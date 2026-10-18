using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020002D0 RID: 720
internal class Class503
{
	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x06002597 RID: 9623 RVA: 0x0001971B File Offset: 0x0001791B
	// (set) Token: 0x06002598 RID: 9624 RVA: 0x00019723 File Offset: 0x00017923
	public long Int64_0 { get; set; }

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x06002599 RID: 9625 RVA: 0x0001972C File Offset: 0x0001792C
	// (set) Token: 0x0600259A RID: 9626 RVA: 0x00019734 File Offset: 0x00017934
	public long Int64_1 { get; set; }

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x0600259B RID: 9627 RVA: 0x0001973D File Offset: 0x0001793D
	// (set) Token: 0x0600259C RID: 9628 RVA: 0x00019745 File Offset: 0x00017945
	public int Int32_0 { get; set; }

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x0600259D RID: 9629 RVA: 0x0001974E File Offset: 0x0001794E
	// (set) Token: 0x0600259E RID: 9630 RVA: 0x00019756 File Offset: 0x00017956
	public int Int32_1 { get; set; }

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x0600259F RID: 9631 RVA: 0x0001975F File Offset: 0x0001795F
	// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00019767 File Offset: 0x00017967
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x060025A1 RID: 9633 RVA: 0x00019770 File Offset: 0x00017970
	// (set) Token: 0x060025A2 RID: 9634 RVA: 0x00019778 File Offset: 0x00017978
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00019781 File Offset: 0x00017981
	public bool Boolean_0
	{
		get
		{
			return Class503.hashSet_0.Any<string>(new Func<string, bool>(this.String_1.Contains)) || (this.String_1.Contains("WuhunSkill") && this.Int32_1 > 100);
		}
	}

	// Token: 0x04001974 RID: 6516
	private static readonly HashSet<string> hashSet_0 = new HashSet<string>
	{
		"FightSkill", "FabaoSkill", "MiJiSkill", "fuqiskill", "Shoes2_5", "RideHeader1_1", "MenpaiLiveSkill2_7", "TaskTools2_13", "PetSkill2_4", "CommonLiveSkill2_2",
		"CircularTaskTool43_2", "Shoes2_4", "TaskTools4_1"
	};

	// Token: 0x04001975 RID: 6517
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001976 RID: 6518
	[CompilerGenerated]
	private long long_1;

	// Token: 0x04001977 RID: 6519
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001978 RID: 6520
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001979 RID: 6521
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400197A RID: 6522
	[CompilerGenerated]
	private string string_1;
}
