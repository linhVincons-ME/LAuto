using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000076 RID: 118
public class GClass21 : IEnumerable<string>, ICollection<string>, IEnumerable
{
	// Token: 0x06000513 RID: 1299 RVA: 0x0000666E File Offset: 0x0000486E
	internal GClass21(GClass19 gclass19_1)
	{
		this.gclass19_0 = gclass19_1;
		this.list_0 = new List<string>();
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000514 RID: 1300 RVA: 0x00006688 File Offset: 0x00004888
	public int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000515 RID: 1301 RVA: 0x00005E76 File Offset: 0x00004076
	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000516 RID: 1302 RVA: 0x00005E76 File Offset: 0x00004076
	public bool Boolean_0
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0002E27C File Offset: 0x0002C47C
	public void Add(string uriPrefix)
	{
		this.gclass19_0.method_9();
		Class67.smethod_0(uriPrefix);
		if (this.list_0.Contains(uriPrefix))
		{
			return;
		}
		this.list_0.Add(uriPrefix);
		if (this.gclass19_0.Boolean_3)
		{
			Class61.smethod_5(uriPrefix, this.gclass19_0);
		}
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00006695 File Offset: 0x00004895
	public void Clear()
	{
		this.gclass19_0.method_9();
		this.list_0.Clear();
		if (this.gclass19_0.Boolean_3)
		{
			Class61.smethod_6(this.gclass19_0);
		}
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x000066C5 File Offset: 0x000048C5
	public bool Contains(string uriPrefix)
	{
		this.gclass19_0.method_9();
		if (uriPrefix == null)
		{
			throw new ArgumentNullException("uriPrefix");
		}
		return this.list_0.Contains(uriPrefix);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x000066EC File Offset: 0x000048EC
	public void method_0(Array array_0, int int_0)
	{
		this.gclass19_0.method_9();
		((ICollection)this.list_0).CopyTo(array_0, int_0);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00006706 File Offset: 0x00004906
	public void CopyTo(string[] array, int offset)
	{
		this.gclass19_0.method_9();
		this.list_0.CopyTo(array, offset);
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00006720 File Offset: 0x00004920
	public IEnumerator<string> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
	public bool Remove(string uriPrefix)
	{
		this.gclass19_0.method_9();
		if (uriPrefix == null)
		{
			throw new ArgumentNullException("uriPrefix");
		}
		bool flag = this.list_0.Remove(uriPrefix);
		if (flag && this.gclass19_0.Boolean_3)
		{
			Class61.smethod_7(uriPrefix, this.gclass19_0);
		}
		return flag;
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00006720 File Offset: 0x00004920
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x0400026A RID: 618
	private GClass19 gclass19_0;

	// Token: 0x0400026B RID: 619
	private List<string> list_0;
}
