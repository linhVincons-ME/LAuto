using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using _i;
using _i.Properties;

// Token: 0x02000331 RID: 817
internal partial class TabLogin : UserControl
{
	// Token: 0x06002B09 RID: 11017 RVA: 0x001356D4 File Offset: 0x001338D4
	public TabLogin()
	{
		this.InitializeComponent();
		TabLogin.List_0.Add(this);
	}

	// Token: 0x170009FA RID: 2554
	// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0001CBA7 File Offset: 0x0001ADA7
	// (set) Token: 0x06002B0B RID: 11019 RVA: 0x0001CBAF File Offset: 0x0001ADAF
	public int Int32_0 { get; set; }

	// Token: 0x170009FB RID: 2555
	// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
	// (set) Token: 0x06002B0D RID: 11021 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
	public string String_0 { get; set; }

	// Token: 0x170009FC RID: 2556
	// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0001CBC9 File Offset: 0x0001ADC9
	// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0001CBD1 File Offset: 0x0001ADD1
	public string String_1 { get; set; }

	// Token: 0x170009FD RID: 2557
	// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0001CBDA File Offset: 0x0001ADDA
	// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0001CBE2 File Offset: 0x0001ADE2
	public string String_2 { get; set; } = string.Empty;

	// Token: 0x170009FE RID: 2558
	// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0001CBEB File Offset: 0x0001ADEB
	// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0001CBF3 File Offset: 0x0001ADF3
	public string String_3 { get; set; } = string.Empty;

	// Token: 0x170009FF RID: 2559
	// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0001CBFC File Offset: 0x0001ADFC
	// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0001CC03 File Offset: 0x0001AE03
	public static List<TabLogin> List_0 { get; set; } = new List<TabLogin>();

	// Token: 0x17000A00 RID: 2560
	// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0001CC0B File Offset: 0x0001AE0B
	// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0001CC13 File Offset: 0x0001AE13
	public bool Boolean_0 { get; set; }

	// Token: 0x17000A01 RID: 2561
	// (get) Token: 0x06002B18 RID: 11032 RVA: 0x0001CC1C File Offset: 0x0001AE1C
	// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0001CC24 File Offset: 0x0001AE24
	public bool Boolean_1 { get; set; }

	// Token: 0x17000A02 RID: 2562
	// (get) Token: 0x06002B1A RID: 11034 RVA: 0x0001CC2D File Offset: 0x0001AE2D
	public IEnumerable<Class400> IEnumerable_0
	{
		get
		{
			return new HashSet<int>(this.lvLogin.SelectedIndices.Cast<int>()).Select<int, Class400>(new Func<int, Class400>(this.method_29));
		}
	}

	// Token: 0x17000A03 RID: 2563
	// (get) Token: 0x06002B1B RID: 11035 RVA: 0x0001CC55 File Offset: 0x0001AE55
	// (set) Token: 0x06002B1C RID: 11036 RVA: 0x0001CC5C File Offset: 0x0001AE5C
	public static List<Class400> List_1 { get; set; } = new List<Class400>();

	// Token: 0x17000A04 RID: 2564
	// (get) Token: 0x06002B1D RID: 11037 RVA: 0x0001CC64 File Offset: 0x0001AE64
	// (set) Token: 0x06002B1E RID: 11038 RVA: 0x0001CC6C File Offset: 0x0001AE6C
	private bool Boolean_2 { get; set; }

	// Token: 0x17000A05 RID: 2565
	// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0001CC75 File Offset: 0x0001AE75
	// (set) Token: 0x06002B20 RID: 11040 RVA: 0x0001CC7D File Offset: 0x0001AE7D
	private bool Boolean_3 { get; set; }

	// Token: 0x17000A06 RID: 2566
	// (get) Token: 0x06002B21 RID: 11041 RVA: 0x0001CC86 File Offset: 0x0001AE86
	// (set) Token: 0x06002B22 RID: 11042 RVA: 0x0001CC8E File Offset: 0x0001AE8E
	private bool Boolean_4 { get; set; }

	// Token: 0x17000A07 RID: 2567
	// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0001CC97 File Offset: 0x0001AE97
	// (set) Token: 0x06002B24 RID: 11044 RVA: 0x0001CC9F File Offset: 0x0001AE9F
	public bool Boolean_5 { get; set; }

