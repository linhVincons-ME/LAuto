# goto L right after a loop whose body contains 'L:' at body level -> break out and move tail after loop
import io,re,collections
errs=collections.defaultdict(list)
import sys
from lauto_paths import ERRORS_FILE, arg
# usage: python loopexit_fix.py [errors.txt]   (default: <work>/errors.txt)
for e in io.open(arg(sys.argv, 1, ERRORS_FILE),encoding='utf-8',errors='replace'):
    m=re.match(r"(.*\.cs)\((\d+),\d+\): error CS0159: No such label '(\w+)'",e.strip())
    if m: errs[m.group(1)].append((int(m.group(2)),m.group(3)))
for fn,lst in errs.items():
    L=io.open(fn,encoding='utf-8-sig').read().split('\n')
    for ln,lab in sorted(lst,key=lambda x:-x[0]):
        g=ln-1
        if L[g].strip()!='goto %s;'%lab or L[g-1].strip()!='}': print('nomatch',fn,ln); continue
        close_ind=re.match(r'\s*',L[g-1]).group(0)
        cand=[i for i in range(g-1,max(0,g-400),-1) if L[i].strip()==lab+':']
        if not cand or re.match(r'\s*',L[cand[0]]).group(0)!=close_ind+'\t': print('indent',fn,ln); continue
        lab_i=cand[0]
        # find loop header for the closing brace
        depth=0; hdr=None
        for i in range(g-1,-1,-1):
            depth+=L[i].count('}')-L[i].count('{')
            if depth==0:
                hdr=L[i-1].strip() if L[i].strip()=='{' else L[i].strip(); break
        if not re.match(r'^(while|for|foreach|do)\b',hdr or ''): print('notloop',fn,ln,hdr); continue
        body=[b[1:] if b.startswith('\t') else b for b in L[lab_i+1:g-1]]
        L[lab_i:g+1]=[close_ind+'\tbreak;',close_ind+'}']+body
        print('fixed',fn,ln)
    io.open(fn,'w',encoding='utf-8-sig').write('\n'.join(L))
