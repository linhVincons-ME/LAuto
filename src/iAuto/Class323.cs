using System;

// Token: 0x020001E5 RID: 485
internal class Class323 : Class315
{
	// Token: 0x060019CB RID: 6603 RVA: 0x000119CA File Offset: 0x0000FBCA
	public Class323(Class381 class381_1)
		: base(class381_1)
	{
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x00011A80 File Offset: 0x0000FC80
	public override void m_B267E5E0()
	{
		this.class324_0 = new Class324(this.class381_0.Control3_0.Class357_5);
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x0000500B File Offset: 0x0000320B
	protected override void m_4B38221A(bool bool_1)
	{
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x00011A9D File Offset: 0x0000FC9D
	public override void m_39C52E01()
	{
		this.class381_0.Control3_0.Class357_5 = new Class357(this.class381_0.Control3_0, this.class324_0.GStruct19_0, this.class324_0.GStruct19_1);
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x000D0128 File Offset: 0x000CE328
	public override Class315 m_5933D0D4()
	{
		Class323 @class = new Class323(this.class381_0);
		if (this.class324_0 != null)
		{
			@class.class324_0 = new Class324(new Class357(this.class381_0.Control3_0, this.class324_0.GStruct19_0, this.class324_0.GStruct19_1));
		}
		return @class;
	}
}
