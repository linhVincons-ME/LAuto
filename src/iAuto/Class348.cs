using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

// Token: 0x02000213 RID: 531
internal class Class348 : UITypeEditor
{
	// Token: 0x06001D3B RID: 7483 RVA: 0x00013CF1 File Offset: 0x00011EF1
	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return UITypeEditorEditStyle.Modal;
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000DF300 File Offset: 0x000DD500
	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (provider != null && (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService)) != null)
		{
			HotkeysEditorForm hotkeysEditorForm = new HotkeysEditorForm(Class347.smethod_0(value as string));
			if (hotkeysEditorForm.ShowDialog() == DialogResult.OK)
			{
				value = hotkeysEditorForm.method_2().ToString();
			}
		}
		return value;
	}
}
