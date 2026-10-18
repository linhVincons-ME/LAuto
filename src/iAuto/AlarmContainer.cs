using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000168 RID: 360
internal partial class AlarmContainer : Form
{
	// Token: 0x060015EB RID: 5611 RVA: 0x0000F7A9 File Offset: 0x0000D9A9
	public AlarmContainer()
	{
		this.InitializeComponent();
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x060015EC RID: 5612 RVA: 0x0000F7B7 File Offset: 0x0000D9B7
	public static AlarmContainer AlarmContainer_0
	{
		get
		{
			if (AlarmContainer.alarmContainer_0 == null)
			{
				AlarmContainer.alarmContainer_0 = new AlarmContainer();
			}
			return AlarmContainer.alarmContainer_0;
		}
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x0000F7CF File Offset: 0x0000D9CF
	public void method_0()
	{
		base.Height = 25;
		Class534.smethod_12(this, Class534.Enum19.BottomLeft);
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x000ADBC0 File Offset: 0x000ABDC0
	public static void smethod_0(Alarm alarm_0)
	{
		AlarmContainer.Class249 @class = new AlarmContainer.Class249();
		@class.alarm_0 = alarm_0;
		GUI.GUI_0.Invoke(new Action(@class.method_0));
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
	private void AlarmContainer_Load(object sender, EventArgs e)
	{
		base.Height = 25;
		Class534.smethod_12(this, Class534.Enum19.BottomCenter);
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x000ADBF4 File Offset: 0x000ABDF4
	private void AlarmContainer_ControlRemoved(object sender, ControlEventArgs e)
	{
		if (AlarmContainer.AlarmContainer_0.Controls.Count == 0 && AlarmContainer.AlarmContainer_0.Visible)
		{
			base.Invoke(new Action(AlarmContainer.Class248.f_1936BB3C.method_0));
		}
	}

	// Token: 0x04000D31 RID: 3377
	private static AlarmContainer alarmContainer_0;

	// Token: 0x02000169 RID: 361
	[CompilerGenerated]
	[Serializable]
	private sealed class Class248
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x0000F81C File Offset: 0x0000DA1C
		internal void method_0()
		{
			AlarmContainer.AlarmContainer_0.Hide();
			Class586.smethod_4();
		}

		// Token: 0x04000D33 RID: 3379
		public static readonly AlarmContainer.Class248 f_1936BB3C = new AlarmContainer.Class248();

		// Token: 0x04000D34 RID: 3380
		public static Action f_C8B1E66F;
	}

	// Token: 0x0200016A RID: 362
	[CompilerGenerated]
	private sealed class Class249
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x0000F82D File Offset: 0x0000DA2D
		internal void method_0()
		{
			AlarmContainer.AlarmContainer_0.Controls.Add(this.alarm_0);
			Class534.smethod_14(AlarmContainer.AlarmContainer_0);
			AlarmContainer.AlarmContainer_0.Height = 25;
			Class534.smethod_12(AlarmContainer.AlarmContainer_0, Class534.Enum19.BottomLeft);
		}

		// Token: 0x04000D35 RID: 3381
		public Alarm alarm_0;
	}
}
