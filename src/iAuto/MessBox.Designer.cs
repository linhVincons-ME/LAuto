// Token: 0x020002CB RID: 715
internal partial class MessBox : global::System.Windows.Forms.UserControl
{
	// Token: 0x06002402 RID: 9218 RVA: 0x00018732 File Offset: 0x00016932
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x001105D8 File Offset: 0x0010E7D8
	private void InitializeComponent()
	{
		this.textBox1 = new global::System.Windows.Forms.TextBox();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button2 = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.textBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
		this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textBox1.ForeColor = global::System.Drawing.Color.White;
		this.textBox1.Location = new global::System.Drawing.Point(20, 16);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new global::System.Drawing.Size(356, 359);
		this.textBox1.TabIndex = 0;
		this.textBox1.Text = "Tài Khoản Không Tồn Tại";
		this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
		this.button1.BackColor = global::System.Drawing.Color.White;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.button1.Location = new global::System.Drawing.Point(110, 391);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(285, 41);
		this.button1.TabIndex = 1;
		this.button1.Text = "Ok";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.button2.BackColor = global::System.Drawing.Color.White;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.button2.Location = new global::System.Drawing.Point(0, 391);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(111, 41);
		this.button2.TabIndex = 2;
		this.button2.Text = "Cancel";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.button1);
		base.Name = "MessBox";
		base.Size = new global::System.Drawing.Size(395, 432);
		base.Load += new global::System.EventHandler(this.MessBox_Load);
		base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.MessBox_KeyPress);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040018D5 RID: 6357
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x040018D6 RID: 6358
	private global::System.Windows.Forms.TextBox textBox1;

	// Token: 0x040018D7 RID: 6359
	private global::System.Windows.Forms.Button button1;

	// Token: 0x040018D8 RID: 6360
	private global::System.Windows.Forms.Button button2;
}
