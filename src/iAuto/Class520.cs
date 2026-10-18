using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x020002E5 RID: 741
internal class Class520
{
	// Token: 0x06002852 RID: 10322 RVA: 0x0001B22A File Offset: 0x0001942A
	public Class520(Class106 class106_1)
	{
		this.class106_0 = class106_1;
	}

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x06002853 RID: 10323 RVA: 0x0012094C File Offset: 0x0011EB4C
	public List<Class519> List_0
	{
		get
		{
			List<Class519> list = new List<Class519>();
			long num = this.class106_0.Class515_0.method_9(this.class106_0.Class502_0.Int64_42) + 8L;
			Class519 @class = new Class519();
			@class.Int64_0 = num;
			@class.Int32_3 = this.class106_0.Class515_0.method_7(new long[] { @class.Int64_0 + 4L });
			@class.Int32_1 = this.class106_0.Class515_0.method_7(new long[] { @class.Int64_0 + 272L });
			@class.Int32_2 = this.class106_0.Class515_0.method_7(new long[] { @class.Int64_0 + 8L });
			@class.String_0 = this.class106_0.Class515_0.method_16(new long[] { @class.Int64_0 + 14L }).Trim();
			list.Add(@class);
			for (int i = 1; i < 17; i++)
			{
				long num2 = num + (long)(280 * i);
				Class519 class2 = new Class519();
				class2.Int64_0 = num2;
				class2.Int32_0 = i;
				class2.Int32_3 = this.class106_0.Class515_0.method_7(new long[] { class2.Int64_0 + 4L });
				class2.Int32_1 = this.class106_0.Class515_0.method_7(new long[] { class2.Int64_0 + 272L });
				class2.Int32_2 = this.class106_0.Class515_0.method_7(new long[] { class2.Int64_0 + 8L });
				class2.String_0 = this.class106_0.Class515_0.method_16(new long[] { num2 + 14L }).Trim();
				if (class2.String_0 == "#{CJG_101231_121}")
				{
					class2.String_0 = "Cái Bang Nghi Vấn Ban Đầu";
				}
				class2.String_0 = class2.String_0.Replace("Kỵ Vọng Thiên Sư", "Thiên sư kỳ đãi");
				if (Class501.Dictionary_7.ContainsKey(class2.String_0))
				{
					class2.String_0 = Class501.Dictionary_7[class2.String_0];
				}
				if (!string.IsNullOrEmpty(class2.String_0))
				{
					list.Add(class2);
				}
			}
			return list;
		}
	}

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06002854 RID: 10324 RVA: 0x0001B239 File Offset: 0x00019439
	// (set) Token: 0x06002855 RID: 10325 RVA: 0x0001B241 File Offset: 0x00019441
	public int Int32_0 { get; set; }

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06002856 RID: 10326 RVA: 0x0001B24A File Offset: 0x0001944A
	// (set) Token: 0x06002857 RID: 10327 RVA: 0x0001B252 File Offset: 0x00019452
	public int Int32_1 { get; set; }

	// Token: 0x170008F0 RID: 2288
	// (get) Token: 0x06002858 RID: 10328 RVA: 0x0001B25B File Offset: 0x0001945B
	// (set) Token: 0x06002859 RID: 10329 RVA: 0x0001B263 File Offset: 0x00019463
	public int Int32_2 { get; set; }

