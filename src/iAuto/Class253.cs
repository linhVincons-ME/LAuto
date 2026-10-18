using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000173 RID: 371
internal class Class253
{
	// Token: 0x0600161D RID: 5661 RVA: 0x000AECB4 File Offset: 0x000ACEB4
	private static IPEndPoint[] smethod_0(int int_1)
	{
		Class253.Class255 @class = new Class253.Class255();
		@class.int_0 = int_1;
		return IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections().Where<TcpConnectionInformation>(new Func<TcpConnectionInformation, bool>(@class.method_0))
			.Select<TcpConnectionInformation, IPEndPoint>(new Func<TcpConnectionInformation, IPEndPoint>(Class253.Class254.f_13596F00.method_0))
			.ToArray<IPEndPoint>();
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x000AED14 File Offset: 0x000ACF14
	private static int smethod_1(TcpConnectionInformation tcpConnectionInformation_0)
	{
		PropertyInfo property = tcpConnectionInformation_0.GetType().GetProperty("OwningProcess", typeof(int));
		if (property != null)
		{
			return (int)property.GetValue(tcpConnectionInformation_0);
		}
		return 0;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
	public static void smethod_2()
	{
		new Thread(new ThreadStart(Class253.Class254.f_13596F00.method_1)).Start();
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x000AED54 File Offset: 0x000ACF54
	private static void smethod_3(object object_0)
	{
		TcpClient tcpClient = (TcpClient)object_0;
		NetworkStream stream = tcpClient.GetStream();
		Class106 @class = null;
		try
		{
			byte[] array = new byte[tcpClient.ReceiveBufferSize];
			for (;;)
			{
				int num = stream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				byte[] array2 = new byte[num];
				Array.Copy(array, array2, num);
				if (@class != null)
				{
					@class.List_0.Add(array2);
				}
				else
				{
					string text = Class500.smethod_3(array2);
					if (text.StartsWith("Process"))
					{
						Class253.Class257 class2 = new Class253.Class257();
						class2.int_0 = text.smethod_26();
						@class = Class106.List_3.FirstOrDefault<Class106>(new Func<Class106, bool>(class2.method_0));
					}
				}
			}
		}
		catch
		{
		}
		finally
		{
			tcpClient.Close();
		}
	}

	// Token: 0x04000D6A RID: 3434
	private const int int_0 = 34560;

	// Token: 0x04000D6B RID: 3435
	private static readonly IPAddress ipaddress_0 = IPAddress.Parse("127.0.0.1");

	// Token: 0x04000D6C RID: 3436
	public static readonly TcpListener tcpListener_0 = new TcpListener(Class253.ipaddress_0, 34560);

	// Token: 0x02000174 RID: 372
	[CompilerGenerated]
	[Serializable]
	private sealed class Class254
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		internal IPEndPoint method_0(TcpConnectionInformation tcpConnectionInformation_0)
		{
			return new IPEndPoint(tcpConnectionInformation_0.LocalEndPoint.Address, tcpConnectionInformation_0.LocalEndPoint.Port);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000AEE24 File Offset: 0x000AD024
		internal void method_1()
		{
			Thread.CurrentThread.IsBackground = true;
			Thread.Sleep(2000);
			try
			{
				Class253.tcpListener_0.Start();
				for (;;)
				{
					new Thread(new ThreadStart(new Class253.Class256
					{
						tcpClient_0 = Class253.tcpListener_0.AcceptTcpClient()
					}.method_0)).Start();
				}
			}
			catch
			{
				try
				{
					foreach (Process process in Process.GetProcesses())
					{
						try
						{
							IPEndPoint[] array = Class253.smethod_0(process.Id);
							for (int j = 0; j < array.Length; j++)
							{
								if (array[j].Port == 34560)
								{
									process.Kill();
								}
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000D6D RID: 3437
		public static readonly Class253.Class254 f_13596F00 = new Class253.Class254();

		// Token: 0x04000D6E RID: 3438
		public static Func<TcpConnectionInformation, IPEndPoint> f_4943DCEC;

		// Token: 0x04000D6F RID: 3439
		public static ThreadStart f_B6A46BEB;
	}

	// Token: 0x02000175 RID: 373
	[CompilerGenerated]
	private sealed class Class255
	{
		// Token: 0x06001628 RID: 5672 RVA: 0x000AEF00 File Offset: 0x000AD100
		internal bool method_0(TcpConnectionInformation tcpConnectionInformation_0)
		{
			return tcpConnectionInformation_0.State == TcpState.Listen && Class253.smethod_1(tcpConnectionInformation_0).Equals(this.int_0);
		}

		// Token: 0x04000D70 RID: 3440
		public int int_0;
	}

	// Token: 0x02000176 RID: 374
	[CompilerGenerated]
	private sealed class Class256
	{
		// Token: 0x0600162A RID: 5674 RVA: 0x0000FA59 File Offset: 0x0000DC59
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			Class253.smethod_3(this.tcpClient_0);
		}

		// Token: 0x04000D71 RID: 3441
		public TcpClient tcpClient_0;
	}

	// Token: 0x02000177 RID: 375
	[CompilerGenerated]
	private sealed class Class257
	{
		// Token: 0x0600162C RID: 5676 RVA: 0x0000FA71 File Offset: 0x0000DC71
		internal bool method_0(Class106 class106_0)
		{
			return class106_0.Process_0.Id == this.int_0;
		}

		// Token: 0x04000D72 RID: 3442
		public int int_0;
	}
}
