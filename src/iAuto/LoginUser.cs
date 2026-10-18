using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using _i.Properties;

// Token: 0x0200017E RID: 382
internal partial class LoginUser : UserControl
{
	// Token: 0x0600167E RID: 5758 RVA: 0x000B315C File Offset: 0x000B135C
	public LoginUser()
	{
		this.InitializeComponent();
		base.Load += this.LoginUser_Load;
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x0600167F RID: 5759 RVA: 0x0000FC13 File Offset: 0x0000DE13
	// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000FC1B File Offset: 0x0000DE1B
	public string String_0 { get; set; }

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001681 RID: 5761 RVA: 0x0000FC24 File Offset: 0x0000DE24
	// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000FC2C File Offset: 0x0000DE2C
	public string String_1 { get; set; }

	// Token: 0x06001683 RID: 5763 RVA: 0x0000500B File Offset: 0x0000320B
	private void LoginUser_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x000B31AC File Offset: 0x000B13AC
	private void btnRegisterLogin_Click(object sender, EventArgs e)
	{
		base.Enabled = false;
		if (this.textRegPass.Text != this.textRetypePass.Text)
		{
			base.Enabled = true;
			MessBox.smethod_0("Mật khẩu nhập lại không khớp");
			return;
		}
		new Thread(new ThreadStart(this.method_3)).Start();
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x0000FC35 File Offset: 0x0000DE35
	private void btnLogin_Click(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x0000FC3D File Offset: 0x0000DE3D
	private void method_0()
	{
		base.Enabled = false;
		Task.Run(new Action(this.method_6));
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x000B3208 File Offset: 0x000B1408
	public static string smethod_0(string string_3, string string_4)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_3);
		httpWebRequest.Method = "GET";
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.UserAgent = string_4;
		httpWebRequest.Proxy = null;
		httpWebRequest.ServicePoint.Expect100Continue = false;
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		httpWebResponse.Close();
		return text;
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x000B327C File Offset: 0x000B147C
	private void method_1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "mật khẩu là chìa khóa quan trọng để giải mã dữ liệu được lưu\r\nchính admin cũng không biết mật khẩu của bạn\r\nbạn vui lòng nhớ kỹ thông tin đăng nhập \r\ntrong trường hợp bạn quên mật khẩu\r\nadmin chỉ có thể phục hồi lại được danh sách tên tài khoản\r\ncòn mật khẩu của tài khoản lưu trong dữ liệu bị mã hóa\r\nkhông thể giải mã nếu không có mật khẩu gốc";
		MessageBox.Show(this, text, "MicroAuto", MessageBoxButtons.OK);
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x0000500B File Offset: 0x0000320B
	private void LoginUser_Load_1(object sender, EventArgs e)
	{
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x0000FC58 File Offset: 0x0000DE58
	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkBox1.Checked)
		{
			this.textLoginPass.PasswordChar = '\0';
			return;
		}
		this.textLoginPass.PasswordChar = '*';
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0000500B File Offset: 0x0000320B
	private void LoginUser_Resize(object sender, EventArgs e)
	{
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0000FC81 File Offset: 0x0000DE81
	private void textLoginEmail_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.btnLogin_Click(null, null);
		}
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x000B32A0 File Offset: 0x000B14A0
	private void button1_Click(object sender, EventArgs e)
	{
		Control6 tabLogin = GUI.GUI_0.tabLogin;
		TabPage tabPage = new TabPage("#");
		tabLogin.TabPages.Add(tabPage);
		string text = Class531.smethod_10(2).ToUpper();
		for (int i = 0; i < 1000; i++)
		{
			text = "#" + i.ToString();
			if (!File.Exists(GUI.String_1 + "/" + text + ".xml"))
			{
				LoginUser.Class263 @class = new LoginUser.Class263();
				File.Create(GUI.String_1 + "/" + text + ".xml");
				@class.tabLogin_0 = new TabLogin
				{
					Dock = DockStyle.Fill,
					String_2 = text
				};
				tabPage.Text = text;
				tabPage.Controls.Add(@class.tabLogin_0);
				Task.Run(new Action(@class.method_0));
				IL_00D6:
				tabLogin.SelectedIndex = tabLogin.TabPages.Count - 1;
				return;
			}
		}
		{
			tabLogin.SelectedIndex = tabLogin.TabPages.Count - 1;
			return;
		}
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x000B3398 File Offset: 0x000B1598
	private void comboBox2_DropDown(object sender, EventArgs e)
	{
		this.comboBox2.Items.Clear();
		foreach (ValueTuple<string, string> valueTuple in Class106.Class210_0["iLogin"])
		{
			this.comboBox2.Items.Add(valueTuple.Item1);
		}
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x000B3410 File Offset: 0x000B1610
	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = Class106.Class210_0["iLogin", this.comboBox2.Text];
		string text2 = this.comboBox2.Text;
		this.textLoginEmail.Text = text2;
		this.textLoginPass.Text = text;
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x000B3E6C File Offset: 0x000B206C
	[CompilerGenerated]
	private void method_3()
	{
		try
		{
			Thread.CurrentThread.IsBackground = true;
			string text = LoginUser.smethod_0(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?cmd=regilogin&u=",
				HttpUtility.UrlEncode(this.textRegMail.Text),
				"&p=",
				HttpUtility.UrlEncode(this.textRegPass.Text),
				"&iid=",
				HttpUtility.UrlEncode(GUI.string_1),
				"&email=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_2),
				"&pass=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_3)
			}), "iMicroLogin" + this.string_0);
			base.Invoke(new Action(this.method_4));
			MessBox.smethod_0(text);
		}
		catch (Exception ex)
		{
			base.Invoke(new Action(this.method_5));
			MessBox.smethod_0(ex.ToString());
		}
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_4()
	{
		base.Enabled = true;
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_5()
	{
		base.Enabled = true;
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x000B3F80 File Offset: 0x000B2180
	[CompilerGenerated]
	private void method_6()
	{
		LoginUser.Class262 @class = new LoginUser.Class262();
		@class.loginUser_0 = this;
		@class.string_0 = string.Empty;
		try
		{
			this.String_0 = this.textLoginPass.Text;
			this.String_1 = this.textLoginEmail.Text;
			string text = "&email=" + HttpUtility.UrlEncode(this.textLoginEmail.Text) + "&pass=" + HttpUtility.UrlEncode(Class529.smethod_1(this.textLoginPass.Text));
			@class.string_0 = LoginUser.smethod_0(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?cmd=loginilogin&u=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_2),
				"&p=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_3),
				"&iid=",
				HttpUtility.UrlEncode(GUI.string_1),
				text
			}), "iMicroLogin" + this.string_0);
			if (@class.string_0 == "sai email hoặc mật khẩu")
			{
				base.Invoke(new Action(this.method_7));
				MessBox.smethod_0(@class.string_0);
			}
			else
			{
				base.Invoke(new Action(@class.method_0));
			}
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

	// Token: 0x06001698 RID: 5784 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
	[CompilerGenerated]
	private void method_7()
	{
		base.Enabled = true;
	}

	// Token: 0x04000DA5 RID: 3493
	public static List<string> list_0 = new List<string>();

	// Token: 0x04000DA6 RID: 3494
	private readonly string string_0 = Class529.smethod_1(Process.GetCurrentProcess().MainModule.FileName);

	// Token: 0x04000DA7 RID: 3495
	public XmlDocument xmlDocument_0 = new XmlDocument();

	// Token: 0x04000DA8 RID: 3496
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04000DA9 RID: 3497
	[CompilerGenerated]
	private string string_2;

	// Token: 0x0200017F RID: 383
	[CompilerGenerated]
	private sealed class Class262
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x000B4110 File Offset: 0x000B2310
		internal void method_0()
		{
			Control6 control = (Control6)this.loginUser_0.Parent.Parent;
			TabPage tabPage = new TabPage("#");
			control.TabPages.Add(tabPage);
			string text = string.Empty;
			for (int i = 0; i < 1000; i++)
			{
				text = "#" + i.ToString();
				if (!File.Exists(GUI.String_1 + "/" + text + ".xml"))
				{
					File.Create(GUI.String_1 + "/" + text + ".xml");
					IL_0092:
					TabLogin tabLogin = new TabLogin
					{
						Dock = DockStyle.Fill,
						String_2 = text
					};
					tabLogin.String_1 = this.loginUser_0.String_1;
					tabPage.Controls.Add(tabLogin);
					tabPage.Text = text;
					tabLogin.Boolean_6 = true;
					tabLogin.method_0(this.string_0, this.loginUser_0.textLoginPass.Text);
					Class106.Class210_0["iLogin", this.loginUser_0.textLoginEmail.Text] = this.loginUser_0.textLoginPass.Text;
					control.SelectedIndex = control.TabPages.Count - 1;
					return;
				}
			}
			{
				TabLogin tabLogin = new TabLogin
				{
					Dock = DockStyle.Fill,
					String_2 = text
				};
				tabLogin.String_1 = this.loginUser_0.String_1;
				tabPage.Controls.Add(tabLogin);
				tabPage.Text = text;
				tabLogin.Boolean_6 = true;
				tabLogin.method_0(this.string_0, this.loginUser_0.textLoginPass.Text);
				Class106.Class210_0["iLogin", this.loginUser_0.textLoginEmail.Text] = this.loginUser_0.textLoginPass.Text;
				control.SelectedIndex = control.TabPages.Count - 1;
				return;
			}
		}

		// Token: 0x04000DB8 RID: 3512
		public string string_0;

		// Token: 0x04000DB9 RID: 3513
		public LoginUser loginUser_0;
	}

	// Token: 0x02000180 RID: 384
	[CompilerGenerated]
	private sealed class Class263
	{
		// Token: 0x0600169C RID: 5788 RVA: 0x0000FCC9 File Offset: 0x0000DEC9
		internal void method_0()
		{
			this.tabLogin_0.method_0(null, null);
		}

		// Token: 0x04000DBA RID: 3514
		public TabLogin tabLogin_0;
	}
}
