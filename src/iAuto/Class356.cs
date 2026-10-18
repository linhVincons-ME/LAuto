using System;
using System.Runtime.InteropServices;

// Token: 0x02000220 RID: 544
internal static class Class356
{
	// Token: 0x06001DBB RID: 7611
	[DllImport("kernel32.dll")]
	private static extern void GetNativeSystemInfo(ref Class356.Struct35 struct35_0);

	// Token: 0x06001DBC RID: 7612
	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Class356.Struct35 struct35_0);

	// Token: 0x06001DBD RID: 7613 RVA: 0x000E082C File Offset: 0x000DEA2C
	public static GEnum20 smethod_0()
	{
		Class356.Struct35 @struct = default(Class356.Struct35);
		if (Environment.OSVersion.Version.Major <= 5 && (Environment.OSVersion.Version.Major != 5 || Environment.OSVersion.Version.Minor < 1))
		{
			Class356.GetSystemInfo(ref @struct);
		}
		else
		{
			Class356.GetNativeSystemInfo(ref @struct);
		}
		ushort num = @struct.ushort_0;
		if (num != 0)
		{
			if (num != 6)
			{
				if (num != 9)
				{
					return GEnum20.Unknown;
				}
			}
			return GEnum20.X64;
		}
		return GEnum20.X86;
	}

	// Token: 0x04001296 RID: 4758
	private const ushort ushort_0 = 0;

	// Token: 0x04001297 RID: 4759
	private const ushort ushort_1 = 6;

	// Token: 0x04001298 RID: 4760
	private const ushort ushort_2 = 9;

	// Token: 0x02000221 RID: 545
	private struct Struct35
	{
		// Token: 0x04001299 RID: 4761
		public ushort ushort_0;

		// Token: 0x0400129A RID: 4762
		public ushort ushort_1;

		// Token: 0x0400129B RID: 4763
		public uint uint_0;

		// Token: 0x0400129C RID: 4764
		public IntPtr intptr_0;

		// Token: 0x0400129D RID: 4765
		public IntPtr intptr_1;

		// Token: 0x0400129E RID: 4766
		public UIntPtr uintptr_0;

		// Token: 0x0400129F RID: 4767
		public uint uint_1;

		// Token: 0x040012A0 RID: 4768
		public uint uint_2;

		// Token: 0x040012A1 RID: 4769
		public uint uint_3;

		// Token: 0x040012A2 RID: 4770
		public ushort ushort_2;

		// Token: 0x040012A3 RID: 4771
		public ushort ushort_3;
	}
}
