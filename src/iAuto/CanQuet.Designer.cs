// Token: 0x02000199 RID: 409
internal partial class CanQuet : global::System.Windows.Forms.UserControl
{
	// Token: 0x0600175A RID: 5978 RVA: 0x000102C7 File Offset: 0x0000E4C7
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x000C1D08 File Offset: 0x000BFF08
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CanQuet));
		this.panel3 = new global::System.Windows.Forms.Panel();
		this.comboBox1 = new global::System.Windows.Forms.ComboBox();
		this.button4 = new global::System.Windows.Forms.Button();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
		this.lvTask = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.lvGame = new global::_i.ListViewEx();
		this.lbCount = new global::System.Windows.Forms.Label();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.panel3.SuspendLayout();
		this.panel1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
		this.splitContainer2.Panel1.SuspendLayout();
		this.splitContainer2.Panel2.SuspendLayout();
		this.splitContainer2.SuspendLayout();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.panel3.Controls.Add(this.comboBox1);
		this.panel3.Controls.Add(this.button4);
		this.panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel3.Location = new global::System.Drawing.Point(0, 0);
		this.panel3.Name = "panel3";
		this.panel3.Size = new global::System.Drawing.Size(440, 22);
		this.panel3.TabIndex = 12;
		this.comboBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[]
		{
			"Hàng Ngày", "Phiêu Miễu Phong", "Phiêu Miễu Phong Huyết Chiến", "Yến Tử Ô", "Thiếu Thất Sơn", "Vương Lăng", "Tam Thần Huyễn Cảnh", "Lan Hoàn Phúc Địa", "Q Lâu Lan", "Q Tô Châu",
			"Sát Tinh", "Tứ Tuyệt Trang", "Phân Giải Trang Bị Pet", "Bán Đồ - Cất Đồ - Trị Liệu", "Nhận x2", "Đông x2", "Nhận Chiến Công + Kiếm Chỉ", "Bảo Vệ Bang"
		});
		this.comboBox1.Location = new global::System.Drawing.Point(125, 0);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new global::System.Drawing.Size(315, 21);
		this.comboBox1.TabIndex = 0;
		this.button4.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.button4.Location = new global::System.Drawing.Point(0, 0);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(125, 22);
		this.button4.TabIndex = 7;
		this.button4.Text = "Kiểm Tra";
		this.button4.UseVisualStyleBackColor = true;
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.button3);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new global::System.Drawing.Point(0, 22);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(440, 21);
		this.panel1.TabIndex = 13;
		this.button1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.button1.Location = new global::System.Drawing.Point(125, 0);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(315, 21);
		this.button1.TabIndex = 2;
		this.button1.Text = "Thêm";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button3.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.button3.Location = new global::System.Drawing.Point(0, 0);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(125, 21);
		this.button3.TabIndex = 6;
		this.button3.Text = "Thêm Toàn Bộ";
		this.button3.UseVisualStyleBackColor = true;
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.IsSplitterFixed = true;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 43);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
		this.splitContainer1.Panel2.Controls.Add(this.panel2);
		this.splitContainer1.Panel2MinSize = 20;
		this.splitContainer1.Size = new global::System.Drawing.Size(440, 313);
		this.splitContainer1.SplitterDistance = 284;
		this.splitContainer1.SplitterWidth = 1;
		this.splitContainer1.TabIndex = 14;
		this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer2.IsSplitterFixed = true;
		this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer2.Name = "splitContainer2";
		this.splitContainer2.Panel1.Controls.Add(this.lvTask);
		this.splitContainer2.Panel2.Controls.Add(this.lvGame);
		this.splitContainer2.Panel2.Controls.Add(this.lbCount);
		this.splitContainer2.Panel2MinSize = 70;
		this.splitContainer2.Size = new global::System.Drawing.Size(440, 284);
		this.splitContainer2.SplitterDistance = 342;
		this.splitContainer2.SplitterWidth = 1;
		this.splitContainer2.TabIndex = 2;
		this.lvTask.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("lvTask.AllItems");
		this.lvTask.AllowColumnReorder = true;
		this.lvTask.AllowDrop = true;
		this.lvTask.AllowReorder = true;
		this.lvTask.AllowSort = false;
		this.lvTask.CheckBoxes = true;
		this.lvTask.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.lvTask.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvTask.DoubleClickActivation = false;
		this.lvTask.FullRowSelect = true;
		this.lvTask.GridLines = true;
		this.lvTask.HideSelection = false;
		this.lvTask.LineColor = global::System.Drawing.Color.Red;
		this.lvTask.Location = new global::System.Drawing.Point(0, 0);
		this.lvTask.Name = "lvTask";
		this.lvTask.Size = new global::System.Drawing.Size(342, 284);
		this.lvTask.TabIndex = 0;
		this.lvTask.UseCompatibleStateImageBehavior = false;
		this.lvTask.View = global::System.Windows.Forms.View.Details;
		this.lvTask.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.lvTask_ItemChecked);
		this.lvTask.SelectedIndexChanged += new global::System.EventHandler(this.lvTask_SelectedIndexChanged);
		this.lvTask.DoubleClick += new global::System.EventHandler(this.lvTask_DoubleClick);
		this.columnHeader_0.Text = "Name";
		this.columnHeader_0.Width = 115;
		this.columnHeader_1.Text = "Status";
		this.columnHeader_1.Width = 80;
		this.columnHeader_2.Text = "Time";
		this.lvGame.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("lvGame.AllItems");
		this.lvGame.AllowColumnReorder = true;
		this.lvGame.AllowDrop = true;
		this.lvGame.AllowReorder = true;
		this.lvGame.AllowSort = false;
		this.lvGame.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvGame.DoubleClickActivation = false;
		this.lvGame.FullRowSelect = true;
		this.lvGame.GridLines = true;
		this.lvGame.HideSelection = false;
		this.lvGame.LineColor = global::System.Drawing.Color.Red;
		this.lvGame.Location = new global::System.Drawing.Point(0, 16);
		this.lvGame.Name = "lvGame";
		this.lvGame.Size = new global::System.Drawing.Size(97, 268);
		this.lvGame.TabIndex = 5;
		this.lvGame.UseCompatibleStateImageBehavior = false;
		this.lvGame.View = global::System.Windows.Forms.View.SmallIcon;
		this.lbCount.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.lbCount.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lbCount.Location = new global::System.Drawing.Point(0, 0);
		this.lbCount.Name = "lbCount";
		this.lbCount.Size = new global::System.Drawing.Size(97, 16);
		this.lbCount.TabIndex = 4;
		this.lbCount.Text = "6";
		this.lbCount.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.panel2.Controls.Add(this.button2);
		this.panel2.Controls.Add(this.button5);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new global::System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(440, 28);
		this.panel2.TabIndex = 11;
		this.button2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.button2.Location = new global::System.Drawing.Point(125, 0);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(315, 28);
		this.button2.TabIndex = 5;
		this.button2.Text = "Start";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button5.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.button5.Location = new global::System.Drawing.Point(0, 0);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(125, 28);
		this.button5.TabIndex = 0;
		this.button5.Text = "Close";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.splitContainer1);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.panel3);
		base.Name = "CanQuet";
		base.Size = new global::System.Drawing.Size(440, 356);
		base.Load += new global::System.EventHandler(this.CanQuet_Load);
		this.panel3.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.splitContainer2.Panel1.ResumeLayout(false);
		this.splitContainer2.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
		this.splitContainer2.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04000EBA RID: 3770
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000EBB RID: 3771
	private global::System.Windows.Forms.Panel panel3;

	// Token: 0x04000EBC RID: 3772
	private global::System.Windows.Forms.ComboBox comboBox1;

	// Token: 0x04000EBD RID: 3773
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000EBE RID: 3774
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000EBF RID: 3775
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000EC0 RID: 3776
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000EC1 RID: 3777
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04000EC2 RID: 3778
	private global::System.Windows.Forms.SplitContainer splitContainer2;

	// Token: 0x04000EC3 RID: 3779
	private global::System.Windows.Forms.Label lbCount;

	// Token: 0x04000EC4 RID: 3780
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04000EC5 RID: 3781
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000EC6 RID: 3782
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04000EC7 RID: 3783
	private global::_i.ListViewEx lvTask;

	// Token: 0x04000EC8 RID: 3784
	private global::_i.ListViewEx lvGame;

	// Token: 0x04000EC9 RID: 3785
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000ECA RID: 3786
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x04000ECB RID: 3787
	private global::System.Windows.Forms.ColumnHeader columnHeader_2;

	// Token: 0x04000ECC RID: 3788
	private global::System.Windows.Forms.Timer timer_0;
}
