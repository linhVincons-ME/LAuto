using System;
using System.Collections.Specialized;
using System.Text;

// Token: 0x02000085 RID: 133
internal sealed class Class72 : NameValueCollection
{
	// Token: 0x060005D3 RID: 1491 RVA: 0x00006F3A File Offset: 0x0000513A
	public Class72()
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00006F42 File Offset: 0x00005142
	public Class72(int int_0)
		: base(int_0)
	{
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00006F4B File Offset: 0x0000514B
	public static Class72 smethod_0(string string_0)
	{
		return Class72.smethod_1(string_0, Encoding.UTF8);
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x000318B0 File Offset: 0x0002FAB0
	public static Class72 smethod_1(string string_0, Encoding encoding_0)
	{
		if (string_0 == null)
		{
			return new Class72(1);
		}
		if (string_0.Length == 0)
		{
			return new Class72(1);
		}
		if (string_0 == "?")
		{
			return new Class72(1);
		}
		if (string_0[0] == '?')
		{
			string_0 = string_0.Substring(1);
		}
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.UTF8;
		}
		Class72 @class = new Class72();
		foreach (string text in string_0.Split(new char[] { '&' }))
		{
			int length = text.Length;
			if (length != 0 && !(text == "="))
			{
				int num = text.IndexOf('=');
				if (num < 0)
				{
					@class.Add(null, Class71.smethod_34(text, encoding_0));
				}
				else if (num == 0)
				{
					@class.Add(null, Class71.smethod_34(text.Substring(1), encoding_0));
				}
				else
				{
					string text2 = Class71.smethod_34(text.Substring(0, num), encoding_0);
					int num2 = num + 1;
					string text3 = ((num2 < length) ? Class71.smethod_34(text.Substring(num2), encoding_0) : string.Empty);
					@class.Add(text2, text3);
				}
			}
		}
		return @class;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x000319D4 File Offset: 0x0002FBD4
	public override string ToString()
	{
		if (this.Count == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string text in this.AllKeys)
		{
			stringBuilder.AppendFormat("{0}={1}&", text, base[text]);
		}
		if (stringBuilder.Length > 0)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			int i = stringBuilder2.Length;
			stringBuilder2.Length = i - 1;
		}
		return stringBuilder.ToString();
	}
}
