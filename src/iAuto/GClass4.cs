using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using WebSocketSharp;

// Token: 0x02000014 RID: 20
public static class GClass4
{
	// Token: 0x0600008C RID: 140 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
	private static byte[] smethod_0(this byte[] byte_1)
	{
		if ((long)byte_1.Length == 0L)
		{
			return byte_1;
		}
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream(byte_1))
		{
			array = memoryStream.smethod_2();
		}
		return array;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
	private static MemoryStream smethod_1(this Stream stream_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		if (stream_0.Length == 0L)
		{
			return memoryStream;
		}
		stream_0.Position = 0L;
		MemoryStream memoryStream2;
		using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true))
		{
			stream_0.CopyTo(deflateStream, 1024);
			deflateStream.Close();
			memoryStream.Write(GClass4.byte_0, 0, 1);
			memoryStream.Position = 0L;
			memoryStream2 = memoryStream;
		}
		return memoryStream2;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0001E67C File Offset: 0x0001C87C
	private static byte[] smethod_2(this Stream stream_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = stream_0.smethod_1())
		{
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0001E6BC File Offset: 0x0001C8BC
	private static byte[] smethod_3(this byte[] byte_1)
	{
		if ((long)byte_1.Length == 0L)
		{
			return byte_1;
		}
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream(byte_1))
		{
			array = memoryStream.smethod_5();
		}
		return array;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0001E6FC File Offset: 0x0001C8FC
	private static MemoryStream smethod_4(this Stream stream_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		if (stream_0.Length == 0L)
		{
			return memoryStream;
		}
		stream_0.Position = 0L;
		MemoryStream memoryStream2;
		using (DeflateStream deflateStream = new DeflateStream(stream_0, CompressionMode.Decompress, true))
		{
			deflateStream.CopyTo(memoryStream, 1024);
			memoryStream.Position = 0L;
			memoryStream2 = memoryStream;
		}
		return memoryStream2;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0001E76C File Offset: 0x0001C96C
	private static byte[] smethod_5(this Stream stream_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = stream_0.smethod_4())
		{
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0001E7AC File Offset: 0x0001C9AC
	private static bool smethod_6(this string string_1)
	{
		return string_1 == "GET" || string_1 == "HEAD" || string_1 == "POST" || string_1 == "PUT" || string_1 == "DELETE" || string_1 == "CONNECT" || string_1 == "OPTIONS" || string_1 == "TRACE";
	}

	// Token: 0x06000093 RID: 147 RVA: 0x0000376B File Offset: 0x0000196B
	private static bool smethod_7(this string string_1)
	{
		return string_1 == "GET" || string_1 == "HEAD" || string_1 == "POST";
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0001E824 File Offset: 0x0001CA24
	private static void smethod_8(this ulong ulong_0, Action action_0)
	{
		for (ulong num = 0UL; num < ulong_0; num += 1UL)
		{
			action_0();
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0001E854 File Offset: 0x0001CA54
	internal static byte[] smethod_9(this ushort ushort_0, string string_1)
	{
		byte[] array = ushort_0.smethod_35(GEnum1.Big);
		if (string_1 != null && string_1.Length > 0)
		{
			List<byte> list = new List<byte>(array);
			list.AddRange(Encoding.UTF8.GetBytes(string_1));
			array = list.ToArray();
		}
		return array;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00003794 File Offset: 0x00001994
	internal static void smethod_10(this GClass23 gclass23_0, GEnum5 genum5_0)
	{
		gclass23_0.Int32_0 = (int)genum5_0;
		gclass23_0.Stream_0.Close();
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000037A8 File Offset: 0x000019A8
	internal static void smethod_11(this GClass23 gclass23_0, string string_1)
	{
		gclass23_0.GClass27_0.method_12("WWW-Authenticate", string_1, true);
		gclass23_0.smethod_10(GEnum5.Unauthorized);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000037C7 File Offset: 0x000019C7
	internal static byte[] smethod_12(this byte[] byte_1, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return byte_1;
		}
		return byte_1.smethod_0();
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000037D5 File Offset: 0x000019D5
	internal static Stream smethod_13(this Stream stream_0, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return stream_0;
		}
		return stream_0.smethod_1();
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000037E3 File Offset: 0x000019E3
	internal static byte[] smethod_14(this Stream stream_0, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return stream_0.smethod_57();
		}
		return stream_0.smethod_2();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000037F6 File Offset: 0x000019F6
	internal static bool smethod_15(this string string_1, params char[] char_0)
	{
		return char_0 != null && char_0.Length != 0 && string_1.IndexOfAny(char_0) > -1;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000380B File Offset: 0x00001A0B
	internal static bool smethod_16(this NameValueCollection nameValueCollection_0, string string_1)
	{
		return nameValueCollection_0[string_1] != null;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0001E894 File Offset: 0x0001CA94
	internal static bool smethod_17(this NameValueCollection nameValueCollection_0, string string_1, string string_2, StringComparison stringComparison_0)
	{
		string text = nameValueCollection_0[string_1];
		if (text == null)
		{
			return false;
		}
		string[] array = text.Split(new char[] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Trim().Equals(string_2, stringComparison_0))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
	internal static bool smethod_18<T>(this IEnumerable<T> ienumerable_0, Func<T, bool> func_0)
	{
		foreach (T t in ienumerable_0)
		{
			if (func_0(t))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0001E938 File Offset: 0x0001CB38
	internal static bool smethod_19(this string[] string_1)
	{
		GClass4.Class3 @class = new GClass4.Class3();
		@class.string_0 = string_1;
		@class.int_1 = @class.string_0.Length;
		@class.int_1--;
		@class.func_0 = null;
		@class.func_0 = new Func<int, bool>(@class.method_0);
		return @class.func_0(0);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0001E994 File Offset: 0x0001CB94
	internal static T[] smethod_20<T>(this T[] gparam_0, int int_1)
	{
		T[] array = new T[int_1];
		Array.Copy(gparam_0, 0, array, 0, int_1);
		return array;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
	internal static T[] smethod_21<T>(this T[] gparam_0, long long_0)
	{
		T[] array = new T[long_0];
		Array.Copy(gparam_0, 0L, array, 0L, long_0);
		return array;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
	internal static void smethod_22(this Stream stream_0, Stream stream_1, int int_1)
	{
		byte[] array = new byte[int_1];
		int num;
		while ((num = stream_0.Read(array, 0, int_1)) > 0)
		{
			stream_1.Write(array, 0, num);
		}
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0001EA14 File Offset: 0x0001CC14
	internal static void smethod_23(this Stream stream_0, Stream stream_1, int int_1, Action action_0, Action<Exception> action_1)
	{
		GClass4.Class4 @class = new GClass4.Class4();
		@class.stream_0 = stream_0;
		@class.action_0 = action_0;
		@class.stream_1 = stream_1;
		@class.int_0 = int_1;
		@class.action_1 = action_1;
		@class.byte_0 = new byte[@class.int_0];
		@class.asyncCallback_0 = null;
		@class.asyncCallback_0 = new AsyncCallback(@class.method_0);
		try
		{
			@class.stream_0.BeginRead(@class.byte_0, 0, @class.int_0, @class.asyncCallback_0, null);
		}
		catch (Exception ex)
		{
			if (@class.action_1 != null)
			{
				@class.action_1(ex);
			}
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00003817 File Offset: 0x00001A17
	internal static byte[] smethod_24(this byte[] byte_1, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return byte_1;
		}
		return byte_1.smethod_3();
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00003825 File Offset: 0x00001A25
	internal static Stream smethod_25(this Stream stream_0, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return stream_0;
		}
		return stream_0.smethod_4();
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00003833 File Offset: 0x00001A33
	internal static byte[] smethod_26(this Stream stream_0, CompressionMethod compressionMethod_0)
	{
		if (compressionMethod_0 != CompressionMethod.Deflate)
		{
			return stream_0.smethod_57();
		}
		return stream_0.smethod_5();
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00003846 File Offset: 0x00001A46
	internal static bool smethod_27(this int int_1, char char_0, Action<int> action_0)
	{
		action_0(int_1);
		return int_1 == (int)char_0;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
	internal static string smethod_28(this Uri uri_0)
	{
		if (uri_0.IsAbsoluteUri)
		{
			return uri_0.AbsolutePath;
		}
		string originalString = uri_0.OriginalString;
		if (originalString[0] != '/')
		{
			return null;
		}
		int num = originalString.IndexOfAny(new char[] { '?', '#' });
		if (num <= 0)
		{
			return originalString;
		}
		return originalString.Substring(0, num);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0001EB18 File Offset: 0x0001CD18
	internal static GClass16 smethod_29(this NameValueCollection nameValueCollection_0, bool bool_0)
	{
		string text = nameValueCollection_0[bool_0 ? "Set-Cookie" : "Cookie"];
		if (text == null)
		{
			return new GClass16();
		}
		return GClass16.smethod_5(text, bool_0);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00003853 File Offset: 0x00001A53
	internal static string smethod_30(this Uri uri_0, bool bool_0)
	{
		if (bool_0)
		{
			if (uri_0.HostNameType == UriHostNameType.IPv6)
			{
				return uri_0.Host;
			}
		}
		return uri_0.DnsSafeHost;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0001EB4C File Offset: 0x0001CD4C
	internal static string smethod_31(this GEnum2 genum2_0)
	{
		if (genum2_0 == GEnum2.ProtocolError)
		{
			return "A WebSocket protocol error has occurred.";
		}
		if (genum2_0 == GEnum2.UnsupportedData)
		{
			return "Unsupported data has been received.";
		}
		if (genum2_0 == GEnum2.Abnormal)
		{
			return "An exception has occurred.";
		}
		if (genum2_0 == GEnum2.InvalidData)
		{
			return "Invalid data has been received.";
		}
		if (genum2_0 == GEnum2.PolicyViolation)
		{
			return "A policy violation has occurred.";
		}
		if (genum2_0 == GEnum2.TooBig)
		{
			return "A too big message has been received.";
		}
		if (genum2_0 == GEnum2.MandatoryExtension)
		{
			return "WebSocket client didn't receive expected extension(s).";
		}
		if (genum2_0 == GEnum2.ServerError)
		{
			return "WebSocket server got an internal error.";
		}
		if (genum2_0 != GEnum2.TlsHandshakeFailure)
		{
			return string.Empty;
		}
		return "An error has occurred during a TLS handshake.";
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0001EBDC File Offset: 0x0001CDDC
	internal static string smethod_32(this string string_1, char char_0)
	{
		int num = string_1.IndexOf(char_0);
		if (num <= 0)
		{
			return null;
		}
		return string_1.Substring(0, num).Trim();
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00003870 File Offset: 0x00001A70
	internal static string smethod_33(this string string_1, char char_0)
	{
		return string_1.smethod_34(char_0, false);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0001EC04 File Offset: 0x0001CE04
	internal static string smethod_34(this string string_1, char char_0, bool bool_0)
	{
		int num = string_1.IndexOf(char_0);
		if (num >= 0)
		{
			if (num != string_1.Length - 1)
			{
				string text = string_1.Substring(num + 1).Trim();
				if (!bool_0)
				{
					return text;
				}
				return text.smethod_73();
			}
		}
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0001EC48 File Offset: 0x0001CE48
	internal static byte[] smethod_35(this ushort ushort_0, GEnum1 genum1_0)
	{
		byte[] bytes = BitConverter.GetBytes(ushort_0);
		if (!genum1_0.smethod_85())
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0001EC6C File Offset: 0x0001CE6C
	internal static byte[] smethod_36(this ulong ulong_0, GEnum1 genum1_0)
	{
		byte[] bytes = BitConverter.GetBytes(ulong_0);
		if (!genum1_0.smethod_85())
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000387A File Offset: 0x00001A7A
	internal static bool smethod_37(this string string_1, CompressionMethod compressionMethod_0)
	{
		return string_1.StartsWith(compressionMethod_0.smethod_59(Array.Empty<string>()));
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000388D File Offset: 0x00001A8D
	internal static bool smethod_38(this byte byte_1)
	{
		return byte_1 > 7 && byte_1 < 16;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000389A File Offset: 0x00001A9A
	internal static bool smethod_39(this Enum2 enum2_0)
	{
		return enum2_0 >= Enum2.Close;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x000038A3 File Offset: 0x00001AA3
	internal static bool smethod_40(this byte byte_1)
	{
		return byte_1 == 1 || byte_1 == 2;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000038A3 File Offset: 0x00001AA3
	internal static bool smethod_41(this Enum2 enum2_0)
	{
		return enum2_0 == Enum2.Text || enum2_0 == Enum2.Binary;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000038AF File Offset: 0x00001AAF
	internal static bool smethod_42(this string string_1, Version version_0)
	{
		if (!(version_0 == GClass24.version_0))
		{
			return GClass4.smethod_6(string_1);
		}
		return string_1.smethod_7();
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000038CB File Offset: 0x00001ACB
	internal static bool smethod_43(this int int_1)
	{
		return int_1 > 0 && int_1 < 65536;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000038DB File Offset: 0x00001ADB
	internal static bool smethod_44(this ushort ushort_0)
	{
		return ushort_0 == 1004 || ushort_0 == 1005 || ushort_0 == 1006 || ushort_0 == 1015;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000038DB File Offset: 0x00001ADB
	internal static bool smethod_45(this GEnum2 genum2_0)
	{
		return genum2_0 == GEnum2.Undefined || genum2_0 == GEnum2.NoStatus || genum2_0 == GEnum2.Abnormal || genum2_0 == GEnum2.TlsHandshakeFailure;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000038FF File Offset: 0x00001AFF
	internal static bool smethod_46(this byte byte_1)
	{
		return Enum.IsDefined(typeof(Enum2), byte_1);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0001EC90 File Offset: 0x0001CE90
	internal static bool smethod_47(this string string_1)
	{
		int length = string_1.Length;
		for (int i = 0; i < length; i++)
		{
			char c = string_1[i];
			if (c < ' ')
			{
				if ("\r\n\t".IndexOf(c) == -1)
				{
					return false;
				}
				if (c == '\n')
				{
					i++;
					if (i == length)
					{
						return true;
					}
					c = string_1[i];
					if (" \t".IndexOf(c) == -1)
					{
						return false;
					}
				}
			}
			else if (c == '\u007f')
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0001ED04 File Offset: 0x0001CF04
	internal static bool smethod_48(this string string_1)
	{
		foreach (char c in string_1)
		{
			if (c < ' ')
			{
				return false;
			}
			if (c >= '\u007f')
			{
				return false;
			}
			if ("()<>@,;:\\\"/[]?={} \t".IndexOf(c) > -1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0001ED4C File Offset: 0x0001CF4C
	internal static bool smethod_49(this NameValueCollection nameValueCollection_0, Version version_0)
	{
		StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
		if (!(version_0 < GClass24.version_1))
		{
			return !nameValueCollection_0.smethod_17("Connection", "close", stringComparison);
		}
		return nameValueCollection_0.smethod_17("Connection", "keep-alive", stringComparison);
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00003916 File Offset: 0x00001B16
	internal static string smethod_50(this string string_1)
	{
		return string.Format("\"{0}\"", string_1.Replace("\"", "\\\""));
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0001ED90 File Offset: 0x0001CF90
	internal static byte[] smethod_51(this Stream stream_0, int int_1)
	{
		byte[] array = new byte[int_1];
		int num = 0;
		try
		{
			while (int_1 > 0)
			{
				int num2 = stream_0.Read(array, num, int_1);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				int_1 -= num2;
			}
		}
		catch
		{
		}
		return array.smethod_90<byte>(0, num);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
	internal static byte[] smethod_52(this Stream stream_0, long long_0, int int_1)
	{
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			try
			{
				byte[] array = new byte[int_1];
				while (long_0 > 0L)
				{
					if (long_0 < (long)int_1)
					{
						int_1 = (int)long_0;
					}
					int num = stream_0.Read(array, 0, int_1);
					if (num == 0)
					{
						break;
					}
					memoryStream.Write(array, 0, num);
					long_0 -= (long)num;
				}
			}
			catch
			{
			}
			memoryStream.Close();
			array2 = memoryStream.ToArray();
		}
		return array2;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0001EE70 File Offset: 0x0001D070
	internal static void smethod_53(this Stream stream_0, int int_1, Action<byte[]> action_0, Action<Exception> action_1)
	{
		GClass4.Class5 @class = new GClass4.Class5();
		@class.stream_0 = stream_0;
		@class.int_2 = int_1;
		@class.action_0 = action_0;
		@class.action_1 = action_1;
		@class.byte_0 = new byte[@class.int_2];
		@class.int_1 = 0;
		@class.int_0 = 0;
		@class.asyncCallback_0 = null;
		@class.asyncCallback_0 = new AsyncCallback(@class.method_0);
		try
		{
			@class.stream_0.BeginRead(@class.byte_0, @class.int_1, @class.int_2, @class.asyncCallback_0, null);
		}
		catch (Exception ex)
		{
			if (@class.action_1 != null)
			{
				@class.action_1(ex);
			}
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0001EF28 File Offset: 0x0001D128
	internal static void smethod_54(this Stream stream_0, long long_0, int int_1, Action<byte[]> action_0, Action<Exception> action_1)
	{
		GClass4.Class6 @class = new GClass4.Class6();
		@class.int_0 = int_1;
		@class.stream_0 = stream_0;
		@class.action_1 = action_0;
		@class.action_2 = action_1;
		@class.memoryStream_0 = new MemoryStream();
		@class.byte_0 = new byte[@class.int_0];
		@class.int_1 = 0;
		@class.action_0 = null;
		@class.action_0 = new Action<long>(@class.method_0);
		try
		{
			@class.action_0(long_0);
		}
		catch (Exception ex)
		{
			@class.memoryStream_0.Dispose();
			if (@class.action_2 != null)
			{
				@class.action_2(ex);
			}
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
	internal static T[] smethod_55<T>(this T[] gparam_0)
	{
		int num = gparam_0.Length;
		T[] array = new T[num];
		int num2 = num - 1;
		for (int i = 0; i <= num2; i++)
		{
			array[i] = gparam_0[num2 - i];
		}
		return array;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00003932 File Offset: 0x00001B32
	internal static IEnumerable<string> smethod_56(this string string_1, params char[] char_0)
	{
		GClass4.Class9 @class = new GClass4.Class9(-2);
		@class.string_2 = string_1;
		@class.char_1 = char_0;
		return @class;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0001F00C File Offset: 0x0001D20C
	internal static byte[] smethod_57(this Stream stream_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			stream_0.Position = 0L;
			stream_0.CopyTo(memoryStream, 1024);
			memoryStream.Close();
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0001F064 File Offset: 0x0001D264
	internal static CompressionMethod smethod_58(this string string_1)
	{
		foreach (object obj in Enum.GetValues(typeof(CompressionMethod)))
		{
			CompressionMethod compressionMethod = (CompressionMethod)obj;
			if (compressionMethod.smethod_59(Array.Empty<string>()) == string_1)
			{
				return compressionMethod;
			}
		}
		return CompressionMethod.None;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0001F0DC File Offset: 0x0001D2DC
	internal static string smethod_59(this CompressionMethod compressionMethod_0, params string[] string_1)
	{
		if (compressionMethod_0 == CompressionMethod.None)
		{
			return string.Empty;
		}
		string text = string.Format("permessage-{0}", compressionMethod_0.ToString().ToLower());
		if (string_1 != null && string_1.Length != 0)
		{
			return string.Format("{0}; {1}", text, string_1.smethod_103<string>("; "));
		}
		return text;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0001F130 File Offset: 0x0001D330
	internal static IPAddress smethod_60(this string string_1)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			return null;
		}
		IPAddress ipaddress;
		if (IPAddress.TryParse(string_1, out ipaddress))
		{
			return ipaddress;
		}
		IPAddress ipaddress2;
		try
		{
			ipaddress2 = Dns.GetHostAddresses(string_1)[0];
		}
		catch
		{
			ipaddress2 = null;
		}
		return ipaddress2;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00003949 File Offset: 0x00001B49
	internal static List<T> smethod_61<T>(this IEnumerable<T> ienumerable_0)
	{
		return new List<T>(ienumerable_0);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00003951 File Offset: 0x00001B51
	internal static string smethod_62(this IPAddress ipaddress_0, bool bool_0)
	{
		if (bool_0)
		{
			if (ipaddress_0.AddressFamily == AddressFamily.InterNetworkV6)
			{
				return string.Format("[{0}]", ipaddress_0.ToString());
			}
		}
		return ipaddress_0.ToString();
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00003979 File Offset: 0x00001B79
	internal static ushort smethod_63(this byte[] byte_1, GEnum1 genum1_0)
	{
		return BitConverter.ToUInt16(byte_1.smethod_102(genum1_0), 0);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00003988 File Offset: 0x00001B88
	internal static ulong smethod_64(this byte[] byte_1, GEnum1 genum1_0)
	{
		return BitConverter.ToUInt64(byte_1.smethod_102(genum1_0), 0);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00003997 File Offset: 0x00001B97
	internal static IEnumerable<string> smethod_65(this IEnumerable<string> ienumerable_0)
	{
		GClass4.Class10 @class = new GClass4.Class10(-2);
		@class.ienumerable_1 = ienumerable_0;
		return @class;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0001F178 File Offset: 0x0001D378
	internal static string smethod_66(this string string_1)
	{
		string text = string_1.TrimEnd(new char[] { '/' });
		if (text.Length <= 0)
		{
			return "/";
		}
		return text;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
	internal static string smethod_67(this string string_1)
	{
		string text = string_1.TrimEnd(new char[] { '/', '\\' });
		if (text.Length <= 0)
		{
			return string_1[0].ToString();
		}
		return text;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
	internal static bool smethod_68(this string string_1, out Version version_0)
	{
		version_0 = null;
		bool flag;
		try
		{
			version_0 = new Version(string_1);
			return true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0001F21C File Offset: 0x0001D41C
	internal static bool smethod_69(this string string_1, out Uri uri_0, out string string_2)
	{
		uri_0 = null;
		string_2 = null;
		Uri uri = string_1.smethod_104();
		if (uri == null)
		{
			string_2 = "An invalid URI string.";
			return false;
		}
		if (!uri.IsAbsoluteUri)
		{
			string_2 = "A relative URI.";
			return false;
		}
		string scheme = uri.Scheme;
		if (!(scheme == "ws") && !(scheme == "wss"))
		{
			string_2 = "The scheme part is not 'ws' or 'wss'.";
			return false;
		}
		int port = uri.Port;
		if (port == 0)
		{
			string_2 = "The port part is zero.";
			return false;
		}
		if (uri.Fragment.Length > 0)
		{
			string_2 = "It includes the fragment component.";
			return false;
		}
		uri_0 = ((port != -1) ? uri : new Uri(string.Format("{0}://{1}:{2}{3}", new object[]
		{
			scheme,
			uri.Host,
			(scheme == "ws") ? 80 : 443,
			uri.PathAndQuery
		})));
		return true;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0001F300 File Offset: 0x0001D500
	internal static bool smethod_70(this byte[] byte_1, out string string_1)
	{
		string_1 = null;
		bool flag;
		try
		{
			string_1 = Encoding.UTF8.GetString(byte_1);
			return true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0001F338 File Offset: 0x0001D538
	internal static bool smethod_71(this string string_1, out byte[] byte_1)
	{
		byte_1 = null;
		bool flag;
		try
		{
			byte_1 = Encoding.UTF8.GetBytes(string_1);
			return true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0001F370 File Offset: 0x0001D570
	internal static bool smethod_72(this FileInfo fileInfo_0, out FileStream fileStream_0)
	{
		fileStream_0 = null;
		bool flag;
		try
		{
			fileStream_0 = fileInfo_0.OpenRead();
			return true;
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
	internal static string smethod_73(this string string_1)
	{
		int num = string_1.IndexOf('"');
		if (num == -1)
		{
			return string_1;
		}
		int num2 = string_1.LastIndexOf('"');
		if (num2 == num)
		{
			return string_1;
		}
		int num3 = num2 - num - 1;
		if (num3 <= 0)
		{
			return string.Empty;
		}
		return string_1.Substring(num + 1, num3).Replace("\\\"", "\"");
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
	internal static bool smethod_74(this NameValueCollection nameValueCollection_0, string string_1)
	{
		StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
		return nameValueCollection_0.smethod_17("Upgrade", string_1, StringComparison.OrdinalIgnoreCase) && nameValueCollection_0.smethod_17("Connection", "Upgrade", stringComparison);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0001F42C File Offset: 0x0001D62C
	internal static string smethod_75(this byte[] byte_1)
	{
		string text;
		try
		{
			text = Encoding.UTF8.GetString(byte_1);
		}
		catch
		{
			text = null;
		}
		return text;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000039A7 File Offset: 0x00001BA7
	internal static byte[] smethod_76(this string string_1)
	{
		return Encoding.UTF8.GetBytes(string_1);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0001F460 File Offset: 0x0001D660
	internal static void smethod_77(this Stream stream_0, byte[] byte_1, int int_1)
	{
		using (MemoryStream memoryStream = new MemoryStream(byte_1))
		{
			memoryStream.CopyTo(stream_0, int_1);
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0001F498 File Offset: 0x0001D698
	internal static void smethod_78(this Stream stream_0, byte[] byte_1, int int_1, Action action_0, Action<Exception> action_1)
	{
		GClass4.Class8 @class = new GClass4.Class8();
		@class.action_0 = action_0;
		@class.action_1 = action_1;
		@class.memoryStream_0 = new MemoryStream(byte_1);
		@class.memoryStream_0.smethod_23(stream_0, int_1, new Action(@class.method_0), new Action<Exception>(@class.method_1));
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000039B4 File Offset: 0x00001BB4
	public static void smethod_79(this EventHandler eventHandler_0, object object_0, EventArgs eventArgs_0)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(object_0, eventArgs_0);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000039C1 File Offset: 0x00001BC1
	public static void smethod_80<T>(this EventHandler<T> eventHandler_0, object object_0, T gparam_0) where T : EventArgs
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(object_0, gparam_0);
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000039CE File Offset: 0x00001BCE
	public static string smethod_81(this GEnum5 genum5_0)
	{
		return ((int)genum5_0).smethod_82();
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0001F4EC File Offset: 0x0001D6EC
	public static string smethod_82(this int int_1)
	{
		if (int_1 <= 207)
		{
			switch (int_1)
			{
			case 100:
				return "Continue";
			case 101:
				return "Switching Protocols";
			case 102:
				return "Processing";
			default:
				switch (int_1)
				{
				case 200:
					return "OK";
				case 201:
					return "Created";
				case 202:
					return "Accepted";
				case 203:
					return "Non-Authoritative Information";
				case 204:
					return "No Content";
				case 205:
					return "Reset Content";
				case 206:
					return "Partial Content";
				case 207:
					return "Multi-Status";
				}
				break;
			}
		}
		else
		{
			switch (int_1)
			{
			case 300:
				return "Multiple Choices";
			case 301:
				return "Moved Permanently";
			case 302:
				return "Found";
			case 303:
				return "See Other";
			case 304:
				return "Not Modified";
			case 305:
				return "Use Proxy";
			case 306:
				break;
			case 307:
				return "Temporary Redirect";
			default:
				switch (int_1)
				{
				case 400:
					return "Bad Request";
				case 401:
					return "Unauthorized";
				case 402:
					return "Payment Required";
				case 403:
					return "Forbidden";
				case 404:
					return "Not Found";
				case 405:
					return "Method Not Allowed";
				case 406:
					return "Not Acceptable";
				case 407:
					return "Proxy Authentication Required";
				case 408:
					return "Request Timeout";
				case 409:
					return "Conflict";
				case 410:
					return "Gone";
				case 411:
					return "Length Required";
				case 412:
					return "Precondition Failed";
				case 413:
					return "Request Entity Too Large";
				case 414:
					return "Request-Uri Too Long";
				case 415:
					return "Unsupported Media Type";
				case 416:
					return "Requested Range Not Satisfiable";
				case 417:
					return "Expectation Failed";
				case 418:
				case 419:
				case 420:
				case 421:
					break;
				case 422:
					return "Unprocessable Entity";
				case 423:
					return "Locked";
				case 424:
					return "Failed Dependency";
				default:
					switch (int_1)
					{
					case 500:
						return "Internal Server Error";
					case 501:
						return "Not Implemented";
					case 502:
						return "Bad Gateway";
					case 503:
						return "Service Unavailable";
					case 504:
						return "Gateway Timeout";
					case 505:
						return "Http Version Not Supported";
					case 507:
						return "Insufficient Storage";
					}
					break;
				}
				break;
			}
		}
		return string.Empty;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000039D6 File Offset: 0x00001BD6
	public static bool smethod_83(this ushort ushort_0)
	{
		return ushort_0 > 999 && ushort_0 < 5000;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000039EA File Offset: 0x00001BEA
	public static bool smethod_84(this string string_1, char char_0)
	{
		return string_1 != null && string_1.Length > 1 && string_1[0] == char_0 && string_1[string_1.Length - 1] == char_0;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00003A15 File Offset: 0x00001C15
	public static bool smethod_85(this GEnum1 genum1_0)
	{
		return BitConverter.IsLittleEndian == (genum1_0 == GEnum1.Little);
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0001F730 File Offset: 0x0001D930
	public static bool smethod_86(this IPAddress ipaddress_0)
	{
		if (ipaddress_0 == null)
		{
			throw new ArgumentNullException("address");
		}
		if (ipaddress_0.Equals(IPAddress.Any))
		{
			return true;
		}
		if (ipaddress_0.Equals(IPAddress.Loopback))
		{
			return true;
		}
		if (Socket.OSSupportsIPv6)
		{
			if (ipaddress_0.Equals(IPAddress.IPv6Any))
			{
				return true;
			}
			if (ipaddress_0.Equals(IPAddress.IPv6Loopback))
			{
				return true;
			}
		}
		foreach (IPAddress ipaddress in Dns.GetHostAddresses(Dns.GetHostName()))
		{
			if (ipaddress_0.Equals(ipaddress))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00003A22 File Offset: 0x00001C22
	public static bool smethod_87(this string string_1)
	{
		return string_1 == null || string_1.Length == 0;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
	public static bool smethod_88(this string string_1)
	{
		if (string_1 == null || string_1.Length < 2)
		{
			return false;
		}
		char c = string_1[0];
		if (c == 'h')
		{
			return string_1 == "http" || string_1 == "https";
		}
		if (c == 'w')
		{
			return string_1 == "ws" || string_1 == "wss";
		}
		if (c == 'f')
		{
			return string_1 == "file" || string_1 == "ftp";
		}
		if (c == 'g')
		{
			return string_1 == "gopher";
		}
		if (c == 'm')
		{
			return string_1 == "mailto";
		}
		if (c != 'n')
		{
			return false;
		}
		c = string_1[1];
		if (c != 'e')
		{
			return string_1 == "nntp";
		}
		return string_1 == "news" || string_1 == "net.pipe" || string_1 == "net.tcp";
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0001F8AC File Offset: 0x0001DAAC
	public static bool smethod_89(this string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			int num = string_1.IndexOf(':');
			return num != -1 && num < 10 && string_1.Substring(0, num).smethod_88();
		}
		return false;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0001F8EC File Offset: 0x0001DAEC
	public static T[] smethod_90<T>(this T[] gparam_0, int int_1, int int_2)
	{
		int num;
		if (gparam_0 == null || (num = gparam_0.Length) == 0)
		{
			return new T[0];
		}
		if (int_1 < 0 || int_2 <= 0 || int_1 + int_2 > num)
		{
			return new T[0];
		}
		if (int_1 == 0 && int_2 == num)
		{
			return gparam_0;
		}
		T[] array = new T[int_2];
		Array.Copy(gparam_0, int_1, array, 0, int_2);
		return array;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0001F93C File Offset: 0x0001DB3C
	public static T[] smethod_91<T>(this T[] gparam_0, long long_0, long long_1)
	{
		long num;
		if (gparam_0 == null || (num = (long)gparam_0.Length) == 0L)
		{
			return new T[0];
		}
		if (long_0 < 0L || long_1 <= 0L || long_0 + long_1 > num)
		{
			return new T[0];
		}
		if (long_0 == 0L && long_1 == num)
		{
			return gparam_0;
		}
		T[] array = new T[long_1];
		Array.Copy(gparam_0, long_0, array, 0L, long_1);
		return array;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00003A32 File Offset: 0x00001C32
	public static void smethod_92(this int int_1, Action action_0)
	{
		if (int_1 > 0 && action_0 != null)
		{
			((ulong)((long)int_1)).smethod_8(action_0);
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00003A43 File Offset: 0x00001C43
	public static void smethod_93(this long long_0, Action action_0)
	{
		if (long_0 > 0L && action_0 != null)
		{
			((ulong)long_0).smethod_8(action_0);
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00003A5B File Offset: 0x00001C5B
	public static void smethod_94(this uint uint_0, Action action_0)
	{
		if (uint_0 > 0U && action_0 != null)
		{
			((ulong)uint_0).smethod_8(action_0);
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00003A6C File Offset: 0x00001C6C
	public static void smethod_95(this ulong ulong_0, Action action_0)
	{
		if (ulong_0 > 0UL && action_0 != null)
		{
			ulong_0.smethod_8(action_0);
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
	public static void smethod_96(this int int_1, Action<int> action_0)
	{
		if (int_1 > 0 && action_0 != null)
		{
			for (int i = 0; i < int_1; i++)
			{
				action_0(i);
			}
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0001F9CC File Offset: 0x0001DBCC
	public static void smethod_97(this long long_0, Action<long> action_0)
	{
		if (long_0 > 0L && action_0 != null)
		{
			for (long num = 0L; num < long_0; num += 1L)
			{
				action_0(num);
			}
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0001FA0C File Offset: 0x0001DC0C
	public static void smethod_98(this uint uint_0, Action<uint> action_0)
	{
		if (uint_0 > 0U && action_0 != null)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				action_0(num);
			}
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0001FA34 File Offset: 0x0001DC34
	public static void smethod_99(this ulong ulong_0, Action<ulong> action_0)
	{
		if (ulong_0 > 0UL && action_0 != null)
		{
			for (ulong num = 0UL; num < ulong_0; num += 1UL)
			{
				action_0(num);
			}
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0001FA74 File Offset: 0x0001DC74
	public static T smethod_100<T>(this byte[] byte_1, GEnum1 genum1_0) where T : struct
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (byte_1.Length == 0)
		{
			return default(T);
		}
		Type typeFromHandle = typeof(T);
		byte[] array = byte_1.smethod_102(genum1_0);
		if (typeFromHandle == typeof(bool))
		{
			return (T)((object)BitConverter.ToBoolean(array, 0));
		}
		if (typeFromHandle == typeof(char))
		{
			return (T)((object)BitConverter.ToChar(array, 0));
		}
		if (typeFromHandle == typeof(double))
		{
			return (T)((object)BitConverter.ToDouble(array, 0));
		}
		if (typeFromHandle == typeof(short))
		{
			return (T)((object)BitConverter.ToInt16(array, 0));
		}
		if (typeFromHandle == typeof(int))
		{
			return (T)((object)BitConverter.ToInt32(array, 0));
		}
		if (typeFromHandle == typeof(long))
		{
			return (T)((object)BitConverter.ToInt64(array, 0));
		}
		if (typeFromHandle == typeof(float))
		{
			return (T)((object)BitConverter.ToSingle(array, 0));
		}
		if (typeFromHandle == typeof(ushort))
		{
			return (T)((object)BitConverter.ToUInt16(array, 0));
		}
		if (typeFromHandle == typeof(uint))
		{
			return (T)((object)BitConverter.ToUInt32(array, 0));
		}
		if (!(typeFromHandle == typeof(ulong)))
		{
			return default(T);
		}
		return (T)((object)BitConverter.ToUInt64(array, 0));
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0001FC34 File Offset: 0x0001DE34
	public static byte[] smethod_101<T>(this T gparam_0, GEnum1 genum1_0) where T : struct
	{
		Type typeFromHandle = typeof(T);
		byte[] array;
		if (!(typeFromHandle == typeof(bool)))
		{
			if (!(typeFromHandle == typeof(byte)))
			{
				array = ((typeFromHandle == typeof(char)) ? BitConverter.GetBytes((char)((object)gparam_0)) : ((typeFromHandle == typeof(double)) ? BitConverter.GetBytes((double)((object)gparam_0)) : ((typeFromHandle == typeof(short)) ? BitConverter.GetBytes((short)((object)gparam_0)) : ((typeFromHandle == typeof(int)) ? BitConverter.GetBytes((int)((object)gparam_0)) : ((typeFromHandle == typeof(long)) ? BitConverter.GetBytes((long)((object)gparam_0)) : ((typeFromHandle == typeof(float)) ? BitConverter.GetBytes((float)((object)gparam_0)) : ((typeFromHandle == typeof(ushort)) ? BitConverter.GetBytes((ushort)((object)gparam_0)) : ((typeFromHandle == typeof(uint)) ? BitConverter.GetBytes((uint)((object)gparam_0)) : ((typeFromHandle == typeof(ulong)) ? BitConverter.GetBytes((ulong)((object)gparam_0)) : GClass7.byte_0)))))))));
			}
			else
			{
				(array = new byte[1])[0] = (byte)((object)gparam_0);
			}
		}
		else
		{
			array = BitConverter.GetBytes((bool)((object)gparam_0));
		}
		byte[] array2 = array;
		if (array2.Length > 1 && !genum1_0.smethod_85())
		{
			Array.Reverse(array2);
		}
		return array2;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00003A84 File Offset: 0x00001C84
	public static byte[] smethod_102(this byte[] byte_1, GEnum1 genum1_0)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (byte_1.Length < 2)
		{
			return byte_1;
		}
		if (genum1_0.smethod_85())
		{
			return byte_1;
		}
		return byte_1.smethod_55<byte>();
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0001FE1C File Offset: 0x0001E01C
	public static string smethod_103<T>(this T[] gparam_0, string string_1)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException("array");
		}
		int num = gparam_0.Length;
		if (num == 0)
		{
			return string.Empty;
		}
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(64);
		for (int i = 0; i < num - 1; i++)
		{
			stringBuilder.AppendFormat("{0}{1}", gparam_0[i], string_1);
		}
		stringBuilder.Append(gparam_0[num - 1].ToString());
		return stringBuilder.ToString();
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
	public static Uri smethod_104(this string string_1)
	{
		Uri uri;
		Uri.TryCreate(string_1, string_1.smethod_89() ? UriKind.Absolute : UriKind.Relative, out uri);
		return uri;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00003AAC File Offset: 0x00001CAC
	public static string smethod_105(this string string_1)
	{
		if (string_1 != null && string_1.Length > 0)
		{
			return Class71.smethod_33(string_1);
		}
		return string_1;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00003AC2 File Offset: 0x00001CC2
	public static string smethod_106(this string string_1)
	{
		if (string_1 != null && string_1.Length > 0)
		{
			return Class71.smethod_43(string_1);
		}
		return string_1;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
	public static void smethod_107(this GClass23 gclass23_0, byte[] byte_1)
	{
		if (gclass23_0 == null)
		{
			throw new ArgumentNullException("response");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("content");
		}
		long num = (long)byte_1.Length;
		if (num == 0L)
		{
			gclass23_0.method_10();
			return;
		}
		gclass23_0.Int64_0 = num;
		Stream stream_ = gclass23_0.Stream_0;
		if (num <= 2147483647L)
		{
			stream_.Write(byte_1, 0, (int)num);
		}
		else
		{
			stream_.smethod_77(byte_1, 1024);
		}
		stream_.Close();
	}

	// Token: 0x04000073 RID: 115
	private static readonly byte[] byte_0 = new byte[1];

	// Token: 0x04000074 RID: 116
	private static readonly int int_0 = 5;

	// Token: 0x04000075 RID: 117
	private const string string_0 = "()<>@,;:\\\"/[]?={} \t";

	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	private sealed class Class3
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0001FF34 File Offset: 0x0001E134
		internal bool method_0(int int_2)
		{
			if (int_2 == this.int_0)
			{
				return false;
			}
			string text = this.string_0[int_2];
			for (int i = int_2 + 1; i < this.int_1; i++)
			{
				if (this.string_0[i] == text)
				{
					return true;
				}
			}
			return this.func_0(++int_2);
		}

		// Token: 0x04000076 RID: 118
		public int int_0;

		// Token: 0x04000077 RID: 119
		public string[] string_0;

		// Token: 0x04000078 RID: 120
		public int int_1;

		// Token: 0x04000079 RID: 121
		public Func<int, bool> func_0;
	}

	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	private sealed class Class4
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0001FF8C File Offset: 0x0001E18C
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = this.stream_0.EndRead(iasyncResult_0);
				if (num <= 0)
				{
					if (this.action_0 != null)
					{
						this.action_0();
					}
				}
				else
				{
					this.stream_1.Write(this.byte_0, 0, num);
					this.stream_0.BeginRead(this.byte_0, 0, this.int_0, this.asyncCallback_0, null);
				}
			}
			catch (Exception ex)
			{
				if (this.action_1 != null)
				{
					this.action_1(ex);
				}
			}
		}

		// Token: 0x0400007A RID: 122
		public Stream stream_0;

		// Token: 0x0400007B RID: 123
		public Action action_0;

		// Token: 0x0400007C RID: 124
		public Stream stream_1;

		// Token: 0x0400007D RID: 125
		public byte[] byte_0;

		// Token: 0x0400007E RID: 126
		public int int_0;

		// Token: 0x0400007F RID: 127
		public AsyncCallback asyncCallback_0;

		// Token: 0x04000080 RID: 128
		public Action<Exception> action_1;
	}

	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	private sealed class Class5
	{
		// Token: 0x060000FE RID: 254 RVA: 0x0002001C File Offset: 0x0001E21C
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = this.stream_0.EndRead(iasyncResult_0);
				if (num == 0 && this.int_0 < GClass4.int_0)
				{
					int num2 = this.int_0;
					this.int_0 = num2 + 1;
					this.stream_0.BeginRead(this.byte_0, this.int_1, this.int_2, this.asyncCallback_0, null);
				}
				else
				{
					if (num != 0)
					{
						if (num != this.int_2)
						{
							this.int_0 = 0;
							this.int_1 += num;
							this.int_2 -= num;
							this.stream_0.BeginRead(this.byte_0, this.int_1, this.int_2, this.asyncCallback_0, null);
							return;
						}
					}
					if (this.action_0 != null)
					{
						this.action_0(this.byte_0.smethod_90<byte>(0, this.int_1 + num));
					}
				}
			}
			catch (Exception ex)
			{
				if (this.action_1 != null)
				{
					this.action_1(ex);
				}
			}
		}

		// Token: 0x04000081 RID: 129
		public Stream stream_0;

		// Token: 0x04000082 RID: 130
		public int int_0;

		// Token: 0x04000083 RID: 131
		public byte[] byte_0;

		// Token: 0x04000084 RID: 132
		public int int_1;

		// Token: 0x04000085 RID: 133
		public int int_2;

		// Token: 0x04000086 RID: 134
		public AsyncCallback asyncCallback_0;

		// Token: 0x04000087 RID: 135
		public Action<byte[]> action_0;

		// Token: 0x04000088 RID: 136
		public Action<Exception> action_1;
	}

	// Token: 0x02000018 RID: 24
	[CompilerGenerated]
	private sealed class Class6
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00020128 File Offset: 0x0001E328
		internal void method_0(long long_0)
		{
			GClass4.Class7 @class = new GClass4.Class7();
			@class.class6_0 = this;
			@class.long_0 = long_0;
			if (@class.long_0 < (long)this.int_0)
			{
				this.int_0 = (int)@class.long_0;
			}
			this.stream_0.BeginRead(this.byte_0, 0, this.int_0, new AsyncCallback(@class.method_0), null);
		}

		// Token: 0x04000089 RID: 137
		public int int_0;

		// Token: 0x0400008A RID: 138
		public Stream stream_0;

		// Token: 0x0400008B RID: 139
		public byte[] byte_0;

		// Token: 0x0400008C RID: 140
		public MemoryStream memoryStream_0;

		// Token: 0x0400008D RID: 141
		public int int_1;

		// Token: 0x0400008E RID: 142
		public Action<long> action_0;

		// Token: 0x0400008F RID: 143
		public Action<byte[]> action_1;

		// Token: 0x04000090 RID: 144
		public Action<Exception> action_2;
	}

	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	private sealed class Class7
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0002018C File Offset: 0x0001E38C
		internal void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = this.class6_0.stream_0.EndRead(iasyncResult_0);
				if (num > 0)
				{
					this.class6_0.memoryStream_0.Write(this.class6_0.byte_0, 0, num);
				}
				if (num == 0 && this.class6_0.int_1 < GClass4.int_0)
				{
					int int_ = this.class6_0.int_1;
					this.class6_0.int_1 = int_ + 1;
					this.class6_0.action_0(this.long_0);
				}
				else
				{
					if (num != 0)
					{
						if ((long)num != this.long_0)
						{
							this.class6_0.int_1 = 0;
							this.class6_0.action_0(this.long_0 - (long)num);
							return;
						}
					}
					if (this.class6_0.action_1 != null)
					{
						this.class6_0.memoryStream_0.Close();
						this.class6_0.action_1(this.class6_0.memoryStream_0.ToArray());
					}
					this.class6_0.memoryStream_0.Dispose();
				}
			}
			catch (Exception ex)
			{
				this.class6_0.memoryStream_0.Dispose();
				if (this.class6_0.action_2 != null)
				{
					this.class6_0.action_2(ex);
				}
			}
		}

		// Token: 0x04000091 RID: 145
		public long long_0;

		// Token: 0x04000092 RID: 146
		public GClass4.Class6 class6_0;
	}

	// Token: 0x0200001A RID: 26
	[CompilerGenerated]
	private sealed class Class8
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00003AF3 File Offset: 0x00001CF3
		internal void method_0()
		{
			if (this.action_0 != null)
			{
				this.action_0();
			}
			this.memoryStream_0.Dispose();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003B13 File Offset: 0x00001D13
		internal void method_1(Exception exception_0)
		{
			this.memoryStream_0.Dispose();
			if (this.action_1 != null)
			{
				this.action_1(exception_0);
			}
		}

		// Token: 0x04000093 RID: 147
		public Action action_0;

		// Token: 0x04000094 RID: 148
		public MemoryStream memoryStream_0;

		// Token: 0x04000095 RID: 149
		public Action<Exception> action_1;
	}

	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	private sealed class Class9 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00003B34 File Offset: 0x00001D34
		[DebuggerHidden]
		public Class9(int int_4)
		{
			this.int_0 = int_4;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003B4E File Offset: 0x00001D4E
		[DebuggerHidden]
		public void Dispose()
		{
			this.stringBuilder_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000202EC File Offset: 0x0001E4EC
		bool IEnumerator.MoveNext()
		{
			switch (this.int_0)
			{
			case 0:
			{
				this.int_0 = -1;
				int length = this.string_1.Length;
				this.stringBuilder_0 = new StringBuilder(32);
				this.int_2 = length - 1;
				this.bool_0 = false;
				this.bool_1 = false;
				this.int_3 = 0;
				break;
			}
			case 1:
				this.int_0 = -1;
				this.stringBuilder_0.Length = 0;
				goto IL_0114;
			case 2:
				this.int_0 = -1;
				return false;
			default:
				return false;
			}
			IL_0073:
			if (this.int_3 <= this.int_2)
			{
				char c = this.string_1[this.int_3];
				this.stringBuilder_0.Append(c);
				if (c == '"')
				{
					if (this.bool_0)
					{
						this.bool_0 = false;
						goto IL_0114;
					}
					this.bool_1 = !this.bool_1;
					goto IL_0114;
				}
				else if (c == '\\')
				{
					if (this.int_3 != this.int_2)
					{
						if (this.string_1[this.int_3 + 1] == '"')
						{
							this.bool_0 = true;
							goto IL_0114;
						}
						goto IL_0114;
					}
				}
				else
				{
					if (Array.IndexOf<char>(this.char_0, c) <= -1 || this.bool_1)
					{
						goto IL_0114;
					}
					this.stringBuilder_0.Length--;
					this.string_0 = this.stringBuilder_0.ToString();
					this.int_0 = 1;
					return true;
				}
			}
			this.string_0 = this.stringBuilder_0.ToString();
			this.int_0 = 2;
			return true;
			IL_0114:
			int num = this.int_3;
			this.int_3 = num + 1;
			goto IL_0073;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00003B5F File Offset: 0x00001D5F
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00003B5F File Offset: 0x00001D5F
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00020474 File Offset: 0x0001E674
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			GClass4.Class9 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass4.Class9(0);
			}
			@class.string_1 = this.string_2;
			@class.char_0 = this.char_1;
			return @class;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003B67 File Offset: 0x00001D67
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000096 RID: 150
		private int int_0;

		// Token: 0x04000097 RID: 151
		private string string_0;

		// Token: 0x04000098 RID: 152
		private int int_1;

		// Token: 0x04000099 RID: 153
		private string string_1;

		// Token: 0x0400009A RID: 154
		public string string_2;

		// Token: 0x0400009B RID: 155
		private char[] char_0;

		// Token: 0x0400009C RID: 156
		public char[] char_1;

		// Token: 0x0400009D RID: 157
		private StringBuilder stringBuilder_0;

		// Token: 0x0400009E RID: 158
		private int int_2;

		// Token: 0x0400009F RID: 159
		private bool bool_0;

		// Token: 0x040000A0 RID: 160
		private bool bool_1;

		// Token: 0x040000A1 RID: 161
		private int int_3;
	}

	// Token: 0x0200001C RID: 28
	[CompilerGenerated]
	private sealed class Class10 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00003B6F File Offset: 0x00001D6F
		[DebuggerHidden]
		public Class10(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000204C4 File Offset: 0x0001E6C4
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
			this.ienumerator_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0002050C File Offset: 0x0001E70C
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
					this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.ienumerator_0.MoveNext())
				{
					this.method_0();
					this.ienumerator_0 = null;
					flag = false;
				}
				else
				{
					string text = this.ienumerator_0.Current;
					this.string_0 = text.Trim();
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003B89 File Offset: 0x00001D89
		private void method_0()
		{
			this.int_0 = -1;
			if (this.ienumerator_0 != null)
			{
				this.ienumerator_0.Dispose();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00003BA5 File Offset: 0x00001DA5
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00003BA5 File Offset: 0x00001DA5
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			GClass4.Class10 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass4.Class10(0);
			}
			@class.ienumerable_0 = this.ienumerable_1;
			return @class;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003BAD File Offset: 0x00001DAD
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040000A2 RID: 162
		private int int_0;

		// Token: 0x040000A3 RID: 163
		private string string_0;

		// Token: 0x040000A4 RID: 164
		private int int_1;

		// Token: 0x040000A5 RID: 165
		private IEnumerable<string> ienumerable_0;

		// Token: 0x040000A6 RID: 166
		public IEnumerable<string> ienumerable_1;

		// Token: 0x040000A7 RID: 167
		private IEnumerator<string> ienumerator_0;
	}
}
