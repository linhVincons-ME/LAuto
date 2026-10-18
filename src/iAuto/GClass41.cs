using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020001C5 RID: 453
public static class GClass41
{
	// Token: 0x06001896 RID: 6294
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06001897 RID: 6295 RVA: 0x000CC5A8 File Offset: 0x000CA7A8
	public static IntPtr smethod_0(IntPtr intptr_0, byte[] byte_0, int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (byte_0 != null && intptr_0 != IntPtr.Zero)
		{
			intPtr = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)byte_0.Length, 12288, int_0);
			uint num = 0U;
			if (intPtr != IntPtr.Zero && GClass41.WriteProcessMemory(intptr_0, intPtr, byte_0, byte_0.Length, out num) && (ulong)num == (ulong)((long)byte_0.Length))
			{
				return intPtr;
			}
			if (intPtr != IntPtr.Zero)
			{
				GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
				intPtr = IntPtr.Zero;
			}
		}
		return intPtr;
	}

	// Token: 0x06001898 RID: 6296
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, uint uint_0, int int_2, int int_3);

	// Token: 0x06001899 RID: 6297
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetExitCodeThread(IntPtr intptr_0, out uint uint_0);

	// Token: 0x0600189A RID: 6298 RVA: 0x000CC62C File Offset: 0x000CA82C
	public static uint smethod_1(IntPtr intptr_0)
	{
		IntPtr intPtr = Class104.smethod_8(GClass41.GetProcessId(intptr_0), "kernel32.dll", "GetLastError", 0);
		return GClass41.smethod_7(intptr_0, intPtr, 0U, 1000);
	}

	// Token: 0x0600189B RID: 6299
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetModuleHandleA(string string_0);

	// Token: 0x0600189C RID: 6300 RVA: 0x000CC660 File Offset: 0x000CA860
	public static IntPtr smethod_2(IntPtr intptr_0, string string_0)
	{
		int processId = GClass41.GetProcessId(intptr_0);
		if (processId == 0)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = Class104.smethod_6(processId, string_0);
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		IntPtr intPtr2;
		try
		{
			intPtr2 = Class104.smethod_4(processId, string_0);
		}
		catch
		{
			intPtr2 = IntPtr.Zero;
		}
		return intPtr2;
	}

	// Token: 0x0600189D RID: 6301
	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string string_0);

	// Token: 0x0600189E RID: 6302
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	// Token: 0x0600189F RID: 6303
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", SetLastError = true)]
	public static extern IntPtr GetProcAddress_1(IntPtr intptr_0, uint uint_0);

	// Token: 0x060018A0 RID: 6304 RVA: 0x000CC6BC File Offset: 0x000CA8BC
	public static IntPtr smethod_3(IntPtr intptr_0, IntPtr intptr_1, object object_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		byte[] array = GClass41.smethod_4(intptr_0, intptr_1, 64U);
		if (array != null)
		{
			if (BitConverter.ToUInt16(array, 0) == 23117)
			{
				uint num = BitConverter.ToUInt32(array, 60);
				if (num <= 0U)
				{
					return intPtr;
				}
				byte[] array2 = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num)), 264U);
				if (array2 != null)
				{
					if (BitConverter.ToUInt32(array2, 0) == 17744U)
					{
						uint num2 = BitConverter.ToUInt32(array2, 120);
						uint num3 = BitConverter.ToUInt32(array2, 124);
						if (num2 <= 0U || num3 <= 0U)
						{
							return intPtr;
						}
						byte[] array3 = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num2)), 40U);
						uint num4 = BitConverter.ToUInt32(array3, 28);
						uint num5 = BitConverter.ToUInt32(array3, 36);
						uint num6 = BitConverter.ToUInt32(array3, 20);
						int num7 = -1;
						if (num4 <= 0U || num5 <= 0U)
						{
							return intPtr;
						}
						if (object_0.GetType().Equals(typeof(string)))
						{
							int num8 = GClass41.smethod_8(intptr_0, intptr_1, array3, (string)object_0);
							if (num8 > -1)
							{
								byte[] array4 = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num5 + (ulong)((long)((long)num8 << 1)))), 2U);
								num7 = ((array4 == null) ? (-1) : ((int)BitConverter.ToUInt16(array4, 0)));
							}
						}
						else if (object_0.GetType().Equals(typeof(short)) || object_0.GetType().Equals(typeof(ushort)))
						{
							uint num9 = BitConverter.ToUInt32(array3, 16);
							num7 = (int)((uint)Convert.ToUInt16(object_0) - num9);
						}
						if (num7 <= -1 || (long)num7 >= (long)((ulong)num6))
						{
							return intPtr;
						}
						byte[] array5 = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num4 + (ulong)((long)((long)num7 << 2)))), 4U);
						if (array5 == null)
						{
							return intPtr;
						}
						uint num10 = BitConverter.ToUInt32(array5, 0);
						if (num10 >= num2 && num10 < num2 + num3)
						{
							string text = GClass41.smethod_6(intptr_0, intptr_1.smethod_0((long)((ulong)num10)), null);
							if (!string.IsNullOrEmpty(text) && text.Contains("."))
							{
								string[] array6 = text.Split(new char[] { '.' });
								IntPtr intPtr2 = GClass41.smethod_2(intptr_0, array6[0]);
								if (intPtr2.smethod_4())
								{
									return IntPtr.Zero;
								}
								intPtr = GClass41.smethod_3(intptr_0, intPtr2, array6[1]);
							}
							return intPtr;
						}
						return intptr_1.smethod_0((long)((ulong)num10));
					}
				}
				return intPtr;
			}
		}
		return intPtr;
	}

	// Token: 0x060018A1 RID: 6305
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int GetProcessId(IntPtr intptr_0);

	// Token: 0x060018A2 RID: 6306
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetThreadContext(IntPtr intptr_0, ref GClass41.GStruct15 gstruct15_0);

	// Token: 0x060018A3 RID: 6307
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	// Token: 0x060018A4 RID: 6308
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenThread(uint uint_0, bool bool_0, int int_0);

	// Token: 0x060018A5 RID: 6309
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, out uint uint_0);

	// Token: 0x060018A6 RID: 6310 RVA: 0x000CC8FC File Offset: 0x000CAAFC
	public static byte[] smethod_4(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		byte[] array = new byte[uint_0];
		uint num = 0U;
		if (!GClass41.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num) || num != uint_0)
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x000CC928 File Offset: 0x000CAB28
	public static IntPtr smethod_5(IntPtr intptr_0, IntPtr intptr_1)
	{
		IntPtr zero = IntPtr.Zero;
		if (!intptr_0.smethod_4() && !intptr_1.smethod_4())
		{
			byte[] array = GClass41.smethod_4(intptr_0, intptr_1, 4U);
			if (array != null)
			{
				zero = new IntPtr((long)((ulong)BitConverter.ToUInt32(array, 0)));
			}
		}
		return zero;
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x000CC968 File Offset: 0x000CAB68
	public static string smethod_6(IntPtr intptr_0, IntPtr intptr_1, Encoding encoding_0 = null)
	{
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.ASCII;
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = new byte[256];
		uint num = 0U;
		int num2 = -1;
		while (num2 < 0 && GClass41.ReadProcessMemory(intptr_0, intptr_1, array, array.Length, out num) && num > 0U)
		{
			intptr_1 = intptr_1.smethod_0((long)((ulong)num));
			int length = stringBuilder.Length;
			stringBuilder.Append(encoding_0.GetString(array, 0, (int)num));
			num2 = stringBuilder.ToString().IndexOf('\0', length);
		}
		return stringBuilder.ToString().Substring(0, num2);
	}

	// Token: 0x060018A9 RID: 6313
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint ResumeThread(IntPtr intptr_0);

	// Token: 0x060018AA RID: 6314 RVA: 0x000CC9F0 File Offset: 0x000CABF0
	public static uint smethod_7(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0 = 1000)
	{
		uint maxValue = uint.MaxValue;
		IntPtr intPtr = GClass41.CreateRemoteThread(intptr_0, 0, 0, intptr_1, uint_0, 0, 0);
		if (intPtr != IntPtr.Zero && (ulong)GClass41.WaitForSingleObject(intPtr, int_0) == 0UL)
		{
			GClass41.GetExitCodeThread(intPtr, out maxValue);
		}
		return maxValue;
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x000CCA30 File Offset: 0x000CAC30
	private static int smethod_8(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, string string_0)
	{
		uint num = BitConverter.ToUInt32(byte_0, 24);
		uint num2 = BitConverter.ToUInt32(byte_0, 32);
		if (num == 0U || num2 == 0U)
		{
			return -1;
		}
		byte[] array = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num2)), num << 2);
		if (array == null)
		{
			return -1;
		}
		for (int i = 0; i < (int)num; i++)
		{
			uint num3 = BitConverter.ToUInt32(array, i << 2);
			if (string.Equals(GClass41.smethod_6(intptr_0, intptr_1.smethod_0((long)((ulong)num3)), null), string_0, StringComparison.Ordinal))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060018AC RID: 6316
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetThreadContext(IntPtr intptr_0, ref GClass41.GStruct15 gstruct15_0);

	// Token: 0x060018AD RID: 6317
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x060018AE RID: 6318
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0, int int_1);

	// Token: 0x060018AF RID: 6319
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1);

	// Token: 0x060018B0 RID: 6320
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, out uint uint_2);

	// Token: 0x060018B1 RID: 6321
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr intptr_0, int int_0);

	// Token: 0x060018B2 RID: 6322
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, out uint uint_0);

	// Token: 0x020001C6 RID: 454
	public struct GStruct15
	{
		// Token: 0x04001031 RID: 4145
		public uint uint_0;

		// Token: 0x04001032 RID: 4146
		public uint uint_1;

		// Token: 0x04001033 RID: 4147
		public uint uint_2;

		// Token: 0x04001034 RID: 4148
		public uint uint_3;

		// Token: 0x04001035 RID: 4149
		public uint uint_4;

		// Token: 0x04001036 RID: 4150
		public uint uint_5;

		// Token: 0x04001037 RID: 4151
		public uint uint_6;

		// Token: 0x04001038 RID: 4152
		public GClass41.GStruct16 gstruct16_0;

		// Token: 0x04001039 RID: 4153
		public uint uint_7;

		// Token: 0x0400103A RID: 4154
		public uint uint_8;

		// Token: 0x0400103B RID: 4155
		public uint uint_9;

		// Token: 0x0400103C RID: 4156
		public uint uint_10;

		// Token: 0x0400103D RID: 4157
		public uint uint_11;

		// Token: 0x0400103E RID: 4158
		public uint uint_12;

		// Token: 0x0400103F RID: 4159
		public uint uint_13;

		// Token: 0x04001040 RID: 4160
		public uint uint_14;

		// Token: 0x04001041 RID: 4161
		public uint uint_15;

		// Token: 0x04001042 RID: 4162
		public uint uint_16;

		// Token: 0x04001043 RID: 4163
		public uint uint_17;

		// Token: 0x04001044 RID: 4164
		public uint uint_18;

		// Token: 0x04001045 RID: 4165
		public uint uint_19;

		// Token: 0x04001046 RID: 4166
		public uint uint_20;

		// Token: 0x04001047 RID: 4167
		public uint uint_21;

		// Token: 0x04001048 RID: 4168
		public uint uint_22;

		// Token: 0x04001049 RID: 4169
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	// Token: 0x020001C7 RID: 455
	public struct GStruct16
	{
		// Token: 0x0400104A RID: 4170
		public uint uint_0;

		// Token: 0x0400104B RID: 4171
		public uint uint_1;

		// Token: 0x0400104C RID: 4172
		public uint uint_2;

		// Token: 0x0400104D RID: 4173
		public uint uint_3;

		// Token: 0x0400104E RID: 4174
		public uint uint_4;

		// Token: 0x0400104F RID: 4175
		public uint uint_5;

		// Token: 0x04001050 RID: 4176
		public uint uint_6;

		// Token: 0x04001051 RID: 4177
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		// Token: 0x04001052 RID: 4178
		public uint uint_7;
	}
}
