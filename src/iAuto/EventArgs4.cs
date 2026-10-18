using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020001F7 RID: 503
internal class EventArgs4 : EventArgs
{
	// Token: 0x06001C62 RID: 7266 RVA: 0x000133A8 File Offset: 0x000115A8
	public EventArgs4(int int_2, int int_3, List<int> list_1)
	{
		this.Int32_0 = int_2;
		this.Int32_1 = int_3;
		this.List_0 = list_1;
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06001C63 RID: 7267 RVA: 0x000133C5 File Offset: 0x000115C5
	public int Int32_0 { get; }

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000133CD File Offset: 0x000115CD
	public int Int32_1 { get; }

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000133D5 File Offset: 0x000115D5
	public List<int> List_0 { get; }

	// Token: 0x0400118C RID: 4492
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x0400118D RID: 4493
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x0400118E RID: 4494
	[CompilerGenerated]
	private readonly List<int> list_0;
}
