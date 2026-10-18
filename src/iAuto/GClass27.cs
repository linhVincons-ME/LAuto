using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x0200008B RID: 139
[ComVisible(true)]
[Serializable]
public class GClass27 : NameValueCollection, ISerializable
{
	// Token: 0x06000621 RID: 1569 RVA: 0x000071E6 File Offset: 0x000053E6
	internal GClass27(Enum5 enum5_0, bool bool_0)
	{
		this._state = enum5_0;
		this._internallyUsed = bool_0;
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00032674 File Offset: 0x00030874
	protected GClass27(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		if (serializationInfo_0 == null)
		{
			throw new ArgumentNullException("serializationInfo");
		}
		try
		{
			this._internallyUsed = serializationInfo_0.GetBoolean("InternallyUsed");
			this._state = (Enum5)serializationInfo_0.GetInt32("State");
			int @int = serializationInfo_0.GetInt32("Count");
			for (int i = 0; i < @int; i++)
			{
				base.Add(serializationInfo_0.GetString(i.ToString()), serializationInfo_0.GetString((@int + i).ToString()));
			}
		}
		catch (SerializationException ex)
		{
			throw new ArgumentException(ex.Message, "serializationInfo", ex);
		}
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00006F3A File Offset: 0x0000513A
	public GClass27()
	{
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000624 RID: 1572 RVA: 0x000071FC File Offset: 0x000053FC
	internal Enum5 Enum5_0
	{
		get
		{
			return this._state;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000625 RID: 1573 RVA: 0x00007204 File Offset: 0x00005404
	public override string[] AllKeys
	{
		get
		{
			return base.AllKeys;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000626 RID: 1574 RVA: 0x0000720C File Offset: 0x0000540C
	public override int Count
	{
		get
		{
			return base.Count;
		}
	}

	// Token: 0x1700019C RID: 412
	public string this[HttpRequestHeader httpRequestHeader_0]
	{
		get
		{
			return this.Get(GClass27.smethod_7(httpRequestHeader_0));
		}
		set
		{
			this.method_16(httpRequestHeader_0, value);
		}
	}

	// Token: 0x1700019D RID: 413
	public string this[HttpResponseHeader httpResponseHeader_0]
	{
		get
		{
			return this.Get(GClass27.smethod_8(httpResponseHeader_0));
		}
		set
		{
			this.method_17(httpResponseHeader_0, value);
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00007244 File Offset: 0x00005444
	public override NameObjectCollectionBase.KeysCollection Keys
	{
		get
		{
			return base.Keys;
		}
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0003271C File Offset: 0x0003091C
	private void method_0(string string_0, string string_1, bool bool_0)
	{
		Action<string, string> action = (bool_0 ? new Action<string, string>(this.method_2) : new Action<string, string>(this.method_1));
		this.method_5(action, GClass27.smethod_2(string_0), string_1, true);
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0000724C File Offset: 0x0000544C
	private void method_1(string string_0, string string_1)
	{
		this.method_7(new Action<string, string>(base.Add), string_0, string_1);
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00007262 File Offset: 0x00005462
	private void method_2(string string_0, string string_1)
	{
		base.Add(string_0, GClass27.smethod_3(string_1));
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00007271 File Offset: 0x00005471
	private static int smethod_0(string string_0)
	{
		int num = string_0.IndexOf(':');
		if (num == -1)
		{
			throw new ArgumentException("No colon could be found.", "header");
		}
		return num;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00032758 File Offset: 0x00030958
	private static Enum5 smethod_1(string string_0)
	{
		Class64 @class = GClass27.smethod_5(string_0);
		if (@class == null)
		{
			return Enum5.Unspecified;
		}
		if (@class.Boolean_2 && !@class.Boolean_3)
		{
			return Enum5.Request;
		}
		if (!@class.Boolean_2 && @class.Boolean_3)
		{
			return Enum5.Response;
		}
		return Enum5.Unspecified;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0000728F File Offset: 0x0000548F
	private static string smethod_2(string string_0)
	{
		if (string_0 == null || string_0.Length == 0)
		{
			throw new ArgumentNullException("name");
		}
		string_0 = string_0.Trim();
		if (!GClass27.smethod_9(string_0))
		{
			throw new ArgumentException("Contains invalid characters.", "name");
		}
		return string_0;
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x000072C8 File Offset: 0x000054C8
	private void method_3(string string_0)
	{
		if (!this._internallyUsed && GClass27.smethod_6(string_0, true))
		{
			throw new ArgumentException("This header must be modified with the appropiate property.");
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x000072E6 File Offset: 0x000054E6
	private void method_4(bool bool_0)
	{
		if (this._state == Enum5.Unspecified)
		{
			return;
		}
		if (bool_0 && this._state == Enum5.Request)
		{
			throw new InvalidOperationException("This collection has already been used to store the request headers.");
		}
		if (!bool_0 && this._state == Enum5.Response)
		{
			throw new InvalidOperationException("This collection has already been used to store the response headers.");
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00032798 File Offset: 0x00030998
	private static string smethod_3(string string_0)
	{
		if (string_0 == null || string_0.Length == 0)
		{
			return string.Empty;
		}
		string_0 = string_0.Trim();
		if (string_0.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("value", "Greater than 65,535 characters.");
		}
		if (!GClass27.smethod_10(string_0))
		{
			throw new ArgumentException("Contains invalid characters.", "value");
		}
		return string_0;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x000327F4 File Offset: 0x000309F4
	private static string smethod_4(string string_0)
	{
		Class64 @class;
		if (!GClass27._headers.TryGetValue(string_0, out @class))
		{
			return string.Empty;
		}
		return @class.String_0;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0003281C File Offset: 0x00030A1C
	private void method_5(Action<string, string> action_0, string string_0, string string_1, bool bool_0)
	{
		Enum5 @enum = GClass27.smethod_1(string_0);
		if (@enum == Enum5.Request)
		{
			this.method_6(action_0, string_0, string_1, false, bool_0);
			return;
		}
		if (@enum == Enum5.Response)
		{
			this.method_6(action_0, string_0, string_1, true, bool_0);
			return;
		}
		action_0(string_0, string_1);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0000731F File Offset: 0x0000551F
	private void method_6(Action<string, string> action_0, string string_0, string string_1, bool bool_0, bool bool_1)
	{
		this.method_4(bool_0);
		action_0(string_0, string_1);
		if (bool_1 && this._state == Enum5.Unspecified)
		{
			this._state = (bool_0 ? Enum5.Response : Enum5.Request);
		}
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0000734B File Offset: 0x0000554B
	private void method_7(Action<string, string> action_0, string string_0, string string_1)
	{
		this.method_3(string_0);
		action_0(string_0, GClass27.smethod_3(string_1));
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0003285C File Offset: 0x00030A5C
	private static Class64 smethod_5(string string_0)
	{
		foreach (Class64 @class in GClass27._headers.Values)
		{
			if (@class.String_0.Equals(string_0, StringComparison.InvariantCultureIgnoreCase))
			{
				return @class;
			}
		}
		return null;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x000328C4 File Offset: 0x00030AC4
	private static bool smethod_6(string string_0, bool bool_0)
	{
		Class64 @class = GClass27.smethod_5(string_0);
		return @class != null && @class.method_1(bool_0);
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00007361 File Offset: 0x00005561
	private void method_8(string string_0, string string_1)
	{
		this.method_3(string_0);
		base.Remove(string_0);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00007371 File Offset: 0x00005571
	private void method_9(string string_0, string string_1)
	{
		this.method_7(new Action<string, string>(base.Set), string_0, string_1);
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00007387 File Offset: 0x00005587
	internal static string smethod_7(HttpRequestHeader httpRequestHeader_0)
	{
		return GClass27.smethod_4(httpRequestHeader_0.ToString());
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0000739B File Offset: 0x0000559B
	internal static string smethod_8(HttpResponseHeader httpResponseHeader_0)
	{
		return GClass27.smethod_4(httpResponseHeader_0.ToString());
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x000073AF File Offset: 0x000055AF
	internal void method_10(string string_0)
	{
		base.Remove(string_0);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000328E4 File Offset: 0x00030AE4
	internal void method_11(string string_0, bool bool_0)
	{
		int num = GClass27.smethod_0(string_0);
		this.method_12(string_0.Substring(0, num), string_0.Substring(num + 1), bool_0);
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x000073B8 File Offset: 0x000055B8
	internal void method_12(string string_0, string string_1, bool bool_0)
	{
		string_1 = GClass27.smethod_3(string_1);
		if (GClass27.smethod_11(string_0, bool_0))
		{
			base.Add(string_0, string_1);
			return;
		}
		base.Set(string_0, string_1);
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000073DC File Offset: 0x000055DC
	internal static bool smethod_9(string string_0)
	{
		return string_0 != null && string_0.Length > 0 && string_0.smethod_48();
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000073F2 File Offset: 0x000055F2
	internal static bool smethod_10(string string_0)
	{
		return string_0.smethod_47();
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00032910 File Offset: 0x00030B10
	internal static bool smethod_11(string string_0, bool bool_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			Class64 @class = GClass27.smethod_5(string_0);
			return @class != null && @class.method_0(bool_0);
		}
		return false;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00032940 File Offset: 0x00030B40
	internal string method_13(bool bool_0)
	{
		GClass27.Class75 @class = new GClass27.Class75();
		@class.gclass27_0 = this;
		@class.bool_0 = bool_0;
		@class.stringBuilder_0 = new StringBuilder();
		this.Count.smethod_96(new Action<int>(@class.method_0));
		return @class.stringBuilder_0.Append("\r\n").ToString();
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x000073FA File Offset: 0x000055FA
	protected void method_14(string string_0, string string_1)
	{
		this.method_0(string_0, string_1, true);
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00032998 File Offset: 0x00030B98
	public void method_15(string string_0)
	{
		if (string_0 == null || string_0.Length == 0)
		{
			throw new ArgumentNullException("header");
		}
		int num = GClass27.smethod_0(string_0);
		this.method_0(string_0.Substring(0, num), string_0.Substring(num + 1), false);
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00007405 File Offset: 0x00005605
	public void method_16(HttpRequestHeader httpRequestHeader_0, string string_0)
	{
		this.method_6(new Action<string, string>(this.method_1), GClass27.smethod_7(httpRequestHeader_0), string_0, false, true);
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00007422 File Offset: 0x00005622
	public void method_17(HttpResponseHeader httpResponseHeader_0, string string_0)
	{
		this.method_6(new Action<string, string>(this.method_1), GClass27.smethod_8(httpResponseHeader_0), string_0, true, true);
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x0000743F File Offset: 0x0000563F
	public override void Add(string name, string value)
	{
		this.method_0(name, value, false);
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0000744A File Offset: 0x0000564A
	public override void Clear()
	{
		base.Clear();
		this._state = Enum5.Unspecified;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00007459 File Offset: 0x00005659
	public override string Get(int index)
	{
		return base.Get(index);
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00007462 File Offset: 0x00005662
	public override string Get(string name)
	{
		return base.Get(name);
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0000746B File Offset: 0x0000566B
	public override IEnumerator GetEnumerator()
	{
		return base.GetEnumerator();
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00007473 File Offset: 0x00005673
	public override string GetKey(int index)
	{
		return base.GetKey(index);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000329DC File Offset: 0x00030BDC
	public override string[] GetValues(int index)
	{
		string[] values = base.GetValues(index);
		if (values != null && values.Length != 0)
		{
			return values;
		}
		return null;
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000329FC File Offset: 0x00030BFC
	public override string[] GetValues(string name)
	{
		string[] values = base.GetValues(name);
		if (values != null && values.Length != 0)
		{
			return values;
		}
		return null;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00032A1C File Offset: 0x00030C1C
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		GClass27.Class76 @class = new GClass27.Class76();
		@class.serializationInfo_0 = info;
		@class.gclass27_0 = this;
		if (@class.serializationInfo_0 == null)
		{
			throw new ArgumentNullException("serializationInfo");
		}
		@class.serializationInfo_0.AddValue("InternallyUsed", this._internallyUsed);
		@class.serializationInfo_0.AddValue("State", (int)this._state);
		@class.int_0 = this.Count;
		@class.serializationInfo_0.AddValue("Count", @class.int_0);
		@class.int_0.smethod_96(new Action<int>(@class.method_0));
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0000747C File Offset: 0x0000567C
	public static bool smethod_12(string string_0)
	{
		return GClass27.smethod_6(GClass27.smethod_2(string_0), false);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0000748A File Offset: 0x0000568A
	public static bool smethod_13(string string_0, bool bool_0)
	{
		return GClass27.smethod_6(GClass27.smethod_2(string_0), bool_0);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x0000500B File Offset: 0x0000320B
	public override void OnDeserialization(object sender)
	{
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00007498 File Offset: 0x00005698
	public void method_18(HttpRequestHeader httpRequestHeader_0)
	{
		this.method_6(new Action<string, string>(this.method_8), GClass27.smethod_7(httpRequestHeader_0), null, false, false);
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x000074B5 File Offset: 0x000056B5
	public void method_19(HttpResponseHeader httpResponseHeader_0)
	{
		this.method_6(new Action<string, string>(this.method_8), GClass27.smethod_8(httpResponseHeader_0), null, true, false);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000074D2 File Offset: 0x000056D2
	public override void Remove(string name)
	{
		this.method_5(new Action<string, string>(this.method_8), GClass27.smethod_2(name), null, false);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000074EE File Offset: 0x000056EE
	public void method_20(HttpRequestHeader httpRequestHeader_0, string string_0)
	{
		this.method_6(new Action<string, string>(this.method_9), GClass27.smethod_7(httpRequestHeader_0), string_0, false, true);
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0000750B File Offset: 0x0000570B
	public void method_21(HttpResponseHeader httpResponseHeader_0, string string_0)
	{
		this.method_6(new Action<string, string>(this.method_9), GClass27.smethod_8(httpResponseHeader_0), string_0, true, true);
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00007528 File Offset: 0x00005728
	public override void Set(string name, string value)
	{
		this.method_5(new Action<string, string>(this.method_9), GClass27.smethod_2(name), value, true);
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00003BDB File Offset: 0x00001DDB
	public byte[] method_22()
	{
		return Encoding.UTF8.GetBytes(this.ToString());
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00032AB8 File Offset: 0x00030CB8
	public override string ToString()
	{
		GClass27.Class77 @class = new GClass27.Class77();
		@class.gclass27_0 = this;
		@class.stringBuilder_0 = new StringBuilder();
		this.Count.smethod_96(new Action<int>(@class.method_0));
		return @class.stringBuilder_0.Append("\r\n").ToString();
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00007544 File Offset: 0x00005744
	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		this.GetObjectData(serializationInfo, streamingContext);
	}

	// Token: 0x04000357 RID: 855
	private static readonly Dictionary<string, Class64> _headers = new Dictionary<string, Class64>(StringComparer.InvariantCultureIgnoreCase)
	{
		{
			"Accept",
			new Class64("Accept", Enum5.Request | Enum5.Restricted | Enum5.MultiValue)
		},
		{
			"AcceptCharset",
			new Class64("Accept-Charset", Enum5.Request | Enum5.MultiValue)
		},
		{
			"AcceptEncoding",
			new Class64("Accept-Encoding", Enum5.Request | Enum5.MultiValue)
		},
		{
			"AcceptLanguage",
			new Class64("Accept-Language", Enum5.Request | Enum5.MultiValue)
		},
		{
			"AcceptRanges",
			new Class64("Accept-Ranges", Enum5.Response | Enum5.MultiValue)
		},
		{
			"Age",
			new Class64("Age", Enum5.Response)
		},
		{
			"Allow",
			new Class64("Allow", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"Authorization",
			new Class64("Authorization", Enum5.Request | Enum5.MultiValue)
		},
		{
			"CacheControl",
			new Class64("Cache-Control", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"Connection",
			new Class64("Connection", Enum5.Request | Enum5.Response | Enum5.Restricted | Enum5.MultiValue)
		},
		{
			"ContentEncoding",
			new Class64("Content-Encoding", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"ContentLanguage",
			new Class64("Content-Language", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"ContentLength",
			new Class64("Content-Length", Enum5.Request | Enum5.Response | Enum5.Restricted)
		},
		{
			"ContentLocation",
			new Class64("Content-Location", Enum5.Request | Enum5.Response)
		},
		{
			"ContentMd5",
			new Class64("Content-MD5", Enum5.Request | Enum5.Response)
		},
		{
			"ContentRange",
			new Class64("Content-Range", Enum5.Request | Enum5.Response)
		},
		{
			"ContentType",
			new Class64("Content-Type", Enum5.Request | Enum5.Response | Enum5.Restricted)
		},
		{
			"Cookie",
			new Class64("Cookie", Enum5.Request)
		},
		{
			"Cookie2",
			new Class64("Cookie2", Enum5.Request)
		},
		{
			"Date",
			new Class64("Date", Enum5.Request | Enum5.Response | Enum5.Restricted)
		},
		{
			"Expect",
			new Class64("Expect", Enum5.Request | Enum5.Restricted | Enum5.MultiValue)
		},
		{
			"Expires",
			new Class64("Expires", Enum5.Request | Enum5.Response)
		},
		{
			"ETag",
			new Class64("ETag", Enum5.Response)
		},
		{
			"From",
			new Class64("From", Enum5.Request)
		},
		{
			"Host",
			new Class64("Host", Enum5.Request | Enum5.Restricted)
		},
		{
			"IfMatch",
			new Class64("If-Match", Enum5.Request | Enum5.MultiValue)
		},
		{
			"IfModifiedSince",
			new Class64("If-Modified-Since", Enum5.Request | Enum5.Restricted)
		},
		{
			"IfNoneMatch",
			new Class64("If-None-Match", Enum5.Request | Enum5.MultiValue)
		},
		{
			"IfRange",
			new Class64("If-Range", Enum5.Request)
		},
		{
			"IfUnmodifiedSince",
			new Class64("If-Unmodified-Since", Enum5.Request)
		},
		{
			"KeepAlive",
			new Class64("Keep-Alive", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"LastModified",
			new Class64("Last-Modified", Enum5.Request | Enum5.Response)
		},
		{
			"Location",
			new Class64("Location", Enum5.Response)
		},
		{
			"MaxForwards",
			new Class64("Max-Forwards", Enum5.Request)
		},
		{
			"Pragma",
			new Class64("Pragma", Enum5.Request | Enum5.Response)
		},
		{
			"ProxyAuthenticate",
			new Class64("Proxy-Authenticate", Enum5.Response | Enum5.MultiValue)
		},
		{
			"ProxyAuthorization",
			new Class64("Proxy-Authorization", Enum5.Request)
		},
		{
			"ProxyConnection",
			new Class64("Proxy-Connection", Enum5.Request | Enum5.Response | Enum5.Restricted)
		},
		{
			"Public",
			new Class64("Public", Enum5.Response | Enum5.MultiValue)
		},
		{
			"Range",
			new Class64("Range", Enum5.Request | Enum5.Restricted | Enum5.MultiValue)
		},
		{
			"Referer",
			new Class64("Referer", Enum5.Request | Enum5.Restricted)
		},
		{
			"RetryAfter",
			new Class64("Retry-After", Enum5.Response)
		},
		{
			"SecWebSocketAccept",
			new Class64("Sec-WebSocket-Accept", Enum5.Response | Enum5.Restricted)
		},
		{
			"SecWebSocketExtensions",
			new Class64("Sec-WebSocket-Extensions", Enum5.Request | Enum5.Response | Enum5.Restricted | Enum5.MultiValueInRequest)
		},
		{
			"SecWebSocketKey",
			new Class64("Sec-WebSocket-Key", Enum5.Request | Enum5.Restricted)
		},
		{
			"SecWebSocketProtocol",
			new Class64("Sec-WebSocket-Protocol", Enum5.Request | Enum5.Response | Enum5.MultiValueInRequest)
		},
		{
			"SecWebSocketVersion",
			new Class64("Sec-WebSocket-Version", Enum5.Request | Enum5.Response | Enum5.Restricted | Enum5.MultiValueInResponse)
		},
		{
			"Server",
			new Class64("Server", Enum5.Response)
		},
		{
			"SetCookie",
			new Class64("Set-Cookie", Enum5.Response | Enum5.MultiValue)
		},
		{
			"SetCookie2",
			new Class64("Set-Cookie2", Enum5.Response | Enum5.MultiValue)
		},
		{
			"Te",
			new Class64("TE", Enum5.Request)
		},
		{
			"Trailer",
			new Class64("Trailer", Enum5.Request | Enum5.Response)
		},
		{
			"TransferEncoding",
			new Class64("Transfer-Encoding", Enum5.Request | Enum5.Response | Enum5.Restricted | Enum5.MultiValue)
		},
		{
			"Translate",
			new Class64("Translate", Enum5.Request)
		},
		{
			"Upgrade",
			new Class64("Upgrade", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"UserAgent",
			new Class64("User-Agent", Enum5.Request | Enum5.Restricted)
		},
		{
			"Vary",
			new Class64("Vary", Enum5.Response | Enum5.MultiValue)
		},
		{
			"Via",
			new Class64("Via", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"Warning",
			new Class64("Warning", Enum5.Request | Enum5.Response | Enum5.MultiValue)
		},
		{
			"WwwAuthenticate",
			new Class64("WWW-Authenticate", Enum5.Response | Enum5.Restricted | Enum5.MultiValue)
		}
	};

	// Token: 0x04000358 RID: 856
	private bool _internallyUsed;

	// Token: 0x04000359 RID: 857
	private Enum5 _state;

	// Token: 0x0200008C RID: 140
	[CompilerGenerated]
	private sealed class Class75
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x00032B0C File Offset: 0x00030D0C
		internal void method_0(int int_0)
		{
			string key = this.gclass27_0.GetKey(int_0);
			if (GClass27.smethod_11(key, this.bool_0))
			{
				foreach (string text in this.gclass27_0.GetValues(int_0))
				{
					this.stringBuilder_0.AppendFormat("{0}: {1}\r\n", key, text);
				}
				return;
			}
			this.stringBuilder_0.AppendFormat("{0}: {1}\r\n", key, this.gclass27_0.Get(int_0));
		}

		// Token: 0x0400035A RID: 858
		public GClass27 gclass27_0;

		// Token: 0x0400035B RID: 859
		public bool bool_0;

		// Token: 0x0400035C RID: 860
		public StringBuilder stringBuilder_0;
	}

	// Token: 0x0200008D RID: 141
	[CompilerGenerated]
	private sealed class Class76
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x00032B88 File Offset: 0x00030D88
		internal void method_0(int int_1)
		{
			this.serializationInfo_0.AddValue(int_1.ToString(), this.gclass27_0.GetKey(int_1));
			this.serializationInfo_0.AddValue((this.int_0 + int_1).ToString(), this.gclass27_0.Get(int_1));
		}

		// Token: 0x0400035D RID: 861
		public SerializationInfo serializationInfo_0;

		// Token: 0x0400035E RID: 862
		public GClass27 gclass27_0;

		// Token: 0x0400035F RID: 863
		public int int_0;
	}

	// Token: 0x0200008E RID: 142
	[CompilerGenerated]
	private sealed class Class77
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x0000754E File Offset: 0x0000574E
		internal void method_0(int int_0)
		{
			this.stringBuilder_0.AppendFormat("{0}: {1}\r\n", this.gclass27_0.GetKey(int_0), this.gclass27_0.Get(int_0));
		}

		// Token: 0x04000360 RID: 864
		public StringBuilder stringBuilder_0;

		// Token: 0x04000361 RID: 865
		public GClass27 gclass27_0;
	}
}
