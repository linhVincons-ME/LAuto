using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

// Token: 0x0200021E RID: 542
internal class Class355
{
	// Token: 0x06001D9E RID: 7582 RVA: 0x00014076 File Offset: 0x00012276
	internal Class355(Control3 control3_1)
	{
		this.Control3_0 = control3_1;
		this.Boolean_0 = true;
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00014097 File Offset: 0x00012297
	// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0001409F File Offset: 0x0001229F
	public bool Boolean_0 { get; set; }

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000140A8 File Offset: 0x000122A8
	// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x000140B0 File Offset: 0x000122B0
	public bool Boolean_1
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			this.Control3_0.method_4();
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000140C4 File Offset: 0x000122C4
	public Control3 Control3_0 { get; }

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000140CC File Offset: 0x000122CC
	public bool Boolean_2
	{
		get
		{
			return this.list_0.Count == 0;
		}
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000E04B0 File Offset: 0x000DE6B0
	// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x000E05B4 File Offset: 0x000DE7B4
	public string String_0
	{
		get
		{
			CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			KeysConverter keysConverter = new KeysConverter();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<macros>");
			foreach (object obj in this.list_0)
			{
				if (obj is Keys)
				{
					stringBuilder.AppendFormat("<item key='{0}' />\r\n", keysConverter.ConvertToString((Keys)obj));
				}
				else if (obj is KeyValuePair<char, Keys>)
				{
					KeyValuePair<char, Keys> keyValuePair = (KeyValuePair<char, Keys>)obj;
					stringBuilder.AppendFormat("<item char='{0}' key='{1}' />\r\n", (int)keyValuePair.Key, keysConverter.ConvertToString(keyValuePair.Value));
				}
			}
			stringBuilder.AppendLine("</macros>");
			Thread.CurrentThread.CurrentUICulture = currentUICulture;
			return stringBuilder.ToString();
		}
		set
		{
			this.bool_0 = false;
			this.method_3();
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes("./macros/item");
			CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			KeysConverter keysConverter = new KeysConverter();
			if (xmlNodeList != null)
			{
				foreach (object obj in xmlNodeList)
				{
					XmlElement xmlElement = (XmlElement)obj;
					XmlAttribute attributeNode = xmlElement.GetAttributeNode("char");
					XmlAttribute attributeNode2 = xmlElement.GetAttributeNode("key");
					if (attributeNode != null)
					{
						if (attributeNode2 != null)
						{
							this.method_1((char)int.Parse(attributeNode.Value), (Keys)keysConverter.ConvertFromString(attributeNode2.Value));
						}
						else
						{
							this.method_1((char)int.Parse(attributeNode.Value), Keys.None);
						}
					}
					else if (attributeNode2 != null)
					{
						this.method_2((Keys)keysConverter.ConvertFromString(attributeNode2.Value));
					}
				}
			}
			Thread.CurrentThread.CurrentUICulture = currentUICulture;
		}
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x000E06E4 File Offset: 0x000DE8E4
	public void method_0()
	{
		this.Boolean_1 = false;
		this.Control3_0.method_85();
		this.Control3_0.Class357_5.method_38();
		this.Control3_0.method_106();
		foreach (object obj in this.list_0)
		{
			if (obj is Keys)
			{
				this.Control3_0.vmethod_30((Keys)obj);
			}
			if (obj is KeyValuePair<char, Keys>)
			{
				KeyValuePair<char, Keys> keyValuePair = (KeyValuePair<char, Keys>)obj;
				this.Control3_0.vmethod_41(keyValuePair.Key, keyValuePair.Value);
			}
		}
		this.Control3_0.method_107();
		this.Control3_0.Class357_5.method_39();
		this.Control3_0.method_86();
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x000140DC File Offset: 0x000122DC
	public void method_1(char char_0, Keys keys_0)
	{
		this.list_0.Add(new KeyValuePair<char, Keys>(char_0, keys_0));
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x000140F5 File Offset: 0x000122F5
	public void method_2(Keys keys_0)
	{
		this.list_0.Add(keys_0);
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x00014108 File Offset: 0x00012308
	public void method_3()
	{
		this.list_0.Clear();
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x00014115 File Offset: 0x00012315
	internal void method_4(Keys keys_0)
	{
		if (this.Boolean_1)
		{
			this.method_2(keys_0);
		}
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x00014126 File Offset: 0x00012326
	internal void method_5(char char_0, Keys keys_0)
	{
		if (this.Boolean_1)
		{
			this.method_1(char_0, keys_0);
		}
	}

	// Token: 0x04001290 RID: 4752
	private readonly List<object> list_0 = new List<object>();

	// Token: 0x04001291 RID: 4753
	private bool bool_0;

	// Token: 0x04001292 RID: 4754
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04001293 RID: 4755
	[CompilerGenerated]
	private readonly Control3 control3_0;
}
