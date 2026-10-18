// Token: 0x0200034E RID: 846
public partial class AutoMap : global::System.Windows.Forms.UserControl
{
	// Token: 0x06002C2B RID: 11307 RVA: 0x0001D69D File Offset: 0x0001B89D
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x001412B0 File Offset: 0x0013F4B0
	private void InitializeComponent()
	{
		this.groupBox11 = new global::System.Windows.Forms.GroupBox();
		this.lvAutoMap = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.comboBox2 = new global::System.Windows.Forms.ComboBox();
		this.button15 = new global::System.Windows.Forms.Button();
		this.groupBox11.SuspendLayout();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.groupBox11.Controls.Add(this.lvAutoMap);
		this.groupBox11.Controls.Add(this.panel2);
		this.groupBox11.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.groupBox11.Location = new global::System.Drawing.Point(0, 0);
		this.groupBox11.Margin = new global::System.Windows.Forms.Padding(0);
		this.groupBox11.Name = "groupBox11";
		this.groupBox11.Size = new global::System.Drawing.Size(475, 372);
		this.groupBox11.TabIndex = 6;
		this.groupBox11.TabStop = false;
		this.groupBox11.Text = "Map";
		this.lvAutoMap.AllItems = null;
		this.lvAutoMap.AllowColumnReorder = true;
		this.lvAutoMap.AllowDrop = true;
		this.lvAutoMap.AllowReorder = true;
		this.lvAutoMap.AllowSort = false;
		this.lvAutoMap.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0 });
		this.lvAutoMap.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvAutoMap.DoubleClickActivation = false;
		this.lvAutoMap.FullRowSelect = true;
		this.lvAutoMap.GridLines = true;
		this.lvAutoMap.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
		this.lvAutoMap.HideSelection = false;
		this.lvAutoMap.LineColor = global::System.Drawing.Color.Red;
		this.lvAutoMap.Location = new global::System.Drawing.Point(3, 37);
		this.lvAutoMap.Name = "lvAutoMap";
		this.lvAutoMap.Size = new global::System.Drawing.Size(469, 332);
		this.lvAutoMap.TabIndex = 2;
		this.lvAutoMap.UseCompatibleStateImageBehavior = false;
		this.lvAutoMap.View = global::System.Windows.Forms.View.Details;
		this.lvAutoMap.DoubleClick += new global::System.EventHandler(this.lvAutoMap_DoubleClick);
		this.columnHeader_0.Text = "Point";
		this.columnHeader_0.Width = 104;
		this.panel2.Controls.Add(this.comboBox2);
		this.panel2.Controls.Add(this.button15);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel2.Location = new global::System.Drawing.Point(3, 16);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(469, 21);
		this.panel2.TabIndex = 1;
		this.comboBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Location = new global::System.Drawing.Point(0, 0);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new global::System.Drawing.Size(436, 21);
		this.comboBox2.TabIndex = 0;
		this.comboBox2.DropDown += new global::System.EventHandler(this.comboBox2_DropDown);
		this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
		this.button15.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button15.Location = new global::System.Drawing.Point(436, 0);
		this.button15.Name = "button15";
		this.button15.Size = new global::System.Drawing.Size(33, 21);
		this.button15.TabIndex = 1;
		this.button15.Text = "+";
		this.button15.UseVisualStyleBackColor = true;
		this.button15.Click += new global::System.EventHandler(this.button15_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.groupBox11);
		base.Name = "AutoMap";
		base.Size = new global::System.Drawing.Size(475, 372);
		this.groupBox11.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04002080 RID: 8320
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04002081 RID: 8321
	private global::System.Windows.Forms.GroupBox groupBox11;

	// Token: 0x04002082 RID: 8322
	private global::_i.ListViewEx lvAutoMap;

	// Token: 0x04002083 RID: 8323
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04002084 RID: 8324
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04002085 RID: 8325
	private global::System.Windows.Forms.ComboBox comboBox2;

	// Token: 0x04002086 RID: 8326
	private global::System.Windows.Forms.Button button15;
}
