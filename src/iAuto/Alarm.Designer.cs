// Token: 0x02000166 RID: 358
internal partial class Alarm : global::System.Windows.Forms.UserControl
{
	// Token: 0x060015E6 RID: 5606 RVA: 0x0000F772 File Offset: 0x0000D972
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x000AD788 File Offset: 0x000AB988
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.lblClose = new global::System.Windows.Forms.Label();
		this.lblExit = new global::System.Windows.Forms.Label();
		this.lblAlarm = new global::System.Windows.Forms.Label();
		this.lblCharName = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.lblClose.BackColor = global::System.Drawing.Color.Silver;
		this.lblClose.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblClose.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.lblClose.Location = new global::System.Drawing.Point(280, 0);
		this.lblClose.Name = "lblClose";
		this.lblClose.Size = new global::System.Drawing.Size(20, 30);
		this.lblClose.TabIndex = 16;
		this.lblClose.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblClose.Click += new global::System.EventHandler(this.lblClose_Click);
		this.lblExit.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
		this.lblExit.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblExit.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.lblExit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lblExit.ForeColor = global::System.Drawing.Color.Green;
		this.lblExit.Location = new global::System.Drawing.Point(240, 0);
		this.lblExit.Name = "lblExit";
		this.lblExit.Size = new global::System.Drawing.Size(40, 30);
		this.lblExit.TabIndex = 18;
		this.lblExit.Text = "0:00";
		this.lblExit.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblExit.Click += new global::System.EventHandler(this.lblExit_Click);
		this.lblExit.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lblExit_MouseClick);
		this.lblAlarm.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblAlarm.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lblAlarm.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lblAlarm.ForeColor = global::System.Drawing.Color.Red;
		this.lblAlarm.Location = new global::System.Drawing.Point(120, 0);
		this.lblAlarm.Name = "lblAlarm";
		this.lblAlarm.Size = new global::System.Drawing.Size(120, 30);
		this.lblAlarm.TabIndex = 17;
		this.lblAlarm.Text = "Đang có câu hỏi";
		this.lblAlarm.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAlarm.Click += new global::System.EventHandler(this.lblAlarm_Click);
		this.lblCharName.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblCharName.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.lblCharName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lblCharName.ForeColor = global::System.Drawing.Color.Green;
		this.lblCharName.Location = new global::System.Drawing.Point(0, 0);
		this.lblCharName.Name = "lblCharName";
		this.lblCharName.Size = new global::System.Drawing.Size(120, 30);
		this.lblCharName.TabIndex = 15;
		this.lblCharName.Text = "LUCDINHPHONG";
		this.lblCharName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblCharName.Click += new global::System.EventHandler(this.lblCharName_Click);
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.lblAlarm);
		base.Controls.Add(this.lblExit);
		base.Controls.Add(this.lblCharName);
		base.Controls.Add(this.lblClose);
		base.Name = "Alarm";
		base.Size = new global::System.Drawing.Size(300, 30);
		base.Load += new global::System.EventHandler(this.Alarm_Load);
		base.ResumeLayout(false);
	}

	// Token: 0x04000D29 RID: 3369
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000D2A RID: 3370
	private global::System.Windows.Forms.Label lblClose;

	// Token: 0x04000D2B RID: 3371
	private global::System.Windows.Forms.Label lblExit;

	// Token: 0x04000D2C RID: 3372
	private global::System.Windows.Forms.Label lblAlarm;

	// Token: 0x04000D2D RID: 3373
	private global::System.Windows.Forms.Label lblCharName;

	// Token: 0x04000D2E RID: 3374
	private global::System.Windows.Forms.Timer timer_0;
}
