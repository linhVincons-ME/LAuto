using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using WebSocketSharp;

// Token: 0x02000054 RID: 84
public class GClass13
{
	// Token: 0x0600036F RID: 879 RVA: 0x00028A6C File Offset: 0x00026C6C
	internal GClass13(GClass6 gclass6_1)
	{
		this.gclass6_0 = gclass6_1;
		this.bool_0 = true;
		this.object_0 = new object();
		this.dictionary_0 = new Dictionary<string, GInterface0>();
		this.enum4_0 = Enum4.Ready;
		this.object_1 = ((ICollection)this.dictionary_0).SyncRoot;
		this.timeSpan_0 = TimeSpan.FromSeconds(1.0);
		this.method_6(60000.0);
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000370 RID: 880 RVA: 0x0000552A File Offset: 0x0000372A
	internal Enum4 Enum4_0
	{
		get
		{
			return this.enum4_0;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000371 RID: 881 RVA: 0x00005534 File Offset: 0x00003734
	public IEnumerable<string> IEnumerable_0
	{
		get
		{
			GClass13.Class49 @class = new GClass13.Class49(-2);
			@class.gclass13_0 = this;
			return @class;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000372 RID: 882 RVA: 0x00028AE4 File Offset: 0x00026CE4
	public int Int32_0
	{
		get
		{
			object obj = this.object_1;
			int count;
			lock (obj)
			{
				count = this.dictionary_0.Count;
			}
			return count;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00028B2C File Offset: 0x00026D2C
	public IEnumerable<string> IEnumerable_1
	{
		get
		{
			if (this.enum4_0 != Enum4.Start)
			{
				return Enumerable.Empty<string>();
			}
			object obj = this.object_1;
			IEnumerable<string> enumerable;
			lock (obj)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					enumerable = Enumerable.Empty<string>();
				}
				else
				{
					enumerable = this.dictionary_0.Keys.smethod_61<string>();
				}
			}
			return enumerable;
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000374 RID: 884 RVA: 0x00005544 File Offset: 0x00003744
	public IEnumerable<string> IEnumerable_2
	{
		get
		{
			GClass13.Class50 @class = new GClass13.Class50(-2);
			@class.gclass13_0 = this;
			return @class;
		}
	}

	// Token: 0x170000D0 RID: 208
	public GInterface0 this[string string_0]
	{
		get
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("id");
			}
			if (string_0.Length == 0)
			{
				throw new ArgumentException("An empty string.", "id");
			}
			GInterface0 ginterface;
			this.method_8(string_0, out ginterface);
			return ginterface;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000376 RID: 886 RVA: 0x00005554 File Offset: 0x00003754
	// (set) Token: 0x06000377 RID: 887 RVA: 0x00028BDC File Offset: 0x00026DDC
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			string text;
			if (!this.method_5(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_1;
			lock (obj)
			{
				if (!this.method_5(out text))
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

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000378 RID: 888 RVA: 0x00028C50 File Offset: 0x00026E50
	public IEnumerable<GInterface0> IEnumerable_3
	{
		get
		{
			if (this.enum4_0 != Enum4.Start)
			{
				return Enumerable.Empty<GInterface0>();
			}
			object obj = this.object_1;
			IEnumerable<GInterface0> enumerable;
			lock (obj)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					enumerable = Enumerable.Empty<GInterface0>();
				}
				else
				{
					enumerable = this.dictionary_0.Values.smethod_61<GInterface0>();
				}
			}
			return enumerable;
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000379 RID: 889 RVA: 0x0000555E File Offset: 0x0000375E
	// (set) Token: 0x0600037A RID: 890 RVA: 0x00028CC0 File Offset: 0x00026EC0
	public TimeSpan TimeSpan_0
	{
		get
		{
			return this.timeSpan_0;
		}
		set
		{
			if (value <= TimeSpan.Zero)
			{
				throw new ArgumentOutOfRangeException("value", "Zero or less.");
			}
			string text;
			if (!this.method_5(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_1;
			lock (obj)
			{
				if (!this.method_5(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.timeSpan_0 = value;
				}
			}
		}
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00028D50 File Offset: 0x00026F50
	private void method_0(Enum2 enum2_0, byte[] byte_0, Action action_0)
	{
		Dictionary<CompressionMethod, byte[]> dictionary = new Dictionary<CompressionMethod, byte[]>();
		try
		{
			foreach (GInterface0 ginterface in this.IEnumerable_3)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					this.gclass6_0.method_2("The service is shutting down.");
					break;
				}
				ginterface.GClass28_0.P_m_3EA51AA9.method_68(enum2_0, byte_0, dictionary);
			}
			if (action_0 != null)
			{
				action_0();
			}
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
		}
		finally
		{
			dictionary.Clear();
		}
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00028E20 File Offset: 0x00027020
	private void method_1(Enum2 enum2_0, Stream stream_0, Action action_0)
	{
		Dictionary<CompressionMethod, Stream> dictionary = new Dictionary<CompressionMethod, Stream>();
		try
		{
			foreach (GInterface0 ginterface in this.IEnumerable_3)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					this.gclass6_0.method_2("The service is shutting down.");
					break;
				}
				ginterface.GClass28_0.P_m_3EA51AA9.method_69(enum2_0, stream_0, dictionary);
			}
			if (action_0 != null)
			{
				action_0();
			}
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
		}
		finally
		{
			foreach (Stream stream in dictionary.Values)
			{
				stream.Dispose();
			}
			dictionary.Clear();
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00005566 File Offset: 0x00003766
	private void method_2(Enum2 enum2_0, byte[] byte_0, Action action_0)
	{
		GClass13.Class47 @class = new GClass13.Class47();
		@class.gclass13_0 = this;
		@class.enum2_0 = enum2_0;
		@class.byte_0 = byte_0;
		@class.action_0 = action_0;
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0000559A File Offset: 0x0000379A
	private void method_3(Enum2 enum2_0, Stream stream_0, Action action_0)
	{
		GClass13.Class48 @class = new GClass13.Class48();
		@class.gclass13_0 = this;
		@class.enum2_0 = enum2_0;
		@class.stream_0 = stream_0;
		@class.action_0 = action_0;
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00028F30 File Offset: 0x00027130
	private Dictionary<string, bool> method_4(byte[] byte_0)
	{
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		foreach (GInterface0 ginterface in this.IEnumerable_3)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				this.gclass6_0.method_2("The service is shutting down.");
				break;
			}
			bool flag = ginterface.GClass28_0.P_m_3EA51AA9.method_67(byte_0, this.timeSpan_0);
			dictionary.Add(ginterface.String_0, flag);
		}
		return dictionary;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000055CE File Offset: 0x000037CE
	private bool method_5(out string string_0)
	{
		string_0 = null;
		if (this.enum4_0 == Enum4.Start)
		{
			string_0 = "The service has already started.";
			return false;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			string_0 = "The service is shutting down.";
			return false;
		}
		return true;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00028FC4 File Offset: 0x000271C4
	private static string smethod_0()
	{
		return Guid.NewGuid().ToString("N");
	}

	// Token: 0x06000382 RID: 898 RVA: 0x000055FC File Offset: 0x000037FC
	private void method_6(double double_0)
	{
		this.timer_0 = new global::System.Timers.Timer(double_0);
		this.timer_0.Elapsed += this.timer_0_Elapsed;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00028FE4 File Offset: 0x000271E4
	private void method_7(Class19 class19_0, bool bool_2)
	{
		byte[] array = (bool_2 ? Class31.smethod_12(class19_0, false).method_3() : null);
		object obj = this.object_1;
		lock (obj)
		{
			this.enum4_0 = Enum4.ShuttingDown;
			this.timer_0.Enabled = false;
			foreach (GInterface0 ginterface in this.dictionary_0.Values.smethod_61<GInterface0>())
			{
				ginterface.GClass28_0.P_m_3EA51AA9.method_65(class19_0, array);
			}
			this.enum4_0 = Enum4.Stop;
		}
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000290A8 File Offset: 0x000272A8
	private bool method_8(string string_0, out GInterface0 ginterface0_0)
	{
		ginterface0_0 = null;
		if (this.enum4_0 != Enum4.Start)
		{
			return false;
		}
		object obj = this.object_1;
		bool flag2;
		lock (obj)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				flag2 = false;
			}
			else
			{
				flag2 = this.dictionary_0.TryGetValue(string_0, out ginterface0_0);
			}
		}
		return flag2;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00029110 File Offset: 0x00027310
	internal string method_9(GInterface0 ginterface0_0)
	{
		object obj = this.object_1;
		string text;
		lock (obj)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				text = null;
			}
			else
			{
				string text2 = GClass13.smethod_0();
				this.dictionary_0.Add(text2, ginterface0_0);
				text = text2;
			}
		}
		return text;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00029170 File Offset: 0x00027370
	internal void method_10(Enum2 enum2_0, byte[] byte_0, Dictionary<CompressionMethod, byte[]> dictionary_1)
	{
		foreach (GInterface0 ginterface in this.IEnumerable_3)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				this.gclass6_0.method_2("The service is shutting down.");
				break;
			}
			ginterface.GClass28_0.P_m_3EA51AA9.method_68(enum2_0, byte_0, dictionary_1);
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x000291EC File Offset: 0x000273EC
	internal void method_11(Enum2 enum2_0, Stream stream_0, Dictionary<CompressionMethod, Stream> dictionary_1)
	{
		foreach (GInterface0 ginterface in this.IEnumerable_3)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				this.gclass6_0.method_2("The service is shutting down.");
				break;
			}
			ginterface.GClass28_0.P_m_3EA51AA9.method_69(enum2_0, stream_0, dictionary_1);
		}
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00029268 File Offset: 0x00027468
	internal Dictionary<string, bool> method_12(byte[] byte_0, TimeSpan timeSpan_1)
	{
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		foreach (GInterface0 ginterface in this.IEnumerable_3)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				this.gclass6_0.method_2("The service is shutting down.");
				break;
			}
			bool flag = ginterface.GClass28_0.P_m_3EA51AA9.method_67(byte_0, timeSpan_1);
			dictionary.Add(ginterface.String_0, flag);
		}
		return dictionary;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000292F8 File Offset: 0x000274F8
	internal bool method_13(string string_0)
	{
		object obj = this.object_1;
		bool flag2;
		lock (obj)
		{
			flag2 = this.dictionary_0.Remove(string_0);
		}
		return flag2;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00029340 File Offset: 0x00027540
	internal void method_14()
	{
		object obj = this.object_1;
		lock (obj)
		{
			this.timer_0.Enabled = this.bool_0;
			this.enum4_0 = Enum4.Start;
		}
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00005621 File Offset: 0x00003821
	internal void method_15(ushort ushort_0, string string_0)
	{
		if (ushort_0 == 1005)
		{
			this.method_7(Class19.class19_0, true);
			return;
		}
		this.method_7(new Class19(ushort_0, string_0), !ushort_0.smethod_44());
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00029398 File Offset: 0x00027598
	public void method_16(byte[] byte_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		if ((long)byte_0.Length <= (long)GClass7.int_2)
		{
			this.method_0(Enum2.Binary, byte_0, null);
			return;
		}
		this.method_1(Enum2.Binary, new MemoryStream(byte_0), null);
	}

	// Token: 0x0600038D RID: 909 RVA: 0x000293EC File Offset: 0x000275EC
	public void method_17(string string_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (string_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array;
		if (!string_0.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "data");
		}
		if ((long)array.Length <= (long)GClass7.int_2)
		{
			this.method_0(Enum2.Text, array, null);
			return;
		}
		this.method_1(Enum2.Text, new MemoryStream(array), null);
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0002945C File Offset: 0x0002765C
	public void method_18(Stream stream_0, int int_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream_0.CanRead)
		{
			throw new ArgumentException("It cannot be read.", "stream");
		}
		if (int_0 < 1)
		{
			throw new ArgumentException("Less than 1.", "length");
		}
		byte[] array = stream_0.smethod_51(int_0);
		int num = array.Length;
		if (num == 0)
		{
			throw new ArgumentException("No data could be read from it.", "stream");
		}
		if (num < int_0)
		{
			this.gclass6_0.method_6(string.Format("Only {0} byte(s) of data could be read from the stream.", num));
		}
		if (num <= GClass7.int_2)
		{
			this.method_0(Enum2.Binary, array, null);
			return;
		}
		this.method_1(Enum2.Binary, new MemoryStream(array), null);
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00029518 File Offset: 0x00027718
	public void method_19(byte[] byte_0, Action action_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		if ((long)byte_0.Length <= (long)GClass7.int_2)
		{
			this.method_2(Enum2.Binary, byte_0, action_0);
			return;
		}
		this.method_3(Enum2.Binary, new MemoryStream(byte_0), action_0);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0002956C File Offset: 0x0002776C
	public void method_20(string string_0, Action action_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (string_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array;
		if (!string_0.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "data");
		}
		if ((long)array.Length <= (long)GClass7.int_2)
		{
			this.method_2(Enum2.Text, array, action_0);
			return;
		}
		this.method_3(Enum2.Text, new MemoryStream(array), action_0);
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000295DC File Offset: 0x000277DC
	public void method_21(Stream stream_0, int int_0, Action action_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream_0.CanRead)
		{
			throw new ArgumentException("It cannot be read.", "stream");
		}
		if (int_0 < 1)
		{
			throw new ArgumentException("Less than 1.", "length");
		}
		byte[] array = stream_0.smethod_51(int_0);
		int num = array.Length;
		if (num == 0)
		{
			throw new ArgumentException("No data could be read from it.", "stream");
		}
		if (num < int_0)
		{
			this.gclass6_0.method_6(string.Format("Only {0} byte(s) of data could be read from the stream.", num));
		}
		if (num <= GClass7.int_2)
		{
			this.method_2(Enum2.Binary, array, action_0);
			return;
		}
		this.method_3(Enum2.Binary, new MemoryStream(array), action_0);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0000564E File Offset: 0x0000384E
	[Obsolete("This method will be removed.")]
	public Dictionary<string, bool> method_22()
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		return this.method_12(Class31.byte_3, this.timeSpan_0);
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00029698 File Offset: 0x00027898
	[Obsolete("This method will be removed.")]
	public Dictionary<string, bool> method_23(string string_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (string_0.smethod_87())
		{
			return this.method_12(Class31.byte_3, this.timeSpan_0);
		}
		byte[] array;
		if (!string_0.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "message");
		}
		if (array.Length > 125)
		{
			string text = "Its size is greater than 125 bytes.";
			throw new ArgumentOutOfRangeException("message", text);
		}
		Class31 @class = Class31.smethod_14(array, false);
		return this.method_12(@class.method_3(), this.timeSpan_0);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00029724 File Offset: 0x00027924
	public void method_24(string string_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_72();
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00029758 File Offset: 0x00027958
	public void method_25(string string_0, ushort ushort_0, string string_1)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_75(ushort_0, string_1);
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00029790 File Offset: 0x00027990
	public void method_26(string string_0, GEnum2 genum2_0, string string_1)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_76(genum2_0, string_1);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x000297C8 File Offset: 0x000279C8
	public bool method_27(string string_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		return ginterface.GClass28_0.P_m_3EA51AA9.method_84();
	}

	// Token: 0x06000398 RID: 920 RVA: 0x000297FC File Offset: 0x000279FC
	public bool method_28(string string_0, string string_1)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_1, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		return ginterface.GClass28_0.P_m_3EA51AA9.method_85(string_0);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00029830 File Offset: 0x00027A30
	public void method_29(byte[] byte_0, string string_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_86(byte_0);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00029864 File Offset: 0x00027A64
	public void method_30(string string_0, string string_1)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_1, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_88(string_0);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00029898 File Offset: 0x00027A98
	public void method_31(Stream stream_0, int int_0, string string_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_89(stream_0, int_0);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x000298D0 File Offset: 0x00027AD0
	public void method_32(byte[] byte_0, string string_0, Action<bool> action_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_90(byte_0, action_0);
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00029908 File Offset: 0x00027B08
	public void method_33(string string_0, string string_1, Action<bool> action_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_1, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_92(string_0, action_0);
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00029940 File Offset: 0x00027B40
	public void method_34(Stream stream_0, int int_0, string string_0, Action<bool> action_0)
	{
		GInterface0 ginterface;
		if (!this.method_36(string_0, out ginterface))
		{
			throw new InvalidOperationException("The session could not be found.");
		}
		ginterface.GClass28_0.P_m_3EA51AA9.method_93(stream_0, int_0, action_0);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00029978 File Offset: 0x00027B78
	public void method_35()
	{
		if (this.bool_1)
		{
			this.gclass6_0.method_4("The sweeping is already in progress.");
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_1)
			{
				this.gclass6_0.method_4("The sweeping is already in progress.");
				return;
			}
			this.bool_1 = true;
		}
		foreach (string text in this.IEnumerable_2)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				break;
			}
			obj = this.object_1;
			lock (obj)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					break;
				}
				GInterface0 ginterface;
				if (this.dictionary_0.TryGetValue(text, out ginterface))
				{
					GEnum4 genum4_ = ginterface.GEnum4_0;
					if (genum4_ == GEnum4.Open)
					{
						ginterface.GClass28_0.P_m_3EA51AA9.method_74(GEnum2.Abnormal);
					}
					else if (genum4_ != GEnum4.Closing)
					{
						this.dictionary_0.Remove(text);
					}
				}
			}
		}
		this.bool_1 = false;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00005677 File Offset: 0x00003877
	public bool method_36(string string_0, out GInterface0 ginterface0_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("id");
		}
		if (string_0.Length == 0)
		{
			throw new ArgumentException("An empty string.", "id");
		}
		return this.method_8(string_0, out ginterface0_0);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000056A7 File Offset: 0x000038A7
	[CompilerGenerated]
	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		this.method_35();
	}

	// Token: 0x040001B7 RID: 439
	private volatile bool bool_0;

	// Token: 0x040001B8 RID: 440
	private object object_0;

	// Token: 0x040001B9 RID: 441
	private GClass6 gclass6_0;

	// Token: 0x040001BA RID: 442
	private Dictionary<string, GInterface0> dictionary_0;

	// Token: 0x040001BB RID: 443
	private volatile Enum4 enum4_0;

	// Token: 0x040001BC RID: 444
	private volatile bool bool_1;

	// Token: 0x040001BD RID: 445
	private global::System.Timers.Timer timer_0;

	// Token: 0x040001BE RID: 446
	private object object_1;

	// Token: 0x040001BF RID: 447
	private TimeSpan timeSpan_0;

	// Token: 0x02000055 RID: 85
	[CompilerGenerated]
	private sealed class Class47
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x000056AF File Offset: 0x000038AF
		internal void method_0(object object_0)
		{
			this.gclass13_0.method_0(this.enum2_0, this.byte_0, this.action_0);
		}

		// Token: 0x040001C0 RID: 448
		public GClass13 gclass13_0;

		// Token: 0x040001C1 RID: 449
		public Enum2 enum2_0;

		// Token: 0x040001C2 RID: 450
		public byte[] byte_0;

		// Token: 0x040001C3 RID: 451
		public Action action_0;
	}

	// Token: 0x02000056 RID: 86
	[CompilerGenerated]
	private sealed class Class48
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x000056CE File Offset: 0x000038CE
		internal void method_0(object object_0)
		{
			this.gclass13_0.method_1(this.enum2_0, this.stream_0, this.action_0);
		}

		// Token: 0x040001C4 RID: 452
		public GClass13 gclass13_0;

		// Token: 0x040001C5 RID: 453
		public Enum2 enum2_0;

		// Token: 0x040001C6 RID: 454
		public Stream stream_0;

		// Token: 0x040001C7 RID: 455
		public Action action_0;
	}

	// Token: 0x02000057 RID: 87
	[CompilerGenerated]
	private sealed class Class49 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x000056ED File Offset: 0x000038ED
		[DebuggerHidden]
		public Class49(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00029ACC File Offset: 0x00027CCC
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
			this.enumerator_0 = default(Dictionary<string, bool>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00029B18 File Offset: 0x00027D18
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				GClass13 gclass = this.gclass13_0;
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
					this.enumerator_0 = gclass.method_4(Class31.byte_3).GetEnumerator();
					this.int_0 = -3;
				}
				while (this.enumerator_0.MoveNext())
				{
					KeyValuePair<string, bool> keyValuePair = this.enumerator_0.Current;
					if (keyValuePair.Value)
					{
						this.string_0 = keyValuePair.Key;
						this.int_0 = 1;
						return true;
					}
				}
				this.method_0();
				this.enumerator_0 = default(Dictionary<string, bool>.Enumerator);
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00005707 File Offset: 0x00003907
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00005721 File Offset: 0x00003921
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00005721 File Offset: 0x00003921
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00029BDC File Offset: 0x00027DDC
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			GClass13.Class49 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass13.Class49(0);
				@class.gclass13_0 = this.gclass13_0;
			}
			return @class;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00005729 File Offset: 0x00003929
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040001C8 RID: 456
		private int int_0;

		// Token: 0x040001C9 RID: 457
		private string string_0;

		// Token: 0x040001CA RID: 458
		private int int_1;

		// Token: 0x040001CB RID: 459
		public GClass13 gclass13_0;

		// Token: 0x040001CC RID: 460
		private Dictionary<string, bool>.Enumerator enumerator_0;
	}

	// Token: 0x02000058 RID: 88
	[CompilerGenerated]
	private sealed class Class50 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x060003AF RID: 943 RVA: 0x00005731 File Offset: 0x00003931
		[DebuggerHidden]
		public Class50(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00029C20 File Offset: 0x00027E20
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
			this.enumerator_0 = default(Dictionary<string, bool>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00029C6C File Offset: 0x00027E6C
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				GClass13 gclass = this.gclass13_0;
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
					this.enumerator_0 = gclass.method_4(Class31.byte_3).GetEnumerator();
					this.int_0 = -3;
				}
				while (this.enumerator_0.MoveNext())
				{
					KeyValuePair<string, bool> keyValuePair = this.enumerator_0.Current;
					if (!keyValuePair.Value)
					{
						this.string_0 = keyValuePair.Key;
						this.int_0 = 1;
						return true;
					}
				}
				this.method_0();
				this.enumerator_0 = default(Dictionary<string, bool>.Enumerator);
				flag = false;
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000574B File Offset: 0x0000394B
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00005765 File Offset: 0x00003965
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00005765 File Offset: 0x00003965
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00029D30 File Offset: 0x00027F30
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			GClass13.Class50 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass13.Class50(0);
				@class.gclass13_0 = this.gclass13_0;
			}
			return @class;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000576D File Offset: 0x0000396D
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040001CD RID: 461
		private int int_0;

		// Token: 0x040001CE RID: 462
		private string string_0;

		// Token: 0x040001CF RID: 463
		private int int_1;

		// Token: 0x040001D0 RID: 464
		public GClass13 gclass13_0;

		// Token: 0x040001D1 RID: 465
		private Dictionary<string, bool>.Enumerator enumerator_0;
	}
}
