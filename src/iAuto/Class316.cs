using System;

// Token: 0x020001DB RID: 475
internal class Class316 : Class315
{
	// Token: 0x0600199B RID: 6555 RVA: 0x00011930 File Offset: 0x0000FB30
	public Class316(Class381 class381_1, char char_2)
		: base(class381_1)
	{
		this.char_0 = char_2;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x000CE738 File Offset: 0x000CC938
	public override void m_39C52E01()
	{
		this.class381_0.vmethod_13();
		switch (this.char_0)
		{
		case '\b':
		{
			this.class381_0.Control3_0.Class357_5.GStruct19_0 = this.class324_0.GStruct19_0;
			char c = '\0';
			if (this.char_1 != '\0')
			{
				this.class381_0.Control3_0.method_99(this.class381_0.Control3_0.Class357_5.GStruct19_0.int_1);
				Class316.smethod_0(this.char_1, ref c, this.class381_0);
				goto IL_01C8;
			}
			goto IL_01C8;
		}
		case '\t':
		{
			this.class381_0.Control3_0.method_99(this.class324_1.GStruct19_0.int_1);
			for (int i = this.class324_1.Int32_0; i < this.class324_0.Int32_0; i++)
			{
				this.class381_0[this.class324_1.GStruct19_0.int_1].RemoveAt(this.class324_1.GStruct19_0.int_0);
			}
			this.class381_0.Control3_0.Class357_5.GStruct19_0 = this.class324_1.GStruct19_0;
			goto IL_01C8;
		}
		case '\n':
			Class316.smethod_2(this.class324_1.GStruct19_0.int_1, this.class381_0);
			goto IL_01C8;
		case '\r':
			goto IL_01C8;
		}
		this.class381_0.Control3_0.method_99(this.class324_1.GStruct19_0.int_1);
		this.class381_0[this.class324_1.GStruct19_0.int_1].RemoveAt(this.class324_1.GStruct19_0.int_0);
		this.class381_0.Control3_0.Class357_5.GStruct19_0 = this.class324_1.GStruct19_0;
		IL_01C8:
		this.class381_0.vmethod_11(new Class381.EventArgs14(this.class324_1.GStruct19_0.int_1, this.class324_1.GStruct19_0.int_1));
		base.m_39C52E01();
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x000CE944 File Offset: 0x000CCB44
	public override void m_B267E5E0()
	{
		this.class381_0.Control3_0.method_99(this.class381_0.Control3_0.Class357_5.GStruct19_0.int_1);
		string text = this.char_0.ToString();
		this.class381_0.vmethod_14(ref text);
		if (text.Length == 1)
		{
			this.char_0 = text[0];
		}
		if (string.IsNullOrEmpty(text))
		{
			throw new ArgumentOutOfRangeException();
		}
		if (this.class381_0.Count == 0)
		{
			Class316.smethod_1(this.class381_0);
		}
		Class316.smethod_0(this.char_0, ref this.char_1, this.class381_0);
		this.class381_0.vmethod_11(new Class381.EventArgs14(this.class381_0.Control3_0.Class357_5.GStruct19_0.int_1, this.class381_0.Control3_0.Class357_5.GStruct19_0.int_1));
		base.m_B267E5E0();
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000CEA34 File Offset: 0x000CCC34
	internal static void smethod_0(char char_2, ref char char_3, Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		switch (char_2)
		{
		case '\b':
			if (control3_.Class357_5.GStruct19_0.int_0 == 0 && control3_.Class357_5.GStruct19_0.int_1 == 0)
			{
				return;
			}
			if (control3_.Class357_5.GStruct19_0.int_0 != 0)
			{
				char_3 = class381_1[control3_.Class357_5.GStruct19_0.int_1][control3_.Class357_5.GStruct19_0.int_0 - 1].char_0;
				class381_1[control3_.Class357_5.GStruct19_0.int_1].RemoveAt(control3_.Class357_5.GStruct19_0.int_0 - 1);
				control3_.Class357_5.GStruct19_0 = new GStruct19(control3_.Class357_5.GStruct19_0.int_0 - 1, control3_.Class357_5.GStruct19_0.int_1);
				return;
			}
			if (!class381_1.Control3_0.bool_0)
			{
				throw new ArgumentOutOfRangeException("Cant insert this char in ColumnRange mode");
			}
			if (control3_.list_0[control3_.Class357_5.GStruct19_0.int_1 - 1].genum18_0 != GEnum18.Visible)
			{
				control3_.method_99(control3_.Class357_5.GStruct19_0.int_1 - 1);
			}
			char_3 = '\n';
			Class316.smethod_2(control3_.Class357_5.GStruct19_0.int_1 - 1, class381_1);
			return;
		case '\t':
		{
			int num = control3_.Int32_5 - control3_.Class357_5.GStruct19_0.int_0 % control3_.Int32_5;
			if (num == 0)
			{
				num = control3_.Int32_5;
			}
			for (int i = 0; i < num; i++)
			{
				class381_1[control3_.Class357_5.GStruct19_0.int_1].Insert(control3_.Class357_5.GStruct19_0.int_0, new GStruct17(' '));
			}
			control3_.Class357_5.GStruct19_0 = new GStruct19(control3_.Class357_5.GStruct19_0.int_0 + num, control3_.Class357_5.GStruct19_0.int_1);
			return;
		}
		case '\n':
			if (!class381_1.Control3_0.bool_0)
			{
				throw new ArgumentOutOfRangeException("Cant insert this char in ColumnRange mode");
			}
			if (class381_1.Count == 0)
			{
				Class316.smethod_1(class381_1);
			}
			Class316.smethod_1(class381_1);
			return;
		case '\r':
			return;
		}
		class381_1[control3_.Class357_5.GStruct19_0.int_1].Insert(control3_.Class357_5.GStruct19_0.int_0, new GStruct17(char_2));
		control3_.Class357_5.GStruct19_0 = new GStruct19(control3_.Class357_5.GStruct19_0.int_0 + 1, control3_.Class357_5.GStruct19_0.int_1);
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000CECD4 File Offset: 0x000CCED4
	internal static void smethod_1(Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		if (!control3_.Boolean_22 && control3_.Int32_14 > 0)
		{
			return;
		}
		if (class381_1.Count == 0)
		{
			class381_1.m_559E6352(0, class381_1.vmethod_0());
		}
		else
		{
			Class316.smethod_3(control3_.Class357_5.GStruct19_0.int_1, control3_.Class357_5.GStruct19_0.int_0, class381_1);
		}
		control3_.Class357_5.GStruct19_0 = new GStruct19(0, control3_.Class357_5.GStruct19_0.int_1 + 1);
		class381_1.vmethod_11(new Class381.EventArgs14(0, 1));
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x000CED68 File Offset: 0x000CCF68
	internal static void smethod_2(int int_0, Class381 class381_1)
	{
		Control3 control3_ = class381_1.Control3_0;
		if (int_0 + 1 >= class381_1.Count)
		{
			return;
		}
		control3_.method_99(int_0);
		control3_.method_99(int_0 + 1);
		int count = class381_1[int_0].Count;
		if (class381_1[int_0 + 1].Count == 0)
		{
			class381_1.vmethod_8(int_0 + 1);
		}
		else
		{
			class381_1[int_0].vmethod_2(class381_1[int_0 + 1]);
			class381_1.vmethod_8(int_0 + 1);
		}
		control3_.Class357_5.GStruct19_0 = new GStruct19(count, int_0);
		class381_1.vmethod_11(new Class381.EventArgs14(0, 1));
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000CEE00 File Offset: 0x000CD000
	internal static void smethod_3(int int_0, int int_1, Class381 class381_1)
	{
		Class351 @class = class381_1.vmethod_0();
		for (int i = int_1; i < class381_1[int_0].Count; i++)
		{
			@class.Add(class381_1[int_0][i]);
		}
		class381_1[int_0].vmethod_0(int_1, class381_1[int_0].Count - int_1);
		class381_1.m_559E6352(int_0 + 1, @class);
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x00011940 File Offset: 0x0000FB40
	public override Class315 m_5933D0D4()
	{
		return new Class316(this.class381_0, this.char_0);
	}

	// Token: 0x0400109A RID: 4250
	public char char_0;

	// Token: 0x0400109B RID: 4251
	private char char_1;
}
