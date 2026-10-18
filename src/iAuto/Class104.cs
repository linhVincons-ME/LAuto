using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020000CB RID: 203
internal static class Class104
{
	// Token: 0x06000869 RID: 2153
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint uint_8, bool bool_0, int int_0);

	// Token: 0x0600086A RID: 2154
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_1);

	// Token: 0x0600086B RID: 2155
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_1, IntPtr intptr_2, uint uint_8, uint uint_9, uint uint_10);

	// Token: 0x0600086C RID: 2156
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_1, IntPtr intptr_2, uint uint_8, uint uint_9);

	// Token: 0x0600086D RID: 2157
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_8, out UIntPtr uintptr_0);

	// Token: 0x0600086E RID: 2158
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_1, IntPtr intptr_2, uint uint_8, IntPtr intptr_3, IntPtr intptr_4, uint uint_9, out uint uint_10);

	// Token: 0x0600086F RID: 2159
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(IntPtr intptr_1, uint uint_8);

	// Token: 0x06000870 RID: 2160
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetExitCodeThread(IntPtr intptr_1, out uint uint_8);

	// Token: 0x06000871 RID: 2161
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_8, uint uint_9);

	// Token: 0x06000872 RID: 2162
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_1, ref Class104.Struct26 struct26_0);

	// Token: 0x06000873 RID: 2163
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_1, ref Class104.Struct26 struct26_0);

	// Token: 0x06000874 RID: 2164
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsWow64Process(IntPtr intptr_1, out bool bool_0);

	// Token: 0x06000875 RID: 2165 RVA: 0x000080A5 File Offset: 0x000062A5
	private static bool smethod_0(string string_0)
	{
		return string_0.StartsWith("api-ms-", StringComparison.OrdinalIgnoreCase) || string_0.StartsWith("ext-ms-", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x000080C3 File Offset: 0x000062C3
	private static string smethod_1(string string_0)
	{
		if (!string_0.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
		{
			string_0 += ".dll";
		}
		return string_0;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00044AEC File Offset: 0x00042CEC
	private static IntPtr smethod_2(int int_0, string string_0, string string_1)
	{
		string_0 = Class104.smethod_1(string_0);
		IntPtr intPtr;
		string text;
		if (!Class104.smethod_9(int_0, string_0, out intPtr, out text) || intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException("Không tìm thấy module x86 " + string_0 + " trong process mục tiêu.");
		}
		string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86), string_0);
		if (!File.Exists(text2) && !string.IsNullOrEmpty(text) && File.Exists(text))
		{
			text2 = text;
		}
		if (!File.Exists(text2))
		{
			throw new FileNotFoundException("Không tìm thấy bản x86 của " + string_0, text2);
		}
		Class104.Class105 @class = Class104.smethod_10(text2, string_1);
		if (!string.IsNullOrEmpty(@class.String_0))
		{
			throw new InvalidOperationException(string_0 + "!" + string_1 + " là forwarder, không dùng được làm bootstrap.");
		}
		return new IntPtr(intPtr.ToInt64() + (long)((ulong)@class.UInt32_0));
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00044BB4 File Offset: 0x00042DB4
	private static IntPtr smethod_3(int int_0, string string_0)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Class104.smethod_2(int_0, "kernelbase.dll", string_0);
		}
		catch
		{
			intPtr = Class104.smethod_2(int_0, "kernel32.dll", string_0);
		}
		return intPtr;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00044BF4 File Offset: 0x00042DF4
	internal static IntPtr smethod_4(int int_0, string string_0)
	{
		string_0 = Class104.smethod_1(string_0);
		IntPtr intPtr;
		string text;
		if (!Class104.smethod_0(string_0) && Class104.smethod_9(int_0, string_0, out intPtr, out text) && intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		IntPtr intPtr2 = Class104.OpenProcess(2035711U, false, int_0);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new InvalidOperationException("OpenProcess thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		try
		{
			IntPtr intPtr5 = Class104.smethod_3(int_0, "LoadLibraryA");
			byte[] bytes = Encoding.ASCII.GetBytes(string_0 + "\0");
			intPtr3 = Class104.VirtualAllocEx(intPtr2, IntPtr.Zero, (uint)bytes.Length, 12288U, 4U);
			if (intPtr3 == IntPtr.Zero)
			{
				throw new InvalidOperationException("VirtualAllocEx thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
			}
			UIntPtr uintPtr;
			if (Class104.WriteProcessMemory(intPtr2, intPtr3, bytes, (uint)bytes.Length, out uintPtr))
			{
				if (uintPtr.ToUInt64() == (ulong)((long)bytes.Length))
				{
					uint num;
					intPtr4 = Class104.CreateRemoteThread(intPtr2, IntPtr.Zero, 0U, intPtr5, intPtr3, 0U, out num);
					if (intPtr4 == IntPtr.Zero)
					{
						throw new InvalidOperationException("CreateRemoteThread thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
					}
					if (Class104.WaitForSingleObject(intPtr4, 10000U) != 0U)
					{
						throw new TimeoutException("Chờ LoadLibraryA quá thời gian.");
					}
					uint num2;
					if (!Class104.GetExitCodeThread(intPtr4, out num2) || num2 == 0U)
					{
						throw new InvalidOperationException("LoadLibraryA remote thất bại cho " + string_0);
					}
					return new IntPtr((long)((ulong)num2));
				}
			}
			throw new InvalidOperationException("WriteProcessMemory thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		finally
		{
			if (intPtr4 != IntPtr.Zero)
			{
				Class104.CloseHandle(intPtr4);
			}
			if (intPtr3 != IntPtr.Zero)
			{
				Class104.VirtualFreeEx(intPtr2, intPtr3, 0U, 32768U);
			}
			Class104.CloseHandle(intPtr2);
		}
		IntPtr intPtr6;
		return intPtr6;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00044DF0 File Offset: 0x00042FF0
	private static IntPtr smethod_5(int int_0, IntPtr intptr_1, string string_0)
	{
		IntPtr intPtr = Class104.OpenProcess(2035711U, false, int_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException("OpenProcess thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		try
		{
			IntPtr intPtr5 = Class104.smethod_3(int_0, "GetProcAddress");
			ushort num;
			uint num2;
			if (string_0.StartsWith("#", StringComparison.Ordinal) && ushort.TryParse(string_0.Substring(1), out num))
			{
				num2 = (uint)num;
			}
			else
			{
				byte[] bytes = Encoding.ASCII.GetBytes(string_0 + "\0");
				intPtr2 = Class104.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)bytes.Length, 12288U, 4U);
				if (intPtr2 == IntPtr.Zero)
				{
					throw new InvalidOperationException("VirtualAllocEx thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
				}
				UIntPtr uintPtr;
				if (Class104.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, out uintPtr))
				{
					if (uintPtr.ToUInt64() == (ulong)((long)bytes.Length))
					{
						num2 = (uint)intPtr2.ToInt64();
						goto IL_0107;
					}
				}
				throw new InvalidOperationException("WriteProcessMemory thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
			}
			IL_0107:
			byte[] array = new byte[]
			{
				184, 0, 0, 0, 0, 104, 0, 0, 0, 0,
				104, 0, 0, 0, 0, byte.MaxValue, 208, 194, 4, 0
			};
			BitConverter.GetBytes((int)intPtr5.ToInt64()).CopyTo(array, 1);
			BitConverter.GetBytes((int)num2).CopyTo(array, 6);
			BitConverter.GetBytes((int)intptr_1.ToInt64()).CopyTo(array, 11);
			intPtr3 = Class104.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)array.Length, 12288U, 64U);
			if (intPtr3 == IntPtr.Zero)
			{
				throw new InvalidOperationException("VirtualAllocEx stub thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
			}
			UIntPtr uintPtr2;
			if (Class104.WriteProcessMemory(intPtr, intPtr3, array, (uint)array.Length, out uintPtr2))
			{
				if (uintPtr2.ToUInt64() == (ulong)((long)array.Length))
				{
					uint num3;
					intPtr4 = Class104.CreateRemoteThread(intPtr, IntPtr.Zero, 0U, intPtr3, IntPtr.Zero, 0U, out num3);
					if (intPtr4 == IntPtr.Zero)
					{
						throw new InvalidOperationException("CreateRemoteThread GetProcAddress thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
					}
					if (Class104.WaitForSingleObject(intPtr4, 10000U) != 0U)
					{
						throw new TimeoutException("Chờ GetProcAddress quá thời gian.");
					}
					uint num4;
					if (!Class104.GetExitCodeThread(intPtr4, out num4) || num4 == 0U)
					{
						throw new MissingMethodException(intptr_1.ToInt64().ToString("X"), string_0);
					}
					return new IntPtr((long)((ulong)num4));
				}
			}
			throw new InvalidOperationException("WriteProcessMemory stub thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		finally
		{
			if (intPtr4 != IntPtr.Zero)
			{
				Class104.CloseHandle(intPtr4);
			}
			if (intPtr3 != IntPtr.Zero)
			{
				Class104.VirtualFreeEx(intPtr, intPtr3, 0U, 32768U);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				Class104.VirtualFreeEx(intPtr, intPtr2, 0U, 32768U);
			}
			Class104.CloseHandle(intPtr);
		}
		IntPtr intPtr6;
		return intPtr6;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000450F8 File Offset: 0x000432F8
	internal static IntPtr smethod_6(int int_0, string string_0)
	{
		IntPtr intPtr;
		string text;
		if (!Class104.smethod_9(int_0, string_0, out intPtr, out text))
		{
			return IntPtr.Zero;
		}
		return intPtr;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x0004511C File Offset: 0x0004331C
	internal static bool smethod_7(int int_0, string string_0, int int_1 = 20000)
	{
		string_0 = Class104.smethod_1(string_0);
		for (int i = 0; i <= int_1; i += 50)
		{
			IntPtr intPtr;
			string text;
			if (Class104.smethod_9(int_0, string_0, out intPtr, out text) && intPtr != IntPtr.Zero)
			{
				return true;
			}
			Thread.Sleep(50);
		}
		return false;
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00045164 File Offset: 0x00043364
	internal static IntPtr smethod_8(int int_0, string string_0, string string_1, int int_1 = 0)
	{
		string_0 = Class104.smethod_1(string_0);
		IntPtr intPtr = Class104.smethod_4(int_0, string_0);
		return Class104.smethod_5(int_0, intPtr, string_1);
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0004518C File Offset: 0x0004338C
	private static bool smethod_9(int int_0, string string_0, out IntPtr intptr_1, out string string_1)
	{
		intptr_1 = IntPtr.Zero;
		string_1 = null;
		string_0 = Class104.smethod_1(string_0);
		IntPtr intPtr = Class104.CreateToolhelp32Snapshot(24U, (uint)int_0);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == Class104.intptr_0))
		{
			try
			{
				Class104.Struct26 @struct = new Class104.Struct26
				{
					uint_0 = (uint)Marshal.SizeOf(typeof(Class104.Struct26))
				};
				if (!Class104.Module32FirstW(intPtr, ref @struct))
				{
					return false;
				}
				while (!string.Equals(@struct.string_0, string_0, StringComparison.OrdinalIgnoreCase))
				{
					if (!Class104.Module32NextW(intPtr, ref @struct))
					{
						return false;
					}
				}
				intptr_1 = @struct.intptr_0;
				string_1 = @struct.string_1;
				return intptr_1 != IntPtr.Zero;
			}
			finally
			{
				Class104.CloseHandle(intPtr);
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00045258 File Offset: 0x00043458
	private static Class104.Class105 smethod_10(string string_0, string string_1)
	{
		byte[] array = File.ReadAllBytes(string_0);
		if (Class104.smethod_12(array, 0) != 23117)
		{
			throw new InvalidDataException("Không phải PE: " + string_0);
		}
		int num = checked((int)Class104.smethod_13(array, 60));
		if (Class104.smethod_13(array, num) != 17744U)
		{
			throw new InvalidDataException("PE signature không hợp lệ: " + string_0);
		}
		int num2 = (int)Class104.smethod_12(array, num + 6);
		int num3 = (int)Class104.smethod_12(array, num + 20);
		int num4 = num + 24;
		ushort num5 = Class104.smethod_12(array, num4);
		int num6 = ((num5 == 267) ? (num4 + 96) : ((num5 == 523) ? (num4 + 112) : (-1)));
		if (num6 < 0)
		{
			throw new InvalidDataException("PE optional header không được hỗ trợ.");
		}
		uint num7 = Class104.smethod_13(array, num6);
		uint num8 = Class104.smethod_13(array, num6 + 4);
		if (num7 == 0U)
		{
			throw new MissingMethodException(string_0, string_1);
		}
		int num9 = num4 + num3;
		int num10 = Class104.smethod_11(array, num7, num4, num9, num2);
		uint num11 = Class104.smethod_13(array, num10 + 16);
		uint num12 = Class104.smethod_13(array, num10 + 20);
		uint num13 = Class104.smethod_13(array, num10 + 24);
		uint num14 = Class104.smethod_13(array, num10 + 28);
		uint num15 = Class104.smethod_13(array, num10 + 32);
		uint num16 = Class104.smethod_13(array, num10 + 36);
		int num17 = -1;
		uint num18;
		if (string_1.StartsWith("#", StringComparison.Ordinal) && uint.TryParse(string_1.Substring(1), out num18) && num18 >= num11)
		{
			uint num19 = num18 - num11;
			if (num19 < num12)
			{
				num17 = checked((int)num19);
			}
		}
		else
		{
			int num20 = Class104.smethod_11(array, num15, num4, num9, num2);
			int num21 = Class104.smethod_11(array, num16, num4, num9, num2);
			for (uint num22 = 0U; num22 < num13; num22 += 1U)
			{
				checked
				{
					uint num23 = Class104.smethod_13(array, num20 + (int)(num22 * 4U));
					if (string.Equals(Class104.smethod_14(array, Class104.smethod_11(array, num23, num4, num9, num2)), string_1, StringComparison.Ordinal))
					{
						num17 = (int)Class104.smethod_12(array, num21 + (int)(num22 * 2U));
						break;
					}
				}
			}
		}
		if (num17 >= 0 && num17 < (int)num12)
		{
			int num24 = Class104.smethod_11(array, num14, num4, num9, num2);
			uint num25 = Class104.smethod_13(array, checked(num24 + num17 * 4));
			Class104.Class105 @class = new Class104.Class105
			{
				UInt32_0 = num25
			};
			if (num25 >= num7 && num25 < num7 + num8)
			{
				@class.String_0 = Class104.smethod_14(array, Class104.smethod_11(array, num25, num4, num9, num2));
			}
			return @class;
		}
		throw new MissingMethodException(string_0, string_1);
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x000454A8 File Offset: 0x000436A8
	private static int smethod_11(byte[] byte_0, uint uint_8, int int_0, int int_1, int int_2)
	{
		uint num = Class104.smethod_13(byte_0, int_0 + 60);
		if (uint_8 < num)
		{
			return checked((int)uint_8);
		}
		for (int i = 0; i < int_2; i++)
		{
			int num2 = checked(int_1 + i * 40);
			uint num3 = Class104.smethod_13(byte_0, num2 + 8);
			uint num4 = Class104.smethod_13(byte_0, num2 + 12);
			uint num5 = Class104.smethod_13(byte_0, num2 + 16);
			uint num6 = Class104.smethod_13(byte_0, num2 + 20);
			uint num7 = Math.Max(num3, num5);
			if (uint_8 >= num4 && uint_8 < num4 + num7)
			{
				return checked((int)(num6 + uint_8 - num4));
			}
		}
		throw new InvalidDataException("Không ánh xạ được PE RVA 0x" + uint_8.ToString("X"));
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x000080E1 File Offset: 0x000062E1
	private static ushort smethod_12(byte[] byte_0, int int_0)
	{
		if (int_0 < 0 || int_0 > byte_0.Length - 2)
		{
			throw new EndOfStreamException();
		}
		return BitConverter.ToUInt16(byte_0, int_0);
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x000080FC File Offset: 0x000062FC
	private static uint smethod_13(byte[] byte_0, int int_0)
	{
		if (int_0 < 0 || int_0 > byte_0.Length - 4)
		{
			throw new EndOfStreamException();
		}
		return BitConverter.ToUInt32(byte_0, int_0);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00045540 File Offset: 0x00043740
	private static string smethod_14(byte[] byte_0, int int_0)
	{
		int num = int_0;
		while (num < byte_0.Length && byte_0[num] != 0)
		{
			num++;
		}
		if (num == byte_0.Length)
		{
			throw new EndOfStreamException();
		}
		return Encoding.ASCII.GetString(byte_0, int_0, num - int_0);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0004557C File Offset: 0x0004377C
	private static void smethod_15(string string_0)
	{
		byte[] array = File.ReadAllBytes(string_0);
		int num = checked((int)Class104.smethod_13(array, 60));
		if (Class104.smethod_13(array, num) != 17744U || Class104.smethod_12(array, num + 4) != 332)
		{
			throw new BadImageFormatException("DLL hook cho client x86 phải là PE32 Intel 386.", string_0);
		}
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x000455C4 File Offset: 0x000437C4
	public static bool smethod_16(int int_0, string string_0)
	{
		string_0 = Path.GetFullPath(string_0);
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException("Không tìm thấy DLL hook x86.", string_0);
		}
		Class104.smethod_15(string_0);
		if (Class104.smethod_6(int_0, Path.GetFileName(string_0)) != IntPtr.Zero)
		{
			return true;
		}
		IntPtr intPtr = Class104.OpenProcess(2035711U, false, int_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException("OpenProcess thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		try
		{
			bool flag;
			if (!Class104.IsWow64Process(intPtr, out flag) || !flag)
			{
				throw new InvalidOperationException("Process mục tiêu không phải client x86/WOW64.");
			}
			if (!Class104.smethod_7(int_0, "kernel32.dll", 20000))
			{
				throw new InvalidOperationException("Không tìm thấy module x86 kernel32.dll trong process mục tiêu.");
			}
			byte[] bytes = Encoding.Unicode.GetBytes(string_0 + "\0");
			intPtr2 = Class104.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)bytes.Length, 12288U, 4U);
			if (intPtr2 == IntPtr.Zero)
			{
				throw new InvalidOperationException("VirtualAllocEx thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
			}
			UIntPtr uintPtr;
			if (Class104.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, out uintPtr))
			{
				if (uintPtr.ToUInt64() == (ulong)((long)bytes.Length))
				{
					IntPtr intPtr4 = Class104.smethod_8(int_0, "kernel32.dll", "LoadLibraryW", 0);
					uint num;
					intPtr3 = Class104.CreateRemoteThread(intPtr, IntPtr.Zero, 0U, intPtr4, intPtr2, 0U, out num);
					if (intPtr3 == IntPtr.Zero)
					{
						throw new InvalidOperationException("CreateRemoteThread thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
					}
					if (Class104.WaitForSingleObject(intPtr3, 10000U) != 0U)
					{
						throw new TimeoutException("Chờ nạp DLL hook x86 quá thời gian.");
					}
					uint num2;
					if (!Class104.GetExitCodeThread(intPtr3, out num2))
					{
						throw new InvalidOperationException("GetExitCodeThread thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
					}
					return num2 > 0U;
				}
			}
			throw new InvalidOperationException("WriteProcessMemory thất bại. Error=" + Marshal.GetLastWin32Error().ToString());
		}
		finally
		{
			if (intPtr3 != IntPtr.Zero)
			{
				Class104.CloseHandle(intPtr3);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				Class104.VirtualFreeEx(intPtr, intPtr2, 0U, 32768U);
			}
			Class104.CloseHandle(intPtr);
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x04000509 RID: 1289
	private const uint uint_0 = 2035711U;

	// Token: 0x0400050A RID: 1290
	private const uint uint_1 = 4096U;

	// Token: 0x0400050B RID: 1291
	private const uint uint_2 = 8192U;

	// Token: 0x0400050C RID: 1292
	private const uint uint_3 = 32768U;

	// Token: 0x0400050D RID: 1293
	private const uint uint_4 = 4U;

	// Token: 0x0400050E RID: 1294
	private const uint uint_5 = 8U;

	// Token: 0x0400050F RID: 1295
	private const uint uint_6 = 16U;

	// Token: 0x04000510 RID: 1296
	private const uint uint_7 = 0U;

	// Token: 0x04000511 RID: 1297
	private static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x020000CC RID: 204
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct26
	{
		// Token: 0x04000512 RID: 1298
		public uint uint_0;

		// Token: 0x04000513 RID: 1299
		public uint uint_1;

		// Token: 0x04000514 RID: 1300
		public uint uint_2;

		// Token: 0x04000515 RID: 1301
		public uint uint_3;

		// Token: 0x04000516 RID: 1302
		public uint uint_4;

		// Token: 0x04000517 RID: 1303
		public IntPtr intptr_0;

		// Token: 0x04000518 RID: 1304
		public uint uint_5;

		// Token: 0x04000519 RID: 1305
		public IntPtr intptr_1;

		// Token: 0x0400051A RID: 1306
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x0400051B RID: 1307
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x020000CD RID: 205
	private sealed class Class105
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00008124 File Offset: 0x00006324
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0000812C File Offset: 0x0000632C
		public uint UInt32_0 { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00008135 File Offset: 0x00006335
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0000813D File Offset: 0x0000633D
		public string String_0 { get; set; }

		// Token: 0x0400051C RID: 1308
		[CompilerGenerated]
		private uint uint_0;

		// Token: 0x0400051D RID: 1309
		[CompilerGenerated]
		private string string_0;
	}
}
