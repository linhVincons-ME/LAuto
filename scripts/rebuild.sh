#!/bin/bash
# Full pipeline from the original iAuto.exe: de4dot -> sanitize names -> dnSpy -> automatic patches -> build.
# Usage: rebuild.sh [original iAuto.exe]
#   The original exe is only needed when <work>/iAuto-clean2.exe does not exist yet.
#   Output goes to <work>/src2; the hand-fixed, buildable source stays in src/ and is not touched.
source "$(dirname "${BASH_SOURCE[0]}")/config.sh"

CLEAN="$WORK_DIR/iAuto-clean.exe"
CLEAN2="$WORK_DIR/iAuto-clean2.exe"

if [ ! -f "$CLEAN2" ]; then
    ORIG="${1:-$LAUTO_ORIGINAL_EXE}"
    require "original exe (pass it as argument or set LAUTO_ORIGINAL_EXE)" "$ORIG"
    require "de4dot" "$DE4DOT"; require "dnlib" "$DNLIB"
    cp "$ORIG" "$WORK_DIR/iAuto.exe"
    "$DE4DOT" "$(cygpath -w "$WORK_DIR/iAuto.exe")" -o "$(cygpath -w "$CLEAN")" || exit 1
    powershell -NoProfile -ExecutionPolicy Bypass -File "$(cygpath -w "$SCRIPTS_DIR/sanitize.ps1")" \
        -In "$(cygpath -w "$CLEAN")" -Out "$(cygpath -w "$CLEAN2")" -Dnlib "$(cygpath -w "$DNLIB")" || exit 1
fi

require "dnSpy.Console" "$DNSPY"
rm -rf "$WORK_DIR/src2"
"$DNSPY" --no-yield --no-async -o "$(cygpath -w "$WORK_DIR/src2")" "$(cygpath -w "$CLEAN2")" > /dev/null 2>&1
python "$SCRIPTS_DIR/patch_src.py" "$WORK_DIR/src2"
msbuild_solution "$WORK_DIR/src2" "$WORK_DIR/build.log"
n=$(collect_errors "$WORK_DIR/build.log" "$WORK_DIR/errors.txt")
echo "$n error(s) in $WORK_DIR/src2 (errors: $WORK_DIR/errors.txt)"
echo "Next: python fix_errors.py, loopexit_fix.py, loopexit2.py, then build_only.sh \"$WORK_DIR/src2\" and repeat"
