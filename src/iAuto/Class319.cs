using System;

// Token: 0x020001DF RID: 479
internal class Class319 : Class315
{
	// Token: 0x060019B0 RID: 6576 RVA: 0x000119CA File Offset: 0x0000FBCA
	public Class319(Class381 class381_1)
		: base(class381_1)
	{
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x000CF3D8 File Offset: 0x000CD5D8
	public override void m_39C52E01()
	{
		this.class381_0.Control3_0.Class357_5.GStruct19_0 = new GStruct19(this.class324_1.Int32_0, Math.Min(this.class324_1.GStruct19_0.int_1, this.class324_1.GStruct19_1.int_1));
		this.class381_0.vmethod_13();
		Class317.smethod_0(this.string_0, this.class381_0);
		this.class381_0.vmethod_10(this.class324_1.GStruct19_0.int_1, this.class324_1.GStruct19_1.int_1);
		this.class381_0.Control3_0.Class357_5.GStruct19_0 = this.class324_1.GStruct19_0;
		this.class381_0.Control3_0.Class357_5.GStruct19_1 = this.class324_1.GStruct19_1;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
	public override void m_B267E5E0()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		string text = null;
		this.class381_0.vmethod_14(ref text);
		if (text == "")
		{
			throw new ArgumentOutOfRangeException();
		}
		this.string_0 = control3_.Class357_5.String_1;
		Class319.smethod_0(this.class381_0);
		this.class324_0 = new Class324(control3_.Class357_5);
		this.class381_0.vmethod_10(this.class324_0.GStruct19_0.int_1, this.class324_0.GStruct19_0.int_1);
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x000CF54C File Offset: 0x000CD74C
	internal static void smethod_0(Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		GStruct19 gstruct19_ = control3_.Class357_5.GStruct19_0;
		GStruct19 gstruct19_2 = control3_.Class357_5.GStruct19_1;
		int num = Math.Min(gstruct19_2.int_1, gstruct19_.int_1);
		int num2 = Math.Max(gstruct19_2.int_1, gstruct19_.int_1);
		int int32_ = control3_.Class357_5.Int32_2;
		int int32_2 = control3_.Class357_5.Int32_3;
		if (num < 0)
		{
			return;
		}
		if (num == num2)
		{
			class381_1[num].vmethod_0(int32_, int32_2 - int32_);
		}
		else
		{
			class381_1[num].vmethod_0(int32_, class381_1[num].Count - int32_);
			class381_1[num2].vmethod_0(0, int32_2);
			class381_1.m_90EA19F5(num + 1, num2 - num - 1);
			Class316.smethod_2(num, class381_1);
		}
		control3_.Class357_5.GStruct19_0 = new GStruct19(int32_, num);
		class381_1.vmethod_11(new Class381.EventArgs14(num, num2));
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x000119D3 File Offset: 0x0000FBD3
	public override Class315 m_5933D0D4()
	{
		return new Class319(this.class381_0);
	}

	// Token: 0x040010A2 RID: 4258
	private string string_0;
}
