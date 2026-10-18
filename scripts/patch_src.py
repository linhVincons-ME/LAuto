# Manual fixes for decompiler output that does not compile
import io,sys
import os
from lauto_paths import WORK_DIR, arg
# usage: python patch_src.py [decompiled solution dir]   (default: <work>/src2)
root=arg(sys.argv, 1, os.path.join(WORK_DIR, 'src2'))
def patch(fn, pairs):
    p=root+'/iAuto/'+fn; s=io.open(p,encoding='utf-8-sig').read()
    for a,b in pairs:
        if a not in s: print('MISSING in',fn,':',a[:60]); continue
        s=s.replace(a,b)
    io.open(p,'w',encoding='utf-8-sig').write(s)
patch('GClass12.cs',[('<>9__33_0','_9__33_0'),('<>9','_9'),
  ('\tprivate sealed class Class44<T> where T : GClass9, new()\n\t{\n',
   '\tprivate sealed class Class44<T> where T : GClass9, new()\n\t{\n\t\tpublic static readonly GClass12.Class44<T> _9;\n\t\tpublic static Func<T> _9__33_0;\n')])
s=io.open(root+'/iAuto/Control3.cs',encoding='utf-8-sig').read().splitlines(True)
for i,l in enumerate(s):
    if '"WordWrapControlWidth")]' in l and 'typeof(' in l:
        s[i]='\t[DefaultValue(typeof(GEnum12), "WordWrapControlWidth")]\n'
io.open(root+'/iAuto/Control3.cs','w',encoding='utf-8-sig').write(''.join(s))
# dnSpy emits TupleElementNames attributes explicitly; C# forbids that
import re,glob
for p in glob.glob(root+'/iAuto/**/*.cs',recursive=True):
    s=io.open(p,encoding='utf-8-sig').read()
    n=re.sub(r'\[(return: )?TupleElementNames\(new string\[\][^\]]*\}\)\]\s*','',s)
    n=re.sub(r'\[(return: )?TupleElementNames\(new string\[\]\s*\{[^}]*\}\)\]\s*','',n)
    if n!=s: io.open(p,'w',encoding='utf-8-sig').write(n)
# Remaining one-off fixes
def lines_patch(fn, func):
    p=root+'/iAuto/'+fn; L=io.open(p,encoding='utf-8-sig').read().split('\n'); L=func(L); io.open(p,'w',encoding='utf-8-sig').write('\n'.join(L))
for fn in ['CheckBoxComboControl.Designer.cs','CheckBoxNumberControl.Designer.cs']:
    lines_patch(fn, lambda L: [l for i,l in enumerate(L) if not (i<4 and 'DefaultProperty("Text")' in l)])
patch('Class210.cs',[('[param: TupleElementNames(new string[] { "Key", "Value" })]\n','')])
def second_override(L):
    hits=[i for i,l in enumerate(L) if 'internal override string m_C16EB083()' in l]
    if len(hits)==2: L[hits[1]]=L[hits[1]].replace('m_C16EB083()','m_C16EB083_2()')
    return L
lines_patch('Class52.cs',second_override); lines_patch('Class53.cs',second_override)
patch('Class95.cs',[('\tprivate struct Struct13','\tinternal struct Struct13')])
patch('GClass32.cs',[('\tprivate struct Struct19','\tinternal struct Struct19')])
for fn in ['GClass27.cs','GException1.cs']:
    patch(fn,[('Flags = 128)]','Flags = SecurityPermissionFlag.SerializationFormatter)]'),('Flags = 128, ','')])
