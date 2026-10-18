using System;
using System.Security.Principal;
using WebSocketSharp.Net;

// Token: 0x02000073 RID: 115
public sealed class GClass20
{
	// Token: 0x060004F1 RID: 1265 RVA: 0x00006531 File Offset: 0x00004731
	internal GClass20(Class62 class62_1)
	{
		this.class62_0 = class62_1;
		this.int_0 = 400;
		this.gclass22_0 = new GClass22(this);
		this.gclass23_0 = new GClass23(this);
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00006563 File Offset: 0x00004763
	internal Class62 Class62_0
	{
		get
		{
			return this.class62_0;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000656B File Offset: 0x0000476B
	// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00006573 File Offset: 0x00004773
	internal string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000657C File Offset: 0x0000477C
	// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00006584 File Offset: 0x00004784
	internal int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0000658D File Offset: 0x0000478D
	internal bool Boolean_0
	{
		get
		{
			return this.string_0 != null;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00006598 File Offset: 0x00004798
	// (set) Token: 0x060004F9 RID: 1273 RVA: 0x000065A0 File Offset: 0x000047A0
	internal GClass19 GClass19_0
	{
		get
		{
			return this.gclass19_0;
		}
		set
		{
			this.gclass19_0 = value;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060004FA RID: 1274 RVA: 0x000065A9 File Offset: 0x000047A9
	public GClass22 GClass22_0
	{
		get
		{
			return this.gclass22_0;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060004FB RID: 1275 RVA: 0x000065B1 File Offset: 0x000047B1
	public GClass23 GClass23_0
	{
		get
		{
			return this.gclass23_0;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060004FC RID: 1276 RVA: 0x000065B9 File Offset: 0x000047B9
	public IPrincipal IPrincipal_0
	{
		get
		{
			return this.iprincipal_0;
		}
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0002DF1C File Offset: 0x0002C11C
	internal bool method_0()
	{
		AuthenticationSchemes authenticationSchemes = this.gclass19_0.method_14(this.gclass22_0);
		if (authenticationSchemes == AuthenticationSchemes.Anonymous)
		{
			return true;
		}
		if (authenticationSchemes == AuthenticationSchemes.None)
		{
			this.gclass23_0.smethod_10(GEnum5.Forbidden);
			return false;
		}
		string text = this.gclass19_0.method_10();
		IPrincipal principal = Class71.smethod_20(this.gclass22_0.NameValueCollection_0["Authorization"], authenticationSchemes, text, this.gclass22_0.String_2, this.gclass19_0.method_11());
		if (principal != null && principal.Identity.IsAuthenticated)
		{
			this.iprincipal_0 = principal;
			return true;
		}
		this.gclass23_0.smethod_11(new Class52(authenticationSchemes, text).ToString());
		return false;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x000065C1 File Offset: 0x000047C1
	internal bool method_1()
	{
		return this.gclass19_0.method_12(this);
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x000065CF File Offset: 0x000047CF
	internal void method_2()
	{
		this.gclass19_0.method_15(this);
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0002DFCC File Offset: 0x0002C1CC
	public GClass29 method_3(string string_1)
	{
		if (this.gclass29_0 != null)
		{
			throw new InvalidOperationException("The accepting is already in progress.");
		}
		if (string_1 != null)
		{
			if (string_1.Length == 0)
			{
				throw new ArgumentException("An empty string.", "protocol");
			}
			if (!string_1.smethod_48())
			{
				throw new ArgumentException("Contains an invalid character.", "protocol");
			}
		}
		this.gclass29_0 = new GClass29(this, string_1);
		return this.gclass29_0;
	}

	// Token: 0x0400025B RID: 603
	private Class62 class62_0;

	// Token: 0x0400025C RID: 604
	private string string_0;

	// Token: 0x0400025D RID: 605
	private int int_0;

	// Token: 0x0400025E RID: 606
	private GClass19 gclass19_0;

	// Token: 0x0400025F RID: 607
	private GClass22 gclass22_0;

	// Token: 0x04000260 RID: 608
	private GClass23 gclass23_0;

	// Token: 0x04000261 RID: 609
	private IPrincipal iprincipal_0;

	// Token: 0x04000262 RID: 610
	private GClass29 gclass29_0;
}
