using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000021 RID: 33
internal class Class12 : Class11
{
	// Token: 0x06000123 RID: 291 RVA: 0x00003C01 File Offset: 0x00001E01
	private Class12(string string_3, string string_4, Version version_1, NameValueCollection nameValueCollection_1)
		: base(version_1, nameValueCollection_1)
	{
		this.string_1 = string_3;
		this.string_2 = string_4;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00003C1A File Offset: 0x00001E1A
	internal Class12(string string_3, string string_4)
		: this(string_3, string_4, GClass24.version_1, new NameValueCollection())
	{
		base.NameValueCollection_0["User-Agent"] = "websocket-sharp/1.0";
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000125 RID: 293 RVA: 0x000208CC File Offset: 0x0001EACC
	public Class53 Class53_0
	{
		get
		{
			string text = base.NameValueCollection_0["Authorization"];
			if (text != null && text.Length > 0)
			{
				return Class53.smethod_8(text);
			}
			return null;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000126 RID: 294 RVA: 0x00003C43 File Offset: 0x00001E43
	public GClass16 GClass16_0
	{
		get
		{
			if (this.gclass16_0 == null)
			{
				this.gclass16_0 = base.NameValueCollection_0.smethod_29(false);
			}
			return this.gclass16_0;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000127 RID: 295 RVA: 0x00003C65 File Offset: 0x00001E65
	public string String_1
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000128 RID: 296 RVA: 0x00003C6D File Offset: 0x00001E6D
	public bool Boolean_0
	{
		get
		{
			return this.string_1 == "GET" && base.Version_0 > GClass24.version_0 && base.NameValueCollection_0.smethod_74("websocket");
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000129 RID: 297 RVA: 0x00003CA5 File Offset: 0x00001EA5
	public string String_2
	{
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00020900 File Offset: 0x0001EB00
	internal static Class12 smethod_3(Uri uri_0)
	{
		string dnsSafeHost = uri_0.DnsSafeHost;
		int port = uri_0.Port;
		string text = string.Format("{0}:{1}", dnsSafeHost, port);
		Class12 @class = new Class12("CONNECT", text);
		@class.NameValueCollection_0["Host"] = ((port == 80) ? dnsSafeHost : text);
		return @class;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00020954 File Offset: 0x0001EB54
	internal static Class12 smethod_4(Uri uri_0)
	{
		Class12 @class = new Class12("GET", uri_0.PathAndQuery);
		NameValueCollection nameValueCollection_ = @class.NameValueCollection_0;
		int port = uri_0.Port;
		string scheme = uri_0.Scheme;
		nameValueCollection_["Host"] = (((port != 80 || !(scheme == "ws")) && (port != 443 || !(scheme == "wss"))) ? uri_0.Authority : uri_0.DnsSafeHost);
		nameValueCollection_["Upgrade"] = "websocket";
		nameValueCollection_["Connection"] = "Upgrade";
		return @class;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000209E4 File Offset: 0x0001EBE4
	internal Class13 method_1(Stream stream_0, int int_1)
	{
		byte[] array = base.method_0();
		stream_0.Write(array, 0, array.Length);
		Func<string[], Class13> func;
		if ((func = Class12.Class16.func_0) == null)
		{
			func = (Class12.Class16.func_0 = new Func<string[], Class13>(Class13.smethod_6));
		}
		return Class11.smethod_2<Class13>(stream_0, func, int_1);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00020A28 File Offset: 0x0001EC28
	internal static Class12 smethod_5(string[] string_3)
	{
		string[] array = string_3[0].Split(new char[] { ' ' }, 3);
		if (array.Length != 3)
		{
			throw new ArgumentException("Invalid request line: " + string_3[0]);
		}
		GClass27 gclass = new GClass27();
		for (int i = 1; i < string_3.Length; i++)
		{
			gclass.method_11(string_3[i], false);
		}
		return new Class12(array[0], array[1], new Version(array[2].Substring(5)), gclass);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00003CAD File Offset: 0x00001EAD
	internal static Class12 smethod_6(Stream stream_0, int int_1)
	{
		Func<string[], Class12> func;
		if ((func = Class12.Class16.func_1) == null)
		{
			func = (Class12.Class16.func_1 = new Func<string[], Class12>(Class12.smethod_5));
		}
		return Class11.smethod_2<Class12>(stream_0, func, int_1);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00020A9C File Offset: 0x0001EC9C
	public void method_2(GClass16 gclass16_1)
	{
		if (gclass16_1 != null && gclass16_1.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			foreach (GClass15 gclass in gclass16_1.IEnumerable_0)
			{
				if (!gclass.Boolean_2)
				{
					stringBuilder.AppendFormat("{0}; ", gclass.ToString());
				}
			}
			int length = stringBuilder.Length;
			if (length > 2)
			{
				stringBuilder.Length = length - 2;
				base.NameValueCollection_0["Cookie"] = stringBuilder.ToString();
			}
			return;
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00020B3C File Offset: 0x0001ED3C
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("{0} {1} HTTP/{2}{3}", new object[] { this.string_1, this.string_2, base.Version_0, "\r\n" });
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

	// Token: 0x040000B4 RID: 180
	private GClass16 gclass16_0;

	// Token: 0x040000B5 RID: 181
	private string string_1;

	// Token: 0x040000B6 RID: 182
	private string string_2;

	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	private static class Class16
	{
		// Token: 0x040000B7 RID: 183
		public static Func<string[], Class13> func_0;

		// Token: 0x040000B8 RID: 184
		public static Func<string[], Class12> func_1;
	}
}
