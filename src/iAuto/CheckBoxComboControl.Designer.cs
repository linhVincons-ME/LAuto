// Token: 0x02000096 RID: 150
public partial class CheckBoxComboControl : global::System.Windows.Forms.UserControl
{
	// Token: 0x060006ED RID: 1773 RVA: 0x00033570 File Offset: 0x00031770
	private void InitializeComponent()
	{
		this.tableLayout = new global::System.Windows.Forms.TableLayoutPanel();
		this.checkBox = new global::System.Windows.Forms.CheckBox();
		this.comboBox = new global::GClass30();
		this.tableLayout.SuspendLayout();
		base.SuspendLayout();
		this.tableLayout.ColumnCount = 2;
		this.tableLayout.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
		this.tableLayout.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayout.Controls.Add(this.checkBox, 0, 0);
		this.tableLayout.Controls.Add(this.comboBox, 1, 0);
		this.tableLayout.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tableLayout.Location = new global::System.Drawing.Point(0, 0);
		this.tableLayout.Margin = new global::System.Windows.Forms.Padding(0);
		this.tableLayout.Name = "tableLayout";
		this.tableLayout.RowCount = 1;
		this.tableLayout.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayout.Size = new global::System.Drawing.Size(250, 23);
		this.tableLayout.TabIndex = 0;
		this.checkBox.AutoSize = true;
		this.checkBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.checkBox.Location = new global::System.Drawing.Point(0, 0);
		this.checkBox.Margin = new global::System.Windows.Forms.Padding(0);
		this.checkBox.Name = "checkBox";
		this.checkBox.Size = new global::System.Drawing.Size(73, 23);
		this.checkBox.TabIndex = 0;
		this.checkBox.Text = "Tùy chỉnh";
		this.checkBox.UseVisualStyleBackColor = true;
		this.checkBox.CheckedChanged += new global::System.EventHandler(this.checkBox_CheckedChanged);
		this.comboBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.comboBox.FormattingEnabled = true;
		this.comboBox.ItemHeight = 13;
		this.comboBox.Location = new global::System.Drawing.Point(73, 0);
		this.comboBox.Margin = new global::System.Windows.Forms.Padding(0);
		this.comboBox.Name = "comboBox";
		this.comboBox.Size = new global::System.Drawing.Size(177, 21);
		this.comboBox.TabIndex = 1;
		this.comboBox.SelectedIndexChanged += new global::System.EventHandler(this.comboBox_SelectedIndexChanged);
		this.comboBox.TextChanged += new global::System.EventHandler(this.comboBox_TextChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.tableLayout);
		base.Margin = new global::System.Windows.Forms.Padding(0);
		base.Name = "CheckBoxComboControl";
		base.Size = new global::System.Drawing.Size(250, 23);
		this.tableLayout.ResumeLayout(false);
		this.tableLayout.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000388 RID: 904
	private global::System.Windows.Forms.CheckBox checkBox;

	// Token: 0x04000389 RID: 905
	private global::GClass30 comboBox;

	// Token: 0x0400038A RID: 906
	private global::System.Windows.Forms.TableLayoutPanel tableLayout;
}
