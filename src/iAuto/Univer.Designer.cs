// Token: 0x02000179 RID: 377
public partial class Univer : global::System.Windows.Forms.UserControl
{
	// Token: 0x06001656 RID: 5718 RVA: 0x0000FB6B File Offset: 0x0000DD6B
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x000B1A1C File Offset: 0x000AFC1C
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Univer));
		global::System.Windows.Forms.TreeNode treeNode = new global::System.Windows.Forms.TreeNode("Hủy");
		global::System.Windows.Forms.TreeNode treeNode2 = new global::System.Windows.Forms.TreeNode("Bán");
		global::System.Windows.Forms.TreeNode treeNode3 = new global::System.Windows.Forms.TreeNode("Dùng");
		global::System.Windows.Forms.TreeNode treeNode4 = new global::System.Windows.Forms.TreeNode("Mua");
		global::System.Windows.Forms.TreeNode treeNode5 = new global::System.Windows.Forms.TreeNode("Cất");
		global::System.Windows.Forms.TreeNode treeNode6 = new global::System.Windows.Forms.TreeNode("Cất Thiên Cơ");
		global::System.Windows.Forms.TreeNode treeNode7 = new global::System.Windows.Forms.TreeNode("Gom");
		global::System.Windows.Forms.TreeNode treeNode8 = new global::System.Windows.Forms.TreeNode("Gom KNB");
		global::System.Windows.Forms.TreeNode treeNode9 = new global::System.Windows.Forms.TreeNode("Lấy");
		global::System.Windows.Forms.TreeNode treeNode10 = new global::System.Windows.Forms.TreeNode("Lấy Thiên Cơ");
		global::System.Windows.Forms.TreeNode treeNode11 = new global::System.Windows.Forms.TreeNode("Chỉ Nhặt");
		global::System.Windows.Forms.TreeNode treeNode12 = new global::System.Windows.Forms.TreeNode("Treo Shop");
		global::System.Windows.Forms.TreeNode treeNode13 = new global::System.Windows.Forms.TreeNode("Bạn Bè");
		global::System.Windows.Forms.TreeNode treeNode14 = new global::System.Windows.Forms.TreeNode("Bỏ Qua");
		global::System.Windows.Forms.TreeNode treeNode15 = new global::System.Windows.Forms.TreeNode("Tuyên Chiến");
		global::System.Windows.Forms.TreeNode treeNode16 = new global::System.Windows.Forms.TreeNode("Chỉ Đánh");
		global::System.Windows.Forms.TreeNode treeNode17 = new global::System.Windows.Forms.TreeNode("Ưu Tiên");
		global::System.Windows.Forms.TreeNode treeNode18 = new global::System.Windows.Forms.TreeNode("Lịch");
		global::System.Windows.Forms.TreeNode treeNode19 = new global::System.Windows.Forms.TreeNode("Tổ Đội");
		global::System.Windows.Forms.TreeNode treeNode20 = new global::System.Windows.Forms.TreeNode("Di Chuyển");
		global::System.Windows.Forms.TreeNode treeNode21 = new global::System.Windows.Forms.TreeNode("Point");
		global::System.Windows.Forms.TreeNode treeNode22 = new global::System.Windows.Forms.TreeNode("Skill");
		global::System.Windows.Forms.TreeNode treeNode23 = new global::System.Windows.Forms.TreeNode("Chia");
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.lvName = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.panelEx1 = new global::GClass3();
		this.txtAiDangCam = new global::System.Windows.Forms.TextBox();
		this.checkLocked = new global::System.Windows.Forms.CheckBox();
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.panelEx2 = new global::GClass3();
		this.txtTo = new global::System.Windows.Forms.TextBox();
		this.txtFrom = new global::System.Windows.Forms.TextBox();
		this.textName = new global::Control3();
		this.lbSearch = new global::System.Windows.Forms.ListBox();
		this.myPanel1 = new global::GClass3();
		this.treeView1 = new global::System.Windows.Forms.TreeView();
		this.lbPlayer = new global::System.Windows.Forms.ListBox();
		this.cboPlayer = new global::System.Windows.Forms.ComboBox();
		this.btnSave = new global::System.Windows.Forms.Button();
		this.txtSearch = new global::Class533();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.panelEx1.SuspendLayout();
		this.panelEx2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.textName).BeginInit();
		this.myPanel1.SuspendLayout();
		base.SuspendLayout();
		this.splitContainer1.BackColor = global::System.Drawing.Color.White;
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 20);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.splitContainer1.Panel1.Controls.Add(this.lvName);
		this.splitContainer1.Panel1.Controls.Add(this.panelEx1);
		this.splitContainer1.Panel2.BackColor = global::System.Drawing.Color.White;
		this.splitContainer1.Panel2.Controls.Add(this.textName);
		this.splitContainer1.Panel2.Controls.Add(this.lbSearch);
		this.splitContainer1.Size = new global::System.Drawing.Size(330, 492);
		this.splitContainer1.SplitterDistance = 243;
		this.splitContainer1.SplitterWidth = 1;
		this.splitContainer1.TabIndex = 2;
		this.lvName.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("lvName.AllItems");
		this.lvName.AllowColumnReorder = true;
		this.lvName.AllowDrop = true;
		this.lvName.AllowReorder = true;
		this.lvName.AllowSort = true;
		this.lvName.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0 });
		this.lvName.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvName.DoubleClickActivation = false;
		this.lvName.FullRowSelect = true;
		this.lvName.GridLines = true;
		this.lvName.HideSelection = false;
		this.lvName.LineColor = global::System.Drawing.Color.Red;
		this.lvName.Location = new global::System.Drawing.Point(0, 0);
		this.lvName.Name = "lvName";
		this.lvName.Size = new global::System.Drawing.Size(260, 243);
		this.lvName.TabIndex = 17;
		this.lvName.UseCompatibleStateImageBehavior = false;
		this.lvName.View = global::System.Windows.Forms.View.Details;
		this.lvName.SelectedIndexChanged += new global::System.EventHandler(this.lvName_SelectedIndexChanged);
		this.lvName.DoubleClick += new global::System.EventHandler(this.lvName_DoubleClick);
		this.columnHeader_0.Text = "Name";
		this.columnHeader_0.Width = 190;
		this.panelEx1.Controls.Add(this.txtAiDangCam);
		this.panelEx1.Controls.Add(this.checkLocked);
		this.panelEx1.Controls.Add(this.textBox1);
		this.panelEx1.Controls.Add(this.panelEx2);
		this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.panelEx1.Location = new global::System.Drawing.Point(260, 0);
		this.panelEx1.Name = "panelEx1";
		this.panelEx1.Size = new global::System.Drawing.Size(70, 243);
		this.panelEx1.TabIndex = 23;
		this.txtAiDangCam.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtAiDangCam.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtAiDangCam.Location = new global::System.Drawing.Point(0, 0);
		this.txtAiDangCam.Multiline = true;
		this.txtAiDangCam.Name = "txtAiDangCam";
		this.txtAiDangCam.Size = new global::System.Drawing.Size(70, 186);
		this.txtAiDangCam.TabIndex = 21;
		this.checkLocked.AutoSize = true;
		this.checkLocked.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.checkLocked.Location = new global::System.Drawing.Point(0, 186);
		this.checkLocked.Margin = new global::System.Windows.Forms.Padding(0);
		this.checkLocked.Name = "checkLocked";
		this.checkLocked.Size = new global::System.Drawing.Size(70, 17);
		this.checkLocked.TabIndex = 9;
		this.checkLocked.Text = "Locked";
		this.checkLocked.UseVisualStyleBackColor = true;
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.textBox1.Location = new global::System.Drawing.Point(0, 203);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new global::System.Drawing.Size(70, 20);
		this.textBox1.TabIndex = 20;
		this.textBox1.Text = "20";
		this.panelEx2.Controls.Add(this.txtTo);
		this.panelEx2.Controls.Add(this.txtFrom);
		this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panelEx2.Location = new global::System.Drawing.Point(0, 223);
		this.panelEx2.Name = "panelEx2";
		this.panelEx2.Size = new global::System.Drawing.Size(70, 20);
		this.panelEx2.TabIndex = 0;
		this.txtTo.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTo.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.txtTo.Location = new global::System.Drawing.Point(36, 0);
		this.txtTo.Name = "txtTo";
		this.txtTo.Size = new global::System.Drawing.Size(34, 20);
		this.txtTo.TabIndex = 16;
		this.txtTo.Text = "23:59";
		this.txtFrom.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtFrom.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.txtFrom.Location = new global::System.Drawing.Point(0, 0);
		this.txtFrom.Name = "txtFrom";
		this.txtFrom.Size = new global::System.Drawing.Size(34, 20);
		this.txtFrom.TabIndex = 18;
		this.txtFrom.Text = "00:00";
		this.textName.Char_0 = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
		this.textName.String_6 = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
		this.textName.Size_0 = new global::System.Drawing.Size(25, 13);
		this.textName.Brush_0 = null;
		this.textName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.textName.Int32_2 = 13;
		this.textName.Int32_4 = 7;
		this.textName.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.textName.Int32_20 = 8;
		this.textName.Color_7 = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
		this.textName.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.textName.Font = new global::System.Drawing.Font("Courier New", 8.799999f);
		this.textName.Boolean_15 = false;
		this.textName.Location = new global::System.Drawing.Point(0, 0);
		this.textName.Name = "textName";
		this.textName.Padding_0 = new global::System.Windows.Forms.Padding(0);
		this.textName.Color_11 = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
		this.textName.Class342_0 = null;
		this.textName.Size = new global::System.Drawing.Size(330, 192);
		this.textName.TabIndex = 0;
		this.textName.Int32_21 = 100;
		this.textName.Event_2 += new global::System.EventHandler<global::EventArgs5>(this.method_7);
		this.textName.Event_5 += new global::System.EventHandler<global::EventArgs6>(this.method_8);
		this.textName.Load += new global::System.EventHandler(this.textName_Load);
		this.lbSearch.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.lbSearch.FormattingEnabled = true;
		this.lbSearch.Location = new global::System.Drawing.Point(0, 192);
		this.lbSearch.Name = "lbSearch";
		this.lbSearch.Size = new global::System.Drawing.Size(330, 56);
		this.lbSearch.TabIndex = 23;
		this.lbSearch.Visible = false;
		this.lbSearch.SelectedIndexChanged += new global::System.EventHandler(this.lbSearch_SelectedIndexChanged);
		this.myPanel1.Controls.Add(this.treeView1);
		this.myPanel1.Controls.Add(this.lbPlayer);
		this.myPanel1.Controls.Add(this.cboPlayer);
		this.myPanel1.Controls.Add(this.btnSave);
		this.myPanel1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.myPanel1.Location = new global::System.Drawing.Point(330, 20);
		this.myPanel1.Name = "myPanel1";
		this.myPanel1.Size = new global::System.Drawing.Size(100, 492);
		this.myPanel1.TabIndex = 16;
		this.treeView1.CheckBoxes = true;
		this.treeView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.treeView1.FullRowSelect = true;
		this.treeView1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
		this.treeView1.Indent = 18;
		this.treeView1.Location = new global::System.Drawing.Point(0, 0);
		this.treeView1.Name = "treeView1";
		treeNode.Name = "Node0";
		treeNode.Tag = "Drop";
		treeNode.Text = "Hủy";
		treeNode2.Name = "Node1";
		treeNode2.Tag = "Sell";
		treeNode2.Text = "Bán";
		treeNode3.Name = "Node2";
		treeNode3.Tag = "Use";
		treeNode3.Text = "Dùng";
		treeNode4.Name = "Node0";
		treeNode4.Tag = "Buy";
		treeNode4.Text = "Mua";
		treeNode5.Name = "Node1";
		treeNode5.Tag = "Bank";
		treeNode5.Text = "Cất";
		treeNode6.Name = "Node2";
		treeNode6.Tag = "TempBank";
		treeNode6.Text = "Cất Thiên Cơ";
		treeNode7.Name = "Node3";
		treeNode7.Tag = "Collect";
		treeNode7.Text = "Gom";
		treeNode8.Name = "Node4";
		treeNode8.Tag = "CollectKNB";
		treeNode8.Text = "Gom KNB";
		treeNode9.Name = "Node5";
		treeNode9.Tag = "Take";
		treeNode9.Text = "Lấy";
		treeNode10.Name = "Node6";
		treeNode10.Tag = "TakeTemp";
		treeNode10.Text = "Lấy Thiên Cơ";
		treeNode11.Name = "Node0";
		treeNode11.Tag = "PickList";
		treeNode11.Text = "Chỉ Nhặt";
		treeNode12.Name = "Node0";
		treeNode12.Tag = "Sale";
		treeNode12.Text = "Treo Shop";
		treeNode13.Name = "Node7";
		treeNode13.Tag = "Friend";
		treeNode13.Text = "Bạn Bè";
		treeNode14.Name = "Node8";
		treeNode14.Tag = "Black";
		treeNode14.Text = "Bỏ Qua";
		treeNode15.Name = "Node1";
		treeNode15.Tag = "Fight";
		treeNode15.Text = "Tuyên Chiến";
		treeNode16.Name = "NodeChiDanh";
		treeNode16.Tag = "AttackList";
		treeNode16.Text = "Chỉ Đánh";
		treeNode17.Name = "nodeuutien";
		treeNode17.Tag = "UuTien";
		treeNode17.Text = "Ưu Tiên";
		treeNode18.Name = "Node9";
		treeNode18.Tag = "Calender";
		treeNode18.Text = "Lịch";
		treeNode19.Name = "Node0";
		treeNode19.Tag = "Team";
		treeNode19.Text = "Tổ Đội";
		treeNode20.Name = "Node0";
		treeNode20.Tag = "DiChuyen";
		treeNode20.Text = "Di Chuyển";
		treeNode21.Name = "Node0";
		treeNode21.Tag = "Point";
		treeNode21.Text = "Point";
		treeNode22.Name = "Node0";
		treeNode22.Tag = "Skill";
		treeNode22.Text = "Skill";
		treeNode23.Name = "Node0";
		treeNode23.Tag = "Chia";
		treeNode23.Text = "Chia";
		this.treeView1.Nodes.AddRange(new global::System.Windows.Forms.TreeNode[]
		{
			treeNode, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10,
			treeNode11, treeNode12, treeNode13, treeNode14, treeNode15, treeNode16, treeNode17, treeNode18, treeNode19, treeNode20,
			treeNode21, treeNode22, treeNode23
		});
		this.treeView1.PathSeparator = "";
		this.treeView1.ShowLines = false;
		this.treeView1.ShowPlusMinus = false;
		this.treeView1.Size = new global::System.Drawing.Size(100, 393);
		this.treeView1.TabIndex = 1;
		this.treeView1.AfterCheck += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
		this.treeView1.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
		this.lbPlayer.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.lbPlayer.FormattingEnabled = true;
		this.lbPlayer.Location = new global::System.Drawing.Point(0, 393);
		this.lbPlayer.Name = "lbPlayer";
		this.lbPlayer.Size = new global::System.Drawing.Size(100, 56);
		this.lbPlayer.TabIndex = 21;
		this.lbPlayer.Visible = false;
		this.lbPlayer.SelectedIndexChanged += new global::System.EventHandler(this.lbPlayer_SelectedIndexChanged);
		this.cboPlayer.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.cboPlayer.FormattingEnabled = true;
		this.cboPlayer.Location = new global::System.Drawing.Point(0, 449);
		this.cboPlayer.Name = "cboPlayer";
		this.cboPlayer.Size = new global::System.Drawing.Size(100, 21);
		this.cboPlayer.TabIndex = 1;
		this.cboPlayer.DropDown += new global::System.EventHandler(this.cboPlayer_DropDown);
		this.cboPlayer.SelectedIndexChanged += new global::System.EventHandler(this.cboPlayer_SelectedIndexChanged);
		this.cboPlayer.TextChanged += new global::System.EventHandler(this.cboPlayer_TextChanged);
		this.btnSave.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnSave.Location = new global::System.Drawing.Point(0, 470);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new global::System.Drawing.Size(100, 22);
		this.btnSave.TabIndex = 8;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
		this.txtSearch.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtSearch.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.txtSearch.Location = new global::System.Drawing.Point(0, 0);
		this.txtSearch.Name = "txtSearch";
		this.txtSearch.Size = new global::System.Drawing.Size(430, 20);
		this.txtSearch.TabIndex = 15;
		this.txtSearch.String_0 = "Search...";
		this.txtSearch.Color_0 = global::System.Drawing.Color.Gray;
		this.txtSearch.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtSearch.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtSearch.TextChanged += new global::System.EventHandler(this.txtSearch_TextChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.Controls.Add(this.splitContainer1);
		base.Controls.Add(this.myPanel1);
		base.Controls.Add(this.txtSearch);
		base.Name = "Univer";
		base.Size = new global::System.Drawing.Size(430, 512);
		base.Load += new global::System.EventHandler(this.Univer_Load);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.panelEx1.ResumeLayout(false);
		this.panelEx1.PerformLayout();
		this.panelEx2.ResumeLayout(false);
		this.panelEx2.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.textName).EndInit();
		this.myPanel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000D78 RID: 3448
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000D79 RID: 3449
	public global::System.Windows.Forms.TreeView treeView1;

	// Token: 0x04000D7A RID: 3450
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04000D7B RID: 3451
	private global::_i.ListViewEx lvName;

	// Token: 0x04000D7C RID: 3452
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000D7D RID: 3453
	public global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x04000D7E RID: 3454
	public global::System.Windows.Forms.TextBox txtFrom;

	// Token: 0x04000D7F RID: 3455
	public global::System.Windows.Forms.TextBox txtTo;

	// Token: 0x04000D80 RID: 3456
	private global::System.Windows.Forms.CheckBox checkLocked;

	// Token: 0x04000D81 RID: 3457
	private global::Control3 textName;

	// Token: 0x04000D82 RID: 3458
	private global::System.Windows.Forms.ComboBox cboPlayer;

	// Token: 0x04000D83 RID: 3459
	private global::System.Windows.Forms.Button btnSave;

	// Token: 0x04000D84 RID: 3460
	private global::Class533 txtSearch;

	// Token: 0x04000D85 RID: 3461
	private global::GClass3 myPanel1;

	// Token: 0x04000D86 RID: 3462
	private global::System.Windows.Forms.TextBox txtAiDangCam;

	// Token: 0x04000D87 RID: 3463
	private global::System.Windows.Forms.ListBox lbSearch;

	// Token: 0x04000D88 RID: 3464
	private global::System.Windows.Forms.ListBox lbPlayer;

	// Token: 0x04000D89 RID: 3465
	private global::GClass3 panelEx1;

	// Token: 0x04000D8A RID: 3466
	private global::GClass3 panelEx2;
}
