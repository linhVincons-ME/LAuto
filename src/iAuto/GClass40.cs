using System;

// Token: 0x020001C4 RID: 452
public static class GClass40
{
	// Token: 0x0600188D RID: 6285 RVA: 0x00010E38 File Offset: 0x0000F038
	public static IntPtr smethod_0(this IntPtr intptr_0, long long_0)
	{
		return new IntPtr(intptr_0.ToInt64() + long_0);
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x00010E48 File Offset: 0x0000F048
	public static IntPtr smethod_1(this IntPtr intptr_0, IntPtr intptr_1)
	{
		return new IntPtr(intptr_0.ToInt64() + intptr_1.ToInt64());
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x00010E5E File Offset: 0x0000F05E
	public static bool smethod_2(this IntPtr intptr_0, long long_0)
	{
		return intptr_0.ToInt64() == long_0;
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x00010E6A File Offset: 0x0000F06A
	public static IntPtr smethod_3(long long_0)
	{
		return new IntPtr(long_0);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x00010E72 File Offset: 0x0000F072
	public static bool smethod_4(this IntPtr intptr_0)
	{
		return intptr_0 == IntPtr.Zero;
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x00010E7F File Offset: 0x0000F07F
	public static bool smethod_5(this UIntPtr uintptr_0)
	{
		return uintptr_0 == UIntPtr.Zero;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x00010E8C File Offset: 0x0000F08C
	public static IntPtr smethod_6(this IntPtr intptr_0, long long_0)
	{
		return new IntPtr(intptr_0.ToInt64() - long_0);
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x00010E9C File Offset: 0x0000F09C
	public static IntPtr smethod_7(this IntPtr intptr_0, IntPtr intptr_1)
	{
		return new IntPtr(intptr_0.ToInt64() - intptr_1.ToInt64());
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00007CD7 File Offset: 0x00005ED7
	public static int smethod_8(this IntPtr intptr_0)
	{
		return (int)intptr_0.ToInt64();
	}
}
