using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000071 RID: 113
internal class Class65 : IAsyncResult
{
	// Token: 0x060004E1 RID: 1249 RVA: 0x00006477 File Offset: 0x00004677
	internal Class65(AsyncCallback asyncCallback_1, object object_2)
	{
		this.asyncCallback_0 = asyncCallback_1;
		this.object_0 = object_2;
		this.object_1 = new object();
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00006498 File Offset: 0x00004698
	// (set) Token: 0x060004E3 RID: 1251 RVA: 0x000064A0 File Offset: 0x000046A0
	internal bool Boolean_0
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000064A9 File Offset: 0x000046A9
	// (set) Token: 0x060004E5 RID: 1253 RVA: 0x000064B1 File Offset: 0x000046B1
	internal bool Boolean_1
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000064BA File Offset: 0x000046BA
	public object AsyncState
	{
		get
		{
			return this.object_0;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002DDAC File Offset: 0x0002BFAC
	public WaitHandle AsyncWaitHandle
	{
		get
		{
			object obj = this.object_1;
			WaitHandle waitHandle;
			lock (obj)
			{
				ManualResetEvent manualResetEvent;
				if ((manualResetEvent = this.manualResetEvent_0) == null)
				{
					manualResetEvent = (this.manualResetEvent_0 = new ManualResetEvent(this.bool_0));
				}
				waitHandle = manualResetEvent;
			}
			return waitHandle;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000064C2 File Offset: 0x000046C2
	public bool CompletedSynchronously
	{
		get
		{
			return this.bool_3;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002DE08 File Offset: 0x0002C008
	public bool IsCompleted
	{
		get
		{
			object obj = this.object_1;
			bool flag2;
			lock (obj)
			{
				flag2 = this.bool_0;
			}
			return flag2;
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0002DE4C File Offset: 0x0002C04C
	private static void smethod_0(Class65 class65_0)
	{
		Class65.Class66 @class = new Class65.Class66();
		@class.class65_0 = class65_0;
		object obj = @class.class65_0.object_1;
		lock (obj)
		{
			@class.class65_0.bool_0 = true;
			ManualResetEvent manualResetEvent = @class.class65_0.manualResetEvent_0;
			if (manualResetEvent != null)
			{
				manualResetEvent.Set();
			}
		}
		@class.asyncCallback_0 = @class.class65_0.asyncCallback_0;
		if (@class.asyncCallback_0 == null)
		{
			return;
		}
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0), null);
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x000064CA File Offset: 0x000046CA
	internal void method_0(Exception exception_1)
	{
		this.exception_0 = ((!this.bool_2 || !(exception_1 is ObjectDisposedException)) ? exception_1 : new GException2(995, "The listener is closed."));
		Class65.smethod_0(this);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x000064FA File Offset: 0x000046FA
	internal void method_1(GClass20 gclass20_1)
	{
		this.method_2(gclass20_1, false);
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00006504 File Offset: 0x00004704
	internal void method_2(GClass20 gclass20_1, bool bool_4)
	{
		this.gclass20_0 = gclass20_1;
		this.bool_3 = bool_4;
		Class65.smethod_0(this);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0000651A File Offset: 0x0000471A
	internal GClass20 method_3()
	{
		if (this.exception_0 != null)
		{
			throw this.exception_0;
		}
		return this.gclass20_0;
	}

	// Token: 0x0400024F RID: 591
	private AsyncCallback asyncCallback_0;

	// Token: 0x04000250 RID: 592
	private bool bool_0;

	// Token: 0x04000251 RID: 593
	private GClass20 gclass20_0;

	// Token: 0x04000252 RID: 594
	private bool bool_1;

	// Token: 0x04000253 RID: 595
	private Exception exception_0;

	// Token: 0x04000254 RID: 596
	private bool bool_2;

	// Token: 0x04000255 RID: 597
	private object object_0;

	// Token: 0x04000256 RID: 598
	private object object_1;

	// Token: 0x04000257 RID: 599
	private bool bool_3;

	// Token: 0x04000258 RID: 600
	private ManualResetEvent manualResetEvent_0;

	// Token: 0x02000072 RID: 114
	[CompilerGenerated]
	private sealed class Class66
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		internal void method_0(object object_0)
		{
			try
			{
				this.asyncCallback_0(this.class65_0);
			}
			catch
			{
			}
		}

		// Token: 0x04000259 RID: 601
		public AsyncCallback asyncCallback_0;

		// Token: 0x0400025A RID: 602
		public Class65 class65_0;
	}
}
