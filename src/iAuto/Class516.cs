using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020002E0 RID: 736
internal class Class516
{
	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x060027BD RID: 10173 RVA: 0x0001ABB1 File Offset: 0x00018DB1
	// (set) Token: 0x060027BE RID: 10174 RVA: 0x0001ABB9 File Offset: 0x00018DB9
	private Class106 Class106_0 { get; set; }

	// Token: 0x170008A2 RID: 2210
	// (get) Token: 0x060027BF RID: 10175 RVA: 0x0001ABC2 File Offset: 0x00018DC2
	public bool Boolean_0
	{
		get
		{
			return Class501.hashSet_1.Contains(this.Int32_25);
		}
	}

	// Token: 0x170008A3 RID: 2211
	// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0001ABD4 File Offset: 0x00018DD4
	// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0001ABDC File Offset: 0x00018DDC
	public bool Boolean_1 { get; set; }

	// Token: 0x170008A4 RID: 2212
	// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0001ABE5 File Offset: 0x00018DE5
	// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0001ABED File Offset: 0x00018DED
	public long Int64_0 { get; set; }

	// Token: 0x170008A5 RID: 2213
	// (get) Token: 0x060027C4 RID: 10180 RVA: 0x0001ABF6 File Offset: 0x00018DF6
	// (set) Token: 0x060027C5 RID: 10181 RVA: 0x0001ABFE File Offset: 0x00018DFE
	public long Int64_1 { get; set; }

	// Token: 0x170008A6 RID: 2214
	// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0001AC07 File Offset: 0x00018E07
	// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0001AC0F File Offset: 0x00018E0F
	public int Int32_0 { get; set; }

	// Token: 0x170008A7 RID: 2215
	// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0011E644 File Offset: 0x0011C844
	public string String_0
	{
		get
		{
			return (this.Int64_3 - this.Class106_0.Int64_0).ToString("X8");
		}
	}

