using System;
using System.ComponentModel;

// Token: 0x02000241 RID: 577
internal class Class383 : TypeDescriptionProvider
{
	// Token: 0x06001F60 RID: 8032 RVA: 0x00015164 File Offset: 0x00013364
	public Class383(Type type_0)
		: base(Class383.smethod_0(type_0))
	{
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x00015172 File Offset: 0x00013372
	private static TypeDescriptionProvider smethod_0(Type type_0)
	{
		return TypeDescriptor.GetProvider(type_0);
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x0001517A File Offset: 0x0001337A
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
	{
		return new Class384(base.GetTypeDescriptor(objectType, instance), instance);
	}
}
