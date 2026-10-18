using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x020001E6 RID: 486
internal class Control2 : Control
{
	// Token: 0x060019D0 RID: 6608 RVA: 0x000D017C File Offset: 0x000CE37C
	public Control2()
	{
		this.ForeColor = Color.Maroon;
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		Application.Idle += this.method_0;
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00011AD5 File Offset: 0x0000FCD5
	// (set) Token: 0x060019D2 RID: 6610 RVA: 0x00011ADD File Offset: 0x0000FCDD
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
			if (value != null)
			{
				this.vmethod_2(this.control3_0);
			}
			this.vmethod_0();
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00011B0F File Offset: 0x0000FD0F
	// (set) Token: 0x060019D4 RID: 6612 RVA: 0x00011B17 File Offset: 0x0000FD17
	[DefaultValue(0.3f)]
	[Description("Scale")]
	public float Single_0
	{
		get
		{
			return this.float_0;
		}
		set
		{
			this.float_0 = value;
			this.method_1();
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00011B26 File Offset: 0x0000FD26
	// (set) Token: 0x060019D6 RID: 6614 RVA: 0x00011B2E File Offset: 0x0000FD2E
	[Description("Scrollbar visibility")]
	[DefaultValue(true)]
	public bool Boolean_0
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			this.method_1();
		}
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x00011B3D File Offset: 0x0000FD3D
	private void method_0(object sender, EventArgs e)
	{
		if (this.bool_0)
		{
			base.Invalidate();
		}
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x00011B4D File Offset: 0x0000FD4D
	protected virtual void vmethod_0()
	{
		this.method_1();
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, EventArgs.Empty);
		}
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x00011B6E File Offset: 0x0000FD6E
	protected virtual void vmethod_1(Control3 control3_1)
	{
		control3_1.Scroll -= this.vmethod_5;
		control3_1.Event_9 -= this.vmethod_4;
		control3_1.Event_7 -= this.vmethod_3;
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x00011BA9 File Offset: 0x0000FDA9
	protected virtual void vmethod_2(Control3 control3_1)
	{
		control3_1.Scroll += this.vmethod_5;
		control3_1.Event_9 += this.vmethod_4;
		control3_1.Event_7 += this.vmethod_3;
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x00011BE4 File Offset: 0x0000FDE4
	protected virtual void vmethod_3(object sender, EventArgs e)
	{
		this.method_1();
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x00011BE4 File Offset: 0x0000FDE4
	protected virtual void vmethod_4(object sender, EventArgs e)
	{
		this.method_1();
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x00011BE4 File Offset: 0x0000FDE4
	protected virtual void vmethod_5(object sender, ScrollEventArgs e)
	{
		this.method_1();
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x00011BEC File Offset: 0x0000FDEC
	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		this.method_1();
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00011BFB File Offset: 0x0000FDFB
	public void method_1()
	{
		this.bool_0 = true;
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x000D01DC File Offset: 0x000CE3DC
	protected override void OnPaint(PaintEventArgs e)
	{
		if (this.control3_0 == null)
		{
			return;
		}
		float num = this.Single_0 * 100f / (float)this.control3_0.Int32_21;
		if (num <= 1E-45f)
		{
			return;
		}
		Class357 class357_ = this.control3_0.Class357_4;
		if (this.gstruct19_0.int_1 > class357_.GStruct19_0.int_1)
		{
			this.gstruct19_0.int_1 = class357_.GStruct19_0.int_1;
		}
		else
		{
			Point point = this.control3_0.method_93(class357_.GStruct19_1);
			point.Offset(0, -(int)((float)base.ClientSize.Height / num) + this.control3_0.Int32_2);
			GStruct19 gstruct = this.control3_0.method_82(point);
			if (gstruct.int_1 > this.gstruct19_0.int_1)
			{
				this.gstruct19_0.int_1 = gstruct.int_1;
			}
		}
		this.gstruct19_0.int_0 = 0;
		int count = this.control3_0.IList_0.Count;
		float num2 = (float)class357_.GStruct19_0.int_1 / (float)count;
		float num3 = (float)class357_.GStruct19_1.int_1 / (float)count;
		e.Graphics.ScaleTransform(num, num);
		SizeF sizeF = new SizeF((float)base.ClientSize.Width / num, (float)base.ClientSize.Height / num);
		this.control3_0.method_68(e.Graphics, this.gstruct19_0, sizeF.ToSize());
		Point point2 = this.control3_0.method_93(this.gstruct19_0);
		Point point3 = this.control3_0.method_93(class357_.GStruct19_0);
		Point point4 = this.control3_0.method_93(class357_.GStruct19_1);
		int num4 = point3.Y - point2.Y;
		int num5 = point4.Y + this.control3_0.Int32_2 - point2.Y;
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(50, this.ForeColor)))
		{
			using (Pen pen = new Pen(solidBrush, 1f / num))
			{
				Rectangle rectangle = new Rectangle(0, num4, (int)((float)(base.ClientSize.Width - 1) / num), num5 - num4);
				e.Graphics.FillRectangle(solidBrush, rectangle);
				e.Graphics.DrawRectangle(pen, rectangle);
			}
		}
		if (this.bool_1)
		{
			e.Graphics.ResetTransform();
			e.Graphics.SmoothingMode = SmoothingMode.None;
			using (SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(200, this.ForeColor)))
			{
				RectangleF rectangleF = new RectangleF((float)(base.ClientSize.Width - 3), (float)base.ClientSize.Height * num2, 2f, (float)base.ClientSize.Height * (num3 - num2));
				e.Graphics.FillRectangle(solidBrush2, rectangleF);
			}
		}
		this.bool_0 = false;
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x00011C04 File Offset: 0x0000FE04
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.method_2(e.Location);
		}
		base.OnMouseDown(e);
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00011C26 File Offset: 0x0000FE26
	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.method_2(e.Location);
		}
		base.OnMouseMove(e);
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x000D0514 File Offset: 0x000CE714
	private void method_2(Point point_0)
	{
		if (this.control3_0 == null)
		{
			return;
		}
		float num = this.Single_0 * 100f / (float)this.control3_0.Int32_21;
		if (num <= 1E-45f)
		{
			return;
		}
		Point point = this.control3_0.method_93(this.gstruct19_0);
		point = new Point(0, point.Y + (int)((float)point_0.Y / num));
		GStruct19 gstruct = this.control3_0.method_82(point);
		this.control3_0.method_53(new Class357(this.control3_0, gstruct, gstruct), true);
		base.BeginInvoke(new MethodInvoker(this.method_3));
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x00011C48 File Offset: 0x0000FE48
	private void method_3()
	{
		this.Refresh();
		this.control3_0.Refresh();
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x00011C5B File Offset: 0x0000FE5B
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Application.Idle -= this.method_0;
			if (this.control3_0 != null)
			{
				this.vmethod_1(this.control3_0);
			}
		}
		base.Dispose(disposing);
	}

	// Token: 0x040010AE RID: 4270
	private bool bool_0 = true;

	// Token: 0x040010AF RID: 4271
	private float float_0 = 0.3f;

	// Token: 0x040010B0 RID: 4272
	private bool bool_1 = true;

	// Token: 0x040010B1 RID: 4273
	private GStruct19 gstruct19_0 = GStruct19.GStruct19_0;

	// Token: 0x040010B2 RID: 4274
	private Control3 control3_0;

	// Token: 0x040010B3 RID: 4275
	public EventHandler eventHandler_0;
}
