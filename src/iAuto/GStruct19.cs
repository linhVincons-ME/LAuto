using System;

// Token: 0x0200021F RID: 543
public struct GStruct19 : IEquatable<GStruct19>
{
	// Token: 0x06001DAD RID: 7597 RVA: 0x00014138 File Offset: 0x00012338
	public GStruct19(int int_2, int int_3)
	{
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x00014148 File Offset: 0x00012348
	public void method_0(int int_2, int int_3)
	{
		this.int_0 += int_2;
		this.int_1 += int_3;
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x00014166 File Offset: 0x00012366
	public bool Equals(GStruct19 other)
	{
		return this.int_0 == other.int_0 && this.int_1 == other.int_1;
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00014186 File Offset: 0x00012386
	public override bool Equals(object obj)
	{
		return obj is GStruct19 && this.Equals((GStruct19)obj);
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0001419E File Offset: 0x0001239E
	public override int GetHashCode()
	{
		return this.int_0.GetHashCode() ^ this.int_1.GetHashCode();
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000141B7 File Offset: 0x000123B7
	public static bool smethod_0(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return !gstruct19_0.Equals(gstruct19_1);
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x000141C4 File Offset: 0x000123C4
	public static bool smethod_1(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return gstruct19_0.Equals(gstruct19_1);
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000141CE File Offset: 0x000123CE
	public static bool smethod_2(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return gstruct19_0.int_1 < gstruct19_1.int_1 || (gstruct19_0.int_1 <= gstruct19_1.int_1 && gstruct19_0.int_0 < gstruct19_1.int_0);
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x00014201 File Offset: 0x00012401
	public static bool smethod_3(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return gstruct19_0.Equals(gstruct19_1) || gstruct19_0.int_1 < gstruct19_1.int_1 || (gstruct19_0.int_1 <= gstruct19_1.int_1 && gstruct19_0.int_0 < gstruct19_1.int_0);
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00014240 File Offset: 0x00012440
	public static bool smethod_4(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return gstruct19_0.int_1 > gstruct19_1.int_1 || (gstruct19_0.int_1 >= gstruct19_1.int_1 && gstruct19_0.int_0 > gstruct19_1.int_0);
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00014273 File Offset: 0x00012473
	public static bool smethod_5(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return gstruct19_0.Equals(gstruct19_1) || gstruct19_0.int_1 > gstruct19_1.int_1 || (gstruct19_0.int_1 >= gstruct19_1.int_1 && gstruct19_0.int_0 > gstruct19_1.int_0);
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x000142B2 File Offset: 0x000124B2
	public static GStruct19 smethod_6(GStruct19 gstruct19_0, GStruct19 gstruct19_1)
	{
		return new GStruct19(gstruct19_0.int_0 + gstruct19_1.int_0, gstruct19_0.int_1 + gstruct19_1.int_1);
	}

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000E07C8 File Offset: 0x000DE9C8
	public static GStruct19 GStruct19_0
	{
		get
		{
			return default(GStruct19);
		}
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x000E07E0 File Offset: 0x000DE9E0
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"(",
			this.int_0.ToString(),
			",",
			this.int_1.ToString(),
			")"
		});
	}

	// Token: 0x04001294 RID: 4756
	public int int_0;

	// Token: 0x04001295 RID: 4757
	public int int_1;
}
