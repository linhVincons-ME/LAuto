// Token: 0x0200019B RID: 411
internal partial class Code : global::System.Windows.Forms.Form
{
	// Token: 0x06001768 RID: 5992 RVA: 0x000103F2 File Offset: 0x0000E5F2
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x000C2B1C File Offset: 0x000C0D1C
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.txtCode = new global::Class533();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.btnCode = new global::System.Windows.Forms.Button();
		this.label3 = new global::System.Windows.Forms.Label();
		this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
		this.label4 = new global::System.Windows.Forms.Label();
		this.listViewCode = new global::_i.ListViewEx();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.button1 = new global::System.Windows.Forms.Button();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.panel2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
		base.SuspendLayout();
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.splitContainer1.Panel1.Controls.Add(this.txtCode);
		this.splitContainer1.Panel1.Controls.Add(this.panel2);
		this.splitContainer1.Panel2.Controls.Add(this.listViewCode);
		this.splitContainer1.Size = new global::System.Drawing.Size(607, 417);
		this.splitContainer1.SplitterDistance = 230;
		this.splitContainer1.TabIndex = 1;
		this.txtCode.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtCode.Location = new global::System.Drawing.Point(0, 0);
		this.txtCode.Multiline = true;
		this.txtCode.Name = "txtCode";
		this.txtCode.Size = new global::System.Drawing.Size(607, 208);
		this.txtCode.TabIndex = 0;
		this.txtCode.String_0 = "Code...";
		this.txtCode.Color_0 = global::System.Drawing.Color.Gray;
		this.txtCode.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtCode.Color_1 = global::System.Drawing.Color.LightGray;
		this.panel2.BackColor = global::System.Drawing.Color.White;
		this.panel2.Controls.Add(this.button1);
		this.panel2.Controls.Add(this.btnCode);
		this.panel2.Controls.Add(this.label3);
		this.panel2.Controls.Add(this.numericUpDown2);
		this.panel2.Controls.Add(this.label4);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panel2.Location = new global::System.Drawing.Point(0, 208);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(607, 22);
		this.panel2.TabIndex = 2;
		this.btnCode.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnCode.Location = new global::System.Drawing.Point(538, 0);
		this.btnCode.Name = "btnCode";
		this.btnCode.Size = new global::System.Drawing.Size(69, 22);
		this.btnCode.TabIndex = 1;
		this.btnCode.Text = "Nhập";
		this.btnCode.UseVisualStyleBackColor = true;
		this.btnCode.Click += new global::System.EventHandler(this.btnCode_Click);
		this.label3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.label3.AutoSize = true;
		this.label3.Location = new global::System.Drawing.Point(106, 3);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(12, 13);
		this.label3.TabIndex = 3;
		this.label3.Text = "s";
		this.numericUpDown2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.numericUpDown2.Location = new global::System.Drawing.Point(49, 1);
		global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown2;
		int[] array = new int[4];
		array[0] = 1;
		numericUpDown.Minimum = new decimal(array);
		this.numericUpDown2.Name = "numericUpDown2";
		this.numericUpDown2.Size = new global::System.Drawing.Size(51, 20);
		this.numericUpDown2.TabIndex = 2;
		global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown2;
		int[] array2 = new int[4];
		array2[0] = 5;
		numericUpDown2.Value = new decimal(array2);
		this.numericUpDown2.ValueChanged += new global::System.EventHandler(this.numericUpDown2_ValueChanged);
		this.label4.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.label4.AutoSize = true;
		this.label4.Location = new global::System.Drawing.Point(9, 4);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(34, 13);
		this.label4.TabIndex = 1;
		this.label4.Text = "Delay";
		this.listViewCode.AllowColumnReorder = true;
		this.listViewCode.AllowDrop = true;
		this.listViewCode.AllowReorder = true;
		this.listViewCode.AllowSort = false;
		this.listViewCode.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_0, this.columnHeader_1 });
		this.listViewCode.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.listViewCode.DoubleClickActivation = false;
		this.listViewCode.FullRowSelect = true;
		this.listViewCode.GridLines = true;
		this.listViewCode.HideSelection = false;
		this.listViewCode.LineColor = global::System.Drawing.Color.Red;
		this.listViewCode.Location = new global::System.Drawing.Point(0, 0);
		this.listViewCode.Name = "listViewCode";
		this.listViewCode.Size = new global::System.Drawing.Size(607, 183);
		this.listViewCode.TabIndex = 0;
		this.listViewCode.UseCompatibleStateImageBehavior = false;
		this.listViewCode.View = global::System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Code";
		this.columnHeader_0.Width = 170;
		this.columnHeader_1.Text = "Status";
		this.columnHeader_1.Width = 97;
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 5000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button1.Location = new global::System.Drawing.Point(469, 0);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(69, 22);
		this.button1.TabIndex = 4;
		this.button1.Text = "Close";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(607, 417);
		base.Controls.Add(this.splitContainer1);
		base.Name = "Code";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Nhập Code";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.Code_Load);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.PerformLayout();
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000ED2 RID: 3794
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000ED3 RID: 3795
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04000ED4 RID: 3796
	private global::Class533 txtCode;

	// Token: 0x04000ED5 RID: 3797
	private global::System.Windows.Forms.Button btnCode;

	// Token: 0x04000ED6 RID: 3798
	private global::_i.ListViewEx listViewCode;

	// Token: 0x04000ED7 RID: 3799
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000ED8 RID: 3800
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x04000ED9 RID: 3801
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000EDA RID: 3802
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04000EDB RID: 3803
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04000EDC RID: 3804
	private global::System.Windows.Forms.NumericUpDown numericUpDown2;

	// Token: 0x04000EDD RID: 3805
	private global::System.Windows.Forms.Label label4;

	// Token: 0x04000EDE RID: 3806
	private global::System.Windows.Forms.Button button1;
}
