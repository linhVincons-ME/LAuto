using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000063 RID: 99
[Serializable]
public sealed class GClass15
{
	// Token: 0x06000415 RID: 1045 RVA: 0x0002AED8 File Offset: 0x000290D8
	public GClass15()
	{
		this._comment = string.Empty;
		this._domain = string.Empty;
		this._expires = DateTime.MinValue;
		this._name = string.Empty;
		this._path = string.Empty;
		this._port = string.Empty;
		this._ports = new int[0];
		this._timestamp = DateTime.Now;
		this._value = string.Empty;
		this._version = 0;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00005BDB File Offset: 0x00003DDB
	public GClass15(string string_0, string string_1)
		: this()
	{
		this.String_2 = string_0;
		this.String_5 = string_1;
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00005BF1 File Offset: 0x00003DF1
	public GClass15(string string_0, string string_1, string string_2)
		: this(string_0, string_1)
	{
		this.String_3 = string_2;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00005C02 File Offset: 0x00003E02
	public GClass15(string string_0, string string_1, string string_2, string string_3)
		: this(string_0, string_1, string_2)
	{
		this.String_1 = string_3;
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000419 RID: 1049 RVA: 0x00005C15 File Offset: 0x00003E15
	// (set) Token: 0x0600041A RID: 1050 RVA: 0x00005C1D File Offset: 0x00003E1D
	internal bool Boolean_0 { get; set; }

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600041B RID: 1051 RVA: 0x0002AF58 File Offset: 0x00029158
	internal int Int32_0
	{
		get
		{
			if (this._expires == DateTime.MinValue)
			{
				return 0;
			}
			TimeSpan timeSpan = ((this._expires.Kind != DateTimeKind.Local) ? this._expires.ToLocalTime() : this._expires) - DateTime.Now;
			if (!(timeSpan > TimeSpan.Zero))
			{
				return 0;
			}
			return (int)timeSpan.TotalSeconds;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00005C26 File Offset: 0x00003E26
	internal int[] Int32_1
	{
		get
		{
			return this._ports;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x00005C2E File Offset: 0x00003E2E
	// (set) Token: 0x0600041E RID: 1054 RVA: 0x00005C36 File Offset: 0x00003E36
	public string String_0
	{
		get
		{
			return this._comment;
		}
		set
		{
			this._comment = value ?? string.Empty;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600041F RID: 1055 RVA: 0x00005C48 File Offset: 0x00003E48
	// (set) Token: 0x06000420 RID: 1056 RVA: 0x00005C50 File Offset: 0x00003E50
	public Uri Uri_0
	{
		get
		{
			return this._commentUri;
		}
		set
		{
			this._commentUri = value;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000421 RID: 1057 RVA: 0x00005C59 File Offset: 0x00003E59
	// (set) Token: 0x06000422 RID: 1058 RVA: 0x00005C61 File Offset: 0x00003E61
	public bool Boolean_1
	{
		get
		{
			return this._discard;
		}
		set
		{
			this._discard = value;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000423 RID: 1059 RVA: 0x00005C6A File Offset: 0x00003E6A
	// (set) Token: 0x06000424 RID: 1060 RVA: 0x00005C72 File Offset: 0x00003E72
	public string String_1
	{
		get
		{
			return this._domain;
		}
		set
		{
			if (value.smethod_87())
			{
				this._domain = string.Empty;
				this.Boolean_0 = true;
				return;
			}
			this._domain = value;
			this.Boolean_0 = value[0] != '.';
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000425 RID: 1061 RVA: 0x00005CAA File Offset: 0x00003EAA
	// (set) Token: 0x06000426 RID: 1062 RVA: 0x00005CD0 File Offset: 0x00003ED0
	public bool Boolean_2
	{
		get
		{
			return this._expires != DateTime.MinValue && this._expires <= DateTime.Now;
		}
		set
		{
			this._expires = (value ? DateTime.Now : DateTime.MinValue);
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000427 RID: 1063 RVA: 0x00005CE7 File Offset: 0x00003EE7
	// (set) Token: 0x06000428 RID: 1064 RVA: 0x00005CEF File Offset: 0x00003EEF
	public DateTime DateTime_0
	{
		get
		{
			return this._expires;
		}
		set
		{
			this._expires = value;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000429 RID: 1065 RVA: 0x00005CF8 File Offset: 0x00003EF8
	// (set) Token: 0x0600042A RID: 1066 RVA: 0x00005D00 File Offset: 0x00003F00
	public bool Boolean_3
	{
		get
		{
			return this._httpOnly;
		}
		set
		{
			this._httpOnly = value;
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x0600042B RID: 1067 RVA: 0x00005D09 File Offset: 0x00003F09
	// (set) Token: 0x0600042C RID: 1068 RVA: 0x0002AFBC File Offset: 0x000291BC
	public string String_2
	{
		get
		{
			return this._name;
		}
		set
		{
			string text;
			if (!GClass15.smethod_0(value, out text))
			{
				throw new GException1(text);
			}
			this._name = value;
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x0600042D RID: 1069 RVA: 0x00005D11 File Offset: 0x00003F11
	// (set) Token: 0x0600042E RID: 1070 RVA: 0x00005D19 File Offset: 0x00003F19
	public string String_3
	{
		get
		{
			return this._path;
		}
		set
		{
			this._path = value ?? string.Empty;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x0600042F RID: 1071 RVA: 0x00005D2B File Offset: 0x00003F2B
	// (set) Token: 0x06000430 RID: 1072 RVA: 0x0002AFE4 File Offset: 0x000291E4
	public string String_4
	{
		get
		{
			return this._port;
		}
		set
		{
			if (value.smethod_87())
			{
				this._port = string.Empty;
				this._ports = new int[0];
				return;
			}
			if (!value.smethod_84('"'))
			{
				throw new GException1("The value specified for the Port attribute isn't enclosed in double quotes.");
			}
			string text;
			if (!GClass15.smethod_3(value, out this._ports, out text))
			{
				throw new GException1(string.Format("The value specified for the Port attribute contains an invalid value: {0}", text));
			}
			this._port = value;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000431 RID: 1073 RVA: 0x00005D33 File Offset: 0x00003F33
	// (set) Token: 0x06000432 RID: 1074 RVA: 0x00005D3B File Offset: 0x00003F3B
	public bool Boolean_4
	{
		get
		{
			return this._secure;
		}
		set
		{
			this._secure = value;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x00005D44 File Offset: 0x00003F44
	public DateTime DateTime_1
	{
		get
		{
			return this._timestamp;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x00005D4C File Offset: 0x00003F4C
	// (set) Token: 0x06000435 RID: 1077 RVA: 0x0002B050 File Offset: 0x00029250
	public string String_5
	{
		get
		{
			return this._value;
		}
		set
		{
			string text;
			if (!GClass15.smethod_1(value, out text))
			{
				throw new GException1(text);
			}
			this._value = ((value.Length > 0) ? value : "\"\"");
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000436 RID: 1078 RVA: 0x00005D54 File Offset: 0x00003F54
	// (set) Token: 0x06000437 RID: 1079 RVA: 0x00005D5C File Offset: 0x00003F5C
	public int Int32_2
	{
		get
		{
			return this._version;
		}
		set
		{
			if (value < 0 || value > 1)
			{
				throw new ArgumentOutOfRangeException("value", "Not 0 or 1.");
			}
			this._version = value;
		}
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00005D7D File Offset: 0x00003F7D
	private static bool smethod_0(string string_0, out string string_1)
	{
		if (string_0.smethod_87())
		{
			string_1 = "The value specified for the Name is null or empty.";
			return false;
		}
		if (string_0[0] != '$' && !string_0.smethod_15(GClass15._reservedCharsForName))
		{
			string_1 = string.Empty;
			return true;
		}
		string_1 = "The value specified for the Name contains an invalid character.";
		return false;
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00005DB9 File Offset: 0x00003FB9
	private static bool smethod_1(string string_0, out string string_1)
	{
		if (string_0 == null)
		{
			string_1 = "The value specified for the Value is null.";
			return false;
		}
		if (string_0.smethod_15(GClass15._reservedCharsForValue) && !string_0.smethod_84('"'))
		{
			string_1 = "The value specified for the Value contains an invalid character.";
			return false;
		}
		string_1 = string.Empty;
		return true;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00005DEF File Offset: 0x00003FEF
	private static int smethod_2(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		return int_0 ^ ((int_1 << 13) | (int_1 >> 19)) ^ ((int_2 << 26) | (int_2 >> 6)) ^ ((int_3 << 7) | (int_3 >> 25)) ^ ((int_4 << 20) | (int_4 >> 12));
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0002B088 File Offset: 0x00029288
	private string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("{0}={1}", this._name, this._value);
		if (this._expires != DateTime.MinValue)
		{
			stringBuilder.AppendFormat("; Expires={0}", this._expires.ToUniversalTime().ToString("ddd, dd'-'MMM'-'yyyy HH':'mm':'ss 'GMT'", CultureInfo.CreateSpecificCulture("en-US")));
		}
		if (!this._path.smethod_87())
		{
			stringBuilder.AppendFormat("; Path={0}", this._path);
		}
		if (!this._domain.smethod_87())
		{
			stringBuilder.AppendFormat("; Domain={0}", this._domain);
		}
		if (this._secure)
		{
			stringBuilder.Append("; Secure");
		}
		if (this._httpOnly)
		{
			stringBuilder.Append("; HttpOnly");
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0002B164 File Offset: 0x00029364
	private string method_1()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("{0}={1}; Version={2}", this._name, this._value, this._version);
		if (this._expires != DateTime.MinValue)
		{
			stringBuilder.AppendFormat("; Max-Age={0}", this.Int32_0);
		}
		if (!this._path.smethod_87())
		{
			stringBuilder.AppendFormat("; Path={0}", this._path);
		}
		if (!this._domain.smethod_87())
		{
			stringBuilder.AppendFormat("; Domain={0}", this._domain);
		}
		if (!this._port.smethod_87())
		{
			if (this._port == "\"\"")
			{
				stringBuilder.Append("; Port");
			}
			else
			{
				stringBuilder.AppendFormat("; Port={0}", this._port);
			}
		}
		if (!this._comment.smethod_87())
		{
			stringBuilder.AppendFormat("; Comment={0}", this._comment.smethod_106());
		}
		if (this._commentUri != null)
		{
			string originalString = this._commentUri.OriginalString;
			stringBuilder.AppendFormat("; CommentURL={0}", originalString.smethod_48() ? originalString : originalString.smethod_50());
		}
		if (this._discard)
		{
			stringBuilder.Append("; Discard");
		}
		if (this._secure)
		{
			stringBuilder.Append("; Secure");
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0002B2CC File Offset: 0x000294CC
	private static bool smethod_3(string string_0, out int[] int_0, out string string_1)
	{
		string[] array = string_0.Trim(new char[] { '"' }).Split(new char[] { ',' });
		int num = array.Length;
		int[] array2 = new int[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = int.MinValue;
			string text = array[i].Trim();
			if (text.Length != 0 && !int.TryParse(text, out array2[i]))
			{
				int_0 = new int[0];
				string_1 = text;
				return false;
			}
		}
		int_0 = array2;
		string_1 = string.Empty;
		return true;
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x0002B358 File Offset: 0x00029558
	internal string method_2(Uri uri_0)
	{
		if (this._name.Length == 0)
		{
			return string.Empty;
		}
		if (this._version == 0)
		{
			return string.Format("{0}={1}", this._name, this._value);
		}
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("$Version={0}; {1}={2}", this._version, this._name, this._value);
		if (!this._path.smethod_87())
		{
			stringBuilder.AppendFormat("; $Path={0}", this._path);
		}
		else if (uri_0 != null)
		{
			stringBuilder.AppendFormat("; $Path={0}", uri_0.smethod_28());
		}
		else
		{
			stringBuilder.Append("; $Path=/");
		}
		if ((uri_0 == null || uri_0.Host != this._domain) && !this._domain.smethod_87())
		{
			stringBuilder.AppendFormat("; $Domain={0}", this._domain);
		}
		if (!this._port.smethod_87())
		{
			if (this._port == "\"\"")
			{
				stringBuilder.Append("; $Port");
			}
			else
			{
				stringBuilder.AppendFormat("; $Port={0}", this._port);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00005E1A File Offset: 0x0000401A
	internal string method_3()
	{
		if (this._name.Length <= 0)
		{
			return string.Empty;
		}
		if (this._version != 0)
		{
			return this.method_1();
		}
		return this.method_0();
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0002B490 File Offset: 0x00029690
	public override bool Equals(object obj)
	{
		GClass15 gclass = obj as GClass15;
		return gclass != null && this._name.Equals(gclass.String_2, StringComparison.InvariantCultureIgnoreCase) && this._value.Equals(gclass.String_5, StringComparison.InvariantCulture) && this._path.Equals(gclass.String_3, StringComparison.InvariantCulture) && this._domain.Equals(gclass.String_1, StringComparison.InvariantCultureIgnoreCase) && this._version == gclass.Int32_2;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0002B508 File Offset: 0x00029708
	public override int GetHashCode()
	{
		return GClass15.smethod_2(StringComparer.InvariantCultureIgnoreCase.GetHashCode(this._name), this._value.GetHashCode(), this._path.GetHashCode(), StringComparer.InvariantCultureIgnoreCase.GetHashCode(this._domain), this._version);
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00005E45 File Offset: 0x00004045
	public override string ToString()
	{
		return this.method_2(null);
	}

	// Token: 0x040001F4 RID: 500
	private string _comment;

	// Token: 0x040001F5 RID: 501
	private Uri _commentUri;

	// Token: 0x040001F6 RID: 502
	private bool _discard;

	// Token: 0x040001F7 RID: 503
	private string _domain;

	// Token: 0x040001F8 RID: 504
	private DateTime _expires;

	// Token: 0x040001F9 RID: 505
	private bool _httpOnly;

	// Token: 0x040001FA RID: 506
	private string _name;

	// Token: 0x040001FB RID: 507
	private string _path;

	// Token: 0x040001FC RID: 508
	private string _port;

	// Token: 0x040001FD RID: 509
	private int[] _ports;

	// Token: 0x040001FE RID: 510
	private static readonly char[] _reservedCharsForName = new char[] { ' ', '=', ';', ',', '\n', '\r', '\t' };

	// Token: 0x040001FF RID: 511
	private static readonly char[] _reservedCharsForValue = new char[] { ';', ',' };

	// Token: 0x04000200 RID: 512
	private bool _secure;

	// Token: 0x04000201 RID: 513
	private DateTime _timestamp;

	// Token: 0x04000202 RID: 514
	private string _value;

	// Token: 0x04000203 RID: 515
	private int _version;

	// Token: 0x04000204 RID: 516
	[CompilerGenerated]
	private bool f_508537A8;
}
