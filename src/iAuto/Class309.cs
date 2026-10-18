using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x020001D2 RID: 466
internal class Class309 : Class308
{
	// Token: 0x06001957 RID: 6487 RVA: 0x0001159A File Offset: 0x0000F79A
	public Class309(Control3 control3_1)
	{
		this.control3_0 = control3_1;
		control3_1.Event_16 += this.vmethod_1;
		control3_1.Event_17 += this.vmethod_0;
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001958 RID: 6488 RVA: 0x000115DA File Offset: 0x0000F7DA
	public override int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001959 RID: 6489 RVA: 0x00005E76 File Offset: 0x00004076
	public override bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x000CDDE8 File Offset: 0x000CBFE8
	protected virtual void vmethod_0(object sender, EventArgs4 e)
	{
		for (int i = 0; i < this.Count; i++)
		{
			if (this.list_0[i].Int32_0 >= e.Int32_0)
			{
				if (this.list_0[i].Int32_0 >= e.Int32_0 + e.Int32_1)
				{
					this.list_0[i].Int32_0 = this.list_0[i].Int32_0 - e.Int32_1;
				}
				else
				{
					bool flag = e.Int32_0 <= 0;
					using (List<Class311>.Enumerator enumerator = this.list_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Int32_0 == e.Int32_0 - 1)
							{
								flag = true;
							}
						}
					}
					if (flag)
					{
						this.list_0.RemoveAt(i);
						i--;
					}
					else
					{
						this.list_0[i].Int32_0 = e.Int32_0 - 1;
					}
				}
			}
		}
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x000CDF00 File Offset: 0x000CC100
	protected virtual void vmethod_1(object sender, EventArgs3 e)
	{
		for (int i = 0; i < this.Count; i++)
		{
			if (this.list_0[i].Int32_0 >= e.Int32_0)
			{
				this.list_0[i].Int32_0 = this.list_0[i].Int32_0 + e.Int32_1;
			}
			else if (this.list_0[i].Int32_0 == e.Int32_0 - 1 && e.Int32_1 == 1 && this.control3_0[e.Int32_0 - 1].Int32_2 == this.control3_0[e.Int32_0 - 1].Count)
			{
				this.list_0[i].Int32_0 = this.list_0[i].Int32_0 + e.Int32_1;
			}
		}
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x000115E7 File Offset: 0x0000F7E7
	public override void Dispose()
	{
		this.control3_0.Event_16 -= this.vmethod_1;
		this.control3_0.Event_17 -= this.vmethod_0;
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00011619 File Offset: 0x0000F819
	public override IEnumerator<Class311> GetEnumerator()
	{
		Class309.Class310 @class = new Class309.Class310(0);
		@class.class309_0 = this;
		return @class;
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00011628 File Offset: 0x0000F828
	public override void m_3C2BBC82(int int_1, string string_0)
	{
		this.Add(new Class311(this.control3_0, string_0 ?? ("Bookmark " + this.int_0.ToString()), int_1));
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00011656 File Offset: 0x0000F856
	public override void m_05DAEE07(int int_1)
	{
		this.Add(new Class311(this.control3_0, "Bookmark " + this.int_0.ToString(), int_1));
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0001167F File Offset: 0x0000F87F
	public override void Clear()
	{
		this.list_0.Clear();
		this.int_0 = 0;
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x000CDFE8 File Offset: 0x000CC1E8
	public override void Add(Class311 item)
	{
		using (List<Class311>.Enumerator enumerator = this.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Int32_0 == item.Int32_0)
				{
					return;
				}
			}
		}
		this.list_0.Add(item);
		this.int_0++;
		this.control3_0.method_4();
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x00011693 File Offset: 0x0000F893
	public override bool Contains(Class311 item)
	{
		return this.list_0.Contains(item);
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x000CE06C File Offset: 0x000CC26C
	public override bool m_2C548EAA(int int_1)
	{
		using (List<Class311>.Enumerator enumerator = this.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Int32_0 == int_1)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x000116A1 File Offset: 0x0000F8A1
	public override void CopyTo(Class311[] array, int arrayIndex)
	{
		this.list_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x000116B0 File Offset: 0x0000F8B0
	public override bool Remove(Class311 item)
	{
		this.control3_0.method_4();
		return this.list_0.Remove(item);
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x000CE0CC File Offset: 0x000CC2CC
	public override bool m_D88CF883(int int_1)
	{
		bool flag = false;
		for (int i = 0; i < this.Count; i++)
		{
			if (this.list_0[i].Int32_0 == int_1)
			{
				this.list_0.RemoveAt(i);
				i--;
				flag = true;
			}
		}
		this.control3_0.method_4();
		return flag;
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x000116C9 File Offset: 0x0000F8C9
	public override Class311 m_298DA27F(int int_1)
	{
		return this.list_0[int_1];
	}

	// Token: 0x0400107D RID: 4221
	protected int int_0;

	// Token: 0x0400107E RID: 4222
	protected List<Class311> list_0 = new List<Class311>();

	// Token: 0x0400107F RID: 4223
	protected Control3 control3_0;

	// Token: 0x020001D3 RID: 467
	[CompilerGenerated]
	private sealed class Class310 : IDisposable, IEnumerator, IEnumerator<Class311>
	{
		// Token: 0x06001968 RID: 6504 RVA: 0x000116D7 File Offset: 0x0000F8D7
		[DebuggerHidden]
		public Class310(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000CE120 File Offset: 0x000CC320
		[DebuggerHidden]
		public void Dispose()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.enumerator_0 = default(List<Class311>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000CE16C File Offset: 0x000CC36C
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class309 @class = this.class309_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
				}
				else
				{
					this.int_0 = -1;
					this.enumerator_0 = @class.list_0.GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.enumerator_0.MoveNext())
				{
					this.method_0();
					this.enumerator_0 = default(List<Class311>.Enumerator);
					flag = false;
				}
				else
				{
					Class311 class2 = this.enumerator_0.Current;
					this.class311_0 = class2;
					this.int_0 = 1;
					flag = true;
				}
			}
			catch
			{
				this.Dispose();
				throw;
			}
			return flag;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000116E6 File Offset: 0x0000F8E6
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00011700 File Offset: 0x0000F900
		public Class311 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class311_0;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00011700 File Offset: 0x0000F900
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class311_0;
			}
		}

		// Token: 0x04001080 RID: 4224
		private int int_0;

		// Token: 0x04001081 RID: 4225
		private Class311 class311_0;

		// Token: 0x04001082 RID: 4226
		public Class309 class309_0;

		// Token: 0x04001083 RID: 4227
		private List<Class311>.Enumerator enumerator_0;
	}
}
