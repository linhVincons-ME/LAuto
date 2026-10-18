using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200002C RID: 44
internal class Class19 : IEnumerable<byte>, IEnumerable
{
	// Token: 0x06000165 RID: 357 RVA: 0x0000401C File Offset: 0x0000221C
	internal Class19()
	{
		this.ushort_0 = 1005;
		this.string_0 = string.Empty;
		this.byte_0 = GClass7.byte_0;
		this.bool_0 = true;
		this.bool_1 = true;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00004053 File Offset: 0x00002253
	internal Class19(byte[] byte_1)
		: this(byte_1, (long)byte_1.Length)
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000405F File Offset: 0x0000225F
	internal Class19(byte[] byte_1, long long_2)
	{
		this.byte_0 = byte_1;
		this.long_1 = long_2;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00021188 File Offset: 0x0001F388
	internal Class19(ushort ushort_1, string string_1)
	{
		this.ushort_0 = ushort_1;
		this.string_0 = string_1 ?? string.Empty;
		this.byte_0 = ushort_1.smethod_9(string_1);
		this.long_1 = (long)this.byte_0.Length;
		this.bool_0 = true;
		this.bool_1 = true;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000169 RID: 361 RVA: 0x000211DC File Offset: 0x0001F3DC
	internal ushort UInt16_0
	{
		get
		{
			if (!this.bool_0)
			{
				this.ushort_0 = ((this.long_1 > 1L) ? this.byte_0.smethod_90<byte>(0, 2).smethod_63(GEnum1.Big) : (ushort)1005);
				this.bool_0 = true;
			}
			return this.ushort_0;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600016A RID: 362 RVA: 0x00004075 File Offset: 0x00002275
	// (set) Token: 0x0600016B RID: 363 RVA: 0x0000407D File Offset: 0x0000227D
	internal long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600016C RID: 364 RVA: 0x00004086 File Offset: 0x00002286
	internal bool Boolean_0
	{
		get
		{
			return this.long_1 > 1L && this.UInt16_0.smethod_44();
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600016D RID: 365 RVA: 0x00021230 File Offset: 0x0001F430
	internal string String_0
	{
		get
		{
			if (!this.bool_1)
			{
				this.string_0 = ((this.long_1 > 2L) ? this.byte_0.smethod_91<byte>(2L, this.long_1 - 2L).smethod_75() : string.Empty);
				this.bool_1 = true;
			}
			return this.string_0;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600016E RID: 366 RVA: 0x000040A6 File Offset: 0x000022A6
	public byte[] Byte_0
	{
		get
		{
			if (this.long_0 <= 0L)
			{
				return this.byte_0;
			}
			return this.byte_0.smethod_91<byte>(this.long_0, this.long_1 - this.long_0);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600016F RID: 367 RVA: 0x000040DE File Offset: 0x000022DE
	public byte[] Byte_1
	{
		get
		{
			if (this.long_0 <= 0L)
			{
				return GClass7.byte_0;
			}
			return this.byte_0.smethod_91<byte>(0L, this.long_0);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00004111 File Offset: 0x00002311
	public ulong UInt64_0
	{
		get
		{
			return (ulong)this.long_1;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0002129C File Offset: 0x0001F49C
	internal void method_0(byte[] byte_1)
	{
		for (long num = 0L; num < this.long_1; num += 1L)
		{
			checked
			{
				this.byte_0[(int)((IntPtr)num)] = (byte)(this.byte_0[(int)((IntPtr)num)] ^ byte_1[(int)((IntPtr)(num % 4L))]);
			}
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00004119 File Offset: 0x00002319
	public IEnumerator<byte> GetEnumerator()
	{
		Class19.Class20 @class = new Class19.Class20(0);
		@class.class19_0 = this;
		return @class;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00004128 File Offset: 0x00002328
	public byte[] method_1()
	{
		return this.byte_0;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00004130 File Offset: 0x00002330
	public override string ToString()
	{
		return BitConverter.ToString(this.byte_0);
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000413D File Offset: 0x0000233D
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x040000DA RID: 218
	private ushort ushort_0;

	// Token: 0x040000DB RID: 219
	private bool bool_0;

	// Token: 0x040000DC RID: 220
	private byte[] byte_0;

	// Token: 0x040000DD RID: 221
	private long long_0;

	// Token: 0x040000DE RID: 222
	private long long_1;

	// Token: 0x040000DF RID: 223
	private string string_0;

	// Token: 0x040000E0 RID: 224
	private bool bool_1;

	// Token: 0x040000E1 RID: 225
	public static readonly Class19 class19_0 = new Class19();

	// Token: 0x040000E2 RID: 226
	public static readonly ulong ulong_0 = 9223372036854775807UL;

	// Token: 0x0200002D RID: 45
	[CompilerGenerated]
	private sealed class Class20 : IEnumerator<byte>, IDisposable, IEnumerator
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00004145 File Offset: 0x00002345
		[DebuggerHidden]
		public Class20(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004154 File Offset: 0x00002354
		[DebuggerHidden]
		public void Dispose()
		{
			this.byte_1 = null;
			this.int_0 = -2;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000212EC File Offset: 0x0001F4EC
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class19 @class = this.class19_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.int_1++;
			}
			else
			{
				this.int_0 = -1;
				this.byte_1 = @class.byte_0;
				this.int_1 = 0;
			}
			if (this.int_1 >= this.byte_1.Length)
			{
				this.byte_1 = null;
				return false;
			}
			byte b = this.byte_1[this.int_1];
			this.byte_0 = b;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00004165 File Offset: 0x00002365
		public byte Current
		{
			[DebuggerHidden]
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000416D File Offset: 0x0000236D
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x040000E3 RID: 227
		private int int_0;

		// Token: 0x040000E4 RID: 228
		private byte byte_0;

		// Token: 0x040000E5 RID: 229
		public Class19 class19_0;

		// Token: 0x040000E6 RID: 230
		private byte[] byte_1;

		// Token: 0x040000E7 RID: 231
		private int int_1;
	}
}
