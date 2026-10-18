using System;
using System.Runtime.InteropServices;

// Token: 0x020001B8 RID: 440
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GStruct11
{
	// Token: 0x0400100D RID: 4109
	[FieldOffset(4)]
	public uint DataEntryRva;

	// Token: 0x0400100E RID: 4110
	[FieldOffset(0)]
	public uint IntegerId;

	// Token: 0x0400100F RID: 4111
	[FieldOffset(0)]
	public uint NameRva;

	// Token: 0x04001010 RID: 4112
	[FieldOffset(4)]
	public uint SubdirectoryRva;
}
