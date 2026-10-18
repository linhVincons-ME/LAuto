using System;
using System.IO;

// Token: 0x0200005F RID: 95
internal class Stream1 : Stream0
{
	// Token: 0x060003EA RID: 1002 RVA: 0x000059A5 File Offset: 0x00003BA5
	internal Stream1(Stream stream_1, byte[] byte_1, int int_3, int int_4, GClass20 gclass20_1)
		: base(stream_1, byte_1, int_3, int_4)
	{
		this.gclass20_0 = gclass20_1;
		this.class56_0 = new Class56((GClass27)gclass20_1.GClass22_0.NameValueCollection_0);
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060003EB RID: 1003 RVA: 0x000059D6 File Offset: 0x00003BD6
	// (set) Token: 0x060003EC RID: 1004 RVA: 0x000059DE File Offset: 0x00003BDE
	internal Class56 Class56_0
	{
		get
		{
			return this.class56_0;
		}
		set
		{
			this.class56_0 = value;
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0002A6B4 File Offset: 0x000288B4
	private void method_1(IAsyncResult iasyncResult_0)
	{
		Class73 @class = (Class73)iasyncResult_0.AsyncState;
		Class70 class70_ = @class.Class70_0;
		try
		{
			int num = base.EndRead(iasyncResult_0);
			this.class56_0.method_9(class70_.Byte_0, class70_.Int32_1, num);
			num = this.class56_0.method_8(@class.Byte_0, @class.Int32_2, @class.Int32_0);
			@class.Int32_2 += num;
			@class.Int32_0 -= num;
			if (@class.Int32_0 != 0 && this.class56_0.Boolean_0 && num != 0)
			{
				class70_.Int32_1 = 0;
				class70_.Int32_0 = Math.Min(8192, this.class56_0.Int32_0 + 6);
				base.BeginRead(class70_.Byte_0, class70_.Int32_1, class70_.Int32_0, new AsyncCallback(this.method_1), @class);
			}
			else
			{
				this.bool_2 = !this.class56_0.Boolean_0 && num == 0;
				class70_.Int32_0 = @class.Int32_1 - @class.Int32_0;
				class70_.method_0();
			}
		}
		catch (Exception ex)
		{
			this.gclass20_0.Class62_0.method_16(ex.Message, 400);
			class70_.method_1(ex);
		}
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0002A7FC File Offset: 0x000289FC
	public virtual IAsyncResult m_843941F3(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (this.bool_1)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "A negative value.");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "A negative value.");
		}
		int num = buffer.Length;
		if (offset + count > num)
		{
			throw new ArgumentException("The sum of 'offset' and 'count' is greater than 'buffer' length.");
		}
		Class70 @class = new Class70(callback, state);
		if (this.bool_2)
		{
			@class.method_0();
			return @class;
		}
		int num2 = this.class56_0.method_8(buffer, offset, count);
		offset += num2;
		count -= num2;
		if (count == 0)
		{
			@class.Int32_0 = num2;
			@class.method_0();
			return @class;
		}
		if (!this.class56_0.Boolean_0)
		{
			this.bool_2 = num2 == 0;
			@class.Int32_0 = num2;
			@class.method_0();
			return @class;
		}
		@class.Byte_0 = new byte[8192];
		@class.Int32_1 = 0;
		@class.Int32_0 = 8192;
		Class73 class2 = new Class73(buffer, offset, count, @class);
		class2.Int32_1 += num2;
		base.BeginRead(@class.Byte_0, @class.Int32_1, @class.Int32_0, new AsyncCallback(this.method_1), class2);
		return @class;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x000059E7 File Offset: 0x00003BE7
	public virtual void m_7E360D93()
	{
		if (this.bool_1)
		{
			return;
		}
		this.bool_1 = true;
		base.Close();
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x0002A93C File Offset: 0x00028B3C
	public virtual int m_E9848AAC(IAsyncResult asyncResult)
	{
		if (this.bool_1)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Class70 @class = asyncResult as Class70;
		if (@class == null)
		{
			throw new ArgumentException("A wrong IAsyncResult.", "asyncResult");
		}
		if (!@class.IsCompleted)
		{
			@class.AsyncWaitHandle.WaitOne();
		}
		if (@class.Boolean_0)
		{
			throw new GException2(400, "I/O operation aborted.");
		}
		return @class.Int32_0;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0002A9BC File Offset: 0x00028BBC
	public virtual int m_B24C1BA0(byte[] buffer, int offset, int count)
	{
		IAsyncResult asyncResult = this.BeginRead(buffer, offset, count, null, null);
		return this.EndRead(asyncResult);
	}

	// Token: 0x040001DE RID: 478
	private const int int_2 = 8192;

	// Token: 0x040001DF RID: 479
	private GClass20 gclass20_0;

	// Token: 0x040001E0 RID: 480
	private Class56 class56_0;

	// Token: 0x040001E1 RID: 481
	private bool bool_1;

	// Token: 0x040001E2 RID: 482
	private bool bool_2;
}
