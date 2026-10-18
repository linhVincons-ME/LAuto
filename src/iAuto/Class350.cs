using System;
using System.Runtime.CompilerServices;

// Token: 0x02000216 RID: 534
internal class Class350<T>
{
	// Token: 0x06001D52 RID: 7506 RVA: 0x00013D82 File Offset: 0x00011F82
	public Class350(int int_2)
	{
		this.gparam_0 = new T[int_2];
		this.Int32_1 = 0;
		this.int_0 = 0;
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00013DA4 File Offset: 0x00011FA4
	public int Int32_0
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00013DAE File Offset: 0x00011FAE
	// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00013DB6 File Offset: 0x00011FB6
	public int Int32_1 { get; private set; }

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00013DBF File Offset: 0x00011FBF
	private int Int32_2
	{
		get
		{
			return (this.int_0 + this.Int32_1 - 1) % this.gparam_0.Length;
		}
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x000E00BC File Offset: 0x000DE2BC
	public T method_0()
	{
		if (this.Int32_1 == 0)
		{
			throw new Exception("Stack is empty");
		}
		int int32_ = this.Int32_2;
		T t = this.gparam_0[int32_];
		this.gparam_0[int32_] = default(T);
		int int32_2 = this.Int32_1;
		this.Int32_1 = int32_2 - 1;
		return t;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000E0114 File Offset: 0x000DE314
	public T method_1()
	{
		if (this.Int32_1 == 0)
		{
			return default(T);
		}
		return this.gparam_0[this.Int32_2];
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000E0144 File Offset: 0x000DE344
	public void method_2(T gparam_1)
	{
		if (this.Int32_1 == this.gparam_0.Length)
		{
			this.int_0 = (this.int_0 + 1) % this.gparam_0.Length;
		}
		else
		{
			int int32_ = this.Int32_1;
			this.Int32_1 = int32_ + 1;
		}
		this.gparam_0[this.Int32_2] = gparam_1;
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x00013DD9 File Offset: 0x00011FD9
	public void method_3()
	{
		this.gparam_0 = new T[this.gparam_0.Length];
		this.Int32_1 = 0;
		this.int_0 = 0;
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000E019C File Offset: 0x000DE39C
	public T[] method_4()
	{
		T[] array = new T[this.Int32_1];
		for (int i = 0; i < this.Int32_1; i++)
		{
			array[i] = this.gparam_0[(this.int_0 + i) % this.gparam_0.Length];
		}
		return array;
	}

	// Token: 0x04001273 RID: 4723
	private T[] gparam_0;

	// Token: 0x04001274 RID: 4724
	private int int_0;

	// Token: 0x04001275 RID: 4725
	[CompilerGenerated]
	private int int_1;
}
