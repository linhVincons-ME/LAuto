using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using WebSocketSharp.Net;

// Token: 0x0200004B RID: 75
public class GClass10
{
	// Token: 0x06000300 RID: 768 RVA: 0x00026F80 File Offset: 0x00025180
	public GClass10()
	{
		IPAddress any = IPAddress.Any;
		this.method_6(any.ToString(), any, 80, false);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00005127 File Offset: 0x00003327
	public GClass10(int int_1)
		: this(int_1, int_1 == 443)
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00026FAC File Offset: 0x000251AC
	public GClass10(string string_4)
	{
		if (string_4 == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string_4.Length == 0)
		{
			throw new ArgumentException("An empty string.", "url");
		}
		Uri uri;
		string text;
		if (!GClass10.smethod_1(string_4, out uri, out text))
		{
			throw new ArgumentException(text, "url");
		}
		string dnsSafeHost = uri.DnsSafeHost;
		IPAddress ipaddress = dnsSafeHost.smethod_60();
		if (ipaddress == null)
		{
			text = "The host part could not be converted to an IP address.";
			throw new ArgumentException(text, "url");
		}
		if (!ipaddress.smethod_86())
		{
			text = "The IP address of the host is not a local IP address.";
			throw new ArgumentException(text, "url");
		}
		this.method_6(dnsSafeHost, ipaddress, uri.Port, uri.Scheme == "wss");
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00027058 File Offset: 0x00025258
	public GClass10(int int_1, bool bool_4)
	{
		if (!int_1.smethod_43())
		{
			string text = "Less than 1 or greater than 65535.";
			throw new ArgumentOutOfRangeException("port", text);
		}
		IPAddress any = IPAddress.Any;
		this.method_6(any.ToString(), any, int_1, bool_4);
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00005138 File Offset: 0x00003338
	public GClass10(IPAddress ipaddress_1, int int_1)
		: this(ipaddress_1, int_1, int_1 == 443)
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0002709C File Offset: 0x0002529C
	public GClass10(IPAddress ipaddress_1, int int_1, bool bool_4)
	{
		if (ipaddress_1 == null)
		{
			throw new ArgumentNullException("address");
		}
		if (!ipaddress_1.smethod_86())
		{
			throw new ArgumentException("Not a local IP address.", "address");
		}
		if (!int_1.smethod_43())
		{
			string text = "Less than 1 or greater than 65535.";
			throw new ArgumentOutOfRangeException("port", text);
		}
		this.method_6(ipaddress_1.ToString(), ipaddress_1, int_1, bool_4);
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000306 RID: 774 RVA: 0x0000514A File Offset: 0x0000334A
	public IPAddress IPAddress_0
	{
		get
		{
			return this.ipaddress_0;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00005152 File Offset: 0x00003352
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00027100 File Offset: 0x00025300
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			string text;
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.bool_0 = value;
				}
			}
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000309 RID: 777 RVA: 0x0000515A File Offset: 0x0000335A
	// (set) Token: 0x0600030A RID: 778 RVA: 0x00027170 File Offset: 0x00025370
	public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes_0
	{
		get
		{
			return this.authenticationSchemes_0;
		}
		set
		{
			string text;
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.authenticationSchemes_0 = value;
				}
			}
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600030B RID: 779 RVA: 0x00005162 File Offset: 0x00003362
	public bool Boolean_1
	{
		get
		{
			return this.enum4_0 == Enum4.Start;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600030C RID: 780 RVA: 0x0000516F File Offset: 0x0000336F
	public bool Boolean_2
	{
		get
		{
			return this.bool_3;
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600030D RID: 781 RVA: 0x00005177 File Offset: 0x00003377
	// (set) Token: 0x0600030E RID: 782 RVA: 0x00005184 File Offset: 0x00003384
	public bool Boolean_3
	{
		get
		{
			return this.gclass12_0.Boolean_0;
		}
		set
		{
			this.gclass12_0.Boolean_0 = value;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600030F RID: 783 RVA: 0x00005192 File Offset: 0x00003392
	public GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000310 RID: 784 RVA: 0x0000519A File Offset: 0x0000339A
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000311 RID: 785 RVA: 0x000051A2 File Offset: 0x000033A2
	// (set) Token: 0x06000312 RID: 786 RVA: 0x000271E0 File Offset: 0x000253E0
	public string String_0
	{
		get
		{
			return this.string_2;
		}
		set
		{
			string text;
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.string_2 = value;
				}
			}
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000313 RID: 787 RVA: 0x000051AA File Offset: 0x000033AA
	// (set) Token: 0x06000314 RID: 788 RVA: 0x00027250 File Offset: 0x00025450
	public bool Boolean_4
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			string text;
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.bool_2 = value;
				}
			}
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000315 RID: 789 RVA: 0x000051B2 File Offset: 0x000033B2
	public GClass26 GClass26_0
	{
		get
		{
			if (!this.bool_3)
			{
				throw new InvalidOperationException("This instance does not provide secure connections.");
			}
			return this.method_5();
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000316 RID: 790 RVA: 0x000051CD File Offset: 0x000033CD
	// (set) Token: 0x06000317 RID: 791 RVA: 0x000272C0 File Offset: 0x000254C0
	public Func<IIdentity, GClass25> Func_0
	{
		get
		{
			return this.func_0;
		}
		set
		{
			string text;
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.func_0 = value;
				}
			}
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000318 RID: 792 RVA: 0x000051D5 File Offset: 0x000033D5
	// (set) Token: 0x06000319 RID: 793 RVA: 0x000051E2 File Offset: 0x000033E2
	public TimeSpan TimeSpan_0
	{
		get
		{
			return this.gclass12_0.TimeSpan_0;
		}
		set
		{
			this.gclass12_0.TimeSpan_0 = value;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x0600031A RID: 794 RVA: 0x000051F0 File Offset: 0x000033F0
	public GClass12 GClass12_0
	{
		get
		{
			return this.gclass12_0;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00027330 File Offset: 0x00025530
	private void method_0()
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				return;
			}
			this.enum4_0 = Enum4.ShuttingDown;
		}
		try
		{
			try
			{
				this.tcpListener_0.Stop();
			}
			finally
			{
				this.gclass12_0.method_9(1006, string.Empty);
			}
		}
		catch
		{
		}
		this.enum4_0 = Enum4.Stop;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x000051F8 File Offset: 0x000033F8
	private bool method_1(Class81 class81_0)
	{
		return this.authenticationSchemes_0 == WebSocketSharp.Net.AuthenticationSchemes.Anonymous || (this.authenticationSchemes_0 != WebSocketSharp.Net.AuthenticationSchemes.None && class81_0.method_1(this.authenticationSchemes_0, this.string_3, this.func_0));
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000522B File Offset: 0x0000342B
	private bool method_2(out string string_4)
	{
		string_4 = null;
		if (this.enum4_0 == Enum4.Start)
		{
			string_4 = "The server has already started.";
			return false;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			string_4 = "The server is shutting down.";
			return false;
		}
		return true;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00005259 File Offset: 0x00003459
	private bool method_3(string string_4)
	{
		return !this.bool_1 || Uri.CheckHostName(string_4) != UriHostNameType.Dns || string_4 == this.string_1;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000527A File Offset: 0x0000347A
	private static bool smethod_0(GClass26 gclass26_2, out string string_4)
	{
		string_4 = null;
		if (gclass26_2.X509Certificate2_0 == null)
		{
			string_4 = "There is no server certificate for secure connection.";
			return false;
		}
		return true;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x000273CC File Offset: 0x000255CC
	private string method_4()
	{
		string text = this.string_2;
		if (text != null && text.Length > 0)
		{
			return text;
		}
		return GClass10.string_0;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00005291 File Offset: 0x00003491
	private GClass26 method_5()
	{
		if (this.gclass26_0 == null)
		{
			this.gclass26_0 = new GClass26();
		}
		return this.gclass26_0;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x000273F4 File Offset: 0x000255F4
	private void method_6(string string_4, IPAddress ipaddress_1, int int_1, bool bool_4)
	{
		this.string_1 = string_4;
		this.ipaddress_0 = ipaddress_1;
		this.int_0 = int_1;
		this.bool_3 = bool_4;
		this.authenticationSchemes_0 = WebSocketSharp.Net.AuthenticationSchemes.Anonymous;
		this.bool_1 = Uri.CheckHostName(string_4) == UriHostNameType.Dns;
		this.tcpListener_0 = new TcpListener(ipaddress_1, int_1);
		this.gclass6_0 = new GClass6();
		this.gclass12_0 = new GClass12(this.gclass6_0);
		this.object_0 = new object();
	}

	// Token: 0x06000323 RID: 803 RVA: 0x0002746C File Offset: 0x0002566C
	private void method_7(Class81 class81_0)
	{
		if (!this.method_1(class81_0))
		{
			class81_0.method_3(GEnum5.Forbidden);
			return;
		}
		Uri uri = class81_0.P_m_6DBB1F3B;
		if (uri == null)
		{
			class81_0.method_3(GEnum5.BadRequest);
			return;
		}
		if (!this.bool_0)
		{
			if (uri.Port != this.int_0)
			{
				class81_0.method_3(GEnum5.BadRequest);
				return;
			}
			if (!this.method_3(uri.DnsSafeHost))
			{
				class81_0.method_3(GEnum5.NotFound);
				return;
			}
		}
		GClass11 gclass;
		if (!this.gclass12_0.method_7(uri.AbsolutePath, out gclass))
		{
			class81_0.method_3(GEnum5.NotImplemented);
			return;
		}
		gclass.method_1(class81_0);
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00027510 File Offset: 0x00025710
	private void method_8()
	{
		for (;;)
		{
			GClass10.Class41 @class = new GClass10.Class41();
			@class.gclass10_0 = this;
			@class.tcpClient_0 = null;
			try
			{
				@class.tcpClient_0 = this.tcpListener_0.AcceptTcpClient();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
				continue;
			}
			catch (SocketException ex)
			{
				if (this.enum4_0 == Enum4.ShuttingDown)
				{
					this.gclass6_0.method_4("The underlying listener is stopped.");
				}
				else
				{
					this.gclass6_0.method_3(ex.Message);
					this.gclass6_0.method_1(ex.ToString());
				}
			}
			catch (Exception ex2)
			{
				this.gclass6_0.method_3(ex2.Message);
				this.gclass6_0.method_1(ex2.ToString());
				if (@class.tcpClient_0 != null)
				{
					@class.tcpClient_0.Close();
				}
			}
			break;
		}
		if (this.enum4_0 != Enum4.ShuttingDown)
		{
			this.method_0();
		}
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00027600 File Offset: 0x00025800
	private void method_9(GClass26 gclass26_2)
	{
		if (this.enum4_0 == Enum4.Start)
		{
			this.gclass6_0.method_4("The server has already started.");
			return;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			this.gclass6_0.method_6("The server is shutting down.");
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.enum4_0 == Enum4.Start)
			{
				this.gclass6_0.method_4("The server has already started.");
			}
			else if (this.enum4_0 == Enum4.ShuttingDown)
			{
				this.gclass6_0.method_6("The server is shutting down.");
			}
			else
			{
				this.gclass26_1 = gclass26_2;
				this.string_3 = this.method_4();
				this.gclass12_0.method_8();
				try
				{
					this.method_10();
				}
				catch
				{
					this.gclass12_0.method_9(1011, string.Empty);
					throw;
				}
				this.enum4_0 = Enum4.Start;
			}
		}
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00027700 File Offset: 0x00025900
	private void method_10()
	{
		if (this.bool_2)
		{
			this.tcpListener_0.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
		}
		try
		{
			this.tcpListener_0.Start();
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException("The underlying listener has failed to start.", ex);
		}
		this.thread_0 = new Thread(new ThreadStart(this.method_8));
		this.thread_0.IsBackground = true;
		this.thread_0.Start();
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00027788 File Offset: 0x00025988
	private void method_11(ushort ushort_0, string string_4)
	{
		if (this.enum4_0 == Enum4.Ready)
		{
			this.gclass6_0.method_4("The server is not started.");
			return;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			this.gclass6_0.method_4("The server is shutting down.");
			return;
		}
		if (this.enum4_0 == Enum4.Stop)
		{
			this.gclass6_0.method_4("The server has already stopped.");
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.enum4_0 == Enum4.ShuttingDown)
			{
				this.gclass6_0.method_4("The server is shutting down.");
				return;
			}
			if (this.enum4_0 == Enum4.Stop)
			{
				this.gclass6_0.method_4("The server has already stopped.");
				return;
			}
			this.enum4_0 = Enum4.ShuttingDown;
		}
		try
		{
			bool flag2 = false;
			try
			{
				this.method_12(5000);
			}
			catch
			{
				flag2 = true;
				throw;
			}
			finally
			{
				try
				{
					this.gclass12_0.method_9(ushort_0, string_4);
				}
				catch
				{
					if (!flag2)
					{
						throw;
					}
				}
			}
		}
		finally
		{
			this.enum4_0 = Enum4.Stop;
		}
	}

	// Token: 0x06000328 RID: 808 RVA: 0x000278C0 File Offset: 0x00025AC0
	private void method_12(int int_1)
	{
		try
		{
			this.tcpListener_0.Stop();
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException("The underlying listener has failed to stop.", ex);
		}
		this.thread_0.Join(int_1);
	}

	// Token: 0x06000329 RID: 809 RVA: 0x000052AC File Offset: 0x000034AC
	private static bool smethod_1(string string_4, out Uri uri_0, out string string_5)
	{
		if (!string_4.smethod_69(out uri_0, out string_5))
		{
			return false;
		}
		if (uri_0.PathAndQuery != "/")
		{
			uri_0 = null;
			string_5 = "It includes either or both path and query components.";
			return false;
		}
		return true;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00027904 File Offset: 0x00025B04
	[Obsolete("This method will be removed. Use added one instead.")]
	public void method_13<T>(string string_4, Func<T> func_1) where T : GClass9
	{
		if (string_4 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (func_1 == null)
		{
			throw new ArgumentNullException("creator");
		}
		if (string_4.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_4[0] != '/')
		{
			throw new ArgumentException("Not an absolute path.", "path");
		}
		if (string_4.IndexOfAny(new char[] { '?', '#' }) > -1)
		{
			throw new ArgumentException("It includes either or both query and fragment components.", "path");
		}
		this.gclass12_0.method_6<T>(string_4, func_1);
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000052DA File Offset: 0x000034DA
	public void method_14<T>(string string_4) where T : GClass9, new()
	{
		this.gclass12_0.method_10<T>(string_4, null);
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000052E9 File Offset: 0x000034E9
	public void method_15<T>(string string_4, Action<T> action_0) where T : GClass9, new()
	{
		this.gclass12_0.method_10<T>(string_4, action_0);
	}

	// Token: 0x0600032D RID: 813 RVA: 0x000052F8 File Offset: 0x000034F8
	public bool method_16(string string_4)
	{
		return this.gclass12_0.method_19(string_4);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00027998 File Offset: 0x00025B98
	public void method_17()
	{
		GClass26 gclass = null;
		if (this.bool_3)
		{
			gclass = new GClass26(this.method_5());
			string text;
			if (!GClass10.smethod_0(gclass, out text))
			{
				throw new InvalidOperationException(text);
			}
		}
		this.method_9(gclass);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00005306 File Offset: 0x00003506
	public void method_18()
	{
		this.method_11(1001, string.Empty);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000279D4 File Offset: 0x00025BD4
	[Obsolete("This method will be removed.")]
	public void method_19(ushort ushort_0, string string_4)
	{
		if (!ushort_0.smethod_83())
		{
			string text = "Less than 1000 or greater than 4999.";
			throw new ArgumentOutOfRangeException("code", text);
		}
		if (ushort_0 == 1010)
		{
			throw new ArgumentException("1010 cannot be used.", "code");
		}
		if (!string_4.smethod_87())
		{
			if (ushort_0 == 1005)
			{
				throw new ArgumentException("1005 cannot be used.", "code");
			}
			byte[] array;
			if (!string_4.smethod_71(out array))
			{
				throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
			}
			if (array.Length > 123)
			{
				string text2 = "Its size is greater than 123 bytes.";
				throw new ArgumentOutOfRangeException("reason", text2);
			}
		}
		this.method_11(ushort_0, string_4);
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00027A70 File Offset: 0x00025C70
	[Obsolete("This method will be removed.")]
	public void method_20(GEnum2 genum2_0, string string_4)
	{
		if (genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		if (!string_4.smethod_87())
		{
			if (genum2_0 == GEnum2.NoStatus)
			{
				throw new ArgumentException("NoStatus cannot be used.", "code");
			}
			byte[] array;
			if (!string_4.smethod_71(out array))
			{
				throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
			}
			if (array.Length > 123)
			{
				string text = "Its size is greater than 123 bytes.";
				throw new ArgumentOutOfRangeException("reason", text);
			}
		}
		this.method_11((ushort)genum2_0, string_4);
	}

	// Token: 0x0400018B RID: 395
	private IPAddress ipaddress_0;

	// Token: 0x0400018C RID: 396
	private bool bool_0;

	// Token: 0x0400018D RID: 397
	private WebSocketSharp.Net.AuthenticationSchemes authenticationSchemes_0;

	// Token: 0x0400018E RID: 398
	private static readonly string string_0 = "SECRET AREA";

	// Token: 0x0400018F RID: 399
	private bool bool_1;

	// Token: 0x04000190 RID: 400
	private string string_1;

	// Token: 0x04000191 RID: 401
	private TcpListener tcpListener_0;

	// Token: 0x04000192 RID: 402
	private GClass6 gclass6_0;

	// Token: 0x04000193 RID: 403
	private int int_0;

	// Token: 0x04000194 RID: 404
	private string string_2;

	// Token: 0x04000195 RID: 405
	private string string_3;

	// Token: 0x04000196 RID: 406
	private Thread thread_0;

	// Token: 0x04000197 RID: 407
	private bool bool_2;

	// Token: 0x04000198 RID: 408
	private bool bool_3;

	// Token: 0x04000199 RID: 409
	private GClass12 gclass12_0;

	// Token: 0x0400019A RID: 410
	private GClass26 gclass26_0;

	// Token: 0x0400019B RID: 411
	private GClass26 gclass26_1;

	// Token: 0x0400019C RID: 412
	private volatile Enum4 enum4_0;

	// Token: 0x0400019D RID: 413
	private object object_0;

	// Token: 0x0400019E RID: 414
	private Func<IIdentity, GClass25> func_0;

	// Token: 0x0200004C RID: 76
	[CompilerGenerated]
	private sealed class Class41
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00027AF0 File Offset: 0x00025CF0
		internal void method_0(object object_0)
		{
			try
			{
				Class81 @class = new Class81(this.tcpClient_0, null, this.gclass10_0.bool_3, this.gclass10_0.gclass26_1, this.gclass10_0.gclass6_0);
				this.gclass10_0.method_7(@class);
			}
			catch (Exception ex)
			{
				this.gclass10_0.gclass6_0.method_2(ex.Message);
				this.gclass10_0.gclass6_0.method_1(ex.ToString());
				this.tcpClient_0.Close();
			}
		}

		// Token: 0x0400019F RID: 415
		public TcpClient tcpClient_0;

		// Token: 0x040001A0 RID: 416
		public GClass10 gclass10_0;
	}
}
