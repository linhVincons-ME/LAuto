using System;
using System.ComponentModel;

// Token: 0x02000243 RID: 579
internal class Class385 : EventDescriptor
{
	// Token: 0x06001F66 RID: 8038 RVA: 0x000151A1 File Offset: 0x000133A1
	public Class385(MemberDescriptor memberDescriptor_0)
		: base(memberDescriptor_0)
	{
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x06001F67 RID: 8039 RVA: 0x000151AA File Offset: 0x000133AA
	public override Type ComponentType
	{
		get
		{
			return typeof(Control3);
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000151B6 File Offset: 0x000133B6
	public override Type EventType
	{
		get
		{
			return typeof(EventHandler);
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00005BAB File Offset: 0x00003DAB
	public override bool IsMulticast
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000151C2 File Offset: 0x000133C2
	public override void AddEventHandler(object component, Delegate value)
	{
		(component as Control3).Event_3 += value as EventHandler;
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000151D5 File Offset: 0x000133D5
	public override void RemoveEventHandler(object component, Delegate value)
	{
		(component as Control3).Event_3 -= value as EventHandler;
	}
}
