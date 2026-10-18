using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// Token: 0x020001A0 RID: 416
[ToolboxBitmap(typeof(Class286), "CheckGroupBox.bmp")]
internal class Class286 : GroupBox
{
	// Token: 0x060017C1 RID: 6081 RVA: 0x000C873C File Offset: 0x000C693C
	public Class286()
	{
		this.method_0();
		this.bool_0 = false;
		this.m_checkBox.Parent = this;
		this.m_checkBox.Location = new Point(10, 0);
		this.Boolean_0 = true;
		Color color = new VisualStyleRenderer(VisualStyleElement.Button.GroupBox.Normal).GetColor(ColorProperty.TextColor);
		this.m_checkBox.ForeColor = color;
	}

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00010667 File Offset: 0x0000E867
	// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0001068F File Offset: 0x0000E88F
	public override string Text
	{
		get
		{
			if (this.Site != null && this.Site.DesignMode)
			{
				return this.m_checkBox.Text;
			}
			return " ";
		}
		set
		{
			base.Text = " ";
			this.m_checkBox.Text = value;
		}
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000106A8 File Offset: 0x0000E8A8
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000106B5 File Offset: 0x0000E8B5
	[Description("Indicates whether the component is checked or not.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool Boolean_0
	{
		get
		{
			return this.m_checkBox.Checked;
		}
		set
		{
			if (this.m_checkBox.Checked != value)
			{
				this.m_checkBox.Checked = value;
			}
		}
	}

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x000106D1 File Offset: 0x0000E8D1
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x000106DE File Offset: 0x0000E8DE
	[Description("Indicates the state of the component.")]
	[Category("Appearance")]
	[DefaultValue(CheckState.Checked)]
	public CheckState CheckState_0
	{
		get
		{
			return this.m_checkBox.CheckState;
		}
		set
		{
			if (this.m_checkBox.CheckState != value)
			{
				this.m_checkBox.CheckState = value;
			}
		}
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000106FA File Offset: 0x0000E8FA
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00010702 File Offset: 0x0000E902
	[Description("Determines if child controls of the GroupBox are disabled when the CheckBox is unchecked.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (this.bool_0 != value)
			{
				this.bool_0 = value;
			}
		}
	}

	// Token: 0x14000019 RID: 25
	// (add) Token: 0x060017CA RID: 6090 RVA: 0x000C87A4 File Offset: 0x000C69A4
	// (remove) Token: 0x060017CB RID: 6091 RVA: 0x000C87DC File Offset: 0x000C69DC
	[Description("Occurs whenever the Checked property of the CheckBox is changed.")]
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

	// Token: 0x1400001A RID: 26
	// (add) Token: 0x060017CC RID: 6092 RVA: 0x000C8814 File Offset: 0x000C6A14
	// (remove) Token: 0x060017CD RID: 6093 RVA: 0x000C884C File Offset: 0x000C6A4C
	[Description("Occurs whenever the CheckState property of the CheckBox is changed.")]
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

	// Token: 0x060017CE RID: 6094 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_0(EventArgs eventArgs_0)
	{
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_1(EventArgs eventArgs_0)
	{
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x000C8884 File Offset: 0x000C6A84
	private void m_checkBox_CheckedChanged(object sender, EventArgs e)
	{
		if (this.bool_0)
		{
			bool @checked = this.m_checkBox.Checked;
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				if (control != this.m_checkBox)
				{
					control.Enabled = @checked;
				}
			}
		}
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, e);
		}
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x00010714 File Offset: 0x0000E914
	private void m_checkBox_CheckStateChanged(object sender, EventArgs e)
	{
		if (this.eventHandler_1 != null)
		{
			this.eventHandler_1(sender, e);
		}
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x0001072B File Offset: 0x0000E92B
	private void Class286_ControlAdded(object sender, ControlEventArgs e)
	{
		if (this.bool_0)
		{
			e.Control.Enabled = this.Boolean_0;
		}
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x00010746 File Offset: 0x0000E946
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x000C8910 File Offset: 0x000C6B10
	private void method_0()
	{
		this.m_checkBox = new CheckBox();
		base.SuspendLayout();
		this.m_checkBox.AutoSize = true;
		this.m_checkBox.Checked = true;
		this.m_checkBox.CheckState = CheckState.Checked;
		this.m_checkBox.Location = new Point(0, 0);
		this.m_checkBox.Name = "m_checkBox";
		this.m_checkBox.Size = new Size(104, 24);
		this.m_checkBox.TabIndex = 0;
		this.m_checkBox.Text = "checkBox";
		this.m_checkBox.UseVisualStyleBackColor = true;
		this.m_checkBox.CheckStateChanged += this.m_checkBox_CheckStateChanged;
		this.m_checkBox.CheckedChanged += this.m_checkBox_CheckedChanged;
		base.ControlAdded += this.Class286_ControlAdded;
		base.ResumeLayout(false);
	}

	// Token: 0x04000F5A RID: 3930
	private const int int_0 = 10;

	// Token: 0x04000F5B RID: 3931
	private const int int_1 = 0;

	// Token: 0x04000F5C RID: 3932
	private bool bool_0;

	// Token: 0x04000F5D RID: 3933
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x04000F5E RID: 3934
	[CompilerGenerated]
	private EventHandler eventHandler_1;

	// Token: 0x04000F5F RID: 3935
	private IContainer icontainer_0;

	// Token: 0x04000F60 RID: 3936
	private CheckBox m_checkBox;
}
