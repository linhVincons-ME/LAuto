using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200017D RID: 381
internal class Class261
{
	// Token: 0x06001678 RID: 5752 RVA: 0x000B2EBC File Offset: 0x000B10BC
	public static string smethod_0(string string_0, string string_1 = "130516")
	{
		byte[] array = Class261.smethod_2(string_1);
		byte[] array2 = Class261.smethod_3(16);
		string text;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array2;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			byte[] array3;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					byte[] bytes = Encoding.UTF8.GetBytes(string_0);
					cryptoStream.Write(bytes, 0, bytes.Length);
				}
				array3 = memoryStream.ToArray();
			}
			text = Convert.ToBase64String(Class261.smethod_4(array2, array3));
		}
		return text;
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x000B2F98 File Offset: 0x000B1198
	public static string smethod_1(string string_0, string string_1 = "130516")
	{
		byte[] array = Class261.smethod_2(string_1);
		byte[] array2 = Convert.FromBase64String(string_0);
		byte[] array3 = new byte[16];
		byte[] array4 = new byte[array2.Length - 16];
		Buffer.BlockCopy(array2, 0, array3, 0, 16);
		Buffer.BlockCopy(array2, 16, array4, 0, array2.Length - 16);
		string text;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(array4, 0, array4.Length);
				}
				byte[] array5 = memoryStream.ToArray();
				@string = Encoding.UTF8.GetString(array5);
			}
			text = @string;
		}
		return text;
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x000B30A0 File Offset: 0x000B12A0
	private static byte[] smethod_2(string string_0)
	{
		byte[] array;
		using (SHA256 sha = SHA256.Create())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			array = sha.ComputeHash(bytes);
		}
		return array;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x000B30E4 File Offset: 0x000B12E4
	private static byte[] smethod_3(int int_0)
	{
		byte[] array2;
		using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			byte[] array = new byte[int_0];
			rngcryptoServiceProvider.GetBytes(array);
			array2 = array;
		}
		return array2;
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x000B3124 File Offset: 0x000B1324
	private static byte[] smethod_4(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length + byte_1.Length];
		Buffer.BlockCopy(byte_0, 0, array, 0, byte_0.Length);
		Buffer.BlockCopy(byte_1, 0, array, byte_0.Length, byte_1.Length);
		return array;
	}
}
