using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200020E RID: 526
internal class Class344 : IEnumerable, IDisposable, ICollection<Class346>, IEnumerable<Class346>
{
	// Token: 0x06001CF5 RID: 7413 RVA: 0x000DE444 File Offset: 0x000DC644
	public Class344(Control3 control3_1)
	{
		this.control3_0 = control3_1;
		control3_1.Event_2 += this.vmethod_1;
		control3_1.KeyDown += this.vmethod_0;
		control3_1.Event_7 += this.method_0;
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x00013A32 File Offset: 0x00011C32
	public IEnumerator<Class346> GetEnumerator()
	{
		Class344.Class345 @class = new Class344.Class345(0);
		@class.class344_0 = this;
		return @class;
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x00013A41 File Offset: 0x00011C41
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x000DE4A4 File Offset: 0x000DC6A4
	public void Clear()
	{
		this.list_0.Clear();
		if (this.control3_0.Controls.Count != 0)
		{
			List<Control> list = new List<Control>();
			foreach (object obj in this.control3_0.Controls)
			{
				Control control = (Control)obj;
				if (control is Control5)
				{
					list.Add(control);
				}
			}
			foreach (Control control2 in list)
			{
				this.control3_0.Controls.Remove(control2);
			}
			for (int i = 0; i < this.control3_0.list_0.Count; i++)
			{
				GStruct18 gstruct = this.control3_0.list_0[i];
				gstruct.int_1 = 0;
				this.control3_0.list_0[i] = gstruct;
			}
			this.control3_0.method_10();
			this.control3_0.method_4();
			this.control3_0.Select();
			this.control3_0.ActiveControl = null;
		}
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x000DE5F8 File Offset: 0x000DC7F8
	public void Add(Class346 hint)
	{
		this.list_0.Add(hint);
		if (hint.Boolean_0)
		{
			GStruct18 gstruct = this.control3_0.list_0[hint.Class357_0.GStruct19_0.int_1];
			hint.Int32_2 = gstruct.int_1;
			gstruct.int_1 += hint.Control5_0.Height;
			this.control3_0.list_0[hint.Class357_0.GStruct19_0.int_1] = gstruct;
			this.control3_0.method_11(true);
		}
		this.method_1(hint);
		this.control3_0.vmethod_4();
		hint.Control5_0.Parent = this.control3_0;
		this.control3_0.Select();
		this.control3_0.ActiveControl = null;
		this.control3_0.method_4();
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00013A49 File Offset: 0x00011C49
	public bool Contains(Class346 item)
	{
		return this.list_0.Contains(item);
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x00013A57 File Offset: 0x00011C57
	public void CopyTo(Class346[] array, int arrayIndex)
	{
		this.list_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00013A66 File Offset: 0x00011C66
	public int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00005E76 File Offset: 0x00004076
	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x00011A79 File Offset: 0x0000FC79
	public bool Remove(Class346 item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x000DE6D0 File Offset: 0x000DC8D0
	public void Dispose()
	{
		this.control3_0.Event_2 -= this.vmethod_1;
		this.control3_0.KeyDown -= this.vmethod_0;
		this.control3_0.Event_7 -= this.method_0;
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00013A73 File Offset: 0x00011C73
	protected virtual void vmethod_0(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			this.Clear();
		}
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x00013A8D File Offset: 0x00011C8D
	protected virtual void vmethod_1(object sender, EventArgs5 e)
	{
		this.Clear();
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x000DE724 File Offset: 0x000DC924
	private void method_0(object sender, EventArgs e)
	{
		if (this.list_0.Count == 0)
		{
			return;
		}
		this.control3_0.method_11(true);
		foreach (Class346 @class in this.list_0)
		{
			this.method_1(@class);
			@class.Control5_0.Invalidate();
		}
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x000DE7A0 File Offset: 0x000DC9A0
	private void method_1(Class346 class346_0)
	{
		if (class346_0.Boolean_0)
		{
			if (class346_0.Class357_0.GStruct19_0.int_1 < this.control3_0.list_0.Count - 1)
			{
				class346_0.Control5_0.Top = this.control3_0.list_0[class346_0.Class357_0.GStruct19_0.int_1 + 1].int_0 - class346_0.Int32_2 - class346_0.Control5_0.Height - this.control3_0.VerticalScroll.Value;
			}
			else
			{
				class346_0.Control5_0.Top = this.control3_0.int_17 + this.control3_0.Padding_0.Top - class346_0.Control5_0.Height - this.control3_0.VerticalScroll.Value;
			}
		}
		else
		{
			if (class346_0.Class357_0.GStruct19_0.int_1 > this.control3_0.Int32_14 - 1)
			{
				return;
			}
			if (class346_0.Class357_0.GStruct19_0.int_1 == this.control3_0.Int32_14 - 1)
			{
				int num = this.control3_0.list_0[class346_0.Class357_0.GStruct19_0.int_1].int_0 - this.control3_0.VerticalScroll.Value + this.control3_0.Int32_2;
				if (num + class346_0.Control5_0.Height + 1 > this.control3_0.ClientRectangle.Bottom)
				{
					class346_0.Control5_0.Top = Math.Max(0, this.control3_0.list_0[class346_0.Class357_0.GStruct19_0.int_1].int_0 - this.control3_0.VerticalScroll.Value - class346_0.Control5_0.Height);
				}
				else
				{
					class346_0.Control5_0.Top = num;
				}
			}
			else
			{
				class346_0.Control5_0.Top = this.control3_0.list_0[class346_0.Class357_0.GStruct19_0.int_1 + 1].int_0 - this.control3_0.VerticalScroll.Value;
				if (class346_0.Control5_0.Bottom > this.control3_0.ClientRectangle.Bottom)
				{
					class346_0.Control5_0.Top = this.control3_0.list_0[class346_0.Class357_0.GStruct19_0.int_1 + 1].int_0 - this.control3_0.Int32_2 - class346_0.Int32_2 - class346_0.Control5_0.Height - this.control3_0.VerticalScroll.Value;
				}
			}
		}
		if (class346_0.DockStyle_0 == DockStyle.Fill)
		{
			class346_0.Int32_0 = this.control3_0.ClientSize.Width - this.control3_0.Int32_7 - 2;
			class346_0.Control5_0.Left = this.control3_0.Int32_7;
			return;
		}
		Point point = this.control3_0.method_93(class346_0.Class357_0.GStruct19_0);
		Point point2 = this.control3_0.method_93(class346_0.Class357_0.GStruct19_1);
		int num2 = (point.X + point2.X) / 2 - class346_0.Control5_0.Width / 2;
		class346_0.Control5_0.Left = Math.Max(this.control3_0.Int32_7, num2);
		if (class346_0.Control5_0.Right > this.control3_0.ClientSize.Width)
		{
			class346_0.Control5_0.Left = Math.Max(this.control3_0.Int32_7, num2 - (class346_0.Control5_0.Right - this.control3_0.ClientSize.Width));
		}
	}

	// Token: 0x040011FD RID: 4605
	private readonly List<Class346> list_0 = new List<Class346>();

	// Token: 0x040011FE RID: 4606
	private readonly Control3 control3_0;

	// Token: 0x0200020F RID: 527
	[CompilerGenerated]
	private sealed class Class345 : IDisposable, IEnumerator, IEnumerator<Class346>
	{
		// Token: 0x06001D04 RID: 7428 RVA: 0x00013A95 File Offset: 0x00011C95
		[DebuggerHidden]
		public Class345(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000DEB6C File Offset: 0x000DCD6C
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
			this.enumerator_0 = default(List<Class346>.Enumerator);
			this.int_0 = -2;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
		bool IEnumerator.MoveNext()
		{
			bool flag;
			try
			{
				int num = this.int_0;
				Class344 @class = this.class344_0;
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
					this.enumerator_0 = default(List<Class346>.Enumerator);
					flag = false;
				}
				else
				{
					Class346 class2 = this.enumerator_0.Current;
					this.class346_0 = class2;
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

		// Token: 0x06001D07 RID: 7431 RVA: 0x00013AA4 File Offset: 0x00011CA4
		private void method_0()
		{
			this.int_0 = -1;
			((IDisposable)this.enumerator_0).Dispose();
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00013ABE File Offset: 0x00011CBE
		public Class346 Current
		{
			[DebuggerHidden]
			get
			{
				return this.class346_0;
			}
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00013ABE File Offset: 0x00011CBE
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.class346_0;
			}
		}

		// Token: 0x040011FF RID: 4607
		private int int_0;

		// Token: 0x04001200 RID: 4608
		private Class346 class346_0;

		// Token: 0x04001201 RID: 4609
		public Class344 class344_0;

		// Token: 0x04001202 RID: 4610
		private List<Class346>.Enumerator enumerator_0;
	}
}
