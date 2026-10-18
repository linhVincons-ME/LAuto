using System;

// Token: 0x02000010 RID: 16
public class GEventArgs0 : EventArgs
{
	// Token: 0x0600007D RID: 125 RVA: 0x000036B4 File Offset: 0x000018B4
	internal GEventArgs0()
	{
		this.class19_0 = Class19.class19_0;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x000036C7 File Offset: 0x000018C7
	internal GEventArgs0(ushort ushort_0)
		: this(ushort_0, null)
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000036C7 File Offset: 0x000018C7
	internal GEventArgs0(GEnum2 genum2_0)
		: this((ushort)genum2_0, null)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000036D1 File Offset: 0x000018D1
	internal GEventArgs0(Class19 class19_1)
	{
		this.class19_0 = class19_1;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000036E0 File Offset: 0x000018E0
	internal GEventArgs0(ushort ushort_0, string string_0)
	{
		this.class19_0 = new Class19(ushort_0, string_0);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000036F5 File Offset: 0x000018F5
	internal GEventArgs0(GEnum2 genum2_0, string string_0)
		: this((ushort)genum2_0, string_0)
	{
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000083 RID: 131 RVA: 0x000036FF File Offset: 0x000018FF
	internal Class19 Class19_0
	{
		get
		{
			return this.class19_0;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000084 RID: 132 RVA: 0x00003707 File Offset: 0x00001907
	public ushort UInt16_0
	{
		get
		{
			return this.class19_0.UInt16_0;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000085 RID: 133 RVA: 0x00003714 File Offset: 0x00001914
	public string String_0
	{
		get
		{
			return this.class19_0.String_0 ?? string.Empty;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000086 RID: 134 RVA: 0x0000372A File Offset: 0x0000192A
	// (set) Token: 0x06000087 RID: 135 RVA: 0x00003732 File Offset: 0x00001932
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		internal set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x0400005E RID: 94
	private bool bool_0;

	// Token: 0x0400005F RID: 95
	private Class19 class19_0;
}
