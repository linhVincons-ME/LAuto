using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000208 RID: 520
internal class Class382 : Class381, IDisposable
{
	// Token: 0x06001CB1 RID: 7345 RVA: 0x000DD110 File Offset: 0x000DB310
	public Class382(Control3 control3_1)
		: base(control3_1)
	{
		this.timer_0.Interval = 10000;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Enabled = true;
		this.String_0 = Environment.NewLine;
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000136CB File Offset: 0x000118CB
	// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x000136D3 File Offset: 0x000118D3
	public string String_0 { get; set; }

	// Token: 0x170005AD RID: 1453
	public override Class351 this[int i]
	{
		get
		{
			if (this.list_0[i] != null)
			{
				return this.list_0[i];
			}
			this.method_6(i);
			return this.list_0[i];
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x0001370C File Offset: 0x0001190C
	public override void Dispose()
	{
		if (this.fileStream_0 != null)
		{
			this.fileStream_0.Dispose();
		}
		this.timer_0.Dispose();
	}

	// Token: 0x1400003A RID: 58
	// (add) Token: 0x06001CB7 RID: 7351 RVA: 0x000DD178 File Offset: 0x000DB378
	// (remove) Token: 0x06001CB8 RID: 7352 RVA: 0x000DD1B0 File Offset: 0x000DB3B0
	public event EventHandler<EventArgs12> Event_7
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs12> eventHandler = this.eventHandler_7;
			EventHandler<EventArgs12> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs12> eventHandler3 = (EventHandler<EventArgs12>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs12>>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs12> eventHandler = this.eventHandler_7;
			EventHandler<EventArgs12> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs12> eventHandler3 = (EventHandler<EventArgs12>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs12>>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400003B RID: 59
	// (add) Token: 0x06001CB9 RID: 7353 RVA: 0x000DD1E8 File Offset: 0x000DB3E8
	// (remove) Token: 0x06001CBA RID: 7354 RVA: 0x000DD220 File Offset: 0x000DB420
	public event EventHandler<EventArgs13> Event_8
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs13> eventHandler = this.eventHandler_8;
			EventHandler<EventArgs13> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs13> eventHandler3 = (EventHandler<EventArgs13>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs13>>(ref this.eventHandler_8, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs13> eventHandler = this.eventHandler_8;
			EventHandler<EventArgs13> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs13> eventHandler3 = (EventHandler<EventArgs13>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs13>>(ref this.eventHandler_8, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x000DD258 File Offset: 0x000DB458
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Enabled = false;
		try
		{
			this.method_1();
		}
		finally
		{
			this.timer_0.Enabled = true;
		}
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x000DD298 File Offset: 0x000DB498
	private void method_1()
	{
		GStruct19 gstruct19_ = base.Control3_0.Class357_4.GStruct19_0;
		int int_ = base.Control3_0.Class357_4.GStruct19_1.int_1;
		int num = 0;
		for (int i = 0; i < this.Count; i++)
		{
			if (this.list_0[i] != null && !this.list_0[i].Boolean_0 && Math.Abs(i - int_) > 2000)
			{
				this.list_0[i] = null;
				num++;
			}
		}
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x000DD320 File Offset: 0x000DB520
	public void method_2(string string_1, Encoding encoding_1)
	{
		this.Clear();
		if (this.fileStream_0 != null)
		{
			this.fileStream_0.Dispose();
		}
		this.String_0 = Environment.NewLine;
		this.fileStream_0 = new FileStream(string_1, FileMode.Open);
		long length = this.fileStream_0.Length;
		encoding_1 = Class382.smethod_0(encoding_1, this.fileStream_0);
		this.method_3(encoding_1);
		this.list_1.Add((int)this.fileStream_0.Position);
		this.list_0.Add(null);
		this.list_1.Capacity = (int)(length / 7L + 1000L);
		int num = 0;
		int num2 = 0;
		BinaryReader binaryReader = new BinaryReader(this.fileStream_0, encoding_1);
		while (this.fileStream_0.Position < length)
		{
			num2 = (int)this.fileStream_0.Position;
			char c = binaryReader.ReadChar();
			if (c == '\n')
			{
				this.list_1.Add((int)this.fileStream_0.Position);
				this.list_0.Add(null);
			}
			else if (num == 13)
			{
				this.list_1.Add(num2);
				this.list_0.Add(null);
				this.String_0 = "\r";
			}
			num = (int)c;
		}
		if (num == 13)
		{
			this.list_1.Add(num2);
			this.list_0.Add(null);
		}
		if (length > 2000000L)
		{
			GC.Collect();
		}
		Class351[] array = new Class351[100];
		int num3 = this.list_0.Count;
		this.list_0.AddRange(array);
		this.list_0.TrimExcess();
		this.list_0.RemoveRange(num3, array.Length);
		int[] array2 = new int[100];
		num3 = this.list_0.Count;
		this.list_1.AddRange(array2);
		this.list_1.TrimExcess();
		this.list_1.RemoveRange(num3, array.Length);
		this.encoding_0 = encoding_1;
		this.vmethod_7(0, this.Count);
		int num4 = Math.Min(this.list_0.Count, base.Control3_0.ClientRectangle.Height / base.Control3_0.Int32_2);
		for (int i = 0; i < num4; i++)
		{
			this.method_6(i);
		}
		this.vmethod_11(new Class381.EventArgs14(0, num4 - 1));
		if (base.Control3_0.Boolean_23)
		{
			this.vmethod_12(new Class381.EventArgs14(0, num4 - 1));
		}
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x000DD584 File Offset: 0x000DB784
	private int method_3(Encoding encoding_1)
	{
		if (encoding_1.IsSingleByte)
		{
			return 0;
		}
		if (encoding_1.HeaderName == "unicodeFFFE")
		{
			return 0;
		}
		if (encoding_1.HeaderName == "utf-16")
		{
			return 1;
		}
		if (encoding_1.HeaderName == "utf-32BE")
		{
			return 0;
		}
		if (encoding_1.HeaderName == "utf-32")
		{
			return 3;
		}
		return 0;
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x000DD5EC File Offset: 0x000DB7EC
	private static Encoding smethod_0(Encoding encoding_1, FileStream fileStream_1)
	{
		int num = 0;
		byte[] array = new byte[4];
		int num2 = fileStream_1.Read(array, 0, 4);
		if (array[0] == 255 && array[1] == 254 && array[2] == 0 && array[3] == 0 && num2 >= 4)
		{
			encoding_1 = Encoding.UTF32;
			num = 4;
		}
		else if (array[0] == 0 && array[1] == 0 && array[2] == 254 && array[3] == 255)
		{
			encoding_1 = new UTF32Encoding(true, true);
			num = 4;
		}
		else if (array[0] == 239 && array[1] == 187 && array[2] == 191)
		{
			encoding_1 = Encoding.UTF8;
			num = 3;
		}
		else if (array[0] == 254 && array[1] == 255)
		{
			encoding_1 = Encoding.BigEndianUnicode;
			num = 2;
		}
		else if (array[0] == 255 && array[1] == 254)
		{
			encoding_1 = Encoding.Unicode;
			num = 2;
		}
		fileStream_1.Seek((long)num, SeekOrigin.Begin);
		return encoding_1;
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x000DD6D8 File Offset: 0x000DB8D8
	public void method_4()
	{
		if (this.fileStream_0 != null)
		{
			try
			{
				this.fileStream_0.Dispose();
			}
			catch
			{
			}
		}
		this.fileStream_0 = null;
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x000DD714 File Offset: 0x000DB914
	public override void m_5A2109FD(string string_1, Encoding encoding_1)
	{
		List<int> list = new List<int>(this.Count);
		string text = Path.Combine(Path.GetDirectoryName(string_1), Path.GetFileNameWithoutExtension(string_1) + ".tmp");
		StreamReader streamReader = new StreamReader(this.fileStream_0, this.encoding_0);
		using (FileStream fileStream = new FileStream(text, FileMode.Create))
		{
			using (StreamWriter streamWriter = new StreamWriter(fileStream, encoding_1))
			{
				streamWriter.Flush();
				for (int i = 0; i < this.Count; i++)
				{
					list.Add((int)fileStream.Length);
					string text2 = this.method_5(streamReader, i);
					bool flag;
					string text3;
					if (flag = this.list_0[i] != null && this.list_0[i].Boolean_0)
					{
						text3 = this.list_0[i].String_2;
					}
					else
					{
						text3 = text2;
					}
					if (this.eventHandler_8 != null)
					{
						EventArgs13 eventArgs = new EventArgs13(text2, i, flag ? text3 : null);
						this.eventHandler_8(this, eventArgs);
						if (eventArgs.String_2 != null)
						{
							text3 = eventArgs.String_2;
						}
					}
					streamWriter.Write(text3);
					if (i < this.Count - 1)
					{
						streamWriter.Write(this.String_0);
					}
					streamWriter.Flush();
				}
			}
		}
		for (int j = 0; j < this.Count; j++)
		{
			this.list_0[j] = null;
		}
		streamReader.Dispose();
		this.fileStream_0.Dispose();
		if (File.Exists(string_1))
		{
			File.Delete(string_1);
		}
		File.Move(text, string_1);
		this.list_1 = list;
		this.fileStream_0 = new FileStream(string_1, FileMode.Open);
		this.encoding_0 = encoding_1;
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x000DD8E8 File Offset: 0x000DBAE8
	private string method_5(StreamReader streamReader_0, int int_1)
	{
		int num = this.list_1[int_1];
		if (num < 0)
		{
			return "";
		}
		this.fileStream_0.Seek((long)num, SeekOrigin.Begin);
		streamReader_0.DiscardBufferedData();
		return streamReader_0.ReadLine();
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x000DD928 File Offset: 0x000DBB28
	public override void m_AA3A1CFA()
	{
		foreach (Class351 @class in this.list_0)
		{
			if (@class != null)
			{
				@class.Boolean_0 = false;
			}
		}
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x000DD980 File Offset: 0x000DBB80
	private void method_6(int int_1)
	{
		Class351 @class = this.vmethod_0();
		this.fileStream_0.Seek((long)this.list_1[int_1], SeekOrigin.Begin);
		string text = new StreamReader(this.fileStream_0, this.encoding_0).ReadLine();
		if (text == null)
		{
			text = "";
		}
		if (this.eventHandler_7 != null)
		{
			EventArgs12 eventArgs = new EventArgs12(text, int_1);
			this.eventHandler_7(this, eventArgs);
			text = eventArgs.String_1;
			if (text == null)
			{
				return;
			}
		}
		foreach (char c in text)
		{
			@class.Add(new GStruct17(c));
		}
		this.list_0[int_1] = @class;
		if (base.Control3_0.Boolean_23)
		{
			this.vmethod_12(new Class381.EventArgs14(int_1, int_1));
		}
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x0001372C File Offset: 0x0001192C
	public override void m_559E6352(int int_1, Class351 class351_0)
	{
		this.list_1.Insert(int_1, -1);
		base.m_559E6352(int_1, class351_0);
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00013743 File Offset: 0x00011943
	public override void m_90EA19F5(int int_1, int int_2)
	{
		this.list_1.RemoveRange(int_1, int_2);
		base.m_90EA19F5(int_1, int_2);
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x0001375A File Offset: 0x0001195A
	public override void Clear()
	{
		base.Clear();
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x00013762 File Offset: 0x00011962
	public override int m_EBF80696(int int_1)
	{
		if (this.list_0[int_1] == null)
		{
			return 0;
		}
		return this.list_0[int_1].Count;
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x00013785 File Offset: 0x00011985
	public override bool m_87D86B1A(int int_1)
	{
		return this.list_0[int_1] != null && !string.IsNullOrEmpty(this.list_0[int_1].String_0);
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x000137B0 File Offset: 0x000119B0
	public override bool m_BC8D0B8B(int int_1)
	{
		return this.list_0[int_1] != null && !string.IsNullOrEmpty(this.list_0[int_1].String_1);
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x000137DB File Offset: 0x000119DB
	internal void method_7(int int_1)
	{
		if (this.list_0[int_1] != null && !this.list_0[int_1].Boolean_0)
		{
			this.list_0[int_1] = null;
		}
	}

	// Token: 0x040011DD RID: 4573
	private readonly global::System.Windows.Forms.Timer timer_0 = new global::System.Windows.Forms.Timer();

	// Token: 0x040011DE RID: 4574
	private Encoding encoding_0;

	// Token: 0x040011DF RID: 4575
	private FileStream fileStream_0;

	// Token: 0x040011E0 RID: 4576
	private List<int> list_1 = new List<int>();

	// Token: 0x040011E1 RID: 4577
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040011E2 RID: 4578
	[CompilerGenerated]
	private EventHandler<EventArgs12> eventHandler_7;

	// Token: 0x040011E3 RID: 4579
	[CompilerGenerated]
	private EventHandler<EventArgs13> eventHandler_8;
}
