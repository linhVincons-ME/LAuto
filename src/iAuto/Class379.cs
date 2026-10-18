using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;
using _i;

// Token: 0x0200023C RID: 572
internal class Class379 : IDisposable
{
	// Token: 0x06001EC7 RID: 7879 RVA: 0x000E5F2C File Offset: 0x000E412C
	public Class379(Control3 control3_1)
	{
		this.control3_0 = control3_1;
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00014CC0 File Offset: 0x00012EC0
	public static RegexOptions RegexOptions_0
	{
		get
		{
			if (Class379.genum20_0 == GEnum20.X86)
			{
				return RegexOptions.Compiled;
			}
			return RegexOptions.None;
		}
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000E6010 File Offset: 0x000E4210
	public void Dispose()
	{
		foreach (Class376 @class in this.dictionary_0.Values)
		{
			@class.Dispose();
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x000E6068 File Offset: 0x000E4268
	public virtual void vmethod_0(GEnum21 genum21_0, Class357 class357_0)
	{
		switch (genum21_0)
		{
		case GEnum21.CSharp:
			this.vmethod_5(class357_0);
			return;
		case GEnum21.VB:
			this.vmethod_6(class357_0);
			return;
		case GEnum21.HTML:
			this.vmethod_7(class357_0);
			return;
		case GEnum21.XML:
			this.vmethod_8(class357_0);
			return;
		case GEnum21.SQL:
			this.vmethod_9(class357_0);
			return;
		case GEnum21.PHP:
			this.vmethod_10(class357_0);
			return;
		case GEnum21.JS:
			this.vmethod_11(class357_0);
			return;
		case GEnum21.Lua:
			this.vmethod_12(class357_0);
			return;
		case GEnum21.JSON:
			this.vmethod_13(class357_0);
			return;
		default:
			return;
		}
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x000E60EC File Offset: 0x000E42EC
	public virtual void vmethod_1(string string_0, Class357 class357_0)
	{
		Class376 @class = null;
		if (!this.dictionary_0.TryGetValue(string_0, out @class))
		{
			XmlDocument xmlDocument = new XmlDocument();
			string text = string_0;
			if (!File.Exists(text))
			{
				text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(text));
			}
			xmlDocument.LoadXml(File.ReadAllText(text));
			@class = Class379.smethod_0(xmlDocument);
			this.dictionary_0[string_0] = @class;
		}
		this.method_6(@class, class357_0);
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x000E6158 File Offset: 0x000E4358
	public virtual void vmethod_2(object sender, EventArgs8 e)
	{
		switch ((sender as Control3).GEnum21_0)
		{
		case GEnum21.CSharp:
			this.method_5(sender, e);
			return;
		case GEnum21.VB:
			this.method_4(sender, e);
			return;
		case GEnum21.HTML:
			this.method_2(sender, e);
			return;
		case GEnum21.XML:
			this.method_3(sender, e);
			return;
		case GEnum21.SQL:
			this.method_1(sender, e);
			return;
		case GEnum21.PHP:
			this.method_0(sender, e);
			return;
		case GEnum21.JS:
			this.method_5(sender, e);
			return;
		case GEnum21.Lua:
			this.method_19(sender, e);
			return;
		default:
			return;
		}
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000E61E4 File Offset: 0x000E43E4
	protected void method_0(object sender, EventArgs8 e)
	{
		if (Regex.IsMatch(e.String_0, "^[^\"']*\\{.*\\}[^\"']*$"))
		{
			return;
		}
		if (Regex.IsMatch(e.String_0, "^[^\"']*\\{"))
		{
			e.Int32_3 = e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "}[^\"']*$"))
		{
			e.Int32_2 = -e.Int32_1;
			e.Int32_3 = -e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_1, "^\\s*(if|for|foreach|while|[\\}\\s]*else)\\b[^{]*$") && !Regex.IsMatch(e.String_1, "(;\\s*$)|(;\\s*//)"))
		{
			e.Int32_2 = e.Int32_1;
		}
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00014CCC File Offset: 0x00012ECC
	protected void method_1(object sender, EventArgs8 e)
	{
		(sender as Control3).vmethod_46(sender, e);
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00014CCC File Offset: 0x00012ECC
	protected void method_2(object sender, EventArgs8 e)
	{
		(sender as Control3).vmethod_46(sender, e);
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x00014CCC File Offset: 0x00012ECC
	protected void method_3(object sender, EventArgs8 e)
	{
		(sender as Control3).vmethod_46(sender, e);
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x000E6280 File Offset: 0x000E4480
	protected void method_4(object sender, EventArgs8 e)
	{
		if (Regex.IsMatch(e.String_0, "^\\s*(End|EndIf|Next|Loop)\\b", RegexOptions.IgnoreCase))
		{
			e.Int32_2 = -e.Int32_1;
			e.Int32_3 = -e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "\\b(Class|Property|Enum|Structure|Sub|Function|Namespace|Interface|Get)\\b|(Set\\s*\\()", RegexOptions.IgnoreCase))
		{
			e.Int32_3 = e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "\\b(Then)\\s*\\S+", RegexOptions.IgnoreCase))
		{
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*(If|While|For|Do|Try|With|Using|Select)\\b", RegexOptions.IgnoreCase))
		{
			e.Int32_3 = e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*(Else|ElseIf|Case|Catch|Finally)\\b", RegexOptions.IgnoreCase))
		{
			e.Int32_2 = -e.Int32_1;
			return;
		}
		if (e.String_1.TrimEnd(Array.Empty<char>()).EndsWith("_"))
		{
			e.Int32_2 = e.Int32_1;
		}
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000E6358 File Offset: 0x000E4558
	protected void method_5(object sender, EventArgs8 e)
	{
		if (Regex.IsMatch(e.String_0, "^[^\"']*\\{.*\\}[^\"']*$"))
		{
			return;
		}
		if (Regex.IsMatch(e.String_0, "^[^\"']*\\{"))
		{
			e.Int32_3 = e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "}[^\"']*$"))
		{
			e.Int32_2 = -e.Int32_1;
			e.Int32_3 = -e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*\\w+\\s*:\\s*($|//)") && !Regex.IsMatch(e.String_0, "^\\s*default\\s*:"))
		{
			e.Int32_2 = -e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*(case|default)\\b.*:\\s*($|//)"))
		{
			e.Int32_2 = -e.Int32_1 / 2;
			return;
		}
		if (Regex.IsMatch(e.String_1, "^\\s*(if|for|foreach|while|[\\}\\s]*else)\\b[^{]*$") && !Regex.IsMatch(e.String_1, "(;\\s*$)|(;\\s*//)"))
		{
			e.Int32_2 = e.Int32_1;
		}
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x000E6448 File Offset: 0x000E4648
	public virtual void vmethod_3(string string_0, XmlDocument xmlDocument_0)
	{
		Class376 @class = Class379.smethod_0(xmlDocument_0);
		this.dictionary_0[string_0] = @class;
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00014CDB File Offset: 0x00012EDB
	public virtual void vmethod_4(Class368 class368_33)
	{
		if (this.list_0.Contains(class368_33))
		{
			return;
		}
		this.control3_0.method_22();
		this.list_0.Add(class368_33);
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000E646C File Offset: 0x000E466C
	public static Class376 smethod_0(XmlDocument xmlDocument_0)
	{
		Class376 @class = new Class376();
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode("doc/brackets");
		if (xmlNode != null)
		{
			if (xmlNode.Attributes["left"] != null && xmlNode.Attributes["right"] != null && !(xmlNode.Attributes["left"].Value == "") && !(xmlNode.Attributes["right"].Value == ""))
			{
				@class.char_0 = xmlNode.Attributes["left"].Value[0];
				@class.char_2 = xmlNode.Attributes["right"].Value[0];
			}
			else
			{
				@class.char_0 = '\0';
				@class.char_2 = '\0';
			}
			if (xmlNode.Attributes["left2"] != null && xmlNode.Attributes["right2"] != null && !(xmlNode.Attributes["left2"].Value == "") && !(xmlNode.Attributes["right2"].Value == ""))
			{
				@class.char_1 = xmlNode.Attributes["left2"].Value[0];
				@class.char_3 = xmlNode.Attributes["right2"].Value[0];
			}
			else
			{
				@class.char_1 = '\0';
				@class.char_3 = '\0';
			}
			if (xmlNode.Attributes["strategy"] != null && !(xmlNode.Attributes["strategy"].Value == ""))
			{
				@class.genum15_0 = (GEnum15)Enum.Parse(typeof(GEnum15), xmlNode.Attributes["strategy"].Value);
			}
			else
			{
				@class.genum15_0 = GEnum15.Strategy2;
			}
		}
		Dictionary<string, Class368> dictionary = new Dictionary<string, Class368>();
		foreach (object obj in xmlDocument_0.SelectNodes("doc/style"))
		{
			XmlNode xmlNode2 = (XmlNode)obj;
			Class368 class2 = Class379.smethod_3(xmlNode2);
			dictionary[xmlNode2.Attributes["name"].Value] = class2;
			@class.list_2.Add(class2);
		}
		foreach (object obj2 in xmlDocument_0.SelectNodes("doc/rule"))
		{
			XmlNode xmlNode3 = (XmlNode)obj2;
			@class.list_1.Add(Class379.smethod_2(xmlNode3, dictionary));
		}
		foreach (object obj3 in xmlDocument_0.SelectNodes("doc/folding"))
		{
			XmlNode xmlNode4 = (XmlNode)obj3;
			@class.list_0.Add(Class379.smethod_1(xmlNode4));
		}
		return @class;
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000E67C0 File Offset: 0x000E49C0
	protected static Class378 smethod_1(XmlNode xmlNode_0)
	{
		Class378 @class = new Class378();
		@class.string_1 = xmlNode_0.Attributes["start"].Value;
		@class.string_0 = xmlNode_0.Attributes["finish"].Value;
		XmlAttribute xmlAttribute = xmlNode_0.Attributes["options"];
		if (xmlAttribute != null)
		{
			@class.regexOptions_0 = (RegexOptions)Enum.Parse(typeof(RegexOptions), xmlAttribute.Value);
		}
		return @class;
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000E6840 File Offset: 0x000E4A40
	protected static Class377 smethod_2(XmlNode xmlNode_0, Dictionary<string, Class368> dictionary_1)
	{
		Class377 @class = new Class377();
		@class.string_0 = xmlNode_0.InnerText;
		XmlAttribute xmlAttribute = xmlNode_0.Attributes["style"];
		XmlAttribute xmlAttribute2 = xmlNode_0.Attributes["options"];
		if (xmlAttribute == null)
		{
			throw new Exception("Rule must contain style name.");
		}
		if (!dictionary_1.ContainsKey(xmlAttribute.Value))
		{
			throw new Exception("Style '" + xmlAttribute.Value + "' is not found.");
		}
		@class.class368_0 = dictionary_1[xmlAttribute.Value];
		if (xmlAttribute2 != null)
		{
			@class.regexOptions_0 = (RegexOptions)Enum.Parse(typeof(RegexOptions), xmlAttribute2.Value);
		}
		return @class;
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x000E68F0 File Offset: 0x000E4AF0
	protected static Class368 smethod_3(XmlNode xmlNode_0)
	{
		XmlAttribute xmlAttribute = xmlNode_0.Attributes["type"];
		XmlAttribute xmlAttribute2 = xmlNode_0.Attributes["color"];
		XmlAttribute xmlAttribute3 = xmlNode_0.Attributes["backColor"];
		XmlAttribute xmlAttribute4 = xmlNode_0.Attributes["fontStyle"];
		XmlAttribute xmlAttribute5 = xmlNode_0.Attributes["name"];
		SolidBrush solidBrush = null;
		if (xmlAttribute2 != null)
		{
			solidBrush = new SolidBrush(Class379.smethod_4(xmlAttribute2.Value));
		}
		SolidBrush solidBrush2 = null;
		if (xmlAttribute3 != null)
		{
			solidBrush2 = new SolidBrush(Class379.smethod_4(xmlAttribute3.Value));
		}
		FontStyle fontStyle = FontStyle.Regular;
		if (xmlAttribute4 != null)
		{
			fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), xmlAttribute4.Value);
		}
		return new Class369(solidBrush, solidBrush2, fontStyle);
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000E69AC File Offset: 0x000E4BAC
	protected static Color smethod_4(string string_0)
	{
		if (!string_0.StartsWith("#"))
		{
			return Color.FromName(string_0);
		}
		if (string_0.Length <= 7)
		{
			return Color.FromArgb(255, Color.FromArgb(int.Parse(string_0.Substring(1), NumberStyles.AllowHexSpecifier)));
		}
		return Color.FromArgb(int.Parse(string_0.Substring(1), NumberStyles.AllowHexSpecifier));
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000E6A10 File Offset: 0x000E4C10
	public void method_6(Class376 class376_0, Class357 class357_0)
	{
		class357_0.control3_0.method_29();
		for (int i = 0; i < class376_0.list_2.Count; i++)
		{
			class357_0.control3_0.Class368_0[i] = class376_0.list_2[i];
		}
		int count = class376_0.list_2.Count;
		for (int j = 0; j < this.list_0.Count; j++)
		{
			class357_0.control3_0.Class368_0[count + j] = this.list_0[j];
		}
		char[] array = this.method_8(class357_0.control3_0);
		class357_0.control3_0.Char_1 = class376_0.char_0;
		class357_0.control3_0.Char_2 = class376_0.char_2;
		class357_0.control3_0.Char_3 = class376_0.char_1;
		class357_0.control3_0.Char_4 = class376_0.char_3;
		class357_0.method_34(class376_0.list_2.ToArray());
		foreach (Class377 @class in class376_0.list_1)
		{
			class357_0.method_20(@class.class368_0, @class.Regex_0);
		}
		class357_0.method_36();
		foreach (Class378 class2 in class376_0.list_0)
		{
			class357_0.method_26(class2.string_1, class2.string_0, class2.regexOptions_0);
		}
		this.method_7(class357_0.control3_0, array);
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00014D04 File Offset: 0x00012F04
	protected void method_7(Control3 control3_1, char[] char_0)
	{
		control3_1.Char_1 = char_0[0];
		control3_1.Char_2 = char_0[1];
		control3_1.Char_3 = char_0[2];
		control3_1.Char_4 = char_0[3];
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x00014D2A File Offset: 0x00012F2A
	protected char[] method_8(Control3 control3_1)
	{
		return new char[] { control3_1.Char_1, control3_1.Char_2, control3_1.Char_3, control3_1.Char_4 };
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000E6BB8 File Offset: 0x000E4DB8
	protected void method_9()
	{
		this.regex_7 = new Regex("\n                            # Character definitions:\n                            '\n                            (?> # disable backtracking\n                              (?:\n                                \\\\[^\\r\\n]|    # escaped meta char\n                                [^'\\r\\n]      # any character except '\n                              )*\n                            )\n                            '?\n                            |\n                            # Normal string & verbatim strings definitions:\n                            (?<verbatimIdentifier>@)?         # this group matches if it is an verbatim string\n                            \"\n                            (?> # disable backtracking\n                              (?:\n                                # match and consume an escaped character including escaped double quote (\") char\n                                (?(verbatimIdentifier)        # if it is a verbatim string ...\n                                  \"\"|                         #   then: only match an escaped double quote (\") char\n                                  \\\\.                         #   else: match an escaped sequence\n                                )\n                                | # OR\n                                # match any char except double quote char (\")\n                                [^\"]\n                              )*\n                            )\n                            \"\n                        ", RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | Class379.RegexOptions_0);
		this.regex_2 = new Regex("//.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_3 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_4 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_6 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", Class379.RegexOptions_0);
		this.regex_0 = new Regex("^\\s*(?<range>\\[.+?\\])\\s*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_1 = new Regex("\\b(class|struct|enum|interface)\\s+(?<range>\\w+?)\\b", Class379.RegexOptions_0);
		this.regex_5 = new Regex("\\b(abstract|add|alias|as|ascending|async|await|base|bool|break|by|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|descending|do|double|dynamic|else|enum|equals|event|explicit|extern|false|finally|fixed|float|for|foreach|from|get|global|goto|group|if|implicit|in|int|interface|internal|into|is|join|let|lock|long|nameof|namespace|new|null|object|on|operator|orderby|out|override|params|partial|private|protected|public|readonly|ref|remove|return|sbyte|sealed|select|set|short|sizeof|stackalloc|static|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|using|value|var|virtual|void|volatile|when|where|while|yield)\\b|#region\\b|#endregion\\b", Class379.RegexOptions_0);
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000E6C7C File Offset: 0x000E4E7C
	public void method_10(GEnum21 genum21_0)
	{
		switch (genum21_0)
		{
		case GEnum21.CSharp:
			this.Class368_0 = this.class368_4;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_7;
			this.Class368_3 = this.class368_6;
			this.Class368_4 = this.class368_3;
			this.Class368_5 = this.class368_2;
			this.Class368_6 = this.class368_5;
			return;
		case GEnum21.VB:
			this.Class368_0 = this.class368_4;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_7;
			this.Class368_4 = this.class368_3;
			this.Class368_5 = this.class368_2;
			return;
		case GEnum21.HTML:
			this.Class368_1 = this.class368_6;
			this.Class368_8 = this.class368_2;
			this.Class368_9 = this.class368_8;
			this.Class368_3 = this.class368_9;
			this.Class368_7 = this.class368_2;
			this.Class368_10 = this.class368_9;
			return;
		case GEnum21.XML:
			this.Class368_1 = this.class368_6;
			this.Class368_13 = this.class368_2;
			this.Class368_14 = this.class368_8;
			this.Class368_11 = this.class368_9;
			this.Class368_12 = this.class368_2;
			this.Class368_15 = this.class368_9;
			this.Class368_16 = this.class368_0;
			return;
		case GEnum21.SQL:
			this.Class368_0 = this.class368_9;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_7;
			this.Class368_5 = this.class368_1;
			this.Class368_20 = this.class368_1;
			this.Class368_21 = this.class368_8;
			this.Class368_17 = this.class368_8;
			this.Class368_22 = this.class368_4;
			return;
		case GEnum21.PHP:
			this.Class368_0 = this.class368_9;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_9;
			this.Class368_17 = this.class368_8;
			this.Class368_5 = this.class368_7;
			this.Class368_18 = this.class368_2;
			this.Class368_19 = this.class368_5;
			return;
		case GEnum21.JS:
			this.Class368_0 = this.class368_4;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_7;
			this.Class368_5 = this.class368_2;
			return;
		case GEnum21.Lua:
			this.Class368_0 = this.class368_4;
			this.Class368_1 = this.class368_6;
			this.Class368_2 = this.class368_7;
			this.Class368_5 = this.class368_1;
			this.Class368_21 = this.class368_8;
			return;
		case GEnum21.JSON:
			this.Class368_0 = this.class368_4;
			this.Class368_2 = this.class368_7;
			this.Class368_5 = this.class368_2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000E6F30 File Offset: 0x000E5130
	public virtual void vmethod_5(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "//";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '{';
		class357_0.control3_0.Char_4 = '}';
		class357_0.control3_0.GEnum15_0 = GEnum15.Strategy2;
		class357_0.control3_0.String_6 = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\n";
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_1, this.Class368_2, this.Class368_3, this.Class368_4, this.Class368_5 });
		if (this.regex_7 == null)
		{
			this.method_9();
		}
		class357_0.method_20(this.Class368_0, this.regex_7);
		class357_0.method_20(this.Class368_1, this.regex_2);
		class357_0.method_20(this.Class368_1, this.regex_3);
		class357_0.method_20(this.Class368_1, this.regex_4);
		class357_0.method_20(this.Class368_2, this.regex_6);
		class357_0.method_20(this.Class368_3, this.regex_0);
		class357_0.method_20(this.Class368_4, this.regex_1);
		class357_0.method_20(this.Class368_5, this.regex_5);
		foreach (Class357 @class in class357_0.method_29("^\\s*///.*$", RegexOptions.Multiline))
		{
			@class.method_35(StyleIndex.All);
			if (this.regex_16 == null)
			{
				this.method_12();
			}
			@class.method_18(this.Class368_1);
			foreach (Class357 class2 in @class.method_33(this.regex_14))
			{
				class2.method_35(StyleIndex.All);
				class2.method_18(this.Class368_6);
			}
			foreach (Class357 class3 in @class.method_29("^\\s*///", RegexOptions.Multiline))
			{
				class3.method_35(StyleIndex.All);
				class3.method_18(this.Class368_6);
			}
		}
		class357_0.method_36();
		class357_0.method_25("{", "}");
		class357_0.method_25("#region\\b", "#endregion\\b");
		class357_0.method_25("/\\*", "\\*/");
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000E71C0 File Offset: 0x000E53C0
	protected void method_11()
	{
		this.regex_57 = new Regex("\"\"|\".*?[^\\\\]\"", Class379.RegexOptions_0);
		this.regex_54 = new Regex("'.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_56 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?\\b", Class379.RegexOptions_0);
		this.regex_53 = new Regex("\\b(Class|Structure|Enum|Interface)[ ]+(?<range>\\w+?)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
		this.regex_55 = new Regex("\\b(AddHandler|AddressOf|Alias|And|AndAlso|As|Boolean|ByRef|Byte|ByVal|Call|Case|Catch|CBool|CByte|CChar|CDate|CDbl|CDec|Char|CInt|Class|CLng|CObj|Const|Continue|CSByte|CShort|CSng|CStr|CType|CUInt|CULng|CUShort|Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|Each|Else|ElseIf|End|EndIf|Enum|Erase|Error|Event|Exit|False|Finally|For|Friend|Function|Get|GetType|GetXMLNamespace|Global|GoSub|GoTo|Handles|If|Implements|Imports|In|Inherits|Integer|Interface|Is|IsNot|Let|Lib|Like|Long|Loop|Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|Namespace|Narrowing|New|Next|Not|Nothing|NotInheritable|NotOverridable|Object|Of|On|Operator|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|ParamArray|Partial|Private|Property|Protected|Public|RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|SByte|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|Then|Throw|To|True|Try|TryCast|TypeOf|UInteger|ULong|UShort|Using|Variant|Wend|When|While|Widening|With|WithEvents|WriteOnly|Xor|Region)\\b|(#Const|#Else|#ElseIf|#End|#If|#Region)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000E723C File Offset: 0x000E543C
	public virtual void vmethod_6(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "'";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '\0';
		class357_0.control3_0.Char_4 = '\0';
		class357_0.control3_0.String_6 = "\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\n";
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_1, this.Class368_2, this.Class368_4, this.Class368_5 });
		if (this.regex_57 == null)
		{
			this.method_11();
		}
		class357_0.method_20(this.Class368_0, this.regex_57);
		class357_0.method_20(this.Class368_1, this.regex_54);
		class357_0.method_20(this.Class368_2, this.regex_56);
		class357_0.method_20(this.Class368_4, this.regex_53);
		class357_0.method_20(this.Class368_5, this.regex_55);
		class357_0.method_36();
		class357_0.method_26("#Region\\b", "#End\\s+Region\\b", RegexOptions.IgnoreCase);
		class357_0.method_26("\\b(Class|Property|Enum|Structure|Interface)[ \\t]+\\S+", "\\bEnd (Class|Property|Enum|Structure|Interface)\\b", RegexOptions.IgnoreCase);
		class357_0.method_26("^\\s*(?<range>While)[ \\t]+\\S+", "^\\s*(?<range>End While)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
		class357_0.method_26("\\b(Sub|Function)[ \\t]+[^\\s']+", "\\bEnd (Sub|Function)\\b", RegexOptions.IgnoreCase);
		class357_0.method_26("(\\r|\\n|^)[ \\t]*(?<range>Get|Set)[ \\t]*(\\r|\\n|$)", "\\bEnd (Get|Set)\\b", RegexOptions.IgnoreCase);
		class357_0.method_26("^\\s*(?<range>For|For\\s+Each)\\b", "^\\s*(?<range>Next)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
		class357_0.method_26("^\\s*(?<range>Do)\\b", "^\\s*(?<range>Loop)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x000E73BC File Offset: 0x000E55BC
	protected void method_12()
	{
		this.regex_10 = new Regex("(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_11 = new Regex("(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_16 = new Regex("<|/>|</|>", Class379.RegexOptions_0);
		this.regex_15 = new Regex("<(?<range>[!\\w:]+)", Class379.RegexOptions_0);
		this.regex_12 = new Regex("</(?<range>[\\w:]+)>", Class379.RegexOptions_0);
		this.regex_14 = new Regex("<[^>]+>", Class379.RegexOptions_0);
		this.regex_8 = new Regex("(?<range>[\\w\\d\\-]{1,20}?)='[^']*'|(?<range>[\\w\\d\\-]{1,20})=\"[^\"]*\"|(?<range>[\\w\\d\\-]{1,20})=[\\w\\d\\-]{1,20}", Class379.RegexOptions_0);
		this.regex_9 = new Regex("[\\w\\d\\-]{1,20}?=(?<range>'[^']*')|[\\w\\d\\-]{1,20}=(?<range>\"[^\"]*\")|[\\w\\d\\-]{1,20}=(?<range>[\\w\\d\\-]{1,20})", Class379.RegexOptions_0);
		this.regex_13 = new Regex("\\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", Class379.RegexOptions_0 | RegexOptions.IgnoreCase);
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x000E7490 File Offset: 0x000E5690
	public virtual void vmethod_7(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = null;
		class357_0.control3_0.Char_1 = '<';
		class357_0.control3_0.Char_2 = '>';
		class357_0.control3_0.Char_3 = '(';
		class357_0.control3_0.Char_4 = ')';
		class357_0.control3_0.String_6 = "";
		class357_0.method_34(new Class368[] { this.Class368_1, this.Class368_8, this.Class368_9, this.Class368_3, this.Class368_7, this.Class368_10 });
		if (this.regex_16 == null)
		{
			this.method_12();
		}
		class357_0.method_20(this.Class368_1, this.regex_10);
		class357_0.method_20(this.Class368_1, this.regex_11);
		class357_0.method_20(this.Class368_8, this.regex_16);
		class357_0.method_20(this.Class368_9, this.regex_15);
		class357_0.method_20(this.Class368_9, this.regex_12);
		class357_0.method_20(this.Class368_3, this.regex_8);
		class357_0.method_20(this.Class368_7, this.regex_9);
		class357_0.method_20(this.Class368_10, this.regex_13);
		class357_0.method_36();
		class357_0.method_26("<head", "</head>", RegexOptions.IgnoreCase);
		class357_0.method_26("<body", "</body>", RegexOptions.IgnoreCase);
		class357_0.method_26("<table", "</table>", RegexOptions.IgnoreCase);
		class357_0.method_26("<form", "</form>", RegexOptions.IgnoreCase);
		class357_0.method_26("<div", "</div>", RegexOptions.IgnoreCase);
		class357_0.method_26("<script", "</script>", RegexOptions.IgnoreCase);
		class357_0.method_26("<tr", "</tr>", RegexOptions.IgnoreCase);
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000E764C File Offset: 0x000E584C
	protected void method_13()
	{
		this.regex_60 = new Regex("(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_61 = new Regex("(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_68 = new Regex("<\\?|</|>|<|/>|\\?>", Class379.RegexOptions_0);
		this.regex_67 = new Regex("<[?](?<range1>[x][m][l]{1})|<(?<range>[!\\w:\\-\\.]+)", Class379.RegexOptions_0);
		this.regex_63 = new Regex("</(?<range>[\\w:\\-\\.]+)>", Class379.RegexOptions_0);
		this.regex_65 = new Regex("<[^>]+>", Class379.RegexOptions_0);
		this.regex_58 = new Regex("(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*'[^']*'|(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*\"[^\"]*\"|(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*[\\w\\d\\-\\:]+", Class379.RegexOptions_0);
		this.regex_59 = new Regex("[\\w\\d\\-]+?=(?<range>'[^']*')|[\\w\\d\\-]+[ ]*=[ ]*(?<range>\"[^\"]*\")|[\\w\\d\\-]+[ ]*=[ ]*(?<range>[\\w\\d\\-]+)", Class379.RegexOptions_0);
		this.regex_64 = new Regex("\\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", Class379.RegexOptions_0 | RegexOptions.IgnoreCase);
		this.regex_62 = new Regex("<!\\s*\\[CDATA\\s*\\[(?<text>(?>[^]]+|](?!]>))*)]]>", Class379.RegexOptions_0 | RegexOptions.IgnoreCase);
		this.regex_66 = new Regex("<(?<range>/?[\\w:\\-\\.]+)\\s[^>]*?[^/]>|<(?<range>/?[\\w:\\-\\.]+)\\s*>", RegexOptions.Singleline | Class379.RegexOptions_0);
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000E7750 File Offset: 0x000E5950
	public virtual void vmethod_8(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = null;
		class357_0.control3_0.Char_1 = '<';
		class357_0.control3_0.Char_2 = '>';
		class357_0.control3_0.Char_3 = '(';
		class357_0.control3_0.Char_4 = ')';
		class357_0.control3_0.String_6 = "";
		class357_0.method_34(new Class368[] { this.Class368_1, this.Class368_13, this.Class368_14, this.Class368_11, this.Class368_12, this.Class368_15, this.Class368_16 });
		if (this.regex_68 == null)
		{
			this.method_13();
		}
		class357_0.method_20(this.Class368_16, this.regex_62);
		class357_0.method_20(this.Class368_1, this.regex_60);
		class357_0.method_20(this.Class368_1, this.regex_61);
		class357_0.method_20(this.Class368_13, this.regex_68);
		class357_0.method_20(this.Class368_14, this.regex_67);
		class357_0.method_20(this.Class368_14, this.regex_63);
		class357_0.method_20(this.Class368_11, this.regex_58);
		class357_0.method_20(this.Class368_12, this.regex_59);
		class357_0.method_20(this.Class368_15, this.regex_64);
		class357_0.method_36();
		this.method_14(class357_0);
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000E78B8 File Offset: 0x000E5AB8
	private void method_14(Class357 class357_0)
	{
		Stack<Class379.Class380> stack = new Stack<Class379.Class380>();
		int num = 0;
		Control3 control = class357_0.control3_0;
		foreach (Class357 @class in class357_0.method_33(this.regex_66))
		{
			string string_ = @class.String_1;
			int int_ = @class.GStruct19_0.int_1;
			if (string_[0] != '/')
			{
				Class379.Class380 class2 = new Class379.Class380
				{
					string_0 = string_,
					int_0 = num++,
					int_1 = @class.GStruct19_0.int_1
				};
				stack.Push(class2);
				if (string.IsNullOrEmpty(control[int_].String_0))
				{
					control[int_].String_0 = class2.String_0;
				}
			}
			else if (stack.Count > 0)
			{
				Class379.Class380 class3 = stack.Pop();
				if (int_ == class3.int_1)
				{
					if (control[int_].String_0 == class3.String_0)
					{
						control[int_].String_0 = null;
					}
				}
				else if (string.IsNullOrEmpty(control[int_].String_1))
				{
					control[int_].String_1 = class3.String_0;
				}
			}
		}
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000E7A1C File Offset: 0x000E5C1C
	protected void method_15()
	{
		this.regex_50 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", Class379.RegexOptions_0);
		this.regex_48 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?\\b", Class379.RegexOptions_0);
		this.regex_42 = new Regex("--.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_43 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_44 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_45 = new Regex("#.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_52 = new Regex("@[a-zA-Z_\\d]*\\b", Class379.RegexOptions_0);
		this.regex_49 = new Regex("\\b(ALTER APPLICATION ROLE|ALTER ASSEMBLY|ALTER ASYMMETRIC KEY|ALTER AUTHORIZATION|ALTER BROKER PRIORITY|ALTER CERTIFICATE|ALTER CREDENTIAL|ALTER CRYPTOGRAPHIC PROVIDER|ALTER DATABASE|ALTER DATABASE AUDIT SPECIFICATION|ALTER DATABASE ENCRYPTION KEY|ALTER ENDPOINT|ALTER EVENT SESSION|ALTER FULLTEXT CATALOG|ALTER FULLTEXT INDEX|ALTER FULLTEXT STOPLIST|ALTER FUNCTION|ALTER INDEX|ALTER LOGIN|ALTER MASTER KEY|ALTER MESSAGE TYPE|ALTER PARTITION FUNCTION|ALTER PARTITION SCHEME|ALTER PROCEDURE|ALTER QUEUE|ALTER REMOTE SERVICE BINDING|ALTER RESOURCE GOVERNOR|ALTER RESOURCE POOL|ALTER ROLE|ALTER ROUTE|ALTER SCHEMA|ALTER SERVER AUDIT|ALTER SERVER AUDIT SPECIFICATION|ALTER SERVICE|ALTER SERVICE MASTER KEY|ALTER SYMMETRIC KEY|ALTER TABLE|ALTER TRIGGER|ALTER USER|ALTER VIEW|ALTER WORKLOAD GROUP|ALTER XML SCHEMA COLLECTION|BULK INSERT|CREATE AGGREGATE|CREATE APPLICATION ROLE|CREATE ASSEMBLY|CREATE ASYMMETRIC KEY|CREATE BROKER PRIORITY|CREATE CERTIFICATE|CREATE CONTRACT|CREATE CREDENTIAL|CREATE CRYPTOGRAPHIC PROVIDER|CREATE DATABASE|CREATE DATABASE AUDIT SPECIFICATION|CREATE DATABASE ENCRYPTION KEY|CREATE DEFAULT|CREATE ENDPOINT|CREATE EVENT NOTIFICATION|CREATE EVENT SESSION|CREATE FULLTEXT CATALOG|CREATE FULLTEXT INDEX|CREATE FULLTEXT STOPLIST|CREATE FUNCTION|CREATE INDEX|CREATE LOGIN|CREATE MASTER KEY|CREATE MESSAGE TYPE|CREATE PARTITION FUNCTION|CREATE PARTITION SCHEME|CREATE PROCEDURE|CREATE QUEUE|CREATE REMOTE SERVICE BINDING|CREATE RESOURCE POOL|CREATE ROLE|CREATE ROUTE|CREATE RULE|CREATE SCHEMA|CREATE SERVER AUDIT|CREATE SERVER AUDIT SPECIFICATION|CREATE SERVICE|CREATE SPATIAL INDEX|CREATE STATISTICS|CREATE SYMMETRIC KEY|CREATE SYNONYM|CREATE TABLE|CREATE TRIGGER|CREATE TYPE|CREATE USER|CREATE VIEW|CREATE WORKLOAD GROUP|CREATE XML INDEX|CREATE XML SCHEMA COLLECTION|DELETE|DISABLE TRIGGER|DROP AGGREGATE|DROP APPLICATION ROLE|DROP ASSEMBLY|DROP ASYMMETRIC KEY|DROP BROKER PRIORITY|DROP CERTIFICATE|DROP CONTRACT|DROP CREDENTIAL|DROP CRYPTOGRAPHIC PROVIDER|DROP DATABASE|DROP DATABASE AUDIT SPECIFICATION|DROP DATABASE ENCRYPTION KEY|DROP DEFAULT|DROP ENDPOINT|DROP EVENT NOTIFICATION|DROP EVENT SESSION|DROP FULLTEXT CATALOG|DROP FULLTEXT INDEX|DROP FULLTEXT STOPLIST|DROP FUNCTION|DROP INDEX|DROP LOGIN|DROP MASTER KEY|DROP MESSAGE TYPE|DROP PARTITION FUNCTION|DROP PARTITION SCHEME|DROP PROCEDURE|DROP QUEUE|DROP REMOTE SERVICE BINDING|DROP RESOURCE POOL|DROP ROLE|DROP ROUTE|DROP RULE|DROP SCHEMA|DROP SERVER AUDIT|DROP SERVER AUDIT SPECIFICATION|DROP SERVICE|DROP SIGNATURE|DROP STATISTICS|DROP SYMMETRIC KEY|DROP SYNONYM|DROP TABLE|DROP TRIGGER|DROP TYPE|DROP USER|DROP VIEW|DROP WORKLOAD GROUP|DROP XML SCHEMA COLLECTION|ENABLE TRIGGER|EXEC|EXECUTE|REPLACE|FROM|INSERT|MERGE|OPTION|OUTPUT|SELECT|TOP|TRUNCATE TABLE|UPDATE|UPDATE STATISTICS|WHERE|WITH|INTO|IN|SET)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
		this.regex_47 = new Regex("\\b(ADD|ALL|AND|ANY|AS|ASC|AUTHORIZATION|BACKUP|BEGIN|BETWEEN|BREAK|BROWSE|BY|CASCADE|CHECK|CHECKPOINT|CLOSE|CLUSTERED|COLLATE|COLUMN|COMMIT|COMPUTE|CONSTRAINT|CONTAINS|CONTINUE|CROSS|CURRENT|CURRENT_DATE|CURRENT_TIME|CURSOR|DATABASE|DBCC|DEALLOCATE|DECLARE|DEFAULT|DENY|DESC|DISK|DISTINCT|DISTRIBUTED|DOUBLE|DUMP|ELSE|END|ERRLVL|ESCAPE|EXCEPT|EXISTS|EXIT|EXTERNAL|FETCH|FILE|FILLFACTOR|FOR|FOREIGN|FREETEXT|FULL|FUNCTION|GOTO|GRANT|GROUP|HAVING|HOLDLOCK|IDENTITY|IDENTITY_INSERT|IDENTITYCOL|IF|INDEX|INNER|INTERSECT|IS|JOIN|KEY|KILL|LIKE|LINENO|LOAD|NATIONAL|NOCHECK|NONCLUSTERED|NOT|NULL|OF|OFF|OFFSETS|ON|OPEN|OR|ORDER|OUTER|OVER|PERCENT|PIVOT|PLAN|PRECISION|PRIMARY|PRINT|PROC|PROCEDURE|PUBLIC|RAISERROR|READ|READTEXT|RECONFIGURE|REFERENCES|REPLICATION|RESTORE|RESTRICT|RETURN|REVERT|REVOKE|ROLLBACK|ROWCOUNT|ROWGUIDCOL|RULE|SAVE|SCHEMA|SECURITYAUDIT|SHUTDOWN|SOME|STATISTICS|TABLE|TABLESAMPLE|TEXTSIZE|THEN|TO|TRAN|TRANSACTION|TRIGGER|TSEQUAL|UNION|UNIQUE|UNPIVOT|UPDATETEXT|USE|USER|VALUES|VARYING|VIEW|WAITFOR|WHEN|WHILE|WRITETEXT)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
		this.regex_46 = new Regex("(@@CONNECTIONS|@@CPU_BUSY|@@CURSOR_ROWS|@@DATEFIRST|@@DATEFIRST|@@DBTS|@@ERROR|@@FETCH_STATUS|@@IDENTITY|@@IDLE|@@IO_BUSY|@@LANGID|@@LANGUAGE|@@LOCK_TIMEOUT|@@MAX_CONNECTIONS|@@MAX_PRECISION|@@NESTLEVEL|@@OPTIONS|@@PACKET_ERRORS|@@PROCID|@@REMSERVER|@@ROWCOUNT|@@SERVERNAME|@@SERVICENAME|@@SPID|@@TEXTSIZE|@@TRANCOUNT|@@VERSION)\\b|\\b(ABS|ACOS|APP_NAME|ASCII|ASIN|ASSEMBLYPROPERTY|AsymKey_ID|ASYMKEY_ID|asymkeyproperty|ASYMKEYPROPERTY|ATAN|ATN2|AVG|CASE|CAST|CEILING|Cert_ID|Cert_ID|CertProperty|CHAR|CHARINDEX|CHECKSUM_AGG|COALESCE|COL_LENGTH|COL_NAME|COLLATIONPROPERTY|COLLATIONPROPERTY|COLUMNPROPERTY|COLUMNS_UPDATED|COLUMNS_UPDATED|CONTAINSTABLE|CONVERT|COS|COT|COUNT|COUNT_BIG|CRYPT_GEN_RANDOM|CURRENT_TIMESTAMP|CURRENT_TIMESTAMP|CURRENT_USER|CURRENT_USER|CURSOR_STATUS|DATABASE_PRINCIPAL_ID|DATABASE_PRINCIPAL_ID|DATABASEPROPERTY|DATABASEPROPERTYEX|DATALENGTH|DATALENGTH|DATEADD|DATEDIFF|DATENAME|DATEPART|DAY|DB_ID|DB_NAME|DECRYPTBYASYMKEY|DECRYPTBYCERT|DECRYPTBYKEY|DECRYPTBYKEYAUTOASYMKEY|DECRYPTBYKEYAUTOCERT|DECRYPTBYPASSPHRASE|DEGREES|DENSE_RANK|DIFFERENCE|ENCRYPTBYASYMKEY|ENCRYPTBYCERT|ENCRYPTBYKEY|ENCRYPTBYPASSPHRASE|ERROR_LINE|ERROR_MESSAGE|ERROR_NUMBER|ERROR_PROCEDURE|ERROR_SEVERITY|ERROR_STATE|EVENTDATA|EXP|FILE_ID|FILE_IDEX|FILE_NAME|FILEGROUP_ID|FILEGROUP_NAME|FILEGROUPPROPERTY|FILEPROPERTY|FLOOR|fn_helpcollations|fn_listextendedproperty|fn_servershareddrives|fn_virtualfilestats|fn_virtualfilestats|FORMATMESSAGE|FREETEXTTABLE|FULLTEXTCATALOGPROPERTY|FULLTEXTSERVICEPROPERTY|GETANSINULL|GETDATE|GETUTCDATE|GROUPING|HAS_PERMS_BY_NAME|HOST_ID|HOST_NAME|IDENT_CURRENT|IDENT_CURRENT|IDENT_INCR|IDENT_INCR|IDENT_SEED|IDENTITY\\(|INDEX_COL|INDEXKEY_PROPERTY|INDEXPROPERTY|IS_MEMBER|IS_OBJECTSIGNED|IS_SRVROLEMEMBER|ISDATE|ISDATE|ISNULL|ISNUMERIC|Key_GUID|Key_GUID|Key_ID|Key_ID|KEY_NAME|KEY_NAME|LEFT|LEN|LOG|LOG10|LOWER|LTRIM|MAX|MIN|MONTH|NCHAR|NEWID|NTILE|NULLIF|OBJECT_DEFINITION|OBJECT_ID|OBJECT_NAME|OBJECT_SCHEMA_NAME|OBJECTPROPERTY|OBJECTPROPERTYEX|OPENDATASOURCE|OPENQUERY|OPENROWSET|OPENXML|ORIGINAL_LOGIN|ORIGINAL_LOGIN|PARSENAME|PATINDEX|PATINDEX|PERMISSIONS|PI|POWER|PUBLISHINGSERVERNAME|PWDCOMPARE|PWDENCRYPT|QUOTENAME|RADIANS|RAND|RANK|REPLICATE|REVERSE|RIGHT|ROUND|ROW_NUMBER|ROWCOUNT_BIG|RTRIM|SCHEMA_ID|SCHEMA_ID|SCHEMA_NAME|SCHEMA_NAME|SCOPE_IDENTITY|SERVERPROPERTY|SESSION_USER|SESSION_USER|SESSIONPROPERTY|SETUSER|SIGN|SignByAsymKey|SignByCert|SIN|SOUNDEX|SPACE|SQL_VARIANT_PROPERTY|SQRT|SQUARE|STATS_DATE|STDEV|STDEVP|STR|STUFF|SUBSTRING|SUM|SUSER_ID|SUSER_NAME|SUSER_SID|SUSER_SNAME|SWITCHOFFSET|SYMKEYPROPERTY|symkeyproperty|sys\\.dm_db_index_physical_stats|sys\\.fn_builtin_permissions|sys\\.fn_my_permissions|SYSDATETIME|SYSDATETIMEOFFSET|SYSTEM_USER|SYSTEM_USER|SYSUTCDATETIME|TAN|TERTIARY_WEIGHTS|TEXTPTR|TODATETIMEOFFSET|TRIGGER_NESTLEVEL|TYPE_ID|TYPE_NAME|TYPEPROPERTY|UNICODE|UPDATE\\(|UPPER|USER_ID|USER_NAME|USER_NAME|VAR|VARP|VerifySignedByAsymKey|VerifySignedByCert|XACT_STATE|YEAR)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
		this.regex_51 = new Regex("\\b(BIGINT|NUMERIC|BIT|SMALLINT|DECIMAL|SMALLMONEY|INT|TINYINT|MONEY|FLOAT|REAL|DATE|DATETIMEOFFSET|DATETIME2|SMALLDATETIME|DATETIME|TIME|CHAR|VARCHAR|TEXT|NCHAR|NVARCHAR|NTEXT|BINARY|VARBINARY|IMAGE|TIMESTAMP|HIERARCHYID|TABLE|UNIQUEIDENTIFIER|SQL_VARIANT|XML)\\b", RegexOptions.IgnoreCase | Class379.RegexOptions_0);
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000E7B24 File Offset: 0x000E5D24
	public virtual void vmethod_9(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "--";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '\0';
		class357_0.control3_0.Char_4 = '\0';
		class357_0.control3_0.String_6 = "";
		class357_0.method_34(new Class368[] { this.Class368_1, this.Class368_0, this.Class368_2, this.Class368_17, this.Class368_20, this.Class368_5, this.Class368_21, this.Class368_22 });
		if (this.regex_50 == null)
		{
			this.method_15();
		}
		class357_0.method_20(this.Class368_1, this.regex_42);
		class357_0.method_20(this.Class368_1, this.regex_43);
		class357_0.method_20(this.Class368_1, this.regex_44);
		class357_0.method_20(this.Class368_1, this.regex_45);
		class357_0.method_20(this.Class368_0, this.regex_50);
		class357_0.method_20(this.Class368_2, this.regex_48);
		class357_0.method_20(this.Class368_22, this.regex_51);
		class357_0.method_20(this.Class368_17, this.regex_52);
		class357_0.method_20(this.Class368_20, this.regex_49);
		class357_0.method_20(this.Class368_5, this.regex_47);
		class357_0.method_20(this.Class368_21, this.regex_46);
		class357_0.method_36();
		class357_0.method_26("\\bBEGIN\\b", "\\bEND\\b", RegexOptions.IgnoreCase);
		class357_0.method_25("/\\*", "\\*/");
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000E7CD4 File Offset: 0x000E5ED4
	protected void method_16()
	{
		this.regex_40 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", Class379.RegexOptions_0);
		this.regex_39 = new Regex("\\b\\d+[\\.]?\\d*\\b", Class379.RegexOptions_0);
		this.regex_33 = new Regex("(//|#).*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_34 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_35 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_41 = new Regex("\\$[a-zA-Z_\\d]*\\b", Class379.RegexOptions_0);
		this.regex_36 = new Regex("\\b(die|echo|empty|exit|eval|include|include_once|isset|list|require|require_once|return|print|unset)\\b", Class379.RegexOptions_0);
		this.regex_37 = new Regex("\\b(abstract|and|array|as|break|case|catch|cfunction|class|clone|const|continue|declare|default|do|else|elseif|enddeclare|endfor|endforeach|endif|endswitch|endwhile|extends|final|for|foreach|function|global|goto|if|implements|instanceof|interface|namespace|new|or|private|protected|public|static|switch|throw|try|use|var|while|xor)\\b", Class379.RegexOptions_0);
		this.regex_38 = new Regex("__CLASS__|__DIR__|__FILE__|__LINE__|__FUNCTION__|__METHOD__|__NAMESPACE__", Class379.RegexOptions_0);
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x000E7DA8 File Offset: 0x000E5FA8
	public virtual void vmethod_10(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "//";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '{';
		class357_0.control3_0.Char_4 = '}';
		class357_0.control3_0.GEnum15_0 = GEnum15.Strategy2;
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_1, this.Class368_2, this.Class368_17, this.Class368_5, this.Class368_18, this.Class368_19 });
		class357_0.control3_0.String_6 = "\n^\\s*\\$[\\w\\.\\[\\]\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
		if (this.regex_40 == null)
		{
			this.method_16();
		}
		class357_0.method_20(this.Class368_0, this.regex_40);
		class357_0.method_20(this.Class368_1, this.regex_33);
		class357_0.method_20(this.Class368_1, this.regex_34);
		class357_0.method_20(this.Class368_1, this.regex_35);
		class357_0.method_20(this.Class368_2, this.regex_39);
		class357_0.method_20(this.Class368_17, this.regex_41);
		class357_0.method_20(this.Class368_5, this.regex_36);
		class357_0.method_20(this.Class368_18, this.regex_37);
		class357_0.method_20(this.Class368_19, this.regex_38);
		class357_0.method_36();
		class357_0.method_25("{", "}");
		class357_0.method_25("/\\*", "\\*/");
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000E7F38 File Offset: 0x000E6138
	protected void method_17()
	{
		this.regex_22 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", Class379.RegexOptions_0);
		this.regex_17 = new Regex("//.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_18 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_19 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_21 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", Class379.RegexOptions_0);
		this.regex_20 = new Regex("\\b(true|false|break|case|catch|const|continue|default|delete|do|else|export|for|function|if|in|instanceof|new|null|return|switch|this|throw|try|var|void|while|with|typeof)\\b", Class379.RegexOptions_0);
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000E7FCC File Offset: 0x000E61CC
	public virtual void vmethod_11(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "//";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '{';
		class357_0.control3_0.Char_4 = '}';
		class357_0.control3_0.GEnum15_0 = GEnum15.Strategy2;
		class357_0.control3_0.String_6 = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_1, this.Class368_2, this.Class368_5 });
		if (this.regex_22 == null)
		{
			this.method_17();
		}
		class357_0.method_20(this.Class368_0, this.regex_22);
		class357_0.method_20(this.Class368_1, this.regex_17);
		class357_0.method_20(this.Class368_1, this.regex_18);
		class357_0.method_20(this.Class368_1, this.regex_19);
		class357_0.method_20(this.Class368_2, this.regex_21);
		class357_0.method_20(this.Class368_5, this.regex_20);
		class357_0.method_36();
		class357_0.method_25("{", "}");
		class357_0.method_25("/\\*", "\\*/");
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x000E810C File Offset: 0x000E630C
	protected void method_18()
	{
		this.regex_32 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", Class379.RegexOptions_0);
		this.regex_26 = new Regex("--.*$", RegexOptions.Multiline | Class379.RegexOptions_0);
		this.regex_27 = new Regex("(--\\[\\[.*?\\]\\])|(--\\[\\[.*)", RegexOptions.Singleline | Class379.RegexOptions_0);
		this.regex_28 = new Regex("(--\\[\\[.*?\\]\\])|(.*\\]\\])", RegexOptions.Singleline | RegexOptions.RightToLeft | Class379.RegexOptions_0);
		this.regex_31 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", Class379.RegexOptions_0);
		this.regex_30 = new Regex("\\b(and|break|do|else|elseif|end|false|for|function|if|in|local|nil|not|or|repeat|return|then|true|until|while)\\b", Class379.RegexOptions_0);
		this.regex_29 = new Regex("\\b(assert|collectgarbage|dofile|error|getfenv|getmetatable|ipairs|load|loadfile|loadstring|module|next|pairs|pcall|print|rawequal|rawget|rawset|require|select|setfenv|setmetatable|tonumber|tostring|type|unpack|xpcall)\\b", Class379.RegexOptions_0);
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x000E81B4 File Offset: 0x000E63B4
	public virtual void vmethod_12(Class357 class357_0)
	{
		class357_0.control3_0.String_1 = "--";
		class357_0.control3_0.Char_1 = '(';
		class357_0.control3_0.Char_2 = ')';
		class357_0.control3_0.Char_3 = '{';
		class357_0.control3_0.Char_4 = '}';
		class357_0.control3_0.GEnum15_0 = GEnum15.Strategy2;
		class357_0.control3_0.String_6 = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\n";
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_1, this.Class368_2, this.Class368_5, this.Class368_21 });
		if (this.regex_32 == null)
		{
			this.method_18();
		}
		class357_0.method_20(this.Class368_0, this.regex_32);
		class357_0.method_20(this.Class368_1, this.regex_26);
		class357_0.method_20(this.Class368_1, this.regex_27);
		class357_0.method_20(this.Class368_1, this.regex_28);
		class357_0.method_20(this.Class368_2, this.regex_31);
		class357_0.method_20(this.Class368_5, this.regex_30);
		class357_0.method_20(this.Class368_21, this.regex_29);
		class357_0.method_36();
		class357_0.method_25("{", "}");
		class357_0.method_25("--\\[\\[", "\\]\\]");
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x000E830C File Offset: 0x000E650C
	protected void method_19(object sender, EventArgs8 e)
	{
		if (Regex.IsMatch(e.String_0, "^\\s*(end|until)\\b"))
		{
			e.Int32_2 = -e.Int32_1;
			e.Int32_3 = -e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "\\b(then)\\s*\\S+"))
		{
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*(function|do|for|while|repeat|if)\\b"))
		{
			e.Int32_3 = e.Int32_1;
			return;
		}
		if (Regex.IsMatch(e.String_0, "^\\s*(else|elseif)\\b", RegexOptions.IgnoreCase))
		{
			e.Int32_2 = -e.Int32_1;
		}
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x000E8398 File Offset: 0x000E6598
	protected void method_20()
	{
		this.regex_25 = new Regex("\"([^\\\\\"]|\\\\\")*\"", Class379.RegexOptions_0);
		this.regex_24 = new Regex("\\b(\\d+[\\.]?\\d*|true|false|null)\\b", Class379.RegexOptions_0);
		this.regex_23 = new Regex("(?<range>\"([^\\\\\"]|\\\\\")*\")\\s*:", Class379.RegexOptions_0);
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x000E83E4 File Offset: 0x000E65E4
	public virtual void vmethod_13(Class357 class357_0)
	{
		class357_0.control3_0.Char_1 = '[';
		class357_0.control3_0.Char_2 = ']';
		class357_0.control3_0.Char_3 = '{';
		class357_0.control3_0.Char_4 = '}';
		class357_0.control3_0.GEnum15_0 = GEnum15.Strategy2;
		class357_0.control3_0.String_6 = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
		class357_0.method_34(new Class368[] { this.Class368_0, this.Class368_2, this.Class368_5 });
		if (this.regex_25 == null)
		{
			this.method_20();
		}
		class357_0.method_20(this.Class368_5, this.regex_23);
		class357_0.method_20(this.Class368_0, this.regex_25);
		class357_0.method_20(this.Class368_2, this.regex_24);
		class357_0.method_36();
		class357_0.method_25("{", "}");
		class357_0.method_25("\\[", "\\]");
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00014D56 File Offset: 0x00012F56
	// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x00014D5E File Offset: 0x00012F5E
	public Class368 Class368_0 { get; set; }

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00014D67 File Offset: 0x00012F67
	// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00014D6F File Offset: 0x00012F6F
	public Class368 Class368_1 { get; set; }

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00014D78 File Offset: 0x00012F78
	// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x00014D80 File Offset: 0x00012F80
	public Class368 Class368_2 { get; set; }

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00014D89 File Offset: 0x00012F89
	// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x00014D91 File Offset: 0x00012F91
	public Class368 Class368_3 { get; set; }

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00014D9A File Offset: 0x00012F9A
	// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00014DA2 File Offset: 0x00012FA2
	public Class368 Class368_4 { get; set; }

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00014DAB File Offset: 0x00012FAB
	// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00014DB3 File Offset: 0x00012FB3
	public Class368 Class368_5 { get; set; }

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00014DBC File Offset: 0x00012FBC
	// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00014DC4 File Offset: 0x00012FC4
	public Class368 Class368_6 { get; set; }

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00014DCD File Offset: 0x00012FCD
	// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00014DD5 File Offset: 0x00012FD5
	public Class368 Class368_7 { get; set; }

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00014DDE File Offset: 0x00012FDE
	// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00014DE6 File Offset: 0x00012FE6
	public Class368 Class368_8 { get; set; }

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00014DEF File Offset: 0x00012FEF
	// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00014DF7 File Offset: 0x00012FF7
	public Class368 Class368_9 { get; set; }

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00014E00 File Offset: 0x00013000
	// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00014E08 File Offset: 0x00013008
	public Class368 Class368_10 { get; set; }

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00014E11 File Offset: 0x00013011
	// (set) Token: 0x06001F09 RID: 7945 RVA: 0x00014E19 File Offset: 0x00013019
	public Class368 Class368_11 { get; set; }

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x06001F0A RID: 7946 RVA: 0x00014E22 File Offset: 0x00013022
	// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00014E2A File Offset: 0x0001302A
	public Class368 Class368_12 { get; set; }

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00014E33 File Offset: 0x00013033
	// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00014E3B File Offset: 0x0001303B
	public Class368 Class368_13 { get; set; }

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00014E44 File Offset: 0x00013044
	// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00014E4C File Offset: 0x0001304C
	public Class368 Class368_14 { get; set; }

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00014E55 File Offset: 0x00013055
	// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00014E5D File Offset: 0x0001305D
	public Class368 Class368_15 { get; set; }

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00014E66 File Offset: 0x00013066
	// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00014E6E File Offset: 0x0001306E
	public Class368 Class368_16 { get; set; }

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00014E77 File Offset: 0x00013077
	// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00014E7F File Offset: 0x0001307F
	public Class368 Class368_17 { get; set; }

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00014E88 File Offset: 0x00013088
	// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00014E90 File Offset: 0x00013090
	public Class368 Class368_18 { get; set; }

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00014E99 File Offset: 0x00013099
	// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00014EA1 File Offset: 0x000130A1
	public Class368 Class368_19 { get; set; }

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00014EAA File Offset: 0x000130AA
	// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00014EB2 File Offset: 0x000130B2
	public Class368 Class368_20 { get; set; }

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00014EBB File Offset: 0x000130BB
	// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00014EC3 File Offset: 0x000130C3
	public Class368 Class368_21 { get; set; }

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00014ECC File Offset: 0x000130CC
	// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00014ED4 File Offset: 0x000130D4
	public Class368 Class368_22 { get; set; }

	// Token: 0x04001347 RID: 4935
	protected static readonly GEnum20 genum20_0 = Class356.smethod_0();

	// Token: 0x04001348 RID: 4936
	public readonly Class368 class368_0 = new Class369(Brushes.Black, null, FontStyle.Regular);

	// Token: 0x04001349 RID: 4937
	public readonly Class368 class368_1 = new Class369(Brushes.Blue, null, FontStyle.Bold);

	// Token: 0x0400134A RID: 4938
	public readonly Class368 class368_2 = new Class369(Brushes.Blue, null, FontStyle.Regular);

	// Token: 0x0400134B RID: 4939
	public readonly Class368 class368_3 = new Class369(null, null, FontStyle.Bold | FontStyle.Underline);

	// Token: 0x0400134C RID: 4940
	public readonly Class368 class368_4 = new Class369(Brushes.Brown, null, FontStyle.Italic);

	// Token: 0x0400134D RID: 4941
	protected readonly Dictionary<string, Class376> dictionary_0 = new Dictionary<string, Class376>();

	// Token: 0x0400134E RID: 4942
	public readonly Class368 class368_5 = new Class369(Brushes.Gray, null, FontStyle.Regular);

	// Token: 0x0400134F RID: 4943
	public readonly Class368 class368_6 = new Class369(Brushes.Green, null, FontStyle.Italic);

	// Token: 0x04001350 RID: 4944
	public readonly Class368 class368_7 = new Class369(Brushes.Magenta, null, FontStyle.Regular);

	// Token: 0x04001351 RID: 4945
	public readonly Class368 class368_8 = new Class369(Brushes.Maroon, null, FontStyle.Regular);

	// Token: 0x04001352 RID: 4946
	public readonly Class368 class368_9 = new Class369(Brushes.Red, null, FontStyle.Regular);

	// Token: 0x04001353 RID: 4947
	protected readonly List<Class368> list_0 = new List<Class368>(5);

	// Token: 0x04001354 RID: 4948
	protected Regex regex_0;

	// Token: 0x04001355 RID: 4949
	protected Regex regex_1;

	// Token: 0x04001356 RID: 4950
	protected Regex regex_2;

	// Token: 0x04001357 RID: 4951
	protected Regex regex_3;

	// Token: 0x04001358 RID: 4952
	protected Regex regex_4;

	// Token: 0x04001359 RID: 4953
	protected Regex regex_5;

	// Token: 0x0400135A RID: 4954
	protected Regex regex_6;

	// Token: 0x0400135B RID: 4955
	protected Regex regex_7;

	// Token: 0x0400135C RID: 4956
	protected Control3 control3_0;

	// Token: 0x0400135D RID: 4957
	protected Regex regex_8;

	// Token: 0x0400135E RID: 4958
	protected Regex regex_9;

	// Token: 0x0400135F RID: 4959
	protected Regex regex_10;

	// Token: 0x04001360 RID: 4960
	protected Regex regex_11;

	// Token: 0x04001361 RID: 4961
	protected Regex regex_12;

	// Token: 0x04001362 RID: 4962
	protected Regex regex_13;

	// Token: 0x04001363 RID: 4963
	protected Regex regex_14;

	// Token: 0x04001364 RID: 4964
	protected Regex regex_15;

	// Token: 0x04001365 RID: 4965
	protected Regex regex_16;

	// Token: 0x04001366 RID: 4966
	protected Regex regex_17;

	// Token: 0x04001367 RID: 4967
	protected Regex regex_18;

	// Token: 0x04001368 RID: 4968
	protected Regex regex_19;

	// Token: 0x04001369 RID: 4969
	protected Regex regex_20;

	// Token: 0x0400136A RID: 4970
	protected Regex regex_21;

	// Token: 0x0400136B RID: 4971
	protected Regex regex_22;

	// Token: 0x0400136C RID: 4972
	protected Regex regex_23;

	// Token: 0x0400136D RID: 4973
	protected Regex regex_24;

	// Token: 0x0400136E RID: 4974
	protected Regex regex_25;

	// Token: 0x0400136F RID: 4975
	protected Regex regex_26;

	// Token: 0x04001370 RID: 4976
	protected Regex regex_27;

	// Token: 0x04001371 RID: 4977
	protected Regex regex_28;

	// Token: 0x04001372 RID: 4978
	protected Regex regex_29;

	// Token: 0x04001373 RID: 4979
	protected Regex regex_30;

	// Token: 0x04001374 RID: 4980
	protected Regex regex_31;

	// Token: 0x04001375 RID: 4981
	protected Regex regex_32;

	// Token: 0x04001376 RID: 4982
	protected Regex regex_33;

	// Token: 0x04001377 RID: 4983
	protected Regex regex_34;

	// Token: 0x04001378 RID: 4984
	protected Regex regex_35;

	// Token: 0x04001379 RID: 4985
	protected Regex regex_36;

	// Token: 0x0400137A RID: 4986
	protected Regex regex_37;

	// Token: 0x0400137B RID: 4987
	protected Regex regex_38;

	// Token: 0x0400137C RID: 4988
	protected Regex regex_39;

	// Token: 0x0400137D RID: 4989
	protected Regex regex_40;

	// Token: 0x0400137E RID: 4990
	protected Regex regex_41;

	// Token: 0x0400137F RID: 4991
	protected Regex regex_42;

	// Token: 0x04001380 RID: 4992
	protected Regex regex_43;

	// Token: 0x04001381 RID: 4993
	protected Regex regex_44;

	// Token: 0x04001382 RID: 4994
	protected Regex regex_45;

	// Token: 0x04001383 RID: 4995
	protected Regex regex_46;

	// Token: 0x04001384 RID: 4996
	protected Regex regex_47;

	// Token: 0x04001385 RID: 4997
	protected Regex regex_48;

	// Token: 0x04001386 RID: 4998
	protected Regex regex_49;

	// Token: 0x04001387 RID: 4999
	protected Regex regex_50;

	// Token: 0x04001388 RID: 5000
	protected Regex regex_51;

	// Token: 0x04001389 RID: 5001
	protected Regex regex_52;

	// Token: 0x0400138A RID: 5002
	protected Regex regex_53;

	// Token: 0x0400138B RID: 5003
	protected Regex regex_54;

	// Token: 0x0400138C RID: 5004
	protected Regex regex_55;

	// Token: 0x0400138D RID: 5005
	protected Regex regex_56;

	// Token: 0x0400138E RID: 5006
	protected Regex regex_57;

	// Token: 0x0400138F RID: 5007
	protected Regex regex_58;

	// Token: 0x04001390 RID: 5008
	protected Regex regex_59;

	// Token: 0x04001391 RID: 5009
	protected Regex regex_60;

	// Token: 0x04001392 RID: 5010
	protected Regex regex_61;

	// Token: 0x04001393 RID: 5011
	protected Regex regex_62;

	// Token: 0x04001394 RID: 5012
	protected Regex regex_63;

	// Token: 0x04001395 RID: 5013
	protected Regex regex_64;

	// Token: 0x04001396 RID: 5014
	protected Regex regex_65;

	// Token: 0x04001397 RID: 5015
	protected Regex regex_66;

	// Token: 0x04001398 RID: 5016
	protected Regex regex_67;

	// Token: 0x04001399 RID: 5017
	protected Regex regex_68;

	// Token: 0x0400139A RID: 5018
	[CompilerGenerated]
	private Class368 class368_10;

	// Token: 0x0400139B RID: 5019
	[CompilerGenerated]
	private Class368 class368_11;

	// Token: 0x0400139C RID: 5020
	[CompilerGenerated]
	private Class368 class368_12;

	// Token: 0x0400139D RID: 5021
	[CompilerGenerated]
	private Class368 class368_13;

	// Token: 0x0400139E RID: 5022
	[CompilerGenerated]
	private Class368 class368_14;

	// Token: 0x0400139F RID: 5023
	[CompilerGenerated]
	private Class368 class368_15;

	// Token: 0x040013A0 RID: 5024
	[CompilerGenerated]
	private Class368 class368_16;

	// Token: 0x040013A1 RID: 5025
	[CompilerGenerated]
	private Class368 class368_17;

	// Token: 0x040013A2 RID: 5026
	[CompilerGenerated]
	private Class368 class368_18;

	// Token: 0x040013A3 RID: 5027
	[CompilerGenerated]
	private Class368 class368_19;

	// Token: 0x040013A4 RID: 5028
	[CompilerGenerated]
	private Class368 class368_20;

	// Token: 0x040013A5 RID: 5029
	[CompilerGenerated]
	private Class368 class368_21;

	// Token: 0x040013A6 RID: 5030
	[CompilerGenerated]
	private Class368 class368_22;

	// Token: 0x040013A7 RID: 5031
	[CompilerGenerated]
	private Class368 class368_23;

	// Token: 0x040013A8 RID: 5032
	[CompilerGenerated]
	private Class368 class368_24;

	// Token: 0x040013A9 RID: 5033
	[CompilerGenerated]
	private Class368 class368_25;

	// Token: 0x040013AA RID: 5034
	[CompilerGenerated]
	private Class368 class368_26;

	// Token: 0x040013AB RID: 5035
	[CompilerGenerated]
	private Class368 class368_27;

	// Token: 0x040013AC RID: 5036
	[CompilerGenerated]
	private Class368 class368_28;

	// Token: 0x040013AD RID: 5037
	[CompilerGenerated]
	private Class368 class368_29;

	// Token: 0x040013AE RID: 5038
	[CompilerGenerated]
	private Class368 class368_30;

	// Token: 0x040013AF RID: 5039
	[CompilerGenerated]
	private Class368 class368_31;

	// Token: 0x040013B0 RID: 5040
	[CompilerGenerated]
	private Class368 class368_32;

	// Token: 0x0200023D RID: 573
	private class Class380
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00014EE9 File Offset: 0x000130E9
		public string String_0
		{
			get
			{
				return this.string_0 + this.int_0.ToString();
			}
		}

		// Token: 0x040013B1 RID: 5041
		public int int_0;

		// Token: 0x040013B2 RID: 5042
		public string string_0;

		// Token: 0x040013B3 RID: 5043
		public int int_1;
	}
}
