using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000266 RID: 614
internal class Class400
{
	// Token: 0x06002063 RID: 8291 RVA: 0x000EC5F4 File Offset: 0x000EA7F4
	public Class400(ListViewItem listViewItem_1 = null)
	{
		if (listViewItem_1 != null)
		{
			this.ListViewItem_0 = listViewItem_1;
			return;
		}
		this.ListViewItem_0 = new ListViewItem(new string[22]);
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x06002064 RID: 8292 RVA: 0x00015A8B File Offset: 0x00013C8B
	// (set) Token: 0x06002065 RID: 8293 RVA: 0x00015A93 File Offset: 0x00013C93
	public Stopwatch Stopwatch_0 { get; set; } = Stopwatch.StartNew();

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x06002066 RID: 8294 RVA: 0x00015A9C File Offset: 0x00013C9C
	// (set) Token: 0x06002067 RID: 8295 RVA: 0x00015AA4 File Offset: 0x00013CA4
	public Stopwatch Stopwatch_1 { get; set; } = Stopwatch.StartNew();

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x06002068 RID: 8296 RVA: 0x00015AAD File Offset: 0x00013CAD
	// (set) Token: 0x06002069 RID: 8297 RVA: 0x00015AB5 File Offset: 0x00013CB5
	public DateTime DateTime_0 { get; set; } = DateTime.Now.AddSeconds(-55.0);

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x0600206A RID: 8298 RVA: 0x00015ABE File Offset: 0x00013CBE
	// (set) Token: 0x0600206B RID: 8299 RVA: 0x00015AC6 File Offset: 0x00013CC6
	public bool Boolean_0 { get; set; }

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x0600206C RID: 8300 RVA: 0x00015ACF File Offset: 0x00013CCF
	// (set) Token: 0x0600206D RID: 8301 RVA: 0x00015AD7 File Offset: 0x00013CD7
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x0600206E RID: 8302 RVA: 0x00015AE0 File Offset: 0x00013CE0
	// (set) Token: 0x0600206F RID: 8303 RVA: 0x00015AE8 File Offset: 0x00013CE8
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06002070 RID: 8304 RVA: 0x00015AF1 File Offset: 0x00013CF1
	// (set) Token: 0x06002071 RID: 8305 RVA: 0x00015AF9 File Offset: 0x00013CF9
	public string String_2 { get; set; } = string.Empty;

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06002072 RID: 8306 RVA: 0x00015B02 File Offset: 0x00013D02
	// (set) Token: 0x06002073 RID: 8307 RVA: 0x00015B1B File Offset: 0x00013D1B
	public string String_3
	{
		get
		{
			return this.ListViewItem_0.SubItems[10].Text;
		}
		set
		{
			this.method_2(10, value);
		}
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x06002074 RID: 8308 RVA: 0x00015B26 File Offset: 0x00013D26
	// (set) Token: 0x06002075 RID: 8309 RVA: 0x00015B2E File Offset: 0x00013D2E
	public string String_4 { get; set; } = string.Empty;

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06002076 RID: 8310 RVA: 0x00015B37 File Offset: 0x00013D37
	// (set) Token: 0x06002077 RID: 8311 RVA: 0x00015B3F File Offset: 0x00013D3F
	public HashSet<Enum17> HashSet_0 { get; set; } = new HashSet<Enum17>();

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x06002078 RID: 8312 RVA: 0x00015B48 File Offset: 0x00013D48
	// (set) Token: 0x06002079 RID: 8313 RVA: 0x00015B50 File Offset: 0x00013D50
	public Class106 Class106_0 { get; set; }

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x0600207A RID: 8314 RVA: 0x000EC6D0 File Offset: 0x000EA8D0
	public string String_5
	{
		get
		{
			return string.Concat(new string[] { this.String_6, this.String_17, this.String_19, this.String_21, this.String_11, this.String_18, this.String_23 }).smethod_36();
		}
	}

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x0600207B RID: 8315 RVA: 0x00015B59 File Offset: 0x00013D59
	// (set) Token: 0x0600207C RID: 8316 RVA: 0x00015B71 File Offset: 0x00013D71
	public string String_6
	{
		get
		{
			return this.ListViewItem_0.SubItems[1].Text;
		}
		set
		{
			this.method_2(1, value);
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x0600207D RID: 8317 RVA: 0x00015B7B File Offset: 0x00013D7B
	// (set) Token: 0x0600207E RID: 8318 RVA: 0x00015B83 File Offset: 0x00013D83
	public string String_7 { get; set; } = string.Empty;

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x0600207F RID: 8319 RVA: 0x00015B8C File Offset: 0x00013D8C
	// (set) Token: 0x06002080 RID: 8320 RVA: 0x00015B94 File Offset: 0x00013D94
	public string String_8 { get; set; } = string.Empty;

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x06002081 RID: 8321 RVA: 0x00015B9D File Offset: 0x00013D9D
	// (set) Token: 0x06002082 RID: 8322 RVA: 0x00015BA5 File Offset: 0x00013DA5
	public string String_9 { get; set; } = string.Empty;

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x06002083 RID: 8323 RVA: 0x00015BAE File Offset: 0x00013DAE
	// (set) Token: 0x06002084 RID: 8324 RVA: 0x00015BB6 File Offset: 0x00013DB6
	public string String_10 { get; set; } = string.Empty;

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x06002085 RID: 8325 RVA: 0x00015BBF File Offset: 0x00013DBF
	// (set) Token: 0x06002086 RID: 8326 RVA: 0x00015BD7 File Offset: 0x00013DD7
	public string String_11
	{
		get
		{
			return this.ListViewItem_0.SubItems[6].Text;
		}
		set
		{
			this.method_2(6, value);
		}
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x06002087 RID: 8327 RVA: 0x00015BE1 File Offset: 0x00013DE1
	// (set) Token: 0x06002088 RID: 8328 RVA: 0x00015BFA File Offset: 0x00013DFA
	public string String_12
	{
		get
		{
			return this.ListViewItem_0.SubItems[9].Text;
		}
		set
		{
			this.method_2(9, value);
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x06002089 RID: 8329 RVA: 0x00015C05 File Offset: 0x00013E05
	// (set) Token: 0x0600208A RID: 8330 RVA: 0x00015C1E File Offset: 0x00013E1E
	public string String_13
	{
		get
		{
			return this.ListViewItem_0.SubItems[12].Text;
		}
		set
		{
			this.method_2(12, value);
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x0600208B RID: 8331 RVA: 0x00015C29 File Offset: 0x00013E29
	// (set) Token: 0x0600208C RID: 8332 RVA: 0x00015C42 File Offset: 0x00013E42
	public string String_14
	{
		get
		{
			return this.ListViewItem_0.SubItems[13].Text;
		}
		set
		{
			this.method_2(13, value);
		}
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x0600208D RID: 8333 RVA: 0x00015C4D File Offset: 0x00013E4D
	// (set) Token: 0x0600208E RID: 8334 RVA: 0x00015C66 File Offset: 0x00013E66
	public string String_15
	{
		get
		{
			return this.ListViewItem_0.SubItems[15].Text;
		}
		set
		{
			this.method_2(15, value);
		}
	}

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x0600208F RID: 8335 RVA: 0x00015C71 File Offset: 0x00013E71
	// (set) Token: 0x06002090 RID: 8336 RVA: 0x00015C8A File Offset: 0x00013E8A
	public string String_16
	{
		get
		{
			return this.ListViewItem_0.SubItems[11].Text;
		}
		set
		{
			this.method_2(11, value);
		}
	}

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x06002091 RID: 8337 RVA: 0x00015C95 File Offset: 0x00013E95
	// (set) Token: 0x06002092 RID: 8338 RVA: 0x00015C9D File Offset: 0x00013E9D
	public bool Boolean_1 { get; set; }

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x06002093 RID: 8339 RVA: 0x000EC72C File Offset: 0x000EA92C
	public int Int32_0
	{
		get
		{
			if (!this.String_11.Contains("Server") && !this.String_11.Contains("Private"))
			{
				int num = GUI.Class210_0["SERVER", this.String_11].smethod_26() - 1;
				if (num <= 0)
				{
					num = 0;
				}
				return num;
			}
			return this.String_11.smethod_26() - 1;
		}
	}

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x06002094 RID: 8340 RVA: 0x00015CA6 File Offset: 0x00013EA6
	// (set) Token: 0x06002095 RID: 8341 RVA: 0x00015CBE File Offset: 0x00013EBE
	public string String_17
	{
		get
		{
			return this.ListViewItem_0.SubItems[2].Text;
		}
		set
		{
			this.method_2(2, value);
		}
	}

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x06002096 RID: 8342 RVA: 0x00015CC8 File Offset: 0x00013EC8
	// (set) Token: 0x06002097 RID: 8343 RVA: 0x00015CE0 File Offset: 0x00013EE0
	public string String_18
	{
		get
		{
			return this.ListViewItem_0.SubItems[5].Text;
		}
		set
		{
			this.method_2(5, value);
		}
	}

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x06002098 RID: 8344 RVA: 0x00015CEA File Offset: 0x00013EEA
	// (set) Token: 0x06002099 RID: 8345 RVA: 0x00015D02 File Offset: 0x00013F02
	public string String_19
	{
		get
		{
			return this.ListViewItem_0.SubItems[3].Text;
		}
		set
		{
			this.method_2(3, value);
		}
	}

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x0600209A RID: 8346 RVA: 0x00015D0C File Offset: 0x00013F0C
	// (set) Token: 0x0600209B RID: 8347 RVA: 0x00015D14 File Offset: 0x00013F14
	public string String_20 { get; set; } = string.Empty;

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x0600209C RID: 8348 RVA: 0x00015D1D File Offset: 0x00013F1D
	// (set) Token: 0x0600209D RID: 8349 RVA: 0x00015D25 File Offset: 0x00013F25
	public string String_21
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
			this.method_2(4, value);
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x0600209E RID: 8350 RVA: 0x00015D36 File Offset: 0x00013F36
	// (set) Token: 0x0600209F RID: 8351 RVA: 0x00015D4E File Offset: 0x00013F4E
	public string String_22
	{
		get
		{
			return this.ListViewItem_0.SubItems[7].Text;
		}
		set
		{
			this.method_2(7, value);
		}
	}

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00015D58 File Offset: 0x00013F58
	// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00015D70 File Offset: 0x00013F70
	public string String_23
	{
		get
		{
			return this.ListViewItem_0.SubItems[8].Text;
		}
		set
		{
			this.method_2(8, value);
		}
	}

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00015D7A File Offset: 0x00013F7A
	// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00015D82 File Offset: 0x00013F82
	public string String_24 { get; set; }

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00015D8B File Offset: 0x00013F8B
	// (set) Token: 0x060020A5 RID: 8357 RVA: 0x00015D93 File Offset: 0x00013F93
	public ListViewItem ListViewItem_0 { get; set; }

	// Token: 0x060020A6 RID: 8358 RVA: 0x000EC790 File Offset: 0x000EA990
	public void method_0()
	{
		this.HashSet_0.Clear();
		this.String_0 = (this.String_3 = string.Empty);
		this.String_1 = (this.String_2 = string.Empty);
	}

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00015D9C File Offset: 0x00013F9C
	// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00015DA4 File Offset: 0x00013FA4
	public bool Boolean_2 { get; set; }

	// Token: 0x060020A9 RID: 8361 RVA: 0x00015DAD File Offset: 0x00013FAD
	public void method_1(Enum17 enum17_0, bool bool_3 = true)
	{
		if (bool_3)
		{
			if (!this.HashSet_0.Contains(enum17_0))
			{
				this.HashSet_0.Add(enum17_0);
			}
		}
		else
		{
			this.HashSet_0.Remove(enum17_0);
		}
		this.Boolean_2 = false;
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x000EC7D0 File Offset: 0x000EA9D0
	private void method_2(int int_0, string string_11)
	{
		Class400.Class401 @class = new Class400.Class401();
		@class.class400_0 = this;
		@class.int_0 = int_0;
		@class.string_0 = string_11;
		GUI.GUI_0.Invoke(new Func<string>(@class.method_0));
	}

	// Token: 0x04001474 RID: 5236
	[CompilerGenerated]
	private Stopwatch stopwatch_0;

	// Token: 0x04001475 RID: 5237
	[CompilerGenerated]
	private Stopwatch stopwatch_1;

	// Token: 0x04001476 RID: 5238
	[CompilerGenerated]
	private DateTime dateTime_0;

	// Token: 0x04001477 RID: 5239
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001478 RID: 5240
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001479 RID: 5241
	[CompilerGenerated]
	private string string_1;

	// Token: 0x0400147A RID: 5242
	[CompilerGenerated]
	private string string_2;

	// Token: 0x0400147B RID: 5243
	[CompilerGenerated]
	private string string_3;

	// Token: 0x0400147C RID: 5244
	[CompilerGenerated]
	private HashSet<Enum17> hashSet_0;

	// Token: 0x0400147D RID: 5245
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x0400147E RID: 5246
	[CompilerGenerated]
	private string string_4;

	// Token: 0x0400147F RID: 5247
	[CompilerGenerated]
	private string string_5;

	// Token: 0x04001480 RID: 5248
	[CompilerGenerated]
	private string string_6;

	// Token: 0x04001481 RID: 5249
	[CompilerGenerated]
	private string string_7;

	// Token: 0x04001482 RID: 5250
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04001483 RID: 5251
	[CompilerGenerated]
	private string string_8;

	// Token: 0x04001484 RID: 5252
	private string string_9 = string.Empty;

	// Token: 0x04001485 RID: 5253
	[CompilerGenerated]
	private string string_10;

	// Token: 0x04001486 RID: 5254
	[CompilerGenerated]
	private ListViewItem listViewItem_0;

	// Token: 0x04001487 RID: 5255
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x02000267 RID: 615
	[CompilerGenerated]
	private sealed class Class401
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x000EC810 File Offset: 0x000EAA10
		internal string method_0()
		{
			return this.class400_0.ListViewItem_0.SubItems[this.int_0].Text = this.string_0;
		}

		// Token: 0x04001488 RID: 5256
		public Class400 class400_0;

		// Token: 0x04001489 RID: 5257
		public int int_0;

		// Token: 0x0400148A RID: 5258
		public string string_0;
	}
}
