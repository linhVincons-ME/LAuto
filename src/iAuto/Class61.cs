using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

// Token: 0x02000069 RID: 105
internal sealed class Class61
{
	// Token: 0x06000476 RID: 1142 RVA: 0x00003AEB File Offset: 0x00001CEB
	private Class61()
	{
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0002C798 File Offset: 0x0002A998
	private static void smethod_0(string string_0, GClass19 gclass19_0)
	{
		Class67 @class = new Class67(string_0);
		IPAddress ipaddress = Class61.smethod_1(@class.String_0);
		if (ipaddress == null)
		{
			throw new GException2(87, "Includes an invalid host.");
		}
		if (!ipaddress.smethod_86())
		{
			throw new GException2(87, "Includes an invalid host.");
		}
		int num;
		if (!int.TryParse(@class.String_3, out num))
		{
			throw new GException2(87, "Includes an invalid port.");
		}
		if (!num.smethod_43())
		{
			throw new GException2(87, "Includes an invalid port.");
		}
		string string_ = @class.String_2;
		if (string_.IndexOf('%') != -1)
		{
			throw new GException2(87, "Includes an invalid path.");
		}
		if (string_.IndexOf("//", StringComparison.Ordinal) != -1)
		{
			throw new GException2(87, "Includes an invalid path.");
		}
		IPEndPoint ipendPoint = new IPEndPoint(ipaddress, num);
		Class59 class2;
		if (Class61.dictionary_0.TryGetValue(ipendPoint, out class2))
		{
			if (class2.Boolean_0 ^ @class.Boolean_0)
			{
				throw new GException2(87, "Includes an invalid scheme.");
			}
		}
		else
		{
			class2 = new Class59(ipendPoint, @class.Boolean_0, gclass19_0.String_0, gclass19_0.GClass26_0, gclass19_0.Boolean_1);
			Class61.dictionary_0.Add(ipendPoint, class2);
		}
		class2.method_3(@class, gclass19_0);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00005FC4 File Offset: 0x000041C4
	private static IPAddress smethod_1(string string_0)
	{
		if (string_0 == "*")
		{
			return IPAddress.Any;
		}
		if (string_0 == "+")
		{
			return IPAddress.Any;
		}
		return string_0.smethod_60();
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0002C8AC File Offset: 0x0002AAAC
	private static void smethod_2(string string_0, GClass19 gclass19_0)
	{
		Class67 @class = new Class67(string_0);
		IPAddress ipaddress = Class61.smethod_1(@class.String_0);
		if (ipaddress == null)
		{
			return;
		}
		if (!ipaddress.smethod_86())
		{
			return;
		}
		int num;
		if (!int.TryParse(@class.String_3, out num))
		{
			return;
		}
		if (!num.smethod_43())
		{
			return;
		}
		string string_ = @class.String_2;
		if (string_.IndexOf('%') != -1)
		{
			return;
		}
		if (string_.IndexOf("//", StringComparison.Ordinal) != -1)
		{
			return;
		}
		IPEndPoint ipendPoint = new IPEndPoint(ipaddress, num);
		Class59 class2;
		if (!Class61.dictionary_0.TryGetValue(ipendPoint, out class2))
		{
			return;
		}
		if (class2.Boolean_0 ^ @class.Boolean_0)
		{
			return;
		}
		class2.method_5(@class, gclass19_0);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x0002C94C File Offset: 0x0002AB4C
	internal static bool smethod_3(IPEndPoint ipendPoint_0)
	{
		object syncRoot = ((ICollection)Class61.dictionary_0).SyncRoot;
		bool flag2;
		lock (syncRoot)
		{
			Class59 @class;
			if (!Class61.dictionary_0.TryGetValue(ipendPoint_0, out @class))
			{
				flag2 = false;
			}
			else
			{
				Class61.dictionary_0.Remove(ipendPoint_0);
				@class.method_4();
				flag2 = true;
			}
		}
		return flag2;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
	public static void smethod_4(GClass19 gclass19_0)
	{
		List<string> list = new List<string>();
		object syncRoot = ((ICollection)Class61.dictionary_0).SyncRoot;
		lock (syncRoot)
		{
			try
			{
				foreach (string text in gclass19_0.GClass21_0)
				{
					Class61.smethod_0(text, gclass19_0);
					list.Add(text);
				}
			}
			catch
			{
				foreach (string text2 in list)
				{
					Class61.smethod_2(text2, gclass19_0);
				}
				throw;
			}
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0002CA8C File Offset: 0x0002AC8C
	public static void smethod_5(string string_0, GClass19 gclass19_0)
	{
		object syncRoot = ((ICollection)Class61.dictionary_0).SyncRoot;
		lock (syncRoot)
		{
			Class61.smethod_0(string_0, gclass19_0);
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
	public static void smethod_6(GClass19 gclass19_0)
	{
		object syncRoot = ((ICollection)Class61.dictionary_0).SyncRoot;
		lock (syncRoot)
		{
			foreach (string text in gclass19_0.GClass21_0)
			{
				Class61.smethod_2(text, gclass19_0);
			}
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0002CB4C File Offset: 0x0002AD4C
	public static void smethod_7(string string_0, GClass19 gclass19_0)
	{
		object syncRoot = ((ICollection)Class61.dictionary_0).SyncRoot;
		lock (syncRoot)
		{
			Class61.smethod_2(string_0, gclass19_0);
		}
	}

	// Token: 0x04000214 RID: 532
	private static readonly Dictionary<IPEndPoint, Class59> dictionary_0 = new Dictionary<IPEndPoint, Class59>();
}
