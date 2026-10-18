using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200013A RID: 314
internal class Class210
{
	// Token: 0x06001220 RID: 4640 RVA: 0x000A581C File Offset: 0x000A3A1C
	public Class210(string string_1)
	{
		using (StringReader stringReader = new StringReader(string_1))
		{
			string text = "ROOT";
			string text2;
			while ((text2 = stringReader.ReadLine()) != null)
			{
				if (!string.IsNullOrWhiteSpace(text2))
				{
					if (text2.StartsWith("[") && text2.EndsWith("]"))
					{
						text = text2.Substring(1, text2.Length - 2);
						if (!this.dictionary_0.ContainsKey(text))
						{
							this.dictionary_0[text] = new Dictionary<string, string>();
						}
					}
					else
					{
						string[] array = text2.Split(new char[] { '=' }, 2);
						if (array.Length == 2)
						{
							this.dictionary_0[text ?? "ROOT"][array[0].Trim()] = array[1].Replace("\\n", "\r\n");
						}
					}
				}
			}
		}
	}

	// Token: 0x17000322 RID: 802
	public IEnumerable<ValueTuple<string, string>> this[string string_1]
	{
		get
		{
			if (this.dictionary_0.ContainsKey(string_1))
			{
				return this.dictionary_0[string_1].Select<KeyValuePair<string, string>, ValueTuple<string, string>>(new Func<KeyValuePair<string, string>, ValueTuple<string, string>>(Class210.Class211.f_CEBAE63B.method_0));
			}
			return Enumerable.Empty<ValueTuple<string, string>>();
		}
				set
		{
			if (value != null && value.Count<ValueTuple<string, string>>() != 0)
			{
				Dictionary<string, string> dictionary = (this.dictionary_0.ContainsKey(string_1) ? this.dictionary_0[string_1] : new Dictionary<string, string>());
				foreach (ValueTuple<string, string> valueTuple in value)
				{
					string item = valueTuple.Item1;
					string item2 = valueTuple.Item2;
					dictionary[item] = item2;
				}
				this.dictionary_0[string_1] = dictionary;
				return;
			}
			this.dictionary_0.Remove(string_1);
		}
	}

	// Token: 0x17000323 RID: 803
	public string this[string string_1, string string_2]
	{
		get
		{
			if (this.dictionary_0.ContainsKey(string_1) && this.dictionary_0[string_1].ContainsKey(string_2))
			{
				return this.dictionary_0[string_1][string_2];
			}
			return string.Empty;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				if (this.dictionary_0.ContainsKey(string_1))
				{
					this.dictionary_0[string_1].Remove(string_2);
				}
				return;
			}
			if (!this.dictionary_0.ContainsKey(string_1))
			{
				this.dictionary_0[string_1] = new Dictionary<string, string>();
			}
			this.dictionary_0[string_1][string_2] = value;
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06001225 RID: 4645 RVA: 0x0000DBCE File Offset: 0x0000BDCE
	public IEnumerable<string> IEnumerable_0
	{
		get
		{
			return this.dictionary_0.Keys;
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x06001226 RID: 4646 RVA: 0x0000DBDB File Offset: 0x0000BDDB
	// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000DBE3 File Offset: 0x0000BDE3
	public string String_0 { get; set; }

	// Token: 0x06001228 RID: 4648 RVA: 0x000A5A78 File Offset: 0x000A3C78
	public static Class210 smethod_0(string string_1)
	{
		Class210 @class = new Class210(string.Empty);
		@class.String_0 = string_1;
		if (!File.Exists(string_1))
		{
			return @class;
		}
		using (StreamReader streamReader = new StreamReader(string_1))
		{
			string text = null;
			string text2;
			while ((text2 = streamReader.ReadLine()) != null)
			{
				if (!string.IsNullOrWhiteSpace(text2))
				{
					if (text2.StartsWith("[") && text2.EndsWith("]"))
					{
						text = text2.Substring(1, text2.Length - 2);
						if (!@class.dictionary_0.ContainsKey(text))
						{
							@class.dictionary_0[text] = new Dictionary<string, string>();
						}
					}
					else
					{
						string[] array = text2.Split(new char[] { '=' }, 2);
						if (array.Length == 2)
						{
							@class.dictionary_0[text ?? "ROOT"][array[0].Trim()] = array[1].Replace("\\n", "\r\n");
						}
					}
				}
			}
		}
		return @class;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x000A5B80 File Offset: 0x000A3D80
	public void method_0(string string_1 = null)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			string_1 = this.String_0;
		}
		try
		{
			File.WriteAllText(string_1, this.ToString());
		}
		catch
		{
		}
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x000A5BC0 File Offset: 0x000A3DC0
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.dictionary_0)
		{
			stringBuilder.AppendLine("[" + keyValuePair.Key + "]");
			foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
			{
				stringBuilder.AppendLine(keyValuePair2.Key + "=" + keyValuePair2.Value.Replace("\r", "").Replace("\n", "\\n"));
			}
			stringBuilder.AppendLine();
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000A86 RID: 2694
	private readonly Dictionary<string, Dictionary<string, string>> dictionary_0 = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x04000A87 RID: 2695
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0200013B RID: 315
	[CompilerGenerated]
	[Serializable]
	private sealed class Class211
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		internal ValueTuple<string, string> method_0(KeyValuePair<string, string> keyValuePair_0)
		{
			return new ValueTuple<string, string>(keyValuePair_0.Key, keyValuePair_0.Value);
		}

		// Token: 0x04000A88 RID: 2696
		public static readonly Class210.Class211 f_CEBAE63B = new Class210.Class211();

		// Token: 0x04000A89 RID: 2697
		public static Func<KeyValuePair<string, string>, ValueTuple<string, string>> f_DCC3D9E5;
	}
}
