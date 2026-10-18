using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020000A5 RID: 165
internal static class Class90
{
	// Token: 0x0600073B RID: 1851
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_8, IntPtr intptr_2, string string_2, ref Class90.Struct5 struct5_0, out Class90.Struct6 struct6_0);

	// Token: 0x0600073C RID: 1852
	[DllImport("kernel32.dll")]
	private static extern uint ResumeThread(IntPtr intptr_0);

	// Token: 0x0600073D RID: 1853
	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x0600073E RID: 1854
	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x0600073F RID: 1855
	[DllImport("kernel32.dll")]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_8);

	// Token: 0x06000740 RID: 1856
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_8, bool bool_0, int int_9);

	// Token: 0x06000741 RID: 1857
	[DllImport("kernel32.dll")]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, uint uint_9, uint uint_10);

	// Token: 0x06000742 RID: 1858
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_9, out int int_10);

	// Token: 0x06000743 RID: 1859
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_9, out int int_10);

	// Token: 0x06000744 RID: 1860
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_8, out uint uint_9);

	// Token: 0x06000745 RID: 1861
	[DllImport("kernel32.dll")]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	// Token: 0x06000746 RID: 1862
	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, IntPtr intptr_2, IntPtr intptr_3, uint uint_9, IntPtr intptr_4);

	// Token: 0x06000747 RID: 1863
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_9, out int int_10, uint uint_8);

	// Token: 0x06000748 RID: 1864
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModules(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_9, out int int_10);

	// Token: 0x06000749 RID: 1865
	[DllImport("psapi.dll", CharSet = CharSet.Ansi)]
	private static extern uint GetModuleBaseNameA(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_9);

	// Token: 0x0600074A RID: 1866
	[DllImport("psapi.dll")]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out Class90.Struct7 struct7_0, int int_9);

	// Token: 0x0600074B RID: 1867 RVA: 0x00007D00 File Offset: 0x00005F00
	private static int smethod_0(IntPtr intptr_0)
	{
		return (int)((uint)intptr_0.ToInt64());
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00007CE1 File Offset: 0x00005EE1
	private static IntPtr smethod_1(int int_9)
	{
		return new IntPtr((long)((ulong)int_9));
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00036E30 File Offset: 0x00035030
	private static bool smethod_2(IntPtr intptr_0)
	{
		bool flag;
		return IntPtr.Size == 4 || !Class90.IsWow64Process(intptr_0, out flag) || flag;
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00007D0A File Offset: 0x00005F0A
	public static Class90.Class91 smethod_3(string string_0)
	{
		return Class90.smethod_4(string_0, "-fl");
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00036E54 File Offset: 0x00035054
	public static Class90.Class91 smethod_4(string string_0, string string_1)
	{
		Class90.Class91 @class = Class90.smethod_8(string_0, string_1, null, true, 60000);
		if (@class.bool_0 && @class.int_0 > 0)
		{
			string text = Path.GetDirectoryName(Path.GetFullPath(string_0)) ?? ".";
			Class90.smethod_12(@class.int_0, text);
		}
		return @class;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00007D17 File Offset: 0x00005F17
	public static Class90.Class91 smethod_5(string string_0, string string_1 = "-fl")
	{
		return Class90.smethod_8(string_0, string_1, null, false, 300000);
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00007D27 File Offset: 0x00005F27
	public static Class90.Class91 smethod_6(string string_0, string string_1, bool bool_0)
	{
		return Class90.smethod_8(string_0, string_1, null, bool_0, 300000);
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00007D37 File Offset: 0x00005F37
	public static Class90.Class91 smethod_7(string string_0, string string_1, byte[] byte_0)
	{
		return Class90.smethod_8(string_0, string_1, byte_0, false, 300000);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00036EA4 File Offset: 0x000350A4
	public static Class90.Class91 smethod_8(string string_0, string string_1, byte[] byte_0, bool bool_0, int int_9)
	{
		Class90.Class91 @class = new Class90.Class91();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("hostBits=" + (IntPtr.Size * 8).ToString());
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			string text = Path.GetDirectoryName(Path.GetFullPath(string_0)) ?? ".";
			string_0 = Path.GetFullPath(string_0);
			@class = Class90.smethod_13(string_0, text, string_1, byte_0, stringBuilder, @class);
			if (@class.bool_0 && bool_0 && @class.int_0 > 0)
			{
				@class.bool_6 = Class90.smethod_34(@class.int_0, int_9);
				stringBuilder.AppendLine("pluginMem=" + @class.bool_6.ToString());
				@class.string_1 = Class90.smethod_14(string_0, stringBuilder);
			}
			else if (@class.bool_0 && @class.int_0 > 0)
			{
				stringBuilder.AppendLine("pluginMem=background");
				@class.string_1 = Class90.smethod_14(string_0, stringBuilder);
			}
			return @class;
		}
		@class.string_2 = "Khong tim thay file: " + string_0;
		@class.string_1 = Class90.smethod_14(string_0, stringBuilder);
		return @class;
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00036FD4 File Offset: 0x000351D4
	private static void smethod_9(int int_9, byte[] byte_0, string string_0)
	{
		for (int i = 0; i < 2400; i++)
		{
			try
			{
				Process processById = Process.GetProcessById(int_9);
				if (processById.HasExited)
				{
					break;
				}
				if (!Class90.smethod_20(processById))
				{
					Class90.smethod_22(processById, byte_0);
				}
				Class90.smethod_21(processById, byte_0);
				Class90.smethod_37(processById);
				if (Class90.smethod_10(processById, string_0))
				{
					try
					{
						File.AppendAllText(Path.Combine(string_0, "TnclPluginWatch.log"), string.Concat(new string[]
						{
							DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
							" pid=",
							int_9.ToString(),
							" pluginSnap=True keepAlive",
							Environment.NewLine
						}));
					}
					catch
					{
					}
				}
			}
			catch
			{
				break;
			}
			Thread.Sleep(500);
		}
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x000370B8 File Offset: 0x000352B8
	private static bool smethod_10(Process process_0, string string_0)
	{
		if (Class90.smethod_35(process_0))
		{
			return true;
		}
		string text = Path.Combine(string_0, "Plugin.dll");
		if (!File.Exists(text))
		{
			return false;
		}
		if (!Class90.smethod_11(process_0, text))
		{
			return false;
		}
		Thread.Sleep(100);
		return Class90.smethod_35(process_0);
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00037100 File Offset: 0x00035300
	private static bool smethod_11(Process process_0, string string_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (Class90.smethod_26(intPtr, "Plugin.dll", out num, out num2))
			{
				flag = true;
			}
			else
			{
				IntPtr intPtr2 = Class90.smethod_27(intPtr, "kernel32.dll", "LoadLibraryA");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_0 + "\0");
					IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)bytes.Length, 12288U, 64U);
					int num3;
					if (intPtr3 == IntPtr.Zero)
					{
						flag = false;
					}
					else if (!Class90.WriteProcessMemory(intPtr, intPtr3, bytes, bytes.Length, out num3))
					{
						flag = false;
					}
					else
					{
						IntPtr intPtr4 = Class90.CreateRemoteThread(intPtr, IntPtr.Zero, 0U, intPtr2, intPtr3, 0U, IntPtr.Zero);
						if (intPtr4 == IntPtr.Zero)
						{
							flag = false;
						}
						else
						{
							Class90.WaitForSingleObject(intPtr4, 10000U);
							Class90.CloseHandle(intPtr4);
							flag = Class90.smethod_26(intPtr, "Plugin.dll", out num, out num2);
						}
					}
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00007D47 File Offset: 0x00005F47
	private static void smethod_12(int int_9, string string_0)
	{
		Class90.Class92 @class = new Class90.Class92();
		@class.int_0 = int_9;
		@class.string_0 = string_0;
		new Thread(new ThreadStart(@class.method_0))
		{
			IsBackground = true
		}.Start();
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00037234 File Offset: 0x00035434
	private static Class90.Class91 smethod_13(string string_0, string string_1, string string_2, byte[] byte_0, StringBuilder stringBuilder_0, Class90.Class91 class91_0)
	{
		stringBuilder_0.AppendLine("mode=direct-patch");
		string text = "\"" + string_0 + "\"";
		if (!string.IsNullOrWhiteSpace(string_2))
		{
			text = text + " " + string_2;
		}
		Class90.Struct5 @struct = default(Class90.Struct5);
		@struct.int_0 = Marshal.SizeOf(typeof(Class90.Struct5));
		Class90.Struct6 struct2;
		if (!Class90.CreateProcess(string_0, text, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, string_1, ref @struct, out struct2))
		{
			class91_0.string_2 = "CreateProcess fail err=" + Marshal.GetLastWin32Error().ToString();
			class91_0.string_1 = Class90.smethod_14(string_0, stringBuilder_0);
			return class91_0;
		}
		class91_0.int_0 = struct2.int_0;
		stringBuilder_0.AppendLine("pid=" + class91_0.int_0.ToString());
		try
		{
			Class90.Class93 @class = new Class90.Class93();
			bool flag;
			if (IntPtr.Size == 8 && Class90.IsWow64Process(struct2.intptr_0, out flag))
			{
				stringBuilder_0.AppendLine("wow64=" + flag.ToString());
			}
			Class90.ResumeThread(struct2.intptr_1);
			bool flag2 = false;
			for (int i = 0; i < 500; i++)
			{
				if (Class90.WaitForSingleObject(struct2.intptr_0, 10U) != 258U)
				{
					class91_0.string_2 = "Game thoat truoc khi unpack";
					class91_0.string_1 = Class90.smethod_14(string_0, stringBuilder_0);
					return class91_0;
				}
				byte[] array = Class90.smethod_18(struct2.intptr_0, 6232324, 8);
				byte[] array2 = Class90.smethod_18(struct2.intptr_0, 4385227, 2);
				if (array != null && array[0] == 65 && array[1] == 50 && array[2] == 57 && array[3] == 50 && array2 != null)
				{
					if (array2[0] != 117)
					{
						if (array2[0] != 235)
						{
							continue;
						}
					}
					flag2 = true;
					stringBuilder_0.AppendLine("unpacked t=" + ((i + 1) * 10).ToString());
					break;
				}
			}
			if (!flag2)
			{
				class91_0.string_2 = "ASPack unpack timeout";
				class91_0.string_1 = Class90.smethod_14(string_0, stringBuilder_0);
				return class91_0;
			}
			Class90.SuspendThread(struct2.intptr_1);
			if (!Class90.smethod_19(struct2.intptr_0, struct2.int_0))
			{
				Class90.ResumeThread(struct2.intptr_1);
				class91_0.string_2 = "Patch mutex that bai";
				class91_0.string_1 = Class90.smethod_14(string_0, stringBuilder_0);
				return class91_0;
			}
			stringBuilder_0.AppendLine("mutex OK lim=FF");
			Class90.ResumeThread(struct2.intptr_1);
			byte[] array3 = ((byte_0 == null || byte_0.Length < 6) ? Class90.smethod_15() : ((byte[])byte_0.Clone()));
			if (array3.Length > 6)
			{
				byte[] array4 = new byte[6];
				Array.Copy(array3, array4, 6);
				array3 = array4;
			}
			array3[0] = (byte)((array3[0] & 252) | 2);
			class91_0.byte_0 = array3;
			class91_0.string_0 = Class90.smethod_16(array3);
			stringBuilder_0.AppendLine("fakeMac=" + class91_0.string_0);
			IntPtr intPtr = Class90.VirtualAllocEx(struct2.intptr_0, IntPtr.Zero, 16U, 12288U, 64U);
			int num = ((intPtr != IntPtr.Zero) ? Class90.smethod_0(intPtr) : 0);
			if (num != 0)
			{
				Class90.smethod_17(struct2.intptr_0, num, array3);
			}
			Process processById = Process.GetProcessById(struct2.int_0);
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			int num2 = 0;
			int j = 0;
			while (j < 750)
			{
				int num3 = (j + 1) * 20;
				if (Class90.WaitForSingleObject(struct2.intptr_0, 20U) != 258U)
				{
					stringBuilder_0.AppendLine("exited t=" + num3.ToString());
					class91_0.string_2 = "Game thoat som";
					break;
				}
				try
				{
					Class90.smethod_22(processById, array3);
					goto IL_05AD;
				}
				catch
				{
					goto IL_05AD;
				}
				goto IL_03B1;
				IL_03BC:
				try
				{
					Class90.smethod_21(processById, array3);
				}
				catch
				{
				}
				if (num != 0)
				{
					IntPtr intPtr2 = Class90.OpenProcess(2097151U, false, processById.Id);
					if (intPtr2 != IntPtr.Zero)
					{
						try
						{
							Class90.smethod_17(intPtr2, num, array3);
						}
						catch
						{
						}
						finally
						{
							Class90.CloseHandle(intPtr2);
						}
					}
				}
				if (!flag8)
				{
					try
					{
						if (Class90.smethod_30(processById, array3, num))
						{
							flag8 = true;
							stringBuilder_0.AppendLine("uuid OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag5)
				{
					try
					{
						if (Class90.smethod_31(processById, array3))
						{
							flag5 = true;
							stringBuilder_0.AppendLine("gai OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag6)
				{
					try
					{
						if (Class90.smethod_32(processById, array3))
						{
							flag6 = true;
							stringBuilder_0.AppendLine("gaa OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag7)
				{
					try
					{
						if (Class90.smethod_33(processById, array3))
						{
							flag7 = true;
							stringBuilder_0.AppendLine("git OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag4)
				{
					try
					{
						if (Class90.smethod_41(processById))
						{
							flag4 = true;
							stringBuilder_0.AppendLine("notice OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag3)
				{
					try
					{
						if (Class90.smethod_40(processById))
						{
							flag3 = true;
							stringBuilder_0.AppendLine("pluginExit OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag9)
				{
					try
					{
						if (Class90.smethod_37(processById))
						{
							flag9 = true;
							stringBuilder_0.AppendLine("hideGame OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag10)
				{
					try
					{
						if (Class90.smethod_10(processById, string_1))
						{
							flag10 = true;
							stringBuilder_0.AppendLine("pluginSnap OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag11 || num2 < 30 || (!flag5 && !flag8 && !flag4) || !flag9)
				{
					j++;
					continue;
				}
				stringBuilder_0.AppendLine("stable t=" + num3.ToString());
				break;
				IL_03B1:
				num2++;
				goto IL_03BC;
				IL_05AD:
				if (flag11 = Class90.smethod_20(processById))
				{
					goto IL_03B1;
				}
				num2 = 0;
				goto IL_03BC;
			}
			int num4 = 0;
			while (num4 < 100 && Class90.WaitForSingleObject(struct2.intptr_0, 100U) == 258U)
			{
				try
				{
					Class90.smethod_22(processById, array3);
					Class90.smethod_21(processById, array3);
					if (num != 0)
					{
						IntPtr intPtr3 = Class90.OpenProcess(2097151U, false, processById.Id);
						if (intPtr3 != IntPtr.Zero)
						{
							try
							{
								Class90.smethod_17(intPtr3, num, array3);
							}
							catch
							{
							}
							finally
							{
								Class90.CloseHandle(intPtr3);
							}
						}
					}
					if (!flag10 && Class90.smethod_10(processById, string_1))
					{
						flag10 = true;
						stringBuilder_0.AppendLine("pluginSnap OK t=late");
					}
					if (!flag9 && Class90.smethod_37(processById))
					{
						flag9 = true;
						stringBuilder_0.AppendLine("hideGame OK t=late");
					}
				}
				catch
				{
				}
				num4++;
			}
			if (!flag10)
			{
				try
				{
					if (Class90.smethod_10(processById, string_1))
					{
						flag10 = true;
						stringBuilder_0.AppendLine("pluginSnap OK t=final");
					}
				}
				catch
				{
				}
			}
			class91_0.bool_1 = Class90.smethod_20(processById);
			if (!class91_0.bool_1)
			{
				try
				{
					Class90.smethod_22(processById, array3);
					Class90.smethod_21(processById, array3);
				}
				catch
				{
				}
				class91_0.bool_1 = Class90.smethod_20(processById);
			}
			class91_0.bool_2 = flag9 || flag10 || flag3;
			class91_0.bool_6 = flag10;
			class91_0.bool_3 = flag4;
			class91_0.bool_4 = flag5;
			class91_0.bool_5 = flag8;
			class91_0.bool_0 = true;
			if (!class91_0.bool_1)
			{
				stringBuilder_0.AppendLine("warn mac hook chua song, mutex da patch");
			}
			if (!flag10)
			{
				stringBuilder_0.AppendLine("warn plugin chua patch");
			}
			stringBuilder_0.AppendLine(string.Concat(new string[]
			{
				"done ok=",
				class91_0.bool_0.ToString(),
				" mac=",
				class91_0.bool_1.ToString(),
				" hideGame=",
				flag9.ToString(),
				" pluginSnap=",
				flag10.ToString(),
				" gai=",
				flag5.ToString(),
				" gaa=",
				flag6.ToString(),
				" git=",
				flag7.ToString(),
				" uuid=",
				flag8.ToString(),
				" pluginExit=",
				flag3.ToString()
			}));
			stringBuilder_0.AppendLine("plugin mode=force-load+memory");
			@class.int_0 = struct2.int_0;
			@class.byte_0 = (byte[])array3.Clone();
			@class.string_0 = string_1;
			ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0));
			goto IL_08E5;
		}
		catch (Exception ex)
		{
			class91_0.string_2 = ex.Message;
			stringBuilder_0.AppendLine(ex.ToString());
			try
			{
				Class90.ResumeThread(struct2.intptr_1);
			}
			catch
			{
			}
		}
		finally
		{
			Class90.CloseHandle(struct2.intptr_1);
			Class90.CloseHandle(struct2.intptr_0);
		}
		IL_08E5:
		class91_0.string_1 = Class90.smethod_14(string_0, stringBuilder_0);
		return class91_0;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00034C5C File Offset: 0x00032E5C
	private static string smethod_14(string string_0, StringBuilder stringBuilder_0)
	{
		string text = stringBuilder_0.ToString();
		try
		{
			File.WriteAllText(Path.Combine(string.IsNullOrEmpty(string_0) ? "." : (Path.GetDirectoryName(string_0) ?? "."), "TnclGameLaunch.log"), text);
		}
		catch
		{
		}
		return text;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00037D20 File Offset: 0x00035F20
	public static byte[] smethod_15()
	{
		byte[] array = new byte[6];
		Class90.random_0.NextBytes(array);
		array[0] = (byte)((array[0] & 252) | 2);
		return array;
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00034CE4 File Offset: 0x00032EE4
	private static string smethod_16(byte[] byte_0)
	{
		return string.Format("{0:X2}-{1:X2}-{2:X2}-{3:X2}-{4:X2}-{5:X2}", new object[]
		{
			byte_0[0],
			byte_0[1],
			byte_0[2],
			byte_0[3],
			byte_0[4],
			byte_0[5]
		});
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00037D50 File Offset: 0x00035F50
	private static bool smethod_17(IntPtr intptr_0, int int_9, byte[] byte_0)
	{
		uint num;
		Class90.VirtualProtectEx(intptr_0, Class90.smethod_1(int_9), new UIntPtr((uint)byte_0.Length), 64U, out num);
		int num2;
		bool flag = Class90.WriteProcessMemory(intptr_0, Class90.smethod_1(int_9), byte_0, byte_0.Length, out num2) && num2 == byte_0.Length;
		uint num3;
		Class90.VirtualProtectEx(intptr_0, Class90.smethod_1(int_9), new UIntPtr((uint)byte_0.Length), num, out num3);
		return flag;
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00037DAC File Offset: 0x00035FAC
	private static byte[] smethod_18(IntPtr intptr_0, int int_9, int int_10)
	{
		byte[] array = new byte[int_10];
		int num;
		if (Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(int_9), array, int_10, out num))
		{
			if (num == int_10)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00037DDC File Offset: 0x00035FDC
	private static bool smethod_19(IntPtr intptr_0, int int_9)
	{
		string text = "A292F57D-84FD-4465-9A03-" + int_9.ToString("X12");
		if (text.Length > 36)
		{
			text = text.Substring(0, 36);
		}
		if (!Class90.smethod_17(intptr_0, 6232324, Encoding.ASCII.GetBytes(text)))
		{
			return false;
		}
		byte[] array = Class90.smethod_18(intptr_0, 4385227, 2);
		if (array != null)
		{
			if (array[0] == 117 || array[0] == 235)
			{
				return Class90.smethod_17(intptr_0, 4385227, new byte[] { 235, 123 }) && Class90.smethod_17(intptr_0, 4385245, new byte[] { byte.MaxValue }) && Class90.smethod_17(intptr_0, 4387436, new byte[] { 144, 144, 144, 144, 144, 144 });
			}
		}
		return false;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00037EAC File Offset: 0x000360AC
	private static bool smethod_20(Process process_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = Class90.smethod_18(intPtr, 4795680, 1);
			flag = array != null && array[0] == 233;
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00037F14 File Offset: 0x00036114
	private static void smethod_21(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Class90.smethod_17(intPtr, 6576016, byte_0);
			Class90.smethod_17(intPtr, 6576840, Encoding.ASCII.GetBytes(Class90.smethod_16(byte_0) + "\0"));
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00037F90 File Offset: 0x00036190
	private static bool smethod_22(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag2;
		try
		{
			bool flag = Class90.smethod_23(intPtr, byte_0);
			Class90.smethod_24(intPtr, byte_0);
			Class90.smethod_25(intPtr, byte_0);
			Class90.smethod_17(intPtr, 6576016, byte_0);
			Class90.smethod_17(intPtr, 6576840, Encoding.ASCII.GetBytes(Class90.smethod_16(byte_0) + "\0"));
			flag2 = flag;
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag2;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00038028 File Offset: 0x00036228
	private static bool smethod_23(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class90.smethod_18(intptr_0, 4795680, 5);
		if (array == null)
		{
			return false;
		}
		if (array[0] == 233)
		{
			return true;
		}
		if (array[0] != 85)
		{
			return false;
		}
		uint num = BitConverter.ToUInt32(byte_0, 0);
		uint num2 = (uint)((int)byte_0[4] | ((int)byte_0[5] << 8));
		IntPtr intPtr = Class90.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num3 = Class90.smethod_0(intPtr);
		List<byte> list = new List<byte>();
		list.AddRange(new byte[] { 139, 68, 36, 4, 199, 0 });
		list.AddRange(BitConverter.GetBytes(num));
		list.AddRange(new byte[] { 139, 68, 36, 8, 102, 199, 0 });
		list.AddRange(BitConverter.GetBytes((ushort)num2));
		list.AddRange(new byte[] { 199, 5 });
		list.AddRange(BitConverter.GetBytes(6576016));
		list.AddRange(BitConverter.GetBytes(num));
		list.AddRange(new byte[] { 102, 199, 5 });
		list.AddRange(BitConverter.GetBytes(6576020));
		list.AddRange(BitConverter.GetBytes((ushort)num2));
		list.AddRange(new byte[] { 51, 192, 195 });
		int num4;
		if (!Class90.WriteProcessMemory(intptr_0, intPtr, list.ToArray(), list.Count, out num4))
		{
			return false;
		}
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - 4795685).CopyTo(array3, 1);
		return Class90.smethod_17(intptr_0, 4795680, array3);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000381C0 File Offset: 0x000363C0
	private static void smethod_24(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class90.smethod_18(intptr_0, 4796032, 5);
		if (array != null && array[0] != 233)
		{
			if (array[0] == 85)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class90.smethod_16(byte_0) + "\0");
				IntPtr intPtr = Class90.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				int num = Class90.smethod_0(intPtr);
				byte[] array2 = new byte[32];
				Buffer.BlockCopy(bytes, 0, array2, 0, bytes.Length);
				int num2;
				if (!Class90.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
				{
					return;
				}
				uint num3 = BitConverter.ToUInt32(byte_0, 0);
				uint num4 = (uint)((int)byte_0[4] | ((int)byte_0[5] << 8));
				int num5 = num + 32;
				List<byte> list = new List<byte>();
				list.AddRange(new byte[] { 86, 87 });
				list.AddRange(new byte[] { 199, 5 });
				list.AddRange(BitConverter.GetBytes(6576016));
				list.AddRange(BitConverter.GetBytes(num3));
				list.AddRange(new byte[] { 102, 199, 5 });
				list.AddRange(BitConverter.GetBytes(6576020));
				list.AddRange(BitConverter.GetBytes((ushort)num4));
				list.Add(190);
				list.AddRange(BitConverter.GetBytes((uint)num));
				list.Add(191);
				list.AddRange(BitConverter.GetBytes(6576840U));
				list.AddRange(new byte[] { 185, 18, 0, 0, 0, 252, 243, 164, 95, 94 });
				list.Add(184);
				list.AddRange(BitConverter.GetBytes(6576840U));
				list.Add(195);
				if (!Class90.WriteProcessMemory(intptr_0, Class90.smethod_1(num5), list.ToArray(), list.Count, out num2))
				{
					return;
				}
				byte[] array3 = new byte[5];
				array3[0] = 233;
				byte[] array4 = array3;
				BitConverter.GetBytes(num5 - 4796037).CopyTo(array4, 1);
				Class90.smethod_17(intptr_0, 4796032, array4);
				return;
			}
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x000383E0 File Offset: 0x000365E0
	private static void smethod_25(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class90.smethod_18(intptr_0, 4796051, 7);
		if (array != null && array[0] == 15)
		{
			if (array[1] == 182)
			{
				IntPtr intPtr = Class90.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				uint num = (uint)Class90.smethod_0(intPtr);
				byte[] array2 = new byte[20];
				Class90.random_0.NextBytes(array2);
				Buffer.BlockCopy(byte_0, 0, array2, 0, 6);
				int num2;
				if (!Class90.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
				{
					return;
				}
				int[] array3 = new int[] { 0, 7, 14, 22, 30, 38 };
				for (int i = 0; i < 6; i++)
				{
					Class90.smethod_17(intptr_0, 4796051 + array3[i] + 3, BitConverter.GetBytes(num + (uint)i));
				}
				return;
			}
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000384B4 File Offset: 0x000366B4
	private static bool smethod_26(IntPtr intptr_0, string string_0, out int int_9, out int int_10)
	{
		int_9 = 0;
		int_10 = 0;
		IntPtr[] array = new IntPtr[1024];
		int num;
		bool flag;
		if (!(flag = Class90.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 1U)) && IntPtr.Size == 4)
		{
			flag = Class90.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 3U) || Class90.EnumProcessModules(intptr_0, array, array.Length * IntPtr.Size, out num);
		}
		if (!flag)
		{
			return false;
		}
		int num2 = num / IntPtr.Size;
		int num3 = 0;
		while (num3 < num2 && num3 < array.Length)
		{
			if (!(array[num3] == IntPtr.Zero))
			{
				long num4 = array[num3].ToInt64();
				if (num4 > 0L && num4 <= 4294967295L)
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					Class90.GetModuleBaseNameA(intptr_0, array[num3], stringBuilder, 260);
					Class90.Struct7 @struct;
					if (stringBuilder.ToString().Equals(string_0, StringComparison.OrdinalIgnoreCase) && Class90.GetModuleInformation(intptr_0, array[num3], out @struct, Marshal.SizeOf(typeof(Class90.Struct7))))
					{
						long num5 = @struct.intptr_0.ToInt64();
						if (num5 > 0L && num5 <= 4294967295L)
						{
							int_9 = (int)((uint)num5);
							int_10 = (int)@struct.uint_0;
							return true;
						}
					}
				}
			}
			num3++;
		}
		return false;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00038610 File Offset: 0x00036810
	private static IntPtr smethod_27(IntPtr intptr_0, string string_0, string string_1)
	{
		int num;
		int num2;
		if (!Class90.smethod_26(intptr_0, string_0, out num, out num2))
		{
			return IntPtr.Zero;
		}
		return Class90.smethod_28(intptr_0, Class90.smethod_1(num), string_1);
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00038640 File Offset: 0x00036840
	private static IntPtr smethod_28(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		int num = Class90.smethod_0(intptr_1);
		byte[] array = new byte[4096];
		int num2;
		if (!Class90.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num2))
		{
			return IntPtr.Zero;
		}
		int num3 = BitConverter.ToInt32(array, 60);
		if (num3 < 0 || num3 + 120 >= array.Length)
		{
			return IntPtr.Zero;
		}
		int num4 = BitConverter.ToInt32(array, num3 + 24 + 96);
		if (num4 == 0)
		{
			return IntPtr.Zero;
		}
		byte[] array2 = new byte[64];
		if (!Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num4), array2, array2.Length, out num2))
		{
			return IntPtr.Zero;
		}
		int num5 = BitConverter.ToInt32(array2, 24);
		int num6 = BitConverter.ToInt32(array2, 32);
		int num7 = BitConverter.ToInt32(array2, 36);
		int num8 = BitConverter.ToInt32(array2, 28);
		for (int i = 0; i < num5; i++)
		{
			byte[] array3 = new byte[4];
			if (Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num6 + i * 4), array3, 4, out num2))
			{
				int num9 = BitConverter.ToInt32(array3, 0);
				byte[] array4 = new byte[64];
				if (Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num9), array4, 64, out num2))
				{
					int num10 = Array.IndexOf<byte>(array4, 0);
					if (!(Encoding.ASCII.GetString(array4, 0, (num10 < 0) ? array4.Length : num10) != string_0))
					{
						byte[] array5 = new byte[2];
						if (!Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num7 + i * 2), array5, 2, out num2))
						{
							return IntPtr.Zero;
						}
						ushort num11 = BitConverter.ToUInt16(array5, 0);
						byte[] array6 = new byte[4];
						if (!Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num8 + (int)(num11 * 4)), array6, 4, out num2))
						{
							return IntPtr.Zero;
						}
						int num12 = BitConverter.ToInt32(array6, 0);
						if (((long)num12 & 2147483648L) != 0L)
						{
							return IntPtr.Zero;
						}
						string text = null;
						if (num12 >= num4 && num12 < num4 + 65536)
						{
							byte[] array7 = new byte[64];
							if (Class90.ReadProcessMemory(intptr_0, Class90.smethod_1(num + num12), array7, 64, out num2))
							{
								int num13 = Array.IndexOf<byte>(array7, 0);
								text = Encoding.ASCII.GetString(array7, 0, (num13 < 0) ? array7.Length : num13);
							}
						}
						if (text != null && text.IndexOf('.') > 0)
						{
							return IntPtr.Zero;
						}
						return Class90.smethod_1(num + num12);
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0003888C File Offset: 0x00036A8C
	private static bool smethod_29(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_1)
	{
		int num = Class90.smethod_0(intptr_1);
		int num2 = Class90.smethod_0(intptr_2);
		int num3 = Class90.smethod_0(intptr_3);
		byte[] array = new byte[10];
		Array.Copy(byte_0, array, 5);
		array[5] = 233;
		BitConverter.GetBytes(num + 5 - (num2 + 10)).CopyTo(array, 6);
		int num4;
		Class90.WriteProcessMemory(intptr_0, intptr_2, array, 10, out num4);
		Class90.WriteProcessMemory(intptr_0, intptr_3, byte_1, byte_1.Length, out num4);
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - (num + 5)).CopyTo(array3, 1);
		uint num5;
		Class90.VirtualProtectEx(intptr_0, intptr_1, new UIntPtr(8U), 64U, out num5);
		bool flag = Class90.WriteProcessMemory(intptr_0, intptr_1, array3, 5, out num4);
		Class90.VirtualProtectEx(intptr_0, intptr_1, new UIntPtr(8U), num5, out num5);
		return flag;
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00038950 File Offset: 0x00036B50
	private static bool smethod_30(Process process_0, byte[] byte_0, int int_9)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			IntPtr intPtr2 = Class90.smethod_27(intPtr, "rpcrt4.dll", "UuidCreateSequential");
			if (intPtr2 == IntPtr.Zero)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[5];
				int num;
				if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num))
				{
					if (num == 5)
					{
						if (array[0] == 233)
						{
							return true;
						}
						if (int_9 == 0)
						{
							IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 16U, 12288U, 64U);
							if (intPtr3 == IntPtr.Zero)
							{
								return false;
							}
							int_9 = Class90.smethod_0(intPtr3);
							Class90.smethod_17(intPtr, int_9, byte_0);
						}
						IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						IntPtr intPtr5 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
						if (!(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
						{
							int num2 = Class90.smethod_0(intPtr5);
							int num3 = Class90.smethod_0(intPtr4);
							List<byte> list = new List<byte>();
							list.AddRange(new byte[] { 85, 139, 236 });
							list.AddRange(new byte[] { byte.MaxValue, 117, 8 });
							int count = list.Count;
							list.Add(232);
							list.AddRange(BitConverter.GetBytes(0));
							list.AddRange(new byte[] { 139, 77, 8, 133, 201 });
							int count2 = list.Count;
							List<byte> list2 = list;
							byte[] array2 = new byte[2];
							array2[0] = 116;
							list2.AddRange(array2);
							list.AddRange(new byte[] { 161 });
							list.AddRange(BitConverter.GetBytes(int_9));
							list.AddRange(new byte[] { 137, 65, 10 });
							list.AddRange(new byte[] { 102, 161 });
							list.AddRange(BitConverter.GetBytes(int_9 + 4));
							list.AddRange(new byte[] { 102, 137, 65, 14 });
							int count3 = list.Count;
							list.AddRange(new byte[] { 51, 192, 93, 194, 4, 0 });
							byte[] array3 = list.ToArray();
							BitConverter.GetBytes(num3 - (num2 + count + 5)).CopyTo(array3, count + 1);
							array3[count2 + 1] = (byte)(count3 - (count2 + 2));
							return Class90.smethod_29(intPtr, intPtr2, array, intPtr4, intPtr5, array3);
						}
						return false;
					}
				}
				flag = false;
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00038C18 File Offset: 0x00036E18
	private static bool smethod_31(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class90.smethod_26(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class90.smethod_28(intPtr, Class90.smethod_1(num), "GetAdaptersInfo");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class90.smethod_0(intPtr4);
								int num7 = Class90.smethod_0(intPtr3);
								List<byte> list = new List<byte>();
								list.AddRange(new byte[] { 85, 139, 236, 86, 87 });
								list.AddRange(new byte[] { byte.MaxValue, 117, 12, byte.MaxValue, 117, 8 });
								int count = list.Count;
								list.Add(232);
								list.AddRange(BitConverter.GetBytes(0));
								list.AddRange(new byte[] { 133, 192 });
								int count2 = list.Count;
								List<byte> list2 = list;
								byte[] array2 = new byte[2];
								array2[0] = 117;
								list2.AddRange(array2);
								list.AddRange(new byte[] { 139, 117, 8 });
								int count3 = list.Count;
								list.AddRange(new byte[] { 133, 246 });
								int count4 = list.Count;
								List<byte> list3 = list;
								byte[] array3 = new byte[2];
								array3[0] = 116;
								list3.AddRange(array3);
								list.AddRange(new byte[] { 199, 134 });
								list.AddRange(BitConverter.GetBytes(400));
								list.AddRange(BitConverter.GetBytes(6));
								list.AddRange(new byte[] { 199, 134 });
								list.AddRange(BitConverter.GetBytes(404));
								list.AddRange(BitConverter.GetBytes(num4));
								list.AddRange(new byte[] { 102, 199, 134 });
								list.AddRange(BitConverter.GetBytes(408));
								list.AddRange(BitConverter.GetBytes(num5));
								list.AddRange(new byte[] { 139, 54 });
								int count5 = list.Count;
								list.Add(233);
								list.AddRange(BitConverter.GetBytes(0));
								int count6 = list.Count;
								list.AddRange(new byte[] { 51, 192 });
								int count7 = list.Count;
								list.AddRange(new byte[] { 95, 94, 93, 194, 8, 0 });
								byte[] array4 = list.ToArray();
								BitConverter.GetBytes(num7 - (num6 + count + 5)).CopyTo(array4, count + 1);
								array4[count2 + 1] = (byte)(count7 - (count2 + 2));
								array4[count4 + 1] = (byte)(count6 - (count4 + 2));
								BitConverter.GetBytes(num6 + count3 - (num6 + count5 + 5)).CopyTo(array4, count5 + 1);
								return Class90.smethod_29(intPtr, intPtr2, array, intPtr3, intPtr4, array4);
							}
							return false;
						}
					}
					flag = false;
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00038FF0 File Offset: 0x000371F0
	private static bool smethod_32(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class90.smethod_26(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class90.smethod_28(intPtr, Class90.smethod_1(num), "GetAdaptersAddresses");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class90.smethod_0(intPtr4);
								int num7 = Class90.smethod_0(intPtr3);
								List<byte> list = new List<byte>();
								list.AddRange(new byte[] { 85, 139, 236, 86, 87 });
								list.AddRange(new byte[]
								{
									byte.MaxValue, 117, 24, byte.MaxValue, 117, 20, byte.MaxValue, 117, 16, byte.MaxValue,
									117, 12, byte.MaxValue, 117, 8
								});
								int count = list.Count;
								list.Add(232);
								list.AddRange(BitConverter.GetBytes(0));
								list.AddRange(new byte[] { 133, 192 });
								int count2 = list.Count;
								List<byte> list2 = list;
								byte[] array2 = new byte[2];
								array2[0] = 117;
								list2.AddRange(array2);
								list.AddRange(new byte[] { 139, 117, 20 });
								int count3 = list.Count;
								list.AddRange(new byte[] { 133, 246 });
								int count4 = list.Count;
								List<byte> list3 = list;
								byte[] array3 = new byte[2];
								array3[0] = 116;
								list3.AddRange(array3);
								list.AddRange(new byte[] { 199, 70, 44 });
								list.AddRange(BitConverter.GetBytes(num4));
								list.AddRange(new byte[] { 102, 199, 70, 48 });
								list.AddRange(BitConverter.GetBytes(num5));
								list.AddRange(new byte[] { 131, 126, 52, 0 });
								int count5 = list.Count;
								List<byte> list4 = list;
								byte[] array4 = new byte[2];
								array4[0] = 116;
								list4.AddRange(array4);
								list.AddRange(new byte[] { 199, 70, 52 });
								list.AddRange(BitConverter.GetBytes(6));
								int count6 = list.Count;
								list.AddRange(new byte[] { 139, 118, 8 });
								int count7 = list.Count;
								list.Add(233);
								list.AddRange(BitConverter.GetBytes(0));
								int count8 = list.Count;
								list.AddRange(new byte[] { 51, 192 });
								int count9 = list.Count;
								list.AddRange(new byte[] { 95, 94, 93, 194, 20, 0 });
								byte[] array5 = list.ToArray();
								BitConverter.GetBytes(num7 - (num6 + count + 5)).CopyTo(array5, count + 1);
								array5[count2 + 1] = (byte)(count9 - (count2 + 2));
								array5[count4 + 1] = (byte)(count8 - (count4 + 2));
								array5[count5 + 1] = (byte)(count6 - (count5 + 2));
								BitConverter.GetBytes(num6 + count3 - (num6 + count7 + 5)).CopyTo(array5, count7 + 1);
								return Class90.smethod_29(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
							}
							return false;
						}
					}
					flag = false;
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x000393D4 File Offset: 0x000375D4
	private static bool smethod_33(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class90.smethod_26(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class90.smethod_28(intPtr, Class90.smethod_1(num), "GetIfTable");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class90.smethod_0(intPtr4);
								int num7 = Class90.smethod_0(intPtr3);
								List<byte> list = new List<byte>();
								list.AddRange(new byte[] { 85, 139, 236, 86, 87 });
								list.AddRange(new byte[] { byte.MaxValue, 117, 16, byte.MaxValue, 117, 12, byte.MaxValue, 117, 8 });
								int count = list.Count;
								list.Add(232);
								list.AddRange(BitConverter.GetBytes(0));
								list.AddRange(new byte[] { 133, 192 });
								int count2 = list.Count;
								List<byte> list2 = list;
								byte[] array2 = new byte[2];
								array2[0] = 117;
								list2.AddRange(array2);
								list.AddRange(new byte[] { 139, 117, 8, 133, 246 });
								int count3 = list.Count;
								List<byte> list3 = list;
								byte[] array3 = new byte[2];
								array3[0] = 116;
								list3.AddRange(array3);
								list.AddRange(new byte[] { 139, 62, 131, 198, 4 });
								int count4 = list.Count;
								list.AddRange(new byte[] { 133, byte.MaxValue });
								int count5 = list.Count;
								List<byte> list4 = list;
								byte[] array4 = new byte[2];
								array4[0] = 116;
								list4.AddRange(array4);
								list.AddRange(new byte[] { 199, 134 });
								list.AddRange(BitConverter.GetBytes(528));
								list.AddRange(BitConverter.GetBytes(6));
								list.AddRange(new byte[] { 199, 134 });
								list.AddRange(BitConverter.GetBytes(532));
								list.AddRange(BitConverter.GetBytes(num4));
								list.AddRange(new byte[] { 102, 199, 134 });
								list.AddRange(BitConverter.GetBytes(536));
								list.AddRange(BitConverter.GetBytes(num5));
								list.AddRange(new byte[] { 129, 198 });
								list.AddRange(BitConverter.GetBytes(860));
								list.Add(79);
								int count6 = list.Count;
								list.Add(233);
								list.AddRange(BitConverter.GetBytes(0));
								int count7 = list.Count;
								list.AddRange(new byte[] { 51, 192 });
								int count8 = list.Count;
								list.AddRange(new byte[] { 95, 94, 93, 194, 12, 0 });
								byte[] array5 = list.ToArray();
								BitConverter.GetBytes(num7 - (num6 + count + 5)).CopyTo(array5, count + 1);
								array5[count2 + 1] = (byte)(count8 - (count2 + 2));
								array5[count3 + 1] = (byte)(count7 - (count3 + 2));
								array5[count5 + 1] = (byte)(count7 - (count5 + 2));
								BitConverter.GetBytes(num6 + count4 - (num6 + count6 + 5)).CopyTo(array5, count6 + 1);
								return Class90.smethod_29(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
							}
							return false;
						}
					}
					flag = false;
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0003980C File Offset: 0x00037A0C
	public static bool smethod_34(int int_9, int int_10)
	{
		Process processById;
		try
		{
			processById = Process.GetProcessById(int_9);
		}
		catch
		{
			return false;
		}
		string text = ".";
		try
		{
			text = Path.GetDirectoryName(processById.MainModule.FileName) ?? ".";
		}
		catch
		{
		}
		int num = Math.Max(1, int_10 / 200);
		for (int i = 0; i < num; i++)
		{
			try
			{
				processById.Refresh();
				if (processById.HasExited)
				{
					return false;
				}
				if (Class90.smethod_10(processById, text))
				{
					try
					{
						Class90.smethod_40(processById);
					}
					catch
					{
					}
					return true;
				}
			}
			catch
			{
			}
			Thread.Sleep(200);
		}
		return false;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x000398E0 File Offset: 0x00037AE0
	private static bool smethod_35(Process process_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class90.smethod_26(intPtr, "Plugin.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[] { 51, 192, 144, 144, 144 };
				byte[] array2 = Class90.smethod_18(intPtr, num + 19821, 5);
				if (array2 == null)
				{
					flag = false;
				}
				else
				{
					bool flag2;
					if (array2[0] == 51)
					{
						if (array2[1] == 192)
						{
							flag2 = true;
							goto IL_008F;
						}
					}
					flag2 = Class90.smethod_17(intPtr, num + 19821, array);
					IL_008F:
					bool flag3 = flag2;
					bool flag4 = Class90.smethod_17(intPtr, num + 19860, array);
					bool flag5 = Class90.smethod_17(intPtr, num + 19888, array);
					byte[] array3 = Class90.smethod_18(intPtr, num + 13043, 3);
					bool flag6;
					if (array3 != null)
					{
						if (array3[0] == 131 && array3[1] == 249)
						{
							if (array3[2] == 255)
							{
								flag6 = true;
								goto IL_010C;
							}
						}
						flag6 = Class90.smethod_17(intPtr, num + 13043, new byte[] { 131, 249, byte.MaxValue });
					}
					else
					{
						flag6 = false;
					}
					IL_010C:
					bool flag7 = flag6;
					flag = flag3 && flag4 && flag5 && flag7;
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00039A24 File Offset: 0x00037C24
	private static bool smethod_36(Process process_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			Class90.Class94 @class = new Class90.Class94();
			IntPtr intPtr2 = Class90.smethod_27(intPtr, "kernel32.dll", "GetModuleHandleA");
			IntPtr intPtr3 = Class90.smethod_27(intPtr, "kernel32.dll", "Sleep");
			IntPtr intPtr4 = Class90.smethod_27(intPtr, "kernel32.dll", "VirtualProtect");
			if (!(intPtr2 == IntPtr.Zero) && !(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
			{
				IntPtr intPtr5 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 512U, 12288U, 64U);
				if (intPtr5 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					int num2;
					int num = (num2 = Class90.smethod_0(intPtr5));
					int num3 = num + 20;
					int num4 = num + 32;
					byte[] bytes = Encoding.ASCII.GetBytes("Plugin.dll\0");
					int num5;
					if (!Class90.WriteProcessMemory(intPtr, intPtr5, bytes, bytes.Length, out num5))
					{
						flag = false;
					}
					else
					{
						@class.list_0 = new List<byte>();
						@class.list_0.Add(96);
						@class.list_0.Add(187);
						@class.list_0.AddRange(BitConverter.GetBytes(1800));
						int count = @class.list_0.Count;
						@class.list_0.Add(104);
						@class.list_0.AddRange(BitConverter.GetBytes((uint)num2));
						@class.list_0.Add(184);
						@class.list_0.AddRange(BitConverter.GetBytes((uint)Class90.smethod_0(intPtr2)));
						@class.list_0.AddRange(new byte[] { byte.MaxValue, 208 });
						@class.list_0.AddRange(new byte[] { 133, 192 });
						int count2 = @class.list_0.Count;
						List<byte> list_ = @class.list_0;
						byte[] array = new byte[2];
						array[0] = 116;
						list_.AddRange(array);
						@class.list_0.AddRange(new byte[] { 137, 198 });
						@class.list_0.AddRange(new byte[] { 141, 134 });
						@class.list_0.AddRange(BitConverter.GetBytes(13043));
						@class.list_0.Add(104);
						@class.list_0.AddRange(BitConverter.GetBytes((uint)num3));
						@class.list_0.AddRange(new byte[] { 106, 64 });
						@class.list_0.Add(104);
						@class.list_0.AddRange(BitConverter.GetBytes(512));
						@class.list_0.Add(80);
						@class.list_0.Add(184);
						@class.list_0.AddRange(BitConverter.GetBytes((uint)Class90.smethod_0(intPtr4)));
						@class.list_0.AddRange(new byte[] { byte.MaxValue, 208 });
						Action<int, byte[]> action = new Action<int, byte[]>(@class.method_0);
						action(19821, new byte[] { 51, 192, 144, 144, 144 });
						action(19860, new byte[] { 51, 192, 144, 144, 144 });
						action(19888, new byte[] { 51, 192, 144, 144, 144 });
						action(13043, new byte[] { 131, 249, byte.MaxValue });
						@class.list_0.AddRange(new byte[] { 97, 51, 192, 195 });
						int count3 = @class.list_0.Count;
						@class.list_0[count2 + 1] = (byte)(count3 - (count2 + 2));
						@class.list_0.Add(104);
						@class.list_0.AddRange(BitConverter.GetBytes(200));
						@class.list_0.Add(184);
						@class.list_0.AddRange(BitConverter.GetBytes((uint)Class90.smethod_0(intPtr3)));
						@class.list_0.AddRange(new byte[] { byte.MaxValue, 208 });
						@class.list_0.Add(75);
						@class.list_0.AddRange(new byte[] { 133, 219 });
						int count4 = @class.list_0.Count;
						List<byte> list_2 = @class.list_0;
						byte[] array2 = new byte[2];
						array2[0] = 116;
						list_2.AddRange(array2);
						int count5 = @class.list_0.Count;
						@class.list_0.Add(233);
						@class.list_0.AddRange(BitConverter.GetBytes(0));
						int count6 = @class.list_0.Count;
						@class.list_0.AddRange(new byte[] { 97, 51, 192, 195 });
						byte[] array3 = @class.list_0.ToArray();
						array3[count2 + 1] = (byte)(count3 - (count2 + 2));
						array3[count4 + 1] = (byte)(count6 - (count4 + 2));
						BitConverter.GetBytes(count - (count5 + 5)).CopyTo(array3, count5 + 1);
						if (!Class90.WriteProcessMemory(intPtr, Class90.smethod_1(num4), array3, array3.Length, out num5))
						{
							flag = false;
						}
						else
						{
							IntPtr intPtr6 = Class90.CreateRemoteThread(intPtr, IntPtr.Zero, 0U, Class90.smethod_1(num4), IntPtr.Zero, 0U, IntPtr.Zero);
							if (intPtr6 == IntPtr.Zero)
							{
								flag = false;
							}
							else
							{
								Class90.CloseHandle(intPtr6);
								flag = true;
							}
						}
					}
				}
			}
			else
			{
				flag = false;
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00007D78 File Offset: 0x00005F78
	private static bool smethod_37(Process process_0)
	{
		return Class90.smethod_38(process_0, "Process32NextW");
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00039FC8 File Offset: 0x000381C8
	private static bool smethod_38(Process process_0, string string_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			IntPtr intPtr2 = Class90.smethod_27(intPtr, "kernel32.dll", string_0);
			if (intPtr2 == IntPtr.Zero)
			{
				intPtr2 = Class90.smethod_27(intPtr, "KERNELBASE.dll", string_0);
			}
			if (intPtr2 == IntPtr.Zero)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[5];
				int num;
				if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num))
				{
					if (num == 5)
					{
						if (array[0] == 233)
						{
							return true;
						}
						IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
						IntPtr intPtr5 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
						{
							byte[] bytes = Encoding.Unicode.GetBytes("Game.exe\0");
							int num2;
							Class90.WriteProcessMemory(intPtr, intPtr5, bytes, bytes.Length, out num2);
							int num3 = Class90.smethod_0(intPtr4);
							int num4 = Class90.smethod_0(intPtr3);
							int num5 = Class90.smethod_0(intPtr5);
							int id = process_0.Id;
							List<byte> list = new List<byte>();
							list.AddRange(new byte[] { 85, 139, 236, 83, 86, 87 });
							int count = list.Count;
							list.AddRange(new byte[] { byte.MaxValue, 117, 12, byte.MaxValue, 117, 8 });
							int count2 = list.Count;
							list.Add(232);
							list.AddRange(BitConverter.GetBytes(0));
							list.AddRange(new byte[] { 133, 192 });
							int count3 = list.Count;
							List<byte> list2 = list;
							byte[] array2 = new byte[2];
							array2[0] = 116;
							list2.AddRange(array2);
							list.AddRange(new byte[] { 139, 117, 12, 139, 70, 8 });
							list.AddRange(new byte[] { 61 });
							list.AddRange(BitConverter.GetBytes(id));
							int count4 = list.Count;
							List<byte> list3 = list;
							byte[] array3 = new byte[2];
							array3[0] = 116;
							list3.AddRange(array3);
							list.AddRange(new byte[] { 141, 126, 44, 190 });
							list.AddRange(BitConverter.GetBytes((uint)num5));
							list.AddRange(new byte[] { 102, 139, 15, 102, 59, 14 });
							int count5 = list.Count;
							List<byte> list4 = list;
							byte[] array4 = new byte[2];
							array4[0] = 117;
							list4.AddRange(array4);
							list.AddRange(new byte[] { 102, 139, 79, 2, 102, 59, 78, 2 });
							int count6 = list.Count;
							List<byte> list5 = list;
							byte[] array5 = new byte[2];
							array5[0] = 117;
							list5.AddRange(array5);
							list.AddRange(new byte[] { 102, 139, 79, 4, 102, 59, 78, 4 });
							int count7 = list.Count;
							List<byte> list6 = list;
							byte[] array6 = new byte[2];
							array6[0] = 117;
							list6.AddRange(array6);
							list.AddRange(new byte[] { 102, 139, 79, 6, 102, 59, 78, 6 });
							int count8 = list.Count;
							List<byte> list7 = list;
							byte[] array7 = new byte[2];
							array7[0] = 117;
							list7.AddRange(array7);
							list.AddRange(new byte[] { 102, 139, 79, 8, 102, 59, 78, 8 });
							int count9 = list.Count;
							List<byte> list8 = list;
							byte[] array8 = new byte[2];
							array8[0] = 117;
							list8.AddRange(array8);
							list.AddRange(new byte[] { 102, 139, 79, 10, 102, 59, 78, 10 });
							int count10 = list.Count;
							List<byte> list9 = list;
							byte[] array9 = new byte[2];
							array9[0] = 117;
							list9.AddRange(array9);
							list.AddRange(new byte[] { 102, 139, 79, 12, 102, 59, 78, 12 });
							int count11 = list.Count;
							List<byte> list10 = list;
							byte[] array10 = new byte[2];
							array10[0] = 117;
							list10.AddRange(array10);
							int count12 = list.Count;
							list.Add(233);
							list.AddRange(BitConverter.GetBytes(0));
							int count13 = list.Count;
							List<byte> list11 = list;
							byte[] array11 = new byte[5];
							array11[0] = 184;
							array11[1] = 1;
							list11.AddRange(array11);
							int count14 = list.Count;
							list.AddRange(new byte[] { 95, 94, 91, 93, 194, 8, 0 });
							byte[] array12 = list.ToArray();
							BitConverter.GetBytes(num4 - (num3 + count2 + 5)).CopyTo(array12, count2 + 1);
							array12[count3 + 1] = (byte)(count14 - (count3 + 2));
							array12[count4 + 1] = (byte)(count13 - (count4 + 2));
							array12[count5 + 1] = (byte)(count13 - (count5 + 2));
							array12[count6 + 1] = (byte)(count13 - (count6 + 2));
							array12[count7 + 1] = (byte)(count13 - (count7 + 2));
							array12[count8 + 1] = (byte)(count13 - (count8 + 2));
							array12[count9 + 1] = (byte)(count13 - (count9 + 2));
							array12[count10 + 1] = (byte)(count13 - (count10 + 2));
							array12[count11 + 1] = (byte)(count13 - (count11 + 2));
							BitConverter.GetBytes(count - (count12 + 5)).CopyTo(array12, count12 + 1);
							return Class90.smethod_29(intPtr, intPtr2, array, intPtr3, intPtr4, array12);
						}
						return false;
					}
				}
				flag = false;
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0003A504 File Offset: 0x00038704
	private static bool smethod_39(IntPtr intptr_0, out int int_9, out int int_10)
	{
		foreach (string text in new string[] { "Plugin_ClientManager.dll", "Plugin.dll", "Plugin_RenderCore.dll" })
		{
			if (Class90.smethod_26(intptr_0, text, out int_9, out int_10) && int_10 > 0)
			{
				return true;
			}
		}
		int_9 = 0;
		int_10 = 0;
		IntPtr[] array2 = new IntPtr[1024];
		int num;
		bool flag;
		if (!(flag = Class90.EnumProcessModulesEx(intptr_0, array2, array2.Length * IntPtr.Size, out num, 1U)) && IntPtr.Size == 4)
		{
			flag = Class90.EnumProcessModules(intptr_0, array2, array2.Length * IntPtr.Size, out num);
		}
		if (!flag)
		{
			return false;
		}
		int num2 = num / IntPtr.Size;
		int num3 = 0;
		while (num3 < num2 && num3 < array2.Length)
		{
			if (!(array2[num3] == IntPtr.Zero))
			{
				long num4 = array2[num3].ToInt64();
				if (num4 > 0L && num4 <= 4294967295L)
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					Class90.GetModuleBaseNameA(intptr_0, array2[num3], stringBuilder, 260);
					string text2 = stringBuilder.ToString();
					Class90.Struct7 @struct;
					if (text2.StartsWith("Plugin", StringComparison.OrdinalIgnoreCase) && text2.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) && text2.IndexOf("Particle", StringComparison.OrdinalIgnoreCase) < 0 && text2.IndexOf("Octree", StringComparison.OrdinalIgnoreCase) < 0 && text2.IndexOf("BSP", StringComparison.OrdinalIgnoreCase) < 0 && text2.IndexOf("CgProgram", StringComparison.OrdinalIgnoreCase) < 0 && text2.IndexOf("Scorpio", StringComparison.OrdinalIgnoreCase) < 0 && Class90.GetModuleInformation(intptr_0, array2[num3], out @struct, Marshal.SizeOf(typeof(Class90.Struct7))))
					{
						long num5 = @struct.intptr_0.ToInt64();
						if (num5 > 0L && num5 <= 4294967295L)
						{
							int_9 = (int)((uint)num5);
							int_10 = (int)@struct.uint_0;
							return true;
						}
					}
				}
			}
			num3++;
		}
		return false;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0003A70C File Offset: 0x0003890C
	private static bool smethod_40(Process process_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class90.smethod_39(intPtr, out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class90.smethod_27(intPtr, "kernel32.dll", "ExitProcess");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 64U, 12288U, 64U);
							IntPtr intPtr5 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 8U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
							{
								int num4 = Class90.smethod_0(intPtr3);
								int num5 = Class90.smethod_0(intPtr4);
								int num6 = Class90.smethod_0(intPtr5);
								int num7 = Class90.smethod_0(intPtr2);
								int num8;
								Class90.WriteProcessMemory(intPtr, intPtr5, BitConverter.GetBytes(num), 4, out num8);
								Class90.WriteProcessMemory(intPtr, Class90.smethod_1(num6 + 4), BitConverter.GetBytes(num + num2), 4, out num8);
								byte[] array2 = new byte[10];
								Array.Copy(array, array2, 5);
								array2[5] = 233;
								BitConverter.GetBytes(num7 + 5 - (num4 + 10)).CopyTo(array2, 6);
								Class90.WriteProcessMemory(intPtr, intPtr3, array2, 10, out num8);
								byte[] array3 = new byte[64];
								array3[0] = 96;
								array3[1] = 139;
								array3[2] = 68;
								array3[3] = 36;
								array3[4] = 32;
								array3[5] = 59;
								array3[6] = 5;
								BitConverter.GetBytes(num6).CopyTo(array3, 7);
								array3[11] = 114;
								array3[12] = 12;
								array3[13] = 59;
								array3[14] = 5;
								BitConverter.GetBytes(num6 + 4).CopyTo(array3, 15);
								array3[19] = 115;
								array3[20] = 4;
								array3[21] = 97;
								array3[22] = 194;
								array3[23] = 4;
								array3[24] = 0;
								array3[25] = 97;
								array3[26] = 233;
								BitConverter.GetBytes(num4 - (num5 + 27 + 4)).CopyTo(array3, 27);
								Class90.WriteProcessMemory(intPtr, intPtr4, array3, 31, out num8);
								byte[] array4 = new byte[5];
								array4[0] = 233;
								byte[] array5 = array4;
								BitConverter.GetBytes(num5 - (num7 + 5)).CopyTo(array5, 1);
								uint num9;
								Class90.VirtualProtectEx(intPtr, intPtr2, new UIntPtr(8U), 64U, out num9);
								bool flag2 = Class90.WriteProcessMemory(intPtr, intPtr2, array5, 5, out num8);
								Class90.VirtualProtectEx(intPtr, intPtr2, new UIntPtr(8U), num9, out num9);
								return flag2;
							}
							return false;
						}
					}
					flag = false;
				}
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0003AA10 File Offset: 0x00038C10
	private static bool smethod_41(Process process_0)
	{
		IntPtr intPtr = Class90.OpenProcess(2097151U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			IntPtr intPtr2 = Class90.smethod_27(intPtr, "user32.dll", "MessageBoxW");
			if (intPtr2 == IntPtr.Zero)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[5];
				int num;
				if (Class90.ReadProcessMemory(intPtr, intPtr2, array, 5, out num))
				{
					if (num == 5)
					{
						if (array[0] == 233)
						{
							return true;
						}
						IntPtr intPtr3 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						IntPtr intPtr4 = Class90.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
						if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
						{
							int num2 = Class90.smethod_0(intPtr3);
							int num3 = Class90.smethod_0(intPtr4);
							int num4 = Class90.smethod_0(intPtr2);
							byte[] array2 = new byte[10];
							Array.Copy(array, array2, 5);
							array2[5] = 233;
							BitConverter.GetBytes(num4 + 5 - (num2 + 10)).CopyTo(array2, 6);
							int num5;
							Class90.WriteProcessMemory(intPtr, intPtr3, array2, 10, out num5);
							List<byte> list = new List<byte>();
							list.AddRange(new byte[] { 85, 139, 236, 139, 69, 16, 133, 192 });
							int count = list.Count;
							List<byte> list2 = list;
							byte[] array3 = new byte[2];
							array3[0] = 116;
							list2.AddRange(array3);
							list.AddRange(new byte[] { 102, 129, 56, 84, 0 });
							int count2 = list.Count;
							List<byte> list3 = list;
							byte[] array4 = new byte[2];
							array4[0] = 117;
							list3.AddRange(array4);
							list.AddRange(new byte[] { 102, 129, 120, 2, 78, 0 });
							int count3 = list.Count;
							List<byte> list4 = list;
							byte[] array5 = new byte[2];
							array5[0] = 117;
							list4.AddRange(array5);
							list.AddRange(new byte[] { 102, 129, 120, 4, 67, 0 });
							int count4 = list.Count;
							List<byte> list5 = list;
							byte[] array6 = new byte[2];
							array6[0] = 117;
							list5.AddRange(array6);
							list.AddRange(new byte[] { 102, 129, 120, 6, 76, 0 });
							int count5 = list.Count;
							List<byte> list6 = list;
							byte[] array7 = new byte[2];
							array7[0] = 117;
							list6.AddRange(array7);
							list.AddRange(new byte[] { 184, 1, 0, 0, 0, 93, 194, 16, 0 });
							int count6 = list.Count;
							list.AddRange(new byte[]
							{
								byte.MaxValue, 117, 20, byte.MaxValue, 117, 16, byte.MaxValue, 117, 12, byte.MaxValue,
								117, 8
							});
							int count7 = list.Count;
							list.Add(232);
							list.AddRange(BitConverter.GetBytes(0));
							list.AddRange(new byte[] { 93, 194, 16, 0 });
							byte[] array8 = list.ToArray();
							array8[count + 1] = (byte)(count6 - (count + 2));
							array8[count2 + 1] = (byte)(count6 - (count2 + 2));
							array8[count3 + 1] = (byte)(count6 - (count3 + 2));
							array8[count4 + 1] = (byte)(count6 - (count4 + 2));
							array8[count5 + 1] = (byte)(count6 - (count5 + 2));
							BitConverter.GetBytes(num2 - (num3 + count7 + 5)).CopyTo(array8, count7 + 1);
							Class90.WriteProcessMemory(intPtr, intPtr4, array8, array8.Length, out num5);
							byte[] array9 = new byte[5];
							array9[0] = 233;
							byte[] array10 = array9;
							BitConverter.GetBytes(num3 - (num4 + 5)).CopyTo(array10, 1);
							uint num6;
							Class90.VirtualProtectEx(intPtr, intPtr2, new UIntPtr(8U), 64U, out num6);
							bool flag2 = Class90.WriteProcessMemory(intPtr, intPtr2, array10, 5, out num5);
							Class90.VirtualProtectEx(intPtr, intPtr2, new UIntPtr(8U), num6, out num6);
							return flag2;
						}
						return false;
					}
				}
				flag = false;
			}
		}
		finally
		{
			Class90.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x040003D9 RID: 985
	private const uint uint_0 = 4U;

	// Token: 0x040003DA RID: 986
	private const uint uint_1 = 2097151U;

	// Token: 0x040003DB RID: 987
	private const uint uint_2 = 4096U;

	// Token: 0x040003DC RID: 988
	private const uint uint_3 = 8192U;

	// Token: 0x040003DD RID: 989
	private const uint uint_4 = 64U;

	// Token: 0x040003DE RID: 990
	private const uint uint_5 = 258U;

	// Token: 0x040003DF RID: 991
	private const uint uint_6 = 1U;

	// Token: 0x040003E0 RID: 992
	private const uint uint_7 = 3U;

	// Token: 0x040003E1 RID: 993
	private const int int_0 = 6232324;

	// Token: 0x040003E2 RID: 994
	private const int int_1 = 4385227;

	// Token: 0x040003E3 RID: 995
	private const int int_2 = 4385245;

	// Token: 0x040003E4 RID: 996
	private const int int_3 = 4387436;

	// Token: 0x040003E5 RID: 997
	private const int int_4 = 4795680;

	// Token: 0x040003E6 RID: 998
	private const int int_5 = 4796032;

	// Token: 0x040003E7 RID: 999
	private const int int_6 = 4796051;

	// Token: 0x040003E8 RID: 1000
	private const int int_7 = 6576016;

	// Token: 0x040003E9 RID: 1001
	private const int int_8 = 6576840;

	// Token: 0x040003EA RID: 1002
	private static readonly Random random_0 = new Random();

	// Token: 0x020000A6 RID: 166
	public sealed class Class91
	{
		// Token: 0x040003EB RID: 1003
		public bool bool_0;

		// Token: 0x040003EC RID: 1004
		public int int_0;

		// Token: 0x040003ED RID: 1005
		public byte[] byte_0;

		// Token: 0x040003EE RID: 1006
		public string string_0;

		// Token: 0x040003EF RID: 1007
		public bool bool_1;

		// Token: 0x040003F0 RID: 1008
		public bool bool_2;

		// Token: 0x040003F1 RID: 1009
		public bool bool_3;

		// Token: 0x040003F2 RID: 1010
		public bool bool_4;

		// Token: 0x040003F3 RID: 1011
		public bool bool_5;

		// Token: 0x040003F4 RID: 1012
		public bool bool_6;

		// Token: 0x040003F5 RID: 1013
		public string string_1;

		// Token: 0x040003F6 RID: 1014
		public string string_2;
	}

	// Token: 0x020000A7 RID: 167
	private struct Struct5
	{
		// Token: 0x040003F7 RID: 1015
		public int int_0;

		// Token: 0x040003F8 RID: 1016
		public IntPtr intptr_0;

		// Token: 0x040003F9 RID: 1017
		public IntPtr intptr_1;

		// Token: 0x040003FA RID: 1018
		public IntPtr intptr_2;

		// Token: 0x040003FB RID: 1019
		public int int_1;

		// Token: 0x040003FC RID: 1020
		public int int_2;

		// Token: 0x040003FD RID: 1021
		public int int_3;

		// Token: 0x040003FE RID: 1022
		public int int_4;

		// Token: 0x040003FF RID: 1023
		public int int_5;

		// Token: 0x04000400 RID: 1024
		public int int_6;

		// Token: 0x04000401 RID: 1025
		public int int_7;

		// Token: 0x04000402 RID: 1026
		public int int_8;

		// Token: 0x04000403 RID: 1027
		public short short_0;

		// Token: 0x04000404 RID: 1028
		public short short_1;

		// Token: 0x04000405 RID: 1029
		public IntPtr intptr_3;

		// Token: 0x04000406 RID: 1030
		public IntPtr intptr_4;

		// Token: 0x04000407 RID: 1031
		public IntPtr intptr_5;

		// Token: 0x04000408 RID: 1032
		public IntPtr intptr_6;
	}

	// Token: 0x020000A8 RID: 168
	private struct Struct6
	{
		// Token: 0x04000409 RID: 1033
		public IntPtr intptr_0;

		// Token: 0x0400040A RID: 1034
		public IntPtr intptr_1;

		// Token: 0x0400040B RID: 1035
		public int int_0;

		// Token: 0x0400040C RID: 1036
		public int int_1;
	}

	// Token: 0x020000A9 RID: 169
	private struct Struct7
	{
		// Token: 0x0400040D RID: 1037
		public IntPtr intptr_0;

		// Token: 0x0400040E RID: 1038
		public uint uint_0;

		// Token: 0x0400040F RID: 1039
		public IntPtr intptr_1;
	}

	// Token: 0x020000AA RID: 170
	[CompilerGenerated]
	private sealed class Class92
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x0003ADCC File Offset: 0x00038FCC
		internal void method_0()
		{
			bool flag = Class90.smethod_34(this.int_0, 300000);
			try
			{
				File.AppendAllText(Path.Combine(this.string_0, "TnclPluginWatch.log"), string.Concat(new string[]
				{
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
					" pid=",
					this.int_0.ToString(),
					" pluginMem=",
					flag.ToString(),
					Environment.NewLine
				}));
			}
			catch
			{
			}
		}

		// Token: 0x04000410 RID: 1040
		public int int_0;

		// Token: 0x04000411 RID: 1041
		public string string_0;
	}

	// Token: 0x020000AB RID: 171
	[CompilerGenerated]
	private sealed class Class93
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x00007D91 File Offset: 0x00005F91
		internal void method_0(object object_0)
		{
			Class90.smethod_9(this.int_0, this.byte_0, this.string_0);
		}

		// Token: 0x04000412 RID: 1042
		public int int_0;

		// Token: 0x04000413 RID: 1043
		public byte[] byte_0;

		// Token: 0x04000414 RID: 1044
		public string string_0;
	}

	// Token: 0x020000AC RID: 172
	[CompilerGenerated]
	private sealed class Class94
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x0003AE64 File Offset: 0x00039064
		internal void method_0(int int_0, byte[] byte_0)
		{
			this.list_0.AddRange(new byte[] { 141, 134 });
			this.list_0.AddRange(BitConverter.GetBytes(int_0));
			for (int i = 0; i < byte_0.Length; i++)
			{
				this.list_0.AddRange(new byte[]
				{
					198,
					64,
					(byte)i,
					byte_0[i]
				});
			}
		}

		// Token: 0x04000415 RID: 1045
		public List<byte> list_0;
	}
}
