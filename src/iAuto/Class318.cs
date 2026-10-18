using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020001DD RID: 477
internal class Class318 : Class315
{
	// Token: 0x060019A8 RID: 6568 RVA: 0x000CEF9C File Offset: 0x000CD19C
	public Class318(Class381 class381_1, List<Class357> list_2, string string_1)
		: base(class381_1)
	{
		list_2.Sort(new Comparison<Class357>(Class318.Class325.f_01A59D4D.method_0));
		this.list_1 = list_2;
		this.string_0 = string_1;
		this.class324_0 = (this.class324_1 = new Class324(class381_1.Control3_0.Class357_5));
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x000CF010 File Offset: 0x000CD210
	public override void m_39C52E01()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.class381_0.vmethod_13();
		control3_.method_85();
		control3_.Class357_5.method_38();
		for (int i = 0; i < this.list_1.Count; i++)
		{
			control3_.Class357_5.GStruct19_0 = this.list_1[i].GStruct19_0;
			for (int j = 0; j < this.string_0.Length; j++)
			{
				control3_.Class357_5.method_11(true);
			}
			Class318.smethod_0(this.class381_0);
			Class317.smethod_0(this.list_0[this.list_0.Count - i - 1], this.class381_0);
		}
		control3_.Class357_5.method_39();
		control3_.method_86();
		if (this.list_1.Count > 0)
		{
			this.class381_0.vmethod_10(this.list_1[0].GStruct19_0.int_1, this.list_1[this.list_1.Count - 1].GStruct19_1.int_1);
		}
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x000CF140 File Offset: 0x000CD340
	public override void m_B267E5E0()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.list_0.Clear();
		this.class381_0.vmethod_14(ref this.string_0);
		control3_.Class357_5.method_38();
		control3_.method_85();
		for (int i = this.list_1.Count - 1; i >= 0; i--)
		{
			control3_.Class357_5.GStruct19_0 = this.list_1[i].GStruct19_0;
			control3_.Class357_5.GStruct19_1 = this.list_1[i].GStruct19_1;
			this.list_0.Add(control3_.Class357_5.String_1);
			Class318.smethod_0(this.class381_0);
			if (this.string_0 != "")
			{
				Class317.smethod_0(this.string_0, this.class381_0);
			}
		}
		if (this.list_1.Count > 0)
		{
			this.class381_0.vmethod_10(this.list_1[0].GStruct19_0.int_1, this.list_1[this.list_1.Count - 1].GStruct19_1.int_1);
		}
		control3_.method_86();
		control3_.Class357_5.method_39();
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
		this.class324_0 = new Class324(control3_.Class357_5);
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000119A0 File Offset: 0x0000FBA0
	public override Class315 m_5933D0D4()
	{
		return new Class318(this.class381_0, this.list_1.ToList<Class357>(), this.string_0);
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000CF2A8 File Offset: 0x000CD4A8
	internal static void smethod_0(Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		control3_.Class357_5.method_40();
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
			return;
		}
		class381_1[num].vmethod_0(int32_, class381_1[num].Count - int32_);
		class381_1[num2].vmethod_0(0, int32_2);
		class381_1.m_90EA19F5(num + 1, num2 - num - 1);
		Class316.smethod_2(num, class381_1);
	}

	// Token: 0x0400109D RID: 4253
	private readonly List<string> list_0 = new List<string>();

	// Token: 0x0400109E RID: 4254
	private readonly List<Class357> list_1;

	// Token: 0x0400109F RID: 4255
	private string string_0;

	// Token: 0x020001DE RID: 478
	[CompilerGenerated]
	[Serializable]
	private sealed class Class325
	{
		// Token: 0x060019AF RID: 6575 RVA: 0x000CF374 File Offset: 0x000CD574
		internal int method_0(Class357 class357_0, Class357 class357_1)
		{
			GStruct19 gstruct;
			if (class357_0.GStruct19_0.int_1 == class357_1.GStruct19_0.int_1)
			{
				gstruct = class357_0.GStruct19_0;
				return gstruct.int_0.CompareTo(class357_1.GStruct19_0.int_0);
			}
			gstruct = class357_0.GStruct19_0;
			return gstruct.int_1.CompareTo(class357_1.GStruct19_0.int_1);
		}

		// Token: 0x040010A0 RID: 4256
		public static readonly Class318.Class325 f_01A59D4D = new Class318.Class325();

		// Token: 0x040010A1 RID: 4257
		public static Comparison<Class357> f_E70F3F94;
	}
}
