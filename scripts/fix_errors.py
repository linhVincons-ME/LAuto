# Error-driven fixes for dnSpy output; edits files bottom-up so line numbers stay valid
import io,re,sys,collections
errs=collections.defaultdict(list)
import sys
from lauto_paths import ERRORS_FILE, arg
# usage: python fix_errors.py [errors.txt]   (default: <work>/errors.txt)
for e in io.open(arg(sys.argv, 1, ERRORS_FILE),encoding='utf-8',errors='replace'):
    m=re.match(r'(.*\.cs)\((\d+),(\d+)\): error (CS\d+): (.*)',e.strip())
    if m: errs[m.group(1)].append((int(m.group(2)),m.group(4),m.group(5)))
def block_after(L,i):
    # statements after label line i until its enclosing block closes
    depth=0; out=[]
    for j in range(i+1,len(L)):
        t=L[j]; d=t.count('{')-t.count('}')
        if depth+d<0 or (t.strip()=='}' and depth==0): return out,j
        depth+=d; out.append(t)
    return None,None
def top_level_jump(body):
    # break/continue not enclosed by a loop or switch that is itself inside the copied block
    stack=[]; prev=''
    for t in body:
        st=t.strip()
        if st=='{': stack.append(prev)
        elif st=='}': stack and stack.pop()
        elif re.search(r'\b(break|continue);',st):
            if not any(re.match(r'^(while|for|foreach|do|switch)\b',h) for h in stack): return True
        if st: prev=st
    return False
for fn,lst in errs.items():
    L=io.open(fn,encoding='utf-8-sig').read().split('\n')
    done=set()
    for (ln,code,msg) in sorted(lst,key=lambda x:-x[0]):
        i=ln-1
        if (i,code) in done: continue
        done.add((i,code)); s=L[i]
        if code=='CS0159':
            lab=re.search(r"label '(\w+)'",msg).group(1)
            li=[k for k,t in enumerate(L) if t.strip()==lab+':']
            if len(li)!=1: print('skip goto',fn,ln); continue
            body,end=block_after(L,li[0])
            if not body: print('skip goto2',fn,ln); continue
            last=[t for t in body if t.strip()][-1].strip()
            if not re.match(r'^(return\b|throw\b|goto\b)',last) or any(re.match(r'\s*IL_\w+:',t) for t in body) or top_level_jump(body):
                print('unsafe goto',fn,ln,lab,last[:40]); continue
            ind=re.match(r'\s*',s).group(0); bind=re.match(r'\s*',body[0]).group(0) if body else ind
            new=[ind+'{']+[ind+'\t'+t[len(bind):] if t.startswith(bind) else t for t in body]+[ind+'}']
            L[i:i+1]=new
        elif code=='CS0201' and re.match(r'^\s*[\w.@]+ == ".*";\s*$',s): L[i]=''
        elif code=='CS0019' and '> false' in s: L[i]=re.sub(r'\((\w+) > false\)',r'(\1)',s)
        elif code=='CS0266' and "to 'byte'" in msg:
            m=re.match(r'^(\s*)(.+?) = (.+);$',s)
            if m and not m.group(2).startswith('byte '): L[i]=f'{m.group(1)}{m.group(2)} = (byte)({m.group(3)});'
            elif m: L[i]=f'{m.group(1)}{m.group(2)} = (byte)({m.group(3)});'
        elif code=='CS1674':
            m=re.match(r'^(\s*)using \((.+)\)\s*$',s)
            if m: L[i]=f'{m.group(1)}{m.group(2)};'
        elif code=='CS1061' and 'this.System.' in s:
            L[i]=re.sub(r'this\.(System\.[\w.<>, ]+?)\.(\w+)\(\)',lambda mm:'(('+mm.group(1)+')this).'+mm.group(2)+'()',s)
        elif code=='CS0171':
            # struct constructor: assign default first
            for k in range(i,min(i+3,len(L))):
                if L[k].strip()=='{': L.insert(k+1,L[k].replace('{','\tthis = default;')); break
    io.open(fn,'w',encoding='utf-8-sig').write('\n'.join(L))
