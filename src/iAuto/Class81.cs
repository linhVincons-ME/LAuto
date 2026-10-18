using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x02000091 RID: 145
internal class Class81 : GClass28
{
	// Token: 0x06000684 RID: 1668 RVA: 0x00032CF0 File Offset: 0x00030EF0
	internal Class81(TcpClient tcpClient_1, string string_0, bool bool_1, GClass26 gclass26_0, GClass6 gclass6_1)
	{
		this.tcpClient_0 = tcpClient_1;
		this.bool_0 = bool_1;
		this.gclass6_0 = gclass6_1;
		NetworkStream stream = tcpClient_1.GetStream();
		if (bool_1)
		{
			SslStream sslStream = new SslStream(stream, false, gclass26_0.RemoteCertificateValidationCallback_0);
			sslStream.AuthenticateAsServer(gclass26_0.X509Certificate2_0, gclass26_0.Boolean_1, gclass26_0.SslProtocols_0, gclass26_0.Boolean_0);
			this.stream_0 = sslStream;
		}
		else
		{
			this.stream_0 = stream;
		}
		Socket client = tcpClient_1.Client;
		this.endPoint_0 = client.LocalEndPoint;
		this.endPoint_1 = client.RemoteEndPoint;
		this.class12_0 = Class12.smethod_6(this.stream_0, 90000);
		this.gclass7_0 = new GClass7(this, string_0);
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000776B File Offset: 0x0000596B
	internal GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000686 RID: 1670 RVA: 0x00007773 File Offset: 0x00005973
	internal Stream Stream_0
	{
		get
		{
			return this.stream_0;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x0000777B File Offset: 0x0000597B
	public override GClass16 P_m_BD29BBD8
	{
		get
		{
			return this.class12_0.GClass16_0;
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000688 RID: 1672 RVA: 0x00007788 File Offset: 0x00005988
	public override NameValueCollection P_m_F73319E4
	{
		get
		{
			return this.class12_0.NameValueCollection_0;
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x00007795 File Offset: 0x00005995
	public override string P_m_40863FD5
	{
		get
		{
			return this.class12_0.NameValueCollection_0["Host"];
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x0600068A RID: 1674 RVA: 0x000077AC File Offset: 0x000059AC
	public override bool P_m_0B4CBE88
	{
		get
		{
			return this.iprincipal_0 != null;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x000077B7 File Offset: 0x000059B7
	public override bool P_m_0B4CBE88_2
	{
		get
		{
			return this.P_m_4ACA8297.Address.smethod_86();
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x0600068C RID: 1676 RVA: 0x000077C9 File Offset: 0x000059C9
	public override bool P_m_A48BE766
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x0600068D RID: 1677 RVA: 0x000077D1 File Offset: 0x000059D1
	public override bool P_m_E8BC7EBE
	{
		get
		{
			return this.class12_0.Boolean_0;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x0600068E RID: 1678 RVA: 0x000077DE File Offset: 0x000059DE
	public override string P_m_6E5F397D
	{
		get
		{
			return this.class12_0.NameValueCollection_0["Origin"];
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x0600068F RID: 1679 RVA: 0x00032DA8 File Offset: 0x00030FA8
	public override NameValueCollection P_m_4976EEAF
	{
		get
		{
			if (this.nameValueCollection_0 == null)
			{
				Uri uri = this.P_m_6DBB1F3B;
				this.nameValueCollection_0 = Class72.smethod_1((uri != null) ? uri.Query : null, Encoding.UTF8);
			}
			return this.nameValueCollection_0;
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000690 RID: 1680 RVA: 0x00032DEC File Offset: 0x00030FEC
	public override Uri P_m_6DBB1F3B
	{
		get
		{
			if (this.uri_0 == null)
			{
				this.uri_0 = Class71.smethod_19(this.class12_0.String_2, this.class12_0.NameValueCollection_0["Host"], this.class12_0.Boolean_0, this.bool_0);
			}
			return this.uri_0;
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000691 RID: 1681 RVA: 0x000077F5 File Offset: 0x000059F5
	public override string P_m_D0AC26BB
	{
		get
		{
			return this.class12_0.NameValueCollection_0["Sec-WebSocket-Key"];
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000692 RID: 1682 RVA: 0x0000780C File Offset: 0x00005A0C
	public override IEnumerable<string> P_m_9596B81E
	{
		get
		{
			Class81.Class80 @class = new Class81.Class80(-2);
			@class.class81_0 = this;
			return @class;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000693 RID: 1683 RVA: 0x0000781C File Offset: 0x00005A1C
	public override string P_m_D0AC26BB_2
	{
		get
		{
			return this.class12_0.NameValueCollection_0["Sec-WebSocket-Version"];
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000694 RID: 1684 RVA: 0x00007833 File Offset: 0x00005A33
	public override IPEndPoint P_m_F2EF2D87
	{
		get
		{
			return (IPEndPoint)this.endPoint_0;
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x00007840 File Offset: 0x00005A40
	public override IPrincipal P_m_FF34850A
	{
		get
		{
			return this.iprincipal_0;
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000696 RID: 1686 RVA: 0x00007848 File Offset: 0x00005A48
	public override IPEndPoint P_m_4ACA8297
	{
		get
		{
			return (IPEndPoint)this.endPoint_1;
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000697 RID: 1687 RVA: 0x00007855 File Offset: 0x00005A55
	public override GClass7 P_m_3EA51AA9
	{
		get
		{
			return this.gclass7_0;
		}
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00032E4C File Offset: 0x0003104C
	private Class12 method_0(string string_0)
	{
		byte[] array = Class13.smethod_4(string_0).method_0();
		this.stream_0.Write(array, 0, array.Length);
		return Class12.smethod_6(this.stream_0, 15000);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00032E88 File Offset: 0x00031088
	internal bool method_1(WebSocketSharp.Net.AuthenticationSchemes authenticationSchemes_0, string string_0, Func<IIdentity, GClass25> func_0)
	{
		Class81.Class79 @class = new Class81.Class79();
		@class.class81_0 = this;
		@class.authenticationSchemes_0 = authenticationSchemes_0;
		@class.string_0 = string_0;
		@class.func_0 = func_0;
		@class.string_1 = new Class52(@class.authenticationSchemes_0, @class.string_0).ToString();
		@class.int_0 = -1;
		@class.func_1 = null;
		@class.func_1 = new Func<bool>(@class.method_0);
		return @class.func_1();
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x0000785D File Offset: 0x00005A5D
	internal void method_2()
	{
		this.stream_0.Close();
		this.tcpClient_0.Close();
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00032F00 File Offset: 0x00031100
	internal void method_3(GEnum5 genum5_0)
	{
		byte[] array = Class13.smethod_3(genum5_0).method_0();
		this.stream_0.Write(array, 0, array.Length);
		this.stream_0.Close();
		this.tcpClient_0.Close();
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00007875 File Offset: 0x00005A75
	public override string ToString()
	{
		return this.class12_0.ToString();
	}

	// Token: 0x0400036A RID: 874
	private GClass6 gclass6_0;

	// Token: 0x0400036B RID: 875
	private NameValueCollection nameValueCollection_0;

	// Token: 0x0400036C RID: 876
	private Class12 class12_0;

	// Token: 0x0400036D RID: 877
	private Uri uri_0;

	// Token: 0x0400036E RID: 878
	private bool bool_0;

	// Token: 0x0400036F RID: 879
	private EndPoint endPoint_0;

	// Token: 0x04000370 RID: 880
	private Stream stream_0;

	// Token: 0x04000371 RID: 881
	private TcpClient tcpClient_0;

	// Token: 0x04000372 RID: 882
	private IPrincipal iprincipal_0;

	// Token: 0x04000373 RID: 883
	private EndPoint endPoint_1;

	// Token: 0x04000374 RID: 884
	private GClass7 gclass7_0;

	// Token: 0x02000092 RID: 146
	[CompilerGenerated]
	private sealed class Class79
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x00032F40 File Offset: 0x00031140
		internal bool method_0()
		{
			int num = this.int_0;
			this.int_0 = num + 1;
			if (this.int_0 > 99)
			{
				return false;
			}
			IPrincipal principal = Class71.smethod_20(this.class81_0.class12_0.NameValueCollection_0["Authorization"], this.authenticationSchemes_0, this.string_0, this.class81_0.class12_0.String_1, this.func_0);
			if (principal != null && principal.Identity.IsAuthenticated)
			{
				this.class81_0.iprincipal_0 = principal;
				return true;
			}
			this.class81_0.class12_0 = this.class81_0.method_0(this.string_1);
			return this.func_1();
		}

		// Token: 0x04000375 RID: 885
		public int int_0;

		// Token: 0x04000376 RID: 886
		public Class81 class81_0;

		// Token: 0x04000377 RID: 887
		public WebSocketSharp.Net.AuthenticationSchemes authenticationSchemes_0;

		// Token: 0x04000378 RID: 888
		public string string_0;

		// Token: 0x04000379 RID: 889
		public Func<IIdentity, GClass25> func_0;

		// Token: 0x0400037A RID: 890
		public string string_1;

		// Token: 0x0400037B RID: 891
		public Func<bool> func_1;
	}

	// Token: 0x02000093 RID: 147
	[CompilerGenerated]
	private sealed class Class80 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00007882 File Offset: 0x00005A82
		[DebuggerHidden]
		public Class80(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000789C File Offset: 0x00005A9C
		[DebuggerHidden]
		public void Dispose()
		{
			this.string_1 = null;
			this.int_0 = -2;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00032FF0 File Offset: 0x000311F0
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class81 @class = this.class81_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
			}
			else
			{
				this.int_0 = -1;
				string text = @class.class12_0.NameValueCollection_0["Sec-WebSocket-Protocol"];
				if (text != null && text.Length != 0)
				{
					this.string_1 = text.Split(new char[] { ',' });
					this.int_2 = 0;
					goto IL_0091;
				}
				return false;
			}
			IL_0083:
			this.int_2++;
			IL_0091:
			if (this.int_2 >= this.string_1.Length)
			{
				this.string_1 = null;
				return false;
			}
			string text2 = this.string_1[this.int_2].Trim();
			if (text2.Length == 0)
			{
				goto IL_0083;
			}
			this.string_0 = text2;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x000078AD File Offset: 0x00005AAD
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x000078AD File Offset: 0x00005AAD
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000330B8 File Offset: 0x000312B8
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			Class81.Class80 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class81.Class80(0);
				@class.class81_0 = this.class81_0;
			}
			return @class;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000078B5 File Offset: 0x00005AB5
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400037C RID: 892
		private int int_0;

		// Token: 0x0400037D RID: 893
		private string string_0;

		// Token: 0x0400037E RID: 894
		private int int_1;

		// Token: 0x0400037F RID: 895
		public Class81 class81_0;

		// Token: 0x04000380 RID: 896
		private string[] string_1;

		// Token: 0x04000381 RID: 897
		private int int_2;
	}
}
