import io,re,sys,os
from lauto_paths import WORK_DIR, arg
# usage: python manual_fixes.py [decompiled solution dir]   (default: <work>/src2); one-off fixes for fresh dnSpy output
os.chdir(os.path.join(arg(sys.argv, 1, os.path.join(WORK_DIR, 'src2')), 'iAuto'))
def rw(fn,pairs,regex=False):
    p=fn; s=io.open(p,encoding='utf-8-sig').read()
    for a,b in pairs:
        n=re.sub(a,b,s) if regex else s.replace(a,b)
        if n==s: print('NOCHANGE',fn,a[:50])
        s=n
    io.open(p,'w',encoding='utf-8-sig').write(s)
rw('Control3.cs',[('\t\t\tfor (int i = int_28; i < this.Int32_14 - 1; i++)\n\t\t\t{\n\t\t\t\tif (this.list_0[i + 1].genum18_0 != GEnum18.Hidden)',
                   '\t\t\tint i;\n\t\t\tfor (i = int_28; i < this.Int32_14 - 1; i++)\n\t\t\t{\n\t\t\t\tif (this.list_0[i + 1].genum18_0 != GEnum18.Hidden)')])
rw('Class357.cs',[(r'ref GStruct17 (ptr2?) = ',r'GStruct17 \1 = ')],regex=True)
rw('Class618.cs',[('return this.gparam_0.Contains(value);','return ((ICollection<T>)this.gparam_0).Contains((T)((object)value));'),
                  ('return this.gparam_0.Contains(item);','return ((ICollection<T>)this.gparam_0).Contains(item);'),
                  ('return this.gparam_0.IndexOf(value);','return Array.IndexOf(this.gparam_0, value);'),
                  ('return this.gparam_0.IndexOf(item);','return Array.IndexOf<T>(this.gparam_0, item);'),
                  ('return this.gparam_0.GetEnumerator();','return ((IEnumerable<T>)this.gparam_0).GetEnumerator();')])
rw('Class619.cs',[('\t\t\tthis.Current = gparam_1;','\t\t\tthis.gparam_0 = gparam_1;')])
rw('Class395.cs',[('return ((System.Collections.Generic.IEnumerable<TSource>)this).GetEnumerator();','return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();')])
rw('GClass4.cs',[('return string_1.smethod_6();','return GClass4.smethod_6(string_1);')])
rw('GUI.cs',[('(int)Math.Floor(this.int_0 / this.int_1)','(int)Math.Floor((double)(this.int_0 / this.int_1))'),
             ('\t\t\t\t\t\tnum / num2 * 100m;\n',''),
             ('RuntimeHelpers.InitializeArray(array = new int[4], fieldof(Class617.CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72).FieldHandle);','array = new int[] { 1, 2, 3, 4 };')])
rw('Class106.cs',[('\t\t\tValueTuple<int, int> valueTuple2;\n','\t\t\tValueTuple<int, int> valueTuple2 = default(ValueTuple<int, int>);\n')])
rw('Class19.cs',[('.smethod_63(GEnum1.Big) : 1005)','.smethod_63(GEnum1.Big) : (ushort)1005)')])
rw('Class11.cs',[('''				flag = true;
				IL_0076:
				if (!flag)
				{
					throw new GException0("The length of header part is greater than the max length.");
				}
				return Encoding.UTF8.GetString(@class.list_0.ToArray()).Replace("\r\n ", " ").Replace("\r\n\t", " ")
					.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			}
		}
		goto IL_0076;''','''				flag = true;
				break;
			}
		}
		if (!flag)
		{
			throw new GException0("The length of header part is greater than the max length.");
		}
		return Encoding.UTF8.GetString(@class.list_0.ToArray()).Replace("\r\n ", " ").Replace("\r\n\t", " ")
			.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);'''),
  ('''		catch (Exception ex)
		{
		}''','''		catch (Exception ex2)
		{
			ex = ex2;
		}''')])
