using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.Win32;
using _i;

// Token: 0x020001EB RID: 491
internal class Control3 : UserControl, ISupportInitialize
{
	// Token: 0x06001A12 RID: 6674 RVA: 0x000D1910 File Offset: 0x000CFB10
	public Control3()
	{
		TypeDescriptionProvider provider = TypeDescriptor.GetProvider(base.GetType());
		if (provider.GetType().GetField("Provider", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(provider)
			.GetType() != typeof(Class383))
		{
			TypeDescriptor.AddProvider(new Class383(base.GetType()), base.GetType());
		}
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.Font = new Font(FontFamily.GenericMonospace, 9.75f);
		this.vmethod_7(this.vmethod_6());
		if (this.class381_0.Count == 0)
		{
			this.class381_0.m_559E6352(0, this.class381_0.vmethod_0());
		}
		this.class357_0 = new Class357(this)
		{
			GStruct19_0 = new GStruct19(0, 0)
		};
		this.Cursor = Cursors.IBeam;
		this.BackColor = Color.White;
		this.Color_4 = Color.Teal;
		this.Color_5 = Color.WhiteSmoke;
		this.Color_9 = Color.Silver;
		this.Color_10 = Color.Green;
		this.Color_2 = Color.Transparent;
		this.Color_3 = Color.Transparent;
		this.Boolean_14 = true;
		this.Boolean_10 = true;
		this.Int32_5 = 4;
		this.Class369_1 = new Class370(Brushes.Gray, null, FontStyle.Regular);
		this.Color_11 = Color.Blue;
		this.Class372_0 = new Class372(new SolidBrush(Color.FromArgb(80, Color.Lime)));
		this.Class372_1 = new Class372(new SolidBrush(Color.FromArgb(60, Color.Red)));
		this.Int32_10 = 100;
		this.Int32_11 = 100;
		this.Boolean_16 = false;
		this.Char_1 = '\0';
		this.Char_2 = '\0';
		this.Char_3 = '\0';
		this.Char_4 = '\0';
		this.Class379_0 = new Class379(this);
		this.genum21_0 = GEnum21.Custom;
		this.Int32_9 = 0;
		this.bool_11 = true;
		this.dateTime_0 = DateTime.Now;
		this.Boolean_18 = true;
		this.Boolean_19 = true;
		this.String_1 = "//";
		this.uint_0 = 1U;
		this.bool_10 = true;
		this.bool_17 = true;
		this.Boolean_3 = true;
		this.Boolean_4 = true;
		this.bool_1 = true;
		this.Color_8 = Color.Black;
		this.Boolean_12 = false;
		this.Padding_0 = new Padding(0, 0, 0, 0);
		this.Color_6 = Color.Transparent;
		this.Color_7 = Color.FromArgb(100, 180, 180, 180);
		this.bool_12 = true;
		this.AllowDrop = true;
		this.GEnum14_0 = GEnum14.Strategy1;
		this.Boolean_2 = false;
		this.Class308_0 = new Class309(this);
		this.Color_0 = Color.PowderBlue;
		this.ToolTip_0 = new ToolTip();
		this.timer_2.Interval = 500;
		this.Class344_0 = new Class344(this);
		this.Boolean_24 = true;
		this.genum16_0 = GEnum16.None;
		this.color_8 = Color.Black;
		this.Class355_0 = new Class355(this);
		this.Class347_0 = new Class347();
		this.Class347_0.vmethod_0();
		this.Boolean_1 = true;
		this.Dictionary_0 = new Dictionary<int, int>();
		this.Boolean_0 = false;
		this.String_6 = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
		this.Boolean_28 = true;
		this.Boolean_6 = true;
		this.Class342_0 = new Class342();
		base.AutoScroll = true;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_1.Tick += this.timer_1_Tick;
		this.timer_2.Tick += this.timer_2_Tick;
		this.timer_3.Tick += this.timer_3_Tick;
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00011DFD File Offset: 0x0000FFFD
	// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00011E05 File Offset: 0x00010005
	public char[] Char_0 { get; set; } = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00011E0E File Offset: 0x0001000E
	// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00011E16 File Offset: 0x00010016
	[Description("AutoComplete brackets.")]
	[DefaultValue(false)]
	public bool Boolean_0 { get; set; }

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00011E1F File Offset: 0x0001001F
	// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00011E27 File Offset: 0x00010027
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("Colors of some service visual markers.")]
	[Browsable(true)]
	public Class342 Class342_0 { get; set; }

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00011E30 File Offset: 0x00010030
	[Browsable(false)]
	public Dictionary<int, int> Dictionary_0 { get; }

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00011E38 File Offset: 0x00010038
	// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00011E40 File Offset: 0x00010040
	[Description("Strategy of search of brackets to highlighting.")]
	[DefaultValue(typeof(GEnum15), "Strategy1")]
	public GEnum15 GEnum15_0 { get; set; }

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00011E49 File Offset: 0x00010049
	// (set) Token: 0x06001A1D RID: 6685 RVA: 0x00011E51 File Offset: 0x00010051
	[Description("Automatically shifts secondary wordwrap lines on the shift amount of the first line.")]
	[DefaultValue(true)]
	public bool Boolean_1 { get; set; }

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00011E5A File Offset: 0x0001005A
	// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00011E62 File Offset: 0x00010062
	[DefaultValue(0)]
	[Description("Indent of secondary wordwrap lines (in chars).")]
	public int Int32_0 { get; set; }

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00011E6B File Offset: 0x0001006B
	[Browsable(false)]
	public Class355 Class355_0 { get; }

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00011E73 File Offset: 0x00010073
	// (set) Token: 0x06001A22 RID: 6690 RVA: 0x00011E7B File Offset: 0x0001007B
	[Description("Allows drag and drop")]
	[DefaultValue(true)]
	public override bool AllowDrop
	{
		get
		{
			return base.AllowDrop;
		}
		set
		{
			base.AllowDrop = value;
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00011E84 File Offset: 0x00010084
	// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00011E8C File Offset: 0x0001008C
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Class344 Class344_0 { get; set; }

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00011E95 File Offset: 0x00010095
	// (set) Token: 0x06001A26 RID: 6694 RVA: 0x00011EA2 File Offset: 0x000100A2
	[DefaultValue(500)]
	[Browsable(true)]
	[Description("Delay(ms) of ToolTip.")]
	public int Int32_1
	{
		get
		{
			return this.timer_2.Interval;
		}
		set
		{
			this.timer_2.Interval = value;
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00011EB0 File Offset: 0x000100B0
	// (set) Token: 0x06001A28 RID: 6696 RVA: 0x00011EB8 File Offset: 0x000100B8
	[Description("ToolTip component.")]
	[Browsable(true)]
	public ToolTip ToolTip_0 { get; set; }

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00011EC1 File Offset: 0x000100C1
	// (set) Token: 0x06001A2A RID: 6698 RVA: 0x00011EC9 File Offset: 0x000100C9
	[DefaultValue(typeof(Color), "PowderBlue")]
	[Browsable(true)]
	[Description("Color of bookmarks.")]
	public Color Color_0 { get; set; }

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00011ED2 File Offset: 0x000100D2
	// (set) Token: 0x06001A2C RID: 6700 RVA: 0x00011EDA File Offset: 0x000100DA
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Class308 Class308_0 { get; set; }

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00011EE3 File Offset: 0x000100E3
	// (set) Token: 0x06001A2E RID: 6702 RVA: 0x00011EEB File Offset: 0x000100EB
	[DefaultValue(false)]
	[Description("Enables virtual spaces.")]
	public bool Boolean_2 { get; set; }

	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00011EF4 File Offset: 0x000100F4
	// (set) Token: 0x06001A30 RID: 6704 RVA: 0x00011EFC File Offset: 0x000100FC
	[DefaultValue(GEnum14.Strategy1)]
	[Description("Strategy of search of end of folding block.")]
	public GEnum14 GEnum14_0 { get; set; }

	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00011F05 File Offset: 0x00010105
	// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00011F0D File Offset: 0x0001010D
	[DefaultValue(true)]
	[Description("Indicates if tab characters are accepted as input.")]
	public bool Boolean_3 { get; set; }

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00011F16 File Offset: 0x00010116
	// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00011F1E File Offset: 0x0001011E
	[Description("Indicates if return characters are accepted as input.")]
	[DefaultValue(true)]
	public bool Boolean_4 { get; set; }

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00011F27 File Offset: 0x00010127
	// (set) Token: 0x06001A36 RID: 6710 RVA: 0x00011F2F File Offset: 0x0001012F
	[Description("Shows or hides the caret")]
	[DefaultValue(true)]
	public bool Boolean_5
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			this.method_4();
		}
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00011F3E File Offset: 0x0001013E
	// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00011F46 File Offset: 0x00010146
	[Description("Enables caret blinking")]
	[DefaultValue(true)]
	public bool Boolean_6 { get; set; }

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00011F4F File Offset: 0x0001014F
	// (set) Token: 0x06001A3A RID: 6714 RVA: 0x00011F57 File Offset: 0x00010157
	[DefaultValue(false)]
	public bool Boolean_7 { get; set; }

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00011F60 File Offset: 0x00010160
	// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00011F68 File Offset: 0x00010168
	[DefaultValue(typeof(Color), "Black")]
	[Description("Color of border of text area")]
	public Color Color_1
	{
		get
		{
			return this.color_8;
		}
		set
		{
			this.color_8 = value;
			this.method_4();
		}
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00011F77 File Offset: 0x00010177
	// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00011F7F File Offset: 0x0001017F
	[Description("Type of border of text area")]
	[DefaultValue(typeof(GEnum16), "None")]
	public GEnum16 GEnum16_0
	{
		get
		{
			return this.genum16_0;
		}
		set
		{
			this.genum16_0 = value;
			this.method_4();
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00011F8E File Offset: 0x0001018E
	// (set) Token: 0x06001A40 RID: 6720 RVA: 0x00011F96 File Offset: 0x00010196
	[Description("Background color for current line. Set to Color.Transparent to hide current line highlighting")]
	[DefaultValue(typeof(Color), "Transparent")]
	public Color Color_2
	{
		get
		{
			return this.color_1;
		}
		set
		{
			this.color_1 = value;
			this.method_4();
		}
	}

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00011FA5 File Offset: 0x000101A5
	// (set) Token: 0x06001A42 RID: 6722 RVA: 0x00011FAD File Offset: 0x000101AD
	[Description("Background color for highlighting of changed lines. Set to Color.Transparent to hide changed line highlighting")]
	[DefaultValue(typeof(Color), "Transparent")]
	public Color Color_3
	{
		get
		{
			return this.color_0;
		}
		set
		{
			this.color_0 = value;
			this.method_4();
		}
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00011FBC File Offset: 0x000101BC
	// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00011FC4 File Offset: 0x000101C4
	public override Color ForeColor
	{
		get
		{
			return base.ForeColor;
		}
		set
		{
			base.ForeColor = value;
			this.class381_0.vmethod_1();
			this.method_4();
		}
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00011FDE File Offset: 0x000101DE
	// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00011FE6 File Offset: 0x000101E6
	[Browsable(false)]
	public int Int32_2
	{
		get
		{
			return this.int_9;
		}
		set
		{
			this.int_9 = value;
			this.method_10();
			this.vmethod_5();
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00011FFB File Offset: 0x000101FB
	// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00012003 File Offset: 0x00010203
	[DefaultValue(0)]
	[Description("Interval between lines in pixels")]
	public int Int32_3
	{
		get
		{
			return this.int_12;
		}
		set
		{
			this.int_12 = value;
			this.method_0(this.Font);
			this.method_4();
		}
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0001201E File Offset: 0x0001021E
	// (set) Token: 0x06001A4A RID: 6730 RVA: 0x00012026 File Offset: 0x00010226
	[Browsable(false)]
	public int Int32_4 { get; set; }

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0001202F File Offset: 0x0001022F
	// (set) Token: 0x06001A4C RID: 6732 RVA: 0x00012037 File Offset: 0x00010237
	[DefaultValue(4)]
	[Description("Spaces count for tab")]
	public int Int32_5 { get; set; }

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00012040 File Offset: 0x00010240
	// (set) Token: 0x06001A4E RID: 6734 RVA: 0x00012048 File Offset: 0x00010248
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Boolean_8
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			if (!value)
			{
				this.class381_0.m_AA3A1CFA();
			}
			this.bool_5 = value;
		}
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06001A4F RID: 6735 RVA: 0x0001205F File Offset: 0x0001025F
	// (set) Token: 0x06001A50 RID: 6736 RVA: 0x00012067 File Offset: 0x00010267
	[Browsable(false)]
	public int Int32_6 { get; private set; }

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00012070 File Offset: 0x00010270
	// (set) Token: 0x06001A52 RID: 6738 RVA: 0x00012078 File Offset: 0x00010278
	[DefaultValue(false)]
	public bool Boolean_9 { get; set; }

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00012081 File Offset: 0x00010281
	// (set) Token: 0x06001A54 RID: 6740 RVA: 0x00012089 File Offset: 0x00010289
	[Description("Shows line numbers.")]
	[DefaultValue(true)]
	public bool Boolean_10
	{
		get
		{
			return this.bool_20;
		}
		set
		{
			this.bool_20 = value;
			this.method_10();
			this.method_4();
		}
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x06001A55 RID: 6741 RVA: 0x0001209E File Offset: 0x0001029E
	// (set) Token: 0x06001A56 RID: 6742 RVA: 0x000120A6 File Offset: 0x000102A6
	[Description("Shows vertical lines between folding start line and folding end line.")]
	[DefaultValue(false)]
	public bool Boolean_11
	{
		get
		{
			return this.bool_19;
		}
		set
		{
			this.bool_19 = value;
			this.method_4();
		}
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06001A57 RID: 6743 RVA: 0x000D1D64 File Offset: 0x000CFF64
	[Browsable(false)]
	public Rectangle Rectangle_0
	{
		get
		{
			int num = this.Int32_7 + this.int_14 * this.Int32_4 + this.Padding_0.Left + 1;
			num = Math.Max(base.ClientSize.Width - this.Padding_0.Right, num);
			int num2 = this.int_17 + this.Padding_0.Top;
			num2 = Math.Max(base.ClientSize.Height - this.Padding_0.Bottom, num2);
			int num3 = Math.Max(0, this.Padding_0.Top - 1) - base.VerticalScroll.Value;
			return Rectangle.FromLTRB(this.Int32_7 - base.HorizontalScroll.Value - 2 + Math.Max(0, this.Padding_0.Left - 1), num3, num - base.HorizontalScroll.Value, num2 - base.VerticalScroll.Value);
		}
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000120B5 File Offset: 0x000102B5
	// (set) Token: 0x06001A59 RID: 6745 RVA: 0x000120BD File Offset: 0x000102BD
	[DefaultValue(typeof(Color), "Teal")]
	[Description("Color of line numbers.")]
	public Color Color_4
	{
		get
		{
			return this.color_4;
		}
		set
		{
			this.color_4 = value;
			this.method_4();
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001A5A RID: 6746 RVA: 0x000120CC File Offset: 0x000102CC
	// (set) Token: 0x06001A5B RID: 6747 RVA: 0x000120D4 File Offset: 0x000102D4
	[Description("Start value of first line number.")]
	[DefaultValue(typeof(uint), "1")]
	public uint UInt32_0
	{
		get
		{
			return this.uint_0;
		}
		set
		{
			this.uint_0 = value;
			this.bool_11 = true;
			this.method_4();
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06001A5C RID: 6748 RVA: 0x000120EA File Offset: 0x000102EA
	// (set) Token: 0x06001A5D RID: 6749 RVA: 0x000120F2 File Offset: 0x000102F2
	[DefaultValue(typeof(Class352), null)]
	[Description("Format of string displayed when ShowLineNumbers = true")]
	public Class352 Class352_0
	{
		get
		{
			return this.class352_0;
		}
		set
		{
			this.class352_0 = value;
			this.bool_11 = true;
			this.method_4();
		}
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00012108 File Offset: 0x00010308
	// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00012110 File Offset: 0x00010310
	[DefaultValue(typeof(Color), "WhiteSmoke")]
	[Description("Background color of indent area")]
	public Color Color_5
	{
		get
		{
			return this.color_3;
		}
		set
		{
			this.color_3 = value;
			this.method_4();
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0001211F File Offset: 0x0001031F
	// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00012127 File Offset: 0x00010327
	[DefaultValue(typeof(Color), "Transparent")]
	[Description("Background color of padding area")]
	public Color Color_6
	{
		get
		{
			return this.color_5;
		}
		set
		{
			this.color_5 = value;
			this.method_4();
		}
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00012136 File Offset: 0x00010336
	// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0001213E File Offset: 0x0001033E
	[DefaultValue(typeof(Color), "100;180;180;180")]
	[Description("Color of disabled component")]
	public Color Color_7 { get; set; }

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00012147 File Offset: 0x00010347
	// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0001214F File Offset: 0x0001034F
	[Description("Color of caret.")]
	[DefaultValue(typeof(Color), "Black")]
	public Color Color_8 { get; set; }

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00012158 File Offset: 0x00010358
	// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00012160 File Offset: 0x00010360
	[DefaultValue(false)]
	[Description("Wide caret.")]
	public bool Boolean_12 { get; set; }

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00012169 File Offset: 0x00010369
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00012171 File Offset: 0x00010371
	[DefaultValue(typeof(Color), "Silver")]
	[Description("Color of service lines (folding lines, borders of blocks etc.)")]
	public Color Color_9
	{
		get
		{
			return this.color_7;
		}
		set
		{
			this.color_7 = value;
			this.method_4();
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00012180 File Offset: 0x00010380
	// (set) Token: 0x06001A6B RID: 6763 RVA: 0x00012188 File Offset: 0x00010388
	[Description("Paddings of text area.")]
	[Browsable(true)]
	public Padding Padding_0 { get; set; }

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06001A6C RID: 6764 RVA: 0x000D1E68 File Offset: 0x000D0068
	// (set) Token: 0x06001A6D RID: 6765 RVA: 0x00011A79 File Offset: 0x0000FC79
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Padding Padding_1
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00011A79 File Offset: 0x0000FC79
	// (set) Token: 0x06001A6F RID: 6767 RVA: 0x00011A79 File Offset: 0x0000FC79
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Boolean_13
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00012191 File Offset: 0x00010391
	// (set) Token: 0x06001A71 RID: 6769 RVA: 0x00012199 File Offset: 0x00010399
	[Description("Color of folding area indicator.")]
	[DefaultValue(typeof(Color), "Green")]
	public Color Color_10
	{
		get
		{
			return this.color_2;
		}
		set
		{
			this.color_2 = value;
			this.method_4();
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06001A72 RID: 6770 RVA: 0x000121A8 File Offset: 0x000103A8
	// (set) Token: 0x06001A73 RID: 6771 RVA: 0x000121B0 File Offset: 0x000103B0
	[DefaultValue(true)]
	[Description("Enables folding indicator (left vertical line between folding bounds)")]
	public bool Boolean_14
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			this.method_4();
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000121BF File Offset: 0x000103BF
	// (set) Token: 0x06001A75 RID: 6773 RVA: 0x000121C7 File Offset: 0x000103C7
	[Browsable(false)]
	[Description("Left distance to text beginning.")]
	public int Int32_7 { get; private set; }

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000121D0 File Offset: 0x000103D0
	// (set) Token: 0x06001A77 RID: 6775 RVA: 0x000121D8 File Offset: 0x000103D8
	[Description("Width of left service area (in pixels)")]
	[DefaultValue(0)]
	public int Int32_8
	{
		get
		{
			return this.int_11;
		}
		set
		{
			this.int_11 = value;
			this.method_4();
		}
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000121E7 File Offset: 0x000103E7
	// (set) Token: 0x06001A79 RID: 6777 RVA: 0x000121EF File Offset: 0x000103EF
	[Description("This property draws vertical line after defined char position. Set to 0 for disable drawing of vertical line.")]
	[DefaultValue(0)]
	public int Int32_9
	{
		get
		{
			return this.int_15;
		}
		set
		{
			this.int_15 = value;
			this.method_4();
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06001A7A RID: 6778 RVA: 0x000121FE File Offset: 0x000103FE
	[Browsable(false)]
	public Class368[] Class368_0
	{
		get
		{
			return this.class381_0.class368_0;
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0001220B File Offset: 0x0001040B
	// (set) Token: 0x06001A7C RID: 6780 RVA: 0x00012218 File Offset: 0x00010418
	[DefaultValue("Tab=IndentIncrease, Escape=ClearHints, PgUp=GoPageUp, PgDn=GoPageDown, End=GoEnd, Home=GoHome, Left=GoLeft, Up=GoUp, Right=GoRight, Down=GoDown, Ins=ReplaceMode, Del=DeleteCharRight, F3=FindNext, Shift+Tab=IndentDecrease, Shift+PgUp=GoPageUpWithSelection, Shift+PgDn=GoPageDownWithSelection, Shift+End=GoEndWithSelection, Shift+Home=GoHomeWithSelection, Shift+Left=GoLeftWithSelection, Shift+Up=GoUpWithSelection, Shift+Right=GoRightWithSelection, Shift+Down=GoDownWithSelection, Shift+Ins=Paste, Shift+Del=Cut, Ctrl+Back=ClearWordLeft, Ctrl+Space=AutocompleteMenu, Ctrl+End=GoLastLine, Ctrl+Home=GoFirstLine, Ctrl+Left=GoWordLeft, Ctrl+Up=ScrollUp, Ctrl+Right=GoWordRight, Ctrl+Down=ScrollDown, Ctrl+Ins=Copy, Ctrl+Del=ClearWordRight, Ctrl+0=ZoomNormal, Ctrl+A=SelectAll, Ctrl+B=BookmarkLine, Ctrl+C=Copy, Ctrl+E=MacroExecute, Ctrl+F=FindDialog, Ctrl+G=GoToDialog, Ctrl+H=ReplaceDialog, Ctrl+I=AutoIndentChars, Ctrl+M=MacroRecord, Ctrl+N=GoNextBookmark, Ctrl+R=Redo, Ctrl+U=UpperCase, Ctrl+V=Paste, Ctrl+X=Cut, Ctrl+Z=Undo, Ctrl+Add=ZoomIn, Ctrl+Subtract=ZoomOut, Ctrl+OemMinus=NavigateBackward, Ctrl+Shift+End=GoLastLineWithSelection, Ctrl+Shift+Home=GoFirstLineWithSelection, Ctrl+Shift+Left=GoWordLeftWithSelection, Ctrl+Shift+Right=GoWordRightWithSelection, Ctrl+Shift+B=UnbookmarkLine, Ctrl+Shift+C=CommentSelected, Ctrl+Shift+N=GoPrevBookmark, Ctrl+Shift+U=LowerCase, Ctrl+Shift+OemMinus=NavigateForward, Alt+Back=Undo, Alt+Up=MoveSelectedLinesUp, Alt+Down=MoveSelectedLinesDown, Alt+F=FindChar, Alt+Shift+Left=GoLeft_ColumnSelectionMode, Alt+Shift+Up=GoUp_ColumnSelectionMode, Alt+Shift+Right=GoRight_ColumnSelectionMode, Alt+Shift+Down=GoDown_ColumnSelectionMode")]
	[Editor(typeof(Class348), typeof(UITypeEditor))]
	[Description("Here you can change hotkeys for FastColoredTextBox.")]
	public string String_0
	{
		get
		{
			return this.Class347_0.ToString();
		}
		set
		{
			this.Class347_0 = Class347.smethod_0(value);
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00012226 File Offset: 0x00010426
	// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0001222E File Offset: 0x0001042E
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Class347 Class347_0 { get; set; }

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00012237 File Offset: 0x00010437
	// (set) Token: 0x06001A80 RID: 6784 RVA: 0x00012244 File Offset: 0x00010444
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Class369 Class369_0
	{
		get
		{
			return this.class381_0.Class369_0;
		}
		set
		{
			this.class381_0.Class369_0 = value;
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00012252 File Offset: 0x00010452
	// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0001225A File Offset: 0x0001045A
	[Browsable(false)]
	public Class371 Class371_0 { get; set; }

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00012263 File Offset: 0x00010463
	// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0001226B File Offset: 0x0001046B
	[Browsable(false)]
	public Class369 Class369_1 { get; set; }

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00012274 File Offset: 0x00010474
	// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0001227C File Offset: 0x0001047C
	[Browsable(false)]
	public Class372 Class372_0 { get; set; }

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00012285 File Offset: 0x00010485
	// (set) Token: 0x06001A88 RID: 6792 RVA: 0x0001228D File Offset: 0x0001048D
	[Browsable(false)]
	public Class372 Class372_1 { get; set; }

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00012296 File Offset: 0x00010496
	// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0001229E File Offset: 0x0001049E
	[DefaultValue('\0')]
	[Description("Opening bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
	public char Char_1 { get; set; }

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000122A7 File Offset: 0x000104A7
	// (set) Token: 0x06001A8C RID: 6796 RVA: 0x000122AF File Offset: 0x000104AF
	[Description("Closing bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
	[DefaultValue('\0')]
	public char Char_2 { get; set; }

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06001A8D RID: 6797 RVA: 0x000122B8 File Offset: 0x000104B8
	// (set) Token: 0x06001A8E RID: 6798 RVA: 0x000122C0 File Offset: 0x000104C0
	[DefaultValue('\0')]
	[Description("Alternative opening bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
	public char Char_3 { get; set; }

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000122C9 File Offset: 0x000104C9
	// (set) Token: 0x06001A90 RID: 6800 RVA: 0x000122D1 File Offset: 0x000104D1
	[DefaultValue('\0')]
	[Description("Alternative closing bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
	public char Char_4 { get; set; }

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06001A91 RID: 6801 RVA: 0x000122DA File Offset: 0x000104DA
	// (set) Token: 0x06001A92 RID: 6802 RVA: 0x000122E2 File Offset: 0x000104E2
	[Description("Comment line prefix.")]
	[DefaultValue("//")]
	public string String_1 { get; set; }

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06001A93 RID: 6803 RVA: 0x000122EB File Offset: 0x000104EB
	// (set) Token: 0x06001A94 RID: 6804 RVA: 0x000122F3 File Offset: 0x000104F3
	[DefaultValue(typeof(GEnum13), "ChangedRange")]
	[Description("This property specifies which part of the text will be highlighted as you type.")]
	public GEnum13 GEnum13_0 { get; set; }

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06001A95 RID: 6805 RVA: 0x000D1E7C File Offset: 0x000D007C
	// (set) Token: 0x06001A96 RID: 6806 RVA: 0x000122FC File Offset: 0x000104FC
	[Browsable(false)]
	public bool Boolean_15
	{
		get
		{
			return this.bool_7 && this.Class357_5.Boolean_2 && !this.Class357_5.Boolean_0 && this.Class357_5.GStruct19_0.int_0 < this.class381_0[this.Class357_5.GStruct19_0.int_1].Count;
		}
		set
		{
			this.bool_7 = value;
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00012305 File Offset: 0x00010505
	// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0001230D File Offset: 0x0001050D
	[DefaultValue(false)]
	[Description("Allows text rendering several styles same time.")]
	[Browsable(true)]
	public bool Boolean_16 { get; set; }

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00012316 File Offset: 0x00010516
	// (set) Token: 0x06001A9A RID: 6810 RVA: 0x00012323 File Offset: 0x00010523
	[Description("Allows to record macros.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool Boolean_17
	{
		get
		{
			return this.Class355_0.Boolean_0;
		}
		set
		{
			this.Class355_0.Boolean_0 = value;
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00012331 File Offset: 0x00010531
	// (set) Token: 0x06001A9C RID: 6812 RVA: 0x00012339 File Offset: 0x00010539
	[Description("Allows auto indent. Inserts spaces before line chars.")]
	[DefaultValue(true)]
	public bool Boolean_18 { get; set; }

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00012342 File Offset: 0x00010542
	// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0001234A File Offset: 0x0001054A
	[Description("Does autoindenting in existing lines. It works only if AutoIndent is True.")]
	[DefaultValue(true)]
	public bool Boolean_19 { get; set; }

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00012353 File Offset: 0x00010553
	// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00012360 File Offset: 0x00010560
	[Browsable(true)]
	[Description("Minimal delay(ms) for delayed events (except TextChangedDelayed).")]
	[DefaultValue(100)]
	public int Int32_10
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

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0001236E File Offset: 0x0001056E
	// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x0001237B File Offset: 0x0001057B
	[DefaultValue(100)]
	[Browsable(true)]
	[Description("Minimal delay(ms) for TextChangedDelayed event.")]
	public int Int32_11
	{
		get
		{
			return this.timer_1.Interval;
		}
		set
		{
			this.timer_1.Interval = value;
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00012389 File Offset: 0x00010589
	// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x00012391 File Offset: 0x00010591
	[Browsable(true)]
	[DefaultValue(typeof(GEnum21), "Custom")]
	[Description("Language for highlighting by built-in highlighter.")]
	public GEnum21 GEnum21_0
	{
		get
		{
			return this.genum21_0;
		}
		set
		{
			this.genum21_0 = value;
			if (this.Class379_0 != null)
			{
				this.Class379_0.method_10(this.genum21_0);
			}
			this.method_4();
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x000123B9 File Offset: 0x000105B9
	// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x000123C1 File Offset: 0x000105C1
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Class379 Class379_0 { get; set; }

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x000123CA File Offset: 0x000105CA
	// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x000123D2 File Offset: 0x000105D2
	[DefaultValue(null)]
	[Description("XML file with description of syntax highlighting. This property works only with Language == Language.Custom.")]
	[Browsable(true)]
	[Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
	public string String_2
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			this.method_4();
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x000123E1 File Offset: 0x000105E1
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Class357 Class357_0
	{
		get
		{
			return this.class357_3;
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000123E9 File Offset: 0x000105E9
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Class357 Class357_1
	{
		get
		{
			return this.class357_5;
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x06001AAB RID: 6827 RVA: 0x000123F1 File Offset: 0x000105F1
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Class357 Class357_2
	{
		get
		{
			return this.class357_4;
		}
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06001AAC RID: 6828 RVA: 0x000123F9 File Offset: 0x000105F9
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Class357 Class357_3
	{
		get
		{
			return this.class357_6;
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00012401 File Offset: 0x00010601
	// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00012409 File Offset: 0x00010609
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Int32_12 { get; private set; } = -1;

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00012412 File Offset: 0x00010612
	// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x0001241A File Offset: 0x0001061A
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int Int32_13 { get; private set; } = -1;

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00012423 File Offset: 0x00010623
	// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x0001242B File Offset: 0x0001062B
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Class381 Class381_0
	{
		get
		{
			return this.class381_0;
		}
		set
		{
			this.vmethod_7(value);
		}
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00012434 File Offset: 0x00010634
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Boolean_20
	{
		get
		{
			return this.Control3_0 != null;
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0001243F File Offset: 0x0001063F
	// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x000D1EE0 File Offset: 0x000D00E0
	[DefaultValue(null)]
	[Description("Allows to get text from other FastColoredTextBox.")]
	[Browsable(true)]
	public Control3 Control3_0
	{
		get
		{
			return this.control3_0;
		}
		set
		{
			if (value == this.control3_0)
			{
				return;
			}
			this.control3_0 = value;
			if (this.control3_0 == null)
			{
				this.vmethod_7(this.vmethod_6());
				this.class381_0.m_559E6352(0, this.Class381_0.vmethod_0());
				this.Boolean_8 = false;
			}
			else
			{
				this.vmethod_7(this.Control3_0.Class381_0);
				this.bool_5 = false;
			}
			this.method_4();
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000D1F50 File Offset: 0x000D0150
	[Browsable(false)]
	public Class357 Class357_4
	{
		get
		{
			if (this.class357_8 != null)
			{
				return this.class357_8;
			}
			return this.method_95(this.method_82(new Point(this.Int32_7, 0)), this.method_82(new Point(base.ClientSize.Width, base.ClientSize.Height)));
		}
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x00012447 File Offset: 0x00010647
	// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x000D1FAC File Offset: 0x000D01AC
	[Browsable(false)]
	public Class357 Class357_5
	{
		get
		{
			return this.class357_0;
		}
		set
		{
			if (value == this.class357_0)
			{
				return;
			}
			this.class357_0.method_38();
			this.class357_0.GStruct19_0 = value.GStruct19_0;
			this.class357_0.GStruct19_1 = value.GStruct19_1;
			this.class357_0.method_39();
			this.method_4();
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0001244F File Offset: 0x0001064F
	// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00012457 File Offset: 0x00010657
	[DefaultValue(typeof(Color), "White")]
	[Description("Background color.")]
	public override Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
		}
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00012460 File Offset: 0x00010660
	// (set) Token: 0x06001ABC RID: 6844 RVA: 0x00012468 File Offset: 0x00010668
	[Browsable(false)]
	public Brush Brush_0
	{
		get
		{
			return this.brush_0;
		}
		set
		{
			this.brush_0 = value;
			this.method_4();
		}
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x06001ABD RID: 6845 RVA: 0x00012477 File Offset: 0x00010677
	// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0001247F File Offset: 0x0001067F
	[Description("Scollbars visibility.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool Boolean_21
	{
		get
		{
			return this.bool_17;
		}
		set
		{
			if (value == this.bool_17)
			{
				return;
			}
			this.bool_17 = value;
			this.bool_11 = true;
			this.method_4();
		}
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0001249F File Offset: 0x0001069F
	// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x000D2004 File Offset: 0x000D0204
	[Description("Multiline mode.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool Boolean_22
	{
		get
		{
			return this.bool_10;
		}
		set
		{
			if (this.bool_10 == value)
			{
				return;
			}
			this.bool_10 = value;
			this.bool_11 = true;
			if (this.bool_10)
			{
				base.AutoScroll = true;
				this.Boolean_21 = true;
			}
			else
			{
				base.AutoScroll = false;
				this.Boolean_21 = false;
				if (this.class381_0.Count > 1)
				{
					this.class381_0.m_90EA19F5(1, this.class381_0.Count - 1);
				}
				this.class381_0.Class312_0.method_5();
			}
			this.method_4();
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000124A7 File Offset: 0x000106A7
	// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x000124AF File Offset: 0x000106AF
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("WordWrap.")]
	public bool Boolean_23
	{
		get
		{
			return this.bool_21;
		}
		set
		{
			if (this.bool_21 == value)
			{
				return;
			}
			this.bool_21 = value;
			if (this.bool_21)
			{
				this.Class357_5.Boolean_0 = false;
			}
			this.method_12(false, true);
			this.method_4();
		}
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000124E4 File Offset: 0x000106E4
	// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x000124EC File Offset: 0x000106EC
	[Browsable(true)]
	[Description("WordWrap mode.")]
	[DefaultValue(typeof(GEnum12), "WordWrapControlWidth")]
	public GEnum12 GEnum12_0
	{
		get
		{
			return this.genum12_0;
		}
		set
		{
			if (this.genum12_0 == value)
			{
				return;
			}
			this.genum12_0 = value;
			this.method_12(false, true);
			this.method_4();
		}
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0001250D File Offset: 0x0001070D
	// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x00012515 File Offset: 0x00010715
	[DefaultValue(true)]
	[Description("If enabled then line ends included into the selection will be selected too. Then line ends will be shown as selected blank character.")]
	public bool Boolean_24
	{
		get
		{
			return this.bool_18;
		}
		set
		{
			this.bool_18 = value;
			this.method_4();
		}
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00012524 File Offset: 0x00010724
	// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0001252C File Offset: 0x0001072C
	[Browsable(false)]
	public FindForm FindForm_0 { get; private set; }

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00012535 File Offset: 0x00010735
	// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0001253D File Offset: 0x0001073D
	[Browsable(false)]
	public ReplaceForm ReplaceForm_0 { get; private set; }

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00012546 File Offset: 0x00010746
	// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000500B File Offset: 0x0000320B
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override bool AutoScroll
	{
		get
		{
			return base.AutoScroll;
		}
		set
		{
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0001254E File Offset: 0x0001074E
	[Browsable(false)]
	public int Int32_14
	{
		get
		{
			return this.class381_0.Count;
		}
	}

	// Token: 0x17000566 RID: 1382
	public GStruct17 this[GStruct19 gstruct19_0]
	{
		get
		{
			return this.class381_0[gstruct19_0.int_1][gstruct19_0.int_0];
		}
		set
		{
			this.class381_0[gstruct19_0.int_1][gstruct19_0.int_0] = value;
		}
	}

	// Token: 0x17000567 RID: 1383
	public Class351 this[int int_28]
	{
		get
		{
			return this.class381_0[int_28];
		}
	}

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000125A6 File Offset: 0x000107A6
	// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x000D208C File Offset: 0x000D028C
	[Description("Text of the control.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Bindable(true)]
	[SettingsBindable(true)]
	[Localizable(true)]
	[Browsable(true)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public override string Text
	{
		get
		{
			if (this.Int32_14 == 0)
			{
				return "";
			}
			Class357 @class = new Class357(this);
			@class.method_2();
			return @class.String_1;
		}
		set
		{
			if (value == this.Text && value != "")
			{
				return;
			}
			this.method_6();
			this.Class357_5.Boolean_0 = false;
			this.Class357_5.method_38();
			try
			{
				this.Class357_5.method_2();
				this.vmethod_20(value);
				this.method_28();
			}
			finally
			{
				this.Class357_5.method_39();
			}
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000125C7 File Offset: 0x000107C7
	public int Int32_15
	{
		get
		{
			if (this.Int32_14 == 0)
			{
				return 0;
			}
			Class357 @class = new Class357(this);
			@class.method_2();
			return @class.Int32_0;
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x000125E4 File Offset: 0x000107E4
	[Browsable(false)]
	public IList<string> IList_0
	{
		get
		{
			return this.class381_0.vmethod_3();
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000D2108 File Offset: 0x000D0308
	[Browsable(false)]
	public string String_3
	{
		get
		{
			return "<pre>" + new Class329
			{
				Boolean_0 = false,
				Boolean_3 = false,
				Boolean_4 = false
			}.method_0(this) + "</pre>";
		}
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x000125F1 File Offset: 0x000107F1
	[Browsable(false)]
	public string String_4
	{
		get
		{
			return new Class330().method_0(this);
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000125FE File Offset: 0x000107FE
	// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0001260B File Offset: 0x0001080B
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string String_5
	{
		get
		{
			return this.Class357_5.String_1;
		}
		set
		{
			this.vmethod_20(value);
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x00012614 File Offset: 0x00010814
	// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0001263D File Offset: 0x0001083D
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int Int32_16
	{
		get
		{
			return Math.Min(this.method_90(this.Class357_5.GStruct19_0), this.method_90(this.Class357_5.GStruct19_1));
		}
		set
		{
			this.Class357_5.GStruct19_0 = this.method_91(value);
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00012651 File Offset: 0x00010851
	// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0001265E File Offset: 0x0001085E
	[Browsable(false)]
	[DefaultValue(0)]
	public int Int32_17
	{
		get
		{
			return this.Class357_5.Int32_0;
		}
		set
		{
			if (value > 0)
			{
				this.Class357_5.GStruct19_1 = this.method_91(this.Int32_16 + value);
			}
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0001267D File Offset: 0x0001087D
	// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00012685 File Offset: 0x00010885
	[DefaultValue(typeof(Font), "Courier New, 9.75")]
	public override Font Font
	{
		get
		{
			return this.Font_0;
		}
		set
		{
			this.font_0 = (Font)value.Clone();
			this.method_0(value);
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0001269F File Offset: 0x0001089F
	// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x000126A7 File Offset: 0x000108A7
	[DefaultValue(typeof(Font), "Courier New, 9.75")]
	private Font Font_0 { get; set; }

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x000126B0 File Offset: 0x000108B0
	// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x000D2148 File Offset: 0x000D0348
	public Size Size_0
	{
		get
		{
			if (this.bool_17)
			{
				return base.AutoScrollMinSize;
			}
			return this.size_0;
		}
		set
		{
			if (this.bool_17)
			{
				if (!base.AutoScroll)
				{
					base.AutoScroll = true;
				}
				Size size = value;
				if (this.Boolean_23 && this.GEnum12_0 != GEnum12.Custom)
				{
					int num = this.method_44();
					size = new Size(Math.Min(size.Width, num), size.Height);
				}
				base.AutoScrollMinSize = size;
				return;
			}
			if (base.AutoScroll)
			{
				base.AutoScroll = false;
			}
			base.AutoScrollMinSize = new Size(0, 0);
			base.VerticalScroll.Visible = false;
			base.HorizontalScroll.Visible = false;
			base.VerticalScroll.Maximum = Math.Max(0, value.Height - base.ClientSize.Height);
			base.HorizontalScroll.Maximum = Math.Max(0, value.Width - base.ClientSize.Width);
			this.size_0 = value;
		}
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000126C7 File Offset: 0x000108C7
	[Browsable(false)]
	public bool Boolean_25
	{
		get
		{
			return base.ImeMode != ImeMode.Disable && base.ImeMode != ImeMode.Off && base.ImeMode > ImeMode.NoControl;
		}
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000126E6 File Offset: 0x000108E6
	[Browsable(false)]
	public bool Boolean_26
	{
		get
		{
			return this.class381_0.Class312_0.Boolean_1;
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000126F8 File Offset: 0x000108F8
	[Browsable(false)]
	public bool Boolean_27
	{
		get
		{
			return this.class381_0.Class312_0.Boolean_2;
		}
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0001270A File Offset: 0x0001090A
	private int Int32_18
	{
		get
		{
			return this.Int32_7 - 4 - 3;
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00012716 File Offset: 0x00010916
	[Browsable(false)]
	public Class357 Class357_6
	{
		get
		{
			return new Class357(this, new GStruct19(0, 0), new GStruct19(this.class381_0[this.class381_0.Count - 1].Count, this.class381_0.Count - 1));
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00012754 File Offset: 0x00010954
	// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x000D2234 File Offset: 0x000D0434
	[Description("Color of selected area.")]
	[DefaultValue(typeof(Color), "Blue")]
	public virtual Color Color_11
	{
		get
		{
			return this.color_6;
		}
		set
		{
			this.color_6 = value;
			if (this.color_6.A == 255)
			{
				this.color_6 = Color.FromArgb(60, this.color_6);
			}
			this.Class371_0 = new Class371(new SolidBrush(this.color_6), null);
			this.method_4();
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0001275C File Offset: 0x0001095C
	// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00012764 File Offset: 0x00010964
	public override Cursor Cursor
	{
		get
		{
			return base.Cursor;
		}
		set
		{
			this.cursor_0 = value;
			base.Cursor = value;
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00012774 File Offset: 0x00010974
	// (set) Token: 0x06001AED RID: 6893 RVA: 0x0001277C File Offset: 0x0001097C
	[Description("Reserved space for line number characters. If smaller than needed (e. g. line count >= 10 and this value set to 1) this value will have no impact. If you want to reserve space, e. g. for line numbers >= 10 or >= 100, than you can set this value to 2 or 3 or higher.")]
	[DefaultValue(1)]
	public int Int32_19
	{
		get
		{
			return this.int_16;
		}
		set
		{
			this.int_16 = value;
			this.method_10();
			this.method_4();
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00012791 File Offset: 0x00010991
	// (set) Token: 0x06001AEF RID: 6895 RVA: 0x00012799 File Offset: 0x00010999
	[DefaultValue(0)]
	[Browsable(false)]
	public int Int32_20
	{
		get
		{
			return this.int_10;
		}
		set
		{
			this.int_10 = value;
			this.method_4();
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x000127A8 File Offset: 0x000109A8
	// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x000127B0 File Offset: 0x000109B0
	[Browsable(false)]
	public int Int32_21
	{
		get
		{
			return this.int_19;
		}
		set
		{
			this.int_19 = value;
			this.method_78((float)this.int_19 / 100f);
			this.vmethod_51();
		}
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x0000500B File Offset: 0x0000320B
	void ISupportInitialize.BeginInit()
	{
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000127D2 File Offset: 0x000109D2
	void ISupportInitialize.EndInit()
	{
		this.vmethod_54();
		this.Class357_5.GStruct19_0 = GStruct19.GStruct19_0;
		this.method_49();
		this.Boolean_8 = false;
		this.method_31();
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000D228C File Offset: 0x000D048C
	private void method_0(Font font_2)
	{
		this.Font_0 = font_2;
		SizeF sizeF = Control3.smethod_1(this.Font_0, 'M');
		SizeF sizeF2 = Control3.smethod_1(this.Font_0, '.');
		if (sizeF != sizeF2)
		{
			this.Font_0 = new Font("Courier New", this.Font_0.SizeInPoints, FontStyle.Regular, GraphicsUnit.Point);
		}
		SizeF sizeF3 = Control3.smethod_1(this.Font_0, 'M');
		this.Int32_4 = (int)Math.Round((double)(sizeF3.Width * 1f)) - 1;
		this.Int32_2 = this.int_12 + (int)Math.Round((double)(sizeF3.Height * 1f)) - 1;
		this.method_12(false, this.bool_21);
		this.method_4();
	}

	// Token: 0x14000022 RID: 34
	// (add) Token: 0x06001AF5 RID: 6901 RVA: 0x000D2340 File Offset: 0x000D0540
	// (remove) Token: 0x06001AF6 RID: 6902 RVA: 0x000D2378 File Offset: 0x000D0578
	[Description("Occurs when mouse is moving over text and tooltip is needed.")]
	[Browsable(true)]
	public event EventHandler<EventArgs9> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs9> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs9> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs9> eventHandler3 = (EventHandler<EventArgs9>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs9> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs9> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs9> eventHandler3 = (EventHandler<EventArgs9>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x000127FD File Offset: 0x000109FD
	public void method_1()
	{
		if (this.Class344_0 != null)
		{
			this.Class344_0.Clear();
		}
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x000D23B0 File Offset: 0x000D05B0
	public virtual Class346 vmethod_0(Class357 class357_9, Control control_0, bool bool_37, bool bool_38, bool bool_39)
	{
		Class346 @class = new Class346(class357_9, control_0, bool_38, bool_39);
		this.Class344_0.Add(@class);
		if (bool_37)
		{
			@class.vmethod_0();
		}
		return @class;
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00012812 File Offset: 0x00010A12
	public Class346 method_2(Class357 class357_9, Control control_0)
	{
		return this.vmethod_0(class357_9, control_0, true, true, true);
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000D23E0 File Offset: 0x000D05E0
	public virtual Class346 vmethod_1(Class357 class357_9, string string_3, bool bool_37, bool bool_38, bool bool_39)
	{
		Class346 @class = new Class346(class357_9, string_3, bool_38, bool_39);
		this.Class344_0.Add(@class);
		if (bool_37)
		{
			@class.vmethod_0();
		}
		return @class;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x0001281F File Offset: 0x00010A1F
	public Class346 method_3(Class357 class357_9, string string_3)
	{
		return this.vmethod_1(class357_9, string_3, true, true, true);
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x0001282C File Offset: 0x00010A2C
	public virtual void vmethod_2(Class346 class346_0)
	{
		if (this.eventHandler_1 != null)
		{
			this.eventHandler_1(this, new EventArgs10(class346_0));
		}
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x00012848 File Offset: 0x00010A48
	private void timer_2_Tick(object sender, EventArgs e)
	{
		this.timer_2.Stop();
		this.vmethod_3();
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000D2410 File Offset: 0x000D0610
	protected virtual void vmethod_3()
	{
		if (this.ToolTip_0 == null)
		{
			return;
		}
		if (this.eventHandler_0 == null)
		{
			return;
		}
		GStruct19 gstruct = this.method_82(this.point_0);
		Point point = this.method_93(gstruct);
		if (Math.Abs(point.X - this.point_0.X) <= this.Int32_4 * 2 && Math.Abs(point.Y - this.point_0.Y) <= this.Int32_2 * 2)
		{
			string text = new Class357(this, gstruct, gstruct).method_43("[a-zA-Z]").String_1;
			EventArgs9 eventArgs = new EventArgs9(gstruct, text);
			this.eventHandler_0(this, eventArgs);
			if (eventArgs.String_2 != null)
			{
				this.ToolTip_0.ToolTipTitle = eventArgs.String_1;
				this.ToolTip_0.ToolTipIcon = eventArgs.ToolTipIcon_0;
				this.ToolTip_0.Show(eventArgs.String_2, this, new Point(this.point_0.X, this.point_0.Y + this.Int32_2));
			}
			return;
		}
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x0001285B File Offset: 0x00010A5B
	public virtual void vmethod_4()
	{
		this.bool_12 = true;
		this.bool_16 = true;
		this.method_20(this.timer_0);
		if (this.eventHandler_7 != null)
		{
			this.eventHandler_7(this, new EventArgs());
		}
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00012890 File Offset: 0x00010A90
	public void method_4()
	{
		if (base.InvokeRequired)
		{
			base.BeginInvoke(new MethodInvoker(this.method_4));
			return;
		}
		base.Invalidate();
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x000128B4 File Offset: 0x00010AB4
	protected virtual void vmethod_5()
	{
		base.VerticalScroll.SmallChange = this.int_9;
		base.VerticalScroll.LargeChange = 10 * this.int_9;
		base.HorizontalScroll.SmallChange = this.Int32_4;
	}

	// Token: 0x14000023 RID: 35
	// (add) Token: 0x06001B02 RID: 6914 RVA: 0x000D251C File Offset: 0x000D071C
	// (remove) Token: 0x06001B03 RID: 6915 RVA: 0x000D2554 File Offset: 0x000D0754
	[Browsable(true)]
	[Description("It occurs if user click on the hint.")]
	public event EventHandler<EventArgs10> Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs10> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs10> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs10> eventHandler3 = (EventHandler<EventArgs10>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs10> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs10> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs10> eventHandler3 = (EventHandler<EventArgs10>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000024 RID: 36
	// (add) Token: 0x06001B04 RID: 6916 RVA: 0x000D258C File Offset: 0x000D078C
	// (remove) Token: 0x06001B05 RID: 6917 RVA: 0x000D25C4 File Offset: 0x000D07C4
	[Description("It occurs after insert, delete, clear, undo and redo operations.")]
	[Browsable(true)]
	public event EventHandler<EventArgs5> Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs5> eventHandler = this.eventHandler_2;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> eventHandler3 = (EventHandler<EventArgs5>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs5> eventHandler = this.eventHandler_2;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> eventHandler3 = (EventHandler<EventArgs5>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000025 RID: 37
	// (add) Token: 0x06001B06 RID: 6918 RVA: 0x000D25FC File Offset: 0x000D07FC
	// (remove) Token: 0x06001B07 RID: 6919 RVA: 0x000D2634 File Offset: 0x000D0834
	[Browsable(false)]
	internal event EventHandler Event_3
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000026 RID: 38
	// (add) Token: 0x06001B08 RID: 6920 RVA: 0x000D266C File Offset: 0x000D086C
	// (remove) Token: 0x06001B09 RID: 6921 RVA: 0x000D26A4 File Offset: 0x000D08A4
	[Description("Occurs when user paste text from clipboard")]
	public event EventHandler<EventArgs6> Event_4
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_4;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_4;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000027 RID: 39
	// (add) Token: 0x06001B0A RID: 6922 RVA: 0x000D26DC File Offset: 0x000D08DC
	// (remove) Token: 0x06001B0B RID: 6923 RVA: 0x000D2714 File Offset: 0x000D0914
	[Browsable(true)]
	[Description("It occurs before insert, delete, clear, undo and redo operations.")]
	public event EventHandler<EventArgs6> Event_5
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_5;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_5;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000028 RID: 40
	// (add) Token: 0x06001B0C RID: 6924 RVA: 0x000D274C File Offset: 0x000D094C
	// (remove) Token: 0x06001B0D RID: 6925 RVA: 0x000D2784 File Offset: 0x000D0984
	[Browsable(true)]
	[Description("It occurs after changing of selection.")]
	public event EventHandler Event_6
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000029 RID: 41
	// (add) Token: 0x06001B0E RID: 6926 RVA: 0x000D27BC File Offset: 0x000D09BC
	// (remove) Token: 0x06001B0F RID: 6927 RVA: 0x000D27F4 File Offset: 0x000D09F4
	[Browsable(true)]
	[Description("It occurs after changing of visible range.")]
	public event EventHandler Event_7
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400002A RID: 42
	// (add) Token: 0x06001B10 RID: 6928 RVA: 0x000D282C File Offset: 0x000D0A2C
	// (remove) Token: 0x06001B11 RID: 6929 RVA: 0x000D2864 File Offset: 0x000D0A64
	[Description("It occurs after insert, delete, clear, undo and redo operations. This event occurs with a delay relative to TextChanged, and fires only once.")]
	[Browsable(true)]
	public event EventHandler<EventArgs5> Event_8
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs5> eventHandler = this.eventHandler_8;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> eventHandler3 = (EventHandler<EventArgs5>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5>>(ref this.eventHandler_8, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs5> eventHandler = this.eventHandler_8;
			EventHandler<EventArgs5> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs5> eventHandler3 = (EventHandler<EventArgs5>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5>>(ref this.eventHandler_8, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400002B RID: 43
	// (add) Token: 0x06001B12 RID: 6930 RVA: 0x000D289C File Offset: 0x000D0A9C
	// (remove) Token: 0x06001B13 RID: 6931 RVA: 0x000D28D4 File Offset: 0x000D0AD4
	[Description("It occurs after changing of selection. This event occurs with a delay relative to SelectionChanged, and fires only once.")]
	[Browsable(true)]
	public event EventHandler Event_9
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400002C RID: 44
	// (add) Token: 0x06001B14 RID: 6932 RVA: 0x000D290C File Offset: 0x000D0B0C
	// (remove) Token: 0x06001B15 RID: 6933 RVA: 0x000D2944 File Offset: 0x000D0B44
	[Browsable(true)]
	[Description("It occurs after changing of visible range. This event occurs with a delay relative to VisibleRangeChanged, and fires only once.")]
	public event EventHandler Event_10
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_10;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_10;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400002D RID: 45
	// (add) Token: 0x06001B16 RID: 6934 RVA: 0x000D297C File Offset: 0x000D0B7C
	// (remove) Token: 0x06001B17 RID: 6935 RVA: 0x000D29B4 File Offset: 0x000D0BB4
	[Description("It occurs when user click on VisualMarker.")]
	[Browsable(true)]
	public event EventHandler<EventArgs15> Event_11
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs15> eventHandler = this.eventHandler_11;
			EventHandler<EventArgs15> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs15> eventHandler3 = (EventHandler<EventArgs15>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_11, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs15> eventHandler = this.eventHandler_11;
			EventHandler<EventArgs15> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs15> eventHandler3 = (EventHandler<EventArgs15>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_11, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400002E RID: 46
	// (add) Token: 0x06001B18 RID: 6936 RVA: 0x000D29EC File Offset: 0x000D0BEC
	// (remove) Token: 0x06001B19 RID: 6937 RVA: 0x000D2A24 File Offset: 0x000D0C24
	[Browsable(true)]
	[Description("It occurs when visible char is enetering (alphabetic, digit, punctuation, DEL, BACKSPACE).")]
	public event KeyPressEventHandler Event_12
	{
		[CompilerGenerated]
		add
		{
			KeyPressEventHandler keyPressEventHandler = this.keyPressEventHandler_0;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler keyPressEventHandler3 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.keyPressEventHandler_0, keyPressEventHandler3, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			KeyPressEventHandler keyPressEventHandler = this.keyPressEventHandler_0;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler keyPressEventHandler3 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.keyPressEventHandler_0, keyPressEventHandler3, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}
	}

	// Token: 0x1400002F RID: 47
	// (add) Token: 0x06001B1A RID: 6938 RVA: 0x000D2A5C File Offset: 0x000D0C5C
	// (remove) Token: 0x06001B1B RID: 6939 RVA: 0x000D2A94 File Offset: 0x000D0C94
	[Browsable(true)]
	[Description("It occurs when visible char is enetered (alphabetic, digit, punctuation, DEL, BACKSPACE).")]
	public event KeyPressEventHandler Event_13
	{
		[CompilerGenerated]
		add
		{
			KeyPressEventHandler keyPressEventHandler = this.keyPressEventHandler_1;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler keyPressEventHandler3 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.keyPressEventHandler_1, keyPressEventHandler3, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			KeyPressEventHandler keyPressEventHandler = this.keyPressEventHandler_1;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler keyPressEventHandler3 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.keyPressEventHandler_1, keyPressEventHandler3, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}
	}

	// Token: 0x14000030 RID: 48
	// (add) Token: 0x06001B1C RID: 6940 RVA: 0x000D2ACC File Offset: 0x000D0CCC
	// (remove) Token: 0x06001B1D RID: 6941 RVA: 0x000D2B04 File Offset: 0x000D0D04
	[Browsable(true)]
	[Description("It occurs when calculates AutoIndent for new line.")]
	public event EventHandler<EventArgs8> Event_14
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs8> eventHandler = this.eventHandler_12;
			EventHandler<EventArgs8> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs8> eventHandler3 = (EventHandler<EventArgs8>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs8>>(ref this.eventHandler_12, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs8> eventHandler = this.eventHandler_12;
			EventHandler<EventArgs8> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs8> eventHandler3 = (EventHandler<EventArgs8>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs8>>(ref this.eventHandler_12, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000031 RID: 49
	// (add) Token: 0x06001B1E RID: 6942 RVA: 0x000D2B3C File Offset: 0x000D0D3C
	// (remove) Token: 0x06001B1F RID: 6943 RVA: 0x000D2B74 File Offset: 0x000D0D74
	[Browsable(true)]
	[Description("It occurs when line background is painting.")]
	public event EventHandler<EventArgs2> Event_15
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs2> eventHandler = this.eventHandler_13;
			EventHandler<EventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs2> eventHandler3 = (EventHandler<EventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs2>>(ref this.eventHandler_13, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs2> eventHandler = this.eventHandler_13;
			EventHandler<EventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs2> eventHandler3 = (EventHandler<EventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs2>>(ref this.eventHandler_13, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000032 RID: 50
	// (add) Token: 0x06001B20 RID: 6944 RVA: 0x000D2BAC File Offset: 0x000D0DAC
	// (remove) Token: 0x06001B21 RID: 6945 RVA: 0x000D2BE4 File Offset: 0x000D0DE4
	[Description("Occurs when line was inserted/added.")]
	[Browsable(true)]
	public event EventHandler<EventArgs3> Event_16
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs3> eventHandler = this.eventHandler_14;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> eventHandler3 = (EventHandler<EventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs3>>(ref this.eventHandler_14, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs3> eventHandler = this.eventHandler_14;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> eventHandler3 = (EventHandler<EventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs3>>(ref this.eventHandler_14, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000033 RID: 51
	// (add) Token: 0x06001B22 RID: 6946 RVA: 0x000D2C1C File Offset: 0x000D0E1C
	// (remove) Token: 0x06001B23 RID: 6947 RVA: 0x000D2C54 File Offset: 0x000D0E54
	[Description("Occurs when line was removed.")]
	[Browsable(true)]
	public event EventHandler<EventArgs4> Event_17
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs4> eventHandler = this.eventHandler_15;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> eventHandler3 = (EventHandler<EventArgs4>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4>>(ref this.eventHandler_15, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs4> eventHandler = this.eventHandler_15;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> eventHandler3 = (EventHandler<EventArgs4>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4>>(ref this.eventHandler_15, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000034 RID: 52
	// (add) Token: 0x06001B24 RID: 6948 RVA: 0x000D2C8C File Offset: 0x000D0E8C
	// (remove) Token: 0x06001B25 RID: 6949 RVA: 0x000D2CC4 File Offset: 0x000D0EC4
	[Browsable(true)]
	[Description("Occurs when current highlighted folding area is changed.")]
	public event EventHandler<EventArgs> Event_18
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs> eventHandler = this.eventHandler_16;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> eventHandler3 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.eventHandler_16, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs> eventHandler = this.eventHandler_16;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> eventHandler3 = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.eventHandler_16, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000035 RID: 53
	// (add) Token: 0x06001B26 RID: 6950 RVA: 0x000D2CFC File Offset: 0x000D0EFC
	// (remove) Token: 0x06001B27 RID: 6951 RVA: 0x000D2D34 File Offset: 0x000D0F34
	[Browsable(true)]
	[Description("Occurs when undo/redo stack is changed.")]
	public event EventHandler<EventArgs> Event_19
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs> eventHandler = this.eventHandler_17;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> eventHandler3 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.eventHandler_17, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs> eventHandler = this.eventHandler_17;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> eventHandler3 = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.eventHandler_17, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000036 RID: 54
	// (add) Token: 0x06001B28 RID: 6952 RVA: 0x000D2D6C File Offset: 0x000D0F6C
	// (remove) Token: 0x06001B29 RID: 6953 RVA: 0x000D2DA4 File Offset: 0x000D0FA4
	[Browsable(true)]
	[Description("Occurs when component was zoomed.")]
	public event EventHandler Event_20
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_18;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_18, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_18;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_18, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000037 RID: 55
	// (add) Token: 0x06001B2A RID: 6954 RVA: 0x000D2DDC File Offset: 0x000D0FDC
	// (remove) Token: 0x06001B2B RID: 6955 RVA: 0x000D2E14 File Offset: 0x000D1014
	[Description("Occurs when user pressed key, that specified as CustomAction.")]
	[Browsable(true)]
	public event EventHandler<EventArgs11> Event_21
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs11> eventHandler = this.eventHandler_19;
			EventHandler<EventArgs11> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs11> eventHandler3 = (EventHandler<EventArgs11>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs11>>(ref this.eventHandler_19, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs11> eventHandler = this.eventHandler_19;
			EventHandler<EventArgs11> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs11> eventHandler3 = (EventHandler<EventArgs11>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs11>>(ref this.eventHandler_19, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000038 RID: 56
	// (add) Token: 0x06001B2C RID: 6956 RVA: 0x000D2E4C File Offset: 0x000D104C
	// (remove) Token: 0x06001B2D RID: 6957 RVA: 0x000D2E84 File Offset: 0x000D1084
	[Browsable(true)]
	[Description("Occurs when scroolbars are updated.")]
	public event EventHandler Event_22
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_20;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_20, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_20;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_20, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000039 RID: 57
	// (add) Token: 0x06001B2E RID: 6958 RVA: 0x000D2EBC File Offset: 0x000D10BC
	// (remove) Token: 0x06001B2F RID: 6959 RVA: 0x000D2EF4 File Offset: 0x000D10F4
	[Browsable(true)]
	[Description("Occurs when custom wordwrap is needed.")]
	public event EventHandler<EventArgs7> Event_23
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs7> eventHandler = this.eventHandler_21;
			EventHandler<EventArgs7> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs7> eventHandler3 = (EventHandler<EventArgs7>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_21, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs7> eventHandler = this.eventHandler_21;
			EventHandler<EventArgs7> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs7> eventHandler3 = (EventHandler<EventArgs7>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_21, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x000D2F2C File Offset: 0x000D112C
	public List<Class368> method_5(GStruct19 gstruct19_0)
	{
		List<Class368> list = new List<Class368>();
		if (gstruct19_0.int_1 < this.Int32_14 && gstruct19_0.int_0 < this[gstruct19_0.int_1].Count)
		{
			ushort styleIndex_ = (ushort)this[gstruct19_0].styleIndex_0;
			for (int i = 0; i < 16; i++)
			{
				if (((int)styleIndex_ & (1 << i)) != 0)
				{
					list.Add(this.Class368_0[i]);
				}
			}
		}
		return list;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x000128EC File Offset: 0x00010AEC
	protected virtual Class381 vmethod_6()
	{
		return new Class381(this);
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000128F4 File Offset: 0x00010AF4
	private void method_6()
	{
		this.Class381_0.Control3_0 = this;
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x000D2F9C File Offset: 0x000D119C
	protected virtual void vmethod_7(Class381 class381_1)
	{
		if (this.class381_0 != null)
		{
			this.class381_0.Event_0 -= this.method_15;
			this.class381_0.Event_1 -= this.method_14;
			this.class381_0.Event_2 -= this.method_13;
			this.class381_0.Event_3 -= this.method_9;
			this.class381_0.Event_4 -= this.method_7;
			this.class381_0.Event_5 -= this.method_8;
			this.class381_0.Dispose();
		}
		this.list_0.Clear();
		this.method_1();
		if (this.Class308_0 != null)
		{
			this.Class308_0.Clear();
		}
		this.class381_0 = class381_1;
		if (class381_1 != null)
		{
			class381_1.Event_0 += this.method_15;
			class381_1.Event_1 += this.method_14;
			class381_1.Event_2 += this.method_13;
			class381_1.Event_3 += this.method_9;
			class381_1.Event_4 += this.method_7;
			class381_1.Event_5 += this.method_8;
			while (this.list_0.Count < class381_1.Count)
			{
				this.list_0.Add(new GStruct18(-1));
			}
		}
		this.bool_5 = false;
		this.bool_11 = true;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x00012902 File Offset: 0x00010B02
	private void method_7(object sender, Class381.EventArgs14 e)
	{
		this.method_45(e.int_0, e.int_1);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000D311C File Offset: 0x000D131C
	private void method_8(object sender, EventArgs6 e)
	{
		if (this.Class381_0.Control3_0 == this)
		{
			string text = e.String_0;
			this.vmethod_52(ref text);
			e.String_0 = text;
		}
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x000D3150 File Offset: 0x000D1350
	private void method_9(object sender, Class381.EventArgs14 e)
	{
		if (e.int_0 == e.int_1 && !this.Boolean_23 && this.class381_0.Count > 100000)
		{
			this.method_42(e.int_0);
			return;
		}
		this.method_12(false, this.Boolean_23);
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x00012916 File Offset: 0x00010B16
	public void method_10()
	{
		this.method_11(false);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0001291F File Offset: 0x00010B1F
	public void method_11(bool bool_37)
	{
		this.method_12(bool_37, false);
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x00012929 File Offset: 0x00010B29
	public void method_12(bool bool_37, bool bool_38)
	{
		this.bool_11 = true;
		if (bool_38)
		{
			this.point_1 = new Point(0, this.Int32_14 - 1);
			this.bool_13 = true;
		}
		if (bool_37)
		{
			this.method_40();
		}
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x000D31A0 File Offset: 0x000D13A0
	private void method_13(object sender, Class381.EventArgs14 e)
	{
		if (e.int_0 == e.int_1 && !this.Boolean_23)
		{
			this.method_42(e.int_0);
		}
		else
		{
			this.bool_11 = true;
		}
		this.method_4();
		if (this.Class381_0.Control3_0 == this)
		{
			this.vmethod_55(e.int_0, e.int_1);
		}
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x00012959 File Offset: 0x00010B59
	private void method_14(object sender, EventArgs4 e)
	{
		this.list_0.RemoveRange(e.Int32_0, e.Int32_1);
		this.method_120(e.Int32_0, e.Int32_1, e.List_0);
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x000D3200 File Offset: 0x000D1400
	private void method_15(object sender, EventArgs3 e)
	{
		GEnum18 genum = GEnum18.Visible;
		if (e.Int32_0 >= 0 && e.Int32_0 < this.list_0.Count && this.list_0[e.Int32_0].genum18_0 == GEnum18.Hidden)
		{
			genum = GEnum18.Hidden;
		}
		if (e.Int32_1 > 100000)
		{
			this.list_0.Capacity = this.list_0.Count + e.Int32_1 + 1000;
		}
		GStruct18[] array = new GStruct18[e.Int32_1];
		for (int i = 0; i < e.Int32_1; i++)
		{
			array[i].int_0 = -1;
			array[i].genum18_0 = genum;
		}
		this.list_0.InsertRange(e.Int32_0, array);
		if (e.Int32_1 > 1000000)
		{
			GC.Collect();
		}
		this.method_119(e.Int32_0, e.Int32_1);
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x000D32E4 File Offset: 0x000D14E4
	public bool method_16()
	{
		DateTime now = DateTime.Now;
		int num = -1;
		for (int i = 0; i < this.Int32_14; i++)
		{
			if (this.class381_0.vmethod_2(i) && this.class381_0[i].DateTime_0 > this.dateTime_0 && this.class381_0[i].DateTime_0 < now)
			{
				now = this.class381_0[i].DateTime_0;
				num = i;
			}
		}
		if (num >= 0)
		{
			this.method_18(num);
			return true;
		}
		return false;
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000D3374 File Offset: 0x000D1574
	public bool method_17()
	{
		DateTime dateTime = default(DateTime);
		int num = -1;
		for (int i = 0; i < this.Int32_14; i++)
		{
			if (this.class381_0.vmethod_2(i) && this.class381_0[i].DateTime_0 < this.dateTime_0 && this.class381_0[i].DateTime_0 > dateTime)
			{
				dateTime = this.class381_0[i].DateTime_0;
				num = i;
			}
		}
		if (num >= 0)
		{
			this.method_18(num);
			return true;
		}
		return false;
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x0001298A File Offset: 0x00010B8A
	public void method_18(int int_28)
	{
		if (int_28 >= this.Int32_14)
		{
			return;
		}
		this.dateTime_0 = this.class381_0[int_28].DateTime_0;
		this.Class357_5.GStruct19_0 = new GStruct19(0, int_28);
		this.method_51();
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x000129C5 File Offset: 0x00010BC5
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		this.intptr_0 = Control3.ImmGetContext(base.Handle);
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x000D3404 File Offset: 0x000D1604
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.timer_1.Enabled = false;
		if (this.bool_15)
		{
			this.bool_15 = false;
			if (this.class357_1 == null)
			{
				return;
			}
			this.class357_1 = this.Class357_6.vmethod_0(this.class357_1);
			this.class357_1.method_42();
			this.vmethod_8(this.class357_1);
			this.class357_1 = null;
		}
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000129DF File Offset: 0x00010BDF
	public void method_19(Class386 class386_0)
	{
		this.list_2.Add(class386_0);
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x000129ED File Offset: 0x00010BED
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Enabled = false;
		if (this.bool_14)
		{
			this.bool_14 = false;
			this.vmethod_9();
		}
		if (this.bool_16)
		{
			this.bool_16 = false;
			this.vmethod_10();
		}
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x00012A25 File Offset: 0x00010C25
	public virtual void vmethod_8(Class357 class357_9)
	{
		if (this.eventHandler_8 != null)
		{
			this.eventHandler_8(this, new EventArgs5(class357_9));
		}
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x000D346C File Offset: 0x000D166C
	public virtual void vmethod_9()
	{
		this.method_42(this.Class357_5.GStruct19_0.int_1);
		this.method_108();
		if (this.Char_1 != '\0' && this.Char_2 != '\0')
		{
			this.method_109(this.Char_1, this.Char_2, ref this.class357_3, ref this.class357_5);
		}
		if (this.Char_3 != '\0' && this.Char_4 != '\0')
		{
			this.method_109(this.Char_3, this.Char_4, ref this.class357_4, ref this.class357_6);
		}
		if (this.Class357_5.Boolean_2 && this.Class357_5.GStruct19_0.int_1 < this.Int32_14 && this.dateTime_0 != this.class381_0[this.Class357_5.GStruct19_0.int_1].DateTime_0)
		{
			this.class381_0[this.Class357_5.GStruct19_0.int_1].DateTime_0 = DateTime.Now;
			this.dateTime_0 = this.class381_0[this.Class357_5.GStruct19_0.int_1].DateTime_0;
		}
		if (this.eventHandler_9 != null)
		{
			this.eventHandler_9(this, new EventArgs());
		}
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x00012A41 File Offset: 0x00010C41
	public virtual void vmethod_10()
	{
		if (this.eventHandler_10 != null)
		{
			this.eventHandler_10(this, new EventArgs());
		}
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000D35AC File Offset: 0x000D17AC
	private void method_20(global::System.Windows.Forms.Timer timer_4)
	{
		Control3.Class334 @class = new Control3.Class334();
		@class.control3_0 = this;
		@class.timer_0 = timer_4;
		if (base.InvokeRequired)
		{
			base.BeginInvoke(new MethodInvoker(@class.method_0));
			return;
		}
		@class.timer_0.Stop();
		if (base.IsHandleCreated)
		{
			@class.timer_0.Start();
			return;
		}
		this.dictionary_1[@class.timer_0] = @class.timer_0;
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x000D3620 File Offset: 0x000D1820
	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		foreach (global::System.Windows.Forms.Timer timer in new List<global::System.Windows.Forms.Timer>(this.dictionary_1.Keys))
		{
			this.method_20(timer);
		}
		this.dictionary_1.Clear();
		this.vmethod_29();
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x000D3698 File Offset: 0x000D1898
	public int method_21(Class368 class368_0)
	{
		if (class368_0 == null)
		{
			return -1;
		}
		int num = this.method_32(class368_0);
		if (num >= 0)
		{
			return num;
		}
		num = this.method_22();
		this.Class368_0[num] = class368_0;
		return num;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000D36CC File Offset: 0x000D18CC
	public int method_22()
	{
		int num = this.Class368_0.Length - 1;
		while (num >= 0 && this.Class368_0[num] == null)
		{
			num--;
		}
		num++;
		if (num >= this.Class368_0.Length)
		{
			throw new Exception("Maximum count of Styles is exceeded.");
		}
		return num;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00012A5C File Offset: 0x00010C5C
	public virtual void vmethod_11()
	{
		this.vmethod_12(null);
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x000D3714 File Offset: 0x000D1914
	public virtual void vmethod_12(string string_3)
	{
		if (this.FindForm_0 == null)
		{
			this.FindForm_0 = new FindForm(this);
		}
		if (string_3 != null)
		{
			this.FindForm_0.tbFind.Text = string_3;
		}
		else if (!this.Class357_5.Boolean_2 && this.Class357_5.GStruct19_0.int_1 == this.Class357_5.GStruct19_1.int_1)
		{
			this.FindForm_0.tbFind.Text = this.Class357_5.String_1;
		}
		this.FindForm_0.tbFind.SelectAll();
		this.FindForm_0.Show();
		this.FindForm_0.Focus();
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x00012A65 File Offset: 0x00010C65
	public virtual void vmethod_13()
	{
		this.vmethod_14(null);
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000D37BC File Offset: 0x000D19BC
	public virtual void vmethod_14(string string_3)
	{
		if (this.Boolean_9)
		{
			return;
		}
		if (this.ReplaceForm_0 == null)
		{
			this.ReplaceForm_0 = new ReplaceForm(this);
		}
		if (string_3 != null)
		{
			this.ReplaceForm_0.tbFind.Text = string_3;
		}
		else if (!this.Class357_5.Boolean_2 && this.Class357_5.GStruct19_0.int_1 == this.Class357_5.GStruct19_1.int_1)
		{
			this.ReplaceForm_0.tbFind.Text = this.Class357_5.String_1;
		}
		this.ReplaceForm_0.tbFind.SelectAll();
		this.ReplaceForm_0.Show();
		this.ReplaceForm_0.Focus();
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x00012A6E File Offset: 0x00010C6E
	public int method_23(int int_28)
	{
		if (int_28 < 0 || int_28 >= this.class381_0.Count)
		{
			throw new ArgumentOutOfRangeException("Line index out of range");
		}
		return this.class381_0[int_28].Count;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x000D3870 File Offset: 0x000D1A70
	public Class357 method_24(int int_28)
	{
		if (int_28 < 0 || int_28 >= this.class381_0.Count)
		{
			throw new ArgumentOutOfRangeException("Line index out of range");
		}
		return new Class357(this)
		{
			GStruct19_0 = new GStruct19(0, int_28),
			GStruct19_1 = new GStruct19(this.class381_0[int_28].Count, int_28)
		};
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x000D38CC File Offset: 0x000D1ACC
	public virtual void vmethod_15()
	{
		Control3.Class335 @class = new Control3.Class335();
		@class.control3_0 = this;
		if (this.Class357_5.Boolean_2)
		{
			this.Class357_5.method_42();
		}
		if (!this.Class357_5.Boolean_2)
		{
			@class.dataObject_0 = new DataObject();
			this.vmethod_16(@class.dataObject_0);
			Thread thread = new Thread(new ThreadStart(@class.method_0));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x000D3948 File Offset: 0x000D1B48
	protected virtual void vmethod_16(DataObject dataObject_0)
	{
		string text = "<pre>" + new Class329
		{
			Boolean_4 = false,
			Boolean_0 = false,
			Boolean_3 = true
		}.method_1(this.Class357_5.method_6()) + "</pre>";
		dataObject_0.SetData(DataFormats.UnicodeText, true, this.Class357_5.String_1);
		dataObject_0.SetData(DataFormats.Html, Control3.smethod_0(text));
		dataObject_0.SetData(DataFormats.Rtf, new Class330().method_1(this.Class357_5.method_6()));
	}

	// Token: 0x06001B53 RID: 6995
	[DllImport("user32.dll")]
	private static extern IntPtr GetOpenClipboardWindow();

	// Token: 0x06001B54 RID: 6996
	[DllImport("user32.dll")]
	private static extern IntPtr CloseClipboard();

	// Token: 0x06001B55 RID: 6997 RVA: 0x000D39DC File Offset: 0x000D1BDC
	protected void method_25(DataObject dataObject_0)
	{
		try
		{
			Control3.CloseClipboard();
			Clipboard.SetDataObject(dataObject_0, true, 5, 100);
		}
		catch (ExternalException)
		{
		}
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x000D3A10 File Offset: 0x000D1C10
	public static MemoryStream smethod_0(string string_3)
	{
		Encoding utf = Encoding.UTF8;
		string text = "Version:0.9\r\nStartHTML:{0:000000}\r\nEndHTML:{1:000000}\r\nStartFragment:{2:000000}\r\nEndFragment:{3:000000}\r\n";
		string text2 = "<html>\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=" + utf.WebName + "\">\r\n<title>HTML clipboard</title>\r\n</head>\r\n<body>\r\n<!--StartFragment-->";
		string text3 = "<!--EndFragment-->\r\n</body>\r\n</html>\r\n";
		string text4 = string.Format(text, new object[] { 0, 0, 0, 0 });
		int byteCount = utf.GetByteCount(text4);
		int byteCount2 = utf.GetByteCount(text2);
		int byteCount3 = utf.GetByteCount(string_3);
		int byteCount4 = utf.GetByteCount(text3);
		string text5 = string.Format(text, new object[]
		{
			byteCount,
			byteCount + byteCount2 + byteCount3 + byteCount4,
			byteCount + byteCount2,
			byteCount + byteCount2 + byteCount3
		}) + text2 + string_3 + text3;
		return new MemoryStream(utf.GetBytes(text5));
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x000D3AFC File Offset: 0x000D1CFC
	public virtual void vmethod_17()
	{
		Control3.Class336 @class = new Control3.Class336();
		@class.control3_0 = this;
		if (!this.Class357_5.Boolean_2)
		{
			this.vmethod_15();
			this.vmethod_28();
			return;
		}
		if (this.Int32_14 == 1)
		{
			this.Class357_5.method_2();
			this.vmethod_15();
			this.vmethod_28();
			return;
		}
		@class.dataObject_0 = new DataObject();
		this.vmethod_16(@class.dataObject_0);
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		if (this.Class357_5.GStruct19_0.int_1 >= 0 && this.Class357_5.GStruct19_0.int_1 < this.Int32_14)
		{
			int num = this.Class357_5.GStruct19_0.int_1;
			this.method_132(new List<int>(1) { num });
			this.Class357_5.GStruct19_0 = new GStruct19(0, Math.Max(0, Math.Min(num, this.Int32_14 - 1)));
		}
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x000D3C00 File Offset: 0x000D1E00
	public virtual void vmethod_18()
	{
		Control3.Class337 @class = new Control3.Class337();
		@class.string_0 = null;
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		if (this.eventHandler_4 != null)
		{
			EventArgs6 eventArgs = new EventArgs6
			{
				Boolean_0 = false,
				String_0 = @class.string_0
			};
			this.eventHandler_4(this, eventArgs);
			if (eventArgs.Boolean_0)
			{
				@class.string_0 = string.Empty;
			}
			else
			{
				@class.string_0 = eventArgs.String_0;
			}
		}
		if (!string.IsNullOrEmpty(@class.string_0))
		{
			this.vmethod_20(@class.string_0);
		}
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x00012A9E File Offset: 0x00010C9E
	public void method_26()
	{
		this.Class357_5.method_2();
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000D3CA8 File Offset: 0x000D1EA8
	public void method_27()
	{
		if (this.class381_0.Count > 0)
		{
			this.Class357_5.GStruct19_0 = new GStruct19(this.class381_0[this.class381_0.Count - 1].Count, this.class381_0.Count - 1);
		}
		else
		{
			this.Class357_5.GStruct19_0 = new GStruct19(0, 0);
		}
		this.method_49();
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x00012AAB File Offset: 0x00010CAB
	public void method_28()
	{
		this.Class357_5.GStruct19_0 = new GStruct19(0, 0);
		this.method_49();
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x000D3D18 File Offset: 0x000D1F18
	public virtual void vmethod_19()
	{
		this.Class357_5.method_38();
		try
		{
			this.Class357_5.method_2();
			this.vmethod_28();
			this.class381_0.Class312_0.method_5();
			this.method_4();
		}
		finally
		{
			this.Class357_5.method_39();
		}
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x000D3D78 File Offset: 0x000D1F78
	public void method_29()
	{
		for (int i = 0; i < this.Class368_0.Length; i++)
		{
			this.Class368_0[i] = null;
		}
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000D3DA4 File Offset: 0x000D1FA4
	public void method_30(StyleIndex styleIndex_0)
	{
		foreach (Class351 @class in this.class381_0)
		{
			@class.method_0(styleIndex_0);
		}
		for (int i = 0; i < this.list_0.Count; i++)
		{
			this.method_126(i, GEnum18.Visible);
		}
		this.method_4();
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x00012AC5 File Offset: 0x00010CC5
	public void method_31()
	{
		this.class381_0.Class312_0.method_5();
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x00012AD7 File Offset: 0x00010CD7
	public virtual void vmethod_20(string string_3)
	{
		this.vmethod_21(string_3, true);
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000D3E14 File Offset: 0x000D2014
	public virtual void vmethod_21(string string_3, bool bool_37)
	{
		if (string_3 == null)
		{
			return;
		}
		if (string_3 == "\r")
		{
			string_3 = "\n";
		}
		this.class381_0.Class312_0.method_4();
		try
		{
			if (!this.Class357_5.Boolean_2)
			{
				this.class381_0.Class312_0.vmethod_0(new Class319(this.Class381_0));
			}
			if (this.Class381_0.Count > 0 && this.Class357_5.Boolean_2 && this.Class357_5.GStruct19_0.int_0 > this.method_23(this.Class357_5.GStruct19_0.int_1) && this.Boolean_2)
			{
				this.method_38();
			}
			this.class381_0.Class312_0.vmethod_0(new Class317(this.Class381_0, string_3));
			if (this.int_18 <= 0 && bool_37)
			{
				this.method_49();
			}
		}
		finally
		{
			this.class381_0.Class312_0.method_3();
		}
		this.method_4();
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x00012AE1 File Offset: 0x00010CE1
	public virtual Class357 vmethod_22(string string_3, Class368 class368_0)
	{
		return this.vmethod_23(string_3, class368_0, true);
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x000D3F20 File Offset: 0x000D2120
	public virtual Class357 vmethod_23(string string_3, Class368 class368_0, bool bool_37)
	{
		if (string_3 == null)
		{
			return null;
		}
		GStruct19 gstruct = (GStruct19.smethod_4(this.Class357_5.GStruct19_0, this.Class357_5.GStruct19_1) ? this.Class357_5.GStruct19_1 : this.Class357_5.GStruct19_0);
		this.vmethod_21(string_3, bool_37);
		Class357 @class = new Class357(this, gstruct, this.Class357_5.GStruct19_0)
		{
			Boolean_0 = this.Class357_5.Boolean_0
		}.vmethod_0(this.Class357_6);
		@class.method_18(class368_0);
		return @class;
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x000D3FA8 File Offset: 0x000D21A8
	public virtual Class357 vmethod_24(Class357 class357_9, string string_3, Class368 class368_0)
	{
		if (string_3 == null)
		{
			return null;
		}
		int num = this.method_90(this.Class357_5.GStruct19_0);
		int num2 = this.method_90(this.Class357_5.GStruct19_1);
		int num3 = class357_9.String_1.Length;
		int num4 = this.method_90(class357_9.GStruct19_0);
		this.Class357_5.method_38();
		this.Class357_5 = class357_9;
		Class357 @class = this.vmethod_22(string_3, class368_0);
		num3 = @class.String_1.Length - num3;
		this.Class357_5.GStruct19_0 = this.method_91(num + ((num >= num4) ? num3 : 0));
		this.Class357_5.GStruct19_1 = this.method_91(num2 + ((num2 >= num4) ? num3 : 0));
		this.Class357_5.method_39();
		return @class;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00012AEC File Offset: 0x00010CEC
	public virtual void vmethod_25(string string_3)
	{
		this.vmethod_26(string_3, null);
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x000D4060 File Offset: 0x000D2260
	public virtual void vmethod_26(string string_3, Class368 class368_0)
	{
		if (string_3 == null)
		{
			return;
		}
		this.Class357_5.Boolean_0 = false;
		GStruct19 gstruct19_ = this.Class357_5.GStruct19_0;
		GStruct19 gstruct19_2 = this.Class357_5.GStruct19_1;
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		try
		{
			if (this.class381_0.Count > 0)
			{
				this.Class357_5.GStruct19_0 = new GStruct19(this.class381_0[this.class381_0.Count - 1].Count, this.class381_0.Count - 1);
			}
			else
			{
				this.Class357_5.GStruct19_0 = new GStruct19(0, 0);
			}
			GStruct19 gstruct19_3 = this.Class357_5.GStruct19_0;
			this.class381_0.Class312_0.vmethod_0(new Class317(this.Class381_0, string_3));
			if (class368_0 != null)
			{
				new Class357(this, gstruct19_3, this.Class357_5.GStruct19_0).method_18(class368_0);
			}
		}
		finally
		{
			this.class381_0.Class312_0.method_3();
			this.Class357_5.GStruct19_0 = gstruct19_;
			this.Class357_5.GStruct19_1 = gstruct19_2;
			this.Class357_5.method_39();
		}
		this.method_4();
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00012AF6 File Offset: 0x00010CF6
	public int method_32(Class368 class368_0)
	{
		return Array.IndexOf<Class368>(this.Class368_0, class368_0);
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x000D419C File Offset: 0x000D239C
	public StyleIndex method_33(Class368[] class368_0)
	{
		StyleIndex styleIndex = StyleIndex.None;
		foreach (Class368 @class in class368_0)
		{
			int num = this.method_32(@class);
			if (num >= 0)
			{
				styleIndex |= Class357.smethod_0(num);
			}
		}
		return styleIndex;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x000D41D8 File Offset: 0x000D23D8
	internal int method_34(Class368 class368_0)
	{
		int num = this.method_32(class368_0);
		if (num < 0)
		{
			num = this.method_21(class368_0);
		}
		return num;
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000D41FC File Offset: 0x000D23FC
	public static SizeF smethod_1(Font font_2, char char_5)
	{
		Size size = TextRenderer.MeasureText("<" + char_5.ToString() + ">", font_2);
		Size size2 = TextRenderer.MeasureText("<>", font_2);
		return new SizeF((float)(size.Width - size2.Width + 1), (float)font_2.Height);
	}

	// Token: 0x06001B6B RID: 7019
	[DllImport("Imm32.dll")]
	public static extern IntPtr ImmGetContext(IntPtr intptr_1);

	// Token: 0x06001B6C RID: 7020
	[DllImport("Imm32.dll")]
	public static extern IntPtr ImmAssociateContext(IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06001B6D RID: 7021 RVA: 0x000D4250 File Offset: 0x000D2450
	protected override void WndProc(ref Message m)
	{
		if ((m.Msg == 276 || m.Msg == 277) && m.WParam.ToInt32() != 8)
		{
			this.method_4();
		}
		base.WndProc(ref m);
		if (this.Boolean_25 && m.Msg == 641 && m.WParam.ToInt32() == 1)
		{
			Control3.ImmAssociateContext(base.Handle, this.intptr_0);
		}
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x000D42D0 File Offset: 0x000D24D0
	private void method_35()
	{
		if (!this.Boolean_21 && this.Class344_0.Count > 0)
		{
			base.SuspendLayout();
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				this.list_1.Add(control);
			}
			base.Controls.Clear();
		}
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x000D4358 File Offset: 0x000D2558
	private void method_36()
	{
		if (!this.Boolean_21 && this.Class344_0.Count > 0)
		{
			foreach (Control control in this.list_1)
			{
				base.Controls.Add(control);
			}
			this.list_1.Clear();
			base.ResumeLayout(false);
			if (!this.Focused)
			{
				base.Focus();
			}
		}
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x000D43E8 File Offset: 0x000D25E8
	public void method_37(ScrollEventArgs scrollEventArgs_0, bool bool_37)
	{
		this.method_35();
		if (scrollEventArgs_0.ScrollOrientation == ScrollOrientation.VerticalScroll)
		{
			int num = scrollEventArgs_0.NewValue;
			if (bool_37)
			{
				num = (int)(Math.Ceiling(1.0 * (double)num / (double)this.Int32_2) * (double)this.Int32_2);
			}
			base.VerticalScroll.Value = Math.Max(base.VerticalScroll.Minimum, Math.Min(base.VerticalScroll.Maximum, num));
		}
		if (scrollEventArgs_0.ScrollOrientation == ScrollOrientation.HorizontalScroll)
		{
			base.HorizontalScroll.Value = Math.Max(base.HorizontalScroll.Minimum, Math.Min(base.HorizontalScroll.Maximum, scrollEventArgs_0.NewValue));
		}
		this.method_47();
		this.method_36();
		this.method_4();
		base.OnScroll(scrollEventArgs_0);
		this.vmethod_4();
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x00012B04 File Offset: 0x00010D04
	protected override void OnScroll(ScrollEventArgs se)
	{
		this.method_37(se, true);
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x000D44B8 File Offset: 0x000D26B8
	protected virtual void vmethod_27(char char_5)
	{
		this.class381_0.Class312_0.method_4();
		try
		{
			if (!this.Class357_5.Boolean_2)
			{
				this.class381_0.Class312_0.vmethod_0(new Class319(this.Class381_0));
			}
			if (this.Class357_5.Boolean_2 && this.Class357_5.GStruct19_0.int_0 > this.method_23(this.Class357_5.GStruct19_0.int_1) && this.Boolean_2)
			{
				this.method_38();
			}
			this.class381_0.Class312_0.vmethod_0(new Class316(this.Class381_0, char_5));
		}
		finally
		{
			this.class381_0.Class312_0.method_3();
		}
		this.method_4();
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x000D4588 File Offset: 0x000D2788
	private void method_38()
	{
		int num = this.method_23(this.Class357_5.GStruct19_0.int_1);
		int num2 = this.Class357_5.GStruct19_0.int_0 - num;
		this.Class357_5.method_38();
		try
		{
			this.Class357_5.GStruct19_0 = new GStruct19(num, this.Class357_5.GStruct19_0.int_1);
			this.class381_0.Class312_0.vmethod_0(new Class317(this.Class381_0, new string(' ', num2)));
		}
		finally
		{
			this.Class357_5.method_39();
		}
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00012B0E File Offset: 0x00010D0E
	public virtual void vmethod_28()
	{
		if (!this.Class357_5.Boolean_2)
		{
			this.class381_0.Class312_0.vmethod_0(new Class319(this.Class381_0));
			this.method_4();
		}
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x000D462C File Offset: 0x000D282C
	public void method_39()
	{
		this.Class357_5.method_42();
		this.class381_0.Class312_0.vmethod_0(new Class319(this.Class381_0));
		if (this.Class357_5.GStruct19_0.int_1 == 0 && !this.Class357_5.vmethod_1())
		{
			return;
		}
		if (this.Class357_5.GStruct19_0.int_1 > 0)
		{
			this.class381_0.Class312_0.vmethod_0(new Class316(this.Class381_0, '\b'));
		}
		this.method_4();
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x000D46B4 File Offset: 0x000D28B4
	private void method_40()
	{
		if (!this.bool_11)
		{
			return;
		}
		this.bool_11 = false;
		this.Int32_7 = this.Int32_8;
		long num = (long)this.Int32_14 + (long)((ulong)this.uint_0) - 1L;
		int num2 = 2 + ((num > 0L) ? ((int)Math.Log10((double)num)) : 0);
		if (this.Int32_19 + 1 > num2)
		{
			num2 = this.Int32_19 + 1;
		}
		if (base.Created)
		{
			if (this.Boolean_10)
			{
				this.Int32_7 += num2 * this.Int32_4 + 8 + 1;
			}
			if (this.bool_13)
			{
				this.method_45(this.point_1.X, this.point_1.Y);
				this.bool_13 = false;
			}
		}
		else
		{
			this.bool_11 = true;
		}
		this.int_17 = 0;
		this.int_14 = this.method_43();
		int num3;
		this.method_41(out num3, ref this.int_14);
		this.Size_0 = new Size(num3, this.int_17 + this.Padding_0.Top + this.Padding_0.Bottom);
		this.method_47();
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x000D47DC File Offset: 0x000D29DC
	private void method_41(out int int_28, ref int int_29)
	{
		int_28 = this.Int32_7 + int_29 * this.Int32_4 + 2 + this.Padding_0.Left + this.Padding_0.Right;
		if (this.bool_21)
		{
			switch (this.GEnum12_0)
			{
			case GEnum12.WordWrapControlWidth:
			case GEnum12.CharWrapControlWidth:
				int_29 = Math.Min(int_29, (base.ClientSize.Width - this.Int32_7 - this.Padding_0.Left - this.Padding_0.Right) / this.Int32_4);
				int_28 = 0;
				return;
			case GEnum12.WordWrapPreferredWidth:
			case GEnum12.CharWrapPreferredWidth:
				int_29 = Math.Min(int_29, this.Int32_9);
				int_28 = this.Int32_7 + this.Int32_9 * this.Int32_4 + 2 + this.Padding_0.Left + this.Padding_0.Right;
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x000D48D0 File Offset: 0x000D2AD0
	private void method_42(int int_28)
	{
		if (int_28 >= this.class381_0.Count)
		{
			return;
		}
		int count = this.class381_0[int_28].Count;
		if (this.int_14 < count && !this.Boolean_23)
		{
			this.int_14 = count;
		}
		int num;
		this.method_41(out num, ref count);
		if (this.Size_0.Width < num)
		{
			this.Size_0 = new Size(num, this.Size_0.Height);
		}
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x000D494C File Offset: 0x000D2B4C
	private int method_43()
	{
		int num = 0;
		Class381 @class = this.class381_0;
		int count = @class.Count;
		int int32_ = this.Int32_2;
		int top = this.Padding_0.Top;
		this.int_17 = top;
		for (int i = 0; i < count; i++)
		{
			int num2 = @class.m_EBF80696(i);
			GStruct18 gstruct = this.list_0[i];
			if (num2 > num && gstruct.genum18_0 == GEnum18.Visible)
			{
				num = num2;
			}
			gstruct.int_0 = this.int_17;
			this.int_17 += gstruct.Int32_0 * int32_ + gstruct.int_1;
			this.list_0[i] = gstruct;
		}
		this.int_17 -= top;
		return num;
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000D4A10 File Offset: 0x000D2C10
	private int method_44()
	{
		if (this.bool_21)
		{
			switch (this.genum12_0)
			{
			case GEnum12.WordWrapControlWidth:
			case GEnum12.CharWrapControlWidth:
				return base.ClientSize.Width;
			case GEnum12.WordWrapPreferredWidth:
			case GEnum12.CharWrapPreferredWidth:
				return this.Int32_7 + this.Int32_9 * this.Int32_4 + 2 + this.Padding_0.Left + this.Padding_0.Right;
			}
		}
		return int.MaxValue;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x000D4A90 File Offset: 0x000D2C90
	private void method_45(int int_28, int int_29)
	{
		int num = 0;
		bool flag = false;
		int_29 = Math.Min(this.Int32_14 - 1, int_29);
		switch (this.GEnum12_0)
		{
		case GEnum12.WordWrapControlWidth:
			num = (base.ClientSize.Width - this.Int32_7 - this.Padding_0.Left - this.Padding_0.Right) / this.Int32_4;
			break;
		case GEnum12.WordWrapPreferredWidth:
			num = this.Int32_9;
			break;
		case GEnum12.CharWrapControlWidth:
			num = (base.ClientSize.Width - this.Int32_7 - this.Padding_0.Left - this.Padding_0.Right) / this.Int32_4;
			flag = true;
			break;
		case GEnum12.CharWrapPreferredWidth:
			num = this.Int32_9;
			flag = true;
			break;
		}
		for (int i = int_28; i <= int_29; i++)
		{
			if (this.class381_0.vmethod_2(i))
			{
				if (!this.bool_21)
				{
					this.list_0[i].List_0.Clear();
				}
				else
				{
					GStruct18 gstruct = this.list_0[i];
					gstruct.int_2 = (this.Boolean_1 ? (this.class381_0[i].Int32_2 + this.Int32_0) : this.Int32_0);
					if (this.GEnum12_0 == GEnum12.Custom)
					{
						if (this.eventHandler_21 != null)
						{
							this.eventHandler_21(this, new EventArgs7(gstruct.List_0, this.Boolean_25, this.class381_0[i]));
						}
					}
					else
					{
						Control3.smethod_2(gstruct.List_0, num, num - gstruct.int_2, this.Boolean_25, flag, this.class381_0[i]);
					}
					this.list_0[i] = gstruct;
				}
			}
		}
		this.bool_11 = true;
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x000D4C74 File Offset: 0x000D2E74
	public static void smethod_2(List<int> list_3, int int_28, int int_29, bool bool_37, bool bool_38, Class351 class351_0)
	{
		if (int_29 < 1)
		{
			int_29 = 1;
		}
		if (int_28 < 1)
		{
			int_28 = 1;
		}
		int num = 0;
		int num2 = 0;
		list_3.Clear();
		for (int i = 0; i < class351_0.Count - 1; i++)
		{
			char c = class351_0[i].char_0;
			if (bool_38)
			{
				num2 = i + 1;
			}
			else if (bool_37 && Control3.smethod_3(c))
			{
				num2 = i;
			}
			else if (!char.IsLetterOrDigit(c) && c != '_' && c != '\'' && c != '\u00a0' && ((c != '.' && c != ',') || !char.IsDigit(class351_0[i + 1].char_0)))
			{
				num2 = Math.Min(i + 1, class351_0.Count - 1);
			}
			num++;
			if (num == int_28)
			{
				if (num2 == 0 || (list_3.Count > 0 && num2 == list_3[list_3.Count - 1]))
				{
					num2 = i + 1;
				}
				list_3.Add(num2);
				num = 1 + i - num2;
				int_28 = int_29;
			}
		}
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x000D4D60 File Offset: 0x000D2F60
	public static bool smethod_3(char char_5)
	{
		int num = Convert.ToInt32(char_5);
		return (num >= 13056 && num <= 13311) || (num >= 65072 && num <= 65103) || (num >= 63744 && num <= 64255) || (num >= 11904 && num <= 12031) || (num >= 12736 && num <= 12783) || (num >= 19968 && num <= 40959) || (num >= 13312 && num <= 19903) || (num >= 12800 && num <= 13055) || (num >= 9312 && num <= 9471) || (num >= 12352 && num <= 12447) || (num >= 12032 && num <= 12255) || (num >= 12704 && num <= 12735) || (num >= 19904 && num <= 19967) || (num >= 12544 && num <= 12591) || (num >= 12448 && num <= 12543) || (num >= 12784 && num <= 12799) || (num >= 12272 && num <= 12287) || (num >= 4352 && num <= 4607) || (num >= 43360 && num <= 43391) || (num >= 55216 && num <= 55295) || (num >= 12592 && num <= 12687) || (num >= 44032 && num <= 55215);
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x00012B3E File Offset: 0x00010D3E
	protected override void OnClientSizeChanged(EventArgs e)
	{
		base.OnClientSizeChanged(e);
		if (this.Boolean_23)
		{
			this.method_12(false, true);
			this.method_4();
		}
		this.vmethod_4();
		this.method_47();
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x000D4F04 File Offset: 0x000D3104
	internal void method_46(Rectangle rectangle_1)
	{
		this.method_35();
		int value = base.VerticalScroll.Value;
		int num = base.VerticalScroll.Value;
		int num2 = base.HorizontalScroll.Value;
		if (rectangle_1.Bottom > base.ClientRectangle.Height)
		{
			num += rectangle_1.Bottom - base.ClientRectangle.Height;
		}
		else if (rectangle_1.Top < 0)
		{
			num += rectangle_1.Top;
		}
		if (rectangle_1.Right > base.ClientRectangle.Width)
		{
			num2 += rectangle_1.Right - base.ClientRectangle.Width;
		}
		else if (rectangle_1.Left < this.Int32_7)
		{
			num2 += rectangle_1.Left - this.Int32_7;
		}
		if (!this.Boolean_22)
		{
			num = 0;
		}
		num = Math.Max(base.VerticalScroll.Minimum, num);
		num2 = Math.Max(base.HorizontalScroll.Minimum, num2);
		try
		{
			if (base.VerticalScroll.Visible || !this.Boolean_21)
			{
				base.VerticalScroll.Value = Math.Min(num, base.VerticalScroll.Maximum);
			}
			if (base.HorizontalScroll.Visible || !this.Boolean_21)
			{
				base.HorizontalScroll.Value = Math.Min(num2, base.HorizontalScroll.Maximum);
			}
		}
		catch (ArgumentOutOfRangeException)
		{
		}
		this.method_47();
		this.method_36();
		if (value != base.VerticalScroll.Value)
		{
			this.vmethod_4();
		}
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00012B69 File Offset: 0x00010D69
	public void method_47()
	{
		if (this.Boolean_21)
		{
			this.method_48();
		}
		else
		{
			base.PerformLayout();
		}
		if (base.IsHandleCreated)
		{
			base.BeginInvoke(new MethodInvoker(this.vmethod_29));
		}
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000D5098 File Offset: 0x000D3298
	private void method_48()
	{
		if (base.InvokeRequired)
		{
			base.Invoke(new MethodInvoker(this.method_48));
			return;
		}
		base.AutoScrollMinSize -= new Size(1, 0);
		base.AutoScrollMinSize += new Size(1, 0);
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x00012B9D File Offset: 0x00010D9D
	protected virtual void vmethod_29()
	{
		if (this.eventHandler_20 != null)
		{
			this.eventHandler_20(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x000D50F4 File Offset: 0x000D32F4
	public void method_49()
	{
		this.method_4();
		this.method_40();
		Point point = this.method_93(this.Class357_5.GStruct19_0);
		point.Offset(-this.Int32_4, 0);
		this.method_46(new Rectangle(point, new Size(2 * this.Int32_4, 2 * this.Int32_2)));
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x000D5150 File Offset: 0x000D3350
	public void method_50()
	{
		this.method_4();
		base.HorizontalScroll.Value = 0;
		this.Size_0 -= new Size(1, 0);
		this.Size_0 += new Size(1, 0);
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x000D51A0 File Offset: 0x000D33A0
	public void method_51()
	{
		if (this.list_0[this.Class357_5.GStruct19_1.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_99(this.Class357_5.GStruct19_1.int_1);
		}
		if (this.list_0[this.Class357_5.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_99(this.Class357_5.GStruct19_0.int_1);
		}
		this.method_40();
		this.method_46(new Rectangle(this.method_93(new GStruct19(0, this.Class357_5.GStruct19_1.int_1)), new Size(2 * this.Int32_4, 2 * this.Int32_2)));
		Point point = this.method_93(this.Class357_5.GStruct19_0);
		Point point2 = this.method_93(this.Class357_5.GStruct19_1);
		point.Offset(-this.Int32_4, -base.ClientSize.Height / 2);
		this.method_46(new Rectangle(point, new Size(Math.Abs(point2.X - point.X), base.ClientSize.Height)));
		this.method_4();
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x00012BB8 File Offset: 0x00010DB8
	public void method_52(Class357 class357_9)
	{
		this.method_53(class357_9, false);
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x000D52DC File Offset: 0x000D34DC
	public void method_53(Class357 class357_9, bool bool_37)
	{
		class357_9 = class357_9.method_6();
		class357_9.method_40();
		class357_9.GStruct19_1 = new GStruct19(class357_9.GStruct19_1.int_0, Math.Min(class357_9.GStruct19_1.int_1, class357_9.GStruct19_0.int_1 + base.ClientSize.Height / this.Int32_2));
		if (this.list_0[class357_9.GStruct19_1.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_99(class357_9.GStruct19_1.int_1);
		}
		if (this.list_0[class357_9.GStruct19_0.int_1].genum18_0 != GEnum18.Visible)
		{
			this.method_99(class357_9.GStruct19_0.int_1);
		}
		this.method_40();
		int num = (1 + class357_9.GStruct19_1.int_1 - class357_9.GStruct19_0.int_1) * this.Int32_2;
		Point point = this.method_93(new GStruct19(0, class357_9.GStruct19_0.int_1));
		if (bool_37)
		{
			point.Offset(0, -base.ClientSize.Height / 2);
			num = base.ClientSize.Height;
		}
		this.method_46(new Rectangle(point, new Size(2 * this.Int32_4, num)));
		this.method_4();
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x000D5424 File Offset: 0x000D3624
	protected override void OnKeyUp(KeyEventArgs e)
	{
		base.OnKeyUp(e);
		if (e.KeyCode == Keys.ShiftKey)
		{
			this.keys_0 &= ~Keys.Shift;
		}
		if (e.KeyCode == Keys.Alt)
		{
			this.keys_0 &= ~Keys.Alt;
		}
		if (e.KeyCode == Keys.ControlKey)
		{
			this.keys_0 &= ~Keys.Control;
		}
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000D5490 File Offset: 0x000D3690
	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (this.bool_36)
		{
			return;
		}
		base.OnKeyDown(e);
		if (this.Focused)
		{
			this.keys_0 = e.Modifiers;
		}
		this.bool_3 = false;
		if (e.Handled)
		{
			this.bool_3 = true;
			return;
		}
		if (this.vmethod_30(e.KeyData))
		{
			return;
		}
		e.Handled = true;
		this.method_49();
		this.method_4();
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00012BC2 File Offset: 0x00010DC2
	protected override bool ProcessDialogKey(Keys keyData)
	{
		if ((keyData & Keys.Alt) > Keys.None && this.Class347_0.ContainsKey(keyData))
		{
			this.vmethod_30(keyData);
			return true;
		}
		return base.ProcessDialogKey(keyData);
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x000D54FC File Offset: 0x000D36FC
	public virtual bool vmethod_30(Keys keys_1)
	{
		KeyEventArgs e = new KeyEventArgs(keys_1);
		if (e.KeyCode == Keys.Tab && !this.Boolean_3)
		{
			return false;
		}
		if (this.Class355_0 != null && (!this.Class347_0.ContainsKey(keys_1) || (this.Class347_0[keys_1] != FCTBAction.MacroExecute && this.Class347_0[keys_1] != FCTBAction.MacroRecord)))
		{
			this.Class355_0.method_4(keys_1);
		}
		if (this.Class347_0.ContainsKey(keys_1))
		{
			FCTBAction fctbaction = this.Class347_0[keys_1];
			this.method_54(fctbaction);
			if (Control3.dictionary_0.ContainsKey(fctbaction))
			{
				return true;
			}
			if (keys_1 == Keys.Tab || keys_1 == (Keys.LButton | Keys.Back | Keys.Shift))
			{
				this.bool_3 = true;
				return true;
			}
		}
		else
		{
			if (e.KeyCode == Keys.Alt)
			{
				return true;
			}
			if ((e.Modifiers & Keys.Control) != Keys.None)
			{
				return true;
			}
			if ((e.Modifiers & Keys.Alt) != Keys.None)
			{
				if ((Control.MouseButtons & MouseButtons.Left) != MouseButtons.None)
				{
					this.vmethod_50();
				}
				return true;
			}
			if (e.KeyCode == Keys.ShiftKey)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x000D55FC File Offset: 0x000D37FC
	private void method_54(FCTBAction fctbaction_0)
	{
		switch (fctbaction_0)
		{
		case FCTBAction.AutoIndentChars:
			if (!this.Class357_5.Boolean_1)
			{
				this.method_133(this.Class357_5.GStruct19_0.int_1);
				return;
			}
			break;
		case FCTBAction.BookmarkLine:
			this.vmethod_32(this.Class357_5.GStruct19_0.int_1);
			return;
		case FCTBAction.ClearHints:
			this.method_1();
			if (this.Class355_0 != null)
			{
				this.Class355_0.Boolean_1 = false;
				return;
			}
			break;
		case FCTBAction.ClearWordLeft:
			if (!this.method_61('\b'))
			{
				if (!this.Class357_5.Boolean_1)
				{
					if (!this.Class357_5.Boolean_2)
					{
						this.vmethod_28();
					}
					this.Class357_5.method_48(true);
					if (!this.Class357_5.Boolean_1)
					{
						this.vmethod_28();
					}
				}
				this.method_62('\b');
				return;
			}
			break;
		case FCTBAction.ClearWordRight:
			if (!this.method_61('ÿ'))
			{
				if (!this.Class357_5.Boolean_1)
				{
					if (!this.Class357_5.Boolean_2)
					{
						this.vmethod_28();
					}
					this.Class357_5.method_49(true, false);
					if (!this.Class357_5.Boolean_1)
					{
						this.vmethod_28();
					}
				}
				this.method_62('ÿ');
				return;
			}
			break;
		case FCTBAction.CommentSelected:
			this.method_59();
			return;
		case FCTBAction.Copy:
			this.vmethod_15();
			return;
		case FCTBAction.Cut:
			if (!this.Class357_5.Boolean_1)
			{
				this.vmethod_17();
				return;
			}
			break;
		case FCTBAction.DeleteCharRight:
			if (!this.Class357_5.Boolean_1 && !this.method_61('ÿ'))
			{
				if (!this.Class357_5.Boolean_2)
				{
					this.vmethod_28();
				}
				else
				{
					if (this[this.Class357_5.GStruct19_0.int_1].Int32_2 == this[this.Class357_5.GStruct19_0.int_1].Count)
					{
						this.method_65();
					}
					if (!this.Class357_5.method_54() && this.Class357_5.vmethod_1())
					{
						int num = this.Class357_5.GStruct19_0.int_1;
						this.vmethod_27('\b');
						if (num != this.Class357_5.GStruct19_0.int_1 && this.Boolean_18 && this.Class357_5.GStruct19_0.int_0 > 0)
						{
							this.method_65();
						}
					}
				}
				if (this.Boolean_28)
				{
					this.method_133(this.Class357_5.GStruct19_0.int_1);
				}
				this.method_62('ÿ');
				return;
			}
			break;
		case FCTBAction.FindChar:
			this.bool_2 = true;
			return;
		case FCTBAction.FindDialog:
			this.vmethod_11();
			return;
		case FCTBAction.FindNext:
			if (this.FindForm_0 != null && !(this.FindForm_0.tbFind.Text == ""))
			{
				this.FindForm_0.vmethod_0(this.FindForm_0.tbFind.Text);
				return;
			}
			this.vmethod_11();
			return;
		case FCTBAction.GoDown:
			this.Class357_5.method_14(false);
			this.method_50();
			return;
		case FCTBAction.GoDownWithSelection:
			this.Class357_5.method_14(true);
			this.method_50();
			return;
		case FCTBAction.GoDown_ColumnSelectionMode:
			this.vmethod_50();
			if (this.Class357_5.Boolean_0)
			{
				this.Class357_5.method_60();
			}
			this.method_4();
			return;
		case FCTBAction.GoEnd:
			this.Class357_5.method_17(false);
			return;
		case FCTBAction.GoEndWithSelection:
			this.Class357_5.method_17(true);
			return;
		case FCTBAction.GoFirstLine:
			this.Class357_5.method_50(false);
			return;
		case FCTBAction.GoFirstLineWithSelection:
			this.Class357_5.method_50(true);
			return;
		case FCTBAction.GoHome:
			this.method_58(false);
			this.method_50();
			return;
		case FCTBAction.GoHomeWithSelection:
			this.method_58(true);
			this.method_50();
			return;
		case FCTBAction.GoLastLine:
			this.Class357_5.method_51(false);
			return;
		case FCTBAction.GoLastLineWithSelection:
			this.Class357_5.method_51(true);
			return;
		case FCTBAction.GoLeft:
			this.Class357_5.method_10(false);
			return;
		case FCTBAction.GoLeftWithSelection:
			this.Class357_5.method_10(true);
			return;
		case FCTBAction.GoLeft_ColumnSelectionMode:
			this.vmethod_50();
			if (this.Class357_5.Boolean_0)
			{
				this.Class357_5.method_63();
			}
			this.method_4();
			return;
		case FCTBAction.GoPageDown:
			this.Class357_5.method_15(false);
			this.method_50();
			return;
		case FCTBAction.GoPageDownWithSelection:
			this.Class357_5.method_15(true);
			this.method_50();
			return;
		case FCTBAction.GoPageUp:
			this.Class357_5.method_13(false);
			this.method_50();
			return;
		case FCTBAction.GoPageUpWithSelection:
			this.Class357_5.method_13(true);
			this.method_50();
			return;
		case FCTBAction.GoRight:
			this.Class357_5.method_11(false);
			return;
		case FCTBAction.GoRightWithSelection:
			this.Class357_5.method_11(true);
			return;
		case FCTBAction.GoRight_ColumnSelectionMode:
			this.vmethod_50();
			if (this.Class357_5.Boolean_0)
			{
				this.Class357_5.method_62();
			}
			this.method_4();
			return;
		case FCTBAction.GoToDialog:
			this.method_128();
			return;
		case FCTBAction.GoNextBookmark:
			this.method_56(this.Class357_5.GStruct19_0.int_1);
			return;
		case FCTBAction.GoPrevBookmark:
			this.method_57(this.Class357_5.GStruct19_0.int_1);
			return;
		case FCTBAction.GoUp:
			this.Class357_5.method_12(false);
			this.method_50();
			return;
		case FCTBAction.GoUpWithSelection:
			this.Class357_5.method_12(true);
			this.method_50();
			return;
		case FCTBAction.GoUp_ColumnSelectionMode:
			this.vmethod_50();
			if (this.Class357_5.Boolean_0)
			{
				this.Class357_5.method_61();
			}
			this.method_4();
			return;
		case FCTBAction.GoWordLeft:
			this.Class357_5.method_48(false);
			return;
		case FCTBAction.GoWordLeftWithSelection:
			this.Class357_5.method_48(true);
			return;
		case FCTBAction.GoWordRight:
			this.Class357_5.method_49(false, true);
			return;
		case FCTBAction.GoWordRightWithSelection:
			this.Class357_5.method_49(true, true);
			return;
		case FCTBAction.IndentIncrease:
			if (!this.Class357_5.Boolean_1)
			{
				Class357 @class = this.Class357_5.method_6();
				bool flag = GStruct19.smethod_4(@class.GStruct19_0, @class.GStruct19_1);
				@class.method_40();
				int int32_ = this[@class.GStruct19_0.int_1].Int32_2;
				if (@class.GStruct19_0.int_1 == @class.GStruct19_1.int_1 && (@class.GStruct19_0.int_0 > int32_ || @class.GStruct19_1.int_0 != this[@class.GStruct19_0.int_1].Count) && @class.GStruct19_1.int_0 > int32_)
				{
					this.vmethod_41('\t', Keys.None);
					return;
				}
				this.vmethod_69();
				if (@class.GStruct19_0.int_1 == @class.GStruct19_1.int_1 && !@class.Boolean_2)
				{
					this.Class357_5 = new Class357(this, this[@class.GStruct19_0.int_1].Int32_2, @class.GStruct19_1.int_1, this[@class.GStruct19_0.int_1].Count, @class.GStruct19_1.int_1);
					if (flag)
					{
						this.Class357_5.method_41();
						return;
					}
				}
			}
			break;
		case FCTBAction.IndentDecrease:
			if (!this.Class357_5.Boolean_1)
			{
				Class357 class2 = this.Class357_5.method_6();
				if (class2.GStruct19_0.int_1 == class2.GStruct19_1.int_1)
				{
					Class351 class3 = this[class2.GStruct19_0.int_1];
					if (class2.GStruct19_0.int_0 == 0 && class2.GStruct19_1.int_0 == class3.Count)
					{
						this.Class357_5 = new Class357(this, class3.Int32_2, class2.GStruct19_0.int_1, class3.Count, class2.GStruct19_0.int_1);
					}
					else if (class2.GStruct19_0.int_0 == class3.Count && class2.GStruct19_1.int_0 == 0)
					{
						this.Class357_5 = new Class357(this, class3.Count, class2.GStruct19_0.int_1, class3.Int32_2, class2.GStruct19_0.int_1);
					}
				}
				this.vmethod_70();
				return;
			}
			break;
		case FCTBAction.LowerCase:
			if (!this.Class357_5.Boolean_1)
			{
				this.vmethod_37();
				return;
			}
			break;
		case FCTBAction.MacroExecute:
			if (this.Class355_0 != null)
			{
				this.Class355_0.Boolean_1 = false;
				this.Class355_0.method_0();
				return;
			}
			break;
		case FCTBAction.MacroRecord:
			if (this.Class355_0 != null)
			{
				if (this.Class355_0.Boolean_0)
				{
					this.Class355_0.Boolean_1 = !this.Class355_0.Boolean_1;
				}
				if (this.Class355_0.Boolean_1)
				{
					this.Class355_0.method_3();
					return;
				}
			}
			break;
		case FCTBAction.MoveSelectedLinesDown:
			if (!this.Class357_5.Boolean_0)
			{
				this.vmethod_34();
				return;
			}
			break;
		case FCTBAction.MoveSelectedLinesUp:
			if (!this.Class357_5.Boolean_0)
			{
				this.vmethod_35();
				return;
			}
			break;
		case FCTBAction.NavigateBackward:
			this.method_17();
			return;
		case FCTBAction.NavigateForward:
			this.method_16();
			return;
		case FCTBAction.Paste:
			if (!this.Class357_5.Boolean_1)
			{
				this.vmethod_18();
				return;
			}
			break;
		case FCTBAction.Redo:
			if (!this.Boolean_9)
			{
				this.vmethod_48();
				return;
			}
			break;
		case FCTBAction.ReplaceDialog:
			this.vmethod_13();
			return;
		case FCTBAction.ReplaceMode:
			if (!this.Boolean_9)
			{
				this.bool_7 = !this.bool_7;
				return;
			}
			break;
		case FCTBAction.ScrollDown:
			this.method_76(1, -1);
			return;
		case FCTBAction.ScrollUp:
			this.method_76(1, 1);
			return;
		case FCTBAction.SelectAll:
			this.Class357_5.method_2();
			return;
		case FCTBAction.UnbookmarkLine:
			this.vmethod_33(this.Class357_5.GStruct19_0.int_1);
			return;
		case FCTBAction.Undo:
			if (!this.Boolean_9)
			{
				this.vmethod_47();
				return;
			}
			break;
		case FCTBAction.UpperCase:
			if (!this.Class357_5.Boolean_1)
			{
				this.vmethod_36();
				return;
			}
			break;
		case FCTBAction.ZoomIn:
			this.method_77(2);
			return;
		case FCTBAction.ZoomNormal:
			this.method_55();
			return;
		case FCTBAction.ZoomOut:
			this.method_77(-2);
			return;
		case FCTBAction.CustomAction1:
		case FCTBAction.CustomAction2:
		case FCTBAction.CustomAction3:
		case FCTBAction.CustomAction4:
		case FCTBAction.CustomAction5:
		case FCTBAction.CustomAction6:
		case FCTBAction.CustomAction7:
		case FCTBAction.CustomAction8:
		case FCTBAction.CustomAction9:
		case FCTBAction.CustomAction10:
		case FCTBAction.CustomAction11:
		case FCTBAction.CustomAction12:
		case FCTBAction.CustomAction13:
		case FCTBAction.CustomAction14:
		case FCTBAction.CustomAction15:
		case FCTBAction.CustomAction16:
		case FCTBAction.CustomAction17:
		case FCTBAction.CustomAction18:
		case FCTBAction.CustomAction19:
		case FCTBAction.CustomAction20:
			this.vmethod_31(new EventArgs11(fctbaction_0));
			break;
		default:
			return;
		}
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x00012BED File Offset: 0x00010DED
	protected virtual void vmethod_31(EventArgs11 eventArgs11_0)
	{
		if (this.eventHandler_19 != null)
		{
			this.eventHandler_19(this, eventArgs11_0);
		}
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x00012C04 File Offset: 0x00010E04
	private void method_55()
	{
		this.Int32_21 = 100;
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x000D5FE0 File Offset: 0x000D41E0
	public bool method_56(int int_28)
	{
		Class311 @class = null;
		int num = int.MaxValue;
		Class311 class2 = null;
		int num2 = int.MaxValue;
		foreach (Class311 class3 in this.Class308_0)
		{
			if (class3.Int32_0 < num2)
			{
				num2 = class3.Int32_0;
				class2 = class3;
			}
			if (class3.Int32_0 > int_28 && class3.Int32_0 < num)
			{
				num = class3.Int32_0;
				@class = class3;
			}
		}
		if (@class != null)
		{
			@class.vmethod_0();
			return true;
		}
		if (class2 != null)
		{
			class2.vmethod_0();
			return true;
		}
		return false;
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x000D6088 File Offset: 0x000D4288
	public bool method_57(int int_28)
	{
		Class311 @class = null;
		int num = -1;
		Class311 class2 = null;
		int num2 = -1;
		foreach (Class311 class3 in this.Class308_0)
		{
			if (class3.Int32_0 > num2)
			{
				num2 = class3.Int32_0;
				class2 = class3;
			}
			if (class3.Int32_0 < int_28 && class3.Int32_0 > num)
			{
				num = class3.Int32_0;
				@class = class3;
			}
		}
		if (@class != null)
		{
			@class.vmethod_0();
			return true;
		}
		if (class2 != null)
		{
			class2.vmethod_0();
			return true;
		}
		return false;
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x00012C0E File Offset: 0x00010E0E
	public virtual void vmethod_32(int int_28)
	{
		if (!this.Class308_0.m_2C548EAA(int_28))
		{
			this.Class308_0.m_05DAEE07(int_28);
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00012C2A File Offset: 0x00010E2A
	public virtual void vmethod_33(int int_28)
	{
		this.Class308_0.m_D88CF883(int_28);
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000D6128 File Offset: 0x000D4328
	public virtual void vmethod_34()
	{
		Class357 @class = this.Class357_5.method_6();
		this.Class357_5.method_42();
		if (this.Class357_5.Boolean_1)
		{
			this.Class357_5 = @class;
			return;
		}
		int num = this.Class357_5.GStruct19_0.int_1;
		if (this.Class357_5.GStruct19_1.int_1 >= this.Int32_14 - 1)
		{
			this.Class357_5 = @class;
			return;
		}
		string string_ = this.String_5;
		List<int> list = new List<int>();
		for (int i = this.Class357_5.GStruct19_0.int_1; i <= this.Class357_5.GStruct19_1.int_1; i++)
		{
			list.Add(i);
		}
		this.method_132(list);
		this.Class357_5.GStruct19_0 = new GStruct19(this.method_23(num), num);
		this.String_5 = "\n" + string_;
		this.Class357_5.GStruct19_0 = new GStruct19(@class.GStruct19_0.int_0, @class.GStruct19_0.int_1 + 1);
		this.Class357_5.GStruct19_1 = new GStruct19(@class.GStruct19_1.int_0, @class.GStruct19_1.int_1 + 1);
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x000D625C File Offset: 0x000D445C
	public virtual void vmethod_35()
	{
		Class357 @class = this.Class357_5.method_6();
		this.Class357_5.method_42();
		if (this.Class357_5.Boolean_1)
		{
			this.Class357_5 = @class;
			return;
		}
		int num = this.Class357_5.GStruct19_0.int_1;
		if (num == 0)
		{
			this.Class357_5 = @class;
			return;
		}
		string string_ = this.String_5;
		List<int> list = new List<int>();
		for (int i = this.Class357_5.GStruct19_0.int_1; i <= this.Class357_5.GStruct19_1.int_1; i++)
		{
			list.Add(i);
		}
		this.method_132(list);
		this.Class357_5.GStruct19_0 = new GStruct19(0, num - 1);
		this.String_5 = string_ + "\n";
		this.Class357_5.GStruct19_0 = new GStruct19(@class.GStruct19_0.int_0, @class.GStruct19_0.int_1 - 1);
		this.Class357_5.GStruct19_1 = new GStruct19(@class.GStruct19_1.int_0, @class.GStruct19_1.int_1 - 1);
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x000D6374 File Offset: 0x000D4574
	private void method_58(bool bool_37)
	{
		this.Class357_5.method_38();
		try
		{
			int num = this.Class357_5.GStruct19_0.int_1;
			int int32_ = this[num].Int32_2;
			if (this.Class357_5.GStruct19_0.int_0 <= int32_)
			{
				this.Class357_5.method_16(bool_37);
			}
			else
			{
				this.Class357_5.method_16(bool_37);
				for (int i = 0; i < int32_; i++)
				{
					this.Class357_5.method_11(bool_37);
				}
			}
		}
		finally
		{
			this.Class357_5.method_39();
		}
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x000D6410 File Offset: 0x000D4610
	public virtual void vmethod_36()
	{
		Class357 @class = this.Class357_5.method_6();
		this.String_5 = this.String_5.ToUpper();
		this.Class357_5.GStruct19_0 = @class.GStruct19_0;
		this.Class357_5.GStruct19_1 = @class.GStruct19_1;
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x000D645C File Offset: 0x000D465C
	public virtual void vmethod_37()
	{
		Class357 @class = this.Class357_5.method_6();
		this.String_5 = this.String_5.ToLower();
		this.Class357_5.GStruct19_0 = @class.GStruct19_0;
		this.Class357_5.GStruct19_1 = @class.GStruct19_1;
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x000D64A8 File Offset: 0x000D46A8
	public virtual void vmethod_38()
	{
		Class357 @class = this.Class357_5.method_6();
		this.String_5 = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.String_5.ToLower());
		this.Class357_5.GStruct19_0 = @class.GStruct19_0;
		this.Class357_5.GStruct19_1 = @class.GStruct19_1;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x000D6508 File Offset: 0x000D4708
	public virtual void vmethod_39()
	{
		Class357 @class = this.Class357_5.method_6();
		string text = this.String_5.ToLower();
		Regex regex = new Regex("(^\\S)|[\\.\\?!:]\\s+(\\S)", RegexOptions.ExplicitCapture);
		this.String_5 = regex.Replace(text, new MatchEvaluator(Control3.Class333.f_359B8C55.method_0));
		this.Class357_5.GStruct19_0 = @class.GStruct19_0;
		this.Class357_5.GStruct19_1 = @class.GStruct19_1;
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x00012C39 File Offset: 0x00010E39
	public void method_59()
	{
		this.vmethod_40(this.String_1);
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x000D6588 File Offset: 0x000D4788
	public virtual void vmethod_40(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			return;
		}
		this.Class357_5.method_40();
		if (this.class381_0[this.Class357_5.GStruct19_0.int_1].String_2.TrimStart(Array.Empty<char>()).StartsWith(string_3))
		{
			this.vmethod_74(string_3);
			return;
		}
		this.vmethod_73(string_3);
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x00012C47 File Offset: 0x00010E47
	public void method_60(KeyPressEventArgs keyPressEventArgs_0)
	{
		if (this.keyPressEventHandler_0 != null)
		{
			this.keyPressEventHandler_0(this, keyPressEventArgs_0);
		}
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x000D65EC File Offset: 0x000D47EC
	private bool method_61(char char_5)
	{
		if (this.bool_2)
		{
			this.bool_2 = false;
			this.vmethod_42(char_5);
			return true;
		}
		KeyPressEventArgs e = new KeyPressEventArgs(char_5);
		this.method_60(e);
		return e.Handled;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x000D6628 File Offset: 0x000D4828
	public void method_62(char char_5)
	{
		KeyPressEventArgs e = new KeyPressEventArgs(char_5);
		if (this.keyPressEventHandler_1 != null)
		{
			this.keyPressEventHandler_1(this, e);
		}
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00012C5E File Offset: 0x00010E5E
	protected override bool ProcessMnemonic(char charCode)
	{
		return !this.bool_36 && this.Focused && (this.vmethod_41(charCode, this.keys_0) || base.ProcessMnemonic(charCode));
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x000D6654 File Offset: 0x000D4854
	protected override bool ProcessKeyMessage(ref Message m)
	{
		if (m.Msg == 258)
		{
			this.ProcessMnemonic(Convert.ToChar(m.WParam.ToInt32()));
		}
		return base.ProcessKeyMessage(ref m);
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x000D6690 File Offset: 0x000D4890
	public virtual bool vmethod_41(char char_5, Keys keys_1)
	{
		if (this.bool_3)
		{
			return true;
		}
		if (this.Class355_0 != null)
		{
			this.Class355_0.method_5(char_5, keys_1);
		}
		if (char_5 == '\b' && (keys_1 == Keys.None || keys_1 == Keys.Shift || (keys_1 & Keys.Alt) != Keys.None))
		{
			if (this.Boolean_9 || !base.Enabled)
			{
				return false;
			}
			if (this.method_61(char_5))
			{
				return true;
			}
			if (this.Class357_5.Boolean_1)
			{
				return false;
			}
			if (!this.Class357_5.Boolean_2)
			{
				this.vmethod_28();
			}
			else if (!this.Class357_5.method_53())
			{
				this.vmethod_27('\b');
			}
			if (this.Boolean_28)
			{
				this.method_133(this.Class357_5.GStruct19_0.int_1);
			}
			this.method_62('\b');
			return true;
		}
		else
		{
			if (char.IsControl(char_5) && char_5 != '\r' && char_5 != '\t')
			{
				return false;
			}
			if (this.Boolean_9 || !base.Enabled)
			{
				return false;
			}
			if (keys_1 != Keys.None && keys_1 != Keys.Shift && keys_1 != (Keys.Control | Keys.Alt) && keys_1 != (Keys.Shift | Keys.Control | Keys.Alt) && (keys_1 != Keys.Alt || char.IsLetterOrDigit(char_5)))
			{
				return false;
			}
			char c = char_5;
			if (this.method_61(c))
			{
				return true;
			}
			if (this.Class357_5.Boolean_1)
			{
				return false;
			}
			if (char_5 == '\r' && !this.Boolean_4)
			{
				return false;
			}
			if (char_5 == '\r')
			{
				char_5 = '\n';
			}
			if (this.Boolean_15)
			{
				this.Class357_5.method_11(true);
				this.Class357_5.method_41();
			}
			if (!this.Class357_5.Boolean_1 && !this.method_63(char_5))
			{
				this.vmethod_27(char_5);
			}
			if (char_5 == '\n' || this.Boolean_19)
			{
				this.vmethod_43();
			}
			if (this.Boolean_28)
			{
				this.method_133(this.Class357_5.GStruct19_0.int_1);
			}
			this.method_49();
			this.method_4();
			this.method_62(c);
			return true;
		}
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x000D6864 File Offset: 0x000D4A64
	private bool method_63(char char_5)
	{
		if (this.Boolean_0)
		{
			if (!this.Class357_5.Boolean_0)
			{
				for (int i = 1; i < this.Char_0.Length; i += 2)
				{
					if (char_5 == this.Char_0[i] && char_5 == this.Class357_5.Char_0)
					{
						this.Class357_5.method_7();
						return true;
					}
				}
			}
			for (int j = 0; j < this.Char_0.Length; j += 2)
			{
				if (char_5 == this.Char_0[j])
				{
					this.method_64(this.Char_0[j], this.Char_0[j + 1]);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x000D6908 File Offset: 0x000D4B08
	private bool method_64(char char_5, char char_6)
	{
		if (this.Class357_5.Boolean_0)
		{
			Class357 @class = this.Class357_5.method_6();
			@class.method_40();
			this.Class357_5.method_38();
			this.method_106();
			this.Class357_5 = new Class357(this, @class.GStruct19_0.int_0, @class.GStruct19_0.int_1, @class.GStruct19_0.int_0, @class.GStruct19_1.int_1)
			{
				Boolean_0 = true
			};
			this.vmethod_27(char_5);
			this.Class357_5 = new Class357(this, @class.GStruct19_1.int_0 + 1, @class.GStruct19_0.int_1, @class.GStruct19_1.int_0 + 1, @class.GStruct19_1.int_1)
			{
				Boolean_0 = true
			};
			this.vmethod_27(char_6);
			if (@class.Boolean_2)
			{
				this.Class357_5 = new Class357(this, @class.GStruct19_1.int_0 + 1, @class.GStruct19_0.int_1, @class.GStruct19_1.int_0 + 1, @class.GStruct19_1.int_1)
				{
					Boolean_0 = true
				};
			}
			this.method_107();
			this.Class357_5.method_39();
		}
		else if (this.Class357_5.Boolean_2)
		{
			this.vmethod_20(char_5.ToString() + char_6.ToString());
			this.Class357_5.method_8();
		}
		else
		{
			this.vmethod_20(char_5.ToString() + this.String_5 + char_6.ToString());
		}
		return true;
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x000D6A8C File Offset: 0x000D4C8C
	protected virtual void vmethod_42(char char_5)
	{
		if (char_5 == '\r')
		{
			char_5 = '\n';
		}
		Class357 @class = this.Class357_5.method_6();
		while (@class.method_7())
		{
			if (@class.Char_1 == char_5)
			{
				this.Class357_5 = @class;
				this.method_49();
				return;
			}
		}
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x000D6AD4 File Offset: 0x000D4CD4
	public virtual void vmethod_43()
	{
		if (this.Class357_5.Boolean_0)
		{
			return;
		}
		if (this.Boolean_18)
		{
			this.method_49();
			int num = this.vmethod_45(this.Class357_5.GStruct19_0.int_1);
			if (this[this.Class357_5.GStruct19_0.int_1].Int32_1 != num)
			{
				this.vmethod_44(this.Class357_5.GStruct19_0.int_1);
				this[this.Class357_5.GStruct19_0.int_1].Int32_1 = num;
			}
		}
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x00012C8C File Offset: 0x00010E8C
	private void method_65()
	{
		if (!this.Class357_5.Boolean_2)
		{
			return;
		}
		GStruct19 gstruct19_ = this.Class357_5.GStruct19_0;
		while (this.Class357_5.Char_0 == ' ')
		{
			this.Class357_5.method_11(true);
		}
		this.vmethod_28();
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000D6B64 File Offset: 0x000D4D64
	public virtual void vmethod_44(int int_28)
	{
		if (this.Class357_5.Boolean_0)
		{
			return;
		}
		GStruct19 gstruct19_ = this.Class357_5.GStruct19_0;
		int num = this.vmethod_45(int_28);
		int int32_ = this.class381_0[int_28].Int32_2;
		int num2 = num - int32_;
		if (num2 < 0)
		{
			num2 = -Math.Min(-num2, int32_);
		}
		if (num2 == 0)
		{
			return;
		}
		this.Class357_5.GStruct19_0 = new GStruct19(0, int_28);
		if (num2 > 0)
		{
			this.vmethod_20(new string(' ', num2));
		}
		else
		{
			this.Class357_5.GStruct19_0 = new GStruct19(0, int_28);
			this.Class357_5.GStruct19_1 = new GStruct19(-num2, int_28);
			this.vmethod_28();
		}
		this.Class357_5.GStruct19_0 = new GStruct19(Math.Min(this.class381_0[int_28].Count, Math.Max(0, gstruct19_.int_0 + num2)), int_28);
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000D6C40 File Offset: 0x000D4E40
	public virtual int vmethod_45(int int_28)
	{
		if (int_28 >= 0 && int_28 < this.Int32_14)
		{
			EventHandler<EventArgs8> eventHandler = this.eventHandler_12;
			if (eventHandler == null)
			{
				if (this.GEnum21_0 != GEnum21.Custom && this.Class379_0 != null)
				{
					eventHandler = new EventHandler<EventArgs8>(this.Class379_0.vmethod_2);
				}
				else
				{
					eventHandler = new EventHandler<EventArgs8>(this.vmethod_46);
				}
			}
			Stack<EventArgs8> stack = new Stack<EventArgs8>();
			int i;
			for (i = int_28 - 1; i >= 0; i--)
			{
				EventArgs8 eventArgs = new EventArgs8(i, this.class381_0[i].String_2, (i > 0) ? this.class381_0[i - 1].String_2 : "", this.Int32_5, 0);
				eventHandler(this, eventArgs);
				stack.Push(eventArgs);
				if (eventArgs.Int32_2 == 0 && eventArgs.Int32_4 == 0 && eventArgs.String_0.Trim() != "")
				{
					break;
				}
			}
			int num = this.class381_0[(i >= 0) ? i : 0].Int32_2;
			while (stack.Count != 0)
			{
				EventArgs8 eventArgs2 = stack.Pop();
				if (eventArgs2.Int32_4 != 0)
				{
					num = eventArgs2.Int32_4 + eventArgs2.Int32_3;
				}
				else
				{
					num += eventArgs2.Int32_3;
				}
			}
			EventArgs8 eventArgs3 = new EventArgs8(int_28, this.class381_0[int_28].String_2, (int_28 > 0) ? this.class381_0[int_28 - 1].String_2 : "", this.Int32_5, num);
			eventHandler(this, eventArgs3);
			return eventArgs3.Int32_4 + eventArgs3.Int32_2;
		}
		return 0;
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000D6DD8 File Offset: 0x000D4FD8
	internal virtual void vmethod_46(object sender, EventArgs8 e)
	{
		if (string.IsNullOrEmpty(this.class381_0[e.Int32_0].String_1) && !string.IsNullOrEmpty(this.class381_0[e.Int32_0].String_0))
		{
			e.Int32_3 = this.Int32_5;
			return;
		}
		if (!string.IsNullOrEmpty(this.class381_0[e.Int32_0].String_1) && string.IsNullOrEmpty(this.class381_0[e.Int32_0].String_0))
		{
			e.Int32_2 = -this.Int32_5;
			e.Int32_3 = -this.Int32_5;
		}
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000D6E80 File Offset: 0x000D5080
	protected int method_66(int int_28, int int_29)
	{
		if (int_28 > int_29)
		{
			return 0;
		}
		int num = int.MaxValue;
		for (int i = int_28; i <= int_29; i++)
		{
			int int32_ = this.class381_0[i].Int32_2;
			if (int32_ < num)
			{
				num = int32_;
			}
		}
		return num;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x000D6EC0 File Offset: 0x000D50C0
	protected int method_67(int int_28, int int_29)
	{
		if (int_28 > int_29)
		{
			return 0;
		}
		int num = 0;
		for (int i = int_28; i <= int_29; i++)
		{
			int int32_ = this.class381_0[i].Int32_2;
			if (int32_ > num)
			{
				num = int32_;
			}
		}
		return num;
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x00012CCB File Offset: 0x00010ECB
	public virtual void vmethod_47()
	{
		this.class381_0.Class312_0.method_0();
		this.method_49();
		this.method_4();
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x00012CE9 File Offset: 0x00010EE9
	public virtual void vmethod_48()
	{
		this.class381_0.Class312_0.method_6();
		this.method_49();
		this.method_4();
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000D6EFC File Offset: 0x000D50FC
	protected override bool IsInputKey(Keys keyData)
	{
		if ((keyData == Keys.Tab || keyData == (Keys.LButton | Keys.Back | Keys.Shift)) && !this.Boolean_3)
		{
			return false;
		}
		if (keyData == Keys.Return && !this.Boolean_4)
		{
			return false;
		}
		if ((keyData & Keys.Alt) == Keys.None && (keyData & Keys.KeyCode) == Keys.Return)
		{
			return true;
		}
		if ((keyData & Keys.Alt) != Keys.Alt)
		{
			Keys keys = keyData & Keys.KeyCode;
			if (keys == Keys.Tab)
			{
				return (keyData & Keys.Control) == Keys.None;
			}
			if (keys == Keys.Escape)
			{
				return false;
			}
			if (keys - Keys.Prior <= 7)
			{
				return true;
			}
		}
		return base.IsInputKey(keyData);
	}

	// Token: 0x06001BAF RID: 7087
	[DllImport("User32.dll")]
	private static extern bool CreateCaret(IntPtr intptr_1, int int_28, int int_29, int int_30);

	// Token: 0x06001BB0 RID: 7088
	[DllImport("User32.dll")]
	private static extern bool SetCaretPos(int int_28, int int_29);

	// Token: 0x06001BB1 RID: 7089
	[DllImport("User32.dll")]
	private static extern bool DestroyCaret();

	// Token: 0x06001BB2 RID: 7090
	[DllImport("User32.dll")]
	private static extern bool ShowCaret(IntPtr intptr_1);

	// Token: 0x06001BB3 RID: 7091
	[DllImport("User32.dll")]
	private static extern bool HideCaret(IntPtr intptr_1);

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00012D07 File Offset: 0x00010F07
	protected override void OnPaintBackground(PaintEventArgs e)
	{
		if (this.Brush_0 == null)
		{
			base.OnPaintBackground(e);
			return;
		}
		e.Graphics.FillRectangle(this.Brush_0, base.ClientRectangle);
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x000D6F84 File Offset: 0x000D5184
	public void method_68(Graphics graphics_0, GStruct19 gstruct19_0, Size size_1)
	{
		if (this.bool_11)
		{
			this.method_40();
		}
		if (this.bool_12)
		{
			this.vmethod_67();
		}
		Point point = this.method_93(gstruct19_0);
		int num = point.Y + base.VerticalScroll.Value;
		int num2 = point.X + base.HorizontalScroll.Value - this.Int32_7 - this.Padding_0.Left;
		int num3 = gstruct19_0.int_0;
		int num4 = (num2 + size_1.Width) / this.Int32_4;
		for (int i = gstruct19_0.int_1; i < this.class381_0.Count; i++)
		{
			Class351 @class = this.class381_0[i];
			GStruct18 gstruct = this.list_0[i];
			if (gstruct.int_0 > num + size_1.Height)
			{
				break;
			}
			if (gstruct.int_0 + gstruct.Int32_0 * this.Int32_2 >= num && gstruct.genum18_0 != GEnum18.Hidden)
			{
				int num5 = gstruct.int_0 - num;
				graphics_0.SmoothingMode = SmoothingMode.None;
				if (gstruct.genum18_0 == GEnum18.Visible && @class.Brush_0 != null)
				{
					graphics_0.FillRectangle(@class.Brush_0, new Rectangle(0, num5, size_1.Width, this.Int32_2 * gstruct.Int32_0));
				}
				graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
				for (int j = 0; j < gstruct.Int32_0; j++)
				{
					num5 = gstruct.int_0 + j * this.Int32_2 - num;
					int num6 = ((j == 0) ? 0 : (gstruct.int_2 * this.Int32_4));
					this.method_73(graphics_0, num3, num4, i, j, -num2 + num6, num5);
				}
			}
		}
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000D713C File Offset: 0x000D533C
	protected override void OnPaint(PaintEventArgs e)
	{
		if (this.bool_11)
		{
			this.method_40();
		}
		if (this.bool_12)
		{
			this.vmethod_67();
		}
		this.list_2.Clear();
		e.Graphics.SmoothingMode = SmoothingMode.None;
		Pen pen = new Pen(this.Color_9);
		Brush brush = new SolidBrush(this.Color_3);
		Brush brush2 = new SolidBrush(this.Color_5);
		Brush brush3 = new SolidBrush(this.Color_6);
		Brush brush4 = new SolidBrush(Color.FromArgb((int)((this.Color_2.A == byte.MaxValue) ? 50 : this.Color_2.A), this.Color_2));
		Rectangle rectangle = this.Rectangle_0;
		e.Graphics.FillRectangle(brush3, 0, -base.VerticalScroll.Value, base.ClientSize.Width, Math.Max(0, this.Padding_0.Top - 1));
		e.Graphics.FillRectangle(brush3, 0, rectangle.Bottom, base.ClientSize.Width, base.ClientSize.Height);
		e.Graphics.FillRectangle(brush3, rectangle.Right, 0, base.ClientSize.Width, base.ClientSize.Height);
		e.Graphics.FillRectangle(brush3, this.Int32_18, 0, this.Int32_7 - this.Int32_18 - 1, base.ClientSize.Height);
		if (base.HorizontalScroll.Value <= this.Padding_0.Left)
		{
			e.Graphics.FillRectangle(brush3, this.Int32_7 - base.HorizontalScroll.Value - 2, 0, Math.Max(0, this.Padding_0.Left - 1), base.ClientSize.Height);
		}
		Math.Max(this.Int32_7, this.Int32_7 + this.Padding_0.Left - base.HorizontalScroll.Value);
		int width = rectangle.Width;
		e.Graphics.FillRectangle(brush2, 0, 0, this.Int32_18, base.ClientSize.Height);
		if (this.Int32_7 > 8)
		{
			e.Graphics.DrawLine(pen, this.Int32_18, 0, this.Int32_18, base.ClientSize.Height);
		}
		if (this.Int32_9 > 0)
		{
			e.Graphics.DrawLine(pen, new Point(this.Int32_7 + this.Padding_0.Left + this.Int32_9 * this.Int32_4 - base.HorizontalScroll.Value + 1, rectangle.Top + 1), new Point(this.Int32_7 + this.Padding_0.Left + this.Int32_9 * this.Int32_4 - base.HorizontalScroll.Value + 1, rectangle.Bottom - 1));
		}
		this.method_71(e.Graphics);
		int num = Math.Max(0, base.HorizontalScroll.Value - this.Padding_0.Left) / this.Int32_4;
		int num2 = (base.HorizontalScroll.Value + base.ClientSize.Width) / this.Int32_4;
		int num3 = this.Int32_7 + this.Padding_0.Left - base.HorizontalScroll.Value;
		if (num3 < this.Int32_7)
		{
			num++;
		}
		Dictionary<int, Class311> dictionary = new Dictionary<int, Class311>();
		foreach (Class311 @class in this.Class308_0)
		{
			dictionary[@class.Int32_0] = @class;
		}
		int num4 = this.method_81(base.VerticalScroll.Value);
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		int i;
		for (i = num4; i < this.class381_0.Count; i++)
		{
			Class351 class2 = this.class381_0[i];
			GStruct18 gstruct = this.list_0[i];
			if (gstruct.int_0 > base.VerticalScroll.Value + base.ClientSize.Height)
			{
				break;
			}
			if (gstruct.int_0 + gstruct.Int32_0 * this.Int32_2 >= base.VerticalScroll.Value && gstruct.genum18_0 != GEnum18.Hidden)
			{
				int num5 = gstruct.int_0 - base.VerticalScroll.Value;
				e.Graphics.SmoothingMode = SmoothingMode.None;
				if (gstruct.genum18_0 == GEnum18.Visible && class2.Brush_0 != null)
				{
					e.Graphics.FillRectangle(class2.Brush_0, new Rectangle(rectangle.Left, num5, rectangle.Width, this.Int32_2 * gstruct.Int32_0));
				}
				if (this.Color_2 != Color.Transparent && i == this.Class357_5.GStruct19_0.int_1 && this.Class357_5.Boolean_2)
				{
					e.Graphics.FillRectangle(brush4, new Rectangle(rectangle.Left, num5, rectangle.Width, this.Int32_2));
				}
				if (this.Color_3 != Color.Transparent && class2.Boolean_0)
				{
					e.Graphics.FillRectangle(brush, new RectangleF(-10f, (float)num5, (float)(this.Int32_7 - 8 - 2 + 10), (float)(this.Int32_2 + 1)));
				}
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				if (dictionary.ContainsKey(i))
				{
					dictionary[i].vmethod_1(e.Graphics, new Rectangle(this.Int32_7, num5, base.Width, this.Int32_2 * gstruct.Int32_0));
				}
				if (gstruct.genum18_0 == GEnum18.Visible)
				{
					this.vmethod_81(new EventArgs2(i, new Rectangle(this.Int32_7, num5, base.Width, this.Int32_2 * gstruct.Int32_0), e.Graphics, e.ClipRectangle));
				}
				if (this.Boolean_10)
				{
					int num6 = i + (int)this.uint_0;
					Class352 class3 = this.Class352_0;
					if (class3 == null)
					{
						goto IL_063E;
					}
					string text;
					if ((text = class3.vmethod_0(num6)) == null)
					{
						goto IL_063E;
					}
					IL_0650:
					string text2 = text;
					using (SolidBrush solidBrush = new SolidBrush(this.Color_4))
					{
						e.Graphics.DrawString(text2, this.Font, solidBrush, new RectangleF(-10f, (float)num5, (float)(this.Int32_7 - 8 - 2 + 10), (float)(this.Int32_2 + (int)((float)this.int_12 * 0.5f))), new StringFormat(StringFormatFlags.DirectionRightToLeft)
						{
							LineAlignment = StringAlignment.Center
						});
					}
					goto IL_06C0;
					IL_063E:
					text = string.Format("{0}", num6);
					goto IL_0650;
				}
				IL_06C0:
				int num7 = (int)((float)(this.int_10 * this.int_19) / 100f);
				int num8 = num7 / 2;
				if (gstruct.genum18_0 == GEnum18.StartOfHiddenBlock)
				{
					this.list_2.Add(new Class388(i, new Rectangle(this.Int32_18 - num8, num5 + this.Int32_2 / 2 - num8 + 1, num7, num7)));
				}
				if (!string.IsNullOrEmpty(class2.String_0) && gstruct.genum18_0 == GEnum18.Visible && string.IsNullOrEmpty(class2.String_1))
				{
					this.list_2.Add(new Class387(i, new Rectangle(this.Int32_18 - num8, num5 + this.Int32_2 / 2 - num8 + 1, num7, num7)));
				}
				if (gstruct.genum18_0 == GEnum18.Visible && !string.IsNullOrEmpty(class2.String_1) && string.IsNullOrEmpty(class2.String_0))
				{
					e.Graphics.DrawLine(pen, this.Int32_18, num5 + this.Int32_2 * gstruct.Int32_0 - 1, this.Int32_18 + 4, num5 + this.Int32_2 * gstruct.Int32_0 - 1);
				}
				for (int j = 0; j < gstruct.Int32_0; j++)
				{
					num5 = gstruct.int_0 + j * this.Int32_2 - base.VerticalScroll.Value;
					if (num5 > base.VerticalScroll.Value + base.ClientSize.Height)
					{
						break;
					}
					if (gstruct.int_0 + j * this.Int32_2 >= base.VerticalScroll.Value)
					{
						int num9 = ((j == 0) ? 0 : (gstruct.int_2 * this.Int32_4));
						this.method_73(e.Graphics, num, num2, i, j, num3 + num9, num5);
					}
				}
			}
		}
		int num10 = i - 1;
		if (this.Boolean_11)
		{
			this.vmethod_49(e, num4, num10);
		}
		if (this.Class357_5.Boolean_0 && this.Class371_0.Brush_0 is SolidBrush)
		{
			Color color = ((SolidBrush)this.Class371_0.Brush_0).Color;
			Point point = this.method_93(this.Class357_5.GStruct19_0);
			Point point2 = this.method_93(this.Class357_5.GStruct19_1);
			using (Pen pen2 = new Pen(color))
			{
				e.Graphics.DrawRectangle(pen2, Rectangle.FromLTRB(Math.Min(point.X, point2.X) - 1, Math.Min(point.Y, point2.Y), Math.Max(point.X, point2.X), Math.Max(point.Y, point2.Y) + this.Int32_2));
			}
		}
		if (this.Class372_0 != null && this.class357_3 != null && this.class357_5 != null)
		{
			this.Class372_0.m_61500534(e.Graphics, this.method_93(this.class357_3.GStruct19_0), this.class357_3);
			this.Class372_0.m_61500534(e.Graphics, this.method_93(this.class357_5.GStruct19_0), this.class357_5);
		}
		if (this.Class372_1 != null && this.class357_4 != null && this.class357_6 != null)
		{
			this.Class372_1.m_61500534(e.Graphics, this.method_93(this.class357_4.GStruct19_0), this.class357_4);
			this.Class372_1.m_61500534(e.Graphics, this.method_93(this.class357_6.GStruct19_0), this.class357_6);
		}
		e.Graphics.SmoothingMode = SmoothingMode.None;
		if ((this.Int32_12 >= 0 || this.Int32_13 >= 0) && GStruct19.smethod_1(this.Class357_5.GStruct19_0, this.Class357_5.GStruct19_1) && this.Int32_13 < this.list_0.Count)
		{
			int num11 = ((this.Int32_12 >= 0) ? this.list_0[this.Int32_12].int_0 : 0) - base.VerticalScroll.Value + this.Int32_2 / 2;
			int num12 = ((this.Int32_13 >= 0) ? (this.list_0[this.Int32_13].int_0 + (this.list_0[this.Int32_13].Int32_0 - 1) * this.Int32_2) : (this.int_17 + this.Int32_2)) - base.VerticalScroll.Value + this.Int32_2;
			using (Pen pen3 = new Pen(Color.FromArgb(100, this.Color_10), 4f))
			{
				e.Graphics.DrawLine(pen3, this.Int32_7 - 5, num11, this.Int32_7 - 5, num12);
			}
		}
		this.method_72(e.Graphics);
		this.method_69(e, pen);
		Point point3 = this.method_93(this.Class357_5.GStruct19_0);
		int num13 = this.Int32_2 - this.int_12;
		point3.Offset(0, this.int_12 / 2);
		if ((this.Focused || this.Boolean_29 || this.Boolean_7) && point3.X >= this.Int32_7 && this.Boolean_5)
		{
			int num14 = ((this.Boolean_15 || this.Boolean_12) ? this.Int32_4 : 1);
			if (this.Boolean_12)
			{
				using (SolidBrush solidBrush2 = new SolidBrush(this.Color_8))
				{
					e.Graphics.FillRectangle(solidBrush2, point3.X, point3.Y, num14, num13 + 1);
					goto IL_0CC3;
				}
			}
			using (Pen pen4 = new Pen(this.Color_8))
			{
				e.Graphics.DrawLine(pen4, point3.X, point3.Y, point3.X, point3.Y + num13);
			}
			IL_0CC3:
			Rectangle rectangle2 = new Rectangle(base.HorizontalScroll.Value + point3.X, base.VerticalScroll.Value + point3.Y, num14, num13 + 1);
			if (this.Boolean_6 && (this.rectangle_0 != rectangle2 || !this.Boolean_21))
			{
				Control3.CreateCaret(base.Handle, 0, num14, num13 + 1);
				Control3.SetCaretPos(point3.X, point3.Y);
				Control3.ShowCaret(base.Handle);
			}
			this.rectangle_0 = rectangle2;
		}
		else
		{
			Control3.HideCaret(base.Handle);
			this.rectangle_0 = Rectangle.Empty;
		}
		if (!base.Enabled)
		{
			using (SolidBrush solidBrush3 = new SolidBrush(this.Color_7))
			{
				e.Graphics.FillRectangle(solidBrush3, base.ClientRectangle);
			}
		}
		if (this.Class355_0.Boolean_1)
		{
			this.method_70(e.Graphics);
		}
		if (this.bool_36)
		{
			this.method_138(e.Graphics);
		}
		pen.Dispose();
		brush.Dispose();
		brush2.Dispose();
		brush4.Dispose();
		brush3.Dispose();
		base.OnPaint(e);
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000D7F94 File Offset: 0x000D6194
	private void method_69(PaintEventArgs paintEventArgs_0, Pen pen_0)
	{
		foreach (Class386 @class in this.list_2)
		{
			if (@class is Class387)
			{
				using (SolidBrush solidBrush = new SolidBrush(this.Class342_0.Color_1))
				{
					using (Pen pen = new Pen(this.Class342_0.Color_0))
					{
						using (Pen pen2 = new Pen(this.Class342_0.Color_2))
						{
							(@class as Class387).method_0(paintEventArgs_0.Graphics, pen2, solidBrush, pen);
							continue;
						}
					}
				}
			}
			if (@class is Class388)
			{
				using (SolidBrush solidBrush2 = new SolidBrush(this.Class342_0.Color_4))
				{
					using (Pen pen3 = new Pen(this.Class342_0.Color_3))
					{
						using (Pen pen4 = new Pen(this.Class342_0.Color_5))
						{
							(@class as Class388).method_0(paintEventArgs_0.Graphics, pen4, solidBrush2, pen3);
							continue;
						}
					}
				}
			}
			@class.m_64CCB291(paintEventArgs_0.Graphics, pen_0);
		}
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000D8184 File Offset: 0x000D6384
	private void method_70(Graphics graphics_0)
	{
		Control3.Class338 @class = new Control3.Class338();
		@class.control3_0 = this;
		@class.rectangle_0 = new Rectangle(base.ClientRectangle.Right - 75, base.ClientRectangle.Bottom - 13, 75, 13);
		Rectangle rectangle = new Rectangle(-3, -3, 6, 6);
		GraphicsState graphicsState = graphics_0.Save();
		graphics_0.SmoothingMode = SmoothingMode.HighQuality;
		graphics_0.TranslateTransform((float)(@class.rectangle_0.Left + 6), (float)(@class.rectangle_0.Top + 6));
		new TimeSpan(DateTime.Now.Ticks);
		graphics_0.RotateTransform(180f * ((float)DateTime.Now.Millisecond / 1000f));
		using (Pen pen = new Pen(Color.Red, 2f))
		{
			graphics_0.DrawArc(pen, rectangle, 0f, 90f);
			graphics_0.DrawArc(pen, rectangle, 180f, 90f);
		}
		graphics_0.DrawEllipse(Pens.Red, rectangle);
		graphics_0.Restore(graphicsState);
		using (Font font = new Font(FontFamily.GenericSansSerif, 8f))
		{
			graphics_0.DrawString("Recording...", font, Brushes.Red, new PointF((float)(@class.rectangle_0.Left + 13), (float)@class.rectangle_0.Top));
		}
		@class.timer_0 = null;
		@class.timer_0 = new global::System.Threading.Timer(new TimerCallback(@class.method_0), null, 200, -1);
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000D832C File Offset: 0x000D652C
	private void method_71(Graphics graphics_0)
	{
		if (this.GEnum16_0 == GEnum16.None)
		{
			return;
		}
		Rectangle rectangle = this.Rectangle_0;
		if (this.GEnum16_0 == GEnum16.Shadow)
		{
			Rectangle rectangle2 = new Rectangle(rectangle.Left + 4, rectangle.Bottom, rectangle.Width - 4, 4);
			Rectangle rectangle3 = new Rectangle(rectangle.Right, rectangle.Bottom, 4, 4);
			Rectangle rectangle4 = new Rectangle(rectangle.Right, rectangle.Top + 4, 4, rectangle.Height - 4);
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(80, this.Color_1)))
			{
				graphics_0.FillRectangle(solidBrush, rectangle2);
				graphics_0.FillRectangle(solidBrush, rectangle4);
				graphics_0.FillRectangle(solidBrush, rectangle3);
			}
		}
		using (Pen pen = new Pen(this.Color_1))
		{
			graphics_0.DrawRectangle(pen, rectangle);
		}
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x000D842C File Offset: 0x000D662C
	private void method_72(Graphics graphics_0)
	{
		foreach (Class346 @class in this.Class344_0)
		{
			Class357 class2 = @class.Class357_0.method_6();
			class2.method_40();
			Point point = this.method_93(class2.GStruct19_0);
			Point point2 = this.method_93(class2.GStruct19_1);
			if (this.method_127(class2.GStruct19_0.int_1) == GEnum18.Visible && this.method_127(class2.GStruct19_1.int_1) == GEnum18.Visible)
			{
				using (Pen pen = new Pen(@class.Color_2))
				{
					pen.DashStyle = DashStyle.Dash;
					if (class2.Boolean_2)
					{
						point.Offset(1, -1);
						graphics_0.DrawLines(pen, new Point[]
						{
							point,
							new Point(point.X, point.Y + this.int_9 + 2)
						});
					}
					else
					{
						point.Offset(-1, -1);
						point2.Offset(1, -1);
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(point.X + this.Int32_4 / 2, point.Y),
							point,
							new Point(point.X, point.Y + this.int_9 + 2),
							new Point(point.X + this.Int32_4 / 2, point.Y + this.int_9 + 2)
						});
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(point2.X - this.Int32_4 / 2, point2.Y),
							point2,
							new Point(point2.X, point2.Y + this.int_9 + 2),
							new Point(point2.X - this.Int32_4 / 2, point2.Y + this.int_9 + 2)
						});
					}
				}
			}
		}
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000D868C File Offset: 0x000D688C
	protected virtual void vmethod_49(PaintEventArgs paintEventArgs_0, int int_28, int int_29)
	{
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.None;
		using (Pen pen = new Pen(Color.FromArgb(200, this.Color_9))
		{
			DashStyle = DashStyle.Dot
		})
		{
			foreach (KeyValuePair<int, int> keyValuePair in this.dictionary_2)
			{
				if (keyValuePair.Key < int_29 && keyValuePair.Value > int_28)
				{
					Class351 @class = this.class381_0[keyValuePair.Key];
					int num = this.list_0[keyValuePair.Key].int_0 - base.VerticalScroll.Value + this.Int32_2;
					num += num % 2;
					int num2;
					if (keyValuePair.Value >= this.Int32_14)
					{
						num2 = this.list_0[this.Int32_14 - 1].int_0 + this.Int32_2 - base.VerticalScroll.Value;
					}
					else
					{
						if (this.list_0[keyValuePair.Value].genum18_0 != GEnum18.Visible)
						{
							continue;
						}
						int num3 = 0;
						int int32_ = @class.Int32_2;
						if (this.class381_0[keyValuePair.Value].Count <= int32_ || this.class381_0[keyValuePair.Value][int32_].char_0 == ' ')
						{
							num3 = this.Int32_2;
						}
						num2 = this.list_0[keyValuePair.Value].int_0 - base.VerticalScroll.Value + num3;
					}
					int num4 = this.Int32_7 + this.Padding_0.Left + @class.Int32_2 * this.Int32_4 - base.HorizontalScroll.Value;
					if (num4 >= this.Int32_7 + this.Padding_0.Left)
					{
						paintEventArgs_0.Graphics.DrawLine(pen, num4, (num >= 0) ? num : 0, num4, (num2 < base.ClientSize.Height) ? num2 : base.ClientSize.Height);
					}
				}
			}
		}
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x000D88FC File Offset: 0x000D6AFC
	private void method_73(Graphics graphics_0, int int_28, int int_29, int int_30, int int_31, int int_32, int int_33)
	{
		Class351 @class = this.class381_0[int_30];
		GStruct18 gstruct = this.list_0[int_30];
		int num = gstruct.method_0(int_31);
		int_29 = Math.Min(gstruct.method_1(int_31, @class) - num, int_29);
		graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
		if (gstruct.genum18_0 == GEnum18.StartOfHiddenBlock)
		{
			this.Class369_1.m_61500534(graphics_0, new Point(int_32 + int_28 * this.Int32_4, int_33), new Class357(this, num + int_28, int_30, num + int_29 + 1, int_30));
		}
		else
		{
			StyleIndex styleIndex = StyleIndex.None;
			int num2 = int_28 - 1;
			for (int i = int_28; i <= int_29; i++)
			{
				StyleIndex styleIndex_ = @class[num + i].styleIndex_0;
				if (styleIndex != styleIndex_)
				{
					this.method_74(graphics_0, styleIndex, new Point(int_32 + (num2 + 1) * this.Int32_4, int_33), new Class357(this, num + num2 + 1, int_30, num + i, int_30));
					num2 = i - 1;
					styleIndex = styleIndex_;
				}
			}
			this.method_74(graphics_0, styleIndex, new Point(int_32 + (num2 + 1) * this.Int32_4, int_33), new Class357(this, num + num2 + 1, int_30, num + int_29 + 1, int_30));
		}
		if (this.Boolean_24 && int_31 == gstruct.Int32_0 - 1)
		{
			int_29++;
		}
		if (!this.Class357_5.Boolean_2 && int_29 >= int_28)
		{
			graphics_0.SmoothingMode = SmoothingMode.None;
			Class357 class2 = new Class357(this, num + int_28, int_30, num + int_29 + 1, int_30);
			class2 = this.Class357_5.vmethod_0(class2);
			if (class2 != null && this.Class371_0 != null)
			{
				this.Class371_0.m_61500534(graphics_0, new Point(int_32 + (class2.GStruct19_0.int_0 - num) * this.Int32_4, 1 + int_33), class2);
			}
		}
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000D8AB4 File Offset: 0x000D6CB4
	private void method_74(Graphics graphics_0, StyleIndex styleIndex_0, Point point_4, Class357 class357_9)
	{
		if (GStruct19.smethod_4(class357_9.GStruct19_1, class357_9.GStruct19_0))
		{
			int num = 1;
			bool flag = false;
			for (int i = 0; i < this.Class368_0.Length; i++)
			{
				if (this.Class368_0[i] != null && ((int)styleIndex_0 & num) != 0)
				{
					Class368 @class = this.Class368_0[i];
					bool flag2 = @class is Class369;
					if (!flag || !flag2 || this.Boolean_16)
					{
						@class.m_61500534(graphics_0, point_4, class357_9);
					}
					flag = flag || flag2;
				}
				num <<= 1;
			}
			if (!flag)
			{
				this.Class369_0.m_61500534(graphics_0, point_4, class357_9);
			}
		}
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x00012D30 File Offset: 0x00010F30
	protected override void OnEnter(EventArgs e)
	{
		base.OnEnter(e);
		this.bool_8 = false;
		this.bool_9 = false;
		this.class357_2 = null;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00012D4E File Offset: 0x00010F4E
	protected override void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.bool_6 = false;
		if (e.Button == MouseButtons.Left && this.bool_9)
		{
			this.method_75(e);
		}
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000D8B44 File Offset: 0x000D6D44
	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (this.bool_36)
		{
			this.method_136();
			this.bool_8 = false;
			if (e.Button == MouseButtons.Middle)
			{
				this.method_137();
			}
			return;
		}
		this.Class355_0.Boolean_1 = false;
		base.Select();
		base.ActiveControl = null;
		if (e.Button != MouseButtons.Left)
		{
			if (e.Button == MouseButtons.Middle)
			{
				this.method_135(e);
			}
			return;
		}
		Class386 @class = this.method_105(e.Location);
		if (@class != null)
		{
			this.bool_8 = false;
			this.bool_9 = false;
			this.class357_2 = null;
			this.vmethod_76(e, @class);
			return;
		}
		this.bool_8 = true;
		this.bool_9 = false;
		this.class357_2 = null;
		this.bool_6 = e.Location.X < this.Int32_18;
		if (this.bool_6)
		{
			this.vmethod_50();
			this.Class357_5.method_38();
			int num = this.method_83(e.Location).int_1;
			this.int_13 = num;
			this.Class357_5.GStruct19_0 = new GStruct19(0, num);
			this.Class357_5.GStruct19_1 = new GStruct19(this.method_23(num), num);
			this.Class357_5.method_39();
			this.method_4();
			return;
		}
		GStruct19 gstruct = this.method_82(e.Location);
		if (e.Clicks == 2)
		{
			this.bool_8 = false;
			this.bool_9 = false;
			this.class357_2 = null;
			this.method_80(gstruct);
			return;
		}
		if (!this.Class357_5.Boolean_2 && this.Class357_5.method_0(gstruct) && this[gstruct.int_1].Count > gstruct.int_0 && !this.Boolean_9)
		{
			this.bool_9 = true;
			this.bool_8 = false;
			return;
		}
		this.method_75(e);
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000D8D14 File Offset: 0x000D6F14
	private void method_75(MouseEventArgs mouseEventArgs_0)
	{
		GStruct19 gstruct19_ = this.Class357_5.GStruct19_1;
		this.Class357_5.method_38();
		if (this.Class357_5.Boolean_0)
		{
			this.Class357_5.GStruct19_0 = this.method_83(mouseEventArgs_0.Location);
			this.Class357_5.Boolean_0 = true;
		}
		else if (this.Boolean_2)
		{
			this.Class357_5.GStruct19_0 = this.method_83(mouseEventArgs_0.Location);
		}
		else
		{
			this.Class357_5.GStruct19_0 = this.method_82(mouseEventArgs_0.Location);
		}
		if ((this.keys_0 & Keys.Shift) != Keys.None)
		{
			this.Class357_5.GStruct19_1 = gstruct19_;
		}
		this.vmethod_50();
		this.Class357_5.method_39();
		this.method_4();
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00012D7A File Offset: 0x00010F7A
	protected virtual void vmethod_50()
	{
		if ((Control.ModifierKeys & Keys.Alt) != Keys.None && !this.Boolean_23)
		{
			this.Class357_5.Boolean_0 = true;
			return;
		}
		this.Class357_5.Boolean_0 = false;
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000D8DD4 File Offset: 0x000D6FD4
	protected override void OnMouseWheel(MouseEventArgs e)
	{
		this.method_4();
		if (this.keys_0 == Keys.Control)
		{
			this.method_77(2 * Math.Sign(e.Delta));
			((HandledMouseEventArgs)e).Handled = true;
		}
		else if (base.VerticalScroll.Visible || !this.Boolean_21)
		{
			int num = Control3.smethod_4();
			this.method_76(num, e.Delta);
			((HandledMouseEventArgs)e).Handled = true;
		}
		this.method_136();
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x000D8E50 File Offset: 0x000D7050
	private void method_76(int int_28, int int_29)
	{
		if (base.VerticalScroll.Visible || !this.Boolean_21)
		{
			int num = base.ClientSize.Height / this.Int32_2;
			int num2;
			if (int_28 != -1 && int_28 <= num)
			{
				num2 = this.Int32_2 * int_28;
			}
			else
			{
				num2 = this.Int32_2 * num;
			}
			int num3 = base.VerticalScroll.Value - Math.Sign(int_29) * num2;
			ScrollEventArgs e = new ScrollEventArgs((int_29 > 0) ? ScrollEventType.SmallDecrement : ScrollEventType.SmallIncrement, base.VerticalScroll.Value, num3, ScrollOrientation.VerticalScroll);
			this.OnScroll(e);
		}
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x000D8EDC File Offset: 0x000D70DC
	private static int smethod_4()
	{
		int num;
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false))
			{
				num = Convert.ToInt32(registryKey.GetValue("WheelScrollLines"));
			}
		}
		catch
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000D8F3C File Offset: 0x000D713C
	public void method_77(int int_28)
	{
		float sizeInPoints = this.Font.SizeInPoints;
		using (Graphics graphics = Graphics.FromHwnd(base.Handle))
		{
			float dpiY = graphics.DpiY;
			float num = sizeInPoints + (float)int_28 * 72f / dpiY;
			if (num >= 1f)
			{
				float num2 = num / this.font_0.SizeInPoints;
				this.Int32_21 = (int)Math.Round((double)(100f * num2));
			}
		}
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00012DAA File Offset: 0x00010FAA
	protected virtual void vmethod_51()
	{
		if (this.eventHandler_18 != null)
		{
			this.eventHandler_18(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x000D8FC0 File Offset: 0x000D71C0
	private void method_78(float float_0)
	{
		int num = this.method_81(base.VerticalScroll.Value);
		float num2 = this.font_0.SizeInPoints;
		num2 *= float_0;
		if (num2 >= 1f && num2 <= 300f)
		{
			Font font = this.Font;
			this.method_0(new Font(this.Font.FontFamily, num2, this.Font.Style, GraphicsUnit.Point));
			font.Dispose();
			this.method_11(true);
			if (num < this.Int32_14)
			{
				base.VerticalScroll.Value = Math.Min(base.VerticalScroll.Maximum, this.list_0[num].int_0 - this.Padding_0.Top);
			}
			this.method_47();
			this.method_4();
			this.vmethod_4();
			return;
		}
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x00012DC5 File Offset: 0x00010FC5
	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.method_79();
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x000D9094 File Offset: 0x000D7294
	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (this.bool_36)
		{
			return;
		}
		if (this.point_0 != e.Location)
		{
			this.method_79();
			this.timer_2.Start();
		}
		this.point_0 = e.Location;
		if (e.Button == MouseButtons.Left && this.bool_9)
		{
			this.class357_2 = this.Class357_5.method_6();
			base.DoDragDrop(this.String_5, DragDropEffects.Copy);
			this.class357_2 = null;
			return;
		}
		if (e.Button == MouseButtons.Left && this.bool_8)
		{
			GStruct19 gstruct;
			if (!this.Class357_5.Boolean_0 && !this.Boolean_2)
			{
				gstruct = this.method_82(e.Location);
			}
			else
			{
				gstruct = this.method_83(e.Location);
			}
			if (this.bool_6)
			{
				this.Class357_5.method_38();
				int num = gstruct.int_1;
				if (num < this.int_13)
				{
					this.Class357_5.GStruct19_0 = new GStruct19(0, num);
					this.Class357_5.GStruct19_1 = new GStruct19(this.method_23(this.int_13), this.int_13);
				}
				else
				{
					this.Class357_5.GStruct19_0 = new GStruct19(this.method_23(num), num);
					this.Class357_5.GStruct19_1 = new GStruct19(0, this.int_13);
				}
				this.Class357_5.method_39();
				this.method_49();
				base.HorizontalScroll.Value = 0;
				this.method_47();
				this.method_4();
			}
			else if (GStruct19.smethod_0(gstruct, this.Class357_5.GStruct19_0))
			{
				GStruct19 gstruct19_ = this.Class357_5.GStruct19_1;
				this.Class357_5.method_38();
				if (this.Class357_5.Boolean_0)
				{
					this.Class357_5.GStruct19_0 = gstruct;
					this.Class357_5.Boolean_0 = true;
				}
				else
				{
					this.Class357_5.GStruct19_0 = gstruct;
				}
				this.Class357_5.GStruct19_1 = gstruct19_;
				this.Class357_5.method_39();
				this.method_49();
				this.method_4();
				return;
			}
		}
		Class386 @class = this.method_105(e.Location);
		if (@class != null)
		{
			base.Cursor = @class.Cursor_0;
			return;
		}
		if (e.Location.X >= this.Int32_18 && !this.bool_6)
		{
			base.Cursor = this.cursor_0;
			return;
		}
		base.Cursor = Cursors.Arrow;
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x000D92F8 File Offset: 0x000D74F8
	private void method_79()
	{
		this.timer_2.Stop();
		if (this.ToolTip_0 != null && !string.IsNullOrEmpty(this.ToolTip_0.GetToolTip(this)))
		{
			this.ToolTip_0.Hide(this);
			this.ToolTip_0.SetToolTip(this, null);
		}
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000D9344 File Offset: 0x000D7544
	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
		base.OnMouseDoubleClick(e);
		Class386 @class = this.method_105(e.Location);
		if (@class != null)
		{
			this.vmethod_77(@class);
		}
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000D9370 File Offset: 0x000D7570
	private void method_80(GStruct19 gstruct19_0)
	{
		int num = gstruct19_0.int_0;
		int num2 = gstruct19_0.int_0;
		for (int i = gstruct19_0.int_0; i < this.class381_0[gstruct19_0.int_1].Count; i++)
		{
			char c = this.class381_0[gstruct19_0.int_1][i].char_0;
			if (!char.IsLetterOrDigit(c) && c != '_')
			{
				break;
			}
			num2 = i + 1;
		}
		for (int j = gstruct19_0.int_0 - 1; j >= 0; j--)
		{
			char c2 = this.class381_0[gstruct19_0.int_1][j].char_0;
			if (!char.IsLetterOrDigit(c2) && c2 != '_')
			{
				break;
			}
			num = j;
		}
		this.Class357_5 = new Class357(this, num2, gstruct19_0.int_1, num, gstruct19_0.int_1);
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000D9444 File Offset: 0x000D7644
	public int method_81(int int_28)
	{
		int num = this.list_0.BinarySearch(new GStruct18(-10), new Control3.Class332(int_28));
		num = ((num < 0) ? (-num - 2) : num);
		if (num < 0)
		{
			return 0;
		}
		if (num > this.class381_0.Count - 1)
		{
			return this.class381_0.Count - 1;
		}
		return num;
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x000D949C File Offset: 0x000D769C
	public GStruct19 method_82(Point point_4)
	{
		point_4.Offset(base.HorizontalScroll.Value, base.VerticalScroll.Value);
		point_4.Offset(-this.Int32_7 - this.Padding_0.Left, 0);
		int i = this.method_81(point_4.Y);
		if (i < 0)
		{
			return GStruct19.GStruct19_0;
		}
		int num = 0;
		while (i < this.class381_0.Count)
		{
			num = this.list_0[i].int_0 + this.list_0[i].Int32_0 * this.Int32_2;
			if (num > point_4.Y && this.list_0[i].genum18_0 == GEnum18.Visible)
			{
				break;
			}
			i++;
		}
		if (i >= this.class381_0.Count)
		{
			i = this.class381_0.Count - 1;
		}
		if (this.list_0[i].genum18_0 != GEnum18.Visible)
		{
			i = this.method_104(i);
		}
		int num2 = this.list_0[i].Int32_0;
		if (num > point_4.Y)
		{
			int num3 = (num - point_4.Y - this.Int32_2) / this.Int32_2;
			num -= num3 * this.Int32_2;
			num2 -= num3;
		}
		do
		{
			num2--;
			num -= this.Int32_2;
		}
		while (num > point_4.Y);
		if (num2 < 0)
		{
			num2 = 0;
		}
		int num4 = this.list_0[i].method_0(num2);
		int num5 = this.list_0[i].method_1(num2, this.class381_0[i]);
		int num6 = (int)Math.Round((double)((float)point_4.X / (float)this.Int32_4));
		if (num2 > 0)
		{
			num6 -= this.list_0[i].int_2;
		}
		num6 = ((num6 < 0) ? num4 : (num4 + num6));
		if (num6 > num5)
		{
			num6 = num5 + 1;
		}
		if (num6 > this.class381_0[i].Count)
		{
			num6 = this.class381_0[i].Count;
		}
		return new GStruct19(num6, i);
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x000D96B8 File Offset: 0x000D78B8
	private GStruct19 method_83(Point point_4)
	{
		point_4.Offset(base.HorizontalScroll.Value, base.VerticalScroll.Value);
		point_4.Offset(-this.Int32_7 - this.Padding_0.Left, 0);
		int num = this.method_81(point_4.Y);
		int num2 = (int)Math.Round((double)((float)point_4.X / (float)this.Int32_4));
		if (num2 < 0)
		{
			num2 = 0;
		}
		return new GStruct19(num2, num);
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00012DD4 File Offset: 0x00010FD4
	public int method_84(Point point_4)
	{
		return this.method_90(this.method_82(point_4));
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x000D9734 File Offset: 0x000D7934
	public virtual void vmethod_52(ref string string_3)
	{
		this.method_108();
		if (this.eventHandler_5 != null)
		{
			EventArgs6 eventArgs = new EventArgs6
			{
				String_0 = string_3
			};
			this.eventHandler_5(this, eventArgs);
			string_3 = eventArgs.String_0;
			if (eventArgs.Boolean_0)
			{
				string_3 = string.Empty;
			}
		}
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x000D9784 File Offset: 0x000D7984
	public virtual void vmethod_53()
	{
		string text = null;
		this.vmethod_52(ref text);
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x000D979C File Offset: 0x000D799C
	public virtual void vmethod_54()
	{
		Class357 @class = new Class357(this);
		@class.method_2();
		this.vmethod_57(new EventArgs5(@class));
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000D97C4 File Offset: 0x000D79C4
	public virtual void vmethod_55(int int_28, int int_29)
	{
		this.vmethod_57(new EventArgs5(new Class357(this)
		{
			GStruct19_0 = new GStruct19(0, Math.Min(int_28, int_29)),
			GStruct19_1 = new GStruct19(this.class381_0[Math.Max(int_28, int_29)].Count, Math.Max(int_28, int_29))
		}));
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00012DE3 File Offset: 0x00010FE3
	public virtual void vmethod_56(Class357 class357_9)
	{
		this.vmethod_57(new EventArgs5(class357_9));
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x00012DF1 File Offset: 0x00010FF1
	public void method_85()
	{
		if (this.int_18 == 0)
		{
			this.class357_7 = null;
		}
		this.int_18++;
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x00012E10 File Offset: 0x00011010
	public void method_86()
	{
		this.int_18--;
		if (this.int_18 == 0 && this.class357_7 != null)
		{
			this.class357_7.method_42();
			this.vmethod_56(this.class357_7);
		}
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000D9820 File Offset: 0x000D7A20
	protected virtual void vmethod_57(EventArgs5 eventArgs5_0)
	{
		eventArgs5_0.Class357_0.method_40();
		if (this.int_18 <= 0)
		{
			this.method_79();
			this.method_1();
			this.Boolean_8 = true;
			int int32_ = this.Int32_6;
			this.Int32_6 = int32_ + 1;
			this.method_88(eventArgs5_0.Class357_0);
			this.method_87(eventArgs5_0.Class357_0);
			if (this.bool_21)
			{
				this.method_45(eventArgs5_0.Class357_0.GStruct19_0.int_1, eventArgs5_0.Class357_0.GStruct19_1.int_1);
			}
			base.OnTextChanged(eventArgs5_0);
			if (this.class357_1 == null)
			{
				this.class357_1 = eventArgs5_0.Class357_0.method_6();
			}
			else
			{
				this.class357_1 = this.class357_1.method_1(eventArgs5_0.Class357_0);
			}
			this.bool_15 = true;
			this.method_20(this.timer_1);
			this.vmethod_78(eventArgs5_0);
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, eventArgs5_0);
			}
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
			base.OnTextChanged(EventArgs.Empty);
			this.vmethod_4();
			return;
		}
		if (this.class357_7 == null)
		{
			this.class357_7 = eventArgs5_0.Class357_0.method_6();
			return;
		}
		if (this.class357_7.GStruct19_0.int_1 > eventArgs5_0.Class357_0.GStruct19_0.int_1)
		{
			this.class357_7.GStruct19_0 = new GStruct19(0, eventArgs5_0.Class357_0.GStruct19_0.int_1);
		}
		if (this.class357_7.GStruct19_1.int_1 < eventArgs5_0.Class357_0.GStruct19_1.int_1)
		{
			this.class357_7.GStruct19_1 = new GStruct19(this.class381_0[eventArgs5_0.Class357_0.GStruct19_1.int_1].Count, eventArgs5_0.Class357_0.GStruct19_1.int_1);
		}
		this.class357_7 = this.class357_7.vmethod_0(this.Class357_6);
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000D9A18 File Offset: 0x000D7C18
	private void method_87(Class357 class357_9)
	{
		for (int i = class357_9.GStruct19_0.int_1; i <= class357_9.GStruct19_1.int_1; i++)
		{
			if (i >= 0 && i < this.class381_0.Count)
			{
				this.Dictionary_0.Remove(this[i].Int32_0);
			}
		}
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x000D9A70 File Offset: 0x000D7C70
	private void method_88(Class357 class357_9)
	{
		for (int i = class357_9.GStruct19_0.int_1; i <= class357_9.GStruct19_1.int_1; i++)
		{
			if (i >= 0 && i < this.class381_0.Count)
			{
				this.class381_0[i].Boolean_0 = true;
			}
		}
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x00012E47 File Offset: 0x00011047
	public virtual void vmethod_58()
	{
		if (this.Boolean_14)
		{
			this.method_89();
		}
		this.bool_14 = true;
		this.method_20(this.timer_0);
		if (this.eventHandler_6 != null)
		{
			this.eventHandler_6(this, new EventArgs());
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x000D9AC4 File Offset: 0x000D7CC4
	private void method_89()
	{
		if (this.Int32_14 == 0)
		{
			return;
		}
		int int32_ = this.Int32_12;
		int int32_2 = this.Int32_13;
		this.Int32_12 = -1;
		this.Int32_13 = -1;
		int num = 0;
		for (int i = this.Class357_5.GStruct19_0.int_1; i >= Math.Max(this.Class357_5.GStruct19_0.int_1 - 3000, 0); i--)
		{
			bool flag = this.class381_0.m_87D86B1A(i);
			bool flag2;
			if (!(flag2 = this.class381_0.m_BC8D0B8B(i)) || !flag)
			{
				if (flag)
				{
					num--;
					if (num == -1)
					{
						this.Int32_12 = i;
						IL_00B1:
						if (this.Int32_12 >= 0)
						{
							this.Int32_13 = this.vmethod_66(this.Int32_12, 3000);
							if (this.Int32_13 == this.Int32_12)
							{
								this.Int32_13 = -1;
							}
						}
						if (this.Int32_12 != int32_ || this.Int32_13 != int32_2)
						{
							this.vmethod_59();
						}
						return;
					}
				}
				if (flag2 && i != this.Class357_5.GStruct19_0.int_1)
				{
					num++;
				}
			}
		}
		{
			if (this.Int32_12 >= 0)
			{
				this.Int32_13 = this.vmethod_66(this.Int32_12, 3000);
				if (this.Int32_13 == this.Int32_12)
				{
					this.Int32_13 = -1;
				}
			}
			if (this.Int32_12 != int32_ || this.Int32_13 != int32_2)
			{
				this.vmethod_59();
			}
			return;
		}
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00012E83 File Offset: 0x00011083
	protected virtual void vmethod_59()
	{
		if (this.eventHandler_16 != null)
		{
			this.eventHandler_16(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00012E9E File Offset: 0x0001109E
	protected override void OnGotFocus(EventArgs e)
	{
		this.method_6();
		base.OnGotFocus(e);
		this.method_4();
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00012EB3 File Offset: 0x000110B3
	protected override void OnLostFocus(EventArgs e)
	{
		this.keys_0 = Keys.None;
		this.method_136();
		base.OnLostFocus(e);
		this.method_4();
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x000D9BD0 File Offset: 0x000D7DD0
	public int method_90(GStruct19 gstruct19_0)
	{
		if (gstruct19_0.int_1 >= 0 && gstruct19_0.int_1 < this.class381_0.Count && gstruct19_0.int_0 < this.class381_0[gstruct19_0.int_1].Count + Environment.NewLine.Length)
		{
			int num = 0;
			for (int i = 0; i < gstruct19_0.int_1; i++)
			{
				num += this.class381_0[i].Count + Environment.NewLine.Length;
			}
			return num + gstruct19_0.int_0;
		}
		return -1;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000D9C60 File Offset: 0x000D7E60
	public GStruct19 method_91(int int_28)
	{
		if (int_28 < 0)
		{
			return new GStruct19(0, 0);
		}
		for (int i = 0; i < this.class381_0.Count; i++)
		{
			int num = this.class381_0[i].Count + Environment.NewLine.Length;
			if (int_28 < this.class381_0[i].Count)
			{
				return new GStruct19(int_28, i);
			}
			if (int_28 < num)
			{
				return new GStruct19(this.class381_0[i].Count, i);
			}
			int_28 -= num;
		}
		if (this.class381_0.Count > 0)
		{
			return new GStruct19(this.class381_0[this.class381_0.Count - 1].Count, this.class381_0.Count - 1);
		}
		return new GStruct19(0, 0);
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00012ECF File Offset: 0x000110CF
	public Point method_92(int int_28)
	{
		return this.method_93(this.method_91(int_28));
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000D9D30 File Offset: 0x000D7F30
	public Point method_93(GStruct19 gstruct19_0)
	{
		if (gstruct19_0.int_1 >= this.list_0.Count)
		{
			return default(Point);
		}
		int num = this.list_0[gstruct19_0.int_1].int_0;
		int num2 = this.list_0[gstruct19_0.int_1].method_2(gstruct19_0.int_0);
		num += num2 * this.Int32_2;
		int num3 = (gstruct19_0.int_0 - this.list_0[gstruct19_0.int_1].method_0(num2)) * this.Int32_4;
		if (num2 > 0)
		{
			num3 += this.list_0[gstruct19_0.int_1].int_2 * this.Int32_4;
		}
		num -= base.VerticalScroll.Value;
		num3 = this.Int32_7 + this.Padding_0.Left + num3 - base.HorizontalScroll.Value;
		return new Point(num3, num);
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00012EDE File Offset: 0x000110DE
	public Class357 method_94(int int_28, int int_29)
	{
		return new Class357(this)
		{
			GStruct19_0 = this.method_91(int_28),
			GStruct19_1 = this.method_91(int_29)
		};
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00012F00 File Offset: 0x00011100
	public Class357 method_95(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return new Class357(this, gstruct19_0, gstruct19_1);
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00012F0A File Offset: 0x0001110A
	public IEnumerable<Class357> method_96(string string_3)
	{
		Control3.Class339 @class = new Control3.Class339(-2);
		@class.control3_0 = this;
		@class.string_1 = string_3;
		return @class;
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00012F21 File Offset: 0x00011121
	public IEnumerable<Class357> method_97(string string_3, RegexOptions regexOptions_0)
	{
		Control3.Class340 @class = new Control3.Class340(-2);
		@class.control3_0 = this;
		@class.string_1 = string_3;
		@class.regexOptions_1 = regexOptions_0;
		return @class;
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x000D9E28 File Offset: 0x000D8028
	public string method_98(int int_28)
	{
		if (int_28 >= 0 && int_28 < this.class381_0.Count)
		{
			StringBuilder stringBuilder = new StringBuilder(this.class381_0[int_28].Count);
			using (IEnumerator<GStruct17> enumerator = this.class381_0[int_28].GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GStruct17 gstruct = enumerator.Current;
					stringBuilder.Append(gstruct.char_0);
				}
				goto IL_0071;
			}
			goto IL_0066;
			IL_0071:
			return stringBuilder.ToString();
		}
		IL_0066:
		throw new ArgumentOutOfRangeException("Line index out of range");
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x000D9EBC File Offset: 0x000D80BC
	public virtual void vmethod_60(int int_28)
	{
		if (int_28 >= 0 && int_28 < this.class381_0.Count)
		{
			int i;
			for (i = int_28; i < this.Int32_14 - 1; i++)
			{
				if (this.list_0[i + 1].genum18_0 != GEnum18.Hidden)
				{
					IL_0048:
					this.vmethod_62(int_28, i);
					this.Dictionary_0.Remove(this[int_28].Int32_0);
					this.vmethod_61();
					return;
				}
			}
			{
				this.vmethod_62(int_28, i);
				this.Dictionary_0.Remove(this[int_28].Int32_0);
				this.vmethod_61();
				return;
			}
		}
		throw new ArgumentOutOfRangeException("Line index out of range");
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x000D9F38 File Offset: 0x000D8138
	public virtual void vmethod_61()
	{
		for (int i = 0; i < this.Int32_14; i++)
		{
			if (this.list_0[i].genum18_0 == GEnum18.Visible && this.Dictionary_0.ContainsKey(this[i].Int32_0))
			{
				this.vmethod_65(i);
			}
		}
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x000D9F8C File Offset: 0x000D818C
	public virtual void vmethod_62(int int_28, int int_29)
	{
		int num = Math.Min(int_28, int_29);
		int num2 = Math.Max(int_28, int_29);
		for (int i = num; i <= num2; i++)
		{
			this.method_126(i, GEnum18.Visible);
		}
		this.bool_11 = true;
		this.method_4();
		this.vmethod_4();
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000D9FD0 File Offset: 0x000D81D0
	public void method_99(int int_28)
	{
		if (this.list_0[int_28].genum18_0 == GEnum18.Visible)
		{
			return;
		}
		int num = int_28;
		while (num < this.Int32_14 && this.list_0[num].genum18_0 != GEnum18.Visible)
		{
			this.method_126(num, GEnum18.Visible);
			this.bool_11 = true;
			num++;
		}
		int num2 = int_28 - 1;
		while (num2 >= 0 && this.list_0[num2].genum18_0 != GEnum18.Visible)
		{
			this.method_126(num2, GEnum18.Visible);
			this.bool_11 = true;
			num2--;
		}
		this.method_4();
		this.vmethod_4();
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000DA060 File Offset: 0x000D8260
	public virtual void vmethod_63()
	{
		for (int i = 0; i < this.Int32_14; i++)
		{
			if (this.class381_0.m_87D86B1A(i))
			{
				int num = this.method_100(i);
				if (num >= 0)
				{
					this.vmethod_68(i, num);
					i = num;
				}
			}
		}
		this.vmethod_4();
		this.method_47();
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x000DA0B0 File Offset: 0x000D82B0
	public virtual void vmethod_64()
	{
		for (int i = 0; i < this.Int32_14; i++)
		{
			this.method_126(i, GEnum18.Visible);
		}
		this.Dictionary_0.Clear();
		this.vmethod_4();
		this.method_4();
		this.method_47();
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x000DA0F4 File Offset: 0x000D82F4
	public virtual void vmethod_65(int int_28)
	{
		if (int_28 < 0 || int_28 >= this.class381_0.Count)
		{
			throw new ArgumentOutOfRangeException("Line index out of range");
		}
		if (string.IsNullOrEmpty(this.class381_0[int_28].String_0))
		{
			throw new ArgumentOutOfRangeException("This line is not folding start line");
		}
		int num = this.method_100(int_28);
		if (num >= 0)
		{
			this.vmethod_68(int_28, num);
			int int32_ = this[int_28].Int32_0;
			this.Dictionary_0[int32_] = int32_;
		}
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00012F3F File Offset: 0x0001113F
	private int method_100(int int_28)
	{
		return this.vmethod_66(int_28, int.MaxValue);
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x000DA174 File Offset: 0x000D8374
	protected virtual int vmethod_66(int int_28, int int_29)
	{
		string text = this.class381_0[int_28].String_0;
		Stack<string> stack = new Stack<string>();
		GEnum14 genum = this.GEnum14_0;
		if (genum != GEnum14.Strategy1)
		{
			if (genum == GEnum14.Strategy2)
			{
				for (int i = int_28; i < this.Int32_14; i++)
				{
					if (this.class381_0.m_BC8D0B8B(i))
					{
						string text2 = this.class381_0[i].String_1;
						while (stack.Count > 0 && stack.Pop() != text2)
						{
						}
						if (stack.Count == 0)
						{
							return i;
						}
					}
					if (this.class381_0.m_87D86B1A(i))
					{
						stack.Push(this.class381_0[i].String_0);
					}
					int_29--;
					if (int_29 < 0)
					{
						return i;
					}
				}
			}
		}
		else
		{
			for (int i = int_28; i < this.Int32_14; i++)
			{
				if (this.class381_0.m_87D86B1A(i))
				{
					stack.Push(this.class381_0[i].String_0);
				}
				if (this.class381_0.m_BC8D0B8B(i))
				{
					string text3 = this.class381_0[i].String_1;
					while (stack.Count > 0 && stack.Pop() != text3)
					{
					}
					if (stack.Count == 0)
					{
						return i;
					}
				}
				int_29--;
				if (int_29 < 0)
				{
					return i;
				}
			}
		}
		return this.Int32_14 - 1;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x00012F4D File Offset: 0x0001114D
	public string method_101(int int_28)
	{
		if (this.class381_0.m_87D86B1A(int_28))
		{
			return this.class381_0[int_28].String_0;
		}
		return null;
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x00012F70 File Offset: 0x00011170
	public string method_102(int int_28)
	{
		if (this.class381_0.m_BC8D0B8B(int_28))
		{
			return this.class381_0[int_28].String_1;
		}
		return null;
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x000DA2C8 File Offset: 0x000D84C8
	protected virtual void vmethod_67()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.bool_12 = false;
		if (!this.Boolean_11)
		{
			return;
		}
		this.dictionary_2.Clear();
		Class357 @class = this.Class357_4;
		int num = Math.Max(@class.GStruct19_0.int_1 - 3000, 0);
		int num2 = Math.Min(@class.GStruct19_1.int_1 + 3000, Math.Max(@class.GStruct19_1.int_1, this.Int32_14 - 1));
		Stack<int> stack = new Stack<int>();
		for (int i = num; i <= num2; i++)
		{
			bool flag = this.class381_0.m_87D86B1A(i);
			bool flag2;
			if (!(flag2 = this.class381_0.m_BC8D0B8B(i)) || !flag)
			{
				if (flag)
				{
					stack.Push(i);
				}
				if (flag2)
				{
					string text = this.class381_0[i].String_1;
					while (stack.Count > 0)
					{
						int num3 = stack.Pop();
						this.dictionary_2[num3] = i;
						if (text == this.class381_0[num3].String_0)
						{
							break;
						}
					}
				}
			}
		}
		while (stack.Count > 0)
		{
			this.dictionary_2[stack.Pop()] = num2 + 1;
		}
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x000DA3FC File Offset: 0x000D85FC
	public virtual void vmethod_68(int int_28, int int_29)
	{
		int num = Math.Min(int_28, int_29);
		int num2 = Math.Max(int_28, int_29);
		if (num == num2)
		{
			return;
		}
		for (int i = num + 1; i <= num2; i++)
		{
			this.method_126(i, GEnum18.Hidden);
		}
		this.method_126(num, GEnum18.StartOfHiddenBlock);
		this.method_4();
		num = Math.Min(int_28, int_29);
		num2 = Math.Max(int_28, int_29);
		int num3 = this.method_103(num2);
		if (num3 == num2)
		{
			num3 = this.method_104(num);
		}
		this.Class357_5.GStruct19_0 = new GStruct19(0, num3);
		this.bool_11 = true;
		this.method_4();
		this.vmethod_4();
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x000DA48C File Offset: 0x000D868C
	internal int method_103(int int_28)
	{
		if (int_28 >= this.class381_0.Count - 1)
		{
			return int_28;
		}
		int num = int_28;
		do
		{
			int_28++;
		}
		while (int_28 < this.class381_0.Count - 1 && this.list_0[int_28].genum18_0 != GEnum18.Visible);
		if (this.list_0[int_28].genum18_0 != GEnum18.Visible)
		{
			return num;
		}
		return int_28;
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x000DA4F0 File Offset: 0x000D86F0
	internal int method_104(int int_28)
	{
		if (int_28 <= 0)
		{
			return int_28;
		}
		int num = int_28;
		do
		{
			int_28--;
		}
		while (int_28 > 0 && this.list_0[int_28].genum18_0 != GEnum18.Visible);
		if (this.list_0[int_28].genum18_0 != GEnum18.Visible)
		{
			return num;
		}
		return int_28;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x000DA53C File Offset: 0x000D873C
	private Class386 method_105(Point point_4)
	{
		foreach (Class386 @class in this.list_2)
		{
			if (@class.rectangle_0.Contains(point_4))
			{
				return @class;
			}
		}
		return null;
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x000DA5A4 File Offset: 0x000D87A4
	public virtual void vmethod_69()
	{
		if (GStruct19.smethod_1(this.Class357_5.GStruct19_0, this.Class357_5.GStruct19_1))
		{
			if (!this.Class357_5.Boolean_1)
			{
				this.Class357_5.GStruct19_0 = new GStruct19(this[this.Class357_5.GStruct19_0.int_1].Int32_2, this.Class357_5.GStruct19_0.int_1);
				int num = this.Int32_5 - this.Class357_5.GStruct19_0.int_0 % this.Int32_5;
				if (this.Boolean_15)
				{
					for (int i = 0; i < num; i++)
					{
						this.Class357_5.method_11(true);
					}
					this.Class357_5.method_41();
				}
				this.vmethod_20(new string(' ', num));
			}
			return;
		}
		bool flag = GStruct19.smethod_4(this.Class357_5.GStruct19_0, this.Class357_5.GStruct19_1) && !this.Class357_5.Boolean_0;
		int num2 = 0;
		if (this.Class357_5.Boolean_0)
		{
			num2 = Math.Min(this.Class357_5.GStruct19_1.int_0, this.Class357_5.GStruct19_0.int_0);
		}
		this.method_85();
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		Class357 @class = this.Class357_5.method_6();
		this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
		this.Class357_5.method_40();
		Class357 class2 = this.Class357_5.method_6();
		int num3 = this.Class357_5.GStruct19_0.int_1;
		int num4 = this.Class357_5.GStruct19_1.int_1;
		if (!this.Class357_5.Boolean_0 && this.Class357_5.GStruct19_1.int_0 == 0)
		{
			num4--;
		}
		for (int j = num3; j <= num4; j++)
		{
			if (this.class381_0[j].Count != 0)
			{
				this.Class357_5.GStruct19_0 = new GStruct19(num2, j);
				this.class381_0.Class312_0.vmethod_0(new Class317(this.Class381_0, new string(' ', this.Int32_5)));
			}
		}
		if (!this.Class357_5.Boolean_0)
		{
			int num5 = class2.GStruct19_0.int_0 + this.Int32_5;
			int num6 = class2.GStruct19_1.int_0 + ((class2.GStruct19_1.int_1 == num4) ? this.Int32_5 : 0);
			this.Class357_5.GStruct19_0 = new GStruct19(num5, class2.GStruct19_0.int_1);
			this.Class357_5.GStruct19_1 = new GStruct19(num6, class2.GStruct19_1.int_1);
		}
		else
		{
			this.Class357_5 = @class;
		}
		this.class381_0.Class312_0.method_3();
		if (flag)
		{
			this.Class357_5.method_41();
		}
		this.bool_11 = true;
		this.Class357_5.method_39();
		this.method_86();
		this.method_4();
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x000DA8AC File Offset: 0x000D8AAC
	public virtual void vmethod_70()
	{
		if (this.Class357_5.GStruct19_0.int_1 == this.Class357_5.GStruct19_1.int_1)
		{
			this.vmethod_71();
			return;
		}
		int num = 0;
		if (this.Class357_5.Boolean_0)
		{
			num = Math.Min(this.Class357_5.GStruct19_1.int_0, this.Class357_5.GStruct19_0.int_0);
		}
		this.method_85();
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		Class357 @class = this.Class357_5.method_6();
		this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
		Class357 class2 = this.Class357_5.method_6();
		this.Class357_5.method_40();
		int num2 = this.Class357_5.GStruct19_0.int_1;
		int num3 = this.Class357_5.GStruct19_1.int_1;
		if (!this.Class357_5.Boolean_0 && this.Class357_5.GStruct19_1.int_0 == 0)
		{
			num3--;
		}
		int num4 = 0;
		int num5 = 0;
		for (int i = num2; i <= num3; i++)
		{
			if (num <= this.class381_0[i].Count)
			{
				int num6 = Math.Min(this.class381_0[i].Count, num + this.Int32_5);
				string text = this.class381_0[i].String_2.Substring(num, num6 - num);
				num6 = Math.Min(num6, num + text.Length - text.TrimStart(Array.Empty<char>()).Length);
				this.Class357_5 = new Class357(this, new GStruct19(num, i), new GStruct19(num6, i));
				int num7 = num6 - num;
				if (i == class2.GStruct19_0.int_1)
				{
					num4 = num7;
				}
				if (i == class2.GStruct19_1.int_1)
				{
					num5 = num7;
				}
				if (!this.Class357_5.Boolean_2)
				{
					this.vmethod_28();
				}
			}
		}
		if (!this.Class357_5.Boolean_0)
		{
			int num8 = Math.Max(0, class2.GStruct19_0.int_0 - num4);
			int num9 = Math.Max(0, class2.GStruct19_1.int_0 - num5);
			this.Class357_5.GStruct19_0 = new GStruct19(num8, class2.GStruct19_0.int_1);
			this.Class357_5.GStruct19_1 = new GStruct19(num9, class2.GStruct19_1.int_1);
		}
		else
		{
			this.Class357_5 = @class;
		}
		this.class381_0.Class312_0.method_3();
		this.bool_11 = true;
		this.Class357_5.method_39();
		this.method_86();
		this.method_4();
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x000DAB58 File Offset: 0x000D8D58
	protected virtual void vmethod_71()
	{
		if (this.Class357_5.GStruct19_0.int_1 != this.Class357_5.GStruct19_1.int_1)
		{
			return;
		}
		Class357 @class = this.Class357_5.method_6();
		int num = this.Class357_5.GStruct19_0.int_1;
		int num2 = Math.Min(this.Class357_5.GStruct19_0.int_0, this.Class357_5.GStruct19_1.int_0);
		string text = this.class381_0[num].String_2;
		Match match = new Regex("\\s*", RegexOptions.RightToLeft).Match(text, num2);
		int index = match.Index;
		int length = match.Length;
		int num3 = 0;
		if (length > 0)
		{
			int num4 = ((this.Int32_5 > 0) ? (num2 % this.Int32_5) : 0);
			num3 = ((num4 != 0) ? Math.Min(num4, length) : Math.Min(this.Int32_5, length));
		}
		if (num3 > 0)
		{
			this.method_85();
			this.Class357_5.method_38();
			this.class381_0.Class312_0.method_4();
			this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
			this.Class357_5.GStruct19_0 = new GStruct19(index, num);
			this.Class357_5.GStruct19_1 = new GStruct19(index + num3, num);
			this.vmethod_28();
			int num5 = @class.GStruct19_0.int_0 - num3;
			int num6 = @class.GStruct19_1.int_0 - num3;
			this.Class357_5.GStruct19_0 = new GStruct19(num5, num);
			this.Class357_5.GStruct19_1 = new GStruct19(num6, num);
			this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
			this.class381_0.Class312_0.method_3();
			this.Class357_5.method_39();
			this.method_86();
		}
		this.method_4();
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x000DAD38 File Offset: 0x000D8F38
	public virtual void vmethod_72()
	{
		if (this.Class357_5.Boolean_0)
		{
			return;
		}
		Class357 @class = this.Class357_5.method_6();
		@class.method_40();
		this.method_85();
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		for (int i = @class.GStruct19_0.int_1; i <= @class.GStruct19_1.int_1; i++)
		{
			this.vmethod_44(i);
		}
		this.class381_0.Class312_0.method_3();
		this.Class357_5.GStruct19_0 = @class.GStruct19_0;
		this.Class357_5.GStruct19_1 = @class.GStruct19_1;
		this.Class357_5.method_42();
		this.Class357_5.method_39();
		this.method_86();
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x000DADFC File Offset: 0x000D8FFC
	public virtual void vmethod_73(string string_3)
	{
		this.Class357_5.method_6();
		int num = Math.Min(this.Class357_5.GStruct19_0.int_1, this.Class357_5.GStruct19_1.int_1);
		int num2 = Math.Max(this.Class357_5.GStruct19_0.int_1, this.Class357_5.GStruct19_1.int_1);
		this.method_85();
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
		int num3 = this.method_66(num, num2);
		for (int i = num; i <= num2; i++)
		{
			this.Class357_5.GStruct19_0 = new GStruct19(num3, i);
			this.class381_0.Class312_0.vmethod_0(new Class317(this.Class381_0, string_3));
		}
		this.Class357_5.GStruct19_0 = new GStruct19(0, num);
		this.Class357_5.GStruct19_1 = new GStruct19(this.class381_0[num2].Count, num2);
		this.bool_11 = true;
		this.class381_0.Class312_0.method_3();
		this.Class357_5.method_39();
		this.method_86();
		this.method_4();
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000DAF44 File Offset: 0x000D9144
	public virtual void vmethod_74(string string_3)
	{
		this.Class357_5.method_6();
		int num = Math.Min(this.Class357_5.GStruct19_0.int_1, this.Class357_5.GStruct19_1.int_1);
		int num2 = Math.Max(this.Class357_5.GStruct19_0.int_1, this.Class357_5.GStruct19_1.int_1);
		this.method_85();
		this.Class357_5.method_38();
		this.class381_0.Class312_0.method_4();
		this.class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
		for (int i = num; i <= num2; i++)
		{
			string text = this.class381_0[i].String_2;
			string text2 = text.TrimStart(Array.Empty<char>());
			if (text2.StartsWith(string_3))
			{
				int num3 = text.Length - text2.Length;
				this.Class357_5.GStruct19_0 = new GStruct19(num3, i);
				this.Class357_5.GStruct19_1 = new GStruct19(num3 + string_3.Length, i);
				this.vmethod_28();
			}
		}
		this.Class357_5.GStruct19_0 = new GStruct19(0, num);
		this.Class357_5.GStruct19_1 = new GStruct19(this.class381_0[num2].Count, num2);
		this.bool_11 = true;
		this.class381_0.Class312_0.method_3();
		this.Class357_5.method_39();
		this.method_86();
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00012F93 File Offset: 0x00011193
	public void method_106()
	{
		this.class381_0.Class312_0.method_4();
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x00012FA5 File Offset: 0x000111A5
	public void method_107()
	{
		this.class381_0.Class312_0.method_3();
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x00012FB7 File Offset: 0x000111B7
	public virtual void vmethod_75(MouseEventArgs mouseEventArgs_0, Class390 class390_0)
	{
		if (this.eventHandler_11 != null)
		{
			this.eventHandler_11(this, new EventArgs15(class390_0.Class368_0, class390_0, mouseEventArgs_0));
		}
		class390_0.Class368_0.vmethod_0(this, new EventArgs15(class390_0.Class368_0, class390_0, mouseEventArgs_0));
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x000DB0BC File Offset: 0x000D92BC
	protected virtual void vmethod_76(MouseEventArgs mouseEventArgs_0, Class386 class386_0)
	{
		if (class386_0 is Class390)
		{
			this.vmethod_75(mouseEventArgs_0, class386_0 as Class390);
			return;
		}
		if (class386_0 is Class387)
		{
			this.vmethod_65((class386_0 as Class387).int_0);
			return;
		}
		if (class386_0 is Class388)
		{
			this.vmethod_60((class386_0 as Class388).int_0);
			return;
		}
		if (class386_0 is Class389)
		{
			int num = (class386_0 as Class389).int_0;
			int num2 = this.method_100(num);
			if (num2 < 0)
			{
				return;
			}
			this.Class357_5.method_38();
			this.Class357_5.GStruct19_0 = new GStruct19(0, num);
			this.Class357_5.GStruct19_1 = new GStruct19(this.class381_0[num2].Count, num2);
			this.Class357_5.method_39();
			this.method_4();
		}
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x00012FF3 File Offset: 0x000111F3
	protected virtual void vmethod_77(Class386 class386_0)
	{
		if (class386_0 is Class389)
		{
			this.vmethod_60((class386_0 as Class389).int_0);
			this.method_4();
		}
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x00013014 File Offset: 0x00011214
	private void method_108()
	{
		this.class357_3 = null;
		this.class357_5 = null;
		this.class357_4 = null;
		this.class357_6 = null;
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x000DB184 File Offset: 0x000D9384
	private void method_109(char char_5, char char_6, ref Class357 class357_9, ref Class357 class357_10)
	{
		GEnum15 genum = this.GEnum15_0;
		if (genum == GEnum15.Strategy1)
		{
			this.method_110(char_5, char_6, ref class357_9, ref class357_10);
			return;
		}
		if (genum != GEnum15.Strategy2)
		{
			return;
		}
		this.method_112(char_5, char_6, ref class357_9, ref class357_10);
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x000DB1B8 File Offset: 0x000D93B8
	private void method_110(char char_5, char char_6, ref Class357 class357_9, ref Class357 class357_10)
	{
		if (!this.Class357_5.Boolean_2)
		{
			return;
		}
		if (this.Int32_14 == 0)
		{
			return;
		}
		Class357 @class = class357_9;
		Class357 class2 = class357_10;
		Class357 class3 = this.method_111(this.Class357_5.GStruct19_0, char_5, char_6, true);
		if (class3 != null)
		{
			class357_9 = new Class357(this, class3.GStruct19_0, new GStruct19(class3.GStruct19_0.int_0 + 1, class3.GStruct19_0.int_1));
			class357_10 = new Class357(this, new GStruct19(class3.GStruct19_1.int_0 - 1, class3.GStruct19_1.int_1), class3.GStruct19_1);
		}
		if (@class != class357_9 || class2 != class357_10)
		{
			this.method_4();
		}
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x000DB264 File Offset: 0x000D9464
	public Class357 method_111(GStruct19 gstruct19_0, char char_5, char char_6, bool bool_37)
	{
		Class357 @class = new Class357(this, gstruct19_0, gstruct19_0);
		Class357 class2 = @class.method_6();
		Class357 class3 = null;
		Class357 class4 = null;
		int num = 0;
		int num2 = 1000;
		while (class2.method_9())
		{
			if (class2.Char_0 == char_5)
			{
				num++;
			}
			if (class2.Char_0 == char_6)
			{
				num--;
			}
			if (num == 1)
			{
				class2.GStruct19_0 = new GStruct19(class2.GStruct19_0.int_0 + ((!bool_37) ? 1 : 0), class2.GStruct19_0.int_1);
				class3 = class2;
			}
			else
			{
				num2--;
				if (num2 > 0)
				{
					continue;
				}
			}
			break;
		}
		class2 = @class.method_6();
		num = 0;
		num2 = 1000;
		for (;;)
		{
			if (class2.Char_0 == char_5)
			{
				num++;
			}
			if (class2.Char_0 == char_6)
			{
				num--;
			}
			if (num == -1)
			{
				break;
			}
			num2--;
			if (num2 <= 0)
			{
				goto IL_00FD;
			}
			if (!class2.vmethod_1())
			{
				goto Block_8;
			}
		}
		class2.GStruct19_1 = new GStruct19(class2.GStruct19_0.int_0 + ((bool_37) ? 1 : 0), class2.GStruct19_0.int_1);
		class4 = class2;
		Block_8:
		IL_00FD:
		if (class3 != null && class4 != null)
		{
			return new Class357(this, class3.GStruct19_0, class4.GStruct19_1);
		}
		return null;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000DB388 File Offset: 0x000D9588
	private void method_112(char char_5, char char_6, ref Class357 class357_9, ref Class357 class357_10)
	{
		if (!this.Class357_5.Boolean_2)
		{
			return;
		}
		if (this.Int32_14 == 0)
		{
			return;
		}
		Class357 @class = class357_9;
		Class357 class2 = class357_10;
		Class357 class3 = this.Class357_5.method_6();
		bool flag = false;
		int num = 0;
		int num2 = 1000;
		if (class3.Char_1 == char_6)
		{
			class357_10 = new Class357(this, class3.GStruct19_0.int_0 - 1, class3.GStruct19_0.int_1, class3.GStruct19_0.int_0, class3.GStruct19_0.int_1);
			while (class3.method_9())
			{
				if (class3.Char_0 == char_5)
				{
					num++;
				}
				if (class3.Char_0 == char_6)
				{
					num--;
				}
				if (num == 0)
				{
					class3.GStruct19_1 = new GStruct19(class3.GStruct19_0.int_0 + 1, class3.GStruct19_0.int_1);
					class357_9 = class3;
					flag = true;
					break;
				}
				num2--;
				if (num2 <= 0)
				{
					break;
				}
			}
		}
		class3 = this.Class357_5.method_6();
		num = 0;
		num2 = 1000;
		if (!flag && class3.Char_0 == char_5)
		{
			class357_9 = new Class357(this, class3.GStruct19_0.int_0, class3.GStruct19_0.int_1, class3.GStruct19_0.int_0 + 1, class3.GStruct19_0.int_1);
			do
			{
				if (class3.Char_0 == char_5)
				{
					num++;
				}
				if (class3.Char_0 == char_6)
				{
					num--;
				}
				if (num == 0)
				{
					goto IL_0175;
				}
				num2--;
				if (num2 <= 0)
				{
					break;
				}
			}
			while (class3.vmethod_1());
			goto IL_019E;
			IL_0175:
			class3.GStruct19_1 = new GStruct19(class3.GStruct19_0.int_0 + 1, class3.GStruct19_0.int_1);
			class357_10 = class3;
		}
		IL_019E:
		if (@class != class357_9 || class2 != class357_10)
		{
			this.method_4();
		}
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000DB544 File Offset: 0x000D9744
	public bool method_113(string string_3, bool bool_37 = false, RegexOptions regexOptions_0 = RegexOptions.None)
	{
		Class357 @class = this.Class357_5.method_6();
		@class.method_40();
		Class357 class2 = (bool_37 ? new Class357(this, this.Class357_6.GStruct19_0, @class.GStruct19_0) : new Class357(this, @class.GStruct19_1, this.Class357_6.GStruct19_1));
		Class357 class3 = null;
		using (IEnumerator<Class357> enumerator = class2.method_29(string_3, regexOptions_0).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				class3 = enumerator.Current;
				if (!bool_37)
				{
					break;
				}
			}
		}
		if (class3 == null)
		{
			return false;
		}
		this.Class357_5 = class3;
		this.method_4();
		return true;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x000DB5EC File Offset: 0x000D97EC
	public virtual void vmethod_78(EventArgs5 eventArgs5_0)
	{
		GEnum13 genum = this.GEnum13_0;
		Class357 @class;
		if (genum != GEnum13.VisibleRange)
		{
			if (genum != GEnum13.AllTextRange)
			{
				@class = eventArgs5_0.Class357_0;
			}
			else
			{
				@class = this.Class357_6;
			}
		}
		else
		{
			@class = this.Class357_4.method_1(eventArgs5_0.Class357_0);
		}
		if (this.Class379_0 != null)
		{
			if (this.GEnum21_0 == GEnum21.Custom && !string.IsNullOrEmpty(this.String_2))
			{
				this.Class379_0.vmethod_1(this.String_2, @class);
				return;
			}
			this.Class379_0.vmethod_0(this.GEnum21_0, @class);
		}
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x000DB670 File Offset: 0x000D9870
	public virtual void vmethod_79(Class357 class357_9, Class341 class341_0)
	{
		Class329 @class = new Class329();
		@class.Boolean_4 = true;
		@class.Boolean_1 = true;
		@class.Boolean_0 = true;
		@class.Boolean_3 = false;
		@class.Boolean_5 = class341_0.Boolean_3;
		if (class357_9 == null)
		{
			class357_9 = this.Class357_6;
		}
		if (class357_9.String_1 == string.Empty)
		{
			return;
		}
		this.class357_8 = class357_9;
		try
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, new EventArgs());
			}
			if (this.eventHandler_10 != null)
			{
				this.eventHandler_10(this, new EventArgs());
			}
		}
		finally
		{
			this.class357_8 = null;
		}
		string text = @class.method_1(class357_9);
		text = string.Concat(new string[]
		{
			"<META HTTP-EQUIV=\"Content-Type\" CONTENT=\"text/html; charset=UTF-8\"><head><title>",
			this.vmethod_80(class341_0.String_0),
			"</title></head>",
			text,
			"<br>",
			this.method_117()
		});
		string text2 = Path.GetTempPath() + "fctb.html";
		File.WriteAllText(text2, text);
		Control3.smethod_5(class341_0);
		WebBrowser webBrowser = new WebBrowser();
		webBrowser.Tag = class341_0;
		webBrowser.Visible = false;
		webBrowser.Location = new Point(-1000, -1000);
		webBrowser.Parent = this;
		webBrowser.StatusTextChanged += this.method_114;
		webBrowser.Navigate(text2);
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00013032 File Offset: 0x00011232
	protected virtual string vmethod_80(string string_3)
	{
		return string_3.Replace("<", "&lt;").Replace(">", "&gt;").Replace("&", "&amp;");
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x000DB7C8 File Offset: 0x000D99C8
	private void method_114(object sender, EventArgs e)
	{
		WebBrowser webBrowser = sender as WebBrowser;
		if (webBrowser.StatusText.Contains("#print"))
		{
			Class341 @class = webBrowser.Tag as Class341;
			try
			{
				if (@class.Boolean_2)
				{
					webBrowser.ShowPrintPreviewDialog();
				}
				else
				{
					if (@class.Boolean_0)
					{
						webBrowser.ShowPageSetupDialog();
					}
					if (@class.Boolean_1)
					{
						webBrowser.ShowPrintDialog();
					}
					else
					{
						webBrowser.Print();
					}
				}
			}
			finally
			{
				webBrowser.Parent = null;
				webBrowser.Dispose();
			}
		}
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00013062 File Offset: 0x00011262
	public void method_115(Class341 class341_0)
	{
		this.vmethod_79(this.Class357_6, class341_0);
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00013071 File Offset: 0x00011271
	public void method_116()
	{
		this.vmethod_79(this.Class357_6, new Class341
		{
			Boolean_0 = false,
			Boolean_1 = false,
			Boolean_2 = false
		});
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x000DB850 File Offset: 0x000D9A50
	private string method_117()
	{
		Class357 @class = this.Class357_5.method_6();
		@class.method_40();
		int num = this.method_90(@class.GStruct19_0) - @class.GStruct19_0.int_1;
		int num2 = @class.String_1.Length - (@class.GStruct19_1.int_1 - @class.GStruct19_0.int_1);
		return string.Format("<script type=\"text/javascript\">\ntry{{\n    var sel = document.selection;\n    var rng = sel.createRange();\n    rng.moveStart(\"character\", {0});\n    rng.moveEnd(\"character\", {1});\n    rng.select();\n}}catch(ex){{}}\nwindow.status = \"#print\";\n</script>", num, num2);
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x000DB8C4 File Offset: 0x000D9AC4
	private static void smethod_5(Class341 class341_0)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\PageSetup", true);
		if (registryKey != null)
		{
			registryKey.SetValue("footer", class341_0.String_1);
			registryKey.SetValue("header", class341_0.String_2);
		}
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x000DB908 File Offset: 0x000D9B08
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (this.Class379_0 != null)
			{
				this.Class379_0.Dispose();
			}
			this.timer_0.Dispose();
			this.timer_1.Dispose();
			this.timer_3.Dispose();
			if (this.FindForm_0 != null)
			{
				this.FindForm_0.Dispose();
			}
			if (this.ReplaceForm_0 != null)
			{
				this.ReplaceForm_0.Dispose();
			}
			if (this.Class381_0 != null)
			{
				this.Class381_0.Dispose();
			}
			if (this.ToolTip_0 != null)
			{
				this.ToolTip_0.Dispose();
			}
		}
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00013099 File Offset: 0x00011299
	protected virtual void vmethod_81(EventArgs2 eventArgs2_0)
	{
		if (this.eventHandler_13 != null)
		{
			this.eventHandler_13(this, eventArgs2_0);
		}
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000130B0 File Offset: 0x000112B0
	internal void method_118(int int_28)
	{
		this.method_119(int_28, 1);
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x000130BA File Offset: 0x000112BA
	internal void method_119(int int_28, int int_29)
	{
		if (this.eventHandler_14 != null)
		{
			this.eventHandler_14(this, new EventArgs3(int_28, int_29));
		}
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x000130D7 File Offset: 0x000112D7
	internal void method_120(int int_28, int int_29, List<int> list_3)
	{
		if (int_29 > 0 && this.eventHandler_15 != null)
		{
			this.eventHandler_15(this, new EventArgs4(int_28, int_29, list_3));
		}
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000DB9A4 File Offset: 0x000D9BA4
	public void method_121(string string_3, Encoding encoding_0)
	{
		Class381 @class = this.vmethod_6();
		try
		{
			this.vmethod_7(@class);
			this.Text = File.ReadAllText(string_3, encoding_0);
			this.method_31();
			this.Boolean_8 = false;
			this.vmethod_4();
		}
		catch
		{
			this.vmethod_7(this.vmethod_6());
			this.class381_0.m_559E6352(0, this.Class381_0.vmethod_0());
			this.Boolean_8 = false;
			throw;
		}
		this.Class357_5.GStruct19_0 = GStruct19.GStruct19_0;
		this.method_51();
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x000DBA34 File Offset: 0x000D9C34
	public void method_122(string string_3)
	{
		try
		{
			Encoding encoding = Class328.smethod_0(string_3);
			if (encoding != null)
			{
				this.method_121(string_3, encoding);
			}
			else
			{
				this.method_121(string_3, Encoding.Default);
			}
		}
		catch
		{
			this.vmethod_7(this.vmethod_6());
			this.class381_0.m_559E6352(0, this.Class381_0.vmethod_0());
			this.Boolean_8 = false;
			throw;
		}
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000DBAA0 File Offset: 0x000D9CA0
	public void method_123(string string_3, Encoding encoding_0)
	{
		Class382 @class = new Class382(this);
		try
		{
			this.vmethod_7(@class);
			@class.method_2(string_3, encoding_0);
			this.Boolean_8 = false;
			this.vmethod_4();
		}
		catch
		{
			@class.method_4();
			this.vmethod_7(this.vmethod_6());
			this.class381_0.m_559E6352(0, this.Class381_0.vmethod_0());
			this.Boolean_8 = false;
			throw;
		}
		this.method_4();
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x000DBB1C File Offset: 0x000D9D1C
	public void method_124()
	{
		if (this.class381_0 is Class382)
		{
			(this.class381_0 as Class382).method_4();
			this.vmethod_7(this.vmethod_6());
			this.class381_0.m_559E6352(0, this.Class381_0.vmethod_0());
			this.Boolean_8 = false;
			this.method_4();
		}
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x000130F9 File Offset: 0x000112F9
	public void method_125(string string_3, Encoding encoding_0)
	{
		this.class381_0.m_5A2109FD(string_3, encoding_0);
		this.Boolean_8 = false;
		this.vmethod_4();
		this.method_47();
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x000DBB78 File Offset: 0x000D9D78
	public void method_126(int int_28, GEnum18 genum18_0)
	{
		GStruct18 gstruct = this.list_0[int_28];
		gstruct.genum18_0 = genum18_0;
		this.list_0[int_28] = gstruct;
		this.bool_11 = true;
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x0001311B File Offset: 0x0001131B
	public GEnum18 method_127(int int_28)
	{
		return this.list_0[int_28].genum18_0;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x000DBBB0 File Offset: 0x000D9DB0
	public void method_128()
	{
		GoToForm goToForm = new GoToForm();
		goToForm.Int32_1 = this.Int32_14;
		goToForm.Int32_0 = this.Class357_5.GStruct19_0.int_1 + 1;
		if (goToForm.ShowDialog() == DialogResult.OK)
		{
			this.method_129(goToForm.Int32_0);
		}
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x000DBBFC File Offset: 0x000D9DFC
	public void method_129(int int_28)
	{
		int num = Math.Min(this.Int32_14 - 1, Math.Max(0, int_28 - 1));
		this.Class357_5 = new Class357(this, 0, num, 0, num);
		this.method_51();
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x0001312E File Offset: 0x0001132E
	public void method_130()
	{
		if (this.eventHandler_17 != null)
		{
			this.eventHandler_17(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x000DBC38 File Offset: 0x000D9E38
	public List<int> method_131(string string_3, RegexOptions regexOptions_0)
	{
		List<int> list = new List<int>();
		foreach (Class357 @class in this.Class357_6.method_30(string_3, regexOptions_0))
		{
			list.Add(@class.GStruct19_0.int_1);
		}
		return list;
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x000DBCA0 File Offset: 0x000D9EA0
	public void method_132(List<int> list_3)
	{
		this.Class381_0.Class312_0.vmethod_0(new Class321(this.Class381_0, list_3));
		if (list_3.Count > 0)
		{
			this.Boolean_8 = true;
		}
		if (this.Int32_14 == 0)
		{
			this.Text = "";
		}
		this.method_10();
		this.method_4();
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00013149 File Offset: 0x00011349
	// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00013151 File Offset: 0x00011351
	[Description("Enables AutoIndentChars mode")]
	[DefaultValue(true)]
	public bool Boolean_28 { get; set; }

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0001315A File Offset: 0x0001135A
	// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00013162 File Offset: 0x00011362
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Description("Regex patterns for AutoIndentChars (one regex per line)")]
	[DefaultValue("^\\s*[\\w\\.]+\\s*(?<range>=)\\s*(?<range>[^;]+);")]
	public string String_6 { get; set; }

	// Token: 0x06001C28 RID: 7208 RVA: 0x000DBCF8 File Offset: 0x000D9EF8
	public void method_133(int int_28)
	{
		foreach (string text in this.String_6.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
		{
			if (Regex.Match(this[int_28].String_2, text).Success)
			{
				this.method_134(int_28, new Regex(text));
				return;
			}
		}
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000DBD5C File Offset: 0x000D9F5C
	protected void method_134(int int_28, Regex regex_0)
	{
		Class357 @class = this.Class357_5.method_6();
		SortedDictionary<int, CaptureCollection> sortedDictionary = new SortedDictionary<int, CaptureCollection>();
		SortedDictionary<int, string> sortedDictionary2 = new SortedDictionary<int, string>();
		int num = 0;
		int int32_ = this[int_28].Int32_2;
		int num2 = int_28;
		while (num2 >= 0 && int32_ == this[num2].Int32_2)
		{
			string text = this[num2].String_2;
			Match match = regex_0.Match(text);
			if (!match.Success)
			{
				break;
			}
			sortedDictionary[num2] = match.Groups["range"].Captures;
			sortedDictionary2[num2] = text;
			if (sortedDictionary[num2].Count > num)
			{
				num = sortedDictionary[num2].Count;
			}
			num2--;
		}
		int num3 = int_28 + 1;
		while (num3 < this.Int32_14 && int32_ == this[num3].Int32_2)
		{
			string text2 = this[num3].String_2;
			Match match2 = regex_0.Match(text2);
			if (!match2.Success)
			{
				break;
			}
			sortedDictionary[num3] = match2.Groups["range"].Captures;
			sortedDictionary2[num3] = text2;
			if (sortedDictionary[num3].Count > num)
			{
				num = sortedDictionary[num3].Count;
			}
			num3++;
		}
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
		bool flag = false;
		for (int i = num - 1; i >= 0; i--)
		{
			int num4 = 0;
			foreach (int num5 in sortedDictionary.Keys)
			{
				CaptureCollection captureCollection = sortedDictionary[num5];
				if (captureCollection.Count > i)
				{
					int j = captureCollection[i].Index;
					string text3 = sortedDictionary2[num5];
					while (j > 0)
					{
						if (text3[j - 1] != ' ')
						{
							break;
						}
						j--;
					}
					int num6;
					if (i == 0)
					{
						num6 = j;
					}
					else
					{
						num6 = j - captureCollection[i - 1].Index - 1;
					}
					if (num6 > num4)
					{
						num4 = num6;
					}
				}
			}
			foreach (int num7 in new List<int>(sortedDictionary2.Keys))
			{
				if (sortedDictionary[num7].Count > i)
				{
					Capture capture = sortedDictionary[num7][i];
					int num8;
					if (i == 0)
					{
						num8 = capture.Index;
					}
					else
					{
						num8 = capture.Index - sortedDictionary[num7][i - 1].Index - 1;
					}
					int num9 = num4 - num8 + 1;
					if (num9 != 0)
					{
						if (@class.GStruct19_0.int_1 == num7 && @class.GStruct19_0.int_0 > capture.Index)
						{
							@class.GStruct19_0 = new GStruct19(@class.GStruct19_0.int_0 + num9, num7);
						}
						if (num9 > 0)
						{
							sortedDictionary2[num7] = sortedDictionary2[num7].Insert(capture.Index, new string(' ', num9));
						}
						else
						{
							sortedDictionary2[num7] = sortedDictionary2[num7].Remove(capture.Index + num9, -num9);
						}
						dictionary[num7] = true;
						flag = true;
					}
				}
			}
		}
		if (flag)
		{
			this.Class357_5.method_38();
			this.method_106();
			this.method_85();
			this.Class381_0.Class312_0.vmethod_0(new Class323(this.Class381_0));
			foreach (int num10 in sortedDictionary2.Keys)
			{
				if (dictionary.ContainsKey(num10))
				{
					this.Class357_5 = new Class357(this, 0, num10, this[num10].Count, num10);
					if (!this.Class357_5.Boolean_1)
					{
						this.vmethod_20(sortedDictionary2[num10]);
					}
				}
			}
			this.Class357_5 = @class;
			this.method_86();
			this.method_107();
			this.Class357_5.method_39();
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0001316B File Offset: 0x0001136B
	// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00013173 File Offset: 0x00011373
	private bool Boolean_29 { get; set; }

	// Token: 0x06001C2C RID: 7212 RVA: 0x0001317C File Offset: 0x0001137C
	protected override void OnDragEnter(DragEventArgs drgevent)
	{
		if (drgevent.Data.GetDataPresent(DataFormats.Text) && this.AllowDrop)
		{
			drgevent.Effect = DragDropEffects.Copy;
			this.Boolean_29 = true;
		}
		base.OnDragEnter(drgevent);
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000DC1E0 File Offset: 0x000DA3E0
	protected override void OnDragDrop(DragEventArgs drgevent)
	{
		if (!this.Boolean_9 && this.AllowDrop)
		{
			if (drgevent.Data.GetDataPresent(DataFormats.Text))
			{
				if (base.ParentForm != null)
				{
					base.ParentForm.Activate();
				}
				base.Focus();
				Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
				string text = drgevent.Data.GetData(DataFormats.Text).ToString();
				GStruct19 gstruct = this.method_82(point);
				this.vmethod_82(gstruct, text);
				this.Boolean_29 = false;
			}
			base.OnDragDrop(drgevent);
			return;
		}
		this.Boolean_29 = false;
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000DC280 File Offset: 0x000DA480
	protected virtual void vmethod_82(GStruct19 gstruct19_0, string string_3)
	{
		Class357 @class = new Class357(this, gstruct19_0, gstruct19_0);
		if (@class.Boolean_1)
		{
			return;
		}
		if (this.class357_2 != null && this.class357_2.method_0(gstruct19_0))
		{
			return;
		}
		bool flag = this.class357_2 == null || this.class357_2.Boolean_1 || (Control.ModifierKeys & Keys.Control) > Keys.None;
		if (this.class357_2 == null)
		{
			this.Class357_5.method_38();
			this.Class357_5.GStruct19_0 = gstruct19_0;
			this.vmethod_20(string_3);
			this.Class357_5 = new Class357(this, gstruct19_0, this.Class357_5.GStruct19_0);
			this.Class357_5.method_39();
		}
		else
		{
			if (!this.class357_2.method_0(gstruct19_0))
			{
				this.method_106();
				this.Class357_5 = this.class357_2;
				this.class381_0.Class312_0.vmethod_0(new Class323(this.class381_0));
				if (this.class357_2.Boolean_0)
				{
					this.class357_2.method_40();
					@class = new Class357(this, gstruct19_0, new GStruct19(gstruct19_0.int_0, gstruct19_0.int_1 + this.class357_2.GStruct19_1.int_1 - this.class357_2.GStruct19_0.int_1))
					{
						Boolean_0 = true
					};
					for (int i = this.Int32_14; i <= @class.GStruct19_1.int_1; i++)
					{
						this.Class357_5.method_51(false);
						this.vmethod_27('\n');
					}
				}
				if (!@class.Boolean_1)
				{
					if (GStruct19.smethod_2(gstruct19_0, this.class357_2.GStruct19_0))
					{
						if (!flag)
						{
							this.Class357_5 = this.class357_2;
							this.vmethod_28();
						}
						this.Class357_5 = @class;
						this.Class357_5.Boolean_0 = @class.Boolean_0;
						this.vmethod_20(string_3);
					}
					else
					{
						this.Class357_5 = @class;
						this.Class357_5.Boolean_0 = @class.Boolean_0;
						this.vmethod_20(string_3);
						if (!flag)
						{
							this.Class357_5 = this.class357_2;
							this.vmethod_28();
						}
					}
				}
				GStruct19 gstruct = gstruct19_0;
				GStruct19 gstruct19_ = this.Class357_5.GStruct19_0;
				Class357 class2 = (GStruct19.smethod_4(this.class357_2.GStruct19_1, this.class357_2.GStruct19_0) ? this.method_95(this.class357_2.GStruct19_0, this.class357_2.GStruct19_1) : this.method_95(this.class357_2.GStruct19_1, this.class357_2.GStruct19_0));
				if (GStruct19.smethod_4(gstruct19_0, this.class357_2.GStruct19_0) && !flag && !this.class357_2.Boolean_0)
				{
					int num;
					int num2;
					if (class2.GStruct19_0.int_1 != class2.GStruct19_1.int_1)
					{
						num = ((class2.GStruct19_1.int_1 != gstruct19_0.int_1) ? gstruct19_0.int_0 : (class2.GStruct19_0.int_0 + (gstruct19_0.int_0 - class2.GStruct19_1.int_0)));
						num2 = class2.GStruct19_1.int_0;
					}
					else if (class2.GStruct19_1.int_1 == gstruct19_0.int_1)
					{
						num = gstruct19_0.int_0 - class2.String_1.Length;
						num2 = gstruct19_0.int_0;
					}
					else
					{
						num = gstruct19_0.int_0;
						num2 = gstruct19_0.int_0 + class2.String_1.Length;
					}
					int num3;
					int num4;
					if (class2.GStruct19_1.int_1 != gstruct19_0.int_1)
					{
						num3 = gstruct19_0.int_1 - (class2.GStruct19_1.int_1 - class2.GStruct19_0.int_1);
						num4 = gstruct19_0.int_1;
					}
					else
					{
						num3 = class2.GStruct19_0.int_1;
						num4 = class2.GStruct19_1.int_1;
					}
					gstruct = new GStruct19(num, num3);
					gstruct19_ = new GStruct19(num2, num4);
				}
				if (!this.class357_2.Boolean_0)
				{
					this.Class357_5 = new Class357(this, gstruct, gstruct19_);
				}
				else
				{
					int num;
					int num2;
					if (!flag && gstruct19_0.int_1 >= class2.GStruct19_0.int_1 && gstruct19_0.int_1 <= class2.GStruct19_1.int_1 && gstruct19_0.int_0 >= class2.GStruct19_1.int_0)
					{
						num = gstruct19_0.int_0 - (class2.GStruct19_1.int_0 - class2.GStruct19_0.int_0);
						num2 = gstruct19_0.int_0;
					}
					else
					{
						num = gstruct19_0.int_0;
						num2 = gstruct19_0.int_0 + (class2.GStruct19_1.int_0 - class2.GStruct19_0.int_0);
					}
					int num3 = gstruct19_0.int_1;
					int num4 = gstruct19_0.int_1 + (class2.GStruct19_1.int_1 - class2.GStruct19_0.int_1);
					gstruct = new GStruct19(num, num3);
					gstruct19_ = new GStruct19(num2, num4);
					this.Class357_5 = new Class357(this, gstruct, gstruct19_)
					{
						Boolean_0 = true
					};
				}
				this.method_107();
			}
			this.class357_0.method_41();
			this.vmethod_58();
		}
		this.class357_2 = null;
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x000DC778 File Offset: 0x000DA978
	protected override void OnDragOver(DragEventArgs drgevent)
	{
		if (drgevent.Data.GetDataPresent(DataFormats.Text))
		{
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			this.Class357_5.GStruct19_0 = this.method_82(point);
			if (point.Y < 6 && base.VerticalScroll.Visible && base.VerticalScroll.Value > 0)
			{
				base.VerticalScroll.Value = Math.Max(0, base.VerticalScroll.Value - this.int_9);
			}
			this.method_49();
			this.method_4();
		}
		base.OnDragOver(drgevent);
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x000131AD File Offset: 0x000113AD
	protected override void OnDragLeave(EventArgs e)
	{
		this.Boolean_29 = false;
		base.OnDragLeave(e);
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x000DC81C File Offset: 0x000DAA1C
	private void method_135(MouseEventArgs mouseEventArgs_0)
	{
		if (!this.bool_36)
		{
			if (!base.HorizontalScroll.Visible && !base.VerticalScroll.Visible && this.Boolean_21)
			{
				return;
			}
			this.bool_36 = true;
			this.point_2 = mouseEventArgs_0.Location;
			this.point_3 = new Point(base.HorizontalScroll.Value, base.VerticalScroll.Value);
			this.timer_3.Interval = 50;
			this.timer_3.Enabled = true;
			base.Capture = true;
			this.Refresh();
			Control3.SendMessage(base.Handle, 11, 0, 0);
		}
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x000DC8C4 File Offset: 0x000DAAC4
	private void method_136()
	{
		if (this.bool_36)
		{
			this.bool_36 = false;
			this.timer_3.Enabled = false;
			base.Capture = false;
			base.Cursor = this.cursor_0;
			Control3.SendMessage(base.Handle, 11, 1, 0);
			this.method_4();
		}
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000DC918 File Offset: 0x000DAB18
	private void method_137()
	{
		ScrollEventArgs e = new ScrollEventArgs(ScrollEventType.ThumbPosition, base.HorizontalScroll.Value, this.point_3.X, ScrollOrientation.HorizontalScroll);
		this.OnScroll(e);
		ScrollEventArgs e2 = new ScrollEventArgs(ScrollEventType.ThumbPosition, base.VerticalScroll.Value, this.point_3.Y, ScrollOrientation.VerticalScroll);
		this.OnScroll(e2);
	}

	// Token: 0x06001C34 RID: 7220
	[DllImport("user32.dll")]
	private static extern int SendMessage(IntPtr intptr_1, int int_28, int int_29, int int_30);

	// Token: 0x06001C35 RID: 7221 RVA: 0x000DC970 File Offset: 0x000DAB70
	private void timer_3_Tick(object sender, EventArgs e)
	{
		if (base.IsDisposed)
		{
			return;
		}
		if (!this.bool_36)
		{
			return;
		}
		Point point = base.PointToClient(Cursor.Position);
		base.Capture = true;
		int num = this.point_2.X - point.X;
		int num2 = this.point_2.Y - point.Y;
		if (!base.VerticalScroll.Visible && this.Boolean_21)
		{
			num2 = 0;
		}
		if (!base.HorizontalScroll.Visible && this.Boolean_21)
		{
			num = 0;
		}
		double num3 = 180.0 - Math.Atan2((double)num2, (double)num) * 180.0 / 3.141592653589793;
		if (Math.Sqrt(Math.Pow((double)num, 2.0) + Math.Pow((double)num2, 2.0)) > 10.0)
		{
			if (num3 < 325.0 && num3 > 35.0)
			{
				if (num3 <= 55.0)
				{
					this.genum17_0 = GEnum17.Right | GEnum17.Up;
				}
				else if (num3 <= 125.0)
				{
					this.genum17_0 = GEnum17.Up;
				}
				else if (num3 <= 145.0)
				{
					this.genum17_0 = GEnum17.Left | GEnum17.Up;
				}
				else if (num3 <= 215.0)
				{
					this.genum17_0 = GEnum17.Left;
				}
				else if (num3 <= 235.0)
				{
					this.genum17_0 = GEnum17.Left | GEnum17.Down;
				}
				else if (num3 <= 305.0)
				{
					this.genum17_0 = GEnum17.Down;
				}
				else
				{
					this.genum17_0 = GEnum17.Right | GEnum17.Down;
				}
			}
			else
			{
				this.genum17_0 = GEnum17.Right;
			}
		}
		else
		{
			this.genum17_0 = GEnum17.None;
		}
		switch (this.genum17_0)
		{
		case GEnum17.Left:
			base.Cursor = Cursors.PanWest;
			goto IL_023F;
		case GEnum17.Right:
			base.Cursor = Cursors.PanEast;
			goto IL_023F;
		case GEnum17.Up:
			base.Cursor = Cursors.PanNorth;
			goto IL_023F;
		case GEnum17.Left | GEnum17.Up:
			base.Cursor = Cursors.PanNW;
			goto IL_023F;
		case GEnum17.Right | GEnum17.Up:
			base.Cursor = Cursors.PanNE;
			goto IL_023F;
		case GEnum17.Down:
			base.Cursor = Cursors.PanSouth;
			goto IL_023F;
		case GEnum17.Left | GEnum17.Down:
			base.Cursor = Cursors.PanSW;
			goto IL_023F;
		case GEnum17.Right | GEnum17.Down:
			base.Cursor = Cursors.PanSE;
			goto IL_023F;
		}
		base.Cursor = this.cursor_0;
		return;
		IL_023F:
		int num4 = (int)((double)(-(double)num) / 5.0);
		int num5 = (int)((double)(-(double)num2) / 5.0);
		ScrollEventArgs e2 = new ScrollEventArgs((num4 < 0) ? ScrollEventType.SmallIncrement : ScrollEventType.SmallDecrement, base.HorizontalScroll.Value, base.HorizontalScroll.Value + num4, ScrollOrientation.HorizontalScroll);
		ScrollEventArgs e3 = new ScrollEventArgs((num5 < 0) ? ScrollEventType.SmallDecrement : ScrollEventType.SmallIncrement, base.VerticalScroll.Value, base.VerticalScroll.Value + num5, ScrollOrientation.VerticalScroll);
		if ((this.genum17_0 & (GEnum17.Up | GEnum17.Down)) > GEnum17.None)
		{
			this.method_37(e3, false);
		}
		if ((this.genum17_0 & (GEnum17.Left | GEnum17.Right)) > GEnum17.None)
		{
			this.OnScroll(e2);
		}
		Control3.SendMessage(base.Handle, 11, 1, 0);
		this.Refresh();
		Control3.SendMessage(base.Handle, 11, 0, 0);
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x000DCC80 File Offset: 0x000DAE80
	private void method_138(Graphics graphics_0)
	{
		bool flag = base.VerticalScroll.Visible || !this.Boolean_21;
		bool flag2 = base.HorizontalScroll.Visible || !this.Boolean_21;
		using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, (int)(~this.BackColor.R), (int)(~this.BackColor.G), (int)(~this.BackColor.B))))
		{
			Point point = this.point_2;
			GraphicsState graphicsState = graphics_0.Save();
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.TranslateTransform((float)point.X, (float)point.Y);
			graphics_0.FillEllipse(solidBrush, -2, -2, 4, 4);
			if (flag)
			{
				this.method_139(graphics_0, solidBrush);
			}
			graphics_0.RotateTransform(90f);
			if (flag2)
			{
				this.method_139(graphics_0, solidBrush);
			}
			graphics_0.RotateTransform(90f);
			if (flag)
			{
				this.method_139(graphics_0, solidBrush);
			}
			graphics_0.RotateTransform(90f);
			if (flag2)
			{
				this.method_139(graphics_0, solidBrush);
			}
			graphics_0.Restore(graphicsState);
		}
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x000DCDAC File Offset: 0x000DAFAC
	private void method_139(Graphics graphics_0, Brush brush_1)
	{
		Point[] array = new Point[]
		{
			new Point(5, 10),
			new Point(0, 15),
			new Point(-5, 10)
		};
		graphics_0.FillPolygon(brush_1, array);
	}

	// Token: 0x040010C4 RID: 4292
	internal const int int_0 = 8;

	// Token: 0x040010C5 RID: 4293
	private const int int_1 = 1000;

	// Token: 0x040010C6 RID: 4294
	private const int int_2 = 3000;

	// Token: 0x040010C7 RID: 4295
	private const int int_3 = 100000;

	// Token: 0x040010C8 RID: 4296
	private const int int_4 = 641;

	// Token: 0x040010C9 RID: 4297
	private const int int_5 = 276;

	// Token: 0x040010CA RID: 4298
	private const int int_6 = 277;

	// Token: 0x040010CB RID: 4299
	private const int int_7 = 8;

	// Token: 0x040010CC RID: 4300
	private const int int_8 = 258;

	// Token: 0x040010CD RID: 4301
	private static readonly Dictionary<FCTBAction, bool> dictionary_0 = new Dictionary<FCTBAction, bool>
	{
		{
			FCTBAction.ScrollDown,
			true
		},
		{
			FCTBAction.ScrollUp,
			true
		},
		{
			FCTBAction.ZoomOut,
			true
		},
		{
			FCTBAction.ZoomIn,
			true
		},
		{
			FCTBAction.ZoomNormal,
			true
		}
	};

	// Token: 0x040010CE RID: 4302
	public readonly List<GStruct18> list_0 = new List<GStruct18>();

	// Token: 0x040010CF RID: 4303
	private readonly Class357 class357_0;

	// Token: 0x040010D0 RID: 4304
	private readonly List<Control> list_1 = new List<Control>();

	// Token: 0x040010D1 RID: 4305
	private readonly global::System.Windows.Forms.Timer timer_0 = new global::System.Windows.Forms.Timer();

	// Token: 0x040010D2 RID: 4306
	private readonly global::System.Windows.Forms.Timer timer_1 = new global::System.Windows.Forms.Timer();

	// Token: 0x040010D3 RID: 4307
	private readonly global::System.Windows.Forms.Timer timer_2 = new global::System.Windows.Forms.Timer();

	// Token: 0x040010D4 RID: 4308
	private readonly Dictionary<global::System.Windows.Forms.Timer, global::System.Windows.Forms.Timer> dictionary_1 = new Dictionary<global::System.Windows.Forms.Timer, global::System.Windows.Forms.Timer>();

	// Token: 0x040010D5 RID: 4309
	private readonly List<Class386> list_2 = new List<Class386>();

	// Token: 0x040010D6 RID: 4310
	public bool bool_0 = true;

	// Token: 0x040010D7 RID: 4311
	private Brush brush_0;

	// Token: 0x040010D8 RID: 4312
	private bool bool_1;

	// Token: 0x040010D9 RID: 4313
	private Color color_0;

	// Token: 0x040010DA RID: 4314
	private int int_9;

	// Token: 0x040010DB RID: 4315
	private Color color_1;

	// Token: 0x040010DC RID: 4316
	private Cursor cursor_0;

	// Token: 0x040010DD RID: 4317
	private int int_10 = 8;

	// Token: 0x040010DE RID: 4318
	private Class357 class357_1;

	// Token: 0x040010DF RID: 4319
	private string string_0;

	// Token: 0x040010E0 RID: 4320
	protected Class357 class357_2;

	// Token: 0x040010E1 RID: 4321
	private bool bool_2;

	// Token: 0x040010E2 RID: 4322
	private Color color_2;

	// Token: 0x040010E3 RID: 4323
	protected Dictionary<int, int> dictionary_2 = new Dictionary<int, int>();

	// Token: 0x040010E4 RID: 4324
	private bool bool_3;

	// Token: 0x040010E5 RID: 4325
	private bool bool_4;

	// Token: 0x040010E6 RID: 4326
	private Color color_3;

	// Token: 0x040010E7 RID: 4327
	private bool bool_5;

	// Token: 0x040010E8 RID: 4328
	private bool bool_6;

	// Token: 0x040010E9 RID: 4329
	private bool bool_7;

	// Token: 0x040010EA RID: 4330
	private GEnum21 genum21_0;

	// Token: 0x040010EB RID: 4331
	private Keys keys_0;

	// Token: 0x040010EC RID: 4332
	private Point point_0;

	// Token: 0x040010ED RID: 4333
	private DateTime dateTime_0;

	// Token: 0x040010EE RID: 4334
	private Class357 class357_3;

	// Token: 0x040010EF RID: 4335
	private Class357 class357_4;

	// Token: 0x040010F0 RID: 4336
	private int int_11;

	// Token: 0x040010F1 RID: 4337
	private int int_12;

	// Token: 0x040010F2 RID: 4338
	private Color color_4;

	// Token: 0x040010F3 RID: 4339
	private Class352 class352_0;

	// Token: 0x040010F4 RID: 4340
	private uint uint_0;

	// Token: 0x040010F5 RID: 4341
	private Class381 class381_0;

	// Token: 0x040010F6 RID: 4342
	private int int_13;

	// Token: 0x040010F7 RID: 4343
	private Size size_0;

	// Token: 0x040010F8 RID: 4344
	private IntPtr intptr_0;

	// Token: 0x040010F9 RID: 4345
	private int int_14;

	// Token: 0x040010FA RID: 4346
	private bool bool_8;

	// Token: 0x040010FB RID: 4347
	private bool bool_9;

	// Token: 0x040010FC RID: 4348
	private bool bool_10;

	// Token: 0x040010FD RID: 4349
	protected bool bool_11;

	// Token: 0x040010FE RID: 4350
	private bool bool_12;

	// Token: 0x040010FF RID: 4351
	protected bool bool_13;

	// Token: 0x04001100 RID: 4352
	private Point point_1;

	// Token: 0x04001101 RID: 4353
	private bool bool_14;

	// Token: 0x04001102 RID: 4354
	private bool bool_15;

	// Token: 0x04001103 RID: 4355
	private bool bool_16;

	// Token: 0x04001104 RID: 4356
	private Font font_0;

	// Token: 0x04001105 RID: 4357
	private Color color_5;

	// Token: 0x04001106 RID: 4358
	private int int_15;

	// Token: 0x04001107 RID: 4359
	private Rectangle rectangle_0;

	// Token: 0x04001108 RID: 4360
	private int int_16 = 1;

	// Token: 0x04001109 RID: 4361
	private Class357 class357_5;

	// Token: 0x0400110A RID: 4362
	private Class357 class357_6;

	// Token: 0x0400110B RID: 4363
	private bool bool_17;

	// Token: 0x0400110C RID: 4364
	private Color color_6;

	// Token: 0x0400110D RID: 4365
	private bool bool_18;

	// Token: 0x0400110E RID: 4366
	private Color color_7;

	// Token: 0x0400110F RID: 4367
	private bool bool_19;

	// Token: 0x04001110 RID: 4368
	private bool bool_20;

	// Token: 0x04001111 RID: 4369
	private Control3 control3_0;

	// Token: 0x04001112 RID: 4370
	private GEnum16 genum16_0;

	// Token: 0x04001113 RID: 4371
	private Color color_8;

	// Token: 0x04001114 RID: 4372
	public int int_17;

	// Token: 0x04001115 RID: 4373
	private int int_18;

	// Token: 0x04001116 RID: 4374
	private Class357 class357_7;

	// Token: 0x04001117 RID: 4375
	private Class357 class357_8;

	// Token: 0x04001118 RID: 4376
	private bool bool_21;

	// Token: 0x04001119 RID: 4377
	private GEnum12 genum12_0;

	// Token: 0x0400111A RID: 4378
	private int int_19 = 100;

	// Token: 0x0400111B RID: 4379
	[CompilerGenerated]
	private char[] char_0;

	// Token: 0x0400111C RID: 4380
	[CompilerGenerated]
	private bool bool_22;

	// Token: 0x0400111D RID: 4381
	[CompilerGenerated]
	private Class342 class342_0;

	// Token: 0x0400111E RID: 4382
	[CompilerGenerated]
	private readonly Dictionary<int, int> dictionary_3;

	// Token: 0x0400111F RID: 4383
	[CompilerGenerated]
	private GEnum15 genum15_0;

	// Token: 0x04001120 RID: 4384
	[CompilerGenerated]
	private bool bool_23;

	// Token: 0x04001121 RID: 4385
	[CompilerGenerated]
	private int int_20;

	// Token: 0x04001122 RID: 4386
	[CompilerGenerated]
	private readonly Class355 class355_0;

	// Token: 0x04001123 RID: 4387
	[CompilerGenerated]
	private Class344 class344_0;

	// Token: 0x04001124 RID: 4388
	[CompilerGenerated]
	private ToolTip toolTip_0;

	// Token: 0x04001125 RID: 4389
	[CompilerGenerated]
	private Color color_9;

	// Token: 0x04001126 RID: 4390
	[CompilerGenerated]
	private Class308 class308_0;

	// Token: 0x04001127 RID: 4391
	[CompilerGenerated]
	private bool bool_24;

	// Token: 0x04001128 RID: 4392
	[CompilerGenerated]
	private GEnum14 genum14_0;

	// Token: 0x04001129 RID: 4393
	[CompilerGenerated]
	private bool bool_25;

	// Token: 0x0400112A RID: 4394
	[CompilerGenerated]
	private bool bool_26;

	// Token: 0x0400112B RID: 4395
	[CompilerGenerated]
	private bool bool_27;

	// Token: 0x0400112C RID: 4396
	[CompilerGenerated]
	private bool bool_28;

	// Token: 0x0400112D RID: 4397
	[CompilerGenerated]
	private int int_21;

	// Token: 0x0400112E RID: 4398
	[CompilerGenerated]
	private int int_22;

	// Token: 0x0400112F RID: 4399
	[CompilerGenerated]
	private int int_23;

	// Token: 0x04001130 RID: 4400
	[CompilerGenerated]
	private bool bool_29;

	// Token: 0x04001131 RID: 4401
	[CompilerGenerated]
	private Color color_10;

	// Token: 0x04001132 RID: 4402
	[CompilerGenerated]
	private Color color_11;

	// Token: 0x04001133 RID: 4403
	[CompilerGenerated]
	private bool bool_30;

	// Token: 0x04001134 RID: 4404
	[CompilerGenerated]
	private Padding padding_0;

	// Token: 0x04001135 RID: 4405
	[CompilerGenerated]
	private int int_24;

	// Token: 0x04001136 RID: 4406
	[CompilerGenerated]
	private Class347 class347_0;

	// Token: 0x04001137 RID: 4407
	[CompilerGenerated]
	private Class371 class371_0;

	// Token: 0x04001138 RID: 4408
	[CompilerGenerated]
	private Class369 class369_0;

	// Token: 0x04001139 RID: 4409
	[CompilerGenerated]
	private Class372 class372_0;

	// Token: 0x0400113A RID: 4410
	[CompilerGenerated]
	private Class372 class372_1;

	// Token: 0x0400113B RID: 4411
	[CompilerGenerated]
	private char char_1;

	// Token: 0x0400113C RID: 4412
	[CompilerGenerated]
	private char char_2;

	// Token: 0x0400113D RID: 4413
	[CompilerGenerated]
	private char char_3;

	// Token: 0x0400113E RID: 4414
	[CompilerGenerated]
	private char char_4;

	// Token: 0x0400113F RID: 4415
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001140 RID: 4416
	[CompilerGenerated]
	private GEnum13 genum13_0;

	// Token: 0x04001141 RID: 4417
	[CompilerGenerated]
	private bool bool_31;

	// Token: 0x04001142 RID: 4418
	[CompilerGenerated]
	private bool bool_32;

	// Token: 0x04001143 RID: 4419
	[CompilerGenerated]
	private bool bool_33;

	// Token: 0x04001144 RID: 4420
	[CompilerGenerated]
	private Class379 class379_0;

	// Token: 0x04001145 RID: 4421
	[CompilerGenerated]
	private int int_25;

	// Token: 0x04001146 RID: 4422
	[CompilerGenerated]
	private int int_26;

	// Token: 0x04001147 RID: 4423
	[CompilerGenerated]
	private FindForm findForm_0;

	// Token: 0x04001148 RID: 4424
	[CompilerGenerated]
	private ReplaceForm replaceForm_0;

	// Token: 0x04001149 RID: 4425
	[CompilerGenerated]
	private Font font_1;

	// Token: 0x0400114A RID: 4426
	[CompilerGenerated]
	private EventHandler<EventArgs9> eventHandler_0;

	// Token: 0x0400114B RID: 4427
	[CompilerGenerated]
	private EventHandler<EventArgs10> eventHandler_1;

	// Token: 0x0400114C RID: 4428
	[CompilerGenerated]
	private EventHandler<EventArgs5> eventHandler_2;

	// Token: 0x0400114D RID: 4429
	[CompilerGenerated]
	private EventHandler eventHandler_3;

	// Token: 0x0400114E RID: 4430
	[CompilerGenerated]
	private EventHandler<EventArgs6> eventHandler_4;

	// Token: 0x0400114F RID: 4431
	[CompilerGenerated]
	private EventHandler<EventArgs6> eventHandler_5;

	// Token: 0x04001150 RID: 4432
	[CompilerGenerated]
	private EventHandler eventHandler_6;

	// Token: 0x04001151 RID: 4433
	[CompilerGenerated]
	private EventHandler eventHandler_7;

	// Token: 0x04001152 RID: 4434
	[CompilerGenerated]
	private EventHandler<EventArgs5> eventHandler_8;

	// Token: 0x04001153 RID: 4435
	[CompilerGenerated]
	private EventHandler eventHandler_9;

	// Token: 0x04001154 RID: 4436
	[CompilerGenerated]
	private EventHandler eventHandler_10;

	// Token: 0x04001155 RID: 4437
	[CompilerGenerated]
	private EventHandler<EventArgs15> eventHandler_11;

	// Token: 0x04001156 RID: 4438
	[CompilerGenerated]
	private KeyPressEventHandler keyPressEventHandler_0;

	// Token: 0x04001157 RID: 4439
	[CompilerGenerated]
	private KeyPressEventHandler keyPressEventHandler_1;

	// Token: 0x04001158 RID: 4440
	[CompilerGenerated]
	private EventHandler<EventArgs8> eventHandler_12;

	// Token: 0x04001159 RID: 4441
	[CompilerGenerated]
	private EventHandler<EventArgs2> eventHandler_13;

	// Token: 0x0400115A RID: 4442
	[CompilerGenerated]
	private EventHandler<EventArgs3> eventHandler_14;

	// Token: 0x0400115B RID: 4443
	[CompilerGenerated]
	private EventHandler<EventArgs4> eventHandler_15;

	// Token: 0x0400115C RID: 4444
	[CompilerGenerated]
	private EventHandler<EventArgs> eventHandler_16;

	// Token: 0x0400115D RID: 4445
	[CompilerGenerated]
	private EventHandler<EventArgs> eventHandler_17;

	// Token: 0x0400115E RID: 4446
	[CompilerGenerated]
	private EventHandler eventHandler_18;

	// Token: 0x0400115F RID: 4447
	[CompilerGenerated]
	private EventHandler<EventArgs11> eventHandler_19;

	// Token: 0x04001160 RID: 4448
	[CompilerGenerated]
	private EventHandler eventHandler_20;

	// Token: 0x04001161 RID: 4449
	[CompilerGenerated]
	private EventHandler<EventArgs7> eventHandler_21;

	// Token: 0x04001162 RID: 4450
	[CompilerGenerated]
	private bool bool_34;

	// Token: 0x04001163 RID: 4451
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04001164 RID: 4452
	[CompilerGenerated]
	private bool bool_35;

	// Token: 0x04001165 RID: 4453
	private bool bool_36;

	// Token: 0x04001166 RID: 4454
	private Point point_2;

	// Token: 0x04001167 RID: 4455
	private Point point_3;

	// Token: 0x04001168 RID: 4456
	private readonly global::System.Windows.Forms.Timer timer_3 = new global::System.Windows.Forms.Timer();

	// Token: 0x04001169 RID: 4457
	private GEnum17 genum17_0;

	// Token: 0x0400116A RID: 4458
	private const int int_27 = 11;

	// Token: 0x020001EC RID: 492
	private class Class332 : IComparer<GStruct18>
	{
		// Token: 0x06001C39 RID: 7225 RVA: 0x000131F6 File Offset: 0x000113F6
		public Class332(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00013205 File Offset: 0x00011405
		public int Compare(GStruct18 x, GStruct18 y)
		{
			if (x.int_0 == -10)
			{
				return -y.int_0.CompareTo(this.int_0);
			}
			return x.int_0.CompareTo(this.int_0);
		}

		// Token: 0x0400116B RID: 4459
		private readonly int int_0;
	}

	// Token: 0x020001ED RID: 493
	[CompilerGenerated]
	[Serializable]
	private sealed class Class333
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x00013243 File Offset: 0x00011443
		internal string method_0(Match match_0)
		{
			return match_0.Value.ToUpper();
		}

		// Token: 0x0400116C RID: 4460
		public static readonly Control3.Class333 f_359B8C55 = new Control3.Class333();

		// Token: 0x0400116D RID: 4461
		public static MatchEvaluator f_E08B0A23;
	}

	// Token: 0x020001EE RID: 494
	[CompilerGenerated]
	private sealed class Class334
	{
		// Token: 0x06001C3F RID: 7231 RVA: 0x00013250 File Offset: 0x00011450
		internal void method_0()
		{
			this.control3_0.method_20(this.timer_0);
		}

		// Token: 0x0400116E RID: 4462
		public Control3 control3_0;

		// Token: 0x0400116F RID: 4463
		public global::System.Windows.Forms.Timer timer_0;
	}

	// Token: 0x020001EF RID: 495
	[CompilerGenerated]
	private sealed class Class335
	{
		// Token: 0x06001C41 RID: 7233 RVA: 0x00013263 File Offset: 0x00011463
		internal void method_0()
		{
			this.control3_0.method_25(this.dataObject_0);
		}

		// Token: 0x04001170 RID: 4464
		public Control3 control3_0;

		// Token: 0x04001171 RID: 4465
		public DataObject dataObject_0;
	}

	// Token: 0x020001F0 RID: 496
	[CompilerGenerated]
	private sealed class Class336
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x00013276 File Offset: 0x00011476
		internal void method_0()
		{
			this.control3_0.method_25(this.dataObject_0);
		}

		// Token: 0x04001172 RID: 4466
		public Control3 control3_0;

		// Token: 0x04001173 RID: 4467
		public DataObject dataObject_0;
	}

	// Token: 0x020001F1 RID: 497
	[CompilerGenerated]
	private sealed class Class337
	{
		// Token: 0x06001C45 RID: 7237 RVA: 0x00013289 File Offset: 0x00011489
		internal void method_0()
		{
			if (Clipboard.ContainsText())
			{
				this.string_0 = Clipboard.GetText();
			}
		}

		// Token: 0x04001174 RID: 4468
		public string string_0;
	}

	// Token: 0x020001F2 RID: 498
	[CompilerGenerated]
	private sealed class Class338
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x0001329D File Offset: 0x0001149D
		internal void method_0(object object_0)
		{
			this.control3_0.Invalidate(this.rectangle_0);
			this.timer_0.Dispose();
		}

		// Token: 0x04001175 RID: 4469
		public Control3 control3_0;

		// Token: 0x04001176 RID: 4470
		public Rectangle rectangle_0;

		// Token: 0x04001177 RID: 4471
		public global::System.Threading.Timer timer_0;
	}

	// Token: 0x020001F3 RID: 499
	[CompilerGenerated]
	private sealed class Class339 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001C48 RID: 7240 RVA: 0x000132BB File Offset: 0x000114BB
		[DebuggerHidden]
		public Class339(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000DCDF8 File Offset: 0x000DAFF8
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000DCE40 File Offset: 0x000DB040
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Control3 control = this.control3_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					Class357 @class = new Class357(control);
					@class.method_2();
					this.ienumerator_0 = @class.method_29(this.string_0, RegexOptions.None).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					Class357 class2 = this.ienumerator_0.Current;
					this.class357_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000132D5 File Offset: 0x000114D5
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000132F1 File Offset: 0x000114F1
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000132F1 File Offset: 0x000114F1
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x000DCF00 File Offset: 0x000DB100
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Control3.Class339 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Control3.Class339(0);
				@class.control3_0 = this.control3_0;
			}
			@class.string_0 = this.string_1;
			return @class;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000132F9 File Offset: 0x000114F9
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04001178 RID: 4472
		private int int_0;

		// Token: 0x04001179 RID: 4473
		private Class357 class357_0;

		// Token: 0x0400117A RID: 4474
		private int int_1;

		// Token: 0x0400117B RID: 4475
		public Control3 control3_0;

		// Token: 0x0400117C RID: 4476
		private string string_0;

		// Token: 0x0400117D RID: 4477
		public string string_1;

		// Token: 0x0400117E RID: 4478
		private IEnumerator<Class357> ienumerator_0;
	}

	// Token: 0x020001F4 RID: 500
	[CompilerGenerated]
	private sealed class Class340 : IEnumerable, IDisposable, IEnumerator, IEnumerable<Class357>, IEnumerator<Class357>
	{
		// Token: 0x06001C51 RID: 7249 RVA: 0x00013301 File Offset: 0x00011501
		[DebuggerHidden]
		public Class340(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000DCF50 File Offset: 0x000DB150
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000DCF98 File Offset: 0x000DB198
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Control3 control = this.control3_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					Class357 @class = new Class357(control);
					@class.method_2();
					this.ienumerator_0 = @class.method_29(this.string_0, this.regexOptions_0).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					Class357 class2 = this.ienumerator_0.Current;
					this.class357_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0001331B File Offset: 0x0001151B
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00013337 File Offset: 0x00011537
		public Class357 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00013337 File Offset: 0x00011537
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class357_0;
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000DD05C File Offset: 0x000DB25C
		[DebuggerHidden]
		public IEnumerator<Class357> GetEnumerator()
		{
			Control3.Class340 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Control3.Class340(0);
				@class.control3_0 = this.control3_0;
			}
			@class.string_0 = this.string_1;
			@class.regexOptions_0 = this.regexOptions_1;
			return @class;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0001333F File Offset: 0x0001153F
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400117F RID: 4479
		private int int_0;

		// Token: 0x04001180 RID: 4480
		private Class357 class357_0;

		// Token: 0x04001181 RID: 4481
		private int int_1;

		// Token: 0x04001182 RID: 4482
		public Control3 control3_0;

		// Token: 0x04001183 RID: 4483
		private string string_0;

		// Token: 0x04001184 RID: 4484
		public string string_1;

		// Token: 0x04001185 RID: 4485
		private RegexOptions regexOptions_0;

		// Token: 0x04001186 RID: 4486
		public RegexOptions regexOptions_1;

		// Token: 0x04001187 RID: 4487
		private IEnumerator<Class357> ienumerator_0;
	}
}
