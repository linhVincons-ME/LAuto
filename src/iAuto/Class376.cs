using System;
using System.Collections.Generic;

// Token: 0x02000239 RID: 569
internal class Class376 : IDisposable
{
	// Token: 0x06001EC2 RID: 7874 RVA: 0x000E5E7C File Offset: 0x000E407C
	public void Dispose()
	{
		foreach (Class368 @class in this.list_2)
		{
			@class.Dispose();
		}
	}

	// Token: 0x04001338 RID: 4920
	public readonly List<Class378> list_0 = new List<Class378>();

	// Token: 0x04001339 RID: 4921
	public readonly List<Class377> list_1 = new List<Class377>();

	// Token: 0x0400133A RID: 4922
	public readonly List<Class368> list_2 = new List<Class368>();

	// Token: 0x0400133B RID: 4923
	public GEnum15 genum15_0 = GEnum15.Strategy2;

	// Token: 0x0400133C RID: 4924
	public char char_0 = '(';

	// Token: 0x0400133D RID: 4925
	public char char_1 = '{';

	// Token: 0x0400133E RID: 4926
	public char char_2 = ')';

	// Token: 0x0400133F RID: 4927
	public char char_3 = '}';
}
