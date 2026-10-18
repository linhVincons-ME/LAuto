using System;
using System.Collections.Specialized;
using System.IO;

// Token: 0x0200004A RID: 74
public abstract class GClass9 : GInterface0
{
	// Token: 0x060002D3 RID: 723 RVA: 0x00004D79 File Offset: 0x00002F79
	protected GClass9()
	{
		this.dateTime_0 = DateTime.MaxValue;
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x00004D8C File Offset: 0x00002F8C
	protected NameValueCollection NameValueCollection_0
	{
		get
		{
			if (this.gclass28_0 == null)
			{
				return null;
			}
			return this.gclass28_0.P_m_F73319E4;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00004DA3 File Offset: 0x00002FA3
	[Obsolete("This property will be removed.")]
	protected GClass6 GClass6_0
	{
		get
		{
			if (this.gclass7_0 == null)
			{
				return null;
			}
			return this.gclass7_0.GClass6_0;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060002D6 RID: 726 RVA: 0x00004DBA File Offset: 0x00002FBA
	protected NameValueCollection NameValueCollection_1
	{
		get
		{
			if (this.gclass28_0 == null)
			{
				return null;
			}
			return this.gclass28_0.P_m_4976EEAF;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00004DD1 File Offset: 0x00002FD1
	protected GClass13 GClass13_0
	{
		get
		{
			return this.gclass13_0;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060002D8 RID: 728 RVA: 0x00004DD9 File Offset: 0x00002FD9
	public GEnum4 GEnum4_0
	{
		get
		{
			if (this.gclass7_0 == null)
			{
				return GEnum4.Connecting;
			}
			return this.gclass7_0.GEnum4_0;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x00004DF0 File Offset: 0x00002FF0
	public GClass28 GClass28_0
	{
		get
		{
			return this.gclass28_0;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060002DA RID: 730 RVA: 0x00004DF8 File Offset: 0x00002FF8
	// (set) Token: 0x060002DB RID: 731 RVA: 0x00004E00 File Offset: 0x00003000
	public Func<GClass16, GClass16, bool> Func_0
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

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060002DC RID: 732 RVA: 0x00004E09 File Offset: 0x00003009
	// (set) Token: 0x060002DD RID: 733 RVA: 0x00004E25 File Offset: 0x00003025
	public bool Boolean_0
	{
		get
		{
			if (this.gclass7_0 == null)
			{
				return this.bool_0;
			}
			return this.gclass7_0.Boolean_3;
		}
		set
		{
			if (this.gclass7_0 != null)
			{
				this.gclass7_0.Boolean_3 = value;
				return;
			}
			this.bool_0 = value;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060002DE RID: 734 RVA: 0x00004E43 File Offset: 0x00003043
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060002DF RID: 735 RVA: 0x00004E4B File Offset: 0x0000304B
	// (set) Token: 0x060002E0 RID: 736 RVA: 0x00004E53 File Offset: 0x00003053
	public bool Boolean_1
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

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060002E1 RID: 737 RVA: 0x00004E5C File Offset: 0x0000305C
	// (set) Token: 0x060002E2 RID: 738 RVA: 0x00004E64 File Offset: 0x00003064
	public Func<string, bool> Func_1
	{
		get
		{
			return this.func_1;
		}
		set
		{
			this.func_1 = value;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x00004E6D File Offset: 0x0000306D
	// (set) Token: 0x060002E4 RID: 740 RVA: 0x00026DA0 File Offset: 0x00024FA0
	public string String_1
	{
		get
		{
			string string_;
			if (this.gclass7_0 == null)
			{
				if ((string_ = this.string_1) == null)
				{
					return string.Empty;
				}
			}
			else
			{
				string_ = this.gclass7_0.String_2;
			}
			return string_;
		}
		set
		{
			if (this.GEnum4_0 != GEnum4.Connecting)
			{
				throw new InvalidOperationException("The session has already started.");
			}
			if (value == null || value.Length == 0)
			{
				this.string_1 = null;
				return;
			}
			if (!value.smethod_48())
			{
				throw new ArgumentException("Not a token.", "value");
			}
			this.string_1 = value;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x00004E92 File Offset: 0x00003092
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00026DF4 File Offset: 0x00024FF4
	private string method_1(GClass28 gclass28_1)
	{
		if (this.func_1 != null && !this.func_1(gclass28_1.P_m_6E5F397D))
		{
			return "It includes no Origin header or an invalid one.";
		}
		if (this.func_0 != null)
		{
			GClass16 gclass = gclass28_1.P_m_BD29BBD8;
			GClass16 gclass16_ = gclass28_1.P_m_3EA51AA9.GClass16_0;
			if (!this.func_0(gclass, gclass16_))
			{
				return "It includes no cookie or an invalid one.";
			}
		}
		return null;
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00004E9A File Offset: 0x0000309A
	private void method_2(object sender, GEventArgs0 e)
	{
		if (this.string_0 == null)
		{
			return;
		}
		this.gclass13_0.method_13(this.string_0);
		this.vmethod_0(e);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00004EBE File Offset: 0x000030BE
	private void method_3(object sender, GEventArgs1 e)
	{
		this.vmethod_1(e);
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00004EC7 File Offset: 0x000030C7
	private void method_4(object sender, GEventArgs2 e)
	{
		this.vmethod_2(e);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00004ED0 File Offset: 0x000030D0
	private void method_5(object sender, EventArgs e)
	{
		this.string_0 = this.gclass13_0.method_9(this);
		if (this.string_0 == null)
		{
			this.gclass7_0.method_74(GEnum2.Away);
			return;
		}
		this.dateTime_0 = DateTime.Now;
		this.vmethod_3();
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00026E54 File Offset: 0x00025054
	internal void method_6(GClass28 gclass28_1, GClass13 gclass13_1)
	{
		if (this.gclass7_0 != null)
		{
			this.gclass7_0.GClass6_0.method_2("A session instance cannot be reused.");
			gclass28_1.P_m_3EA51AA9.method_64(GEnum5.ServiceUnavailable);
			return;
		}
		this.gclass28_0 = gclass28_1;
		this.gclass13_0 = gclass13_1;
		this.gclass7_0 = gclass28_1.P_m_3EA51AA9;
		this.gclass7_0.Func_0 = new Func<GClass28, string>(this.method_1);
		this.gclass7_0.Boolean_3 = this.bool_0;
		this.gclass7_0.Boolean_1 = this.bool_1;
		this.gclass7_0.String_2 = this.string_1;
		TimeSpan timeSpan_ = gclass13_1.TimeSpan_0;
		if (timeSpan_ != this.gclass7_0.TimeSpan_0)
		{
			this.gclass7_0.TimeSpan_0 = timeSpan_;
		}
		this.gclass7_0.Event_3 += this.method_5;
		this.gclass7_0.Event_2 += this.method_4;
		this.gclass7_0.Event_1 += this.method_3;
		this.gclass7_0.Event_0 += this.method_2;
		this.gclass7_0.method_66();
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00004F0E File Offset: 0x0000310E
	protected void method_7()
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_72();
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00004F2E File Offset: 0x0000312E
	protected void method_8(ushort ushort_0, string string_2)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_75(ushort_0, string_2);
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00004F50 File Offset: 0x00003150
	protected void method_9(GEnum2 genum2_0, string string_2)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_76(genum2_0, string_2);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00004F72 File Offset: 0x00003172
	protected void method_10()
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_77();
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00004F92 File Offset: 0x00003192
	protected void method_11(ushort ushort_0, string string_2)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_80(ushort_0, string_2);
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00004FB4 File Offset: 0x000031B4
	protected void method_12(GEnum2 genum2_0, string string_2)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The session has not started yet.");
		}
		this.gclass7_0.method_81(genum2_0, string_2);
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00004FD6 File Offset: 0x000031D6
	[Obsolete("This method will be removed.")]
	protected void method_13(string string_2, Exception exception_0)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("message");
		}
		if (string_2.Length == 0)
		{
			throw new ArgumentException("An empty string.", "message");
		}
		this.vmethod_1(new GEventArgs1(string_2, exception_0));
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_0(GEventArgs0 geventArgs0_0)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_1(GEventArgs1 geventArgs1_0)
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_2(GEventArgs2 geventArgs2_0)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_3()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0000500D File Offset: 0x0000320D
	protected void method_14(byte[] byte_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_86(byte_0);
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0000502E File Offset: 0x0000322E
	protected void method_15(FileInfo fileInfo_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_87(fileInfo_0);
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0000504F File Offset: 0x0000324F
	protected void method_16(string string_2)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_88(string_2);
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00005070 File Offset: 0x00003270
	protected void method_17(Stream stream_0, int int_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_89(stream_0, int_0);
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00005092 File Offset: 0x00003292
	protected void method_18(byte[] byte_0, Action<bool> action_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_90(byte_0, action_0);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x000050B4 File Offset: 0x000032B4
	protected void method_19(FileInfo fileInfo_0, Action<bool> action_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_91(fileInfo_0, action_0);
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000050D6 File Offset: 0x000032D6
	protected void method_20(string string_2, Action<bool> action_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_92(string_2, action_0);
	}

	// Token: 0x060002FE RID: 766 RVA: 0x000050F8 File Offset: 0x000032F8
	protected void method_21(Stream stream_0, int int_0, Action<bool> action_0)
	{
		if (this.gclass7_0 == null)
		{
			throw new InvalidOperationException("The current state of the connection is not Open.");
		}
		this.gclass7_0.method_93(stream_0, int_0, action_0);
	}

	// Token: 0x04000181 RID: 385
	private GClass28 gclass28_0;

	// Token: 0x04000182 RID: 386
	private Func<GClass16, GClass16, bool> func_0;

	// Token: 0x04000183 RID: 387
	private bool bool_0;

	// Token: 0x04000184 RID: 388
	private string string_0;

	// Token: 0x04000185 RID: 389
	private bool bool_1;

	// Token: 0x04000186 RID: 390
	private Func<string, bool> func_1;

	// Token: 0x04000187 RID: 391
	private string string_1;

	// Token: 0x04000188 RID: 392
	private GClass13 gclass13_0;

	// Token: 0x04000189 RID: 393
	private DateTime dateTime_0;

	// Token: 0x0400018A RID: 394
	private GClass7 gclass7_0;
}
