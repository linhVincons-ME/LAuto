using System;

// Token: 0x020001C0 RID: 448
[Serializable]
public abstract class GClass38
{
	// Token: 0x06001869 RID: 6249 RVA: 0x00010C20 File Offset: 0x0000EE20
	public virtual void vmethod_0()
	{
		this._lasterror = null;
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00010C29 File Offset: 0x0000EE29
	public virtual Exception vmethod_1()
	{
		return this._lasterror;
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00010C31 File Offset: 0x0000EE31
	protected virtual bool vmethod_2(Exception exception_0)
	{
		this._lasterror = exception_0;
		return false;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00010C3B File Offset: 0x0000EE3B
	public virtual bool vmethod_3(string string_0)
	{
		return this.vmethod_2(new Exception(string_0));
	}

	// Token: 0x0400102A RID: 4138
	protected Exception _lasterror;
}
