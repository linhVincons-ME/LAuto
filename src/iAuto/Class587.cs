using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _i.Properties;

// Token: 0x0200032F RID: 815
internal static class Class587
{
	// Token: 0x06002AFD RID: 11005 RVA: 0x001343DC File Offset: 0x001325DC
	public static string smethod_0(string string_0)
	{
		UdpClient udpClient = new UdpClient();
		try
		{
			IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Parse(Settings.Default.CaptchaServer), Settings.Default.CaptchaPort.smethod_26());
			udpClient.Client.ReceiveTimeout = 10000;
			udpClient.Send(Encoding.UTF8.GetBytes(string_0), string_0.Length, ipendPoint);
			byte[] array = udpClient.Receive(ref ipendPoint);
			return Encoding.UTF8.GetString(array);
		}
		catch
		{
		}
		finally
		{
			udpClient.Close();
		}
		return string.Empty;
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x0001CB2C File Offset: 0x0001AD2C
	public static string smethod_1(string string_0)
	{
		return Regex.Replace(string_0, "[^\\-+*/0-9]", "");
	}

	// Token: 0x06002AFF RID: 11007 RVA: 0x00134480 File Offset: 0x00132680
	public static double smethod_2(string string_0)
	{
		string_0 = string_0.Replace(" ", "");
		double num;
		if (double.TryParse(string_0, out num))
		{
			return num;
		}
		int num2 = -1;
		int num3 = 0;
		for (int i = string_0.Length - 1; i >= 0; i--)
		{
			char c = string_0[i];
			if (c == ')')
			{
				num3++;
			}
			else if (c == '(')
			{
				num3--;
			}
			else if ((c == '+' || c == '-') && num3 == 0)
			{
				num2 = i;
				IL_006F:
				if (num2 == -1)
				{
					return Class587.smethod_2(string_0.Substring(1, string_0.Length - 1));
				}
				char c2 = string_0[num2];
				string text = ((num2 > 0) ? string_0.Substring(0, num2) : "");
				string text2 = ((num2 < string_0.Length - 1) ? string_0.Substring(num2 + 1) : "");
				double num4 = Class587.smethod_2(text);
				double num5 = Class587.smethod_2(text2);
				switch (c2)
				{
				case '*':
					return num4 * num5;
				case '+':
					return num4 + num5;
				case '-':
					return num4 - num5;
				case '/':
					return num4 / num5;
				}
				throw new ArgumentException("Invalid operator: " + c2.ToString());
			}
		}
		{
			if (num2 == -1)
			{
				return Class587.smethod_2(string_0.Substring(1, string_0.Length - 1));
			}
			char c2 = string_0[num2];
			string text = ((num2 > 0) ? string_0.Substring(0, num2) : "");
			string text2 = ((num2 < string_0.Length - 1) ? string_0.Substring(num2 + 1) : "");
			double num4 = Class587.smethod_2(text);
			double num5 = Class587.smethod_2(text2);
			switch (c2)
			{
			case '*':
				return num4 * num5;
			case '+':
				return num4 + num5;
			case '-':
				return num4 - num5;
			case '/':
				return num4 / num5;
			}
			throw new ArgumentException("Invalid operator: " + c2.ToString());
		}
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x001345B0 File Offset: 0x001327B0
	public static string smethod_3(byte[] byte_0)
	{
		string text = "";
		text += "        0  1  2  3  4  5  6  7   8  9  A  B  C  D  E  F\r\n";
		text += "       -- -- -- -- -- -- -- --  -- -- -- -- -- -- -- --\r\n";
		text += "0000   ";
		bool flag = false;
		int i = 0;
		while (i < byte_0.Length)
		{
			if (flag)
			{
				goto IL_0040;
			}
			if (byte_0[i] != 0)
			{
				flag = true;
				goto IL_0040;
			}
			IL_02A6:
			i++;
			continue;
			IL_0040:
			if (i != 0 && i % 16 == 0)
			{
				text += "  ";
				int num = i / 16 - 1;
				for (int j = 0; j < 16; j++)
				{
					byte b = byte_0[num * 16 + j];
					if (b >= 32 && b <= 126)
					{
						string text2 = text;
						char c = (char)b;
						text = text2 + c.ToString();
					}
					else
					{
						text += ".";
					}
				}
				text += "  ";
				for (int k = 0; k < 16; k++)
				{
					byte b2 = byte_0[num * 16 + k];
					if (b2 >= 32 && b2 <= 255)
					{
						text += Class587.char_0[(int)b2].ToString();
					}
					else
					{
						text += ".";
					}
				}
				text = text + "\r\n" + i.ToString("X4") + "   ";
			}
			else if (i % 16 == 8)
			{
				text += " ";
			}
			text = text + byte_0[i].ToString("X2") + " ";
			if (i == byte_0.Length - 1)
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num2 = 16 - byte_0.Length % 16;
				int num3 = num2 * 3 + 2;
				if (num2 >= 8)
				{
					num3++;
				}
				for (int l = 0; l < num3; l++)
				{
					stringBuilder.Append(' ');
				}
				int num4 = (i - (byte_0.Length % 16 - 1)) / 16;
				for (int m = 0; m < byte_0.Length % 16; m++)
				{
					int num5 = (int)byte_0[num4 * 16 + m];
					if (num5 >= 32 && num5 <= 126)
					{
						stringBuilder.Append((char)num5);
					}
					else
					{
						stringBuilder.Append(".");
					}
				}
				int num6 = (num3 - (16 - byte_0.Length % 16)) / 2 + 1;
				for (int n = 0; n < num6; n++)
				{
					stringBuilder.Append(' ');
				}
				for (int num7 = 0; num7 < byte_0.Length % 16; num7++)
				{
					int num8 = (int)byte_0[num4 * 16 + num7];
					if (num8 >= 32 && num8 <= 255)
					{
						stringBuilder.Append(Class587.char_0[num8]);
					}
					else
					{
						stringBuilder.Append(".");
					}
				}
				for (int num9 = 0; num9 < num3; num9++)
				{
					stringBuilder.Append(' ');
				}
				text += stringBuilder.ToString();
				num4 = (i - (byte_0.Length % 16 - 1)) / 16;
				goto IL_02A6;
			}
			goto IL_02A6;
		}
		return text + "\n\n";
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x00134880 File Offset: 0x00132A80
	public static Point smethod_4(Point point_0, double double_0, Point point_1, double double_1)
	{
		Math.Sqrt(Math.Pow((double)(point_1.X - point_0.X), 2.0) + Math.Pow((double)(point_1.Y - point_0.Y), 2.0));
		double num = Math.Atan2((double)(point_1.Y - point_0.Y), (double)(point_1.X - point_0.X)) - double_1 * 3.141592653589793 / 180.0;
		int num2 = (int)Math.Round((double)point_0.X + double_0 * Math.Cos(num));
		int num3 = (int)Math.Round((double)point_0.Y + double_0 * Math.Sin(num));
		return new Point(num2, num3);
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x00134944 File Offset: 0x00132B44
	public static string smethod_5()
	{
		string text = Class531.smethod_10(6);
		string text2 = Class529.smethod_1(text).ToLower().Substring(0, 2);
		return text + text2;
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x0001CB3E File Offset: 0x0001AD3E
	public static string smethod_6(this int int_1)
	{
		if (int_1 == 0)
		{
			return "0";
		}
		return string.Format("{0:#,###}", int_1).Replace(".", ",");
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x00134970 File Offset: 0x00132B70
	public static string smethod_7()
	{
		Class587.Class588 @class = new Class587.Class588();
		List<string> list = new List<string>(279)
		{
			"Thiên", "Long", "Bát", "Vân", "Phong", "Hà", "Nhật", "Nguyệt", "Mộc", "Thủy",
			"Hỏa", "Địa", "Huyền", "Tâm", "Ngọc", "Sơn", "Lâm", "Dương", "Tùng", "Quốc",
			"Kiên", "Bình", "Thành", "Cường", "Hưng", "Khải", "Đạt", "Trường", "Thái", "Bảo",
			"Phúc", "Minh", "Quang", "Nhân", "Khánh", "Việt", "Hải", "Tú", "Trí", "Tâm",
			"Thành", "Nguyên", "Lộc", "Tấn", "Vinh", "Hòa", "Nam", "Tính", "Gia", "Tuấn",
			"Đức", "Chí", "Phát", "Huy", "Sáng", "Linh", "Tình", "Thảo", "Nguyên", "Bích",
			"Mai", "Đông", "Tây", "Nam", "Bắc", "Mỹ", "Hạnh", "Vỹ", "Phương", "Kiều",
			"Yến", "Diễm", "Nhung", "Hương", "Lan", "Thảo", "Như", "Châu", "Cát", "Tuyết",
			"Hòa", "Quý", "Thịnh", "Phước", "An", "Đăng", "Khoa", "Hoàng", "Minh", "Bích",
			"Gấm", "Nghi", "Khôi", "Đào", "Thủy", "Diệu", "Thúy", "Hồng", "Ngân", "Quý",
			"Sang", "Thành", "Nguyên", "Thức", "Định", "Huy", "Sự", "Hiếu", "Mạnh", "Quốc",
			"Bảo", "Lộc", "Nhã", "Huyền", "Hòa", "Tâm", "Khánh", "Chí", "Đức", "Thiện",
			"Bình", "Cường", "Trọng", "Hậu", "Thành", "Vinh", "Sỹ", "Nguyên", "Khoa", "Hưng",
			"Bảo", "Tín", "Thi", "Tuyết", "Thạch", "Miên", "Sang", "Thịnh", "Mỹ", "Huy",
			"Xuyên", "Thiên", "Quang", "Khải", "Sơn", "Hưng", "Thủy", "Đức", "Chí", "Phát",
			"Thắng", "Đông", "Kiên", "Vương", "Thái", "Thành", "Bảo", "Minh", "Diệu", "Tín",
			"Lợi", "Cát", "Thắng", "Duy", "Thành", "Hòa", "Kiên", "Tâm", "Thái", "Nhân",
			"Vân", "Hạnh", "Mai", "Hải", "Khoa", "Sáng", "Lộc", "Vĩnh", "Tân", "Định",
			"Quân", "Phúc", "Chí", "Vĩ", "Bình", "Triệu", "Hoàng", "Bảo", "Tú", "Như",
			"Quốc", "Tú", "Chinh", "Khôi", "Hải", "Thái", "Lâm", "Tuyên", "Thảo", "Hạnh",
			"Vũ", "Kỳ", "Ngân", "Hà", "Mỹ", "Đức", "Thúy", "Thảo", "Bảo", "Kiến",
			"Châu", "Hằng", "Giang", "Thành", "Tú", "Tuệ", "Ninh", "Quế", "Ly", "Sương",
			"Hương", "Đan", "Linh", "Yến", "Hòa", "Cẩm", "Quỳnh", "Chí", "Vân", "Hạ",
			"Như", "Tâm", "Nguyệt", "Vinh", "Thành", "Mai", "Châu", "Bích", "Khánh", "Nhã",
			"Tuyết", "Đoan", "Diệu", "Thúy", "Huyền", "Thành", "Ánh", "Cát", "Thành", "Khuê",
			"Đan", "Mẫn", "Thức", "Mẫn", "Thẩm", "Tường", "Quang", "Duy", "Dương", "Khánh",
			"Phúc", "Thịnh", "Mạnh", "Thạch", "Thành", "Khải", "Gia", "Ngọc", "Tâm", "Vũ",
			"Hồng", "Yên", "Linh", "Trâm", "Khải", "Huệ", "Nguyên", "Bạch", "Đức"
		};
		@class.random_0 = new Random();
		string text = list[@class.random_0.Next(list.Count)];
		string text2 = list[@class.random_0.Next(list.Count)];
		string text3 = text + text2;
		while (text3.Length > 11)
		{
			string text4 = list[@class.random_0.Next(list.Count)];
			text2 = list[@class.random_0.Next(list.Count)];
			text3 = text4 + text2;
		}
		return new string(Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyz", 1).Select<string, char>(new Func<string, char>(@class.method_0)).ToArray<char>()) + text3;
	}

	// Token: 0x06002B05 RID: 11013 RVA: 0x0013563C File Offset: 0x0013383C
	public static string smethod_8(string string_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		httpWebRequest.Method = "GET";
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.Proxy = null;
		httpWebRequest.ServicePoint.Expect100Continue = false;
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		string text;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				text = streamReader.ReadToEnd();
			}
		}
		return text;
	}

	// Token: 0x04001F25 RID: 7973
	public static int int_0 = 3450;

	// Token: 0x04001F26 RID: 7974
	public static readonly char[] char_0 = new char[]
	{
		'\0', '\u0001', 'Ẳ', '\u0003', '\u0004', 'Ẵ', 'Ẫ', '\a', '\b', '\t',
		'\n', '\v', '\f', '\r', '\u000e', '\u000f', '\u0010', '\u0011', '\u0012', '\u0013',
		'Ỷ', '\u0015', '\u0016', '\u0017', '\u0018', 'Ỹ', '\u001a', '\u001b', '\u001c', '\u001d',
		'Ỵ', '\u001f', ' ', '!', '"', '#', '$', '%', '&', '\'',
		'(', ')', '*', '+', ',', '-', '.', '/', '0', '1',
		'2', '3', '4', '5', '6', '7', '8', '9', ':', ';',
		'<', '=', '>', '?', '@', 'A', 'B', 'C', 'D', 'E',
		'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
		'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y',
		'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c',
		'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
		'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
		'x', 'y', 'z', '{', '|', '}', '~', '\u007f', 'Ạ', 'Ắ',
		'Ằ', 'Ặ', 'Ấ', 'Ầ', 'Ẩ', 'Ậ', 'Ẽ', 'Ẹ', 'Ế', 'Ề',
		'Ể', 'Ễ', 'Ệ', 'Ố', 'Ồ', 'Ổ', 'Ỗ', 'Ộ', 'Ợ', 'Ớ',
		'Ờ', 'Ở', 'Ị', 'Ỏ', 'Ọ', 'Ỉ', 'Ủ', 'Ũ', 'Ụ', 'Ỳ',
		'Õ', 'ắ', 'ằ', 'ặ', 'ấ', 'ầ', 'ẩ', 'ậ', 'ẽ', 'ẹ',
		'ế', 'ề', 'ể', 'ễ', 'ệ', 'ố', 'ồ', 'ổ', 'ỗ', 'Ỡ',
		'Ơ', 'ộ', 'ờ', 'ở', 'ị', 'Ự', 'Ứ', 'Ừ', 'Ử', 'ơ',
		'ớ', 'Ư', 'À', 'Á', 'Â', 'Ã', 'Ả', 'Ă', 'ẳ', 'ẵ',
		'È', 'É', 'Ê', 'Ẻ', 'Ì', 'Í', 'Ĩ', 'ỳ', 'Đ', 'ứ',
		'Ò', 'Ó', 'Ô', 'ạ', 'ỷ', 'ừ', 'ử', 'Ù', 'Ú', 'ỹ',
		'ỵ', 'Ý', 'ỡ', 'ư', 'à', 'á', 'â', 'ã', 'ả', 'ă',
		'ữ', 'ẫ', 'è', 'é', 'ê', 'ẻ', 'ì', 'í', 'ĩ', 'ỉ',
		'đ', 'ự', 'ò', 'ó', 'ô', 'õ', 'ỏ', 'ọ', 'ụ', 'ù',
		'ú', 'ũ', 'ủ', 'ý', 'ợ', 'Ữ'
	};

	// Token: 0x02000330 RID: 816
	[CompilerGenerated]
	private sealed class Class588
	{
		// Token: 0x06002B08 RID: 11016 RVA: 0x0001CB8E File Offset: 0x0001AD8E
		internal char method_0(string string_0)
		{
			return string_0[this.random_0.Next(string_0.Length)];
		}

		// Token: 0x04001F27 RID: 7975
		public Random random_0;
	}
}
