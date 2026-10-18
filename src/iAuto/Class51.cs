using System;
using System.Collections.Specialized;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x02000059 RID: 89
internal abstract class Class51
{
	// Token: 0x060003B8 RID: 952 RVA: 0x00005775 File Offset: 0x00003975
	protected Class51(AuthenticationSchemes authenticationSchemes_1, NameValueCollection nameValueCollection_1)
	{
		this.authenticationSchemes_0 = authenticationSchemes_1;
		this.nameValueCollection_0 = nameValueCollection_1;
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000578B File Offset: 0x0000398B
	public string String_0
	{
		get
		{
			return this.nameValueCollection_0["algorithm"];
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060003BA RID: 954 RVA: 0x0000579D File Offset: 0x0000399D
	public string String_1
	{
		get
		{
			return this.nameValueCollection_0["nonce"];
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060003BB RID: 955 RVA: 0x000057AF File Offset: 0x000039AF
	public string String_2
	{
		get
		{
			return this.nameValueCollection_0["opaque"];
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060003BC RID: 956 RVA: 0x000057C1 File Offset: 0x000039C1
	public string String_3
	{
		get
		{
			return this.nameValueCollection_0["qop"];
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060003BD RID: 957 RVA: 0x000057D3 File Offset: 0x000039D3
	public string String_4
	{
		get
		{
			return this.nameValueCollection_0["realm"];
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060003BE RID: 958 RVA: 0x000057E5 File Offset: 0x000039E5
	public AuthenticationSchemes AuthenticationSchemes_0
	{
		get
		{
			return this.authenticationSchemes_0;
		}
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00029D74 File Offset: 0x00027F74
	internal static string smethod_0()
	{
		byte[] array = new byte[16];
		new Random().NextBytes(array);
		StringBuilder stringBuilder = new StringBuilder(32);
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00029DCC File Offset: 0x00027FCC
	internal static NameValueCollection smethod_1(string string_0)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		foreach (string text in string_0.smethod_56(new char[] { ',' }))
		{
			int num = text.IndexOf('=');
			string text2 = ((num > 0) ? text.Substring(0, num).Trim() : null);
			string text3 = ((num < 0) ? text.Trim().Trim(new char[] { '"' }) : ((num < text.Length - 1) ? text.Substring(num + 1).Trim().Trim(new char[] { '"' }) : string.Empty));
			nameValueCollection.Add(text2, text3);
		}
		return nameValueCollection;
	}

	// Token: 0x060003C1 RID: 961
	internal abstract string m_C16EB083();

	// Token: 0x060003C2 RID: 962
	internal abstract string m_C16EB083_2();

	// Token: 0x060003C3 RID: 963 RVA: 0x000057ED File Offset: 0x000039ED
	public override string ToString()
	{
		if (this.authenticationSchemes_0 == AuthenticationSchemes.Basic)
		{
			return this.m_C16EB083();
		}
		if (this.authenticationSchemes_0 != AuthenticationSchemes.Digest)
		{
			return string.Empty;
		}
		return this.m_C16EB083_2();
	}

	// Token: 0x040001D2 RID: 466
	private AuthenticationSchemes authenticationSchemes_0;

	// Token: 0x040001D3 RID: 467
	internal NameValueCollection nameValueCollection_0;
}
