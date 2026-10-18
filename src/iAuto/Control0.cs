using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x020001A1 RID: 417
[DefaultProperty("BarInnerColor")]
[DefaultEvent("Scroll")]
[ToolboxBitmap(typeof(TrackBar))]
internal class Control0 : Control
{
	// Token: 0x060017D5 RID: 6101 RVA: 0x000C89F8 File Offset: 0x000C6BF8
	public Control0(int int_5, int int_6, int int_7)
	{
		Color[,] array = new Color[4, 8];
		array[0, 0] = Color.White;
		array[0, 1] = Color.Gainsboro;
		array[0, 2] = Color.Silver;
		array[0, 3] = Color.SkyBlue;
		array[0, 4] = Color.DarkSlateBlue;
		array[0, 5] = Color.Gainsboro;
		array[0, 6] = Color.DarkGreen;
		array[0, 7] = Color.Chartreuse;
		array[1, 0] = Color.White;
		array[1, 1] = Color.Gainsboro;
		array[1, 2] = Color.Silver;
		array[1, 3] = Color.Red;
		array[1, 4] = Color.DarkRed;
		array[1, 5] = Color.Gainsboro;
		array[1, 6] = Color.Coral;
		array[1, 7] = Color.LightCoral;
		array[2, 0] = Color.White;
		array[2, 1] = Color.Gainsboro;
		array[2, 2] = Color.Silver;
		array[2, 3] = Color.GreenYellow;
		array[2, 4] = Color.Yellow;
		array[2, 5] = Color.Gold;
		array[2, 6] = Color.Orange;
		array[2, 7] = Color.OrangeRed;
		array[3, 0] = Color.White;
		array[3, 1] = Color.Gainsboro;
		array[3, 2] = Color.Silver;
		array[3, 3] = Color.Red;
		array[3, 4] = Color.Crimson;
		array[3, 5] = Color.Gainsboro;
		array[3, 6] = Color.DarkViolet;
		array[3, 7] = Color.Violet;
		this.color_0 = array;
		this.color_1 = Color.DarkSlateBlue;
		this.int_0 = 100;
		this.color_2 = Color.SkyBlue;
		this.color_3 = Color.Gainsboro;
		this.size_0 = new Size(8, 8);
		this.bool_0 = true;
		this.bool_1 = true;
		this.color_4 = Color.Chartreuse;
		this.color_5 = Color.DarkGreen;
		this.bool_2 = true;
		this.int_2 = 10;
		this.color_6 = Color.Gainsboro;
		this.color_7 = Color.White;
		this.color_8 = Color.Silver;
		this.size_1 = new Size(8, 8);
		this.int_3 = 15;
		this.int_4 = 50;
		this.UInt32_0 = 1U;
		this.UInt32_1 = 5U;
		this.method_2();
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.BackColor = Color.Transparent;
		this.Int32_2 = int_5;
		this.Int32_3 = int_6;
		this.Int32_1 = int_7;
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x00010765 File Offset: 0x0000E965
	public Control0()
		: this(0, 100, 50)
	{
	}

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00010772 File Offset: 0x0000E972
	[Browsable(false)]
	public Rectangle Rectangle_0
	{
		get
		{
			return this.rectangle_4;
		}
	}

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0001077A File Offset: 0x0000E97A
	// (set) Token: 0x060017D9 RID: 6105 RVA: 0x000C8CA0 File Offset: 0x000C6EA0
	[Description("Set Slider thumb size")]
	[Category("ColorSlider")]
	[DefaultValue(15)]
	public int Int32_0
	{
		get
		{
			return this.int_3;
		}
		set
		{
			if (!((value > 0) & (value < ((this.orientation_0 == Orientation.Horizontal) ? base.ClientRectangle.Width : base.ClientRectangle.Height))))
			{
				throw new ArgumentOutOfRangeException("TrackSize has to be greather than zero and lower than half of Slider width");
			}
			this.int_3 = value;
			base.Invalidate();
		}
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x060017DA RID: 6106 RVA: 0x00010782 File Offset: 0x0000E982
	// (set) Token: 0x060017DB RID: 6107 RVA: 0x000C8CF8 File Offset: 0x000C6EF8
	[Description("Set Slider's thumb's custom shape")]
	[Category("ColorSlider")]
	[Browsable(false)]
	[DefaultValue(typeof(GraphicsPath), "null")]
	public GraphicsPath GraphicsPath_0
	{
		get
		{
			return this.graphicsPath_0;
		}
		set
		{
			this.graphicsPath_0 = value;
			this.int_3 = (int)((this.orientation_0 == Orientation.Horizontal) ? value.GetBounds().Width : value.GetBounds().Height) + 1;
			base.Invalidate();
		}
	}

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x060017DC RID: 6108 RVA: 0x0001078A File Offset: 0x0000E98A
	// (set) Token: 0x060017DD RID: 6109 RVA: 0x000C8D44 File Offset: 0x000C6F44
	[Description("Set Slider's thumb round rect size")]
	[Category("ColorSlider")]
	[DefaultValue(typeof(Size), "8; 8")]
	public Size Size_0
	{
		get
		{
			return this.size_1;
		}
		set
		{
			int num = value.Height;
			int num2 = value.Width;
			if (num <= 0)
			{
				num = 1;
			}
			if (num2 <= 0)
			{
				num2 = 1;
			}
			this.size_1 = new Size(num2, num);
			base.Invalidate();
		}
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x060017DE RID: 6110 RVA: 0x00010792 File Offset: 0x0000E992
	// (set) Token: 0x060017DF RID: 6111 RVA: 0x000C8D80 File Offset: 0x000C6F80
	[Description("Set Slider's border round rect size")]
	[Category("ColorSlider")]
	[DefaultValue(typeof(Size), "8; 8")]
	public Size Size_1
	{
		get
		{
			return this.size_0;
		}
		set
		{
			int num = value.Height;
			int num2 = value.Width;
			if (num <= 0)
			{
				num = 1;
			}
			if (num2 <= 0)
			{
				num2 = 1;
			}
			this.size_0 = new Size(num2, num);
			base.Invalidate();
		}
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0001079A File Offset: 0x0000E99A
	// (set) Token: 0x060017E1 RID: 6113 RVA: 0x000C8DBC File Offset: 0x000C6FBC
	[Category("ColorSlider")]
	[Description("Set Slider orientation")]
	[DefaultValue(Orientation.Horizontal)]
	public Orientation Orientation_0
	{
		get
		{
			return this.orientation_0;
		}
		set
		{
			if (this.orientation_0 != value)
			{
				this.orientation_0 = value;
				int width = base.Width;
				base.Width = base.Height;
				base.Height = width;
				if (this.graphicsPath_0 != null)
				{
					this.int_3 = (int)((this.orientation_0 == Orientation.Horizontal) ? this.graphicsPath_0.GetBounds().Width : this.graphicsPath_0.GetBounds().Height) + 1;
				}
				base.Invalidate();
			}
		}
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x060017E2 RID: 6114 RVA: 0x000107A2 File Offset: 0x0000E9A2
	// (set) Token: 0x060017E3 RID: 6115 RVA: 0x000C8E3C File Offset: 0x000C703C
	[DefaultValue(50)]
	[Category("ColorSlider")]
	[Description("Set Slider value")]
	public int Int32_1
	{
		get
		{
			return this.int_4;
		}
		set
		{
			if ((value >= this.int_1) & (value <= this.int_0))
			{
				this.int_4 = value;
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, new EventArgs());
				}
				base.Invalidate();
				return;
			}
			throw new ArgumentOutOfRangeException("Value is outside appropriate range (min, max)");
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000107AA File Offset: 0x0000E9AA
	// (set) Token: 0x060017E5 RID: 6117 RVA: 0x000C8E98 File Offset: 0x000C7098
	[DefaultValue(0)]
	[Category("ColorSlider")]
	[Description("Set Slider minimal point")]
	public int Int32_2
	{
		get
		{
			return this.int_1;
		}
		set
		{
			if (value < this.int_0)
			{
				this.int_1 = value;
				if (this.int_4 < this.int_1)
				{
					this.int_4 = this.int_1;
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, new EventArgs());
					}
				}
				base.Invalidate();
				return;
			}
			throw new ArgumentOutOfRangeException("Minimal value is greather than maximal one");
		}
	}

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000107B2 File Offset: 0x0000E9B2
	// (set) Token: 0x060017E7 RID: 6119 RVA: 0x000C8EFC File Offset: 0x000C70FC
	[DefaultValue(100)]
	[Category("ColorSlider")]
	[Description("Set Slider maximal point")]
	public int Int32_3
	{
		get
		{
			return this.int_0;
		}
		set
		{
			if (value > this.int_1)
			{
				this.int_0 = value;
				if (this.int_4 > this.int_0)
				{
					this.int_4 = this.int_0;
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, new EventArgs());
					}
				}
				base.Invalidate();
				return;
			}
			throw new ArgumentOutOfRangeException("Maximal value is lower than minimal one");
		}
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000107BA File Offset: 0x0000E9BA
	// (set) Token: 0x060017E9 RID: 6121 RVA: 0x000107C2 File Offset: 0x0000E9C2
	[DefaultValue(1)]
	[Category("ColorSlider")]
	[Description("Set trackbar's small change")]
	public uint UInt32_0 { get; set; }

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x060017EA RID: 6122 RVA: 0x000107CB File Offset: 0x0000E9CB
	// (set) Token: 0x060017EB RID: 6123 RVA: 0x000107D3 File Offset: 0x0000E9D3
	[DefaultValue(5)]
	[Category("ColorSlider")]
	[Description("Set trackbar's large change")]
	public uint UInt32_1 { get; set; }

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x000107DC File Offset: 0x0000E9DC
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x000107E4 File Offset: 0x0000E9E4
	[DefaultValue(true)]
	[Category("ColorSlider")]
	[Description("Set whether to draw focus rectangle")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x060017EE RID: 6126 RVA: 0x000107F3 File Offset: 0x0000E9F3
	// (set) Token: 0x060017EF RID: 6127 RVA: 0x000107FB File Offset: 0x0000E9FB
	[DefaultValue(true)]
	[Category("ColorSlider")]
	[Description("Set whether to draw semitransparent thumb")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0001080A File Offset: 0x0000EA0A
	// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00010812 File Offset: 0x0000EA12
	[DefaultValue(true)]
	[Category("ColorSlider")]
	[Description("Set whether mouse entry and exit actions have impact on how control look")]
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00010821 File Offset: 0x0000EA21
	// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00010829 File Offset: 0x0000EA29
	[DefaultValue(10)]
	[Category("ColorSlider")]
	[Description("Set to how many parts is bar divided when using mouse wheel")]
	public int Int32_4
	{
		get
		{
			return this.int_2;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("MouseWheelBarPartitions has to be greather than zero");
			}
			this.int_2 = value;
		}
	}

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00010841 File Offset: 0x0000EA41
	// (set) Token: 0x060017F5 RID: 6133 RVA: 0x00010849 File Offset: 0x0000EA49
	[DefaultValue(typeof(Color), "White")]
	[Category("ColorSlider")]
	[Description("Set Slider thumb outer color")]
	public Color Color_0
	{
		get
		{
			return this.color_7;
		}
		set
		{
			this.color_7 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00010858 File Offset: 0x0000EA58
	// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00010860 File Offset: 0x0000EA60
	[DefaultValue(typeof(Color), "Gainsboro")]
	[Category("ColorSlider")]
	[Description("Set Slider thumb inner color")]
	public Color Color_1
	{
		get
		{
			return this.color_6;
		}
		set
		{
			this.color_6 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0001086F File Offset: 0x0000EA6F
	// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00010877 File Offset: 0x0000EA77
	[DefaultValue(typeof(Color), "Silver")]
	[Category("ColorSlider")]
	[Description("Set Slider thumb pen color")]
	public Color Color_2
	{
		get
		{
			return this.color_8;
		}
		set
		{
			this.color_8 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x060017FA RID: 6138 RVA: 0x00010886 File Offset: 0x0000EA86
	// (set) Token: 0x060017FB RID: 6139 RVA: 0x0001088E File Offset: 0x0000EA8E
	[DefaultValue(typeof(Color), "SkyBlue")]
	[Category("ColorSlider")]
	[Description("Set Slider bar outer color")]
	public Color Color_3
	{
		get
		{
			return this.color_2;
		}
		set
		{
			this.color_2 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x0001089D File Offset: 0x0000EA9D
	// (set) Token: 0x060017FD RID: 6141 RVA: 0x000108A5 File Offset: 0x0000EAA5
	[DefaultValue(typeof(Color), "DarkSlateBlue")]
	[Category("ColorSlider")]
	[Description("Set Slider bar inner color")]
	public Color Color_4
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

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x060017FE RID: 6142 RVA: 0x000108B4 File Offset: 0x0000EAB4
	// (set) Token: 0x060017FF RID: 6143 RVA: 0x000108BC File Offset: 0x0000EABC
	[DefaultValue(typeof(Color), "Gainsboro")]
	[Category("ColorSlider")]
	[Description("Set Slider bar pen color")]
	public Color Color_5
	{
		get
		{
			return this.color_3;
		}
		set
		{
			this.color_3 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06001800 RID: 6144 RVA: 0x000108CB File Offset: 0x0000EACB
	// (set) Token: 0x06001801 RID: 6145 RVA: 0x000108D3 File Offset: 0x0000EAD3
	[DefaultValue(typeof(Color), "DarkGreen")]
	[Category("ColorSlider")]
	[Description("Set Slider's elapsed part outer color")]
	public Color Color_6
	{
		get
		{
			return this.color_5;
		}
		set
		{
			this.color_5 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001802 RID: 6146 RVA: 0x000108E2 File Offset: 0x0000EAE2
	// (set) Token: 0x06001803 RID: 6147 RVA: 0x000108EA File Offset: 0x0000EAEA
	[DefaultValue(typeof(Color), "Chartreuse")]
	[Category("ColorSlider")]
	[Description("Set Slider's elapsed part inner color")]
	public Color Color_7
	{
		get
		{
			return this.color_4;
		}
		set
		{
			this.color_4 = value;
			base.Invalidate();
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001804 RID: 6148 RVA: 0x000108F9 File Offset: 0x0000EAF9
	// (set) Token: 0x06001805 RID: 6149 RVA: 0x000C8F60 File Offset: 0x000C7160
	[DefaultValue(typeof(Control0.Enum13), "PerlBlueGreen")]
	[Category("ColorSlider")]
	[Description("Set Slider color schema. Has no effect when slider colors are changed manually after schema was applied.")]
	public Control0.Enum13 Enum13_0
	{
		get
		{
			return this.enum13_0;
		}
		set
		{
			this.enum13_0 = value;
			byte b = (byte)value;
			this.color_7 = this.color_0[(int)b, 0];
			this.color_6 = this.color_0[(int)b, 1];
			this.color_8 = this.color_0[(int)b, 2];
			this.color_2 = this.color_0[(int)b, 3];
			this.color_1 = this.color_0[(int)b, 4];
			this.color_3 = this.color_0[(int)b, 5];
			this.color_5 = this.color_0[(int)b, 6];
			this.color_4 = this.color_0[(int)b, 7];
			base.Invalidate();
		}
	}

	// Token: 0x1400001B RID: 27
	// (add) Token: 0x06001806 RID: 6150 RVA: 0x000C9018 File Offset: 0x000C7218
	// (remove) Token: 0x06001807 RID: 6151 RVA: 0x000C9050 File Offset: 0x000C7250
	[Description("Event fires when the Value property changes")]
	[Category("Action")]
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

	// Token: 0x1400001C RID: 28
	// (add) Token: 0x06001808 RID: 6152 RVA: 0x000C9088 File Offset: 0x000C7288
	// (remove) Token: 0x06001809 RID: 6153 RVA: 0x000C90C0 File Offset: 0x000C72C0
	[Category("Behavior")]
	[Description("Event fires when the Slider position is changed")]
	public event ScrollEventHandler Event_1
	{
		[CompilerGenerated]
		add
		{
			ScrollEventHandler scrollEventHandler = this.scrollEventHandler_0;
			ScrollEventHandler scrollEventHandler2;
			do
			{
				scrollEventHandler2 = scrollEventHandler;
				ScrollEventHandler scrollEventHandler3 = (ScrollEventHandler)Delegate.Combine(scrollEventHandler2, value);
				scrollEventHandler = Interlocked.CompareExchange<ScrollEventHandler>(ref this.scrollEventHandler_0, scrollEventHandler3, scrollEventHandler2);
			}
			while (scrollEventHandler != scrollEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ScrollEventHandler scrollEventHandler = this.scrollEventHandler_0;
			ScrollEventHandler scrollEventHandler2;
			do
			{
				scrollEventHandler2 = scrollEventHandler;
				ScrollEventHandler scrollEventHandler3 = (ScrollEventHandler)Delegate.Remove(scrollEventHandler2, value);
				scrollEventHandler = Interlocked.CompareExchange<ScrollEventHandler>(ref this.scrollEventHandler_0, scrollEventHandler3, scrollEventHandler2);
			}
			while (scrollEventHandler != scrollEventHandler2);
		}
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x000C90F8 File Offset: 0x000C72F8
	protected override void OnPaint(PaintEventArgs e)
	{
		if (!base.Enabled)
		{
			Color[] array = Control0.smethod_1(new Color[] { this.color_7, this.color_6, this.color_8, this.color_2, this.color_1, this.color_3, this.color_5, this.color_4 });
			this.method_0(e, array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7]);
			return;
		}
		if (this.bool_2 && this.bool_3)
		{
			Color[] array2 = Control0.smethod_2(new Color[] { this.color_7, this.color_6, this.color_8, this.color_2, this.color_1, this.color_3, this.color_5, this.color_4 });
			this.method_0(e, array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7]);
			return;
		}
		this.method_0(e, this.color_7, this.color_6, this.color_8, this.color_2, this.color_1, this.color_3, this.color_5, this.color_4);
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x000C92C8 File Offset: 0x000C74C8
	private void method_0(PaintEventArgs paintEventArgs_0, Color color_9, Color color_10, Color color_11, Color color_12, Color color_13, Color color_14, Color color_15, Color color_16)
	{
		try
		{
			if (this.orientation_0 == Orientation.Horizontal)
			{
				int num = (this.int_4 - this.int_1) * (base.ClientRectangle.Width - this.int_3) / (this.int_0 - this.int_1);
				this.rectangle_4 = new Rectangle(num, 1, this.int_3 - 1, base.ClientRectangle.Height - 3);
			}
			else
			{
				int num2 = (this.int_4 - this.int_1) * (base.ClientRectangle.Height - this.int_3) / (this.int_0 - this.int_1);
				this.rectangle_4 = new Rectangle(1, num2, base.ClientRectangle.Width - 3, this.int_3 - 1);
			}
			this.rectangle_1 = base.ClientRectangle;
			this.rectangle_3 = this.rectangle_4;
			LinearGradientMode linearGradientMode;
			if (this.orientation_0 == Orientation.Horizontal)
			{
				this.rectangle_1.Inflate(-1, -this.rectangle_1.Height / 3);
				this.rectangle_0 = this.rectangle_1;
				this.rectangle_0.Height = this.rectangle_0.Height / 2;
				linearGradientMode = LinearGradientMode.Vertical;
				this.rectangle_3.Height = this.rectangle_3.Height / 2;
				this.rectangle_2 = this.rectangle_1;
				this.rectangle_2.Width = this.rectangle_4.Left + this.int_3 / 2;
			}
			else
			{
				this.rectangle_1.Inflate(-this.rectangle_1.Width / 3, -1);
				this.rectangle_0 = this.rectangle_1;
				this.rectangle_0.Width = this.rectangle_0.Width / 2;
				linearGradientMode = LinearGradientMode.Horizontal;
				this.rectangle_3.Width = this.rectangle_3.Width / 2;
				this.rectangle_2 = this.rectangle_1;
				this.rectangle_2.Height = this.rectangle_4.Top + this.int_3 / 2;
			}
			GraphicsPath graphicsPath;
			if (this.graphicsPath_0 == null)
			{
				graphicsPath = Control0.smethod_0(this.rectangle_4, this.size_1);
			}
			else
			{
				graphicsPath = this.graphicsPath_0;
				Matrix matrix = new Matrix();
				matrix.Translate((float)this.rectangle_4.Left - graphicsPath.GetBounds().Left, (float)this.rectangle_4.Top - graphicsPath.GetBounds().Top);
				graphicsPath.Transform(matrix);
			}
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.rectangle_0, color_12, color_13, linearGradientMode))
			{
				linearGradientBrush.WrapMode = WrapMode.TileFlipXY;
				paintEventArgs_0.Graphics.FillRectangle(linearGradientBrush, this.rectangle_1);
				using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(this.rectangle_0, color_15, color_16, linearGradientMode))
				{
					linearGradientBrush2.WrapMode = WrapMode.TileFlipXY;
					if (base.Capture && this.bool_1)
					{
						Region region = new Region(this.rectangle_2);
						region.Exclude(graphicsPath);
						paintEventArgs_0.Graphics.FillRegion(linearGradientBrush2, region);
					}
					else
					{
						paintEventArgs_0.Graphics.FillRectangle(linearGradientBrush2, this.rectangle_2);
					}
				}
				using (Pen pen = new Pen(color_14, 0.5f))
				{
					paintEventArgs_0.Graphics.DrawRectangle(pen, this.rectangle_1);
				}
			}
			Color color = color_9;
			Color color2 = color_10;
			if (base.Capture && this.bool_1)
			{
				color = Color.FromArgb(175, color_9);
				color2 = Color.FromArgb(175, color_10);
			}
			using (LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(this.rectangle_3, color, color2, linearGradientMode))
			{
				linearGradientBrush3.WrapMode = WrapMode.TileFlipXY;
				paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				paintEventArgs_0.Graphics.FillPath(linearGradientBrush3, graphicsPath);
				Color color3 = color_11;
				if (this.bool_2 && (base.Capture || this.bool_4))
				{
					color3 = ControlPaint.Dark(color3);
				}
				using (Pen pen2 = new Pen(color3))
				{
					paintEventArgs_0.Graphics.DrawPath(pen2, graphicsPath);
				}
			}
			if (this.Focused & this.bool_0)
			{
				using (Pen pen3 = new Pen(Color.FromArgb(200, color_14)))
				{
					pen3.DashStyle = DashStyle.Dot;
					Rectangle clientRectangle = base.ClientRectangle;
					clientRectangle.Width -= 2;
					int num3 = clientRectangle.Height;
					clientRectangle.Height = num3 - 1;
					num3 = clientRectangle.X;
					clientRectangle.X = num3 + 1;
					using (GraphicsPath graphicsPath2 = Control0.smethod_0(clientRectangle, this.size_0))
					{
						paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
						paintEventArgs_0.Graphics.DrawPath(pen3, graphicsPath2);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("DrawBackGround Error in " + base.Name + ":" + ex.Message);
		}
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00010901 File Offset: 0x0000EB01
	protected override void OnEnabledChanged(EventArgs e)
	{
		base.OnEnabledChanged(e);
		base.Invalidate();
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00010910 File Offset: 0x0000EB10
	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.bool_3 = true;
		base.Invalidate();
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00010926 File Offset: 0x0000EB26
	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.bool_3 = false;
		this.bool_4 = false;
		base.Invalidate();
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x000C9848 File Offset: 0x000C7A48
	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (e.Button == MouseButtons.Left)
		{
			base.Capture = true;
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.ThumbTrack, this.int_4));
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs());
			}
			this.OnMouseMove(e);
		}
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x000C98B0 File Offset: 0x000C7AB0
	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.bool_4 = Control0.smethod_3(e.Location, this.rectangle_4);
		if (base.Capture & (e.Button == MouseButtons.Left))
		{
			ScrollEventType scrollEventType = ScrollEventType.ThumbPosition;
			Point location = e.Location;
			int num = ((this.orientation_0 == Orientation.Horizontal) ? location.X : location.Y);
			int num2 = this.int_3 >> 1;
			num -= num2;
			float num3 = (float)(this.int_0 - this.int_1) / (float)(((this.orientation_0 == Orientation.Horizontal) ? base.ClientSize.Width : base.ClientSize.Height) - 2 * num2);
			this.int_4 = (int)((float)num * num3 + (float)this.int_1);
			if (this.int_4 <= this.int_1)
			{
				this.int_4 = this.int_1;
				scrollEventType = ScrollEventType.First;
			}
			else if (this.int_4 >= this.int_0)
			{
				this.int_4 = this.int_0;
				scrollEventType = ScrollEventType.Last;
			}
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(scrollEventType, this.int_4));
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs());
			}
		}
		base.Invalidate();
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x000C99F0 File Offset: 0x000C7BF0
	protected override void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		base.Capture = false;
		this.bool_4 = Control0.smethod_3(e.Location, this.rectangle_4);
		if (this.scrollEventHandler_0 != null)
		{
			this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.EndScroll, this.int_4));
		}
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, new EventArgs());
		}
		base.Invalidate();
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x00010943 File Offset: 0x0000EB43
	protected override void OnMouseWheel(MouseEventArgs e)
	{
		base.OnMouseWheel(e);
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x0001094C File Offset: 0x0000EB4C
	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		base.Invalidate();
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x0001095B File Offset: 0x0000EB5B
	protected override void OnLostFocus(EventArgs e)
	{
		base.OnLostFocus(e);
		base.Invalidate();
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x000C9A64 File Offset: 0x000C7C64
	protected override void OnKeyUp(KeyEventArgs e)
	{
		base.OnKeyUp(e);
		switch (e.KeyCode)
		{
		case Keys.Prior:
			this.method_1(this.Int32_1 + (int)this.UInt32_1);
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.LargeIncrement, this.Int32_1));
			}
			break;
		case Keys.Next:
			this.method_1(this.Int32_1 - (int)this.UInt32_1);
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.LargeDecrement, this.Int32_1));
			}
			break;
		case Keys.End:
			this.Int32_1 = this.int_0;
			break;
		case Keys.Home:
			this.Int32_1 = this.int_1;
			break;
		case Keys.Left:
		case Keys.Down:
			this.method_1(this.Int32_1 - (int)this.UInt32_0);
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.SmallDecrement, this.Int32_1));
			}
			break;
		case Keys.Up:
		case Keys.Right:
			this.method_1(this.Int32_1 + (int)this.UInt32_0);
			if (this.scrollEventHandler_0 != null)
			{
				this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.SmallIncrement, this.Int32_1));
			}
			break;
		}
		if (this.scrollEventHandler_0 != null && this.Int32_1 == this.int_1)
		{
			this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.First, this.Int32_1));
		}
		if (this.scrollEventHandler_0 != null && this.Int32_1 == this.int_0)
		{
			this.scrollEventHandler_0(this, new ScrollEventArgs(ScrollEventType.Last, this.Int32_1));
		}
		Point point = base.PointToClient(Cursor.Position);
		this.OnMouseMove(new MouseEventArgs(MouseButtons.None, 0, point.X, point.Y, 0));
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x0001096A File Offset: 0x0000EB6A
	protected override bool ProcessDialogKey(Keys keyData)
	{
		if ((keyData == Keys.Tab) | (Control.ModifierKeys == Keys.Shift))
		{
			return base.ProcessDialogKey(keyData);
		}
		this.OnKeyDown(new KeyEventArgs(keyData));
		return true;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x000C9C2C File Offset: 0x000C7E2C
	public static GraphicsPath smethod_0(Rectangle rectangle_5, Size size_2)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine(rectangle_5.Left + size_2.Width / 2, rectangle_5.Top, rectangle_5.Right - size_2.Width / 2, rectangle_5.Top);
		graphicsPath.AddArc(rectangle_5.Right - size_2.Width, rectangle_5.Top, size_2.Width, size_2.Height, 270f, 90f);
		graphicsPath.AddLine(rectangle_5.Right, rectangle_5.Top + size_2.Height / 2, rectangle_5.Right, rectangle_5.Bottom - size_2.Width / 2);
		graphicsPath.AddArc(rectangle_5.Right - size_2.Width, rectangle_5.Bottom - size_2.Height, size_2.Width, size_2.Height, 0f, 90f);
		graphicsPath.AddLine(rectangle_5.Right - size_2.Width / 2, rectangle_5.Bottom, rectangle_5.Left + size_2.Width / 2, rectangle_5.Bottom);
		graphicsPath.AddArc(rectangle_5.Left, rectangle_5.Bottom - size_2.Height, size_2.Width, size_2.Height, 90f, 90f);
		graphicsPath.AddLine(rectangle_5.Left, rectangle_5.Bottom - size_2.Height / 2, rectangle_5.Left, rectangle_5.Top + size_2.Height / 2);
		graphicsPath.AddArc(rectangle_5.Left, rectangle_5.Top, size_2.Width, size_2.Height, 180f, 90f);
		return graphicsPath;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x000C9DE8 File Offset: 0x000C7FE8
	public static Color[] smethod_1(params Color[] color_9)
	{
		Color[] array = new Color[color_9.Length];
		for (int i = 0; i < color_9.Length; i++)
		{
			int num = (int)((double)color_9[i].R * 0.3 + (double)color_9[i].G * 0.6 + (double)color_9[i].B * 0.1);
			array[i] = Color.FromArgb(-65793 * (255 - num) - 1);
		}
		return array;
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x000C9E74 File Offset: 0x000C8074
	public static Color[] smethod_2(params Color[] color_9)
	{
		Color[] array = new Color[color_9.Length];
		for (int i = 0; i < color_9.Length; i++)
		{
			array[i] = ControlPaint.Light(color_9[i]);
		}
		return array;
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x00010995 File Offset: 0x0000EB95
	private void method_1(int int_5)
	{
		if (int_5 < this.int_1)
		{
			this.Int32_1 = this.int_1;
			return;
		}
		if (int_5 > this.int_0)
		{
			this.Int32_1 = this.int_0;
			return;
		}
		this.Int32_1 = int_5;
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x000C9EAC File Offset: 0x000C80AC
	private static bool smethod_3(Point point_0, Rectangle rectangle_5)
	{
		return (point_0.X > rectangle_5.Left) & (point_0.X < rectangle_5.Right) & (point_0.Y > rectangle_5.Top) & (point_0.Y < rectangle_5.Bottom);
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x000109CA File Offset: 0x0000EBCA
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x000109E9 File Offset: 0x0000EBE9
	private void method_2()
	{
		base.SuspendLayout();
		base.Size = new Size(200, 30);
		base.ResumeLayout(false);
	}

	// Token: 0x04000F61 RID: 3937
	private readonly Color[,] color_0;

	// Token: 0x04000F62 RID: 3938
	private Rectangle rectangle_0;

	// Token: 0x04000F63 RID: 3939
	private Color color_1;

	// Token: 0x04000F64 RID: 3940
	private int int_0;

	// Token: 0x04000F65 RID: 3941
	private int int_1;

	// Token: 0x04000F66 RID: 3942
	private Orientation orientation_0;

	// Token: 0x04000F67 RID: 3943
	private Color color_2;

	// Token: 0x04000F68 RID: 3944
	private Color color_3;

	// Token: 0x04000F69 RID: 3945
	private Rectangle rectangle_1;

	// Token: 0x04000F6A RID: 3946
	private Size size_0;

	// Token: 0x04000F6B RID: 3947
	private Control0.Enum13 enum13_0;

	// Token: 0x04000F6C RID: 3948
	private bool bool_0;

	// Token: 0x04000F6D RID: 3949
	private bool bool_1;

	// Token: 0x04000F6E RID: 3950
	private Color color_4;

	// Token: 0x04000F6F RID: 3951
	private Color color_5;

	// Token: 0x04000F70 RID: 3952
	private Rectangle rectangle_2;

	// Token: 0x04000F71 RID: 3953
	private bool bool_2;

	// Token: 0x04000F72 RID: 3954
	private bool bool_3;

	// Token: 0x04000F73 RID: 3955
	private bool bool_4;

	// Token: 0x04000F74 RID: 3956
	private int int_2;

	// Token: 0x04000F75 RID: 3957
	private GraphicsPath graphicsPath_0;

	// Token: 0x04000F76 RID: 3958
	private Rectangle rectangle_3;

	// Token: 0x04000F77 RID: 3959
	private Color color_6;

	// Token: 0x04000F78 RID: 3960
	private Color color_7;

	// Token: 0x04000F79 RID: 3961
	private Color color_8;

	// Token: 0x04000F7A RID: 3962
	private Rectangle rectangle_4;

	// Token: 0x04000F7B RID: 3963
	private Size size_1;

	// Token: 0x04000F7C RID: 3964
	private int int_3;

	// Token: 0x04000F7D RID: 3965
	private int int_4;

	// Token: 0x04000F7E RID: 3966
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000F7F RID: 3967
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000F80 RID: 3968
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x04000F81 RID: 3969
	[CompilerGenerated]
	private ScrollEventHandler scrollEventHandler_0;

	// Token: 0x04000F82 RID: 3970
	private IContainer icontainer_0;

	// Token: 0x020001A2 RID: 418
	public enum Enum13
	{
		// Token: 0x04000F84 RID: 3972
		PerlBlueGreen,
		// Token: 0x04000F85 RID: 3973
		PerlRedCoral,
		// Token: 0x04000F86 RID: 3974
		PerlGold,
		// Token: 0x04000F87 RID: 3975
		PerlRoyalColors
	}
}
