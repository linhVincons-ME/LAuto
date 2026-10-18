using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000008 RID: 8
public class GClass2
{
	// Token: 0x06000020 RID: 32
	[DllImport("user32.dll")]
	private static extern bool RegisterHotKey(IntPtr intptr_1, int int_6, int int_7, int int_8);

	// Token: 0x06000021 RID: 33
	[DllImport("user32.dll")]
	private static extern bool UnregisterHotKey(IntPtr intptr_1, int int_6);

	// Token: 0x06000022 RID: 34 RVA: 0x0001DF68 File Offset: 0x0001C168
	public GClass2(Keys keys_0, GEnum0 genum0_0, Form form_0, Action action_1)
	{
		this.int_5 = this.GetHashCode();
		this.intptr_0 = form_0.Handle;
		this.action_0 = action_1;
		int num = 0;
		if (genum0_0.HasFlag(GEnum0.Alt))
		{
			num |= 1;
		}
		if (genum0_0.HasFlag(GEnum0.Control))
		{
			num |= 2;
		}
		if (genum0_0.HasFlag(GEnum0.Shift))
		{
			num |= 4;
		}
		if (genum0_0.HasFlag(GEnum0.Win))
		{
			num |= 8;
		}
		GClass2.RegisterHotKey(this.intptr_0, this.int_5, num, (int)keys_0);
		form_0.FormClosing += this.method_1;
		GClass2.list_0.Add(new Action(this.method_2));
		GClass2.list_1.Add(this);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0001E040 File Offset: 0x0001C240
	public static void smethod_0()
	{
		foreach (Action action in GClass2.list_0)
		{
			action();
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0001E090 File Offset: 0x0001C290
	public bool method_0(Message message_0)
	{
		if (message_0.Msg == 786 && message_0.WParam.ToInt32() == this.int_5)
		{
			Action action = this.action_0;
			if (action != null)
			{
				action();
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000033CC File Offset: 0x000015CC
	[CompilerGenerated]
	private void method_1(object sender, FormClosingEventArgs e)
	{
		GClass2.UnregisterHotKey(this.intptr_0, this.int_5);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000033CC File Offset: 0x000015CC
	[CompilerGenerated]
	private void method_2()
	{
		GClass2.UnregisterHotKey(this.intptr_0, this.int_5);
	}

	// Token: 0x0400001F RID: 31
	private const int int_0 = 1;

	// Token: 0x04000020 RID: 32
	private const int int_1 = 2;

	// Token: 0x04000021 RID: 33
	private const int int_2 = 4;

	// Token: 0x04000022 RID: 34
	private const int int_3 = 8;

	// Token: 0x04000023 RID: 35
	private const int int_4 = 786;

	// Token: 0x04000024 RID: 36
	private int int_5;

	// Token: 0x04000025 RID: 37
	private IntPtr intptr_0;

	// Token: 0x04000026 RID: 38
	private Action action_0;

	// Token: 0x04000027 RID: 39
	public static List<Action> list_0 = new List<Action>();

	// Token: 0x04000028 RID: 40
	public static List<GClass2> list_1 = new List<GClass2>();
}
