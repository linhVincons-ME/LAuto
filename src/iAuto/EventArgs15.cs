using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200024A RID: 586
internal class EventArgs15 : MouseEventArgs
{
	// Token: 0x06001F82 RID: 8066 RVA: 0x000152C2 File Offset: 0x000134C2
	public EventArgs15(Class368 class368_1, Class390 class390_1, MouseEventArgs mouseEventArgs_0)
		: base(mouseEventArgs_0.Button, mouseEventArgs_0.Clicks, mouseEventArgs_0.X, mouseEventArgs_0.Y, mouseEventArgs_0.Delta)
	{
		this.Class368_0 = class368_1;
		this.Class390_0 = class390_1;
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000152F6 File Offset: 0x000134F6
	// (set) Token: 0x06001F84 RID: 8068 RVA: 0x000152FE File Offset: 0x000134FE
	public Class368 Class368_0 { get; private set; }

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00015307 File Offset: 0x00013507
	// (set) Token: 0x06001F86 RID: 8070 RVA: 0x0001530F File Offset: 0x0001350F
	public Class390 Class390_0 { get; private set; }

	// Token: 0x040013DA RID: 5082
	[CompilerGenerated]
	private Class368 class368_0;

	// Token: 0x040013DB RID: 5083
	[CompilerGenerated]
	private Class390 class390_0;
}
