using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000061 RID: 97
public class GClass14
{
	// Token: 0x06000403 RID: 1027 RVA: 0x00005AC3 File Offset: 0x00003CC3
	public GClass14()
	{
		this.sslProtocols_0 = SslProtocols.Default;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00005AD6 File Offset: 0x00003CD6
	public GClass14(string string_1)
	{
		this.string_0 = string_1;
		this.sslProtocols_0 = SslProtocols.Default;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x0002AE6C File Offset: 0x0002906C
	public GClass14(GClass14 gclass14_0)
	{
		if (gclass14_0 == null)
		{
			throw new ArgumentNullException("configuration");
		}
		this.bool_0 = gclass14_0.bool_0;
		this.localCertificateSelectionCallback_0 = gclass14_0.localCertificateSelectionCallback_0;
		this.x509CertificateCollection_0 = gclass14_0.x509CertificateCollection_0;
		this.sslProtocols_0 = gclass14_0.sslProtocols_0;
		this.remoteCertificateValidationCallback_0 = gclass14_0.remoteCertificateValidationCallback_0;
		this.string_0 = gclass14_0.string_0;
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00005AF0 File Offset: 0x00003CF0
	// (set) Token: 0x06000407 RID: 1031 RVA: 0x00005AF8 File Offset: 0x00003CF8
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

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x00005B01 File Offset: 0x00003D01
	// (set) Token: 0x06000409 RID: 1033 RVA: 0x00005B09 File Offset: 0x00003D09
	public X509CertificateCollection X509CertificateCollection_0
	{
		get
		{
			return this.x509CertificateCollection_0;
		}
		set
		{
			this.x509CertificateCollection_0 = value;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00005B12 File Offset: 0x00003D12
	// (set) Token: 0x0600040B RID: 1035 RVA: 0x00005B43 File Offset: 0x00003D43
	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback_0
	{
		get
		{
			if (this.localCertificateSelectionCallback_0 == null)
			{
				LocalCertificateSelectionCallback localCertificateSelectionCallback;
				if ((localCertificateSelectionCallback = GClass14.Class57.localCertificateSelectionCallback_0) == null)
				{
					localCertificateSelectionCallback = (GClass14.Class57.localCertificateSelectionCallback_0 = new LocalCertificateSelectionCallback(GClass14.smethod_0));
				}
				this.localCertificateSelectionCallback_0 = localCertificateSelectionCallback;
			}
			return this.localCertificateSelectionCallback_0;
		}
		set
		{
			this.localCertificateSelectionCallback_0 = value;
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x00005B4C File Offset: 0x00003D4C
	// (set) Token: 0x0600040D RID: 1037 RVA: 0x00005B54 File Offset: 0x00003D54
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

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00005B5D File Offset: 0x00003D5D
	// (set) Token: 0x0600040F RID: 1039 RVA: 0x00005B8E File Offset: 0x00003D8E
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback_0
	{
		get
		{
			if (this.remoteCertificateValidationCallback_0 == null)
			{
				RemoteCertificateValidationCallback remoteCertificateValidationCallback;
				if ((remoteCertificateValidationCallback = GClass14.Class57.remoteCertificateValidationCallback_0) == null)
				{
					remoteCertificateValidationCallback = (GClass14.Class57.remoteCertificateValidationCallback_0 = new RemoteCertificateValidationCallback(GClass14.smethod_1));
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

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000410 RID: 1040 RVA: 0x00005B97 File Offset: 0x00003D97
	// (set) Token: 0x06000411 RID: 1041 RVA: 0x00005B9F File Offset: 0x00003D9F
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00005BA8 File Offset: 0x00003DA8
	private static X509Certificate smethod_0(object object_0, string string_1, X509CertificateCollection x509CertificateCollection_1, X509Certificate x509Certificate_0, string[] string_2)
	{
		return null;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00005BAB File Offset: 0x00003DAB
	private static bool smethod_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	// Token: 0x040001EC RID: 492
	private bool bool_0;

	// Token: 0x040001ED RID: 493
	private LocalCertificateSelectionCallback localCertificateSelectionCallback_0;

	// Token: 0x040001EE RID: 494
	private X509CertificateCollection x509CertificateCollection_0;

	// Token: 0x040001EF RID: 495
	private SslProtocols sslProtocols_0;

	// Token: 0x040001F0 RID: 496
	private RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

	// Token: 0x040001F1 RID: 497
	private string string_0;

	// Token: 0x02000062 RID: 98
	[CompilerGenerated]
	private static class Class57
	{
		// Token: 0x040001F2 RID: 498
		public static LocalCertificateSelectionCallback localCertificateSelectionCallback_0;

		// Token: 0x040001F3 RID: 499
		public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
	}
}
