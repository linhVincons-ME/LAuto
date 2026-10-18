#!/bin/bash
# Shared paths for the LAuto scripts. Every value can be overridden with an environment variable;
# the defaults are resolved relative to this folder so the whole LAuto tree can be moved anywhere.

SCRIPTS_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
LAUTO_ROOT="${LAUTO_ROOT:-$(cd "$SCRIPTS_DIR/.." && pwd)}"
SRC_DIR="${LAUTO_SRC:-$LAUTO_ROOT/src}"
WORK_DIR="${LAUTO_WORK:-$LAUTO_ROOT/work}"
TOOLS_DIR="${LAUTO_TOOLS:-$LAUTO_ROOT/../tools}"

DNSPY="${DNSPY:-$TOOLS_DIR/dnSpy/dnSpy.Console.exe}"
DE4DOT="${DE4DOT:-$TOOLS_DIR/de4dot/de4dot-x64.exe}"
DNLIB="${DNLIB:-$TOOLS_DIR/de4dot/bin/dnlib.dll}"

# MSBuild: explicit override, otherwise ask vswhere for the newest Visual Studio / Build Tools install
if [ -z "$MSBUILD" ]; then
    PF86="$(printenv 'ProgramFiles(x86)')"
    VSWHERE="$(cygpath -u "${PF86:-C:\\Program Files (x86)}")/Microsoft Visual Studio/Installer/vswhere.exe"
    if [ -f "$VSWHERE" ]; then
        MSBUILD="$("$VSWHERE" -latest -products '*' -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | head -n 1 | tr -d '\r')"
        [ -n "$MSBUILD" ] && MSBUILD="$(cygpath -u "$MSBUILD")"
    fi
fi

# Reference assemblies: the installed .NET Framework 4.x runtime, so no targeting pack is needed
FRAMEWORK_DIR="${FRAMEWORK_DIR:-$(cygpath -w "${WINDIR:-/c/Windows}" 2>/dev/null || echo 'C:\Windows')\\Microsoft.NET\\Framework64\\v4.0.30319}"

mkdir -p "$WORK_DIR"
export LAUTO_ROOT SRC_DIR WORK_DIR TOOLS_DIR DNSPY DE4DOT DNLIB MSBUILD FRAMEWORK_DIR

require() {
    # require <description> <path>
    if [ ! -e "$2" ]; then echo "Missing $1: $2" >&2; exit 1; fi
}

msbuild_solution() {
    # msbuild_solution <dir containing solution.sln> <log file>
    require "MSBuild (set MSBUILD=...)" "$MSBUILD"
    (cd "$1" && "$MSBUILD" solution.sln -nologo -v:m -p:Configuration=Release \
        -p:FrameworkPathOverride="$FRAMEWORK_DIR" -p:LangVersion=latest) > "$2" 2>&1
}

collect_errors() {
    # collect_errors <log file> <errors file>; prints the error count
    grep -E " error " "$1" | sed -E 's/ \[[A-Za-z]:[^]]*\]$//' | sort -u > "$2"
    wc -l < "$2"
}
