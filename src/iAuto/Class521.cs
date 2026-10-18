using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

// Token: 0x020002E7 RID: 743
internal class Class521
{
	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06002890 RID: 10384 RVA: 0x0001B5DF File Offset: 0x000197DF
	// (set) Token: 0x06002891 RID: 10385 RVA: 0x0001B5E6 File Offset: 0x000197E6
	public static List<Class524> List_0 { get; set; }

	// Token: 0x06002892 RID: 10386 RVA: 0x00124B14 File Offset: 0x00122D14
	public static List<Class524> smethod_0()
	{
		Class521.xmlDocument_0.LoadXml(Class616.String_1);
		List<Class524> list = new List<Class524>();
		XmlNodeList xmlNodeList = Class521.xmlDocument_0.SelectSingleNode("Scripts").SelectNodes("Script");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				list.Add(new Class524(xmlNode));
			}
		}
		Class521.List_0 = list;
		return list;
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x00124BAC File Offset: 0x00122DAC
	public static Class524 smethod_1(string string_0)
	{
		Class521.Class522 @class = new Class521.Class522();
		@class.string_0 = string_0;
		return Class521.List_0.Find(new Predicate<Class524>(@class.method_0));
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x00124BDC File Offset: 0x00122DDC
	public static Class524 smethod_2(string string_0)
	{
		Class521.Class523 @class = new Class521.Class523();
		@class.string_0 = string_0;
		return Class521.List_0.Find(new Predicate<Class524>(@class.method_0));
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x00124C0C File Offset: 0x00122E0C
	public static string smethod_3(Class524 class524_0)
	{
		XmlNodeList xmlNodeList = Class521.xmlDocument_0.SelectSingleNode("Scripts").SelectNodes("Script");
		if (xmlNodeList != null)
		{
			IEnumerator enumerator = xmlNodeList.GetEnumerator();
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Class524 @class = new Class524((XmlNode)obj);
					if (@class.String_3.Contains(class524_0.String_3) || (@class.String_0 == class524_0.String_0 && class524_0.String_0 != ""))
					{
						return "Script Đã Tồn Tại";
					}
				}
				goto IL_0098;
			}
			string text;
			return text;
		}
		IL_0098:
		Class521.xmlDocument_0.SelectSingleNode("/*").AppendChild(class524_0.XmlNode_0);
		Class521.smethod_4();
		return "";
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x0000500B File Offset: 0x0000320B
	public static void smethod_4()
	{
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x0001B5EE File Offset: 0x000197EE
	public static void smethod_5(Class524 class524_0)
	{
		Class521.xmlDocument_0.SelectSingleNode("/*").RemoveChild(class524_0.XmlNode_0);
	}

	// Token: 0x04001BAA RID: 7082
	public static XmlDocument xmlDocument_0 = new XmlDocument();

	// Token: 0x04001BAB RID: 7083
	[CompilerGenerated]
	private static List<Class524> list_0;

	// Token: 0x020002E8 RID: 744
	[CompilerGenerated]
	private sealed class Class522
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x0001B617 File Offset: 0x00019817
		internal bool method_0(Class524 class524_0)
		{
			return class524_0.String_0 == this.string_0 || class524_0.String_3.Contains(this.string_0);
		}

		// Token: 0x04001BAC RID: 7084
		public string string_0;
	}

	// Token: 0x020002E9 RID: 745
	[CompilerGenerated]
	private sealed class Class523
	{
		// Token: 0x0600289D RID: 10397 RVA: 0x0001B63F File Offset: 0x0001983F
		internal bool method_0(Class524 class524_0)
		{
			return class524_0.String_6.smethod_36() == this.string_0.smethod_36();
		}

		// Token: 0x04001BAD RID: 7085
		public string string_0;
	}
}
