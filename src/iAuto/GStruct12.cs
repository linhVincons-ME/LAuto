using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020001B9 RID: 441
[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct12
{
	// Token: 0x0600185A RID: 6234 RVA: 0x000CBCF4 File Offset: 0x000C9EF4
	public override string ToString()
	{
		string text = Encoding.UTF8.GetString(this.Name);
		if (text.Contains("\0"))
		{
			text = text.Substring(0, text.IndexOf("\0"));
		}
		return text;
	}

	// Token: 0x04001011 RID: 4113
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public byte[] Name;

	// Token: 0x04001012 RID: 4114
	public uint VirtualSize;

	// Token: 0x04001013 RID: 4115
	public uint VirtualAddress;

	// Token: 0x04001014 RID: 4116
	public uint SizeOfRawData;

	// Token: 0x04001015 RID: 4117
	public uint PointerToRawData;

	// Token: 0x04001016 RID: 4118
	public uint PointerToRelocations;

	// Token: 0x04001017 RID: 4119
	public uint PointerToLineNumbers;

	// Token: 0x04001018 RID: 4120
	public ushort NumberOfRelocations;

	// Token: 0x04001019 RID: 4121
	public ushort NumberOfLineNumbers;

	// Token: 0x0400101A RID: 4122
	public uint Characteristics;
}
