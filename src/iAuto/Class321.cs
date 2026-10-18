using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020001E3 RID: 483
internal class Class321 : Class315
{
	// Token: 0x060019C1 RID: 6593 RVA: 0x000CF994 File Offset: 0x000CDB94
	public Class321(Class381 class381_1, List<int> list_2)
		: base(class381_1)
	{
		list_2.Sort();
		this.list_0 = list_2;
		this.class324_0 = (this.class324_1 = new Class324(class381_1.Control3_0.Class357_5));
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x000CF9E0 File Offset: 0x000CDBE0
	public override void m_39C52E01()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.class381_0.vmethod_13();
		control3_.Class357_5.method_38();
		for (int i = 0; i < this.list_0.Count; i++)
		{
			int num = this.list_0[i];
			if (num < this.class381_0.Count)
			{
				control3_.Class357_5.GStruct19_0 = new GStruct19(0, num);
			}
			else
			{
				control3_.Class357_5.GStruct19_0 = new GStruct19(this.class381_0[this.class381_0.Count - 1].Count, this.class381_0.Count - 1);
			}
			Class316.smethod_1(this.class381_0);
			control3_.Class357_5.GStruct19_0 = new GStruct19(0, num);
			string text = this.list_1[this.list_1.Count - i - 1];
			Class317.smethod_0(text, this.class381_0);
			this.class381_0[num].Boolean_0 = true;
			if (num < this.class381_0.Count - 1)
			{
				this.class381_0[num + 1].Boolean_0 = true;
			}
			else
			{
				this.class381_0[num - 1].Boolean_0 = true;
			}
			if (text.Trim() != string.Empty)
			{
				this.class381_0.vmethod_10(num, num);
			}
		}
		control3_.Class357_5.method_39();
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x000CFB60 File Offset: 0x000CDD60
	public override void m_B267E5E0()
	{
		Control3 control3_ = this.class381_0.Control3_0;
		this.list_1.Clear();
		this.class381_0.vmethod_13();
		control3_.Class357_5.method_38();
		for (int i = this.list_0.Count - 1; i >= 0; i--)
		{
			int num = this.list_0[i];
			this.list_1.Add(this.class381_0[num].String_2);
			this.class381_0.vmethod_8(num);
		}
		control3_.Class357_5.GStruct19_0 = new GStruct19(0, 0);
		control3_.Class357_5.method_39();
		this.class381_0.vmethod_11(new Class381.EventArgs14(0, 1));
		this.class324_0 = new Class324(control3_.Class357_5);
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x00011A26 File Offset: 0x0000FC26
	public override Class315 m_5933D0D4()
	{
		return new Class321(this.class381_0, this.list_0.ToList<int>());
	}

	// Token: 0x040010A9 RID: 4265
	private readonly List<int> list_0;

	// Token: 0x040010AA RID: 4266
	private readonly List<string> list_1 = new List<string>();
}
