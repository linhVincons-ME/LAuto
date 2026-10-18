using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020002DC RID: 732
internal class Class515 : IDisposable
{
	// Token: 0x1700089D RID: 2205
	// (get) Token: 0x06002785 RID: 10117 RVA: 0x0001AAA6 File Offset: 0x00018CA6
	// (set) Token: 0x06002786 RID: 10118 RVA: 0x0001AAAE File Offset: 0x00018CAE
	public IntPtr IntPtr_0 { get; set; }

	// Token: 0x1700089E RID: 2206
	// (get) Token: 0x06002787 RID: 10119 RVA: 0x0001AAB7 File Offset: 0x00018CB7
	// (set) Token: 0x06002788 RID: 10120 RVA: 0x0001AABF File Offset: 0x00018CBF
	public int Int32_0 { get; set; }

	// Token: 0x1700089F RID: 2207
	// (get) Token: 0x06002789 RID: 10121 RVA: 0x0001AAC8 File Offset: 0x00018CC8
	public bool Boolean_0 { get; }

	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x0600278A RID: 10122 RVA: 0x0001AAD0 File Offset: 0x00018CD0
	public int Int32_1
	{
		get
		{
			if (!this.Boolean_0)
			{
				return 4;
			}
			return 8;
		}
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x0011DAF8 File Offset: 0x0011BCF8
	public Class515(int int_2)
	{
		this.Int32_0 = int_2;
		this.IntPtr_0 = Class515.OpenProcess(2035711, false, int_2);
		if (this.IntPtr_0 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error(), "Không thể mở tiến trình game.");
		}
		this.Boolean_0 = Class515.smethod_9(this.IntPtr_0);
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x0011DB58 File Offset: 0x0011BD58
	public int method_0(string string_0, string string_1)
	{
		foreach (Class514 @class in this.method_6())
		{
			if (@class.String_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return this.method_19(string_0, (int)@class.Int64_0, (int)@class.Int64_0 + @class.Int32_0, 0);
			}
		}
		return 0;
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x0011DBD8 File Offset: 0x0011BDD8
	public static bool smethod_0(byte[] byte_0, int[] int_2, int int_3)
	{
		for (int i = 0; i < int_2.Length; i++)
		{
			if (int_2[i] != -1)
			{
				if (int_2[i] == 257)
				{
					if (byte_0[int_3 + i] == 0)
					{
						return false;
					}
				}
				else if ((int)byte_0[int_3 + i] != int_2[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x00015974 File Offset: 0x00013B74
	public static int smethod_1(float float_0)
	{
		return BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0);
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x0011DC20 File Offset: 0x0011BE20
	public static byte smethod_2(string string_0)
	{
		byte b;
		if (!byte.TryParse(string_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b))
		{
			return 0;
		}
		return b;
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x0011DC44 File Offset: 0x0011BE44
	public static byte[] smethod_3(string string_0)
	{
		byte[] array = new byte[string_0.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Class515.smethod_2(string_0.Substring(i * 2, 2));
		}
		return array;
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x0011DC80 File Offset: 0x0011BE80
	public static int smethod_4(string string_0)
	{
		if (string_0 == "??")
		{
			return -1;
		}
		int num;
		if (!int.TryParse(string_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num))
		{
			return 0;
		}
		return num;
	}

	// Token: 0x06002792 RID: 10130
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_2, bool bool_1, int int_3);

	// Token: 0x06002793 RID: 10131
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_2);

	// Token: 0x06002794 RID: 10132
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsWow64Process(IntPtr intptr_2, out bool bool_1);

	// Token: 0x06002795 RID: 10133
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_2, uint uint_3);

	// Token: 0x06002796 RID: 10134
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_2, ref Class515.Struct41 struct41_0);

	// Token: 0x06002797 RID: 10135
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_2, ref Class515.Struct41 struct41_0);

	// Token: 0x06002798 RID: 10136 RVA: 0x0001AADD File Offset: 0x00018CDD
	public static bool smethod_5(IntPtr intptr_2, long long_0, byte[] byte_0, int int_2, out int int_3)
	{
		return Class515.ReadProcessMemory(intptr_2, (ulong)long_0, byte_0, int_2, out int_3);
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x0001AAEA File Offset: 0x00018CEA
	public static bool smethod_6(IntPtr intptr_2, long long_0, byte[] byte_0, int int_2, int int_3)
	{
		return Class515.ReadProcessMemory(intptr_2, (ulong)long_0, byte_0, int_2, out int_3);
	}

	// Token: 0x0600279A RID: 10138
	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_2, ulong ulong_0, byte[] byte_0, int int_2, out int int_3);

	// Token: 0x0600279B RID: 10139
	[DllImport("kernel32.dll")]
	public static extern bool SetProcessWorkingSetSize(IntPtr intptr_2, int int_2, int int_3);

	// Token: 0x0600279C RID: 10140 RVA: 0x0011DCB4 File Offset: 0x0011BEB4
	public static byte[] smethod_7(string string_0)
	{
		byte[] array = new byte[string_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			byte b;
			array[i] = (byte)((Class500.dictionary_0.TryGetValue(string_0[i], out b) ? b : 63));
		}
		return array;
	}

	// Token: 0x0600279D RID: 10141
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern long VirtualAllocEx(IntPtr intptr_2, long long_0, int int_2, uint uint_2, uint uint_3);

	// Token: 0x0600279E RID: 10142
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualFreeEx(IntPtr intptr_2, long long_0, int int_2, int int_3);

	// Token: 0x0600279F RID: 10143 RVA: 0x0011DCFC File Offset: 0x0011BEFC
	public static string smethod_8(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = Array.IndexOf<byte>(byte_0, 0);
			if (num == -1)
			{
				num = byte_0.Length;
			}
			char[] array = new char[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = Class515.char_0[(int)byte_0[i]];
			}
			return new string(array);
		}
		return string.Empty;
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x0001AAF7 File Offset: 0x00018CF7
	public bool method_1(long long_0, byte[] byte_0)
	{
		Class515.WriteProcessMemory(this.IntPtr_0, long_0, byte_0, byte_0.Length, 0);
		return true;
	}

	// Token: 0x060027A1 RID: 10145
	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr intptr_2, long long_0, byte[] byte_0, int int_2, int int_3);

	// Token: 0x060027A2 RID: 10146 RVA: 0x0011DD4C File Offset: 0x0011BF4C
	public string method_2(params long[] long_0)
	{
		if (long_0.Length != 1)
		{
			long num = this.method_14(long_0);
			return this.method_2(new long[] { num });
		}
		if (this.method_7(new long[] { long_0[0] + (this.Boolean_0 ? 24L : 20L) }) == 15)
		{
			byte[] array = new byte[15];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, 15, 0);
			return Class515.smethod_8(array);
		}
		byte[] array2 = new byte[120];
		Class515.smethod_6(this.IntPtr_0, this.method_8(long_0[0]), array2, array2.Length, 0);
		return Class515.smethod_8(array2);
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x0011DDE8 File Offset: 0x0011BFE8
	public string method_3(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			this.method_7(new long[] { long_0[0] + 20L });
			byte[] array = new byte[15];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, 15, 0);
			return Class515.smethod_8(array);
		}
		long num = this.method_14(long_0);
		return this.method_2(new long[] { num });
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x0011DE54 File Offset: 0x0011C054
	public long method_4(string string_0)
	{
		foreach (Class514 @class in this.method_6())
		{
			if (@class.String_0.Equals(string_0, StringComparison.OrdinalIgnoreCase))
			{
				return @class.Int64_0;
			}
		}
		return 0L;
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x0001AB0C File Offset: 0x00018D0C
	public Class514 method_5()
	{
		List<Class514> list = this.method_6();
		if (list.Count == 0)
		{
			throw new Win32Exception("Không lấy được module chính của tiến trình game.");
		}
		return list[0];
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x0011DEC4 File Offset: 0x0011C0C4
	public List<Class514> method_6()
	{
		IntPtr intPtr = Class515.intptr_0;
		int num = 0;
		while (num < 5 && intPtr == Class515.intptr_0)
		{
			intPtr = Class515.CreateToolhelp32Snapshot(24U, (uint)this.Int32_0);
			num++;
		}
		if (intPtr == Class515.intptr_0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error(), "Không thể liệt kê module của tiến trình game.");
		}
		List<Class514> list2;
		try
		{
			List<Class514> list = new List<Class514>();
			Class515.Struct41 @struct = new Class515.Struct41
			{
				uint_0 = (uint)Marshal.SizeOf(typeof(Class515.Struct41))
			};
			if (!Class515.Module32FirstW(intPtr, ref @struct))
			{
				list2 = list;
			}
			else
			{
				do
				{
					List<Class514> list3 = list;
					Class514 @class = new Class514();
					string text;
					if ((text = @struct.string_0) == null)
					{
						text = string.Empty;
					}
					@class.String_0 = text;
					@class.String_1 = @struct.string_1 ?? string.Empty;
					@class.Int64_0 = @struct.intptr_0.ToInt64();
					@class.Int32_0 = (int)@struct.uint_5;
					list3.Add(@class);
					@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class515.Struct41));
				}
				while (Class515.Module32NextW(intPtr, ref @struct));
				list2 = list;
			}
		}
		finally
		{
			Class515.CloseHandle(intPtr);
		}
		return list2;
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x0011DFEC File Offset: 0x0011C1EC
	public int method_7(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[4];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, 4, 0);
			return (int)array[0] | ((int)array[1] << 8) | ((int)array[2] << 16) | ((int)array[3] << 24);
		}
		return this.method_7(new long[] { this.method_14(long_0) });
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x0011E048 File Offset: 0x0011C248
	public long method_8(long long_0)
	{
		byte[] array = new byte[this.Int32_1];
		Class515.smethod_6(this.IntPtr_0, long_0, array, array.Length, 0);
		if (!this.Boolean_0)
		{
			return (long)((ulong)BitConverter.ToUInt32(array, 0));
		}
		return BitConverter.ToInt64(array, 0);
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x0011E08C File Offset: 0x0011C28C
	public long method_9(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			return this.method_8(long_0[0]);
		}
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		return num;
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x0011E0D0 File Offset: 0x0011C2D0
	public int method_10(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[1];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, array.Length, 0);
			return (int)array[0];
		}
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length - 1; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		return this.method_10(new long[] { num + long_0[long_0.Length - 1] });
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x0011E140 File Offset: 0x0011C340
	public int method_11(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[2];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, array.Length, 0);
			return (int)array[0] | ((int)array[1] << 8);
		}
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length - 1; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		return this.method_11(new long[] { num + long_0[long_0.Length - 1] });
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x0011E1B8 File Offset: 0x0011C3B8
	public ulong method_12(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[8];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, array.Length, 0);
			return BitConverter.ToUInt64(array, 0);
		}
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length - 1; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		return this.method_12(new long[] { num + long_0[long_0.Length - 1] });
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x0011E22C File Offset: 0x0011C42C
	public float method_13(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[4];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, array.Length, 0);
			return BitConverter.ToSingle(array, 0);
		}
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length - 1; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		return this.method_13(new long[] { num + long_0[long_0.Length - 1] });
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x0011E2A0 File Offset: 0x0011C4A0
	public long method_14(params long[] long_0)
	{
		long num = this.method_8(long_0[0]);
		for (int i = 1; i < long_0.Length - 1; i++)
		{
			num = this.method_8(num + long_0[i]);
		}
		if (long_0.Length != 1)
		{
			return num + long_0[long_0.Length - 1];
		}
		return num;
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x0011E2E4 File Offset: 0x0011C4E4
	public int[] method_15(int int_2)
	{
		byte[] array = new byte[12];
		Class515.smethod_6(this.IntPtr_0, (long)int_2, array, 12, 0);
		return new int[]
		{
			BitConverter.ToInt32(array, 0),
			BitConverter.ToInt32(array, 4),
			BitConverter.ToInt32(array, 8)
		};
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x0011E330 File Offset: 0x0011C530
	public string method_16(params long[] long_0)
	{
		if (long_0.Length == 1)
		{
			byte[] array = new byte[500];
			Class515.smethod_6(this.IntPtr_0, long_0[0], array, array.Length, 0);
			return Class515.smethod_8(array);
		}
		return this.method_16(new long[] { this.method_14(long_0) });
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x0011E380 File Offset: 0x0011C580
	public string method_17(long long_0)
	{
		byte[] array = new byte[10248];
		Class515.smethod_6(this.IntPtr_0, long_0, array, array.Length, 0);
		return Class515.smethod_8(array);
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x0011E3B0 File Offset: 0x0011C5B0
	public byte[] method_18(long long_0)
	{
		byte[] array = new byte[60];
		Class515.smethod_6(this.IntPtr_0, long_0, array, 60, 0);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == 0)
			{
				Array.Resize<byte>(ref array, i);
				return array;
			}
		}
		return array;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x0011E3F4 File Offset: 0x0011C5F4
	public int method_19(string string_0, int int_2 = -1, int int_3 = -1, int int_4 = 0)
	{
		int num = 20248;
		int num2 = 0;
		int num3 = 0;
		try
		{
			Class514 @class = this.method_5();
			if (int_2 == -1)
			{
				int_2 = (int)@class.Int64_0;
			}
			if (int_3 == -1)
			{
				int_3 = int_2 + @class.Int32_0;
			}
		}
		catch
		{
			int_2 = 262144;
			int_3 = 8978431;
		}
		if (int_2 == 0 && int_3 == 0)
		{
			int_2 = 0;
			int_3 = int.MaxValue;
		}
		int[] array = Class500.smethod_1(string_0);
		byte[] array2 = new byte[num + array.Length];
		int num4 = (int_3 - int_2) / num;
		int num5 = (int_3 - int_2) % num;
		for (int i = 0; i < num4; i++)
		{
			int num6;
			Class515.smethod_5(this.IntPtr_0, (long)(int_2 + i * num), array2, array2.Length, out num6);
			for (int j = 0; j < num; j++)
			{
				if (Class515.smethod_0(array2, array, j))
				{
					int num7 = j + i * num + int_2;
					if (num2++ >= int_4)
					{
						return num7;
					}
					num3 = num7;
				}
			}
		}
		if (num5 > 0)
		{
			array2 = new byte[num5 + array.Length];
			Class515.smethod_6(this.IntPtr_0, (long)(int_2 + num4 * num), array2, array2.Length, 0);
			for (int k = 0; k < num5; k++)
			{
				if (Class515.smethod_0(array2, array, k))
				{
					int num7 = k + int_2 + num4 * num;
					if (num2++ >= int_4)
					{
						return num7;
					}
					num3 = num7;
				}
			}
		}
		return num3;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x0001AB2D File Offset: 0x00018D2D
	public long method_20(int int_2)
	{
		return Class515.VirtualAllocEx(this.IntPtr_0, 0L, int_2 + 16, 4096U, 64U);
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x0011E550 File Offset: 0x0011C750
	public void method_21(long long_0, int int_2)
	{
		byte[] bytes = BitConverter.GetBytes(int_2);
		Class515.WriteProcessMemory(this.IntPtr_0, long_0, bytes, 4, 0);
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x0011E574 File Offset: 0x0011C774
	public void method_22(long long_0, uint uint_2, int int_2)
	{
		byte[] bytes = BitConverter.GetBytes(uint_2);
		Class515.WriteProcessMemory(this.IntPtr_0, long_0, bytes, int_2, 0);
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x0011E598 File Offset: 0x0011C798
	public long method_23(long long_0, string string_0)
	{
		byte[] array = Class515.smethod_7(string_0);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == 63)
			{
				array[i] = 213;
			}
		}
		Array.Resize<byte>(ref array, array.Length + 32);
		Class515.WriteProcessMemory(this.IntPtr_0, long_0, array, array.Length, 0);
		return long_0;
	}

	// Token: 0x060027B8 RID: 10168
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_2, long long_0, int int_2, Class515.Enum16 enum16_0, out uint uint_2);

	// Token: 0x060027B9 RID: 10169 RVA: 0x0011E5EC File Offset: 0x0011C7EC
	private static bool smethod_9(IntPtr intptr_2)
	{
		if (!Environment.Is64BitOperatingSystem)
		{
			return false;
		}
		bool flag;
		if (!Class515.IsWow64Process(intptr_2, out flag))
		{
			return Environment.Is64BitProcess;
		}
		return !flag;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x0001AB4E File Offset: 0x00018D4E
	public void Dispose()
	{
		if (this.IntPtr_0 == IntPtr.Zero)
		{
			return;
		}
		Class515.CloseHandle(this.IntPtr_0);
		this.IntPtr_0 = IntPtr.Zero;
		GC.SuppressFinalize(this);
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x0011E618 File Offset: 0x0011C818
	~Class515()
	{
		this.Dispose();
	}

	// Token: 0x040019E1 RID: 6625
	private const uint uint_0 = 8U;

	// Token: 0x040019E2 RID: 6626
	private const uint uint_1 = 16U;

	// Token: 0x040019E3 RID: 6627
	private static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x040019E4 RID: 6628
	[CompilerGenerated]
	private IntPtr intptr_1;

	// Token: 0x040019E5 RID: 6629
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040019E6 RID: 6630
	[CompilerGenerated]
	private readonly bool bool_0;

	// Token: 0x040019E7 RID: 6631
	public static int int_1 = 20248;

	// Token: 0x040019E8 RID: 6632
	public static readonly char[] char_0 = new char[]
	{
		'\0', '\u0001', 'Ẳ', '\u0003', '\u0004', 'Ẵ', 'Ẫ', '\a', '\b', '\t',
		'\n', '\v', '\f', '\r', '\u000e', '\u000f', '\u0010', '\u0011', '\u0012', '\u0013',
		'Ỷ', '\u0015', '\u0016', '\u0017', '\u0018', 'Ỹ', '\u001a', '\u001b', '\u001c', '\u001d',
		'Ỵ', '\u001f', ' ', '!', '"', '#', '$', '%', '&', '\'',
		'(', ')', '*', '+', ',', '-', '.', '/', '0', '1',
		'2', '3', '4', '5', '6', '7', '8', '9', ':', ';',
		'<', '=', '>', '?', '@', 'A', 'B', 'C', 'D', 'E',
		'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
		'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y',
		'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c',
		'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
		'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
		'x', 'y', 'z', '{', '|', '}', '~', '\u007f', 'Ạ', 'Ắ',
		'Ằ', 'Ặ', 'Ấ', 'Ầ', 'Ẩ', 'Ậ', 'Ẽ', 'Ẹ', 'Ế', 'Ề',
		'Ể', 'Ễ', 'Ệ', 'Ố', 'Ồ', 'Ổ', 'Ỗ', 'Ộ', 'Ợ', 'Ớ',
		'Ờ', 'Ở', 'Ị', 'Ỏ', 'Ọ', 'Ỉ', 'Ủ', 'Ũ', 'Ụ', 'Ỳ',
		'Õ', 'ắ', 'ằ', 'ặ', 'ấ', 'ầ', 'ẩ', 'ậ', 'ẽ', 'ẹ',
		'ế', 'ề', 'ể', 'ễ', 'ệ', 'ố', 'ồ', 'ổ', 'ỗ', 'Ỡ',
		'Ơ', 'ộ', 'ờ', 'ở', 'ị', 'Ự', 'Ứ', 'Ừ', 'Ử', 'ơ',
		'ớ', 'Ư', 'À', 'Á', 'Â', 'Ã', 'Ả', 'Ă', 'ẳ', 'ẵ',
		'È', 'É', 'Ê', 'Ẻ', 'Ì', 'Í', 'Ĩ', 'ỳ', 'Đ', 'ứ',
		'Ò', 'Ó', 'Ô', 'ạ', 'ỷ', 'ừ', 'ử', 'Ù', 'Ú', 'ỹ',
		'ỵ', 'Ý', 'ỡ', 'ư', 'à', 'á', 'â', 'ã', 'ả', 'ă',
		'ữ', 'ẫ', 'è', 'é', 'ê', 'ẻ', 'ì', 'í', 'ĩ', 'ỉ',
		'đ', 'ự', 'ò', 'ó', 'ô', 'õ', 'ỏ', 'ọ', 'ụ', 'ù',
		'ú', 'ũ', 'ủ', 'ý', 'ợ', 'Ữ'
	};

	// Token: 0x020002DD RID: 733
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct41
	{
		// Token: 0x040019E9 RID: 6633
		public uint uint_0;

		// Token: 0x040019EA RID: 6634
		public uint uint_1;

		// Token: 0x040019EB RID: 6635
		public uint uint_2;

		// Token: 0x040019EC RID: 6636
		public uint uint_3;

		// Token: 0x040019ED RID: 6637
		public uint uint_4;

		// Token: 0x040019EE RID: 6638
		public IntPtr intptr_0;

		// Token: 0x040019EF RID: 6639
		public uint uint_5;

		// Token: 0x040019F0 RID: 6640
		public IntPtr intptr_1;

		// Token: 0x040019F1 RID: 6641
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x040019F2 RID: 6642
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x020002DE RID: 734
	public enum Enum16
	{
		// Token: 0x040019F4 RID: 6644
		PAGE_NOACCESS = 1,
		// Token: 0x040019F5 RID: 6645
		PAGE_READONLY,
		// Token: 0x040019F6 RID: 6646
		PAGE_READWRITE = 4,
		// Token: 0x040019F7 RID: 6647
		PAGE_WRITECOPY = 8,
		// Token: 0x040019F8 RID: 6648
		PAGE_EXECUTE = 16,
		// Token: 0x040019F9 RID: 6649
		PAGE_EXECUTE_READ = 32,
		// Token: 0x040019FA RID: 6650
		PAGE_EXECUTE_READWRITE = 64,
		// Token: 0x040019FB RID: 6651
		PAGE_EXECUTE_WRITECOPY = 128,
		// Token: 0x040019FC RID: 6652
		PAGE_GUARD = 256,
		// Token: 0x040019FD RID: 6653
		PAGE_NOCACHE = 512,
		// Token: 0x040019FE RID: 6654
		PAGE_WRITECOMBINE = 1024
	}
}
