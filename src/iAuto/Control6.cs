using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// Token: 0x02000258 RID: 600
internal class Control6 : TabControl
{
	// Token: 0x06001FF6 RID: 8182 RVA: 0x000156FB File Offset: 0x000138FB
	public Control6()
	{
		base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
		this.TabAlignment_0 = TabAlignment.Bottom;
		this.Boolean_0 = true;
		this.Padding = new Point(12, 5);
		this.class392_0 = new Control6.Class392(this);
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x0001573B File Offset: 0x0001393B
	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		this.method_0();
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x0001574A File Offset: 0x0001394A
	protected override void Dispose(bool disposing)
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			Control6.Class394.DeleteObject(this.intptr_0);
			this.intptr_0 = IntPtr.Zero;
		}
		this.class392_0.ReleaseHandle();
		base.Dispose(disposing);
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000EA9B8 File Offset: 0x000E8BB8
	private void method_0()
	{
		this.bool_0 = true;
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
		base.UpdateStyles();
		if (this.bool_0)
		{
			if (this.intptr_0 == IntPtr.Zero)
			{
				this.intptr_0 = this.Font.ToHfont();
			}
			Control6.Class394.SendMessageW(base.Handle, 48U, this.intptr_0, (IntPtr)1);
			return;
		}
		Control6.Class394.SendMessageW(base.Handle, 48U, this.Font.ToHfont(), (IntPtr)1);
		if (this.intptr_0 != IntPtr.Zero)
		{
			Control6.Class394.DeleteObject(this.intptr_0);
			this.intptr_0 = IntPtr.Zero;
		}
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x000EAA7C File Offset: 0x000E8C7C
	protected override void OnFontChanged(EventArgs e)
	{
		base.OnFontChanged(e);
		if (this.bool_0)
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				Control6.Class394.DeleteObject(this.intptr_0);
			}
			this.intptr_0 = this.Font.ToHfont();
			Control6.Class394.SendMessageW(base.Handle, 48U, this.intptr_0, (IntPtr)1);
		}
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000EAAE4 File Offset: 0x000E8CE4
	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 794)
		{
			this.method_0();
		}
		else if (m.Msg == 528 && (m.WParam.ToInt32() & 65535) == 1)
		{
			StringBuilder stringBuilder = new StringBuilder(16);
			if (Control6.Class394.RealGetWindowClassW(m.LParam, stringBuilder, 16U) > 0U && stringBuilder.ToString() == "msctls_updown32")
			{
				this.class392_0.ReleaseHandle();
				this.class392_0.AssignHandle(m.LParam);
			}
		}
		base.WndProc(ref m);
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000EAB78 File Offset: 0x000E8D78
	private void method_1(Graphics graphics_0, Rectangle rectangle_0)
	{
		if (!base.Visible)
		{
			return;
		}
		graphics_0.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
		graphics_0.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

		int selectedIndex = base.SelectedIndex;
		Rectangle rectangle = ((selectedIndex != -1) ? base.GetTabRect(selectedIndex) : Rectangle.Empty);
		Rectangle clientRectangle = base.ClientRectangle;
		TabAlignment tabAlignment_ = this.TabAlignment_0;
		if (tabAlignment_ != TabAlignment.Top)
		{
			if (tabAlignment_ == TabAlignment.Bottom)
			{
				clientRectangle.Height -= rectangle.Height * base.RowCount + 1;
			}
		}
		else
		{
			int num = rectangle.Height * base.RowCount + 2;
			clientRectangle.Y += num;
			clientRectangle.Height -= num;
		}

		// Dark Cyber Tab background
		using (SolidBrush bStrip = new SolidBrush(Color.FromArgb(15, 23, 42)))
		{
			graphics_0.FillRectangle(bStrip, base.ClientRectangle);
		}

		// Dark Cyber TabPage content area
		if (clientRectangle.IntersectsWith(rectangle_0) && clientRectangle.Width > 0 && clientRectangle.Height > 0)
		{
			using (SolidBrush bPage = new SolidBrush(Color.FromArgb(18, 24, 36)))
			using (Pen pBorder = new Pen(Color.FromArgb(42, 54, 79)))
			{
				graphics_0.FillRectangle(bPage, clientRectangle);
				graphics_0.DrawRectangle(pBorder, clientRectangle.X, clientRectangle.Y, Math.Max(0, clientRectangle.Width - 1), Math.Max(0, clientRectangle.Height - 1));
			}
		}

		int tabCount = base.TabCount;
		if (tabCount == 0)
		{
			return;
		}
		this.int_0 = this.method_4();
		for (int i = 0; i < tabCount; i++)
		{
			if (i != selectedIndex)
			{
				Rectangle tabRect = base.GetTabRect(i);
				if (tabRect.Right >= 3 && tabRect.IntersectsWith(rectangle_0))
				{
					bool isHot = (i == this.int_0);
					this.DrawCyberTab(graphics_0, i, tabRect, false, isHot);
				}
			}
		}
		rectangle.Inflate(1, 0);
		if (selectedIndex != -1 && rectangle.IntersectsWith(rectangle_0))
		{
			this.DrawCyberTab(graphics_0, selectedIndex, rectangle, true, false);
		}
	}

	private void DrawCyberTab(Graphics g, int tabIndex, Rectangle rect, bool isSelected, bool isHot)
	{
		if (tabIndex < 0 || tabIndex >= base.TabPages.Count)
		{
			return;
		}
		if (this.class392_0.Int32_0 > 0 && rect.X >= this.class392_0.Int32_0)
		{
			return;
		}
		TabPage tabPage = base.TabPages[tabIndex];

		Color bgColor = isSelected 
			? Color.FromArgb(20, 27, 41) 
			: (isHot ? Color.FromArgb(39, 53, 76) : Color.FromArgb(30, 41, 59));
		Color textColor = isSelected 
			? Color.FromArgb(255, 255, 255) 
			: (isHot ? Color.FromArgb(255, 255, 255) : Color.FromArgb(226, 232, 240));
		Color accentCyan = Color.FromArgb(56, 189, 248);
		Color borderColor = isSelected ? Color.FromArgb(14, 165, 233) : Color.FromArgb(51, 65, 85);

		using (SolidBrush bBg = new SolidBrush(bgColor))
		using (Pen pBorder = new Pen(borderColor))
		{
			g.FillRectangle(bBg, rect);
			g.DrawRectangle(pBorder, rect.X, rect.Y, Math.Max(0, rect.Width - 1), Math.Max(0, rect.Height - 1));

			if (isSelected)
			{
				using (SolidBrush bAccent = new SolidBrush(accentCyan))
				{
					if (this.TabAlignment_0 == TabAlignment.Bottom)
					{
						g.FillRectangle(bAccent, rect.X, rect.Bottom - 3, rect.Width, 3);
					}
					else
					{
						g.FillRectangle(bAccent, rect.X, rect.Y, rect.Width, 3);
					}
				}
			}
		}

		Rectangle textRect = new Rectangle(rect.X + 4, rect.Y + (isSelected ? 2 : 1), Math.Max(0, rect.Width - 8), Math.Max(0, rect.Height - 3));
		Image image = this.method_3(tabPage.ImageIndex, tabPage.ImageKey);
		if (image != null)
		{
			int imgY = rect.Y + (rect.Height - image.Height) / 2;
			g.DrawImage(image, rect.X + 6, imgY, image.Width, image.Height);
			textRect.X += image.Width + 6;
			textRect.Width -= (image.Width + 6);
		}

		using (Font tabFont = new Font(this.Font.FontFamily, isSelected ? 9f : 8.5f, isSelected ? FontStyle.Bold : FontStyle.Regular))
		using (Brush bText = new SolidBrush(textColor))
		{
			StringFormat sf = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center,
				Trimming = StringTrimming.EllipsisCharacter,
				FormatFlags = StringFormatFlags.NoWrap
			};
			g.DrawString(tabPage.Text, tabFont, bText, textRect, sf);
		}
	}

	private void method_2(Graphics graphics_0, int int_1, Rectangle rectangle_0, VisualStyleRenderer visualStyleRenderer_0)
	{
		bool isSelected = (visualStyleRenderer_0 != null && visualStyleRenderer_0.State == 3);
		bool isHot = (visualStyleRenderer_0 != null && visualStyleRenderer_0.State == 2);
		this.DrawCyberTab(graphics_0, int_1, rectangle_0, isSelected, isHot);
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x00015787 File Offset: 0x00013987
	private Image method_3(int int_1, string string_0)
	{
		if (base.ImageList == null)
		{
			return null;
		}
		if (int_1 > -1)
		{
			return base.ImageList.Images[int_1];
		}
		if (string_0.Length > 0)
		{
			return base.ImageList.Images[string_0];
		}
		return null;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000EAEFC File Offset: 0x000E90FC
	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Point location = base.Location;
		e.Graphics.TranslateTransform((float)(-(float)location.X), (float)(-(float)location.Y));
		base.InvokePaintBackground(base.Parent, e);
		e.Graphics.TranslateTransform((float)location.X, (float)location.Y);
		this.method_1(e.Graphics, e.ClipRectangle);
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x000EAF70 File Offset: 0x000E9170
	private int method_4()
	{
		Control6.Class394.Struct38 @struct = default(Control6.Class394.Struct38);
		Point point = base.PointToClient(Control.MousePosition);
		@struct.struct37_0.int_0 = point.X;
		@struct.struct37_0.int_1 = point.Y;
		GCHandle gchandle = GCHandle.Alloc(@struct, GCHandleType.Pinned);
		int num = (int)Control6.Class394.SendMessageW(base.Handle, 4877U, IntPtr.Zero, gchandle.AddrOfPinnedObject());
		gchandle.Free();
		return num;
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x06002001 RID: 8193 RVA: 0x000157C5 File Offset: 0x000139C5
	// (set) Token: 0x06002002 RID: 8194 RVA: 0x000157CD File Offset: 0x000139CD
	[Browsable(true)]
	[DefaultValue(TabAlignment.Bottom)]
	public TabAlignment TabAlignment_0
	{
		get
		{
			return base.Alignment;
		}
		set
		{
			if (value <= TabAlignment.Bottom)
			{
				base.Alignment = value;
			}
		}
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06002003 RID: 8195 RVA: 0x000157DA File Offset: 0x000139DA
	// (set) Token: 0x06002004 RID: 8196 RVA: 0x000157E2 File Offset: 0x000139E2
	[Browsable(true)]
	[DefaultValue(true)]
	public bool Boolean_0
	{
		get
		{
			return base.HotTrack;
		}
		set
		{
			base.HotTrack = value;
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x06002005 RID: 8197 RVA: 0x000157EB File Offset: 0x000139EB
	// (set) Token: 0x06002006 RID: 8198 RVA: 0x000157F3 File Offset: 0x000139F3
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public TabAppearance TabAppearance_0
	{
		get
		{
			return base.Appearance;
		}
		set
		{
			if (value == TabAppearance.Normal)
			{
				base.Appearance = value;
			}
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x06002007 RID: 8199 RVA: 0x000157FF File Offset: 0x000139FF
	// (set) Token: 0x06002008 RID: 8200 RVA: 0x00015807 File Offset: 0x00013A07
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public TabDrawMode TabDrawMode_0
	{
		get
		{
			return base.DrawMode;
		}
		set
		{
			if (value == TabDrawMode.Normal)
			{
				base.DrawMode = value;
			}
		}
	}

	// Token: 0x04001428 RID: 5160
	private readonly Control6.Class392 class392_0;

	// Token: 0x04001429 RID: 5161
	private bool bool_0;

	// Token: 0x0400142A RID: 5162
	private IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x0400142B RID: 5163
	private int int_0 = -1;

	// Token: 0x02000259 RID: 601
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	private class Class392 : NativeWindow
	{
		// Token: 0x06002009 RID: 8201 RVA: 0x00015813 File Offset: 0x00013A13
		public Class392(Control6 control6_1)
		{
			this.control6_0 = control6_1;
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x00015822 File Offset: 0x00013A22
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0001582A File Offset: 0x00013A2A
		public int Int32_0 { get; private set; }

		// Token: 0x0600200C RID: 8204 RVA: 0x000EAFEC File Offset: 0x000E91EC
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 15)
			{
				base.WndProc(ref m);
				try
				{
					Control6.Class394.RECT rect;
					if (Control6.Class394.GetClientRect(this.Handle, out rect) && rect.Width > 0 && rect.Height > 0)
					{
						using (Graphics g = Graphics.FromHwnd(this.Handle))
						{
							int halfW = rect.Width / 2;
							Rectangle leftBtn = new Rectangle(0, 0, halfW, rect.Height);
							Rectangle rightBtn = new Rectangle(halfW, 0, rect.Width - halfW, rect.Height);

							using (SolidBrush bBg = new SolidBrush(Color.FromArgb(30, 41, 59)))
							using (Pen pBorder = new Pen(Color.FromArgb(51, 65, 85)))
							using (SolidBrush bArrow = new SolidBrush(Color.FromArgb(56, 189, 248)))
							{
								g.FillRectangle(bBg, leftBtn);
								g.DrawRectangle(pBorder, leftBtn.X, leftBtn.Y, Math.Max(0, leftBtn.Width - 1), Math.Max(0, leftBtn.Height - 1));
								int lcx = leftBtn.X + leftBtn.Width / 2;
								int lcy = leftBtn.Y + leftBtn.Height / 2;
								Point[] leftArrow = new Point[]
								{
									new Point(lcx + 2, lcy - 4),
									new Point(lcx + 2, lcy + 4),
									new Point(lcx - 3, lcy)
								};
								g.FillPolygon(bArrow, leftArrow);

								g.FillRectangle(bBg, rightBtn);
								g.DrawRectangle(pBorder, rightBtn.X, rightBtn.Y, Math.Max(0, rightBtn.Width - 1), Math.Max(0, rightBtn.Height - 1));
								int rcx = rightBtn.X + rightBtn.Width / 2;
								int rcy = rightBtn.Y + rightBtn.Height / 2;
								Point[] rightArrow = new Point[]
								{
									new Point(rcx - 2, rcy - 4),
									new Point(rcx - 2, rcy + 4),
									new Point(rcx + 3, rcy)
								};
								g.FillPolygon(bArrow, rightArrow);
							}
						}
					}
				}
				catch
				{
				}
				return;
			}
			if (m.Msg != 2)
			{
				if (m.Msg != 130)
				{
					if (m.Msg == 70)
					{
						Control6.Class394.Struct39 @struct = (Control6.Class394.Struct39)m.GetLParam(typeof(Control6.Class394.Struct39));
						this.Int32_0 = @struct.int_0;
						goto IL_019A;
					}
					if (m.Msg == 512 && this.control6_0.int_0 > 0 && this.control6_0.int_0 != this.control6_0.SelectedIndex)
					{
						using (Graphics graphics = Graphics.FromHwnd(this.control6_0.Handle))
						{
							VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(VisualStyleElement.Tab.TabItem.Normal);
							this.control6_0.method_2(graphics, this.control6_0.int_0, this.control6_0.GetTabRect(this.control6_0.int_0), visualStyleRenderer);
							if (this.control6_0.int_0 - this.control6_0.SelectedIndex == 1)
							{
								Rectangle tabRect = this.control6_0.GetTabRect(this.control6_0.SelectedIndex);
								tabRect.Inflate(2, 2);
								visualStyleRenderer.SetParameters(visualStyleRenderer.Class, visualStyleRenderer.Part, 3);
								this.control6_0.method_2(graphics, this.control6_0.SelectedIndex, tabRect, visualStyleRenderer);
							}
							goto IL_019A;
						}
					}
					if (m.Msg == 513)
					{
						Rectangle tabRect2 = this.control6_0.GetTabRect(this.control6_0.SelectedIndex);
						tabRect2.X = 0;
						tabRect2.Width = 2;
						tabRect2.Inflate(0, 2);
						this.control6_0.Invalidate(tabRect2);
						goto IL_019A;
					}
					goto IL_019A;
				}
			}
			this.ReleaseHandle();
			IL_019A:
			base.WndProc(ref m);
		}

		// Token: 0x0400142C RID: 5164
		private readonly Control6 control6_0;

		// Token: 0x0400142D RID: 5165
		[CompilerGenerated]
		private int int_0;
	}

	// Token: 0x0200025A RID: 602
	internal class Class393 : IDisposable
	{
		// Token: 0x0600200D RID: 8205 RVA: 0x000EB1AC File Offset: 0x000E93AC
		public Class393(Graphics graphics_1, int int_2, int int_3)
		{
			if (graphics_1 == null || int_2 <= 0 || int_3 <= 0)
			{
				throw new ArgumentException("Arguments are unacceptable");
			}
			IntPtr hdc = graphics_1.GetHdc();
			bool flag = true;
			if (!((this.intptr_0 = Control6.Class394.CreateCompatibleDC(hdc)) == IntPtr.Zero))
			{
				if ((this.intptr_1 = Control6.Class394.CreateCompatibleBitmap(hdc, int_2, int_3)) == IntPtr.Zero)
				{
					Control6.Class394.DeleteDC(this.intptr_0);
				}
				else
				{
					this.intptr_2 = Control6.Class394.SelectObject(this.intptr_0, this.intptr_1);
					if (this.intptr_2 == IntPtr.Zero)
					{
						Control6.Class394.DeleteObject(this.intptr_1);
						Control6.Class394.DeleteDC(this.intptr_0);
					}
					else
					{
						flag = false;
					}
				}
			}
			graphics_1.ReleaseHdc(hdc);
			if (flag)
			{
				throw new SystemException("GDI error occured while creating context");
			}
			this.Graphics_0 = Graphics.FromHdc(this.intptr_0);
			this.Int32_0 = int_2;
			this.Int32_1 = int_3;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00015833 File Offset: 0x00013A33
		public Graphics Graphics_0 { get; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0001583B File Offset: 0x00013A3B
		public int Int32_0 { get; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00015843 File Offset: 0x00013A43
		public int Int32_1 { get; }

		// Token: 0x06002011 RID: 8209 RVA: 0x0001584B File Offset: 0x00013A4B
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000EB2A8 File Offset: 0x000E94A8
		~Class393()
		{
			this.vmethod_0(false);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000EB2D8 File Offset: 0x000E94D8
		protected virtual void vmethod_0(bool bool_0)
		{
			if (bool_0 && this.Graphics_0 != null)
			{
				this.Graphics_0.Dispose();
			}
			Control6.Class394.SelectObject(this.intptr_0, this.intptr_2);
			Control6.Class394.DeleteDC(this.intptr_0);
			this.intptr_0 = (this.intptr_2 = IntPtr.Zero);
			Control6.Class394.DeleteObject(this.intptr_1);
			this.intptr_1 = IntPtr.Zero;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000EB344 File Offset: 0x000E9544
		public void method_0()
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				Control6.Class394.StretchBlt(this.intptr_0, 0, this.Int32_1 - 1, this.Int32_0, -this.Int32_1, this.intptr_0, 0, 0, this.Int32_0, this.Int32_1, 13369376U);
			}
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0001585A File Offset: 0x00013A5A
		public uint method_1(int int_2, int int_3)
		{
			if (!(this.intptr_0 != IntPtr.Zero))
			{
				throw new ObjectDisposedException(null, "GDI context seems to be disposed.");
			}
			return Control6.Class394.GetPixel(this.intptr_0, int_2, int_3);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00015887 File Offset: 0x00013A87
		public void method_2(int int_2, int int_3, uint uint_0)
		{
			if (!(this.intptr_0 != IntPtr.Zero))
			{
				throw new ObjectDisposedException(null, "GDI context seems to be disposed.");
			}
			Control6.Class394.SetPixel(this.intptr_0, int_2, int_3, uint_0);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000EB3A0 File Offset: 0x000E95A0
		public void method_3(Graphics graphics_1, Rectangle rectangle_0)
		{
			if (graphics_1 != null && !(this.intptr_0 == IntPtr.Zero))
			{
				IntPtr hdc = graphics_1.GetHdc();
				if (!(hdc == IntPtr.Zero))
				{
					Control6.Class394.BitBlt(hdc, rectangle_0.Left, rectangle_0.Top, rectangle_0.Width, rectangle_0.Height, this.intptr_0, 0, 0, 13369376U);
					graphics_1.ReleaseHdc(hdc);
				}
			}
		}

		// Token: 0x0400142E RID: 5166
		private IntPtr intptr_0;

		// Token: 0x0400142F RID: 5167
		private IntPtr intptr_1;

		// Token: 0x04001430 RID: 5168
		private IntPtr intptr_2;

		// Token: 0x04001431 RID: 5169
		[CompilerGenerated]
		private readonly Graphics graphics_0;

		// Token: 0x04001432 RID: 5170
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x04001433 RID: 5171
		[CompilerGenerated]
		private readonly int int_1;
	}

	// Token: 0x0200025B RID: 603
	internal static class Class394
	{
		// Token: 0x06002018 RID: 8216
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern IntPtr SendMessageW(IntPtr intptr_0, uint uint_1, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06002019 RID: 8217
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern uint RealGetWindowClassW(IntPtr intptr_0, StringBuilder stringBuilder_0, uint uint_1);

		// Token: 0x0600201A RID: 8218
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

		// Token: 0x0600201B RID: 8219
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteDC(IntPtr intptr_0);

		// Token: 0x0600201C RID: 8220
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_10, int int_11);

		// Token: 0x0600201D RID: 8221
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x0600201E RID: 8222
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject(IntPtr intptr_0);

		// Token: 0x0600201F RID: 8223
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StretchBlt(IntPtr intptr_0, int int_10, int int_11, int int_12, int int_13, IntPtr intptr_1, int int_14, int int_15, int int_16, int int_17, uint uint_1);

		// Token: 0x06002020 RID: 8224
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt(IntPtr intptr_0, int int_10, int int_11, int int_12, int int_13, IntPtr intptr_1, int int_14, int int_15, uint uint_1);

		// Token: 0x06002021 RID: 8225
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern uint GetPixel(IntPtr intptr_0, int int_10, int int_11);

		// Token: 0x06002022 RID: 8226
		[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern uint SetPixel(IntPtr intptr_0, int int_10, int int_11, uint uint_1);

		// Token: 0x04001434 RID: 5172
		public const int int_0 = 4877;

		// Token: 0x04001435 RID: 5173
		public const int int_1 = 48;

		// Token: 0x04001436 RID: 5174
		public const int int_2 = 794;

		// Token: 0x04001437 RID: 5175
		public const int int_3 = 2;

		// Token: 0x04001438 RID: 5176
		public const int int_4 = 130;

		// Token: 0x04001439 RID: 5177
		public const int int_5 = 70;

		// Token: 0x0400143A RID: 5178
		public const int int_6 = 528;

		// Token: 0x0400143B RID: 5179
		public const int int_7 = 1;

		// Token: 0x0400143C RID: 5180
		public const int int_8 = 512;

		// Token: 0x0400143D RID: 5181
		public const int int_9 = 513;

		// Token: 0x0400143E RID: 5182
		public const uint uint_0 = 13369376U;

		// Token: 0x0200025C RID: 604
		public struct Struct37
		{
			// Token: 0x0400143F RID: 5183
			public int int_0;

			// Token: 0x04001440 RID: 5184
			public int int_1;
		}

		// Token: 0x0200025D RID: 605
		public struct Struct38
		{
			// Token: 0x04001441 RID: 5185
			public Control6.Class394.Struct37 struct37_0;

			// Token: 0x04001442 RID: 5186
			public uint uint_0;
		}

		// Token: 0x0200025E RID: 606
		public struct Struct39
		{
			// Token: 0x04001443 RID: 5187
			public IntPtr intptr_0;

			// Token: 0x04001444 RID: 5188
			public IntPtr intptr_1;

			// Token: 0x04001445 RID: 5189
			public int int_0;

			// Token: 0x04001446 RID: 5190
			public int int_1;

			// Token: 0x04001447 RID: 5191
			public int int_2;

			// Token: 0x04001448 RID: 5192
			public int int_3;

			public int int_4;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
			public int Width => Right - Left;
			public int Height => Bottom - Top;
		}

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
	}

	// Token: 0x0200025F RID: 607
	private enum Enum14
	{
		// Token: 0x0400144B RID: 5195
		Normal = 1,
		// Token: 0x0400144C RID: 5196
		Hot,
		// Token: 0x0400144D RID: 5197
		Selected
	}
}
