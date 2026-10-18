using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020000A0 RID: 160
internal class Class88
{
	// Token: 0x0600070F RID: 1807
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_8, IntPtr intptr_2, string string_2, ref Class88.Struct2 struct2_0, out Class88.Struct3 struct3_0);

	// Token: 0x06000710 RID: 1808
	[DllImport("kernel32.dll")]
	private static extern uint ResumeThread(IntPtr intptr_0);

	// Token: 0x06000711 RID: 1809
	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000712 RID: 1810
	[DllImport("kernel32.dll")]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_8);

	// Token: 0x06000713 RID: 1811
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_8, bool bool_0, int int_9);

	// Token: 0x06000714 RID: 1812
	[DllImport("kernel32.dll")]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, uint uint_9, uint uint_10);

	// Token: 0x06000715 RID: 1813
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_9, out int int_10);

	// Token: 0x06000716 RID: 1814
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_9, out int int_10);

	// Token: 0x06000717 RID: 1815
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, uint uint_9, out uint uint_10);

	// Token: 0x06000718 RID: 1816
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_9, out int int_10, uint uint_8);

	// Token: 0x06000719 RID: 1817
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModules(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_9, out int int_10);

	// Token: 0x0600071A RID: 1818
	[DllImport("psapi.dll", CharSet = CharSet.Ansi)]
	private static extern uint GetModuleBaseNameA(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_9);

	// Token: 0x0600071B RID: 1819
	[DllImport("psapi.dll")]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out Class88.Struct4 struct4_0, int int_9);

	// Token: 0x0600071C RID: 1820 RVA: 0x00007CD7 File Offset: 0x00005ED7
	private static int smethod_0(IntPtr intptr_0)
	{
		return (int)intptr_0.ToInt64();
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00007CE1 File Offset: 0x00005EE1
	private static IntPtr smethod_1(int int_9)
	{
		return new IntPtr((long)((ulong)int_9));
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00007CEA File Offset: 0x00005EEA
	public static Class88.Class89 smethod_2(string string_0, string string_1 = "-fl")
	{
		return Class88.smethod_3(string_0, string_1, null);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x0003416C File Offset: 0x0003236C
	public static Class88.Class89 smethod_3(string string_0, string string_1, byte[] byte_0)
	{
		Class88.Class89 @class = new Class88.Class89();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("hostBits=" + (IntPtr.Size * 8).ToString());
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			string text = Path.GetDirectoryName(string_0) ?? ".";
			string fileName = Path.GetFileName(string_0);
			if (fileName.Equals("Game01.exe", StringComparison.OrdinalIgnoreCase) || fileName.Equals("PathTool.exe", StringComparison.OrdinalIgnoreCase))
			{
				string text2 = Path.Combine(text, "Game.exe");
				if (File.Exists(text2))
				{
					string_0 = text2;
				}
			}
			if (IntPtr.Size == 8)
			{
				string text3 = Path.Combine(text, "Game01.exe");
				if (File.Exists(text3) && byte_0 == null)
				{
					stringBuilder.AppendLine("mode=Game01 helper (x64->x86)");
					return Class88.smethod_4(text3, text, string.IsNullOrWhiteSpace(string_1) ? "-fl" : string_1, stringBuilder, @class);
				}
			}
			return Class88.smethod_5(string_0, text, string_1, byte_0, stringBuilder, @class);
		}
		@class.string_2 = "Khong tim thay Game.exe";
		@class.string_1 = Class88.smethod_6(string_0, stringBuilder);
		return @class;
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00034290 File Offset: 0x00032490
	private static Class88.Class89 smethod_4(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, Class88.Class89 class89_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			FileName = string_0,
			Arguments = string_2,
			WorkingDirectory = string_1,
			UseShellExecute = false
		};
		Process process;
		try
		{
			process = Process.Start(processStartInfo);
		}
		catch (Exception ex)
		{
			class89_0.string_2 = "Start Game01 fail: " + ex.Message;
			class89_0.string_1 = Class88.smethod_6(Path.Combine(string_1, "Game.exe"), stringBuilder_0);
			return class89_0;
		}
		if (process == null)
		{
			class89_0.string_2 = "Start Game01 null";
			class89_0.string_1 = Class88.smethod_6(Path.Combine(string_1, "Game.exe"), stringBuilder_0);
			return class89_0;
		}
		class89_0.int_0 = process.Id;
		string text = "helperPid=";
		int i = process.Id;
		stringBuilder_0.AppendLine(text + i.ToString());
		int j = 0;
		while (j < 100)
		{
			Thread.Sleep(100);
			try
			{
				foreach (Process process2 in Process.GetProcessesByName("Game"))
				{
					try
					{
						string fileName = process2.MainModule.FileName;
						if (fileName != null && fileName.StartsWith(string_1, StringComparison.OrdinalIgnoreCase))
						{
							class89_0.int_0 = process2.Id;
							class89_0.bool_0 = true;
							class89_0.bool_1 = true;
							class89_0.bool_2 = true;
							class89_0.bool_3 = true;
							class89_0.bool_4 = true;
							class89_0.bool_5 = true;
							class89_0.string_0 = "(Game01)";
							stringBuilder_0.AppendLine("gamePid=" + process2.Id.ToString());
							class89_0.string_1 = Class88.smethod_6(Path.Combine(string_1, "Game.exe"), stringBuilder_0);
							return class89_0;
						}
					}
					catch
					{
					}
				}
				goto IL_01BE;
			}
			catch
			{
				goto IL_01BE;
			}
			goto IL_01AE;
			IL_01B3:
			j++;
			continue;
			IL_01AE:
			if (j <= 5)
			{
				goto IL_01B3;
			}
			break;
			IL_01BE:
			if (process.HasExited)
			{
				goto IL_01AE;
			}
			goto IL_01B3;
		}
		class89_0.bool_0 = !process.HasExited;
		class89_0.string_2 = (class89_0.bool_0 ? null : "Game01 thoat, khong thay Game.exe");
		class89_0.string_1 = Class88.smethod_6(Path.Combine(string_1, "Game.exe"), stringBuilder_0);
		return class89_0;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x000344D4 File Offset: 0x000326D4
	private static Class88.Class89 smethod_5(string string_0, string string_1, string string_2, byte[] byte_0, StringBuilder stringBuilder_0, Class88.Class89 class89_0)
	{
		stringBuilder_0.AppendLine("mode=in-process");
		string text = "\"" + string_0 + "\"";
		if (!string.IsNullOrWhiteSpace(string_2))
		{
			text = text + " " + string_2;
		}
		Class88.Struct2 @struct = default(Class88.Struct2);
		@struct.int_0 = Marshal.SizeOf(typeof(Class88.Struct2));
		Class88.Struct3 struct2;
		if (!Class88.CreateProcess(string_0, text, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, string_1, ref @struct, out struct2))
		{
			class89_0.string_2 = "CreateProcess fail err=" + Marshal.GetLastWin32Error().ToString();
			class89_0.string_1 = Class88.smethod_6(string_0, stringBuilder_0);
			return class89_0;
		}
		class89_0.int_0 = struct2.int_0;
		stringBuilder_0.AppendLine("pid=" + class89_0.int_0.ToString());
		try
		{
			if (!Class88.smethod_11(struct2.intptr_0, struct2.int_0))
			{
				class89_0.string_2 = "Patch mutex that bai";
				Class88.ResumeThread(struct2.intptr_1);
				class89_0.string_1 = Class88.smethod_6(string_0, stringBuilder_0);
				return class89_0;
			}
			stringBuilder_0.AppendLine("mutex OK");
			byte[] array = ((byte_0 == null || byte_0.Length < 6) ? Class88.smethod_7() : ((byte[])byte_0.Clone()));
			if (array.Length > 6)
			{
				byte[] array2 = new byte[6];
				Array.Copy(array, array2, 6);
				array = array2;
			}
			array[0] = (byte)((array[0] & 252) | 2);
			class89_0.byte_0 = array;
			class89_0.string_0 = Class88.smethod_8(array);
			stringBuilder_0.AppendLine("fakeMac=" + class89_0.string_0);
			IntPtr intPtr = Class88.VirtualAllocEx(struct2.intptr_0, IntPtr.Zero, 16U, 12288U, 64U);
			int num = ((intPtr != IntPtr.Zero) ? Class88.smethod_0(intPtr) : 0);
			if (num != 0)
			{
				Class88.smethod_9(struct2.intptr_0, num, array);
			}
			Class88.ResumeThread(struct2.intptr_1);
			Process processById = Process.GetProcessById(struct2.int_0);
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			int num2 = 0;
			int i = 0;
			while (i < 750)
			{
				int num3 = (i + 1) * 20;
				if (Class88.WaitForSingleObject(struct2.intptr_0, 20U) != 258U)
				{
					stringBuilder_0.AppendLine("exited t=" + num3.ToString());
					class89_0.string_2 = "Game thoat som";
					break;
				}
				try
				{
					Class88.smethod_14(processById, array);
					goto IL_03F3;
				}
				catch
				{
					goto IL_03F3;
				}
				goto IL_0257;
				IL_0262:
				try
				{
					Class88.smethod_13(processById, array);
				}
				catch
				{
				}
				if (num != 0)
				{
					IntPtr intPtr2 = Class88.OpenProcess(2035711U, false, processById.Id);
					if (intPtr2 != IntPtr.Zero)
					{
						try
						{
							Class88.smethod_9(intPtr2, num, array);
						}
						catch
						{
						}
						finally
						{
							Class88.CloseHandle(intPtr2);
						}
					}
				}
				if (!flag6)
				{
					try
					{
						if (Class88.smethod_22(processById, array, num))
						{
							flag6 = true;
							stringBuilder_0.AppendLine("uuid OK t=" + num3.ToString());
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
						if (Class88.smethod_23(processById, array))
						{
							flag3 = true;
							stringBuilder_0.AppendLine("gai OK t=" + num3.ToString());
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
						if (Class88.smethod_24(processById, array))
						{
							flag4 = true;
							stringBuilder_0.AppendLine("gaa OK t=" + num3.ToString());
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
						if (Class88.smethod_25(processById, array))
						{
							flag5 = true;
							stringBuilder_0.AppendLine("git OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag2)
				{
					try
					{
						if (Class88.smethod_27(processById))
						{
							flag2 = true;
							stringBuilder_0.AppendLine("notice OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag)
				{
					try
					{
						if (Class88.smethod_26(processById))
						{
							flag = true;
							stringBuilder_0.AppendLine("multi OK t=" + num3.ToString());
						}
					}
					catch
					{
					}
				}
				if (!flag || !flag2 || !flag7 || num2 < 50 || (!flag3 && !flag6))
				{
					i++;
					continue;
				}
				stringBuilder_0.AppendLine("stable t=" + num3.ToString());
				break;
				IL_0257:
				num2++;
				goto IL_0262;
				IL_03F3:
				if (flag7 = Class88.smethod_12(processById))
				{
					goto IL_0257;
				}
				num2 = 0;
				goto IL_0262;
			}
			int num4 = 0;
			while (num4 < 50 && Class88.WaitForSingleObject(struct2.intptr_0, 100U) == 258U)
			{
				try
				{
					if (!Class88.smethod_12(processById))
					{
						Class88.smethod_14(processById, array);
					}
					Class88.smethod_13(processById, array);
				}
				catch
				{
				}
				num4++;
			}
			class89_0.bool_1 = Class88.smethod_12(processById);
			class89_0.bool_2 = flag;
			class89_0.bool_3 = flag2;
			class89_0.bool_4 = flag3;
			class89_0.bool_5 = flag6;
			class89_0.bool_0 = class89_0.bool_1 && class89_0.bool_2;
			if (!class89_0.bool_0 && string.IsNullOrEmpty(class89_0.string_2))
			{
				class89_0.string_2 = "Patch chua on dinh mac=" + class89_0.bool_1.ToString() + " multi=" + class89_0.bool_2.ToString();
			}
			stringBuilder_0.AppendLine(string.Concat(new string[]
			{
				"done ok=",
				class89_0.bool_0.ToString(),
				" mac=",
				class89_0.bool_1.ToString(),
				" multi=",
				class89_0.bool_2.ToString(),
				" gai=",
				flag3.ToString(),
				" gaa=",
				flag4.ToString(),
				" git=",
				flag5.ToString(),
				" uuid=",
				flag6.ToString()
			}));
		}
		catch (Exception ex)
		{
			class89_0.string_2 = ex.Message;
			stringBuilder_0.AppendLine(ex.ToString());
			try
			{
				Class88.ResumeThread(struct2.intptr_1);
			}
			catch
			{
			}
		}
		finally
		{
			Class88.CloseHandle(struct2.intptr_1);
			Class88.CloseHandle(struct2.intptr_0);
		}
		class89_0.string_1 = Class88.smethod_6(string_0, stringBuilder_0);
		return class89_0;
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00034C5C File Offset: 0x00032E5C
	private static string smethod_6(string string_0, StringBuilder stringBuilder_0)
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

	// Token: 0x06000723 RID: 1827 RVA: 0x00034CB4 File Offset: 0x00032EB4
	public static byte[] smethod_7()
	{
		byte[] array = new byte[6];
		Class88.random_0.NextBytes(array);
		array[0] = (byte)((array[0] & 252) | 2);
		return array;
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00034CE4 File Offset: 0x00032EE4
	private static string smethod_8(byte[] byte_0)
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

	// Token: 0x06000725 RID: 1829 RVA: 0x00034D44 File Offset: 0x00032F44
	private static bool smethod_9(IntPtr intptr_0, int int_9, byte[] byte_0)
	{
		uint num;
		Class88.VirtualProtectEx(intptr_0, Class88.smethod_1(int_9), (uint)byte_0.Length, 64U, out num);
		int num2;
		bool flag = Class88.WriteProcessMemory(intptr_0, Class88.smethod_1(int_9), byte_0, byte_0.Length, out num2) && num2 == byte_0.Length;
		uint num3;
		Class88.VirtualProtectEx(intptr_0, Class88.smethod_1(int_9), (uint)byte_0.Length, num, out num3);
		return flag;
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00034D98 File Offset: 0x00032F98
	private static byte[] smethod_10(IntPtr intptr_0, int int_9, int int_10)
	{
		byte[] array = new byte[int_10];
		int num;
		if (Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(int_9), array, int_10, out num))
		{
			if (num == int_10)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00034DC8 File Offset: 0x00032FC8
	private static bool smethod_11(IntPtr intptr_0, int int_9)
	{
		string text = "A292F57D-84FD-4465-9A03-" + int_9.ToString("X12");
		if (text.Length > 36)
		{
			text = text.Substring(0, 36);
		}
		if (!Class88.smethod_9(intptr_0, 6232324, Encoding.ASCII.GetBytes(text)))
		{
			return false;
		}
		byte[] array = Class88.smethod_10(intptr_0, 4385227, 2);
		if (array != null)
		{
			if (array[0] == 117 || array[0] == 235)
			{
				return Class88.smethod_9(intptr_0, 4385227, new byte[] { 235, 123 }) && Class88.smethod_9(intptr_0, 4385245, new byte[] { byte.MaxValue }) && Class88.smethod_9(intptr_0, 4387436, new byte[] { 144, 144, 144, 144, 144, 144 });
			}
		}
		return false;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00034E98 File Offset: 0x00033098
	private static bool smethod_12(Process process_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = Class88.smethod_10(intPtr, 4795680, 1);
			flag = array != null && array[0] == 233;
		}
		finally
		{
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00034F00 File Offset: 0x00033100
	private static void smethod_13(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Class88.smethod_9(intPtr, 6576016, byte_0);
			Class88.smethod_9(intPtr, 6576840, Encoding.ASCII.GetBytes(Class88.smethod_8(byte_0) + "\0"));
		}
		finally
		{
			Class88.CloseHandle(intPtr);
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00034F7C File Offset: 0x0003317C
	private static bool smethod_14(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag2;
		try
		{
			bool flag = Class88.smethod_15(intPtr, byte_0);
			Class88.smethod_16(intPtr, byte_0);
			Class88.smethod_17(intPtr, byte_0);
			Class88.smethod_9(intPtr, 6576016, byte_0);
			Class88.smethod_9(intPtr, 6576840, Encoding.ASCII.GetBytes(Class88.smethod_8(byte_0) + "\0"));
			flag2 = flag;
		}
		finally
		{
			Class88.CloseHandle(intPtr);
		}
		return flag2;
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00035014 File Offset: 0x00033214
	private static bool smethod_15(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class88.smethod_10(intptr_0, 4795680, 5);
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
		IntPtr intPtr = Class88.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num3 = Class88.smethod_0(intPtr);
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
		if (!Class88.WriteProcessMemory(intptr_0, intPtr, list.ToArray(), list.Count, out num4))
		{
			return false;
		}
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - 4795685).CopyTo(array3, 1);
		return Class88.smethod_9(intptr_0, 4795680, array3);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000351AC File Offset: 0x000333AC
	private static void smethod_16(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class88.smethod_10(intptr_0, 4796032, 5);
		if (array != null && array[0] != 233)
		{
			if (array[0] == 85)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class88.smethod_8(byte_0) + "\0");
				IntPtr intPtr = Class88.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				int num = Class88.smethod_0(intPtr);
				byte[] array2 = new byte[32];
				Buffer.BlockCopy(bytes, 0, array2, 0, bytes.Length);
				int num2;
				if (!Class88.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
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
				if (!Class88.WriteProcessMemory(intptr_0, Class88.smethod_1(num5), list.ToArray(), list.Count, out num2))
				{
					return;
				}
				byte[] array3 = new byte[5];
				array3[0] = 233;
				byte[] array4 = array3;
				BitConverter.GetBytes(num5 - 4796037).CopyTo(array4, 1);
				Class88.smethod_9(intptr_0, 4796032, array4);
				return;
			}
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x000353CC File Offset: 0x000335CC
	private static void smethod_17(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class88.smethod_10(intptr_0, 4796051, 7);
		if (array != null && array[0] == 15)
		{
			if (array[1] == 182)
			{
				IntPtr intPtr = Class88.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				uint num = (uint)Class88.smethod_0(intPtr);
				byte[] array2 = new byte[20];
				Class88.random_0.NextBytes(array2);
				Buffer.BlockCopy(byte_0, 0, array2, 0, 6);
				int num2;
				if (!Class88.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
				{
					return;
				}
				int[] array3 = new int[] { 0, 7, 14, 22, 30, 38 };
				for (int i = 0; i < 6; i++)
				{
					Class88.smethod_9(intptr_0, 4796051 + array3[i] + 3, BitConverter.GetBytes(num + (uint)i));
				}
				return;
			}
		}
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000354A0 File Offset: 0x000336A0
	private static bool smethod_18(IntPtr intptr_0, string string_0, out int int_9, out int int_10)
	{
		int_9 = 0;
		int_10 = 0;
		IntPtr[] array = new IntPtr[1024];
		int num;
		bool flag = Class88.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 1U) || Class88.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 3U);
		if (!flag)
		{
			flag = Class88.EnumProcessModules(intptr_0, array, array.Length * IntPtr.Size, out num);
		}
		if (!flag)
		{
			return false;
		}
		int num2 = num / IntPtr.Size;
		int num3 = 0;
		while (num3 < num2 && num3 < array.Length)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			Class88.GetModuleBaseNameA(intptr_0, array[num3], stringBuilder, 260);
			if (!stringBuilder.ToString().Equals(string_0, StringComparison.OrdinalIgnoreCase))
			{
				num3++;
			}
			else
			{
				Class88.Struct4 @struct;
				if (!Class88.GetModuleInformation(intptr_0, array[num3], out @struct, Marshal.SizeOf(typeof(Class88.Struct4))))
				{
					return false;
				}
				int_9 = Class88.smethod_0(@struct.intptr_0);
				int_10 = (int)@struct.uint_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x0003558C File Offset: 0x0003378C
	private static IntPtr smethod_19(IntPtr intptr_0, string string_0, string string_1)
	{
		int num;
		int num2;
		if (!Class88.smethod_18(intptr_0, string_0, out num, out num2))
		{
			return IntPtr.Zero;
		}
		return Class88.smethod_20(intptr_0, Class88.smethod_1(num), string_1);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x000355BC File Offset: 0x000337BC
	private static IntPtr smethod_20(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		int num = Class88.smethod_0(intptr_1);
		byte[] array = new byte[4096];
		int num2;
		if (!Class88.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num2))
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
		if (!Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num4), array2, array2.Length, out num2))
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
			if (Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num6 + i * 4), array3, 4, out num2))
			{
				int num9 = BitConverter.ToInt32(array3, 0);
				byte[] array4 = new byte[64];
				if (Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num9), array4, 64, out num2))
				{
					int num10 = Array.IndexOf<byte>(array4, 0);
					if (!(Encoding.ASCII.GetString(array4, 0, (num10 < 0) ? array4.Length : num10) != string_0))
					{
						byte[] array5 = new byte[2];
						if (!Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num7 + i * 2), array5, 2, out num2))
						{
							return IntPtr.Zero;
						}
						ushort num11 = BitConverter.ToUInt16(array5, 0);
						byte[] array6 = new byte[4];
						if (!Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num8 + (int)(num11 * 4)), array6, 4, out num2))
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
							if (Class88.ReadProcessMemory(intptr_0, Class88.smethod_1(num + num12), array7, 64, out num2))
							{
								int num13 = Array.IndexOf<byte>(array7, 0);
								text = Encoding.ASCII.GetString(array7, 0, (num13 < 0) ? array7.Length : num13);
							}
						}
						if (text != null && text.IndexOf('.') > 0)
						{
							return IntPtr.Zero;
						}
						return Class88.smethod_1(num + num12);
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00035808 File Offset: 0x00033A08
	private static bool smethod_21(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_1)
	{
		int num = Class88.smethod_0(intptr_1);
		int num2 = Class88.smethod_0(intptr_2);
		int num3 = Class88.smethod_0(intptr_3);
		byte[] array = new byte[10];
		Array.Copy(byte_0, array, 5);
		array[5] = 233;
		BitConverter.GetBytes(num + 5 - (num2 + 10)).CopyTo(array, 6);
		int num4;
		Class88.WriteProcessMemory(intptr_0, intptr_2, array, 10, out num4);
		Class88.WriteProcessMemory(intptr_0, intptr_3, byte_1, byte_1.Length, out num4);
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - (num + 5)).CopyTo(array3, 1);
		uint num5;
		Class88.VirtualProtectEx(intptr_0, intptr_1, 8U, 64U, out num5);
		bool flag = Class88.WriteProcessMemory(intptr_0, intptr_1, array3, 5, out num4);
		Class88.VirtualProtectEx(intptr_0, intptr_1, 8U, num5, out num5);
		return flag;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x000358C4 File Offset: 0x00033AC4
	private static bool smethod_22(Process process_0, byte[] byte_0, int int_9)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			IntPtr intPtr2 = Class88.smethod_19(intPtr, "rpcrt4.dll", "UuidCreateSequential");
			if (intPtr2 == IntPtr.Zero)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[5];
				int num;
				if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num))
				{
					if (num == 5)
					{
						if (array[0] == 233)
						{
							return true;
						}
						if (int_9 == 0)
						{
							IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 16U, 12288U, 64U);
							if (intPtr3 == IntPtr.Zero)
							{
								return false;
							}
							int_9 = Class88.smethod_0(intPtr3);
							Class88.smethod_9(intPtr, int_9, byte_0);
						}
						IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						IntPtr intPtr5 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
						if (!(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
						{
							int num2 = Class88.smethod_0(intPtr5);
							int num3 = Class88.smethod_0(intPtr4);
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
							return Class88.smethod_21(intPtr, intPtr2, array, intPtr4, intPtr5, array3);
						}
						return false;
					}
				}
				flag = false;
			}
		}
		finally
		{
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00035B8C File Offset: 0x00033D8C
	private static bool smethod_23(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class88.smethod_18(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class88.smethod_20(intPtr, Class88.smethod_1(num), "GetAdaptersInfo");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class88.smethod_0(intPtr4);
								int num7 = Class88.smethod_0(intPtr3);
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
								return Class88.smethod_21(intPtr, intPtr2, array, intPtr3, intPtr4, array4);
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
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00035F64 File Offset: 0x00034164
	private static bool smethod_24(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class88.smethod_18(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class88.smethod_20(intPtr, Class88.smethod_1(num), "GetAdaptersAddresses");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class88.smethod_0(intPtr4);
								int num7 = Class88.smethod_0(intPtr3);
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
								return Class88.smethod_21(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00036348 File Offset: 0x00034548
	private static bool smethod_25(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class88.smethod_18(intPtr, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class88.smethod_20(intPtr, Class88.smethod_1(num), "GetIfTable");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class88.smethod_0(intPtr4);
								int num7 = Class88.smethod_0(intPtr3);
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
								return Class88.smethod_21(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00036780 File Offset: 0x00034980
	private static bool smethod_26(Process process_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class88.smethod_18(intPtr, "Plugin_ClientManager.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class88.smethod_19(intPtr, "kernel32.dll", "ExitProcess");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 64U, 12288U, 64U);
							IntPtr intPtr5 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 8U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
							{
								int num4 = Class88.smethod_0(intPtr3);
								int num5 = Class88.smethod_0(intPtr4);
								int num6 = Class88.smethod_0(intPtr5);
								int num7 = Class88.smethod_0(intPtr2);
								int num8;
								Class88.WriteProcessMemory(intPtr, intPtr5, BitConverter.GetBytes(num), 4, out num8);
								Class88.WriteProcessMemory(intPtr, Class88.smethod_1(num6 + 4), BitConverter.GetBytes(num + num2), 4, out num8);
								byte[] array2 = new byte[10];
								Array.Copy(array, array2, 5);
								array2[5] = 233;
								BitConverter.GetBytes(num7 + 5 - (num4 + 10)).CopyTo(array2, 6);
								Class88.WriteProcessMemory(intPtr, intPtr3, array2, 10, out num8);
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
								Class88.WriteProcessMemory(intPtr, intPtr4, array3, 31, out num8);
								byte[] array4 = new byte[5];
								array4[0] = 233;
								byte[] array5 = array4;
								BitConverter.GetBytes(num5 - (num7 + 5)).CopyTo(array5, 1);
								uint num9;
								Class88.VirtualProtectEx(intPtr, intPtr2, 8U, 64U, out num9);
								bool flag2 = Class88.WriteProcessMemory(intPtr, intPtr2, array5, 5, out num8);
								Class88.VirtualProtectEx(intPtr, intPtr2, 8U, num9, out num9);
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
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00036A80 File Offset: 0x00034C80
	private static bool smethod_27(Process process_0)
	{
		IntPtr intPtr = Class88.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			IntPtr intPtr2 = Class88.smethod_19(intPtr, "user32.dll", "MessageBoxW");
			if (intPtr2 == IntPtr.Zero)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[5];
				int num;
				if (Class88.ReadProcessMemory(intPtr, intPtr2, array, 5, out num))
				{
					if (num == 5)
					{
						if (array[0] == 233)
						{
							return true;
						}
						IntPtr intPtr3 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
						IntPtr intPtr4 = Class88.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
						if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
						{
							int num2 = Class88.smethod_0(intPtr3);
							int num3 = Class88.smethod_0(intPtr4);
							int num4 = Class88.smethod_0(intPtr2);
							byte[] array2 = new byte[10];
							Array.Copy(array, array2, 5);
							array2[5] = 233;
							BitConverter.GetBytes(num4 + 5 - (num2 + 10)).CopyTo(array2, 6);
							int num5;
							Class88.WriteProcessMemory(intPtr, intPtr3, array2, 10, out num5);
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
							Class88.WriteProcessMemory(intPtr, intPtr4, array8, array8.Length, out num5);
							byte[] array9 = new byte[5];
							array9[0] = 233;
							byte[] array10 = array9;
							BitConverter.GetBytes(num3 - (num4 + 5)).CopyTo(array10, 1);
							uint num6;
							Class88.VirtualProtectEx(intPtr, intPtr2, 8U, 64U, out num6);
							bool flag2 = Class88.WriteProcessMemory(intPtr, intPtr2, array10, 5, out num5);
							Class88.VirtualProtectEx(intPtr, intPtr2, 8U, num6, out num6);
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
			Class88.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x040003A3 RID: 931
	private const uint uint_0 = 4U;

	// Token: 0x040003A4 RID: 932
	private const uint uint_1 = 2035711U;

	// Token: 0x040003A5 RID: 933
	private const uint uint_2 = 4096U;

	// Token: 0x040003A6 RID: 934
	private const uint uint_3 = 8192U;

	// Token: 0x040003A7 RID: 935
	private const uint uint_4 = 64U;

	// Token: 0x040003A8 RID: 936
	private const uint uint_5 = 258U;

	// Token: 0x040003A9 RID: 937
	private const uint uint_6 = 1U;

	// Token: 0x040003AA RID: 938
	private const uint uint_7 = 3U;

	// Token: 0x040003AB RID: 939
	private const int int_0 = 6232324;

	// Token: 0x040003AC RID: 940
	private const int int_1 = 4385227;

	// Token: 0x040003AD RID: 941
	private const int int_2 = 4385245;

	// Token: 0x040003AE RID: 942
	private const int int_3 = 4387436;

	// Token: 0x040003AF RID: 943
	private const int int_4 = 4795680;

	// Token: 0x040003B0 RID: 944
	private const int int_5 = 4796032;

	// Token: 0x040003B1 RID: 945
	private const int int_6 = 4796051;

	// Token: 0x040003B2 RID: 946
	private const int int_7 = 6576016;

	// Token: 0x040003B3 RID: 947
	private const int int_8 = 6576840;

	// Token: 0x040003B4 RID: 948
	private static readonly Random random_0 = new Random();

	// Token: 0x020000A1 RID: 161
	public sealed class Class89
	{
		// Token: 0x040003B5 RID: 949
		public bool bool_0;

		// Token: 0x040003B6 RID: 950
		public int int_0;

		// Token: 0x040003B7 RID: 951
		public byte[] byte_0;

		// Token: 0x040003B8 RID: 952
		public string string_0;

		// Token: 0x040003B9 RID: 953
		public bool bool_1;

		// Token: 0x040003BA RID: 954
		public bool bool_2;

		// Token: 0x040003BB RID: 955
		public bool bool_3;

		// Token: 0x040003BC RID: 956
		public bool bool_4;

		// Token: 0x040003BD RID: 957
		public bool bool_5;

		// Token: 0x040003BE RID: 958
		public string string_1;

		// Token: 0x040003BF RID: 959
		public string string_2;
	}

	// Token: 0x020000A2 RID: 162
	private struct Struct2
	{
		// Token: 0x040003C0 RID: 960
		public int int_0;

		// Token: 0x040003C1 RID: 961
		public IntPtr intptr_0;

		// Token: 0x040003C2 RID: 962
		public IntPtr intptr_1;

		// Token: 0x040003C3 RID: 963
		public IntPtr intptr_2;

		// Token: 0x040003C4 RID: 964
		public int int_1;

		// Token: 0x040003C5 RID: 965
		public int int_2;

		// Token: 0x040003C6 RID: 966
		public int int_3;

		// Token: 0x040003C7 RID: 967
		public int int_4;

		// Token: 0x040003C8 RID: 968
		public int int_5;

		// Token: 0x040003C9 RID: 969
		public int int_6;

		// Token: 0x040003CA RID: 970
		public int int_7;

		// Token: 0x040003CB RID: 971
		public int int_8;

		// Token: 0x040003CC RID: 972
		public short short_0;

		// Token: 0x040003CD RID: 973
		public short short_1;

		// Token: 0x040003CE RID: 974
		public IntPtr intptr_3;

		// Token: 0x040003CF RID: 975
		public IntPtr intptr_4;

		// Token: 0x040003D0 RID: 976
		public IntPtr intptr_5;

		// Token: 0x040003D1 RID: 977
		public IntPtr intptr_6;
	}

	// Token: 0x020000A3 RID: 163
	private struct Struct3
	{
		// Token: 0x040003D2 RID: 978
		public IntPtr intptr_0;

		// Token: 0x040003D3 RID: 979
		public IntPtr intptr_1;

		// Token: 0x040003D4 RID: 980
		public int int_0;

		// Token: 0x040003D5 RID: 981
		public int int_1;
	}

	// Token: 0x020000A4 RID: 164
	private struct Struct4
	{
		// Token: 0x040003D6 RID: 982
		public IntPtr intptr_0;

		// Token: 0x040003D7 RID: 983
		public uint uint_0;

		// Token: 0x040003D8 RID: 984
		public IntPtr intptr_1;
	}
}
