using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000230 RID: 560
internal class Control4 : UserControl
{
	// Token: 0x06001E81 RID: 7809 RVA: 0x000E5090 File Offset: 0x000E3290
	public Control4()
	{
		this.method_2();
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.MinimumSize = new Size(0, 24);
		this.MaximumSize = new Size(1073741823, 24);
		this.Color_0 = SystemColors.ControlLight;
		this.Color_1 = Color.DarkGray;
		this.Color_2 = Color.Black;
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06001E82 RID: 7810 RVA: 0x000149BA File Offset: 0x00012BBA
	// (set) Token: 0x06001E83 RID: 7811 RVA: 0x000149C2 File Offset: 0x00012BC2
	[DefaultValue(typeof(Color), "ControlLight")]
	public Color Color_0 { get; set; }

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000149CB File Offset: 0x00012BCB
	// (set) Token: 0x06001E85 RID: 7813 RVA: 0x000149D3 File Offset: 0x00012BD3
	[DefaultValue(typeof(Color), "DarkGray")]
	public Color Color_1 { get; set; }

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000149DC File Offset: 0x00012BDC
	// (set) Token: 0x06001E87 RID: 7815 RVA: 0x000149E4 File Offset: 0x00012BE4
	[DefaultValue(typeof(Color), "Black")]
	public Color Color_2 { get; set; }

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000149ED File Offset: 0x00012BED
	// (set) Token: 0x06001E89 RID: 7817 RVA: 0x000149F5 File Offset: 0x00012BF5
	[Description("Target FastColoredTextBox")]
	public Control3 Control3_0
	{
		get
		{
			return this.control3_0;
		}
		set
		{
			if (this.control3_0 != null)
			{
				this.vmethod_1(this.control3_0);
			}
			this.control3_0 = value;
			this.vmethod_2(this.control3_0);
			this.vmethod_0();
		}
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x00014A24 File Offset: 0x00012C24
	protected virtual void vmethod_0()
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x00014A3F File Offset: 0x00012C3F
	protected virtual void vmethod_1(Control3 control3_1)
	{
		control3_1.Scroll -= this.vmethod_3;
		control3_1.Event_6 -= this.method_1;
		control3_1.Event_7 -= this.method_0;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00014A78 File Offset: 0x00012C78
	protected virtual void vmethod_2(Control3 control3_1)
	{
		control3_1.Scroll += this.vmethod_3;
		control3_1.Event_6 += this.method_1;
		control3_1.Event_7 += this.method_0;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00014AB1 File Offset: 0x00012CB1
	private void method_0(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x00014AB1 File Offset: 0x00012CB1
	private void method_1(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x00014AB1 File Offset: 0x00012CB1
	protected virtual void vmethod_3(object sender, ScrollEventArgs e)
	{
		base.Invalidate();
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x00014AB9 File Offset: 0x00012CB9
	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Invalidate();
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000E50F8 File Offset: 0x000E32F8
	protected override void OnPaint(PaintEventArgs e)
	{
		if (this.control3_0 == null)
		{
			return;
		}
		Point point = base.PointToClient(this.control3_0.PointToScreen(this.control3_0.method_93(this.control3_0.Class357_5.GStruct19_0)));
		Size size = TextRenderer.MeasureText("W", this.Font);
		int num = 0;
		e.Graphics.FillRectangle(new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), this.BackColor, this.Color_0, 270f), new Rectangle(0, 0, base.Width, base.Height));
		float num2 = (float)this.control3_0.Int32_4;
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Near;
		Point point2 = this.control3_0.method_92(0);
		point2 = base.PointToClient(this.control3_0.PointToScreen(point2));
		using (Pen pen = new Pen(this.Color_1))
		{
			using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
			{
				float num3 = (float)point2.X;
				while (num3 < (float)base.Right)
				{
					if (num % 10 == 0)
					{
						e.Graphics.DrawString(num.ToString(), this.Font, solidBrush, num3, 0f, stringFormat);
					}
					e.Graphics.DrawLine(pen, (int)num3, size.Height + ((num % 5 == 0) ? 1 : 3), (int)num3, base.Height - 4);
					num3 += num2;
					num++;
				}
			}
		}
		using (Pen pen2 = new Pen(this.Color_1))
		{
			e.Graphics.DrawLine(pen2, new Point(point.X - 3, base.Height - 3), new Point(point.X + 3, base.Height - 3));
		}
		using (Pen pen3 = new Pen(this.Color_2))
		{
			e.Graphics.DrawLine(pen3, new Point(point.X - 2, size.Height + 3), new Point(point.X - 2, base.Height - 4));
			e.Graphics.DrawLine(pen3, new Point(point.X, size.Height + 1), new Point(point.X, base.Height - 4));
			e.Graphics.DrawLine(pen3, new Point(point.X + 2, size.Height + 3), new Point(point.X + 2, base.Height - 4));
		}
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x00014AC8 File Offset: 0x00012CC8
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x00014AE7 File Offset: 0x00012CE7
	private void method_2()
	{
		this.icontainer_0 = new Container();
		base.AutoScaleMode = AutoScaleMode.Font;
	}

	// Token: 0x04001327 RID: 4903
	private Control3 control3_0;

	// Token: 0x04001328 RID: 4904
	public EventHandler eventHandler_0;

	// Token: 0x04001329 RID: 4905
	[CompilerGenerated]
	private Color color_0;

	// Token: 0x0400132A RID: 4906
	[CompilerGenerated]
	private Color color_1;

	// Token: 0x0400132B RID: 4907
	[CompilerGenerated]
	private Color color_2;

	// Token: 0x0400132C RID: 4908
	private IContainer icontainer_0;
}
