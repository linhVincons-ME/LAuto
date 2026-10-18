using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000078 RID: 120
public sealed class GClass23 : IDisposable
{
	// Token: 0x06000548 RID: 1352 RVA: 0x0000698A File Offset: 0x00004B8A
	internal GClass23(GClass20 gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
		this.bool_3 = true;
		this.int_0 = 200;
		this.string_2 = "OK";
		this.version_0 = GClass24.version_1;
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000549 RID: 1353 RVA: 0x000069C1 File Offset: 0x00004BC1
	// (set) Token: 0x0600054A RID: 1354 RVA: 0x000069C9 File Offset: 0x00004BC9
	internal bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x0600054B RID: 1355 RVA: 0x000069D2 File Offset: 0x00004BD2
	// (set) Token: 0x0600054C RID: 1356 RVA: 0x000069DA File Offset: 0x00004BDA
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

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x0600054D RID: 1357 RVA: 0x000069E3 File Offset: 0x00004BE3
	// (set) Token: 0x0600054E RID: 1358 RVA: 0x000069EB File Offset: 0x00004BEB
	public Encoding Encoding_0
	{
		get
		{
			return this.encoding_0;
		}
		set
		{
			this.method_1();
			this.encoding_0 = value;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x0600054F RID: 1359 RVA: 0x000069FA File Offset: 0x00004BFA
	// (set) Token: 0x06000550 RID: 1360 RVA: 0x00006A02 File Offset: 0x00004C02
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.method_2();
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("Less than zero.", "value");
			}
			this.long_0 = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x00006A2D File Offset: 0x00004C2D
	// (set) Token: 0x06000552 RID: 1362 RVA: 0x00006A35 File Offset: 0x00004C35
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.method_1();
			if (value != null && value.Length == 0)
			{
				throw new ArgumentException("An empty string.", "value");
			}
			this.string_0 = value;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x0002E9D4 File Offset: 0x0002CBD4
	// (set) Token: 0x06000554 RID: 1364 RVA: 0x00006A5F File Offset: 0x00004C5F
	public GClass16 GClass16_0
	{
		get
		{
			GClass16 gclass;
			if ((gclass = this.gclass16_0) == null)
			{
				gclass = (this.gclass16_0 = new GClass16());
			}
			return gclass;
		}
		set
		{
			this.gclass16_0 = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000555 RID: 1365 RVA: 0x0002E9FC File Offset: 0x0002CBFC
	// (set) Token: 0x06000556 RID: 1366 RVA: 0x00006A68 File Offset: 0x00004C68
	public GClass27 GClass27_0
	{
		get
		{
			GClass27 gclass;
			if ((gclass = this.gclass27_0) == null)
			{
				gclass = (this.gclass27_0 = new GClass27(Enum5.Response, false));
			}
			return gclass;
		}
		set
		{
			if (value != null && value.Enum5_0 != Enum5.Response)
			{
				throw new InvalidOperationException("The specified headers aren't valid for a response.");
			}
			this.gclass27_0 = value;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000557 RID: 1367 RVA: 0x00006A88 File Offset: 0x00004C88
	// (set) Token: 0x06000558 RID: 1368 RVA: 0x00006A90 File Offset: 0x00004C90
	public bool Boolean_2
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.method_2();
			this.bool_3 = value;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000559 RID: 1369 RVA: 0x0002EA24 File Offset: 0x0002CC24
	public Stream Stream_0
	{
		get
		{
			this.method_1();
			Stream2 stream;
			if ((stream = this.stream2_0) == null)
			{
				stream = (this.stream2_0 = this.gclass20_0.Class62_0.method_14());
			}
			return stream;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x0600055A RID: 1370 RVA: 0x00006A9F File Offset: 0x00004C9F
	// (set) Token: 0x0600055B RID: 1371 RVA: 0x0002EA5C File Offset: 0x0002CC5C
	public Version Version_0
	{
		get
		{
			return this.version_0;
		}
		set
		{
			this.method_2();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Major != 1 || (value.Minor != 0 && value.Minor != 1))
			{
				throw new ArgumentException("Not 1.0 or 1.1.", "value");
			}
			this.version_0 = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x00006AA7 File Offset: 0x00004CA7
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.method_1();
			if (value == null)
			{
				this.string_1 = null;
				return;
			}
			Uri uri = null;
			if (!value.smethod_89() || !Uri.TryCreate(value, UriKind.Absolute, out uri))
			{
				throw new ArgumentException("Not an absolute URL.", "value");
			}
			this.string_1 = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x0600055E RID: 1374 RVA: 0x00006AAF File Offset: 0x00004CAF
	// (set) Token: 0x0600055F RID: 1375 RVA: 0x00006AB7 File Offset: 0x00004CB7
	public bool Boolean_3
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.method_2();
			this.bool_4 = value;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000560 RID: 1376 RVA: 0x00006AC6 File Offset: 0x00004CC6
	// (set) Token: 0x06000561 RID: 1377 RVA: 0x00006ACE File Offset: 0x00004CCE
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.method_2();
			if (value < 100 || value > 999)
			{
				throw new ProtocolViolationException("A value isn't between 100 and 999 inclusive.");
			}
			this.int_0 = value;
			this.string_2 = value.smethod_82();
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x00006B01 File Offset: 0x00004D01
	// (set) Token: 0x06000563 RID: 1379 RVA: 0x0002EB00 File Offset: 0x0002CD00
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.method_2();
			if (value == null || value.Length == 0)
			{
				this.string_2 = this.int_0.smethod_82();
				return;
			}
			if (value.smethod_47() && value.IndexOfAny(new char[] { '\r', '\n' }) <= -1)
			{
				this.string_2 = value;
				return;
			}
			throw new ArgumentException("Contains invalid characters.", "value");
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0002EB68 File Offset: 0x0002CD68
	private bool method_0(GClass15 gclass15_0)
	{
		if (this.gclass16_0 == null || this.gclass16_0.Count == 0)
		{
			return true;
		}
		List<GClass15> list = this.method_4(gclass15_0).smethod_61<GClass15>();
		if (list.Count == 0)
		{
			return true;
		}
		int int32_ = gclass15_0.Int32_2;
		using (List<GClass15>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Int32_2 == int32_)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00006B09 File Offset: 0x00004D09
	private void method_1()
	{
		if (this.bool_1)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00006B24 File Offset: 0x00004D24
	private void method_2()
	{
		if (this.bool_1)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
		if (this.bool_2)
		{
			throw new InvalidOperationException("Cannot be changed after the headers are sent.");
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00006B52 File Offset: 0x00004D52
	private void method_3(bool bool_5)
	{
		this.bool_1 = true;
		this.gclass20_0.Class62_0.method_10(bool_5);
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00006B6C File Offset: 0x00004D6C
	private IEnumerable<GClass15> method_4(GClass15 gclass15_0)
	{
		GClass23.Class69 @class = new GClass23.Class69(-2);
		@class.gclass23_0 = this;
		@class.gclass15_2 = gclass15_0;
		return @class;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
	internal GClass27 method_5(MemoryStream memoryStream_0)
	{
		GClass27 gclass = new GClass27(Enum5.Response, true);
		if (this.gclass27_0 != null)
		{
			gclass.Add(this.gclass27_0);
		}
		if (this.string_0 != null)
		{
			string text = ((this.string_0.IndexOf("charset=", StringComparison.Ordinal) != -1 || this.encoding_0 == null) ? this.string_0 : string.Format("{0}; charset={1}", this.string_0, this.encoding_0.WebName));
			gclass.method_12("Content-Type", text, true);
		}
		if (gclass["Server"] == null)
		{
			gclass.method_12("Server", "websocket-sharp/1.0", true);
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		if (gclass["Date"] == null)
		{
			gclass.method_12("Date", DateTime.UtcNow.ToString("r", invariantCulture), true);
		}
		if (!this.bool_4)
		{
			gclass.method_12("Content-Length", this.long_0.ToString(invariantCulture), true);
		}
		else
		{
			gclass.method_12("Transfer-Encoding", "chunked", true);
		}
		bool flag = !this.gclass20_0.GClass22_0.Boolean_5 || !this.bool_3 || this.int_0 == 400 || this.int_0 == 408 || this.int_0 == 411 || this.int_0 == 413 || this.int_0 == 414 || this.int_0 == 500 || this.int_0 == 503;
		int int32_ = this.gclass20_0.Class62_0.Int32_0;
		if (!flag && int32_ < 100)
		{
			gclass.method_12("Keep-Alive", string.Format("timeout=15,max={0}", 100 - int32_), true);
			if (this.gclass20_0.GClass22_0.Version_0 < GClass24.version_1)
			{
				gclass.method_12("Connection", "keep-alive", true);
			}
		}
		else
		{
			gclass.method_12("Connection", "close", true);
		}
		if (this.string_1 != null)
		{
			gclass.method_12("Location", this.string_1, true);
		}
		if (this.gclass16_0 != null)
		{
			foreach (object obj in this.gclass16_0)
			{
				GClass15 gclass2 = (GClass15)obj;
				gclass.method_12("Set-Cookie", gclass2.method_3(), true);
			}
		}
		Encoding encoding = this.encoding_0 ?? Encoding.Default;
		StreamWriter streamWriter = new StreamWriter(memoryStream_0, encoding, 256);
		streamWriter.Write("HTTP/{0} {1} {2}\r\n", this.version_0, this.int_0, this.string_2);
		streamWriter.Write(gclass.method_13(true));
		streamWriter.Flush();
		memoryStream_0.Position = (long)encoding.GetPreamble().Length;
		return gclass;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00006B83 File Offset: 0x00004D83
	public void method_6()
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_3(true);
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00006B95 File Offset: 0x00004D95
	public void method_7(string string_3, string string_4)
	{
		this.GClass27_0.Set(string_3, string_4);
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00006BA4 File Offset: 0x00004DA4
	public void method_8(GClass15 gclass15_0)
	{
		this.GClass16_0.method_4(gclass15_0);
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00006BB2 File Offset: 0x00004DB2
	public void method_9(string string_3, string string_4)
	{
		this.GClass27_0.Add(string_3, string_4);
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00006BC1 File Offset: 0x00004DC1
	public void method_10()
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_3(false);
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0002EED0 File Offset: 0x0002D0D0
	public void method_11(byte[] byte_0, bool bool_5)
	{
		GClass23.Class68 @class = new GClass23.Class68();
		@class.gclass23_0 = this;
		this.method_1();
		if (byte_0 == null)
		{
			throw new ArgumentNullException("responseEntity");
		}
		int num = byte_0.Length;
		@class.stream_0 = this.Stream_0;
		if (bool_5)
		{
			@class.stream_0.Write(byte_0, 0, num);
			this.method_3(false);
			return;
		}
		@class.stream_0.BeginWrite(byte_0, 0, num, new AsyncCallback(@class.method_0), null);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0002EF44 File Offset: 0x0002D144
	public void method_12(GClass23 gclass23_0)
	{
		if (gclass23_0 == null)
		{
			throw new ArgumentNullException("templateResponse");
		}
		if (gclass23_0.gclass27_0 != null)
		{
			if (this.gclass27_0 != null)
			{
				this.gclass27_0.Clear();
			}
			this.GClass27_0.Add(gclass23_0.gclass27_0);
		}
		else if (this.gclass27_0 != null)
		{
			this.gclass27_0 = null;
		}
		this.long_0 = gclass23_0.long_0;
		this.int_0 = gclass23_0.int_0;
		this.string_2 = gclass23_0.string_2;
		this.bool_3 = gclass23_0.bool_3;
		this.version_0 = gclass23_0.version_0;
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0002EFD8 File Offset: 0x0002D1D8
	public void method_13(string string_3)
	{
		this.method_2();
		if (string_3 == null)
		{
			throw new ArgumentNullException("url");
		}
		Uri uri = null;
		if (!string_3.smethod_89() || !Uri.TryCreate(string_3, UriKind.Absolute, out uri))
		{
			throw new ArgumentException("Not an absolute URL.", "url");
		}
		this.string_1 = string_3;
		this.int_0 = 302;
		this.string_2 = "Found";
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00006BD3 File Offset: 0x00004DD3
	public void method_14(GClass15 gclass15_0)
	{
		if (gclass15_0 == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (!this.method_0(gclass15_0))
		{
			throw new ArgumentException("Cannot be replaced.", "cookie");
		}
		this.GClass16_0.method_4(gclass15_0);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00006B83 File Offset: 0x00004D83
	public void Dispose()
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_3(true);
	}

	// Token: 0x04000280 RID: 640
	private bool bool_0;

	// Token: 0x04000281 RID: 641
	private Encoding encoding_0;

	// Token: 0x04000282 RID: 642
	private long long_0;

	// Token: 0x04000283 RID: 643
	private string string_0;

	// Token: 0x04000284 RID: 644
	private GClass20 gclass20_0;

	// Token: 0x04000285 RID: 645
	private GClass16 gclass16_0;

	// Token: 0x04000286 RID: 646
	private bool bool_1;

	// Token: 0x04000287 RID: 647
	private GClass27 gclass27_0;

	// Token: 0x04000288 RID: 648
	private bool bool_2;

	// Token: 0x04000289 RID: 649
	private bool bool_3;

	// Token: 0x0400028A RID: 650
	private string string_1;

	// Token: 0x0400028B RID: 651
	private Stream2 stream2_0;

	// Token: 0x0400028C RID: 652
	private bool bool_4;

	// Token: 0x0400028D RID: 653
	private int int_0;

	// Token: 0x0400028E RID: 654
	private string string_2;

	// Token: 0x0400028F RID: 655
	private Version version_0;

	// Token: 0x02000079 RID: 121
	[CompilerGenerated]
	private sealed class Class68
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00006C08 File Offset: 0x00004E08
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			this.stream_0.EndWrite(iasyncResult_0);
			this.gclass23_0.method_3(false);
		}

		// Token: 0x04000290 RID: 656
		public Stream stream_0;

		// Token: 0x04000291 RID: 657
		public GClass23 gclass23_0;
	}

	// Token: 0x0200007A RID: 122
	[CompilerGenerated]
	private sealed class Class69 : IEnumerable<GClass15>, IEnumerator<GClass15>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x00006C22 File Offset: 0x00004E22
		[DebuggerHidden]
		public Class69(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002F03C File Offset: 0x0002D23C
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.string_0 = null;
			this.string_1 = null;
			this.string_2 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0002F098 File Offset: 0x0002D298
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				GClass23 gclass = this.gclass23_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					this.string_0 = this.gclass15_1.String_2;
					this.string_1 = this.gclass15_1.String_1;
					this.string_2 = this.gclass15_1.String_3;
					if (gclass.gclass16_0 == null)
					{
						goto IL_0104;
					}
					this.ienumerator_0 = gclass.gclass16_0.GetEnumerator();
					this.int_0 = -3;
				}
				while (this.ienumerator_0.MoveNext())
				{
					GClass15 gclass2 = (GClass15)this.ienumerator_0.Current;
					if (gclass2.String_2.Equals(this.string_0, StringComparison.OrdinalIgnoreCase) && gclass2.String_1.Equals(this.string_1, StringComparison.OrdinalIgnoreCase) && gclass2.String_3.Equals(this.string_2, StringComparison.Ordinal))
					{
						this.gclass15_0 = gclass2;
						this.int_0 = 1;
						return true;
					}
				}
				this.method_0();
				this.ienumerator_0 = null;
				IL_0104:
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
		private void method_0()
		{
			this.int_0 = -1;
			IDisposable disposable = this.ienumerator_0 as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00006C3C File Offset: 0x00004E3C
		public GClass15 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gclass15_0;
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00006C3C File Offset: 0x00004E3C
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gclass15_0;
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0002F200 File Offset: 0x0002D400
		[DebuggerHidden]
		public IEnumerator<GClass15> GetEnumerator()
		{
			GClass23.Class69 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass23.Class69(0);
				@class.gclass23_0 = this.gclass23_0;
			}
			@class.gclass15_1 = this.gclass15_2;
			return @class;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00006C44 File Offset: 0x00004E44
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000292 RID: 658
		private int int_0;

		// Token: 0x04000293 RID: 659
		private GClass15 gclass15_0;

		// Token: 0x04000294 RID: 660
		private int int_1;

		// Token: 0x04000295 RID: 661
		private GClass15 gclass15_1;

		// Token: 0x04000296 RID: 662
		public GClass15 gclass15_2;

		// Token: 0x04000297 RID: 663
		public GClass23 gclass23_0;

		// Token: 0x04000298 RID: 664
		private string string_0;

		// Token: 0x04000299 RID: 665
		private string string_1;

		// Token: 0x0400029A RID: 666
		private string string_2;

		// Token: 0x0400029B RID: 667
		private IEnumerator ienumerator_0;
	}
}
