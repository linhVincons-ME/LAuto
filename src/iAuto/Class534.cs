using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

// Token: 0x020002F6 RID: 758
internal class Class534
{
	// Token: 0x06002A39 RID: 10809
	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string string_0, string string_1);

	// Token: 0x170009BD RID: 2493
	// (get) Token: 0x06002A3A RID: 10810 RVA: 0x0001C86D File Offset: 0x0001AA6D
	public static IEnumerable<IntPtr> IEnumerable_0
	{
		get
		{
			return new Class534.Class536(-2);
		}
	}

	// Token: 0x06002A3B RID: 10811
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr intptr_0, IntPtr intptr_1, int int_4, int int_5, int int_6, int int_7, int int_8);

	// Token: 0x06002A3C RID: 10812
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, Class534.Enum20 enum20_0);

	// Token: 0x06002A3D RID: 10813
	[DllImport("user32.dll")]
	public static extern bool PostMessage(IntPtr intptr_0, int int_4, long long_0, long long_1);

	// Token: 0x06002A3E RID: 10814
	[DllImport("user32.dll")]
	public static extern bool IsWindowVisible(IntPtr intptr_0);

	// Token: 0x06002A3F RID: 10815
	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, out GStruct21 gstruct21_0);

	// Token: 0x06002A40 RID: 10816
	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr intptr_0, Class534.Enum22 enum22_0);

	// Token: 0x06002A41 RID: 10817
	[DllImport("user32.dll")]
	public static extern int SetWindowText(IntPtr intptr_0, string string_0);

	// Token: 0x06002A42 RID: 10818
	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out int int_4);

	// Token: 0x06002A43 RID: 10819
	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	// Token: 0x06002A44 RID: 10820
	[DllImport("user32.dll")]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_4);

	// Token: 0x06002A45 RID: 10821
	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_4);

	// Token: 0x06002A46 RID: 10822
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	// Token: 0x06002A47 RID: 10823 RVA: 0x0001C876 File Offset: 0x0001AA76
	public static void smethod_0(IntPtr intptr_0)
	{
		if (Class534.IsWindowVisible(intptr_0))
		{
			Class534.ShowWindow(intptr_0, Class534.Enum20.ShowMinNoActivate);
			Class534.ShowWindow(intptr_0, Class534.Enum20.Hide);
		}
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x0012E15C File Offset: 0x0012C35C
	public static IntPtr smethod_1(int int_4)
	{
		StringBuilder stringBuilder = new StringBuilder(100);
		foreach (IntPtr intPtr in Class534.IEnumerable_0)
		{
			Class534.Class535 @class = new Class534.Class535();
			stringBuilder.Clear();
			Class534.GetClassName(intPtr, stringBuilder, 100);
			@class.string_0 = stringBuilder.ToString();
			if (Class534.hashSet_0.Any<string>(new Func<string, bool>(@class.method_0)))
			{
				int num;
				Class534.GetWindowThreadProcessId(intPtr, out num);
				if (num == int_4)
				{
					return intPtr;
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x0012E204 File Offset: 0x0012C404
	public static IntPtr smethod_2(int int_4, string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(100);
		foreach (IntPtr intPtr in Class534.IEnumerable_0)
		{
			stringBuilder.Clear();
			Class534.GetClassName(intPtr, stringBuilder, 100);
			if (stringBuilder.ToString().Contains(string_0))
			{
				int num;
				Class534.GetWindowThreadProcessId(intPtr, out num);
				if (num == int_4)
				{
					return intPtr;
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x0012E290 File Offset: 0x0012C490
	public static void smethod_3(IntPtr intptr_0)
	{
		GStruct21 gstruct;
		if (!Class534.GetWindowRect(intptr_0, out gstruct))
		{
			return;
		}
		bool flag = gstruct.int_0 == -32000;
		if (!Class534.IsWindowVisible(intptr_0))
		{
			Class534.ShowWindow(intptr_0, Class534.Enum20.Show);
		}
		if (flag)
		{
			Class534.ShowWindow(intptr_0, Class534.Enum20.Restore);
		}
		if (Class534.GetForegroundWindow() != intptr_0)
		{
			Class534.SetForegroundWindow(intptr_0);
		}
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x0012E2E4 File Offset: 0x0012C4E4
	public static void smethod_4(IntPtr intptr_0)
	{
		GStruct21 gstruct;
		if (!Class534.GetWindowRect(intptr_0, out gstruct))
		{
			return;
		}
		if (!Class534.IsWindowVisible(intptr_0))
		{
			Class534.ShowWindow(intptr_0, Class534.Enum20.Show);
		}
		Class534.ShowWindow(intptr_0, Class534.Enum20.ShowMaximized);
		if (Class534.GetForegroundWindow() != intptr_0)
		{
			Class534.SetForegroundWindow(intptr_0);
		}
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x0001C890 File Offset: 0x0001AA90
	public static bool smethod_5(IntPtr intptr_0)
	{
		return !Class534.IsWindowVisible(intptr_0) || Class534.smethod_7(intptr_0);
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x0001C8A2 File Offset: 0x0001AAA2
	public static bool smethod_6(IntPtr intptr_0)
	{
		return Class534.IsWindowVisible(intptr_0) && !Class534.smethod_7(intptr_0);
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x0012E328 File Offset: 0x0012C528
	public static bool smethod_7(IntPtr intptr_0)
	{
		GStruct21 gstruct;
		return Class534.GetWindowRect(intptr_0, out gstruct) && gstruct.int_0 == -32000;
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x0001C8B7 File Offset: 0x0001AAB7
	public static void smethod_8(IntPtr intptr_0)
	{
		Class534.ShowWindow(intptr_0, Class534.Enum20.Hide);
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x0001C8C1 File Offset: 0x0001AAC1
	public static void smethod_9(IntPtr intptr_0)
	{
		Class534.PostMessage(intptr_0, 16, 0L, 0L);
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x0012E350 File Offset: 0x0012C550
	public static void smethod_10()
	{
		foreach (string text in new string[] { "Unsupported 16-Bit Application", "Microsoft Visual C++ Runtime Library", "TTL3D" })
		{
			IntPtr intPtr = Class534.FindWindow("#32770", text);
			if (intPtr != IntPtr.Zero)
			{
				Class534.smethod_9(intPtr);
			}
		}
		StringBuilder stringBuilder = new StringBuilder(64);
		StringBuilder stringBuilder2 = new StringBuilder(256);
		foreach (IntPtr intPtr2 in Class534.IEnumerable_0)
		{
			if (Class534.IsWindowVisible(intPtr2))
			{
				stringBuilder.Clear();
				Class534.GetClassName(intPtr2, stringBuilder, 64);
				if (!(stringBuilder.ToString() != "#32770"))
				{
					stringBuilder2.Clear();
					Class534.GetWindowText(intPtr2, stringBuilder2, 256);
					string text2 = stringBuilder2.ToString();
					if (!string.IsNullOrEmpty(text2))
					{
						string text3 = text2.ToLowerInvariant();
						if (text3.Contains("unsupported 16") || text3.Contains("16-bit application") || text3.Contains("16 bit application") || text3.Contains("ứng dụng 16") || text2 == "TTL3D" || text2.Contains("Visual C++ Runtime"))
						{
							Class534.smethod_9(intPtr2);
						}
					}
				}
			}
		}
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x0012E4C8 File Offset: 0x0012C6C8
	public static void smethod_11(IntPtr intptr_0, Class534.Enum19 enum19_0 = Class534.Enum19.Center)
	{
		GStruct21 gstruct;
		if (!Class534.smethod_7(intptr_0) && Class534.GetWindowRect(intptr_0, out gstruct))
		{
			ValueTuple<int, int> valueTuple = Class534.smethod_13(enum19_0, 600, 800);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			Class534.SetWindowPos(intptr_0, IntPtr.Zero, item, item2, 799, 599, 0);
			return;
		}
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x0012E520 File Offset: 0x0012C720
	public static void smethod_12(Form form_0, Class534.Enum19 enum19_0)
	{
		ValueTuple<int, int> valueTuple = Class534.smethod_13(enum19_0, form_0.Width, form_0.Height);
		int item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		form_0.Location = new Point(item, item2);
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x0012E55C File Offset: 0x0012C75C
	private static ValueTuple<int, int> smethod_13(Class534.Enum19 enum19_0, int int_4, int int_5)
	{
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		int num = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
		ValueTuple<int, int> valueTuple;
		switch (enum19_0)
		{
		case Class534.Enum19.TopLeft:
			valueTuple = new ValueTuple<int, int>(0, 0);
			break;
		case Class534.Enum19.TopRight:
			valueTuple = new ValueTuple<int, int>(width - int_4, 0);
			break;
		case Class534.Enum19.BottomRight:
			valueTuple = new ValueTuple<int, int>(width - int_4, height - int_5 - num);
			break;
		case Class534.Enum19.BottomLeft:
			valueTuple = new ValueTuple<int, int>(0, height - int_5 - num);
			break;
		case Class534.Enum19.Center:
			valueTuple = new ValueTuple<int, int>((width - int_4) / 2, (height - int_5 - num) / 2);
			break;
		case Class534.Enum19.None:
			valueTuple = new ValueTuple<int, int>(-1000, -1000);
			break;
		case Class534.Enum19.TopCenter:
			valueTuple = new ValueTuple<int, int>((width - int_4) / 2, 0);
			break;
		case Class534.Enum19.RightCenter:
			valueTuple = new ValueTuple<int, int>(width - int_4, (height - int_5 - num) / 2);
			break;
		case Class534.Enum19.BottomCenter:
			valueTuple = new ValueTuple<int, int>((width - int_4) / 2, height - int_5 - num);
			break;
		case Class534.Enum19.LeftCenter:
			valueTuple = new ValueTuple<int, int>(0, (height - int_5 - num) / 2);
			break;
		default:
			valueTuple = new ValueTuple<int, int>(0, 0);
			break;
		}
		return valueTuple;
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x0012E6A0 File Offset: 0x0012C8A0
	public static void smethod_14(Form form_0)
	{
		if (form_0.WindowState == FormWindowState.Minimized)
		{
			Class534.SetWindowPos(form_0.Handle, (IntPtr)(-1), form_0.Left, form_0.Top, form_0.Width, form_0.Height, 16);
		}
		Class534.ShowWindow(form_0.Handle, Class534.Enum20.ShowNormalNoActivate);
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x0012E6F0 File Offset: 0x0012C8F0
	public static void smethod_15(Class106 class106_0)
	{
		if (Class226.Boolean_93 && !class106_0.Boolean_49)
		{
			Class534.SetWindowPos(class106_0.IntPtr_0, IntPtr.Zero, class106_0.Int32_8, class106_0.Int32_9, 200, 150, 20);
		}
		else if (Class534.smethod_7(class106_0.IntPtr_0) || !Class534.IsWindowVisible(class106_0.IntPtr_0))
		{
			int num = 20;
			Class534.SetWindowPos(class106_0.IntPtr_0, IntPtr.Zero, (class106_0.Int32_8 == 0) ? 20 : class106_0.Int32_8, (class106_0.Int32_8 == 0) ? 20 : class106_0.Int32_9, (class106_0.Int32_8 == 0) ? 1030 : class106_0.Int32_6, (class106_0.Int32_8 == 0) ? 797 : class106_0.Int32_7, num);
		}
		Class534.ShowWindow(class106_0.IntPtr_0, Class534.Enum20.ShowNormalNoActivate);
	}

	// Token: 0x04001D5A RID: 7514
	private const int int_0 = -1;

	// Token: 0x04001D5B RID: 7515
	private const uint uint_0 = 16U;

	// Token: 0x04001D5C RID: 7516
	private const int int_1 = 16;

	// Token: 0x04001D5D RID: 7517
	private const int int_2 = 600;

	// Token: 0x04001D5E RID: 7518
	private const int int_3 = 800;

	// Token: 0x04001D5F RID: 7519
	private static readonly HashSet<string> hashSet_0 = new HashSet<string> { "TianLongBaBu WndClass", "TLBB_KIMDUNG WndClass", "TL_BachChien WndClass", "1234567890", "TianLongBaBuHJ WndClass", "TianLongBaBuTK WndClass", "TianLongBaBuPL WndClass" };

	// Token: 0x020002F7 RID: 759
	public enum Enum19 : byte
	{
		// Token: 0x04001D61 RID: 7521
		TopLeft,
		// Token: 0x04001D62 RID: 7522
		TopRight,
		// Token: 0x04001D63 RID: 7523
		BottomRight,
		// Token: 0x04001D64 RID: 7524
		BottomLeft,
		// Token: 0x04001D65 RID: 7525
		Center,
		// Token: 0x04001D66 RID: 7526
		None,
		// Token: 0x04001D67 RID: 7527
		TopCenter,
		// Token: 0x04001D68 RID: 7528
		RightCenter,
		// Token: 0x04001D69 RID: 7529
		BottomCenter,
		// Token: 0x04001D6A RID: 7530
		LeftCenter
	}

	// Token: 0x020002F8 RID: 760
	public enum Enum20 : uint
	{
		// Token: 0x04001D6C RID: 7532
		Hide,
		// Token: 0x04001D6D RID: 7533
		ShowNormal,
		// Token: 0x04001D6E RID: 7534
		ShowMinimized,
		// Token: 0x04001D6F RID: 7535
		ShowMaximized,
		// Token: 0x04001D70 RID: 7536
		Maximize = 3U,
		// Token: 0x04001D71 RID: 7537
		ShowNormalNoActivate,
		// Token: 0x04001D72 RID: 7538
		Show,
		// Token: 0x04001D73 RID: 7539
		Minimize,
		// Token: 0x04001D74 RID: 7540
		ShowMinNoActivate,
		// Token: 0x04001D75 RID: 7541
		ShowNoActivate,
		// Token: 0x04001D76 RID: 7542
		Restore,
		// Token: 0x04001D77 RID: 7543
		ShowDefault,
		// Token: 0x04001D78 RID: 7544
		ForceMinimized
	}

	// Token: 0x020002F9 RID: 761
	private enum Enum21 : uint
	{
		// Token: 0x04001D7A RID: 7546
		SWP_NOACTIVATE = 16U,
		// Token: 0x04001D7B RID: 7547
		SWP_NOZORDER = 4U
	}

	// Token: 0x020002FA RID: 762
	private enum Enum22 : uint
	{
		// Token: 0x04001D7D RID: 7549
		GW_HWNDFIRST,
		// Token: 0x04001D7E RID: 7550
		GW_HWNDNEXT = 2U
	}

	// Token: 0x020002FB RID: 763
	[CompilerGenerated]
	private sealed class Class535
	{
		// Token: 0x06002A5A RID: 10842 RVA: 0x0001C8DE File Offset: 0x0001AADE
		internal bool method_0(string string_1)
		{
			return string_1.Contains(this.string_0) || this.string_0.Contains(string_1);
		}

		// Token: 0x04001D7F RID: 7551
		public string string_0;
	}

	// Token: 0x020002FC RID: 764
	[CompilerGenerated]
	private sealed class Class536 : IEnumerable, IDisposable, IEnumerator, IEnumerable<IntPtr>, IEnumerator<IntPtr>
	{
		// Token: 0x06002A5B RID: 10843 RVA: 0x0001C8FC File Offset: 0x0001AAFC
		[DebuggerHidden]
		public Class536(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x0001C916 File Offset: 0x0001AB16
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x0012E830 File Offset: 0x0012CA30
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.intptr_1 = Class534.GetWindow(this.intptr_1, Class534.Enum22.GW_HWNDNEXT);
			}
			else
			{
				this.int_0 = -1;
				this.intptr_1 = Class534.GetWindow(Class534.GetForegroundWindow(), Class534.Enum22.GW_HWNDFIRST);
			}
			if (!(this.intptr_1 != IntPtr.Zero))
			{
				return false;
			}
			this.intptr_0 = this.intptr_1;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0001C920 File Offset: 0x0001AB20
		public IntPtr Current
		{
			[DebuggerHidden]
			get
			{
				return this.intptr_0;
			}
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0001C928 File Offset: 0x0001AB28
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.intptr_0;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x0012E8A8 File Offset: 0x0012CAA8
		[DebuggerHidden]
		public IEnumerator<IntPtr> GetEnumerator()
		{
			Class534.Class536 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class534.Class536(0);
			}
			return @class;
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x0001C935 File Offset: 0x0001AB35
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04001D80 RID: 7552
		private int int_0;

		// Token: 0x04001D81 RID: 7553
		private IntPtr intptr_0;

		// Token: 0x04001D82 RID: 7554
		private int int_1;

		// Token: 0x04001D83 RID: 7555
		private IntPtr intptr_1;
	}
}
