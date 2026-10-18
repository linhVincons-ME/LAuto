using System;

// Token: 0x020001CB RID: 459
internal class Class305 : Class303
{
	// Token: 0x060018CD RID: 6349 RVA: 0x0001102D File Offset: 0x0000F22D
	public Class305(string string_6)
		: base(string_6)
	{
		this.string_4 = this.string_1.ToLower();
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x000CCBA8 File Offset: 0x000CADA8
	public override GEnum11 m_E27BA5A4(string string_6)
	{
		int num = string_6.LastIndexOf('.');
		if (num < 0)
		{
			return GEnum11.Hidden;
		}
		string text = string_6.Substring(num + 1);
		this.string_5 = string_6.Substring(0, num);
		if (text == "")
		{
			return GEnum11.Visible;
		}
		if (this.string_1.StartsWith(text, StringComparison.InvariantCultureIgnoreCase))
		{
			return GEnum11.VisibleAndSelected;
		}
		if (this.string_4.Contains(text.ToLower()))
		{
			return GEnum11.Visible;
		}
		return GEnum11.Hidden;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00011047 File Offset: 0x0000F247
	public override string m_8A4FE07C()
	{
		return this.string_5 + "." + this.string_1;
	}

	// Token: 0x0400105E RID: 4190
	private readonly string string_4;

	// Token: 0x0400105F RID: 4191
	private string string_5;
}
