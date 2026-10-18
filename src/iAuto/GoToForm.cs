using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200020D RID: 525
internal partial class GoToForm : Form
{
	// Token: 0x06001CEA RID: 7402 RVA: 0x000139BF File Offset: 0x00011BBF
	public GoToForm()
	{
		this.InitializeComponent();
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000139CD File Offset: 0x00011BCD
	// (set) Token: 0x06001CEC RID: 7404 RVA: 0x000139D5 File Offset: 0x00011BD5
	public int Int32_0 { get; set; }

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x06001CED RID: 7405 RVA: 0x000139DE File Offset: 0x00011BDE
	// (set) Token: 0x06001CEE RID: 7406 RVA: 0x000139E6 File Offset: 0x00011BE6
	public int Int32_1 { get; set; }

	// Token: 0x06001CEF RID: 7407 RVA: 0x000DE0C4 File Offset: 0x000DC2C4
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		this.tbLineNumber.Text = this.Int32_0.ToString();
		this.label.Text = string.Format("Line number (1 - {0}):", this.Int32_1);
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x000139EF File Offset: 0x00011BEF
	protected override void OnShown(EventArgs e)
	{
		base.OnShown(e);
		this.tbLineNumber.Focus();
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x000DE114 File Offset: 0x000DC314
	private void btnOk_Click(object sender, EventArgs e)
	{
		int num;
		if (int.TryParse(this.tbLineNumber.Text, out num))
		{
			num = Math.Min(num, this.Int32_1);
			num = Math.Max(1, num);
			this.Int32_0 = num;
		}
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x00013A04 File Offset: 0x00011C04
	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	// Token: 0x040011F6 RID: 4598
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040011F7 RID: 4599
	[CompilerGenerated]
	private int int_1;
}
