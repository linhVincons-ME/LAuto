using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200032E RID: 814
internal class Class586
{
	// Token: 0x170009F9 RID: 2553
	// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0001CABE File Offset: 0x0001ACBE
	// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x0001CAC5 File Offset: 0x0001ACC5
	public static string String_0
	{
		get
		{
			return Class586.string_0;
		}
		set
		{
			Class586.string_0 = value;
		}
	}

	// Token: 0x06002AF4 RID: 10996
	[DllImport("winmm.dll")]
	private static extern long mciSendString(string string_1, StringBuilder stringBuilder_0, int int_0, IntPtr intptr_0);

	// Token: 0x06002AF5 RID: 10997 RVA: 0x0001CACD File Offset: 0x0001ACCD
	public static void smethod_0()
	{
		if (!Class586.bool_0)
		{
			Class586.smethod_5();
			Class586.mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
		}
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x001342D4 File Offset: 0x001324D4
	public static void smethod_1()
	{
		if (Class226.Boolean_142)
		{
			return;
		}
		try
		{
			Class586.soundPlayer_0 = new SoundPlayer
			{
				Stream = Class616.UnmanagedMemoryStream_1
			};
			Class586.soundPlayer_0.PlayLooping();
		}
		catch
		{
		}
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x00134320 File Offset: 0x00132520
	public static void smethod_2()
	{
		if (Class226.Boolean_142)
		{
			return;
		}
		using (SoundPlayer soundPlayer = new SoundPlayer
		{
			Stream = Class616.UnmanagedMemoryStream_0
		})
		{
			soundPlayer.Play();
		}
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x00134368 File Offset: 0x00132568
	public static void smethod_3()
	{
		if (Class226.Boolean_142)
		{
			return;
		}
		using (SoundPlayer soundPlayer = new SoundPlayer
		{
			Stream = Class616.UnmanagedMemoryStream_2
		})
		{
			soundPlayer.Play();
		}
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x001343B0 File Offset: 0x001325B0
	public static void smethod_4()
	{
		try
		{
			Class586.soundPlayer_0.Stop();
		}
		catch
		{
		}
	}

	// Token: 0x06002AFA RID: 11002 RVA: 0x0001CAED File Offset: 0x0001ACED
	private static void smethod_5()
	{
		Class586.mciSendString("open \"" + Class586.String_0 + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
		Class586.bool_0 = true;
	}

	// Token: 0x04001F22 RID: 7970
	private static string string_0 = Class226.String_1 + "\\Alarm.mp3";

	// Token: 0x04001F23 RID: 7971
	private static bool bool_0;

	// Token: 0x04001F24 RID: 7972
	private static SoundPlayer soundPlayer_0;
}
