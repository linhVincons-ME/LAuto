using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

// Token: 0x020002EA RID: 746
internal class Class524
{
	// Token: 0x0600289E RID: 10398 RVA: 0x0001B65C File Offset: 0x0001985C
	public Class524()
	{
		this.XmlNode_0 = Class521.xmlDocument_0.CreateElement("Script");
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x0001B679 File Offset: 0x00019879
	public Class524(XmlNode xmlNode_1)
	{
		this.XmlNode_0 = xmlNode_1;
	}

	// Token: 0x170008F4 RID: 2292
	// (get) Token: 0x060028A0 RID: 10400 RVA: 0x0001B688 File Offset: 0x00019888
	// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0001B690 File Offset: 0x00019890
	public XmlNode XmlNode_0 { get; set; }

	// Token: 0x060028A2 RID: 10402 RVA: 0x00124CE8 File Offset: 0x00122EE8
	private string method_0(string string_0)
	{
		string text2;
		try
		{
			XmlAttribute xmlAttribute = this.XmlNode_0.Attributes[string_0];
			string text;
			if (xmlAttribute != null)
			{
				if ((text = xmlAttribute.Value) != null)
				{
					goto IL_0026;
				}
			}
			text = "";
			IL_0026:
			text2 = text;
		}
		catch
		{
			text2 = "";
		}
		return text2;
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x00124D38 File Offset: 0x00122F38
	private void method_1(string string_0, string string_1)
	{
		try
		{
			if (this.XmlNode_0.Attributes[string_0] != null)
			{
				this.XmlNode_0.Attributes[string_0].Value = string_1;
			}
			else
			{
				XmlAttribute xmlAttribute = Class521.xmlDocument_0.CreateAttribute(string_0);
				xmlAttribute.Value = string_1;
				this.XmlNode_0.Attributes.Append(xmlAttribute);
			}
		}
		catch
		{
			XmlAttribute xmlAttribute2 = Class521.xmlDocument_0.CreateAttribute(string_0);
			xmlAttribute2.Value = string_1;
			this.XmlNode_0.Attributes.Append(xmlAttribute2);
		}
	}

	// Token: 0x170008F5 RID: 2293
	// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0001B699 File Offset: 0x00019899
	// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0001B6A6 File Offset: 0x000198A6
	public string String_0
	{
		get
		{
			return this.method_0("ID");
		}
		set
		{
			this.method_1("ID", value);
		}
	}

	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x060028A6 RID: 10406 RVA: 0x00124DD0 File Offset: 0x00122FD0
	// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0001B6B4 File Offset: 0x000198B4
	public string String_1
	{
		get
		{
			if (this.String_6.Contains("Thiên sư kỳ đãi"))
			{
				string text;
				try
				{
					text = (Class531.smethod_19(this.XmlNode_0.Attributes["Level"].Value) + 5).ToString();
				}
				catch
				{
					text = "";
				}
				return text;
			}
			return this.method_0("Level");
		}
		set
		{
			this.method_1("Level", value);
		}
	}

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0001B6C2 File Offset: 0x000198C2
	// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0001B6CF File Offset: 0x000198CF
	public string String_2
	{
		get
		{
			return this.method_0("InfoEx");
		}
		set
		{
			this.method_1("InfoEx", value);
		}
	}

	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x060028AA RID: 10410 RVA: 0x0001B6DD File Offset: 0x000198DD
	// (set) Token: 0x060028AB RID: 10411 RVA: 0x0001B6EA File Offset: 0x000198EA
	public string String_3
	{
		get
		{
			return this.method_0("MD");
		}
		set
		{
			this.method_1("MD", value);
		}
	}

	// Token: 0x170008F9 RID: 2297
	// (get) Token: 0x060028AC RID: 10412 RVA: 0x00124E44 File Offset: 0x00123044
	// (set) Token: 0x060028AD RID: 10413 RVA: 0x0001B6F8 File Offset: 0x000198F8
	public string String_4
	{
		get
		{
			if (this.Boolean_2)
			{
				return "[Completed]";
			}
			if (this.Boolean_7)
			{
				return "[BienThan]";
			}
			if (this.Boolean_1)
			{
				return "[IsComplete]";
			}
			if (this.String_8 != "0")
			{
				return "[IsCollect]";
			}
			if (this.Boolean_3)
			{
				return "[UseItem]";
			}
			return this.method_0("Monter");
		}
		set
		{
			this.method_1("Monter", value);
		}
	}

	// Token: 0x170008FA RID: 2298
	// (get) Token: 0x060028AE RID: 10414 RVA: 0x00124EAC File Offset: 0x001230AC
	public string String_5
	{
		get
		{
			try
			{
				string[] array = this.String_13.Split(new char[] { ':' });
				if (array.Length != 0)
				{
					return Class531.smethod_26(array[0]).Replace(" ", "");
				}
			}
			catch
			{
			}
			return "";
		}
	}

	// Token: 0x170008FB RID: 2299
	// (get) Token: 0x060028AF RID: 10415 RVA: 0x0001B706 File Offset: 0x00019906
	// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0001B72B File Offset: 0x0001992B
	public string String_6
	{
		get
		{
			string text = this.method_0("Name");
			if (string.IsNullOrEmpty(text))
			{
				this.method_1("Name", "");
			}
			return text;
		}
		set
		{
			this.method_1("Name", value);
		}
	}

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0001B739 File Offset: 0x00019939
	// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0001B746 File Offset: 0x00019946
	public string String_7
	{
		get
		{
			return this.method_0("Recv");
		}
		set
		{
			this.method_1("Recv", value);
		}
	}

	// Token: 0x170008FD RID: 2301
	// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00124F0C File Offset: 0x0012310C
	public Class530 Class530_0
	{
		get
		{
			Class530 @class = new Class530();
			if (this.String_7.Length == 12)
			{
				@class.Int32_0 = Class515.smethod_4(this.String_7.Substring(0, 3));
				@class.Int32_1 = Class515.smethod_4(this.String_7.Substring(3, 3));
				@class.Int32_2 = Class515.smethod_4(this.String_7.Substring(6, 3));
				@class.Int32_3 = Class515.smethod_4(this.String_7.Substring(9, 3));
			}
			return @class;
		}
	}

	// Token: 0x170008FE RID: 2302
	// (get) Token: 0x060028B4 RID: 10420 RVA: 0x0001B754 File Offset: 0x00019954
	public Class530 Class530_1
	{
		get
		{
			return this.method_2(6);
		}
	}

	// Token: 0x170008FF RID: 2303
	// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0001B75D File Offset: 0x0001995D
	public Class530 Class530_2
	{
		get
		{
			return this.method_2(18);
		}
	}

	// Token: 0x17000900 RID: 2304
	// (get) Token: 0x060028B6 RID: 10422 RVA: 0x0001B767 File Offset: 0x00019967
	public Class530 Class530_3
	{
		get
		{
			return this.method_2(30);
		}
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x00124F90 File Offset: 0x00123190
	private Class530 method_2(int int_0)
	{
		Class530 @class = new Class530();
		if (this.String_12.Length >= int_0 + 12)
		{
			@class.String_1 = this.String_12.Substring(int_0, 3);
			@class.Int32_1 = Class515.smethod_4(this.String_12.Substring(int_0 + 3, 3));
			@class.Int32_2 = Class515.smethod_4(this.String_12.Substring(int_0 + 6, 3));
			@class.Int32_3 = Class515.smethod_4(this.String_12.Substring(int_0 + 9, 3));
		}
		return @class;
	}

	// Token: 0x17000901 RID: 2305
	// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0001B771 File Offset: 0x00019971
	public bool Boolean_0
	{
		get
		{
			return this.String_12.Length >= 43 && this.String_12[42] == '1';
		}
	}

	// Token: 0x17000902 RID: 2306
	// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00125018 File Offset: 0x00123218
	// (set) Token: 0x060028BA RID: 10426 RVA: 0x00125050 File Offset: 0x00123250
	public string String_8
	{
		get
		{
			if (this.String_12.Length < 44)
			{
				return "0";
			}
			return this.String_12[43].ToString();
		}
		set
		{
			if (this.String_12.Length >= 44)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[43] = value[0];
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000903 RID: 2307
	// (get) Token: 0x060028BB RID: 10427 RVA: 0x0001B795 File Offset: 0x00019995
	// (set) Token: 0x060028BC RID: 10428 RVA: 0x00125094 File Offset: 0x00123294
	public bool Boolean_1
	{
		get
		{
			return this.String_12.Length >= 45 && this.String_12[44] == '1';
		}
		set
		{
			if (this.String_12.Length >= 45)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[44] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000904 RID: 2308
	// (get) Token: 0x060028BD RID: 10429 RVA: 0x0001B7B9 File Offset: 0x000199B9
	// (set) Token: 0x060028BE RID: 10430 RVA: 0x001250DC File Offset: 0x001232DC
	public bool Boolean_2
	{
		get
		{
			return this.String_12.Length >= 46 && this.String_12[45] == '1';
		}
		set
		{
			if (this.String_12.Length >= 46)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[45] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000905 RID: 2309
	// (get) Token: 0x060028BF RID: 10431 RVA: 0x0001B7DD File Offset: 0x000199DD
	// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00125124 File Offset: 0x00123324
	public bool Boolean_3
	{
		get
		{
			return this.String_12.Length >= 47 && this.String_12[46] == '1';
		}
		set
		{
			if (this.String_12.Length >= 47)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[46] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0012516C File Offset: 0x0012336C
	// (set) Token: 0x060028C2 RID: 10434 RVA: 0x001251A8 File Offset: 0x001233A8
	public int Int32_0
	{
		get
		{
			if (this.String_12.Length < 48)
			{
				return -1;
			}
			return Class531.smethod_19(this.String_12[47].ToString()) - 1;
		}
		set
		{
			if (this.String_12.Length >= 48)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[47] = value.ToString()[0];
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x060028C3 RID: 10435 RVA: 0x001251F4 File Offset: 0x001233F4
	// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00125230 File Offset: 0x00123430
	public int Int32_1
	{
		get
		{
			if (this.String_12.Length < 49)
			{
				return -1;
			}
			return Class531.smethod_19(this.String_12[48].ToString()) - 1;
		}
		set
		{
			if (this.String_12.Length >= 49)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[48] = value.ToString()[0];
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000908 RID: 2312
	// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0001B801 File Offset: 0x00019A01
	// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0012527C File Offset: 0x0012347C
	public bool Boolean_4
	{
		get
		{
			return this.String_12.Length >= 50 && this.String_12[49] == '1';
		}
		set
		{
			if (this.String_12.Length >= 50)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[49] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x17000909 RID: 2313
	// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0001B825 File Offset: 0x00019A25
	// (set) Token: 0x060028C8 RID: 10440 RVA: 0x001252C4 File Offset: 0x001234C4
	public bool Boolean_5
	{
		get
		{
			return this.String_12.Length >= 51 && this.String_12[50] == '1';
		}
		set
		{
			if (this.String_12.Length >= 51)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[50] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x1700090A RID: 2314
	// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0012530C File Offset: 0x0012350C
	// (set) Token: 0x060028CA RID: 10442 RVA: 0x0001B849 File Offset: 0x00019A49
	public bool Boolean_6
	{
		get
		{
			bool flag;
			try
			{
				XmlAttribute xmlAttribute = this.XmlNode_0.Attributes["BienThan"];
				flag = ((xmlAttribute != null) ? xmlAttribute.Value : null) == "True";
			}
			catch
			{
				flag = false;
			}
			return flag;
		}
		set
		{
			this.method_1("BienThan", value.ToString());
		}
	}

	// Token: 0x1700090B RID: 2315
	// (get) Token: 0x060028CB RID: 10443 RVA: 0x0001B85D File Offset: 0x00019A5D
	// (set) Token: 0x060028CC RID: 10444 RVA: 0x00125360 File Offset: 0x00123560
	public bool Boolean_7
	{
		get
		{
			return this.String_12.Length >= 52 && this.String_12[51] == '1';
		}
		set
		{
			if (this.String_12.Length >= 52)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_12);
				stringBuilder[51] = (value ? '1' : '0');
				this.String_12 = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x1700090C RID: 2316
	// (get) Token: 0x060028CD RID: 10445 RVA: 0x0001B881 File Offset: 0x00019A81
	// (set) Token: 0x060028CE RID: 10446 RVA: 0x0001B88E File Offset: 0x00019A8E
	public string String_9
	{
		get
		{
			return this.method_0("Send");
		}
		set
		{
			this.method_1("Send", value);
		}
	}

	// Token: 0x1700090D RID: 2317
	// (get) Token: 0x060028CF RID: 10447 RVA: 0x001253A8 File Offset: 0x001235A8
	public Class530 Class530_4
	{
		get
		{
			if (this.String_6 == "Quả Ngân Võ Lâm Ấn Bối Diệp Kinh Tàn Phiến")
			{
				return Class524.class530_0;
			}
			Class530 @class = new Class530();
			if (this.String_9.Length == 12)
			{
				@class.Int32_0 = Class515.smethod_4(this.String_9.Substring(0, 3));
				@class.Int32_1 = Class515.smethod_4(this.String_9.Substring(3, 3));
				@class.Int32_2 = Class515.smethod_4(this.String_9.Substring(6, 3));
				@class.Int32_3 = Class515.smethod_4(this.String_9.Substring(9, 3));
			}
			return @class;
		}
	}

	// Token: 0x1700090E RID: 2318
	// (get) Token: 0x060028D0 RID: 10448 RVA: 0x0001B89C File Offset: 0x00019A9C
	public string String_10
	{
		get
		{
			if (this.String_12.Length < 6)
			{
				return "000";
			}
			return this.String_12.Substring(3, 3);
		}
	}

	// Token: 0x1700090F RID: 2319
	// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0001B8BF File Offset: 0x00019ABF
	public string String_11
	{
		get
		{
			if (this.String_12.Length < 3)
			{
				return "000";
			}
			return this.String_12.Substring(0, 3);
		}
	}

	// Token: 0x17000910 RID: 2320
	// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0001B8E2 File Offset: 0x00019AE2
	// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0001B8EF File Offset: 0x00019AEF
	public string String_12
	{
		get
		{
			return this.method_0("Do");
		}
		set
		{
			this.method_1("Do", value);
		}
	}

	// Token: 0x17000911 RID: 2321
	// (get) Token: 0x060028D4 RID: 10452 RVA: 0x0001B8FD File Offset: 0x00019AFD
	// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0001B90A File Offset: 0x00019B0A
	public string String_13
	{
		get
		{
			return this.method_0("Info");
		}
		set
		{
			this.method_1("Info", value);
		}
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x00125444 File Offset: 0x00123644
	public bool method_3(Class519 class519_0)
	{
		return !string.IsNullOrEmpty(class519_0.String_0.Trim()) && (this.String_6.Contains(class519_0.String_0) || this.String_6.smethod_36() == class519_0.String_0.smethod_36() || (this.String_6 == "Khoa Ngân Võ Lâm Ấn Phồn Mang Tào Vận" && class519_0.String_0 == "Khoa Ngân Võ Lâm Ấn Phồn Mang Tào Vận") || this.String_6 == "#{YD_100806_58}");
	}

	// Token: 0x04001BAE RID: 7086
	public static readonly Class530 class530_0 = new Class530
	{
		Int32_0 = 32,
		Int32_1 = 290,
		Int32_2 = 322,
		Int32_3 = 0,
		String_2 = "Gia Cát Khổng Minh"
	};

	// Token: 0x04001BAF RID: 7087
	[CompilerGenerated]
	private XmlNode xmlNode_0;
}
