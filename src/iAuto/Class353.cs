using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200021C RID: 540
internal class Class353 : IEnumerable<string>, ICollection<string>, IEnumerable, IList<string>
{
	// Token: 0x06001D89 RID: 7561 RVA: 0x0001400F File Offset: 0x0001220F
	public Class353(IList<Class351> ilist_1)
	{
		this.ilist_0 = ilist_1;
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000E0370 File Offset: 0x000DE570
	public int IndexOf(string item)
	{
		for (int i = 0; i < this.ilist_0.Count; i++)
		{
			if (this.ilist_0[i].String_2 == item)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x00011A79 File Offset: 0x0000FC79
	public void Insert(int index, string item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x00011A79 File Offset: 0x0000FC79
	public void RemoveAt(int index)
	{
		throw new NotImplementedException();
	}

	// Token: 0x170005E0 RID: 1504
	public string this[int index]
	{
		get
		{
			return this.ilist_0[index].String_2;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x00011A79 File Offset: 0x0000FC79
	public void Add(string item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x00011A79 File Offset: 0x0000FC79
	public void Clear()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000E03B0 File Offset: 0x000DE5B0
	public bool Contains(string item)
	{
		for (int i = 0; i < this.ilist_0.Count; i++)
		{
			if (this.ilist_0[i].String_2 == item)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000E03F0 File Offset: 0x000DE5F0
	public void CopyTo(string[] array, int arrayIndex)
	{
		for (int i = 0; i < this.ilist_0.Count; i++)
		{
			array[i + arrayIndex] = this.ilist_0[i].String_2;
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00014031 File Offset: 0x00012231
	public int Count
	{
		get
		{
			return this.ilist_0.Count;
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00005BAB File Offset: 0x00003DAB
	public bool IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x00011A79 File Offset: 0x0000FC79
	public bool Remove(string item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x0001403E File Offset: 0x0001223E
	public IEnumerator<string> GetEnumerator()
	{
		Class353.Class354 @class = new Class353.Class354(0);
		@class.class353_0 = this;
		return @class;
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x0001404D File Offset: 0x0001224D
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x0400128B RID: 4747
	private readonly IList<Class351> ilist_0;

	// Token: 0x0200021D RID: 541
	[CompilerGenerated]
	private sealed class Class354 : IEnumerator<string>, IDisposable, IEnumerator
	{
		// Token: 0x06001D98 RID: 7576 RVA: 0x00014055 File Offset: 0x00012255
		[DebuggerHidden]
		public Class354(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00014064 File Offset: 0x00012264
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000E042C File Offset: 0x000DE62C
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			Class353 @class = this.class353_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
			}
			else
			{
				this.int_0 = -1;
				this.int_1 = 0;
			}
			if (this.int_1 >= @class.ilist_0.Count)
			{
				return false;
			}
			this.string_0 = @class.ilist_0[this.int_1].String_2;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0001406E File Offset: 0x0001226E
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0001406E File Offset: 0x0001226E
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0400128C RID: 4748
		private int int_0;

		// Token: 0x0400128D RID: 4749
		private string string_0;

		// Token: 0x0400128E RID: 4750
		public Class353 class353_0;

		// Token: 0x0400128F RID: 4751
		private int int_1;
	}
}
