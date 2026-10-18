using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020001D6 RID: 470
internal class Class312
{
	// Token: 0x0600197A RID: 6522 RVA: 0x000CE2BC File Offset: 0x000CC4BC
	public Class312(Class381 class381_1)
	{
		this.class350_0 = new Class350<Class315>(Class312.int_0);
		this.Class381_0 = class381_1;
		this.Boolean_0 = true;
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x0600197B RID: 6523 RVA: 0x000117BC File Offset: 0x0000F9BC
	public Class381 Class381_0 { get; }

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x000117C4 File Offset: 0x0000F9C4
	// (set) Token: 0x0600197D RID: 6525 RVA: 0x000117CC File Offset: 0x0000F9CC
	public bool Boolean_0 { get; set; }

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x0600197E RID: 6526 RVA: 0x000117D5 File Offset: 0x0000F9D5
	public bool Boolean_1
	{
		get
		{
			return this.class350_0.Int32_1 > 0;
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x0600197F RID: 6527 RVA: 0x000117E5 File Offset: 0x0000F9E5
	public bool Boolean_2
	{
		get
		{
			return this.stack_0.Count > 0;
		}
	}

	// Token: 0x14000021 RID: 33
	// (add) Token: 0x06001980 RID: 6528 RVA: 0x000CE320 File Offset: 0x000CC520
	// (remove) Token: 0x06001981 RID: 6529 RVA: 0x000CE358 File Offset: 0x000CC558
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

	// Token: 0x06001982 RID: 6530 RVA: 0x000CE390 File Offset: 0x000CC590
	public virtual void vmethod_0(Class314 class314_0)
	{
		if (this.int_2 > 0)
		{
			return;
		}
		if (class314_0.class381_0.Control3_0.Class357_5.Boolean_0 && class314_0 is Class315)
		{
			class314_0 = new Class322((Class315)class314_0);
		}
		if (class314_0 is Class315)
		{
			(class314_0 as Class315).bool_0 = this.int_1 > 0;
			this.class350_0.method_2(class314_0 as Class315);
		}
		try
		{
			class314_0.m_B267E5E0();
		}
		catch (ArgumentOutOfRangeException)
		{
			if (class314_0 is Class315)
			{
				this.class350_0.method_0();
			}
		}
		if (!this.Boolean_0)
		{
			this.method_5();
		}
		this.stack_0.Clear();
		this.Class381_0.Control3_0.method_130();
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x000CE45C File Offset: 0x000CC65C
	public void method_0()
	{
		if (this.class350_0.Int32_1 > 0)
		{
			Class315 @class = this.class350_0.method_0();
			this.method_2();
			try
			{
				@class.m_39C52E01();
			}
			finally
			{
				this.method_1();
			}
			this.stack_0.Push(@class);
		}
		if (this.class350_0.Int32_1 > 0 && this.class350_0.method_1().bool_0)
		{
			this.method_0();
		}
		this.Class381_0.Control3_0.method_130();
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x000117F5 File Offset: 0x0000F9F5
	private void method_1()
	{
		this.int_2--;
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00011805 File Offset: 0x0000FA05
	private void method_2()
	{
		this.int_2++;
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00011815 File Offset: 0x0000FA15
	public void method_3()
	{
		this.int_1--;
		if (this.int_1 == 0 && this.class350_0.Int32_1 > 0)
		{
			this.class350_0.method_1().bool_0 = false;
		}
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0001184C File Offset: 0x0000FA4C
	public void method_4()
	{
		this.int_1++;
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0001185C File Offset: 0x0000FA5C
	internal void method_5()
	{
		this.class350_0.method_3();
		this.stack_0.Clear();
		this.Class381_0.Control3_0.method_130();
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x000CE4EC File Offset: 0x000CC6EC
	internal void method_6()
	{
		if (this.stack_0.Count == 0)
		{
			return;
		}
		this.method_2();
		Class315 @class;
		try
		{
			@class = this.stack_0.Pop();
			if (this.Class381_0.Control3_0.Class357_5.Boolean_0)
			{
				this.Class381_0.Control3_0.Class357_5.Boolean_0 = false;
			}
			this.Class381_0.Control3_0.Class357_5.GStruct19_0 = @class.class324_1.GStruct19_0;
			this.Class381_0.Control3_0.Class357_5.GStruct19_1 = @class.class324_1.GStruct19_1;
			@class.m_B267E5E0();
			this.class350_0.method_2(@class);
		}
		finally
		{
			this.method_1();
		}
		this.eventHandler_0(this, EventArgs.Empty);
		if (@class.bool_0)
		{
			this.method_6();
		}
		this.Class381_0.Control3_0.method_130();
	}

	// Token: 0x0400108A RID: 4234
	public static int int_0 = 200;

	// Token: 0x0400108B RID: 4235
	private readonly Class350<Class315> class350_0;

	// Token: 0x0400108C RID: 4236
	private readonly Stack<Class315> stack_0 = new Stack<Class315>();

	// Token: 0x0400108D RID: 4237
	private int int_1;

	// Token: 0x0400108E RID: 4238
	protected int int_2;

	// Token: 0x0400108F RID: 4239
	[CompilerGenerated]
	private readonly Class381 class381_0;

	// Token: 0x04001090 RID: 4240
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04001091 RID: 4241
	[CompilerGenerated]
	private EventHandler eventHandler_0 = new EventHandler(Class312.Class313.f_99CCAB7F.method_0);

	// Token: 0x020001D7 RID: 471
	[CompilerGenerated]
	[Serializable]
	private sealed class Class313
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x0000500B File Offset: 0x0000320B
		internal void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x04001092 RID: 4242
		public static readonly Class312.Class313 f_99CCAB7F = new Class312.Class313();

		// Token: 0x04001093 RID: 4243
		public static EventHandler f_C58E3C21;
	}
}
