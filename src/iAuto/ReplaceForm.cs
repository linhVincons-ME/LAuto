using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x0200022F RID: 559
internal partial class ReplaceForm : Form
{
	// Token: 0x06001E72 RID: 7794 RVA: 0x00014912 File Offset: 0x00012B12
	public ReplaceForm(Control3 control3_1)
	{
		this.InitializeComponent();
		this.control3_0 = control3_1;
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x000138EF File Offset: 0x00011AEF
	private void btClose_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x000E4584 File Offset: 0x000E2784
	private void btFindNext_Click(object sender, EventArgs e)
	{
		try
		{
			if (!this.method_1(this.tbFind.Text))
			{
				MessageBox.Show("Not found");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000E45D0 File Offset: 0x000E27D0
	public List<Class357> method_0(string string_0)
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
		return (this.control3_0.Class357_5.Boolean_2 ? this.control3_0.Class357_6.method_6() : this.control3_0.Class357_5.method_6()).method_30(string_0, regexOptions).ToList<Class357>();
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x000E4664 File Offset: 0x000E2864
	public bool method_1(string string_0)
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
				this.control3_0.Class357_5.GStruct19_0 = class2.GStruct19_0;
				this.control3_0.Class357_5.GStruct19_1 = class2.GStruct19_1;
				this.control3_0.method_51();
				this.control3_0.method_4();
				return true;
			}
		}
		if (GStruct19.smethod_5(@class.GStruct19_0, this.gstruct19_0) && GStruct19.smethod_4(this.gstruct19_0, GStruct19.GStruct19_0))
		{
			this.control3_0.Class357_5.GStruct19_0 = new GStruct19(0, 0);
			return this.method_1(string_0);
		}
		return false;
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x0001492E File Offset: 0x00012B2E
	private void tbReplace_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			this.btFindNext_Click(sender, null);
		}
		if (e.KeyChar == '\u001b')
		{
			base.Hide();
		}
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x00013964 File Offset: 0x00011B64
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData == Keys.Escape)
		{
			base.Close();
			return true;
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x00014952 File Offset: 0x00012B52
	private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (e.CloseReason == CloseReason.UserClosing)
		{
			e.Cancel = true;
			base.Hide();
		}
		this.control3_0.Focus();
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000E4810 File Offset: 0x000E2A10
	private void btReplace_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.control3_0.Int32_17 != 0 && !this.control3_0.Class357_5.Boolean_1)
			{
				this.control3_0.vmethod_20(this.tbReplace.Text);
			}
			this.btFindNext_Click(sender, null);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x000E487C File Offset: 0x000E2A7C
	private void btReplaceAll_Click(object sender, EventArgs e)
	{
		try
		{
			this.control3_0.Class357_5.method_38();
			List<Class357> list = this.method_0(this.tbFind.Text);
			bool flag = false;
			using (List<Class357>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Boolean_1)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag && list.Count > 0)
			{
				this.control3_0.Class381_0.Class312_0.vmethod_0(new Class318(this.control3_0.Class381_0, list, this.tbReplace.Text));
				this.control3_0.Class357_5.GStruct19_0 = new GStruct19(0, 0);
			}
			this.control3_0.method_4();
			MessageBox.Show(list.Count.ToString() + " occurrence(s) replaced");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		this.control3_0.Class357_5.method_39();
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x00014976 File Offset: 0x00012B76
	protected override void OnActivated(EventArgs e)
	{
		this.tbFind.Focus();
		this.method_2();
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x0001498A File Offset: 0x00012B8A
	private void method_2()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x00014993 File Offset: 0x00012B93
	private void tbReplace_TextChanged(object sender, EventArgs e)
	{
		this.method_2();
	}

	// Token: 0x04001318 RID: 4888
	private readonly Control3 control3_0;

	// Token: 0x04001319 RID: 4889
	private bool bool_0 = true;

	// Token: 0x0400131A RID: 4890
	private GStruct19 gstruct19_0;
}
