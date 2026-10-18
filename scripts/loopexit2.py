# goto L after a loop; 'L:' nested in if/else inside that loop; tail ends with return/throw
import io,re,collections
errs=collections.defaultdict(list)
import sys
from lauto_paths import ERRORS_FILE, arg
# usage: python loopexit2.py [errors.txt]   (default: <work>/errors.txt)
for e in io.open(arg(sys.argv, 1, ERRORS_FILE),encoding='utf-8',errors='replace'):
    m=re.match(r"(.*\.cs)\((\d+),\d+\): error CS0159: No such label '(\w+)'",e.strip())
    if m: errs[m.group(1)].append((int(m.group(2)),m.group(3)))
def ind(s): return len(re.match(r'\t*',s).group(0))
for fn,lst in errs.items():
    L=io.open(fn,encoding='utf-8-sig').read().split('\n')
    for ln,lab in sorted(lst,key=lambda x:-x[0]):
        g=ln-1
        if L[g].strip()!='goto %s;'%lab or L[g-1].strip()!='}': print('nomatch',fn,ln); continue
        # loop open brace
        depth=0; ob=None
        for i in range(g-1,-1,-1):
            depth+=L[i].count('}')-L[i].count('{')
            if depth==0: ob=i; break
        hdr=L[ob-1].strip()
        if not re.match(r'^(while|for|foreach)\b',hdr): print('notloop',fn,ln,hdr[:30]); continue
        labs=[i for i in range(ob,g) if L[i].strip()==lab+':']
        if len(labs)!=1: print('nolab',fn,ln); continue
        li=labs[0]
        # headers of blocks enclosing the label inside the loop
        stack=[]
        for i in range(ob+1,li):
            t=L[i].strip()
            if t=='{': stack.append(L[i-1].strip())
            elif t=='}' or t.startswith('}'): stack.pop()
        if any(not re.match(r'^(if\b|else\b|try$)',h) for h in stack): print('badchain',fn,ln,stack); continue
        # tail: label+1 .. end of enclosing block
        d=0; end=None
        for j in range(li+1,g):
            t=L[j]; d+=t.count('{')-t.count('}')
            if d<0: end=j; break
        tail=L[li+1:end]
        last=[t for t in tail if t.strip()][-1].strip()
        if not re.match(r'^(return|throw|goto)',last) or any(re.search(r'\b(break|continue);',t) or re.match(r'\s*IL_\w+:',t) for t in tail): print('unsafe',fn,ln,last[:30]); continue
        k=ind(L[li])-ind(L[g])
        moved=[t[k:] if t.startswith('\t'*k) else t for t in tail]
        L[g:g+1]=moved
        L[li:end]=['\t'*ind(L[li])+'break;']
        print('fixed',fn,ln)
    io.open(fn,'w',encoding='utf-8-sig').write('\n'.join(L))
