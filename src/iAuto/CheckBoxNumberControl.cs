using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000095 RID: 149
[DefaultProperty("Text")]
public partial class CheckBoxNumberControl : UserControl
{
	// Token: 0x170001DA RID: 474
	// (get) Token: 0x060006BB RID: 1723 RVA: 0x000078DC File Offset: 0x00005ADC
	// (set) Token: 0x060006BC RID: 1724 RVA: 0x000078FA File Offset: 0x00005AFA
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Bindable(true)]
	public override string Text
	{
		get
		{
			CheckBox checkBox = this.checkBox;
			string text;
			if (checkBox != null)
			{
				if ((text = checkBox.Text) != null)
				{
					return text;
				}
			}
			text = base.Text;
			return text;
		}
		set
		{
			base.Text = value;
			if (this.checkBox != null)
			{
				this.checkBox.Text = value;
			}
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x060006BD RID: 1725 RVA: 0x00007917 File Offset: 0x00005B17
	// (set) Token: 0x060006BE RID: 1726 RVA: 0x0000792A File Offset: 0x00005B2A
	public bool Boolean_0
	{
		get
		{
			CheckBox checkBox = this.checkBox;
			return checkBox != null && checkBox.Checked;
		}
		set
		{
			if (this.checkBox != null)
			{
				this.checkBox.Checked = value;
			}
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x00007940 File Offset: 0x00005B40
	// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00007957 File Offset: 0x00005B57
	public decimal Decimal_0
	{
		get
		{
			NumericUpDown numericUpDown = this.numericUpDown;
			if (numericUpDown == null)
			{
				return 0m;
			}
			return numericUpDown.Value;
		}
		set
		{
			if (this.numericUpDown != null)
			{
				this.numericUpDown.Value = value;
			}
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0000796D File Offset: 0x00005B6D
	// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00007984 File Offset: 0x00005B84
	public decimal Decimal_1
	{
		get
		{
			NumericUpDown numericUpDown = this.numericUpDown;
			if (numericUpDown == null)
			{
				return 0m;
			}
			return numericUpDown.Minimum;
		}
		set
		{
			if (this.numericUpDown != null)
			{
				this.numericUpDown.Minimum = value;
			}
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0000799A File Offset: 0x00005B9A
	// (set) Token: 0x060006C4 RID: 1732 RVA: 0x000079B6 File Offset: 0x00005BB6
	public decimal Decimal_2
	{
		get
		{
			NumericUpDown numericUpDown = this.numericUpDown;
			if (numericUpDown == null)
			{
				return 9999m;
			}
			return numericUpDown.Maximum;
		}
		set
		{
			if (this.numericUpDown != null)
			{
				this.numericUpDown.Maximum = value;
			}
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x000079CC File Offset: 0x00005BCC
	// (set) Token: 0x060006C6 RID: 1734 RVA: 0x000079E3 File Offset: 0x00005BE3
	public decimal Decimal_3
	{
		get
		{
			NumericUpDown numericUpDown = this.numericUpDown;
			if (numericUpDown == null)
			{
				return 1m;
			}
			return numericUpDown.Increment;
		}
		set
		{
			if (this.numericUpDown != null)
			{
				this.numericUpDown.Increment = value;
			}
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000079F9 File Offset: 0x00005BF9
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00007A0C File Offset: 0x00005C0C
	public bool Boolean_1
	{
		get
		{
			NumericUpDown numericUpDown = this.numericUpDown;
			return numericUpDown != null && numericUpDown.Enabled;
		}
		set
		{
			if (this.numericUpDown != null)
			{
				this.numericUpDown.Enabled = value;
			}
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00007A22 File Offset: 0x00005C22
	// (set) Token: 0x060006CA RID: 1738 RVA: 0x00007A2A File Offset: 0x00005C2A
	public bool Boolean_2 { get; set; }

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060006CB RID: 1739 RVA: 0x00033284 File Offset: 0x00031484
	// (remove) Token: 0x060006CC RID: 1740 RVA: 0x000332BC File Offset: 0x000314BC
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

	// Token: 0x1400000E RID: 14
	// (add) Token: 0x060006CD RID: 1741 RVA: 0x000332F4 File Offset: 0x000314F4
	// (remove) Token: 0x060006CE RID: 1742 RVA: 0x0003332C File Offset: 0x0003152C
	public event EventHandler Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00007A33 File Offset: 0x00005C33
	public CheckBoxNumberControl()
	{
		this.InitializeComponent();
		this.method_0();
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00033364 File Offset: 0x00031564
	private void method_0()
	{
		base.Resize += this.CheckBoxNumberControl_Resize;
		if (this.checkBox != null)
		{
			this.checkBox.Text = "Tùy chỉnh";
			this.checkBox.CheckedChanged += this.checkBox_CheckedChanged;
		}
		if (this.numericUpDown != null)
		{
			this.numericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.numericUpDown.ValueChanged += this.numericUpDown_ValueChanged;
			this.numericUpDown.MouseWheel += this.numericUpDown_MouseWheel;
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00007A47 File Offset: 0x00005C47
	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		this.method_1();
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00007A56 File Offset: 0x00005C56
	private void checkBox_CheckedChanged(object sender, EventArgs e)
	{
		EventHandler eventHandler = this.eventHandler_0;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, e);
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00007A6A File Offset: 0x00005C6A
	private void numericUpDown_ValueChanged(object sender, EventArgs e)
	{
		EventHandler eventHandler = this.eventHandler_1;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, e);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00007A7E File Offset: 0x00005C7E
	private void CheckBoxNumberControl_Resize(object sender, EventArgs e)
	{
		this.method_1();
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00007A86 File Offset: 0x00005C86
	private void method_1()
	{
		if (this.numericUpDown != null && !base.DesignMode)
		{
			this.numericUpDown.Location = new Point(base.Width - this.numericUpDown.Width, 0);
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00007ABB File Offset: 0x00005CBB
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		this.Text = base.Text;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x000333F8 File Offset: 0x000315F8
	private void numericUpDown_MouseWheel(object sender, MouseEventArgs e)
	{
		if (!this.Boolean_2)
		{
			HandledMouseEventArgs e2 = e as HandledMouseEventArgs;
			if (e2 != null)
			{
				e2.Handled = true;
			}
		}
	}

	// Token: 0x04000385 RID: 901
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04000386 RID: 902
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x04000387 RID: 903
	[CompilerGenerated]
	private EventHandler eventHandler_1;
}
