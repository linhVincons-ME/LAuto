using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x020001CD RID: 461
[Browsable(false)]
internal class Class307 : ToolStripDropDown, IDisposable
{
	// Token: 0x060018D2 RID: 6354 RVA: 0x000CCC14 File Offset: 0x000CAE14
	public Class307(Control3 control3_0)
	{
		base.AutoClose = false;
		this.AutoSize = false;
		base.Margin = Padding.Empty;
		base.Padding = Padding.Empty;
		base.BackColor = Color.White;
		this.Control1_0 = new Control1(control3_0);
		this.toolStripControlHost_0 = new ToolStripControlHost(this.Control1_0);
		this.toolStripControlHost_0.Margin = new Padding(2, 2, 2, 2);
		this.toolStripControlHost_0.Padding = Padding.Empty;
		this.toolStripControlHost_0.AutoSize = false;
		this.toolStripControlHost_0.AutoToolTip = false;
		this.method_2();
		base.Items.Add(this.toolStripControlHost_0);
		this.Control1_0.Parent = this;
		this.String_0 = "[\\w\\.]";
		this.Int32_0 = 2;
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00011069 File Offset: 0x0000F269
	// (set) Token: 0x060018D4 RID: 6356 RVA: 0x00011071 File Offset: 0x0000F271
	public Class357 Class357_0 { get; internal set; }

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0001107A File Offset: 0x0000F27A
	// (set) Token: 0x060018D6 RID: 6358 RVA: 0x00011082 File Offset: 0x0000F282
	public string String_0 { get; set; }

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0001108B File Offset: 0x0000F28B
	// (set) Token: 0x060018D8 RID: 6360 RVA: 0x00011093 File Offset: 0x0000F293
	public int Int32_0 { get; set; }

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0001109C File Offset: 0x0000F29C
	// (set) Token: 0x060018DA RID: 6362 RVA: 0x000110A9 File Offset: 0x0000F2A9
	public bool Boolean_0
	{
		get
		{
			return this.Control1_0.Boolean_0;
		}
		set
		{
			this.Control1_0.Boolean_0 = value;
		}
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x060018DB RID: 6363 RVA: 0x000110B7 File Offset: 0x0000F2B7
	// (set) Token: 0x060018DC RID: 6364 RVA: 0x000110C4 File Offset: 0x0000F2C4
	public int Int32_1
	{
		get
		{
			return this.Control1_0.Int32_1;
		}
		set
		{
			this.Control1_0.Int32_1 = value;
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x060018DD RID: 6365 RVA: 0x000110D2 File Offset: 0x0000F2D2
	// (set) Token: 0x060018DE RID: 6366 RVA: 0x000110DF File Offset: 0x0000F2DF
	public Size Size_0
	{
		get
		{
			return this.Control1_0.Size_0;
		}
		set
		{
			this.Control1_0.Size_0 = value;
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x060018DF RID: 6367 RVA: 0x000110ED File Offset: 0x0000F2ED
	// (set) Token: 0x060018E0 RID: 6368 RVA: 0x000110FA File Offset: 0x0000F2FA
	public bool Boolean_1
	{
		get
		{
			return this.Control1_0.Boolean_1;
		}
		set
		{
			this.Control1_0.Boolean_1 = value;
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x060018E1 RID: 6369 RVA: 0x00011108 File Offset: 0x0000F308
	// (set) Token: 0x060018E2 RID: 6370 RVA: 0x00011115 File Offset: 0x0000F315
	[DefaultValue(typeof(Color), "Orange")]
	public Color Color_0
	{
		get
		{
			return this.Control1_0.Color_0;
		}
		set
		{
			this.Control1_0.Color_0 = value;
		}
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00011123 File Offset: 0x0000F323
	// (set) Token: 0x060018E4 RID: 6372 RVA: 0x00011130 File Offset: 0x0000F330
	[DefaultValue(typeof(Color), "Red")]
	public Color Color_1
	{
		get
		{
			return this.Control1_0.Color_1;
		}
		set
		{
			this.Control1_0.Color_1 = value;
		}
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0001113E File Offset: 0x0000F33E
	// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0001114B File Offset: 0x0000F34B
	public Font Font_0
	{
		get
		{
			return this.Control1_0.Font;
		}
		set
		{
			this.Control1_0.Font = value;
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00011159 File Offset: 0x0000F359
	public Control1 Control1_0 { get; }

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00011161 File Offset: 0x0000F361
	// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0001116E File Offset: 0x0000F36E
	public Size Size_1
	{
		get
		{
			return this.Control1_0.MinimumSize;
		}
		set
		{
			this.Control1_0.MinimumSize = value;
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x060018EA RID: 6378 RVA: 0x0001117C File Offset: 0x0000F37C
	// (set) Token: 0x060018EB RID: 6379 RVA: 0x00011189 File Offset: 0x0000F389
	public ImageList ImageList_0
	{
		get
		{
			return this.Control1_0.ImageList_0;
		}
		set
		{
			this.Control1_0.ImageList_0 = value;
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x060018EC RID: 6380 RVA: 0x00011197 File Offset: 0x0000F397
	// (set) Token: 0x060018ED RID: 6381 RVA: 0x000111A4 File Offset: 0x0000F3A4
	public int Int32_2
	{
		get
		{
			return this.Control1_0.Int32_2;
		}
		set
		{
			this.Control1_0.Int32_2 = value;
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x060018EE RID: 6382 RVA: 0x000111B2 File Offset: 0x0000F3B2
	// (set) Token: 0x060018EF RID: 6383 RVA: 0x000111BF File Offset: 0x0000F3BF
	public ToolTip ToolTip_0
	{
		get
		{
			return this.Control1_0.toolTip_0;
		}
		set
		{
			this.Control1_0.toolTip_0 = value;
		}
	}

	// Token: 0x1400001D RID: 29
	// (add) Token: 0x060018F0 RID: 6384 RVA: 0x000CCCE8 File Offset: 0x000CAEE8
	// (remove) Token: 0x060018F1 RID: 6385 RVA: 0x000CCD20 File Offset: 0x000CAF20
	public event EventHandler<EventArgs0> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> eventHandler3 = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> eventHandler3 = (EventHandler<EventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400001E RID: 30
	// (add) Token: 0x060018F2 RID: 6386 RVA: 0x000CCD58 File Offset: 0x000CAF58
	// (remove) Token: 0x060018F3 RID: 6387 RVA: 0x000CCD90 File Offset: 0x000CAF90
	public event EventHandler<EventArgs1> Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs1> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs1> eventHandler3 = (EventHandler<EventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs1>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs1> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs1> eventHandler3 = (EventHandler<EventArgs1>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs1>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400001F RID: 31
	// (add) Token: 0x060018F4 RID: 6388 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
	// (remove) Token: 0x060018F5 RID: 6389 RVA: 0x000CCE00 File Offset: 0x000CB000
	public event EventHandler<CancelEventArgs> Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CancelEventArgs> eventHandler = this.eventHandler_2;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> eventHandler3 = (EventHandler<CancelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<CancelEventArgs>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CancelEventArgs> eventHandler = this.eventHandler_2;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> eventHandler3 = (EventHandler<CancelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<CancelEventArgs>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x000111CD File Offset: 0x0000F3CD
	internal void method_0(CancelEventArgs cancelEventArgs_0)
	{
		if (this.eventHandler_2 != null)
		{
			this.eventHandler_2(this, cancelEventArgs_0);
		}
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x000111E4 File Offset: 0x0000F3E4
	public void method_1()
	{
		this.Control1_0.toolTip_0.Hide(this.Control1_0);
		base.Close();
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x000CCE38 File Offset: 0x000CB038
	internal void method_2()
	{
		this.toolStripControlHost_0.Size = this.Control1_0.Size;
		base.Size = new Size(this.Control1_0.Size.Width + 4, this.Control1_0.Size.Height + 4);
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00011202 File Offset: 0x0000F402
	public virtual void vmethod_0()
	{
		this.Control1_0.vmethod_0();
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x0001120F File Offset: 0x0000F40F
	public void method_3(int int_1)
	{
		this.Control1_0.method_11(int_1);
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x0001121D File Offset: 0x0000F41D
	internal void method_4(EventArgs0 eventArgs0_0)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, eventArgs0_0);
		}
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x00011234 File Offset: 0x0000F434
	public void method_5(EventArgs1 eventArgs1_0)
	{
		if (this.eventHandler_1 != null)
		{
			this.eventHandler_1(this, eventArgs1_0);
		}
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x0001124B File Offset: 0x0000F44B
	public void method_6(bool bool_0)
	{
		this.Control1_0.method_4(bool_0);
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x00011259 File Offset: 0x0000F459
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (this.Control1_0 != null && !this.Control1_0.IsDisposed)
		{
			this.Control1_0.Dispose();
		}
	}

	// Token: 0x04001060 RID: 4192
	public ToolStripControlHost toolStripControlHost_0;

	// Token: 0x04001061 RID: 4193
	[CompilerGenerated]
	private Class357 class357_0;

	// Token: 0x04001062 RID: 4194
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001063 RID: 4195
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001064 RID: 4196
	[CompilerGenerated]
	private readonly Control1 control1_0;

	// Token: 0x04001065 RID: 4197
	[CompilerGenerated]
	private EventHandler<EventArgs0> eventHandler_0;

	// Token: 0x04001066 RID: 4198
	[CompilerGenerated]
	private EventHandler<EventArgs1> eventHandler_1;

	// Token: 0x04001067 RID: 4199
	[CompilerGenerated]
	private EventHandler<CancelEventArgs> eventHandler_2;
}
