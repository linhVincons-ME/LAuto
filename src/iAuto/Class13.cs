using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000023 RID: 35
internal class Class13 : Class11
{
	// Token: 0x06000131 RID: 305 RVA: 0x00003CD1 File Offset: 0x00001ED1
	private Class13(string string_3, string string_4, Version version_1, NameValueCollection nameValueCollection_1)
		: base(version_1, nameValueCollection_1)
	{
		this.string_1 = string_3;
		this.string_2 = string_4;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00003CEA File Offset: 0x00001EEA
	internal Class13(GEnum5 genum5_0)
		: this(genum5_0, genum5_0.smethod_81())
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00020BF4 File Offset: 0x0001EDF4
	internal Class13(GEnum5 genum5_0, string string_3)
		: this(((int)genum5_0).ToString(), string_3, GClass24.version_1, new NameValueCollection())
	{
		base.NameValueCollection_0["Server"] = "websocket-sharp/1.0";
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000134 RID: 308 RVA: 0x00003CF9 File Offset: 0x00001EF9
	public GClass16 GClass16_0
	{
		get
		{
			return base.NameValueCollection_0.smethod_29(true);
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000135 RID: 309 RVA: 0x00003D07 File Offset: 0x00001F07
	public bool Boolean_0
	{
		get
		{
			return base.NameValueCollection_0.smethod_17("Connection", "close", StringComparison.OrdinalIgnoreCase);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000136 RID: 310 RVA: 0x00003D1F File Offset: 0x00001F1F
	public bool Boolean_1
	{
		get
		{
			return this.string_1 == "407";
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000137 RID: 311 RVA: 0x00003D31 File Offset: 0x00001F31
	public bool Boolean_2
	{
		get
		{
			return this.string_1 == "301" || this.string_1 == "302";
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000138 RID: 312 RVA: 0x00003D57 File Offset: 0x00001F57
	public bool Boolean_3
	{
		get
		{
			return this.string_1 == "401";
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000139 RID: 313 RVA: 0x00003D69 File Offset: 0x00001F69
	public bool Boolean_4
	{
		get
		{
			return base.Version_0 > GClass24.version_0 && this.string_1 == "101" && base.NameValueCollection_0.smethod_74("websocket");
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600013A RID: 314 RVA: 0x00003DA1 File Offset: 0x00001FA1
	public string String_1
	{
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600013B RID: 315 RVA: 0x00003DA9 File Offset: 0x00001FA9
	public string String_2
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00003DB1 File Offset: 0x00001FB1
	internal static Class13 smethod_3(GEnum5 genum5_0)
	{
		Class13 @class = new Class13(genum5_0);
		@class.NameValueCollection_0["Connection"] = "close";
		return @class;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00003DCE File Offset: 0x00001FCE
	internal static Class13 smethod_4(string string_3)
	{
		Class13 @class = new Class13(GEnum5.Unauthorized);
		@class.NameValueCollection_0["WWW-Authenticate"] = string_3;
		return @class;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00003DEB File Offset: 0x00001FEB
	internal static Class13 smethod_5()
	{
		Class13 @class = new Class13(GEnum5.SwitchingProtocols);
		NameValueCollection nameValueCollection_ = @class.NameValueCollection_0;
		nameValueCollection_["Upgrade"] = "websocket";
		nameValueCollection_["Connection"] = "Upgrade";
		return @class;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00020C30 File Offset: 0x0001EE30
	internal static Class13 smethod_6(string[] string_3)
	{
		string[] array = string_3[0].Split(new char[] { ' ' }, 3);
		if (array.Length != 3)
		{
			throw new ArgumentException("Invalid status line: " + string_3[0]);
		}
		GClass27 gclass = new GClass27();
		for (int i = 1; i < string_3.Length; i++)
		{
			gclass.method_11(string_3[i], true);
		}
		return new Class13(array[1], array[2], new Version(array[0].Substring(5)), gclass);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00003E19 File Offset: 0x00002019
	internal static Class13 smethod_7(Stream stream_0, int int_1)
	{
		Func<string[], Class13> func;
		if ((func = Class13.Class17.func_0) == null)
		{
			func = (Class13.Class17.func_0 = new Func<string[], Class13>(Class13.smethod_6));
		}
		return Class11.smethod_2<Class13>(stream_0, func, int_1);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00020CA4 File Offset: 0x0001EEA4
	public void method_1(GClass16 gclass16_0)
	{
		if (gclass16_0 != null && gclass16_0.Count != 0)
		{
			NameValueCollection nameValueCollection_ = base.NameValueCollection_0;
			foreach (GClass15 gclass in gclass16_0.IEnumerable_0)
			{
				nameValueCollection_.Add("Set-Cookie", gclass.method_3());
			}
			return;
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00020D10 File Offset: 0x0001EF10
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("HTTP/{0} {1} {2}{3}", new object[] { base.Version_0, this.string_1, this.string_2, "\r\n" });
		NameValueCollection nameValueCollection_ = base.NameValueCollection_0;
		foreach (string text in nameValueCollection_.AllKeys)
		{
			stringBuilder.AppendFormat("{0}: {1}{2}", text, nameValueCollection_[text], "\r\n");
		}
		stringBuilder.Append("\r\n");
		string string_ = base.String_0;
		if (string_.Length > 0)
		{
			stringBuilder.Append(string_);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x040000B9 RID: 185
	private string string_1;

	// Token: 0x040000BA RID: 186
	private string string_2;

	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	private static class Class17
	{
		// Token: 0x040000BB RID: 187
		public static Func<string[], Class13> func_0;
	}
}
