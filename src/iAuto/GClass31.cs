using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

// Token: 0x02000098 RID: 152
public static class GClass31
{
	// Token: 0x060006F7 RID: 1783 RVA: 0x00033864 File Offset: 0x00031A64
	public static string smethod_0()
	{
		IEnumerable<string> enumerable = new string[]
		{
			GClass31.smethod_2("Win32_ComputerSystemProduct", "UUID"),
			GClass31.smethod_2("Win32_BaseBoard", "SerialNumber"),
			GClass31.smethod_2("Win32_BIOS", "SerialNumber"),
			GClass31.smethod_2("Win32_Processor", "ProcessorId"),
			GClass31.smethod_3(),
			GClass31.smethod_4()
		};
		Func<string, string> func;
		if ((func = GClass31.Class82.func_0) == null)
		{
			func = (GClass31.Class82.func_0 = new Func<string, string>(GClass31.smethod_5));
		}
		IEnumerable<string> enumerable2 = enumerable.Select<string, string>(func);
		Func<string, bool> func2;
		if ((func2 = GClass31.Class82.func_1) == null)
		{
			func2 = (GClass31.Class82.func_1 = new Func<string, bool>(GClass31.smethod_6));
		}
		string[] array = enumerable2.Where<string>(func2).Distinct<string>(StringComparer.OrdinalIgnoreCase).ToArray<string>();
		string text = ((array.Length != 0) ? string.Join("|", array) : (Environment.MachineName + "|" + Environment.OSVersion.VersionString));
		string text2;
		using (SHA256 sha = SHA256.Create())
		{
			GClass31.Class83 @class = new GClass31.Class83();
			@class.string_0 = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-", "");
			text2 = string.Join("-", Enumerable.Range(0, 8).Select<int, string>(new Func<int, string>(@class.method_0)));
		}
		return text2;
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00007C6F File Offset: 0x00005E6F
	public static string smethod_1()
	{
		return GClass31.smethod_0().Replace("-", "").Substring(0, 16);
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000339C4 File Offset: 0x00031BC4
	private static string smethod_2(string string_0, string string_1)
	{
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT " + string_1 + " FROM " + string_0))
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					object obj = ((ManagementObject)managementBaseObject)[string_1];
					if (obj != null)
					{
						return obj.ToString();
					}
				}
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00033A6C File Offset: 0x00031C6C
	private static string smethod_3()
	{
		try
		{
			string text = Environment.SystemDirectory.Substring(0, 2);
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE DeviceID='" + text.Replace("'", "''") + "'"))
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return Convert.ToString(((ManagementObject)enumerator.Current)["VolumeSerialNumber"]);
					}
				}
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00033B28 File Offset: 0x00031D28
	private static string smethod_4()
	{
		string text;
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography"))
			{
				text = Convert.ToString((registryKey != null) ? registryKey.GetValue("MachineGuid") : null);
			}
		}
		catch
		{
			try
			{
				using (RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography"))
				{
					text = Convert.ToString((registryKey2 != null) ? registryKey2.GetValue("MachineGuid") : null);
				}
			}
			catch
			{
				text = string.Empty;
			}
		}
		return text;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00033BF0 File Offset: 0x00031DF0
	private static string smethod_5(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string.Empty;
		}
		IEnumerable<char> enumerable = string_0.Trim().ToUpperInvariant();
		Func<char, bool> func;
		if ((func = GClass31.Class82.func_2) == null)
		{
			func = (GClass31.Class82.func_2 = new Func<char, bool>(char.IsLetterOrDigit));
		}
		return new string(enumerable.Where<char>(func).ToArray<char>());
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00033C40 File Offset: 0x00031E40
	private static bool smethod_6(string string_0)
	{
		return !string.IsNullOrWhiteSpace(string_0) && string_0.Length >= 4 && !new string[] { "NONE", "NULL", "UNKNOWN", "DEFAULTSTRING", "TOBEFILLEDBYOEM", "SYSTEMSERIALNUMBER", "FFFFFFFFFFFFFFFF", "0000000000000000", "03000200040005000006000700080009" }.Contains(string_0, StringComparer.OrdinalIgnoreCase);
	}

	// Token: 0x02000099 RID: 153
	[CompilerGenerated]
	private static class Class82
	{
		// Token: 0x0400038E RID: 910
		public static Func<string, string> func_0;

		// Token: 0x0400038F RID: 911
		public static Func<string, bool> func_1;

		// Token: 0x04000390 RID: 912
		public static Func<char, bool> func_2;
	}

	// Token: 0x0200009A RID: 154
	[CompilerGenerated]
	private sealed class Class83
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x00007C8D File Offset: 0x00005E8D
		internal string method_0(int int_0)
		{
			return this.string_0.Substring(int_0 * 4, 4);
		}

		// Token: 0x04000391 RID: 913
		public string string_0;
	}
}
