using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using _i;

// Token: 0x020001CE RID: 462
[ToolboxItem(false)]
internal class Control1 : UserControl, IDisposable
{
	// Token: 0x060018FF RID: 6399 RVA: 0x000CCE90 File Offset: 0x000CB090
	internal Control1(Control3 control3_1)
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		base.Font = new Font(FontFamily.GenericSansSerif, 9f);
		this.list_0 = new List<Class303>();
		base.VerticalScroll.SmallChange = this.Int32_0;
		this.MaximumSize = new Size(base.Size.Width, 180);
		this.toolTip_0.ShowAlways = false;
		this.Int32_1 = 500;
		this.timer_0.Tick += this.timer_0_Tick;
		this.Color_0 = Color.Orange;
		this.Color_1 = Color.Red;
		this.Int32_2 = 3000;
		this.toolTip_0.Popup += this.toolTip_0_Popup;
		this.control3_0 = control3_1;
		control3_1.KeyDown += this.method_6;
		control3_1.Event_6 += this.method_5;
		control3_1.Event_13 += this.method_1;
		Form form = control3_1.FindForm();
		if (form != null)
		{
			form.LocationChanged += this.method_16;
			form.ResizeBegin += this.method_17;
			form.FormClosing += this.method_18;
			form.LostFocus += this.method_19;
		}
		control3_1.LostFocus += this.method_20;
		control3_1.Scroll += this.method_21;
		base.VisibleChanged += this.Control1_VisibleChanged;
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001900 RID: 6400 RVA: 0x00011282 File Offset: 0x0000F482
	private int Int32_0
	{
		get
		{
			return this.Font.Height + 2;
		}
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001901 RID: 6401 RVA: 0x00011291 File Offset: 0x0000F491
	private Class307 Class307_0
	{
		get
		{
			return base.Parent as Class307;
		}
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06001902 RID: 6402 RVA: 0x0001129E File Offset: 0x0000F49E
	// (set) Token: 0x06001903 RID: 6403 RVA: 0x000112A6 File Offset: 0x0000F4A6
	internal bool Boolean_0 { get; set; }

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06001904 RID: 6404 RVA: 0x000112AF File Offset: 0x0000F4AF
	// (set) Token: 0x06001905 RID: 6405 RVA: 0x000112B7 File Offset: 0x0000F4B7
	public ImageList ImageList_0 { get; set; }

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06001906 RID: 6406 RVA: 0x000112C0 File Offset: 0x0000F4C0
	// (set) Token: 0x06001907 RID: 6407 RVA: 0x000112CD File Offset: 0x0000F4CD
	internal int Int32_1
	{
		get
		{
			return this.timer_0.Interval;
		}
		set
		{
			this.timer_0.Interval = value;
		}
	}

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06001908 RID: 6408 RVA: 0x000112DB File Offset: 0x0000F4DB
	// (set) Token: 0x06001909 RID: 6409 RVA: 0x000112E3 File Offset: 0x0000F4E3
	internal int Int32_2 { get; set; }

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x0600190A RID: 6410 RVA: 0x000112EC File Offset: 0x0000F4EC
	// (set) Token: 0x0600190B RID: 6411 RVA: 0x000112F4 File Offset: 0x0000F4F4
	internal Size Size_0 { get; set; }

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x0600190C RID: 6412 RVA: 0x000112FD File Offset: 0x0000F4FD
	// (set) Token: 0x0600190D RID: 6413 RVA: 0x0001130A File Offset: 0x0000F50A
	internal bool Boolean_1
	{
		get
		{
			return this.toolTip_0.ShowAlways;
		}
		set
		{
			this.toolTip_0.ShowAlways = value;
		}
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x0600190E RID: 6414 RVA: 0x00011318 File Offset: 0x0000F518
	// (set) Token: 0x0600190F RID: 6415 RVA: 0x00011320 File Offset: 0x0000F520
	public Color Color_0 { get; set; }

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001910 RID: 6416 RVA: 0x00011329 File Offset: 0x0000F529
	// (set) Token: 0x06001911 RID: 6417 RVA: 0x00011331 File Offset: 0x0000F531
	public Color Color_1 { get; set; }

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001912 RID: 6418 RVA: 0x0001133A File Offset: 0x0000F53A
	// (set) Token: 0x06001913 RID: 6419 RVA: 0x00011342 File Offset: 0x0000F542
	public int Int32_3
	{
		get
		{
			return this.int_1;
		}
		set
		{
			if (this.int_1 != value)
			{
				this.int_1 = value;
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
				}
			}
		}
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06001914 RID: 6420 RVA: 0x0001136D File Offset: 0x0000F56D
	// (set) Token: 0x06001915 RID: 6421 RVA: 0x0001139E File Offset: 0x0000F59E
	public Class303 Class303_0
	{
		get
		{
			if (this.Int32_3 >= 0 && this.int_1 < this.list_0.Count)
			{
				return this.list_0[this.int_1];
			}
			return null;
		}
		set
		{
			this.Int32_3 = this.list_0.IndexOf(value);
		}
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06001916 RID: 6422 RVA: 0x000113B2 File Offset: 0x0000F5B2
	public int Int32_4
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x14000020 RID: 32
	// (add) Token: 0x06001917 RID: 6423 RVA: 0x000CD054 File Offset: 0x000CB254
	// (remove) Token: 0x06001918 RID: 6424 RVA: 0x000CD08C File Offset: 0x000CB28C
	public event EventHandler Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x000CD0C4 File Offset: 0x000CB2C4
	private void toolTip_0_Popup(object sender, PopupEventArgs e)
	{
		if (this.Size_0.Height > 0 && this.Size_0.Width > 0)
		{
			e.ToolTipSize = this.Size_0;
		}
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x000CD100 File Offset: 0x000CB300
	protected override void Dispose(bool disposing)
	{
		if (this.toolTip_0 != null)
		{
			this.toolTip_0.Popup -= this.toolTip_0_Popup;
			this.toolTip_0.Dispose();
		}
		if (this.control3_0 != null)
		{
			this.control3_0.KeyDown -= this.method_6;
			this.control3_0.Event_13 -= this.method_1;
			this.control3_0.Event_6 -= this.method_5;
		}
		if (this.timer_0 != null)
		{
			this.timer_0.Stop();
			this.timer_0.Tick -= this.timer_0_Tick;
			this.timer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x000113BF File Offset: 0x0000F5BF
	private void method_0()
	{
		if (this.Class307_0 != null && !this.Class307_0.IsDisposed)
		{
			this.Class307_0.method_1();
		}
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x000CD1C0 File Offset: 0x000CB3C0
	private void method_1(object sender, KeyPressEventArgs e)
	{
		bool flag = e.KeyChar == '\b' || e.KeyChar == 'ÿ';
		if (this.Class307_0.Visible && !flag)
		{
			this.method_4(false);
			return;
		}
		this.method_2(this.timer_0);
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x000113E1 File Offset: 0x0000F5E1
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.method_4(false);
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x000113F5 File Offset: 0x0000F5F5
	private void method_2(global::System.Windows.Forms.Timer timer_1)
	{
		timer_1.Stop();
		timer_1.Start();
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00011403 File Offset: 0x0000F603
	internal void method_3()
	{
		this.method_4(false);
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x000CD20C File Offset: 0x000CB40C
	internal void method_4(bool bool_1)
	{
		if (!this.Class307_0.Enabled)
		{
			this.Class307_0.method_1();
			return;
		}
		this.list_0.Clear();
		this.Int32_3 = 0;
		base.VerticalScroll.Value = 0;
		base.AutoScrollMinSize -= new Size(1, 0);
		base.AutoScrollMinSize += new Size(1, 0);
		Class357 @class = this.control3_0.Class357_5.method_43(this.Class307_0.String_0);
		string string_ = @class.String_1;
		Point point = this.control3_0.method_93(@class.GStruct19_1);
		point.Offset(2, this.control3_0.Int32_2);
		if (bool_1 || (string_.Length >= this.Class307_0.Int32_0 && this.control3_0.Class357_5.Boolean_2 && (GStruct19.smethod_4(this.control3_0.Class357_5.GStruct19_0, @class.GStruct19_0) || string_.Length == 0)))
		{
			this.Class307_0.Class357_0 = @class;
			bool flag = false;
			foreach (Class303 class2 in this.ienumerable_0)
			{
				class2.Class307_0 = this.Class307_0;
				GEnum11 genum = class2.m_E27BA5A4(string_);
				if (genum != GEnum11.Hidden)
				{
					this.list_0.Add(class2);
				}
				if (genum == GEnum11.VisibleAndSelected && !flag)
				{
					flag = true;
					this.Int32_3 = this.list_0.Count - 1;
				}
			}
			if (flag)
			{
				this.method_7();
				this.method_12();
			}
		}
		if (this.Int32_4 > 0)
		{
			if (!this.Class307_0.Visible)
			{
				CancelEventArgs e = new CancelEventArgs();
				this.Class307_0.method_0(e);
				if (!e.Cancel)
				{
					this.Class307_0.Show(this.control3_0, point);
				}
			}
			this.method_12();
			base.Invalidate();
			return;
		}
		this.Class307_0.method_1();
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x000CD418 File Offset: 0x000CB618
	private void method_5(object sender, EventArgs e)
	{
		if (this.Class307_0.Visible)
		{
			bool flag = false;
			if (!this.control3_0.Class357_5.Boolean_2)
			{
				flag = true;
			}
			else if (!this.Class307_0.Class357_0.method_0(this.control3_0.Class357_5.GStruct19_0))
			{
				if (this.control3_0.Class357_5.GStruct19_0.int_1 == this.Class307_0.Class357_0.GStruct19_1.int_1 && this.control3_0.Class357_5.GStruct19_0.int_0 == this.Class307_0.Class357_0.GStruct19_1.int_0 + 1)
				{
					if (!Regex.IsMatch(this.control3_0.Class357_5.Char_1.ToString(), this.Class307_0.String_0))
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.Class307_0.method_1();
			}
		}
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x000CD510 File Offset: 0x000CB710
	private void method_6(object sender, KeyEventArgs e)
	{
		Control3 control = sender as Control3;
		if (this.Class307_0.Visible && this.method_10(e.KeyCode, e.Modifiers))
		{
			e.Handled = true;
		}
		if (!this.Class307_0.Visible)
		{
			if (control.Class347_0.ContainsKey(e.KeyData) && control.Class347_0[e.KeyData] == FCTBAction.AutocompleteMenu)
			{
				this.method_3();
				e.Handled = true;
				return;
			}
			if (e.KeyCode == Keys.Escape && this.timer_0.Enabled)
			{
				this.timer_0.Stop();
			}
		}
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x000CD5B0 File Offset: 0x000CB7B0
	private void method_7()
	{
		if (this.int_2 == this.list_0.Count)
		{
			return;
		}
		int num = this.Int32_0 * this.list_0.Count + 1;
		base.Height = Math.Min(num, this.MaximumSize.Height);
		this.Class307_0.method_2();
		base.AutoScrollMinSize = new Size(0, num);
		this.int_2 = this.list_0.Count;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x000CD62C File Offset: 0x000CB82C
	protected override void OnPaint(PaintEventArgs e)
	{
		this.method_7();
		int int32_ = this.Int32_0;
		int num = base.VerticalScroll.Value / int32_ - 1;
		int num2 = (base.VerticalScroll.Value + base.ClientSize.Height) / int32_ + 1;
		int num3 = Math.Max(num, 0);
		num2 = Math.Min(num2, this.list_0.Count);
		int num4 = 0;
		int num5 = 18;
		for (int i = num3; i < num2; i++)
		{
			num4 = i * int32_ - base.VerticalScroll.Value;
			Class303 @class = this.list_0[i];
			if (@class.Color_1 != Color.Transparent)
			{
				using (SolidBrush solidBrush = new SolidBrush(@class.Color_1))
				{
					e.Graphics.FillRectangle(solidBrush, 1, num4, base.ClientSize.Width - 1 - 1, int32_ - 1);
				}
			}
			if (this.ImageList_0 != null && this.list_0[i].int_0 >= 0)
			{
				e.Graphics.DrawImage(this.ImageList_0.Images[@class.int_0], 1, num4);
			}
			if (i == this.Int32_3)
			{
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, num4 - 3), new Point(0, num4 + int32_), Color.Transparent, this.Color_0))
				{
					using (Pen pen = new Pen(this.Color_0))
					{
						e.Graphics.FillRectangle(linearGradientBrush, num5, num4, base.ClientSize.Width - 1 - num5, int32_ - 1);
						e.Graphics.DrawRectangle(pen, num5, num4, base.ClientSize.Width - 1 - num5, int32_ - 1);
					}
				}
			}
			if (i == this.int_0)
			{
				using (Pen pen2 = new Pen(this.Color_1))
				{
					e.Graphics.DrawRectangle(pen2, num5, num4, base.ClientSize.Width - 1 - num5, int32_ - 1);
				}
			}
			using (SolidBrush solidBrush2 = new SolidBrush((@class.Color_0 != Color.Transparent) ? @class.Color_0 : this.ForeColor))
			{
				e.Graphics.DrawString(@class.ToString(), this.Font, solidBrush2, (float)num5, (float)num4);
			}
		}
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x0001140C File Offset: 0x0000F60C
	protected override void OnScroll(ScrollEventArgs se)
	{
		base.OnScroll(se);
		base.Invalidate();
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x0001141B File Offset: 0x0000F61B
	protected override void OnMouseClick(MouseEventArgs e)
	{
		base.OnMouseClick(e);
		if (e.Button == MouseButtons.Left)
		{
			this.Int32_3 = this.method_9(e.Location);
			this.method_12();
			base.Invalidate();
		}
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x0001144F File Offset: 0x0000F64F
	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
		base.OnMouseDoubleClick(e);
		this.Int32_3 = this.method_9(e.Location);
		base.Invalidate();
		this.vmethod_0();
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x000CD8E0 File Offset: 0x000CBAE0
	internal virtual void vmethod_0()
	{
		if (this.Int32_3 >= 0 && this.Int32_3 < this.list_0.Count)
		{
			this.control3_0.Class381_0.Class312_0.method_4();
			try
			{
				Class303 class303_ = this.Class303_0;
				EventArgs0 eventArgs = new EventArgs0
				{
					Class303_0 = class303_,
					Int32_0 = this.Int32_3
				};
				this.Class307_0.method_4(eventArgs);
				if (eventArgs.Boolean_0)
				{
					this.Int32_3 = eventArgs.Int32_0;
					base.Invalidate();
				}
				else
				{
					if (!eventArgs.Boolean_1)
					{
						Class357 class357_ = this.Class307_0.Class357_0;
						this.method_8(class303_, class357_);
					}
					this.Class307_0.method_1();
					EventArgs1 eventArgs2 = new EventArgs1
					{
						Class303_0 = class303_,
						Control3_0 = this.Class307_0.Class357_0.control3_0
					};
					class303_.m_864A0ECA(this.Class307_0, eventArgs2);
					this.Class307_0.method_5(eventArgs2);
				}
			}
			finally
			{
				this.control3_0.Class381_0.Class312_0.method_3();
			}
			return;
		}
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x000CD9F8 File Offset: 0x000CBBF8
	private void method_8(Class303 class303_0, Class357 class357_0)
	{
		string text = class303_0.m_8A4FE07C();
		Control3 control = class357_0.control3_0;
		control.method_106();
		control.Class381_0.Class312_0.vmethod_0(new Class323(control.Class381_0));
		if (control.Class357_5.Boolean_0)
		{
			GStruct19 gstruct19_ = control.Class357_5.GStruct19_0;
			GStruct19 gstruct19_2 = control.Class357_5.GStruct19_1;
			gstruct19_.int_0 = class357_0.GStruct19_0.int_0;
			gstruct19_2.int_0 = class357_0.GStruct19_1.int_0;
			control.Class357_5.GStruct19_0 = gstruct19_;
			control.Class357_5.GStruct19_1 = gstruct19_2;
		}
		else
		{
			control.Class357_5.GStruct19_0 = class357_0.GStruct19_0;
			control.Class357_5.GStruct19_1 = class357_0.GStruct19_1;
		}
		control.vmethod_20(text);
		control.Class381_0.Class312_0.vmethod_0(new Class323(control.Class381_0));
		control.method_107();
		control.Focus();
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00011476 File Offset: 0x0000F676
	private int method_9(Point point_0)
	{
		return (point_0.Y + base.VerticalScroll.Value) / this.Int32_0;
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00011492 File Offset: 0x0000F692
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		this.method_10(keyData, Keys.None);
		return base.ProcessCmdKey(ref msg, keyData);
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x000CDAE8 File Offset: 0x000CBCE8
	private bool method_10(Keys keys_0, Keys keys_1)
	{
		if (keys_1 == Keys.None)
		{
			if (keys_0 <= Keys.Escape)
			{
				if (keys_0 != Keys.Tab)
				{
					if (keys_0 == Keys.Return)
					{
						this.vmethod_0();
						return true;
					}
					if (keys_0 == Keys.Escape)
					{
						this.Class307_0.method_1();
						return true;
					}
				}
				else if (this.Boolean_0)
				{
					this.vmethod_0();
					return true;
				}
			}
			else if (keys_0 <= Keys.Next)
			{
				if (keys_0 == Keys.Prior)
				{
					this.method_11(-10);
					return true;
				}
				if (keys_0 == Keys.Next)
				{
					this.method_11(10);
					return true;
				}
			}
			else
			{
				if (keys_0 == Keys.Up)
				{
					this.method_11(-1);
					return true;
				}
				if (keys_0 == Keys.Down)
				{
					this.method_11(1);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x000114A5 File Offset: 0x0000F6A5
	public void method_11(int int_4)
	{
		this.Int32_3 = Math.Max(0, Math.Min(this.Int32_3 + int_4, this.list_0.Count - 1));
		this.method_12();
		base.Invalidate();
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x000CDB78 File Offset: 0x000CBD78
	private void method_12()
	{
		if (this.Class303_0 != null)
		{
			this.method_13(this.Class303_0);
		}
		int num = this.Int32_3 * this.Int32_0 - base.VerticalScroll.Value;
		if (num < 0)
		{
			base.VerticalScroll.Value = this.Int32_3 * this.Int32_0;
		}
		if (num > base.ClientSize.Height - this.Int32_0)
		{
			base.VerticalScroll.Value = Math.Min(base.VerticalScroll.Maximum, this.Int32_3 * this.Int32_0 - base.ClientSize.Height + this.Int32_0);
		}
		base.AutoScrollMinSize -= new Size(1, 0);
		base.AutoScrollMinSize += new Size(1, 0);
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x000CDC54 File Offset: 0x000CBE54
	private void method_13(Class303 class303_0)
	{
		string string_ = class303_0.String_0;
		string string_2 = class303_0.String_1;
		if (string.IsNullOrEmpty(string_))
		{
			this.toolTip_0.ToolTipTitle = null;
			this.toolTip_0.SetToolTip(this, null);
			return;
		}
		if (base.Parent != null)
		{
			IWin32Window win32Window = base.Parent ?? this;
			Point point;
			if (base.PointToScreen(base.Location).X + this.Size_0.Width + 105 < Screen.FromControl(base.Parent).WorkingArea.Right)
			{
				point = new Point(base.Right + 5, 0);
			}
			else
			{
				point = new Point(base.Left - 105 - this.MaximumSize.Width, 0);
			}
			if (string.IsNullOrEmpty(string_2))
			{
				this.toolTip_0.ToolTipTitle = null;
				this.toolTip_0.Show(string_, win32Window, point.X, point.Y, this.Int32_2);
				return;
			}
			this.toolTip_0.ToolTipTitle = string_;
			this.toolTip_0.Show(string_2, win32Window, point.X, point.Y, this.Int32_2);
		}
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x000CDD84 File Offset: 0x000CBF84
	public void method_14(ICollection<string> icollection_0)
	{
		List<Class303> list = new List<Class303>(icollection_0.Count);
		foreach (string text in icollection_0)
		{
			list.Add(new Class303(text));
		}
		this.method_15(list);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x000114D9 File Offset: 0x0000F6D9
	public void method_15(IEnumerable<Class303> ienumerable_1)
	{
		this.ienumerable_0 = ienumerable_1;
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x000114E2 File Offset: 0x0000F6E2
	[CompilerGenerated]
	private void method_16(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x000114E2 File Offset: 0x0000F6E2
	[CompilerGenerated]
	private void method_17(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x000114E2 File Offset: 0x0000F6E2
	[CompilerGenerated]
	private void method_18(object sender, FormClosingEventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x000114E2 File Offset: 0x0000F6E2
	[CompilerGenerated]
	private void method_19(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x000114EA File Offset: 0x0000F6EA
	[CompilerGenerated]
	private void method_20(object sender, EventArgs e)
	{
		if (this.Class307_0 != null && !this.Class307_0.IsDisposed && !this.Class307_0.Focused)
		{
			this.method_0();
		}
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x000114E2 File Offset: 0x0000F6E2
	[CompilerGenerated]
	private void method_21(object sender, ScrollEventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x00011514 File Offset: 0x0000F714
	[CompilerGenerated]
	private void Control1_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			this.method_12();
		}
	}

	// Token: 0x04001068 RID: 4200
	private readonly int int_0 = -1;

	// Token: 0x04001069 RID: 4201
	private readonly Control3 control3_0;

	// Token: 0x0400106A RID: 4202
	private readonly global::System.Windows.Forms.Timer timer_0 = new global::System.Windows.Forms.Timer();

	// Token: 0x0400106B RID: 4203
	private int int_1;

	// Token: 0x0400106C RID: 4204
	private int int_2;

	// Token: 0x0400106D RID: 4205
	private IEnumerable<Class303> ienumerable_0 = new List<Class303>();

	// Token: 0x0400106E RID: 4206
	internal ToolTip toolTip_0 = new ToolTip();

	// Token: 0x0400106F RID: 4207
	internal List<Class303> list_0;

	// Token: 0x04001070 RID: 4208
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001071 RID: 4209
	[CompilerGenerated]
	private ImageList imageList_0;

	// Token: 0x04001072 RID: 4210
	[CompilerGenerated]
	private int int_3;

	// Token: 0x04001073 RID: 4211
	[CompilerGenerated]
	private Size size_0;

	// Token: 0x04001074 RID: 4212
	[CompilerGenerated]
	private Color color_0;

	// Token: 0x04001075 RID: 4213
	[CompilerGenerated]
	private Color color_1;

	// Token: 0x04001076 RID: 4214
	[CompilerGenerated]
	private EventHandler eventHandler_0;
}
