// Token: 0x0200034C RID: 844
internal partial class LoginiAuto : global::System.Windows.Forms.UserControl
{
	// Token: 0x06002C1D RID: 11293 RVA: 0x0001D643 File Offset: 0x0001B843
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x0013ED94 File Offset: 0x0013CF94
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.btnReg = new global::System.Windows.Forms.Button();
		this.panelReRegPass = new global::System.Windows.Forms.Panel();
		this.txtConfirmPass = new global::Class533();
		this.checkBox1 = new global::System.Windows.Forms.CheckBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.panelRegPass = new global::System.Windows.Forms.Panel();
		this.txtRegPass = new global::Class533();
		this.label3 = new global::System.Windows.Forms.Label();
		this.panelRegUser = new global::System.Windows.Forms.Panel();
		this.txtRegUser = new global::Class533();
		this.label2 = new global::System.Windows.Forms.Label();
		this.panel3 = new global::System.Windows.Forms.Panel();
		this.label4 = new global::System.Windows.Forms.Label();
		this.btnLogin = new global::System.Windows.Forms.Button();
		this.panelPass = new global::System.Windows.Forms.Panel();
		this.txtLoginPass = new global::Class533();
		this.kk = new global::System.Windows.Forms.CheckBox();
		this.gr = new global::System.Windows.Forms.Label();
		this.panelUser = new global::System.Windows.Forms.Panel();
		this.txtLoginUser = new global::Class533();
		this.fd = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
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
		this.splitContainer1.Size = new global::System.Drawing.Size(452, 370);
		this.splitContainer1.SplitterDistance = 187;
		this.splitContainer1.TabIndex = 9;
		this.splitContainer1.TabStop = false;
		this.panel2.Controls.Add(this.btnReg);
		this.panel2.Controls.Add(this.panelReRegPass);
		this.panel2.Controls.Add(this.panelRegPass);
		this.panel2.Controls.Add(this.panelRegUser);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new global::System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(452, 187);
		this.panel2.TabIndex = 6;
		this.btnReg.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		this.btnReg.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnReg.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnReg.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.btnReg.ForeColor = global::System.Drawing.Color.White;
		this.btnReg.Location = new global::System.Drawing.Point(0, 81);
		this.btnReg.Name = "btnReg";
		this.btnReg.Size = new global::System.Drawing.Size(452, 33);
		this.btnReg.TabIndex = 0;
		this.btnReg.TabStop = false;
		this.btnReg.Text = "Register [Đăng Ký]";
		this.btnReg.UseVisualStyleBackColor = false;
		this.btnReg.Click += new global::System.EventHandler(this.btnReg_Click);
		this.panelReRegPass.Controls.Add(this.txtConfirmPass);
		this.panelReRegPass.Controls.Add(this.checkBox1);
		this.panelReRegPass.Controls.Add(this.label1);
		this.panelReRegPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelReRegPass.Location = new global::System.Drawing.Point(0, 54);
		this.panelReRegPass.Name = "panelReRegPass";
		this.panelReRegPass.Size = new global::System.Drawing.Size(452, 27);
		this.panelReRegPass.TabIndex = 4;
		this.txtConfirmPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtConfirmPass.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtConfirmPass.Location = new global::System.Drawing.Point(110, 0);
		this.txtConfirmPass.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtConfirmPass.Name = "txtConfirmPass";
		this.txtConfirmPass.PasswordChar = '*';
		this.txtConfirmPass.Size = new global::System.Drawing.Size(322, 26);
		this.txtConfirmPass.TabIndex = 2;
		this.txtConfirmPass.String_0 = "ConfirmPass";
		this.txtConfirmPass.Color_0 = global::System.Drawing.Color.Gray;
		this.txtConfirmPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtConfirmPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkBox1.Location = new global::System.Drawing.Point(432, 0);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
		this.checkBox1.Size = new global::System.Drawing.Size(20, 27);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.TabStop = false;
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
		this.label1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label1.Location = new global::System.Drawing.Point(0, 0);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(110, 27);
		this.label1.TabIndex = 0;
		this.label1.Text = "Retype Pass:";
		this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelRegPass.Controls.Add(this.txtRegPass);
		this.panelRegPass.Controls.Add(this.label3);
		this.panelRegPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelRegPass.Location = new global::System.Drawing.Point(0, 27);
		this.panelRegPass.Name = "panelRegPass";
		this.panelRegPass.Size = new global::System.Drawing.Size(452, 27);
		this.panelRegPass.TabIndex = 3;
		this.txtRegPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtRegPass.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtRegPass.Location = new global::System.Drawing.Point(110, 0);
		this.txtRegPass.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtRegPass.Name = "txtRegPass";
		this.txtRegPass.PasswordChar = '*';
		this.txtRegPass.Size = new global::System.Drawing.Size(342, 26);
		this.txtRegPass.TabIndex = 2;
		this.txtRegPass.String_0 = "Pass";
		this.txtRegPass.Color_0 = global::System.Drawing.Color.Gray;
		this.txtRegPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtRegPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.label3.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label3.Location = new global::System.Drawing.Point(0, 0);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(110, 27);
		this.label3.TabIndex = 1;
		this.label3.Text = "Pass:";
		this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelRegUser.Controls.Add(this.txtRegUser);
		this.panelRegUser.Controls.Add(this.label2);
		this.panelRegUser.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelRegUser.Location = new global::System.Drawing.Point(0, 0);
		this.panelRegUser.Name = "panelRegUser";
		this.panelRegUser.Size = new global::System.Drawing.Size(452, 27);
		this.panelRegUser.TabIndex = 2;
		this.txtRegUser.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtRegUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtRegUser.Location = new global::System.Drawing.Point(110, 0);
		this.txtRegUser.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtRegUser.Name = "txtRegUser";
		this.txtRegUser.Size = new global::System.Drawing.Size(342, 26);
		this.txtRegUser.TabIndex = 1;
		this.txtRegUser.String_0 = "User";
		this.txtRegUser.Color_0 = global::System.Drawing.Color.Gray;
		this.txtRegUser.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtRegUser.Color_1 = global::System.Drawing.Color.LightGray;
		this.label2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.label2.Location = new global::System.Drawing.Point(0, 0);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(110, 27);
		this.label2.TabIndex = 0;
		this.label2.Text = "User:";
		this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panel3.Controls.Add(this.label4);
		this.panel3.Controls.Add(this.btnLogin);
		this.panel3.Controls.Add(this.panelPass);
		this.panel3.Controls.Add(this.panelUser);
		this.panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel3.Location = new global::System.Drawing.Point(0, 0);
		this.panel3.Name = "panel3";
		this.panel3.Size = new global::System.Drawing.Size(452, 179);
		this.panel3.TabIndex = 7;
		this.panel3.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
		this.label4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.label4.Location = new global::System.Drawing.Point(0, 156);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(452, 23);
		this.label4.TabIndex = 2;
		this.label4.Text = "Auto Login After 60 sec";
		this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.btnLogin.BackColor = global::System.Drawing.Color.FromArgb(15, 157, 88);
		this.btnLogin.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnLogin.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnLogin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.btnLogin.ForeColor = global::System.Drawing.Color.White;
		this.btnLogin.Location = new global::System.Drawing.Point(0, 54);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new global::System.Drawing.Size(452, 33);
		this.btnLogin.TabIndex = 0;
		this.btnLogin.TabStop = false;
		this.btnLogin.Text = "Login [Đăng Nhập]";
		this.btnLogin.UseVisualStyleBackColor = false;
		this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
		this.panelPass.Controls.Add(this.txtLoginPass);
		this.panelPass.Controls.Add(this.kk);
		this.panelPass.Controls.Add(this.gr);
		this.panelPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelPass.Location = new global::System.Drawing.Point(0, 27);
		this.panelPass.Name = "panelPass";
		this.panelPass.Size = new global::System.Drawing.Size(452, 27);
		this.panelPass.TabIndex = 1;
		this.txtLoginPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtLoginPass.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtLoginPass.Location = new global::System.Drawing.Point(69, 0);
		this.txtLoginPass.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtLoginPass.Name = "txtLoginPass";
		this.txtLoginPass.PasswordChar = '*';
		this.txtLoginPass.Size = new global::System.Drawing.Size(363, 26);
		this.txtLoginPass.TabIndex = 2;
		this.txtLoginPass.String_0 = "Pass";
		this.txtLoginPass.Color_0 = global::System.Drawing.Color.Gray;
		this.txtLoginPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtLoginPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtLoginPass.TextChanged += new global::System.EventHandler(this.txtLoginPass_TextChanged);
		this.txtLoginPass.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtLoginPass_KeyDown);
		this.kk.AutoSize = true;
		this.kk.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.kk.Location = new global::System.Drawing.Point(432, 0);
		this.kk.Name = "kk";
		this.kk.Padding = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
		this.kk.Size = new global::System.Drawing.Size(20, 27);
		this.kk.TabIndex = 0;
		this.kk.TabStop = false;
		this.kk.UseVisualStyleBackColor = true;
		this.kk.CheckedChanged += new global::System.EventHandler(this.kk_CheckedChanged);
		this.gr.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.gr.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.gr.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.gr.Location = new global::System.Drawing.Point(0, 0);
		this.gr.Name = "gr";
		this.gr.Size = new global::System.Drawing.Size(69, 27);
		this.gr.TabIndex = 0;
		this.gr.Text = "Pass:";
		this.gr.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.panelUser.Controls.Add(this.txtLoginUser);
		this.panelUser.Controls.Add(this.fd);
		this.panelUser.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelUser.Location = new global::System.Drawing.Point(0, 0);
		this.panelUser.Name = "panelUser";
		this.panelUser.Size = new global::System.Drawing.Size(452, 27);
		this.panelUser.TabIndex = 0;
		this.txtLoginUser.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtLoginUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtLoginUser.Location = new global::System.Drawing.Point(69, 0);
		this.txtLoginUser.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtLoginUser.Name = "txtLoginUser";
		this.txtLoginUser.Size = new global::System.Drawing.Size(383, 26);
		this.txtLoginUser.TabIndex = 2;
		this.txtLoginUser.String_0 = "User";
		this.txtLoginUser.Color_0 = global::System.Drawing.Color.Gray;
		this.txtLoginUser.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtLoginUser.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtLoginUser.TextChanged += new global::System.EventHandler(this.txtLoginUser_TextChanged);
		this.txtLoginUser.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtLoginUser_KeyDown);
		this.fd.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.fd.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.fd.ForeColor = global::System.Drawing.SystemColors.GrayText;
		this.fd.Location = new global::System.Drawing.Point(0, 0);
		this.fd.Name = "fd";
		this.fd.Size = new global::System.Drawing.Size(69, 27);
		this.fd.TabIndex = 0;
		this.fd.Text = "User:";
		this.fd.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.Controls.Add(this.splitContainer1);
		base.Margin = new global::System.Windows.Forms.Padding(2);
		base.Name = "LoginiAuto";
		base.Size = new global::System.Drawing.Size(452, 370);
		base.Load += new global::System.EventHandler(this.LoginiAuto_Load);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		this.panelReRegPass.ResumeLayout(false);
		this.panelReRegPass.PerformLayout();
		this.panelRegPass.ResumeLayout(false);
		this.panelRegPass.PerformLayout();
		this.panelRegUser.ResumeLayout(false);
		this.panelRegUser.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panelPass.ResumeLayout(false);
		this.panelPass.PerformLayout();
		this.panelUser.ResumeLayout(false);
		this.panelUser.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04002055 RID: 8277
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04002056 RID: 8278
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x04002057 RID: 8279
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x04002058 RID: 8280
	private global::System.Windows.Forms.Button btnReg;

	// Token: 0x04002059 RID: 8281
	private global::System.Windows.Forms.Panel panelReRegPass;

	// Token: 0x0400205A RID: 8282
	private global::System.Windows.Forms.CheckBox checkBox1;

	// Token: 0x0400205B RID: 8283
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400205C RID: 8284
	private global::System.Windows.Forms.Panel panelRegPass;

	// Token: 0x0400205D RID: 8285
	private global::System.Windows.Forms.Label label3;

	// Token: 0x0400205E RID: 8286
	private global::System.Windows.Forms.Panel panelRegUser;

	// Token: 0x0400205F RID: 8287
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04002060 RID: 8288
	private global::System.Windows.Forms.Panel panel3;

	// Token: 0x04002061 RID: 8289
	private global::System.Windows.Forms.Button btnLogin;

	// Token: 0x04002062 RID: 8290
	private global::System.Windows.Forms.Panel panelPass;

	// Token: 0x04002063 RID: 8291
	private global::System.Windows.Forms.CheckBox kk;

	// Token: 0x04002064 RID: 8292
	private global::System.Windows.Forms.Label gr;

	// Token: 0x04002065 RID: 8293
	private global::System.Windows.Forms.Panel panelUser;

	// Token: 0x04002066 RID: 8294
	private global::System.Windows.Forms.Label fd;

	// Token: 0x04002067 RID: 8295
	private global::Class533 txtConfirmPass;

	// Token: 0x04002068 RID: 8296
	private global::Class533 txtRegPass;

	// Token: 0x04002069 RID: 8297
	private global::Class533 txtRegUser;

	// Token: 0x0400206A RID: 8298
	private global::Class533 txtLoginPass;

	// Token: 0x0400206B RID: 8299
	private global::Class533 txtLoginUser;

	// Token: 0x0400206C RID: 8300
	private global::System.Windows.Forms.Label label4;

	// Token: 0x0400206D RID: 8301
	private global::System.Windows.Forms.Timer timer_0;
}
