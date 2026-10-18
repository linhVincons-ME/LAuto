using System;
using System.Text;

// Token: 0x020001A4 RID: 420
internal class Class298 : Class297
{
	// Token: 0x06001822 RID: 6178 RVA: 0x000CA0AC File Offset: 0x000C82AC
	public override IntPtr m_11CA4005(string string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		if (!intptr_0.smethod_4() && !intptr_0.smethod_2(-1L))
		{
			try
			{
				IntPtr intPtr = IntPtr.Zero;
				IntPtr intPtr2 = Class104.smethod_8(GClass41.GetProcessId(intptr_0), "kernel32.dll", "LoadLibraryW", 0);
				if (intPtr2.smethod_4())
				{
					throw new Exception("Unable to locate the LoadLibraryW entry point");
				}
				IntPtr intPtr3 = GClass41.smethod_0(intptr_0, Encoding.Unicode.GetBytes(string_0 + "\0"), 4);
				if (intPtr3.smethod_4())
				{
					throw new InvalidOperationException("Failed to allocate memory in the remote process");
				}
				try
				{
					uint num = GClass41.smethod_7(intptr_0, intPtr2, (uint)intPtr3.smethod_8(), 10000);
					if (num == 0U)
					{
						throw new Exception("Failed to load module into remote process. Error code: " + GClass41.smethod_1(intptr_0).ToString());
					}
					if (num == 4294967295U)
					{
						throw new Exception("Error occurred when calling function in the remote process");
					}
					intPtr = GClass40.smethod_3((long)((ulong)num));
				}
				finally
				{
					GClass41.VirtualFreeEx(intptr_0, intPtr3, 0, 32768);
				}
				return intPtr;
			}
			catch (Exception ex)
			{
				this.vmethod_2(ex);
				return IntPtr.Zero;
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x000CA1E4 File Offset: 0x000C83E4
	public override IntPtr[] m_12A0C7DB(string[] string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		if (!intptr_0.smethod_4() && !intptr_0.smethod_2(-1L))
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr intPtr = this.vmethod_10(string_0, intptr_0, out zero, 0U);
				IntPtr[] array = null;
				if (!intPtr.smethod_4())
				{
					try
					{
						if (GClass41.smethod_7(intptr_0, intPtr, 0U, 10000) == 4294967295U)
						{
							throw new Exception("Error occurred while executing remote thread.");
						}
						byte[] array2 = GClass41.smethod_4(intptr_0, zero, (uint)((uint)string_0.Length << 2));
						if (array2 == null)
						{
							throw new InvalidOperationException("Unable to read from the remote process.");
						}
						array = new IntPtr[string_0.Length];
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = new IntPtr((long)((ulong)BitConverter.ToUInt32(array2, i << 2)));
						}
					}
					finally
					{
						GClass41.VirtualFreeEx(intptr_0, zero, 0, 32768);
						GClass41.VirtualFreeEx(intptr_0, intPtr, 0, 32768);
					}
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
}
