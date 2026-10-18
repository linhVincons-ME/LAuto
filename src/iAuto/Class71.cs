using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using System.Text;
using WebSocketSharp.Net;

// Token: 0x0200007F RID: 127
internal static class Class71
{
	// Token: 0x06000592 RID: 1426 RVA: 0x0002F374 File Offset: 0x0002D574
	private static int smethod_0(byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		int num2 = int_1 + int_0;
		for (int i = int_0; i < num2; i++)
		{
			int num3 = Class71.smethod_4(byte_0[i]);
			if (num3 == -1)
			{
				return -1;
			}
			num = (num << 4) + num3;
		}
		return num;
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0002F3AC File Offset: 0x0002D5AC
	private static int smethod_1(string string_0, int int_0, int int_1)
	{
		int num = 0;
		int num2 = int_1 + int_0;
		for (int i = int_0; i < num2; i++)
		{
			char c = string_0[i];
			if (c > '\u007f')
			{
				return -1;
			}
			int num3 = Class71.smethod_4((byte)c);
			if (num3 == -1)
			{
				return -1;
			}
			num = (num << 4) + num3;
		}
		return num;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00006D14 File Offset: 0x00004F14
	private static char[] smethod_2(MemoryStream memoryStream_0, Encoding encoding_0)
	{
		return encoding_0.GetChars(memoryStream_0.GetBuffer(), 0, (int)memoryStream_0.Length);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
	private static Dictionary<string, char> smethod_3()
	{
		object obj = Class71.object_0;
		Dictionary<string, char> dictionary;
		lock (obj)
		{
			if (Class71.dictionary_0 == null)
			{
				Class71.smethod_5();
			}
			dictionary = Class71.dictionary_0;
		}
		return dictionary;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0002F440 File Offset: 0x0002D640
	private static int smethod_4(byte byte_0)
	{
		if (byte_0 >= 48 && byte_0 <= 57)
		{
			return (int)(byte_0 - 48);
		}
		if (byte_0 >= 97 && byte_0 <= 102)
		{
			return (int)(byte_0 - 97 + 10);
		}
		if (byte_0 >= 65 && byte_0 <= 70)
		{
			return (int)(byte_0 - 65 + 10);
		}
		return -1;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0002F484 File Offset: 0x0002D684
	private static void smethod_5()
	{
		Class71.dictionary_0 = new Dictionary<string, char>();
		Class71.dictionary_0.Add("nbsp", '\u00a0');
		Class71.dictionary_0.Add("iexcl", '¡');
		Class71.dictionary_0.Add("cent", '¢');
		Class71.dictionary_0.Add("pound", '£');
		Class71.dictionary_0.Add("curren", '¤');
		Class71.dictionary_0.Add("yen", '¥');
		Class71.dictionary_0.Add("brvbar", '¦');
		Class71.dictionary_0.Add("sect", '§');
		Class71.dictionary_0.Add("uml", '\u00a8');
		Class71.dictionary_0.Add("copy", '©');
		Class71.dictionary_0.Add("ordf", 'ª');
		Class71.dictionary_0.Add("laquo", '«');
		Class71.dictionary_0.Add("not", '¬');
		Class71.dictionary_0.Add("shy", '\u00ad');
		Class71.dictionary_0.Add("reg", '®');
		Class71.dictionary_0.Add("macr", '\u00af');
		Class71.dictionary_0.Add("deg", '°');
		Class71.dictionary_0.Add("plusmn", '±');
		Class71.dictionary_0.Add("sup2", '²');
		Class71.dictionary_0.Add("sup3", '³');
		Class71.dictionary_0.Add("acute", '\u00b4');
		Class71.dictionary_0.Add("micro", 'µ');
		Class71.dictionary_0.Add("para", '¶');
		Class71.dictionary_0.Add("middot", '·');
		Class71.dictionary_0.Add("cedil", '\u00b8');
		Class71.dictionary_0.Add("sup1", '¹');
		Class71.dictionary_0.Add("ordm", 'º');
		Class71.dictionary_0.Add("raquo", '»');
		Class71.dictionary_0.Add("frac14", '¼');
		Class71.dictionary_0.Add("frac12", '½');
		Class71.dictionary_0.Add("frac34", '¾');
		Class71.dictionary_0.Add("iquest", '¿');
		Class71.dictionary_0.Add("Agrave", 'À');
		Class71.dictionary_0.Add("Aacute", 'Á');
		Class71.dictionary_0.Add("Acirc", 'Â');
		Class71.dictionary_0.Add("Atilde", 'Ã');
		Class71.dictionary_0.Add("Auml", 'Ä');
		Class71.dictionary_0.Add("Aring", 'Å');
		Class71.dictionary_0.Add("AElig", 'Æ');
		Class71.dictionary_0.Add("Ccedil", 'Ç');
		Class71.dictionary_0.Add("Egrave", 'È');
		Class71.dictionary_0.Add("Eacute", 'É');
		Class71.dictionary_0.Add("Ecirc", 'Ê');
		Class71.dictionary_0.Add("Euml", 'Ë');
		Class71.dictionary_0.Add("Igrave", 'Ì');
		Class71.dictionary_0.Add("Iacute", 'Í');
		Class71.dictionary_0.Add("Icirc", 'Î');
		Class71.dictionary_0.Add("Iuml", 'Ï');
		Class71.dictionary_0.Add("ETH", 'Ð');
		Class71.dictionary_0.Add("Ntilde", 'Ñ');
		Class71.dictionary_0.Add("Ograve", 'Ò');
		Class71.dictionary_0.Add("Oacute", 'Ó');
		Class71.dictionary_0.Add("Ocirc", 'Ô');
		Class71.dictionary_0.Add("Otilde", 'Õ');
		Class71.dictionary_0.Add("Ouml", 'Ö');
		Class71.dictionary_0.Add("times", '×');
		Class71.dictionary_0.Add("Oslash", 'Ø');
		Class71.dictionary_0.Add("Ugrave", 'Ù');
		Class71.dictionary_0.Add("Uacute", 'Ú');
		Class71.dictionary_0.Add("Ucirc", 'Û');
		Class71.dictionary_0.Add("Uuml", 'Ü');
		Class71.dictionary_0.Add("Yacute", 'Ý');
		Class71.dictionary_0.Add("THORN", 'Þ');
		Class71.dictionary_0.Add("szlig", 'ß');
		Class71.dictionary_0.Add("agrave", 'à');
		Class71.dictionary_0.Add("aacute", 'á');
		Class71.dictionary_0.Add("acirc", 'â');
		Class71.dictionary_0.Add("atilde", 'ã');
		Class71.dictionary_0.Add("auml", 'ä');
		Class71.dictionary_0.Add("aring", 'å');
		Class71.dictionary_0.Add("aelig", 'æ');
		Class71.dictionary_0.Add("ccedil", 'ç');
		Class71.dictionary_0.Add("egrave", 'è');
		Class71.dictionary_0.Add("eacute", 'é');
		Class71.dictionary_0.Add("ecirc", 'ê');
		Class71.dictionary_0.Add("euml", 'ë');
		Class71.dictionary_0.Add("igrave", 'ì');
		Class71.dictionary_0.Add("iacute", 'í');
		Class71.dictionary_0.Add("icirc", 'î');
		Class71.dictionary_0.Add("iuml", 'ï');
		Class71.dictionary_0.Add("eth", 'ð');
		Class71.dictionary_0.Add("ntilde", 'ñ');
		Class71.dictionary_0.Add("ograve", 'ò');
		Class71.dictionary_0.Add("oacute", 'ó');
		Class71.dictionary_0.Add("ocirc", 'ô');
		Class71.dictionary_0.Add("otilde", 'õ');
		Class71.dictionary_0.Add("ouml", 'ö');
		Class71.dictionary_0.Add("divide", '÷');
		Class71.dictionary_0.Add("oslash", 'ø');
		Class71.dictionary_0.Add("ugrave", 'ù');
		Class71.dictionary_0.Add("uacute", 'ú');
		Class71.dictionary_0.Add("ucirc", 'û');
		Class71.dictionary_0.Add("uuml", 'ü');
		Class71.dictionary_0.Add("yacute", 'ý');
		Class71.dictionary_0.Add("thorn", 'þ');
		Class71.dictionary_0.Add("yuml", 'ÿ');
		Class71.dictionary_0.Add("fnof", 'ƒ');
		Class71.dictionary_0.Add("Alpha", 'Α');
		Class71.dictionary_0.Add("Beta", 'Β');
		Class71.dictionary_0.Add("Gamma", 'Γ');
		Class71.dictionary_0.Add("Delta", 'Δ');
		Class71.dictionary_0.Add("Epsilon", 'Ε');
		Class71.dictionary_0.Add("Zeta", 'Ζ');
		Class71.dictionary_0.Add("Eta", 'Η');
		Class71.dictionary_0.Add("Theta", 'Θ');
		Class71.dictionary_0.Add("Iota", 'Ι');
		Class71.dictionary_0.Add("Kappa", 'Κ');
		Class71.dictionary_0.Add("Lambda", 'Λ');
		Class71.dictionary_0.Add("Mu", 'Μ');
		Class71.dictionary_0.Add("Nu", 'Ν');
		Class71.dictionary_0.Add("Xi", 'Ξ');
		Class71.dictionary_0.Add("Omicron", 'Ο');
		Class71.dictionary_0.Add("Pi", 'Π');
		Class71.dictionary_0.Add("Rho", 'Ρ');
		Class71.dictionary_0.Add("Sigma", 'Σ');
		Class71.dictionary_0.Add("Tau", 'Τ');
		Class71.dictionary_0.Add("Upsilon", 'Υ');
		Class71.dictionary_0.Add("Phi", 'Φ');
		Class71.dictionary_0.Add("Chi", 'Χ');
		Class71.dictionary_0.Add("Psi", 'Ψ');
		Class71.dictionary_0.Add("Omega", 'Ω');
		Class71.dictionary_0.Add("alpha", 'α');
		Class71.dictionary_0.Add("beta", 'β');
		Class71.dictionary_0.Add("gamma", 'γ');
		Class71.dictionary_0.Add("delta", 'δ');
		Class71.dictionary_0.Add("epsilon", 'ε');
		Class71.dictionary_0.Add("zeta", 'ζ');
		Class71.dictionary_0.Add("eta", 'η');
		Class71.dictionary_0.Add("theta", 'θ');
		Class71.dictionary_0.Add("iota", 'ι');
		Class71.dictionary_0.Add("kappa", 'κ');
		Class71.dictionary_0.Add("lambda", 'λ');
		Class71.dictionary_0.Add("mu", 'μ');
		Class71.dictionary_0.Add("nu", 'ν');
		Class71.dictionary_0.Add("xi", 'ξ');
		Class71.dictionary_0.Add("omicron", 'ο');
		Class71.dictionary_0.Add("pi", 'π');
		Class71.dictionary_0.Add("rho", 'ρ');
		Class71.dictionary_0.Add("sigmaf", 'ς');
		Class71.dictionary_0.Add("sigma", 'σ');
		Class71.dictionary_0.Add("tau", 'τ');
		Class71.dictionary_0.Add("upsilon", 'υ');
		Class71.dictionary_0.Add("phi", 'φ');
		Class71.dictionary_0.Add("chi", 'χ');
		Class71.dictionary_0.Add("psi", 'ψ');
		Class71.dictionary_0.Add("omega", 'ω');
		Class71.dictionary_0.Add("thetasym", 'ϑ');
		Class71.dictionary_0.Add("upsih", 'ϒ');
		Class71.dictionary_0.Add("piv", 'ϖ');
		Class71.dictionary_0.Add("bull", '•');
		Class71.dictionary_0.Add("hellip", '…');
		Class71.dictionary_0.Add("prime", '′');
		Class71.dictionary_0.Add("Prime", '″');
		Class71.dictionary_0.Add("oline", '‾');
		Class71.dictionary_0.Add("frasl", '⁄');
		Class71.dictionary_0.Add("weierp", '℘');
		Class71.dictionary_0.Add("image", 'ℑ');
		Class71.dictionary_0.Add("real", 'ℜ');
		Class71.dictionary_0.Add("trade", '™');
		Class71.dictionary_0.Add("alefsym", 'ℵ');
		Class71.dictionary_0.Add("larr", '←');
		Class71.dictionary_0.Add("uarr", '↑');
		Class71.dictionary_0.Add("rarr", '→');
		Class71.dictionary_0.Add("darr", '↓');
		Class71.dictionary_0.Add("harr", '↔');
		Class71.dictionary_0.Add("crarr", '↵');
		Class71.dictionary_0.Add("lArr", '⇐');
		Class71.dictionary_0.Add("uArr", '⇑');
		Class71.dictionary_0.Add("rArr", '⇒');
		Class71.dictionary_0.Add("dArr", '⇓');
		Class71.dictionary_0.Add("hArr", '⇔');
		Class71.dictionary_0.Add("forall", '∀');
		Class71.dictionary_0.Add("part", '∂');
		Class71.dictionary_0.Add("exist", '∃');
		Class71.dictionary_0.Add("empty", '∅');
		Class71.dictionary_0.Add("nabla", '∇');
		Class71.dictionary_0.Add("isin", '∈');
		Class71.dictionary_0.Add("notin", '∉');
		Class71.dictionary_0.Add("ni", '∋');
		Class71.dictionary_0.Add("prod", '∏');
		Class71.dictionary_0.Add("sum", '∑');
		Class71.dictionary_0.Add("minus", '−');
		Class71.dictionary_0.Add("lowast", '∗');
		Class71.dictionary_0.Add("radic", '√');
		Class71.dictionary_0.Add("prop", '∝');
		Class71.dictionary_0.Add("infin", '∞');
		Class71.dictionary_0.Add("ang", '∠');
		Class71.dictionary_0.Add("and", '∧');
		Class71.dictionary_0.Add("or", '∨');
		Class71.dictionary_0.Add("cap", '∩');
		Class71.dictionary_0.Add("cup", '∪');
		Class71.dictionary_0.Add("int", '∫');
		Class71.dictionary_0.Add("there4", '∴');
		Class71.dictionary_0.Add("sim", '∼');
		Class71.dictionary_0.Add("cong", '≅');
		Class71.dictionary_0.Add("asymp", '≈');
		Class71.dictionary_0.Add("ne", '≠');
		Class71.dictionary_0.Add("equiv", '≡');
		Class71.dictionary_0.Add("le", '≤');
		Class71.dictionary_0.Add("ge", '≥');
		Class71.dictionary_0.Add("sub", '⊂');
		Class71.dictionary_0.Add("sup", '⊃');
		Class71.dictionary_0.Add("nsub", '⊄');
		Class71.dictionary_0.Add("sube", '⊆');
		Class71.dictionary_0.Add("supe", '⊇');
		Class71.dictionary_0.Add("oplus", '⊕');
		Class71.dictionary_0.Add("otimes", '⊗');
		Class71.dictionary_0.Add("perp", '⊥');
		Class71.dictionary_0.Add("sdot", '⋅');
		Class71.dictionary_0.Add("lceil", '⌈');
		Class71.dictionary_0.Add("rceil", '⌉');
		Class71.dictionary_0.Add("lfloor", '⌊');
		Class71.dictionary_0.Add("rfloor", '⌋');
		Class71.dictionary_0.Add("lang", '〈');
		Class71.dictionary_0.Add("rang", '〉');
		Class71.dictionary_0.Add("loz", '◊');
		Class71.dictionary_0.Add("spades", '♠');
		Class71.dictionary_0.Add("clubs", '♣');
		Class71.dictionary_0.Add("hearts", '♥');
		Class71.dictionary_0.Add("diams", '♦');
		Class71.dictionary_0.Add("quot", '"');
		Class71.dictionary_0.Add("amp", '&');
		Class71.dictionary_0.Add("lt", '<');
		Class71.dictionary_0.Add("gt", '>');
		Class71.dictionary_0.Add("OElig", 'Œ');
		Class71.dictionary_0.Add("oelig", 'œ');
		Class71.dictionary_0.Add("Scaron", 'Š');
		Class71.dictionary_0.Add("scaron", 'š');
		Class71.dictionary_0.Add("Yuml", 'Ÿ');
		Class71.dictionary_0.Add("circ", 'ˆ');
		Class71.dictionary_0.Add("tilde", '\u02dc');
		Class71.dictionary_0.Add("ensp", '\u2002');
		Class71.dictionary_0.Add("emsp", '\u2003');
		Class71.dictionary_0.Add("thinsp", '\u2009');
		Class71.dictionary_0.Add("zwnj", '\u200c');
		Class71.dictionary_0.Add("zwj", '\u200d');
		Class71.dictionary_0.Add("lrm", '\u200e');
		Class71.dictionary_0.Add("rlm", '\u200f');
		Class71.dictionary_0.Add("ndash", '–');
		Class71.dictionary_0.Add("mdash", '—');
		Class71.dictionary_0.Add("lsquo", '‘');
		Class71.dictionary_0.Add("rsquo", '’');
		Class71.dictionary_0.Add("sbquo", '‚');
		Class71.dictionary_0.Add("ldquo", '“');
		Class71.dictionary_0.Add("rdquo", '”');
		Class71.dictionary_0.Add("bdquo", '„');
		Class71.dictionary_0.Add("dagger", '†');
		Class71.dictionary_0.Add("Dagger", '‡');
		Class71.dictionary_0.Add("permil", '‰');
		Class71.dictionary_0.Add("lsaquo", '‹');
		Class71.dictionary_0.Add("rsaquo", '›');
		Class71.dictionary_0.Add("euro", '€');
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00006D2A File Offset: 0x00004F2A
	private static bool smethod_6(byte byte_0)
	{
		return (byte_0 >= 65 && byte_0 <= 90) || (byte_0 >= 97 && byte_0 <= 122);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00006D2A File Offset: 0x00004F2A
	private static bool smethod_7(char char_1)
	{
		return (char_1 >= 'A' && char_1 <= 'Z') || (char_1 >= 'a' && char_1 <= 'z');
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00006D47 File Offset: 0x00004F47
	private static bool smethod_8(byte byte_0)
	{
		return byte_0 >= 48 && byte_0 <= 57;
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00006D47 File Offset: 0x00004F47
	private static bool smethod_9(char char_1)
	{
		return char_1 >= '0' && char_1 <= '9';
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00006D58 File Offset: 0x00004F58
	private static bool smethod_10(byte byte_0)
	{
		return byte_0 == 42 || byte_0 == 45 || byte_0 == 46 || byte_0 == 95;
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00006D58 File Offset: 0x00004F58
	private static bool smethod_11(char char_1)
	{
		return char_1 == '*' || char_1 == '-' || char_1 == '.' || char_1 == '_';
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00006D70 File Offset: 0x00004F70
	private static bool smethod_12(char char_1)
	{
		return char_1 == '!' || char_1 == '\'' || char_1 == '(' || char_1 == ')' || char_1 == '*' || char_1 == '-' || char_1 == '.' || char_1 == '_' || char_1 == '~';
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00006DA1 File Offset: 0x00004FA1
	private static bool smethod_13(char char_1)
	{
		return char_1 == '-' || char_1 == '.' || char_1 == '_' || char_1 == '~';
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00006DB9 File Offset: 0x00004FB9
	private static bool smethod_14(char char_1)
	{
		return char_1 == '!' || char_1 == '\'' || char_1 == '(' || char_1 == ')' || char_1 == '*' || char_1 == '-' || char_1 == '.' || char_1 == '_';
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00030840 File Offset: 0x0002EA40
	private static void smethod_15(byte byte_0, Stream stream_0)
	{
		if (byte_0 > 31 && byte_0 < 127)
		{
			if (byte_0 == 32)
			{
				stream_0.WriteByte(43);
				return;
			}
			if (Class71.smethod_8(byte_0))
			{
				stream_0.WriteByte(byte_0);
				return;
			}
			if (Class71.smethod_6(byte_0))
			{
				stream_0.WriteByte(byte_0);
				return;
			}
			if (Class71.smethod_10(byte_0))
			{
				stream_0.WriteByte(byte_0);
				return;
			}
		}
		stream_0.WriteByte(37);
		int num = byte_0 >> 4;
		stream_0.WriteByte((byte)Class71.char_0[num]);
		num = (int)(byte_0 & 15);
		stream_0.WriteByte((byte)Class71.char_0[num]);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x000308C4 File Offset: 0x0002EAC4
	private static void smethod_16(char char_1, Stream stream_0)
	{
		if (char_1 > '\u001f' && char_1 < '\u007f')
		{
			if (char_1 == ' ')
			{
				stream_0.WriteByte(43);
				return;
			}
			if (Class71.smethod_9(char_1))
			{
				stream_0.WriteByte((byte)char_1);
				return;
			}
			if (Class71.smethod_7(char_1))
			{
				stream_0.WriteByte((byte)char_1);
				return;
			}
			if (Class71.smethod_11(char_1))
			{
				stream_0.WriteByte((byte)char_1);
				return;
			}
		}
		stream_0.WriteByte(37);
		stream_0.WriteByte(117);
		int num = (int)(char_1 >> 12);
		stream_0.WriteByte((byte)Class71.char_0[num]);
		num = (int)((char_1 >> 8) & '\u000f');
		stream_0.WriteByte((byte)Class71.char_0[num]);
		num = (int)((char_1 >> 4) & '\u000f');
		stream_0.WriteByte((byte)Class71.char_0[num]);
		num = (int)(char_1 & '\u000f');
		stream_0.WriteByte((byte)Class71.char_0[num]);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0003097C File Offset: 0x0002EB7C
	private static void smethod_17(char char_1, Stream stream_0)
	{
		if (char_1 < '!' || char_1 > '~')
		{
			foreach (byte b in Encoding.UTF8.GetBytes(char_1.ToString()))
			{
				stream_0.WriteByte(37);
				int num = b >> 4;
				stream_0.WriteByte((byte)Class71.char_0[num]);
				num = (int)(b & 15);
				stream_0.WriteByte((byte)Class71.char_0[num]);
			}
			return;
		}
		if (char_1 == ' ')
		{
			stream_0.WriteByte(37);
			stream_0.WriteByte(50);
			stream_0.WriteByte(48);
			return;
		}
		stream_0.WriteByte((byte)char_1);
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00030A0C File Offset: 0x0002EC0C
	private static void smethod_18(char char_1, IList ilist_0, Encoding encoding_0)
	{
		if (char_1 > 'ÿ')
		{
			foreach (byte b in encoding_0.GetBytes(new char[] { char_1 }))
			{
				ilist_0.Add(b);
			}
			return;
		}
		ilist_0.Add((byte)char_1);
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00030A60 File Offset: 0x0002EC60
	internal static Uri smethod_19(string string_0, string string_1, bool bool_0, bool bool_1)
	{
		if (string_0 == null || string_0.Length == 0 || string_1 == null || string_1.Length == 0)
		{
			return null;
		}
		string text = null;
		string text2 = null;
		if (string_0.StartsWith("/"))
		{
			text2 = string_0;
		}
		else if (string_0.smethod_89())
		{
			Uri uri;
			if (!Uri.TryCreate(string_0, UriKind.Absolute, out uri) || ((!(text = uri.Scheme).StartsWith("http") || bool_0) && (!text.StartsWith("ws") || !bool_0)))
			{
				return null;
			}
			string_1 = uri.Authority;
			text2 = uri.PathAndQuery;
		}
		else if (!(string_0 == "*"))
		{
			string_1 = string_0;
		}
		if (text == null)
		{
			text = (bool_0 ? "ws" : "http") + (bool_1 ? "s" : string.Empty);
		}
		if (string_1.IndexOf(':') == -1)
		{
			string_1 = string.Format("{0}:{1}", string_1, (text == "http" || text == "ws") ? 80 : 443);
		}
		Uri uri2;
		if (!Uri.TryCreate(string.Format("{0}://{1}{2}", text, string_1, text2), UriKind.Absolute, out uri2))
		{
			return null;
		}
		return uri2;
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00030B8C File Offset: 0x0002ED8C
	internal static IPrincipal smethod_20(string string_0, AuthenticationSchemes authenticationSchemes_0, string string_1, string string_2, Func<IIdentity, GClass25> func_0)
	{
		if (string_0 == null || string_0.Length == 0)
		{
			return null;
		}
		if (func_0 == null)
		{
			return null;
		}
		if (authenticationSchemes_0 != AuthenticationSchemes.Basic && authenticationSchemes_0 != AuthenticationSchemes.Digest)
		{
			return null;
		}
		if (authenticationSchemes_0 == AuthenticationSchemes.Digest)
		{
			if (string_1 == null || string_1.Length == 0)
			{
				return null;
			}
			if (string_2 == null || string_2.Length == 0)
			{
				return null;
			}
		}
		if (!string_0.StartsWith(authenticationSchemes_0.ToString(), StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		Class53 @class = Class53.smethod_8(string_0);
		if (@class == null)
		{
			return null;
		}
		IIdentity identity = @class.method_1();
		if (identity == null)
		{
			return null;
		}
		GClass25 gclass = null;
		try
		{
			gclass = func_0(identity);
		}
		catch
		{
		}
		if (gclass == null)
		{
			return null;
		}
		if (authenticationSchemes_0 == AuthenticationSchemes.Basic && ((GClass17)identity).String_0 != gclass.String_1)
		{
			return null;
		}
		if (authenticationSchemes_0 == AuthenticationSchemes.Digest && !((GClass18)identity).method_0(gclass.String_1, string_1, string_2, null))
		{
			return null;
		}
		return new GenericPrincipal(identity, gclass.String_2);
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00030C78 File Offset: 0x0002EE78
	internal static Encoding smethod_21(string string_0)
	{
		string text = "charset=";
		StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
		foreach (string text2 in string_0.smethod_56(new char[] { ';' }))
		{
			string text3 = text2.Trim();
			if (text3.IndexOf(text, stringComparison) == 0)
			{
				string text4 = text3.smethod_34('=', true);
				if (text4 != null && text4.Length != 0)
				{
					return Encoding.GetEncoding(text4);
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00030D10 File Offset: 0x0002EF10
	internal static string smethod_22(byte[] byte_0, int int_0, int int_1, Encoding encoding_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (MemoryStream memoryStream = new MemoryStream())
		{
			int num = int_1 + int_0;
			int i = int_0;
			while (i < num)
			{
				if (byte_0[i] != 37 || i + 2 >= int_1 || byte_0[i + 1] == 37)
				{
					goto IL_00B0;
				}
				if (byte_0[i + 1] == 117 && i + 5 < num)
				{
					if (memoryStream.Length > 0L)
					{
						stringBuilder.Append(Class71.smethod_2(memoryStream, encoding_0));
						memoryStream.SetLength(0L);
					}
					int num2 = Class71.smethod_0(byte_0, i + 2, 4);
					if (num2 == -1)
					{
						goto IL_00B0;
					}
					stringBuilder.Append((char)num2);
					i += 5;
				}
				else
				{
					int num2;
					if ((num2 = Class71.smethod_0(byte_0, i + 1, 2)) == -1)
					{
						goto IL_00B0;
					}
					memoryStream.WriteByte((byte)num2);
					i += 2;
				}
				IL_00FA:
				i++;
				continue;
				IL_00B0:
				if (memoryStream.Length > 0L)
				{
					stringBuilder.Append(Class71.smethod_2(memoryStream, encoding_0));
					memoryStream.SetLength(0L);
				}
				if (byte_0[i] == 43)
				{
					stringBuilder.Append(' ');
					goto IL_00FA;
				}
				stringBuilder.Append((char)byte_0[i]);
				goto IL_00FA;
			}
			if (memoryStream.Length > 0L)
			{
				stringBuilder.Append(Class71.smethod_2(memoryStream, encoding_0));
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00030E70 File Offset: 0x0002F070
	internal static byte[] smethod_23(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			int num = int_0 + int_1;
			for (int i = int_0; i < num; i++)
			{
				char c = (char)byte_0[i];
				if (c == '+')
				{
					c = ' ';
				}
				else if (c == '%' && i < num - 2)
				{
					int num2 = Class71.smethod_0(byte_0, i + 1, 2);
					if (num2 != -1)
					{
						c = (char)num2;
						i += 2;
					}
				}
				memoryStream.WriteByte((byte)c);
			}
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00030EFC File Offset: 0x0002F0FC
	internal static byte[] smethod_24(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			int num = int_0 + int_1;
			for (int i = int_0; i < num; i++)
			{
				Class71.smethod_15(byte_0[i], memoryStream);
			}
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00030F54 File Offset: 0x0002F154
	internal static byte[] smethod_25(string string_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Class71.smethod_16(string_0[i], memoryStream);
			}
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00030FB4 File Offset: 0x0002F1B4
	internal static bool smethod_26(string string_0, out Encoding encoding_0)
	{
		encoding_0 = null;
		bool flag;
		try
		{
			encoding_0 = Class71.smethod_21(string_0);
			goto IL_0014;
		}
		catch
		{
			flag = false;
		}
		return flag;
		IL_0014:
		return encoding_0 != null;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00030FEC File Offset: 0x0002F1EC
	public static string smethod_27(string string_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_0)
			{
				stringBuilder.Append((c == '&') ? "&amp;" : ((c == '"') ? "&quot;" : ((c == '<') ? "&lt;" : ((c == '>') ? "&gt;" : c.ToString()))));
			}
			return stringBuilder.ToString();
		}
		return string_0;
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00006DE5 File Offset: 0x00004FE5
	public static void smethod_28(string string_0, TextWriter textWriter_0)
	{
		if (textWriter_0 == null)
		{
			throw new ArgumentNullException("output");
		}
		textWriter_0.Write(Class71.smethod_27(string_0));
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0003106C File Offset: 0x0002F26C
	public static string smethod_29(string string_0)
	{
		if (string_0 != null && string_0.Length != 0 && string_0.smethod_15(new char[] { '&' }))
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			int num = 0;
			int num2 = 0;
			bool flag = false;
			foreach (char c in string_0)
			{
				if (num == 0)
				{
					if (c == '&')
					{
						stringBuilder.Append(c);
						num = 1;
					}
					else
					{
						stringBuilder2.Append(c);
					}
				}
				else if (c == '&')
				{
					num = 1;
					if (flag)
					{
						stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
						flag = false;
					}
					stringBuilder2.Append(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append('&');
				}
				else if (num == 1)
				{
					if (c == ';')
					{
						num = 0;
						stringBuilder2.Append(stringBuilder.ToString());
						stringBuilder2.Append(c);
						stringBuilder.Length = 0;
					}
					else
					{
						num2 = 0;
						if (c != '#')
						{
							num = 2;
						}
						else
						{
							num = 3;
						}
						stringBuilder.Append(c);
					}
				}
				else if (num == 2)
				{
					stringBuilder.Append(c);
					if (c == ';')
					{
						string text = stringBuilder.ToString();
						Dictionary<string, char> dictionary = Class71.smethod_3();
						if (text.Length > 1 && dictionary.ContainsKey(text.Substring(1, text.Length - 2)))
						{
							text = dictionary[text.Substring(1, text.Length - 2)].ToString();
						}
						stringBuilder2.Append(text);
						num = 0;
						stringBuilder.Length = 0;
					}
				}
				else if (num == 3)
				{
					if (c == ';')
					{
						if (num2 > 65535)
						{
							stringBuilder2.Append("&#");
							stringBuilder2.Append(num2.ToString(CultureInfo.InvariantCulture));
							stringBuilder2.Append(";");
						}
						else
						{
							stringBuilder2.Append((char)num2);
						}
						num = 0;
						stringBuilder.Length = 0;
						flag = false;
					}
					else if (char.IsDigit(c))
					{
						num2 = num2 * 10 + (int)(c - '0');
						flag = true;
					}
					else
					{
						num = 2;
						if (flag)
						{
							stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
							flag = false;
						}
						stringBuilder.Append(c);
					}
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder2.Append(stringBuilder.ToString());
			}
			else if (flag)
			{
				stringBuilder2.Append(num2.ToString(CultureInfo.InvariantCulture));
			}
			return stringBuilder2.ToString();
		}
		return string_0;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00006E01 File Offset: 0x00005001
	public static void smethod_30(string string_0, TextWriter textWriter_0)
	{
		if (textWriter_0 == null)
		{
			throw new ArgumentNullException("output");
		}
		textWriter_0.Write(Class71.smethod_29(string_0));
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x000312E4 File Offset: 0x0002F4E4
	public static string smethod_31(string string_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_0)
			{
				if (c == '&')
				{
					stringBuilder.Append("&amp;");
				}
				else if (c == '"')
				{
					stringBuilder.Append("&quot;");
				}
				else if (c == '<')
				{
					stringBuilder.Append("&lt;");
				}
				else if (c == '>')
				{
					stringBuilder.Append("&gt;");
				}
				else if (c > '\u009f')
				{
					stringBuilder.AppendFormat("&#{0};", (int)c);
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}
		return string_0;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00006E1D File Offset: 0x0000501D
	public static void smethod_32(string string_0, TextWriter textWriter_0)
	{
		if (textWriter_0 == null)
		{
			throw new ArgumentNullException("output");
		}
		textWriter_0.Write(Class71.smethod_31(string_0));
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00006E39 File Offset: 0x00005039
	public static string smethod_33(string string_0)
	{
		return Class71.smethod_34(string_0, Encoding.UTF8);
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x000313A0 File Offset: 0x0002F5A0
	public static string smethod_34(string string_0, Encoding encoding_0)
	{
		if (string_0 != null && string_0.Length != 0 && string_0.smethod_15(new char[] { '%', '+' }))
		{
			if (encoding_0 == null)
			{
				encoding_0 = Encoding.UTF8;
			}
			List<byte> list = new List<byte>();
			int length = string_0.Length;
			for (int i = 0; i < length; i++)
			{
				char c = string_0[i];
				if (c == '%' && i + 2 < length && string_0[i + 1] != '%')
				{
					int num;
					if (string_0[i + 1] == 'u' && i + 5 < length)
					{
						num = Class71.smethod_1(string_0, i + 2, 4);
						if (num != -1)
						{
							Class71.smethod_18((char)num, list, encoding_0);
							i += 5;
						}
						else
						{
							Class71.smethod_18('%', list, encoding_0);
						}
					}
					else if ((num = Class71.smethod_1(string_0, i + 1, 2)) != -1)
					{
						Class71.smethod_18((char)num, list, encoding_0);
						i += 2;
					}
					else
					{
						Class71.smethod_18('%', list, encoding_0);
					}
				}
				else if (c == '+')
				{
					Class71.smethod_18(' ', list, encoding_0);
				}
				else
				{
					Class71.smethod_18(c, list, encoding_0);
				}
			}
			return encoding_0.GetString(list.ToArray());
		}
		return string_0;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x000314B4 File Offset: 0x0002F6B4
	public static string smethod_35(byte[] byte_0, Encoding encoding_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		int num;
		if ((num = byte_0.Length) != 0)
		{
			return Class71.smethod_22(byte_0, 0, num, encoding_0 ?? Encoding.UTF8);
		}
		return string.Empty;
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x000314E8 File Offset: 0x0002F6E8
	public static string smethod_36(byte[] byte_0, int int_0, int int_1, Encoding encoding_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		int num = byte_0.Length;
		if (num == 0 || int_1 == 0)
		{
			return string.Empty;
		}
		if (int_0 < 0 || int_0 >= num)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (int_1 >= 0 && int_1 <= num - int_0)
		{
			return Class71.smethod_22(byte_0, int_0, int_1, encoding_0 ?? Encoding.UTF8);
		}
		throw new ArgumentOutOfRangeException("count");
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00031544 File Offset: 0x0002F744
	public static byte[] smethod_37(byte[] byte_0)
	{
		int num;
		if (byte_0 != null && (num = byte_0.Length) > 0)
		{
			return Class71.smethod_23(byte_0, 0, num);
		}
		return byte_0;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00006E46 File Offset: 0x00005046
	public static byte[] smethod_38(string string_0)
	{
		return Class71.smethod_39(string_0, Encoding.UTF8);
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00031568 File Offset: 0x0002F768
	public static byte[] smethod_39(string string_0, Encoding encoding_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length == 0)
		{
			return new byte[0];
		}
		byte[] bytes = (encoding_0 ?? Encoding.UTF8).GetBytes(string_0);
		return Class71.smethod_23(bytes, 0, bytes.Length);
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x000315A4 File Offset: 0x0002F7A4
	public static byte[] smethod_40(byte[] byte_0, int int_0, int int_1)
	{
		int num;
		if (byte_0 == null || (num = byte_0.Length) == 0)
		{
			return byte_0;
		}
		if (int_1 == 0)
		{
			return new byte[0];
		}
		if (int_0 < 0 || int_0 >= num)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (int_1 >= 0 && int_1 <= num - int_0)
		{
			return Class71.smethod_23(byte_0, int_0, int_1);
		}
		throw new ArgumentOutOfRangeException("count");
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x000315F8 File Offset: 0x0002F7F8
	public static string smethod_41(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		int num = byte_0.Length;
		if (num <= 0)
		{
			return string.Empty;
		}
		return Encoding.ASCII.GetString(Class71.smethod_24(byte_0, 0, num));
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0003162C File Offset: 0x0002F82C
	public static string smethod_42(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			if (int_1 != 0)
			{
				throw new ArgumentNullException("bytes");
			}
			return null;
		}
		else
		{
			int num = byte_0.Length;
			if (num == 0)
			{
				if (int_0 == 0 && int_1 == 0)
				{
					return string.Empty;
				}
				throw new ArgumentException("An empty byte array.", "bytes");
			}
			else
			{
				if (int_0 < 0 || int_0 >= num)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (int_1 < 0 || int_1 > num - int_0)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (int_1 <= 0)
				{
					return string.Empty;
				}
				return Encoding.ASCII.GetString(Class71.smethod_24(byte_0, int_0, int_1));
			}
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00006E53 File Offset: 0x00005053
	public static string smethod_43(string string_0)
	{
		return Class71.smethod_44(string_0, Encoding.UTF8);
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x000316B4 File Offset: 0x0002F8B4
	public static string smethod_44(string string_0, Encoding encoding_0)
	{
		if (string_0 == null)
		{
			return string_0;
		}
		int length = string_0.Length;
		if (length == 0)
		{
			return string_0;
		}
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.UTF8;
		}
		byte[] array = new byte[encoding_0.GetMaxByteCount(length)];
		int bytes = encoding_0.GetBytes(string_0, 0, length, array, 0);
		return Encoding.ASCII.GetString(Class71.smethod_24(array, 0, bytes));
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00031708 File Offset: 0x0002F908
	public static byte[] smethod_45(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		int num = byte_0.Length;
		if (num <= 0)
		{
			return byte_0;
		}
		return Class71.smethod_24(byte_0, 0, num);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0003172C File Offset: 0x0002F92C
	public static byte[] smethod_46(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			if (int_1 != 0)
			{
				throw new ArgumentNullException("bytes");
			}
			return null;
		}
		else
		{
			int num = byte_0.Length;
			if (num == 0)
			{
				if (int_0 == 0 && int_1 == 0)
				{
					return byte_0;
				}
				throw new ArgumentException("An empty byte array.", "bytes");
			}
			else
			{
				if (int_0 < 0 || int_0 >= num)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (int_1 < 0 || int_1 > num - int_0)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (int_1 <= 0)
				{
					return new byte[0];
				}
				return Class71.smethod_24(byte_0, int_0, int_1);
			}
		}
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00006E60 File Offset: 0x00005060
	public static byte[] smethod_47(string string_0)
	{
		return Class71.smethod_48(string_0, Encoding.UTF8);
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x000317A8 File Offset: 0x0002F9A8
	public static byte[] smethod_48(string string_0, Encoding encoding_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length == 0)
		{
			return new byte[0];
		}
		byte[] bytes = (encoding_0 ?? Encoding.UTF8).GetBytes(string_0);
		return Class71.smethod_24(bytes, 0, bytes.Length);
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00006E6D File Offset: 0x0000506D
	public static string smethod_49(string string_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			return Encoding.ASCII.GetString(Class71.smethod_25(string_0));
		}
		return string_0;
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00006E8C File Offset: 0x0000508C
	public static byte[] smethod_50(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length != 0)
		{
			return Class71.smethod_25(string_0);
		}
		return new byte[0];
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x000317E4 File Offset: 0x0002F9E4
	public static string smethod_51(string string_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			string text;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				text = string_0;
				for (int i = 0; i < text.Length; i++)
				{
					Class71.smethod_17(text[i], memoryStream);
				}
				memoryStream.Close();
				text = Encoding.ASCII.GetString(memoryStream.ToArray());
			}
			return text;
		}
		return string_0;
	}

	// Token: 0x04000326 RID: 806
	private static Dictionary<string, char> dictionary_0;

	// Token: 0x04000327 RID: 807
	private static char[] char_0 = "0123456789abcdef".ToCharArray();

	// Token: 0x04000328 RID: 808
	private static object object_0 = new object();
}
