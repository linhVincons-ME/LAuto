using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000166 RID: 358
internal partial class Alarm : UserControl
{
	// Token: 0x060015DD RID: 5597 RVA: 0x0000F735 File Offset: 0x0000D935
	public Alarm()
	{
		this.InitializeComponent();
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x000AD5A4 File Offset: 0x000AB7A4
	public Alarm(Class106 class106_1, string string_0, int int_1)
	{
		this.InitializeComponent();
		this.class106_0 = class106_1;
		this.lblCharName.Text = class106_1.Class527_0.String_11;
		this.lblAlarm.Text = string_0;
		if (int_1 > 0)
		{
			this.int_0 = int_1;
			this.lblExit.Text = string.Format("{0:0}:{1:00}", int_1 / 60, int_1 % 60);
			this.timer_0.Start();
			return;
		}
		this.timer_0.Stop();
		this.lblExit.Text = "";
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x0000F743 File Offset: 0x0000D943
	private void Alarm_Load(object sender, EventArgs e)
	{
		if (!Class226.Boolean_142)
		{
			Class586.smethod_1();
		}
		base.Height = 25;
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x000AD640 File Offset: 0x000AB840
	private void timer_0_Tick(object sender, EventArgs e)
	{
		int num = this.int_0;
		this.int_0 = num - 1;
		if (num < 3 && this.int_0 <= 0)
		{
			base.Dispose();
		}
		this.lblExit.Text = string.Format("{0:0}:{1:00}", this.int_0 / 60, this.int_0 % 60);
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0000F759 File Offset: 0x0000D959
	private void lblCharName_Click(object sender, EventArgs e)
	{
		this.class106_0.Boolean_49 = true;
		this.class106_0.method_299();
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x0000F759 File Offset: 0x0000D959
	private void lblAlarm_Click(object sender, EventArgs e)
	{
		this.class106_0.Boolean_49 = true;
		this.class106_0.method_299();
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0000500B File Offset: 0x0000320B
	private void lblExit_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000AD6A4 File Offset: 0x000AB8A4
	private void lblExit_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && Class226.Boolean_61)
		{
			if (MessageBox.Show(this, "Do you want to exit " + this.class106_0.Class527_0.String_11, "iAuto", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.class106_0.method_305();
				return;
			}
			if (MessageBox.Show(this, "Bạn có muốn thoát " + this.class106_0.Class527_0.String_11, "iAuto", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.class106_0.method_305();
			}
		}
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x000AD730 File Offset: 0x000AB930
	private void lblClose_Click(object sender, EventArgs e)
	{
		base.Dispose();
		if (AlarmContainer.AlarmContainer_0.Controls.Count == 0 && AlarmContainer.AlarmContainer_0.Visible)
		{
			base.Invoke(new Action(Alarm.Class247.f_8BA5390D.method_0));
		}
	}

	// Token: 0x04000D27 RID: 3367
	private readonly Class106 class106_0;

	// Token: 0x04000D28 RID: 3368
	private int int_0;

	// Token: 0x02000167 RID: 359
	[CompilerGenerated]
	[Serializable]
	private sealed class Class247
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x0000F79D File Offset: 0x0000D99D
		internal void method_0()
		{
			AlarmContainer.AlarmContainer_0.Hide();
		}

		// Token: 0x04000D2F RID: 3375
		public static readonly Alarm.Class247 f_8BA5390D = new Alarm.Class247();

		// Token: 0x04000D30 RID: 3376
		public static Action f_5443B5A1;
	}
}
