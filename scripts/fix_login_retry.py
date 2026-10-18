# Restore the retry loop in LoginiAuto.method_1 that goto-inlining turned into a single extra attempt
import io, os, sys
from lauto_paths import WORK_DIR, arg
# usage: python fix_login_retry.py [solution dir]   (default: <work>/src2; src/ already has this fix)
p = os.path.join(arg(sys.argv, 1, os.path.join(WORK_DIR, 'src2')), 'iAuto', 'LoginiAuto.cs')
L = io.open(p, encoding='utf-8-sig').read().split('\n')
m = [i for i, l in enumerate(L) if 'private void method_1()' in l][0]
t = [i for i in range(m, m + 30) if L[i].strip() == 'try' and L[i + 2].strip() == 'IL_0030:'][0]
sl = [i for i in range(t, len(L)) if L[i].strip() == 'Thread.Sleep(100);'][0]
end = [i for i in range(sl, len(L)) if L[i].rstrip() == '\t}'][0]   # method's closing brace
block = [b for b in L[t:sl + 1] if b.strip() != 'IL_0030:']
L[t:end] = ['\t\tfor (;;)', '\t\t{'] + ['\t' + b for b in block] + ['\t\t}']
io.open(p, 'w', encoding='utf-8-sig').write('\n'.join(L))
print('fixed lines', t + 1, end + 1)
