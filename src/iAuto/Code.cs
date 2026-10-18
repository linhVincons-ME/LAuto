using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x0200019B RID: 411
internal partial class Code : Form
{
	// Token: 0x06001760 RID: 5984 RVA: 0x0001032C File Offset: 0x0000E52C
	public Code(Class106 class106_1)
	{
		this.class106_0 = class106_1;
		this.InitializeComponent();
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x000C29BC File Offset: 0x000C0BBC
	private void btnCode_Click(object sender, EventArgs e)
	{
		string[] array = this.txtCode.Text.Split(new char[] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length > 5)
			{
				ListViewItem listViewItem = new ListViewItem(text);
				listViewItem.SubItems.Add("wait");
				this.listViewCode.Items.Add(listViewItem);
			}
		}
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00010341 File Offset: 0x0000E541
	private void Code_Load(object sender, EventArgs e)
	{
		base.Icon = Class616.Icon_0;
		this.Text = this.class106_0.Class527_0.String_11 + " - Nhập Code";
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x000C2A30 File Offset: 0x000C0C30
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (this.class106_0 == null)
		{
			return;
		}
		foreach (object obj in this.listViewCode.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			string text = listViewItem.Text;
			if (listViewItem.SubItems[1].Text == "wait")
			{
				listViewItem.SubItems[1].Text = "done";
				if (this.class106_0.Class502_0.Int32_5 == 1)
				{
					this.class106_0.method_375("NewUserCard('" + text + "', -1, 0)", false);
					break;
				}
				this.class106_0.method_375("setmetatable(_G, {__index = NewbieCardActivation_Env}); NewUserCard_YDPrize_OpenClick('" + text + "')", false);
				break;
			}
		}
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x0001036E File Offset: 0x0000E56E
	public static string smethod_0()
	{
		return "q0" + Code.smethod_1(16);
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x00010381 File Offset: 0x0000E581
	public static string smethod_1(int int_0)
	{
		return new string(Enumerable.Repeat<string>("qwertyuiopasdfghjklzxcvbnm01234567890012345678900123456789001234567890012345678900123456789001234567890", int_0).Select<string, char>(new Func<string, char>(Code.Class283.f_56B3767C.method_0)).ToArray<char>());
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x000103BC File Offset: 0x0000E5BC
	private void numericUpDown2_ValueChanged(object sender, EventArgs e)
	{
		this.timer_0.Interval = 1000 * (int)this.numericUpDown2.Value;
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x000103DF File Offset: 0x0000E5DF
	private void button1_Click(object sender, EventArgs e)
	{
		base.Parent.Dispose();
		base.Dispose();
	}

	// Token: 0x04000ED0 RID: 3792
	private static readonly Random random_0 = new Random();

	// Token: 0x04000ED1 RID: 3793
	private readonly Class106 class106_0;

	// Token: 0x0200019C RID: 412
	[CompilerGenerated]
	[Serializable]
	private sealed class Class283
	{
		// Token: 0x0600176D RID: 5997 RVA: 0x00010429 File Offset: 0x0000E629
		internal char method_0(string string_0)
		{
			return string_0[Code.random_0.Next(string_0.Length)];
		}

		// Token: 0x04000EDF RID: 3807
		public static readonly Code.Class283 f_56B3767C = new Code.Class283();

		// Token: 0x04000EE0 RID: 3808
		public static Func<string, char> f_0E6F2D77;
	}
}
