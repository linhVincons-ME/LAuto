using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x02000170 RID: 368
public partial class AutoPkEx : Form
{
	// Token: 0x06001607 RID: 5639 RVA: 0x0000F8AF File Offset: 0x0000DAAF
	public AutoPkEx()
	{
		this.InitializeComponent();
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001608 RID: 5640 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
	public static AutoPkEx AutoPkEx_0
	{
		get
		{
			if (AutoPkEx.autoPkEx_0 == null || AutoPkEx.autoPkEx_0.IsDisposed)
			{
				AutoPkEx.autoPkEx_0 = new AutoPkEx();
			}
			return AutoPkEx.autoPkEx_0;
		}
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x000ADEEC File Offset: 0x000AC0EC
	private void AutoPkEx_Load(object sender, EventArgs e)
	{
		base.Icon = Class616.Icon_0;
		Class534.smethod_12(this, Class534.Enum19.BottomRight);
		string text = Class106.Class210_0["Settings", "Fight"];
		this.listViewName.Items.AddRange(text.Split(new char[] { '-' }).Select<string, ListViewItem>(new Func<string, ListViewItem>(AutoPkEx.Class251.f_EED861E4.method_0)).ToArray<ListViewItem>());
		this.txtListName.Text = Class106.Class210_0["Settings", "PkNames"];
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x000ADF8C File Offset: 0x000AC18C
	private void button2_Click(object sender, EventArgs e)
	{
		this.listViewName.Items.Clear();
		this.hashSet_0.Clear();
		foreach (Class106 @class in Class106.IEnumerable_0)
		{
			foreach (Class504 class2 in @class.Class506_0.List_0)
			{
				if (!(class2.String_9.Trim() == "") && class2.Boolean_5 && !Class106.HashSet_12.Contains(class2.String_9) && !this.hashSet_0.Contains(class2.String_9) && !Class226.HashSet_2.Contains(class2.String_9))
				{
					this.hashSet_0.Add(class2.String_9);
					this.listViewName.Items.Add(class2.String_9);
				}
			}
		}
		Class106.Class210_0["Settings", "Fight"] = string.Join("-", this.hashSet_0.ToArray<string>());
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0000F8EC File Offset: 0x0000DAEC
	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		this.listViewName.Search(this.txtSearch.Text);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x000AE0E0 File Offset: 0x000AC2E0
	private void listViewName_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.txtListName.Text = string.Join(",", this.listViewName.SelectedItems.Cast<ListViewItem>().Select<ListViewItem, string>(new Func<ListViewItem, string>(AutoPkEx.Class251.f_EED861E4.method_1)));
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x000AE138 File Offset: 0x000AC338
	private void menuListName_Opening(object sender, CancelEventArgs e)
	{
		List<string> list = this.listViewName.Items.Cast<ListViewItem>().Select<ListViewItem, string>(new Func<ListViewItem, string>(AutoPkEx.Class251.f_EED861E4.method_2)).ToList<string>();
		this.hashSet_0.Clear();
		this.menuListName.Items.Clear();
		foreach (Class106 @class in Class106.IEnumerable_0)
		{
			foreach (Class504 class2 in @class.Class506_0.List_0.Where<Class504>(new Func<Class504, bool>(AutoPkEx.Class251.f_EED861E4.method_3)))
			{
				if (!Class106.HashSet_12.Contains(class2.String_9) && !list.Contains(class2.String_9) && !this.hashSet_0.Contains(class2.String_9) && !Class226.HashSet_2.Contains(class2.String_9))
				{
					this.hashSet_0.Add(class2.String_9);
				}
			}
		}
		List<ToolStripMenuItem> list2 = new List<ToolStripMenuItem>();
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("No News");
		toolStripMenuItem.Enabled = false;
		using (HashSet<string>.Enumerator enumerator3 = this.hashSet_0.GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				AutoPkEx.Class252 class3 = new AutoPkEx.Class252();
				class3.autoPkEx_0 = this;
				class3.string_0 = enumerator3.Current;
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(class3.string_0);
				toolStripMenuItem2.Click += class3.method_0;
				list2.Add(toolStripMenuItem2);
			}
		}
		if (list2.Count == 0)
		{
			list2.Add(toolStripMenuItem);
		}
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("[Delete]");
		toolStripMenuItem3.Font = new Font(toolStripMenuItem3.Font, FontStyle.Bold);
		this.menuListName.Items.Add(toolStripMenuItem3);
		toolStripMenuItem3.Click += this.method_0;
		ToolStripItemCollection items = this.menuListName.Items;
		ToolStripItem[] array = list2.ToArray();
		items.AddRange(array);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x0000F904 File Offset: 0x0000DB04
	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		base.TopMost = this.checkBox1.Checked;
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x0000F917 File Offset: 0x0000DB17
	private void txtListName_TextChanged(object sender, EventArgs e)
	{
		Class106.Class210_0["Settings", "PkNames"] = this.txtListName.Text;
		Class226.String_5 = this.txtListName.Text;
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0000F948 File Offset: 0x0000DB48
	private void checkIsFight_CheckedChanged(object sender, EventArgs e)
	{
		Class226.Boolean_70 = this.checkIsFight.Checked;
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0000F95A File Offset: 0x0000DB5A
	private void AutoPkEx_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
		{
			base.Hide();
			e.Cancel = true;
			return;
		}
		if (e.CloseReason == CloseReason.WindowsShutDown)
		{
			base.Dispose();
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x000AEB24 File Offset: 0x000ACD24
	[CompilerGenerated]
	private void method_0(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewName.SelectedItems)
		{
			((ListViewItem)obj).Remove();
		}
		List<string> list = new List<string>();
		foreach (object obj2 in this.listViewName.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj2;
			list.Add(listViewItem.Text);
		}
		Class106.Class210_0["Settings", "Fight"] = string.Join("-", list.ToArray());
	}

	// Token: 0x04000D56 RID: 3414
	public static AutoPkEx autoPkEx_0;

	// Token: 0x04000D57 RID: 3415
	private readonly HashSet<string> hashSet_0 = new HashSet<string>();

	// Token: 0x02000171 RID: 369
	[CompilerGenerated]
	[Serializable]
	private sealed class Class251
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		internal ListViewItem method_0(string string_0)
		{
			return new ListViewItem(string_0);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		internal string method_1(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		internal string method_2(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000F9C6 File Offset: 0x0000DBC6
		internal bool method_3(Class504 class504_0)
		{
			return class504_0.Boolean_5 && !string.IsNullOrEmpty(class504_0.String_9);
		}

		// Token: 0x04000D63 RID: 3427
		public static readonly AutoPkEx.Class251 f_EED861E4 = new AutoPkEx.Class251();

		// Token: 0x04000D64 RID: 3428
		public static Func<string, ListViewItem> f_60D046D9;

		// Token: 0x04000D65 RID: 3429
		public static Func<ListViewItem, string> f_84EBDAAC;

		// Token: 0x04000D66 RID: 3430
		public static Func<ListViewItem, string> f_F86D386E;

		// Token: 0x04000D67 RID: 3431
		public static Func<Class504, bool> f_CA29D81B;
	}

	// Token: 0x02000172 RID: 370
	[CompilerGenerated]
	private sealed class Class252
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x000AEC00 File Offset: 0x000ACE00
		internal void method_0(object sender, EventArgs e)
		{
			this.autoPkEx_0.listViewName.Items.Add(new ListViewItem(this.string_0));
			List<string> list = new List<string>();
			foreach (object obj in this.autoPkEx_0.listViewName.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				list.Add(listViewItem.Text);
			}
			Class106.Class210_0["Settings", "Fight"] = string.Join("-", list.ToArray());
		}

		// Token: 0x04000D68 RID: 3432
		public string string_0;

		// Token: 0x04000D69 RID: 3433
		public AutoPkEx autoPkEx_0;
	}
}
