using System;
using System.Text;

// Token: 0x020001A3 RID: 419
internal class Class287
{
	// Token: 0x0600181E RID: 6174 RVA: 0x000C9F04 File Offset: 0x000C8104
	public static int smethod_0(byte[] byte_0, IntPtr intptr_0)
	{
		object object_ = Class106.Object_0;
		lock (object_)
		{
			Class287.int_0 = 0;
			for (int i = 0; i < byte_0.Length; i++)
			{
				Class287.int_0 += (int)byte_0[i];
			}
		}
		GClass38 gclass = new Class296();
		Class301 @class = new Class301(byte_0);
		gclass.vmethod_0();
		return Class296.smethod_7(@class, intptr_0, false).smethod_8();
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00010A0A File Offset: 0x0000EC0A
	public static IntPtr smethod_1(string string_0, IntPtr intptr_0)
	{
		return new Class299().m_11CA4005(string_0, intptr_0);
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x000C9F80 File Offset: 0x000C8180
	public static IntPtr smethod_2(string string_0, IntPtr intptr_0)
	{
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
				throw new Exception(ex.ToString());
			}
		}
		throw new ArgumentOutOfRangeException("hProcess", "Invalid process handle specified.");
	}

	// Token: 0x04000F88 RID: 3976
	public static int int_0;
}
