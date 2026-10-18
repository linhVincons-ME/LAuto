// Token: 0x02000170 RID: 368
public partial class AutoPkEx : global::System.Windows.Forms.Form
{
	// Token: 0x06001612 RID: 5650 RVA: 0x0000F98B File Offset: 0x0000DB8B
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x000AE39C File Offset: 0x000AC59C
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoPkEx));
		this.menuListName = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.button2 = new global::System.Windows.Forms.Button();
		this.checkIsFight = new global::System.Windows.Forms.CheckBox();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.txtListName = new global::Class533();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.checkBox1 = new global::System.Windows.Forms.CheckBox();
		this.listViewName = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.txtSearch = new global::Class533();
		this.panel1.SuspendLayout();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.menuListName.Name = "menuListName";
		this.menuListName.Size = new global::System.Drawing.Size(61, 4);
		this.menuListName.Opening += new global::System.ComponentModel.CancelEventHandler(this.menuListName_Opening);
		this.button2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.button2.Location = new global::System.Drawing.Point(154, 0);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(162, 20);
		this.button2.TabIndex = 10;
		this.button2.Text = "Refresh";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.checkIsFight.AutoSize = true;
		this.checkIsFight.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkIsFight.Location = new global::System.Drawing.Point(3, 0);
		this.checkIsFight.Name = "checkIsFight";
		this.checkIsFight.Size = new global::System.Drawing.Size(92, 20);
		this.checkIsFight.TabIndex = 12;
		this.checkIsFight.Text = "Fight [Alt + Y ]";
		this.checkIsFight.UseVisualStyleBackColor = true;
		this.checkIsFight.CheckedChanged += new global::System.EventHandler(this.checkIsFight_CheckedChanged);
		this.panel1.Controls.Add(this.txtListName);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panel1.Location = new global::System.Drawing.Point(0, 339);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(316, 40);
		this.panel1.TabIndex = 18;
		this.txtListName.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtListName.Location = new global::System.Drawing.Point(0, 0);
		this.txtListName.Name = "txtListName";
		this.txtListName.Size = new global::System.Drawing.Size(316, 20);
		this.txtListName.TabIndex = 13;
		this.txtListName.String_0 = "List Name";
		this.txtListName.Color_0 = global::System.Drawing.Color.Gray;
		this.txtListName.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtListName.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtListName.TextChanged += new global::System.EventHandler(this.txtListName_TextChanged);
		this.panel2.Controls.Add(this.button2);
		this.panel2.Controls.Add(this.checkBox1);
		this.panel2.Controls.Add(this.checkIsFight);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panel2.Location = new global::System.Drawing.Point(0, 20);
		this.panel2.Name = "panel2";
		this.panel2.Padding = new global::System.Windows.Forms.Padding(3, 0, 0, 0);
		this.panel2.Size = new global::System.Drawing.Size(316, 20);
		this.panel2.TabIndex = 14;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Checked = true;
		this.checkBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
		this.checkBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkBox1.Location = new global::System.Drawing.Point(95, 0);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new global::System.Drawing.Size(59, 20);
		this.checkBox1.TabIndex = 13;
		this.checkBox1.Text = "OnTop";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
		this.listViewName.AllItems = (global::System.Collections.Generic.List<global::System.Windows.Forms.ListViewItem>)componentResourceManager.GetObject("listViewName.AllItems");
		this.listViewName.AllowColumnReorder = true;
		this.listViewName.AllowDrop = true;
		this.listViewName.AllowReorder = true;
		this.listViewName.AllowSort = true;
		this.listViewName.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0 });
		this.listViewName.ContextMenuStrip = this.menuListName;
		this.listViewName.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.listViewName.DoubleClickActivation = false;
		this.listViewName.FullRowSelect = true;
		this.listViewName.GridLines = true;
		this.listViewName.HideSelection = false;
		this.listViewName.LineColor = global::System.Drawing.Color.Red;
		this.listViewName.Location = new global::System.Drawing.Point(0, 20);
		this.listViewName.Name = "listViewName";
		this.listViewName.Size = new global::System.Drawing.Size(316, 319);
		this.listViewName.TabIndex = 16;
		this.listViewName.UseCompatibleStateImageBehavior = false;
		this.listViewName.View = global::System.Windows.Forms.View.Details;
		this.listViewName.SelectedIndexChanged += new global::System.EventHandler(this.listViewName_SelectedIndexChanged);
		this.columnHeader_0.Text = "Name";
		this.columnHeader_0.Width = 189;
		this.txtSearch.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.txtSearch.Location = new global::System.Drawing.Point(0, 0);
		this.txtSearch.Name = "txtSearch";
		this.txtSearch.Size = new global::System.Drawing.Size(316, 20);
		this.txtSearch.TabIndex = 17;
		this.txtSearch.String_0 = "Search";
		this.txtSearch.Color_0 = global::System.Drawing.Color.Gray;
		this.txtSearch.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtSearch.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtSearch.TextChanged += new global::System.EventHandler(this.txtSearch_TextChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(316, 379);
		base.Controls.Add(this.listViewName);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.txtSearch);
		base.Name = "AutoPkEx";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Fight";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.AutoPkEx_FormClosing);
		base.Load += new global::System.EventHandler(this.AutoPkEx_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000D58 RID: 3416
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000D59 RID: 3417
	private global::_i.ListViewEx listViewName;

	// Token: 0x04000D5A RID: 3418
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000D5B RID: 3419
	private global::System.Windows.Forms.ContextMenuStrip menuListName;

	// Token: 0x04000D5C RID: 3420
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000D5D RID: 3421
	public global::System.Windows.Forms.CheckBox checkIsFight;

	// Token: 0x04000D5E RID: 3422
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000D5F RID: 3423
	private global::Class533 txtListName;

	// Token: 0x04000D60 RID: 3424
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04000D61 RID: 3425
	public global::System.Windows.Forms.CheckBox checkBox1;

	// Token: 0x04000D62 RID: 3426
	private global::Class533 txtSearch;
}
