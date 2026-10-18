// Token: 0x02000348 RID: 840
internal partial class ToDoi : global::System.Windows.Forms.UserControl
{
	// Token: 0x06002C04 RID: 11268 RVA: 0x0001D4C2 File Offset: 0x0001B6C2
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x0013E5C4 File Offset: 0x0013C7C4
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ToDoi));
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.deleteDoubleClickToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.clearToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.refreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
		this.lvTeamName = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.lvTeamMem = new global::_i.ListViewEx();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.contextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Panel1.Controls.Add(this.lvTeamName);
		this.splitContainer1.Panel2.Controls.Add(this.lvTeamMem);
		this.splitContainer1.Size = new global::System.Drawing.Size(620, 405);
		this.splitContainer1.SplitterDistance = 302;
		this.splitContainer1.TabIndex = 1;
		this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.refreshToolStripMenuItem, this.deleteDoubleClickToolStripMenuItem, this.clearToolStripMenuItem });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new global::System.Drawing.Size(114, 70);
		this.deleteDoubleClickToolStripMenuItem.Name = "deleteDoubleClickToolStripMenuItem";
		this.deleteDoubleClickToolStripMenuItem.Size = new global::System.Drawing.Size(113, 22);
		this.deleteDoubleClickToolStripMenuItem.Text = "Delete";
		this.deleteDoubleClickToolStripMenuItem.Click += new global::System.EventHandler(this.deleteDoubleClickToolStripMenuItem_Click);
		this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
		this.clearToolStripMenuItem.Size = new global::System.Drawing.Size(113, 22);
		this.clearToolStripMenuItem.Text = "Clear";
		this.clearToolStripMenuItem.Click += new global::System.EventHandler(this.clearToolStripMenuItem_Click);
		this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
		this.refreshToolStripMenuItem.Size = new global::System.Drawing.Size(113, 22);
		this.refreshToolStripMenuItem.Text = "Refresh";
		this.columnHeader_2.Text = "Member";
		this.columnHeader_2.Width = 160;
		this.columnHeader_3.Text = "Member";
		this.columnHeader_3.Width = 160;
		this.lvTeamName.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("lvTeamName.AllItems");
		this.lvTeamName.AllowColumnReorder = true;
		this.lvTeamName.AllowDrop = true;
		this.lvTeamName.AllowReorder = true;
		this.lvTeamName.AllowSort = false;
		this.lvTeamName.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0 });
		this.lvTeamName.ContextMenuStrip = this.contextMenuStrip1;
		this.lvTeamName.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvTeamName.DoubleClickActivation = false;
		this.lvTeamName.FullRowSelect = true;
		this.lvTeamName.GridLines = true;
		this.lvTeamName.HideSelection = false;
		this.lvTeamName.LineColor = global::System.Drawing.Color.Red;
		this.lvTeamName.Location = new global::System.Drawing.Point(0, 0);
		this.lvTeamName.Name = "lvTeamName";
		this.lvTeamName.Size = new global::System.Drawing.Size(302, 405);
		this.lvTeamName.TabIndex = 14;
		this.lvTeamName.UseCompatibleStateImageBehavior = false;
		this.lvTeamName.View = global::System.Windows.Forms.View.Details;
		this.lvTeamName.SelectedIndexChanged += new global::System.EventHandler(this.lvTeamName_SelectedIndexChanged);
		this.lvTeamName.DoubleClick += new global::System.EventHandler(this.lvTeamMem_DoubleClick);
		this.columnHeader_0.Text = "Tên Đội";
		this.columnHeader_0.Width = 120;
		this.lvTeamMem.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("lvTeamMem.AllItems");
		this.lvTeamMem.AllowColumnReorder = true;
		this.lvTeamMem.AllowDrop = true;
		this.lvTeamMem.AllowReorder = true;
		this.lvTeamMem.AllowSort = false;
		this.lvTeamMem.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_1 });
		this.lvTeamMem.ContextMenuStrip = this.contextMenuStrip1;
		this.lvTeamMem.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvTeamMem.DoubleClickActivation = false;
		this.lvTeamMem.FullRowSelect = true;
		this.lvTeamMem.GridLines = true;
		this.lvTeamMem.HideSelection = false;
		this.lvTeamMem.LineColor = global::System.Drawing.Color.Red;
		this.lvTeamMem.Location = new global::System.Drawing.Point(0, 0);
		this.lvTeamMem.Name = "lvTeamMem";
		this.lvTeamMem.Size = new global::System.Drawing.Size(314, 405);
		this.lvTeamMem.TabIndex = 16;
		this.lvTeamMem.UseCompatibleStateImageBehavior = false;
		this.lvTeamMem.View = global::System.Windows.Forms.View.Details;
		this.lvTeamMem.SelectedIndexChanged += new global::System.EventHandler(this.lvTeamMem_SelectedIndexChanged);
		this.lvTeamMem.ControlRemoved += new global::System.Windows.Forms.ControlEventHandler(this.lvTeamMem_ControlRemoved);
		this.lvTeamMem.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.lvTeamMem_DragDrop);
		this.lvTeamMem.DoubleClick += new global::System.EventHandler(this.lvTeamMem_DoubleClick);
		this.columnHeader_1.Text = "Thành Viên";
		this.columnHeader_1.Width = 120;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.splitContainer1);
		base.Name = "ToDoi";
		base.Size = new global::System.Drawing.Size(620, 405);
		base.Load += new global::System.EventHandler(this.ToDoi_Load);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04002040 RID: 8256
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04002041 RID: 8257
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04002042 RID: 8258
	private global::_i.ListViewEx lvTeamName;

	// Token: 0x04002043 RID: 8259
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04002044 RID: 8260
	private global::_i.ListViewEx lvTeamMem;

	// Token: 0x04002045 RID: 8261
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x04002046 RID: 8262
	private global::System.Windows.Forms.ColumnHeader columnHeader_2;

	// Token: 0x04002047 RID: 8263
	private global::System.Windows.Forms.ColumnHeader columnHeader_3;

	// Token: 0x04002048 RID: 8264
	private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

	// Token: 0x04002049 RID: 8265
	private global::System.Windows.Forms.ToolStripMenuItem deleteDoubleClickToolStripMenuItem;

	// Token: 0x0400204A RID: 8266
	private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

	// Token: 0x0400204B RID: 8267
	private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
}
