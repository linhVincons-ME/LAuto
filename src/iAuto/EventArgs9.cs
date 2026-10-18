using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000201 RID: 513
internal class EventArgs9 : EventArgs
{
	// Token: 0x06001C93 RID: 7315 RVA: 0x000135BA File Offset: 0x000117BA
	public EventArgs9(GStruct19 gstruct19_1, string string_3)
	{
		this.String_0 = string_3;
		this.GStruct19_0 = gstruct19_1;
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x06001C94 RID: 7316 RVA: 0x000135D0 File Offset: 0x000117D0
	// (set) Token: 0x06001C95 RID: 7317 RVA: 0x000135D8 File Offset: 0x000117D8
	public GStruct19 GStruct19_0 { get; private set; }

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x06001C96 RID: 7318 RVA: 0x000135E1 File Offset: 0x000117E1
	// (set) Token: 0x06001C97 RID: 7319 RVA: 0x000135E9 File Offset: 0x000117E9
	public string String_0 { get; private set; }

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000135F2 File Offset: 0x000117F2
	// (set) Token: 0x06001C99 RID: 7321 RVA: 0x000135FA File Offset: 0x000117FA
	public string String_1 { get; set; }

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00013603 File Offset: 0x00011803
	// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0001360B File Offset: 0x0001180B
	public string String_2 { get; set; }

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00013614 File Offset: 0x00011814
	// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0001361C File Offset: 0x0001181C
	public ToolTipIcon ToolTipIcon_0 { get; set; }

	// Token: 0x040011B3 RID: 4531
	[CompilerGenerated]
	private GStruct19 gstruct19_0;

	// Token: 0x040011B4 RID: 4532
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040011B5 RID: 4533
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040011B6 RID: 4534
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040011B7 RID: 4535
	[CompilerGenerated]
	private ToolTipIcon toolTipIcon_0;
}
