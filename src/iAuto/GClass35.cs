using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000178 RID: 376
public class GClass35 : ProgressBar
{
	// Token: 0x0600162D RID: 5677 RVA: 0x0000FA86 File Offset: 0x0000DC86
	public GClass35()
	{
		base.SetStyle(ControlStyles.UserPaint, true);
		base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x0600162E RID: 5678 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
	// (set) Token: 0x0600162F RID: 5679 RVA: 0x0000FABC File Offset: 0x0000DCBC
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Văn bản hiển thị ở giữa thanh tiến trình")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (this.string_0 != value)
			{
				this.string_0 = value;
				base.Invalidate();
			}
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001630 RID: 5680 RVA: 0x0000FAD9 File Offset: 0x0000DCD9
	// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
	public int Int32_0
	{
		get
		{
			return base.Value;
		}
		set
		{
			if (base.Value != value)
			{
				base.Value = value;
				base.Invalidate();
			}
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x000AEF2C File Offset: 0x000AD12C
	protected override void OnPaint(PaintEventArgs e)
	{
		Rectangle clientRectangle = base.ClientRectangle;
		Graphics graphics = e.Graphics;
		ProgressBarRenderer.DrawHorizontalBar(graphics, clientRectangle);
		clientRectangle.Inflate(-3, -3);
		if (this.Int32_0 > 0)
		{
			Rectangle rectangle = new Rectangle(clientRectangle.X, clientRectangle.Y, (int)((double)clientRectangle.Width * ((double)this.Int32_0 / (double)base.Maximum)), clientRectangle.Height);
			graphics.FillRectangle(Brushes.Green, rectangle);
		}
		if (!string.IsNullOrEmpty(this.string_0))
		{
			using (Font font = new Font(FontFamily.GenericSansSerif, 10f))
			{
				SizeF sizeF = graphics.MeasureString(this.string_0, font);
				string text = this.string_0;
				if (sizeF.Width > (float)(clientRectangle.Width - 10))
				{
					int num = this.string_0.Length;
					string text2;
					do
					{
						num--;
						text2 = this.string_0.Substring(0, num) + "...";
						sizeF = graphics.MeasureString(text2, font);
					}
					while (sizeF.Width > (float)(clientRectangle.Width - 10) && num > 0);
					text = text2;
				}
				PointF pointF = new PointF(((float)base.Width - sizeF.Width) / 2f, ((float)base.Height - sizeF.Height) / 2f);
				Color color;
				if (pointF.X + sizeF.Width / 2f < (float)(clientRectangle.X + (int)((double)clientRectangle.Width * ((double)this.Int32_0 / (double)base.Maximum))))
				{
					color = Color.White;
				}
				else
				{
					color = Color.Black;
				}
				TextRenderer.DrawText(graphics, text, font, new Point((int)pointF.X, (int)pointF.Y), color, Color.Transparent);
			}
		}
	}

	// Token: 0x04000D73 RID: 3443
	private string string_0 = string.Empty;
}
