using System;
using System.Collections.Specialized;
using System.Security.Principal;

// Token: 0x0200006D RID: 109
public class GClass18 : GenericIdentity
{
	// Token: 0x0600049C RID: 1180 RVA: 0x0000614E File Offset: 0x0000434E
	internal GClass18(NameValueCollection nameValueCollection_1)
		: base(nameValueCollection_1["username"], "Digest")
	{
		this.nameValueCollection_0 = nameValueCollection_1;
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000616D File Offset: 0x0000436D
	public string String_0
	{
		get
		{
			return this.nameValueCollection_0["algorithm"];
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x0600049E RID: 1182 RVA: 0x0000617F File Offset: 0x0000437F
	public string String_1
	{
		get
		{
			return this.nameValueCollection_0["cnonce"];
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600049F RID: 1183 RVA: 0x00006191 File Offset: 0x00004391
	public string String_2
	{
		get
		{
			return this.nameValueCollection_0["nc"];
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000061A3 File Offset: 0x000043A3
	public string String_3
	{
		get
		{
			return this.nameValueCollection_0["nonce"];
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000061B5 File Offset: 0x000043B5
	public string String_4
	{
		get
		{
			return this.nameValueCollection_0["opaque"];
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000061C7 File Offset: 0x000043C7
	public string String_5
	{
		get
		{
			return this.nameValueCollection_0["qop"];
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000061D9 File Offset: 0x000043D9
	public string String_6
	{
		get
		{
			return this.nameValueCollection_0["realm"];
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000061EB File Offset: 0x000043EB
	public string String_7
	{
		get
		{
			return this.nameValueCollection_0["response"];
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000061FD File Offset: 0x000043FD
	public string String_8
	{
		get
		{
			return this.nameValueCollection_0["uri"];
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0002D5BC File Offset: 0x0002B7BC
	internal bool method_0(string string_0, string string_1, string string_2, string string_3)
	{
		NameValueCollection nameValueCollection = new NameValueCollection(this.nameValueCollection_0);
		nameValueCollection["password"] = string_0;
		nameValueCollection["realm"] = string_1;
		nameValueCollection["method"] = string_2;
		nameValueCollection["entity"] = string_3;
		string text = Class53.smethod_7(nameValueCollection);
		return this.nameValueCollection_0["response"] == text;
	}

	// Token: 0x0400022F RID: 559
	private NameValueCollection nameValueCollection_0;
}
