using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x02000348 RID: 840
internal partial class ToDoi : UserControl
{
	// Token: 0x06002BF0 RID: 11248 RVA: 0x0001D49A File Offset: 0x0001B69A
	public ToDoi()
	{
		this.InitializeComponent();
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_0(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_1(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_3(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x0013E204 File Offset: 0x0013C404
	private void ToDoi_Load(object sender, EventArgs e)
	{
		try
		{
			this.method_9();
		}
		catch
		{
		}
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x0013E22C File Offset: 0x0013C42C
	private void lvTeamName_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.lvTeamMem.Items.Clear();
		List<string> list = this.lvTeamName.SelectedItems[0].Tag as List<string>;
		this.lvTeamMem.Items.AddRange(list.Select<string, ListViewItem>(new Func<string, ListViewItem>(ToDoi.Class611.f_37F0A1FA.method_0)).ToArray<ListViewItem>());
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_5(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x0013E2A0 File Offset: 0x0013C4A0
	private void deleteDoubleClickToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToolStripItem toolStripItem = sender as ToolStripItem;
		if (toolStripItem != null)
		{
			ContextMenuStrip contextMenuStrip = toolStripItem.Owner as ContextMenuStrip;
			if (contextMenuStrip != null)
			{
				ToDoi.Class613 @class = new ToDoi.Class613();
				@class.listViewEx_0 = (ListViewEx)contextMenuStrip.SourceControl;
				ListViewItem[] array = @class.listViewEx_0.Items.Cast<ListViewItem>().Where<ListViewItem>(new Func<ListViewItem, bool>(@class.method_0)).ToArray<ListViewItem>();
				@class.listViewEx_0.Items.Clear();
				@class.listViewEx_0.Items.AddRange(array);
			}
		}
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x0013E328 File Offset: 0x0013C528
	private void lvTeamMem_DoubleClick(object sender, EventArgs e)
	{
		ToDoi.Class612 @class = new ToDoi.Class612();
		@class.listViewEx_0 = (ListViewEx)sender;
		ListViewItem[] array = @class.listViewEx_0.Items.Cast<ListViewItem>().Where<ListViewItem>(new Func<ListViewItem, bool>(@class.method_0)).ToArray<ListViewItem>();
		@class.listViewEx_0.Items.Clear();
		@class.listViewEx_0.Items.AddRange(array);
		if (@class.listViewEx_0 == this.lvTeamMem)
		{
			this.lvTeamName.SelectedItems[0].Tag = this.lvTeamMem.Items.Cast<ListViewItem>().Select<ListViewItem, string>(new Func<ListViewItem, string>(ToDoi.Class611.f_37F0A1FA.method_1)).ToList<string>();
		}
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x0000500B File Offset: 0x0000320B
	private void lvTeamMem_ControlRemoved(object sender, ControlEventArgs e)
	{
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x0000500B File Offset: 0x0000320B
	private void lvTeamMem_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	private void method_6(object sender, FormClosingEventArgs e)
	{
		this.method_7();
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x0013E3EC File Offset: 0x0013C5EC
	public void method_7()
	{
		Class226.Dictionary_2.Clear();
		foreach (object obj in this.lvTeamName.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			Class226.Dictionary_2[listViewItem.Text] = listViewItem.Tag as List<string>;
		}
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x0013E46C File Offset: 0x0013C66C
	private void lvTeamMem_DragDrop(object sender, DragEventArgs e)
	{
		if ((ListViewEx)sender == this.lvTeamMem)
		{
			this.lvTeamName.SelectedItems[0].Tag = this.lvTeamMem.Items.Cast<ListViewItem>().Select<ListViewItem, string>(new Func<ListViewItem, string>(ToDoi.Class611.f_37F0A1FA.method_2)).ToList<string>();
		}
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	private void method_8(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x0013E4D8 File Offset: 0x0013C6D8
	public void method_9()
	{
		try
		{
			this.lvTeamName.Items.Clear();
			this.lvTeamMem.Items.Clear();
			this.lvTeamName.Items.AddRange(Class226.Dictionary_2.Select<KeyValuePair<string, List<string>>, ListViewItem>(new Func<KeyValuePair<string, List<string>>, ListViewItem>(ToDoi.Class611.f_37F0A1FA.method_3)).ToArray<ListViewItem>());
		}
		catch
		{
		}
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x0013E558 File Offset: 0x0013C758
	private void method_10(object sender, EventArgs e)
	{
		this.lvTeamName.Items.Clear();
		this.lvTeamMem.Items.Clear();
		this.lvTeamName.Items.AddRange(Class226.Dictionary_2.Select<KeyValuePair<string, List<string>>, ListViewItem>(new Func<KeyValuePair<string, List<string>>, ListViewItem>(ToDoi.Class611.f_37F0A1FA.method_4)).ToArray<ListViewItem>());
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
	private void clearToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvTeamName.Items.Clear();
	}

	// Token: 0x02000349 RID: 841
	[CompilerGenerated]
	[Serializable]
	private sealed class Class611
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		internal ListViewItem method_0(string string_0)
		{
			return new ListViewItem(string_0);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		internal string method_1(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		internal string method_2(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0001D4ED File Offset: 0x0001B6ED
		internal ListViewItem method_3(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return new ListViewItem(keyValuePair_0.Key)
			{
				Tag = keyValuePair_0.Value
			};
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0001D4ED File Offset: 0x0001B6ED
		internal ListViewItem method_4(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return new ListViewItem(keyValuePair_0.Key)
			{
				Tag = keyValuePair_0.Value
			};
		}

		// Token: 0x0400204C RID: 8268
		public static readonly ToDoi.Class611 f_37F0A1FA = new ToDoi.Class611();

		// Token: 0x0400204D RID: 8269
		public static Func<string, ListViewItem> f_1046F2A7;

		// Token: 0x0400204E RID: 8270
		public static Func<ListViewItem, string> f_D2269C66;

		// Token: 0x0400204F RID: 8271
		public static Func<ListViewItem, string> f_EAD78871;

		// Token: 0x04002050 RID: 8272
		public static Func<KeyValuePair<string, List<string>>, ListViewItem> f_7B9CC25C;

		// Token: 0x04002051 RID: 8273
		public static Func<KeyValuePair<string, List<string>>, ListViewItem> f_5F7E8A59;
	}

	// Token: 0x0200034A RID: 842
	[CompilerGenerated]
	private sealed class Class612
	{
		// Token: 0x06002C0E RID: 11278 RVA: 0x0001D508 File Offset: 0x0001B708
		internal bool method_0(ListViewItem listViewItem_0)
		{
			return !this.listViewEx_0.SelectedItems.Contains(listViewItem_0);
		}

		// Token: 0x04002052 RID: 8274
		public ListViewEx listViewEx_0;
	}

	// Token: 0x0200034B RID: 843
	[CompilerGenerated]
	private sealed class Class613
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x0001D51E File Offset: 0x0001B71E
		internal bool method_0(ListViewItem listViewItem_0)
		{
			return !this.listViewEx_0.SelectedItems.Contains(listViewItem_0);
		}

		// Token: 0x04002053 RID: 8275
		public ListViewEx listViewEx_0;
	}
}
