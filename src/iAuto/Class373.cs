using System;
using System.Drawing;

// Token: 0x02000236 RID: 566
internal class Class373 : Class368
{
	// Token: 0x06001EB9 RID: 7865 RVA: 0x00014C38 File Offset: 0x00012E38
	public Class373(Pen pen_1)
	{
		this.pen_0 = pen_1;
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000E5CEC File Offset: 0x000E3EEC
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		Point point = class357_0.control3_0.method_93(class357_0.GStruct19_1);
		Rectangle rectangle = new Rectangle(point.X - 5, point.Y + class357_0.control3_0.Int32_2 - 2, 4, 3);
		graphics_0.FillPath(Brushes.White, Class368.smethod_1(rectangle, 1));
		graphics_0.DrawPath(this.pen_0, Class368.smethod_1(rectangle, 1));
		this.vmethod_1(class357_0.control3_0, new Class390(new Rectangle(point.X - class357_0.control3_0.Int32_4, point.Y, class357_0.control3_0.Int32_4, class357_0.control3_0.Int32_2), this));
	}

	// Token: 0x04001336 RID: 4918
	public Pen pen_0;
}
