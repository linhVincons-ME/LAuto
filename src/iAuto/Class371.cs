using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

// Token: 0x02000234 RID: 564
internal class Class371 : Class368
{
	// Token: 0x06001EAD RID: 7853 RVA: 0x00014BE2 File Offset: 0x00012DE2
	public Class371(Brush brush_2, Brush brush_3 = null)
	{
		this.Brush_0 = brush_2;
		this.Brush_1 = brush_3;
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00014BF8 File Offset: 0x00012DF8
	// (set) Token: 0x06001EAF RID: 7855 RVA: 0x00014C00 File Offset: 0x00012E00
	public Brush Brush_0 { get; set; }

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00014C09 File Offset: 0x00012E09
	public Brush Brush_1 { get; }

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00005E76 File Offset: 0x00004076
	// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x0000500B File Offset: 0x0000320B
	public override bool P_m_9D8BB1CB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x000E5AF8 File Offset: 0x000E3CF8
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		if (this.Brush_0 != null)
		{
			graphics_0.SmoothingMode = SmoothingMode.None;
			Rectangle rectangle = new Rectangle(point_0.X, point_0.Y, (class357_0.GStruct19_1.int_0 - class357_0.GStruct19_0.int_0) * class357_0.control3_0.Int32_4, class357_0.control3_0.Int32_2);
			if (rectangle.Width == 0)
			{
				return;
			}
			graphics_0.FillRectangle(this.Brush_0, rectangle);
			if (this.Brush_1 != null)
			{
				graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
				Class357 @class = new Class357(class357_0.control3_0, class357_0.GStruct19_0.int_0, class357_0.GStruct19_0.int_1, Math.Min(class357_0.control3_0[class357_0.GStruct19_1.int_1].Count, class357_0.GStruct19_1.int_0), class357_0.GStruct19_1.int_1);
				using (Class369 class2 = new Class369(this.Brush_1, null, FontStyle.Regular))
				{
					class2.m_61500534(graphics_0, new Point(point_0.X, point_0.Y - 1), @class);
				}
			}
		}
	}

	// Token: 0x04001333 RID: 4915
	[CompilerGenerated]
	private Brush brush_0;

	// Token: 0x04001334 RID: 4916
	[CompilerGenerated]
	private readonly Brush brush_1;
}
