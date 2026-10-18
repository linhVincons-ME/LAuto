using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000064 RID: 100
[Serializable]
public class GClass16 : IEnumerable, ICollection
{
	// Token: 0x06000443 RID: 1091 RVA: 0x00005E4E File Offset: 0x0000404E
	public GClass16()
	{
		this._list = new List<GClass15>();
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00005E61 File Offset: 0x00004061
	internal IList<GClass15> IList_0
	{
		get
		{
			return this._list;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000445 RID: 1093 RVA: 0x0002B558 File Offset: 0x00029758
	internal IEnumerable<GClass15> IEnumerable_0
	{
		get
		{
			List<GClass15> list = new List<GClass15>(this._list);
			if (list.Count > 1)
			{
				List<GClass15> list2 = list;
				Comparison<GClass15> comparison;
				if ((comparison = GClass16.Class58.comparison_0) == null)
				{
					comparison = (GClass16.Class58.comparison_0 = new Comparison<GClass15>(GClass16.smethod_1));
				}
				list2.Sort(comparison);
			}
			return list;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00005E69 File Offset: 0x00004069
	public int Count
	{
		get
		{
			return this._list.Count;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000447 RID: 1095 RVA: 0x00005BAB File Offset: 0x00003DAB
	public bool Boolean_0
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x00005E76 File Offset: 0x00004076
	public bool IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000108 RID: 264
	public GClass15 this[int int_0]
	{
		get
		{
			if (int_0 < 0 || int_0 >= this._list.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return this._list[int_0];
		}
	}

	// Token: 0x17000109 RID: 265
	public GClass15 this[string string_0]
	{
		get
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("name");
			}
			foreach (GClass15 gclass in this.IEnumerable_0)
			{
				if (gclass.String_2.Equals(string_0, StringComparison.InvariantCultureIgnoreCase))
				{
					return gclass;
				}
			}
			return null;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x0600044B RID: 1099 RVA: 0x0002B608 File Offset: 0x00029808
	public object SyncRoot
	{
		get
		{
			object obj;
			if ((obj = this._sync) == null)
			{
				obj = (this._sync = ((ICollection)this._list).SyncRoot);
			}
			return obj;
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00005EA4 File Offset: 0x000040A4
	private static int smethod_0(GClass15 gclass15_0, GClass15 gclass15_1)
	{
		return gclass15_0.String_2.Length + gclass15_0.String_5.Length - (gclass15_1.String_2.Length + gclass15_1.String_5.Length);
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x0002B634 File Offset: 0x00029834
	private static int smethod_1(GClass15 gclass15_0, GClass15 gclass15_1)
	{
		int num;
		if ((num = gclass15_0.Int32_2 - gclass15_1.Int32_2) != 0)
		{
			return num;
		}
		if ((num = gclass15_0.String_2.CompareTo(gclass15_1.String_2)) == 0)
		{
			return gclass15_1.String_3.Length - gclass15_0.String_3.Length;
		}
		return num;
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x0002B684 File Offset: 0x00029884
	private static GClass16 smethod_2(string string_0)
	{
		GClass16 gclass = new GClass16();
		GClass15 gclass2 = null;
		int num = 0;
		string[] array = GClass16.smethod_4(string_0);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length != 0)
			{
				if (text.StartsWith("$version", StringComparison.InvariantCultureIgnoreCase))
				{
					num = int.Parse(text.smethod_34('=', true));
				}
				else if (text.StartsWith("$path", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.String_3 = text.smethod_33('=');
					}
				}
				else if (text.StartsWith("$domain", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.String_1 = text.smethod_33('=');
					}
				}
				else if (text.StartsWith("$port", StringComparison.InvariantCultureIgnoreCase))
				{
					string text2 = (text.Equals("$port", StringComparison.InvariantCultureIgnoreCase) ? "\"\"" : text.smethod_33('='));
					if (gclass2 != null)
					{
						gclass2.String_4 = text2;
					}
				}
				else
				{
					if (gclass2 != null)
					{
						gclass.method_4(gclass2);
					}
					string text3 = string.Empty;
					int num2 = text.IndexOf('=');
					string text4;
					if (num2 == -1)
					{
						text4 = text;
					}
					else if (num2 == text.Length - 1)
					{
						text4 = text.Substring(0, num2).TrimEnd(new char[] { ' ' });
					}
					else
					{
						text4 = text.Substring(0, num2).TrimEnd(new char[] { ' ' });
						text3 = text.Substring(num2 + 1).TrimStart(new char[] { ' ' });
					}
					gclass2 = new GClass15(text4, text3);
					if (num != 0)
					{
						gclass2.Int32_2 = num;
					}
				}
			}
		}
		if (gclass2 != null)
		{
			gclass.method_4(gclass2);
		}
		return gclass;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x0002B834 File Offset: 0x00029A34
	private static GClass16 smethod_3(string string_0)
	{
		GClass16 gclass = new GClass16();
		GClass15 gclass2 = null;
		string[] array = GClass16.smethod_4(string_0);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length != 0)
			{
				if (text.StartsWith("version", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.Int32_2 = int.Parse(text.smethod_34('=', true));
					}
				}
				else if (text.StartsWith("expires", StringComparison.InvariantCultureIgnoreCase))
				{
					StringBuilder stringBuilder = new StringBuilder(text.smethod_33('='), 32);
					if (i < array.Length - 1)
					{
						stringBuilder.AppendFormat(", {0}", array[++i].Trim());
					}
					DateTime now;
					if (!DateTime.TryParseExact(stringBuilder.ToString(), new string[] { "ddd, dd'-'MMM'-'yyyy HH':'mm':'ss 'GMT'", "r" }, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out now))
					{
						now = DateTime.Now;
					}
					if (gclass2 != null && gclass2.DateTime_0 == DateTime.MinValue)
					{
						gclass2.DateTime_0 = now.ToLocalTime();
					}
				}
				else if (text.StartsWith("max-age", StringComparison.InvariantCultureIgnoreCase))
				{
					int num = int.Parse(text.smethod_34('=', true));
					DateTime dateTime = DateTime.Now.AddSeconds((double)num);
					if (gclass2 != null)
					{
						gclass2.DateTime_0 = dateTime;
					}
				}
				else if (text.StartsWith("path", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.String_3 = text.smethod_33('=');
					}
				}
				else if (text.StartsWith("domain", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.String_1 = text.smethod_33('=');
					}
				}
				else if (text.StartsWith("port", StringComparison.InvariantCultureIgnoreCase))
				{
					string text2 = (text.Equals("port", StringComparison.InvariantCultureIgnoreCase) ? "\"\"" : text.smethod_33('='));
					if (gclass2 != null)
					{
						gclass2.String_4 = text2;
					}
				}
				else if (text.StartsWith("comment", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.String_0 = text.smethod_33('=').smethod_105();
					}
				}
				else if (text.StartsWith("commenturl", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.Uri_0 = text.smethod_34('=', true).smethod_104();
					}
				}
				else if (text.StartsWith("discard", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.Boolean_1 = true;
					}
				}
				else if (text.StartsWith("secure", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.Boolean_4 = true;
					}
				}
				else if (text.StartsWith("httponly", StringComparison.InvariantCultureIgnoreCase))
				{
					if (gclass2 != null)
					{
						gclass2.Boolean_3 = true;
					}
				}
				else
				{
					if (gclass2 != null)
					{
						gclass.method_4(gclass2);
					}
					string text3 = string.Empty;
					int num2 = text.IndexOf('=');
					string text4;
					if (num2 == -1)
					{
						text4 = text;
					}
					else if (num2 == text.Length - 1)
					{
						text4 = text.Substring(0, num2).TrimEnd(new char[] { ' ' });
					}
					else
					{
						text4 = text.Substring(0, num2).TrimEnd(new char[] { ' ' });
						text3 = text.Substring(num2 + 1).TrimStart(new char[] { ' ' });
					}
					gclass2 = new GClass15(text4, text3);
				}
			}
		}
		if (gclass2 != null)
		{
			gclass.method_4(gclass2);
		}
		return gclass;
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0002BB90 File Offset: 0x00029D90
	private int method_0(GClass15 gclass15_0)
	{
		string string_ = gclass15_0.String_2;
		string string_2 = gclass15_0.String_3;
		string string_3 = gclass15_0.String_1;
		int int32_ = gclass15_0.Int32_2;
		for (int i = this._list.Count - 1; i >= 0; i--)
		{
			GClass15 gclass = this._list[i];
			if (gclass.String_2.Equals(string_, StringComparison.InvariantCultureIgnoreCase) && gclass.String_3.Equals(string_2, StringComparison.InvariantCulture) && gclass.String_1.Equals(string_3, StringComparison.InvariantCultureIgnoreCase) && gclass.Int32_2 == int32_)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00005ED5 File Offset: 0x000040D5
	private static string[] smethod_4(string string_0)
	{
		return new List<string>(string_0.smethod_56(new char[] { ',', ';' })).ToArray();
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00005EF7 File Offset: 0x000040F7
	internal static GClass16 smethod_5(string string_0, bool bool_0)
	{
		if (!bool_0)
		{
			return GClass16.smethod_2(string_0);
		}
		return GClass16.smethod_3(string_0);
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0002BC24 File Offset: 0x00029E24
	internal void method_1(GClass15 gclass15_0)
	{
		int num = this.method_0(gclass15_0);
		if (num == -1)
		{
			if (!gclass15_0.Boolean_2)
			{
				this._list.Add(gclass15_0);
			}
			return;
		}
		if (!gclass15_0.Boolean_2)
		{
			this._list[num] = gclass15_0;
			return;
		}
		this._list.RemoveAt(num);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0002BC74 File Offset: 0x00029E74
	internal void method_2(GClass16 gclass16_0)
	{
		foreach (object obj in gclass16_0)
		{
			GClass15 gclass = (GClass15)obj;
			this.method_1(gclass);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00005F09 File Offset: 0x00004109
	internal void method_3()
	{
		if (this._list.Count > 1)
		{
			List<GClass15> list = this._list;
			Comparison<GClass15> comparison;
			if ((comparison = GClass16.Class58.comparison_1) == null)
			{
				comparison = (GClass16.Class58.comparison_1 = new Comparison<GClass15>(GClass16.smethod_0));
			}
			list.Sort(comparison);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x0002BCCC File Offset: 0x00029ECC
	public void method_4(GClass15 gclass15_0)
	{
		if (gclass15_0 == null)
		{
			throw new ArgumentNullException("cookie");
		}
		int num = this.method_0(gclass15_0);
		if (num == -1)
		{
			this._list.Add(gclass15_0);
			return;
		}
		this._list[num] = gclass15_0;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0002BD10 File Offset: 0x00029F10
	public void method_5(GClass16 gclass16_0)
	{
		if (gclass16_0 == null)
		{
			throw new ArgumentNullException("cookies");
		}
		foreach (object obj in gclass16_0)
		{
			GClass15 gclass = (GClass15)obj;
			this.method_4(gclass);
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0002BD74 File Offset: 0x00029F74
	public void CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", "Less than zero.");
		}
		if (array.Rank > 1)
		{
			throw new ArgumentException("Multidimensional.", "array");
		}
		if (array.Length - index < this._list.Count)
		{
			throw new ArgumentException("The number of elements in this collection is greater than the available space of the destination array.");
		}
		if (!array.GetType().GetElementType().IsAssignableFrom(typeof(GClass15)))
		{
			throw new InvalidCastException("The elements in this collection cannot be cast automatically to the type of the destination array.");
		}
		((ICollection)this._list).CopyTo(array, index);
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0002BE10 File Offset: 0x0002A010
	public void method_6(GClass15[] gclass15_0, int int_0)
	{
		if (gclass15_0 == null)
		{
			throw new ArgumentNullException("array");
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("index", "Less than zero.");
		}
		if (gclass15_0.Length - int_0 < this._list.Count)
		{
			throw new ArgumentException("The number of elements in this collection is greater than the available space of the destination array.");
		}
		this._list.CopyTo(gclass15_0, int_0);
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00005F3F File Offset: 0x0000413F
	public IEnumerator GetEnumerator()
	{
		return this._list.GetEnumerator();
	}

	// Token: 0x04000205 RID: 517
	private List<GClass15> _list;

	// Token: 0x04000206 RID: 518
	private object _sync;

	// Token: 0x02000065 RID: 101
	[CompilerGenerated]
	private static class Class58
	{
		// Token: 0x04000207 RID: 519
		public static Comparison<GClass15> comparison_0;

		// Token: 0x04000208 RID: 520
		public static Comparison<GClass15> comparison_1;
	}
}
