using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x020001E7 RID: 487
internal static class Class328
{
	// Token: 0x060019E6 RID: 6630 RVA: 0x000D05B4 File Offset: 0x000CE7B4
	public static Encoding smethod_0(string string_0)
	{
		Encoding encoding;
		using (FileStream fileStream = File.OpenRead(string_0))
		{
			encoding = Class328.smethod_1(fileStream, 65536L);
		}
		return encoding;
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x000D05F8 File Offset: 0x000CE7F8
	public static Encoding smethod_1(FileStream fileStream_0, long long_1)
	{
		bool flag = false;
		return Class328.smethod_2(fileStream_0, 65536L, out flag);
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x000D0618 File Offset: 0x000CE818
	public static Encoding smethod_2(FileStream fileStream_0, long long_1, out bool bool_0)
	{
		long position = fileStream_0.Position;
		fileStream_0.Position = 0L;
		byte[] array = new byte[(fileStream_0.Length > 4L) ? 4L : fileStream_0.Length];
		fileStream_0.Read(array, 0, array.Length);
		Encoding encoding = Class328.smethod_3(array);
		if (encoding != null)
		{
			fileStream_0.Position = position;
			bool_0 = true;
			return encoding;
		}
		byte[] array2 = new byte[(long_1 > fileStream_0.Length) ? fileStream_0.Length : long_1];
		Array.Copy(array, array2, array.Length);
		if (fileStream_0.Length > (long)array.Length)
		{
			fileStream_0.Read(array2, array.Length, array2.Length - array.Length);
		}
		fileStream_0.Position = position;
		encoding = Class328.smethod_4(array2);
		bool_0 = false;
		return encoding;
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x000D06DC File Offset: 0x000CE8DC
	public static Encoding smethod_3(byte[] byte_0)
	{
		if (byte_0.Length < 2)
		{
			return null;
		}
		if (byte_0[0] == 255 && byte_0[1] == 254 && (byte_0.Length < 4 || byte_0[2] != 0 || byte_0[3] != 0))
		{
			return Encoding.Unicode;
		}
		if (byte_0[0] == 254 && byte_0[1] == 255)
		{
			return Encoding.BigEndianUnicode;
		}
		if (byte_0.Length < 3)
		{
			return null;
		}
		if (byte_0[0] == 239 && byte_0[1] == 187 && byte_0[2] == 191)
		{
			return Encoding.UTF8;
		}
		if (byte_0[0] == 43 && byte_0[1] == 47 && byte_0[2] == 118)
		{
			return Encoding.UTF7;
		}
		if (byte_0.Length < 4)
		{
			return null;
		}
		if (byte_0[0] == 255 && byte_0[1] == 254 && byte_0[2] == 0 && byte_0[3] == 0)
		{
			return Encoding.UTF32;
		}
		if (byte_0[0] == 0 && byte_0[1] == 0 && byte_0[2] == 254 && byte_0[3] == 255)
		{
			return Encoding.GetEncoding(12001);
		}
		return null;
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x000D07D4 File Offset: 0x000CE9D4
	public static Encoding smethod_4(byte[] byte_0)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		int num7 = 0;
		while (num6 < (long)byte_0.Length)
		{
			if (byte_0[(int)(checked((IntPtr)num6))] == 0)
			{
				if (num6 % 2L == 0L)
				{
					num2 += 1L;
				}
				else
				{
					num += 1L;
				}
			}
			if (Class328.smethod_5(byte_0[(int)(checked((IntPtr)num6))]))
			{
				num5 += 1L;
			}
			if (num7 == 0)
			{
				int num8 = Class328.smethod_6(byte_0, num6);
				if (num8 > 0)
				{
					num3 += 1L;
					num4 += (long)num8;
					num7 = num8 - 1;
				}
			}
			else
			{
				num7--;
			}
			num6 += 1L;
		}
		if ((double)num2 * 2.0 / (double)byte_0.Length < 0.2 && (double)num * 2.0 / (double)byte_0.Length > 0.6)
		{
			return Encoding.Unicode;
		}
		if ((double)num * 2.0 / (double)byte_0.Length < 0.2 && (double)num2 * 2.0 / (double)byte_0.Length > 0.6)
		{
			return Encoding.BigEndianUnicode;
		}
		string @string = Encoding.ASCII.GetString(byte_0);
		if (new Regex("\\A([\\x09\\x0A\\x0D\\x20-\\x7E]|[\\xC2-\\xDF][\\x80-\\xBF]|\\xE0[\\xA0-\\xBF][\\x80-\\xBF]|[\\xE1-\\xEC\\xEE\\xEF][\\x80-\\xBF]{2}|\\xED[\\x80-\\x9F][\\x80-\\xBF]|\\xF0[\\x90-\\xBF][\\x80-\\xBF]{2}|[\\xF1-\\xF3][\\x80-\\xBF]{3}|\\xF4[\\x80-\\x8F][\\x80-\\xBF]{2})*\\z").IsMatch(@string) && (double)num3 * 500000.0 / (double)byte_0.Length >= 1.0 && ((long)byte_0.Length - num4 == 0L || (double)num5 * 1.0 / (double)((long)byte_0.Length - num4) >= 0.8))
		{
			return Encoding.UTF8;
		}
		return null;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x000D09A4 File Offset: 0x000CEBA4
	private static bool smethod_5(byte byte_0)
	{
		return byte_0 == 10 || byte_0 == 13 || byte_0 == 9 || (byte_0 >= 32 && byte_0 <= 47) || (byte_0 >= 48 && byte_0 <= 57) || (byte_0 >= 58 && byte_0 <= 64) || (byte_0 >= 65 && byte_0 <= 90) || (byte_0 >= 91 && byte_0 <= 96) || (byte_0 >= 97 && byte_0 <= 122) || (byte_0 >= 123 && byte_0 <= 126);
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x000D0A0C File Offset: 0x000CEC0C
	private static int smethod_6(byte[] byte_0, long long_1)
	{
		int num = 0;
		checked
		{
			if (unchecked((long)byte_0.Length >= long_1 + 1L) && byte_0[(int)((IntPtr)long_1)] == 194)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 129 && byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 141)
				{
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 143)
					{
						if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 144)
						{
							if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 157)
							{
								if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] >= 160 && byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] <= 191)
								{
									return 2;
								}
								return num;
							}
						}
						return 2;
					}
				}
				num = 2;
			}
			else if (unchecked((long)byte_0.Length >= long_1 + 1L) && byte_0[(int)((IntPtr)long_1)] == 195)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] >= 128 && byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] <= 191)
				{
					num = 2;
				}
			}
			else if (unchecked((long)byte_0.Length >= long_1 + 1L) && byte_0[(int)((IntPtr)long_1)] == 197)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 146)
				{
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 147)
					{
						if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 160)
						{
							if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] != 161)
							{
								if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 184 || byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 189 || byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 190)
								{
									return 2;
								}
								return num;
							}
						}
						return 2;
					}
				}
				num = 2;
			}
			else if (unchecked((long)byte_0.Length >= long_1 + 1L) && byte_0[(int)((IntPtr)long_1)] == 198)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 146)
				{
					num = 2;
				}
			}
			else if (unchecked((long)byte_0.Length >= long_1 + 1L) && byte_0[(int)((IntPtr)long_1)] == 203)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 134 || byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 156)
				{
					num = 2;
				}
			}
			else if (unchecked((long)byte_0.Length >= long_1 + 2L) && byte_0[(int)((IntPtr)long_1)] == 226)
			{
				if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 128)
				{
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 147 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 148)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 152 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 153 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 154)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 156 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 157 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 158)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 160 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 161 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 162)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 166)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 176)
					{
						num = 3;
					}
					if (byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 185 || byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 186)
					{
						num = 3;
					}
				}
				else if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 130 && byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 172)
				{
					num = 3;
				}
				else if (byte_0[(int)((IntPtr)(unchecked(long_1 + 1L)))] == 132 && byte_0[(int)((IntPtr)(unchecked(long_1 + 2L)))] == 162)
				{
					num = 3;
				}
			}
			return num;
		}
	}

	// Token: 0x040010B4 RID: 4276
	private const long long_0 = 65536L;
}
