// Token: 0x0200022F RID: 559
internal partial class ReplaceForm : global::System.Windows.Forms.Form
{
	// Token: 0x06001E7F RID: 7807 RVA: 0x0001499B File Offset: 0x00012B9B
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x000E499C File Offset: 0x000E2B9C
	private void InitializeComponent()
	{
		this.btClose = new global::System.Windows.Forms.Button();
		this.btFindNext = new global::System.Windows.Forms.Button();
		this.tbFind = new global::System.Windows.Forms.TextBox();
		this.cbRegex = new global::System.Windows.Forms.CheckBox();
		this.cbMatchCase = new global::System.Windows.Forms.CheckBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.cbWholeWord = new global::System.Windows.Forms.CheckBox();
		this.btReplace = new global::System.Windows.Forms.Button();
		this.btReplaceAll = new global::System.Windows.Forms.Button();
		this.label2 = new global::System.Windows.Forms.Label();
		this.tbReplace = new global::System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.btClose.Location = new global::System.Drawing.Point(273, 153);
		this.btClose.Name = "btClose";
		this.btClose.Size = new global::System.Drawing.Size(75, 23);
		this.btClose.TabIndex = 8;
		this.btClose.Text = "Close";
		this.btClose.UseVisualStyleBackColor = true;
		this.btClose.Click += new global::System.EventHandler(this.btClose_Click);
		this.btFindNext.Location = new global::System.Drawing.Point(111, 124);
		this.btFindNext.Name = "btFindNext";
		this.btFindNext.Size = new global::System.Drawing.Size(75, 23);
		this.btFindNext.TabIndex = 5;
		this.btFindNext.Text = "Find next";
		this.btFindNext.UseVisualStyleBackColor = true;
		this.btFindNext.Click += new global::System.EventHandler(this.btFindNext_Click);
		this.tbFind.Location = new global::System.Drawing.Point(62, 12);
		this.tbFind.Name = "tbFind";
		this.tbFind.Size = new global::System.Drawing.Size(286, 20);
		this.tbFind.TabIndex = 0;
		this.tbFind.TextChanged += new global::System.EventHandler(this.tbReplace_TextChanged);
		this.tbFind.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbReplace_KeyPress);
		this.cbRegex.AutoSize = true;
		this.cbRegex.Location = new global::System.Drawing.Point(273, 38);
		this.cbRegex.Name = "cbRegex";
		this.cbRegex.Size = new global::System.Drawing.Size(57, 17);
		this.cbRegex.TabIndex = 3;
		this.cbRegex.Text = "Regex";
		this.cbRegex.UseVisualStyleBackColor = true;
		this.cbRegex.CheckedChanged += new global::System.EventHandler(this.tbReplace_TextChanged);
		this.cbMatchCase.AutoSize = true;
		this.cbMatchCase.Location = new global::System.Drawing.Point(66, 38);
		this.cbMatchCase.Name = "cbMatchCase";
		this.cbMatchCase.Size = new global::System.Drawing.Size(82, 17);
		this.cbMatchCase.TabIndex = 1;
		this.cbMatchCase.Text = "Match case";
		this.cbMatchCase.UseVisualStyleBackColor = true;
		this.cbMatchCase.CheckedChanged += new global::System.EventHandler(this.tbReplace_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(23, 14);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(33, 13);
		this.label1.TabIndex = 5;
		this.label1.Text = "Find: ";
		this.cbWholeWord.AutoSize = true;
		this.cbWholeWord.Location = new global::System.Drawing.Point(154, 38);
		this.cbWholeWord.Name = "cbWholeWord";
		this.cbWholeWord.Size = new global::System.Drawing.Size(113, 17);
		this.cbWholeWord.TabIndex = 2;
		this.cbWholeWord.Text = "Match whole word";
		this.cbWholeWord.UseVisualStyleBackColor = true;
		this.cbWholeWord.CheckedChanged += new global::System.EventHandler(this.tbReplace_TextChanged);
		this.btReplace.Location = new global::System.Drawing.Point(192, 124);
		this.btReplace.Name = "btReplace";
		this.btReplace.Size = new global::System.Drawing.Size(75, 23);
		this.btReplace.TabIndex = 6;
		this.btReplace.Text = "Replace";
		this.btReplace.UseVisualStyleBackColor = true;
		this.btReplace.Click += new global::System.EventHandler(this.btReplace_Click);
		this.btReplaceAll.Location = new global::System.Drawing.Point(273, 124);
		this.btReplaceAll.Name = "btReplaceAll";
		this.btReplaceAll.Size = new global::System.Drawing.Size(75, 23);
		this.btReplaceAll.TabIndex = 7;
		this.btReplaceAll.Text = "Replace all";
		this.btReplaceAll.UseVisualStyleBackColor = true;
		this.btReplaceAll.Click += new global::System.EventHandler(this.btReplaceAll_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(6, 81);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(50, 13);
		this.label2.TabIndex = 9;
		this.label2.Text = "Replace:";
		this.tbReplace.Location = new global::System.Drawing.Point(62, 78);
		this.tbReplace.Name = "tbReplace";
		this.tbReplace.Size = new global::System.Drawing.Size(286, 20);
		this.tbReplace.TabIndex = 0;
		this.tbReplace.TextChanged += new global::System.EventHandler(this.tbReplace_TextChanged);
		this.tbReplace.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbReplace_KeyPress);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(360, 191);
		base.Controls.Add(this.tbFind);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.tbReplace);
		base.Controls.Add(this.btReplaceAll);
		base.Controls.Add(this.btReplace);
		base.Controls.Add(this.cbWholeWord);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.cbMatchCase);
		base.Controls.Add(this.cbRegex);
		base.Controls.Add(this.btFindNext);
		base.Controls.Add(this.btClose);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "ReplaceForm";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Find and replace";
		base.TopMost = true;
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400131B RID: 4891
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x0400131C RID: 4892
	private global::System.Windows.Forms.Button btClose;

	// Token: 0x0400131D RID: 4893
	private global::System.Windows.Forms.Button btFindNext;

	// Token: 0x0400131E RID: 4894
	private global::System.Windows.Forms.CheckBox cbRegex;

	// Token: 0x0400131F RID: 4895
	private global::System.Windows.Forms.CheckBox cbMatchCase;

	// Token: 0x04001320 RID: 4896
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04001321 RID: 4897
	private global::System.Windows.Forms.CheckBox cbWholeWord;

	// Token: 0x04001322 RID: 4898
	private global::System.Windows.Forms.Button btReplace;

	// Token: 0x04001323 RID: 4899
	private global::System.Windows.Forms.Button btReplaceAll;

	// Token: 0x04001324 RID: 4900
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04001325 RID: 4901
	public global::System.Windows.Forms.TextBox tbFind;

	// Token: 0x04001326 RID: 4902
	public global::System.Windows.Forms.TextBox tbReplace;
}
