using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _i
{
	// Token: 0x0200009B RID: 155
	public static class ChatServerMMF
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x00033CC0 File Offset: 0x00031EC0
		public static void smethod_0()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			EventHandler eventHandler;
			if ((eventHandler = ChatServerMMF.Class85.eventHandler_0) == null)
			{
				eventHandler = (ChatServerMMF.Class85.eventHandler_0 = new EventHandler(ChatServerMMF.smethod_7));
			}
			currentDomain.ProcessExit += eventHandler;
			ThreadStart threadStart;
			if ((threadStart = ChatServerMMF.Class85.threadStart_0) == null)
			{
				threadStart = (ChatServerMMF.Class85.threadStart_0 = new ThreadStart(ChatServerMMF.smethod_1));
			}
			new Thread(threadStart)
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00033D20 File Offset: 0x00031F20
		private static void smethod_1()
		{
			while (ChatServerMMF.bool_0)
			{
				try
				{
					foreach (Class106 @class in Class106.List_3)
					{
						if (!ChatServerMMF.concurrentDictionary_0.ContainsKey(@class.Process_0.Id))
						{
							ChatServerMMF.smethod_2(@class);
						}
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(3000);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00033DB0 File Offset: 0x00031FB0
		private static void smethod_2(Class106 class106_0)
		{
			ChatServerMMF.Class86 @class = new ChatServerMMF.Class86();
			@class.int_0 = class106_0.Process_0.Id;
			try
			{
				ChatServerMMF.Class84 class2 = new ChatServerMMF.Class84
				{
					memoryMappedFile_0 = MemoryMappedFile.OpenExisting(string.Format("{0}{1}", "TLBB_MEM_", @class.int_0)),
					memoryMappedViewAccessor_0 = MemoryMappedFile.OpenExisting(string.Format("{0}{1}", "TLBB_MEM_", @class.int_0)).CreateViewAccessor(),
					eventWaitHandle_0 = EventWaitHandle.OpenExisting(string.Format("{0}{1}", "TLBB_EVENT_", @class.int_0)),
					class106_0 = class106_0,
					process_0 = class106_0.Process_0
				};
				class2.process_0.EnableRaisingEvents = true;
				Process process_ = class2.process_0;
				EventHandler eventHandler;
				if ((eventHandler = ChatServerMMF.Class85.eventHandler_1) == null)
				{
					eventHandler = (ChatServerMMF.Class85.eventHandler_1 = new EventHandler(ChatServerMMF.smethod_4));
				}
				process_.Exited += eventHandler;
				if (ChatServerMMF.concurrentDictionary_0.TryAdd(@class.int_0, class2))
				{
					class2.thread_0 = new Thread(new ThreadStart(@class.method_0));
					class2.thread_0.Start();
				}
				else
				{
					ChatServerMMF.smethod_6(@class.int_0, class2);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00033EF8 File Offset: 0x000320F8
		private static void smethod_3(int int_0)
		{
			ChatServerMMF.Class87 @class = new ChatServerMMF.Class87();
			if (!ChatServerMMF.concurrentDictionary_0.TryGetValue(int_0, out @class.class84_0))
			{
				return;
			}
			while (ChatServerMMF.bool_0 && !@class.class84_0.process_0.HasExited)
			{
				try
				{
					if (@class.class84_0.eventWaitHandle_0.WaitOne(1000))
					{
						int num = @class.class84_0.memoryMappedViewAccessor_0.ReadInt32(0L);
						if (num > 0 && num < 2000)
						{
							byte[] array = new byte[num];
							@class.class84_0.memoryMappedViewAccessor_0.ReadArray<byte>(4L, array, 0, num);
							@class.class84_0.int_0++;
							if (@class.class84_0.class106_0.Class527_0.Boolean_41)
							{
								List<byte[]> list = Class106.smethod_23(array);
								Action<byte[]> action;
								if ((action = @class.action_0) == null)
								{
									action = (@class.action_0 = new Action<byte[]>(@class.method_0));
								}
								list.ForEach(action);
							}
							else
							{
								@class.class84_0.class106_0.method_155(array);
							}
						}
					}
				}
				catch (Exception)
				{
					break;
				}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00034028 File Offset: 0x00032228
		private static void smethod_4(object sender, EventArgs e)
		{
			Process process = sender as Process;
			if (process != null)
			{
				ChatServerMMF.smethod_5(process.Id);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0003404C File Offset: 0x0003224C
		private static void smethod_5(int int_0)
		{
			ChatServerMMF.Class84 @class;
			if (ChatServerMMF.concurrentDictionary_0.TryRemove(int_0, out @class))
			{
				ChatServerMMF.smethod_6(int_0, @class);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00034070 File Offset: 0x00032270
		private static void smethod_6(int int_0, ChatServerMMF.Class84 class84_0)
		{
			if (class84_0 == null)
			{
				return;
			}
			if (class84_0.process_0 != null)
			{
				Process process_ = class84_0.process_0;
				EventHandler eventHandler;
				if ((eventHandler = ChatServerMMF.Class85.eventHandler_1) == null)
				{
					eventHandler = (ChatServerMMF.Class85.eventHandler_1 = new EventHandler(ChatServerMMF.smethod_4));
				}
				process_.Exited -= eventHandler;
			}
			MemoryMappedViewAccessor memoryMappedViewAccessor_ = class84_0.memoryMappedViewAccessor_0;
			if (memoryMappedViewAccessor_ != null)
			{
				memoryMappedViewAccessor_.Dispose();
			}
			MemoryMappedFile memoryMappedFile_ = class84_0.memoryMappedFile_0;
			if (memoryMappedFile_ != null)
			{
				memoryMappedFile_.Dispose();
			}
			EventWaitHandle eventWaitHandle_ = class84_0.eventWaitHandle_0;
			if (eventWaitHandle_ == null)
			{
				return;
			}
			eventWaitHandle_.Dispose();
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00007C9E File Offset: 0x00005E9E
		private static void smethod_7(object sender, EventArgs e)
		{
			ChatServerMMF.smethod_8();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000340E4 File Offset: 0x000322E4
		public static void smethod_8()
		{
			ChatServerMMF.bool_0 = false;
			foreach (int num in ChatServerMMF.concurrentDictionary_0.Keys.ToList<int>())
			{
				ChatServerMMF.Class84 @class;
				if (ChatServerMMF.concurrentDictionary_0.TryGetValue(num, out @class))
				{
					Thread thread_ = @class.thread_0;
					if (thread_ != null)
					{
						thread_.Join(500);
					}
				}
				ChatServerMMF.smethod_5(num);
			}
		}

		// Token: 0x04000392 RID: 914
		private static ConcurrentDictionary<int, ChatServerMMF.Class84> concurrentDictionary_0 = new ConcurrentDictionary<int, ChatServerMMF.Class84>();

		// Token: 0x04000393 RID: 915
		private static bool bool_0 = true;

		// Token: 0x04000394 RID: 916
		private const string string_0 = "TLBB_MEM_";

		// Token: 0x04000395 RID: 917
		private const string string_1 = "TLBB_EVENT_";

		// Token: 0x0200009C RID: 156
		private class Class84
		{
			// Token: 0x04000396 RID: 918
			public MemoryMappedFile memoryMappedFile_0;

			// Token: 0x04000397 RID: 919
			public MemoryMappedViewAccessor memoryMappedViewAccessor_0;

			// Token: 0x04000398 RID: 920
			public EventWaitHandle eventWaitHandle_0;

			// Token: 0x04000399 RID: 921
			public Thread thread_0;

			// Token: 0x0400039A RID: 922
			public int int_0;

			// Token: 0x0400039B RID: 923
			public Class106 class106_0;

			// Token: 0x0400039C RID: 924
			public Process process_0;
		}

		// Token: 0x0200009D RID: 157
		[CompilerGenerated]
		private static class Class85
		{
			// Token: 0x0400039D RID: 925
			public static EventHandler eventHandler_0;

			// Token: 0x0400039E RID: 926
			public static ThreadStart threadStart_0;

			// Token: 0x0400039F RID: 927
			public static EventHandler eventHandler_1;
		}

		// Token: 0x0200009E RID: 158
		[CompilerGenerated]
		private sealed class Class86
		{
			// Token: 0x0600070C RID: 1804 RVA: 0x00007CB7 File Offset: 0x00005EB7
			internal void method_0()
			{
				ChatServerMMF.smethod_3(this.int_0);
			}

			// Token: 0x040003A0 RID: 928
			public int int_0;
		}

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		private sealed class Class87
		{
			// Token: 0x0600070E RID: 1806 RVA: 0x00007CC4 File Offset: 0x00005EC4
			internal void method_0(byte[] byte_0)
			{
				this.class84_0.class106_0.method_155(byte_0);
			}

			// Token: 0x040003A1 RID: 929
			public ChatServerMMF.Class84 class84_0;

			// Token: 0x040003A2 RID: 930
			public Action<byte[]> action_0;
		}
	}
}
