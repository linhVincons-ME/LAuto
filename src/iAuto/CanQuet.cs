using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _i;

// Token: 0x02000199 RID: 409
internal partial class CanQuet : UserControl
{
	// Token: 0x0600174E RID: 5966 RVA: 0x00010232 File Offset: 0x0000E432
	public CanQuet()
	{
		this.InitializeComponent();
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x0600174F RID: 5967 RVA: 0x00010240 File Offset: 0x0000E440
	// (set) Token: 0x06001750 RID: 5968 RVA: 0x00010248 File Offset: 0x0000E448
	public Class106 Class106_0 { get; set; }

	// Token: 0x06001751 RID: 5969 RVA: 0x000BFC14 File Offset: 0x000BDE14
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0)
		{
			foreach (object obj in this.lvTask.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.SubItems[1].Text == "Hoàn Thành")
				{
					listViewItem.SubItems[1].Text = "Đang Chờ";
				}
			}
			if (this.button2.Text == "Start")
			{
				this.button2.Text = "Stop";
			}
			return;
		}
		if (this.button2.Text != "Stop")
		{
			return;
		}
		try
		{
			if (this.lvTask.Items.Cast<ListViewItem>().Where<ListViewItem>(new Func<ListViewItem, bool>(CanQuet.Class282.f_78113AC3.method_0)).Count<ListViewItem>() != 0)
			{
				foreach (object obj2 in this.lvGame.Items)
				{
					ListViewItem listViewItem2 = (ListViewItem)obj2;
					foreach (Class106 @class in Class106.IEnumerable_0)
					{
						if (@class.Class527_0.String_11 == listViewItem2.Text)
						{
							listViewItem2.Tag = @class;
							if (this.class106_0 == null)
							{
								if (@class.Class527_0.Boolean_21)
								{
									this.class106_0 = @class;
									this.string_0 = @class.Class527_0.String_11;
								}
							}
							else if (this.class106_0.Process_0.HasExited && @class.Class527_0.String_11 == this.string_0)
							{
								this.class106_0 = @class;
							}
							break;
						}
					}
				}
				this.int_0 = 0;
				foreach (object obj3 in this.lvTask.Items)
				{
					string text = ((ListViewItem)obj3).SubItems[2].Text;
					if (text.Split(new char[] { ':' }).Length == 2)
					{
						int num = Class531.smethod_18(text.Split(new char[] { ':' })[0]);
						int num2 = Class531.smethod_18(text.Split(new char[] { ':' })[1]);
						this.int_0 += num * 60 + num2;
					}
				}
				int num3 = this.int_0 % 60;
				int num4 = (int)Math.Floor(this.int_0 / 60m);
				this.lvTask.Columns[2].Text = string.Format("{0:00}", num4) + ":" + string.Format("{0:00}", num3);
				if (this.class106_0 != null && this.class106_0.Class527_0.Int32_37 >= 10)
				{
					if (this.class106_0.Class527_0.Int32_31 == -1)
					{
						bool flag = false;
						foreach (object obj4 in this.lvGame.Items)
						{
							Class106 class2 = ((ListViewItem)obj4).Tag as Class106;
							if (class2 != this.class106_0 && class2.Class527_0.Int32_31 != -1 && !class2.method_100(this.class106_0.Class527_0))
							{
								this.class106_0.method_370(class2.Class527_0.Byte_0);
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							this.class106_0.method_375("Player:CreateTeamSelf();", false);
						}
					}
					else if (!this.class106_0.Class527_0.Boolean_21)
					{
						foreach (Class106 class3 in this.class106_0.List_21)
						{
							if (class3.Class527_0.Boolean_21)
							{
								class3.method_426(this.class106_0.Class527_0.String_11);
								break;
							}
						}
					}
					else
					{
						foreach (object obj5 in this.lvGame.Items)
						{
							(((ListViewItem)obj5).Tag as Class106).Boolean_56 = false;
						}
						foreach (object obj6 in this.lvGame.Items)
						{
							ListViewItem listViewItem3 = (ListViewItem)obj6;
							Class106 class4 = listViewItem3.Tag as Class106;
							if (class4.Process_0.HasExited)
							{
								this.class106_0.Boolean_56 = true;
								using (IEnumerator<Class106> enumerator2 = Class106.IEnumerable_0.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										Class106 class5 = enumerator2.Current;
										if (class5.Class527_0.String_11 == listViewItem3.Text)
										{
											listViewItem3.Tag = class5;
											break;
										}
									}
									continue;
								}
							}
							if (class4 != this.class106_0)
							{
								if (class4.method_100(this.class106_0.Class527_0))
								{
									class4.method_111(this.class106_0.Single_5, this.class106_0.Single_6, this.class106_0.Class527_0.Int32_35, false, 3f, 20f);
									this.class106_0.Boolean_56 = true;
									foreach (object obj7 in this.lvGame.Items)
									{
										(((ListViewItem)obj7).Tag as Class106).Boolean_56 = true;
									}
								}
								if (class4.Class527_0.Int32_31 == -1)
								{
									class4.method_370(this.class106_0.Class527_0.Byte_0);
									foreach (object obj8 in this.lvGame.Items)
									{
										(((ListViewItem)obj8).Tag as Class106).Boolean_56 = true;
										this.class106_0.Boolean_56 = true;
									}
								}
							}
						}
						foreach (ListViewItem listViewItem4 in this.lvTask.Items.Cast<ListViewItem>().Where<ListViewItem>(new Func<ListViewItem, bool>(CanQuet.Class282.f_78113AC3.method_1)))
						{
							if (listViewItem4.SubItems[1].Text == "Đang Làm")
							{
								string text2 = listViewItem4.SubItems[2].Text;
								if (text2.Split(new char[] { ':' }).Length == 2)
								{
									int num5 = Class531.smethod_18(text2.Split(new char[] { ':' })[0]);
									int num6 = Class531.smethod_18(text2.Split(new char[] { ':' })[1]);
									TimeSpan timeSpan = TimeSpan.FromSeconds((double)(num5 * 60 + num6 + 1));
									listViewItem4.SubItems[2].Text = (timeSpan.Hours * 60 + timeSpan.Minutes).ToString() + ":" + timeSpan.Seconds.ToString();
								}
								if (listViewItem4.Text == "Nhận Phỉ Thúy")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.NhanPhucNguyenLeHap))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Bảo Vệ Bang")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.BaoVeBang))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Nhận x2")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.NhanX2))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Đông x2")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.DongX2))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Nhận Chiến Công + Kiếm Chỉ")
								{
									foreach (object obj9 in this.lvGame.Items)
									{
										Class106 class6 = ((ListViewItem)obj9).Tag as Class106;
										if (class6.List_5.Contains(Enum17.NhanChienCong) || class6.List_5.Contains(Enum17.NhanKiemChi))
										{
											return;
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Hàng Ngày")
								{
									foreach (object obj10 in this.lvGame.Items)
									{
										Class106 class7 = ((ListViewItem)obj10).Tag as Class106;
										if (class7.List_5.Contains(Enum17.ThuTaiVanMay) || class7.List_5.Contains(Enum17.NguyenVongThienLinh))
										{
											return;
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Bán Đồ - Cất Đồ - Trị Liệu")
								{
									foreach (object obj11 in this.lvGame.Items)
									{
										Class106 class8 = ((ListViewItem)obj11).Tag as Class106;
										if (class8.List_5.Contains(Enum17.TriLieu) || class8.List_5.Contains(Enum17.BanRac) || class8.List_5.Contains(Enum17.CatVang) || class8.List_5.Contains(Enum17.CatDo))
										{
											return;
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Luyện Kim")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.LuyenKim))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Luyện Kim Nhanh")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.LuyenKimNhanh))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Sửa Trang Bị")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.SuaTrangBi))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Phiêu Miễu Phong")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiPhieuMieuPhong))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Q Tô Châu")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiTruPhiPhaTamQuan))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Q Lâu Lan")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiQ123LauLan))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Phân Giải Trang Bị Pet")
								{
									IEnumerator enumerator = this.lvGame.Items.GetEnumerator();
									{
										while (enumerator.MoveNext())
										{
											if ((((ListViewItem)enumerator.Current).Tag as Class106).List_5.Contains(Enum17.PhanGiaiTrangBiPet))
											{
												return;
											}
										}
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Phiêu Miễu Phong Huyết Chiến")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiKhieuChienPhieuMieuPhong))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Yến Tử Ô")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiYenTuO))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Sát Tinh")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiSatTinh))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Tứ Tuyệt Trang")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiTuTuyetTrang))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Thiếu Thất Sơn")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiThieuThatSon))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Vương Lăng")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiVuongLang))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Tam Thần Huyễn Cảnh")
								{
									if (this.class106_0.List_5.Contains(Enum17.DatDoiTamThan))
									{
										return;
									}
									listViewItem4.SubItems[1].Text = "Hoàn Thành";
								}
								if (listViewItem4.Text == "Lan Hoàn Phúc Địa")
								{
									if (!this.class106_0.List_5.Contains(Enum17.DatDoiPhucDia))
									{
										listViewItem4.SubItems[1].Text = "Hoàn Thành";
									}
								}
								return;
							}
						}
						foreach (object obj12 in this.lvTask.Items)
						{
							ListViewItem listViewItem5 = (ListViewItem)obj12;
							if (listViewItem5.Checked && listViewItem5.SubItems[1].Text == "Đang Chờ")
							{
								if (listViewItem5.Text == "Nhận Phỉ Thúy")
								{
									foreach (object obj13 in this.lvGame.Items)
									{
										(((ListViewItem)obj13).Tag as Class106).method_97(Enum17.NhanPhucNguyenLeHap, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Bảo Vệ Bang")
								{
									foreach (object obj14 in this.lvGame.Items)
									{
										(((ListViewItem)obj14).Tag as Class106).method_97(Enum17.BaoVeBang, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Nhận x2")
								{
									foreach (object obj15 in this.lvGame.Items)
									{
										(((ListViewItem)obj15).Tag as Class106).method_97(Enum17.NhanX2, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Đông x2")
								{
									foreach (object obj16 in this.lvGame.Items)
									{
										(((ListViewItem)obj16).Tag as Class106).method_97(Enum17.DongX2, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Nhận Chiến Công + Kiếm Chỉ")
								{
									foreach (object obj17 in this.lvGame.Items)
									{
										Class106 class9 = ((ListViewItem)obj17).Tag as Class106;
										class9.method_97(Enum17.NhanChienCong, true);
										class9.method_97(Enum17.NhanKiemChi, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Hàng Ngày")
								{
									foreach (object obj18 in this.lvGame.Items)
									{
										Class106 class10 = ((ListViewItem)obj18).Tag as Class106;
										class10.method_97(Enum17.ThuTaiVanMay, true);
										foreach (Class516 class11 in class10.Class214_0.IEnumerable_0)
										{
											if (class11.String_5 == "nguyenlinhtuyen" && class11.Int32_10 >= 5)
											{
												class10.method_97(Enum17.NguyenVongThienLinh, true);
												break;
											}
										}
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Bán Đồ - Cất Đồ - Trị Liệu")
								{
									foreach (object obj19 in this.lvGame.Items)
									{
										(((ListViewItem)obj19).Tag as Class106).method_98(new Enum17[]
										{
											Enum17.TriLieu,
											Enum17.BanRac,
											Enum17.CatVang,
											Enum17.CatDo
										});
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Luyện Kim")
								{
									foreach (object obj20 in this.lvGame.Items)
									{
										(((ListViewItem)obj20).Tag as Class106).method_97(Enum17.LuyenKim, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Luyện Kim Nhanh")
								{
									foreach (object obj21 in this.lvGame.Items)
									{
										(((ListViewItem)obj21).Tag as Class106).method_97(Enum17.LuyenKimNhanh, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Sửa Trang Bị")
								{
									foreach (object obj22 in this.lvGame.Items)
									{
										(((ListViewItem)obj22).Tag as Class106).method_97(Enum17.SuaTrangBi, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Q Lâu Lan")
								{
									this.class106_0.method_97(Enum17.DatDoiQ123LauLan, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Q Tô Châu")
								{
									this.class106_0.method_97(Enum17.DatDoiTruPhiPhaTamQuan, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Phiêu Miễu Phong")
								{
									this.class106_0.method_97(Enum17.DatDoiPhieuMieuPhong, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Phân Giải Trang Bị Pet")
								{
									foreach (object obj23 in this.lvGame.Items)
									{
										(((ListViewItem)obj23).Tag as Class106).method_97(Enum17.PhanGiaiTrangBiPet, true);
									}
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Phiêu Miễu Phong Huyết Chiến")
								{
									this.class106_0.method_97(Enum17.DatDoiKhieuChienPhieuMieuPhong, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Yến Tử Ô")
								{
									this.class106_0.method_97(Enum17.DatDoiYenTuO, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Sát Tinh")
								{
									this.class106_0.method_97(Enum17.DatDoiSatTinh, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Tứ Tuyệt Trang")
								{
									this.class106_0.method_97(Enum17.DatDoiTuTuyetTrang, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Thiếu Thất Sơn")
								{
									this.class106_0.method_97(Enum17.DatDoiThieuThatSon, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Vương Lăng")
								{
									this.class106_0.method_97(Enum17.DatDoiVuongLang, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Tam Thần Huyễn Cảnh")
								{
									this.class106_0.method_97(Enum17.DatDoiTamThan, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								if (listViewItem5.Text == "Lan Hoàn Phúc Địa")
								{
									this.class106_0.method_97(Enum17.DatDoiPhucDia, true);
									listViewItem5.SubItems[1].Text = "Đang Làm";
								}
								break;
							}
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x000C1928 File Offset: 0x000BFB28
	private void method_0()
	{
		string text = "";
		foreach (object obj in this.lvTask.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			text = string.Concat(new string[]
			{
				text,
				listViewItem.Text,
				"|",
				listViewItem.Checked.ToString(),
				"\r\n"
			});
		}
		Class106.Class210_0["CanQuet", "Default"] = text;
		if (this.class106_0 != null)
		{
			Class106.Class210_0["CanQuet", this.class106_0.String_29] = text;
		}
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x000C19FC File Offset: 0x000BFBFC
	private void CanQuet_Load(object sender, EventArgs e)
	{
		this.comboBox1.SelectedIndex = 0;
		foreach (Class106 @class in this.Class106_0.List_21)
		{
			if (!@class.Class527_0.Boolean_21)
			{
				ListViewItem listViewItem = new ListViewItem(@class.Class527_0.String_11);
				listViewItem.SubItems.Add("Thành Viên");
				listViewItem.Tag = @class;
				this.lvGame.Items.Add(listViewItem);
			}
			else
			{
				ListViewItem listViewItem2 = new ListViewItem(@class.Class527_0.String_11)
				{
					UseItemStyleForSubItems = false
				};
				listViewItem2.ForeColor = Color.Blue;
				listViewItem2.SubItems.Add("Đội Trưởng");
				listViewItem2.Tag = @class;
				this.lvGame.Items.Add(listViewItem2);
			}
		}
		this.lbCount.Text = this.lvGame.Items.Count.ToString();
		string text = Class106.Class210_0["CanQuet", this.class106_0.String_29];
		if (string.IsNullOrEmpty(text))
		{
			text = Class106.Class210_0["CanQuet", "Default"];
		}
		List<ListViewItem> list = new List<ListViewItem>();
		foreach (string text2 in text.Split(new char[] { '\n' }))
		{
			if (text2.Trim().Length > 2 && text2.Split(new char[] { '|' }).Length == 2)
			{
				ListViewItem listViewItem3 = new ListViewItem(text2.Split(new char[] { '|' })[0].Trim());
				if (text2.Split(new char[] { '|' })[1].Trim() == "True")
				{
					listViewItem3.Checked = true;
				}
				listViewItem3.SubItems.Add("Đang Chờ");
				listViewItem3.SubItems.Add("00:00");
				list.Add(listViewItem3);
			}
		}
		this.lvTask.Items.AddRange(list.ToArray());
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x000C1C50 File Offset: 0x000BFE50
	private void button1_Click(object sender, EventArgs e)
	{
		ListViewItem listViewItem = new ListViewItem(this.comboBox1.Text);
		listViewItem.SubItems.Add("Đang Chờ");
		listViewItem.SubItems.Add("00:00");
		listViewItem.Checked = true;
		this.lvTask.Items.Add(listViewItem);
		this.method_0();
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x00010251 File Offset: 0x0000E451
	private void button2_Click(object sender, EventArgs e)
	{
		if (this.button2.Text == "Start")
		{
			this.button2.Text = "Stop";
			return;
		}
		this.button2.Text = "Start";
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x000C1CB0 File Offset: 0x000BFEB0
	private void button5_Click(object sender, EventArgs e)
	{
		try
		{
			base.Parent.Parent.Controls.Remove(base.Parent);
			this.method_0();
		}
		catch
		{
		}
		finally
		{
			base.Dispose();
		}
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x0001028B File Offset: 0x0000E48B
	private void lvTask_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		this.method_0();
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x0000500B File Offset: 0x0000320B
	private void lvTask_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x00010293 File Offset: 0x0000E493
	private void lvTask_DoubleClick(object sender, EventArgs e)
	{
		while (this.lvTask.SelectedItems.Count > 0)
		{
			this.lvTask.SelectedItems[0].Remove();
		}
		this.method_0();
	}

	// Token: 0x04000EB6 RID: 3766
	public Class106 class106_0;

	// Token: 0x04000EB7 RID: 3767
	public string string_0;

	// Token: 0x04000EB8 RID: 3768
	private int int_0;

	// Token: 0x04000EB9 RID: 3769
	[CompilerGenerated]
	private Class106 class106_1;

	// Token: 0x0200019A RID: 410
	[CompilerGenerated]
	[Serializable]
	private sealed class Class282
	{
		// Token: 0x0600175E RID: 5982 RVA: 0x000102F2 File Offset: 0x0000E4F2
		internal bool method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.SubItems[1].Text.Contains("Đang");
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0001030F File Offset: 0x0000E50F
		internal bool method_1(ListViewItem listViewItem_0)
		{
			return listViewItem_0.SubItems[1].Text == "Đang Làm";
		}

		// Token: 0x04000ECD RID: 3789
		public static readonly CanQuet.Class282 f_78113AC3 = new CanQuet.Class282();

		// Token: 0x04000ECE RID: 3790
		public static Func<ListViewItem, bool> f_B71A398C;

		// Token: 0x04000ECF RID: 3791
		public static Func<ListViewItem, bool> f_88EDAAD8;
	}
}
