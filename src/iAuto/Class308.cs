using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x020001D1 RID: 465
internal abstract class Class308 : IEnumerable, IDisposable, ICollection<Class311>, IEnumerable<Class311>
{
	// Token: 0x06001947 RID: 6471
	public abstract void Add(Class311 item);

	// Token: 0x06001948 RID: 6472
	public abstract void Clear();

	// Token: 0x06001949 RID: 6473
	public abstract bool Contains(Class311 item);

	// Token: 0x0600194A RID: 6474
	public abstract void CopyTo(Class311[] array, int arrayIndex);

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x0600194B RID: 6475
	public abstract int Count { get; }

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x0600194C RID: 6476
	public abstract bool IsReadOnly { get; }

	// Token: 0x0600194D RID: 6477
	public abstract bool Remove(Class311 item);

	// Token: 0x0600194E RID: 6478
	public abstract IEnumerator<Class311> GetEnumerator();

	// Token: 0x0600194F RID: 6479 RVA: 0x00011592 File Offset: 0x0000F792
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06001950 RID: 6480
	public abstract void Dispose();

	// Token: 0x06001951 RID: 6481
	public abstract void m_3C2BBC82(int int_0, string string_0);

	// Token: 0x06001952 RID: 6482
	public abstract void m_05DAEE07(int int_0);

	// Token: 0x06001953 RID: 6483
	public abstract bool m_2C548EAA(int int_0);

	// Token: 0x06001954 RID: 6484
	public abstract bool m_D88CF883(int int_0);

	// Token: 0x06001955 RID: 6485
	public abstract Class311 m_298DA27F(int int_0);
}
