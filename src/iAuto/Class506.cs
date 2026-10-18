using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020002D3 RID: 723
internal class Class506
{
	// Token: 0x06002610 RID: 9744 RVA: 0x00019D15 File Offset: 0x00017F15
	public Class506(Class106 class106_1)
	{
		this.Class106_0 = class106_1;
	}

	// Token: 0x170007AB RID: 1963
	// (get) Token: 0x06002611 RID: 9745 RVA: 0x00019D50 File Offset: 0x00017F50
	// (set) Token: 0x06002612 RID: 9746 RVA: 0x00019D58 File Offset: 0x00017F58
	public List<Class504> List_0 { get; set; } = new List<Class504>();

	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x06002613 RID: 9747 RVA: 0x0011C0E8 File Offset: 0x0011A2E8
	public IEnumerable<Class504> IEnumerable_0
	{
		get
		{
			return this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_0)).Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_1));
		}
	}

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x06002614 RID: 9748 RVA: 0x00019D61 File Offset: 0x00017F61
	// (set) Token: 0x06002615 RID: 9749 RVA: 0x00019D69 File Offset: 0x00017F69
	public Class106 Class106_0 { get; set; }

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x06002616 RID: 9750 RVA: 0x00019D72 File Offset: 0x00017F72
	// (set) Token: 0x06002617 RID: 9751 RVA: 0x00019D7A File Offset: 0x00017F7A
	public Class504 Class504_0 { get; set; }

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06002618 RID: 9752 RVA: 0x00019D83 File Offset: 0x00017F83
	public IEnumerable<Class504> IEnumerable_1
	{
		get
		{
			return this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_2));
		}
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x06002619 RID: 9753 RVA: 0x00019DAF File Offset: 0x00017FAF
	// (set) Token: 0x0600261A RID: 9754 RVA: 0x00019DB7 File Offset: 0x00017FB7
	public List<Class504> List_1 { get; set; } = new List<Class504>();

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x0600261B RID: 9755 RVA: 0x00019DC0 File Offset: 0x00017FC0
	public IEnumerable<Class504> IEnumerable_2
	{
		get
		{
			Class506.Class509 @class = new Class506.Class509(-2);
			@class.class506_0 = this;
			return @class;
		}
	}

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x0600261C RID: 9756 RVA: 0x00019DD0 File Offset: 0x00017FD0
	public IEnumerable<Class504> IEnumerable_3
	{
		get
		{
			return this.List_0.Where<Class504>(new Func<Class504, bool>(this.method_7));
		}
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x0600261D RID: 9757 RVA: 0x00019DE9 File Offset: 0x00017FE9
	// (set) Token: 0x0600261E RID: 9758 RVA: 0x00019DF1 File Offset: 0x00017FF1
	public List<Class504> List_2 { get; set; } = new List<Class504>();

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x0600261F RID: 9759 RVA: 0x00019DFA File Offset: 0x00017FFA
	public IEnumerable<Class504> IEnumerable_4
	{
		get
		{
			return this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_4));
		}
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x06002620 RID: 9760 RVA: 0x00019E26 File Offset: 0x00018026
	// (set) Token: 0x06002621 RID: 9761 RVA: 0x00019E2E File Offset: 0x0001802E
	public Class504 Class504_1 { get; set; }

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x06002622 RID: 9762 RVA: 0x00019E37 File Offset: 0x00018037
	// (set) Token: 0x06002623 RID: 9763 RVA: 0x00019E3F File Offset: 0x0001803F
	public Class504 Class504_2 { get; set; }

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x06002624 RID: 9764 RVA: 0x0011C144 File Offset: 0x0011A344
	public bool Boolean_0
	{
		get
		{
			if (this.Class106_0.method_143())
			{
				return true;
			}
			Class504 @class = this.Class504_2;
			return ((@class != null) ? @class.String_2 : null) != null && this.Class106_0.Class527_0.string_0.Contains(this.Class504_2.String_2);
		}
	}

	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x06002625 RID: 9765 RVA: 0x00019E48 File Offset: 0x00018048
	public IEnumerable<Class504> IEnumerable_5
	{
		get
		{
			return this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_5));
		}
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x0011C198 File Offset: 0x0011A398
	public HashSet<long> method_0(long long_0)
	{
		HashSet<long> hashSet = new HashSet<long>();
		Stack<long> stack = new Stack<long>();
		stack.Push(long_0);
		while (stack.Count > 0 && hashSet.Count <= 10000)
		{
			long num = stack.Pop();
			if (num > 0L && !hashSet.Contains(num))
			{
				hashSet.Add(num);
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num }));
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num + (long)this.Class106_0.Class515_0.Int32_1 }));
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num + (long)(this.Class106_0.Class515_0.Int32_1 * 2) }));
			}
		}
		return hashSet;
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x00019E74 File Offset: 0x00018074
	public IEnumerable<Class504> method_1(float float_0, float float_1 = -1f, float float_2 = -1f)
	{
		Class506.Class508 @class = new Class506.Class508(-2);
		@class.class506_0 = this;
		@class.float_5 = float_0;
		@class.float_1 = float_1;
		@class.float_3 = float_2;
		return @class;
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x0011C28C File Offset: 0x0011A48C
	public Class504 method_2(string string_0)
	{
		foreach (Class504 @class in this.List_0)
		{
			if (@class.String_9 == string_0)
			{
				return @class;
			}
		}
		return null;
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x0011C2F0 File Offset: 0x0011A4F0
	public bool method_3(string string_0)
	{
		using (List<Class504>.Enumerator enumerator = this.List_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.String_4.Contains(string_0.smethod_36()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x0011C358 File Offset: 0x0011A558
	public bool method_4(string string_0)
	{
		string_0 = string_0.smethod_36();
		using (List<Class504>.Enumerator enumerator = this.List_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.String_4.Contains(string_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x0011C3C0 File Offset: 0x0011A5C0
	public void method_5()
	{
		try
		{
			this.Class504_1 = (this.Class504_0 = (this.Class504_2 = null));
			this.List_0.Clear();
			this.List_2.Clear();
			this.List_1.Clear();
			long num = this.Class106_0.Class515_0.method_9(new long[]
			{
				this.Class106_0.Class502_0.Int64_4[0],
				this.Class106_0.Class502_0.Int64_4[1],
				this.Class106_0.Class502_0.Int64_4[2]
			});
			foreach (long num2 in this.method_0(num))
			{
				Class504 @class = new Class504(this.Class106_0, num2);
				if (@class.Int32_4 >= 0)
				{
					@class.method_4();
					if (!@class.String_9.Equals("Lão Tôn Đầu"))
					{
						if (@class.Boolean_5 && @class.String_9 == this.Class106_0.String_6 && this.Class106_0.String_6.Trim().Length > 1)
						{
							this.Class504_0 = @class;
						}
						if (@class.Int32_4 == this.Class106_0.Int32_14)
						{
							this.Class504_2 = @class;
						}
						if (@class.String_11 == this.Class106_0.Class527_0.String_1 && this.Class106_0.Class527_0.Boolean_41)
						{
							this.Class504_1 = @class;
							this.Class106_0.Class527_0.Int32_31 = this.Class504_1.Int32_8;
							this.Class106_0.Int32_52 = this.Class504_1.Int32_4;
							if (this.Class106_0.Single_3 != this.Class106_0.Single_5 || this.Class106_0.Single_4 != this.Class106_0.Single_6)
							{
								this.Class106_0.Class0_0.Stopwatch_3 = Stopwatch.StartNew();
							}
							this.Class106_0.Single_3 = this.Class106_0.Single_5;
							this.Class106_0.Single_4 = this.Class106_0.Single_6;
							this.Class106_0.Single_5 = this.Class504_1.Single_4;
							this.Class106_0.Single_6 = this.Class504_1.Single_5;
						}
						if (@class.method_1(this.Class106_0) < (float)Class226.Int32_35 || GUI.GUI_0.String_2 == "tieudattai@yahoo.com" || GUI.GUI_0.String_2 == "0813673640" || GUI.GUI_0.String_2 == "lctauto@gmail.com" || !Class226.Boolean_112)
						{
							this.List_0.Add(@class);
						}
					}
				}
			}
			this.Class106_0.Class527_0.string_0 = "0000000000000000FFFFFFFFFFFFFFFF";
			if (this.Class504_1 != null)
			{
				Class527 class527_ = this.Class106_0.Class527_0;
				class527_.string_0 += this.Class504_1.String_11;
				bool flag = false;
				foreach (Class504 class2 in this.List_0)
				{
					if (class2 != this.Class504_1)
					{
						if (class2.Boolean_5 && class2.Single_2 > 0f)
						{
							if (Class226.Boolean_31 && Class226.HashSet_2.Contains(class2.String_9))
							{
								continue;
							}
							if (!string.IsNullOrEmpty(class2.String_9))
							{
								if ((Class226.Boolean_19 || this.Class106_0.Boolean_51) && Class226.HashSet_3.Count > 0 && !Class226.HashSet_3.Contains(class2.String_9))
								{
									continue;
								}
								if (Class226.Boolean_70)
								{
									int num3 = Class226.String_5.Split(new char[] { ',' }).smethod_15(class2.String_9);
									if (num3 != -1)
									{
										flag = true;
										if (this.List_2.Count > 0)
										{
											string string_ = this.List_2[0].String_9;
											int num4 = Class226.String_5.Split(new char[] { ',' }).smethod_15(string_);
											if (num4 == -1 || num4 > num3)
											{
												this.List_2.Clear();
												this.List_2.Add(class2);
											}
										}
										else
										{
											this.List_2.Add(class2);
										}
									}
								}
								if (!flag && Class226.Boolean_55 && this.Class106_0.Dictionary_5.ContainsKey(class2.String_9))
								{
									this.List_2.Add(class2);
								}
							}
						}
						if ((double)this.Class504_1.Single_2 > 0.3 && this.Class504_1.Int32_9 != 65535 && this.Class106_0.Class502_0.Int32_5 == 1 && Class226.Boolean_40)
						{
							if (this.Class504_1.Int32_9 == class2.Int32_9 && class2.Boolean_5 && class2.Single_2 > 0f)
							{
								Class527 class527_2 = this.Class106_0.Class527_0;
								class527_2.string_0 += class2.String_11;
							}
						}
						else if (this.Class504_1.Int32_8 != -1 && class2.Int32_8 == this.Class504_1.Int32_8 && class2.Single_2 > 0f)
						{
							Class527 class527_3 = this.Class106_0.Class527_0;
							class527_3.string_0 += class2.String_11;
							if (class2.String_11 == this.Class106_0.Class527_0.String_5 && this.Class504_0 == null)
							{
								this.Class504_0 = class2;
							}
						}
						if (class2.Boolean_2)
						{
							this.List_1.Add(class2);
						}
						if (this.Class504_1.Int32_8 != -1 && class2.String_13 == this.Class106_0.Class527_0.String_5 && this.Class504_0 == null)
						{
							this.Class504_0 = class2;
						}
					}
				}
				if (!flag && this.List_2.Count > 0 && Class226.Boolean_69 && Class226.HashSet_4.Count > 0)
				{
					if (this.List_0.Any<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_6)))
					{
						this.List_2 = this.List_2.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_7)).ToList<Class504>();
					}
				}
				if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_1)
				{
					this.List_0 = this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_8)).ToList<Class504>();
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x0011CB28 File Offset: 0x0011AD28
	public void method_6()
	{
		this.List_0.ForEach(new Action<Class504>(this.method_8));
		this.List_1 = this.List_0.Where<Class504>(new Func<Class504, bool>(Class506.Class507.f_96A810B5.method_9)).ToList<Class504>();
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00019EA5 File Offset: 0x000180A5
	[CompilerGenerated]
	private bool method_7(Class504 class504_3)
	{
		if (class504_3.Boolean_5)
		{
			if (this.Class504_1.Int32_8 != -1)
			{
				if (class504_3.Int32_8 == this.Class504_1.Int32_8)
				{
					return true;
				}
			}
			return class504_3 == this.Class504_1;
		}
		return false;
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x0011CB84 File Offset: 0x0011AD84
	[CompilerGenerated]
	private void method_8(Class504 class504_3)
	{
		class504_3.method_5();
		if (class504_3.String_11 == this.Class106_0.Class527_0.String_1 && this.Class106_0.Class527_0.Boolean_41)
		{
			this.Class504_1 = class504_3;
			this.Class106_0.Class527_0.Int32_31 = this.Class504_1.Int32_8;
			this.Class106_0.Int32_52 = this.Class504_1.Int32_4;
			this.Class106_0.Single_5 = this.Class504_1.Single_4;
			this.Class106_0.Single_6 = this.Class504_1.Single_5;
		}
		if (class504_3.Int32_4 == this.Class106_0.Int32_14)
		{
			this.Class504_2 = class504_3;
		}
	}

	// Token: 0x040019A6 RID: 6566
	public static Dictionary<string, Class504> dictionary_0 = new Dictionary<string, Class504>();

	// Token: 0x040019A7 RID: 6567
	[CompilerGenerated]
	private List<Class504> list_0;

	// Token: 0x040019A8 RID: 6568
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x040019A9 RID: 6569
	[CompilerGenerated]
	private Class504 class504_0;

	// Token: 0x040019AA RID: 6570
	[CompilerGenerated]
	private List<Class504> list_1;

	// Token: 0x040019AB RID: 6571
	[CompilerGenerated]
	private List<Class504> list_2;

	// Token: 0x040019AC RID: 6572
	[CompilerGenerated]
	private Class504 class504_1;

	// Token: 0x040019AD RID: 6573
	[CompilerGenerated]
	private Class504 class504_2;

	// Token: 0x040019AE RID: 6574
	public List<Class504> list_3 = new List<Class504>();

	// Token: 0x020002D4 RID: 724
	[CompilerGenerated]
	[Serializable]
	private sealed class Class507
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x00019EEB File Offset: 0x000180EB
		internal bool method_0(Class504 class504_0)
		{
			return !Class226.Boolean_31 || !Class226.HashSet_2.Contains(class504_0.String_9);
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00019F09 File Offset: 0x00018109
		internal bool method_1(Class504 class504_0)
		{
			return class504_0.Boolean_3;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00019F11 File Offset: 0x00018111
		internal bool method_2(Class504 class504_0)
		{
			return class504_0.Boolean_0;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_3(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00017743 File Offset: 0x00015943
		internal bool method_4(Class504 class504_0)
		{
			return class504_0.Boolean_5;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0000BE4E File Offset: 0x0000A04E
		internal bool method_5(Class504 class504_0)
		{
			return class504_0.Boolean_10;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0011CC44 File Offset: 0x0011AE44
		internal bool method_6(Class504 class504_0)
		{
			return Class226.HashSet_4.Contains(class504_0.String_9) || Class226.HashSet_4.Contains(class504_0.String_5) || Class226.HashSet_4.Contains("Guild-" + class504_0.Int32_3.ToString());
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0011CC44 File Offset: 0x0011AE44
		internal bool method_7(Class504 class504_0)
		{
			return Class226.HashSet_4.Contains(class504_0.String_9) || Class226.HashSet_4.Contains(class504_0.String_5) || Class226.HashSet_4.Contains("Guild-" + class504_0.Int32_3.ToString());
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00019F19 File Offset: 0x00018119
		internal bool method_8(Class504 class504_0)
		{
			return class504_0.Single_1 <= 15f;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00019F2B File Offset: 0x0001812B
		internal bool method_9(Class504 class504_0)
		{
			return class504_0.Boolean_2;
		}

		// Token: 0x040019AF RID: 6575
		public static readonly Class506.Class507 f_96A810B5 = new Class506.Class507();

		// Token: 0x040019B0 RID: 6576
		public static Func<Class504, bool> f_FC9EA219;

		// Token: 0x040019B1 RID: 6577
		public static Func<Class504, bool> f_A46D31FE;

		// Token: 0x040019B2 RID: 6578
		public static Func<Class504, bool> f_65B85B39;

		// Token: 0x040019B3 RID: 6579
		public static Func<Class106, string> f_1D9E1CE8;

		// Token: 0x040019B4 RID: 6580
		public static Func<Class504, bool> f_9F67EBA2;

		// Token: 0x040019B5 RID: 6581
		public static Func<Class504, bool> f_CA76039A;

		// Token: 0x040019B6 RID: 6582
		public static Func<Class504, bool> f_6CF0B530;

		// Token: 0x040019B7 RID: 6583
		public static Func<Class504, bool> f_9E618173;

		// Token: 0x040019B8 RID: 6584
		public static Func<Class504, bool> f_300216A3;

		// Token: 0x040019B9 RID: 6585
		public static Func<Class504, bool> f_ACF63BEB;
	}

	// Token: 0x020002D5 RID: 725
	[CompilerGenerated]
	private sealed class Class508 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class504>, IEnumerator<Class504>
	{
		// Token: 0x0600263C RID: 9788 RVA: 0x00019F33 File Offset: 0x00018133
		[DebuggerHidden]
		public Class508(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0011CC9C File Offset: 0x0011AE9C
		[DebuggerHidden]
		public void Dispose()
		{
			switch (this.int_0)
			{
			case -4:
			case 2:
				break;
			case -3:
			case 1:
				try
				{
					goto IL_0042;
				}
				finally
				{
					this.method_0();
				}
				break;
			case -2:
			case -1:
			case 0:
				goto IL_0042;
			default:
				goto IL_0042;
			}
			try
			{
			}
			finally
			{
				this.method_1();
			}
			IL_0042:
			this.enumerator_0 = default(List<Class504>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0011CD1C File Offset: 0x0011AF1C
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class506 @class = this.class506_0;
				switch (num)
				{
				case 0:
					this.int_0 = -1;
					if (this.float_0 == -1f)
					{
						this.float_0 = @class.Class106_0.Single_5;
					}
					if (this.float_2 == -1f)
					{
						this.float_2 = @class.Class106_0.Single_6;
					}
					this.enumerator_0 = @class.List_1.GetEnumerator();
					this.int_0 = -3;
					break;
				case 1:
					this.int_0 = -3;
					break;
				case 2:
					this.int_0 = -4;
					goto IL_0164;
				default:
					return false;
				}
				while (this.enumerator_0.MoveNext())
				{
					Class504 class2 = this.enumerator_0.Current;
					if (class2.method_3(this.float_0, this.float_2) < this.float_4)
					{
						this.class504_0 = class2;
						this.int_0 = 1;
						return true;
					}
				}
				this.method_0();
				this.enumerator_0 = default(List<Class504>.Enumerator);
				if (@class.Class106_0.Class527_0.Int32_35 != Class513.Int32_153)
				{
					goto IL_0183;
				}
				this.enumerator_0 = @class.List_0.GetEnumerator();
				this.int_0 = -4;
				IL_0164:
				while (this.enumerator_0.MoveNext())
				{
					Class504 class3 = this.enumerator_0.Current;
					if (class3.method_3(this.float_0, this.float_2) < this.float_4 && class3.Int32_7 == 12 && class3.Boolean_3)
					{
						this.class504_0 = class3;
						this.int_0 = 2;
						return true;
					}
				}
				this.method_1();
				this.enumerator_0 = default(List<Class504>.Enumerator);
				IL_0183:
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00019F4D File Offset: 0x0001814D
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00019F4D File Offset: 0x0001814D
		private void method_1()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x00019F67 File Offset: 0x00018167
		public Class504 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class504_0;
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x00019F67 File Offset: 0x00018167
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class504_0;
			}
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x0011CEE8 File Offset: 0x0011B0E8
		[DebuggerHidden]
		public IEnumerator<Class504> GetEnumerator()
		{
			Class506.Class508 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class506.Class508(0);
				@class.class506_0 = this.class506_0;
			}
			@class.float_4 = this.float_5;
			@class.float_0 = this.float_1;
			@class.float_2 = this.float_3;
			return @class;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00019F6F File Offset: 0x0001816F
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040019BA RID: 6586
		private int int_0;

		// Token: 0x040019BB RID: 6587
		private Class504 class504_0;

		// Token: 0x040019BC RID: 6588
		private int int_1;

		// Token: 0x040019BD RID: 6589
		private float float_0;

		// Token: 0x040019BE RID: 6590
		public float float_1;

		// Token: 0x040019BF RID: 6591
		public Class506 class506_0;

		// Token: 0x040019C0 RID: 6592
		private float float_2;

		// Token: 0x040019C1 RID: 6593
		public float float_3;

		// Token: 0x040019C2 RID: 6594
		private float float_4;

		// Token: 0x040019C3 RID: 6595
		public float float_5;

		// Token: 0x040019C4 RID: 6596
		private List<Class504>.Enumerator enumerator_0;
	}

	// Token: 0x020002D6 RID: 726
	[CompilerGenerated]
	private sealed class Class509 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class504>, IEnumerator<Class504>
	{
		// Token: 0x06002646 RID: 9798 RVA: 0x00019F77 File Offset: 0x00018177
		[DebuggerHidden]
		public Class509(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0011CF50 File Offset: 0x0011B150
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num - 1 <= 2)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.enumerator_0 = default(List<Class504>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0011CFA0 File Offset: 0x0011B1A0
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class506 @class = this.class506_0;
				switch (num)
				{
				case 0:
					this.int_0 = -1;
					this.enumerator_0 = @class.List_0.GetEnumerator();
					this.int_0 = -3;
					break;
				case 1:
					this.int_0 = -3;
					break;
				case 2:
					this.int_0 = -3;
					break;
				case 3:
					this.int_0 = -3;
					break;
				default:
					return false;
				}
				while (this.enumerator_0.MoveNext())
				{
					Class504 class2 = this.enumerator_0.Current;
					if (class2.Boolean_5)
					{
						if (!@class.Class106_0.HashSet_0.Contains(class2.String_9))
						{
							if (Class226.Boolean_35)
							{
								if (Class106.IEnumerable_0.Select<Class106, string>(new Func<Class106, string>(Class506.Class507.f_96A810B5.method_3)).Contains(class2.String_9))
								{
									goto IL_01EC;
								}
							}
							if ((!Class226.Boolean_40 || @class.Class504_1.Int32_9 == 65535 || @class.Class106_0.Class502_0.Int32_5 != 1 || @class.Class504_1.Int32_9 != class2.Int32_9) && (@class.Class504_1.Int32_8 == -1 || class2.Int32_8 != @class.Class504_1.Int32_8))
							{
								if (class2 != @class.Class504_1)
								{
									continue;
								}
							}
						}
						IL_01EC:
						this.class504_0 = class2;
						this.int_0 = 1;
						return true;
					}
					if (@class.Class106_0.Class527_0.Int32_35 == Class513.Int32_145 && (class2.String_4 == "hodienbao" || class2.String_4 == "tienhoanhvu"))
					{
						this.class504_0 = class2;
						this.int_0 = 2;
						return true;
					}
					if (@class.Class106_0.Class527_0.Int32_35 == Class513.Int32_129 && class2.String_12.smethod_36() == "linhthu")
					{
						this.class504_0 = class2;
						this.int_0 = 3;
						return true;
					}
				}
				this.method_0();
				this.enumerator_0 = default(List<Class504>.Enumerator);
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00019F91 File Offset: 0x00018191
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00019FAB File Offset: 0x000181AB
		public Class504 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class504_0;
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00019FAB File Offset: 0x000181AB
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class504_0;
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0011D1F4 File Offset: 0x0011B3F4
		[DebuggerHidden]
		public IEnumerator<Class504> GetEnumerator()
		{
			Class506.Class509 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class506.Class509(0);
				@class.class506_0 = this.class506_0;
			}
			return @class;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00019FB3 File Offset: 0x000181B3
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040019C5 RID: 6597
		private int int_0;

		// Token: 0x040019C6 RID: 6598
		private Class504 class504_0;

		// Token: 0x040019C7 RID: 6599
		private int int_1;

		// Token: 0x040019C8 RID: 6600
		public Class506 class506_0;

		// Token: 0x040019C9 RID: 6601
		private List<Class504>.Enumerator enumerator_0;
	}
}
