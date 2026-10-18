using System;
using System.Runtime.InteropServices;

// Token: 0x0200018A RID: 394
public static class GClass36
{
	// Token: 0x06001716 RID: 5910
	[DllImport("psapi.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetPerformanceInfo(out GClass36.GStruct1 gstruct1_0, [In] int int_0);

	// Token: 0x06001717 RID: 5911 RVA: 0x000B4454 File Offset: 0x000B2654
	public static long smethod_0()
	{
		GClass36.GStruct1 gstruct = default(GClass36.GStruct1);
		if (GClass36.GetPerformanceInfo(out gstruct, Marshal.SizeOf<GClass36.GStruct1>(gstruct)))
		{
			return Convert.ToInt64(gstruct.intptr_4.ToInt64() * gstruct.intptr_9.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x000B44AC File Offset: 0x000B26AC
	public static long smethod_1()
	{
		GClass36.GStruct1 gstruct = default(GClass36.GStruct1);
		if (GClass36.GetPerformanceInfo(out gstruct, Marshal.SizeOf<GClass36.GStruct1>(gstruct)))
		{
			return Convert.ToInt64(gstruct.intptr_3.ToInt64() * gstruct.intptr_9.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x0200018B RID: 395
	public struct GStruct1
	{
		// Token: 0x04000DFC RID: 3580
		public int int_0;

		// Token: 0x04000DFD RID: 3581
		public IntPtr intptr_0;

		// Token: 0x04000DFE RID: 3582
		public IntPtr intptr_1;

		// Token: 0x04000DFF RID: 3583
		public IntPtr intptr_2;

		// Token: 0x04000E00 RID: 3584
		public IntPtr intptr_3;

		// Token: 0x04000E01 RID: 3585
		public IntPtr intptr_4;

		// Token: 0x04000E02 RID: 3586
		public IntPtr intptr_5;

		// Token: 0x04000E03 RID: 3587
		public IntPtr intptr_6;

		// Token: 0x04000E04 RID: 3588
		public IntPtr intptr_7;

		// Token: 0x04000E05 RID: 3589
		public IntPtr intptr_8;

		// Token: 0x04000E06 RID: 3590
		public IntPtr intptr_9;

		// Token: 0x04000E07 RID: 3591
		public int int_1;

		// Token: 0x04000E08 RID: 3592
		public int int_2;

		// Token: 0x04000E09 RID: 3593
		public int int_3;
	}
}
