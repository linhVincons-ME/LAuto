using System;

// Token: 0x02000075 RID: 117
internal sealed class Class67
{
	// Token: 0x06000506 RID: 1286 RVA: 0x0000660A File Offset: 0x0000480A
	internal Class67(string string_5)
	{
		this.string_1 = string_5;
		this.method_0(string_5);
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x00006620 File Offset: 0x00004820
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000508 RID: 1288 RVA: 0x00006628 File Offset: 0x00004828
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000509 RID: 1289 RVA: 0x00006630 File Offset: 0x00004830
	// (set) Token: 0x0600050A RID: 1290 RVA: 0x00006638 File Offset: 0x00004838
	public GClass19 GClass19_0
	{
		get
		{
			return this.gclass19_0;
		}
		set
		{
			this.gclass19_0 = value;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x0600050B RID: 1291 RVA: 0x00006641 File Offset: 0x00004841
	public string String_1
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x0600050C RID: 1292 RVA: 0x00006649 File Offset: 0x00004849
	public string String_2
	{
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x0600050D RID: 1293 RVA: 0x00006651 File Offset: 0x00004851
	public string String_3
	{
		get
		{
			return this.string_3;
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0002E034 File Offset: 0x0002C234
	private void method_0(string string_5)
	{
		if (string_5.StartsWith("https"))
		{
			this.bool_0 = true;
		}
		int length = string_5.Length;
		int num = string_5.IndexOf(':') + 3;
		int num2 = string_5.IndexOf('/', num + 1, length - num - 1);
		int num3 = string_5.LastIndexOf(':', num2 - 1, num2 - num - 1);
		if (string_5[num2 - 1] != ']' && num3 > num)
		{
			this.string_0 = string_5.Substring(num, num3 - num);
			this.string_3 = string_5.Substring(num3 + 1, num2 - num3 - 1);
		}
		else
		{
			this.string_0 = string_5.Substring(num, num2 - num);
			this.string_3 = (this.bool_0 ? "443" : "80");
		}
		this.string_2 = string_5.Substring(num2);
		this.string_4 = string.Format("http{0}://{1}:{2}{3}", new object[]
		{
			this.bool_0 ? "s" : "",
			this.string_0,
			this.string_3,
			this.string_2
		});
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0002E140 File Offset: 0x0002C340
	public static void smethod_0(string string_5)
	{
		if (string_5 == null)
		{
			throw new ArgumentNullException("uriPrefix");
		}
		int length = string_5.Length;
		if (length == 0)
		{
			throw new ArgumentException("An empty string.", "uriPrefix");
		}
		if (!string_5.StartsWith("http://") && !string_5.StartsWith("https://"))
		{
			throw new ArgumentException("The scheme isn't 'http' or 'https'.", "uriPrefix");
		}
		int num = string_5.IndexOf(':') + 3;
		if (num >= length)
		{
			throw new ArgumentException("No host is specified.", "uriPrefix");
		}
		if (string_5[num] == ':')
		{
			throw new ArgumentException("No host is specified.", "uriPrefix");
		}
		int num2 = string_5.IndexOf('/', num, length - num);
		if (num2 == num)
		{
			throw new ArgumentException("No host is specified.", "uriPrefix");
		}
		if (num2 != -1)
		{
			if (string_5[length - 1] == '/')
			{
				if (string_5[num2 - 1] == ':')
				{
					throw new ArgumentException("No port is specified.", "uriPrefix");
				}
				if (num2 == length - 2)
				{
					throw new ArgumentException("No path is specified.", "uriPrefix");
				}
				return;
			}
		}
		throw new ArgumentException("Ends without '/'.", "uriPrefix");
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0002E250 File Offset: 0x0002C450
	public override bool Equals(object obj)
	{
		Class67 @class = obj as Class67;
		return @class != null && @class.string_4 == this.string_4;
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00006659 File Offset: 0x00004859
	public override int GetHashCode()
	{
		return this.string_4.GetHashCode();
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00006666 File Offset: 0x00004866
	public override string ToString()
	{
		return this.string_4;
	}

	// Token: 0x04000263 RID: 611
	private string string_0;

	// Token: 0x04000264 RID: 612
	private GClass19 gclass19_0;

	// Token: 0x04000265 RID: 613
	private string string_1;

	// Token: 0x04000266 RID: 614
	private string string_2;

	// Token: 0x04000267 RID: 615
	private string string_3;

	// Token: 0x04000268 RID: 616
	private string string_4;

	// Token: 0x04000269 RID: 617
	private bool bool_0;
}
