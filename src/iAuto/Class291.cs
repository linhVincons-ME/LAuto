using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020001BB RID: 443
internal class Class291
{
	// Token: 0x0600185B RID: 6235 RVA: 0x000CBD34 File Offset: 0x000C9F34
	public Class291(Class301 class301_0)
	{
		GStruct3 gstruct = class301_0.GStruct7_0.OptionalHeader.DataDirectory[2];
		if (gstruct.VirtualAddress > 0U && gstruct.Size > 0U)
		{
			uint num;
			GStruct10 gstruct2;
			if (!class301_0.method_3<GStruct10>((long)((ulong)(num = class301_0.method_11(gstruct.VirtualAddress))), SeekOrigin.Begin, out gstruct2))
			{
				throw class301_0.vmethod_1();
			}
			GStruct11 gstruct3 = new GStruct11
			{
				SubdirectoryRva = 2147483648U
			};
			this.Class293_0 = new Class291.Class293(class301_0, gstruct3, false, num);
		}
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x0600185C RID: 6236 RVA: 0x00010B4F File Offset: 0x0000ED4F
	// (set) Token: 0x0600185D RID: 6237 RVA: 0x00010B57 File Offset: 0x0000ED57
	public Class291.Class293 Class293_0 { get; set; }

	// Token: 0x0400101C RID: 4124
	[CompilerGenerated]
	private Class291.Class293 class293_0;

	// Token: 0x020001BC RID: 444
	public class Class293 : Class291.Class292
	{
		// Token: 0x0600185E RID: 6238 RVA: 0x00010B60 File Offset: 0x0000ED60
		public Class293(Class301 class301_1, GStruct11 gstruct11_1, bool bool_1, uint uint_1)
			: base(class301_1, gstruct11_1, bool_1, uint_1)
		{
			if (!class301_1.method_3<GStruct10>((long)((ulong)(uint_1 + (gstruct11_1.SubdirectoryRva ^ 2147483648U))), SeekOrigin.Begin, out this.gstruct10_0))
			{
				throw class301_1.vmethod_1();
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00010B93 File Offset: 0x0000ED93
		public Class291.Class293[] Class293_0
		{
			get
			{
				if (this.class293_0 == null)
				{
					this.method_0();
				}
				return this.class293_0;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00010BA9 File Offset: 0x0000EDA9
		public Class291.Class294[] Class294_0
		{
			get
			{
				if (this.class294_0 == null)
				{
					this.method_0();
				}
				return this.class294_0;
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000CBDBC File Offset: 0x000C9FBC
		private void method_0()
		{
			List<Class291.Class293> list = new List<Class291.Class293>();
			List<Class291.Class294> list2 = new List<Class291.Class294>();
			int numberOfNamedEntries = (int)this.gstruct10_0.NumberOfNamedEntries;
			for (int i = 0; i < numberOfNamedEntries + (int)this.gstruct10_0.NumberOfIdEntries; i++)
			{
				GStruct11 gstruct;
				if (this.class301_0.method_3<GStruct11>((long)((ulong)(this.uint_0 + 16U + (this.gstruct11_0.SubdirectoryRva ^ 2147483648U)) + (ulong)((long)i * 8L)), SeekOrigin.Begin, out gstruct))
				{
					if ((gstruct.SubdirectoryRva & 2147483648U) != 0U)
					{
						list.Add(new Class291.Class293(this.class301_0, gstruct, i < numberOfNamedEntries, this.uint_0));
					}
					else
					{
						list2.Add(new Class291.Class294(this.class301_0, gstruct, i < numberOfNamedEntries, this.uint_0));
					}
				}
			}
			this.class294_0 = list2.ToArray();
			this.class293_0 = list.ToArray();
		}

		// Token: 0x0400101D RID: 4125
		private readonly GStruct10 gstruct10_0;

		// Token: 0x0400101E RID: 4126
		private Class291.Class293[] class293_0;

		// Token: 0x0400101F RID: 4127
		private Class291.Class294[] class294_0;
	}

	// Token: 0x020001BD RID: 445
	public class Class294 : Class291.Class292
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x00010BBF File Offset: 0x0000EDBF
		public Class294(Class301 class301_1, GStruct11 gstruct11_1, bool bool_1, uint uint_1)
			: base(class301_1, gstruct11_1, bool_1, uint_1)
		{
			if (!class301_1.method_3<GStruct9>((long)((ulong)(this.uint_0 + gstruct11_1.DataEntryRva)), SeekOrigin.Begin, out this.gstruct9_0))
			{
				throw class301_1.vmethod_1();
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000CBE9C File Offset: 0x000CA09C
		public byte[] method_0()
		{
			byte[] array = new byte[this.gstruct9_0.Size];
			if (!this.class301_0.method_2((long)((ulong)this.class301_0.method_11(this.gstruct9_0.OffsetToData)), SeekOrigin.Begin, array))
			{
				throw this.class301_0.vmethod_1();
			}
			return array;
		}

		// Token: 0x04001020 RID: 4128
		private readonly GStruct9 gstruct9_0;
	}

	// Token: 0x020001BE RID: 446
	public abstract class Class292
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x000CBEF0 File Offset: 0x000CA0F0
		public Class292(Class301 class301_1, GStruct11 gstruct11_1, bool bool_1, uint uint_1)
		{
			this.class301_0 = class301_1;
			this.gstruct11_0 = gstruct11_1;
			this.Boolean_0 = bool_1;
			if (bool_1)
			{
				ushort num = 0;
				if (class301_1.method_3<ushort>((long)((ulong)(uint_1 + (gstruct11_1.NameRva & 2147483647U))), SeekOrigin.Begin, out num))
				{
					byte[] array = new byte[(int)num << 1];
					if (class301_1.method_2(0L, SeekOrigin.Current, array))
					{
						this.String_0 = Encoding.Unicode.GetString(array);
					}
				}
				if (this.String_0 == null)
				{
					throw class301_1.vmethod_1();
				}
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		public int Int32_0
		{
			get
			{
				if (!this.Boolean_0)
				{
					return (int)this.gstruct11_0.IntegerId;
				}
				return -1;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00010C07 File Offset: 0x0000EE07
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x00010C0F File Offset: 0x0000EE0F
		public bool Boolean_0 { get; protected set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00010C18 File Offset: 0x0000EE18
		public string String_0 { get; }

		// Token: 0x04001021 RID: 4129
		protected GStruct11 gstruct11_0;

		// Token: 0x04001022 RID: 4130
		protected Class301 class301_0;

		// Token: 0x04001023 RID: 4131
		protected uint uint_0;

		// Token: 0x04001024 RID: 4132
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04001025 RID: 4133
		[CompilerGenerated]
		private readonly string string_0;
	}
}
