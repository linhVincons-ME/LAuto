using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using _i.Properties;

// Token: 0x0200034C RID: 844
internal partial class LoginiAuto : UserControl
{
	// Token: 0x06002C11 RID: 11281 RVA: 0x0013EC6C File Offset: 0x0013CE6C
	public LoginiAuto()
	{
		this.InitializeComponent();
		this.timer_0.Start();
		this.txtLoginUser.Text = Class106.Class210_0["Settings", "User"];
		this.txtLoginPass.Text = Class106.Class210_0["Settings", "Pass"];
		this.int_0 = 1;
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x0001D534 File Offset: 0x0001B734
	private void btnReg_Click(object sender, EventArgs e)
	{
		Task.Run(new Action(this.method_0));
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x0001D548 File Offset: 0x0001B748
	private void btnLogin_Click(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.timer_0.Dispose();
		this.label4.Dispose();
		Task.Run(new Action(this.method_1));
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x0001D57D File Offset: 0x0001B77D
	private void LoginiAuto_Load(object sender, EventArgs e)
	{
		if (GUI.Boolean_3)
		{
			this.timer_0.Stop();
			this.timer_0.Dispose();
			this.label4.Dispose();
		}
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x0001D5A7 File Offset: 0x0001B7A7
	private void txtLoginUser_TextChanged(object sender, EventArgs e)
	{
		Class106.Class210_0["Settings", "User"] = this.txtLoginUser.Text;
		this.int_0 = 60;
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x0001D5D0 File Offset: 0x0001B7D0
	private void txtLoginPass_TextChanged(object sender, EventArgs e)
	{
		Class106.Class210_0["Settings", "Pass"] = this.txtLoginPass.Text;
		this.int_0 = 60;
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x0001D5F9 File Offset: 0x0001B7F9
	private void txtLoginUser_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.txtLoginPass.Select();
		}
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x0001D610 File Offset: 0x0001B810
	private void txtLoginPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.btnLogin_Click(null, null);
		}
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x0001D624 File Offset: 0x0001B824
	private void kk_CheckedChanged(object sender, EventArgs e)
	{
		this.txtLoginPass.PasswordChar = (this.kk.Checked ? '\0' : '*');
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x0013ECDC File Offset: 0x0013CEDC
	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		this.txtRegPass.PasswordChar = (this.txtConfirmPass.PasswordChar = (this.checkBox1.Checked ? '\0' : '*'));
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x0013ED14 File Offset: 0x0013CF14
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Class106.Class210_0["Settings", "User"]))
		{
			int num = this.int_0;
			this.int_0 = num - 1;
			int num2 = num;
			if (num2 <= 0)
			{
				this.label4.Text = "Auto Login";
				this.btnLogin_Click(null, null);
				this.timer_0.Stop();
				return;
			}
			this.label4.Text = string.Format("Auto Login After {0} sec", num2);
		}
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x0000500B File Offset: 0x0000320B
	private void panel3_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x00140064 File Offset: 0x0013E264
	[CompilerGenerated]
	private void method_0()
	{
		try
		{
			base.Enabled = false;
			string text = Class106.smethod_2(string.Concat(new string[]
			{
				"cmd=reg&email=",
				HttpUtility.UrlEncode(this.txtRegUser.Text),
				"&pass=",
				HttpUtility.UrlEncode(this.txtRegPass.Text),
				"&repass=",
				HttpUtility.UrlEncode(this.txtConfirmPass.Text),
				"&hwid=",
				GUI.string_1,
				"&ran=",
				Class531.smethod_10(6)
			}), Settings.Default.PublicKey);
			MessBox.smethod_0(Class106.smethod_1(Class106.smethod_0(Settings.Default.HomePage ?? "", text, null, false)));
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
		finally
		{
			base.Enabled = true;
		}
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x00140160 File Offset: 0x0013E360
	[CompilerGenerated]
	private void method_1()
	{
		try
		{
			if (GUI.string_1 == null)
			{
				GUI.string_1 = GClass31.smethod_0();
			}
			GUI.GUI_0.txtHWID.Text = GUI.string_1;
		}
		catch
		{
		}
		for (;;)
		{
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				base.Enabled = false;
				string text = Class106.smethod_0(string.Concat(new string[]
				{
					Settings.Default.HomePage,
					"?cmd=login&email=",
					HttpUtility.UrlEncode(Class106.Class210_0["Settings", "User"]),
					"&pass=",
					HttpUtility.UrlEncode(Class106.Class210_0["Settings", "Pass"]),
					"&hwid=",
					GUI.string_1,
					"&ran=",
					Class531.smethod_10(6),
					"&version=",
					HttpUtility.UrlEncode(Settings.Default.Version)
				}), null, null, false);
				if (text.Contains("success"))
				{
					GUI.GUI_0.String_2 = Class106.Class210_0["Settings", "User"];
					GUI.GUI_0.String_3 = Class106.Class210_0["Settings", "Pass"];
					GUI.GUI_0.method_5();
					base.Invoke(new Action(this.method_2));
				}
				else
				{
					base.Invoke(new Action(this.method_3));
					MessBox.smethod_0(text);
				}
				return;
			}
			catch
			{
			}
			Thread.Sleep(100);
		}
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x0001872A File Offset: 0x0001692A
	[CompilerGenerated]
	private void method_2()
	{
		base.Dispose();
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_3()
	{
		base.Enabled = true;
	}

	// Token: 0x04002054 RID: 8276
	private int int_0 = 1;
}
