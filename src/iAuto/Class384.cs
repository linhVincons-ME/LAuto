using System;
using System.ComponentModel;
using System.Windows.Forms;

// Token: 0x02000242 RID: 578
internal class Class384 : CustomTypeDescriptor
{
	// Token: 0x06001F63 RID: 8035 RVA: 0x0001518A File Offset: 0x0001338A
	public Class384(ICustomTypeDescriptor icustomTypeDescriptor_1, object object_1)
		: base(icustomTypeDescriptor_1)
	{
		this.icustomTypeDescriptor_0 = icustomTypeDescriptor_1;
		this.object_0 = object_1;
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x000E8A30 File Offset: 0x000E6C30
	public override string GetComponentName()
	{
		Control control = this.object_0 as Control;
		if (control != null)
		{
			return control.Name;
		}
		return null;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000E8A54 File Offset: 0x000E6C54
	public override EventDescriptorCollection GetEvents()
	{
		EventDescriptorCollection events = base.GetEvents();
		EventDescriptor[] array = new EventDescriptor[events.Count];
		for (int i = 0; i < events.Count; i++)
		{
			if (events[i].Name == "TextChanged")
			{
				array[i] = new Class385(events[i]);
			}
			else
			{
				array[i] = events[i];
			}
		}
		return new EventDescriptorCollection(array);
	}

	// Token: 0x040013CF RID: 5071
	private readonly object object_0;

	// Token: 0x040013D0 RID: 5072
	private ICustomTypeDescriptor icustomTypeDescriptor_0;
}
