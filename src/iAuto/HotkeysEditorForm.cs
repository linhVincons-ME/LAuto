using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _i;

// Token: 0x02000214 RID: 532
internal partial class HotkeysEditorForm : Form
{
	// Token: 0x06001D3E RID: 7486 RVA: 0x00013CFC File Offset: 0x00011EFC
	public HotkeysEditorForm(Class347 class347_0)
	{
		this.InitializeComponent();
		this.method_1(class347_0);
		this.dgv.DataSource = this.bindingList_0;
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x000DF350 File Offset: 0x000DD550
	private int method_0(Keys keys_0, Keys keys_1)
	{
		int num = ((int)(keys_0 & (Keys)255)).CompareTo((int)(keys_1 & (Keys)255));
		if (num == 0)
		{
			num = keys_0.CompareTo(keys_1);
		}
		return num;
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x000DF38C File Offset: 0x000DD58C
	private void method_1(Class347 class347_0)
	{
		List<Keys> list = class347_0.Keys.ToList<Keys>();
		list.Sort(new Comparison<Keys>(this.method_0));
		this.bindingList_0.Clear();
		foreach (Keys keys in list)
		{
			this.bindingList_0.Add(new Class349(keys, class347_0[keys]));
		}
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x000DF414 File Offset: 0x000DD614
	public Class347 method_2()
	{
		Class347 @class = new Class347();
		foreach (Class349 class2 in this.bindingList_0)
		{
			@class[class2.method_0()] = class2.FCTBAction_0;
		}
		return @class;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00013D2D File Offset: 0x00011F2D
	private void btAdd_Click(object sender, EventArgs e)
	{
		this.bindingList_0.Add(new Class349(Keys.None, FCTBAction.None));
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x000DF474 File Offset: 0x000DD674
	private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgv[0, e.RowIndex] as DataGridViewComboBoxCell;
		if (dataGridViewComboBoxCell.Items.Count == 0)
		{
			foreach (string text in new string[] { "", "Ctrl", "Ctrl + Shift", "Ctrl + Alt", "Shift", "Shift + Alt", "Alt", "Ctrl + Shift + Alt" })
			{
				dataGridViewComboBoxCell.Items.Add(text);
			}
		}
		dataGridViewComboBoxCell = this.dgv[1, e.RowIndex] as DataGridViewComboBoxCell;
		if (dataGridViewComboBoxCell.Items.Count == 0)
		{
			foreach (object obj in Enum.GetValues(typeof(Keys)))
			{
				dataGridViewComboBoxCell.Items.Add(obj);
			}
		}
		dataGridViewComboBoxCell = this.dgv[2, e.RowIndex] as DataGridViewComboBoxCell;
		if (dataGridViewComboBoxCell.Items.Count == 0)
		{
			foreach (object obj2 in Enum.GetValues(typeof(FCTBAction)))
			{
				dataGridViewComboBoxCell.Items.Add(obj2);
			}
		}
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x000DF614 File Offset: 0x000DD814
	private void btResore_Click(object sender, EventArgs e)
	{
		Class347 @class = new Class347();
		@class.vmethod_0();
		this.method_1(@class);
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000DF634 File Offset: 0x000DD834
	private void btRemove_Click(object sender, EventArgs e)
	{
		for (int i = this.dgv.RowCount - 1; i >= 0; i--)
		{
			if (this.dgv.Rows[i].Selected)
			{
				this.dgv.Rows.RemoveAt(i);
			}
		}
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000DF684 File Offset: 0x000DD884
	private void HotkeysEditorForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			string text = this.method_3();
			if (!string.IsNullOrEmpty(text) && MessageBox.Show("Some actions are not assigned!\r\nActions: " + text + "\r\nPress Yes to save and exit, press No to continue editing", "Some actions is not assigned", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000DF6D0 File Offset: 0x000DD8D0
	private string method_3()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Dictionary<FCTBAction, FCTBAction> dictionary = new Dictionary<FCTBAction, FCTBAction>();
		foreach (Class349 @class in this.bindingList_0)
		{
			dictionary[@class.FCTBAction_0] = @class.FCTBAction_0;
		}
		foreach (object obj in Enum.GetValues(typeof(FCTBAction)))
		{
			if ((FCTBAction)obj != FCTBAction.None && !((FCTBAction)obj).ToString().StartsWith("CustomAction") && !dictionary.ContainsKey((FCTBAction)obj))
			{
				stringBuilder.Append(((obj != null) ? obj.ToString() : null) + ", ");
			}
		}
		return stringBuilder.ToString().TrimEnd(new char[] { ' ', ',' });
	}

	// Token: 0x04001262 RID: 4706
	private readonly BindingList<Class349> bindingList_0 = new BindingList<Class349>();
}
