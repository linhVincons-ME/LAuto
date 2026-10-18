using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000245 RID: 581
internal class Class386
{
	// Token: 0x06001F76 RID: 8054 RVA: 0x0001524C File Offset: 0x0001344C
	public Class386(Rectangle rectangle_1)
	{
		this.rectangle_0 = rectangle_1;
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0001525B File Offset: 0x0001345B
	public virtual Cursor Cursor_0
	{
		get
		{
			return Cursors.Hand;
		}
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x0000500B File Offset: 0x0000320B
	public virtual void m_64CCB291(Graphics graphics_0, Pen pen_0)
	{
	}

	// Token: 0x040013D5 RID: 5077
	public readonly Rectangle rectangle_0;
}
