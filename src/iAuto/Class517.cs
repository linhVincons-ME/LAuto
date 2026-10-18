using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020002E2 RID: 738
internal class Class517
{
	// Token: 0x170008D8 RID: 2264
	// (get) Token: 0x06002824 RID: 10276 RVA: 0x0001B0A3 File Offset: 0x000192A3
	// (set) Token: 0x06002825 RID: 10277 RVA: 0x0001B0AB File Offset: 0x000192AB
	public int Int32_0 { get; set; }

	// Token: 0x170008D9 RID: 2265
	// (get) Token: 0x06002826 RID: 10278 RVA: 0x0001B0B4 File Offset: 0x000192B4
	// (set) Token: 0x06002827 RID: 10279 RVA: 0x0001B0BC File Offset: 0x000192BC
	public int Int32_1 { get; set; }

	// Token: 0x170008DA RID: 2266
	// (get) Token: 0x06002828 RID: 10280 RVA: 0x0001B0C5 File Offset: 0x000192C5
	// (set) Token: 0x06002829 RID: 10281 RVA: 0x0001B0CD File Offset: 0x000192CD
	public long Int64_0 { get; set; }

	// Token: 0x170008DB RID: 2267
	// (get) Token: 0x0600282A RID: 10282 RVA: 0x0001B0D6 File Offset: 0x000192D6
	// (set) Token: 0x0600282B RID: 10283 RVA: 0x0001B0DE File Offset: 0x000192DE
	public int Int32_2 { get; set; }

	// Token: 0x170008DC RID: 2268
	// (get) Token: 0x0600282C RID: 10284 RVA: 0x0001B0E7 File Offset: 0x000192E7
	// (set) Token: 0x0600282D RID: 10285 RVA: 0x0001B0EF File Offset: 0x000192EF
	public int Int32_3 { get; set; }

	// Token: 0x170008DD RID: 2269
	// (get) Token: 0x0600282E RID: 10286 RVA: 0x0001B0F8 File Offset: 0x000192F8
	// (set) Token: 0x0600282F RID: 10287 RVA: 0x0001B100 File Offset: 0x00019300
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x170008DE RID: 2270
	// (get) Token: 0x06002830 RID: 10288 RVA: 0x0001B109 File Offset: 0x00019309
	// (set) Token: 0x06002831 RID: 10289 RVA: 0x0001B111 File Offset: 0x00019311
	public int Int32_4 { get; set; }

	// Token: 0x170008DF RID: 2271
	// (get) Token: 0x06002832 RID: 10290 RVA: 0x0001B11A File Offset: 0x0001931A
	// (set) Token: 0x06002833 RID: 10291 RVA: 0x0001B122 File Offset: 0x00019322
	public int Int32_5 { get; set; }

	// Token: 0x170008E0 RID: 2272
	// (get) Token: 0x06002834 RID: 10292 RVA: 0x0001B12B File Offset: 0x0001932B
	// (set) Token: 0x06002835 RID: 10293 RVA: 0x0001B133 File Offset: 0x00019333
	public int Int32_6 { get; set; }

	// Token: 0x170008E1 RID: 2273
	// (get) Token: 0x06002836 RID: 10294 RVA: 0x0001B13C File Offset: 0x0001933C
	// (set) Token: 0x06002837 RID: 10295 RVA: 0x0001B144 File Offset: 0x00019344
	public int Int32_7 { get; set; }

	// Token: 0x170008E2 RID: 2274
	// (get) Token: 0x06002838 RID: 10296 RVA: 0x0001B14D File Offset: 0x0001934D
	// (set) Token: 0x06002839 RID: 10297 RVA: 0x0001B155 File Offset: 0x00019355
	public int Int32_8 { get; set; }

	// Token: 0x170008E3 RID: 2275
	// (get) Token: 0x0600283A RID: 10298 RVA: 0x0001B15E File Offset: 0x0001935E
	// (set) Token: 0x0600283B RID: 10299 RVA: 0x0001B166 File Offset: 0x00019366
	public string String_1 { get; set; } = string.Empty;

	// Token: 0x170008E4 RID: 2276
	// (get) Token: 0x0600283C RID: 10300 RVA: 0x0001B16F File Offset: 0x0001936F
	// (set) Token: 0x0600283D RID: 10301 RVA: 0x0001B177 File Offset: 0x00019377
	public bool Boolean_0 { get; set; }

	// Token: 0x170008E5 RID: 2277
	// (get) Token: 0x0600283E RID: 10302 RVA: 0x0001B180 File Offset: 0x00019380
	// (set) Token: 0x0600283F RID: 10303 RVA: 0x0001B188 File Offset: 0x00019388
	public int Int32_9 { get; set; }

	// Token: 0x170008E6 RID: 2278
	// (get) Token: 0x06002840 RID: 10304 RVA: 0x001208D4 File Offset: 0x0011EAD4
	public GEnum22 GEnum22_0
	{
		get
		{
			Dictionary<GEnum22, int> dictionary = new Dictionary<GEnum22, int>();
			dictionary.Add(GEnum22.NgoaiCong, this.Int32_4);
			dictionary.Add(GEnum22.NoiCong, this.Int32_5);
			dictionary.Add(GEnum22.TheLuc, this.Int32_6);
			dictionary.Add(GEnum22.ThanPhap, this.Int32_7);
			return dictionary.OrderByDescending<KeyValuePair<GEnum22, int>, int>(new Func<KeyValuePair<GEnum22, int>, int>(Class517.Class518.f_111F3BFD.method_0)).FirstOrDefault<KeyValuePair<GEnum22, int>>().Key;
		}
	}

	// Token: 0x04001B39 RID: 6969
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001B3A RID: 6970
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04001B3B RID: 6971
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001B3C RID: 6972
	[CompilerGenerated]
	private int int_2;

	// Token: 0x04001B3D RID: 6973
	[CompilerGenerated]
	private int int_3;

	// Token: 0x04001B3E RID: 6974
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001B3F RID: 6975
	[CompilerGenerated]
	private int int_4;

	// Token: 0x04001B40 RID: 6976
	[CompilerGenerated]
	private int int_5;

	// Token: 0x04001B41 RID: 6977
	[CompilerGenerated]
	private int int_6;

	// Token: 0x04001B42 RID: 6978
	[CompilerGenerated]
	private int int_7;

	// Token: 0x04001B43 RID: 6979
	[CompilerGenerated]
	private int int_8;

	// Token: 0x04001B44 RID: 6980
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001B45 RID: 6981
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001B46 RID: 6982
	[CompilerGenerated]
	private int int_9;

	// Token: 0x020002E3 RID: 739
	[CompilerGenerated]
	[Serializable]
	private sealed class Class518
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x0001B1BB File Offset: 0x000193BB
		internal int method_0(KeyValuePair<GEnum22, int> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x04001B47 RID: 6983
		public static readonly Class517.Class518 f_111F3BFD = new Class517.Class518();

		// Token: 0x04001B48 RID: 6984
		public static Func<KeyValuePair<GEnum22, int>, int> f_53B030B6;
	}
}
