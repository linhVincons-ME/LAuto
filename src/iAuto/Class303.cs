using System;
using System.Drawing;
using System.Runtime.CompilerServices;

// Token: 0x020001C8 RID: 456
internal class Class303
{
	// Token: 0x060018B3 RID: 6323 RVA: 0x00010EB2 File Offset: 0x0000F0B2
	public Class303()
	{
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00010EC1 File Offset: 0x0000F0C1
	public Class303(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00010ED7 File Offset: 0x0000F0D7
	public Class303(string string_4, int int_1)
		: this(string_4)
	{
		this.int_0 = int_1;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00010EE7 File Offset: 0x0000F0E7
	public Class303(string string_4, int int_1, string string_5)
		: this(string_4, int_1)
	{
		this.string_0 = string_5;
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00010EF8 File Offset: 0x0000F0F8
	public Class303(string string_4, int int_1, string string_5, string string_6, string string_7)
		: this(string_4, int_1, string_5)
	{
		this.string_3 = string_6;
		this.string_2 = string_7;
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00010F13 File Offset: 0x0000F113
	// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00010F1B File Offset: 0x0000F11B
	public Class307 Class307_0 { get; internal set; }

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x060018BA RID: 6330 RVA: 0x00010F24 File Offset: 0x0000F124
	// (set) Token: 0x060018BB RID: 6331 RVA: 0x00010F2C File Offset: 0x0000F12C
	public virtual string String_0
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x060018BC RID: 6332 RVA: 0x00010F35 File Offset: 0x0000F135
	// (set) Token: 0x060018BD RID: 6333 RVA: 0x00010F3D File Offset: 0x0000F13D
	public virtual string String_1
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x060018BE RID: 6334 RVA: 0x00010F46 File Offset: 0x0000F146
	// (set) Token: 0x060018BF RID: 6335 RVA: 0x00010F4E File Offset: 0x0000F14E
	public virtual string String_2
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00010F57 File Offset: 0x0000F157
	// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00010F5E File Offset: 0x0000F15E
	public virtual Color Color_0
	{
		get
		{
			return Color.Transparent;
		}
		set
		{
			throw new NotImplementedException("Override this property to change color");
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00010F57 File Offset: 0x0000F157
	// (set) Token: 0x060018C3 RID: 6339 RVA: 0x00010F5E File Offset: 0x0000F15E
	public virtual Color Color_1
	{
		get
		{
			return Color.Transparent;
		}
		set
		{
			throw new NotImplementedException("Override this property to change color");
		}
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00010F6A File Offset: 0x0000F16A
	public virtual string m_8A4FE07C()
	{
		return this.string_1;
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00010F72 File Offset: 0x0000F172
	public virtual GEnum11 m_E27BA5A4(string string_4)
	{
		if (this.string_1.StartsWith(string_4, StringComparison.InvariantCultureIgnoreCase) && this.string_1 != string_4)
		{
			return GEnum11.VisibleAndSelected;
		}
		return GEnum11.Hidden;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00010F94 File Offset: 0x0000F194
	public override string ToString()
	{
		return this.string_0 ?? this.string_1;
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x0000500B File Offset: 0x0000320B
	public virtual void m_864A0ECA(Class307 class307_1, EventArgs1 eventArgs1_0)
	{
	}

	// Token: 0x04001053 RID: 4179
	public int int_0 = -1;

	// Token: 0x04001054 RID: 4180
	private string string_0;

	// Token: 0x04001055 RID: 4181
	public object object_0;

	// Token: 0x04001056 RID: 4182
	public string string_1;

	// Token: 0x04001057 RID: 4183
	private string string_2;

	// Token: 0x04001058 RID: 4184
	private string string_3;

	// Token: 0x04001059 RID: 4185
	[CompilerGenerated]
	private Class307 class307_0;
}
