using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

// Token: 0x02000260 RID: 608
internal static class Class395
{
	// Token: 0x06002023 RID: 8227 RVA: 0x000EB410 File Offset: 0x000E9610
	public static string smethod_0(this string string_0, string string_1, string string_2)
	{
		int num = string_0.IndexOf(string_1);
		if (num < 0)
		{
			return string_0;
		}
		return string_0.Substring(0, num) + string_2 + string_0.Substring(num + string_1.Length);
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000158B6 File Offset: 0x00013AB6
	public static string smethod_1(this string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string_0;
		}
		string_0 = string_0.ToLower();
		return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(string_0);
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000EB448 File Offset: 0x000E9648
	public static List<int> smethod_2(this ListView listView_0)
	{
		List<int> list = new List<int>();
		if (listView_0.VirtualMode && listView_0.VirtualListSize != 0)
		{
			int scrollPos = Class395.GetScrollPos(listView_0.Handle, 1);
			Rectangle itemRect;
			List<int> list2;
			try
			{
				itemRect = listView_0.GetItemRect(0);
				goto IL_0036;
			}
			catch
			{
				list2 = list;
			}
			return list2;
			IL_0036:
			int height = itemRect.Height;
			int num = scrollPos / height;
			int num2 = listView_0.ClientSize.Height / height;
			int num3 = Math.Min(num + num2, listView_0.VirtualListSize - 1);
			for (int i = num; i <= num3; i++)
			{
				list.Add(i);
			}
			return list;
		}
		return list;
	}

	// Token: 0x06002026 RID: 8230
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetScrollPos(IntPtr intptr_0, int int_2);

	// Token: 0x06002027 RID: 8231 RVA: 0x000EB4E8 File Offset: 0x000E96E8
	public static string smethod_3(this string string_0)
	{
		string_0 = string_0.Replace(" ", "");
		if (string_0.Length % 2 != 0)
		{
			string_0 += "0";
		}
		string text = string.Empty;
		for (int i = string_0.Length; i > 0; i -= 2)
		{
			text += string_0.Substring(i - 2, 2);
		}
		return text;
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000EB548 File Offset: 0x000E9748
	public static void smethod_4(this TabControl tabControl_0, int int_2, int int_3)
	{
		if (int_2 == int_3)
		{
			return;
		}
		TabPage tabPage = tabControl_0.TabPages[int_2];
		tabControl_0.TabPages.RemoveAt(int_2);
		tabControl_0.TabPages.Insert(int_3, tabPage);
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000158DA File Offset: 0x00013ADA
	public static string smethod_5(this IEnumerable<string> ienumerable_0, string string_0)
	{
		if (ienumerable_0 == null)
		{
			return string.Empty;
		}
		return string.Join(string_0, ienumerable_0);
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000EB580 File Offset: 0x000E9780
	public static int smethod_6(this string string_0)
	{
		foreach (KeyValuePair<int, string> keyValuePair in Class501.Dictionary_0)
		{
			if (keyValuePair.Value.smethod_36() == string_0.smethod_36())
			{
				return keyValuePair.Key;
			}
		}
		foreach (KeyValuePair<string, string> keyValuePair2 in Class501.Dictionary_1)
		{
			if (keyValuePair2.Value.smethod_36() == string_0.smethod_36())
			{
				foreach (KeyValuePair<int, string> keyValuePair3 in Class501.Dictionary_0)
				{
					if (keyValuePair3.Value.smethod_36() == keyValuePair2.Value.smethod_36())
					{
						return keyValuePair3.Key;
					}
				}
			}
		}
		return -1;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000158EC File Offset: 0x00013AEC
	public static string smethod_7(this IEnumerable<string> ienumerable_0)
	{
		return ienumerable_0.smethod_5(string.Empty);
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000158F9 File Offset: 0x00013AF9
	public static string smethod_8(this IEnumerable<string> ienumerable_0, char char_0)
	{
		return ienumerable_0.smethod_5(char_0.ToString());
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x00015908 File Offset: 0x00013B08
	public static IEnumerable<T> smethod_9<T, U>(this IEnumerable<T> ienumerable_0, Func<T, U> func_0)
	{
		Class395.Class398<T, U> @class = new Class395.Class398<T, U>(-2);
		@class.ienumerable_1 = ienumerable_0;
		@class.func_1 = func_0;
		return @class;
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000EB6B4 File Offset: 0x000E98B4
	public static List<int> smethod_10(this byte[] byte_0, string string_0)
	{
		byte?[] array = Class395.smethod_12(string_0);
		List<int> list = new List<int>();
		if (byte_0 != null && array != null && byte_0.Length != 0 && array.Length != 0 && array.Length <= byte_0.Length)
		{
			int num = byte_0.Length;
			int num2 = array.Length;
			int i = 0;
			while (i <= num - num2)
			{
				int j = num2 - 1;
				while (j >= 0)
				{
					if (array[j] == null)
					{
						j--;
					}
					else
					{
						int num3 = (int)byte_0[i + j];
						byte? b = array[j];
						int? num4 = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
						if (!((num3 == num4.GetValueOrDefault()) & (num4 != null)))
						{
							break;
						}
						j--;
					}
				}
				if (j < 0)
				{
					list.Add(i);
					i++;
				}
				else
				{
					i++;
				}
			}
			return list;
		}
		return list;
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000EB79C File Offset: 0x000E999C
	public static List<int> smethod_11(this byte[] byte_0, string string_0, string string_1)
	{
		Class395.smethod_12(string_0);
		byte?[] array = Class395.smethod_12(string_1);
		List<int> list = byte_0.smethod_10(string_0);
		if (list.Count == 0)
		{
			return new List<int>();
		}
		foreach (int num in list)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					byte_0[num + i] = array[i].Value;
				}
			}
		}
		return list;
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000EB840 File Offset: 0x000E9A40
	public static byte?[] smethod_12(string string_0)
	{
		List<byte?> list = new List<byte?>();
		string_0 = string_0.Replace(" ", "").ToUpper();
		for (int i = 0; i < string_0.Length / 2; i++)
		{
			string text = string_0.Substring(i * 2, 2);
			if (text.Equals("??"))
			{
				list.Add(null);
			}
			else
			{
				try
				{
					list.Add(new byte?(Convert.ToByte(text, 16)));
				}
				catch
				{
					list.Add(null);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x0001591F File Offset: 0x00013B1F
	public static bool smethod_13(this string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			Func<char, bool> func;
			if ((func = Class395.Class396.func_0) == null)
			{
				func = (Class395.Class396.func_0 = new Func<char, bool>(char.IsDigit));
			}
			return string_0.All<char>(func);
		}
		return false;
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000EB8E4 File Offset: 0x000E9AE4
	public static void smethod_14(this StringBuilder stringBuilder_0, string string_0, string string_1)
	{
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		stringBuilder_0.Append(" ");
		stringBuilder_0.Append(string_0);
		stringBuilder_0.Append("=\"");
		stringBuilder_0.Append(SecurityElement.Escape(string_1));
		stringBuilder_0.Append("\"");
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000EB934 File Offset: 0x000E9B34
	public static int smethod_15(this string[] string_0, string string_1)
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == string_1)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000EB960 File Offset: 0x000E9B60
	public static int smethod_16(this byte[] byte_0, byte byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (byte_0[i] == byte_1)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x000EB988 File Offset: 0x000E9B88
	public static string smethod_17(this string string_0, string string_1, string string_2 = "")
	{
		int num = string_0.IndexOf(string_1);
		if (num == -1)
		{
			return string.Empty;
		}
		int num2 = ((string_2 != "") ? string_0.IndexOf(string_2, num + string_1.Length) : string_0.Length);
		if (num2 == -1)
		{
			return string.Empty;
		}
		return string_0.Substring(num + string_1.Length, num2 - num - string_1.Length);
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000EB9F0 File Offset: 0x000E9BF0
	public static string smethod_18(this string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0.Length * 4);
		foreach (char c in string_0)
		{
			if (c != ' ')
			{
				int num;
				if (int.TryParse(c.ToString(), NumberStyles.HexNumber, null, out num))
				{
					stringBuilder.Append(Convert.ToString(num, 2).PadLeft(4, '0'));
				}
				else
				{
					stringBuilder.Append("0000");
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000EBA6C File Offset: 0x000E9C6C
	public static string smethod_19(this string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = (8 - string_0.Length % 8) % 8;
		string_0 = string_0.PadRight(string_0.Length + num, '0');
		for (int i = 0; i < string_0.Length; i += 8)
		{
			string text = string_0.Substring(i, 8);
			try
			{
				stringBuilder.Append(Convert.ToInt32(text, 2).ToString("X2"));
			}
			catch
			{
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000EBAF0 File Offset: 0x000E9CF0
	public static void smethod_20(this Control3 control3_0, string string_0)
	{
		string_0 = string_0.smethod_36();
		Class357 @class;
		if (string_0.Length == 0)
		{
			@class = control3_0.Class357_5.method_6();
			@class.GStruct19_0 = new GStruct19(0, 0);
			@class.GStruct19_1 = new GStruct19(0, 0);
			@class.method_40();
			control3_0.Class357_5 = @class;
			control3_0.method_51();
			control3_0.method_4();
			return;
		}
		if (string_0.Length > 0)
		{
			for (int i = 0; i < control3_0.IList_0.Count; i++)
			{
				if (control3_0.IList_0[i].smethod_36().Contains(string_0))
				{
					@class = control3_0.Class357_5.method_6();
					@class.GStruct19_0 = new GStruct19(0, i);
					@class.GStruct19_1 = new GStruct19(control3_0.IList_0[i].Length, i);
					@class.method_40();
					control3_0.Class357_5 = @class;
					control3_0.method_51();
					control3_0.method_4();
					return;
				}
			}
		}
		@class = control3_0.Class357_5.method_6();
		@class.GStruct19_0 = new GStruct19(0, 0);
		@class.GStruct19_1 = new GStruct19(0, 0);
		@class.method_40();
		control3_0.Class357_5 = @class;
		control3_0.method_51();
		control3_0.method_4();
	}

	// Token: 0x06002039 RID: 8249
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(HandleRef handleRef_0, int int_2, int int_3, ref Class395.Struct40 struct40_0);

	// Token: 0x0600203A RID: 8250 RVA: 0x0001594C File Offset: 0x00013B4C
	public static void smethod_21(this ListView listView_0)
	{
		Class395.smethod_23(listView_0, -1, 2, 2);
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x000EBC1C File Offset: 0x000E9E1C
	public static void smethod_22<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0)
	{
		foreach (T t in ienumerable_0)
		{
			action_0(t);
		}
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000EBC68 File Offset: 0x000E9E68
	public static void smethod_23(ListView listView_0, int int_2, int int_3, int int_4)
	{
		Class395.Struct40 @struct = default(Class395.Struct40);
		@struct.int_4 = int_3;
		@struct.int_3 = int_4;
		Class395.SendMessage(new HandleRef(listView_0, listView_0.Handle), 4139, int_2, ref @struct);
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000EBCA8 File Offset: 0x000E9EA8
	public static bool smethod_24(this Point point_0, Point point_1, Point point_2)
	{
		point_0.X -= point_2.X;
		point_1.X -= point_2.X;
		point_0.Y = point_2.Y - point_0.Y;
		point_1.Y = point_2.Y - point_1.Y;
		return (point_1.X - point_0.X) * (point_1.Y + point_0.Y) > 0;
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00015957 File Offset: 0x00013B57
	public static IEnumerable<IEnumerable<T>> smethod_25<T>(this T[] gparam_0, int int_2)
	{
		Class395.Class399<T> @class = new Class395.Class399<T>(-2);
		@class.gparam_1 = gparam_0;
		@class.int_3 = int_2;
		return @class;
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000EBD30 File Offset: 0x000E9F30
	public static int smethod_26(this string string_0)
	{
		Func<char, bool> func;
		if ((func = Class395.Class396.func_0) == null)
		{
			func = (Class395.Class396.func_0 = new Func<char, bool>(char.IsDigit));
		}
		IEnumerable<char> enumerable = string_0.Where<char>(func);
		if (!enumerable.Any<char>())
		{
			return 0;
		}
		int num = enumerable.Aggregate(0, new Func<int, char, int>(Class395.Class397.f_4CB783C4.method_0));
		if (string_0.StartsWith("-"))
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x0001596E File Offset: 0x00013B6E
	public static int smethod_27(this bool bool_0)
	{
		return (bool_0) ? 1 : 0;
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x00015974 File Offset: 0x00013B74
	public static int smethod_28(this float float_0)
	{
		return BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0);
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000EBDA4 File Offset: 0x000E9FA4
	public static int smethod_29(this string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return -1;
		}
		int num = 0;
		string text = string.Empty;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (char.IsDigit(string_0[i]))
			{
				text += string_0[i].ToString();
			}
			else if (text.Length > 0)
			{
				break;
			}
		}
		if (text.Length > 0)
		{
			num = int.Parse(text);
		}
		if (string_0.StartsWith("-"))
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x00015982 File Offset: 0x00013B82
	public static void smethod_30(this ComboBox comboBox_0)
	{
		comboBox_0.MouseWheel += Class395.Class397.f_4CB783C4.method_1;
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000159A9 File Offset: 0x00013BA9
	public static void smethod_31(this NumericUpDown numericUpDown_0)
	{
		numericUpDown_0.MouseWheel += Class395.Class397.f_4CB783C4.method_2;
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000EBE24 File Offset: 0x000EA024
	public static bool smethod_32(this string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		string text = string_0.ToLower();
		return text == "true" || (!(text == "false") && (text == "1" || (!(text == "0") && false)));
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000EBE8C File Offset: 0x000EA08C
	public static void smethod_33(this ToolStripMenuItem toolStripMenuItem_0)
	{
		ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_0.OwnerItem as ToolStripMenuItem;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Checked = true;
			toolStripMenuItem.smethod_33();
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000EBEB8 File Offset: 0x000EA0B8
	public static void smethod_34(this ToolStripMenuItem toolStripMenuItem_0)
	{
		foreach (object obj in toolStripMenuItem_0.DropDownItems)
		{
			ToolStripMenuItem toolStripMenuItem = obj as ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				if (toolStripMenuItem.Checked)
				{
					toolStripMenuItem_0.Checked = true;
					toolStripMenuItem_0.smethod_33();
					break;
				}
				if (toolStripMenuItem.DropDownItems.Count > 0)
				{
					toolStripMenuItem.smethod_34();
				}
			}
		}
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000EBF3C File Offset: 0x000EA13C
	public static void smethod_35(this ToolStripMenuItem toolStripMenuItem_0)
	{
		foreach (object obj in toolStripMenuItem_0.DropDownItems)
		{
			ToolStripMenuItem toolStripMenuItem = obj as ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Checked = false;
				if (toolStripMenuItem.DropDownItems.Count > 0)
				{
					toolStripMenuItem.smethod_35();
				}
			}
		}
	}

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x06002049 RID: 8265 RVA: 0x000159D0 File Offset: 0x00013BD0
	// (set) Token: 0x0600204A RID: 8266 RVA: 0x000159D7 File Offset: 0x00013BD7
	private static Dictionary<char, char> Dictionary_0 { get; set; } = new Dictionary<char, char>
	{
		{ 'à', 'a' },
		{ 'á', 'a' },
		{ 'ả', 'a' },
		{ 'ã', 'a' },
		{ 'ạ', 'a' },
		{ 'ă', 'a' },
		{ 'ằ', 'a' },
		{ 'ắ', 'a' },
		{ 'ẳ', 'a' },
		{ 'ẵ', 'a' },
		{ 'ặ', 'a' },
		{ 'â', 'a' },
		{ 'ầ', 'a' },
		{ 'ấ', 'a' },
		{ 'ẩ', 'a' },
		{ 'ẫ', 'a' },
		{ 'ậ', 'a' },
		{ 'è', 'e' },
		{ 'é', 'e' },
		{ 'ẻ', 'e' },
		{ 'ẽ', 'e' },
		{ 'ẹ', 'e' },
		{ 'ê', 'e' },
		{ 'ề', 'e' },
		{ 'ế', 'e' },
		{ 'ể', 'e' },
		{ 'ễ', 'e' },
		{ 'ệ', 'e' },
		{ 'ì', 'i' },
		{ 'í', 'i' },
		{ 'ỉ', 'i' },
		{ 'ĩ', 'i' },
		{ 'ị', 'i' },
		{ 'ò', 'o' },
		{ 'ó', 'o' },
		{ 'ỏ', 'o' },
		{ 'õ', 'o' },
		{ 'ọ', 'o' },
		{ 'ô', 'o' },
		{ 'ồ', 'o' },
		{ 'ố', 'o' },
		{ 'ổ', 'o' },
		{ 'ỗ', 'o' },
		{ 'ộ', 'o' },
		{ 'ơ', 'o' },
		{ 'ờ', 'o' },
		{ 'ớ', 'o' },
		{ 'ở', 'o' },
		{ 'ỡ', 'o' },
		{ 'ợ', 'o' },
		{ 'ù', 'u' },
		{ 'ú', 'u' },
		{ 'ủ', 'u' },
		{ 'ũ', 'u' },
		{ 'ụ', 'u' },
		{ 'ư', 'u' },
		{ 'ừ', 'u' },
		{ 'ứ', 'u' },
		{ 'ử', 'u' },
		{ 'ữ', 'u' },
		{ 'ự', 'u' },
		{ 'ỳ', 'y' },
		{ 'ý', 'y' },
		{ 'ỷ', 'y' },
		{ 'ỹ', 'y' },
		{ 'ỵ', 'y' },
		{ 'đ', 'd' }
	};

	// Token: 0x0600204B RID: 8267 RVA: 0x000EBFB0 File Offset: 0x000EA1B0
	public static string smethod_36(this string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		char[] array = new char[string_0.Length];
		int num = 0;
		foreach (char c in string_0.ToLowerInvariant())
		{
			if (!char.IsWhiteSpace(c))
			{
				char c2;
				array[num++] = (Class395.Dictionary_0.TryGetValue(c, out c2) ? c2 : c);
			}
		}
		return new string(array, 0, num);
	}

	// Token: 0x0400144E RID: 5198
	internal const int int_0 = 4096;

	// Token: 0x0400144F RID: 5199
	private const int int_1 = 4139;

	// Token: 0x04001450 RID: 5200
	[CompilerGenerated]
	private static Dictionary<char, char> dictionary_0;

	// Token: 0x02000261 RID: 609
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct Struct40
	{
		// Token: 0x04001451 RID: 5201
		public int int_0;

		// Token: 0x04001452 RID: 5202
		public int int_1;

		// Token: 0x04001453 RID: 5203
		public int int_2;

		// Token: 0x04001454 RID: 5204
		public int int_3;

		// Token: 0x04001455 RID: 5205
		public int int_4;

		// Token: 0x04001456 RID: 5206
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;

		// Token: 0x04001457 RID: 5207
		public int int_5;

		// Token: 0x04001458 RID: 5208
		public int int_6;

		// Token: 0x04001459 RID: 5209
		public IntPtr intptr_0;

		// Token: 0x0400145A RID: 5210
		public int int_7;

		// Token: 0x0400145B RID: 5211
		public int int_8;

		// Token: 0x0400145C RID: 5212
		public int int_9;

		// Token: 0x0400145D RID: 5213
		public IntPtr intptr_1;
	}

	// Token: 0x02000262 RID: 610
	[CompilerGenerated]
	private static class Class396
	{
		// Token: 0x0400145E RID: 5214
		public static Func<char, bool> func_0;
	}

	// Token: 0x02000263 RID: 611
	[CompilerGenerated]
	[Serializable]
	private sealed class Class397
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x000159EB File Offset: 0x00013BEB
		internal int method_0(int int_0, char char_0)
		{
			return int_0 * 10 + (int)(char_0 - '0');
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000159F6 File Offset: 0x00013BF6
		internal void method_1(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000159F6 File Offset: 0x00013BF6
		internal void method_2(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}

		// Token: 0x0400145F RID: 5215
		public static readonly Class395.Class397 f_4CB783C4 = new Class395.Class397();

		// Token: 0x04001460 RID: 5216
		public static Func<int, char, int> f_AC9E87C4;

		// Token: 0x04001461 RID: 5217
		public static MouseEventHandler f_C53B9883;

		// Token: 0x04001462 RID: 5218
		public static MouseEventHandler f_888A38FF;
	}

	// Token: 0x02000264 RID: 612
	[CompilerGenerated]
	private sealed class Class398<T, U> : IEnumerable, IDisposable, IEnumerator, IEnumerable<T>, IEnumerator<T>
	{
		// Token: 0x06002052 RID: 8274 RVA: 0x00015A04 File Offset: 0x00013C04
		[DebuggerHidden]
		public Class398(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000EC3A8 File Offset: 0x000EA5A8
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.hashSet_0 = null;
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000EC3F8 File Offset: 0x000EA5F8
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					this.hashSet_0 = new HashSet<U>();
					this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
					this.int_0 = -3;
				}
				while (this.ienumerator_0.MoveNext())
				{
					T t = this.ienumerator_0.Current;
					if (this.hashSet_0.Add(this.func_0(t)))
					{
						this.gparam_0 = t;
						this.int_0 = 1;
						return true;
					}
				}
				this.method_0();
				this.ienumerator_0 = null;
				flag = false;
			}
			catch
			{
				((System.IDisposable)this).Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00015A1E File Offset: 0x00013C1E
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00015A3A File Offset: 0x00013C3A
		public T Current
		{
			[DebuggerHidden]
			get
			{
				return this.gparam_0;
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00015A42 File Offset: 0x00013C42
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.gparam_0;
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000EC4C0 File Offset: 0x000EA6C0
		[DebuggerHidden]
		public IEnumerator<T> GetEnumerator()
		{
			Class395.Class398<T, U> @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class395.Class398<T, U>(0);
			}
			@class.ienumerable_0 = this.ienumerable_1;
			@class.func_0 = this.func_1;
			return @class;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00015A4F File Offset: 0x00013C4F
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
		}

		// Token: 0x04001463 RID: 5219
		private int int_0;

		// Token: 0x04001464 RID: 5220
		private T gparam_0;

		// Token: 0x04001465 RID: 5221
		private int int_1;

		// Token: 0x04001466 RID: 5222
		private IEnumerable<T> ienumerable_0;

		// Token: 0x04001467 RID: 5223
		public IEnumerable<T> ienumerable_1;

		// Token: 0x04001468 RID: 5224
		private Func<T, U> func_0;

		// Token: 0x04001469 RID: 5225
		public Func<T, U> func_1;

		// Token: 0x0400146A RID: 5226
		private HashSet<U> hashSet_0;

		// Token: 0x0400146B RID: 5227
		private IEnumerator<T> ienumerator_0;
	}

	// Token: 0x02000265 RID: 613
	[CompilerGenerated]
	private sealed class Class399<T> : IEnumerable, IDisposable, IEnumerator, IEnumerable<IEnumerable<T>>, IEnumerator<IEnumerable<T>>
	{
		// Token: 0x0600205B RID: 8283 RVA: 0x00015A57 File Offset: 0x00013C57
		[DebuggerHidden]
		public Class399(int int_5)
		{
			this.int_0 = int_5;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00015A71 File Offset: 0x00013C71
		[DebuggerHidden]
		public void Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000EC510 File Offset: 0x000EA710
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
				int num2 = this.int_4;
				this.int_4 = num2 + 1;
			}
			else
			{
				this.int_0 = -1;
				this.int_4 = 0;
			}
			if ((float)this.int_4 >= (float)this.gparam_0.Length / (float)this.int_2)
			{
				return false;
			}
			this.ienumerable_0 = this.gparam_0.Skip<T>(this.int_4 * this.int_2).Take<T>(this.int_2);
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00015A7B File Offset: 0x00013C7B
		public IEnumerable<T> Current
		{
			[DebuggerHidden]
			get
			{
				return this.ienumerable_0;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x00015A7B File Offset: 0x00013C7B
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.ienumerable_0;
			}
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000EC5A4 File Offset: 0x000EA7A4
		[DebuggerHidden]
		public IEnumerator<IEnumerable<T>> GetEnumerator()
		{
			Class395.Class399<T> @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class395.Class399<T>(0);
			}
			@class.gparam_0 = this.gparam_1;
			@class.int_2 = this.int_3;
			return @class;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00015A83 File Offset: 0x00013C83
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>)this).GetEnumerator();
		}

		// Token: 0x0400146C RID: 5228
		private int int_0;

		// Token: 0x0400146D RID: 5229
		private IEnumerable<T> ienumerable_0;

		// Token: 0x0400146E RID: 5230
		private int int_1;

		// Token: 0x0400146F RID: 5231
		private T[] gparam_0;

		// Token: 0x04001470 RID: 5232
		public T[] gparam_1;

		// Token: 0x04001471 RID: 5233
		private int int_2;

		// Token: 0x04001472 RID: 5234
		public int int_3;

		// Token: 0x04001473 RID: 5235
		private int int_4;
	}
}
