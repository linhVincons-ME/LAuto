using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x020001F5 RID: 501
internal class EventArgs2 : PaintEventArgs
{
	// Token: 0x06001C5A RID: 7258 RVA: 0x00013347 File Offset: 0x00011547
	public EventArgs2(int int_1, Rectangle rectangle_1, Graphics graphics_0, Rectangle rectangle_2)
		: base(graphics_0, rectangle_2)
	{
		this.Int32_0 = int_1;
		this.Rectangle_0 = rectangle_1;
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00013360 File Offset: 0x00011560
	// (set) Token: 0x06001C5C RID: 7260 RVA: 0x00013368 File Offset: 0x00011568
	public int Int32_0 { get; private set; }

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00013371 File Offset: 0x00011571
	// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00013379 File Offset: 0x00011579
	public Rectangle Rectangle_0 { get; private set; }

	// Token: 0x04001188 RID: 4488
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04001189 RID: 4489
	[CompilerGenerated]
	private Rectangle rectangle_0;
}
