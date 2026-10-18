using System;
using System.Collections.Specialized;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x0200005A RID: 90
internal class Class52 : Class51
{
	// Token: 0x060003C4 RID: 964 RVA: 0x00005814 File Offset: 0x00003A14
	private Class52(AuthenticationSchemes authenticationSchemes_1, NameValueCollection nameValueCollection_1)
		: base(authenticationSchemes_1, nameValueCollection_1)
	{
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00029EA0 File Offset: 0x000280A0
	internal Class52(AuthenticationSchemes authenticationSchemes_1, string string_0)
		: base(authenticationSchemes_1, new NameValueCollection())
	{
		this.nameValueCollection_0["realm"] = string_0;
		if (authenticationSchemes_1 == AuthenticationSchemes.Digest)
		{
			this.nameValueCollection_0["nonce"] = Class51.smethod_0();
			this.nameValueCollection_0["algorithm"] = "MD5";
			this.nameValueCollection_0["qop"] = "auth";
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000581E File Offset: 0x00003A1E
	public string String_5
	{
		get
		{
			return this.nameValueCollection_0["domain"];
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060003C7 RID: 967 RVA: 0x00005830 File Offset: 0x00003A30
	public string String_6
	{
		get
		{
			return this.nameValueCollection_0["stale"];
		}
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00005842 File Offset: 0x00003A42
	internal static Class52 smethod_2(string string_0)
	{
		return new Class52(AuthenticationSchemes.Basic, string_0);
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x0000584B File Offset: 0x00003A4B
	internal static Class52 smethod_3(string string_0)
	{
		return new Class52(AuthenticationSchemes.Digest, string_0);
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00029F10 File Offset: 0x00028110
	internal static Class52 smethod_4(string string_0)
	{
		string[] array = string_0.Split(new char[] { ' ' }, 2);
		if (array.Length != 2)
		{
			return null;
		}
		string text = array[0].ToLower();
		if (text == "basic")
		{
			return new Class52(AuthenticationSchemes.Basic, Class51.smethod_1(array[1]));
		}
		if (!(text == "digest"))
		{
			return null;
		}
		return new Class52(AuthenticationSchemes.Digest, Class51.smethod_1(array[1]));
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00005854 File Offset: 0x00003A54
	internal override string m_C16EB083()
	{
		return string.Format("Basic realm=\"{0}\"", this.nameValueCollection_0["realm"]);
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00029F7C File Offset: 0x0002817C
	internal override string m_C16EB083_2()
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		string text = this.nameValueCollection_0["domain"];
		if (text != null)
		{
			stringBuilder.AppendFormat("Digest realm=\"{0}\", domain=\"{1}\", nonce=\"{2}\"", this.nameValueCollection_0["realm"], text, this.nameValueCollection_0["nonce"]);
		}
		else
		{
			stringBuilder.AppendFormat("Digest realm=\"{0}\", nonce=\"{1}\"", this.nameValueCollection_0["realm"], this.nameValueCollection_0["nonce"]);
		}
		string text2 = this.nameValueCollection_0["opaque"];
		if (text2 != null)
		{
			stringBuilder.AppendFormat(", opaque=\"{0}\"", text2);
		}
		string text3 = this.nameValueCollection_0["stale"];
		if (text3 != null)
		{
			stringBuilder.AppendFormat(", stale={0}", text3);
		}
		string text4 = this.nameValueCollection_0["algorithm"];
		if (text4 != null)
		{
			stringBuilder.AppendFormat(", algorithm={0}", text4);
		}
		string text5 = this.nameValueCollection_0["qop"];
		if (text5 != null)
		{
			stringBuilder.AppendFormat(", qop=\"{0}\"", text5);
		}
		return stringBuilder.ToString();
	}
}
