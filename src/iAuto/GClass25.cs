using System;

// Token: 0x02000084 RID: 132
public class GClass25
{
	// Token: 0x060005C9 RID: 1481 RVA: 0x00006ECF File Offset: 0x000050CF
	public GClass25(string string_5, string string_6)
		: this(string_5, string_6, null, null)
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00031858 File Offset: 0x0002FA58
	public GClass25(string string_5, string string_6, string string_7, params string[] string_8)
	{
		if (string_5 == null)
		{
			throw new ArgumentNullException("username");
		}
		if (string_5.Length == 0)
		{
			throw new ArgumentException("An empty string.", "username");
		}
		this.string_4 = string_5;
		this.string_2 = string_6;
		this.string_0 = string_7;
		this.string_3 = string_8;
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x060005CB RID: 1483 RVA: 0x00006EDB File Offset: 0x000050DB
	// (set) Token: 0x060005CC RID: 1484 RVA: 0x00006EEC File Offset: 0x000050EC
	public string String_0
	{
		get
		{
			return this.string_0 ?? string.Empty;
		}
		internal set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x060005CD RID: 1485 RVA: 0x00006EF5 File Offset: 0x000050F5
	// (set) Token: 0x060005CE RID: 1486 RVA: 0x00006F06 File Offset: 0x00005106
	public string String_1
	{
		get
		{
			return this.string_2 ?? string.Empty;
		}
		internal set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x00006F0F File Offset: 0x0000510F
	// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00006F20 File Offset: 0x00005120
	public string[] String_2
	{
		get
		{
			return this.string_3 ?? GClass25.string_1;
		}
		internal set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00006F29 File Offset: 0x00005129
	// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00006F31 File Offset: 0x00005131
	public string String_3
	{
		get
		{
			return this.string_4;
		}
		internal set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x04000338 RID: 824
	private string string_0;

	// Token: 0x04000339 RID: 825
	private static readonly string[] string_1 = new string[0];

	// Token: 0x0400033A RID: 826
	private string string_2;

	// Token: 0x0400033B RID: 827
	private string[] string_3;

	// Token: 0x0400033C RID: 828
	private string string_4;
}
