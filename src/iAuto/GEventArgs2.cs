using System;

// Token: 0x0200002A RID: 42
public class GEventArgs2 : EventArgs
{
	// Token: 0x0600015B RID: 347 RVA: 0x00003F38 File Offset: 0x00002138
	internal GEventArgs2(Class31 class31_0)
	{
		this.enum2_0 = class31_0.Enum2_0;
		this.byte_0 = class31_0.Class19_0.Byte_0;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00003F5D File Offset: 0x0000215D
	internal GEventArgs2(Enum2 enum2_1, byte[] byte_1)
	{
		if ((long)byte_1.Length > (long)Class19.ulong_0)
		{
			throw new GException0(GEnum2.TooBig);
		}
		this.enum2_0 = enum2_1;
		this.byte_0 = byte_1;
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600015D RID: 349 RVA: 0x00003F88 File Offset: 0x00002188
	internal Enum2 Enum2_0
	{
		get
		{
			return this.enum2_0;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600015E RID: 350 RVA: 0x00003F90 File Offset: 0x00002190
	public string String_0
	{
		get
		{
			this.method_0();
			return this.string_0;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600015F RID: 351 RVA: 0x00003F9E File Offset: 0x0000219E
	public bool Boolean_0
	{
		get
		{
			return this.enum2_0 == Enum2.Binary;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000160 RID: 352 RVA: 0x00003FA9 File Offset: 0x000021A9
	public bool Boolean_1
	{
		get
		{
			return this.enum2_0 == Enum2.Ping;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000161 RID: 353 RVA: 0x00003FB5 File Offset: 0x000021B5
	public bool Boolean_2
	{
		get
		{
			return this.enum2_0 == Enum2.Text;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000162 RID: 354 RVA: 0x00003FC0 File Offset: 0x000021C0
	public byte[] Byte_0
	{
		get
		{
			this.method_0();
			return this.byte_0;
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00003FCE File Offset: 0x000021CE
	private void method_0()
	{
		if (this.bool_0)
		{
			return;
		}
		if (this.enum2_0 == Enum2.Binary)
		{
			this.bool_0 = true;
			return;
		}
		this.string_0 = this.byte_0.smethod_75();
		this.bool_0 = true;
	}

	// Token: 0x040000CF RID: 207
	private string string_0;

	// Token: 0x040000D0 RID: 208
	private bool bool_0;

	// Token: 0x040000D1 RID: 209
	private Enum2 enum2_0;

	// Token: 0x040000D2 RID: 210
	private byte[] byte_0;
}
