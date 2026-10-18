using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020002ED RID: 749
internal class Class527
{
	// Token: 0x17000923 RID: 2339
	// (get) Token: 0x06002907 RID: 10503 RVA: 0x00125B8C File Offset: 0x00123D8C
	public bool Boolean_0
	{
		get
		{
			return this.Int32_33 != 2 && this.Int32_33 != 3 && this.Int32_33 != 4 && this.Int32_33 != 5 && this.Int32_33 != 9 && this.Int32_33 != 10 && this.Int32_33 > 0;
		}
	}

	// Token: 0x17000924 RID: 2340
	// (get) Token: 0x06002908 RID: 10504 RVA: 0x0001BB25 File Offset: 0x00019D25
	public int Int32_0
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[]
			{
				this.Class106_0.Int64_0 + 2381888L,
				72L
			});
		}
	}

	// Token: 0x17000925 RID: 2341
	// (get) Token: 0x06002909 RID: 10505 RVA: 0x0001BB61 File Offset: 0x00019D61
	public int Int32_1
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[]
			{
				this.Class106_0.Int64_0 + 2381888L,
				76L
			});
		}
	}

	// Token: 0x17000926 RID: 2342
	// (get) Token: 0x0600290A RID: 10506 RVA: 0x00125BEC File Offset: 0x00123DEC
	public Class530 Class530_0
	{
		get
		{
			Class530 @class;
			if (!this.dictionary_4.TryGetValue(this.Int32_5, out @class))
			{
				return null;
			}
			return @class;
		}
	}

	// Token: 0x17000927 RID: 2343
	// (get) Token: 0x0600290B RID: 10507 RVA: 0x0001BB9D File Offset: 0x00019D9D
	// (set) Token: 0x0600290C RID: 10508 RVA: 0x0001BBA5 File Offset: 0x00019DA5
	public Class502 Class502_0 { get; set; }

	// Token: 0x17000928 RID: 2344
	// (get) Token: 0x0600290D RID: 10509 RVA: 0x0001BBAE File Offset: 0x00019DAE
	// (set) Token: 0x0600290E RID: 10510 RVA: 0x0001BBB6 File Offset: 0x00019DB6
	public long Int64_0 { get; set; }

	// Token: 0x17000929 RID: 2345
	// (get) Token: 0x0600290F RID: 10511 RVA: 0x0001BBBF File Offset: 0x00019DBF
	// (set) Token: 0x06002910 RID: 10512 RVA: 0x0001BBC7 File Offset: 0x00019DC7
	public bool Boolean_1 { get; set; }

	// Token: 0x1700092A RID: 2346
	// (get) Token: 0x06002911 RID: 10513 RVA: 0x0001BBD0 File Offset: 0x00019DD0
	// (set) Token: 0x06002912 RID: 10514 RVA: 0x0001BBD8 File Offset: 0x00019DD8
	public Class515 Class515_0 { get; set; }

	// Token: 0x1700092B RID: 2347
	// (get) Token: 0x06002913 RID: 10515 RVA: 0x0001BBE1 File Offset: 0x00019DE1
	// (set) Token: 0x06002914 RID: 10516 RVA: 0x0001BBE9 File Offset: 0x00019DE9
	public int Int32_2 { get; set; }

	// Token: 0x06002915 RID: 10517 RVA: 0x00125C14 File Offset: 0x00123E14
	public Class527(Class106 class106_1)
	{
		this.Class106_0 = class106_1;
		this.Class502_0 = class106_1.Class502_0;
		this.Class515_0 = class106_1.Class515_0;
	}

	// Token: 0x1700092C RID: 2348
	// (get) Token: 0x06002916 RID: 10518 RVA: 0x00126E08 File Offset: 0x00125008
	public int Int32_3
	{
		get
		{
			long num = this.Class106_0.Class515_0.method_14(new long[] { 4209108L, 0L, 1036L });
			return this.Class106_0.Class515_0.method_10(new long[] { num });
		}
	}

	// Token: 0x1700092D RID: 2349
	// (get) Token: 0x06002917 RID: 10519 RVA: 0x00126E60 File Offset: 0x00125060
	public int Int32_4
	{
		get
		{
			if (this.Class502_0.Int32_5 == 5)
			{
				return 512;
			}
			if (this.Class502_0.Int32_5 == 4)
			{
				Class515 @class = this.Class515_0;
				long[] array = new long[4];
				array[0] = this.Class106_0.Int64_0 + 4388740L;
				array[1] = 44L;
				array[2] = 112L;
				return @class.method_7(array);
			}
			if (this.Class502_0.Int32_5 == 2)
			{
				return this.Class515_0.method_7(new long[] { 6576212L, 48L, 72L, 0L });
			}
			if (this.Class502_0.Int32_5 == 3)
			{
				Class515 class2 = this.Class515_0;
				long[] array2 = new long[4];
				array2[0] = this.Class106_0.Int64_0 + 3466612L;
				array2[1] = 44L;
				array2[2] = 104L;
				return class2.method_7(array2);
			}
			if (this.Class502_0.Int32_5 == 1 && this.Int32_35 <= 1)
			{
				return 512;
			}
			Class515 class3 = this.Class515_0;
			long[] array3 = new long[4];
			array3[0] = this.Class106_0.Int64_0 + 10884488L;
			array3[1] = 36L;
			array3[2] = 124L;
			return class3.method_7(array3);
		}
	}

	// Token: 0x1700092E RID: 2350
	// (get) Token: 0x06002918 RID: 10520 RVA: 0x0001BBF2 File Offset: 0x00019DF2
	public bool Boolean_2
	{
		get
		{
			return this.Int32_33 == 9;
		}
	}

	// Token: 0x1700092F RID: 2351
	// (get) Token: 0x06002919 RID: 10521 RVA: 0x00126FAC File Offset: 0x001251AC
	public string String_0
	{
		get
		{
			string text = "";
			foreach (char c in this.String_11)
			{
				if (Class531.string_0.Contains(c))
				{
					text += c.ToString();
				}
			}
			return text;
		}
	}

	// Token: 0x17000930 RID: 2352
	// (get) Token: 0x0600291A RID: 10522 RVA: 0x00126FFC File Offset: 0x001251FC
	public float Single_0
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				return this.Class515_0.method_13(new long[]
				{
					this.Class106_0.Int64_0 + 10884276L,
					52L
				});
			}
			return this.Class515_0.method_13(new long[] { 6575012L, 84L });
		}
	}

	// Token: 0x17000931 RID: 2353
	// (get) Token: 0x0600291B RID: 10523 RVA: 0x00127078 File Offset: 0x00125278
	public float Single_1
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				return this.Class515_0.method_13(new long[]
				{
					this.Class106_0.Int64_0 + 10884276L,
					60L
				});
			}
			return this.Class515_0.method_13(new long[] { 6575012L, 92L });
		}
	}

	// Token: 0x17000932 RID: 2354
	// (get) Token: 0x0600291C RID: 10524 RVA: 0x001270F4 File Offset: 0x001252F4
	public bool Boolean_3
	{
		get
		{
			if (this.Class106_0.Boolean_66)
			{
				return this.Class106_0.Class515_0.method_7(new long[]
				{
					this.Class106_0.Int64_0 + 4068996L,
					0L,
					12L,
					88L
				}) == 1;
			}
			return this.Class106_0.Class515_0.method_7(new long[] { 6557664L, 0L, 12L, 100L }) == 1;
		}
	}

	// Token: 0x17000933 RID: 2355
	// (get) Token: 0x0600291D RID: 10525 RVA: 0x0012717C File Offset: 0x0012537C
	public bool Boolean_4
	{
		get
		{
			return this.method_1(this.Int32_35) || this.Int32_35 == Class513.Int32_37 || this.Int32_35 == Class513.Int32_174 || this.Int32_35 == Class513.Int32_177 || this.Int32_35 == Class513.Int32_182;
		}
	}

	// Token: 0x17000934 RID: 2356
	// (get) Token: 0x0600291E RID: 10526 RVA: 0x001271D0 File Offset: 0x001253D0
	public Class530 Class530_1
	{
		get
		{
			if (this.Int32_5 == Class537.int_2)
			{
				return Class538.class530_0;
			}
			if (this.Int32_5 == Class537.int_10)
			{
				return Class542.class530_2;
			}
			if (this.Int32_5 == Class537.int_1)
			{
				return Class544.class530_5;
			}
			if (this.Int32_5 == Class537.int_9)
			{
				return Class546.class530_0;
			}
			if (this.Int32_5 == Class537.int_4)
			{
				return Class548.class530_3;
			}
			if (this.Int32_5 == Class537.int_11)
			{
				return Class550.class530_0;
			}
			if (this.Int32_5 == Class537.int_6)
			{
				return Class552.class530_1;
			}
			if (this.Int32_5 == Class537.int_7)
			{
				return Class554.class530_2;
			}
			if (this.Int32_5 == Class537.int_0)
			{
				return Class556.class530_1;
			}
			if (this.Int32_5 == Class537.int_8)
			{
				return Class558.class530_0;
			}
			if (this.Int32_5 == Class537.int_5)
			{
				return Class560.class530_3;
			}
			if (this.Int32_5 == Class537.int_3)
			{
				return Class562.class530_2;
			}
			if (this.Int32_5 == Class537.int_12)
			{
				return Class540.class530_2;
			}
			if (this.Int32_5 == Class537.int_13)
			{
				return Class279.class530_3;
			}
			return null;
		}
	}

	// Token: 0x17000935 RID: 2357
	// (get) Token: 0x0600291F RID: 10527 RVA: 0x0001BBFE File Offset: 0x00019DFE
	// (set) Token: 0x06002920 RID: 10528 RVA: 0x0001BC06 File Offset: 0x00019E06
	public Class106 Class106_0 { get; set; }

	// Token: 0x17000936 RID: 2358
	// (get) Token: 0x06002921 RID: 10529 RVA: 0x0001BC0F File Offset: 0x00019E0F
	// (set) Token: 0x06002922 RID: 10530 RVA: 0x0001BC17 File Offset: 0x00019E17
	public long Int64_1 { get; set; }

	// Token: 0x17000937 RID: 2359
	// (get) Token: 0x06002923 RID: 10531 RVA: 0x0001BC20 File Offset: 0x00019E20
	public string String_1
	{
		get
		{
			return this.String_10.Substring(0, 8);
		}
	}

	// Token: 0x17000938 RID: 2360
	// (get) Token: 0x06002924 RID: 10532 RVA: 0x0001BC2F File Offset: 0x00019E2F
	public byte[] Byte_0
	{
		get
		{
			this.Int64_1 = this.Class515_0.method_9(this.Class502_0.Int64_1);
			return this.Class515_0.method_18(this.Int64_1 + (long)this.Class502_0.Int32_8);
		}
	}

	// Token: 0x17000939 RID: 2361
	// (get) Token: 0x06002925 RID: 10533 RVA: 0x001272E8 File Offset: 0x001254E8
	public int Int32_5
	{
		get
		{
			int num = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_9 });
			int int32_ = this.Class106_0.Class527_0.Int32_35;
			if (this.Class106_0.Class502_0.Int32_5 == 1 && (int32_ == 851 || int32_ == 852 || int32_ == 853))
			{
				int num2 = this.Class515_0.method_7(new long[] { this.Int64_3 + 664L });
				switch (num2)
				{
				case 10:
					num = Class537.int_9;
					break;
				case 11:
					num = Class537.int_10;
					break;
				case 12:
					num = Class537.int_11;
					break;
				case 13:
					num = Class537.int_12;
					break;
				case 14:
					num = Class537.int_13;
					break;
				default:
					num = num2 + 1;
					break;
				}
			}
			return num;
		}
	}

	// Token: 0x1700093A RID: 2362
	// (get) Token: 0x06002926 RID: 10534 RVA: 0x0001BC6B File Offset: 0x00019E6B
	// (set) Token: 0x06002927 RID: 10535 RVA: 0x0001BC73 File Offset: 0x00019E73
	public int Int32_6 { get; set; }

	// Token: 0x1700093B RID: 2363
	// (get) Token: 0x06002928 RID: 10536 RVA: 0x0001BC7C File Offset: 0x00019E7C
	public bool Boolean_5
	{
		get
		{
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_14 }) == 1;
		}
	}

	// Token: 0x1700093C RID: 2364
	// (get) Token: 0x06002929 RID: 10537 RVA: 0x0001BCA8 File Offset: 0x00019EA8
	// (set) Token: 0x0600292A RID: 10538 RVA: 0x0001BCB0 File Offset: 0x00019EB0
	public int Int32_7 { get; set; }

	// Token: 0x1700093D RID: 2365
	// (get) Token: 0x0600292B RID: 10539 RVA: 0x0001BCB9 File Offset: 0x00019EB9
	// (set) Token: 0x0600292C RID: 10540 RVA: 0x0001BCC1 File Offset: 0x00019EC1
	public int Int32_8 { get; set; }

	// Token: 0x1700093E RID: 2366
	// (get) Token: 0x0600292D RID: 10541 RVA: 0x0001BCCA File Offset: 0x00019ECA
	// (set) Token: 0x0600292E RID: 10542 RVA: 0x0001BCD2 File Offset: 0x00019ED2
	public int Int32_9 { get; set; }

	// Token: 0x1700093F RID: 2367
	// (get) Token: 0x0600292F RID: 10543 RVA: 0x0001BCDB File Offset: 0x00019EDB
	// (set) Token: 0x06002930 RID: 10544 RVA: 0x0001BCE3 File Offset: 0x00019EE3
	public int Int32_10 { get; set; }

	// Token: 0x17000940 RID: 2368
	// (get) Token: 0x06002931 RID: 10545 RVA: 0x0001BCEC File Offset: 0x00019EEC
	public static int[] Int32_11
	{
		get
		{
			return new int[]
			{
				0, 90, 324, 630, 1152, 1620, 1800, 1980, 2160, 2340,
				6300, 7020, 7776, 8874, 10044, 11628, 13320, 15498, 18216, 21528,
				25488, 30150, 35568, 41796, 48888, 57420, 67500, 78678, 91008, 104544,
				123624, 144270, 166536, 190476, 216144, 243594, 272880, 304056, 337176, 372294,
				409860, 449955, 492660, 538056, 586224, 637245, 691200, 748170, 808236, 871479,
				937980, 1007820, 1081080, 1157841, 1238184, 1322190, 1409940, 1501515, 1596996, 1696464,
				1800000, 1907685, 2019600, 2135826, 2256444, 2381535, 2516850, 2667825, 2835000, 3018915,
				3220110, 3439125, 3676500, 3932775, 4208490, 4518405, 4863600, 5245155, 5664150, 6121665,
				6739740, 7676775, 9098370, 11177325, 14093640, 18034515, 23194350, 29774745, 37984500, 48039615,
				60163290, 74585925, 91545120, 111285675, 134059590, 160126065, 189751500, 223209495, 260780850, 302753565,
				307564920, 312506775, 317581830, 322792785, 328142340, 333633195, 339268050, 345049605, 350980560, 357063615,
				363301470, 369696825, 376252380, 382970835, 389854890, 396907245, 404130600, 411527655, 419101110, 426853665,
				434788020, 442906875, 451212930, 459708885, 468397440, 477281295, 486363150, 495645705, 505131660, 514823715,
				524724570, 534836925, 545163480, 555706935, 566469990, 577455345, 588665700, 600103755, 611772210, 623673765,
				635811120, 648186975, 660804030, 673664985, 686772540, 724294215, 766577250, 813979845, 866867400, 925612515,
				0
			};
		}
	}

	// Token: 0x17000941 RID: 2369
	// (get) Token: 0x06002932 RID: 10546 RVA: 0x001273CC File Offset: 0x001255CC
	public ulong UInt64_0
	{
		get
		{
			ulong num = 0UL;
			if (this.Int32_50 > 0 && this.Int32_50 < 150)
			{
				for (int i = 1; i < this.Int32_50; i++)
				{
					num += (ulong)((long)Class527.Int32_11[i]);
				}
				return num;
			}
			return 0UL;
		}
	}

	// Token: 0x17000942 RID: 2370
	// (get) Token: 0x06002933 RID: 10547 RVA: 0x0001BD03 File Offset: 0x00019F03
	// (set) Token: 0x06002934 RID: 10548 RVA: 0x0001BD0B File Offset: 0x00019F0B
	public int Int32_12 { get; set; }

	// Token: 0x17000943 RID: 2371
	// (get) Token: 0x06002935 RID: 10549 RVA: 0x0001BD14 File Offset: 0x00019F14
	// (set) Token: 0x06002936 RID: 10550 RVA: 0x0001BD1C File Offset: 0x00019F1C
	public int Int32_13 { get; set; }

	// Token: 0x17000944 RID: 2372
	// (get) Token: 0x06002937 RID: 10551 RVA: 0x0001BD25 File Offset: 0x00019F25
	// (set) Token: 0x06002938 RID: 10552 RVA: 0x0001BD2D File Offset: 0x00019F2D
	public long Int64_2 { get; set; }

	// Token: 0x17000945 RID: 2373
	// (get) Token: 0x06002939 RID: 10553 RVA: 0x0001BD36 File Offset: 0x00019F36
	// (set) Token: 0x0600293A RID: 10554 RVA: 0x0001BD3E File Offset: 0x00019F3E
	public int Int32_14 { get; set; }

	// Token: 0x17000946 RID: 2374
	// (get) Token: 0x0600293B RID: 10555 RVA: 0x0001BD47 File Offset: 0x00019F47
	// (set) Token: 0x0600293C RID: 10556 RVA: 0x0001BD4F File Offset: 0x00019F4F
	public int Int32_15 { get; set; }

	// Token: 0x17000947 RID: 2375
	// (get) Token: 0x0600293D RID: 10557 RVA: 0x0001BD58 File Offset: 0x00019F58
	// (set) Token: 0x0600293E RID: 10558 RVA: 0x0001BD60 File Offset: 0x00019F60
	public int Int32_16 { get; set; }

	// Token: 0x17000948 RID: 2376
	// (get) Token: 0x0600293F RID: 10559 RVA: 0x0001BD69 File Offset: 0x00019F69
	// (set) Token: 0x06002940 RID: 10560 RVA: 0x0001BD71 File Offset: 0x00019F71
	public int Int32_17 { get; set; }

	// Token: 0x17000949 RID: 2377
	// (get) Token: 0x06002941 RID: 10561 RVA: 0x0001BD7A File Offset: 0x00019F7A
	// (set) Token: 0x06002942 RID: 10562 RVA: 0x0001BD82 File Offset: 0x00019F82
	public int Int32_18 { get; set; }

	// Token: 0x1700094A RID: 2378
	// (get) Token: 0x06002943 RID: 10563 RVA: 0x0001BD8B File Offset: 0x00019F8B
	// (set) Token: 0x06002944 RID: 10564 RVA: 0x0001BD93 File Offset: 0x00019F93
	public int Int32_19 { get; set; }

	// Token: 0x1700094B RID: 2379
	// (get) Token: 0x06002945 RID: 10565 RVA: 0x00127420 File Offset: 0x00125620
	public int Int32_20
	{
		get
		{
			if (!this.Class106_0.Boolean_67)
			{
				return this.Class515_0.method_7(new long[]
				{
					this.Class502_0.Int64_2[0],
					1136L
				});
			}
			return this.Class515_0.method_7(new long[]
			{
				this.Class502_0.Int64_2[0],
				117672L
			});
		}
	}

	// Token: 0x1700094C RID: 2380
	// (get) Token: 0x06002946 RID: 10566 RVA: 0x00127498 File Offset: 0x00125698
	public int Int32_21
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int32_23 = this.Class502_0.Int32_12;
			}
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_23 });
		}
	}

	// Token: 0x1700094D RID: 2381
	// (get) Token: 0x06002947 RID: 10567 RVA: 0x001274F0 File Offset: 0x001256F0
	public int Int32_22
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int32_24 = 25112;
			}
			if (this.Class106_0.Boolean_66)
			{
				this.Class502_0.Int32_24 = 7952;
			}
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_24 });
		}
	}

	// Token: 0x1700094E RID: 2382
	// (get) Token: 0x06002948 RID: 10568 RVA: 0x00127560 File Offset: 0x00125760
	public int Int32_23
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int32_25 = 30588;
			}
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_25 });
		}
	}

	// Token: 0x1700094F RID: 2383
	// (get) Token: 0x06002949 RID: 10569 RVA: 0x0001BD9C File Offset: 0x00019F9C
	public int Int32_24
	{
		get
		{
			return this.Class515_0.method_7(new long[]
			{
				this.Class106_0.Int64_0 + 11270564L,
				6476L
			});
		}
	}

	// Token: 0x17000950 RID: 2384
	// (get) Token: 0x0600294A RID: 10570 RVA: 0x001275B4 File Offset: 0x001257B4
	public int Int32_25
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int32_26 = 25124;
			}
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_26 });
		}
	}

	// Token: 0x17000951 RID: 2385
	// (get) Token: 0x0600294B RID: 10571 RVA: 0x00127608 File Offset: 0x00125808
	public int Int32_26
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int32_27 = 11872;
			}
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_27 });
		}
	}

	// Token: 0x17000952 RID: 2386
	// (get) Token: 0x0600294C RID: 10572 RVA: 0x0012765C File Offset: 0x0012585C
	public Class530 Class530_2
	{
		get
		{
			Class530 @class;
			if (!Class527.dictionary_7.TryGetValue(this.Int32_5, out @class))
			{
				return null;
			}
			return @class;
		}
	}

	// Token: 0x17000953 RID: 2387
	// (get) Token: 0x0600294D RID: 10573 RVA: 0x00127680 File Offset: 0x00125880
	public Class530 Class530_3
	{
		get
		{
			Class530 @class;
			if (!Class527.dictionary_8.TryGetValue(this.Int32_5, out @class))
			{
				return null;
			}
			return @class;
		}
	}

	// Token: 0x17000954 RID: 2388
	// (get) Token: 0x0600294E RID: 10574 RVA: 0x001276A4 File Offset: 0x001258A4
	public static Dictionary<int, int> Dictionary_0
	{
		get
		{
			return new Dictionary<int, int>
			{
				{
					Class537.int_6,
					889
				},
				{
					Class537.int_13,
					896
				},
				{
					Class537.int_12,
					895
				},
				{
					Class537.int_11,
					894
				},
				{
					Class537.int_10,
					893
				},
				{
					Class537.int_9,
					892
				},
				{
					Class537.int_5,
					885
				},
				{
					Class537.int_8,
					888
				},
				{
					Class537.int_0,
					883
				},
				{
					Class537.int_7,
					884
				},
				{
					Class537.int_4,
					890
				},
				{
					Class537.int_3,
					886
				},
				{
					Class537.int_1,
					887
				},
				{
					Class537.int_2,
					891
				},
				{
					Class537.int_14,
					988
				}
			};
		}
	}

	// Token: 0x17000955 RID: 2389
	// (get) Token: 0x0600294F RID: 10575 RVA: 0x001277A8 File Offset: 0x001259A8
	public static Dictionary<int, int> Dictionary_1
	{
		get
		{
			return new Dictionary<int, int>
			{
				{
					Class537.int_0,
					901
				},
				{
					Class537.int_7,
					902
				},
				{
					Class537.int_5,
					903
				},
				{
					Class537.int_3,
					904
				},
				{
					Class537.int_1,
					905
				},
				{
					Class537.int_8,
					906
				},
				{
					Class537.int_6,
					907
				},
				{
					Class537.int_4,
					908
				},
				{
					Class537.int_2,
					909
				},
				{
					Class537.int_9,
					910
				},
				{
					Class537.int_10,
					911
				},
				{
					Class537.int_11,
					912
				},
				{
					Class537.int_12,
					913
				},
				{
					Class537.int_13,
					914
				},
				{
					Class537.int_14,
					915
				}
			};
		}
	}

	// Token: 0x17000956 RID: 2390
	// (get) Token: 0x06002950 RID: 10576 RVA: 0x0001BDD3 File Offset: 0x00019FD3
	public bool Boolean_6
	{
		get
		{
			return Class527.Dictionary_0.ContainsValue(this.Int32_35);
		}
	}

	// Token: 0x17000957 RID: 2391
	// (get) Token: 0x06002951 RID: 10577 RVA: 0x0001BDE5 File Offset: 0x00019FE5
	// (set) Token: 0x06002952 RID: 10578 RVA: 0x0001BDED File Offset: 0x00019FED
	public int Int32_27 { get; set; }

	// Token: 0x17000958 RID: 2392
	// (get) Token: 0x06002953 RID: 10579 RVA: 0x0001BDF6 File Offset: 0x00019FF6
	// (set) Token: 0x06002954 RID: 10580 RVA: 0x0001BDFE File Offset: 0x00019FFE
	public int Int32_28 { get; set; }

	// Token: 0x17000959 RID: 2393
	// (get) Token: 0x06002955 RID: 10581 RVA: 0x0001BE07 File Offset: 0x0001A007
	// (set) Token: 0x06002956 RID: 10582 RVA: 0x0001BE0F File Offset: 0x0001A00F
	public int Int32_29 { get; set; }

	// Token: 0x1700095A RID: 2394
	// (get) Token: 0x06002957 RID: 10583 RVA: 0x0001BE18 File Offset: 0x0001A018
	// (set) Token: 0x06002958 RID: 10584 RVA: 0x0001BE20 File Offset: 0x0001A020
	public int Int32_30 { get; set; }

	// Token: 0x1700095B RID: 2395
	// (get) Token: 0x06002959 RID: 10585 RVA: 0x0001BE29 File Offset: 0x0001A029
	public bool Boolean_7
	{
		get
		{
			return this.Class106_0.List_10.Count >= this.Int32_27;
		}
	}

	// Token: 0x1700095C RID: 2396
	// (get) Token: 0x0600295A RID: 10586 RVA: 0x0001BE46 File Offset: 0x0001A046
	public bool Boolean_8
	{
		get
		{
			return this.Class106_0.List_11.Count >= this.Int32_28;
		}
	}

	// Token: 0x1700095D RID: 2397
	// (get) Token: 0x0600295B RID: 10587 RVA: 0x001278AC File Offset: 0x00125AAC
	public string String_2
	{
		get
		{
			return this.Class515_0.method_12(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_6 }).ToString("X8");
		}
	}

	// Token: 0x1700095E RID: 2398
	// (get) Token: 0x0600295C RID: 10588 RVA: 0x0001BE63 File Offset: 0x0001A063
	// (set) Token: 0x0600295D RID: 10589 RVA: 0x0001BE6B File Offset: 0x0001A06B
	public string String_3 { get; set; } = string.Empty;

	// Token: 0x1700095F RID: 2399
	// (get) Token: 0x0600295E RID: 10590 RVA: 0x0001BE74 File Offset: 0x0001A074
	// (set) Token: 0x0600295F RID: 10591 RVA: 0x0001BE7C File Offset: 0x0001A07C
	public int Int32_31 { get; set; }

	// Token: 0x17000960 RID: 2400
	// (get) Token: 0x06002960 RID: 10592 RVA: 0x001278F0 File Offset: 0x00125AF0
	public string String_4
	{
		get
		{
			long num = this.Class515_0.method_4("UI_CEGUI.dll");
			if (this.Class502_0.Int32_5 == 5)
			{
				num += 538584L;
			}
			else if (this.Class502_0.Int32_5 == 1)
			{
				num += 568360L;
			}
			else
			{
				num += 226052L;
			}
			return this.Class515_0.method_16(new long[] { this.Class515_0.method_9(new long[] { num }) });
		}
	}

	// Token: 0x17000961 RID: 2401
	// (get) Token: 0x06002961 RID: 10593 RVA: 0x0001BE85 File Offset: 0x0001A085
	// (set) Token: 0x06002962 RID: 10594 RVA: 0x0001BE8D File Offset: 0x0001A08D
	public bool Boolean_9 { get; set; }

	// Token: 0x17000962 RID: 2402
	// (get) Token: 0x06002963 RID: 10595 RVA: 0x0001BE96 File Offset: 0x0001A096
	public int Int32_32
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_9);
		}
	}

	// Token: 0x17000963 RID: 2403
	// (get) Token: 0x06002964 RID: 10596 RVA: 0x0001BEAE File Offset: 0x0001A0AE
	// (set) Token: 0x06002965 RID: 10597 RVA: 0x0001BEB6 File Offset: 0x0001A0B6
	public int Int32_33 { get; set; }

	// Token: 0x17000964 RID: 2404
	// (get) Token: 0x06002966 RID: 10598 RVA: 0x0001BE96 File Offset: 0x0001A096
	public int Int32_34
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_9);
		}
	}

	// Token: 0x17000965 RID: 2405
	// (get) Token: 0x06002967 RID: 10599 RVA: 0x0001BEBF File Offset: 0x0001A0BF
	public bool Boolean_10
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_10) == 1;
		}
	}

	// Token: 0x17000966 RID: 2406
	// (get) Token: 0x06002968 RID: 10600 RVA: 0x0001BEDA File Offset: 0x0001A0DA
	// (set) Token: 0x06002969 RID: 10601 RVA: 0x0001BEE2 File Offset: 0x0001A0E2
	public string String_5 { get; set; }

	// Token: 0x17000967 RID: 2407
	// (get) Token: 0x0600296A RID: 10602 RVA: 0x0001BEEB File Offset: 0x0001A0EB
	// (set) Token: 0x0600296B RID: 10603 RVA: 0x0001BEF3 File Offset: 0x0001A0F3
	public int Int32_35 { get; set; }

	// Token: 0x17000968 RID: 2408
	// (get) Token: 0x0600296C RID: 10604 RVA: 0x0001BEFC File Offset: 0x0001A0FC
	public int Int32_36
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_6);
		}
	}

	// Token: 0x17000969 RID: 2409
	// (get) Token: 0x0600296D RID: 10605 RVA: 0x0001BF14 File Offset: 0x0001A114
	// (set) Token: 0x0600296E RID: 10606 RVA: 0x0001BF1C File Offset: 0x0001A11C
	public string String_6 { get; set; }

	// Token: 0x1700096A RID: 2410
	// (get) Token: 0x0600296F RID: 10607 RVA: 0x0001BF25 File Offset: 0x0001A125
	// (set) Token: 0x06002970 RID: 10608 RVA: 0x0001BF2D File Offset: 0x0001A12D
	public string String_7 { get; set; }

	// Token: 0x1700096B RID: 2411
	// (get) Token: 0x06002971 RID: 10609 RVA: 0x0001BF36 File Offset: 0x0001A136
	// (set) Token: 0x06002972 RID: 10610 RVA: 0x0001BF3E File Offset: 0x0001A13E
	public int Int32_37 { get; set; }

	// Token: 0x1700096C RID: 2412
	// (get) Token: 0x06002973 RID: 10611 RVA: 0x0001BF47 File Offset: 0x0001A147
	// (set) Token: 0x06002974 RID: 10612 RVA: 0x0001BF4F File Offset: 0x0001A14F
	public string String_8 { get; set; }

	// Token: 0x1700096D RID: 2413
	// (get) Token: 0x06002975 RID: 10613 RVA: 0x0001BF58 File Offset: 0x0001A158
	// (set) Token: 0x06002976 RID: 10614 RVA: 0x0001BF60 File Offset: 0x0001A160
	public int Int32_38 { get; set; }

	// Token: 0x1700096E RID: 2414
	// (get) Token: 0x06002977 RID: 10615 RVA: 0x0001BF69 File Offset: 0x0001A169
	public int Int32_39
	{
		get
		{
			return this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_7 });
		}
	}

	// Token: 0x1700096F RID: 2415
	// (get) Token: 0x06002978 RID: 10616 RVA: 0x0001BF92 File Offset: 0x0001A192
	public int Int32_40
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_45);
		}
	}

	// Token: 0x17000970 RID: 2416
	// (get) Token: 0x06002979 RID: 10617 RVA: 0x0001BFAA File Offset: 0x0001A1AA
	public bool Boolean_11
	{
		get
		{
			return !this.Boolean_12 && !this.Boolean_43 && !this.Boolean_36 && !this.Boolean_37 && !this.Boolean_41;
		}
	}

	// Token: 0x17000971 RID: 2417
	// (get) Token: 0x0600297A RID: 10618 RVA: 0x0001BFD7 File Offset: 0x0001A1D7
	// (set) Token: 0x0600297B RID: 10619 RVA: 0x0001BFDF File Offset: 0x0001A1DF
	public bool Boolean_12 { get; set; }

	// Token: 0x17000972 RID: 2418
	// (get) Token: 0x0600297C RID: 10620 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
	// (set) Token: 0x0600297D RID: 10621 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
	public bool Boolean_13 { get; set; }

	// Token: 0x17000973 RID: 2419
	// (get) Token: 0x0600297E RID: 10622 RVA: 0x0001BFF9 File Offset: 0x0001A1F9
	public bool Boolean_14
	{
		get
		{
			return this.Class106_0.Class506_0.Class504_1 != null && this.Class106_0.Class506_0.Class504_1.List_0.Contains(271);
		}
	}

	// Token: 0x17000974 RID: 2420
	// (get) Token: 0x0600297F RID: 10623 RVA: 0x0001C02E File Offset: 0x0001A22E
	public int Int32_41
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_7);
		}
	}

	// Token: 0x17000975 RID: 2421
	// (get) Token: 0x06002980 RID: 10624 RVA: 0x0001C046 File Offset: 0x0001A246
	public int Int32_42
	{
		get
		{
			return Class527.smethod_0(this.Int32_8, this.Int32_12, true);
		}
	}

	// Token: 0x17000976 RID: 2422
	// (get) Token: 0x06002981 RID: 10625 RVA: 0x0001C05A File Offset: 0x0001A25A
	public int Int32_43
	{
		get
		{
			return Class527.smethod_0(this.Int32_9, this.Int32_13, true);
		}
	}

	// Token: 0x17000977 RID: 2423
	// (get) Token: 0x06002982 RID: 10626 RVA: 0x0001C06E File Offset: 0x0001A26E
	public int Int32_44
	{
		get
		{
			return Class527.smethod_0(this.Int32_14, this.Int32_15, true);
		}
	}

	// Token: 0x17000978 RID: 2424
	// (get) Token: 0x06002983 RID: 10627 RVA: 0x0001C082 File Offset: 0x0001A282
	public bool Boolean_15
	{
		get
		{
			return this.Int32_33 != 5 && (this.Int32_33 > 2 && this.Int32_33 < 10);
		}
	}

	// Token: 0x17000979 RID: 2425
	// (get) Token: 0x06002984 RID: 10628 RVA: 0x0001C0A5 File Offset: 0x0001A2A5
	public bool Boolean_16
	{
		get
		{
			if (this.Int32_33 <= 0)
			{
				return false;
			}
			if (this.Int32_33 != 2)
			{
				if (this.Int32_33 != 7)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x1700097A RID: 2426
	// (get) Token: 0x06002985 RID: 10629 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
	public bool Boolean_17
	{
		get
		{
			this.Int32_33 = this.Int32_34;
			if (this.Int32_33 <= 0)
			{
				return false;
			}
			if (this.Int32_33 != 2)
			{
				if (this.Int32_33 != 7)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x1700097B RID: 2427
	// (get) Token: 0x06002986 RID: 10630 RVA: 0x0001C0F9 File Offset: 0x0001A2F9
	public int Int32_45
	{
		get
		{
			if (this.Int32_50 > 0 && this.Int32_50 < 150)
			{
				return Class527.Int32_11[this.Int32_50];
			}
			return Class527.Int32_11[1];
		}
	}

	// Token: 0x1700097C RID: 2428
	// (get) Token: 0x06002987 RID: 10631 RVA: 0x0001C125 File Offset: 0x0001A325
	public float Single_2
	{
		get
		{
			return (float)this.Int32_10 * 100f / (float)this.Int32_45;
		}
	}

	// Token: 0x1700097D RID: 2429
	// (get) Token: 0x06002988 RID: 10632 RVA: 0x0012797C File Offset: 0x00125B7C
	public bool Boolean_18
	{
		get
		{
			return this.Int32_5 == Class537.int_11 || this.Int32_5 == Class537.int_3 || this.Int32_5 == Class537.int_6 || this.Int32_5 == Class537.int_4 || this.Int32_5 == Class537.int_10 || this.Int32_5 == Class537.int_5 || this.Int32_5 == Class537.int_8 || this.Int32_5 == Class537.int_12 || this.Int32_5 == Class537.int_13;
		}
	}

	// Token: 0x1700097E RID: 2430
	// (get) Token: 0x06002989 RID: 10633 RVA: 0x0001C13C File Offset: 0x0001A33C
	public bool Boolean_19
	{
		get
		{
			return !this.Boolean_18;
		}
	}

	// Token: 0x1700097F RID: 2431
	// (get) Token: 0x0600298A RID: 10634 RVA: 0x0001C147 File Offset: 0x0001A347
	// (set) Token: 0x0600298B RID: 10635 RVA: 0x0001C14F File Offset: 0x0001A34F
	public bool Boolean_20 { get; set; }

	// Token: 0x17000980 RID: 2432
	// (get) Token: 0x0600298C RID: 10636 RVA: 0x0001C158 File Offset: 0x0001A358
	public bool Boolean_21
	{
		get
		{
			return this.Boolean_41 && this.String_10.Contains(this.String_5);
		}
	}

	// Token: 0x17000981 RID: 2433
	// (get) Token: 0x0600298D RID: 10637 RVA: 0x00127A00 File Offset: 0x00125C00
	public int Int32_46
	{
		get
		{
			int num = 0;
			int num2 = this.Class515_0.method_7(this.Class502_0.Int64_2);
			for (int i = 0; i < 20; i++)
			{
				int num3 = num2 + this.Class502_0.Int32_28 * i + this.Class502_0.Int32_29;
				int num4 = num2 + this.Class502_0.Int32_28 * i + this.Class502_0.Int32_31;
				int num5 = this.Class515_0.method_7(new long[] { (long)num3 });
				int num6 = this.Class515_0.method_7(new long[] { (long)num4 });
				if (num5 > 0 && num6 > 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	// Token: 0x17000982 RID: 2434
	// (get) Token: 0x0600298E RID: 10638 RVA: 0x0001C17A File Offset: 0x0001A37A
	// (set) Token: 0x0600298F RID: 10639 RVA: 0x0001C182 File Offset: 0x0001A382
	public bool Boolean_22 { get; set; }

	// Token: 0x17000983 RID: 2435
	// (get) Token: 0x06002990 RID: 10640 RVA: 0x0001C18B File Offset: 0x0001A38B
	public bool Boolean_23
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_41) == 1;
		}
	}

	// Token: 0x17000984 RID: 2436
	// (get) Token: 0x06002991 RID: 10641 RVA: 0x00127AB0 File Offset: 0x00125CB0
	public bool Boolean_24
	{
		get
		{
			if (!this.Class106_0.Boolean_67)
			{
				return this.Class515_0.method_7(new long[] { 6563448L, 0L, 12L, 100L }) == 1;
			}
			return this.Class515_0.method_7(new long[] { 11421928L, 8L, 4L, 332L }) == 1;
		}
	}

	// Token: 0x17000985 RID: 2437
	// (get) Token: 0x06002992 RID: 10642 RVA: 0x00127B0C File Offset: 0x00125D0C
	public bool Boolean_25
	{
		get
		{
			if (this.Class502_0.Int32_5 == 5)
			{
				return this.Class515_0.method_7(new long[]
				{
					this.Class106_0.Int64_0 + 7310568L,
					0L,
					24L,
					128L
				}) == 1;
			}
			if (this.Class106_0.Boolean_67)
			{
				Class515 @class = this.Class515_0;
				long[] array = new long[] { 0L, 8L, 4L, 324L };
				array[0] = this.Class106_0.Int64_0 + 12155344L;
				return @class.method_7(array) == 1;
			}
			if (this.Class106_0.Boolean_68)
			{
				return this.Class515_0.method_7(new long[] { 6549984L, 0L, 12L, 100L }) == 1;
			}
			return this.Class515_0.method_7(new long[]
			{
				this.Class106_0.Int64_0 + 3579496L,
				0L,
				12L,
				88L
			}) == 1;
		}
	}

	// Token: 0x17000986 RID: 2438
	// (get) Token: 0x06002993 RID: 10643 RVA: 0x00127C24 File Offset: 0x00125E24
	public bool Boolean_26
	{
		get
		{
			if (this.Int32_35 == Class513.Int32_139)
			{
				return false;
			}
			if (this.Boolean_22)
			{
				return false;
			}
			if (this.Boolean_14)
			{
				return false;
			}
			if (this.Int32_35 == Class513.Int32_83)
			{
				return false;
			}
			if (this.Int32_35 == Class513.Int32_82)
			{
				return false;
			}
			if (this.Int32_35 == Class513.Int32_142)
			{
				return false;
			}
			if (Class226.Boolean_58)
			{
				return false;
			}
			if (this.Boolean_46)
			{
				return false;
			}
			if (this.Class106_0.Class502_0.Int32_5 != 1 && this.Boolean_14)
			{
				return false;
			}
			if (!Class226.Boolean_58 && this.Int32_50 >= 10)
			{
				if (this.Int32_35 != Class513.Int32_146)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x17000987 RID: 2439
	// (get) Token: 0x06002994 RID: 10644 RVA: 0x00127CD4 File Offset: 0x00125ED4
	public string String_9
	{
		get
		{
			string text = "None";
			if (Class501.Dictionary_0.ContainsKey(this.Int32_5))
			{
				text = Class501.Dictionary_0[this.Int32_5];
			}
			if (Class226.Boolean_61)
			{
				using (Dictionary<string, string>.Enumerator enumerator = Class501.Dictionary_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						if (keyValuePair.Value == text)
						{
							return keyValuePair.Key;
						}
					}
					return text;
				}
				string text2;
				return text2;
			}
			return text;
		}
	}

	// Token: 0x17000988 RID: 2440
	// (get) Token: 0x06002995 RID: 10645 RVA: 0x0001C1A6 File Offset: 0x0001A3A6
	public Class530 Class530_4
	{
		get
		{
			if (!this.dictionary_3.ContainsKey(this.Int32_5))
			{
				return null;
			}
			return this.dictionary_3[this.Int32_5];
		}
	}

	// Token: 0x17000989 RID: 2441
	// (get) Token: 0x06002996 RID: 10646 RVA: 0x00127D6C File Offset: 0x00125F6C
	public Class530 Class530_5
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				if (this.Int32_35 == Class572.int_0)
				{
					return Class572.class530_27;
				}
				if (this.Int32_35 == Class577.int_0)
				{
					return Class577.class530_5;
				}
				if (this.Int32_35 == Class583.int_0)
				{
					return Class583.class530_1;
				}
				if (this.Int32_35 == Class579.int_0)
				{
					return Class579.class530_11;
				}
				return Class576.class530_25;
			}
			else
			{
				if (this.Int32_35 == Class584.int_0 && !this.Class106_0.Boolean_44)
				{
					return Class584.class530_25;
				}
				if (this.Int32_35 == Class576.int_0 && !this.Class106_0.Boolean_45)
				{
					return Class576.class530_24;
				}
				if (this.Int32_35 == Class572.int_0)
				{
					if (this.Class106_0.Boolean_66)
					{
						return Class572.class530_1;
					}
					return Class572.class530_29;
				}
				else
				{
					if (this.Int32_35 == Class584.int_0)
					{
						return Class584.class530_46;
					}
					if (this.Int32_35 == Class576.int_0)
					{
						return Class576.class530_27;
					}
					if (this.Int32_35 == Class577.int_0)
					{
						return Class577.class530_5;
					}
					if (this.Int32_35 == Class583.int_0)
					{
						return Class583.class530_2;
					}
					if (this.Int32_35 == Class579.int_0)
					{
						return Class579.class530_11;
					}
					return Class576.class530_27;
				}
			}
		}
	}

	// Token: 0x1700098A RID: 2442
	// (get) Token: 0x06002997 RID: 10647 RVA: 0x0001C1CE File Offset: 0x0001A3CE
	public Class530 Class530_6
	{
		get
		{
			if (!this.dictionary_2.ContainsKey(this.Int32_5))
			{
				return null;
			}
			return this.dictionary_2[this.Int32_5];
		}
	}

	// Token: 0x1700098B RID: 2443
	// (get) Token: 0x06002998 RID: 10648 RVA: 0x0001C1F6 File Offset: 0x0001A3F6
	public Class530 Class530_7
	{
		get
		{
			if (!this.dictionary_6.ContainsKey(this.Int32_5))
			{
				return null;
			}
			return this.dictionary_6[this.Int32_5];
		}
	}

	// Token: 0x1700098C RID: 2444
	// (get) Token: 0x06002999 RID: 10649 RVA: 0x0001C21E File Offset: 0x0001A41E
	public int Int32_47
	{
		get
		{
			if (!Class527.dictionary_1.ContainsKey(this.Int32_5))
			{
				return -1;
			}
			return Class527.dictionary_1[this.Int32_5];
		}
	}

	// Token: 0x1700098D RID: 2445
	// (get) Token: 0x0600299A RID: 10650 RVA: 0x0001C244 File Offset: 0x0001A444
	public int Int32_48
	{
		get
		{
			if (!Class527.dictionary_5.ContainsKey(this.Int32_5))
			{
				return -1;
			}
			return Class527.dictionary_5[this.Int32_5];
		}
	}

	// Token: 0x1700098E RID: 2446
	// (get) Token: 0x0600299B RID: 10651 RVA: 0x0001C26A File Offset: 0x0001A46A
	public int Int32_49
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(this.Class106_0.Class502_0.Int64_34);
		}
	}

	// Token: 0x1700098F RID: 2447
	// (get) Token: 0x0600299C RID: 10652 RVA: 0x00127EA4 File Offset: 0x001260A4
	public List<Class517> List_0
	{
		get
		{
			List<Class517> list = new List<Class517>();
			long num = this.Class515_0.method_9(this.Class502_0.Int64_2);
			int num2 = 0;
			for (int i = 0; i < 10; i++)
			{
				int num3 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_29 });
				if (num3 > 0)
				{
					string text = string.Empty;
					int num4 = ((this.Class502_0.Int32_5 == 5 || this.Class502_0.Int32_5 == 1) ? 32 : 28);
					text = this.Class515_0.method_2(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + (long)num4 }).Trim();
					if (!string.IsNullOrEmpty(text))
					{
						Class517 @class = new Class517();
						@class.Int32_9 = num2;
						if (num3 == this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_15 }))
						{
							@class.Boolean_0 = true;
						}
						num2++;
						@class.Int64_0 = num + (long)(this.Class502_0.Int32_28 * i);
						@class.String_0 = num3.ToString("X8");
						@class.Int32_2 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_32 });
						@class.Int32_3 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_34 });
						if (this.Class502_0.Int32_5 == 3)
						{
							@class.Int32_4 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 180L });
							@class.Int32_5 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 192L });
							@class.Int32_6 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 184L });
							@class.Int32_8 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 196L });
							@class.Int32_7 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 188L });
						}
						else if (this.Class502_0.Int32_5 == 2)
						{
							@class.Int32_4 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 132L });
							@class.Int32_5 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 144L });
							@class.Int32_6 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 136L });
							@class.Int32_8 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 148L });
							@class.Int32_7 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 140L });
						}
						else if (this.Class502_0.Int32_5 == 5)
						{
							@class.Int32_4 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 196L });
							@class.Int32_5 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 208L });
							@class.Int32_6 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 200L });
							@class.Int32_8 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 212L });
							@class.Int32_7 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 204L });
						}
						else
						{
							@class.Int32_4 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 188L });
							@class.Int32_5 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 200L });
							@class.Int32_6 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 192L });
							@class.Int32_8 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 204L });
							@class.Int32_7 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 196L });
						}
						@class.Int32_1 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 108L });
						@class.Int32_0 = this.Class515_0.method_7(new long[] { num + (long)(this.Class502_0.Int32_28 * i) + 104L });
						@class.String_1 = text;
						if (!(@class.String_1.smethod_36() == "thiemdiendieu") && !@class.String_1.smethod_36().Contains("nier"))
						{
							list.Add(@class);
						}
					}
				}
			}
			return list;
		}
	}

	// Token: 0x17000990 RID: 2448
	// (get) Token: 0x0600299D RID: 10653 RVA: 0x00128578 File Offset: 0x00126778
	public ValueTuple<int, int>[] ValueTuple_0
	{
		get
		{
			ValueTuple<int, int>[] array;
			if (this.dictionary_9.TryGetValue(this.Int32_5, out array) && array.Length != 0)
			{
				return array;
			}
			return null;
		}
	}

	// Token: 0x17000991 RID: 2449
	// (get) Token: 0x0600299E RID: 10654 RVA: 0x001285A4 File Offset: 0x001267A4
	public Class530 Class530_8
	{
		get
		{
			Class530 @class;
			if (!this.dictionary_10.TryGetValue(this.Int32_5, out @class))
			{
				return null;
			}
			return @class;
		}
	}

	// Token: 0x17000992 RID: 2450
	// (get) Token: 0x0600299F RID: 10655 RVA: 0x0001C28C File Offset: 0x0001A48C
	// (set) Token: 0x060029A0 RID: 10656 RVA: 0x0001C294 File Offset: 0x0001A494
	public bool Boolean_27 { get; set; }

	// Token: 0x17000993 RID: 2451
	// (get) Token: 0x060029A1 RID: 10657 RVA: 0x0001C29D File Offset: 0x0001A49D
	// (set) Token: 0x060029A2 RID: 10658 RVA: 0x0001C2A5 File Offset: 0x0001A4A5
	public bool Boolean_28 { get; set; }

	// Token: 0x17000994 RID: 2452
	// (get) Token: 0x060029A3 RID: 10659 RVA: 0x0001C2AE File Offset: 0x0001A4AE
	// (set) Token: 0x060029A4 RID: 10660 RVA: 0x0001C2B6 File Offset: 0x0001A4B6
	public bool Boolean_29 { get; set; }

	// Token: 0x17000995 RID: 2453
	// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0001C2BF File Offset: 0x0001A4BF
	// (set) Token: 0x060029A6 RID: 10662 RVA: 0x0001C2C7 File Offset: 0x0001A4C7
	public bool Boolean_30 { get; set; }

	// Token: 0x17000996 RID: 2454
	// (get) Token: 0x060029A7 RID: 10663 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
	// (set) Token: 0x060029A8 RID: 10664 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
	public bool Boolean_31 { get; set; }

	// Token: 0x17000997 RID: 2455
	// (get) Token: 0x060029A9 RID: 10665 RVA: 0x0001C2E1 File Offset: 0x0001A4E1
	// (set) Token: 0x060029AA RID: 10666 RVA: 0x0001C2E9 File Offset: 0x0001A4E9
	public bool Boolean_32 { get; set; }

	// Token: 0x17000998 RID: 2456
	// (get) Token: 0x060029AB RID: 10667 RVA: 0x0001C2F2 File Offset: 0x0001A4F2
	// (set) Token: 0x060029AC RID: 10668 RVA: 0x0001C2FA File Offset: 0x0001A4FA
	public bool Boolean_33 { get; set; }

	// Token: 0x17000999 RID: 2457
	// (get) Token: 0x060029AD RID: 10669 RVA: 0x0001C303 File Offset: 0x0001A503
	// (set) Token: 0x060029AE RID: 10670 RVA: 0x0001C30B File Offset: 0x0001A50B
	public bool Boolean_34 { get; set; }

	// Token: 0x1700099A RID: 2458
	// (get) Token: 0x060029AF RID: 10671 RVA: 0x0001C314 File Offset: 0x0001A514
	// (set) Token: 0x060029B0 RID: 10672 RVA: 0x0001C31C File Offset: 0x0001A51C
	public bool Boolean_35 { get; set; }

	// Token: 0x1700099B RID: 2459
	// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0001C325 File Offset: 0x0001A525
	// (set) Token: 0x060029B2 RID: 10674 RVA: 0x0001C32D File Offset: 0x0001A52D
	public bool Boolean_36 { get; set; }

	// Token: 0x1700099C RID: 2460
	// (get) Token: 0x060029B3 RID: 10675 RVA: 0x0001C336 File Offset: 0x0001A536
	// (set) Token: 0x060029B4 RID: 10676 RVA: 0x0001C33E File Offset: 0x0001A53E
	public bool Boolean_37 { get; set; }

	// Token: 0x1700099D RID: 2461
	// (get) Token: 0x060029B5 RID: 10677 RVA: 0x0001C347 File Offset: 0x0001A547
	// (set) Token: 0x060029B6 RID: 10678 RVA: 0x0001C34F File Offset: 0x0001A54F
	public bool Boolean_38 { get; set; }

	// Token: 0x1700099E RID: 2462
	// (get) Token: 0x060029B7 RID: 10679 RVA: 0x0001C358 File Offset: 0x0001A558
	// (set) Token: 0x060029B8 RID: 10680 RVA: 0x0001C360 File Offset: 0x0001A560
	public bool Boolean_39 { get; set; }

	// Token: 0x1700099F RID: 2463
	// (get) Token: 0x060029B9 RID: 10681 RVA: 0x0001C369 File Offset: 0x0001A569
	public bool Boolean_40
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_43) == 1;
		}
	}

	// Token: 0x170009A0 RID: 2464
	// (get) Token: 0x060029BA RID: 10682 RVA: 0x0001C384 File Offset: 0x0001A584
	// (set) Token: 0x060029BB RID: 10683 RVA: 0x0001C38C File Offset: 0x0001A58C
	public bool Boolean_41 { get; set; }

	// Token: 0x170009A1 RID: 2465
	// (get) Token: 0x060029BC RID: 10684 RVA: 0x0001C395 File Offset: 0x0001A595
	// (set) Token: 0x060029BD RID: 10685 RVA: 0x0001C39D File Offset: 0x0001A59D
	public bool Boolean_42 { get; set; }

	// Token: 0x170009A2 RID: 2466
	// (get) Token: 0x060029BE RID: 10686 RVA: 0x0001C3A6 File Offset: 0x0001A5A6
	// (set) Token: 0x060029BF RID: 10687 RVA: 0x0001C3AE File Offset: 0x0001A5AE
	public int Int32_50 { get; set; }

	// Token: 0x170009A3 RID: 2467
	// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0001C3B7 File Offset: 0x0001A5B7
	// (set) Token: 0x060029C1 RID: 10689 RVA: 0x0001C3BF File Offset: 0x0001A5BF
	public long Int64_3 { get; set; }

	// Token: 0x170009A4 RID: 2468
	// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
	// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
	public string String_10 { get; set; } = string.Empty;

	// Token: 0x170009A5 RID: 2469
	// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0001C3D9 File Offset: 0x0001A5D9
	// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0001C3E1 File Offset: 0x0001A5E1
	public string String_11 { get; set; } = "OFFLINE";

	// Token: 0x170009A6 RID: 2470
	// (get) Token: 0x060029C6 RID: 10694 RVA: 0x0001C3EA File Offset: 0x0001A5EA
	// (set) Token: 0x060029C7 RID: 10695 RVA: 0x0001C3F2 File Offset: 0x0001A5F2
	public string String_12 { get; set; } = string.Empty;

	// Token: 0x170009A7 RID: 2471
	// (get) Token: 0x060029C8 RID: 10696 RVA: 0x0001C3FB File Offset: 0x0001A5FB
	// (set) Token: 0x060029C9 RID: 10697 RVA: 0x0001C403 File Offset: 0x0001A603
	public bool Boolean_43 { get; set; }

	// Token: 0x170009A8 RID: 2472
	// (get) Token: 0x060029CA RID: 10698 RVA: 0x0001C40C File Offset: 0x0001A60C
	public bool Boolean_44
	{
		get
		{
			return this.Class515_0.method_7(this.Class502_0.Int64_46) == 1;
		}
	}

	// Token: 0x170009A9 RID: 2473
	// (get) Token: 0x060029CB RID: 10699 RVA: 0x0001C427 File Offset: 0x0001A627
	public bool Boolean_45
	{
		get
		{
			return !this.Boolean_41;
		}
	}

	// Token: 0x170009AA RID: 2474
	// (get) Token: 0x060029CC RID: 10700 RVA: 0x0001C432 File Offset: 0x0001A632
	// (set) Token: 0x060029CD RID: 10701 RVA: 0x0001C43A File Offset: 0x0001A63A
	public bool Boolean_46 { get; set; }

	// Token: 0x170009AB RID: 2475
	// (get) Token: 0x060029CE RID: 10702 RVA: 0x0001C443 File Offset: 0x0001A643
	// (set) Token: 0x060029CF RID: 10703 RVA: 0x0001C44A File Offset: 0x0001A64A
	public static int Int32_51 { get; set; } = 76;

	// Token: 0x170009AC RID: 2476
	// (get) Token: 0x060029D0 RID: 10704 RVA: 0x0001C452 File Offset: 0x0001A652
	// (set) Token: 0x060029D1 RID: 10705 RVA: 0x0001C45A File Offset: 0x0001A65A
	public string String_13 { get; set; }

	// Token: 0x170009AD RID: 2477
	// (get) Token: 0x060029D2 RID: 10706 RVA: 0x0001C463 File Offset: 0x0001A663
	public bool Boolean_47
	{
		get
		{
			return this.Class106_0.List_10.Any<Class516>(new Func<Class516, bool>(Class527.Class528.f_78D49EE1.method_0));
		}
	}

	// Token: 0x170009AE RID: 2478
	// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0001C494 File Offset: 0x0001A694
	// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0001C49C File Offset: 0x0001A69C
	public string[] String_14 { get; set; } = new string[4];

	// Token: 0x060029D5 RID: 10709 RVA: 0x001285CC File Offset: 0x001267CC
	public void method_0()
	{
		int num = this.Class106_0.Class515_0.method_7(new long[] { this.Class106_0.Int64_0 + 13118084L }) + 4767964;
		for (int i = 0; i < 4; i++)
		{
			int[] array = new int[4];
			for (int j = 0; j < 4; j++)
			{
				array[j] = this.Class106_0.Class515_0.method_11(new long[] { (long)(num + i * 16 + j * 2) });
			}
			this.String_14[i] = string.Concat<char>(array.Select<int, char>(new Func<int, char>(Class527.Class528.f_78D49EE1.method_1)));
		}
		Class515 @class = this.Class106_0.Class515_0;
		long[] array2 = new long[]
		{
			0L, 28L, 16L, 36L, 68L, 12L, 212L, 0L, 104L, 8L,
			240L
		};
		array2[0] = this.Class106_0.Int64_0 + 13145600L;
		int num2 = @class.method_7(array2);
		byte[] array3 = new byte[9216];
		Class515.smethod_6(this.Class515_0.IntPtr_0, (long)num2, array3, array3.Length, 0);
		string text = "";
		for (int k = 0; k < 9216; k += 2)
		{
			text += (((ushort)((int)array3[k] | ((int)array3[k + 1] << 8)) == 40960) ? '0' : '1').ToString();
		}
		this.String_3 = string.Concat(new string[]
		{
			text.smethod_19(),
			this.String_14[0],
			this.String_14[1],
			this.String_14[2],
			this.String_14[3]
		});
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x0001C4A5 File Offset: 0x0001A6A5
	public bool method_1(int int_26)
	{
		return int_26 >= 663 && int_26 <= 667;
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x0001C4BC File Offset: 0x0001A6BC
	public bool method_2(int int_26)
	{
		return int_26 >= 501 && int_26 <= 545;
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x0001C4D3 File Offset: 0x0001A6D3
	private static int smethod_0(int int_26, int int_27, bool bool_24 = true)
	{
		if (int_27 == 0)
		{
			return 0;
		}
		if (int_26 * 100 / int_27 == 0 && int_26 > 0)
		{
			return 1;
		}
		if (bool_24 && int_26 * 100 / int_27 >= 100)
		{
			return 99;
		}
		return int_26 * 100 / int_27;
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x0001C4FE File Offset: 0x0001A6FE
	public static string smethod_1(string string_11)
	{
		return Class527.smethod_2(Class531.smethod_18(string_11));
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x00128784 File Offset: 0x00126984
	public static string smethod_2(int int_26)
	{
		string text;
		if (!Class501.Dictionary_0.TryGetValue(int_26, out text))
		{
			return "None";
		}
		return text;
	}

	// Token: 0x170009AF RID: 2479
	// (get) Token: 0x060029DB RID: 10715 RVA: 0x001287A8 File Offset: 0x001269A8
	public int Int32_52
	{
		get
		{
			try
			{
				foreach (Class514 @class in this.Class106_0.Class515_0.method_6())
				{
					if (@class.String_1.ToLower().Contains("antivirus"))
					{
						return (int)@class.Int64_0;
					}
				}
			}
			catch
			{
			}
			return 0;
		}
	}

	// Token: 0x170009B0 RID: 2480
	// (get) Token: 0x060029DC RID: 10716 RVA: 0x0001C50B File Offset: 0x0001A70B
	// (set) Token: 0x060029DD RID: 10717 RVA: 0x0001C513 File Offset: 0x0001A713
	public int Int32_53 { get; set; }

	// Token: 0x060029DE RID: 10718 RVA: 0x00128834 File Offset: 0x00126A34
	public Class530 method_3(int int_26)
	{
		Class530 @class;
		if (!this.dictionary_3.TryGetValue(int_26, out @class))
		{
			return null;
		}
		return @class;
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x00128854 File Offset: 0x00126A54
	public void method_4()
	{
		this.Boolean_39 = this.Class515_0.method_7(this.Class502_0.Int64_12) == 1;
		this.bool_1 = this.Boolean_44;
		this.Boolean_9 = this.Class515_0.method_7(this.Class502_0.Int64_47) == 1;
		this.Int64_3 = this.Class515_0.method_9(this.Class502_0.Int64_1);
		if (this.Class502_0.Int32_5 == 5)
		{
			this.Class502_0.Int32_22 = 10596;
		}
		else if (this.Class502_0.Int32_5 == 1)
		{
			this.Class502_0.Int32_22 = 30344;
		}
		else if (this.Class502_0.Int32_5 == 3)
		{
			this.Class502_0.Int32_22 = 9132;
		}
		else
		{
			this.Class502_0.Int32_22 = 1764;
		}
		int num = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_22 });
		if (num >= 0)
		{
			this.Int32_19 = num;
		}
		if (this.Class502_0.Int32_5 == 2 || this.Class502_0.Int32_5 == 3 || this.Class502_0.Int32_5 == 4)
		{
			this.Boolean_43 = this.Class515_0.method_7(this.Class502_0.Int64_58) == 1;
		}
		this.String_12 = this.Class515_0.method_2(this.Class502_0.Int64_8);
		this.Int32_53 = this.Class515_0.method_7(new long[] { this.Int64_3 + 31092L });
		if (string.IsNullOrEmpty(this.String_12))
		{
			this.String_12 = this.Class515_0.method_2(new long[]
			{
				(long)(this.Int32_52 + 364732),
				4048L,
				680L
			});
		}
		if (string.IsNullOrEmpty(this.String_12))
		{
			try
			{
				this.String_12 = Class501.Dictionary_8[this.Int32_35];
			}
			catch
			{
			}
		}
		this.Int32_50 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_10 });
		if (this.Class502_0.Int32_5 != 1)
		{
			if (this.Class502_0.Int32_5 != 3)
			{
				this.Boolean_42 = this.Class515_0.method_7(new long[] { 6553128L, 0L, 12L, 100L }) == 1 || this.Class515_0.method_7(new long[] { 6549744L, 0L, 12L, 100L }) == 1;
				goto IL_02DB;
			}
		}
		this.Boolean_42 = this.Class515_0.method_7(this.Class502_0.Int64_49) == 1 || this.Class515_0.method_7(this.Class502_0.Int64_48) == 1;
		IL_02DB:
		string text = ((this.Class502_0.Int32_5 == 5) ? this.Class515_0.method_16(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_8 }) : this.Class515_0.method_2(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_8 }));
		if (string.IsNullOrEmpty(text.Trim()))
		{
			text = "OFFLINE";
		}
		this.String_11 = text;
		this.String_10 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_6 + ((this.Class502_0.Int32_5 != 1) ? 0L : 4L) }).ToString("X8");
		this.Boolean_36 = this.Class515_0.method_7(this.Class502_0.Int64_53) == 1;
		this.Boolean_37 = this.Class515_0.method_7(this.Class502_0.Int64_55) == 1;
		this.Boolean_38 = this.Class515_0.method_7(this.Class502_0.Int64_56) == 1;
		this.Boolean_12 = this.Class515_0.method_7(this.Class502_0.Int64_50) == 1;
		this.Boolean_13 = this.Class515_0.method_7(this.Class502_0.Int64_54) == 1;
		if (this.Class106_0.Boolean_67)
		{
			Class515 @class = this.Class515_0;
			long[] array = new long[] { 0L, 8L, 4L, 324L };
			array[0] = this.Class106_0.Int64_0 + 12201280L;
			this.Boolean_35 = @class.method_7(array) == 1;
			Class515 class2 = this.Class515_0;
			long[] array2 = new long[] { 0L, 8L, 4L, 324L };
			array2[0] = this.Class106_0.Int64_0 + 12173440L;
			this.Boolean_29 = class2.method_7(array2) == 1;
			Class515 class3 = this.Class515_0;
			long[] array3 = new long[] { 0L, 8L, 4L, 324L };
			array3[0] = this.Class106_0.Int64_0 + 12201304L;
			this.Boolean_31 = class3.method_7(array3) == 1;
			Class515 class4 = this.Class515_0;
			long[] array4 = new long[] { 0L, 8L, 4L, 324L };
			array4[0] = this.Class106_0.Int64_0 + 12201304L;
			this.Boolean_33 = class4.method_7(array4) == 1;
			Class515 class5 = this.Class515_0;
			long[] array5 = new long[] { 0L, 8L, 4L, 324L };
			array5[0] = this.Class106_0.Int64_0 + 12169240L;
			this.Boolean_34 = class5.method_7(array5) == 1;
			Class515 class6 = this.Class515_0;
			long[] array6 = new long[] { 0L, 8L, 4L, 324L };
			array6[0] = this.Class106_0.Int64_0 + 12205768L;
			this.Boolean_28 = class6.method_7(array6) == 1;
			Class515 class7 = this.Class515_0;
			long[] array7 = new long[] { 0L, 8L, 4L, 324L };
			array7[0] = this.Class106_0.Int64_0 + 12197992L;
			this.Boolean_27 = class7.method_7(array7) == 1;
		}
		this.Boolean_41 = !string.IsNullOrEmpty(this.String_10) && !this.String_10.Contains("00000000") && !this.String_10.Contains("FFFFFFFF") && !(this.String_11 == "OFFLINE") && this.Int32_50 >= 1 && !string.IsNullOrEmpty(this.String_11);
		this.Int64_1 = this.Class515_0.method_9(this.Class502_0.Int64_1);
		this.Int32_35 = this.Class515_0.method_7(this.Class502_0.Int64_6);
		if (this.Class502_0.Int32_5 == 2 && this.Int32_35 <= 2)
		{
			foreach (KeyValuePair<int, string> keyValuePair in Class501.Dictionary_4)
			{
				if (this.String_12.smethod_36() == keyValuePair.Value.smethod_36())
				{
					this.Int32_35 = keyValuePair.Key;
					break;
				}
			}
		}
		if (this.Class106_0.Class0_0.Stopwatch_0.Elapsed.TotalSeconds > 10.0 && this.Class106_0.Class0_0.Stopwatch_0.Elapsed.TotalSeconds < 15.0)
		{
			int int32_ = this.Int32_41;
			if (!Class527.dictionary_0.ContainsKey(int32_))
			{
				Class527.dictionary_0.Add(int32_, this.Int32_35);
				Class106.Class210_0["Fake", int32_.ToString()] = this.Int32_35.ToString();
			}
		}
		if (this.String_12 == "Lạc Dương" || this.String_12 == "lacduong" || this.Int32_35 == 242 || (this.Int32_35 == 300 && this.Class106_0.String_21.Contains("14.225.209.112")) || (this.Int32_35 == 302 && !this.Class106_0.String_21.Contains("14.225.209.112")))
		{
			this.Int32_35 = 0;
		}
		if (this.String_12 == "Tô Châu" || this.String_12 == "tochau" || this.Int32_35 == 303 || (this.Int32_35 == 301 && this.Class106_0.String_21.Contains("14.225.209.112")))
		{
			this.Int32_35 = Class513.Int32_39;
		}
		if (this.String_12 == "Đại Lý" || this.String_12 == "daily" || this.Int32_35 == 304 || (this.Int32_35 == 302 && this.Class106_0.String_21.Contains("14.225.209.112")))
		{
			this.Int32_35 = Class513.Int32_40;
		}
		this.Int32_6 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_11 });
		this.Int32_7 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_15 });
		this.Int32_8 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_16 });
		this.Int32_12 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_19 });
		this.Int32_9 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_17 });
		this.Int32_10 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_18 });
		this.Int32_13 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_20 });
		this.Int32_18 = this.Class515_0.method_7(new long[] { this.Int64_1 + ((this.Class502_0.Int32_5 == 3) ? 9744L : 31064L) });
		this.String_8 = this.Class515_0.method_16(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_21 });
		this.Int32_38 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_13 });
		this.String_13 = "";
		if (this.Int32_7 != 0)
		{
			this.Int64_2 = this.Class515_0.method_9(this.Class502_0.Int64_2);
			for (int i = 0; i < 10; i++)
			{
				if (this.Class515_0.method_7(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_29 }) == this.Int32_7)
				{
					this.Int32_14 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_30 });
					this.Int32_15 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_31 });
					this.Int32_16 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_32 });
					this.Int32_17 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + (long)this.Class502_0.Int32_34 });
					if (this.Class502_0.Int32_5 != 5)
					{
						if (this.Class502_0.Int32_5 != 1)
						{
							this.String_13 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + 28L }).Trim();
							break;
						}
					}
					this.String_13 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)(this.Class502_0.Int32_28 * i) + 32L }).Trim();
					break;
				}
			}
		}
		else
		{
			this.Int32_16 = 0;
			this.Int32_15 = 0;
			this.Int32_14 = 0;
		}
		this.Boolean_1 = this.Class515_0.method_7(this.Class502_0.Int64_11) == 1;
		if (this.Class502_0.Int32_5 == 1)
		{
			this.String_5 = this.Class515_0.method_12(this.Class502_0.Int64_14).ToString("X8").Substring(0, 8);
		}
		else
		{
			this.String_5 = this.Class515_0.method_7(this.Class502_0.Int64_14).ToString("X8");
		}
		if (this.Class106_0.List_19.Contains(this.Class106_0) && this.Class106_0.List_19.Count > 0)
		{
			this.String_5 = this.Class106_0.List_19[0].Class527_0.String_10;
		}
		if (this.Class106_0.List_20.Contains(this.Class106_0) && this.Class106_0.List_20.Count > 0)
		{
			this.String_5 = this.Class106_0.List_20[0].Class527_0.String_10;
		}
		if (this.Class502_0.Int32_5 == 5)
		{
			this.Class502_0.Int64_3[1] = 144L;
			this.String_6 = this.Class515_0.method_2(new long[]
			{
				this.Class515_0.method_9(this.Class502_0.Int64_3),
				48L
			});
			this.String_7 = this.Class515_0.method_2(new long[]
			{
				this.Class515_0.method_9(this.Class502_0.Int64_3) + 8L,
				48L
			});
		}
		else
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Class502_0.Int64_3[1] = (long)Class527.Int32_51;
			}
			else if (this.Class502_0.Int32_5 == 3 || this.Class502_0.Int32_5 == 4)
			{
				this.Class502_0.Int64_3[1] = 84L;
			}
			long num2 = this.Class515_0.method_9(this.Class502_0.Int64_3);
			int num3 = ((this.Class502_0.Int32_5 == 2) ? 40 : 32);
			this.String_6 = this.Class515_0.method_2(new long[]
			{
				num2,
				(long)num3
			});
			this.String_7 = this.Class515_0.method_2(new long[]
			{
				num2 + 4L,
				(long)num3
			});
		}
		this.Int32_37 = this.Class515_0.method_7(this.Class502_0.Int64_44) / 1000;
		if (this.Int32_37 < 1)
		{
			this.Int32_37 = 100;
		}
		this.Int64_0 = this.Class515_0.method_9(this.Class502_0.Int64_20);
		this.Boolean_22 = false;
		if (this.Class106_0.Class506_0.Class504_1 != null && (this.Class106_0.Class506_0.Class504_1.List_0.Contains(1665) || this.Class106_0.Class506_0.Class504_1.List_0.Contains(2746) || this.Class106_0.Class506_0.Class504_1.List_0.Contains(2209)))
		{
			this.Boolean_22 = true;
		}
		if (!this.Boolean_22)
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.Boolean_22 = this.Class515_0.method_7(new long[] { this.Int64_1 + 164L }) != -1;
			}
			else
			{
				this.Boolean_22 = this.Class515_0.method_7(new long[]
				{
					(long)this.Class502_0.Int32_62,
					(long)this.Class502_0.Int32_63
				}) == 1;
			}
		}
		if (this.String_12 == "Thủy Lao")
		{
			this.Int32_35 = 66;
		}
		this.Boolean_20 = this.Class515_0.method_7(new long[] { this.Int64_1 + (long)this.Class502_0.Int32_49 }) != -1;
		if (this.String_12 == "Độc Chướng Trạch Địa")
		{
			this.Int32_35 = Class513.Int32_18;
		}
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x001299C4 File Offset: 0x00127BC4
	public void method_5()
	{
		this.Class106_0.ListViewItem_0.Text = this.Class106_0.Class527_0.String_11;
		this.Class106_0.ListViewItem_0.SubItems[2].Text = this.String_9;
		TimeSpan timeSpan = DateTime.Now - this.Class106_0.Process_0.StartTime;
		this.Class106_0.ListViewItem_0.SubItems[14].Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(timeSpan.TotalHours), timeSpan.Minutes, timeSpan.Seconds);
		this.Class106_0.ListViewItem_0.SubItems[7].Text = string.Format("{0:00}:{1:00}", Math.Floor(this.Class106_0.Class527_0.Int32_37 / 3600m), this.Class106_0.Class527_0.Int32_37 / 60 % 60);
		this.Class106_0.ListViewItem_0.SubItems[0].BackColor = (this.Boolean_1 ? Color.Red : Color.White);
		this.Class106_0.ListViewItem_0.SubItems[1].Text = this.Int32_50.ToString();
		this.Class106_0.ListViewItem_0.SubItems[5].Text = string.Format("{0}%", this.Int32_43);
		this.Class106_0.ListViewItem_0.SubItems[6].Text = string.Format("{0}%", this.Int32_44);
		this.Class106_0.ListViewItem_0.SubItems[8].Text = string.Format("{0:0.00}%", this.Class106_0.Class527_0.Single_2);
		this.Class106_0.ListViewItem_0.SubItems[9].Text = string.Format("{0:0.00}M", this.Class106_0.Double_0 / 1000000.0);
		this.Class106_0.ListViewItem_0.SubItems[9].BackColor = (this.Class106_0.Boolean_34 ? Color.LightBlue : Color.White);
		this.Class106_0.ListViewItem_0.SubItems[12].Text = this.Int32_18.ToString();
		this.Class106_0.ListViewItem_0.SubItems[13].Text = (this.Int32_19 / 10000).ToString();
		Class106 class106_ = this.Class106_0.Class106_3;
		string string_;
		if (class106_ != null)
		{
			if ((string_ = class106_.Class527_0.String_11) != null)
			{
				goto IL_030A;
			}
		}
		string_ = this.Class106_0.Class527_0.String_5;
		IL_030A:
		string text = string_;
		this.Class106_0.ListViewItem_0.SubItems[11].Text = text;
		this.Class106_0.ListViewItem_0.SubItems[0].ForeColor = (this.Boolean_21 ? Color.Blue : SystemColors.WindowText);
		Color color;
		if (!GUI.dictionary_0.TryGetValue(this.String_5, out color))
		{
			do
			{
				color = Color.FromArgb(this.random_0.Next(256), this.random_0.Next(256), this.random_0.Next(256));
			}
			while (color == Color.Black || color == Color.White || GUI.dictionary_0.ContainsValue(color));
			GUI.dictionary_0.Add(this.String_5, color);
		}
		this.Class106_0.ListViewItem_0.SubItems[11].BackColor = color;
		this.Class106_0.ListViewItem_0.SubItems[7].BackColor = ((this.Class106_0.Int32_54 > 1) ? Color.Orange : SystemColors.Window);
		this.Class106_0.ListViewItem_0.SubItems[10].Text = (this.Class106_0.Class527_0.bool_1 ? "TRANSING" : string.Format("{0} [{1} {2}]", this.Class106_0.Class527_0.String_12, this.Class106_0.Int32_16, this.Class106_0.Int32_17));
		this.Class106_0.ListViewItem_0.SubItems[4].BackColor = ((this.Int32_42 > 30) ? Color.White : Color.Red);
		this.Class106_0.ListViewItem_0.SubItems[4].Text = string.Format("{0}%", this.Int32_42);
		this.Class106_0.ListViewItem_0.SubItems[3].Text = this.Class106_0.String_16;
		this.Class106_0.ListViewItem_0.SubItems[3].ForeColor = ((this.Class106_0.Class0_0.Stopwatch_11.Elapsed.TotalSeconds <= 5.0) ? Color.Green : Color.Red);
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x00129F48 File Offset: 0x00128148
	public void method_6(string string_11)
	{
		if (string_11.Split(new char[] { ',' }).Length >= 2)
		{
			int num = Class531.smethod_19(string_11);
			int num2 = Class531.smethod_19(string_11.Replace(num.ToString() + ",", ""));
			this.method_7((float)num, (float)num2);
		}
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x00129FA0 File Offset: 0x001281A0
	public void method_7(float float_0, float float_1)
	{
		if (this.Boolean_20)
		{
			this.Class106_0.method_366();
		}
		foreach (Class525 @class in this.Class106_0.List_6)
		{
			if (!string.IsNullOrEmpty(@class.String_1) && @class.String_1.Contains("Shoes2"))
			{
				this.Class106_0.method_381((long)float_0.smethod_28(), 59L);
				this.Class106_0.method_381((long)float_1.smethod_28(), 60L);
				this.Class106_0.method_381((long)@class.Int32_1, 61L);
				this.Class106_0.method_381(0L, 126L);
				break;
			}
		}
	}

	// Token: 0x04001BC9 RID: 7113
	public static Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	// Token: 0x04001BCA RID: 7114
	private static readonly Dictionary<int, int> dictionary_1 = new Dictionary<int, int>
	{
		{
			Class537.int_0,
			Class513.Int32_109
		},
		{
			Class537.int_1,
			Class513.Int32_114
		},
		{
			Class537.int_2,
			Class513.Int32_118
		},
		{
			Class537.int_3,
			Class513.Int32_115
		},
		{
			Class537.int_4,
			Class513.Int32_110
		},
		{
			Class537.int_5,
			Class513.Int32_116
		},
		{
			Class537.int_6,
			Class513.Int32_119
		},
		{
			Class537.int_7,
			Class513.Int32_117
		},
		{
			Class537.int_8,
			Class513.Int32_111
		},
		{
			Class537.int_9,
			Class513.Int32_120
		},
		{
			Class537.int_10,
			Class513.Int32_112
		},
		{
			Class537.int_11,
			Class513.Int32_113
		},
		{
			Class537.int_12,
			Class513.Int32_60
		},
		{
			Class537.int_14,
			Class513.Int32_61
		}
	};

	// Token: 0x04001BCB RID: 7115
	private readonly Dictionary<int, Class530> dictionary_2 = new Dictionary<int, Class530>
	{
		{
			Class537.int_10,
			Class572.class530_41
		},
		{
			Class537.int_1,
			Class572.class530_42
		},
		{
			Class537.int_7,
			Class572.class530_43
		},
		{
			Class537.int_5,
			Class572.class530_44
		},
		{
			Class537.int_6,
			Class572.class530_45
		},
		{
			Class537.int_8,
			Class572.class530_46
		},
		{
			Class537.int_9,
			Class572.class530_48
		},
		{
			Class537.int_4,
			Class572.class530_49
		},
		{
			Class537.int_2,
			Class572.class530_50
		},
		{
			Class537.int_0,
			Class572.class530_51
		},
		{
			Class537.int_3,
			Class572.class530_53
		},
		{
			Class537.int_11,
			Class572.class530_52
		},
		{
			Class537.int_12,
			Class572.class530_47
		},
		{
			Class537.int_13,
			Class572.class530_9
		},
		{
			Class537.int_14,
			Class572.class530_54
		}
	};

	// Token: 0x04001BCC RID: 7116
	private readonly Dictionary<int, Class530> dictionary_3 = new Dictionary<int, Class530>
	{
		{
			Class537.int_0,
			Class556.class530_2
		},
		{
			Class537.int_1,
			Class544.class530_6
		},
		{
			Class537.int_2,
			Class538.class530_1
		},
		{
			Class537.int_3,
			Class562.class530_3
		},
		{
			Class537.int_4,
			Class548.class530_4
		},
		{
			Class537.int_5,
			Class560.class530_4
		},
		{
			Class537.int_6,
			Class552.class530_2
		},
		{
			Class537.int_7,
			Class554.class530_3
		},
		{
			Class537.int_8,
			Class558.class530_1
		},
		{
			Class537.int_9,
			Class546.class530_1
		},
		{
			Class537.int_10,
			Class542.class530_3
		},
		{
			Class537.int_11,
			Class550.class530_2
		},
		{
			Class537.int_12,
			Class540.class530_3
		},
		{
			Class537.int_13,
			Class279.class530_2
		},
		{
			Class537.int_14,
			Class208.class530_2
		}
	};

	// Token: 0x04001BCD RID: 7117
	private readonly Dictionary<int, Class530> dictionary_4 = new Dictionary<int, Class530>
	{
		{
			Class537.int_0,
			Class556.class530_6
		},
		{
			Class537.int_1,
			Class544.class530_10
		},
		{
			Class537.int_2,
			Class538.class530_6
		},
		{
			Class537.int_3,
			Class562.class530_7
		},
		{
			Class537.int_4,
			Class548.class530_2
		},
		{
			Class537.int_5,
			Class560.class530_9
		},
		{
			Class537.int_6,
			Class552.class530_6
		},
		{
			Class537.int_7,
			Class554.class530_8
		},
		{
			Class537.int_8,
			Class558.class530_5
		}
	};

	// Token: 0x04001BCE RID: 7118
	public static readonly Dictionary<int, int> dictionary_5 = new Dictionary<int, int>
	{
		{
			Class537.int_0,
			Class556.int_0
		},
		{
			Class537.int_1,
			Class544.int_0
		},
		{
			Class537.int_2,
			Class538.Int32_0
		},
		{
			Class537.int_3,
			Class562.int_0
		},
		{
			Class537.int_4,
			Class548.int_0
		},
		{
			Class537.int_5,
			Class560.int_0
		},
		{
			Class537.int_6,
			Class552.int_0
		},
		{
			Class537.int_7,
			Class554.int_0
		},
		{
			Class537.int_8,
			Class558.int_0
		},
		{
			Class537.int_9,
			Class546.int_0
		},
		{
			Class537.int_10,
			Class542.int_0
		},
		{
			Class537.int_11,
			Class550.int_0
		},
		{
			Class537.int_12,
			Class540.int_0
		},
		{
			Class537.int_13,
			Class279.Int32_0
		},
		{
			Class537.int_14,
			Class208.Int32_0
		}
	};

	// Token: 0x04001BCF RID: 7119
	private readonly Dictionary<int, Class530> dictionary_6 = new Dictionary<int, Class530>
	{
		{
			Class537.int_0,
			Class556.class530_4
		},
		{
			Class537.int_1,
			Class544.class530_8
		},
		{
			Class537.int_2,
			Class538.class530_3
		},
		{
			Class537.int_3,
			Class562.class530_5
		},
		{
			Class537.int_4,
			Class548.class530_6
		},
		{
			Class537.int_5,
			Class560.class530_6
		},
		{
			Class537.int_6,
			Class552.class530_4
		},
		{
			Class537.int_7,
			Class554.class530_5
		},
		{
			Class537.int_8,
			Class558.class530_3
		},
		{
			Class537.int_9,
			Class546.class530_3
		},
		{
			Class537.int_10,
			Class542.class530_5
		},
		{
			Class537.int_11,
			Class550.class530_3
		},
		{
			Class537.int_12,
			Class540.class530_5
		},
		{
			Class537.int_13,
			Class279.class530_4
		},
		{
			Class537.int_14,
			Class208.class530_0
		}
	};

	// Token: 0x04001BD0 RID: 7120
	private readonly Random random_0 = new Random();

	// Token: 0x04001BD1 RID: 7121
	[CompilerGenerated]
	private Class502 class502_0;

	// Token: 0x04001BD2 RID: 7122
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001BD3 RID: 7123
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001BD4 RID: 7124
	[CompilerGenerated]
	private Class515 class515_0;

	// Token: 0x04001BD5 RID: 7125
	public string string_0 = "";

	// Token: 0x04001BD6 RID: 7126
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001BD7 RID: 7127
	public bool bool_1;

	// Token: 0x04001BD8 RID: 7128
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x04001BD9 RID: 7129
	[CompilerGenerated]
	private long long_1;

	// Token: 0x04001BDA RID: 7130
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001BDB RID: 7131
	[CompilerGenerated]
	private int int_2;

	// Token: 0x04001BDC RID: 7132
	[CompilerGenerated]
	private int int_3;

	// Token: 0x04001BDD RID: 7133
	[CompilerGenerated]
	private int int_4;

	// Token: 0x04001BDE RID: 7134
	[CompilerGenerated]
	private int int_5;

	// Token: 0x04001BDF RID: 7135
	[CompilerGenerated]
	private int int_6;

	// Token: 0x04001BE0 RID: 7136
	[CompilerGenerated]
	private int int_7;

	// Token: 0x04001BE1 RID: 7137
	[CompilerGenerated]
	private long long_2;

	// Token: 0x04001BE2 RID: 7138
	[CompilerGenerated]
	private int int_8;

	// Token: 0x04001BE3 RID: 7139
	[CompilerGenerated]
	private int int_9;

	// Token: 0x04001BE4 RID: 7140
	[CompilerGenerated]
	private int int_10;

	// Token: 0x04001BE5 RID: 7141
	[CompilerGenerated]
	private int int_11;

	// Token: 0x04001BE6 RID: 7142
	[CompilerGenerated]
	private int int_12;

	// Token: 0x04001BE7 RID: 7143
	[CompilerGenerated]
	private int int_13;

	// Token: 0x04001BE8 RID: 7144
	private static Dictionary<int, Class530> dictionary_7 = new Dictionary<int, Class530>
	{
		{
			Class537.int_13,
			Class279.Class280.class530_1
		},
		{
			Class537.int_12,
			Class540.Class541.class530_1
		},
		{
			Class537.int_11,
			Class550.Class551.class530_1
		},
		{
			Class537.int_10,
			Class542.Class543.class530_1
		},
		{
			Class537.int_9,
			Class546.Class547.class530_1
		},
		{
			Class537.int_5,
			Class560.Class561.class530_1
		},
		{
			Class537.int_8,
			Class558.Class559.class530_1
		},
		{
			Class537.int_0,
			Class556.Class557.class530_1
		},
		{
			Class537.int_7,
			Class554.Class555.class530_1
		},
		{
			Class537.int_4,
			Class548.Class549.class530_1
		},
		{
			Class537.int_3,
			Class562.Class563.class530_1
		},
		{
			Class537.int_1,
			Class544.Class545.class530_1
		},
		{
			Class537.int_2,
			Class538.Class539.class530_1
		},
		{
			Class537.int_6,
			Class552.Class553.class530_1
		},
		{
			Class537.int_14,
			Class208.Class209.class530_1
		}
	};

	// Token: 0x04001BE9 RID: 7145
	private static Dictionary<int, Class530> dictionary_8 = new Dictionary<int, Class530>
	{
		{
			Class537.int_13,
			Class279.Class280.class530_0
		},
		{
			Class537.int_12,
			Class540.Class541.class530_0
		},
		{
			Class537.int_11,
			Class550.Class551.class530_0
		},
		{
			Class537.int_10,
			Class542.Class543.class530_0
		},
		{
			Class537.int_9,
			Class546.Class547.class530_0
		},
		{
			Class537.int_5,
			Class560.Class561.class530_0
		},
		{
			Class537.int_8,
			Class558.Class559.class530_0
		},
		{
			Class537.int_0,
			Class556.Class557.class530_0
		},
		{
			Class537.int_7,
			Class554.Class555.class530_0
		},
		{
			Class537.int_4,
			Class548.Class549.class530_0
		},
		{
			Class537.int_3,
			Class562.Class563.class530_0
		},
		{
			Class537.int_1,
			Class544.Class545.class530_0
		},
		{
			Class537.int_2,
			Class538.Class539.class530_0
		},
		{
			Class537.int_6,
			Class552.Class553.class530_0
		},
		{
			Class537.int_14,
			Class208.Class209.class530_2
		}
	};

	// Token: 0x04001BEA RID: 7146
	[CompilerGenerated]
	private int int_14;

	// Token: 0x04001BEB RID: 7147
	[CompilerGenerated]
	private int int_15;

	// Token: 0x04001BEC RID: 7148
	[CompilerGenerated]
	private int int_16;

	// Token: 0x04001BED RID: 7149
	[CompilerGenerated]
	private int int_17;

	// Token: 0x04001BEE RID: 7150
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001BEF RID: 7151
	[CompilerGenerated]
	private int int_18;

	// Token: 0x04001BF0 RID: 7152
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04001BF1 RID: 7153
	[CompilerGenerated]
	private int int_19;

	// Token: 0x04001BF2 RID: 7154
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04001BF3 RID: 7155
	[CompilerGenerated]
	private int int_20;

	// Token: 0x04001BF4 RID: 7156
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04001BF5 RID: 7157
	[CompilerGenerated]
	private string string_4;

	// Token: 0x04001BF6 RID: 7158
	[CompilerGenerated]
	private int int_21;

	// Token: 0x04001BF7 RID: 7159
	[CompilerGenerated]
	private string string_5;

	// Token: 0x04001BF8 RID: 7160
	[CompilerGenerated]
	private int int_22;

	// Token: 0x04001BF9 RID: 7161
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x04001BFA RID: 7162
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x04001BFB RID: 7163
	[CompilerGenerated]
	private bool bool_5;

	// Token: 0x04001BFC RID: 7164
	[CompilerGenerated]
	private bool bool_6;

	// Token: 0x04001BFD RID: 7165
	private readonly Dictionary<int, ValueTuple<int, int>[]> dictionary_9 = new Dictionary<int, ValueTuple<int, int>[]>
	{
		{
			Class537.int_0,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(149, 51),
				new ValueTuple<int, int>(36, 155),
				new ValueTuple<int, int>(47, 40)
			}
		},
		{
			Class537.int_1,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(38, 33),
				new ValueTuple<int, int>(32, 142),
				new ValueTuple<int, int>(27, 102)
			}
		},
		{
			Class537.int_2,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(156, 156),
				new ValueTuple<int, int>(34, 123),
				new ValueTuple<int, int>(157, 54)
			}
		},
		{
			Class537.int_3,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(112, 162),
				new ValueTuple<int, int>(114, 124),
				new ValueTuple<int, int>(42, 138)
			}
		},
		{
			Class537.int_4,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(149, 96),
				new ValueTuple<int, int>(48, 92),
				new ValueTuple<int, int>(155, 35)
			}
		},
		{
			Class537.int_5,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(82, 44),
				new ValueTuple<int, int>(153, 142),
				new ValueTuple<int, int>(49, 129)
			}
		},
		{
			Class537.int_6,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(163, 84),
				new ValueTuple<int, int>(32, 83),
				new ValueTuple<int, int>(49, 138)
			}
		},
		{
			Class537.int_7,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(157, 149),
				new ValueTuple<int, int>(31, 155),
				new ValueTuple<int, int>(78, 126)
			}
		},
		{
			Class537.int_8,
			new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(155, 63),
				new ValueTuple<int, int>(50, 150),
				new ValueTuple<int, int>(69, 141)
			}
		},
		{
			Class537.int_9,
			Array.Empty<ValueTuple<int, int>>()
		},
		{
			Class537.int_10,
			Array.Empty<ValueTuple<int, int>>()
		},
		{
			Class537.int_11,
			Array.Empty<ValueTuple<int, int>>()
		},
		{
			Class537.int_12,
			Array.Empty<ValueTuple<int, int>>()
		},
		{
			Class537.int_13,
			Array.Empty<ValueTuple<int, int>>()
		},
		{
			Class537.int_14,
			Array.Empty<ValueTuple<int, int>>()
		}
	};

	// Token: 0x04001BFE RID: 7166
	private readonly Dictionary<int, Class530> dictionary_10 = new Dictionary<int, Class530>
	{
		{
			Class537.int_0,
			Class556.class530_5
		},
		{
			Class537.int_1,
			Class544.class530_9
		},
		{
			Class537.int_2,
			Class538.class530_5
		},
		{
			Class537.int_3,
			Class562.class530_6
		},
		{
			Class537.int_4,
			Class548.class530_1
		},
		{
			Class537.int_5,
			Class560.class530_8
		},
		{
			Class537.int_6,
			Class552.class530_5
		},
		{
			Class537.int_7,
			Class554.class530_6
		},
		{
			Class537.int_8,
			Class558.class530_4
		}
	};

	// Token: 0x04001BFF RID: 7167
	public readonly Dictionary<string, ValueTuple<string, Class530, int, int, int>> dictionary_11 = new Dictionary<string, ValueTuple<string, Class530, int, int, int>>
	{
		{
			"GoThieuLam",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_76}", Class556.class530_0, 564, 16, 33)
		},
		{
			"GoMinhGiao",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_80}", Class544.class530_11, 566, 40, 36)
		},
		{
			"GoCaiBang",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_78}", Class538.class530_4, 565, 30, 36)
		},
		{
			"GoVoDang",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_82}", Class562.class530_1, 567, 30, 35)
		},
		{
			"GoNgaMy",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_88}", Class548.class530_7, 570, 45, 33)
		},
		{
			"GoTinhTuc",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_90}", Class560.class530_2, 571, 44, 33)
		},
		{
			"GoThienLong",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_84}", Class552.class530_0, 568, 15, 38)
		},
		{
			"GoThienSon",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_92}", Class554.class530_0, 572, 17, 35)
		},
		{
			"GoTieuDao",
			new ValueTuple<string, Class530, int, int, int>("#{XLRW_210725_86}", Class558.class530_6, 569, 44, 33)
		}
	};

	// Token: 0x04001C00 RID: 7168
	public static readonly Dictionary<string, ValueTuple<Class530, int, int, int, string, string, string>> dictionary_12 = new Dictionary<string, ValueTuple<Class530, int, int, int, string, string, string>>
	{
		{
			"#{XLRW_210725_267}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_4, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_268}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_41, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_269}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_29, 0, 0, 0, "1", "0", "0")
		},
		{
			"#{XLRW_210725_270}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_43, 0, 0, 0, "2", "1", "3")
		},
		{
			"#{XLRW_210725_271}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_3, 0, 0, 0, "3", "2", "1")
		},
		{
			"#{XLRW_210725_272}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class576.class530_42, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_273}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_31, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_274}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_4, 0, 0, 0, "2", "1", "3")
		},
		{
			"#{XLRW_210725_275}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_3, 0, 0, 0, "3", "2", "1")
		},
		{
			"#{XLRW_210725_276}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_55, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_277}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_2, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_278}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class572.class530_56, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_279}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_8, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_280}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_58, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_281}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_7, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_282}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_57, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_283}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_4, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_284}",
			new ValueTuple<Class530, int, int, int, string, string, string>(Class584.class530_32, 0, 0, 0, "1", "2", "3")
		},
		{
			"#{XLRW_210725_285}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 191, 119, "1", "2", "3")
		},
		{
			"#{XLRW_210725_286}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 117, 34, "2", "3", "1")
		},
		{
			"#{XLRW_210725_287}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 122, 56, "3", "2", "1")
		},
		{
			"#{XLRW_210725_288}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 27, 22, "3", "2", "1")
		},
		{
			"#{XLRW_210725_289}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 295, 68, "1", "2", "3")
		},
		{
			"#{XLRW_210725_290}",
			new ValueTuple<Class530, int, int, int, string, string, string>(null, 246, 261, 32, "1", "2", "3")
		}
	};

	// Token: 0x04001C01 RID: 7169
	public readonly Dictionary<string, ValueTuple<int, int, int>> dictionary_13 = new Dictionary<string, ValueTuple<int, int, int>>
	{
		{
			"#{XLRW_210725_347}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 128, 86)
		},
		{
			"#{XLRW_210725_348}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 38, 98)
		},
		{
			"#{XLRW_210725_349}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 89, 72)
		},
		{
			"#{XLRW_210725_350}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 91, 71)
		},
		{
			"#{XLRW_210725_352}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 57, 88)
		},
		{
			"#{XLRW_210725_353}",
			new ValueTuple<int, int, int>(Class513.Int32_49, 135, 90)
		},
		{
			"#{XLRW_210725_361}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 98, 108)
		},
		{
			"#{XLRW_210725_362}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 113, 117)
		},
		{
			"#{XLRW_210725_363}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 89, 56)
		},
		{
			"#{XLRW_210725_364}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 113, 118)
		},
		{
			"#{XLRW_210725_365}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 87, 58)
		},
		{
			"#{XLRW_210725_366}",
			new ValueTuple<int, int, int>(Class513.Int32_50, 66, 118)
		},
		{
			"#{XLRW_210725_354}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 94, 99)
		},
		{
			"#{XLRW_210725_355}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 114, 91)
		},
		{
			"#{XLRW_210725_356}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 131, 83)
		},
		{
			"#{XLRW_210725_358}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 95, 120)
		},
		{
			"#{XLRW_210725_359}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 92, 64)
		},
		{
			"#{XLRW_210725_360}",
			new ValueTuple<int, int, int>(Class513.Int32_51, 89, 99)
		},
		{
			"#{XLRW_210725_368}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 77, 85)
		},
		{
			"#{XLRW_210725_369}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 82, 85)
		},
		{
			"#{XLRW_210725_370}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 44, 56)
		},
		{
			"#{XLRW_210725_372}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 101, 136)
		},
		{
			"#{XLRW_210725_373}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 58, 73)
		},
		{
			"#{XLRW_210725_374}",
			new ValueTuple<int, int, int>(Class513.Int32_52, 78, 95)
		},
		{
			"#{XLRW_210725_389}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 98, 51)
		},
		{
			"#{XLRW_210725_390}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 86, 142)
		},
		{
			"#{XLRW_210725_392}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 96, 73)
		},
		{
			"#{XLRW_210725_393}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 95, 86)
		},
		{
			"#{XLRW_210725_394}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 105, 57)
		},
		{
			"#{XLRW_210725_395}",
			new ValueTuple<int, int, int>(Class513.Int32_55, 96, 51)
		},
		{
			"#{XLRW_210725_396}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 142, 55)
		},
		{
			"#{XLRW_210725_397}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 95, 75)
		},
		{
			"#{XLRW_210725_398}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 128, 77)
		},
		{
			"#{XLRW_210725_399}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 90, 87)
		},
		{
			"#{XLRW_210725_400}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 87, 70)
		},
		{
			"#{XLRW_210725_402}",
			new ValueTuple<int, int, int>(Class513.Int32_56, 96, 92)
		},
		{
			"#{XLRW_210725_375}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 96, 66)
		},
		{
			"#{XLRW_210725_376}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 97, 67)
		},
		{
			"#{XLRW_210725_377}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 35, 86)
		},
		{
			"#{XLRW_210725_378}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 95, 88)
		},
		{
			"#{XLRW_210725_380}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 99, 120)
		},
		{
			"#{XLRW_210725_381}",
			new ValueTuple<int, int, int>(Class513.Int32_53, 152, 118)
		},
		{
			"#{XLRW_210725_404}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 90, 120)
		},
		{
			"#{XLRW_210725_405}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 98, 44)
		},
		{
			"#{XLRW_210725_406}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 88, 44)
		},
		{
			"#{XLRW_210725_407}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 91, 44)
		},
		{
			"#{XLRW_210725_408}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 95, 60)
		},
		{
			"#{XLRW_210725_409}",
			new ValueTuple<int, int, int>(Class513.Int32_57, 101, 44)
		},
		{
			"#{XLRW_210725_382}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 125, 144)
		},
		{
			"#{XLRW_210725_383}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 125, 142)
		},
		{
			"#{XLRW_210725_384}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 69, 142)
		},
		{
			"#{XLRW_210725_385}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 119, 152)
		},
		{
			"#{XLRW_210725_386}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 54, 150)
		},
		{
			"#{XLRW_210725_387}",
			new ValueTuple<int, int, int>(Class513.Int32_54, 62, 68)
		}
	};

	// Token: 0x04001C02 RID: 7170
	public readonly Dictionary<int, ValueTuple<string, int, int>> dictionary_14 = new Dictionary<int, ValueTuple<string, int, int>>
	{
		{
			Class537.int_0,
			new ValueTuple<string, int, int>("#{XLRW_210725_540}", 98, 144)
		},
		{
			Class537.int_1,
			new ValueTuple<string, int, int>("#{XLRW_210725_542}", 95, 160)
		},
		{
			Class537.int_2,
			new ValueTuple<string, int, int>("#{XLRW_210725_541}", 93, 152)
		},
		{
			Class537.int_3,
			new ValueTuple<string, int, int>("#{XLRW_210725_543}", 100, 181)
		},
		{
			Class537.int_4,
			new ValueTuple<string, int, int>("#{XLRW_210725_546}", 94, 146)
		},
		{
			Class537.int_5,
			new ValueTuple<string, int, int>("#{XLRW_210725_547}", 98, 142)
		},
		{
			Class537.int_6,
			new ValueTuple<string, int, int>("#{XLRW_210725_544}", 98, 142)
		},
		{
			Class537.int_7,
			new ValueTuple<string, int, int>("#{XLRW_210725_548}", 96, 148)
		},
		{
			Class537.int_8,
			new ValueTuple<string, int, int>("#{XLRW_210725_545}", 44, 127)
		}
	};

	// Token: 0x04001C03 RID: 7171
	public readonly Dictionary<string, ValueTuple<int, int, int>> dictionary_15 = new Dictionary<string, ValueTuple<int, int, int>>
	{
		{
			"#{XLRW_210725_639}",
			new ValueTuple<int, int, int>(9, 41, 56)
		},
		{
			"#{XLRW_210725_640}",
			new ValueTuple<int, int, int>(9, 147, 114)
		},
		{
			"#{XLRW_210725_641}",
			new ValueTuple<int, int, int>(9, 57, 131)
		},
		{
			"#{XLRW_210725_645}",
			new ValueTuple<int, int, int>(11, 155, 35)
		},
		{
			"#{XLRW_210725_646}",
			new ValueTuple<int, int, int>(11, 161, 139)
		},
		{
			"#{XLRW_210725_647}",
			new ValueTuple<int, int, int>(11, 43, 157)
		},
		{
			"#{XLRW_210725_642}",
			new ValueTuple<int, int, int>(10, 144, 33)
		},
		{
			"#{XLRW_210725_643}",
			new ValueTuple<int, int, int>(10, 39, 139)
		},
		{
			"#{XLRW_210725_644}",
			new ValueTuple<int, int, int>(10, 150, 158)
		},
		{
			"#{XLRW_210725_648}",
			new ValueTuple<int, int, int>(12, 42, 94)
		},
		{
			"#{XLRW_210725_649}",
			new ValueTuple<int, int, int>(12, 100, 87)
		},
		{
			"#{XLRW_210725_650}",
			new ValueTuple<int, int, int>(12, 103, 154)
		},
		{
			"#{XLRW_210725_657}",
			new ValueTuple<int, int, int>(15, 45, 35)
		},
		{
			"#{XLRW_210725_658}",
			new ValueTuple<int, int, int>(15, 94, 118)
		},
		{
			"#{XLRW_210725_659}",
			new ValueTuple<int, int, int>(15, 71, 109)
		},
		{
			"#{XLRW_210725_660}",
			new ValueTuple<int, int, int>(16, 66, 38)
		},
		{
			"#{XLRW_210725_661}",
			new ValueTuple<int, int, int>(16, 111, 115)
		},
		{
			"#{XLRW_210725_662}",
			new ValueTuple<int, int, int>(16, 41, 150)
		},
		{
			"#{XLRW_210725_651}",
			new ValueTuple<int, int, int>(13, 64, 145)
		},
		{
			"#{XLRW_210725_652}",
			new ValueTuple<int, int, int>(13, 130, 136)
		},
		{
			"#{XLRW_210725_653}",
			new ValueTuple<int, int, int>(13, 154, 61)
		},
		{
			"#{XLRW_210725_663}",
			new ValueTuple<int, int, int>(17, 153, 38)
		},
		{
			"#{XLRW_210725_664}",
			new ValueTuple<int, int, int>(17, 72, 63)
		},
		{
			"#{XLRW_210725_665}",
			new ValueTuple<int, int, int>(17, 81, 117)
		},
		{
			"#{XLRW_210725_654}",
			new ValueTuple<int, int, int>(14, 88, 60)
		},
		{
			"#{XLRW_210725_655}",
			new ValueTuple<int, int, int>(14, 119, 88)
		},
		{
			"#{XLRW_210725_656}",
			new ValueTuple<int, int, int>(14, 130, 119)
		}
	};

	// Token: 0x04001C04 RID: 7172
	[CompilerGenerated]
	private bool bool_7;

	// Token: 0x04001C05 RID: 7173
	[CompilerGenerated]
	private bool bool_8;

	// Token: 0x04001C06 RID: 7174
	[CompilerGenerated]
	private bool bool_9;

	// Token: 0x04001C07 RID: 7175
	[CompilerGenerated]
	private bool bool_10;

	// Token: 0x04001C08 RID: 7176
	[CompilerGenerated]
	private bool bool_11;

	// Token: 0x04001C09 RID: 7177
	[CompilerGenerated]
	private bool bool_12;

	// Token: 0x04001C0A RID: 7178
	[CompilerGenerated]
	private bool bool_13;

	// Token: 0x04001C0B RID: 7179
	[CompilerGenerated]
	private bool bool_14;

	// Token: 0x04001C0C RID: 7180
	[CompilerGenerated]
	private bool bool_15;

	// Token: 0x04001C0D RID: 7181
	[CompilerGenerated]
	private bool bool_16;

	// Token: 0x04001C0E RID: 7182
	[CompilerGenerated]
	private bool bool_17;

	// Token: 0x04001C0F RID: 7183
	[CompilerGenerated]
	private bool bool_18;

	// Token: 0x04001C10 RID: 7184
	[CompilerGenerated]
	private bool bool_19;

	// Token: 0x04001C11 RID: 7185
	[CompilerGenerated]
	private bool bool_20;

	// Token: 0x04001C12 RID: 7186
	[CompilerGenerated]
	private bool bool_21;

	// Token: 0x04001C13 RID: 7187
	[CompilerGenerated]
	private int int_23;

	// Token: 0x04001C14 RID: 7188
	[CompilerGenerated]
	private long long_3;

	// Token: 0x04001C15 RID: 7189
	[CompilerGenerated]
	private string string_6;

	// Token: 0x04001C16 RID: 7190
	[CompilerGenerated]
	private string string_7;

	// Token: 0x04001C17 RID: 7191
	[CompilerGenerated]
	private string string_8;

	// Token: 0x04001C18 RID: 7192
	[CompilerGenerated]
	private bool bool_22;

	// Token: 0x04001C19 RID: 7193
	[CompilerGenerated]
	private bool bool_23;

	// Token: 0x04001C1A RID: 7194
	[CompilerGenerated]
	private static int int_24;

	// Token: 0x04001C1B RID: 7195
	[CompilerGenerated]
	private string string_9;

	// Token: 0x04001C1C RID: 7196
	[CompilerGenerated]
	private string[] string_10;

	// Token: 0x04001C1D RID: 7197
	[CompilerGenerated]
	private int int_25;

	// Token: 0x020002EE RID: 750
	[CompilerGenerated]
	[Serializable]
	private sealed class Class528
	{
		// Token: 0x060029E6 RID: 10726 RVA: 0x0000B514 File Offset: 0x00009714
		internal bool method_0(Class516 class516_0)
		{
			return Class501.Dictionary_9.ContainsKey(class516_0.String_4);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0001C528 File Offset: 0x0001A728
		internal char method_1(int int_0)
		{
			return Class500.Char_0[int_0];
		}

		// Token: 0x04001C1E RID: 7198
		public static readonly Class527.Class528 f_78D49EE1 = new Class527.Class528();

		// Token: 0x04001C1F RID: 7199
		public static Func<Class516, bool> f_A11D5BB6;

		// Token: 0x04001C20 RID: 7200
		public static Func<int, char> f_25A5F015;
	}
}
