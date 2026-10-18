using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000210 RID: 528
internal class Class346
{
	// Token: 0x06001D0B RID: 7435 RVA: 0x00013AC6 File Offset: 0x00011CC6
	private Class346(Class357 class357_1, Control control_1, string string_0, bool bool_1, bool bool_2)
	{
		this.Class357_0 = class357_1;
		this.Boolean_0 = bool_1;
		this.Control_0 = control_1;
		this.vmethod_1();
		this.DockStyle_0 = (bool_2 ? DockStyle.Fill : DockStyle.None);
		this.String_0 = string_0;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x00013AFF File Offset: 0x00011CFF
	public Class346(Class357 class357_1, string string_0, bool bool_1, bool bool_2)
		: this(class357_1, null, string_0, bool_1, bool_2)
	{
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x00013B0D File Offset: 0x00011D0D
	public Class346(Class357 class357_1, string string_0)
		: this(class357_1, null, string_0, true, true)
	{
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x00013B1A File Offset: 0x00011D1A
	public Class346(Class357 class357_1, Control control_1, bool bool_1, bool bool_2)
		: this(class357_1, control_1, null, bool_1, bool_2)
	{
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x00013B28 File Offset: 0x00011D28
	public Class346(Class357 class357_1, Control control_1)
		: this(class357_1, control_1, null, true, true)
	{
	}

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00013B35 File Offset: 0x00011D35
	// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00013B42 File Offset: 0x00011D42
	public string String_0
	{
		get
		{
			return this.Control5_0.String_0;
		}
		set
		{
			this.Control5_0.String_0 = value;
		}
	}

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00013B50 File Offset: 0x00011D50
	// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00013B58 File Offset: 0x00011D58
	public Class357 Class357_0 { get; set; }

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00013B61 File Offset: 0x00011D61
	// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00013B6E File Offset: 0x00011D6E
	public Color Color_0
	{
		get
		{
			return this.Control5_0.BackColor;
		}
		set
		{
			this.Control5_0.BackColor = value;
		}
	}

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00013B7C File Offset: 0x00011D7C
	// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00013B89 File Offset: 0x00011D89
	public Color Color_1
	{
		get
		{
			return this.Control5_0.Color_0;
		}
		set
		{
			this.Control5_0.Color_0 = value;
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00013B97 File Offset: 0x00011D97
	// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00013BA4 File Offset: 0x00011DA4
	public Color Color_2
	{
		get
		{
			return this.Control5_0.Color_1;
		}
		set
		{
			this.Control5_0.Color_1 = value;
		}
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00013BB2 File Offset: 0x00011DB2
	// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00013BBF File Offset: 0x00011DBF
	public Color Color_3
	{
		get
		{
			return this.Control5_0.ForeColor;
		}
		set
		{
			this.Control5_0.ForeColor = value;
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00013BCD File Offset: 0x00011DCD
	// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00013BDA File Offset: 0x00011DDA
	public StringAlignment StringAlignment_0
	{
		get
		{
			return this.Control5_0.StringAlignment_0;
		}
		set
		{
			this.Control5_0.StringAlignment_0 = value;
		}
	}

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00013BE8 File Offset: 0x00011DE8
	// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00013BF5 File Offset: 0x00011DF5
	public Font Font_0
	{
		get
		{
			return this.Control5_0.Font;
		}
		set
		{
			this.Control5_0.Font = value;
		}
	}

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00013C03 File Offset: 0x00011E03
	// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00013C0B File Offset: 0x00011E0B
	public Control Control_0 { get; set; }

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00013C14 File Offset: 0x00011E14
	// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00013C1C File Offset: 0x00011E1C
	public DockStyle DockStyle_0 { get; set; }

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00013C25 File Offset: 0x00011E25
	// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00013C32 File Offset: 0x00011E32
	public int Int32_0
	{
		get
		{
			return this.Control5_0.Width;
		}
		set
		{
			this.Control5_0.Width = value;
		}
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00013C40 File Offset: 0x00011E40
	// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00013C4D File Offset: 0x00011E4D
	public int Int32_1
	{
		get
		{
			return this.Control5_0.Height;
		}
		set
		{
			this.Control5_0.Height = value;
		}
	}

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00013C5B File Offset: 0x00011E5B
	// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00013C63 File Offset: 0x00011E63
	public Control5 Control5_0 { get; private set; }

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00013C6C File Offset: 0x00011E6C
	// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00013C74 File Offset: 0x00011E74
	internal int Int32_2 { get; set; }

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00013C7D File Offset: 0x00011E7D
	// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00013C85 File Offset: 0x00011E85
	public object Object_0 { get; set; }

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00013C8E File Offset: 0x00011E8E
	// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00013C9B File Offset: 0x00011E9B
	public Cursor Cursor_0
	{
		get
		{
			return this.Control5_0.Cursor;
		}
		set
		{
			this.Control5_0.Cursor = value;
		}
	}

	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00013CA9 File Offset: 0x00011EA9
	// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00013CB1 File Offset: 0x00011EB1
	public bool Boolean_0 { get; set; }

	// Token: 0x1400003C RID: 60
	// (add) Token: 0x06001D32 RID: 7474 RVA: 0x00013CBA File Offset: 0x00011EBA
	// (remove) Token: 0x06001D33 RID: 7475 RVA: 0x00013CC8 File Offset: 0x00011EC8
	public event EventHandler Event_0
	{
		add
		{
			this.Control5_0.Click += value;
		}
		remove
		{
			this.Control5_0.Click -= value;
		}
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x000DEC64 File Offset: 0x000DCE64
	public virtual void vmethod_0()
	{
		this.Class357_0.control3_0.method_53(this.Class357_0, true);
		this.Class357_0.control3_0.method_46(this.Control5_0.Bounds);
		this.Class357_0.control3_0.method_4();
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x000DECB4 File Offset: 0x000DCEB4
	protected virtual void vmethod_1()
	{
		this.Control5_0 = new Control5();
		this.Control5_0.Click += this.vmethod_2;
		this.Cursor_0 = Cursors.Default;
		this.Color_2 = Color.Silver;
		this.Color_1 = Color.White;
		this.Color_0 = ((this.Control_0 == null) ? Color.Silver : SystemColors.Control);
		this.Color_3 = Color.Black;
		this.StringAlignment_0 = StringAlignment.Near;
		this.Font_0 = ((this.Class357_0.control3_0.Parent == null) ? this.Class357_0.control3_0.Font : this.Class357_0.control3_0.Parent.Font);
		if (this.Control_0 != null)
		{
			this.Control5_0.Controls.Add(this.Control_0);
			Size preferredSize = this.Control_0.GetPreferredSize(this.Control_0.Size);
			this.Control5_0.Width = preferredSize.Width + 2;
			this.Control5_0.Height = preferredSize.Height + 2;
			this.Control_0.Dock = DockStyle.Fill;
			this.Control_0.Visible = true;
			this.Color_0 = SystemColors.Control;
			return;
		}
		this.Control5_0.Height = this.Class357_0.control3_0.Int32_2 + 5;
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x00013CD6 File Offset: 0x00011ED6
	protected virtual void vmethod_2(object sender, EventArgs e)
	{
		this.Class357_0.control3_0.vmethod_2(this);
	}

	// Token: 0x04001203 RID: 4611
	[CompilerGenerated]
	private Class357 class357_0;

	// Token: 0x04001204 RID: 4612
	[CompilerGenerated]
	private Control control_0;

	// Token: 0x04001205 RID: 4613
	[CompilerGenerated]
	private DockStyle dockStyle_0;

	// Token: 0x04001206 RID: 4614
	[CompilerGenerated]
	private Control5 control5_0;

	// Token: 0x04001207 RID: 4615
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001208 RID: 4616
	[CompilerGenerated]
	private object object_0;

	// Token: 0x04001209 RID: 4617
	[CompilerGenerated]
	private bool bool_0;
}
