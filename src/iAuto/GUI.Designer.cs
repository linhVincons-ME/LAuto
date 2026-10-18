// Token: 0x02000268 RID: 616
internal partial class GUI : global::System.Windows.Forms.Form
{
	// Token: 0x06002207 RID: 8711 RVA: 0x000170FC File Offset: 0x000152FC
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000F8E00 File Offset: 0x000F7000
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GUI));
		global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("Quay Lại Bãi");
		global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("Attack");
		global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("Lure");
		global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("Chỉ Đánh");
		global::System.Windows.Forms.ListViewItem listViewItem5 = new global::System.Windows.Forms.ListViewItem("Tuyên Chiến");
		global::System.Windows.Forms.ListViewItem listViewItem6 = new global::System.Windows.Forms.ListViewItem("Only Pet");
		global::System.Windows.Forms.ListViewItem listViewItem7 = new global::System.Windows.Forms.ListViewItem("Pet");
		global::System.Windows.Forms.ListViewItem listViewItem8 = new global::System.Windows.Forms.ListViewItem("HP");
		global::System.Windows.Forms.ListViewItem listViewItem9 = new global::System.Windows.Forms.ListViewItem("MP");
		global::System.Windows.Forms.ListViewItem listViewItem10 = new global::System.Windows.Forms.ListViewItem("Chỉ Nhặt");
		global::System.Windows.Forms.ListViewItem listViewItem11 = new global::System.Windows.Forms.ListViewItem("Gia Công");
		global::System.Windows.Forms.ListViewItem listViewItem12 = new global::System.Windows.Forms.ListViewItem("Thăng Cấp");
		global::System.Windows.Forms.ListViewItem listViewItem13 = new global::System.Windows.Forms.ListViewItem("Quay Vòng");
		global::System.Windows.Forms.ListViewItem listViewItem14 = new global::System.Windows.Forms.ListViewItem("Tụ Linh Ngọc");
		global::System.Windows.Forms.ListViewItem listViewItem15 = new global::System.Windows.Forms.ListViewItem("Càn Khôn Hồ");
		global::System.Windows.Forms.ListViewItem listViewItem16 = new global::System.Windows.Forms.ListViewItem("Nhặt Đồ");
		global::System.Windows.Forms.ListViewItem listViewItem17 = new global::System.Windows.Forms.ListViewItem("Dùng x2");
		global::System.Windows.Forms.ListViewItem listViewItem18 = new global::System.Windows.Forms.ListViewItem("Dùng x4");
		global::System.Windows.Forms.ListViewItem listViewItem19 = new global::System.Windows.Forms.ListViewItem("x2, x3 Võ Ý");
		global::System.Windows.Forms.ListViewItem listViewItem20 = new global::System.Windows.Forms.ListViewItem("Keep Online");
		global::System.Windows.Forms.ListViewItem listViewItem21 = new global::System.Windows.Forms.ListViewItem("Hái Hoa");
		global::System.Windows.Forms.ListViewItem listViewItem22 = new global::System.Windows.Forms.ListViewItem("Mua Ngọc");
		global::System.Windows.Forms.ListViewItem listViewItem23 = new global::System.Windows.Forms.ListViewItem("Không Bật Lịch");
		global::System.Windows.Forms.ListViewItem listViewItem24 = new global::System.Windows.Forms.ListViewItem("Khai Khoáng");
		global::System.Windows.Forms.ListViewItem listViewItem25 = new global::System.Windows.Forms.ListViewItem("Hái Dược");
		global::System.Windows.Forms.ListViewItem listViewItem26 = new global::System.Windows.Forms.ListViewItem("Thu Thập");
		global::System.Windows.Forms.ListViewItem listViewItem27 = new global::System.Windows.Forms.ListViewItem("Báo inbox");
		global::System.Windows.Forms.ListViewItem listViewItem28 = new global::System.Windows.Forms.ListViewItem("Khai Thác");
		this.menuListView = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.menuHideGame = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuShowGame = new global::System.Windows.Forms.ToolStripMenuItem();
		this.centerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.maximizeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.viewToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x2ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x2ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x3ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x4ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x6ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.x8ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuRefreshAuto = new global::System.Windows.Forms.ToolStripMenuItem();
		this.reloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator15 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuDiChuyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDinhVi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDinhViThoLinhChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDinhViAllThoLinhChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuAllDinhViPhu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuUse = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuUseThoLinhChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuUseDinhViPhu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuUseTrieuTapLenh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLucPhu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThemPhu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator20 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem9 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem10 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem11 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem12 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem13 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem14 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem15 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem19 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem20 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThemToaDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator38 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuTrieuTapTheo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTrieuTap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTrieuTapNhom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuBuocTrieuTap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDiChuyenVongTron = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator31 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuLuuToaDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLenToaDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuToDoi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuMoiDoi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator58 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuSetNhom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTuTaoNhom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQuanLyNhom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator27 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuCreateTeam = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuJoinTeam = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muGiaiTan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_46 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThaoTac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem17 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem21 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem22 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem23 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem24 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem5 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem16 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem25 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem26 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem27 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuMuaCuongHoaLo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_67 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_79 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_52 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muaX2ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_59 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_60 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_61 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_62 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_53 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_54 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_55 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_56 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_57 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_58 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muAnDon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQuayVeDaiLy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator14 = new global::System.Windows.Forms.ToolStripSeparator();
		this.mLenNgua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.mXuongNgua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator11 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muXuatPet = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThuPet = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muHaoHuu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuyetGiao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_71 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_72 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuSelectServer = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuExitGame = new global::System.Windows.Forms.ToolStripMenuItem();
		this.quitNRelogToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.setDoneToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator34 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muNhapCode = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDebug = new global::System.Windows.Forms.ToolStripMenuItem();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.menuMain = new global::System.Windows.Forms.MenuStrip();
		this.muPlayer = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThuongDung = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiBanRac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTriLieu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTriLieuBanRacCatDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muNhanx2 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDongx2 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPhanGiaiTrangBijPet = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_20 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator37 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuMoSap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLenGia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuChoGiao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuChayThuongNhan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuStopTrader = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQuayVe = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDiToi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_39 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_40 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiKinhNghiem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiNoiTuc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiThieuThatSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiYenTuO = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiTuTuyetTrang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiPhucDia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiVuongLang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiTamThan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLaiPhieuMieuPhong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muGom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDuaKNBCho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDuaDoChoTa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDuaTangBaoDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_49 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_51 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator29 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muTrangBi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDucLo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.socket1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.socket2 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.socket3 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLenhBai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNangBaoChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuRed = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuGreen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuBlue = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuYellow = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTangSaoLenhBai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem28 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCold = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuFire = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLight = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuPoison = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_31 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToiLuyenThe = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToiLuyenBang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToiLuyenHuyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToiLuyenHoa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToiLuyenDoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTrungLau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_50 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLen8Sao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_63 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_68 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator41 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muCuongHoaDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_64 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_65 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_66 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCheThanKhi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNgungTuBaoGiam = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muGiaiPhongChanNguyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTangCapTruongThanhLongVan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator16 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuThaoTrangBi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDeoTrangBi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThaoDeo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator12 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuGiamDinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_34 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThuongKho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuOpenBank = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCatDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLayDoKhongCoDinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLayDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLayDoLayVang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThuongHoi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuXuongGia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLenGia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuLayDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator17 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muDi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuSkillStudy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_32 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.lrn30 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len40 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len45 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len50 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len60 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len75 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len80 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len90 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.len100 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTuLuyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuLuyenTheLuc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuLuyenNoiLuc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuLuyenThanPhap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuLuyenCuongLuc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuLuyenTheNoiThan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muMoShop = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoShopTrungDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoShopHungBa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoShopBachBaoCac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoShopVanCam = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoTiemThuoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuMoHoaNgocTap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_29 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_30 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBaGiaCan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBaGiaKhon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPhonghoa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiMuaNgua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNopTuViHuyTinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThanhLyNhiemVu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muGiaoNguHanhPhapThiep = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem32 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuHocCheDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThinhGiaoBiKy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMua100KimSangDuoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.mu200ReTranh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiSua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.trangBij13ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.trangBij23ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muSuaVoHon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muSuaThanKhi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muSuaTrangBi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_33 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiDoi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem33 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem34 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem35 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem36 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem37 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem39 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem40 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_22 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_23 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_24 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_25 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_26 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_27 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_28 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDoiChanNguyenLinhPhach = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDoiHuyenSac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_18 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_19 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDoiLoanPhi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDoiDiaLinhChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem46 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDoiBoiDiep = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiNhan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanThienMachPhucTrach = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_14 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_15 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_16 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_17 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanChienCongKiemChi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanThuongQuanSonHai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanBuaBaoRuong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLeBao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanLenhBai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBaGiaLinhThao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanx2x3VoY = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanPhiThuy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNhanBachHoaHuongNang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_70 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPkMode = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuHoaBinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThienAc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNhom = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuBang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQuanDoan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muIntime = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muAcTac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator21 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muVoLuongSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKinhHo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKiemCac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThaiHo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTungSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDonHoang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muAcBa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muAcBaTuDong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator24 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuDaoHoa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQuyCoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuDuongMon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuMoDung = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTinhTuc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTieuDao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThieuLam = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThienSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThienLong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNgamy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuVoDang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuMinhGiao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCaiBang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTuyetTinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.MenuAcNhanCoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTangKinhCac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator22 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuTayHo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNhiHai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuNhanNham = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuBossMap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThuongSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuVoDi = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThaoNguyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuHuyenVuDao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuKinhHo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator40 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muTucCau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKyCuoc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKyCuocNhanh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKyCuocCham = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLauLanTamBao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLauLanTamBaoNhanh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLauLanTamBaoCham = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator39 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muDaTru = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMongHeo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThienGiangKyThu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPhungHoangLangMo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator30 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muBaoDoHiem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDoanBaoMaTac = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDaily = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muHangNgay = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muToanBoHangNgay = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator33 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muRotRuou = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBaoVeBang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muVanMay = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNguyenVong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator45 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muThanKhi9Sao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThienKiepLau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_37 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTamAnhCuuLeThuong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTamAnhCuuLeKho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuChoiCungNienThu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuAnTiec = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_69 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.qBangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muXayDung = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNghienCuu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muKhuyechTruong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThuongNghiep = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCongTrinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKyThuat = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPhatTrien = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQuocPhong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator36 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muConCai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTuDuong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muPhuMau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNhanCon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenThangCap = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenExp = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenKnbKhoa = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNgoChanNguyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenChinhTuyen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenVoY = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCotTruyenVoTuPho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.mux2Exp = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThienSuKyDai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBiBao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muBaoThachBieuTang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muThongBao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_78 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_41 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_42 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_43 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_44 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_45 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator32 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muSuMon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muTrungAc = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muMoBaoTangDo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator35 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muNhanThuongTriVu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muSinhTieu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDungDoatBaoRuong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muKiemTung = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_74 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muVoDao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muVoDao1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_77 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muFuBen = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCanQuet = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQThuCong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQAll = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_75 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_76 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ1ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ2ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ3ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVSatTInh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ1LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ2LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.canVQ3LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator44 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muCQKhieuChienPMP = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQPhucDia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQPhucDiaKho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQVuongLang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQTamThan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQTuTuyetTrang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQThieuThatSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQYenTuO = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muCQTruPhiPhaTamQuan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ1ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ2ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ3ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQSatTinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ1LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ2LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQQ3LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQYenTuO = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQSCPMP = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQKCPMP = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuCQThuyNguyetSonTrang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator43 = new global::System.Windows.Forms.ToolStripSeparator();
		this.evBinhThanhKyTran = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evPhieuMieuPhong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evYenTuO = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evTuTuyetTrang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evThieuThatSon = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evPhucDia = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evPhucDiaKho = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evVuongLang = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evTamThan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.evTruPhiPhaTamQuan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQuanSonHai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuSatTinh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator13 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muQ1ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQ2ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQ3ToChau = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQ3ToChauNhanh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQ3ToChauCham = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator19 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muQ1LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQ2LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muQ3LauLan = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQ3LauLanNhanh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuQ3LauLanCham = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator42 = new global::System.Windows.Forms.ToolStripSeparator();
		this.muThuyLao = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_35 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuThanhKhuu = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuTNST = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muAll = new global::System.Windows.Forms.ToolStripMenuItem();
		this.selectCtrlAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_21 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.refreshToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator28 = new global::System.Windows.Forms.ToolStripSeparator();
		this.selectServerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.eitOFFLINEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.quitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator9 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuDauThai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muLenNgua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muXuongNgua = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muDiemDanh = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muSapXepTayNai = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muNier = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuOpenGame = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open1ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open2ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open3ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open4ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open5ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open6ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open12ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open24ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open48ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.open96ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuSelectPath = new global::System.Windows.Forms.ToolStripMenuItem();
		this.autoPkAltIToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuPickNear = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuPickItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.muItemFiller = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_47 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_73 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_48 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuFollowKey = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuuForceFollowKey = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator25 = new global::System.Windows.Forms.ToolStripSeparator();
		this.menuAtkFollowKey = new global::System.Windows.Forms.ToolStripMenuItem();
		this.menuPkMode = new global::System.Windows.Forms.ToolStripMenuItem();
		this.goToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
		this.tabPage5 = new global::System.Windows.Forms.TabPage();
		this.label9 = new global::System.Windows.Forms.Label();
		this.splitContainer3 = new global::System.Windows.Forms.SplitContainer();
		this.panel7 = new global::System.Windows.Forms.Panel();
		this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.clearToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.notifyIcon_0 = new global::System.Windows.Forms.NotifyIcon(this.icontainer_0);
		this.contextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.updateIAutoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
		this.onTopToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.englishToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.englishToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_38 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_36 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator23 = new global::System.Windows.Forms.ToolStripSeparator();
		this.resetSpeedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.pauseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tabLoginOnline = new global::System.Windows.Forms.TabPage();
		this.loginUser1 = new global::LoginUser();
		this.columnHeader_19 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_20 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_21 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_22 = new global::System.Windows.Forms.ColumnHeader();
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
		this.checkSkill = new global::System.Windows.Forms.CheckBox();
		this.txtPass2 = new global::Class533();
		this.cboLeader = new global::System.Windows.Forms.ComboBox();
		this.cboMenpai = new global::System.Windows.Forms.ComboBox();
		this.checkPanel = new global::System.Windows.Forms.CheckBox();
		this.menuQr = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tabMain = new global::Control6();
		this.tabGame = new global::System.Windows.Forms.TabPage();
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.LvGame = new global::_i.ListViewEx();
		this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_7 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_8 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_9 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_10 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_11 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_12 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_13 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_14 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_15 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_16 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_17 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_18 = new global::System.Windows.Forms.ColumnHeader();
		this.tabBoottom = new global::Control6();
		this.tabBuff = new global::System.Windows.Forms.TabPage();
		this.myPanel7 = new global::GClass3();
		this.lvSkill = new global::_i.ListViewEx();
		this.columnHeader_24 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_25 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_26 = new global::System.Windows.Forms.ColumnHeader();
		this.panelEx3 = new global::GClass3();
		this.txtSearchName = new global::Class533();
		this.panelEx1 = new global::GClass3();
		this.lvFunction = new global::_i.ListViewEx();
		this.columnHeader_23 = new global::System.Windows.Forms.ColumnHeader();
		this.txtSearchFuntion = new global::Class533();
		this.panelEx4 = new global::GClass3();
		this.checkShowPass = new global::System.Windows.Forms.CheckBox();
		this.tabQ = new global::System.Windows.Forms.TabPage();
		this.myPanel2 = new global::GClass3();
		this.myPanel5 = new global::GClass3();
		this.panelEx5 = new global::GClass3();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.cboPhu = new global::System.Windows.Forms.ComboBox();
		this.checkAutoPhu = new global::System.Windows.Forms.CheckBox();
		this.grNM = new global::GClass3();
		this.numberNM = new global::Control0();
		this.checkNM = new global::System.Windows.Forms.CheckBox();
		this.panel5 = new global::System.Windows.Forms.Panel();
		this.cboPoint = new global::System.Windows.Forms.ComboBox();
		this.btnAddPoint = new global::System.Windows.Forms.Button();
		this.numberPoint = new global::System.Windows.Forms.NumericUpDown();
		this.panelEx2 = new global::GClass3();
		this.checkRadius = new global::CheckBoxNumberControl();
		this.cboPet = new global::CheckBoxComboControl();
		this.panel8 = new global::System.Windows.Forms.Panel();
		this.panel24 = new global::System.Windows.Forms.Panel();
		this.txtJoindGuildId = new global::Class533();
		this.btnJoinGuild = new global::System.Windows.Forms.Button();
		this.cboTrongTrot = new global::System.Windows.Forms.ComboBox();
		this.checkTrongTrot = new global::System.Windows.Forms.CheckBox();
		this.panel9 = new global::System.Windows.Forms.Panel();
		this.txtRao = new global::Class533();
		this.button6 = new global::System.Windows.Forms.Button();
		this.chkRaoVat = new global::System.Windows.Forms.CheckBox();
		this.panel2 = new global::System.Windows.Forms.Panel();
		this.lblTrader = new global::System.Windows.Forms.Label();
		this.lblCityName = new global::System.Windows.Forms.Label();
		this.lblFriendCityName = new global::System.Windows.Forms.Label();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
		this.panel4 = new global::System.Windows.Forms.Panel();
		this.panel11 = new global::System.Windows.Forms.Panel();
		this.btnDuc = new global::System.Windows.Forms.Button();
		this.btnKham = new global::System.Windows.Forms.Button();
		this.cboTrangBi = new global::System.Windows.Forms.ComboBox();
		this.panel12 = new global::System.Windows.Forms.Panel();
		this.btnTrac = new global::System.Windows.Forms.Button();
		this.btnHop = new global::System.Windows.Forms.Button();
		this.cboGem = new global::System.Windows.Forms.ComboBox();
		this.tabPage1 = new global::System.Windows.Forms.TabPage();
		this.checkHuyCraft = new global::Class286();
		this.numHuyCraftLine = new global::System.Windows.Forms.NumericUpDown();
		this.numHuyCraftStar = new global::System.Windows.Forms.NumericUpDown();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label1 = new global::System.Windows.Forms.Label();
		this.panel10 = new global::System.Windows.Forms.Panel();
		this.panel14 = new global::System.Windows.Forms.Panel();
		this.cboDaTaoDo = new global::System.Windows.Forms.ComboBox();
		this.cboCheNoiNgoai = new global::System.Windows.Forms.ComboBox();
		this.checkCraft = new global::System.Windows.Forms.CheckBox();
		this.panel17 = new global::System.Windows.Forms.Panel();
		this.txtMainSearch = new global::Class533();
		this.tabiLogin = new global::System.Windows.Forms.TabPage();
		this.tabLogin = new global::Control6();
		this.tabPay = new global::System.Windows.Forms.TabPage();
		this.myPanel3 = new global::GClass3();
		this.picQr = new global::System.Windows.Forms.PictureBox();
		this.txtHWID = new global::Class533();
		this.button5 = new global::System.Windows.Forms.Button();
		this.txtiAutoUser = new global::Class533();
		this.btnRefresh = new global::System.Windows.Forms.Button();
		this.button12 = new global::System.Windows.Forms.Button();
		this.myPanel1 = new global::GClass3();
		this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
		this.groupBox9 = new global::System.Windows.Forms.GroupBox();
		this.txtBetChip = new global::Class533();
		this.button14 = new global::System.Windows.Forms.Button();
		this.lblIncome = new global::System.Windows.Forms.Label();
		this.btnBlance = new global::System.Windows.Forms.Button();
		this.btnDayVNG = new global::System.Windows.Forms.Button();
		this.btnDayPRI = new global::System.Windows.Forms.Button();
		this.btnDayORI = new global::System.Windows.Forms.Button();
		this.groupBox2 = new global::System.Windows.Forms.GroupBox();
		this.button3 = new global::System.Windows.Forms.Button();
		this.txtNewPass = new global::Class533();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.txtGiftCode = new global::Class533();
		this.btnOpenGiftCode = new global::System.Windows.Forms.Button();
		this.groupBox8 = new global::System.Windows.Forms.GroupBox();
		this.txtSendChip = new global::Class533();
		this.txtUserChip = new global::Class533();
		this.btnSendChip = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.tabinBox = new global::System.Windows.Forms.TabPage();
		this.lvInbox = new global::_i.ListViewEx();
		this.columnHeader_27 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_28 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_29 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_30 = new global::System.Windows.Forms.ColumnHeader();
		this.txtContent = new global::Class533();
		this.panel23 = new global::System.Windows.Forms.Panel();
		this.txtChatContent = new global::Class533();
		this.txtChatFrom = new global::Class533();
		this.button17 = new global::System.Windows.Forms.Button();
		this.panel6 = new global::System.Windows.Forms.Panel();
		this.textBoxEx2 = new global::Class533();
		this.checkAutoShow = new global::System.Windows.Forms.CheckBox();
		this.tabSetting = new global::System.Windows.Forms.TabPage();
		this.tabConfig = new global::System.Windows.Forms.TabPage();
		this.tabChat = new global::System.Windows.Forms.TabPage();
		this.menuListView.SuspendLayout();
		this.menuMain.SuspendLayout();
		this.tabPage5.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
		this.splitContainer3.SuspendLayout();
		this.contextMenuStrip1.SuspendLayout();
		this.contextMenuStrip2.SuspendLayout();
		this.tabLoginOnline.SuspendLayout();
		this.menuQr.SuspendLayout();
		this.tabMain.SuspendLayout();
		this.tabGame.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.tabBoottom.SuspendLayout();
		this.tabBuff.SuspendLayout();
		this.myPanel7.SuspendLayout();
		this.panelEx3.SuspendLayout();
		this.panelEx1.SuspendLayout();
		this.panelEx4.SuspendLayout();
		this.tabQ.SuspendLayout();
		this.myPanel2.SuspendLayout();
		this.myPanel5.SuspendLayout();
		this.panelEx5.SuspendLayout();
		this.panel1.SuspendLayout();
		this.grNM.SuspendLayout();
		this.panel5.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.numberPoint).BeginInit();
		this.panelEx2.SuspendLayout();
		this.panel8.SuspendLayout();
		this.panel24.SuspendLayout();
		this.panel9.SuspendLayout();
		this.panel2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
		this.splitContainer2.Panel1.SuspendLayout();
		this.splitContainer2.Panel2.SuspendLayout();
		this.splitContainer2.SuspendLayout();
		this.panel4.SuspendLayout();
		this.panel11.SuspendLayout();
		this.panel12.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.checkHuyCraft.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.numHuyCraftLine).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.numHuyCraftStar).BeginInit();
		this.panel10.SuspendLayout();
		this.panel17.SuspendLayout();
		this.tabiLogin.SuspendLayout();
		this.tabPay.SuspendLayout();
		this.myPanel3.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picQr).BeginInit();
		this.myPanel1.SuspendLayout();
		this.groupBox9.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.groupBox8.SuspendLayout();
		this.tabinBox.SuspendLayout();
		this.panel23.SuspendLayout();
		this.panel6.SuspendLayout();
		base.SuspendLayout();
		this.menuListView.ImageScalingSize = new global::System.Drawing.Size(24, 24);
		this.menuListView.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuHideGame, this.menuShowGame, this.centerToolStripMenuItem, this.maximizeToolStripMenuItem, this.viewToolStripMenuItem, this.menuRefreshAuto, this.reloadToolStripMenuItem, this.toolStripSeparator15, this.menuDiChuyen, this.menuToDoi,
			this.menuThaoTac, this.toolStripSeparator5, this.menuSelectServer, this.menuExitGame, this.quitNRelogToolStripMenuItem, this.setDoneToolStripMenuItem, this.toolStripSeparator34, this.muNhapCode, this.menuDebug
		});
		this.menuListView.Name = "menuListView";
		this.menuListView.Size = new global::System.Drawing.Size(171, 374);
		this.menuListView.Opening += new global::System.ComponentModel.CancelEventHandler(this.menuListView_Opening);
		this.menuHideGame.Name = "menuHideGame";
		this.menuHideGame.Size = new global::System.Drawing.Size(170, 22);
		this.menuHideGame.Text = "Hide";
		this.menuHideGame.Click += new global::System.EventHandler(this.menuHideGame_Click);
		this.menuShowGame.Name = "menuShowGame";
		this.menuShowGame.Size = new global::System.Drawing.Size(170, 22);
		this.menuShowGame.Text = "Show";
		this.menuShowGame.Click += new global::System.EventHandler(this.menuShowGame_Click);
		this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
		this.centerToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.centerToolStripMenuItem.Text = "Center";
		this.centerToolStripMenuItem.Click += new global::System.EventHandler(this.centerToolStripMenuItem_Click);
		this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
		this.maximizeToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.maximizeToolStripMenuItem.Text = "Maximize";
		this.maximizeToolStripMenuItem.Click += new global::System.EventHandler(this.maximizeToolStripMenuItem_Click);
		this.viewToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.x2ToolStripMenuItem, this.x2ToolStripMenuItem1, this.x3ToolStripMenuItem, this.x4ToolStripMenuItem, this.x6ToolStripMenuItem, this.x8ToolStripMenuItem });
		this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
		this.viewToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.viewToolStripMenuItem.Text = "Split View";
		this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
		this.x2ToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
		this.x2ToolStripMenuItem.Text = "2x2";
		this.x2ToolStripMenuItem.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.x2ToolStripMenuItem1.Name = "x2ToolStripMenuItem1";
		this.x2ToolStripMenuItem1.Size = new global::System.Drawing.Size(91, 22);
		this.x2ToolStripMenuItem1.Text = "3x2";
		this.x2ToolStripMenuItem1.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
		this.x3ToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
		this.x3ToolStripMenuItem.Text = "4x3";
		this.x3ToolStripMenuItem.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
		this.x4ToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
		this.x4ToolStripMenuItem.Text = "6x4";
		this.x4ToolStripMenuItem.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
		this.x6ToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
		this.x6ToolStripMenuItem.Text = "8x6";
		this.x6ToolStripMenuItem.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
		this.x8ToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
		this.x8ToolStripMenuItem.Text = "9x8";
		this.x8ToolStripMenuItem.Click += new global::System.EventHandler(this.x8ToolStripMenuItem_Click);
		this.menuRefreshAuto.Name = "menuRefreshAuto";
		this.menuRefreshAuto.Size = new global::System.Drawing.Size(170, 22);
		this.menuRefreshAuto.Text = "Refresh [Ctrl + W]";
		this.menuRefreshAuto.Click += new global::System.EventHandler(this.menuRefreshAuto_Click);
		this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
		this.reloadToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.reloadToolStripMenuItem.Text = "Reload";
		this.reloadToolStripMenuItem.Click += new global::System.EventHandler(this.reloadToolStripMenuItem_Click);
		this.toolStripSeparator15.Name = "toolStripSeparator15";
		this.toolStripSeparator15.Size = new global::System.Drawing.Size(167, 6);
		this.menuDiChuyen.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuDinhVi, this.menuUse, this.menuLucPhu, this.menuThemToaDo, this.toolStripSeparator38, this.menuTrieuTapTheo, this.menuTrieuTap, this.menuTrieuTapNhom, this.menuBuocTrieuTap, this.menuDiChuyenVongTron,
			this.toolStripSeparator31, this.menuLuuToaDo, this.menuLenToaDo
		});
		this.menuDiChuyen.Name = "menuDiChuyen";
		this.menuDiChuyen.Size = new global::System.Drawing.Size(170, 22);
		this.menuDiChuyen.Text = "Di Chuyển";
		this.menuDinhVi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuDinhViThoLinhChau, this.muDinhViAllThoLinhChau, this.menuAllDinhViPhu });
		this.menuDinhVi.Name = "menuDinhVi";
		this.menuDinhVi.Size = new global::System.Drawing.Size(234, 22);
		this.menuDinhVi.Text = "Định Vị";
		this.menuDinhViThoLinhChau.Name = "menuDinhViThoLinhChau";
		this.menuDinhViThoLinhChau.Size = new global::System.Drawing.Size(254, 22);
		this.menuDinhViThoLinhChau.Text = "Thổ Linh Châu -> Ctrl + [";
		this.menuDinhViThoLinhChau.Click += new global::System.EventHandler(this.menuDinhViThoLinhChau_Click);
		this.muDinhViAllThoLinhChau.Name = "muDinhViAllThoLinhChau";
		this.muDinhViAllThoLinhChau.Size = new global::System.Drawing.Size(254, 22);
		this.muDinhViAllThoLinhChau.Text = "Toàn Bộ Thổ Linh Châu -> Ctrl + ]";
		this.muDinhViAllThoLinhChau.Click += new global::System.EventHandler(this.muDinhViAllThoLinhChau_Click);
		this.menuAllDinhViPhu.Name = "menuAllDinhViPhu";
		this.menuAllDinhViPhu.Size = new global::System.Drawing.Size(254, 22);
		this.menuAllDinhViPhu.Text = "Toàn Bộ Định Vị Phù";
		this.menuUse.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuUseThoLinhChau, this.menuUseDinhViPhu, this.menuUseTrieuTapLenh });
		this.menuUse.Name = "menuUse";
		this.menuUse.Size = new global::System.Drawing.Size(234, 22);
		this.menuUse.Text = "Dùng";
		this.menuUseThoLinhChau.Name = "menuUseThoLinhChau";
		this.menuUseThoLinhChau.Size = new global::System.Drawing.Size(206, 22);
		this.menuUseThoLinhChau.Text = "Thổ Linh Châu";
		this.menuUseDinhViPhu.Name = "menuUseDinhViPhu";
		this.menuUseDinhViPhu.Size = new global::System.Drawing.Size(206, 22);
		this.menuUseDinhViPhu.Text = "Định Vị Phù";
		this.menuUseTrieuTapLenh.Name = "menuUseTrieuTapLenh";
		this.menuUseTrieuTapLenh.Size = new global::System.Drawing.Size(206, 22);
		this.menuUseTrieuTapLenh.Text = "Môn Phái Triệu Tập Lệnh";
		this.menuLucPhu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuThemPhu, this.toolStripSeparator20, this.toolStripMenuItem6, this.toolStripMenuItem7, this.toolStripMenuItem8, this.toolStripMenuItem9, this.toolStripMenuItem10, this.toolStripMenuItem11, this.toolStripMenuItem12, this.toolStripMenuItem13,
			this.toolStripMenuItem14, this.toolStripMenuItem15, this.toolStripMenuItem19, this.toolStripMenuItem20
		});
		this.menuLucPhu.Name = "menuLucPhu";
		this.menuLucPhu.Size = new global::System.Drawing.Size(234, 22);
		this.menuLucPhu.Text = "Lục Phù";
		this.menuThemPhu.Name = "menuThemPhu";
		this.menuThemPhu.Size = new global::System.Drawing.Size(129, 22);
		this.menuThemPhu.Text = "Thêm Phù";
		this.menuThemPhu.Click += new global::System.EventHandler(this.menuThemPhu_Click);
		this.toolStripSeparator20.Name = "toolStripSeparator20";
		this.toolStripSeparator20.Size = new global::System.Drawing.Size(126, 6);
		this.toolStripMenuItem6.Name = "toolStripMenuItem6";
		this.toolStripMenuItem6.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem6.Text = "1";
		this.toolStripMenuItem6.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem7.Name = "toolStripMenuItem7";
		this.toolStripMenuItem7.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem7.Text = "2";
		this.toolStripMenuItem7.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem8.Name = "toolStripMenuItem8";
		this.toolStripMenuItem8.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem8.Text = "3";
		this.toolStripMenuItem8.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem9.Name = "toolStripMenuItem9";
		this.toolStripMenuItem9.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem9.Text = "4";
		this.toolStripMenuItem9.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem10.Name = "toolStripMenuItem10";
		this.toolStripMenuItem10.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem10.Text = "5";
		this.toolStripMenuItem10.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem11.Name = "toolStripMenuItem11";
		this.toolStripMenuItem11.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem11.Text = "6";
		this.toolStripMenuItem11.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem12.Name = "toolStripMenuItem12";
		this.toolStripMenuItem12.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem12.Text = "7";
		this.toolStripMenuItem12.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem13.Name = "toolStripMenuItem13";
		this.toolStripMenuItem13.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem13.Text = "8";
		this.toolStripMenuItem13.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem14.Name = "toolStripMenuItem14";
		this.toolStripMenuItem14.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem14.Text = "9";
		this.toolStripMenuItem14.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem15.Name = "toolStripMenuItem15";
		this.toolStripMenuItem15.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem15.Text = "10";
		this.toolStripMenuItem15.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem19.Name = "toolStripMenuItem19";
		this.toolStripMenuItem19.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem19.Text = "11";
		this.toolStripMenuItem19.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.toolStripMenuItem20.Name = "toolStripMenuItem20";
		this.toolStripMenuItem20.Size = new global::System.Drawing.Size(129, 22);
		this.toolStripMenuItem20.Text = "12";
		this.toolStripMenuItem20.Click += new global::System.EventHandler(this.toolStripMenuItem20_Click);
		this.menuThemToaDo.Name = "menuThemToaDo";
		this.menuThemToaDo.Size = new global::System.Drawing.Size(234, 22);
		this.menuThemToaDo.Text = "+ Thêm Tọa Độ +";
		this.menuThemToaDo.Click += new global::System.EventHandler(this.menuThemToaDo_Click);
		this.toolStripSeparator38.Name = "toolStripSeparator38";
		this.toolStripSeparator38.Size = new global::System.Drawing.Size(231, 6);
		this.menuTrieuTapTheo.Name = "menuTrieuTapTheo";
		this.menuTrieuTapTheo.Size = new global::System.Drawing.Size(234, 22);
		this.menuTrieuTapTheo.Text = "Triệu Tập";
		this.menuTrieuTapTheo.DropDownOpening += new global::System.EventHandler(this.menuTrieuTapTheo_DropDownOpening);
		this.menuTrieuTap.Name = "menuTrieuTap";
		this.menuTrieuTap.Size = new global::System.Drawing.Size(234, 22);
		this.menuTrieuTap.Text = "Triệu Tập [Alt + F1]";
		this.menuTrieuTap.Click += new global::System.EventHandler(this.menuTrieuTap_Click);
		this.menuTrieuTapNhom.Name = "menuTrieuTapNhom";
		this.menuTrieuTapNhom.Size = new global::System.Drawing.Size(234, 22);
		this.menuTrieuTapNhom.Text = "Triệu Tập Nhóm [Alt + F2]";
		this.menuTrieuTapNhom.Click += new global::System.EventHandler(this.menuTrieuTapNhom_Click);
		this.menuBuocTrieuTap.Name = "menuBuocTrieuTap";
		this.menuBuocTrieuTap.Size = new global::System.Drawing.Size(234, 22);
		this.menuBuocTrieuTap.Text = "Buộc Triệu Tập [Alt + F3]";
		this.menuBuocTrieuTap.Click += new global::System.EventHandler(this.menuBuocTrieuTap_Click);
		this.menuDiChuyenVongTron.Name = "menuDiChuyenVongTron";
		this.menuDiChuyenVongTron.Size = new global::System.Drawing.Size(234, 22);
		this.menuDiChuyenVongTron.Text = "Di Chuyển Vòng Tròn [Alt + G]";
		this.toolStripSeparator31.Name = "toolStripSeparator31";
		this.toolStripSeparator31.Size = new global::System.Drawing.Size(231, 6);
		this.menuLuuToaDo.Name = "menuLuuToaDo";
		this.menuLuuToaDo.Size = new global::System.Drawing.Size(234, 22);
		this.menuLuuToaDo.Text = "Lưu Vị Trí Luyện";
		this.menuLuuToaDo.Click += new global::System.EventHandler(this.menuLuuToaDo_Click);
		this.menuLenToaDo.Name = "menuLenToaDo";
		this.menuLenToaDo.Size = new global::System.Drawing.Size(234, 22);
		this.menuLenToaDo.Text = "Lên Vị Trí Luyện";
		this.menuLenToaDo.Click += new global::System.EventHandler(this.menuLenToaDo_Click);
		this.menuToDoi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuMoiDoi, this.toolStripSeparator58, this.menuSetNhom, this.menuTuTaoNhom, this.menuQuanLyNhom, this.toolStripSeparator27, this.menuCreateTeam, this.menuJoinTeam, this.muGiaiTan, this.toolStripMenuItem_46 });
		this.menuToDoi.Name = "menuToDoi";
		this.menuToDoi.Size = new global::System.Drawing.Size(170, 22);
		this.menuToDoi.Text = "Tổ Đội";
		this.menuMoiDoi.Name = "menuMoiDoi";
		this.menuMoiDoi.Size = new global::System.Drawing.Size(231, 22);
		this.menuMoiDoi.Text = "Mời Đội [Ctrl+ F1 | Ctrl + End]";
		this.menuMoiDoi.Click += new global::System.EventHandler(this.menuMoiDoi_Click);
		this.toolStripSeparator58.Name = "toolStripSeparator58";
		this.toolStripSeparator58.Size = new global::System.Drawing.Size(228, 6);
		this.menuSetNhom.Name = "menuSetNhom";
		this.menuSetNhom.Size = new global::System.Drawing.Size(231, 22);
		this.menuSetNhom.Text = "Set Nhóm";
		this.menuSetNhom.Click += new global::System.EventHandler(this.menuSetNhom_Click);
		this.menuTuTaoNhom.Name = "menuTuTaoNhom";
		this.menuTuTaoNhom.Size = new global::System.Drawing.Size(231, 22);
		this.menuTuTaoNhom.Text = "Tự Tạo Nhóm";
		this.menuTuTaoNhom.Click += new global::System.EventHandler(this.menuTuTaoNhom_Click);
		this.menuQuanLyNhom.Name = "menuQuanLyNhom";
		this.menuQuanLyNhom.Size = new global::System.Drawing.Size(231, 22);
		this.menuQuanLyNhom.Text = "Quản Lý Nhóm";
		this.menuQuanLyNhom.Click += new global::System.EventHandler(this.menuQuanLyNhom_Click);
		this.toolStripSeparator27.Name = "toolStripSeparator27";
		this.toolStripSeparator27.Size = new global::System.Drawing.Size(228, 6);
		this.menuCreateTeam.Name = "menuCreateTeam";
		this.menuCreateTeam.Size = new global::System.Drawing.Size(231, 22);
		this.menuCreateTeam.Text = "Tạo Nhóm";
		this.menuCreateTeam.Click += new global::System.EventHandler(this.menuCreateTeam_Click);
		this.menuJoinTeam.Name = "menuJoinTeam";
		this.menuJoinTeam.Size = new global::System.Drawing.Size(231, 22);
		this.menuJoinTeam.Text = "Vào Nhóm";
		this.muGiaiTan.Name = "muGiaiTan";
		this.muGiaiTan.Size = new global::System.Drawing.Size(231, 22);
		this.muGiaiTan.Text = "Giải Tán";
		this.muGiaiTan.Click += new global::System.EventHandler(this.muGiaiTan_Click);
		this.toolStripMenuItem_46.Name = "vàoĐộiTrốngToolStripMenuItem";
		this.toolStripMenuItem_46.Size = new global::System.Drawing.Size(231, 22);
		this.toolStripMenuItem_46.Text = "Vào Đội Trống";
		this.toolStripMenuItem_46.Click += new global::System.EventHandler(this.toolStripMenuItem_46_Click);
		this.menuThaoTac.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.toolStripMenuItem4, this.toolStripMenuItem_52, this.copyToolStripMenuItem, this.toolStripSeparator2, this.muAnDon, this.muQuayVeDaiLy, this.toolStripSeparator14, this.mLenNgua, this.mXuongNgua, this.toolStripSeparator11,
			this.muXuatPet, this.muThuPet, this.toolStripSeparator6, this.muHaoHuu, this.muTuyetGiao, this.toolStripMenuItem_71, this.toolStripMenuItem_72
		});
		this.menuThaoTac.Name = "menuThaoTac";
		this.menuThaoTac.Size = new global::System.Drawing.Size(170, 22);
		this.menuThaoTac.Text = "Thao Tác";
		this.toolStripMenuItem4.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem17, this.toolStripMenuItem5, this.toolStripMenuItem16, this.toolStripMenuItem25, this.toolStripMenuItem26, this.toolStripMenuItem27, this.menuMuaCuongHoaLo, this.toolStripMenuItem_67, this.toolStripMenuItem_79 });
		this.toolStripMenuItem4.Name = "toolStripMenuItem4";
		this.toolStripMenuItem4.Size = new global::System.Drawing.Size(186, 22);
		this.toolStripMenuItem4.Text = "Shop KNB";
		this.toolStripMenuItem17.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem21, this.toolStripMenuItem22, this.toolStripMenuItem23, this.toolStripMenuItem24 });
		this.toolStripMenuItem17.Name = "toolStripMenuItem17";
		this.toolStripMenuItem17.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem17.Text = "Mua x2";
		this.toolStripMenuItem21.Name = "toolStripMenuItem21";
		this.toolStripMenuItem21.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem21.Text = "1 Viên";
		this.toolStripMenuItem21.Click += new global::System.EventHandler(this.toolStripMenuItem24_Click);
		this.toolStripMenuItem22.Name = "toolStripMenuItem22";
		this.toolStripMenuItem22.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem22.Text = "2 Viên";
		this.toolStripMenuItem22.Click += new global::System.EventHandler(this.toolStripMenuItem24_Click);
		this.toolStripMenuItem23.Name = "toolStripMenuItem23";
		this.toolStripMenuItem23.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem23.Text = "4 Viên";
		this.toolStripMenuItem23.Click += new global::System.EventHandler(this.toolStripMenuItem24_Click);
		this.toolStripMenuItem24.Name = "toolStripMenuItem24";
		this.toolStripMenuItem24.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem24.Text = "10 Viên";
		this.toolStripMenuItem24.Click += new global::System.EventHandler(this.toolStripMenuItem24_Click);
		this.toolStripMenuItem5.Name = "toolStripMenuItem5";
		this.toolStripMenuItem5.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem5.Text = "Mua Tư Bổ Đan";
		this.toolStripMenuItem5.Click += new global::System.EventHandler(this.toolStripMenuItem5_Click);
		this.toolStripMenuItem16.Name = "toolStripMenuItem16";
		this.toolStripMenuItem16.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem16.Text = "Mua Thổ Linh Châu";
		this.toolStripMenuItem16.Click += new global::System.EventHandler(this.toolStripMenuItem16_Click);
		this.toolStripMenuItem25.Name = "toolStripMenuItem25";
		this.toolStripMenuItem25.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem25.Text = "Mua Kim Đan Hồ Lô";
		this.toolStripMenuItem25.Click += new global::System.EventHandler(this.toolStripMenuItem25_Click);
		this.toolStripMenuItem26.Name = "toolStripMenuItem26";
		this.toolStripMenuItem26.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem26.Text = "Mua Ngọc Dịch Tịnh Bình";
		this.toolStripMenuItem26.Click += new global::System.EventHandler(this.toolStripMenuItem26_Click);
		this.toolStripMenuItem27.Name = "toolStripMenuItem27";
		this.toolStripMenuItem27.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem27.Text = "Mua Mã Yên";
		this.toolStripMenuItem27.Click += new global::System.EventHandler(this.toolStripMenuItem27_Click);
		this.menuMuaCuongHoaLo.Name = "menuMuaCuongHoaLo";
		this.menuMuaCuongHoaLo.Size = new global::System.Drawing.Size(253, 22);
		this.menuMuaCuongHoaLo.Text = "Mua Cường Hóa Lộ";
		this.toolStripMenuItem_67.Name = "muaBảoThạchTươngKhảmPhùToolStripMenuItem1";
		this.toolStripMenuItem_67.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_67.Text = "Mua Bảo Thạch Tương Khảm Phù";
		this.toolStripMenuItem_67.Click += new global::System.EventHandler(this.toolStripMenuItem_67_Click);
		this.toolStripMenuItem_79.Name = "muaCànKhônHồToolStripMenuItem";
		this.toolStripMenuItem_79.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_79.Text = "Mua Càn Khôn Hồ";
		this.toolStripMenuItem_79.Click += new global::System.EventHandler(this.toolStripMenuItem_79_Click);
		this.toolStripMenuItem_52.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muaX2ToolStripMenuItem, this.toolStripMenuItem_53, this.toolStripMenuItem_54, this.toolStripMenuItem_55, this.toolStripMenuItem_56, this.toolStripMenuItem_57, this.toolStripMenuItem_58 });
		this.toolStripMenuItem_52.Name = "shopThôngBảoToolStripMenuItem";
		this.toolStripMenuItem_52.Size = new global::System.Drawing.Size(186, 22);
		this.toolStripMenuItem_52.Text = "Shop Thông Bảo";
		this.muaX2ToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_59, this.toolStripMenuItem_60, this.toolStripMenuItem_61, this.toolStripMenuItem_62 });
		this.muaX2ToolStripMenuItem.Name = "muaX2ToolStripMenuItem";
		this.muaX2ToolStripMenuItem.Size = new global::System.Drawing.Size(253, 22);
		this.muaX2ToolStripMenuItem.Text = "Mua x2";
		this.toolStripMenuItem_59.Name = "viênToolStripMenuItem";
		this.toolStripMenuItem_59.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem_59.Text = "1 Viên";
		this.toolStripMenuItem_59.Click += new global::System.EventHandler(this.toolStripMenuItem_62_Click);
		this.toolStripMenuItem_60.Name = "viênToolStripMenuItem1";
		this.toolStripMenuItem_60.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem_60.Text = "2 Viên";
		this.toolStripMenuItem_60.Click += new global::System.EventHandler(this.toolStripMenuItem_62_Click);
		this.toolStripMenuItem_61.Name = "viênToolStripMenuItem2";
		this.toolStripMenuItem_61.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem_61.Text = "4 Viên";
		this.toolStripMenuItem_61.Click += new global::System.EventHandler(this.toolStripMenuItem_62_Click);
		this.toolStripMenuItem_62.Name = "viênToolStripMenuItem3";
		this.toolStripMenuItem_62.Size = new global::System.Drawing.Size(112, 22);
		this.toolStripMenuItem_62.Text = "10 Viên";
		this.toolStripMenuItem_62.Click += new global::System.EventHandler(this.toolStripMenuItem_62_Click);
		this.toolStripMenuItem_53.Name = "muaTưBổĐanToolStripMenuItem";
		this.toolStripMenuItem_53.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_53.Text = "Mua Tư Bổ Đan";
		this.toolStripMenuItem_54.Name = "muaKimĐanHồLôToolStripMenuItem";
		this.toolStripMenuItem_54.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_54.Text = "Mua Kim Đan Hồ Lô";
		this.toolStripMenuItem_54.Click += new global::System.EventHandler(this.toolStripMenuItem_54_Click);
		this.toolStripMenuItem_55.Name = "muaNgọcDịchTịnhBÌnhToolStripMenuItem";
		this.toolStripMenuItem_55.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_55.Text = "Mua Ngọc Dịch Tịnh BÌnh";
		this.toolStripMenuItem_55.Click += new global::System.EventHandler(this.toolStripMenuItem_55_Click);
		this.toolStripMenuItem_56.Name = "muaMãYênToolStripMenuItem";
		this.toolStripMenuItem_56.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_56.Text = "Mua Mã Yên";
		this.toolStripMenuItem_56.Click += new global::System.EventHandler(this.toolStripMenuItem_56_Click);
		this.toolStripMenuItem_57.Name = "muaCườngHóaLộToolStripMenuItem";
		this.toolStripMenuItem_57.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_57.Text = "Mua Cường Hóa Lộ";
		this.toolStripMenuItem_57.Click += new global::System.EventHandler(this.toolStripMenuItem_57_Click);
		this.toolStripMenuItem_58.Name = "muaBảoThạchTươngKhảmPhùToolStripMenuItem";
		this.toolStripMenuItem_58.Size = new global::System.Drawing.Size(253, 22);
		this.toolStripMenuItem_58.Text = "Mua Bảo Thạch Tương Khảm Phù";
		this.toolStripMenuItem_58.Click += new global::System.EventHandler(this.toolStripMenuItem_58_Click);
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(186, 22);
		this.copyToolStripMenuItem.Text = "Copy ID";
		this.copyToolStripMenuItem.Click += new global::System.EventHandler(this.copyToolStripMenuItem_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new global::System.Drawing.Size(183, 6);
		this.muAnDon.Name = "muAnDon";
		this.muAnDon.Size = new global::System.Drawing.Size(186, 22);
		this.muAnDon.Text = "Ẩn Độn";
		this.muAnDon.Click += new global::System.EventHandler(this.muAnDon_Click);
		this.muQuayVeDaiLy.Name = "muQuayVeDaiLy";
		this.muQuayVeDaiLy.Size = new global::System.Drawing.Size(186, 22);
		this.muQuayVeDaiLy.Text = "Quay về đại lý";
		this.muQuayVeDaiLy.Click += new global::System.EventHandler(this.muQuayVeDaiLy_Click);
		this.toolStripSeparator14.Name = "toolStripSeparator14";
		this.toolStripSeparator14.Size = new global::System.Drawing.Size(183, 6);
		this.mLenNgua.Name = "mLenNgua";
		this.mLenNgua.Size = new global::System.Drawing.Size(186, 22);
		this.mLenNgua.Text = "Lên Ngựa";
		this.mLenNgua.Click += new global::System.EventHandler(this.mLenNgua_Click);
		this.mXuongNgua.Name = "mXuongNgua";
		this.mXuongNgua.Size = new global::System.Drawing.Size(186, 22);
		this.mXuongNgua.Text = "Xuống Ngựa";
		this.mXuongNgua.Click += new global::System.EventHandler(this.mXuongNgua_Click);
		this.toolStripSeparator11.Name = "toolStripSeparator11";
		this.toolStripSeparator11.Size = new global::System.Drawing.Size(183, 6);
		this.muXuatPet.Name = "muXuatPet";
		this.muXuatPet.Size = new global::System.Drawing.Size(186, 22);
		this.muXuatPet.Text = "Xuất Pet";
		this.muXuatPet.Click += new global::System.EventHandler(this.muXuatPet_Click);
		this.muThuPet.Name = "muThuPet";
		this.muThuPet.Size = new global::System.Drawing.Size(186, 22);
		this.muThuPet.Text = "Thu Pet";
		this.muThuPet.Click += new global::System.EventHandler(this.muThuPet_Click);
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new global::System.Drawing.Size(183, 6);
		this.muHaoHuu.Name = "muHaoHuu";
		this.muHaoHuu.Size = new global::System.Drawing.Size(186, 22);
		this.muHaoHuu.Text = "Hảo Hữu Nhau";
		this.muHaoHuu.Click += new global::System.EventHandler(this.muHaoHuu_Click);
		this.muTuyetGiao.Name = "muTuyetGiao";
		this.muTuyetGiao.Size = new global::System.Drawing.Size(186, 22);
		this.muTuyetGiao.Text = "Tuyệt Giao";
		this.muTuyetGiao.Click += new global::System.EventHandler(this.muTuyetGiao_Click);
		this.toolStripMenuItem_71.Name = "hủyNgânPhiếuToolStripMenuItem";
		this.toolStripMenuItem_71.Size = new global::System.Drawing.Size(186, 22);
		this.toolStripMenuItem_71.Text = "Hủy Ngân Phiếu";
		this.toolStripMenuItem_71.Click += new global::System.EventHandler(this.toolStripMenuItem_71_Click);
		this.toolStripMenuItem_72.Name = "chấpNhậnTheoSauToolStripMenuItem";
		this.toolStripMenuItem_72.Size = new global::System.Drawing.Size(186, 22);
		this.toolStripMenuItem_72.Text = "Chấp Nhận Theo Sau";
		this.toolStripMenuItem_72.Click += new global::System.EventHandler(this.toolStripMenuItem_72_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new global::System.Drawing.Size(167, 6);
		this.menuSelectServer.Name = "menuSelectServer";
		this.menuSelectServer.Size = new global::System.Drawing.Size(170, 22);
		this.menuSelectServer.Text = "Select Server";
		this.menuSelectServer.Click += new global::System.EventHandler(this.menuSelectServer_Click);
		this.menuExitGame.Name = "menuExitGame";
		this.menuExitGame.Size = new global::System.Drawing.Size(170, 22);
		this.menuExitGame.Text = "Quit [ESC | Delete]";
		this.menuExitGame.Click += new global::System.EventHandler(this.menuExitGame_Click);
		this.quitNRelogToolStripMenuItem.Name = "quitNRelogToolStripMenuItem";
		this.quitNRelogToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.quitNRelogToolStripMenuItem.Text = "Quit + Relog";
		this.quitNRelogToolStripMenuItem.Click += new global::System.EventHandler(this.quitNRelogToolStripMenuItem_Click);
		this.setDoneToolStripMenuItem.Name = "setDoneToolStripMenuItem";
		this.setDoneToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
		this.setDoneToolStripMenuItem.Text = "Set Done";
		this.setDoneToolStripMenuItem.Click += new global::System.EventHandler(this.setDoneToolStripMenuItem_Click);
		this.toolStripSeparator34.Name = "toolStripSeparator34";
		this.toolStripSeparator34.Size = new global::System.Drawing.Size(167, 6);
		this.muNhapCode.Name = "muNhapCode";
		this.muNhapCode.Size = new global::System.Drawing.Size(170, 22);
		this.muNhapCode.Text = "Gift Code";
		this.muNhapCode.Click += new global::System.EventHandler(this.muNhapCode_Click);
		this.menuDebug.Name = "menuDebug";
		this.menuDebug.Size = new global::System.Drawing.Size(170, 22);
		this.menuDebug.Text = "Debug";
		this.menuDebug.Visible = false;
		this.menuDebug.Click += new global::System.EventHandler(this.menuDebug_Click);
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 600000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.menuMain.BackColor = global::System.Drawing.Color.White;
		this.menuMain.ImageScalingSize = new global::System.Drawing.Size(20, 20);
		this.menuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muPlayer, this.muIntime, this.muDaily, this.muFuBen, this.muAll, this.muNier, this.goToolStripMenuItem });
		this.menuMain.Location = new global::System.Drawing.Point(0, 0);
		this.menuMain.Name = "menuMain";
		this.menuMain.Padding = new global::System.Windows.Forms.Padding(3, 2, 0, 2);
		this.menuMain.Size = new global::System.Drawing.Size(434, 24);
		this.menuMain.TabIndex = 13;
		this.menuMain.Text = "MainMenu";
		this.muPlayer.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muThuongDung, this.muNhanLai, this.muGom, this.toolStripSeparator29, this.muTrangBi, this.muThuongKho, this.muThuongHoi, this.toolStripSeparator17, this.muDi, this.muDiSua,
			this.muDiDoi, this.muDiNhan, this.muPkMode
		});
		this.muPlayer.Name = "muPlayer";
		this.muPlayer.Size = new global::System.Drawing.Size(51, 20);
		this.muPlayer.Text = "Player";
		this.muPlayer.DropDownOpened += new global::System.EventHandler(this.muFuBen_DropDownOpened);
		this.muThuongDung.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muDiBanRac, this.muTriLieu, this.muTriLieuBanRacCatDo, this.toolStripSeparator7, this.muNhanx2, this.muDongx2, this.muPhanGiaiTrangBijPet, this.toolStripMenuItem_20, this.toolStripSeparator37, this.menuMoSap,
			this.muLenGia, this.menuChoGiao, this.menuChayThuongNhan, this.toolStripMenuItem_39, this.toolStripMenuItem_40
		});
		this.muThuongDung.Name = "muThuongDung";
		this.muThuongDung.Size = new global::System.Drawing.Size(148, 22);
		this.muThuongDung.Text = "Thường Dùng";
		this.muDiBanRac.Name = "muDiBanRac";
		this.muDiBanRac.Size = new global::System.Drawing.Size(218, 22);
		this.muDiBanRac.Text = "Đi Bán Rác";
		this.muTriLieu.Name = "muTriLieu";
		this.muTriLieu.Size = new global::System.Drawing.Size(218, 22);
		this.muTriLieu.Text = "Trị Liệu";
		this.muTriLieuBanRacCatDo.Name = "muTriLieuBanRacCatDo";
		this.muTriLieuBanRacCatDo.Size = new global::System.Drawing.Size(218, 22);
		this.muTriLieuBanRacCatDo.Text = "Bán Rác + Trị Liệu + Cất Đồ";
		this.toolStripSeparator7.Name = "toolStripSeparator7";
		this.toolStripSeparator7.Size = new global::System.Drawing.Size(215, 6);
		this.muNhanx2.Name = "muNhanx2";
		this.muNhanx2.Size = new global::System.Drawing.Size(218, 22);
		this.muNhanx2.Text = "Nhận x2";
		this.muDongx2.Name = "muDongx2";
		this.muDongx2.Size = new global::System.Drawing.Size(218, 22);
		this.muDongx2.Text = "Đông x2";
		this.muPhanGiaiTrangBijPet.Name = "muPhanGiaiTrangBijPet";
		this.muPhanGiaiTrangBijPet.Size = new global::System.Drawing.Size(218, 22);
		this.muPhanGiaiTrangBijPet.Text = "Phân Giải Trang Bị Pet";
		this.toolStripMenuItem_20.Name = "tăngSaoTrangBịPetToolStripMenuItem";
		this.toolStripMenuItem_20.Size = new global::System.Drawing.Size(218, 22);
		this.toolStripMenuItem_20.Text = "Tăng Sao Trang Bị Pet";
		this.toolStripSeparator37.Name = "toolStripSeparator37";
		this.toolStripSeparator37.Size = new global::System.Drawing.Size(215, 6);
		this.menuMoSap.Name = "menuMoSap";
		this.menuMoSap.Size = new global::System.Drawing.Size(218, 22);
		this.menuMoSap.Text = "Mở Sạp";
		this.muLenGia.Name = "muLenGia";
		this.muLenGia.Size = new global::System.Drawing.Size(218, 22);
		this.muLenGia.Text = "Lên Giá Vật Phẩm";
		this.muLenGia.Click += new global::System.EventHandler(this.muLenGia_Click);
		this.menuChoGiao.Name = "menuChoGiao";
		this.menuChoGiao.Size = new global::System.Drawing.Size(218, 22);
		this.menuChoGiao.Text = "Chờ Giao Tàng Bảo Đồ";
		this.menuChayThuongNhan.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuStopTrader, this.menuQuayVe, this.menuDiToi });
		this.menuChayThuongNhan.Name = "menuChayThuongNhan";
		this.menuChayThuongNhan.Size = new global::System.Drawing.Size(218, 22);
		this.menuChayThuongNhan.Text = "Thương Nhân";
		this.menuChayThuongNhan.Click += new global::System.EventHandler(this.menuChayThuongNhan_Click);
		this.menuStopTrader.Name = "menuStopTrader";
		this.menuStopTrader.Size = new global::System.Drawing.Size(182, 22);
		this.menuStopTrader.Text = "Dừng [Ctrl + Down ]";
		this.menuStopTrader.Click += new global::System.EventHandler(this.menuStopTrader_Click);
		this.menuQuayVe.Name = "menuQuayVe";
		this.menuQuayVe.Size = new global::System.Drawing.Size(182, 22);
		this.menuQuayVe.Text = "Quay Về [Ctrl + Left]";
		this.menuQuayVe.Click += new global::System.EventHandler(this.menuQuayVe_Click);
		this.menuDiToi.Name = "menuDiToi";
		this.menuDiToi.Size = new global::System.Drawing.Size(182, 22);
		this.menuDiToi.Text = "Đi Tới [Ctrl + Right]";
		this.menuDiToi.Click += new global::System.EventHandler(this.menuDiToi_Click);
		this.toolStripMenuItem_39.Name = "đổiVàngSangGiaoTửToolStripMenuItem";
		this.toolStripMenuItem_39.Size = new global::System.Drawing.Size(218, 22);
		this.toolStripMenuItem_39.Text = "Đổi Vàng Sang Giao Tử";
		this.toolStripMenuItem_39.Click += new global::System.EventHandler(this.toolStripMenuItem_39_Click);
		this.toolStripMenuItem_40.Name = "ngânPhiếuĐổiTiềnMặtToolStripMenuItem";
		this.toolStripMenuItem_40.Size = new global::System.Drawing.Size(218, 22);
		this.toolStripMenuItem_40.Text = "Ngân Phiếu Đổi Tiền Mặt";
		this.toolStripMenuItem_40.Click += new global::System.EventHandler(this.toolStripMenuItem_40_Click);
		this.muNhanLai.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muNhanLaiKinhNghiem, this.muNhanLaiNoiTuc, this.muNhanLaiThieuThatSon, this.muNhanLaiYenTuO, this.muNhanLaiTuTuyetTrang, this.muNhanLaiPhucDia, this.muNhanLaiVuongLang, this.muNhanLaiTamThan, this.muNhanLaiPhieuMieuPhong });
		this.muNhanLai.Name = "muNhanLai";
		this.muNhanLai.Size = new global::System.Drawing.Size(148, 22);
		this.muNhanLai.Text = "Nhận Lại";
		this.muNhanLaiKinhNghiem.Name = "muNhanLaiKinhNghiem";
		this.muNhanLaiKinhNghiem.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiKinhNghiem.Text = "Kinh Nghiệm";
		this.muNhanLaiNoiTuc.Name = "muNhanLaiNoiTuc";
		this.muNhanLaiNoiTuc.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiNoiTuc.Text = "Nội Tức";
		this.muNhanLaiThieuThatSon.Name = "muNhanLaiThieuThatSon";
		this.muNhanLaiThieuThatSon.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiThieuThatSon.Text = "Thiếu Thất Sơn";
		this.muNhanLaiYenTuO.Name = "muNhanLaiYenTuO";
		this.muNhanLaiYenTuO.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiYenTuO.Text = "Yến Tử Ô";
		this.muNhanLaiTuTuyetTrang.Name = "muNhanLaiTuTuyetTrang";
		this.muNhanLaiTuTuyetTrang.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiTuTuyetTrang.Text = "Tứ Tuyệt Trang";
		this.muNhanLaiPhucDia.Name = "muNhanLaiPhucDia";
		this.muNhanLaiPhucDia.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiPhucDia.Text = "Phúc Địa";
		this.muNhanLaiVuongLang.Name = "muNhanLaiVuongLang";
		this.muNhanLaiVuongLang.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiVuongLang.Text = "Vương Lăng";
		this.muNhanLaiTamThan.Name = "muNhanLaiTamThan";
		this.muNhanLaiTamThan.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiTamThan.Text = "Tam Thần";
		this.muNhanLaiPhieuMieuPhong.Name = "muNhanLaiPhieuMieuPhong";
		this.muNhanLaiPhieuMieuPhong.Size = new global::System.Drawing.Size(172, 22);
		this.muNhanLaiPhieuMieuPhong.Text = "Phiêu Miễu Phong";
		this.muGom.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muDuaKNBCho, this.muDuaDoChoTa, this.muDuaTangBaoDo, this.toolStripMenuItem_49, this.toolStripMenuItem_51 });
		this.muGom.Name = "muGom";
		this.muGom.Size = new global::System.Drawing.Size(148, 22);
		this.muGom.Text = "Gom";
		this.muGom.DropDownOpening += new global::System.EventHandler(this.muGom_DropDownOpening);
		this.muDuaKNBCho.Name = "muDuaKNBCho";
		this.muDuaKNBCho.Size = new global::System.Drawing.Size(190, 22);
		this.muDuaKNBCho.Text = "Đưa KNB Cho";
		this.muDuaDoChoTa.Name = "muDuaDoChoTa";
		this.muDuaDoChoTa.Size = new global::System.Drawing.Size(190, 22);
		this.muDuaDoChoTa.Text = "Đưa Đồ + Vàng Cho";
		this.muDuaTangBaoDo.Name = "muDuaTangBaoDo";
		this.muDuaTangBaoDo.Size = new global::System.Drawing.Size(190, 22);
		this.muDuaTangBaoDo.Text = "Đưa Tàng Bảo Đồ Cho";
		this.toolStripMenuItem_49.Name = "chiaĐồTừToolStripMenuItem";
		this.toolStripMenuItem_49.Size = new global::System.Drawing.Size(190, 22);
		this.toolStripMenuItem_49.Text = "Chia Đồ Từ";
		this.toolStripMenuItem_51.Name = "tặngBáchHoaToolStripMenuItem";
		this.toolStripMenuItem_51.Size = new global::System.Drawing.Size(190, 22);
		this.toolStripMenuItem_51.Text = "Tặng Bách Hoa";
		this.toolStripSeparator29.Name = "toolStripSeparator29";
		this.toolStripSeparator29.Size = new global::System.Drawing.Size(145, 6);
		this.muTrangBi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuDucLo, this.menuLenhBai, this.toolStripMenuItem28, this.toolStripMenuItem_31, this.toolStripMenuItem_50, this.toolStripSeparator41, this.muCuongHoaDo, this.muCheThanKhi, this.muNgungTuBaoGiam, this.muGiaiPhongChanNguyen,
			this.muTangCapTruongThanhLongVan, this.toolStripSeparator16, this.menuThaoTrangBi, this.menuDeoTrangBi, this.menuThaoDeo, this.toolStripSeparator12, this.menuGiamDinh, this.toolStripMenuItem_34
		});
		this.muTrangBi.Name = "muTrangBi";
		this.muTrangBi.Size = new global::System.Drawing.Size(148, 22);
		this.muTrangBi.Text = "Trang Bị";
		this.menuDucLo.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.socket1, this.socket2, this.socket3 });
		this.menuDucLo.Name = "menuDucLo";
		this.menuDucLo.Size = new global::System.Drawing.Size(230, 22);
		this.menuDucLo.Text = "Đục Lỗ";
		this.socket1.Name = "socket1";
		this.socket1.Size = new global::System.Drawing.Size(96, 22);
		this.socket1.Text = "1 Lỗ";
		this.socket1.Click += new global::System.EventHandler(this.socket3_Click);
		this.socket2.Name = "socket2";
		this.socket2.Size = new global::System.Drawing.Size(96, 22);
		this.socket2.Text = "2 Lỗ";
		this.socket2.Click += new global::System.EventHandler(this.socket3_Click);
		this.socket3.Name = "socket3";
		this.socket3.Size = new global::System.Drawing.Size(96, 22);
		this.socket3.Text = "3 Lỗ";
		this.socket3.Click += new global::System.EventHandler(this.socket3_Click);
		this.menuLenhBai.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuNangBaoChau, this.menuTangSaoLenhBai });
		this.menuLenhBai.Name = "menuLenhBai";
		this.menuLenhBai.Size = new global::System.Drawing.Size(230, 22);
		this.menuLenhBai.Text = "Lệnh Bài";
		this.menuNangBaoChau.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuRed, this.menuGreen, this.menuBlue, this.menuYellow });
		this.menuNangBaoChau.Name = "menuNangBaoChau";
		this.menuNangBaoChau.Size = new global::System.Drawing.Size(157, 22);
		this.menuNangBaoChau.Text = "Nâng Bảo Châu";
		this.menuRed.Name = "menuRed";
		this.menuRed.Size = new global::System.Drawing.Size(100, 22);
		this.menuRed.Tag = "1";
		this.menuRed.Text = "Đỏ";
		this.menuRed.Click += new global::System.EventHandler(this.menuYellow_Click);
		this.menuGreen.Name = "menuGreen";
		this.menuGreen.Size = new global::System.Drawing.Size(100, 22);
		this.menuGreen.Tag = "2";
		this.menuGreen.Text = "Lục";
		this.menuGreen.Click += new global::System.EventHandler(this.menuYellow_Click);
		this.menuBlue.Name = "menuBlue";
		this.menuBlue.Size = new global::System.Drawing.Size(100, 22);
		this.menuBlue.Tag = "3";
		this.menuBlue.Text = "Lam";
		this.menuBlue.Click += new global::System.EventHandler(this.menuYellow_Click);
		this.menuYellow.Name = "menuYellow";
		this.menuYellow.Size = new global::System.Drawing.Size(100, 22);
		this.menuYellow.Tag = "4";
		this.menuYellow.Text = "Vàng";
		this.menuYellow.Click += new global::System.EventHandler(this.menuYellow_Click);
		this.menuTangSaoLenhBai.Name = "menuTangSaoLenhBai";
		this.menuTangSaoLenhBai.Size = new global::System.Drawing.Size(157, 22);
		this.menuTangSaoLenhBai.Text = "Tăng Sao";
		this.toolStripMenuItem28.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuCold, this.menuFire, this.menuLight, this.menuPoison });
		this.toolStripMenuItem28.Name = "toolStripMenuItem28";
		this.toolStripMenuItem28.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem28.Text = "Mở Tàn Ấn - Bí Kĩ";
		this.menuCold.Name = "menuCold";
		this.menuCold.Size = new global::System.Drawing.Size(109, 22);
		this.menuCold.Tag = "1";
		this.menuCold.Text = "Băng";
		this.menuCold.Click += new global::System.EventHandler(this.menuPoison_Click);
		this.menuFire.Name = "menuFire";
		this.menuFire.Size = new global::System.Drawing.Size(109, 22);
		this.menuFire.Tag = "2";
		this.menuFire.Text = "Hỏa";
		this.menuFire.Click += new global::System.EventHandler(this.menuPoison_Click);
		this.menuLight.Name = "menuLight";
		this.menuLight.Size = new global::System.Drawing.Size(109, 22);
		this.menuLight.Tag = "3";
		this.menuLight.Text = "Huyền";
		this.menuLight.Click += new global::System.EventHandler(this.menuPoison_Click);
		this.menuPoison.Name = "menuPoison";
		this.menuPoison.Size = new global::System.Drawing.Size(109, 22);
		this.menuPoison.Tag = "4";
		this.menuPoison.Text = "Độc";
		this.menuPoison.Click += new global::System.EventHandler(this.menuPoison_Click);
		this.toolStripMenuItem_31.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muToiLuyenThe, this.muToiLuyenBang, this.muToiLuyenHuyen, this.muToiLuyenHoa, this.muToiLuyenDoc, this.muTrungLau });
		this.toolStripMenuItem_31.Name = "tôiLuyệnTăngTinhThôngToolStripMenuItem1";
		this.toolStripMenuItem_31.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem_31.Text = "Tinh Thông + Tôi Luyện";
		this.muToiLuyenThe.Name = "muToiLuyenThe";
		this.muToiLuyenThe.Size = new global::System.Drawing.Size(127, 22);
		this.muToiLuyenThe.Text = "Thể";
		this.muToiLuyenBang.Name = "muToiLuyenBang";
		this.muToiLuyenBang.Size = new global::System.Drawing.Size(127, 22);
		this.muToiLuyenBang.Text = "Băng";
		this.muToiLuyenHuyen.Name = "muToiLuyenHuyen";
		this.muToiLuyenHuyen.Size = new global::System.Drawing.Size(127, 22);
		this.muToiLuyenHuyen.Text = "Huyền";
		this.muToiLuyenHoa.Name = "muToiLuyenHoa";
		this.muToiLuyenHoa.Size = new global::System.Drawing.Size(127, 22);
		this.muToiLuyenHoa.Text = "Hỏa";
		this.muToiLuyenDoc.Name = "muToiLuyenDoc";
		this.muToiLuyenDoc.Size = new global::System.Drawing.Size(127, 22);
		this.muToiLuyenDoc.Text = "Độc";
		this.muTrungLau.Name = "muTrungLau";
		this.muTrungLau.Size = new global::System.Drawing.Size(127, 22);
		this.muTrungLau.Text = "Trùng Lâu";
		this.muTrungLau.Click += new global::System.EventHandler(this.muTrungLau_Click);
		this.toolStripMenuItem_50.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuLen8Sao, this.toolStripMenuItem_63, this.toolStripMenuItem_68 });
		this.toolStripMenuItem_50.Name = "thầnKhíToolStripMenuItem";
		this.toolStripMenuItem_50.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem_50.Text = "Thần Khí";
		this.menuLen8Sao.Name = "menuLen8Sao";
		this.menuLen8Sao.Size = new global::System.Drawing.Size(150, 22);
		this.menuLen8Sao.Text = "Lên 8 Sao";
		this.toolStripMenuItem_63.Name = "cườngHóa9ToolStripMenuItem";
		this.toolStripMenuItem_63.Size = new global::System.Drawing.Size(150, 22);
		this.toolStripMenuItem_63.Text = "Cường Hóa 9";
		this.toolStripMenuItem_68.Name = "cườngHóa99ToolStripMenuItem";
		this.toolStripMenuItem_68.Size = new global::System.Drawing.Size(150, 22);
		this.toolStripMenuItem_68.Text = "Cường Hóa 99";
		this.toolStripSeparator41.Name = "toolStripSeparator41";
		this.toolStripSeparator41.Size = new global::System.Drawing.Size(227, 6);
		this.muCuongHoaDo.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_64, this.toolStripMenuItem_65, this.toolStripMenuItem_66 });
		this.muCuongHoaDo.Name = "muCuongHoaDo";
		this.muCuongHoaDo.Size = new global::System.Drawing.Size(230, 22);
		this.muCuongHoaDo.Text = "Cường Hóa";
		this.toolStripMenuItem_64.Name = "trongTayNảiLên7ToolStripMenuItem";
		this.toolStripMenuItem_64.Size = new global::System.Drawing.Size(178, 22);
		this.toolStripMenuItem_64.Text = "Trong Tay Nải Lên 7";
		this.toolStripMenuItem_65.Name = "hàoHiệpẤnLên9ToolStripMenuItem";
		this.toolStripMenuItem_65.Size = new global::System.Drawing.Size(178, 22);
		this.toolStripMenuItem_65.Text = "Hào Hiệp Ấn Lên 9";
		this.toolStripMenuItem_66.Name = "ámKhíLên9ToolStripMenuItem";
		this.toolStripMenuItem_66.Size = new global::System.Drawing.Size(178, 22);
		this.toolStripMenuItem_66.Text = "Ám Khí Lên 9";
		this.muCheThanKhi.Name = "muCheThanKhi";
		this.muCheThanKhi.Size = new global::System.Drawing.Size(230, 22);
		this.muCheThanKhi.Text = "Chế Thần Khí";
		this.muNgungTuBaoGiam.Name = "muNgungTuBaoGiam";
		this.muNgungTuBaoGiam.Size = new global::System.Drawing.Size(230, 22);
		this.muNgungTuBaoGiam.Text = "Ngưng Tụ Bảo Giám";
		this.muGiaiPhongChanNguyen.Name = "muGiaiPhongChanNguyen";
		this.muGiaiPhongChanNguyen.Size = new global::System.Drawing.Size(230, 22);
		this.muGiaiPhongChanNguyen.Text = "Giải Phong Chân Nguyên";
		this.muTangCapTruongThanhLongVan.Name = "muTangCapTruongThanhLongVan";
		this.muTangCapTruongThanhLongVan.Size = new global::System.Drawing.Size(230, 22);
		this.muTangCapTruongThanhLongVan.Text = "Tăng Trưởng Thành Long Văn";
		this.toolStripSeparator16.Name = "toolStripSeparator16";
		this.toolStripSeparator16.Size = new global::System.Drawing.Size(227, 6);
		this.menuThaoTrangBi.Name = "menuThaoTrangBi";
		this.menuThaoTrangBi.Size = new global::System.Drawing.Size(230, 22);
		this.menuThaoTrangBi.Text = "Tháo Trang Bị";
		this.menuThaoTrangBi.Click += new global::System.EventHandler(this.menuThaoTrangBi_Click);
		this.menuDeoTrangBi.Name = "menuDeoTrangBi";
		this.menuDeoTrangBi.Size = new global::System.Drawing.Size(230, 22);
		this.menuDeoTrangBi.Text = "Đeo Trang Bị";
		this.menuDeoTrangBi.Click += new global::System.EventHandler(this.menuDeoTrangBi_Click);
		this.menuThaoDeo.Name = "menuThaoDeo";
		this.menuThaoDeo.Size = new global::System.Drawing.Size(230, 22);
		this.menuThaoDeo.Text = "Tháo + Đeo";
		this.menuThaoDeo.Click += new global::System.EventHandler(this.menuThaoDeo_Click);
		this.toolStripSeparator12.Name = "toolStripSeparator12";
		this.toolStripSeparator12.Size = new global::System.Drawing.Size(227, 6);
		this.menuGiamDinh.Name = "menuGiamDinh";
		this.menuGiamDinh.Size = new global::System.Drawing.Size(230, 22);
		this.menuGiamDinh.Text = "Giám Định [Ctrl + /]";
		this.menuGiamDinh.Click += new global::System.EventHandler(this.menuGiamDinh_Click);
		this.toolStripMenuItem_34.Name = "yêuCầuHủyVậtPhẩmQuýToolStripMenuItem";
		this.toolStripMenuItem_34.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem_34.Text = "Yêu Cầu Hủy Vật Phẩm Quý";
		this.toolStripMenuItem_34.Click += new global::System.EventHandler(this.toolStripMenuItem_34_Click);
		this.muThuongKho.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuOpenBank, this.muCatDo, this.menuLayDoKhongCoDinh, this.muLayDo, this.muLayDoLayVang });
		this.muThuongKho.Name = "muThuongKho";
		this.muThuongKho.Size = new global::System.Drawing.Size(148, 22);
		this.muThuongKho.Text = "Thương Khố";
		this.menuOpenBank.Name = "menuOpenBank";
		this.menuOpenBank.Size = new global::System.Drawing.Size(194, 22);
		this.menuOpenBank.Text = "Mở Từ Xa [Ctrl + B]";
		this.menuOpenBank.Click += new global::System.EventHandler(this.menuOpenBank_Click);
		this.muCatDo.Name = "muCatDo";
		this.muCatDo.Size = new global::System.Drawing.Size(194, 22);
		this.muCatDo.Text = "Cất Đồ";
		this.menuLayDoKhongCoDinh.Name = "menuLayDoKhongCoDinh";
		this.menuLayDoKhongCoDinh.Size = new global::System.Drawing.Size(194, 22);
		this.menuLayDoKhongCoDinh.Text = "Lấy Đồ Không Cố Định";
		this.muLayDo.Name = "muLayDo";
		this.muLayDo.Size = new global::System.Drawing.Size(194, 22);
		this.muLayDo.Text = "Lấy Đồ";
		this.muLayDo.Click += new global::System.EventHandler(this.muLayDo_Click);
		this.muLayDoLayVang.Name = "muLayDoLayVang";
		this.muLayDoLayVang.Size = new global::System.Drawing.Size(194, 22);
		this.muLayDoLayVang.Text = "Lấy Vàng";
		this.muThuongHoi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuXuongGia, this.menuLenGia, this.menuLayDo });
		this.muThuongHoi.Name = "muThuongHoi";
		this.muThuongHoi.Size = new global::System.Drawing.Size(148, 22);
		this.muThuongHoi.Text = "Thương Hội";
		this.menuXuongGia.Name = "menuXuongGia";
		this.menuXuongGia.Size = new global::System.Drawing.Size(129, 22);
		this.menuXuongGia.Text = "Xuống Giá";
		this.menuXuongGia.Click += new global::System.EventHandler(this.menuXuongGia_Click);
		this.menuLenGia.Name = "menuLenGia";
		this.menuLenGia.Size = new global::System.Drawing.Size(129, 22);
		this.menuLenGia.Text = "Lên Giá";
		this.menuLenGia.Click += new global::System.EventHandler(this.menuLenGia_Click);
		this.menuLayDo.Name = "menuLayDo";
		this.menuLayDo.Size = new global::System.Drawing.Size(129, 22);
		this.menuLayDo.Text = "Lấy Đồ";
		this.menuLayDo.Click += new global::System.EventHandler(this.menuLayDo_Click);
		this.toolStripSeparator17.Name = "toolStripSeparator17";
		this.toolStripSeparator17.Size = new global::System.Drawing.Size(145, 6);
		this.muDi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuSkillStudy, this.menuTuLuyen, this.toolStripSeparator4, this.muMoShop, this.toolStripMenuItem_30, this.muDiMuaNgua, this.muNopTuViHuyTinh, this.muThanhLyNhiemVu, this.muGiaoNguHanhPhapThiep, this.toolStripMenuItem32,
			this.menuHocCheDo, this.muThinhGiaoBiKy, this.muMua100KimSangDuoc, this.mu200ReTranh
		});
		this.muDi.Name = "muDi";
		this.muDi.Size = new global::System.Drawing.Size(148, 22);
		this.muDi.Text = "Đi";
		this.menuSkillStudy.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_32, this.lrn30, this.len40, this.len45, this.len50, this.len60, this.len75, this.len80, this.len90, this.len100 });
		this.menuSkillStudy.Name = "menuSkillStudy";
		this.menuSkillStudy.Size = new global::System.Drawing.Size(265, 22);
		this.menuSkillStudy.Text = "Nâng Tâm Pháp";
		this.toolStripMenuItem_32.Name = "buffMáuToolStripMenuItem";
		this.toolStripMenuItem_32.Size = new global::System.Drawing.Size(123, 22);
		this.toolStripMenuItem_32.Text = "Buff Máu";
		this.lrn30.Name = "lrn30";
		this.lrn30.Size = new global::System.Drawing.Size(123, 22);
		this.lrn30.Text = "Lên 30";
		this.lrn30.Click += new global::System.EventHandler(this.len100_Click);
		this.len40.Name = "len40";
		this.len40.Size = new global::System.Drawing.Size(123, 22);
		this.len40.Text = "Lên 40";
		this.len40.Click += new global::System.EventHandler(this.len100_Click);
		this.len45.Name = "len45";
		this.len45.Size = new global::System.Drawing.Size(123, 22);
		this.len45.Text = "Lên 45";
		this.len45.Click += new global::System.EventHandler(this.len100_Click);
		this.len50.Name = "len50";
		this.len50.Size = new global::System.Drawing.Size(123, 22);
		this.len50.Text = "Lên 50";
		this.len50.Click += new global::System.EventHandler(this.len100_Click);
		this.len60.Name = "len60";
		this.len60.Size = new global::System.Drawing.Size(123, 22);
		this.len60.Text = "Lên 60";
		this.len60.Click += new global::System.EventHandler(this.len100_Click);
		this.len75.Name = "len75";
		this.len75.Size = new global::System.Drawing.Size(123, 22);
		this.len75.Text = "Lên 75";
		this.len75.Click += new global::System.EventHandler(this.len100_Click);
		this.len80.Name = "len80";
		this.len80.Size = new global::System.Drawing.Size(123, 22);
		this.len80.Text = "Lên 80";
		this.len80.Click += new global::System.EventHandler(this.len100_Click);
		this.len90.Name = "len90";
		this.len90.Size = new global::System.Drawing.Size(123, 22);
		this.len90.Text = "Lên 90";
		this.len90.Click += new global::System.EventHandler(this.len100_Click);
		this.len100.Name = "len100";
		this.len100.Size = new global::System.Drawing.Size(123, 22);
		this.len100.Text = "Lên 100";
		this.len100.Click += new global::System.EventHandler(this.len100_Click);
		this.menuTuLuyen.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muTuLuyenTheLuc, this.muTuLuyenNoiLuc, this.muTuLuyenThanPhap, this.muTuLuyenCuongLuc, this.muTuLuyenTheNoiThan });
		this.menuTuLuyen.Name = "menuTuLuyen";
		this.menuTuLuyen.Size = new global::System.Drawing.Size(265, 22);
		this.menuTuLuyen.Text = "Đi Tu Luyện";
		this.muTuLuyenTheLuc.Name = "muTuLuyenTheLuc";
		this.muTuLuyenTheLuc.Size = new global::System.Drawing.Size(168, 22);
		this.muTuLuyenTheLuc.Text = "Thể Lực";
		this.muTuLuyenNoiLuc.Name = "muTuLuyenNoiLuc";
		this.muTuLuyenNoiLuc.Size = new global::System.Drawing.Size(168, 22);
		this.muTuLuyenNoiLuc.Text = "Nội Lực";
		this.muTuLuyenThanPhap.Name = "muTuLuyenThanPhap";
		this.muTuLuyenThanPhap.Size = new global::System.Drawing.Size(168, 22);
		this.muTuLuyenThanPhap.Text = "Thân Pháp";
		this.muTuLuyenCuongLuc.Name = "muTuLuyenCuongLuc";
		this.muTuLuyenCuongLuc.Size = new global::System.Drawing.Size(168, 22);
		this.muTuLuyenCuongLuc.Text = "Cường Lực";
		this.muTuLuyenTheNoiThan.Name = "muTuLuyenTheNoiThan";
		this.muTuLuyenTheNoiThan.Size = new global::System.Drawing.Size(168, 22);
		this.muTuLuyenTheNoiThan.Text = "Thể + Nội + Thân";
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new global::System.Drawing.Size(262, 6);
		this.muMoShop.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muMoShopTrungDo, this.muMoShopHungBa, this.muMoShopBachBaoCac, this.muMoShopVanCam, this.muMoTiemThuoc, this.toolStripMenuItem_12, this.menuMoHoaNgocTap, this.toolStripMenuItem_29 });
		this.muMoShop.Name = "muMoShop";
		this.muMoShop.Size = new global::System.Drawing.Size(265, 22);
		this.muMoShop.Text = "Đi Mở Shop";
		this.muMoShopTrungDo.Name = "muMoShopTrungDo";
		this.muMoShopTrungDo.Size = new global::System.Drawing.Size(177, 22);
		this.muMoShopTrungDo.Text = "Shop Trung Đô";
		this.muMoShopHungBa.Name = "muMoShopHungBa";
		this.muMoShopHungBa.Size = new global::System.Drawing.Size(177, 22);
		this.muMoShopHungBa.Text = "Shop Chiến Công";
		this.muMoShopBachBaoCac.Name = "muMoShopBachBaoCac";
		this.muMoShopBachBaoCac.Size = new global::System.Drawing.Size(177, 22);
		this.muMoShopBachBaoCac.Text = "Bách Bảo Các";
		this.muMoShopVanCam.Name = "muMoShopVanCam";
		this.muMoShopVanCam.Size = new global::System.Drawing.Size(177, 22);
		this.muMoShopVanCam.Text = "Shop Vân Cẩm";
		this.muMoTiemThuoc.Name = "muMoTiemThuoc";
		this.muMoTiemThuoc.Size = new global::System.Drawing.Size(177, 22);
		this.muMoTiemThuoc.Text = "Tiệm Thuốc";
		this.toolStripMenuItem_12.Name = "shopQuanSơnHảiToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new global::System.Drawing.Size(177, 22);
		this.toolStripMenuItem_12.Text = "Shop Quan Sơn Hải";
		this.toolStripMenuItem_12.Click += new global::System.EventHandler(this.toolStripMenuItem_12_Click);
		this.menuMoHoaNgocTap.Name = "menuMoHoaNgocTap";
		this.menuMoHoaNgocTap.Size = new global::System.Drawing.Size(177, 22);
		this.menuMoHoaNgocTap.Text = "Hoa Ngọc Tập";
		this.menuMoHoaNgocTap.Click += new global::System.EventHandler(this.menuMoHoaNgocTap_Click);
		this.toolStripMenuItem_29.Name = "shopTinhBànToolStripMenuItem";
		this.toolStripMenuItem_29.Size = new global::System.Drawing.Size(177, 22);
		this.toolStripMenuItem_29.Text = "Shop Tinh Bàn";
		this.toolStripMenuItem_30.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muBaGiaCan, this.muBaGiaKhon, this.muPhonghoa });
		this.toolStripMenuItem_30.Name = "báGiảThiênHạToolStripMenuItem";
		this.toolStripMenuItem_30.Size = new global::System.Drawing.Size(265, 22);
		this.toolStripMenuItem_30.Text = "Bá Giả Thiên Hạ";
		this.muBaGiaCan.Name = "muBaGiaCan";
		this.muBaGiaCan.Size = new global::System.Drawing.Size(209, 22);
		this.muBaGiaCan.Text = "Càn";
		this.muBaGiaKhon.Name = "muBaGiaKhon";
		this.muBaGiaKhon.Size = new global::System.Drawing.Size(209, 22);
		this.muBaGiaKhon.Text = "Khôn";
		this.muPhonghoa.Name = "muPhonghoa";
		this.muPhonghoa.Size = new global::System.Drawing.Size(209, 22);
		this.muPhonghoa.Text = "Chiến Trường Phong Hỏa";
		this.muDiMuaNgua.Name = "muDiMuaNgua";
		this.muDiMuaNgua.Size = new global::System.Drawing.Size(265, 22);
		this.muDiMuaNgua.Text = "Đi Mua Ngựa";
		this.muNopTuViHuyTinh.Name = "muNopTuViHuyTinh";
		this.muNopTuViHuyTinh.Size = new global::System.Drawing.Size(265, 22);
		this.muNopTuViHuyTinh.Text = "Đi Nộp Tử Vi Huy Tinh";
		this.muThanhLyNhiemVu.Name = "muThanhLyNhiemVu";
		this.muThanhLyNhiemVu.Size = new global::System.Drawing.Size(265, 22);
		this.muThanhLyNhiemVu.Text = "Đi Thanh Lý Nhiệm Vụ";
		this.muGiaoNguHanhPhapThiep.Name = "muGiaoNguHanhPhapThiep";
		this.muGiaoNguHanhPhapThiep.Size = new global::System.Drawing.Size(265, 22);
		this.muGiaoNguHanhPhapThiep.Text = "Đi Giao Ngũ Hành Thiệp";
		this.toolStripMenuItem32.Name = "toolStripMenuItem32";
		this.toolStripMenuItem32.Size = new global::System.Drawing.Size(265, 22);
		this.toolStripMenuItem32.Text = "Đi Mở Rộng Thương Khố";
		this.menuHocCheDo.Name = "menuHocCheDo";
		this.menuHocCheDo.Size = new global::System.Drawing.Size(265, 22);
		this.menuHocCheDo.Text = "Đi Học Tinh - Chế + Luyện + Công";
		this.muThinhGiaoBiKy.Name = "muThinhGiaoBiKy";
		this.muThinhGiaoBiKy.Size = new global::System.Drawing.Size(265, 22);
		this.muThinhGiaoBiKy.Text = "Đi Thỉnh Giáo Bí Kỹ";
		this.muMua100KimSangDuoc.Name = "muMua100KimSangDuoc";
		this.muMua100KimSangDuoc.Size = new global::System.Drawing.Size(265, 22);
		this.muMua100KimSangDuoc.Text = "Đi Mua 100 Kim Sang Dược";
		this.mu200ReTranh.Name = "mu200ReTranh";
		this.mu200ReTranh.Size = new global::System.Drawing.Size(265, 22);
		this.mu200ReTranh.Text = "Mua 250 Cỏ + 250 Thịt + 20 Đồ Chơi";
		this.muDiSua.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_3, this.muSuaVoHon, this.muSuaThanKhi, this.muSuaTrangBi, this.toolStripMenuItem_33 });
		this.muDiSua.Name = "muDiSua";
		this.muDiSua.Size = new global::System.Drawing.Size(148, 22);
		this.muDiSua.Text = "Đi Sửa";
		this.toolStripMenuItem_3.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_13, this.trangBij13ToolStripMenuItem, this.trangBij23ToolStripMenuItem });
		this.toolStripMenuItem_3.Name = "tăngSốLầnSửaChữaToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new global::System.Drawing.Size(191, 22);
		this.toolStripMenuItem_3.Text = "Tăng Số Lần Sửa Chữa";
		this.toolStripMenuItem_13.Name = "trangBị03ToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new global::System.Drawing.Size(135, 22);
		this.toolStripMenuItem_13.Tag = "1";
		this.toolStripMenuItem_13.Text = "Độ Bềnị 0/3";
		this.toolStripMenuItem_13.Click += new global::System.EventHandler(this.trangBij23ToolStripMenuItem_Click);
		this.trangBij13ToolStripMenuItem.Name = "trangBij13ToolStripMenuItem";
		this.trangBij13ToolStripMenuItem.Size = new global::System.Drawing.Size(135, 22);
		this.trangBij13ToolStripMenuItem.Tag = "2";
		this.trangBij13ToolStripMenuItem.Text = "Độ Bền 1/3";
		this.trangBij13ToolStripMenuItem.Click += new global::System.EventHandler(this.trangBij23ToolStripMenuItem_Click);
		this.trangBij23ToolStripMenuItem.Name = "trangBij23ToolStripMenuItem";
		this.trangBij23ToolStripMenuItem.Size = new global::System.Drawing.Size(135, 22);
		this.trangBij23ToolStripMenuItem.Tag = "3";
		this.trangBij23ToolStripMenuItem.Text = "Độ Bền 2/3";
		this.trangBij23ToolStripMenuItem.Click += new global::System.EventHandler(this.trangBij23ToolStripMenuItem_Click);
		this.muSuaVoHon.Name = "muSuaVoHon";
		this.muSuaVoHon.Size = new global::System.Drawing.Size(191, 22);
		this.muSuaVoHon.Text = "Võ Hồn";
		this.muSuaThanKhi.Name = "muSuaThanKhi";
		this.muSuaThanKhi.Size = new global::System.Drawing.Size(191, 22);
		this.muSuaThanKhi.Text = "Thần Khí";
		this.muSuaTrangBi.Name = "muSuaTrangBi";
		this.muSuaTrangBi.Size = new global::System.Drawing.Size(191, 22);
		this.muSuaTrangBi.Text = "Trang Bị";
		this.muSuaTrangBi.Click += new global::System.EventHandler(this.muSuaTrangBi_Click);
		this.toolStripMenuItem_33.Name = "sửaĐồPrivateToolStripMenuItem";
		this.toolStripMenuItem_33.Size = new global::System.Drawing.Size(191, 22);
		this.toolStripMenuItem_33.Text = "Private";
		this.muDiDoi.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.toolStripMenuItem33, this.toolStripMenuItem_22, this.toolStripMenuItem_7, this.toolStripMenuItem_4, this.muDoiChanNguyenLinhPhach, this.menuDoiHuyenSac, this.toolStripMenuItem_18, this.toolStripMenuItem_19, this.menuDoiLoanPhi, this.menuDoiDiaLinhChau,
			this.toolStripMenuItem46, this.menuDoiBoiDiep
		});
		this.muDiDoi.Name = "muDiDoi";
		this.muDiDoi.Size = new global::System.Drawing.Size(148, 22);
		this.muDiDoi.Text = "Đi Đổi";
		this.toolStripMenuItem33.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem34, this.toolStripMenuItem35, this.toolStripMenuItem36, this.toolStripMenuItem37, this.toolStripMenuItem39, this.toolStripMenuItem40 });
		this.toolStripMenuItem33.Name = "toolStripMenuItem33";
		this.toolStripMenuItem33.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem33.Text = "Đổi Phiếu Ngọc Cấp 3";
		this.toolStripMenuItem34.Name = "toolStripMenuItem34";
		this.toolStripMenuItem34.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem34.Tag = "1";
		this.toolStripMenuItem34.Text = "Thể Lực";
		this.toolStripMenuItem34.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem35.Name = "toolStripMenuItem35";
		this.toolStripMenuItem35.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem35.Tag = "2";
		this.toolStripMenuItem35.Text = "Băng";
		this.toolStripMenuItem35.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem36.Name = "toolStripMenuItem36";
		this.toolStripMenuItem36.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem36.Tag = "3";
		this.toolStripMenuItem36.Text = "Huyền";
		this.toolStripMenuItem36.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem37.Name = "toolStripMenuItem37";
		this.toolStripMenuItem37.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem37.Tag = "4";
		this.toolStripMenuItem37.Text = "Hỏa";
		this.toolStripMenuItem37.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem39.Name = "toolStripMenuItem39";
		this.toolStripMenuItem39.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem39.Tag = "5";
		this.toolStripMenuItem39.Text = "Độc";
		this.toolStripMenuItem39.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem40.Name = "toolStripMenuItem40";
		this.toolStripMenuItem40.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem40.Tag = "6";
		this.toolStripMenuItem40.Text = "Kháng Độc";
		this.toolStripMenuItem40.Click += new global::System.EventHandler(this.toolStripMenuItem40_Click);
		this.toolStripMenuItem_22.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_23, this.toolStripMenuItem_24, this.toolStripMenuItem_25, this.toolStripMenuItem_26, this.toolStripMenuItem_27, this.toolStripMenuItem_28 });
		this.toolStripMenuItem_22.Name = "cổLanNgọcToolStripMenuItem";
		this.toolStripMenuItem_22.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem_22.Text = "Cổ Lan Ngọc";
		this.toolStripMenuItem_23.Name = "thểLựcToolStripMenuItem";
		this.toolStripMenuItem_23.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_23.Tag = "#{FZYH_170213_11}";
		this.toolStripMenuItem_23.Text = "Thể Lực";
		this.toolStripMenuItem_23.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_24.Name = "băngToolStripMenuItem";
		this.toolStripMenuItem_24.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_24.Tag = "#{FZYH_170213_16}";
		this.toolStripMenuItem_24.Text = "Băng";
		this.toolStripMenuItem_24.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_25.Name = "huyềnToolStripMenuItem";
		this.toolStripMenuItem_25.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_25.Tag = "#{FZYH_170213_15}";
		this.toolStripMenuItem_25.Text = "Huyền";
		this.toolStripMenuItem_25.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_26.Name = "hỏaToolStripMenuItem";
		this.toolStripMenuItem_26.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_26.Tag = "#{FZYH_170213_17}";
		this.toolStripMenuItem_26.Text = "Hỏa";
		this.toolStripMenuItem_26.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_27.Name = "độcToolStripMenuItem";
		this.toolStripMenuItem_27.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_27.Tag = "#{FZYH_170213_18}";
		this.toolStripMenuItem_27.Text = "Độc";
		this.toolStripMenuItem_27.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_28.Name = "khángĐộcToolStripMenuItem";
		this.toolStripMenuItem_28.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_28.Tag = "#{FZYH_170213_22}";
		this.toolStripMenuItem_28.Text = "Kháng Độc";
		this.toolStripMenuItem_28.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
		this.toolStripMenuItem_7.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_8, this.toolStripMenuItem_9, this.toolStripMenuItem_10, this.toolStripMenuItem_11 });
		this.toolStripMenuItem_7.Name = "đổiHiệpẤnToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem_7.Text = "Đổi Hiệp Ấn";
		this.toolStripMenuItem_8.Name = "độcToolStripMenuItem1";
		this.toolStripMenuItem_8.Size = new global::System.Drawing.Size(109, 22);
		this.toolStripMenuItem_8.Tag = "1";
		this.toolStripMenuItem_8.Text = "Độc";
		this.toolStripMenuItem_8.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
		this.toolStripMenuItem_9.Name = "huyềnToolStripMenuItem1";
		this.toolStripMenuItem_9.Size = new global::System.Drawing.Size(109, 22);
		this.toolStripMenuItem_9.Tag = "2";
		this.toolStripMenuItem_9.Text = "Huyền";
		this.toolStripMenuItem_9.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
		this.toolStripMenuItem_10.Name = "hỏaToolStripMenuItem1";
		this.toolStripMenuItem_10.Size = new global::System.Drawing.Size(109, 22);
		this.toolStripMenuItem_10.Tag = "3";
		this.toolStripMenuItem_10.Text = "Hỏa";
		this.toolStripMenuItem_10.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
		this.toolStripMenuItem_11.Name = "băngToolStripMenuItem1";
		this.toolStripMenuItem_11.Size = new global::System.Drawing.Size(109, 22);
		this.toolStripMenuItem_11.Tag = "4";
		this.toolStripMenuItem_11.Text = "Băng";
		this.toolStripMenuItem_11.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
		this.toolStripMenuItem_4.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_5, this.toolStripMenuItem_6 });
		this.toolStripMenuItem_4.Name = "hoaLanToáiPhiếnToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem_4.Text = "Đổi Hoa Lan Toái Phiến";
		this.toolStripMenuItem_5.Name = "đổiKimTinhThạchToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem_5.Text = "Đổi Kim Tinh Thạch";
		this.toolStripMenuItem_6.Name = "đổiChânNguyênLinhPháchToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new global::System.Drawing.Size(230, 22);
		this.toolStripMenuItem_6.Text = "Đổi Chân Nguyên Linh Phách";
		this.muDoiChanNguyenLinhPhach.Name = "muDoiChanNguyenLinhPhach";
		this.muDoiChanNguyenLinhPhach.Size = new global::System.Drawing.Size(234, 22);
		this.muDoiChanNguyenLinhPhach.Text = "Đổi Chân Nguyên Linh Phách";
		this.menuDoiHuyenSac.Name = "menuDoiHuyenSac";
		this.menuDoiHuyenSac.Size = new global::System.Drawing.Size(234, 22);
		this.menuDoiHuyenSac.Text = "Đổi Huyễn Sắc Câu Thiên Thái";
		this.toolStripMenuItem_18.Name = "chíTônMiênBốToolStripMenuItem";
		this.toolStripMenuItem_18.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem_18.Text = "Đổi Chí Tôn Miên Bố";
		this.toolStripMenuItem_18.Click += new global::System.EventHandler(this.toolStripMenuItem_18_Click);
		this.toolStripMenuItem_19.Name = "chíTônBíNgânToolStripMenuItem";
		this.toolStripMenuItem_19.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem_19.Text = "Đổi Chí Tôn Bí Ngân";
		this.toolStripMenuItem_19.Click += new global::System.EventHandler(this.toolStripMenuItem_19_Click);
		this.menuDoiLoanPhi.Name = "menuDoiLoanPhi";
		this.menuDoiLoanPhi.Size = new global::System.Drawing.Size(234, 22);
		this.menuDoiLoanPhi.Text = "Đổi Loạn Phỉ Mật Hàm";
		this.menuDoiDiaLinhChau.Name = "menuDoiDiaLinhChau";
		this.menuDoiDiaLinhChau.Size = new global::System.Drawing.Size(234, 22);
		this.menuDoiDiaLinhChau.Text = "Đổi Địa Linh Châu";
		this.toolStripMenuItem46.Name = "toolStripMenuItem46";
		this.toolStripMenuItem46.Size = new global::System.Drawing.Size(234, 22);
		this.toolStripMenuItem46.Text = "Đổi Công Lực Đan";
		this.menuDoiBoiDiep.Name = "menuDoiBoiDiep";
		this.menuDoiBoiDiep.Size = new global::System.Drawing.Size(234, 22);
		this.menuDoiBoiDiep.Text = "Đổi Bối Diệp Kinh Tàn Phiến";
		this.muDiNhan.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muNhanThienMachPhucTrach, this.muNhanChienCongKiemChi, this.muNhanThuongQuanSonHai, this.muNhanBuaBaoRuong, this.muNhanLeBao, this.muNhanLenhBai, this.muBaGiaLinhThao, this.muNhanx2x3VoY, this.muNhanPhiThuy, this.menuNhanBachHoaHuongNang,
			this.toolStripMenuItem_70
		});
		this.muDiNhan.Name = "muDiNhan";
		this.muDiNhan.Size = new global::System.Drawing.Size(148, 22);
		this.muDiNhan.Text = "Đi Nhận";
		this.muNhanThienMachPhucTrach.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_14, this.toolStripMenuItem_15, this.toolStripMenuItem_16, this.toolStripMenuItem_17 });
		this.muNhanThienMachPhucTrach.Name = "muNhanThienMachPhucTrach";
		this.muNhanThienMachPhucTrach.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanThienMachPhucTrach.Text = "Nhận Thiên Mạch Phúc Trạch";
		this.toolStripMenuItem_14.Name = "laPhùThànhToolStripMenuItem";
		this.toolStripMenuItem_14.Size = new global::System.Drawing.Size(173, 22);
		this.toolStripMenuItem_14.Tag = "Hữu Tử Khuê";
		this.toolStripMenuItem_14.Text = "La Phù Thành";
		this.toolStripMenuItem_14.Click += new global::System.EventHandler(this.toolStripMenuItem_17_Click);
		this.toolStripMenuItem_15.Name = "quânThiênThànhToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new global::System.Drawing.Size(173, 22);
		this.toolStripMenuItem_15.Tag = "Uý Trì Cung";
		this.toolStripMenuItem_15.Text = "Quân Thiên Thành";
		this.toolStripMenuItem_15.Click += new global::System.EventHandler(this.toolStripMenuItem_17_Click);
		this.toolStripMenuItem_16.Name = "triềuKinhThànhToolStripMenuItem";
		this.toolStripMenuItem_16.Size = new global::System.Drawing.Size(173, 22);
		this.toolStripMenuItem_16.Tag = "Tần Thư Bảo";
		this.toolStripMenuItem_16.Text = "Triều Kinh Thành";
		this.toolStripMenuItem_16.Click += new global::System.EventHandler(this.toolStripMenuItem_17_Click);
		this.toolStripMenuItem_17.Name = "phụngMinhTrấnToolStripMenuItem";
		this.toolStripMenuItem_17.Size = new global::System.Drawing.Size(173, 22);
		this.toolStripMenuItem_17.Tag = "Trần Tiêu";
		this.toolStripMenuItem_17.Text = "Phụng Minh Trấn";
		this.toolStripMenuItem_17.Click += new global::System.EventHandler(this.toolStripMenuItem_17_Click);
		this.muNhanChienCongKiemChi.Name = "muNhanChienCongKiemChi";
		this.muNhanChienCongKiemChi.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanChienCongKiemChi.Text = "Nhận Chiến Công + Tử Vi";
		this.muNhanThuongQuanSonHai.Name = "muNhanThuongQuanSonHai";
		this.muNhanThuongQuanSonHai.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanThuongQuanSonHai.Text = "Nhận Thưởng Quan Sơn Hải";
		this.muNhanBuaBaoRuong.Name = "muNhanBuaBaoRuong";
		this.muNhanBuaBaoRuong.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanBuaBaoRuong.Text = "Nhận Bùa Bảo Rương";
		this.muNhanLeBao.Name = "muNhanLeBao";
		this.muNhanLeBao.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanLeBao.Text = "Nhận Lễ Bao";
		this.muNhanLenhBai.Name = "muNhanLenhBai";
		this.muNhanLenhBai.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanLenhBai.Text = "Nhận Lệnh Bài";
		this.muBaGiaLinhThao.Name = "muBaGiaLinhThao";
		this.muBaGiaLinhThao.Size = new global::System.Drawing.Size(265, 22);
		this.muBaGiaLinhThao.Text = "Nhận Bá Giả + Linh Thảo + Liên Tục";
		this.muNhanx2x3VoY.Name = "muNhanx2x3VoY";
		this.muNhanx2x3VoY.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanx2x3VoY.Text = "Nhận x2 x3 Võ Ý";
		this.muNhanPhiThuy.Name = "muNhanPhiThuy";
		this.muNhanPhiThuy.Size = new global::System.Drawing.Size(265, 22);
		this.muNhanPhiThuy.Text = "Nhận Phúc Nguyên Lễ Hạp";
		this.menuNhanBachHoaHuongNang.Name = "menuNhanBachHoaHuongNang";
		this.menuNhanBachHoaHuongNang.Size = new global::System.Drawing.Size(265, 22);
		this.menuNhanBachHoaHuongNang.Text = "Nhận Bách Hoa Hương Nang";
		this.toolStripMenuItem_70.Name = "nhận5GiỏHoaToolStripMenuItem";
		this.toolStripMenuItem_70.Size = new global::System.Drawing.Size(265, 22);
		this.toolStripMenuItem_70.Text = "Nhận 5 Giỏ Hoa";
		this.muPkMode.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuHoaBinh, this.menuThienAc, this.menuNhom, this.menuBang, this.menuQuanDoan });
		this.muPkMode.Name = "muPkMode";
		this.muPkMode.Size = new global::System.Drawing.Size(148, 22);
		this.muPkMode.Text = "Chế Độ Pk";
		this.menuHoaBinh.Name = "menuHoaBinh";
		this.menuHoaBinh.Size = new global::System.Drawing.Size(134, 22);
		this.menuHoaBinh.Tag = "0";
		this.menuHoaBinh.Text = "Hòa Bình";
		this.menuHoaBinh.Click += new global::System.EventHandler(this.menuQuanDoan_Click);
		this.menuThienAc.Name = "menuThienAc";
		this.menuThienAc.Size = new global::System.Drawing.Size(134, 22);
		this.menuThienAc.Tag = "2";
		this.menuThienAc.Text = "Thiện Ác";
		this.menuThienAc.Click += new global::System.EventHandler(this.menuQuanDoan_Click);
		this.menuNhom.Name = "menuNhom";
		this.menuNhom.Size = new global::System.Drawing.Size(134, 22);
		this.menuNhom.Tag = "3";
		this.menuNhom.Text = "Nhóm";
		this.menuNhom.Click += new global::System.EventHandler(this.menuQuanDoan_Click);
		this.menuBang.Name = "menuBang";
		this.menuBang.Size = new global::System.Drawing.Size(134, 22);
		this.menuBang.Tag = "4";
		this.menuBang.Text = "Bang";
		this.menuBang.Click += new global::System.EventHandler(this.menuQuanDoan_Click);
		this.menuQuanDoan.Name = "menuQuanDoan";
		this.menuQuanDoan.Size = new global::System.Drawing.Size(134, 22);
		this.menuQuanDoan.Tag = "5";
		this.menuQuanDoan.Text = "Quân Đoàn";
		this.menuQuanDoan.Click += new global::System.EventHandler(this.menuQuanDoan_Click);
		this.muIntime.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muAcTac, this.muAcBa, this.muTangKinhCac, this.menuBossMap, this.toolStripSeparator40, this.muTucCau, this.muKyCuoc, this.muLauLanTamBao, this.toolStripSeparator39, this.muDaTru,
			this.muMongHeo, this.muThienGiangKyThu, this.muPhungHoangLangMo, this.toolStripSeparator30, this.muBaoDoHiem, this.muDoanBaoMaTac
		});
		this.muIntime.Name = "muIntime";
		this.muIntime.Size = new global::System.Drawing.Size(55, 20);
		this.muIntime.Text = "Hourly";
		this.muIntime.DropDownOpened += new global::System.EventHandler(this.muFuBen_DropDownOpened);
		this.muAcTac.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripSeparator21, this.muVoLuongSon, this.muKinhHo, this.muKiemCac, this.muThaiHo, this.muTungSon, this.muDonHoang });
		this.muAcTac.Name = "muAcTac";
		this.muAcTac.Size = new global::System.Drawing.Size(198, 22);
		this.muAcTac.Text = "Ác Tặc";
		this.toolStripMenuItem_0.Name = "tựĐộngToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new global::System.Drawing.Size(147, 22);
		this.toolStripMenuItem_0.Tag = "0";
		this.toolStripMenuItem_0.Text = "Auto";
		this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.toolStripSeparator21.Name = "toolStripSeparator21";
		this.toolStripSeparator21.Size = new global::System.Drawing.Size(144, 6);
		this.muVoLuongSon.Name = "muVoLuongSon";
		this.muVoLuongSon.Size = new global::System.Drawing.Size(147, 22);
		this.muVoLuongSon.Tag = "6";
		this.muVoLuongSon.Text = "Vô Lượng Sơn";
		this.muVoLuongSon.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muKinhHo.Name = "muKinhHo";
		this.muKinhHo.Size = new global::System.Drawing.Size(147, 22);
		this.muKinhHo.Tag = "5";
		this.muKinhHo.Text = "Kính Hồ";
		this.muKinhHo.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muKiemCac.Name = "muKiemCac";
		this.muKiemCac.Size = new global::System.Drawing.Size(147, 22);
		this.muKiemCac.Tag = "7";
		this.muKiemCac.Text = "Kiếm Các";
		this.muKiemCac.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muThaiHo.Name = "muThaiHo";
		this.muThaiHo.Size = new global::System.Drawing.Size(147, 22);
		this.muThaiHo.Tag = "4";
		this.muThaiHo.Text = "Thái Hồ";
		this.muThaiHo.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muTungSon.Name = "muTungSon";
		this.muTungSon.Size = new global::System.Drawing.Size(147, 22);
		this.muTungSon.Tag = "3";
		this.muTungSon.Text = "Tung Sơn";
		this.muTungSon.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muDonHoang.Name = "muDonHoang";
		this.muDonHoang.Size = new global::System.Drawing.Size(147, 22);
		this.muDonHoang.Tag = "8";
		this.muDonHoang.Text = "Đôn Hoàng";
		this.muDonHoang.Click += new global::System.EventHandler(this.muDonHoang_Click);
		this.muAcBa.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muAcBaTuDong, this.toolStripSeparator24, this.menuDaoHoa, this.menuQuyCoc, this.menuDuongMon, this.menuMoDung, this.menuTinhTuc, this.menuTieuDao, this.menuThieuLam, this.menuThienSon,
			this.menuThienLong, this.menuNgamy, this.menuVoDang, this.menuMinhGiao, this.menuCaiBang, this.menuTuyetTinh, this.MenuAcNhanCoc
		});
		this.muAcBa.Name = "muAcBa";
		this.muAcBa.Size = new global::System.Drawing.Size(198, 22);
		this.muAcBa.Text = "Ác Bá";
		this.muAcBaTuDong.Name = "muAcBaTuDong";
		this.muAcBaTuDong.Size = new global::System.Drawing.Size(144, 22);
		this.muAcBaTuDong.Tag = "0";
		this.muAcBaTuDong.Text = "Auto";
		this.toolStripSeparator24.Name = "toolStripSeparator24";
		this.toolStripSeparator24.Size = new global::System.Drawing.Size(141, 6);
		this.menuDaoHoa.Name = "menuDaoHoa";
		this.menuDaoHoa.Size = new global::System.Drawing.Size(144, 22);
		this.menuDaoHoa.Tag = "54";
		this.menuDaoHoa.Text = "Đào Hoa";
		this.menuDaoHoa.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuQuyCoc.Name = "menuQuyCoc";
		this.menuQuyCoc.Size = new global::System.Drawing.Size(144, 22);
		this.menuQuyCoc.Tag = "53";
		this.menuQuyCoc.Text = "Quỷ Cốc";
		this.menuQuyCoc.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuDuongMon.Name = "menuDuongMon";
		this.menuDuongMon.Size = new global::System.Drawing.Size(144, 22);
		this.menuDuongMon.Tag = "37";
		this.menuDuongMon.Text = "Đường Môn";
		this.menuDuongMon.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuMoDung.Name = "menuMoDung";
		this.menuMoDung.Size = new global::System.Drawing.Size(144, 22);
		this.menuMoDung.Tag = "32";
		this.menuMoDung.Text = "Mộ Dung";
		this.menuMoDung.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuTinhTuc.Name = "menuTinhTuc";
		this.menuTinhTuc.Size = new global::System.Drawing.Size(144, 22);
		this.menuTinhTuc.Tag = "6";
		this.menuTinhTuc.Text = "Tinh Túc";
		this.menuTinhTuc.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuTieuDao.Name = "menuTieuDao";
		this.menuTieuDao.Size = new global::System.Drawing.Size(144, 22);
		this.menuTieuDao.Tag = "9";
		this.menuTieuDao.Text = "Tiêu Dao";
		this.menuTieuDao.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuThieuLam.Name = "menuThieuLam";
		this.menuThieuLam.Size = new global::System.Drawing.Size(144, 22);
		this.menuThieuLam.Tag = "1";
		this.menuThieuLam.Text = "Thiếu Lâm";
		this.menuThieuLam.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuThienSon.Name = "menuThienSon";
		this.menuThienSon.Size = new global::System.Drawing.Size(144, 22);
		this.menuThienSon.Tag = "8";
		this.menuThienSon.Text = "Thiên Sơn";
		this.menuThienSon.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuThienLong.Name = "menuThienLong";
		this.menuThienLong.Size = new global::System.Drawing.Size(144, 22);
		this.menuThienLong.Tag = "7";
		this.menuThienLong.Text = "Thiên Long";
		this.menuThienLong.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuNgamy.Name = "menuNgamy";
		this.menuNgamy.Size = new global::System.Drawing.Size(144, 22);
		this.menuNgamy.Tag = "5";
		this.menuNgamy.Text = "Ngamy";
		this.menuNgamy.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuVoDang.Name = "menuVoDang";
		this.menuVoDang.Size = new global::System.Drawing.Size(144, 22);
		this.menuVoDang.Tag = "4";
		this.menuVoDang.Text = "Võ Đang";
		this.menuVoDang.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuMinhGiao.Name = "menuMinhGiao";
		this.menuMinhGiao.Size = new global::System.Drawing.Size(144, 22);
		this.menuMinhGiao.Tag = "2";
		this.menuMinhGiao.Text = "Minh Giáo";
		this.menuMinhGiao.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuCaiBang.Name = "menuCaiBang";
		this.menuCaiBang.Size = new global::System.Drawing.Size(144, 22);
		this.menuCaiBang.Tag = "3";
		this.menuCaiBang.Text = "Cái Bang";
		this.menuCaiBang.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.menuTuyetTinh.Name = "menuTuyetTinh";
		this.menuTuyetTinh.Size = new global::System.Drawing.Size(144, 22);
		this.menuTuyetTinh.Tag = "55";
		this.menuTuyetTinh.Text = "Tuyệt Tình";
		this.menuTuyetTinh.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.MenuAcNhanCoc.Name = "MenuAcNhanCoc";
		this.MenuAcNhanCoc.Size = new global::System.Drawing.Size(144, 22);
		this.MenuAcNhanCoc.Tag = "58";
		this.MenuAcNhanCoc.Text = "Ác Nhân Cốc";
		this.MenuAcNhanCoc.Click += new global::System.EventHandler(this.MenuAcNhanCoc_Click);
		this.muTangKinhCac.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripSeparator22, this.menuTayHo, this.menuNhiHai, this.menuNhanNham });
		this.muTangKinhCac.Name = "muTangKinhCac";
		this.muTangKinhCac.Size = new global::System.Drawing.Size(198, 22);
		this.muTangKinhCac.Text = "Tàng Kinh Các";
		this.toolStripMenuItem_1.Name = "tựĐộngToolStripMenuItem1";
		this.toolStripMenuItem_1.Size = new global::System.Drawing.Size(132, 22);
		this.toolStripMenuItem_1.Tag = "0";
		this.toolStripMenuItem_1.Text = "Auto";
		this.toolStripMenuItem_1.Click += new global::System.EventHandler(this.menuNhanNham_Click);
		this.toolStripSeparator22.Name = "toolStripSeparator22";
		this.toolStripSeparator22.Size = new global::System.Drawing.Size(129, 6);
		this.menuTayHo.Name = "menuTayHo";
		this.menuTayHo.Size = new global::System.Drawing.Size(132, 22);
		this.menuTayHo.Tag = "30";
		this.menuTayHo.Text = "Tây Hồ";
		this.menuTayHo.Click += new global::System.EventHandler(this.menuNhanNham_Click);
		this.menuNhiHai.Name = "menuNhiHai";
		this.menuNhiHai.Size = new global::System.Drawing.Size(132, 22);
		this.menuNhiHai.Tag = "24";
		this.menuNhiHai.Text = "Nhĩ Hải";
		this.menuNhiHai.Click += new global::System.EventHandler(this.menuNhanNham_Click);
		this.menuNhanNham.Name = "menuNhanNham";
		this.menuNhanNham.Size = new global::System.Drawing.Size(132, 22);
		this.menuNhanNham.Tag = "18";
		this.menuNhanNham.Text = "Nhạn Nam";
		this.menuNhanNham.Click += new global::System.EventHandler(this.menuNhanNham_Click);
		this.menuBossMap.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuThuongSon, this.menuVoDi, this.menuThaoNguyen, this.menuHuyenVuDao, this.menuKinhHo });
		this.menuBossMap.Name = "menuBossMap";
		this.menuBossMap.Size = new global::System.Drawing.Size(198, 22);
		this.menuBossMap.Text = "Boss Trường Cảnh";
		this.menuBossMap.DropDownOpening += new global::System.EventHandler(this.menuBossMap_DropDownOpening);
		this.menuThuongSon.Name = "menuThuongSon";
		this.menuThuongSon.Size = new global::System.Drawing.Size(150, 22);
		this.menuThuongSon.Tag = "25";
		this.menuThuongSon.Text = "Thương Sơn";
		this.menuThuongSon.Click += new global::System.EventHandler(this.menuKinhHo_Click);
		this.menuVoDi.Name = "menuVoDi";
		this.menuVoDi.Size = new global::System.Drawing.Size(150, 22);
		this.menuVoDi.Tag = "32";
		this.menuVoDi.Text = "Võ Di";
		this.menuVoDi.Click += new global::System.EventHandler(this.menuKinhHo_Click);
		this.menuThaoNguyen.Name = "menuThaoNguyen";
		this.menuThaoNguyen.Size = new global::System.Drawing.Size(150, 22);
		this.menuThaoNguyen.Tag = "20";
		this.menuThaoNguyen.Text = "Thảo Nguyên";
		this.menuThaoNguyen.Click += new global::System.EventHandler(this.menuKinhHo_Click);
		this.menuHuyenVuDao.Name = "menuHuyenVuDao";
		this.menuHuyenVuDao.Size = new global::System.Drawing.Size(150, 22);
		this.menuHuyenVuDao.Tag = "112";
		this.menuHuyenVuDao.Text = "Huyền Vũ Đảo";
		this.menuHuyenVuDao.Click += new global::System.EventHandler(this.menuKinhHo_Click);
		this.menuKinhHo.Name = "menuKinhHo";
		this.menuKinhHo.Size = new global::System.Drawing.Size(150, 22);
		this.menuKinhHo.Tag = "5";
		this.menuKinhHo.Text = "Kính Hồ";
		this.menuKinhHo.Click += new global::System.EventHandler(this.menuKinhHo_Click);
		this.toolStripSeparator40.Name = "toolStripSeparator40";
		this.toolStripSeparator40.Size = new global::System.Drawing.Size(195, 6);
		this.muTucCau.Name = "muTucCau";
		this.muTucCau.Size = new global::System.Drawing.Size(198, 22);
		this.muTucCau.Text = "Túc Cầu";
		this.muKyCuoc.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muKyCuocNhanh, this.muKyCuocCham });
		this.muKyCuoc.Name = "muKyCuoc";
		this.muKyCuoc.Size = new global::System.Drawing.Size(198, 22);
		this.muKyCuoc.Text = "Kỳ Cuộc";
		this.muKyCuocNhanh.Name = "muKyCuocNhanh";
		this.muKyCuocNhanh.Size = new global::System.Drawing.Size(110, 22);
		this.muKyCuocNhanh.Text = "Nhanh";
		this.muKyCuocCham.Name = "muKyCuocCham";
		this.muKyCuocCham.Size = new global::System.Drawing.Size(110, 22);
		this.muKyCuocCham.Text = "Chậm";
		this.muLauLanTamBao.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muLauLanTamBaoNhanh, this.muLauLanTamBaoCham });
		this.muLauLanTamBao.Name = "muLauLanTamBao";
		this.muLauLanTamBao.Size = new global::System.Drawing.Size(198, 22);
		this.muLauLanTamBao.Text = "Lâu Lan Tầm Bảo";
		this.muLauLanTamBaoNhanh.Name = "muLauLanTamBaoNhanh";
		this.muLauLanTamBaoNhanh.Size = new global::System.Drawing.Size(110, 22);
		this.muLauLanTamBaoNhanh.Text = "Nhanh";
		this.muLauLanTamBaoCham.Name = "muLauLanTamBaoCham";
		this.muLauLanTamBaoCham.Size = new global::System.Drawing.Size(110, 22);
		this.muLauLanTamBaoCham.Text = "Chậm";
		this.toolStripSeparator39.Name = "toolStripSeparator39";
		this.toolStripSeparator39.Size = new global::System.Drawing.Size(195, 6);
		this.muDaTru.Name = "muDaTru";
		this.muDaTru.Size = new global::System.Drawing.Size(198, 22);
		this.muDaTru.Text = "Dã Trư";
		this.muMongHeo.Name = "muMongHeo";
		this.muMongHeo.Size = new global::System.Drawing.Size(198, 22);
		this.muMongHeo.Text = "Móng Heo";
		this.muThienGiangKyThu.Name = "muThienGiangKyThu";
		this.muThienGiangKyThu.Size = new global::System.Drawing.Size(198, 22);
		this.muThienGiangKyThu.Text = "Thiên Giáng Kỳ Thú";
		this.muPhungHoangLangMo.Name = "muPhungHoangLangMo";
		this.muPhungHoangLangMo.Size = new global::System.Drawing.Size(198, 22);
		this.muPhungHoangLangMo.Text = "Phụng Hoàng Lăng Mộ";
		this.toolStripSeparator30.Name = "toolStripSeparator30";
		this.toolStripSeparator30.Size = new global::System.Drawing.Size(195, 6);
		this.muBaoDoHiem.Name = "muBaoDoHiem";
		this.muBaoDoHiem.Size = new global::System.Drawing.Size(198, 22);
		this.muBaoDoHiem.Text = "Mở Bảo Đồ Hiếm";
		this.muDoanBaoMaTac.Name = "muDoanBaoMaTac";
		this.muDoanBaoMaTac.Size = new global::System.Drawing.Size(198, 22);
		this.muDoanBaoMaTac.Text = "Đoạn Bảo Mã Tặc";
		this.muDaily.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muHangNgay, this.qBangToolStripMenuItem, this.toolStripSeparator36, this.muConCai, this.muCotTruyen, this.toolStripMenuItem_41, this.toolStripSeparator32, this.muSuMon, this.muTrungAc, this.muMoBaoTangDo,
			this.toolStripSeparator35, this.muNhanThuongTriVu, this.muSinhTieu, this.muDungDoatBaoRuong, this.muKiemTung, this.toolStripMenuItem_74, this.toolStripMenuItem_77
		});
		this.muDaily.Name = "muDaily";
		this.muDaily.Size = new global::System.Drawing.Size(50, 20);
		this.muDaily.Text = "Quest";
		this.muDaily.DropDownOpened += new global::System.EventHandler(this.muFuBen_DropDownOpened);
		this.muHangNgay.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muToanBoHangNgay, this.toolStripSeparator33, this.muRotRuou, this.muBaoVeBang, this.muVanMay, this.muNguyenVong, this.toolStripSeparator45, this.muThanKhi9Sao, this.muThienKiepLau, this.toolStripMenuItem_37,
			this.menuChoiCungNienThu, this.menuAnTiec, this.toolStripMenuItem_69
		});
		this.muHangNgay.Name = "muHangNgay";
		this.muHangNgay.Size = new global::System.Drawing.Size(197, 22);
		this.muHangNgay.Text = "Daily";
		this.muToanBoHangNgay.Name = "muToanBoHangNgay";
		this.muToanBoHangNgay.Size = new global::System.Drawing.Size(206, 22);
		this.muToanBoHangNgay.Text = "All";
		this.toolStripSeparator33.Name = "toolStripSeparator33";
		this.toolStripSeparator33.Size = new global::System.Drawing.Size(203, 6);
		this.muRotRuou.Name = "muRotRuou";
		this.muRotRuou.Size = new global::System.Drawing.Size(206, 22);
		this.muRotRuou.Text = "Rót Rượu";
		this.muBaoVeBang.Name = "muBaoVeBang";
		this.muBaoVeBang.Size = new global::System.Drawing.Size(206, 22);
		this.muBaoVeBang.Text = "Bảo Vệ Bang";
		this.muVanMay.Name = "muVanMay";
		this.muVanMay.Size = new global::System.Drawing.Size(206, 22);
		this.muVanMay.Text = "Thử Tài Vận May";
		this.muNguyenVong.Name = "muNguyenVong";
		this.muNguyenVong.Size = new global::System.Drawing.Size(206, 22);
		this.muNguyenVong.Text = "Nguyện Vọng Thiên Linh";
		this.toolStripSeparator45.Name = "toolStripSeparator45";
		this.toolStripSeparator45.Size = new global::System.Drawing.Size(203, 6);
		this.muThanKhi9Sao.Name = "muThanKhi9Sao";
		this.muThanKhi9Sao.Size = new global::System.Drawing.Size(206, 22);
		this.muThanKhi9Sao.Text = "Thần Khí 9*";
		this.muThienKiepLau.Name = "muThienKiepLau";
		this.muThienKiepLau.Size = new global::System.Drawing.Size(206, 22);
		this.muThienKiepLau.Text = "Thiên Kiếp Lâu";
		this.toolStripMenuItem_37.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muTamAnhCuuLeThuong, this.muTamAnhCuuLeKho });
		this.toolStripMenuItem_37.Name = "tầmẢnhCửuLêToolStripMenuItem";
		this.toolStripMenuItem_37.Size = new global::System.Drawing.Size(206, 22);
		this.toolStripMenuItem_37.Text = "Tầm Ảnh Cửu Lê";
		this.muTamAnhCuuLeThuong.Name = "muTamAnhCuuLeThuong";
		this.muTamAnhCuuLeThuong.Size = new global::System.Drawing.Size(95, 22);
		this.muTamAnhCuuLeThuong.Text = "Sơ";
		this.muTamAnhCuuLeKho.Name = "muTamAnhCuuLeKho";
		this.muTamAnhCuuLeKho.Size = new global::System.Drawing.Size(95, 22);
		this.muTamAnhCuuLeKho.Text = "Khó";
		this.menuChoiCungNienThu.Name = "menuChoiCungNienThu";
		this.menuChoiCungNienThu.Size = new global::System.Drawing.Size(206, 22);
		this.menuChoiCungNienThu.Text = "Chơi Cùng Niên Thú";
		this.menuAnTiec.Name = "menuAnTiec";
		this.menuAnTiec.Size = new global::System.Drawing.Size(206, 22);
		this.menuAnTiec.Text = "Ăn Tiệc";
		this.toolStripMenuItem_69.Name = "ngàyXuânTaoNhãToolStripMenuItem";
		this.toolStripMenuItem_69.Size = new global::System.Drawing.Size(206, 22);
		this.toolStripMenuItem_69.Text = "Ngày Xuân Tao Nhã";
		this.qBangToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muXayDung, this.muNghienCuu, this.toolStripSeparator10, this.muKhuyechTruong, this.muThuongNghiep, this.muCongTrinh, this.muKyThuat, this.muPhatTrien, this.muQuocPhong });
		this.qBangToolStripMenuItem.Name = "qBangToolStripMenuItem";
		this.qBangToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
		this.qBangToolStripMenuItem.Text = "Bang";
		this.muXayDung.Name = "muXayDung";
		this.muXayDung.Size = new global::System.Drawing.Size(219, 22);
		this.muXayDung.Text = "Nha -> Xây Dựng";
		this.muNghienCuu.Name = "muNghienCuu";
		this.muNghienCuu.Size = new global::System.Drawing.Size(219, 22);
		this.muNghienCuu.Text = "Nha -> Nghiên Cứu";
		this.toolStripSeparator10.Name = "toolStripSeparator10";
		this.toolStripSeparator10.Size = new global::System.Drawing.Size(216, 6);
		this.muKhuyechTruong.Name = "muKhuyechTruong";
		this.muKhuyechTruong.Size = new global::System.Drawing.Size(219, 22);
		this.muKhuyechTruong.Text = "Trường -> Khuyếch Trương";
		this.muThuongNghiep.Name = "muThuongNghiep";
		this.muThuongNghiep.Size = new global::System.Drawing.Size(219, 22);
		this.muThuongNghiep.Text = "Thương -> Thương Nghiêp";
		this.muCongTrinh.Name = "muCongTrinh";
		this.muCongTrinh.Size = new global::System.Drawing.Size(219, 22);
		this.muCongTrinh.Text = "Công -> Công Trình";
		this.muKyThuat.Name = "muKyThuat";
		this.muKyThuat.Size = new global::System.Drawing.Size(219, 22);
		this.muKyThuat.Text = "Thư -> Kỹ Thuật";
		this.muPhatTrien.Name = "muPhatTrien";
		this.muPhatTrien.Size = new global::System.Drawing.Size(219, 22);
		this.muPhatTrien.Text = "Lật -> Phát Triển";
		this.muQuocPhong.Name = "muQuocPhong";
		this.muQuocPhong.Size = new global::System.Drawing.Size(219, 22);
		this.muQuocPhong.Text = "Binh -> Quốc Phòng";
		this.toolStripSeparator36.Name = "toolStripSeparator36";
		this.toolStripSeparator36.Size = new global::System.Drawing.Size(194, 6);
		this.muConCai.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muTuDuong, this.muPhuMau, this.muNhanCon, this.toolStripMenuItem_2 });
		this.muConCai.Name = "muConCai";
		this.muConCai.Size = new global::System.Drawing.Size(197, 22);
		this.muConCai.Text = "Con Cái";
		this.muTuDuong.Name = "muTuDuong";
		this.muTuDuong.Size = new global::System.Drawing.Size(163, 22);
		this.muTuDuong.Text = "Tu Dưỡng";
		this.muPhuMau.Name = "muPhuMau";
		this.muPhuMau.Size = new global::System.Drawing.Size(163, 22);
		this.muPhuMau.Text = "Phụ Mẫu";
		this.muNhanCon.Name = "muNhanCon";
		this.muNhanCon.Size = new global::System.Drawing.Size(163, 22);
		this.muNhanCon.Text = "Nhận Con";
		this.toolStripMenuItem_2.Name = "dùngTànQuyểnToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new global::System.Drawing.Size(163, 22);
		this.toolStripMenuItem_2.Text = "Dùng Tàn Quyển";
		this.muCotTruyen.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muCotTruyenThangCap, this.muCotTruyenExp, this.muCotTruyenKnbKhoa, this.muNgoChanNguyen, this.muCotTruyenChinhTuyen, this.muCotTruyenVoY, this.muCotTruyenVoTuPho, this.mux2Exp, this.muThienSuKyDai, this.muBiBao,
			this.muBaoThachBieuTang, this.muThongBao, this.toolStripMenuItem_78
		});
		this.muCotTruyen.Name = "muCotTruyen";
		this.muCotTruyen.Size = new global::System.Drawing.Size(197, 22);
		this.muCotTruyen.Text = "Cốt Truyện";
		this.muCotTruyenThangCap.Name = "muCotTruyenThangCap";
		this.muCotTruyenThangCap.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenThangCap.Text = "Thăng Cấp";
		this.muCotTruyenExp.Name = "muCotTruyenExp";
		this.muCotTruyenExp.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenExp.Text = "Nhiệm Vụ Exp 28->38";
		this.muCotTruyenKnbKhoa.Name = "muCotTruyenKnbKhoa";
		this.muCotTruyenKnbKhoa.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenKnbKhoa.Text = "Nhiệm Vụ KNB Khóa";
		this.muNgoChanNguyen.Name = "muNgoChanNguyen";
		this.muNgoChanNguyen.Size = new global::System.Drawing.Size(205, 22);
		this.muNgoChanNguyen.Text = "Ngộ Chân Nguyên";
		this.muCotTruyenChinhTuyen.Name = "muCotTruyenChinhTuyen";
		this.muCotTruyenChinhTuyen.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenChinhTuyen.Text = "Chính Tuyến";
		this.muCotTruyenVoY.Name = "muCotTruyenVoY";
		this.muCotTruyenVoY.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenVoY.Text = "Võ Ý";
		this.muCotTruyenVoTuPho.Name = "muCotTruyenVoTuPho";
		this.muCotTruyenVoTuPho.Size = new global::System.Drawing.Size(205, 22);
		this.muCotTruyenVoTuPho.Text = "Vô Tự Phổ";
		this.mux2Exp.Name = "mux2Exp";
		this.mux2Exp.Size = new global::System.Drawing.Size(205, 22);
		this.mux2Exp.Text = "Nhận x2 + Nhiệm Vụ Exp";
		this.muThienSuKyDai.Name = "muThienSuKyDai";
		this.muThienSuKyDai.Size = new global::System.Drawing.Size(205, 22);
		this.muThienSuKyDai.Text = "Thiên Sư Kỳ Đãi";
		this.muBiBao.Name = "muBiBao";
		this.muBiBao.Size = new global::System.Drawing.Size(205, 22);
		this.muBiBao.Text = "Bí Bảo";
		this.muBaoThachBieuTang.Name = "muBaoThachBieuTang";
		this.muBaoThachBieuTang.Size = new global::System.Drawing.Size(205, 22);
		this.muBaoThachBieuTang.Text = "Bảo Thạch Biếu Tặng";
		this.muThongBao.Name = "muThongBao";
		this.muThongBao.Size = new global::System.Drawing.Size(205, 22);
		this.muThongBao.Text = "Thông Bảo";
		this.toolStripMenuItem_78.Name = "cấp120ToolStripMenuItem";
		this.toolStripMenuItem_78.Size = new global::System.Drawing.Size(205, 22);
		this.toolStripMenuItem_78.Text = "Cấp 120";
		this.toolStripMenuItem_41.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem_42, this.toolStripMenuItem_43, this.toolStripMenuItem_44, this.toolStripMenuItem_45 });
		this.toolStripMenuItem_41.Name = "báchHoaDuyênToolStripMenuItem";
		this.toolStripMenuItem_41.Size = new global::System.Drawing.Size(197, 22);
		this.toolStripMenuItem_41.Text = "Bách Hoa Duyên";
		this.toolStripMenuItem_42.Name = "tuầnHoànToolStripMenuItem";
		this.toolStripMenuItem_42.Size = new global::System.Drawing.Size(133, 22);
		this.toolStripMenuItem_42.Text = "Tuần Hoàn";
		this.toolStripMenuItem_43.Name = "trồngHoaToolStripMenuItem";
		this.toolStripMenuItem_43.Size = new global::System.Drawing.Size(133, 22);
		this.toolStripMenuItem_43.Text = "Trồng Hoa";
		this.toolStripMenuItem_44.Name = "bónHoaToolStripMenuItem";
		this.toolStripMenuItem_44.Size = new global::System.Drawing.Size(133, 22);
		this.toolStripMenuItem_44.Text = "Bón Hoa";
		this.toolStripMenuItem_45.Name = "thuHoạchToolStripMenuItem";
		this.toolStripMenuItem_45.Size = new global::System.Drawing.Size(133, 22);
		this.toolStripMenuItem_45.Text = "Thu Hoạch";
		this.toolStripSeparator32.Name = "toolStripSeparator32";
		this.toolStripSeparator32.Size = new global::System.Drawing.Size(194, 6);
		this.muSuMon.Name = "muSuMon";
		this.muSuMon.Size = new global::System.Drawing.Size(197, 22);
		this.muSuMon.Text = "Sư Môn";
		this.muTrungAc.Name = "muTrungAc";
		this.muTrungAc.Size = new global::System.Drawing.Size(197, 22);
		this.muTrungAc.Text = "Trừng Ác";
		this.muTrungAc.Click += new global::System.EventHandler(this.muTrungAc_Click);
		this.muMoBaoTangDo.Name = "muMoBaoTangDo";
		this.muMoBaoTangDo.Size = new global::System.Drawing.Size(197, 22);
		this.muMoBaoTangDo.Text = "Mở Bảo Tàng Đồ";
		this.toolStripSeparator35.Name = "toolStripSeparator35";
		this.toolStripSeparator35.Size = new global::System.Drawing.Size(194, 6);
		this.muNhanThuongTriVu.Name = "muNhanThuongTriVu";
		this.muNhanThuongTriVu.Size = new global::System.Drawing.Size(197, 22);
		this.muNhanThuongTriVu.Text = "Bí Cảnh";
		this.muSinhTieu.Name = "muSinhTieu";
		this.muSinhTieu.Size = new global::System.Drawing.Size(197, 22);
		this.muSinhTieu.Text = "Sinh Tiêu";
		this.muDungDoatBaoRuong.Name = "muDungDoatBaoRuong";
		this.muDungDoatBaoRuong.Size = new global::System.Drawing.Size(197, 22);
		this.muDungDoatBaoRuong.Text = "Dũng Đoạt Bảo Rương";
		this.muKiemTung.Name = "muKiemTung";
		this.muKiemTung.Size = new global::System.Drawing.Size(197, 22);
		this.muKiemTung.Text = "Kiếm Tung Quần Hùng";
		this.toolStripMenuItem_74.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.muVoDao, this.muVoDao1 });
		this.toolStripMenuItem_74.Name = "võĐạoToolStripMenuItem";
		this.toolStripMenuItem_74.Size = new global::System.Drawing.Size(197, 22);
		this.toolStripMenuItem_74.Text = "Võ Đạo";
		this.muVoDao.Name = "muVoDao";
		this.muVoDao.Size = new global::System.Drawing.Size(103, 22);
		this.muVoDao.Text = "Công";
		this.muVoDao1.Name = "muVoDao1";
		this.muVoDao1.Size = new global::System.Drawing.Size(103, 22);
		this.muVoDao1.Text = "Thủ";
		this.toolStripMenuItem_77.Name = "tràĐạoToolStripMenuItem";
		this.toolStripMenuItem_77.Size = new global::System.Drawing.Size(197, 22);
		this.toolStripMenuItem_77.Text = "Trà Đạo";
		this.muFuBen.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muCanQuet, this.toolStripSeparator43, this.evBinhThanhKyTran, this.evPhieuMieuPhong, this.evYenTuO, this.evTuTuyetTrang, this.evThieuThatSon, this.evPhucDia, this.evPhucDiaKho, this.evVuongLang,
			this.evTamThan, this.evTruPhiPhaTamQuan, this.muQuanSonHai, this.menuSatTinh, this.toolStripSeparator13, this.muQ1ToChau, this.muQ2ToChau, this.muQ3ToChau, this.toolStripSeparator19, this.muQ1LauLan,
			this.muQ2LauLan, this.muQ3LauLan, this.toolStripSeparator42, this.muThuyLao, this.toolStripMenuItem_35, this.menuThanhKhuu, this.menuTNST
		});
		this.muFuBen.Name = "muFuBen";
		this.muFuBen.Size = new global::System.Drawing.Size(52, 20);
		this.muFuBen.Text = "Fuben";
		this.muFuBen.DropDownOpened += new global::System.EventHandler(this.muFuBen_DropDownOpened);
		this.muCanQuet.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.muCQThuCong, this.muCQAll, this.toolStripMenuItem_75, this.toolStripMenuItem_76, this.toolStripSeparator44, this.muCQKhieuChienPMP, this.muCQPhucDia, this.muCQPhucDiaKho, this.muCQVuongLang, this.muCQTamThan,
			this.muCQTuTuyetTrang, this.muCQThieuThatSon, this.muCQYenTuO, this.muCQTruPhiPhaTamQuan, this.menuCQQ1ToChau, this.menuCQQ2ToChau, this.menuCQQ3ToChau, this.menuCQSatTinh, this.menuCQQ1LauLan, this.menuCQQ2LauLan,
			this.menuCQQ3LauLan, this.menuCQYenTuO, this.menuCQSCPMP, this.menuCQKCPMP, this.menuCQThuyNguyetSonTrang
		});
		this.muCanQuet.Name = "muCanQuet";
		this.muCanQuet.Size = new global::System.Drawing.Size(199, 22);
		this.muCanQuet.Text = "Càn Quét";
		this.muCQThuCong.Name = "muCQThuCong";
		this.muCQThuCong.Size = new global::System.Drawing.Size(239, 22);
		this.muCQThuCong.Text = "Thủ Công";
		this.muCQThuCong.Click += new global::System.EventHandler(this.muCQThuCong_Click);
		this.muCQAll.Name = "muCQAll";
		this.muCQAll.Size = new global::System.Drawing.Size(239, 22);
		this.muCQAll.Text = "Toàn Bộ Phụ Bản";
		this.toolStripMenuItem_75.Name = "cànQuét5LầnToolStripMenuItem";
		this.toolStripMenuItem_75.Size = new global::System.Drawing.Size(239, 22);
		this.toolStripMenuItem_75.Text = "Càn Quét 5 Lần";
		this.toolStripMenuItem_75.Click += new global::System.EventHandler(this.toolStripMenuItem_75_Click);
		this.toolStripMenuItem_76.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.canVQ1ToChau, this.canVQ2ToChau, this.canVQ3ToChau, this.canVSatTInh, this.canVQ1LauLan, this.canVQ2LauLan, this.canVQ3LauLan });
		this.toolStripMenuItem_76.Name = "vàngToolStripMenuItem";
		this.toolStripMenuItem_76.Size = new global::System.Drawing.Size(239, 22);
		this.toolStripMenuItem_76.Text = "Vàng";
		this.canVQ1ToChau.Name = "canVQ1ToChau";
		this.canVQ1ToChau.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ1ToChau.Text = "Q1 Tô Châu";
		this.canVQ2ToChau.Name = "canVQ2ToChau";
		this.canVQ2ToChau.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ2ToChau.Text = "Q2 Tô Châu";
		this.canVQ3ToChau.Name = "canVQ3ToChau";
		this.canVQ3ToChau.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ3ToChau.Text = "Q3 Tô Châu";
		this.canVSatTInh.Name = "canVSatTInh";
		this.canVSatTInh.Size = new global::System.Drawing.Size(136, 22);
		this.canVSatTInh.Text = "Sát Tinh";
		this.canVQ1LauLan.Name = "canVQ1LauLan";
		this.canVQ1LauLan.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ1LauLan.Text = "Q1 Lâu Lan";
		this.canVQ2LauLan.Name = "canVQ2LauLan";
		this.canVQ2LauLan.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ2LauLan.Text = "Q2 Lâu Lan";
		this.canVQ3LauLan.Name = "canVQ3LauLan";
		this.canVQ3LauLan.Size = new global::System.Drawing.Size(136, 22);
		this.canVQ3LauLan.Text = "Q3 Lâu Lan";
		this.toolStripSeparator44.Name = "toolStripSeparator44";
		this.toolStripSeparator44.Size = new global::System.Drawing.Size(236, 6);
		this.muCQKhieuChienPMP.Name = "muCQKhieuChienPMP";
		this.muCQKhieuChienPMP.Size = new global::System.Drawing.Size(239, 22);
		this.muCQKhieuChienPMP.Tag = "9";
		this.muCQKhieuChienPMP.Text = "Phiêu Miễu Phong";
		this.muCQPhucDia.Name = "muCQPhucDia";
		this.muCQPhucDia.Size = new global::System.Drawing.Size(239, 22);
		this.muCQPhucDia.Tag = "11";
		this.muCQPhucDia.Text = "Phúc Địa";
		this.muCQPhucDiaKho.Name = "muCQPhucDiaKho";
		this.muCQPhucDiaKho.Size = new global::System.Drawing.Size(239, 22);
		this.muCQPhucDiaKho.Tag = "12";
		this.muCQPhucDiaKho.Text = "Phúc Địa Khó";
		this.muCQVuongLang.Name = "muCQVuongLang";
		this.muCQVuongLang.Size = new global::System.Drawing.Size(239, 22);
		this.muCQVuongLang.Tag = "8";
		this.muCQVuongLang.Text = "Vương Lăng";
		this.muCQTamThan.Name = "muCQTamThan";
		this.muCQTamThan.Size = new global::System.Drawing.Size(239, 22);
		this.muCQTamThan.Tag = "10";
		this.muCQTamThan.Text = "Tam Thần";
		this.muCQTuTuyetTrang.Name = "muCQTuTuyetTrang";
		this.muCQTuTuyetTrang.Size = new global::System.Drawing.Size(239, 22);
		this.muCQTuTuyetTrang.Tag = "2";
		this.muCQTuTuyetTrang.Text = "Tứ Tuyệt Trang";
		this.muCQThieuThatSon.Name = "muCQThieuThatSon";
		this.muCQThieuThatSon.Size = new global::System.Drawing.Size(239, 22);
		this.muCQThieuThatSon.Tag = "5";
		this.muCQThieuThatSon.Text = "Thiếu Thất Sơn";
		this.muCQYenTuO.Name = "muCQYenTuO";
		this.muCQYenTuO.Size = new global::System.Drawing.Size(239, 22);
		this.muCQYenTuO.Tag = "1";
		this.muCQYenTuO.Text = "Yến Tử Ô";
		this.muCQTruPhiPhaTamQuan.Name = "muCQTruPhiPhaTamQuan";
		this.muCQTruPhiPhaTamQuan.Size = new global::System.Drawing.Size(239, 22);
		this.muCQTruPhiPhaTamQuan.Tag = "13";
		this.muCQTruPhiPhaTamQuan.Text = "Trừ Phỉ Phá Tam Quan";
		this.menuCQQ1ToChau.Name = "menuCQQ1ToChau";
		this.menuCQQ1ToChau.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ1ToChau.Text = "Q1 Tô Châu";
		this.menuCQQ2ToChau.Name = "menuCQQ2ToChau";
		this.menuCQQ2ToChau.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ2ToChau.Text = "Q2 Tô Châu";
		this.menuCQQ3ToChau.Name = "menuCQQ3ToChau";
		this.menuCQQ3ToChau.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ3ToChau.Text = "Q3 Tô Châu";
		this.menuCQSatTinh.Name = "menuCQSatTinh";
		this.menuCQSatTinh.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQSatTinh.Text = "Sát Tinh";
		this.menuCQQ1LauLan.Name = "menuCQQ1LauLan";
		this.menuCQQ1LauLan.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ1LauLan.Text = "Q1 Lâu Lan";
		this.menuCQQ2LauLan.Name = "menuCQQ2LauLan";
		this.menuCQQ2LauLan.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ2LauLan.Text = "Q2 Lâu Lan";
		this.menuCQQ3LauLan.Name = "menuCQQ3LauLan";
		this.menuCQQ3LauLan.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQQ3LauLan.Text = "Q3 Lâu Lan";
		this.menuCQYenTuO.Name = "menuCQYenTuO";
		this.menuCQYenTuO.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQYenTuO.Text = "Yến Tử Ô";
		this.menuCQSCPMP.Name = "menuCQSCPMP";
		this.menuCQSCPMP.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQSCPMP.Text = "Sơ Chiến Phiêu Miễu Phong";
		this.menuCQKCPMP.Name = "menuCQKCPMP";
		this.menuCQKCPMP.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQKCPMP.Text = "Khiêu Chiến Phiêu Miễu Phong";
		this.menuCQThuyNguyetSonTrang.Name = "menuCQThuyNguyetSonTrang";
		this.menuCQThuyNguyetSonTrang.Size = new global::System.Drawing.Size(239, 22);
		this.menuCQThuyNguyetSonTrang.Text = "Thủy Nguyệt Sơn Trang";
		this.toolStripSeparator43.Name = "toolStripSeparator43";
		this.toolStripSeparator43.Size = new global::System.Drawing.Size(196, 6);
		this.evBinhThanhKyTran.Name = "evBinhThanhKyTran";
		this.evBinhThanhKyTran.Size = new global::System.Drawing.Size(199, 22);
		this.evBinhThanhKyTran.Tag = "7";
		this.evBinhThanhKyTran.Text = "Binh Thánh Kỳ Trận";
		this.evPhieuMieuPhong.Name = "evPhieuMieuPhong";
		this.evPhieuMieuPhong.Size = new global::System.Drawing.Size(199, 22);
		this.evPhieuMieuPhong.Tag = "9";
		this.evPhieuMieuPhong.Text = "Phiêu Miễu Phong";
		this.evYenTuO.Name = "evYenTuO";
		this.evYenTuO.Size = new global::System.Drawing.Size(199, 22);
		this.evYenTuO.Tag = "1";
		this.evYenTuO.Text = "Yến Tử Ô";
		this.evTuTuyetTrang.Name = "evTuTuyetTrang";
		this.evTuTuyetTrang.Size = new global::System.Drawing.Size(199, 22);
		this.evTuTuyetTrang.Tag = "2";
		this.evTuTuyetTrang.Text = "Tứ Tuyệt Trang";
		this.evThieuThatSon.Name = "evThieuThatSon";
		this.evThieuThatSon.Size = new global::System.Drawing.Size(199, 22);
		this.evThieuThatSon.Tag = "5";
		this.evThieuThatSon.Text = "Thiếu Thất Sơn";
		this.evPhucDia.Name = "evPhucDia";
		this.evPhucDia.Size = new global::System.Drawing.Size(199, 22);
		this.evPhucDia.Text = "Phúc Địa";
		this.evPhucDiaKho.Name = "evPhucDiaKho";
		this.evPhucDiaKho.Size = new global::System.Drawing.Size(199, 22);
		this.evPhucDiaKho.Tag = "12";
		this.evPhucDiaKho.Text = "Phúc Địa Khó";
		this.evVuongLang.Name = "evVuongLang";
		this.evVuongLang.Size = new global::System.Drawing.Size(199, 22);
		this.evVuongLang.Tag = "8";
		this.evVuongLang.Text = "Vương Lăng";
		this.evTamThan.Name = "evTamThan";
		this.evTamThan.Size = new global::System.Drawing.Size(199, 22);
		this.evTamThan.Tag = "10";
		this.evTamThan.Text = "Tam Thần";
		this.evTruPhiPhaTamQuan.Name = "evTruPhiPhaTamQuan";
		this.evTruPhiPhaTamQuan.Size = new global::System.Drawing.Size(199, 22);
		this.evTruPhiPhaTamQuan.Tag = "13";
		this.evTruPhiPhaTamQuan.Text = "Trừ Phỉ Phá Tam Quan";
		this.muQuanSonHai.Name = "muQuanSonHai";
		this.muQuanSonHai.Size = new global::System.Drawing.Size(199, 22);
		this.muQuanSonHai.Text = "Quan Sơn Hải";
		this.menuSatTinh.Name = "menuSatTinh";
		this.menuSatTinh.Size = new global::System.Drawing.Size(199, 22);
		this.menuSatTinh.Text = "Sát Tinh";
		this.toolStripSeparator13.Name = "toolStripSeparator13";
		this.toolStripSeparator13.Size = new global::System.Drawing.Size(196, 6);
		this.muQ1ToChau.Name = "muQ1ToChau";
		this.muQ1ToChau.Size = new global::System.Drawing.Size(199, 22);
		this.muQ1ToChau.Text = "Q1 Tô Châu";
		this.muQ2ToChau.Name = "muQ2ToChau";
		this.muQ2ToChau.Size = new global::System.Drawing.Size(199, 22);
		this.muQ2ToChau.Text = "Q2 Tô Châu";
		this.muQ3ToChau.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuQ3ToChauNhanh, this.menuQ3ToChauCham });
		this.muQ3ToChau.Name = "muQ3ToChau";
		this.muQ3ToChau.Size = new global::System.Drawing.Size(199, 22);
		this.muQ3ToChau.Text = "Q3 Tô Châu";
		this.menuQ3ToChauNhanh.Name = "menuQ3ToChauNhanh";
		this.menuQ3ToChauNhanh.Size = new global::System.Drawing.Size(110, 22);
		this.menuQ3ToChauNhanh.Text = "Nhanh";
		this.menuQ3ToChauCham.Name = "menuQ3ToChauCham";
		this.menuQ3ToChauCham.Size = new global::System.Drawing.Size(110, 22);
		this.menuQ3ToChauCham.Text = "Chậm";
		this.toolStripSeparator19.Name = "toolStripSeparator19";
		this.toolStripSeparator19.Size = new global::System.Drawing.Size(196, 6);
		this.muQ1LauLan.Name = "muQ1LauLan";
		this.muQ1LauLan.Size = new global::System.Drawing.Size(199, 22);
		this.muQ1LauLan.Text = "Q1 Lâu Lan";
		this.muQ2LauLan.Name = "muQ2LauLan";
		this.muQ2LauLan.Size = new global::System.Drawing.Size(199, 22);
		this.muQ2LauLan.Text = "Q2 Lâu Lan";
		this.muQ3LauLan.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuQ3LauLanNhanh, this.menuQ3LauLanCham });
		this.muQ3LauLan.Name = "muQ3LauLan";
		this.muQ3LauLan.Size = new global::System.Drawing.Size(199, 22);
		this.muQ3LauLan.Text = "Q3 Lâu Lan";
		this.menuQ3LauLanNhanh.Name = "menuQ3LauLanNhanh";
		this.menuQ3LauLanNhanh.Size = new global::System.Drawing.Size(110, 22);
		this.menuQ3LauLanNhanh.Text = "Nhanh";
		this.menuQ3LauLanCham.Name = "menuQ3LauLanCham";
		this.menuQ3LauLanCham.Size = new global::System.Drawing.Size(110, 22);
		this.menuQ3LauLanCham.Text = "Chậm";
		this.toolStripSeparator42.Name = "toolStripSeparator42";
		this.toolStripSeparator42.Size = new global::System.Drawing.Size(196, 6);
		this.muThuyLao.Name = "muThuyLao";
		this.muThuyLao.Size = new global::System.Drawing.Size(199, 22);
		this.muThuyLao.Text = "Thủy Lao";
		this.toolStripMenuItem_35.Name = "nhậnTrảQ3TôChâuToolStripMenuItem";
		this.toolStripMenuItem_35.Size = new global::System.Drawing.Size(199, 22);
		this.toolStripMenuItem_35.Text = "Nhận Trả Q3 Tô Châu";
		this.toolStripMenuItem_35.Click += new global::System.EventHandler(this.toolStripMenuItem_35_Click);
		this.menuThanhKhuu.Name = "menuThanhKhuu";
		this.menuThanhKhuu.Size = new global::System.Drawing.Size(199, 22);
		this.menuThanhKhuu.Text = "Thanh Khưu";
		this.menuTNST.Name = "menuTNST";
		this.menuTNST.Size = new global::System.Drawing.Size(199, 22);
		this.menuTNST.Text = "Thủy Nguyệt Sơn Trang";
		this.muAll.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.selectCtrlAToolStripMenuItem, this.toolStripMenuItem_21, this.refreshToolStripMenuItem1, this.toolStripSeparator28, this.selectServerToolStripMenuItem, this.eitOFFLINEToolStripMenuItem, this.quitToolStripMenuItem, this.toolStripSeparator9, this.menuDauThai, this.muLenNgua,
			this.muXuongNgua, this.muDiemDanh, this.muSapXepTayNai
		});
		this.muAll.Name = "muAll";
		this.muAll.Size = new global::System.Drawing.Size(33, 20);
		this.muAll.Text = "All";
		this.selectCtrlAToolStripMenuItem.Name = "selectCtrlAToolStripMenuItem";
		this.selectCtrlAToolStripMenuItem.Size = new global::System.Drawing.Size(205, 22);
		this.selectCtrlAToolStripMenuItem.Text = "Select [Ctrl + A]";
		this.selectCtrlAToolStripMenuItem.Click += new global::System.EventHandler(this.selectCtrlAToolStripMenuItem_Click);
		this.toolStripMenuItem_21.Name = "ẩnCtrlToolStripMenuItem";
		this.toolStripMenuItem_21.Size = new global::System.Drawing.Size(205, 22);
		this.toolStripMenuItem_21.Text = "Hide [Ctrl + Page Down]";
		this.toolStripMenuItem_21.Click += new global::System.EventHandler(this.toolStripMenuItem_21_Click);
		this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
		this.refreshToolStripMenuItem1.Size = new global::System.Drawing.Size(205, 22);
		this.refreshToolStripMenuItem1.Text = "Refresh [Alt + W]";
		this.refreshToolStripMenuItem1.Click += new global::System.EventHandler(this.refreshToolStripMenuItem1_Click);
		this.toolStripSeparator28.Name = "toolStripSeparator28";
		this.toolStripSeparator28.Size = new global::System.Drawing.Size(202, 6);
		this.selectServerToolStripMenuItem.Name = "selectServerToolStripMenuItem";
		this.selectServerToolStripMenuItem.Size = new global::System.Drawing.Size(205, 22);
		this.selectServerToolStripMenuItem.Text = "Select Server";
		this.selectServerToolStripMenuItem.Click += new global::System.EventHandler(this.selectServerToolStripMenuItem_Click);
		this.eitOFFLINEToolStripMenuItem.Name = "eitOFFLINEToolStripMenuItem";
		this.eitOFFLINEToolStripMenuItem.Size = new global::System.Drawing.Size(205, 22);
		this.eitOFFLINEToolStripMenuItem.Text = "Quit OFFLINE";
		this.eitOFFLINEToolStripMenuItem.Click += new global::System.EventHandler(this.eitOFFLINEToolStripMenuItem_Click);
		this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
		this.quitToolStripMenuItem.Size = new global::System.Drawing.Size(205, 22);
		this.quitToolStripMenuItem.Text = "Quit All";
		this.quitToolStripMenuItem.Click += new global::System.EventHandler(this.quitToolStripMenuItem_Click);
		this.toolStripSeparator9.Name = "toolStripSeparator9";
		this.toolStripSeparator9.Size = new global::System.Drawing.Size(202, 6);
		this.menuDauThai.Name = "menuDauThai";
		this.menuDauThai.Size = new global::System.Drawing.Size(205, 22);
		this.menuDauThai.Text = "Đầu Thai [Alt + P]";
		this.menuDauThai.Click += new global::System.EventHandler(this.menuDauThai_Click);
		this.muLenNgua.Name = "muLenNgua";
		this.muLenNgua.Size = new global::System.Drawing.Size(205, 22);
		this.muLenNgua.Text = "Lên Ngựa [Ctrl + U]";
		this.muLenNgua.Click += new global::System.EventHandler(this.muLenNgua_Click);
		this.muXuongNgua.Name = "muXuongNgua";
		this.muXuongNgua.Size = new global::System.Drawing.Size(205, 22);
		this.muXuongNgua.Text = "Xuống Ngựa [Ctrl + D]";
		this.muXuongNgua.Click += new global::System.EventHandler(this.muXuongNgua_Click);
		this.muDiemDanh.Name = "muDiemDanh";
		this.muDiemDanh.Size = new global::System.Drawing.Size(205, 22);
		this.muDiemDanh.Text = "Điểm Danh [Ctrp + P]";
		this.muDiemDanh.Click += new global::System.EventHandler(this.muDiemDanh_Click);
		this.muSapXepTayNai.Name = "muSapXepTayNai";
		this.muSapXepTayNai.Size = new global::System.Drawing.Size(205, 22);
		this.muSapXepTayNai.Text = "Sắp Xếp Tay Nải [Alt + Z]";
		this.muSapXepTayNai.Click += new global::System.EventHandler(this.muSapXepTayNai_Click);
		this.muNier.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.menuOpenGame, this.autoPkAltIToolStripMenuItem, this.toolStripSeparator3, this.menuPickNear, this.menuPickItem, this.muItemFiller, this.toolStripMenuItem_47, this.toolStripMenuItem_73, this.toolStripSeparator8, this.toolStripMenuItem_48,
			this.menuFollowKey, this.menuuForceFollowKey, this.toolStripSeparator25, this.menuAtkFollowKey, this.menuPkMode
		});
		this.muNier.Name = "muNier";
		this.muNier.Size = new global::System.Drawing.Size(22, 20);
		this.muNier.Text = "i";
		this.muNier.DropDownOpening += new global::System.EventHandler(this.muNier_DropDownOpening);
		this.muNier.Click += new global::System.EventHandler(this.muNier_Click);
		this.menuOpenGame.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.open1ToolStripMenuItem, this.open2ToolStripMenuItem, this.open3ToolStripMenuItem, this.open4ToolStripMenuItem, this.open5ToolStripMenuItem, this.open6ToolStripMenuItem, this.open12ToolStripMenuItem, this.open24ToolStripMenuItem, this.open48ToolStripMenuItem, this.open96ToolStripMenuItem,
			this.menuSelectPath
		});
		this.menuOpenGame.Name = "menuOpenGame";
		this.menuOpenGame.Size = new global::System.Drawing.Size(263, 22);
		this.menuOpenGame.Text = "Mở Game [Ctrl + O]";
		this.menuOpenGame.DropDownOpening += new global::System.EventHandler(this.menuOpenGame_DropDownOpening);
		this.open1ToolStripMenuItem.Name = "open1ToolStripMenuItem";
		this.open1ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open1ToolStripMenuItem.Text = "1 Game";
		this.open1ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open2ToolStripMenuItem.Name = "open2ToolStripMenuItem";
		this.open2ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open2ToolStripMenuItem.Text = "2 Game";
		this.open2ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open3ToolStripMenuItem.Name = "open3ToolStripMenuItem";
		this.open3ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open3ToolStripMenuItem.Text = "3 Game";
		this.open3ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open4ToolStripMenuItem.Name = "open4ToolStripMenuItem";
		this.open4ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open4ToolStripMenuItem.Text = "4 Game";
		this.open4ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open5ToolStripMenuItem.Name = "open5ToolStripMenuItem";
		this.open5ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open5ToolStripMenuItem.Text = "5 Game";
		this.open5ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open6ToolStripMenuItem.Name = "open6ToolStripMenuItem";
		this.open6ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open6ToolStripMenuItem.Text = "6 Game";
		this.open6ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open12ToolStripMenuItem.Name = "open12ToolStripMenuItem";
		this.open12ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open12ToolStripMenuItem.Text = "12 Game";
		this.open12ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open24ToolStripMenuItem.Name = "open24ToolStripMenuItem";
		this.open24ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open24ToolStripMenuItem.Text = "24 Game";
		this.open24ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open48ToolStripMenuItem.Name = "open48ToolStripMenuItem";
		this.open48ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open48ToolStripMenuItem.Text = "48 Game";
		this.open48ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.open96ToolStripMenuItem.Name = "open96ToolStripMenuItem";
		this.open96ToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
		this.open96ToolStripMenuItem.Text = "96 Game";
		this.open96ToolStripMenuItem.Click += new global::System.EventHandler(this.open96ToolStripMenuItem_Click);
		this.menuSelectPath.Name = "menuSelectPath";
		this.menuSelectPath.Size = new global::System.Drawing.Size(166, 22);
		this.menuSelectPath.Text = "Chọn Đường Dẫn";
		this.menuSelectPath.Click += new global::System.EventHandler(this.menuSelectPath_Click);
		this.autoPkAltIToolStripMenuItem.Name = "autoPkAltIToolStripMenuItem";
		this.autoPkAltIToolStripMenuItem.Size = new global::System.Drawing.Size(263, 22);
		this.autoPkAltIToolStripMenuItem.Text = "Auto Pk [Alt + Y]";
		this.autoPkAltIToolStripMenuItem.Click += new global::System.EventHandler(this.autoPkAltIToolStripMenuItem_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new global::System.Drawing.Size(260, 6);
		this.menuPickNear.Name = "menuPickNear";
		this.menuPickNear.Size = new global::System.Drawing.Size(263, 22);
		this.menuPickNear.Text = "Nhặt Đồ Gần";
		this.menuPickNear.Click += new global::System.EventHandler(this.menuPickNear_Click);
		this.menuPickItem.Name = "menuPickItem";
		this.menuPickItem.Size = new global::System.Drawing.Size(263, 22);
		this.menuPickItem.Text = "Nhặt Đồ";
		this.menuPickItem.Click += new global::System.EventHandler(this.menuPickItem_Click);
		this.muItemFiller.Name = "muItemFiller";
		this.muItemFiller.Size = new global::System.Drawing.Size(263, 22);
		this.muItemFiller.Text = "Lọc Đồ";
		this.muItemFiller.Click += new global::System.EventHandler(this.muItemFiller_Click);
		this.toolStripMenuItem_47.Name = "dùngCànKhônHồToolStripMenuItem";
		this.toolStripMenuItem_47.Size = new global::System.Drawing.Size(263, 22);
		this.toolStripMenuItem_47.Text = "Dùng Càn Khôn Hồ";
		this.toolStripMenuItem_47.Click += new global::System.EventHandler(this.toolStripMenuItem_47_Click);
		this.toolStripMenuItem_73.Name = "dùngMãYênToolStripMenuItem";
		this.toolStripMenuItem_73.Size = new global::System.Drawing.Size(263, 22);
		this.toolStripMenuItem_73.Text = "Dùng Mã Yên";
		this.toolStripMenuItem_73.Click += new global::System.EventHandler(this.toolStripMenuItem_73_Click);
		this.toolStripSeparator8.Name = "toolStripSeparator8";
		this.toolStripSeparator8.Size = new global::System.Drawing.Size(260, 6);
		this.toolStripMenuItem_48.Name = "lùaQuáiToolStripMenuItem";
		this.toolStripMenuItem_48.Size = new global::System.Drawing.Size(263, 22);
		this.toolStripMenuItem_48.Text = "Lùa Quái";
		this.toolStripMenuItem_48.Click += new global::System.EventHandler(this.toolStripMenuItem_48_Click);
		this.menuFollowKey.Name = "menuFollowKey";
		this.menuFollowKey.Size = new global::System.Drawing.Size(263, 22);
		this.menuFollowKey.Text = "Theo Sau Key";
		this.menuFollowKey.Click += new global::System.EventHandler(this.menuFollowKey_Click);
		this.menuuForceFollowKey.Name = "menuuForceFollowKey";
		this.menuuForceFollowKey.Size = new global::System.Drawing.Size(263, 22);
		this.menuuForceFollowKey.Text = "Buộc Theo Sau Key [Ctrl + Shift + F]";
		this.menuuForceFollowKey.Click += new global::System.EventHandler(this.menuuForceFollowKey_Click);
		this.toolStripSeparator25.Name = "toolStripSeparator25";
		this.toolStripSeparator25.Size = new global::System.Drawing.Size(260, 6);
		this.menuAtkFollowKey.Name = "menuAtkFollowKey";
		this.menuAtkFollowKey.Size = new global::System.Drawing.Size(263, 22);
		this.menuAtkFollowKey.Text = "Đánh Theo Key [Ctrl + Q]";
		this.menuAtkFollowKey.Click += new global::System.EventHandler(this.menuAtkFollowKey_Click);
		this.menuPkMode.Name = "menuPkMode";
		this.menuPkMode.Size = new global::System.Drawing.Size(263, 22);
		this.menuPkMode.Text = "Chỉ Đánh Người";
		this.menuPkMode.Click += new global::System.EventHandler(this.menuPkMode_Click);
		this.goToolStripMenuItem.Name = "goToolStripMenuItem";
		this.goToolStripMenuItem.Size = new global::System.Drawing.Size(34, 20);
		this.goToolStripMenuItem.Text = "Go";
		this.goToolStripMenuItem.DropDownOpening += new global::System.EventHandler(this.goToolStripMenuItem_DropDownOpening);
		this.columnHeader_0.Text = "Time";
		this.columnHeader_0.Width = 73;
		this.columnHeader_1.Text = "From";
		this.columnHeader_1.Width = 70;
		this.columnHeader_2.Text = "To";
		this.columnHeader_2.Width = 70;
		this.columnHeader_3.Text = "Message";
		this.columnHeader_3.Width = 120;
		this.tabPage5.Controls.Add(this.label9);
		this.tabPage5.Controls.Add(this.splitContainer3);
		this.tabPage5.Controls.Add(this.panel7);
		this.tabPage5.Location = new global::System.Drawing.Point(4, 4);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new global::System.Drawing.Size(368, 196);
		this.tabPage5.TabIndex = 15;
		this.tabPage5.Text = "Trader";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.label9.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.label9.Location = new global::System.Drawing.Point(3, 3);
		this.label9.Name = "label9";
		this.label9.Size = new global::System.Drawing.Size(362, 190);
		this.label9.TabIndex = 3;
		this.label9.Text = "Tính Năng Chạy Thương Nhân Đang Được Hoàn Thiện";
		this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.splitContainer3.Location = new global::System.Drawing.Point(3, 3);
		this.splitContainer3.Name = "splitContainer3";
		this.splitContainer3.Size = new global::System.Drawing.Size(362, 141);
		this.splitContainer3.SplitterDistance = 178;
		this.splitContainer3.TabIndex = 1;
		this.panel7.Location = new global::System.Drawing.Point(3, 171);
		this.panel7.Name = "panel7";
		this.panel7.Size = new global::System.Drawing.Size(362, 22);
		this.panel7.TabIndex = 0;
		this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
		this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.deleteToolStripMenuItem, this.clearToolStripMenuItem });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new global::System.Drawing.Size(108, 48);
		this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
		this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
		this.deleteToolStripMenuItem.Text = "Delete";
		this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
		this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
		this.clearToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
		this.clearToolStripMenuItem.Text = "Clear";
		this.clearToolStripMenuItem.Click += new global::System.EventHandler(this.clearToolStripMenuItem_Click);
		this.notifyIcon_0.ContextMenuStrip = this.contextMenuStrip2;
		this.notifyIcon_0.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("nIco.Icon");
		this.notifyIcon_0.Text = "iAuto";
		this.notifyIcon_0.Visible = true;
		this.notifyIcon_0.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon_0_MouseClick);
		this.contextMenuStrip2.ImageScalingSize = new global::System.Drawing.Size(20, 20);
		this.contextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.updateIAutoToolStripMenuItem, this.toolStripSeparator1, this.onTopToolStripMenuItem, this.englishToolStripMenuItem, this.toolStripMenuItem_36, this.toolStripSeparator23, this.resetSpeedToolStripMenuItem, this.pauseToolStripMenuItem, this.exitToolStripMenuItem });
		this.contextMenuStrip2.Name = "contextMenuStrip2";
		this.contextMenuStrip2.Size = new global::System.Drawing.Size(173, 170);
		this.contextMenuStrip2.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
		this.updateIAutoToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
		this.updateIAutoToolStripMenuItem.Name = "updateIAutoToolStripMenuItem";
		this.updateIAutoToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.updateIAutoToolStripMenuItem.Text = "Update";
		this.updateIAutoToolStripMenuItem.Visible = false;
		this.updateIAutoToolStripMenuItem.Click += new global::System.EventHandler(this.updateIAutoToolStripMenuItem_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new global::System.Drawing.Size(169, 6);
		this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
		this.onTopToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.onTopToolStripMenuItem.Text = "OnTop";
		this.onTopToolStripMenuItem.Click += new global::System.EventHandler(this.onTopToolStripMenuItem_Click);
		this.englishToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.englishToolStripMenuItem1, this.toolStripMenuItem_38 });
		this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
		this.englishToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.englishToolStripMenuItem.Text = "Language";
		this.englishToolStripMenuItem.DropDownOpening += new global::System.EventHandler(this.englishToolStripMenuItem_DropDownOpening);
		this.englishToolStripMenuItem.Click += new global::System.EventHandler(this.englishToolStripMenuItem_Click);
		this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
		this.englishToolStripMenuItem1.Size = new global::System.Drawing.Size(127, 22);
		this.englishToolStripMenuItem1.Text = "English";
		this.englishToolStripMenuItem1.Click += new global::System.EventHandler(this.englishToolStripMenuItem1_Click);
		this.toolStripMenuItem_38.Name = "tiếngViệtToolStripMenuItem";
		this.toolStripMenuItem_38.Size = new global::System.Drawing.Size(127, 22);
		this.toolStripMenuItem_38.Text = "Tiếng Việt";
		this.toolStripMenuItem_38.Click += new global::System.EventHandler(this.toolStripMenuItem_38_Click);
		this.toolStripMenuItem_36.Name = "váGameToolStripMenuItem1";
		this.toolStripMenuItem_36.Size = new global::System.Drawing.Size(172, 22);
		this.toolStripMenuItem_36.Text = "Game Patcher";
		this.toolStripMenuItem_36.Click += new global::System.EventHandler(this.toolStripMenuItem_36_Click);
		this.toolStripSeparator23.Name = "toolStripSeparator23";
		this.toolStripSeparator23.Size = new global::System.Drawing.Size(169, 6);
		this.resetSpeedToolStripMenuItem.Name = "resetSpeedToolStripMenuItem";
		this.resetSpeedToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.resetSpeedToolStripMenuItem.Text = "Recalculate Speed ";
		this.resetSpeedToolStripMenuItem.Click += new global::System.EventHandler(this.resetSpeedToolStripMenuItem_Click);
		this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
		this.pauseToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.pauseToolStripMenuItem.Text = "[Pause]";
		this.pauseToolStripMenuItem.Click += new global::System.EventHandler(this.pauseToolStripMenuItem_Click);
		this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
		this.exitToolStripMenuItem.Text = "Exit";
		this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.exitToolStripMenuItem_Click);
		this.tabLoginOnline.Controls.Add(this.loginUser1);
		this.tabLoginOnline.Location = new global::System.Drawing.Point(4, 4);
		this.tabLoginOnline.Name = "tabLoginOnline";
		this.tabLoginOnline.Size = new global::System.Drawing.Size(508, 398);
		this.tabLoginOnline.TabIndex = 7;
		this.tabLoginOnline.Tag = "#";
		this.tabLoginOnline.Text = "+";
		this.tabLoginOnline.UseVisualStyleBackColor = true;
		this.loginUser1.BackColor = global::System.Drawing.Color.White;
		this.loginUser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.loginUser1.String_1 = null;
		this.loginUser1.Location = new global::System.Drawing.Point(0, 0);
		this.loginUser1.Margin = new global::System.Windows.Forms.Padding(4);
		this.loginUser1.Name = "loginUser1";
		this.loginUser1.String_0 = null;
		this.loginUser1.Size = new global::System.Drawing.Size(508, 398);
		this.loginUser1.TabIndex = 0;
		this.columnHeader_19.Text = "Time";
		this.columnHeader_19.Width = 79;
		this.columnHeader_20.Text = "From";
		this.columnHeader_20.Width = 79;
		this.columnHeader_21.Text = "To";
		this.columnHeader_22.Text = "Message";
		this.columnHeader_22.Width = 143;
		this.timer_1.Enabled = true;
		this.timer_1.Interval = 2000;
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		this.checkSkill.AutoSize = true;
		this.checkSkill.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkSkill.Location = new global::System.Drawing.Point(244, 0);
		this.checkSkill.Name = "checkSkill";
		this.checkSkill.Size = new global::System.Drawing.Size(15, 20);
		this.checkSkill.TabIndex = 0;
		this.toolTip_0.SetToolTip(this.checkSkill, "Ctrl + K");
		this.checkSkill.UseVisualStyleBackColor = true;
		this.checkSkill.CheckedChanged += new global::System.EventHandler(this.checkSkill_CheckedChanged);
		this.txtPass2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtPass2.Location = new global::System.Drawing.Point(258, 0);
		this.txtPass2.Name = "txtPass2";
		this.txtPass2.PasswordChar = '*';
		this.txtPass2.Size = new global::System.Drawing.Size(133, 20);
		this.txtPass2.TabIndex = 214;
		this.toolTip_0.SetToolTip(this.txtPass2, "Enter To Open Pass 2");
		this.txtPass2.String_0 = "Pass 2";
		this.txtPass2.Color_0 = global::System.Drawing.Color.Gray;
		this.txtPass2.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtPass2.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtPass2.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtPass2_KeyDown);
		this.cboLeader.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboLeader.FormattingEnabled = true;
		this.cboLeader.Location = new global::System.Drawing.Point(147, 0);
		this.cboLeader.Name = "cboLeader";
		this.cboLeader.Size = new global::System.Drawing.Size(111, 21);
		this.cboLeader.TabIndex = 277;
		this.toolTip_0.SetToolTip(this.cboLeader, "Key - Leader");
		this.cboLeader.DropDown += new global::System.EventHandler(this.cboLeader_DropDown);
		this.cboLeader.SelectedIndexChanged += new global::System.EventHandler(this.cboLeader_SelectedIndexChanged);
		this.cboLeader.TextChanged += new global::System.EventHandler(this.cboLeader_TextChanged);
		this.cboMenpai.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboMenpai.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboMenpai.FormattingEnabled = true;
		this.cboMenpai.Items.AddRange(new object[]
		{
			"None", "Thiếu Lâm", "Minh Giáo", "Cái Bang", "Võ Đang", "Nga My", "Tinh Túc", "Thiên Long", "Thiên Sơn", "Tiêu Dao",
			"Mộ Dung", "Đường Môn", "Quỷ Cốc", "Đào Hoa", "Tuyệt Tình"
		});
		this.cboMenpai.Location = new global::System.Drawing.Point(0, 0);
		this.cboMenpai.Name = "cboMenpai";
		this.cboMenpai.Size = new global::System.Drawing.Size(147, 21);
		this.cboMenpai.TabIndex = 333;
		this.cboMenpai.TabStop = false;
		this.toolTip_0.SetToolTip(this.cboMenpai, "Join Menpai");
		this.cboMenpai.SelectedIndexChanged += new global::System.EventHandler(this.cboMenpai_SelectedIndexChanged);
		this.checkPanel.AutoSize = true;
		this.checkPanel.Checked = true;
		this.checkPanel.CheckState = global::System.Windows.Forms.CheckState.Checked;
		this.checkPanel.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkPanel.Location = new global::System.Drawing.Point(405, 0);
		this.checkPanel.Name = "checkPanel";
		this.checkPanel.Size = new global::System.Drawing.Size(15, 20);
		this.checkPanel.TabIndex = 11;
		this.toolTip_0.SetToolTip(this.checkPanel, "Panel");
		this.checkPanel.UseVisualStyleBackColor = true;
		this.checkPanel.CheckedChanged += new global::System.EventHandler(this.checkPanel_CheckedChanged);
		this.menuQr.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.saveToolStripMenuItem });
		this.menuQr.Name = "menuQr";
		this.menuQr.Size = new global::System.Drawing.Size(99, 26);
		this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
		this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(98, 22);
		this.saveToolStripMenuItem.Text = "Save";
		this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.saveToolStripMenuItem_Click);
		this.tabMain.TabAlignment_0 = global::System.Windows.Forms.TabAlignment.Top;
		this.tabMain.Controls.Add(this.tabGame);
		this.tabMain.Controls.Add(this.tabiLogin);
		this.tabMain.Controls.Add(this.tabPay);
		this.tabMain.Controls.Add(this.tabinBox);
		this.tabMain.Controls.Add(this.tabSetting);
		this.tabMain.Controls.Add(this.tabConfig);
		this.tabMain.Controls.Add(this.tabChat);
		this.tabMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tabMain.Location = new global::System.Drawing.Point(0, 24);
		this.tabMain.Name = "tabMain";
		this.tabMain.SelectedIndex = 0;
		this.tabMain.Size = new global::System.Drawing.Size(434, 487);
		this.tabMain.TabIndex = 14;
		this.tabGame.BackColor = global::System.Drawing.Color.White;
		this.tabGame.Controls.Add(this.splitContainer1);
		this.tabGame.Controls.Add(this.panel17);
		this.tabGame.Location = new global::System.Drawing.Point(4, 22);
		this.tabGame.Name = "tabGame";
		this.tabGame.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabGame.Size = new global::System.Drawing.Size(426, 461);
		this.tabGame.TabIndex = 0;
		this.tabGame.Text = "Game";
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
		this.splitContainer1.Location = new global::System.Drawing.Point(3, 23);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.splitContainer1.Panel1.Controls.Add(this.LvGame);
		this.splitContainer1.Panel2.Controls.Add(this.tabBoottom);
		this.splitContainer1.Panel2MinSize = 0;
		this.splitContainer1.Size = new global::System.Drawing.Size(420, 435);
		this.splitContainer1.SplitterDistance = 191;
		this.splitContainer1.TabIndex = 17;
		this.LvGame.AllItems = null;
		this.LvGame.AllowColumnReorder = true;
		this.LvGame.AllowDrop = true;
		this.LvGame.AllowReorder = true;
		this.LvGame.AllowSort = false;
		this.LvGame.CheckBoxes = true;
		this.LvGame.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_4, this.columnHeader_5, this.columnHeader_6, this.columnHeader_7, this.columnHeader_8, this.columnHeader_9, this.columnHeader_10, this.columnHeader_11, this.columnHeader_12, this.columnHeader_13,
			this.columnHeader_14, this.columnHeader_15, this.columnHeader_16, this.columnHeader_17, this.columnHeader_18
		});
		this.LvGame.ContextMenuStrip = this.menuListView;
		this.LvGame.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.LvGame.DoubleClickActivation = false;
		this.LvGame.FullRowSelect = true;
		this.LvGame.GridLines = true;
		this.LvGame.HideSelection = false;
		this.LvGame.LineColor = global::System.Drawing.Color.Red;
		this.LvGame.Location = new global::System.Drawing.Point(0, 0);
		this.LvGame.Name = "LvGame";
		this.LvGame.ShowItemToolTips = true;
		this.LvGame.Size = new global::System.Drawing.Size(420, 191);
		this.LvGame.TabIndex = 14;
		this.LvGame.UseCompatibleStateImageBehavior = false;
		this.LvGame.View = global::System.Windows.Forms.View.Details;
		this.LvGame.VirtualMode = true;
		this.LvGame.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.LvGame_ColumnClick);
		this.LvGame.ColumnReordered += new global::System.Windows.Forms.ColumnReorderedEventHandler(this.LvGame_ColumnReordered);
		this.LvGame.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.LvGame_ItemChecked);
		this.LvGame.RetrieveVirtualItem += new global::System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvGame_RetrieveVirtualItem);
		this.LvGame.SelectedIndexChanged += new global::System.EventHandler(this.LvGame_SelectedIndexChanged);
		this.LvGame.DoubleClick += new global::System.EventHandler(this.LvGame_DoubleClick);
		this.LvGame.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.LvGame_KeyDown);
		this.LvGame.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.LvGame_MouseDown);
		this.LvGame.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.LvGame_MouseMove);
		this.LvGame.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.LvGame_MouseUp);
		this.columnHeader_4.Text = "Name";
		this.columnHeader_4.Width = 80;
		this.columnHeader_5.Text = "Lvl";
		this.columnHeader_5.Width = 32;
		this.columnHeader_6.Text = "Phái";
		this.columnHeader_6.Width = 55;
		this.columnHeader_7.Text = "Status";
		this.columnHeader_7.Width = 42;
		this.columnHeader_8.Text = "HP";
		this.columnHeader_8.Width = 33;
		this.columnHeader_9.Text = "MP";
		this.columnHeader_9.Width = 32;
		this.columnHeader_10.Text = "Pet";
		this.columnHeader_10.Width = 32;
		this.columnHeader_11.Text = "Online";
		this.columnHeader_11.Width = 45;
		this.columnHeader_12.Text = "Exp";
		this.columnHeader_12.Width = 54;
		this.columnHeader_13.Text = "Exp/H";
		this.columnHeader_13.Width = 44;
		this.columnHeader_14.Text = "Vị trí";
		this.columnHeader_14.Width = 70;
		this.columnHeader_15.Text = "Đội Ngũ";
		this.columnHeader_15.Width = 65;
		this.columnHeader_16.Text = "HĐ";
		this.columnHeader_16.Width = 32;
		this.columnHeader_17.Text = "Vàng";
		this.columnHeader_17.Width = 40;
		this.columnHeader_18.Text = "RunTime";
		this.tabBoottom.Controls.Add(this.tabBuff);
		this.tabBoottom.Controls.Add(this.tabQ);
		this.tabBoottom.Controls.Add(this.tabPage1);
		this.tabBoottom.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tabBoottom.ItemSize = new global::System.Drawing.Size(42, 18);
		this.tabBoottom.Location = new global::System.Drawing.Point(0, 0);
		this.tabBoottom.Multiline = true;
		this.tabBoottom.Name = "tabBoottom";
		this.tabBoottom.SelectedIndex = 0;
		this.tabBoottom.Size = new global::System.Drawing.Size(420, 240);
		this.tabBoottom.TabIndex = 0;
		this.tabBuff.Controls.Add(this.myPanel7);
		this.tabBuff.Controls.Add(this.panelEx1);
		this.tabBuff.Controls.Add(this.panelEx4);
		this.tabBuff.Location = new global::System.Drawing.Point(4, 4);
		this.tabBuff.Name = "tabBuff";
		this.tabBuff.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabBuff.Size = new global::System.Drawing.Size(412, 214);
		this.tabBuff.TabIndex = 0;
		this.tabBuff.Text = "Key";
		this.tabBuff.UseVisualStyleBackColor = true;
		this.myPanel7.AutoScroll = true;
		this.myPanel7.Controls.Add(this.lvSkill);
		this.myPanel7.Controls.Add(this.panelEx3);
		this.myPanel7.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.myPanel7.Location = new global::System.Drawing.Point(150, 3);
		this.myPanel7.Name = "myPanel7";
		this.myPanel7.Size = new global::System.Drawing.Size(259, 186);
		this.myPanel7.TabIndex = 445;
		this.lvSkill.AllItems = null;
		this.lvSkill.AllowColumnReorder = true;
		this.lvSkill.AllowDrop = true;
		this.lvSkill.AllowReorder = true;
		this.lvSkill.AllowSort = true;
		this.lvSkill.CheckBoxes = true;
		this.lvSkill.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_24, this.columnHeader_25, this.columnHeader_26 });
		this.lvSkill.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvSkill.DoubleClickActivation = false;
		this.lvSkill.FullRowSelect = true;
		this.lvSkill.GridLines = true;
		this.lvSkill.HideSelection = false;
		this.lvSkill.LineColor = global::System.Drawing.Color.Red;
		this.lvSkill.Location = new global::System.Drawing.Point(0, 20);
		this.lvSkill.Name = "lvSkill";
		this.lvSkill.Size = new global::System.Drawing.Size(259, 166);
		this.lvSkill.TabIndex = 10;
		this.lvSkill.UseCompatibleStateImageBehavior = false;
		this.lvSkill.View = global::System.Windows.Forms.View.Details;
		this.lvSkill.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.lvSkill_ItemChecked);
		this.lvSkill.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.lvSkill_DragDrop);
		this.lvSkill.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.lvSkill_MouseDown);
		this.columnHeader_24.Text = "Name";
		this.columnHeader_24.Width = 144;
		this.columnHeader_25.Text = "PK";
		this.columnHeader_25.Width = 33;
		this.columnHeader_26.Text = "Delay";
		this.columnHeader_26.Width = 39;
		this.panelEx3.Controls.Add(this.checkSkill);
		this.panelEx3.Controls.Add(this.txtSearchName);
		this.panelEx3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panelEx3.Location = new global::System.Drawing.Point(0, 0);
		this.panelEx3.Name = "panelEx3";
		this.panelEx3.Size = new global::System.Drawing.Size(259, 20);
		this.panelEx3.TabIndex = 12;
		this.txtSearchName.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtSearchName.Location = new global::System.Drawing.Point(0, 0);
		this.txtSearchName.Name = "txtSearchName";
		this.txtSearchName.Size = new global::System.Drawing.Size(259, 20);
		this.txtSearchName.TabIndex = 9;
		this.txtSearchName.String_0 = "Search...";
		this.txtSearchName.Color_0 = global::System.Drawing.Color.Gray;
		this.txtSearchName.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtSearchName.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtSearchName.TextChanged += new global::System.EventHandler(this.txtSearchName_TextChanged);
		this.panelEx1.Controls.Add(this.lvFunction);
		this.panelEx1.Controls.Add(this.txtSearchFuntion);
		this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.panelEx1.Location = new global::System.Drawing.Point(3, 3);
		this.panelEx1.Name = "panelEx1";
		this.panelEx1.Size = new global::System.Drawing.Size(147, 186);
		this.panelEx1.TabIndex = 447;
		this.lvFunction.AllItems = null;
		this.lvFunction.AllowColumnReorder = true;
		this.lvFunction.AllowDrop = true;
		this.lvFunction.AllowReorder = true;
		this.lvFunction.AllowSort = false;
		this.lvFunction.CheckBoxes = true;
		this.lvFunction.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_23 });
		this.lvFunction.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvFunction.DoubleClickActivation = false;
		this.lvFunction.FullRowSelect = true;
		this.lvFunction.GridLines = true;
		this.lvFunction.HideSelection = false;
		listViewItem.StateImageIndex = 0;
		listViewItem.Tag = "comeback";
		listViewItem2.StateImageIndex = 0;
		listViewItem2.Tag = "attack";
		listViewItem3.StateImageIndex = 0;
		listViewItem3.Tag = "lure";
		listViewItem4.StateImageIndex = 0;
		listViewItem4.Tag = "attacklist";
		listViewItem5.StateImageIndex = 0;
		listViewItem5.Tag = "fight";
		listViewItem6.StateImageIndex = 0;
		listViewItem6.Tag = "onlypet";
		listViewItem7.StateImageIndex = 0;
		listViewItem7.Tag = "pet";
		listViewItem8.StateImageIndex = 0;
		listViewItem8.Tag = "nm";
		listViewItem9.StateImageIndex = 0;
		listViewItem9.Tag = "mp";
		listViewItem10.StateImageIndex = 0;
		listViewItem10.Tag = "picklist";
		listViewItem11.StateImageIndex = 0;
		listViewItem11.Tag = "giacong";
		listViewItem12.StateImageIndex = 0;
		listViewItem12.Tag = "lvlup";
		listViewItem13.StateImageIndex = 0;
		listViewItem13.Tag = "quayvong";
		listViewItem14.StateImageIndex = 0;
		listViewItem14.Tag = "tulinhngoc";
		listViewItem15.StateImageIndex = 0;
		listViewItem15.Tag = "cankhonho";
		listViewItem16.StateImageIndex = 0;
		listViewItem16.Tag = "pick";
		listViewItem17.StateImageIndex = 0;
		listViewItem17.Tag = "x2";
		listViewItem18.StateImageIndex = 0;
		listViewItem18.Tag = "x4";
		listViewItem19.StateImageIndex = 0;
		listViewItem19.Tag = "x2x3";
		listViewItem20.StateImageIndex = 0;
		listViewItem20.Tag = "keeponline";
		listViewItem21.StateImageIndex = 0;
		listViewItem22.StateImageIndex = 0;
		listViewItem22.Tag = "muangoc";
		listViewItem23.StateImageIndex = 0;
		listViewItem23.Tag = "khongbatlich";
		listViewItem24.StateImageIndex = 0;
		listViewItem24.Tag = "khaikhoang";
		listViewItem25.StateImageIndex = 0;
		listViewItem25.Tag = "haiduoc";
		listViewItem26.StateImageIndex = 0;
		listViewItem26.Tag = "thuthap";
		listViewItem27.StateImageIndex = 0;
		listViewItem27.Tag = "baoinbox";
		listViewItem28.StateImageIndex = 0;
		listViewItem28.Tag = "khaithac";
		this.lvFunction.Items.AddRange(new global::System.Windows.Forms.ListViewItem[]
		{
			listViewItem, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10,
			listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20,
			listViewItem21, listViewItem22, listViewItem23, listViewItem24, listViewItem25, listViewItem26, listViewItem27, listViewItem28
		});
		this.lvFunction.LineColor = global::System.Drawing.Color.Red;
		this.lvFunction.Location = new global::System.Drawing.Point(0, 20);
		this.lvFunction.Name = "lvFunction";
		this.lvFunction.Size = new global::System.Drawing.Size(147, 166);
		this.lvFunction.TabIndex = 15;
		this.lvFunction.UseCompatibleStateImageBehavior = false;
		this.lvFunction.View = global::System.Windows.Forms.View.Details;
		this.lvFunction.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.lvFunction_ItemChecked);
		this.lvFunction.SelectedIndexChanged += new global::System.EventHandler(this.lvFunction_SelectedIndexChanged);
		this.columnHeader_23.Text = "Name";
		this.columnHeader_23.Width = 126;
		this.txtSearchFuntion.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.txtSearchFuntion.Location = new global::System.Drawing.Point(0, 0);
		this.txtSearchFuntion.Name = "txtSearchFuntion";
		this.txtSearchFuntion.Size = new global::System.Drawing.Size(147, 20);
		this.txtSearchFuntion.TabIndex = 446;
		this.txtSearchFuntion.String_0 = "Search...";
		this.txtSearchFuntion.Color_0 = global::System.Drawing.Color.Gray;
		this.txtSearchFuntion.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtSearchFuntion.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtSearchFuntion.TextChanged += new global::System.EventHandler(this.txtSearchFuntion_TextChanged);
		this.panelEx4.Controls.Add(this.txtPass2);
		this.panelEx4.Controls.Add(this.cboLeader);
		this.panelEx4.Controls.Add(this.checkShowPass);
		this.panelEx4.Controls.Add(this.cboMenpai);
		this.panelEx4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panelEx4.Location = new global::System.Drawing.Point(3, 189);
		this.panelEx4.Name = "panelEx4";
		this.panelEx4.Size = new global::System.Drawing.Size(406, 22);
		this.panelEx4.TabIndex = 448;
		this.checkShowPass.AutoSize = true;
		this.checkShowPass.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkShowPass.Location = new global::System.Drawing.Point(391, 0);
		this.checkShowPass.Name = "checkShowPass";
		this.checkShowPass.Size = new global::System.Drawing.Size(15, 22);
		this.checkShowPass.TabIndex = 216;
		this.checkShowPass.UseVisualStyleBackColor = true;
		this.checkShowPass.CheckedChanged += new global::System.EventHandler(this.checkShowPass_CheckedChanged);
		this.tabQ.Controls.Add(this.myPanel2);
		this.tabQ.Location = new global::System.Drawing.Point(4, 4);
		this.tabQ.Name = "tabQ";
		this.tabQ.Size = new global::System.Drawing.Size(412, 214);
		this.tabQ.TabIndex = 3;
		this.tabQ.Text = "Life";
		this.tabQ.UseVisualStyleBackColor = true;
		this.myPanel2.Controls.Add(this.myPanel5);
		this.myPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.myPanel2.Location = new global::System.Drawing.Point(0, 0);
		this.myPanel2.Name = "myPanel2";
		this.myPanel2.Size = new global::System.Drawing.Size(412, 214);
		this.myPanel2.TabIndex = 341;
		this.myPanel5.AutoScroll = true;
		this.myPanel5.Controls.Add(this.panelEx5);
		this.myPanel5.Controls.Add(this.panelEx2);
		this.myPanel5.Controls.Add(this.panel8);
		this.myPanel5.Controls.Add(this.panel9);
		this.myPanel5.Controls.Add(this.panel2);
		this.myPanel5.Controls.Add(this.splitContainer2);
		this.myPanel5.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.myPanel5.Location = new global::System.Drawing.Point(0, 0);
		this.myPanel5.Name = "myPanel5";
		this.myPanel5.Size = new global::System.Drawing.Size(412, 214);
		this.myPanel5.TabIndex = 378;
		this.panelEx5.Controls.Add(this.panel1);
		this.panelEx5.Controls.Add(this.grNM);
		this.panelEx5.Controls.Add(this.panel5);
		this.panelEx5.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panelEx5.Location = new global::System.Drawing.Point(200, 107);
		this.panelEx5.Name = "panelEx5";
		this.panelEx5.Size = new global::System.Drawing.Size(212, 107);
		this.panelEx5.TabIndex = 449;
		this.panel1.Controls.Add(this.cboPhu);
		this.panel1.Controls.Add(this.checkAutoPhu);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new global::System.Drawing.Point(0, 42);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(212, 22);
		this.panel1.TabIndex = 448;
		this.cboPhu.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboPhu.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboPhu.FormattingEnabled = true;
		this.cboPhu.Items.AddRange(new object[]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15"
		});
		this.cboPhu.Location = new global::System.Drawing.Point(72, 0);
		this.cboPhu.Name = "cboPhu";
		this.cboPhu.Size = new global::System.Drawing.Size(79, 21);
		this.cboPhu.TabIndex = 343;
		this.cboPhu.TabStop = false;
		this.checkAutoPhu.AutoSize = true;
		this.checkAutoPhu.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkAutoPhu.Location = new global::System.Drawing.Point(0, 0);
		this.checkAutoPhu.Name = "checkAutoPhu";
		this.checkAutoPhu.Padding = new global::System.Windows.Forms.Padding(2, 0, 0, 0);
		this.checkAutoPhu.Size = new global::System.Drawing.Size(72, 22);
		this.checkAutoPhu.TabIndex = 346;
		this.checkAutoPhu.Text = "Auto Phù";
		this.checkAutoPhu.UseVisualStyleBackColor = true;
		this.checkAutoPhu.CheckedChanged += new global::System.EventHandler(this.checkAutoPhu_CheckedChanged);
		this.grNM.Controls.Add(this.numberNM);
		this.grNM.Controls.Add(this.checkNM);
		this.grNM.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.grNM.Location = new global::System.Drawing.Point(0, 22);
		this.grNM.Name = "grNM";
		this.grNM.Padding = new global::System.Windows.Forms.Padding(0, 2, 0, 0);
		this.grNM.Size = new global::System.Drawing.Size(212, 20);
		this.grNM.TabIndex = 447;
		this.numberNM.BackColor = global::System.Drawing.Color.Transparent;
		this.numberNM.Color_4 = global::System.Drawing.Color.Red;
		this.numberNM.Size_1 = new global::System.Drawing.Size(8, 8);
		this.numberNM.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.numberNM.UInt32_1 = 5U;
		this.numberNM.Location = new global::System.Drawing.Point(72, 2);
		this.numberNM.Name = "numberNM";
		this.numberNM.Size = new global::System.Drawing.Size(140, 18);
		this.numberNM.UInt32_0 = 1U;
		this.numberNM.TabIndex = 0;
		this.numberNM.Text = "colorSlider2";
		this.numberNM.Size_0 = new global::System.Drawing.Size(8, 8);
		this.numberNM.Int32_1 = 90;
		this.numberNM.Event_0 += new global::System.EventHandler(this.method_53);
		this.checkNM.AutoSize = true;
		this.checkNM.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkNM.Location = new global::System.Drawing.Point(0, 2);
		this.checkNM.Margin = new global::System.Windows.Forms.Padding(0);
		this.checkNM.Name = "checkNM";
		this.checkNM.Padding = new global::System.Windows.Forms.Padding(4, 1, 0, 0);
		this.checkNM.Size = new global::System.Drawing.Size(72, 18);
		this.checkNM.TabIndex = 0;
		this.checkNM.Text = "90% Buff";
		this.checkNM.UseVisualStyleBackColor = true;
		this.checkNM.CheckedChanged += new global::System.EventHandler(this.checkNM_CheckedChanged);
		this.panel5.Controls.Add(this.cboPoint);
		this.panel5.Controls.Add(this.btnAddPoint);
		this.panel5.Controls.Add(this.numberPoint);
		this.panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel5.Location = new global::System.Drawing.Point(0, 0);
		this.panel5.Name = "panel5";
		this.panel5.Size = new global::System.Drawing.Size(212, 22);
		this.panel5.TabIndex = 15;
		this.cboPoint.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.cboPoint.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboPoint.FormattingEnabled = true;
		this.cboPoint.Items.AddRange(new object[] { "Thể Lực", "Thân Pháp", "Nội Lực", "Cường Lực", "Trí Lực" });
		this.cboPoint.Location = new global::System.Drawing.Point(58, 0);
		this.cboPoint.Name = "cboPoint";
		this.cboPoint.Size = new global::System.Drawing.Size(92, 21);
		this.cboPoint.TabIndex = 243;
		this.btnAddPoint.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnAddPoint.Location = new global::System.Drawing.Point(150, 0);
		this.btnAddPoint.Name = "btnAddPoint";
		this.btnAddPoint.Size = new global::System.Drawing.Size(62, 22);
		this.btnAddPoint.TabIndex = 0;
		this.btnAddPoint.Text = "+ Điểm";
		this.btnAddPoint.UseVisualStyleBackColor = true;
		this.btnAddPoint.Click += new global::System.EventHandler(this.btnAddPoint_Click);
		this.numberPoint.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.numberPoint.Location = new global::System.Drawing.Point(0, 0);
		global::System.Windows.Forms.NumericUpDown numericUpDown = this.numberPoint;
		int[] array = new int[4];
		array[0] = 999999;
		numericUpDown.Maximum = new decimal(array);
		this.numberPoint.Name = "numberPoint";
		this.numberPoint.Size = new global::System.Drawing.Size(58, 20);
		this.numberPoint.TabIndex = 246;
		global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numberPoint;
		int[] array2 = new int[4];
		array2[0] = 75;
		numericUpDown2.Value = new decimal(array2);
		this.panelEx2.Controls.Add(this.checkRadius);
		this.panelEx2.Controls.Add(this.cboPet);
		this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.panelEx2.Location = new global::System.Drawing.Point(0, 107);
		this.panelEx2.Name = "panelEx2";
		this.panelEx2.Size = new global::System.Drawing.Size(200, 107);
		this.panelEx2.TabIndex = 448;
		this.checkRadius.Boolean_2 = false;
		this.checkRadius.Boolean_0 = false;
		this.checkRadius.Dock = global::System.Windows.Forms.DockStyle.Top;
		global::CheckBoxNumberControl checkBoxNumberControl = this.checkRadius;
		int[] array3 = new int[4];
		array3[0] = 1;
		checkBoxNumberControl.Decimal_3 = new decimal(array3);
		this.checkRadius.Location = new global::System.Drawing.Point(0, 23);
		this.checkRadius.Margin = new global::System.Windows.Forms.Padding(0);
		global::CheckBoxNumberControl checkBoxNumberControl2 = this.checkRadius;
		int[] array4 = new int[4];
		array4[0] = 100;
		checkBoxNumberControl2.Decimal_2 = new decimal(array4);
		this.checkRadius.Decimal_1 = new decimal(new int[4]);
		this.checkRadius.Name = "checkRadius";
		this.checkRadius.Boolean_1 = true;
		this.checkRadius.Padding = new global::System.Windows.Forms.Padding(4, 0, 0, 0);
		this.checkRadius.Size = new global::System.Drawing.Size(200, 20);
		this.checkRadius.TabIndex = 445;
		this.checkRadius.Text = "Bán Kính";
		this.checkRadius.Decimal_0 = new decimal(new int[4]);
		this.checkRadius.Event_0 += new global::System.EventHandler(this.method_68);
		this.checkRadius.Event_1 += new global::System.EventHandler(this.method_69);
		this.cboPet.Boolean_0 = false;
		this.cboPet.String_0 = "";
		this.cboPet.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.cboPet.ComboBoxStyle_0 = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboPet.Location = new global::System.Drawing.Point(0, 0);
		this.cboPet.Margin = new global::System.Windows.Forms.Padding(0);
		this.cboPet.Name = "cboPet";
		this.cboPet.Padding = new global::System.Windows.Forms.Padding(4, 0, 0, 0);
		this.cboPet.Int32_0 = -1;
		this.cboPet.Object_0 = null;
		this.cboPet.Size = new global::System.Drawing.Size(200, 23);
		this.cboPet.TabIndex = 446;
		this.cboPet.Text = "Pet    ";
		this.cboPet.Event_0 += new global::System.EventHandler(this.method_66);
		this.cboPet.Event_1 += new global::System.EventHandler(this.method_65);
		this.cboPet.Load += new global::System.EventHandler(this.cboPet_Load);
		this.panel8.Controls.Add(this.panel24);
		this.panel8.Controls.Add(this.cboTrongTrot);
		this.panel8.Controls.Add(this.checkTrongTrot);
		this.panel8.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel8.Location = new global::System.Drawing.Point(0, 85);
		this.panel8.Name = "panel8";
		this.panel8.Size = new global::System.Drawing.Size(412, 22);
		this.panel8.TabIndex = 16;
		this.panel24.Controls.Add(this.txtJoindGuildId);
		this.panel24.Controls.Add(this.btnJoinGuild);
		this.panel24.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel24.Location = new global::System.Drawing.Point(195, 0);
		this.panel24.Name = "panel24";
		this.panel24.Size = new global::System.Drawing.Size(217, 22);
		this.panel24.TabIndex = 377;
		this.txtJoindGuildId.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.txtJoindGuildId.Location = new global::System.Drawing.Point(63, 0);
		this.txtJoindGuildId.Name = "txtJoindGuildId";
		this.txtJoindGuildId.Size = new global::System.Drawing.Size(92, 20);
		this.txtJoindGuildId.TabIndex = 1;
		this.txtJoindGuildId.String_0 = "ID Bang";
		this.txtJoindGuildId.Color_0 = global::System.Drawing.Color.Gray;
		this.txtJoindGuildId.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtJoindGuildId.Color_1 = global::System.Drawing.Color.LightGray;
		this.btnJoinGuild.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnJoinGuild.Location = new global::System.Drawing.Point(155, 0);
		this.btnJoinGuild.Name = "btnJoinGuild";
		this.btnJoinGuild.Size = new global::System.Drawing.Size(62, 22);
		this.btnJoinGuild.TabIndex = 0;
		this.btnJoinGuild.Text = "Vào";
		this.btnJoinGuild.UseVisualStyleBackColor = true;
		this.btnJoinGuild.Click += new global::System.EventHandler(this.btnJoinGuild_Click);
		this.cboTrongTrot.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboTrongTrot.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboTrongTrot.FormattingEnabled = true;
		this.cboTrongTrot.Items.AddRange(new object[]
		{
			"Lúa Mì - Sớm", "Gạo - Sớm", "Ngô - Sớm", "Đậu Phụng - Sớm", "Khoai Lang - Sớm", "Cao Lương - Sớm", "Mè - Sớm", "Đậu Xanh - Sớm", "Đậu Nành - Sớm", "Đậu Tằm - Sớm",
			"Khoai Tây - Sớm", "Khoai Môn - Sớm", "Cây Gai - Sớm", "Bông Cỏ - Sớm", "Cây Lanh - Sớm", "Cây Gạo - Sớm", "Cây Đay - Sớm", "Gấm Hoa - Sớm", "Đay Cẩn - Sớm", "Gấm Nhung - Sớm",
			"Cây Đay - Sớm", "Thái Miên - Sớm", "Đay La Bố - Sớm", "Bông Trên Cạn - Sớm", "Lúa Mì - Muộn", "Gạo - Muộn", "Ngô - Muộn", "Đâu Phụng - Muộn", "Khoai Lang - Muộn", "Cao Lương - Muộn",
			"Mè - Muộn", "Đậu Xanh - Muộn", "Đậu Nành - Muộn", "Đậu Tằm - Muộn", "Khoai Tây - Muộn", "Khoai Tây - Muộn", "Cây Gai - Muộn", "Bông Cỏ - Muộn", "Cây Lanh - Muộn", "Cây Gạo - Muộn",
			"Cây Đay - Muộn", "Gấm Hoa - Muộn", "Đay Cần - Muộn", "Gấm Nhung - Muộn", "Cây Đay - Muộn", "Thái Miên - Muộn", "Đay La Bố - Muộn", "Bông Trên Cạn - Muộn"
		});
		this.cboTrongTrot.Location = new global::System.Drawing.Point(58, 0);
		this.cboTrongTrot.Name = "cboTrongTrot";
		this.cboTrongTrot.Size = new global::System.Drawing.Size(137, 21);
		this.cboTrongTrot.TabIndex = 229;
		this.cboTrongTrot.SelectedIndexChanged += new global::System.EventHandler(this.cboTrongTrot_SelectedIndexChanged);
		this.checkTrongTrot.AutoSize = true;
		this.checkTrongTrot.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkTrongTrot.Location = new global::System.Drawing.Point(0, 0);
		this.checkTrongTrot.Name = "checkTrongTrot";
		this.checkTrongTrot.Padding = new global::System.Windows.Forms.Padding(4, 0, 0, 0);
		this.checkTrongTrot.Size = new global::System.Drawing.Size(58, 22);
		this.checkTrongTrot.TabIndex = 0;
		this.checkTrongTrot.Text = "Trồng";
		this.checkTrongTrot.UseVisualStyleBackColor = true;
		this.checkTrongTrot.CheckedChanged += new global::System.EventHandler(this.checkTrongTrot_CheckedChanged);
		this.panel9.Controls.Add(this.txtRao);
		this.panel9.Controls.Add(this.button6);
		this.panel9.Controls.Add(this.chkRaoVat);
		this.panel9.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel9.Location = new global::System.Drawing.Point(0, 64);
		this.panel9.Margin = new global::System.Windows.Forms.Padding(1);
		this.panel9.Name = "panel9";
		this.panel9.Padding = new global::System.Windows.Forms.Padding(3, 0, 0, 0);
		this.panel9.Size = new global::System.Drawing.Size(412, 21);
		this.panel9.TabIndex = 340;
		this.txtRao.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtRao.Location = new global::System.Drawing.Point(57, 0);
		this.txtRao.Name = "txtRao";
		this.txtRao.Size = new global::System.Drawing.Size(331, 20);
		this.txtRao.TabIndex = 177;
		this.txtRao.String_0 = "";
		this.txtRao.Color_0 = global::System.Drawing.Color.Gray;
		this.txtRao.Font_0 = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtRao.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtRao.TextChanged += new global::System.EventHandler(this.txtRao_TextChanged);
		this.button6.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button6.Location = new global::System.Drawing.Point(388, 0);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(24, 21);
		this.button6.TabIndex = 336;
		this.button6.Text = "#";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new global::System.EventHandler(this.button6_Click);
		this.chkRaoVat.AutoSize = true;
		this.chkRaoVat.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.chkRaoVat.ForeColor = global::System.Drawing.Color.Black;
		this.chkRaoVat.Location = new global::System.Drawing.Point(3, 0);
		this.chkRaoVat.Name = "chkRaoVat";
		this.chkRaoVat.Padding = new global::System.Windows.Forms.Padding(1, 0, 0, 0);
		this.chkRaoVat.Size = new global::System.Drawing.Size(54, 21);
		this.chkRaoVat.TabIndex = 175;
		this.chkRaoVat.Text = "Talk  ";
		this.chkRaoVat.UseVisualStyleBackColor = true;
		this.chkRaoVat.CheckedChanged += new global::System.EventHandler(this.chkRaoVat_CheckedChanged);
		this.panel2.Controls.Add(this.lblTrader);
		this.panel2.Controls.Add(this.lblCityName);
		this.panel2.Controls.Add(this.lblFriendCityName);
		this.panel2.Controls.Add(this.button2);
		this.panel2.Controls.Add(this.button4);
		this.panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel2.Location = new global::System.Drawing.Point(0, 42);
		this.panel2.Name = "panel2";
		this.panel2.Size = new global::System.Drawing.Size(412, 22);
		this.panel2.TabIndex = 4;
		this.lblTrader.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblTrader.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lblTrader.Location = new global::System.Drawing.Point(160, 0);
		this.lblTrader.Name = "lblTrader";
		this.lblTrader.Size = new global::System.Drawing.Size(92, 22);
		this.lblTrader.TabIndex = 3;
		this.lblTrader.Text = "<- Trader ->";
		this.lblTrader.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblTrader.Click += new global::System.EventHandler(this.lblTrader_Click);
		this.lblCityName.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblCityName.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.lblCityName.Location = new global::System.Drawing.Point(30, 0);
		this.lblCityName.Name = "lblCityName";
		this.lblCityName.Size = new global::System.Drawing.Size(130, 22);
		this.lblCityName.TabIndex = 2;
		this.lblCityName.Text = "[None]";
		this.lblCityName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblCityName.Click += new global::System.EventHandler(this.lblCityName_Click);
		this.lblFriendCityName.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.lblFriendCityName.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.lblFriendCityName.Location = new global::System.Drawing.Point(252, 0);
		this.lblFriendCityName.Name = "lblFriendCityName";
		this.lblFriendCityName.Size = new global::System.Drawing.Size(130, 22);
		this.lblFriendCityName.TabIndex = 2;
		this.lblFriendCityName.Text = "[None]";
		this.lblFriendCityName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.lblFriendCityName.Click += new global::System.EventHandler(this.lblFriendCityName_Click);
		this.button2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.button2.Location = new global::System.Drawing.Point(0, 0);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(30, 22);
		this.button2.TabIndex = 4;
		this.button2.Text = "<-";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button4.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button4.Location = new global::System.Drawing.Point(382, 0);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(30, 22);
		this.button4.TabIndex = 5;
		this.button4.Text = "->";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer2.Name = "splitContainer2";
		this.splitContainer2.Panel1.Controls.Add(this.panel4);
		this.splitContainer2.Panel2.Controls.Add(this.panel12);
		this.splitContainer2.Size = new global::System.Drawing.Size(412, 42);
		this.splitContainer2.SplitterDistance = 206;
		this.splitContainer2.TabIndex = 15;
		this.panel4.Controls.Add(this.panel11);
		this.panel4.Controls.Add(this.cboTrangBi);
		this.panel4.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel4.Location = new global::System.Drawing.Point(0, 0);
		this.panel4.Name = "panel4";
		this.panel4.Size = new global::System.Drawing.Size(206, 42);
		this.panel4.TabIndex = 447;
		this.panel11.Controls.Add(this.btnDuc);
		this.panel11.Controls.Add(this.btnKham);
		this.panel11.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel11.Location = new global::System.Drawing.Point(0, 21);
		this.panel11.Name = "panel11";
		this.panel11.Size = new global::System.Drawing.Size(206, 21);
		this.panel11.TabIndex = 2;
		this.btnDuc.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnDuc.Location = new global::System.Drawing.Point(126, 0);
		this.btnDuc.Name = "btnDuc";
		this.btnDuc.Size = new global::System.Drawing.Size(80, 21);
		this.btnDuc.TabIndex = 0;
		this.btnDuc.Text = "Đục";
		this.btnDuc.UseVisualStyleBackColor = true;
		this.btnDuc.Click += new global::System.EventHandler(this.btnDuc_Click);
		this.btnKham.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.btnKham.Location = new global::System.Drawing.Point(0, 0);
		this.btnKham.Name = "btnKham";
		this.btnKham.Size = new global::System.Drawing.Size(80, 21);
		this.btnKham.TabIndex = 0;
		this.btnKham.Text = "Khảm";
		this.btnKham.UseVisualStyleBackColor = true;
		this.btnKham.Click += new global::System.EventHandler(this.btnKham_Click);
		this.cboTrangBi.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.cboTrangBi.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboTrangBi.FormattingEnabled = true;
		this.cboTrangBi.Location = new global::System.Drawing.Point(0, 0);
		this.cboTrangBi.Name = "cboTrangBi";
		this.cboTrangBi.Size = new global::System.Drawing.Size(206, 21);
		this.cboTrangBi.TabIndex = 1;
		this.cboTrangBi.DropDown += new global::System.EventHandler(this.cboTrangBi_DropDown);
		this.panel12.Controls.Add(this.btnTrac);
		this.panel12.Controls.Add(this.btnHop);
		this.panel12.Controls.Add(this.cboGem);
		this.panel12.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel12.Location = new global::System.Drawing.Point(0, 0);
		this.panel12.Name = "panel12";
		this.panel12.Size = new global::System.Drawing.Size(202, 42);
		this.panel12.TabIndex = 448;
		this.btnTrac.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.btnTrac.Location = new global::System.Drawing.Point(0, 21);
		this.btnTrac.Name = "btnTrac";
		this.btnTrac.Size = new global::System.Drawing.Size(80, 21);
		this.btnTrac.TabIndex = 1;
		this.btnTrac.Text = "Trác";
		this.btnTrac.UseVisualStyleBackColor = true;
		this.btnTrac.Click += new global::System.EventHandler(this.btnTrac_Click);
		this.btnHop.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnHop.Location = new global::System.Drawing.Point(122, 21);
		this.btnHop.Name = "btnHop";
		this.btnHop.Size = new global::System.Drawing.Size(80, 21);
		this.btnHop.TabIndex = 0;
		this.btnHop.Text = "Hợp";
		this.btnHop.UseVisualStyleBackColor = true;
		this.btnHop.Click += new global::System.EventHandler(this.btnHop_Click);
		this.cboGem.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.cboGem.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboGem.FormattingEnabled = true;
		this.cboGem.Location = new global::System.Drawing.Point(0, 0);
		this.cboGem.Name = "cboGem";
		this.cboGem.Size = new global::System.Drawing.Size(202, 21);
		this.cboGem.TabIndex = 2;
		this.cboGem.DropDown += new global::System.EventHandler(this.cboGem_DropDown);
		this.tabPage1.Controls.Add(this.checkHuyCraft);
		this.tabPage1.Controls.Add(this.panel10);
		this.tabPage1.Location = new global::System.Drawing.Point(4, 4);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new global::System.Drawing.Size(412, 214);
		this.tabPage1.TabIndex = 4;
		this.tabPage1.Text = "Craft";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.checkHuyCraft.Boolean_0 = false;
		this.checkHuyCraft.CheckState_0 = global::System.Windows.Forms.CheckState.Unchecked;
		this.checkHuyCraft.Controls.Add(this.numHuyCraftLine);
		this.checkHuyCraft.Controls.Add(this.numHuyCraftStar);
		this.checkHuyCraft.Controls.Add(this.label2);
		this.checkHuyCraft.Controls.Add(this.label1);
		this.checkHuyCraft.Boolean_1 = false;
		this.checkHuyCraft.Location = new global::System.Drawing.Point(3, 25);
		this.checkHuyCraft.Name = "checkHuyCraft";
		this.checkHuyCraft.Size = new global::System.Drawing.Size(141, 74);
		this.checkHuyCraft.TabIndex = 18;
		this.checkHuyCraft.TabStop = false;
		this.checkHuyCraft.Text = "Hủy Trang Bị";
		this.checkHuyCraft.Event_0 += new global::System.EventHandler(this.method_79);
		this.numHuyCraftLine.Location = new global::System.Drawing.Point(85, 45);
		this.numHuyCraftLine.Name = "numHuyCraftLine";
		this.numHuyCraftLine.Size = new global::System.Drawing.Size(36, 20);
		this.numHuyCraftLine.TabIndex = 4;
		this.numHuyCraftLine.ValueChanged += new global::System.EventHandler(this.numHuyCraftLine_ValueChanged);
		this.numHuyCraftStar.Location = new global::System.Drawing.Point(85, 19);
		this.numHuyCraftStar.Name = "numHuyCraftStar";
		this.numHuyCraftStar.Size = new global::System.Drawing.Size(36, 20);
		this.numHuyCraftStar.TabIndex = 3;
		this.numHuyCraftStar.ValueChanged += new global::System.EventHandler(this.numHuyCraftStar_ValueChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(7, 47);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(58, 13);
		this.label2.TabIndex = 2;
		this.label2.Text = "Số Dòng <";
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(7, 21);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(51, 13);
		this.label1.TabIndex = 1;
		this.label1.Text = "Số Sao <";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.panel10.Controls.Add(this.panel14);
		this.panel10.Controls.Add(this.cboDaTaoDo);
		this.panel10.Controls.Add(this.cboCheNoiNgoai);
		this.panel10.Controls.Add(this.checkCraft);
		this.panel10.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel10.Location = new global::System.Drawing.Point(3, 3);
		this.panel10.Name = "panel10";
		this.panel10.Size = new global::System.Drawing.Size(406, 22);
		this.panel10.TabIndex = 17;
		this.panel14.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel14.Location = new global::System.Drawing.Point(258, 0);
		this.panel14.Name = "panel14";
		this.panel14.Padding = new global::System.Windows.Forms.Padding(3, 0, 0, 0);
		this.panel14.Size = new global::System.Drawing.Size(148, 22);
		this.panel14.TabIndex = 347;
		this.cboDaTaoDo.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboDaTaoDo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboDaTaoDo.FormattingEnabled = true;
		this.cboDaTaoDo.Items.AddRange(new object[] { "Nội", "Mix", "Ngoại" });
		this.cboDaTaoDo.Location = new global::System.Drawing.Point(121, 0);
		this.cboDaTaoDo.Name = "cboDaTaoDo";
		this.cboDaTaoDo.Size = new global::System.Drawing.Size(137, 21);
		this.cboDaTaoDo.TabIndex = 351;
		this.cboDaTaoDo.DropDown += new global::System.EventHandler(this.cboDaTaoDo_DropDown);
		this.cboDaTaoDo.SelectedIndexChanged += new global::System.EventHandler(this.cboDaTaoDo_SelectedIndexChanged);
		this.cboCheNoiNgoai.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.cboCheNoiNgoai.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cboCheNoiNgoai.FormattingEnabled = true;
		this.cboCheNoiNgoai.Items.AddRange(new object[] { "Nội", "Mix", "Ngoại" });
		this.cboCheNoiNgoai.Location = new global::System.Drawing.Point(58, 0);
		this.cboCheNoiNgoai.Name = "cboCheNoiNgoai";
		this.cboCheNoiNgoai.Size = new global::System.Drawing.Size(63, 21);
		this.cboCheNoiNgoai.TabIndex = 8;
		this.cboCheNoiNgoai.SelectedIndexChanged += new global::System.EventHandler(this.cboCheNoiNgoai_SelectedIndexChanged);
		this.checkCraft.AutoSize = true;
		this.checkCraft.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.checkCraft.Location = new global::System.Drawing.Point(0, 0);
		this.checkCraft.Name = "checkCraft";
		this.checkCraft.Padding = new global::System.Windows.Forms.Padding(4, 0, 0, 0);
		this.checkCraft.Size = new global::System.Drawing.Size(58, 22);
		this.checkCraft.TabIndex = 0;
		this.checkCraft.Text = "Chế   ";
		this.checkCraft.UseVisualStyleBackColor = true;
		this.checkCraft.CheckedChanged += new global::System.EventHandler(this.checkCraft_CheckedChanged);
		this.panel17.Controls.Add(this.txtMainSearch);
		this.panel17.Controls.Add(this.checkPanel);
		this.panel17.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel17.Location = new global::System.Drawing.Point(3, 3);
		this.panel17.Name = "panel17";
		this.panel17.Size = new global::System.Drawing.Size(420, 20);
		this.panel17.TabIndex = 15;
		this.txtMainSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtMainSearch.Location = new global::System.Drawing.Point(0, 0);
		this.txtMainSearch.Name = "txtMainSearch";
		this.txtMainSearch.Size = new global::System.Drawing.Size(405, 20);
		this.txtMainSearch.TabIndex = 10;
		this.txtMainSearch.String_0 = "Search...";
		this.txtMainSearch.Color_0 = global::System.Drawing.Color.DimGray;
		this.txtMainSearch.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtMainSearch.Color_1 = global::System.Drawing.Color.DimGray;
		this.txtMainSearch.TextChanged += new global::System.EventHandler(this.txtMainSearch_TextChanged);
		this.tabiLogin.BackColor = global::System.Drawing.Color.White;
		this.tabiLogin.Controls.Add(this.tabLogin);
		this.tabiLogin.Location = new global::System.Drawing.Point(4, 22);
		this.tabiLogin.Name = "tabiLogin";
		this.tabiLogin.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabiLogin.Size = new global::System.Drawing.Size(426, 461);
		this.tabiLogin.TabIndex = 1;
		this.tabiLogin.Text = "Login";
		this.tabLogin.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tabLogin.ItemSize = new global::System.Drawing.Size(42, 18);
		this.tabLogin.Location = new global::System.Drawing.Point(3, 3);
		this.tabLogin.Name = "tabLogin";
		this.tabLogin.SelectedIndex = 0;
		this.tabLogin.Size = new global::System.Drawing.Size(420, 455);
		this.tabLogin.TabIndex = 46;
		this.tabPay.BackColor = global::System.Drawing.Color.White;
		this.tabPay.Controls.Add(this.myPanel3);
		this.tabPay.Controls.Add(this.myPanel1);
		this.tabPay.Controls.Add(this.button1);
		this.tabPay.Location = new global::System.Drawing.Point(4, 22);
		this.tabPay.Name = "tabPay";
		this.tabPay.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabPay.Size = new global::System.Drawing.Size(426, 461);
		this.tabPay.TabIndex = 7;
		this.tabPay.Text = "Pay";
		this.myPanel3.Controls.Add(this.picQr);
		this.myPanel3.Controls.Add(this.txtHWID);
		this.myPanel3.Controls.Add(this.button5);
		this.myPanel3.Controls.Add(this.txtiAutoUser);
		this.myPanel3.Controls.Add(this.btnRefresh);
		this.myPanel3.Controls.Add(this.button12);
		this.myPanel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.myPanel3.Location = new global::System.Drawing.Point(203, 3);
		this.myPanel3.Name = "myPanel3";
		this.myPanel3.Size = new global::System.Drawing.Size(220, 432);
		this.myPanel3.TabIndex = 186;
		this.picQr.ContextMenuStrip = this.menuQr;
		this.picQr.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.picQr.Location = new global::System.Drawing.Point(0, 0);
		this.picQr.Name = "picQr";
		this.picQr.Size = new global::System.Drawing.Size(220, 326);
		this.picQr.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.picQr.TabIndex = 189;
		this.picQr.TabStop = false;
		this.txtHWID.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtHWID.Location = new global::System.Drawing.Point(0, 326);
		this.txtHWID.Name = "txtHWID";
		this.txtHWID.ReadOnly = true;
		this.txtHWID.Size = new global::System.Drawing.Size(220, 20);
		this.txtHWID.TabIndex = 192;
		this.txtHWID.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.txtHWID.String_0 = "iAutoUser";
		this.txtHWID.Color_0 = global::System.Drawing.Color.Gray;
		this.txtHWID.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtHWID.Color_1 = global::System.Drawing.Color.LightGray;
		this.button5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.button5.Location = new global::System.Drawing.Point(0, 346);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(220, 22);
		this.button5.TabIndex = 191;
		this.button5.Text = "+365 Days  -  1.000.000 Chip";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.txtiAutoUser.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtiAutoUser.Location = new global::System.Drawing.Point(0, 368);
		this.txtiAutoUser.Name = "txtiAutoUser";
		this.txtiAutoUser.ReadOnly = true;
		this.txtiAutoUser.Size = new global::System.Drawing.Size(220, 20);
		this.txtiAutoUser.TabIndex = 190;
		this.txtiAutoUser.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.txtiAutoUser.String_0 = "iAutoUser";
		this.txtiAutoUser.Color_0 = global::System.Drawing.Color.Gray;
		this.txtiAutoUser.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtiAutoUser.Color_1 = global::System.Drawing.Color.LightGray;
		this.btnRefresh.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
		this.btnRefresh.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnRefresh.FlatAppearance.BorderSize = 0;
		this.btnRefresh.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
		this.btnRefresh.Location = new global::System.Drawing.Point(0, 388);
		this.btnRefresh.Name = "btnRefresh";
		this.btnRefresh.Size = new global::System.Drawing.Size(220, 22);
		this.btnRefresh.TabIndex = 170;
		this.btnRefresh.Text = "Refresh";
		this.btnRefresh.UseVisualStyleBackColor = false;
		this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
		this.button12.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.button12.Location = new global::System.Drawing.Point(0, 410);
		this.button12.Name = "button12";
		this.button12.Size = new global::System.Drawing.Size(220, 22);
		this.button12.TabIndex = 187;
		this.button12.Text = "+20 Days  -  99.000 Chip";
		this.button12.UseVisualStyleBackColor = true;
		this.button12.Click += new global::System.EventHandler(this.button12_Click);
		this.myPanel1.Controls.Add(this.linkLabel1);
		this.myPanel1.Controls.Add(this.groupBox9);
		this.myPanel1.Controls.Add(this.lblIncome);
		this.myPanel1.Controls.Add(this.btnBlance);
		this.myPanel1.Controls.Add(this.btnDayVNG);
		this.myPanel1.Controls.Add(this.btnDayPRI);
		this.myPanel1.Controls.Add(this.btnDayORI);
		this.myPanel1.Controls.Add(this.groupBox2);
		this.myPanel1.Controls.Add(this.groupBox1);
		this.myPanel1.Controls.Add(this.groupBox8);
		this.myPanel1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.myPanel1.Location = new global::System.Drawing.Point(3, 3);
		this.myPanel1.Name = "myPanel1";
		this.myPanel1.Size = new global::System.Drawing.Size(200, 432);
		this.myPanel1.TabIndex = 185;
		this.linkLabel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.linkLabel1.LinkBehavior = global::System.Windows.Forms.LinkBehavior.HoverUnderline;
		this.linkLabel1.Location = new global::System.Drawing.Point(0, 301);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new global::System.Drawing.Size(200, 23);
		this.linkLabel1.TabIndex = 192;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Join Zalo Group";
		this.linkLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		this.groupBox9.Controls.Add(this.txtBetChip);
		this.groupBox9.Controls.Add(this.button14);
		this.groupBox9.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox9.Location = new global::System.Drawing.Point(0, 140);
		this.groupBox9.Name = "groupBox9";
		this.groupBox9.Size = new global::System.Drawing.Size(200, 40);
		this.groupBox9.TabIndex = 185;
		this.groupBox9.TabStop = false;
		this.groupBox9.Text = "50%";
		this.txtBetChip.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtBetChip.Location = new global::System.Drawing.Point(3, 16);
		this.txtBetChip.Name = "txtBetChip";
		this.txtBetChip.Size = new global::System.Drawing.Size(126, 20);
		this.txtBetChip.TabIndex = 169;
		this.txtBetChip.String_0 = "Chip";
		this.txtBetChip.Color_0 = global::System.Drawing.Color.Gray;
		this.txtBetChip.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtBetChip.Color_1 = global::System.Drawing.Color.LightGray;
		this.button14.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button14.Location = new global::System.Drawing.Point(129, 16);
		this.button14.Name = "button14";
		this.button14.Size = new global::System.Drawing.Size(68, 21);
		this.button14.TabIndex = 0;
		this.button14.Text = "x2 Chip";
		this.button14.UseVisualStyleBackColor = true;
		this.button14.Click += new global::System.EventHandler(this.button14_Click);
		this.lblIncome.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.lblIncome.Location = new global::System.Drawing.Point(0, 324);
		this.lblIncome.Name = "lblIncome";
		this.lblIncome.Size = new global::System.Drawing.Size(200, 20);
		this.lblIncome.TabIndex = 188;
		this.lblIncome.Text = "10% lãi hàng năm, trả theo phút";
		this.lblIncome.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.btnBlance.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnBlance.Enabled = false;
		this.btnBlance.Location = new global::System.Drawing.Point(0, 344);
		this.btnBlance.Name = "btnBlance";
		this.btnBlance.Size = new global::System.Drawing.Size(200, 22);
		this.btnBlance.TabIndex = 191;
		this.btnBlance.Text = "0 Chip | -30 Days / Month";
		this.btnBlance.UseVisualStyleBackColor = true;
		this.btnDayVNG.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnDayVNG.Enabled = false;
		this.btnDayVNG.Location = new global::System.Drawing.Point(0, 366);
		this.btnDayVNG.Name = "btnDayVNG";
		this.btnDayVNG.Size = new global::System.Drawing.Size(200, 22);
		this.btnDayVNG.TabIndex = 190;
		this.btnDayVNG.Text = "0.0000 Days VNG";
		this.btnDayVNG.UseVisualStyleBackColor = true;
		this.btnDayPRI.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnDayPRI.Enabled = false;
		this.btnDayPRI.Location = new global::System.Drawing.Point(0, 388);
		this.btnDayPRI.Name = "btnDayPRI";
		this.btnDayPRI.Size = new global::System.Drawing.Size(200, 22);
		this.btnDayPRI.TabIndex = 189;
		this.btnDayPRI.Text = "0.0000 Days PRI";
		this.btnDayPRI.UseVisualStyleBackColor = true;
		this.btnDayORI.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.btnDayORI.Enabled = false;
		this.btnDayORI.Location = new global::System.Drawing.Point(0, 410);
		this.btnDayORI.Name = "btnDayORI";
		this.btnDayORI.Size = new global::System.Drawing.Size(200, 22);
		this.btnDayORI.TabIndex = 188;
		this.btnDayORI.Text = "0.0000 Days ORI";
		this.btnDayORI.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.button3);
		this.groupBox2.Controls.Add(this.txtNewPass);
		this.groupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox2.Location = new global::System.Drawing.Point(0, 100);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new global::System.Drawing.Size(200, 40);
		this.groupBox2.TabIndex = 186;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Change Password";
		this.button3.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button3.Location = new global::System.Drawing.Point(129, 16);
		this.button3.Margin = new global::System.Windows.Forms.Padding(2);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(68, 21);
		this.button3.TabIndex = 0;
		this.button3.Text = "Change";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.txtNewPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtNewPass.Location = new global::System.Drawing.Point(3, 16);
		this.txtNewPass.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtNewPass.Name = "txtNewPass";
		this.txtNewPass.Size = new global::System.Drawing.Size(194, 20);
		this.txtNewPass.TabIndex = 169;
		this.txtNewPass.String_0 = "Pass";
		this.txtNewPass.Color_0 = global::System.Drawing.Color.Gray;
		this.txtNewPass.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtNewPass.Color_1 = global::System.Drawing.Color.LightGray;
		this.groupBox1.Controls.Add(this.txtGiftCode);
		this.groupBox1.Controls.Add(this.btnOpenGiftCode);
		this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox1.Location = new global::System.Drawing.Point(0, 60);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(200, 40);
		this.groupBox1.TabIndex = 184;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "GiftCode";
		this.txtGiftCode.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtGiftCode.Location = new global::System.Drawing.Point(3, 16);
		this.txtGiftCode.Name = "txtGiftCode";
		this.txtGiftCode.Size = new global::System.Drawing.Size(126, 20);
		this.txtGiftCode.TabIndex = 169;
		this.txtGiftCode.String_0 = "GiftCode";
		this.txtGiftCode.Color_0 = global::System.Drawing.Color.Gray;
		this.txtGiftCode.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtGiftCode.Color_1 = global::System.Drawing.Color.LightGray;
		this.btnOpenGiftCode.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnOpenGiftCode.Location = new global::System.Drawing.Point(129, 16);
		this.btnOpenGiftCode.Name = "btnOpenGiftCode";
		this.btnOpenGiftCode.Size = new global::System.Drawing.Size(68, 21);
		this.btnOpenGiftCode.TabIndex = 0;
		this.btnOpenGiftCode.Text = "Use";
		this.btnOpenGiftCode.UseVisualStyleBackColor = true;
		this.btnOpenGiftCode.Click += new global::System.EventHandler(this.btnOpenGiftCode_Click);
		this.groupBox8.Controls.Add(this.txtSendChip);
		this.groupBox8.Controls.Add(this.txtUserChip);
		this.groupBox8.Controls.Add(this.btnSendChip);
		this.groupBox8.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.groupBox8.Location = new global::System.Drawing.Point(0, 0);
		this.groupBox8.Name = "groupBox8";
		this.groupBox8.Size = new global::System.Drawing.Size(200, 60);
		this.groupBox8.TabIndex = 181;
		this.groupBox8.TabStop = false;
		this.groupBox8.Text = "Send Chip";
		this.txtSendChip.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.txtSendChip.Location = new global::System.Drawing.Point(3, 36);
		this.txtSendChip.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtSendChip.Name = "txtSendChip";
		this.txtSendChip.Size = new global::System.Drawing.Size(126, 20);
		this.txtSendChip.TabIndex = 170;
		this.txtSendChip.String_0 = "Chip";
		this.txtSendChip.Color_0 = global::System.Drawing.Color.Gray;
		this.txtSendChip.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtSendChip.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtUserChip.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.txtUserChip.Location = new global::System.Drawing.Point(3, 16);
		this.txtUserChip.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtUserChip.Name = "txtUserChip";
		this.txtUserChip.Size = new global::System.Drawing.Size(126, 20);
		this.txtUserChip.TabIndex = 169;
		this.txtUserChip.String_0 = "User";
		this.txtUserChip.Color_0 = global::System.Drawing.Color.Gray;
		this.txtUserChip.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtUserChip.Color_1 = global::System.Drawing.Color.LightGray;
		this.btnSendChip.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.btnSendChip.Location = new global::System.Drawing.Point(129, 16);
		this.btnSendChip.Margin = new global::System.Windows.Forms.Padding(2);
		this.btnSendChip.Name = "btnSendChip";
		this.btnSendChip.Size = new global::System.Drawing.Size(68, 41);
		this.btnSendChip.TabIndex = 0;
		this.btnSendChip.Text = "Send";
		this.btnSendChip.UseVisualStyleBackColor = true;
		this.btnSendChip.Click += new global::System.EventHandler(this.btnSendChip_Click);
		this.button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.button1.Location = new global::System.Drawing.Point(3, 435);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(420, 23);
		this.button1.TabIndex = 187;
		this.button1.Text = "Sign Out";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.tabinBox.BackColor = global::System.Drawing.Color.White;
		this.tabinBox.Controls.Add(this.lvInbox);
		this.tabinBox.Controls.Add(this.txtContent);
		this.tabinBox.Controls.Add(this.panel23);
		this.tabinBox.Controls.Add(this.panel6);
		this.tabinBox.Location = new global::System.Drawing.Point(4, 22);
		this.tabinBox.Margin = new global::System.Windows.Forms.Padding(2);
		this.tabinBox.Name = "tabinBox";
		this.tabinBox.Size = new global::System.Drawing.Size(426, 461);
		this.tabinBox.TabIndex = 6;
		this.tabinBox.Text = "inbox";
		this.lvInbox.AllItems = null;
		this.lvInbox.AllowColumnReorder = true;
		this.lvInbox.AllowDrop = true;
		this.lvInbox.AllowReorder = true;
		this.lvInbox.AllowSort = true;
		this.lvInbox.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader_27, this.columnHeader_28, this.columnHeader_29, this.columnHeader_30 });
		this.lvInbox.ContextMenuStrip = this.contextMenuStrip1;
		this.lvInbox.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvInbox.DoubleClickActivation = false;
		this.lvInbox.FullRowSelect = true;
		this.lvInbox.GridLines = true;
		this.lvInbox.HideSelection = false;
		this.lvInbox.LineColor = global::System.Drawing.Color.Red;
		this.lvInbox.Location = new global::System.Drawing.Point(0, 17);
		this.lvInbox.Margin = new global::System.Windows.Forms.Padding(2);
		this.lvInbox.Name = "lvInbox";
		this.lvInbox.Size = new global::System.Drawing.Size(426, 355);
		this.lvInbox.TabIndex = 2;
		this.lvInbox.UseCompatibleStateImageBehavior = false;
		this.lvInbox.View = global::System.Windows.Forms.View.Details;
		this.lvInbox.SelectedIndexChanged += new global::System.EventHandler(this.lvInbox_SelectedIndexChanged);
		this.lvInbox.DoubleClick += new global::System.EventHandler(this.lvInbox_DoubleClick);
		this.columnHeader_27.Text = "Time";
		this.columnHeader_27.Width = 80;
		this.columnHeader_28.Text = "From";
		this.columnHeader_28.Width = 70;
		this.columnHeader_29.Text = "To";
		this.columnHeader_29.Width = 70;
		this.columnHeader_30.Text = "Content";
		this.columnHeader_30.Width = 141;
		this.txtContent.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.txtContent.Location = new global::System.Drawing.Point(0, 372);
		this.txtContent.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtContent.Multiline = true;
		this.txtContent.Name = "txtContent";
		this.txtContent.Size = new global::System.Drawing.Size(426, 67);
		this.txtContent.TabIndex = 1;
		this.txtContent.String_0 = "Content...";
		this.txtContent.Color_0 = global::System.Drawing.Color.Gray;
		this.txtContent.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtContent.Color_1 = global::System.Drawing.Color.LightGray;
		this.panel23.Controls.Add(this.txtChatContent);
		this.panel23.Controls.Add(this.txtChatFrom);
		this.panel23.Controls.Add(this.button17);
		this.panel23.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panel23.Location = new global::System.Drawing.Point(0, 439);
		this.panel23.Margin = new global::System.Windows.Forms.Padding(2);
		this.panel23.Name = "panel23";
		this.panel23.Size = new global::System.Drawing.Size(426, 22);
		this.panel23.TabIndex = 284;
		this.txtChatContent.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.txtChatContent.Location = new global::System.Drawing.Point(79, 0);
		this.txtChatContent.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtChatContent.Name = "txtChatContent";
		this.txtChatContent.Size = new global::System.Drawing.Size(291, 20);
		this.txtChatContent.TabIndex = 0;
		this.txtChatContent.String_0 = "Message";
		this.txtChatContent.Color_0 = global::System.Drawing.Color.Gray;
		this.txtChatContent.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtChatContent.Color_1 = global::System.Drawing.Color.LightGray;
		this.txtChatContent.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtChatContent_KeyDown);
		this.txtChatFrom.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.txtChatFrom.Location = new global::System.Drawing.Point(0, 0);
		this.txtChatFrom.Margin = new global::System.Windows.Forms.Padding(2);
		this.txtChatFrom.Name = "txtChatFrom";
		this.txtChatFrom.Size = new global::System.Drawing.Size(79, 20);
		this.txtChatFrom.TabIndex = 2;
		this.txtChatFrom.String_0 = "Name";
		this.txtChatFrom.Color_0 = global::System.Drawing.Color.Gray;
		this.txtChatFrom.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txtChatFrom.Color_1 = global::System.Drawing.Color.LightGray;
		this.button17.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.button17.Location = new global::System.Drawing.Point(370, 0);
		this.button17.Margin = new global::System.Windows.Forms.Padding(2);
		this.button17.Name = "button17";
		this.button17.Size = new global::System.Drawing.Size(56, 22);
		this.button17.TabIndex = 1;
		this.button17.Text = "Talk";
		this.button17.UseVisualStyleBackColor = true;
		this.button17.Click += new global::System.EventHandler(this.button17_Click);
		this.panel6.Controls.Add(this.textBoxEx2);
		this.panel6.Controls.Add(this.checkAutoShow);
		this.panel6.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.panel6.Location = new global::System.Drawing.Point(0, 0);
		this.panel6.Margin = new global::System.Windows.Forms.Padding(2);
		this.panel6.Name = "panel6";
		this.panel6.Size = new global::System.Drawing.Size(426, 17);
		this.panel6.TabIndex = 283;
		this.textBoxEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.textBoxEx2.Location = new global::System.Drawing.Point(0, 0);
		this.textBoxEx2.Margin = new global::System.Windows.Forms.Padding(2);
		this.textBoxEx2.Name = "textBoxEx2";
		this.textBoxEx2.Size = new global::System.Drawing.Size(347, 20);
		this.textBoxEx2.TabIndex = 0;
		this.textBoxEx2.String_0 = "Search...";
		this.textBoxEx2.Color_0 = global::System.Drawing.Color.Gray;
		this.textBoxEx2.Font_0 = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxEx2.Color_1 = global::System.Drawing.Color.LightGray;
		this.textBoxEx2.TextChanged += new global::System.EventHandler(this.textBoxEx2_TextChanged);
		this.checkAutoShow.AutoSize = true;
		this.checkAutoShow.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.checkAutoShow.Location = new global::System.Drawing.Point(347, 0);
		this.checkAutoShow.Margin = new global::System.Windows.Forms.Padding(2);
		this.checkAutoShow.Name = "checkAutoShow";
		this.checkAutoShow.Padding = new global::System.Windows.Forms.Padding(4, 0, 0, 0);
		this.checkAutoShow.Size = new global::System.Drawing.Size(79, 17);
		this.checkAutoShow.TabIndex = 283;
		this.checkAutoShow.Text = "AutoShow";
		this.checkAutoShow.UseVisualStyleBackColor = true;
		this.checkAutoShow.CheckedChanged += new global::System.EventHandler(this.checkAutoShow_CheckedChanged);
		this.tabSetting.Location = new global::System.Drawing.Point(4, 22);
		this.tabSetting.Name = "tabSetting";
		this.tabSetting.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabSetting.Size = new global::System.Drawing.Size(426, 461);
		this.tabSetting.TabIndex = 8;
		this.tabSetting.Text = "Setting";
		this.tabSetting.UseVisualStyleBackColor = true;
		this.tabConfig.Location = new global::System.Drawing.Point(4, 22);
		this.tabConfig.Name = "tabConfig";
		this.tabConfig.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabConfig.Size = new global::System.Drawing.Size(426, 461);
		this.tabConfig.TabIndex = 9;
		this.tabConfig.Text = "Config";
		this.tabConfig.UseVisualStyleBackColor = true;
		this.tabChat.Location = new global::System.Drawing.Point(4, 22);
		this.tabChat.Name = "tabChat";
		this.tabChat.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabChat.Size = new global::System.Drawing.Size(426, 461);
		this.tabChat.TabIndex = 10;
		this.tabChat.Text = "Chat";
		this.tabChat.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.ClientSize = new global::System.Drawing.Size(434, 511);
		base.Controls.Add(this.tabMain);
		base.Controls.Add(this.menuMain);
		base.Name = "GUI";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "iAuto";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
		base.Load += new global::System.EventHandler(this.GUI_Load);
		this.menuListView.ResumeLayout(false);
		this.menuMain.ResumeLayout(false);
		this.menuMain.PerformLayout();
		this.tabPage5.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
		this.splitContainer3.ResumeLayout(false);
		this.contextMenuStrip1.ResumeLayout(false);
		this.contextMenuStrip2.ResumeLayout(false);
		this.tabLoginOnline.ResumeLayout(false);
		this.menuQr.ResumeLayout(false);
		this.tabMain.ResumeLayout(false);
		this.tabGame.ResumeLayout(false);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.tabBoottom.ResumeLayout(false);
		this.tabBuff.ResumeLayout(false);
		this.myPanel7.ResumeLayout(false);
		this.panelEx3.ResumeLayout(false);
		this.panelEx3.PerformLayout();
		this.panelEx1.ResumeLayout(false);
		this.panelEx1.PerformLayout();
		this.panelEx4.ResumeLayout(false);
		this.panelEx4.PerformLayout();
		this.tabQ.ResumeLayout(false);
		this.myPanel2.ResumeLayout(false);
		this.myPanel5.ResumeLayout(false);
		this.panelEx5.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.grNM.ResumeLayout(false);
		this.grNM.PerformLayout();
		this.panel5.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.numberPoint).EndInit();
		this.panelEx2.ResumeLayout(false);
		this.panel8.ResumeLayout(false);
		this.panel8.PerformLayout();
		this.panel24.ResumeLayout(false);
		this.panel24.PerformLayout();
		this.panel9.ResumeLayout(false);
		this.panel9.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.splitContainer2.Panel1.ResumeLayout(false);
		this.splitContainer2.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
		this.splitContainer2.ResumeLayout(false);
		this.panel4.ResumeLayout(false);
		this.panel11.ResumeLayout(false);
		this.panel12.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.checkHuyCraft.ResumeLayout(false);
		this.checkHuyCraft.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.numHuyCraftLine).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.numHuyCraftStar).EndInit();
		this.panel10.ResumeLayout(false);
		this.panel10.PerformLayout();
		this.panel17.ResumeLayout(false);
		this.panel17.PerformLayout();
		this.tabiLogin.ResumeLayout(false);
		this.tabPay.ResumeLayout(false);
		this.myPanel3.ResumeLayout(false);
		this.myPanel3.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.picQr).EndInit();
		this.myPanel1.ResumeLayout(false);
		this.groupBox9.ResumeLayout(false);
		this.groupBox9.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox8.ResumeLayout(false);
		this.groupBox8.PerformLayout();
		this.tabinBox.ResumeLayout(false);
		this.tabinBox.PerformLayout();
		this.panel23.ResumeLayout(false);
		this.panel23.PerformLayout();
		this.panel6.ResumeLayout(false);
		this.panel6.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040014B2 RID: 5298
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x040014B3 RID: 5299
	private global::System.Windows.Forms.MenuStrip menuMain;

	// Token: 0x040014B4 RID: 5300
	private global::System.Windows.Forms.ToolStripMenuItem muPlayer;

	// Token: 0x040014B5 RID: 5301
	private global::System.Windows.Forms.ToolStripMenuItem muThuongKho;

	// Token: 0x040014B6 RID: 5302
	private global::System.Windows.Forms.ToolStripMenuItem menuOpenBank;

	// Token: 0x040014B7 RID: 5303
	private global::System.Windows.Forms.ToolStripMenuItem muCatDo;

	// Token: 0x040014B8 RID: 5304
	private global::System.Windows.Forms.ToolStripMenuItem muLayDo;

	// Token: 0x040014B9 RID: 5305
	private global::System.Windows.Forms.ToolStripMenuItem muLayDoLayVang;

	// Token: 0x040014BA RID: 5306
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator17;

	// Token: 0x040014BB RID: 5307
	private global::System.Windows.Forms.ToolStripMenuItem muDi;

	// Token: 0x040014BC RID: 5308
	private global::System.Windows.Forms.ToolStripMenuItem muMoShop;

	// Token: 0x040014BD RID: 5309
	private global::System.Windows.Forms.ToolStripMenuItem muMoShopTrungDo;

	// Token: 0x040014BE RID: 5310
	private global::System.Windows.Forms.ToolStripMenuItem muMoShopHungBa;

	// Token: 0x040014BF RID: 5311
	private global::System.Windows.Forms.ToolStripMenuItem muMoShopBachBaoCac;

	// Token: 0x040014C0 RID: 5312
	private global::System.Windows.Forms.ToolStripMenuItem muMoTiemThuoc;

	// Token: 0x040014C1 RID: 5313
	private global::System.Windows.Forms.ToolStripMenuItem muDiMuaNgua;

	// Token: 0x040014C2 RID: 5314
	private global::System.Windows.Forms.ToolStripMenuItem muNopTuViHuyTinh;

	// Token: 0x040014C3 RID: 5315
	private global::System.Windows.Forms.ToolStripMenuItem muThanhLyNhiemVu;

	// Token: 0x040014C4 RID: 5316
	private global::System.Windows.Forms.ToolStripMenuItem muGiaoNguHanhPhapThiep;

	// Token: 0x040014C5 RID: 5317
	private global::System.Windows.Forms.ToolStripMenuItem muMua100KimSangDuoc;

	// Token: 0x040014C6 RID: 5318
	private global::System.Windows.Forms.ToolStripMenuItem muDiSua;

	// Token: 0x040014C7 RID: 5319
	private global::System.Windows.Forms.ToolStripMenuItem muSuaVoHon;

	// Token: 0x040014C8 RID: 5320
	private global::System.Windows.Forms.ToolStripMenuItem muSuaThanKhi;

	// Token: 0x040014C9 RID: 5321
	private global::System.Windows.Forms.ToolStripMenuItem muSuaTrangBi;

	// Token: 0x040014CA RID: 5322
	private global::System.Windows.Forms.ToolStripMenuItem muDiDoi;

	// Token: 0x040014CB RID: 5323
	private global::System.Windows.Forms.ToolStripMenuItem muDoiChanNguyenLinhPhach;

	// Token: 0x040014CC RID: 5324
	private global::System.Windows.Forms.ToolStripMenuItem muDiNhan;

	// Token: 0x040014CD RID: 5325
	private global::System.Windows.Forms.ToolStripMenuItem muNhanChienCongKiemChi;

	// Token: 0x040014CE RID: 5326
	private global::System.Windows.Forms.ToolStripMenuItem muNhanThuongQuanSonHai;

	// Token: 0x040014CF RID: 5327
	private global::System.Windows.Forms.ToolStripMenuItem muNhanBuaBaoRuong;

	// Token: 0x040014D0 RID: 5328
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLeBao;

	// Token: 0x040014D1 RID: 5329
	private global::System.Windows.Forms.ToolStripMenuItem muIntime;

	// Token: 0x040014D2 RID: 5330
	private global::System.Windows.Forms.ToolStripMenuItem muAcTac;

	// Token: 0x040014D3 RID: 5331
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

	// Token: 0x040014D4 RID: 5332
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator21;

	// Token: 0x040014D5 RID: 5333
	private global::System.Windows.Forms.ToolStripMenuItem muVoLuongSon;

	// Token: 0x040014D6 RID: 5334
	private global::System.Windows.Forms.ToolStripMenuItem muKinhHo;

	// Token: 0x040014D7 RID: 5335
	private global::System.Windows.Forms.ToolStripMenuItem muKiemCac;

	// Token: 0x040014D8 RID: 5336
	private global::System.Windows.Forms.ToolStripMenuItem muThaiHo;

	// Token: 0x040014D9 RID: 5337
	private global::System.Windows.Forms.ToolStripMenuItem muTungSon;

	// Token: 0x040014DA RID: 5338
	private global::System.Windows.Forms.ToolStripMenuItem muDonHoang;

	// Token: 0x040014DB RID: 5339
	private global::System.Windows.Forms.ToolStripMenuItem muAcBa;

	// Token: 0x040014DC RID: 5340
	private global::System.Windows.Forms.ToolStripMenuItem muAcBaTuDong;

	// Token: 0x040014DD RID: 5341
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator24;

	// Token: 0x040014DE RID: 5342
	private global::System.Windows.Forms.ToolStripMenuItem menuDaoHoa;

	// Token: 0x040014DF RID: 5343
	private global::System.Windows.Forms.ToolStripMenuItem menuQuyCoc;

	// Token: 0x040014E0 RID: 5344
	private global::System.Windows.Forms.ToolStripMenuItem menuDuongMon;

	// Token: 0x040014E1 RID: 5345
	private global::System.Windows.Forms.ToolStripMenuItem menuMoDung;

	// Token: 0x040014E2 RID: 5346
	private global::System.Windows.Forms.ToolStripMenuItem menuTinhTuc;

	// Token: 0x040014E3 RID: 5347
	private global::System.Windows.Forms.ToolStripMenuItem menuTieuDao;

	// Token: 0x040014E4 RID: 5348
	private global::System.Windows.Forms.ToolStripMenuItem menuThieuLam;

	// Token: 0x040014E5 RID: 5349
	private global::System.Windows.Forms.ToolStripMenuItem menuThienSon;

	// Token: 0x040014E6 RID: 5350
	private global::System.Windows.Forms.ToolStripMenuItem menuThienLong;

	// Token: 0x040014E7 RID: 5351
	private global::System.Windows.Forms.ToolStripMenuItem menuNgamy;

	// Token: 0x040014E8 RID: 5352
	private global::System.Windows.Forms.ToolStripMenuItem muTangKinhCac;

	// Token: 0x040014E9 RID: 5353
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

	// Token: 0x040014EA RID: 5354
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator22;

	// Token: 0x040014EB RID: 5355
	private global::System.Windows.Forms.ToolStripMenuItem menuTayHo;

	// Token: 0x040014EC RID: 5356
	private global::System.Windows.Forms.ToolStripMenuItem menuNhiHai;

	// Token: 0x040014ED RID: 5357
	private global::System.Windows.Forms.ToolStripMenuItem menuNhanNham;

	// Token: 0x040014EE RID: 5358
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator40;

	// Token: 0x040014EF RID: 5359
	private global::System.Windows.Forms.ToolStripMenuItem muTucCau;

	// Token: 0x040014F0 RID: 5360
	private global::System.Windows.Forms.ToolStripMenuItem muLauLanTamBao;

	// Token: 0x040014F1 RID: 5361
	private global::System.Windows.Forms.ToolStripMenuItem muLauLanTamBaoNhanh;

	// Token: 0x040014F2 RID: 5362
	private global::System.Windows.Forms.ToolStripMenuItem muLauLanTamBaoCham;

	// Token: 0x040014F3 RID: 5363
	private global::System.Windows.Forms.ToolStripMenuItem muKyCuoc;

	// Token: 0x040014F4 RID: 5364
	private global::System.Windows.Forms.ToolStripMenuItem muKyCuocNhanh;

	// Token: 0x040014F5 RID: 5365
	private global::System.Windows.Forms.ToolStripMenuItem muKyCuocCham;

	// Token: 0x040014F6 RID: 5366
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator39;

	// Token: 0x040014F7 RID: 5367
	private global::System.Windows.Forms.ToolStripMenuItem muDaTru;

	// Token: 0x040014F8 RID: 5368
	private global::System.Windows.Forms.ToolStripMenuItem muMongHeo;

	// Token: 0x040014F9 RID: 5369
	private global::System.Windows.Forms.ToolStripMenuItem muThienGiangKyThu;

	// Token: 0x040014FA RID: 5370
	private global::System.Windows.Forms.ToolStripMenuItem muPhungHoangLangMo;

	// Token: 0x040014FB RID: 5371
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator30;

	// Token: 0x040014FC RID: 5372
	private global::System.Windows.Forms.ToolStripMenuItem menuBossMap;

	// Token: 0x040014FD RID: 5373
	private global::System.Windows.Forms.ToolStripMenuItem muBaoDoHiem;

	// Token: 0x040014FE RID: 5374
	private global::System.Windows.Forms.ToolStripMenuItem muDoanBaoMaTac;

	// Token: 0x040014FF RID: 5375
	private global::System.Windows.Forms.ToolStripMenuItem muDaily;

	// Token: 0x04001500 RID: 5376
	private global::System.Windows.Forms.ToolStripMenuItem muHangNgay;

	// Token: 0x04001501 RID: 5377
	private global::System.Windows.Forms.ToolStripMenuItem muToanBoHangNgay;

	// Token: 0x04001502 RID: 5378
	private global::System.Windows.Forms.ToolStripMenuItem muVanMay;

	// Token: 0x04001503 RID: 5379
	private global::System.Windows.Forms.ToolStripMenuItem muNguyenVong;

	// Token: 0x04001504 RID: 5380
	private global::System.Windows.Forms.ToolStripMenuItem muSuMon;

	// Token: 0x04001505 RID: 5381
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator36;

	// Token: 0x04001506 RID: 5382
	private global::System.Windows.Forms.ToolStripMenuItem muMoBaoTangDo;

	// Token: 0x04001507 RID: 5383
	private global::System.Windows.Forms.ToolStripMenuItem muTrungAc;

	// Token: 0x04001508 RID: 5384
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator32;

	// Token: 0x04001509 RID: 5385
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyen;

	// Token: 0x0400150A RID: 5386
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenThangCap;

	// Token: 0x0400150B RID: 5387
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenExp;

	// Token: 0x0400150C RID: 5388
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenKnbKhoa;

	// Token: 0x0400150D RID: 5389
	private global::System.Windows.Forms.ToolStripMenuItem muNgoChanNguyen;

	// Token: 0x0400150E RID: 5390
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenChinhTuyen;

	// Token: 0x0400150F RID: 5391
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenVoY;

	// Token: 0x04001510 RID: 5392
	private global::System.Windows.Forms.ToolStripMenuItem muCotTruyenVoTuPho;

	// Token: 0x04001511 RID: 5393
	private global::System.Windows.Forms.ToolStripMenuItem muConCai;

	// Token: 0x04001512 RID: 5394
	private global::System.Windows.Forms.ToolStripMenuItem muTuDuong;

	// Token: 0x04001513 RID: 5395
	private global::System.Windows.Forms.ToolStripMenuItem muPhuMau;

	// Token: 0x04001514 RID: 5396
	private global::System.Windows.Forms.ToolStripMenuItem muNhanCon;

	// Token: 0x04001515 RID: 5397
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

	// Token: 0x04001516 RID: 5398
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator35;

	// Token: 0x04001517 RID: 5399
	private global::System.Windows.Forms.ToolStripMenuItem muSinhTieu;

	// Token: 0x04001518 RID: 5400
	private global::System.Windows.Forms.ToolStripMenuItem muDungDoatBaoRuong;

	// Token: 0x04001519 RID: 5401
	private global::System.Windows.Forms.ToolStripMenuItem muNier;

	// Token: 0x0400151A RID: 5402
	private global::System.Windows.Forms.ToolStripMenuItem menuPickItem;

	// Token: 0x0400151B RID: 5403
	private global::System.Windows.Forms.ToolStripMenuItem menuuForceFollowKey;

	// Token: 0x0400151C RID: 5404
	private global::System.Windows.Forms.ToolStripMenuItem menuAtkFollowKey;

	// Token: 0x0400151D RID: 5405
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator25;

	// Token: 0x0400151E RID: 5406
	private global::System.Windows.Forms.ContextMenuStrip menuListView;

	// Token: 0x0400151F RID: 5407
	private global::System.Windows.Forms.ToolStripMenuItem menuHideGame;

	// Token: 0x04001520 RID: 5408
	private global::System.Windows.Forms.ToolStripMenuItem menuShowGame;

	// Token: 0x04001521 RID: 5409
	private global::System.Windows.Forms.ToolStripMenuItem menuExitGame;

	// Token: 0x04001522 RID: 5410
	private global::System.Windows.Forms.ToolStripMenuItem menuSelectServer;

	// Token: 0x04001523 RID: 5411
	private global::System.Windows.Forms.ToolStripMenuItem menuToDoi;

	// Token: 0x04001524 RID: 5412
	private global::System.Windows.Forms.ToolStripMenuItem menuMoiDoi;

	// Token: 0x04001525 RID: 5413
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator58;

	// Token: 0x04001526 RID: 5414
	private global::System.Windows.Forms.ToolStripMenuItem menuSetNhom;

	// Token: 0x04001527 RID: 5415
	private global::System.Windows.Forms.ToolStripMenuItem muGiaiTan;

	// Token: 0x04001528 RID: 5416
	private global::System.Windows.Forms.ToolStripMenuItem menuDiChuyen;

	// Token: 0x04001529 RID: 5417
	private global::System.Windows.Forms.ToolStripMenuItem menuLenToaDo;

	// Token: 0x0400152A RID: 5418
	private global::System.Windows.Forms.ToolStripMenuItem menuLuuToaDo;

	// Token: 0x0400152B RID: 5419
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator34;

	// Token: 0x0400152C RID: 5420
	private global::System.Windows.Forms.ToolStripMenuItem menuThaoTac;

	// Token: 0x0400152D RID: 5421
	private global::System.Windows.Forms.ToolStripMenuItem muAnDon;

	// Token: 0x0400152E RID: 5422
	private global::System.Windows.Forms.ToolStripMenuItem muQuayVeDaiLy;

	// Token: 0x0400152F RID: 5423
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator14;

	// Token: 0x04001530 RID: 5424
	private global::System.Windows.Forms.ToolStripMenuItem mLenNgua;

	// Token: 0x04001531 RID: 5425
	private global::System.Windows.Forms.ToolStripMenuItem mXuongNgua;

	// Token: 0x04001532 RID: 5426
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

	// Token: 0x04001533 RID: 5427
	private global::System.Windows.Forms.ToolStripMenuItem muXuatPet;

	// Token: 0x04001534 RID: 5428
	private global::System.Windows.Forms.ToolStripMenuItem muThuPet;

	// Token: 0x04001535 RID: 5429
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

	// Token: 0x04001536 RID: 5430
	private global::System.Windows.Forms.ToolStripMenuItem muHaoHuu;

	// Token: 0x04001537 RID: 5431
	private global::System.Windows.Forms.ToolStripMenuItem muTuyetGiao;

	// Token: 0x04001538 RID: 5432
	private global::System.Windows.Forms.ToolStripMenuItem menuRefreshAuto;

	// Token: 0x04001539 RID: 5433
	private global::System.Windows.Forms.ToolStripMenuItem menuDebug;

	// Token: 0x0400153A RID: 5434
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x0400153B RID: 5435
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x0400153C RID: 5436
	private global::System.Windows.Forms.ColumnHeader columnHeader_2;

	// Token: 0x0400153D RID: 5437
	private global::System.Windows.Forms.ColumnHeader columnHeader_3;

	// Token: 0x0400153E RID: 5438
	private global::System.Windows.Forms.ToolStripMenuItem menuVoDang;

	// Token: 0x0400153F RID: 5439
	private global::System.Windows.Forms.ToolStripMenuItem menuMinhGiao;

	// Token: 0x04001540 RID: 5440
	private global::System.Windows.Forms.ToolStripMenuItem menuCaiBang;

	// Token: 0x04001541 RID: 5441
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04001542 RID: 5442
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

	// Token: 0x04001543 RID: 5443
	private global::System.Windows.Forms.ToolStripMenuItem menuPkMode;

	// Token: 0x04001544 RID: 5444
	private global::System.Windows.Forms.ToolStripMenuItem menuTuyetTinh;

	// Token: 0x04001545 RID: 5445
	private global::System.Windows.Forms.ToolStripMenuItem muMoShopVanCam;

	// Token: 0x04001546 RID: 5446
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

	// Token: 0x04001547 RID: 5447
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_4;

	// Token: 0x04001548 RID: 5448
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_5;

	// Token: 0x04001549 RID: 5449
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_6;

	// Token: 0x0400154A RID: 5450
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_7;

	// Token: 0x0400154B RID: 5451
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_8;

	// Token: 0x0400154C RID: 5452
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_9;

	// Token: 0x0400154D RID: 5453
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_10;

	// Token: 0x0400154E RID: 5454
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_11;

	// Token: 0x0400154F RID: 5455
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_12;

	// Token: 0x04001550 RID: 5456
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLenhBai;

	// Token: 0x04001551 RID: 5457
	private global::System.Windows.Forms.TabPage tabPage5;

	// Token: 0x04001552 RID: 5458
	private global::System.Windows.Forms.Panel panel7;

	// Token: 0x04001553 RID: 5459
	private global::System.Windows.Forms.SplitContainer splitContainer3;

	// Token: 0x04001554 RID: 5460
	private global::System.Windows.Forms.Label label9;

	// Token: 0x04001555 RID: 5461
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_13;

	// Token: 0x04001556 RID: 5462
	private global::System.Windows.Forms.ToolStripMenuItem trangBij13ToolStripMenuItem;

	// Token: 0x04001557 RID: 5463
	private global::System.Windows.Forms.ToolStripMenuItem trangBij23ToolStripMenuItem;

	// Token: 0x04001558 RID: 5464
	private global::System.Windows.Forms.ToolStripMenuItem muItemFiller;

	// Token: 0x04001559 RID: 5465
	private global::System.Windows.Forms.ToolStripMenuItem menuFollowKey;

	// Token: 0x0400155A RID: 5466
	private global::System.Windows.Forms.ToolStripMenuItem qBangToolStripMenuItem;

	// Token: 0x0400155B RID: 5467
	private global::System.Windows.Forms.ToolStripMenuItem muThuongNghiep;

	// Token: 0x0400155C RID: 5468
	private global::System.Windows.Forms.ToolStripMenuItem muCongTrinh;

	// Token: 0x0400155D RID: 5469
	private global::System.Windows.Forms.ToolStripMenuItem muKyThuat;

	// Token: 0x0400155E RID: 5470
	private global::System.Windows.Forms.ToolStripMenuItem muKhuyechTruong;

	// Token: 0x0400155F RID: 5471
	private global::System.Windows.Forms.ToolStripMenuItem muPhatTrien;

	// Token: 0x04001560 RID: 5472
	private global::System.Windows.Forms.ToolStripMenuItem muXayDung;

	// Token: 0x04001561 RID: 5473
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

	// Token: 0x04001562 RID: 5474
	private global::System.Windows.Forms.ToolStripMenuItem muNghienCuu;

	// Token: 0x04001563 RID: 5475
	private global::System.Windows.Forms.ToolStripMenuItem muBaGiaLinhThao;

	// Token: 0x04001564 RID: 5476
	private global::System.Windows.Forms.ToolStripMenuItem muRotRuou;

	// Token: 0x04001565 RID: 5477
	private global::System.Windows.Forms.ToolStripMenuItem muNhanx2x3VoY;

	// Token: 0x04001566 RID: 5478
	private global::System.Windows.Forms.ToolStripMenuItem muNhanThienMachPhucTrach;

	// Token: 0x04001567 RID: 5479
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_14;

	// Token: 0x04001568 RID: 5480
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_15;

	// Token: 0x04001569 RID: 5481
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_16;

	// Token: 0x0400156A RID: 5482
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_17;

	// Token: 0x0400156B RID: 5483
	private global::System.Windows.Forms.ToolStripMenuItem muQuocPhong;

	// Token: 0x0400156C RID: 5484
	private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

	// Token: 0x0400156D RID: 5485
	private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

	// Token: 0x0400156E RID: 5486
	private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

	// Token: 0x0400156F RID: 5487
	private global::System.Windows.Forms.NotifyIcon notifyIcon_0;

	// Token: 0x04001570 RID: 5488
	private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

	// Token: 0x04001571 RID: 5489
	private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

	// Token: 0x04001572 RID: 5490
	private global::System.Windows.Forms.TabPage tabinBox;

	// Token: 0x04001573 RID: 5491
	private global::System.Windows.Forms.TabPage tabiLogin;

	// Token: 0x04001574 RID: 5492
	public global::Control6 tabLogin;

	// Token: 0x04001575 RID: 5493
	private global::System.Windows.Forms.TabPage tabLoginOnline;

	// Token: 0x04001576 RID: 5494
	private global::System.Windows.Forms.TabPage tabGame;

	// Token: 0x04001577 RID: 5495
	public global::_i.ListViewEx LvGame;

	// Token: 0x04001578 RID: 5496
	private global::System.Windows.Forms.ColumnHeader columnHeader_4;

	// Token: 0x04001579 RID: 5497
	private global::System.Windows.Forms.ColumnHeader columnHeader_5;

	// Token: 0x0400157A RID: 5498
	private global::System.Windows.Forms.ColumnHeader columnHeader_6;

	// Token: 0x0400157B RID: 5499
	private global::System.Windows.Forms.ColumnHeader columnHeader_7;

	// Token: 0x0400157C RID: 5500
	private global::System.Windows.Forms.ColumnHeader columnHeader_8;

	// Token: 0x0400157D RID: 5501
	private global::System.Windows.Forms.ColumnHeader columnHeader_9;

	// Token: 0x0400157E RID: 5502
	private global::System.Windows.Forms.ColumnHeader columnHeader_10;

	// Token: 0x0400157F RID: 5503
	private global::System.Windows.Forms.ColumnHeader columnHeader_11;

	// Token: 0x04001580 RID: 5504
	private global::System.Windows.Forms.ColumnHeader columnHeader_12;

	// Token: 0x04001581 RID: 5505
	private global::System.Windows.Forms.ColumnHeader columnHeader_13;

	// Token: 0x04001582 RID: 5506
	private global::System.Windows.Forms.ColumnHeader columnHeader_14;

	// Token: 0x04001583 RID: 5507
	private global::System.Windows.Forms.ColumnHeader columnHeader_15;

	// Token: 0x04001584 RID: 5508
	private global::System.Windows.Forms.ColumnHeader columnHeader_16;

	// Token: 0x04001585 RID: 5509
	private global::System.Windows.Forms.ColumnHeader columnHeader_17;

	// Token: 0x04001586 RID: 5510
	private global::Class533 txtMainSearch;

	// Token: 0x04001587 RID: 5511
	public global::Control6 tabMain;

	// Token: 0x04001588 RID: 5512
	private global::System.Windows.Forms.ColumnHeader columnHeader_18;

	// Token: 0x04001589 RID: 5513
	private global::System.Windows.Forms.ToolStripMenuItem mux2Exp;

	// Token: 0x0400158A RID: 5514
	private global::System.Windows.Forms.ToolStripMenuItem muThuongHoi;

	// Token: 0x0400158B RID: 5515
	private global::System.Windows.Forms.ToolStripMenuItem menuXuongGia;

	// Token: 0x0400158C RID: 5516
	private global::System.Windows.Forms.ToolStripMenuItem menuLayDo;

	// Token: 0x0400158D RID: 5517
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_18;

	// Token: 0x0400158E RID: 5518
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_19;

	// Token: 0x0400158F RID: 5519
	private global::System.Windows.Forms.ToolStripMenuItem menuLenGia;

	// Token: 0x04001590 RID: 5520
	public global::_i.ListViewEx lvInbox;

	// Token: 0x04001591 RID: 5521
	private global::System.Windows.Forms.ColumnHeader columnHeader_19;

	// Token: 0x04001592 RID: 5522
	private global::System.Windows.Forms.ColumnHeader columnHeader_20;

	// Token: 0x04001593 RID: 5523
	private global::System.Windows.Forms.ColumnHeader columnHeader_21;

	// Token: 0x04001594 RID: 5524
	private global::System.Windows.Forms.ColumnHeader columnHeader_22;

	// Token: 0x04001595 RID: 5525
	public global::Class533 txtContent;

	// Token: 0x04001596 RID: 5526
	private global::System.Windows.Forms.Panel panel6;

	// Token: 0x04001597 RID: 5527
	private global::Class533 textBoxEx2;

	// Token: 0x04001598 RID: 5528
	private global::System.Windows.Forms.CheckBox checkAutoShow;

	// Token: 0x04001599 RID: 5529
	private global::System.Windows.Forms.ToolStripMenuItem muThuongDung;

	// Token: 0x0400159A RID: 5530
	private global::System.Windows.Forms.ToolStripMenuItem muDiBanRac;

	// Token: 0x0400159B RID: 5531
	private global::System.Windows.Forms.ToolStripMenuItem muTriLieu;

	// Token: 0x0400159C RID: 5532
	private global::System.Windows.Forms.ToolStripMenuItem muTriLieuBanRacCatDo;

	// Token: 0x0400159D RID: 5533
	private global::System.Windows.Forms.ToolStripMenuItem muNhanx2;

	// Token: 0x0400159E RID: 5534
	private global::System.Windows.Forms.ToolStripMenuItem muDongx2;

	// Token: 0x0400159F RID: 5535
	private global::System.Windows.Forms.ToolStripMenuItem muPhanGiaiTrangBijPet;

	// Token: 0x040015A0 RID: 5536
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_20;

	// Token: 0x040015A1 RID: 5537
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;

	// Token: 0x040015A2 RID: 5538
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;

	// Token: 0x040015A3 RID: 5539
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;

	// Token: 0x040015A4 RID: 5540
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;

	// Token: 0x040015A5 RID: 5541
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;

	// Token: 0x040015A6 RID: 5542
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;

	// Token: 0x040015A7 RID: 5543
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;

	// Token: 0x040015A8 RID: 5544
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;

	// Token: 0x040015A9 RID: 5545
	private global::System.Windows.Forms.ToolStripMenuItem menuDoiHuyenSac;

	// Token: 0x040015AA RID: 5546
	private global::System.Windows.Forms.ToolStripMenuItem menuDoiLoanPhi;

	// Token: 0x040015AB RID: 5547
	private global::System.Windows.Forms.ToolStripMenuItem menuDoiDiaLinhChau;

	// Token: 0x040015AC RID: 5548
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem46;

	// Token: 0x040015AD RID: 5549
	private global::System.Windows.Forms.ToolStripMenuItem menuHocCheDo;

	// Token: 0x040015AE RID: 5550
	private global::System.Windows.Forms.ToolStripMenuItem muThinhGiaoBiKy;

	// Token: 0x040015AF RID: 5551
	private global::System.Windows.Forms.ToolStripMenuItem muAll;

	// Token: 0x040015B0 RID: 5552
	private global::System.Windows.Forms.ToolStripMenuItem selectCtrlAToolStripMenuItem;

	// Token: 0x040015B1 RID: 5553
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_21;

	// Token: 0x040015B2 RID: 5554
	private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;

	// Token: 0x040015B3 RID: 5555
	private global::System.Windows.Forms.ToolStripMenuItem selectServerToolStripMenuItem;

	// Token: 0x040015B4 RID: 5556
	private global::System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

	// Token: 0x040015B5 RID: 5557
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

	// Token: 0x040015B6 RID: 5558
	private global::System.Windows.Forms.ToolStripMenuItem muLenNgua;

	// Token: 0x040015B7 RID: 5559
	private global::System.Windows.Forms.ToolStripMenuItem muXuongNgua;

	// Token: 0x040015B8 RID: 5560
	private global::System.Windows.Forms.ToolStripMenuItem muDiemDanh;

	// Token: 0x040015B9 RID: 5561
	private global::System.Windows.Forms.ToolStripMenuItem muSapXepTayNai;

	// Token: 0x040015BA RID: 5562
	private global::System.Windows.Forms.ToolStripMenuItem menuDauThai;

	// Token: 0x040015BB RID: 5563
	private global::System.Windows.Forms.ToolStripMenuItem eitOFFLINEToolStripMenuItem;

	// Token: 0x040015BC RID: 5564
	private global::System.Windows.Forms.ToolStripMenuItem muPkMode;

	// Token: 0x040015BD RID: 5565
	private global::System.Windows.Forms.ToolStripMenuItem menuHoaBinh;

	// Token: 0x040015BE RID: 5566
	private global::System.Windows.Forms.ToolStripMenuItem menuThienAc;

	// Token: 0x040015BF RID: 5567
	private global::System.Windows.Forms.ToolStripMenuItem menuNhom;

	// Token: 0x040015C0 RID: 5568
	private global::System.Windows.Forms.ToolStripMenuItem menuBang;

	// Token: 0x040015C1 RID: 5569
	private global::System.Windows.Forms.ToolStripMenuItem menuQuanDoan;

	// Token: 0x040015C2 RID: 5570
	private global::System.Windows.Forms.ToolStripMenuItem menuJoinTeam;

	// Token: 0x040015C3 RID: 5571
	private global::System.Windows.Forms.ToolStripMenuItem menuCreateTeam;

	// Token: 0x040015C4 RID: 5572
	private global::System.Windows.Forms.Panel panel17;

	// Token: 0x040015C5 RID: 5573
	public global::LoginUser loginUser1;

	// Token: 0x040015C6 RID: 5574
	private global::System.Windows.Forms.ToolStripMenuItem menuOpenGame;

	// Token: 0x040015C7 RID: 5575
	private global::System.Windows.Forms.ToolStripMenuItem open1ToolStripMenuItem;

	// Token: 0x040015C8 RID: 5576
	private global::System.Windows.Forms.ToolStripMenuItem open2ToolStripMenuItem;

	// Token: 0x040015C9 RID: 5577
	private global::System.Windows.Forms.ToolStripMenuItem open3ToolStripMenuItem;

	// Token: 0x040015CA RID: 5578
	private global::System.Windows.Forms.ToolStripMenuItem open4ToolStripMenuItem;

	// Token: 0x040015CB RID: 5579
	private global::System.Windows.Forms.ToolStripMenuItem open5ToolStripMenuItem;

	// Token: 0x040015CC RID: 5580
	private global::System.Windows.Forms.ToolStripMenuItem open6ToolStripMenuItem;

	// Token: 0x040015CD RID: 5581
	private global::System.Windows.Forms.ToolStripMenuItem open12ToolStripMenuItem;

	// Token: 0x040015CE RID: 5582
	private global::System.Windows.Forms.ToolStripMenuItem open24ToolStripMenuItem;

	// Token: 0x040015CF RID: 5583
	private global::System.Windows.Forms.ToolStripMenuItem open48ToolStripMenuItem;

	// Token: 0x040015D0 RID: 5584
	private global::System.Windows.Forms.ToolStripMenuItem open96ToolStripMenuItem;

	// Token: 0x040015D1 RID: 5585
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

	// Token: 0x040015D2 RID: 5586
	private global::System.Windows.Forms.ToolStripMenuItem menuSelectPath;

	// Token: 0x040015D3 RID: 5587
	private global::System.Windows.Forms.ToolStripMenuItem menuTuTaoNhom;

	// Token: 0x040015D4 RID: 5588
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator27;

	// Token: 0x040015D5 RID: 5589
	private global::System.Windows.Forms.ToolStripMenuItem menuQuanLyNhom;

	// Token: 0x040015D6 RID: 5590
	private global::System.Windows.Forms.TabPage tabPay;

	// Token: 0x040015D7 RID: 5591
	private global::System.Windows.Forms.Panel panel23;

	// Token: 0x040015D8 RID: 5592
	private global::Class533 txtChatContent;

	// Token: 0x040015D9 RID: 5593
	private global::System.Windows.Forms.Button button17;

	// Token: 0x040015DA RID: 5594
	private global::Class533 txtChatFrom;

	// Token: 0x040015DB RID: 5595
	private global::System.Windows.Forms.Button btnRefresh;

	// Token: 0x040015DC RID: 5596
	private global::Class533 txtBetChip;

	// Token: 0x040015DD RID: 5597
	private global::System.Windows.Forms.Button button14;

	// Token: 0x040015DE RID: 5598
	private global::Class533 txtGiftCode;

	// Token: 0x040015DF RID: 5599
	private global::System.Windows.Forms.Button btnOpenGiftCode;

	// Token: 0x040015E0 RID: 5600
	private global::System.Windows.Forms.GroupBox groupBox8;

	// Token: 0x040015E1 RID: 5601
	private global::Class533 txtUserChip;

	// Token: 0x040015E2 RID: 5602
	private global::Class533 txtSendChip;

	// Token: 0x040015E3 RID: 5603
	private global::System.Windows.Forms.Button btnSendChip;

	// Token: 0x040015E4 RID: 5604
	private global::System.Windows.Forms.SplitContainer splitContainer1;

	// Token: 0x040015E5 RID: 5605
	private global::Control6 tabBoottom;

	// Token: 0x040015E6 RID: 5606
	private global::System.Windows.Forms.TabPage tabBuff;

	// Token: 0x040015E7 RID: 5607
	private global::_i.ListViewEx lvFunction;

	// Token: 0x040015E8 RID: 5608
	private global::System.Windows.Forms.ColumnHeader columnHeader_23;

	// Token: 0x040015E9 RID: 5609
	private global::System.Windows.Forms.ComboBox cboMenpai;

	// Token: 0x040015EA RID: 5610
	private global::System.Windows.Forms.ComboBox cboLeader;

	// Token: 0x040015EB RID: 5611
	private global::System.Windows.Forms.Panel panel9;

	// Token: 0x040015EC RID: 5612
	private global::Class533 txtRao;

	// Token: 0x040015ED RID: 5613
	private global::System.Windows.Forms.Button button6;

	// Token: 0x040015EE RID: 5614
	private global::System.Windows.Forms.CheckBox chkRaoVat;

	// Token: 0x040015EF RID: 5615
	private global::_i.ListViewEx lvSkill;

	// Token: 0x040015F0 RID: 5616
	private global::System.Windows.Forms.ColumnHeader columnHeader_24;

	// Token: 0x040015F1 RID: 5617
	private global::System.Windows.Forms.ColumnHeader columnHeader_25;

	// Token: 0x040015F2 RID: 5618
	private global::System.Windows.Forms.ColumnHeader columnHeader_26;

	// Token: 0x040015F3 RID: 5619
	private global::Class533 txtSearchName;

	// Token: 0x040015F4 RID: 5620
	private global::System.Windows.Forms.TabPage tabQ;

	// Token: 0x040015F5 RID: 5621
	private global::Class533 txtPass2;

	// Token: 0x040015F6 RID: 5622
	private global::System.Windows.Forms.CheckBox checkShowPass;

	// Token: 0x040015F7 RID: 5623
	private global::Class533 txtJoindGuildId;

	// Token: 0x040015F8 RID: 5624
	private global::System.Windows.Forms.Button btnJoinGuild;

	// Token: 0x040015F9 RID: 5625
	private global::System.Windows.Forms.Label lblFriendCityName;

	// Token: 0x040015FA RID: 5626
	private global::System.Windows.Forms.Label lblCityName;

	// Token: 0x040015FB RID: 5627
	private global::System.Windows.Forms.ComboBox cboCheNoiNgoai;

	// Token: 0x040015FC RID: 5628
	private global::Control0 numberNM;

	// Token: 0x040015FD RID: 5629
	private global::System.Windows.Forms.Button btnDuc;

	// Token: 0x040015FE RID: 5630
	private global::System.Windows.Forms.Button btnTrac;

	// Token: 0x040015FF RID: 5631
	private global::System.Windows.Forms.Button btnHop;

	// Token: 0x04001600 RID: 5632
	private global::System.Windows.Forms.ComboBox cboGem;

	// Token: 0x04001601 RID: 5633
	private global::System.Windows.Forms.ComboBox cboTrangBi;

	// Token: 0x04001602 RID: 5634
	private global::System.Windows.Forms.Button btnKham;

	// Token: 0x04001603 RID: 5635
	private global::System.Windows.Forms.ToolStripMenuItem muNhanThuongTriVu;

	// Token: 0x04001604 RID: 5636
	private global::System.Windows.Forms.ToolStripMenuItem muBiBao;

	// Token: 0x04001605 RID: 5637
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_22;

	// Token: 0x04001606 RID: 5638
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_23;

	// Token: 0x04001607 RID: 5639
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_24;

	// Token: 0x04001608 RID: 5640
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_25;

	// Token: 0x04001609 RID: 5641
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_26;

	// Token: 0x0400160A RID: 5642
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_27;

	// Token: 0x0400160B RID: 5643
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_28;

	// Token: 0x0400160C RID: 5644
	private global::System.Windows.Forms.ToolStripMenuItem muThienSuKyDai;

	// Token: 0x0400160D RID: 5645
	private global::System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;

	// Token: 0x0400160E RID: 5646
	private global::System.Windows.Forms.ToolStripMenuItem muBaoThachBieuTang;

	// Token: 0x0400160F RID: 5647
	private global::System.Windows.Forms.ToolStripMenuItem muKiemTung;

	// Token: 0x04001610 RID: 5648
	private global::GClass3 myPanel2;

	// Token: 0x04001611 RID: 5649
	private global::System.Windows.Forms.CheckBox checkAutoPhu;

	// Token: 0x04001612 RID: 5650
	public global::System.Windows.Forms.ComboBox cboPhu;

	// Token: 0x04001613 RID: 5651
	private global::System.Windows.Forms.ToolStripMenuItem menuMoHoaNgocTap;

	// Token: 0x04001614 RID: 5652
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_29;

	// Token: 0x04001615 RID: 5653
	private global::System.Windows.Forms.ToolStripMenuItem autoPkAltIToolStripMenuItem;

	// Token: 0x04001616 RID: 5654
	private global::System.Windows.Forms.ToolStripMenuItem mu200ReTranh;

	// Token: 0x04001617 RID: 5655
	private global::System.Windows.Forms.ToolStripMenuItem muThongBao;

	// Token: 0x04001618 RID: 5656
	private global::System.Windows.Forms.ToolStripMenuItem setDoneToolStripMenuItem;

	// Token: 0x04001619 RID: 5657
	private global::System.Windows.Forms.ToolStripMenuItem updateIAutoToolStripMenuItem;

	// Token: 0x0400161A RID: 5658
	private global::System.Windows.Forms.CheckBox checkPanel;

	// Token: 0x0400161B RID: 5659
	private global::System.Windows.Forms.Panel panel24;

	// Token: 0x0400161C RID: 5660
	private global::System.Windows.Forms.Panel panel14;

	// Token: 0x0400161D RID: 5661
	private global::System.Windows.Forms.GroupBox groupBox9;

	// Token: 0x0400161E RID: 5662
	private global::System.Windows.Forms.GroupBox groupBox1;

	// Token: 0x0400161F RID: 5663
	private global::GClass3 myPanel3;

	// Token: 0x04001620 RID: 5664
	private global::GClass3 myPanel1;

	// Token: 0x04001621 RID: 5665
	private global::System.Windows.Forms.ColumnHeader columnHeader_27;

	// Token: 0x04001622 RID: 5666
	private global::System.Windows.Forms.ColumnHeader columnHeader_28;

	// Token: 0x04001623 RID: 5667
	private global::System.Windows.Forms.ColumnHeader columnHeader_29;

	// Token: 0x04001624 RID: 5668
	private global::System.Windows.Forms.ColumnHeader columnHeader_30;

	// Token: 0x04001625 RID: 5669
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x04001626 RID: 5670
	private global::System.Windows.Forms.ToolStripMenuItem menuPickNear;

	// Token: 0x04001627 RID: 5671
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

	// Token: 0x04001628 RID: 5672
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator28;

	// Token: 0x04001629 RID: 5673
	private global::GClass3 myPanel5;

	// Token: 0x0400162A RID: 5674
	private global::System.Windows.Forms.ToolStripMenuItem menuThuongSon;

	// Token: 0x0400162B RID: 5675
	private global::System.Windows.Forms.ToolStripMenuItem menuVoDi;

	// Token: 0x0400162C RID: 5676
	private global::System.Windows.Forms.ToolStripMenuItem menuThaoNguyen;

	// Token: 0x0400162D RID: 5677
	private global::System.Windows.Forms.ToolStripMenuItem menuHuyenVuDao;

	// Token: 0x0400162E RID: 5678
	private global::System.Windows.Forms.ToolStripMenuItem menuKinhHo;

	// Token: 0x0400162F RID: 5679
	private global::System.Windows.Forms.ComboBox cboPoint;

	// Token: 0x04001630 RID: 5680
	private global::System.Windows.Forms.NumericUpDown numberPoint;

	// Token: 0x04001631 RID: 5681
	private global::System.Windows.Forms.Button btnAddPoint;

	// Token: 0x04001632 RID: 5682
	private global::System.Windows.Forms.ComboBox cboTrongTrot;

	// Token: 0x04001633 RID: 5683
	private global::GClass3 myPanel7;

	// Token: 0x04001634 RID: 5684
	private global::System.Windows.Forms.ToolStripMenuItem muBaoVeBang;

	// Token: 0x04001635 RID: 5685
	private global::System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;

	// Token: 0x04001636 RID: 5686
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_30;

	// Token: 0x04001637 RID: 5687
	private global::System.Windows.Forms.ToolStripMenuItem muBaGiaCan;

	// Token: 0x04001638 RID: 5688
	private global::System.Windows.Forms.ToolStripMenuItem muBaGiaKhon;

	// Token: 0x04001639 RID: 5689
	private global::CheckBoxNumberControl checkRadius;

	// Token: 0x0400163A RID: 5690
	private global::CheckBoxComboControl cboPet;

	// Token: 0x0400163B RID: 5691
	private global::GClass3 panelEx1;

	// Token: 0x0400163C RID: 5692
	private global::Class533 txtSearchFuntion;

	// Token: 0x0400163D RID: 5693
	private global::System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;

	// Token: 0x0400163E RID: 5694
	private global::System.Windows.Forms.GroupBox groupBox2;

	// Token: 0x0400163F RID: 5695
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04001640 RID: 5696
	private global::Class533 txtNewPass;

	// Token: 0x04001641 RID: 5697
	private global::System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;

	// Token: 0x04001642 RID: 5698
	private global::System.Windows.Forms.ToolStripMenuItem resetSpeedToolStripMenuItem;

	// Token: 0x04001643 RID: 5699
	private global::System.Windows.Forms.ToolStripMenuItem menuThemToaDo;

	// Token: 0x04001644 RID: 5700
	private global::System.Windows.Forms.ToolStripMenuItem menuTrieuTapTheo;

	// Token: 0x04001645 RID: 5701
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator31;

	// Token: 0x04001646 RID: 5702
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator15;

	// Token: 0x04001647 RID: 5703
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator38;

	// Token: 0x04001648 RID: 5704
	private global::System.Windows.Forms.Button button12;

	// Token: 0x04001649 RID: 5705
	private global::System.Windows.Forms.ToolStripMenuItem menuDiChuyenVongTron;

	// Token: 0x0400164A RID: 5706
	private global::System.Windows.Forms.Label lblIncome;

	// Token: 0x0400164B RID: 5707
	private global::System.Windows.Forms.ToolStripMenuItem menuDinhVi;

	// Token: 0x0400164C RID: 5708
	private global::System.Windows.Forms.ToolStripMenuItem menuDinhViThoLinhChau;

	// Token: 0x0400164D RID: 5709
	private global::System.Windows.Forms.ToolStripMenuItem muDinhViAllThoLinhChau;

	// Token: 0x0400164E RID: 5710
	private global::System.Windows.Forms.ToolStripMenuItem menuAllDinhViPhu;

	// Token: 0x0400164F RID: 5711
	private global::System.Windows.Forms.ToolStripMenuItem menuUse;

	// Token: 0x04001650 RID: 5712
	private global::System.Windows.Forms.ToolStripMenuItem menuUseThoLinhChau;

	// Token: 0x04001651 RID: 5713
	private global::System.Windows.Forms.ToolStripMenuItem menuUseDinhViPhu;

	// Token: 0x04001652 RID: 5714
	private global::System.Windows.Forms.ToolStripMenuItem menuUseTrieuTapLenh;

	// Token: 0x04001653 RID: 5715
	private global::System.Windows.Forms.ToolStripMenuItem menuTrieuTap;

	// Token: 0x04001654 RID: 5716
	private global::System.Windows.Forms.ToolStripMenuItem menuBuocTrieuTap;

	// Token: 0x04001655 RID: 5717
	private global::System.Windows.Forms.ToolStripMenuItem menuTrieuTapNhom;

	// Token: 0x04001656 RID: 5718
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLai;

	// Token: 0x04001657 RID: 5719
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiKinhNghiem;

	// Token: 0x04001658 RID: 5720
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiNoiTuc;

	// Token: 0x04001659 RID: 5721
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiThieuThatSon;

	// Token: 0x0400165A RID: 5722
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiYenTuO;

	// Token: 0x0400165B RID: 5723
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiTuTuyetTrang;

	// Token: 0x0400165C RID: 5724
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiPhucDia;

	// Token: 0x0400165D RID: 5725
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiVuongLang;

	// Token: 0x0400165E RID: 5726
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiTamThan;

	// Token: 0x0400165F RID: 5727
	private global::System.Windows.Forms.ToolStripMenuItem muNhanLaiPhieuMieuPhong;

	// Token: 0x04001660 RID: 5728
	private global::System.Windows.Forms.ToolStripMenuItem muTrangBi;

	// Token: 0x04001661 RID: 5729
	private global::System.Windows.Forms.ToolStripMenuItem menuThaoTrangBi;

	// Token: 0x04001662 RID: 5730
	private global::System.Windows.Forms.ToolStripMenuItem menuDeoTrangBi;

	// Token: 0x04001663 RID: 5731
	private global::System.Windows.Forms.ToolStripMenuItem menuDucLo;

	// Token: 0x04001664 RID: 5732
	private global::System.Windows.Forms.ToolStripMenuItem socket1;

	// Token: 0x04001665 RID: 5733
	private global::System.Windows.Forms.ToolStripMenuItem socket2;

	// Token: 0x04001666 RID: 5734
	private global::System.Windows.Forms.ToolStripMenuItem socket3;

	// Token: 0x04001667 RID: 5735
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator16;

	// Token: 0x04001668 RID: 5736
	private global::System.Windows.Forms.ToolTip toolTip_0;

	// Token: 0x04001669 RID: 5737
	private global::GClass3 panelEx3;

	// Token: 0x0400166A RID: 5738
	private global::System.Windows.Forms.ToolStripMenuItem menuLucPhu;

	// Token: 0x0400166B RID: 5739
	private global::System.Windows.Forms.ToolStripMenuItem menuThemPhu;

	// Token: 0x0400166C RID: 5740
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator20;

	// Token: 0x0400166D RID: 5741
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

	// Token: 0x0400166E RID: 5742
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

	// Token: 0x0400166F RID: 5743
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

	// Token: 0x04001670 RID: 5744
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;

	// Token: 0x04001671 RID: 5745
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;

	// Token: 0x04001672 RID: 5746
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;

	// Token: 0x04001673 RID: 5747
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;

	// Token: 0x04001674 RID: 5748
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;

	// Token: 0x04001675 RID: 5749
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;

	// Token: 0x04001676 RID: 5750
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;

	// Token: 0x04001677 RID: 5751
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;

	// Token: 0x04001678 RID: 5752
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;

	// Token: 0x04001679 RID: 5753
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_31;

	// Token: 0x0400167A RID: 5754
	private global::System.Windows.Forms.ToolStripMenuItem muToiLuyenThe;

	// Token: 0x0400167B RID: 5755
	private global::System.Windows.Forms.ToolStripMenuItem muToiLuyenBang;

	// Token: 0x0400167C RID: 5756
	private global::System.Windows.Forms.ToolStripMenuItem muToiLuyenHuyen;

	// Token: 0x0400167D RID: 5757
	private global::System.Windows.Forms.ToolStripMenuItem muToiLuyenHoa;

	// Token: 0x0400167E RID: 5758
	private global::System.Windows.Forms.ToolStripMenuItem muToiLuyenDoc;

	// Token: 0x0400167F RID: 5759
	private global::System.Windows.Forms.ToolStripMenuItem muTrungLau;

	// Token: 0x04001680 RID: 5760
	private global::System.Windows.Forms.ToolStripMenuItem menuLenhBai;

	// Token: 0x04001681 RID: 5761
	private global::System.Windows.Forms.ToolStripMenuItem menuNangBaoChau;

	// Token: 0x04001682 RID: 5762
	private global::System.Windows.Forms.ToolStripMenuItem menuRed;

	// Token: 0x04001683 RID: 5763
	private global::System.Windows.Forms.ToolStripMenuItem menuGreen;

	// Token: 0x04001684 RID: 5764
	private global::System.Windows.Forms.ToolStripMenuItem menuBlue;

	// Token: 0x04001685 RID: 5765
	private global::System.Windows.Forms.ToolStripMenuItem menuYellow;

	// Token: 0x04001686 RID: 5766
	private global::System.Windows.Forms.ToolStripMenuItem menuTangSaoLenhBai;

	// Token: 0x04001687 RID: 5767
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator29;

	// Token: 0x04001688 RID: 5768
	private global::System.Windows.Forms.ToolStripMenuItem muTangCapTruongThanhLongVan;

	// Token: 0x04001689 RID: 5769
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator41;

	// Token: 0x0400168A RID: 5770
	private global::System.Windows.Forms.ToolStripMenuItem muNgungTuBaoGiam;

	// Token: 0x0400168B RID: 5771
	private global::System.Windows.Forms.ToolStripMenuItem muCuongHoaDo;

	// Token: 0x0400168C RID: 5772
	private global::System.Windows.Forms.ToolStripMenuItem muCheThanKhi;

	// Token: 0x0400168D RID: 5773
	private global::System.Windows.Forms.ToolStripMenuItem menuGiamDinh;

	// Token: 0x0400168E RID: 5774
	private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

	// Token: 0x0400168F RID: 5775
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

	// Token: 0x04001690 RID: 5776
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

	// Token: 0x04001691 RID: 5777
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

	// Token: 0x04001692 RID: 5778
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;

	// Token: 0x04001693 RID: 5779
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;

	// Token: 0x04001694 RID: 5780
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;

	// Token: 0x04001695 RID: 5781
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;

	// Token: 0x04001696 RID: 5782
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;

	// Token: 0x04001697 RID: 5783
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;

	// Token: 0x04001698 RID: 5784
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;

	// Token: 0x04001699 RID: 5785
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;

	// Token: 0x0400169A RID: 5786
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;

	// Token: 0x0400169B RID: 5787
	private global::System.Windows.Forms.ToolStripMenuItem menuSkillStudy;

	// Token: 0x0400169C RID: 5788
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_32;

	// Token: 0x0400169D RID: 5789
	private global::System.Windows.Forms.ToolStripMenuItem lrn30;

	// Token: 0x0400169E RID: 5790
	private global::System.Windows.Forms.ToolStripMenuItem len40;

	// Token: 0x0400169F RID: 5791
	private global::System.Windows.Forms.ToolStripMenuItem len45;

	// Token: 0x040016A0 RID: 5792
	private global::System.Windows.Forms.ToolStripMenuItem len50;

	// Token: 0x040016A1 RID: 5793
	private global::System.Windows.Forms.ToolStripMenuItem len60;

	// Token: 0x040016A2 RID: 5794
	private global::System.Windows.Forms.ToolStripMenuItem len75;

	// Token: 0x040016A3 RID: 5795
	private global::System.Windows.Forms.ToolStripMenuItem len80;

	// Token: 0x040016A4 RID: 5796
	private global::System.Windows.Forms.ToolStripMenuItem len90;

	// Token: 0x040016A5 RID: 5797
	private global::System.Windows.Forms.ToolStripMenuItem len100;

	// Token: 0x040016A6 RID: 5798
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

	// Token: 0x040016A7 RID: 5799
	private global::System.Windows.Forms.ToolStripMenuItem menuTuLuyen;

	// Token: 0x040016A8 RID: 5800
	private global::System.Windows.Forms.ToolStripMenuItem muTuLuyenTheLuc;

	// Token: 0x040016A9 RID: 5801
	private global::System.Windows.Forms.ToolStripMenuItem muTuLuyenNoiLuc;

	// Token: 0x040016AA RID: 5802
	private global::System.Windows.Forms.ToolStripMenuItem muTuLuyenThanPhap;

	// Token: 0x040016AB RID: 5803
	private global::System.Windows.Forms.ToolStripMenuItem muTuLuyenCuongLuc;

	// Token: 0x040016AC RID: 5804
	private global::System.Windows.Forms.ToolStripMenuItem muTuLuyenTheNoiThan;

	// Token: 0x040016AD RID: 5805
	private global::System.Windows.Forms.ToolStripMenuItem muGiaiPhongChanNguyen;

	// Token: 0x040016AE RID: 5806
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;

	// Token: 0x040016AF RID: 5807
	private global::System.Windows.Forms.ToolStripMenuItem menuCold;

	// Token: 0x040016B0 RID: 5808
	private global::System.Windows.Forms.ToolStripMenuItem menuFire;

	// Token: 0x040016B1 RID: 5809
	private global::System.Windows.Forms.ToolStripMenuItem menuLight;

	// Token: 0x040016B2 RID: 5810
	private global::System.Windows.Forms.ToolStripMenuItem menuPoison;

	// Token: 0x040016B3 RID: 5811
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_33;

	// Token: 0x040016B4 RID: 5812
	private global::System.Windows.Forms.ToolStripMenuItem muLenGia;

	// Token: 0x040016B5 RID: 5813
	private global::System.Windows.Forms.ToolStripMenuItem menuThaoDeo;

	// Token: 0x040016B6 RID: 5814
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator12;

	// Token: 0x040016B7 RID: 5815
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_34;

	// Token: 0x040016B8 RID: 5816
	private global::System.Windows.Forms.ToolStripMenuItem muFuBen;

	// Token: 0x040016B9 RID: 5817
	private global::System.Windows.Forms.ToolStripMenuItem evTruPhiPhaTamQuan;

	// Token: 0x040016BA RID: 5818
	private global::System.Windows.Forms.ToolStripMenuItem evYenTuO;

	// Token: 0x040016BB RID: 5819
	private global::System.Windows.Forms.ToolStripMenuItem evThieuThatSon;

	// Token: 0x040016BC RID: 5820
	private global::System.Windows.Forms.ToolStripMenuItem evTuTuyetTrang;

	// Token: 0x040016BD RID: 5821
	private global::System.Windows.Forms.ToolStripMenuItem evBinhThanhKyTran;

	// Token: 0x040016BE RID: 5822
	private global::System.Windows.Forms.ToolStripMenuItem evVuongLang;

	// Token: 0x040016BF RID: 5823
	private global::System.Windows.Forms.ToolStripMenuItem evTamThan;

	// Token: 0x040016C0 RID: 5824
	private global::System.Windows.Forms.ToolStripMenuItem evPhieuMieuPhong;

	// Token: 0x040016C1 RID: 5825
	private global::System.Windows.Forms.ToolStripMenuItem evPhucDia;

	// Token: 0x040016C2 RID: 5826
	private global::System.Windows.Forms.ToolStripMenuItem evPhucDiaKho;

	// Token: 0x040016C3 RID: 5827
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator13;

	// Token: 0x040016C4 RID: 5828
	private global::System.Windows.Forms.ToolStripMenuItem muQ1ToChau;

	// Token: 0x040016C5 RID: 5829
	private global::System.Windows.Forms.ToolStripMenuItem muQ2ToChau;

	// Token: 0x040016C6 RID: 5830
	private global::System.Windows.Forms.ToolStripMenuItem muQ3ToChau;

	// Token: 0x040016C7 RID: 5831
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator19;

	// Token: 0x040016C8 RID: 5832
	private global::System.Windows.Forms.ToolStripMenuItem muQ1LauLan;

	// Token: 0x040016C9 RID: 5833
	private global::System.Windows.Forms.ToolStripMenuItem muQ2LauLan;

	// Token: 0x040016CA RID: 5834
	private global::System.Windows.Forms.ToolStripMenuItem muQ3LauLan;

	// Token: 0x040016CB RID: 5835
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator42;

	// Token: 0x040016CC RID: 5836
	private global::System.Windows.Forms.ToolStripMenuItem muThuyLao;

	// Token: 0x040016CD RID: 5837
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_35;

	// Token: 0x040016CE RID: 5838
	private global::System.Windows.Forms.ToolStripMenuItem muCanQuet;

	// Token: 0x040016CF RID: 5839
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator43;

	// Token: 0x040016D0 RID: 5840
	private global::System.Windows.Forms.ToolStripMenuItem muCQThuCong;

	// Token: 0x040016D1 RID: 5841
	private global::System.Windows.Forms.ToolStripMenuItem muCQAll;

	// Token: 0x040016D2 RID: 5842
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator44;

	// Token: 0x040016D3 RID: 5843
	private global::System.Windows.Forms.ToolStripMenuItem muCQPhucDiaKho;

	// Token: 0x040016D4 RID: 5844
	private global::System.Windows.Forms.ToolStripMenuItem muCQTamThan;

	// Token: 0x040016D5 RID: 5845
	private global::System.Windows.Forms.ToolStripMenuItem muCQKhieuChienPMP;

	// Token: 0x040016D6 RID: 5846
	private global::System.Windows.Forms.ToolStripMenuItem muCQVuongLang;

	// Token: 0x040016D7 RID: 5847
	private global::System.Windows.Forms.ToolStripMenuItem muCQPhucDia;

	// Token: 0x040016D8 RID: 5848
	private global::System.Windows.Forms.ToolStripMenuItem muCQTuTuyetTrang;

	// Token: 0x040016D9 RID: 5849
	private global::System.Windows.Forms.ToolStripMenuItem muCQThieuThatSon;

	// Token: 0x040016DA RID: 5850
	private global::System.Windows.Forms.ToolStripMenuItem muCQYenTuO;

	// Token: 0x040016DB RID: 5851
	private global::System.Windows.Forms.ToolStripMenuItem muCQTruPhiPhaTamQuan;

	// Token: 0x040016DC RID: 5852
	private global::System.Windows.Forms.ToolStripMenuItem muQuanSonHai;

	// Token: 0x040016DD RID: 5853
	private global::System.Windows.Forms.ToolStripMenuItem muPhonghoa;

	// Token: 0x040016DE RID: 5854
	private global::System.Windows.Forms.Panel panel2;

	// Token: 0x040016DF RID: 5855
	private global::System.Windows.Forms.Panel panel5;

	// Token: 0x040016E0 RID: 5856
	private global::System.Windows.Forms.Panel panel8;

	// Token: 0x040016E1 RID: 5857
	private global::System.Windows.Forms.CheckBox checkTrongTrot;

	// Token: 0x040016E2 RID: 5858
	private global::System.Windows.Forms.Panel panel10;

	// Token: 0x040016E3 RID: 5859
	private global::System.Windows.Forms.CheckBox checkCraft;

	// Token: 0x040016E4 RID: 5860
	private global::GClass3 panelEx4;

	// Token: 0x040016E5 RID: 5861
	private global::GClass3 grNM;

	// Token: 0x040016E6 RID: 5862
	private global::System.Windows.Forms.CheckBox checkNM;

	// Token: 0x040016E7 RID: 5863
	private global::System.Windows.Forms.ComboBox cboDaTaoDo;

	// Token: 0x040016E8 RID: 5864
	private global::GClass3 panelEx2;

	// Token: 0x040016E9 RID: 5865
	private global::GClass3 panelEx5;

	// Token: 0x040016EA RID: 5866
	private global::System.Windows.Forms.ToolStripMenuItem muNhanPhiThuy;

	// Token: 0x040016EB RID: 5867
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator33;

	// Token: 0x040016EC RID: 5868
	private global::System.Windows.Forms.ToolStripMenuItem muThanKhi9Sao;

	// Token: 0x040016ED RID: 5869
	private global::System.Windows.Forms.ToolStripMenuItem muThienKiepLau;

	// Token: 0x040016EE RID: 5870
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator45;

	// Token: 0x040016EF RID: 5871
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_36;

	// Token: 0x040016F0 RID: 5872
	private global::System.Windows.Forms.ToolStripMenuItem muGom;

	// Token: 0x040016F1 RID: 5873
	private global::System.Windows.Forms.ToolStripMenuItem muDuaKNBCho;

	// Token: 0x040016F2 RID: 5874
	private global::System.Windows.Forms.ToolStripMenuItem muDuaDoChoTa;

	// Token: 0x040016F3 RID: 5875
	private global::System.Windows.Forms.ToolStripMenuItem muDuaTangBaoDo;

	// Token: 0x040016F4 RID: 5876
	private global::System.Windows.Forms.ToolStripMenuItem menuMoSap;

	// Token: 0x040016F5 RID: 5877
	private global::System.Windows.Forms.ToolStripMenuItem menuChayThuongNhan;

	// Token: 0x040016F6 RID: 5878
	private global::System.Windows.Forms.ToolStripMenuItem menuStopTrader;

	// Token: 0x040016F7 RID: 5879
	private global::System.Windows.Forms.ToolStripMenuItem menuQuayVe;

	// Token: 0x040016F8 RID: 5880
	private global::System.Windows.Forms.ToolStripMenuItem menuDiToi;

	// Token: 0x040016F9 RID: 5881
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_37;

	// Token: 0x040016FA RID: 5882
	private global::System.Windows.Forms.ToolStripMenuItem muTamAnhCuuLeThuong;

	// Token: 0x040016FB RID: 5883
	private global::System.Windows.Forms.ToolStripMenuItem muTamAnhCuuLeKho;

	// Token: 0x040016FC RID: 5884
	private global::System.Windows.Forms.ToolStripMenuItem menuChoGiao;

	// Token: 0x040016FD RID: 5885
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

	// Token: 0x040016FE RID: 5886
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator37;

	// Token: 0x040016FF RID: 5887
	private global::System.Windows.Forms.Label lblTrader;

	// Token: 0x04001700 RID: 5888
	public global::System.Windows.Forms.ToolStripMenuItem muNhapCode;

	// Token: 0x04001701 RID: 5889
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator23;

	// Token: 0x04001702 RID: 5890
	private global::System.Windows.Forms.Panel panel12;

	// Token: 0x04001703 RID: 5891
	private global::System.Windows.Forms.Panel panel4;

	// Token: 0x04001704 RID: 5892
	private global::System.Windows.Forms.Panel panel11;

	// Token: 0x04001705 RID: 5893
	private global::System.Windows.Forms.SplitContainer splitContainer2;

	// Token: 0x04001706 RID: 5894
	private global::System.Windows.Forms.TabPage tabSetting;

	// Token: 0x04001707 RID: 5895
	private global::System.Windows.Forms.TabPage tabConfig;

	// Token: 0x04001708 RID: 5896
	private global::System.Windows.Forms.TabPage tabChat;

	// Token: 0x04001709 RID: 5897
	private global::System.Windows.Forms.ToolStripMenuItem menuLayDoKhongCoDinh;

	// Token: 0x0400170A RID: 5898
	private global::System.Windows.Forms.PictureBox picQr;

	// Token: 0x0400170B RID: 5899
	private global::System.Windows.Forms.ContextMenuStrip menuQr;

	// Token: 0x0400170C RID: 5900
	private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

	// Token: 0x0400170D RID: 5901
	private global::System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;

	// Token: 0x0400170E RID: 5902
	private global::Class533 txtiAutoUser;

	// Token: 0x0400170F RID: 5903
	private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

	// Token: 0x04001710 RID: 5904
	private global::System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;

	// Token: 0x04001711 RID: 5905
	private global::System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem1;

	// Token: 0x04001712 RID: 5906
	private global::System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;

	// Token: 0x04001713 RID: 5907
	private global::System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;

	// Token: 0x04001714 RID: 5908
	private global::System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;

	// Token: 0x04001715 RID: 5909
	private global::System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;

	// Token: 0x04001716 RID: 5910
	private global::System.Windows.Forms.Button btnDayVNG;

	// Token: 0x04001717 RID: 5911
	private global::System.Windows.Forms.Button btnDayPRI;

	// Token: 0x04001718 RID: 5912
	private global::System.Windows.Forms.Button btnDayORI;

	// Token: 0x04001719 RID: 5913
	private global::System.Windows.Forms.Button btnBlance;

	// Token: 0x0400171A RID: 5914
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

	// Token: 0x0400171B RID: 5915
	private global::System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;

	// Token: 0x0400171C RID: 5916
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_38;

	// Token: 0x0400171D RID: 5917
	private global::System.Windows.Forms.Button button1;

	// Token: 0x0400171E RID: 5918
	private global::System.Windows.Forms.Button button2;

	// Token: 0x0400171F RID: 5919
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04001720 RID: 5920
	private global::System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;

	// Token: 0x04001721 RID: 5921
	private global::System.Windows.Forms.ToolStripMenuItem quitNRelogToolStripMenuItem;

	// Token: 0x04001722 RID: 5922
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_39;

	// Token: 0x04001723 RID: 5923
	private global::System.Windows.Forms.LinkLabel linkLabel1;

	// Token: 0x04001724 RID: 5924
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_40;

	// Token: 0x04001725 RID: 5925
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_41;

	// Token: 0x04001726 RID: 5926
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_42;

	// Token: 0x04001727 RID: 5927
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_43;

	// Token: 0x04001728 RID: 5928
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_44;

	// Token: 0x04001729 RID: 5929
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_45;

	// Token: 0x0400172A RID: 5930
	private global::System.Windows.Forms.ToolStripMenuItem MenuAcNhanCoc;

	// Token: 0x0400172B RID: 5931
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_46;

	// Token: 0x0400172C RID: 5932
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_47;

	// Token: 0x0400172D RID: 5933
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_48;

	// Token: 0x0400172E RID: 5934
	private global::System.Windows.Forms.ToolStripMenuItem menuChoiCungNienThu;

	// Token: 0x0400172F RID: 5935
	private global::System.Windows.Forms.ToolStripMenuItem menuAnTiec;

	// Token: 0x04001730 RID: 5936
	private global::System.Windows.Forms.ToolStripMenuItem menuDoiBoiDiep;

	// Token: 0x04001731 RID: 5937
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_49;

	// Token: 0x04001732 RID: 5938
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_50;

	// Token: 0x04001733 RID: 5939
	private global::System.Windows.Forms.ToolStripMenuItem menuLen8Sao;

	// Token: 0x04001734 RID: 5940
	private global::System.Windows.Forms.ToolStripMenuItem menuNhanBachHoaHuongNang;

	// Token: 0x04001735 RID: 5941
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_51;

	// Token: 0x04001736 RID: 5942
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_52;

	// Token: 0x04001737 RID: 5943
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_53;

	// Token: 0x04001738 RID: 5944
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_54;

	// Token: 0x04001739 RID: 5945
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_55;

	// Token: 0x0400173A RID: 5946
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_56;

	// Token: 0x0400173B RID: 5947
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_57;

	// Token: 0x0400173C RID: 5948
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_58;

	// Token: 0x0400173D RID: 5949
	private global::System.Windows.Forms.ToolStripMenuItem muaX2ToolStripMenuItem;

	// Token: 0x0400173E RID: 5950
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_59;

	// Token: 0x0400173F RID: 5951
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_60;

	// Token: 0x04001740 RID: 5952
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_61;

	// Token: 0x04001741 RID: 5953
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_62;

	// Token: 0x04001742 RID: 5954
	private global::System.Windows.Forms.ToolStripMenuItem menuQ3ToChauNhanh;

	// Token: 0x04001743 RID: 5955
	private global::System.Windows.Forms.ToolStripMenuItem menuQ3ToChauCham;

	// Token: 0x04001744 RID: 5956
	private global::System.Windows.Forms.ToolStripMenuItem menuQ3LauLanNhanh;

	// Token: 0x04001745 RID: 5957
	private global::System.Windows.Forms.ToolStripMenuItem menuQ3LauLanCham;

	// Token: 0x04001746 RID: 5958
	private global::System.Windows.Forms.ToolStripMenuItem menuSatTinh;

	// Token: 0x04001747 RID: 5959
	private global::System.Windows.Forms.ToolStripMenuItem menuMuaCuongHoaLo;

	// Token: 0x04001748 RID: 5960
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_63;

	// Token: 0x04001749 RID: 5961
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_64;

	// Token: 0x0400174A RID: 5962
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_65;

	// Token: 0x0400174B RID: 5963
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_66;

	// Token: 0x0400174C RID: 5964
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_67;

	// Token: 0x0400174D RID: 5965
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_68;

	// Token: 0x0400174E RID: 5966
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_69;

	// Token: 0x0400174F RID: 5967
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_70;

	// Token: 0x04001750 RID: 5968
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_71;

	// Token: 0x04001751 RID: 5969
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_72;

	// Token: 0x04001752 RID: 5970
	private global::System.Windows.Forms.Button button5;

	// Token: 0x04001753 RID: 5971
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_73;

	// Token: 0x04001754 RID: 5972
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_74;

	// Token: 0x04001755 RID: 5973
	private global::System.Windows.Forms.ToolStripMenuItem muVoDao;

	// Token: 0x04001756 RID: 5974
	private global::System.Windows.Forms.ToolStripMenuItem muVoDao1;

	// Token: 0x04001757 RID: 5975
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_75;

	// Token: 0x04001758 RID: 5976
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_76;

	// Token: 0x04001759 RID: 5977
	private global::System.Windows.Forms.ToolStripMenuItem canVQ1ToChau;

	// Token: 0x0400175A RID: 5978
	private global::System.Windows.Forms.ToolStripMenuItem canVQ2ToChau;

	// Token: 0x0400175B RID: 5979
	private global::System.Windows.Forms.ToolStripMenuItem canVQ3ToChau;

	// Token: 0x0400175C RID: 5980
	private global::System.Windows.Forms.ToolStripMenuItem canVSatTInh;

	// Token: 0x0400175D RID: 5981
	private global::System.Windows.Forms.ToolStripMenuItem canVQ1LauLan;

	// Token: 0x0400175E RID: 5982
	private global::System.Windows.Forms.ToolStripMenuItem canVQ2LauLan;

	// Token: 0x0400175F RID: 5983
	private global::System.Windows.Forms.ToolStripMenuItem canVQ3LauLan;

	// Token: 0x04001760 RID: 5984
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ1ToChau;

	// Token: 0x04001761 RID: 5985
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ2ToChau;

	// Token: 0x04001762 RID: 5986
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ3ToChau;

	// Token: 0x04001763 RID: 5987
	private global::System.Windows.Forms.ToolStripMenuItem menuCQSatTinh;

	// Token: 0x04001764 RID: 5988
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ1LauLan;

	// Token: 0x04001765 RID: 5989
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ2LauLan;

	// Token: 0x04001766 RID: 5990
	private global::System.Windows.Forms.ToolStripMenuItem menuCQQ3LauLan;

	// Token: 0x04001767 RID: 5991
	private global::System.Windows.Forms.ToolStripMenuItem menuCQYenTuO;

	// Token: 0x04001768 RID: 5992
	private global::System.Windows.Forms.ToolStripMenuItem menuCQSCPMP;

	// Token: 0x04001769 RID: 5993
	private global::System.Windows.Forms.ToolStripMenuItem menuCQKCPMP;

	// Token: 0x0400176A RID: 5994
	private global::System.Windows.Forms.ToolStripMenuItem menuCQThuyNguyetSonTrang;

	// Token: 0x0400176B RID: 5995
	public global::Class533 txtHWID;

	// Token: 0x0400176C RID: 5996
	public global::System.Windows.Forms.CheckBox checkSkill;

	// Token: 0x0400176D RID: 5997
	private global::System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;

	// Token: 0x0400176E RID: 5998
	private global::System.Windows.Forms.ToolStripMenuItem menuTNST;

	// Token: 0x0400176F RID: 5999
	private global::System.Windows.Forms.ToolStripMenuItem menuThanhKhuu;

	// Token: 0x04001770 RID: 6000
	private global::System.Windows.Forms.TabPage tabPage1;

	// Token: 0x04001771 RID: 6001
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04001772 RID: 6002
	private global::Class286 checkHuyCraft;

	// Token: 0x04001773 RID: 6003
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04001774 RID: 6004
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04001775 RID: 6005
	private global::System.Windows.Forms.NumericUpDown numHuyCraftLine;

	// Token: 0x04001776 RID: 6006
	private global::System.Windows.Forms.NumericUpDown numHuyCraftStar;

	// Token: 0x04001777 RID: 6007
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_77;

	// Token: 0x04001778 RID: 6008
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_78;

	// Token: 0x04001779 RID: 6009
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_79;
}
