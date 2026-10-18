using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020001A7 RID: 423
internal class Class296 : Class295
{
	// Token: 0x06001835 RID: 6197 RVA: 0x00010A39 File Offset: 0x0000EC39
	private static IntPtr smethod_1(int int_0, string string_0)
	{
		return Class104.smethod_8(int_0, "kernel32.dll", string_0, 0);
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x000CA464 File Offset: 0x000C8664
	private static byte[] smethod_2(Class301 class301_0)
	{
		byte[] array = null;
		Class291 @class = new Class291(class301_0);
		Class291.Class293 class2 = null;
		int num = 0;
		while (num < @class.Class293_0.Class293_0.Length && class2 == null)
		{
			if ((long)@class.Class293_0.Class293_0[num].Int32_0 == 24L)
			{
				class2 = @class.Class293_0.Class293_0[num];
			}
			num++;
		}
		if (class2 != null && class2.Class293_0.Length != 0 && Class296.smethod_5(class2.Class293_0[0].Int32_0) && class2.Class293_0[0].Class294_0.Length == 1)
		{
			array = class2.Class293_0[0].Class294_0[0].method_0();
		}
		return array;
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x000CA50C File Offset: 0x000C870C
	private static uint smethod_3(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_0.smethod_4() || intptr_0.smethod_2(-1L))
		{
			throw new ArgumentException("Invalid process handle.", "hProcess");
		}
		if (intptr_1.smethod_4())
		{
			throw new ArgumentException("Invalid module handle.", "hModule");
		}
		byte[] array = GClass41.smethod_4(intptr_0, intptr_1, (uint)Marshal.SizeOf(typeof(GStruct4)));
		if (array != null)
		{
			ushort num = BitConverter.ToUInt16(array, 0);
			uint num2 = BitConverter.ToUInt32(array, 60);
			if (num == 23117)
			{
				byte[] array2 = GClass41.smethod_4(intptr_0, intptr_1.smethod_0((long)((ulong)num2)), (uint)Marshal.SizeOf(typeof(GStruct7)));
				if (array2 != null && BitConverter.ToUInt32(array2, 0) == 17744U)
				{
					GStruct7 gstruct = default(GStruct7);
					uint addressOfEntryPoint;
					using (Class302 @class = new Class302(256))
					{
						if (!@class.method_9<GStruct7>(array2, out gstruct))
						{
							return 0U;
						}
						addressOfEntryPoint = gstruct.OptionalHeader.AddressOfEntryPoint;
					}
					return addressOfEntryPoint;
				}
			}
		}
		return 0U;
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x000CA61C File Offset: 0x000C881C
	private static IntPtr smethod_4(string string_0, int int_0)
	{
		IntPtr intPtr = Class104.smethod_6(int_0, string_0);
		if (!intPtr.smethod_4())
		{
			return intPtr;
		}
		if (!string_0.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
		{
			intPtr = Class104.smethod_6(int_0, string_0 + ".dll");
		}
		return intPtr;
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x000CA65C File Offset: 0x000C885C
	public override IntPtr m_0AD323ED(Class301 class301_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		IntPtr intPtr;
		try
		{
			intPtr = Class296.smethod_7(GClass39.smethod_0<Class301>(class301_0), intptr_0, true);
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			intPtr = IntPtr.Zero;
		}
		return intPtr;
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x000CA6A4 File Offset: 0x000C88A4
	public override IntPtr m_11CA4005(string string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		IntPtr intPtr;
		try
		{
			using (Class301 @class = new Class301(string_0))
			{
				intPtr = this.m_0AD323ED(@class, intptr_0);
			}
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			intPtr = IntPtr.Zero;
		}
		return intPtr;
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x000CA704 File Offset: 0x000C8904
	public override IntPtr[] m_68422D2A(Class301[] class301_0, IntPtr intptr_0)
	{
		Class296.Class288 @class = new Class296.Class288();
		@class.class296_0 = this;
		@class.intptr_0 = intptr_0;
		this.vmethod_0();
		return Array.ConvertAll<Class301, IntPtr>(class301_0, new Converter<Class301, IntPtr>(@class.method_0));
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x000CA740 File Offset: 0x000C8940
	public override IntPtr[] m_12A0C7DB(string[] string_0, IntPtr intptr_0)
	{
		Class296.Class289 @class = new Class296.Class289();
		@class.class296_0 = this;
		@class.intptr_0 = intptr_0;
		this.vmethod_0();
		return Array.ConvertAll<string, IntPtr>(string_0, new Converter<string, IntPtr>(@class.method_0));
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x000CA77C File Offset: 0x000C897C
	private static bool smethod_5(int int_0)
	{
		return int_0 - 1 <= 2;
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x000CA794 File Offset: 0x000C8994
	private static bool smethod_6(Class301 class301_0, IntPtr intptr_0, int int_0)
	{
		List<string> list = new List<string>();
		string empty = string.Empty;
		bool flag = false;
		foreach (GStruct6 gstruct in class301_0.method_8())
		{
			if (class301_0.method_4((long)((ulong)class301_0.method_11(gstruct.Name)), SeekOrigin.Begin, out empty, -1, null) && !string.IsNullOrEmpty(empty) && !empty.StartsWith("api-ms-", StringComparison.OrdinalIgnoreCase) && !empty.StartsWith("ext-ms-", StringComparison.OrdinalIgnoreCase) && Class296.smethod_4(empty, int_0).smethod_4())
			{
				list.Add(empty);
			}
		}
		if (list.Count > 0)
		{
			byte[] array = Class296.smethod_2(class301_0);
			string text = string.Empty;
			if (array == null)
			{
				if (string.IsNullOrEmpty(class301_0.String_0) || !File.Exists(Path.Combine(Path.GetDirectoryName(class301_0.String_0), Path.GetFileName(class301_0.String_0) + ".manifest")))
				{
					IntPtr[] array2 = Class295.smethod_0(GEnum9.Standard).m_12A0C7DB(list.ToArray(), intptr_0);
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i].smethod_4())
						{
							return false;
						}
					}
					return true;
				}
				text = Path.Combine(Path.GetDirectoryName(class301_0.String_0), Path.GetFileName(class301_0.String_0) + ".manifest");
			}
			else
			{
				text = GClass39.smethod_2(array);
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			IntPtr intPtr = Class296.smethod_1(int_0, "CreateActCtxA");
			IntPtr intPtr2 = Class296.smethod_1(int_0, "ActivateActCtx");
			IntPtr intPtr3 = Class296.smethod_1(int_0, "GetModuleHandleA");
			IntPtr intPtr4 = Class296.smethod_1(int_0, "LoadLibraryA");
			IntPtr intPtr5 = Class296.smethod_1(int_0, "DeactivateActCtx");
			IntPtr intPtr6 = Class296.smethod_1(int_0, "ReleaseActCtx");
			IntPtr intPtr7 = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)Class296.byte_1.Length, 12288, 64);
			IntPtr intPtr8 = GClass41.smethod_0(intptr_0, Encoding.ASCII.GetBytes(text + "\0"), 4);
			IntPtr intPtr9 = GClass41.smethod_0(intptr_0, Encoding.ASCII.GetBytes(string.Join("\0", list.ToArray()) + "\0"), 4);
			if (!intPtr7.smethod_4())
			{
				byte[] array3 = (byte[])Class296.byte_1.Clone();
				uint num = 0U;
				BitConverter.GetBytes(intPtr.smethod_7(intPtr7.smethod_0(63L)).smethod_8()).CopyTo(array3, 59);
				BitConverter.GetBytes(intPtr2.smethod_7(intPtr7.smethod_0(88L)).smethod_8()).CopyTo(array3, 84);
				BitConverter.GetBytes(intPtr3.smethod_7(intPtr7.smethod_0(132L)).smethod_8()).CopyTo(array3, 128);
				BitConverter.GetBytes(intPtr4.smethod_7(intPtr7.smethod_0(146L)).smethod_8()).CopyTo(array3, 142);
				BitConverter.GetBytes(intPtr5.smethod_7(intPtr7.smethod_0(200L)).smethod_8()).CopyTo(array3, 196);
				BitConverter.GetBytes(intPtr6.smethod_7(intPtr7.smethod_0(209L)).smethod_8()).CopyTo(array3, 205);
				BitConverter.GetBytes(intPtr8.smethod_8()).CopyTo(array3, 31);
				BitConverter.GetBytes(list.Count).CopyTo(array3, 40);
				BitConverter.GetBytes(intPtr9.smethod_8()).CopyTo(array3, 49);
				if (GClass41.WriteProcessMemory(intptr_0, intPtr7, array3, array3.Length, out num) && (ulong)num == (ulong)((long)array3.Length))
				{
					uint num2 = GClass41.smethod_7(intptr_0, intPtr7, 0U, 5000);
					flag = num2 != uint.MaxValue && num2 > 0U;
				}
				GClass41.VirtualFreeEx(intptr_0, intPtr9, 0, 32768);
				GClass41.VirtualFreeEx(intptr_0, intPtr8, 0, 32768);
				GClass41.VirtualFreeEx(intptr_0, intPtr7, 0, 32768);
			}
		}
		return flag;
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x000CAB90 File Offset: 0x000C8D90
	public static IntPtr smethod_7(Class301 class301_0, IntPtr intptr_0, bool bool_0 = false)
	{
		if (intptr_0.smethod_4() || intptr_0.smethod_2(-1L))
		{
			throw new ArgumentException("Invalid process handle.", "hProcess");
		}
		if (class301_0 == null)
		{
			throw new ArgumentException("Cannot map a non-existant PE Image.", "image");
		}
		int processId = GClass41.GetProcessId(intptr_0);
		if (processId == 0)
		{
			throw new ArgumentException("Provided handle doesn't have sufficient permissions to inject", "hProcess");
		}
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		uint num = 0U;
		try
		{
			intPtr = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, class301_0.GStruct7_0.OptionalHeader.SizeOfImage, 12288, 4);
			if (intPtr.smethod_4())
			{
				return (IntPtr)999;
			}
			Class296.smethod_10(class301_0, intPtr);
			Class296.smethod_6(class301_0, intptr_0, processId);
			Class296.smethod_9(class301_0, intptr_0, processId);
			if (bool_0)
			{
				byte[] array = new byte[(ulong)class301_0.GStruct4_0.e_lfanew + (ulong)((long)Marshal.SizeOf(typeof(GStruct5))) + 4UL + (ulong)class301_0.GStruct7_0.FileHeader.SizeOfOptionalHeader];
				if (class301_0.method_2(0L, SeekOrigin.Begin, array))
				{
					GClass41.WriteProcessMemory(intptr_0, intPtr, array, array.Length, out num);
				}
			}
			Class296.smethod_8(class301_0, intptr_0, intPtr);
			if (class301_0.GStruct7_0.OptionalHeader.AddressOfEntryPoint <= 0U)
			{
				return intPtr;
			}
			byte[] array2 = (byte[])Class296.byte_0.Clone();
			BitConverter.GetBytes(intPtr.smethod_8()).CopyTo(array2, 11);
			intPtr2 = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)Class296.byte_0.Length, 12288, 64);
			if (!intPtr2.smethod_4() && GClass41.WriteProcessMemory(intptr_0, intPtr2, array2, array2.Length, out num))
			{
				if ((ulong)num == (ulong)((long)array2.Length))
				{
					IntPtr intPtr3 = GClass41.CreateRemoteThread(intptr_0, 0, 0, intPtr2, (uint)intPtr.smethod_0((long)((ulong)class301_0.GStruct7_0.OptionalHeader.AddressOfEntryPoint)).smethod_8(), 0, 0);
					if ((ulong)GClass41.WaitForSingleObject(intPtr3, 5000) != 0UL)
					{
						return intPtr;
					}
					GClass41.GetExitCodeThread(intPtr3, out num);
					if (num == 0U)
					{
						GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
						throw new Exception("Entry method of module reported a failure " + Marshal.GetLastWin32Error().ToString());
					}
					GClass41.VirtualFreeEx(intptr_0, intPtr2, 0, 32768);
					GClass41.CloseHandle(intPtr3);
					return intPtr;
				}
			}
			throw new InvalidOperationException("Unable to write stub to the remote process.");
		}
		catch (Exception ex)
		{
			if (!intPtr.smethod_4())
			{
				GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
			}
			if (!intPtr2.smethod_4())
			{
				GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
			}
			intPtr = IntPtr.Zero;
			throw ex;
		}
		return intPtr;
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x000CAE40 File Offset: 0x000C9040
	private static void smethod_8(Class301 class301_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		foreach (GStruct12 gstruct in class301_0.method_9())
		{
			byte[] array = new byte[gstruct.SizeOfRawData];
			if (!class301_0.method_2((long)((ulong)gstruct.PointerToRawData), SeekOrigin.Begin, array))
			{
				throw class301_0.vmethod_1();
			}
			if ((gstruct.Characteristics & 33554432U) == 0U)
			{
				uint num;
				GClass41.WriteProcessMemory(intptr_0, intptr_1.smethod_0((long)((ulong)gstruct.VirtualAddress)), array, array.Length, out num);
				IntPtr intPtr = intptr_1.smethod_0((long)((ulong)gstruct.VirtualAddress));
				GClass41.VirtualProtectEx(intptr_0, intPtr, gstruct.SizeOfRawData, gstruct.Characteristics & 16777215U, out num);
			}
		}
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x000CAF04 File Offset: 0x000C9104
	private static void smethod_9(Class301 class301_0, IntPtr intptr_0, int int_0)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		foreach (GStruct6 gstruct in class301_0.method_8())
		{
			if (class301_0.method_4((long)((ulong)class301_0.method_11(gstruct.Name)), SeekOrigin.Begin, out empty, -1, null))
			{
				uint num = class301_0.method_11(gstruct.FirstThunkPtr);
				uint num2 = (uint)Marshal.SizeOf(typeof(GStruct13));
				GStruct13 gstruct2;
				while (class301_0.method_3<GStruct13>((long)((ulong)num), SeekOrigin.Begin, out gstruct2) && gstruct2.u1.AddressOfData > 0U)
				{
					string text;
					if ((gstruct2.u1.Ordinal & 2147483648U) == 0U)
					{
						if (!class301_0.method_4((long)((ulong)(class301_0.method_11(gstruct2.u1.AddressOfData) + 2U)), SeekOrigin.Begin, out empty2, -1, null))
						{
							throw class301_0.vmethod_1();
						}
						text = empty2;
					}
					else
					{
						text = "#" + ((ushort)(gstruct2.u1.Ordinal & 65535U)).ToString();
					}
					IntPtr intPtr = Class104.smethod_8(int_0, empty, text, 0);
					if (intPtr.smethod_4())
					{
						throw new EntryPointNotFoundException(string.Format("Unable to locate imported function '{0}' from module '{1}' in the remote process.", empty2, empty));
					}
					class301_0.method_7<int>((long)((ulong)num), SeekOrigin.Begin, intPtr.smethod_8());
					num += num2;
				}
			}
		}
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x000CB07C File Offset: 0x000C927C
	private static void smethod_10(Class301 class301_0, IntPtr intptr_0)
	{
		GStruct3 gstruct = class301_0.GStruct7_0.OptionalHeader.DataDirectory[5];
		if (gstruct.Size > 0U)
		{
			uint num = 0U;
			uint num2 = (uint)(intptr_0.smethod_8() - (int)class301_0.GStruct7_0.OptionalHeader.ImageBase);
			uint num3 = class301_0.method_11(gstruct.VirtualAddress);
			uint num4 = (uint)Marshal.SizeOf(typeof(GStruct2));
			GStruct2 gstruct2;
			while (num < gstruct.Size && class301_0.method_3<GStruct2>((long)((ulong)num3), SeekOrigin.Begin, out gstruct2))
			{
				int num5 = (int)((gstruct2.SizeOfBlock - num4) / 2U);
				uint num6 = class301_0.method_11(gstruct2.VirtualAddress);
				for (int i = 0; i < num5; i++)
				{
					ushort num7;
					if (class301_0.method_3<ushort>((long)((ulong)(num3 + num4) + (ulong)((long)((long)i << 1))), SeekOrigin.Begin, out num7) && ((num7 >> 12) & 3) != 0)
					{
						uint num8 = num6 + (uint)(num7 & 4095);
						uint num9;
						if (!class301_0.method_3<uint>((long)((ulong)num8), SeekOrigin.Begin, out num9))
						{
							throw class301_0.vmethod_1();
						}
						class301_0.method_7<uint>(-4L, SeekOrigin.Current, num9 + num2);
					}
				}
				num += gstruct2.SizeOfBlock;
				num3 += gstruct2.SizeOfBlock;
			}
		}
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x000CB1A0 File Offset: 0x000C93A0
	public override bool m_D3316F8A(IntPtr intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		if (intptr_0.smethod_4())
		{
			throw new ArgumentNullException("hModule", "Invalid module handle");
		}
		if (!intptr_1.smethod_4() && !intptr_1.smethod_2(-1L))
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0U;
			try
			{
				uint num2 = Class296.smethod_3(intptr_1, intptr_0);
				if (num2 != 0U)
				{
					byte[] array = (byte[])Class296.byte_0.Clone();
					BitConverter.GetBytes(intptr_0.smethod_8()).CopyTo(array, 11);
					BitConverter.GetBytes(0U).CopyTo(array, 6);
					BitConverter.GetBytes(1000U).CopyTo(array, 1);
					intPtr = GClass41.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)Class296.byte_0.Length, 12288, 64);
					if (!intPtr.smethod_4() && GClass41.WriteProcessMemory(intptr_1, intPtr, array, array.Length, out num))
					{
						if ((ulong)num == (ulong)((long)array.Length))
						{
							IntPtr intPtr2 = GClass41.CreateRemoteThread(intptr_1, 0, 0, intPtr, (uint)intptr_0.smethod_0((long)((ulong)num2)).smethod_8(), 0, 0);
							if ((ulong)GClass41.WaitForSingleObject(intPtr2, 5000) == 0UL)
							{
								GClass41.VirtualFreeEx(intptr_1, intPtr, 0, 32768);
								GClass41.CloseHandle(intPtr2);
								return GClass41.VirtualFreeEx(intptr_1, intptr_0, 0, 32768);
							}
							return false;
						}
					}
					throw new InvalidOperationException("Unable to write stub to the remote process.");
				}
				return GClass41.VirtualFreeEx(intptr_1, intptr_0, 0, 32768);
			}
			catch (Exception ex)
			{
				this.vmethod_2(ex);
				return false;
			}
		}
		throw new ArgumentException("Invalid process handle.", "hProcess");
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x000CB320 File Offset: 0x000C9520
	public override bool[] m_6D139C37(IntPtr[] intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		if (intptr_0 == null)
		{
			throw new ArgumentNullException("hModules", "Parameter cannot be null.");
		}
		if (!intptr_1.smethod_4() && !intptr_1.smethod_2(-1L))
		{
			try
			{
				bool[] array = new bool[intptr_0.Length];
				for (int i = 0; i < intptr_0.Length; i++)
				{
					array[i] = this.m_D3316F8A(intptr_0[i], intptr_1);
				}
				return array;
			}
			catch (Exception ex)
			{
				this.vmethod_2(ex);
				return null;
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x04000F8E RID: 3982
	private static readonly byte[] byte_0 = new byte[]
	{
		104, 0, 0, 0, 0, 104, 1, 0, 0, 0,
		104, 0, 0, 0, 0, byte.MaxValue, 84, 36, 16, 194,
		4, 0
	};

	// Token: 0x04000F8F RID: 3983
	private static readonly byte[] byte_1 = new byte[]
	{
		85, 139, 236, 131, 236, 60, 139, 204, 139, 209,
		131, 194, 60, 199, 1, 0, 0, 0, 0, 131,
		193, 4, 59, 202, 126, 243, 198, 4, 36, 32,
		185, 0, 0, 0, 0, 137, 76, 36, 8, 185,
		0, 0, 0, 0, 137, 76, 36, 40, 185, 0,
		0, 0, 0, 137, 76, 36, 44, 84, 232, 0,
		0, 0, 0, 131, 56, byte.MaxValue, 15, 132, 137, 0,
		0, 0, 137, 68, 36, 48, 139, 204, 131, 193,
		32, 81, 80, 232, 0, 0, 0, 0, 131, 248,
		0, 116, 107, 198, 68, 36, 36, 1, 139, 76,
		36, 40, 131, 249, 0, 126, 62, 131, 233, 1,
		137, 76, 36, 40, 139, 76, 36, 36, 131, 249,
		0, 116, 46, byte.MaxValue, 116, 36, 44, 232, 0, 0,
		0, 0, 131, 248, 0, 117, 9, byte.MaxValue, 116, 36,
		44, 232, 0, 0, 0, 0, 137, 68, 36, 36,
		139, 76, 36, 44, 138, 1, 131, 193, 1, 60,
		0, 117, 247, 137, 76, 36, 44, 235, 185, 139,
		68, 36, 36, 185, 1, 0, 0, 0, 35, 193,
		137, 76, 36, 36, 131, 249, 0, 117, 20, byte.MaxValue,
		116, 36, 32, 106, 0, 232, 0, 0, 0, 0,
		byte.MaxValue, 116, 36, 48, 232, 0, 0, 0, 0, 139,
		68, 36, 36, 139, 229, 93, 195
	};

	// Token: 0x020001A8 RID: 424
	[CompilerGenerated]
	private sealed class Class288
	{
		// Token: 0x06001848 RID: 6216 RVA: 0x00010A83 File Offset: 0x0000EC83
		internal IntPtr method_0(Class301 class301_0)
		{
			return this.class296_0.m_0AD323ED(class301_0, this.intptr_0);
		}

		// Token: 0x04000F90 RID: 3984
		public Class296 class296_0;

		// Token: 0x04000F91 RID: 3985
		public IntPtr intptr_0;
	}

	// Token: 0x020001A9 RID: 425
	[CompilerGenerated]
	private sealed class Class289
	{
		// Token: 0x0600184A RID: 6218 RVA: 0x00010A97 File Offset: 0x0000EC97
		internal IntPtr method_0(string string_0)
		{
			return this.class296_0.m_11CA4005(string_0, this.intptr_0);
		}

		// Token: 0x04000F92 RID: 3986
		public Class296 class296_0;

		// Token: 0x04000F93 RID: 3987
		public IntPtr intptr_0;
	}
}
