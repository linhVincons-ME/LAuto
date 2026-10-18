using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
[Serializable]
internal class Class301 : Class300
{
	// Token: 0x06000060 RID: 96 RVA: 0x000035BB File Offset: 0x000017BB
	public Class301(string string_0)
		: this(File.ReadAllBytes(string_0))
	{
		this.String_0 = string_0;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0001E200 File Offset: 0x0001C400
	public Class301(byte[] byte_0)
		: base(byte_0)
	{
		string text = string.Empty;
		GStruct7 gstruct = default(GStruct7);
		GStruct4 gstruct2 = default(GStruct4);
		if (base.method_1<GStruct4>(out gstruct2) && gstruct2.e_magic == 23117)
		{
			if (base.method_3<GStruct7>((long)((ulong)gstruct2.e_lfanew), SeekOrigin.Begin, out gstruct) && (long)gstruct.Signature == 17744L)
			{
				if (gstruct.OptionalHeader.Magic == 267)
				{
					if (gstruct.OptionalHeader.DataDirectory[14].Size > 0U)
					{
						text = "Image contains a CLR runtime header. Currently only native binaries are supported; no .NET dependent libraries.";
					}
				}
				else
				{
					text = "File is of the PE32+ format. Currently support only extends to PE32 images. Either recompile the binary as x86, or choose a different target.";
				}
			}
			else
			{
				text = "Invalid NT header found in image.";
			}
		}
		else
		{
			text = "Invalid DOS Header found in image";
		}
		if (!string.IsNullOrEmpty(text))
		{
			base.Dispose();
			throw new ArgumentException(text);
		}
		this.GStruct7_0 = gstruct;
		this.GStruct4_0 = gstruct2;
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000062 RID: 98 RVA: 0x000035D0 File Offset: 0x000017D0
	// (set) Token: 0x06000063 RID: 99 RVA: 0x000035D8 File Offset: 0x000017D8
	public GStruct4 GStruct4_0 { get; private set; }

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000064 RID: 100 RVA: 0x000035E1 File Offset: 0x000017E1
	// (set) Token: 0x06000065 RID: 101 RVA: 0x000035E9 File Offset: 0x000017E9
	public string String_0 { get; private set; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000066 RID: 102 RVA: 0x000035F2 File Offset: 0x000017F2
	// (set) Token: 0x06000067 RID: 103 RVA: 0x000035FA File Offset: 0x000017FA
	public GStruct7 GStruct7_0 { get; private set; }

	// Token: 0x06000068 RID: 104 RVA: 0x00003603 File Offset: 0x00001803
	public IEnumerable<GStruct6> method_8()
	{
		Class301.Class1 @class = new Class301.Class1(-2);
		@class.class301_0 = this;
		return @class;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003613 File Offset: 0x00001813
	public IEnumerable<GStruct12> method_9()
	{
		Class301.Class2 @class = new Class301.Class2(-2);
		@class.class301_0 = this;
		return @class;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0001E2D4 File Offset: 0x0001C4D4
	private GStruct12 method_10(uint uint_0)
	{
		foreach (GStruct12 gstruct in this.method_9())
		{
			if (uint_0 >= gstruct.VirtualAddress && uint_0 < gstruct.VirtualAddress + ((gstruct.VirtualSize > 0U) ? gstruct.VirtualSize : gstruct.SizeOfRawData))
			{
				return gstruct;
			}
		}
		throw new EntryPointNotFoundException("RVA does not exist within any of the current sections.");
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0001E358 File Offset: 0x0001C558
	public uint method_11(uint uint_0)
	{
		GStruct12 gstruct = this.method_10(uint_0);
		return uint_0 - (gstruct.VirtualAddress - gstruct.PointerToRawData);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003623 File Offset: 0x00001823
	public byte[] method_12()
	{
		return base.method_0();
	}

	// Token: 0x0400004A RID: 74
	[CompilerGenerated]
	private GStruct4 f_2793B34C;

	// Token: 0x0400004B RID: 75
	[CompilerGenerated]
	private string f_B02EE4F7;

	// Token: 0x0400004C RID: 76
	[CompilerGenerated]
	private GStruct7 f_BEB07444;

	// Token: 0x0200000D RID: 13
	[CompilerGenerated]
	private sealed class Class1 : IEnumerable<GStruct6>, IEnumerator<GStruct6>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000362B File Offset: 0x0000182B
		[DebuggerHidden]
		public Class1(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003645 File Offset: 0x00001845
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0001E37C File Offset: 0x0001C57C
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class301 @class = this.class301_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.uint_0 += this.uint_1;
			}
			else
			{
				this.int_0 = -1;
				GStruct3 gstruct = @class.GStruct7_0.OptionalHeader.DataDirectory[1];
				if (gstruct.Size <= 0U)
				{
					return false;
				}
				this.uint_0 = @class.method_11(gstruct.VirtualAddress);
				this.uint_1 = typeof(GStruct6).smethod_1();
			}
			GStruct6 gstruct2;
			if (@class.method_3<GStruct6>((long)((ulong)this.uint_0), SeekOrigin.Begin, out gstruct2) && gstruct2.OriginalFirstThunk > 0U && gstruct2.Name > 0U)
			{
				this.gstruct6_0 = gstruct2;
				this.int_0 = 1;
				return true;
			}
			return false;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000364F File Offset: 0x0000184F
		public GStruct6 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct6_0;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000365E File Offset: 0x0000185E
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct6_0;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0001E440 File Offset: 0x0001C640
		[DebuggerHidden]
		public IEnumerator<GStruct6> GetEnumerator()
		{
			Class301.Class1 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class301.Class1(0);
				@class.class301_0 = this.class301_0;
			}
			return @class;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000366B File Offset: 0x0000186B
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400004D RID: 77
		private int int_0;

		// Token: 0x0400004E RID: 78
		private GStruct6 gstruct6_0;

		// Token: 0x0400004F RID: 79
		private int int_1;

		// Token: 0x04000050 RID: 80
		public Class301 class301_0;

		// Token: 0x04000051 RID: 81
		private uint uint_0;

		// Token: 0x04000052 RID: 82
		private uint uint_1;
	}

	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	private sealed class Class2 : IEnumerable<GStruct12>, IEnumerator<GStruct12>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00003673 File Offset: 0x00001873
		[DebuggerHidden]
		public Class2(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000368D File Offset: 0x0000188D
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0001E484 File Offset: 0x0001C684
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class301 @class = this.class301_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.uint_0 = (uint)@class.GStruct7_0.FileHeader.NumberOfSections;
				this.long_0 = (long)((ulong)((uint)@class.GStruct7_0.FileHeader.SizeOfOptionalHeader + typeof(GStruct5).smethod_1() + 4U + @class.GStruct4_0.e_lfanew));
				this.uint_1 = typeof(GStruct12).smethod_1();
				this.uint_2 = 0U;
				goto IL_00C3;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_00B3:
			uint num2 = this.uint_2;
			this.uint_2 = num2 + 1U;
			IL_00C3:
			if (this.uint_2 >= this.uint_0)
			{
				return false;
			}
			GStruct12 gstruct;
			if (!@class.method_3<GStruct12>(this.long_0 + (long)((ulong)(this.uint_2 * this.uint_1)), SeekOrigin.Begin, out gstruct))
			{
				goto IL_00B3;
			}
			this.gstruct12_0 = gstruct;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003697 File Offset: 0x00001897
		public GStruct12 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct12_0;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000369F File Offset: 0x0000189F
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gstruct12_0;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0001E574 File Offset: 0x0001C774
		[DebuggerHidden]
		public IEnumerator<GStruct12> GetEnumerator()
		{
			Class301.Class2 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class301.Class2(0);
				@class.class301_0 = this.class301_0;
			}
			return @class;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000036AC File Offset: 0x000018AC
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000053 RID: 83
		private int int_0;

		// Token: 0x04000054 RID: 84
		private GStruct12 gstruct12_0;

		// Token: 0x04000055 RID: 85
		private int int_1;

		// Token: 0x04000056 RID: 86
		public Class301 class301_0;

		// Token: 0x04000057 RID: 87
		private uint uint_0;

		// Token: 0x04000058 RID: 88
		private long long_0;

		// Token: 0x04000059 RID: 89
		private uint uint_1;

		// Token: 0x0400005A RID: 90
		private uint uint_2;
	}
}