	// Token: 0x170008F1 RID: 2289
	// (get) Token: 0x0600285A RID: 10330 RVA: 0x0001B26C File Offset: 0x0001946C
	public int Int32_3
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[]
			{
				this.class106_0.Class502_0.Int64_42[0],
				60L
			});
		}
	}

	// Token: 0x170008F2 RID: 2290
	// (get) Token: 0x0600285B RID: 10331 RVA: 0x00120BD8 File Offset: 0x0011EDD8
	public string String_0
	{
		get
		{
			string text = "";
			foreach (Class519 @class in this.List_0)
			{
				text += @class.String_0;
			}
			return text;
		}
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x00120C3C File Offset: 0x0011EE3C
	public void method_0()
	{
		foreach (Class519 @class in this.List_0)
		{
			this.class106_0.method_442(@class);
		}
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x0001B2A5 File Offset: 0x000194A5
	public bool method_1(Class519 class519_0)
	{
		return this.method_2(class519_0.Int32_1, class519_0.Int32_2);
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x00120C98 File Offset: 0x0011EE98
	public bool method_2(int int_4, int int_5)
	{
		foreach (Class519 @class in this.List_0)
		{
			if (@class.Int32_1 == int_4 && @class.Int32_2 == int_5)
			{
				this.class106_0.method_442(@class);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x0001B2B9 File Offset: 0x000194B9
	public bool method_3(int int_4)
	{
		if (int_4 <= this.List_0.Count - 1)
		{
			this.class106_0.method_442(this.List_0[int_4]);
			return true;
		}
		return false;
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x00120D0C File Offset: 0x0011EF0C
	public bool method_4(int int_4)
	{
		foreach (Class519 @class in this.List_0)
		{
			if (@class.Int32_3 == int_4)
			{
				this.class106_0.method_443(@class.Int32_1, @class.Int32_2);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x0001B2E5 File Offset: 0x000194E5
	public void method_5()
	{
		this.class106_0.method_375("QuestFrameAcceptClicked();", false);
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x0001B2F8 File Offset: 0x000194F8
	public void method_6()
	{
		this.class106_0.method_375("QuestFrameMissionComplete(1);", false);
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x00120D84 File Offset: 0x0011EF84
	public bool method_7(string string_1, List<int> list_0 = null)
	{
		if (Regex.IsMatch(string_1, "^\\d+$"))
		{
			return this.method_3(string_1.smethod_26());
		}
		if (list_0 != null)
		{
			foreach (Class519 @class in this.List_0)
			{
				if (@class.String_0.smethod_36().Contains(string_1.smethod_36()) && list_0.Contains(@class.Int32_3))
				{
					this.class106_0.method_442(@class);
					return true;
				}
			}
		}
		foreach (Class519 class2 in this.List_0)
		{
			if (class2.String_0.smethod_36().Contains(string_1.smethod_36()))
			{
				this.class106_0.method_442(class2);
				return true;
			}
		}
		if (this.class106_0.List_5.Contains(Enum17.NhiemVuChinhTuyen))
		{
			Thread.Sleep(1000);
			foreach (Class519 class3 in this.List_0)
			{
				if (class3.String_0.smethod_36().Contains(string_1.smethod_36()))
				{
					this.class106_0.method_442(class3);
					return true;
				}
			}
			Thread.Sleep(1000);
			foreach (Class519 class4 in this.List_0)
			{
				if (class4.String_0.smethod_36().Contains(string_1.smethod_36()))
				{
					this.class106_0.method_442(class4);
					return true;
				}
			}
			Thread.Sleep(1000);
			foreach (Class519 class5 in this.List_0)
			{
				if (class5.String_0.smethod_36().Contains(string_1.smethod_36()))
				{
					this.class106_0.method_442(class5);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x0001B30B File Offset: 0x0001950B
	public void method_8()
	{
		this.class106_0.method_381(0L, 122L);
	}

	// Token: 0x06002865 RID: 10341 RVA: 0x00121000 File Offset: 0x0011F200
	public static void smethod_0(Class106 class106_1)
	{
		foreach (Class519 @class in Class520.smethod_3(class106_1))
		{
			if (Class520.smethod_2(@class.Int32_1))
			{
				class106_1.method_442(@class);
				return;
			}
		}
		foreach (Class519 class2 in class106_1.Class520_0.List_0)
		{
			if (class2.Int32_3 == 10)
			{
				class106_1.method_442(class2);
				break;
			}
		}
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x001210BC File Offset: 0x0011F2BC
	public static void smethod_1(Class106 class106_1)
	{
		foreach (Class519 @class in Class520.smethod_3(class106_1))
		{
			if (((@class.Int32_1 != 119001 && @class.Int32_1 != 118001) || @class.Int32_2 != 1) && @class.Int32_1 != 119005 && @class.Int32_1 != 118012)
			{
				if (@class.Int32_1 != 2108)
				{
					continue;
				}
			}
			class106_1.method_442(@class);
			break;
		}
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x0001B32A File Offset: 0x0001952A
	public static bool smethod_2(int int_4)
	{
		return Class520.hashSet_0.Contains(int_4);
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x00121160 File Offset: 0x0011F360
	public static List<Class519> smethod_3(Class106 class106_1)
	{
		List<Class519> list = new List<Class519>();
		long num = class106_1.Class515_0.method_9(class106_1.Class502_0.Int64_42) + 8L;
		Class519 @class = new Class519();
		@class.Int64_0 = num;
		@class.Int32_1 = class106_1.Class515_0.method_7(new long[] { @class.Int64_0 + 272L });
		@class.Int32_2 = class106_1.Class515_0.method_7(new long[] { @class.Int64_0 + 8L });
		@class.String_0 = class106_1.Class515_0.method_16(new long[] { @class.Int64_0 + 14L });
		list.Add(@class);
		for (int i = 1; i < 20; i++)
		{
			long num2 = num + (long)(280 * i);
			@class = new Class519();
			@class.Int64_0 = num2;
			@class.Int32_0 = i;
			@class.Int32_1 = class106_1.Class515_0.method_7(new long[] { @class.Int64_0 + 272L });
			@class.Int32_2 = class106_1.Class515_0.method_7(new long[] { @class.Int64_0 + 8L });
			@class.String_0 = class106_1.Class515_0.method_16(new long[] { num2 + 14L }).Trim();
			if (@class.String_0 == "#{CJG_101231_121}")
			{
				@class.String_0 = "Cái Bang Nghi Vấn Ban Đầu";
			}
			if (Class501.Dictionary_7.ContainsKey(@class.String_0))
			{
				@class.String_0 = Class501.Dictionary_7[@class.String_0];
			}
			if (@class.String_0.Trim() != "")
			{
				list.Add(@class);
			}
		}
		return list;
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x00121340 File Offset: 0x0011F540
	public static string smethod_4(Class106 class106_1)
	{
		string text = "";
		foreach (Class519 @class in Class520.smethod_3(class106_1))
		{
			text += @class.String_0;
		}
		return text;
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x001213A4 File Offset: 0x0011F5A4
	public static string smethod_5(Class106 class106_1)
	{
		string text = "";
		using (List<Class519>.Enumerator enumerator = Class520.smethod_3(class106_1).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				Class519 @class = enumerator.Current;
				text += @class.String_0;
			}
		}
		return text;
	}

	// Token: 0x04001B4F RID: 6991
	private static readonly HashSet<int> hashSet_0 = new HashSet<int>
	{
		200005, 118001, 119005, 119001, 200001, 13035, 9044, 10051, 16035, 14035,
		9035, 17035, 15035, 12035, 11035, 10035
	};

	// Token: 0x04001B50 RID: 6992
	private readonly Class106 class106_0;

	// Token: 0x04001B51 RID: 6993
	public int int_0;

	// Token: 0x04001B52 RID: 6994
	public string string_0;

	// Token: 0x04001B53 RID: 6995
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001B54 RID: 6996
	[CompilerGenerated]
	private int int_2;

	// Token: 0x04001B55 RID: 6997
	[CompilerGenerated]
	private int int_3;
}
