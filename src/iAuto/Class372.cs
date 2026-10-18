using System;
using System.Drawing;
using System.Runtime.CompilerServices;

// Token: 0x02000235 RID: 565
internal class Class372 : Class368
{
	// Token: 0x06001EB4 RID: 7860 RVA: 0x00014C11 File Offset: 0x00012E11
	public Class372(Brush brush_1)
	{
		this.Brush_0 = brush_1;
		this.P_m_9D8BB1CB = true;
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00014C27 File Offset: 0x00012E27
	// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00014C2F File Offset: 0x00012E2F
	public Brush Brush_0 { get; set; }

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000E5C24 File Offset: 0x000E3E24
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		if (this.Brush_0 != null)
		{
			Rectangle rectangle = new Rectangle(point_0.X, point_0.Y, (class357_0.GStruct19_1.int_0 - class357_0.GStruct19_0.int_0) * class357_0.control3_0.Int32_4, class357_0.control3_0.Int32_2);
			if (rectangle.Width == 0)
			{
				return;
			}
			graphics_0.FillRectangle(this.Brush_0, rectangle);
		}
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000E5C94 File Offset: 0x000E3E94
	public override string m_D9599D06()
	{
		string text = "";
		if (this.Brush_0 is SolidBrush)
		{
			string text2 = Class329.smethod_0((this.Brush_0 as SolidBrush).Color);
			if (text2 != "")
			{
				text = text + "background-color:" + text2 + ";";
			}
		}
		return text;
	}

	// Token: 0x04001335 RID: 4917
	[CompilerGenerated]
	private Brush brush_0;
}
