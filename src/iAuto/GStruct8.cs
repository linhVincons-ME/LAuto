using System;
using System.Runtime.InteropServices;

// Token: 0x020001B5 RID: 437
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct8
{
	// Token: 0x04000FE4 RID: 4068
	public ushort Magic;

	// Token: 0x04000FE5 RID: 4069
	public byte MajorLinkerVersion;

	// Token: 0x04000FE6 RID: 4070
	public byte MinorLinkerVersion;

	// Token: 0x04000FE7 RID: 4071
	public uint SizeOfCode;

	// Token: 0x04000FE8 RID: 4072
	public uint SizeOfInitializedData;

	// Token: 0x04000FE9 RID: 4073
	public uint SizeOfUninitializedData;

	// Token: 0x04000FEA RID: 4074
	public uint AddressOfEntryPoint;

	// Token: 0x04000FEB RID: 4075
	public uint BaseOfCode;

	// Token: 0x04000FEC RID: 4076
	public uint BaseOfData;

	// Token: 0x04000FED RID: 4077
	public uint ImageBase;

	// Token: 0x04000FEE RID: 4078
	public uint SectionAlignment;

	// Token: 0x04000FEF RID: 4079
	public uint FileAlignment;

	// Token: 0x04000FF0 RID: 4080
	public ushort MajorOperatingSystemVersion;

	// Token: 0x04000FF1 RID: 4081
	public ushort MinorOperatingSystemVersion;

	// Token: 0x04000FF2 RID: 4082
	public ushort MajorImageVersion;

	// Token: 0x04000FF3 RID: 4083
	public ushort MinorImageVersion;

	// Token: 0x04000FF4 RID: 4084
	public ushort MajorSubsystemVersion;

	// Token: 0x04000FF5 RID: 4085
	public ushort MinorSubsystemVersion;

	// Token: 0x04000FF6 RID: 4086
	public uint Win32VersionValue;

	// Token: 0x04000FF7 RID: 4087
	public uint SizeOfImage;

	// Token: 0x04000FF8 RID: 4088
	public uint SizeOfHeaders;

	// Token: 0x04000FF9 RID: 4089
	public uint CheckSum;

	// Token: 0x04000FFA RID: 4090
	public ushort Subsystem;

	// Token: 0x04000FFB RID: 4091
	public ushort DllCharacteristics;

	// Token: 0x04000FFC RID: 4092
	public uint SizeOfStackReserve;

	// Token: 0x04000FFD RID: 4093
	public uint SizeOfStackCommit;

	// Token: 0x04000FFE RID: 4094
	public uint SizeOfHeapReserve;

	// Token: 0x04000FFF RID: 4095
	public uint SizeOfHeapCommit;

	// Token: 0x04001000 RID: 4096
	public uint LoaderFlags;

	// Token: 0x04001001 RID: 4097
	public uint NumberOfRvaAndSizes;

	// Token: 0x04001002 RID: 4098
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public GStruct3[] DataDirectory;
}
