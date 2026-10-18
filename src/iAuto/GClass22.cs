using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x02000077 RID: 119
public sealed class GClass22
{
	// Token: 0x06000520 RID: 1312 RVA: 0x00006748 File Offset: 0x00004948
	internal GClass22(GClass20 gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
		this.class62_0 = gclass20_1.Class62_0;
		this.long_0 = -1L;
		this.gclass27_0 = new GClass27();
		this.guid_0 = Guid.NewGuid();
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000521 RID: 1313 RVA: 0x0002E320 File Offset: 0x0002C520
	public string[] String_0
	{
		get
		{
			string text = this.gclass27_0["Accept"];
			if (text == null)
			{
				return null;
			}
			if (this.string_0 == null)
			{
				this.string_0 = text.smethod_56(new char[] { ',' }).smethod_65().smethod_61<string>()
					.ToArray();
			}
			return this.string_0;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000522 RID: 1314 RVA: 0x00003657 File Offset: 0x00001857
	public int Int32_0
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000523 RID: 1315 RVA: 0x00006788 File Offset: 0x00004988
	public Encoding Encoding_0
	{
		get
		{
			if (this.encoding_0 == null)
			{
				this.encoding_0 = this.method_1() ?? Encoding.UTF8;
			}
			return this.encoding_0;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000524 RID: 1316 RVA: 0x000067AD File Offset: 0x000049AD
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000525 RID: 1317 RVA: 0x000067B5 File Offset: 0x000049B5
	public string String_1
	{
		get
		{
			return this.gclass27_0["Content-Type"];
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000526 RID: 1318 RVA: 0x000067C7 File Offset: 0x000049C7
	public GClass16 GClass16_0
	{
		get
		{
			if (this.gclass16_0 == null)
			{
				this.gclass16_0 = this.gclass27_0.smethod_29(false);
			}
			return this.gclass16_0;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000527 RID: 1319 RVA: 0x000067E9 File Offset: 0x000049E9
	public bool Boolean_0
	{
		get
		{
			return this.long_0 > 0L || this.bool_0;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000528 RID: 1320 RVA: 0x00006804 File Offset: 0x00004A04
	public NameValueCollection NameValueCollection_0
	{
		get
		{
			return this.gclass27_0;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000680C File Offset: 0x00004A0C
	public string String_2
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x0600052A RID: 1322 RVA: 0x00006814 File Offset: 0x00004A14
	public Stream Stream_0
	{
		get
		{
			if (this.stream_0 == null)
			{
				this.stream_0 = this.method_2() ?? Stream.Null;
			}
			return this.stream_0;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x00006839 File Offset: 0x00004A39
	public bool Boolean_1
	{
		get
		{
			return this.gclass20_0.IPrincipal_0 != null;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x0600052C RID: 1324 RVA: 0x00006849 File Offset: 0x00004A49
	public bool Boolean_2
	{
		get
		{
			return this.class62_0.Boolean_1;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x0600052D RID: 1325 RVA: 0x00006856 File Offset: 0x00004A56
	public bool Boolean_3
	{
		get
		{
			return this.class62_0.Boolean_2;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x0600052E RID: 1326 RVA: 0x00006863 File Offset: 0x00004A63
	public bool Boolean_4
	{
		get
		{
			return this.string_1 == "GET" && this.version_0 > GClass24.version_0 && this.gclass27_0.smethod_74("websocket");
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x0000689B File Offset: 0x00004A9B
	public bool Boolean_5
	{
		get
		{
			return this.gclass27_0.smethod_49(this.version_0);
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000530 RID: 1328 RVA: 0x000068AE File Offset: 0x00004AAE
	public IPEndPoint IPEndPoint_0
	{
		get
		{
			return this.class62_0.IPEndPoint_0;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x000068BB File Offset: 0x00004ABB
	public Version Version_0
	{
		get
		{
			return this.version_0;
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x0002E378 File Offset: 0x0002C578
	public NameValueCollection NameValueCollection_1
	{
		get
		{
			if (this.nameValueCollection_0 == null)
			{
				Uri uri = this.Uri_0;
				this.nameValueCollection_0 = Class72.smethod_1((uri != null) ? uri.Query : null, Encoding.UTF8);
			}
			return this.nameValueCollection_0;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000533 RID: 1331 RVA: 0x000068C3 File Offset: 0x00004AC3
	public string String_3
	{
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000534 RID: 1332 RVA: 0x000068CB File Offset: 0x00004ACB
	public IPEndPoint IPEndPoint_1
	{
		get
		{
			return this.class62_0.IPEndPoint_1;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000535 RID: 1333 RVA: 0x000068D8 File Offset: 0x00004AD8
	public Guid Guid_0
	{
		get
		{
			return this.guid_0;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000536 RID: 1334 RVA: 0x0002E3BC File Offset: 0x0002C5BC
	public Uri Uri_0
	{
		get
		{
			if (!this.bool_1)
			{
				this.uri_0 = Class71.smethod_19(this.string_2, this.string_3 ?? this.String_5, this.Boolean_4, this.Boolean_3);
				this.bool_1 = true;
			}
			return this.uri_0;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000537 RID: 1335 RVA: 0x0002E40C File Offset: 0x0002C60C
	public Uri Uri_1
	{
		get
		{
			string text = this.gclass27_0["Referer"];
			if (text == null)
			{
				return null;
			}
			if (this.uri_1 == null)
			{
				this.uri_1 = text.smethod_104();
			}
			return this.uri_1;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000538 RID: 1336 RVA: 0x000068E0 File Offset: 0x00004AE0
	public string String_4
	{
		get
		{
			return this.gclass27_0["User-Agent"];
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000539 RID: 1337 RVA: 0x000068F2 File Offset: 0x00004AF2
	public string String_5
	{
		get
		{
			return this.class62_0.IPEndPoint_0.ToString();
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x0600053A RID: 1338 RVA: 0x00006904 File Offset: 0x00004B04
	public string String_6
	{
		get
		{
			return this.string_3;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x0600053B RID: 1339 RVA: 0x0002E450 File Offset: 0x0002C650
	public string[] String_7
	{
		get
		{
			string text = this.gclass27_0["Accept-Language"];
			if (text == null)
			{
				return null;
			}
			if (this.string_4 == null)
			{
				this.string_4 = text.Split(new char[] { ',' }).smethod_65().smethod_61<string>()
					.ToArray();
			}
			return this.string_4;
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
	private void method_0()
	{
		if (this.gclass27_0["Transfer-Encoding"] != null)
		{
			this.gclass20_0.String_0 = "Invalid Transfer-Encoding header";
			return;
		}
		if (this.string_1 == "POST")
		{
			if (this.long_0 == -1L)
			{
				this.gclass20_0.String_0 = "Content-Length header required";
				return;
			}
			if (this.long_0 == 0L)
			{
				this.gclass20_0.String_0 = "Invalid Content-Length header";
				return;
			}
		}
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0002E528 File Offset: 0x0002C728
	private Encoding method_1()
	{
		string text = this.gclass27_0["Content-Type"];
		if (text == null)
		{
			return null;
		}
		Encoding encoding;
		Class71.smethod_26(text, out encoding);
		return encoding;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0000690C File Offset: 0x00004B0C
	private Stream0 method_2()
	{
		if (this.long_0 <= 0L && !this.bool_0)
		{
			return null;
		}
		return this.class62_0.method_13(this.long_0, this.bool_0);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0002E558 File Offset: 0x0002C758
	internal void method_3(string string_5)
	{
		char c = string_5[0];
		if (c != ' ')
		{
			if (c != '\t')
			{
				int num = string_5.IndexOf(':');
				if (num < 1)
				{
					this.gclass20_0.String_0 = "Invalid header field";
					return;
				}
				string text = string_5.Substring(0, num).Trim();
				if (text.Length == 0 || !text.smethod_48())
				{
					this.gclass20_0.String_0 = "Invalid header name";
					return;
				}
				string text2 = ((num < string_5.Length - 1) ? string_5.Substring(num + 1).Trim() : string.Empty);
				this.gclass27_0.method_12(text, text2, false);
				string text3 = text.ToLower(CultureInfo.InvariantCulture);
				if (text3 == "host")
				{
					if (this.string_3 != null)
					{
						this.gclass20_0.String_0 = "Invalid Host header";
						return;
					}
					if (text2.Length == 0)
					{
						this.gclass20_0.String_0 = "Invalid Host header";
						return;
					}
					this.string_3 = text2;
					return;
				}
				else
				{
					if (!(text3 == "content-length"))
					{
						return;
					}
					if (this.long_0 > -1L)
					{
						this.gclass20_0.String_0 = "Invalid Content-Length header";
						return;
					}
					long num2;
					if (!long.TryParse(text2, out num2))
					{
						this.gclass20_0.String_0 = "Invalid Content-Length header";
						return;
					}
					if (num2 < 0L)
					{
						this.gclass20_0.String_0 = "Invalid Content-Length header";
						return;
					}
					this.long_0 = num2;
					return;
				}
			}
		}
		this.gclass20_0.String_0 = "Invalid header field";
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0002E6DC File Offset: 0x0002C8DC
	internal void method_4()
	{
		if (this.version_0 == GClass24.version_0)
		{
			this.method_0();
			return;
		}
		if (this.string_3 == null)
		{
			this.gclass20_0.String_0 = "Host header required";
			return;
		}
		string text = this.gclass27_0["Transfer-Encoding"];
		if (text != null)
		{
			if (!text.Equals("chunked", StringComparison.OrdinalIgnoreCase))
			{
				this.gclass20_0.String_0 = string.Empty;
				this.gclass20_0.Int32_0 = 501;
				return;
			}
			this.bool_0 = true;
		}
		if ((this.string_1 == "POST" || this.string_1 == "PUT") && this.long_0 <= 0L && !this.bool_0)
		{
			this.gclass20_0.String_0 = string.Empty;
			this.gclass20_0.Int32_0 = 411;
			return;
		}
		string text2 = this.gclass27_0["Expect"];
		if (text2 != null)
		{
			if (!text2.Equals("100-continue", StringComparison.OrdinalIgnoreCase))
			{
				this.gclass20_0.String_0 = "Invalid Expect header";
				return;
			}
			this.class62_0.method_14().method_7(GClass22.byte_0, 0, GClass22.byte_0.Length);
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0002E814 File Offset: 0x0002CA14
	internal bool method_5()
	{
		Stream stream = this.Stream_0;
		if (stream == Stream.Null)
		{
			return true;
		}
		int num = 2048;
		if (this.long_0 > 0L && this.long_0 < (long)num)
		{
			num = (int)this.long_0;
		}
		byte[] array = new byte[num];
		bool flag;
		for (;;)
		{
			try
			{
				IAsyncResult asyncResult = stream.BeginRead(array, 0, num, null, null);
				if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(100))
				{
					flag = false;
					break;
				}
				if (stream.EndRead(asyncResult) <= 0)
				{
					flag = true;
					break;
				}
			}
			catch
			{
				flag = false;
				break;
			}
		}
		return flag;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00006940 File Offset: 0x00004B40
	internal bool method_6(string string_5)
	{
		return this.gclass27_0.smethod_74(string_5);
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
	internal void method_7(string string_5)
	{
		string[] array = string_5.Split(new char[] { ' ' }, 3);
		if (array.Length < 3)
		{
			this.gclass20_0.String_0 = "Invalid request line (parts)";
			return;
		}
		string text = array[0];
		if (text.Length == 0)
		{
			this.gclass20_0.String_0 = "Invalid request line (method)";
			return;
		}
		string text2 = array[1];
		if (text2.Length == 0)
		{
			this.gclass20_0.String_0 = "Invalid request line (target)";
			return;
		}
		string text3 = array[2];
		if (text3.Length != 8)
		{
			this.gclass20_0.String_0 = "Invalid request line (version)";
			return;
		}
		if (text3.IndexOf("HTTP/") != 0)
		{
			this.gclass20_0.String_0 = "Invalid request line (version)";
			return;
		}
		Version version;
		if (!text3.Substring(5).smethod_68(out version))
		{
			this.gclass20_0.String_0 = "Invalid request line (version)";
			return;
		}
		if (version.Major < 1)
		{
			this.gclass20_0.String_0 = "Invalid request line (version)";
			return;
		}
		if (!text.smethod_42(version))
		{
			this.gclass20_0.String_0 = "Invalid request line (method)";
			return;
		}
		this.string_1 = text;
		this.string_2 = text2;
		this.version_0 = version;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00003657 File Offset: 0x00001857
	public IAsyncResult method_8(AsyncCallback asyncCallback_0, object object_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00003657 File Offset: 0x00001857
	public X509Certificate2 method_9(IAsyncResult iasyncResult_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00003657 File Offset: 0x00001857
	public X509Certificate2 method_10()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0000694E File Offset: 0x00004B4E
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		stringBuilder.AppendFormat("{0} {1} HTTP/{2}\r\n", this.string_1, this.string_2, this.version_0).Append(this.gclass27_0.ToString());
		return stringBuilder.ToString();
	}

	// Token: 0x0400026C RID: 620
	private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("HTTP/1.1 100 Continue\r\n\r\n");

	// Token: 0x0400026D RID: 621
	private string[] string_0;

	// Token: 0x0400026E RID: 622
	private bool bool_0;

	// Token: 0x0400026F RID: 623
	private Class62 class62_0;

	// Token: 0x04000270 RID: 624
	private Encoding encoding_0;

	// Token: 0x04000271 RID: 625
	private long long_0;

	// Token: 0x04000272 RID: 626
	private GClass20 gclass20_0;

	// Token: 0x04000273 RID: 627
	private GClass16 gclass16_0;

	// Token: 0x04000274 RID: 628
	private GClass27 gclass27_0;

	// Token: 0x04000275 RID: 629
	private string string_1;

	// Token: 0x04000276 RID: 630
	private Stream stream_0;

	// Token: 0x04000277 RID: 631
	private Version version_0;

	// Token: 0x04000278 RID: 632
	private NameValueCollection nameValueCollection_0;

	// Token: 0x04000279 RID: 633
	private string string_2;

	// Token: 0x0400027A RID: 634
	private Guid guid_0;

	// Token: 0x0400027B RID: 635
	private Uri uri_0;

	// Token: 0x0400027C RID: 636
	private Uri uri_1;

	// Token: 0x0400027D RID: 637
	private bool bool_1;

	// Token: 0x0400027E RID: 638
	private string string_3;

	// Token: 0x0400027F RID: 639
	private string[] string_4;
}
