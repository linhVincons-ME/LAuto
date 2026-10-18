using System;
using System.Runtime.InteropServices;

// Token: 0x020001B4 RID: 436
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct7
{
	// Token: 0x04000FE1 RID: 4065
	public int Signature;

	// Token: 0x04000FE2 RID: 4066
	public GStruct5 FileHeader;

	// Token: 0x04000FE3 RID: 4067
	public GStruct8 OptionalHeader;
}
