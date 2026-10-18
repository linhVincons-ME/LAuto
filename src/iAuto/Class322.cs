using System;
using System.Collections.Generic;

// Token: 0x020001E4 RID: 484
internal class Class322 : Class315
{
	// Token: 0x060019C5 RID: 6597 RVA: 0x00011A3E File Offset: 0x0000FC3E
	public Class322(Class315 class315_1)
		: base(class315_1.class381_0)
	{
		this.class315_0 = class315_1;
		this.class357_0 = this.class381_0.Control3_0.Class357_5.method_6();
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x000CFC28 File Offset: 0x000CDE28
	public override void m_B267E5E0()
	{
		this.list_0.Clear();
		Class357 @class = this.class357_0.method_6();
		int num = -1;
		int int_ = @class.GStruct19_0.int_1;
		int int_2 = @class.GStruct19_1.int_1;
		this.class381_0.Control3_0.Class357_5.Boolean_0 = false;
		this.class381_0.Control3_0.Class357_5.method_38();
		this.class381_0.Control3_0.method_85();
		this.class381_0.Control3_0.bool_0 = false;
		try
		{
			if (this.class315_0 is Class317)
			{
				this.method_0(ref num, (this.class315_0 as Class317).string_0);
			}
			else if (this.class315_0 is Class316 && (this.class315_0 as Class316).char_0 != '\0' && (this.class315_0 as Class316).char_0 != '\b')
			{
				this.method_0(ref num, (this.class315_0 as Class316).char_0.ToString());
			}
			else
			{
				this.method_1(ref num);
			}
		}
		catch (ArgumentOutOfRangeException)
		{
		}
		finally
		{
			this.class381_0.Control3_0.bool_0 = true;
			this.class381_0.Control3_0.method_86();
			this.class381_0.Control3_0.Class357_5 = this.class357_0;
			if (num >= 0)
			{
				this.class381_0.Control3_0.Class357_5.GStruct19_0 = new GStruct19(num, int_);
				this.class381_0.Control3_0.Class357_5.GStruct19_1 = new GStruct19(num, int_2);
			}
			this.class381_0.Control3_0.Class357_5.Boolean_0 = true;
			this.class381_0.Control3_0.Class357_5.method_39();
		}
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x000CFDF8 File Offset: 0x000CDFF8
	private void method_0(ref int int_0, string string_0)
	{
		string[] array = string_0.Split(new char[] { '\n' });
		int num = 0;
		foreach (Class357 @class in this.class357_0.method_52(true))
		{
			Class351 class2 = this.class381_0.Control3_0[@class.GStruct19_0.int_1];
			if (!GStruct19.smethod_2(@class.GStruct19_1, @class.GStruct19_0) || class2.Int32_2 != class2.Count)
			{
				string text = array[num % array.Length];
				if (GStruct19.smethod_2(@class.GStruct19_1, @class.GStruct19_0) && text != "")
				{
					text = new string(' ', @class.GStruct19_0.int_0 - @class.GStruct19_1.int_0) + text;
					@class.GStruct19_0 = @class.GStruct19_1;
				}
				this.class381_0.Control3_0.Class357_5 = @class;
				Class317 class3 = new Class317(this.class381_0, text);
				class3.m_B267E5E0();
				if (this.class381_0.Control3_0.Class357_5.GStruct19_1.int_0 > int_0)
				{
					int_0 = this.class381_0.Control3_0.Class357_5.GStruct19_1.int_0;
				}
				this.list_0.Add(class3);
			}
			num++;
		}
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x000CFF84 File Offset: 0x000CE184
	private void method_1(ref int int_0)
	{
		foreach (Class357 @class in this.class357_0.method_52(false))
		{
			this.class381_0.Control3_0.Class357_5 = @class;
			Class315 class2 = this.class315_0.m_5933D0D4();
			class2.m_B267E5E0();
			if (this.class381_0.Control3_0.Class357_5.GStruct19_1.int_0 > int_0)
			{
				int_0 = this.class381_0.Control3_0.Class357_5.GStruct19_1.int_0;
			}
			this.list_0.Add(class2);
		}
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x000D003C File Offset: 0x000CE23C
	public override void m_39C52E01()
	{
		this.class381_0.Control3_0.method_85();
		this.class381_0.Control3_0.Class357_5.method_38();
		try
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				this.list_0[i].m_39C52E01();
			}
		}
		finally
		{
			this.class381_0.Control3_0.Class357_5.method_39();
			this.class381_0.Control3_0.method_86();
		}
		this.class381_0.Control3_0.Class357_5 = this.class357_0.method_6();
		this.class381_0.Control3_0.vmethod_56(this.class357_0);
		this.class381_0.Control3_0.vmethod_58();
		this.class381_0.Control3_0.Class357_5.Boolean_0 = true;
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x00011A79 File Offset: 0x0000FC79
	public override Class315 m_5933D0D4()
	{
		throw new NotImplementedException();
	}

	// Token: 0x040010AB RID: 4267
	private readonly Class315 class315_0;

	// Token: 0x040010AC RID: 4268
	private readonly List<Class315> list_0 = new List<Class315>();

	// Token: 0x040010AD RID: 4269
	private readonly Class357 class357_0;
}
