using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020001FA RID: 506
internal class EventArgs7 : EventArgs
{
	// Token: 0x06001C6E RID: 7278 RVA: 0x0001341F File Offset: 0x0001161F
	public EventArgs7(List<int> list_1, bool bool_1, Class351 class351_1)
	{
		this.List_0 = list_1;
		this.Boolean_0 = bool_1;
		this.Class351_0 = class351_1;
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0001343C File Offset: 0x0001163C
	// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00013444 File Offset: 0x00011644
	public List<int> List_0 { get; private set; }

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0001344D File Offset: 0x0001164D
	// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00013455 File Offset: 0x00011655
	public bool Boolean_0 { get; private set; }

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0001345E File Offset: 0x0001165E
	// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00013466 File Offset: 0x00011666
	public Class351 Class351_0 { get; private set; }

	// Token: 0x04001192 RID: 4498
	[CompilerGenerated]
	private List<int> list_0;

	// Token: 0x04001193 RID: 4499
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001194 RID: 4500
	[CompilerGenerated]
	private Class351 class351_0;
}
