using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200015C RID: 348
internal static class Class238
{
	// Token: 0x14000014 RID: 20
	// (add) Token: 0x06001598 RID: 5528 RVA: 0x000AB14C File Offset: 0x000A934C
	// (remove) Token: 0x06001599 RID: 5529 RVA: 0x000AB180 File Offset: 0x000A9380
	public static event Action<string, string, string> Event_0
	{
		[CompilerGenerated]
		add
		{
			Action<string, string, string> action = Class238.action_0;
			Action<string, string, string> action2;
			do
			{
				action2 = action;
				Action<string, string, string> action3 = (Action<string, string, string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action<string, string, string>>(ref Class238.action_0, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string, string, string> action = Class238.action_0;
			Action<string, string, string> action2;
			do
			{
				action2 = action;
				Action<string, string, string> action3 = (Action<string, string, string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action<string, string, string>>(ref Class238.action_0, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x14000015 RID: 21
	// (add) Token: 0x0600159A RID: 5530 RVA: 0x000AB1B4 File Offset: 0x000A93B4
	// (remove) Token: 0x0600159B RID: 5531 RVA: 0x000AB1E8 File Offset: 0x000A93E8
	public static event Action<string> Event_1
	{
		[CompilerGenerated]
		add
		{
			Action<string> action = Class238.action_1;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> action3 = (Action<string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action<string>>(ref Class238.action_1, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string> action = Class238.action_1;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> action3 = (Action<string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action<string>>(ref Class238.action_1, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x14000016 RID: 22
	// (add) Token: 0x0600159C RID: 5532 RVA: 0x000AB21C File Offset: 0x000A941C
	// (remove) Token: 0x0600159D RID: 5533 RVA: 0x000AB250 File Offset: 0x000A9450
	public static event Action<string[]> Event_2
	{
		[CompilerGenerated]
		add
		{
			Action<string[]> action = Class238.action_2;
			Action<string[]> action2;
			do
			{
				action2 = action;
				Action<string[]> action3 = (Action<string[]>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action<string[]>>(ref Class238.action_2, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string[]> action = Class238.action_2;
			Action<string[]> action2;
			do
			{
				action2 = action;
				Action<string[]> action3 = (Action<string[]>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action<string[]>>(ref Class238.action_2, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x0600159E RID: 5534 RVA: 0x000AB284 File Offset: 0x000A9484
	// (remove) Token: 0x0600159F RID: 5535 RVA: 0x000AB2B8 File Offset: 0x000A94B8
	public static event Action<bool, string> Event_3
	{
		[CompilerGenerated]
		add
		{
			Action<bool, string> action = Class238.action_3;
			Action<bool, string> action2;
			do
			{
				action2 = action;
				Action<bool, string> action3 = (Action<bool, string>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action<bool, string>>(ref Class238.action_3, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<bool, string> action = Class238.action_3;
			Action<bool, string> action2;
			do
			{
				action2 = action;
				Action<bool, string> action3 = (Action<bool, string>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action<bool, string>>(ref Class238.action_3, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x060015A0 RID: 5536 RVA: 0x000AB2EC File Offset: 0x000A94EC
	// (remove) Token: 0x060015A1 RID: 5537 RVA: 0x000AB320 File Offset: 0x000A9520
	public static event Action<List<ValueTuple<string, string, string>>> Event_4
	{
		[CompilerGenerated]
		add
		{
			Action<List<ValueTuple<string, string, string>>> action = Class238.action_4;
			Action<List<ValueTuple<string, string, string>>> action2;
			do
			{
				action2 = action;
				Action<List<ValueTuple<string, string, string>>> action3 = (Action<List<ValueTuple<string, string, string>>>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action<List<ValueTuple<string, string, string>>>>(ref Class238.action_4, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<List<ValueTuple<string, string, string>>> action = Class238.action_4;
			Action<List<ValueTuple<string, string, string>>> action2;
			do
			{
				action2 = action;
				Action<List<ValueTuple<string, string, string>>> action3 = (Action<List<ValueTuple<string, string, string>>>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action<List<ValueTuple<string, string, string>>>>(ref Class238.action_4, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x060015A2 RID: 5538 RVA: 0x000AB354 File Offset: 0x000A9554
	public static bool Boolean_0
	{
		get
		{
			object obj = Class238.object_0;
			bool flag2;
			lock (obj)
			{
				flag2 = Class238.bool_0;
			}
			return flag2;
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x060015A3 RID: 5539 RVA: 0x0000F5F9 File Offset: 0x0000D7F9
	public static string String_0
	{
		get
		{
			return Class238.string_1;
		}
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x000AB394 File Offset: 0x000A9594
	public static void smethod_0(string string_2)
	{
		Class238.Class239 @class = new Class238.Class239();
		string_2 = Class238.smethod_11(string_2);
		if (!string.IsNullOrWhiteSpace(string_2))
		{
			object obj = Class238.object_0;
			lock (obj)
			{
				if (Class238.bool_1 && Class238.bool_0 && string.Equals(Class238.string_1, string_2, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
				if (Class238.bool_1 && !Class238.bool_0 && string.Equals(Class238.string_1, string_2, StringComparison.OrdinalIgnoreCase) && Class238.cancellationTokenSource_0 != null && !Class238.cancellationTokenSource_0.IsCancellationRequested)
				{
					return;
				}
				Class238.string_1 = string_2;
				Class238.bool_1 = true;
			}
			try
			{
				CancellationTokenSource cancellationTokenSource = Class238.cancellationTokenSource_0;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
				}
			}
			catch
			{
			}
			Class238.smethod_7();
			Class238.cancellationTokenSource_0 = new CancellationTokenSource();
			@class.int_0 = Interlocked.Increment(ref Class238.int_1);
			@class.cancellationToken_0 = Class238.cancellationTokenSource_0.Token;
			Task.Run(new Action(@class.method_0));
			return;
		}
		Action<bool, string> action = Class238.action_3;
		if (action == null)
		{
			return;
		}
		action(false, "Nick trống");
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0000F600 File Offset: 0x0000D800
	public static void smethod_1(string string_2)
	{
		Class238.smethod_0(string_2);
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x000AB4BC File Offset: 0x000A96BC
	public static void smethod_2()
	{
		object obj = Class238.object_0;
		lock (obj)
		{
			Class238.bool_1 = false;
			Class238.bool_2 = false;
			Class238.bool_3 = false;
		}
		try
		{
			CancellationTokenSource cancellationTokenSource = Class238.cancellationTokenSource_0;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
		}
		catch
		{
		}
		Class238.smethod_7();
		Action<bool, string> action = Class238.action_3;
		if (action == null)
		{
			return;
		}
		action(false, "Offline");
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x000AB544 File Offset: 0x000A9744
	public static void smethod_3(string string_2)
	{
		string_2 = (string_2 ?? "").Replace("\r", " ").Replace("\n", " ").Trim();
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return;
		}
		Class238.smethod_10("MSG\t" + string_2);
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x000AB59C File Offset: 0x000A979C
	private static void smethod_4(int int_2, CancellationToken cancellationToken_0)
	{
		int num = 2000;
		while (!cancellationToken_0.IsCancellationRequested)
		{
			object obj = Class238.object_0;
			bool flag2;
			string text;
			lock (obj)
			{
				flag2 = Class238.bool_1;
				text = Class238.string_1;
				if (int_2 != Class238.int_1)
				{
					break;
				}
			}
			if (!flag2 || string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			Class238.smethod_5(text, cancellationToken_0);
			obj = Class238.object_0;
			lock (obj)
			{
				Class238.bool_0 = false;
				if (Class238.bool_1)
				{
					if (int_2 == Class238.int_1)
					{
						goto IL_0091;
					}
				}
				break;
			}
			IL_0091:
			if (!cancellationToken_0.IsCancellationRequested)
			{
				Action<bool, string> action = Class238.action_3;
				if (action != null)
				{
					action(false, "Đang nối lại...");
				}
				try
				{
					Task.Delay(num, cancellationToken_0).Wait(cancellationToken_0);
				}
				catch
				{
					break;
				}
				num = Math.Min(num + 1000, 10000);
				continue;
			}
			return;
		}
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x000AB6B8 File Offset: 0x000A98B8
	private static void smethod_5(string string_2, CancellationToken cancellationToken_0)
	{
		TcpClient tcpClient = null;
		CancellationTokenSource cancellationTokenSource = null;
		try
		{
			Class238.Class240 @class = new Class238.Class240();
			tcpClient = new TcpClient();
			if (!tcpClient.ConnectAsync("68.183.181.185", 18887).Wait(8000, cancellationToken_0))
			{
				try
				{
					tcpClient.Close();
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					tcpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
				}
				catch
				{
				}
				NetworkStream stream = tcpClient.GetStream();
				StreamReader streamReader = new StreamReader(stream, new UTF8Encoding(false));
				StreamWriter streamWriter = new StreamWriter(stream, new UTF8Encoding(false))
				{
					AutoFlush = true
				};
				object obj = Class238.object_0;
				lock (obj)
				{
					Class238.tcpClient_0 = tcpClient;
					Class238.streamReader_0 = streamReader;
					Class238.streamWriter_0 = streamWriter;
					Class238.bool_0 = true;
				}
				Class238.smethod_10("JOIN\t" + string_2);
				obj = Class238.object_0;
				lock (obj)
				{
					Class238.bool_2 = true;
					Class238.list_0.Clear();
				}
				Action<bool, string> action = Class238.action_3;
				if (action != null)
				{
					action(true, "Online");
				}
				cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(new CancellationToken[] { cancellationToken_0 });
				@class.cancellationToken_0 = cancellationTokenSource.Token;
				Task.Run(new Action(@class.method_0), @class.cancellationToken_0);
				while (!cancellationToken_0.IsCancellationRequested)
				{
					string text;
					try
					{
						text = streamReader.ReadLine();
					}
					catch
					{
						break;
					}
					if (text == null)
					{
						break;
					}
					Class238.smethod_9(text);
				}
			}
		}
		catch
		{
		}
		finally
		{
			try
			{
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
				}
			}
			catch
			{
			}
			object obj = Class238.object_0;
			lock (obj)
			{
				Class238.bool_0 = false;
				if (Class238.tcpClient_0 == tcpClient)
				{
					Class238.streamWriter_0 = null;
					Class238.streamReader_0 = null;
					Class238.tcpClient_0 = null;
				}
			}
			try
			{
				if (tcpClient != null)
				{
					tcpClient.Close();
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x000AB988 File Offset: 0x000A9B88
	private static void smethod_6(CancellationToken cancellationToken_0)
	{
		while (!cancellationToken_0.IsCancellationRequested)
		{
			try
			{
				Task.Delay(30000, cancellationToken_0).Wait(cancellationToken_0);
			}
			catch
			{
				break;
			}
			Class238.smethod_10("PING");
		}
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x000AB9D4 File Offset: 0x000A9BD4
	private static void smethod_7()
	{
		object obj = Class238.object_0;
		lock (obj)
		{
			Class238.bool_0 = false;
			try
			{
				StreamWriter streamWriter = Class238.streamWriter_0;
				if (streamWriter != null)
				{
					streamWriter.Dispose();
				}
			}
			catch
			{
			}
			try
			{
				StreamReader streamReader = Class238.streamReader_0;
				if (streamReader != null)
				{
					streamReader.Dispose();
				}
			}
			catch
			{
			}
			try
			{
				TcpClient tcpClient = Class238.tcpClient_0;
				if (tcpClient != null)
				{
					tcpClient.Close();
				}
			}
			catch
			{
			}
			Class238.streamWriter_0 = null;
			Class238.streamReader_0 = null;
			Class238.tcpClient_0 = null;
		}
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x000ABA8C File Offset: 0x000A9C8C
	private static bool smethod_8(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return true;
		}
		string text = string_2.ToLowerInvariant();
		return text == "ok" || text.Contains("vao chat") || text.Contains("vào chat") || text.Contains("da thoat") || text.Contains("đã thoát") || text.Contains("thoát") || text.Contains("ket noi thanh cong") || text.Contains("kết nối thành công") || text.StartsWith("chao ");
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x000ABB2C File Offset: 0x000A9D2C
	private static void smethod_9(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			return;
		}
		string[] array = string_2.Split(new char[] { '\t' });
		string text = array[0];
		if (text == "HIST" && array.Length >= 3)
		{
			string text2 = array[1];
			string text3 = array[2];
			string text4 = ((array.Length >= 4) ? array[3] : "");
			object obj = Class238.object_0;
			lock (obj)
			{
				Class238.list_0.Add(new ValueTuple<string, string, string>(text2, text3, text4));
				return;
			}
		}
		if (text == "HISTEND")
		{
			object obj = Class238.object_0;
			List<ValueTuple<string, string, string>> list;
			bool flag2;
			lock (obj)
			{
				list = new List<ValueTuple<string, string, string>>(Class238.list_0);
				Class238.list_0.Clear();
				if (flag2 = !Class238.bool_3)
				{
					Class238.bool_3 = true;
				}
			}
			if (flag2)
			{
				Action<List<ValueTuple<string, string, string>>> action = Class238.action_4;
				if (action == null)
				{
					return;
				}
				action(list);
				return;
			}
		}
		else if (text == "MSG" && array.Length >= 3)
		{
			string text5 = array[1];
			string text6 = array[2];
			string text7 = ((array.Length >= 4) ? array[3] : "");
			Action<string, string, string> action2 = Class238.action_0;
			if (action2 == null)
			{
				return;
			}
			action2(text5, text6, text7);
			return;
		}
		else if (text == "SYS" && array.Length >= 2)
		{
			if (!Class238.smethod_8(array[1]))
			{
				Action<string> action3 = Class238.action_1;
				if (action3 == null)
				{
					return;
				}
				action3(array[1]);
				return;
			}
		}
		else if (text == "USERS" && array.Length >= 2)
		{
			string[] array2 = (string.IsNullOrWhiteSpace(array[1]) ? Array.Empty<string>() : array[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			Action<string[]> action4 = Class238.action_2;
			if (action4 == null)
			{
				return;
			}
			action4(array2);
			return;
		}
		else if (text == "ERR" && array.Length >= 2)
		{
			if (!Class238.smethod_8(array[1]))
			{
				Action<string> action5 = Class238.action_1;
				if (action5 == null)
				{
					return;
				}
				action5(array[1]);
				return;
			}
		}
		else
		{

		}
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x000ABD48 File Offset: 0x000A9F48
	private static void smethod_10(string string_2)
	{
		object obj = Class238.object_0;
		lock (obj)
		{
			if (Class238.streamWriter_0 != null && Class238.bool_0)
			{
				try
				{
					Class238.streamWriter_0.WriteLine(string_2);
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x000ABDAC File Offset: 0x000A9FAC
	public static string smethod_11(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return "";
		}
		string_2 = string_2.Trim();
		if (string_2.Length > 40)
		{
			string_2 = string_2.Substring(0, 40);
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_2)
		{
			if (c != '\t' && c != '\n' && c != '\r' && c != ',' && c != '|')
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x04000CEC RID: 3308
	public const string string_0 = "68.183.181.185";

	// Token: 0x04000CED RID: 3309
	public const int int_0 = 18887;

	// Token: 0x04000CEE RID: 3310
	[CompilerGenerated]
	private static Action<string, string, string> action_0;

	// Token: 0x04000CEF RID: 3311
	[CompilerGenerated]
	private static Action<string> action_1;

	// Token: 0x04000CF0 RID: 3312
	[CompilerGenerated]
	private static Action<string[]> action_2;

	// Token: 0x04000CF1 RID: 3313
	[CompilerGenerated]
	private static Action<bool, string> action_3;

	// Token: 0x04000CF2 RID: 3314
	[CompilerGenerated]
	private static Action<List<ValueTuple<string, string, string>>> action_4;

	// Token: 0x04000CF3 RID: 3315
	private static readonly object object_0 = new object();

	// Token: 0x04000CF4 RID: 3316
	private static TcpClient tcpClient_0;

	// Token: 0x04000CF5 RID: 3317
	private static StreamReader streamReader_0;

	// Token: 0x04000CF6 RID: 3318
	private static StreamWriter streamWriter_0;

	// Token: 0x04000CF7 RID: 3319
	private static CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04000CF8 RID: 3320
	private static string string_1 = "";

	// Token: 0x04000CF9 RID: 3321
	private static bool bool_0;

	// Token: 0x04000CFA RID: 3322
	private static bool bool_1;

	// Token: 0x04000CFB RID: 3323
	private static int int_1;

	// Token: 0x04000CFC RID: 3324
	private static bool bool_2;

	// Token: 0x04000CFD RID: 3325
	private static bool bool_3;

	// Token: 0x04000CFE RID: 3326
	private static readonly List<ValueTuple<string, string, string>> list_0 = new List<ValueTuple<string, string, string>>();

	// Token: 0x0200015D RID: 349
	[CompilerGenerated]
	private sealed class Class239
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x0000F628 File Offset: 0x0000D828
		internal void method_0()
		{
			Class238.smethod_4(this.int_0, this.cancellationToken_0);
		}

		// Token: 0x04000CFF RID: 3327
		public int int_0;

		// Token: 0x04000D00 RID: 3328
		public CancellationToken cancellationToken_0;
	}

	// Token: 0x0200015E RID: 350
	[CompilerGenerated]
	private sealed class Class240
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x0000F63B File Offset: 0x0000D83B
		internal void method_0()
		{
			Class238.smethod_6(this.cancellationToken_0);
		}

		// Token: 0x04000D01 RID: 3329
		public CancellationToken cancellationToken_0;
	}
}
