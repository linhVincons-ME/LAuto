using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200007E RID: 126
internal class Class70 : IAsyncResult
{
	// Token: 0x0600057F RID: 1407 RVA: 0x00006C4C File Offset: 0x00004E4C
	internal Class70(AsyncCallback asyncCallback_1, object object_2)
	{
		this.asyncCallback_0 = asyncCallback_1;
		this.object_0 = object_2;
		this.object_1 = new object();
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000580 RID: 1408 RVA: 0x00006C6D File Offset: 0x00004E6D
	// (set) Token: 0x06000581 RID: 1409 RVA: 0x00006C75 File Offset: 0x00004E75
	internal byte[] Byte_0
	{
		get
		{
			return this.byte_0;
		}
		set
		{
			this.byte_0 = value;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000582 RID: 1410 RVA: 0x00006C7E File Offset: 0x00004E7E
	// (set) Token: 0x06000583 RID: 1411 RVA: 0x00006C86 File Offset: 0x00004E86
	internal int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000584 RID: 1412 RVA: 0x00006C8F File Offset: 0x00004E8F
	internal Exception Exception_0
	{
		get
		{
			return this.exception_0;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000585 RID: 1413 RVA: 0x00006C97 File Offset: 0x00004E97
	internal bool Boolean_0
	{
		get
		{
			return this.exception_0 != null;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000586 RID: 1414 RVA: 0x00006CA2 File Offset: 0x00004EA2
	// (set) Token: 0x06000587 RID: 1415 RVA: 0x00006CAA File Offset: 0x00004EAA
	internal int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000588 RID: 1416 RVA: 0x00006CB3 File Offset: 0x00004EB3
	// (set) Token: 0x06000589 RID: 1417 RVA: 0x00006CBB File Offset: 0x00004EBB
	internal int Int32_2
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x0600058A RID: 1418 RVA: 0x00006CC4 File Offset: 0x00004EC4
	public object AsyncState
	{
		get
		{
			return this.object_0;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x0600058B RID: 1419 RVA: 0x0002F250 File Offset: 0x0002D450
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

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x0600058C RID: 1420 RVA: 0x00006CCC File Offset: 0x00004ECC
	public bool CompletedSynchronously
	{
		get
		{
			return this.int_2 == this.int_0;
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x0600058D RID: 1421 RVA: 0x0002F2AC File Offset: 0x0002D4AC
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

	// Token: 0x0600058E RID: 1422 RVA: 0x0002F2F0 File Offset: 0x0002D4F0
	internal void method_0()
	{
		object obj = this.object_1;
		lock (obj)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				if (this.manualResetEvent_0 != null)
				{
					this.manualResetEvent_0.Set();
				}
				if (this.asyncCallback_0 != null)
				{
					this.asyncCallback_0.BeginInvoke(this, new AsyncCallback(this.method_2), null);
				}
			}
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00006CDC File Offset: 0x00004EDC
	internal void method_1(Exception exception_1)
	{
		this.exception_0 = exception_1;
		this.method_0();
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00006CEB File Offset: 0x00004EEB
	[CompilerGenerated]
	private void method_2(IAsyncResult iasyncResult_0)
	{
		this.asyncCallback_0.EndInvoke(iasyncResult_0);
	}

	// Token: 0x0400031C RID: 796
	private byte[] byte_0;

	// Token: 0x0400031D RID: 797
	private AsyncCallback asyncCallback_0;

	// Token: 0x0400031E RID: 798
	private bool bool_0;

	// Token: 0x0400031F RID: 799
	private int int_0;

	// Token: 0x04000320 RID: 800
	private Exception exception_0;

	// Token: 0x04000321 RID: 801
	private int int_1;

	// Token: 0x04000322 RID: 802
	private object object_0;

	// Token: 0x04000323 RID: 803
	private object object_1;

	// Token: 0x04000324 RID: 804
	private int int_2;

	// Token: 0x04000325 RID: 805
	private ManualResetEvent manualResetEvent_0;
}
