// Token: 0x0200017E RID: 382
internal partial class LoginUser : global::System.Windows.Forms.UserControl
{
	// Token: 0x06001691 RID: 5777 RVA: 0x0000FC95 File Offset: 0x0000DE95
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x000B345C File Offset: 0x000B165C
	private void InitializeComponent()
	{
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.textLoginPass = new global::Class533();
		this.checkBox1 = new global::System.Windows.Forms.CheckBox();
		this.textLoginEmail = new global::Class533();
		this.btnLogin = new global::System.Windows.Forms.Button();
		this.comboBox2 = new global::System.Windows.Forms.ComboBox();
		this.textRetypePass = new global::Class533();
		this.textRegPass = new global::Class533();
		this.textRegMail = new global::Class533();
		this.btnRegisterLogin = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.groupBox3 = new global::System.Windows.Forms.GroupBox();
		this.groupBox4 = new global::System.Windows.Forms.GroupBox();
		this.panel1.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox4.SuspendLayout();
		base.SuspendLayout();
		this.panel1.Controls.Add(this.textLoginPass);
		this.panel1.Controls.Add(this.checkBox1);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new global::System.Drawing.Point(3, 57);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(560, 20);
		this.panel1.TabIndex = 66;
		this.textLoginPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.textLoginPass.Location = new global::System.Drawing.Point(0, 0);
		this.textLoginPass.Name = "textLoginPass";
		this.textLoginPass.PasswordChar = '*';
		this.textLoginPass.Size = new global::System.Drawing.Size(545, 20);
		this.textLoginPass.TabIndex = 3;
		this.textLoginPass.String_0 = "Password";
		this.textLoginPass.Color_0 = global::System.Drawing.Color.Gray;
		this.textLoginPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textLoginPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.textLoginPass.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textLoginEmail_KeyDown);
		this.checkBox1.AutoSize = true;
		this.checkBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkBox1.Location = new global::System.Drawing.Point(545, 0);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new global::System.Drawing.Size(15, 20);
		this.checkBox1.TabIndex = 6;
		this.checkBox1.TabStop = false;
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
		this.textLoginEmail.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.textLoginEmail.Location = new global::System.Drawing.Point(3, 37);
		this.textLoginEmail.Name = "textLoginEmail";
		this.textLoginEmail.Size = new global::System.Drawing.Size(560, 20);
		this.textLoginEmail.TabIndex = 2;
		this.textLoginEmail.String_0 = "User";
		this.textLoginEmail.Color_0 = global::System.Drawing.Color.Gray;
		this.textLoginEmail.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textLoginEmail.Color_1 = global::System.Drawing.Color.LightGray;
		this.textLoginEmail.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textLoginEmail_KeyDown);
		this.btnLogin.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnLogin.Location = new global::System.Drawing.Point(3, 77);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new global::System.Drawing.Size(560, 23);
		this.btnLogin.TabIndex = 4;
		this.btnLogin.TabStop = false;
		this.btnLogin.Text = "Đăng Nhập";
		this.btnLogin.UseVisualStyleBackColor = true;
		this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
		this.comboBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Location = new global::System.Drawing.Point(3, 16);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new global::System.Drawing.Size(560, 21);
		this.comboBox2.TabIndex = 74;
		this.comboBox2.DropDown += new global::System.EventHandler(this.comboBox2_DropDown);
		this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
		this.textRetypePass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.textRetypePass.Location = new global::System.Drawing.Point(3, 56);
		this.textRetypePass.Name = "textRetypePass";
		this.textRetypePass.PasswordChar = '*';
		this.textRetypePass.Size = new global::System.Drawing.Size(560, 20);
		this.textRetypePass.TabIndex = 12;
		this.textRetypePass.String_0 = "Confirm Password";
		this.textRetypePass.Color_0 = global::System.Drawing.Color.Gray;
		this.textRetypePass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textRetypePass.Color_1 = global::System.Drawing.Color.LightGray;
		this.textRegPass.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.textRegPass.Location = new global::System.Drawing.Point(3, 36);
		this.textRegPass.Name = "textRegPass";
		this.textRegPass.PasswordChar = '*';
		this.textRegPass.Size = new global::System.Drawing.Size(560, 20);
		this.textRegPass.TabIndex = 11;
		this.textRegPass.String_0 = "Password";
		this.textRegPass.Color_0 = global::System.Drawing.Color.Gray;
		this.textRegPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textRegPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.textRegMail.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.textRegMail.Location = new global::System.Drawing.Point(3, 16);
		this.textRegMail.Name = "textRegMail";
		this.textRegMail.Size = new global::System.Drawing.Size(560, 20);
		this.textRegMail.TabIndex = 10;
		this.textRegMail.String_0 = "User";
		this.textRegMail.Color_0 = global::System.Drawing.Color.Gray;
		this.textRegMail.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textRegMail.Color_1 = global::System.Drawing.Color.LightGray;
		this.btnRegisterLogin.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.btnRegisterLogin.Location = new global::System.Drawing.Point(3, 76);
		this.btnRegisterLogin.Name = "btnRegisterLogin";
		this.btnRegisterLogin.Size = new global::System.Drawing.Size(560, 23);
		this.btnRegisterLogin.TabIndex = 13;
		this.btnRegisterLogin.Text = "Đăng Ký";
		this.btnRegisterLogin.UseVisualStyleBackColor = true;
		this.btnRegisterLogin.Click += new global::System.EventHandler(this.btnRegisterLogin_Click);
		this.button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.button1.Location = new global::System.Drawing.Point(0, 387);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(566, 23);
		this.button1.TabIndex = 75;
		this.button1.Text = "+";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.groupBox3.Controls.Add(this.btnLogin);
		this.groupBox3.Controls.Add(this.panel1);
		this.groupBox3.Controls.Add(this.textLoginEmail);
		this.groupBox3.Controls.Add(this.comboBox2);
		this.groupBox3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox3.Location = new global::System.Drawing.Point(0, 0);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new global::System.Drawing.Size(566, 104);
		this.groupBox3.TabIndex = 76;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Login";
		this.groupBox4.Controls.Add(this.btnRegisterLogin);
		this.groupBox4.Controls.Add(this.textRetypePass);
		this.groupBox4.Controls.Add(this.textRegPass);
		this.groupBox4.Controls.Add(this.textRegMail);
		this.groupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox4.Location = new global::System.Drawing.Point(0, 104);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new global::System.Drawing.Size(566, 103);
		this.groupBox4.TabIndex = 77;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Register";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.Controls.Add(this.groupBox4);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.button1);
		base.Name = "LoginUser";
		base.Size = new global::System.Drawing.Size(566, 410);
		base.Load += new global::System.EventHandler(this.LoginUser_Load_1);
		base.Resize += new global::System.EventHandler(this.LoginUser_Resize);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000DAA RID: 3498
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000DAB RID: 3499
	private global::System.Windows.Forms.Button btnRegisterLogin;

	// Token: 0x04000DAC RID: 3500
	private global::System.Windows.Forms.Button btnLogin;

	// Token: 0x04000DAD RID: 3501
	private global::System.Windows.Forms.CheckBox checkBox1;

	// Token: 0x04000DAE RID: 3502
	private global::Class533 textLoginPass;

	// Token: 0x04000DAF RID: 3503
	private global::Class533 textLoginEmail;

	// Token: 0x04000DB0 RID: 3504
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000DB1 RID: 3505
	private global::Class533 textRetypePass;

	// Token: 0x04000DB2 RID: 3506
	private global::Class533 textRegPass;

	// Token: 0x04000DB3 RID: 3507
	private global::Class533 textRegMail;

	// Token: 0x04000DB4 RID: 3508
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000DB5 RID: 3509
	private global::System.Windows.Forms.ComboBox comboBox2;

	// Token: 0x04000DB6 RID: 3510
	private global::System.Windows.Forms.GroupBox groupBox3;

	// Token: 0x04000DB7 RID: 3511
	private global::System.Windows.Forms.GroupBox groupBox4;
}
