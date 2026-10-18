using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000370 RID: 880
[CompilerGenerated]
internal sealed class Class618<T> : IEnumerable, ICollection, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, IList, ICollection<T>, IList<T>
{
	// Token: 0x06002C5D RID: 11357 RVA: 0x0001D9DD File Offset: 0x0001BBDD
	public Class618(T[] gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x0001D9EC File Offset: 0x0001BBEC
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<T>)this.gparam_0).GetEnumerator();
	}

	// Token: 0x17000A27 RID: 2599
	// (get) Token: 0x06002C5F RID: 11359 RVA: 0x0001D9F9 File Offset: 0x0001BBF9
	int ICollection.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x17000A28 RID: 2600
	// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00005E76 File Offset: 0x00004076
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000A29 RID: 2601
	// (get) Token: 0x06002C61 RID: 11361 RVA: 0x0001DA03 File Offset: 0x0001BC03
	object ICollection.SyncRoot
	{
		get
		{
			return this;
		}
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x0001DA06 File Offset: 0x0001BC06
	void ICollection.CopyTo(Array array, int index)
	{
		this.gparam_0.CopyTo(array, index);
	}

	// Token: 0x17000A2A RID: 2602
	object IList.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000A2B RID: 2603
	// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000A2C RID: 2604
	// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x00003657 File Offset: 0x00001857
	int IList.Add(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x0001DA28 File Offset: 0x0001BC28
	bool IList.Contains(object value)
	{
		return ((ICollection<T>)this.gparam_0).Contains((T)((object)value));
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x0001DA36 File Offset: 0x0001BC36
	int IList.IndexOf(object value)
	{
		return Array.IndexOf(this.gparam_0, value);
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Insert(int index, object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Remove(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00003657 File Offset: 0x00001857
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x0001DA44 File Offset: 0x0001BC44
	public IEnumerator<T> GetEnumerator()
	{
		return ((IEnumerable<T>)this.gparam_0).GetEnumerator();
	}

	// Token: 0x17000A2D RID: 2605
	// (get) Token: 0x06002C6F RID: 11375 RVA: 0x0001D9F9 File Offset: 0x0001BBF9
	int IReadOnlyCollection<T>.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x17000A2E RID: 2606
	T IReadOnlyList<T>.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
	}

	// Token: 0x17000A2F RID: 2607
	// (get) Token: 0x06002C71 RID: 11377 RVA: 0x0001D9F9 File Offset: 0x0001BBF9
	int ICollection<T>.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x17000A30 RID: 2608
	// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool ICollection<T>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x00003657 File Offset: 0x00001857
	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x00003657 File Offset: 0x00001857
	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x0001DA5F File Offset: 0x0001BC5F
	bool ICollection<T>.Contains(T item)
	{
		return ((ICollection<T>)this.gparam_0).Contains(item);
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x0001DA6D File Offset: 0x0001BC6D
	void ICollection<T>.CopyTo(T[] array, int arrayIndex)
	{
		this.gparam_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x00003657 File Offset: 0x00001857
	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17000A31 RID: 2609
	T IList<T>.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x0001DA7C File Offset: 0x0001BC7C
	int IList<T>.IndexOf(T item)
	{
		return Array.IndexOf<T>(this.gparam_0, item);
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x00003657 File Offset: 0x00001857
	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x00003657 File Offset: 0x00001857
	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04002118 RID: 8472
	[CompilerGenerated]
	private readonly T[] gparam_0;
}
