using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200016F RID: 367
internal class Class250
{
	// Token: 0x060015F8 RID: 5624 RVA: 0x0000F865 File Offset: 0x0000DA65
	public Class250(int int_3)
	{
		this.int_2 = int_3;
		this.method_0();
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0000F885 File Offset: 0x0000DA85
	// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000F88D File Offset: 0x0000DA8D
	public bool Boolean_0 { get; set; }

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x060015FB RID: 5627 RVA: 0x0000F896 File Offset: 0x0000DA96
	// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000F89E File Offset: 0x0000DA9E
	public List<GStruct0> List_0 { get; set; } = new List<GStruct0>();

	// Token: 0x060015FD RID: 5629
	[DllImport("kernel32.dll", SetLastError = true)]
	protected static extern IntPtr OpenProcess(int int_3, bool bool_1, int int_4);

	// Token: 0x060015FE RID: 5630
	[DllImport("kernel32.dll", SetLastError = true)]
	protected static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x060015FF RID: 5631
	[DllImport("kernel32.dll", SetLastError = true)]
	protected static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_3, out int int_4);

	// Token: 0x06001600 RID: 5632
	[DllImport("kernel32.dll", SetLastError = true)]
	protected static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GStruct0 gstruct0_0, int int_3);

	// Token: 0x06001601 RID: 5633
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_1);

	// Token: 0x06001602 RID: 5634 RVA: 0x000ADCDC File Offset: 0x000ABEDC
	protected void method_0()
	{
		IntPtr intPtr = Class250.OpenProcess(1040, false, this.int_2);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			bool flag = Class250.smethod_2(intPtr);
			IntPtr zero = IntPtr.Zero;
			int num = Marshal.SizeOf(typeof(GStruct0));
			GStruct0 gstruct;
			do
			{
				gstruct = default(GStruct0);
				if (Class250.VirtualQueryEx(intPtr, zero, out gstruct, num) == 0)
				{
					break;
				}
				if ((gstruct.uint_1 & 4096U) != 0U && (gstruct.uint_2 & 256U) == 0U)
				{
					this.List_0.Add(gstruct);
				}
			}
			while (Class250.smethod_3(gstruct, flag, out zero));
			this.List_0.Reverse();
		}
		finally
		{
			Class250.CloseHandle(intPtr);
		}
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0000F8A7 File Offset: 0x0000DAA7
	public static List<GStruct0> smethod_0(int int_3)
	{
		return Class250.smethod_1(int_3);
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x000ADD9C File Offset: 0x000ABF9C
	private static List<GStruct0> smethod_1(int int_3)
	{
		List<GStruct0> list = new List<GStruct0>(1024);
		IntPtr intPtr = Class250.OpenProcess(1040, false, int_3);
		if (intPtr == IntPtr.Zero)
		{
			return list;
		}
		try
		{
			bool flag = Class250.smethod_2(intPtr);
			IntPtr zero = IntPtr.Zero;
			int num = Marshal.SizeOf(typeof(GStruct0));
			GStruct0 gstruct;
			do
			{
				gstruct = default(GStruct0);
				if (Class250.VirtualQueryEx(intPtr, zero, out gstruct, num) == 0)
				{
					break;
				}
				bool flag2 = (gstruct.uint_1 & 4096U) > 0U;
				bool flag3 = (gstruct.uint_2 & 256U) == 0U;
				bool flag4 = (gstruct.uint_2 & 1U) == 0U;
				if (flag2 && flag3 && flag4)
				{
					list.Add(gstruct);
				}
			}
			while (Class250.smethod_3(gstruct, flag, out zero));
		}
		finally
		{
			Class250.CloseHandle(intPtr);
		}
		return list;
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x000ADE70 File Offset: 0x000AC070
	private static bool smethod_2(IntPtr intptr_0)
	{
		bool flag;
		return !Environment.Is64BitProcess || (Class250.IsWow64Process(intptr_0, out flag) && flag);
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x000ADE94 File Offset: 0x000AC094
	private static bool smethod_3(GStruct0 gstruct0_0, bool bool_1, out IntPtr intptr_0)
	{
		intptr_0 = IntPtr.Zero;
		ulong num = (ulong)gstruct0_0.intptr_0.ToInt64();
		ulong num2 = gstruct0_0.uintptr_0.ToUInt64();
		if (num2 == 0UL)
		{
			return false;
		}
		ulong num3 = num + num2;
		if (num3 <= num)
		{
			return false;
		}
		if (bool_1 && num3 > 4294967295UL)
		{
			return false;
		}
		intptr_0 = new IntPtr((long)num3);
		return true;
	}

	// Token: 0x04000D51 RID: 3409
	private const int int_0 = 1024;

	// Token: 0x04000D52 RID: 3410
	private const int int_1 = 16;

	// Token: 0x04000D53 RID: 3411
	protected int int_2;

	// Token: 0x04000D54 RID: 3412
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04000D55 RID: 3413
	[CompilerGenerated]
	private List<GStruct0> list_0;
}
