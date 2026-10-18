using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

// Token: 0x0200006B RID: 107
internal sealed class Class62
{
	// Token: 0x06000481 RID: 1153 RVA: 0x0002CB94 File Offset: 0x0002AD94
	internal Class62(Socket socket_1, Class59 class59_1)
	{
		this.socket_0 = socket_1;
		this.class59_0 = class59_1;
		NetworkStream networkStream = new NetworkStream(socket_1, false);
		if (class59_1.Boolean_0)
		{
			GClass26 gclass26_ = class59_1.GClass26_0;
			SslStream sslStream = new SslStream(networkStream, false, gclass26_.RemoteCertificateValidationCallback_0);
			sslStream.AuthenticateAsServer(gclass26_.X509Certificate2_0, gclass26_.Boolean_1, gclass26_.SslProtocols_0, gclass26_.Boolean_0);
			this.bool_1 = true;
			this.stream_0 = sslStream;
		}
		else
		{
			this.stream_0 = networkStream;
		}
		this.endPoint_0 = socket_1.LocalEndPoint;
		this.endPoint_1 = socket_1.RemoteEndPoint;
		this.object_0 = new object();
		this.int_3 = 90000;
		this.dictionary_0 = new Dictionary<int, bool>();
		TimerCallback timerCallback;
		if ((timerCallback = Class62.Class63.timerCallback_0) == null)
		{
			timerCallback = (Class62.Class63.timerCallback_0 = new TimerCallback(Class62.smethod_1));
		}
		this.timer_0 = new Timer(timerCallback, this, -1, -1);
		this.method_5();
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000482 RID: 1154 RVA: 0x0000600F File Offset: 0x0000420F
	public bool Boolean_0
	{
		get
		{
			return this.socket_0 == null;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000601A File Offset: 0x0000421A
	public bool Boolean_1
	{
		get
		{
			return ((IPEndPoint)this.endPoint_1).Address.smethod_86();
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000484 RID: 1156 RVA: 0x00006031 File Offset: 0x00004231
	public bool Boolean_2
	{
		get
		{
			return this.bool_1;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x00006039 File Offset: 0x00004239
	public IPEndPoint IPEndPoint_0
	{
		get
		{
			return (IPEndPoint)this.endPoint_0;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000486 RID: 1158 RVA: 0x00006046 File Offset: 0x00004246
	public IPEndPoint IPEndPoint_1
	{
		get
		{
			return (IPEndPoint)this.endPoint_1;
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000487 RID: 1159 RVA: 0x00006053 File Offset: 0x00004253
	public int Int32_0
	{
		get
		{
			return this.int_2;
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000488 RID: 1160 RVA: 0x0000605B File Offset: 0x0000425B
	public Stream Stream_0
	{
		get
		{
			return this.stream_0;
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0002CC78 File Offset: 0x0002AE78
	private void method_0()
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.socket_0 == null)
			{
				return;
			}
			this.method_4();
			this.method_2();
			this.method_3();
			this.method_1();
		}
		this.method_9();
		this.method_8();
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0002CCE0 File Offset: 0x0002AEE0
	private void method_1()
	{
		try
		{
			this.socket_0.Shutdown(SocketShutdown.Both);
		}
		catch
		{
		}
		this.socket_0.Close();
		this.socket_0 = null;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00006063 File Offset: 0x00004263
	private void method_2()
	{
		if (this.memoryStream_0 == null)
		{
			return;
		}
		this.memoryStream_0.Dispose();
		this.memoryStream_0 = null;
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00006080 File Offset: 0x00004280
	private void method_3()
	{
		if (this.stream_0 == null)
		{
			return;
		}
		this.stream0_0 = null;
		this.stream2_0 = null;
		this.stream_0.Dispose();
		this.stream_0 = null;
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x0002CD20 File Offset: 0x0002AF20
	private void method_4()
	{
		if (this.timer_0 == null)
		{
			return;
		}
		try
		{
			this.timer_0.Change(-1, -1);
		}
		catch
		{
		}
		this.timer_0.Dispose();
		this.timer_0 = null;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000060AB File Offset: 0x000042AB
	private void method_5()
	{
		this.gclass20_0 = new GClass20(this);
		this.enum7_0 = Enum7.RequestLine;
		this.stream0_0 = null;
		this.enum8_0 = Enum8.None;
		this.stream2_0 = null;
		this.int_1 = 0;
		this.memoryStream_0 = new MemoryStream();
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0002CD6C File Offset: 0x0002AF6C
	private static void smethod_0(IAsyncResult iasyncResult_0)
	{
		Class62 @class = (Class62)iasyncResult_0.AsyncState;
		if (@class.socket_0 == null)
		{
			return;
		}
		object obj = @class.object_0;
		lock (obj)
		{
			if (@class.socket_0 != null)
			{
				int num = -1;
				int num2 = 0;
				try
				{
					int num3 = @class.int_2;
					if (!@class.dictionary_0[num3])
					{
						@class.timer_0.Change(-1, -1);
						@class.dictionary_0[num3] = true;
					}
					num = @class.stream_0.EndRead(iasyncResult_0);
					@class.memoryStream_0.Write(@class.byte_0, 0, num);
					num2 = (int)@class.memoryStream_0.Length;
				}
				catch (Exception ex)
				{
					if (@class.memoryStream_0 != null && @class.memoryStream_0.Length > 0L)
					{
						@class.method_16(ex.Message, 400);
						return;
					}
					@class.method_0();
					return;
				}
				if (num <= 0)
				{
					@class.method_0();
				}
				else if (@class.method_6(@class.memoryStream_0.GetBuffer(), num2))
				{
					if (!@class.gclass20_0.Boolean_0)
					{
						@class.gclass20_0.GClass22_0.method_4();
					}
					GClass19 gclass;
					if (@class.gclass20_0.Boolean_0)
					{
						@class.method_15();
					}
					else if (!@class.class59_0.method_2(@class.gclass20_0.GClass22_0.Uri_0, out gclass))
					{
						@class.method_16(null, 404);
					}
					else
					{
						if (@class.gclass19_0 != gclass)
						{
							@class.method_8();
							if (!gclass.method_7(@class))
							{
								@class.method_0();
								return;
							}
							@class.gclass19_0 = gclass;
						}
						@class.gclass20_0.GClass19_0 = gclass;
						if (@class.gclass20_0.method_0())
						{
							if (@class.gclass20_0.method_1())
							{
								@class.bool_0 = true;
							}
						}
					}
				}
				else
				{
					Stream stream = @class.stream_0;
					byte[] array = @class.byte_0;
					int num4 = 0;
					int num5 = 8192;
					AsyncCallback asyncCallback;
					if ((asyncCallback = Class62.Class63.asyncCallback_0) == null)
					{
						asyncCallback = (Class62.Class63.asyncCallback_0 = new AsyncCallback(Class62.smethod_0));
					}
					stream.BeginRead(array, num4, num5, asyncCallback, @class);
				}
			}
		}
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
	private static void smethod_1(object object_1)
	{
		Class62 @class = (Class62)object_1;
		int num = @class.int_2;
		if (@class.socket_0 == null)
		{
			return;
		}
		object obj = @class.object_0;
		lock (obj)
		{
			if (@class.socket_0 != null)
			{
				if (!@class.dictionary_0[num])
				{
					@class.method_16(null, 408);
				}
			}
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0002D02C File Offset: 0x0002B22C
	private bool method_6(byte[] byte_1, int int_4)
	{
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(64);
		}
		int num = 0;
		try
		{
			string text;
			while ((text = this.method_7(byte_1, this.int_1, int_4, out num)) != null)
			{
				this.int_1 += num;
				if (text.Length == 0)
				{
					if (this.enum7_0 != Enum7.RequestLine)
					{
						if (this.int_1 > 32768)
						{
							this.gclass20_0.String_0 = "Headers too long";
						}
						this.stringBuilder_0 = null;
						return true;
					}
				}
				else
				{
					if (this.enum7_0 == Enum7.RequestLine)
					{
						this.gclass20_0.GClass22_0.method_7(text);
						this.enum7_0 = Enum7.Headers;
					}
					else
					{
						this.gclass20_0.GClass22_0.method_3(text);
					}
					if (this.gclass20_0.Boolean_0)
					{
						return true;
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.gclass20_0.String_0 = ex.Message;
			return true;
		}
		this.int_1 += num;
		if (this.int_1 >= 32768)
		{
			this.gclass20_0.String_0 = "Headers too long";
			return true;
		}
		return false;
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x0002D14C File Offset: 0x0002B34C
	private string method_7(byte[] byte_1, int int_4, int int_5, out int int_6)
	{
		int_6 = 0;
		for (int i = int_4; i < int_5; i++)
		{
			if (this.enum8_0 == Enum8.Lf)
			{
				break;
			}
			int_6++;
			byte b = byte_1[i];
			if (b == 13)
			{
				this.enum8_0 = Enum8.Cr;
			}
			else if (b == 10)
			{
				this.enum8_0 = Enum8.Lf;
			}
			else
			{
				this.stringBuilder_0.Append((char)b);
			}
		}
		if (this.enum8_0 != Enum8.Lf)
		{
			return null;
		}
		string text = this.stringBuilder_0.ToString();
		this.stringBuilder_0.Length = 0;
		this.enum8_0 = Enum8.None;
		return text;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x000060E7 File Offset: 0x000042E7
	private void method_8()
	{
		if (this.gclass19_0 != null)
		{
			this.gclass19_0.method_13(this);
			return;
		}
		this.class59_0.method_1(this);
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0000610A File Offset: 0x0000430A
	private void method_9()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.gclass20_0.method_2();
		this.bool_0 = false;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
	internal void method_10(bool bool_2)
	{
		if (this.socket_0 == null)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.socket_0 != null)
			{
				if (bool_2)
				{
					if (this.stream2_0 != null)
					{
						this.stream2_0.method_6(true);
					}
					this.method_0();
				}
				else
				{
					this.method_14().method_6(false);
					if (this.gclass20_0.GClass23_0.Boolean_0)
					{
						this.method_0();
					}
					else if (!this.gclass20_0.GClass22_0.method_5())
					{
						this.method_0();
					}
					else
					{
						this.method_2();
						this.method_9();
						this.method_5();
						this.int_2++;
						this.method_11();
					}
				}
			}
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0002D2AC File Offset: 0x0002B4AC
	public void method_11()
	{
		if (this.byte_0 == null)
		{
			this.byte_0 = new byte[8192];
		}
		if (this.int_2 == 1)
		{
			this.int_3 = 15000;
		}
		try
		{
			this.dictionary_0.Add(this.int_2, false);
			this.timer_0.Change(this.int_3, -1);
			Stream stream = this.stream_0;
			byte[] array = this.byte_0;
			int num = 0;
			int num2 = 8192;
			AsyncCallback asyncCallback;
			if ((asyncCallback = Class62.Class63.asyncCallback_0) == null)
			{
				asyncCallback = (Class62.Class63.asyncCallback_0 = new AsyncCallback(Class62.smethod_0));
			}
			stream.BeginRead(array, num, num2, asyncCallback, this);
		}
		catch
		{
			this.method_0();
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00006127 File Offset: 0x00004327
	public void method_12()
	{
		this.method_10(false);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0002D35C File Offset: 0x0002B55C
	public Stream0 method_13(long long_0, bool bool_2)
	{
		object obj = this.object_0;
		Stream0 stream;
		lock (obj)
		{
			if (this.socket_0 == null)
			{
				stream = null;
			}
			else if (this.stream0_0 != null)
			{
				stream = this.stream0_0;
			}
			else
			{
				byte[] buffer = this.memoryStream_0.GetBuffer();
				int num = (int)this.memoryStream_0.Length - this.int_1;
				this.method_2();
				this.stream0_0 = (bool_2 ? new Stream1(this.stream_0, buffer, this.int_1, num, this.gclass20_0) : new Stream0(this.stream_0, buffer, this.int_1, num, long_0));
				stream = this.stream0_0;
			}
		}
		return stream;
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0002D420 File Offset: 0x0002B620
	public Stream2 method_14()
	{
		object obj = this.object_0;
		Stream2 stream;
		lock (obj)
		{
			if (this.socket_0 == null)
			{
				stream = null;
			}
			else if (this.stream2_0 != null)
			{
				stream = this.stream2_0;
			}
			else
			{
				GClass19 gclass = this.gclass20_0.GClass19_0;
				bool flag2 = gclass == null || gclass.Boolean_2;
				this.stream2_0 = new Stream2(this.stream_0, this.gclass20_0.GClass23_0, flag2);
				stream = this.stream2_0;
			}
		}
		return stream;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00006130 File Offset: 0x00004330
	public void method_15()
	{
		this.method_16(this.gclass20_0.String_0, this.gclass20_0.Int32_0);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0002D4BC File Offset: 0x0002B6BC
	public void method_16(string string_0, int int_4)
	{
		if (this.socket_0 == null)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.socket_0 != null)
			{
				try
				{
					GClass23 gclass23_ = this.gclass20_0.GClass23_0;
					gclass23_.Int32_0 = int_4;
					gclass23_.String_0 = "text/html";
					StringBuilder stringBuilder = new StringBuilder(64);
					stringBuilder.AppendFormat("<html><body><h1>{0} {1}", int_4, gclass23_.String_2);
					if (string_0 != null && string_0.Length > 0)
					{
						stringBuilder.AppendFormat(" ({0})</h1></body></html>", string_0);
					}
					else
					{
						stringBuilder.Append("</h1></body></html>");
					}
					Encoding utf = Encoding.UTF8;
					byte[] bytes = utf.GetBytes(stringBuilder.ToString());
					gclass23_.Encoding_0 = utf;
					gclass23_.Int64_0 = (long)bytes.Length;
					gclass23_.method_11(bytes, true);
				}
				catch
				{
					this.method_10(true);
				}
			}
		}
	}

	// Token: 0x04000216 RID: 534
	private byte[] byte_0;

	// Token: 0x04000217 RID: 535
	private const int int_0 = 8192;

	// Token: 0x04000218 RID: 536
	private GClass20 gclass20_0;

	// Token: 0x04000219 RID: 537
	private bool bool_0;

	// Token: 0x0400021A RID: 538
	private StringBuilder stringBuilder_0;

	// Token: 0x0400021B RID: 539
	private Enum7 enum7_0;

	// Token: 0x0400021C RID: 540
	private Stream0 stream0_0;

	// Token: 0x0400021D RID: 541
	private GClass19 gclass19_0;

	// Token: 0x0400021E RID: 542
	private Enum8 enum8_0;

	// Token: 0x0400021F RID: 543
	private Class59 class59_0;

	// Token: 0x04000220 RID: 544
	private EndPoint endPoint_0;

	// Token: 0x04000221 RID: 545
	private Stream2 stream2_0;

	// Token: 0x04000222 RID: 546
	private int int_1;

	// Token: 0x04000223 RID: 547
	private EndPoint endPoint_1;

	// Token: 0x04000224 RID: 548
	private MemoryStream memoryStream_0;

	// Token: 0x04000225 RID: 549
	private int int_2;

	// Token: 0x04000226 RID: 550
	private bool bool_1;

	// Token: 0x04000227 RID: 551
	private Socket socket_0;

	// Token: 0x04000228 RID: 552
	private Stream stream_0;

	// Token: 0x04000229 RID: 553
	private object object_0;

	// Token: 0x0400022A RID: 554
	private int int_3;

	// Token: 0x0400022B RID: 555
	private Dictionary<int, bool> dictionary_0;

	// Token: 0x0400022C RID: 556
	private Timer timer_0;

	// Token: 0x0200006C RID: 108
	[CompilerGenerated]
	private static class Class63
	{
		// Token: 0x0400022D RID: 557
		public static TimerCallback timerCallback_0;

		// Token: 0x0400022E RID: 558
		public static AsyncCallback asyncCallback_0;
	}
}
