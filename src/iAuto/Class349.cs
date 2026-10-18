using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x02000215 RID: 533
internal class Class349
{
	// Token: 0x06001D4A RID: 7498 RVA: 0x000DFF5C File Offset: 0x000DE15C
	public Class349(Keys keys_1, FCTBAction fctbaction_1)
	{
		KeyEventArgs e = new KeyEventArgs(keys_1);
		this.bool_1 = e.Control;
		this.bool_2 = e.Shift;
		this.bool_0 = e.Alt;
		this.Keys_0 = e.KeyCode;
		this.FCTBAction_0 = fctbaction_1;
	}

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x06001D4B RID: 7499 RVA: 0x000DFFB0 File Offset: 0x000DE1B0
	// (set) Token: 0x06001D4C RID: 7500 RVA: 0x000E0018 File Offset: 0x000DE218
	public string String_0
	{
		get
		{
			string text = "";
			if (this.bool_1)
			{
				text += "Ctrl + ";
			}
			if (this.bool_2)
			{
				text += "Shift + ";
			}
			if (this.bool_0)
			{
				text += "Alt + ";
			}
			return text.Trim(new char[] { ' ', '+' });
		}
		set
		{
			if (value == null)
			{
				this.bool_2 = false;
				this.bool_0 = false;
				this.bool_1 = false;
				return;
			}
			this.bool_1 = value.Contains("Ctrl");
			this.bool_2 = value.Contains("Shift");
			this.bool_0 = value.Contains("Alt");
		}
	}

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00013D60 File Offset: 0x00011F60
	// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00013D68 File Offset: 0x00011F68
	public Keys Keys_0 { get; set; }

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00013D71 File Offset: 0x00011F71
	// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00013D79 File Offset: 0x00011F79
	public FCTBAction FCTBAction_0 { get; set; }

	// Token: 0x06001D51 RID: 7505 RVA: 0x000E0074 File Offset: 0x000DE274
	public Keys method_0()
	{
		Keys keys = this.Keys_0;
		if (this.bool_1)
		{
			keys |= Keys.Control;
		}
		if (this.bool_0)
		{
			keys |= Keys.Alt;
		}
		if (this.bool_2)
		{
			keys |= Keys.Shift;
		}
		return keys;
	}

	// Token: 0x0400126E RID: 4718
	private bool bool_0;

	// Token: 0x0400126F RID: 4719
	private bool bool_1;

	// Token: 0x04001270 RID: 4720
	private bool bool_2;

	// Token: 0x04001271 RID: 4721
	[CompilerGenerated]
	private Keys keys_0;

	// Token: 0x04001272 RID: 4722
	[CompilerGenerated]
	private FCTBAction fctbaction_0;
}
