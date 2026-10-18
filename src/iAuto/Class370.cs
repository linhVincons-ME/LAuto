using System;
using System.Drawing;

// Token: 0x02000233 RID: 563
internal class Class370 : Class369
{
	// Token: 0x06001EAB RID: 7851 RVA: 0x00014BD7 File Offset: 0x00012DD7
	public Class370(Brush brush_2, Brush brush_3, FontStyle fontStyle_1)
		: base(brush_2, brush_3, fontStyle_1)
	{
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x000E5964 File Offset: 0x000E3B64
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		if (class357_0.GStruct19_1.int_0 > class357_0.GStruct19_0.int_0)
		{
			base.m_61500534(graphics_0, point_0, class357_0);
			int num = point_0.X;
			int num2 = class357_0.GStruct19_0.int_0;
			while (num2 < class357_0.GStruct19_1.int_0 && class357_0.control3_0[class357_0.GStruct19_0.int_1][num2].char_0 == ' ')
			{
				num += class357_0.control3_0.Int32_4;
				num2++;
			}
			class357_0.control3_0.method_19(new Class389(class357_0.GStruct19_0.int_1, new Rectangle(num, point_0.Y, point_0.X + (class357_0.GStruct19_1.int_0 - class357_0.GStruct19_0.int_0) * class357_0.control3_0.Int32_4 - num, class357_0.control3_0.Int32_2)));
			return;
		}
		using (Font font = new Font(class357_0.control3_0.Font, base.FontStyle_0))
		{
			graphics_0.DrawString("...", font, base.Brush_0, (float)class357_0.control3_0.Int32_7, (float)(point_0.Y - 2));
		}
		class357_0.control3_0.method_19(new Class389(class357_0.GStruct19_0.int_1, new Rectangle(class357_0.control3_0.Int32_7 + 2, point_0.Y, 2 * class357_0.control3_0.Int32_2, class357_0.control3_0.Int32_2)));
	}
}
