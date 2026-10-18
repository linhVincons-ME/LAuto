using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _i;

// Token: 0x02000223 RID: 547
internal class Class357 : IEnumerable, IEnumerable<GStruct19>
{
	// Token: 0x06001DBE RID: 7614 RVA: 0x000142D3 File Offset: 0x000124D3
	public Class357(Control3 control3_1)
	{
		this.control3_0 = control3_1;
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x000142F0 File Offset: 0x000124F0
	public Class357(Control3 control3_1, int int_3, int int_4, int int_5, int int_6)
		: this(control3_1)
	{
		this.gstruct19_1 = new GStruct19(int_3, int_4);
		this.gstruct19_0 = new GStruct19(int_5, int_6);
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00014315 File Offset: 0x00012515
	public Class357(Control3 control3_1, GStruct19 gstruct19_2, GStruct19 gstruct19_3)
		: this(control3_1)
	{
		this.gstruct19_1 = gstruct19_2;
		this.gstruct19_0 = gstruct19_3;
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0001432C File Offset: 0x0001252C
	public Class357(Control3 control3_1, int int_3)
		: this(control3_1)
	{
		this.gstruct19_1 = new GStruct19(0, int_3);
		this.gstruct19_0 = new GStruct19(control3_1[int_3].Count, int_3);
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0001435A File Offset: 0x0001255A
	public virtual bool Boolean_2
	{
		get
		{
			if (this.Boolean_0)
			{
				return this.GStruct19_0.int_0 == this.GStruct19_1.int_0;
			}
			return GStruct19.smethod_1(this.GStruct19_0, this.GStruct19_1);
		}
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0001438E File Offset: 0x0001258E
	// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00014396 File Offset: 0x00012596
	public bool Boolean_0 { get; set; }

	// Token: 0x170005ED RID: 1517
	// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0001439F File Offset: 0x0001259F
	// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x000E08A4 File Offset: 0x000DEAA4
	public GStruct19 GStruct19_0
	{
		get
		{
			return this.gstruct19_1;
		}
		set
		{
			this.gstruct19_1 = value;
			this.gstruct19_0 = value;
			this.int_1 = -1;
			this.method_37();
		}
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000143A7 File Offset: 0x000125A7
	// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x000143AF File Offset: 0x000125AF
	public GStruct19 GStruct19_1
	{
		get
		{
			return this.gstruct19_0;
		}
		set
		{
			this.gstruct19_0 = value;
			this.method_37();
		}
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000E08D0 File Offset: 0x000DEAD0
	public virtual string String_1
	{
		get
		{
			if (this.Boolean_0)
			{
				return this.String_0;
			}
			int num = Math.Min(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
			int num2 = Math.Max(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
			int int32_ = this.Int32_2;
			int int32_2 = this.Int32_3;
			if (num < 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = num; i <= num2; i++)
			{
				int num3 = ((i == num) ? int32_ : 0);
				int num4 = ((i == num2) ? Math.Min(this.control3_0[i].Count - 1, int32_2 - 1) : (this.control3_0[i].Count - 1));
				for (int j = num3; j <= num4; j++)
				{
					stringBuilder.Append(this.control3_0[i][j].char_0);
				}
				if (i != num2 && num != num2)
				{
					stringBuilder.AppendLine();
				}
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000E09E0 File Offset: 0x000DEBE0
	public int Int32_0
	{
		get
		{
			if (this.Boolean_0)
			{
				return this.method_59(false);
			}
			int num = Math.Min(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
			int num2 = Math.Max(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
			int num3 = 0;
			if (num < 0)
			{
				return 0;
			}
			for (int i = num; i <= num2; i++)
			{
				int num4 = ((i == num) ? this.Int32_2 : 0);
				int num5 = ((i == num2) ? Math.Min(this.control3_0[i].Count - 1, this.Int32_3 - 1) : (this.control3_0[i].Count - 1));
				num3 += num5 - num4 + 1;
				if (i != num2 && num != num2)
				{
					num3 += Environment.NewLine.Length;
				}
			}
			return num3;
		}
	}

	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000143BE File Offset: 0x000125BE
	public int Int32_1
	{
		get
		{
			if (this.Boolean_0)
			{
				return this.method_59(true);
			}
			return this.Int32_0;
		}
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000E0AB4 File Offset: 0x000DECB4
	public char Char_0
	{
		get
		{
			if (this.GStruct19_0.int_0 >= this.control3_0[this.GStruct19_0.int_1].Count)
			{
				return '\n';
			}
			return this.control3_0[this.GStruct19_0.int_1][this.GStruct19_0.int_0].char_0;
		}
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x06001DCD RID: 7629 RVA: 0x000E0B18 File Offset: 0x000DED18
	public char Char_1
	{
		get
		{
			if (this.GStruct19_0.int_0 > this.control3_0[this.GStruct19_0.int_1].Count)
			{
				return '\n';
			}
			if (this.GStruct19_0.int_0 <= 0)
			{
				return '\n';
			}
			return this.control3_0[this.GStruct19_0.int_1][this.GStruct19_0.int_0 - 1].char_0;
		}
	}

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000E0B90 File Offset: 0x000DED90
	internal int Int32_2
	{
		get
		{
			if (this.gstruct19_0.int_1 < this.gstruct19_1.int_1)
			{
				return this.gstruct19_0.int_0;
			}
			if (this.gstruct19_0.int_1 > this.gstruct19_1.int_1)
			{
				return this.gstruct19_1.int_0;
			}
			return Math.Min(this.gstruct19_0.int_0, this.gstruct19_1.int_0);
		}
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000E0C00 File Offset: 0x000DEE00
	internal int Int32_3
	{
		get
		{
			if (this.gstruct19_0.int_1 < this.gstruct19_1.int_1)
			{
				return this.gstruct19_1.int_0;
			}
			if (this.gstruct19_0.int_1 > this.gstruct19_1.int_1)
			{
				return this.gstruct19_0.int_0;
			}
			return Math.Max(this.gstruct19_0.int_0, this.gstruct19_1.int_0);
		}
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000143D6 File Offset: 0x000125D6
	public int Int32_4
	{
		get
		{
			return Math.Min(this.GStruct19_0.int_1, this.GStruct19_1.int_1);
		}
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000143F3 File Offset: 0x000125F3
	public int Int32_5
	{
		get
		{
			return Math.Max(this.GStruct19_0.int_1, this.GStruct19_1.int_1);
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00014410 File Offset: 0x00012610
	public IEnumerable<GStruct17> IEnumerable_0
	{
		get
		{
			Class357.Class367 @class = new Class357.Class367(-2);
			@class.class357_0 = this;
			return @class;
		}
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000E0C70 File Offset: 0x000DEE70
	public GStruct20 GStruct20_0
	{
		get
		{
			int num = Math.Min(this.GStruct19_0.int_0, this.GStruct19_1.int_0);
			int num2 = Math.Min(this.GStruct19_0.int_1, this.GStruct19_1.int_1);
			int num3 = Math.Max(this.GStruct19_0.int_0, this.GStruct19_1.int_0);
			int num4 = Math.Max(this.GStruct19_0.int_1, this.GStruct19_1.int_1);
			return new GStruct20(num2, num, num4, num3);
		}
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x000E0CF4 File Offset: 0x000DEEF4
	// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x000E0F0C File Offset: 0x000DF10C
	public bool Boolean_1
	{
		get
		{
			if (this.control3_0.Boolean_9)
			{
				return true;
			}
			Class375 @class = null;
			foreach (Class368 class2 in this.control3_0.Class368_0)
			{
				if (class2 is Class375)
				{
					@class = (Class375)class2;
					IL_0040:
					if (@class != null)
					{
						StyleIndex styleIndex = Class357.smethod_0(this.control3_0.method_32(@class));
						if (this.Boolean_2)
						{
							Class351 class3 = this.control3_0[this.gstruct19_1.int_1];
							if (this.Boolean_0)
							{
								using (IEnumerator<Class357> enumerator = this.method_52(false).GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										Class357 class4 = enumerator.Current;
										class3 = this.control3_0[class4.gstruct19_1.int_1];
										if (class4.gstruct19_1.int_0 < class3.Count && class4.gstruct19_1.int_0 > 0)
										{
											GStruct17 ptr = class3[class4.gstruct19_1.int_0 - 1];
											GStruct17 gstruct = class3[class4.gstruct19_1.int_0];
											if ((ptr.styleIndex_0 & styleIndex) != StyleIndex.None && (gstruct.styleIndex_0 & styleIndex) != StyleIndex.None)
											{
												return true;
											}
										}
									}
									return false;
								}
							}
							if (this.gstruct19_1.int_0 >= class3.Count || this.gstruct19_1.int_0 <= 0)
							{
								return false;
							}
							GStruct17 ptr2 = class3[this.gstruct19_1.int_0 - 1];
							GStruct17 gstruct2 = class3[this.gstruct19_1.int_0];
							if ((ptr2.styleIndex_0 & styleIndex) != StyleIndex.None && (gstruct2.styleIndex_0 & styleIndex) != StyleIndex.None)
							{
								return true;
							}
							return false;
						}
						else
						{
							using (IEnumerator<GStruct17> enumerator2 = this.IEnumerable_0.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if ((enumerator2.Current.styleIndex_0 & styleIndex) != StyleIndex.None)
									{
										return true;
									}
								}
								return false;
							}
						}
						bool flag;
						return flag;
					}
					return false;
				}
			}
			{
				if (@class != null)
				{
					StyleIndex styleIndex = Class357.smethod_0(this.control3_0.method_32(@class));
					if (this.Boolean_2)
					{
						Class351 class3 = this.control3_0[this.gstruct19_1.int_1];
						if (this.Boolean_0)
						{
							using (IEnumerator<Class357> enumerator = this.method_52(false).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									Class357 class4 = enumerator.Current;
									class3 = this.control3_0[class4.gstruct19_1.int_1];
									if (class4.gstruct19_1.int_0 < class3.Count && class4.gstruct19_1.int_0 > 0)
									{
										GStruct17 ptr = class3[class4.gstruct19_1.int_0 - 1];
										GStruct17 gstruct = class3[class4.gstruct19_1.int_0];
										if ((ptr.styleIndex_0 & styleIndex) != StyleIndex.None && (gstruct.styleIndex_0 & styleIndex) != StyleIndex.None)
										{
											return true;
										}
									}
								}
								return false;
							}
						}
						if (this.gstruct19_1.int_0 >= class3.Count || this.gstruct19_1.int_0 <= 0)
						{
							return false;
						}
						GStruct17 ptr2 = class3[this.gstruct19_1.int_0 - 1];
						GStruct17 gstruct2 = class3[this.gstruct19_1.int_0];
						if ((ptr2.styleIndex_0 & styleIndex) != StyleIndex.None && (gstruct2.styleIndex_0 & styleIndex) != StyleIndex.None)
						{
							return true;
						}
						return false;
					}
					else
					{
						using (IEnumerator<GStruct17> enumerator2 = this.IEnumerable_0.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if ((enumerator2.Current.styleIndex_0 & styleIndex) != StyleIndex.None)
								{
									return true;
								}
							}
							return false;
						}
					}
					bool flag;
					return flag;
				}
				return false;
			}
		}
		set
		{
			Class375 @class = null;
			Class368[] class368_ = this.control3_0.Class368_0;
			int i = 0;
			while (i < class368_.Length)
			{
				Class368 class2 = class368_[i];
				if (!(class2 is Class375))
				{
					i++;
				}
				else
				{
					@class = (Class375)class2;
					IL_0031:
					if (@class == null)
					{
						@class = new Class375();
					}
					if (value)
					{
						this.method_18(@class);
						return;
					}
					this.method_34(new Class368[] { @class });
					return;
				}
			}
			{
				if (@class == null)
				{
					@class = new Class375();
				}
				if (value)
				{
					this.method_18(@class);
					return;
				}
				this.method_34(new Class368[] { @class });
				return;
			}
		}
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x00014420 File Offset: 0x00012620
	public IEnumerator<GStruct19> GetEnumerator()
	{
		Class357.Class366 @class = new Class357.Class366(0);
		@class.class357_0 = this;
		return @class;
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0001442F File Offset: 0x0001262F
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<GStruct19>)this).GetEnumerator();
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x000E0F70 File Offset: 0x000DF170
	public bool method_0(GStruct19 gstruct19_2)
	{
		if (gstruct19_2.int_1 < Math.Min(this.gstruct19_1.int_1, this.gstruct19_0.int_1))
		{
			return false;
		}
		if (gstruct19_2.int_1 > Math.Max(this.gstruct19_1.int_1, this.gstruct19_0.int_1))
		{
			return false;
		}
		GStruct19 gstruct = this.gstruct19_1;
		GStruct19 gstruct2 = this.gstruct19_0;
		if (gstruct.int_1 > gstruct2.int_1 || (gstruct.int_1 == gstruct2.int_1 && gstruct.int_0 > gstruct2.int_0))
		{
			GStruct19 gstruct3 = gstruct;
			gstruct = gstruct2;
			gstruct2 = gstruct3;
		}
		if (this.Boolean_0)
		{
			if (gstruct19_2.int_0 < gstruct.int_0 || gstruct19_2.int_0 > gstruct2.int_0)
			{
				return false;
			}
		}
		else
		{
			if (gstruct19_2.int_1 == gstruct.int_1 && gstruct19_2.int_0 < gstruct.int_0)
			{
				return false;
			}
			if (gstruct19_2.int_1 == gstruct2.int_1 && gstruct19_2.int_0 > gstruct2.int_0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x000E1068 File Offset: 0x000DF268
	public virtual Class357 vmethod_0(Class357 class357_0)
	{
		if (this.Boolean_0)
		{
			return this.method_56(class357_0);
		}
		Class357 @class = this.method_6();
		Class357 class2 = class357_0.method_6();
		@class.method_40();
		class2.method_40();
		GStruct19 gstruct = (GStruct19.smethod_4(@class.GStruct19_0, class2.GStruct19_0) ? @class.GStruct19_0 : class2.GStruct19_0);
		GStruct19 gstruct2 = (GStruct19.smethod_2(@class.GStruct19_1, class2.GStruct19_1) ? @class.GStruct19_1 : class2.GStruct19_1);
		if (GStruct19.smethod_2(gstruct2, gstruct))
		{
			return new Class357(this.control3_0, this.gstruct19_1, this.gstruct19_1);
		}
		return this.control3_0.method_95(gstruct, gstruct2);
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x000E1114 File Offset: 0x000DF314
	public Class357 method_1(Class357 class357_0)
	{
		Class357 @class = this.method_6();
		Class357 class2 = class357_0.method_6();
		@class.method_40();
		class2.method_40();
		GStruct19 gstruct = (GStruct19.smethod_2(@class.GStruct19_0, class2.GStruct19_0) ? @class.GStruct19_0 : class2.GStruct19_0);
		GStruct19 gstruct2 = (GStruct19.smethod_4(@class.GStruct19_1, class2.GStruct19_1) ? @class.GStruct19_1 : class2.GStruct19_1);
		return this.control3_0.method_95(gstruct, gstruct2);
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x000E118C File Offset: 0x000DF38C
	public void method_2()
	{
		this.Boolean_0 = false;
		this.GStruct19_0 = new GStruct19(0, 0);
		if (this.control3_0.Int32_14 == 0)
		{
			this.GStruct19_0 = new GStruct19(0, 0);
		}
		else
		{
			this.gstruct19_0 = new GStruct19(0, 0);
			this.gstruct19_1 = new GStruct19(this.control3_0[this.control3_0.Int32_14 - 1].Count, this.control3_0.Int32_14 - 1);
		}
		if (this == this.control3_0.Class357_5)
		{
			this.control3_0.method_4();
		}
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x000E1224 File Offset: 0x000DF424
	internal void method_3(out string string_1, out List<GStruct19> list_1)
	{
		if (this.control3_0.Int32_6 == this.int_0)
		{
			string_1 = this.string_0;
			list_1 = this.list_0;
			return;
		}
		int num = Math.Min(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
		int num2 = Math.Max(this.gstruct19_0.int_1, this.gstruct19_1.int_1);
		int int32_ = this.Int32_2;
		int int32_2 = this.Int32_3;
		StringBuilder stringBuilder = new StringBuilder((num2 - num) * 50);
		list_1 = new List<GStruct19>(stringBuilder.Capacity);
		if (num >= 0)
		{
			for (int i = num; i <= num2; i++)
			{
				int num3 = ((i == num) ? int32_ : 0);
				int num4 = ((i == num2) ? Math.Min(int32_2 - 1, this.control3_0[i].Count - 1) : (this.control3_0[i].Count - 1));
				for (int j = num3; j <= num4; j++)
				{
					stringBuilder.Append(this.control3_0[i][j].char_0);
					list_1.Add(new GStruct19(j, i));
				}
				if (i != num2 && num != num2)
				{
					foreach (char c in Environment.NewLine)
					{
						stringBuilder.Append(c);
						list_1.Add(new GStruct19(this.control3_0[i].Count, i));
					}
				}
			}
		}
		string_1 = stringBuilder.ToString();
		list_1.Add(GStruct19.smethod_4(this.GStruct19_1, this.GStruct19_0) ? this.GStruct19_1 : this.GStruct19_0);
		this.string_0 = string_1;
		this.list_0 = list_1;
		this.int_0 = this.control3_0.Int32_6;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000E1404 File Offset: 0x000DF604
	public string method_4(int int_3)
	{
		int num = this.control3_0.method_90(this.GStruct19_0) - int_3;
		if (num < 0)
		{
			num = 0;
		}
		return new Class357(this.control3_0, this.control3_0.method_91(num), this.GStruct19_0).String_1;
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x00014437 File Offset: 0x00012637
	public string method_5(int int_3)
	{
		return this.method_4(-int_3);
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x00014441 File Offset: 0x00012641
	public Class357 method_6()
	{
		return (Class357)base.MemberwiseClone();
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x0001444E File Offset: 0x0001264E
	public bool method_7()
	{
		GStruct19 gstruct = this.gstruct19_1;
		this.method_11(false);
		return GStruct19.smethod_0(gstruct, this.gstruct19_1);
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x000E1450 File Offset: 0x000DF650
	public virtual bool vmethod_1()
	{
		if (this.Boolean_0)
		{
			return this.method_57();
		}
		if (this.gstruct19_1.int_1 >= this.control3_0.Int32_14 - 1 && this.gstruct19_1.int_0 >= this.control3_0[this.control3_0.Int32_14 - 1].Count)
		{
			return false;
		}
		if (this.gstruct19_1.int_0 < this.control3_0[this.gstruct19_1.int_1].Count)
		{
			this.gstruct19_1.method_0(1, 0);
		}
		else
		{
			this.gstruct19_1 = new GStruct19(0, this.gstruct19_1.int_1 + 1);
		}
		this.int_1 = -1;
		this.gstruct19_0 = this.gstruct19_1;
		this.method_37();
		return true;
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x00014468 File Offset: 0x00012668
	public bool method_8()
	{
		this.Boolean_0 = false;
		GStruct19 gstruct = this.gstruct19_1;
		this.method_10(false);
		return GStruct19.smethod_0(gstruct, this.gstruct19_1);
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000E151C File Offset: 0x000DF71C
	public bool method_9()
	{
		this.Boolean_0 = false;
		if (this.gstruct19_1.int_0 == 0 && this.gstruct19_1.int_1 == 0)
		{
			return false;
		}
		if (this.gstruct19_1.int_0 > 0)
		{
			this.gstruct19_1.method_0(-1, 0);
		}
		else
		{
			this.gstruct19_1 = new GStruct19(this.control3_0[this.gstruct19_1.int_1 - 1].Count, this.gstruct19_1.int_1 - 1);
		}
		this.int_1 = -1;
		this.gstruct19_0 = this.gstruct19_1;
		this.method_37();
		return true;
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000E15B8 File Offset: 0x000DF7B8
	public void method_10(bool bool_1)
	{
		this.Boolean_0 = false;
		if (!bool_1 && GStruct19.smethod_4(this.gstruct19_1, this.gstruct19_0))
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		if (this.gstruct19_1.int_0 != 0 || this.gstruct19_1.int_1 != 0)
		{
			if (this.gstruct19_1.int_0 > 0 && this.control3_0.list_0[this.gstruct19_1.int_1].genum18_0 == GEnum18.Visible)
			{
				this.gstruct19_1.method_0(-1, 0);
			}
			else
			{
				int num = this.control3_0.method_104(this.gstruct19_1.int_1);
				if (num == this.gstruct19_1.int_1)
				{
					return;
				}
				this.gstruct19_1 = new GStruct19(this.control3_0[num].Count, num);
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
		this.int_1 = -1;
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000E16AC File Offset: 0x000DF8AC
	public void method_11(bool bool_1)
	{
		this.Boolean_0 = false;
		if (!bool_1 && GStruct19.smethod_2(this.gstruct19_1, this.gstruct19_0))
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		if (this.gstruct19_1.int_1 < this.control3_0.Int32_14 - 1 || this.gstruct19_1.int_0 < this.control3_0[this.control3_0.Int32_14 - 1].Count)
		{
			if (this.gstruct19_1.int_0 < this.control3_0[this.gstruct19_1.int_1].Count && this.control3_0.list_0[this.gstruct19_1.int_1].genum18_0 == GEnum18.Visible)
			{
				this.gstruct19_1.method_0(1, 0);
			}
			else
			{
				int num = this.control3_0.method_103(this.gstruct19_1.int_1);
				if (num == this.gstruct19_1.int_1)
				{
					return;
				}
				this.gstruct19_1 = new GStruct19(0, num);
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
		this.int_1 = -1;
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x000E17D4 File Offset: 0x000DF9D4
	internal void method_12(bool bool_1)
	{
		this.Boolean_0 = false;
		if (!bool_1 && this.gstruct19_1.int_1 > this.gstruct19_0.int_1)
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		if (this.int_1 < 0)
		{
			this.int_1 = this.gstruct19_1.int_0 - this.control3_0.list_0[this.gstruct19_1.int_1].method_0(this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0));
		}
		int num = this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0);
		if (num == 0)
		{
			if (this.gstruct19_1.int_1 <= 0)
			{
				return;
			}
			int num2 = this.control3_0.method_104(this.gstruct19_1.int_1);
			if (num2 == this.gstruct19_1.int_1)
			{
				return;
			}
			this.gstruct19_1.int_1 = num2;
			num = this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0;
		}
		if (num > 0)
		{
			int num3 = this.control3_0.list_0[this.gstruct19_1.int_1].method_1(num - 1, this.control3_0[this.gstruct19_1.int_1]);
			this.gstruct19_1.int_0 = this.control3_0.list_0[this.gstruct19_1.int_1].method_0(num - 1) + this.int_1;
			if (this.gstruct19_1.int_0 > num3 + 1)
			{
				this.gstruct19_1.int_0 = num3 + 1;
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x000E19C8 File Offset: 0x000DFBC8
	internal void method_13(bool bool_1)
	{
		this.Boolean_0 = false;
		if (this.int_1 < 0)
		{
			this.int_1 = this.gstruct19_1.int_0 - this.control3_0.list_0[this.gstruct19_1.int_1].method_0(this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0));
		}
		int num = this.control3_0.ClientRectangle.Height / this.control3_0.Int32_2 - 1;
		for (int i = 0; i < num; i++)
		{
			int num2 = this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0);
			if (num2 == 0)
			{
				if (this.gstruct19_1.int_1 <= 0)
				{
					break;
				}
				int num3 = this.control3_0.method_104(this.gstruct19_1.int_1);
				if (num3 == this.gstruct19_1.int_1)
				{
					break;
				}
				this.gstruct19_1.int_1 = num3;
				num2 = this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0;
			}
			if (num2 > 0)
			{
				int num4 = this.control3_0.list_0[this.gstruct19_1.int_1].method_1(num2 - 1, this.control3_0[this.gstruct19_1.int_1]);
				this.gstruct19_1.int_0 = this.control3_0.list_0[this.gstruct19_1.int_1].method_0(num2 - 1) + this.int_1;
				if (this.gstruct19_1.int_0 > num4 + 1)
				{
					this.gstruct19_1.int_0 = num4 + 1;
				}
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000E1BD8 File Offset: 0x000DFDD8
	internal void method_14(bool bool_1)
	{
		this.Boolean_0 = false;
		if (!bool_1 && this.gstruct19_1.int_1 < this.gstruct19_0.int_1)
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		if (this.int_1 < 0)
		{
			this.int_1 = this.gstruct19_1.int_0 - this.control3_0.list_0[this.gstruct19_1.int_1].method_0(this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0));
		}
		int num = this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0);
		if (num >= this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0 - 1)
		{
			if (this.gstruct19_1.int_1 >= this.control3_0.Int32_14 - 1)
			{
				return;
			}
			int num2 = this.control3_0.method_103(this.gstruct19_1.int_1);
			if (num2 == this.gstruct19_1.int_1)
			{
				return;
			}
			this.gstruct19_1.int_1 = num2;
			num = -1;
		}
		if (num < this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0 - 1)
		{
			int num3 = this.control3_0.list_0[this.gstruct19_1.int_1].method_1(num + 1, this.control3_0[this.gstruct19_1.int_1]);
			this.gstruct19_1.int_0 = this.control3_0.list_0[this.gstruct19_1.int_1].method_0(num + 1) + this.int_1;
			if (this.gstruct19_1.int_0 > num3 + 1)
			{
				this.gstruct19_1.int_0 = num3 + 1;
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000E1DFC File Offset: 0x000DFFFC
	internal void method_15(bool bool_1)
	{
		this.Boolean_0 = false;
		if (this.int_1 < 0)
		{
			this.int_1 = this.gstruct19_1.int_0 - this.control3_0.list_0[this.gstruct19_1.int_1].method_0(this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0));
		}
		int num = this.control3_0.ClientRectangle.Height / this.control3_0.Int32_2 - 1;
		for (int i = 0; i < num; i++)
		{
			int num2 = this.control3_0.list_0[this.gstruct19_1.int_1].method_2(this.gstruct19_1.int_0);
			if (num2 >= this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0 - 1)
			{
				if (this.gstruct19_1.int_1 >= this.control3_0.Int32_14 - 1)
				{
					break;
				}
				int num3 = this.control3_0.method_103(this.gstruct19_1.int_1);
				if (num3 == this.gstruct19_1.int_1)
				{
					break;
				}
				this.gstruct19_1.int_1 = num3;
				num2 = -1;
			}
			if (num2 < this.control3_0.list_0[this.gstruct19_1.int_1].Int32_0 - 1)
			{
				int num4 = this.control3_0.list_0[this.gstruct19_1.int_1].method_1(num2 + 1, this.control3_0[this.gstruct19_1.int_1]);
				this.gstruct19_1.int_0 = this.control3_0.list_0[this.gstruct19_1.int_1].method_0(num2 + 1) + this.int_1;
				if (this.gstruct19_1.int_0 > num4 + 1)
				{
					this.gstruct19_1.int_0 = num4 + 1;
				}
			}
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000E2040 File Offset: 0x000E0240
	internal void method_16(bool bool_1)
	{
		this.Boolean_0 = false;
		if (this.gstruct19_1.int_1 < 0)
		{
			return;
		}
		if (this.control3_0.list_0[this.gstruct19_1.int_1].genum18_0 != GEnum18.Visible)
		{
			return;
		}
		this.gstruct19_1 = new GStruct19(0, this.gstruct19_1.int_1);
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
		this.int_1 = -1;
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000E20BC File Offset: 0x000E02BC
	internal void method_17(bool bool_1)
	{
		this.Boolean_0 = false;
		if (this.gstruct19_1.int_1 < 0)
		{
			return;
		}
		if (this.control3_0.list_0[this.gstruct19_1.int_1].genum18_0 != GEnum18.Visible)
		{
			return;
		}
		this.gstruct19_1 = new GStruct19(this.control3_0[this.gstruct19_1.int_1].Count, this.gstruct19_1.int_1);
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
		this.int_1 = -1;
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000E2150 File Offset: 0x000E0350
	public void method_18(Class368 class368_0)
	{
		int num = this.control3_0.method_34(class368_0);
		this.method_24(Class357.smethod_0(num));
		this.control3_0.method_4();
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000E2184 File Offset: 0x000E0384
	public void method_19(Class368 class368_0, string string_1)
	{
		StyleIndex styleIndex = Class357.smethod_0(this.control3_0.method_34(class368_0));
		this.method_22(styleIndex, string_1, RegexOptions.None);
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x000E21AC File Offset: 0x000E03AC
	public void method_20(Class368 class368_0, Regex regex_0)
	{
		StyleIndex styleIndex = Class357.smethod_0(this.control3_0.method_34(class368_0));
		this.method_23(styleIndex, regex_0);
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x000E21D4 File Offset: 0x000E03D4
	public void method_21(Class368 class368_0, string string_1, RegexOptions regexOptions_0)
	{
		StyleIndex styleIndex = Class357.smethod_0(this.control3_0.method_34(class368_0));
		this.method_22(styleIndex, string_1, regexOptions_0);
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000E21FC File Offset: 0x000E03FC
	public void method_22(StyleIndex styleIndex_0, string string_1, RegexOptions regexOptions_0)
	{
		if (Math.Abs(this.GStruct19_0.int_1 - this.GStruct19_1.int_1) > 1000)
		{
			regexOptions_0 |= Class379.RegexOptions_0;
		}
		foreach (Class357 @class in this.method_29(string_1, regexOptions_0))
		{
			@class.method_24(styleIndex_0);
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x000E2284 File Offset: 0x000E0484
	public void method_23(StyleIndex styleIndex_0, Regex regex_0)
	{
		foreach (Class357 @class in this.method_33(regex_0))
		{
			@class.method_24(styleIndex_0);
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x000E22DC File Offset: 0x000E04DC
	public void method_24(StyleIndex styleIndex_0)
	{
		int num = Math.Min(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		int num2 = Math.Max(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		int int32_ = this.Int32_2;
		int int32_2 = this.Int32_3;
		if (num < 0)
		{
			return;
		}
		for (int i = num; i <= num2; i++)
		{
			int num3 = ((i == num) ? int32_ : 0);
			int num4 = ((i == num2) ? Math.Min(int32_2 - 1, this.control3_0[i].Count - 1) : (this.control3_0[i].Count - 1));
			for (int j = num3; j <= num4; j++)
			{
				GStruct17 gstruct = this.control3_0[i][j];
				gstruct.styleIndex_0 |= styleIndex_0;
				this.control3_0[i][j] = gstruct;
			}
		}
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x00014489 File Offset: 0x00012689
	public void method_25(string string_1, string string_2)
	{
		this.method_26(string_1, string_2, Class379.RegexOptions_0);
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000E23D4 File Offset: 0x000E05D4
	public void method_26(string string_1, string string_2, RegexOptions regexOptions_0)
	{
		if (string_1 == string_2)
		{
			this.method_27(string_1, regexOptions_0);
			return;
		}
		foreach (Class357 @class in this.method_29(string_1, regexOptions_0))
		{
			this.control3_0[@class.GStruct19_0.int_1].String_0 = string_1;
		}
		foreach (Class357 class2 in this.method_29(string_2, regexOptions_0))
		{
			this.control3_0[class2.GStruct19_0.int_1].String_1 = string_1;
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000E24AC File Offset: 0x000E06AC
	public void method_27(string string_1, RegexOptions regexOptions_0)
	{
		foreach (Class357 @class in this.method_29(string_1, regexOptions_0))
		{
			if (@class.GStruct19_0.int_1 > 0)
			{
				this.control3_0[@class.GStruct19_0.int_1 - 1].String_1 = string_1;
			}
			this.control3_0[@class.GStruct19_0.int_1].String_0 = string_1;
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x00014498 File Offset: 0x00012698
	public IEnumerable<Class357> method_28(string string_1)
	{
		return this.method_29(string_1, RegexOptions.None);
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000144A2 File Offset: 0x000126A2
	public IEnumerable<Class357> method_29(string string_1, RegexOptions regexOptions_0)
	{
		Class357.Class360 @class = new Class357.Class360(-2);
		@class.class357_1 = this;
		@class.string_1 = string_1;
		@class.regexOptions_1 = regexOptions_0;
		return @class;
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000144C0 File Offset: 0x000126C0
	public IEnumerable<Class357> method_30(string string_1, RegexOptions regexOptions_0)
	{
		Class357.Class362 @class = new Class357.Class362(-2);
		@class.class357_1 = this;
		@class.string_1 = string_1;
		@class.regexOptions_1 = regexOptions_0;
		return @class;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000144DE File Offset: 0x000126DE
	public IEnumerable<Class357> method_31(Regex regex_0)
	{
		Class357.Class363 @class = new Class357.Class363(-2);
		@class.class357_1 = this;
		@class.regex_1 = regex_0;
		return @class;
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000144F5 File Offset: 0x000126F5
	public IEnumerable<Class357> method_32(string string_1, RegexOptions regexOptions_0)
	{
		Class357.Class364 @class = new Class357.Class364(-2);
		@class.class357_1 = this;
		@class.string_1 = string_1;
		@class.regexOptions_1 = regexOptions_0;
		return @class;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00014513 File Offset: 0x00012713
	public IEnumerable<Class357> method_33(Regex regex_0)
	{
		Class357.Class361 @class = new Class357.Class361(-2);
		@class.class357_1 = this;
		@class.regex_1 = regex_0;
		return @class;
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x000E2548 File Offset: 0x000E0748
	public void method_34(params Class368[] class368_0)
	{
		try
		{
			this.method_35(this.control3_0.method_33(class368_0));
		}
		catch
		{
		}
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x000E257C File Offset: 0x000E077C
	public void method_35(StyleIndex styleIndex_0)
	{
		int num = Math.Min(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		int num2 = Math.Max(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		int int32_ = this.Int32_2;
		int int32_2 = this.Int32_3;
		if (num < 0)
		{
			return;
		}
		for (int i = num; i <= num2; i++)
		{
			int num3 = ((i == num) ? int32_ : 0);
			int num4 = ((i == num2) ? Math.Min(int32_2 - 1, this.control3_0[i].Count - 1) : (this.control3_0[i].Count - 1));
			for (int j = num3; j <= num4; j++)
			{
				GStruct17 gstruct = this.control3_0[i][j];
				gstruct.styleIndex_0 &= ~styleIndex_0;
				this.control3_0[i][j] = gstruct;
			}
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x000E2684 File Offset: 0x000E0884
	public void method_36()
	{
		int num = Math.Min(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		int num2 = Math.Max(this.GStruct19_1.int_1, this.GStruct19_0.int_1);
		if (num < 0)
		{
			return;
		}
		for (int i = num; i <= num2; i++)
		{
			this.control3_0[i].method_1();
		}
		this.control3_0.method_4();
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x0001452A File Offset: 0x0001272A
	private void method_37()
	{
		this.int_0 = -1;
		this.string_0 = null;
		this.list_0 = null;
		if (this.control3_0.Class357_5 == this && this.int_2 == 0)
		{
			this.control3_0.vmethod_58();
		}
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00014562 File Offset: 0x00012762
	public void method_38()
	{
		this.int_2++;
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x00014572 File Offset: 0x00012772
	public void method_39()
	{
		this.int_2--;
		if (this.int_2 == 0)
		{
			this.method_37();
		}
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x000E26F8 File Offset: 0x000E08F8
	public override string ToString()
	{
		return "Start: " + this.GStruct19_0.ToString() + " End: " + this.GStruct19_1.ToString();
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00014590 File Offset: 0x00012790
	public void method_40()
	{
		if (GStruct19.smethod_4(this.GStruct19_0, this.GStruct19_1))
		{
			this.method_41();
		}
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x000E273C File Offset: 0x000E093C
	public void method_41()
	{
		GStruct19 gstruct = this.gstruct19_1;
		this.gstruct19_1 = this.gstruct19_0;
		this.gstruct19_0 = gstruct;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x000E2764 File Offset: 0x000E0964
	public void method_42()
	{
		this.method_40();
		this.gstruct19_1 = new GStruct19(0, this.gstruct19_1.int_1);
		this.gstruct19_0 = new GStruct19(this.control3_0.method_23(this.gstruct19_0.int_1), this.gstruct19_0.int_1);
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000145AB File Offset: 0x000127AB
	public Class357 method_43(string string_1)
	{
		return this.method_45(string_1, RegexOptions.None);
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000E27BC File Offset: 0x000E09BC
	public Class357 method_44(Class368 class368_0, bool bool_1)
	{
		StyleIndex styleIndex = this.control3_0.method_33(new Class368[] { class368_0 });
		Class357 @class = new Class357(this.control3_0);
		@class.GStruct19_0 = this.GStruct19_0;
		while (@class.method_9())
		{
			if (bool_1 || @class.Char_0 != '\n')
			{
				if (@class.GStruct19_0.int_0 >= this.control3_0.method_23(@class.GStruct19_0.int_1) || (this.control3_0[@class.GStruct19_0].styleIndex_0 & styleIndex) != StyleIndex.None)
				{
					continue;
				}
				@class.vmethod_1();
			}
			break;
		}
		GStruct19 gstruct = @class.GStruct19_0;
		@class.GStruct19_0 = this.GStruct19_0;
		do
		{
			if (!bool_1)
			{
				if (@class.Char_0 == '\n')
				{
					break;
				}
			}
			if (@class.GStruct19_0.int_0 < this.control3_0.method_23(@class.GStruct19_0.int_1) && (this.control3_0[@class.GStruct19_0].styleIndex_0 & styleIndex) == StyleIndex.None)
			{
				break;
			}
		}
		while (@class.vmethod_1());
		GStruct19 gstruct2 = @class.GStruct19_0;
		return new Class357(this.control3_0, gstruct, gstruct2);
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x000E28D8 File Offset: 0x000E0AD8
	public Class357 method_45(string string_1, RegexOptions regexOptions_0)
	{
		Class357 @class = new Class357(this.control3_0);
		@class.GStruct19_0 = this.GStruct19_0;
		Regex regex = new Regex(string_1, regexOptions_0);
		while (@class.method_9())
		{
			if (!regex.IsMatch(@class.Char_0.ToString()))
			{
				@class.vmethod_1();
				IL_004A:
				GStruct19 gstruct = @class.GStruct19_0;
				@class.GStruct19_0 = this.GStruct19_0;
				while (regex.IsMatch(@class.Char_0.ToString()) && @class.vmethod_1())
				{
				}
				GStruct19 gstruct2 = @class.GStruct19_0;
				return new Class357(this.control3_0, gstruct, gstruct2);
			}
		}
		{
			GStruct19 gstruct = @class.GStruct19_0;
			@class.GStruct19_0 = this.GStruct19_0;
			while (regex.IsMatch(@class.Char_0.ToString()) && @class.vmethod_1())
			{
			}
			GStruct19 gstruct2 = @class.GStruct19_0;
			return new Class357(this.control3_0, gstruct, gstruct2);
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x000145B5 File Offset: 0x000127B5
	private bool method_46(char char_0)
	{
		return char.IsLetterOrDigit(char_0) || char_0 == '_';
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000145C6 File Offset: 0x000127C6
	private bool method_47(char char_0)
	{
		return char_0 == ' ' || char_0 == '\t';
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000E2978 File Offset: 0x000E0B78
	public void method_48(bool bool_1)
	{
		this.Boolean_0 = false;
		if (!bool_1 && GStruct19.smethod_4(this.gstruct19_1, this.gstruct19_0))
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		Class357 @class = this.method_6();
		bool flag = false;
		while (this.method_47(@class.Char_1))
		{
			flag = true;
			@class.method_10(bool_1);
		}
		bool flag2 = false;
		while (this.method_46(@class.Char_1))
		{
			flag2 = true;
			@class.method_10(bool_1);
		}
		if (!flag2 && (!flag || @class.Char_1 != '\n'))
		{
			@class.method_10(bool_1);
		}
		this.GStruct19_0 = @class.GStruct19_0;
		this.GStruct19_1 = @class.GStruct19_1;
		if (this.control3_0.list_0[this.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_11(bool_1);
		}
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000E2A44 File Offset: 0x000E0C44
	public void method_49(bool bool_1, bool bool_2 = false)
	{
		this.Boolean_0 = false;
		if (!bool_1 && GStruct19.smethod_2(this.gstruct19_1, this.gstruct19_0))
		{
			this.GStruct19_0 = this.GStruct19_1;
			return;
		}
		Class357 @class = this.method_6();
		bool flag = false;
		if (@class.Char_0 == '\n')
		{
			@class.method_11(bool_1);
			flag = true;
		}
		bool flag2 = false;
		while (this.method_47(@class.Char_0))
		{
			flag2 = true;
			@class.method_11(bool_1);
		}
		if ((!flag2 && !flag) || !bool_2)
		{
			bool flag3 = false;
			while (this.method_46(@class.Char_0))
			{
				flag3 = true;
				@class.method_11(bool_1);
			}
			if (!flag3)
			{
				@class.method_11(bool_1);
			}
			if (bool_2 && !flag2)
			{
				while (this.method_47(@class.Char_0))
				{
					@class.method_11(bool_1);
				}
			}
		}
		this.GStruct19_0 = @class.GStruct19_0;
		this.GStruct19_1 = @class.GStruct19_1;
		if (this.control3_0.list_0[this.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_10(bool_1);
		}
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000E2B3C File Offset: 0x000E0D3C
	internal void method_50(bool bool_1)
	{
		this.Boolean_0 = false;
		this.gstruct19_1 = new GStruct19(0, 0);
		if (this.control3_0.list_0[this.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.control3_0.method_99(this.GStruct19_0.int_1);
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x000E2BAC File Offset: 0x000E0DAC
	internal void method_51(bool bool_1)
	{
		this.Boolean_0 = false;
		this.gstruct19_1 = new GStruct19(this.control3_0[this.control3_0.Int32_14 - 1].Count, this.control3_0.Int32_14 - 1);
		if (this.control3_0.list_0[this.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.control3_0.method_99(this.GStruct19_0.int_1);
		}
		if (!bool_1)
		{
			this.gstruct19_0 = this.gstruct19_1;
		}
		this.method_37();
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000145D4 File Offset: 0x000127D4
	public static StyleIndex smethod_0(int int_3)
	{
		return (StyleIndex)(1 << int_3);
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x000145DD File Offset: 0x000127DD
	public IEnumerable<Class357> method_52(bool bool_1)
	{
		Class357.Class365 @class = new Class357.Class365(-2);
		@class.class357_1 = this;
		@class.bool_1 = bool_1;
		return @class;
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000E2C44 File Offset: 0x000E0E44
	public bool method_53()
	{
		if (this.control3_0.Boolean_9)
		{
			return true;
		}
		Class357 @class = this.method_6();
		@class.method_40();
		if (@class.gstruct19_1.int_0 == 0)
		{
			return false;
		}
		if (this.Boolean_0)
		{
			@class.method_63();
		}
		else
		{
			@class.method_10(true);
		}
		return @class.Boolean_1;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x000E2C9C File Offset: 0x000E0E9C
	public bool method_54()
	{
		if (this.control3_0.Boolean_9)
		{
			return true;
		}
		Class357 @class = this.method_6();
		@class.method_40();
		if (@class.gstruct19_0.int_0 >= this.control3_0[this.gstruct19_0.int_1].Count)
		{
			return false;
		}
		if (this.Boolean_0)
		{
			@class.method_62();
		}
		else
		{
			@class.method_11(true);
		}
		return @class.Boolean_1;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000145F4 File Offset: 0x000127F4
	public IEnumerable<GStruct19> method_55(GStruct19 gstruct19_2, bool bool_1 = false)
	{
		Class357.Class359 @class = new Class357.Class359(-2);
		@class.class357_0 = this;
		@class.gstruct19_2 = gstruct19_2;
		@class.bool_1 = bool_1;
		return @class;
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000E2D0C File Offset: 0x000E0F0C
	private Class357 method_56(Class357 class357_0)
	{
		if (class357_0.GStruct19_0.int_1 != class357_0.GStruct19_1.int_1)
		{
			return new Class357(this.control3_0, this.GStruct19_0, this.GStruct19_0);
		}
		GStruct20 gstruct20_ = this.GStruct20_0;
		if (class357_0.GStruct19_0.int_1 >= gstruct20_.int_0 && class357_0.GStruct19_0.int_1 <= gstruct20_.int_2)
		{
			return new Class357(this.control3_0, gstruct20_.int_1, class357_0.GStruct19_0.int_1, gstruct20_.int_3, class357_0.GStruct19_0.int_1).vmethod_0(class357_0);
		}
		return new Class357(this.control3_0, this.GStruct19_0, this.GStruct19_0);
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000E2DC4 File Offset: 0x000E0FC4
	private bool method_57()
	{
		GStruct20 gstruct20_ = this.GStruct20_0;
		bool flag = true;
		int i = gstruct20_.int_0;
		while (i <= gstruct20_.int_2)
		{
			if (gstruct20_.int_3 >= this.control3_0[i].Count)
			{
				i++;
			}
			else
			{
				flag = false;
				IL_0041:
				if (flag)
				{
					return false;
				}
				GStruct19 gstruct = this.GStruct19_0;
				GStruct19 gstruct2 = this.GStruct19_1;
				gstruct.method_0(1, 0);
				gstruct2.method_0(1, 0);
				this.method_38();
				this.GStruct19_0 = gstruct;
				this.GStruct19_1 = gstruct2;
				this.method_39();
				return true;
			}
		}
		{
			if (flag)
			{
				return false;
			}
			GStruct19 gstruct = this.GStruct19_0;
			GStruct19 gstruct2 = this.GStruct19_1;
			gstruct.method_0(1, 0);
			gstruct2.method_0(1, 0);
			this.method_38();
			this.GStruct19_0 = gstruct;
			this.GStruct19_1 = gstruct2;
			this.method_39();
			return true;
		}
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x00014612 File Offset: 0x00012812
	private IEnumerable<GStruct19> method_58()
	{
		Class357.Class358 @class = new Class357.Class358(-2);
		@class.class357_0 = this;
		return @class;
	}

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000E2E54 File Offset: 0x000E1054
	private string String_0
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			GStruct20 gstruct20_ = this.GStruct20_0;
			if (gstruct20_.int_0 < 0)
			{
				return "";
			}
			for (int i = gstruct20_.int_0; i <= gstruct20_.int_2; i++)
			{
				for (int j = gstruct20_.int_1; j < gstruct20_.int_3; j++)
				{
					if (j < this.control3_0[i].Count)
					{
						stringBuilder.Append(this.control3_0[i][j].char_0);
					}
				}
				if (gstruct20_.int_2 != gstruct20_.int_0 && i != gstruct20_.int_2)
				{
					stringBuilder.AppendLine();
				}
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000E2F00 File Offset: 0x000E1100
	private int method_59(bool bool_1)
	{
		GStruct20 gstruct20_ = this.GStruct20_0;
		if (gstruct20_.int_0 < 0)
		{
			return 0;
		}
		int num = 0;
		for (int i = gstruct20_.int_0; i <= gstruct20_.int_2; i++)
		{
			for (int j = gstruct20_.int_1; j < gstruct20_.int_3; j++)
			{
				if (j < this.control3_0[i].Count)
				{
					num++;
				}
			}
			if (bool_1 && gstruct20_.int_2 != gstruct20_.int_0 && i != gstruct20_.int_2)
			{
				num += Environment.NewLine.Length;
			}
		}
		return num;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x000E2F90 File Offset: 0x000E1190
	internal void method_60()
	{
		int num = this.control3_0.method_103(this.GStruct19_1.int_1);
		this.GStruct19_1 = new GStruct19(this.GStruct19_1.int_0, num);
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x000E2FCC File Offset: 0x000E11CC
	internal void method_61()
	{
		int num = this.control3_0.method_104(this.GStruct19_1.int_1);
		this.GStruct19_1 = new GStruct19(this.GStruct19_1.int_0, num);
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x00014622 File Offset: 0x00012822
	internal void method_62()
	{
		this.GStruct19_1 = new GStruct19(this.GStruct19_1.int_0 + 1, this.GStruct19_1.int_1);
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x00014647 File Offset: 0x00012847
	internal void method_63()
	{
		if (this.GStruct19_1.int_0 > 0)
		{
			this.GStruct19_1 = new GStruct19(this.GStruct19_1.int_0 - 1, this.GStruct19_1.int_1);
		}
	}

	// Token: 0x040012A8 RID: 4776
	public readonly Control3 control3_0;

	// Token: 0x040012A9 RID: 4777
	private List<GStruct19> list_0;

	// Token: 0x040012AA RID: 4778
	private string string_0;

	// Token: 0x040012AB RID: 4779
	private int int_0 = -1;

	// Token: 0x040012AC RID: 4780
	private GStruct19 gstruct19_0;

	// Token: 0x040012AD RID: 4781
	private int int_1 = -1;

	// Token: 0x040012AE RID: 4782
	private GStruct19 gstruct19_1;

	// Token: 0x040012AF RID: 4783
	private int int_2;

	// Token: 0x040012B0 RID: 4784
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x02000224 RID: 548
	[CompilerGenerated]
	private sealed class Class358 : IEnumerable, IDisposable, IEnumerator, IEnumerable<GStruct19>, IEnumerator<GStruct19>
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x0001467A File Offset: 0x0001287A
		[DebuggerHidden]
		public Class358(int int_4)
		{
			this.int_0 = int_4;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00014694 File Offset: 0x00012894
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000E3008 File Offset: 0x000E1208
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class357 @class = this.class357_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
			}
			else
			{
				this.int_0 = -1;
				this.gstruct20_0 = @class.GStruct20_0;
				if (this.gstruct20_0.int_0 < 0)
				{
					return false;
				}
				this.int_2 = this.gstruct20_0.int_0;
				goto IL_00BA;
			}
			IL_0087:
			int num2 = this.int_3;
			this.int_3 = num2 + 1;
			IL_0097:
			if (this.int_3 >= this.gstruct20_0.int_3)
			{
				num2 = this.int_2;
				this.int_2 = num2 + 1;
			}
			else
			{
				if (this.int_3 >= @class.control3_0[this.int_2].Count)
				{
					goto IL_0087;
				}
				this.gstruct19_0 = new GStruct19(this.int_3, this.int_2);
				this.int_0 = 1;
				return true;
			}
			IL_00BA:
			if (this.int_2 > this.gstruct20_0.int_2)
			{
				return false;
			}
			this.int_3 = this.gstruct20_0.int_1;
			goto IL_0097;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0001469E File Offset: 0x0001289E
		public GStruct19 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000146A6 File Offset: 0x000128A6
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000E3104 File Offset: 0x000E1304
		[DebuggerHidden]
		public IEnumerator<GStruct19> GetEnumerator()
		{
			Class357.Class358 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class358(0);
				@class.class357_0 = this.class357_0;
			}
			return @class;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000146B3 File Offset: 0x000128B3
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012B1 RID: 4785
		private int int_0;

		// Token: 0x040012B2 RID: 4786
		private GStruct19 gstruct19_0;

		// Token: 0x040012B3 RID: 4787
		private int int_1;

		// Token: 0x040012B4 RID: 4788
		public Class357 class357_0;

		// Token: 0x040012B5 RID: 4789
		private GStruct20 gstruct20_0;

		// Token: 0x040012B6 RID: 4790
		private int int_2;

		// Token: 0x040012B7 RID: 4791
		private int int_3;
	}

	// Token: 0x02000225 RID: 549
	[CompilerGenerated]
	private sealed class Class359 : IEnumerable, IDisposable, IEnumerator, IEnumerable<GStruct19>, IEnumerator<GStruct19>
	{
		// Token: 0x06001E25 RID: 7717 RVA: 0x000146BB File Offset: 0x000128BB
		[DebuggerHidden]
		public Class359(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000146D5 File Offset: 0x000128D5
		[DebuggerHidden]
		public void Dispose()
		{
			this.class357_1 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x000E3148 File Offset: 0x000E1348
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class357 @class = this.class357_0;
			switch (num)
			{
			case 0:
				this.int_0 = -1;
				if (this.bool_0)
				{
					this.class357_1 = new Class357(@class.control3_0, this.gstruct19_1, this.gstruct19_1);
				}
				else
				{
					this.class357_1 = new Class357(@class.control3_0, this.gstruct19_1, this.gstruct19_1);
					if (GStruct19.smethod_2(this.gstruct19_1, @class.GStruct19_1))
					{
						goto IL_01BF;
					}
					goto IL_01FE;
				}
				break;
			case 1:
				this.int_0 = -1;
				break;
			case 2:
				this.int_0 = -1;
				goto IL_0181;
			case 3:
				this.int_0 = -1;
				goto IL_01F1;
			case 4:
				this.int_0 = -1;
				goto IL_02A5;
			default:
				return false;
			}
			while (this.class357_1.method_8() && GStruct19.smethod_5(this.class357_1.gstruct19_1, @class.GStruct19_0))
			{
				if (this.class357_1.GStruct19_0.int_0 < @class.control3_0[this.class357_1.GStruct19_0.int_1].Count)
				{
					this.gstruct19_0 = this.class357_1.GStruct19_0;
					this.int_0 = 1;
					return true;
				}
			}
			this.class357_1 = new Class357(@class.control3_0, @class.GStruct19_1, @class.GStruct19_1);
			IL_0181:
			while (this.class357_1.method_8() && GStruct19.smethod_5(this.class357_1.gstruct19_1, this.gstruct19_1))
			{
				if (this.class357_1.GStruct19_0.int_0 < @class.control3_0[this.class357_1.GStruct19_0.int_1].Count)
				{
					this.gstruct19_0 = this.class357_1.GStruct19_0;
					this.int_0 = 2;
					return true;
				}
			}
			this.class357_1 = null;
			return false;
			IL_01BF:
			if (this.class357_1.GStruct19_0.int_0 < @class.control3_0[this.class357_1.GStruct19_0.int_1].Count)
			{
				this.gstruct19_0 = this.class357_1.GStruct19_0;
				this.int_0 = 3;
				return true;
			}
			IL_01F1:
			if (this.class357_1.method_7())
			{
				goto IL_01BF;
			}
			IL_01FE:
			this.class357_1 = new Class357(@class.control3_0, @class.GStruct19_0, @class.GStruct19_0);
			if (!GStruct19.smethod_2(this.class357_1.GStruct19_0, this.gstruct19_1))
			{
				goto IL_02CE;
			}
			IL_0273:
			if (this.class357_1.GStruct19_0.int_0 < @class.control3_0[this.class357_1.GStruct19_0.int_1].Count)
			{
				this.gstruct19_0 = this.class357_1.GStruct19_0;
				this.int_0 = 4;
				return true;
			}
			IL_02A5:
			if (this.class357_1.method_7() && GStruct19.smethod_2(this.class357_1.GStruct19_0, this.gstruct19_1))
			{
				goto IL_0273;
			}
			IL_02CE:
			this.class357_1 = null;
			return false;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000146E6 File Offset: 0x000128E6
		public GStruct19 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000146EE File Offset: 0x000128EE
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000E342C File Offset: 0x000E162C
		[DebuggerHidden]
		public IEnumerator<GStruct19> GetEnumerator()
		{
			Class357.Class359 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class359(0);
				@class.class357_0 = this.class357_0;
			}
			@class.gstruct19_1 = this.gstruct19_2;
			@class.bool_0 = this.bool_1;
			return @class;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000146FB File Offset: 0x000128FB
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012B8 RID: 4792
		private int int_0;

		// Token: 0x040012B9 RID: 4793
		private GStruct19 gstruct19_0;

		// Token: 0x040012BA RID: 4794
		private int int_1;

		// Token: 0x040012BB RID: 4795
		private bool bool_0;

		// Token: 0x040012BC RID: 4796
		public bool bool_1;

		// Token: 0x040012BD RID: 4797
		public Class357 class357_0;

		// Token: 0x040012BE RID: 4798
		private GStruct19 gstruct19_1;

		// Token: 0x040012BF RID: 4799
		public GStruct19 gstruct19_2;

		// Token: 0x040012C0 RID: 4800
		private Class357 class357_1;
	}

	// Token: 0x02000226 RID: 550
	[CompilerGenerated]
	private sealed class Class360 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x00014703 File Offset: 0x00012903
		[DebuggerHidden]
		public Class360(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000E3488 File Offset: 0x000E1688
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.list_0 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000E34D8 File Offset: 0x000E16D8
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_1;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					string text;
					@class.method_3(out text, out this.list_0);
					Regex regex = new Regex(this.string_0, this.regexOptions_0);
					this.ienumerator_0 = regex.Matches(text).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					Match match = (Match)this.ienumerator_0.Current;
					Class357 class2 = new Class357(@class.control3_0);
					Group group = match.Groups["range"];
					if (!group.Success)
					{
						group = match.Groups[0];
					}
					class2.GStruct19_0 = this.list_0[group.Index];
					class2.GStruct19_1 = this.list_0[group.Index + group.Length];
					this.class357_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000E362C File Offset: 0x000E182C
		private void method_0()
		{
			this.int_0 = -1;
			IDisposable disposable = this.ienumerator_0 as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0001471D File Offset: 0x0001291D
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0001471D File Offset: 0x0001291D
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x000E3658 File Offset: 0x000E1858
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class360 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class360(0);
				@class.class357_1 = this.class357_1;
			}
			@class.string_0 = this.string_1;
			@class.regexOptions_0 = this.regexOptions_1;
			return @class;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00014725 File Offset: 0x00012925
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012C1 RID: 4801
		private int int_0;

		// Token: 0x040012C2 RID: 4802
		private Class357 class357_0;

		// Token: 0x040012C3 RID: 4803
		private int int_1;

		// Token: 0x040012C4 RID: 4804
		public Class357 class357_1;

		// Token: 0x040012C5 RID: 4805
		private string string_0;

		// Token: 0x040012C6 RID: 4806
		public string string_1;

		// Token: 0x040012C7 RID: 4807
		private RegexOptions regexOptions_0;

		// Token: 0x040012C8 RID: 4808
		public RegexOptions regexOptions_1;

		// Token: 0x040012C9 RID: 4809
		private List<GStruct19> list_0;

		// Token: 0x040012CA RID: 4810
		private IEnumerator ienumerator_0;
	}

	// Token: 0x02000227 RID: 551
	[CompilerGenerated]
	private sealed class Class361 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x0001472D File Offset: 0x0001292D
		[DebuggerHidden]
		public Class361(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000E36B4 File Offset: 0x000E18B4
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.list_0 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000E3704 File Offset: 0x000E1904
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_1;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					string text;
					@class.method_3(out text, out this.list_0);
					this.ienumerator_0 = this.regex_0.Matches(text).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					Match match = (Match)this.ienumerator_0.Current;
					Class357 class2 = new Class357(@class.control3_0);
					Group group = match.Groups["range"];
					if (!group.Success)
					{
						group = match.Groups[0];
					}
					class2.GStruct19_0 = this.list_0[group.Index];
					class2.GStruct19_1 = this.list_0[group.Index + group.Length];
					this.class357_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000E3848 File Offset: 0x000E1A48
		private void method_0()
		{
			this.int_0 = -1;
			IDisposable disposable = this.ienumerator_0 as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00014747 File Offset: 0x00012947
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00014747 File Offset: 0x00012947
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000E3874 File Offset: 0x000E1A74
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class361 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class361(0);
				@class.class357_1 = this.class357_1;
			}
			@class.regex_0 = this.regex_1;
			return @class;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0001474F File Offset: 0x0001294F
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012CB RID: 4811
		private int int_0;

		// Token: 0x040012CC RID: 4812
		private Class357 class357_0;

		// Token: 0x040012CD RID: 4813
		private int int_1;

		// Token: 0x040012CE RID: 4814
		public Class357 class357_1;

		// Token: 0x040012CF RID: 4815
		private Regex regex_0;

		// Token: 0x040012D0 RID: 4816
		public Regex regex_1;

		// Token: 0x040012D1 RID: 4817
		private List<GStruct19> list_0;

		// Token: 0x040012D2 RID: 4818
		private IEnumerator ienumerator_0;
	}

	// Token: 0x02000228 RID: 552
	[CompilerGenerated]
	private sealed class Class362 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E3F RID: 7743 RVA: 0x00014757 File Offset: 0x00012957
		[DebuggerHidden]
		public Class362(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000E38C4 File Offset: 0x000E1AC4
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000E390C File Offset: 0x000E1B0C
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_1;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					Regex regex = new Regex(this.string_0, this.regexOptions_0);
					this.ienumerator_0 = @class.method_31(regex).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					Class357 class2 = this.ienumerator_0.Current;
					this.class357_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00014771 File Offset: 0x00012971
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0001478D File Offset: 0x0001298D
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0001478D File Offset: 0x0001298D
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000E39C8 File Offset: 0x000E1BC8
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class362 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class362(0);
				@class.class357_1 = this.class357_1;
			}
			@class.string_0 = this.string_1;
			@class.regexOptions_0 = this.regexOptions_1;
			return @class;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00014795 File Offset: 0x00012995
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012D3 RID: 4819
		private int int_0;

		// Token: 0x040012D4 RID: 4820
		private Class357 class357_0;

		// Token: 0x040012D5 RID: 4821
		private int int_1;

		// Token: 0x040012D6 RID: 4822
		private string string_0;

		// Token: 0x040012D7 RID: 4823
		public string string_1;

		// Token: 0x040012D8 RID: 4824
		private RegexOptions regexOptions_0;

		// Token: 0x040012D9 RID: 4825
		public RegexOptions regexOptions_1;

		// Token: 0x040012DA RID: 4826
		public Class357 class357_1;

		// Token: 0x040012DB RID: 4827
		private IEnumerator<Class357> ienumerator_0;
	}

	// Token: 0x02000229 RID: 553
	[CompilerGenerated]
	private sealed class Class363 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x0001479D File Offset: 0x0001299D
		[DebuggerHidden]
		public Class363(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000E3A24 File Offset: 0x000E1C24
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.class382_0 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000E3A74 File Offset: 0x000E1C74
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_1;
				if (num == 0)
				{
					this.int_0 = -1;
					@class.method_40();
					this.class382_0 = @class.control3_0.Class381_0 as Class382;
					this.int_2 = @class.GStruct19_0.int_1;
					goto IL_014F;
				}
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -3;
				IL_010A:
				if (this.ienumerator_0.MoveNext())
				{
					Class357 class2 = this.ienumerator_0.Current;
					this.class357_0 = class2;
					this.int_0 = 1;
					return true;
				}
				this.method_0();
				this.ienumerator_0 = null;
				if (!this.bool_0)
				{
					this.class382_0.method_7(this.int_2);
				}
				int num2 = this.int_2;
				this.int_2 = num2 + 1;
				IL_014F:
				if (this.int_2 <= @class.GStruct19_1.int_1)
				{
					this.bool_0 = this.class382_0 == null || this.class382_0.vmethod_2(this.int_2);
					Class357 class3 = new Class357(@class.control3_0, new GStruct19(0, this.int_2), new GStruct19(@class.control3_0[this.int_2].Count, this.int_2));
					if (this.int_2 == @class.GStruct19_0.int_1 || this.int_2 == @class.GStruct19_1.int_1)
					{
						class3 = class3.vmethod_0(@class);
					}
					this.ienumerator_0 = class3.method_33(this.regex_0).GetEnumerator();
					this.int_0 = -3;
					goto IL_010A;
				}
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000147B7 File Offset: 0x000129B7
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x000147D3 File Offset: 0x000129D3
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x000147D3 File Offset: 0x000129D3
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000E3C30 File Offset: 0x000E1E30
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class363 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class363(0);
				@class.class357_1 = this.class357_1;
			}
			@class.regex_0 = this.regex_1;
			return @class;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000147DB File Offset: 0x000129DB
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012DC RID: 4828
		private int int_0;

		// Token: 0x040012DD RID: 4829
		private Class357 class357_0;

		// Token: 0x040012DE RID: 4830
		private int int_1;

		// Token: 0x040012DF RID: 4831
		public Class357 class357_1;

		// Token: 0x040012E0 RID: 4832
		private Regex regex_0;

		// Token: 0x040012E1 RID: 4833
		public Regex regex_1;

		// Token: 0x040012E2 RID: 4834
		private Class382 class382_0;

		// Token: 0x040012E3 RID: 4835
		private int int_2;

		// Token: 0x040012E4 RID: 4836
		private bool bool_0;

		// Token: 0x040012E5 RID: 4837
		private IEnumerator<Class357> ienumerator_0;
	}

	// Token: 0x0200022A RID: 554
	[CompilerGenerated]
	private sealed class Class364 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x000147E3 File Offset: 0x000129E3
		[DebuggerHidden]
		public Class364(int int_4)
		{
			this.int_0 = int_4;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000147FD File Offset: 0x000129FD
		[DebuggerHidden]
		public void Dispose()
		{
			this.regex_0 = null;
			this.class382_0 = null;
			this.list_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000E3C80 File Offset: 0x000E1E80
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class357 @class = this.class357_1;
			if (num == 0)
			{
				this.int_0 = -1;
				@class.method_40();
				this.regex_0 = new Regex(this.string_0, this.regexOptions_0);
				this.class382_0 = @class.control3_0.Class381_0 as Class382;
				this.int_2 = @class.GStruct19_1.int_1;
				goto IL_016F;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			int num2 = this.int_3;
			this.int_3 = num2 - 1;
			IL_0136:
			if (this.int_3 >= 0)
			{
				this.class357_0 = this.list_0[this.int_3];
				this.int_0 = 1;
				return true;
			}
			if (!this.bool_0)
			{
				this.class382_0.method_7(this.int_2);
			}
			this.list_0 = null;
			num2 = this.int_2;
			this.int_2 = num2 - 1;
			IL_016F:
			if (this.int_2 < @class.GStruct19_0.int_1)
			{
				return false;
			}
			this.bool_0 = this.class382_0 == null || this.class382_0.vmethod_2(this.int_2);
			Class357 class2 = new Class357(@class.control3_0, new GStruct19(0, this.int_2), new GStruct19(@class.control3_0[this.int_2].Count, this.int_2));
			if (this.int_2 == @class.GStruct19_0.int_1 || this.int_2 == @class.GStruct19_1.int_1)
			{
				class2 = class2.vmethod_0(@class);
			}
			this.list_0 = class2.method_33(this.regex_0).ToList<Class357>();
			this.int_3 = this.list_0.Count - 1;
			goto IL_0136;
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x0001481C File Offset: 0x00012A1C
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0001481C File Offset: 0x00012A1C
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000E3E34 File Offset: 0x000E2034
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class364 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class364(0);
				@class.class357_1 = this.class357_1;
			}
			@class.string_0 = this.string_1;
			@class.regexOptions_0 = this.regexOptions_1;
			return @class;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00014824 File Offset: 0x00012A24
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012E6 RID: 4838
		private int int_0;

		// Token: 0x040012E7 RID: 4839
		private Class357 class357_0;

		// Token: 0x040012E8 RID: 4840
		private int int_1;

		// Token: 0x040012E9 RID: 4841
		public Class357 class357_1;

		// Token: 0x040012EA RID: 4842
		private string string_0;

		// Token: 0x040012EB RID: 4843
		public string string_1;

		// Token: 0x040012EC RID: 4844
		private RegexOptions regexOptions_0;

		// Token: 0x040012ED RID: 4845
		public RegexOptions regexOptions_1;

		// Token: 0x040012EE RID: 4846
		private Regex regex_0;

		// Token: 0x040012EF RID: 4847
		private Class382 class382_0;

		// Token: 0x040012F0 RID: 4848
		private int int_2;

		// Token: 0x040012F1 RID: 4849
		private bool bool_0;

		// Token: 0x040012F2 RID: 4850
		private List<Class357> list_0;

		// Token: 0x040012F3 RID: 4851
		private int int_3;
	}

	// Token: 0x0200022B RID: 555
	[CompilerGenerated]
	private sealed class Class365 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x0001482C File Offset: 0x00012A2C
		[DebuggerHidden]
		public Class365(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00014846 File Offset: 0x00012A46
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000E3E90 File Offset: 0x000E2090
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class357 @class = this.class357_1;
			switch (num)
			{
			case 0:
				this.int_0 = -1;
				if (!@class.Boolean_0)
				{
					this.class357_0 = @class;
					this.int_0 = 1;
					return true;
				}
				this.gstruct20_0 = @class.GStruct20_0;
				this.int_2 = this.gstruct20_0.int_0;
				break;
			case 1:
				this.int_0 = -1;
				return false;
			case 2:
				this.int_0 = -1;
				goto IL_00B0;
			default:
				return false;
			}
			IL_0072:
			if (this.int_2 > this.gstruct20_0.int_2)
			{
				return false;
			}
			if (this.gstruct20_0.int_1 <= @class.control3_0[this.int_2].Count || this.bool_0)
			{
				Class357 class2 = new Class357(@class.control3_0, this.gstruct20_0.int_1, this.int_2, Math.Min(this.gstruct20_0.int_3, @class.control3_0[this.int_2].Count), this.int_2);
				this.class357_0 = class2;
				this.int_0 = 2;
				return true;
			}
			IL_00B0:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			goto IL_0072;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00014850 File Offset: 0x00012A50
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00014850 File Offset: 0x00012A50
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000E3FBC File Offset: 0x000E21BC
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Class357.Class365 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class365(0);
				@class.class357_1 = this.class357_1;
			}
			@class.bool_0 = this.bool_1;
			return @class;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00014858 File Offset: 0x00012A58
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040012F4 RID: 4852
		private int int_0;

		// Token: 0x040012F5 RID: 4853
		private Class357 class357_0;

		// Token: 0x040012F6 RID: 4854
		private int int_1;

		// Token: 0x040012F7 RID: 4855
		public Class357 class357_1;

		// Token: 0x040012F8 RID: 4856
		private bool bool_0;

		// Token: 0x040012F9 RID: 4857
		public bool bool_1;

		// Token: 0x040012FA RID: 4858
		private GStruct20 gstruct20_0;

		// Token: 0x040012FB RID: 4859
		private int int_2;
	}

	// Token: 0x0200022C RID: 556
	[CompilerGenerated]
	private sealed class Class366 : IDisposable, IEnumerator, IEnumerator<GStruct19>
	{
		// Token: 0x06001E61 RID: 7777 RVA: 0x00014860 File Offset: 0x00012A60
		[DebuggerHidden]
		public Class366(int int_8)
		{
			this.int_0 = int_8;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000E400C File Offset: 0x000E220C
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000E4054 File Offset: 0x000E2254
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_0;
				switch (num)
				{
				case 0:
					this.int_0 = -1;
					if (@class.Boolean_0)
					{
						this.ienumerator_0 = @class.method_58().GetEnumerator();
						this.int_0 = -3;
					}
					else
					{
						this.int_1 = Math.Min(@class.gstruct19_0.int_1, @class.gstruct19_1.int_1);
						this.int_2 = Math.Max(@class.gstruct19_0.int_1, @class.gstruct19_1.int_1);
						this.int_3 = @class.Int32_2;
						this.int_4 = @class.Int32_3;
						if (this.int_1 < 0)
						{
							return false;
						}
						this.int_5 = this.int_1;
						goto IL_0146;
					}
					break;
				case 1:
					this.int_0 = -3;
					break;
				case 2:
				{
					this.int_0 = -1;
					int num2 = this.int_7;
					this.int_7 = num2 + 1;
					goto IL_01CB;
				}
				default:
					return false;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					return false;
				}
				GStruct19 gstruct = this.ienumerator_0.Current;
				this.gstruct19_0 = gstruct;
				this.int_0 = 1;
				return true;
				IL_0146:
				if (this.int_5 > this.int_2)
				{
					return false;
				}
				int num3 = ((this.int_5 == this.int_1) ? this.int_3 : 0);
				this.int_6 = ((this.int_5 == this.int_2) ? Math.Min(this.int_4 - 1, @class.control3_0[this.int_5].Count - 1) : (@class.control3_0[this.int_5].Count - 1));
				this.int_7 = num3;
				IL_01CB:
				if (this.int_7 > this.int_6)
				{
					int num2 = this.int_5;
					this.int_5 = num2 + 1;
					goto IL_0146;
				}
				this.gstruct19_0 = new GStruct19(this.int_7, this.int_5);
				this.int_0 = 2;
				flag = true;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0001486F File Offset: 0x00012A6F
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x0001488B File Offset: 0x00012A8B
		public GStruct19 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00014893 File Offset: 0x00012A93
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct19_0;
			}
		}

		// Token: 0x040012FC RID: 4860
		private int int_0;

		// Token: 0x040012FD RID: 4861
		private GStruct19 gstruct19_0;

		// Token: 0x040012FE RID: 4862
		public Class357 class357_0;

		// Token: 0x040012FF RID: 4863
		private int int_1;

		// Token: 0x04001300 RID: 4864
		private int int_2;

		// Token: 0x04001301 RID: 4865
		private int int_3;

		// Token: 0x04001302 RID: 4866
		private int int_4;

		// Token: 0x04001303 RID: 4867
		private IEnumerator<GStruct19> ienumerator_0;

		// Token: 0x04001304 RID: 4868
		private int int_5;

		// Token: 0x04001305 RID: 4869
		private int int_6;

		// Token: 0x04001306 RID: 4870
		private int int_7;
	}

	// Token: 0x0200022D RID: 557
	[CompilerGenerated]
	private sealed class Class367 : IEnumerable, IDisposable, IEnumerator, IEnumerable<GStruct17>, IEnumerator<GStruct17>
	{
		// Token: 0x06001E68 RID: 7784 RVA: 0x000148A0 File Offset: 0x00012AA0
		[DebuggerHidden]
		public Class367(int int_9)
		{
			this.int_0 = int_9;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000E428C File Offset: 0x000E248C
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.ienumerator_0 = null;
			this.class351_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000E42DC File Offset: 0x000E24DC
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class357 @class = this.class357_0;
				switch (num)
				{
				case 0:
					this.int_0 = -1;
					if (@class.Boolean_0)
					{
						this.ienumerator_0 = @class.method_58().GetEnumerator();
						this.int_0 = -3;
					}
					else
					{
						this.int_2 = Math.Min(@class.gstruct19_0.int_1, @class.gstruct19_1.int_1);
						this.int_3 = Math.Max(@class.gstruct19_0.int_1, @class.gstruct19_1.int_1);
						this.int_4 = @class.Int32_2;
						this.int_5 = @class.Int32_3;
						if (this.int_2 < 0)
						{
							return false;
						}
						this.int_6 = this.int_2;
						goto IL_015B;
					}
					break;
				case 1:
					this.int_0 = -3;
					break;
				case 2:
				{
					this.int_0 = -1;
					int num2 = this.int_8;
					this.int_8 = num2 + 1;
					goto IL_01F7;
				}
				default:
					return false;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					return false;
				}
				GStruct19 gstruct = this.ienumerator_0.Current;
				this.gstruct17_0 = @class.control3_0[gstruct];
				this.int_0 = 1;
				return true;
				IL_015B:
				if (this.int_6 > this.int_3)
				{
					return false;
				}
				int num3 = ((this.int_6 == this.int_2) ? this.int_4 : 0);
				this.int_7 = ((this.int_6 == this.int_3) ? Math.Min(this.int_5 - 1, @class.control3_0[this.int_6].Count - 1) : (@class.control3_0[this.int_6].Count - 1));
				this.class351_0 = @class.control3_0[this.int_6];
				this.int_8 = num3;
				IL_01F7:
				if (this.int_8 > this.int_7)
				{
					this.class351_0 = null;
					int num2 = this.int_6;
					this.int_6 = num2 + 1;
					goto IL_015B;
				}
				this.gstruct17_0 = this.class351_0[this.int_8];
				this.int_0 = 2;
				flag = true;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000148BA File Offset: 0x00012ABA
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000148D6 File Offset: 0x00012AD6
		public GStruct17 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct17_0;
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x000148DE File Offset: 0x00012ADE
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct17_0;
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000E4540 File Offset: 0x000E2740
		[DebuggerHidden]
		public IEnumerator<GStruct17> GetEnumerator()
		{
			Class357.Class367 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class357.Class367(0);
				@class.class357_0 = this.class357_0;
			}
			return @class;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000148EB File Offset: 0x00012AEB
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04001307 RID: 4871
		private int int_0;

		// Token: 0x04001308 RID: 4872
		private GStruct17 gstruct17_0;

		// Token: 0x04001309 RID: 4873
		private int int_1;

		// Token: 0x0400130A RID: 4874
		public Class357 class357_0;

		// Token: 0x0400130B RID: 4875
		private int int_2;

		// Token: 0x0400130C RID: 4876
		private int int_3;

		// Token: 0x0400130D RID: 4877
		private int int_4;

		// Token: 0x0400130E RID: 4878
		private int int_5;

		// Token: 0x0400130F RID: 4879
		private IEnumerator<GStruct19> ienumerator_0;

		// Token: 0x04001310 RID: 4880
		private int int_6;

		// Token: 0x04001311 RID: 4881
		private int int_7;

		// Token: 0x04001312 RID: 4882
		private Class351 class351_0;

		// Token: 0x04001313 RID: 4883
		private int int_8;
	}
}
