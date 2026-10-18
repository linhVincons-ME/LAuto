using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using _i;

// Token: 0x02000217 RID: 535
internal class Class351 : IEnumerable, IList<GStruct17>, ICollection<GStruct17>, IEnumerable<GStruct17>
{
	// Token: 0x06001D5C RID: 7516 RVA: 0x00013DFC File Offset: 0x00011FFC
	internal Class351(int int_2)
	{
		this.Int32_0 = int_2;
		this.list_0 = new List<GStruct17>();
	}

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00013E16 File Offset: 0x00012016
	// (set) Token: 0x06001D5E RID: 7518 RVA: 0x00013E1E File Offset: 0x0001201E
	public string String_0 { get; set; }

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00013E27 File Offset: 0x00012027
	// (set) Token: 0x06001D60 RID: 7520 RVA: 0x00013E2F File Offset: 0x0001202F
	public string String_1 { get; set; }

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00013E38 File Offset: 0x00012038
	// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00013E40 File Offset: 0x00012040
	public bool Boolean_0 { get; set; }

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00013E49 File Offset: 0x00012049
	// (set) Token: 0x06001D64 RID: 7524 RVA: 0x00013E51 File Offset: 0x00012051
	public DateTime DateTime_0 { get; set; }

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00013E5A File Offset: 0x0001205A
	// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00013E62 File Offset: 0x00012062
	public Brush Brush_0 { get; set; }

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00013E6B File Offset: 0x0001206B
	// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00013E73 File Offset: 0x00012073
	public int Int32_0 { get; private set; }

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00013E7C File Offset: 0x0001207C
	// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00013E84 File Offset: 0x00012084
	public int Int32_1 { get; set; }

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x06001D6B RID: 7531 RVA: 0x000E01EC File Offset: 0x000DE3EC
	public virtual string String_2
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(this.Count);
			foreach (GStruct17 gstruct in this)
			{
				stringBuilder.Append(gstruct.char_0);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000E0250 File Offset: 0x000DE450
	public int Int32_2
	{
		get
		{
			int num = 0;
			int num2 = 0;
			while (num2 < this.Count && this[num2].char_0 == ' ')
			{
				num++;
				num2++;
			}
			return num;
		}
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x00013E8D File Offset: 0x0001208D
	public int IndexOf(GStruct17 item)
	{
		return this.list_0.IndexOf(item);
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x00013E9B File Offset: 0x0001209B
	public void Insert(int index, GStruct17 item)
	{
		this.list_0.Insert(index, item);
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x00013EAA File Offset: 0x000120AA
	public void RemoveAt(int index)
	{
		this.list_0.RemoveAt(index);
	}

	// Token: 0x170005DB RID: 1499
	public GStruct17 this[int index]
	{
		get
		{
			return this.list_0[index];
		}
		set
		{
			this.list_0[index] = value;
		}
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x00013ED5 File Offset: 0x000120D5
	public void Add(GStruct17 item)
	{
		this.list_0.Add(item);
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x00013EE3 File Offset: 0x000120E3
	public void Clear()
	{
		this.list_0.Clear();
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x00013EF0 File Offset: 0x000120F0
	public bool Contains(GStruct17 item)
	{
		return this.list_0.Contains(item);
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x00013EFE File Offset: 0x000120FE
	public void CopyTo(GStruct17[] array, int arrayIndex)
	{
		this.list_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00013F0D File Offset: 0x0001210D
	public int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00005E76 File Offset: 0x00004076
	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x00013F1A File Offset: 0x0001211A
	public bool Remove(GStruct17 item)
	{
		return this.list_0.Remove(item);
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x00013F28 File Offset: 0x00012128
	public IEnumerator<GStruct17> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x00013F28 File Offset: 0x00012128
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000E0288 File Offset: 0x000DE488
	public void method_0(StyleIndex styleIndex_0)
	{
		this.String_0 = null;
		this.String_1 = null;
		for (int i = 0; i < this.Count; i++)
		{
			GStruct17 gstruct = this[i];
			gstruct.styleIndex_0 &= ~styleIndex_0;
			this[i] = gstruct;
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x00013F3A File Offset: 0x0001213A
	public void method_1()
	{
		this.String_0 = null;
		this.String_1 = null;
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x00013F4A File Offset: 0x0001214A
	public virtual void vmethod_0(int int_2, int int_3)
	{
		if (int_2 >= this.Count)
		{
			return;
		}
		this.list_0.RemoveRange(int_2, Math.Min(this.Count - int_2, int_3));
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x00013F70 File Offset: 0x00012170
	public virtual void vmethod_1()
	{
		this.list_0.TrimExcess();
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x00013F7D File Offset: 0x0001217D
	public virtual void vmethod_2(IEnumerable<GStruct17> ienumerable_0)
	{
		this.list_0.AddRange(ienumerable_0);
	}

	// Token: 0x04001276 RID: 4726
	protected List<GStruct17> list_0;

	// Token: 0x04001277 RID: 4727
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04001278 RID: 4728
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001279 RID: 4729
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400127A RID: 4730
	[CompilerGenerated]
	private DateTime dateTime_0;

	// Token: 0x0400127B RID: 4731
	[CompilerGenerated]
	private Brush brush_0;

	// Token: 0x0400127C RID: 4732
	[CompilerGenerated]
	private int int_0;

	// Token: 0x0400127D RID: 4733
	[CompilerGenerated]
	private int int_1;
}
