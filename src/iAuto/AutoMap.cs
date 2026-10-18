using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x0200034E RID: 846
public partial class AutoMap : UserControl
{
	// Token: 0x06002C26 RID: 11302 RVA: 0x0001D68F File Offset: 0x0001B88F
	public AutoMap()
	{
		this.InitializeComponent();
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x00140F34 File Offset: 0x0013F134
	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.lvAutoMap.Items.Clear();
		int i = Class531.smethod_12(this.comboBox2.Text, "[", "]").smethod_26();
		string[] array = Class106.smethod_25(i.ToString()).Split(new char[] { '-' });
		i = 0;
		while (i < array.Length)
		{
			string text = array[i];
			int num = 0;
			int num2 = 0;
			try
			{
				num = Class531.smethod_19(text.Split(new char[] { ',' })[0]);
				num2 = Class531.smethod_19(text.Split(new char[] { ',' })[1]);
				goto IL_00D4;
			}
			catch
			{
				goto IL_00D4;
			}
			goto IL_0099;
			IL_00CB:
			i++;
			continue;
			IL_0099:
			if (num2 != 0)
			{
				this.lvAutoMap.Items.Add(new ListViewItem(num.ToString() + "," + num2.ToString()));
				goto IL_00CB;
			}
			goto IL_00CB;
			IL_00D4:
			if (num != 0)
			{
				goto IL_0099;
			}
			goto IL_00CB;
		}
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x0014102C File Offset: 0x0013F22C
	private void lvAutoMap_DoubleClick(object sender, EventArgs e)
	{
		while (this.lvAutoMap.SelectedItems.Count > 0)
		{
			this.lvAutoMap.SelectedItems[0].Remove();
		}
		string text = string.Empty;
		foreach (object obj in this.lvAutoMap.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			text = text + listViewItem.Text + "-";
		}
		text = text.Trim(new char[] { '-' });
		Class106.Class210_0["MAP", Class531.smethod_12(this.comboBox2.Text, "[", "]").smethod_26().ToString()] = text;
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x00141114 File Offset: 0x0013F314
	private void button15_Click(object sender, EventArgs e)
	{
		if (Class106.Class106_0 != null)
		{
			string text = ((int)Class106.Class106_0.Single_5).ToString() + "," + ((int)Class106.Class106_0.Single_6).ToString();
			ListViewItem listViewItem = new ListViewItem(text);
			this.lvAutoMap.Items.Add(listViewItem);
			text = string.Empty;
			foreach (object obj in this.lvAutoMap.Items)
			{
				ListViewItem listViewItem2 = (ListViewItem)obj;
				text = text + listViewItem2.Text + "-";
			}
			text = text.Trim(new char[] { '-' });
			Class106.Class210_0["MAP", Class531.smethod_12(this.comboBox2.Text, "[", "]").smethod_26().ToString()] = text;
		}
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x00141228 File Offset: 0x0013F428
	private void comboBox2_DropDown(object sender, EventArgs e)
	{
		this.comboBox2.Items.Clear();
		ComboBox.ObjectCollection items = this.comboBox2.Items;
		object[] array = Class106.List_3.Where<Class106>(new Func<Class106, bool>(AutoMap.Class614.f_0756E15D.method_0)).Select<Class106, string>(new Func<Class106, string>(AutoMap.Class614.f_0756E15D.method_1)).Distinct<string>()
			.ToArray<string>();
		items.AddRange(array);
	}

	// Token: 0x0200034F RID: 847
	[CompilerGenerated]
	[Serializable]
	private sealed class Class614
	{
		// Token: 0x06002C2F RID: 11311 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_0(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0014170C File Offset: 0x0013F90C
		internal string method_1(Class106 class106_0)
		{
			return class106_0.Class527_0.String_12 + " [" + class106_0.Class527_0.Int32_35.ToString() + "]";
		}

		// Token: 0x04002087 RID: 8327
		public static readonly AutoMap.Class614 f_0756E15D = new AutoMap.Class614();

		// Token: 0x04002088 RID: 8328
		public static Func<Class106, bool> f_495B1068;

		// Token: 0x04002089 RID: 8329
		public static Func<Class106, string> f_FEB92EB1;
	}
}
