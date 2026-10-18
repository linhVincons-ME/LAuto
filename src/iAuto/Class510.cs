using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020002D7 RID: 727
internal class Class510
{
	// Token: 0x0600264F RID: 9807 RVA: 0x00019FBB File Offset: 0x000181BB
	public Class510(Class106 class106_1)
	{
		this.class106_0 = class106_1;
	}

	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x06002650 RID: 9808 RVA: 0x00019FD5 File Offset: 0x000181D5
	// (set) Token: 0x06002651 RID: 9809 RVA: 0x00019FDD File Offset: 0x000181DD
	public long Int64_0 { get; set; }

	// Token: 0x170007BE RID: 1982
	// (get) Token: 0x06002652 RID: 9810 RVA: 0x00019FE6 File Offset: 0x000181E6
	// (set) Token: 0x06002653 RID: 9811 RVA: 0x00019FEE File Offset: 0x000181EE
	public int Int32_0 { get; set; }

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x06002654 RID: 9812 RVA: 0x00019FF7 File Offset: 0x000181F7
	// (set) Token: 0x06002655 RID: 9813 RVA: 0x00019FFF File Offset: 0x000181FF
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x06002656 RID: 9814 RVA: 0x0001A008 File Offset: 0x00018208
	// (set) Token: 0x06002657 RID: 9815 RVA: 0x0001A010 File Offset: 0x00018210
	public string String_1 { get; set; }

	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x06002658 RID: 9816 RVA: 0x0001A019 File Offset: 0x00018219
	// (set) Token: 0x06002659 RID: 9817 RVA: 0x0001A021 File Offset: 0x00018221
	public int Int32_1 { get; set; }

	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x0600265A RID: 9818 RVA: 0x0001A02A File Offset: 0x0001822A
	// (set) Token: 0x0600265B RID: 9819 RVA: 0x0001A032 File Offset: 0x00018232
	public int Int32_2 { get; set; }

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x0600265C RID: 9820 RVA: 0x0001A03B File Offset: 0x0001823B
	// (set) Token: 0x0600265D RID: 9821 RVA: 0x0001A043 File Offset: 0x00018243
	public int Int32_3 { get; set; }

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x0600265E RID: 9822 RVA: 0x0001A04C File Offset: 0x0001824C
	// (set) Token: 0x0600265F RID: 9823 RVA: 0x0001A054 File Offset: 0x00018254
	public string String_2 { get; set; }

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x06002660 RID: 9824 RVA: 0x0001A05D File Offset: 0x0001825D
	// (set) Token: 0x06002661 RID: 9825 RVA: 0x0001A065 File Offset: 0x00018265
	public bool Boolean_0 { get; set; }

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x06002662 RID: 9826 RVA: 0x0001A06E File Offset: 0x0001826E
	// (set) Token: 0x06002663 RID: 9827 RVA: 0x0001A076 File Offset: 0x00018276
	public int Int32_4 { get; set; }

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x06002664 RID: 9828 RVA: 0x0001A07F File Offset: 0x0001827F
	// (set) Token: 0x06002665 RID: 9829 RVA: 0x0001A087 File Offset: 0x00018287
	public long Int64_1 { get; set; }

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06002666 RID: 9830 RVA: 0x0001A090 File Offset: 0x00018290
	public bool Boolean_1
	{
		get
		{
			return this.Int32_4 == 512 || this.Int32_4 == 513 || this.Int32_4 == 516;
		}
	}

	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06002667 RID: 9831 RVA: 0x0001A0BB File Offset: 0x000182BB
	public string String_3
	{
		get
		{
			return this.String_0.smethod_36();
		}
	}

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x06002668 RID: 9832 RVA: 0x0001A0C8 File Offset: 0x000182C8
	public int Int32_5
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L });
		}
	}

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x06002669 RID: 9833 RVA: 0x0001A0F3 File Offset: 0x000182F3
	public int Int32_6
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L + 4L });
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x0600266A RID: 9834 RVA: 0x0001A128 File Offset: 0x00018328
	public int Int32_7
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L + 8L });
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x0600266B RID: 9835 RVA: 0x0001A15D File Offset: 0x0001835D
	public int Int32_8
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L + 12L });
		}
	}

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x0600266C RID: 9836 RVA: 0x0001A192 File Offset: 0x00018392
	public int Int32_9
	{
		get
		{
			return this.class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L + 16L });
		}
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x0011D238 File Offset: 0x0011B438
	public void method_0()
	{
		foreach (Class510.Class511 @class in Class510.Class511.smethod_0(this.class106_0))
		{
			if (@class.Int32_1 == this.Int32_0)
			{
				@class.method_0(256);
				break;
			}
		}
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x0011D2A8 File Offset: 0x0011B4A8
	public static bool smethod_0(Class106 class106_1, string string_3)
	{
		class106_1.Class512_0.method_28();
		foreach (long num in Class510.smethod_1(class106_1.Class502_0.Int64_39, class106_1))
		{
			if (new Class510(class106_1)
			{
				String_0 = class106_1.Class515_0.method_2(new long[] { num + (long)Class510.smethod_3(class106_1) })
			}.String_0.Contains(string_3))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x0011D34C File Offset: 0x0011B54C
	public static List<long> smethod_1(long[] long_2, Class106 class106_1)
	{
		long num = class106_1.Class515_0.method_9(long_2);
		if (num <= 0L)
		{
			return new List<long>();
		}
		List<long> list = new List<long>();
		Stack<long> stack = new Stack<long>();
		stack.Push(num);
		while (stack.Count > 0 && list.Count <= 1000)
		{
			long num2 = stack.Pop();
			if (num2 > 0L && !list.Contains(num2))
			{
				list.Add(num2);
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 }));
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 + (long)class106_1.Class515_0.Int32_1 }));
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 + (long)(class106_1.Class515_0.Int32_1 * 2) }));
			}
		}
		return list;
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x0011D440 File Offset: 0x0011B640
	public static List<Class510> smethod_2(Class106 class106_1)
	{
		List<Class510> list = new List<Class510>();
		List<Class510.Class511> list2 = Class510.Class511.smethod_0(class106_1);
		long num = class106_1.Class515_0.method_9(class106_1.Class502_0.Int64_39);
		List<long> list3 = new List<long>();
		Stack<long> stack = new Stack<long>();
		stack.Push(num);
		while (stack.Count > 0 && list3.Count <= 1000)
		{
			long num2 = stack.Pop();
			if (num2 > 0L && !list3.Contains(num2))
			{
				list3.Add(num2);
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 }));
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 + (long)class106_1.Class515_0.Int32_1 }));
				stack.Push(class106_1.Class515_0.method_9(new long[] { num2 + (long)(class106_1.Class515_0.Int32_1 * 2) }));
			}
		}
		foreach (long num3 in list3)
		{
			Class510 @class = new Class510(class106_1)
			{
				Int64_0 = num3,
				String_0 = class106_1.Class515_0.method_2(new long[] { num3 + (long)Class510.smethod_3(class106_1) }).Trim(),
				Int32_1 = class106_1.Class515_0.method_7(new long[] { num3 + 24L }),
				Int32_0 = class106_1.Class515_0.method_7(new long[] { num3 + (long)Class510.smethod_4(class106_1) }),
				Int32_2 = ((class106_1.Class502_0.Int32_5 == 1 || class106_1.Class502_0.Int32_5 == 3 || class106_1.Class502_0.Int32_5 == 4) ? class106_1.Class515_0.method_7(new long[] { num3 + 48L }) : class106_1.Class515_0.method_7(new long[] { num3 + 44L })),
				Int32_3 = ((class106_1.Class502_0.Int32_5 == 1 || class106_1.Class502_0.Int32_5 == 3 || class106_1.Class502_0.Int32_5 == 4) ? class106_1.Class515_0.method_7(new long[] { num3 + 52L }) : class106_1.Class515_0.method_7(new long[] { num3 + 48L })),
				String_2 = class106_1.Class515_0.method_2(new long[] { num3 + 60L }),
				String_1 = class106_1.Class515_0.method_2(new long[] { num3 + 200L })
			};
			if (@class.String_0 == "#{CJG_101231_121}")
			{
				@class.String_0 = "Cái Bang Nghi Vấn Ban Đầu";
			}
			if (Class501.Dictionary_7.ContainsKey(@class.String_0))
			{
				@class.String_0 = Class501.Dictionary_7[@class.String_0];
			}
			if ((!string.IsNullOrEmpty(@class.String_0) || class106_1.Class502_0.Int32_5 != 1) && @class.Int32_0 > 0)
			{
				list.Add(@class);
				foreach (Class510.Class511 class2 in list2)
				{
					if (class2.Int32_1 == @class.Int32_0)
					{
						if (class2.Int32_2 >= 256)
						{
							@class.Boolean_0 = true;
						}
						@class.Int32_4 = class2.Int32_2;
						@class.Int64_1 = class2.Int64_0;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x0011D858 File Offset: 0x0011BA58
	private static int smethod_3(Class106 class106_1)
	{
		if (class106_1.Class502_0.Int32_5 == 5)
		{
			return 304;
		}
		if (class106_1.Class502_0.Int32_5 != 1 && class106_1.Class502_0.Int32_5 != 3 && class106_1.Class502_0.Int32_5 != 4)
		{
			return 224;
		}
		return 192;
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x0011D8B0 File Offset: 0x0011BAB0
	private static int smethod_4(Class106 class106_1)
	{
		if (class106_1.Class502_0.Int32_5 == 5)
		{
			return 32;
		}
		if (class106_1.Class502_0.Int32_5 != 1 && class106_1.Class502_0.Int32_5 != 3 && class106_1.Class502_0.Int32_5 != 4)
		{
			return 12;
		}
		return 16;
	}

	// Token: 0x040019CA RID: 6602
	private readonly Class106 class106_0;

	// Token: 0x040019CB RID: 6603
	[CompilerGenerated]
	private long long_0;

	// Token: 0x040019CC RID: 6604
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040019CD RID: 6605
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040019CE RID: 6606
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040019CF RID: 6607
	[CompilerGenerated]
	private int int_1;

	// Token: 0x040019D0 RID: 6608
	[CompilerGenerated]
	private int int_2;

	// Token: 0x040019D1 RID: 6609
	[CompilerGenerated]
	private int int_3;

	// Token: 0x040019D2 RID: 6610
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040019D3 RID: 6611
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040019D4 RID: 6612
	[CompilerGenerated]
	private int int_4;

	// Token: 0x040019D5 RID: 6613
	[CompilerGenerated]
	private long long_1;

	// Token: 0x020002D8 RID: 728
	internal class Class511
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x0001A1C7 File Offset: 0x000183C7
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0001A1CF File Offset: 0x000183CF
		public long Int64_0 { get; set; }

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x0001A1D8 File Offset: 0x000183D8
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x0001A1E0 File Offset: 0x000183E0
		public int Int32_0 { get; set; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x0001A1E9 File Offset: 0x000183E9
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x0001A1F1 File Offset: 0x000183F1
		public int Int32_1 { get; set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x0001A1FA File Offset: 0x000183FA
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0001A202 File Offset: 0x00018402
		public int Int32_2 { get; set; }

		// Token: 0x0600267B RID: 9851 RVA: 0x0001A20B File Offset: 0x0001840B
		public Class511(Class106 class106_1)
		{
			this.class106_0 = class106_1;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0001A21A File Offset: 0x0001841A
		public void method_0(int int_3)
		{
			this.class106_0.Class515_0.method_21(this.Int64_0 + (long)(this.class106_0.Class515_0.Int32_1 * 2), int_3);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0011D900 File Offset: 0x0011BB00
		public static List<Class510.Class511> smethod_0(Class106 class106_1)
		{
			List<Class510.Class511> list = new List<Class510.Class511>();
			long num = class106_1.Class515_0.method_9(class106_1.Class502_0.Int64_40);
			for (int i = 0; i < 80; i++)
			{
				if (class106_1.Class515_0.method_9(new long[] { num + 5L + (long)(i * 41) }) != 0L)
				{
					Class510.Class511 @class = new Class510.Class511(class106_1)
					{
						Int64_0 = num + 5L + (long)(i * 41),
						Int32_0 = class106_1.Class515_0.method_7(new long[] { num + 5L + (long)(i * 41) }),
						Int32_1 = class106_1.Class515_0.method_7(new long[] { num + 5L + (long)(i * 41) + (long)class106_1.Class515_0.Int32_1 }),
						Int32_2 = class106_1.Class515_0.method_7(new long[] { num + 5L + (long)(i * 41) + (long)(class106_1.Class515_0.Int32_1 * 2) })
					};
					if (@class.Int32_1 > 0)
					{
						list.Add(@class);
					}
				}
			}
			return list;
		}

		// Token: 0x040019D6 RID: 6614
		private readonly Class106 class106_0;

		// Token: 0x040019D7 RID: 6615
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040019D8 RID: 6616
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040019D9 RID: 6617
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040019DA RID: 6618
		[CompilerGenerated]
		private int int_2;
	}
}