	// Token: 0x170008A8 RID: 2216
	// (get) Token: 0x060027C9 RID: 10185 RVA: 0x0001AC18 File Offset: 0x00018E18
	public int Int32_1
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 });
		}
	}

	// Token: 0x170008A9 RID: 2217
	// (get) Token: 0x060027CA RID: 10186 RVA: 0x0001AC39 File Offset: 0x00018E39
	public int Int32_2
	{
		get
		{
			return this.Class106_0.Class515_0.method_11(new long[] { this.Int64_0 + 4L });
		}
	}

	// Token: 0x170008AA RID: 2218
	// (get) Token: 0x060027CB RID: 10187 RVA: 0x0001AC64 File Offset: 0x00018E64
	// (set) Token: 0x060027CC RID: 10188 RVA: 0x0011E670 File Offset: 0x0011C870
	public int Int32_3
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[]
			{
				this.Class106_0.Class502_0.Int64_29[0],
				4733120L
			});
		}
		set
		{
			if (this.Class106_0.Class502_0.Int32_5 == 2)
			{
				this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
				{
					this.Class106_0.Class502_0.Int64_29[0],
					293964L
				}), 2);
				this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
				{
					this.Class106_0.Class502_0.Int64_29[0],
					293968L
				}), value);
				return;
			}
			if (this.Class106_0.Boolean_66)
			{
				this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
				{
					this.Class106_0.Class502_0.Int64_29[0],
					364304L
				}), 2);
				this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
				{
					this.Class106_0.Class502_0.Int64_29[0],
					364308L
				}), value);
				return;
			}
			this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
			{
				this.Class106_0.Class502_0.Int64_29[0],
				4733112L
			}), 2);
			this.Class106_0.Class515_0.method_21(this.Class106_0.Class515_0.method_14(new long[]
			{
				this.Class106_0.Class502_0.Int64_29[0],
				4733120L
			}), value);
		}
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x0011E858 File Offset: 0x0011CA58
	public Class516(Class106 class106_1, long long_4, bool bool_3 = false)
	{
		this.Class106_0 = class106_1;
		this.Boolean_1 = bool_3;
		this.Int64_2 = long_4;
		if (class106_1.Class502_0.Int32_5 == 5)
		{
			this.method_0();
		}
		else
		{
			this.method_1();
		}
		this.String_1 = this.String_1.Trim();
		this.String_2 = this.String_2.Trim();
		this.String_4 = this.String_4.Trim();
		if (this.String_2.StartsWith("Trân Thú "))
		{
			this.Int32_13 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + 78L });
		}
		if (this.String_4 == "Cloth2_9" || this.String_4.Contains("Charm") || this.String_4.Contains("CircularTaskTool64_5") || this.String_4 == "Merchandise4_16")
		{
			if (this.Class106_0.Boolean_66)
			{
				this.Int32_16 = class106_1.Class515_0.method_11(new long[] { class106_1.Class515_0.method_14(new long[]
				{
					this.Int64_2 + 20L,
					52L
				}) });
				this.Int32_17 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 54L });
				this.Int32_18 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 56L });
			}
			else if (this.Class106_0.Boolean_67)
			{
				if (this.String_4.Equals("Merchandise4_16"))
				{
					this.Int32_16 = class106_1.Class515_0.method_10(new long[] { class106_1.Class515_0.method_14(new long[]
					{
						this.Int64_2 + 20L,
						53L
					}) });
				}
				else
				{
					this.Int32_16 = class106_1.Class515_0.method_11(new long[] { class106_1.Class515_0.method_14(new long[]
					{
						this.Int64_2 + 20L,
						56L
					}) });
				}
				this.Int32_17 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 58L });
				this.Int32_18 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 60L });
			}
			else
			{
				this.Int32_16 = class106_1.Class515_0.method_11(new long[] { class106_1.Class515_0.method_14(new long[]
				{
					this.Int64_2 + 20L,
					80L
				}) });
				this.Int32_17 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 82L });
				this.Int32_18 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 84L });
			}
		}
		if (class106_1.Class502_0.Int32_5 == 5)
		{
			this.Int32_16 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 80L });
			this.Int32_18 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 82L });
			this.Int32_17 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 84L });
		}
		else if (this.Int32_25 == 30000000 && this.Class106_0.Boolean_67)
		{
			this.Int32_16 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 53L });
			this.Int32_18 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 55L });
			this.Int32_17 = class106_1.Class515_0.method_11(new long[] { this.Int64_1 + 57L });
		}
		if (this.String_4.Contains("Card_Icon"))
		{
			this.String_2 = "Điển Tịch";
		}
		if (class106_1.Class502_0.Int32_5 == 3)
		{
			this.Int32_20 = class106_1.Class515_0.method_7(new long[]
			{
				this.Int64_2 + 40L + 4L,
				44L
			});
		}
		else
		{
			this.Int32_20 = class106_1.Class515_0.method_7(new long[]
			{
				this.Int64_2 + 40L,
				44L
			});
		}
		this.Int32_0 = class106_1.Class515_0.method_10(new long[] { this.Int64_0 - 5L });
		if (class106_1.Boolean_66)
		{
			this.Int32_14 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + 94L });
			this.Int32_12 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + (long)this.Int32_19 + 40L });
			this.Int32_15 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + 91L });
		}
		else
		{
			this.Int32_14 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + (long)this.Int32_19 });
			this.Int32_12 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + (long)this.Int32_19 + 12L });
		}
		if (class106_1.List_5.Contains(Enum17.ChayThuongNhan))
		{
			this.Int32_5 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 76L });
			this.Int32_6 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 80L });
		}
		if (!Class226.Boolean_61)
		{
			if (!this.Boolean_5)
			{
				this.List_0.Add("Đồ Không Cố Định");
			}
			else
			{
				this.List_0.Add("Đồ Cố Định");
			}
		}
		if (this.String_4 == "CircularTaskTool33_6")
		{
			this.Int32_21 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + 19L });
		}
		if (this.String_2 == "Võ Hồn")
		{
			this.Int32_22 = class106_1.Class515_0.method_10(new long[] { this.Int64_1 + 40L });
		}
		this.List_0.Add(this.String_1);
		this.List_0.Add(this.String_2);
		this.List_0.Add(this.String_3);
		if (this.Boolean_3)
		{
			if (this.Int32_12 == 0 && this.Int32_14 == 1 && !Class501.List_14.Contains(this.String_1))
			{
				if (!Class226.Boolean_61)
				{
					this.List_0.Add("Trang Bị Chưa Giám Định");
				}
			}
			else if (Class226.Boolean_61)
			{
				this.List_0.Add(string.Format("Equipment {0} Star", this.Int32_12));
				this.List_0.Add(string.Format("Equipment {0} Line", this.Int32_14));
			}
			else
			{
				this.List_0.Add(string.Format("Trang Bị {0} Sao", this.Int32_12));
				this.List_0.Add(string.Format("Trang Bị {0} Dòng", this.Int32_14));
			}
		}
		if (this.String_2.smethod_36() == "dataodo")
		{
			this.List_0.Add("Đả Tạo Đồ " + this.String_1.smethod_26().ToString());
		}
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x0011F144 File Offset: 0x0011D344
	private void method_0()
	{
		this.Int32_9 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 8L });
		this.Int64_1 = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 + 24L });
		this.Int32_25 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 12L });
		this.Int32_11 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 20L });
		this.Int64_3 = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 });
		this.Boolean_5 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_1 + 13L }) == 1;
		this.Boolean_6 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_2 + 32L }) == 0;
		this.Int32_19 = 94;
		this.Int64_0 = this.Int64_1 + (long)this.Int32_19;
		long num = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 + 64L });
		if (this.Int64_3 == this.Class106_0.Class502_0.Int64_23)
		{
			this.method_4(1, num, 40, 112, 104, -1);
			return;
		}
		if (this.Int64_3 == this.Class106_0.Class502_0.Int64_24)
		{
			this.method_4(2, num, 32, 96, 24, -1);
			return;
		}
		if (this.Int64_3 == this.Class106_0.Class502_0.Int64_25)
		{
			this.method_4(3, num, 40, 328, 24, -1);
		}
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x0011F358 File Offset: 0x0011D558
	private void method_1()
	{
		this.Int32_9 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 4L });
		this.Int64_1 = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 + 20L });
		this.Int32_25 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 8L });
		this.Int32_11 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + 16L });
		this.Int64_3 = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 });
		this.Boolean_5 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_1 + 13L }) == 1;
		if (this.Class106_0.Boolean_67)
		{
			this.Boolean_6 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_1 + 12L }) != 0;
			this.Int32_19 = 70;
		}
		else if (this.Class106_0.Boolean_66)
		{
			this.Boolean_6 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_2 + 24L }) == 0;
			this.Int32_19 = 66;
		}
		else
		{
			this.Boolean_6 = this.Class106_0.Class515_0.method_10(new long[] { this.Int64_2 + 24L }) == 0;
			this.Int32_19 = 94;
		}
		this.Int64_0 = this.Int64_1 + (long)this.Int32_19;
		long num = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_2 + ((this.Class106_0.Class502_0.Int32_5 == 3 || this.Class106_0.Class502_0.Int32_5 == 4) ? 44L : 40L) });
		if (this.Class106_0.Class502_0.Int32_5 == 3)
		{
			if (this.method_2(this.Class106_0.Class502_0.Int64_23))
			{
				this.method_4(1, num, 40, 88, 84, -1);
				return;
			}
			if (this.method_2(this.Class106_0.Class502_0.Int64_24))
			{
				this.method_4(2, num, 24, 80, 20, 88);
				return;
			}
			if (this.method_2(this.Class106_0.Class502_0.Int64_25))
			{
				this.method_4(3, num, 28, 304, 20, 136);
				return;
			}
			this.method_3(num);
			return;
		}
		else if (this.Class106_0.Boolean_67)
		{
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_23)
			{
				this.method_4(1, num, 40, 76, 72, -1);
				return;
			}
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_24)
			{
				this.method_4(2, num, 24, 76, 20, 64);
				return;
			}
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_25)
			{
				this.method_4(4, num, 28, 304, 20, 124);
				return;
			}
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_26)
			{
				this.method_4(4, num, 32, -1, 92, -1);
				this.String_2 = "Chân Nguyên";
				return;
			}
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_27)
			{
				this.method_4(5, num, 44, -1, 40, -1);
				return;
			}
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_28)
			{
				this.method_4(6, num, 40, 64, 60, -1);
			}
			return;
		}
		else if (this.Class106_0.Boolean_68)
		{
			if (this.Int64_3 == this.Class106_0.Class502_0.Int64_23)
			{
				this.method_4(1, num, 40, 88, 84, -1);
				return;
			}
			if (this.Int64_3 != this.Class106_0.Class502_0.Int64_24)
			{
				if (this.Int64_3 != this.Class106_0.Class502_0.Int64_27)
				{
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_25)
					{
						this.method_4(3, num, 28, 304, 20, -1);
						return;
					}
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_26)
					{
						this.method_4(4, num, 40, 76, 72, -1);
					}
					return;
				}
			}
			this.method_4((this.Int64_3 == this.Class106_0.Class502_0.Int64_27) ? 5 : 2, num, 24, 80, 20, 88);
			return;
		}
		else
		{
			if (this.Int64_3 == this.Class106_0.Int64_0 + 7836764L)
			{
				this.method_4(4, num, 32, -1, 92, -1);
				this.String_2 = "Chân Nguyên";
				return;
			}
			if (this.Int64_3 != this.Class106_0.Class502_0.Int64_23)
			{
				if (this.Int64_3 != this.Class106_0.Class502_0.Int64_27)
				{
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_24)
					{
						this.method_4(2, num, 24, 80, 20, (this.Class106_0.Class502_0.Int32_5 == 4) ? 64 : 88);
						return;
					}
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_25)
					{
						this.method_4(3, num, 28, 304, 20, 60);
						return;
					}
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_26)
					{
						this.method_4(4, num, 40, 76, 72, -1);
						return;
					}
					if (this.Int64_3 == this.Class106_0.Class502_0.Int64_28)
					{
						this.method_4(6, num, 44, 104, 40, -1);
						return;
					}
					this.method_4(0, num, 88, 80, 20, -1);
					return;
				}
			}
			this.method_4(1, num, 40, 88, 84, -1);
			return;
		}
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x0001AC9D File Offset: 0x00018E9D
	private bool method_2(long long_4)
	{
		return this.Int64_3 == this.Class106_0.Int64_0 + long_4;
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x0011F988 File Offset: 0x0011DB88
	private void method_3(long long_4)
	{
		this.method_4(1, long_4, 40, 88, 84, -1);
		if (!string.IsNullOrEmpty(this.String_1))
		{
			this.Class106_0.Class502_0.Int64_23 = this.Int64_3 - this.Class106_0.Int64_0;
			return;
		}
		this.method_4(2, long_4, 24, 80, 20, 88);
		if (!string.IsNullOrEmpty(this.String_1))
		{
			this.Class106_0.Class502_0.Int64_24 = this.Int64_3 - this.Class106_0.Int64_0;
			return;
		}
		this.method_4(3, long_4, 28, 304, 20, 88);
		if (!string.IsNullOrEmpty(this.String_1))
		{
			this.Class106_0.Class502_0.Int64_25 = this.Int64_3 - this.Class106_0.Int64_0;
		}
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x0011FA58 File Offset: 0x0011DC58
	private void method_4(int int_20, long long_4, int int_21, int int_22, int int_23, int int_24 = -1)
	{
		this.Int32_8 = int_20;
		this.String_1 = this.method_5(long_4 + (long)int_21);
		this.String_2 = ((int_22 < 0) ? string.Empty : this.method_5(long_4 + (long)int_22));
		this.String_4 = this.method_5(long_4 + (long)int_23);
		if (int_24 >= 0)
		{
			this.Int32_10 = this.Class106_0.Class515_0.method_10(new long[]
			{
				this.Int64_2 + 20L,
				(long)int_24
			});
		}
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x0011FAE4 File Offset: 0x0011DCE4
	private string method_5(long long_4)
	{
		long num = this.Class106_0.Class515_0.method_9(new long[] { long_4 });
		if (num != 0L)
		{
			return this.Class106_0.Class515_0.method_16(new long[] { num });
		}
		return string.Empty;
	}

	// Token: 0x170008AB RID: 2219
	// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0001ACB4 File Offset: 0x00018EB4
	public int Int32_4
	{
		get
		{
			if (this.Int32_12 != 0 && this.Int32_14 != 0)
			{
				return this.Int32_20 + (this.Int32_12 + this.Int32_14) * 10;
			}
			return 0;
		}
	}

	// Token: 0x170008AC RID: 2220
	// (get) Token: 0x060027D5 RID: 10197 RVA: 0x0001ACDF File Offset: 0x00018EDF
	// (set) Token: 0x060027D6 RID: 10198 RVA: 0x0001ACE7 File Offset: 0x00018EE7
	public int Int32_5 { get; set; }

	// Token: 0x170008AD RID: 2221
	// (get) Token: 0x060027D7 RID: 10199 RVA: 0x0001ACF0 File Offset: 0x00018EF0
	// (set) Token: 0x060027D8 RID: 10200 RVA: 0x0001ACF8 File Offset: 0x00018EF8
	public int Int32_6 { get; set; }

	// Token: 0x170008AE RID: 2222
	// (get) Token: 0x060027D9 RID: 10201 RVA: 0x0001AD01 File Offset: 0x00018F01
	public bool Boolean_2
	{
		get
		{
			return Class501.HashSet_2.Contains(this.String_2.smethod_1());
		}
	}

	// Token: 0x170008AF RID: 2223
	// (get) Token: 0x060027DA RID: 10202 RVA: 0x0001AD18 File Offset: 0x00018F18
	public bool Boolean_3
	{
		get
		{
			return Class501.HashSet_1.Contains(this.String_2.smethod_1());
		}
	}

	// Token: 0x170008B0 RID: 2224
	// (get) Token: 0x060027DB RID: 10203 RVA: 0x0001AD2F File Offset: 0x00018F2F
	public bool Boolean_4
	{
		get
		{
			return this.Boolean_3 && this.Int32_12 == 0 && this.Int32_14 == 1;
		}
	}

	// Token: 0x170008B1 RID: 2225
	// (get) Token: 0x060027DC RID: 10204 RVA: 0x0001AD4C File Offset: 0x00018F4C
	public int Int32_7
	{
		get
		{
			return this.Class106_0.Class515_0.method_10(new long[] { this.Int64_0 + 2L });
		}
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x0001AD77 File Offset: 0x00018F77
	public void method_6()
	{
		if (this.Int32_8 == 1)
		{
			this.method_8();
			return;
		}
		this.method_9();
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x0001AD8F File Offset: 0x00018F8F
	public void method_7()
	{
		this.Class106_0.method_400(this.String_4, this.Int32_9);
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x0001ADA9 File Offset: 0x00018FA9
	public void method_8()
	{
		this.Class106_0.method_399(this.String_4, this.Int32_9);
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x0011FB30 File Offset: 0x0011DD30
	public void method_9()
	{
		this.Class106_0.method_375("PlayerPackage:UseItem(" + this.Int32_11.ToString() + ");", false);
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x0001ADC3 File Offset: 0x00018FC3
	public void method_10()
	{
		this.Class106_0.method_381(this.Int64_2, 107L);
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x0001ADDF File Offset: 0x00018FDF
	public void method_11()
	{
		this.Class106_0.method_381(this.Int64_2, 117L);
	}

	// Token: 0x170008B2 RID: 2226
	// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0001ADFB File Offset: 0x00018FFB
	// (set) Token: 0x060027E4 RID: 10212 RVA: 0x0001AE03 File Offset: 0x00019003
	public long Int64_2 { get; set; }

	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x060027E5 RID: 10213 RVA: 0x0001AE0C File Offset: 0x0001900C
	// (set) Token: 0x060027E6 RID: 10214 RVA: 0x0001AE14 File Offset: 0x00019014
	public long Int64_3 { get; set; }

	// Token: 0x170008B4 RID: 2228
	// (get) Token: 0x060027E7 RID: 10215 RVA: 0x0001AE1D File Offset: 0x0001901D
	// (set) Token: 0x060027E8 RID: 10216 RVA: 0x0001AE25 File Offset: 0x00019025
	public int Int32_8 { get; set; }

	// Token: 0x170008B5 RID: 2229
	// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0001AE2E File Offset: 0x0001902E
	// (set) Token: 0x060027EA RID: 10218 RVA: 0x0001AE36 File Offset: 0x00019036
	public int Int32_9 { get; set; }

	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x060027EB RID: 10219 RVA: 0x0001AE3F File Offset: 0x0001903F
	// (set) Token: 0x060027EC RID: 10220 RVA: 0x0001AE47 File Offset: 0x00019047
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x060027ED RID: 10221 RVA: 0x0001AE50 File Offset: 0x00019050
	// (set) Token: 0x060027EE RID: 10222 RVA: 0x0001AE58 File Offset: 0x00019058
	public int Int32_10 { get; set; } = 1;

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x060027EF RID: 10223 RVA: 0x0001AE61 File Offset: 0x00019061
	// (set) Token: 0x060027F0 RID: 10224 RVA: 0x0001AE69 File Offset: 0x00019069
	public int Int32_11 { get; set; }

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x060027F1 RID: 10225 RVA: 0x0001AE72 File Offset: 0x00019072
	// (set) Token: 0x060027F2 RID: 10226 RVA: 0x0001AE7A File Offset: 0x0001907A
	public string String_2 { get; set; } = string.Empty;

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x060027F3 RID: 10227 RVA: 0x0001AE83 File Offset: 0x00019083
	// (set) Token: 0x060027F4 RID: 10228 RVA: 0x0001AE8B File Offset: 0x0001908B
	public List<string> List_0 { get; set; } = new List<string>();

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0011FB68 File Offset: 0x0011DD68
	public string String_3
	{
		get
		{
			if (this.String_4 == "Charm11_4" || this.String_4 == "Charm11_3")
			{
				return "Rương Phụ Bản";
			}
			if (this.String_4 == "Scroll_1")
			{
				return "Vũ Khí Đả Tạo Đồ";
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "Linh Thú Đan", "Linh Thú Đan" },
				{ "Nhuận Hồn Thạch", "Nhuận Hồn Thạch" },
				{ "Xuyết Long Thạch", "Xuyết Long Thạch" },
				{ "Ngũ Độc Châu", "Ngũ Độc Châu" },
				{ "Miên Bố", "Miên Bố" },
				{ "Bí Ngân", "Bí Ngân" },
				{ "Hồn Băng Châu", "Hồn Băng Châu" },
				{ "Câu Thiên Thái", "Câu Thiên Thái" }
			};
			foreach (string text in dictionary.Keys)
			{
				if (this.String_1.StartsWith(text))
				{
					return dictionary[text];
				}
			}
			if (this.String_1.EndsWith("Câu Thiên Thái"))
			{
				return "Câu Thiên Thái";
			}
			if (this.String_1.ToLower().StartsWith("vạn linh thạch"))
			{
				return "Vạn Linh Thạch";
			}
			if (this.String_1.Contains("Chân Nguyên-Tử") || this.String_1.Contains("Chân Nguyên Tử"))
			{
				return "Chân Nguyên-Tử Phù";
			}
			if (this.String_2.Contains("Thạch"))
			{
				return "Bảo Thạch";
			}
			if (this.String_2.Contains("Đục Lỗ"))
			{
				return "Đục Lỗ";
			}
			return this.String_2;
		}
	}

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0001AE94 File Offset: 0x00019094
	// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0001AE9C File Offset: 0x0001909C
	public int Int32_12 { get; set; }

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0001AEA5 File Offset: 0x000190A5
	// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0001AEAD File Offset: 0x000190AD
	public int Int32_13 { get; set; }

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x060027FA RID: 10234 RVA: 0x0001AEB6 File Offset: 0x000190B6
	// (set) Token: 0x060027FB RID: 10235 RVA: 0x0001AEBE File Offset: 0x000190BE
	public int Int32_14 { get; set; }

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x060027FC RID: 10236 RVA: 0x0001AEC7 File Offset: 0x000190C7
	// (set) Token: 0x060027FD RID: 10237 RVA: 0x0001AECF File Offset: 0x000190CF
	public int Int32_15 { get; set; }

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x060027FE RID: 10238 RVA: 0x0001AED8 File Offset: 0x000190D8
	public long Int64_4
	{
		get
		{
			return this.Int64_1 + (long)this.Int32_19;
		}
	}

	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x060027FF RID: 10239 RVA: 0x0001AEE8 File Offset: 0x000190E8
	// (set) Token: 0x06002800 RID: 10240 RVA: 0x0001AEF0 File Offset: 0x000190F0
	public string String_4 { get; set; } = string.Empty;

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06002801 RID: 10241 RVA: 0x0001AEF9 File Offset: 0x000190F9
	// (set) Token: 0x06002802 RID: 10242 RVA: 0x0001AF01 File Offset: 0x00019101
	public int Int32_16 { get; set; } = -1;

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x06002803 RID: 10243 RVA: 0x0001AF0A File Offset: 0x0001910A
	// (set) Token: 0x06002804 RID: 10244 RVA: 0x0001AF12 File Offset: 0x00019112
	public int Int32_17 { get; set; }

	// Token: 0x170008C4 RID: 2244
	// (get) Token: 0x06002805 RID: 10245 RVA: 0x0001AF1B File Offset: 0x0001911B
	// (set) Token: 0x06002806 RID: 10246 RVA: 0x0001AF23 File Offset: 0x00019123
	public int Int32_18 { get; set; }

	// Token: 0x170008C5 RID: 2245
	// (get) Token: 0x06002807 RID: 10247 RVA: 0x0001AF2C File Offset: 0x0001912C
	// (set) Token: 0x06002808 RID: 10248 RVA: 0x0001AF34 File Offset: 0x00019134
	public int Int32_19 { get; set; }

	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x06002809 RID: 10249 RVA: 0x0001AF3D File Offset: 0x0001913D
	public string String_5
	{
		get
		{
			return this.String_1.smethod_36();
		}
	}

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x0600280A RID: 10250 RVA: 0x0001AF4A File Offset: 0x0001914A
	// (set) Token: 0x0600280B RID: 10251 RVA: 0x0001AF52 File Offset: 0x00019152
	public int Int32_20 { get; set; }

	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x0600280C RID: 10252 RVA: 0x0001AF5B File Offset: 0x0001915B
	// (set) Token: 0x0600280D RID: 10253 RVA: 0x0001AF63 File Offset: 0x00019163
	public int Int32_21 { get; set; }

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x0600280E RID: 10254 RVA: 0x0001AF6C File Offset: 0x0001916C
	// (set) Token: 0x0600280F RID: 10255 RVA: 0x0001AF74 File Offset: 0x00019174
	public int Int32_22 { get; set; }

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06002810 RID: 10256 RVA: 0x0001AF7D File Offset: 0x0001917D
	// (set) Token: 0x06002811 RID: 10257 RVA: 0x0001AF85 File Offset: 0x00019185
	public bool Boolean_5 { get; set; }

	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x06002812 RID: 10258 RVA: 0x0011FD38 File Offset: 0x0011DF38
	public int Int32_23
	{
		get
		{
			if (this.Class106_0.Class502_0.Int32_5 != 1)
			{
				return (int)Math.Floor(this.Int32_11 / 5m) + 1;
			}
			return (int)Math.Floor(this.Int32_11 / 10m) + 1;
		}
	}

	// Token: 0x170008CC RID: 2252
	// (get) Token: 0x06002813 RID: 10259 RVA: 0x0001AF8E File Offset: 0x0001918E
	public int Int32_24
	{
		get
		{
			if (this.Class106_0.Class502_0.Int32_5 != 1)
			{
				return this.Int32_11 % 5 + 1;
			}
			return this.Int32_11 % 10 + 1;
		}
	}

	// Token: 0x170008CD RID: 2253
	// (get) Token: 0x06002814 RID: 10260 RVA: 0x0001AFB9 File Offset: 0x000191B9
	// (set) Token: 0x06002815 RID: 10261 RVA: 0x0001AFC1 File Offset: 0x000191C1
	public bool Boolean_6 { get; set; }

	// Token: 0x170008CE RID: 2254
	// (get) Token: 0x06002816 RID: 10262 RVA: 0x0001AFCA File Offset: 0x000191CA
	// (set) Token: 0x06002817 RID: 10263 RVA: 0x0001AFD2 File Offset: 0x000191D2
	public int Int32_25 { get; set; }

	// Token: 0x170008CF RID: 2255
	// (get) Token: 0x06002818 RID: 10264 RVA: 0x0011FDA0 File Offset: 0x0011DFA0
	public int Int32_26
	{
		get
		{
			if (this.String_4.Contains("Card_Icon_Jinzhuang1"))
			{
				if (this.String_4.EndsWith("_4") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_7") || this.String_4.EndsWith("_9"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_2") || this.String_4.EndsWith("_3") || this.String_4.EndsWith("_8") || this.String_4.EndsWith("_13"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_14") || this.String_4.EndsWith("_15") || this.String_4.EndsWith("_16"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_5") || this.String_4.EndsWith("_10") || this.String_4.EndsWith("_11") || this.String_4.EndsWith("_12"))
				{
					return 4;
				}
			}
			if (this.String_4.Contains("Card_Icon_Mingju1"))
			{
				if (this.String_4.EndsWith("_8") || this.String_4.EndsWith("_9") || this.String_4.EndsWith("_11") || this.String_4.EndsWith("_16"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_3") || this.String_4.EndsWith("_4") || this.String_4.EndsWith("_10") || this.String_4.EndsWith("_13"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_2") || this.String_4.EndsWith("_5") || this.String_4.EndsWith("_7") || this.String_4.EndsWith("_14"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_12") || this.String_4.EndsWith("_15"))
				{
					return 4;
				}
			}
			if (this.String_4.Contains("Card_Icon_Mingshi1"))
			{
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_2") || this.String_4.EndsWith("_4") || this.String_4.EndsWith("_9"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_5") || this.String_4.EndsWith("_7") || this.String_4.EndsWith("_8") || this.String_4.EndsWith("_13"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_10") || this.String_4.EndsWith("_14") || this.String_4.EndsWith("_15") || this.String_4.EndsWith("_16"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_3") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_11") || this.String_4.EndsWith("_12"))
				{
					return 4;
				}
			}
			if (this.String_4.Contains("Card_Icon_Qinggong1"))
			{
				if (this.String_4.EndsWith("_3") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_10") || this.String_4.EndsWith("_16"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_5") || this.String_4.EndsWith("_12") || this.String_4.EndsWith("_15"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_2") || this.String_4.EndsWith("_4") || this.String_4.EndsWith("_8") || this.String_4.EndsWith("_11"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_7") || this.String_4.EndsWith("_9") || this.String_4.EndsWith("_13") || this.String_4.EndsWith("_14"))
				{
					return 4;
				}
			}
			if (this.String_4.Contains("Card_Icon_Shenbing1"))
			{
				if (this.String_4.EndsWith("_2") || this.String_4.EndsWith("_4") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_11"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_3") || this.String_4.EndsWith("_5") || this.String_4.EndsWith("_10") || this.String_4.EndsWith("_16"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_8") || this.String_4.EndsWith("_9") || this.String_4.EndsWith("_13") || this.String_4.EndsWith("_14"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_7") || this.String_4.EndsWith("_12") || this.String_4.EndsWith("_15"))
				{
					return 4;
				}
			}
			if (this.String_4.Contains("Card_Icon_Wujue1"))
			{
				if (this.String_4.EndsWith("_3") || this.String_4.EndsWith("_10") || this.String_4.EndsWith("_12") || this.String_4.EndsWith("_14"))
				{
					return 1;
				}
				if (this.String_4.EndsWith("_4") || this.String_4.EndsWith("_8") || this.String_4.EndsWith("_9") || this.String_4.EndsWith("_13"))
				{
					return 2;
				}
				if (this.String_4.EndsWith("_2") || this.String_4.EndsWith("_11") || this.String_4.EndsWith("_15") || this.String_4.EndsWith("_16"))
				{
					return 3;
				}
				if (this.String_4.EndsWith("_1") || this.String_4.EndsWith("_5") || this.String_4.EndsWith("_6") || this.String_4.EndsWith("_7"))
				{
					return 4;
				}
			}
			return -1;
		}
	}

	// Token: 0x170008D0 RID: 2256
	// (get) Token: 0x06002819 RID: 10265 RVA: 0x0001AFDB File Offset: 0x000191DB
	public bool Boolean_7
	{
		get
		{
			if (this.Class106_0.Class502_0.Int32_5 == 1)
			{
				return this.String_6[50] == '1';
			}
			return this.String_6[51] == '1';
		}
	}

	// Token: 0x170008D1 RID: 2257
	// (get) Token: 0x0600281A RID: 10266 RVA: 0x001205C0 File Offset: 0x0011E7C0
	public string String_6
	{
		get
		{
			string text = "";
			for (int i = 0; i < 2; i++)
			{
				int num;
				if (this.Class106_0.Class502_0.Int32_5 == 1)
				{
					num = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 84L + (long)(i * 4) });
				}
				else
				{
					num = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 112L + (long)(i * 4) });
				}
				string text2 = Convert.ToString(num, 2);
				while (text2.Length < 32)
				{
					text2 = "0" + text2;
				}
				text += text2;
			}
			return text;
		}
	}

	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x0600281B RID: 10267 RVA: 0x00120684 File Offset: 0x0011E884
	public int Int32_27
	{
		get
		{
			if (!this.Boolean_7)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < 32; i++)
			{
				if (this.String_6[i] == '1')
				{
					num++;
				}
			}
			for (int j = 52; j < 64; j++)
			{
				if (this.String_6[j] == '1')
				{
					num++;
				}
			}
			if (this.Class106_0.Class502_0.Int32_5 == 1)
			{
				return this.Class106_0.Class515_0.method_11(new long[] { this.Int64_1 + 110L + (long)(num * 2) });
			}
			return this.Class106_0.Class515_0.method_11(new long[] { this.Int64_1 + 138L + (long)(num * 2) });
		}
	}

	// Token: 0x170008D3 RID: 2259
	// (get) Token: 0x0600281C RID: 10268 RVA: 0x0001B013 File Offset: 0x00019213
	// (set) Token: 0x0600281D RID: 10269 RVA: 0x00120750 File Offset: 0x0011E950
	public int Int32_28
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L });
		}
		set
		{
			this.int_19 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L });
			this.Class106_0.Class515_0.method_21(this.Int64_1 + 13L, value);
		}
	}

	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x0600281E RID: 10270 RVA: 0x0001B03E File Offset: 0x0001923E
	public long Int64_5
	{
		get
		{
			return this.Int64_1 + 13L;
		}
	}

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x0600281F RID: 10271 RVA: 0x0001B050 File Offset: 0x00019250
	// (set) Token: 0x06002820 RID: 10272 RVA: 0x001207B0 File Offset: 0x0011E9B0
	public int Int32_29
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 109L });
		}
		set
		{
			this.int_19 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 96L });
			this.Class106_0.Class515_0.method_21(this.Int64_1 + 96L, value);
		}
	}

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06002821 RID: 10273 RVA: 0x00120810 File Offset: 0x0011EA10
	public string String_7
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L }).ToString("X8");
		}
	}

	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06002822 RID: 10274 RVA: 0x0001B07B File Offset: 0x0001927B
	public bool Boolean_8
	{
		get
		{
			return this.Class106_0.Class515_0.method_7(new long[] { this.Int64_5 }) != 50;
		}
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x00120854 File Offset: 0x0011EA54
	public void method_12()
	{
		string text = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_1 + 13L }).ToString("X8");
		if (text.EndsWith("000010") || text.EndsWith("000011"))
		{
			this.Class106_0.Class515_0.method_21(this.Int64_1 + 13L, 50);
		}
	}

	// Token: 0x04001B13 RID: 6931
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x04001B14 RID: 6932
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001B15 RID: 6933
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001B16 RID: 6934
	[CompilerGenerated]
	private long long_1;

	// Token: 0x04001B17 RID: 6935
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001B18 RID: 6936
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001B19 RID: 6937
	[CompilerGenerated]
	private int int_2;

	// Token: 0x04001B1A RID: 6938
	[CompilerGenerated]
	private long long_2;

	// Token: 0x04001B1B RID: 6939
	[CompilerGenerated]
	private long long_3;

	// Token: 0x04001B1C RID: 6940
	[CompilerGenerated]
	private int int_3;

	// Token: 0x04001B1D RID: 6941
	[CompilerGenerated]
	private int int_4;

	// Token: 0x04001B1E RID: 6942
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001B1F RID: 6943
	[CompilerGenerated]
	private int int_5;

	// Token: 0x04001B20 RID: 6944
	[CompilerGenerated]
	private int int_6;

	// Token: 0x04001B21 RID: 6945
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001B22 RID: 6946
	[CompilerGenerated]
	private List<string> list_0;

	// Token: 0x04001B23 RID: 6947
	[CompilerGenerated]
	private int int_7;

	// Token: 0x04001B24 RID: 6948
	[CompilerGenerated]
	private int int_8;

	// Token: 0x04001B25 RID: 6949
	[CompilerGenerated]
	private int int_9;

	// Token: 0x04001B26 RID: 6950
	[CompilerGenerated]
	private int int_10;

	// Token: 0x04001B27 RID: 6951
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04001B28 RID: 6952
	[CompilerGenerated]
	private int int_11;

	// Token: 0x04001B29 RID: 6953
	[CompilerGenerated]
	private int int_12;

	// Token: 0x04001B2A RID: 6954
	[CompilerGenerated]
	private int int_13;

	// Token: 0x04001B2B RID: 6955
	[CompilerGenerated]
	private int int_14;

	// Token: 0x04001B2C RID: 6956
	[CompilerGenerated]
	private int int_15;

	// Token: 0x04001B2D RID: 6957
	[CompilerGenerated]
	private int int_16;

	// Token: 0x04001B2E RID: 6958
	[CompilerGenerated]
	private int int_17;

	// Token: 0x04001B2F RID: 6959
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04001B30 RID: 6960
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04001B31 RID: 6961
	[CompilerGenerated]
	private int int_18;

	// Token: 0x04001B32 RID: 6962
	private int int_19 = -1;
}
