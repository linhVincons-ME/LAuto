using System;

// Token: 0x020001DC RID: 476
internal class Class317 : Class315
{
	// Token: 0x060019A3 RID: 6563 RVA: 0x00011953 File Offset: 0x0000FB53
	public Class317(Class381 class381_1, string string_1)
		: base(class381_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x000CEE64 File Offset: 0x000CD064
	public override void m_39C52E01()
	{
		this.class381_0.Control3_0.Class357_5.GStruct19_0 = this.class324_1.GStruct19_0;
		this.class381_0.Control3_0.Class357_5.GStruct19_1 = this.class324_0.GStruct19_0;
		this.class381_0.vmethod_13();
		Class319.smethod_0(this.class381_0);
		base.m_39C52E01();
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x00011963 File Offset: 0x0000FB63
	public override void m_B267E5E0()
	{
		this.class381_0.vmethod_14(ref this.string_0);
		Class317.smethod_0(this.string_0, this.class381_0);
		base.m_B267E5E0();
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x000CEED0 File Offset: 0x000CD0D0
	internal static void smethod_0(string string_1, Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		try
		{
			control3_.Class357_5.method_38();
			char c = '\0';
			if (class381_1.Count == 0)
			{
				Class316.smethod_1(class381_1);
				control3_.Class357_5.GStruct19_0 = GStruct19.GStruct19_0;
			}
			control3_.method_99(control3_.Class357_5.GStruct19_0.int_1);
			int length = string_1.Length;
			for (int i = 0; i < length; i++)
			{
				char c2 = string_1[i];
				if (c2 == '\r' && (i >= length - 1 || string_1[i + 1] != '\n'))
				{
					Class316.smethod_0('\n', ref c, class381_1);
				}
				else
				{
					Class316.smethod_0(c2, ref c, class381_1);
				}
			}
			class381_1.vmethod_11(new Class381.EventArgs14(0, 1));
		}
		finally
		{
			control3_.Class357_5.method_39();
		}
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0001198D File Offset: 0x0000FB8D
	public override Class315 m_5933D0D4()
	{
		return new Class317(this.class381_0, this.string_0);
	}

	// Token: 0x0400109C RID: 4252
	public string string_0;
}
