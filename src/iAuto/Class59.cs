using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// Token: 0x02000067 RID: 103
internal sealed class Class59
{
	// Token: 0x06000462 RID: 1122 RVA: 0x0002BE6C File Offset: 0x0002A06C
	internal Class59(IPEndPoint ipendPoint_1, bool bool_1, string string_1, GClass26 gclass26_1, bool bool_2)
	{
		if (bool_1)
		{
			X509Certificate2 x509Certificate = Class59.smethod_2(ipendPoint_1.Port, string_1, gclass26_1.X509Certificate2_0);
			if (x509Certificate == null)
			{
				throw new ArgumentException("No server certificate could be found.");
			}
			this.bool_0 = true;
			this.gclass26_0 = new GClass26(gclass26_1);
			this.gclass26_0.X509Certificate2_0 = x509Certificate;
		}
		this.ipendPoint_0 = ipendPoint_1;
		this.dictionary_0 = new Dictionary<Class67, GClass19>();
		this.dictionary_1 = new Dictionary<Class62, Class62>();
		this.object_0 = ((ICollection)this.dictionary_1).SyncRoot;
		this.socket_0 = new Socket(ipendPoint_1.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		if (bool_2)
		{
			this.socket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
		}
		this.socket_0.Bind(ipendPoint_1);
		this.socket_0.Listen(500);
		Socket socket = this.socket_0;
		AsyncCallback asyncCallback;
		if ((asyncCallback = Class59.Class60.asyncCallback_0) == null)
		{
			asyncCallback = (Class59.Class60.asyncCallback_0 = new AsyncCallback(Class59.smethod_3));
		}
		socket.BeginAccept(asyncCallback, this);
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000463 RID: 1123 RVA: 0x00005F8E File Offset: 0x0000418E
	public IPAddress IPAddress_0
	{
		get
		{
			return this.ipendPoint_0.Address;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x00005F9B File Offset: 0x0000419B
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x00005FA3 File Offset: 0x000041A3
	public int Int32_0
	{
		get
		{
			return this.ipendPoint_0.Port;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000466 RID: 1126 RVA: 0x00005FB0 File Offset: 0x000041B0
	public GClass26 GClass26_0
	{
		get
		{
			return this.gclass26_0;
		}
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0002BF64 File Offset: 0x0002A164
	private static void smethod_0(List<Class67> list_2, Class67 class67_0)
	{
		string string_ = class67_0.String_2;
		using (List<Class67>.Enumerator enumerator = list_2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.String_2 == string_)
				{
					throw new GException2(87, "The prefix is already in use.");
				}
			}
		}
		list_2.Add(class67_0);
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0002BFD8 File Offset: 0x0002A1D8
	private static RSACryptoServiceProvider smethod_1(string string_1)
	{
		byte[] array = null;
		using (FileStream fileStream = File.Open(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
		}
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		rsacryptoServiceProvider.ImportCspBlob(array);
		return rsacryptoServiceProvider;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x0002C034 File Offset: 0x0002A234
	private static X509Certificate2 smethod_2(int int_0, string string_1, X509Certificate2 x509Certificate2_0)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			string_1 = Class59.string_0;
		}
		try
		{
			string text = Path.Combine(string_1, string.Format("{0}.cer", int_0));
			string text2 = Path.Combine(string_1, string.Format("{0}.key", int_0));
			if (File.Exists(text) && File.Exists(text2))
			{
				return new X509Certificate2(text)
				{
					PrivateKey = Class59.smethod_1(text2)
				};
			}
		}
		catch
		{
		}
		return x509Certificate2_0;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
	private void method_0()
	{
		if (this.dictionary_0.Count > 0)
		{
			return;
		}
		List<Class67> list = this.list_1;
		if (list != null && list.Count > 0)
		{
			return;
		}
		list = this.list_0;
		if (list != null && list.Count > 0)
		{
			return;
		}
		Class61.smethod_3(this.ipendPoint_0);
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x0002C110 File Offset: 0x0002A310
	private static void smethod_3(IAsyncResult iasyncResult_0)
	{
		Class59 @class = (Class59)iasyncResult_0.AsyncState;
		Socket socket = null;
		try
		{
			socket = @class.socket_0.EndAccept(iasyncResult_0);
		}
		catch (SocketException)
		{
		}
		catch (ObjectDisposedException)
		{
			return;
		}
		try
		{
			Socket socket2 = @class.socket_0;
			AsyncCallback asyncCallback;
			if ((asyncCallback = Class59.Class60.asyncCallback_0) == null)
			{
				asyncCallback = (Class59.Class60.asyncCallback_0 = new AsyncCallback(Class59.smethod_3));
			}
			socket2.BeginAccept(asyncCallback, @class);
		}
		catch
		{
			if (socket != null)
			{
				socket.Close();
			}
			return;
		}
		if (socket == null)
		{
			return;
		}
		Class59.smethod_4(socket, @class);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x0002C1AC File Offset: 0x0002A3AC
	private static void smethod_4(Socket socket_1, Class59 class59_0)
	{
		Class62 @class = null;
		try
		{
			@class = new Class62(socket_1, class59_0);
			object obj = class59_0.object_0;
			lock (obj)
			{
				class59_0.dictionary_1[@class] = @class;
			}
			@class.method_11();
		}
		catch
		{
			if (@class != null)
			{
				@class.method_10(true);
			}
			else
			{
				socket_1.Close();
			}
		}
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0002C228 File Offset: 0x0002A428
	private static bool smethod_5(List<Class67> list_2, Class67 class67_0)
	{
		string string_ = class67_0.String_2;
		int count = list_2.Count;
		for (int i = 0; i < count; i++)
		{
			if (list_2[i].String_2 == string_)
			{
				list_2.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0002C270 File Offset: 0x0002A470
	private static GClass19 smethod_6(string string_1, List<Class67> list_2)
	{
		if (list_2 == null)
		{
			return null;
		}
		GClass19 gclass = null;
		int num = -1;
		foreach (Class67 @class in list_2)
		{
			string string_2 = @class.String_2;
			int length = string_2.Length;
			if (length >= num && string_1.StartsWith(string_2))
			{
				num = length;
				gclass = @class.GClass19_0;
			}
		}
		return gclass;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0002C2EC File Offset: 0x0002A4EC
	internal static bool smethod_7(int int_0, string string_1)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			string_1 = Class59.string_0;
		}
		string text = Path.Combine(string_1, string.Format("{0}.cer", int_0));
		string text2 = Path.Combine(string_1, string.Format("{0}.key", int_0));
		return File.Exists(text) && File.Exists(text2);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x0002C348 File Offset: 0x0002A548
	internal void method_1(Class62 class62_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.dictionary_1.Remove(class62_0);
		}
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0002C390 File Offset: 0x0002A590
	internal bool method_2(Uri uri_0, out GClass19 gclass19_0)
	{
		gclass19_0 = null;
		if (uri_0 == null)
		{
			return false;
		}
		string host = uri_0.Host;
		bool flag = Uri.CheckHostName(host) == UriHostNameType.Dns;
		string text = uri_0.Port.ToString();
		string text2 = Class71.smethod_33(uri_0.AbsolutePath);
		string text3 = ((text2[text2.Length - 1] != '/') ? (text2 + "/") : text2);
		if (host != null && host.Length > 0)
		{
			int num = -1;
			foreach (Class67 @class in this.dictionary_0.Keys)
			{
				if (flag)
				{
					string text4 = @class.String_0;
					if (Uri.CheckHostName(text4) == UriHostNameType.Dns && text4 != host)
					{
						continue;
					}
				}
				if (!(@class.String_3 != text))
				{
					string string_ = @class.String_2;
					int length = string_.Length;
					if (length >= num && (text2.StartsWith(string_) || text3.StartsWith(string_)))
					{
						num = length;
						gclass19_0 = this.dictionary_0[@class];
					}
				}
			}
			if (num != -1)
			{
				return true;
			}
		}
		List<Class67> list = this.list_1;
		gclass19_0 = Class59.smethod_6(text2, list);
		if (gclass19_0 == null && text3 != text2)
		{
			gclass19_0 = Class59.smethod_6(text3, list);
		}
		if (gclass19_0 != null)
		{
			return true;
		}
		list = this.list_0;
		gclass19_0 = Class59.smethod_6(text2, list);
		if (gclass19_0 == null && text3 != text2)
		{
			gclass19_0 = Class59.smethod_6(text3, list);
		}
		return gclass19_0 != null;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0002C530 File Offset: 0x0002A730
	public void method_3(Class67 class67_0, GClass19 gclass19_0)
	{
		if (class67_0.String_0 == "*")
		{
			List<Class67> list;
			List<Class67> list2;
			do
			{
				list = this.list_1;
				list2 = ((list != null) ? new List<Class67>(list) : new List<Class67>());
				class67_0.GClass19_0 = gclass19_0;
				Class59.smethod_0(list2, class67_0);
			}
			while (Interlocked.CompareExchange<List<Class67>>(ref this.list_1, list2, list) != list);
			return;
		}
		if (class67_0.String_0 == "+")
		{
			List<Class67> list;
			List<Class67> list2;
			do
			{
				list = this.list_0;
				list2 = ((list != null) ? new List<Class67>(list) : new List<Class67>());
				class67_0.GClass19_0 = gclass19_0;
				Class59.smethod_0(list2, class67_0);
			}
			while (Interlocked.CompareExchange<List<Class67>>(ref this.list_0, list2, list) != list);
			return;
		}
		Dictionary<Class67, GClass19> dictionary;
		Dictionary<Class67, GClass19> dictionary2;
		do
		{
			dictionary = this.dictionary_0;
			if (dictionary.ContainsKey(class67_0))
			{
				goto Block_8;
			}
			dictionary2 = new Dictionary<Class67, GClass19>(dictionary);
			dictionary2[class67_0] = gclass19_0;
		}
		while (Interlocked.CompareExchange<Dictionary<Class67, GClass19>>(ref this.dictionary_0, dictionary2, dictionary) != dictionary);
		return;
		Block_8:
		if (dictionary[class67_0] != gclass19_0)
		{
			throw new GException2(87, string.Format("There's another listener for {0}.", class67_0));
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0002C62C File Offset: 0x0002A82C
	public void method_4()
	{
		this.socket_0.Close();
		Class62[] array = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.dictionary_1.Count == 0)
			{
				return;
			}
			Dictionary<Class62, Class62>.KeyCollection keys = this.dictionary_1.Keys;
			array = new Class62[keys.Count];
			keys.CopyTo(array, 0);
			this.dictionary_1.Clear();
		}
		for (int i = array.Length - 1; i >= 0; i--)
		{
			array[i].method_10(true);
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
	public void method_5(Class67 class67_0, GClass19 gclass19_0)
	{
		if (class67_0.String_0 == "*")
		{
			List<Class67> list;
			List<Class67> list2;
			do
			{
				list = this.list_1;
				if (list == null)
				{
					break;
				}
				list2 = new List<Class67>(list);
				if (!Class59.smethod_5(list2, class67_0))
				{
					break;
				}
			}
			while (Interlocked.CompareExchange<List<Class67>>(ref this.list_1, list2, list) != list);
			this.method_0();
			return;
		}
		if (class67_0.String_0 == "+")
		{
			List<Class67> list;
			List<Class67> list2;
			do
			{
				list = this.list_0;
				if (list == null)
				{
					break;
				}
				list2 = new List<Class67>(list);
				if (!Class59.smethod_5(list2, class67_0))
				{
					break;
				}
			}
			while (Interlocked.CompareExchange<List<Class67>>(ref this.list_0, list2, list) != list);
			this.method_0();
			return;
		}
		Dictionary<Class67, GClass19> dictionary;
		Dictionary<Class67, GClass19> dictionary2;
		do
		{
			dictionary = this.dictionary_0;
			if (!dictionary.ContainsKey(class67_0))
			{
				break;
			}
			dictionary2 = new Dictionary<Class67, GClass19>(dictionary);
			dictionary2.Remove(class67_0);
		}
		while (Interlocked.CompareExchange<Dictionary<Class67, GClass19>>(ref this.dictionary_0, dictionary2, dictionary) != dictionary);
		this.method_0();
	}

	// Token: 0x04000209 RID: 521
	private List<Class67> list_0;

	// Token: 0x0400020A RID: 522
	private static readonly string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	// Token: 0x0400020B RID: 523
	private IPEndPoint ipendPoint_0;

	// Token: 0x0400020C RID: 524
	private Dictionary<Class67, GClass19> dictionary_0;

	// Token: 0x0400020D RID: 525
	private bool bool_0;

	// Token: 0x0400020E RID: 526
	private Socket socket_0;

	// Token: 0x0400020F RID: 527
	private GClass26 gclass26_0;

	// Token: 0x04000210 RID: 528
	private List<Class67> list_1;

	// Token: 0x04000211 RID: 529
	private Dictionary<Class62, Class62> dictionary_1;

	// Token: 0x04000212 RID: 530
	private object object_0;

	// Token: 0x02000068 RID: 104
	[CompilerGenerated]
	private static class Class60
	{
		// Token: 0x04000213 RID: 531
		public static AsyncCallback asyncCallback_0;
	}
}
