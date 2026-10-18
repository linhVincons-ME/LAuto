using System;
using System.Security.Principal;

// Token: 0x0200006A RID: 106
public class GClass17 : GenericIdentity
{
	// Token: 0x0600047F RID: 1151 RVA: 0x00005FF2 File Offset: 0x000041F2
	internal GClass17(string string_1, string string_2)
		: base(string_1, "Basic")
	{
		this.string_0 = string_2;
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000480 RID: 1152 RVA: 0x00006007 File Offset: 0x00004207
	public virtual string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x04000215 RID: 533
	private string string_0;
}
