using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x020002CB RID: 715
internal partial class MessBox : UserControl
{
	// Token: 0x060023F4 RID: 9204 RVA: 0x0001867D File Offset: 0x0001687D
	public MessBox()
	{
		this.InitializeComponent();
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x0001868B File Offset: 0x0001688B
	public MessBox(string string_0)
	{
		this.InitializeComponent();
		this.textBox1.Text = string_0;
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000186A5 File Offset: 0x000168A5
	// (set) Token: 0x060023F7 RID: 9207 RVA: 0x000186AC File Offset: 0x000168AC
	public static bool Boolean_0 { get; set; }

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000186B4 File Offset: 0x000168B4
	// (set) Token: 0x060023F9 RID: 9209 RVA: 0x000186BB File Offset: 0x000168BB
	public static MessBox MessBox_0 { get; set; }

	// Token: 0x1700069D RID: 1693
	// (set) Token: 0x060023FA RID: 9210 RVA: 0x000186C3 File Offset: 0x000168C3
	public string String_0
	{
		set
		{
			this.textBox1.Text = value;
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x060023FB RID: 9211 RVA: 0x000186D1 File Offset: 0x000168D1
	// (set) Token: 0x060023FC RID: 9212 RVA: 0x000186D9 File Offset: 0x000168D9
	public EventHandler EventHandler_0 { get; set; }

	// Token: 0x060023FD RID: 9213 RVA: 0x001105A0 File Offset: 0x0010E7A0
	public static MessBox smethod_0(string string_0)
	{
		MessBox.Class499 @class = new MessBox.Class499();
		@class.string_0 = string_0;
		GUI.GUI_0.Invoke(new Action(@class.method_0));
		return MessBox.MessBox_0;
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000186E2 File Offset: 0x000168E2
	private void MessBox_Load(object sender, EventArgs e)
	{
		this.textBox1.BackColor = Color.FromArgb(15, 157, 88);
		this.textBox1.ForeColor = Color.White;
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x0001870D File Offset: 0x0001690D
	private void button1_Click(object sender, EventArgs e)
	{
		if (this.EventHandler_0 != null)
		{
			this.EventHandler_0(this, null);
		}
		base.Dispose();
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x0001872A File Offset: 0x0001692A
	private void button2_Click(object sender, EventArgs e)
	{
		base.Dispose();
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x0000500B File Offset: 0x0000320B
	private void MessBox_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	// Token: 0x040018D2 RID: 6354
	[CompilerGenerated]
	private static bool bool_0;

	// Token: 0x040018D3 RID: 6355
	[CompilerGenerated]
	private static MessBox messBox_0;

	// Token: 0x040018D4 RID: 6356
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x020002CC RID: 716
	[CompilerGenerated]
	private sealed class Class499
	{
		// Token: 0x06002405 RID: 9221 RVA: 0x00018751 File Offset: 0x00016951
		internal void method_0()
		{
			MessBox.MessBox_0 = new MessBox
			{
				Dock = DockStyle.Fill,
				String_0 = this.string_0
			};
			MessBox.MessBox_0.Parent = GUI.GUI_0;
			MessBox.MessBox_0.BringToFront();
		}

		// Token: 0x040018D9 RID: 6361
		public string string_0;
	}
}
