# List gotos in the raw decompiled source (src2) whose label is out of scope -- the ones we had to rewrite --
# and flag the risky ones: backward jumps (loops) and jumps into a try block from outside it.
import io, re, glob, sys

import os
from lauto_paths import WORK_DIR, arg
# usage: python audit_gotos.py [project dir]   (default: <work>/src2/iAuto)
root = arg(sys.argv, 1, os.path.join(WORK_DIR, 'src2', 'iAuto'))
strip = re.compile(r'"(?:[^"\\]|\\.)*"|\'(?:[^\'\\]|\\.)*\'')

for fn in sorted(glob.glob(root + '/**/*.cs', recursive=True)):
    L = io.open(fn, encoding='utf-8-sig').read().split('\n')
    # block id per line: stack of (open line index, header text)
    stack, blocks, prev = [], [], ''
    for i, raw in enumerate(L):
        t = strip.sub('""', raw).strip()
        blocks.append(tuple(stack))
        for ch in t:
            if ch == '{': stack.append((i, prev))
            elif ch == '}' and stack: stack.pop()
        if t: prev = t
    labels = {}
    for i, raw in enumerate(L):
        m = re.match(r'\s*(IL_\w+|Block_\d+):', raw)
        if m: labels.setdefault(m.group(1), []).append(i)
    for i, raw in enumerate(L):
        m = re.search(r'\bgoto (IL_\w+|Block_\d+);', raw)
        if not m: continue
        cands=[li for li in labels.get(m.group(1), []) if abs(li-i)<400]
        for li in cands:
            lb, gb = blocks[li], blocks[i]
            if gb[:len(lb)] == lb:  # label block encloses goto: legal
                continue
            back = li < i
            tries = [h for (_, h) in lb[len(set(lb) & set(gb)):] if h == 'try']
            into_try = any(h == 'try' for (_, h) in lb if (_, h) not in gb)
            kind = []
            own=[h for (_, h) in lb if (_, h) not in gb]
            inloop=any(re.match(r'^(while|for|foreach|do)',h) for h in own)
            if back and not inloop: kind.append('RETRY-LOOP')
            elif back: kind.append('loop-exit')
            if into_try: kind.append('INTO-TRY')
            print('%s:%d -> %s@%d %s' % (fn.split('/')[-1].split('\\')[-1], i + 1, m.group(1), li + 1, ' '.join(kind) or 'forward'))
