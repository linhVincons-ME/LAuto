using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200014F RID: 335
internal static class Class228
{
	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06001550 RID: 5456 RVA: 0x000A9D4C File Offset: 0x000A7F4C
	// (remove) Token: 0x06001551 RID: 5457 RVA: 0x000A9D80 File Offset: 0x000A7F80
	public static event Action Event_0
	{
		[CompilerGenerated]
		add
		{
			Action action = Class228.action_0;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Class228.action_0, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = Class228.action_0;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Class228.action_0, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x0000F370 File Offset: 0x0000D570
	public static void smethod_0()
	{
		if (Interlocked.Exchange(ref Class228.int_0, 1) == 1)
		{
			return;
		}
		Action<string, string, string> action;
		if ((action = Class228.Class229.action_0) == null)
		{
			action = (Class228.Class229.action_0 = new Action<string, string, string>(Class228.smethod_1));
		}
		Class238.Event_0 += action;
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x000A9DB4 File Offset: 0x000A7FB4
	private static void smethod_1(string string_7, string string_8, string string_9)
	{
		if (!Class228.smethod_3(string_8))
		{
			return;
		}
		if (!string.Equals(string_7, Class238.String_0, StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		try
		{
			Class228.smethod_4(string_8);
		}
		catch
		{
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
	public static void smethod_2()
	{
		Class228.smethod_0();
		GUI gui_ = GUI.GUI_0;
		string text;
		if (gui_ != null)
		{
			if ((text = gui_.String_2) != null)
			{
				goto IL_001F;
			}
		}
		text = "";
		IL_001F:
		string text2 = Class238.smethod_11(text);
		if (string.IsNullOrWhiteSpace(text2))
		{
			return;
		}
		Class238.smethod_1(text2);
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x0000F3A1 File Offset: 0x0000D5A1
	public static bool smethod_3(string string_7)
	{
		return !string.IsNullOrWhiteSpace(string_7) && string_7.StartsWith("#IGOM", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x000A9E3C File Offset: 0x000A803C
	public static void smethod_4(string string_7)
	{
		if (!Class228.smethod_3(string_7))
		{
			return;
		}
		string[] array = string_7.Split(new char[] { '|' });
		if (array.Length < 2)
		{
			return;
		}
		string text = (array[1] ?? "").Trim().ToUpperInvariant();
		if (!(text == "WHO"))
		{
			if (text == "NHAN" && array.Length >= 3)
			{
				Class228.Class231 @class = new Class228.Class231();
				@class.string_0 = (array[2] ?? "").Trim();
				if (string.IsNullOrEmpty(@class.string_0))
				{
					return;
				}
				string text2 = ((array.Length >= 4) ? (array[3] ?? "vang").Trim().ToLowerInvariant() : "vang");
				Class228.concurrentDictionary_1[@class.string_0] = text2;
				IEnumerable<Class106> ienumerable_ = Class106.IEnumerable_0;
				Func<Class106, bool> func;
				if ((func = @class.func_0) == null)
				{
					func = (@class.func_0 = new Func<Class106, bool>(@class.method_0));
				}
				using (IEnumerator<Class106> enumerator = ienumerable_.Where<Class106>(func).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class106 class2 = enumerator.Current;
						class2.Boolean_46 = true;
						class2.method_493("Nhận gom máy khác [" + text2 + "]");
					}
					return;
				}
			}
			if (text == "STOP" && array.Length >= 3)
			{
				Class228.Class232 class3 = new Class228.Class232();
				class3.string_0 = (array[2] ?? "").Trim();
				if (string.IsNullOrEmpty(class3.string_0))
				{
					return;
				}
				string text3;
				Class228.concurrentDictionary_1.TryRemove(class3.string_0, out text3);
				IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_0;
				Func<Class106, bool> func2;
				if ((func2 = class3.func_0) == null)
				{
					func2 = (class3.func_0 = new Func<Class106, bool>(class3.method_0));
				}
				using (IEnumerator<Class106> enumerator = ienumerable_2.Where<Class106>(func2).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class106 class4 = enumerator.Current;
						class4.Boolean_46 = false;
						class4.method_493("Dừng nhận gom máy khác");
					}
					return;
				}
			}
			if (text == "POS" && array.Length >= 6)
			{
				string text4 = (array[2] ?? "").Trim();
				if (string.IsNullOrEmpty(text4))
				{
					return;
				}
				int num;
				if (!int.TryParse(array[3], out num))
				{
					return;
				}
				float num2;
				if (!float.TryParse(array[4], NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
				{
					return;
				}
				float num3;
				if (!float.TryParse(array[5], NumberStyles.Float, CultureInfo.InvariantCulture, out num3))
				{
					return;
				}
				Class228.concurrentDictionary_0[text4] = new Class228.Struct33(text4, num, num2, num3, DateTime.UtcNow);
				return;
			}
			else if (text == "CHARS" && array.Length >= 3)
			{
				bool flag = false;
				foreach (string text5 in (array[2] ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
				{
					Class228.Class233 class5 = new Class228.Class233();
					string[] array3 = text5.Split(new char[] { ':' });
					if (array3.Length >= 4)
					{
						class5.string_0 = (array3[0] ?? "").Trim();
						int num4;
						float num5;
						float num6;
						if (!string.IsNullOrEmpty(class5.string_0) && int.TryParse(array3[1], out num4) && float.TryParse(array3[2], NumberStyles.Float, CultureInfo.InvariantCulture, out num5) && float.TryParse(array3[3], NumberStyles.Float, CultureInfo.InvariantCulture, out num6) && !Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(class5.method_0)))
						{
							Class228.concurrentDictionary_2[class5.string_0] = new Class228.Struct33(class5.string_0, num4, num5, num6, DateTime.UtcNow);
							flag = true;
						}
					}
				}
				if (flag)
				{
					Action action = Class228.action_0;
					if (action == null)
					{
						return;
					}
					action();
					return;
				}
			}
			else if (text == "TRADE" && array.Length >= 5)
			{
				string text6 = (array[2] ?? "").Trim();
				string text7 = (array[3] ?? "").Trim();
				string text8 = (array[4] ?? "").Trim().ToLowerInvariant();
				if (!string.IsNullOrEmpty(text6) && !string.IsNullOrEmpty(text7) && !string.IsNullOrEmpty(text8))
				{
					Class228.smethod_6(text6, text7, text8);
					return;
				}
				return;
			}
			else if (text == "CHIA" && array.Length >= 3)
			{
				string text9 = (array[2] ?? "").Trim().ToUpperInvariant();
				if (text9 == "REQ" && array.Length >= 5)
				{
					Class228.Class234 class6 = new Class228.Class234();
					class6.string_0 = (array[3] ?? "").Trim();
					string text10 = (array[4] ?? "").Trim();
					if (!string.IsNullOrEmpty(class6.string_0) && !string.IsNullOrEmpty(text10))
					{
						Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
						int num7 = 0;
						if (array.Length >= 6)
						{
							foreach (string text11 in (array[5] ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
							{
								int num8 = text11.IndexOf(':');
								if (num8 > 0)
								{
									string text12 = text11.Substring(0, num8).Trim();
									int num9;
									if (int.TryParse(text11.Substring(num8 + 1), out num9))
									{
										if (text12.Equals("vang", StringComparison.OrdinalIgnoreCase))
										{
											num7 = num9;
										}
										else if (!string.IsNullOrEmpty(text12))
										{
											dictionary[text12] = num9;
										}
									}
								}
							}
						}
						Class228.concurrentDictionary_4[text10] = new Class228.Struct31(class6.string_0, text10, dictionary, num7, DateTime.UtcNow);
						IEnumerable<Class106> ienumerable_3 = Class106.IEnumerable_0;
						Func<Class106, bool> func3;
						if ((func3 = class6.func_0) == null)
						{
							func3 = (class6.func_0 = new Func<Class106, bool>(class6.method_0));
						}
						using (IEnumerator<Class106> enumerator = ienumerable_3.Where<Class106>(func3).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Class106 class7 = enumerator.Current;
								class7.Boolean_47 = true;
								if (string.IsNullOrEmpty(class7.String_1))
								{
									class7.String_1 = text10;
								}
							}
							return;
						}
					}
					return;
				}
				if (text9 == "STOP" && array.Length >= 4)
				{
					string text13 = (array[3] ?? "").Trim();
					if (string.IsNullOrEmpty(text13))
					{
						return;
					}
					Class228.Struct31 @struct;
					Class228.concurrentDictionary_4.TryRemove(text13, out @struct);
				}
			}
			return;
		}
		if ((DateTime.UtcNow - Class228.dateTime_3).TotalMilliseconds < 400.0)
		{
			return;
		}
		Class228.dateTime_3 = DateTime.UtcNow;
		Class228.smethod_16();
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
	private static string smethod_5(string string_7, string string_8)
	{
		return Class228.smethod_23(string_7) + ">" + Class228.smethod_23(string_8);
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000AA500 File Offset: 0x000A8700
	private static void smethod_6(string string_7, string string_8, string string_9)
	{
		string text = Class228.smethod_5(string_7, string_8);
		if (!(string_9 == "done") && !(string_9 == "cancel"))
		{
			Class228.concurrentDictionary_3[text] = new Class228.Struct32(string_7, string_8, string_9, DateTime.UtcNow);
			return;
		}
		Class228.Struct32 @struct;
		Class228.concurrentDictionary_3.TryRemove(text, out @struct);
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x000AA558 File Offset: 0x000A8758
	public static void smethod_7(string string_7, string string_8, string string_9)
	{
		if (!string.IsNullOrWhiteSpace(string_7) && !string.IsNullOrWhiteSpace(string_8) && !string.IsNullOrWhiteSpace(string_9))
		{
			Class228.smethod_2();
			string_9 = string_9.Trim().ToLowerInvariant();
			Class228.smethod_6(string_7, string_8, string_9);
			Class238.smethod_3(string.Concat(new string[]
			{
				"#IGOM|TRADE|",
				Class228.smethod_23(string_7),
				"|",
				Class228.smethod_23(string_8),
				"|",
				string_9
			}));
			return;
		}
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x000AA5D8 File Offset: 0x000A87D8
	public static string smethod_8(string string_7, string string_8)
	{
		if (string.IsNullOrWhiteSpace(string_7) || string.IsNullOrWhiteSpace(string_8))
		{
			return "";
		}
		Class228.Struct32 @struct;
		if (!Class228.concurrentDictionary_3.TryGetValue(Class228.smethod_5(string_7, string_8), out @struct))
		{
			return "";
		}
		if ((DateTime.UtcNow - @struct.DateTime_0).TotalSeconds > 45.0)
		{
			Class228.Struct32 struct2;
			Class228.concurrentDictionary_3.TryRemove(Class228.smethod_5(string_7, string_8), out struct2);
			return "";
		}
		return @struct.String_2;
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x000AA65C File Offset: 0x000A885C
	public static bool smethod_9(string string_7, out string string_8)
	{
		string_8 = "";
		if (string.IsNullOrWhiteSpace(string_7))
		{
			return false;
		}
		DateTime utcNow = DateTime.UtcNow;
		foreach (KeyValuePair<string, Class228.Struct32> keyValuePair in Class228.concurrentDictionary_3)
		{
			if ((utcNow - keyValuePair.Value.DateTime_0).TotalSeconds <= 45.0 && string.Equals(keyValuePair.Value.String_1, string_7, StringComparison.OrdinalIgnoreCase) && string.Equals(keyValuePair.Value.String_2, "locked", StringComparison.OrdinalIgnoreCase))
			{
				string_8 = keyValuePair.Value.String_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x000AA730 File Offset: 0x000A8930
	public static void smethod_10(string string_7, string string_8)
	{
		if (!string.IsNullOrWhiteSpace(string_7) && !string.IsNullOrWhiteSpace(string_8))
		{
			Class228.Struct32 @struct;
			Class228.concurrentDictionary_3.TryRemove(Class228.smethod_5(string_7, string_8), out @struct);
			return;
		}
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x000AA764 File Offset: 0x000A8964
	public static void smethod_11(string string_7, string string_8, Dictionary<string, int> dictionary_0, int int_1)
	{
		if (!string.IsNullOrWhiteSpace(string_7) && !string.IsNullOrWhiteSpace(string_8))
		{
			Class228.smethod_2();
			if (dictionary_0 == null)
			{
				dictionary_0 = new Dictionary<string, int>();
			}
			List<string> list = dictionary_0.Where<KeyValuePair<string, int>>(new Func<KeyValuePair<string, int>, bool>(Class228.Class230.f_79571992.method_0)).Select<KeyValuePair<string, int>, string>(new Func<KeyValuePair<string, int>, string>(Class228.Class230.f_79571992.method_1)).ToList<string>();
			list.Insert(0, "vang:" + int_1.ToString());
			string text = string.Join(";", list);
			Class228.concurrentDictionary_4[string_8] = new Class228.Struct31(string_7, string_8, dictionary_0, int_1, DateTime.UtcNow);
			Class238.smethod_3(string.Concat(new string[]
			{
				"#IGOM|CHIA|REQ|",
				Class228.smethod_23(string_7),
				"|",
				Class228.smethod_23(string_8),
				"|",
				text
			}));
			return;
		}
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x000AA864 File Offset: 0x000A8A64
	public static void smethod_12(string string_7)
	{
		if (string.IsNullOrWhiteSpace(string_7))
		{
			return;
		}
		Class228.smethod_2();
		Class228.Struct31 @struct;
		Class228.concurrentDictionary_4.TryRemove(string_7, out @struct);
		Class238.smethod_3("#IGOM|CHIA|STOP|" + Class228.smethod_23(string_7));
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x000AA8A4 File Offset: 0x000A8AA4
	public static bool smethod_13(string string_7, out Class228.Struct31 struct31_0)
	{
		struct31_0 = default(Class228.Struct31);
		if (string.IsNullOrWhiteSpace(string_7))
		{
			return false;
		}
		DateTime utcNow = DateTime.UtcNow;
		Class228.Struct31 @struct = default(Class228.Struct31);
		bool flag = false;
		foreach (KeyValuePair<string, Class228.Struct31> keyValuePair in Class228.concurrentDictionary_4)
		{
			if ((utcNow - keyValuePair.Value.DateTime_0).TotalSeconds <= 30.0 && string.Equals(keyValuePair.Value.String_0, string_7, StringComparison.OrdinalIgnoreCase) && (!flag || keyValuePair.Value.DateTime_0 > @struct.DateTime_0))
			{
				@struct = keyValuePair.Value;
				flag = true;
			}
		}
		if (!flag)
		{
			return false;
		}
		struct31_0 = @struct;
		return true;
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x000AA988 File Offset: 0x000A8B88
	public static bool smethod_14(string string_7)
	{
		Class228.Struct31 @struct;
		return Class228.smethod_13(string_7, out @struct);
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x000AA9A0 File Offset: 0x000A8BA0
	public static void smethod_15()
	{
		Class228.smethod_2();
		if (!Class238.Boolean_0)
		{
			return;
		}
		if ((DateTime.UtcNow - Class228.dateTime_2).TotalMilliseconds < 500.0)
		{
			return;
		}
		Class228.dateTime_2 = DateTime.UtcNow;
		Class238.smethod_3("#IGOM|WHO");
		Class228.smethod_16();
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x000AA9F8 File Offset: 0x000A8BF8
	public static void smethod_16()
	{
		Class228.smethod_2();
		if (!Class238.Boolean_0)
		{
			return;
		}
		List<string> list = Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(Class228.Class230.f_79571992.method_2)).Select<Class106, string>(new Func<Class106, string>(Class228.Class230.f_79571992.method_3)).ToList<string>();
		if (list.Count == 0)
		{
			return;
		}
		Class228.dateTime_0 = DateTime.UtcNow;
		Class238.smethod_3("#IGOM|CHARS|" + string.Join(";", list));
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x000AAA94 File Offset: 0x000A8C94
	public static void smethod_17(string string_7, string string_8)
	{
		if (string.IsNullOrWhiteSpace(string_7))
		{
			return;
		}
		Class228.smethod_2();
		string_8 = (string.IsNullOrWhiteSpace(string_8) ? "vang" : string_8.Trim().ToLowerInvariant());
		Class228.concurrentDictionary_1[string_7] = string_8;
		Class238.smethod_3("#IGOM|NHAN|" + Class228.smethod_23(string_7) + "|" + string_8);
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x000AAAF4 File Offset: 0x000A8CF4
	public static void smethod_18(string string_7)
	{
		if (string.IsNullOrWhiteSpace(string_7))
		{
			return;
		}
		Class228.smethod_2();
		string text;
		Class228.concurrentDictionary_1.TryRemove(string_7, out text);
		Class238.smethod_3("#IGOM|STOP|" + Class228.smethod_23(string_7));
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x000AAB34 File Offset: 0x000A8D34
	public static bool smethod_19(string string_7, out Class228.Struct33 struct33_0)
	{
		struct33_0 = default(Class228.Struct33);
		return !string.IsNullOrWhiteSpace(string_7) && ((Class228.concurrentDictionary_0.TryGetValue(string_7, out struct33_0) && (DateTime.UtcNow - struct33_0.DateTime_0).TotalSeconds <= 30.0) || (Class228.concurrentDictionary_2.TryGetValue(string_7, out struct33_0) && (DateTime.UtcNow - struct33_0.DateTime_0).TotalSeconds <= 30.0));
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x0000F3D1 File Offset: 0x0000D5D1
	public static bool smethod_20(string string_7)
	{
		return !string.IsNullOrWhiteSpace(string_7) && Class228.concurrentDictionary_1.ContainsKey(string_7);
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x000AABBC File Offset: 0x000A8DBC
	public static IReadOnlyList<string> smethod_21()
	{
		Class228.Class235 @class = new Class228.Class235();
		@class.dateTime_0 = DateTime.UtcNow;
		return Class228.concurrentDictionary_2.Where<KeyValuePair<string, Class228.Struct33>>(new Func<KeyValuePair<string, Class228.Struct33>, bool>(@class.method_0)).Select<KeyValuePair<string, Class228.Struct33>, string>(new Func<KeyValuePair<string, Class228.Struct33>, string>(Class228.Class230.f_79571992.method_4)).Where<string>(new Func<string, bool>(Class228.Class230.f_79571992.method_5))
			.OrderBy<string, string>(new Func<string, string>(Class228.Class230.f_79571992.method_6))
			.ToList<string>();
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x000AAC64 File Offset: 0x000A8E64
	public static void smethod_22()
	{
		Class228.smethod_2();
		if (!Class238.Boolean_0)
		{
			return;
		}
		bool flag = Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(Class228.Class230.f_79571992.method_7));
		bool flag2;
		if (!flag)
		{
			flag2 = Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(Class228.Class230.f_79571992.method_8));
		}
		else
		{
			flag2 = true;
		}
		bool flag3 = flag2;
		DateTime utcNow = DateTime.UtcNow;
		if (flag && (utcNow - Class228.dateTime_1).TotalSeconds >= 3.0)
		{
			Class228.dateTime_1 = utcNow;
			foreach (Class106 @class in Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(Class228.Class230.f_79571992.method_9)))
			{
				if (!string.IsNullOrWhiteSpace(@class.Class527_0.String_11))
				{
					Class238.smethod_3(string.Concat(new string[]
					{
						"#IGOM|POS|",
						Class228.smethod_23(@class.Class527_0.String_11),
						"|",
						@class.Class527_0.Int32_35.ToString(),
						"|",
						@class.Int32_16.ToString(CultureInfo.InvariantCulture),
						"|",
						@class.Int32_17.ToString(CultureInfo.InvariantCulture)
					}));
				}
			}
		}
		if (flag3 && (utcNow - Class228.dateTime_0).TotalSeconds >= 5.0)
		{
			Class228.smethod_16();
			return;
		}
		if (Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(Class228.Class230.f_79571992.method_10)) && (utcNow - Class228.dateTime_4).TotalSeconds >= 12.0)
		{
			Class228.dateTime_4 = utcNow;
			Class228.smethod_16();
		}
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x000AAE8C File Offset: 0x000A908C
	private static string smethod_23(string string_7)
	{
		return (string_7 ?? "").Replace("|", "").Replace(";", "").Replace(":", "")
			.Replace("\t", "")
			.Replace("\r", "")
			.Replace("\n", "")
			.Trim();
	}

	// Token: 0x04000CB4 RID: 3252
	public const string string_0 = "#IGOM";

	// Token: 0x04000CB5 RID: 3253
	private static readonly ConcurrentDictionary<string, Class228.Struct33> concurrentDictionary_0 = new ConcurrentDictionary<string, Class228.Struct33>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04000CB6 RID: 3254
	private static readonly ConcurrentDictionary<string, string> concurrentDictionary_1 = new ConcurrentDictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04000CB7 RID: 3255
	private static readonly ConcurrentDictionary<string, Class228.Struct33> concurrentDictionary_2 = new ConcurrentDictionary<string, Class228.Struct33>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04000CB8 RID: 3256
	private static readonly ConcurrentDictionary<string, Class228.Struct32> concurrentDictionary_3 = new ConcurrentDictionary<string, Class228.Struct32>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04000CB9 RID: 3257
	private static readonly ConcurrentDictionary<string, Class228.Struct31> concurrentDictionary_4 = new ConcurrentDictionary<string, Class228.Struct31>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04000CBA RID: 3258
	private static DateTime dateTime_0 = DateTime.MinValue;

	// Token: 0x04000CBB RID: 3259
	private static DateTime dateTime_1 = DateTime.MinValue;

	// Token: 0x04000CBC RID: 3260
	private static DateTime dateTime_2 = DateTime.MinValue;

	// Token: 0x04000CBD RID: 3261
	private static DateTime dateTime_3 = DateTime.MinValue;

	// Token: 0x04000CBE RID: 3262
	private static DateTime dateTime_4 = DateTime.MinValue;

	// Token: 0x04000CBF RID: 3263
	private static int int_0;

	// Token: 0x04000CC0 RID: 3264
	public const string string_1 = "apply";

	// Token: 0x04000CC1 RID: 3265
	public const string string_2 = "open";

	// Token: 0x04000CC2 RID: 3266
	public const string string_3 = "locked";

	// Token: 0x04000CC3 RID: 3267
	public const string string_4 = "accept";

	// Token: 0x04000CC4 RID: 3268
	public const string string_5 = "done";

	// Token: 0x04000CC5 RID: 3269
	public const string string_6 = "cancel";

	// Token: 0x04000CC6 RID: 3270
	[CompilerGenerated]
	private static Action action_0;

	// Token: 0x02000150 RID: 336
	internal readonly struct Struct31
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public Struct31(string string_2, string string_3, Dictionary<string, int> dictionary_1, int int_1, DateTime dateTime_1)
		{
			this = default;
			this.String_0 = string_2;
			this.String_1 = string_3;
			this.Dictionary_0 = dictionary_1 ?? new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			this.Int32_0 = int_1;
			this.DateTime_0 = dateTime_1;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x0000F41D File Offset: 0x0000D61D
		public string String_0 { get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x0000F425 File Offset: 0x0000D625
		public string String_1 { get; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0000F42D File Offset: 0x0000D62D
		public Dictionary<string, int> Dictionary_0 { get; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0000F435 File Offset: 0x0000D635
		public int Int32_0 { get; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0000F43D File Offset: 0x0000D63D
		public DateTime DateTime_0 { get; }

		// Token: 0x04000CC7 RID: 3271
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x04000CC8 RID: 3272
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x04000CC9 RID: 3273
		[CompilerGenerated]
		private readonly Dictionary<string, int> dictionary_0;

		// Token: 0x04000CCA RID: 3274
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x04000CCB RID: 3275
		[CompilerGenerated]
		private readonly DateTime dateTime_0;
	}

	// Token: 0x02000151 RID: 337
	internal readonly struct Struct32
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x0000F445 File Offset: 0x0000D645
		public Struct32(string string_3, string string_4, string string_5, DateTime dateTime_1)
		{
			this = default;
			this.String_0 = string_3;
			this.String_1 = string_4;
			this.String_2 = string_5;
			this.DateTime_0 = dateTime_1;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0000F464 File Offset: 0x0000D664
		public string String_0 { get; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0000F46C File Offset: 0x0000D66C
		public string String_1 { get; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0000F474 File Offset: 0x0000D674
		public string String_2 { get; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0000F47C File Offset: 0x0000D67C
		public DateTime DateTime_0 { get; }

		// Token: 0x04000CCC RID: 3276
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x04000CCD RID: 3277
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x04000CCE RID: 3278
		[CompilerGenerated]
		private readonly string string_2;

		// Token: 0x04000CCF RID: 3279
		[CompilerGenerated]
		private readonly DateTime dateTime_0;
	}

	// Token: 0x02000152 RID: 338
	internal readonly struct Struct33
	{
		// Token: 0x06001576 RID: 5494 RVA: 0x0000F484 File Offset: 0x0000D684
		public Struct33(string string_1, int int_1, float float_2, float float_3, DateTime dateTime_1)
		{
			this = default;
			this.String_0 = string_1;
			this.Int32_0 = int_1;
			this.Single_0 = float_2;
			this.Single_1 = float_3;
			this.DateTime_0 = dateTime_1;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0000F4AB File Offset: 0x0000D6AB
		public string String_0 { get; }

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0000F4B3 File Offset: 0x0000D6B3
		public int Int32_0 { get; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0000F4BB File Offset: 0x0000D6BB
		public float Single_0 { get; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0000F4C3 File Offset: 0x0000D6C3
		public float Single_1 { get; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0000F4CB File Offset: 0x0000D6CB
		public DateTime DateTime_0 { get; }

		// Token: 0x04000CD0 RID: 3280
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x04000CD1 RID: 3281
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x04000CD2 RID: 3282
		[CompilerGenerated]
		private readonly float float_0;

		// Token: 0x04000CD3 RID: 3283
		[CompilerGenerated]
		private readonly float float_1;

		// Token: 0x04000CD4 RID: 3284
		[CompilerGenerated]
		private readonly DateTime dateTime_0;
	}

	// Token: 0x02000153 RID: 339
	[CompilerGenerated]
	private static class Class229
	{
		// Token: 0x04000CD5 RID: 3285
		public static Action<string, string, string> action_0;
	}

	// Token: 0x02000154 RID: 340
	[CompilerGenerated]
	[Serializable]
	private sealed class Class230
	{
		// Token: 0x0600157E RID: 5502 RVA: 0x0000F4DF File Offset: 0x0000D6DF
		internal bool method_0(KeyValuePair<string, int> keyValuePair_0)
		{
			return !string.IsNullOrWhiteSpace(keyValuePair_0.Key);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000AAF90 File Offset: 0x000A9190
		internal string method_1(KeyValuePair<string, int> keyValuePair_0)
		{
			return Class228.smethod_23(keyValuePair_0.Key) + ":" + keyValuePair_0.Value.ToString();
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		internal bool method_2(Class106 class106_0)
		{
			return !string.IsNullOrWhiteSpace(class106_0.Class527_0.String_11);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000AAFC4 File Offset: 0x000A91C4
		internal string method_3(Class106 class106_0)
		{
			return string.Concat(new string[]
			{
				Class228.smethod_23(class106_0.Class527_0.String_11),
				":",
				class106_0.Class527_0.Int32_35.ToString(),
				":",
				class106_0.Int32_16.ToString(CultureInfo.InvariantCulture),
				":",
				class106_0.Int32_17.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0000F505 File Offset: 0x0000D705
		internal string method_4(KeyValuePair<string, Class228.Struct33> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x000AB04C File Offset: 0x000A924C
		internal bool method_5(string string_0)
		{
			Class228.Class236 @class = new Class228.Class236();
			@class.string_0 = string_0;
			return !Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(@class.method_0));
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0000B939 File Offset: 0x00009B39
		internal string method_6(string string_0)
		{
			return string_0;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0000F50E File Offset: 0x0000D70E
		internal bool method_7(Class106 class106_0)
		{
			return class106_0.Boolean_46 || class106_0.Boolean_47 || Class228.concurrentDictionary_1.ContainsKey(class106_0.Class527_0.String_11 ?? "");
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000AB080 File Offset: 0x000A9280
		internal bool method_8(Class106 class106_0)
		{
			Class228.Class237 @class = new Class228.Class237();
			@class.class106_0 = class106_0;
			return (!string.IsNullOrEmpty(@class.class106_0.String_19) && !Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(@class.method_0))) || (@class.class106_0.List_5.Contains(Enum17.ChiaDo) && !string.IsNullOrEmpty(@class.class106_0.String_20) && !Class106.IEnumerable_0.Any<Class106>(new Func<Class106, bool>(@class.method_1)));
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000F50E File Offset: 0x0000D70E
		internal bool method_9(Class106 class106_0)
		{
			return class106_0.Boolean_46 || class106_0.Boolean_47 || Class228.concurrentDictionary_1.ContainsKey(class106_0.Class527_0.String_11 ?? "");
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		internal bool method_10(Class106 class106_0)
		{
			return !string.IsNullOrWhiteSpace(class106_0.Class527_0.String_11);
		}

		// Token: 0x04000CD6 RID: 3286
		public static readonly Class228.Class230 f_79571992 = new Class228.Class230();

		// Token: 0x04000CD7 RID: 3287
		public static Func<KeyValuePair<string, int>, bool> f_A4FFCD76;

		// Token: 0x04000CD8 RID: 3288
		public static Func<KeyValuePair<string, int>, string> f_BACE2EA6;

		// Token: 0x04000CD9 RID: 3289
		public static Func<Class106, bool> f_66248C53;

		// Token: 0x04000CDA RID: 3290
		public static Func<Class106, string> f_102153AF;

		// Token: 0x04000CDB RID: 3291
		public static Func<KeyValuePair<string, Class228.Struct33>, string> f_6F2F8D05;

		// Token: 0x04000CDC RID: 3292
		public static Func<string, bool> f_D5B3CA25;

		// Token: 0x04000CDD RID: 3293
		public static Func<string, string> f_EAF0B1C4;

		// Token: 0x04000CDE RID: 3294
		public static Func<Class106, bool> f_0715747D;

		// Token: 0x04000CDF RID: 3295
		public static Func<Class106, bool> f_2B8FAA5D;

		// Token: 0x04000CE0 RID: 3296
		public static Func<Class106, bool> f_1FC688CE;

		// Token: 0x04000CE1 RID: 3297
		public static Func<Class106, bool> f_7F20ED68;
	}

	// Token: 0x02000155 RID: 341
	[CompilerGenerated]
	private sealed class Class231
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x0000F540 File Offset: 0x0000D740
		internal bool method_0(Class106 class106_0)
		{
			return string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CE2 RID: 3298
		public string string_0;

		// Token: 0x04000CE3 RID: 3299
		public Func<Class106, bool> func_0;
	}

	// Token: 0x02000156 RID: 342
	[CompilerGenerated]
	private sealed class Class232
	{
		// Token: 0x0600158C RID: 5516 RVA: 0x0000F559 File Offset: 0x0000D759
		internal bool method_0(Class106 class106_0)
		{
			return string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CE4 RID: 3300
		public string string_0;

		// Token: 0x04000CE5 RID: 3301
		public Func<Class106, bool> func_0;
	}

	// Token: 0x02000157 RID: 343
	[CompilerGenerated]
	private sealed class Class233
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x0000F572 File Offset: 0x0000D772
		internal bool method_0(Class106 class106_0)
		{
			return string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CE6 RID: 3302
		public string string_0;
	}

	// Token: 0x02000158 RID: 344
	[CompilerGenerated]
	private sealed class Class234
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x0000F58B File Offset: 0x0000D78B
		internal bool method_0(Class106 class106_0)
		{
			return string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CE7 RID: 3303
		public string string_0;

		// Token: 0x04000CE8 RID: 3304
		public Func<Class106, bool> func_0;
	}

	// Token: 0x02000159 RID: 345
	[CompilerGenerated]
	private sealed class Class235
	{
		// Token: 0x06001592 RID: 5522 RVA: 0x000AB10C File Offset: 0x000A930C
		internal bool method_0(KeyValuePair<string, Class228.Struct33> keyValuePair_0)
		{
			return (this.dateTime_0 - keyValuePair_0.Value.DateTime_0).TotalSeconds <= 60.0;
		}

		// Token: 0x04000CE9 RID: 3305
		public DateTime dateTime_0;
	}

	// Token: 0x0200015A RID: 346
	[CompilerGenerated]
	private sealed class Class236
	{
		// Token: 0x06001594 RID: 5524 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		internal bool method_0(Class106 class106_0)
		{
			return string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CEA RID: 3306
		public string string_0;
	}

	// Token: 0x0200015B RID: 347
	[CompilerGenerated]
	private sealed class Class237
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x0000F5BD File Offset: 0x0000D7BD
		internal bool method_0(Class106 class106_1)
		{
			return string.Equals(class106_1.Class527_0.String_11, this.class106_0.String_19, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0000F5DB File Offset: 0x0000D7DB
		internal bool method_1(Class106 class106_1)
		{
			return string.Equals(class106_1.Class527_0.String_11, this.class106_0.String_20, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CEB RID: 3307
		public Class106 class106_0;
	}
}
