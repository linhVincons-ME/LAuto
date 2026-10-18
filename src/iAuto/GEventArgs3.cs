using System;
using System.IO;
using System.Security.Principal;
using System.Text;

// Token: 0x02000045 RID: 69
public class GEventArgs3 : EventArgs
{
	// Token: 0x06000282 RID: 642 RVA: 0x00004B31 File Offset: 0x00002D31
	internal GEventArgs3(GClass20 gclass20_1, string string_1)
	{
		this.gclass20_0 = gclass20_1;
		this.string_0 = string_1;
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000283 RID: 643 RVA: 0x00004B47 File Offset: 0x00002D47
	public GClass22 GClass22_0
	{
		get
		{
			return this.gclass20_0.GClass22_0;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000284 RID: 644 RVA: 0x00004B54 File Offset: 0x00002D54
	public GClass23 GClass23_0
	{
		get
		{
			return this.gclass20_0.GClass23_0;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000285 RID: 645 RVA: 0x00004B61 File Offset: 0x00002D61
	public IPrincipal IPrincipal_0
	{
		get
		{
			return this.gclass20_0.IPrincipal_0;
		}
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00004B6E File Offset: 0x00002D6E
	private string method_0(string string_1)
	{
		string_1 = string_1.TrimStart(new char[] { '/', '\\' });
		return new StringBuilder(this.string_0, 32).AppendFormat("/{0}", string_1).ToString().Replace('\\', '/');
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00025A5C File Offset: 0x00023C5C
	private static bool smethod_0(string string_1, out byte[] byte_0)
	{
		byte_0 = null;
		if (!File.Exists(string_1))
		{
			return false;
		}
		bool flag;
		try
		{
			byte_0 = File.ReadAllBytes(string_1);
			return true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00025A9C File Offset: 0x00023C9C
	public byte[] method_1(string string_1)
	{
		if (string_1 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_1.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_1.IndexOf("..") > -1)
		{
			throw new ArgumentException("It contains '..'.", "path");
		}
		byte[] array;
		GEventArgs3.smethod_0(this.method_0(string_1), out array);
		return array;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00025B00 File Offset: 0x00023D00
	public bool method_2(string string_1, out byte[] byte_0)
	{
		if (string_1 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_1.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_1.IndexOf("..") > -1)
		{
			throw new ArgumentException("It contains '..'.", "path");
		}
		return GEventArgs3.smethod_0(this.method_0(string_1), out byte_0);
	}

	// Token: 0x04000165 RID: 357
	private GClass20 gclass20_0;

	// Token: 0x04000166 RID: 358
	private string string_0;
}
