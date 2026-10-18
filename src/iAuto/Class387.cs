using System;
using System.Drawing;

// Token: 0x02000246 RID: 582
internal class Class387 : Class386
{
	// Token: 0x06001F79 RID: 8057 RVA: 0x00015262 File Offset: 0x00013462
	public Class387(int int_1, Rectangle rectangle_1)
		: base(rectangle_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000E8C20 File Offset: 0x000E6E20
	public void method_0(Graphics graphics_0, Pen pen_0, Brush brush_0, Pen pen_1)
	{
		graphics_0.FillRectangle(brush_0, this.rectangle_0);
		graphics_0.DrawRectangle(pen_0, this.rectangle_0);
		graphics_0.DrawLine(pen_1, this.rectangle_0.Left + 2, this.rectangle_0.Top + this.rectangle_0.Height / 2, this.rectangle_0.Right - 2, this.rectangle_0.Top + this.rectangle_0.Height / 2);
	}

	// Token: 0x040013D6 RID: 5078
	public readonly int int_0;
}
