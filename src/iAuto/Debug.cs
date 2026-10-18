using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _i;

// Token: 0x0200019D RID: 413
internal partial class Debug : Form
{
	// Token: 0x0600176E RID: 5998 RVA: 0x00010441 File Offset: 0x0000E641
	public Debug(Class106 class106_1)
	{
		this.Class106_0 = class106_1;
		this.InitializeComponent();
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x0600176F RID: 5999 RVA: 0x0001046B File Offset: 0x0000E66B
	// (set) Token: 0x06001770 RID: 6000 RVA: 0x00010473 File Offset: 0x0000E673
	public Class106 Class106_0 { get; set; }

	// Token: 0x06001771 RID: 6001 RVA: 0x000C332C File Offset: 0x000C152C
	private void btnDoString_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_375(this.txtDoString.Text, false);
		this.txtToString.Text = this.Class106_0.method_488(true);
		Thread.Sleep(1);
		this.txtToString.Text = this.Class106_0.method_488(true);
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x000C3384 File Offset: 0x000C1584
	private void allToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class504 @class in this.Class106_0.Class506_0.List_0)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_4.ToString());
			listViewItem.SubItems.Add(@class.String_9);
			listViewItem.SubItems.Add(@class.method_1(this.Class106_0).ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x000C344C File Offset: 0x000C164C
	private void lvObject_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.pgGameObject.SelectedObject = this.lvObject.SelectedItems[0].Tag;
		if (this.lvObject.SelectedItems[0].Tag.GetType() == typeof(Class504))
		{
			this.Class106_0.method_381((long)(this.lvObject.SelectedItems[0].Tag as Class504).Int32_4, 100L);
		}
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x000C34DC File Offset: 0x000C16DC
	private void packetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_0)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.SubItems.Add(@class.Int32_8.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x000C3598 File Offset: 0x000C1798
	private void thienCoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_5)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.SubItems.Add(@class.Boolean_6.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x000C3654 File Offset: 0x000C1854
	private void trangBiToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_6)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x0000500B File Offset: 0x0000320B
	private void testToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x000C36F4 File Offset: 0x000C18F4
	private void Debug_Load(object sender, EventArgs e)
	{
		base.Icon = Class616.Icon_0;
		try
		{
			if (this.Class106_0 != null)
			{
				this.pgTLBB.SelectedObject = this.Class106_0.Class527_0;
				this.pgGame.SelectedObject = this.Class106_0;
				this.pgAddresss.SelectedObject = this.Class106_0.Class502_0;
				this.Text = this.Class106_0.Class527_0.String_11;
			}
		}
		catch (Exception ex)
		{
			this.Text = ex.ToString();
		}
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x0001047C File Offset: 0x0000E67C
	private void btnPush_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_493(this.txtPushDebugMessage.Text);
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x000C3788 File Offset: 0x000C1988
	private void tuiChanNguyenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_7)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x000C3828 File Offset: 0x000C1A28
	private void instanceToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			string text = string.Concat(new string[]
			{
				"public static NPC ",
				Class531.smethod_26(@class.String_9).Replace(" ", ""),
				"  = new NPC()\r\n{\r\n\tId = ",
				@class.Int32_4.ToString(),
				",\r\n\tX = ",
				@class.Int32_11.ToString(),
				",\r\n\tY = ",
				@class.Int32_12.ToString(),
				",\r\n\tMap = Id,\r\n\tName = \"",
				@class.String_9,
				"\"\r\n};"
			});
			MessageBox.Show(this, text, "MicroAuto", MessageBoxButtons.OK);
			Clipboard.SetText(text);
		}
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x000C3934 File Offset: 0x000C1B34
	private void gameTaskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class510 @class in Class510.smethod_2(this.Class106_0))
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x000C39D8 File Offset: 0x000C1BD8
	private void button2_Click(object sender, EventArgs e)
	{
		string text = "";
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Game.exe |Game.exe";
		if (openFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			byte[] array = File.ReadAllBytes(openFileDialog.FileName);
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				byte[] array2 = File.ReadAllBytes(openFileDialog.FileName);
				int num = 0;
				while (num < array.Length && num < array2.Length)
				{
					if (array[num] != array2[num] && (array2[num] == 144 || array2[num] == 235))
					{
						text = string.Concat(new string[]
						{
							text,
							num.ToString(),
							":",
							array[num].ToString("X2"),
							"=>",
							array2[num].ToString("X2"),
							"\r\n"
						});
					}
					num++;
				}
				this.txtDoString.Text = text;
			}
		}
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x000C3AD8 File Offset: 0x000C1CD8
	private void skillToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class525 @class in this.Class106_0.List_6)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_1.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x000C3B7C File Offset: 0x000C1D7C
	private void questFrameItemToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class519 @class in this.Class106_0.Class520_0.List_0)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00010494 File Offset: 0x0000E694
	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		this.lvObject.Search(this.textBox1.Text);
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x000C3C24 File Offset: 0x000C1E24
	private void lootToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_11)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000104AC File Offset: 0x0000E6AC
	private void collectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Class516)this.lvObject.SelectedItems[0].Tag).method_10();
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000104CE File Offset: 0x0000E6CE
	private void btnSendPacket_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_166(this.txtPacket.Text);
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x000C3CC4 File Offset: 0x000C1EC4
	private void shopToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_9)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x000C3D64 File Offset: 0x000C1F64
	private void bankToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_10)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x000C3E04 File Offset: 0x000C2004
	private void teamToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class526 @class in this.Class106_0.List_15)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x0000500B File Offset: 0x0000320B
	private void gameControlToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x000C3EA8 File Offset: 0x000C20A8
	private void sellToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class516)
		{
			(this.lvObject.SelectedItems[0].Tag as Class516).method_11();
		}
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x000C3F08 File Offset: 0x000C2108
	private void doActionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.lvObject.SelectedItems)
		{
			(((ListViewItem)obj).Tag as Class516).method_7();
		}
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x000C3F70 File Offset: 0x000C2170
	private void doSubActionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.lvObject.SelectedItems)
		{
			(((ListViewItem)obj).Tag as Class516).method_8();
		}
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x000C3FD8 File Offset: 0x000C21D8
	private void btnSniff_Click(object sender, EventArgs e)
	{
		this.panSniff.SuspendLayout();
		while (this.Class106_0.list_9.Count > 0)
		{
			Debug.Class285 @class = new Debug.Class285();
			@class.debug_0 = this;
			@class.byteViewer_0 = new ByteViewer();
			@class.byteViewer_0.SetBytes(this.Class106_0.list_9[0]);
			@class.byteViewer_0.Dock = DockStyle.Top;
			@class.byteViewer_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			@class.byteViewer_0.Height = 100;
			@class.byteViewer_0.MouseClick += @class.method_0;
			this.panSniff.Controls.Add(@class.byteViewer_0);
			@class.byteViewer_0.BringToFront();
			this.Class106_0.list_9.RemoveAt(0);
		}
		this.panSniff.ResumeLayout();
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x000104E6 File Offset: 0x0000E6E6
	private void method_0(object sender, EventArgs e)
	{
		this.Class106_0.list_9.Clear();
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x000104F8 File Offset: 0x0000E6F8
	private void btnClearSniff_Click(object sender, EventArgs e)
	{
		this.panSniff.Controls.Clear();
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_1(object sender, EventArgs e)
	{
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_3(object sender, EventArgs e)
	{
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x000104E6 File Offset: 0x0000E6E6
	private void btnFlush_Click(object sender, EventArgs e)
	{
		this.Class106_0.list_9.Clear();
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x000C40B8 File Offset: 0x000C22B8
	private void pickToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_293(@class.Int32_4);
		}
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x000C4110 File Offset: 0x000C2310
	private void selectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_327(@class.Int32_4);
		}
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x0000500B File Offset: 0x0000320B
	private void useSkill3ToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0000500B File Offset: 0x0000320B
	private void uskill3ToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x000C417C File Offset: 0x000C237C
	private void method_4(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_378(4831, @class.Int32_4, -1f, -1f);
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x000C41D8 File Offset: 0x000C23D8
	private void method_5(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_378(4830, @class.Int32_4, -1f, -1f);
		}
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x000C4234 File Offset: 0x000C2434
	private void freeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.lvMemInfo.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			int num = Convert.ToInt32(listViewItem.SubItems[1].Text, 16);
			Convert.ToInt32(listViewItem.SubItems[2].Text, 16);
			if (Class515.VirtualFreeEx(this.Class106_0.Class515_0.IntPtr_0, (long)num, 4096, 32768))
			{
				listViewItem.SubItems[5].Text = "True";
			}
			else
			{
				listViewItem.SubItems[5].Text = "False";
			}
		}
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x000C4318 File Offset: 0x000C2518
	private void attackToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_378(3, @class.Int32_4, -1f, -1f);
		}
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x000C4390 File Offset: 0x000C2590
	private void allToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class503 @class in this.Class106_0.IEnumerable_7)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.SubItems.Add(@class.Int32_1.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x000C4448 File Offset: 0x000C2648
	private void doActionToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class503)
		{
			Class503 @class = this.lvObject.SelectedItems[0].Tag as Class503;
			this.Class106_0.method_394(@class);
		}
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x000C44B0 File Offset: 0x000C26B0
	private void petSkillToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class503 @class in this.Class106_0.IEnumerable_7.Where<Class503>(new Func<Class503, bool>(Debug.Class284.f_A0123B07.method_0)))
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.SubItems.Add(@class.Int32_1.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x000C458C File Offset: 0x000C278C
	private void skillToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class503 @class in this.Class106_0.IEnumerable_7.Where<Class503>(new Func<Class503, bool>(Debug.Class284.f_A0123B07.method_1)))
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_0.ToString());
			listViewItem.SubItems.Add(@class.String_0);
			listViewItem.SubItems.Add(@class.Int32_1.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x000C4668 File Offset: 0x000C2868
	private void pushToThienCoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class516)
		{
			Class516 @class = this.lvObject.SelectedItems[0].Tag as Class516;
			this.Class106_0.method_352(@class.Int32_11);
		}
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000C46D4 File Offset: 0x000C28D4
	private void thuongHoiToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_8)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_6(object sender, EventArgs e)
	{
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0001050A File Offset: 0x0000E70A
	private void method_7(object sender, EventArgs e)
	{
		base.Parent.Dispose();
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x00010517 File Offset: 0x0000E717
	private void method_8(object sender, EventArgs e)
	{
		this.Class106_0.method_174();
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x0000500B File Offset: 0x0000320B
	private void txtDoString_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00010524 File Offset: 0x0000E724
	private void Fly_Click(object sender, EventArgs e)
	{
		this.Class106_0.Class527_0.method_7(100f, 100f);
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000C4774 File Offset: 0x000C2974
	private void openStallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_338(@class.Int32_4);
		}
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x000C47E0 File Offset: 0x000C29E0
	private void talkToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_441(@class.Int32_4);
		}
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x000C484C File Offset: 0x000C2A4C
	private void pickObjectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0 && this.lvObject.SelectedItems[0].Tag is Class504)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_118(@class.Int64_3);
		}
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x000C3788 File Offset: 0x000C1988
	private void chanNguyenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_7)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0000500B File Offset: 0x0000320B
	private void button4_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00010540 File Offset: 0x0000E740
	private void button1_Click(object sender, EventArgs e)
	{
		this.txtConvert.Text = Class515.smethod_8(Encoding.GetEncoding(1252).GetBytes(this.txtConvert.Text));
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x000C48B8 File Offset: 0x000C2AB8
	private void button6_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			this.button6.Text = openFileDialog.FileName;
		}
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x000C48E8 File Offset: 0x000C2AE8
	private void button7_Click(object sender, EventArgs e)
	{
		this.textBoxEx1.Text = string.Join(",", File.ReadAllBytes(this.button6.Text).smethod_10(this.textBoxEx1.Text).Select<int, string>(new Func<int, string>(Debug.Class284.f_A0123B07.method_2))
			.ToArray<string>());
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x000C4954 File Offset: 0x000C2B54
	private void daoCuToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_1)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.SubItems.Add(@class.Int32_8.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x000C4A10 File Offset: 0x000C2C10
	private void nguyenLieuToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_2)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.SubItems.Add(@class.Int32_8.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x000C4ACC File Offset: 0x000C2CCC
	private void button8_Click(object sender, EventArgs e)
	{
		string text = this.tPacket.Text;
		this.Class106_0.method_167(text);
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x000C4AF4 File Offset: 0x000C2CF4
	private void allExToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class516 @class in this.Class106_0.Class214_0.IEnumerable_4)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_11.ToString());
			listViewItem.SubItems.Add(@class.String_1);
			listViewItem.SubItems.Add(@class.Int32_8.ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x0001056C File Offset: 0x0000E76C
	private void soiDoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_178(((Class516)this.lvObject.SelectedItems[0].Tag).Int32_11);
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00010599 File Offset: 0x0000E799
	private void giamDinhToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Class516)this.lvObject.SelectedItems[0].Tag).method_12();
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x000105BB File Offset: 0x0000E7BB
	private void dieuTucToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_323();
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x000105C8 File Offset: 0x0000E7C8
	private void tHAO1ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Class106_0.method_261(1);
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x000C4BB0 File Offset: 0x000C2DB0
	private void playerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvObject.Items.Clear();
		foreach (Class504 @class in this.Class106_0.Class506_0.IEnumerable_4)
		{
			ListViewItem listViewItem = new ListViewItem(@class.Int32_4.ToString());
			listViewItem.SubItems.Add(@class.String_9);
			listViewItem.SubItems.Add(@class.method_1(this.Class106_0).ToString());
			listViewItem.Tag = @class;
			this.lvObject.Items.Add(listViewItem);
		}
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x000C4C74 File Offset: 0x000C2E74
	private void useSkillToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.lvObject.SelectedItems.Count > 0)
		{
			Class504 @class = this.lvObject.SelectedItems[0].Tag as Class504;
			this.Class106_0.method_378(3651, @class.Int32_4, -1f, -1f);
		}
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x000105D6 File Offset: 0x0000E7D6
	private void button9_Click(object sender, EventArgs e)
	{
		this.gclass7_0.method_88("dcmm");
	}

	// Token: 0x04000EE1 RID: 3809
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x04000EE2 RID: 3810
	private GClass7 gclass7_0 = new GClass7("wss://microauto.org:8443", Array.Empty<string>());

	// Token: 0x0200019E RID: 414
	[CompilerGenerated]
	[Serializable]
	private sealed class Class284
	{
		// Token: 0x060017BC RID: 6076 RVA: 0x00010613 File Offset: 0x0000E813
		internal bool method_0(Class503 class503_0)
		{
			return class503_0.String_1.Contains("PetSkill");
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00010625 File Offset: 0x0000E825
		internal bool method_1(Class503 class503_0)
		{
			return class503_0.String_1.Contains("Skill");
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00010637 File Offset: 0x0000E837
		internal string method_2(int int_0)
		{
			return int_0.ToString("X8");
		}

		// Token: 0x04000F54 RID: 3924
		public static readonly Debug.Class284 f_A0123B07 = new Debug.Class284();

		// Token: 0x04000F55 RID: 3925
		public static Func<Class503, bool> f_D8CE5679;

		// Token: 0x04000F56 RID: 3926
		public static Func<Class503, bool> f_6BF985E0;

		// Token: 0x04000F57 RID: 3927
		public static Func<int, string> f_098947F3;
	}

	// Token: 0x0200019F RID: 415
	[CompilerGenerated]
	private sealed class Class285
	{
		// Token: 0x060017C0 RID: 6080 RVA: 0x00010645 File Offset: 0x0000E845
		internal void method_0(object sender, MouseEventArgs e)
		{
			this.debug_0.txtHex.Text = Class587.smethod_3(this.byteViewer_0.GetBytes());
		}

		// Token: 0x04000F58 RID: 3928
		public ByteViewer byteViewer_0;

		// Token: 0x04000F59 RID: 3929
		public Debug debug_0;
	}
}
