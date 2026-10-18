using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000096 RID: 150
[DefaultProperty("Text")]
public partial class CheckBoxComboControl : UserControl
{
	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00007AD0 File Offset: 0x00005CD0
	// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00007ADD File Offset: 0x00005CDD
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Bindable(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			return this.checkBox.Text;
		}
		set
		{
			base.Text = value;
			this.checkBox.Text = value;
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x060006DA RID: 1754 RVA: 0x00007AF2 File Offset: 0x00005CF2
	// (set) Token: 0x060006DB RID: 1755 RVA: 0x00007AFF File Offset: 0x00005CFF
	public bool Boolean_0
	{
		get
		{
			return this.checkBox.Checked;
		}
		set
		{
			this.checkBox.Checked = value;
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x060006DC RID: 1756 RVA: 0x00007B0D File Offset: 0x00005D0D
	// (set) Token: 0x060006DD RID: 1757 RVA: 0x00007B1A File Offset: 0x00005D1A
	public string String_0
	{
		get
		{
			return this.comboBox.Text;
		}
		set
		{
			this.comboBox.Text = value;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x060006DE RID: 1758 RVA: 0x00007B28 File Offset: 0x00005D28
	// (set) Token: 0x060006DF RID: 1759 RVA: 0x00007B35 File Offset: 0x00005D35
	public object Object_0
	{
		get
		{
			return this.comboBox.SelectedItem;
		}
		set
		{
			this.comboBox.SelectedItem = value;
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00007B43 File Offset: 0x00005D43
	// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00007B50 File Offset: 0x00005D50
	public int Int32_0
	{
		get
		{
			return this.comboBox.SelectedIndex;
		}
		set
		{
			this.comboBox.SelectedIndex = value;
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00007B5E File Offset: 0x00005D5E
	public ComboBox.ObjectCollection ObjectCollection_0
	{
		get
		{
			return this.comboBox.Items;
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00007B6B File Offset: 0x00005D6B
	// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00007B78 File Offset: 0x00005D78
	public ComboBoxStyle ComboBoxStyle_0
	{
		get
		{
			return this.comboBox.DropDownStyle;
		}
		set
		{
			this.comboBox.DropDownStyle = value;
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00007B86 File Offset: 0x00005D86
	[Browsable(false)]
	public ComboBox ComboBox_0
	{
		get
		{
			return this.comboBox;
		}
	}

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x060006E6 RID: 1766 RVA: 0x00033420 File Offset: 0x00031620
	// (remove) Token: 0x060006E7 RID: 1767 RVA: 0x00033458 File Offset: 0x00031658
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

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x060006E8 RID: 1768 RVA: 0x00033490 File Offset: 0x00031690
	// (remove) Token: 0x060006E9 RID: 1769 RVA: 0x000334C8 File Offset: 0x000316C8
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

	// Token: 0x14000011 RID: 17
	// (add) Token: 0x060006EA RID: 1770 RVA: 0x00033500 File Offset: 0x00031700
	// (remove) Token: 0x060006EB RID: 1771 RVA: 0x00033538 File Offset: 0x00031738
	public event EventHandler Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00007B8E File Offset: 0x00005D8E
	public CheckBoxComboControl()
	{
		this.InitializeComponent();
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00007B9C File Offset: 0x00005D9C
	private void checkBox_CheckedChanged(object sender, EventArgs e)
	{
		EventHandler eventHandler = this.eventHandler_0;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, e);
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00007BB0 File Offset: 0x00005DB0
	private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		EventHandler eventHandler = this.eventHandler_1;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, e);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00007BC4 File Offset: 0x00005DC4
	private void comboBox_TextChanged(object sender, EventArgs e)
	{
		EventHandler eventHandler = this.eventHandler_2;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, e);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00007BD8 File Offset: 0x00005DD8
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		if (!base.DesignMode)
		{
			this.Text = base.Text;
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00007BF5 File Offset: 0x00005DF5
	public void method_0(object object_0)
	{
		if (this.comboBox != null && object_0 != null)
		{
			this.comboBox.Items.Add(object_0);
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00007C14 File Offset: 0x00005E14
	public void method_1(object[] object_0)
	{
		if (this.comboBox != null && object_0 != null && object_0.Length != 0)
		{
			this.comboBox.Items.AddRange(object_0);
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00007C36 File Offset: 0x00005E36
	public void method_2()
	{
		if (this.comboBox != null)
		{
			this.comboBox.Items.Clear();
		}
	}

	// Token: 0x0400038B RID: 907
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x0400038C RID: 908
	[CompilerGenerated]
	private EventHandler eventHandler_1;

	// Token: 0x0400038D RID: 909
	[CompilerGenerated]
	private EventHandler eventHandler_2;
}
