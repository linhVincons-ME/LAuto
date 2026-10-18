using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

internal static class DarkTheme
{
	public static readonly Color Bg = Color.FromArgb(18, 24, 36);
	public static readonly Color Surface = Color.FromArgb(26, 34, 52);
	public static readonly Color ButtonSurface = Color.FromArgb(30, 41, 59);
	public static readonly Color Input = Color.FromArgb(15, 23, 42);
	public static readonly Color Border = Color.FromArgb(51, 65, 85);
	public static readonly Color Text = Color.FromArgb(241, 245, 249);
	public static readonly Color TextMuted = Color.FromArgb(148, 163, 184);
	public static readonly Color TextDisabled = Color.FromArgb(100, 116, 139);
	public static readonly Color Accent = Color.FromArgb(56, 189, 248);
	public static readonly Color AccentHover = Color.FromArgb(14, 165, 233);

	[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("dwmapi.dll")]
	public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

	private const int LVM_GETHEADER = 0x101F;
	private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

	private static readonly HashSet<Control> HookedContainers = new HashSet<Control>();
	private static readonly HashSet<ComboBox> StyledCombos = new HashSet<ComboBox>();
	private static readonly HashSet<GroupBox> StyledGroupBoxes = new HashSet<GroupBox>();

	private static bool ToolStripManagerInitialized = false;
	private static readonly HashSet<Form> ThemedForms = new HashSet<Form>();
	private static bool FormsHooked = false;

	public static void HookApplicationForms()
	{
		if (FormsHooked) return;
		FormsHooked = true;
		try
		{
			Application.Idle += (s, e) =>
			{
				try
				{
					foreach (Form f in Application.OpenForms)
					{
						if (f != null && !ThemedForms.Contains(f))
						{
							ThemedForms.Add(f);
							Apply(f);
						}
					}
				}
				catch {}
			};
		}
		catch {}
	}

