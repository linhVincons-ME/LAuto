using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _i;

// Token: 0x0200023F RID: 575
internal class Class381 : IEnumerable, IDisposable, IList<Class351>, ICollection<Class351>, IEnumerable<Class351>
{
	// Token: 0x06001F23 RID: 7971 RVA: 0x000E84D4 File Offset: 0x000E66D4
	public Class381(Control3 control3_1)
	{
		this.Control3_0 = control3_1;
		this.class353_0 = new Class353(this);
		this.Class312_0 = new Class312(this);
		if (Enum.GetUnderlyingType(typeof(StyleIndex)) == typeof(uint))
		{
			this.class368_0 = new Class368[32];
		}
		else
		{
			this.class368_0 = new Class368[16];
		}
		this.vmethod_1();
	}

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00014F01 File Offset: 0x00013101
	// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00014F09 File Offset: 0x00013109
	public Class312 Class312_0 { get; set; }

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00014F12 File Offset: 0x00013112
	// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00014F1A File Offset: 0x0001311A
	public Control3 Control3_0
	{
		get
		{
			return this.control3_0;
		}
		set
		{
			if (this.control3_0 == value)
			{
				return;
			}
			this.control3_0 = value;
			this.method_0();
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00014F33 File Offset: 0x00013133
	// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00014F3B File Offset: 0x0001313B
	public Class369 Class369_0 { get; set; }

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00014F44 File Offset: 0x00013144
	public virtual bool Boolean_0
	{
		get
		{
			return this.eventHandler_1 != null;
		}
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x0000500B File Offset: 0x0000320B
	public virtual void Dispose()
	{
	}

	// Token: 0x1700063B RID: 1595
	public virtual Class351 this[int i]
	{
		get
		{
			return this.list_0[i];
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x00014F5D File Offset: 0x0001315D
	public IEnumerator<Class351> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x00014F6F File Offset: 0x0001316F
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.list_0 as IEnumerator;
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x00014F7C File Offset: 0x0001317C
	public virtual int IndexOf(Class351 item)
	{
		return this.list_0.IndexOf(item);
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x00014F8A File Offset: 0x0001318A
	public virtual void Insert(int index, Class351 item)
	{
		this.m_559E6352(index, item);
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x00014F94 File Offset: 0x00013194
	public virtual void RemoveAt(int index)
	{
		this.vmethod_8(index);
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x00014F9D File Offset: 0x0001319D
	public virtual void Add(Class351 item)
	{
		this.m_559E6352(this.Count, item);
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x00014FAC File Offset: 0x000131AC
	public virtual void Clear()
	{
		this.m_90EA19F5(0, this.Count);
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x00014FBB File Offset: 0x000131BB
	public virtual bool Contains(Class351 item)
	{
		return this.list_0.Contains(item);
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x00014FC9 File Offset: 0x000131C9
	public virtual void CopyTo(Class351[] array, int arrayIndex)
	{
		this.list_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00014FD8 File Offset: 0x000131D8
	public virtual int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00005E76 File Offset: 0x00004076
	public virtual bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x000E8554 File Offset: 0x000E6754
	public virtual bool Remove(Class351 item)
	{
		int num = this.IndexOf(item);
		if (num >= 0)
		{
			this.vmethod_8(num);
			return true;
		}
		return false;
	}

	// Token: 0x1400003E RID: 62
	// (add) Token: 0x06001F3A RID: 7994 RVA: 0x000E8578 File Offset: 0x000E6778
	// (remove) Token: 0x06001F3B RID: 7995 RVA: 0x000E85B0 File Offset: 0x000E67B0
	public event EventHandler<EventArgs3> Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs3> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> eventHandler3 = (EventHandler<EventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs3>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs3> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs3> eventHandler3 = (EventHandler<EventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs3>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x1400003F RID: 63
	// (add) Token: 0x06001F3C RID: 7996 RVA: 0x000E85E8 File Offset: 0x000E67E8
	// (remove) Token: 0x06001F3D RID: 7997 RVA: 0x000E8620 File Offset: 0x000E6820
	public event EventHandler<EventArgs4> Event_1
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs4> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> eventHandler3 = (EventHandler<EventArgs4>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs4> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> eventHandler3 = (EventHandler<EventArgs4>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4>>(ref this.eventHandler_1, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000040 RID: 64
	// (add) Token: 0x06001F3E RID: 7998 RVA: 0x000E8658 File Offset: 0x000E6858
	// (remove) Token: 0x06001F3F RID: 7999 RVA: 0x000E8690 File Offset: 0x000E6890
	public event EventHandler<Class381.EventArgs14> Event_2
	{
		[CompilerGenerated]
		add
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_2;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_2;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_2, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000041 RID: 65
	// (add) Token: 0x06001F40 RID: 8000 RVA: 0x000E86C8 File Offset: 0x000E68C8
	// (remove) Token: 0x06001F41 RID: 8001 RVA: 0x000E8700 File Offset: 0x000E6900
	public event EventHandler<Class381.EventArgs14> Event_3
	{
		[CompilerGenerated]
		add
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_3;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_3;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_3, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000042 RID: 66
	// (add) Token: 0x06001F42 RID: 8002 RVA: 0x000E8738 File Offset: 0x000E6938
	// (remove) Token: 0x06001F43 RID: 8003 RVA: 0x000E8770 File Offset: 0x000E6970
	public event EventHandler<Class381.EventArgs14> Event_4
	{
		[CompilerGenerated]
		add
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_4;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<Class381.EventArgs14> eventHandler = this.eventHandler_4;
			EventHandler<Class381.EventArgs14> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Class381.EventArgs14> eventHandler3 = (EventHandler<Class381.EventArgs14>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<Class381.EventArgs14>>(ref this.eventHandler_4, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000043 RID: 67
	// (add) Token: 0x06001F44 RID: 8004 RVA: 0x000E87A8 File Offset: 0x000E69A8
	// (remove) Token: 0x06001F45 RID: 8005 RVA: 0x000E87E0 File Offset: 0x000E69E0
	public event EventHandler<EventArgs6> Event_5
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_5;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs6> eventHandler = this.eventHandler_5;
			EventHandler<EventArgs6> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs6> eventHandler3 = (EventHandler<EventArgs6>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6>>(ref this.eventHandler_5, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x14000044 RID: 68
	// (add) Token: 0x06001F46 RID: 8006 RVA: 0x000E8818 File Offset: 0x000E6A18
	// (remove) Token: 0x06001F47 RID: 8007 RVA: 0x000E8850 File Offset: 0x000E6A50
	public event EventHandler Event_6
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000E8888 File Offset: 0x000E6A88
	public virtual void m_AA3A1CFA()
	{
		foreach (Class351 @class in this.list_0)
		{
			@class.Boolean_0 = false;
		}
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x00014FE5 File Offset: 0x000131E5
	public virtual Class351 vmethod_0()
	{
		return new Class351(this.vmethod_5());
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x00014FF2 File Offset: 0x000131F2
	private void method_0()
	{
		if (this.eventHandler_6 != null)
		{
			this.eventHandler_6(this, EventArgs.Empty);
		}
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x0001500D File Offset: 0x0001320D
	public virtual void vmethod_1()
	{
		this.Class369_0 = new Class369(null, null, FontStyle.Regular);
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x0001501D File Offset: 0x0001321D
	public virtual bool vmethod_2(int int_1)
	{
		return this.list_0[int_1] != null;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x0001502E File Offset: 0x0001322E
	public virtual IList<string> vmethod_3()
	{
		return this.class353_0;
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x00015036 File Offset: 0x00013236
	public virtual int vmethod_4(Class351 class351_0, IComparer<Class351> icomparer_0)
	{
		return this.list_0.BinarySearch(class351_0, icomparer_0);
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000E88DC File Offset: 0x000E6ADC
	public virtual int vmethod_5()
	{
		int num = this.int_0;
		this.int_0 = num + 1;
		return num;
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x00015045 File Offset: 0x00013245
	public virtual void m_559E6352(int int_1, Class351 class351_0)
	{
		this.list_0.Insert(int_1, class351_0);
		this.vmethod_6(int_1);
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x0001505B File Offset: 0x0001325B
	public virtual void vmethod_6(int int_1)
	{
		this.vmethod_7(int_1, 1);
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x00015065 File Offset: 0x00013265
	public virtual void vmethod_7(int int_1, int int_2)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, new EventArgs3(int_1, int_2));
		}
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x00015082 File Offset: 0x00013282
	public virtual void vmethod_8(int int_1)
	{
		this.m_90EA19F5(int_1, 1);
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000E88FC File Offset: 0x000E6AFC
	public virtual void m_90EA19F5(int int_1, int int_2)
	{
		List<int> list = new List<int>();
		if (int_2 > 0 && this.Boolean_0)
		{
			for (int i = 0; i < int_2; i++)
			{
				list.Add(this[int_1 + i].Int32_0);
			}
		}
		this.list_0.RemoveRange(int_1, int_2);
		this.vmethod_9(int_1, int_2, list);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x0001508C File Offset: 0x0001328C
	public virtual void vmethod_9(int int_1, int int_2, List<int> list_1)
	{
		if (int_2 > 0 && this.eventHandler_1 != null)
		{
			this.eventHandler_1(this, new EventArgs4(int_1, int_2, list_1));
		}
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000150AE File Offset: 0x000132AE
	public virtual void vmethod_10(int int_1, int int_2)
	{
		if (this.eventHandler_2 != null)
		{
			this.eventHandler_2(this, new Class381.EventArgs14(Math.Min(int_1, int_2), Math.Max(int_1, int_2)));
		}
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000150D7 File Offset: 0x000132D7
	public virtual void vmethod_11(Class381.EventArgs14 eventArgs14_0)
	{
		if (this.eventHandler_3 != null)
		{
			this.eventHandler_3(this, eventArgs14_0);
		}
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000150EE File Offset: 0x000132EE
	public virtual void vmethod_12(Class381.EventArgs14 eventArgs14_0)
	{
		if (this.eventHandler_4 != null)
		{
			this.eventHandler_4(this, eventArgs14_0);
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000E8954 File Offset: 0x000E6B54
	public virtual void vmethod_13()
	{
		string text = null;
		this.vmethod_14(ref text);
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000E896C File Offset: 0x000E6B6C
	public virtual void vmethod_14(ref string string_0)
	{
		if (this.eventHandler_5 != null)
		{
			EventArgs6 eventArgs = new EventArgs6
			{
				String_0 = string_0
			};
			this.eventHandler_5(this, eventArgs);
			string_0 = eventArgs.String_0;
			if (eventArgs.Boolean_0)
			{
				string_0 = string.Empty;
			}
		}
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x00015105 File Offset: 0x00013305
	public virtual int m_EBF80696(int int_1)
	{
		return this.list_0[int_1].Count;
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x00015118 File Offset: 0x00013318
	public virtual bool m_87D86B1A(int int_1)
	{
		return !string.IsNullOrEmpty(this.list_0[int_1].String_0);
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x00015133 File Offset: 0x00013333
	public virtual bool m_BC8D0B8B(int int_1)
	{
		return !string.IsNullOrEmpty(this.list_0[int_1].String_1);
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000E89B4 File Offset: 0x000E6BB4
	public virtual void m_5A2109FD(string string_0, Encoding encoding_0)
	{
		using (StreamWriter streamWriter = new StreamWriter(string_0, false, encoding_0))
		{
			for (int i = 0; i < this.Count - 1; i++)
			{
				streamWriter.WriteLine(this.list_0[i].String_2);
			}
			streamWriter.Write(this.list_0[this.Count - 1].String_2);
		}
	}

	// Token: 0x040013BF RID: 5055
	protected readonly List<Class351> list_0 = new List<Class351>();

	// Token: 0x040013C0 RID: 5056
	public readonly Class368[] class368_0;

	// Token: 0x040013C1 RID: 5057
	private Control3 control3_0;

	// Token: 0x040013C2 RID: 5058
	private int int_0;

	// Token: 0x040013C3 RID: 5059
	protected Class353 class353_0;

	// Token: 0x040013C4 RID: 5060
	[CompilerGenerated]
	private Class312 class312_0;

	// Token: 0x040013C5 RID: 5061
	[CompilerGenerated]
	private Class369 class369_0;

	// Token: 0x040013C6 RID: 5062
	[CompilerGenerated]
	private EventHandler<EventArgs3> eventHandler_0;

	// Token: 0x040013C7 RID: 5063
	[CompilerGenerated]
	private EventHandler<EventArgs4> eventHandler_1;

	// Token: 0x040013C8 RID: 5064
	[CompilerGenerated]
	private EventHandler<Class381.EventArgs14> eventHandler_2;

	// Token: 0x040013C9 RID: 5065
	[CompilerGenerated]
	private EventHandler<Class381.EventArgs14> eventHandler_3;

	// Token: 0x040013CA RID: 5066
	[CompilerGenerated]
	private EventHandler<Class381.EventArgs14> eventHandler_4;

	// Token: 0x040013CB RID: 5067
	[CompilerGenerated]
	private EventHandler<EventArgs6> eventHandler_5;

	// Token: 0x040013CC RID: 5068
	[CompilerGenerated]
	private EventHandler eventHandler_6;

	// Token: 0x02000240 RID: 576
	public class EventArgs14 : EventArgs
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x0001514E File Offset: 0x0001334E
		public EventArgs14(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x040013CD RID: 5069
		public int int_0;

		// Token: 0x040013CE RID: 5070
		public int int_1;
	}
}
