using System;
using System.Runtime.InteropServices;

// Token: 0x020001B2 RID: 434
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct5
{
	// Token: 0x04000FD5 RID: 4053
	public ushort Machine;

	// Token: 0x04000FD6 RID: 4054
	public ushort NumberOfSections;

	// Token: 0x04000FD7 RID: 4055
	public uint TimeDateStamp;

	// Token: 0x04000FD8 RID: 4056
	public uint PointerToSymbolTable;

	// Token: 0x04000FD9 RID: 4057
	public uint NumberOfSymbols;

	// Token: 0x04000FDA RID: 4058
	public ushort SizeOfOptionalHeader;

	// Token: 0x04000FDB RID: 4059
	public ushort Characteristics;
}
