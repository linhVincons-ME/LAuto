using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000141 RID: 321
internal class Class214
{
	// Token: 0x0600124C RID: 4684 RVA: 0x0000DC6C File Offset: 0x0000BE6C
	public Class214(Class106 class106_1)
	{
		this.Class106_0 = class106_1;
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x0600124D RID: 4685 RVA: 0x0000DC86 File Offset: 0x0000BE86
	// (set) Token: 0x0600124E RID: 4686 RVA: 0x0000DC8E File Offset: 0x0000BE8E
	public Class106 Class106_0 { get; set; }

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x0600124F RID: 4687 RVA: 0x0000DC97 File Offset: 0x0000BE97
	public IEnumerable<Class516> IEnumerable_0
	{
		get
		{
			return this.IEnumerable_1.Concat<Class516>(this.IEnumerable_2).Concat<Class516>(this.IEnumerable_3);
		}
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x000A63A4 File Offset: 0x000A45A4
	public void method_0()
	{
		bool flag = false;
		foreach (Class516 @class in this.IEnumerable_1)
		{
			if (@class.Boolean_8)
			{
				flag = true;
				this.dictionary_0[@class.Int64_5] = this.Class106_0.Class515_0.method_7(new long[] { @class.Int64_5 });
				this.Class106_0.Class515_0.method_21(@class.Int64_5, 50);
			}
		}
		if (flag && Class214.stopwatch_0.Elapsed.TotalMinutes > 1.0)
		{
			Class214.stopwatch_0 = Stopwatch.StartNew();
			this.Class106_0.method_493("Detect Equitment [Hold Ctrl]");
		}
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x000A647C File Offset: 0x000A467C
	public void method_1()
	{
		foreach (KeyValuePair<long, int> keyValuePair in this.dictionary_0)
		{
			this.Class106_0.Class515_0.method_21(keyValuePair.Key, keyValuePair.Value);
		}
		this.dictionary_0.Clear();
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x000A64F4 File Offset: 0x000A46F4
	public Class516 Class516_0
	{
		get
		{
			long num = this.Class106_0.Class515_0.method_9(new long[]
			{
				this.Class106_0.Class502_0.Int64_38[0],
				this.Class106_0.Class502_0.Int64_38[1]
			});
			long num2 = this.Class106_0.Class515_0.method_9(new long[] { num + (long)(17 * this.Class106_0.Class515_0.Int32_1) });
			if (num2 != 0L)
			{
				return new Class516(this.Class106_0, num2, false);
			}
			return null;
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x0000DCB5 File Offset: 0x0000BEB5
	public IEnumerable<Class516> IEnumerable_1
	{
		get
		{
			Class214.Class217 @class = new Class214.Class217(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x06001254 RID: 4692 RVA: 0x0000DCC5 File Offset: 0x0000BEC5
	public IEnumerable<Class516> IEnumerable_2
	{
		get
		{
			Class214.Class219 @class = new Class214.Class219(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06001255 RID: 4693 RVA: 0x0000DCD5 File Offset: 0x0000BED5
	public IEnumerable<Class516> IEnumerable_3
	{
		get
		{
			Class214.Class220 @class = new Class214.Class220(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x06001256 RID: 4694 RVA: 0x0000DCE5 File Offset: 0x0000BEE5
	public IEnumerable<Class516> IEnumerable_4
	{
		get
		{
			Class214.Class215 @class = new Class214.Class215(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06001257 RID: 4695 RVA: 0x0000DCF5 File Offset: 0x0000BEF5
	public IEnumerable<Class516> IEnumerable_5
	{
		get
		{
			Class214.Class222 @class = new Class214.Class222(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06001258 RID: 4696 RVA: 0x000A6584 File Offset: 0x000A4784
	public Class516 Class516_1
	{
		get
		{
			long num = this.Class106_0.Class515_0.method_9(new long[]
			{
				this.Class106_0.Class502_0.Int64_38[0],
				this.Class106_0.Class502_0.Int64_38[1]
			});
			long num2 = this.Class106_0.Class515_0.method_9(new long[] { num });
			if (num2 != 0L)
			{
				return new Class516(this.Class106_0, num2, false);
			}
			return null;
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06001259 RID: 4697 RVA: 0x0000DD05 File Offset: 0x0000BF05
	public IEnumerable<Class516> IEnumerable_6
	{
		get
		{
			Class214.Class224 @class = new Class214.Class224(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x0600125A RID: 4698 RVA: 0x0000DD15 File Offset: 0x0000BF15
	public IEnumerable<Class516> IEnumerable_7
	{
		get
		{
			Class214.Class225 @class = new Class214.Class225(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x0600125B RID: 4699 RVA: 0x0000DD25 File Offset: 0x0000BF25
	public IEnumerable<Class516> IEnumerable_8
	{
		get
		{
			Class214.Class223 @class = new Class214.Class223(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x0600125C RID: 4700 RVA: 0x0000DD35 File Offset: 0x0000BF35
	public IEnumerable<Class516> IEnumerable_9
	{
		get
		{
			Class214.Class221 @class = new Class214.Class221(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x0600125D RID: 4701 RVA: 0x0000DD45 File Offset: 0x0000BF45
	public IEnumerable<Class516> IEnumerable_10
	{
		get
		{
			Class214.Class216 @class = new Class214.Class216(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x0600125E RID: 4702 RVA: 0x0000DD55 File Offset: 0x0000BF55
	public IEnumerable<Class516> IEnumerable_11
	{
		get
		{
			Class214.Class218 @class = new Class214.Class218(-2);
			@class.class214_0 = this;
			return @class;
		}
	}

	// Token: 0x04000AC2 RID: 2754
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x04000AC3 RID: 2755
	private Dictionary<long, int> dictionary_0 = new Dictionary<long, int>();

	// Token: 0x04000AC4 RID: 2756
	private static Stopwatch stopwatch_0 = Stopwatch.StartNew();

	// Token: 0x02000142 RID: 322
	[CompilerGenerated]
	private sealed class Class215 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001260 RID: 4704 RVA: 0x0000DD71 File Offset: 0x0000BF71
		[DebuggerHidden]
		public Class215(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0000DD8B File Offset: 0x0000BF8B
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000A6600 File Offset: 0x000A4800
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_29);
				this.int_2 = 0;
				goto IL_00A2;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0092:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00A2:
			if (this.int_2 >= 220)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_0092;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0000DD95 File Offset: 0x0000BF95
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0000DD95 File Offset: 0x0000BF95
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000A66DC File Offset: 0x000A48DC
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class215 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class215(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0000DD9D File Offset: 0x0000BF9D
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AC5 RID: 2757
		private int int_0;

		// Token: 0x04000AC6 RID: 2758
		private Class516 class516_0;

		// Token: 0x04000AC7 RID: 2759
		private int int_1;

		// Token: 0x04000AC8 RID: 2760
		public Class214 class214_0;

		// Token: 0x04000AC9 RID: 2761
		private long long_0;

		// Token: 0x04000ACA RID: 2762
		private int int_2;
	}

	// Token: 0x02000143 RID: 323
	[CompilerGenerated]
	private sealed class Class216 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x0000DDA5 File Offset: 0x0000BFA5
		[DebuggerHidden]
		public Class216(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0000DDBF File Offset: 0x0000BFBF
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000A6720 File Offset: 0x000A4920
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_30);
				this.int_2 = 0;
				goto IL_00A2;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0092:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00A2:
			if (this.int_2 >= 140)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_0092;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000A67FC File Offset: 0x000A49FC
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class216 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class216(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000DDD1 File Offset: 0x0000BFD1
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000ACB RID: 2763
		private int int_0;

		// Token: 0x04000ACC RID: 2764
		private Class516 class516_0;

		// Token: 0x04000ACD RID: 2765
		private int int_1;

		// Token: 0x04000ACE RID: 2766
		public Class214 class214_0;

		// Token: 0x04000ACF RID: 2767
		private long long_0;

		// Token: 0x04000AD0 RID: 2768
		private int int_2;
	}

	// Token: 0x02000144 RID: 324
	[CompilerGenerated]
	private sealed class Class217 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x0000DDD9 File Offset: 0x0000BFD9
		[DebuggerHidden]
		public Class217(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000DDF3 File Offset: 0x0000BFF3
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000A6840 File Offset: 0x000A4A40
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_29);
				this.int_2 = 0;
				goto IL_00A2;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0092:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00A2:
			if (this.int_2 >= @class.Class106_0.Class527_0.Int32_27)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_0092;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x0000DDFD File Offset: 0x0000BFFD
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0000DDFD File Offset: 0x0000BFFD
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000A6924 File Offset: 0x000A4B24
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class217 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class217(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000DE05 File Offset: 0x0000C005
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AD1 RID: 2769
		private int int_0;

		// Token: 0x04000AD2 RID: 2770
		private Class516 class516_0;

		// Token: 0x04000AD3 RID: 2771
		private int int_1;

		// Token: 0x04000AD4 RID: 2772
		public Class214 class214_0;

		// Token: 0x04000AD5 RID: 2773
		private long long_0;

		// Token: 0x04000AD6 RID: 2774
		private int int_2;
	}

	// Token: 0x02000145 RID: 325
	[CompilerGenerated]
	private sealed class Class218 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x0000DE0D File Offset: 0x0000C00D
		[DebuggerHidden]
		public Class218(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000DE27 File Offset: 0x0000C027
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000A6968 File Offset: 0x000A4B68
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_14(@class.Class106_0.Class502_0.Int64_35);
				this.int_2 = 0;
				goto IL_00A2;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0092:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00A2:
			if (this.int_2 >= 10)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_0092;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x0000DE31 File Offset: 0x0000C031
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x0000DE31 File Offset: 0x0000C031
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000A6A40 File Offset: 0x000A4C40
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class218 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class218(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0000DE39 File Offset: 0x0000C039
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AD7 RID: 2775
		private int int_0;

		// Token: 0x04000AD8 RID: 2776
		private Class516 class516_0;

		// Token: 0x04000AD9 RID: 2777
		private int int_1;

		// Token: 0x04000ADA RID: 2778
		public Class214 class214_0;

		// Token: 0x04000ADB RID: 2779
		private long long_0;

		// Token: 0x04000ADC RID: 2780
		private int int_2;
	}

	// Token: 0x02000146 RID: 326
	[CompilerGenerated]
	private sealed class Class219 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x0000DE41 File Offset: 0x0000C041
		[DebuggerHidden]
		public Class219(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0000DE5B File Offset: 0x0000C05B
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000A6A84 File Offset: 0x000A4C84
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_29);
				this.int_2 = @class.Class106_0.Class527_0.Int32_29;
				goto IL_00B4;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00A4:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00B4:
			if (this.int_2 >= @class.Class106_0.Class527_0.Int32_29 + @class.Class106_0.Class527_0.Int32_28)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_00A4;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0000DE65 File Offset: 0x0000C065
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0000DE65 File Offset: 0x0000C065
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000A6B8C File Offset: 0x000A4D8C
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class219 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class219(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000DE6D File Offset: 0x0000C06D
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000ADD RID: 2781
		private int int_0;

		// Token: 0x04000ADE RID: 2782
		private Class516 class516_0;

		// Token: 0x04000ADF RID: 2783
		private int int_1;

		// Token: 0x04000AE0 RID: 2784
		public Class214 class214_0;

		// Token: 0x04000AE1 RID: 2785
		private long long_0;

		// Token: 0x04000AE2 RID: 2786
		private int int_2;
	}

	// Token: 0x02000147 RID: 327
	[CompilerGenerated]
	private sealed class Class220 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x0000DE75 File Offset: 0x0000C075
		[DebuggerHidden]
		public Class220(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000DE8F File Offset: 0x0000C08F
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000A6BD0 File Offset: 0x000A4DD0
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_29);
				this.int_2 = @class.Class106_0.Class527_0.Int32_29 + @class.Class106_0.Class527_0.Int32_30;
				goto IL_00C5;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00B5:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00C5:
			if (this.int_2 >= @class.Class106_0.Class527_0.Int32_29 + @class.Class106_0.Class527_0.Int32_30 + 20)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_00B5;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0000DE99 File Offset: 0x0000C099
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0000DE99 File Offset: 0x0000C099
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000A6CEC File Offset: 0x000A4EEC
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class220 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class220(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0000DEA1 File Offset: 0x0000C0A1
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AE3 RID: 2787
		private int int_0;

		// Token: 0x04000AE4 RID: 2788
		private Class516 class516_0;

		// Token: 0x04000AE5 RID: 2789
		private int int_1;

		// Token: 0x04000AE6 RID: 2790
		public Class214 class214_0;

		// Token: 0x04000AE7 RID: 2791
		private long long_0;

		// Token: 0x04000AE8 RID: 2792
		private int int_2;
	}

	// Token: 0x02000148 RID: 328
	[CompilerGenerated]
	private sealed class Class221 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001290 RID: 4752 RVA: 0x0000DEA9 File Offset: 0x0000C0A9
		[DebuggerHidden]
		public Class221(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0000DEC3 File Offset: 0x0000C0C3
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000A6D30 File Offset: 0x000A4F30
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_31);
				this.int_2 = 0;
				goto IL_00A2;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0092:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00A2:
			if (this.int_2 >= 80)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_0092;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0000DECD File Offset: 0x0000C0CD
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x0000DECD File Offset: 0x0000C0CD
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000A6E08 File Offset: 0x000A5008
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class221 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class221(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0000DED5 File Offset: 0x0000C0D5
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AE9 RID: 2793
		private int int_0;

		// Token: 0x04000AEA RID: 2794
		private Class516 class516_0;

		// Token: 0x04000AEB RID: 2795
		private int int_1;

		// Token: 0x04000AEC RID: 2796
		public Class214 class214_0;

		// Token: 0x04000AED RID: 2797
		private long long_0;

		// Token: 0x04000AEE RID: 2798
		private int int_2;
	}

	// Token: 0x02000149 RID: 329
	[CompilerGenerated]
	private sealed class Class222 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x0000DEDD File Offset: 0x0000C0DD
		[DebuggerHidden]
		public Class222(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0000DEF7 File Offset: 0x0000C0F7
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000A6E4C File Offset: 0x000A504C
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
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
				if (@class.Class106_0.Class502_0.Int32_5 != 1)
				{
					return false;
				}
				this.long_0 = @class.Class106_0.Class515_0.method_9(@class.Class106_0.Class502_0.Int64_33);
				this.int_2 = 0;
				goto IL_00BA;
			}
			IL_00AA:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00BA:
			if (this.int_2 >= 120)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_00AA;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, true);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0000DF01 File Offset: 0x0000C101
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x0000DF01 File Offset: 0x0000C101
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000A6F3C File Offset: 0x000A513C
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class222 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class222(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000DF09 File Offset: 0x0000C109
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AEF RID: 2799
		private int int_0;

		// Token: 0x04000AF0 RID: 2800
		private Class516 class516_0;

		// Token: 0x04000AF1 RID: 2801
		private int int_1;

		// Token: 0x04000AF2 RID: 2802
		public Class214 class214_0;

		// Token: 0x04000AF3 RID: 2803
		private long long_0;

		// Token: 0x04000AF4 RID: 2804
		private int int_2;
	}

	// Token: 0x0200014A RID: 330
	[CompilerGenerated]
	private sealed class Class223 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x060012A0 RID: 4768 RVA: 0x0000DF11 File Offset: 0x0000C111
		[DebuggerHidden]
		public Class223(int int_4)
		{
			this.int_0 = int_4;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000DF2B File Offset: 0x0000C12B
		[DebuggerHidden]
		public void Dispose()
		{
			this.list_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000A6F80 File Offset: 0x000A5180
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.list_0 = new List<int>();
				this.int_2 = 0;
				goto IL_0113;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00E2:
			int num2 = this.int_3;
			this.int_3 = num2 + 1;
			IL_00F4:
			if (this.int_3 >= 20)
			{
				num2 = this.int_2;
				this.int_2 = num2 + 1;
			}
			else
			{
				int num3 = @class.Class106_0.Class515_0.method_7(new long[]
				{
					@class.Class106_0.Int64_0 + 10858864L,
					124880L,
					(long)(28 * this.int_2 + 4),
					(long)(16 * this.int_3)
				});
				if (num3 == 0 || this.list_0.Contains(num3))
				{
					goto IL_00E2;
				}
				this.list_0.Add(num3);
				Class516 class2 = new Class516(@class.Class106_0, (long)num3, false);
				if (!(class2.String_1 != string.Empty))
				{
					goto IL_00E2;
				}
				this.class516_0 = class2;
				this.int_0 = 1;
				return true;
			}
			IL_0113:
			if (this.int_2 >= 10)
			{
				return false;
			}
			this.int_3 = 0;
			goto IL_00F4;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0000DF3C File Offset: 0x0000C13C
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0000DF3C File Offset: 0x0000C13C
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000A70C0 File Offset: 0x000A52C0
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class223 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class223(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000DF44 File Offset: 0x0000C144
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AF5 RID: 2805
		private int int_0;

		// Token: 0x04000AF6 RID: 2806
		private Class516 class516_0;

		// Token: 0x04000AF7 RID: 2807
		private int int_1;

		// Token: 0x04000AF8 RID: 2808
		public Class214 class214_0;

		// Token: 0x04000AF9 RID: 2809
		private List<int> list_0;

		// Token: 0x04000AFA RID: 2810
		private int int_2;

		// Token: 0x04000AFB RID: 2811
		private int int_3;
	}

	// Token: 0x0200014B RID: 331
	[CompilerGenerated]
	private sealed class Class224 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x0000DF4C File Offset: 0x0000C14C
		[DebuggerHidden]
		public Class224(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0000DF66 File Offset: 0x0000C166
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000A7104 File Offset: 0x000A5304
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(new long[]
				{
					@class.Class106_0.Class502_0.Int64_38[0],
					@class.Class106_0.Class502_0.Int64_38[1]
				});
				this.int_2 = 0;
				goto IL_00C5;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00B5:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00C5:
			if (this.int_2 >= 22)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_00B5;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x0000DF70 File Offset: 0x0000C170
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0000DF70 File Offset: 0x0000C170
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000A7200 File Offset: 0x000A5400
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class224 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class224(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0000DF78 File Offset: 0x0000C178
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AFC RID: 2812
		private int int_0;

		// Token: 0x04000AFD RID: 2813
		private Class516 class516_0;

		// Token: 0x04000AFE RID: 2814
		private int int_1;

		// Token: 0x04000AFF RID: 2815
		public Class214 class214_0;

		// Token: 0x04000B00 RID: 2816
		private long long_0;

		// Token: 0x04000B01 RID: 2817
		private int int_2;
	}

	// Token: 0x0200014C RID: 332
	[CompilerGenerated]
	private sealed class Class225 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class516>, IEnumerator<Class516>
	{
		// Token: 0x060012B0 RID: 4784 RVA: 0x0000DF80 File Offset: 0x0000C180
		[DebuggerHidden]
		public Class225(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0000DF9A File Offset: 0x0000C19A
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000A7244 File Offset: 0x000A5444
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class214 @class = this.class214_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = @class.Class106_0.Class515_0.method_9(new long[]
				{
					@class.Class106_0.Class502_0.Int64_2[0],
					117076L
				});
				this.int_2 = 36;
				goto IL_00BD;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00AD:
			int num2 = this.int_2;
			this.int_2 = num2 + 1;
			IL_00BD:
			if (this.int_2 >= 66)
			{
				return false;
			}
			long num3 = @class.Class106_0.Class515_0.method_9(new long[] { this.long_0 + (long)(this.int_2 * @class.Class106_0.Class515_0.Int32_1) });
			if (num3 == 0L)
			{
				goto IL_00AD;
			}
			this.class516_0 = new Class516(@class.Class106_0, num3, false);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		public Class516 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class516_0;
			}
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000A7338 File Offset: 0x000A5538
		[DebuggerHidden]
		public IEnumerator<Class516> GetEnumerator()
		{
			Class214.Class225 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class214.Class225(0);
				@class.class214_0 = this.class214_0;
			}
			return @class;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000B02 RID: 2818
		private int int_0;

		// Token: 0x04000B03 RID: 2819
		private Class516 class516_0;

		// Token: 0x04000B04 RID: 2820
		private int int_1;

		// Token: 0x04000B05 RID: 2821
		public Class214 class214_0;

		// Token: 0x04000B06 RID: 2822
		private long long_0;

		// Token: 0x04000B07 RID: 2823
		private int int_2;
	}
}
