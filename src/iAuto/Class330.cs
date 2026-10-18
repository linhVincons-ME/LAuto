using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using _i;

// Token: 0x020001E9 RID: 489
internal class Class330
{
	// Token: 0x06001A00 RID: 6656 RVA: 0x00011D4E File Offset: 0x0000FF4E
	public Class330()
	{
		this.Boolean_1 = true;
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00011D68 File Offset: 0x0000FF68
	// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00011D70 File Offset: 0x0000FF70
	public bool Boolean_0 { get; set; }

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00011D79 File Offset: 0x0000FF79
	// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00011D81 File Offset: 0x0000FF81
	public bool Boolean_1 { get; set; }

	// Token: 0x06001A05 RID: 6661 RVA: 0x000D13A8 File Offset: 0x000CF5A8
	public string method_0(Control3 control3_1)
	{
		this.control3_0 = control3_1;
		Class357 @class = new Class357(control3_1);
		@class.method_2();
		return this.method_1(@class);
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x000D13D0 File Offset: 0x000CF5D0
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
		this.dictionary_0.Clear();
		int num2 = this.method_4(class357_0.control3_0.Color_4);
		if (this.Boolean_0)
		{
			stringBuilder2.AppendFormat("{{\\cf{1} {0}}}\\tab", num + 1, num2);
		}
		foreach (GStruct19 gstruct in ((IEnumerable<GStruct19>)class357_0))
		{
			GStruct17 gstruct2 = class357_0.control3_0[gstruct.int_1][gstruct.int_0];
			if (gstruct2.styleIndex_0 != styleIndex)
			{
				this.method_3(stringBuilder, stringBuilder2, styleIndex);
				styleIndex = gstruct2.styleIndex_0;
				dictionary[styleIndex] = null;
			}
			if (gstruct.int_1 != num)
			{
				for (int i = num; i < gstruct.int_1; i++)
				{
					stringBuilder2.AppendLine("\\line");
					if (this.Boolean_0)
					{
						stringBuilder2.AppendFormat("{{\\cf{1} {0}}}\\tab", i + 2, num2);
					}
				}
				num = gstruct.int_1;
			}
			char char_ = gstruct2.char_0;
			if (char_ != '\\')
			{
				if (char_ != '{')
				{
					if (char_ != '}')
					{
						int char_2 = (int)gstruct2.char_0;
						if (char_2 < 128)
						{
							stringBuilder2.Append(gstruct2.char_0);
						}
						else
						{
							stringBuilder2.AppendFormat("{{\\u{0}}}", char_2);
						}
					}
					else
					{
						stringBuilder2.Append("\\}");
					}
				}
				else
				{
					stringBuilder2.Append("\\{");
				}
			}
			else
			{
				stringBuilder2.Append("\\\\");
			}
		}
		this.method_3(stringBuilder, stringBuilder2, styleIndex);
		SortedList<int, Color> sortedList = new SortedList<int, Color>();
		foreach (KeyValuePair<Color, int> keyValuePair in this.dictionary_0)
		{
			sortedList.Add(keyValuePair.Value, keyValuePair.Key);
		}
		stringBuilder2.Length = 0;
		stringBuilder2.AppendFormat("{{\\colortbl;", Array.Empty<object>());
		foreach (KeyValuePair<int, Color> keyValuePair2 in sortedList)
		{
			stringBuilder2.Append(Class330.smethod_0(keyValuePair2.Value) + ";");
		}
		stringBuilder2.AppendLine("}");
		if (this.Boolean_1)
		{
			stringBuilder.Insert(0, string.Format("{{\\fonttbl{{\\f0\\fmodern {0};}}}}{{\\fs{1} ", this.control3_0.Font.Name, (int)(2f * this.control3_0.Font.SizeInPoints), this.control3_0.Int32_2));
			stringBuilder.AppendLine("}");
		}
		stringBuilder.Insert(0, stringBuilder2.ToString());
		stringBuilder.Insert(0, "{\\rtf1\\ud\\deff0");
		stringBuilder.AppendLine("}");
		return stringBuilder.ToString();
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x000D1744 File Offset: 0x000CF944
	private Class331 method_2(StyleIndex styleIndex_0)
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
		Class331 class3;
		if (!flag)
		{
			class3 = this.control3_0.Class369_0.m_E7CA5341();
		}
		else
		{
			class3 = @class.m_E7CA5341();
		}
		return class3;
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x000D180C File Offset: 0x000CFA0C
	public static string smethod_0(Color color_0)
	{
		if (color_0 == Color.Transparent)
		{
			return "";
		}
		return string.Format("\\red{0}\\green{1}\\blue{2}", color_0.R, color_0.G, color_0.B);
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x000D185C File Offset: 0x000CFA5C
	private void method_3(StringBuilder stringBuilder_0, StringBuilder stringBuilder_1, StyleIndex styleIndex_0)
	{
		if (stringBuilder_1.Length == 0)
		{
			return;
		}
		Class331 @class = this.method_2(styleIndex_0);
		int num = this.method_4(@class.Color_0);
		int num2 = this.method_4(@class.Color_1);
		StringBuilder stringBuilder = new StringBuilder();
		if (num >= 0)
		{
			stringBuilder.AppendFormat("\\cf{0}", num);
		}
		if (num2 >= 0)
		{
			stringBuilder.AppendFormat("\\highlight{0}", num2);
		}
		if (!string.IsNullOrEmpty(@class.String_0))
		{
			stringBuilder.Append(@class.String_0.Trim());
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder_0.AppendFormat("{{{0} {1}}}", stringBuilder, stringBuilder_1);
		}
		else
		{
			stringBuilder_0.Append(stringBuilder_1);
		}
		stringBuilder_1.Length = 0;
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x00011D8A File Offset: 0x0000FF8A
	private int method_4(Color color_0)
	{
		if (color_0.A == 0)
		{
			return -1;
		}
		if (!this.dictionary_0.ContainsKey(color_0))
		{
			this.dictionary_0[color_0] = this.dictionary_0.Count + 1;
		}
		return this.dictionary_0[color_0];
	}

	// Token: 0x040010BD RID: 4285
	private readonly Dictionary<Color, int> dictionary_0 = new Dictionary<Color, int>();

	// Token: 0x040010BE RID: 4286
	private Control3 control3_0;

	// Token: 0x040010BF RID: 4287
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040010C0 RID: 4288
	[CompilerGenerated]
	private bool bool_1;
}
