using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004E RID: 78
internal class Class42<T> : GClass11 where T : GClass9
{
	// Token: 0x06000342 RID: 834 RVA: 0x000053C5 File Offset: 0x000035C5
	internal Class42(string string_1, Func<T> func_1, GClass6 gclass6_1)
		: this(string_1, func_1, null, gclass6_1)
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x000053D1 File Offset: 0x000035D1
	internal Class42(string string_1, Func<T> func_1, Action<T> action_0, GClass6 gclass6_1)
		: base(string_1, gclass6_1)
	{
		this.func_0 = this.method_3(func_1, action_0);
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000344 RID: 836 RVA: 0x000053EA File Offset: 0x000035EA
	public override Type P_m_6E6D2FDF
	{
		get
		{
			return typeof(T);
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00027B84 File Offset: 0x00025D84
	private Func<T> method_3(Func<T> func_1, Action<T> action_0)
	{
		Class42<T>.Class43 @class = new Class42<T>.Class43();
		@class.func_0 = func_1;
		@class.action_0 = action_0;
		if (@class.action_0 == null)
		{
			return @class.func_0;
		}
		return new Func<T>(@class.method_0);
	}

	// Token: 0x06000346 RID: 838 RVA: 0x000053F6 File Offset: 0x000035F6
	protected override GClass9 m_3C35837C()
	{
		return this.func_0();
	}

	// Token: 0x040001A4 RID: 420
	private Func<T> func_0;

	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	private sealed class Class43
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00027BC0 File Offset: 0x00025DC0
		internal T method_0()
		{
			T t = this.func_0();
			this.action_0(t);
			return t;
		}

		// Token: 0x040001A5 RID: 421
		public Func<T> func_0;

		// Token: 0x040001A6 RID: 422
		public Action<T> action_0;
	}
}
