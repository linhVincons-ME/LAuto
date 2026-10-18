using System;

// Token: 0x020001DA RID: 474
internal abstract class Class315 : Class314
{
	// Token: 0x06001996 RID: 6550 RVA: 0x000118DE File Offset: 0x0000FADE
	public Class315(Class381 class381_1)
	{
		this.class381_0 = class381_1;
		this.class324_1 = new Class324(class381_1.Control3_0.Class357_5);
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00011903 File Offset: 0x0000FB03
	public virtual void m_39C52E01()
	{
		this.m_4B38221A(true);
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0001190C File Offset: 0x0000FB0C
	public override void m_B267E5E0()
	{
		this.class324_0 = new Class324(this.class381_0.Control3_0.Class357_5);
		this.m_4B38221A(false);
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000CE650 File Offset: 0x000CC850
	protected virtual void m_4B38221A(bool bool_1)
	{
		bool flag = this.class324_1.GStruct19_0.int_1 < this.class324_0.GStruct19_0.int_1;
		if (bool_1)
		{
			if (flag)
			{
				this.class381_0.vmethod_10(this.class324_1.GStruct19_0.int_1, this.class324_1.GStruct19_0.int_1);
				return;
			}
			this.class381_0.vmethod_10(this.class324_1.GStruct19_0.int_1, this.class324_0.GStruct19_0.int_1);
			return;
		}
		else
		{
			if (flag)
			{
				this.class381_0.vmethod_10(this.class324_1.GStruct19_0.int_1, this.class324_0.GStruct19_0.int_1);
				return;
			}
			this.class381_0.vmethod_10(this.class324_0.GStruct19_0.int_1, this.class324_0.GStruct19_0.int_1);
			return;
		}
	}

	// Token: 0x0600199A RID: 6554
	public abstract Class315 m_5933D0D4();

	// Token: 0x04001097 RID: 4247
	internal bool bool_0;

	// Token: 0x04001098 RID: 4248
	internal Class324 class324_0;

	// Token: 0x04001099 RID: 4249
	internal Class324 class324_1;
}
