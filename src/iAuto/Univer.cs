using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x02000179 RID: 377
public partial class Univer : UserControl
{
	// Token: 0x06001633 RID: 5683 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_0(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x000AF10C File Offset: 0x000AD30C
	private void lvName_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.lvName.SelectedItems.Count <= 0)
		{
			this.txtAiDangCam.Text = string.Empty;
			return;
		}
		string[] array = Class106.List_3.Where<Class106>(new Func<Class106, bool>(this.method_19)).Select<Class106, string>(new Func<Class106, string>(Univer.Class258.f_7ECD44E1.method_0)).Select<string, string>(new Func<string, string>(Univer.Class258.f_7ECD44E1.method_1))
			.ToArray<string>();
		if (array.Length == 0)
		{
			return;
		}
		this.txtAiDangCam.Text = string.Join(Environment.NewLine, array);
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x0000FAF9 File Offset: 0x0000DCF9
	private void lvName_DoubleClick(object sender, EventArgs e)
	{
		this.method_1(null, null);
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x000AF1C0 File Offset: 0x000AD3C0
	private void method_1(object sender, EventArgs e)
	{
		foreach (object obj in this.lvName.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			if (this.String_0.Contains("Friend"))
			{
				string text = listViewItem.Text;
				if (this.cboPlayer.Text.Trim().Length > 0)
				{
					text = text + " {" + this.cboPlayer.Text + "}";
				}
				this.textName.Text = this.textName.Text.Trim() + "\r\n" + text;
				this.string_1 = this.string_1 + "\r\n" + text;
			}
			else if (this.String_0.Contains("Calender"))
			{
				string text = string.Concat(new string[]
				{
					this.txtFrom.Text,
					"->",
					this.txtTo.Text,
					"->",
					listViewItem.Text
				});
				if (this.cboPlayer.Text.Trim().Length > 0)
				{
					text = text + " {" + this.cboPlayer.Text + "}";
				}
				this.textName.Text = this.textName.Text.Trim() + "\r\n" + text;
			}
			else if (!this.String_0.Contains("Buy") && !this.String_0.Contains("Chia"))
			{
				if (this.String_0.Contains("Sale"))
				{
					string text = listViewItem.Text + "|" + this.textBox1.Text;
					this.textName.Text = this.textName.Text.Trim() + "\r\n" + text;
				}
				else
				{
					string text;
					if (this.checkLocked.Checked)
					{
						text = listViewItem.Text + " [Locked]";
					}
					else
					{
						text = listViewItem.Text;
					}
					if (this.cboPlayer.Text.Trim().Length > 0)
					{
						text = text + " {" + this.cboPlayer.Text + "}";
					}
					this.textName.Text = this.textName.Text.Trim() + "\r\n" + text;
				}
			}
			else
			{
				string text = this.textBox1.Text + "->" + listViewItem.Text;
				if (this.cboPlayer.Text.Trim().Length > 0)
				{
					text = text + " {" + this.cboPlayer.Text + "}";
				}
				this.textName.Text = this.textName.Text.Trim() + "\r\n" + text;
			}
		}
		this.textName.method_27();
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x000AF4FC File Offset: 0x000AD6FC
	private void method_2(object sender, EventArgs e)
	{
		string text = "";
		foreach (Class106 @class in Class106.IEnumerable_0)
		{
			text = text + @class.Class527_0.String_11 + Environment.NewLine;
		}
		Clipboard.SetText(text);
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_3(object sender, EventArgs e)
	{
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x000AF568 File Offset: 0x000AD768
	private void method_4(object sender, EventArgs e)
	{
		this.lvName.Items.Clear();
		this.lvName.AllItems.Clear();
		if (this.String_0.Contains("Skill"))
		{
			this.lvName.Items.AddRange(Class106.IEnumerable_0.SelectMany<Class106, Class525>(new Func<Class106, IEnumerable<Class525>>(Univer.Class258.f_7ECD44E1.method_2)).smethod_9<Class525, string>(new Func<Class525, string>(Univer.Class258.f_7ECD44E1.method_3)).Select<Class525, ListViewItem>(new Func<Class525, ListViewItem>(Univer.Class258.f_7ECD44E1.method_4))
				.ToArray<ListViewItem>());
			return;
		}
		if (this.String_0.Contains("Calender"))
		{
			this.lvName.Items.AddRange(Class501.List_0.Select<string, ListViewItem>(new Func<string, ListViewItem>(Univer.Class258.f_7ECD44E1.method_5)).ToArray<ListViewItem>());
			return;
		}
		if (!this.String_0.Contains("Friend") && !this.String_0.Contains("Black") && !this.String_0.Contains("AttackList") && !this.String_0.Contains("Fight") && !this.String_0.Contains("UuTien"))
		{
			string[] array = Class106.IEnumerable_0.SelectMany<Class106, string>(new Func<Class106, IEnumerable<string>>(Univer.Class258.f_7ECD44E1.method_10)).Distinct<string>().Concat<string>(new Class619<string>("Vàng"))
				.ToArray<string>();
			this.lvName.Items.AddRange(array.Select<string, ListViewItem>(new Func<string, ListViewItem>(Univer.Class258.f_7ECD44E1.method_12)).ToArray<ListViewItem>());
			this.lvName.Items.AddRange(Class106.Class106_0.Class214_0.IEnumerable_7.Where<Class516>(new Func<Class516, bool>(Univer.Class258.f_7ECD44E1.method_13)).Select<Class516, ListViewItem>(new Func<Class516, ListViewItem>(Univer.Class258.f_7ECD44E1.method_14)).ToArray<ListViewItem>());
			return;
		}
		this.lvName.Items.AddRange(Class106.IEnumerable_0.SelectMany<Class106, Class504>(new Func<Class106, IEnumerable<Class504>>(Univer.Class258.f_7ECD44E1.method_6)).SelectMany<Class504, string>(new Func<Class504, IEnumerable<string>>(Univer.Class258.f_7ECD44E1.method_7)).Where<string>(new Func<string, bool>(Univer.Class258.f_7ECD44E1.method_8))
			.Distinct<string>()
			.Select<string, ListViewItem>(new Func<string, ListViewItem>(Univer.Class258.f_7ECD44E1.method_9))
			.ToArray<ListViewItem>());
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_5(object sender, EventArgs e)
	{
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_6(object sender, EventArgs e)
	{
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x000AF884 File Offset: 0x000ADA84
	private void method_7(object sender, EventArgs5 e)
	{
		try
		{
			if (!this.String_0.Contains("Friend"))
			{
				this.string_1 = this.textName.Text;
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_8(object sender, EventArgs6 e)
	{
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x0000500B File Offset: 0x0000320B
	private void textName_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_9(object sender, EventArgs e)
	{
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x000AF8CC File Offset: 0x000ADACC
	private void cboPlayer_DropDown(object sender, EventArgs e)
	{
		this.cboPlayer.Items.Clear();
		this.cboPlayer.Items.Add("");
		ComboBox.ObjectCollection items = this.cboPlayer.Items;
		object[] array = Class106.List_3.Where<Class106>(new Func<Class106, bool>(Univer.Class258.f_7ECD44E1.method_15)).Select<Class106, string>(new Func<Class106, string>(Univer.Class258.f_7ECD44E1.method_16)).Distinct<string>()
			.ToArray<string>();
		items.AddRange(array);
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001641 RID: 5697 RVA: 0x0000FB03 File Offset: 0x0000DD03
	// (set) Token: 0x06001642 RID: 5698 RVA: 0x0000FB0B File Offset: 0x0000DD0B
	public string String_0 { get; set; } = string.Empty;

	// Token: 0x06001643 RID: 5699 RVA: 0x000AF968 File Offset: 0x000ADB68
	private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (this.String_0.Contains("Friend"))
			{
				string text = "";
				foreach (string text2 in this.string_1.Split(new char[] { '\n' }))
				{
					if (string.IsNullOrEmpty(this.cboPlayer.Text) || text2.Contains("{"))
					{
						if (text2.Contains("{"))
						{
							if (text2.Contains(this.cboPlayer.Text) && !string.IsNullOrEmpty(this.cboPlayer.Text) && !text.Contains(text2.Trim()))
							{
								text = text + text2 + "\r\n";
							}
						}
						else
						{
							text = text + text2 + "\r\n";
						}
					}
				}
				text = string.Join("\n", text.Split(new char[] { '\n' }).Distinct<string>().ToArray<string>());
				this.textName.Event_2 -= this.method_7;
				this.textName.Text = text;
				this.textName.Text = string.Join("\n", this.textName.Text.Split(new char[] { '\n' }).Distinct<string>().ToArray<string>());
				this.textName.Event_2 += this.method_7;
			}
			this.string_1 = string.Join("\n", this.string_1.Split(new char[] { '\n' }).Distinct<string>().ToArray<string>());
		}
		catch
		{
		}
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x000AFB28 File Offset: 0x000ADD28
	private void cboPlayer_TextChanged(object sender, EventArgs e)
	{
		Univer.Class259 @class = new Univer.Class259();
		ComboBox comboBox = sender as ComboBox;
		@class.string_0 = comboBox.Text.smethod_36();
		this.lbPlayer.Visible = false;
		if (string.IsNullOrEmpty(@class.string_0))
		{
			return;
		}
		string[] array = Class106.List_3.Where<Class106>(new Func<Class106, bool>(Univer.Class258.f_7ECD44E1.method_17)).Select<Class106, string>(new Func<Class106, string>(Univer.Class258.f_7ECD44E1.method_18)).Where<string>(new Func<string, bool>(@class.method_0))
			.ToArray<string>();
		if (array.Length == 0)
		{
			return;
		}
		this.lbPlayer.Items.Clear();
		ListBox.ObjectCollection items = this.lbPlayer.Items;
		object[] array2 = array;
		items.AddRange(array2);
		this.lbPlayer.Visible = true;
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x000AFC08 File Offset: 0x000ADE08
	private void btnSave_Click(object sender, EventArgs e)
	{
		string text = this.String_0;
		if (text != null)
		{
			switch (text.Length)
			{
			case 3:
			{
				char c = text[0];
				if (c != 'B')
				{
					if (c == 'U')
					{
						if (text == "Use")
						{
							Class106.Class210_0["Settings", "UseName"] = this.string_1;
						}
					}
				}
				else if (text == "Buy")
				{
					Class106.Class210_0["Settings", "BuyName"] = this.string_1;
				}
				break;
			}
			case 4:
			{
				char c = text[2];
				if (c != 'a')
				{
					switch (c)
					{
					case 'i':
						if (text == "Chia")
						{
							Class106.Class210_0["Settings", "Chia"] = this.string_1;
						}
						break;
					case 'k':
						if (text == "Take")
						{
							Class106.Class210_0["Settings", "LayName"] = this.string_1;
						}
						break;
					case 'l':
						if (!(text == "Sell"))
						{
							if (text == "Sale")
							{
								Class106.Class210_0["Settings", "Sale"] = this.string_1;
							}
						}
						else
						{
							Class106.Class210_0["Settings", "SellName"] = this.string_1;
						}
						break;
					case 'n':
						if (text == "Bank")
						{
							Class106.Class210_0["Settings", "CatName"] = this.string_1;
						}
						break;
					case 'o':
						if (text == "Drop")
						{
							Class106.Class210_0["Settings", "DropName"] = this.string_1;
						}
						break;
					}
				}
				else if (text == "Team")
				{
					this.toDoi_0.method_7();
				}
				break;
			}
			case 5:
			{
				char c = text[0];
				if (c <= 'F')
				{
					if (c != 'B')
					{
						if (c == 'F')
						{
							if (text == "Fight")
							{
								Class106.Class210_0["Settings", "TuyenChien"] = this.string_1;
							}
						}
					}
					else if (text == "Black")
					{
						Class106.Class210_0["Settings", "BoQua"] = this.string_1;
					}
				}
				else if (c != 'P')
				{
					if (c == 'S')
					{
						if (text == "Skill")
						{
							Class106.Class210_0["Settings", "Skill"] = this.string_1;
						}
					}
				}
				else if (text == "Point")
				{
					Class106.Class210_0["Settings", "Point"] = this.string_1;
				}
				break;
			}
			case 6:
			{
				char c = text[0];
				if (c != 'F')
				{
					if (c == 'U')
					{
						if (text == "UuTien")
						{
							Class106.Class210_0["Settings", "UuTien"] = this.string_1;
						}
					}
				}
				else if (text == "Friend")
				{
					this.method_12();
					Class106.Class210_0["Settings", "BanBe"] = this.string_1;
				}
				break;
			}
			case 7:
				if (text == "Collect")
				{
					Class106.Class210_0["Settings", "GomName"] = this.string_1;
				}
				break;
			case 8:
			{
				char c = text[2];
				if (c != 'c')
				{
					switch (c)
					{
					case 'k':
						if (text == "TakeTemp")
						{
							Class106.Class210_0["Settings", "LayThienCoName"] = this.string_1;
						}
						break;
					case 'l':
						if (text == "Calender")
						{
							Class106.Class210_0["Settings", "Calender"] = this.string_1;
						}
						break;
					case 'm':
						if (text == "TempBank")
						{
							Class106.Class210_0["Settings", "CatThienCoName"] = this.string_1;
						}
						break;
					}
				}
				else if (text == "PickList")
				{
					Class106.Class210_0["Settings", "ChiNhat"] = this.string_1;
				}
				break;
			}
			case 10:
			{
				char c = text[0];
				if (c != 'A')
				{
					if (c == 'C')
					{
						if (text == "CollectKNB")
						{
							Class106.Class210_0["Settings", "GomKNBName"] = this.string_1;
						}
					}
				}
				else if (text == "AttackList")
				{
					Class106.Class210_0["Settings", "ChiDanh"] = this.string_1;
				}
				break;
			}
			}
		}
		Class106.List_3.Where<Class106>(new Func<Class106, bool>(Univer.Class258.f_7ECD44E1.method_19)).smethod_22<Class106>(new Action<Class106>(Univer.Class258.f_7ECD44E1.method_20));
		Class226.smethod_3();
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_10(object sender, EventArgs e)
	{
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x000B0168 File Offset: 0x000AE368
	private void method_11(object sender, TreeViewEventArgs e)
	{
		string text = e.Node.Tag.ToString();
		if (text.Contains("Drop"))
		{
			Class226.Boolean_59 = e.Node.Checked;
		}
		if (text.Contains("Sell"))
		{
			Class226.Boolean_108 = e.Node.Checked;
		}
		if (text.Contains("Use"))
		{
			Class226.Boolean_134 = e.Node.Checked;
		}
		if (text.Contains("Buy"))
		{
			Class226.Boolean_43 = e.Node.Checked;
		}
		if (text.Contains("TempBank"))
		{
			Class226.Boolean_28 = e.Node.Checked;
		}
		else if (text.Contains("Bank"))
		{
			Class226.Boolean_27 = e.Node.Checked;
		}
		if (text.Contains("Collect"))
		{
			Class226.Boolean_51 = e.Node.Checked;
		}
		if (text.Contains("CollectKNB"))
		{
			Class226.Boolean_52 = e.Node.Checked;
		}
		if (text.Contains("TakeTemp"))
		{
			Class226.Boolean_111 = e.Node.Checked;
		}
		else if (text.Contains("Take"))
		{
			Class226.Boolean_110 = e.Node.Checked;
		}
		if (text.Contains("Friend"))
		{
			Class226.Boolean_71 = e.Node.Checked;
		}
		if (text.Contains("Black"))
		{
			Class226.Boolean_31 = e.Node.Checked;
		}
		if (text.Contains("Calender"))
		{
			Class226.Boolean_132 = e.Node.Checked;
		}
		if (text.Contains("PickList"))
		{
			Class226.Boolean_105 = e.Node.Checked;
		}
		if (text.Contains("AttackList"))
		{
			Class226.Boolean_19 = e.Node.Checked;
		}
		if (text.Contains("Fight"))
		{
			Class226.Boolean_69 = e.Node.Checked;
		}
		if (text.Contains("Team"))
		{
			Class226.Boolean_20 = e.Node.Checked;
		}
		if (text.Contains("UuTien"))
		{
			Class226.Boolean_137 = e.Node.Checked;
		}
		if (text.Contains("Skill"))
		{
			Class226.Boolean_49 = e.Node.Checked;
		}
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x000B03B4 File Offset: 0x000AE5B4
	public void method_12()
	{
		if (this.String_0.Contains("Friend"))
		{
			if (!string.IsNullOrEmpty(this.cboPlayer.Text))
			{
				this.textName.Event_2 -= this.method_7;
				string text = string.Empty;
				foreach (string text2 in this.textName.Text.Split(new char[] { '\n' }))
				{
					if (text2.Trim().Length > 0)
					{
						if (!text2.Contains("{"))
						{
							text = string.Concat(new string[]
							{
								text,
								text2.Trim(),
								" {",
								this.cboPlayer.Text,
								"}\r\n"
							});
						}
						else
						{
							text = text + text2.Trim() + "\r\n";
						}
					}
				}
				this.textName.Text = text;
				this.textName.Event_2 += this.method_7;
			}
			foreach (string text3 in this.textName.Text.Split(new char[] { '\n' }))
			{
				if (!string.IsNullOrEmpty(this.cboPlayer.Text) && !text3.Contains("{"))
				{
					this.string_1 = string.Concat(new string[]
					{
						this.string_1,
						"\r\n",
						text3.Trim(),
						" {",
						this.cboPlayer.Text,
						"}"
					});
				}
				else
				{
					this.string_1 = this.string_1 + "\r\n" + text3.Trim();
				}
			}
			try
			{
				if (!string.IsNullOrEmpty(this.cboPlayer.Text))
				{
					foreach (string text4 in this.string_1.Split(new char[] { '\n' }))
					{
						if (text4.Contains("{" + this.cboPlayer.Text + "}") && !this.textName.Text.Contains(text4.Trim()))
						{
							this.string_1 = this.string_1.Replace(text4, "");
						}
					}
				}
				else
				{
					foreach (string text5 in this.string_1.Split(new char[] { '\n' }))
					{
						if (!text5.Contains('{') && !this.textName.Text.Contains(text5.Trim()))
						{
							this.string_1 = this.string_1.Replace(text5, "");
						}
					}
				}
			}
			catch
			{
			}
			this.string_1 = string.Join("\n", this.string_1.Split(new char[] { '\n' }).Distinct<string>().ToArray<string>());
		}
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_13(object sender, TreeViewEventArgs e)
	{
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_14(object sender, EventArgs e)
	{
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_15(object sender, EventArgs e)
	{
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x000B06C0 File Offset: 0x000AE8C0
	public Univer()
	{
		this.InitializeComponent();
		base.Controls.Add(this.toDoi_0);
		base.Controls.Add(this.autoMap_0);
		this.toDoi_0.SendToBack();
		this.autoMap_0.SendToBack();
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x0000FB14 File Offset: 0x0000DD14
	private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
	{
		this.method_11(sender, e);
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x000B074C File Offset: 0x000AE94C
	public void method_16()
	{
		foreach (object obj in this.treeView1.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			if (treeNode.Tag != null)
			{
				string text = treeNode.Tag.ToString();
				if (text != null)
				{
					switch (text.Length)
					{
					case 3:
					{
						char c = text[0];
						if (c != 'B')
						{
							if (c == 'U')
							{
								if (text == "Use")
								{
									treeNode.Text = "Use";
								}
							}
						}
						else if (text == "Buy")
						{
							treeNode.Text = "Buy";
						}
						break;
					}
					case 4:
					{
						char c = text[2];
						if (c != 'a')
						{
							switch (c)
							{
							case 'k':
								if (text == "Take")
								{
									treeNode.Text = "Take";
								}
								break;
							case 'l':
								if (!(text == "Sell"))
								{
									if (text == "Sale")
									{
										treeNode.Text = "Sale";
									}
								}
								else
								{
									treeNode.Text = "Sell";
								}
								break;
							case 'n':
								if (text == "Bank")
								{
									treeNode.Text = "Bank";
								}
								break;
							case 'o':
								if (text == "Drop")
								{
									treeNode.Text = "Drop";
								}
								break;
							}
						}
						else if (text == "Team")
						{
							treeNode.Text = "Team";
						}
						break;
					}
					case 5:
					{
						char c = text[0];
						if (c != 'B')
						{
							if (c != 'F')
							{
								if (c == 'P')
								{
									if (text == "Point")
									{
										treeNode.Text = "Point";
									}
								}
							}
							else if (text == "Fight")
							{
								treeNode.Text = "Fight";
							}
						}
						else if (text == "Black")
						{
							treeNode.Text = "Black List";
						}
						break;
					}
					case 6:
					{
						char c = text[0];
						if (c != 'F')
						{
							if (c == 'U')
							{
								if (text == "UuTien")
								{
									treeNode.Text = "Priority List";
								}
							}
						}
						else if (text == "Friend")
						{
							treeNode.Text = "Friend List";
						}
						break;
					}
					case 7:
						if (text == "Collect")
						{
							treeNode.Text = "Collect";
						}
						break;
					case 8:
					{
						char c = text[2];
						if (c != 'C')
						{
							if (c != 'c')
							{
								switch (c)
								{
								case 'k':
									if (text == "TakeTemp")
									{
										treeNode.Text = "TakeTempBag";
									}
									break;
								case 'l':
									if (text == "Calender")
									{
										treeNode.Text = "Schedule";
									}
									break;
								case 'm':
									if (text == "TempBank")
									{
										treeNode.Text = "PutTempBag";
									}
									break;
								}
							}
							else if (text == "PickList")
							{
								treeNode.Text = "Pick List";
							}
						}
						else if (text == "DiChuyen")
						{
							treeNode.Text = "Point List";
						}
						break;
					}
					case 10:
					{
						char c = text[0];
						if (c != 'A')
						{
							if (c == 'C')
							{
								if (text == "CollectKNB")
								{
									treeNode.Text = "CollectYuanbao";
								}
							}
						}
						else if (text == "AttackList")
						{
							treeNode.Text = "Attack List";
						}
						break;
					}
					}
				}
			}
		}
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x000B0B60 File Offset: 0x000AED60
	public void method_17()
	{
		foreach (object obj in this.treeView1.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			if (treeNode.Tag != null)
			{
				string text = treeNode.Tag.ToString();
				if (text != null)
				{
					switch (text.Length)
					{
					case 3:
					{
						char c = text[0];
						if (c != 'B')
						{
							if (c == 'U')
							{
								if (text == "Use")
								{
									treeNode.Text = "Dùng";
								}
							}
						}
						else if (text == "Buy")
						{
							treeNode.Text = "Mua";
						}
						break;
					}
					case 4:
					{
						char c = text[2];
						if (c != 'a')
						{
							switch (c)
							{
							case 'k':
								if (text == "Take")
								{
									treeNode.Text = "Lấy";
								}
								break;
							case 'l':
								if (!(text == "Sell"))
								{
									if (text == "Sale")
									{
										treeNode.Text = "Treo Shop";
									}
								}
								else
								{
									treeNode.Text = "Bán";
								}
								break;
							case 'n':
								if (text == "Bank")
								{
									treeNode.Text = "Cất";
								}
								break;
							case 'o':
								if (text == "Drop")
								{
									treeNode.Text = "Hủy";
								}
								break;
							}
						}
						else if (text == "Team")
						{
							treeNode.Text = "Tổ Đội";
						}
						break;
					}
					case 5:
					{
						char c = text[0];
						if (c != 'B')
						{
							if (c != 'F')
							{
								if (c == 'P')
								{
									if (text == "Point")
									{
										treeNode.Text = "Point";
									}
								}
							}
							else if (text == "Fight")
							{
								treeNode.Text = "Tuyên Chiến";
							}
						}
						else if (text == "Black")
						{
							treeNode.Text = "Bỏ Qua";
						}
						break;
					}
					case 6:
					{
						char c = text[0];
						if (c != 'F')
						{
							if (c == 'U')
							{
								if (text == "UuTien")
								{
									treeNode.Text = "Ưu Tiên";
								}
							}
						}
						else if (text == "Friend")
						{
							treeNode.Text = "Bạn Bè";
						}
						break;
					}
					case 7:
						if (text == "Collect")
						{
							treeNode.Text = "Gom";
						}
						break;
					case 8:
					{
						char c = text[2];
						if (c != 'C')
						{
							if (c != 'c')
							{
								switch (c)
								{
								case 'k':
									if (text == "TakeTemp")
									{
										treeNode.Text = "Lấy Thiên Cơ";
									}
									break;
								case 'l':
									if (text == "Calender")
									{
										treeNode.Text = "Lịch";
									}
									break;
								case 'm':
									if (text == "TempBank")
									{
										treeNode.Text = "Cất Thiên Cơ";
									}
									break;
								}
							}
							else if (text == "PickList")
							{
								treeNode.Text = "Chỉ Nhặt";
							}
						}
						else if (text == "DiChuyen")
						{
							treeNode.Text = "Di Chuyển";
						}
						break;
					}
					case 10:
					{
						char c = text[0];
						if (c != 'A')
						{
							if (c == 'C')
							{
								if (text == "CollectKNB")
								{
									treeNode.Text = "Gom KNB";
								}
							}
						}
						else if (text == "AttackList")
						{
							treeNode.Text = "Chỉ Đánh";
						}
						break;
					}
					}
				}
			}
		}
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x000B0F74 File Offset: 0x000AF174
	public void method_18()
	{
		string text = this.String_0;
		if (text != null)
		{
			switch (text.Length)
			{
			case 3:
			{
				char c = text[0];
				if (c != 'B')
				{
					if (c == 'U')
					{
						if (text == "Use")
						{
							this.textName.Text = Class106.Class210_0["Settings", "UseName"];
						}
					}
				}
				else if (text == "Buy")
				{
					this.textName.Text = Class106.Class210_0["Settings", "BuyName"];
				}
				break;
			}
			case 4:
			{
				char c = text[0];
				switch (c)
				{
				case 'B':
					if (text == "Bank")
					{
						this.textName.Text = Class106.Class210_0["Settings", "CatName"];
					}
					break;
				case 'C':
					if (text == "Chia")
					{
						this.textName.Text = Class106.Class210_0["Settings", "Chia"];
					}
					break;
				case 'D':
					if (text == "Drop")
					{
						this.textName.Text = Class106.Class210_0["Settings", "DropName"];
					}
					break;
				default:
					if (c != 'S')
					{
						if (c == 'T')
						{
							if (text == "Take")
							{
								this.textName.Text = Class106.Class210_0["Settings", "LayName"];
							}
						}
					}
					else if (!(text == "Sell"))
					{
						if (text == "Sale")
						{
							this.textName.Text = Class106.Class210_0["Settings", "Sale"];
						}
					}
					else
					{
						this.textName.Text = Class106.Class210_0["Settings", "SellName"];
					}
					break;
				}
				break;
			}
			case 5:
			{
				char c = text[0];
				if (c <= 'F')
				{
					if (c != 'B')
					{
						if (c == 'F')
						{
							if (text == "Fight")
							{
								this.textName.Text = Class106.Class210_0["Settings", "TuyenChien"];
							}
						}
					}
					else if (text == "Black")
					{
						this.textName.Text = Class106.Class210_0["Settings", "BoQua"];
					}
				}
				else if (c != 'P')
				{
					if (c == 'S')
					{
						if (text == "Skill")
						{
							this.textName.Text = Class106.Class210_0["Settings", "Skill"];
						}
					}
				}
				else if (text == "Point")
				{
					this.textName.Text = Class106.Class210_0["Settings", "Point"];
				}
				break;
			}
			case 6:
			{
				char c = text[0];
				if (c != 'F')
				{
					if (c == 'U')
					{
						if (text == "UuTien")
						{
							this.textName.Text = Class106.Class210_0["Settings", "UuTien"];
						}
					}
				}
				else if (text == "Friend")
				{
					this.string_1 = Class106.Class210_0["Settings", "BanBe"];
					this.textName.Text = this.string_1;
				}
				break;
			}
			case 7:
				if (text == "Collect")
				{
					this.textName.Text = Class106.Class210_0["Settings", "GomName"];
				}
				break;
			case 8:
			{
				char c = text[2];
				if (c != 'c')
				{
					switch (c)
					{
					case 'k':
						if (text == "TakeTemp")
						{
							this.textName.Text = Class106.Class210_0["Settings", "LayThienCoName"];
						}
						break;
					case 'l':
						if (text == "Calender")
						{
							this.textName.Text = Class106.Class210_0["Settings", "Calender"];
						}
						break;
					case 'm':
						if (text == "TempBank")
						{
							this.textName.Text = Class106.Class210_0["Settings", "CatThienCoName"];
						}
						break;
					}
				}
				else if (text == "PickList")
				{
					this.textName.Text = Class106.Class210_0["Settings", "ChiNhat"];
				}
				break;
			}
			case 10:
			{
				char c = text[0];
				if (c != 'A')
				{
					if (c == 'C')
					{
						if (text == "CollectKNB")
						{
							this.textName.Text = Class106.Class210_0["Settings", "GomKNBName"];
						}
					}
				}
				else if (text == "AttackList")
				{
					this.textName.Text = Class106.Class210_0["Settings", "ChiDanh"];
				}
				break;
			}
			}
		}
		this.method_4(null, null);
		this.cboPlayer_SelectedIndexChanged(null, null);
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x000B14D4 File Offset: 0x000AF6D4
	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (this.treeView1.SelectedNode.Tag == "Team")
		{
			this.toDoi_0.BringToFront();
			this.toDoi_0.method_9();
		}
		else
		{
			this.toDoi_0.SendToBack();
		}
		if (this.treeView1.SelectedNode.Tag == "DiChuyen")
		{
			this.autoMap_0.BringToFront();
		}
		else
		{
			this.autoMap_0.SendToBack();
		}
		foreach (object obj in this.treeView1.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			if (treeNode != this.treeView1.SelectedNode)
			{
				treeNode.BackColor = this.treeView1.BackColor;
				treeNode.ForeColor = this.treeView1.ForeColor;
			}
		}
		if (this.treeView1.SelectedNode != null)
		{
			this.treeView1.SelectedNode.BackColor = SystemColors.Highlight;
			this.treeView1.SelectedNode.ForeColor = SystemColors.HighlightText;
			string text = this.treeView1.SelectedNode.Tag.ToString();
			this.String_0 = text;
			this.method_18();
		}
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x000B1620 File Offset: 0x000AF820
	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		Univer.Class260 @class = new Univer.Class260();
		@class.string_0 = this.txtSearch.Text.smethod_36();
		if (this.txtSearch.Text == string.Empty)
		{
			this.method_4(null, null);
		}
		this.lvName.Search(@class.string_0);
		this.textName.smethod_20(@class.string_0);
		this.lbSearch.Visible = false;
		this.lbPlayer.Visible = false;
		if (!string.IsNullOrEmpty(@class.string_0))
		{
			string[] array = this.textName.IList_0.Where<string>(new Func<string, bool>(@class.method_0)).ToArray<string>();
			if (array.Length != 0)
			{
				this.lbSearch.Items.Clear();
				ListBox.ObjectCollection items = this.lbSearch.Items;
				object[] array2 = array;
				items.AddRange(array2);
				this.lbSearch.Visible = true;
			}
		}
		if (!string.IsNullOrEmpty(@class.string_0))
		{
			string[] array3 = Class106.List_3.Where<Class106>(new Func<Class106, bool>(Univer.Class258.f_7ECD44E1.method_21)).Select<Class106, string>(new Func<Class106, string>(Univer.Class258.f_7ECD44E1.method_22)).Where<string>(new Func<string, bool>(@class.method_1))
				.ToArray<string>();
			if (array3.Length != 0)
			{
				this.lbPlayer.Items.Clear();
				ListBox.ObjectCollection items2 = this.lbPlayer.Items;
				object[] array2 = array3;
				items2.AddRange(array2);
				this.lbPlayer.Visible = true;
			}
		}
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0000FB1E File Offset: 0x0000DD1E
	private void lbSearch_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.txtSearch.Text = this.lbSearch.Text;
		this.lbSearch.Visible = false;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0000FB42 File Offset: 0x0000DD42
	private void lbPlayer_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.cboPlayer.Text = this.lbPlayer.SelectedItem.ToString();
		this.lbPlayer.Visible = false;
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x000B17AC File Offset: 0x000AF9AC
	private void Univer_Load(object sender, EventArgs e)
	{
		this.treeView1.AfterCheck -= this.treeView1_AfterCheck;
		foreach (object obj in this.treeView1.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			string text = treeNode.Tag.ToString();
			if (text.Contains("Drop"))
			{
				treeNode.Checked = Class226.Boolean_59;
			}
			if (text.Contains("Sell"))
			{
				treeNode.Checked = Class226.Boolean_108;
			}
			if (text.Contains("Use"))
			{
				treeNode.Checked = Class226.Boolean_134;
			}
			if (text.Contains("Buy"))
			{
				treeNode.Checked = Class226.Boolean_43;
			}
			if (text.Contains("TempBank"))
			{
				treeNode.Checked = Class226.Boolean_28;
			}
			else if (text.Contains("Bank"))
			{
				treeNode.Checked = Class226.Boolean_27;
			}
			if (text.Contains("Collect"))
			{
				treeNode.Checked = Class226.Boolean_51;
			}
			if (text.Contains("CollectKNB"))
			{
				treeNode.Checked = Class226.Boolean_52;
			}
			if (text.Contains("TakeTemp"))
			{
				treeNode.Checked = Class226.Boolean_111;
			}
			else if (text.Contains("Take"))
			{
				treeNode.Checked = Class226.Boolean_110;
			}
			if (text.Contains("Friend"))
			{
				treeNode.Checked = Class226.Boolean_71;
			}
			if (text.Contains("Black"))
			{
				treeNode.Checked = Class226.Boolean_31;
			}
			if (text.Contains("Calender"))
			{
				treeNode.Checked = Class226.Boolean_132;
			}
			if (text.Contains("PickList"))
			{
				treeNode.Checked = Class226.Boolean_105;
			}
			if (text.Contains("AttackList"))
			{
				treeNode.Checked = Class226.Boolean_19;
			}
			if (text.Contains("Fight"))
			{
				treeNode.Checked = Class226.Boolean_69;
			}
			if (text.Contains("Team"))
			{
				treeNode.Checked = Class226.Boolean_20;
			}
			if (text.Contains("UuTien"))
			{
				treeNode.Checked = Class226.Boolean_137;
			}
			if (text.Contains("Skill"))
			{
				treeNode.Checked = Class226.Boolean_49;
			}
		}
		this.treeView1.AfterCheck += this.treeView1_AfterCheck;
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x000B2D68 File Offset: 0x000B0F68
	[CompilerGenerated]
	private bool method_19(Class106 class106_0)
	{
		return class106_0.Class527_0.Boolean_41 && class106_0.List_10.Concat<Class516>(class106_0.List_11).Concat<Class516>(class106_0.List_12).Concat<Class516>(class106_0.List_13)
			.Any<Class516>(new Func<Class516, bool>(this.method_20));
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x000B2DBC File Offset: 0x000B0FBC
	[CompilerGenerated]
	private bool method_20(Class516 class516_0)
	{
		return class516_0.String_1 == this.lvName.SelectedItems[0].Text || class516_0.List_0.Contains(this.lvName.SelectedItems[0].Text);
	}

	// Token: 0x04000D74 RID: 3444
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000D75 RID: 3445
	public string string_1 = "";

	// Token: 0x04000D76 RID: 3446
	private ToDoi toDoi_0 = new ToDoi
	{
		Dock = DockStyle.Fill
	};

	// Token: 0x04000D77 RID: 3447
	private AutoMap autoMap_0 = new AutoMap
	{
		Dock = DockStyle.Fill
	};

	// Token: 0x0200017A RID: 378
	[CompilerGenerated]
	[Serializable]
	private sealed class Class258
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_0(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0000B939 File Offset: 0x00009B39
		internal string method_1(string string_0)
		{
			return string_0;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0000FB96 File Offset: 0x0000DD96
		internal IEnumerable<Class525> method_2(Class106 class106_0)
		{
			return class106_0.List_6;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		internal string method_3(Class525 class525_0)
		{
			return class525_0.String_0;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0000FBA6 File Offset: 0x0000DDA6
		internal ListViewItem method_4(Class525 class525_0)
		{
			return new ListViewItem(class525_0.String_0);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		internal ListViewItem method_5(string string_0)
		{
			return new ListViewItem(string_0);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0000B3B7 File Offset: 0x000095B7
		internal IEnumerable<Class504> method_6(Class106 class106_0)
		{
			return class106_0.Class506_0.List_0;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000B2E10 File Offset: 0x000B1010
		internal IEnumerable<string> method_7(Class504 class504_0)
		{
			return new string[]
			{
				class504_0.String_9,
				"Guild-" + class504_0.Int32_3.ToString(),
				class504_0.String_8,
				class504_0.String_5,
				class504_0.String_12
			};
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		internal bool method_8(string string_0)
		{
			return !string.IsNullOrEmpty(string_0);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		internal ListViewItem method_9(string string_0)
		{
			return new ListViewItem(string_0);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000B2E64 File Offset: 0x000B1064
		internal IEnumerable<string> method_10(Class106 class106_0)
		{
			return class106_0.List_10.Concat<Class516>(class106_0.List_11).Concat<Class516>(class106_0.List_12).Concat<Class516>(class106_0.List_13)
				.SelectMany<Class516, string>(new Func<Class516, IEnumerable<string>>(Univer.Class258.f_7ECD44E1.method_11));
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0000FBBE File Offset: 0x0000DDBE
		internal IEnumerable<string> method_11(Class516 class516_0)
		{
			return class516_0.List_0;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		internal ListViewItem method_12(string string_0)
		{
			return new ListViewItem(string_0);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0000FBC6 File Offset: 0x0000DDC6
		internal bool method_13(Class516 class516_0)
		{
			return class516_0.String_1 != string.Empty;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		internal ListViewItem method_14(Class516 class516_0)
		{
			return new ListViewItem(class516_0.String_1);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_15(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_16(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_17(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_18(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_19(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0000FBE5 File Offset: 0x0000DDE5
		internal void method_20(Class106 class106_0)
		{
			class106_0.method_450();
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_21(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_22(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x04000D8B RID: 3467
		public static readonly Univer.Class258 f_7ECD44E1 = new Univer.Class258();

		// Token: 0x04000D8C RID: 3468
		public static Func<Class106, string> f_3A236BCA;

		// Token: 0x04000D8D RID: 3469
		public static Func<string, string> f_1AC6C9AC;

		// Token: 0x04000D8E RID: 3470
		public static Func<Class106, IEnumerable<Class525>> f_B569A0D3;

		// Token: 0x04000D8F RID: 3471
		public static Func<Class525, string> f_AA28882C;

		// Token: 0x04000D90 RID: 3472
		public static Func<Class525, ListViewItem> f_0FFD2A17;

		// Token: 0x04000D91 RID: 3473
		public static Func<string, ListViewItem> f_FC905498;

		// Token: 0x04000D92 RID: 3474
		public static Func<Class106, IEnumerable<Class504>> f_8CEF290D;

		// Token: 0x04000D93 RID: 3475
		public static Func<Class504, IEnumerable<string>> f_4B7AD599;

		// Token: 0x04000D94 RID: 3476
		public static Func<string, bool> f_7F06BF77;

		// Token: 0x04000D95 RID: 3477
		public static Func<string, ListViewItem> f_F1C9EE7D;

		// Token: 0x04000D96 RID: 3478
		public static Func<Class516, IEnumerable<string>> f_04938E8B;

		// Token: 0x04000D97 RID: 3479
		public static Func<Class106, IEnumerable<string>> f_93ED82D6;

		// Token: 0x04000D98 RID: 3480
		public static Func<string, ListViewItem> f_E3D8A8AC;

		// Token: 0x04000D99 RID: 3481
		public static Func<Class516, bool> f_7DF6AF34;

		// Token: 0x04000D9A RID: 3482
		public static Func<Class516, ListViewItem> f_C1041D86;

		// Token: 0x04000D9B RID: 3483
		public static Func<Class106, bool> f_6EC929EC;

		// Token: 0x04000D9C RID: 3484
		public static Func<Class106, string> f_351BC80C;

		// Token: 0x04000D9D RID: 3485
		public static Func<Class106, bool> f_59B6594F;

		// Token: 0x04000D9E RID: 3486
		public static Func<Class106, string> f_A376578C;

		// Token: 0x04000D9F RID: 3487
		public static Func<Class106, bool> f_7C180633;

		// Token: 0x04000DA0 RID: 3488
		public static Action<Class106> f_FE3C5B1F;

		// Token: 0x04000DA1 RID: 3489
		public static Func<Class106, bool> f_3DEA3224;

		// Token: 0x04000DA2 RID: 3490
		public static Func<Class106, string> f_4F6F1259;
	}

	// Token: 0x0200017B RID: 379
	[CompilerGenerated]
	private sealed class Class259
	{
		// Token: 0x06001674 RID: 5748 RVA: 0x0000FBED File Offset: 0x0000DDED
		internal bool method_0(string string_1)
		{
			return string_1.smethod_36().Contains(this.string_0);
		}

		// Token: 0x04000DA3 RID: 3491
		public string string_0;
	}

	// Token: 0x0200017C RID: 380
	[CompilerGenerated]
	private sealed class Class260
	{
		// Token: 0x06001676 RID: 5750 RVA: 0x0000FC00 File Offset: 0x0000DE00
		internal bool method_0(string string_1)
		{
			return string_1.smethod_36().Contains(this.string_0);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0000FC00 File Offset: 0x0000DE00
		internal bool method_1(string string_1)
		{
			return string_1.smethod_36().Contains(this.string_0);
		}

		// Token: 0x04000DA4 RID: 3492
		public string string_0;
	}
}
