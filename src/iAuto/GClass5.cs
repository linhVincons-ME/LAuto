using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

// Token: 0x02000025 RID: 37
public class GClass5
{
	// Token: 0x06000143 RID: 323 RVA: 0x00003E3D File Offset: 0x0000203D
	internal GClass5(GEnum3 genum3_1, StackFrame stackFrame_1, string string_1)
	{
		this.genum3_0 = genum3_1;
		this.stackFrame_0 = stackFrame_1;
		this.string_0 = string_1 ?? string.Empty;
		this.dateTime_0 = DateTime.Now;
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00003E6E File Offset: 0x0000206E
	public StackFrame StackFrame_0
	{
		get
		{
			return this.stackFrame_0;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000145 RID: 325 RVA: 0x00003E76 File Offset: 0x00002076
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000146 RID: 326 RVA: 0x00003E7E File Offset: 0x0000207E
	public GEnum3 GEnum3_0
	{
		get
		{
			return this.genum3_0;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00003E86 File Offset: 0x00002086
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00020DC8 File Offset: 0x0001EFC8
	public override string ToString()
	{
		string text = string.Format("{0}|{1,-5}|", this.dateTime_0, this.genum3_0);
		MethodBase method = this.stackFrame_0.GetMethod();
		Type declaringType = method.DeclaringType;
		string text2 = string.Format("{0}{1}.{2}|", text, declaringType.Name, method.Name);
		string[] array = this.string_0.Replace("\r\n", "\n").TrimEnd(new char[] { '\n' }).Split(new char[] { '\n' });
		if (array.Length <= 1)
		{
			return string.Format("{0}{1}", text2, this.string_0);
		}
		StringBuilder stringBuilder = new StringBuilder(string.Format("{0}{1}\n", text2, array[0]), 64);
		string text3 = string.Format("{{0,{0}}}{{1}}\n", text.Length);
		for (int i = 1; i < array.Length; i++)
		{
			stringBuilder.AppendFormat(text3, "", array[i]);
		}
		StringBuilder stringBuilder2 = stringBuilder;
		int length = stringBuilder2.Length;
		stringBuilder2.Length = length - 1;
		return stringBuilder.ToString();
	}

	// Token: 0x040000BC RID: 188
	private StackFrame stackFrame_0;

	// Token: 0x040000BD RID: 189
	private DateTime dateTime_0;

	// Token: 0x040000BE RID: 190
	private GEnum3 genum3_0;

	// Token: 0x040000BF RID: 191
	private string string_0;
}
