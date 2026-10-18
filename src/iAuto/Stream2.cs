using System;
using System.IO;
using System.Text;

// Token: 0x02000088 RID: 136
internal class Stream2 : Stream
{
	// Token: 0x060005F6 RID: 1526 RVA: 0x00031CE4 File Offset: 0x0002FEE4
	internal Stream2(Stream stream_1, GClass23 gclass23_1, bool bool_2)
	{
		this.stream_0 = stream_1;
		this.gclass23_0 = gclass23_1;
		if (bool_2)
		{
			this.action_0 = new Action<byte[], int, int>(this.method_5);
			this.action_2 = new Action<byte[], int, int>(this.method_4);
		}
		else
		{
			this.action_0 = new Action<byte[], int, int>(stream_1.Write);
			this.action_2 = new Action<byte[], int, int>(this.method_3);
		}
		this.memoryStream_0 = new MemoryStream();
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00005E76 File Offset: 0x00004076
	public override bool CanRead
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00005E76 File Offset: 0x00004076
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00007025 File Offset: 0x00005225
	public override bool CanWrite
	{
		get
		{
			return !this.bool_0;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060005FA RID: 1530 RVA: 0x00003657 File Offset: 0x00001857
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x060005FB RID: 1531 RVA: 0x00003657 File Offset: 0x00001857
	// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003657 File Offset: 0x00001857
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

	// Token: 0x060005FD RID: 1533 RVA: 0x00031D60 File Offset: 0x0002FF60
	private bool method_0(bool bool_2)
	{
		if (!this.gclass23_0.Boolean_1)
		{
			if (!this.method_2(bool_2))
			{
				if (bool_2)
				{
					this.gclass23_0.Boolean_0 = true;
				}
				return false;
			}
			this.bool_1 = this.gclass23_0.Boolean_3;
			this.action_1 = (this.bool_1 ? this.action_2 : this.action_0);
		}
		this.method_1(bool_2);
		if (bool_2 && this.bool_1)
		{
			byte[] array = Stream2.smethod_0(0, true);
			this.action_0(array, 0, array.Length);
		}
		return true;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00031DEC File Offset: 0x0002FFEC
	private void method_1(bool bool_2)
	{
		using (this.memoryStream_0)
		{
			long length = this.memoryStream_0.Length;
			if (length > 2147483647L)
			{
				this.memoryStream_0.Position = 0L;
				int num = 1024;
				byte[] array = new byte[1024];
				int num2;
				while ((num2 = this.memoryStream_0.Read(array, 0, num)) > 0)
				{
					this.action_1(array, 0, num2);
				}
			}
			else if (length > 0L)
			{
				this.action_1(this.memoryStream_0.GetBuffer(), 0, (int)length);
			}
		}
		this.memoryStream_0 = ((!bool_2) ? new MemoryStream() : null);
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00031EBC File Offset: 0x000300BC
	private bool method_2(bool bool_2)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			GClass27 gclass = this.gclass23_0.method_5(memoryStream);
			long position = memoryStream.Position;
			long num = memoryStream.Length - position;
			if (num > 32768L)
			{
				return false;
			}
			if (!this.gclass23_0.Boolean_3 && this.gclass23_0.Int64_0 != this.memoryStream_0.Length)
			{
				return false;
			}
			this.action_0(memoryStream.GetBuffer(), (int)position, (int)num);
			this.gclass23_0.Boolean_0 = gclass["Connection"] == "close";
			this.gclass23_0.Boolean_1 = true;
		}
		return true;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00007030 File Offset: 0x00005230
	private static byte[] smethod_0(int int_0, bool bool_2)
	{
		return Encoding.ASCII.GetBytes(string.Format("{0:x}\r\n{1}", int_0, bool_2 ? "\r\n" : ""));
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00031F88 File Offset: 0x00030188
	private void method_3(byte[] byte_1, int int_0, int int_1)
	{
		byte[] array = Stream2.smethod_0(int_1, false);
		this.stream_0.Write(array, 0, array.Length);
		this.stream_0.Write(byte_1, int_0, int_1);
		this.stream_0.Write(Stream2.byte_0, 0, 2);
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00031FD0 File Offset: 0x000301D0
	private void method_4(byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			this.method_3(byte_1, int_0, int_1);
		}
		catch
		{
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00031FFC File Offset: 0x000301FC
	private void method_5(byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			this.stream_0.Write(byte_1, int_0, int_1);
		}
		catch
		{
		}
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0003202C File Offset: 0x0003022C
	internal void method_6(bool bool_2)
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		if (!bool_2 && this.method_0(true))
		{
			this.gclass23_0.method_10();
		}
		else
		{
			if (this.bool_1)
			{
				byte[] array = Stream2.smethod_0(0, true);
				this.action_0(array, 0, array.Length);
			}
			this.memoryStream_0.Dispose();
			this.memoryStream_0 = null;
			this.gclass23_0.method_6();
		}
		this.gclass23_0 = null;
		this.stream_0 = null;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0000705B File Offset: 0x0000525B
	internal void method_7(byte[] byte_1, int int_0, int int_1)
	{
		this.action_0(byte_1, int_0, int_1);
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00003657 File Offset: 0x00001857
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0000706B File Offset: 0x0000526B
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		return this.memoryStream_0.BeginWrite(buffer, offset, count, callback, state);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00007098 File Offset: 0x00005298
	public override void Close()
	{
		this.method_6(false);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x000070A1 File Offset: 0x000052A1
	protected override void Dispose(bool disposing)
	{
		this.method_6(!disposing);
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00003657 File Offset: 0x00001857
	public override int EndRead(IAsyncResult asyncResult)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000070AD File Offset: 0x000052AD
	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		this.memoryStream_0.EndWrite(asyncResult);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000070D4 File Offset: 0x000052D4
	public override void Flush()
	{
		if (!this.bool_0 && (this.bool_1 || this.gclass23_0.Boolean_3))
		{
			this.method_0(false);
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00003657 File Offset: 0x00001857
	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00003657 File Offset: 0x00001857
	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00003657 File Offset: 0x00001857
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x000070FB File Offset: 0x000052FB
	public override void Write(byte[] buffer, int offset, int count)
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		this.memoryStream_0.Write(buffer, offset, count);
	}

	// Token: 0x04000348 RID: 840
	private MemoryStream memoryStream_0;

	// Token: 0x04000349 RID: 841
	private static readonly byte[] byte_0 = new byte[] { 13, 10 };

	// Token: 0x0400034A RID: 842
	private bool bool_0;

	// Token: 0x0400034B RID: 843
	private GClass23 gclass23_0;

	// Token: 0x0400034C RID: 844
	private bool bool_1;

	// Token: 0x0400034D RID: 845
	private Stream stream_0;

	// Token: 0x0400034E RID: 846
	private Action<byte[], int, int> action_0;

	// Token: 0x0400034F RID: 847
	private Action<byte[], int, int> action_1;

	// Token: 0x04000350 RID: 848
	private Action<byte[], int, int> action_2;
}
