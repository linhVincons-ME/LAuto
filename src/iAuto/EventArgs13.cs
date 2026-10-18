using System;
using System.Runtime.CompilerServices;

// Token: 0x0200020A RID: 522
internal class EventArgs13 : EventArgs
{
	// Token: 0x06001CD3 RID: 7379 RVA: 0x0001385B File Offset: 0x00011A5B
	public EventArgs13(string string_3, int int_1, string string_4)
	{
		this.String_0 = string_3;
		this.Int32_0 = int_1;
		this.String_1 = string_4;
		this.String_2 = string_4;
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0001387F File Offset: 0x00011A7F
	// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00013887 File Offset: 0x00011A87
	public string String_0 { get; private set; }

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00013890 File Offset: 0x00011A90
	// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00013898 File Offset: 0x00011A98
	public int Int32_0 { get; private set; }

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000138A1 File Offset: 0x00011AA1
	// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000138A9 File Offset: 0x00011AA9
	public string String_1 { get; private set; }

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000138B2 File Offset: 0x00011AB2
	// (set) Token: 0x06001CDB RID: 7387 RVA: 0x000138BA File Offset: 0x00011ABA
	public string String_2 { get; set; }

	// Token: 0x040011E7 RID: 4583
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040011E8 RID: 4584
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040011E9 RID: 4585
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040011EA RID: 4586
	[CompilerGenerated]
	private string string_2;
}
