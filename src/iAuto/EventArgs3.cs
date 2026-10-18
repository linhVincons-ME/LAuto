using System;
using System.Runtime.CompilerServices;

// Token: 0x020001F6 RID: 502
internal class EventArgs3 : EventArgs
{
	// Token: 0x06001C5F RID: 7263 RVA: 0x00013382 File Offset: 0x00011582
	public EventArgs3(int int_2, int int_3)
	{
		this.Int32_0 = int_2;
		this.Int32_1 = int_3;
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00013398 File Offset: 0x00011598
	public int Int32_0 { get; }

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000133A0 File Offset: 0x000115A0
	public int Int32_1 { get; }

	// Token: 0x0400118A RID: 4490
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x0400118B RID: 4491
	[CompilerGenerated]
	private readonly int int_1;
}
