using System;
using System.Runtime.CompilerServices;

// Token: 0x020001D9 RID: 473
internal class Class324
{
	// Token: 0x06001990 RID: 6544 RVA: 0x0001189C File Offset: 0x0000FA9C
	public Class324(Class357 class357_0)
	{
		this.GStruct19_0 = class357_0.GStruct19_0;
		this.GStruct19_1 = class357_0.GStruct19_1;
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001991 RID: 6545 RVA: 0x000118BC File Offset: 0x0000FABC
	// (set) Token: 0x06001992 RID: 6546 RVA: 0x000118C4 File Offset: 0x0000FAC4
	public GStruct19 GStruct19_0 { get; set; }

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001993 RID: 6547 RVA: 0x000118CD File Offset: 0x0000FACD
	// (set) Token: 0x06001994 RID: 6548 RVA: 0x000118D5 File Offset: 0x0000FAD5
	public GStruct19 GStruct19_1 { get; set; }

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001995 RID: 6549 RVA: 0x000CE5E0 File Offset: 0x000CC7E0
	internal int Int32_0
	{
		get
		{
			if (this.GStruct19_1.int_1 < this.GStruct19_0.int_1)
			{
				return this.GStruct19_1.int_0;
			}
			if (this.GStruct19_1.int_1 > this.GStruct19_0.int_1)
			{
				return this.GStruct19_0.int_0;
			}
			return Math.Min(this.GStruct19_1.int_0, this.GStruct19_0.int_0);
		}
	}

	// Token: 0x04001095 RID: 4245
	[CompilerGenerated]
	private GStruct19 gstruct19_0;

	// Token: 0x04001096 RID: 4246
	[CompilerGenerated]
	private GStruct19 gstruct19_1;
}
