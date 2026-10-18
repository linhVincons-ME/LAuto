using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using _i;

// Token: 0x020001E8 RID: 488
internal class Class329
{
	// Token: 0x060019ED RID: 6637 RVA: 0x00011C8C File Offset: 0x0000FE8C
	public Class329()
	{
		this.Boolean_0 = true;
		this.Boolean_2 = true;
		this.Boolean_3 = true;
		this.Boolean_4 = true;
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x060019EE RID: 6638 RVA: 0x00011CBB File Offset: 0x0000FEBB
	// (set) Token: 0x060019EF RID: 6639 RVA: 0x00011CC3 File Offset: 0x0000FEC3
	public bool Boolean_0 { get; set; }

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00011CCC File Offset: 0x0000FECC
	// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00011CD4 File Offset: 0x0000FED4
	public bool Boolean_1 { get; set; }

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00011CDD File Offset: 0x0000FEDD
	// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00011CE5 File Offset: 0x0000FEE5
	public bool Boolean_2 { get; set; }

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00011CEE File Offset: 0x0000FEEE
	// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00011CF6 File Offset: 0x0000FEF6
	public bool Boolean_3 { get; set; }

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00011CFF File Offset: 0x0000FEFF
	// (set) Token: 0x060019F7 RID: 6647 RVA: 0x00011D07 File Offset: 0x0000FF07
	public bool Boolean_4 { get; set; }

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00011D10 File Offset: 0x0000FF10
	// (set) Token: 0x060019F9 RID: 6649 RVA: 0x00011D18 File Offset: 0x0000FF18
	public bool Boolean_5 { get; set; }

	// Token: 0x060019FA RID: 6650 RVA: 0x000D0E88 File Offset: 0x000CF088
	public string method_0(Control3 control3_1)
	{
		this.control3_0 = control3_1;
		Class357 @class = new Class357(control3_1);
		@class.method_2();
		return this.method_1(@class);
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x000D0EB0 File Offset: 0x000CF0B0
	public string method_1(Class357 class357_0)
	{
		this.control3_0 = class357_0.control3_0;
		Dictionary<StyleIndex, object> dictionary = new Dictionary<StyleIndex, object>();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		StyleIndex styleIndex = StyleIndex.None;
		class357_0.method_40();
		int num = class357_0.GStruct19_0.int_1;
		dictionary[StyleIndex.None] = null;
		if (this.Boolean_2)
		{
			stringBuilder.AppendFormat("<font style=\"font-family: {0}, monospace; font-size: {1}pt; line-height: {2}px;\">", class357_0.control3_0.Font.Name, class357_0.control3_0.Font.SizeInPoints, class357_0.control3_0.Int32_2);
		}
		if (this.Boolean_5)
		{
			stringBuilder2.AppendFormat("<span class=lineNumber>{0}</span>  ", num + 1);
		}
		bool flag = false;
		foreach (GStruct19 gstruct in ((IEnumerable<GStruct19>)class357_0))
		{
			GStruct17 gstruct2 = class357_0.control3_0[gstruct.int_1][gstruct.int_0];
			if (gstruct2.styleIndex_0 != styleIndex)
			{
				this.method_4(stringBuilder, stringBuilder2, styleIndex);
				styleIndex = gstruct2.styleIndex_0;
				dictionary[styleIndex] = null;
			}
			if (gstruct.int_1 != num)
			{
				for (int i = num; i < gstruct.int_1; i++)
				{
					stringBuilder2.Append(this.Boolean_4 ? "<br>" : "\r\n");
					if (this.Boolean_5)
					{
						stringBuilder2.AppendFormat("<span class=lineNumber>{0}</span>  ", i + 2);
					}
				}
				num = gstruct.int_1;
				flag = false;
			}
			char char_ = gstruct2.char_0;
			if (char_ <= '&')
			{
				if (char_ != ' ')
				{
					if (char_ == '&')
					{
						stringBuilder2.Append("&amp;");
						continue;
					}
				}
				else if ((!flag && this.Boolean_1) || this.Boolean_0)
				{
					stringBuilder2.Append("&nbsp;");
					continue;
				}
			}
			else
			{
				if (char_ == '<')
				{
					stringBuilder2.Append("&lt;");
					continue;
				}
				if (char_ == '>')
				{
					stringBuilder2.Append("&gt;");
					continue;
				}
			}
			flag = true;
			stringBuilder2.Append(gstruct2.char_0);
		}
		this.method_4(stringBuilder, stringBuilder2, styleIndex);
		if (this.Boolean_2)
		{
			stringBuilder.Append("</font>");
		}
		if (this.Boolean_3)
		{
			stringBuilder2.Length = 0;
			stringBuilder2.Append("<style type=\"text/css\">");
			foreach (StyleIndex styleIndex2 in dictionary.Keys)
			{
				stringBuilder2.AppendFormat(".fctb{0}{{ {1} }}\r\n", this.method_3(styleIndex2), this.method_2(styleIndex2));
			}
			stringBuilder2.Append("</style>");
			stringBuilder.Insert(0, stringBuilder2.ToString());
		}
		if (this.Boolean_5)
		{
			stringBuilder.Insert(0, this.string_0);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x000D11B4 File Offset: 0x000CF3B4
	private string method_2(StyleIndex styleIndex_0)
	{
		List<Class368> list = new List<Class368>();
		Class369 @class = null;
		int num = 1;
		bool flag = false;
		for (int i = 0; i < this.control3_0.Class368_0.Length; i++)
		{
			if (this.control3_0.Class368_0[i] != null && ((int)styleIndex_0 & num) != 0 && this.control3_0.Class368_0[i].P_m_9D8BB1CB)
			{
				Class368 class2 = this.control3_0.Class368_0[i];
				list.Add(class2);
				if (class2 is Class369 && (!flag || this.control3_0.Boolean_16))
				{
					flag = true;
					@class = class2 as Class369;
				}
			}
			num <<= 1;
		}
		string text = "";
		if (!flag)
		{
			text = this.control3_0.Class369_0.m_D9599D06();
		}
		else
		{
			text = @class.m_D9599D06();
		}
		foreach (Class368 class3 in list)
		{
			if (!(class3 is Class369))
			{
				text += class3.m_D9599D06();
			}
		}
		return text;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x000D12D8 File Offset: 0x000CF4D8
	public static string smethod_0(Color color_0)
	{
		if (color_0 == Color.Transparent)
		{
			return "";
		}
		return string.Format("#{0:x2}{1:x2}{2:x2}", color_0.R, color_0.G, color_0.B);
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x00011D21 File Offset: 0x0000FF21
	private string method_3(StyleIndex styleIndex_0)
	{
		return styleIndex_0.ToString().Replace(" ", "").Replace(",", "");
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x000D1328 File Offset: 0x000CF528
	private void method_4(StringBuilder stringBuilder_0, StringBuilder stringBuilder_1, StyleIndex styleIndex_0)
	{
		if (stringBuilder_1.Length == 0)
		{
			return;
		}
		if (this.Boolean_3)
		{
			stringBuilder_0.AppendFormat("<font class=fctb{0}>{1}</font>", this.method_3(styleIndex_0), stringBuilder_1);
		}
		else
		{
			string text = this.method_2(styleIndex_0);
			if (text != "")
			{
				stringBuilder_0.AppendFormat("<font style=\"{0}\">", text);
			}
			stringBuilder_0.Append(stringBuilder_1);
			if (text != "")
			{
				stringBuilder_0.Append("</font>");
			}
		}
		stringBuilder_1.Length = 0;
	}

	// Token: 0x040010B5 RID: 4277
	public string string_0 = "<style type=\"text/css\"> .lineNumber{font-family : monospace; font-size : small; font-style : normal; font-weight : normal; color : Teal; background-color : ThreedFace;} </style>";

	// Token: 0x040010B6 RID: 4278
	private Control3 control3_0;

	// Token: 0x040010B7 RID: 4279
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040010B8 RID: 4280
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040010B9 RID: 4281
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x040010BA RID: 4282
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x040010BB RID: 4283
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x040010BC RID: 4284
	[CompilerGenerated]
	private bool bool_5;
}
