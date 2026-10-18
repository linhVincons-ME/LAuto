using System;

// Token: 0x0200003A RID: 58
public class GException0 : Exception
{
	// Token: 0x0600022B RID: 555 RVA: 0x00004717 File Offset: 0x00002917
	internal GException0()
		: this(GEnum2.Abnormal, null, null)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00004726 File Offset: 0x00002926
	internal GException0(Exception exception_0)
		: this(GEnum2.Abnormal, null, exception_0)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00004735 File Offset: 0x00002935
	internal GException0(string string_0)
		: this(GEnum2.Abnormal, string_0, null)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00004744 File Offset: 0x00002944
	internal GException0(GEnum2 genum2_1)
		: this(genum2_1, null, null)
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000474F File Offset: 0x0000294F
	internal GException0(string string_0, Exception exception_0)
		: this(GEnum2.Abnormal, string_0, exception_0)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000475E File Offset: 0x0000295E
	internal GException0(GEnum2 genum2_1, Exception exception_0)
		: this(genum2_1, null, exception_0)
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00004769 File Offset: 0x00002969
	internal GException0(GEnum2 genum2_1, string string_0)
		: this(genum2_1, string_0, null)
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00004774 File Offset: 0x00002974
	internal GException0(GEnum2 genum2_1, string string_0, Exception exception_0)
		: base(string_0 ?? genum2_1.smethod_31(), exception_0)
	{
		this.genum2_0 = genum2_1;
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000233 RID: 563 RVA: 0x0000478F File Offset: 0x0000298F
	public GEnum2 GEnum2_0
	{
		get
		{
			return this.genum2_0;
		}
	}

	// Token: 0x0400013A RID: 314
	private GEnum2 genum2_0;
}