	public static void Apply(Control root)
	{
		if (root == null)
		{
			return;
		}

		try
		{
			HookApplicationForms();

			if (!ToolStripManagerInitialized)
			{
				ToolStripManagerInitialized = true;
				try
				{
					ToolStripManager.Renderer = new ModernDarkToolStripRenderer();
					ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
				}
				catch {}
			}

			// Hook dynamic control additions
			if (root.HasChildren && !HookedContainers.Contains(root))
			{
				HookedContainers.Add(root);
				root.ControlAdded += Container_ControlAdded;
			}

			// 1. Form
			if (root is Form form)
			{
				form.BackColor = Bg;
				form.ForeColor = Text;
				try
				{
					if (form.IsHandleCreated)
					{
						int darkVal = 1;
						DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkVal, sizeof(int));
					}
					else
					{
						form.HandleCreated += (s, e) =>
						{
							int darkVal = 1;
							DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkVal, sizeof(int));
						};
					}
				}
				catch
				{
				}
			}
			// 2. Button
			else if (root is Button btn)
			{
				btn.FlatStyle = FlatStyle.Flat;
				btn.UseVisualStyleBackColor = false;
				btn.BackColor = ButtonSurface;
				btn.ForeColor = Text;
				btn.FlatAppearance.BorderColor = Border;
				btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 53, 76);
				btn.FlatAppearance.MouseDownBackColor = AccentHover;
			}
			// 3. CheckBox
			else if (root is CheckBox cb)
			{
				cb.ForeColor = Text;
				cb.BackColor = Color.Transparent;
				cb.UseVisualStyleBackColor = false;
			}
			// 4. RadioButton
			else if (root is RadioButton rb)
			{
				rb.ForeColor = Text;
				rb.BackColor = Color.Transparent;
				rb.UseVisualStyleBackColor = false;
			}
			// 5. NumericUpDown
			else if (root is NumericUpDown num)
			{
				num.BackColor = Input;
				num.ForeColor = Text;
				num.BorderStyle = BorderStyle.FixedSingle;
				ApplyThemeToHandle(num, "DarkMode_Explorer");
			}
			// 6. TextBoxBase (TextBox + RichTextBox)
			else if (root is TextBoxBase tb)
			{
				tb.BackColor = Input;
				tb.ForeColor = Text;
				tb.BorderStyle = BorderStyle.FixedSingle;
			}
			// 7. ComboBox
			else if (root is ComboBox cbo)
			{
				cbo.BackColor = Surface;
				cbo.ForeColor = Text;
				cbo.FlatStyle = FlatStyle.Flat;
				cbo.DrawMode = DrawMode.OwnerDrawFixed;
				cbo.DrawItem -= Cbo_DrawItem;
				cbo.DrawItem += Cbo_DrawItem;
				if (!StyledCombos.Contains(cbo))
				{
					StyledCombos.Add(cbo);
					new CyberComboBoxStyler(cbo);
				}
			}
			// 8. ListView
			else if (root is ListView lv)
			{
				lv.BackColor = Surface;
				lv.ForeColor = Text;
				ApplyThemeToHandle(lv, "DarkMode_Explorer");
				ApplyListViewHeaderTheme(lv);
				foreach (ListViewItem item in lv.Items)
				{
					item.BackColor = Surface;
					item.ForeColor = Text;
					foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
					{
						sub.BackColor = Surface;
						sub.ForeColor = Text;
					}
				}
			}
			// 9. TreeView
			else if (root is TreeView tv)
			{
				tv.BackColor = Surface;
				tv.ForeColor = Text;
				tv.LineColor = Border;
				ApplyThemeToHandle(tv, "DarkMode_Explorer");
			}
			// 10. ListBox
			else if (root is ListBox lb)
			{
				lb.BackColor = Surface;
				lb.ForeColor = Text;
				lb.BorderStyle = BorderStyle.FixedSingle;
			}
			// 11. DataGridView
			else if (root is DataGridView dgv)
			{
				dgv.EnableHeadersVisualStyles = false;
				dgv.BackgroundColor = Surface;
				dgv.GridColor = Border;
				dgv.DefaultCellStyle.BackColor = Surface;
				dgv.DefaultCellStyle.ForeColor = Text;
				dgv.DefaultCellStyle.SelectionBackColor = AccentHover;
				dgv.DefaultCellStyle.SelectionForeColor = Color.White;
				dgv.ColumnHeadersDefaultCellStyle.BackColor = Input;
				dgv.ColumnHeadersDefaultCellStyle.ForeColor = Text;
				dgv.RowHeadersDefaultCellStyle.BackColor = Input;
				dgv.RowHeadersDefaultCellStyle.ForeColor = Text;
			}
			// 12. PropertyGrid
			else if (root is PropertyGrid pg)
			{
				pg.ViewBackColor = Surface;
				pg.ViewForeColor = Text;
				pg.LineColor = Border;
				pg.CategoryForeColor = Accent;
				pg.HelpBackColor = Surface;
				pg.HelpForeColor = Text;
				pg.CommandsBackColor = Surface;
				pg.CommandsForeColor = Text;
			}
			// 13. SplitContainer
			else if (root is SplitContainer sc)
			{
				sc.BackColor = Border;
				sc.Panel1.BackColor = Bg;
				sc.Panel2.BackColor = Bg;
			}
			// 14. GroupBox
			else if (root is GroupBox gb)
			{
				gb.BackColor = Color.Transparent;
				gb.ForeColor = Accent;
				if (!StyledGroupBoxes.Contains(gb))
				{
					StyledGroupBoxes.Add(gb);
					gb.Paint += GroupBox_Paint;
				}
			}
			// 15. LinkLabel
			else if (root is LinkLabel ll)
			{
				ll.LinkColor = Accent;
				ll.ActiveLinkColor = AccentHover;
				ll.VisitedLinkColor = Accent;
			}
			// 16. Label
			else if (root is Label lbl)
			{
				if (lbl.ForeColor == Color.Black || lbl.ForeColor == SystemColors.ControlText || lbl.ForeColor == SystemColors.WindowText)
				{
					lbl.ForeColor = Text;
				}
				else if (lbl.ForeColor == SystemColors.GrayText)
				{
					lbl.ForeColor = TextMuted;
				}
				if (lbl.BackColor == Color.White || lbl.BackColor == SystemColors.Control || lbl.BackColor == SystemColors.Window)
				{
					lbl.BackColor = Color.Transparent;
				}
			}
			// 17. TabControl
			else if (root is TabControl tc)
			{
				tc.BackColor = Bg;
				tc.ForeColor = Text;
				foreach (TabPage tpItem in tc.TabPages)
				{
					tpItem.BackColor = Bg;
					tpItem.ForeColor = Text;
				}
			}
			// 18. ToolStrip / StatusStrip / MenuStrip
			else if (root is ToolStrip ts)
			{
				ts.BackColor = Input;
				ts.ForeColor = Text;
				try
				{
					ts.Renderer = new ModernDarkToolStripRenderer();
				}
				catch {}
			}
			// 19. TrackBar / Control0
			else if (root.GetType().Name == "Control0" || root is TrackBar)
			{
				root.BackColor = Bg;
				root.ForeColor = Accent;
			}
			// 20. ProgressBar
			else if (root is ProgressBar pb)
			{
				ApplyThemeToHandle(pb, "DarkMode_Explorer");
			}
			// 21. UserControl / ContainerControl / TabPage / Panel
			else if (root is UserControl uc)
			{
				uc.BackColor = Bg;
				uc.ForeColor = Text;
			}
			else if (root is TabPage tp)
			{
				tp.BackColor = Bg;
				tp.ForeColor = Text;
			}
			else if (root is Panel p)
			{
				p.BackColor = Bg;
				p.ForeColor = Text;
			}
		}
		catch
		{
		}

		// Recurse into all child controls
		if (root.HasChildren)
		{
			for (int i = 0; i < root.Controls.Count; i++)
			{
				Apply(root.Controls[i]);
			}
		}
	}

	private static void Container_ControlAdded(object sender, ControlEventArgs e)
	{
		if (e.Control != null)
		{
			Apply(e.Control);
		}
	}

	private static void ApplyThemeToHandle(Control ctrl, string theme)
	{
		try
		{
			if (ctrl.IsHandleCreated)
			{
				SetWindowTheme(ctrl.Handle, theme, null);
			}
			else
			{
				ctrl.HandleCreated += (s, e) =>
				{
					try { SetWindowTheme(ctrl.Handle, theme, null); } catch {}
				};
			}
		}
		catch
		{
		}
	}

	private static void ApplyListViewHeaderTheme(ListView lv)
	{
		try
		{
			Action applyHeader = () =>
			{
				try
				{
					IntPtr hHeader = SendMessage(lv.Handle, LVM_GETHEADER, IntPtr.Zero, IntPtr.Zero);
					if (hHeader != IntPtr.Zero)
					{
						SetWindowTheme(hHeader, "DarkMode_ItemsView", null);
					}
				}
				catch {}
			};

			if (lv.IsHandleCreated)
			{
				applyHeader();
			}
			else
			{
				lv.HandleCreated += (s, e) => applyHeader();
			}
		}
		catch
		{
		}
	}

	private static void Cbo_DrawItem(object sender, DrawItemEventArgs e)
	{
		ComboBox cbo = sender as ComboBox;
		if (cbo == null || e.Index < 0 || e.Index >= cbo.Items.Count)
		{
			return;
		}

		bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
		Color bg = isSelected ? AccentHover : Surface;
		Color fg = isSelected ? Color.White : Text;

		using (SolidBrush bBg = new SolidBrush(bg))
		using (SolidBrush bFg = new SolidBrush(fg))
		{
			e.Graphics.FillRectangle(bBg, e.Bounds);
			string text = cbo.GetItemText(cbo.Items[e.Index]);
			using (StringFormat sf = new StringFormat { LineAlignment = StringAlignment.Center })
			{
				Rectangle textRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y, e.Bounds.Width - 4, e.Bounds.Height);
				e.Graphics.DrawString(text, e.Font ?? cbo.Font, bFg, textRect, sf);
			}
		}
	}

	private static void GroupBox_Paint(object sender, PaintEventArgs e)
	{
		GroupBox gb = sender as GroupBox;
		if (gb == null)
		{
			return;
		}

		try
		{
			Color parentBg = (gb.Parent != null && gb.Parent.BackColor != Color.Transparent) ? gb.Parent.BackColor : Bg;
			e.Graphics.Clear(parentBg);

			using (Pen pBorder = new Pen(Border))
			using (SolidBrush bBg = new SolidBrush(parentBg))
			using (SolidBrush bText = new SolidBrush(Accent))
			{
				if (string.IsNullOrEmpty(gb.Text))
				{
					e.Graphics.DrawRectangle(pBorder, 0, 0, Math.Max(0, gb.Width - 1), Math.Max(0, gb.Height - 1));
				}
				else
				{
					SizeF size = e.Graphics.MeasureString(gb.Text, gb.Font);
					int top = (int)(size.Height / 2);
					Rectangle rect = new Rectangle(0, top, Math.Max(0, gb.Width - 1), Math.Max(0, gb.Height - top - 1));
					e.Graphics.DrawRectangle(pBorder, rect);

					// Text background cutout
					e.Graphics.FillRectangle(bBg, 8, 0, (int)size.Width + 4, (int)size.Height);
					e.Graphics.DrawString(gb.Text, gb.Font, bText, 10, 0);
				}
			}
		}
		catch
		{
		}
	}

	public static void VerifyContrast(Control root, StringBuilder log)
	{
		if (root == null || log == null) return;
		try
		{
			Color effectiveBg = GetEffectiveBackColor(root);
			Color fg = root.ForeColor;
			if (effectiveBg.A > 0 && fg.A > 0)
			{
				double ratio = CalculateContrastRatio(fg, effectiveBg);
				if (ratio < 3.0 && !(root is GroupBox) && !(root is Panel) && !(root is UserControl) && !string.IsNullOrEmpty(root.Text))
				{
					log.AppendLine($"Low contrast ({ratio:0.0}:1): [{root.GetType().Name}] '{root.Text}' on '{root.Parent?.GetType().Name}' (FG: {fg}, BG: {effectiveBg})");
				}
			}
		}
		catch {}

		if (root.HasChildren)
		{
			foreach (Control child in root.Controls)
			{
				VerifyContrast(child, log);
			}
		}
	}

	private static Color GetEffectiveBackColor(Control c)
	{
		Control cur = c;
		while (cur != null)
		{
			if (cur.BackColor != Color.Transparent && cur.BackColor.A > 0)
			{
				return cur.BackColor;
			}
			cur = cur.Parent;
		}
		return Bg;
	}

	private static double CalculateContrastRatio(Color c1, Color c2)
	{
		double l1 = GetLuminance(c1);
		double l2 = GetLuminance(c2);
		return (Math.Max(l1, l2) + 0.05) / (Math.Min(l1, l2) + 0.05);
	}

	private static double GetLuminance(Color c)
	{
		double r = c.R / 255.0;
		double g = c.G / 255.0;
		double b = c.B / 255.0;
		r = (r <= 0.03928) ? r / 12.92 : Math.Pow((r + 0.055) / 1.055, 2.4);
		g = (g <= 0.03928) ? g / 12.92 : Math.Pow((g + 0.055) / 1.055, 2.4);
		b = (b <= 0.03928) ? b / 12.92 : Math.Pow((b + 0.055) / 1.055, 2.4);
		return 0.2126 * r + 0.7152 * g + 0.0722 * b;
	}
}
