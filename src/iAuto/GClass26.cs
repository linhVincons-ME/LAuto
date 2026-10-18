using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000089 RID: 137
public class GClass26
{
	// Token: 0x06000612 RID: 1554 RVA: 0x0000713B File Offset: 0x0000533B
	public GClass26()
	{
		this.sslProtocols_0 = SslProtocols.Default;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0000714E File Offset: 0x0000534E
	public GClass26(X509Certificate2 x509Certificate2_1)
	{
		this.x509Certificate2_0 = x509Certificate2_1;
		this.sslProtocols_0 = SslProtocols.Default;
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x000320B0 File Offset: 0x000302B0
	public GClass26(GClass26 gclass26_0)
	{
		if (gclass26_0 == null)
		{
			throw new ArgumentNullException("configuration");
		}
		this.bool_0 = gclass26_0.bool_0;
		this.bool_1 = gclass26_0.bool_1;
		this.remoteCertificateValidationCallback_0 = gclass26_0.remoteCertificateValidationCallback_0;
		this.sslProtocols_0 = gclass26_0.sslProtocols_0;
		this.x509Certificate2_0 = gclass26_0.x509Certificate2_0;
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x00007168 File Offset: 0x00005368
	// (set) Token: 0x06000616 RID: 1558 RVA: 0x00007170 File Offset: 0x00005370
	public bool Boolean_0
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

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x00007179 File Offset: 0x00005379
	// (set) Token: 0x06000618 RID: 1560 RVA: 0x00007181 File Offset: 0x00005381
	public bool Boolean_1
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

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000619 RID: 1561 RVA: 0x0000718A File Offset: 0x0000538A
	// (set) Token: 0x0600061A RID: 1562 RVA: 0x000071BB File Offset: 0x000053BB
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback_0
	{
		get
		{
			if (this.remoteCertificateValidationCallback_0 == null)
			{
				RemoteCertificateValidationCallback remoteCertificateValidationCallback;
				if ((remoteCertificateValidationCallback = GClass26.Class74.remoteCertificateValidationCallback_0) == null)
				{
					remoteCertificateValidationCallback = (GClass26.Class74.remoteCertificateValidationCallback_0 = new RemoteCertificateValidationCallback(GClass26.smethod_0));
				}
				this.remoteCertificateValidationCallback_0 = remoteCertificateValidationCallback;
			}
			return this.remoteCertificateValidationCallback_0;
		}
		set
		{
			this.remoteCertificateValidationCallback_0 = value;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x0600061B RID: 1563 RVA: 0x000071C4 File Offset: 0x000053C4
	// (set) Token: 0x0600061C RID: 1564 RVA: 0x000071CC File Offset: 0x000053CC
	public SslProtocols SslProtocols_0
	{
		get
		{
			return this.sslProtocols_0;
		}
		set
		{
			this.sslProtocols_0 = value;
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x0600061D RID: 1565 RVA: 0x000071D5 File Offset: 0x000053D5
	// (set) Token: 0x0600061E RID: 1566 RVA: 0x000071DD File Offset: 0x000053DD
	public X509Certificate2 X509Certificate2_0
	{
		get
		{
			return this.x509Certificate2_0;
		}
		set
		{
			this.x509Certificate2_0 = value;
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00005BAB File Offset: 0x00003DAB
	private static bool smethod_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	// Token: 0x04000351 RID: 849
	private bool bool_0;

	// Token: 0x04000352 RID: 850
	private bool bool_1;

	// Token: 0x04000353 RID: 851
	private RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

	// Token: 0x04000354 RID: 852
	private SslProtocols sslProtocols_0;

	// Token: 0x04000355 RID: 853
	private X509Certificate2 x509Certificate2_0;

	// Token: 0x0200008A RID: 138
	[CompilerGenerated]
	private static class Class74
	{
		// Token: 0x04000356 RID: 854
		public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
	}
}
