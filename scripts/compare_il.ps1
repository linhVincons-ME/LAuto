# Compare two builds of iAuto method by method: string literals and the set of methods each one calls.
# Usage: compare_il.ps1 -A <reference exe> -B <rebuilt exe> [-Dnlib <dnlib.dll>] [-Out <report.txt>]
param([string]$A, [string]$B, [string]$Dnlib, [string]$Out)
$lautoRoot = if ($env:LAUTO_ROOT) { $env:LAUTO_ROOT } else { Split-Path -Parent $PSScriptRoot }
$toolsDir = if ($env:LAUTO_TOOLS) { $env:LAUTO_TOOLS } else { Join-Path (Split-Path -Parent $lautoRoot) 'tools' }
if (-not $Dnlib) { $Dnlib = if ($env:DNLIB) { $env:DNLIB } else { Join-Path $toolsDir 'de4dot\bin\dnlib.dll' } }
if (-not $Out) { $Out = Join-Path $lautoRoot 'work\compare_il.txt' }
Add-Type -Path $Dnlib

# Calls the C# compiler is free to emit differently; they say nothing about behaviour
$noise = '^(System\.String::(op_Equality|op_Inequality|Equals|Concat|get_Length|ComputeStringHash)|.*::ComputeStringHash|System\.Object::\.ctor|System\.Runtime\.CompilerServices\.RuntimeHelpers::.*|System\.Math::Floor|System\.Delegate::(Combine|Remove)|System\.Threading\.Interlocked::CompareExchange.*|System\.IDisposable::Dispose|System\.Collections\.IEnumerator::MoveNext|System\.Type::GetTypeFromHandle)$'

function Index($path) {
    $m = [dnlib.DotNet.ModuleDefMD]::Load($path)
    $h = @{}
    foreach ($t in $m.GetTypes()) {
        foreach ($md in $t.Methods) {
            if (-not $md.HasBody) { continue }
            $strs = New-Object System.Collections.Generic.List[string]
            $calls = New-Object System.Collections.Generic.HashSet[string]
            foreach ($ins in $md.Body.Instructions) {
                if ($ins.OpCode.Code -eq [dnlib.DotNet.Emit.Code]::Ldstr) { $strs.Add([string]$ins.Operand) }
                elseif ($ins.OpCode.FlowControl -eq [dnlib.DotNet.Emit.FlowControl]::Call -and $ins.Operand -is [dnlib.DotNet.IMethod]) {
                    $op = $ins.Operand
                    $name = (($op.DeclaringType.FullName -split '<')[0] -replace '`\d+', '') + '::' + $op.Name
                    if ($name -notmatch $noise) { [void]$calls.Add($name) }
                }
            }
            $k = $t.FullName + '::' + $md.Name + '|' + $md.Parameters.Count
            $h[$k] = @(@($strs | Sort-Object -Unique), $calls)
        }
    }
    return $h
}
$ha = Index $A; $hb = Index $B
$lines = New-Object System.Collections.Generic.List[string]
$onlyA = @($ha.Keys | Where-Object { -not $hb.ContainsKey($_) } | Sort-Object)
$onlyB = @($hb.Keys | Where-Object { -not $ha.ContainsKey($_) } | Sort-Object)
$strDiff = 0; $callDiff = 0
foreach ($k in ($ha.Keys | Sort-Object)) {
    if (-not $hb.ContainsKey($k)) { continue }
    $sa = $ha[$k][0]; $sb = $hb[$k][0]
    $missS = @($sa | Where-Object { $sb -notcontains $_ }); $addS = @($sb | Where-Object { $sa -notcontains $_ })
    $ca = $ha[$k][1]; $cb = $hb[$k][1]
    $missC = @($ca | Where-Object { -not $cb.Contains($_) }); $addC = @($cb | Where-Object { -not $ca.Contains($_) })
    if ($missS.Count -or $addS.Count) { $strDiff++ }
    if ($missC.Count -or $addC.Count) { $callDiff++ }
    if ($missS.Count -or $addS.Count -or $missC.Count -or $addC.Count) {
        $lines.Add("== $k")
        foreach ($s in $missS) { $lines.Add("   - str  $s") }; foreach ($s in $addS) { $lines.Add("   + str  $s") }
        foreach ($c in $missC) { $lines.Add("   - call $c") }; foreach ($c in $addC) { $lines.Add("   + call $c") }
    }
}
$head = @("A: $A", "B: $B", "methods with body: A=$($ha.Count) B=$($hb.Count)", "only in A: $($onlyA.Count)  only in B: $($onlyB.Count)",
          "methods whose string literals differ: $strDiff", "methods whose callees differ: $callDiff", "")
$head += ($onlyA | ForEach-Object { "only A: $_" }); $head += ($onlyB | ForEach-Object { "only B: $_" }); $head += ''
[IO.File]::WriteAllLines($Out, [string[]]($head + $lines))
$head[0..5]
"report: $Out"
