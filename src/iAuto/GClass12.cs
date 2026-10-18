using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using WebSocketSharp;

// Token: 0x02000050 RID: 80
public class GClass12
{
	// Token: 0x06000349 RID: 841 RVA: 0x00027BE8 File Offset: 0x00025DE8
	internal GClass12(GClass6 gclass6_1)
	{
		this.gclass6_0 = gclass6_1;
		this.bool_0 = true;
		this.dictionary_0 = new Dictionary<string, GClass11>();
		this.enum4_0 = Enum4.Ready;
		this.object_0 = ((ICollection)this.dictionary_0).SyncRoot;
		this.timeSpan_0 = TimeSpan.FromSeconds(1.0);
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600034A RID: 842 RVA: 0x00027C44 File Offset: 0x00025E44
	public int Int32_0
	{
		get
		{
			object obj = this.object_0;
			int count;
			lock (obj)
			{
				count = this.dictionary_0.Count;
			}
			return count;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600034B RID: 843 RVA: 0x00027C8C File Offset: 0x00025E8C
	public IEnumerable<GClass11> IEnumerable_0
	{
		get
		{
			object obj = this.object_0;
			IEnumerable<GClass11> enumerable;
			lock (obj)
			{
				enumerable = this.dictionary_0.Values.smethod_61<GClass11>();
			}
			return enumerable;
		}
	}

	// Token: 0x170000C6 RID: 198
	public GClass11 this[string string_0]
	{
		get
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("path");
			}
			if (string_0.Length == 0)
			{
				throw new ArgumentException("An empty string.", "path");
			}
			if (string_0[0] != '/')
			{
				throw new ArgumentException("Not an absolute path.", "path");
			}
			if (string_0.IndexOfAny(new char[] { '?', '#' }) > -1)
			{
				throw new ArgumentException("It includes either or both query and fragment components.", "path");
			}
			GClass11 gclass;
			this.method_7(string_0, out gclass);
			return gclass;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600034D RID: 845 RVA: 0x00005408 File Offset: 0x00003608
	// (set) Token: 0x0600034E RID: 846 RVA: 0x00027D5C File Offset: 0x00025F5C
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
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_5(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					foreach (GClass11 gclass in this.dictionary_0.Values)
					{
						gclass.Boolean_0 = value;
					}
					this.bool_0 = value;
				}
			}
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600034F RID: 847 RVA: 0x00027E14 File Offset: 0x00026014
	public IEnumerable<string> IEnumerable_1
	{
		get
		{
			object obj = this.object_0;
			IEnumerable<string> enumerable;
			lock (obj)
			{
				enumerable = this.dictionary_0.Keys.smethod_61<string>();
			}
			return enumerable;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000350 RID: 848 RVA: 0x00027E60 File Offset: 0x00026060
	[Obsolete("This property will be removed.")]
	public int Int32_1
	{
		get
		{
			int num = 0;
			foreach (GClass11 gclass in this.IEnumerable_0)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					break;
				}
				num += gclass.GClass13_0.Int32_0;
			}
			return num;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000351 RID: 849 RVA: 0x00005412 File Offset: 0x00003612
	// (set) Token: 0x06000352 RID: 850 RVA: 0x00027EC8 File Offset: 0x000260C8
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
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_5(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					foreach (GClass11 gclass in this.dictionary_0.Values)
					{
						gclass.TimeSpan_0 = value;
					}
					this.timeSpan_0 = value;
				}
			}
		}
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00027F9C File Offset: 0x0002619C
	private void method_0(Enum2 enum2_0, byte[] byte_0, Action action_0)
	{
		Dictionary<CompressionMethod, byte[]> dictionary = new Dictionary<CompressionMethod, byte[]>();
		try
		{
			foreach (GClass11 gclass in this.IEnumerable_0)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					this.gclass6_0.method_2("The server is shutting down.");
					break;
				}
				gclass.GClass13_0.method_10(enum2_0, byte_0, dictionary);
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

	// Token: 0x06000354 RID: 852 RVA: 0x00028068 File Offset: 0x00026268
	private void method_1(Enum2 enum2_0, Stream stream_0, Action action_0)
	{
		Dictionary<CompressionMethod, Stream> dictionary = new Dictionary<CompressionMethod, Stream>();
		try
		{
			foreach (GClass11 gclass in this.IEnumerable_0)
			{
				if (this.enum4_0 != Enum4.Start)
				{
					this.gclass6_0.method_2("The server is shutting down.");
					break;
				}
				gclass.GClass13_0.method_11(enum2_0, stream_0, dictionary);
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

	// Token: 0x06000355 RID: 853 RVA: 0x0000541A File Offset: 0x0000361A
	private void method_2(Enum2 enum2_0, byte[] byte_0, Action action_0)
	{
		GClass12.Class45 @class = new GClass12.Class45();
		@class.gclass12_0 = this;
		@class.enum2_0 = enum2_0;
		@class.byte_0 = byte_0;
		@class.action_0 = action_0;
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0000544E File Offset: 0x0000364E
	private void method_3(Enum2 enum2_0, Stream stream_0, Action action_0)
	{
		GClass12.Class46 @class = new GClass12.Class46();
		@class.gclass12_0 = this;
		@class.enum2_0 = enum2_0;
		@class.stream_0 = stream_0;
		@class.action_0 = action_0;
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00028174 File Offset: 0x00026374
	private Dictionary<string, Dictionary<string, bool>> method_4(byte[] byte_0, TimeSpan timeSpan_1)
	{
		Dictionary<string, Dictionary<string, bool>> dictionary = new Dictionary<string, Dictionary<string, bool>>();
		foreach (GClass11 gclass in this.IEnumerable_0)
		{
			if (this.enum4_0 != Enum4.Start)
			{
				this.gclass6_0.method_2("The server is shutting down.");
				break;
			}
			Dictionary<string, bool> dictionary2 = gclass.GClass13_0.method_12(byte_0, timeSpan_1);
			dictionary.Add(gclass.String_0, dictionary2);
		}
		return dictionary;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00005482 File Offset: 0x00003682
	private bool method_5(out string string_0)
	{
		string_0 = null;
		if (this.enum4_0 == Enum4.Start)
		{
			string_0 = "The server has already started.";
			return false;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			string_0 = "The server is shutting down.";
			return false;
		}
		return true;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000281FC File Offset: 0x000263FC
	internal void method_6<T>(string string_0, Func<T> func_0) where T : GClass9
	{
		string_0 = Class71.smethod_33(string_0).smethod_66();
		object obj = this.object_0;
		lock (obj)
		{
			GClass11 gclass;
			if (this.dictionary_0.TryGetValue(string_0, out gclass))
			{
				throw new ArgumentException("Already in use.", "path");
			}
			gclass = new Class42<T>(string_0, func_0, null, this.gclass6_0);
			if (!this.bool_0)
			{
				gclass.Boolean_0 = false;
			}
			if (this.timeSpan_0 != gclass.TimeSpan_0)
			{
				gclass.TimeSpan_0 = this.timeSpan_0;
			}
			if (this.enum4_0 == Enum4.Start)
			{
				gclass.method_0();
			}
			this.dictionary_0.Add(string_0, gclass);
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x000282C0 File Offset: 0x000264C0
	internal bool method_7(string string_0, out GClass11 gclass11_0)
	{
		string_0 = Class71.smethod_33(string_0).smethod_66();
		object obj = this.object_0;
		bool flag2;
		lock (obj)
		{
			flag2 = this.dictionary_0.TryGetValue(string_0, out gclass11_0);
		}
		return flag2;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00028318 File Offset: 0x00026518
	internal void method_8()
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (GClass11 gclass in this.dictionary_0.Values)
			{
				gclass.method_0();
			}
			this.enum4_0 = Enum4.Start;
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000283A0 File Offset: 0x000265A0
	internal void method_9(ushort ushort_0, string string_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.enum4_0 = Enum4.ShuttingDown;
			foreach (GClass11 gclass in this.dictionary_0.Values)
			{
				gclass.method_2(ushort_0, string_0);
			}
			this.enum4_0 = Enum4.Stop;
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00028434 File Offset: 0x00026634
	public void method_10<T>(string string_0, Action<T> action_0) where T : GClass9, new()
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_0.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_0[0] != '/')
		{
			throw new ArgumentException("Not an absolute path.", "path");
		}
		if (string_0.IndexOfAny(new char[] { '?', '#' }) > -1)
		{
			throw new ArgumentException("It includes either or both query and fragment components.", "path");
		}
		string_0 = Class71.smethod_33(string_0).smethod_66();
		object obj = this.object_0;
		lock (obj)
		{
			GClass11 gclass;
			if (this.dictionary_0.TryGetValue(string_0, out gclass))
			{
				throw new ArgumentException("Already in use.", "path");
			}
			string text = string_0;
			Func<T> func;
			if ((func = GClass12.Class44<T>._9__33_0) == null)
			{
				func = (GClass12.Class44<T>._9__33_0 = new Func<T>(GClass12.Class44<T>._9.method_0));
			}
			gclass = new Class42<T>(text, func, action_0, this.gclass6_0);
			if (!this.bool_0)
			{
				gclass.Boolean_0 = false;
			}
			if (this.timeSpan_0 != gclass.TimeSpan_0)
			{
				gclass.TimeSpan_0 = this.timeSpan_0;
			}
			if (this.enum4_0 == Enum4.Start)
			{
				gclass.method_0();
			}
			this.dictionary_0.Add(string_0, gclass);
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00028580 File Offset: 0x00026780
	[Obsolete("This method will be removed.")]
	public void method_11(byte[] byte_0)
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

	// Token: 0x0600035F RID: 863 RVA: 0x000285D4 File Offset: 0x000267D4
	[Obsolete("This method will be removed.")]
	public void method_12(string string_0)
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

	// Token: 0x06000360 RID: 864 RVA: 0x00028644 File Offset: 0x00026844
	[Obsolete("This method will be removed.")]
	public void method_13(byte[] byte_0, Action action_0)
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

	// Token: 0x06000361 RID: 865 RVA: 0x00028698 File Offset: 0x00026898
	[Obsolete("This method will be removed.")]
	public void method_14(string string_0, Action action_0)
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

	// Token: 0x06000362 RID: 866 RVA: 0x00028708 File Offset: 0x00026908
	[Obsolete("This method will be removed.")]
	public void method_15(Stream stream_0, int int_0, Action action_0)
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

	// Token: 0x06000363 RID: 867 RVA: 0x000054B0 File Offset: 0x000036B0
	[Obsolete("This method will be removed.")]
	public Dictionary<string, Dictionary<string, bool>> method_16()
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		return this.method_4(Class31.byte_3, this.timeSpan_0);
	}

	// Token: 0x06000364 RID: 868 RVA: 0x000287C4 File Offset: 0x000269C4
	[Obsolete("This method will be removed.")]
	public Dictionary<string, Dictionary<string, bool>> method_17(string string_0)
	{
		if (this.enum4_0 != Enum4.Start)
		{
			throw new InvalidOperationException("The current state of the manager is not Start.");
		}
		if (string_0.smethod_87())
		{
			return this.method_4(Class31.byte_3, this.timeSpan_0);
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
		return this.method_4(@class.method_3(), this.timeSpan_0);
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00028850 File Offset: 0x00026A50
	public void method_18()
	{
		List<GClass11> list = null;
		object obj = this.object_0;
		lock (obj)
		{
			list = this.dictionary_0.Values.smethod_61<GClass11>();
			this.dictionary_0.Clear();
		}
		foreach (GClass11 gclass in list)
		{
			if (gclass.Enum4_0 == Enum4.Start)
			{
				gclass.method_2(1001, string.Empty);
			}
		}
	}

	// Token: 0x06000366 RID: 870 RVA: 0x000288FC File Offset: 0x00026AFC
	public bool method_19(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_0.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_0[0] != '/')
		{
			throw new ArgumentException("Not an absolute path.", "path");
		}
		if (string_0.IndexOfAny(new char[] { '?', '#' }) > -1)
		{
			throw new ArgumentException("It includes either or both query and fragment components.", "path");
		}
		string_0 = Class71.smethod_33(string_0).smethod_66();
		object obj = this.object_0;
		GClass11 gclass;
		lock (obj)
		{
			if (!this.dictionary_0.TryGetValue(string_0, out gclass))
			{
				return false;
			}
			this.dictionary_0.Remove(string_0);
		}
		if (gclass.Enum4_0 == Enum4.Start)
		{
			gclass.method_2(1001, string.Empty);
		}
		return true;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x000289EC File Offset: 0x00026BEC
	public bool method_20(string string_0, out GClass11 gclass11_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_0.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_0[0] != '/')
		{
			throw new ArgumentException("Not an absolute path.", "path");
		}
		if (string_0.IndexOfAny(new char[] { '?', '#' }) > -1)
		{
			throw new ArgumentException("It includes either or both query and fragment components.", "path");
		}
		return this.method_7(string_0, out gclass11_0);
	}

	// Token: 0x040001A7 RID: 423
	private volatile bool bool_0;

	// Token: 0x040001A8 RID: 424
	private Dictionary<string, GClass11> dictionary_0;

	// Token: 0x040001A9 RID: 425
	private GClass6 gclass6_0;

	// Token: 0x040001AA RID: 426
	private volatile Enum4 enum4_0;

	// Token: 0x040001AB RID: 427
	private object object_0;

	// Token: 0x040001AC RID: 428
	private TimeSpan timeSpan_0;

	// Token: 0x02000051 RID: 81
	[CompilerGenerated]
	[Serializable]
	private sealed class Class44<T> where T : GClass9, new()
	{
		public static readonly GClass12.Class44<T> _9;
		public static Func<T> _9__33_0;
		// Token: 0x06000368 RID: 872 RVA: 0x000054D9 File Offset: 0x000036D9
		// Note: this type is marked as 'beforefieldinit'.
		static Class44()
		{
			GClass12.Class44<T>._9 = new GClass12.Class44<T>();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000054E5 File Offset: 0x000036E5
		internal T method_0()
		{
			return new T();
		}

		// Token: 0x040001AD RID: 429
		public static readonly GClass12.Class44<T> f_24C8983E;

		// Token: 0x040001AE RID: 430
		public static Func<T> f_DD5AD646;
	}

	// Token: 0x02000052 RID: 82
	[CompilerGenerated]
	private sealed class Class45
	{
		// Token: 0x0600036C RID: 876 RVA: 0x000054EC File Offset: 0x000036EC
		internal void method_0(object object_0)
		{
			this.gclass12_0.method_0(this.enum2_0, this.byte_0, this.action_0);
		}

		// Token: 0x040001AF RID: 431
		public GClass12 gclass12_0;

		// Token: 0x040001B0 RID: 432
		public Enum2 enum2_0;

		// Token: 0x040001B1 RID: 433
		public byte[] byte_0;

		// Token: 0x040001B2 RID: 434
		public Action action_0;
	}

	// Token: 0x02000053 RID: 83
	[CompilerGenerated]
	private sealed class Class46
	{
		// Token: 0x0600036E RID: 878 RVA: 0x0000550B File Offset: 0x0000370B
		internal void method_0(object object_0)
		{
			this.gclass12_0.method_1(this.enum2_0, this.stream_0, this.action_0);
		}

		// Token: 0x040001B3 RID: 435
		public GClass12 gclass12_0;

		// Token: 0x040001B4 RID: 436
		public Enum2 enum2_0;

		// Token: 0x040001B5 RID: 437
		public Stream stream_0;

		// Token: 0x040001B6 RID: 438
		public Action action_0;
	}
}
