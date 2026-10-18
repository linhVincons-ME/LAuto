using System;

// Token: 0x020001CA RID: 458
internal class Class304 : Class303
{
	// Token: 0x060018C8 RID: 6344 RVA: 0x00010FA6 File Offset: 0x0000F1A6
	public Class304(string string_4)
	{
		this.string_1 = string_4.Replace("\r", "");
		this.String_0 = "Code snippet:";
		this.String_1 = this.string_1;
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00010FDB File Offset: 0x0000F1DB
	public virtual string m_7E45F35E()
	{
		return this.String_2 ?? this.string_1.Replace("\n", " ").Replace("^", "");
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00010F6A File Offset: 0x0000F16A
	public override string m_8A4FE07C()
	{
		return this.string_1;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000CCAA4 File Offset: 0x000CACA4
	public override void m_864A0ECA(Class307 class307_1, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.Control3_0.method_85();
		eventArgs1_0.Control3_0.Class357_5.method_38();
		GStruct19 gstruct19_ = class307_1.Class357_0.GStruct19_0;
		GStruct19 gstruct19_2 = eventArgs1_0.Control3_0.Class357_5.GStruct19_0;
		if (eventArgs1_0.Control3_0.Boolean_18)
		{
			for (int i = gstruct19_.int_1 + 1; i <= gstruct19_2.int_1; i++)
			{
				eventArgs1_0.Control3_0.Class357_5.GStruct19_0 = new GStruct19(0, i);
				eventArgs1_0.Control3_0.vmethod_44(i);
			}
		}
		eventArgs1_0.Control3_0.Class357_5.GStruct19_0 = gstruct19_;
		while (eventArgs1_0.Control3_0.Class357_5.Char_1 != '^' && eventArgs1_0.Control3_0.Class357_5.vmethod_1())
		{
		}
		eventArgs1_0.Control3_0.Class357_5.method_10(true);
		eventArgs1_0.Control3_0.vmethod_20("");
		eventArgs1_0.Control3_0.Class357_5.method_39();
		eventArgs1_0.Control3_0.method_86();
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x0001100B File Offset: 0x0000F20B
	public override GEnum11 m_E27BA5A4(string string_4)
	{
		if (this.string_1.StartsWith(string_4, StringComparison.InvariantCultureIgnoreCase) && this.string_1 != string_4)
		{
			return GEnum11.Visible;
		}
		return GEnum11.Hidden;
	}
}
