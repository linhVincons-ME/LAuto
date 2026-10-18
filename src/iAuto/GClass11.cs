using System;

// Token: 0x0200004D RID: 77
public abstract class GClass11
{
	// Token: 0x06000334 RID: 820 RVA: 0x00005318 File Offset: 0x00003518
	protected GClass11(string string_1, GClass6 gclass6_1)
	{
		this.string_0 = string_1;
		this.gclass6_0 = gclass6_1;
		this.gclass13_0 = new GClass13(gclass6_1);
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000335 RID: 821 RVA: 0x0000533A File Offset: 0x0000353A
	internal Enum4 Enum4_0
	{
		get
		{
			return this.gclass13_0.Enum4_0;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000336 RID: 822 RVA: 0x00005347 File Offset: 0x00003547
	protected GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000337 RID: 823 RVA: 0x0000534F File Offset: 0x0000354F
	// (set) Token: 0x06000338 RID: 824 RVA: 0x0000535C File Offset: 0x0000355C
	public bool Boolean_0
	{
		get
		{
			return this.gclass13_0.Boolean_0;
		}
		set
		{
			this.gclass13_0.Boolean_0 = value;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000339 RID: 825 RVA: 0x0000536A File Offset: 0x0000356A
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600033A RID: 826 RVA: 0x00005372 File Offset: 0x00003572
	public GClass13 GClass13_0
	{
		get
		{
			return this.gclass13_0;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x0600033B RID: 827
	public abstract Type P_m_6E6D2FDF { get; }

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x0600033C RID: 828 RVA: 0x0000537A File Offset: 0x0000357A
	// (set) Token: 0x0600033D RID: 829 RVA: 0x00005387 File Offset: 0x00003587
	public TimeSpan TimeSpan_0
	{
		get
		{
			return this.gclass13_0.TimeSpan_0;
		}
		set
		{
			this.gclass13_0.TimeSpan_0 = value;
		}
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00005395 File Offset: 0x00003595
	internal void method_0()
	{
		this.gclass13_0.method_14();
	}

	// Token: 0x0600033F RID: 831 RVA: 0x000053A2 File Offset: 0x000035A2
	internal void method_1(GClass28 gclass28_0)
	{
		this.m_3C35837C().method_6(gclass28_0, this.gclass13_0);
	}

	// Token: 0x06000340 RID: 832 RVA: 0x000053B6 File Offset: 0x000035B6
	internal void method_2(ushort ushort_0, string string_1)
	{
		this.gclass13_0.method_15(ushort_0, string_1);
	}

	// Token: 0x06000341 RID: 833
	protected abstract GClass9 m_3C35837C();

	// Token: 0x040001A1 RID: 417
	private GClass6 gclass6_0;

	// Token: 0x040001A2 RID: 418
	private string string_0;

	// Token: 0x040001A3 RID: 419
	private GClass13 gclass13_0;
}
