using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000005 RID: 5
public static class GClass1
{
	// Token: 0x06000011 RID: 17
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint uint_9, bool bool_0, int int_2);

	// Token: 0x06000012 RID: 18
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000013 RID: 19
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	// Token: 0x06000014 RID: 20
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, uint uint_9, out uint uint_10, uint uint_11);

	// Token: 0x06000015 RID: 21
	[DllImport("psapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint GetModuleFileNameExW(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_9);

	// Token: 0x06000016 RID: 22
	[DllImport("psapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint GetModuleBaseNameW(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_9);

	// Token: 0x06000017 RID: 23
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out GClass1.Struct1 struct1_0, uint uint_9);

	// Token: 0x06000018 RID: 24
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_9, uint uint_10);

	// Token: 0x06000019 RID: 25
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_0, ref GClass1.Struct0 struct0_0);

	// Token: 0x0600001A RID: 26
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_0, ref GClass1.Struct0 struct0_0);

	// Token: 0x0600001B RID: 27 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
	public static IReadOnlyList<GClass0> smethod_0(int int_2)
	{
		List<GClass0> list = GClass1.smethod_2(int_2);
		if (list.Count > 0)
		{
			return list;
		}
		return GClass1.smethod_4(int_2);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000339B File Offset: 0x0000159B
	public static IReadOnlyList<GClass0> smethod_1(Process process_0)
	{
		if (process_0 == null)
		{
			throw new ArgumentNullException("process");
		}
		return GClass1.smethod_0(process_0.Id);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0001DC10 File Offset: 0x0001BE10
	private static List<GClass0> smethod_2(int int_2)
	{
		List<GClass0> list = new List<GClass0>();
		IntPtr intPtr = GClass1.OpenProcess(5136U, false, int_2);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = GClass1.OpenProcess(4112U, false, int_2);
			if (intPtr == IntPtr.Zero)
			{
				return list;
			}
		}
		try
		{
			uint num = GClass1.smethod_3(intPtr);
			uint num2;
			if (!GClass1.EnumProcessModulesEx(intPtr, Array.Empty<IntPtr>(), 0U, out num2, num) && num2 == 0U)
			{
				return list;
			}
			int num3 = (int)(num2 / (uint)IntPtr.Size);
			if (num3 <= 0)
			{
				return list;
			}
			IntPtr[] array = new IntPtr[num3];
			if (!GClass1.EnumProcessModulesEx(intPtr, array, (uint)(array.Length * IntPtr.Size), out num2, num))
			{
				num3 = (int)(num2 / (uint)IntPtr.Size);
				if (num3 <= 0)
				{
					return list;
				}
				array = new IntPtr[num3];
				uint num4;
				if (!GClass1.EnumProcessModulesEx(intPtr, array, (uint)(array.Length * IntPtr.Size), out num4, num))
				{
					return list;
				}
			}
			StringBuilder stringBuilder = new StringBuilder(260);
			StringBuilder stringBuilder2 = new StringBuilder(1040);
			foreach (IntPtr intPtr2 in array)
			{
				if (!(intPtr2 == IntPtr.Zero))
				{
					stringBuilder.Clear();
					stringBuilder2.Clear();
					GClass1.GetModuleBaseNameW(intPtr, intPtr2, stringBuilder, (uint)stringBuilder.Capacity);
					GClass1.GetModuleFileNameExW(intPtr, intPtr2, stringBuilder2, (uint)stringBuilder2.Capacity);
					uint num5 = 0U;
					IntPtr intPtr3 = IntPtr.Zero;
					IntPtr intPtr4 = intPtr2;
					GClass1.Struct1 @struct;
					if (GClass1.GetModuleInformation(intPtr, intPtr2, out @struct, (uint)Marshal.SizeOf<GClass1.Struct1>()))
					{
						intPtr4 = @struct.intptr_0;
						num5 = @struct.uint_0;
						intPtr3 = @struct.intptr_1;
					}
					list.Add(new GClass0
					{
						String_0 = stringBuilder.ToString(),
						String_1 = stringBuilder2.ToString(),
						IntPtr_0 = intPtr4,
						UInt32_0 = num5,
						IntPtr_1 = intPtr3
					});
				}
			}
		}
		finally
		{
			GClass1.CloseHandle(intPtr);
		}
		return list;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0001DE14 File Offset: 0x0001C014
	private static uint smethod_3(IntPtr intptr_0)
	{
		if (!Environment.Is64BitProcess)
		{
			return 0U;
		}
		bool flag;
		if (GClass1.IsWow64Process(intptr_0, out flag) && flag)
		{
			return 1U;
		}
		return 3U;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0001DE3C File Offset: 0x0001C03C
	private static List<GClass0> smethod_4(int int_2)
	{
		List<GClass0> list = new List<GClass0>();
		IntPtr intPtr = GClass1.CreateToolhelp32Snapshot(24U, (uint)int_2);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == new IntPtr(-1)))
		{
			try
			{
				GClass1.Struct0 @struct = new GClass1.Struct0
				{
					uint_0 = (uint)Marshal.SizeOf<GClass1.Struct0>()
				};
				if (!GClass1.Module32FirstW(intPtr, ref @struct))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 18)
					{
						return list;
					}
					throw new Win32Exception(lastWin32Error, string.Format("Module32FirstW thất bại cho PID {0}", int_2));
				}
				else
				{
					do
					{
						List<GClass0> list2 = list;
						GClass0 gclass = new GClass0();
						string text;
						if ((text = @struct.string_0) == null)
						{
							text = string.Empty;
						}
						gclass.String_0 = text;
						gclass.String_1 = @struct.string_1 ?? string.Empty;
						gclass.IntPtr_0 = @struct.intptr_0;
						gclass.UInt32_0 = @struct.uint_5;
						gclass.IntPtr_1 = IntPtr.Zero;
						list2.Add(gclass);
					}
					while (GClass1.Module32NextW(intPtr, ref @struct));
				}
			}
			finally
			{
				GClass1.CloseHandle(intPtr);
			}
			return list;
		}
		throw new Win32Exception(Marshal.GetLastWin32Error(), string.Format("Không tạo được snapshot cho PID {0}", int_2));
	}

	// Token: 0x04000007 RID: 7
	private const uint uint_0 = 1024U;

	// Token: 0x04000008 RID: 8
	private const uint uint_1 = 16U;

	// Token: 0x04000009 RID: 9
	private const uint uint_2 = 4096U;

	// Token: 0x0400000A RID: 10
	private const uint uint_3 = 0U;

	// Token: 0x0400000B RID: 11
	private const uint uint_4 = 1U;

	// Token: 0x0400000C RID: 12
	private const uint uint_5 = 2U;

	// Token: 0x0400000D RID: 13
	private const uint uint_6 = 3U;

	// Token: 0x0400000E RID: 14
	private const uint uint_7 = 8U;

	// Token: 0x0400000F RID: 15
	private const uint uint_8 = 16U;

	// Token: 0x04000010 RID: 16
	private const int int_0 = 260;

	// Token: 0x04000011 RID: 17
	private const int int_1 = 255;

	// Token: 0x02000006 RID: 6
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct0
	{
		// Token: 0x04000012 RID: 18
		public uint uint_0;

		// Token: 0x04000013 RID: 19
		public uint uint_1;

		// Token: 0x04000014 RID: 20
		public uint uint_2;

		// Token: 0x04000015 RID: 21
		public uint uint_3;

		// Token: 0x04000016 RID: 22
		public uint uint_4;

		// Token: 0x04000017 RID: 23
		public IntPtr intptr_0;

		// Token: 0x04000018 RID: 24
		public uint uint_5;

		// Token: 0x04000019 RID: 25
		public IntPtr intptr_1;

		// Token: 0x0400001A RID: 26
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x0400001B RID: 27
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x02000007 RID: 7
	private struct Struct1
	{
		// Token: 0x0400001C RID: 28
		public IntPtr intptr_0;

		// Token: 0x0400001D RID: 29
		public uint uint_0;

		// Token: 0x0400001E RID: 30
		public IntPtr intptr_1;
	}
}
