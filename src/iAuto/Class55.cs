using System;

// Token: 0x0200005E RID: 94
internal class Class55
{
	// Token: 0x060003E7 RID: 999 RVA: 0x00005985 File Offset: 0x00003B85
	public Class55(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00005994 File Offset: 0x00003B94
	public int Int32_0
	{
		get
		{
			return this.byte_0.Length - this.int_0;
		}
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x0002A668 File Offset: 0x00028868
	public int method_0(byte[] byte_1, int int_1, int int_2)
	{
		int num = this.byte_0.Length - this.int_0;
		if (num == 0)
		{
			return num;
		}
		if (int_2 > num)
		{
			int_2 = num;
		}
		Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_1, int_2);
		this.int_0 += int_2;
		return int_2;
	}

	// Token: 0x040001DC RID: 476
	private byte[] byte_0;

	// Token: 0x040001DD RID: 477
	private int int_0;
}
