// Token: 0x0200015F RID: 351
internal partial class TabChat : global::System.Windows.Forms.UserControl
{
	// Token: 0x060015C7 RID: 5575 RVA: 0x0000F683 File Offset: 0x0000D883
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x000AC63C File Offset: 0x000AA83C
	private void InitializeComponent()
	{
		this.panelTop = new global::System.Windows.Forms.Panel();
		this.lblTitle = new global::System.Windows.Forms.Label();
		this.lblMeta = new global::System.Windows.Forms.Label();
		this.rtbChat = new global::System.Windows.Forms.RichTextBox();
		this.panelBottom = new global::System.Windows.Forms.Panel();
		this.btnSend = new global::System.Windows.Forms.Button();
		this.txtInput = new global::System.Windows.Forms.TextBox();
		this.panelTop.SuspendLayout();
		this.panelBottom.SuspendLayout();
		base.SuspendLayout();
		this.panelTop.Controls.Add(this.lblTitle);
		this.panelTop.Controls.Add(this.lblMeta);
		this.panelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelTop.Location = new global::System.Drawing.Point(0, 0);
		this.panelTop.Name = "panelTop";
		this.panelTop.Size = new global::System.Drawing.Size(640, 32);
		this.panelTop.TabIndex = 0;
		this.lblTitle.AutoSize = false;
		this.lblTitle.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9f);
		this.lblTitle.Location = new global::System.Drawing.Point(10, 0);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new global::System.Drawing.Size(220, 32);
		this.lblTitle.TabIndex = 0;
		this.lblTitle.Text = "-";
		this.lblTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.lblMeta.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
		this.lblMeta.AutoEllipsis = true;
		this.lblMeta.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
		this.lblMeta.Location = new global::System.Drawing.Point(230, 0);
		this.lblMeta.Name = "lblMeta";
		this.lblMeta.Size = new global::System.Drawing.Size(400, 32);
		this.lblMeta.TabIndex = 1;
		this.lblMeta.Text = "Offline · 0 online";
		this.lblMeta.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.rtbChat.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.rtbChat.DetectUrls = false;
		this.rtbChat.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.rtbChat.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
		this.rtbChat.Location = new global::System.Drawing.Point(0, 32);
		this.rtbChat.Name = "rtbChat";
		this.rtbChat.ReadOnly = true;
		this.rtbChat.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.rtbChat.Size = new global::System.Drawing.Size(640, 388);
		this.rtbChat.TabIndex = 1;
		this.rtbChat.Text = "";
		this.rtbChat.WordWrap = true;
		this.panelBottom.Controls.Add(this.txtInput);
		this.panelBottom.Controls.Add(this.btnSend);
		this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panelBottom.Location = new global::System.Drawing.Point(0, 420);
		this.panelBottom.Name = "panelBottom";
		this.panelBottom.Size = new global::System.Drawing.Size(640, 44);
		this.panelBottom.TabIndex = 2;
		this.txtInput.Font = new global::System.Drawing.Font("Segoe UI", 10f);
		this.txtInput.Location = new global::System.Drawing.Point(8, 10);
		this.txtInput.MaxLength = 300;
		this.txtInput.Name = "txtInput";
		this.txtInput.Size = new global::System.Drawing.Size(540, 25);
		this.txtInput.TabIndex = 0;
		this.txtInput.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
		this.btnSend.FlatAppearance.BorderSize = 0;
		this.btnSend.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9f);
		this.btnSend.Location = new global::System.Drawing.Point(556, 8);
		this.btnSend.Name = "btnSend";
		this.btnSend.Size = new global::System.Drawing.Size(72, 28);
		this.btnSend.TabIndex = 1;
		this.btnSend.Text = "Gửi";
		this.btnSend.UseVisualStyleBackColor = false;
		this.btnSend.Click += new global::System.EventHandler(this.btnSend_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.rtbChat);
		base.Controls.Add(this.panelBottom);
		base.Controls.Add(this.panelTop);
		base.Name = "TabChat";
		base.Size = new global::System.Drawing.Size(640, 460);
		this.panelTop.ResumeLayout(false);
		this.panelBottom.ResumeLayout(false);
		this.panelBottom.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000D0D RID: 3341
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000D0E RID: 3342
	private global::System.Windows.Forms.Panel panelTop;

	// Token: 0x04000D0F RID: 3343
	private global::System.Windows.Forms.Label lblTitle;

	// Token: 0x04000D10 RID: 3344
	private global::System.Windows.Forms.Label lblMeta;

	// Token: 0x04000D11 RID: 3345
	private global::System.Windows.Forms.RichTextBox rtbChat;

	// Token: 0x04000D12 RID: 3346
	private global::System.Windows.Forms.Panel panelBottom;

	// Token: 0x04000D13 RID: 3347
	private global::System.Windows.Forms.TextBox txtInput;

	// Token: 0x04000D14 RID: 3348
	private global::System.Windows.Forms.Button btnSend;
}
