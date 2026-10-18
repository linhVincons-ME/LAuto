# Usage: sanitize.ps1 -In <de4dot output> -Out <sanitized exe> [-Dnlib <dnlib.dll>]
# Defaults: <work>\iAuto-clean.exe -> <work>\iAuto-clean2.exe; dnlib from $env:DNLIB or <LAuto>\..\tools.
param([string]$In, [string]$Out, [string]$Dnlib)
$lautoRoot = if ($env:LAUTO_ROOT) { $env:LAUTO_ROOT } else { Split-Path -Parent $PSScriptRoot }
$workDir = if ($env:LAUTO_WORK) { $env:LAUTO_WORK } else { Join-Path $lautoRoot 'work' }
$toolsDir = if ($env:LAUTO_TOOLS) { $env:LAUTO_TOOLS } else { Join-Path (Split-Path -Parent $lautoRoot) 'tools' }
if (-not $In) { $In = Join-Path $workDir 'iAuto-clean.exe' }
if (-not $Out) { $Out = Join-Path $workDir 'iAuto-clean2.exe' }
if (-not $Dnlib) { $Dnlib = if ($env:DNLIB) { $env:DNLIB } else { Join-Path $toolsDir 'de4dot\bin\dnlib.dll' } }
foreach ($p in @($In, $Dnlib)) { if (-not (Test-Path $p)) { throw "Missing: $p" } }
Add-Type -Path $Dnlib
$mod = [dnlib.DotNet.ModuleDefMD]::Load($In)
$valid = '^[A-Za-z_][A-Za-z0-9_]*$'
$map = @{}
$md5 = [System.Security.Cryptography.MD5]::Create()
function NewName([string]$prefix, [string]$old) {
    $key = "$prefix|$old"
    if (-not $map.ContainsKey($key)) {
        $h = $md5.ComputeHash([System.Text.Encoding]::UTF8.GetBytes($old))
        $map[$key] = $prefix + '_' + ([BitConverter]::ToString($h, 0, 4) -replace '-', '')
    }
    return $map[$key]
}
$count = 0
$oldTypeNames = @{}
foreach ($t in $mod.GetTypes()) { $oldTypeNames[$t] = $t.FullName }
# Signatures captured before any rename so defs and refs get the same key
$sigOf = New-Object 'System.Collections.Generic.Dictionary[object,string]'
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) { $sigOf[$m] = [string]$m.MethodSig }
    foreach ($f in $t.Fields) { $sigOf[$f] = [string]$f.FieldSig }
    foreach ($p in $t.Properties) { $sigOf[$p] = [string]$p.PropertySig }
}
foreach ($mr in $mod.GetMemberRefs()) { if ($mr.IsFieldRef) { $sigOf[$mr] = [string]$mr.FieldSig } else { $sigOf[$mr] = [string]$mr.MethodSig } }
foreach ($t in $mod.GetTypes()) {
    if ($t.Name -ne '<Module>' -and $t.Name.String -notmatch $valid) {
        $base = ($t.Name.String -split '`')[0]
        if ($base -notmatch $valid) { $t.Name = (NewName 'T' $t.Name.String); $count++ }
    }
    if ($t.Namespace.String -and ($t.Namespace.String -split '\.' | Where-Object { $_ -notmatch $valid })) { $t.Namespace = 'NS'; $count++ }
    foreach ($m in $t.Methods) {
        if ($m.IsConstructor) { continue }
        if ($m.Name.String -notmatch $valid) {
            # Explicit interface implementations keep dotted names; sanitize only the last part
            $m.Name = (NewName 'm' ($m.Name.String + '|' + $sigOf[$m])); $count++
        }
        foreach ($p in $m.ParamDefs) { if ($p.Name.String -and $p.Name.String -notmatch $valid) { $p.Name = "p$($p.Sequence)"; $count++ } }
        foreach ($g in $m.GenericParameters) { if ($g.Name.String -notmatch $valid) { $g.Name = "TM$($g.Number)"; $count++ } }
    }
    foreach ($g in $t.GenericParameters) { if ($g.Name.String -notmatch $valid) { $g.Name = "TT$($g.Number)"; $count++ } }
    foreach ($f in $t.Fields) { if ($f.Name.String -notmatch $valid) { $f.Name = (NewName 'f' ($f.Name.String + '|' + $sigOf[$f])); $count++ } }
    foreach ($p in $t.Properties) { if ($p.Name.String -notmatch $valid -and $p.Name.String -ne 'Item') { $p.Name = (NewName 'P' ($p.Name.String + '|' + $sigOf[$p])); $count++ } }
    foreach ($e in $t.Events) { if ($e.Name.String -notmatch $valid) { $e.Name = (NewName 'E' $e.Name.String); $count++ } }
}
# Methods that explicitly override something: name them the way the C# compiler would
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) {
        if (-not $m.HasOverrides -or $m.Overrides.Count -ne 1) { continue }
        $decl = $m.Overrides[0].MethodDeclaration
        $dtd = $null
        try { $dtd = [dnlib.DotNet.Extensions]::ResolveTypeDef($decl.DeclaringType) } catch { }
        $declName = $decl.Name.String
        $isIf = ($dtd -ne $null -and $dtd.IsInterface) -or ($decl.DeclaringType.FullName -match '^System\.(IDisposable$|Collections\.(Generic\.)?I[A-Z])')
        if ($isIf) {
            $ifName = ($decl.DeclaringType.FullName -replace '/', '.') -replace '`\d+', ''
            $want = "$ifName.$declName"
            if ($ifName -match '\[') { continue }
            # Iterator classes call these members on 'this'; make them implicit public implementations
            $ifDef = ($decl.DeclaringType.FullName -split '<')[0]
            if ($ifDef -eq 'System.IDisposable' -or $ifDef -eq 'System.Collections.Generic.IEnumerable`1' -or $ifDef -eq 'System.Collections.Generic.IEnumerator`1') {
                $want = $declName
                $m.Attributes = [dnlib.DotNet.MethodAttributes](([int]$m.Attributes -band (-bnot 7)) -bor 6)
            }
        } else { $want = $declName }
        if ($m.Name.String -ne $want) { $m.Name = $want; $count++ }
    }
}
# Same name and same signature inside one type is legal IL but not C#: number the duplicates
foreach ($t in $mod.GetTypes()) {
    $seen = @{}
    foreach ($m in ($t.Methods | Sort-Object { $_.Rid })) {
        if ($m.IsConstructor -or $m.HasOverrides) { continue }
        $k = $m.Name.String + '|' + $sigOf[$m]
        if ($seen.ContainsKey($k)) { $seen[$k]++; $m.Name = $m.Name.String + '_' + $seen[$k]; $count++ } else { $seen[$k] = 1 }
    }
}
# Properties/events take the name implied by their (possibly overriding) accessors
foreach ($t in $mod.GetTypes()) {
    foreach ($p in $t.Properties) {
        $acc = $p.GetMethod; if ($acc -eq $null) { $acc = $p.SetMethod }
        if ($acc -eq $null) { continue }
        if ($acc.Name.String -match '^(.*\.)?[gs]et_(.+)$') { $want = $Matches[1] + $Matches[2]; if ($p.Name.String -ne $want) { $p.Name = $want; $count++ } }
        elseif ($p.Name.String -match '^P_') { $p.Name = 'P_' + $acc.Name.String; $count++ }
    }
    foreach ($e in $t.Events) {
        $acc = $e.AddMethod
        if ($acc -ne $null -and $acc.Name.String -match '^(.*\.)?add_(.+)$') { $want = $Matches[1] + $Matches[2]; if ($e.Name.String -ne $want) { $e.Name = $want; $count++ } }
    }
}
# MemberRefs to members of generic types defined here (e.g. Class44<T>.<>9) carry their own names
foreach ($mr in $mod.GetMemberRefs()) {
    $dt = $mr.DeclaringType
    if ($dt -eq $null) { continue }
    $td = $null
    try { $td = [dnlib.DotNet.Extensions]::ResolveTypeDef($dt) } catch { }
    if ($td -eq $null -or $td.Module -ne $mod) { continue }
    if ($mr.Name.String -notmatch $valid -and $mr.Name.String -ne '.ctor' -and $mr.Name.String -ne '.cctor') {
        if ($mr.IsFieldRef) { $mr.Name = (NewName 'f' ($mr.Name.String + '|' + $sigOf[$mr])) } else { $mr.Name = (NewName 'm' ($mr.Name.String + '|' + $sigOf[$mr])) }
        $count++
    }
}
# Resources: follow renamed types; give other unusable names a safe name and patch string references
$typeRen = @{}
foreach ($t in $mod.GetTypes()) { if ($oldTypeNames[$t] -ne $t.FullName) { $typeRen[$oldTypeNames[$t]] = $t.FullName } }
$resRen = @{}
foreach ($r in $mod.Resources) {
    $n = $r.Name.String
    if (-not $n.EndsWith('.resources')) { continue }
    $base = $n.Substring(0, $n.Length - 10)
    if ($typeRen.ContainsKey($base)) { $r.Name = $typeRen[$base] + '.resources'; $count++ }
    elseif ($base -notmatch '^[A-Za-z0-9_.]+$') { $nb = (NewName 'Res' $base); $resRen[$base] = $nb; $r.Name = $nb + '.resources'; $count++ }
}
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) {
        if (-not $m.HasBody) { continue }
        foreach ($ins in $m.Body.Instructions) {
            if ($ins.OpCode.Code -eq [dnlib.DotNet.Emit.Code]::Ldstr -and $resRen.ContainsKey([string]$ins.Operand)) { $ins.Operand = $resRen[[string]$ins.Operand]; $count++ }
        }
    }
}
$opts = New-Object dnlib.DotNet.Writer.ModuleWriterOptions($mod)
$opts.MetadataOptions.Flags = $opts.MetadataOptions.Flags -bor [dnlib.DotNet.Writer.MetadataFlags]::KeepOldMaxStack
$mod.Write($Out, $opts)
"renamed $count"
