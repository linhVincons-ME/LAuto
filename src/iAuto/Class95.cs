using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020000AD RID: 173
internal class Class95
{
	// Token: 0x0600077D RID: 1917
	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x0600077E RID: 1918
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CreateProcess(string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_8, IntPtr intptr_2, string string_1, ref Class95.Struct9 struct9_0, out Class95.Struct10 struct10_0);

	// Token: 0x0600077F RID: 1919
	[DllImport("kernel32.dll")]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_8);

	// Token: 0x06000780 RID: 1920
	[DllImport("kernel32.dll")]
	private static extern uint ResumeThread(IntPtr intptr_0);

	// Token: 0x06000781 RID: 1921
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_8, bool bool_0, int int_11);

	// Token: 0x06000782 RID: 1922
	[DllImport("kernel32.dll")]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, uint uint_9, uint uint_10);

	// Token: 0x06000783 RID: 1923
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_11, out int int_12);

	// Token: 0x06000784 RID: 1924
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_11, out int int_12);

	// Token: 0x06000785 RID: 1925
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, uint uint_9, out uint uint_10);

	// Token: 0x06000786 RID: 1926
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_8, uint uint_9);

	// Token: 0x06000787 RID: 1927
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_0, ref Class95.Struct12 struct12_0);

	// Token: 0x06000788 RID: 1928
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_0, ref Class95.Struct12 struct12_0);

	// Token: 0x06000789 RID: 1929
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_8, IntPtr intptr_2, IntPtr intptr_3, uint uint_9, out uint uint_10);

	// Token: 0x0600078A RID: 1930
	[DllImport("ntdll.dll")]
	private static extern int NtQueryInformationProcess(IntPtr intptr_0, int int_11, ref Class95.Struct11 struct11_0, int int_12, out int int_13);

	// Token: 0x0600078B RID: 1931
	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess")]
	private static extern int NtQueryInformationProcess_1(IntPtr intptr_0, int int_11, out IntPtr intptr_1, int int_12, out int int_13);

	// Token: 0x0600078C RID: 1932
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_11, out int int_12, uint uint_8);

	// Token: 0x0600078D RID: 1933
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModules(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_11, out int int_12);

	// Token: 0x0600078E RID: 1934
	[DllImport("psapi.dll", CharSet = CharSet.Ansi)]
	private static extern uint GetModuleBaseNameA(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_11);

	// Token: 0x0600078F RID: 1935
	[DllImport("psapi.dll")]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out Class95.Struct8 struct8_0, int int_11);

	// Token: 0x06000790 RID: 1936 RVA: 0x00007CD7 File Offset: 0x00005ED7
	private static int smethod_0(IntPtr intptr_0)
	{
		return (int)intptr_0.ToInt64();
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00007CE1 File Offset: 0x00005EE1
	private static IntPtr smethod_1(int int_11)
	{
		return new IntPtr((long)((ulong)int_11));
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00007DAA File Offset: 0x00005FAA
	public static Class95.Class96 smethod_2(string string_0, string string_1 = "-fl")
	{
		return Class95.smethod_9(string_0, string_1, null, false);
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00007DB5 File Offset: 0x00005FB5
	public static Class95.Class96 smethod_3(string string_0, string string_1, byte[] byte_0)
	{
		return Class95.smethod_9(string_0, string_1, byte_0, false);
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00007DC0 File Offset: 0x00005FC0
	public static Class95.Class96 smethod_4(string string_0, string string_1, string string_2 = "-fl")
	{
		if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(string_1))
		{
			return Class95.smethod_9(Path.Combine(string_0, string_1), string_2, null, false);
		}
		return Class95.smethod_12(string_0, "Thieu gameDir hoac exeName");
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00007DAA File Offset: 0x00005FAA
	public static Class95.Class96 smethod_5(string string_0, string string_1 = "-fl")
	{
		return Class95.smethod_9(string_0, string_1, null, false);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00007DED File Offset: 0x00005FED
	public static Class95.Class96 smethod_6(string string_0, string string_1 = "-fl")
	{
		return Class95.smethod_9(string_0, string_1, null, true);
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00007DF8 File Offset: 0x00005FF8
	public static Class95.Class96 smethod_7(string string_0, string string_1, byte[] byte_0)
	{
		return Class95.smethod_9(string_0, string_1, byte_0, true);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0003AEDC File Offset: 0x000390DC
	private static string smethod_8(string string_0, StringBuilder stringBuilder_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return null;
		}
		string_0 = string_0.Trim().Trim(new char[] { '"' });
		Class95.Struct13 @struct;
		@struct.list_0 = new List<string>();
		if (string_0.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			Class95.smethod_54(string_0, ref @struct);
			Class95.smethod_54(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0), ref @struct);
			string directoryName = Path.GetDirectoryName(string_0);
			if (!string.IsNullOrEmpty(directoryName))
			{
				Class95.smethod_54(Path.Combine(directoryName, Path.GetFileName(string_0)), ref @struct);
			}
		}
		else if (Directory.Exists(string_0))
		{
			Class95.smethod_54(Path.Combine(string_0, "Game.exe"), ref @struct);
			// game root folder: the client lives in Bin\Game.exe
			Class95.smethod_54(Path.Combine(string_0, "Bin", "Game.exe"), ref @struct);
		}
		else
		{
			Class95.smethod_54(string_0, ref @struct);
			Class95.smethod_54(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0), ref @struct);
			if (!string_0.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				Class95.smethod_54(Path.Combine(string_0, "Game.exe"), ref @struct);
				Class95.smethod_54(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0, "Game.exe"), ref @struct);
				Class95.smethod_54(Path.Combine(string_0, "Bin", "Game.exe"), ref @struct);
				Class95.smethod_54(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0, "Bin", "Game.exe"), ref @struct);
			}
		}
		foreach (string text in @struct.list_0)
		{
			if (File.Exists(text) && text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				stringBuilder_0.AppendLine("gameExe=" + text);
				return text;
			}
		}
		stringBuilder_0.AppendLine("resolve fail input=" + string_0);
		foreach (string text2 in @struct.list_0)
		{
			stringBuilder_0.AppendLine(" tried=" + text2);
		}
		return null;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0003B0B8 File Offset: 0x000392B8
	private static Class95.Class96 smethod_9(string string_0, string string_1, byte[] byte_0, bool bool_0)
	{
		Class95.Class96 @class = new Class95.Class96();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("hostBits=" + (IntPtr.Size * 8).ToString());
		stringBuilder.AppendLine("input=" + string_0);
		string text = Class95.smethod_8(string_0, stringBuilder);
		if (text == null)
		{
			@class.string_3 = "Khong tim thay file game: " + string_0;
			@class.string_2 = Class95.smethod_18(string_0, stringBuilder);
			return @class;
		}
		@class.string_0 = text;
		string text2 = Path.GetDirectoryName(text) ?? ".";
		string_1 = (string.IsNullOrWhiteSpace(string_1) ? "-fl" : string_1);
		stringBuilder.AppendLine("mode=in-process waitPatch=" + bool_0.ToString());
		Class95.smethod_18(text, stringBuilder);
		return Class95.smethod_13(text, text2, string_1, byte_0, bool_0, stringBuilder, @class);
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00007E03 File Offset: 0x00006003
	public static Class95.Class96 smethod_10(int int_11)
	{
		return Class95.smethod_11(int_11, null);
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0003B1A0 File Offset: 0x000393A0
	public static Class95.Class96 smethod_11(int int_11, string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("mode=attach pid=" + int_11.ToString());
		Process processById;
		Class95.Class96 @class;
		try
		{
			processById = Process.GetProcessById(int_11);
			goto IL_0060;
		}
		catch
		{
			@class = Class95.smethod_12(string_0, "Process khong ton tai pid=" + int_11.ToString());
		}
		return @class;
		IL_0060:
		if (processById.HasExited)
		{
			return Class95.smethod_12(string_0, "Process da thoat pid=" + int_11.ToString());
		}
		Class95.smethod_48(processById);
		string text = string_0;
		if (string.IsNullOrEmpty(text))
		{
			try
			{
				text = processById.MainModule.FileName;
			}
			catch
			{
				text = ".";
			}
		}
		text = Path.GetFullPath(text);
		stringBuilder.AppendLine("gameExe=" + text);
		byte[] array = Class95.smethod_19();
		array[0] = (byte)((array[0] & 252) | 2);
		stringBuilder.AppendLine("fakeMac=" + Class95.smethod_20(array));
		Class95.smethod_18(text, stringBuilder);
		Class95.Class96 class2 = Class95.smethod_15(processById, text, array, stringBuilder);
		class2.string_0 = text;
		return class2;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00007E0C File Offset: 0x0000600C
	private static Class95.Class96 smethod_12(string string_0, string string_1)
	{
		return new Class95.Class96
		{
			string_3 = string_1,
			string_2 = Class95.smethod_18(string_0, new StringBuilder(string_1))
		};
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0003B2D0 File Offset: 0x000394D0
	private static Class95.Class96 smethod_13(string string_0, string string_1, string string_2, byte[] byte_0, bool bool_0, StringBuilder stringBuilder_0, Class95.Class96 class96_0)
	{
		Class95.Class97 @class = new Class95.Class97();
		@class.stringBuilder_0 = stringBuilder_0;
		Process process = Class95.smethod_14(string_0, string_1, string_2, @class.stringBuilder_0);
		if (process == null)
		{
			class96_0.string_3 = "Start Game that bai, xem TnclGameLaunch.log";
			class96_0.string_2 = Class95.smethod_18(string_0, @class.stringBuilder_0);
			return class96_0;
		}
		class96_0.int_0 = process.Id;
		class96_0.bool_0 = true;
		class96_0.string_0 = string_0;
		@class.stringBuilder_0.AppendLine("pid=" + class96_0.int_0.ToString());
		Class95.smethod_18(string_0, @class.stringBuilder_0);
		@class.byte_0 = ((byte_0 == null || byte_0.Length < 6) ? Class95.smethod_19() : ((byte[])byte_0.Clone()));
		if (@class.byte_0.Length > 6)
		{
			byte[] array = new byte[6];
			Array.Copy(@class.byte_0, array, 6);
			@class.byte_0 = array;
		}
		@class.byte_0[0] = (byte)((@class.byte_0[0] & 252) | 2);
		class96_0.byte_0 = @class.byte_0;
		class96_0.string_1 = Class95.smethod_20(@class.byte_0);
		@class.stringBuilder_0.AppendLine("fakeMac=" + class96_0.string_1);
		if (!bool_0)
		{
			@class.stringBuilder_0.AppendLine("patch=background");
			Class95.smethod_18(string_0, @class.stringBuilder_0);
			@class.int_0 = process.Id;
			@class.string_0 = string_0;
			new Thread(new ThreadStart(@class.method_0))
			{
				IsBackground = true,
				Name = "TnclPatch"
			}.Start();
			class96_0.string_2 = @class.stringBuilder_0.ToString();
			return class96_0;
		}
		return Class95.smethod_15(process, string_0, @class.byte_0, @class.stringBuilder_0);
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0003B48C File Offset: 0x0003968C
	private static Process smethod_14(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0)
	{
		string_0 = Path.GetFullPath(string_0);
		string_1 = Path.GetFullPath(string_1);
		try
		{
			Class95.Struct9 @struct = new Class95.Struct9
			{
				int_0 = Marshal.SizeOf(typeof(Class95.Struct9))
			};
			StringBuilder stringBuilder = new StringBuilder("\"" + string_0 + "\"");
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				stringBuilder.Append(" ").Append(string_2.Trim());
			}
			Class95.Struct10 struct2;
			if (Class95.CreateProcess(null, stringBuilder, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, string_1, ref @struct, out struct2))
			{
				Process processById = Process.GetProcessById(struct2.int_0);
				bool flag;
				stringBuilder_0.AppendLine("nameFix=" + ((flag = Class95.smethod_49(processById)) || Class95.smethod_52(processById)).ToString() + " pebAlias=" + flag.ToString());
				Class95.smethod_48(processById);
				int num = (int)Class95.ResumeThread(struct2.intptr_1);
				Class95.CloseHandle(struct2.intptr_1);
				Class95.CloseHandle(struct2.intptr_0);
				if (num != -1)
				{
					stringBuilder_0.AppendLine("start=CreateProcess suspended pid=" + struct2.int_0.ToString());
					return processById;
				}
				try
				{
					processById.Kill();
				}
				catch
				{
				}
				stringBuilder_0.AppendLine("ResumeThread fail err=" + Marshal.GetLastWin32Error().ToString());
			}
			else
			{
				stringBuilder_0.AppendLine("CreateProcess suspended fail err=" + Marshal.GetLastWin32Error().ToString());
			}
		}
		catch (Exception ex)
		{
			stringBuilder_0.AppendLine("CreateProcess suspended ex " + ex.Message);
		}
		try
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				Arguments = (string_2 ?? ""),
				WorkingDirectory = string_1,
				UseShellExecute = false
			});
			if (process != null)
			{
				Class95.smethod_48(process);
				Thread.Sleep(300);
				try
				{
					process.Refresh();
					if (!process.HasExited)
					{
						stringBuilder_0.AppendLine("start=Process.Start pid=" + process.Id.ToString());
						return process;
					}
					stringBuilder_0.AppendLine("start=Process.Start exited code=" + process.ExitCode.ToString());
				}
				catch (Exception ex2)
				{
					stringBuilder_0.AppendLine("start=Process.Start refresh fail " + ex2.Message);
					return process;
				}
			}
		}
		catch (Exception ex3)
		{
			stringBuilder_0.AppendLine("start=Process.Start fail " + ex3.Message);
		}
		try
		{
			Class95.Struct9 struct3 = new Class95.Struct9
			{
				int_0 = Marshal.SizeOf(typeof(Class95.Struct9))
			};
			StringBuilder stringBuilder2 = new StringBuilder("\"" + string_0 + "\"");
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				stringBuilder2.Append(" ").Append(string_2.Trim());
			}
			Class95.Struct10 struct4;
			if (Class95.CreateProcess(null, stringBuilder2, IntPtr.Zero, IntPtr.Zero, false, 0U, IntPtr.Zero, string_1, ref struct3, out struct4))
			{
				Class95.CloseHandle(struct4.intptr_1);
				Class95.CloseHandle(struct4.intptr_0);
				stringBuilder_0.AppendLine("start=CreateProcess pid=" + struct4.int_0.ToString());
				Process processById2 = Process.GetProcessById(struct4.int_0);
				Class95.smethod_48(processById2);
				return processById2;
			}
			stringBuilder_0.AppendLine("start=CreateProcess fail err=" + Marshal.GetLastWin32Error().ToString());
		}
		catch (Exception ex4)
		{
			stringBuilder_0.AppendLine("start=CreateProcess ex " + ex4.Message);
		}
		return null;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0003B894 File Offset: 0x00039A94
	private static Class95.Class96 smethod_15(Process process_0, string string_0, byte[] byte_0, StringBuilder stringBuilder_0)
	{
		Class95.Class96 @class = new Class95.Class96
		{
			int_0 = process_0.Id,
			bool_0 = true,
			string_0 = string_0,
			byte_0 = byte_0,
			string_1 = Class95.smethod_20(byte_0)
		};
		try
		{
			stringBuilder_0.AppendLine("wait unpack+patch...");
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			int num = 0;
			int num2 = 0;
			bool flag10 = false;
			int num3 = -1;
			int i = 0;
			while (i < 2000)
			{
				int num4 = (i + 1) * 10;
				if (!process_0.HasExited)
				{
					try
					{
						if (Class95.smethod_53(process_0))
						{
							if (!flag)
							{
								stringBuilder_0.AppendLine("notice early t=" + num4.ToString());
							}
							flag = true;
						}
					}
					catch
					{
					}
					try
					{
						IL_00B7:
						if (Class95.smethod_46(process_0))
						{
							if (!flag2)
							{
								stringBuilder_0.AppendLine("multi early t=" + num4.ToString());
							}
							flag2 = true;
						}
					}
					catch
					{
					}
					if (!flag5)
					{
						try
						{
							if (Class95.smethod_40(process_0, byte_0))
							{
								flag5 = true;
								stringBuilder_0.AppendLine("gai OK t=" + num4.ToString());
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
							if (Class95.smethod_41(process_0, byte_0))
							{
								flag6 = true;
								stringBuilder_0.AppendLine("gaa OK t=" + num4.ToString());
							}
						}
						catch
						{
						}
					}
					if (!flag8)
					{
						try
						{
							if (Class95.smethod_39(process_0, byte_0))
							{
								flag8 = true;
								stringBuilder_0.AppendLine("uuid OK t=" + num4.ToString());
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
							if (Class95.smethod_42(process_0, byte_0))
							{
								flag7 = true;
								stringBuilder_0.AppendLine("git OK t=" + num4.ToString());
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
							if (Class95.smethod_17(process_0))
							{
								flag3 = true;
								num3 = num4;
								stringBuilder_0.AppendLine("unpacked t=" + num4.ToString() + " macNow mutex+" + 800.ToString());
							}
						}
						catch
						{
						}
					}
					bool flag11 = flag3 && num3 >= 0 && num4 >= num3;
					bool flag12 = flag3 && num3 >= 0 && num4 >= num3 + 800;
					if (flag11)
					{
						bool flag13 = Class95.smethod_24(process_0);
						try
						{
							if (Class95.smethod_26(process_0, byte_0))
							{
								if (!flag10)
								{
									stringBuilder_0.AppendLine("ApplyMac OK t=" + num4.ToString());
								}
								flag10 = true;
							}
						}
						catch
						{
						}
						bool flag14 = Class95.smethod_24(process_0);
						if (flag13 && !flag14)
						{
							num2++;
							num = 0;
							stringBuilder_0.AppendLine("mac RESTORED t=" + num4.ToString());
						}
						else if (flag14)
						{
							num++;
						}
						else
						{
							num = 0;
						}
						if (flag14)
						{
							flag9 = true;
						}
						try
						{
							Class95.smethod_25(process_0, byte_0);
						}
						catch
						{
						}
					}
					if (flag12 && !flag4)
					{
						try
						{
							if (Class95.smethod_23(process_0))
							{
								flag4 = true;
								stringBuilder_0.AppendLine("mutex OK t=" + num4.ToString());
							}
						}
						catch
						{
						}
					}
					if (!flag2 || !flag || !flag10 || !flag4 || (!flag5 && !flag6 && !flag8))
					{
						if (i % 100 == 99)
						{
							Class95.smethod_18(string_0, stringBuilder_0);
						}
						Thread.Sleep(10);
						i++;
						continue;
					}
					stringBuilder_0.AppendLine("stable t=" + num4.ToString() + " restores=" + num2.ToString());
					Class95.smethod_18(string_0, stringBuilder_0);
					break;
				}
				stringBuilder_0.AppendLine(string.Concat(new string[]
				{
					"exited t=",
					num4.ToString(),
					" multi=",
					flag2.ToString(),
					" notice=",
					flag.ToString(),
					" mac=",
					flag10.ToString()
				}));
				@class.string_3 = "Game thoat som";
				@class.bool_0 = false;
				@class.string_2 = Class95.smethod_18(string_0, stringBuilder_0);
				return @class;
			}
			bool flag15 = flag2;
			bool flag16 = flag;
			int num5 = 0;
			while (num5 < 30 && !process_0.HasExited)
			{
				try
				{
					Class95.smethod_26(process_0, byte_0);
					Class95.smethod_25(process_0, byte_0);
					if (Class95.smethod_24(process_0))
					{
						flag9 = true;
					}
				}
				catch
				{
				}
				Thread.Sleep(100);
				num5++;
			}
			@class.bool_1 = !process_0.HasExited && (Class95.smethod_24(process_0) || flag9);
			@class.bool_2 = flag15;
			@class.bool_3 = flag16;
			@class.bool_4 = flag4;
			@class.bool_5 = flag5;
			@class.bool_6 = flag6;
			@class.bool_7 = flag7;
			@class.bool_8 = flag8;
			@class.bool_0 = !process_0.HasExited && @class.bool_2 && flag4 && (@class.bool_1 || @class.bool_5 || @class.bool_6 || @class.bool_8);
			if (!@class.bool_0 && string.IsNullOrEmpty(@class.string_3))
			{
				@class.string_3 = string.Concat(new string[]
				{
					"Patch chua on dinh mutex=",
					flag4.ToString(),
					" mac=",
					@class.bool_1.ToString(),
					" multi=",
					@class.bool_2.ToString()
				});
			}
			stringBuilder_0.AppendLine(string.Concat(new string[]
			{
				"done ok=",
				@class.bool_0.ToString(),
				" mutex=",
				flag4.ToString(),
				" mac=",
				@class.bool_1.ToString(),
				" multi=",
				@class.bool_2.ToString(),
				" gai=",
				flag5.ToString(),
				" gaa=",
				flag6.ToString(),
				" git=",
				flag7.ToString(),
				" uuid=",
				flag8.ToString()
			}));
		}
		catch (Exception ex)
		{
			@class.string_3 = ex.Message;
			@class.bool_0 = false;
			stringBuilder_0.AppendLine(ex.ToString());
		}
		@class.string_2 = Class95.smethod_18(string_0, stringBuilder_0);
		return @class;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
	private static void smethod_16(IntPtr intptr_0, int int_11)
	{
		string text = "A292F57D-84FD-4465-9A03-" + int_11.ToString("X12");
		if (text.Length > 36)
		{
			text = text.Substring(0, 36);
		}
		Class95.smethod_21(intptr_0, 6232324, Encoding.ASCII.GetBytes(text));
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0003BFF8 File Offset: 0x0003A1F8
	private static bool smethod_17(Process process_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = Class95.smethod_22(intPtr, 4795680, 1);
			flag = array != null && array[0] == 85;
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00034C5C File Offset: 0x00032E5C
	private static string smethod_18(string string_0, StringBuilder stringBuilder_0)
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

	// Token: 0x060007A3 RID: 1955 RVA: 0x0003C060 File Offset: 0x0003A260
	public static byte[] smethod_19()
	{
		byte[] array = new byte[6];
		Class95.random_0.NextBytes(array);
		array[0] = (byte)((array[0] & 252) | 2);
		return array;
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00034CE4 File Offset: 0x00032EE4
	private static string smethod_20(byte[] byte_0)
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

	// Token: 0x060007A5 RID: 1957 RVA: 0x0003C090 File Offset: 0x0003A290
	private static bool smethod_21(IntPtr intptr_0, int int_11, byte[] byte_0)
	{
		uint num;
		Class95.VirtualProtectEx(intptr_0, Class95.smethod_1(int_11), (uint)byte_0.Length, 64U, out num);
		int num2;
		bool flag = Class95.WriteProcessMemory(intptr_0, Class95.smethod_1(int_11), byte_0, byte_0.Length, out num2) && num2 == byte_0.Length;
		uint num3;
		Class95.VirtualProtectEx(intptr_0, Class95.smethod_1(int_11), (uint)byte_0.Length, num, out num3);
		return flag;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
	private static byte[] smethod_22(IntPtr intptr_0, int int_11, int int_12)
	{
		byte[] array = new byte[int_12];
		int num;
		if (Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(int_11), array, int_12, out num))
		{
			if (num == int_12)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x0003C114 File Offset: 0x0003A314
	private static bool smethod_23(Process process_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			Class95.smethod_16(intPtr, process_0.Id);
			byte[] array = Class95.smethod_22(intPtr, 4385227, 2);
			if (array != null)
			{
				if (array[0] == 117 || array[0] == 235)
				{
					return Class95.smethod_21(intPtr, 4385227, new byte[] { 235, 123 }) && Class95.smethod_21(intPtr, 4385245, new byte[] { byte.MaxValue }) && Class95.smethod_21(intPtr, 4387436, new byte[] { 144, 144, 144, 144, 144, 144 });
				}
			}
			flag = false;
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x0003C1EC File Offset: 0x0003A3EC
	private static bool smethod_24(Process process_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = Class95.smethod_22(intPtr, 4795680, 1);
			flag = array != null && array[0] == 233;
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x0003C254 File Offset: 0x0003A454
	private static void smethod_25(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Class95.smethod_21(intPtr, 6576016, byte_0);
			Class95.smethod_21(intPtr, 6576840, Encoding.ASCII.GetBytes(Class95.smethod_20(byte_0) + "\0"));
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0003C2D0 File Offset: 0x0003A4D0
	private static bool smethod_26(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag2;
		try
		{
			if (Class95.smethod_22(intPtr, 4795680, 1) != null)
			{
				if (Class95.smethod_22(intPtr, 4795680, 1)[0] == 85 || Class95.smethod_22(intPtr, 4795680, 1)[0] == 233)
				{
					bool flag = Class95.smethod_27(intPtr, byte_0);
					Class95.smethod_28(intPtr, byte_0);
					Class95.smethod_29(intPtr, byte_0);
					Class95.smethod_21(intPtr, 6576016, byte_0);
					Class95.smethod_21(intPtr, 6576840, Encoding.ASCII.GetBytes(Class95.smethod_20(byte_0) + "\0"));
					return flag;
				}
			}
			flag2 = false;
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag2;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x0003C3A0 File Offset: 0x0003A5A0
	private static bool smethod_27(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class95.smethod_22(intptr_0, 4795680, 5);
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
		IntPtr intPtr = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num3 = Class95.smethod_0(intPtr);
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
		if (!Class95.WriteProcessMemory(intptr_0, intPtr, list.ToArray(), list.Count, out num4))
		{
			return false;
		}
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - 4795685).CopyTo(array3, 1);
		return Class95.smethod_21(intptr_0, 4795680, array3);
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0003C538 File Offset: 0x0003A738
	private static void smethod_28(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class95.smethod_22(intptr_0, 4796032, 5);
		if (array != null && array[0] != 233)
		{
			if (array[0] == 85)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class95.smethod_20(byte_0) + "\0");
				IntPtr intPtr = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				int num = Class95.smethod_0(intPtr);
				byte[] array2 = new byte[32];
				Buffer.BlockCopy(bytes, 0, array2, 0, bytes.Length);
				int num2;
				if (!Class95.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
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
				if (!Class95.WriteProcessMemory(intptr_0, Class95.smethod_1(num5), list.ToArray(), list.Count, out num2))
				{
					return;
				}
				byte[] array3 = new byte[5];
				array3[0] = 233;
				byte[] array4 = array3;
				BitConverter.GetBytes(num5 - 4796037).CopyTo(array4, 1);
				Class95.smethod_21(intptr_0, 4796032, array4);
				return;
			}
		}
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0003C758 File Offset: 0x0003A958
	private static void smethod_29(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = Class95.smethod_22(intptr_0, 4796051, 7);
		if (array != null && array[0] == 15)
		{
			if (array[1] == 182)
			{
				IntPtr intPtr = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				uint num = (uint)Class95.smethod_0(intPtr);
				byte[] array2 = new byte[20];
				Class95.random_0.NextBytes(array2);
				Buffer.BlockCopy(byte_0, 0, array2, 0, 6);
				int num2;
				if (!Class95.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
				{
					return;
				}
				int[] array3 = new int[] { 0, 7, 14, 22, 30, 38 };
				for (int i = 0; i < 6; i++)
				{
					Class95.smethod_21(intptr_0, 4796051 + array3[i] + 3, BitConverter.GetBytes(num + (uint)i));
				}
				return;
			}
		}
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0003C82C File Offset: 0x0003AA2C
	private static bool smethod_30(int int_11, string string_0, out int int_12, out int int_13)
	{
		int_12 = 0;
		int_13 = 0;
		IntPtr intPtr = Class95.CreateToolhelp32Snapshot(24U, (uint)int_11);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			try
			{
				Class95.Struct12 @struct = default(Class95.Struct12);
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class95.Struct12));
				if (!Class95.Module32FirstW(intPtr, ref @struct))
				{
					return false;
				}
				while (!@struct.string_0.Equals(string_0, StringComparison.OrdinalIgnoreCase))
				{
					if (!Class95.Module32NextW(intPtr, ref @struct))
					{
						return false;
					}
				}
				int_12 = @struct.intptr_0.ToInt32();
				int_13 = (int)@struct.uint_5;
				return true;
			}
			finally
			{
				Class95.CloseHandle(intPtr);
			}
			return false;
		}
		return false;
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
	private static bool smethod_31(IntPtr intptr_0, string string_0, out int int_11, out int int_12)
	{
		int_11 = 0;
		int_12 = 0;
		Class95.Struct11 @struct = default(Class95.Struct11);
		int num;
		if (Class95.NtQueryInformationProcess(intptr_0, 0, ref @struct, Marshal.SizeOf(typeof(Class95.Struct11)), out num) != 0)
		{
			return false;
		}
		byte[] array = new byte[32];
		int num2;
		if (Class95.ReadProcessMemory(intptr_0, @struct.intptr_1, array, array.Length, out num2) && num2 >= 16)
		{
			int num3 = BitConverter.ToInt32(array, 12);
			byte[] array2 = new byte[8];
			if (Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num3 + 20), array2, 8, out num2))
			{
				if (num2 == 8)
				{
					int num4 = num3 + 20;
					int num5 = BitConverter.ToInt32(array2, 0);
					int num6 = 0;
					while (num6 < 128 && num5 != 0)
					{
						if (num5 == num4)
						{
							break;
						}
						byte[] array3 = new byte[48];
						if (!Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num5 - 8), array3, array3.Length, out num2) || num2 < 48)
						{
							break;
						}
						int num7 = BitConverter.ToInt32(array3, 24);
						int num8 = BitConverter.ToInt32(array3, 32);
						int num9 = (int)BitConverter.ToInt16(array3, 36);
						int num10 = BitConverter.ToInt32(array3, 40);
						if (num10 != 0 && num9 > 0 && num9 < 512)
						{
							byte[] array4 = new byte[num9];
							if (Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num10), array4, num9, out num2) && num2 == num9 && Encoding.Unicode.GetString(array4).Equals(string_0, StringComparison.OrdinalIgnoreCase))
							{
								int_11 = num7;
								int_12 = ((num8 > 0) ? num8 : 1048576);
								return true;
							}
						}
						byte[] array5 = new byte[4];
						if (!Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num5), array5, 4, out num2) || num2 != 4)
						{
							break;
						}
						num5 = BitConverter.ToInt32(array5, 0);
						num6++;
					}
					return false;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00007E2C File Offset: 0x0000602C
	private static bool smethod_32(IntPtr intptr_0, int int_11, string string_0, out int int_12, out int int_13)
	{
		return Class95.smethod_30(int_11, string_0, out int_12, out int_13) || Class95.smethod_31(intptr_0, string_0, out int_12, out int_13) || Class95.smethod_35(intptr_0, string_0, out int_12, out int_13);
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
	private static void smethod_33(IntPtr intptr_0, int int_11, string string_0)
	{
		try
		{
			int num;
			int num2;
			if (Class95.smethod_32(intptr_0, int_11, "kernel32.dll", out num, out num2))
			{
				IntPtr intPtr = Class95.smethod_37(intptr_0, Class95.smethod_1(num), "LoadLibraryA");
				if (!(intPtr == IntPtr.Zero))
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_0 + "\0");
					IntPtr intPtr2 = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)bytes.Length, 12288U, 64U);
					if (!(intPtr2 == IntPtr.Zero))
					{
						int num3;
						if (Class95.WriteProcessMemory(intptr_0, intPtr2, bytes, bytes.Length, out num3))
						{
							uint num4;
							IntPtr intPtr3 = Class95.CreateRemoteThread(intptr_0, IntPtr.Zero, 0U, intPtr, intPtr2, 0U, out num4);
							if (!(intPtr3 == IntPtr.Zero))
							{
								Class95.WaitForSingleObject(intPtr3, 3000U);
								Class95.CloseHandle(intPtr3);
							}
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00007E54 File Offset: 0x00006054
	private static bool smethod_34(IntPtr intptr_0, int int_11, string string_0, out int int_12, out int int_13)
	{
		if (Class95.smethod_32(intptr_0, int_11, string_0, out int_12, out int_13))
		{
			return true;
		}
		Class95.smethod_33(intptr_0, int_11, string_0);
		return Class95.smethod_32(intptr_0, int_11, string_0, out int_12, out int_13);
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0003CB88 File Offset: 0x0003AD88
	private static bool smethod_35(IntPtr intptr_0, string string_0, out int int_11, out int int_12)
	{
		int_11 = 0;
		int_12 = 0;
		IntPtr[] array = new IntPtr[1024];
		int num;
		bool flag = Class95.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 1U) || Class95.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 3U);
		if (!flag)
		{
			flag = Class95.EnumProcessModules(intptr_0, array, array.Length * IntPtr.Size, out num);
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
			Class95.GetModuleBaseNameA(intptr_0, array[num3], stringBuilder, 260);
			if (!stringBuilder.ToString().Equals(string_0, StringComparison.OrdinalIgnoreCase))
			{
				num3++;
			}
			else
			{
				Class95.Struct8 @struct;
				if (!Class95.GetModuleInformation(intptr_0, array[num3], out @struct, Marshal.SizeOf(typeof(Class95.Struct8))))
				{
					return false;
				}
				int_11 = Class95.smethod_0(@struct.intptr_0);
				int_12 = (int)@struct.uint_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0003CC74 File Offset: 0x0003AE74
	private static IntPtr smethod_36(IntPtr intptr_0, int int_11, string string_0, string string_1)
	{
		int num;
		int num2;
		if (!Class95.smethod_32(intptr_0, int_11, string_0, out num, out num2))
		{
			return IntPtr.Zero;
		}
		return Class95.smethod_37(intptr_0, Class95.smethod_1(num), string_1);
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0003CCA4 File Offset: 0x0003AEA4
	private static IntPtr smethod_37(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		int num = Class95.smethod_0(intptr_1);
		byte[] array = new byte[4096];
		int num2;
		if (!Class95.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num2))
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
		if (!Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num + num4), array2, array2.Length, out num2))
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
			if (Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num + num6 + i * 4), array3, 4, out num2))
			{
				int num9 = BitConverter.ToInt32(array3, 0);
				byte[] array4 = new byte[64];
				if (Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num + num9), array4, 64, out num2))
				{
					int num10 = Array.IndexOf<byte>(array4, 0);
					if (!(Encoding.ASCII.GetString(array4, 0, (num10 < 0) ? array4.Length : num10) != string_0))
					{
						byte[] array5 = new byte[2];
						if (!Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num + num7 + i * 2), array5, 2, out num2))
						{
							return IntPtr.Zero;
						}
						ushort num11 = BitConverter.ToUInt16(array5, 0);
						byte[] array6 = new byte[4];
						if (!Class95.ReadProcessMemory(intptr_0, Class95.smethod_1(num + num8 + (int)(num11 * 4)), array6, 4, out num2))
						{
							return IntPtr.Zero;
						}
						return Class95.smethod_1(num + BitConverter.ToInt32(array6, 0));
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0003CE68 File Offset: 0x0003B068
	private static bool smethod_38(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_1)
	{
		int num = Class95.smethod_0(intptr_1);
		int num2 = Class95.smethod_0(intptr_2);
		int num3 = Class95.smethod_0(intptr_3);
		byte[] array = new byte[10];
		Array.Copy(byte_0, array, 5);
		array[5] = 233;
		BitConverter.GetBytes(num + 5 - (num2 + 10)).CopyTo(array, 6);
		int num4;
		Class95.WriteProcessMemory(intptr_0, intptr_2, array, 10, out num4);
		Class95.WriteProcessMemory(intptr_0, intptr_3, byte_1, byte_1.Length, out num4);
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - (num + 5)).CopyTo(array3, 1);
		uint num5;
		Class95.VirtualProtectEx(intptr_0, intptr_1, 8U, 64U, out num5);
		bool flag = Class95.WriteProcessMemory(intptr_0, intptr_1, array3, 5, out num4);
		Class95.VirtualProtectEx(intptr_0, intptr_1, 8U, num5, out num5);
		return flag;
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0003CF24 File Offset: 0x0003B124
	private static bool smethod_39(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_34(intPtr, process_0.Id, "rpcrt4.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "UuidCreateSequential");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class95.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							IntPtr intPtr3 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 16U, 12288U, 64U);
							if (intPtr3 == IntPtr.Zero)
							{
								return false;
							}
							int num4 = Class95.smethod_0(intPtr3);
							Class95.smethod_21(intPtr, num4, byte_0);
							IntPtr intPtr4 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr5 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
							if (!(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
							{
								int num5 = Class95.smethod_0(intPtr5);
								int num6 = Class95.smethod_0(intPtr4);
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
								list.AddRange(BitConverter.GetBytes(num4));
								list.AddRange(new byte[] { 137, 65, 10 });
								list.AddRange(new byte[] { 102, 161 });
								list.AddRange(BitConverter.GetBytes(num4 + 4));
								list.AddRange(new byte[] { 102, 137, 65, 14 });
								int count3 = list.Count;
								list.AddRange(new byte[] { 51, 192, 93, 194, 4, 0 });
								byte[] array3 = list.ToArray();
								BitConverter.GetBytes(num6 - (num5 + count + 5)).CopyTo(array3, count + 1);
								array3[count2 + 1] = (byte)(count3 - (count2 + 2));
								return Class95.smethod_38(intPtr, intPtr2, array, intPtr4, intPtr5, array3);
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
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0003D210 File Offset: 0x0003B410
	private static bool smethod_40(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "GetAdaptersInfo");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class95.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class95.smethod_0(intPtr4);
								int num7 = Class95.smethod_0(intPtr3);
								Class95.smethod_0(intPtr2);
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
								return Class95.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array4);
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
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
	private static bool smethod_41(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "GetAdaptersAddresses");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class95.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class95.smethod_0(intPtr4);
								int num7 = Class95.smethod_0(intPtr3);
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
								return Class95.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0003D9E0 File Offset: 0x0003BBE0
	private static bool smethod_42(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "GetIfTable");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (Class95.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = Class95.smethod_0(intPtr4);
								int num7 = Class95.smethod_0(intPtr3);
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
								return Class95.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0003DE1C File Offset: 0x0003C01C
	private static bool smethod_43(IntPtr intptr_0, int int_11)
	{
		IntPtr intPtr = Class95.smethod_36(intptr_0, int_11, "kernel32.dll", "ExitProcess");
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[1];
		int num;
		if (Class95.ReadProcessMemory(intptr_0, intPtr, array, 1, out num))
		{
			if (num == 1)
			{
				return array[0] == 233;
			}
		}
		return false;
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x0003DE70 File Offset: 0x0003C070
	private static bool smethod_44(IntPtr intptr_0, int int_11, int int_12, int int_13)
	{
		if (Class95.dictionary_0.ContainsKey(int_11))
		{
			Class95.smethod_45(intptr_0, int_11, int_12, int_13);
			return true;
		}
		IntPtr intPtr = Class95.smethod_36(intptr_0, int_11, "kernel32.dll", "ExitProcess");
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[5];
		int num;
		if (Class95.ReadProcessMemory(intptr_0, intPtr, array, 5, out num))
		{
			if (num == 5)
			{
				if (array[0] == 233)
				{
					return Class95.smethod_43(intptr_0, int_11);
				}
				IntPtr intPtr2 = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				IntPtr intPtr3 = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
				IntPtr intPtr4 = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 8U, 12288U, 64U);
				if (!(intPtr2 == IntPtr.Zero) && !(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
				{
					int num2 = Class95.smethod_0(intPtr2);
					int num3 = Class95.smethod_0(intPtr3);
					int num4 = Class95.smethod_0(intPtr4);
					int num5 = Class95.smethod_0(intPtr);
					int num6;
					Class95.WriteProcessMemory(intptr_0, intPtr4, BitConverter.GetBytes(int_12), 4, out num6);
					Class95.WriteProcessMemory(intptr_0, Class95.smethod_1(num4 + 4), BitConverter.GetBytes(int_12 + int_13), 4, out num6);
					byte[] array2 = new byte[10];
					Array.Copy(array, array2, 5);
					array2[5] = 233;
					BitConverter.GetBytes(num5 + 5 - (num2 + 10)).CopyTo(array2, 6);
					Class95.WriteProcessMemory(intptr_0, intPtr2, array2, 10, out num6);
					byte[] array3 = new byte[64];
					array3[0] = 96;
					array3[1] = 139;
					array3[2] = 68;
					array3[3] = 36;
					array3[4] = 32;
					array3[5] = 59;
					array3[6] = 5;
					BitConverter.GetBytes(num4).CopyTo(array3, 7);
					array3[11] = 114;
					array3[12] = 12;
					array3[13] = 59;
					array3[14] = 5;
					BitConverter.GetBytes(num4 + 4).CopyTo(array3, 15);
					array3[19] = 115;
					array3[20] = 4;
					array3[21] = 97;
					array3[22] = 194;
					array3[23] = 4;
					array3[24] = 0;
					array3[25] = 97;
					array3[26] = 233;
					BitConverter.GetBytes(num2 - (num3 + 27 + 4)).CopyTo(array3, 27);
					Class95.WriteProcessMemory(intptr_0, intPtr3, array3, 31, out num6);
					byte[] array4 = new byte[5];
					array4[0] = 233;
					byte[] array5 = array4;
					BitConverter.GetBytes(num3 - (num5 + 5)).CopyTo(array5, 1);
					uint num7;
					Class95.VirtualProtectEx(intptr_0, intPtr, 8U, 64U, out num7);
					bool flag = Class95.WriteProcessMemory(intptr_0, intPtr, array5, 5, out num6);
					Class95.VirtualProtectEx(intptr_0, intPtr, 8U, num7, out num7);
					if (flag)
					{
						Class95.dictionary_0[int_11] = intPtr4;
					}
					return flag;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x0003E11C File Offset: 0x0003C31C
	private static void smethod_45(IntPtr intptr_0, int int_11, int int_12, int int_13)
	{
		IntPtr intPtr;
		if (!Class95.dictionary_0.TryGetValue(int_11, out intPtr))
		{
			return;
		}
		int num;
		Class95.WriteProcessMemory(intptr_0, intPtr, BitConverter.GetBytes(int_12), 4, out num);
		Class95.WriteProcessMemory(intptr_0, Class95.smethod_1(Class95.smethod_0(intPtr) + 4), BitConverter.GetBytes(int_12 + int_13), 4, out num);
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0003E16C File Offset: 0x0003C36C
	private static bool smethod_46(Process process_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_32(intPtr, process_0.Id, "Plugin_ClientManager.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				flag = Class95.smethod_44(intPtr, process_0.Id, num, num2);
			}
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
	private static bool smethod_47(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[5];
		int num;
		if (Class95.ReadProcessMemory(intptr_0, intptr_1, array, 5, out num))
		{
			if (num == 5)
			{
				if (array[0] == 233)
				{
					return true;
				}
				IntPtr intPtr = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				IntPtr intPtr2 = Class95.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (!(intPtr == IntPtr.Zero) && !(intPtr2 == IntPtr.Zero))
				{
					int num2 = Class95.smethod_0(intptr_1);
					int num3 = Class95.smethod_0(intPtr);
					int num4 = Class95.smethod_0(intPtr2);
					byte[] array2 = new byte[10];
					Array.Copy(array, array2, 5);
					array2[5] = 233;
					BitConverter.GetBytes(num2 + 5 - (num3 + 10)).CopyTo(array2, 6);
					int num5;
					Class95.WriteProcessMemory(intptr_0, intPtr, array2, 10, out num5);
					List<byte> list = new List<byte>();
					list.AddRange(new byte[] { 85, 139, 236 });
					list.AddRange(new byte[] { 139, 69, 12, 133, 192 });
					int count = list.Count;
					List<byte> list2 = list;
					byte[] array3 = new byte[2];
					array3[0] = 116;
					list2.AddRange(array3);
					list.AddRange(new byte[] { 129, 56, 71, 97, 109, 101 });
					int count2 = list.Count;
					List<byte> list3 = list;
					byte[] array4 = new byte[2];
					array4[0] = 117;
					list3.AddRange(array4);
					list.AddRange(new byte[] { 184, 1, 0, 0, 0, 93, 194, 16, 0 });
					int count3 = list.Count;
					list.AddRange(new byte[] { 139, 69, 16, 133, 192 });
					int count4 = list.Count;
					List<byte> list4 = list;
					byte[] array5 = new byte[2];
					array5[0] = 116;
					list4.AddRange(array5);
					list.AddRange(new byte[] { 102, 129, 56, 84, 0 });
					int count5 = list.Count;
					List<byte> list5 = list;
					byte[] array6 = new byte[2];
					array6[0] = 117;
					list5.AddRange(array6);
					list.AddRange(new byte[] { 102, 129, 120, 2, 78, 0 });
					int count6 = list.Count;
					List<byte> list6 = list;
					byte[] array7 = new byte[2];
					array7[0] = 117;
					list6.AddRange(array7);
					list.AddRange(new byte[] { 102, 129, 120, 4, 67, 0 });
					int count7 = list.Count;
					List<byte> list7 = list;
					byte[] array8 = new byte[2];
					array8[0] = 117;
					list7.AddRange(array8);
					list.AddRange(new byte[] { 102, 129, 120, 6, 76, 0 });
					int count8 = list.Count;
					List<byte> list8 = list;
					byte[] array9 = new byte[2];
					array9[0] = 117;
					list8.AddRange(array9);
					list.AddRange(new byte[] { 184, 1, 0, 0, 0, 93, 194, 16, 0 });
					int count9 = list.Count;
					list.AddRange(new byte[]
					{
						byte.MaxValue, 117, 20, byte.MaxValue, 117, 16, byte.MaxValue, 117, 12, byte.MaxValue,
						117, 8
					});
					int count10 = list.Count;
					list.Add(232);
					list.AddRange(BitConverter.GetBytes(0));
					list.AddRange(new byte[] { 93, 194, 16, 0 });
					byte[] array10 = list.ToArray();
					array10[count + 1] = (byte)(count3 - (count + 2));
					array10[count2 + 1] = (byte)(count3 - (count2 + 2));
					array10[count4 + 1] = (byte)(count9 - (count4 + 2));
					array10[count5 + 1] = (byte)(count9 - (count5 + 2));
					array10[count6 + 1] = (byte)(count9 - (count6 + 2));
					array10[count7 + 1] = (byte)(count9 - (count7 + 2));
					array10[count8 + 1] = (byte)(count9 - (count8 + 2));
					BitConverter.GetBytes(num3 - (num4 + count10 + 5)).CopyTo(array10, count10 + 1);
					Class95.WriteProcessMemory(intptr_0, intPtr2, array10, array10.Length, out num5);
					byte[] array11 = new byte[5];
					array11[0] = 233;
					byte[] array12 = array11;
					BitConverter.GetBytes(num4 - (num2 + 5)).CopyTo(array12, 1);
					uint num6;
					Class95.VirtualProtectEx(intptr_0, intptr_1, 8U, 64U, out num6);
					bool flag = Class95.WriteProcessMemory(intptr_0, intptr_1, array12, 5, out num5);
					Class95.VirtualProtectEx(intptr_0, intptr_1, 8U, num6, out num6);
					return flag;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
	private static void smethod_48(Process process_0)
	{
		Class95.Class98 @class = new Class95.Class98();
		if (process_0 == null)
		{
			return;
		}
		@class.int_0 = process_0.Id;
		new Thread(new ThreadStart(@class.method_0))
		{
			IsBackground = true,
			Name = "TnclGameNameFix",
			Priority = ThreadPriority.Highest
		}.Start();
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x0003E628 File Offset: 0x0003C828
	private static bool smethod_49(Process process_0)
	{
		if (process_0 == null || process_0.HasExited)
		{
			return false;
		}
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			if (Class95.smethod_50(intPtr, process_0.Id, out num) && num != 0)
			{
				IntPtr intPtr2;
				int num2;
				if (Class95.NtQueryInformationProcess_1(intPtr, 26, out intPtr2, IntPtr.Size, out num2) == 0 && !(intPtr2 == IntPtr.Zero))
				{
					int num3 = Class95.smethod_0(intPtr2);
					byte[] array = Class95.smethod_22(intPtr, num3 + 12, 4);
					if (array == null)
					{
						flag = false;
					}
					else
					{
						int num4 = BitConverter.ToInt32(array, 0);
						if (num4 == 0)
						{
							flag = false;
						}
						else
						{
							int num5 = num4 + 12;
							byte[] array2 = Class95.smethod_22(intPtr, num5, 4);
							if (array2 == null)
							{
								flag = false;
							}
							else
							{
								int num6 = BitConverter.ToInt32(array2, 0);
								byte[] bytes = Encoding.Unicode.GetBytes("Game.exe\0");
								int num7 = 0;
								while (num7 < 128 && num6 != 0)
								{
									if (num6 == num5)
									{
										break;
									}
									byte[] array3 = Class95.smethod_22(intPtr, num6, 52);
									if (array3 == null)
									{
										return false;
									}
									if (BitConverter.ToInt32(array3, 24) == num)
									{
										ushort num8 = BitConverter.ToUInt16(array3, 46);
										int num9 = BitConverter.ToInt32(array3, 48);
										if (num9 == 0 || (int)num8 < bytes.Length)
										{
											return false;
										}
										if (!Class95.smethod_21(intPtr, num9, bytes))
										{
											return false;
										}
										return Class95.smethod_21(intPtr, num6 + 44, BitConverter.GetBytes(16));
									}
									else
									{
										num6 = BitConverter.ToInt32(array3, 0);
										num7++;
									}
								}
								flag = false;
							}
						}
					}
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
	private static bool smethod_50(IntPtr intptr_0, int int_11, out int int_12)
	{
		int_12 = 0;
		string text = null;
		try
		{
			using (Process processById = Process.GetProcessById(int_11))
			{
				text = Path.GetFileName(processById.MainModule.FileName);
			}
		}
		catch
		{
		}
		int num;
		if (!string.IsNullOrEmpty(text) && Class95.smethod_32(intptr_0, int_11, text, out int_12, out num) && int_12 != 0)
		{
			return true;
		}
		IntPtr intPtr = Class95.CreateToolhelp32Snapshot(24U, (uint)int_11);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			bool flag;
			try
			{
				Class95.Struct12 @struct = default(Class95.Struct12);
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class95.Struct12));
				if (!Class95.Module32FirstW(intPtr, ref @struct))
				{
					flag = false;
				}
				else
				{
					int_12 = @struct.intptr_0.ToInt32();
					flag = int_12 != 0;
				}
			}
			finally
			{
				Class95.CloseHandle(intPtr);
			}
			return flag;
		}
		return false;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
	private static int smethod_51(byte[] byte_0)
	{
		if (byte_0 == null || byte_0.Length < 6)
		{
			return 0;
		}
		if (byte_0[0] == 233)
		{
			return -1;
		}
		if (byte_0[0] == 139 && byte_0[1] == 255 && byte_0[2] == 85 && byte_0[3] == 139 && byte_0[4] == 236 && byte_0[5] == 93)
		{
			return 6;
		}
		if (byte_0[0] == 139 && byte_0[1] == 255 && byte_0[2] == 85 && byte_0[3] == 139 && byte_0[4] == 236)
		{
			return 5;
		}
		if (byte_0[0] == 85 && byte_0[1] == 139 && byte_0[2] == 236 && byte_0[3] == 93 && byte_0[4] == 255 && byte_0[5] == 37)
		{
			return 6;
		}
		if (byte_0[0] == 255 && byte_0[1] == 37)
		{
			return 6;
		}
		if (byte_0[0] == 85 && byte_0[1] == 139 && byte_0[2] == 236)
		{
			if (byte_0.Length >= 7 && byte_0[3] == 139 && byte_0[4] == 255)
			{
				return 5;
			}
			if (byte_0.Length >= 6 && byte_0[3] == 131 && byte_0[4] == 236)
			{
				return 6;
			}
		}
		return 0;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x0003EA18 File Offset: 0x0003CC18
	private static bool smethod_52(Process process_0)
	{
		if (process_0 == null || process_0.HasExited)
		{
			return false;
		}
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			if (Class95.smethod_50(intPtr, process_0.Id, out num) && num != 0)
			{
				int num2;
				int num3;
				if (!Class95.smethod_32(intPtr, process_0.Id, "kernel32.dll", out num2, out num3))
				{
					flag = false;
				}
				else
				{
					IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num2), "GetModuleHandleA");
					if (intPtr2 == IntPtr.Zero)
					{
						flag = false;
					}
					else
					{
						int num4 = Class95.smethod_0(intPtr2);
						byte[] array = Class95.smethod_22(intPtr, num4, 16);
						if (array == null)
						{
							flag = false;
						}
						else
						{
							int num5 = Class95.smethod_51(array);
							if (num5 < 0)
							{
								flag = true;
							}
							else if (num5 < 5)
							{
								flag = false;
							}
							else
							{
								IntPtr intPtr3 = Class95.VirtualAllocEx(intPtr, IntPtr.Zero, 4096U, 12288U, 64U);
								if (intPtr3 == IntPtr.Zero)
								{
									flag = false;
								}
								else
								{
									int num6 = Class95.smethod_0(intPtr3);
									List<byte> list = new List<byte>();
									list.AddRange(new byte[] { 139, 68, 36, 4 });
									list.AddRange(new byte[] { 133, 192 });
									int count = list.Count;
									List<byte> list2 = list;
									byte[] array2 = new byte[2];
									array2[0] = 116;
									list2.AddRange(array2);
									list.AddRange(new byte[] { 129, 56, 71, 97, 109, 101 });
									int count2 = list.Count;
									List<byte> list3 = list;
									byte[] array3 = new byte[2];
									array3[0] = 117;
									list3.AddRange(array3);
									list.AddRange(new byte[] { 129, 120, 4, 46, 101, 120, 101 });
									int count3 = list.Count;
									List<byte> list4 = list;
									byte[] array4 = new byte[2];
									array4[0] = 117;
									list4.AddRange(array4);
									list.AddRange(new byte[] { 128, 120, 8, 0 });
									int count4 = list.Count;
									List<byte> list5 = list;
									byte[] array5 = new byte[2];
									array5[0] = 117;
									list5.AddRange(array5);
									list.Add(184);
									list.AddRange(BitConverter.GetBytes((uint)num));
									List<byte> list6 = list;
									byte[] array6 = new byte[3];
									array6[0] = 194;
									array6[1] = 4;
									list6.AddRange(array6);
									int count5 = list.Count;
									list[count + 1] = (byte)(count5 - (count + 2));
									list[count2 + 1] = (byte)(count5 - (count2 + 2));
									list[count3 + 1] = (byte)(count5 - (count3 + 2));
									list[count4 + 1] = (byte)(count5 - (count4 + 2));
									for (int i = 0; i < num5; i++)
									{
										list.Add(array[i]);
									}
									list.Add(233);
									int count6 = list.Count;
									list.AddRange(BitConverter.GetBytes(0));
									byte[] array7 = list.ToArray();
									BitConverter.GetBytes(num4 + num5 - (num6 + count6 + 4)).CopyTo(array7, count6);
									if (!Class95.smethod_21(intPtr, num6, array7))
									{
										flag = false;
									}
									else
									{
										byte[] array8 = new byte[num5];
										array8[0] = 233;
										BitConverter.GetBytes(num6 - (num4 + 5)).CopyTo(array8, 1);
										for (int j = 5; j < num5; j++)
										{
											array8[j] = 144;
										}
										flag = Class95.smethod_21(intPtr, num4, array8);
									}
								}
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
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0003ED9C File Offset: 0x0003CF9C
	private static bool smethod_53(Process process_0)
	{
		IntPtr intPtr = Class95.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!Class95.smethod_32(intPtr, process_0.Id, "user32.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "MessageBoxW");
				IntPtr intPtr3 = Class95.smethod_37(intPtr, Class95.smethod_1(num), "MessageBoxA");
				bool flag2 = Class95.smethod_47(intPtr, intPtr2);
				bool flag3 = Class95.smethod_47(intPtr, intPtr3);
				flag = flag2 || flag3;
			}
		}
		finally
		{
			Class95.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0003EE44 File Offset: 0x0003D044
	[CompilerGenerated]
	internal static void smethod_54(string string_0, ref Class95.Struct13 struct13_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		try
		{
			string_0 = Path.GetFullPath(string_0);
			if (!struct13_0.list_0.Contains(string_0))
			{
				struct13_0.list_0.Add(string_0);
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000416 RID: 1046
	private const uint uint_0 = 2035711U;

	// Token: 0x04000417 RID: 1047
	private const uint uint_1 = 4096U;

	// Token: 0x04000418 RID: 1048
	private const uint uint_2 = 8192U;

	// Token: 0x04000419 RID: 1049
	private const uint uint_3 = 64U;

	// Token: 0x0400041A RID: 1050
	private const uint uint_4 = 258U;

	// Token: 0x0400041B RID: 1051
	private const uint uint_5 = 4U;

	// Token: 0x0400041C RID: 1052
	private const uint uint_6 = 1U;

	// Token: 0x0400041D RID: 1053
	private const uint uint_7 = 3U;

	// Token: 0x0400041E RID: 1054
	private const int int_0 = 6232324;

	// Token: 0x0400041F RID: 1055
	private const int int_1 = 4385227;

	// Token: 0x04000420 RID: 1056
	private const int int_2 = 4385245;

	// Token: 0x04000421 RID: 1057
	private const int int_3 = 4387436;

	// Token: 0x04000422 RID: 1058
	private const int int_4 = 4795680;

	// Token: 0x04000423 RID: 1059
	private const int int_5 = 4796032;

	// Token: 0x04000424 RID: 1060
	private const int int_6 = 4796051;

	// Token: 0x04000425 RID: 1061
	private const int int_7 = 6576016;

	// Token: 0x04000426 RID: 1062
	private const int int_8 = 6576840;

	// Token: 0x04000427 RID: 1063
	private const int int_9 = 6201668;

	// Token: 0x04000428 RID: 1064
	private static readonly Random random_0 = new Random();

	// Token: 0x04000429 RID: 1065
	private static readonly Dictionary<int, IntPtr> dictionary_0 = new Dictionary<int, IntPtr>();

	// Token: 0x0400042A RID: 1066
	private const int int_10 = 20000;

	// Token: 0x020000AE RID: 174
	public sealed class Class96
	{
		// Token: 0x0400042B RID: 1067
		public bool bool_0;

		// Token: 0x0400042C RID: 1068
		public int int_0;

		// Token: 0x0400042D RID: 1069
		public string string_0;

		// Token: 0x0400042E RID: 1070
		public byte[] byte_0;

		// Token: 0x0400042F RID: 1071
		public string string_1;

		// Token: 0x04000430 RID: 1072
		public bool bool_1;

		// Token: 0x04000431 RID: 1073
		public bool bool_2;

		// Token: 0x04000432 RID: 1074
		public bool bool_3;

		// Token: 0x04000433 RID: 1075
		public bool bool_4;

		// Token: 0x04000434 RID: 1076
		public bool bool_5;

		// Token: 0x04000435 RID: 1077
		public bool bool_6;

		// Token: 0x04000436 RID: 1078
		public bool bool_7;

		// Token: 0x04000437 RID: 1079
		public bool bool_8;

		// Token: 0x04000438 RID: 1080
		public string string_2;

		// Token: 0x04000439 RID: 1081
		public string string_3;
	}

	// Token: 0x020000AF RID: 175
	private struct Struct8
	{
		// Token: 0x0400043A RID: 1082
		public IntPtr intptr_0;

		// Token: 0x0400043B RID: 1083
		public uint uint_0;

		// Token: 0x0400043C RID: 1084
		public IntPtr intptr_1;
	}

	// Token: 0x020000B0 RID: 176
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct9
	{
		// Token: 0x0400043D RID: 1085
		public int int_0;

		// Token: 0x0400043E RID: 1086
		public IntPtr intptr_0;

		// Token: 0x0400043F RID: 1087
		public IntPtr intptr_1;

		// Token: 0x04000440 RID: 1088
		public IntPtr intptr_2;

		// Token: 0x04000441 RID: 1089
		public int int_1;

		// Token: 0x04000442 RID: 1090
		public int int_2;

		// Token: 0x04000443 RID: 1091
		public int int_3;

		// Token: 0x04000444 RID: 1092
		public int int_4;

		// Token: 0x04000445 RID: 1093
		public int int_5;

		// Token: 0x04000446 RID: 1094
		public int int_6;

		// Token: 0x04000447 RID: 1095
		public int int_7;

		// Token: 0x04000448 RID: 1096
		public int int_8;

		// Token: 0x04000449 RID: 1097
		public short short_0;

		// Token: 0x0400044A RID: 1098
		public short short_1;

		// Token: 0x0400044B RID: 1099
		public IntPtr intptr_3;

		// Token: 0x0400044C RID: 1100
		public IntPtr intptr_4;

		// Token: 0x0400044D RID: 1101
		public IntPtr intptr_5;

		// Token: 0x0400044E RID: 1102
		public IntPtr intptr_6;
	}

	// Token: 0x020000B1 RID: 177
	private struct Struct10
	{
		// Token: 0x0400044F RID: 1103
		public IntPtr intptr_0;

		// Token: 0x04000450 RID: 1104
		public IntPtr intptr_1;

		// Token: 0x04000451 RID: 1105
		public int int_0;

		// Token: 0x04000452 RID: 1106
		public int int_1;
	}

	// Token: 0x020000B2 RID: 178
	private struct Struct11
	{
		// Token: 0x04000453 RID: 1107
		public IntPtr intptr_0;

		// Token: 0x04000454 RID: 1108
		public IntPtr intptr_1;

		// Token: 0x04000455 RID: 1109
		public IntPtr intptr_2;

		// Token: 0x04000456 RID: 1110
		public IntPtr intptr_3;

		// Token: 0x04000457 RID: 1111
		public IntPtr intptr_4;

		// Token: 0x04000458 RID: 1112
		public IntPtr intptr_5;
	}

	// Token: 0x020000B3 RID: 179
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct12
	{
		// Token: 0x04000459 RID: 1113
		public uint uint_0;

		// Token: 0x0400045A RID: 1114
		public uint uint_1;

		// Token: 0x0400045B RID: 1115
		public uint uint_2;

		// Token: 0x0400045C RID: 1116
		public uint uint_3;

		// Token: 0x0400045D RID: 1117
		public uint uint_4;

		// Token: 0x0400045E RID: 1118
		public IntPtr intptr_0;

		// Token: 0x0400045F RID: 1119
		public uint uint_5;

		// Token: 0x04000460 RID: 1120
		public IntPtr intptr_1;

		// Token: 0x04000461 RID: 1121
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x04000462 RID: 1122
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x020000B4 RID: 180
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct13
	{
		// Token: 0x04000463 RID: 1123
		public List<string> list_0;
	}

	// Token: 0x020000B5 RID: 181
	[CompilerGenerated]
	private sealed class Class97
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x0003EE94 File Offset: 0x0003D094
		internal void method_0()
		{
			try
			{
				Class95.smethod_15(Process.GetProcessById(this.int_0), this.string_0, this.byte_0, this.stringBuilder_0);
			}
			catch (Exception ex)
			{
				this.stringBuilder_0.AppendLine("patch thread fail: " + ex.Message);
				Class95.smethod_18(this.string_0, this.stringBuilder_0);
			}
		}

		// Token: 0x04000464 RID: 1124
		public byte[] byte_0;

		// Token: 0x04000465 RID: 1125
		public StringBuilder stringBuilder_0;

		// Token: 0x04000466 RID: 1126
		public int int_0;

		// Token: 0x04000467 RID: 1127
		public string string_0;
	}

	// Token: 0x020000B6 RID: 182
	[CompilerGenerated]
	private sealed class Class98
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x0003EF08 File Offset: 0x0003D108
		internal void method_0()
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			while (stopwatch.ElapsedMilliseconds < 10000L)
			{
				try
				{
					Process processById = Process.GetProcessById(this.int_0);
					if (processById.HasExited)
					{
						break;
					}
					if (Class95.smethod_49(processById) || Class95.smethod_52(processById))
					{
						break;
					}
				}
				catch
				{
					break;
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x04000468 RID: 1128
		public int int_0;
	}
}
