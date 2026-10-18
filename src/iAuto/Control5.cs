using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000244 RID: 580
[ToolboxItem(false)]
internal class Control5 : UserControl
{
	// Token: 0x06001F6C RID: 8044 RVA: 0x000151E8 File Offset: 0x000133E8
	public Control5()
	{
		base.SetStyle(ControlStyles.Selectable, false);
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00015208 File Offset: 0x00013408
	// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00015210 File Offset: 0x00013410
	public Color Color_0 { get; set; }

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00015219 File Offset: 0x00013419
	// (set) Token: 0x06001F70 RID: 8048 RVA: 0x00015221 File Offset: 0x00013421
	public Color Color_1 { get; set; }

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0001522A File Offset: 0x0001342A
	// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00015232 File Offset: 0x00013432
	public string String_0 { get; set; }

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0001523B File Offset: 0x0001343B
	// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00015243 File Offset: 0x00013443
	public StringAlignment StringAlignment_0 { get; set; }

	// Token: 0x06001F75 RID: 8053 RVA: 0x000E8AC0 File Offset: 0x000E6CC0
	protected override void OnPaint(PaintEventArgs e)
	{
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, this.Color_0, this.BackColor, 90f))
		{
			e.Graphics.FillRectangle(linearGradientBrush, 0, 0, base.ClientSize.Width - 1, base.ClientSize.Height - 1);
		}
		using (Pen pen = new Pen(this.Color_1))
		{
			e.Graphics.DrawRectangle(pen, 0, 0, base.ClientSize.Width - 1, base.ClientSize.Height - 1);
		}
		if (!string.IsNullOrEmpty(this.String_0))
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = this.StringAlignment_0;
			stringFormat.LineAlignment = StringAlignment.Center;
			using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
			{
				e.Graphics.DrawString(this.String_0, this.Font, solidBrush, new RectangleF(1f, 1f, (float)(base.ClientSize.Width - 2), (float)(base.ClientSize.Height - 2)), stringFormat);
			}
		}
	}

	// Token: 0x040013D1 RID: 5073
	[CompilerGenerated]
	private Color color_0;

	// Token: 0x040013D2 RID: 5074
	[CompilerGenerated]
	private Color color_1;

	// Token: 0x040013D3 RID: 5075
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040013D4 RID: 5076
	[CompilerGenerated]
	private StringAlignment stringAlignment_0;
}
