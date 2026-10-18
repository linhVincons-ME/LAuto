using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000231 RID: 561
internal abstract class Class368 : IDisposable
{
	// Token: 0x06001E94 RID: 7828 RVA: 0x00014AFB File Offset: 0x00012CFB
	public Class368()
	{
		this.P_m_9D8BB1CB = true;
	}

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00014B0A File Offset: 0x00012D0A
	// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00014B12 File Offset: 0x00012D12
	public virtual bool P_m_9D8BB1CB { get; set; }

	// Token: 0x06001E97 RID: 7831 RVA: 0x0000500B File Offset: 0x0000320B
	public virtual void Dispose()
	{
	}

	// Token: 0x1400003D RID: 61
	// (add) Token: 0x06001E98 RID: 7832 RVA: 0x000E53D4 File Offset: 0x000E35D4
	// (remove) Token: 0x06001E99 RID: 7833 RVA: 0x000E540C File Offset: 0x000E360C
	public event EventHandler<EventArgs15> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs15> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs15> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs15> eventHandler3 = (EventHandler<EventArgs15>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs15> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs15> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs15> eventHandler3 = (EventHandler<EventArgs15>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001E9A RID: 7834
	public abstract void m_61500534(Graphics graphics_0, Point point_0, Class357 class357_0);

	// Token: 0x06001E9B RID: 7835 RVA: 0x00014B1B File Offset: 0x00012D1B
	public virtual void vmethod_0(Control3 control3_0, EventArgs15 eventArgs15_0)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(control3_0, eventArgs15_0);
		}
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00014B32 File Offset: 0x00012D32
	protected virtual void vmethod_1(Control3 control3_0, Class390 class390_0)
	{
		control3_0.method_19(class390_0);
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00014B3B File Offset: 0x00012D3B
	public static Size smethod_0(Class357 class357_0)
	{
		return new Size((class357_0.GStruct19_1.int_0 - class357_0.GStruct19_0.int_0) * class357_0.control3_0.Int32_4, class357_0.control3_0.Int32_2);
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000E5444 File Offset: 0x000E3644
	public static GraphicsPath smethod_1(Rectangle rectangle_0, int int_0)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y, int_0, int_0, 180f, 90f);
		graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y, int_0, int_0, 270f, 90f);
		graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 0f, 90f);
		graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 90f, 90f);
		graphicsPath.AddLine(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, rectangle_0.X, rectangle_0.Y + int_0 / 2);
		return graphicsPath;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00009922 File Offset: 0x00007B22
	public virtual string m_D9599D06()
	{
		return "";
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00014B70 File Offset: 0x00012D70
	public virtual Class331 m_E7CA5341()
	{
		return new Class331();
	}

	// Token: 0x0400132D RID: 4909
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400132E RID: 4910
	[CompilerGenerated]
	private EventHandler<EventArgs15> eventHandler_0;
}
