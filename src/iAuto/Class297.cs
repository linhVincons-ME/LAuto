using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020001AA RID: 426
internal abstract class Class297 : Class295
{
	// Token: 0x0600184B RID: 6219 RVA: 0x000CB3B8 File Offset: 0x000C95B8
	protected virtual IntPtr vmethod_10(string[] string_0, IntPtr intptr_0, out IntPtr intptr_1, uint uint_0 = 0U)
	{
		intptr_1 = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr6;
		try
		{
			IntPtr intPtr2 = Class104.smethod_6(GClass41.GetProcessId(intptr_0), "kernel32.dll");
			IntPtr intPtr3 = Class104.smethod_8(GClass41.GetProcessId(intptr_0), "kernel32.dll", "LoadLibraryA", 0);
			IntPtr intPtr4 = Class104.smethod_8(GClass41.GetProcessId(intptr_0), "kernel32.dll", "GetModuleHandleA", 0);
			if (!intPtr2.smethod_4() && !intPtr3.smethod_4() && !intPtr4.smethod_4())
			{
				intptr_1 = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)((uint)string_0.Length << 2), 12288, 4);
				IntPtr intPtr5 = GClass41.smethod_0(intptr_0, Encoding.ASCII.GetBytes(string.Join("\0", string_0) + "\0"), 4);
				if (!intptr_1.smethod_4() && !intPtr5.smethod_4())
				{
					try
					{
						uint num = 0U;
						byte[] array = new byte[string_0.Length << 2];
						for (int i = 0; i < array.Length >> 2; i++)
						{
							BitConverter.GetBytes(uint_0).CopyTo(array, i << 2);
						}
						GClass41.WriteProcessMemory(intptr_0, intptr_1, array, array.Length, out num);
						byte[] array2 = (byte[])Class297.byte_0.Clone();
						intPtr = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)array2.Length, 12288, 64);
						if (intPtr.smethod_4())
						{
							throw new InvalidOperationException("Unable to allocate memory in the remote process");
						}
						BitConverter.GetBytes(intPtr5.smethod_8()).CopyTo(array2, 7);
						BitConverter.GetBytes(string_0.Length).CopyTo(array2, 15);
						BitConverter.GetBytes(intptr_1.smethod_8()).CopyTo(array2, 24);
						BitConverter.GetBytes(intPtr4.smethod_7(intPtr.smethod_0(56L)).smethod_8()).CopyTo(array2, 52);
						BitConverter.GetBytes(intPtr3.smethod_7(intPtr.smethod_0(69L)).smethod_8()).CopyTo(array2, 65);
						if (!GClass41.WriteProcessMemory(intptr_0, intPtr, array2, array2.Length, out num) || (ulong)num != (ulong)((long)array2.Length))
						{
							throw new Exception("Error creating the remote function stub.");
						}
						intPtr6 = intPtr;
						goto IL_024C;
					}
					finally
					{
						GClass41.VirtualFreeEx(intptr_0, intptr_1, 0, 32768);
						GClass41.VirtualFreeEx(intptr_0, intPtr5, 0, 32768);
						if (!intPtr.smethod_4())
						{
							GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
						}
						intptr_1 = IntPtr.Zero;
					}
					goto IL_0236;
					IL_024C:
					return intPtr6;
				}
				IL_0236:
				throw new InvalidOperationException("Unable to allocate memory in the remote process");
			}
			throw new Exception("Unable to find necessary function entry points in the remote process");
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			intPtr6 = IntPtr.Zero;
		}
		return intPtr6;
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x000CB65C File Offset: 0x000C985C
	public override IntPtr m_0AD323ED(Class301 class301_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		string text = GClass39.smethod_2(class301_0.method_12());
		IntPtr intPtr = IntPtr.Zero;
		if (!string.IsNullOrEmpty(text))
		{
			intPtr = this.m_11CA4005(text, intptr_0);
			try
			{
				File.Delete(text);
			}
			catch
			{
			}
		}
		return intPtr;
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00010AAB File Offset: 0x0000ECAB
	public override IntPtr[] m_68422D2A(Class301[] class301_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		return this.m_12A0C7DB(Array.ConvertAll<Class301, string>(class301_0, new Converter<Class301, string>(Class297.Class290.f_3E6A6624.method_0)), intptr_0);
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x000CB6B0 File Offset: 0x000C98B0
	public override bool m_D3316F8A(IntPtr intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		if (!intptr_1.smethod_4() && !intptr_1.smethod_2(-1L))
		{
			if (intptr_0.smethod_4())
			{
				throw new ArgumentNullException("hModule", "Invalid module handle");
			}
			try
			{
				IntPtr[] array = new IntPtr[] { intptr_0 };
				bool[] array2 = this.m_6D139C37(array, intptr_1);
				return array2 != null && array2.Length != 0 && array2[0];
			}
			catch (Exception ex)
			{
				this.vmethod_2(ex);
				return false;
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x000CB748 File Offset: 0x000C9948
	public override bool[] m_6D139C37(IntPtr[] intptr_0, IntPtr intptr_1)
	{
		this.vmethod_0();
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		bool[] array5;
		try
		{
			uint num = 0U;
			IntPtr intPtr4 = Class104.smethod_8(GClass41.GetProcessId(intptr_1), "kernel32.dll", "FreeLibrary", 0);
			if (intPtr4.smethod_4())
			{
				throw new Exception("Unable to find necessary function entry points in the remote process");
			}
			intPtr = GClass41.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)((uint)intptr_0.Length << 2), 12288, 4);
			intPtr2 = GClass41.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)((uint)(intptr_0.Length + 1) << 2), 12288, 4);
			intPtr3 = GClass41.VirtualAllocEx(intptr_1, IntPtr.Zero, (uint)Class297.byte_1.Length, 12288, 64);
			if (!intPtr.smethod_4() && !intPtr2.smethod_4() && !intPtr3.smethod_4())
			{
				byte[] array = new byte[intptr_0.Length + 1 << 2];
				for (int i = 0; i < intptr_0.Length; i++)
				{
					BitConverter.GetBytes(intptr_0[i].smethod_8()).CopyTo(array, i << 2);
				}
				GClass41.WriteProcessMemory(intptr_1, intPtr2, array, array.Length, out num);
				byte[] array2 = (byte[])Class297.byte_1.Clone();
				BitConverter.GetBytes(intPtr2.smethod_8()).CopyTo(array2, 7);
				BitConverter.GetBytes(intPtr.smethod_8()).CopyTo(array2, 15);
				BitConverter.GetBytes(intPtr4.smethod_7(intPtr3.smethod_0(56L)).smethod_8()).CopyTo(array2, 52);
				if (GClass41.WriteProcessMemory(intptr_1, intPtr3, array2, array2.Length, out num))
				{
					if ((ulong)num == (ulong)((long)array2.Length))
					{
						if (GClass41.smethod_7(intptr_1, intPtr3, 0U, 1000) == 4294967295U)
						{
							throw new InvalidOperationException("Error occurred when running remote function stub.");
						}
						byte[] array3 = GClass41.smethod_4(intptr_1, intPtr, (uint)((uint)intptr_0.Length << 2));
						if (array3 == null)
						{
							throw new Exception("Unable to read results from the remote process.");
						}
						bool[] array4 = new bool[intptr_0.Length];
						for (int i = 0; i < array4.Length; i++)
						{
							array4[i] = BitConverter.ToInt32(array3, i << 2) != 0;
						}
						return array4;
					}
				}
				throw new InvalidOperationException("Unable to write the function stub to the remote process.");
			}
			throw new InvalidOperationException("Unable to allocate memory in the remote process");
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			array5 = null;
		}
		finally
		{
			GClass41.VirtualFreeEx(intptr_1, intPtr3, 0, 32768);
			GClass41.VirtualFreeEx(intptr_1, intPtr, 0, 32768);
			GClass41.VirtualFreeEx(intptr_1, intPtr2, 0, 32768);
		}
		return array5;
	}

	// Token: 0x04000F94 RID: 3988
	protected static readonly byte[] byte_0 = new byte[]
	{
		85, 139, 236, 131, 236, 12, 185, 0, 0, 0,
		0, 137, 12, 36, 185, 0, 0, 0, 0, 137,
		76, 36, 4, 185, 0, 0, 0, 0, 137, 76,
		36, 8, 139, 76, 36, 4, 131, 249, 0, 116,
		58, 131, 233, 1, 137, 76, 36, 4, byte.MaxValue, 52,
		36, 232, 0, 0, 0, 0, 131, 248, 0, 117,
		8, byte.MaxValue, 52, 36, 232, 0, 0, 0, 0, 139,
		76, 36, 8, 137, 1, 131, 193, 4, 137, 76,
		36, 8, 139, 12, 36, 138, 1, 131, 193, 1,
		60, 0, 117, 247, 137, 12, 36, 235, 189, 139,
		229, 93, 195
	};

	// Token: 0x04000F95 RID: 3989
	protected static readonly byte[] byte_1 = new byte[]
	{
		85, 139, 236, 131, 236, 12, 185, 0, 0, 0,
		0, 137, 12, 36, 185, 0, 0, 0, 0, 137,
		76, 36, 4, 139, 12, 36, 139, 9, 131, 249,
		0, 116, 58, 137, 76, 36, 8, 139, 76, 36,
		4, 199, 1, 0, 0, 0, 0, byte.MaxValue, 116, 36,
		8, 232, 0, 0, 0, 0, 131, 248, 0, 116,
		8, 139, 76, 36, 4, 137, 1, 235, 234, 139,
		12, 36, 131, 193, 4, 137, 12, 36, 139, 76,
		36, 4, 131, 193, 4, 137, 76, 36, 4, 235,
		188, 139, 229, 93, 195
	};

	// Token: 0x020001AB RID: 427
	[CompilerGenerated]
	[Serializable]
	private sealed class Class290
	{
		// Token: 0x06001854 RID: 6228 RVA: 0x00010B1B File Offset: 0x0000ED1B
		internal string method_0(Class301 class301_0)
		{
			return GClass39.smethod_2(class301_0.method_12());
		}

		// Token: 0x04000F96 RID: 3990
		public static readonly Class297.Class290 f_3E6A6624 = new Class297.Class290();

		// Token: 0x04000F97 RID: 3991
		public static Converter<Class301, string> f_AD837E7D;
	}
}
