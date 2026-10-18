using System;
using System.IO;

// Token: 0x02000087 RID: 135
internal class Stream0 : Stream
{
	// Token: 0x060005E3 RID: 1507 RVA: 0x00006FD9 File Offset: 0x000051D9
	internal Stream0(Stream stream_1, byte[] byte_1, int int_2, int int_3)
		: this(stream_1, byte_1, int_2, int_3, -1L)
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00006FEF File Offset: 0x000051EF
	internal Stream0(Stream stream_1, byte[] byte_1, int int_2, int int_3, long long_1)
	{
		this.stream_0 = stream_1;
		this.byte_0 = byte_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.long_0 = long_1;
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00005BAB File Offset: 0x00003DAB
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00005E76 File Offset: 0x00004076
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00005E76 File Offset: 0x00004076
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00003657 File Offset: 0x00001857
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00003657 File Offset: 0x00001857
	// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003657 File Offset: 0x00001857
	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00031A44 File Offset: 0x0002FC44
	private int method_0(byte[] byte_1, int int_2, int int_3)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "A negative value.");
		}
		if (int_3 < 0)
		{
			throw new ArgumentOutOfRangeException("count", "A negative value.");
		}
		int num = byte_1.Length;
		if (int_2 + int_3 > num)
		{
			throw new ArgumentException("The sum of 'offset' and 'count' is greater than 'buffer' length.");
		}
		if (this.long_0 == 0L)
		{
			return -1;
		}
		if (this.int_0 != 0 && int_3 != 0)
		{
			if (int_3 > this.int_0)
			{
				int_3 = this.int_0;
			}
			if (this.long_0 > 0L && (long)int_3 > this.long_0)
			{
				int_3 = (int)this.long_0;
			}
			Buffer.BlockCopy(this.byte_0, this.int_1, byte_1, int_2, int_3);
			this.int_1 += int_3;
			this.int_0 -= int_3;
			if (this.long_0 > 0L)
			{
				this.long_0 -= (long)int_3;
			}
			return int_3;
		}
		return 0;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00031B40 File Offset: 0x0002FD40
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		int num = this.method_0(buffer, offset, count);
		if (num <= 0)
		{
			if (num != -1)
			{
				if (this.long_0 >= 0L && (long)count > this.long_0)
				{
					count = (int)this.long_0;
				}
				return this.stream_0.BeginRead(buffer, offset, count, callback, state);
			}
		}
		Class70 @class = new Class70(callback, state);
		@class.Byte_0 = buffer;
		@class.Int32_1 = offset;
		@class.Int32_0 = count;
		@class.Int32_2 = ((num > 0) ? num : 0);
		@class.method_0();
		return @class;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00003657 File Offset: 0x00001857
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0000701C File Offset: 0x0000521C
	public override void Close()
	{
		this.bool_0 = true;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00031BE4 File Offset: 0x0002FDE4
	public override int EndRead(IAsyncResult asyncResult)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult is Class70)
		{
			Class70 @class = (Class70)asyncResult;
			if (!@class.IsCompleted)
			{
				@class.AsyncWaitHandle.WaitOne();
			}
			return @class.Int32_2;
		}
		int num = this.stream_0.EndRead(asyncResult);
		if (num > 0 && this.long_0 > 0L)
		{
			this.long_0 -= (long)num;
		}
		return num;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00003657 File Offset: 0x00001857
	public override void EndWrite(IAsyncResult asyncResult)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0000500B File Offset: 0x0000320B
	public override void Flush()
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00031C74 File Offset: 0x0002FE74
	public override int Read(byte[] buffer, int offset, int count)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		int num = this.method_0(buffer, offset, count);
		if (num == -1)
		{
			return 0;
		}
		if (num > 0)
		{
			return num;
		}
		num = this.stream_0.Read(buffer, offset, count);
		if (num > 0 && this.long_0 > 0L)
		{
			this.long_0 -= (long)num;
		}
		return num;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00003657 File Offset: 0x00001857
	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00003657 File Offset: 0x00001857
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x00003657 File Offset: 0x00001857
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000342 RID: 834
	private long long_0;

	// Token: 0x04000343 RID: 835
	private byte[] byte_0;

	// Token: 0x04000344 RID: 836
	private int int_0;

	// Token: 0x04000345 RID: 837
	private bool bool_0;

	// Token: 0x04000346 RID: 838
	private int int_1;

	// Token: 0x04000347 RID: 839
	private Stream stream_0;
}
