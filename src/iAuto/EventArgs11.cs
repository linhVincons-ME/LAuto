using System;
using System.Runtime.CompilerServices;
using _i;

// Token: 0x02000203 RID: 515
internal class EventArgs11 : EventArgs
{
	// Token: 0x06001CA1 RID: 7329 RVA: 0x00013645 File Offset: 0x00011845
	public EventArgs11(FCTBAction fctbaction_1)
	{
		this.FCTBAction_0 = fctbaction_1;
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00013654 File Offset: 0x00011854
	// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0001365C File Offset: 0x0001185C
	public FCTBAction FCTBAction_0 { get; private set; }

	// Token: 0x040011B9 RID: 4537
	[CompilerGenerated]
	private FCTBAction fctbaction_0;
}
