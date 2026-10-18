using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x0200005B RID: 91
internal class Class53 : Class51
{
	// Token: 0x060003CD RID: 973 RVA: 0x00005814 File Offset: 0x00003A14
	private Class53(AuthenticationSchemes authenticationSchemes_1, NameValueCollection nameValueCollection_1)
		: base(authenticationSchemes_1, nameValueCollection_1)
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00005870 File Offset: 0x00003A70
	internal Class53(GClass25 gclass25_0)
		: this(AuthenticationSchemes.Basic, new NameValueCollection(), gclass25_0, 0U)
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00005880 File Offset: 0x00003A80
	internal Class53(Class52 class52_0, GClass25 gclass25_0, uint uint_1)
		: this(class52_0.AuthenticationSchemes_0, class52_0.nameValueCollection_0, gclass25_0, uint_1)
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x0002A094 File Offset: 0x00028294
	internal Class53(AuthenticationSchemes authenticationSchemes_1, NameValueCollection nameValueCollection_1, GClass25 gclass25_0, uint uint_1)
		: base(authenticationSchemes_1, nameValueCollection_1)
	{
		this.nameValueCollection_0["username"] = gclass25_0.String_3;
		this.nameValueCollection_0["password"] = gclass25_0.String_1;
		this.nameValueCollection_0["uri"] = gclass25_0.String_0;
		this.uint_0 = uint_1;
		if (authenticationSchemes_1 == AuthenticationSchemes.Digest)
		{
			this.method_0();
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060003D1 RID: 977 RVA: 0x00005896 File Offset: 0x00003A96
	internal uint UInt32_0
	{
		get
		{
			if (this.uint_0 >= 4294967295U)
			{
				return 0U;
			}
			return this.uint_0;
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060003D2 RID: 978 RVA: 0x000058A9 File Offset: 0x00003AA9
	public string String_5
	{
		get
		{
			return this.nameValueCollection_0["cnonce"];
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060003D3 RID: 979 RVA: 0x000058BB File Offset: 0x00003ABB
	public string String_6
	{
		get
		{
			return this.nameValueCollection_0["nc"];
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060003D4 RID: 980 RVA: 0x000058CD File Offset: 0x00003ACD
	public string String_7
	{
		get
		{
			return this.nameValueCollection_0["password"];
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x000058DF File Offset: 0x00003ADF
	public string String_8
	{
		get
		{
			return this.nameValueCollection_0["response"];
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060003D6 RID: 982 RVA: 0x000058F1 File Offset: 0x00003AF1
	public string String_9
	{
		get
		{
			return this.nameValueCollection_0["uri"];
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060003D7 RID: 983 RVA: 0x00005903 File Offset: 0x00003B03
	public string String_10
	{
		get
		{
			return this.nameValueCollection_0["username"];
		}
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00005915 File Offset: 0x00003B15
	private static string smethod_2(string string_0, string string_1, string string_2)
	{
		return string.Format("{0}:{1}:{2}", string_0, string_2, string_1);
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00005924 File Offset: 0x00003B24
	private static string smethod_3(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		return string.Format("{0}:{1}:{2}", Class53.smethod_6(Class53.smethod_2(string_0, string_1, string_2)), string_3, string_4);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00005940 File Offset: 0x00003B40
	private static string smethod_4(string string_0, string string_1)
	{
		return string.Format("{0}:{1}", string_0, string_1);
	}

	// Token: 0x060003DB RID: 987 RVA: 0x0000594E File Offset: 0x00003B4E
	private static string smethod_5(string string_0, string string_1, string string_2)
	{
		return string.Format("{0}:{1}:{2}", string_0, string_1, Class53.smethod_6(string_2));
	}

	// Token: 0x060003DC RID: 988 RVA: 0x0002A100 File Offset: 0x00028300
	private static string smethod_6(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		byte[] array = MD5.Create().ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder(64);
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0002A15C File Offset: 0x0002835C
	private void method_0()
	{
		string text = this.nameValueCollection_0["qop"];
		if (text != null)
		{
			if (text.Split(new char[] { ',' }).smethod_18<string>(new Func<string, bool>(Class53.Class54.f_8DE0094A.method_0)))
			{
				this.nameValueCollection_0["qop"] = "auth";
				this.nameValueCollection_0["cnonce"] = Class51.smethod_0();
				NameValueCollection nameValueCollection_ = this.nameValueCollection_0;
				string text2 = "nc";
				string text3 = "{0:x8}";
				uint num = this.uint_0 + 1U;
				this.uint_0 = num;
				nameValueCollection_[text2] = string.Format(text3, num);
			}
			else
			{
				this.nameValueCollection_0["qop"] = null;
			}
		}
		this.nameValueCollection_0["method"] = "GET";
		this.nameValueCollection_0["response"] = Class53.smethod_7(this.nameValueCollection_0);
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0002A254 File Offset: 0x00028454
	internal static string smethod_7(NameValueCollection nameValueCollection_1)
	{
		string text = nameValueCollection_1["username"];
		string text2 = nameValueCollection_1["password"];
		string text3 = nameValueCollection_1["realm"];
		string text4 = nameValueCollection_1["nonce"];
		string text5 = nameValueCollection_1["uri"];
		string text6 = nameValueCollection_1["algorithm"];
		string text7 = nameValueCollection_1["qop"];
		string text8 = nameValueCollection_1["cnonce"];
		string text9 = nameValueCollection_1["nc"];
		string text10 = nameValueCollection_1["method"];
		string text11 = ((text6 == null || !(text6.ToLower() == "md5-sess")) ? Class53.smethod_2(text, text2, text3) : Class53.smethod_3(text, text2, text3, text4, text8));
		string text12 = ((text7 == null || !(text7.ToLower() == "auth-int")) ? Class53.smethod_4(text10, text5) : Class53.smethod_5(text10, text5, nameValueCollection_1["entity"]));
		string text13 = Class53.smethod_6(text11);
		string text14 = ((text7 != null) ? string.Format("{0}:{1}:{2}:{3}:{4}", new object[]
		{
			text4,
			text9,
			text8,
			text7,
			Class53.smethod_6(text12)
		}) : string.Format("{0}:{1}", text4, Class53.smethod_6(text12)));
		return Class53.smethod_6(string.Format("{0}:{1}", text13, text14));
	}

	// Token: 0x060003DF RID: 991 RVA: 0x0002A3A4 File Offset: 0x000285A4
	internal static Class53 smethod_8(string string_0)
	{
		try
		{
			string[] array = string_0.Split(new char[] { ' ' }, 2);
			if (array.Length != 2)
			{
				return null;
			}
			string text = array[0].ToLower();
			return (text == "basic") ? new Class53(AuthenticationSchemes.Basic, Class53.smethod_9(array[1])) : ((text == "digest") ? new Class53(AuthenticationSchemes.Digest, Class51.smethod_1(array[1])) : null);
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x0002A42C File Offset: 0x0002862C
	internal static NameValueCollection smethod_9(string string_0)
	{
		string @string = Encoding.Default.GetString(Convert.FromBase64String(string_0));
		int num = @string.IndexOf(':');
		string text = @string.Substring(0, num);
		string text2 = ((num < @string.Length - 1) ? @string.Substring(num + 1) : string.Empty);
		num = text.IndexOf('\\');
		if (num > -1)
		{
			text = text.Substring(num + 1);
		}
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["username"] = text;
		nameValueCollection["password"] = text2;
		return nameValueCollection;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x0002A4AC File Offset: 0x000286AC
	internal override string m_C16EB083()
	{
		string text = string.Format("{0}:{1}", this.nameValueCollection_0["username"], this.nameValueCollection_0["password"]);
		string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
		return "Basic " + text2;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x0002A500 File Offset: 0x00028700
	internal override string m_C16EB083_2()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		stringBuilder.AppendFormat("Digest username=\"{0}\", realm=\"{1}\", nonce=\"{2}\", uri=\"{3}\", response=\"{4}\"", new object[]
		{
			this.nameValueCollection_0["username"],
			this.nameValueCollection_0["realm"],
			this.nameValueCollection_0["nonce"],
			this.nameValueCollection_0["uri"],
			this.nameValueCollection_0["response"]
		});
		string text = this.nameValueCollection_0["opaque"];
		if (text != null)
		{
			stringBuilder.AppendFormat(", opaque=\"{0}\"", text);
		}
		string text2 = this.nameValueCollection_0["algorithm"];
		if (text2 != null)
		{
			stringBuilder.AppendFormat(", algorithm={0}", text2);
		}
		string text3 = this.nameValueCollection_0["qop"];
		if (text3 != null)
		{
			stringBuilder.AppendFormat(", qop={0}, cnonce=\"{1}\", nc={2}", text3, this.nameValueCollection_0["cnonce"], this.nameValueCollection_0["nc"]);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x0002A614 File Offset: 0x00028814
	public IIdentity method_1()
	{
		AuthenticationSchemes authenticationSchemes_ = base.AuthenticationSchemes_0;
		if (authenticationSchemes_ != AuthenticationSchemes.Basic)
		{
			return (authenticationSchemes_ == AuthenticationSchemes.Digest) ? new GClass18(this.nameValueCollection_0) : null;
		}
		return new GClass17(this.nameValueCollection_0["username"], this.nameValueCollection_0["password"]);
	}

	// Token: 0x040001D4 RID: 468
	private uint uint_0;

	// Token: 0x0200005C RID: 92
	[CompilerGenerated]
	[Serializable]
	private sealed class Class54
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0000596E File Offset: 0x00003B6E
		internal bool method_0(string string_0)
		{
			return string_0.Trim().ToLower() == "auth";
		}

		// Token: 0x040001D5 RID: 469
		public static readonly Class53.Class54 f_8DE0094A = new Class53.Class54();

		// Token: 0x040001D6 RID: 470
		public static Func<string, bool> f_6EFDAD11;
	}
}
