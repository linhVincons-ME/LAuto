using System;
using System.Runtime.CompilerServices;

// Token: 0x020001A5 RID: 421
internal abstract class Class295 : GClass38
{
	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001825 RID: 6181 RVA: 0x00010A20 File Offset: 0x0000EC20
	// (set) Token: 0x06001826 RID: 6182 RVA: 0x00010A28 File Offset: 0x0000EC28
	public GEnum9 GEnum9_0 { get; protected set; }

	// Token: 0x06001827 RID: 6183 RVA: 0x000CA300 File Offset: 0x000C8500
	public static Class295 smethod_0(GEnum9 genum9_1)
	{
		Class295 @class;
		switch (genum9_1)
		{
		case GEnum9.Standard:
			@class = new Class298();
			break;
		case GEnum9.ThreadHijack:
			@class = new Class299();
			break;
		case GEnum9.ManualMap:
			@class = new Class296();
			break;
		default:
			return null;
		}
		if (@class != null)
		{
			@class.GEnum9_0 = genum9_1;
		}
		return @class;
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x000CA344 File Offset: 0x000C8544
	public virtual IntPtr vmethod_4(Class301 class301_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		IntPtr intPtr2 = this.m_0AD323ED(class301_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return intPtr2;
	}

	// Token: 0x06001829 RID: 6185
	public abstract IntPtr m_0AD323ED(Class301 class301_0, IntPtr intptr_0);

	// Token: 0x0600182A RID: 6186 RVA: 0x000CA374 File Offset: 0x000C8574
	public virtual IntPtr vmethod_5(string string_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		IntPtr intPtr2 = this.m_11CA4005(string_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return intPtr2;
	}

	// Token: 0x0600182B RID: 6187
	public abstract IntPtr m_11CA4005(string string_0, IntPtr intptr_0);

	// Token: 0x0600182C RID: 6188 RVA: 0x000CA3A4 File Offset: 0x000C85A4
	public virtual IntPtr[] vmethod_6(Class301[] class301_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		IntPtr[] array = this.m_68422D2A(class301_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return array;
	}

	// Token: 0x0600182D RID: 6189
	public abstract IntPtr[] m_68422D2A(Class301[] class301_0, IntPtr intptr_0);

	// Token: 0x0600182E RID: 6190 RVA: 0x000CA3D4 File Offset: 0x000C85D4
	public virtual IntPtr[] vmethod_7(string[] string_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		IntPtr[] array = this.m_12A0C7DB(string_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return array;
	}

	// Token: 0x0600182F RID: 6191
	public abstract IntPtr[] m_12A0C7DB(string[] string_0, IntPtr intptr_0);

	// Token: 0x06001830 RID: 6192 RVA: 0x000CA404 File Offset: 0x000C8604
	public virtual bool vmethod_8(IntPtr intptr_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		bool flag = this.m_D3316F8A(intptr_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return flag;
	}

	// Token: 0x06001831 RID: 6193
	public abstract bool m_D3316F8A(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06001832 RID: 6194 RVA: 0x000CA434 File Offset: 0x000C8634
	public virtual bool[] vmethod_9(IntPtr[] intptr_0, int int_0)
	{
		this.vmethod_0();
		IntPtr intPtr = GClass41.OpenProcess(1082U, false, int_0);
		bool[] array = this.m_6D139C37(intptr_0, intPtr);
		GClass41.CloseHandle(intPtr);
		return array;
	}

	// Token: 0x06001833 RID: 6195
	public abstract bool[] m_6D139C37(IntPtr[] intptr_0, IntPtr intptr_1);

	// Token: 0x04000F89 RID: 3977
	[CompilerGenerated]
	private GEnum9 genum9_0;
}
