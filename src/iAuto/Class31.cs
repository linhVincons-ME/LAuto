using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200003B RID: 59
internal class Class31 : IEnumerable<byte>, IEnumerable
{
	// Token: 0x06000235 RID: 565 RVA: 0x00003AEB File Offset: 0x00001CEB
	private Class31()
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x000047A9 File Offset: 0x000029A9
	internal Class31(Enum2 enum2_1, Class19 class19_1, bool bool_0)
		: this(Enum0.Final, enum2_1, class19_1, false, bool_0)
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000047B6 File Offset: 0x000029B6
	internal Class31(Enum0 enum0_1, Enum2 enum2_1, byte[] byte_4, bool bool_0, bool bool_1)
		: this(enum0_1, enum2_1, new Class19(byte_4), bool_0, bool_1)
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00024EC4 File Offset: 0x000230C4
	internal Class31(Enum0 enum0_1, Enum2 enum2_1, Class19 class19_1, bool bool_0, bool bool_1)
	{
		this.enum0_0 = enum0_1;
		this.enum3_0 = ((enum2_1.smethod_41() && bool_0) ? Enum3.On : Enum3.Off);
		this.enum3_1 = Enum3.Off;
		this.enum3_2 = Enum3.Off;
		this.enum2_0 = enum2_1;
		ulong uint64_ = class19_1.UInt64_0;
		if (uint64_ < 126UL)
		{
			this.byte_2 = (byte)uint64_;
			this.byte_0 = GClass7.byte_0;
		}
		else if (uint64_ < 65536UL)
		{
			this.byte_2 = 126;
			this.byte_0 = ((ushort)uint64_).smethod_35(GEnum1.Big);
		}
		else
		{
			this.byte_2 = 127;
			this.byte_0 = uint64_.smethod_36(GEnum1.Big);
		}
		if (bool_1)
		{
			this.enum1_0 = Enum1.On;
			this.byte_1 = Class31.smethod_0();
			class19_1.method_0(this.byte_1);
		}
		else
		{
			this.enum1_0 = Enum1.Off;
			this.byte_1 = GClass7.byte_0;
		}
		this.class19_0 = class19_1;
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000239 RID: 569 RVA: 0x000047CA File Offset: 0x000029CA
	internal int Int32_0
	{
		get
		{
			if (this.byte_2 < 126)
			{
				return 0;
			}
			if (this.byte_2 != 126)
			{
				return 8;
			}
			return 2;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600023A RID: 570 RVA: 0x000047E5 File Offset: 0x000029E5
	internal ulong UInt64_0
	{
		get
		{
			if (this.byte_2 < 126)
			{
				return (ulong)this.byte_2;
			}
			if (this.byte_2 != 126)
			{
				return this.byte_0.smethod_64(GEnum1.Big);
			}
			return (ulong)this.byte_0.smethod_63(GEnum1.Big);
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600023B RID: 571 RVA: 0x0000481D File Offset: 0x00002A1D
	public byte[] Byte_0
	{
		get
		{
			return this.byte_0;
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600023C RID: 572 RVA: 0x00004825 File Offset: 0x00002A25
	public Enum0 Enum0_0
	{
		get
		{
			return this.enum0_0;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x0600023D RID: 573 RVA: 0x0000482D File Offset: 0x00002A2D
	public bool Boolean_0
	{
		get
		{
			return this.enum2_0 == Enum2.Binary;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600023E RID: 574 RVA: 0x00004838 File Offset: 0x00002A38
	public bool Boolean_1
	{
		get
		{
			return this.enum2_0 == Enum2.Close;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600023F RID: 575 RVA: 0x00004843 File Offset: 0x00002A43
	public bool Boolean_2
	{
		get
		{
			return this.enum3_0 == Enum3.On;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000240 RID: 576 RVA: 0x0000484E File Offset: 0x00002A4E
	public bool Boolean_3
	{
		get
		{
			return this.enum2_0 == Enum2.Cont;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00004859 File Offset: 0x00002A59
	public bool Boolean_4
	{
		get
		{
			return this.enum2_0 >= Enum2.Close;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000242 RID: 578 RVA: 0x00004867 File Offset: 0x00002A67
	public bool Boolean_5
	{
		get
		{
			return this.enum2_0 == Enum2.Text || this.enum2_0 == Enum2.Binary;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000243 RID: 579 RVA: 0x0000487D File Offset: 0x00002A7D
	public bool Boolean_6
	{
		get
		{
			return this.enum0_0 == Enum0.Final;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000244 RID: 580 RVA: 0x00004888 File Offset: 0x00002A88
	public bool Boolean_7
	{
		get
		{
			return this.enum0_0 == Enum0.More || this.enum2_0 == Enum2.Cont;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000245 RID: 581 RVA: 0x0000489D File Offset: 0x00002A9D
	public bool Boolean_8
	{
		get
		{
			return this.enum1_0 == Enum1.On;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000246 RID: 582 RVA: 0x000048A8 File Offset: 0x00002AA8
	public bool Boolean_9
	{
		get
		{
			return this.enum2_0 == Enum2.Ping;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000247 RID: 583 RVA: 0x000048B4 File Offset: 0x00002AB4
	public bool Boolean_10
	{
		get
		{
			return this.enum2_0 == Enum2.Pong;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000248 RID: 584 RVA: 0x000048C0 File Offset: 0x00002AC0
	public bool Boolean_11
	{
		get
		{
			return this.enum2_0 == Enum2.Text;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000249 RID: 585 RVA: 0x000048CB File Offset: 0x00002ACB
	public ulong UInt64_1
	{
		get
		{
			return (ulong)(2L + (long)(this.byte_0.Length + this.byte_1.Length) + (long)this.class19_0.UInt64_0);
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600024A RID: 586 RVA: 0x000048F5 File Offset: 0x00002AF5
	public Enum1 Enum1_0
	{
		get
		{
			return this.enum1_0;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600024B RID: 587 RVA: 0x000048FD File Offset: 0x00002AFD
	public byte[] Byte_1
	{
		get
		{
			return this.byte_1;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600024C RID: 588 RVA: 0x00004905 File Offset: 0x00002B05
	public Enum2 Enum2_0
	{
		get
		{
			return this.enum2_0;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600024D RID: 589 RVA: 0x0000490D File Offset: 0x00002B0D
	public Class19 Class19_0
	{
		get
		{
			return this.class19_0;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600024E RID: 590 RVA: 0x00004915 File Offset: 0x00002B15
	public byte Byte_2
	{
		get
		{
			return this.byte_2;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600024F RID: 591 RVA: 0x0000491D File Offset: 0x00002B1D
	public Enum3 Enum3_0
	{
		get
		{
			return this.enum3_0;
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000250 RID: 592 RVA: 0x00004925 File Offset: 0x00002B25
	public Enum3 Enum3_1
	{
		get
		{
			return this.enum3_1;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000251 RID: 593 RVA: 0x0000492D File Offset: 0x00002B2D
	public Enum3 Enum3_2
	{
		get
		{
			return this.enum3_2;
		}
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00024FA8 File Offset: 0x000231A8
	private static byte[] smethod_0()
	{
		byte[] array = new byte[4];
		GClass7.randomNumberGenerator_0.GetBytes(array);
		return array;
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00024FC8 File Offset: 0x000231C8
	private static string smethod_1(Class31 class31_0)
	{
		Class31.Class32 @class = new Class31.Class32();
		ulong uint64_ = class31_0.UInt64_1;
		long num = (long)(uint64_ / 4UL);
		int num2 = (int)(uint64_ % 4UL);
		int num3;
		string text;
		if (num < 10000L)
		{
			num3 = 4;
			text = "{0,4}";
		}
		else if (num < 65536L)
		{
			num3 = 4;
			text = "{0,4:X}";
		}
		else if (num < 4294967296L)
		{
			num3 = 8;
			text = "{0,8:X}";
		}
		else
		{
			num3 = 16;
			text = "{0,16:X}";
		}
		string text2 = string.Format("{{0,{0}}}", num3);
		string text3 = string.Format("\n{0} 01234567 89ABCDEF 01234567 89ABCDEF\n{0}+--------+--------+--------+--------+\\n", text2);
		@class.string_0 = string.Format("{0}|{{1,8}} {{2,8}} {{3,8}} {{4,8}}|\n", text);
		string text4 = string.Format("{0}+--------+--------+--------+--------+", text2);
		@class.stringBuilder_0 = new StringBuilder(64);
		Action<string, string, string, string> action = new Func<Action<string, string, string, string>>(@class.method_0)();
		@class.stringBuilder_0.AppendFormat(text3, string.Empty);
		byte[] array = class31_0.method_3();
		for (long num4 = 0L; num4 <= num; num4 += 1L)
		{
			long num5 = num4 * 4L;
			checked
			{
				if (num4 < num)
				{
					action(Convert.ToString(array[(int)((IntPtr)num5)], 2).PadLeft(8, '0'), Convert.ToString(array[(int)((IntPtr)(unchecked(num5 + 1L)))], 2).PadLeft(8, '0'), Convert.ToString(array[(int)((IntPtr)(unchecked(num5 + 2L)))], 2).PadLeft(8, '0'), Convert.ToString(array[(int)((IntPtr)(unchecked(num5 + 3L)))], 2).PadLeft(8, '0'));
				}
				else if (num2 > 0)
				{
					action(Convert.ToString(array[(int)((IntPtr)num5)], 2).PadLeft(8, '0'), (num2 >= 2) ? Convert.ToString(array[(int)((IntPtr)(unchecked(num5 + 1L)))], 2).PadLeft(8, '0') : string.Empty, (num2 == 3) ? Convert.ToString(array[(int)((IntPtr)(unchecked(num5 + 2L)))], 2).PadLeft(8, '0') : string.Empty, string.Empty);
				}
			}
		}
		@class.stringBuilder_0.AppendFormat(text4, string.Empty);
		return @class.stringBuilder_0.ToString();
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00025208 File Offset: 0x00023408
	private static string smethod_2(Class31 class31_0)
	{
		byte b = class31_0.byte_2;
		string text = ((b > 125) ? class31_0.UInt64_0.ToString() : string.Empty);
		string text2 = BitConverter.ToString(class31_0.byte_1);
		string text3 = ((b == 0) ? string.Empty : ((b > 125) ? "---" : ((!class31_0.Boolean_11 || class31_0.Boolean_7 || class31_0.Boolean_8 || class31_0.Boolean_2) ? class31_0.class19_0.ToString() : class31_0.class19_0.Byte_0.smethod_75())));
		return string.Format("\n                    FIN: {0}\n                   RSV1: {1}\n                   RSV2: {2}\n                   RSV3: {3}\n                 Opcode: {4}\n                   MASK: {5}\n         Payload Length: {6}\nExtended Payload Length: {7}\n            Masking Key: {8}\n           Payload Data: {9}", new object[] { class31_0.enum0_0, class31_0.enum3_0, class31_0.enum3_1, class31_0.enum3_2, class31_0.enum2_0, class31_0.enum1_0, b, text, text2, text3 });
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00025314 File Offset: 0x00023514
	private static Class31 smethod_3(byte[] byte_4)
	{
		if (byte_4.Length != 2)
		{
			throw new GException0("The header of a frame cannot be read from the stream.");
		}
		Enum0 @enum = (((byte_4[0] & 128) == 128) ? Enum0.Final : Enum0.More);
		Enum3 enum2 = (((byte_4[0] & 64) == 64) ? Enum3.On : Enum3.Off);
		Enum3 enum3 = (((byte_4[0] & 32) == 32) ? Enum3.On : Enum3.Off);
		Enum3 enum4 = (((byte_4[0] & 16) == 16) ? Enum3.On : Enum3.Off);
		byte b = (byte)(byte_4[0] & 15);
		Enum1 enum5 = (((byte_4[1] & 128) == 128) ? Enum1.On : Enum1.Off);
		byte b2 = (byte)(byte_4[1] & 127);
		string text;
		if (b.smethod_46())
		{
			if (!b.smethod_40())
			{
				if (enum2 == Enum3.On)
				{
					text = "A non data frame is compressed.";
					goto IL_00CB;
				}
			}
			text = ((!b.smethod_38() || @enum != Enum0.More) ? ((!b.smethod_38() || b2 <= 125) ? null : "A control frame has a long payload length.") : "A control frame is fragmented.");
		}
		else
		{
			text = "An unsupported opcode.";
		}
		IL_00CB:
		string text2 = text;
		if (text2 != null)
		{
			throw new GException0(GEnum2.ProtocolError, text2);
		}
		return new Class31
		{
			enum0_0 = @enum,
			enum3_0 = enum2,
			enum3_1 = enum3,
			enum3_2 = enum4,
			enum2_0 = (Enum2)b,
			enum1_0 = enum5,
			byte_2 = b2
		};
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00025438 File Offset: 0x00023638
	private static Class31 smethod_4(Stream stream_0, Class31 class31_0)
	{
		int int32_ = class31_0.Int32_0;
		if (int32_ == 0)
		{
			class31_0.byte_0 = GClass7.byte_0;
			return class31_0;
		}
		byte[] array = stream_0.smethod_51(int32_);
		if (array.Length != int32_)
		{
			throw new GException0("The extended payload length of a frame cannot be read from the stream.");
		}
		class31_0.byte_0 = array;
		return class31_0;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00025480 File Offset: 0x00023680
	private static void smethod_5(Stream stream_0, Class31 class31_0, Action<Class31> action_0, Action<Exception> action_1)
	{
		Class31.Class34 @class = new Class31.Class34();
		@class.class31_0 = class31_0;
		@class.action_0 = action_0;
		@class.int_0 = @class.class31_0.Int32_0;
		if (@class.int_0 == 0)
		{
			@class.class31_0.byte_0 = GClass7.byte_0;
			@class.action_0(@class.class31_0);
			return;
		}
		stream_0.smethod_53(@class.int_0, new Action<byte[]>(@class.method_0), action_1);
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00004935 File Offset: 0x00002B35
	private static Class31 smethod_6(Stream stream_0)
	{
		return Class31.smethod_3(stream_0.smethod_51(2));
	}

	// Token: 0x06000259 RID: 601 RVA: 0x000254F8 File Offset: 0x000236F8
	private static void smethod_7(Stream stream_0, Action<Class31> action_0, Action<Exception> action_1)
	{
		Class31.Class35 @class = new Class31.Class35();
		@class.action_0 = action_0;
		stream_0.smethod_53(2, new Action<byte[]>(@class.method_0), action_1);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00025528 File Offset: 0x00023728
	private static Class31 smethod_8(Stream stream_0, Class31 class31_0)
	{
		int num = (class31_0.Boolean_8 ? 4 : 0);
		if (num == 0)
		{
			class31_0.byte_1 = GClass7.byte_0;
			return class31_0;
		}
		byte[] array = stream_0.smethod_51(num);
		if (array.Length != num)
		{
			throw new GException0("The masking key of a frame cannot be read from the stream.");
		}
		class31_0.byte_1 = array;
		return class31_0;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00025574 File Offset: 0x00023774
	private static void smethod_9(Stream stream_0, Class31 class31_0, Action<Class31> action_0, Action<Exception> action_1)
	{
		Class31.Class36 @class = new Class31.Class36();
		@class.class31_0 = class31_0;
		@class.action_0 = action_0;
		@class.int_0 = (@class.class31_0.Boolean_8 ? 4 : 0);
		if (@class.int_0 == 0)
		{
			@class.class31_0.byte_1 = GClass7.byte_0;
			@class.action_0(@class.class31_0);
			return;
		}
		stream_0.smethod_53(@class.int_0, new Action<byte[]>(@class.method_0), action_1);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x000255F0 File Offset: 0x000237F0
	private static Class31 smethod_10(Stream stream_0, Class31 class31_0)
	{
		ulong uint64_ = class31_0.UInt64_0;
		if (uint64_ == 0UL)
		{
			class31_0.class19_0 = Class19.class19_0;
			return class31_0;
		}
		if (uint64_ > Class19.ulong_0)
		{
			throw new GException0(GEnum2.TooBig, "A frame has a long payload length.");
		}
		long num = (long)uint64_;
		byte[] array = ((class31_0.byte_2 < 127) ? stream_0.smethod_51((int)uint64_) : stream_0.smethod_52(num, 1024));
		if ((long)array.Length != num)
		{
			throw new GException0("The payload data of a frame cannot be read from the stream.");
		}
		class31_0.class19_0 = new Class19(array, num);
		return class31_0;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00025670 File Offset: 0x00023870
	private static void smethod_11(Stream stream_0, Class31 class31_0, Action<Class31> action_0, Action<Exception> action_1)
	{
		Class31.Class37 @class = new Class31.Class37();
		@class.class31_0 = class31_0;
		@class.action_0 = action_0;
		ulong uint64_ = @class.class31_0.UInt64_0;
		if (uint64_ == 0UL)
		{
			@class.class31_0.class19_0 = Class19.class19_0;
			@class.action_0(@class.class31_0);
			return;
		}
		if (uint64_ > Class19.ulong_0)
		{
			throw new GException0(GEnum2.TooBig, "A frame has a long payload length.");
		}
		@class.long_0 = (long)uint64_;
		Action<byte[]> action = new Action<byte[]>(@class.method_0);
		if (@class.class31_0.byte_2 < 127)
		{
			stream_0.smethod_53((int)uint64_, action, action_1);
			return;
		}
		stream_0.smethod_54(@class.long_0, 1024, action, action_1);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00004943 File Offset: 0x00002B43
	internal static Class31 smethod_12(Class19 class19_1, bool bool_0)
	{
		return new Class31(Enum0.Final, Enum2.Close, class19_1, false, bool_0);
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000494F File Offset: 0x00002B4F
	internal static Class31 smethod_13(bool bool_0)
	{
		return new Class31(Enum0.Final, Enum2.Ping, Class19.class19_0, false, bool_0);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00004960 File Offset: 0x00002B60
	internal static Class31 smethod_14(byte[] byte_4, bool bool_0)
	{
		return new Class31(Enum0.Final, Enum2.Ping, new Class19(byte_4), false, bool_0);
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00004972 File Offset: 0x00002B72
	internal static Class31 smethod_15(Class19 class19_1, bool bool_0)
	{
		return new Class31(Enum0.Final, Enum2.Pong, class19_1, false, bool_0);
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0002571C File Offset: 0x0002391C
	internal static Class31 smethod_16(Stream stream_0, bool bool_0)
	{
		Class31 @class = Class31.smethod_6(stream_0);
		Class31.smethod_4(stream_0, @class);
		Class31.smethod_8(stream_0, @class);
		Class31.smethod_10(stream_0, @class);
		if (bool_0)
		{
			@class.method_0();
		}
		return @class;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00025754 File Offset: 0x00023954
	internal static void smethod_17(Stream stream_0, bool bool_0, Action<Class31> action_0, Action<Exception> action_1)
	{
		Class31.Class38 @class = new Class31.Class38();
		@class.stream_0 = stream_0;
		@class.bool_0 = bool_0;
		@class.action_0 = action_0;
		@class.action_1 = action_1;
		Class31.smethod_7(@class.stream_0, new Action<Class31>(@class.method_0), @class.action_1);
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000497F File Offset: 0x00002B7F
	internal void method_0()
	{
		if (this.enum1_0 == Enum1.Off)
		{
			return;
		}
		this.enum1_0 = Enum1.Off;
		this.class19_0.method_0(this.byte_1);
		this.byte_1 = GClass7.byte_0;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x000049AD File Offset: 0x00002BAD
	public IEnumerator<byte> GetEnumerator()
	{
		Class31.Class39 @class = new Class31.Class39(0);
		@class.class31_0 = this;
		return @class;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x000049BC File Offset: 0x00002BBC
	public void method_1(bool bool_0)
	{
		Console.WriteLine(bool_0 ? Class31.smethod_1(this) : Class31.smethod_2(this));
	}

	// Token: 0x06000267 RID: 615 RVA: 0x000049D4 File Offset: 0x00002BD4
	public string method_2(bool bool_0)
	{
		if (!bool_0)
		{
			return Class31.smethod_2(this);
		}
		return Class31.smethod_1(this);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x000257A0 File Offset: 0x000239A0
	public byte[] method_3()
	{
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			int num = (int)this.enum0_0;
			num = (int)((byte)(num << 1) + this.enum3_0);
			num = (int)((byte)(num << 1) + this.enum3_1);
			num = (int)((byte)(num << 1) + this.enum3_2);
			num = (int)((byte)(num << 4) + this.enum2_0);
			num = (int)((byte)(num << 1) + this.enum1_0);
			num = (num << 7) + (int)this.byte_2;
			memoryStream.Write(((ushort)num).smethod_35(GEnum1.Big), 0, 2);
			if (this.byte_2 > 125)
			{
				memoryStream.Write(this.byte_0, 0, (this.byte_2 == 126) ? 2 : 8);
			}
			if (this.enum1_0 == Enum1.On)
			{
				memoryStream.Write(this.byte_1, 0, 4);
			}
			if (this.byte_2 > 0)
			{
				byte[] array = this.class19_0.method_1();
				if (this.byte_2 < 127)
				{
					memoryStream.Write(array, 0, array.Length);
				}
				else
				{
					memoryStream.smethod_77(array, 1024);
				}
			}
			memoryStream.Close();
			array2 = memoryStream.ToArray();
		}
		return array2;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x000049E6 File Offset: 0x00002BE6
	public override string ToString()
	{
		return BitConverter.ToString(this.method_3());
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000049F3 File Offset: 0x00002BF3
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x0400013B RID: 315
	private byte[] byte_0;

	// Token: 0x0400013C RID: 316
	private Enum0 enum0_0;

	// Token: 0x0400013D RID: 317
	private Enum1 enum1_0;

	// Token: 0x0400013E RID: 318
	private byte[] byte_1;

	// Token: 0x0400013F RID: 319
	private Enum2 enum2_0;

	// Token: 0x04000140 RID: 320
	private Class19 class19_0;

	// Token: 0x04000141 RID: 321
	private byte byte_2;

	// Token: 0x04000142 RID: 322
	private Enum3 enum3_0;

	// Token: 0x04000143 RID: 323
	private Enum3 enum3_1;

	// Token: 0x04000144 RID: 324
	private Enum3 enum3_2;

	// Token: 0x04000145 RID: 325
	internal static readonly byte[] byte_3 = Class31.smethod_13(false).method_3();

	// Token: 0x0200003C RID: 60
	[CompilerGenerated]
	private sealed class Class32
	{
		// Token: 0x0600026C RID: 620 RVA: 0x000049FB File Offset: 0x00002BFB
		internal Action<string, string, string, string> method_0()
		{
			return new Action<string, string, string, string>(new Class31.Class33
			{
				class32_0 = this,
				long_0 = 0L
			}.method_0);
		}

		// Token: 0x04000146 RID: 326
		public StringBuilder stringBuilder_0;

		// Token: 0x04000147 RID: 327
		public string string_0;
	}

	// Token: 0x0200003D RID: 61
	[CompilerGenerated]
	private sealed class Class33
	{
		// Token: 0x0600026E RID: 622 RVA: 0x000258AC File Offset: 0x00023AAC
		internal void method_0(string string_0, string string_1, string string_2, string string_3)
		{
			StringBuilder stringBuilder_ = this.class32_0.stringBuilder_0;
			string string_4 = this.class32_0.string_0;
			object[] array = new object[5];
			int num = 0;
			long num2 = this.long_0 + 1L;
			this.long_0 = num2;
			array[num] = num2;
			array[1] = string_0;
			array[2] = string_1;
			array[3] = string_2;
			array[4] = string_3;
			stringBuilder_.AppendFormat(string_4, array);
		}

		// Token: 0x04000148 RID: 328
		public long long_0;

		// Token: 0x04000149 RID: 329
		public Class31.Class32 class32_0;
	}

	// Token: 0x0200003E RID: 62
	[CompilerGenerated]
	private sealed class Class34
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00004A23 File Offset: 0x00002C23
		internal void method_0(byte[] byte_0)
		{
			if (byte_0.Length != this.int_0)
			{
				throw new GException0("The extended payload length of a frame cannot be read from the stream.");
			}
			this.class31_0.byte_0 = byte_0;
			this.action_0(this.class31_0);
		}

		// Token: 0x0400014A RID: 330
		public int int_0;

		// Token: 0x0400014B RID: 331
		public Class31 class31_0;

		// Token: 0x0400014C RID: 332
		public Action<Class31> action_0;
	}

	// Token: 0x0200003F RID: 63
	[CompilerGenerated]
	private sealed class Class35
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00004A58 File Offset: 0x00002C58
		internal void method_0(byte[] byte_0)
		{
			this.action_0(Class31.smethod_3(byte_0));
		}

		// Token: 0x0400014D RID: 333
		public Action<Class31> action_0;
	}

	// Token: 0x02000040 RID: 64
	[CompilerGenerated]
	private sealed class Class36
	{
		// Token: 0x06000274 RID: 628 RVA: 0x00004A6B File Offset: 0x00002C6B
		internal void method_0(byte[] byte_0)
		{
			if (byte_0.Length != this.int_0)
			{
				throw new GException0("The masking key of a frame cannot be read from the stream.");
			}
			this.class31_0.byte_1 = byte_0;
			this.action_0(this.class31_0);
		}

		// Token: 0x0400014E RID: 334
		public int int_0;

		// Token: 0x0400014F RID: 335
		public Class31 class31_0;

		// Token: 0x04000150 RID: 336
		public Action<Class31> action_0;
	}

	// Token: 0x02000041 RID: 65
	[CompilerGenerated]
	private sealed class Class37
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00004AA0 File Offset: 0x00002CA0
		internal void method_0(byte[] byte_0)
		{
			if ((long)byte_0.Length != this.long_0)
			{
				throw new GException0("The payload data of a frame cannot be read from the stream.");
			}
			this.class31_0.class19_0 = new Class19(byte_0, this.long_0);
			this.action_0(this.class31_0);
		}

		// Token: 0x04000151 RID: 337
		public long long_0;

		// Token: 0x04000152 RID: 338
		public Class31 class31_0;

		// Token: 0x04000153 RID: 339
		public Action<Class31> action_0;
	}

	// Token: 0x02000042 RID: 66
	[CompilerGenerated]
	private sealed class Class38
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00025910 File Offset: 0x00023B10
		internal void method_0(Class31 class31_0)
		{
			Stream stream = this.stream_0;
			Action<Class31> action;
			if ((action = this.action_4) == null)
			{
				action = (this.action_4 = new Action<Class31>(this.method_1));
			}
			Class31.smethod_5(stream, class31_0, action, this.action_1);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00025950 File Offset: 0x00023B50
		internal void method_1(Class31 class31_0)
		{
			Stream stream = this.stream_0;
			Action<Class31> action;
			if ((action = this.action_3) == null)
			{
				action = (this.action_3 = new Action<Class31>(this.method_2));
			}
			Class31.smethod_9(stream, class31_0, action, this.action_1);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00025990 File Offset: 0x00023B90
		internal void method_2(Class31 class31_0)
		{
			Stream stream = this.stream_0;
			Action<Class31> action;
			if ((action = this.action_2) == null)
			{
				action = (this.action_2 = new Action<Class31>(this.method_3));
			}
			Class31.smethod_11(stream, class31_0, action, this.action_1);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00004AE0 File Offset: 0x00002CE0
		internal void method_3(Class31 class31_0)
		{
			if (this.bool_0)
			{
				class31_0.method_0();
			}
			this.action_0(class31_0);
		}

		// Token: 0x04000154 RID: 340
		public Stream stream_0;

		// Token: 0x04000155 RID: 341
		public bool bool_0;

		// Token: 0x04000156 RID: 342
		public Action<Class31> action_0;

		// Token: 0x04000157 RID: 343
		public Action<Exception> action_1;

		// Token: 0x04000158 RID: 344
		public Action<Class31> action_2;

		// Token: 0x04000159 RID: 345
		public Action<Class31> action_3;

		// Token: 0x0400015A RID: 346
		public Action<Class31> action_4;
	}

	// Token: 0x02000043 RID: 67
	[CompilerGenerated]
	private sealed class Class39 : IEnumerator<byte>, IDisposable, IEnumerator
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00004AFC File Offset: 0x00002CFC
		[DebuggerHidden]
		public Class39(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00004B0B File Offset: 0x00002D0B
		[DebuggerHidden]
		public void Dispose()
		{
			this.byte_1 = null;
			this.int_0 = -2;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000259D0 File Offset: 0x00023BD0
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class31 @class = this.class31_0;
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
				this.byte_1 = @class.method_3();
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00004B1C File Offset: 0x00002D1C
		public byte Current
		{
			[DebuggerHidden]
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00004B24 File Offset: 0x00002D24
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x0400015B RID: 347
		private int int_0;

		// Token: 0x0400015C RID: 348
		private byte byte_0;

		// Token: 0x0400015D RID: 349
		public Class31 class31_0;

		// Token: 0x0400015E RID: 350
		private byte[] byte_1;

		// Token: 0x0400015F RID: 351
		private int int_1;
	}
}
