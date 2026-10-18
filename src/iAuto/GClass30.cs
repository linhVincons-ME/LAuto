using System;
using System.Windows.Forms;

// Token: 0x02000097 RID: 151
public class GClass30 : ComboBox
{
	// Token: 0x060006F5 RID: 1781 RVA: 0x00007C50 File Offset: 0x00005E50
	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 522)
		{
			return;
		}
		base.WndProc(ref m);
	}
}
