using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020000B7 RID: 183
public sealed class GClass32
{
	// Token: 0x060007CE RID: 1998
	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x060007CF RID: 1999
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CreateProcess(string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_7, IntPtr intptr_2, string string_1, ref GClass32.Struct15 struct15_0, out GClass32.Struct16 struct16_0);

	// Token: 0x060007D0 RID: 2000
	[DllImport("kernel32.dll")]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_7);

	// Token: 0x060007D1 RID: 2001
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_7, bool bool_0, int int_11);

	// Token: 0x060007D2 RID: 2002
	[DllImport("kernel32.dll")]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, uint uint_8, uint uint_9);

	// Token: 0x060007D3 RID: 2003
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_11, out int int_12);

	// Token: 0x060007D4 RID: 2004
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_11, out int int_12);

	// Token: 0x060007D5 RID: 2005
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, uint uint_8, out uint uint_9);

	// Token: 0x060007D6 RID: 2006
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_7, uint uint_8);

	// Token: 0x060007D7 RID: 2007
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_0, ref GClass32.Struct18 struct18_0);

	// Token: 0x060007D8 RID: 2008
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_0, ref GClass32.Struct18 struct18_0);

	// Token: 0x060007D9 RID: 2009
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_7, IntPtr intptr_2, IntPtr intptr_3, uint uint_8, out uint uint_9);

	// Token: 0x060007DA RID: 2010
	[DllImport("ntdll.dll")]
	private static extern int NtQueryInformationProcess(IntPtr intptr_0, int int_11, ref GClass32.Struct17 struct17_0, int int_12, out int int_13);

	// Token: 0x060007DB RID: 2011
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModulesEx(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_11, out int int_12, uint uint_7);

	// Token: 0x060007DC RID: 2012
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool EnumProcessModules(IntPtr intptr_0, [Out] IntPtr[] intptr_1, int int_11, out int int_12);

	// Token: 0x060007DD RID: 2013
	[DllImport("psapi.dll", CharSet = CharSet.Ansi)]
	private static extern uint GetModuleBaseNameA(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_11);

	// Token: 0x060007DE RID: 2014
	[DllImport("psapi.dll")]
	private static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out GClass32.Struct14 struct14_0, int int_11);

	// Token: 0x060007DF RID: 2015 RVA: 0x00007CD7 File Offset: 0x00005ED7
	private static int smethod_0(IntPtr intptr_0)
	{
		return (int)intptr_0.ToInt64();
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00007CE1 File Offset: 0x00005EE1
	private static IntPtr smethod_1(int int_11)
	{
		return new IntPtr((long)((ulong)int_11));
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00007E8E File Offset: 0x0000608E
	public static GClass32.GClass33 smethod_2(string string_0, string string_1 = "-fl")
	{
		return GClass32.smethod_9(string_0, string_1, null, false);
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00007E99 File Offset: 0x00006099
	public static GClass32.GClass33 smethod_3(string string_0, string string_1, byte[] byte_0)
	{
		return GClass32.smethod_9(string_0, string_1, byte_0, false);
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00007EA4 File Offset: 0x000060A4
	public static GClass32.GClass33 smethod_4(string string_0, string string_1, string string_2 = "-fl")
	{
		if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(string_1))
		{
			return GClass32.smethod_9(Path.Combine(string_0, string_1), string_2, null, false);
		}
		return GClass32.smethod_12(string_0, "Thieu gameDir hoac exeName");
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00007E8E File Offset: 0x0000608E
	public static GClass32.GClass33 smethod_5(string string_0, string string_1 = "-fl")
	{
		return GClass32.smethod_9(string_0, string_1, null, false);
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00007ED1 File Offset: 0x000060D1
	public static GClass32.GClass33 smethod_6(string string_0, string string_1 = "-fl")
	{
		return GClass32.smethod_9(string_0, string_1, null, true);
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00007EDC File Offset: 0x000060DC
	public static GClass32.GClass33 smethod_7(string string_0, string string_1, byte[] byte_0)
	{
		return GClass32.smethod_9(string_0, string_1, byte_0, true);
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0003EF74 File Offset: 0x0003D174
	private static string smethod_8(string string_0, StringBuilder stringBuilder_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return null;
		}
		string_0 = string_0.Trim().Trim(new char[] { '"' });
		GClass32.Struct19 @struct;
		@struct.list_0 = new List<string>();
		if (string_0.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			GClass32.smethod_49(string_0, ref @struct);
			GClass32.smethod_49(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0), ref @struct);
			string directoryName = Path.GetDirectoryName(string_0);
			if (!string.IsNullOrEmpty(directoryName))
			{
				GClass32.smethod_49(Path.Combine(directoryName, Path.GetFileName(string_0)), ref @struct);
			}
		}
		else if (Directory.Exists(string_0))
		{
			GClass32.smethod_49(Path.Combine(string_0, "Game.exe"), ref @struct);
			// game root folder: the client lives in Bin\Game.exe
			GClass32.smethod_49(Path.Combine(string_0, "Bin", "Game.exe"), ref @struct);
		}
		else
		{
			GClass32.smethod_49(string_0, ref @struct);
			GClass32.smethod_49(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0), ref @struct);
			if (!string_0.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				GClass32.smethod_49(Path.Combine(string_0, "Game.exe"), ref @struct);
				GClass32.smethod_49(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0, "Game.exe"), ref @struct);
				GClass32.smethod_49(Path.Combine(string_0, "Bin", "Game.exe"), ref @struct);
				GClass32.smethod_49(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0, "Bin", "Game.exe"), ref @struct);
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

	// Token: 0x060007E8 RID: 2024 RVA: 0x0003F150 File Offset: 0x0003D350
	private static GClass32.GClass33 smethod_9(string string_0, string string_1, byte[] byte_0, bool bool_0)
	{
		GClass32.GClass33 gclass = new GClass32.GClass33();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("hostBits=" + (IntPtr.Size * 8).ToString());
		stringBuilder.AppendLine("input=" + string_0);
		string text = GClass32.smethod_8(string_0, stringBuilder);
		if (text == null)
		{
			gclass.string_3 = "Khong tim thay file game: " + string_0;
			gclass.string_2 = GClass32.smethod_18(string_0, stringBuilder);
			return gclass;
		}
		gclass.string_0 = text;
		string text2 = Path.GetDirectoryName(text) ?? ".";
		string_1 = (string.IsNullOrWhiteSpace(string_1) ? "-fl" : string_1);
		stringBuilder.AppendLine("mode=in-process waitPatch=" + bool_0.ToString());
		GClass32.smethod_18(text, stringBuilder);
		return GClass32.smethod_13(text, text2, string_1, byte_0, bool_0, stringBuilder, gclass);
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00007EE7 File Offset: 0x000060E7
	public static GClass32.GClass33 smethod_10(int int_11)
	{
		return GClass32.smethod_11(int_11, null);
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0003F238 File Offset: 0x0003D438
	public static GClass32.GClass33 smethod_11(int int_11, string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		stringBuilder.AppendLine("mode=attach pid=" + int_11.ToString());
		Process processById;
		GClass32.GClass33 gclass;
		try
		{
			processById = Process.GetProcessById(int_11);
			goto IL_0060;
		}
		catch
		{
			gclass = GClass32.smethod_12(string_0, "Process khong ton tai pid=" + int_11.ToString());
		}
		return gclass;
		IL_0060:
		if (processById.HasExited)
		{
			return GClass32.smethod_12(string_0, "Process da thoat pid=" + int_11.ToString());
		}
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
		byte[] array = GClass32.smethod_19();
		array[0] = (byte)((array[0] & 252) | 2);
		stringBuilder.AppendLine("fakeMac=" + GClass32.smethod_20(array));
		GClass32.smethod_18(text, stringBuilder);
		GClass32.GClass33 gclass2 = GClass32.smethod_15(processById, text, array, stringBuilder);
		gclass2.string_0 = text;
		return gclass2;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00007EF0 File Offset: 0x000060F0
	private static GClass32.GClass33 smethod_12(string string_0, string string_1)
	{
		return new GClass32.GClass33
		{
			string_3 = string_1,
			string_2 = GClass32.smethod_18(string_0, new StringBuilder(string_1))
		};
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0003F360 File Offset: 0x0003D560
	private static GClass32.GClass33 smethod_13(string string_0, string string_1, string string_2, byte[] byte_0, bool bool_0, StringBuilder stringBuilder_0, GClass32.GClass33 gclass33_0)
	{
		GClass32.Class99 @class = new GClass32.Class99();
		@class.stringBuilder_0 = stringBuilder_0;
		Process process = GClass32.smethod_14(string_0, string_1, string_2, @class.stringBuilder_0);
		if (process == null)
		{
			gclass33_0.string_3 = "Start Game that bai, xem TnclGameLaunch.log";
			gclass33_0.string_2 = GClass32.smethod_18(string_0, @class.stringBuilder_0);
			return gclass33_0;
		}
		gclass33_0.int_0 = process.Id;
		gclass33_0.bool_0 = true;
		gclass33_0.string_0 = string_0;
		@class.stringBuilder_0.AppendLine("pid=" + gclass33_0.int_0.ToString());
		GClass32.smethod_18(string_0, @class.stringBuilder_0);
		@class.byte_0 = ((byte_0 == null || byte_0.Length < 6) ? GClass32.smethod_19() : ((byte[])byte_0.Clone()));
		if (@class.byte_0.Length > 6)
		{
			byte[] array = new byte[6];
			Array.Copy(@class.byte_0, array, 6);
			@class.byte_0 = array;
		}
		@class.byte_0[0] = (byte)((@class.byte_0[0] & 252) | 2);
		gclass33_0.byte_0 = @class.byte_0;
		gclass33_0.string_1 = GClass32.smethod_20(@class.byte_0);
		@class.stringBuilder_0.AppendLine("fakeMac=" + gclass33_0.string_1);
		if (!bool_0)
		{
			@class.stringBuilder_0.AppendLine("patch=background");
			GClass32.smethod_18(string_0, @class.stringBuilder_0);
			@class.int_0 = process.Id;
			@class.string_0 = string_0;
			new Thread(new ThreadStart(@class.method_0))
			{
				IsBackground = true,
				Name = "TnclPatch"
			}.Start();
			gclass33_0.string_2 = @class.stringBuilder_0.ToString();
			return gclass33_0;
		}
		return GClass32.smethod_15(process, string_0, @class.byte_0, @class.stringBuilder_0);
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x0003F51C File Offset: 0x0003D71C
	private static Process smethod_14(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0)
	{
		string_0 = Path.GetFullPath(string_0);
		string_1 = Path.GetFullPath(string_1);
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
				catch (Exception ex)
				{
					stringBuilder_0.AppendLine("start=Process.Start refresh fail " + ex.Message);
					return process;
				}
			}
		}
		catch (Exception ex2)
		{
			stringBuilder_0.AppendLine("start=Process.Start fail " + ex2.Message);
		}
		try
		{
			GClass32.Struct15 @struct = new GClass32.Struct15
			{
				int_0 = Marshal.SizeOf(typeof(GClass32.Struct15))
			};
			StringBuilder stringBuilder = new StringBuilder("\"" + string_0 + "\"");
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				stringBuilder.Append(" ").Append(string_2.Trim());
			}
			GClass32.Struct16 struct2;
			if (GClass32.CreateProcess(null, stringBuilder, IntPtr.Zero, IntPtr.Zero, false, 0U, IntPtr.Zero, string_1, ref @struct, out struct2))
			{
				GClass32.CloseHandle(struct2.intptr_1);
				GClass32.CloseHandle(struct2.intptr_0);
				stringBuilder_0.AppendLine("start=CreateProcess pid=" + struct2.int_0.ToString());
				return Process.GetProcessById(struct2.int_0);
			}
			stringBuilder_0.AppendLine("start=CreateProcess fail err=" + Marshal.GetLastWin32Error().ToString());
		}
		catch (Exception ex3)
		{
			stringBuilder_0.AppendLine("start=CreateProcess ex " + ex3.Message);
		}
		return null;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x0003F730 File Offset: 0x0003D930
	private static GClass32.GClass33 smethod_15(Process process_0, string string_0, byte[] byte_0, StringBuilder stringBuilder_0)
	{
		GClass32.GClass33 gclass = new GClass32.GClass33
		{
			int_0 = process_0.Id,
			bool_0 = true,
			string_0 = string_0,
			byte_0 = byte_0,
			string_1 = GClass32.smethod_20(byte_0)
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
			while (i < 400)
			{
				int num4 = (i + 1) * 50;
				if (!process_0.HasExited)
				{
					try
					{
						if (GClass32.smethod_48(process_0))
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
						if (GClass32.smethod_46(process_0))
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
							if (GClass32.smethod_40(process_0, byte_0))
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
							if (GClass32.smethod_41(process_0, byte_0))
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
							if (GClass32.smethod_39(process_0, byte_0))
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
							if (GClass32.smethod_42(process_0, byte_0))
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
							if (GClass32.smethod_17(process_0))
							{
								flag3 = true;
								num3 = num4;
								stringBuilder_0.AppendLine("unpacked t=" + num4.ToString() + " macNow mutex+" + 5500.ToString());
							}
						}
						catch
						{
						}
					}
					bool flag11 = flag3 && num3 >= 0 && num4 >= num3;
					bool flag12 = flag3 && num3 >= 0 && num4 >= num3 + 5500;
					if (flag11)
					{
						bool flag13 = GClass32.smethod_24(process_0);
						try
						{
							if (GClass32.smethod_26(process_0, byte_0))
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
						bool flag14 = GClass32.smethod_24(process_0);
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
							GClass32.smethod_25(process_0, byte_0);
						}
						catch
						{
						}
					}
					if (flag12 && !flag4)
					{
						try
						{
							if (GClass32.smethod_23(process_0))
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
						if (i % 20 == 19)
						{
							GClass32.smethod_18(string_0, stringBuilder_0);
						}
						Thread.Sleep(50);
						i++;
						continue;
					}
					stringBuilder_0.AppendLine("stable t=" + num4.ToString() + " restores=" + num2.ToString());
					GClass32.smethod_18(string_0, stringBuilder_0);
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
				gclass.string_3 = "Game thoat som";
				gclass.bool_0 = false;
				gclass.string_2 = GClass32.smethod_18(string_0, stringBuilder_0);
				return gclass;
			}
			bool flag15 = flag2;
			bool flag16 = flag;
			int num5 = 0;
			while (num5 < 30 && !process_0.HasExited)
			{
				try
				{
					GClass32.smethod_26(process_0, byte_0);
					GClass32.smethod_25(process_0, byte_0);
					if (GClass32.smethod_24(process_0))
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
			gclass.bool_1 = !process_0.HasExited && (GClass32.smethod_24(process_0) || flag9);
			gclass.bool_2 = flag15;
			gclass.bool_3 = flag16;
			gclass.bool_4 = flag4;
			gclass.bool_5 = flag5;
			gclass.bool_6 = flag6;
			gclass.bool_7 = flag7;
			gclass.bool_8 = flag8;
			gclass.bool_0 = !process_0.HasExited && gclass.bool_2 && flag4 && (gclass.bool_1 || gclass.bool_5 || gclass.bool_6 || gclass.bool_8);
			if (!gclass.bool_0 && string.IsNullOrEmpty(gclass.string_3))
			{
				gclass.string_3 = string.Concat(new string[]
				{
					"Patch chua on dinh mutex=",
					flag4.ToString(),
					" mac=",
					gclass.bool_1.ToString(),
					" multi=",
					gclass.bool_2.ToString()
				});
			}
			stringBuilder_0.AppendLine(string.Concat(new string[]
			{
				"done ok=",
				gclass.bool_0.ToString(),
				" mutex=",
				flag4.ToString(),
				" mac=",
				gclass.bool_1.ToString(),
				" multi=",
				gclass.bool_2.ToString(),
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
			gclass.string_3 = ex.Message;
			gclass.bool_0 = false;
			stringBuilder_0.AppendLine(ex.ToString());
		}
		gclass.string_2 = GClass32.smethod_18(string_0, stringBuilder_0);
		return gclass;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x0003FE44 File Offset: 0x0003E044
	private static void smethod_16(IntPtr intptr_0, int int_11)
	{
		string text = "A292F57D-84FD-4465-9A03-" + int_11.ToString("X12");
		if (text.Length > 36)
		{
			text = text.Substring(0, 36);
		}
		GClass32.smethod_21(intptr_0, 6232324, Encoding.ASCII.GetBytes(text));
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0003FE94 File Offset: 0x0003E094
	private static bool smethod_17(Process process_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = GClass32.smethod_22(intPtr, 4795680, 1);
			flag = array != null && array[0] == 85;
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00034C5C File Offset: 0x00032E5C
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

	// Token: 0x060007F2 RID: 2034 RVA: 0x0003FEFC File Offset: 0x0003E0FC
	public static byte[] smethod_19()
	{
		byte[] array = new byte[6];
		GClass32.random_0.NextBytes(array);
		array[0] = (byte)((array[0] & 252) | 2);
		return array;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00034CE4 File Offset: 0x00032EE4
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

	// Token: 0x060007F4 RID: 2036 RVA: 0x0003FF2C File Offset: 0x0003E12C
	private static bool smethod_21(IntPtr intptr_0, int int_11, byte[] byte_0)
	{
		uint num;
		GClass32.VirtualProtectEx(intptr_0, GClass32.smethod_1(int_11), (uint)byte_0.Length, 64U, out num);
		int num2;
		bool flag = GClass32.WriteProcessMemory(intptr_0, GClass32.smethod_1(int_11), byte_0, byte_0.Length, out num2) && num2 == byte_0.Length;
		uint num3;
		GClass32.VirtualProtectEx(intptr_0, GClass32.smethod_1(int_11), (uint)byte_0.Length, num, out num3);
		return flag;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0003FF80 File Offset: 0x0003E180
	private static byte[] smethod_22(IntPtr intptr_0, int int_11, int int_12)
	{
		byte[] array = new byte[int_12];
		int num;
		if (GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(int_11), array, int_12, out num))
		{
			if (num == int_12)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
	private static bool smethod_23(Process process_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			GClass32.smethod_16(intPtr, process_0.Id);
			byte[] array = GClass32.smethod_22(intPtr, 4385227, 2);
			if (array != null)
			{
				if (array[0] == 117 || array[0] == 235)
				{
					return GClass32.smethod_21(intPtr, 4385227, new byte[] { 235, 123 }) && GClass32.smethod_21(intPtr, 4385245, new byte[] { byte.MaxValue }) && GClass32.smethod_21(intPtr, 4387436, new byte[] { 144, 144, 144, 144, 144, 144 });
				}
			}
			flag = false;
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00040088 File Offset: 0x0003E288
	private static bool smethod_24(Process process_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			byte[] array = GClass32.smethod_22(intPtr, 4795680, 1);
			flag = array != null && array[0] == 233;
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x000400F0 File Offset: 0x0003E2F0
	private static void smethod_25(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			GClass32.smethod_21(intPtr, 6576016, byte_0);
			GClass32.smethod_21(intPtr, 6576840, Encoding.ASCII.GetBytes(GClass32.smethod_20(byte_0) + "\0"));
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0004016C File Offset: 0x0003E36C
	private static bool smethod_26(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag2;
		try
		{
			if (GClass32.smethod_22(intPtr, 4795680, 1) != null)
			{
				if (GClass32.smethod_22(intPtr, 4795680, 1)[0] == 85 || GClass32.smethod_22(intPtr, 4795680, 1)[0] == 233)
				{
					bool flag = GClass32.smethod_27(intPtr, byte_0);
					GClass32.smethod_28(intPtr, byte_0);
					GClass32.smethod_29(intPtr, byte_0);
					GClass32.smethod_21(intPtr, 6576016, byte_0);
					GClass32.smethod_21(intPtr, 6576840, Encoding.ASCII.GetBytes(GClass32.smethod_20(byte_0) + "\0"));
					return flag;
				}
			}
			flag2 = false;
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag2;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0004023C File Offset: 0x0003E43C
	private static bool smethod_27(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = GClass32.smethod_22(intptr_0, 4795680, 5);
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
		IntPtr intPtr = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num3 = GClass32.smethod_0(intPtr);
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
		if (!GClass32.WriteProcessMemory(intptr_0, intPtr, list.ToArray(), list.Count, out num4))
		{
			return false;
		}
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - 4795685).CopyTo(array3, 1);
		return GClass32.smethod_21(intptr_0, 4795680, array3);
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x000403D4 File Offset: 0x0003E5D4
	private static void smethod_28(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = GClass32.smethod_22(intptr_0, 4796032, 5);
		if (array != null && array[0] != 233)
		{
			if (array[0] == 85)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(GClass32.smethod_20(byte_0) + "\0");
				IntPtr intPtr = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				int num = GClass32.smethod_0(intPtr);
				byte[] array2 = new byte[32];
				Buffer.BlockCopy(bytes, 0, array2, 0, bytes.Length);
				int num2;
				if (!GClass32.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
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
				if (!GClass32.WriteProcessMemory(intptr_0, GClass32.smethod_1(num5), list.ToArray(), list.Count, out num2))
				{
					return;
				}
				byte[] array3 = new byte[5];
				array3[0] = 233;
				byte[] array4 = array3;
				BitConverter.GetBytes(num5 - 4796037).CopyTo(array4, 1);
				GClass32.smethod_21(intptr_0, 4796032, array4);
				return;
			}
		}
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x000405F4 File Offset: 0x0003E7F4
	private static void smethod_29(IntPtr intptr_0, byte[] byte_0)
	{
		byte[] array = GClass32.smethod_22(intptr_0, 4796051, 7);
		if (array != null && array[0] == 15)
		{
			if (array[1] == 182)
			{
				IntPtr intPtr = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				if (intPtr == IntPtr.Zero)
				{
					return;
				}
				uint num = (uint)GClass32.smethod_0(intPtr);
				byte[] array2 = new byte[20];
				GClass32.random_0.NextBytes(array2);
				Buffer.BlockCopy(byte_0, 0, array2, 0, 6);
				int num2;
				if (!GClass32.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num2))
				{
					return;
				}
				int[] array3 = new int[] { 0, 7, 14, 22, 30, 38 };
				for (int i = 0; i < 6; i++)
				{
					GClass32.smethod_21(intptr_0, 4796051 + array3[i] + 3, BitConverter.GetBytes(num + (uint)i));
				}
				return;
			}
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x000406C8 File Offset: 0x0003E8C8
	private static bool smethod_30(int int_11, string string_0, out int int_12, out int int_13)
	{
		int_12 = 0;
		int_13 = 0;
		IntPtr intPtr = GClass32.CreateToolhelp32Snapshot(24U, (uint)int_11);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			try
			{
				GClass32.Struct18 @struct = default(GClass32.Struct18);
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(GClass32.Struct18));
				if (!GClass32.Module32FirstW(intPtr, ref @struct))
				{
					return false;
				}
				while (!@struct.string_0.Equals(string_0, StringComparison.OrdinalIgnoreCase))
				{
					if (!GClass32.Module32NextW(intPtr, ref @struct))
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
				GClass32.CloseHandle(intPtr);
			}
			return false;
		}
		return false;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00040780 File Offset: 0x0003E980
	private static bool smethod_31(IntPtr intptr_0, string string_0, out int int_11, out int int_12)
	{
		int_11 = 0;
		int_12 = 0;
		GClass32.Struct17 @struct = default(GClass32.Struct17);
		int num;
		if (GClass32.NtQueryInformationProcess(intptr_0, 0, ref @struct, Marshal.SizeOf(typeof(GClass32.Struct17)), out num) != 0)
		{
			return false;
		}
		byte[] array = new byte[32];
		int num2;
		if (GClass32.ReadProcessMemory(intptr_0, @struct.intptr_1, array, array.Length, out num2) && num2 >= 16)
		{
			int num3 = BitConverter.ToInt32(array, 12);
			byte[] array2 = new byte[8];
			if (GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num3 + 20), array2, 8, out num2))
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
						if (!GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num5 - 8), array3, array3.Length, out num2) || num2 < 48)
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
							if (GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num10), array4, num9, out num2) && num2 == num9 && Encoding.Unicode.GetString(array4).Equals(string_0, StringComparison.OrdinalIgnoreCase))
							{
								int_11 = num7;
								int_12 = ((num8 > 0) ? num8 : 1048576);
								return true;
							}
						}
						byte[] array5 = new byte[4];
						if (!GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num5), array5, 4, out num2) || num2 != 4)
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

	// Token: 0x060007FF RID: 2047 RVA: 0x00007F10 File Offset: 0x00006110
	private static bool smethod_32(IntPtr intptr_0, int int_11, string string_0, out int int_12, out int int_13)
	{
		return GClass32.smethod_30(int_11, string_0, out int_12, out int_13) || GClass32.smethod_31(intptr_0, string_0, out int_12, out int_13) || GClass32.smethod_35(intptr_0, string_0, out int_12, out int_13);
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x0004093C File Offset: 0x0003EB3C
	private static void smethod_33(IntPtr intptr_0, int int_11, string string_0)
	{
		try
		{
			int num;
			int num2;
			if (GClass32.smethod_32(intptr_0, int_11, "kernel32.dll", out num, out num2))
			{
				IntPtr intPtr = GClass32.smethod_37(intptr_0, GClass32.smethod_1(num), "LoadLibraryA");
				if (!(intPtr == IntPtr.Zero))
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_0 + "\0");
					IntPtr intPtr2 = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)bytes.Length, 12288U, 64U);
					if (!(intPtr2 == IntPtr.Zero))
					{
						int num3;
						if (GClass32.WriteProcessMemory(intptr_0, intPtr2, bytes, bytes.Length, out num3))
						{
							uint num4;
							IntPtr intPtr3 = GClass32.CreateRemoteThread(intptr_0, IntPtr.Zero, 0U, intPtr, intPtr2, 0U, out num4);
							if (!(intPtr3 == IntPtr.Zero))
							{
								GClass32.WaitForSingleObject(intPtr3, 3000U);
								GClass32.CloseHandle(intPtr3);
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

	// Token: 0x06000801 RID: 2049 RVA: 0x00007F38 File Offset: 0x00006138
	private static bool smethod_34(IntPtr intptr_0, int int_11, string string_0, out int int_12, out int int_13)
	{
		if (GClass32.smethod_32(intptr_0, int_11, string_0, out int_12, out int_13))
		{
			return true;
		}
		GClass32.smethod_33(intptr_0, int_11, string_0);
		return GClass32.smethod_32(intptr_0, int_11, string_0, out int_12, out int_13);
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00040A24 File Offset: 0x0003EC24
	private static bool smethod_35(IntPtr intptr_0, string string_0, out int int_11, out int int_12)
	{
		int_11 = 0;
		int_12 = 0;
		IntPtr[] array = new IntPtr[1024];
		int num;
		bool flag = GClass32.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 1U) || GClass32.EnumProcessModulesEx(intptr_0, array, array.Length * IntPtr.Size, out num, 3U);
		if (!flag)
		{
			flag = GClass32.EnumProcessModules(intptr_0, array, array.Length * IntPtr.Size, out num);
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
			GClass32.GetModuleBaseNameA(intptr_0, array[num3], stringBuilder, 260);
			if (!stringBuilder.ToString().Equals(string_0, StringComparison.OrdinalIgnoreCase))
			{
				num3++;
			}
			else
			{
				GClass32.Struct14 @struct;
				if (!GClass32.GetModuleInformation(intptr_0, array[num3], out @struct, Marshal.SizeOf(typeof(GClass32.Struct14))))
				{
					return false;
				}
				int_11 = GClass32.smethod_0(@struct.intptr_0);
				int_12 = (int)@struct.uint_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00040B10 File Offset: 0x0003ED10
	private static IntPtr smethod_36(IntPtr intptr_0, int int_11, string string_0, string string_1)
	{
		int num;
		int num2;
		if (!GClass32.smethod_32(intptr_0, int_11, string_0, out num, out num2))
		{
			return IntPtr.Zero;
		}
		return GClass32.smethod_37(intptr_0, GClass32.smethod_1(num), string_1);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00040B40 File Offset: 0x0003ED40
	private static IntPtr smethod_37(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		int num = GClass32.smethod_0(intptr_1);
		byte[] array = new byte[4096];
		int num2;
		if (!GClass32.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num2))
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
		if (!GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num + num4), array2, array2.Length, out num2))
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
			if (GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num + num6 + i * 4), array3, 4, out num2))
			{
				int num9 = BitConverter.ToInt32(array3, 0);
				byte[] array4 = new byte[64];
				if (GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num + num9), array4, 64, out num2))
				{
					int num10 = Array.IndexOf<byte>(array4, 0);
					if (!(Encoding.ASCII.GetString(array4, 0, (num10 < 0) ? array4.Length : num10) != string_0))
					{
						byte[] array5 = new byte[2];
						if (!GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num + num7 + i * 2), array5, 2, out num2))
						{
							return IntPtr.Zero;
						}
						ushort num11 = BitConverter.ToUInt16(array5, 0);
						byte[] array6 = new byte[4];
						if (!GClass32.ReadProcessMemory(intptr_0, GClass32.smethod_1(num + num8 + (int)(num11 * 4)), array6, 4, out num2))
						{
							return IntPtr.Zero;
						}
						return GClass32.smethod_1(num + BitConverter.ToInt32(array6, 0));
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00040D04 File Offset: 0x0003EF04
	private static bool smethod_38(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_1)
	{
		int num = GClass32.smethod_0(intptr_1);
		int num2 = GClass32.smethod_0(intptr_2);
		int num3 = GClass32.smethod_0(intptr_3);
		byte[] array = new byte[10];
		Array.Copy(byte_0, array, 5);
		array[5] = 233;
		BitConverter.GetBytes(num + 5 - (num2 + 10)).CopyTo(array, 6);
		int num4;
		GClass32.WriteProcessMemory(intptr_0, intptr_2, array, 10, out num4);
		GClass32.WriteProcessMemory(intptr_0, intptr_3, byte_1, byte_1.Length, out num4);
		byte[] array2 = new byte[5];
		array2[0] = 233;
		byte[] array3 = array2;
		BitConverter.GetBytes(num3 - (num + 5)).CopyTo(array3, 1);
		uint num5;
		GClass32.VirtualProtectEx(intptr_0, intptr_1, 8U, 64U, out num5);
		bool flag = GClass32.WriteProcessMemory(intptr_0, intptr_1, array3, 5, out num4);
		GClass32.VirtualProtectEx(intptr_0, intptr_1, 8U, num5, out num5);
		return flag;
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00040DC0 File Offset: 0x0003EFC0
	private static bool smethod_39(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_34(intPtr, process_0.Id, "rpcrt4.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "UuidCreateSequential");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (GClass32.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							IntPtr intPtr3 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 16U, 12288U, 64U);
							if (intPtr3 == IntPtr.Zero)
							{
								return false;
							}
							int num4 = GClass32.smethod_0(intPtr3);
							GClass32.smethod_21(intPtr, num4, byte_0);
							IntPtr intPtr4 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr5 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 128U, 12288U, 64U);
							if (!(intPtr4 == IntPtr.Zero) && !(intPtr5 == IntPtr.Zero))
							{
								int num5 = GClass32.smethod_0(intPtr5);
								int num6 = GClass32.smethod_0(intPtr4);
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
								return GClass32.smethod_38(intPtr, intPtr2, array, intPtr4, intPtr5, array3);
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
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x000410AC File Offset: 0x0003F2AC
	private static bool smethod_40(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "GetAdaptersInfo");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (GClass32.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = GClass32.smethod_0(intPtr4);
								int num7 = GClass32.smethod_0(intPtr3);
								GClass32.smethod_0(intPtr2);
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
								return GClass32.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array4);
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
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00041490 File Offset: 0x0003F690
	private static bool smethod_41(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "GetAdaptersAddresses");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (GClass32.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = GClass32.smethod_0(intPtr4);
								int num7 = GClass32.smethod_0(intPtr3);
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
								return GClass32.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0004187C File Offset: 0x0003FA7C
	private static bool smethod_42(Process process_0, byte[] byte_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_34(intPtr, process_0.Id, "iphlpapi.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "GetIfTable");
				if (intPtr2 == IntPtr.Zero)
				{
					flag = false;
				}
				else
				{
					byte[] array = new byte[5];
					int num3;
					if (GClass32.ReadProcessMemory(intPtr, intPtr2, array, 5, out num3))
					{
						if (num3 == 5)
						{
							if (array[0] == 233)
							{
								return true;
							}
							uint num4 = BitConverter.ToUInt32(byte_0, 0);
							ushort num5 = (ushort)((int)byte_0[4] | ((int)byte_0[5] << 8));
							IntPtr intPtr3 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 32U, 12288U, 64U);
							IntPtr intPtr4 = GClass32.VirtualAllocEx(intPtr, IntPtr.Zero, 256U, 12288U, 64U);
							if (!(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
							{
								int num6 = GClass32.smethod_0(intPtr4);
								int num7 = GClass32.smethod_0(intPtr3);
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
								return GClass32.smethod_38(intPtr, intPtr2, array, intPtr3, intPtr4, array5);
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
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00041CB8 File Offset: 0x0003FEB8
	private static bool smethod_43(IntPtr intptr_0, int int_11)
	{
		IntPtr intPtr = GClass32.smethod_36(intptr_0, int_11, "kernel32.dll", "ExitProcess");
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[1];
		int num;
		if (GClass32.ReadProcessMemory(intptr_0, intPtr, array, 1, out num))
		{
			if (num == 1)
			{
				return array[0] == 233;
			}
		}
		return false;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00041D0C File Offset: 0x0003FF0C
	private static bool smethod_44(IntPtr intptr_0, int int_11, int int_12, int int_13)
	{
		if (GClass32.dictionary_0.ContainsKey(int_11))
		{
			GClass32.smethod_45(intptr_0, int_11, int_12, int_13);
			return true;
		}
		IntPtr intPtr = GClass32.smethod_36(intptr_0, int_11, "kernel32.dll", "ExitProcess");
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[5];
		int num;
		if (GClass32.ReadProcessMemory(intptr_0, intPtr, array, 5, out num))
		{
			if (num == 5)
			{
				if (array[0] == 233)
				{
					return GClass32.smethod_43(intptr_0, int_11);
				}
				IntPtr intPtr2 = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				IntPtr intPtr3 = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 64U, 12288U, 64U);
				IntPtr intPtr4 = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 8U, 12288U, 64U);
				if (!(intPtr2 == IntPtr.Zero) && !(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
				{
					int num2 = GClass32.smethod_0(intPtr2);
					int num3 = GClass32.smethod_0(intPtr3);
					int num4 = GClass32.smethod_0(intPtr4);
					int num5 = GClass32.smethod_0(intPtr);
					int num6;
					GClass32.WriteProcessMemory(intptr_0, intPtr4, BitConverter.GetBytes(int_12), 4, out num6);
					GClass32.WriteProcessMemory(intptr_0, GClass32.smethod_1(num4 + 4), BitConverter.GetBytes(int_12 + int_13), 4, out num6);
					byte[] array2 = new byte[10];
					Array.Copy(array, array2, 5);
					array2[5] = 233;
					BitConverter.GetBytes(num5 + 5 - (num2 + 10)).CopyTo(array2, 6);
					GClass32.WriteProcessMemory(intptr_0, intPtr2, array2, 10, out num6);
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
					GClass32.WriteProcessMemory(intptr_0, intPtr3, array3, 31, out num6);
					byte[] array4 = new byte[5];
					array4[0] = 233;
					byte[] array5 = array4;
					BitConverter.GetBytes(num3 - (num5 + 5)).CopyTo(array5, 1);
					uint num7;
					GClass32.VirtualProtectEx(intptr_0, intPtr, 8U, 64U, out num7);
					bool flag = GClass32.WriteProcessMemory(intptr_0, intPtr, array5, 5, out num6);
					GClass32.VirtualProtectEx(intptr_0, intPtr, 8U, num7, out num7);
					if (flag)
					{
						GClass32.dictionary_0[int_11] = intPtr4;
					}
					return flag;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00041FB8 File Offset: 0x000401B8
	private static void smethod_45(IntPtr intptr_0, int int_11, int int_12, int int_13)
	{
		IntPtr intPtr;
		if (!GClass32.dictionary_0.TryGetValue(int_11, out intPtr))
		{
			return;
		}
		int num;
		GClass32.WriteProcessMemory(intptr_0, intPtr, BitConverter.GetBytes(int_12), 4, out num);
		GClass32.WriteProcessMemory(intptr_0, GClass32.smethod_1(GClass32.smethod_0(intPtr) + 4), BitConverter.GetBytes(int_12 + int_13), 4, out num);
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00042008 File Offset: 0x00040208
	private static bool smethod_46(Process process_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_32(intPtr, process_0.Id, "Plugin_ClientManager.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				flag = GClass32.smethod_44(intPtr, process_0.Id, num, num2);
			}
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0004207C File Offset: 0x0004027C
	private static bool smethod_47(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return false;
		}
		byte[] array = new byte[5];
		int num;
		if (GClass32.ReadProcessMemory(intptr_0, intptr_1, array, 5, out num))
		{
			if (num == 5)
			{
				if (array[0] == 233)
				{
					return true;
				}
				IntPtr intPtr = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 32U, 12288U, 64U);
				IntPtr intPtr2 = GClass32.VirtualAllocEx(intptr_0, IntPtr.Zero, 128U, 12288U, 64U);
				if (!(intPtr == IntPtr.Zero) && !(intPtr2 == IntPtr.Zero))
				{
					int num2 = GClass32.smethod_0(intptr_1);
					int num3 = GClass32.smethod_0(intPtr);
					int num4 = GClass32.smethod_0(intPtr2);
					byte[] array2 = new byte[10];
					Array.Copy(array, array2, 5);
					array2[5] = 233;
					BitConverter.GetBytes(num2 + 5 - (num3 + 10)).CopyTo(array2, 6);
					int num5;
					GClass32.WriteProcessMemory(intptr_0, intPtr, array2, 10, out num5);
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
					GClass32.WriteProcessMemory(intptr_0, intPtr2, array10, array10.Length, out num5);
					byte[] array11 = new byte[5];
					array11[0] = 233;
					byte[] array12 = array11;
					BitConverter.GetBytes(num4 - (num2 + 5)).CopyTo(array12, 1);
					uint num6;
					GClass32.VirtualProtectEx(intptr_0, intptr_1, 8U, 64U, out num6);
					bool flag = GClass32.WriteProcessMemory(intptr_0, intptr_1, array12, 5, out num5);
					GClass32.VirtualProtectEx(intptr_0, intptr_1, 8U, num6, out num6);
					return flag;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00042470 File Offset: 0x00040670
	private static bool smethod_48(Process process_0)
	{
		IntPtr intPtr = GClass32.OpenProcess(2035711U, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		try
		{
			int num;
			int num2;
			if (!GClass32.smethod_32(intPtr, process_0.Id, "user32.dll", out num, out num2))
			{
				flag = false;
			}
			else
			{
				IntPtr intPtr2 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "MessageBoxW");
				IntPtr intPtr3 = GClass32.smethod_37(intPtr, GClass32.smethod_1(num), "MessageBoxA");
				bool flag2 = GClass32.smethod_47(intPtr, intPtr2);
				bool flag3 = GClass32.smethod_47(intPtr, intPtr3);
				flag = flag2 || flag3;
			}
		}
		finally
		{
			GClass32.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00042518 File Offset: 0x00040718
	[CompilerGenerated]
	internal static void smethod_49(string string_0, ref GClass32.Struct19 struct19_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		try
		{
			string_0 = Path.GetFullPath(string_0);
			if (!struct19_0.list_0.Contains(string_0))
			{
				struct19_0.list_0.Add(string_0);
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000469 RID: 1129
	private const uint uint_0 = 2035711U;

	// Token: 0x0400046A RID: 1130
	private const uint uint_1 = 4096U;

	// Token: 0x0400046B RID: 1131
	private const uint uint_2 = 8192U;

	// Token: 0x0400046C RID: 1132
	private const uint uint_3 = 64U;

	// Token: 0x0400046D RID: 1133
	private const uint uint_4 = 258U;

	// Token: 0x0400046E RID: 1134
	private const uint uint_5 = 1U;

	// Token: 0x0400046F RID: 1135
	private const uint uint_6 = 3U;

	// Token: 0x04000470 RID: 1136
	private const int int_0 = 6232324;

	// Token: 0x04000471 RID: 1137
	private const int int_1 = 4385227;

	// Token: 0x04000472 RID: 1138
	private const int int_2 = 4385245;

	// Token: 0x04000473 RID: 1139
	private const int int_3 = 4387436;

	// Token: 0x04000474 RID: 1140
	private const int int_4 = 4795680;

	// Token: 0x04000475 RID: 1141
	private const int int_5 = 4796032;

	// Token: 0x04000476 RID: 1142
	private const int int_6 = 4796051;

	// Token: 0x04000477 RID: 1143
	private const int int_7 = 6576016;

	// Token: 0x04000478 RID: 1144
	private const int int_8 = 6576840;

	// Token: 0x04000479 RID: 1145
	private const int int_9 = 6201668;

	// Token: 0x0400047A RID: 1146
	private static readonly Random random_0 = new Random();

	// Token: 0x0400047B RID: 1147
	private static readonly Dictionary<int, IntPtr> dictionary_0 = new Dictionary<int, IntPtr>();

	// Token: 0x0400047C RID: 1148
	private const int int_10 = 20000;

	// Token: 0x020000B8 RID: 184
	public sealed class GClass33
	{
		// Token: 0x0400047D RID: 1149
		public bool bool_0;

		// Token: 0x0400047E RID: 1150
		public int int_0;

		// Token: 0x0400047F RID: 1151
		public string string_0;

		// Token: 0x04000480 RID: 1152
		public byte[] byte_0;

		// Token: 0x04000481 RID: 1153
		public string string_1;

		// Token: 0x04000482 RID: 1154
		public bool bool_1;

		// Token: 0x04000483 RID: 1155
		public bool bool_2;

		// Token: 0x04000484 RID: 1156
		public bool bool_3;

		// Token: 0x04000485 RID: 1157
		public bool bool_4;

		// Token: 0x04000486 RID: 1158
		public bool bool_5;

		// Token: 0x04000487 RID: 1159
		public bool bool_6;

		// Token: 0x04000488 RID: 1160
		public bool bool_7;

		// Token: 0x04000489 RID: 1161
		public bool bool_8;

		// Token: 0x0400048A RID: 1162
		public string string_2;

		// Token: 0x0400048B RID: 1163
		public string string_3;
	}

	// Token: 0x020000B9 RID: 185
	private struct Struct14
	{
		// Token: 0x0400048C RID: 1164
		public IntPtr intptr_0;

		// Token: 0x0400048D RID: 1165
		public uint uint_0;

		// Token: 0x0400048E RID: 1166
		public IntPtr intptr_1;
	}

	// Token: 0x020000BA RID: 186
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct15
	{
		// Token: 0x0400048F RID: 1167
		public int int_0;

		// Token: 0x04000490 RID: 1168
		public IntPtr intptr_0;

		// Token: 0x04000491 RID: 1169
		public IntPtr intptr_1;

		// Token: 0x04000492 RID: 1170
		public IntPtr intptr_2;

		// Token: 0x04000493 RID: 1171
		public int int_1;

		// Token: 0x04000494 RID: 1172
		public int int_2;

		// Token: 0x04000495 RID: 1173
		public int int_3;

		// Token: 0x04000496 RID: 1174
		public int int_4;

		// Token: 0x04000497 RID: 1175
		public int int_5;

		// Token: 0x04000498 RID: 1176
		public int int_6;

		// Token: 0x04000499 RID: 1177
		public int int_7;

		// Token: 0x0400049A RID: 1178
		public int int_8;

		// Token: 0x0400049B RID: 1179
		public short short_0;

		// Token: 0x0400049C RID: 1180
		public short short_1;

		// Token: 0x0400049D RID: 1181
		public IntPtr intptr_3;

		// Token: 0x0400049E RID: 1182
		public IntPtr intptr_4;

		// Token: 0x0400049F RID: 1183
		public IntPtr intptr_5;

		// Token: 0x040004A0 RID: 1184
		public IntPtr intptr_6;
	}

	// Token: 0x020000BB RID: 187
	private struct Struct16
	{
		// Token: 0x040004A1 RID: 1185
		public IntPtr intptr_0;

		// Token: 0x040004A2 RID: 1186
		public IntPtr intptr_1;

		// Token: 0x040004A3 RID: 1187
		public int int_0;

		// Token: 0x040004A4 RID: 1188
		public int int_1;
	}

	// Token: 0x020000BC RID: 188
	private struct Struct17
	{
		// Token: 0x040004A5 RID: 1189
		public IntPtr intptr_0;

		// Token: 0x040004A6 RID: 1190
		public IntPtr intptr_1;

		// Token: 0x040004A7 RID: 1191
		public IntPtr intptr_2;

		// Token: 0x040004A8 RID: 1192
		public IntPtr intptr_3;

		// Token: 0x040004A9 RID: 1193
		public IntPtr intptr_4;

		// Token: 0x040004AA RID: 1194
		public IntPtr intptr_5;
	}

	// Token: 0x020000BD RID: 189
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct18
	{
		// Token: 0x040004AB RID: 1195
		public uint uint_0;

		// Token: 0x040004AC RID: 1196
		public uint uint_1;

		// Token: 0x040004AD RID: 1197
		public uint uint_2;

		// Token: 0x040004AE RID: 1198
		public uint uint_3;

		// Token: 0x040004AF RID: 1199
		public uint uint_4;

		// Token: 0x040004B0 RID: 1200
		public IntPtr intptr_0;

		// Token: 0x040004B1 RID: 1201
		public uint uint_5;

		// Token: 0x040004B2 RID: 1202
		public IntPtr intptr_1;

		// Token: 0x040004B3 RID: 1203
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x040004B4 RID: 1204
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x020000BE RID: 190
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct19
	{
		// Token: 0x040004B5 RID: 1205
		public List<string> list_0;
	}

	// Token: 0x020000BF RID: 191
	[CompilerGenerated]
	private sealed class Class99
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00042568 File Offset: 0x00040768
		internal void method_0()
		{
			try
			{
				GClass32.smethod_15(Process.GetProcessById(this.int_0), this.string_0, this.byte_0, this.stringBuilder_0);
			}
			catch (Exception ex)
			{
				this.stringBuilder_0.AppendLine("patch thread fail: " + ex.Message);
				GClass32.smethod_18(this.string_0, this.stringBuilder_0);
			}
		}

		// Token: 0x040004B6 RID: 1206
		public byte[] byte_0;

		// Token: 0x040004B7 RID: 1207
		public StringBuilder stringBuilder_0;

		// Token: 0x040004B8 RID: 1208
		public int int_0;

		// Token: 0x040004B9 RID: 1209
		public string string_0;
	}
}
