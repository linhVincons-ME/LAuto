using System;
using System.Collections.Generic;

// Token: 0x02000218 RID: 536
public struct GStruct18
{
	// Token: 0x06001D80 RID: 7552 RVA: 0x00013F8B File Offset: 0x0001218B
	public GStruct18(int int_3)
	{
		this.list_0 = null;
		this.genum18_0 = GEnum18.Visible;
		this.int_0 = int_3;
		this.int_1 = 0;
		this.int_2 = 0;
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00013FB0 File Offset: 0x000121B0
	public List<int> List_0
	{
		get
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<int>();
			}
			return this.list_0;
		}
	}

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000E02D4 File Offset: 0x000DE4D4
	public int Int32_0
	{
		get
		{
			switch (this.genum18_0)
			{
			case GEnum18.Visible:
				if (this.list_0 == null)
				{
					return 1;
				}
				return this.list_0.Count + 1;
			case GEnum18.StartOfHiddenBlock:
				return 1;
			case GEnum18.Hidden:
				return 0;
			default:
				return 0;
			}
		}
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x00013FCB File Offset: 0x000121CB
	internal int method_0(int int_3)
	{
		if (int_3 != 0)
		{
			return this.List_0[int_3 - 1];
		}
		return 0;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x00013FE0 File Offset: 0x000121E0
	internal int method_1(int int_3, Class351 class351_0)
	{
		if (this.Int32_0 <= 0)
		{
			return 0;
		}
		if (int_3 != this.Int32_0 - 1)
		{
			return this.List_0[int_3] - 1;
		}
		return class351_0.Count - 1;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000E0318 File Offset: 0x000DE518
	public int method_2(int int_3)
	{
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i] > int_3)
				{
					return i;
				}
			}
			return this.list_0.Count;
		}
		return 0;
	}

	// Token: 0x0400127E RID: 4734
	private List<int> list_0;

	// Token: 0x0400127F RID: 4735
	internal int int_0;

	// Token: 0x04001280 RID: 4736
	internal int int_1;

	// Token: 0x04001281 RID: 4737
	internal int int_2;

	// Token: 0x04001282 RID: 4738
	public GEnum18 genum18_0;
}
