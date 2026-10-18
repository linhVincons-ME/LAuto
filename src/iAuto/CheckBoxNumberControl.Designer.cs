// Token: 0x02000095 RID: 149
public partial class CheckBoxNumberControl : global::System.Windows.Forms.UserControl
{
	// Token: 0x060006B9 RID: 1721 RVA: 0x000078BD File Offset: 0x00005ABD
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000330FC File Offset: 0x000312FC
	private void InitializeComponent()
	{
		this.checkBox = new global::System.Windows.Forms.CheckBox();
		this.numericUpDown = new global::System.Windows.Forms.NumericUpDown();
		((global::System.ComponentModel.ISupportInitialize)this.numericUpDown).BeginInit();
		base.SuspendLayout();
		this.checkBox.AutoSize = true;
		this.checkBox.Location = new global::System.Drawing.Point(0, 0);
		this.checkBox.Margin = new global::System.Windows.Forms.Padding(0);
		this.checkBox.Name = "checkBox";
		this.checkBox.Padding = new global::System.Windows.Forms.Padding(0, 2, 0, 0);
		this.checkBox.Size = new global::System.Drawing.Size(73, 19);
		this.checkBox.TabIndex = 0;
		this.checkBox.Text = "Tùy chỉnh";
		this.checkBox.UseVisualStyleBackColor = true;
		this.numericUpDown.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.numericUpDown.Location = new global::System.Drawing.Point(115, 0);
		this.numericUpDown.Name = "numericUpDown";
		this.numericUpDown.Size = new global::System.Drawing.Size(40, 20);
		this.numericUpDown.TabIndex = 1;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.numericUpDown);
		base.Controls.Add(this.checkBox);
		base.Name = "CheckBoxNumberControl";
		base.Size = new global::System.Drawing.Size(155, 20);
		((global::System.ComponentModel.ISupportInitialize)this.numericUpDown).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000382 RID: 898
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000383 RID: 899
	private global::System.Windows.Forms.CheckBox checkBox;

	// Token: 0x04000384 RID: 900
	private global::System.Windows.Forms.NumericUpDown numericUpDown;
}
