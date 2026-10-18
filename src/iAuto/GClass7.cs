using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Net;

// Token: 0x0200002F RID: 47
public class GClass7 : IDisposable
{
	// Token: 0x0600017D RID: 381 RVA: 0x00021378 File Offset: 0x0001F578
	internal GClass7(GClass29 gclass29_0, string string_7)
	{
		this.gclass28_0 = gclass29_0;
		this.string_4 = string_7;
		this.action_0 = new Action(gclass29_0.method_0);
		this.gclass6_0 = gclass29_0.GClass6_0;
		this.action_1 = new Action<GEventArgs2>(this.method_29);
		this.bool_10 = gclass29_0.P_m_A48BE766;
		this.stream_0 = gclass29_0.Stream_0;
		this.timeSpan_0 = TimeSpan.FromSeconds(1.0);
		this.method_26();
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00021400 File Offset: 0x0001F600
	internal GClass7(Class81 class81_0, string string_7)
	{
		this.gclass28_0 = class81_0;
		this.string_4 = string_7;
		this.action_0 = new Action(class81_0.method_2);
		this.gclass6_0 = class81_0.GClass6_0;
		this.action_1 = new Action<GEventArgs2>(this.method_29);
		this.bool_10 = class81_0.P_m_A48BE766;
		this.stream_0 = class81_0.Stream_0;
		this.timeSpan_0 = TimeSpan.FromSeconds(1.0);
		this.method_26();
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00021488 File Offset: 0x0001F688
	public GClass7(string string_7, params string[] string_8)
	{
		if (string_7 == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string_7.Length == 0)
		{
			throw new ArgumentException("An empty string.", "url");
		}
		string text;
		if (!string_7.smethod_69(out this.uri_1, out text))
		{
			throw new ArgumentException(text, "url");
		}
		if (string_8 != null && string_8.Length != 0)
		{
			if (!GClass7.smethod_0(string_8, out text))
			{
				throw new ArgumentException(text, "protocols");
			}
			this.string_5 = string_8;
		}
		this.string_0 = GClass7.smethod_1();
		this.bool_0 = true;
		this.gclass6_0 = new GClass6();
		this.action_1 = new Action<GEventArgs2>(this.method_28);
		this.bool_10 = this.uri_1.Scheme == "wss";
		this.timeSpan_0 = TimeSpan.FromSeconds(5.0);
		this.method_26();
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000180 RID: 384 RVA: 0x000041A2 File Offset: 0x000023A2
	internal GClass16 GClass16_0
	{
		get
		{
			return this.gclass16_0;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000181 RID: 385 RVA: 0x000041AA File Offset: 0x000023AA
	// (set) Token: 0x06000182 RID: 386 RVA: 0x000041B2 File Offset: 0x000023B2
	internal Func<GClass28, string> Func_0
	{
		get
		{
			return this.func_0;
		}
		set
		{
			this.func_0 = value;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000183 RID: 387 RVA: 0x00021568 File Offset: 0x0001F768
	internal bool Boolean_0
	{
		get
		{
			object obj = this.object_0;
			bool flag2;
			lock (obj)
			{
				flag2 = this.queue_0.Count > 0;
			}
			return flag2;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000184 RID: 388 RVA: 0x000041BB File Offset: 0x000023BB
	// (set) Token: 0x06000185 RID: 389 RVA: 0x000041C3 File Offset: 0x000023C3
	internal bool Boolean_1
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000186 RID: 390 RVA: 0x000041CC File Offset: 0x000023CC
	internal bool Boolean_2
	{
		get
		{
			return this.genum4_0 == GEnum4.Open || this.genum4_0 == GEnum4.Closing;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000187 RID: 391 RVA: 0x000041E6 File Offset: 0x000023E6
	// (set) Token: 0x06000188 RID: 392 RVA: 0x000215B4 File Offset: 0x0001F7B4
	public CompressionMethod CompressionMethod_0
	{
		get
		{
			return this.compressionMethod_0;
		}
		set
		{
			string text = null;
			if (!this.bool_0)
			{
				text = "This instance is not a client.";
				throw new InvalidOperationException(text);
			}
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_3;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.compressionMethod_0 = value;
				}
			}
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000189 RID: 393 RVA: 0x000041EE File Offset: 0x000023EE
	public IEnumerable<GClass15> IEnumerable_0
	{
		get
		{
			GClass7.Class30 @class = new GClass7.Class30(-2);
			@class.gclass7_0 = this;
			return @class;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600018A RID: 394 RVA: 0x000041FE File Offset: 0x000023FE
	public GClass25 GClass25_0
	{
		get
		{
			return this.gclass25_0;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600018B RID: 395 RVA: 0x00004206 File Offset: 0x00002406
	// (set) Token: 0x0600018C RID: 396 RVA: 0x0000420E File Offset: 0x0000240E
	public bool Boolean_3
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

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600018D RID: 397 RVA: 0x00004217 File Offset: 0x00002417
	// (set) Token: 0x0600018E RID: 398 RVA: 0x00021640 File Offset: 0x0001F840
	public bool Boolean_4
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			string text = null;
			if (!this.bool_0)
			{
				text = "This instance is not a client.";
				throw new InvalidOperationException(text);
			}
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_3;
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

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600018F RID: 399 RVA: 0x0000421F File Offset: 0x0000241F
	public string String_0
	{
		get
		{
			return this.string_1 ?? string.Empty;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000190 RID: 400 RVA: 0x00004230 File Offset: 0x00002430
	public bool Boolean_5
	{
		get
		{
			return this.method_31(GClass7.byte_0);
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000191 RID: 401 RVA: 0x0000423D File Offset: 0x0000243D
	public bool Boolean_6
	{
		get
		{
			return this.bool_10;
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000192 RID: 402 RVA: 0x00004245 File Offset: 0x00002445
	// (set) Token: 0x06000193 RID: 403 RVA: 0x0000424F File Offset: 0x0000244F
	public GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
		internal set
		{
			this.gclass6_0 = value;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000194 RID: 404 RVA: 0x0000425A File Offset: 0x0000245A
	// (set) Token: 0x06000195 RID: 405 RVA: 0x000216CC File Offset: 0x0001F8CC
	public string String_1
	{
		get
		{
			return this.string_3;
		}
		set
		{
			string text = null;
			if (!this.bool_0)
			{
				text = "This instance is not a client.";
				throw new InvalidOperationException(text);
			}
			if (!value.smethod_87())
			{
				Uri uri;
				if (!Uri.TryCreate(value, UriKind.Absolute, out uri))
				{
					text = "Not an absolute URI string.";
					throw new ArgumentException(text, "value");
				}
				if (uri.Segments.Length > 1)
				{
					text = "It includes the path segments.";
					throw new ArgumentException(text, "value");
				}
			}
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_3;
			lock (obj)
			{
				if (!this.method_2(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.string_3 = ((!value.smethod_87()) ? value.TrimEnd(new char[] { '/' }) : value);
				}
			}
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000196 RID: 406 RVA: 0x00004262 File Offset: 0x00002462
	// (set) Token: 0x06000197 RID: 407 RVA: 0x00004273 File Offset: 0x00002473
	public string String_2
	{
		get
		{
			return this.string_4 ?? string.Empty;
		}
		internal set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000198 RID: 408 RVA: 0x0000427C File Offset: 0x0000247C
	public GEnum4 GEnum4_0
	{
		get
		{
			return this.genum4_0;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000199 RID: 409 RVA: 0x00004286 File Offset: 0x00002486
	public GClass14 GClass14_0
	{
		get
		{
			if (!this.bool_0)
			{
				throw new InvalidOperationException("This instance is not a client.");
			}
			if (!this.bool_10)
			{
				throw new InvalidOperationException("This instance does not use a secure connection.");
			}
			return this.method_25();
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000042B4 File Offset: 0x000024B4
	public Uri Uri_0
	{
		get
		{
			if (!this.bool_0)
			{
				return this.gclass28_0.P_m_6DBB1F3B;
			}
			return this.uri_1;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600019B RID: 411 RVA: 0x000042D0 File Offset: 0x000024D0
	// (set) Token: 0x0600019C RID: 412 RVA: 0x000217B4 File Offset: 0x0001F9B4
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
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_3;
			lock (obj)
			{
				if (!this.method_2(out text))
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

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600019D RID: 413 RVA: 0x00021848 File Offset: 0x0001FA48
	// (remove) Token: 0x0600019E RID: 414 RVA: 0x00021880 File Offset: 0x0001FA80
	public event EventHandler<GEventArgs0> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> eventHandler3 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> eventHandler3 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x0600019F RID: 415 RVA: 0x000218B8 File Offset: 0x0001FAB8
	// (remove) Token: 0x060001A0 RID: 416 RVA: 0x000218F0 File Offset: 0x0001FAF0
	public event EventHandler<GEventArgs1> Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs1> eventHandler = this.eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> eventHandler3 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs1>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs1> eventHandler = this.eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> eventHandler3 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs1>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060001A1 RID: 417 RVA: 0x00021928 File Offset: 0x0001FB28
	// (remove) Token: 0x060001A2 RID: 418 RVA: 0x00021960 File Offset: 0x0001FB60
	public event EventHandler<GEventArgs2> Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs2> eventHandler = this.eventHandler_2;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> eventHandler3 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs2>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs2> eventHandler = this.eventHandler_2;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> eventHandler3 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs2>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060001A3 RID: 419 RVA: 0x00021998 File Offset: 0x0001FB98
	// (remove) Token: 0x060001A4 RID: 420 RVA: 0x000219D0 File Offset: 0x0001FBD0
	public event EventHandler Event_3
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00021A08 File Offset: 0x0001FC08
	private bool method_0()
	{
		if (this.genum4_0 == GEnum4.Open)
		{
			string text = "The handshake request has already been accepted.";
			this.gclass6_0.method_6(text);
			return false;
		}
		object obj = this.object_3;
		bool flag2;
		lock (obj)
		{
			if (this.genum4_0 == GEnum4.Open)
			{
				string text2 = "The handshake request has already been accepted.";
				this.gclass6_0.method_6(text2);
				flag2 = false;
			}
			else if (this.genum4_0 == GEnum4.Closing)
			{
				string text3 = "The close process has set in.";
				this.gclass6_0.method_2(text3);
				text3 = "An interruption has occurred while attempting to accept.";
				this.method_21(text3, null);
				flag2 = false;
			}
			else if (this.genum4_0 == GEnum4.Closed)
			{
				string text4 = "The connection has been closed.";
				this.gclass6_0.method_2(text4);
				text4 = "An interruption has occurred while attempting to accept.";
				this.method_21(text4, null);
				flag2 = false;
			}
			else
			{
				try
				{
					if (!this.method_1())
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					this.gclass6_0.method_3(ex.Message);
					this.gclass6_0.method_1(ex.ToString());
					string text5 = "An exception has occurred while attempting to accept.";
					this.method_22(text5, ex);
					return false;
				}
				this.genum4_0 = GEnum4.Open;
				flag2 = true;
			}
		}
		return flag2;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00021B64 File Offset: 0x0001FD64
	private bool method_1()
	{
		this.gclass6_0.method_1(string.Format("A handshake request from {0}:\n{1}", this.gclass28_0.P_m_4ACA8297, this.gclass28_0));
		string text;
		if (!this.method_3(this.gclass28_0, out text))
		{
			this.gclass6_0.method_2(text);
			this.method_43(GEnum2.ProtocolError, "A handshake error has occurred while attempting to accept.");
			return false;
		}
		if (!this.method_17(this.gclass28_0, out text))
		{
			this.gclass6_0.method_2(text);
			this.method_43(GEnum2.PolicyViolation, "A handshake error has occurred while attempting to accept.");
			return false;
		}
		this.string_0 = this.gclass28_0.P_m_F73319E4["Sec-WebSocket-Key"];
		if (this.string_4 != null)
		{
			IEnumerable<string> enumerable = this.gclass28_0.P_m_9596B81E;
			this.method_41(enumerable);
		}
		if (!this.bool_5)
		{
			string text2 = this.gclass28_0.P_m_F73319E4["Sec-WebSocket-Extensions"];
			this.method_39(text2);
		}
		return this.method_55(this.method_16());
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000042D8 File Offset: 0x000024D8
	private bool method_2(out string string_7)
	{
		string_7 = null;
		if (this.genum4_0 == GEnum4.Open)
		{
			string_7 = "The connection has already been established.";
			return false;
		}
		if (this.genum4_0 == GEnum4.Closing)
		{
			string_7 = "The connection is closing.";
			return false;
		}
		return true;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00021C60 File Offset: 0x0001FE60
	private bool method_3(GClass28 gclass28_1, out string string_7)
	{
		string_7 = null;
		if (!gclass28_1.P_m_E8BC7EBE)
		{
			string_7 = "Not a handshake request.";
			return false;
		}
		if (gclass28_1.P_m_6DBB1F3B == null)
		{
			string_7 = "It specifies an invalid Request-URI.";
			return false;
		}
		NameValueCollection nameValueCollection = gclass28_1.P_m_F73319E4;
		string text = nameValueCollection["Sec-WebSocket-Key"];
		if (text == null)
		{
			string_7 = "It includes no Sec-WebSocket-Key header.";
			return false;
		}
		if (text.Length == 0)
		{
			string_7 = "It includes an invalid Sec-WebSocket-Key header.";
			return false;
		}
		string text2 = nameValueCollection["Sec-WebSocket-Version"];
		if (text2 == null)
		{
			string_7 = "It includes no Sec-WebSocket-Version header.";
			return false;
		}
		if (text2 != "13")
		{
			string_7 = "It includes an invalid Sec-WebSocket-Version header.";
			return false;
		}
		string text3 = nameValueCollection["Sec-WebSocket-Protocol"];
		if (text3 != null && text3.Length == 0)
		{
			string_7 = "It includes an invalid Sec-WebSocket-Protocol header.";
			return false;
		}
		if (!this.bool_5)
		{
			string text4 = nameValueCollection["Sec-WebSocket-Extensions"];
			if (text4 != null && text4.Length == 0)
			{
				string_7 = "It includes an invalid Sec-WebSocket-Extensions header.";
				return false;
			}
		}
		return true;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00021D44 File Offset: 0x0001FF44
	private bool method_4(Class13 class13_0, out string string_7)
	{
		string_7 = null;
		if (class13_0.Boolean_2)
		{
			string_7 = "Indicates the redirection.";
			return false;
		}
		if (class13_0.Boolean_3)
		{
			string_7 = "Requires the authentication.";
			return false;
		}
		if (!class13_0.Boolean_4)
		{
			string_7 = "Not a WebSocket handshake response.";
			return false;
		}
		NameValueCollection nameValueCollection_ = class13_0.NameValueCollection_0;
		if (!this.method_59(nameValueCollection_["Sec-WebSocket-Accept"]))
		{
			string_7 = "Includes no Sec-WebSocket-Accept header, or it has an invalid value.";
			return false;
		}
		if (!this.method_61(nameValueCollection_["Sec-WebSocket-Protocol"]))
		{
			string_7 = "Includes no Sec-WebSocket-Protocol header, or it has an invalid value.";
			return false;
		}
		if (!this.method_60(nameValueCollection_["Sec-WebSocket-Extensions"]))
		{
			string_7 = "Includes an invalid Sec-WebSocket-Extensions header.";
			return false;
		}
		if (!this.method_62(nameValueCollection_["Sec-WebSocket-Version"]))
		{
			string_7 = "Includes an invalid Sec-WebSocket-Version header.";
			return false;
		}
		return true;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00021E00 File Offset: 0x00020000
	private static bool smethod_0(string[] string_7, out string string_8)
	{
		string_8 = null;
		Func<string, bool> func = new Func<string, bool>(GClass7.Class21.f_76642BEE.method_0);
		if (string_7.smethod_18<string>(func))
		{
			string_8 = "It contains a value that is not a token.";
			return false;
		}
		if (string_7.smethod_19())
		{
			string_8 = "It contains a value twice.";
			return false;
		}
		return true;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00021E54 File Offset: 0x00020054
	private bool method_5(Class31 class31_0, out string string_7)
	{
		string_7 = null;
		bool boolean_ = class31_0.Boolean_8;
		if (this.bool_0 && boolean_)
		{
			string_7 = "A frame from the server is masked.";
			return false;
		}
		if (!this.bool_0 && !boolean_)
		{
			string_7 = "A frame from a client is not masked.";
			return false;
		}
		if (this.bool_6 && class31_0.Boolean_5)
		{
			string_7 = "A data frame has been received while receiving continuation frames.";
			return false;
		}
		if (class31_0.Boolean_2 && this.compressionMethod_0 == CompressionMethod.None)
		{
			string_7 = "A compressed frame has been received without any agreement for it.";
			return false;
		}
		if (class31_0.Enum3_1 == Enum3.On)
		{
			string_7 = "The RSV2 of a frame is non-zero without any negotiation for it.";
			return false;
		}
		if (class31_0.Enum3_2 == Enum3.On)
		{
			string_7 = "The RSV3 of a frame is non-zero without any negotiation for it.";
			return false;
		}
		return true;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00021EEC File Offset: 0x000200EC
	private void method_6(ushort ushort_0, string string_7)
	{
		if (this.genum4_0 == GEnum4.Closing)
		{
			this.gclass6_0.method_4("The closing is already in progress.");
			return;
		}
		if (this.genum4_0 == GEnum4.Closed)
		{
			this.gclass6_0.method_4("The connection has already been closed.");
			return;
		}
		if (ushort_0 == 1005)
		{
			this.method_7(Class19.class19_0, true, true, false);
			return;
		}
		bool flag = !ushort_0.smethod_44();
		this.method_7(new Class19(ushort_0, string_7), flag, flag, false);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00021F68 File Offset: 0x00020168
	private void method_7(Class19 class19_0, bool bool_11, bool bool_12, bool bool_13)
	{
		object obj = this.object_3;
		lock (obj)
		{
			if (this.genum4_0 == GEnum4.Closing)
			{
				this.gclass6_0.method_4("The closing is already in progress.");
				return;
			}
			if (this.genum4_0 == GEnum4.Closed)
			{
				this.gclass6_0.method_4("The connection has already been closed.");
				return;
			}
			bool_11 = bool_11 && this.genum4_0 == GEnum4.Open;
			bool_12 = bool_11 && bool_12;
			this.genum4_0 = GEnum4.Closing;
		}
		this.gclass6_0.method_5("Begin closing the connection.");
		bool flag2 = this.method_11(class19_0, bool_11, bool_12, bool_13);
		this.method_46();
		this.gclass6_0.method_5("End closing the connection.");
		this.genum4_0 = GEnum4.Closed;
		GEventArgs0 geventArgs = new GEventArgs0(class19_0);
		geventArgs.Boolean_0 = flag2;
		try
		{
			this.eventHandler_0.smethod_80(this, geventArgs);
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.ToString());
			this.method_21("An error has occurred during the OnClose event.", ex);
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00022094 File Offset: 0x00020294
	private void method_8(ushort ushort_0, string string_7)
	{
		if (this.genum4_0 == GEnum4.Closing)
		{
			this.gclass6_0.method_4("The closing is already in progress.");
			return;
		}
		if (this.genum4_0 == GEnum4.Closed)
		{
			this.gclass6_0.method_4("The connection has already been closed.");
			return;
		}
		if (ushort_0 == 1005)
		{
			this.method_9(Class19.class19_0, true, true, false);
			return;
		}
		bool flag = !ushort_0.smethod_44();
		this.method_9(new Class19(ushort_0, string_7), flag, flag, false);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00022110 File Offset: 0x00020310
	private void method_9(Class19 class19_0, bool bool_11, bool bool_12, bool bool_13)
	{
		GClass7.Class22 @class = new GClass7.Class22();
		@class.action_0 = new Action<Class19, bool, bool, bool>(this.method_7);
		@class.action_0.BeginInvoke(class19_0, bool_11, bool_12, bool_13, new AsyncCallback(@class.method_0), null);
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00022154 File Offset: 0x00020354
	private bool method_10(byte[] byte_1, bool bool_11, bool bool_12)
	{
		bool flag = byte_1 != null && this.method_52(byte_1);
		if (!bool_12 && flag && bool_11 && this.manualResetEvent_1 != null)
		{
			bool_12 = this.manualResetEvent_1.WaitOne(this.timeSpan_0);
		}
		bool flag2 = flag && bool_12;
		this.gclass6_0.method_1(string.Format("Was clean?: {0}\n  sent: {1}\n  received: {2}", flag2, flag, bool_12));
		return flag2;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x000221C8 File Offset: 0x000203C8
	private bool method_11(Class19 class19_0, bool bool_11, bool bool_12, bool bool_13)
	{
		bool flag = false;
		if (bool_11)
		{
			Class31 @class = Class31.smethod_12(class19_0, this.bool_0);
			flag = this.method_52(@class.method_3());
			if (this.bool_0)
			{
				@class.method_0();
			}
		}
		if (!bool_13 && flag && bool_12 && this.manualResetEvent_1 != null)
		{
			bool_13 = this.manualResetEvent_1.WaitOne(this.timeSpan_0);
		}
		bool flag2 = flag && bool_13;
		this.gclass6_0.method_1(string.Format("Was clean?: {0}\n  sent: {1}\n  received: {2}", flag2, flag, bool_13));
		return flag2;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00022260 File Offset: 0x00020460
	private bool method_12()
	{
		if (this.genum4_0 == GEnum4.Open)
		{
			string text = "The connection has already been established.";
			this.gclass6_0.method_6(text);
			return false;
		}
		object obj = this.object_3;
		bool flag2;
		lock (obj)
		{
			if (this.genum4_0 == GEnum4.Open)
			{
				string text2 = "The connection has already been established.";
				this.gclass6_0.method_6(text2);
				flag2 = false;
			}
			else if (this.genum4_0 == GEnum4.Closing)
			{
				string text3 = "The close process has set in.";
				this.gclass6_0.method_2(text3);
				text3 = "An interruption has occurred while attempting to connect.";
				this.method_21(text3, null);
				flag2 = false;
			}
			else if (this.int_1 > GClass7.int_0)
			{
				string text4 = "An opportunity for reconnecting has been lost.";
				this.gclass6_0.method_2(text4);
				text4 = "An interruption has occurred while attempting to connect.";
				this.method_21(text4, null);
				flag2 = false;
			}
			else
			{
				this.genum4_0 = GEnum4.Connecting;
				try
				{
					this.method_19();
				}
				catch (Exception ex)
				{
					this.int_1++;
					this.gclass6_0.method_3(ex.Message);
					this.gclass6_0.method_1(ex.ToString());
					string text5 = "An exception has occurred while attempting to connect.";
					this.method_22(text5, ex);
					return false;
				}
				this.int_1 = 1;
				this.genum4_0 = GEnum4.Open;
				flag2 = true;
			}
		}
		return flag2;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x000223EC File Offset: 0x000205EC
	private string method_13()
	{
		StringBuilder stringBuilder = new StringBuilder(80);
		if (this.compressionMethod_0 != CompressionMethod.None)
		{
			string text = this.compressionMethod_0.smethod_59(new string[] { "server_no_context_takeover", "client_no_context_takeover" });
			stringBuilder.AppendFormat("{0}, ", text);
		}
		int length = stringBuilder.Length;
		if (length > 2)
		{
			stringBuilder.Length = length - 2;
			return stringBuilder.ToString();
		}
		return null;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00004306 File Offset: 0x00002506
	private Class13 method_14(GEnum5 genum5_0)
	{
		Class13 @class = Class13.smethod_3(genum5_0);
		@class.NameValueCollection_0["Sec-WebSocket-Version"] = "13";
		return @class;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00022454 File Offset: 0x00020654
	private Class12 method_15()
	{
		Class12 @class = Class12.smethod_4(this.uri_1);
		NameValueCollection nameValueCollection_ = @class.NameValueCollection_0;
		if (!this.string_3.smethod_87())
		{
			nameValueCollection_["Origin"] = this.string_3;
		}
		nameValueCollection_["Sec-WebSocket-Key"] = this.string_0;
		this.bool_9 = this.string_5 != null;
		if (this.bool_9)
		{
			nameValueCollection_["Sec-WebSocket-Protocol"] = this.string_5.smethod_103<string>(", ");
		}
		this.bool_3 = this.compressionMethod_0 > CompressionMethod.None;
		if (this.bool_3)
		{
			nameValueCollection_["Sec-WebSocket-Extensions"] = this.method_13();
		}
		nameValueCollection_["Sec-WebSocket-Version"] = "13";
		Class53 class2 = null;
		if (this.class52_0 != null && this.gclass25_0 != null)
		{
			class2 = new Class53(this.class52_0, this.gclass25_0, this.uint_0);
			this.uint_0 = class2.UInt32_0;
		}
		else if (this.bool_8)
		{
			class2 = new Class53(this.gclass25_0);
		}
		if (class2 != null)
		{
			nameValueCollection_["Authorization"] = class2.ToString();
		}
		if (this.gclass16_0.Count > 0)
		{
			@class.method_2(this.gclass16_0);
		}
		return @class;
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00022588 File Offset: 0x00020788
	private Class13 method_16()
	{
		Class13 @class = Class13.smethod_5();
		NameValueCollection nameValueCollection_ = @class.NameValueCollection_0;
		nameValueCollection_["Sec-WebSocket-Accept"] = GClass7.smethod_2(this.string_0);
		if (this.string_4 != null)
		{
			nameValueCollection_["Sec-WebSocket-Protocol"] = this.string_4;
		}
		if (this.string_1 != null)
		{
			nameValueCollection_["Sec-WebSocket-Extensions"] = this.string_1;
		}
		if (this.gclass16_0.Count > 0)
		{
			@class.method_1(this.gclass16_0);
		}
		return @class;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00004323 File Offset: 0x00002523
	private bool method_17(GClass28 gclass28_1, out string string_7)
	{
		string_7 = null;
		if (this.func_0 == null)
		{
			return true;
		}
		string_7 = this.func_0(gclass28_1);
		return string_7 == null;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00022608 File Offset: 0x00020808
	private GEventArgs2 method_18()
	{
		object obj = this.object_0;
		GEventArgs2 geventArgs;
		lock (obj)
		{
			geventArgs = ((this.queue_0.Count > 0) ? this.queue_0.Dequeue() : null);
		}
		return geventArgs;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00022660 File Offset: 0x00020860
	private void method_19()
	{
		this.method_57();
		Class13 @class = this.method_53();
		string text;
		if (!this.method_4(@class, out text))
		{
			throw new GException0(GEnum2.ProtocolError, text);
		}
		if (this.bool_9)
		{
			this.string_4 = @class.NameValueCollection_0["Sec-WebSocket-Protocol"];
		}
		if (this.bool_3)
		{
			this.method_40(@class.NameValueCollection_0["Sec-WebSocket-Extensions"]);
		}
		this.method_33(@class.GClass16_0);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000226DC File Offset: 0x000208DC
	private void method_20(GEventArgs2 geventArgs2_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.queue_0.Enqueue(geventArgs2_0);
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00022724 File Offset: 0x00020924
	private void method_21(string string_7, Exception exception_0)
	{
		try
		{
			this.eventHandler_1.smethod_80(this, new GEventArgs1(string_7, exception_0));
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00022780 File Offset: 0x00020980
	private void method_22(string string_7, Exception exception_0)
	{
		GEnum2 genum = ((exception_0 is GException0) ? ((GException0)exception_0).GEnum2_0 : GEnum2.Abnormal);
		this.method_23(string_7, (ushort)genum);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000227B0 File Offset: 0x000209B0
	private void method_23(string string_7, ushort ushort_0)
	{
		Class19 @class = new Class19(ushort_0, string_7);
		this.method_7(@class, !ushort_0.smethod_44(), false, false);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00004345 File Offset: 0x00002545
	private void method_24(string string_7, GEnum2 genum2_0)
	{
		this.method_23(string_7, (ushort)genum2_0);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000434F File Offset: 0x0000254F
	private GClass14 method_25()
	{
		if (this.gclass14_0 == null)
		{
			this.gclass14_0 = new GClass14(this.uri_1.DnsSafeHost);
		}
		return this.gclass14_0;
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x000227D8 File Offset: 0x000209D8
	private void method_26()
	{
		this.compressionMethod_0 = CompressionMethod.None;
		this.gclass16_0 = new GClass16();
		this.object_1 = new object();
		this.object_2 = new object();
		this.object_3 = new object();
		this.queue_0 = new Queue<GEventArgs2>();
		this.object_0 = ((ICollection)this.queue_0).SyncRoot;
		this.genum4_0 = GEnum4.Connecting;
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00022840 File Offset: 0x00020A40
	private void method_27()
	{
		GEventArgs2 geventArgs = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (!this.bool_7 && this.queue_0.Count != 0)
			{
				if (this.genum4_0 == GEnum4.Open)
				{
					this.bool_7 = true;
					geventArgs = this.queue_0.Dequeue();
					goto IL_005A;
				}
			}
			return;
		}
		IL_005A:
		this.action_1(geventArgs);
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x000228C4 File Offset: 0x00020AC4
	private void method_28(GEventArgs2 geventArgs2_0)
	{
		for (;;)
		{
			try
			{
				this.eventHandler_2.smethod_80(this, geventArgs2_0);
			}
			catch (Exception ex)
			{
				this.gclass6_0.method_2(ex.ToString());
				this.method_21("An error has occurred during an OnMessage event.", ex);
			}
			lock (this.object_0)
			{
				if (this.queue_0.Count == 0 || this.genum4_0 != GEnum4.Open)
				{
					this.bool_7 = false;
					break;
				}
				geventArgs2_0 = this.queue_0.Dequeue();
			}
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00022970 File Offset: 0x00020B70
	private void method_29(GEventArgs2 geventArgs2_0)
	{
		GClass7.Class23 @class = new GClass7.Class23();
		@class.gclass7_0 = this;
		@class.geventArgs2_0 = geventArgs2_0;
		try
		{
			this.eventHandler_2.smethod_80(this, @class.geventArgs2_0);
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.ToString());
			this.method_21("An error has occurred during an OnMessage event.", ex);
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (this.queue_0.Count != 0)
			{
				if (this.genum4_0 == GEnum4.Open)
				{
					@class.geventArgs2_0 = this.queue_0.Dequeue();
					goto IL_009D;
				}
			}
			this.bool_7 = false;
			return;
		}
		IL_009D:
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00022A48 File Offset: 0x00020C48
	private void method_30()
	{
		this.bool_7 = true;
		this.method_58();
		try
		{
			this.eventHandler_3.smethod_79(this, EventArgs.Empty);
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.ToString());
			this.method_21("An error has occurred during the OnOpen event.", ex);
		}
		GEventArgs2 geventArgs = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.queue_0.Count != 0)
			{
				if (this.genum4_0 == GEnum4.Open)
				{
					geventArgs = this.queue_0.Dequeue();
					goto IL_0094;
				}
			}
			this.bool_7 = false;
			return;
		}
		IL_0094:
		this.action_1.BeginInvoke(geventArgs, new AsyncCallback(this.method_97), null);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00022B20 File Offset: 0x00020D20
	private bool method_31(byte[] byte_1)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			return false;
		}
		ManualResetEvent manualResetEvent = this.manualResetEvent_0;
		if (manualResetEvent == null)
		{
			return false;
		}
		object obj = this.object_1;
		bool flag2;
		lock (obj)
		{
			try
			{
				manualResetEvent.Reset();
				if (!this.method_50(Enum0.Final, Enum2.Ping, byte_1, false))
				{
					flag2 = false;
				}
				else
				{
					flag2 = manualResetEvent.WaitOne(this.timeSpan_0);
				}
			}
			catch (ObjectDisposedException)
			{
				flag2 = false;
			}
		}
		return flag2;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00022BAC File Offset: 0x00020DAC
	private bool method_32(Class31 class31_0)
	{
		Class19 class19_ = class31_0.Class19_0;
		this.method_7(class19_, !class19_.Boolean_0, false, true);
		return false;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00004375 File Offset: 0x00002575
	private void method_33(GClass16 gclass16_1)
	{
		if (gclass16_1.Count == 0)
		{
			return;
		}
		this.gclass16_0.method_2(gclass16_1);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000438C File Offset: 0x0000258C
	private bool method_34(Class31 class31_0)
	{
		this.method_20(class31_0.Boolean_2 ? new GEventArgs2(class31_0.Enum2_0, class31_0.Class19_0.Byte_0.smethod_24(this.compressionMethod_0)) : new GEventArgs2(class31_0));
		return true;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00022BD4 File Offset: 0x00020DD4
	private bool method_35(Class31 class31_0)
	{
		if (!this.bool_6)
		{
			if (class31_0.Boolean_3)
			{
				return true;
			}
			this.enum2_0 = class31_0.Enum2_0;
			this.bool_4 = class31_0.Boolean_2;
			this.memoryStream_0 = new MemoryStream();
			this.bool_6 = true;
		}
		this.memoryStream_0.smethod_77(class31_0.Class19_0.Byte_0, 1024);
		if (class31_0.Boolean_6)
		{
			using (this.memoryStream_0)
			{
				byte[] array = (this.bool_4 ? this.memoryStream_0.smethod_26(this.compressionMethod_0) : this.memoryStream_0.ToArray());
				this.method_20(new GEventArgs2(this.enum2_0, array));
			}
			this.memoryStream_0 = null;
			this.bool_6 = false;
		}
		return true;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00022CAC File Offset: 0x00020EAC
	private bool method_36(Class31 class31_0)
	{
		this.gclass6_0.method_5("A ping was received.");
		Class31 @class = Class31.smethod_15(class31_0.Class19_0, this.bool_0);
		object obj = this.object_3;
		lock (obj)
		{
			if (this.genum4_0 != GEnum4.Open)
			{
				this.gclass6_0.method_2("The connection is closing.");
				return true;
			}
			if (!this.method_52(@class.method_3()))
			{
				return false;
			}
		}
		this.gclass6_0.method_5("A pong to this ping has been sent.");
		if (this.bool_1)
		{
			if (this.bool_0)
			{
				@class.method_0();
			}
			this.method_20(new GEventArgs2(class31_0));
		}
		return true;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00022D74 File Offset: 0x00020F74
	private bool method_37(Class31 class31_0)
	{
		this.gclass6_0.method_5("A pong was received.");
		bool flag;
		try
		{
			this.manualResetEvent_0.Set();
			goto IL_0078;
		}
		catch (NullReferenceException ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
			flag = false;
		}
		catch (ObjectDisposedException ex2)
		{
			this.gclass6_0.method_2(ex2.Message);
			this.gclass6_0.method_1(ex2.ToString());
			flag = false;
		}
		return flag;
		IL_0078:
		this.gclass6_0.method_5("It has been signaled.");
		return true;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00022E28 File Offset: 0x00021028
	private bool method_38(Class31 class31_0)
	{
		string text;
		if (!this.method_5(class31_0, out text))
		{
			throw new GException0(GEnum2.ProtocolError, text);
		}
		class31_0.method_0();
		if (class31_0.Boolean_7)
		{
			return this.method_35(class31_0);
		}
		if (class31_0.Boolean_5)
		{
			return this.method_34(class31_0);
		}
		if (class31_0.Boolean_9)
		{
			return this.method_36(class31_0);
		}
		if (class31_0.Boolean_10)
		{
			return this.method_37(class31_0);
		}
		if (!class31_0.Boolean_1)
		{
			return this.method_42(class31_0);
		}
		return this.method_32(class31_0);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00022EAC File Offset: 0x000210AC
	private void method_39(string string_7)
	{
		if (string_7 == null)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(80);
		bool flag = false;
		foreach (string text in string_7.smethod_56(new char[] { ',' }))
		{
			string text2 = text.Trim();
			if (text2.Length != 0 && !flag && text2.smethod_37(CompressionMethod.Deflate))
			{
				this.compressionMethod_0 = CompressionMethod.Deflate;
				stringBuilder.AppendFormat("{0}, ", this.compressionMethod_0.smethod_59(new string[] { "client_no_context_takeover", "server_no_context_takeover" }));
				flag = true;
			}
		}
		int length = stringBuilder.Length;
		if (length <= 2)
		{
			return;
		}
		stringBuilder.Length = length - 2;
		this.string_1 = stringBuilder.ToString();
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000043C6 File Offset: 0x000025C6
	private void method_40(string string_7)
	{
		if (string_7 == null)
		{
			this.compressionMethod_0 = CompressionMethod.None;
			return;
		}
		this.string_1 = string_7;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000043DA File Offset: 0x000025DA
	private void method_41(IEnumerable<string> ienumerable_0)
	{
		if (ienumerable_0.smethod_18<string>(new Func<string, bool>(this.method_98)))
		{
			return;
		}
		this.string_4 = null;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000043F8 File Offset: 0x000025F8
	private bool method_42(Class31 class31_0)
	{
		this.gclass6_0.method_3("An unsupported frame:" + class31_0.method_2(false));
		this.method_24("There is no way to handle it.", GEnum2.PolicyViolation);
		return false;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00022F80 File Offset: 0x00021180
	private void method_43(GEnum2 genum2_0, string string_7)
	{
		this.genum4_0 = GEnum4.Closing;
		Class13 @class = this.method_14(GEnum5.BadRequest);
		this.method_55(@class);
		this.method_47();
		this.genum4_0 = GEnum4.Closed;
		GEventArgs0 geventArgs = new GEventArgs0(genum2_0, string_7);
		try
		{
			this.eventHandler_0.smethod_80(this, geventArgs);
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00004429 File Offset: 0x00002629
	private void method_44()
	{
		if (this.stream_0 != null)
		{
			this.stream_0.Dispose();
			this.stream_0 = null;
		}
		if (this.tcpClient_0 != null)
		{
			this.tcpClient_0.Close();
			this.tcpClient_0 = null;
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0002300C File Offset: 0x0002120C
	private void method_45()
	{
		if (this.memoryStream_0 != null)
		{
			this.memoryStream_0.Dispose();
			this.memoryStream_0 = null;
			this.bool_6 = false;
		}
		if (this.manualResetEvent_0 != null)
		{
			this.manualResetEvent_0.Close();
			this.manualResetEvent_0 = null;
		}
		if (this.manualResetEvent_1 != null)
		{
			this.manualResetEvent_1.Close();
			this.manualResetEvent_1 = null;
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000445F File Offset: 0x0000265F
	private void method_46()
	{
		if (this.bool_0)
		{
			this.method_44();
		}
		else
		{
			this.method_47();
		}
		this.method_45();
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0000447D File Offset: 0x0000267D
	private void method_47()
	{
		if (this.action_0 == null)
		{
			return;
		}
		this.action_0();
		this.action_0 = null;
		this.stream_0 = null;
		this.gclass28_0 = null;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00023070 File Offset: 0x00021270
	private bool method_48(Enum2 enum2_1, Stream stream_1)
	{
		object obj = this.object_2;
		bool flag4;
		lock (obj)
		{
			Stream stream = stream_1;
			bool flag2 = false;
			bool flag3 = false;
			try
			{
				if (this.compressionMethod_0 != CompressionMethod.None)
				{
					stream_1 = stream_1.smethod_13(this.compressionMethod_0);
					flag2 = true;
				}
				if (!(flag3 = this.method_49(enum2_1, stream_1, flag2)))
				{
					this.method_21("A send has been interrupted.", null);
				}
			}
			catch (Exception ex)
			{
				this.gclass6_0.method_2(ex.ToString());
				this.method_21("An error has occurred during a send.", ex);
			}
			finally
			{
				if (flag2)
				{
					stream_1.Dispose();
				}
				stream.Dispose();
			}
			flag4 = flag3;
		}
		return flag4;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00023138 File Offset: 0x00021338
	private bool method_49(Enum2 enum2_1, Stream stream_1, bool bool_11)
	{
		long length = stream_1.Length;
		if (length == 0L)
		{
			return this.method_50(Enum0.Final, enum2_1, GClass7.byte_0, false);
		}
		long num = length / (long)GClass7.int_2;
		int num2 = (int)(length % (long)GClass7.int_2);
		byte[] array;
		if (num == 0L)
		{
			array = new byte[num2];
			return stream_1.Read(array, 0, num2) == num2 && this.method_50(Enum0.Final, enum2_1, array, bool_11);
		}
		if (num == 1L && num2 == 0)
		{
			array = new byte[GClass7.int_2];
			return stream_1.Read(array, 0, GClass7.int_2) == GClass7.int_2 && this.method_50(Enum0.Final, enum2_1, array, bool_11);
		}
		array = new byte[GClass7.int_2];
		if (stream_1.Read(array, 0, GClass7.int_2) != GClass7.int_2 || !this.method_50(Enum0.More, enum2_1, array, bool_11))
		{
			return false;
		}
		long num3 = ((num2 == 0) ? (num - 2L) : (num - 1L));
		for (long num4 = 0L; num4 < num3; num4 += 1L)
		{
			if (stream_1.Read(array, 0, GClass7.int_2) != GClass7.int_2 || !this.method_50(Enum0.More, Enum2.Cont, array, false))
			{
				return false;
			}
		}
		if (num2 == 0)
		{
			num2 = GClass7.int_2;
		}
		else
		{
			array = new byte[num2];
		}
		return stream_1.Read(array, 0, num2) == num2 && this.method_50(Enum0.Final, Enum2.Cont, array, false);
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00023290 File Offset: 0x00021490
	private bool method_50(Enum0 enum0_0, Enum2 enum2_1, byte[] byte_1, bool bool_11)
	{
		object obj = this.object_3;
		bool flag2;
		lock (obj)
		{
			if (this.genum4_0 != GEnum4.Open)
			{
				this.gclass6_0.method_2("The connection is closing.");
				flag2 = false;
			}
			else
			{
				Class31 @class = new Class31(enum0_0, enum2_1, byte_1, bool_11, this.bool_0);
				flag2 = this.method_52(@class.method_3());
			}
		}
		return flag2;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0002330C File Offset: 0x0002150C
	private void method_51(Enum2 enum2_1, Stream stream_1, Action<bool> action_2)
	{
		GClass7.Class24 @class = new GClass7.Class24();
		@class.action_0 = action_2;
		@class.gclass7_0 = this;
		@class.func_0 = new Func<Enum2, Stream, bool>(this.method_48);
		@class.func_0.BeginInvoke(enum2_1, stream_1, new AsyncCallback(@class.method_0), null);
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0002335C File Offset: 0x0002155C
	private bool method_52(byte[] byte_1)
	{
		bool flag;
		try
		{
			this.stream_0.Write(byte_1, 0, byte_1.Length);
			return true;
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
			flag = false;
		}
		return flag;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000233BC File Offset: 0x000215BC
	private Class13 method_53()
	{
		Class12 @class = this.method_15();
		Class13 class2 = this.method_54(@class, 90000);
		if (class2.Boolean_3)
		{
			string text = class2.NameValueCollection_0["WWW-Authenticate"];
			this.gclass6_0.method_6(string.Format("Received an authentication requirement for '{0}'.", text));
			if (text.smethod_87())
			{
				this.gclass6_0.method_2("No authentication challenge is specified.");
				return class2;
			}
			this.class52_0 = Class52.smethod_4(text);
			if (this.class52_0 == null)
			{
				this.gclass6_0.method_2("An invalid authentication challenge is specified.");
				return class2;
			}
			if (this.gclass25_0 != null && (!this.bool_8 || this.class52_0.AuthenticationSchemes_0 == AuthenticationSchemes.Digest))
			{
				if (class2.Boolean_0)
				{
					this.method_44();
					this.method_57();
				}
				Class53 class3 = new Class53(this.class52_0, this.gclass25_0, this.uint_0);
				this.uint_0 = class3.UInt32_0;
				@class.NameValueCollection_0["Authorization"] = class3.ToString();
				class2 = this.method_54(@class, 15000);
			}
		}
		if (class2.Boolean_2)
		{
			string text2 = class2.NameValueCollection_0["Location"];
			this.gclass6_0.method_6(string.Format("Received a redirection to '{0}'.", text2));
			if (this.bool_2)
			{
				if (text2.smethod_87())
				{
					this.gclass6_0.method_2("No url to redirect is located.");
					return class2;
				}
				Uri uri;
				string text3;
				if (!text2.smethod_69(out uri, out text3))
				{
					this.gclass6_0.method_2("An invalid url to redirect is located: " + text3);
					return class2;
				}
				this.method_44();
				this.uri_1 = uri;
				this.bool_10 = uri.Scheme == "wss";
				this.method_57();
				return this.method_53();
			}
		}
		return class2;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00023584 File Offset: 0x00021784
	private Class13 method_54(Class12 class12_0, int int_3)
	{
		this.gclass6_0.method_1("A request to the server:\n" + class12_0.ToString());
		Class13 @class = class12_0.method_1(this.stream_0, int_3);
		this.gclass6_0.method_1("A response to this request:\n" + @class.ToString());
		return @class;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x000044A8 File Offset: 0x000026A8
	private bool method_55(Class13 class13_0)
	{
		this.gclass6_0.method_1(string.Format("A response to {0}:\n{1}", this.gclass28_0.P_m_4ACA8297, class13_0));
		return this.method_52(class13_0.method_0());
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000235DC File Offset: 0x000217DC
	private void method_56()
	{
		Class12 @class = Class12.smethod_3(this.uri_1);
		Class13 class2 = this.method_54(@class, 90000);
		if (class2.Boolean_1)
		{
			string text = class2.NameValueCollection_0["Proxy-Authenticate"];
			this.gclass6_0.method_6(string.Format("Received a proxy authentication requirement for '{0}'.", text));
			if (text.smethod_87())
			{
				throw new GException0("No proxy authentication challenge is specified.");
			}
			Class52 class3 = Class52.smethod_4(text);
			if (class3 == null)
			{
				throw new GException0("An invalid proxy authentication challenge is specified.");
			}
			if (this.gclass25_1 != null)
			{
				if (class2.Boolean_0)
				{
					this.method_44();
					this.tcpClient_0 = new TcpClient(this.uri_0.DnsSafeHost, this.uri_0.Port);
					this.stream_0 = this.tcpClient_0.GetStream();
				}
				Class53 class4 = new Class53(class3, this.gclass25_1, 0U);
				@class.NameValueCollection_0["Proxy-Authorization"] = class4.ToString();
				class2 = this.method_54(@class, 15000);
			}
			if (class2.Boolean_1)
			{
				throw new GException0("A proxy authentication is required.");
			}
		}
		if (class2.String_2[0] != '2')
		{
			throw new GException0("The proxy has failed a connection to the requested host and port.");
		}
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00023708 File Offset: 0x00021908
	private void method_57()
	{
		if (this.uri_0 != null)
		{
			this.tcpClient_0 = new TcpClient(this.uri_0.DnsSafeHost, this.uri_0.Port);
			this.stream_0 = this.tcpClient_0.GetStream();
			this.method_56();
		}
		else
		{
			this.tcpClient_0 = new TcpClient(this.uri_1.DnsSafeHost, this.uri_1.Port);
			this.stream_0 = this.tcpClient_0.GetStream();
		}
		if (this.bool_10)
		{
			GClass14 gclass = this.method_25();
			string text = gclass.String_0;
			if (text != this.uri_1.DnsSafeHost)
			{
				throw new GException0(GEnum2.TlsHandshakeFailure, "An invalid host name is specified.");
			}
			try
			{
				SslStream sslStream = new SslStream(this.stream_0, false, gclass.RemoteCertificateValidationCallback_0, gclass.LocalCertificateSelectionCallback_0);
				sslStream.AuthenticateAsClient(text, gclass.X509CertificateCollection_0, gclass.SslProtocols_0, gclass.Boolean_0);
				this.stream_0 = sslStream;
			}
			catch (Exception ex)
			{
				throw new GException0(GEnum2.TlsHandshakeFailure, ex);
			}
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00023824 File Offset: 0x00021A24
	private void method_58()
	{
		GClass7.Class25 @class = new GClass7.Class25();
		@class.gclass7_0 = this;
		if (this.queue_0.Count > 0)
		{
			this.queue_0.Clear();
		}
		this.manualResetEvent_0 = new ManualResetEvent(false);
		this.manualResetEvent_1 = new ManualResetEvent(false);
		@class.action_0 = null;
		@class.action_0 = new Action(@class.method_0);
		@class.action_0();
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000044D9 File Offset: 0x000026D9
	private bool method_59(string string_7)
	{
		return string_7 != null && string_7 == GClass7.smethod_2(this.string_0);
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00023894 File Offset: 0x00021A94
	private bool method_60(string string_7)
	{
		if (string_7 == null)
		{
			return true;
		}
		if (string_7.Length == 0)
		{
			return false;
		}
		if (!this.bool_3)
		{
			return false;
		}
		bool flag = this.compressionMethod_0 > CompressionMethod.None;
		foreach (string text in string_7.smethod_56(new char[] { ',' }))
		{
			string text2 = text.Trim();
			if (!flag || !text2.smethod_37(this.compressionMethod_0))
			{
				return false;
			}
			GClass7.Class26 @class = new GClass7.Class26();
			if (!text2.Contains("server_no_context_takeover"))
			{
				this.gclass6_0.method_2("The server hasn't sent back 'server_no_context_takeover'.");
				return false;
			}
			if (!text2.Contains("client_no_context_takeover"))
			{
				this.gclass6_0.method_6("The server hasn't sent back 'client_no_context_takeover'.");
			}
			@class.string_0 = this.compressionMethod_0.smethod_59(Array.Empty<string>());
			if (text2.smethod_56(new char[] { ';' }).smethod_18<string>(new Func<string, bool>(@class.method_0)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x000239BC File Offset: 0x00021BBC
	private bool method_61(string string_7)
	{
		GClass7.Class27 @class = new GClass7.Class27();
		@class.string_0 = string_7;
		if (@class.string_0 == null)
		{
			return !this.bool_9;
		}
		return @class.string_0.Length != 0 && this.bool_9 && this.string_5.smethod_18<string>(new Func<string, bool>(@class.method_0));
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x000044F1 File Offset: 0x000026F1
	private bool method_62(string string_7)
	{
		return string_7 == null || string_7 == "13";
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00004503 File Offset: 0x00002703
	internal void method_63(Class13 class13_0)
	{
		this.genum4_0 = GEnum4.Closing;
		this.method_55(class13_0);
		this.method_47();
		this.genum4_0 = GEnum4.Closed;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00004525 File Offset: 0x00002725
	internal void method_64(GEnum5 genum5_0)
	{
		this.method_63(this.method_14(genum5_0));
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00023A18 File Offset: 0x00021C18
	internal void method_65(Class19 class19_0, byte[] byte_1)
	{
		object obj = this.object_3;
		lock (obj)
		{
			if (this.genum4_0 == GEnum4.Closing)
			{
				this.gclass6_0.method_4("The closing is already in progress.");
				return;
			}
			if (this.genum4_0 == GEnum4.Closed)
			{
				this.gclass6_0.method_4("The connection has already been closed.");
				return;
			}
			this.genum4_0 = GEnum4.Closing;
		}
		this.gclass6_0.method_5("Begin closing the connection.");
		bool flag3;
		bool flag2 = (flag3 = byte_1 != null && this.method_52(byte_1)) && this.manualResetEvent_1 != null && this.manualResetEvent_1.WaitOne(this.timeSpan_0);
		bool flag4 = flag3 && flag2;
		this.gclass6_0.method_1(string.Format("Was clean?: {0}\n  sent: {1}\n  received: {2}", flag4, flag3, flag2));
		this.method_47();
		this.method_45();
		this.gclass6_0.method_5("End closing the connection.");
		this.genum4_0 = GEnum4.Closed;
		GEventArgs0 geventArgs = new GEventArgs0(class19_0);
		geventArgs.Boolean_0 = flag4;
		try
		{
			this.eventHandler_0.smethod_80(this, geventArgs);
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_2(ex.ToString());
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00023B7C File Offset: 0x00021D7C
	internal static string smethod_1()
	{
		byte[] array = new byte[16];
		GClass7.randomNumberGenerator_0.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00023BA4 File Offset: 0x00021DA4
	internal static string smethod_2(string string_7)
	{
		StringBuilder stringBuilder = new StringBuilder(string_7, 64);
		stringBuilder.Append("258EAFA5-E914-47DA-95CA-C5AB0DC85B11");
		return Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(stringBuilder.ToString().smethod_76()));
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00023BE0 File Offset: 0x00021DE0
	internal void method_66()
	{
		try
		{
			if (!this.method_1())
			{
				return;
			}
		}
		catch (Exception ex)
		{
			this.gclass6_0.method_3(ex.Message);
			this.gclass6_0.method_1(ex.ToString());
			string text = "An exception has occurred while attempting to accept.";
			this.method_22(text, ex);
			return;
		}
		this.genum4_0 = GEnum4.Open;
		this.method_30();
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00023C50 File Offset: 0x00021E50
	internal bool method_67(byte[] byte_1, TimeSpan timeSpan_1)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			return false;
		}
		ManualResetEvent manualResetEvent = this.manualResetEvent_0;
		if (manualResetEvent == null)
		{
			return false;
		}
		object obj = this.object_1;
		bool flag3;
		lock (obj)
		{
			try
			{
				manualResetEvent.Reset();
				object obj2 = this.object_3;
				lock (obj2)
				{
					if (this.genum4_0 != GEnum4.Open)
					{
						return false;
					}
					if (!this.method_52(byte_1))
					{
						return false;
					}
				}
				flag3 = manualResetEvent.WaitOne(timeSpan_1);
			}
			catch (ObjectDisposedException)
			{
				flag3 = false;
			}
		}
		return flag3;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00023D10 File Offset: 0x00021F10
	internal void method_68(Enum2 enum2_1, byte[] byte_1, Dictionary<CompressionMethod, byte[]> dictionary_0)
	{
		object obj = this.object_2;
		lock (obj)
		{
			object obj2 = this.object_3;
			lock (obj2)
			{
				if (this.genum4_0 != GEnum4.Open)
				{
					this.gclass6_0.method_2("The connection is closing.");
				}
				else
				{
					byte[] array;
					if (!dictionary_0.TryGetValue(this.compressionMethod_0, out array))
					{
						array = new Class31(Enum0.Final, enum2_1, byte_1.smethod_12(this.compressionMethod_0), this.compressionMethod_0 > CompressionMethod.None, false).method_3();
						dictionary_0.Add(this.compressionMethod_0, array);
					}
					this.method_52(array);
				}
			}
		}
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00023DDC File Offset: 0x00021FDC
	internal void method_69(Enum2 enum2_1, Stream stream_1, Dictionary<CompressionMethod, Stream> dictionary_0)
	{
		object obj = this.object_2;
		lock (obj)
		{
			Stream stream;
			if (!dictionary_0.TryGetValue(this.compressionMethod_0, out stream))
			{
				stream = stream_1.smethod_13(this.compressionMethod_0);
				dictionary_0.Add(this.compressionMethod_0, stream);
			}
			else
			{
				stream.Position = 0L;
			}
			this.method_49(enum2_1, stream, this.compressionMethod_0 > CompressionMethod.None);
		}
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00023E64 File Offset: 0x00022064
	public void method_70()
	{
		if (this.bool_0)
		{
			throw new InvalidOperationException("This instance is a client.");
		}
		if (this.genum4_0 == GEnum4.Closing)
		{
			throw new InvalidOperationException("The close process is in progress.");
		}
		if (this.genum4_0 == GEnum4.Closed)
		{
			throw new InvalidOperationException("The connection has already been closed.");
		}
		if (this.method_0())
		{
			this.method_30();
		}
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00023EC0 File Offset: 0x000220C0
	public void method_71()
	{
		GClass7.Class28 @class = new GClass7.Class28();
		@class.gclass7_0 = this;
		if (this.bool_0)
		{
			throw new InvalidOperationException("This instance is a client.");
		}
		if (this.genum4_0 == GEnum4.Closing)
		{
			throw new InvalidOperationException("The close process is in progress.");
		}
		if (this.genum4_0 == GEnum4.Closed)
		{
			throw new InvalidOperationException("The connection has already been closed.");
		}
		@class.func_0 = new Func<bool>(this.method_0);
		@class.func_0.BeginInvoke(new AsyncCallback(@class.method_0), null);
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00004534 File Offset: 0x00002734
	public void method_72()
	{
		this.method_6(1005, string.Empty);
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00023F44 File Offset: 0x00022144
	public void method_73(ushort ushort_0)
	{
		if (!ushort_0.smethod_83())
		{
			string text = "Less than 1000 or greater than 4999.";
			throw new ArgumentOutOfRangeException("code", text);
		}
		if (this.bool_0 && ushort_0 == 1011)
		{
			throw new ArgumentException("1011 cannot be used.", "code");
		}
		if (!this.bool_0 && ushort_0 == 1010)
		{
			throw new ArgumentException("1010 cannot be used.", "code");
		}
		this.method_6(ushort_0, string.Empty);
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00023FB8 File Offset: 0x000221B8
	public void method_74(GEnum2 genum2_0)
	{
		if (this.bool_0 && genum2_0 == GEnum2.ServerError)
		{
			throw new ArgumentException("ServerError cannot be used.", "code");
		}
		if (!this.bool_0 && genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		this.method_6((ushort)genum2_0, string.Empty);
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00024014 File Offset: 0x00022214
	public void method_75(ushort ushort_0, string string_7)
	{
		if (!ushort_0.smethod_83())
		{
			string text = "Less than 1000 or greater than 4999.";
			throw new ArgumentOutOfRangeException("code", text);
		}
		if (this.bool_0 && ushort_0 == 1011)
		{
			throw new ArgumentException("1011 cannot be used.", "code");
		}
		if (!this.bool_0 && ushort_0 == 1010)
		{
			throw new ArgumentException("1010 cannot be used.", "code");
		}
		if (string_7.smethod_87())
		{
			this.method_6(ushort_0, string.Empty);
			return;
		}
		if (ushort_0 == 1005)
		{
			throw new ArgumentException("1005 cannot be used.", "code");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
		}
		if (array.Length > 123)
		{
			string text2 = "Its size is greater than 123 bytes.";
			throw new ArgumentOutOfRangeException("reason", text2);
		}
		this.method_6(ushort_0, string_7);
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x000240E4 File Offset: 0x000222E4
	public void method_76(GEnum2 genum2_0, string string_7)
	{
		if (this.bool_0 && genum2_0 == GEnum2.ServerError)
		{
			throw new ArgumentException("ServerError cannot be used.", "code");
		}
		if (!this.bool_0 && genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		if (string_7.smethod_87())
		{
			this.method_6((ushort)genum2_0, string.Empty);
			return;
		}
		if (genum2_0 == GEnum2.NoStatus)
		{
			throw new ArgumentException("NoStatus cannot be used.", "code");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
		}
		if (array.Length > 123)
		{
			string text = "Its size is greater than 123 bytes.";
			throw new ArgumentOutOfRangeException("reason", text);
		}
		this.method_6((ushort)genum2_0, string_7);
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00004546 File Offset: 0x00002746
	public void method_77()
	{
		this.method_8(1005, string.Empty);
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0002419C File Offset: 0x0002239C
	public void method_78(ushort ushort_0)
	{
		if (!ushort_0.smethod_83())
		{
			string text = "Less than 1000 or greater than 4999.";
			throw new ArgumentOutOfRangeException("code", text);
		}
		if (this.bool_0 && ushort_0 == 1011)
		{
			throw new ArgumentException("1011 cannot be used.", "code");
		}
		if (!this.bool_0 && ushort_0 == 1010)
		{
			throw new ArgumentException("1010 cannot be used.", "code");
		}
		this.method_8(ushort_0, string.Empty);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00024210 File Offset: 0x00022410
	public void method_79(GEnum2 genum2_0)
	{
		if (this.bool_0 && genum2_0 == GEnum2.ServerError)
		{
			throw new ArgumentException("ServerError cannot be used.", "code");
		}
		if (!this.bool_0 && genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		this.method_8((ushort)genum2_0, string.Empty);
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0002426C File Offset: 0x0002246C
	public void method_80(ushort ushort_0, string string_7)
	{
		if (!ushort_0.smethod_83())
		{
			string text = "Less than 1000 or greater than 4999.";
			throw new ArgumentOutOfRangeException("code", text);
		}
		if (this.bool_0 && ushort_0 == 1011)
		{
			throw new ArgumentException("1011 cannot be used.", "code");
		}
		if (!this.bool_0 && ushort_0 == 1010)
		{
			throw new ArgumentException("1010 cannot be used.", "code");
		}
		if (string_7.smethod_87())
		{
			this.method_8(ushort_0, string.Empty);
			return;
		}
		if (ushort_0 == 1005)
		{
			throw new ArgumentException("1005 cannot be used.", "code");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
		}
		if (array.Length > 123)
		{
			string text2 = "Its size is greater than 123 bytes.";
			throw new ArgumentOutOfRangeException("reason", text2);
		}
		this.method_8(ushort_0, string_7);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0002433C File Offset: 0x0002253C
	public void method_81(GEnum2 genum2_0, string string_7)
	{
		if (this.bool_0 && genum2_0 == GEnum2.ServerError)
		{
			throw new ArgumentException("ServerError cannot be used.", "code");
		}
		if (!this.bool_0 && genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		if (string_7.smethod_87())
		{
			this.method_8((ushort)genum2_0, string.Empty);
			return;
		}
		if (genum2_0 == GEnum2.NoStatus)
		{
			throw new ArgumentException("NoStatus cannot be used.", "code");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
		}
		if (array.Length > 123)
		{
			string text = "Its size is greater than 123 bytes.";
			throw new ArgumentOutOfRangeException("reason", text);
		}
		this.method_8((ushort)genum2_0, string_7);
	}

	// Token: 0x060001FA RID: 506 RVA: 0x000243F4 File Offset: 0x000225F4
	public void method_82()
	{
		if (!this.bool_0)
		{
			throw new InvalidOperationException("This instance is not a client.");
		}
		if (this.genum4_0 == GEnum4.Closing)
		{
			throw new InvalidOperationException("The close process is in progress.");
		}
		if (this.int_1 > GClass7.int_0)
		{
			throw new InvalidOperationException("A series of reconnecting has failed.");
		}
		if (this.method_12())
		{
			this.method_30();
		}
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00024450 File Offset: 0x00022650
	public void method_83()
	{
		GClass7.Class29 @class = new GClass7.Class29();
		@class.gclass7_0 = this;
		if (!this.bool_0)
		{
			throw new InvalidOperationException("This instance is not a client.");
		}
		if (this.genum4_0 == GEnum4.Closing)
		{
			throw new InvalidOperationException("The close process is in progress.");
		}
		if (this.int_1 > GClass7.int_0)
		{
			throw new InvalidOperationException("A series of reconnecting has failed.");
		}
		@class.func_0 = new Func<bool>(this.method_12);
		@class.func_0.BeginInvoke(new AsyncCallback(@class.method_0), null);
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00004230 File Offset: 0x00002430
	public bool method_84()
	{
		return this.method_31(GClass7.byte_0);
	}

	// Token: 0x060001FD RID: 509 RVA: 0x000244D8 File Offset: 0x000226D8
	public bool method_85(string string_7)
	{
		if (string_7.smethod_87())
		{
			return this.method_31(GClass7.byte_0);
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "message");
		}
		if (array.Length > 125)
		{
			string text = "Its size is greater than 125 bytes.";
			throw new ArgumentOutOfRangeException("message", text);
		}
		return this.method_31(array);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00004558 File Offset: 0x00002758
	public void method_86(byte[] byte_1)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("data");
		}
		this.method_48(Enum2.Binary, new MemoryStream(byte_1));
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00024534 File Offset: 0x00022734
	public void method_87(FileInfo fileInfo_0)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (fileInfo_0 == null)
		{
			throw new ArgumentNullException("fileInfo");
		}
		if (!fileInfo_0.Exists)
		{
			throw new ArgumentException("The file does not exist.", "fileInfo");
		}
		FileStream fileStream;
		if (!fileInfo_0.smethod_72(out fileStream))
		{
			throw new ArgumentException("The file could not be opened.", "fileInfo");
		}
		this.method_48(Enum2.Binary, fileStream);
	}

	// Token: 0x06000200 RID: 512 RVA: 0x000245A0 File Offset: 0x000227A0
	public void method_88(string string_7)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (string_7 == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "data");
		}
		this.method_48(Enum2.Text, new MemoryStream(array));
	}

	// Token: 0x06000201 RID: 513 RVA: 0x000245FC File Offset: 0x000227FC
	public void method_89(Stream stream_1, int int_3)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (stream_1 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream_1.CanRead)
		{
			throw new ArgumentException("It cannot be read.", "stream");
		}
		if (int_3 < 1)
		{
			throw new ArgumentException("Less than 1.", "length");
		}
		byte[] array = stream_1.smethod_51(int_3);
		int num = array.Length;
		if (num == 0)
		{
			throw new ArgumentException("No data could be read from it.", "stream");
		}
		if (num < int_3)
		{
			this.gclass6_0.method_6(string.Format("Only {0} byte(s) of data could be read from the stream.", num));
		}
		this.method_48(Enum2.Binary, new MemoryStream(array));
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000458C File Offset: 0x0000278C
	public void method_90(byte[] byte_1, Action<bool> action_2)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("data");
		}
		this.method_51(Enum2.Binary, new MemoryStream(byte_1), action_2);
	}

	// Token: 0x06000203 RID: 515 RVA: 0x000246A8 File Offset: 0x000228A8
	public void method_91(FileInfo fileInfo_0, Action<bool> action_2)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (fileInfo_0 == null)
		{
			throw new ArgumentNullException("fileInfo");
		}
		if (!fileInfo_0.Exists)
		{
			throw new ArgumentException("The file does not exist.", "fileInfo");
		}
		FileStream fileStream;
		if (!fileInfo_0.smethod_72(out fileStream))
		{
			throw new ArgumentException("The file could not be opened.", "fileInfo");
		}
		this.method_51(Enum2.Binary, fileStream, action_2);
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00024714 File Offset: 0x00022914
	public void method_92(string string_7, Action<bool> action_2)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (string_7 == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array;
		if (!string_7.smethod_71(out array))
		{
			throw new ArgumentException("It could not be UTF-8-encoded.", "data");
		}
		this.method_51(Enum2.Text, new MemoryStream(array), action_2);
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00024770 File Offset: 0x00022970
	public void method_93(Stream stream_1, int int_3, Action<bool> action_2)
	{
		if (this.genum4_0 != GEnum4.Open)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		if (stream_1 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream_1.CanRead)
		{
			throw new ArgumentException("It cannot be read.", "stream");
		}
		if (int_3 < 1)
		{
			throw new ArgumentException("Less than 1.", "length");
		}
		byte[] array = stream_1.smethod_51(int_3);
		int num = array.Length;
		if (num == 0)
		{
			throw new ArgumentException("No data could be read from it.", "stream");
		}
		if (num < int_3)
		{
			this.gclass6_0.method_6(string.Format("Only {0} byte(s) of data could be read from the stream.", num));
		}
		this.method_51(Enum2.Binary, new MemoryStream(array), action_2);
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0002481C File Offset: 0x00022A1C
	public void method_94(GClass15 gclass15_0)
	{
		string text = null;
		if (!this.bool_0)
		{
			text = "This instance is not a client.";
			throw new InvalidOperationException(text);
		}
		if (gclass15_0 == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (!this.method_2(out text))
		{
			this.gclass6_0.method_6(text);
			return;
		}
		object obj = this.object_3;
		lock (obj)
		{
			if (this.method_2(out text))
			{
				object syncRoot = this.gclass16_0.SyncRoot;
				lock (syncRoot)
				{
					this.gclass16_0.method_1(gclass15_0);
					return;
				}
			}
			this.gclass6_0.method_6(text);
		}
	}

	// Token: 0x06000207 RID: 519 RVA: 0x000248E8 File Offset: 0x00022AE8
	public void method_95(string string_7, string string_8, bool bool_11)
	{
		string text = null;
		if (!this.bool_0)
		{
			text = "This instance is not a client.";
			throw new InvalidOperationException(text);
		}
		if (!string_7.smethod_87() && (string_7.smethod_15(new char[] { ':' }) || !string_7.smethod_47()))
		{
			text = "It contains an invalid character.";
			throw new ArgumentException(text, "username");
		}
		if (!string_8.smethod_87() && !string_8.smethod_47())
		{
			text = "It contains an invalid character.";
			throw new ArgumentException(text, "password");
		}
		if (!this.method_2(out text))
		{
			this.gclass6_0.method_6(text);
			return;
		}
		object obj = this.object_3;
		lock (obj)
		{
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
			}
			else if (string_7.smethod_87())
			{
				this.gclass25_0 = null;
				this.bool_8 = false;
			}
			else
			{
				this.gclass25_0 = new GClass25(string_7, string_8, this.uri_1.PathAndQuery, Array.Empty<string>());
				this.bool_8 = bool_11;
			}
		}
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00024A00 File Offset: 0x00022C00
	public void method_96(string string_7, string string_8, string string_9)
	{
		string text = null;
		if (!this.bool_0)
		{
			text = "This instance is not a client.";
			throw new InvalidOperationException(text);
		}
		Uri uri = null;
		if (!string_7.smethod_87())
		{
			if (!Uri.TryCreate(string_7, UriKind.Absolute, out uri))
			{
				text = "Not an absolute URI string.";
				throw new ArgumentException(text, "url");
			}
			if (uri.Scheme != "http")
			{
				text = "The scheme part is not http.";
				throw new ArgumentException(text, "url");
			}
			if (uri.Segments.Length > 1)
			{
				text = "It includes the path segments.";
				throw new ArgumentException(text, "url");
			}
		}
		if (!string_8.smethod_87() && (string_8.smethod_15(new char[] { ':' }) || !string_8.smethod_47()))
		{
			text = "It contains an invalid character.";
			throw new ArgumentException(text, "username");
		}
		if (!string_9.smethod_87() && !string_9.smethod_47())
		{
			text = "It contains an invalid character.";
			throw new ArgumentException(text, "password");
		}
		if (!this.method_2(out text))
		{
			this.gclass6_0.method_6(text);
			return;
		}
		object obj = this.object_3;
		lock (obj)
		{
			if (!this.method_2(out text))
			{
				this.gclass6_0.method_6(text);
			}
			else if (string_7.smethod_87())
			{
				this.uri_0 = null;
				this.gclass25_1 = null;
			}
			else
			{
				this.uri_0 = uri;
				this.gclass25_1 = ((!string_8.smethod_87()) ? new GClass25(string_8, string_9, string.Format("{0}:{1}", this.uri_1.DnsSafeHost, this.uri_1.Port), Array.Empty<string>()) : null);
			}
		}
	}

	// Token: 0x06000209 RID: 521 RVA: 0x000045C0 File Offset: 0x000027C0
	public void Dispose()
	{
		this.method_6(1001, string.Empty);
	}

	// Token: 0x0600020A RID: 522 RVA: 0x000045D2 File Offset: 0x000027D2
	[CompilerGenerated]
	private void method_97(IAsyncResult iasyncResult_0)
	{
		this.action_1.EndInvoke(iasyncResult_0);
	}

	// Token: 0x0600020B RID: 523 RVA: 0x000045E0 File Offset: 0x000027E0
	[CompilerGenerated]
	private bool method_98(string string_7)
	{
		return string_7 == this.string_4;
	}

	// Token: 0x040000EB RID: 235
	private Class52 class52_0;

	// Token: 0x040000EC RID: 236
	private string string_0;

	// Token: 0x040000ED RID: 237
	private bool bool_0;

	// Token: 0x040000EE RID: 238
	private Action action_0;

	// Token: 0x040000EF RID: 239
	private CompressionMethod compressionMethod_0;

	// Token: 0x040000F0 RID: 240
	private GClass28 gclass28_0;

	// Token: 0x040000F1 RID: 241
	private GClass16 gclass16_0;

	// Token: 0x040000F2 RID: 242
	private GClass25 gclass25_0;

	// Token: 0x040000F3 RID: 243
	private bool bool_1;

	// Token: 0x040000F4 RID: 244
	private bool bool_2;

	// Token: 0x040000F5 RID: 245
	private string string_1;

	// Token: 0x040000F6 RID: 246
	private bool bool_3;

	// Token: 0x040000F7 RID: 247
	private object object_0;

	// Token: 0x040000F8 RID: 248
	private object object_1;

	// Token: 0x040000F9 RID: 249
	private object object_2;

	// Token: 0x040000FA RID: 250
	private object object_3;

	// Token: 0x040000FB RID: 251
	private MemoryStream memoryStream_0;

	// Token: 0x040000FC RID: 252
	private bool bool_4;

	// Token: 0x040000FD RID: 253
	private Enum2 enum2_0;

	// Token: 0x040000FE RID: 254
	private const string string_2 = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

	// Token: 0x040000FF RID: 255
	private Func<GClass28, string> func_0;

	// Token: 0x04000100 RID: 256
	private bool bool_5;

	// Token: 0x04000101 RID: 257
	private bool bool_6;

	// Token: 0x04000102 RID: 258
	private volatile bool bool_7;

	// Token: 0x04000103 RID: 259
	private volatile GClass6 gclass6_0;

	// Token: 0x04000104 RID: 260
	private static readonly int int_0 = 10;

	// Token: 0x04000105 RID: 261
	private Action<GEventArgs2> action_1;

	// Token: 0x04000106 RID: 262
	private Queue<GEventArgs2> queue_0;

	// Token: 0x04000107 RID: 263
	private uint uint_0;

	// Token: 0x04000108 RID: 264
	private string string_3;

	// Token: 0x04000109 RID: 265
	private ManualResetEvent manualResetEvent_0;

	// Token: 0x0400010A RID: 266
	private bool bool_8;

	// Token: 0x0400010B RID: 267
	private string string_4;

	// Token: 0x0400010C RID: 268
	private string[] string_5;

	// Token: 0x0400010D RID: 269
	private bool bool_9;

	// Token: 0x0400010E RID: 270
	private GClass25 gclass25_1;

	// Token: 0x0400010F RID: 271
	private Uri uri_0;

	// Token: 0x04000110 RID: 272
	private volatile GEnum4 genum4_0;

	// Token: 0x04000111 RID: 273
	private ManualResetEvent manualResetEvent_1;

	// Token: 0x04000112 RID: 274
	private int int_1;

	// Token: 0x04000113 RID: 275
	private bool bool_10;

	// Token: 0x04000114 RID: 276
	private GClass14 gclass14_0;

	// Token: 0x04000115 RID: 277
	private Stream stream_0;

	// Token: 0x04000116 RID: 278
	private TcpClient tcpClient_0;

	// Token: 0x04000117 RID: 279
	private Uri uri_1;

	// Token: 0x04000118 RID: 280
	private const string string_6 = "13";

	// Token: 0x04000119 RID: 281
	private TimeSpan timeSpan_0;

	// Token: 0x0400011A RID: 282
	internal static readonly byte[] byte_0 = new byte[0];

	// Token: 0x0400011B RID: 283
	internal static readonly int int_2 = 1016;

	// Token: 0x0400011C RID: 284
	internal static readonly RandomNumberGenerator randomNumberGenerator_0 = new RNGCryptoServiceProvider();

	// Token: 0x0400011D RID: 285
	[CompilerGenerated]
	private EventHandler<GEventArgs0> eventHandler_0;

	// Token: 0x0400011E RID: 286
	[CompilerGenerated]
	private EventHandler<GEventArgs1> eventHandler_1;

	// Token: 0x0400011F RID: 287
	[CompilerGenerated]
	private EventHandler<GEventArgs2> eventHandler_2;

	// Token: 0x04000120 RID: 288
	[CompilerGenerated]
	private EventHandler eventHandler_3;

	// Token: 0x02000030 RID: 48
	[CompilerGenerated]
	[Serializable]
	private sealed class Class21
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000045FA File Offset: 0x000027FA
		internal bool method_0(string string_0)
		{
			return string_0.smethod_87() || !string_0.smethod_48();
		}

		// Token: 0x04000121 RID: 289
		public static readonly GClass7.Class21 f_76642BEE = new GClass7.Class21();

		// Token: 0x04000122 RID: 290
		public static Func<string, bool> f_5C19FFC9;
	}

	// Token: 0x02000031 RID: 49
	[CompilerGenerated]
	private sealed class Class22
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0000460F File Offset: 0x0000280F
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			this.action_0.EndInvoke(iasyncResult_0);
		}

		// Token: 0x04000123 RID: 291
		public Action<Class19, bool, bool, bool> action_0;
	}

	// Token: 0x02000032 RID: 50
	[CompilerGenerated]
	private sealed class Class23
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0000461D File Offset: 0x0000281D
		internal void method_0(object object_0)
		{
			this.gclass7_0.method_29(this.geventArgs2_0);
		}

		// Token: 0x04000124 RID: 292
		public GClass7 gclass7_0;

		// Token: 0x04000125 RID: 293
		public GEventArgs2 geventArgs2_0;
	}

	// Token: 0x02000033 RID: 51
	[CompilerGenerated]
	private sealed class Class24
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00024BA4 File Offset: 0x00022DA4
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				bool flag = this.func_0.EndInvoke(iasyncResult_0);
				if (this.action_0 != null)
				{
					this.action_0(flag);
				}
			}
			catch (Exception ex)
			{
				this.gclass7_0.gclass6_0.method_2(ex.ToString());
				this.gclass7_0.method_21("An error has occurred during the callback for an async send.", ex);
			}
		}

		// Token: 0x04000126 RID: 294
		public Func<Enum2, Stream, bool> func_0;

		// Token: 0x04000127 RID: 295
		public Action<bool> action_0;

		// Token: 0x04000128 RID: 296
		public GClass7 gclass7_0;
	}

	// Token: 0x02000034 RID: 52
	[CompilerGenerated]
	private sealed class Class25
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00024C10 File Offset: 0x00022E10
		internal void method_0()
		{
			Stream stream_ = this.gclass7_0.stream_0;
			bool flag = false;
			Action<Class31> action;
			if ((action = this.action_1) == null)
			{
				action = (this.action_1 = new Action<Class31>(this.method_1));
			}
			Action<Exception> action2;
			if ((action2 = this.action_2) == null)
			{
				action2 = (this.action_2 = new Action<Exception>(this.method_2));
			}
			Class31.smethod_17(stream_, flag, action, action2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00024C6C File Offset: 0x00022E6C
		internal void method_1(Class31 class31_0)
		{
			if (this.gclass7_0.method_38(class31_0))
			{
				if (this.gclass7_0.genum4_0 != GEnum4.Closed)
				{
					this.action_0();
					if (!this.gclass7_0.bool_7 && this.gclass7_0.Boolean_0)
					{
						if (this.gclass7_0.genum4_0 == GEnum4.Open)
						{
							this.gclass7_0.method_27();
							return;
						}
					}
					return;
				}
			}
			ManualResetEvent manualResetEvent_ = this.gclass7_0.manualResetEvent_1;
			if (manualResetEvent_ != null)
			{
				manualResetEvent_.Set();
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00004630 File Offset: 0x00002830
		internal void method_2(Exception exception_0)
		{
			this.gclass7_0.gclass6_0.method_3(exception_0.ToString());
			this.gclass7_0.method_22("An exception has occurred while receiving.", exception_0);
		}

		// Token: 0x04000129 RID: 297
		public GClass7 gclass7_0;

		// Token: 0x0400012A RID: 298
		public Action action_0;

		// Token: 0x0400012B RID: 299
		public Action<Class31> action_1;

		// Token: 0x0400012C RID: 300
		public Action<Exception> action_2;
	}

	// Token: 0x02000035 RID: 53
	[CompilerGenerated]
	private sealed class Class26
	{
		// Token: 0x0600021A RID: 538 RVA: 0x0000465B File Offset: 0x0000285B
		internal bool method_0(string string_1)
		{
			string_1 = string_1.Trim();
			return string_1 != this.string_0 && string_1 != "server_no_context_takeover" && string_1 != "client_no_context_takeover";
		}

		// Token: 0x0400012D RID: 301
		public string string_0;
	}

	// Token: 0x02000036 RID: 54
	[CompilerGenerated]
	private sealed class Class27
	{
		// Token: 0x0600021C RID: 540 RVA: 0x0000468D File Offset: 0x0000288D
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x0400012E RID: 302
		public string string_0;
	}

	// Token: 0x02000037 RID: 55
	[CompilerGenerated]
	private sealed class Class28
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0000469B File Offset: 0x0000289B
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			if (this.func_0.EndInvoke(iasyncResult_0))
			{
				this.gclass7_0.method_30();
			}
		}

		// Token: 0x0400012F RID: 303
		public Func<bool> func_0;

		// Token: 0x04000130 RID: 304
		public GClass7 gclass7_0;
	}

	// Token: 0x02000038 RID: 56
	[CompilerGenerated]
	private sealed class Class29
	{
		// Token: 0x06000220 RID: 544 RVA: 0x000046B6 File Offset: 0x000028B6
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			if (this.func_0.EndInvoke(iasyncResult_0))
			{
				this.gclass7_0.method_30();
			}
		}

		// Token: 0x04000131 RID: 305
		public Func<bool> func_0;

		// Token: 0x04000132 RID: 306
		public GClass7 gclass7_0;
	}

	// Token: 0x02000039 RID: 57
	[CompilerGenerated]
	private sealed class Class30 : IEnumerable<GClass15>, IEnumerator<GClass15>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06000221 RID: 545 RVA: 0x000046D1 File Offset: 0x000028D1
		[DebuggerHidden]
		public Class30(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00024CF8 File Offset: 0x00022EF8
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num - -4 <= 1 || num == 1)
			{
				try
				{
					if (num == -4 || num == 1)
					{
						try
						{
						}
						finally
						{
							this.method_1();
						}
					}
				}
				finally
				{
					this.method_0();
				}
			}
			this.object_0 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00024D68 File Offset: 0x00022F68
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				GClass7 gclass = this.gclass7_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -4;
				}
				else
				{
					this.int_0 = -1;
					this.object_0 = gclass.gclass16_0.SyncRoot;
					this.bool_0 = false;
					this.int_0 = -3;
					Monitor.Enter(this.object_0, ref this.bool_0);
					this.ienumerator_0 = gclass.gclass16_0.GetEnumerator();
					this.int_0 = -4;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_1();
					this.ienumerator_0 = null;
					this.method_0();
					this.object_0 = null;
					flag = false;
				}
				else
				{
					GClass15 gclass2 = (GClass15)this.ienumerator_0.Current;
					this.gclass15_0 = gclass2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000046EB File Offset: 0x000028EB
		private void method_0()
		{
			this.int_0 = -1;
			if (this.bool_0)
			{
				Monitor.Exit(this.object_0);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00024E54 File Offset: 0x00023054
		private void method_1()
		{
			this.int_0 = -3;
			IDisposable disposable = this.ienumerator_0 as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00004707 File Offset: 0x00002907
		public GClass15 Current
		{
			[DebuggerHidden]
			get
			{
				return this.gclass15_0;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00004707 File Offset: 0x00002907
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gclass15_0;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00024E80 File Offset: 0x00023080
		[DebuggerHidden]
		public IEnumerator<GClass15> GetEnumerator()
		{
			GClass7.Class30 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass7.Class30(0);
				@class.gclass7_0 = this.gclass7_0;
			}
			return @class;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000470F File Offset: 0x0000290F
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000133 RID: 307
		private int int_0;

		// Token: 0x04000134 RID: 308
		private GClass15 gclass15_0;

		// Token: 0x04000135 RID: 309
		private int int_1;

		// Token: 0x04000136 RID: 310
		public GClass7 gclass7_0;

		// Token: 0x04000137 RID: 311
		private object object_0;

		// Token: 0x04000138 RID: 312
		private bool bool_0;

		// Token: 0x04000139 RID: 313
		private IEnumerator ienumerator_0;
	}
}
