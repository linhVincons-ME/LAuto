using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000074 RID: 116
[Serializable]
public class GException2 : Win32Exception
{
	// Token: 0x06000501 RID: 1281 RVA: 0x000065DD File Offset: 0x000047DD
	protected GException2(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x000065E7 File Offset: 0x000047E7
	public GException2()
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x000065EF File Offset: 0x000047EF
	public GException2(int int_0)
		: base(int_0)
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x000065F8 File Offset: 0x000047F8
	public GException2(int int_0, string string_0)
		: base(int_0, string_0)
	{
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x00006602 File Offset: 0x00004802
	public override int ErrorCode
	{
		get
		{
			return base.NativeErrorCode;
		}
	}
}
