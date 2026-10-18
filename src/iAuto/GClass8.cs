using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using WebSocketSharp.Net;

// Token: 0x02000046 RID: 70
public class GClass8
{
	// Token: 0x0600028A RID: 650 RVA: 0x00004BAE File Offset: 0x00002DAE
	public GClass8()
	{
		this.method_4("*", IPAddress.Any, 80, false);
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00004BC9 File Offset: 0x00002DC9
	public GClass8(int int_1)
		: this(int_1, int_1 == 443)
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00025B60 File Offset: 0x00023D60
	public GClass8(string string_2)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string_2.Length == 0)
		{
			throw new ArgumentException("An empty string.", "url");
		}
		Uri uri;
		string text;
		if (!GClass8.smethod_1(string_2, out uri, out text))
		{
			throw new ArgumentException(text, "url");
		}
		string text2 = uri.smethod_30(true);
		IPAddress ipaddress = text2.smethod_60();
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
		this.method_4(text2, ipaddress, uri.Port, uri.Scheme == "https");
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00025C10 File Offset: 0x00023E10
	public GClass8(int int_1, bool bool_1)
	{
		if (!int_1.smethod_43())
		{
			string text = "Less than 1 or greater than 65535.";
			throw new ArgumentOutOfRangeException("port", text);
		}
		this.method_4("*", IPAddress.Any, int_1, bool_1);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00004BDA File Offset: 0x00002DDA
	public GClass8(IPAddress ipaddress_1, int int_1)
		: this(ipaddress_1, int_1, int_1 == 443)
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00025C50 File Offset: 0x00023E50
	public GClass8(IPAddress ipaddress_1, int int_1, bool bool_1)
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
		this.method_4(ipaddress_1.smethod_62(true), ipaddress_1, int_1, bool_1);
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000290 RID: 656 RVA: 0x00004BEC File Offset: 0x00002DEC
	public IPAddress IPAddress_0
	{
		get
		{
			return this.ipaddress_0;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000291 RID: 657 RVA: 0x00004BF4 File Offset: 0x00002DF4
	// (set) Token: 0x06000292 RID: 658 RVA: 0x00025CB4 File Offset: 0x00023EB4
	public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes_0
	{
		get
		{
			return this.gclass19_0.AuthenticationSchemes_0;
		}
		set
		{
			string text;
			if (!this.method_1(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_1(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.gclass19_0.AuthenticationSchemes_0 = value;
				}
			}
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000293 RID: 659 RVA: 0x00004C01 File Offset: 0x00002E01
	// (set) Token: 0x06000294 RID: 660 RVA: 0x00025D2C File Offset: 0x00023F2C
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("An empty string.", "value");
			}
			value = value.smethod_67();
			string text = null;
			try
			{
				text = Path.GetFullPath(value);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("An invalid path string.", "value", ex);
			}
			if (value == "/")
			{
				throw new ArgumentException("An absolute root.", "value");
			}
			if (value == "\\")
			{
				throw new ArgumentException("An absolute root.", "value");
			}
			if (value.Length == 2 && value[1] == ':')
			{
				throw new ArgumentException("An absolute root.", "value");
			}
			if (text == "/")
			{
				throw new ArgumentException("An absolute root.", "value");
			}
			text = text.smethod_67();
			if (text.Length == 2 && text[1] == ':')
			{
				throw new ArgumentException("An absolute root.", "value");
			}
			string text2;
			if (!this.method_1(out text2))
			{
				this.gclass6_0.method_6(text2);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_1(out text2))
				{
					this.gclass6_0.method_6(text2);
				}
				else
				{
					this.string_0 = value;
				}
			}
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000295 RID: 661 RVA: 0x00004C09 File Offset: 0x00002E09
	public bool Boolean_0
	{
		get
		{
			return this.enum4_0 == Enum4.Start;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000296 RID: 662 RVA: 0x00004C16 File Offset: 0x00002E16
	public bool Boolean_1
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000297 RID: 663 RVA: 0x00004C1E File Offset: 0x00002E1E
	// (set) Token: 0x06000298 RID: 664 RVA: 0x00004C2B File Offset: 0x00002E2B
	public bool Boolean_2
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

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000299 RID: 665 RVA: 0x00004C39 File Offset: 0x00002E39
	public GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600029A RID: 666 RVA: 0x00004C41 File Offset: 0x00002E41
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600029B RID: 667 RVA: 0x00004C49 File Offset: 0x00002E49
	// (set) Token: 0x0600029C RID: 668 RVA: 0x00025E9C File Offset: 0x0002409C
	public string String_1
	{
		get
		{
			return this.gclass19_0.String_1;
		}
		set
		{
			string text;
			if (!this.method_1(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_1(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.gclass19_0.String_1 = value;
				}
			}
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600029D RID: 669 RVA: 0x00004C56 File Offset: 0x00002E56
	// (set) Token: 0x0600029E RID: 670 RVA: 0x00025F14 File Offset: 0x00024114
	public bool Boolean_3
	{
		get
		{
			return this.gclass19_0.Boolean_1;
		}
		set
		{
			string text;
			if (!this.method_1(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_1(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.gclass19_0.Boolean_1 = value;
				}
			}
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600029F RID: 671 RVA: 0x00004C63 File Offset: 0x00002E63
	public GClass26 GClass26_0
	{
		get
		{
			if (!this.bool_0)
			{
				throw new InvalidOperationException("This instance does not provide secure connections.");
			}
			return this.gclass19_0.GClass26_0;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060002A0 RID: 672 RVA: 0x00004C83 File Offset: 0x00002E83
	// (set) Token: 0x060002A1 RID: 673 RVA: 0x00025F8C File Offset: 0x0002418C
	public Func<IIdentity, GClass25> Func_0
	{
		get
		{
			return this.gclass19_0.Func_1;
		}
		set
		{
			string text;
			if (!this.method_1(out text))
			{
				this.gclass6_0.method_6(text);
				return;
			}
			object obj = this.object_0;
			lock (obj)
			{
				if (!this.method_1(out text))
				{
					this.gclass6_0.method_6(text);
				}
				else
				{
					this.gclass19_0.Func_1 = value;
				}
			}
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060002A2 RID: 674 RVA: 0x00004C90 File Offset: 0x00002E90
	// (set) Token: 0x060002A3 RID: 675 RVA: 0x00004C9D File Offset: 0x00002E9D
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

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x00004CAB File Offset: 0x00002EAB
	public GClass12 GClass12_0
	{
		get
		{
			return this.gclass12_0;
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x060002A5 RID: 677 RVA: 0x00026004 File Offset: 0x00024204
	// (remove) Token: 0x060002A6 RID: 678 RVA: 0x0002603C File Offset: 0x0002423C
	public event EventHandler<GEventArgs3> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x060002A7 RID: 679 RVA: 0x00026074 File Offset: 0x00024274
	// (remove) Token: 0x060002A8 RID: 680 RVA: 0x000260AC File Offset: 0x000242AC
	public event EventHandler<GEventArgs3> Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_1;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_1;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060002A9 RID: 681 RVA: 0x000260E4 File Offset: 0x000242E4
	// (remove) Token: 0x060002AA RID: 682 RVA: 0x0002611C File Offset: 0x0002431C
	public event EventHandler<GEventArgs3> Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_2;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_2;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x060002AB RID: 683 RVA: 0x00026154 File Offset: 0x00024354
	// (remove) Token: 0x060002AC RID: 684 RVA: 0x0002618C File Offset: 0x0002438C
	public event EventHandler<GEventArgs3> Event_3
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_3;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_3;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060002AD RID: 685 RVA: 0x000261C4 File Offset: 0x000243C4
	// (remove) Token: 0x060002AE RID: 686 RVA: 0x000261FC File Offset: 0x000243FC
	public event EventHandler<GEventArgs3> Event_4
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_4;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_4;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060002AF RID: 687 RVA: 0x00026234 File Offset: 0x00024434
	// (remove) Token: 0x060002B0 RID: 688 RVA: 0x0002626C File Offset: 0x0002446C
	public event EventHandler<GEventArgs3> Event_5
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_5;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_5;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x060002B1 RID: 689 RVA: 0x000262A4 File Offset: 0x000244A4
	// (remove) Token: 0x060002B2 RID: 690 RVA: 0x000262DC File Offset: 0x000244DC
	public event EventHandler<GEventArgs3> Event_6
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_6;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_6;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060002B3 RID: 691 RVA: 0x00026314 File Offset: 0x00024514
	// (remove) Token: 0x060002B4 RID: 692 RVA: 0x0002634C File Offset: 0x0002454C
	public event EventHandler<GEventArgs3> Event_7
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_7;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs3> eventHandler = this.eventHandler_7;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> eventHandler3 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs3>>(ref this.eventHandler_7, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00026384 File Offset: 0x00024584
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
				this.gclass12_0.method_9(1006, string.Empty);
			}
			finally
			{
				this.gclass19_0.method_16();
			}
		}
		catch
		{
		}
		this.enum4_0 = Enum4.Stop;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00004CB3 File Offset: 0x00002EB3
	private bool method_1(out string string_2)
	{
		string_2 = null;
		if (this.enum4_0 == Enum4.Start)
		{
			string_2 = "The server has already started.";
			return false;
		}
		if (this.enum4_0 == Enum4.ShuttingDown)
		{
			string_2 = "The server is shutting down.";
			return false;
		}
		return true;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00026420 File Offset: 0x00024620
	private bool method_2(out string string_2)
	{
		string_2 = null;
		bool flag = this.gclass19_0.GClass26_0.X509Certificate2_0 != null;
		string text = this.gclass19_0.String_0;
		bool flag2 = Class59.smethod_7(this.int_0, text);
		if (!flag && !flag2)
		{
			string_2 = "There is no server certificate for secure connection.";
			return false;
		}
		if (flag && flag2)
		{
			this.gclass6_0.method_6("The server certificate associated with the port is used.");
		}
		return true;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00004CE1 File Offset: 0x00002EE1
	private string method_3(string string_2)
	{
		string_2 = string_2.TrimStart(new char[] { '/', '\\' });
		return new StringBuilder(this.string_0, 32).AppendFormat("/{0}", string_2).ToString().Replace('\\', '/');
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00026484 File Offset: 0x00024684
	private static GClass19 smethod_0(string string_2, int int_1, bool bool_1)
	{
		GClass19 gclass = new GClass19();
		string text = (bool_1 ? "https" : "http");
		string text2 = string.Format("{0}://{1}:{2}/", text, string_2, int_1);
		gclass.GClass21_0.Add(text2);
		return gclass;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x000264C8 File Offset: 0x000246C8
	private void method_4(string string_2, IPAddress ipaddress_1, int int_1, bool bool_1)
	{
		this.string_1 = string_2;
		this.ipaddress_0 = ipaddress_1;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
		this.string_0 = "./Public";
		this.gclass19_0 = GClass8.smethod_0(this.string_1, this.int_0, this.bool_0);
		this.gclass6_0 = this.gclass19_0.GClass6_0;
		this.gclass12_0 = new GClass12(this.gclass6_0);
		this.object_0 = new object();
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00026548 File Offset: 0x00024748
	private void method_5(GClass20 gclass20_0)
	{
		string string_ = gclass20_0.GClass22_0.String_2;
		EventHandler<GEventArgs3> eventHandler = ((string_ == "GET") ? this.eventHandler_2 : ((string_ == "HEAD") ? this.eventHandler_3 : ((string_ == "POST") ? this.eventHandler_5 : ((string_ == "PUT") ? this.eventHandler_6 : ((string_ == "DELETE") ? this.eventHandler_1 : ((string_ == "CONNECT") ? this.eventHandler_0 : ((string_ == "OPTIONS") ? this.eventHandler_4 : ((string_ == "TRACE") ? this.eventHandler_7 : null))))))));
		if (eventHandler != null)
		{
			eventHandler(this, new GEventArgs3(gclass20_0, this.string_0));
		}
		else
		{
			gclass20_0.GClass23_0.Int32_0 = 501;
		}
		gclass20_0.GClass23_0.method_10();
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00026644 File Offset: 0x00024844
	private void method_6(GClass29 gclass29_0)
	{
		Uri uri = gclass29_0.P_m_6DBB1F3B;
		if (uri == null)
		{
			gclass29_0.method_1(GEnum5.BadRequest);
			return;
		}
		string absolutePath = uri.AbsolutePath;
		GClass11 gclass;
		if (!this.gclass12_0.method_7(absolutePath, out gclass))
		{
			gclass29_0.method_1(GEnum5.NotImplemented);
			return;
		}
		gclass.method_1(gclass29_0);
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00026698 File Offset: 0x00024898
	private void method_7()
	{
		for (;;)
		{
			GClass8.Class40 @class = new GClass8.Class40();
			@class.gclass8_0 = this;
			@class.gclass20_0 = null;
			try
			{
				@class.gclass20_0 = this.gclass19_0.method_20();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
				continue;
			}
			catch (GException2)
			{
				this.gclass6_0.method_4("The underlying listener is stopped.");
			}
			catch (InvalidOperationException)
			{
				this.gclass6_0.method_4("The underlying listener is stopped.");
			}
			catch (Exception ex)
			{
				this.gclass6_0.method_3(ex.Message);
				this.gclass6_0.method_1(ex.ToString());
				if (@class.gclass20_0 != null)
				{
					@class.gclass20_0.Class62_0.method_10(true);
				}
			}
			break;
		}
		if (this.enum4_0 != Enum4.ShuttingDown)
		{
			this.method_0();
		}
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0002677C File Offset: 0x0002497C
	private void method_8()
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
				this.gclass12_0.method_8();
				try
				{
					this.method_9();
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

	// Token: 0x060002BF RID: 703 RVA: 0x00026868 File Offset: 0x00024A68
	private void method_9()
	{
		try
		{
			this.gclass19_0.method_21();
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException("The underlying listener has failed to start.", ex);
		}
		this.thread_0 = new Thread(new ThreadStart(this.method_7));
		this.thread_0.IsBackground = true;
		this.thread_0.Start();
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x000268D0 File Offset: 0x00024AD0
	private void method_10(ushort ushort_0, string string_2)
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
				this.gclass12_0.method_9(ushort_0, string_2);
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
					this.method_11(5000);
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

	// Token: 0x060002C1 RID: 705 RVA: 0x00004D21 File Offset: 0x00002F21
	private void method_11(int int_1)
	{
		this.gclass19_0.method_22();
		this.thread_0.Join(int_1);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00026A08 File Offset: 0x00024C08
	private static bool smethod_1(string string_2, out Uri uri_0, out string string_3)
	{
		uri_0 = null;
		string_3 = null;
		Uri uri = string_2.smethod_104();
		if (uri == null)
		{
			string_3 = "An invalid URI string.";
			return false;
		}
		if (!uri.IsAbsoluteUri)
		{
			string_3 = "A relative URI.";
			return false;
		}
		string scheme = uri.Scheme;
		if (!(scheme == "http") && !(scheme == "https"))
		{
			string_3 = "The scheme part is not 'http' or 'https'.";
			return false;
		}
		if (uri.PathAndQuery != "/")
		{
			string_3 = "It includes either or both path and query components.";
			return false;
		}
		if (uri.Fragment.Length > 0)
		{
			string_3 = "It includes the fragment component.";
			return false;
		}
		if (uri.Port == 0)
		{
			string_3 = "The port part is zero.";
			return false;
		}
		uri_0 = uri;
		return true;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00026AB8 File Offset: 0x00024CB8
	[Obsolete("This method will be removed. Use added one instead.")]
	public void method_12<T>(string string_2, Func<T> func_0) where T : GClass9
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (func_0 == null)
		{
			throw new ArgumentNullException("creator");
		}
		if (string_2.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_2[0] != '/')
		{
			throw new ArgumentException("Not an absolute path.", "path");
		}
		if (string_2.IndexOfAny(new char[] { '?', '#' }) > -1)
		{
			throw new ArgumentException("It includes either or both query and fragment components.", "path");
		}
		this.gclass12_0.method_6<T>(string_2, func_0);
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00004D3B File Offset: 0x00002F3B
	public void method_13<T>(string string_2) where T : GClass9, new()
	{
		this.gclass12_0.method_10<T>(string_2, null);
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00004D4A File Offset: 0x00002F4A
	public void method_14<T>(string string_2, Action<T> action_0) where T : GClass9, new()
	{
		this.gclass12_0.method_10<T>(string_2, action_0);
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00026B4C File Offset: 0x00024D4C
	[Obsolete("This method will be removed.")]
	public byte[] method_15(string string_2)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("path");
		}
		if (string_2.Length == 0)
		{
			throw new ArgumentException("An empty string.", "path");
		}
		if (string_2.IndexOf("..") > -1)
		{
			throw new ArgumentException("It contains '..'.", "path");
		}
		string_2 = this.method_3(string_2);
		if (!File.Exists(string_2))
		{
			return null;
		}
		return File.ReadAllBytes(string_2);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00004D59 File Offset: 0x00002F59
	public bool method_16(string string_2)
	{
		return this.gclass12_0.method_19(string_2);
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00026BB8 File Offset: 0x00024DB8
	public void method_17()
	{
		string text;
		if (this.bool_0 && !this.method_2(out text))
		{
			throw new InvalidOperationException(text);
		}
		this.method_8();
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00004D67 File Offset: 0x00002F67
	public void method_18()
	{
		this.method_10(1001, string.Empty);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00026BE4 File Offset: 0x00024DE4
	[Obsolete("This method will be removed.")]
	public void method_19(ushort ushort_0, string string_2)
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
		if (!string_2.smethod_87())
		{
			if (ushort_0 == 1005)
			{
				throw new ArgumentException("1005 cannot be used.", "code");
			}
			byte[] array;
			if (!string_2.smethod_71(out array))
			{
				throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
			}
			if (array.Length > 123)
			{
				string text2 = "Its size is greater than 123 bytes.";
				throw new ArgumentOutOfRangeException("reason", text2);
			}
		}
		this.method_10(ushort_0, string_2);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00026C80 File Offset: 0x00024E80
	[Obsolete("This method will be removed.")]
	public void method_20(GEnum2 genum2_0, string string_2)
	{
		if (genum2_0 == GEnum2.MandatoryExtension)
		{
			throw new ArgumentException("MandatoryExtension cannot be used.", "code");
		}
		if (!string_2.smethod_87())
		{
			if (genum2_0 == GEnum2.NoStatus)
			{
				throw new ArgumentException("NoStatus cannot be used.", "code");
			}
			byte[] array;
			if (!string_2.smethod_71(out array))
			{
				throw new ArgumentException("It could not be UTF-8-encoded.", "reason");
			}
			if (array.Length > 123)
			{
				string text = "Its size is greater than 123 bytes.";
				throw new ArgumentOutOfRangeException("reason", text);
			}
		}
		this.method_10((ushort)genum2_0, string_2);
	}

	// Token: 0x04000167 RID: 359
	private IPAddress ipaddress_0;

	// Token: 0x04000168 RID: 360
	private string string_0;

	// Token: 0x04000169 RID: 361
	private string string_1;

	// Token: 0x0400016A RID: 362
	private GClass19 gclass19_0;

	// Token: 0x0400016B RID: 363
	private GClass6 gclass6_0;

	// Token: 0x0400016C RID: 364
	private int int_0;

	// Token: 0x0400016D RID: 365
	private Thread thread_0;

	// Token: 0x0400016E RID: 366
	private bool bool_0;

	// Token: 0x0400016F RID: 367
	private GClass12 gclass12_0;

	// Token: 0x04000170 RID: 368
	private volatile Enum4 enum4_0;

	// Token: 0x04000171 RID: 369
	private object object_0;

	// Token: 0x04000172 RID: 370
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_0;

	// Token: 0x04000173 RID: 371
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_1;

	// Token: 0x04000174 RID: 372
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_2;

	// Token: 0x04000175 RID: 373
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_3;

	// Token: 0x04000176 RID: 374
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_4;

	// Token: 0x04000177 RID: 375
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_5;

	// Token: 0x04000178 RID: 376
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_6;

	// Token: 0x04000179 RID: 377
	[CompilerGenerated]
	private EventHandler<GEventArgs3> eventHandler_7;

	// Token: 0x02000047 RID: 71
	[CompilerGenerated]
	private sealed class Class40
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00026D00 File Offset: 0x00024F00
		internal void method_0(object object_0)
		{
			try
			{
				if (this.gclass20_0.GClass22_0.method_6("websocket"))
				{
					this.gclass8_0.method_6(this.gclass20_0.method_3(null));
				}
				else
				{
					this.gclass8_0.method_5(this.gclass20_0);
				}
			}
			catch (Exception ex)
			{
				this.gclass8_0.gclass6_0.method_3(ex.Message);
				this.gclass8_0.gclass6_0.method_1(ex.ToString());
				this.gclass20_0.Class62_0.method_10(true);
			}
		}

		// Token: 0x0400017A RID: 378
		public GClass20 gclass20_0;

		// Token: 0x0400017B RID: 379
		public GClass8 gclass8_0;
	}
}
