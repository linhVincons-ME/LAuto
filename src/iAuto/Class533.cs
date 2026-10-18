using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x020002F4 RID: 756
internal class Class533 : TextBox
{
	// Token: 0x06002A23 RID: 10787 RVA: 0x0001C724 File Offset: 0x0001A924
	public Class533()
	{
		this.method_2();
		base.KeyDown += this.Class533_KeyDown;
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x0012DF20 File Offset: 0x0012C120
	public void method_0(string string_1)
	{
		string_1 = string_1.smethod_36();
		base.SelectionStart = 0;
		int num = 0;
		foreach (string text in base.Lines)
		{
			if (text.smethod_36().Contains(string_1))
			{
				base.SelectionStart = num;
				this.SelectionLength = text.Length;
				base.ScrollToCaret();
				return;
			}
			num += text.Length;
		}
		base.ScrollToCaret();
	}

	// Token: 0x06002A25 RID: 10789 RVA: 0x0012DF90 File Offset: 0x0012C190
	private void Class533_KeyDown(object sender, KeyEventArgs e)
	{
		TextBox textBox = sender as TextBox;
		if (e.Control && e.KeyCode == Keys.A)
		{
			textBox.SelectAll();
		}
	}

	// Token: 0x06002A26 RID: 10790 RVA: 0x0001C74F File Offset: 0x0001A94F
	public void method_1()
	{
		base.SelectionStart = this.TextLength;
		base.ScrollToCaret();
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x0012DFBC File Offset: 0x0012C1BC
	private void method_2()
	{
		this.BackColor = Color.FromArgb(15, 23, 42);
		this.ForeColor = Color.FromArgb(241, 245, 249);
		this.color_0 = Color.FromArgb(148, 163, 184);
		this.color_1 = Color.FromArgb(226, 232, 240);
		this.font_0 = this.Font;
		this.solidBrush_0 = new SolidBrush(this.color_1);
		this.panel_0 = null;
		this.method_4();
		base.Enter += this.Class533_Enter;
		base.Leave += this.Class533_Leave;
		base.TextChanged += this.Class533_TextChanged;
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x0001C763 File Offset: 0x0001A963
	private void method_3()
	{
		if (this.panel_0 != null)
		{
			base.Controls.Remove(this.panel_0);
			this.panel_0 = null;
		}
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x0012E040 File Offset: 0x0012C240
	private void method_4()
	{
		if (this.panel_0 == null && this.TextLength <= 0)
		{
			this.panel_0 = new Panel();
			this.panel_0.BackColor = this.BackColor;
			this.panel_0.Paint += this.panel_0_Paint;
			this.panel_0.Invalidate();
			this.panel_0.Click += this.panel_0_Click;
			base.Controls.Add(this.panel_0);
		}
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x0001C785 File Offset: 0x0001A985
	private void panel_0_Click(object sender, EventArgs e)
	{
		base.Focus();
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x0012E0B4 File Offset: 0x0012C2B4
	private void panel_0_Paint(object sender, PaintEventArgs e)
	{
		this.panel_0.Location = new Point(2, 0);
		this.panel_0.Height = base.Height;
		this.panel_0.Width = base.Width;
		this.panel_0.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		if (base.ContainsFocus)
		{
			this.solidBrush_0 = new SolidBrush(this.color_1);
		}
		else
		{
			this.solidBrush_0 = new SolidBrush(this.color_0);
		}
		e.Graphics.DrawString(this.string_0, this.font_0, this.solidBrush_0, new PointF(-2f, 1f));
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x0001C78E File Offset: 0x0001A98E
	private void Class533_Enter(object sender, EventArgs e)
	{
		this.solidBrush_0 = new SolidBrush(this.color_1);
		if (this.TextLength <= 0)
		{
			this.method_3();
			this.method_4();
		}
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x0001C7B6 File Offset: 0x0001A9B6
	private void Class533_Leave(object sender, EventArgs e)
	{
		if (this.TextLength > 0)
		{
			this.method_3();
			return;
		}
		base.Invalidate();
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x0001C7CE File Offset: 0x0001A9CE
	private void Class533_TextChanged(object sender, EventArgs e)
	{
		if (this.TextLength > 0)
		{
			this.method_3();
			return;
		}
		this.method_4();
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x0001C7E6 File Offset: 0x0001A9E6
	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		this.method_4();
	}

	// Token: 0x06002A30 RID: 10800 RVA: 0x0001C7F5 File Offset: 0x0001A9F5
	protected override void OnInvalidated(InvalidateEventArgs e)
	{
		base.OnInvalidated(e);
		if (this.panel_0 != null)
		{
			this.panel_0.Invalidate();
		}
	}

	// Token: 0x170009B9 RID: 2489
	// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0001C811 File Offset: 0x0001AA11
	// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0001C819 File Offset: 0x0001AA19
	[Description("Sets the text of the watermark")]
	[Category("Watermark attribtues")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x06002A33 RID: 10803 RVA: 0x0001C828 File Offset: 0x0001AA28
	// (set) Token: 0x06002A34 RID: 10804 RVA: 0x0001C830 File Offset: 0x0001AA30
	[Description("When the control gaines focus, this color will be used as the watermark's forecolor")]
	[Category("Watermark attribtues")]
	public Color Color_0
	{
		get
		{
			return this.color_1;
		}
		set
		{
			this.color_1 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170009BB RID: 2491
	// (get) Token: 0x06002A35 RID: 10805 RVA: 0x0001C83F File Offset: 0x0001AA3F
	// (set) Token: 0x06002A36 RID: 10806 RVA: 0x0001C847 File Offset: 0x0001AA47
	[Category("Watermark attribtues")]
	[Description("When the control looses focus, this color will be used as the watermark's forecolor")]
	public Color Color_1
	{
		get
		{
			return this.color_0;
		}
		set
		{
			this.color_0 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170009BC RID: 2492
	// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0001C856 File Offset: 0x0001AA56
	// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0001C85E File Offset: 0x0001AA5E
	[Description("The font used on the watermark. Default is the same as the control")]
	[Category("Watermark attribtues")]
	public Font Font_0
	{
		get
		{
			return this.font_0;
		}
		set
		{
			this.font_0 = value;
			base.Invalidate();
		}
	}

	// Token: 0x04001D50 RID: 7504
	protected string string_0 = "Default Watermark...";

	// Token: 0x04001D51 RID: 7505
	protected Color color_0;

	// Token: 0x04001D52 RID: 7506
	protected Color color_1;

	// Token: 0x04001D53 RID: 7507
	private Panel panel_0;

	// Token: 0x04001D54 RID: 7508
	private Font font_0;

	// Token: 0x04001D55 RID: 7509
	private SolidBrush solidBrush_0;
}
