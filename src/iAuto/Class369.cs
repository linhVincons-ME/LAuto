using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

// Token: 0x02000232 RID: 562
internal class Class369 : Class368
{
	// Token: 0x06001EA1 RID: 7841 RVA: 0x00014B77 File Offset: 0x00012D77
	public Class369(Brush brush_2, Brush brush_3, FontStyle fontStyle_1)
	{
		this.Brush_0 = brush_2;
		this.Brush_1 = brush_3;
		this.FontStyle_0 = fontStyle_1;
		this.stringFormat_0 = new StringFormat(StringFormatFlags.MeasureTrailingSpaces);
	}

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00014BA4 File Offset: 0x00012DA4
	// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00014BAC File Offset: 0x00012DAC
	public Brush Brush_0 { get; set; }

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00014BB5 File Offset: 0x00012DB5
	// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00014BBD File Offset: 0x00012DBD
	public Brush Brush_1 { get; set; }

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00014BC6 File Offset: 0x00012DC6
	// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x00014BCE File Offset: 0x00012DCE
	public FontStyle FontStyle_0 { get; set; }

	// Token: 0x06001EA8 RID: 7848 RVA: 0x000E5530 File Offset: 0x000E3730
	public override void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0)
	{
		if (this.Brush_1 != null)
		{
			graphics_0.FillRectangle(this.Brush_1, point_0.X, point_0.Y, (class357_0.GStruct19_1.int_0 - class357_0.GStruct19_0.int_0) * class357_0.control3_0.Int32_4, class357_0.control3_0.Int32_2);
		}
		using (Font font = new Font(class357_0.control3_0.Font, this.FontStyle_0))
		{
			Class351 @class = class357_0.control3_0[class357_0.GStruct19_0.int_1];
			float num = (float)class357_0.control3_0.Int32_4;
			float num2 = (float)(point_0.Y + class357_0.control3_0.Int32_3 / 2);
			float num3 = (float)(point_0.X - class357_0.control3_0.Int32_4 / 3);
			if (this.Brush_0 == null)
			{
				this.Brush_0 = new SolidBrush(class357_0.control3_0.ForeColor);
			}
			if (class357_0.control3_0.Boolean_25)
			{
				for (int i = class357_0.GStruct19_0.int_0; i < class357_0.GStruct19_1.int_0; i++)
				{
					SizeF sizeF = Control3.smethod_1(font, @class[i].char_0);
					GraphicsState graphicsState = graphics_0.Save();
					float num4 = ((sizeF.Width > (float)(class357_0.control3_0.Int32_4 + 1)) ? ((float)class357_0.control3_0.Int32_4 / sizeF.Width) : 1f);
					graphics_0.TranslateTransform(num3, num2 + (1f - num4) * (float)class357_0.control3_0.Int32_2 / 2f);
					graphics_0.ScaleTransform(num4, (float)Math.Sqrt((double)num4));
					GStruct17 gstruct = @class[i];
					graphics_0.DrawString(gstruct.char_0.ToString(), font, this.Brush_0, 0f, 0f, this.stringFormat_0);
					graphics_0.Restore(graphicsState);
					num3 += num;
				}
			}
			else
			{
				for (int j = class357_0.GStruct19_0.int_0; j < class357_0.GStruct19_1.int_0; j++)
				{
					GStruct17 gstruct = @class[j];
					graphics_0.DrawString(gstruct.char_0.ToString(), font, this.Brush_0, num3, num2, this.stringFormat_0);
					num3 += num;
				}
			}
		}
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000E5798 File Offset: 0x000E3998
	public override string m_D9599D06()
	{
		string text = "";
		if (this.Brush_1 is SolidBrush)
		{
			string text2 = Class329.smethod_0((this.Brush_1 as SolidBrush).Color);
			if (text2 != "")
			{
				text = text + "background-color:" + text2 + ";";
			}
		}
		if (this.Brush_0 is SolidBrush)
		{
			string text3 = Class329.smethod_0((this.Brush_0 as SolidBrush).Color);
			if (text3 != "")
			{
				text = text + "color:" + text3 + ";";
			}
		}
		if ((this.FontStyle_0 & FontStyle.Bold) != FontStyle.Regular)
		{
			text += "font-weight:bold;";
		}
		if ((this.FontStyle_0 & FontStyle.Italic) != FontStyle.Regular)
		{
			text += "font-style:oblique;";
		}
		if ((this.FontStyle_0 & FontStyle.Strikeout) != FontStyle.Regular)
		{
			text += "text-decoration:line-through;";
		}
		if ((this.FontStyle_0 & FontStyle.Underline) != FontStyle.Regular)
		{
			text += "text-decoration:underline;";
		}
		return text;
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000E5888 File Offset: 0x000E3A88
	public override Class331 m_E7CA5341()
	{
		Class331 @class = new Class331();
		if (this.Brush_1 is SolidBrush)
		{
			@class.Color_1 = (this.Brush_1 as SolidBrush).Color;
		}
		if (this.Brush_0 is SolidBrush)
		{
			@class.Color_0 = (this.Brush_0 as SolidBrush).Color;
		}
		if ((this.FontStyle_0 & FontStyle.Bold) != FontStyle.Regular)
		{
			Class331 class2 = @class;
			class2.String_0 += "\\b";
		}
		if ((this.FontStyle_0 & FontStyle.Italic) != FontStyle.Regular)
		{
			Class331 class3 = @class;
			class3.String_0 += "\\i";
		}
		if ((this.FontStyle_0 & FontStyle.Strikeout) != FontStyle.Regular)
		{
			Class331 class4 = @class;
			class4.String_0 += "\\strike";
		}
		if ((this.FontStyle_0 & FontStyle.Underline) != FontStyle.Regular)
		{
			Class331 class5 = @class;
			class5.String_0 += "\\ul";
		}
		return @class;
	}

	// Token: 0x0400132F RID: 4911
	public StringFormat stringFormat_0;

	// Token: 0x04001330 RID: 4912
	[CompilerGenerated]
	private Brush brush_0;

	// Token: 0x04001331 RID: 4913
	[CompilerGenerated]
	private Brush brush_1;

	// Token: 0x04001332 RID: 4914
	[CompilerGenerated]
	private FontStyle fontStyle_0;
}
