using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x020002CD RID: 717
internal class Class500
{
	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x06002406 RID: 9222 RVA: 0x00018789 File Offset: 0x00016989
	public static char[] Char_0
	{
		get
		{
			return new char[]
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
		}
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x00110954 File Offset: 0x0010EB54
	public static int smethod_0(string string_0)
	{
		if (string_0.Contains("?"))
		{
			return -1;
		}
		if (string_0.Contains("#"))
		{
			return 257;
		}
		int num = -1;
		int.TryParse(string_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num);
		return num;
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x0011099C File Offset: 0x0010EB9C
	public static int[] smethod_1(string string_0)
	{
		string_0 = string_0.Replace(" ", "");
		if (string_0.Length % 2 != 0)
		{
			string_0 += "0";
		}
		int[] array = new int[string_0.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Class500.smethod_0(string_0.Substring(i * 2, 2));
		}
		return array;
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x00110A04 File Offset: 0x0010EC04
	public static string smethod_2(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in byte_0)
		{
			if (c == '\0')
			{
				break;
			}
			if (c < 'Ā')
			{
				stringBuilder.Append(Class500.Char_0[(int)c]);
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x00110A54 File Offset: 0x0010EC54
	public static string smethod_3(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in byte_0)
		{
			if (c == '\0')
			{
				stringBuilder.Append('.');
			}
			else if (c < 'Ā')
			{
				stringBuilder.Append(Class500.Char_0[(int)c]);
			}
			else
			{
				stringBuilder.Append("?");
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x00110AB4 File Offset: 0x0010ECB4
	// Note: this type is marked as 'beforefieldinit'.
	static Class500()
	{
		Dictionary<char, byte> dictionary = new Dictionary<char, byte>();
		dictionary['\0'] = 0;
		dictionary['\u0001'] = 1;
		dictionary['Ẳ'] = 2;
		dictionary['\u0003'] = 3;
		dictionary['\u0004'] = 4;
		dictionary['Ẵ'] = 5;
		dictionary['Ẫ'] = 6;
		dictionary['\a'] = 7;
		dictionary['\b'] = 8;
		dictionary['\t'] = 9;
		dictionary['\n'] = 10;
		dictionary['\v'] = 11;
		dictionary['\f'] = 12;
		dictionary['\r'] = 13;
		dictionary['\u000e'] = 14;
		dictionary['\u000f'] = 15;
		dictionary['\u0010'] = 16;
		dictionary['\u0011'] = 17;
		dictionary['\u0012'] = 18;
		dictionary['\u0013'] = 19;
		dictionary['Ỷ'] = 20;
		dictionary['\u0015'] = 21;
		dictionary['\u0016'] = 22;
		dictionary['\u0017'] = 23;
		dictionary['\u0018'] = 24;
		dictionary['Ỹ'] = 25;
		dictionary['\u001a'] = 26;
		dictionary['\u001b'] = 27;
		dictionary['\u001c'] = 28;
		dictionary['\u001d'] = 29;
		dictionary['Ỵ'] = 30;
		dictionary['\u001f'] = 31;
		dictionary[' '] = 32;
		dictionary['!'] = 33;
		dictionary['"'] = 34;
		dictionary['#'] = 35;
		dictionary['$'] = 36;
		dictionary['%'] = 37;
		dictionary['&'] = 38;
		dictionary['\''] = 39;
		dictionary['('] = 40;
		dictionary[')'] = 41;
		dictionary['*'] = 42;
		dictionary['+'] = 43;
		dictionary[','] = 44;
		dictionary['-'] = 45;
		dictionary['.'] = 46;
		dictionary['/'] = 47;
		dictionary['0'] = 48;
		dictionary['1'] = 49;
		dictionary['2'] = 50;
		dictionary['3'] = 51;
		dictionary['4'] = 52;
		dictionary['5'] = 53;
		dictionary['6'] = 54;
		dictionary['7'] = 55;
		dictionary['8'] = 56;
		dictionary['9'] = 57;
		dictionary[':'] = 58;
		dictionary[';'] = 59;
		dictionary['<'] = 60;
		dictionary['='] = 61;
		dictionary['>'] = 62;
		dictionary['?'] = 63;
		dictionary['@'] = 64;
		dictionary['A'] = 65;
		dictionary['B'] = 66;
		dictionary['C'] = 67;
		dictionary['D'] = 68;
		dictionary['E'] = 69;
		dictionary['F'] = 70;
		dictionary['G'] = 71;
		dictionary['H'] = 72;
		dictionary['I'] = 73;
		dictionary['J'] = 74;
		dictionary['K'] = 75;
		dictionary['L'] = 76;
		dictionary['M'] = 77;
		dictionary['N'] = 78;
		dictionary['O'] = 79;
		dictionary['P'] = 80;
		dictionary['Q'] = 81;
		dictionary['R'] = 82;
		dictionary['S'] = 83;
		dictionary['T'] = 84;
		dictionary['U'] = 85;
		dictionary['V'] = 86;
		dictionary['W'] = 87;
		dictionary['X'] = 88;
		dictionary['Y'] = 89;
		dictionary['Z'] = 90;
		dictionary['['] = 91;
		dictionary['\\'] = 92;
		dictionary[']'] = 93;
		dictionary['^'] = 94;
		dictionary['_'] = 95;
		dictionary['`'] = 96;
		dictionary['a'] = 97;
		dictionary['b'] = 98;
		dictionary['c'] = 99;
		dictionary['d'] = 100;
		dictionary['e'] = 101;
		dictionary['f'] = 102;
		dictionary['g'] = 103;
		dictionary['h'] = 104;
		dictionary['i'] = 105;
		dictionary['j'] = 106;
		dictionary['k'] = 107;
		dictionary['l'] = 108;
		dictionary['m'] = 109;
		dictionary['n'] = 110;
		dictionary['o'] = 111;
		dictionary['p'] = 112;
		dictionary['q'] = 113;
		dictionary['r'] = 114;
		dictionary['s'] = 115;
		dictionary['t'] = 116;
		dictionary['u'] = 117;
		dictionary['v'] = 118;
		dictionary['w'] = 119;
		dictionary['x'] = 120;
		dictionary['y'] = 121;
		dictionary['z'] = 122;
		dictionary['{'] = 123;
		dictionary['|'] = 124;
		dictionary['}'] = 125;
		dictionary['~'] = 126;
		dictionary['\u007f'] = 127;
		dictionary['Ạ'] = 128;
		dictionary['Ắ'] = 129;
		dictionary['Ằ'] = 130;
		dictionary['Ặ'] = 131;
		dictionary['Ấ'] = 132;
		dictionary['Ầ'] = 133;
		dictionary['Ẩ'] = 134;
		dictionary['Ậ'] = 135;
		dictionary['Ẽ'] = 136;
		dictionary['Ẹ'] = 137;
		dictionary['Ế'] = 138;
		dictionary['Ề'] = 139;
		dictionary['Ể'] = 140;
		dictionary['Ễ'] = 141;
		dictionary['Ệ'] = 142;
		dictionary['Ố'] = 143;
		dictionary['Ồ'] = 144;
		dictionary['Ổ'] = 145;
		dictionary['Ỗ'] = 146;
		dictionary['Ộ'] = 147;
		dictionary['Ợ'] = 148;
		dictionary['Ớ'] = 149;
		dictionary['Ờ'] = 150;
		dictionary['Ở'] = 151;
		dictionary['Ị'] = 152;
		dictionary['Ỏ'] = 153;
		dictionary['Ọ'] = 154;
		dictionary['Ỉ'] = 155;
		dictionary['Ủ'] = 156;
		dictionary['Ũ'] = 157;
		dictionary['Ụ'] = 158;
		dictionary['Ỳ'] = 159;
		dictionary['Õ'] = 160;
		dictionary['ắ'] = 161;
		dictionary['ằ'] = 162;
		dictionary['ặ'] = 163;
		dictionary['ấ'] = 164;
		dictionary['ầ'] = 165;
		dictionary['ẩ'] = 166;
		dictionary['ậ'] = 167;
		dictionary['ẽ'] = 168;
		dictionary['ẹ'] = 169;
		dictionary['ế'] = 170;
		dictionary['ề'] = 171;
		dictionary['ể'] = 172;
		dictionary['ễ'] = 173;
		dictionary['ệ'] = 174;
		dictionary['ố'] = 175;
		dictionary['ồ'] = 176;
		dictionary['ổ'] = 177;
		dictionary['ỗ'] = 178;
		dictionary['Ỡ'] = 179;
		dictionary['Ơ'] = 180;
		dictionary['ộ'] = 181;
		dictionary['ờ'] = 182;
		dictionary['ở'] = 183;
		dictionary['ị'] = 184;
		dictionary['Ự'] = 185;
		dictionary['Ứ'] = 186;
		dictionary['Ừ'] = 187;
		dictionary['Ử'] = 188;
		dictionary['ơ'] = 189;
		dictionary['ớ'] = 190;
		dictionary['Ư'] = 191;
		dictionary['À'] = 192;
		dictionary['Á'] = 193;
		dictionary['Â'] = 194;
		dictionary['Ã'] = 195;
		dictionary['Ả'] = 196;
		dictionary['Ă'] = 197;
		dictionary['ẳ'] = 198;
		dictionary['ẵ'] = 199;
		dictionary['È'] = 200;
		dictionary['É'] = 201;
		dictionary['Ê'] = 202;
		dictionary['Ẻ'] = 203;
		dictionary['Ì'] = 204;
		dictionary['Í'] = 205;
		dictionary['Ĩ'] = 206;
		dictionary['ỳ'] = 207;
		dictionary['Đ'] = 208;
		dictionary['ứ'] = 209;
		dictionary['Ò'] = 210;
		dictionary['Ó'] = 211;
		dictionary['Ô'] = 212;
		dictionary['ạ'] = 213;
		dictionary['ỷ'] = 214;
		dictionary['ừ'] = 215;
		dictionary['ử'] = 216;
		dictionary['Ù'] = 217;
		dictionary['Ú'] = 218;
		dictionary['ỹ'] = 219;
		dictionary['ỵ'] = 220;
		dictionary['Ý'] = 221;
		dictionary['ỡ'] = 222;
		dictionary['ư'] = 223;
		dictionary['à'] = 224;
		dictionary['á'] = 225;
		dictionary['â'] = 226;
		dictionary['ã'] = 227;
		dictionary['ả'] = 228;
		dictionary['ă'] = 229;
		dictionary['ữ'] = 230;
		dictionary['ẫ'] = 231;
		dictionary['è'] = 232;
		dictionary['é'] = 233;
		dictionary['ê'] = 234;
		dictionary['ẻ'] = 235;
		dictionary['ì'] = 236;
		dictionary['í'] = 237;
		dictionary['ĩ'] = 238;
		dictionary['ỉ'] = 239;
		dictionary['đ'] = 240;
		dictionary['ự'] = 241;
		dictionary['ò'] = 242;
		dictionary['ó'] = 243;
		dictionary['ô'] = 244;
		dictionary['õ'] = 245;
		dictionary['ỏ'] = 246;
		dictionary['ọ'] = 247;
		dictionary['ụ'] = 248;
		dictionary['ù'] = 249;
		dictionary['ú'] = 250;
		dictionary['ũ'] = 251;
		dictionary['ủ'] = 252;
		dictionary['ý'] = 253;
		dictionary['ợ'] = 254;
		dictionary['Ữ'] = byte.MaxValue;
		Class500.dictionary_0 = dictionary;
	}

	// Token: 0x040018DA RID: 6362
	public static readonly Dictionary<char, byte> dictionary_0;
}
