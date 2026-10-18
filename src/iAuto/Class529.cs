using System;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020002EF RID: 751
internal class Class529
{
	// Token: 0x060029E8 RID: 10728 RVA: 0x0001C531 File Offset: 0x0001A731
	private static FileStream smethod_0(string string_0)
	{
		return new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x0012A854 File Offset: 0x00128A54
	public static string smethod_1(string string_0)
	{
		string text = "";
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			if (File.Exists(string_0))
			{
				FileStream fileStream = Class529.smethod_0(string_0);
				byte[] array = md5CryptoServiceProvider.ComputeHash(fileStream);
				fileStream.Close();
				text = BitConverter.ToString(array).Replace("-", "");
			}
			else
			{
				HashAlgorithm hashAlgorithm = MD5.Create();
				byte[] bytes = Encoding.ASCII.GetBytes(string_0);
				byte[] array2 = hashAlgorithm.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array2.Length; i++)
				{
					stringBuilder.Append(array2[i].ToString("X2"));
				}
				text = stringBuilder.ToString();
			}
		}
		catch
		{
			HashAlgorithm hashAlgorithm2 = MD5.Create();
			byte[] bytes2 = Encoding.ASCII.GetBytes(string_0);
			byte[] array3 = hashAlgorithm2.ComputeHash(bytes2);
			StringBuilder stringBuilder2 = new StringBuilder();
			for (int j = 0; j < array3.Length; j++)
			{
				stringBuilder2.Append(array3[j].ToString("X2"));
			}
			text = stringBuilder2.ToString();
		}
		return text.ToUpper();
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x0012A96C File Offset: 0x00128B6C
	public static string smethod_2(string string_0, string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		new AppSettingsReader();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		md5CryptoServiceProvider.Clear();
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = array;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array2 = tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
		tripleDESCryptoServiceProvider.Clear();
		return Convert.ToBase64String(array2, 0, array2.Length);
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x0012A9E4 File Offset: 0x00128BE4
	public static string smethod_3(string string_0, string string_1)
	{
		byte[] array = Convert.FromBase64String(string_0);
		new AppSettingsReader();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array2 = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		md5CryptoServiceProvider.Clear();
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = array2;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array3 = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
		tripleDESCryptoServiceProvider.Clear();
		return Encoding.UTF8.GetString(array3);
	}
}
