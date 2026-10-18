using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;

// Token: 0x020000C0 RID: 192
public static class GClass34
{
	// Token: 0x06000816 RID: 2070
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint uint_15, bool bool_1, int int_0);

	// Token: 0x06000817 RID: 2071
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000818 RID: 2072
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_1, int int_0, out int int_1);

	// Token: 0x06000819 RID: 2073
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_1, int int_0, out int int_1);

	// Token: 0x0600081A RID: 2074
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_15, out uint uint_16);

	// Token: 0x0600081B RID: 2075
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern UIntPtr VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GClass34.Struct21 struct21_0, UIntPtr uintptr_0);

	// Token: 0x0600081C RID: 2076
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_15, uint uint_16);

	// Token: 0x0600081D RID: 2077
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_15);

	// Token: 0x0600081E RID: 2078
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, IntPtr intptr_3, uint uint_15, out uint uint_16);

	// Token: 0x0600081F RID: 2079
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_15);

	// Token: 0x06000820 RID: 2080
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_3);

	// Token: 0x06000821 RID: 2081
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_3);

	// Token: 0x06000822 RID: 2082
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr OpenMutex(uint uint_15, bool bool_1, string string_3);

	// Token: 0x06000823 RID: 2083
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_15, int int_0);

	// Token: 0x06000824 RID: 2084
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_0, ref GClass34.Struct20 struct20_0);

	// Token: 0x06000825 RID: 2085
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_0, ref GClass34.Struct20 struct20_0);

	// Token: 0x06000826 RID: 2086
	[DllImport("kernel32.dll")]
	private static extern bool DuplicateHandle(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, out IntPtr intptr_3, uint uint_15, bool bool_1, uint uint_16);

	// Token: 0x06000827 RID: 2087
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	// Token: 0x06000828 RID: 2088
	[DllImport("ntdll.dll")]
	private static extern uint NtQuerySystemInformation(int int_0, IntPtr intptr_0, int int_1, out int int_2);

	// Token: 0x06000829 RID: 2089
	[DllImport("ntdll.dll")]
	private static extern uint NtQueryObject(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1, out int int_2);

	// Token: 0x0600082A RID: 2090
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_0, out int int_1, uint uint_15);

	// Token: 0x0600082B RID: 2091
	[DllImport("psapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint GetModuleBaseName(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	// Token: 0x0600082C RID: 2092
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out GClass34.Struct24 struct24_0, int int_0);

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x0600082D RID: 2093 RVA: 0x00007F72 File Offset: 0x00006172
	// (set) Token: 0x0600082E RID: 2094 RVA: 0x00007F79 File Offset: 0x00006179
	public static Action<string> Action_0 { get; set; }

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x0600082F RID: 2095 RVA: 0x00007F81 File Offset: 0x00006181
	// (set) Token: 0x06000830 RID: 2096 RVA: 0x00007F88 File Offset: 0x00006188
	public static string String_0 { get; set; } = "-fl";

	// Token: 0x06000831 RID: 2097 RVA: 0x00007F90 File Offset: 0x00006190
	private static void smethod_0(string string_3)
	{
		if (GClass34.Action_0 != null)
		{
			GClass34.Action_0(string_3);
			return;
		}
		Console.WriteLine(string_3);
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00007FAB File Offset: 0x000061AB
	private static void smethod_1(string string_3, params object[] object_1)
	{
		GClass34.smethod_0((object_1 == null || object_1.Length == 0) ? string_3 : string.Format(string_3, object_1));
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00007FC3 File Offset: 0x000061C3
	public static bool smethod_2()
	{
		return GClass34.bool_0 && GClass34.timer_0 != null;
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000425DC File Offset: 0x000407DC
	public static void smethod_3(string string_3 = null)
	{
		if (!string.IsNullOrEmpty(string_3))
		{
			GClass34.string_2 = string_3;
		}
		if (GClass34.timer_0 != null)
		{
			return;
		}
		if (!GClass34.smethod_8())
		{
			GClass34.smethod_0("Can chay bang quyen Administrator.");
			return;
		}
		GClass34.bool_0 = true;
		GClass34.timer_0 = new Timer(new TimerCallback(GClass34.Class100.f_19566E19.method_0), null, 0, 500);
		GClass34.smethod_0(Environment.Is64BitProcess ? "GamePatcher dang chay (host x64 -> Game x86)" : "GamePatcher dang chay");
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00042664 File Offset: 0x00040864
	public static void smethod_4()
	{
		GClass34.bool_0 = false;
		Timer timer = GClass34.timer_0;
		GClass34.timer_0 = null;
		if (timer != null)
		{
			timer.Dispose();
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00007FD8 File Offset: 0x000061D8
	public static void smethod_5(string string_3)
	{
		GClass34.smethod_6(string_3, 1);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00042690 File Offset: 0x00040890
	public static void smethod_6(string string_3, int int_0)
	{
		GClass34.Class102 @class = new GClass34.Class102();
		@class.string_0 = string_3;
		@class.int_0 = int_0;
		if (@class.int_0 < 1)
		{
			@class.int_0 = 1;
		}
		if (string.IsNullOrWhiteSpace(@class.string_0))
		{
			throw new ArgumentException("path rong");
		}
		@class.string_0 = Path.GetFullPath(@class.string_0);
		if (Directory.Exists(@class.string_0))
		{
			string inRoot = Path.Combine(@class.string_0, "Game.exe");
			string inBin = Path.Combine(@class.string_0, "Bin", "Game.exe");
			// game root folder: the client lives in Bin\Game.exe
			@class.string_0 = (!File.Exists(inRoot) && File.Exists(inBin)) ? inBin : inRoot;
		}
		if (!File.Exists(@class.string_0))
		{
			throw new FileNotFoundException("Khong tim thay Game.exe", @class.string_0);
		}
		if (!GClass34.smethod_8())
		{
			throw new InvalidOperationException("Can chay bang quyen Administrator.");
		}
		GClass34.string_2 = @class.string_0;
		if (!GClass34.smethod_2())
		{
			GClass34.smethod_3(@class.string_0);
		}
		ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0004276C File Offset: 0x0004096C
	public static void smethod_7()
	{
		string text = GClass34.string_2;
		if (string.IsNullOrEmpty(text) || !File.Exists(text))
		{
			text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Game.exe");
			if (!File.Exists(text))
			{
				text = Path.Combine(Directory.GetCurrentDirectory(), "Game.exe");
			}
		}
		GClass34.smethod_6(text, 1);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x000427C4 File Offset: 0x000409C4
	private static bool smethod_8()
	{
		bool flag;
		using (WindowsIdentity current = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
		}
		return flag;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00042808 File Offset: 0x00040A08
	private static void smethod_9(string string_3)
	{
		if (!File.Exists(string_3))
		{
			GClass34.smethod_1("Khong tim thay: " + string_3, Array.Empty<object>());
			return;
		}
		Process process;
		try
		{
			process = Process.Start(new ProcessStartInfo
			{
				FileName = string_3,
				Arguments = GClass34.String_0,
				WorkingDirectory = (Path.GetDirectoryName(string_3) ?? "."),
				UseShellExecute = true
			});
		}
		catch (Exception ex)
		{
			GClass34.smethod_1("Loi mo game: " + ex.Message, Array.Empty<object>());
			return;
		}
		if (process == null)
		{
			return;
		}
		GClass34.smethod_1("[{0:HH:mm:ss}] Mo Game.exe -fl PID={1}", new object[]
		{
			DateTime.Now,
			process.Id
		});
		for (int i = 0; i < 200; i++)
		{
			Thread.Sleep(50);
			try
			{
				if (process.HasExited)
				{
					break;
				}
				if (GClass34.smethod_10(process.Id, true))
				{
					return;
				}
			}
			catch
			{
			}
		}
		GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} tiep tuc theo doi...", new object[]
		{
			DateTime.Now,
			process.Id
		});
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x0004293C File Offset: 0x00040B3C
	private static bool smethod_10(int int_0, bool bool_1)
	{
		GClass34.Struct25 @struct = GClass34.smethod_13(int_0, "Game.exe");
		if (@struct.intptr_0 == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr = GClass34.OpenProcess(2035711U, false, int_0);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num = 0 + GClass34.smethod_19(intPtr, @struct.intptr_0, @struct.uint_0);
			num += GClass34.smethod_20(intPtr, @struct.intptr_0, @struct.uint_0);
			num += GClass34.smethod_21(intPtr, @struct.intptr_0, @struct.uint_0);
			num += GClass34.smethod_27(intPtr, @struct.intptr_0, @struct.uint_0);
			GClass34.Struct25 struct2 = GClass34.smethod_13(int_0, "tEngine.dll");
			if (struct2.intptr_0 != IntPtr.Zero)
			{
				int num2 = GClass34.smethod_22(intPtr, struct2.intptr_0, struct2.uint_0);
				if (num2 > 0)
				{
					num += num2;
					if (!GClass34.hashSet_2.Contains(int_0))
					{
						GClass34.hashSet_2.Add(int_0);
						GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} tEngine StealthCrash da vo hieu ({2})", new object[]
						{
							DateTime.Now,
							int_0,
							num2
						});
					}
				}
				else if (!GClass34.hashSet_2.Contains(int_0))
				{
					GClass34.hashSet_2.Add(int_0);
				}
			}
			if (GClass34.smethod_24(intPtr) && !GClass34.hashSet_3.Contains(int_0))
			{
				GClass34.hashSet_3.Add(int_0);
				num++;
				GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} chan toan bo ExitProcess/TerminateProcess/NtTerminateProcess", new object[]
				{
					DateTime.Now,
					int_0
				});
			}
			if (num > 0)
			{
				GClass34.hashSet_0.Add(int_0);
				if (bool_1)
				{
					GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} da va ({2} cho)", new object[]
					{
						DateTime.Now,
						int_0,
						num
					});
				}
			}
			if (GClass34.hashSet_0.Contains(int_0) || num > 0)
			{
				GClass34.smethod_32(intPtr, int_0, bool_1);
			}
			flag = num > 0 || GClass34.hashSet_0.Contains(int_0);
		}
		finally
		{
			GClass34.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00042B64 File Offset: 0x00040D64
	private static bool smethod_11(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = GClass34.smethod_16(intptr_0, intptr_1.ToInt64(), 64);
		if (array != null)
		{
			if (array[0] == 77)
			{
				int num = BitConverter.ToInt32(array, 60);
				if (num > 0 && num <= 4096)
				{
					byte[] array2 = GClass34.smethod_16(intptr_0, intptr_1.ToInt64() + (long)num, 32);
					if (array2 != null)
					{
						if (BitConverter.ToUInt32(array2, 0) == 17744U)
						{
							return BitConverter.ToUInt16(array2, 24) == 267;
						}
					}
					return false;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00042BEC File Offset: 0x00040DEC
	private static bool smethod_12(IntPtr intptr_0, string string_3, uint uint_15, out GClass34.Struct25 struct25_0)
	{
		struct25_0 = default(GClass34.Struct25);
		IntPtr[] array = new IntPtr[1024];
		int num;
		if (!GClass34.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, uint_15))
		{
			return false;
		}
		int num2 = num / IntPtr.Size;
		if (num2 > array.Length)
		{
			array = new IntPtr[num2];
			if (!GClass34.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, uint_15))
			{
				return false;
			}
			num2 = num / IntPtr.Size;
		}
		StringBuilder stringBuilder = new StringBuilder(260);
		GClass34.Struct25 @struct = default(GClass34.Struct25);
		for (int i = 0; i < num2; i++)
		{
			stringBuilder.Clear();
			GClass34.Struct24 struct2;
			if (GClass34.GetModuleBaseName(intptr_0, array[i], stringBuilder, stringBuilder.Capacity) != 0U && string.Equals(stringBuilder.ToString(), string_3, StringComparison.OrdinalIgnoreCase) && GClass34.GetModuleInformation(intptr_0, array[i], out struct2, Marshal.SizeOf(typeof(GClass34.Struct24))))
			{
				GClass34.Struct25 struct3 = new GClass34.Struct25
				{
					intptr_0 = struct2.intptr_0,
					uint_0 = struct2.uint_0
				};
				if (GClass34.smethod_11(intptr_0, struct3.intptr_0))
				{
					struct25_0 = struct3;
					return true;
				}
				if (@struct.intptr_0 == IntPtr.Zero)
				{
					@struct = struct3;
				}
			}
		}
		if (@struct.intptr_0 != IntPtr.Zero && !Environment.Is64BitProcess)
		{
			struct25_0 = @struct;
			return true;
		}
		return false;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00042D44 File Offset: 0x00040F44
	private static GClass34.Struct25 smethod_13(int int_0, string string_3)
	{
		GClass34.Struct25 @struct = default(GClass34.Struct25);
		IntPtr intPtr = GClass34.OpenProcess(2035711U, false, int_0);
		if (intPtr != IntPtr.Zero)
		{
			GClass34.Struct25 struct2;
			try
			{
				if (!Environment.Is64BitProcess || !GClass34.smethod_12(intPtr, string_3, 1U, out @struct))
				{
					if (GClass34.smethod_12(intPtr, string_3, 3U, out @struct))
					{
						if (!Environment.Is64BitProcess || GClass34.smethod_11(intPtr, @struct.intptr_0))
						{
							return @struct;
						}
						@struct = default(GClass34.Struct25);
					}
					goto IL_0077;
				}
				struct2 = @struct;
			}
			finally
			{
				GClass34.CloseHandle(intPtr);
			}
			return struct2;
		}
		IL_0077:
		IntPtr intPtr2 = GClass34.CreateToolhelp32Snapshot(24U, int_0);
		if (intPtr2 == (IntPtr)(-1) || intPtr2 == IntPtr.Zero)
		{
			return @struct;
		}
		IntPtr intPtr3 = GClass34.OpenProcess(2035711U, false, int_0);
		GClass34.Struct20 struct3 = default(GClass34.Struct20);
		struct3.uint_0 = (uint)Marshal.SizeOf(typeof(GClass34.Struct20));
		GClass34.Struct25 struct4 = default(GClass34.Struct25);
		GClass34.Struct25 struct5 = default(GClass34.Struct25);
		if (GClass34.Module32FirstW(intPtr2, ref struct3))
		{
			GClass34.Struct25 struct6;
			do
			{
				if (string.Equals(struct3.string_0, string_3, StringComparison.OrdinalIgnoreCase))
				{
					struct6 = new GClass34.Struct25
					{
						intptr_0 = struct3.intptr_0,
						uint_0 = struct3.uint_5
					};
					if (struct5.intptr_0 == IntPtr.Zero)
					{
						struct5 = struct6;
					}
					if (intPtr3 != IntPtr.Zero && GClass34.smethod_11(intPtr3, struct6.intptr_0))
					{
						goto Block_8;
					}
				}
			}
			while (GClass34.Module32NextW(intPtr2, ref struct3));
			goto IL_016A;
			Block_8:
			struct4 = struct6;
		}
		IL_016A:
		GClass34.CloseHandle(intPtr2);
		if (intPtr3 != IntPtr.Zero)
		{
			GClass34.CloseHandle(intPtr3);
		}
		if (!(struct4.intptr_0 != IntPtr.Zero))
		{
			return struct5;
		}
		return struct4;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00007FE1 File Offset: 0x000061E1
	private static bool smethod_14(uint uint_15)
	{
		return (uint_15 & 240U) != 0U && (uint_15 & 1U) == 0U;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00007FF4 File Offset: 0x000061F4
	private static IEnumerable<ValueTuple<long, int>> smethod_15(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		GClass34.Class103 @class = new GClass34.Class103(-2);
		@class.intptr_3 = intptr_0;
		@class.intptr_1 = intptr_1;
		@class.uint_1 = uint_15;
		return @class;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00042F00 File Offset: 0x00041100
	private static byte[] smethod_16(IntPtr intptr_0, long long_0, int int_0)
	{
		byte[] array = new byte[int_0];
		int num;
		if (!GClass34.ReadProcessMemory(intptr_0, (IntPtr)long_0, array, int_0, out num) || num <= 0)
		{
			return null;
		}
		if (num != int_0)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			return array2;
		}
		return array;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00042F44 File Offset: 0x00041144
	private static bool smethod_17(IntPtr intptr_0, long long_0, byte[] byte_1)
	{
		uint num;
		GClass34.VirtualProtectEx(intptr_0, (IntPtr)long_0, (UIntPtr)((ulong)((long)byte_1.Length)), 64U, out num);
		int num2;
		bool flag = GClass34.WriteProcessMemory(intptr_0, (IntPtr)long_0, byte_1, byte_1.Length, out num2);
		uint num3;
		GClass34.VirtualProtectEx(intptr_0, (IntPtr)long_0, (UIntPtr)((ulong)((long)byte_1.Length)), num, out num3);
		return flag && num2 == byte_1.Length;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00042FA0 File Offset: 0x000411A0
	private static int smethod_18(byte[] byte_1, byte[] byte_2, int int_0)
	{
		int i = int_0;
		IL_002B:
		while (i <= byte_1.Length - byte_2.Length)
		{
			bool flag = true;
			int j = 0;
			while (j < byte_2.Length)
			{
				if (byte_1[i + j] != byte_2[j])
				{
					flag = false;
					IL_0024:
					if (!flag)
					{
						i++;
						goto IL_002B;
					}
					return i;
				}
				else
				{
					j++;
				}
			}
			{
				if (!flag)
				{
					i++;
					goto IL_002B;
				}
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00042FE8 File Offset: 0x000411E8
	private static int smethod_19(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		int num = 0;
		foreach (byte b in new byte[] { 2, 3, 4 })
		{
			byte[] array2 = new byte[] { 70, 131, 254, 0, 15, 140 };
			array2[3] = b;
			byte[] array3 = array2;
			byte[] array4 = new byte[] { 70, 131, 254, 127, 15, 140 };
			foreach (ValueTuple<long, int> valueTuple in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
			{
				long item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				byte[] array5 = GClass34.smethod_16(intptr_0, item, item2);
				if (array5 != null)
				{
					int num2 = 0;
					for (;;)
					{
						int num3 = GClass34.smethod_18(array5, array3, num2);
						if (num3 < 0)
						{
							break;
						}
						bool flag = false;
						int num4 = num3;
						while (num4 < num3 + 96 && num4 + 2 < array5.Length)
						{
							if (array5[num4] == 106 && array5[num4 + 1] == 64 && array5[num4 + 2] == 106)
							{
								flag = true;
								break;
							}
							num4++;
						}
						if (flag && GClass34.smethod_17(intptr_0, item + (long)num3, array4))
						{
							num++;
							GClass34.smethod_1("  [Game] esi limit 0x{0:X2}->0x{1:X2} @ 0x{2:X8}", new object[]
							{
								b,
								127,
								item + (long)num3
							});
						}
						num2 = num3 + 1;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00043168 File Offset: 0x00041368
	private static int smethod_20(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		int num = 0;
		byte[] array = new byte[] { 131, 251, 127, 15, 140 };
		foreach (byte b in new byte[] { 2, 3, 4 })
		{
			byte[] array3 = new byte[] { 131, 251, 0, 15, 140 };
			array3[2] = b;
			byte[] array4 = array3;
			foreach (ValueTuple<long, int> valueTuple in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
			{
				long item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				byte[] array5 = GClass34.smethod_16(intptr_0, item, item2);
				if (array5 != null)
				{
					int num2 = 0;
					for (;;)
					{
						int num3 = GClass34.smethod_18(array5, array4, num2);
						if (num3 < 0)
						{
							break;
						}
						if (GClass34.smethod_17(intptr_0, item + (long)num3, array))
						{
							num++;
							GClass34.smethod_1("  [Game] ebx limit 0x{0:X2}->0x{1:X2} @ 0x{2:X8}", new object[]
							{
								b,
								127,
								item + (long)num3
							});
						}
						num2 = num3 + 1;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00043294 File Offset: 0x00041494
	private static int smethod_21(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		int num = 0;
		byte[] array = new byte[]
		{
			104, 222, 192, 0, 0, 104, 222, 192, 0, 0,
			106, 16
		};
		byte[] array2 = new byte[] { 235, 22 };
		foreach (ValueTuple<long, int> valueTuple in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			byte[] array3 = GClass34.smethod_16(intptr_0, item, item2);
			if (array3 != null)
			{
				int num2 = 0;
				for (;;)
				{
					int num3 = GClass34.smethod_18(array3, array, num2);
					if (num3 < 0)
					{
						break;
					}
					if (num3 + 24 <= array3.Length && array3[num3 + 12] == 255 && array3[num3 + 13] == 53 && array3[num3 + 18] == 255 && array3[num3 + 19] == 21 && GClass34.smethod_17(intptr_0, item + (long)num3, array2))
					{
						num++;
						GClass34.smethod_1("  [Game] skip WM_CLOSE 0xC0DE @ 0x{0:X8}", new object[] { item + (long)num3 });
					}
					num2 = num3 + 1;
				}
			}
		}
		foreach (ValueTuple<long, int> valueTuple2 in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item3 = valueTuple2.Item1;
			int item4 = valueTuple2.Item2;
			byte[] array4 = GClass34.smethod_16(intptr_0, item3, item4);
			if (array4 != null)
			{
				int num4 = 0;
				while (num4 + 8 < array4.Length)
				{
					if (array4[num4] == 131 && (array4[num4 + 1] == 120 || array4[num4 + 1] == 121) && array4[num4 + 2] == 4 && array4[num4 + 3] == 1 && array4[num4 + 4] == 117)
					{
						bool flag = false;
						int num5 = num4 + 5;
						while (num5 < num4 + 16 && num5 + 2 < array4.Length)
						{
							if (array4[num5] == 104 && array4[num5 + 1] == 222 && array4[num5 + 2] == 192)
							{
								flag = true;
								break;
							}
							if (array4[num5] == 235 && array4[num5 + 1] == 22)
							{
								flag = true;
								break;
							}
							num5++;
						}
						if (flag && GClass34.smethod_17(intptr_0, item3 + (long)num4 + 4L, new byte[] { 235 }))
						{
							num++;
							GClass34.smethod_1("  [Game] skip state==1 close @ 0x{0:X8}", new object[] { item3 + (long)num4 });
						}
					}
					num4++;
				}
			}
		}
		foreach (ValueTuple<long, int> valueTuple3 in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item5 = valueTuple3.Item1;
			int item6 = valueTuple3.Item2;
			byte[] array5 = GClass34.smethod_16(intptr_0, item5, item6);
			if (array5 != null)
			{
				int num6 = 0;
				while (num6 + 8 < array5.Length)
				{
					if (array5[num6] == 60 && array5[num6 + 1] == 5 && array5[num6 + 2] == 117 && num6 + 6 < array5.Length && array5[num6 + 4] == 106 && array5[num6 + 5] == 16 && array5[num6 + 6] == 106 && array5[num6 + 7] == 0 && array5[num6 + 2] != 235 && GClass34.smethod_17(intptr_0, item5 + (long)num6 + 2L, new byte[] { 235 }))
					{
						num++;
						GClass34.smethod_1("  [Game] skip enterscene reject close @ 0x{0:X8}", new object[] { item5 + (long)num6 });
					}
					num6++;
				}
			}
		}
		foreach (ValueTuple<long, int> valueTuple4 in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item7 = valueTuple4.Item1;
			int item8 = valueTuple4.Item2;
			byte[] array6 = GClass34.smethod_16(intptr_0, item7, item8);
			if (array6 != null)
			{
				int num7 = 0;
				while (num7 + 18 <= array6.Length)
				{
					if ((array6[num7] != 235 || array6[num7 + 1] != 16 || array6[num7 + 2] != 0 || array6[num7 + 3] != 0 || array6[num7 + 4] != 106 || array6[num7 + 5] != 16) && array6[num7] == 106 && array6[num7 + 1] == 0 && array6[num7 + 2] == 106 && array6[num7 + 3] == 0 && array6[num7 + 4] == 106 && array6[num7 + 5] == 16 && array6[num7 + 6] == 255 && array6[num7 + 7] == 53 && array6[num7 + 12] == 255 && array6[num7 + 13] == 21 && GClass34.smethod_17(intptr_0, item7 + (long)num7, new byte[] { 235, 16 }))
					{
						num++;
						GClass34.smethod_1("  [Game] skip WM_CLOSE wparam0 @ 0x{0:X8}", new object[] { item7 + (long)num7 });
					}
					num7++;
				}
			}
		}
		return num;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00043820 File Offset: 0x00041A20
	private static int smethod_22(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		int num = 0;
		byte[] array = new byte[] { 131, 250, 10, 124 };
		foreach (ValueTuple<long, int> valueTuple in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			byte[] array2 = GClass34.smethod_16(intptr_0, item, item2);
			if (array2 != null)
			{
				int num2 = 0;
				for (;;)
				{
					int num3 = GClass34.smethod_18(array2, array, num2);
					if (num3 < 0)
					{
						break;
					}
					if (num3 + 8 <= array2.Length && array2[num3 + 5] == 133 && array2[num3 + 6] == 219 && (array2[num3 + 7] == 117 || array2[num3 + 7] == 235) && array2[num3 + 7] == 117 && GClass34.smethod_17(intptr_0, item + (long)num3 + 7L, new byte[] { 235 }))
					{
						num++;
						GClass34.smethod_1("  [tEngine] skip StealthCrash @ 0x{0:X8}", new object[] { item + (long)num3 });
					}
					num2 = num3 + 1;
				}
			}
		}
		return num;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00043958 File Offset: 0x00041B58
	private static uint smethod_23(IntPtr intptr_0, IntPtr intptr_1, string string_3)
	{
		byte[] array = GClass34.smethod_16(intptr_0, intptr_1.ToInt64(), 64);
		if (array != null)
		{
			if (array[0] == 77)
			{
				int num = BitConverter.ToInt32(array, 60);
				byte[] array2 = GClass34.smethod_16(intptr_0, intptr_1.ToInt64() + (long)num, 288);
				if (array2 != null)
				{
					if (BitConverter.ToUInt32(array2, 0) == 17744U)
					{
						int num2 = ((BitConverter.ToUInt16(array2, 24) == 523) ? 136 : 120);
						uint num3 = BitConverter.ToUInt32(array2, num2);
						if (num3 == 0U)
						{
							return 0U;
						}
						byte[] array3 = GClass34.smethod_16(intptr_0, intptr_1.ToInt64() + (long)((ulong)num3), 64);
						if (array3 == null)
						{
							return 0U;
						}
						uint num4 = BitConverter.ToUInt32(array3, 24);
						uint num5 = BitConverter.ToUInt32(array3, 20);
						uint num6 = BitConverter.ToUInt32(array3, 28);
						uint num7 = BitConverter.ToUInt32(array3, 32);
						uint num8 = BitConverter.ToUInt32(array3, 36);
						long num9 = intptr_1.ToInt64();
						byte[] array4 = GClass34.smethod_16(intptr_0, num9 + (long)((ulong)num7), (int)(num4 * 4U));
						byte[] array5 = GClass34.smethod_16(intptr_0, num9 + (long)((ulong)num8), (int)(num4 * 2U));
						byte[] array6 = GClass34.smethod_16(intptr_0, num9 + (long)((ulong)num6), (int)(num5 * 4U));
						if (array4 != null && array5 != null && array6 != null)
						{
							byte[] bytes = Encoding.ASCII.GetBytes(string_3);
							for (int i = 0; i < (int)num4; i++)
							{
								uint num10 = BitConverter.ToUInt32(array4, i * 4);
								byte[] array7 = GClass34.smethod_16(intptr_0, num9 + (long)((ulong)num10), bytes.Length + 1);
								if (array7 != null)
								{
									bool flag = true;
									int j = 0;
									while (j < bytes.Length)
									{
										if (array7[j] != bytes[j])
										{
											flag = false;
											IL_0188:
											if (!flag || array7[bytes.Length] != 0)
											{
												goto IL_01A8;
											}
											ushort num11 = BitConverter.ToUInt16(array5, i * 2);
											if ((uint)num11 >= num5)
											{
												goto IL_01A8;
											}
											uint num12 = BitConverter.ToUInt32(array6, (int)(num11 * 4));
											return (uint)(num9 + (long)((ulong)num12));
										}
										else
										{
											j++;
										}
									}
									{
										if (!flag || array7[bytes.Length] != 0)
										{
											goto IL_01A8;
										}
										ushort num11 = BitConverter.ToUInt16(array5, i * 2);
										if ((uint)num11 >= num5)
										{
											goto IL_01A8;
										}
										uint num12 = BitConverter.ToUInt32(array6, (int)(num11 * 4));
										return (uint)(num9 + (long)((ulong)num12));
									}
								}
								IL_01A8:;
							}
							return 0U;
						}
						return 0U;
					}
				}
				return 0U;
			}
		}
		return 0U;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00043B38 File Offset: 0x00041D38
	private static bool smethod_24(IntPtr intptr_0)
	{
		int processId = GClass34.GetProcessId(intptr_0);
		GClass34.Struct25 @struct = GClass34.smethod_13(processId, "kernel32.dll");
		GClass34.Struct25 struct2 = GClass34.smethod_13(processId, "ntdll.dll");
		if (@struct.intptr_0 == IntPtr.Zero || struct2.intptr_0 == IntPtr.Zero)
		{
			return false;
		}
		if (Environment.Is64BitProcess && (!GClass34.smethod_11(intptr_0, @struct.intptr_0) || !GClass34.smethod_11(intptr_0, struct2.intptr_0)))
		{
			return false;
		}
		uint num = GClass34.smethod_23(intptr_0, @struct.intptr_0, "ExitProcess");
		uint num2 = GClass34.smethod_23(intptr_0, @struct.intptr_0, "TerminateProcess");
		uint num3 = GClass34.smethod_23(intptr_0, struct2.intptr_0, "NtTerminateProcess");
		return num != 0U && num2 != 0U && num3 != 0U && (true & GClass34.smethod_25(intptr_0, num) & GClass34.smethod_26(intptr_0, num2, true) & GClass34.smethod_26(intptr_0, num3, false));
	}

	// Token: 0x0600084A RID: 2122
	[DllImport("kernel32.dll")]
	private static extern int GetProcessId(IntPtr intptr_0);

	// Token: 0x0600084B RID: 2123 RVA: 0x00043C14 File Offset: 0x00041E14
	private static bool smethod_25(IntPtr intptr_0, uint uint_15)
	{
		byte[] array = GClass34.smethod_16(intptr_0, (long)((ulong)uint_15), 5);
		if (array == null)
		{
			return false;
		}
		if (array[0] == 233)
		{
			int num = BitConverter.ToInt32(array, 1);
			long num2 = (long)((ulong)uint_15 + 5UL + (ulong)((long)num));
			byte[] array2 = GClass34.smethod_16(intptr_0, num2, 3);
			if (array2 != null && array2[0] == 194 && array2[1] == 4)
			{
				return true;
			}
		}
		IntPtr intPtr = GClass34.VirtualAllocEx(intptr_0, IntPtr.Zero, (UIntPtr)16UL, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array3 = new byte[3];
		array3[0] = 194;
		array3[1] = 4;
		byte[] array4 = array3;
		int num3;
		if (!GClass34.WriteProcessMemory(intptr_0, intPtr, array4, array4.Length, out num3))
		{
			return false;
		}
		byte[] array5 = new byte[5];
		array5[0] = 233;
		BitConverter.GetBytes(GClass34.smethod_33(intPtr) - (int)(uint_15 + 5U)).CopyTo(array5, 1);
		return GClass34.smethod_17(intptr_0, (long)((ulong)uint_15), array5);
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00043CFC File Offset: 0x00041EFC
	private static bool smethod_26(IntPtr intptr_0, uint uint_15, bool bool_1)
	{
		byte[] array = GClass34.smethod_16(intptr_0, (long)((ulong)uint_15), 8);
		if (array == null)
		{
			return false;
		}
		if (array[0] == 233)
		{
			int num = BitConverter.ToInt32(array, 1);
			long num2 = (long)((ulong)uint_15 + 5UL + (ulong)((long)num));
			byte[] array2 = GClass34.smethod_16(intptr_0, num2, 8);
			if (bool_1)
			{
				if (array2 != null && array2[0] == 184 && array2[1] == 1 && array2[5] == 194 && array2[6] == 8)
				{
					return true;
				}
			}
			else if (array2 != null && array2[0] == 51 && array2[1] == 192 && array2[2] == 194 && array2[3] == 8)
			{
				return true;
			}
		}
		IntPtr intPtr = GClass34.VirtualAllocEx(intptr_0, IntPtr.Zero, (UIntPtr)16UL, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array3;
		if (bool_1)
		{
			array3 = new byte[] { 184, 1, 0, 0, 0, 194, 8, 0 };
		}
		else
		{
			array3 = new byte[] { 51, 192, 194, 8, 0 };
		}
		int num3;
		if (!GClass34.WriteProcessMemory(intptr_0, intPtr, array3, array3.Length, out num3))
		{
			return false;
		}
		byte[] array4 = new byte[5];
		array4[0] = 233;
		BitConverter.GetBytes(GClass34.smethod_33(intPtr) - (int)(uint_15 + 5U)).CopyTo(array4, 1);
		return GClass34.smethod_17(intptr_0, (long)((ulong)uint_15), array4);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00043E38 File Offset: 0x00042038
	private static int smethod_27(IntPtr intptr_0, IntPtr intptr_1, uint uint_15)
	{
		int num = 0;
		byte[] array = new byte[] { 106, 0, byte.MaxValue, 21, 208, 144, 245, 0 };
		byte[] array2 = new byte[] { 235, 6, 144, 144, 144, 144, 144, 144 };
		byte[] array3 = new byte[]
		{
			byte.MaxValue, 53, 100, 130, 5, 1, byte.MaxValue, 21, 92, 149,
			245, 0
		};
		byte[] array4 = new byte[]
		{
			235, 10, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144
		};
		byte[] array5 = new byte[]
		{
			131, 196, 4, 144, 144, 144, 144, 144, 144, 144,
			144, 144
		};
		byte[] array6 = new byte[]
		{
			106, 16, byte.MaxValue, 53, 100, 130, 5, 1, byte.MaxValue, 21,
			96, 149, 245, 0
		};
		byte[] array7 = new byte[] { 235, 12 };
		foreach (ValueTuple<long, int> valueTuple in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			byte[] array8 = GClass34.smethod_16(intptr_0, item, item2);
			if (array8 != null)
			{
				int num2 = 0;
				for (;;)
				{
					int num3 = GClass34.smethod_18(array8, array, num2);
					if (num3 < 0)
					{
						break;
					}
					if (GClass34.smethod_17(intptr_0, item + (long)num3, array2))
					{
						num++;
						GClass34.smethod_1("  [Game] nop ExitProcess @ 0x{0:X8}", new object[] { item + (long)num3 });
					}
					num2 = num3 + 1;
				}
				num2 = 0;
				for (;;)
				{
					int num4 = GClass34.smethod_18(array8, array5, num2);
					if (num4 < 0)
					{
						break;
					}
					if (GClass34.smethod_17(intptr_0, item + (long)num4, array4))
					{
						num++;
						GClass34.smethod_1("  [Game] fix DestroyWindow @ 0x{0:X8}", new object[] { item + (long)num4 });
					}
					num2 = num4 + 1;
				}
				num2 = 0;
				for (;;)
				{
					int num5 = GClass34.smethod_18(array8, array3, num2);
					if (num5 < 0)
					{
						break;
					}
					if (GClass34.smethod_17(intptr_0, item + (long)num5, array4))
					{
						num++;
						GClass34.smethod_1("  [Game] skip DestroyWindow @ 0x{0:X8}", new object[] { item + (long)num5 });
					}
					num2 = num5 + 1;
				}
				num2 = 0;
				for (;;)
				{
					int num6 = GClass34.smethod_18(array8, array6, num2);
					if (num6 < 0)
					{
						break;
					}
					if (num6 >= 2 && array8[num6 - 2] == 235 && (array8[num6 - 1] == 22 || array8[num6 - 1] == 16))
					{
						num2 = num6 + 1;
					}
					else if (array8[num6] == 235)
					{
						num2 = num6 + 1;
					}
					else
					{
						if (GClass34.smethod_17(intptr_0, item + (long)num6, array7))
						{
							num++;
							GClass34.smethod_1("  [Game] skip PostMsg WM_CLOSE @ 0x{0:X8}", new object[] { item + (long)num6 });
						}
						num2 = num6 + 1;
					}
				}
			}
		}
		byte[] array9 = new byte[] { byte.MaxValue, 21, 208, 144, 245, 0 };
		foreach (ValueTuple<long, int> valueTuple2 in GClass34.smethod_15(intptr_0, intptr_1, uint_15))
		{
			long item3 = valueTuple2.Item1;
			int item4 = valueTuple2.Item2;
			byte[] array10 = GClass34.smethod_16(intptr_0, item3, item4);
			if (array10 != null)
			{
				int num7 = 0;
				for (;;)
				{
					int num8 = GClass34.smethod_18(array10, array9, num7);
					if (num8 < 0)
					{
						break;
					}
					if (num8 >= 2 && array10[num8 - 2] == 235 && array10[num8 - 1] == 6)
					{
						num7 = num8 + 1;
					}
					else if (array10[num8] == 235)
					{
						num7 = num8 + 1;
					}
					else
					{
						if (GClass34.smethod_17(intptr_0, item3 + (long)num8, new byte[] { 235, 4, 144, 144, 144, 144 }))
						{
							num++;
							GClass34.smethod_1("  [Game] nop ExitProcess2 @ 0x{0:X8}", new object[] { item3 + (long)num8 });
						}
						num7 = num8 + 1;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00008012 File Offset: 0x00006212
	private static string smethod_28(int int_0)
	{
		return "Global\\D5854F17-0B12-4D61-AE21-7EB607CD6DFE_" + int_0.ToString();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x000441E8 File Offset: 0x000423E8
	private static bool smethod_29(int int_0)
	{
		IntPtr intPtr = GClass34.OpenProcess(2035711U, false, int_0);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		try
		{
			int num = 1048576;
			IntPtr intPtr2 = IntPtr.Zero;
			try
			{
				uint num2;
				do
				{
					intPtr2 = Marshal.AllocHGlobal(num);
					int num3;
					num2 = GClass34.NtQuerySystemInformation(64, intPtr2, num, out num3);
					if (num2 != 3221225476U)
					{
						goto IL_0073;
					}
					Marshal.FreeHGlobal(intPtr2);
					intPtr2 = IntPtr.Zero;
					num = Math.Max(num * 2, num3 + 65536);
				}
				while (num <= 268435456);
				return false;
				IL_0073:
				if (num2 != 0U)
				{
					return false;
				}
				long num4 = Marshal.ReadInt64(intPtr2);
				int num5 = Marshal.SizeOf(typeof(GClass34.Struct22));
				IntPtr intPtr3 = IntPtr.Add(intPtr2, IntPtr.Size * 2);
				for (long num6 = 0L; num6 < num4; num6 += 1L)
				{
					GClass34.Struct22 @struct = Marshal.PtrToStructure<GClass34.Struct22>(intPtr3);
					intPtr3 = IntPtr.Add(intPtr3, num5);
					IntPtr intPtr4;
					if (@struct.intptr_1.ToInt64() == (long)int_0 && GClass34.DuplicateHandle(intPtr, @struct.intptr_2, GClass34.GetCurrentProcess(), out intPtr4, 0U, false, 2U))
					{
						try
						{
							string text = GClass34.smethod_30(intPtr4);
							if (!string.IsNullOrEmpty(text) && text.IndexOf("D5854F17-0B12-4D61-AE21-7EB607CD6DFE", StringComparison.OrdinalIgnoreCase) >= 0)
							{
								return true;
							}
						}
						finally
						{
							GClass34.CloseHandle(intPtr4);
						}
					}
				}
			}
			finally
			{
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr2);
				}
			}
		}
		finally
		{
			GClass34.CloseHandle(intPtr);
		}
		return false;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0004439C File Offset: 0x0004259C
	private static string smethod_30(IntPtr intptr_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(8192);
		string text;
		try
		{
			int num;
			if (GClass34.NtQueryObject(intptr_0, 1, intPtr, 8192, out num) != 0U)
			{
				text = null;
			}
			else
			{
				GClass34.Struct23 @struct = Marshal.PtrToStructure<GClass34.Struct23>(intPtr);
				if (@struct.ushort_0 != 0 && !(@struct.intptr_0 == IntPtr.Zero))
				{
					text = Marshal.PtrToStringUni(@struct.intptr_0, (int)(@struct.ushort_0 / 2));
				}
				else
				{
					text = null;
				}
			}
		}
		catch
		{
			text = null;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return text;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00044430 File Offset: 0x00042630
	private static int smethod_31()
	{
		for (int i = 0; i < 127; i++)
		{
			IntPtr intPtr = GClass34.OpenMutex(1048576U, false, GClass34.smethod_28(i));
			if (intPtr == IntPtr.Zero)
			{
				return i;
			}
			GClass34.CloseHandle(intPtr);
		}
		return -1;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00044474 File Offset: 0x00042674
	private static void smethod_32(IntPtr intptr_0, int int_0, bool bool_1)
	{
		object obj = GClass34.object_0;
		lock (obj)
		{
			if (!GClass34.hashSet_1.Contains(int_0))
			{
				if (GClass34.smethod_29(int_0))
				{
					GClass34.hashSet_1.Add(int_0);
					if (bool_1)
					{
						GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} da co mutex slot", new object[]
						{
							DateTime.Now,
							int_0
						});
					}
				}
				else
				{
					int num = GClass34.smethod_31();
					if (num < 0)
					{
						GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} het slot mutex", new object[]
						{
							DateTime.Now,
							int_0
						});
					}
					else if (GClass34.smethod_35(intptr_0, GClass34.smethod_28(num)))
					{
						GClass34.hashSet_1.Add(int_0);
						GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} gan mutex slot {2}", new object[]
						{
							DateTime.Now,
							int_0,
							num
						});
					}
					else if (bool_1)
					{
						GClass34.smethod_1("[{0:HH:mm:ss}] PID={1} gan mutex slot {2} THAT BAI", new object[]
						{
							DateTime.Now,
							int_0,
							num
						});
					}
				}
			}
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00008025 File Offset: 0x00006225
	private static int smethod_33(IntPtr intptr_0)
	{
		return (int)(intptr_0.ToInt64() & 4294967295L);
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00008039 File Offset: 0x00006239
	private static int smethod_34(long long_0)
	{
		return (int)(long_0 & 4294967295L);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x000445C0 File Offset: 0x000427C0
	private static bool smethod_35(IntPtr intptr_0, string string_3)
	{
		GClass34.Struct25 @struct = GClass34.smethod_13(GClass34.GetProcessId(intptr_0), "kernel32.dll");
		if (@struct.intptr_0 == IntPtr.Zero)
		{
			return false;
		}
		uint num = GClass34.smethod_23(intptr_0, @struct.intptr_0, "CreateMutexW");
		if (num == 0U)
		{
			return false;
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_3 + "\0");
		IntPtr intPtr = GClass34.VirtualAllocEx(intptr_0, IntPtr.Zero, (UIntPtr)((ulong)((long)bytes.Length)), 12288U, 4U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		bool flag;
		try
		{
			int num2;
			if (!GClass34.WriteProcessMemory(intptr_0, intPtr, bytes, bytes.Length, out num2))
			{
				flag = false;
			}
			else
			{
				uint num3 = (uint)GClass34.smethod_33(intPtr);
				byte[] array = new byte[]
				{
					104, 0, 0, 0, 0, 106, 0, 106, 0, 184,
					0, 0, 0, 0, byte.MaxValue, 208, 195
				};
				BitConverter.GetBytes(num3).CopyTo(array, 1);
				BitConverter.GetBytes(num).CopyTo(array, 10);
				intPtr2 = GClass34.VirtualAllocEx(intptr_0, IntPtr.Zero, (UIntPtr)((ulong)((long)array.Length)), 12288U, 64U);
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else if (!GClass34.WriteProcessMemory(intptr_0, intPtr2, array, array.Length, out num2))
				{
					flag = false;
				}
				else
				{
					uint num4;
					intPtr3 = GClass34.CreateRemoteThread(intptr_0, IntPtr.Zero, UIntPtr.Zero, intPtr2, IntPtr.Zero, 0U, out num4);
					if (intPtr3 == IntPtr.Zero)
					{
						flag = false;
					}
					else
					{
						GClass34.WaitForSingleObject(intPtr3, 5000U);
						flag = true;
					}
				}
			}
		}
		finally
		{
			if (intPtr3 != IntPtr.Zero)
			{
				GClass34.CloseHandle(intPtr3);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				GClass34.VirtualFreeEx(intptr_0, intPtr2, UIntPtr.Zero, 32768U);
			}
			if (intPtr != IntPtr.Zero)
			{
				GClass34.VirtualFreeEx(intptr_0, intPtr, UIntPtr.Zero, 32768U);
			}
		}
		return flag;
	}

	// Token: 0x040004BA RID: 1210
	private const byte byte_0 = 127;

	// Token: 0x040004BB RID: 1211
	private const string string_0 = "D5854F17-0B12-4D61-AE21-7EB607CD6DFE";

	// Token: 0x040004BC RID: 1212
	private const uint uint_0 = 2035711U;

	// Token: 0x040004BD RID: 1213
	private const uint uint_1 = 4096U;

	// Token: 0x040004BE RID: 1214
	private const uint uint_2 = 8192U;

	// Token: 0x040004BF RID: 1215
	private const uint uint_3 = 32768U;

	// Token: 0x040004C0 RID: 1216
	private const uint uint_4 = 4U;

	// Token: 0x040004C1 RID: 1217
	private const uint uint_5 = 64U;

	// Token: 0x040004C2 RID: 1218
	private const uint uint_6 = 16U;

	// Token: 0x040004C3 RID: 1219
	private const uint uint_7 = 32U;

	// Token: 0x040004C4 RID: 1220
	private const uint uint_8 = 128U;

	// Token: 0x040004C5 RID: 1221
	private const uint uint_9 = 1U;

	// Token: 0x040004C6 RID: 1222
	private const uint uint_10 = 8U;

	// Token: 0x040004C7 RID: 1223
	private const uint uint_11 = 16U;

	// Token: 0x040004C8 RID: 1224
	private const uint uint_12 = 1U;

	// Token: 0x040004C9 RID: 1225
	private const uint uint_13 = 3U;

	// Token: 0x040004CA RID: 1226
	private const uint uint_14 = 4294967295U;

	// Token: 0x040004CB RID: 1227
	private static readonly HashSet<int> hashSet_0 = new HashSet<int>();

	// Token: 0x040004CC RID: 1228
	private static readonly HashSet<int> hashSet_1 = new HashSet<int>();

	// Token: 0x040004CD RID: 1229
	private static readonly HashSet<int> hashSet_2 = new HashSet<int>();

	// Token: 0x040004CE RID: 1230
	private static readonly HashSet<int> hashSet_3 = new HashSet<int>();

	// Token: 0x040004CF RID: 1231
	private static readonly object object_0 = new object();

	// Token: 0x040004D0 RID: 1232
	[CompilerGenerated]
	private static Action<string> action_0;

	// Token: 0x040004D1 RID: 1233
	[CompilerGenerated]
	private static string string_1;

	// Token: 0x040004D2 RID: 1234
	private static Timer timer_0;

	// Token: 0x040004D3 RID: 1235
	private static volatile bool bool_0;

	// Token: 0x040004D4 RID: 1236
	private static string string_2 = "";

	// Token: 0x020000C1 RID: 193
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct20
	{
		// Token: 0x040004D5 RID: 1237
		public uint uint_0;

		// Token: 0x040004D6 RID: 1238
		public uint uint_1;

		// Token: 0x040004D7 RID: 1239
		public uint uint_2;

		// Token: 0x040004D8 RID: 1240
		public uint uint_3;

		// Token: 0x040004D9 RID: 1241
		public uint uint_4;

		// Token: 0x040004DA RID: 1242
		public IntPtr intptr_0;

		// Token: 0x040004DB RID: 1243
		public uint uint_5;

		// Token: 0x040004DC RID: 1244
		public IntPtr intptr_1;

		// Token: 0x040004DD RID: 1245
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x040004DE RID: 1246
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x020000C2 RID: 194
	private struct Struct21
	{
		// Token: 0x040004DF RID: 1247
		public IntPtr intptr_0;

		// Token: 0x040004E0 RID: 1248
		public IntPtr intptr_1;

		// Token: 0x040004E1 RID: 1249
		public uint uint_0;

		// Token: 0x040004E2 RID: 1250
		public UIntPtr uintptr_0;

		// Token: 0x040004E3 RID: 1251
		public uint uint_1;

		// Token: 0x040004E4 RID: 1252
		public uint uint_2;

		// Token: 0x040004E5 RID: 1253
		public uint uint_3;
	}

	// Token: 0x020000C3 RID: 195
	private struct Struct22
	{
		// Token: 0x040004E6 RID: 1254
		public IntPtr intptr_0;

		// Token: 0x040004E7 RID: 1255
		public IntPtr intptr_1;

		// Token: 0x040004E8 RID: 1256
		public IntPtr intptr_2;

		// Token: 0x040004E9 RID: 1257
		public uint uint_0;

		// Token: 0x040004EA RID: 1258
		public ushort ushort_0;

		// Token: 0x040004EB RID: 1259
		public ushort ushort_1;

		// Token: 0x040004EC RID: 1260
		public uint uint_1;

		// Token: 0x040004ED RID: 1261
		public uint uint_2;
	}

	// Token: 0x020000C4 RID: 196
	private struct Struct23
	{
		// Token: 0x040004EE RID: 1262
		public ushort ushort_0;

		// Token: 0x040004EF RID: 1263
		public ushort ushort_1;

		// Token: 0x040004F0 RID: 1264
		public IntPtr intptr_0;
	}

	// Token: 0x020000C5 RID: 197
	private struct Struct24
	{
		// Token: 0x040004F1 RID: 1265
		public IntPtr intptr_0;

		// Token: 0x040004F2 RID: 1266
		public uint uint_0;

		// Token: 0x040004F3 RID: 1267
		public IntPtr intptr_1;
	}

	// Token: 0x020000C6 RID: 198
	private struct Struct25
	{
		// Token: 0x040004F4 RID: 1268
		public IntPtr intptr_0;

		// Token: 0x040004F5 RID: 1269
		public uint uint_0;
	}

	// Token: 0x020000C7 RID: 199
	[CompilerGenerated]
	[Serializable]
	private sealed class Class100
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x000447F4 File Offset: 0x000429F4
		internal void method_0(object object_0)
		{
			if (!GClass34.bool_0)
			{
				return;
			}
			try
			{
				GClass34.Class101 @class = new GClass34.Class101();
				@class.hashSet_0 = new HashSet<int>();
				foreach (Process process in Process.GetProcessesByName("Game"))
				{
					@class.hashSet_0.Add(process.Id);
					try
					{
						GClass34.smethod_10(process.Id, false);
					}
					catch
					{
					}
					finally
					{
						process.Dispose();
					}
				}
				GClass34.hashSet_0.RemoveWhere(new Predicate<int>(@class.method_0));
				GClass34.hashSet_1.RemoveWhere(new Predicate<int>(@class.method_1));
				GClass34.hashSet_2.RemoveWhere(new Predicate<int>(@class.method_2));
				GClass34.hashSet_3.RemoveWhere(new Predicate<int>(@class.method_3));
			}
			catch
			{
			}
		}

		// Token: 0x040004F6 RID: 1270
		public static readonly GClass34.Class100 f_19566E19 = new GClass34.Class100();

		// Token: 0x040004F7 RID: 1271
		public static TimerCallback f_3A9E9105;
	}

	// Token: 0x020000C8 RID: 200
	[CompilerGenerated]
	private sealed class Class101
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00008053 File Offset: 0x00006253
		internal bool method_0(int int_0)
		{
			return !this.hashSet_0.Contains(int_0);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00008053 File Offset: 0x00006253
		internal bool method_1(int int_0)
		{
			return !this.hashSet_0.Contains(int_0);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00008053 File Offset: 0x00006253
		internal bool method_2(int int_0)
		{
			return !this.hashSet_0.Contains(int_0);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00008053 File Offset: 0x00006253
		internal bool method_3(int int_0)
		{
			return !this.hashSet_0.Contains(int_0);
		}

		// Token: 0x040004F8 RID: 1272
		public HashSet<int> hashSet_0;
	}

	// Token: 0x020000C9 RID: 201
	[CompilerGenerated]
	private sealed class Class102
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x000448F0 File Offset: 0x00042AF0
		internal void method_0(object object_0)
		{
			for (int i = 0; i < this.int_0; i++)
			{
				GClass34.smethod_9(this.string_0);
			}
		}

		// Token: 0x040004F9 RID: 1273
		public string string_0;

		// Token: 0x040004FA RID: 1274
		public int int_0;
	}

	// Token: 0x020000CA RID: 202
	[CompilerGenerated]
	private sealed class Class103 : IEnumerable<ValueTuple<long, int>>, IEnumerator<ValueTuple<long, int>>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x00008064 File Offset: 0x00006264
		[DebuggerHidden]
		public Class103(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0000807E File Offset: 0x0000627E
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0004491C File Offset: 0x00042B1C
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num == 0)
			{
				this.int_0 = -1;
				this.long_0 = this.intptr_0.ToInt64();
				this.long_1 = this.long_0 + (long)((ulong)this.uint_0);
				this.long_2 = this.long_0;
				goto IL_0132;
			}
			if (num != 1)
			{
				return false;
			}
			this.int_0 = -1;
			IL_0114:
			long num2 = this.long_3 + this.long_4;
			if (num2 <= this.long_2)
			{
				return false;
			}
			this.long_2 = num2;
			IL_0132:
			if (this.long_2 >= this.long_1)
			{
				return false;
			}
			GClass34.Struct21 @struct;
			if (GClass34.VirtualQueryEx(this.intptr_2, (IntPtr)this.long_2, out @struct, (UIntPtr)((ulong)((long)Marshal.SizeOf(typeof(GClass34.Struct21))))) == UIntPtr.Zero)
			{
				return false;
			}
			this.long_3 = @struct.intptr_0.ToInt64();
			this.long_4 = (long)(ulong)@struct.uintptr_0;
			if (this.long_4 <= 0L)
			{
				return false;
			}
			if (@struct.uint_1 != 4096U || !GClass34.smethod_14(@struct.uint_2))
			{
				goto IL_0114;
			}
			long num3 = Math.Max(this.long_3, this.long_0);
			long num4 = Math.Min(this.long_3 + this.long_4, this.long_1);
			if (num4 <= num3)
			{
				goto IL_0114;
			}
			this.valueTuple_0 = new ValueTuple<long, int>(num3, (int)(num4 - num3));
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00008088 File Offset: 0x00006288
		public ValueTuple<long, int> Current
		{
			[DebuggerHidden]
			get
			{
				return this.valueTuple_0;
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00008090 File Offset: 0x00006290
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.valueTuple_0;
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00044A90 File Offset: 0x00042C90
		[DebuggerHidden]
		public IEnumerator<ValueTuple<long, int>> GetEnumerator()
		{
			GClass34.Class103 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass34.Class103(0);
			}
			@class.intptr_2 = this.intptr_3;
			@class.intptr_0 = this.intptr_1;
			@class.uint_0 = this.uint_1;
			return @class;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000809D File Offset: 0x0000629D
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040004FB RID: 1275
		private int int_0;

		// Token: 0x040004FC RID: 1276
		private ValueTuple<long, int> valueTuple_0;

		// Token: 0x040004FD RID: 1277
		private int int_1;

		// Token: 0x040004FE RID: 1278
		private IntPtr intptr_0;

		// Token: 0x040004FF RID: 1279
		public IntPtr intptr_1;

		// Token: 0x04000500 RID: 1280
		private uint uint_0;

		// Token: 0x04000501 RID: 1281
		public uint uint_1;

		// Token: 0x04000502 RID: 1282
		private IntPtr intptr_2;

		// Token: 0x04000503 RID: 1283
		public IntPtr intptr_3;

		// Token: 0x04000504 RID: 1284
		private long long_0;

		// Token: 0x04000505 RID: 1285
		private long long_1;

		// Token: 0x04000506 RID: 1286
		private long long_2;

		// Token: 0x04000507 RID: 1287
		private long long_3;

		// Token: 0x04000508 RID: 1288
		private long long_4;
	}
}
