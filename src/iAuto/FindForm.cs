using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x0200020C RID: 524
internal partial class FindForm : Form
{
	// Token: 0x06001CDE RID: 7390 RVA: 0x000138D3 File Offset: 0x00011AD3
	public FindForm(Control3 control3_1)
	{
		this.InitializeComponent();
		this.control3_0 = control3_1;
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x000138EF File Offset: 0x00011AEF
	private void btClose_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x000138F7 File Offset: 0x00011AF7
	private void btFindNext_Click(object sender, EventArgs e)
	{
		this.vmethod_0(this.tbFind.Text);
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x000DDA4C File Offset: 0x000DBC4C
	public virtual void vmethod_0(string string_0)
	{
		try
		{
			RegexOptions regexOptions = (this.cbMatchCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
			if (!this.cbRegex.Checked)
			{
				string_0 = Regex.Escape(string_0);
			}
			if (this.cbWholeWord.Checked)
			{
				string_0 = "\\b" + string_0 + "\\b";
			}
			Class357 @class = this.control3_0.Class357_5.method_6();
			@class.method_40();
			if (this.bool_0)
			{
				this.gstruct19_0 = @class.GStruct19_0;
				this.bool_0 = false;
			}
			@class.GStruct19_0 = @class.GStruct19_1;
			if (GStruct19.smethod_5(@class.GStruct19_0, this.gstruct19_0))
			{
				@class.GStruct19_1 = new GStruct19(this.control3_0.method_23(this.control3_0.Int32_14 - 1), this.control3_0.Int32_14 - 1);
			}
			else
			{
				@class.GStruct19_1 = this.gstruct19_0;
			}
			using (IEnumerator<Class357> enumerator = @class.method_30(string_0, regexOptions).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					Class357 class2 = enumerator.Current;
					this.control3_0.Class357_5 = class2;
					this.control3_0.method_51();
					this.control3_0.method_4();
					return;
				}
			}
			if (GStruct19.smethod_5(@class.GStruct19_0, this.gstruct19_0) && GStruct19.smethod_4(this.gstruct19_0, GStruct19.GStruct19_0))
			{
				this.control3_0.Class357_5.GStruct19_0 = new GStruct19(0, 0);
				this.vmethod_0(string_0);
			}
			else
			{
				MessageBox.Show("Not found");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x0001390A File Offset: 0x00011B0A
	private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			this.btFindNext.PerformClick();
			e.Handled = true;
			return;
		}
		if (e.KeyChar == '\u001b')
		{
			base.Hide();
			e.Handled = true;
		}
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x00013940 File Offset: 0x00011B40
	private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (e.CloseReason == CloseReason.UserClosing)
		{
			e.Cancel = true;
			base.Hide();
		}
		this.control3_0.Focus();
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x00013964 File Offset: 0x00011B64
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData == Keys.Escape)
		{
			base.Close();
			return true;
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x0001397B File Offset: 0x00011B7B
	protected override void OnActivated(EventArgs e)
	{
		this.tbFind.Focus();
		this.method_0();
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x0001398F File Offset: 0x00011B8F
	private void method_0()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00013998 File Offset: 0x00011B98
	private void cbWholeWord_CheckedChanged(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x040011EB RID: 4587
	private readonly Control3 control3_0;

	// Token: 0x040011EC RID: 4588
	private bool bool_0 = true;

	// Token: 0x040011ED RID: 4589
	private GStruct19 gstruct19_0;
}
