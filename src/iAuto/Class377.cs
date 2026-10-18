using System;
using System.Text.RegularExpressions;

// Token: 0x0200023A RID: 570
internal class Class377
{
	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00014C93 File Offset: 0x00012E93
	public Regex Regex_0
	{
		get
		{
			if (this.regex_0 == null)
			{
				this.regex_0 = new Regex(this.string_0, Class379.RegexOptions_0 | this.regexOptions_0);
			}
			return this.regex_0;
		}
	}

	// Token: 0x04001340 RID: 4928
	public RegexOptions regexOptions_0;

	// Token: 0x04001341 RID: 4929
	public string string_0;

	// Token: 0x04001342 RID: 4930
	private Regex regex_0;

	// Token: 0x04001343 RID: 4931
	public Class368 class368_0;
}
