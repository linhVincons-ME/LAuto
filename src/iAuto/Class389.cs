using System;
using System.Drawing;

// Token: 0x02000248 RID: 584
internal class Class389 : Class386
{
	// Token: 0x06001F7D RID: 8061 RVA: 0x00015282 File Offset: 0x00013482
	public Class389(int int_1, Rectangle rectangle_1)
		: base(rectangle_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x00015292 File Offset: 0x00013492
	public override void m_64CCB291(Graphics graphics_0, Pen pen_0)
	{
		graphics_0.DrawRectangle(pen_0, this.rectangle_0);
	}

	// Token: 0x040013D8 RID: 5080
	public readonly int int_0;
}
