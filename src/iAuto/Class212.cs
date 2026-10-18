using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200013C RID: 316
internal static class Class212
{
	// Token: 0x0600122E RID: 4654
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint uint_14, bool bool_0, int int_0);

	// Token: 0x0600122F RID: 4655
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06001230 RID: 4656
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_1, int int_0, out int int_1);

	// Token: 0x06001231 RID: 4657
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_1, int int_0, out int int_1);

	// Token: 0x06001232 RID: 4658
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_14, out uint uint_15);

	// Token: 0x06001233 RID: 4659
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern UIntPtr VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out Class212.Struct30 struct30_0, UIntPtr uintptr_0);

	// Token: 0x06001234 RID: 4660
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_14, int int_0);

	// Token: 0x06001235 RID: 4661
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Process32FirstW(IntPtr intptr_0, ref Class212.Struct28 struct28_0);

	// Token: 0x06001236 RID: 4662
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Process32NextW(IntPtr intptr_0, ref Class212.Struct28 struct28_0);

	// Token: 0x06001237 RID: 4663
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32FirstW(IntPtr intptr_0, ref Class212.Struct29 struct29_0);

	// Token: 0x06001238 RID: 4664
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Module32NextW(IntPtr intptr_0, ref Class212.Struct29 struct29_0);

	// Token: 0x06001239 RID: 4665 RVA: 0x000A5CC0 File Offset: 0x000A3EC0
	public static List<int> smethod_0()
	{
		List<int> list = new List<int>();
		IntPtr intPtr = Class212.CreateToolhelp32Snapshot(2U, 0);
		if (intPtr == (IntPtr)(-1))
		{
			return list;
		}
		Class212.Struct28 @struct = default(Class212.Struct28);
		@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class212.Struct28));
		if (Class212.Process32FirstW(intPtr, ref @struct))
		{
			do
			{
				if (string.Equals(@struct.string_0, "Game.exe", StringComparison.OrdinalIgnoreCase))
				{
					list.Add((int)@struct.uint_2);
				}
			}
			while (Class212.Process32NextW(intPtr, ref @struct));
		}
		Class212.CloseHandle(intPtr);
		return list;
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x000A5D4C File Offset: 0x000A3F4C
	public static int smethod_1()
	{
		int num = 0;
		foreach (int num2 in Class212.smethod_0())
		{
			num += Class212.smethod_2(num2);
		}
		return num;
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x000A5DA4 File Offset: 0x000A3FA4
	public static int smethod_2(int int_0)
	{
		IntPtr intPtr = Class212.OpenProcess(1080U, false, int_0);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		int num2;
		try
		{
			IntPtr intPtr2 = IntPtr.Zero;
			uint num = 0U;
			string text = null;
			IntPtr intPtr3 = Class212.CreateToolhelp32Snapshot(24U, int_0);
			if (intPtr3 == (IntPtr)(-1))
			{
				num2 = 0;
			}
			else
			{
				Class212.Struct29 @struct = default(Class212.Struct29);
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class212.Struct29));
				if (Class212.Module32FirstW(intPtr3, ref @struct))
				{
					do
					{
						string text2;
						if ((text2 = @struct.string_0) == null)
						{
							text2 = "";
						}
						string text3 = text2;
						if (!text3.Equals("Game.exe", StringComparison.OrdinalIgnoreCase) && text3.Equals("Plugin_ParticleFX3.dll", StringComparison.OrdinalIgnoreCase))
						{
							intPtr2 = @struct.intptr_0;
							num = @struct.uint_5;
							text = text3;
						}
					}
					while (Class212.Module32NextW(intPtr3, ref @struct));
				}
				Class212.CloseHandle(intPtr3);
				int num3 = 0;
				if (intPtr2 != IntPtr.Zero && num > 0U)
				{
					num3 += Class212.smethod_8(intPtr, text, intPtr2, num);
				}
				num2 = num3;
			}
		}
		finally
		{
			Class212.CloseHandle(intPtr);
		}
		return num2;
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x00007FE1 File Offset: 0x000061E1
	private static bool smethod_3(uint uint_14)
	{
		return (uint_14 & 240U) != 0U && (uint_14 & 1U) == 0U;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x0000DC0D File Offset: 0x0000BE0D
	private static IEnumerable<ValueTuple<long, int>> smethod_4(IntPtr intptr_0, IntPtr intptr_1, uint uint_14)
	{
		Class212.Class213 @class = new Class212.Class213(-2);
		@class.intptr_3 = intptr_0;
		@class.intptr_1 = intptr_1;
		@class.uint_1 = uint_14;
		return @class;
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x000A5EC0 File Offset: 0x000A40C0
	private static byte[] smethod_5(IntPtr intptr_0, long long_0, int int_0)
	{
		byte[] array = new byte[int_0];
		int num;
		if (!Class212.ReadProcessMemory(intptr_0, (IntPtr)long_0, array, int_0, out num) || num <= 0)
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

	// Token: 0x0600123F RID: 4671 RVA: 0x000A5F04 File Offset: 0x000A4104
	private static bool smethod_6(IntPtr intptr_0, long long_0, byte[] byte_1)
	{
		uint num;
		Class212.VirtualProtectEx(intptr_0, (IntPtr)long_0, (UIntPtr)((ulong)((long)byte_1.Length)), 64U, out num);
		int num2;
		bool flag = Class212.WriteProcessMemory(intptr_0, (IntPtr)long_0, byte_1, byte_1.Length, out num2);
		uint num3;
		Class212.VirtualProtectEx(intptr_0, (IntPtr)long_0, (UIntPtr)((ulong)((long)byte_1.Length)), num, out num3);
		return flag && num2 == byte_1.Length;
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x000A5F60 File Offset: 0x000A4160
	private static List<ValueTuple<int, byte, byte>> smethod_7(byte[] byte_1)
	{
		List<ValueTuple<int, byte, byte>> list = new List<ValueTuple<int, byte, byte>>();
		int num = 0;
		while (num + 5 < byte_1.Length)
		{
			if (byte_1[num] == 131 && byte_1[num + 1] >= 248)
			{
				byte b = byte_1[num + 2];
				if (b == 2 || b == 3 || b == 4 || b == 32)
				{
					byte b2 = byte_1[num + 3];
					if ((b2 == 124 || b2 == 126 || (b2 == 15 && (byte_1[num + 4] == 140 || byte_1[num + 4] == 142))) && b != 127)
					{
						list.Add(new ValueTuple<int, byte, byte>(num + 2, b, 127));
					}
				}
			}
			num++;
		}
		return list;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x000A6004 File Offset: 0x000A4204
	private static int smethod_8(IntPtr intptr_0, string string_0, IntPtr intptr_1, uint uint_14)
	{
		int num = 0;
		intptr_1.ToInt64();
		foreach (ValueTuple<long, int> valueTuple in Class212.smethod_4(intptr_0, intptr_1, uint_14))
		{
			long item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			byte[] array = Class212.smethod_5(intptr_0, item, item2);
			if (array != null)
			{
				foreach (ValueTuple<int, byte, byte> valueTuple2 in Class212.smethod_7(array))
				{
					int item3 = valueTuple2.Item1;
					byte item4 = valueTuple2.Item3;
					if (Class212.smethod_6(intptr_0, item + (long)item3, new byte[] { item4 }))
					{
						num++;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00042FA0 File Offset: 0x000411A0
	private static int smethod_9(byte[] byte_1, byte[] byte_2, int int_0)
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

	// Token: 0x06001243 RID: 4675 RVA: 0x000A60E0 File Offset: 0x000A42E0
	private static int smethod_10(IntPtr intptr_0, IntPtr intptr_1, uint uint_14)
	{
		int num = 0;
		byte[] array = new byte[] { 131, 251, 127, 15, 140 };
		foreach (byte b in new byte[] { 2, 3, 32 })
		{
			byte[] array3 = new byte[] { 131, 251, 0, 15, 140 };
			array3[2] = b;
			byte[] array4 = array3;
			foreach (ValueTuple<long, int> valueTuple in Class212.smethod_4(intptr_0, intptr_1, uint_14))
			{
				long item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				byte[] array5 = Class212.smethod_5(intptr_0, item, item2);
				if (array5 != null)
				{
					int num2 = 0;
					for (;;)
					{
						int num3 = Class212.smethod_9(array5, array4, num2);
						if (num3 < 0)
						{
							break;
						}
						if (Class212.smethod_6(intptr_0, item + (long)num3, array))
						{
							num++;
						}
						num2 = num3 + 1;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x04000A8A RID: 2698
	public const byte byte_0 = 127;

	// Token: 0x04000A8B RID: 2699
	private const uint uint_0 = 1024U;

	// Token: 0x04000A8C RID: 2700
	private const uint uint_1 = 16U;

	// Token: 0x04000A8D RID: 2701
	private const uint uint_2 = 32U;

	// Token: 0x04000A8E RID: 2702
	private const uint uint_3 = 8U;

	// Token: 0x04000A8F RID: 2703
	private const uint uint_4 = 1080U;

	// Token: 0x04000A90 RID: 2704
	private const uint uint_5 = 4096U;

	// Token: 0x04000A91 RID: 2705
	private const uint uint_6 = 1U;

	// Token: 0x04000A92 RID: 2706
	private const uint uint_7 = 16U;

	// Token: 0x04000A93 RID: 2707
	private const uint uint_8 = 32U;

	// Token: 0x04000A94 RID: 2708
	private const uint uint_9 = 64U;

	// Token: 0x04000A95 RID: 2709
	private const uint uint_10 = 128U;

	// Token: 0x04000A96 RID: 2710
	private const uint uint_11 = 2U;

	// Token: 0x04000A97 RID: 2711
	private const uint uint_12 = 8U;

	// Token: 0x04000A98 RID: 2712
	private const uint uint_13 = 16U;

	// Token: 0x0200013D RID: 317
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct28
	{
		// Token: 0x04000A99 RID: 2713
		public uint uint_0;

		// Token: 0x04000A9A RID: 2714
		public uint uint_1;

		// Token: 0x04000A9B RID: 2715
		public uint uint_2;

		// Token: 0x04000A9C RID: 2716
		public IntPtr intptr_0;

		// Token: 0x04000A9D RID: 2717
		public uint uint_3;

		// Token: 0x04000A9E RID: 2718
		public uint uint_4;

		// Token: 0x04000A9F RID: 2719
		public uint uint_5;

		// Token: 0x04000AA0 RID: 2720
		public int int_0;

		// Token: 0x04000AA1 RID: 2721
		public uint uint_6;

		// Token: 0x04000AA2 RID: 2722
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;
	}

	// Token: 0x0200013E RID: 318
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct29
	{
		// Token: 0x04000AA3 RID: 2723
		public uint uint_0;

		// Token: 0x04000AA4 RID: 2724
		public uint uint_1;

		// Token: 0x04000AA5 RID: 2725
		public uint uint_2;

		// Token: 0x04000AA6 RID: 2726
		public uint uint_3;

		// Token: 0x04000AA7 RID: 2727
		public uint uint_4;

		// Token: 0x04000AA8 RID: 2728
		public IntPtr intptr_0;

		// Token: 0x04000AA9 RID: 2729
		public uint uint_5;

		// Token: 0x04000AAA RID: 2730
		public IntPtr intptr_1;

		// Token: 0x04000AAB RID: 2731
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x04000AAC RID: 2732
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	// Token: 0x0200013F RID: 319
	private struct Struct30
	{
		// Token: 0x04000AAD RID: 2733
		public IntPtr intptr_0;

		// Token: 0x04000AAE RID: 2734
		public IntPtr intptr_1;

		// Token: 0x04000AAF RID: 2735
		public uint uint_0;

		// Token: 0x04000AB0 RID: 2736
		public UIntPtr uintptr_0;

		// Token: 0x04000AB1 RID: 2737
		public uint uint_1;

		// Token: 0x04000AB2 RID: 2738
		public uint uint_2;

		// Token: 0x04000AB3 RID: 2739
		public uint uint_3;
	}

	// Token: 0x02000140 RID: 320
	[CompilerGenerated]
	private sealed class Class213 : IEnumerable<ValueTuple<long, int>>, IEnumerator<ValueTuple<long, int>>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x0000DC2B File Offset: 0x0000BE2B
		[DebuggerHidden]
		public Class213(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0000DC45 File Offset: 0x0000BE45
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x000A61D4 File Offset: 0x000A43D4
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
			Class212.Struct30 @struct;
			if (Class212.VirtualQueryEx(this.intptr_2, (IntPtr)this.long_2, out @struct, (UIntPtr)((ulong)((long)Marshal.SizeOf(typeof(Class212.Struct30))))) == UIntPtr.Zero)
			{
				return false;
			}
			this.long_3 = @struct.intptr_0.ToInt64();
			this.long_4 = (long)(ulong)@struct.uintptr_0;
			if (this.long_4 <= 0L)
			{
				return false;
			}
			if (@struct.uint_1 != 4096U || !Class212.smethod_3(@struct.uint_2))
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0000DC4F File Offset: 0x0000BE4F
		public ValueTuple<long, int> Current
		{
			[DebuggerHidden]
			get
			{
				return this.valueTuple_0;
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0000DC57 File Offset: 0x0000BE57
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.valueTuple_0;
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000A6348 File Offset: 0x000A4548
		[DebuggerHidden]
		public IEnumerator<ValueTuple<long, int>> GetEnumerator()
		{
			Class212.Class213 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class212.Class213(0);
			}
			@class.intptr_2 = this.intptr_3;
			@class.intptr_0 = this.intptr_1;
			@class.uint_0 = this.uint_1;
			return @class;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0000DC64 File Offset: 0x0000BE64
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AB4 RID: 2740
		private int int_0;

		// Token: 0x04000AB5 RID: 2741
		private ValueTuple<long, int> valueTuple_0;

		// Token: 0x04000AB6 RID: 2742
		private int int_1;

		// Token: 0x04000AB7 RID: 2743
		private IntPtr intptr_0;

		// Token: 0x04000AB8 RID: 2744
		public IntPtr intptr_1;

		// Token: 0x04000AB9 RID: 2745
		private uint uint_0;

		// Token: 0x04000ABA RID: 2746
		public uint uint_1;

		// Token: 0x04000ABB RID: 2747
		private IntPtr intptr_2;

		// Token: 0x04000ABC RID: 2748
		public IntPtr intptr_3;

		// Token: 0x04000ABD RID: 2749
		private long long_0;

		// Token: 0x04000ABE RID: 2750
		private long long_1;

		// Token: 0x04000ABF RID: 2751
		private long long_2;

		// Token: 0x04000AC0 RID: 2752
		private long long_3;

		// Token: 0x04000AC1 RID: 2753
		private long long_4;
	}
}
