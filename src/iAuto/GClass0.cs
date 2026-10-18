using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
public sealed class GClass0
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00003317 File Offset: 0x00001517
	// (set) Token: 0x06000004 RID: 4 RVA: 0x0000331F File Offset: 0x0000151F
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00003328 File Offset: 0x00001528
	// (set) Token: 0x06000006 RID: 6 RVA: 0x00003330 File Offset: 0x00001530
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00003339 File Offset: 0x00001539
	// (set) Token: 0x06000008 RID: 8 RVA: 0x00003341 File Offset: 0x00001541
	public IntPtr IntPtr_0 { get; set; }

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000009 RID: 9 RVA: 0x0000334A File Offset: 0x0000154A
	// (set) Token: 0x0600000A RID: 10 RVA: 0x00003352 File Offset: 0x00001552
	public uint UInt32_0 { get; set; }

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000B RID: 11 RVA: 0x0000335B File Offset: 0x0000155B
	// (set) Token: 0x0600000C RID: 12 RVA: 0x00003363 File Offset: 0x00001563
	public IntPtr IntPtr_1 { get; set; }

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600000D RID: 13 RVA: 0x0000336C File Offset: 0x0000156C
	// (set) Token: 0x0600000E RID: 14 RVA: 0x00003374 File Offset: 0x00001574
	public int Int32_0
	{
		get
		{
			return (int)this.UInt32_0;
		}
		set
		{
			this.UInt32_0 = (uint)value;
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0001DB94 File Offset: 0x0001BD94
	public override string ToString()
	{
		return string.Format("{0} @ 0x{1:X} ({2} bytes) [{3}]", new object[]
		{
			this.String_0,
			this.IntPtr_0.ToInt64(),
			this.UInt32_0,
			this.String_1
		});
	}

	// Token: 0x04000002 RID: 2
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000003 RID: 3
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04000004 RID: 4
	[CompilerGenerated]
	private IntPtr intptr_0;

	// Token: 0x04000005 RID: 5
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000006 RID: 6
	[CompilerGenerated]
	private IntPtr intptr_1;
}
