using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

// Token: 0x02000237 RID: 567
internal class Class374 : Class368
{
	// Token: 0x06001EBB RID: 7867 RVA: 0x00014C47 File Offset: 0x00012E47
	public Class374(int int_0, Color color_0)
	{
		this.Pen_0 = new Pen(Color.FromArgb(int_0, color_0));
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00014C61 File Offset: 0x00012E61
	private Pen Pen_0 { get; }

	// Token: 0x06001EBD RID: 7869 RVA: 0x000E5DA0 File Offset: 0x000E3FA0
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		Size size = Class368.smethod_0(class357_0);
		Point point = new Point(point_0.X, point_0.Y + size.Height - 1);
		Point point2 = new Point(point_0.X + size.Width, point_0.Y + size.Height - 1);
		this.method_0(graphics_0, point, point2);
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000E5E04 File Offset: 0x000E4004
	private void method_0(Graphics graphics_0, Point point_0, Point point_1)
	{
		if (point_1.X - point_0.X < 2)
		{
			graphics_0.DrawLine(this.Pen_0, point_0, point_1);
			return;
		}
		int num = -1;
		List<Point> list = new List<Point>();
		for (int i = point_0.X; i <= point_1.X; i += 2)
		{
			list.Add(new Point(i, point_0.Y + num));
			num = -num;
		}
		graphics_0.DrawLines(this.Pen_0, list.ToArray());
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x00014C69 File Offset: 0x00012E69
	public override void Dispose()
	{
		base.Dispose();
		if (this.Pen_0 != null)
		{
			this.Pen_0.Dispose();
		}
	}

	// Token: 0x04001337 RID: 4919
	[CompilerGenerated]
	private readonly Pen pen_0;
}
