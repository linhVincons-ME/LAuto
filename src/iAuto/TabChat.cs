using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200015F RID: 351
internal partial class TabChat : UserControl
{
	// Token: 0x060015B5 RID: 5557 RVA: 0x000ABE34 File Offset: 0x000AA034
	public TabChat()
	{
		this.InitializeComponent();
		this.method_0();
		Class238.Event_0 += this.method_6;
		Class238.Event_1 += this.method_8;
		Class238.Event_2 += this.method_9;
		Class238.Event_3 += this.method_10;
		Class238.Event_4 += this.method_7;
		base.Load += this.TabChat_Load;
		base.Resize += this.TabChat_Resize;
		this.panelBottom.Resize += this.panelBottom_Resize;
		base.Disposed += this.TabChat_Disposed;
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x000ABF00 File Offset: 0x000AA100
	private void method_0()
	{
		this.BackColor = TabChat.color_0;
		this.panelTop.BackColor = TabChat.color_1;
		this.panelBottom.BackColor = TabChat.color_1;
		this.rtbChat.BackColor = TabChat.color_0;
		this.rtbChat.ForeColor = TabChat.color_3;
		this.txtInput.BackColor = Color.FromArgb(35, 39, 47);
		this.txtInput.ForeColor = TabChat.color_3;
		this.txtInput.BorderStyle = BorderStyle.FixedSingle;
		this.btnSend.FlatStyle = FlatStyle.Flat;
		this.btnSend.FlatAppearance.BorderColor = TabChat.color_2;
		this.btnSend.BackColor = TabChat.color_5;
		this.btnSend.ForeColor = Color.White;
		this.lblTitle.ForeColor = TabChat.color_3;
		this.lblMeta.ForeColor = TabChat.color_4;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x000ABFEC File Offset: 0x000AA1EC
	private void method_1()
	{
		int width = this.panelTop.ClientSize.Width;
		this.lblTitle.Location = new Point(10, 0);
		this.lblTitle.Size = new Size(Math.Min(200, Math.Max(80, width / 3)), 32);
		int num = this.lblTitle.Right + 8;
		this.lblMeta.Location = new Point(num, 0);
		this.lblMeta.Size = new Size(Math.Max(60, width - num - 10), 32);
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x000AC088 File Offset: 0x000AA288
	private void method_2()
	{
		int height = this.panelBottom.ClientSize.Height;
		int width = this.panelBottom.ClientSize.Width;
		this.btnSend.Size = new Size(72, 28);
		this.btnSend.Location = new Point(Math.Max(8, width - 8 - this.btnSend.Width), Math.Max(0, (height - this.btnSend.Height) / 2));
		this.txtInput.Height = 25;
		this.txtInput.Location = new Point(8, Math.Max(0, (height - this.txtInput.Height) / 2));
		this.txtInput.Width = Math.Max(40, this.btnSend.Left - 8 - 8);
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x000AC160 File Offset: 0x000AA360
	private void method_3()
	{
		this.lblMeta.Text = this.string_0 + "  ·  " + this.int_0.ToString() + " online";
		this.lblMeta.ForeColor = (this.bool_0 ? TabChat.color_6 : TabChat.color_4);
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x0000F648 File Offset: 0x0000D848
	private void TabChat_Load(object sender, EventArgs e)
	{
		this.method_1();
		this.method_2();
		this.method_4();
		this.method_5();
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x000AC1B8 File Offset: 0x000AA3B8
	private void method_4()
	{
		GUI gui_ = GUI.GUI_0;
		string text;
		if (gui_ != null)
		{
			if ((text = gui_.String_2) != null)
			{
				goto IL_001A;
			}
		}
		text = "";
		IL_001A:
		string text2 = Class238.smethod_11(text);
		this.lblTitle.Text = (string.IsNullOrWhiteSpace(text2) ? "Chưa đăng nhập" : text2);
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x000AC200 File Offset: 0x000AA400
	public void method_5()
	{
		this.method_4();
		GUI gui_ = GUI.GUI_0;
		string text;
		if (gui_ != null)
		{
			if ((text = gui_.String_2) != null)
			{
				goto IL_0020;
			}
		}
		text = "";
		IL_0020:
		string text2 = Class238.smethod_11(text);
		if (string.IsNullOrWhiteSpace(text2))
		{
			this.string_0 = "Cần đăng nhập";
			this.bool_0 = false;
			this.method_3();
			return;
		}
		if (!Class238.Boolean_0 || !string.Equals(Class238.String_0, text2, StringComparison.OrdinalIgnoreCase))
		{
			Class238.smethod_1(text2);
		}
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x000AC270 File Offset: 0x000AA470
	private void method_6(string string_1, string string_2, string string_3)
	{
		TabChat.Class242 @class = new TabChat.Class242();
		@class.tabChat_0 = this;
		@class.string_0 = string_1;
		@class.string_1 = string_2;
		@class.string_2 = string_3;
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(@class.method_0));
		}
		catch
		{
		}
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x000AC2D4 File Offset: 0x000AA4D4
	private void method_7(List<ValueTuple<string, string, string>> list_0)
	{
		TabChat.Class243 @class = new TabChat.Class243();
		@class.tabChat_0 = this;
		@class.list_0 = list_0;
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(@class.method_0));
		}
		catch
		{
		}
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x000AC328 File Offset: 0x000AA528
	private void method_8(string string_1)
	{
		TabChat.Class244 @class = new TabChat.Class244();
		@class.tabChat_0 = this;
		@class.string_0 = string_1;
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(@class.method_0));
		}
		catch
		{
		}
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x000AC37C File Offset: 0x000AA57C
	private void method_9(string[] string_1)
	{
		TabChat.Class245 @class = new TabChat.Class245();
		@class.tabChat_0 = this;
		@class.string_0 = string_1;
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(@class.method_0));
		}
		catch
		{
		}
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x000AC3D0 File Offset: 0x000AA5D0
	private void method_10(bool bool_1, string string_1)
	{
		TabChat.Class246 @class = new TabChat.Class246();
		@class.tabChat_0 = this;
		@class.bool_0 = bool_1;
		@class.string_0 = string_1;
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(@class.method_0));
		}
		catch
		{
		}
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x000AC42C File Offset: 0x000AA62C
	private void method_11(string string_1)
	{
		this.rtbChat.SelectionStart = this.rtbChat.TextLength;
		this.rtbChat.SelectionLength = 0;
		this.rtbChat.SelectionColor = TabChat.color_7;
		this.rtbChat.SelectionFont = new Font(this.rtbChat.Font, FontStyle.Italic);
		this.rtbChat.AppendText("· " + string_1 + "\n");
		this.rtbChat.SelectionFont = this.rtbChat.Font;
		this.rtbChat.ScrollToCaret();
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x000AC4C4 File Offset: 0x000AA6C4
	private void method_12(string string_1, string string_2, string string_3, Color color_8, Color color_9)
	{
		this.rtbChat.SelectionStart = this.rtbChat.TextLength;
		this.rtbChat.SelectionLength = 0;
		if (!string.IsNullOrEmpty(string_1))
		{
			this.rtbChat.SelectionColor = TabChat.color_4;
			this.rtbChat.AppendText(string_1 + " ");
		}
		this.rtbChat.SelectionColor = color_8;
		this.rtbChat.SelectionFont = new Font(this.rtbChat.Font, FontStyle.Bold);
		this.rtbChat.AppendText(string_2);
		this.rtbChat.SelectionFont = this.rtbChat.Font;
		this.rtbChat.SelectionColor = TabChat.color_4;
		this.rtbChat.AppendText("  ");
		this.rtbChat.SelectionColor = color_9;
		this.rtbChat.AppendText(string_3 + "\n");
		this.rtbChat.ScrollToCaret();
		if (this.rtbChat.TextLength > 80000)
		{
			this.rtbChat.Select(0, 20000);
			this.rtbChat.SelectedText = "";
		}
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0000F662 File Offset: 0x0000D862
	private void btnSend_Click(object sender, EventArgs e)
	{
		this.method_13();
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0000F66A File Offset: 0x0000D86A
	private void txtInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			this.method_13();
		}
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x000AC5F0 File Offset: 0x000AA7F0
	private void method_13()
	{
		string text = this.txtInput.Text;
		if (string.IsNullOrWhiteSpace(text))
		{
			return;
		}
		if (!Class238.Boolean_0)
		{
			this.method_5();
		}
		Class238.smethod_3(text);
		this.txtInput.Clear();
		this.txtInput.Focus();
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x0000F6A2 File Offset: 0x0000D8A2
	[CompilerGenerated]
	private void TabChat_Resize(object sender, EventArgs e)
	{
		this.method_1();
		this.method_2();
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
	[CompilerGenerated]
	private void panelBottom_Resize(object sender, EventArgs e)
	{
		this.method_2();
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x000ACC04 File Offset: 0x000AAE04
	[CompilerGenerated]
	private void TabChat_Disposed(object sender, EventArgs e)
	{
		Class238.Event_0 -= this.method_6;
		Class238.Event_1 -= this.method_8;
		Class238.Event_2 -= this.method_9;
		Class238.Event_3 -= this.method_10;
		Class238.Event_4 -= this.method_7;
	}

	// Token: 0x04000D02 RID: 3330
	private static readonly Color color_0 = Color.FromArgb(18, 20, 24);

	// Token: 0x04000D03 RID: 3331
	private static readonly Color color_1 = Color.FromArgb(28, 31, 38);

	// Token: 0x04000D04 RID: 3332
	private static readonly Color color_2 = Color.FromArgb(45, 50, 60);

	// Token: 0x04000D05 RID: 3333
	private static readonly Color color_3 = Color.FromArgb(230, 233, 239);

	// Token: 0x04000D06 RID: 3334
	private static readonly Color color_4 = Color.FromArgb(130, 138, 150);

	// Token: 0x04000D07 RID: 3335
	private static readonly Color color_5 = Color.FromArgb(88, 166, 255);

	// Token: 0x04000D08 RID: 3336
	private static readonly Color color_6 = Color.FromArgb(63, 185, 80);

	// Token: 0x04000D09 RID: 3337
	private static readonly Color color_7 = Color.FromArgb(210, 153, 34);

	// Token: 0x04000D0A RID: 3338
	private string string_0 = "Offline";

	// Token: 0x04000D0B RID: 3339
	private int int_0;

	// Token: 0x04000D0C RID: 3340
	private bool bool_0;

	// Token: 0x02000160 RID: 352
	[CompilerGenerated]
	[Serializable]
	private sealed class Class241
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x0000F6C4 File Offset: 0x0000D8C4
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_365(false);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0000BB7E File Offset: 0x00009D7E
		internal void method_1(Class106 class106_0)
		{
			class106_0.method_366();
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0000F6CD File Offset: 0x0000D8CD
		internal void method_2(Class106 class106_0)
		{
			class106_0.method_398(false);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0000F6D6 File Offset: 0x0000D8D6
		internal void method_3(Class106 class106_0)
		{
			class106_0.method_398(true);
		}

		// Token: 0x04000D15 RID: 3349
		public static readonly TabChat.Class241 f_252CA5F3 = new TabChat.Class241();

		// Token: 0x04000D16 RID: 3350
		public static Action<Class106> f_A9BA482B;

		// Token: 0x04000D17 RID: 3351
		public static Action<Class106> f_78C5DE60;

		// Token: 0x04000D18 RID: 3352
		public static Action<Class106> f_8FA97B13;

		// Token: 0x04000D19 RID: 3353
		public static Action<Class106> f_6EDEFF1A;
	}

	// Token: 0x02000161 RID: 353
	[CompilerGenerated]
	private sealed class Class242
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x000ACC68 File Offset: 0x000AAE68
		internal void method_0()
		{
			if (this.tabChat_0.IsDisposed)
			{
				return;
			}
			bool flag = string.Equals(this.string_0, Class238.String_0, StringComparison.OrdinalIgnoreCase);
			if (Class228.smethod_3(this.string_1))
			{
				if (!this.string_1.StartsWith("#IGOM|CHARS", StringComparison.OrdinalIgnoreCase) && !this.string_1.StartsWith("#IGOM|POS", StringComparison.OrdinalIgnoreCase) && !this.string_1.StartsWith("#IGOM|WHO", StringComparison.OrdinalIgnoreCase) && !this.string_1.StartsWith("#IGOM|TRADE", StringComparison.OrdinalIgnoreCase) && !this.string_1.StartsWith("#IGOM|CHIA", StringComparison.OrdinalIgnoreCase))
				{
					this.tabChat_0.method_12(string.IsNullOrEmpty(this.string_2) ? "" : this.string_2, this.string_0, this.string_1, flag ? TabChat.color_6 : TabChat.color_5, TabChat.color_3);
				}
				return;
			}
			string text = this.string_1.smethod_36();
			if (flag)
			{
				if (GUI.Boolean_0)
				{
					if (text.Contains("batdanhtheokey"))
					{
						foreach (Class106 @class in Class106.List_3)
						{
							@class.method_493("Bật Đánh THeo Key [Ctrl + Q]");
						}
						Class226.Boolean_5 = true;
					}
					if (text.Contains("tatdanhtheokey"))
					{
						foreach (Class106 class2 in Class106.List_3)
						{
							class2.method_493("Tắt Đánh THeo Key [Ctrl + Q]");
						}
						Class226.Boolean_5 = false;
					}
					if (text.Contains("lenngua"))
					{
						foreach (Class106 class3 in Class106.List_3)
						{
							class3.method_493("Lên Ngựa [Ctrl + U]");
						}
						Class106.List_3.ForEach(new Action<Class106>(TabChat.Class241.f_252CA5F3.method_0));
					}
					if (text.Contains("xuongngua"))
					{
						foreach (Class106 class4 in Class106.List_3)
						{
							class4.method_493("Xuống Ngựa [Ctrl + D]");
						}
						Class106.List_3.ForEach(new Action<Class106>(TabChat.Class241.f_252CA5F3.method_1));
					}
					if (text.Contains("tholinhchaudautien"))
					{
						foreach (Class106 class5 in Class106.List_3)
						{
							class5.method_493("Định Vị Thổ Linh Châu Đầu Tiên [Ctrl + Shift + E]");
						}
						Class106.List_3.ForEach(new Action<Class106>(TabChat.Class241.f_252CA5F3.method_2));
					}
					else if (text.Contains("tholinhchau"))
					{
						foreach (Class106 class6 in Class106.List_3)
						{
							class6.method_493("Định Vị Thổ Linh Châu [Ctrl + Shift + Q]");
						}
						Class106.List_3.ForEach(new Action<Class106>(TabChat.Class241.f_252CA5F3.method_3));
					}
					if (text.Contains("batbuoctheosaukey"))
					{
						foreach (Class106 class7 in Class106.List_3)
						{
							class7.method_493("Bật Buộc Theo Sau Key [Ctrl + Shift + F]");
						}
						Class226.Boolean_11 = true;
					}
					if (text.Contains("tatbuoctheosaukey"))
					{
						foreach (Class106 class8 in Class106.List_3)
						{
							class8.method_493("Tắt Buộc Theo Sau Key [Ctrl + Shift + F]");
						}
						Class226.Boolean_11 = false;
					}
					if (text.Contains("batskill"))
					{
						foreach (Class106 class9 in Class106.List_3)
						{
							class9.method_493("Bật Skill [Ctrl + K]");
						}
						CheckBox checkSkill = GUI.GUI_0.checkSkill;
						bool flag2 = true;
						Class226.Boolean_148 = true;
						checkSkill.Checked = flag2;
					}
					if (text.Contains("tatskill"))
					{
						foreach (Class106 class10 in Class106.List_3)
						{
							class10.method_493("Tắt SKill [Ctrl + K]");
						}
						CheckBox checkSkill2 = GUI.GUI_0.checkSkill;
						bool flag3 = false;
						Class226.Boolean_148 = false;
						checkSkill2.Checked = flag3;
					}
					if (text.Contains("khongtheovelacduong"))
					{
						foreach (Class106 class11 in Class106.List_3)
						{
							class11.method_493("Không Theo Về Lạc Dương");
						}
						GUI.setting_0.checkKhongTheoKey.Checked = true;
					}
					else if (text.Contains("theovelacduong"))
					{
						foreach (Class106 class12 in Class106.List_3)
						{
							class12.method_493("Theo Về Lạc Dương");
						}
						GUI.setting_0.checkKhongTheoKey.Checked = false;
					}
					if (text.Contains("batchidanh"))
					{
						foreach (Class106 class13 in Class106.List_3)
						{
							class13.method_493("Bật Chỉ Đánh [Ctrl + Shift + O]");
						}
						TreeNode treeNode = GUI.univer_0.treeView1.Nodes["NodeChiDanh"];
						bool flag4 = true;
						Class226.Boolean_19 = true;
						treeNode.Checked = flag4;
					}
					if (text.Contains("tatchidanh"))
					{
						foreach (Class106 class14 in Class106.List_3)
						{
							class14.method_493("Tắt Chỉ Đánh [Ctrl + Shift + O]");
						}
						TreeNode treeNode2 = GUI.univer_0.treeView1.Nodes["NodeChiDanh"];
						bool flag5 = false;
						Class226.Boolean_19 = false;
						treeNode2.Checked = flag5;
					}
				}
			}
			else
			{
				if (text.Contains("batdanhtheokey"))
				{
					return;
				}
				if (text.Contains("tatdanhtheokey"))
				{
					return;
				}
				if (text.Contains("lenngua"))
				{
					return;
				}
				if (text.Contains("xuongngua"))
				{
					return;
				}
				if (text.Contains("tholinhchau"))
				{
					return;
				}
				if (text.Contains("batbuoctheosaukey"))
				{
					return;
				}
				if (text.Contains("tatbuoctheosaukey"))
				{
					return;
				}
				if (text.Contains("batskill"))
				{
					return;
				}
				if (text.Contains("tatskill"))
				{
					return;
				}
				if (text.Contains("khongtheovelacduong"))
				{
					return;
				}
				if (text.Contains("theovelacduong"))
				{
					return;
				}
				if (text.Contains("chidanh"))
				{
					return;
				}
			}
			this.tabChat_0.method_12(string.IsNullOrEmpty(this.string_2) ? "" : this.string_2, this.string_0, this.string_1, flag ? TabChat.color_6 : TabChat.color_5, TabChat.color_3);
		}

		// Token: 0x04000D1A RID: 3354
		public TabChat tabChat_0;

		// Token: 0x04000D1B RID: 3355
		public string string_0;

		// Token: 0x04000D1C RID: 3356
		public string string_1;

		// Token: 0x04000D1D RID: 3357
		public string string_2;
	}

	// Token: 0x02000162 RID: 354
	[CompilerGenerated]
	private sealed class Class243
	{
		// Token: 0x060015D6 RID: 5590 RVA: 0x000AD428 File Offset: 0x000AB628
		internal void method_0()
		{
			if (this.tabChat_0.IsDisposed)
			{
				return;
			}
			this.tabChat_0.rtbChat.Clear();
			if (this.list_0 != null)
			{
				foreach (ValueTuple<string, string, string> valueTuple in this.list_0)
				{
					bool flag = string.Equals(valueTuple.Item1, Class238.String_0, StringComparison.OrdinalIgnoreCase);
					this.tabChat_0.method_12(string.IsNullOrEmpty(valueTuple.Item3) ? "" : valueTuple.Item3, valueTuple.Item1, valueTuple.Item2, flag ? TabChat.color_6 : TabChat.color_5, TabChat.color_3);
				}
			}
			if (this.list_0 != null && this.list_0.Count > 0)
			{
				this.tabChat_0.method_11("Đã tải " + this.list_0.Count.ToString() + " tin gần nhất");
			}
		}

		// Token: 0x04000D1E RID: 3358
		public TabChat tabChat_0;

		// Token: 0x04000D1F RID: 3359
		public List<ValueTuple<string, string, string>> list_0;
	}

	// Token: 0x02000163 RID: 355
	[CompilerGenerated]
	private sealed class Class244
	{
		// Token: 0x060015D8 RID: 5592 RVA: 0x0000F6DF File Offset: 0x0000D8DF
		internal void method_0()
		{
			if (this.tabChat_0.IsDisposed)
			{
				return;
			}
			this.tabChat_0.method_11(this.string_0);
		}

		// Token: 0x04000D20 RID: 3360
		public TabChat tabChat_0;

		// Token: 0x04000D21 RID: 3361
		public string string_0;
	}

	// Token: 0x02000164 RID: 356
	[CompilerGenerated]
	private sealed class Class245
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x0000F700 File Offset: 0x0000D900
		internal void method_0()
		{
			if (this.tabChat_0.IsDisposed)
			{
				return;
			}
			TabChat tabChat = this.tabChat_0;
			string[] array = this.string_0;
			tabChat.int_0 = ((array != null) ? array.Length : 0);
			this.tabChat_0.method_3();
		}

		// Token: 0x04000D22 RID: 3362
		public TabChat tabChat_0;

		// Token: 0x04000D23 RID: 3363
		public string[] string_0;
	}

	// Token: 0x02000165 RID: 357
	[CompilerGenerated]
	private sealed class Class246
	{
		// Token: 0x060015DC RID: 5596 RVA: 0x000AD538 File Offset: 0x000AB738
		internal void method_0()
		{
			if (this.tabChat_0.IsDisposed)
			{
				return;
			}
			this.tabChat_0.bool_0 = this.bool_0;
			this.tabChat_0.string_0 = (string.IsNullOrWhiteSpace(this.string_0) ? (this.bool_0 ? "Online" : "Offline") : this.string_0);
			this.tabChat_0.method_3();
		}

		// Token: 0x04000D24 RID: 3364
		public TabChat tabChat_0;

		// Token: 0x04000D25 RID: 3365
		public bool bool_0;

		// Token: 0x04000D26 RID: 3366
		public string string_0;
	}
}
