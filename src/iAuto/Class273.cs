using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200018C RID: 396
internal static class Class273
{
	// Token: 0x06001719 RID: 5913 RVA: 0x000B4504 File Offset: 0x000B2704
	[STAThread]
	private static void Main()
	{
		Class273.Class274 @class = new Class273.Class274();
		if (!Class273.smethod_0())
		{
			Class273.smethod_1();
			Application.Exit();
			return;
		}
		@class.stringBuilder_0 = new StringBuilder(100);
		Process[] processesByName = Process.GetProcessesByName("iAuto");
		for (int i = 0; i < processesByName.Length; i++)
		{
			Class273.Class275 class2 = new Class273.Class275();
			class2.class274_0 = @class;
			class2.process_0 = processesByName[i];
			class2.intptr_0 = IntPtr.Zero;
			Class273.EnumWindows(new Class273.Delegate0(class2.method_0), IntPtr.Zero);
			if (class2.intptr_0 != IntPtr.Zero)
			{
				Class534.smethod_3(class2.intptr_0);
			}
		}
		bool flag = true;
		using (new Mutex(true, "iAuto", out flag))
		{
			if (flag)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new GUI());
			}
		}
	}

	// Token: 0x0600171A RID: 5914
	[DllImport("user32.dll")]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	// Token: 0x0600171B RID: 5915
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumWindows(Class273.Delegate0 delegate0_0, IntPtr intptr_0);

	// Token: 0x0600171C RID: 5916
	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, out int int_0);

	// Token: 0x0600171D RID: 5917 RVA: 0x000100D9 File Offset: 0x0000E2D9
	internal static bool smethod_0()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x000B45F4 File Offset: 0x000B27F4
	private static bool smethod_1()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			UseShellExecute = true,
			WorkingDirectory = Environment.CurrentDirectory,
			FileName = Application.ExecutablePath,
			Verb = "runas"
		};
		bool flag;
		try
		{
			Process.Start(processStartInfo);
			flag = true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x0200018D RID: 397
	// (Invoke) Token: 0x06001720 RID: 5920
	public delegate bool Delegate0(IntPtr hWnd, IntPtr lParam);

	// Token: 0x0200018E RID: 398
	public enum Enum12 : uint
	{
		// Token: 0x04000E0B RID: 3595
		Hide,
		// Token: 0x04000E0C RID: 3596
		ShowNormal,
		// Token: 0x04000E0D RID: 3597
		ShowMinimized,
		// Token: 0x04000E0E RID: 3598
		ShowMaximized,
		// Token: 0x04000E0F RID: 3599
		Maximize = 3U,
		// Token: 0x04000E10 RID: 3600
		ShowNormalNoActivate,
		// Token: 0x04000E11 RID: 3601
		Show,
		// Token: 0x04000E12 RID: 3602
		Minimize,
		// Token: 0x04000E13 RID: 3603
		ShowMinNoActivate,
		// Token: 0x04000E14 RID: 3604
		ShowNoActivate,
		// Token: 0x04000E15 RID: 3605
		Restore,
		// Token: 0x04000E16 RID: 3606
		ShowDefault,
		// Token: 0x04000E17 RID: 3607
		ForceMinimized
	}

	// Token: 0x0200018F RID: 399
	public struct Struct34
	{
		// Token: 0x04000E18 RID: 3608
		public int int_0;

		// Token: 0x04000E19 RID: 3609
		public int int_1;

		// Token: 0x04000E1A RID: 3610
		public int int_2;

		// Token: 0x04000E1B RID: 3611
		public int int_3;
	}

	// Token: 0x02000190 RID: 400
	[CompilerGenerated]
	private sealed class Class274
	{
		// Token: 0x04000E1C RID: 3612
		public StringBuilder stringBuilder_0;
	}

	// Token: 0x02000191 RID: 401
	[CompilerGenerated]
	private sealed class Class275
	{
		// Token: 0x06001725 RID: 5925 RVA: 0x000B4650 File Offset: 0x000B2850
		internal bool method_0(IntPtr intptr_1, IntPtr intptr_2)
		{
			int num;
			Class273.GetWindowThreadProcessId(intptr_1, out num);
			if (this.process_0.Id == num)
			{
				Class273.GetClassName(intptr_1, this.class274_0.stringBuilder_0, 100);
				if (this.class274_0.stringBuilder_0.ToString().Contains("WindowsForms10.Window.8.app"))
				{
					this.intptr_0 = intptr_1;
					return true;
				}
			}
			return true;
		}

		// Token: 0x04000E1D RID: 3613
		public Process process_0;

		// Token: 0x04000E1E RID: 3614
		public IntPtr intptr_0;

		// Token: 0x04000E1F RID: 3615
		public Class273.Class274 class274_0;
	}
}
