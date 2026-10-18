using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000256 RID: 598
internal class Class391
{
	// Token: 0x06001FF2 RID: 8178
	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06001FF3 RID: 8179
	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_0, int int_11, IntPtr intptr_1, ref Class391.Struct36 struct36_0);

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000EA8C4 File Offset: 0x000E8AC4
	public static void smethod_0(ListView listView_0, int int_11, SortOrder sortOrder_0)
	{
		IntPtr intPtr = Class391.SendMessage(listView_0.Handle, 4127U, IntPtr.Zero, IntPtr.Zero);
		for (int i = 0; i <= listView_0.Columns.Count - 1; i++)
		{
			IntPtr intPtr2 = new IntPtr(i);
			Class391.Struct36 @struct = default(Class391.Struct36);
			@struct.int_0 = 4;
			Class391.SendMessage_1(intPtr, 4619, intPtr2, ref @struct);
			if (sortOrder_0 != SortOrder.None && i == int_11)
			{
				if (sortOrder_0 != SortOrder.Ascending)
				{
					if (sortOrder_0 == SortOrder.Descending)
					{
						@struct.int_3 &= -1025;
						@struct.int_3 |= 512;
					}
				}
				else
				{
					@struct.int_3 &= -513;
					@struct.int_3 |= 1024;
				}
				@struct.int_3 |= 4096;
			}
			else
			{
				@struct.int_3 &= -5633;
			}
			Class391.SendMessage_1(intPtr, 4620, intPtr2, ref @struct);
		}
	}

	// Token: 0x04001414 RID: 5140
	private const int int_0 = 1;

	// Token: 0x04001415 RID: 5141
	private const int int_1 = 4;

	// Token: 0x04001416 RID: 5142
	private const int int_2 = 0;

	// Token: 0x04001417 RID: 5143
	private const int int_3 = 4096;

	// Token: 0x04001418 RID: 5144
	private const int int_4 = 1024;

	// Token: 0x04001419 RID: 5145
	private const int int_5 = 512;

	// Token: 0x0400141A RID: 5146
	private const int int_6 = 4096;

	// Token: 0x0400141B RID: 5147
	private const int int_7 = 4127;

	// Token: 0x0400141C RID: 5148
	private const int int_8 = 4608;

	// Token: 0x0400141D RID: 5149
	private const int int_9 = 4619;

	// Token: 0x0400141E RID: 5150
	private const int int_10 = 4620;

	// Token: 0x02000257 RID: 599
	public struct Struct36
	{
		// Token: 0x0400141F RID: 5151
		public int int_0;

		// Token: 0x04001420 RID: 5152
		public int int_1;

		// Token: 0x04001421 RID: 5153
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;

		// Token: 0x04001422 RID: 5154
		public IntPtr intptr_0;

		// Token: 0x04001423 RID: 5155
		public int int_2;

		// Token: 0x04001424 RID: 5156
		public int int_3;

		// Token: 0x04001425 RID: 5157
		public int int_4;

		// Token: 0x04001426 RID: 5158
		public int int_5;

		// Token: 0x04001427 RID: 5159
		public int int_6;
	}
}
