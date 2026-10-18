# Print the IL right after each ldstr of a given literal, to see whether its result is used or dropped.
# Usage: show_il_around.ps1 -Asm <exe> -Literal <text> [-Count 4] [-Dnlib <dnlib.dll>]
param([string]$Asm, [string]$Literal, [int]$Count = 4, [string]$Dnlib)
$lautoRoot = if ($env:LAUTO_ROOT) { $env:LAUTO_ROOT } else { Split-Path -Parent $PSScriptRoot }
$toolsDir = if ($env:LAUTO_TOOLS) { $env:LAUTO_TOOLS } else { Join-Path (Split-Path -Parent $lautoRoot) 'tools' }
if (-not $Dnlib) { $Dnlib = if ($env:DNLIB) { $env:DNLIB } else { Join-Path $toolsDir 'de4dot\bin\dnlib.dll' } }
Add-Type -Path $Dnlib
$mod = [dnlib.DotNet.ModuleDefMD]::Load($Asm)
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) {
        if (-not $m.HasBody) { continue }
        $ins = $m.Body.Instructions
        for ($i = 0; $i -lt $ins.Count; $i++) {
            if ($ins[$i].OpCode.Code -eq [dnlib.DotNet.Emit.Code]::Ldstr -and [string]$ins[$i].Operand -eq $Literal) {
                $seq = for ($j = [Math]::Max(0, $i - 1); $j -le [Math]::Min($ins.Count - 1, $i + $Count); $j++) { "$($ins[$j].OpCode.Name) $($ins[$j].Operand)" }
                "$($t.FullName)::$($m.Name): " + ($seq -join ' | ')
            }
        }
    }
}
