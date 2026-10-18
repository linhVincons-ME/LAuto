using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

// Token: 0x0200001E RID: 30
internal abstract class Class11
{
	// Token: 0x06000117 RID: 279 RVA: 0x00003BB5 File Offset: 0x00001DB5
	protected Class11(Version version_1, NameValueCollection nameValueCollection_1)
	{
		this.version_0 = version_1;
		this.nameValueCollection_0 = nameValueCollection_1;
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000118 RID: 280 RVA: 0x000205F4 File Offset: 0x0001E7F4
	public string String_0
	{
		get
		{
			if (this.byte_0 != null && (long)this.byte_0.Length != 0L)
			{
				Encoding encoding = null;
				string text = this.nameValueCollection_0["Content-Type"];
				if (text != null && text.Length > 0)
				{
					encoding = Class71.smethod_21(text);
				}
				return (encoding ?? Encoding.UTF8).GetString(this.byte_0);
			}
			return string.Empty;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000119 RID: 281 RVA: 0x00003BCB File Offset: 0x00001DCB
	public NameValueCollection NameValueCollection_0
	{
		get
		{
			return this.nameValueCollection_0;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600011A RID: 282 RVA: 0x00003BD3 File Offset: 0x00001DD3
	public Version Version_0
	{
		get
		{
			return this.version_0;
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00020654 File Offset: 0x0001E854
	private static byte[] smethod_0(Stream stream_0, string string_1)
	{
		long num;
		if (!long.TryParse(string_1, out num))
		{
			throw new ArgumentException("Cannot be parsed.", "length");
		}
		if (num < 0L)
		{
			throw new ArgumentOutOfRangeException("length", "Less than zero.");
		}
		if (num > 1024L)
		{
			return stream_0.smethod_52(num, 1024);
		}
		if (num <= 0L)
		{
			return null;
		}
		return stream_0.smethod_51((int)num);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000206C8 File Offset: 0x0001E8C8
	private static string[] smethod_1(Stream stream_0, int int_1)
	{
		Class11.Class14 @class = new Class11.Class14();
		@class.list_0 = new List<byte>();
		@class.int_0 = 0;
		Action<int> action = new Action<int>(@class.method_0);
		bool flag = false;
		while (@class.int_0 < int_1)
		{
			if (stream_0.ReadByte().smethod_27('\r', action) && stream_0.ReadByte().smethod_27('\n', action) && stream_0.ReadByte().smethod_27('\r', action) && stream_0.ReadByte().smethod_27('\n', action))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			throw new GException0("The length of header part is greater than the max length.");
		}
		return Encoding.UTF8.GetString(@class.list_0.ToArray()).Replace("\r\n ", " ").Replace("\r\n\t", " ")
			.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000207A0 File Offset: 0x0001E9A0
	protected static T smethod_2<T>(Stream stream_0, Func<string[], T> func_0, int int_1) where T : Class11
	{
		Class11.Class15<T> @class = new Class11.Class15<T>();
		@class.stream_0 = stream_0;
		@class.bool_0 = false;
		Timer timer = new Timer(new TimerCallback(@class.method_0), null, int_1, -1);
		T t = default(T);
		Exception ex = null;
		try
		{
			t = func_0(Class11.smethod_1(@class.stream_0, 8192));
			string text = t.NameValueCollection_0["Content-Length"];
			if (text != null && text.Length > 0)
			{
				t.byte_0 = Class11.smethod_0(@class.stream_0, text);
			}
		}
		catch (Exception ex2)
		{
			ex = ex2;
		}
		finally
		{
			timer.Change(-1, -1);
			timer.Dispose();
		}
		string text2 = (@class.bool_0 ? "A timeout has occurred while reading an HTTP request/response." : ((ex != null) ? "An exception has occurred while reading an HTTP request/response." : null));
		if (text2 != null)
		{
			throw new GException0(text2, ex);
		}
		return t;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00003BDB File Offset: 0x00001DDB
	public byte[] method_0()
	{
		return Encoding.UTF8.GetBytes(this.ToString());
	}

	// Token: 0x040000AB RID: 171
	private NameValueCollection nameValueCollection_0;

	// Token: 0x040000AC RID: 172
	private const int int_0 = 8192;

	// Token: 0x040000AD RID: 173
	private Version version_0;

	// Token: 0x040000AE RID: 174
	internal byte[] byte_0;

	// Token: 0x040000AF RID: 175
	protected const string string_0 = "\r\n";

	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	private sealed class Class14
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00020890 File Offset: 0x0001EA90
		internal void method_0(int int_1)
		{
			if (int_1 == -1)
			{
				throw new EndOfStreamException("The header cannot be read from the data source.");
			}
			this.list_0.Add((byte)int_1);
			int num = this.int_0;
			this.int_0 = num + 1;
		}

		// Token: 0x040000B0 RID: 176
		public List<byte> list_0;

		// Token: 0x040000B1 RID: 177
		public int int_0;
	}

	// Token: 0x02000020 RID: 32
	[CompilerGenerated]
	private sealed class Class15<T> where T : Class11
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00003BED File Offset: 0x00001DED
		internal void method_0(object object_0)
		{
			this.bool_0 = true;
			this.stream_0.Close();
		}

		// Token: 0x040000B2 RID: 178
		public bool bool_0;

		// Token: 0x040000B3 RID: 179
		public Stream stream_0;
	}
}
