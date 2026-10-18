// Token: 0x02000168 RID: 360
internal partial class AlarmContainer : global::System.Windows.Forms.Form
{
	// Token: 0x060015F1 RID: 5617 RVA: 0x0000F7F1 File Offset: 0x0000D9F1
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x000ADC44 File Offset: 0x000ABE44
	private void InitializeComponent()
	{
		base.SuspendLayout();
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(300, 30);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Name = "AlarmContainer";
		base.ShowInTaskbar = false;
		this.Text = "AlarmContainer";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.AlarmContainer_Load);
		base.ControlRemoved += new global::System.Windows.Forms.ControlEventHandler(this.AlarmContainer_ControlRemoved);
		base.ResumeLayout(false);
	}

	// Token: 0x04000D32 RID: 3378
	private global::System.ComponentModel.IContainer icontainer_0;
}
