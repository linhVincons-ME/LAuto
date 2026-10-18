using System;

// Token: 0x0200006E RID: 110
internal class Class64
{
	// Token: 0x060004A7 RID: 1191 RVA: 0x0000620F File Offset: 0x0000440F
	internal Class64(string string_1, Enum5 enum5_1)
	{
		this.string_0 = string_1;
		this.enum5_0 = enum5_1;
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00006225 File Offset: 0x00004425
	internal bool Boolean_0
	{
		get
		{
			return (this.enum5_0 & Enum5.MultiValueInRequest) == Enum5.MultiValueInRequest;
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00006234 File Offset: 0x00004434
	internal bool Boolean_1
	{
		get
		{
			return (this.enum5_0 & Enum5.MultiValueInResponse) == Enum5.MultiValueInResponse;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060004AA RID: 1194 RVA: 0x00006243 File Offset: 0x00004443
	public bool Boolean_2
	{
		get
		{
			return (this.enum5_0 & Enum5.Request) == Enum5.Request;
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060004AB RID: 1195 RVA: 0x00006250 File Offset: 0x00004450
	public bool Boolean_3
	{
		get
		{
			return (this.enum5_0 & Enum5.Response) == Enum5.Response;
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000625D File Offset: 0x0000445D
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x00006265 File Offset: 0x00004465
	public Enum5 Enum5_0
	{
		get
		{
			return this.enum5_0;
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0000626D File Offset: 0x0000446D
	public bool method_0(bool bool_0)
	{
		if ((this.enum5_0 & Enum5.MultiValue) != Enum5.MultiValue)
		{
			if (!bool_0)
			{
				return this.Boolean_0;
			}
			return this.Boolean_1;
		}
		else
		{
			if (!bool_0)
			{
				return this.Boolean_2;
			}
			return this.Boolean_3;
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0000629B File Offset: 0x0000449B
	public bool method_1(bool bool_0)
	{
		if ((this.enum5_0 & Enum5.Restricted) != Enum5.Restricted)
		{
			return false;
		}
		if (!bool_0)
		{
			return this.Boolean_2;
		}
		return this.Boolean_3;
	}

	// Token: 0x04000230 RID: 560
	private string string_0;

	// Token: 0x04000231 RID: 561
	private Enum5 enum5_0;
}
