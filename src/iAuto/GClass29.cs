using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;

// Token: 0x0200008F RID: 143
public class GClass29 : GClass28
{
	// Token: 0x06000665 RID: 1637 RVA: 0x00007579 File Offset: 0x00005779
	internal GClass29(GClass20 gclass20_1, string string_0)
	{
		this.gclass20_0 = gclass20_1;
		this.gclass7_0 = new GClass7(this, string_0);
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000666 RID: 1638 RVA: 0x00007595 File Offset: 0x00005795
	internal GClass6 GClass6_0
	{
		get
		{
			return this.gclass20_0.GClass19_0.GClass6_0;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000667 RID: 1639 RVA: 0x000075A7 File Offset: 0x000057A7
	internal Stream Stream_0
	{
		get
		{
			return this.gclass20_0.Class62_0.Stream_0;
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000668 RID: 1640 RVA: 0x000075B9 File Offset: 0x000057B9
	public override GClass16 P_m_BD29BBD8
	{
		get
		{
			return this.gclass20_0.GClass22_0.GClass16_0;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000669 RID: 1641 RVA: 0x000075CB File Offset: 0x000057CB
	public override NameValueCollection P_m_F73319E4
	{
		get
		{
			return this.gclass20_0.GClass22_0.NameValueCollection_0;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x0600066A RID: 1642 RVA: 0x000075DD File Offset: 0x000057DD
	public override string P_m_40863FD5
	{
		get
		{
			return this.gclass20_0.GClass22_0.String_6;
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x000075EF File Offset: 0x000057EF
	public override bool P_m_0B4CBE88
	{
		get
		{
			return this.gclass20_0.GClass22_0.Boolean_1;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x0600066C RID: 1644 RVA: 0x00007601 File Offset: 0x00005801
	public override bool P_m_0B4CBE88_2
	{
		get
		{
			return this.gclass20_0.GClass22_0.Boolean_2;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600066D RID: 1645 RVA: 0x00007613 File Offset: 0x00005813
	public override bool P_m_A48BE766
	{
		get
		{
			return this.gclass20_0.GClass22_0.Boolean_3;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600066E RID: 1646 RVA: 0x00007625 File Offset: 0x00005825
	public override bool P_m_E8BC7EBE
	{
		get
		{
			return this.gclass20_0.GClass22_0.Boolean_4;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600066F RID: 1647 RVA: 0x00007637 File Offset: 0x00005837
	public override string P_m_6E5F397D
	{
		get
		{
			return this.gclass20_0.GClass22_0.NameValueCollection_0["Origin"];
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000670 RID: 1648 RVA: 0x00007653 File Offset: 0x00005853
	public override NameValueCollection P_m_4976EEAF
	{
		get
		{
			return this.gclass20_0.GClass22_0.NameValueCollection_1;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x00007665 File Offset: 0x00005865
	public override Uri P_m_6DBB1F3B
	{
		get
		{
			return this.gclass20_0.GClass22_0.Uri_0;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x00007677 File Offset: 0x00005877
	public override string P_m_D0AC26BB
	{
		get
		{
			return this.gclass20_0.GClass22_0.NameValueCollection_0["Sec-WebSocket-Key"];
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000673 RID: 1651 RVA: 0x00007693 File Offset: 0x00005893
	public override IEnumerable<string> P_m_9596B81E
	{
		get
		{
			GClass29.Class78 @class = new GClass29.Class78(-2);
			@class.gclass29_0 = this;
			return @class;
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x000076A3 File Offset: 0x000058A3
	public override string P_m_D0AC26BB_2
	{
		get
		{
			return this.gclass20_0.GClass22_0.NameValueCollection_0["Sec-WebSocket-Version"];
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x000076BF File Offset: 0x000058BF
	public override IPEndPoint P_m_F2EF2D87
	{
		get
		{
			return this.gclass20_0.GClass22_0.IPEndPoint_0;
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000676 RID: 1654 RVA: 0x000076D1 File Offset: 0x000058D1
	public override IPrincipal P_m_FF34850A
	{
		get
		{
			return this.gclass20_0.IPrincipal_0;
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x000076DE File Offset: 0x000058DE
	public override IPEndPoint P_m_4ACA8297
	{
		get
		{
			return this.gclass20_0.GClass22_0.IPEndPoint_1;
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000678 RID: 1656 RVA: 0x000076F0 File Offset: 0x000058F0
	public override GClass7 P_m_3EA51AA9
	{
		get
		{
			return this.gclass7_0;
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000076F8 File Offset: 0x000058F8
	internal void method_0()
	{
		this.gclass20_0.Class62_0.method_10(true);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0000770B File Offset: 0x0000590B
	internal void method_1(GEnum5 genum5_0)
	{
		this.gclass20_0.GClass23_0.smethod_10(genum5_0);
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0000771E File Offset: 0x0000591E
	public override string ToString()
	{
		return this.gclass20_0.GClass22_0.ToString();
	}

	// Token: 0x04000362 RID: 866
	private GClass20 gclass20_0;

	// Token: 0x04000363 RID: 867
	private GClass7 gclass7_0;

	// Token: 0x02000090 RID: 144
	[CompilerGenerated]
	private sealed class Class78 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IDisposable, IEnumerator
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00007730 File Offset: 0x00005930
		[DebuggerHidden]
		public Class78(int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000774A File Offset: 0x0000594A
		[DebuggerHidden]
		public void Dispose()
		{
			this.string_1 = null;
			this.int_0 = -2;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00032BDC File Offset: 0x00030DDC
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			GClass29 gclass = this.gclass29_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
			}
			else
			{
				this.int_0 = -1;
				string text = gclass.gclass20_0.GClass22_0.NameValueCollection_0["Sec-WebSocket-Protocol"];
				if (text != null && text.Length != 0)
				{
					this.string_1 = text.Split(new char[] { ',' });
					this.int_2 = 0;
					goto IL_0096;
				}
				return false;
			}
			IL_0088:
			this.int_2++;
			IL_0096:
			if (this.int_2 >= this.string_1.Length)
			{
				this.string_1 = null;
				return false;
			}
			string text2 = this.string_1[this.int_2].Trim();
			if (text2.Length == 0)
			{
				goto IL_0088;
			}
			this.string_0 = text2;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0000775B File Offset: 0x0000595B
		public string Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00003657 File Offset: 0x00001857
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0000775B File Offset: 0x0000595B
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00032CAC File Offset: 0x00030EAC
		[DebuggerHidden]
		public IEnumerator<string> GetEnumerator()
		{
			GClass29.Class78 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass29.Class78(0);
				@class.gclass29_0 = this.gclass29_0;
			}
			return @class;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00007763 File Offset: 0x00005963
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000364 RID: 868
		private int int_0;

		// Token: 0x04000365 RID: 869
		private string string_0;

		// Token: 0x04000366 RID: 870
		private int int_1;

		// Token: 0x04000367 RID: 871
		public GClass29 gclass29_0;

		// Token: 0x04000368 RID: 872
		private string[] string_1;

		// Token: 0x04000369 RID: 873
		private int int_2;
	}
}
