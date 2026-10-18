using System;
using System.Diagnostics;
using System.Threading;

// Token: 0x020001AC RID: 428
internal class Class299 : Class297
{
	// Token: 0x06001855 RID: 6229 RVA: 0x000CB9C4 File Offset: 0x000C9BC4
	public override IntPtr m_11CA4005(string string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		IntPtr[] array = this.m_12A0C7DB(new string[] { string_0 }, intptr_0);
		if (array != null && array[0].smethod_4() && this.vmethod_1() == null)
		{
			this.vmethod_2(new Exception("Module's entry point function reported a failure"));
		}
		if (array != null && array.Length != 0)
		{
			return array[0];
		}
		return IntPtr.Zero;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x000CBA20 File Offset: 0x000C9C20
	public override IntPtr[] m_12A0C7DB(string[] string_0, IntPtr intptr_0)
	{
		this.vmethod_0();
		IntPtr[] array4;
		try
		{
			if (intptr_0.smethod_4() || intptr_0.smethod_2(-1L))
			{
				throw new ArgumentException("Invalid process handle.", "hProcess");
			}
			int processId = GClass41.GetProcessId(intptr_0);
			if (processId == 0)
			{
				throw new ArgumentException("Provided handle doesn't have sufficient permissions to inject", "hProcess");
			}
			Process processById = Process.GetProcessById(processId);
			if (processById.Threads.Count == 0)
			{
				throw new Exception("Target process has no targetable threads to hijack.");
			}
			ProcessThread processThread = Class299.smethod_1(processById);
			IntPtr intPtr = GClass41.OpenThread(26U, false, processThread.Id);
			if (intPtr.smethod_4() || intPtr.smethod_2(-1L))
			{
				throw new Exception("Unable to obtain a handle for the remote thread.");
			}
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			IntPtr intPtr2 = this.vmethod_10(string_0, intptr_0, out zero, 1U);
			IntPtr[] array = null;
			if (!intPtr2.smethod_4())
			{
				if (GClass41.SuspendThread(intPtr) == 4294967295U)
				{
					throw new Exception("Unable to suspend the remote thread");
				}
				try
				{
					uint num = 0U;
					GClass41.GStruct15 gstruct = new GClass41.GStruct15
					{
						uint_0 = 65537U
					};
					if (!GClass41.GetThreadContext(intPtr, ref gstruct))
					{
						throw new InvalidOperationException("Cannot get the remote thread's context");
					}
					byte[] array2 = Class299.byte_2;
					IntPtr intPtr3 = GClass41.VirtualAllocEx(intptr_0, IntPtr.Zero, (uint)array2.Length, 12288, 64);
					if (intPtr3.smethod_4())
					{
						throw new InvalidOperationException("Unable to allocate memory in the remote process.");
					}
					BitConverter.GetBytes(intPtr2.smethod_7(intPtr3.smethod_0(7L)).smethod_8()).CopyTo(array2, 3);
					BitConverter.GetBytes(gstruct.uint_18 - (uint)intPtr3.smethod_0((long)array2.Length).smethod_8()).CopyTo(array2, array2.Length - 4);
					if (!GClass41.WriteProcessMemory(intptr_0, intPtr3, array2, array2.Length, out num) || (ulong)num != (ulong)((long)array2.Length))
					{
						throw new InvalidOperationException("Unable to write stub to the remote process.");
					}
					gstruct.uint_18 = (uint)intPtr3.smethod_8();
					GClass41.SetThreadContext(intPtr, ref gstruct);
				}
				catch (Exception ex)
				{
					this.vmethod_2(ex);
					array = null;
					GClass41.VirtualFreeEx(intptr_0, zero, 0, 32768);
					GClass41.VirtualFreeEx(intptr_0, intPtr2, 0, 32768);
					GClass41.VirtualFreeEx(intptr_0, zero2, 0, 32768);
				}
				GClass41.ResumeThread(intPtr);
				if (this.vmethod_1() == null)
				{
					Thread.Sleep(100);
					array = new IntPtr[string_0.Length];
					byte[] array3 = GClass41.smethod_4(intptr_0, zero, (uint)((uint)string_0.Length << 2));
					if (array3 != null)
					{
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = GClass40.smethod_3((long)BitConverter.ToInt32(array3, i << 2));
						}
					}
				}
				GClass41.CloseHandle(intPtr);
			}
			array4 = array;
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			array4 = null;
		}
		return array4;
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00010B28 File Offset: 0x0000ED28
	private static ProcessThread smethod_1(Process process_0)
	{
		return process_0.Threads[0];
	}

	// Token: 0x04000F98 RID: 3992
	private static readonly byte[] byte_2 = new byte[]
	{
		156, 96, 232, 0, 0, 0, 0, 97, 157, 233,
		0, 0, 0, 0
	};
}
