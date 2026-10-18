using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x02000060 RID: 96
internal class Class56
{
	// Token: 0x060003F2 RID: 1010 RVA: 0x000059FF File Offset: 0x00003BFF
	public Class56(GClass27 gclass27_1)
	{
		this.gclass27_0 = gclass27_1;
		this.int_1 = -1;
		this.list_0 = new List<Class55>();
		this.stringBuilder_0 = new StringBuilder();
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00005A2B File Offset: 0x00003C2B
	public Class56(byte[] byte_0, int int_3, int int_4, GClass27 gclass27_1)
		: this(gclass27_1)
	{
		this.method_9(byte_0, int_3, int_4);
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00005A3E File Offset: 0x00003C3E
	internal GClass27 GClass27_0
	{
		get
		{
			return this.gclass27_0;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00005A46 File Offset: 0x00003C46
	public int Int32_0
	{
		get
		{
			return this.int_1 - this.int_0;
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00005A55 File Offset: 0x00003C55
	public bool Boolean_0
	{
		get
		{
			return this.enum6_0 != Enum6.End;
		}
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0002A9DC File Offset: 0x00028BDC
	private int method_0(byte[] byte_0, int int_3, int int_4)
	{
		int num = 0;
		int count = this.list_0.Count;
		for (int i = 0; i < count; i++)
		{
			Class55 @class = this.list_0[i];
			if (@class != null)
			{
				if (@class.Int32_0 == 0)
				{
					this.list_0[i] = null;
				}
				else
				{
					num += @class.method_0(byte_0, int_3 + num, int_4 - num);
					if (num == int_4)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0002AA40 File Offset: 0x00028C40
	private static string smethod_0(string string_0)
	{
		int num = string_0.IndexOf(';');
		if (num <= -1)
		{
			return string_0;
		}
		return string_0.Substring(0, num);
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0002AA64 File Offset: 0x00028C64
	private Enum6 method_1(byte[] byte_0, ref int int_3, int int_4)
	{
		int num;
		if (!this.bool_1)
		{
			num = int_3;
			int_3 = num + 1;
			if (byte_0[num] != 13)
			{
				Class56.smethod_1("CR is expected.");
			}
			this.bool_1 = true;
			if (int_3 == int_4)
			{
				return Enum6.DataEnded;
			}
		}
		num = int_3;
		int_3 = num + 1;
		if (byte_0[num] != 10)
		{
			Class56.smethod_1("LF is expected.");
		}
		return Enum6.None;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x0002AABC File Offset: 0x00028CBC
	private Enum6 method_2(byte[] byte_0, ref int int_3, int int_4)
	{
		byte b = 0;
		while (int_3 < int_4)
		{
			int num = int_3;
			int_3 = num + 1;
			b = byte_0[num];
			if (this.bool_1)
			{
				if (b != 10)
				{
					Class56.smethod_1("LF is expected.");
				}
				IL_0085:
				if (this.bool_1)
				{
					if (b == 10)
					{
						this.int_0 = 0;
						try
						{
							this.int_1 = int.Parse(Class56.smethod_0(this.stringBuilder_0.ToString()), NumberStyles.HexNumber);
						}
						catch
						{
							Class56.smethod_1("The chunk size cannot be parsed.");
						}
						if (this.int_1 == 0)
						{
							this.int_2 = 2;
							return Enum6.Trailer;
						}
						return Enum6.Data;
					}
				}
				return Enum6.None;
			}
			if (b == 13)
			{
				this.bool_1 = true;
			}
			else
			{
				if (b == 10)
				{
					Class56.smethod_1("LF is unexpected.");
				}
				if (b == 32)
				{
					this.bool_0 = true;
				}
				if (!this.bool_0)
				{
					this.stringBuilder_0.Append((char)b);
				}
				if (this.stringBuilder_0.Length > 20)
				{
					Class56.smethod_1("The chunk size is too long.");
				}
			}
		}
		{
			if (this.bool_1)
			{
				if (b == 10)
				{
					this.int_0 = 0;
					try
					{
						this.int_1 = int.Parse(Class56.smethod_0(this.stringBuilder_0.ToString()), NumberStyles.HexNumber);
					}
					catch
					{
						Class56.smethod_1("The chunk size cannot be parsed.");
					}
					if (this.int_1 == 0)
					{
						this.int_2 = 2;
						return Enum6.Trailer;
					}
					return Enum6.Data;
				}
			}
			return Enum6.None;
		}
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x0002ABB8 File Offset: 0x00028DB8
	private Enum6 method_3(byte[] byte_0, ref int int_3, int int_4)
	{
		if (this.int_2 == 2 && byte_0[int_3] == 13 && this.stringBuilder_0.Length == 0)
		{
			int_3++;
			if (int_3 < int_4 && byte_0[int_3] == 10)
			{
				int_3++;
				return Enum6.End;
			}
			int_3--;
		}
		while (int_3 < int_4 && this.int_2 < 4)
		{
			int num = int_3;
			int_3 = num + 1;
			byte b = byte_0[num];
			this.stringBuilder_0.Append((char)b);
			if (this.stringBuilder_0.Length > 4196)
			{
				Class56.smethod_1("The trailer is too long.");
			}
			if (this.int_2 != 1)
			{
				if (this.int_2 != 3)
				{
					if (b == 13)
					{
						this.int_2++;
						continue;
					}
					if (b == 10)
					{
						Class56.smethod_1("LF is unexpected.");
					}
					this.int_2 = 0;
					continue;
				}
			}
			if (b != 10)
			{
				Class56.smethod_1("LF is expected.");
			}
			this.int_2++;
		}
		if (this.int_2 < 4)
		{
			return Enum6.Trailer;
		}
		this.stringBuilder_0.Length -= 2;
		StringReader stringReader = new StringReader(this.stringBuilder_0.ToString());
		string text;
		while ((text = stringReader.ReadLine()) != null && text.Length > 0)
		{
			this.gclass27_0.method_15(text);
		}
		return Enum6.End;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00005A63 File Offset: 0x00003C63
	private static void smethod_1(string string_0)
	{
		throw new WebException(string_0, null, WebExceptionStatus.ServerProtocolViolation, null);
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0002AD0C File Offset: 0x00028F0C
	private void method_4(byte[] byte_0, ref int int_3, int int_4)
	{
		if (this.enum6_0 == Enum6.End)
		{
			Class56.smethod_1("The chunks were ended.");
		}
		if (this.enum6_0 == Enum6.None)
		{
			this.enum6_0 = this.method_2(byte_0, ref int_3, int_4);
			if (this.enum6_0 == Enum6.None)
			{
				return;
			}
			this.stringBuilder_0.Length = 0;
			this.bool_1 = false;
			this.bool_0 = false;
		}
		if (this.enum6_0 == Enum6.Data && int_3 < int_4)
		{
			this.enum6_0 = this.method_5(byte_0, ref int_3, int_4);
			if (this.enum6_0 == Enum6.Data)
			{
				return;
			}
		}
		if (this.enum6_0 == Enum6.DataEnded && int_3 < int_4)
		{
			this.enum6_0 = this.method_1(byte_0, ref int_3, int_4);
			if (this.enum6_0 == Enum6.DataEnded)
			{
				return;
			}
			this.bool_1 = false;
		}
		if (this.enum6_0 == Enum6.Trailer && int_3 < int_4)
		{
			this.enum6_0 = this.method_3(byte_0, ref int_3, int_4);
			if (this.enum6_0 == Enum6.Trailer)
			{
				return;
			}
			this.stringBuilder_0.Length = 0;
		}
		if (int_3 < int_4)
		{
			this.method_4(byte_0, ref int_3, int_4);
		}
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0002ADFC File Offset: 0x00028FFC
	private Enum6 method_5(byte[] byte_0, ref int int_3, int int_4)
	{
		int num = int_4 - int_3;
		int num2 = this.int_1 - this.int_0;
		if (num > num2)
		{
			num = num2;
		}
		byte[] array = new byte[num];
		Buffer.BlockCopy(byte_0, int_3, array, 0, num);
		this.list_0.Add(new Class55(array));
		int_3 += num;
		this.int_0 += num;
		if (this.int_0 != this.int_1)
		{
			return Enum6.Data;
		}
		return Enum6.DataEnded;
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00005A6F File Offset: 0x00003C6F
	internal void method_6()
	{
		this.int_0 = 0;
		this.int_1 = -1;
		this.list_0.Clear();
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00005A8A File Offset: 0x00003C8A
	internal int method_7(byte[] byte_0, int int_3, int int_4, int int_5)
	{
		this.method_9(byte_0, int_3, int_4);
		return this.method_8(byte_0, int_3, int_5);
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00005A9F File Offset: 0x00003C9F
	public int method_8(byte[] byte_0, int int_3, int int_4)
	{
		if (int_4 <= 0)
		{
			return 0;
		}
		return this.method_0(byte_0, int_3, int_4);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00005AB0 File Offset: 0x00003CB0
	public void method_9(byte[] byte_0, int int_3, int int_4)
	{
		if (int_4 <= 0)
		{
			return;
		}
		this.method_4(byte_0, ref int_3, int_3 + int_4);
	}

	// Token: 0x040001E3 RID: 483
	private int int_0;

	// Token: 0x040001E4 RID: 484
	private int int_1;

	// Token: 0x040001E5 RID: 485
	private List<Class55> list_0;

	// Token: 0x040001E6 RID: 486
	private bool bool_0;

	// Token: 0x040001E7 RID: 487
	private GClass27 gclass27_0;

	// Token: 0x040001E8 RID: 488
	private StringBuilder stringBuilder_0;

	// Token: 0x040001E9 RID: 489
	private bool bool_1;

	// Token: 0x040001EA RID: 490
	private Enum6 enum6_0;

	// Token: 0x040001EB RID: 491
	private int int_2;
}
