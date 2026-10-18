using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

// Token: 0x020001D4 RID: 468
internal class Class311
{
	// Token: 0x0600196F RID: 6511 RVA: 0x00011708 File Offset: 0x0000F908
	public Class311(Control3 control3_1, string string_1, int int_1)
	{
		this.Control3_0 = control3_1;
		this.String_0 = string_1;
		this.Int32_0 = int_1;
		this.Color_0 = control3_1.Color_0;
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001970 RID: 6512 RVA: 0x00011731 File Offset: 0x0000F931
	public Control3 Control3_0 { get; }

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06001971 RID: 6513 RVA: 0x00011739 File Offset: 0x0000F939
	// (set) Token: 0x06001972 RID: 6514 RVA: 0x00011741 File Offset: 0x0000F941
	public string String_0 { get; set; }

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001973 RID: 6515 RVA: 0x0001174A File Offset: 0x0000F94A
	// (set) Token: 0x06001974 RID: 6516 RVA: 0x00011752 File Offset: 0x0000F952
	public int Int32_0 { get; set; }

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001975 RID: 6517 RVA: 0x0001175B File Offset: 0x0000F95B
	// (set) Token: 0x06001976 RID: 6518 RVA: 0x00011763 File Offset: 0x0000F963
	public Color Color_0 { get; set; }

	// Token: 0x06001977 RID: 6519 RVA: 0x0001176C File Offset: 0x0000F96C
	public virtual void vmethod_0()
	{
		this.Control3_0.Class357_5.GStruct19_0 = new GStruct19(0, this.Int32_0);
		this.Control3_0.method_53(this.Control3_0.Class357_5, true);
		this.Control3_0.method_4();
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x000CE218 File Offset: 0x000CC418
	public virtual void vmethod_1(Graphics graphics_0, Rectangle rectangle_0)
	{
		int num = this.Control3_0.Int32_2 - 1;
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(0, rectangle_0.Top, num, num), Color.White, this.Color_0, 45f))
		{
			graphics_0.FillEllipse(linearGradientBrush, 0, rectangle_0.Top, num, num);
		}
		using (Pen pen = new Pen(this.Color_0))
		{
			graphics_0.DrawEllipse(pen, 0, rectangle_0.Top, num, num);
		}
	}

	// Token: 0x04001084 RID: 4228
	[CompilerGenerated]
	private readonly Control3 control3_0;

	// Token: 0x04001085 RID: 4229
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001086 RID: 4230
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001087 RID: 4231
	[CompilerGenerated]
	private Color color_0;
}
