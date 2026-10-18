using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace _i
{
	// Token: 0x0200024B RID: 587
	internal class ListViewEx : ListView
	{
		// Token: 0x06001F87 RID: 8071 RVA: 0x000E8DA4 File Offset: 0x000E6FA4
		public ListViewEx()
		{
			this.AllowReorder = true;
			this.LineColor = Color.Red;
			this.AllowDrop = true;
			base.View = View.Details;
			base.AllowColumnReorder = true;
			base.FullRowSelect = true;
			base.GridLines = true;
			base.HideSelection = false;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			ListViewEx.SendMessage(base.Handle, 295, this.MakeLong(1, 1), 0);
			if (this.m_changeDelayTimer == null)
			{
				this.m_changeDelayTimer = new Timer();
				this.m_changeDelayTimer.Tick += this.ChangeDelayTimerTick;
				this.m_changeDelayTimer.Interval = 75;
			}
			base.KeyDown += this.m_42978C9C;
			base.SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00015318 File Offset: 0x00013518
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00015320 File Offset: 0x00013520
		public List<ListViewItem> AllItems { get; set; } = new List<ListViewItem>();

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00015329 File Offset: 0x00013529
		public IEnumerable<ListViewItem> VisibleItems
		{
			get
			{
				ListViewEx.T_4CF55308 t_4CF = new ListViewEx.T_4CF55308(-2);
				t_4CF.f_DC873842 = this;
				return t_4CF;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x000E8E7C File Offset: 0x000E707C
		public ListViewItem LastVisibleItem
		{
			get
			{
				ListViewItem listViewItem = base.TopItem;
				int num = base.TopItem.Index + 1;
				while (num < base.Items.Count && base.ClientRectangle.Contains(base.Items[num].Bounds))
				{
					listViewItem = base.Items[num];
					num++;
				}
				return listViewItem;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00015339 File Offset: 0x00013539
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00015341 File Offset: 0x00013541
		public bool AllowReorder { get; set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x0001534A File Offset: 0x0001354A
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x00015352 File Offset: 0x00013552
		public bool AllowSort
		{
			get
			{
				return this.allowSort;
			}
			set
			{
				this.allowSort = value;
				if (this.allowSort)
				{
					base.ColumnClick += this.ListViewEx_ColumnClick;
					return;
				}
				base.ColumnClick -= this.ListViewEx_ColumnClick;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00015388 File Offset: 0x00013588
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x00015390 File Offset: 0x00013590
		public Color LineColor { get; set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00015399 File Offset: 0x00013599
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x000153A1 File Offset: 0x000135A1
		public bool DoubleClickActivation { get; set; }

		// Token: 0x06001F94 RID: 8084
		[DllImport("user32.dll")]
		public static extern int GetKeyState(int nVirtKey);

		// Token: 0x06001F95 RID: 8085 RVA: 0x000153AA File Offset: 0x000135AA
		public static bool IsPressed(int key)
		{
			return Convert.ToBoolean(ListViewEx.GetKeyState(key) & 32768);
		}

		// Token: 0x06001F96 RID: 8086
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06001F97 RID: 8087 RVA: 0x000153BD File Offset: 0x000135BD
		protected override void OnNotifyMessage(Message m)
		{
			if (m.Msg != 20)
			{
				base.OnNotifyMessage(m);
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000153D1 File Offset: 0x000135D1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.m_changeDelayTimer != null)
			{
				this.m_changeDelayTimer.Tick -= this.ChangeDelayTimerTick;
				this.m_changeDelayTimer.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00015407 File Offset: 0x00013607
		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			this.m_changeDelayTimer.Enabled = false;
			this.m_changeDelayTimer.Enabled = true;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00015421 File Offset: 0x00013621
		private void ChangeDelayTimerTick(object sender, EventArgs e)
		{
			this.m_changeDelayTimer.Enabled = false;
			base.OnSelectedIndexChanged(new EventArgs());
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0001543A File Offset: 0x0001363A
		public void PerformDoubleClick(EventArgs e = null)
		{
			base.OnDoubleClick(e);
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06001F9C RID: 8092 RVA: 0x000E8EE4 File Offset: 0x000E70E4
		// (remove) Token: 0x06001F9D RID: 8093 RVA: 0x000E8F1C File Offset: 0x000E711C
		public event ListViewEx.SubItemEndEditingEventHandler SubItemEndEditing;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06001F9E RID: 8094 RVA: 0x000E8F54 File Offset: 0x000E7154
		// (remove) Token: 0x06001F9F RID: 8095 RVA: 0x000E8F8C File Offset: 0x000E718C
		public event ListViewEx.SubItemEventHandler SubItemBeginEditing;

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00015443 File Offset: 0x00013643
		private void OnSubItemBeginEditing(ListViewEx.SubItemEventArgs e)
		{
			if (this.SubItemBeginEditing != null)
			{
				this.SubItemBeginEditing(this, e);
			}
		}

		// Token: 0x06001FA1 RID: 8097
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wPar, IntPtr lPar);

		// Token: 0x06001FA2 RID: 8098
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int len, ref int[] order);

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000E8FC4 File Offset: 0x000E71C4
		public int[] GetColumnOrder()
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)) * base.Columns.Count);
			if (ListViewEx.SendMessage(base.Handle, 4155, new IntPtr(base.Columns.Count), intPtr).ToInt32() == 0)
			{
				Marshal.FreeHGlobal(intPtr);
				return null;
			}
			int[] array = new int[base.Columns.Count];
			Marshal.Copy(intPtr, array, 0, base.Columns.Count);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000E9050 File Offset: 0x000E7250
		public Rectangle GetSubItemBounds(ListViewItem Item, int SubItem)
		{
			int[] columnOrder = this.GetColumnOrder();
			if (SubItem >= columnOrder.Length)
			{
				throw new IndexOutOfRangeException("SubItem " + SubItem.ToString() + " out of range");
			}
			if (Item == null)
			{
				throw new ArgumentNullException("Item");
			}
			Rectangle bounds = Item.GetBounds(ItemBoundsPortion.Entire);
			int num = bounds.Left;
			int i;
			for (i = 0; i < columnOrder.Length; i++)
			{
				ColumnHeader columnHeader = base.Columns[columnOrder[i]];
				if (columnHeader.Index == SubItem)
				{
					break;
				}
				num += columnHeader.Width;
			}
			return new Rectangle(num, bounds.Top, base.Columns[columnOrder[i]].Width, bounds.Height);
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06001FA5 RID: 8101 RVA: 0x000E9100 File Offset: 0x000E7300
		// (remove) Token: 0x06001FA6 RID: 8102 RVA: 0x000E9138 File Offset: 0x000E7338
		public event ListViewEx.SubItemEventHandler SubItemClicked;

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0001545A File Offset: 0x0001365A
		public void OnSubItemClicked(ListViewEx.SubItemEventArgs e)
		{
			if (this.SubItemClicked != null)
			{
				this.SubItemClicked(this, e);
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000E9170 File Offset: 0x000E7370
		private void EditSubitemAt(Point p)
		{
			ListViewItem listViewItem;
			int subItemAt = this.GetSubItemAt(p.X, p.Y, out listViewItem);
			if (subItemAt >= 0)
			{
				this.OnSubItemClicked(new ListViewEx.SubItemEventArgs(listViewItem, subItemAt));
			}
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000E91A8 File Offset: 0x000E73A8
		public int GetSubItemAt(int x, int y, out ListViewItem item)
		{
			item = base.GetItemAt(x, y);
			if (item != null)
			{
				int[] columnOrder = this.GetColumnOrder();
				int num = item.GetBounds(ItemBoundsPortion.Entire).Left;
				for (int i = 0; i < columnOrder.Length; i++)
				{
					ColumnHeader columnHeader = base.Columns[columnOrder[i]];
					if (x < num + columnHeader.Width)
					{
						return columnHeader.Index;
					}
					num += columnHeader.Width;
				}
			}
			return -1;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000E921C File Offset: 0x000E741C
		public void StartEditing(Control c, ListViewItem Item, int SubItem)
		{
			this.OnSubItemBeginEditing(new ListViewEx.SubItemEventArgs(Item, SubItem));
			Rectangle subItemBounds = this.GetSubItemBounds(Item, SubItem);
			if (subItemBounds.X < 0)
			{
				subItemBounds.Width += subItemBounds.X;
				subItemBounds.X = 0;
			}
			if (subItemBounds.X + subItemBounds.Width > base.Width)
			{
				subItemBounds.Width = base.Width - subItemBounds.Left;
			}
			subItemBounds.Offset(base.Left, base.Top);
			Point point = new Point(0, 0);
			Point point2 = base.Parent.PointToScreen(point);
			Point point3 = c.Parent.PointToScreen(point);
			subItemBounds.Offset(point2.X - point3.X, point2.Y - point3.Y);
			c.Bounds = subItemBounds;
			c.Text = Item.SubItems[SubItem].Text;
			c.Visible = true;
			c.BringToFront();
			c.Focus();
			this._editingControl = c;
			this._editingControl.Leave += this._editControl_Leave;
			this._editingControl.KeyPress += this._editControl_KeyPress;
			this._editItem = Item;
			this._editSubItem = SubItem;
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00015471 File Offset: 0x00013671
		private void _editControl_Leave(object sender, EventArgs e)
		{
			this.EndEditing(true);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000E9364 File Offset: 0x000E7564
		private void _editControl_KeyPress(object sender, KeyPressEventArgs e)
		{
			char keyChar = e.KeyChar;
			if (keyChar != '\r')
			{
				if (keyChar == '\u001b')
				{
					this.EndEditing(false);
					return;
				}
			}
			else
			{
				this.EndEditing(true);
			}
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000E9394 File Offset: 0x000E7594
		public void EndEditing(bool AcceptChanges)
		{
			if (this._editingControl == null)
			{
				return;
			}
			ListViewEx.SubItemEndEditingEventArgs e = new ListViewEx.SubItemEndEditingEventArgs(this._editItem, this._editSubItem, AcceptChanges ? this._editingControl.Text : this._editItem.SubItems[this._editSubItem].Text, !AcceptChanges);
			this._editItem.SubItems[this._editSubItem].Text = e.DisplayText;
			this._editingControl.Leave -= this._editControl_Leave;
			this._editingControl.KeyPress -= this._editControl_KeyPress;
			this._editingControl.Visible = false;
			this._editingControl = null;
			this._editItem = null;
			this._editSubItem = -1;
			this.OnSubItemEndEditing(e);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0001547A File Offset: 0x0001367A
		private void OnSubItemEndEditing(ListViewEx.SubItemEndEditingEventArgs e)
		{
			if (this.SubItemEndEditing != null)
			{
				this.SubItemEndEditing(this, e);
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000E9464 File Offset: 0x000E7664
		public void Search(string input)
		{
			ListViewEx.T_7B6613BF t_7B6613BF = new ListViewEx.T_7B6613BF();
			if (this.AllItems == null)
			{
				this.AllItems = new List<ListViewItem>();
			}
			this.AllItems = this.AllItems.Concat<ListViewItem>(base.Items.Cast<ListViewItem>()).Distinct<ListViewItem>().ToList<ListViewItem>();
			t_7B6613BF.niceSearch = ListViewEx.minString(input);
			IEnumerable<ListViewItem> enumerable = this.AllItems.Where<ListViewItem>(new Func<ListViewItem, bool>(t_7B6613BF.m_D7D274E9));
			base.Items.Clear();
			base.Items.AddRange(enumerable.ToArray<ListViewItem>());
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00015491 File Offset: 0x00013691
		public static string NiceString(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return string.Empty;
			}
			return ListViewEx.RemoveSign(ListViewEx.RemoveWhitespace(input));
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000154AC File Offset: 0x000136AC
		public static string minString(string input)
		{
			return ListViewEx.NiceString(input).ToLower();
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000E94F0 File Offset: 0x000E76F0
		public static string RemoveSign(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return string.Empty;
			}
			for (int i = 1; i < ListViewEx.VietnameseSigns.Length; i++)
			{
				for (int j = 0; j < ListViewEx.VietnameseSigns[i].Length; j++)
				{
					input = input.Replace(ListViewEx.VietnameseSigns[i][j], ListViewEx.VietnameseSigns[0][i - 1]);
				}
			}
			return input;
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000E955C File Offset: 0x000E775C
		public static string RemoveWhitespace(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return string.Empty;
			}
			return new string(input.ToCharArray().Where<char>(new Func<char, bool>(ListViewEx.T_05FB01B2.f_20435697.m_02F67DB9)).ToArray<char>());
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06001FB4 RID: 8116 RVA: 0x000E95AC File Offset: 0x000E77AC
		// (remove) Token: 0x06001FB5 RID: 8117 RVA: 0x000E95E4 File Offset: 0x000E77E4
		public event ScrollEventHandler Scroll;

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000E961C File Offset: 0x000E781C
		protected virtual void OnScroll(ScrollEventArgs e)
		{
			ScrollEventHandler scroll = this.Scroll;
			if (scroll != null)
			{
				scroll(this, e);
			}
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000E963C File Offset: 0x000E783C
		protected override void WndProc(ref Message msg)
		{
			base.WndProc(ref msg);
			int msg2 = msg.Msg;
			if (msg2 <= 78)
			{
				if (msg2 != 5)
				{
					if (msg2 != 78)
					{
						return;
					}
					if (((ListViewEx.NMHDR)Marshal.PtrToStructure(msg.LParam, typeof(ListViewEx.NMHDR))).code == -310 && this._editingControl != null)
					{
						this.EndEditing(true);
					}
				}
				else if (this._editingControl != null)
				{
					this.EndEditing(true);
					return;
				}
			}
			else
			{
				if (msg2 == 276)
				{
					this.OnScroll(new ScrollEventArgs((ScrollEventType)(msg.WParam.ToInt32() & 65535), 0));
					return;
				}
				if (msg2 == 277)
				{
					this.OnScroll(new ScrollEventArgs((ScrollEventType)(msg.WParam.ToInt32() & 65535), 0));
					return;
				}
				if (msg2 == 522)
				{
					this.OnScroll(new ScrollEventArgs((ScrollEventType)(msg.WParam.ToInt32() & 65535), 0));
					return;
				}
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000154B9 File Offset: 0x000136B9
		public void ScrollToEnd()
		{
			base.EnsureVisible(base.Items.Count - 1);
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000154CE File Offset: 0x000136CE
		private void ChangeOrder()
		{
			if (this.sortOrder == 0)
			{
				this.sortOrder = 1;
				return;
			}
			if (this.sortOrder == 1)
			{
				this.sortOrder = 2;
				return;
			}
			this.sortOrder = 0;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000E9728 File Offset: 0x000E7928
		private void ListViewEx_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == this.lastColumnIndex)
			{
				this.ChangeOrder();
			}
			else
			{
				this.sortOrder = 1;
				this.lastColumnIndex = e.Column;
			}
			Class391.smethod_0(this, e.Column, (SortOrder)this.sortOrder);
			if (this.sortOrder == 0)
			{
				base.ListViewItemSorter = null;
				return;
			}
			base.ListViewItemSorter = new ListViewEx.ListViewItemComparer(e.Column)
			{
				SortOrder = this.sortOrder
			};
			base.Sort();
			base.ListViewItemSorter = null;
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000E97AC File Offset: 0x000E79AC
		protected override void OnItemCheck(ItemCheckEventArgs ice)
		{
			if (this.checkFromDoubleClick)
			{
				ice.NewValue = ice.CurrentValue;
				this.checkFromDoubleClick = false;
				return;
			}
			if (!ListViewEx.IsPressed(ListViewEx.VK_LSHIFT) && !ListViewEx.IsPressed(ListViewEx.VK_LCONTROL) && !ListViewEx.IsPressed(ListViewEx.VK_RSHIFT) && !ListViewEx.IsPressed(ListViewEx.VK_RCONTROL))
			{
				base.OnItemCheck(ice);
				return;
			}
			ice.NewValue = ice.CurrentValue;
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000E981C File Offset: 0x000E7A1C
		protected override void OnMouseClick(MouseEventArgs e)
		{
			if (base.VirtualMode)
			{
				ListViewItem itemAt = this.GetItemAt(e.X, e.Y);
				if (itemAt != null && e.X < itemAt.Bounds.Left + 16)
				{
					itemAt.Checked = !itemAt.Checked;
					base.OnItemChecked(new ItemCheckedEventArgs(itemAt));
					this.Invalidate(itemAt.Bounds);
				}
			}
			base.OnMouseClick(e);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000154F8 File Offset: 0x000136F8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks > 1)
			{
				this.checkFromDoubleClick = true;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0001551E File Offset: 0x0001371E
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (this.DoubleClickActivation)
			{
				return;
			}
			this.EditSubitemAt(new Point(e.X, e.Y));
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000E9890 File Offset: 0x000E7A90
		protected override void OnDoubleClick(EventArgs e)
		{
			base.OnDoubleClick(e);
			if (!this.DoubleClickActivation)
			{
				return;
			}
			Point point = base.PointToClient(Cursor.Position);
			this.EditSubitemAt(point);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00015547 File Offset: 0x00013747
		protected override void OnKeyDown(KeyEventArgs e)
		{
			this.checkFromDoubleClick = false;
			base.OnKeyDown(e);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000E98C0 File Offset: 0x000E7AC0
		private int MakeLong(int wLow, int wHigh)
		{
			int num = (int)this.IntLoWord(wLow);
			short num2 = this.IntLoWord(wHigh);
			int num3 = 65536 * (int)num2;
			return num | num3;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00015557 File Offset: 0x00013757
		private short IntLoWord(int word)
		{
			return (short)(word & 32767);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000E98E8 File Offset: 0x000E7AE8
		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			if (!this.AllowReorder)
			{
				base.OnDragDrop(drgevent);
				return;
			}
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			ListViewItem itemAt = base.GetItemAt(point.X, point.Y);
			if (drgevent.Data.GetDataPresent(typeof(ListViewEx.DragItemData).ToString()) && ((ListViewEx.DragItemData)drgevent.Data.GetData(typeof(ListViewEx.DragItemData).ToString())).ListView != null && ((ListViewEx.DragItemData)drgevent.Data.GetData(typeof(ListViewEx.DragItemData).ToString())).DragItems.Count != 0)
			{
				ListViewEx.DragItemData dragItemData = (ListViewEx.DragItemData)drgevent.Data.GetData(typeof(ListViewEx.DragItemData).ToString());
				int num = -1;
				if (itemAt != null)
				{
					num = itemAt.Index;
				}
				if (this == dragItemData.ListView)
				{
					if (num == -1)
					{
						num = base.Items.Count;
					}
					if (num > base.SelectedItems[0].Index)
					{
						num -= dragItemData.ListView.SelectedItems.Count;
					}
				}
				List<ListViewItem> list = new List<ListViewItem>();
				if (dragItemData.ListView != null)
				{
					foreach (object obj in dragItemData.ListView.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						dragItemData.ListView.Items.Remove(listViewItem);
						list.Add(listViewItem);
					}
				}
				for (int i = list.Count; i > 0; i--)
				{
					base.Items.Insert(num, list[i - 1]);
				}
				if (this.previousItem != null)
				{
					this.previousItem = null;
				}
				base.Invalidate();
				base.OnDragDrop(drgevent);
				return;
			}
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000E9ADC File Offset: 0x000E7CDC
		protected override void OnDragOver(DragEventArgs drgevent)
		{
			if (!this.AllowReorder)
			{
				base.OnDragOver(drgevent);
				return;
			}
			if (!drgevent.Data.GetDataPresent(typeof(ListViewEx.DragItemData).ToString()))
			{
				drgevent.Effect = DragDropEffects.None;
				return;
			}
			if (base.Items.Count > 0)
			{
				Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
				ListViewItem listViewItem = base.GetItemAt(point.X, point.Y);
				Graphics graphics = base.CreateGraphics();
				if (listViewItem == null)
				{
					drgevent.Effect = DragDropEffects.Move;
					if (this.previousItem != null)
					{
						this.previousItem = null;
						base.Invalidate();
					}
					listViewItem = base.Items[base.Items.Count - 1];
					if (base.View != View.Details)
					{
						if (base.View != View.List)
						{
							graphics.DrawLine(new Pen(this.LineColor, 2f), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
							graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
							{
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y),
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y),
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + 5)
							});
							graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
							{
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
								new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5)
							});
							goto IL_0517;
						}
					}
					graphics.DrawLine(new Pen(this.LineColor, 2f), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height), new Point(listViewItem.Bounds.X + base.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
					graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
					{
						new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
						new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
						new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
					});
					graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
					{
						new Point(base.Bounds.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
						new Point(base.Bounds.Width - 9, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
						new Point(base.Bounds.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
					});
					IL_0517:
					base.OnDragOver(drgevent);
					return;
				}
				if ((this.previousItem != null && this.previousItem != listViewItem) || this.previousItem == null)
				{
					base.Invalidate();
				}
				this.previousItem = listViewItem;
				if (base.View != View.Details)
				{
					if (base.View != View.List)
					{
						graphics.DrawLine(new Pen(this.LineColor, 2f), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
						graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
						{
							new Point(listViewItem.Bounds.X - 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + 5)
						});
						graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
						{
							new Point(listViewItem.Bounds.X - 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5)
						});
						goto IL_08B8;
					}
				}
				graphics.DrawLine(new Pen(this.LineColor, 2f), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y), new Point(listViewItem.Bounds.X + base.Bounds.Width, listViewItem.Bounds.Y));
				graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
				{
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y - 5),
					new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y),
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + 5)
				});
				graphics.FillPolygon(new SolidBrush(this.LineColor), new Point[]
				{
					new Point(base.Bounds.Width - 4, listViewItem.Bounds.Y - 5),
					new Point(base.Bounds.Width - 9, listViewItem.Bounds.Y),
					new Point(base.Bounds.Width - 4, listViewItem.Bounds.Y + 5)
				});
				IL_08B8:
				IEnumerator enumerator = base.SelectedItems.GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						if (((ListViewItem)enumerator.Current).Index == listViewItem.Index)
						{
							drgevent.Effect = DragDropEffects.None;
							listViewItem.EnsureVisible();
							return;
						}
					}
				}
				listViewItem.EnsureVisible();
			}
			drgevent.Effect = DragDropEffects.Move;
			base.OnDragOver(drgevent);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000EA420 File Offset: 0x000E8620
		protected override void OnDragEnter(DragEventArgs drgevent)
		{
			if (!this.AllowReorder)
			{
				base.OnDragEnter(drgevent);
				return;
			}
			if (!drgevent.Data.GetDataPresent(typeof(ListViewEx.DragItemData).ToString()))
			{
				drgevent.Effect = DragDropEffects.None;
				return;
			}
			drgevent.Effect = DragDropEffects.Move;
			base.OnDragEnter(drgevent);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00015561 File Offset: 0x00013761
		protected override void OnItemDrag(ItemDragEventArgs e)
		{
			if (!this.AllowReorder)
			{
				base.OnItemDrag(e);
				return;
			}
			base.DoDragDrop(this.GetDataForDragDrop(), DragDropEffects.Move);
			base.OnItemDrag(e);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00015588 File Offset: 0x00013788
		protected override void OnLostFocus(EventArgs e)
		{
			this.ResetOutOfRange();
			base.Invalidate();
			base.OnLostFocus(e);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0001559D File Offset: 0x0001379D
		protected override void OnDragLeave(EventArgs e)
		{
			this.ResetOutOfRange();
			base.Invalidate();
			base.OnDragLeave(e);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000EA470 File Offset: 0x000E8670
		private ListViewEx.DragItemData GetDataForDragDrop()
		{
			ListViewEx.DragItemData dragItemData = new ListViewEx.DragItemData(this);
			foreach (object obj in base.SelectedItems)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				ListViewItem listViewItem2 = (ListViewItem)listViewItem.Clone();
				listViewItem2.Name = listViewItem.Name;
				dragItemData.DragItems.Add(listViewItem2);
			}
			return dragItemData;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000155B2 File Offset: 0x000137B2
		private void ResetOutOfRange()
		{
			if (this.previousItem != null)
			{
				this.previousItem = null;
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x000155C3 File Offset: 0x000137C3
		[CompilerGenerated]
		private void m_42978C9C(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A && e.Control)
			{
				this.smethod_21();
			}
		}

		// Token: 0x040013DC RID: 5084
		private const int LVM_FIRST = 4096;

		// Token: 0x040013DD RID: 5085
		private const int LVM_GETCOLUMNORDERARRAY = 4155;

		// Token: 0x040013DE RID: 5086
		private const int WM_HSCROLL = 276;

		// Token: 0x040013DF RID: 5087
		private const int WM_VSCROLL = 277;

		// Token: 0x040013E0 RID: 5088
		private const int WM_SIZE = 5;

		// Token: 0x040013E1 RID: 5089
		private const int WM_NOTIFY = 78;

		// Token: 0x040013E2 RID: 5090
		private const int HDN_FIRST = -300;

		// Token: 0x040013E3 RID: 5091
		private const int HDN_BEGINDRAG = -310;

		// Token: 0x040013E4 RID: 5092
		private const int HDN_ITEMCHANGINGA = -300;

		// Token: 0x040013E5 RID: 5093
		private const int HDN_ITEMCHANGINGW = -320;

		// Token: 0x040013E6 RID: 5094
		private const int WM_MOUSEWHEEL = 522;

		// Token: 0x040013E7 RID: 5095
		private const int WM_CHANGEUISTATE = 295;

		// Token: 0x040013E8 RID: 5096
		private const int UIS_SET = 1;

		// Token: 0x040013E9 RID: 5097
		private const int UISF_HIDEFOCUS = 1;

		// Token: 0x040013EA RID: 5098
		public static int VK_LSHIFT = 160;

		// Token: 0x040013EB RID: 5099
		public static int VK_RSHIFT = 161;

		// Token: 0x040013EC RID: 5100
		public static int VK_LCONTROL = 162;

		// Token: 0x040013ED RID: 5101
		public static int VK_RCONTROL = 163;

		// Token: 0x040013EE RID: 5102
		private static readonly string[] VietnameseSigns = new string[]
		{
			"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
			"ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"
		};

		// Token: 0x040013EF RID: 5103
		private readonly Timer m_changeDelayTimer;

		// Token: 0x040013F0 RID: 5104
		private Control _editingControl;

		// Token: 0x040013F1 RID: 5105
		private ListViewItem _editItem;

		// Token: 0x040013F2 RID: 5106
		private int _editSubItem;

		// Token: 0x040013F3 RID: 5107
		private bool allowSort;

		// Token: 0x040013F4 RID: 5108
		private bool checkFromDoubleClick;

		// Token: 0x040013F5 RID: 5109
		private int lastColumnIndex;

		// Token: 0x040013F6 RID: 5110
		private ListViewItem previousItem;

		// Token: 0x040013F7 RID: 5111
		private int sortOrder;

		// Token: 0x040013F8 RID: 5112
		[CompilerGenerated]
		private List<ListViewItem> f_73F6B7D4;

		// Token: 0x040013F9 RID: 5113
		[CompilerGenerated]
		private bool f_28DC4C95;

		// Token: 0x040013FA RID: 5114
		[CompilerGenerated]
		private Color f_CA3C222A;

		// Token: 0x040013FB RID: 5115
		[CompilerGenerated]
		private bool f_6DAC9750;

		// Token: 0x0200024C RID: 588
		// (Invoke) Token: 0x06001FCE RID: 8142
		public delegate void SubItemEndEditingEventHandler(object sender, ListViewEx.SubItemEndEditingEventArgs e);

		// Token: 0x0200024D RID: 589
		// (Invoke) Token: 0x06001FD2 RID: 8146
		public delegate void SubItemEventHandler(object sender, ListViewEx.SubItemEventArgs e);

		// Token: 0x0200024E RID: 590
		public struct NMHDR
		{
			// Token: 0x04001400 RID: 5120
			public IntPtr hwndFrom;

			// Token: 0x04001401 RID: 5121
			public int idFrom;

			// Token: 0x04001402 RID: 5122
			public int code;
		}

		// Token: 0x0200024F RID: 591
		public class SubItemEventArgs : EventArgs
		{
			// Token: 0x06001FD5 RID: 8149 RVA: 0x000155DD File Offset: 0x000137DD
			public SubItemEventArgs(ListViewItem listViewItem_0, int int_0)
			{
				this.SubItem = int_0;
				this.Item = listViewItem_0;
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000155FA File Offset: 0x000137FA
			public int SubItem { get; } = -1;

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00015602 File Offset: 0x00013802
			public ListViewItem Item { get; }

			// Token: 0x04001403 RID: 5123
			[CompilerGenerated]
			private readonly int f_5FBF413F;

			// Token: 0x04001404 RID: 5124
			[CompilerGenerated]
			private readonly ListViewItem f_BE6027CD;
		}

		// Token: 0x02000250 RID: 592
		public class SubItemEndEditingEventArgs : ListViewEx.SubItemEventArgs
		{
			// Token: 0x06001FD8 RID: 8152 RVA: 0x0001560A File Offset: 0x0001380A
			public SubItemEndEditingEventArgs(ListViewItem listViewItem_0, int int_0, string string_0, bool bool_0)
				: base(listViewItem_0, int_0)
			{
				this.DisplayText = string_0;
				this.Cancel = bool_0;
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00015635 File Offset: 0x00013835
			// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0001563D File Offset: 0x0001383D
			public string DisplayText { get; set; } = string.Empty;

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00015646 File Offset: 0x00013846
			// (set) Token: 0x06001FDC RID: 8156 RVA: 0x0001564E File Offset: 0x0001384E
			public bool Cancel { get; set; } = true;

			// Token: 0x04001405 RID: 5125
			[CompilerGenerated]
			private string f_DBAC1ED7;

			// Token: 0x04001406 RID: 5126
			[CompilerGenerated]
			private bool f_50FA49E9;
		}

		// Token: 0x02000251 RID: 593
		private class DragItemData
		{
			// Token: 0x06001FDD RID: 8157 RVA: 0x00015657 File Offset: 0x00013857
			public DragItemData(ListViewEx listViewEx_0)
			{
				this.ListView = listViewEx_0;
				this.DragItems = new ArrayList();
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00015671 File Offset: 0x00013871
			public ListViewEx ListView { get; }

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00015679 File Offset: 0x00013879
			public ArrayList DragItems { get; }

			// Token: 0x04001407 RID: 5127
			[CompilerGenerated]
			private readonly ListViewEx f_0F2607B1;

			// Token: 0x04001408 RID: 5128
			[CompilerGenerated]
			private readonly ArrayList f_F7C052DF;
		}

		// Token: 0x02000252 RID: 594
		private class ListViewItemComparer : IComparer
		{
			// Token: 0x06001FE0 RID: 8160 RVA: 0x00015681 File Offset: 0x00013881
			public ListViewItemComparer()
			{
				this.col = 0;
			}

			// Token: 0x06001FE1 RID: 8161 RVA: 0x00015690 File Offset: 0x00013890
			public ListViewItemComparer(int int_0)
			{
				this.col = int_0;
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0001569F File Offset: 0x0001389F
			// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x000156A7 File Offset: 0x000138A7
			public int SortOrder { get; set; }

			// Token: 0x06001FE4 RID: 8164 RVA: 0x000EA5B4 File Offset: 0x000E87B4
			public int Compare(object x, object y)
			{
				string text = "";
				string text2 = "";
				if (this.col < ((ListViewItem)x).SubItems.Count)
				{
					text = ((ListViewItem)x).SubItems[this.col].Text;
				}
				if (this.col < ((ListViewItem)y).SubItems.Count)
				{
					text2 = ((ListViewItem)y).SubItems[this.col].Text;
				}
				int num;
				if (int.TryParse(text, out num) && int.TryParse(text2, out num))
				{
					if (text2.Length > text.Length)
					{
						text = new string('0', text2.Length - text.Length) + text;
					}
					else
					{
						text2 = new string('0', text.Length - text2.Length) + text2;
					}
				}
				else if (text2.Length > text.Length)
				{
					text += new string('0', text2.Length - text.Length);
				}
				else
				{
					text2 += new string('0', text.Length - text2.Length);
				}
				if (this.SortOrder == 1)
				{
					return string.Compare(text, text2);
				}
				if (this.SortOrder == 2)
				{
					return string.Compare(text2, text);
				}
				return 0;
			}

			// Token: 0x04001409 RID: 5129
			private readonly int col;

			// Token: 0x0400140A RID: 5130
			[CompilerGenerated]
			private int f_CA35C193;
		}

		// Token: 0x02000253 RID: 595
		[CompilerGenerated]
		[Serializable]
		private sealed class T_05FB01B2
		{
			// Token: 0x06001FE7 RID: 8167 RVA: 0x000156BC File Offset: 0x000138BC
			internal bool m_02F67DB9(char c)
			{
				return !char.IsWhiteSpace(c);
			}

			// Token: 0x0400140B RID: 5131
			public static readonly ListViewEx.T_05FB01B2 f_20435697 = new ListViewEx.T_05FB01B2();

			// Token: 0x0400140C RID: 5132
			public static Func<char, bool> f_79EF1691;
		}

		// Token: 0x02000254 RID: 596
		[CompilerGenerated]
		private sealed class T_7B6613BF
		{
			// Token: 0x06001FE9 RID: 8169 RVA: 0x000EA6FC File Offset: 0x000E88FC
			internal bool m_D7D274E9(ListViewItem i)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (object obj in i.SubItems)
				{
					stringBuilder.Append(ListViewEx.minString(obj.ToString()));
				}
				return stringBuilder.ToString().Contains(this.niceSearch);
			}

			// Token: 0x0400140D RID: 5133
			public string niceSearch;
		}

		// Token: 0x02000255 RID: 597
		[CompilerGenerated]
		private sealed class T_4CF55308 : IEnumerable, IDisposable, IEnumerator, IEnumerable<ListViewItem>, IEnumerator<ListViewItem>
		{
			// Token: 0x06001FEA RID: 8170 RVA: 0x000156C7 File Offset: 0x000138C7
			[DebuggerHidden]
			public T_4CF55308(int int_0)
			{
				this.f_13AE8B2A = int_0;
				this.f_AD02BED6 = Environment.CurrentManagedThreadId;
			}

			// Token: 0x06001FEB RID: 8171 RVA: 0x000156E1 File Offset: 0x000138E1
			[DebuggerHidden]
			public void Dispose()
			{
				this.f_13AE8B2A = -2;
			}

			// Token: 0x06001FEC RID: 8172 RVA: 0x000EA774 File Offset: 0x000E8974
			bool IEnumerator.MoveNext()
			{
				int num = this.f_13AE8B2A;
				ListViewEx listViewEx = this.f_DC873842;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.f_13AE8B2A = -1;
				}
				else
				{
					this.f_13AE8B2A = -1;
					if (listViewEx.TopItem == null)
					{
						return false;
					}
					int num2 = listViewEx.Items.IndexOf(listViewEx.TopItem);
					if (num2 == -1)
					{
						return false;
					}
					this.f_A88D4CE9 = listViewEx.ClientRectangle;
					this.f_1726A0E8 = num2;
					goto IL_00C6;
				}
				IL_00B4:
				int num3 = this.f_1726A0E8;
				this.f_1726A0E8 = num3 + 1;
				IL_00C6:
				if (this.f_1726A0E8 < listViewEx.Items.Count)
				{
					Rectangle bounds = listViewEx.Items[this.f_1726A0E8].Bounds;
					if (bounds.Top < this.f_A88D4CE9.Bottom && bounds.Bottom > this.f_A88D4CE9.Top)
					{
						this.f_BB1CF016 = listViewEx.Items[this.f_1726A0E8];
						this.f_13AE8B2A = 1;
						return true;
					}
					if (bounds.Top < this.f_A88D4CE9.Bottom)
					{
						goto IL_00B4;
					}
				}
				return false;
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06001FED RID: 8173 RVA: 0x000156EB File Offset: 0x000138EB
			public ListViewItem Current
			{
				[DebuggerHidden]
				get
				{
					return this.f_BB1CF016;
				}
			}

			// Token: 0x06001FEE RID: 8174 RVA: 0x00003657 File Offset: 0x00001857
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06001FEF RID: 8175 RVA: 0x000156EB File Offset: 0x000138EB
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.f_BB1CF016;
				}
			}

			// Token: 0x06001FF0 RID: 8176 RVA: 0x000EA880 File Offset: 0x000E8A80
			[DebuggerHidden]
			public IEnumerator<ListViewItem> GetEnumerator()
			{
				ListViewEx.T_4CF55308 t_4CF;
				if (this.f_13AE8B2A == -2 && this.f_AD02BED6 == Environment.CurrentManagedThreadId)
				{
					this.f_13AE8B2A = 0;
					t_4CF = this;
				}
				else
				{
					t_4CF = new ListViewEx.T_4CF55308(0);
					t_4CF.f_DC873842 = this.f_DC873842;
				}
				return t_4CF;
			}

			// Token: 0x06001FF1 RID: 8177 RVA: 0x000156F3 File Offset: 0x000138F3
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400140E RID: 5134
			private int f_13AE8B2A;

			// Token: 0x0400140F RID: 5135
			private ListViewItem f_BB1CF016;

			// Token: 0x04001410 RID: 5136
			private int f_AD02BED6;

			// Token: 0x04001411 RID: 5137
			public ListViewEx f_DC873842;

			// Token: 0x04001412 RID: 5138
			private Rectangle f_A88D4CE9;

			// Token: 0x04001413 RID: 5139
			private int f_1726A0E8;
		}
	}
}
