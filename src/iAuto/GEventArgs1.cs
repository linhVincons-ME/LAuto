using System;

// Token: 0x02000013 RID: 19
public class GEventArgs1 : EventArgs
{
	// Token: 0x06000088 RID: 136 RVA: 0x0000373B File Offset: 0x0000193B
	internal GEventArgs1(string string_1)
		: this(string_1, null)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003745 File Offset: 0x00001945
	internal GEventArgs1(string string_1, Exception exception_1)
	{
		this.string_0 = string_1;
		this.exception_0 = exception_1;
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600008A RID: 138 RVA: 0x0000375B File Offset: 0x0000195B
	public Exception Exception_0
	{
		get
		{
			return this.exception_0;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600008B RID: 139 RVA: 0x00003763 File Offset: 0x00001963
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x04000071 RID: 113
	private Exception exception_0;

	// Token: 0x04000072 RID: 114
	private string string_0;
}
