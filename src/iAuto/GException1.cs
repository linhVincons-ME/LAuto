using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

// Token: 0x02000066 RID: 102
[Serializable]
public class GException1 : FormatException, ISerializable
{
	// Token: 0x0600045B RID: 1115 RVA: 0x00005F51 File Offset: 0x00004151
	internal GException1(string string_0)
		: base(string_0)
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00005F5A File Offset: 0x0000415A
	internal GException1(string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00005F64 File Offset: 0x00004164
	protected GException1(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00005F6E File Offset: 0x0000416E
	public GException1()
	{
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00005F76 File Offset: 0x00004176
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00005F76 File Offset: 0x00004176
	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		base.GetObjectData(serializationInfo, streamingContext);
	}
}
