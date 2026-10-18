using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

// Token: 0x020001C3 RID: 451
public static class GClass39
{
	// Token: 0x0600188A RID: 6282 RVA: 0x000CC4E4 File Offset: 0x000CA6E4
	public static T smethod_0<T>(T gparam_0)
	{
		T t;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, gparam_0);
			memoryStream.Position = 0L;
			t = (T)((object)binaryFormatter.Deserialize(memoryStream));
		}
		return t;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00010E30 File Offset: 0x0000F030
	public static uint smethod_1(this Type type_0)
	{
		return (uint)Marshal.SizeOf(type_0);
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x000CC544 File Offset: 0x000CA744
	public static string smethod_2(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		string text = null;
		try
		{
			text = Path.GetTempFileName();
		}
		catch (IOException)
		{
			text = Path.Combine(Directory.GetCurrentDirectory(), Path.GetRandomFileName());
		}
		try
		{
			File.WriteAllBytes(text, byte_0);
		}
		catch
		{
			text = null;
		}
		return text;
	}
}
