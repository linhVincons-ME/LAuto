using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000026 RID: 38
public class GClass6
{
	// Token: 0x06000149 RID: 329 RVA: 0x00003E8E File Offset: 0x0000208E
	public GClass6()
		: this(GEnum3.Error, null, null)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00003E99 File Offset: 0x00002099
	public GClass6(GEnum3 genum3_1)
		: this(genum3_1, null, null)
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00020EE4 File Offset: 0x0001F0E4
	public GClass6(GEnum3 genum3_1, string string_1, Action<GClass5, string> action_1)
	{
		this.genum3_0 = genum3_1;
		this.string_0 = string_1;
		Action<GClass5, string> action = action_1;
		if (action_1 == null && (action = GClass6.Class18.action_0) == null)
		{
			action = (GClass6.Class18.action_0 = new Action<GClass5, string>(GClass6.smethod_0));
		}
		this.action_0 = action;
		this.object_0 = new object();
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600014C RID: 332 RVA: 0x00003EA4 File Offset: 0x000020A4
	// (set) Token: 0x0600014D RID: 333 RVA: 0x00020F3C File Offset: 0x0001F13C
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			object obj = this.object_0;
			lock (obj)
			{
				this.string_0 = value;
				this.method_6(string.Format("The current path to the log file has been changed to {0}.", this.string_0));
			}
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600014E RID: 334 RVA: 0x00003EAE File Offset: 0x000020AE
	// (set) Token: 0x0600014F RID: 335 RVA: 0x00020F98 File Offset: 0x0001F198
	public GEnum3 GEnum3_0
	{
		get
		{
			return this.genum3_0;
		}
		set
		{
			object obj = this.object_0;
			lock (obj)
			{
				this.genum3_0 = value;
				this.method_6(string.Format("The current logging level has been changed to {0}.", this.genum3_0));
			}
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000150 RID: 336 RVA: 0x00003EB8 File Offset: 0x000020B8
	// (set) Token: 0x06000151 RID: 337 RVA: 0x00020FF8 File Offset: 0x0001F1F8
	public Action<GClass5, string> Action_0
	{
		get
		{
			return this.action_0;
		}
		set
		{
			object obj = this.object_0;
			lock (obj)
			{
				Action<GClass5, string> action = value;
				if (value == null && (action = GClass6.Class18.action_0) == null)
				{
					action = (GClass6.Class18.action_0 = new Action<GClass5, string>(GClass6.smethod_0));
				}
				this.action_0 = action;
				this.method_6("The current output action has been changed.");
			}
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00021064 File Offset: 0x0001F264
	private static void smethod_0(GClass5 gclass5_0, string string_1)
	{
		string text = gclass5_0.ToString();
		Console.WriteLine(text);
		if (string_1 != null && string_1.Length > 0)
		{
			GClass6.smethod_1(text, string_1);
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00021094 File Offset: 0x0001F294
	private void method_0(string string_1, GEnum3 genum3_1)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.genum3_0 <= genum3_1)
			{
				try
				{
					GClass5 gclass = new GClass5(genum3_1, new StackFrame(2, true), string_1);
					this.action_0(gclass, this.string_0);
				}
				catch (Exception ex)
				{
					GClass5 gclass = new GClass5(GEnum3.Fatal, new StackFrame(0, true), ex.Message);
					Console.WriteLine(gclass.ToString());
				}
			}
		}
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00021130 File Offset: 0x0001F330
	private static void smethod_1(string string_1, string string_2)
	{
		using (StreamWriter streamWriter = new StreamWriter(string_2, true))
		{
			using (TextWriter textWriter = TextWriter.Synchronized(streamWriter))
			{
				textWriter.WriteLine(string_1);
			}
		}
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00003EC0 File Offset: 0x000020C0
	public void method_1(string string_1)
	{
		if (this.genum3_0 > GEnum3.Debug)
		{
			return;
		}
		this.method_0(string_1, GEnum3.Debug);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00003ED6 File Offset: 0x000020D6
	public void method_2(string string_1)
	{
		if (this.genum3_0 > GEnum3.Error)
		{
			return;
		}
		this.method_0(string_1, GEnum3.Error);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00003EEC File Offset: 0x000020EC
	public void method_3(string string_1)
	{
		this.method_0(string_1, GEnum3.Fatal);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00003EF6 File Offset: 0x000020F6
	public void method_4(string string_1)
	{
		if (this.genum3_0 > GEnum3.Info)
		{
			return;
		}
		this.method_0(string_1, GEnum3.Info);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00003F0C File Offset: 0x0000210C
	public void method_5(string string_1)
	{
		if (this.genum3_0 > GEnum3.Trace)
		{
			return;
		}
		this.method_0(string_1, GEnum3.Trace);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00003F22 File Offset: 0x00002122
	public void method_6(string string_1)
	{
		if (this.genum3_0 > GEnum3.Warn)
		{
			return;
		}
		this.method_0(string_1, GEnum3.Warn);
	}

	// Token: 0x040000C0 RID: 192
	private volatile string string_0;

	// Token: 0x040000C1 RID: 193
	private volatile GEnum3 genum3_0;

	// Token: 0x040000C2 RID: 194
	private Action<GClass5, string> action_0;

	// Token: 0x040000C3 RID: 195
	private object object_0;

	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	private static class Class18
	{
		// Token: 0x040000C4 RID: 196
		public static Action<GClass5, string> action_0;
	}
}