	// Token: 0x06002B25 RID: 11045 RVA: 0x001357B4 File Offset: 0x001339B4
	public void method_0(string string_5 = null, string string_6 = null)
	{
		if (string.IsNullOrEmpty(string_5))
		{
			try
			{
				string_5 = File.ReadAllText(GUI.String_1 + "/" + this.String_2 + ".xml");
			}
			catch
			{
			}
		}
		base.Invoke(new Action(this.method_30));
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			string_5 = TabLogin.smethod_4(string_5);
			xmlDocument.LoadXml(string_5);
			this.String_0 = string_6;
			if (xmlDocument == null)
			{
				xmlDocument = TabLogin.smethod_5();
			}
			if (string.IsNullOrEmpty(this.String_1))
			{
				this.String_1 = this.method_2(xmlDocument);
			}
			List<Class400> list = this.method_3(xmlDocument, string_6);
			this.method_9(list);
			this.method_1(xmlDocument);
		}
		catch
		{
		}
		finally
		{
			base.Invoke(new Action(this.method_31));
			this.Boolean_6 = true;
		}
	}

	// Token: 0x17000A08 RID: 2568
	// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
	// (set) Token: 0x06002B27 RID: 11047 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
	public bool Boolean_6 { get; set; }

	// Token: 0x06002B28 RID: 11048 RVA: 0x001358A0 File Offset: 0x00133AA0
	private void method_1(XmlDocument xmlDocument_0)
	{
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode("Accounts/Settings");
		if (xmlNode != null)
		{
			this.numberlimit.Value = this.method_5(xmlNode, "Limit");
			this.Boolean_0 = (this.checkRelog.Checked = this.method_6(xmlNode, "ReLog"));
			this.Boolean_1 = (this.checkReset.Checked = this.method_6(xmlNode, "Reset"));
			this.Boolean_5 = (this.check0hReset.Checked = this.method_6(xmlNode, "Reset0h"));
			this.Boolean_7 = (this.checkPaused.Checked = this.method_6(xmlNode, "IsStop"));
			this.String_3 = this.method_7(xmlNode, "FakeName");
			if (!string.IsNullOrEmpty(this.String_3))
			{
				base.Invoke(new Action(this.method_32));
			}
		}
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x00135990 File Offset: 0x00133B90
	private string method_2(XmlDocument xmlDocument_0)
	{
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode("Accounts/Settings/@User");
		if (xmlNode != null)
		{
			string value = xmlNode.Value;
			if (!string.IsNullOrEmpty(value))
			{
				this.String_0 = Class106.Class210_0["iLogin", value];
			}
			return value;
		}
		return null;
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x001359D4 File Offset: 0x00133BD4
	private List<Class400> method_3(XmlDocument xmlDocument_0, string string_5)
	{
		XmlNodeList xmlNodeList = xmlDocument_0.SelectNodes("Accounts/Account");
		List<Class400> list = new List<Class400>();
		foreach (object obj in xmlNodeList)
		{
			XmlElement xmlElement = (XmlElement)obj;
			try
			{
				Class400 @class = this.method_4(xmlElement, string_5);
				list.Add(@class);
			}
			catch
			{
			}
		}
		return list;
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x00135A58 File Offset: 0x00133C58
	private Class400 method_4(XmlElement xmlElement_0, string string_5)
	{
		TabLogin.Class608 @class = new TabLogin.Class608();
		@class.xmlElement_0 = xmlElement_0;
		@class.listViewItem_0 = new ListViewItem(new string[22]);
		@class.listViewItem_0.SubItems[0].Text = (this.list_2.Count + 1).ToString();
		@class.listViewItem_0.SubItems[1].Text = @class.method_0("User");
		@class.listViewItem_0.SubItems[2].Text = @class.method_0("Name");
		@class.listViewItem_0.SubItems[6].Text = @class.method_0("Server");
		@class.listViewItem_0.SubItems[7].Text = @class.method_0("Index");
		@class.listViewItem_0.SubItems[4].Text = @class.method_0("Status");
		@class.listViewItem_0.SubItems[3].Text = @class.method_0("Lvl");
		@class.listViewItem_0.SubItems[8].Text = @class.method_0("Tag");
		@class.listViewItem_0.SubItems[5].Text = @class.method_0("Menpai");
		@class.listViewItem_0.SubItems[9].Text = @class.method_0("TaiNguyen");
		@class.listViewItem_0.SubItems[10].Text = @class.method_0("GoTo");
		@class.listViewItem_0.SubItems[11].Text = @class.method_0("BTD");
		@class.listViewItem_0.SubItems[13].Text = @class.method_0("CQ");
		@class.listViewItem_0.SubItems[12].Text = @class.method_0("HD");
		@class.listViewItem_0.SubItems[15].Text = @class.method_0("TB");
		IEnumerable<KeyValuePair<string, List<string>>> enumerable = Class226.Dictionary_2.Where<KeyValuePair<string, List<string>>>(new Func<KeyValuePair<string, List<string>>, bool>(@class.method_1));
		if (enumerable != null)
		{
			@class.listViewItem_0.SubItems[14].Text = enumerable.Select<KeyValuePair<string, List<string>>, string>(new Func<KeyValuePair<string, List<string>>, string>(TabLogin.Class589.f_99F04B36.method_0)).FirstOrDefault<string>();
		}
		else
		{
			@class.listViewItem_0.SubItems[14].Text = "...";
		}
		Class400 class2 = new Class400(@class.listViewItem_0)
		{
			String_7 = @class.method_0("Id"),
			String_8 = @class.method_0("Pass"),
			String_9 = @class.method_0("NPH"),
			String_11 = @class.method_0("Server"),
			String_22 = @class.method_0("Index"),
			String_24 = @class.method_0("Path"),
			String_10 = @class.method_0("Tail"),
			String_3 = @class.method_0("GoTo"),
			String_20 = @class.method_0("Pass2")
		};
		try
		{
			string value = @class.xmlElement_0.Attributes["Missions"].Value;
			class2.HashSet_0 = value.Split(new char[] { ',' }).Select<string, Enum17>(new Func<string, Enum17>(TabLogin.Class589.f_99F04B36.method_1)).ToHashSet<Enum17>();
		}
		catch
		{
		}
		if (!string.IsNullOrEmpty(string_5))
		{
			try
			{
				class2.String_8 = Class529.smethod_3(class2.String_8, string_5);
			}
			catch
			{
			}
		}
		return class2;
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x00135E40 File Offset: 0x00134040
	private int method_5(XmlNode xmlNode_0, string string_5)
	{
		XmlAttribute xmlAttribute = xmlNode_0.Attributes[string_5];
		int num;
		if (xmlAttribute != null && int.TryParse(xmlAttribute.Value, out num))
		{
			return num;
		}
		return 0;
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x00135E70 File Offset: 0x00134070
	private bool method_6(XmlNode xmlNode_0, string string_5)
	{
		XmlAttribute xmlAttribute = xmlNode_0.Attributes[string_5];
		bool flag;
		return xmlAttribute != null && bool.TryParse(xmlAttribute.Value, out flag) && flag;
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x00135EA0 File Offset: 0x001340A0
	private string method_7(XmlNode xmlNode_0, string string_5)
	{
		XmlAttribute xmlAttribute = xmlNode_0.Attributes[string_5];
		if (xmlAttribute != null)
		{
			return xmlAttribute.Value;
		}
		return string.Empty;
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x000EE8DC File Offset: 0x000ECADC
	public static string smethod_0(string string_5, string string_6 = null, string string_7 = null)
	{
		string text2;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.Method = "POST";
			httpWebRequest.UserAgent = string_7;
			httpWebRequest.Headers.Add("Accept-Encoding: *");
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Connection = "keepalive";
			httpWebRequest.Referer = "http://www.facebook.com/";
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebRequest.Proxy = null;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			if (string_6 != null)
			{
				StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
				streamWriter.Write(string_6);
				streamWriter.Close();
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			httpWebResponse.Close();
			text2 = text;
		}
		catch (Exception ex)
		{
			text2 = ex.Message;
		}
		return text2;
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x00135ECC File Offset: 0x001340CC
	public string method_8(string string_5 = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		stringBuilder.Append(Environment.NewLine);
		stringBuilder.Append("<Accounts>");
		stringBuilder.Append(Environment.NewLine);
		stringBuilder.Append("<Settings");
		stringBuilder.smethod_14("Limit", this.Int32_0.ToString());
		stringBuilder.smethod_14("ReLog", this.Boolean_0.ToString());
		stringBuilder.smethod_14("Reset", this.Boolean_1.ToString());
		stringBuilder.smethod_14("Reset0h", this.Boolean_5.ToString());
		stringBuilder.smethod_14("User", this.String_1);
		stringBuilder.smethod_14("IsSleep", this.bool_0.ToString());
		stringBuilder.smethod_14("IsStop", this.Boolean_7.ToString());
		if (!string.IsNullOrEmpty(this.String_3))
		{
			stringBuilder.smethod_14("FakeName", this.String_3);
		}
		else
		{
			stringBuilder.smethod_14("FakeName", this.String_2);
		}
		stringBuilder.smethod_14("ColOrder", string.Join(",", this.dictionary_0.Select<KeyValuePair<int, int>, string>(new Func<KeyValuePair<int, int>, string>(TabLogin.Class589.f_99F04B36.method_2))));
		stringBuilder.Append("/>");
		stringBuilder.Append(Environment.NewLine);
		foreach (Class400 @class in this.list_2.ToList<Class400>())
		{
			string text = @class.String_8;
			if (!string.IsNullOrEmpty(string_5))
			{
				text = Class529.smethod_2(text, string_5);
			}
			stringBuilder.Append("<Account");
			stringBuilder.smethod_14("User", @class.String_6);
			stringBuilder.smethod_14("Id", @class.String_7);
			stringBuilder.smethod_14("Pass", text);
			stringBuilder.smethod_14("Name", @class.String_17);
			stringBuilder.smethod_14("NPH", @class.String_9);
			stringBuilder.smethod_14("Server", @class.String_11);
			stringBuilder.smethod_14("Index", @class.String_22);
			if (!@class.String_21.Equals("done") && !@class.String_21.Equals("exit") && !@class.String_21.Equals("quit"))
			{
				stringBuilder.smethod_14("Status", "...");
			}
			else
			{
				stringBuilder.smethod_14("Status", @class.String_21);
			}
			stringBuilder.smethod_14("Lvl", @class.String_19);
			stringBuilder.smethod_14("Menpai", @class.String_18);
			stringBuilder.smethod_14("Tag", @class.String_23);
			stringBuilder.smethod_14("TaiNguyen", @class.String_12);
			stringBuilder.smethod_14("Path", @class.String_24);
			stringBuilder.smethod_14("Tail", @class.String_10);
			stringBuilder.smethod_14("GoTo", @class.String_3);
			stringBuilder.smethod_14("BTD", @class.String_16);
			stringBuilder.smethod_14("HD", @class.String_13);
			stringBuilder.smethod_14("CQ", @class.String_14);
			stringBuilder.smethod_14("TB", @class.String_15);
			stringBuilder.smethod_14("Missions", string.Join<int>(",", @class.HashSet_0.Cast<int>().ToArray<int>()));
			if (!string.IsNullOrEmpty(@class.String_20))
			{
				stringBuilder.smethod_14("Pass2", @class.String_20);
			}
			stringBuilder.Append("/>");
			stringBuilder.Append(Environment.NewLine);
		}
		stringBuilder.Append("</Accounts>");
		return stringBuilder.ToString();
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x001362D4 File Offset: 0x001344D4
	public void method_9(List<Class400> list_7)
	{
		int num = 1;
		using (List<Class400>.Enumerator enumerator = list_7.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class609 @class = new TabLogin.Class609();
				@class.class400_0 = enumerator.Current;
				@class.class400_0.ListViewItem_0.Text = (this.list_2.Count + num++).ToString();
				if (!string.IsNullOrEmpty(@class.class400_0.String_7))
				{
					Class106 class2 = Class106.IEnumerable_0.FirstOrDefault<Class106>(new Func<Class106, bool>(@class.method_0));
					if (class2 != null)
					{
						@class.class400_0.Class106_0 = class2;
						class2.List_17.Add(@class.class400_0);
					}
				}
			}
		}
		this.list_2.AddRange(list_7.ToArray());
		GUI.GUI_0.Invoke(new Action(this.method_33));
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x001363D0 File Offset: 0x001345D0
	public void method_10(Class400 class400_0)
	{
		this.list_2.Add(class400_0);
		class400_0.ListViewItem_0.Text = this.list_2.Count.ToString();
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x00136410 File Offset: 0x00134610
	private void menuLogin_Click(object sender, EventArgs e)
	{
		this.IEnumerable_0.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_3)).smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_4));
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x0001CCB9 File Offset: 0x0001AEB9
	private void lvLogin_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.timer_0.Interval = 100;
		this.timer_0.Start();
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x0001CCDE File Offset: 0x0001AEDE
	private void lvLogin_DoubleClick(object sender, EventArgs e)
	{
		this.Boolean_3 = false;
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_5));
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x0001CD11 File Offset: 0x0001AF11
	private void toolStripMenuItem24_Click(object sender, EventArgs e)
	{
		Task.Run(new Action(this.method_34));
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x0013646C File Offset: 0x0013466C
	private void toolStripMenuItem74_Click(object sender, EventArgs e)
	{
		TabLogin.Class610 @class = new TabLogin.Class610();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(@class.method_0));
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x001364A4 File Offset: 0x001346A4
	private void lvLogin_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			this.toolStripMenuItem24_Click(null, null);
		}
		if (e.KeyCode == Keys.Return)
		{
			this.menuLogin_Click(null, null);
		}
		if (e.KeyCode == Keys.Delete)
		{
			this.toolStripMenuItem4_Click(null, null);
		}
		if (e.Control)
		{
			if (e.KeyCode == Keys.Z)
			{
				this.menuUndoDelete_Click(null, null);
			}
			if (e.KeyCode == Keys.C)
			{
				this.toolStripMenuItem2_Click(null, null);
			}
			if (e.KeyCode == Keys.V)
			{
				this.toolStripMenuItem3_Click(null, null);
			}
			if (e.KeyCode == Keys.X)
			{
				this.toolStripMenuItem1_Click(null, null);
			}
			if (e.KeyCode == Keys.W)
			{
				this.menuRefresh_Click(null, null);
			}
			if (e.KeyCode == Keys.Up)
			{
				this.moveToTop_Click(null, null);
			}
			if (e.KeyCode == Keys.Down)
			{
				this.moveToBootom_Click(null, null);
			}
			if (e.KeyCode == Keys.Delete)
			{
				TabLogin.List_0.Remove(this);
				try
				{
					this.thread_0.Abort();
				}
				catch
				{
				}
				base.Parent.Dispose();
				Task.Run(new Action(this.method_35));
			}
		}
		if (e.KeyCode == Keys.F5)
		{
			this.menuRefresh_Click(null, null);
		}
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x001365D8 File Offset: 0x001347D8
	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		List<Class400> list = this.IEnumerable_0.ToList<Class400>();
		if (list.Count == 0)
		{
			return;
		}
		List<ValueTuple<int, Class400>> list2 = new List<ValueTuple<int, Class400>>();
		foreach (Class400 @class in list)
		{
			int num = this.list_2.IndexOf(@class);
			if (num >= 0)
			{
				list2.Add(new ValueTuple<int, Class400>(num, @class));
			}
		}
		if (list2.Count > 0)
		{
			this.stack_0.Push(list2);
		}
		this.list_2 = this.list_2.Except<Class400>(list).ToList<Class400>();
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x00136690 File Offset: 0x00134890
	private void menuUndoDelete_Click(object sender, EventArgs e)
	{
		if (this.stack_0.Count == 0)
		{
			return;
		}
		foreach (ValueTuple<int, Class400> valueTuple in this.stack_0.Pop().OrderByDescending<ValueTuple<int, Class400>, int>(new Func<ValueTuple<int, Class400>, int>(TabLogin.Class589.f_99F04B36.method_7)))
		{
			int item = valueTuple.Item1;
			Class400 item2 = valueTuple.Item2;
			int num = Math.Min(item, this.list_2.Count);
			this.list_2.Insert(num, item2);
		}
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x0001CD25 File Offset: 0x0001AF25
	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		TabLogin.List_1 = this.IEnumerable_0.ToList<Class400>();
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x00136744 File Offset: 0x00134944
	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		this.list_2 = this.list_2.Concat<Class400>(TabLogin.List_1).ToList<Class400>();
		string[] array = Clipboard.GetText().Split(new char[] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Split(new char[] { '\t' }).Length == 2)
			{
				this.method_10(new Class400(null)
				{
					String_6 = text.Split(new char[] { '\t' })[0],
					String_8 = text.Split(new char[] { '\t' })[1],
					String_11 = string.Empty,
					String_10 = string.Empty
				});
			}
		}
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x00136810 File Offset: 0x00134A10
	private void method_11(object sender, EventArgs e)
	{
		foreach (IEnumerable<Class400> enumerable in this.IEnumerable_0.ToArray<Class400>().smethod_25<Class400>(6))
		{
			TabLogin.Class590 @class = new TabLogin.Class590();
			List<string> list = enumerable.Select<Class400, string>(new Func<Class400, string>(TabLogin.Class589.f_99F04B36.method_8)).ToList<string>();
			foreach (List<string> list2 in Class226.Dictionary_2.Values)
			{
				list2.RemoveAll(new Predicate<string>(list.Contains));
			}
			TabLogin.Class590 class2 = @class;
			Class400 class3 = enumerable.FirstOrDefault<Class400>();
			class2.string_0 = ((class3 != null) ? class3.String_17 : null);
			if (@class.string_0 != null)
			{
				Class226.Dictionary_2[@class.string_0] = list;
			}
			enumerable.smethod_22<Class400>(new Action<Class400>(@class.method_0));
		}
		foreach (string text in Class226.Dictionary_2.Where<KeyValuePair<string, List<string>>>(new Func<KeyValuePair<string, List<string>>, bool>(TabLogin.Class589.f_99F04B36.method_9)).Select<KeyValuePair<string, List<string>>, string>(new Func<KeyValuePair<string, List<string>>, string>(TabLogin.Class589.f_99F04B36.method_10)).ToList<string>())
		{
			Class226.Dictionary_2.Remove(text);
		}
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x001369C8 File Offset: 0x00134BC8
	private void menuListView_Opening(object sender, CancelEventArgs e)
	{
		int num = this.IEnumerable_0.Count<Class400>();
		this.IEnumerable_0.FirstOrDefault<Class400>();
		if (Class226.Boolean_61)
		{
			this.menuThaoTac.Text = "Actions";
			this.uploadToToolStripMenuItem.Text = "Upload to";
			this.downloadFromToolStripMenuItem.Text = "Download from";
			this.moveToTop.Text = "Move to Top";
			this.moveToBootom.Text = "Move to Bottom";
			this.menuXaoTron.Text = "Shuffle List";
			this.removeDuplicate.Text = "Remove Duplicates";
		}
		if (Class226.Boolean_61)
		{
			this.menuTaoNhom.Text = string.Concat(new string[]
			{
				"Create Team [",
				(num / 6).ToString(),
				"x6 +",
				(num % 6).ToString(),
				"]"
			});
			this.menuSetNhom.Text = string.Concat(new string[]
			{
				"Set Team [",
				(num / 6).ToString(),
				"x6 +",
				(num % 6).ToString(),
				"]"
			});
		}
		else
		{
			this.menuTaoNhom.Text = string.Concat(new string[]
			{
				"Tạo Nhóm [",
				(num / 6).ToString(),
				"x6 +",
				(num % 6).ToString(),
				"]"
			});
			this.menuSetNhom.Text = string.Concat(new string[]
			{
				"Set Nhóm [",
				(num / 6).ToString(),
				"x6 +",
				(num % 6).ToString(),
				"]"
			});
		}
		this.menuRefresh.Text = "Refesh [F5 | Ctrl + W] [" + num.ToString() + "]";
		this.menuUndoDelete.Enabled = this.stack_0.Count > 0;
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x0001CD37 File Offset: 0x0001AF37
	public void method_12()
	{
		this.columnHeader_18.Text = "Menpai";
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x00136BD8 File Offset: 0x00134DD8
	private void menuRefresh_Click(object sender, EventArgs e)
	{
		foreach (Class400 @class in this.IEnumerable_0)
		{
			@class.HashSet_0.Clear();
			@class.String_3 = string.Empty;
			if (@class.Class106_0 == null)
			{
				@class.String_21 = "...";
			}
			else if (@class.Class106_0.Class527_0.Boolean_41)
			{
				@class.Class106_0.method_126();
			}
			else
			{
				@class.String_21 = "...";
				@class.Class106_0 = null;
			}
		}
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x00136C7C File Offset: 0x00134E7C
	private void moveToBootom_Click(object sender, EventArgs e)
	{
		List<Class400> list = this.IEnumerable_0.ToList<Class400>();
		this.list_2 = this.list_2.Except<Class400>(list).ToList<Class400>();
		this.list_2.AddRange(list);
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x00136CC0 File Offset: 0x00134EC0
	private void moveToTop_Click(object sender, EventArgs e)
	{
		List<Class400> list = this.IEnumerable_0.ToList<Class400>();
		this.list_2 = this.list_2.Except<Class400>(list).ToList<Class400>();
		this.list_2.InsertRange(0, list);
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x0001CD49 File Offset: 0x0001AF49
	private void lvLogin_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
	{
		if (this.list_3.Count > e.ItemIndex)
		{
			e.Item = this.list_3[e.ItemIndex].ListViewItem_0;
		}
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x00136D08 File Offset: 0x00134F08
	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		TabLogin.Class591 @class = new TabLogin.Class591();
		@class.string_0 = this.txtSearch.Text.smethod_36();
		if (string.IsNullOrEmpty(@class.string_0))
		{
			this.list_3 = this.list_2.ToList<Class400>();
		}
		else
		{
			this.list_3 = this.list_2.Where<Class400>(new Func<Class400, bool>(@class.method_0)).ToList<Class400>();
		}
		this.lvLogin.VirtualListSize = this.list_3.Count;
		if (this.lvLogin.Columns[0].Text != "...")
		{
			this.lvLogin.Columns[0].Text = this.lvLogin.VirtualListSize.ToString();
		}
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x00136DD4 File Offset: 0x00134FD4
	private void btnAddAccount_Click(object sender, EventArgs e)
	{
		this.method_10(new Class400(null)
		{
			String_6 = this.TxtUser.Text,
			String_8 = this.TxtPass.Text,
			String_11 = string.Empty,
			String_10 = string.Empty
		});
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x00136E28 File Offset: 0x00135028
	private void method_13(object sender, EventArgs e)
	{
		Class400 @class = this.IEnumerable_0.FirstOrDefault<Class400>();
		if (@class != null)
		{
			@class.String_6 = this.TxtUser.Text;
			@class.String_8 = this.TxtPass.Text;
		}
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x0001CD7A File Offset: 0x0001AF7A
	private void TxtPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.btnAddAccount_Click(null, null);
		}
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x0001CD8E File Offset: 0x0001AF8E
	private void chkShowPass_CheckedChanged(object sender, EventArgs e)
	{
		this.TxtPass.PasswordChar = (this.chkShowPass.Checked ? '\0' : '*');
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x00136E68 File Offset: 0x00135068
	private void lvLogin_ColumnReordered(object sender, ColumnReorderedEventArgs e)
	{
		this.dictionary_0.Clear();
		foreach (object obj in this.lvLogin.Columns)
		{
			ColumnHeader columnHeader = (ColumnHeader)obj;
			this.dictionary_0.Add(columnHeader.Index, columnHeader.DisplayIndex);
		}
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x00136EE4 File Offset: 0x001350E4
	public void method_14()
	{
		try
		{
			if (this.lvLogin.Columns[0].Text != "...")
			{
				this.lvLogin.Columns[0].Text = this.list_3.Count.ToString();
			}
			int num = this.list_2.Count<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_11));
			int num2 = this.list_2.Count<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_12));
			this.lvLogin.Columns[4].Text = string.Format("[{0}/{1}]", num2, num);
			if (this.Boolean_5 && DateTime.Now.Hour == 0 && DateTime.Now.Minute < 1)
			{
				this.list_2.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_13)).smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_14));
			}
			else
			{
				if (this.stopwatch_1.Elapsed.TotalMinutes > 1.0)
				{
					this.stopwatch_1 = Stopwatch.StartNew();
					if (this.Boolean_1)
					{
						if (!this.list_2.Any<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_15)))
						{
							this.list_2.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_16)).smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_17));
						}
					}
				}
				try
				{
					using (IEnumerator<Class400> enumerator = this.list_2.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_18)).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							TabLogin.Class592 @class = new TabLogin.Class592();
							@class.class400_0 = enumerator.Current;
							Class106 class106_ = @class.class400_0.Class106_0;
							if (class106_.Process_0.HasExited)
							{
								@class.class400_0.Boolean_1 = false;
								@class.class400_0.Boolean_2 = false;
								@class.class400_0.Class106_0 = null;
								if (class106_.Boolean_10)
								{
									@class.class400_0.String_21 = "done";
								}
								else if (class106_.Class264_0.Boolean_32)
								{
									@class.class400_0.String_21 = "quit";
								}
								else if (!this.Boolean_0 && !class106_.Class264_0.Boolean_7)
								{
									@class.class400_0.String_21 = "exit";
								}
								else
								{
									@class.class400_0.String_21 = "wait";
								}
							}
							else
							{
								if (class106_.Class527_0.Boolean_43)
								{
									class106_.Class512_0.method_29();
								}
								if (class106_.Class527_0.Boolean_12)
								{
									@class.class400_0.Boolean_2 = false;
									@class.class400_0.Boolean_0 = false;
									if (class106_.Class264_0.Boolean_32)
									{
										class106_.Class264_0.Boolean_32 = false;
										@class.class400_0.Class106_0.List_17.Remove(@class.class400_0);
										@class.class400_0.Class106_0 = null;
										@class.class400_0.String_21 = "quit";
										continue;
									}
									if (@class.class400_0.Boolean_1 && !this.Boolean_0)
									{
										@class.class400_0.Boolean_1 = false;
										@class.class400_0.String_21 = "select";
										@class.class400_0.Boolean_2 = false;
										@class.class400_0.Class106_0.List_17.Remove(@class.class400_0);
										@class.class400_0.Class106_0 = null;
										continue;
									}
									if (@class.class400_0.Int32_0 != -1)
									{
										if (@class.class400_0.String_11.Equals("Ngũ Tuyệt - Thánh Hỏa"))
										{
											class106_.method_303(@class.class400_0.Int32_0);
										}
										else
										{
											class106_.method_302(@class.class400_0.Int32_0, 0);
										}
									}
									else
									{
										class106_.method_493("Wrong Server. Plz Select valid Server");
									}
								}
								if (class106_.Class527_0.Boolean_36)
								{
									if (!@class.class400_0.Boolean_0)
									{
										@class.class400_0.Boolean_0 = true;
										if (@class.class400_0.String_10.smethod_26() > 0)
										{
											class106_.Class512_0.method_22(@class.class400_0.String_10.smethod_26() - 1);
										}
										class106_.method_295(@class.class400_0.String_6, @class.class400_0.String_8);
									}
								}
								else
								{
									@class.class400_0.Boolean_0 = false;
								}
								if (class106_.Class527_0.Boolean_38)
								{
									if (Class226.Boolean_128 && @class.class400_0.Stopwatch_1.Elapsed.TotalSeconds > 20.0)
									{
										string text = Class531.smethod_25(Class531.Random_0.Next(3, 5)) + Class531.smethod_25(Class531.Random_0.Next(3, 5));
										if (Class226.Boolean_113)
										{
											text = Class587.smethod_7();
										}
										@class.class400_0.Stopwatch_1 = Stopwatch.StartNew();
										string text2 = "setmetatable(_G, {__index = LoginCreateRole_Env}); if this:IsVisible() then GameProduceLogin:SetFaceId(0, 2); GameProduceLogin:CreateRole('" + text + "',0) end";
										if (class106_.Class502_0.Int32_5 == 1 || class106_.Boolean_66)
										{
											text2 = "setmetatable(_G, {__index = LoginCreateRole_Env}); if this:IsVisible() then GameProduceLogin:SetFaceId(0, 1); GameProduceLogin:CreateRole('" + text + "',0, -1, -1) end";
										}
										class106_.method_375(text2, false);
									}
								}
								else if (class106_.Class527_0.Boolean_37 && @class.class400_0.Stopwatch_0.Elapsed.TotalSeconds > 10.0 && class106_.Class0_0.Stopwatch_5.Elapsed.TotalSeconds > 3.0)
								{
									@class.class400_0.Stopwatch_0 = Stopwatch.StartNew();
									class106_.method_301(@class.class400_0.String_22.smethod_26());
								}
								if (class106_.Class527_0.Boolean_41)
								{
									if (class106_.Boolean_63)
									{
										if (class106_.String_10.Length >= 4)
										{
											@class.class400_0.String_20 = class106_.String_10;
										}
										if (@class.class400_0.String_20.Length >= 4 && string.IsNullOrEmpty(class106_.String_10))
										{
											class106_.String_10 = @class.class400_0.String_20;
										}
									}
									@class.class400_0.Boolean_1 = true;
									@class.class400_0.String_16 = class106_.Int32_59.ToString();
									if (@class.class400_0.String_3 != string.Empty)
									{
										@class.class400_0.Class106_0.String_23 = @class.class400_0.String_3;
									}
									@class.class400_0.String_7 = class106_.String_29;
									@class.class400_0.String_17 = class106_.Class527_0.String_11;
									@class.class400_0.String_19 = class106_.Class527_0.Int32_50.ToString();
									@class.class400_0.String_12 = (class106_.Class527_0.Int32_19 / 10000).ToString() + "v";
									@class.class400_0.String_13 = class106_.Class527_0.Int32_18.ToString();
									@class.class400_0.String_14 = class106_.Class527_0.Int32_24.ToString();
									@class.class400_0.String_18 = class106_.Class527_0.String_9;
									@class.class400_0.String_15 = class106_.Class527_0.Int32_53.smethod_6().ToString();
									if (class106_.Class527_0.Int32_53 <= 0)
									{
										@class.class400_0.String_15 = class106_.Class527_0.Int32_8.smethod_6().ToString();
									}
									if (class106_.Boolean_63 && !@class.class400_0.Boolean_2)
									{
										@class.class400_0.Boolean_2 = true;
										if (@class.class400_0.HashSet_0.Any<Enum17>())
										{
											@class.class400_0.Class106_0.List_5.Clear();
										}
										@class.class400_0.HashSet_0.smethod_22<Enum17>(new Action<Enum17>(@class.method_0));
									}
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x00137824 File Offset: 0x00135A24
	public void TabLogin_Load(object sender, EventArgs e)
	{
		if (Class226.Boolean_61)
		{
			this.method_12();
		}
		if (base.Parent != null)
		{
			if (!string.IsNullOrEmpty(this.String_3))
			{
				base.Parent.Text = this.String_3;
			}
			else
			{
				base.Parent.Text = this.String_2;
			}
		}
		this.timer_0.Tick += this.timer_0_Tick;
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x00137890 File Offset: 0x00135A90
	private void selectServerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.IEnumerable_0.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_21)).smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_22));
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x001378EC File Offset: 0x00135AEC
	private void lvLogin_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		TabLogin.Class593 @class = new TabLogin.Class593();
		@class.columnClickEventArgs_0 = e;
		List<int> list = new List<int>(5);
		list.Add(0);
		list.Add(3);
		list.Add(7);
		list.Add(9);
		list.Add(11);
		this.Boolean_2 = !this.Boolean_2;
		if (list.Contains(@class.columnClickEventArgs_0.Column))
		{
			if (this.Boolean_2)
			{
				this.list_2 = this.list_2.OrderBy<Class400, int>(new Func<Class400, int>(@class.method_0)).ToList<Class400>();
			}
			else
			{
				this.list_2 = this.list_2.OrderByDescending<Class400, int>(new Func<Class400, int>(@class.method_1)).ToList<Class400>();
			}
		}
		else if (this.Boolean_2)
		{
			this.list_2 = this.list_2.OrderBy<Class400, string>(new Func<Class400, string>(@class.method_2)).ToList<Class400>();
		}
		else
		{
			this.list_2 = this.list_2.OrderByDescending<Class400, string>(new Func<Class400, string>(@class.method_3)).ToList<Class400>();
		}
		this.list_3 = this.list_2;
		this.lvLogin.VirtualListSize = this.list_3.Count;
		this.lvLogin.Refresh();
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x0001CDAD File Offset: 0x0001AFAD
	private void numberlimit_ValueChanged(object sender, EventArgs e)
	{
		this.Int32_0 = (int)this.numberlimit.Value;
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x0001CDC5 File Offset: 0x0001AFC5
	private void method_15(object sender, EventArgs e)
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_23));
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x0001CDF1 File Offset: 0x0001AFF1
	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		this.toolStripMenuItem2_Click(null, null);
		this.toolStripMenuItem4_Click(null, null);
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x00137A20 File Offset: 0x00135C20
	public void method_16()
	{
		if (!this.Boolean_6)
		{
			return;
		}
		try
		{
			File.WriteAllText(GUI.String_1 + "/" + this.String_2 + ".xml", this.method_8(null));
		}
		catch
		{
		}
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x00137A74 File Offset: 0x00135C74
	private void toolStripMenuItem14_Click(object sender, EventArgs e)
	{
		TabLogin.Class594 @class = new TabLogin.Class594();
		@class.tabLogin_0 = this;
		ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
		@class.int_0 = toolStripMenuItem.Text.smethod_26();
		Task.Run(new Action(@class.method_0));
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x0001CE03 File Offset: 0x0001B003
	private void setDoneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.method_15(null, null);
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x0001CE0D File Offset: 0x0001B00D
	private void lvLogin_MouseDown(object sender, MouseEventArgs e)
	{
		if (!this.Boolean_3)
		{
			this.stopwatch_2 = Stopwatch.StartNew();
		}
		this.Boolean_4 = false;
		this.Boolean_3 = true;
		this.point_0 = e.Location;
		this.bool_1 = false;
	}

	// Token: 0x06002B55 RID: 11093 RVA: 0x00137AB8 File Offset: 0x00135CB8
	private void lvLogin_MouseUp(object sender, MouseEventArgs e)
	{
		this.Boolean_4 = true;
		this.Boolean_3 = false;
		this.lvLogin.Invalidate(this.rectangle_0);
		this.lvLogin.Update();
		this.rectangle_0 = Rectangle.Empty;
		if (!this.bool_1)
		{
			this.list_4.Clear();
			this.int_2 = -1;
			return;
		}
		this.bool_1 = false;
		if (this.stopwatch_2.Elapsed.TotalSeconds >= 0.2 && this.list_4.Count > 0 && this.int_2 >= 0 && this.int_2 != this.list_4[0].ListViewItem_0.Index)
		{
			this.list_2 = this.list_2.Except<Class400>(this.list_4).ToList<Class400>();
			this.list_2.InsertRange(this.int_2, this.list_4);
			int num = 1;
			foreach (Class400 @class in this.list_2)
			{
				@class.ListViewItem_0.Text = num++.ToString();
			}
			this.lvLogin.SelectedIndices.Clear();
			for (int i = 0; i < this.list_4.Count; i++)
			{
				this.lvLogin.SelectedIndices.Add(this.int_2 + i);
			}
			this.list_4.Clear();
			this.txtSearch_TextChanged(null, null);
			this.int_2 = -1;
		}
	}

	// Token: 0x06002B56 RID: 11094 RVA: 0x00137C64 File Offset: 0x00135E64
	private void method_17(object sender, EventArgs e)
	{
		using (IEnumerator<IEnumerable<Class106>> enumerator = Class106.IEnumerable_3.ToArray<Class106>().smethod_25<Class106>(6).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class597 @class = new TabLogin.Class597();
				@class.ienumerable_0 = enumerator.Current;
				Task.Run(new Action(@class.method_0));
			}
		}
	}

	// Token: 0x06002B57 RID: 11095 RVA: 0x00137CD0 File Offset: 0x00135ED0
	private void timer_2_Tick(object sender, EventArgs e)
	{
		int num = this.list_2.Count<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_24));
		if (this.int_1 < num)
		{
			if (!this.stopwatch_0.IsRunning)
			{
				this.stopwatch_0 = Stopwatch.StartNew();
				this.int_1 = num;
			}
			else
			{
				this.int_0 += num - this.int_1;
				this.int_1 = num;
			}
		}
		else if (this.int_1 > num)
		{
			this.int_1 = num;
		}
		int num2 = (int)((float)(num * 100) / (float)this.list_2.Count);
		this.processPercent.Int32_0 = num2;
		this.columnHeader_20.Text = this.IEnumerable_0.Sum<Class400>(new Func<Class400, int>(TabLogin.Class589.f_99F04B36.method_25)).ToString();
		if (this.stopwatch_0.IsRunning)
		{
			int num3 = (int)((double)this.int_0 / this.stopwatch_0.Elapsed.TotalHours);
			this.txtSearch.String_0 = string.Concat(new string[]
			{
				this.int_0.smethod_6(),
				" Done Total - ",
				num3.smethod_6(),
				" / Hour - ",
				((int)((double)((float)this.int_0 * 24f) / this.stopwatch_0.Elapsed.TotalHours)).smethod_6(),
				" / Day"
			});
		}
		else
		{
			this.txtSearch.String_0 = string.Concat(new string[]
			{
				0.smethod_6(),
				" Done Total - ",
				0.smethod_6(),
				" / Hour - ",
				0.smethod_6(),
				" / Day"
			});
		}
		this.lvLogin.Columns[9].Text = this.list_2.Sum<Class400>(new Func<Class400, int>(TabLogin.Class589.f_99F04B36.method_26)).smethod_6();
		this.lvLogin.Columns[11].Text = this.list_2.Sum<Class400>(new Func<Class400, int>(TabLogin.Class589.f_99F04B36.method_27)).smethod_6();
	}

	// Token: 0x06002B58 RID: 11096 RVA: 0x0001CE43 File Offset: 0x0001B043
	private void method_18(object sender, EventArgs e)
	{
		Clipboard.SetText(this.IEnumerable_0.FirstOrDefault<Class400>().String_7);
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x0001CE5A File Offset: 0x0001B05A
	private void method_19(object sender, EventArgs e)
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_28));
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_20(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B5B RID: 11099 RVA: 0x0000500B File Offset: 0x0000320B
	private void uploadToToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x000B3208 File Offset: 0x000B1408
	public static string smethod_1(string string_5, string string_6)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
		httpWebRequest.Method = "GET";
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.UserAgent = string_6;
		httpWebRequest.Proxy = null;
		httpWebRequest.ServicePoint.Expect100Continue = false;
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		httpWebResponse.Close();
		return text;
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x0000500B File Offset: 0x0000320B
	private void downloadFromToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_21(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x00137F34 File Offset: 0x00136134
	private void method_22(object sender, EventArgs e)
	{
		TabLogin.Class598 @class = new TabLogin.Class598();
		@class.tabLogin_0 = this;
		@class.list_0 = new List<Class400>();
		List<string> list = new List<string>();
		foreach (Class400 class2 in this.list_2)
		{
			string text = string.Concat(new string[] { class2.String_6, "|", class2.String_8, "|", class2.String_9, "|", class2.String_11, "|", class2.String_22 });
			if (!list.Contains(text))
			{
				list.Add(text);
			}
			else
			{
				@class.list_0.Add(class2);
			}
		}
		MessBox messBox = MessBox.smethod_0("Bạn có muốn xóa " + @class.list_0.Count.ToString() + " tài khoản trùng lặp");
		messBox.EventHandler_0 = (EventHandler)Delegate.Combine(messBox.EventHandler_0, new EventHandler(@class.method_0));
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x0001CE86 File Offset: 0x0001B086
	private void txtSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.txtSearch_TextChanged(null, null);
		}
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x0013806C File Offset: 0x0013626C
	private void lvLogin_MouseMove(object sender, MouseEventArgs e)
	{
		if (!this.Boolean_3)
		{
			return;
		}
		int num = Math.Abs(e.Location.X - this.point_0.X);
		int num2 = Math.Abs(e.Location.Y - this.point_0.Y);
		int num3 = (int)Math.Sqrt((double)(num * num + num2 * num2));
		if (!this.bool_1 && num3 < 5)
		{
			return;
		}
		this.bool_1 = true;
		if (this.stopwatch_2.Elapsed.TotalSeconds >= 0.2)
		{
			if (this.list_4.Count == 0)
			{
				this.list_4 = this.IEnumerable_0.ToList<Class400>();
			}
			ListViewItem item = this.lvLogin.HitTest(e.Location).Item;
			Graphics graphics = this.lvLogin.CreateGraphics();
			if (!this.rectangle_0.IsEmpty)
			{
				this.lvLogin.Invalidate(this.rectangle_0);
				this.lvLogin.Update();
			}
			Rectangle empty = Rectangle.Empty;
			if (item != null)
			{
				int index = item.Index;
				this.int_2 = index;
				if (this.list_4.Count > 0 && this.int_2 != this.list_4.FirstOrDefault<Class400>().ListViewItem_0.Index)
				{
					Cursor.Current = Cursors.WaitCursor;
					Color red = Color.Red;
					if (this.lvLogin.View != View.Details)
					{
						if (this.lvLogin.View != View.List)
						{
							empty = new Rectangle(item.Bounds.X - 5, item.Bounds.Y, 10, item.Bounds.Height);
							graphics.DrawLine(new Pen(red, 2f), new Point(item.Bounds.X, item.Bounds.Y), new Point(item.Bounds.X, item.Bounds.Y + item.Bounds.Height));
							graphics.FillPolygon(new SolidBrush(red), new Point[]
							{
								new Point(item.Bounds.X - 5, item.Bounds.Y),
								new Point(item.Bounds.X + 5, item.Bounds.Y),
								new Point(item.Bounds.X, item.Bounds.Y + 5)
							});
							graphics.FillPolygon(new SolidBrush(red), new Point[]
							{
								new Point(item.Bounds.X - 5, item.Bounds.Y + item.Bounds.Height),
								new Point(item.Bounds.X + 5, item.Bounds.Y + item.Bounds.Height),
								new Point(item.Bounds.X, item.Bounds.Y + item.Bounds.Height - 5)
							});
							goto IL_0B99;
						}
					}
					empty = new Rectangle(item.Bounds.X, item.Bounds.Y - 5, this.lvLogin.ClientRectangle.Width - item.Bounds.X, 10);
					graphics.DrawLine(new Pen(red, 2f), new Point(item.Bounds.X, item.Bounds.Y), new Point(item.Bounds.X + this.lvLogin.ClientRectangle.Width, item.Bounds.Y));
					graphics.FillPolygon(new SolidBrush(red), new Point[]
					{
						new Point(item.Bounds.X, item.Bounds.Y - 5),
						new Point(item.Bounds.X + 5, item.Bounds.Y),
						new Point(item.Bounds.X, item.Bounds.Y + 5)
					});
					graphics.FillPolygon(new SolidBrush(red), new Point[]
					{
						new Point(this.lvLogin.ClientRectangle.Width - 4, item.Bounds.Y - 5),
						new Point(this.lvLogin.ClientRectangle.Width - 9, item.Bounds.Y),
						new Point(this.lvLogin.ClientRectangle.Width - 4, item.Bounds.Y + 5)
					});
				}
			}
			else if (this.lvLogin.Items.Count > 0 && this.list_4.Count > 0)
			{
				ListViewItem listViewItem = this.lvLogin.Items[this.lvLogin.Items.Count - 1];
				Color red2 = Color.Red;
				if (this.lvLogin.View != View.Details)
				{
					if (this.lvLogin.View != View.List)
					{
						empty = new Rectangle(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y, 10, listViewItem.Bounds.Height);
						graphics.DrawLine(new Pen(red2, 2f), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
						graphics.FillPolygon(new SolidBrush(red2), new Point[]
						{
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + 5)
						});
						graphics.FillPolygon(new SolidBrush(red2), new Point[]
						{
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5)
						});
						goto IL_0B81;
					}
				}
				empty = new Rectangle(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5, this.lvLogin.ClientRectangle.Width - listViewItem.Bounds.X, 10);
				graphics.DrawLine(new Pen(red2, 2f), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height), new Point(listViewItem.Bounds.X + this.lvLogin.ClientRectangle.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
				graphics.FillPolygon(new SolidBrush(red2), new Point[]
				{
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
					new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
				});
				graphics.FillPolygon(new SolidBrush(red2), new Point[]
				{
					new Point(this.lvLogin.ClientRectangle.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
					new Point(this.lvLogin.ClientRectangle.Width - 9, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
					new Point(this.lvLogin.ClientRectangle.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
				});
				IL_0B81:
				this.int_2 = this.lvLogin.Items.Count - 1;
			}
			IL_0B99:
			this.rectangle_0 = empty;
		}
	}

	// Token: 0x17000A09 RID: 2569
	// (get) Token: 0x06002B62 RID: 11106 RVA: 0x0001CE9A File Offset: 0x0001B09A
	// (set) Token: 0x06002B63 RID: 11107 RVA: 0x0001CEA2 File Offset: 0x0001B0A2
	public bool Boolean_7 { get; set; }

	// Token: 0x06002B64 RID: 11108 RVA: 0x0001CEAB File Offset: 0x0001B0AB
	private void copyUserNameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(string.Join("\r\n", this.IEnumerable_0.Select<Class400, string>(new Func<Class400, string>(TabLogin.Class589.f_99F04B36.method_29))));
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x00138C1C File Offset: 0x00136E1C
	private void button1_Click(object sender, EventArgs e)
	{
		TabLogin.List_0.Remove(this);
		base.Parent.Dispose();
		if (this.list_2.Count == 0 && this.Boolean_6)
		{
			try
			{
				File.Delete(GUI.String_1 + "/" + this.String_2 + ".xml");
			}
			catch
			{
			}
		}
		base.Dispose();
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x0001CEE6 File Offset: 0x0001B0E6
	private void txtFakeName_TextChanged(object sender, EventArgs e)
	{
		this.String_3 = this.txtFakeName.Text;
		base.Parent.Text = this.String_3;
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x00138C90 File Offset: 0x00136E90
	private void txtTag_TextChanged(object sender, EventArgs e)
	{
		this.timer_1.Stop();
		this.timer_1.Dispose();
		this.timer_1 = new global::System.Windows.Forms.Timer
		{
			Interval = 333
		};
		this.timer_1.Tick += this.timer_1_Tick;
		this.timer_1.Start();
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x00138CEC File Offset: 0x00136EEC
	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		TabLogin.Class599 @class = new TabLogin.Class599();
		@class.object_0 = sender;
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(@class.method_0));
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x00138D20 File Offset: 0x00136F20
	private void toolStripMenuItem90_Click(object sender, EventArgs e)
	{
		TabLogin.Class600 @class = new TabLogin.Class600();
		@class.object_0 = sender;
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(@class.method_0));
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x0001CF0A File Offset: 0x0001B10A
	private void checkPaused_CheckedChanged(object sender, EventArgs e)
	{
		this.Boolean_7 = this.checkPaused.Checked;
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x0001CF1D File Offset: 0x0001B11D
	private void checkRelog_CheckedChanged(object sender, EventArgs e)
	{
		this.Boolean_0 = this.checkRelog.Checked;
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x0001CF30 File Offset: 0x0001B130
	private void checkReset_CheckedChanged(object sender, EventArgs e)
	{
		this.Boolean_1 = this.checkReset.Checked;
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x0001CF43 File Offset: 0x0001B143
	private void check0hReset_CheckedChanged(object sender, EventArgs e)
	{
		this.Boolean_5 = this.check0hReset.Checked;
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x0001CF56 File Offset: 0x0001B156
	private void menuSetNhom_Click(object sender, EventArgs e)
	{
		this.method_11(null, null);
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x0001CF60 File Offset: 0x0001B160
	private void menuTaoNhom_Click(object sender, EventArgs e)
	{
		this.method_17(null, null);
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x0000500B File Offset: 0x0000320B
	private void TxtUser_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x0000500B File Offset: 0x0000320B
	private void timer_3_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x0001CF6A File Offset: 0x0001B16A
	private void cleanNameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_30));
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x0001CF96 File Offset: 0x0001B196
	private void timer_4_Tick(object sender, EventArgs e)
	{
		this.method_16();
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_23(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x00138D54 File Offset: 0x00136F54
	private void changeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
		Class400 @class = this.IEnumerable_0.FirstOrDefault<Class400>();
		this.pathToolStripMenuItem.DropDownItems.Clear();
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("Open");
		toolStripMenuItem.Click += this.method_37;
		this.pathToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
		toolStripMenuItem = new ToolStripMenuItem("None");
		toolStripMenuItem.Click += this.method_38;
		this.pathToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
		using (List<string>.Enumerator enumerator = Class226.List_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class602 class2 = new TabLogin.Class602();
				class2.tabLogin_0 = this;
				class2.string_0 = enumerator.Current;
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(class2.string_0);
				if (@class != null)
				{
					if (string.IsNullOrEmpty(@class.String_24) && class2.string_0 == Class226.String_4)
					{
						toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Bold);
					}
					else if (@class.String_24 == class2.string_0)
					{
						toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Bold);
					}
				}
				toolStripMenuItem2.Click += class2.method_0;
				this.pathToolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
			}
		}
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x00138EC4 File Offset: 0x001370C4
	private void menuXaoTron_Click(object sender, EventArgs e)
	{
		this.list_2 = this.list_2.OrderBy<Class400, Guid>(new Func<Class400, Guid>(TabLogin.Class589.f_99F04B36.method_32)).ToList<Class400>();
		this.list_3 = this.list_2;
		this.lvLogin.VirtualListSize = this.list_3.Count;
		this.lvLogin.Refresh();
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x0001CF9E File Offset: 0x0001B19E
	private void removeDuplicate_Click(object sender, EventArgs e)
	{
		this.method_22(null, null);
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x00138F34 File Offset: 0x00137134
	private void menuThaoTac_DropDownOpening(object sender, EventArgs e)
	{
		this.uploadToToolStripMenuItem.DropDownItems.Clear();
		using (IEnumerator<ValueTuple<string, string>> enumerator = Class106.Class210_0["iLogin"].GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class603 @class = new TabLogin.Class603();
				@class.tabLogin_0 = this;
				@class.valueTuple_0 = enumerator.Current;
				TabLogin.Class604 class2 = new TabLogin.Class604();
				class2.class603_0 = @class;
				class2.toolStripMenuItem_0 = new ToolStripMenuItem(class2.class603_0.valueTuple_0.Item1);
				class2.toolStripMenuItem_0.Click += class2.method_0;
				this.uploadToToolStripMenuItem.DropDownItems.Add(class2.toolStripMenuItem_0);
			}
		}
		this.downloadFromToolStripMenuItem.DropDownItems.Clear();
		using (IEnumerator<ValueTuple<string, string>> enumerator = Class106.Class210_0["iLogin"].GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class605 class3 = new TabLogin.Class605();
				class3.tabLogin_0 = this;
				class3.valueTuple_0 = enumerator.Current;
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(class3.valueTuple_0.Item1);
				toolStripMenuItem.Click += class3.method_0;
				this.downloadFromToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
			}
		}
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_24(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_25(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_26(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_27(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_28(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x0000500B File Offset: 0x0000320B
	private void TxtPass_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
	private void cleanStatusToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_33));
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x00139098 File Offset: 0x00137298
	private void runLauncherToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class400 @class = this.IEnumerable_0.FirstOrDefault<Class400>();
		if (@class != null)
		{
			string text = Directory.GetParent(@class.String_24).Parent.FullName + "\\Launch.exe";
			if (File.Exists(text))
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = text,
					Arguments = "-static",
					WorkingDirectory = Path.GetDirectoryName(text)
				});
				return;
			}
			MessBox.smethod_0("Không tìm thấy file " + text);
		}
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x00139118 File Offset: 0x00137318
	private void timer_5_Tick(object sender, EventArgs e)
	{
		if (GUI.GUI_0.tabMain.SelectedIndex == 1 && GUI.GUI_0.tabLogin.SelectedTab == base.Parent)
		{
			this.lvLogin.BeginUpdate();
			foreach (Class400 @class in this.list_2)
			{
				if (@class.Class106_0 != null)
				{
					if (@class.Class106_0.Class527_0.Boolean_41)
					{
						@class.String_21 = "Online";
					}
					else
					{
						@class.String_21 = @class.Class106_0.String_16;
					}
				}
			}
			this.lvLogin.EndUpdate();
		}
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x001391E0 File Offset: 0x001373E0
	private void cleanTeamToolStripMenuItem_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class400> enumerator = this.IEnumerable_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TabLogin.Class606 @class = new TabLogin.Class606();
				@class.class400_0 = enumerator.Current;
				Class226.Dictionary_2.smethod_22<KeyValuePair<string, List<string>>>(new Action<KeyValuePair<string, List<string>>>(@class.method_0));
				@class.class400_0.ListViewItem_0.SubItems[14].Text = "...";
			}
		}
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x0013926C File Offset: 0x0013746C
	public static List<string> smethod_2()
	{
		List<string> list = new List<string>();
		foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
		{
			if (driveInfo.IsReady)
			{
				TabLogin.smethod_3(driveInfo.RootDirectory.FullName, list);
			}
		}
		return list;
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x001392B4 File Offset: 0x001374B4
	private static void smethod_3(string string_5, List<string> list_7)
	{
		try
		{
			list_7.AddRange(Directory.GetFiles(string_5, "*.ini"));
			string[] directories = Directory.GetDirectories(string_5);
			for (int i = 0; i < directories.Length; i++)
			{
				TabLogin.smethod_3(directories[i], list_7);
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (PathTooLongException)
		{
		}
		catch (IOException)
		{
		}
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x00139324 File Offset: 0x00137524
	private void importTLAutoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TabLogin.Class607 @class = new TabLogin.Class607();
		@class.tabLogin_0 = this;
		@class.openFileDialog_0 = new OpenFileDialog();
		if (@class.openFileDialog_0.ShowDialog() == DialogResult.OK)
		{
			Task.Run(new Action(@class.method_0));
		}
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x0001D01D File Offset: 0x0001B21D
	[CompilerGenerated]
	private Class400 method_29(int int_5)
	{
		return this.list_3.ElementAt<Class400>(int_5);
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x0001D02B File Offset: 0x0001B22B
	[CompilerGenerated]
	private void method_30()
	{
		this.lvLogin.Columns[0].Text = "...";
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x0013D6B4 File Offset: 0x0013B8B4
	[CompilerGenerated]
	internal static string smethod_4(string string_5)
	{
		string text = "[\\x00-\\x08\\x0B\\x0C\\x0E-\\x1F\\x7F]";
		return Regex.Replace(string_5, text, "");
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x0013D6D4 File Offset: 0x0013B8D4
	[CompilerGenerated]
	internal static XmlDocument smethod_5()
	{
		XmlDocument xmlDocument = new XmlDocument();
		try
		{
			xmlDocument.LoadXml(Class106.Class210_0["Settings", "Accounts"]);
		}
		catch
		{
			xmlDocument.InsertBefore(xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null), xmlDocument.DocumentElement);
			xmlDocument.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "Accounts", ""));
		}
		return xmlDocument;
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x0013D750 File Offset: 0x0013B950
	[CompilerGenerated]
	private void method_31()
	{
		this.lvLogin.Columns[0].Text = this.list_3.Count.ToString();
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x0001D048 File Offset: 0x0001B248
	[CompilerGenerated]
	private void method_32()
	{
		base.Parent.Text = this.String_3;
		this.txtFakeName.String_0 = this.String_3;
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x0001D06C File Offset: 0x0001B26C
	[CompilerGenerated]
	private void method_33()
	{
		this.txtSearch_TextChanged(null, null);
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x0001D076 File Offset: 0x0001B276
	[CompilerGenerated]
	private void method_34()
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_6));
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x0013D788 File Offset: 0x0013B988
	[CompilerGenerated]
	private void method_35()
	{
		string text = this.method_8(null);
		if (text.Length > 0)
		{
			File.WriteAllText(GUI.String_1 + "/" + this.String_2 + ".xml", text);
		}
		try
		{
			if (this.list_2.Count == 0)
			{
				File.Delete(GUI.String_1 + "/" + this.String_2 + ".xml");
			}
			else
			{
				File.Move(GUI.String_1 + "/" + this.String_2 + ".xml", string.Concat(new string[]
				{
					GUI.String_1,
					"/",
					this.String_2,
					".xml.",
					DateTime.Now.Ticks.ToString(),
					".bak"
				}));
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x0013D878 File Offset: 0x0013BA78
	[CompilerGenerated]
	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			Class400 @class = this.IEnumerable_0.FirstOrDefault<Class400>();
			if (@class != null)
			{
				this.TxtUser.Text = @class.String_6;
				this.TxtPass.Text = @class.String_8;
			}
			GUI.GUI_0.LvGame.SelectedIndices.Clear();
			this.IEnumerable_0.Where<Class400>(new Func<Class400, bool>(TabLogin.Class589.f_99F04B36.method_19)).smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_20));
		}
		catch
		{
		}
		this.timer_0.Stop();
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x0013D938 File Offset: 0x0013BB38
	[CompilerGenerated]
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (this.txtTag.Text != this.txtTag.String_0)
		{
			this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(this.method_36));
		}
		this.timer_1.Stop();
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x0001D0A2 File Offset: 0x0001B2A2
	[CompilerGenerated]
	private void method_36(Class400 class400_0)
	{
		class400_0.String_23 = this.txtTag.Text;
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x0013D984 File Offset: 0x0013BB84
	[CompilerGenerated]
	private void method_37(object sender, EventArgs e)
	{
		TabLogin.Class601 @class = new TabLogin.Class601();
		@class.openFileDialog_0 = new OpenFileDialog();
		if (@class.openFileDialog_0.ShowDialog(this) == DialogResult.OK)
		{
			this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(@class.method_0));
		}
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x0001D0B5 File Offset: 0x0001B2B5
	[CompilerGenerated]
	private void method_38(object sender, EventArgs e)
	{
		this.IEnumerable_0.smethod_22<Class400>(new Action<Class400>(TabLogin.Class589.f_99F04B36.method_31));
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_39()
	{
		base.Enabled = true;
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_40()
	{
		base.Enabled = true;
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x0001D02B File Offset: 0x0001B22B
	[CompilerGenerated]
	private void method_41()
	{
		this.lvLogin.Columns[0].Text = "...";
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x0013D6B4 File Offset: 0x0013B8B4
	[CompilerGenerated]
	internal static string smethod_6(string string_5)
	{
		string text = "[\\x00-\\x08\\x0B\\x0C\\x0E-\\x1F\\x7F]";
		return Regex.Replace(string_5, text, "");
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x0013D6D4 File Offset: 0x0013B8D4
	[CompilerGenerated]
	internal static XmlDocument smethod_7()
	{
		XmlDocument xmlDocument = new XmlDocument();
		try
		{
			xmlDocument.LoadXml(Class106.Class210_0["Settings", "Accounts"]);
		}
		catch
		{
			xmlDocument.InsertBefore(xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null), xmlDocument.DocumentElement);
			xmlDocument.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "Accounts", ""));
		}
		return xmlDocument;
	}

	// Token: 0x04001F28 RID: 7976
	public static List<List<Class400>> list_0 = new List<List<Class400>>();

	// Token: 0x04001F29 RID: 7977
	public static List<int> list_1 = new List<int>();

	// Token: 0x04001F2A RID: 7978
	private readonly Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	// Token: 0x04001F2B RID: 7979
	private readonly string string_0 = Class529.smethod_1(Process.GetCurrentProcess().MainModule.FileName);

	// Token: 0x04001F2C RID: 7980
	public List<Class400> list_2 = new List<Class400>();

	// Token: 0x04001F2D RID: 7981
	public List<Class400> list_3 = new List<Class400>();

	// Token: 0x04001F2E RID: 7982
	public int int_0;

	// Token: 0x04001F2F RID: 7983
	private bool bool_0;

	// Token: 0x04001F30 RID: 7984
	public int int_1;

	// Token: 0x04001F31 RID: 7985
	private List<Class400> list_4 = new List<Class400>();

	// Token: 0x04001F32 RID: 7986
	private readonly Stack<List<ValueTuple<int, Class400>>> stack_0 = new Stack<List<ValueTuple<int, Class400>>>();

	// Token: 0x04001F33 RID: 7987
	private int int_2 = -1;

	// Token: 0x04001F34 RID: 7988
	public Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x04001F35 RID: 7989
	private Stopwatch stopwatch_1 = Stopwatch.StartNew();

	// Token: 0x04001F36 RID: 7990
	private Thread thread_0;

	// Token: 0x04001F37 RID: 7991
	private Point point_0;

	// Token: 0x04001F38 RID: 7992
	private bool bool_1;

	// Token: 0x04001F39 RID: 7993
	private const int int_3 = 5;

	// Token: 0x04001F3A RID: 7994
	private Rectangle rectangle_0 = Rectangle.Empty;

	// Token: 0x04001F3B RID: 7995
	[CompilerGenerated]
	private int int_4;

	// Token: 0x04001F3C RID: 7996
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001F3D RID: 7997
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04001F3E RID: 7998
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04001F3F RID: 7999
	[CompilerGenerated]
	private string string_4;

	// Token: 0x04001F40 RID: 8000
	[CompilerGenerated]
	private static List<TabLogin> list_5;

	// Token: 0x04001F41 RID: 8001
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04001F42 RID: 8002
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x04001F43 RID: 8003
	[CompilerGenerated]
	private static List<Class400> list_6;

	// Token: 0x04001F44 RID: 8004
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x04001F45 RID: 8005
	[CompilerGenerated]
	private bool bool_5;

	// Token: 0x04001F46 RID: 8006
	[CompilerGenerated]
	private bool bool_6;

	// Token: 0x04001F47 RID: 8007
	[CompilerGenerated]
	private bool bool_7;

	// Token: 0x04001F48 RID: 8008
	[CompilerGenerated]
	private bool bool_8;

	// Token: 0x04001F49 RID: 8009
	private global::System.Windows.Forms.Timer timer_0 = new global::System.Windows.Forms.Timer();

	// Token: 0x04001F4A RID: 8010
	private Stopwatch stopwatch_2 = Stopwatch.StartNew();

	// Token: 0x04001F4B RID: 8011
	[CompilerGenerated]
	private bool bool_9;

	// Token: 0x04001F4C RID: 8012
	private global::System.Windows.Forms.Timer timer_1 = new global::System.Windows.Forms.Timer
	{
		Interval = 333
	};

	// Token: 0x02000332 RID: 818
	[CompilerGenerated]
	[Serializable]
	private sealed class Class589
	{
		// Token: 0x06002B9E RID: 11166 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		internal string method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0001D0ED File Offset: 0x0001B2ED
		internal Enum17 method_1(string string_0)
		{
			return (Enum17)Enum.Parse(typeof(Enum17), string_0.Trim());
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x0001D109 File Offset: 0x0001B309
		internal string method_2(KeyValuePair<int, int> keyValuePair_0)
		{
			return string.Format("{0},{1}", keyValuePair_0.Key, keyValuePair_0.Value);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0001D12D File Offset: 0x0001B32D
		internal bool method_3(Class400 class400_0)
		{
			return class400_0.String_21 != "done";
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0001D13F File Offset: 0x0001B33F
		internal void method_4(Class400 class400_0)
		{
			if (class400_0.Class106_0 == null)
			{
				class400_0.String_21 = "wait";
			}
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x0013D9C8 File Offset: 0x0013BBC8
		internal void method_5(Class400 class400_0)
		{
			if (class400_0.Class106_0 == null)
			{
				class400_0.String_21 = "wait";
				return;
			}
			class400_0.Class106_0.Boolean_49 = true;
			class400_0.Class106_0.method_299();
			class400_0.Class106_0.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x0001D154 File Offset: 0x0001B354
		internal void method_6(Class400 class400_0)
		{
			if (class400_0.Class106_0 != null)
			{
				class400_0.Class106_0.method_305();
				class400_0.Class106_0 = null;
			}
			class400_0.String_21 = "...";
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x0001D17B File Offset: 0x0001B37B
		internal int method_7(ValueTuple<int, Class400> valueTuple_0)
		{
			return valueTuple_0.Item1;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0001D183 File Offset: 0x0001B383
		internal string method_8(Class400 class400_0)
		{
			return class400_0.String_17;
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0001D18B File Offset: 0x0001B38B
		internal bool method_9(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return !keyValuePair_0.Value.Any<string>();
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		internal string method_10(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x0000B68A File Offset: 0x0000988A
		internal bool method_11(Class400 class400_0)
		{
			return class400_0.Class106_0 != null;
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x0001D19C File Offset: 0x0001B39C
		internal bool method_12(Class400 class400_0)
		{
			return class400_0.Class106_0 != null && class400_0.Class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		internal bool method_13(Class400 class400_0)
		{
			return class400_0.HashSet_0.Count > 0;
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		internal void method_14(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0001D1D5 File Offset: 0x0001B3D5
		internal bool method_15(Class400 class400_0)
		{
			return class400_0.String_21.Equals("wait");
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0001D1E7 File Offset: 0x0001B3E7
		internal bool method_16(Class400 class400_0)
		{
			return class400_0.Class106_0 == null && class400_0.HashSet_0.Count > 0;
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		internal void method_17(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0000B68A File Offset: 0x0000988A
		internal bool method_18(Class400 class400_0)
		{
			return class400_0.Class106_0 != null;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0000B68A File Offset: 0x0000988A
		internal bool method_19(Class400 class400_0)
		{
			return class400_0.Class106_0 != null;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0001D201 File Offset: 0x0001B401
		internal void method_20(Class400 class400_0)
		{
			GUI.GUI_0.LvGame.SelectedIndices.Add(class400_0.Class106_0.ListViewItem_0.Index);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x0000B68A File Offset: 0x0000988A
		internal bool method_21(Class400 class400_0)
		{
			return class400_0.Class106_0 != null;
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x0001D228 File Offset: 0x0001B428
		internal void method_22(Class400 class400_0)
		{
			class400_0.Class106_0.method_304();
			class400_0.Class106_0.Class264_0.Boolean_32 = true;
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x0001D246 File Offset: 0x0001B446
		internal void method_23(Class400 class400_0)
		{
			if (class400_0.Class106_0 != null)
			{
				class400_0.Class106_0.Boolean_10 = true;
				class400_0.Class106_0.List_5.Clear();
				return;
			}
			class400_0.String_21 = "done";
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0001D278 File Offset: 0x0001B478
		internal bool method_24(Class400 class400_0)
		{
			return class400_0.String_21.Equals("done");
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0001D28A File Offset: 0x0001B48A
		internal int method_25(Class400 class400_0)
		{
			return class400_0.String_12.smethod_26();
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0001D28A File Offset: 0x0001B48A
		internal int method_26(Class400 class400_0)
		{
			return class400_0.String_12.smethod_26();
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0001D297 File Offset: 0x0001B497
		internal int method_27(Class400 class400_0)
		{
			return class400_0.String_16.smethod_26();
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		internal void method_28(Class400 class400_0)
		{
			if (class400_0.Class106_0 == null && class400_0.String_21 != "done")
			{
				class400_0.String_21 = "wait";
			}
			class400_0.method_1(Enum17.VuiCungNienThu, true);
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x0001D2D7 File Offset: 0x0001B4D7
		internal string method_29(Class400 class400_0)
		{
			return class400_0.String_6 + "\t" + class400_0.String_8;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0013DA18 File Offset: 0x0013BC18
		internal void method_30(Class400 class400_0)
		{
			class400_0.String_17 = (class400_0.String_7 = string.Empty);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x0001D2EF File Offset: 0x0001B4EF
		internal void method_31(Class400 class400_0)
		{
			class400_0.String_24 = string.Empty;
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x0000B0FE File Offset: 0x000092FE
		internal Guid method_32(Class400 class400_0)
		{
			return Guid.NewGuid();
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0001D2FC File Offset: 0x0001B4FC
		internal void method_33(Class400 class400_0)
		{
			class400_0.String_21 = "...";
		}

		// Token: 0x04001FFA RID: 8186
		public static readonly TabLogin.Class589 f_99F04B36 = new TabLogin.Class589();

		// Token: 0x04001FFB RID: 8187
		public static Func<KeyValuePair<string, List<string>>, string> f_12A54AD9;

		// Token: 0x04001FFC RID: 8188
		public static Func<string, Enum17> f_7D318BCC;

		// Token: 0x04001FFD RID: 8189
		public static Func<KeyValuePair<int, int>, string> f_9E5BC5CE;

		// Token: 0x04001FFE RID: 8190
		public static Func<Class400, bool> f_3ABC520A;

		// Token: 0x04001FFF RID: 8191
		public static Action<Class400> f_36006332;

		// Token: 0x04002000 RID: 8192
		public static Action<Class400> f_C5B24596;

		// Token: 0x04002001 RID: 8193
		public static Action<Class400> f_8AB7D4C3;

		// Token: 0x04002002 RID: 8194
		public static Func<ValueTuple<int, Class400>, int> f_F7427075;

		// Token: 0x04002003 RID: 8195
		public static Func<Class400, string> f_612D7E0B;

		// Token: 0x04002004 RID: 8196
		public static Func<KeyValuePair<string, List<string>>, bool> f_33837FE4;

		// Token: 0x04002005 RID: 8197
		public static Func<KeyValuePair<string, List<string>>, string> f_45D76B14;

		// Token: 0x04002006 RID: 8198
		public static Func<Class400, bool> f_17050EC5;

		// Token: 0x04002007 RID: 8199
		public static Func<Class400, bool> f_833C7E93;

		// Token: 0x04002008 RID: 8200
		public static Func<Class400, bool> f_E35D9758;

		// Token: 0x04002009 RID: 8201
		public static Action<Class400> f_6453587C;

		// Token: 0x0400200A RID: 8202
		public static Func<Class400, bool> f_E1850138;

		// Token: 0x0400200B RID: 8203
		public static Func<Class400, bool> f_D9EA62E9;

		// Token: 0x0400200C RID: 8204
		public static Action<Class400> f_37057A63;

		// Token: 0x0400200D RID: 8205
		public static Func<Class400, bool> f_08F8E3FA;

		// Token: 0x0400200E RID: 8206
		public static Func<Class400, bool> f_02A02B11;

		// Token: 0x0400200F RID: 8207
		public static Action<Class400> f_70CDFFAC;

		// Token: 0x04002010 RID: 8208
		public static Func<Class400, bool> f_232788D3;

		// Token: 0x04002011 RID: 8209
		public static Action<Class400> f_F301C4CA;

		// Token: 0x04002012 RID: 8210
		public static Action<Class400> f_A469FAB6;

		// Token: 0x04002013 RID: 8211
		public static Func<Class400, bool> f_E97D5362;

		// Token: 0x04002014 RID: 8212
		public static Func<Class400, int> f_8BF28D59;

		// Token: 0x04002015 RID: 8213
		public static Func<Class400, int> f_D517E166;

		// Token: 0x04002016 RID: 8214
		public static Func<Class400, int> f_19062F97;

		// Token: 0x04002017 RID: 8215
		public static Action<Class400> f_816EF537;

		// Token: 0x04002018 RID: 8216
		public static Func<Class400, string> f_E1796360;

		// Token: 0x04002019 RID: 8217
		public static Action<Class400> f_677C817C;

		// Token: 0x0400201A RID: 8218
		public static Action<Class400> f_62C325A5;

		// Token: 0x0400201B RID: 8219
		public static Func<Class400, Guid> f_5979D351;

		// Token: 0x0400201C RID: 8220
		public static Action<Class400> f_FE82561E;
	}

	// Token: 0x02000333 RID: 819
	[CompilerGenerated]
	private sealed class Class590
	{
		// Token: 0x06002BC1 RID: 11201 RVA: 0x0001D309 File Offset: 0x0001B509
		internal void method_0(Class400 class400_0)
		{
			class400_0.ListViewItem_0.SubItems[14].Text = this.string_0;
		}

		// Token: 0x0400201D RID: 8221
		public string string_0;
	}

	// Token: 0x02000334 RID: 820
	[CompilerGenerated]
	private sealed class Class591
	{
		// Token: 0x06002BC3 RID: 11203 RVA: 0x0001D328 File Offset: 0x0001B528
		internal bool method_0(Class400 class400_0)
		{
			return class400_0.String_5.Contains(this.string_0);
		}

		// Token: 0x0400201E RID: 8222
		public string string_0;
	}

	// Token: 0x02000335 RID: 821
	[CompilerGenerated]
	private sealed class Class592
	{
		// Token: 0x06002BC5 RID: 11205 RVA: 0x0013DA3C File Offset: 0x0013BC3C
		internal void method_0(Enum17 enum17_0)
		{
			this.class400_0.Class106_0.method_97(enum17_0, true);
			if (this.class400_0.String_0 != string.Empty)
			{
				this.class400_0.Class106_0.String_19 = this.class400_0.String_0;
				this.class400_0.Class106_0.method_97(Enum17.GomDo, true);
				this.class400_0.Class106_0.method_97(Enum17.GomVang, true);
			}
			if (this.class400_0.String_1 != string.Empty)
			{
				this.class400_0.Class106_0.String_20 = this.class400_0.String_1;
				this.class400_0.Class106_0.method_97(Enum17.ChiaDo, true);
			}
			if (this.class400_0.String_2 != string.Empty)
			{
				this.class400_0.Class106_0.String_5 = this.class400_0.String_1;
				this.class400_0.Class106_0.method_97(Enum17.TangBachHoaHuongNang, true);
			}
			if (this.class400_0.HashSet_0.Contains(Enum17.DatDoiAcBa))
			{
				this.class400_0.Class106_0.Int32_40 = this.class400_0.String_4.smethod_26();
			}
			if (this.class400_0.HashSet_0.Contains(Enum17.ChayThuongNhan) && string.IsNullOrEmpty(this.class400_0.Class106_0.String_27))
			{
				this.class400_0.Class106_0.String_27 = "Back";
			}
		}

		// Token: 0x0400201F RID: 8223
		public Class400 class400_0;
	}

	// Token: 0x02000336 RID: 822
	[CompilerGenerated]
	private sealed class Class593
	{
		// Token: 0x06002BC7 RID: 11207 RVA: 0x0001D33B File Offset: 0x0001B53B
		internal int method_0(Class400 class400_0)
		{
			return class400_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text.smethod_26();
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x0001D33B File Offset: 0x0001B53B
		internal int method_1(Class400 class400_0)
		{
			return class400_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text.smethod_26();
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x0001D362 File Offset: 0x0001B562
		internal string method_2(Class400 class400_0)
		{
			return class400_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x0001D362 File Offset: 0x0001B562
		internal string method_3(Class400 class400_0)
		{
			return class400_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text;
		}

		// Token: 0x04002020 RID: 8224
		public ColumnClickEventArgs columnClickEventArgs_0;
	}

	// Token: 0x02000337 RID: 823
	[CompilerGenerated]
	private sealed class Class594
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x0013DBC0 File Offset: 0x0013BDC0
		internal void method_0()
		{
			try
			{
				TabLogin.Class595 @class = new TabLogin.Class595();
				@class.class594_0 = this;
				new List<ListViewItem>();
				string text = Class587.smethod_8(string.Concat(new string[]
				{
					Settings.Default.HomePage,
					"?cmd=buyclone&sl=",
					this.int_0.ToString(),
					"&email=",
					HttpUtility.UrlEncode(GUI.GUI_0.String_2),
					"&pass=",
					HttpUtility.UrlEncode(GUI.GUI_0.String_3)
				}));
				if (!text.Contains("\n"))
				{
					MessBox.smethod_0(text);
				}
				else
				{
					new List<ListViewItem>();
					@class.int_0 = 0;
					foreach (string text2 in text.Split(new char[] { '\n' }))
					{
						TabLogin.Class596 class2 = new TabLogin.Class596();
						class2.class595_0 = @class;
						class2.string_0 = text2.Trim();
						if (class2.string_0.Length > 0)
						{
							this.tabLogin_0.Invoke(new Action(class2.method_0));
						}
					}
					if (@class.int_0 > 0)
					{
						MessBox.smethod_0("Mua thành công " + @class.int_0.ToString() + " Clone");
					}
				}
			}
			catch (Exception ex)
			{
				MessBox.smethod_0(ex.ToString());
			}
		}

		// Token: 0x04002021 RID: 8225
		public int int_0;

		// Token: 0x04002022 RID: 8226
		public TabLogin tabLogin_0;
	}

	// Token: 0x02000338 RID: 824
	[CompilerGenerated]
	private sealed class Class595
	{
		// Token: 0x04002023 RID: 8227
		public int int_0;

		// Token: 0x04002024 RID: 8228
		public TabLogin.Class594 class594_0;
	}

	// Token: 0x02000339 RID: 825
	[CompilerGenerated]
	private sealed class Class596
	{
		// Token: 0x06002BCF RID: 11215 RVA: 0x0013DD2C File Offset: 0x0013BF2C
		internal void method_0()
		{
			Class400 @class = new Class400(null);
			@class.String_6 = this.string_0;
			@class.String_8 = this.string_0;
			@class.String_9 = "VinaGame";
			@class.String_11 = "Thiên Long 38";
			@class.String_10 = string.Empty;
			this.class595_0.class594_0.tabLogin_0.method_10(@class);
			int int_ = this.class595_0.int_0;
			this.class595_0.int_0 = int_ + 1;
		}

		// Token: 0x04002025 RID: 8229
		public string string_0;

		// Token: 0x04002026 RID: 8230
		public TabLogin.Class595 class595_0;
	}

	// Token: 0x0200033A RID: 826
	[CompilerGenerated]
	private sealed class Class597
	{
		// Token: 0x06002BD1 RID: 11217 RVA: 0x0001D384 File Offset: 0x0001B584
		internal void method_0()
		{
			GUI.smethod_3(this.ienumerable_0.ToList<Class106>());
		}

		// Token: 0x04002027 RID: 8231
		public IEnumerable<Class106> ienumerable_0;
	}

	// Token: 0x0200033B RID: 827
	[CompilerGenerated]
	private sealed class Class598
	{
		// Token: 0x06002BD3 RID: 11219 RVA: 0x0001D396 File Offset: 0x0001B596
		internal void method_0(object sender, EventArgs e)
		{
			this.tabLogin_0.list_2 = this.tabLogin_0.list_2.Except<Class400>(this.list_0).ToList<Class400>();
			this.tabLogin_0.txtSearch_TextChanged(null, null);
		}

		// Token: 0x04002028 RID: 8232
		public TabLogin tabLogin_0;

		// Token: 0x04002029 RID: 8233
		public List<Class400> list_0;
	}

	// Token: 0x0200033C RID: 828
	[CompilerGenerated]
	private sealed class Class599
	{
		// Token: 0x06002BD5 RID: 11221 RVA: 0x0001D3CB File Offset: 0x0001B5CB
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_11 = (this.object_0 as ToolStripMenuItem).Text;
		}

		// Token: 0x0400202A RID: 8234
		public object object_0;
	}

	// Token: 0x0200033D RID: 829
	[CompilerGenerated]
	private sealed class Class600
	{
		// Token: 0x06002BD7 RID: 11223 RVA: 0x0001D3E3 File Offset: 0x0001B5E3
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_10 = (this.object_0 as ToolStripMenuItem).Text;
		}

		// Token: 0x0400202B RID: 8235
		public object object_0;
	}

	// Token: 0x0200033E RID: 830
	[CompilerGenerated]
	private sealed class Class601
	{
		// Token: 0x06002BD9 RID: 11225 RVA: 0x0001D3FB File Offset: 0x0001B5FB
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_24 = this.openFileDialog_0.FileName;
		}

		// Token: 0x0400202C RID: 8236
		public OpenFileDialog openFileDialog_0;
	}

	// Token: 0x0200033F RID: 831
	[CompilerGenerated]
	private sealed class Class602
	{
		// Token: 0x06002BDB RID: 11227 RVA: 0x0013DDAC File Offset: 0x0013BFAC
		internal void method_0(object sender, EventArgs e)
		{
			IEnumerable<Class400> ienumerable_ = this.tabLogin_0.IEnumerable_0;
			Action<Class400> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class400>(this.method_1));
			}
			ienumerable_.smethod_22<Class400>(action);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0001D40E File Offset: 0x0001B60E
		internal void method_1(Class400 class400_0)
		{
			class400_0.String_24 = this.string_0;
		}

		// Token: 0x0400202D RID: 8237
		public string string_0;

		// Token: 0x0400202E RID: 8238
		public TabLogin tabLogin_0;

		// Token: 0x0400202F RID: 8239
		public Action<Class400> action_0;
	}

	// Token: 0x02000340 RID: 832
	[CompilerGenerated]
	private sealed class Class603
	{
		// Token: 0x06002BDE RID: 11230 RVA: 0x0013DDE8 File Offset: 0x0013BFE8
		internal void method_0(object sender, EventArgs e)
		{
			Action action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action(this.method_1));
			}
			Task.Run(action);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x0013DE1C File Offset: 0x0013C01C
		internal void method_1()
		{
			this.tabLogin_0.Enabled = false;
			try
			{
				string text = Class106.Class210_0["iLogin", this.valueTuple_0.Item1];
				string text2 = TabLogin.smethod_0(string.Concat(new string[]
				{
					Settings.Default.HomePage,
					"?cmd=saveilogin&email=",
					HttpUtility.UrlEncode(this.valueTuple_0.Item1),
					"&pass=",
					HttpUtility.UrlEncode(Class529.smethod_1(text)),
					"&iid=",
					HttpUtility.UrlEncode(GUI.string_1)
				}), this.tabLogin_0.method_8(text), "iMicroLogin" + this.tabLogin_0.string_0);
				this.tabLogin_0.Invoke(new Action(this.tabLogin_0.method_39));
				MessBox.smethod_0(text2);
			}
			catch (Exception ex)
			{
				MessBox.smethod_0(ex.ToString());
			}
			finally
			{
				this.tabLogin_0.Enabled = true;
			}
		}

		// Token: 0x04002030 RID: 8240
		public ValueTuple<string, string> valueTuple_0;

		// Token: 0x04002031 RID: 8241
		public TabLogin tabLogin_0;

		// Token: 0x04002032 RID: 8242
		public Action action_0;

		// Token: 0x04002033 RID: 8243
		public EventHandler eventHandler_0;
	}

	// Token: 0x02000341 RID: 833
	[CompilerGenerated]
	private sealed class Class604
	{
		// Token: 0x06002BE1 RID: 11233 RVA: 0x0013DF30 File Offset: 0x0013C130
		internal void method_0(object sender, EventArgs e)
		{
			MessBox messBox = MessBox.smethod_0("Are u Sure Upload To " + this.toolStripMenuItem_0.Text);
			Delegate eventHandler_ = messBox.EventHandler_0;
			EventHandler eventHandler;
			if ((eventHandler = this.class603_0.eventHandler_0) == null)
			{
				eventHandler = (this.class603_0.eventHandler_0 = new EventHandler(this.class603_0.method_0));
			}
			messBox.EventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_, eventHandler);
		}

		// Token: 0x04002034 RID: 8244
		public ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04002035 RID: 8245
		public TabLogin.Class603 class603_0;
	}

	// Token: 0x02000342 RID: 834
	[CompilerGenerated]
	private sealed class Class605
	{
		// Token: 0x06002BE3 RID: 11235 RVA: 0x0013DF9C File Offset: 0x0013C19C
		internal void method_0(object sender, EventArgs e)
		{
			Action action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action(this.method_1));
			}
			Task.Run(action);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0013DFD0 File Offset: 0x0013C1D0
		internal void method_1()
		{
			string text = string.Empty;
			try
			{
				string text2 = Class106.Class210_0["iLogin", this.valueTuple_0.Item1];
				string item = this.valueTuple_0.Item1;
				string text3 = "&email=" + HttpUtility.UrlEncode(item) + "&pass=" + HttpUtility.UrlEncode(Class529.smethod_1(text2));
				text = TabLogin.smethod_1(string.Concat(new string[]
				{
					Settings.Default.HomePage,
					"?cmd=loginilogin&u=",
					HttpUtility.UrlEncode(GUI.GUI_0.String_2),
					"&p=",
					HttpUtility.UrlEncode(GUI.GUI_0.String_3),
					"&iid=",
					HttpUtility.UrlEncode(GUI.string_1),
					text3
				}), "iMicroLogin" + this.tabLogin_0.string_0);
				if (text == "sai email hoặc mật khẩu")
				{
					this.tabLogin_0.Invoke(new Action(this.tabLogin_0.method_40));
					MessBox.smethod_0(text);
				}
				else
				{
					this.tabLogin_0.lvLogin.Invoke(new Action(this.tabLogin_0.method_41));
					this.tabLogin_0.method_0(text, text2);
				}
			}
			catch (Exception ex)
			{
				MessBox.smethod_0(ex.ToString());
			}
			finally
			{
				this.tabLogin_0.Enabled = true;
			}
		}

		// Token: 0x04002036 RID: 8246
		public ValueTuple<string, string> valueTuple_0;

		// Token: 0x04002037 RID: 8247
		public TabLogin tabLogin_0;

		// Token: 0x04002038 RID: 8248
		public Action action_0;
	}

	// Token: 0x02000343 RID: 835
	[CompilerGenerated]
	private sealed class Class606
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x0001D41C File Offset: 0x0001B61C
		internal void method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			keyValuePair_0.Value.Remove(this.class400_0.String_17);
		}

		// Token: 0x04002039 RID: 8249
		public Class400 class400_0;
	}

	// Token: 0x02000344 RID: 836
	[CompilerGenerated]
	private sealed class Class607
	{
		// Token: 0x06002BE8 RID: 11240 RVA: 0x0013E160 File Offset: 0x0013C360
		internal void method_0()
		{
			Class210 @class = new Class210(File.ReadAllText(this.openFileDialog_0.FileName));
			string text = string.Empty;
			text = @class["Settings", "Accounts"];
			if (!string.IsNullOrEmpty(text))
			{
				XmlDocument xmlDocument = new XmlDocument();
				text = TabLogin.smethod_6(text);
				xmlDocument.LoadXml(text);
				if (xmlDocument == null)
				{
					xmlDocument = TabLogin.smethod_7();
				}
				List<Class400> list = this.tabLogin_0.method_3(xmlDocument, null);
				this.tabLogin_0.method_9(list);
			}
		}

		// Token: 0x0400203A RID: 8250
		public OpenFileDialog openFileDialog_0;

		// Token: 0x0400203B RID: 8251
		public TabLogin tabLogin_0;
	}

	// Token: 0x02000345 RID: 837
	[CompilerGenerated]
	private sealed class Class608
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x0001D436 File Offset: 0x0001B636
		internal string method_0(string string_0)
		{
			XmlAttribute xmlAttribute = this.xmlElement_0.Attributes[string_0];
			string text;
			if (xmlAttribute != null)
			{
				if ((text = xmlAttribute.Value) != null)
				{
					return text;
				}
			}
			text = "";
			return text;
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0001D45E File Offset: 0x0001B65E
		internal bool method_1(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Contains(this.listViewItem_0.SubItems[2].Text);
		}

		// Token: 0x0400203C RID: 8252
		public XmlElement xmlElement_0;

		// Token: 0x0400203D RID: 8253
		public ListViewItem listViewItem_0;
	}

	// Token: 0x02000346 RID: 838
	[CompilerGenerated]
	private sealed class Class609
	{
		// Token: 0x06002BED RID: 11245 RVA: 0x0001D482 File Offset: 0x0001B682
		internal bool method_0(Class106 class106_0)
		{
			return class106_0.String_29 == this.class400_0.String_7;
		}

		// Token: 0x0400203E RID: 8254
		public Class400 class400_0;
	}

	// Token: 0x02000347 RID: 839
	[CompilerGenerated]
	private sealed class Class610
	{
		// Token: 0x06002BEF RID: 11247 RVA: 0x0013E1D8 File Offset: 0x0013C3D8
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_22 = this.toolStripMenuItem_0.Text.smethod_26().ToString();
		}

		// Token: 0x0400203F RID: 8255
		public ToolStripMenuItem toolStripMenuItem_0;
	}
}
