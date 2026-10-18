using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000371 RID: 881
[CompilerGenerated]
internal sealed class Class619<T> : IEnumerable, ICollection, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, IList, ICollection<T>, IList<T>
{
	// Token: 0x06002C7D RID: 11389 RVA: 0x0001DA8A File Offset: 0x0001BC8A
	public Class619(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x0001DA99 File Offset: 0x0001BC99
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Class619<T>.Class620(this.gparam_0);
	}

	// Token: 0x17000A32 RID: 2610
	// (get) Token: 0x06002C7F RID: 11391 RVA: 0x00005BAB File Offset: 0x00003DAB
	int ICollection.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A33 RID: 2611
	// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00005E76 File Offset: 0x00004076
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000A34 RID: 2612
	// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0001DA03 File Offset: 0x0001BC03
	object ICollection.SyncRoot
	{
		get
		{
			return this;
		}
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x0001DAA6 File Offset: 0x0001BCA6
	void ICollection.CopyTo(Array array, int index)
	{
		array.SetValue(this.gparam_0, index);
	}

	// Token: 0x17000A35 RID: 2613
	object IList.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this.gparam_0;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000A36 RID: 2614
	// (get) Token: 0x06002C85 RID: 11397 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000A37 RID: 2615
	// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06002C87 RID: 11399 RVA: 0x00003657 File Offset: 0x00001857
	int IList.Add(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
	bool IList.Contains(object value)
	{
		return EqualityComparer<T>.Default.Equals(this.gparam_0, (T)((object)value));
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
	int IList.IndexOf(object value)
	{
		if (!EqualityComparer<T>.Default.Equals(this.gparam_0, (T)((object)value)))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Insert(int index, object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00003657 File Offset: 0x00001857
	void IList.Remove(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x00003657 File Offset: 0x00001857
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x0001DA99 File Offset: 0x0001BC99
	public IEnumerator<T> GetEnumerator()
	{
		return new Class619<T>.Class620(this.gparam_0);
	}

	// Token: 0x17000A38 RID: 2616
	// (get) Token: 0x06002C8F RID: 11407 RVA: 0x00005BAB File Offset: 0x00003DAB
	int IReadOnlyCollection<T>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A39 RID: 2617
	T IReadOnlyList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this.gparam_0;
		}
	}

	// Token: 0x17000A3A RID: 2618
	// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00005BAB File Offset: 0x00003DAB
	int ICollection<T>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A3B RID: 2619
	// (get) Token: 0x06002C92 RID: 11410 RVA: 0x00005BAB File Offset: 0x00003DAB
	bool ICollection<T>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x00003657 File Offset: 0x00001857
	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x00003657 File Offset: 0x00001857
	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x0001DB16 File Offset: 0x0001BD16
	bool ICollection<T>.Contains(T item)
	{
		return EqualityComparer<T>.Default.Equals(this.gparam_0, item);
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x0001DB29 File Offset: 0x0001BD29
	void ICollection<T>.CopyTo(T[] array, int arrayIndex)
	{
		array[arrayIndex] = this.gparam_0;
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x00003657 File Offset: 0x00001857
	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17000A3C RID: 2620
	T IList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this.gparam_0;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x0001DB38 File Offset: 0x0001BD38
	int IList<T>.IndexOf(T item)
	{
		if (!EqualityComparer<T>.Default.Equals(this.gparam_0, item))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x00003657 File Offset: 0x00001857
	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x00003657 File Offset: 0x00001857
	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04002119 RID: 8473
	[CompilerGenerated]
	private readonly T gparam_0;

	// Token: 0x02000372 RID: 882
	private sealed class Class620 : IDisposable, IEnumerator, IEnumerator<T>
	{
		// Token: 0x06002C9D RID: 11421 RVA: 0x0001DB50 File Offset: 0x0001BD50
		public Class620(T gparam_1)
		{
			this.gparam_0 = gparam_1;
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x0001DB5F File Offset: 0x0001BD5F
		object IEnumerator.Current
		{
			get
			{
				return this.gparam_0;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		public T Current
		{
			get
			{
				return this.gparam_0;
			}
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0001DB74 File Offset: 0x0001BD74
		bool IEnumerator.MoveNext()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				return true;
			}
			return false;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0001DB88 File Offset: 0x0001BD88
		void IEnumerator.Reset()
		{
			this.bool_0 = false;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0000500B File Offset: 0x0000320B
		public void Dispose()
		{
		}

		// Token: 0x0400211A RID: 8474
		[CompilerGenerated]
		private readonly T gparam_0;

		// Token: 0x0400211B RID: 8475
		[CompilerGenerated]
		private bool bool_0;
	}
}
