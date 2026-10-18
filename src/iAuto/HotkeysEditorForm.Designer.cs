// Token: 0x02000214 RID: 532
internal partial class HotkeysEditorForm : global::System.Windows.Forms.Form
{
	// Token: 0x06001D48 RID: 7496 RVA: 0x00013D41 File Offset: 0x00011F41
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
	private void InitializeComponent()
	{
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.dgv = new global::System.Windows.Forms.DataGridView();
		this.cbModifiers = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
		this.cbKey = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
		this.cbAction = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
		this.btAdd = new global::System.Windows.Forms.Button();
		this.btRemove = new global::System.Windows.Forms.Button();
		this.btCancel = new global::System.Windows.Forms.Button();
		this.btOk = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.btResore = new global::System.Windows.Forms.Button();
		((global::System.ComponentModel.ISupportInitialize)this.dgv).BeginInit();
		base.SuspendLayout();
		this.dgv.AllowUserToAddRows = false;
		this.dgv.AllowUserToDeleteRows = false;
		this.dgv.AllowUserToResizeColumns = false;
		this.dgv.AllowUserToResizeRows = false;
		this.dgv.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
		this.dgv.BackgroundColor = global::System.Drawing.SystemColors.Control;
		this.dgv.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgv.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.cbModifiers, this.cbKey, this.cbAction });
		dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
		dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.LightSteelBlue;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.dgv.DefaultCellStyle = dataGridViewCellStyle;
		this.dgv.GridColor = global::System.Drawing.SystemColors.Control;
		this.dgv.Location = new global::System.Drawing.Point(12, 28);
		this.dgv.Name = "dgv";
		this.dgv.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.dgv.RowHeadersVisible = false;
		this.dgv.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dgv.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgv.Size = new global::System.Drawing.Size(525, 278);
		this.dgv.TabIndex = 0;
		this.dgv.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
		this.cbModifiers.DataPropertyName = "Modifiers";
		this.cbModifiers.DisplayStyle = global::System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.cbModifiers.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.cbModifiers.HeaderText = "Modifiers";
		this.cbModifiers.Name = "cbModifiers";
		this.cbKey.DataPropertyName = "Key";
		this.cbKey.DisplayStyle = global::System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.cbKey.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.cbKey.HeaderText = "Key";
		this.cbKey.Name = "cbKey";
		this.cbKey.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
		this.cbKey.Width = 120;
		this.cbAction.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cbAction.DataPropertyName = "Action";
		this.cbAction.DisplayStyle = global::System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.cbAction.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.cbAction.HeaderText = "Action";
		this.cbAction.Name = "cbAction";
		this.btAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.btAdd.Location = new global::System.Drawing.Point(13, 322);
		this.btAdd.Name = "btAdd";
		this.btAdd.Size = new global::System.Drawing.Size(75, 23);
		this.btAdd.TabIndex = 1;
		this.btAdd.Text = "Add";
		this.btAdd.UseVisualStyleBackColor = true;
		this.btAdd.Click += new global::System.EventHandler(this.btAdd_Click);
		this.btRemove.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.btRemove.Location = new global::System.Drawing.Point(103, 322);
		this.btRemove.Name = "btRemove";
		this.btRemove.Size = new global::System.Drawing.Size(75, 23);
		this.btRemove.TabIndex = 2;
		this.btRemove.Text = "Remove";
		this.btRemove.UseVisualStyleBackColor = true;
		this.btRemove.Click += new global::System.EventHandler(this.btRemove_Click);
		this.btCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
		this.btCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btCancel.Location = new global::System.Drawing.Point(460, 322);
		this.btCancel.Name = "btCancel";
		this.btCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btCancel.TabIndex = 4;
		this.btCancel.Text = "Cancel";
		this.btCancel.UseVisualStyleBackColor = true;
		this.btOk.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
		this.btOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btOk.Location = new global::System.Drawing.Point(379, 322);
		this.btOk.Name = "btOk";
		this.btOk.Size = new global::System.Drawing.Size(75, 23);
		this.btOk.TabIndex = 3;
		this.btOk.Text = "OK";
		this.btOk.UseVisualStyleBackColor = true;
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(114, 16);
		this.label1.TabIndex = 5;
		this.label1.Text = "Hotkeys mapping";
		this.btResore.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
		this.btResore.Location = new global::System.Drawing.Point(194, 322);
		this.btResore.Name = "btResore";
		this.btResore.Size = new global::System.Drawing.Size(105, 23);
		this.btResore.TabIndex = 6;
		this.btResore.Text = "Restore default";
		this.btResore.UseVisualStyleBackColor = true;
		this.btResore.Click += new global::System.EventHandler(this.btResore_Click);
		base.AcceptButton = this.btOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btCancel;
		base.ClientSize = new global::System.Drawing.Size(549, 357);
		base.Controls.Add(this.btResore);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btCancel);
		base.Controls.Add(this.btOk);
		base.Controls.Add(this.btRemove);
		base.Controls.Add(this.btAdd);
		base.Controls.Add(this.dgv);
		this.MaximumSize = new global::System.Drawing.Size(565, 700);
		this.MinimumSize = new global::System.Drawing.Size(565, 395);
		base.Name = "HotkeysEditorForm";
		base.ShowIcon = false;
		this.Text = "Hotkeys Editor";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.HotkeysEditorForm_FormClosing);
		((global::System.ComponentModel.ISupportInitialize)this.dgv).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04001263 RID: 4707
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04001264 RID: 4708
	private global::System.Windows.Forms.DataGridView dgv;

	// Token: 0x04001265 RID: 4709
	private global::System.Windows.Forms.Button btAdd;

	// Token: 0x04001266 RID: 4710
	private global::System.Windows.Forms.Button btRemove;

	// Token: 0x04001267 RID: 4711
	private global::System.Windows.Forms.Button btCancel;

	// Token: 0x04001268 RID: 4712
	private global::System.Windows.Forms.Button btOk;

	// Token: 0x04001269 RID: 4713
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400126A RID: 4714
	private global::System.Windows.Forms.Button btResore;

	// Token: 0x0400126B RID: 4715
	private global::System.Windows.Forms.DataGridViewComboBoxColumn cbModifiers;

	// Token: 0x0400126C RID: 4716
	private global::System.Windows.Forms.DataGridViewComboBoxColumn cbKey;

	// Token: 0x0400126D RID: 4717
	private global::System.Windows.Forms.DataGridViewComboBoxColumn cbAction;
}
