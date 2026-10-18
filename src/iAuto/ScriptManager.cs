using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x020002E6 RID: 742
internal partial class ScriptManager : Form
{
	// Token: 0x0600286C RID: 10348 RVA: 0x0001B337 File Offset: 0x00019537
	public ScriptManager(Class524 class524_1, Class106 class106_1)
	{
		this.class106_0 = class106_1;
		this.class524_0 = class524_1;
		this.InitializeComponent();
	}

	// Token: 0x0600286D RID: 10349 RVA: 0x001214DC File Offset: 0x0011F6DC
	private void ScriptManager_Load(object sender, EventArgs e)
	{
		this.txtID.Text = this.class524_0.String_0;
		this.txtMD.Text = this.class524_0.String_3;
		this.txtInfo.Text = this.class524_0.String_13;
		if (this.class524_0.String_7.Length == 12)
		{
			this.recvID.Value = Class515.smethod_4(this.class524_0.String_7.Substring(0, 3));
			try
			{
				this.recvX.Value = Class515.smethod_4(this.class524_0.String_7.Substring(3, 3));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			this.recvY.Value = Class515.smethod_4(this.class524_0.String_7.Substring(6, 3));
			this.recvMAP.Value = Class515.smethod_4(this.class524_0.String_7.Substring(9, 3));
		}
		if (this.class524_0.String_9.Length == 12)
		{
			this.sendID.Value = Class515.smethod_4(this.class524_0.String_9.Substring(0, 3));
			this.sendX.Value = Class515.smethod_4(this.class524_0.String_9.Substring(3, 3));
			this.sendY.Value = Class515.smethod_4(this.class524_0.String_9.Substring(6, 3));
			this.sendMAP.Value = Class515.smethod_4(this.class524_0.String_9.Substring(9, 3));
		}
		this.txdDo.Text = this.class524_0.String_12;
		this.atk1MD.Text = this.class524_0.Class530_1.String_1;
		this.atk1X.Value = this.class524_0.Class530_1.Int32_1;
		this.atk1Y.Value = this.class524_0.Class530_1.Int32_2;
		this.atk1Map.Value = this.class524_0.Class530_1.Int32_3;
		this.atk2MD.Text = this.class524_0.Class530_2.String_1;
		this.atk2X.Value = this.class524_0.Class530_2.Int32_1;
		this.atk2Y.Value = this.class524_0.Class530_2.Int32_2;
		this.atk2Map.Value = this.class524_0.Class530_2.Int32_3;
		this.atk3MD.Text = this.class524_0.Class530_3.String_1;
		this.atk3X.Value = this.class524_0.Class530_3.Int32_1;
		this.atk3Y.Value = this.class524_0.Class530_3.Int32_2;
		this.atk3Map.Value = this.class524_0.Class530_3.Int32_3;
		this.chkPick.Checked = this.class524_0.Boolean_4;
		this.chkIsThuThap.Checked = this.class524_0.Boolean_5;
		this.chkCompleted.Checked = this.class524_0.Boolean_2;
		this.chkUseItem.Checked = this.class524_0.Boolean_3;
		this.txtName.Text = this.class524_0.String_6;
		this.nudColloect.Value = Class531.smethod_19(this.class524_0.String_8);
		this.chkComplete.Checked = this.class524_0.Boolean_1;
		this.txtMonter.Text = this.class524_0.String_4;
		this.chkBienThan.Checked = this.class524_0.Boolean_7;
	}

	// Token: 0x14000049 RID: 73
	// (add) Token: 0x0600286E RID: 10350 RVA: 0x0012190C File Offset: 0x0011FB0C
	// (remove) Token: 0x0600286F RID: 10351 RVA: 0x00121944 File Offset: 0x0011FB44
	public event EventHandler Event_0
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x0012197C File Offset: 0x0011FB7C
	public void btnEdit_Click(object sender, EventArgs e)
	{
		this.class524_0.String_0 = this.txtID.Text;
		this.class524_0.String_3 = this.txtMD.Text;
		this.class524_0.String_7 = ScriptManager.smethod_0(this.recvID.Value) + ScriptManager.smethod_0(this.recvX.Value) + ScriptManager.smethod_0(this.recvY.Value) + ScriptManager.smethod_0(this.recvMAP.Value);
		this.class524_0.String_9 = ScriptManager.smethod_0(this.sendID.Value) + ScriptManager.smethod_0(this.sendX.Value) + ScriptManager.smethod_0(this.sendY.Value) + ScriptManager.smethod_0(this.sendMAP.Value);
		this.class524_0.String_12 = this.txdDo.Text;
		this.class524_0.String_6 = this.txtName.Text;
		this.class524_0.String_13 = this.txtInfo.Text;
		this.class524_0.String_4 = this.txtMonter.Text;
		Class521.smethod_4();
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, null);
		}
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x00121AC8 File Offset: 0x0011FCC8
	public static string smethod_0(decimal decimal_0)
	{
		return ((int)decimal_0).ToString("X8").Substring(5, 3);
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x0000500B File Offset: 0x0000320B
	private void recvClick1_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002873 RID: 10355 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk1MD_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x0001B353 File Offset: 0x00019553
	private void button1_Click(object sender, EventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x00121AF0 File Offset: 0x0011FCF0
	private void method_0()
	{
		string text;
		if (this.class524_0.String_12.Length >= 58)
		{
			text = this.class524_0.String_12.Substring(42, 16);
		}
		else
		{
			text = "0000000000000000";
		}
		if (this.class524_0.String_12.Length > 6)
		{
			this.class524_0.String_12 = this.class524_0.String_12.Substring(0, 6);
		}
		else
		{
			this.class524_0.String_12 = "000000";
		}
		this.txdDo.Text = string.Concat(new string[]
		{
			this.class524_0.String_12,
			this.atk1MD.Text,
			ScriptManager.smethod_0(this.atk1X.Value),
			ScriptManager.smethod_0(this.atk1Y.Value),
			ScriptManager.smethod_0(this.atk1Map.Value)
		});
		this.txdDo.Text = string.Concat(new string[]
		{
			this.txdDo.Text,
			this.atk2MD.Text,
			ScriptManager.smethod_0(this.atk2X.Value),
			ScriptManager.smethod_0(this.atk2Y.Value),
			ScriptManager.smethod_0(this.atk2Map.Value)
		});
		this.txdDo.Text = string.Concat(new string[]
		{
			this.txdDo.Text,
			this.atk3MD.Text,
			ScriptManager.smethod_0(this.atk3X.Value),
			ScriptManager.smethod_0(this.atk3Y.Value),
			ScriptManager.smethod_0(this.atk3Map.Value)
		});
		if (text != "")
		{
			this.txdDo.Text = this.txdDo.Text + text;
		}
		else
		{
			this.txdDo.Text = this.txdDo.Text + "1000000000000000";
		}
		this.class524_0.String_12 = this.txdDo.Text;
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x0001B35B File Offset: 0x0001955B
	private void method_1(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_2 = !this.class524_0.Boolean_2;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x0001B394 File Offset: 0x00019594
	private void method_2(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_3 = !this.class524_0.Boolean_3;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x0001B3CD File Offset: 0x000195CD
	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Int32_0 = (int)this.numericUpDown1.Value;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x0001B408 File Offset: 0x00019608
	private void numericUpDown2_ValueChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Int32_1 = (int)this.numericUpDown2.Value;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x00121D18 File Offset: 0x0011FF18
	private void btnGet_Click(object sender, EventArgs e)
	{
		this.atk1X.Value = (int)this.class106_0.Single_5;
		this.atk1Y.Value = (int)this.class106_0.Single_6;
		this.atk1Map.Value = this.class106_0.Class527_0.Int32_35;
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x00121D80 File Offset: 0x0011FF80
	private void nudColloect_ValueChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.String_8 = this.nudColloect.Value.ToString();
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x0001B443 File Offset: 0x00019643
	private void method_3(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_1 = !this.class524_0.Boolean_1;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x0001B47C File Offset: 0x0001967C
	private void chkPick_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_4 = this.chkPick.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x0001B4B2 File Offset: 0x000196B2
	private void chkCompleted_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_2 = this.chkCompleted.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x0001B4E8 File Offset: 0x000196E8
	private void chkUseItem_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_3 = this.chkUseItem.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x0001B51E File Offset: 0x0001971E
	private void chkIsThuThap_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_5 = this.chkIsThuThap.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x0000500B File Offset: 0x0000320B
	private void txtInfoEx_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x0001B554 File Offset: 0x00019754
	private void chkComplete_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_1 = this.chkComplete.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x0001B58A File Offset: 0x0001978A
	private void chkBienThan_CheckedChanged(object sender, EventArgs e)
	{
		this.button1_Click(null, null);
		this.class524_0.Boolean_7 = this.chkBienThan.Checked;
		this.txdDo.Text = this.class524_0.String_12;
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk1X_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk1Y_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk1Map_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk2X_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk2Y_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk2Map_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk3X_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk3Y_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x0000500B File Offset: 0x0000320B
	private void atk3Map_ValueChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x00121DCC File Offset: 0x0011FFCC
	private void button2_Click(object sender, EventArgs e)
	{
		this.class106_0.method_375("MISSIONINFO = ''; cnt = 0; while true do local name, content = DataPool:GetPlayerMission_Memo(cnt); if string.len(name) > 0 then MISSIONINFO = MISSIONINFO .. name .. '=' .. content .. ';'; end cnt = cnt + 1; if cnt == 20 then return end end return MISSIONINFO;", false);
		this.class106_0.method_488(false);
		string text = this.class106_0.method_488(false);
		MessageBox.Show(text);
		if (MessageBox.Show(this, "Bạn có muốn thêm info", "MicroAuto", MessageBoxButtons.YesNo) == DialogResult.Yes)
		{
			text = text.Replace("=", ":");
			text = text.Replace("   ", "");
			text = text.Replace("  ", "");
			text.Trim(new char[] { ';' });
			foreach (string text2 in text.Split(new char[] { ';' }))
			{
				new ListViewItem(text2.Split(new char[] { '=' })[0]).SubItems.Add(text2.Split(new char[] { '=' })[1]);
			}
		}
	}

	// Token: 0x04001B56 RID: 6998
	private readonly Class106 class106_0;

	// Token: 0x04001B57 RID: 6999
	private readonly Class524 class524_0;

	// Token: 0x04001B58 RID: 7000
	[CompilerGenerated]
	private EventHandler eventHandler_0;
}
