using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020001E0 RID: 480
internal class Class320 : Class315
{
	// Token: 0x060019B5 RID: 6581 RVA: 0x000CF634 File Offset: 0x000CD834
	private Class320(Class381 class381_1, List<Class320.Class326> list_2)
		: base(class381_1)
	{
		list_2.Sort(new Comparison<Class320.Class326>(Class320.Class327.f_DC753226.method_0));
		this.list_1 = list_2;
		this.class324_0 = (this.class324_1 = new Class324(class381_1.Control3_0.Class357_5));
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x000CF6A0 File Offset: 0x000CD8A0
	public override void m_39C52E01()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.class381_0.vmethod_13();
		control3_.Class357_5.method_38();
		for (int i = 0; i < this.list_1.Count; i++)
		{
			control3_.Class357_5.GStruct19_0 = this.list_1[i].Class357_0.GStruct19_0;
			for (int j = 0; j < this.list_1[i].String_0.Length; j++)
			{
				control3_.Class357_5.method_11(true);
			}
			Class319.smethod_0(this.class381_0);
			int num = this.list_1.Count - 1 - i;
			Class317.smethod_0(this.list_0[num], this.class381_0);
			this.class381_0.vmethod_10(this.list_1[i].Class357_0.GStruct19_0.int_1, this.list_1[i].Class357_0.GStruct19_0.int_1);
		}
		control3_.Class357_5.method_39();
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000CF7CC File Offset: 0x000CD9CC
	public override void m_B267E5E0()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.list_0.Clear();
		this.class381_0.vmethod_13();
		control3_.Class357_5.method_38();
		for (int i = this.list_1.Count - 1; i >= 0; i--)
		{
			control3_.Class357_5.GStruct19_0 = this.list_1[i].Class357_0.GStruct19_0;
			control3_.Class357_5.GStruct19_1 = this.list_1[i].Class357_0.GStruct19_1;
			this.list_0.Add(control3_.Class357_5.String_1);
			Class319.smethod_0(this.class381_0);
			Class317.smethod_0(this.list_1[i].String_0, this.class381_0);
			this.class381_0.vmethod_10(this.list_1[i].Class357_0.GStruct19_0.int_1, this.list_1[i].Class357_0.GStruct19_1.int_1);
		}
		control3_.Class357_5.method_39();
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
		this.class324_0 = new Class324(control3_.Class357_5);
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x000119E0 File Offset: 0x0000FBE0
	public override Class315 m_5933D0D4()
	{
		return new Class320(this.class381_0, this.list_1.ToList<Class320.Class326>());
	}

	// Token: 0x040010A3 RID: 4259
	private readonly List<string> list_0 = new List<string>();

	// Token: 0x040010A4 RID: 4260
	private readonly List<Class320.Class326> list_1;

	// Token: 0x020001E1 RID: 481
	private class Class326
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x000119F8 File Offset: 0x0000FBF8
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00011A00 File Offset: 0x0000FC00
		public Class357 Class357_0 { get; set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00011A09 File Offset: 0x0000FC09
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00011A11 File Offset: 0x0000FC11
		public string String_0 { get; set; }

		// Token: 0x040010A5 RID: 4261
		[CompilerGenerated]
		private Class357 class357_0;

		// Token: 0x040010A6 RID: 4262
		[CompilerGenerated]
		private string string_0;
	}

	// Token: 0x020001E2 RID: 482
	[CompilerGenerated]
	[Serializable]
	private sealed class Class327
	{
		// Token: 0x060019C0 RID: 6592 RVA: 0x000CF914 File Offset: 0x000CDB14
		internal int method_0(Class320.Class326 class326_0, Class320.Class326 class326_1)
		{
			GStruct19 gstruct;
			if (class326_0.Class357_0.GStruct19_0.int_1 == class326_1.Class357_0.GStruct19_0.int_1)
			{
				gstruct = class326_0.Class357_0.GStruct19_0;
				return gstruct.int_0.CompareTo(class326_1.Class357_0.GStruct19_0.int_0);
			}
			gstruct = class326_0.Class357_0.GStruct19_0;
			return gstruct.int_1.CompareTo(class326_1.Class357_0.GStruct19_0.int_1);
		}

		// Token: 0x040010A7 RID: 4263
		public static readonly Class320.Class327 f_DC753226 = new Class320.Class327();

		// Token: 0x040010A8 RID: 4264
		public static Comparison<Class320.Class326> f_2630DAE1;
	}
}
