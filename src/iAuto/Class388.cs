using System;
using System.Drawing;

// Token: 0x02000247 RID: 583
internal class Class388 : Class386
{
	// Token: 0x06001F7B RID: 8059 RVA: 0x00015272 File Offset: 0x00013472
	public Class388(int int_1, Rectangle rectangle_1)
		: base(rectangle_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x000E8CB0 File Offset: 0x000E6EB0
	public void method_0(Graphics graphics_0, Pen pen_0, Brush brush_0, Pen pen_1)
	{
		graphics_0.FillRectangle(brush_0, this.rectangle_0);
		graphics_0.DrawRectangle(pen_0, this.rectangle_0);
		graphics_0.DrawLine(pen_1, this.rectangle_0.Left + 2, this.rectangle_0.Top + this.rectangle_0.Height / 2, this.rectangle_0.Right - 2, this.rectangle_0.Top + this.rectangle_0.Height / 2);
		graphics_0.DrawLine(pen_1, this.rectangle_0.Left + this.rectangle_0.Width / 2, this.rectangle_0.Top + 2, this.rectangle_0.Left + this.rectangle_0.Width / 2, this.rectangle_0.Bottom - 2);
	}

	// Token: 0x040013D7 RID: 5079
	public readonly int int_0;
}
