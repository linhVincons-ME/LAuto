// Token: 0x0200034D RID: 845
internal partial class UserControl1 : global::System.Windows.Forms.UserControl
{
	// Token: 0x06002C24 RID: 11300 RVA: 0x0001D670 File Offset: 0x0001B870
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x00140320 File Offset: 0x0013E520
	private void InitializeComponent()
	{
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.btnReg = new global::System.Windows.Forms.Button();
		this.panelReRegPass = new global::System.Windows.Forms.Panel();
		this.checkBox1 = new global::System.Windows.Forms.CheckBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.panelRegPass = new global::System.Windows.Forms.Panel();
		this.label3 = new global::System.Windows.Forms.Label();
		this.panelRegUser = new global::System.Windows.Forms.Panel();
		this.label2 = new global::System.Windows.Forms.Label();
		this.panel3 = new global::System.Windows.Forms.Panel();
		this.btnLogin = new global::System.Windows.Forms.Button();
		this.panelPass = new global::System.Windows.Forms.Panel();
		this.kk = new global::System.Windows.Forms.CheckBox();
		this.gr = new global::System.Windows.Forms.Label();
		this.panelUser = new global::System.Windows.Forms.Panel();
		this.fd = new global::System.Windows.Forms.Label();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.panel2.SuspendLayout();
		this.panelReRegPass.SuspendLayout();
		this.panelRegPass.SuspendLayout();
		this.panelRegUser.SuspendLayout();
		this.panel3.SuspendLayout();
		this.panelPass.SuspendLayout();
		this.panelUser.SuspendLayout();
		base.SuspendLayout();
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.splitContainer1.Panel1.Controls.Add(this.panel2);
		this.splitContainer1.Panel2.Controls.Add(this.panel3);
		this.splitContainer1.Size = new global::System.Drawing.Size(671, 440);
		this.splitContainer1.SplitterDistance = 219;
		this.splitContainer1.TabIndex = 9;
		this.splitContainer1.TabStop = false;
		this.panel2.Controls.Add(this.btnReg);
		this.panel2.Controls.Add(this.panelReRegPass);
		this.panel2.Controls.Add(this.panelRegPass);
		this.panel2.Controls.Add(this.panelRegUser);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new global::System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(671, 219);
		this.panel2.TabIndex = 6;
		this.btnReg.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		this.btnReg.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnReg.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnReg.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.btnReg.ForeColor = global::System.Drawing.Color.White;
		this.btnReg.Location = new global::System.Drawing.Point(0, 81);
		this.btnReg.Name = "btnReg";
		this.btnReg.Size = new global::System.Drawing.Size(671, 33);
		this.btnReg.TabIndex = 0;
		this.btnReg.TabStop = false;
		this.btnReg.Text = "Register [Đăng Ký]";
		this.btnReg.UseVisualStyleBackColor = false;
		this.panelReRegPass.Controls.Add(this.checkBox1);
		this.panelReRegPass.Controls.Add(this.label1);
		this.panelReRegPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelReRegPass.Location = new global::System.Drawing.Point(0, 54);
		this.panelReRegPass.Name = "panelReRegPass";
		this.panelReRegPass.Size = new global::System.Drawing.Size(671, 27);
		this.panelReRegPass.TabIndex = 4;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkBox1.Location = new global::System.Drawing.Point(651, 0);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
		this.checkBox1.Size = new global::System.Drawing.Size(20, 27);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.TabStop = false;
		this.checkBox1.UseVisualStyleBackColor = true;
		this.label1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label1.Location = new global::System.Drawing.Point(0, 0);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(110, 27);
		this.label1.TabIndex = 0;
		this.label1.Text = "Retype Pass:";
		this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelRegPass.Controls.Add(this.label3);
		this.panelRegPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelRegPass.Location = new global::System.Drawing.Point(0, 27);
		this.panelRegPass.Name = "panelRegPass";
		this.panelRegPass.Size = new global::System.Drawing.Size(671, 27);
		this.panelRegPass.TabIndex = 3;
		this.label3.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label3.Location = new global::System.Drawing.Point(0, 0);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(110, 27);
		this.label3.TabIndex = 1;
		this.label3.Text = "Pass:";
		this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelRegUser.Controls.Add(this.label2);
		this.panelRegUser.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelRegUser.Location = new global::System.Drawing.Point(0, 0);
		this.panelRegUser.Name = "panelRegUser";
		this.panelRegUser.Size = new global::System.Drawing.Size(671, 27);
		this.panelRegUser.TabIndex = 2;
		this.label2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label2.Location = new global::System.Drawing.Point(0, 0);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(110, 27);
		this.label2.TabIndex = 0;
		this.label2.Text = "User:";
		this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panel3.Controls.Add(this.btnLogin);
		this.panel3.Controls.Add(this.panelPass);
		this.panel3.Controls.Add(this.panelUser);
		this.panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel3.Location = new global::System.Drawing.Point(0, 0);
		this.panel3.Name = "panel3";
		this.panel3.Size = new global::System.Drawing.Size(671, 217);
		this.panel3.TabIndex = 7;
		this.btnLogin.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		this.btnLogin.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnLogin.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnLogin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.btnLogin.ForeColor = global::System.Drawing.Color.White;
		this.btnLogin.Location = new global::System.Drawing.Point(0, 54);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new global::System.Drawing.Size(671, 33);
		this.btnLogin.TabIndex = 0;
		this.btnLogin.TabStop = false;
		this.btnLogin.Text = "Login [Đăng Nhập]";
		this.btnLogin.UseVisualStyleBackColor = false;
		this.panelPass.Controls.Add(this.kk);
		this.panelPass.Controls.Add(this.gr);
		this.panelPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelPass.Location = new global::System.Drawing.Point(0, 27);
		this.panelPass.Name = "panelPass";
		this.panelPass.Size = new global::System.Drawing.Size(671, 27);
		this.panelPass.TabIndex = 1;
		this.kk.AutoSize = true;
		this.kk.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.kk.Location = new global::System.Drawing.Point(651, 0);
		this.kk.Name = "kk";
		this.kk.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
		this.kk.Size = new global::System.Drawing.Size(20, 27);
		this.kk.TabIndex = 0;
		this.kk.TabStop = false;
		this.kk.UseVisualStyleBackColor = true;
		this.gr.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.gr.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.gr.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.gr.Location = new global::System.Drawing.Point(0, 0);
		this.gr.Name = "gr";
		this.gr.Size = new global::System.Drawing.Size(69, 27);
		this.gr.TabIndex = 0;
		this.gr.Text = "Pass:";
		this.gr.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelUser.Controls.Add(this.fd);
		this.panelUser.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelUser.Location = new global::System.Drawing.Point(0, 0);
		this.panelUser.Name = "panelUser";
		this.panelUser.Size = new global::System.Drawing.Size(671, 27);
		this.panelUser.TabIndex = 0;
		this.fd.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.fd.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.fd.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.fd.Location = new global::System.Drawing.Point(0, 0);
		this.fd.Name = "fd";
		this.fd.Size = new global::System.Drawing.Size(69, 27);
		this.fd.TabIndex = 0;
		this.fd.Text = "User:";
		this.fd.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.splitContainer1);
		base.Name = "UserControl1";
		base.Size = new global::System.Drawing.Size(671, 440);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		this.panelReRegPass.ResumeLayout(false);
		this.panelReRegPass.PerformLayout();
		this.panelRegPass.ResumeLayout(false);
		this.panelRegUser.ResumeLayout(false);
		this.panel3.ResumeLayout(false);
		this.panelPass.ResumeLayout(false);
		this.panelPass.PerformLayout();
		this.panelUser.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x0400206E RID: 8302
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x0400206F RID: 8303
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04002070 RID: 8304
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04002071 RID: 8305
	private global::System.Windows.Forms.Button btnReg;

	// Token: 0x04002072 RID: 8306
	private global::System.Windows.Forms.Panel panelReRegPass;

	// Token: 0x04002073 RID: 8307
	private global::System.Windows.Forms.CheckBox checkBox1;

	// Token: 0x04002074 RID: 8308
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04002075 RID: 8309
	private global::System.Windows.Forms.Panel panelRegPass;

	// Token: 0x04002076 RID: 8310
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04002077 RID: 8311
	private global::System.Windows.Forms.Panel panelRegUser;

	// Token: 0x04002078 RID: 8312
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04002079 RID: 8313
	private global::System.Windows.Forms.Panel panel3;

	// Token: 0x0400207A RID: 8314
	private global::System.Windows.Forms.Button btnLogin;

	// Token: 0x0400207B RID: 8315
	private global::System.Windows.Forms.Panel panelPass;

	// Token: 0x0400207C RID: 8316
	private global::System.Windows.Forms.CheckBox kk;

	// Token: 0x0400207D RID: 8317
	private global::System.Windows.Forms.Label gr;

	// Token: 0x0400207E RID: 8318
	private global::System.Windows.Forms.Panel panelUser;

	// Token: 0x0400207F RID: 8319
	private global::System.Windows.Forms.Label fd;
}
