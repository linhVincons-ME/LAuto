using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020002EB RID: 747
internal class Class525
{
	// Token: 0x17000912 RID: 2322
	// (get) Token: 0x060028D8 RID: 10456 RVA: 0x0001B954 File Offset: 0x00019B54
	// (set) Token: 0x060028D9 RID: 10457 RVA: 0x0001B95C File Offset: 0x00019B5C
	public long Int64_0 { get; set; }

	// Token: 0x17000913 RID: 2323
	// (get) Token: 0x060028DA RID: 10458 RVA: 0x0001B965 File Offset: 0x00019B65
	// (set) Token: 0x060028DB RID: 10459 RVA: 0x0001B96D File Offset: 0x00019B6D
	public int Int32_0 { get; set; }

	// Token: 0x17000914 RID: 2324
	// (get) Token: 0x060028DC RID: 10460 RVA: 0x0001B976 File Offset: 0x00019B76
	// (set) Token: 0x060028DD RID: 10461 RVA: 0x0001B97E File Offset: 0x00019B7E
	public int Int32_1 { get; set; }

	// Token: 0x17000915 RID: 2325
	// (get) Token: 0x060028DE RID: 10462 RVA: 0x0001B987 File Offset: 0x00019B87
	// (set) Token: 0x060028DF RID: 10463 RVA: 0x0001B98F File Offset: 0x00019B8F
	public int Int32_2 { get; set; }

	// Token: 0x17000916 RID: 2326
	// (get) Token: 0x060028E0 RID: 10464 RVA: 0x0001B998 File Offset: 0x00019B98
	// (set) Token: 0x060028E1 RID: 10465 RVA: 0x0001B9A0 File Offset: 0x00019BA0
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x17000917 RID: 2327
	// (get) Token: 0x060028E2 RID: 10466 RVA: 0x0001B9A9 File Offset: 0x00019BA9
	// (set) Token: 0x060028E3 RID: 10467 RVA: 0x0001B9B1 File Offset: 0x00019BB1
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x17000918 RID: 2328
	// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0001B9BA File Offset: 0x00019BBA
	// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0001B9C2 File Offset: 0x00019BC2
	public bool Boolean_0 { get; set; }

	// Token: 0x17000919 RID: 2329
	// (get) Token: 0x060028E6 RID: 10470 RVA: 0x0001B9CB File Offset: 0x00019BCB
	// (set) Token: 0x060028E7 RID: 10471 RVA: 0x0001B9D3 File Offset: 0x00019BD3
	public bool Boolean_1 { get; set; }

	// Token: 0x060028E8 RID: 10472 RVA: 0x0001B9DC File Offset: 0x00019BDC
	public static bool smethod_0(int int_3)
	{
		return Class525.hashSet_0.Contains(int_3);
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x0001B9E9 File Offset: 0x00019BE9
	public static bool smethod_1(int int_3)
	{
		return Class525.hashSet_1.Contains(int_3);
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x0001B9F6 File Offset: 0x00019BF6
	public static bool smethod_2(int int_3)
	{
		return Class525.hashSet_2.Contains(int_3);
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x0001BA03 File Offset: 0x00019C03
	public static bool smethod_3(int int_3)
	{
		return Class525.hashSet_3.Contains(int_3);
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x0001BA10 File Offset: 0x00019C10
	public static bool smethod_4(int int_3)
	{
		return Class525.hashSet_4.Contains(int_3);
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x0001BA1D File Offset: 0x00019C1D
	public static int smethod_5(int int_3)
	{
		if (int_3 != 402)
		{
			return 0;
		}
		return 199;
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x0001BA2E File Offset: 0x00019C2E
	public static int smethod_6(int int_3)
	{
		if (int_3 != 467)
		{
			return 0;
		}
		return 36;
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x001254D4 File Offset: 0x001236D4
	public static int smethod_7(int int_3)
	{
		int num;
		if (!Class525.dictionary_0.TryGetValue(int_3, out num))
		{
			return 0;
		}
		return num;
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x001254F4 File Offset: 0x001236F4
	public static int smethod_8(int int_3)
	{
		int num;
		if (!Class525.dictionary_1.TryGetValue(int_3, out num))
		{
			return 0;
		}
		return num;
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x0001BA3C File Offset: 0x00019C3C
	public static bool smethod_9(int int_3)
	{
		return Class525.hashSet_5.Contains(int_3);
	}

	// Token: 0x04001BB0 RID: 7088
	private static readonly HashSet<int> hashSet_0 = new HashSet<int>
	{
		311, 341, 371, 281, 401, 431, 461, 491, 521, 760,
		2900, 3430, 3800, 4515
	};

	// Token: 0x04001BB1 RID: 7089
	private static readonly HashSet<int> hashSet_1 = new HashSet<int>
	{
		328, 358, 388, 298, 418, 448, 478, 508, 538, 778,
		2918, 329, 359, 389, 299, 419, 449, 479, 509, 539,
		779, 2919, 330, 360, 390, 300, 420, 450, 480, 510,
		540, 780, 2920
	};

	// Token: 0x04001BB2 RID: 7090
	private static readonly HashSet<int> hashSet_2 = new HashSet<int>
	{
		328, 358, 388, 298, 418, 448, 478, 508, 538, 778,
		2918, 3448
	};

	// Token: 0x04001BB3 RID: 7091
	private static readonly HashSet<int> hashSet_3 = new HashSet<int>
	{
		329, 359, 389, 299, 419, 449, 479, 509, 539, 779,
		2919, 3449
	};

	// Token: 0x04001BB4 RID: 7092
	private static readonly HashSet<int> hashSet_4 = new HashSet<int>
	{
		330, 360, 390, 300, 420, 450, 480, 510, 540, 780,
		2920, 3450
	};

	// Token: 0x04001BB5 RID: 7093
	private static readonly HashSet<int> hashSet_5 = new HashSet<int> { 395, 374, 3431, 3447, 3439 };

	// Token: 0x04001BB6 RID: 7094
	private static readonly Dictionary<int, int> dictionary_0 = new Dictionary<int, int>
	{
		{ 349, 129 },
		{ 468, 168 },
		{ 767, 1328 },
		{ 317, 115 },
		{ 318, -1 },
		{ 439, -1 },
		{ 289, -1 },
		{ 438, 158 },
		{ 248, 1284 },
		{ 2907, 2611 },
		{ 494, 174 }
	};

	// Token: 0x04001BB7 RID: 7095
	private static readonly Dictionary<int, int> dictionary_1 = new Dictionary<int, int>
	{
		{ 302, 283 },
		{ 332, 284 },
		{ 362, 285 },
		{ 392, 286 },
		{ 422, 287 },
		{ 452, 288 },
		{ 482, 289 },
		{ 512, 290 },
		{ 542, 291 },
		{ 762, 1305 },
		{ 2902, 2607 },
		{ 286, 102 },
		{ 316, 114 },
		{ 346, 124 },
		{ 436, 154 },
		{ 466, 166 },
		{ 526, 189 },
		{ 766, 1308 },
		{ 2906, 2610 },
		{ 3432, 3646 },
		{ 3436, 3649 },
		{ 3802, 4124 }
	};

	// Token: 0x04001BB8 RID: 7096
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001BB9 RID: 7097
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001BBA RID: 7098
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001BBB RID: 7099
	[CompilerGenerated]
	private int int_2;

	// Token: 0x04001BBC RID: 7100
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001BBD RID: 7101
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001BBE RID: 7102
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001BBF RID: 7103
	[CompilerGenerated]
	private bool bool_1;
}
