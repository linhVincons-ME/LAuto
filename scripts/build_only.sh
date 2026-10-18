#!/bin/bash
# Build the decompiled source (src/) without decompiling again.
# Usage: build_only.sh [source dir]   (default: $LAUTO_SRC or <LAuto>/src)
source "$(dirname "${BASH_SOURCE[0]}")/config.sh"
SRC="${1:-$SRC_DIR}"
require "solution" "$SRC/solution.sln"
msbuild_solution "$SRC" "$WORK_DIR/build.log"
n=$(collect_errors "$WORK_DIR/build.log" "$WORK_DIR/errors.txt")
echo "$n error(s); log: $WORK_DIR/build.log"
[ "$n" -eq 0 ] && echo "output: $SRC/iAuto/bin/Release/iAuto.exe"
