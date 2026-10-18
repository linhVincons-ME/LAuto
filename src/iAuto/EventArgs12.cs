using System;
using System.Runtime.CompilerServices;

// Token: 0x02000209 RID: 521
internal class EventArgs12 : EventArgs
{
	// Token: 0x06001CCC RID: 7372 RVA: 0x0001380B File Offset: 0x00011A0B
	public EventArgs12(string string_2, int int_1)
	{
		this.String_0 = string_2;
		this.Int32_0 = int_1;
		this.String_1 = string_2;
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00013828 File Offset: 0x00011A28
	// (set) Token: 0x06001CCE RID: 7374 RVA: 0x00013830 File Offset: 0x00011A30
	public string String_0 { get; private set; }

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00013839 File Offset: 0x00011A39
	// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x00013841 File Offset: 0x00011A41
	public int Int32_0 { get; private set; }

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0001384A File Offset: 0x00011A4A
	// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x00013852 File Offset: 0x00011A52
	public string String_1 { get; set; }

	// Token: 0x040011E4 RID: 4580
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040011E5 RID: 4581
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040011E6 RID: 4582
	[CompilerGenerated]
	private string string_1;
}
