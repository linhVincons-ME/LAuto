using System;
using System.Runtime.InteropServices;

// Token: 0x020001B3 RID: 435
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct6
{
	// Token: 0x04000FDC RID: 4060
	public uint OriginalFirstThunk;

	// Token: 0x04000FDD RID: 4061
	public uint TimeDateStamp;

	// Token: 0x04000FDE RID: 4062
	public uint ForwarderChain;

	// Token: 0x04000FDF RID: 4063
	public uint Name;

	// Token: 0x04000FE0 RID: 4064
	public uint FirstThunkPtr;
}
