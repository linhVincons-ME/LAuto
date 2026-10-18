using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using _i;
using _i.Properties;

// Token: 0x02000268 RID: 616
internal partial class GUI : Form
{
	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x060020AD RID: 8365 RVA: 0x00015DE3 File Offset: 0x00013FE3
	// (set) Token: 0x060020AE RID: 8366 RVA: 0x00015DEA File Offset: 0x00013FEA
	public static string String_0 { get; set; } = "1";

	// Token: 0x060020AF RID: 8367 RVA: 0x000EC848 File Offset: 0x000EAA48
	public List<ToolStripMenuItem> method_0(ToolStripMenuItem toolStripMenuItem_80)
	{
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		foreach (object obj in toolStripMenuItem_80.DropDownItems)
		{
			ToolStripItem toolStripItem = (ToolStripItem)obj;
			if (toolStripItem is ToolStripMenuItem)
			{
				list.Add((ToolStripMenuItem)toolStripItem);
				this.method_1((ToolStripMenuItem)toolStripItem, list);
			}
		}
		return list;
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000EC8C4 File Offset: 0x000EAAC4
	private void method_1(ToolStripMenuItem toolStripMenuItem_80, List<ToolStripMenuItem> list_1)
	{
		foreach (object obj in toolStripMenuItem_80.DropDownItems)
		{
			ToolStripItem toolStripItem = (ToolStripItem)obj;
			if (toolStripItem is ToolStripMenuItem)
			{
				list_1.Add((ToolStripMenuItem)toolStripItem);
				if (((ToolStripMenuItem)toolStripItem).HasDropDownItems)
				{
					this.method_1((ToolStripMenuItem)toolStripItem, list_1);
				}
			}
		}
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00015DF2 File Offset: 0x00013FF2
	// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00015DFA File Offset: 0x00013FFA
	private Dictionary<ToolStripMenuItem, Enum17[]> Dictionary_0 { get; set; } = new Dictionary<ToolStripMenuItem, Enum17[]>();

	// Token: 0x060020B3 RID: 8371 RVA: 0x00015E03 File Offset: 0x00014003
	public static void smethod_0()
	{
		GUI.smethod_2();
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(GUI.smethod_1));
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x00005BAB File Offset: 0x00003DAB
	private static bool smethod_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000EC948 File Offset: 0x000EAB48
	public static bool smethod_2()
	{
		Assembly assembly = Assembly.GetAssembly(typeof(SettingsSection));
		if (assembly != null)
		{
			Type type = assembly.GetType("System.Net.Configuration.SettingsSectionInternal");
			if (type != null)
			{
				object obj = type.InvokeMember("Section", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, Array.Empty<object>());
				if (obj != null)
				{
					FieldInfo field = type.GetField("useUnsafeHeaderParsing", BindingFlags.Instance | BindingFlags.NonPublic);
					if (field != null)
					{
						field.SetValue(obj, true);
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000EC9C8 File Offset: 0x000EABC8
	public GUI()
	{
		try
		{
			GUI.smethod_0();
		}
		catch
		{
		}
		Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
		Application.ThreadException += GUI.Class403.f_A642BF9F.method_0;
		AppDomain.CurrentDomain.UnhandledException += GUI.Class403.f_A642BF9F.method_1;
		this.InitializeComponent();
		this.ApplyModernDarkCyberTheme();
		this.Text = string.Concat(new string[]
		{
			"LAuto v2 ",
			Settings.Default.Version,
			" - ",
			(100 - this.Int32_0).ToString(),
			"% Mem + ",
			this.Int32_1.ToString(),
			"% CPU [",
			GUI.String_0,
			"]"
		});
		GUI.GUI_0 = this;
		Control.CheckForIllegalCrossThreadCalls = false;
		if (!File.Exists("iAuto.Go.json"))
		{
			File.WriteAllBytes("iAuto.Go.json", Class616.Byte_1);
		}
		try
		{
			GUI.String_1 = "iAuto.Login";
			if (!Directory.Exists(GUI.String_1))
			{
				Directory.CreateDirectory(GUI.String_1);
			}
			try
			{
				foreach (string text in Directory.GetFiles("iAuto.Config", "*.*", SearchOption.AllDirectories))
				{
					if (text.EndsWith(".xml"))
					{
						string text2 = GUI.String_1 + "\\" + Path.GetFileName(text);
						if (!File.Exists(text2))
						{
							File.Move(text, text2);
						}
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		Class106.Class210_0 = Class210.smethod_0("-iAuto.ini");
		Class226.Class210_0 = GUI.Class210_0;
		Class521.smethod_0();
		Class226.smethod_1();
		try
		{
			if (!Class226.Boolean_147)
			{
				this.method_3();
			}
		}
		catch
		{
		}
		base.Icon = Class616.Icon_0;
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		try
		{
			// LAuto: self-update is disabled, so the embedded updater is no longer written next to the exe
			File.WriteAllBytes("iAuto.tieudattai.dll", Class616.Byte_4);
			File.WriteAllBytes("iAuto.tieudattai.x86.dll", Class616.Byte_5);
		}
		catch
		{
		}
		Dictionary<ToolStripMenuItem, Enum17[]> dictionary = new Dictionary<ToolStripMenuItem, Enum17[]>();
		ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_42;
		dictionary[toolStripMenuItem] = new Enum17[] { Enum17.BachHoaDuyen };
		ToolStripMenuItem toolStripMenuItem2 = this.menuHocCheDo;
		dictionary[toolStripMenuItem2] = new Enum17[] { Enum17.Hoc3Q };
		ToolStripMenuItem toolStripMenuItem3 = this.menuLayDoKhongCoDinh;
		dictionary[toolStripMenuItem3] = new Enum17[] { Enum17.LayDoKhongCoDinh };
		ToolStripMenuItem toolStripMenuItem4 = this.menuChoGiao;
		dictionary[toolStripMenuItem4] = new Enum17[] { Enum17.ChoGiaoBaoTangDo };
		ToolStripMenuItem toolStripMenuItem5 = this.menuMoSap;
		dictionary[toolStripMenuItem5] = new Enum17[] { Enum17.TreoShop };
		ToolStripMenuItem toolStripMenuItem6 = this.menuUseDinhViPhu;
		dictionary[toolStripMenuItem6] = new Enum17[] { Enum17.DungDinhViPhu };
		ToolStripMenuItem toolStripMenuItem7 = this.menuAllDinhViPhu;
		dictionary[toolStripMenuItem7] = new Enum17[] { Enum17.DinhViPhu };
		ToolStripMenuItem toolStripMenuItem8 = this.toolStripMenuItem_64;
		dictionary[toolStripMenuItem8] = new Enum17[] { Enum17.CuongHoaDoTayNai };
		ToolStripMenuItem toolStripMenuItem9 = this.menuUseTrieuTapLenh;
		dictionary[toolStripMenuItem9] = new Enum17[] { Enum17.DungMonPhaiTrieuTapLenh };
		ToolStripMenuItem toolStripMenuItem10 = this.muQuayVeDaiLy;
		dictionary[toolStripMenuItem10] = new Enum17[] { Enum17.QuayVeDaily };
		ToolStripMenuItem toolStripMenuItem11 = this.menuUseThoLinhChau;
		dictionary[toolStripMenuItem11] = new Enum17[] { Enum17.DungThoLinhChau };
		ToolStripMenuItem toolStripMenuItem12 = this.muThinhGiaoBiKy;
		dictionary[toolStripMenuItem12] = new Enum17[] { Enum17.ThinhGiaoBiKy };
		ToolStripMenuItem toolStripMenuItem13 = this.muThienSuKyDai;
		dictionary[toolStripMenuItem13] = new Enum17[] { Enum17.ThienSuKyDai };
		ToolStripMenuItem toolStripMenuItem14 = this.muBaoThachBieuTang;
		dictionary[toolStripMenuItem14] = new Enum17[]
		{
			Enum17.ThienSuKyDai,
			Enum17.BaoThachBieuTang
		};
		ToolStripMenuItem toolStripMenuItem15 = this.muThongBao;
		dictionary[toolStripMenuItem15] = new Enum17[] { Enum17.ThongBao };
		ToolStripMenuItem toolStripMenuItem16 = this.muToiLuyenThe;
		dictionary[toolStripMenuItem16] = new Enum17[] { Enum17.ToiLuyenThe };
		ToolStripMenuItem toolStripMenuItem17 = this.muToiLuyenBang;
		dictionary[toolStripMenuItem17] = new Enum17[] { Enum17.ToiLuyenBang };
		ToolStripMenuItem toolStripMenuItem18 = this.muNgungTuBaoGiam;
		dictionary[toolStripMenuItem18] = new Enum17[] { Enum17.NgungTuBaoGiam };
		ToolStripMenuItem toolStripMenuItem19 = this.muNhanLenhBai;
		dictionary[toolStripMenuItem19] = new Enum17[] { Enum17.NhanLenhBai };
		ToolStripMenuItem toolStripMenuItem20 = this.muToiLuyenHuyen;
		dictionary[toolStripMenuItem20] = new Enum17[] { Enum17.ToiLuyenHuyen };
		ToolStripMenuItem toolStripMenuItem21 = this.muToiLuyenHoa;
		dictionary[toolStripMenuItem21] = new Enum17[] { Enum17.ToiLuyenHoa };
		ToolStripMenuItem toolStripMenuItem22 = this.muToiLuyenDoc;
		dictionary[toolStripMenuItem22] = new Enum17[] { Enum17.ToiLuyenDoc };
		ToolStripMenuItem toolStripMenuItem23 = this.muTrungLau;
		dictionary[toolStripMenuItem23] = new Enum17[] { Enum17.TinhThongTrungLau };
		ToolStripMenuItem toolStripMenuItem24 = this.mu200ReTranh;
		dictionary[toolStripMenuItem24] = new Enum17[] { Enum17.Mua200Co20DoChoi };
		ToolStripMenuItem toolStripMenuItem25 = this.muNhanLaiKinhNghiem;
		dictionary[toolStripMenuItem25] = new Enum17[] { Enum17.NhanLaiKinhNghiem };
		ToolStripMenuItem toolStripMenuItem26 = this.muNhanLaiNoiTuc;
		dictionary[toolStripMenuItem26] = new Enum17[] { Enum17.NhanLaiNoiTuc };
		ToolStripMenuItem toolStripMenuItem27 = this.muNhanLaiThieuThatSon;
		dictionary[toolStripMenuItem27] = new Enum17[] { Enum17.NhanLaiThieuThatSon };
		ToolStripMenuItem toolStripMenuItem28 = this.muNhanLaiYenTuO;
		dictionary[toolStripMenuItem28] = new Enum17[] { Enum17.NhanLaiYenTuO };
		ToolStripMenuItem toolStripMenuItem29 = this.muNhanLaiTuTuyetTrang;
		dictionary[toolStripMenuItem29] = new Enum17[] { Enum17.NhanLaiTuTuyetTrang };
		ToolStripMenuItem toolStripMenuItem30 = this.muNhanLaiPhucDia;
		dictionary[toolStripMenuItem30] = new Enum17[] { Enum17.NhanLaiPhucDia };
		ToolStripMenuItem toolStripMenuItem31 = this.muNhanLaiVuongLang;
		dictionary[toolStripMenuItem31] = new Enum17[] { Enum17.NhanLaiVuongLang };
		ToolStripMenuItem toolStripMenuItem32 = this.muNhanLaiTamThan;
		dictionary[toolStripMenuItem32] = new Enum17[] { Enum17.NhanLaiTamThan };
		ToolStripMenuItem toolStripMenuItem33 = this.muNhanLaiPhieuMieuPhong;
		dictionary[toolStripMenuItem33] = new Enum17[] { Enum17.NhanLaiPhieuMieuPhong };
		ToolStripMenuItem toolStripMenuItem34 = this.toolStripMenuItem_12;
		dictionary[toolStripMenuItem34] = new Enum17[] { Enum17.MoShopQuanSonHai };
		ToolStripMenuItem toolStripMenuItem35 = this.toolStripMenuItem_29;
		dictionary[toolStripMenuItem35] = new Enum17[] { Enum17.MoShopTinhBan };
		ToolStripMenuItem toolStripMenuItem36 = this.toolStripMenuItem_32;
		dictionary[toolStripMenuItem36] = new Enum17[] { Enum17.NangBuffMau };
		ToolStripMenuItem toolStripMenuItem37 = this.muKiemTung;
		dictionary[toolStripMenuItem37] = new Enum17[] { Enum17.KiemTungQuanHung };
		ToolStripMenuItem toolStripMenuItem38 = this.muNhanThuongTriVu;
		dictionary[toolStripMenuItem38] = new Enum17[] { Enum17.NhanThuongTriVu };
		ToolStripMenuItem toolStripMenuItem39 = this.muNhanx2x3VoY;
		dictionary[toolStripMenuItem39] = new Enum17[] { Enum17.Nhanx2x3VoY };
		ToolStripMenuItem toolStripMenuItem40 = this.muRotRuou;
		dictionary[toolStripMenuItem40] = new Enum17[] { Enum17.RotRuou };
		ToolStripMenuItem toolStripMenuItem41 = this.muQ1LauLan;
		dictionary[toolStripMenuItem41] = new Enum17[] { Enum17.DatDoiQ1LauLan };
		ToolStripMenuItem toolStripMenuItem42 = this.muQ2LauLan;
		dictionary[toolStripMenuItem42] = new Enum17[] { Enum17.DatDoiQ2LauLan };
		ToolStripMenuItem toolStripMenuItem43 = this.menuQ3LauLanNhanh;
		dictionary[toolStripMenuItem43] = new Enum17[] { Enum17.DatDoiQ3LauLan };
		ToolStripMenuItem toolStripMenuItem44 = this.menuQ3LauLanCham;
		dictionary[toolStripMenuItem44] = new Enum17[] { Enum17.DatDoiQ3LauLanCham };
		ToolStripMenuItem toolStripMenuItem45 = this.muQ1ToChau;
		dictionary[toolStripMenuItem45] = new Enum17[] { Enum17.DatDoiQ1ToChau };
		ToolStripMenuItem toolStripMenuItem46 = this.muQ2ToChau;
		dictionary[toolStripMenuItem46] = new Enum17[] { Enum17.DatDoiQ2ToChau };
		ToolStripMenuItem toolStripMenuItem47 = this.menuQ3ToChauNhanh;
		dictionary[toolStripMenuItem47] = new Enum17[] { Enum17.DatDoiQ3ToChau };
		ToolStripMenuItem toolStripMenuItem48 = this.menuQ3ToChauCham;
		dictionary[toolStripMenuItem48] = new Enum17[] { Enum17.DatDoiQ3ToChauCham };
		ToolStripMenuItem toolStripMenuItem49 = this.muThuyLao;
		dictionary[toolStripMenuItem49] = new Enum17[] { Enum17.DatDoiThuyLao };
		ToolStripMenuItem toolStripMenuItem50 = this.muThuongNghiep;
		dictionary[toolStripMenuItem50] = new Enum17[] { Enum17.NhiemVuThuongNghiep };
		ToolStripMenuItem toolStripMenuItem51 = this.muCongTrinh;
		dictionary[toolStripMenuItem51] = new Enum17[] { Enum17.NhiemVuCongTrinh };
		ToolStripMenuItem toolStripMenuItem52 = this.muKhuyechTruong;
		dictionary[toolStripMenuItem52] = new Enum17[] { Enum17.NhiemVuKhuyechTruong };
		ToolStripMenuItem toolStripMenuItem53 = this.muKyThuat;
		dictionary[toolStripMenuItem53] = new Enum17[] { Enum17.NhiemVuKyThuat };
		ToolStripMenuItem toolStripMenuItem54 = this.muPhatTrien;
		dictionary[toolStripMenuItem54] = new Enum17[] { Enum17.NhiemVuPhatTrien };
		ToolStripMenuItem toolStripMenuItem55 = this.muXayDung;
		dictionary[toolStripMenuItem55] = new Enum17[] { Enum17.NhiemVuXayDung };
		ToolStripMenuItem toolStripMenuItem56 = this.muNghienCuu;
		dictionary[toolStripMenuItem56] = new Enum17[] { Enum17.NhiemVuNghienCuu };
		ToolStripMenuItem toolStripMenuItem57 = this.muQuocPhong;
		dictionary[toolStripMenuItem57] = new Enum17[] { Enum17.NhiemVuQuocPhong };
		ToolStripMenuItem toolStripMenuItem58 = this.muBaoVeBang;
		dictionary[toolStripMenuItem58] = new Enum17[] { Enum17.BaoVeBang };
		ToolStripMenuItem toolStripMenuItem59 = this.muTriLieu;
		dictionary[toolStripMenuItem59] = new Enum17[] { Enum17.TriLieu };
		ToolStripMenuItem toolStripMenuItem60 = this.muDiBanRac;
		dictionary[toolStripMenuItem60] = new Enum17[] { Enum17.BanRac };
		ToolStripMenuItem toolStripMenuItem61 = this.muCatDo;
		dictionary[toolStripMenuItem61] = new Enum17[]
		{
			Enum17.CatDo,
			Enum17.CatVang
		};
		ToolStripMenuItem toolStripMenuItem62 = this.muLayDo;
		dictionary[toolStripMenuItem62] = new Enum17[] { Enum17.LayDo };
		ToolStripMenuItem toolStripMenuItem63 = this.muLayDoLayVang;
		dictionary[toolStripMenuItem63] = new Enum17[]
		{
			Enum17.LayDo,
			Enum17.LayVang
		};
		ToolStripMenuItem toolStripMenuItem64 = this.muTriLieuBanRacCatDo;
		dictionary[toolStripMenuItem64] = new Enum17[]
		{
			Enum17.CatVang,
			Enum17.BanRac,
			Enum17.CatDo,
			Enum17.TriLieu
		};
		ToolStripMenuItem toolStripMenuItem65 = this.muMoShopTrungDo;
		dictionary[toolStripMenuItem65] = new Enum17[] { Enum17.MoShopTrungDo };
		ToolStripMenuItem toolStripMenuItem66 = this.muMoShopBachBaoCac;
		dictionary[toolStripMenuItem66] = new Enum17[] { Enum17.MoShopBachBaoCac };
		ToolStripMenuItem toolStripMenuItem67 = this.muMoShopHungBa;
		dictionary[toolStripMenuItem67] = new Enum17[] { Enum17.MoShopHungBa };
		ToolStripMenuItem toolStripMenuItem68 = this.muMoTiemThuoc;
		dictionary[toolStripMenuItem68] = new Enum17[] { Enum17.MoTiemThuoc };
		ToolStripMenuItem toolStripMenuItem69 = this.muMoShopVanCam;
		dictionary[toolStripMenuItem69] = new Enum17[] { Enum17.MoShopVanCam };
		ToolStripMenuItem toolStripMenuItem70 = this.muTuLuyenCuongLuc;
		dictionary[toolStripMenuItem70] = new Enum17[] { Enum17.TuLuyenCuongLuc };
		ToolStripMenuItem toolStripMenuItem71 = this.muTuLuyenNoiLuc;
		dictionary[toolStripMenuItem71] = new Enum17[] { Enum17.TuLuyenNoiLuc };
		ToolStripMenuItem toolStripMenuItem72 = this.muTuLuyenThanPhap;
		dictionary[toolStripMenuItem72] = new Enum17[] { Enum17.TuLuyenThanPhap };
		ToolStripMenuItem toolStripMenuItem73 = this.muTuLuyenTheLuc;
		dictionary[toolStripMenuItem73] = new Enum17[] { Enum17.TuLuyenTheLuc };
		ToolStripMenuItem toolStripMenuItem74 = this.muTuLuyenTheNoiThan;
		dictionary[toolStripMenuItem74] = new Enum17[]
		{
			Enum17.TuLuyenNoiLuc,
			Enum17.TuLuyenThanPhap,
			Enum17.TuLuyenTheLuc
		};
		ToolStripMenuItem toolStripMenuItem75 = this.muPhanGiaiTrangBijPet;
		dictionary[toolStripMenuItem75] = new Enum17[] { Enum17.PhanGiaiTrangBiPet };
		ToolStripMenuItem toolStripMenuItem76 = this.muTucCau;
		dictionary[toolStripMenuItem76] = new Enum17[] { Enum17.DatDoiTucCau };
		ToolStripMenuItem toolStripMenuItem77 = this.muNhanx2;
		dictionary[toolStripMenuItem77] = new Enum17[] { Enum17.NhanX2 };
		ToolStripMenuItem toolStripMenuItem78 = this.muDongx2;
		dictionary[toolStripMenuItem78] = new Enum17[] { Enum17.DongX2 };
		ToolStripMenuItem toolStripMenuItem79 = this.muDiMuaNgua;
		dictionary[toolStripMenuItem79] = new Enum17[] { Enum17.DiMuaNga };
		ToolStripMenuItem toolStripMenuItem80 = this.muNopTuViHuyTinh;
		dictionary[toolStripMenuItem80] = new Enum17[] { Enum17.NopTuViHuyTinh };
		ToolStripMenuItem toolStripMenuItem81 = this.muThanhLyNhiemVu;
		dictionary[toolStripMenuItem81] = new Enum17[] { Enum17.ThanhLyNhiemVu };
		ToolStripMenuItem toolStripMenuItem82 = this.muGiaoNguHanhPhapThiep;
		dictionary[toolStripMenuItem82] = new Enum17[] { Enum17.GiaoNguHanhPhapThiep };
		ToolStripMenuItem toolStripMenuItem83 = this.muTangCapTruongThanhLongVan;
		dictionary[toolStripMenuItem83] = new Enum17[] { Enum17.TangCapTruongThanhLongVan };
		ToolStripMenuItem toolStripMenuItem84 = this.muCheThanKhi;
		dictionary[toolStripMenuItem84] = new Enum17[] { Enum17.CheThanKhi };
		ToolStripMenuItem toolStripMenuItem85 = this.muMua100KimSangDuoc;
		dictionary[toolStripMenuItem85] = new Enum17[] { Enum17.Mua100KimSangDuoc };
		ToolStripMenuItem toolStripMenuItem86 = this.muSuaVoHon;
		dictionary[toolStripMenuItem86] = new Enum17[] { Enum17.SuaVoHon };
		ToolStripMenuItem toolStripMenuItem87 = this.muSuaThanKhi;
		dictionary[toolStripMenuItem87] = new Enum17[] { Enum17.SuaThanKhi };
		ToolStripMenuItem toolStripMenuItem88 = this.muSuaTrangBi;
		dictionary[toolStripMenuItem88] = new Enum17[] { Enum17.SuaTrangBi };
		ToolStripMenuItem toolStripMenuItem89 = this.muDoiChanNguyenLinhPhach;
		dictionary[toolStripMenuItem89] = new Enum17[] { Enum17.DoiChanNguyenLinhPhach };
		ToolStripMenuItem toolStripMenuItem90 = this.muNhanChienCongKiemChi;
		dictionary[toolStripMenuItem90] = new Enum17[]
		{
			Enum17.NhanChienCong,
			Enum17.NhanKiemChi
		};
		ToolStripMenuItem toolStripMenuItem91 = this.muNhanThuongQuanSonHai;
		dictionary[toolStripMenuItem91] = new Enum17[] { Enum17.NhanThuongQuanSonHai };
		ToolStripMenuItem toolStripMenuItem92 = this.muNhanBuaBaoRuong;
		dictionary[toolStripMenuItem92] = new Enum17[] { Enum17.NhanBuaBaoRuong };
		ToolStripMenuItem toolStripMenuItem93 = this.muNhanLeBao;
		dictionary[toolStripMenuItem93] = new Enum17[] { Enum17.NhanLeBao };
		ToolStripMenuItem toolStripMenuItem94 = this.muKyCuocCham;
		dictionary[toolStripMenuItem94] = new Enum17[] { Enum17.DatDoiKyCuoc };
		ToolStripMenuItem toolStripMenuItem95 = this.muKyCuocNhanh;
		dictionary[toolStripMenuItem95] = new Enum17[]
		{
			Enum17.DatDoiKyCuoc,
			Enum17.KyCuocNhanh
		};
		ToolStripMenuItem toolStripMenuItem96 = this.muLauLanTamBaoCham;
		dictionary[toolStripMenuItem96] = new Enum17[] { Enum17.DatDoiLauLanTamBao };
		ToolStripMenuItem toolStripMenuItem97 = this.muLauLanTamBaoNhanh;
		dictionary[toolStripMenuItem97] = new Enum17[]
		{
			Enum17.DatDoiLauLanTamBao,
			Enum17.LauLanTamBaoNhanh
		};
		ToolStripMenuItem toolStripMenuItem98 = this.muDaTru;
		dictionary[toolStripMenuItem98] = new Enum17[] { Enum17.DatDoiDaTru };
		ToolStripMenuItem toolStripMenuItem99 = this.muMongHeo;
		dictionary[toolStripMenuItem99] = new Enum17[] { Enum17.DatDoiMongHeo };
		ToolStripMenuItem toolStripMenuItem100 = this.muThienGiangKyThu;
		dictionary[toolStripMenuItem100] = new Enum17[] { Enum17.DatDoiThienGiangKyThu };
		ToolStripMenuItem toolStripMenuItem101 = this.muPhungHoangLangMo;
		dictionary[toolStripMenuItem101] = new Enum17[] { Enum17.DatDoiPhungHoangLangMo };
		ToolStripMenuItem toolStripMenuItem102 = this.muBaoDoHiem;
		dictionary[toolStripMenuItem102] = new Enum17[] { Enum17.DatDoiBaoDoHiem };
		ToolStripMenuItem toolStripMenuItem103 = this.muDoanBaoMaTac;
		dictionary[toolStripMenuItem103] = new Enum17[] { Enum17.DatDoiMaTac };
		ToolStripMenuItem toolStripMenuItem104 = this.muQuanSonHai;
		dictionary[toolStripMenuItem104] = new Enum17[] { Enum17.DatDoiQuanSonHai };
		ToolStripMenuItem toolStripMenuItem105 = this.muNhanPhiThuy;
		dictionary[toolStripMenuItem105] = new Enum17[] { Enum17.NhanPhucNguyenLeHap };
		ToolStripMenuItem toolStripMenuItem106 = this.muVanMay;
		dictionary[toolStripMenuItem106] = new Enum17[] { Enum17.ThuTaiVanMay };
		ToolStripMenuItem toolStripMenuItem107 = this.muNguyenVong;
		dictionary[toolStripMenuItem107] = new Enum17[] { Enum17.NguyenVongThienLinh };
		ToolStripMenuItem toolStripMenuItem108 = this.muToanBoHangNgay;
		dictionary[toolStripMenuItem108] = new Enum17[]
		{
			Enum17.ThuTaiVanMay,
			Enum17.BaoVeBang,
			Enum17.NguyenVongThienLinh,
			Enum17.RotRuou
		};
		ToolStripMenuItem toolStripMenuItem109 = this.muSuMon;
		dictionary[toolStripMenuItem109] = new Enum17[] { Enum17.NhiemVuSuMon };
		ToolStripMenuItem toolStripMenuItem110 = this.muMoBaoTangDo;
		dictionary[toolStripMenuItem110] = new Enum17[] { Enum17.MoBaoTangDo };
		ToolStripMenuItem toolStripMenuItem111 = this.muTrungAc;
		dictionary[toolStripMenuItem111] = new Enum17[] { Enum17.TrungAc };
		ToolStripMenuItem toolStripMenuItem112 = this.muCotTruyenKnbKhoa;
		dictionary[toolStripMenuItem112] = new Enum17[]
		{
			Enum17.ThongBao,
			Enum17.NhiemVuKNBKhoa
		};
		ToolStripMenuItem toolStripMenuItem113 = this.muCotTruyenThangCap;
		dictionary[toolStripMenuItem113] = new Enum17[] { Enum17.NhiemVuThangCap };
		ToolStripMenuItem toolStripMenuItem114 = this.muCotTruyenChinhTuyen;
		dictionary[toolStripMenuItem114] = new Enum17[] { Enum17.NhiemVuChinhTuyen };
		ToolStripMenuItem toolStripMenuItem115 = this.muCotTruyenExp;
		dictionary[toolStripMenuItem115] = new Enum17[] { Enum17.NhiemVuExp };
		ToolStripMenuItem toolStripMenuItem116 = this.muCotTruyenVoY;
		dictionary[toolStripMenuItem116] = new Enum17[] { Enum17.NhiemVuVoY };
		ToolStripMenuItem toolStripMenuItem117 = this.muCotTruyenVoTuPho;
		dictionary[toolStripMenuItem117] = new Enum17[] { Enum17.VoTuPho };
		ToolStripMenuItem toolStripMenuItem118 = this.muNgoChanNguyen;
		dictionary[toolStripMenuItem118] = new Enum17[] { Enum17.NgoChanNguyen };
		ToolStripMenuItem toolStripMenuItem119 = this.muTuDuong;
		dictionary[toolStripMenuItem119] = new Enum17[] { Enum17.TuDuongCon };
		ToolStripMenuItem toolStripMenuItem120 = this.muNhanCon;
		dictionary[toolStripMenuItem120] = new Enum17[] { Enum17.NhanCon };
		ToolStripMenuItem toolStripMenuItem121 = this.muPhuMau;
		dictionary[toolStripMenuItem121] = new Enum17[] { Enum17.LongPhuMau };
		ToolStripMenuItem toolStripMenuItem122 = this.muThienKiepLau;
		dictionary[toolStripMenuItem122] = new Enum17[] { Enum17.TruAc };
		ToolStripMenuItem toolStripMenuItem123 = this.muSinhTieu;
		dictionary[toolStripMenuItem123] = new Enum17[] { Enum17.SinhTieu };
		ToolStripMenuItem toolStripMenuItem124 = this.muThanKhi9Sao;
		dictionary[toolStripMenuItem124] = new Enum17[] { Enum17.ThanKhi9Sao };
		ToolStripMenuItem toolStripMenuItem125 = this.muDungDoatBaoRuong;
		dictionary[toolStripMenuItem125] = new Enum17[] { Enum17.DungDoatBaoRuong };
		ToolStripMenuItem toolStripMenuItem126 = this.muBaGiaLinhThao;
		dictionary[toolStripMenuItem126] = new Enum17[]
		{
			Enum17.NhanThuongBaGiaThienHa,
			Enum17.NhanThuongLinhThao
		};
		ToolStripMenuItem toolStripMenuItem127 = this.muTamAnhCuuLeThuong;
		dictionary[toolStripMenuItem127] = new Enum17[] { Enum17.TamAnhCuuLe };
		ToolStripMenuItem toolStripMenuItem128 = this.muTamAnhCuuLeKho;
		dictionary[toolStripMenuItem128] = new Enum17[] { Enum17.TamAnhCuuLeKho };
		ToolStripMenuItem toolStripMenuItem129 = this.muBaGiaCan;
		dictionary[toolStripMenuItem129] = new Enum17[] { Enum17.DiBaGiaThienHaCan };
		ToolStripMenuItem toolStripMenuItem130 = this.muBaGiaKhon;
		dictionary[toolStripMenuItem130] = new Enum17[] { Enum17.DiBaGiaThienHaKhon };
		ToolStripMenuItem toolStripMenuItem131 = this.muPhonghoa;
		dictionary[toolStripMenuItem131] = new Enum17[] { Enum17.Chientruongphonghoa };
		ToolStripMenuItem toolStripMenuItem132 = this.menuTangSaoLenhBai;
		dictionary[toolStripMenuItem132] = new Enum17[] { Enum17.TangSaoLenhBai };
		ToolStripMenuItem toolStripMenuItem133 = this.muGiaiPhongChanNguyen;
		dictionary[toolStripMenuItem133] = new Enum17[] { Enum17.GiaiPhongChanNguyen };
		ToolStripMenuItem toolStripMenuItem134 = this.toolStripMenuItem_33;
		dictionary[toolStripMenuItem134] = new Enum17[] { Enum17.SuaDoTinhKiem2 };
		ToolStripMenuItem toolStripMenuItem135 = this.menuDoiHuyenSac;
		dictionary[toolStripMenuItem135] = new Enum17[] { Enum17.DoiHuyenSacCauThienThai };
		ToolStripMenuItem toolStripMenuItem136 = this.menuDoiLoanPhi;
		dictionary[toolStripMenuItem136] = new Enum17[] { Enum17.DoiLoanPhiMatHam };
		ToolStripMenuItem toolStripMenuItem137 = this.menuDoiDiaLinhChau;
		dictionary[toolStripMenuItem137] = new Enum17[] { Enum17.DoiDiaLinhChau };
		ToolStripMenuItem toolStripMenuItem138 = this.evBinhThanhKyTran;
		dictionary[toolStripMenuItem138] = new Enum17[] { Enum17.DatDoiBinhThanh };
		ToolStripMenuItem toolStripMenuItem139 = this.evPhieuMieuPhong;
		dictionary[toolStripMenuItem139] = new Enum17[] { Enum17.DatDoiKhieuChienPhieuMieuPhong };
		ToolStripMenuItem toolStripMenuItem140 = this.evPhucDia;
		dictionary[toolStripMenuItem140] = new Enum17[] { Enum17.DatDoiPhucDia };
		ToolStripMenuItem toolStripMenuItem141 = this.evVuongLang;
		dictionary[toolStripMenuItem141] = new Enum17[] { Enum17.DatDoiVuongLang };
		ToolStripMenuItem toolStripMenuItem142 = this.evTamThan;
		dictionary[toolStripMenuItem142] = new Enum17[] { Enum17.DatDoiTamThan };
		ToolStripMenuItem toolStripMenuItem143 = this.evPhucDiaKho;
		dictionary[toolStripMenuItem143] = new Enum17[] { Enum17.DatDoiPhucDiaKho };
		ToolStripMenuItem toolStripMenuItem144 = this.evThieuThatSon;
		dictionary[toolStripMenuItem144] = new Enum17[] { Enum17.DatDoiThieuThatSon };
		ToolStripMenuItem toolStripMenuItem145 = this.evYenTuO;
		dictionary[toolStripMenuItem145] = new Enum17[] { Enum17.DatDoiYenTuO };
		ToolStripMenuItem toolStripMenuItem146 = this.evTuTuyetTrang;
		dictionary[toolStripMenuItem146] = new Enum17[] { Enum17.DatDoiTuTuyetTrang };
		ToolStripMenuItem toolStripMenuItem147 = this.evTruPhiPhaTamQuan;
		dictionary[toolStripMenuItem147] = new Enum17[] { Enum17.DatDoiTruPhiPhaTamQuan };
		ToolStripMenuItem toolStripMenuItem148 = this.muCQKhieuChienPMP;
		dictionary[toolStripMenuItem148] = new Enum17[] { Enum17.CanQuetPhieuMieuPhong };
		ToolStripMenuItem toolStripMenuItem149 = this.muCQPhucDia;
		dictionary[toolStripMenuItem149] = new Enum17[] { Enum17.CanQuetPhucDia };
		ToolStripMenuItem toolStripMenuItem150 = this.muCQPhucDiaKho;
		dictionary[toolStripMenuItem150] = new Enum17[] { Enum17.CanQuetPhucDiaKho };
		ToolStripMenuItem toolStripMenuItem151 = this.muCQVuongLang;
		dictionary[toolStripMenuItem151] = new Enum17[] { Enum17.CanQuetVuongLang };
		ToolStripMenuItem toolStripMenuItem152 = this.muCQTamThan;
		dictionary[toolStripMenuItem152] = new Enum17[] { Enum17.CanQuetTamThan };
		ToolStripMenuItem toolStripMenuItem153 = this.muCQThieuThatSon;
		dictionary[toolStripMenuItem153] = new Enum17[] { Enum17.CanQuetThieuThatSon };
		ToolStripMenuItem toolStripMenuItem154 = this.muCQYenTuO;
		dictionary[toolStripMenuItem154] = new Enum17[] { Enum17.CanQuetYenTuO };
		ToolStripMenuItem toolStripMenuItem155 = this.muCQTuTuyetTrang;
		dictionary[toolStripMenuItem155] = new Enum17[] { Enum17.CanQuetTuTuyetTrang };
		ToolStripMenuItem toolStripMenuItem156 = this.muCQTruPhiPhaTamQuan;
		dictionary[toolStripMenuItem156] = new Enum17[] { Enum17.CanQuetTruPhiPhaTamQuan };
		ToolStripMenuItem toolStripMenuItem157 = this.menuCQQ1ToChau;
		dictionary[toolStripMenuItem157] = new Enum17[] { Enum17.CqDietGon };
		ToolStripMenuItem toolStripMenuItem158 = this.menuCQQ2ToChau;
		dictionary[toolStripMenuItem158] = new Enum17[] { Enum17.CqTruHai };
		ToolStripMenuItem toolStripMenuItem159 = this.menuCQQ3ToChau;
		dictionary[toolStripMenuItem159] = new Enum17[] { Enum17.CqDietPhiTac };
		ToolStripMenuItem toolStripMenuItem160 = this.menuCQYenTuO;
		dictionary[toolStripMenuItem160] = new Enum17[] { Enum17.CqYTO };
		ToolStripMenuItem toolStripMenuItem161 = this.menuCQSatTinh;
		dictionary[toolStripMenuItem161] = new Enum17[] { Enum17.CqSatTinh };
		ToolStripMenuItem toolStripMenuItem162 = this.menuCQQ1LauLan;
		dictionary[toolStripMenuItem162] = new Enum17[] { Enum17.CqHoangKimChiLien };
		ToolStripMenuItem toolStripMenuItem163 = this.menuCQQ2LauLan;
		dictionary[toolStripMenuItem163] = new Enum17[] { Enum17.CqHuyenPhatChau };
		ToolStripMenuItem toolStripMenuItem164 = this.menuCQQ3LauLan;
		dictionary[toolStripMenuItem164] = new Enum17[] { Enum17.CqDungNhamChiDia };
		ToolStripMenuItem toolStripMenuItem165 = this.menuCQSCPMP;
		dictionary[toolStripMenuItem165] = new Enum17[] { Enum17.CqSCPMP };
		ToolStripMenuItem toolStripMenuItem166 = this.menuCQKCPMP;
		dictionary[toolStripMenuItem166] = new Enum17[] { Enum17.CqKCPMP };
		ToolStripMenuItem toolStripMenuItem167 = this.menuCQThuyNguyetSonTrang;
		dictionary[toolStripMenuItem167] = new Enum17[] { Enum17.CqThuyNguyetSonTrang };
		ToolStripMenuItem toolStripMenuItem168 = this.canVQ1ToChau;
		dictionary[toolStripMenuItem168] = new Enum17[] { Enum17.CqVDietGon };
		ToolStripMenuItem toolStripMenuItem169 = this.canVQ2ToChau;
		dictionary[toolStripMenuItem169] = new Enum17[] { Enum17.CqVTruHai };
		ToolStripMenuItem toolStripMenuItem170 = this.canVQ3ToChau;
		dictionary[toolStripMenuItem170] = new Enum17[] { Enum17.CqVDietPhiTac };
		ToolStripMenuItem toolStripMenuItem171 = this.canVSatTInh;
		dictionary[toolStripMenuItem171] = new Enum17[] { Enum17.CqVSatTinh };
		ToolStripMenuItem toolStripMenuItem172 = this.canVQ1LauLan;
		dictionary[toolStripMenuItem172] = new Enum17[] { Enum17.CqVHoangKimChiLien };
		ToolStripMenuItem toolStripMenuItem173 = this.canVQ2LauLan;
		dictionary[toolStripMenuItem173] = new Enum17[] { Enum17.CqVHuyenPhatChau };
		ToolStripMenuItem toolStripMenuItem174 = this.canVQ3LauLan;
		dictionary[toolStripMenuItem174] = new Enum17[] { Enum17.CqVDungNhamChiDia };
		ToolStripMenuItem toolStripMenuItem175 = this.muCQAll;
		dictionary[toolStripMenuItem175] = new Enum17[]
		{
			Enum17.CanQuetPhieuMieuPhong,
			Enum17.CanQuetPhucDia,
			Enum17.CanQuetPhucDiaKho,
			Enum17.CanQuetVuongLang,
			Enum17.CanQuetTamThan,
			Enum17.CanQuetThieuThatSon,
			Enum17.CanQuetYenTuO,
			Enum17.CanQuetTuTuyetTrang,
			Enum17.CanQuetTruPhiPhaTamQuan
		};
		ToolStripMenuItem toolStripMenuItem176 = this.menuChayThuongNhan;
		dictionary[toolStripMenuItem176] = new Enum17[] { Enum17.ChayThuongNhan };
		ToolStripMenuItem toolStripMenuItem177 = this.menuChoiCungNienThu;
		dictionary[toolStripMenuItem177] = new Enum17[] { Enum17.ChoiCungNienTHu };
		ToolStripMenuItem toolStripMenuItem178 = this.menuAnTiec;
		dictionary[toolStripMenuItem178] = new Enum17[] { Enum17.AnTiec };
		ToolStripMenuItem toolStripMenuItem179 = this.menuDoiBoiDiep;
		dictionary[toolStripMenuItem179] = new Enum17[] { Enum17.DoiBoiDiep };
		ToolStripMenuItem toolStripMenuItem180 = this.menuMoHoaNgocTap;
		dictionary[toolStripMenuItem180] = new Enum17[] { Enum17.MoHoaNgocTap };
		ToolStripMenuItem toolStripMenuItem181 = this.menuLen8Sao;
		dictionary[toolStripMenuItem181] = new Enum17[] { Enum17.Len8Sao };
		ToolStripMenuItem toolStripMenuItem182 = this.menuNhanBachHoaHuongNang;
		dictionary[toolStripMenuItem182] = new Enum17[] { Enum17.NhanBachHoaHuongNang };
		ToolStripMenuItem toolStripMenuItem183 = this.menuSatTinh;
		dictionary[toolStripMenuItem183] = new Enum17[] { Enum17.DatDoiSatTinh };
		ToolStripMenuItem toolStripMenuItem184 = this.toolStripMenuItem_63;
		dictionary[toolStripMenuItem184] = new Enum17[] { Enum17.CuongHoaVuKhi9 };
		ToolStripMenuItem toolStripMenuItem185 = this.toolStripMenuItem_65;
		dictionary[toolStripMenuItem185] = new Enum17[] { Enum17.CuongHoaHHA9 };
		ToolStripMenuItem toolStripMenuItem186 = this.toolStripMenuItem_66;
		dictionary[toolStripMenuItem186] = new Enum17[] { Enum17.CuongHoaAK9 };
		ToolStripMenuItem toolStripMenuItem187 = this.toolStripMenuItem_68;
		dictionary[toolStripMenuItem187] = new Enum17[] { Enum17.CuongHoaVK99 };
		ToolStripMenuItem toolStripMenuItem188 = this.toolStripMenuItem_69;
		dictionary[toolStripMenuItem188] = new Enum17[] { Enum17.NgayXuanTaoNha };
		ToolStripMenuItem toolStripMenuItem189 = this.toolStripMenuItem_70;
		dictionary[toolStripMenuItem189] = new Enum17[] { Enum17.Nhan5GioHoa };
		ToolStripMenuItem toolStripMenuItem190 = this.muVoDao;
		dictionary[toolStripMenuItem190] = new Enum17[] { Enum17.VoDao };
		ToolStripMenuItem toolStripMenuItem191 = this.muVoDao1;
		dictionary[toolStripMenuItem191] = new Enum17[] { Enum17.VoDao2 };
		ToolStripMenuItem toolStripMenuItem192 = this.menuThanhKhuu;
		dictionary[toolStripMenuItem192] = new Enum17[] { Enum17.DatDoiThanhKhuu };
		ToolStripMenuItem toolStripMenuItem193 = this.menuTNST;
		dictionary[toolStripMenuItem193] = new Enum17[] { Enum17.DatDoiTNST };
		ToolStripMenuItem toolStripMenuItem194 = this.toolStripMenuItem_77;
		dictionary[toolStripMenuItem194] = new Enum17[] { Enum17.TraDao };
		ToolStripMenuItem toolStripMenuItem195 = this.toolStripMenuItem_78;
		dictionary[toolStripMenuItem195] = new Enum17[] { Enum17.CotTruyen120 };
		this.Dictionary_0 = dictionary;
		this.Dictionary_0.smethod_22<KeyValuePair<ToolStripMenuItem, Enum17[]>>(new Action<KeyValuePair<ToolStripMenuItem, Enum17[]>>(this.method_80));
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
	private void method_2(int int_6)
	{
		GUI.Class488 @class = new GUI.Class488();
		@class.int_0 = int_6;
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_1));
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000EE400 File Offset: 0x000EC600
	public void method_3()
	{
		new GClass2(Keys.P, GEnum0.Alt, this, new Action(GUI.Class403.f_A642BF9F.method_2));
		new GClass2(Keys.Left, GEnum0.Control, this, new Action(this.method_82));
		new GClass2(Keys.Right, GEnum0.Control, this, new Action(this.method_83));
		new GClass2(Keys.Down, GEnum0.Control, this, new Action(this.method_84));
		new GClass2(Keys.W, GEnum0.Alt, this, new Action(GUI.Class403.f_A642BF9F.method_4));
		new GClass2(Keys.U, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_6));
		new GClass2(Keys.D, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_8));
		new GClass2(Keys.F, GEnum0.Control | GEnum0.Shift, this, new Action(GUI.Class403.f_A642BF9F.method_10));
		new GClass2(Keys.O, GEnum0.Control | GEnum0.Shift, this, new Action(GUI.Class403.f_A642BF9F.method_11));
		new GClass2(Keys.Q, GEnum0.Control | GEnum0.Shift, this, new Action(this.method_85));
		new GClass2(Keys.E, GEnum0.Control | GEnum0.Shift, this, new Action(this.method_87));
		new GClass2(Keys.P, GEnum0.Control, this, new Action(this.method_89));
		new GClass2(Keys.O, GEnum0.Control, this, new Action(this.method_90));
		new GClass2(Keys.Z, GEnum0.Alt, this, new Action(GUI.Class403.f_A642BF9F.method_12));
		new GClass2(Keys.Next, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_14));
		new GClass2(Keys.B, GEnum0.Control, this, new Action(this.method_91));
		new GClass2(Keys.Q, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_16));
		new GClass2(Keys.Y, GEnum0.Alt, this, new Action(GUI.Class403.f_A642BF9F.method_18));
		new GClass2(Keys.F1, GEnum0.Control, this, new Action(this.method_92));
		new GClass2(Keys.End, GEnum0.Control, this, new Action(this.method_93));
		new GClass2(Keys.F1, GEnum0.Alt, this, new Action(this.method_94));
		new GClass2(Keys.F2, GEnum0.Alt, this, new Action(this.method_95));
		new GClass2(Keys.F3, GEnum0.Alt, this, new Action(this.method_96));
		new GClass2(Keys.K, GEnum0.Control, this, new Action(this.method_97));
		new GClass2(Keys.W, GEnum0.Control, this, new Action(this.method_98));
		new GClass2(Keys.I, GEnum0.Alt, this, new Action(this.method_99));
		new GClass2(Keys.K, GEnum0.Alt, this, new Action(this.method_100));
		new GClass2(Keys.Pause, GEnum0.None, this, new Action(this.method_101));
		new GClass2(Keys.G, GEnum0.Alt, this, new Action(GUI.Class403.f_A642BF9F.method_20));
		new GClass2(Keys.OemOpenBrackets, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_22));
		new GClass2(Keys.OemCloseBrackets, GEnum0.Control, this, new Action(GUI.Class403.f_A642BF9F.method_25));
		new GClass2(Keys.Insert, GEnum0.None, this, new Action(this.method_102));
		new GClass2(Keys.F2, GEnum0.Control, this, new Action(this.method_103));
		new GClass2(Keys.OemQuestion, GEnum0.Control, this, new Action(this.method_104));
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x060020B9 RID: 8377 RVA: 0x00015E2B File Offset: 0x0001402B
	// (set) Token: 0x060020BA RID: 8378 RVA: 0x00015E32 File Offset: 0x00014032
	public static GUI GUI_0 { get; set; }

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x060020BB RID: 8379 RVA: 0x00015E3A File Offset: 0x0001403A
	// (set) Token: 0x060020BC RID: 8380 RVA: 0x00015E41 File Offset: 0x00014041
	public static string String_1 { get; set; } = "iAuto.Login";

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x060020BD RID: 8381 RVA: 0x000EE7FC File Offset: 0x000EC9FC
	public int Int32_0
	{
		get
		{
			long num = GClass36.smethod_0();
			long num2 = GClass36.smethod_1();
			if (num <= 0 || num2 <= 0)
			{
				return 0;
			}
			return (int)((decimal)num / num2 * 100m);
		}
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x060020BE RID: 8382 RVA: 0x00015E49 File Offset: 0x00014049
	// (set) Token: 0x060020BF RID: 8383 RVA: 0x00015E51 File Offset: 0x00014051
	public string String_2 { get; set; } = "";

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00015E5A File Offset: 0x0001405A
	// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00015E62 File Offset: 0x00014062
	public string String_3 { get; set; } = "";

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00015E6B File Offset: 0x0001406B
	// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00015E73 File Offset: 0x00014073
	private int Int32_1 { get; set; }

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00015E7C File Offset: 0x0001407C
	private Class106 Class106_0
	{
		get
		{
			return Class106.IEnumerable_0.FirstOrDefault<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_28));
		}
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000EE838 File Offset: 0x000ECA38
	public static void smethod_3(List<Class106> list_1)
	{
		GUI.Class490 @class = new GUI.Class490();
		@class.list_0 = list_1;
		if (@class.list_0.Count > 0)
		{
			if (!@class.list_0[0].Class527_0.Boolean_21)
			{
				@class.list_0[0].method_375("Player:LeaveTeam();", false);
				Thread.Sleep(500);
				@class.list_0[0].method_375("Player:CreateTeamSelf();", false);
				Thread.Sleep(500);
			}
			@class.list_0.Skip<Class106>(1).ToList<Class106>().ForEach(new Action<Class106>(@class.method_0));
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000EE8DC File Offset: 0x000ECADC
	public static string smethod_4(string string_6, string string_7 = null, string string_8 = null)
	{
		string text2;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_6);
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.Method = "POST";
			httpWebRequest.UserAgent = string_8;
			httpWebRequest.Headers.Add("Accept-Encoding: *");
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Connection = "keepalive";
			httpWebRequest.Referer = "http://www.facebook.com/";
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebRequest.Proxy = null;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			if (string_7 != null)
			{
				StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
				streamWriter.Write(string_7);
				streamWriter.Close();
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			httpWebResponse.Close();
			text2 = text;
		}
		catch (Exception ex)
		{
			text2 = ex.Message;
		}
		return text2;
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000EE9C4 File Offset: 0x000ECBC4
	public static void smethod_5(string string_6)
	{
		GUI.Class492 @class = new GUI.Class492();
		@class.string_0 = string_6;
		GUI.GUI_0.Invoke(new Action(@class.method_0));
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000EE9F8 File Offset: 0x000ECBF8
	public double method_4(double double_1)
	{
		double_1 -= 1000.0;
		if (double_1 < 0.0)
		{
			double_1 = 0.0;
		}
		double num = 2000.0;
		double num2 = 20000.0;
		double num3 = 100000000.0;
		double num5;
		if (double_1 <= num3)
		{
			double num4 = num2 - (num2 - num) * Math.Log(double_1 + 1.0, num3 + 1.0);
			num5 = double_1 / num4;
		}
		else
		{
			num5 = double_1 / num;
		}
		return num5;
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000EEA84 File Offset: 0x000ECC84
	public static string smethod_6(float float_0)
	{
		TimeSpan timeSpan = TimeSpan.FromDays((double)float_0);
		return string.Format("{0:%d}:{0:hh}:{0:mm}:{0:ss}", timeSpan);
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000EEAAC File Offset: 0x000ECCAC
	public static string smethod_7(string string_6)
	{
		string text;
		try
		{
			TimeSpan timeSpan = TimeSpan.FromDays((double)float.Parse(string_6, CultureInfo.InvariantCulture));
			text = string.Format("{0:%d}:{0:hh}:{0:mm}:{0:ss}", timeSpan);
		}
		catch
		{
			text = "0:00:00:00";
		}
		return text;
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x060020CB RID: 8395 RVA: 0x00015EA7 File Offset: 0x000140A7
	// (set) Token: 0x060020CC RID: 8396 RVA: 0x00015EAE File Offset: 0x000140AE
	public static int Int32_2 { get; set; }

	// Token: 0x060020CD RID: 8397 RVA: 0x00015EB6 File Offset: 0x000140B6
	public void method_5()
	{
		Task.Run(new Action(this.method_105));
	}

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x060020CE RID: 8398 RVA: 0x00015ECA File Offset: 0x000140CA
	// (set) Token: 0x060020CF RID: 8399 RVA: 0x00015ED1 File Offset: 0x000140D1
	public static bool Boolean_0 { get; set; }

	// Token: 0x060020D0 RID: 8400 RVA: 0x000EEAF8 File Offset: 0x000ECCF8
	private void method_6()
	{
		this.lblIncome.Text = "10% annual interest, paid per minute";
		this.cboPoint.Items.Clear();
		this.cboPoint.Items.Add("Sta. - Stamina");
		this.cboPoint.Items.Add("Agi. - Agility");
		this.cboPoint.Items.Add("Wil. - Willpower");
		this.cboPoint.Items.Add("Str. - Strength");
		this.cboPoint.Items.Add("Int. - Intelligence");
		this.cboTrongTrot.Items.Clear();
		this.cboTrongTrot.Items.AddRange(new object[]
		{
			"Wheat - Early", "Rice - Early", "Corn - Early", "Peanut - Early", "Sweet Potato - Early", "Proso Millet - Early", "Sesame - Early", "Mung Bean - Early", "Soybean - Early", "Broad Bean - Early",
			"Potato - Early", "Taro - Early", "Flax - Early", "Cotton - Early", "Flax - Early", "Silk - Early", "Woven Silk - Early", "Fibre - Early", "Satin - Early", "Damask - Early",
			"Kender - Early", "Woolen - Early", "Muslin - Early", "Brocade - Early", "Wheat - Late", "Rice - Late", "Corn - Late", "Peanut - Late", "Sweet Potato - Late", "Proso Millet - Late",
			"Sesame - Late", "Mung Bean - Late", "Soybean - Late", "Broad Bean - Late", "Potato - Late", "Potato - Late", "Flax - Late", "Cotton - Late", "Flax - Late", "Silk - Late",
			"Woven Silk - Late", "Fibre - Late", "Satin - Late", "Damask - Late", "Kender - Late", "Woolen - Late", "Muslin - Late", "Brocade - Late"
		});
		for (int i = 0; i < this.cboMenpai.Items.Count; i++)
		{
			foreach (KeyValuePair<string, string> keyValuePair in Class501.Dictionary_1)
			{
				if (this.cboMenpai.Items[i].ToString().Contains(keyValuePair.Value))
				{
					this.cboMenpai.Items[i] = this.cboMenpai.Items[i].ToString().Replace(keyValuePair.Value, keyValuePair.Key);
					break;
				}
			}
		}
		foreach (object obj in this.menuSkillStudy.DropDownItems)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
			toolStripMenuItem.Text = toolStripMenuItem.Text.Replace("Lên", "Up To");
			toolStripMenuItem.Text = toolStripMenuItem.Text.Replace("Máu", "HP");
		}
		this.muVanMay.Text = "OnAugury";
		this.muNhanLaiKinhNghiem.Text = "Exp";
		this.muDiMuaNgua.Text = "Buy Mount";
		this.columnHeader_6.Text = "Menpai";
		this.columnHeader_14.Text = "Position";
		this.columnHeader_15.Text = "Team";
		this.columnHeader_17.Text = "Gold";
		this.muMoShop.Text = "Go to Shop";
		this.menuSkillStudy.Text = "Skill Study";
		this.menuHocCheDo.Text = "Learn Synthesize";
		this.menuLayDoKhongCoDinh.Text = "Take Unbound Items";
		this.muThienKiepLau.Text = "Mansion of Crime";
		this.muThanKhi9Sao.Text = "Artifact 9*";
		this.menuQuanDoan.Text = "Raid";
		this.menuHoaBinh.Text = "Peace";
		this.menuThienAc.Text = "Moral";
		this.menuNhom.Text = "Team";
		this.menuBang.Text = "Guild";
		this.muSuaThanKhi.Text = "Artifact";
		this.muSuaTrangBi.Text = "Equipment";
		this.muSuaVoHon.Text = "Soul";
		this.muTrungLau.Text = "God Equipment";
		this.muToiLuyenBang.Text = "Cold";
		this.muToiLuyenDoc.Text = "Poison";
		this.muToiLuyenHoa.Text = "Fire";
		this.muToiLuyenHuyen.Text = "Light";
		this.menuCold.Text = "Cold";
		this.menuFire.Text = "Fire";
		this.menuLight.Text = "Light";
		this.menuPoison.Text = "Poison";
		this.menuRed.Text = "Red";
		this.menuGreen.Text = "Green";
		this.menuYellow.Text = "Yellow";
		this.menuBlue.Text = "Blue";
		this.menuNangBaoChau.Text = "Rune Stone Level Up";
		this.menuTangSaoLenhBai.Text = "Star Level Up";
		this.menuOpenBank.Text = "Open Bank [Ctrl + B]";
		this.muCatDo.Text = "Store Items";
		this.muLayDo.Text = "Take Items";
		this.muLayDoLayVang.Text = "Take Gold";
		this.menuLenhBai.Text = "LingPai";
		this.menuLayDo.Text = "Retack Item";
		this.menuXuongGia.Text = "Down Sale";
		this.menuLenGia.Text = "Up Stall";
		this.menuDauThai.Text = "Revive [Alt + P]";
		foreach (object obj2 in this.lvFunction.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj2;
			if (listViewItem.Tag == "x2x3")
			{
				listViewItem.Text = "Use x2 WuYi";
			}
			if (listViewItem.Tag == "muangoc")
			{
				listViewItem.Text = "Buy Gem";
			}
			if (listViewItem.Tag == "khongbatlich")
			{
				listViewItem.Text = "Schedule Disabled";
			}
			if (listViewItem.Tag == "baoinbox")
			{
				listViewItem.Text = "Notify inbox";
			}
			if (listViewItem.Tag == "khaikhoang")
			{
				listViewItem.Text = "Mining";
			}
			if (listViewItem.Tag == "haiduoc")
			{
				listViewItem.Text = "Herbing";
			}
			if (listViewItem.Tag == "comeback")
			{
				listViewItem.Text = "Comeback";
			}
			if (listViewItem.Tag == "fight")
			{
				listViewItem.Text = "Fight";
			}
			if (listViewItem.Tag == "attacklist")
			{
				listViewItem.Text = "Attack List";
			}
			if (listViewItem.Tag == "picklist")
			{
				listViewItem.Text = "Pick List";
			}
			if (listViewItem.Tag == "lvlup")
			{
				listViewItem.Text = "Level Up";
			}
			if (listViewItem.Tag == "giacong")
			{
				listViewItem.Text = "Compose";
			}
			if (listViewItem.Tag == "quayvong")
			{
				listViewItem.Text = "Turn Plate";
			}
			if (listViewItem.Tag == "cankhonho")
			{
				listViewItem.Text = "Heaven Pot";
			}
			if (listViewItem.Tag == "pick")
			{
				listViewItem.Text = "Pick Item";
			}
			if (listViewItem.Tag == "thuthap")
			{
				listViewItem.Text = "Collect Materials";
			}
			if (listViewItem.Tag == "x2")
			{
				listViewItem.Text = "Use x2";
			}
			if (listViewItem.Tag == "x4")
			{
				listViewItem.Text = "Use x4";
			}
			if (listViewItem.Tag == "tulinhngoc")
			{
				listViewItem.Text = "Use Ju Ling";
			}
		}
		this.muCheThanKhi.Text = "Synthesize Ultimate Artifact";
		this.muCuongHoaDo.Text = "Enchase Equipment";
		this.menuThaoTrangBi.Text = "Unequip Equipment";
		this.menuDeoTrangBi.Text = "Equip Equipment";
		this.menuThaoDeo.Text = "Unequip + Equip";
		this.menuGiamDinh.Text = "Identify [Ctrl + /]";
		this.menuDucLo.Text = "Add Socket";
		this.socket1.Text = "1 Socket";
		this.socket2.Text = "2 Socket";
		this.socket3.Text = "3 Socket";
		this.checkAutoPhu.Text = "Auto Spell";
		this.btnKham.Text = "Enchase";
		this.btnTrac.Text = "Polish";
		this.btnHop.Text = "Combine";
		this.btnDuc.Text = "Socket";
		this.menuThaoTac.Text = "Actions";
		this.muTuyetGiao.Text = "Remove Friend";
		this.muHaoHuu.Text = "Add Friend";
		this.muXuatPet.Text = "Summon Pet";
		this.muThuPet.Text = "Rest Pet";
		this.muQuayVeDaiLy.Text = "Town Portal";
		this.muAnDon.Text = "Stealth";
		this.muAcTac.Text = "Rebels";
		this.muAcBa.Text = "Thieves";
		this.muVoLuongSon.Text = "Mt.Infinity";
		this.muKinhHo.Text = "Twin Island";
		this.muKiemCac.Text = "Wild Plains";
		this.muThaiHo.Text = "Reed Port";
		this.muTungSon.Text = "Mt.Sanctity";
		this.muDonHoang.Text = "Dun Huang";
		this.menuTayHo.Text = "West Lake";
		this.menuNhiHai.Text = "Werewolf Plain";
		this.menuNhanNham.Text = "South Yan";
		this.menuThieuLam.Text = "Shaolin";
		this.menuCaiBang.Text = "Beggars Alliance";
		this.menuMinhGiao.Text = "Pyromancer";
		this.menuVoDang.Text = "Taoist";
		this.menuNgamy.Text = "Lotus Order";
		this.menuQuyCoc.Text = "Voodoo";
		this.menuThienLong.Text = "Royalty";
		this.menuThienSon.Text = "Assassin";
		this.menuTieuDao.Text = "Minstrel";
		this.menuMoDung.Text = "Sphinx";
		this.menuTuyetTinh.Text = "Heartless";
		this.menuDuongMon.Text = "Tang Men";
		this.menuDaoHoa.Text = "Peach Blossom Island";
		this.menuTinhTuc.Text = "Ghost Fairy";
		this.muKyCuoc.Text = "Chess";
		this.muTucCau.Text = "Soccer";
		this.muDaTru.Text = "Boar";
		this.muMongHeo.Text = "Boar King";
		this.muTrungAc.Text = "Mission Of Treasure";
		this.muMoBaoTangDo.Text = "Open Treasure Map";
		this.muSuMon.Text = "Mission Of Menpai";
		this.muLauLanTamBao.Text = "Kroraina Treasure";
		this.muBaoDoHiem.Text = "Open Special Treasure";
		this.muPhungHoangLangMo.Text = "Phoenix Tomb";
		this.muThienGiangKyThu.Text = "Mythical Beast Invasion";
		this.muDoanBaoMaTac.Text = "Treasure Raider Cavalry";
		this.menuBossMap.Text = "Scene Leader Boss";
		this.muDiDoi.Text = "Go Exchange";
		this.muThuongHoi.Text = "Player Shop";
		this.muThuongKho.Text = "Bank";
		this.muDi.Text = "Go";
		this.muDiNhan.Text = "Go Receive";
		this.muDiSua.Text = "Go Repair";
		this.muPkMode.Text = "Pk Mode";
		this.muTrangBi.Text = "Equipment";
		this.muGom.Text = "Collect";
		this.muThuongDung.Text = "Common Use";
		this.checkTrongTrot.Text = "Plant ";
		this.checkCraft.Text = "Craft  ";
		this.checkRadius.Text = "Radius";
		this.btnAddPoint.Text = "+ Point";
		this.btnJoinGuild.Text = "Join";
		this.txtJoindGuildId.String_0 = "Guild ID";
		this.muQ1ToChau.Text = "Q1 Su Zhou";
		this.muQ2ToChau.Text = "Q2 Su Zhou";
		this.muQ3ToChau.Text = "Q3 Su Zhou";
		this.toolStripMenuItem_35.Text = "Q3 Su Zhou Fast Accept";
		this.muQ1LauLan.Text = "Q1 Kroraina";
		this.muQ2LauLan.Text = "Q2 Kroraina";
		this.muQ3LauLan.Text = "Q3 Kroraina";
		this.muThuyLao.Text = "Water Prison";
		this.muCanQuet.Text = "Clear";
		this.muLenNgua.Text = "Mount [Ctrl + U]";
		this.muXuongNgua.Text = "Dismount [Ctrl + D]";
		this.mLenNgua.Text = "Mount";
		this.mXuongNgua.Text = "Dismount";
		this.muSapXepTayNai.Text = "Sort Bag [Alt + Z]";
		this.muDiemDanh.Text = "Check-in [Ctrl + P]";
		this.menuPickItem.Text = "Pick up items";
		this.menuPickNear.Text = "Pick up nearby items";
		this.muItemFiller.Text = "Item Filler";
		this.menuFollowKey.Text = "Follow Key";
		this.menuuForceFollowKey.Text = "Force Follow Key";
		this.menuAtkFollowKey.Text = "Follow leader's attack [Ctrl + Q]";
		this.menuPkMode.Text = "Only attack players";
		this.menuOpenGame.Text = "Open Game";
		this.menuSelectPath.Text = "Select Path";
		this.muConCai.Text = "Children";
		this.muCotTruyen.Text = "Story Mission";
		this.menuThuongSon.Text = "Werewolf Hill";
		this.menuVoDi.Text = "Mt. Fire Rock";
		this.menuThaoNguyen.Text = "Grasslands";
		this.menuHuyenVuDao.Text = "Pet Island";
		this.menuKinhHo.Text = "Twin Island";
		this.muTangKinhCac.Text = "Scripture Library";
		this.muKyCuocNhanh.Text = (this.muLauLanTamBaoNhanh.Text = "Quick");
		this.muKyCuocCham.Text = (this.muLauLanTamBaoCham.Text = "Slowly");
		this.muNhanLai.Text = "Reclaim";
		this.muDiBanRac.Text = "Go Sell Junk";
		this.muTriLieu.Text = "Healing";
		this.muTriLieuBanRacCatDo.Text = "Sell Junk + Heal + Store Items";
		this.muNhanx2.Text = "Start Double EXP";
		this.muDongx2.Text = "Freeze Double EXP";
		this.menuMoSap.Text = "Open Stall";
		this.muLenGia.Text = "Sell Item on Stall";
		this.muDuaKNBCho.Text = "Give Yuanbao To";
		this.muDuaDoChoTa.Text = "Give Items + Gold To";
		this.muDuaTangBaoDo.Text = "Give Treasure Maps To";
		this.menuChayThuongNhan.Text = "Trader";
		this.menuStopTrader.Text = "Stop [Ctrl + Down]";
		this.menuQuayVe.Text = "Go Back [Ctrl + Left]";
		this.menuDiToi.Text = "Go Forward [Ctrl + Right]";
		this.qBangToolStripMenuItem.Text = "Guild Mission";
		this.muXayDung.Text = "Goverment->Building Mission";
		this.muNghienCuu.Text = "Goverment->Research Mission";
		this.muKhuyechTruong.Text = "Maidan->Expansion Mission";
		this.muThuongNghiep.Text = "Shop->Commerce Mission";
		this.muCongTrinh.Text = "Contruction->Contruction Mission";
		this.muKyThuat.Text = "Technology->Technique Mission";
		this.muPhatTrien.Text = "Food->Development Mission";
		this.muQuocPhong.Text = "Military->Defense Mission";
		this.menuToDoi.Text = "Team";
		this.menuJoinTeam.Text = "Join Team";
		this.muGiaiTan.Text = "Leave and Disband";
		this.menuSetNhom.Text = "Set Team";
		this.menuQuanLyNhom.Text = "Manage Team";
		this.menuTuTaoNhom.Text = "Auto Create Team";
		this.menuMoiDoi.Text = "Invite Team [Ctrl + F1 | Ctrl + End]";
		this.menuDiChuyen.Text = "Move";
		this.menuUse.Text = "Use";
		this.menuUseThoLinhChau.Text = "Light Dust Capsule";
		this.menuUseDinhViPhu.Text = "Location Spell";
		this.menuUseTrieuTapLenh.Text = "Class Teleport Board";
		this.menuDinhViThoLinhChau.Text = "Light Dust Capsule -> Ctrl + [";
		this.muDinhViAllThoLinhChau.Text = "All Light Dust Capsule -> Ctrl + ]";
		this.menuAllDinhViPhu.Text = "All Location Spell";
		this.menuLucPhu.Text = "[Earth + Heaven] Spell";
		this.menuThemPhu.Text = "Add FuZhou";
		this.menuDiChuyenVongTron.Text = "Move in Circle [Alt + G]";
		this.menuDinhVi.Text = "Set Position";
		this.menuTrieuTapTheo.Text = "Summon";
		this.menuTrieuTap.Text = "Summon [Alt + F1]";
		this.menuTrieuTapNhom.Text = "Summon Team [Alt + F2]";
		this.menuBuocTrieuTap.Text = "Force Summon [Alt + F3]";
		this.menuLuuToaDo.Text = "Save Training Point";
		this.menuLenToaDo.Text = "Go to Training Point";
		this.menuThemToaDo.Text = "+ Add Point +";
		this.muNhanLaiYenTuO.Text = (this.evYenTuO.Text = (this.muCQYenTuO.Text = "Swallow's Dock"));
		this.evTuTuyetTrang.Text = (this.muCQTuTuyetTrang.Text = (this.muNhanLaiTuTuyetTrang.Text = "Marvels' Estate"));
		this.evThieuThatSon.Text = (this.muCQThieuThatSon.Text = (this.muNhanLaiThieuThatSon.Text = "Shaolin Mountain"));
		this.evPhieuMieuPhong.Text = (this.muCQKhieuChienPMP.Text = (this.muNhanLaiPhieuMieuPhong.Text = "Misty Peaks"));
		this.evBinhThanhKyTran.Text = "Tactic Challenge";
		this.evVuongLang.Text = (this.muCQVuongLang.Text = (this.muNhanLaiVuongLang.Text = "Phoenix Mausoleum"));
		this.evTamThan.Text = (this.muCQTamThan.Text = (this.muNhanLaiTamThan.Text = "Three God Scene"));
		this.muQuanSonHai.Text = "Guanshan Sea";
		this.evPhucDia.Text = (this.muCQPhucDia.Text = (this.muNhanLaiPhucDia.Text = "Blessed Land"));
		this.evPhucDiaKho.Text = (this.muCQPhucDiaKho.Text = "Blessed Land - Hard");
		this.evTruPhiPhaTamQuan.Text = (this.muCQTruPhiPhaTamQuan.Text = "Three Talent Valley");
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000EFFA4 File Offset: 0x000EE1A4
	public void method_7()
	{
		this.checkHuyCraft.Boolean_0 = Class226.Boolean_0;
		this.numHuyCraftStar.Value = Class226.Int32_0;
		this.numHuyCraftLine.Value = Class226.Int32_1;
		string text = GUI.String_1 + "/";
		GUI.setting_0 = new Setting
		{
			Dock = DockStyle.Fill
		};
		GUI.univer_0 = new Univer
		{
			Dock = DockStyle.Fill
		};
		this.tabChat_0 = new TabChat
		{
			Dock = DockStyle.Fill
		};
		this.tabSetting.Controls.Add(GUI.setting_0);
		this.tabConfig.Controls.Add(GUI.univer_0);
		this.tabChat.Controls.Add(this.tabChat_0);
		Class228.smethod_0();
		Class228.Event_0 -= this.method_32;
		Class228.Event_0 += this.method_32;
		if (!string.IsNullOrWhiteSpace(this.String_2))
		{
			Class228.smethod_2();
			this.tabChat_0.method_5();
		}
		if (Class226.Boolean_61)
		{
			GUI.setting_0.method_1();
			GUI.univer_0.method_16();
			this.method_6();
		}
		if (Directory.GetFiles(text, "*.xml").Length == 0)
		{
			File.WriteAllText(text + "\\#0.xml", string.Empty);
		}
		string[] files = Directory.GetFiles(text, "*.xml");
		for (int i = 0; i < files.Length; i++)
		{
			GUI.Class495 @class = new GUI.Class495();
			@class.gui_0 = this;
			@class.string_0 = files[i];
			base.Invoke(new Action(@class.method_0));
		}
		base.Invoke(new Action(this.method_107));
		foreach (ValueTuple<string, string> valueTuple in Class106.Class210_0["SkillDelay"].ToList<ValueTuple<string, string>>())
		{
			Class106.Dictionary_0[valueTuple.Item1.smethod_26()] = valueTuple.Item2.smethod_26();
		}
		foreach (ValueTuple<string, string> valueTuple2 in Class106.Class210_0["Path"])
		{
			if (File.Exists(valueTuple2.Item2))
			{
				Class226.List_0.Add(valueTuple2.Item2);
			}
		}
		Class226.List_0 = Class226.List_0.smethod_9<string, string>(new Func<string, string>(GUI.Class403.f_A642BF9F.method_34)).ToList<string>();
		base.Invoke(new Action(this.method_108));
		base.Invoke(new Action(this.method_109));
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000F027C File Offset: 0x000EE47C
	private void method_8()
	{
		LoginiAuto loginiAuto = new LoginiAuto
		{
			Dock = DockStyle.Fill
		};
		foreach (object obj in this.tabPay.Controls)
		{
			((Control)obj).Visible = false;
		}
		base.Controls.Add(loginiAuto);
		this.tabMain.Visible = false;
		this.menuMain.Visible = false;
		loginiAuto.BringToFront();
		loginiAuto.Disposed += this.method_110;
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000F0324 File Offset: 0x000EE524
	public void method_9(string string_6 = null)
	{
		GUI.Class497 @class = new GUI.Class497();
		@class.string_0 = string_6;
		if (string.IsNullOrWhiteSpace(@class.string_0))
		{
			GUI.ReportGameLaunchError(null, "Chưa chọn đường dẫn game (Game.exe hoặc launcher).");
			return;
		}
		try
		{
			if (GUI.Boolean_2 && @class.string_0.ToLower().Contains("batbai"))
			{
				GClass34.smethod_5(@class.string_0);
			}
			else if (GUI.Boolean_2 && @class.string_0.ToLower().Contains("tiennhan"))
			{
				GClass32.GClass33 result = GClass32.smethod_2(@class.string_0, "-fl");
				if (result != null && !string.IsNullOrEmpty(result.string_3))
				{
					GUI.ReportGameLaunchError(@class.string_0, result.string_3);
				}
			}
			else if (GUI.Boolean_2 && @class.string_0.ToLower().Contains("thienmay"))
			{
				Class95.Class96 result = Class95.smethod_2(@class.string_0, "-fl");
				if (result != null && !string.IsNullOrEmpty(result.string_3))
				{
					GUI.ReportGameLaunchError(@class.string_0, result.string_3);
				}
			}
			else if (GUI.Boolean_2 && @class.string_0.ToLower().Contains("huyet"))
			{
				Task.Run(new Action(@class.method_0));
			}
			else
			{
				string gameFile = GUI.ResolveGameFile(@class.string_0);
				if (gameFile == null)
				{
					GUI.ReportGameLaunchError(@class.string_0, "Không tìm thấy file game (đã thử cả Bin\\Game.exe).");
					return;
				}
				// Game.exe itself is started directly; anything else is a launcher that is told where Game.exe is
				bool isGameExe = string.Equals(Path.GetFileName(gameFile), "Game.exe", StringComparison.OrdinalIgnoreCase);
				Process.Start(new ProcessStartInfo
				{
					FileName = gameFile,
					Arguments = isGameExe ? "-fl -fk" : ".\\Bin\\Game.exe -fl -fk",
					WorkingDirectory = Path.GetDirectoryName(gameFile)
				});
			}
		}
		catch (Exception ex)
		{
			GUI.ReportGameLaunchError(@class.string_0, ex.Message);
		}
	}

	/// <summary>
	/// Returns the file to start for a configured game path: the file itself, or for a folder
	/// its Game.exe / Bin\Game.exe. Returns null when nothing usable exists.
	/// </summary>
	internal static string ResolveGameFile(string gamePath)
	{
		if (string.IsNullOrWhiteSpace(gamePath))
		{
			return null;
		}
		string path = gamePath.Trim().Trim('"');
		try
		{
			if (File.Exists(path))
			{
				return path;
			}
			if (Directory.Exists(path))
			{
				// same order as the in-process launchers: <folder>\Game.exe first, then <folder>\Bin\Game.exe
				string inRoot = Path.Combine(path, "Game.exe");
				if (File.Exists(inRoot))
				{
					return inRoot;
				}
				string inBin = Path.Combine(path, "Bin", "Game.exe");
				if (File.Exists(inBin))
				{
					return inBin;
				}
			}
		}
		catch (ArgumentException)
		{
			// invalid characters in the configured path
		}
		return null;
	}

	/// <summary>Writes a game-launch failure to the log list instead of failing silently.</summary>
	internal static void ReportGameLaunchError(string gamePath, string reason)
	{
		try
		{
			string message = string.IsNullOrEmpty(gamePath) ? reason : (reason + " [" + gamePath + "]");
			GUI.smethod_5("iAuto\tMở game\t" + message);
		}
		catch
		{
			// logging must never break the launch loop
		}
	}

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00015ED9 File Offset: 0x000140D9
	// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00015EE0 File Offset: 0x000140E0
	public static bool Boolean_1 { get; set; }

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00015EE8 File Offset: 0x000140E8
	// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00015EEF File Offset: 0x000140EF
	public static bool Boolean_2 { get; set; }

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00015EF7 File Offset: 0x000140F7
	// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00015EFE File Offset: 0x000140FE
	public static bool Boolean_3 { get; set; }

	// Token: 0x060020DA RID: 8410 RVA: 0x000F045C File Offset: 0x000EE65C
	public void method_10()
	{
		try
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_35));
			foreach (KeyValuePair<int, int> keyValuePair in Class106.Dictionary_0)
			{
				Class106.Class210_0["SkillDelay", keyValuePair.Key.ToString()] = keyValuePair.Value.ToString();
			}
			Class106.Class210_0["Inbox"] = null;
			foreach (object obj in this.lvInbox.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				Class106.Class210_0["Inbox", listViewItem.SubItems[0].Text] = listViewItem.SubItems.Cast<ListViewItem.ListViewSubItem>().Skip<ListViewItem.ListViewSubItem>(1).Select<ListViewItem.ListViewSubItem, string>(new Func<ListViewItem.ListViewSubItem, string>(GUI.Class403.f_A642BF9F.method_36))
					.smethod_8('\t');
			}
		}
		catch
		{
		}
		TabLogin.List_0.ForEach(new Action<TabLogin>(GUI.Class403.f_A642BF9F.method_37));
		Class226.smethod_0();
		Class106.Class210_0.method_0(null);
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000F0628 File Offset: 0x000EE828
	private static void smethod_8(NetworkStream networkStream_0, NetworkStream networkStream_1)
	{
		byte[] array = new byte[4096];
		try
		{
			int num;
			while ((num = networkStream_0.Read(array, 0, array.Length)) > 0)
			{
				if (array[0] != 109 || array[1] != 121)
				{
					networkStream_1.Write(array, 0, num);
					networkStream_1.Flush();
				}
			}
		}
		catch
		{
			networkStream_0.Close();
			networkStream_1.Close();
		}
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000F0694 File Offset: 0x000EE894
	private static void smethod_9(NetworkStream networkStream_0, NetworkStream networkStream_1)
	{
		byte[] array = new byte[4096];
		try
		{
			int num;
			while ((num = networkStream_0.Read(array, 0, array.Length)) > 0)
			{
				if (num == 413)
				{
					for (int i = 101; i < 413; i++)
					{
						array[i] = (byte)GUI.random_0.Next(0, 255);
					}
				}
				networkStream_1.Write(array, 0, num);
				networkStream_1.Flush();
			}
		}
		catch
		{
			networkStream_0.Close();
			networkStream_1.Close();
		}
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000F071C File Offset: 0x000EE91C
	private static void smethod_10(TcpClient tcpClient_0, string string_6, int int_6)
	{
		GUI.Class498 @class = new GUI.Class498();
		@class.networkStream_0 = tcpClient_0.GetStream();
		TcpClient tcpClient = new TcpClient(string_6, int_6);
		@class.networkStream_1 = tcpClient.GetStream();
		@class.networkStream_1.Write(GUI.byte_0, 0, GUI.byte_0.Length);
		@class.networkStream_1.Flush();
		Task.Run(new Action(@class.method_0));
		Task.Run(new Action(@class.method_1));
	}

	// Token: 0x060020DE RID: 8414
	[DllImport("user32.dll")]
	private static extern bool RegisterHotKey(IntPtr intptr_1, int int_6, int int_7, int int_8);

	// Token: 0x060020DF RID: 8415 RVA: 0x00015F06 File Offset: 0x00014106
	private void toolStripMenuItem_21_Click(object sender, EventArgs e)
	{
		Class106.List_3.ToList<Class106>().ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_38));
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x00015F36 File Offset: 0x00014136
	private void method_11(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.ToList<Class106>().ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_39));
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x00015F66 File Offset: 0x00014166
	private void muAnDon_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_40));
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x00015F91 File Offset: 0x00014191
	private void autoPkAltIToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AutoPkEx.AutoPkEx_0.Show();
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000F0794 File Offset: 0x000EE994
	private void menuPoison_Click(object sender, EventArgs e)
	{
		GUI.Class404 @class = new GUI.Class404();
		@class.int_0 = (sender as ToolStripMenuItem).Tag.ToString().smethod_26();
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class405 class2 = new GUI.Class405();
				class2.class404_0 = @class;
				class2.class106_0 = enumerator.Current;
				Task.Run(new Action(class2.method_0));
			}
		}
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x000F0820 File Offset: 0x000EEA20
	private void menuBossMap_DropDownOpening(object sender, EventArgs e)
	{
		foreach (object obj in this.menuBossMap.DropDownItems)
		{
			if (typeof(ToolStripMenuItem) == obj.GetType())
			{
				ToolStripMenuItem toolStripMenuItem = obj as ToolStripMenuItem;
				if (toolStripMenuItem.Tag != null)
				{
					if (Class106.Class106_0 != null && Class106.Class106_0.Int32_48 == Class531.smethod_18(toolStripMenuItem.Tag.ToString()) && Class106.Class106_0.List_5.Contains(Enum17.DatDoiBossMap))
					{
						toolStripMenuItem.Checked = true;
					}
					else
					{
						toolStripMenuItem.Checked = false;
					}
				}
			}
		}
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x00015F9D File Offset: 0x0001419D
	private void method_12(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_42));
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000F08E0 File Offset: 0x000EEAE0
	private void method_13(object sender, EventArgs e)
	{
		GUI.Class406 @class = new GUI.Class406();
		@class.gui_0 = this;
		@class.label_0 = new Label();
		@class.label_0.AutoSize = false;
		@class.label_0.TextAlign = ContentAlignment.MiddleCenter;
		@class.label_0.Dock = DockStyle.Bottom;
		@class.label_0.Text = "Plz Enter Pass and New Pass";
		foreach (object obj in this.tabPay.Controls)
		{
			((Control)obj).Hide();
		}
		@class.class533_0 = new Class533
		{
			Dock = DockStyle.Bottom
		};
		@class.class533_0.String_0 = "Pass";
		@class.class533_1 = new Class533
		{
			Dock = DockStyle.Bottom
		};
		@class.class533_1.String_0 = "New Pass";
		@class.button_0 = new Button
		{
			Dock = DockStyle.Bottom
		};
		@class.button_0.Text = "Change";
		@class.button_1 = new Button
		{
			Dock = DockStyle.Bottom
		};
		@class.button_1.Text = "Done";
		base.Invoke(new Action(@class.method_0));
		@class.button_1.Click += @class.method_1;
		@class.button_0.Click += @class.method_2;
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000F0A54 File Offset: 0x000EEC54
	private void method_14(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_3)
		{
			@class.String_27 = "Go";
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000F0AA4 File Offset: 0x000EECA4
	private void method_15(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_3)
		{
			@class.String_27 = "Back";
		}
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000F0AF4 File Offset: 0x000EECF4
	private void btnJoinGuild_Click(object sender, EventArgs e)
	{
		GUI.Class407 @class = new GUI.Class407();
		@class.int_0 = -1;
		if (!string.IsNullOrEmpty(this.txtJoindGuildId.Text.Trim()))
		{
			@class.int_0 = this.txtJoindGuildId.Text.smethod_26();
		}
		if (@class.int_0 >= 0)
		{
			using (IEnumerator<Class106> enumerator = Class106.IEnumerable_3.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GUI.Class408 class2 = new GUI.Class408();
					class2.class407_0 = @class;
					class2.class106_0 = enumerator.Current;
					Task.Run(new Action(class2.method_0));
				}
			}
		}
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x00015FC8 File Offset: 0x000141C8
	private void btnOpenGiftCode_Click(object sender, EventArgs e)
	{
		MessBox.smethod_0("Phiên bản LAuto Pro đã được kích hoạt VIP Vĩnh Viễn!\nBạn không cần nạp GiftCode.");
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x00015FDC File Offset: 0x000141DC
	private void btnRefresh_Click(object sender, EventArgs e)
	{
		this.ApplyModernDarkCyberTheme();
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x00015FFE File Offset: 0x000141FE
	private void btnSendChip_Click(object sender, EventArgs e)
	{
		MessBox.smethod_0("Tài khoản đang hoạt động ở chế độ VIP trọn đời.");
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x00016012 File Offset: 0x00014212
	private void method_16(Class106 class106_0)
	{
		GUI.Class409 @class = new GUI.Class409();
		@class.class106_0 = class106_0;
		Task.Run(new Action(@class.method_0));
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x00016031 File Offset: 0x00014231
	private void menuBuocTrieuTap_Click(object sender, EventArgs e)
	{
		this.method_16(this.Class106_0);
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000F0BA0 File Offset: 0x000EEDA0
	private void lblFriendCityName_Click(object sender, EventArgs e)
	{
		if (Class106.IEnumerable_3.Count<Class106>() >= 0)
		{
			Class106 @class = Class106.IEnumerable_3.First<Class106>();
			if (@class.Class527_0.Int32_35 < 500 || @class.Class527_0.Int32_35 > 550)
			{
				MessBox.smethod_0("Vui lòng vào thành thông thương");
				return;
			}
			string text = Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()];
			int int32_ = Class106.Class106_0.Class527_0.Int32_41;
			string text2 = GUI.Class210_0["Point", int32_.ToString()];
			if (text.Split(new char[] { '|' }).Length == 4)
			{
				string text3 = string.Concat(new string[]
				{
					text.Split(new char[] { '|' })[0],
					"|",
					text.Split(new char[] { '|' })[1],
					"|",
					text2,
					"|",
					@class.Class527_0.String_12
				});
				Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()] = text3;
			}
			else
			{
				string text4 = "#|#|" + text2 + "|" + @class.Class527_0.String_12;
				Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()] = text4;
			}
			this.lblFriendCityName.Text = "[" + @class.Class527_0.String_12 + "]";
		}
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000F0D94 File Offset: 0x000EEF94
	private void btnKham_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			int int32_ = @class.Class214_0.IEnumerable_0.FirstOrDefault<Class516>(new Func<Class516, bool>(this.method_116)).Int32_11;
			int int32_2 = @class.Class214_0.IEnumerable_0.FirstOrDefault<Class516>(new Func<Class516, bool>(this.method_117)).Int32_11;
			if (@class.Class502_0.Int32_5 == 1)
			{
				Class106 class2 = @class;
				string[] array = new string[9];
				array[0] = "for i=1,4 do\r\n\tif LifeAbility:Baoshiyi_GetGemType(";
				array[1] = int32_.ToString();
				array[2] = ", i-1) == -1 then\r\n\t\tholetoenchase = i\r\n\t\tbreak\r\n\tend\r\nend\r\nClear_XSCRIPT()\r\nSet_XSCRIPT_Function_Name('EnchaseEx_3')\r\nSet_XSCRIPT_ScriptID(701614)\r\nSet_XSCRIPT_Parameter(0,";
				array[3] = int32_2.ToString();
				array[4] = ")\r\nSet_XSCRIPT_Parameter(1,";
				array[5] = int32_.ToString();
				array[6] = ")\r\nSet_XSCRIPT_Parameter(2, ";
				array[7] = @class.Class214_0.IEnumerable_1.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_43)).FirstOrDefault<Class516>().Int32_11.ToString();
				array[8] = ")\r\nSet_XSCRIPT_Parameter(3,-1)\r\nSet_XSCRIPT_Parameter(4,holetoenchase-1)\r\nSet_XSCRIPT_ParamCount(5)\r\nSend_XSCRIPT()";
				class2.method_375(string.Concat(array), false);
			}
			else
			{
				Class106 class3 = @class;
				string[] array2 = new string[7];
				array2[0] = "LifeAbility : Do_Enchase( ";
				array2[1] = int32_.ToString();
				array2[2] = " ,  ";
				array2[3] = int32_2.ToString();
				array2[4] = ", ";
				array2[5] = @class.Class214_0.IEnumerable_1.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_44)).FirstOrDefault<Class516>().Int32_11.ToString();
				array2[6] = ",-1);";
				class3.method_375(string.Concat(array2), false);
			}
		}
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000F0F70 File Offset: 0x000EF170
	private void method_17(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_3)
		{
			@class.String_27 = "";
		}
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x0001603F File Offset: 0x0001423F
	private void button14_Click(object sender, EventArgs e)
	{
		MessBox.smethod_0("Cơ chế tiêm DLL (WOW64) và Lua Engine đang hoạt động bình thường.");
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000F0FC0 File Offset: 0x000EF1C0
	private void btnDuc_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			GUI.Class410 class2 = new GUI.Class410();
			class2.class516_0 = @class.Class214_0.IEnumerable_0.FirstOrDefault<Class516>(new Func<Class516, bool>(this.method_119));
			int num = -1;
			if (class2.class516_0 != null)
			{
				num = class2.class516_0.Int32_11;
			}
			int int32_ = @class.Class214_0.IEnumerable_0.Where<Class516>(new Func<Class516, bool>(class2.method_0)).OrderBy<Class516, int>(new Func<Class516, int>(GUI.Class403.f_A642BF9F.method_45)).FirstOrDefault<Class516>()
				.Int32_11;
			if (@class.Class502_0.Int32_5 == 1)
			{
				@class.method_375(string.Concat(new string[]
				{
					"_material,_money,_count,_holecount=LifeAbility:Stiletto_Preparation(",
					num.ToString(),
					", 1)\r\n\tif _holecount < ",
					3.ToString(),
					" then\r\n\r\n\t\tClear_XSCRIPT()\r\n\t\t\tSet_XSCRIPT_Function_Name('StilettoEx_3')\r\n\t\t\tSet_XSCRIPT_ScriptID(311200)\r\n\t\t\tSet_XSCRIPT_Parameter(0,",
					num.ToString(),
					")\r\n\r\n            Set_XSCRIPT_Parameter(1,",
					int32_.ToString(),
					")\r\n\t\t\tSet_XSCRIPT_ParamCount(2)\r\n\t\tSend_XSCRIPT()\r\n        return 'duc'\r\n\tend\r\nreturn 'dux'"
				}), false);
			}
			else
			{
				@class.method_375(string.Concat(new string[]
				{
					"_material,_money,_count,_holecount=LifeAbility:Stiletto_Preparation(",
					num.ToString(),
					", 1)\r\n\tif _holecount < ",
					3.ToString(),
					" then\r\n\r\n\t\tClear_XSCRIPT()\r\n\t\t\tSet_XSCRIPT_Function_Name('OnStiletto')\r\n\t\t\tSet_XSCRIPT_ScriptID(311200)\r\n\t\t\tSet_XSCRIPT_Parameter(0,",
					num.ToString(),
					")\r\n\r\n            Set_XSCRIPT_Parameter(1,",
					int32_.ToString(),
					")\r\n\t\t\tSet_XSCRIPT_ParamCount(2)\r\n\t\tSend_XSCRIPT()\r\n        return 'duc'\r\n\tend\r\nreturn 'dux'"
				}), false);
			}
		}
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000F1180 File Offset: 0x000EF380
	private void button17_Click(object sender, EventArgs e)
	{
		if (this.txtChatContent.Text == "Fake")
		{
			Class106.Boolean_0 = true;
			return;
		}
		string text = "/" + this.txtChatFrom.Text + " " + this.txtChatContent.Text;
		if (this.lvInbox.SelectedItems.Count > 0)
		{
			foreach (Class106 @class in Class106.List_3)
			{
				if (@class.Class527_0.String_11 == this.lvInbox.SelectedItems[0].SubItems[2].Text)
				{
					@class.method_375("Talk:SendChatMessage('near', '" + text + "');", false);
				}
			}
		}
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_18(object sender, EventArgs e)
	{
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000F1270 File Offset: 0x000EF470
	private void method_19(ToolStripMenuItem toolStripMenuItem_80, string string_6)
	{
		toolStripMenuItem_80.DropDownItems.Clear();
		try
		{
			if (!string.IsNullOrWhiteSpace(string_6))
			{
				int num = string_6.IndexOf("\"Go\":");
				if (num != -1)
				{
					int num2 = string_6.IndexOf('{', num);
					if (num2 != -1)
					{
						string text = this.method_21(string_6, num2);
						if (!string.IsNullOrEmpty(text))
						{
							toolStripMenuItem_80.DropDownItems.Clear();
							this.method_20(toolStripMenuItem_80, text);
						}
					}
				}
			}
		}
		catch (Exception)
		{
			File.Delete("iAuto.Go.json");
		}
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000F12FC File Offset: 0x000EF4FC
	private void method_20(ToolStripMenuItem toolStripMenuItem_80, string string_6)
	{
		int i = 0;
		while (i < string_6.Length)
		{
			while (i < string_6.Length && char.IsWhiteSpace(string_6[i]))
			{
				i++;
			}
			if (i >= string_6.Length)
			{
				break;
			}
			if (string_6[i] == '"')
			{
				i++;
				int num = i;
				while (i < string_6.Length)
				{
					if (string_6[i] == '"')
					{
						break;
					}
					i++;
				}
				if (i >= string_6.Length)
				{
					break;
				}
				string text = string_6.Substring(num, i - num);
				for (i++; i < string_6.Length; i++)
				{
					if (string_6[i] == ':')
					{
						break;
					}
				}
				if (i >= string_6.Length)
				{
					break;
				}
				i++;
				while (i < string_6.Length && char.IsWhiteSpace(string_6[i]))
				{
					i++;
				}
				if (i >= string_6.Length)
				{
					break;
				}
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text);
				if (string_6[i] == '{')
				{
					string text2 = this.method_21(string_6, i);
					this.method_20(toolStripMenuItem, text2);
					i += text2.Length + 2;
				}
				else if (string_6[i] == '"')
				{
					i++;
					int num2 = i;
					while (i < string_6.Length)
					{
						if (string_6[i] == '"')
						{
							break;
						}
						i++;
					}
					if (i >= string_6.Length)
					{
						break;
					}
					string text3 = string_6.Substring(num2, i - num2);
					toolStripMenuItem.Tag = text3;
					toolStripMenuItem.Click += this.method_22;
					i++;
				}
				else if (string_6[i] == 'n')
				{
					i += 4;
					toolStripMenuItem.Enabled = false;
				}
				toolStripMenuItem_80.DropDownItems.Add(toolStripMenuItem);
			}
			while (i < string_6.Length && (string_6[i] == ',' || char.IsWhiteSpace(string_6[i])))
			{
				i++;
			}
		}
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000F14CC File Offset: 0x000EF6CC
	private string method_21(string string_6, int int_6)
	{
		if (int_6 < string_6.Length)
		{
			if (string_6[int_6] == '{')
			{
				int num = 1;
				int num2 = int_6 + 1;
				while (num2 < string_6.Length && num > 0)
				{
					if (string_6[num2] == '{')
					{
						num++;
					}
					else if (string_6[num2] == '}')
					{
						num--;
					}
					num2++;
				}
				if (num != 0)
				{
					MessageBox.Show("Lỗi: Dấu ngoặc không khớp trong JSON");
					return string.Empty;
				}
				return string_6.Substring(int_6 + 1, num2 - int_6 - 2);
			}
		}
		return string.Empty;
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000F1550 File Offset: 0x000EF750
	private void method_22(object sender, EventArgs e)
	{
		ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
		string text = toolStripMenuItem.Text.Trim();
		List<Class106> list = Class106.IEnumerable_1.ToList<Class106>();
		if (list.Count == 0 && Class106.IEnumerable_2.Count<Class400>() == 0)
		{
			return;
		}
		if (text == "Càn")
		{
			list.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_46));
			return;
		}
		if (text == "Chiến Trường Phong Hỏa")
		{
			list.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_47));
			return;
		}
		if (text == "Khôn")
		{
			list.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_48));
			return;
		}
		if (toolStripMenuItem.Tag != null)
		{
			GUI.Class411 @class = new GUI.Class411();
			@class.string_0 = toolStripMenuItem.Tag.ToString();
			if (this.tabMain.SelectedIndex == 1)
			{
				Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
				return;
			}
			list.ForEach(new Action<Class106>(@class.method_1));
		}
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000F1680 File Offset: 0x000EF880
	private void btnTrac_Click(object sender, EventArgs e)
	{
		GUI.Class412 @class = new GUI.Class412();
		@class.int_1 = -1;
		@class.int_0 = -1;
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class413 class2 = new GUI.Class413();
				class2.class412_0 = @class;
				class2.class106_0 = enumerator.Current;
				foreach (Class516 class3 in class2.class106_0.Class214_0.IEnumerable_0)
				{
					if (class3.String_1 == this.cboGem.Text)
					{
						GUI.Class414 class4 = new GUI.Class414();
						class2.class412_0.int_0 = class3.Int32_11;
						class4.int_0 = class3.String_1.smethod_26();
						class2.class412_0.int_1 = class2.class106_0.Class214_0.IEnumerable_0.Where<Class516>(new Func<Class516, bool>(class4.method_0)).FirstOrDefault<Class516>().Int32_11;
					}
				}
				if (class2.class412_0.int_1 == -1)
				{
					foreach (Class516 class5 in class2.class106_0.Class214_0.IEnumerable_0)
					{
						if (class5.String_1 == "Bảo Thạch Điêu Trác Phù Cấp 3" && !class5.Boolean_5)
						{
							class2.class412_0.int_1 = class5.Int32_11;
						}
					}
				}
				if (class2.class412_0.int_0 != -1 && class2.class412_0.int_1 != -1)
				{
					if (class2.class106_0.Class502_0.Int32_5 == 1)
					{
						Task.Run(new Action(class2.method_0));
					}
					else
					{
						class2.class106_0.method_375(string.Concat(new string[]
						{
							"Clear_XSCRIPT();\r\n                Set_XSCRIPT_Function_Name('OnGemCarve');\r\n                Set_XSCRIPT_ScriptID(800117);\r\n                Set_XSCRIPT_Parameter(0, ",
							class2.class412_0.int_0.ToString(),
							");\r\n                Set_XSCRIPT_Parameter(1, ",
							class2.class412_0.int_1.ToString(),
							");\r\n                Set_XSCRIPT_Parameter(2, 135);\r\n                Set_XSCRIPT_ParamCount(3);\r\n                Send_XSCRIPT();"
						}), false);
					}
				}
			}
		}
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x00016053 File Offset: 0x00014253
	private void method_23(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_120));
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x0001606B File Offset: 0x0001426B
	private void button6_Click(object sender, EventArgs e)
	{
		this.txtRao.Text = Class106.Class106_0.Class527_0.String_4;
	}

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x060020FD RID: 8445 RVA: 0x00016087 File Offset: 0x00014287
	public static Class210 Class210_0
	{
		get
		{
			return new Class210(Class616.String_0);
		}
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000F18F4 File Offset: 0x000EFAF4
	private void lblCityName_Click(object sender, EventArgs e)
	{
		if (Class106.IEnumerable_3.Count<Class106>() >= 0)
		{
			Class106 @class = Class106.IEnumerable_3.First<Class106>();
			if (@class.Class527_0.Int32_35 < 500 || @class.Class527_0.Int32_35 > 550)
			{
				MessBox.smethod_0("Vui lòng vào thành thị của Bang");
				return;
			}
			string text = Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()];
			int int32_ = Class106.Class106_0.Class527_0.Int32_41;
			string text2 = GUI.Class210_0["Point", int32_.ToString()];
			if (text.Split(new char[] { '|' }).Length == 4)
			{
				string text3 = string.Concat(new string[]
				{
					text2,
					"|",
					@class.Class527_0.String_12,
					"|",
					text.Split(new char[] { '|' })[2],
					"|",
					text.Split(new char[] { '|' })[3]
				});
				Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()] = text3;
			}
			else
			{
				string text4 = text2 + "|" + @class.Class527_0.String_12 + "|#|#";
				Class106.Class210_0["Trader", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()] = text4;
			}
			this.lblCityName.Text = "[" + @class.Class527_0.String_12 + "]";
		}
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x00016093 File Offset: 0x00014293
	private void btnHop_Click(object sender, EventArgs e)
	{
		this.method_39(this.cboGem.Text);
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_24(object sender, EventArgs e)
	{
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000160A6 File Offset: 0x000142A6
	private void cboMenpai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_121));
		}
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000F1AE8 File Offset: 0x000EFCE8
	private void cboLeader_DropDown(object sender, EventArgs e)
	{
		this.cboLeader.Items.Clear();
		this.cboLeader.Items.Add("");
		this.cboLeader.Items.Add("Leader");
		ComboBox.ObjectCollection items = this.cboLeader.Items;
		object[] array = Class106.List_3.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_49)).SelectMany<Class106, Class504>(new Func<Class106, IEnumerable<Class504>>(GUI.Class403.f_A642BF9F.method_50)).Select<Class504, string>(new Func<Class504, string>(GUI.Class403.f_A642BF9F.method_52))
			.Distinct<string>()
			.ToArray<string>();
		items.AddRange(array);
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x0000500B File Offset: 0x0000320B
	private void cboLeader_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000F1BC0 File Offset: 0x000EFDC0
	private void cboLeader_TextChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			GUI.Class415 @class = new GUI.Class415();
			@class.string_0 = this.cboLeader.Text;
			if (@class.string_0.Equals("Leader"))
			{
				@class.string_0 = string.Empty;
			}
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000F1C20 File Offset: 0x000EFE20
	private void chkRaoVat_CheckedChanged(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		Control control = (Control)sender;
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			if (control == this.chkRaoVat)
			{
				@class.Class264_0.Boolean_13 = this.chkRaoVat.Checked;
			}
		}
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000160C5 File Offset: 0x000142C5
	private void checkAutoPhu_CheckedChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_122));
		}
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000160E4 File Offset: 0x000142E4
	private void checkAutoShow_CheckedChanged(object sender, EventArgs e)
	{
		Class226.Boolean_25 = this.checkAutoShow.Checked;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000160F6 File Offset: 0x000142F6
	private void checkPanel_CheckedChanged(object sender, EventArgs e)
	{
		this.splitContainer1.Panel2Collapsed = !this.checkPanel.Checked;
		Class226.Boolean_149 = this.checkPanel.Checked;
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x00016121 File Offset: 0x00014321
	private void checkCraft_CheckedChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_123));
		}
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_25(object sender, EventArgs e)
	{
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x00016140 File Offset: 0x00014340
	private void checkShowPass_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkShowPass.Checked)
		{
			this.txtPass2.PasswordChar = '\0';
			return;
		}
		this.txtPass2.PasswordChar = '*';
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x00016169 File Offset: 0x00014369
	private void method_26(object sender, EventArgs e)
	{
		Class226.Boolean_148 = this.checkSkill.Checked;
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x0001617B File Offset: 0x0001437B
	private void toolStripMenuItem_19_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_53));
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000161A6 File Offset: 0x000143A6
	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_56));
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000161D1 File Offset: 0x000143D1
	private void clearToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.lvInbox.Items.Clear();
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000161E3 File Offset: 0x000143E3
	private void cboCheNoiNgoai_SelectedIndexChanged(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(this.method_124));
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000F1C94 File Offset: 0x000EFE94
	private void cboTrangBi_DropDown(object sender, EventArgs e)
	{
		ComboBox comboBox = sender as ComboBox;
		comboBox.Items.Clear();
		foreach (Class516 @class in Class106.Class106_0.Class214_0.IEnumerable_1.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_59)))
		{
			if (@class.String_1.Trim().Length > 0)
			{
				comboBox.Items.Add(@class.String_1);
			}
		}
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000F1D40 File Offset: 0x000EFF40
	private void method_27(object sender, EventArgs e)
	{
		ComboBox comboBox = sender as ComboBox;
		comboBox.Items.Clear();
		ComboBox.ObjectCollection items = comboBox.Items;
		object[] array = Class106.Class106_0.Class214_0.IEnumerable_0.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_60)).Select<Class516, string>(new Func<Class516, string>(GUI.Class403.f_A642BF9F.method_61)).ToArray<string>();
		items.AddRange(array);
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x000F1DC8 File Offset: 0x000EFFC8
	private void cboGem_DropDown(object sender, EventArgs e)
	{
		ComboBox comboBox = sender as ComboBox;
		comboBox.Items.Clear();
		ComboBox.ObjectCollection items = comboBox.Items;
		object[] array = Class106.Class106_0.Class214_0.IEnumerable_0.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_62)).smethod_9<Class516, string>(new Func<Class516, string>(GUI.Class403.f_A642BF9F.method_63)).Select<Class516, string>(new Func<Class516, string>(GUI.Class403.f_A642BF9F.method_64))
			.ToArray<string>();
		items.AddRange(array);
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000F1E74 File Offset: 0x000F0074
	private void copyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106 @class = Class106.IEnumerable_1.FirstOrDefault<Class106>();
		if (@class != null)
		{
			if (@class.Class502_0.Int32_5 != 1)
			{
				Clipboard.SetText(@class.Class527_0.String_10);
				return;
			}
			Clipboard.SetText(@class.Class527_0.String_2.Substring(8) + @class.Class527_0.String_2.Substring(0, 8));
		}
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x000161FB File Offset: 0x000143FB
	private void menuDauThai_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_65));
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x000F1EDC File Offset: 0x000F00DC
	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.lvInbox.SelectedItems)
		{
			((ListViewItem)obj).Remove();
		}
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x00016226 File Offset: 0x00014426
	private void menuDeoTrangBi_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_66));
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x00016251 File Offset: 0x00014451
	private void muDiemDanh_Click(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_67));
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000F1F38 File Offset: 0x000F0138
	private void muDinhViAllThoLinhChau_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class420 @class = new GUI.Class420();
				@class.class106_0 = enumerator.Current;
				new Thread(new ThreadStart(@class.method_0)).Start();
			}
		}
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000F1FA0 File Offset: 0x000F01A0
	private void menuDinhViThoLinhChau_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class421 @class = new GUI.Class421();
				@class.class106_0 = enumerator.Current;
				new Thread(new ThreadStart(@class.method_0)).Start();
			}
		}
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000F2008 File Offset: 0x000F0208
	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		GUI.Class422 @class = new GUI.Class422();
		@class.int_0 = (sender as ToolStripMenuItem).Tag.ToString().smethod_26();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x0001627C File Offset: 0x0001447C
	private void method_28(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_68));
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000F204C File Offset: 0x000F024C
	private void eitOFFLINEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106.List_3.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_69)).smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_70));
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000F20A8 File Offset: 0x000F02A8
	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Class238.smethod_2();
		}
		catch
		{
		}
		ChatServerMMF.smethod_8();
		this.method_10();
		base.Dispose();
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000F20E0 File Offset: 0x000F02E0
	private void method_29(object sender, EventArgs e)
	{
		foreach (object obj in this.LvGame.Columns)
		{
			((ColumnHeader)obj).Width = 0;
		}
		this.columnHeader_4.Width = 80;
		this.columnHeader_14.Width = 150;
		this.columnHeader_7.Width = 43;
		this.columnHeader_11.Width = 42;
		this.columnHeader_8.Width = 32;
		this.columnHeader_15.Width = 70;
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x000162A7 File Offset: 0x000144A7
	private void menuFollowKey_Click(object sender, EventArgs e)
	{
		Class226.Boolean_104 = !this.menuFollowKey.Checked;
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000162BC File Offset: 0x000144BC
	private void method_30(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_71));
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000162E7 File Offset: 0x000144E7
	private void menuGiamDinh_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_72));
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000F2190 File Offset: 0x000F0390
	private void muGom_DropDownOpening(object sender, EventArgs e)
	{
		this.muDuaDoChoTa.DropDownItems.Clear();
		this.muDuaKNBCho.DropDownItems.Clear();
		this.muDuaTangBaoDo.DropDownItems.Clear();
		this.toolStripMenuItem_49.DropDownItems.Clear();
		this.toolStripMenuItem_51.DropDownItems.Clear();
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		List<ToolStripMenuItem> list2 = new List<ToolStripMenuItem>();
		List<ToolStripMenuItem> list3 = new List<ToolStripMenuItem>();
		List<ToolStripMenuItem> list4 = new List<ToolStripMenuItem>();
		List<ToolStripMenuItem> list5 = new List<ToolStripMenuItem>();
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class423 @class = new GUI.Class423();
				@class.gui_0 = this;
				@class.class106_0 = enumerator.Current;
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
				toolStripMenuItem.Tag = @class.class106_0;
				toolStripMenuItem.Click += @class.method_0;
				list.Add(toolStripMenuItem);
				toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
				toolStripMenuItem.Tag = @class.class106_0;
				toolStripMenuItem.Click += @class.method_3;
				list3.Add(toolStripMenuItem);
				toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
				toolStripMenuItem.Tag = @class.class106_0;
				toolStripMenuItem.Click += @class.method_6;
				list2.Add(toolStripMenuItem);
				toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
				toolStripMenuItem.Tag = @class.class106_0;
				toolStripMenuItem.Click += @class.method_9;
				list4.Add(toolStripMenuItem);
				toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
				toolStripMenuItem.Tag = @class.class106_0;
				toolStripMenuItem.Click += @class.method_12;
				list5.Add(toolStripMenuItem);
			}
		}
		Class228.smethod_2();
		Class228.smethod_15();
		GUI.smethod_12(list, "vang");
		GUI.smethod_12(list3, "knb");
		GUI.smethod_12(list2, "tbd");
		GUI.smethod_11(list4);
		ToolStripItemCollection dropDownItems = this.muDuaDoChoTa.DropDownItems;
		ToolStripItem[] array = list.ToArray();
		dropDownItems.AddRange(array);
		ToolStripItemCollection dropDownItems2 = this.muDuaKNBCho.DropDownItems;
		array = list3.ToArray();
		dropDownItems2.AddRange(array);
		ToolStripItemCollection dropDownItems3 = this.muDuaTangBaoDo.DropDownItems;
		array = list2.ToArray();
		dropDownItems3.AddRange(array);
		ToolStripItemCollection dropDownItems4 = this.toolStripMenuItem_49.DropDownItems;
		array = list4.ToArray();
		dropDownItems4.AddRange(array);
		ToolStripItemCollection dropDownItems5 = this.toolStripMenuItem_51.DropDownItems;
		array = list5.ToArray();
		dropDownItems5.AddRange(array);
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000F2470 File Offset: 0x000F0670
	private static void smethod_11(List<ToolStripMenuItem> list_1)
	{
		list_1.Add(new ToolStripMenuItem("──── Máy khác ────")
		{
			Enabled = false
		});
		IReadOnlyList<string> readOnlyList = Class228.smethod_21();
		if (readOnlyList.Count == 0)
		{
			list_1.Add(new ToolStripMenuItem(Class238.Boolean_0 ? "Đang lấy nick máy khác..." : "Chat chưa online")
			{
				Enabled = false
			});
			return;
		}
		foreach (string text in readOnlyList)
		{
			GUI.Class424 @class = new GUI.Class424();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text + "  «máy khác»");
			@class.string_0 = text;
			toolStripMenuItem.Click += @class.method_0;
			list_1.Add(toolStripMenuItem);
		}
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000F2538 File Offset: 0x000F0738
	private static void smethod_12(List<ToolStripMenuItem> list_1, string string_6)
	{
		list_1.Add(new ToolStripMenuItem("──── Máy khác ────")
		{
			Enabled = false
		});
		IReadOnlyList<string> readOnlyList = Class228.smethod_21();
		if (readOnlyList.Count == 0)
		{
			list_1.Add(new ToolStripMenuItem(Class238.Boolean_0 ? "Đang lấy nick máy khác..." : "Chat chưa online")
			{
				Enabled = false
			});
			return;
		}
		foreach (string text in readOnlyList)
		{
			GUI.Class425 @class = new GUI.Class425();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text + "  «máy khác»");
			@class.string_0 = text;
			@class.string_1 = string_6;
			toolStripMenuItem.Click += @class.method_0;
			list_1.Add(toolStripMenuItem);
		}
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000F2608 File Offset: 0x000F0808
	private void method_31(ToolStripMenuItem toolStripMenuItem_80, string string_6)
	{
		if (toolStripMenuItem_80 != null && toolStripMenuItem_80.DropDown.Visible)
		{
			int num = -1;
			int i = 0;
			while (i < toolStripMenuItem_80.DropDownItems.Count)
			{
				if (toolStripMenuItem_80.DropDownItems[i].Text == null || !toolStripMenuItem_80.DropDownItems[i].Text.Contains("Máy khác"))
				{
					i++;
				}
				else
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return;
			}
			bool autoClose = toolStripMenuItem_80.DropDown.AutoClose;
			toolStripMenuItem_80.DropDown.AutoClose = false;
			try
			{
				while (toolStripMenuItem_80.DropDownItems.Count > num)
				{
					toolStripMenuItem_80.DropDownItems.RemoveAt(num);
				}
				List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
				GUI.smethod_12(list, string_6);
				ToolStripItemCollection dropDownItems = toolStripMenuItem_80.DropDownItems;
				ToolStripItem[] array = list.ToArray();
				dropDownItems.AddRange(array);
			}
			finally
			{
				toolStripMenuItem_80.DropDown.AutoClose = autoClose;
			}
			return;
		}
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000F26F4 File Offset: 0x000F08F4
	private void method_32()
	{
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.BeginInvoke(new Action(this.method_125));
		}
		catch
		{
		}
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000F2734 File Offset: 0x000F0934
	private void method_33(ToolStripMenuItem toolStripMenuItem_80)
	{
		if (toolStripMenuItem_80 != null && toolStripMenuItem_80.DropDown.Visible)
		{
			int num = -1;
			int i = 0;
			while (i < toolStripMenuItem_80.DropDownItems.Count)
			{
				if (toolStripMenuItem_80.DropDownItems[i].Text == null || !toolStripMenuItem_80.DropDownItems[i].Text.Contains("Máy khác"))
				{
					i++;
				}
				else
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return;
			}
			bool autoClose = toolStripMenuItem_80.DropDown.AutoClose;
			toolStripMenuItem_80.DropDown.AutoClose = false;
			try
			{
				while (toolStripMenuItem_80.DropDownItems.Count > num)
				{
					toolStripMenuItem_80.DropDownItems.RemoveAt(num);
				}
				List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
				GUI.smethod_11(list);
				ToolStripItemCollection dropDownItems = toolStripMenuItem_80.DropDownItems;
				ToolStripItem[] array = list.ToArray();
				dropDownItems.AddRange(array);
			}
			finally
			{
				toolStripMenuItem_80.DropDown.AutoClose = autoClose;
			}
			return;
		}
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000F2820 File Offset: 0x000F0A20
	private void method_34(string string_6)
	{
		GUI.Class426 @class = new GUI.Class426();
		@class.string_0 = string_6;
		if (string.IsNullOrWhiteSpace(@class.string_0))
		{
			return;
		}
		Class228.smethod_2();
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
			return;
		}
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_1));
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000F2888 File Offset: 0x000F0A88
	private void method_35(string string_6, string string_7)
	{
		GUI.Class427 @class = new GUI.Class427();
		@class.string_0 = string_6;
		@class.string_1 = string_7;
		if (string.IsNullOrWhiteSpace(@class.string_0))
		{
			return;
		}
		Class228.smethod_2();
		@class.string_1 = (@class.string_1 ?? "vang").ToLowerInvariant();
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
		}
		else
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_1));
		}
		Class228.smethod_17(@class.string_0, @class.string_1);
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x00016312 File Offset: 0x00014512
	private void checkNM_CheckedChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_126));
		}
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x0000F95A File Offset: 0x0000DB5A
	private void GUI_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
		{
			base.Hide();
			e.Cancel = true;
			return;
		}
		if (e.CloseReason == CloseReason.WindowsShutDown)
		{
			base.Dispose();
		}
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000F2924 File Offset: 0x000F0B24
	private static void smethod_13(string string_6)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "netsh",
			Arguments = string_6,
			Verb = "runas",
			CreateNoWindow = true,
			UseShellExecute = true
		};
		process.Start();
		process.WaitForExit();
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000F2978 File Offset: 0x000F0B78
	public static void smethod_14()
	{
		foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces().Where<NetworkInterface>(new Func<NetworkInterface, bool>(GUI.Class403.f_A642BF9F.method_73)))
		{
			string name = networkInterface.Name;
			GUI.smethod_13("interface ip set dns name=\"" + name + "\" static 1.1.1.1 primary");
			GUI.smethod_13("interface ip add dns name=\"" + name + "\" 1.0.0.1 index=2");
		}
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x000F2A14 File Offset: 0x000F0C14
	private void GUI_Load(object sender, EventArgs e)
	{
		this.muVoDao.Click += this.muVoDao_Click;
		this.muVoDao1.Click += this.muVoDao1_Click;
		ChatServerMMF.smethod_0();
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
			if (File.ReadAllText(text).Contains("tieudattai.org"))
			{
				File.Delete(text);
			}
		}
		catch
		{
		}
		new Thread(new ThreadStart(this.method_127)).Start();
		try
		{
			foreach (object obj in this.LvGame.Columns)
			{
				ColumnHeader columnHeader = (ColumnHeader)obj;
				if (!string.IsNullOrEmpty(Class106.Class210_0["LvGame", columnHeader.Index.ToString()]))
				{
					columnHeader.DisplayIndex = Class106.Class210_0["LvGame", columnHeader.Index.ToString()].smethod_26();
				}
			}
		}
		catch
		{
		}
		this.method_7();
		this.cboMenpai.smethod_30();
		this.cboLeader.smethod_30();
		this.cboCheNoiNgoai.smethod_30();
		this.cboPoint.smethod_30();
		this.cboTrongTrot.smethod_30();
		new Thread(new ThreadStart(this.method_128)).Start();
		this.splitContainer1.SplitterDistance = this.splitContainer1.Height / 2;
		Task.Run(new Action(this.method_129));
		this.btnRefresh_Click(null, null);
		this.lvSkill.Controls.Add(this.textBox_0);
		this.textBox_0.Visible = false;
		GUI.GUI_0.lvSkill.SubItemClicked += this.method_130;
		GUI.GUI_0.lvSkill.Scroll += GUI.Class403.f_A642BF9F.method_76;
		GUI.GUI_0.lvSkill.SubItemEndEditing += GUI.Class403.f_A642BF9F.method_77;
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x00016331 File Offset: 0x00014531
	private void method_36()
	{
		Task.Run(new Action(this.method_131));
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x00016345 File Offset: 0x00014545
	private void method_37()
	{
		new Thread(new ThreadStart(GUI.Class403.f_A642BF9F.method_78)).Start();
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x00011A79 File Offset: 0x0000FC79
	private void method_38(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000F2C70 File Offset: 0x000F0E70
	private void menuQuanDoan_Click(object sender, EventArgs e)
	{
		GUI.Class430 @class = new GUI.Class430();
		ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
		@class.int_0 = toolStripMenuItem.Tag.ToString().smethod_26();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x0000500B File Offset: 0x0000320B
	private void menuMoHoaNgocTap_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x000F2CB8 File Offset: 0x000F0EB8
	private void method_39(string string_6)
	{
		GUI.Class431 @class = new GUI.Class431();
		if (Class106.Class106_0 != null && !string.IsNullOrEmpty(string_6))
		{
			@class.class106_0 = Class106.Class106_0;
			@class.int_1 = -1;
			int num = -1;
			@class.int_0 = 0;
			if (@class.class106_0.Class502_0.Int32_5 == 1)
			{
				foreach (Class516 class2 in @class.class106_0.Class214_0.IEnumerable_0)
				{
					if (class2.String_4 == "Cloth3_7" && !class2.Boolean_5)
					{
						@class.int_1 = class2.Int32_11;
					}
					if (class2.String_1 == string_6)
					{
						@class.int_0 = class2.Int32_25;
						num = class2.Int32_11;
					}
				}
				if (num != -1 && @class.int_1 != -1)
				{
					Task.Run(new Action(@class.method_0));
					return;
				}
			}
			else
			{
				GUI.Class432 class3 = new GUI.Class432();
				class3.class431_0 = @class;
				class3.list_0 = new List<int>();
				foreach (Class516 class4 in class3.class431_0.class106_0.Class214_0.IEnumerable_0)
				{
					if (class4.String_4 == "Cloth3_7" && !class4.Boolean_5)
					{
						class3.class431_0.int_1 = class4.Int32_11;
					}
					if (class4.String_1 == string_6)
					{
						num = class4.Int32_11;
						class3.list_0.Add(num);
					}
				}
				if (class3.list_0.Count >= 5 && class3.class431_0.int_1 != -1)
				{
					Task.Run(new Action(class3.method_0));
				}
			}
			return;
		}
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00016370 File Offset: 0x00014570
	private void method_40(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.ToList<Class106>().ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_79));
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000163A0 File Offset: 0x000145A0
	private void muItemFiller_Click(object sender, EventArgs e)
	{
		Class226.Boolean_98 = !this.muItemFiller.Checked;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000F2EAC File Offset: 0x000F10AC
	private void menuLayDo_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class434 @class = new GUI.Class434();
				@class.class106_0 = enumerator.Current;
				new Thread(new ThreadStart(@class.method_0)).Start();
			}
		}
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x000163B5 File Offset: 0x000145B5
	private void method_41(object sender, EventArgs e)
	{
		Task.Run(new Action(GUI.Class403.f_A642BF9F.method_80));
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_42(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000F2F14 File Offset: 0x000F1114
	private void len100_Click(object sender, EventArgs e)
	{
		GUI.Class435 @class = new GUI.Class435();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000163DC File Offset: 0x000145DC
	private void menuLenToaDo_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_82));
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x000F2F4C File Offset: 0x000F114C
	private void menuLenGia_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class436 @class = new GUI.Class436();
				@class.class106_0 = enumerator.Current;
				Task.Run(new Action(@class.method_0));
			}
		}
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00016407 File Offset: 0x00014607
	private void muLenNgua_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_83));
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00016432 File Offset: 0x00014632
	private void mLenNgua_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_84));
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x0001645D File Offset: 0x0001465D
	private void method_43(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://zalo.me/g/cfmgni055");
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x0001646A File Offset: 0x0001466A
	private void method_44(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.youtube.com/watch?v=xqC00cAz6jM&list=PLYaqEetIcFfl8F00MwsbK8N5Lih6yO2JP&index=12");
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x000F2FB0 File Offset: 0x000F11B0
	private void lvFunction_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		GUI.Class437 @class = new GUI.Class437();
		if (GUI.bool_0)
		{
			return;
		}
		@class.listViewItem_0 = e.Item;
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x000F2FF0 File Offset: 0x000F11F0
	private void lvInbox_SelectedIndexChanged(object sender, EventArgs e)
	{
		Control control = this.txtContent;
		string[] array = new string[5];
		array[0] = this.lvInbox.SelectedItems[0].Text;
		array[1] = Environment.NewLine;
		array[2] = this.lvInbox.SelectedItems[0].SubItems.Cast<ListViewItem.ListViewSubItem>().Select<ListViewItem.ListViewSubItem, string>(new Func<ListViewItem.ListViewSubItem, string>(GUI.Class403.f_A642BF9F.method_85)).Skip<string>(1)
			.Take<string>(2)
			.smethod_8('\t');
		array[3] = Environment.NewLine;
		array[4] = this.lvInbox.SelectedItems[0].SubItems[3].Text;
		control.Text = string.Concat(array);
		if (this.lvInbox.SelectedItems[0].SubItems.Count > 1)
		{
			this.txtChatFrom.Text = this.lvInbox.SelectedItems[0].SubItems[1].Text;
		}
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000F3100 File Offset: 0x000F1300
	private void lvSkill_DragDrop(object sender, DragEventArgs e)
	{
		foreach (object obj in this.lvSkill.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			Class525 @class = listViewItem.Tag as Class525;
			Class106.Class210_0["Skills", @class.String_0] = listViewItem.Index.ToString();
		}
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x000F318C File Offset: 0x000F138C
	private void lvSkill_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		GUI.Class438 @class = new GUI.Class438();
		@class.itemCheckedEventArgs_0 = e;
		if (GUI.bool_0)
		{
			return;
		}
		foreach (Class106 class2 in Class106.IEnumerable_1)
		{
			List<Class525> list_ = class2.List_6;
			Action<Class525> action;
			if ((action = @class.action_0) == null)
			{
				action = (@class.action_0 = new Action<Class525>(@class.method_0));
			}
			list_.ForEach(action);
		}
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000F3210 File Offset: 0x000F1410
	private void lvSkill_MouseDown(object sender, MouseEventArgs e)
	{
		if (!GUI.bool_0)
		{
			ListViewHitTestInfo listViewHitTestInfo = this.lvSkill.HitTest(e.X, e.Y);
			int index = listViewHitTestInfo.Item.Index;
			int num = listViewHitTestInfo.Item.SubItems.IndexOf(listViewHitTestInfo.SubItem);
			if (num == 1)
			{
				GUI.Class439 @class = new GUI.Class439();
				string text = listViewHitTestInfo.Item.SubItems[num].Text;
				@class.class525_0 = listViewHitTestInfo.Item.Tag as Class525;
				@class.class525_0.Boolean_0 = !@class.class525_0.Boolean_0;
				listViewHitTestInfo.Item.SubItems[1].Text = (@class.class525_0.Boolean_0 ? "X" : "");
				Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
			}
		}
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00016477 File Offset: 0x00014677
	private void socket3_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_86));
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x000F32FC File Offset: 0x000F14FC
	private void menuLuuToaDo_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_3)
		{
			@class.String_28 = string.Concat(new string[]
			{
				@class.Int32_16.ToString(),
				",",
				@class.Int32_17.ToString(),
				",",
				@class.Class527_0.Int32_35.ToString()
			});
		}
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000F339C File Offset: 0x000F159C
	private void LvGame_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		GUI.Class440 @class = new GUI.Class440();
		@class.columnClickEventArgs_0 = e;
		this.bool_2 = !this.bool_2;
		if (this.bool_2)
		{
			Class106.List_3 = Class106.List_3.OrderBy<Class106, string>(new Func<Class106, string>(@class.method_0)).ToList<Class106>();
		}
		else
		{
			Class106.List_3 = Class106.List_3.OrderByDescending<Class106, string>(new Func<Class106, string>(@class.method_1)).ToList<Class106>();
		}
		this.txtMainSearch_TextChanged(null, null);
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x000F3418 File Offset: 0x000F1618
	private void LvGame_DoubleClick(object sender, EventArgs e)
	{
		ListView listView = sender as ListView;
		if (listView.SelectedIndices.Count > 0)
		{
			int num = listView.SelectedIndices[0];
			ListViewItem listViewItem = listView.Items[num];
			listViewItem.Checked = !listViewItem.Checked;
		}
		Class106 @class = Class106.IEnumerable_1.FirstOrDefault<Class106>();
		if (@class != null)
		{
			@class.Boolean_49 = true;
			@class.method_299();
		}
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x000F347C File Offset: 0x000F167C
	private void LvGame_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		object tag = e.Item.Tag;
		this.LvGame.ItemChecked -= this.LvGame_ItemChecked;
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			@class.ListViewItem_0.Checked = e.Item.Checked;
		}
		this.LvGame.ItemChecked += this.LvGame_ItemChecked;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x000164A2 File Offset: 0x000146A2
	private void LvGame_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
		{
			this.menuExitGame_Click(null, null);
		}
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x000164C0 File Offset: 0x000146C0
	private void LvGame_MouseDown(object sender, MouseEventArgs e)
	{
		if (!this.bool_1)
		{
			this.stopwatch_0 = Stopwatch.StartNew();
		}
		this.bool_1 = true;
		this.point_0 = e.Location;
		this.bool_3 = false;
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x000F3510 File Offset: 0x000F1710
	private void LvGame_MouseMove(object sender, MouseEventArgs e)
	{
		if (!this.bool_1)
		{
			return;
		}
		int num = Math.Abs(e.Location.X - this.point_0.X);
		int num2 = Math.Abs(e.Location.Y - this.point_0.Y);
		int num3 = (int)Math.Sqrt((double)(num * num + num2 * num2));
		if (!this.bool_3 && num3 < 5)
		{
			return;
		}
		this.bool_3 = true;
		if (this.stopwatch_0.Elapsed.TotalSeconds >= 0.2)
		{
			if (this.list_0.Count == 0)
			{
				this.list_0 = Class106.IEnumerable_1.ToList<Class106>();
			}
			ListViewItem item = this.LvGame.HitTest(e.Location).Item;
			Graphics graphics = this.LvGame.CreateGraphics();
			if (!this.rectangle_0.IsEmpty)
			{
				this.LvGame.Invalidate(this.rectangle_0);
				this.LvGame.Update();
			}
			Rectangle empty = Rectangle.Empty;
			if (item != null)
			{
				int index = item.Index;
				this.int_2 = index;
				if (this.list_0.Count > 0 && this.int_2 != this.list_0.FirstOrDefault<Class106>().ListViewItem_0.Index)
				{
					Cursor.Current = Cursors.WaitCursor;
					Color red = Color.Red;
					if (this.LvGame.View != View.Details)
					{
						if (this.LvGame.View != View.List)
						{
							empty = new Rectangle(item.Bounds.X - 5, item.Bounds.Y, 10, item.Bounds.Height);
							graphics.DrawLine(new Pen(red, 2f), new Point(item.Bounds.X, item.Bounds.Y), new Point(item.Bounds.X, item.Bounds.Y + item.Bounds.Height));
							graphics.FillPolygon(new SolidBrush(red), new Point[]
							{
								new Point(item.Bounds.X - 5, item.Bounds.Y),
								new Point(item.Bounds.X + 5, item.Bounds.Y),
								new Point(item.Bounds.X, item.Bounds.Y + 5)
							});
							graphics.FillPolygon(new SolidBrush(red), new Point[]
							{
								new Point(item.Bounds.X - 5, item.Bounds.Y + item.Bounds.Height),
								new Point(item.Bounds.X + 5, item.Bounds.Y + item.Bounds.Height),
								new Point(item.Bounds.X, item.Bounds.Y + item.Bounds.Height - 5)
							});
							goto IL_0B98;
						}
					}
					empty = new Rectangle(item.Bounds.X, item.Bounds.Y - 5, this.LvGame.ClientRectangle.Width - item.Bounds.X, 10);
					graphics.DrawLine(new Pen(red, 2f), new Point(item.Bounds.X, item.Bounds.Y), new Point(item.Bounds.X + this.LvGame.ClientRectangle.Width, item.Bounds.Y));
					graphics.FillPolygon(new SolidBrush(red), new Point[]
					{
						new Point(item.Bounds.X, item.Bounds.Y - 5),
						new Point(item.Bounds.X + 5, item.Bounds.Y),
						new Point(item.Bounds.X, item.Bounds.Y + 5)
					});
					graphics.FillPolygon(new SolidBrush(red), new Point[]
					{
						new Point(this.LvGame.ClientRectangle.Width - 4, item.Bounds.Y - 5),
						new Point(this.LvGame.ClientRectangle.Width - 9, item.Bounds.Y),
						new Point(this.LvGame.ClientRectangle.Width - 4, item.Bounds.Y + 5)
					});
				}
			}
			else if (this.LvGame.Items.Count > 0 && this.list_0.Count > 0)
			{
				ListViewItem listViewItem = this.LvGame.Items[this.LvGame.Items.Count - 1];
				Color red2 = Color.Red;
				if (this.LvGame.View != View.Details)
				{
					if (this.LvGame.View != View.List)
					{
						empty = new Rectangle(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y, 10, listViewItem.Bounds.Height);
						graphics.DrawLine(new Pen(red2, 2f), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y), new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
						graphics.FillPolygon(new SolidBrush(red2), new Point[]
						{
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + 5)
						});
						graphics.FillPolygon(new SolidBrush(red2), new Point[]
						{
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width - 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
							new Point(listViewItem.Bounds.X + listViewItem.Bounds.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5)
						});
						goto IL_0B80;
					}
				}
				empty = new Rectangle(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5, this.LvGame.ClientRectangle.Width - listViewItem.Bounds.X, 10);
				graphics.DrawLine(new Pen(red2, 2f), new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height), new Point(listViewItem.Bounds.X + this.LvGame.ClientRectangle.Width, listViewItem.Bounds.Y + listViewItem.Bounds.Height));
				graphics.FillPolygon(new SolidBrush(red2), new Point[]
				{
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
					new Point(listViewItem.Bounds.X + 5, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
					new Point(listViewItem.Bounds.X, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
				});
				graphics.FillPolygon(new SolidBrush(red2), new Point[]
				{
					new Point(this.LvGame.ClientRectangle.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height - 5),
					new Point(this.LvGame.ClientRectangle.Width - 9, listViewItem.Bounds.Y + listViewItem.Bounds.Height),
					new Point(this.LvGame.ClientRectangle.Width - 4, listViewItem.Bounds.Y + listViewItem.Bounds.Height + 5)
				});
				IL_0B80:
				this.int_2 = this.LvGame.Items.Count - 1;
			}
			IL_0B98:
			this.rectangle_0 = empty;
		}
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x000F40C0 File Offset: 0x000F22C0
	private void LvGame_MouseUp(object sender, MouseEventArgs e)
	{
		this.bool_1 = false;
		this.LvGame.Invalidate(this.rectangle_0);
		this.LvGame.Update();
		this.rectangle_0 = Rectangle.Empty;
		if (!this.bool_3)
		{
			this.list_0.Clear();
			this.int_2 = -1;
			return;
		}
		this.bool_3 = false;
		if (this.stopwatch_0.Elapsed.TotalSeconds >= 0.2 && this.list_0.Count > 0 && this.int_2 >= 0 && this.int_2 != this.list_0[0].ListViewItem_0.Index)
		{
			Class106.List_3 = Class106.List_3.Except<Class106>(this.list_0).ToList<Class106>();
			Class106.List_3.InsertRange(this.int_2, this.list_0);
			this.LvGame.SelectedIndices.Clear();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				this.LvGame.SelectedIndices.Add(this.int_2 + i);
			}
			this.list_0.Clear();
			this.txtMainSearch_TextChanged(null, null);
			this.int_2 = -1;
		}
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x000164EF File Offset: 0x000146EF
	private void LvGame_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
	{
		if (Class106.List_4.Count > e.ItemIndex)
		{
			e.Item = Class106.List_4[e.ItemIndex].ListViewItem_0;
		}
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x000F4208 File Offset: 0x000F2408
	private void LvGame_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Class106 @class = (Class106.Class106_0 = Class106.IEnumerable_1.FirstOrDefault<Class106>());
			if (@class != null)
			{
				try
				{
					this.method_56();
				}
				catch
				{
				}
				GUI.bool_0 = true;
				this.checkRadius.Boolean_0 = Class106.Class106_0.Single_1 != 0f;
				this.cboDaTaoDo.Text = @class.String_3;
				if (@class.Class527_0.Boolean_18)
				{
					this.checkRadius.Decimal_0 = Class226.Int32_30;
				}
				else
				{
					this.checkRadius.Decimal_0 = Class226.Int32_29;
				}
				this.checkAutoPhu.Checked = @class.Boolean_57;
				this.checkNM.Checked = @class.Class264_0.Boolean_29;
				string text = string.Format("{0}-{1}", @class.Class527_0.String_8, @class.Class527_0.Int32_38);
				string text2 = Class106.Class210_0["Trader", text];
				if (text2.Split(new char[] { '|' }).Length == 4)
				{
					string[] array = text2.Split(new char[] { '|' });
					this.lblCityName.Text = "[" + array[1] + "]";
					this.lblFriendCityName.Text = "[" + array[3] + "]";
				}
				else
				{
					this.lblCityName.Text = "[None]";
					this.lblFriendCityName.Text = "[None]";
				}
				if (!string.IsNullOrEmpty(Class106.Class210_0["TienViNhat", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()]))
				{
					this.lblTrader.Text = "<-[" + Class106.Class210_0["TienViNhat", @class.Class527_0.String_8 + "-" + @class.Class527_0.Int32_38.ToString()] + "]->";
				}
				else
				{
					this.lblTrader.Text = "<-[Trader]->";
				}
				this.cboLeader.Text = @class.String_6;
				if (string.IsNullOrEmpty(@class.String_28))
				{
					this.lvSkill.Columns[0].Text = "[None]";
				}
				else
				{
					this.lvSkill.Columns[0].Text = "[" + @class.String_28 + "]";
				}
				this.cboMenpai.SelectedIndex = this.cboMenpai.FindString(@class.String_8);
				this.txtPass2.Text = @class.String_10;
				this.checkCraft.Checked = @class.bool_12;
				this.checkTrongTrot.Checked = @class.List_5.Contains(Enum17.TrongTrot);
				foreach (object obj in this.lvFunction.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (listViewItem.Tag != null)
					{
						string text3 = listViewItem.Tag as string;
						if (text3 != null)
						{
							switch (text3.Length)
							{
							case 2:
							{
								char c = text3[1];
								if (c <= '4')
								{
									if (c != '2')
									{
										if (c == '4')
										{
											if (text3 == "x4")
											{
												listViewItem.Checked = @class.Class264_0.Boolean_12;
											}
										}
									}
									else if (text3 == "x2")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_23;
									}
								}
								else if (c != 'm')
								{
									if (c == 'p')
									{
										if (text3 == "mp")
										{
											listViewItem.Checked = @class.Class264_0.Boolean_8;
										}
									}
								}
								else if (text3 == "nm")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_9;
								}
								break;
							}
							case 3:
								if (text3 == "pet")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_25;
								}
								break;
							case 4:
							{
								char c = text3[0];
								if (c != 'l')
								{
									if (c != 'p')
									{
										if (c == 'x')
										{
											if (text3 == "x2x3")
											{
												listViewItem.Checked = @class.Class264_0.Boolean_15;
											}
										}
									}
									else if (text3 == "pick")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_16;
									}
								}
								else if (text3 == "lure")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_18;
								}
								break;
							}
							case 5:
							{
								char c = text3[0];
								if (c != 'f')
								{
									if (c == 'l')
									{
										if (text3 == "lvlup")
										{
											listViewItem.Checked = @class.Class264_0.Boolean_22;
										}
									}
								}
								else if (text3 == "fight")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_27;
								}
								break;
							}
							case 6:
								if (text3 == "attack")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_19;
								}
								break;
							case 7:
							{
								char c = text3[0];
								if (c <= 'h')
								{
									if (c != 'g')
									{
										if (c == 'h')
										{
											if (text3 == "haiduoc")
											{
												listViewItem.Checked = @class.List_5.Contains(Enum17.HaiDuoc);
											}
										}
									}
									else if (text3 == "giacong")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_11;
									}
								}
								else if (c != 'm')
								{
									if (c != 'o')
									{
										if (c == 't')
										{
											if (text3 == "thuthap")
											{
												listViewItem.Checked = @class.List_5.Contains(Enum17.ThuThap);
											}
										}
									}
									else if (text3 == "onlypet")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_20;
									}
								}
								else if (text3 == "muangoc")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_28;
								}
								break;
							}
							case 8:
							{
								char c = text3[0];
								if (c <= 'c')
								{
									if (c != 'b')
									{
										if (c == 'c')
										{
											if (text3 == "comeback")
											{
												listViewItem.Checked = @class.Class264_0.Boolean_10;
											}
										}
									}
									else if (text3 == "baoinbox")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_37;
									}
								}
								else if (c != 'k')
								{
									if (c != 'p')
									{
										if (c == 'q')
										{
											if (text3 == "quayvong")
											{
												listViewItem.Checked = @class.Class264_0.Boolean_21;
											}
										}
									}
									else if (text3 == "picklist")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_26;
									}
								}
								else if (text3 == "khaithac")
								{
									listViewItem.Checked = @class.List_5.Contains(Enum17.KhaiThac);
								}
								break;
							}
							case 9:
								if (text3 == "cankhonho")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_17;
								}
								break;
							case 10:
							{
								char c = text3[1];
								if (c <= 'h')
								{
									if (c != 'e')
									{
										if (c == 'h')
										{
											if (text3 == "khaikhoang")
											{
												listViewItem.Checked = @class.List_5.Contains(Enum17.KhaiKhoang);
											}
										}
									}
									else if (text3 == "keeponline")
									{
										listViewItem.Checked = @class.Class264_0.Boolean_14;
									}
								}
								else if (c != 't')
								{
									if (c == 'u')
									{
										if (text3 == "tulinhngoc")
										{
											listViewItem.Checked = @class.Class264_0.Boolean_24;
										}
									}
								}
								else if (text3 == "attacklist")
								{
									listViewItem.Checked = @class.Boolean_51;
								}
								break;
							}
							case 12:
								if (text3 == "khongbatlich")
								{
									listViewItem.Checked = @class.Class264_0.Boolean_35;
								}
								break;
							}
						}
					}
				}
				this.cboPet.Boolean_0 = @class.Class264_0.Boolean_6;
				this.chkRaoVat.Checked = @class.Class264_0.Boolean_13;
				this.txtRao.Text = @class.String_11;
				this.cboTrongTrot.SelectedIndex = @class.int_42;
				this.cboPet.ComboBox_0.Items.Clear();
				foreach (Class517 class2 in @class.Class527_0.List_0)
				{
					GUI.Class402 class3 = new GUI.Class402();
					class3.String_0 = class2.String_1;
					class3.Int32_0 = Class500.smethod_0(class2.String_0);
					this.cboPet.ObjectCollection_0.Add(class3);
				}
				foreach (object obj2 in this.cboPet.ObjectCollection_0)
				{
					GUI.Class402 class4 = (GUI.Class402)obj2;
					if (class4.Int32_0 == @class.Int32_69)
					{
						this.cboPet.Object_0 = class4;
						break;
					}
				}
				this.method_55();
				this.numberNM.Int32_1 = @class.Int32_53;
			}
		}
		finally
		{
			GUI.bool_0 = false;
		}
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
	private void lvInbox_DoubleClick(object sender, EventArgs e)
	{
		if (this.lvInbox.SelectedItems.Count > 0)
		{
			GUI.Class441 @class = new GUI.Class441();
			@class.string_0 = this.lvInbox.SelectedItems[0].SubItems[2].Text;
			Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(@class.method_0)).smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_87));
		}
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x0001651E File Offset: 0x0001471E
	private void method_45(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_88));
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00016549 File Offset: 0x00014749
	private void menuAtkFollowKey_Click(object sender, EventArgs e)
	{
		Class226.Boolean_5 = !Class226.Boolean_5;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00016558 File Offset: 0x00014758
	private void menuDebug_Click(object sender, EventArgs e)
	{
		new global::Debug(Class106.Class106_0).Show();
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000F4D2C File Offset: 0x000F2F2C
	private void muFuBen_DropDownOpened(object sender, EventArgs e)
	{
		if (Class106.Class106_0 != null)
		{
			if (!Class106.Class106_0.Boolean_66)
			{
				this.menuCQQ1ToChau.Visible = false;
				this.menuCQQ2ToChau.Visible = false;
				this.menuCQQ3ToChau.Visible = false;
				this.menuCQYenTuO.Visible = false;
				this.menuCQSatTinh.Visible = false;
				this.menuCQQ1LauLan.Visible = false;
				this.menuCQQ2LauLan.Visible = false;
				this.menuCQQ3LauLan.Visible = false;
				this.menuCQSCPMP.Visible = false;
				this.menuCQKCPMP.Visible = false;
				this.menuCQThuyNguyetSonTrang.Visible = false;
				this.toolStripMenuItem_75.Visible = false;
				this.muCQKhieuChienPMP.Visible = true;
				this.muCQPhucDia.Visible = true;
				this.muCQPhucDiaKho.Visible = true;
				this.muCQVuongLang.Visible = true;
				this.muCQTamThan.Visible = true;
				this.muCQThieuThatSon.Visible = true;
				this.muCQYenTuO.Visible = true;
				this.muCQTuTuyetTrang.Visible = true;
				this.muCQTruPhiPhaTamQuan.Visible = true;
			}
			else
			{
				this.menuCQQ1ToChau.Visible = true;
				this.menuCQQ2ToChau.Visible = true;
				this.menuCQQ3ToChau.Visible = true;
				this.menuCQYenTuO.Visible = true;
				this.menuCQSatTinh.Visible = true;
				this.menuCQQ1LauLan.Visible = true;
				this.menuCQQ2LauLan.Visible = true;
				this.menuCQQ3LauLan.Visible = true;
				this.menuCQSCPMP.Visible = true;
				this.menuCQKCPMP.Visible = true;
				this.menuCQThuyNguyetSonTrang.Visible = true;
				this.toolStripMenuItem_75.Visible = true;
				this.muCQKhieuChienPMP.Visible = false;
				this.muCQPhucDia.Visible = false;
				this.muCQPhucDiaKho.Visible = false;
				this.muCQVuongLang.Visible = false;
				this.muCQTamThan.Visible = false;
				this.muCQThieuThatSon.Visible = false;
				this.muCQYenTuO.Visible = false;
				this.muCQTuTuyetTrang.Visible = false;
				this.muCQTruPhiPhaTamQuan.Visible = false;
			}
		}
		this.toolStripMenuItem_75.Checked = Class226.Boolean_3;
		DateTime now = DateTime.Now;
		int hour = now.Hour;
		int minute = now.Minute;
		Font font = new Font(this.muAcTac.Font, FontStyle.Bold);
		Dictionary<ToolStripMenuItem, bool> dictionary = new Dictionary<ToolStripMenuItem, bool>();
		dictionary.Add(this.muAcTac, hour == 13 || hour == 15 || hour == 17 || hour == 19 || hour == 21 || hour == 2);
		ToolStripMenuItem toolStripMenuItem = this.muAcBa;
		bool flag;
		if (hour != 0 && hour != 4 && hour != 10 && hour != 12 && hour != 16 && hour != 20)
		{
			if (hour != 22)
			{
				flag = false;
				goto IL_02B3;
			}
		}
		flag = minute <= 30;
		IL_02B3:
		dictionary.Add(toolStripMenuItem, flag);
		dictionary.Add(this.muTangKinhCac, (hour == 10 && minute >= 45) || (hour == 11 && minute <= 15) || (hour == 16 && minute >= 30) || (hour == 21 && minute >= 30) || (hour == 23 && minute <= 30));
		dictionary.Add(this.muKyCuoc, (hour == 11 && minute >= 30) || hour == 12 || hour == 13 || (hour == 14 && minute <= 30) || (hour == 20 && minute >= 30) || hour == 21);
		dictionary.Add(this.muLauLanTamBao, (hour == 11 && minute >= 30) || hour == 12 || hour == 13 || (hour == 14 && minute <= 30) || (hour == 19 && minute >= 30) || hour == 20 || hour == 21);
		dictionary.Add(this.muDaTru, hour == 14 || hour == 15 || (hour == 16 && minute <= 40) || (hour == 21 && minute >= 30) || hour == 22 || hour == 23);
		dictionary.Add(this.muMongHeo, hour == 14 || hour == 15 || (hour == 16 && minute <= 40) || (hour == 21 && minute >= 30) || hour == 22 || hour == 23);
		dictionary.Add(this.muThienGiangKyThu, (hour == 13 && minute >= 30) || (hour == 18 && minute >= 30) || (hour == 19 && minute <= 30) || (hour == 21 && minute >= 45) || (hour == 22 && minute <= 15));
		dictionary.Add(this.muPhungHoangLangMo, hour == 13 || (hour == 22 && minute >= 30) || (hour == 23 && minute <= 30));
		foreach (KeyValuePair<ToolStripMenuItem, bool> keyValuePair in dictionary)
		{
			if (keyValuePair.Value)
			{
				keyValuePair.Key.Font = font;
			}
		}
		if (this.tabMain.SelectedIndex == 1)
		{
			GUI.Class442 @class = new GUI.Class442();
			@class.class400_0 = null;
			foreach (TabLogin tabLogin in TabLogin.List_0)
			{
				if (tabLogin.Parent == this.tabLogin.SelectedTab)
				{
					@class.class400_0 = tabLogin.IEnumerable_0.FirstOrDefault<Class400>();
					break;
				}
			}
			if (@class.class400_0 != null)
			{
				this.muPlayer.smethod_35();
				this.muDaily.smethod_35();
				this.muIntime.smethod_35();
				this.muFuBen.smethod_35();
				foreach (KeyValuePair<ToolStripMenuItem, Enum17[]> keyValuePair2 in this.Dictionary_0)
				{
					IEnumerable<Enum17> value = keyValuePair2.Value;
					Func<Enum17, bool> func;
					if ((func = @class.func_0) == null)
					{
						func = (@class.func_0 = new Func<Enum17, bool>(@class.method_0));
					}
					if (!value.Any<Enum17>(func))
					{
						keyValuePair2.Key.Checked = true;
						keyValuePair2.Key.smethod_33();
					}
					else
					{
						keyValuePair2.Key.Checked = false;
					}
				}
				this.muAcBa.Checked = @class.class400_0.HashSet_0.Contains(Enum17.DatDoiAcBa);
				if (this.muAcBa.Checked)
				{
					foreach (object obj in this.muAcBa.DropDownItems)
					{
						ToolStripMenuItem toolStripMenuItem2 = obj as ToolStripMenuItem;
						if (toolStripMenuItem2 != null)
						{
							if (Class527.smethod_1(@class.class400_0.String_4).Equals(toolStripMenuItem2.Text))
							{
								toolStripMenuItem2.Checked = true;
							}
							else
							{
								toolStripMenuItem2.Checked = false;
							}
						}
					}
				}
				if (!@class.class400_0.HashSet_0.Contains(Enum17.DatDoiAcTac))
				{
					ToolStripMenuItem toolStripMenuItem3 = this.muVoLuongSon;
					ToolStripMenuItem toolStripMenuItem4 = this.muKinhHo;
					ToolStripMenuItem toolStripMenuItem5 = this.muKiemCac;
					ToolStripMenuItem toolStripMenuItem6 = this.muTungSon;
					this.muDonHoang.Checked = false;
					toolStripMenuItem6.Checked = false;
					toolStripMenuItem5.Checked = false;
					toolStripMenuItem4.Checked = false;
					toolStripMenuItem3.Checked = false;
					this.muAcTac.Checked = false;
				}
				else
				{
					this.muAcTac.Checked = true;
				}
				this.muTangKinhCac.Checked = @class.class400_0.HashSet_0.Contains(Enum17.DatDoiTangKinhCac);
				if (!@class.class400_0.HashSet_0.Contains(Enum17.DatDoiTangKinhCac))
				{
					ToolStripMenuItem toolStripMenuItem7 = this.menuTayHo;
					ToolStripMenuItem toolStripMenuItem8 = this.menuNhiHai;
					this.menuNhanNham.Checked = false;
					toolStripMenuItem8.Checked = false;
					toolStripMenuItem7.Checked = false;
					this.muTangKinhCac.Checked = false;
					return;
				}
				this.muTangKinhCac.Checked = true;
				return;
			}
		}
		else
		{
			GUI.Class443 class2 = new GUI.Class443();
			class2.class106_0 = Class106.IEnumerable_1.FirstOrDefault<Class106>();
			if (class2.class106_0 != null)
			{
				this.muPlayer.smethod_35();
				this.muDaily.smethod_35();
				this.muIntime.smethod_35();
				this.muFuBen.smethod_35();
				foreach (KeyValuePair<ToolStripMenuItem, Enum17[]> keyValuePair3 in this.Dictionary_0)
				{
					IEnumerable<Enum17> value2 = keyValuePair3.Value;
					Func<Enum17, bool> func2;
					if ((func2 = class2.func_0) == null)
					{
						func2 = (class2.func_0 = new Func<Enum17, bool>(class2.method_0));
					}
					if (!value2.Any<Enum17>(func2))
					{
						keyValuePair3.Key.Checked = true;
						keyValuePair3.Key.smethod_33();
					}
					else
					{
						keyValuePair3.Key.Checked = false;
					}
				}
				this.muAcBa.Checked = class2.class106_0.List_5.Contains(Enum17.DatDoiAcBa);
				if (this.muAcBa.Checked)
				{
					foreach (object obj2 in this.muAcBa.DropDownItems)
					{
						ToolStripMenuItem toolStripMenuItem9 = obj2 as ToolStripMenuItem;
						if (toolStripMenuItem9 != null)
						{
							if (Class527.smethod_2(class2.class106_0.Int32_40).Equals(toolStripMenuItem9.Text))
							{
								toolStripMenuItem9.Checked = true;
							}
							else
							{
								toolStripMenuItem9.Checked = false;
							}
						}
					}
				}
				if (!class2.class106_0.List_5.Contains(Enum17.DatDoiAcTac))
				{
					ToolStripMenuItem toolStripMenuItem10 = this.muVoLuongSon;
					ToolStripMenuItem toolStripMenuItem11 = this.muKinhHo;
					ToolStripMenuItem toolStripMenuItem12 = this.muKiemCac;
					ToolStripMenuItem toolStripMenuItem13 = this.muTungSon;
					this.muDonHoang.Checked = false;
					toolStripMenuItem13.Checked = false;
					toolStripMenuItem12.Checked = false;
					toolStripMenuItem11.Checked = false;
					toolStripMenuItem10.Checked = false;
					this.muAcTac.Checked = false;
				}
				else
				{
					this.muVoLuongSon.Checked = class2.class106_0.Int32_70 == Class513.Int32_46;
					this.muKinhHo.Checked = class2.class106_0.Int32_70 == Class513.Int32_45;
					this.muKiemCac.Checked = class2.class106_0.Int32_70 == Class513.Int32_47;
					this.muThaiHo.Checked = class2.class106_0.Int32_70 == Class513.Int32_44;
					this.muTungSon.Checked = class2.class106_0.Int32_70 == Class513.Int32_43;
					this.muDonHoang.Checked = class2.class106_0.Int32_70 == Class513.Int32_48;
					this.muAcTac.Checked = true;
				}
				this.muTangKinhCac.Checked = class2.class106_0.List_5.Contains(Enum17.DatDoiTangKinhCac);
				if (!class2.class106_0.List_5.Contains(Enum17.DatDoiTangKinhCac))
				{
					ToolStripMenuItem toolStripMenuItem14 = this.menuTayHo;
					ToolStripMenuItem toolStripMenuItem15 = this.menuNhiHai;
					this.menuNhanNham.Checked = false;
					toolStripMenuItem15.Checked = false;
					toolStripMenuItem14.Checked = false;
					this.muTangKinhCac.Checked = false;
					return;
				}
				this.menuTayHo.Checked = class2.class106_0.Int32_71 == Class513.Int32_76;
				this.menuNhiHai.Checked = class2.class106_0.Int32_71 == Class513.Int32_70;
				this.menuNhanNham.Checked = class2.class106_0.Int32_71 == Class513.Int32_108;
				this.muTangKinhCac.Checked = true;
			}
		}
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x00016569 File Offset: 0x00014769
	private void menuExitGame_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_89));
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00016594 File Offset: 0x00014794
	private void menuHideGame_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_90));
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000F5850 File Offset: 0x000F3A50
	protected override void WndProc(ref Message m)
	{
		bool flag = false;
		using (List<GClass2>.Enumerator enumerator = GClass2.list_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.method_0(m))
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			base.WndProc(ref m);
		}
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000F58B8 File Offset: 0x000F3AB8
	private void menuListView_Opening(object sender, CancelEventArgs e)
	{
		int num = Class106.IEnumerable_1.Count<Class106>();
		ValueTuple<int, int> valueTuple = GUI.smethod_15(num);
		int num2 = valueTuple.Item1;
		int num3 = valueTuple.Item2;
		if (num2 < 1)
		{
			num2 = 1;
		}
		if (num3 < 1)
		{
			num3 = 1;
		}
		this.menuShowGame.Text = string.Concat(new string[]
		{
			"Show [",
			num3.ToString(),
			"x",
			num2.ToString(),
			"]"
		});
		if (Class106.Class106_0 != null)
		{
			this.menuThemToaDo.Enabled = true;
			this.menuThemToaDo.Text = string.Concat(new string[]
			{
				"+ ",
				Class106.Class106_0.Class527_0.String_12,
				" [",
				Class106.Class106_0.Int32_16.ToString(),
				",",
				Class106.Class106_0.Int32_17.ToString(),
				"] +"
			});
		}
		else
		{
			this.menuThemToaDo.Enabled = false;
		}
		this.menuTuTaoNhom.Checked = Class226.Boolean_20;
		this.menuDebug.Visible = this.String_2.Equals("tieudattai@yahoo.com") || this.String_2.Equals("0813673640");
		try
		{
			this.menuRefreshAuto.Text = "Refresh [" + num.ToString() + "] [Ctrl + W]";
			if (Class226.Boolean_61)
			{
				this.menuCreateTeam.Text = string.Concat(new string[]
				{
					"Create Team [",
					(num / 6).ToString(),
					"x6 +",
					(num % 6).ToString(),
					"]"
				});
				this.menuSetNhom.Text = string.Concat(new string[]
				{
					"Set Team [",
					(num / 6).ToString(),
					"x6 +",
					(num % 6).ToString(),
					"]"
				});
			}
			else
			{
				this.menuCreateTeam.Text = string.Concat(new string[]
				{
					"Tạo Nhóm [",
					(num / 6).ToString(),
					"x6 +",
					(num % 6).ToString(),
					"]"
				});
				this.menuSetNhom.Text = string.Concat(new string[]
				{
					"Set Nhóm [",
					(num / 6).ToString(),
					"x6 +",
					(num % 6).ToString(),
					"]"
				});
			}
			this.menuJoinTeam.DropDownItems.Clear();
			using (IEnumerator<Class106> enumerator = Class106.List_3.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_91)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GUI.Class444 @class = new GUI.Class444();
					@class.class106_0 = enumerator.Current;
					if (@class.class106_0.Class527_0.Boolean_21)
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(@class.class106_0.Class527_0.String_11);
						toolStripMenuItem.Click += @class.method_0;
						this.menuJoinTeam.DropDownItems.Add(toolStripMenuItem);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000F5C5C File Offset: 0x000F3E5C
	private void menuMoiDoi_Click(object sender, EventArgs e)
	{
		if (Class106.Class106_0 != null && Class106.Class106_0.Class527_0.String_11 != "OFFLINE")
		{
			if (Class106.Class106_0.Class527_0.Boolean_21)
			{
				this.method_47(Class106.Class106_0);
				return;
			}
			Class106.Class106_0.Class512_0.method_27();
		}
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000F5CB8 File Offset: 0x000F3EB8
	private void muNier_DropDownOpening(object sender, EventArgs e)
	{
		this.menuuForceFollowKey.Checked = Class226.Boolean_11;
		this.menuPickItem.Checked = Class226.Boolean_103;
		this.muItemFiller.Checked = Class226.Boolean_98;
		this.menuAtkFollowKey.Checked = Class226.Boolean_5;
		this.menuFollowKey.Checked = Class226.Boolean_104;
		this.pauseToolStripMenuItem.Checked = Class226.Boolean_143;
		this.menuPkMode.Checked = Class226.Boolean_106;
		this.menuPickNear.Checked = Class226.Boolean_146;
		this.toolStripMenuItem_47.Checked = Class226.Boolean_45;
		this.toolStripMenuItem_48.Checked = Class226.Boolean_46;
		this.toolStripMenuItem_73.Checked = Class226.Boolean_47;
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x000165BF File Offset: 0x000147BF
	private void method_46(object sender, EventArgs e)
	{
		this.method_54();
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x000165C7 File Offset: 0x000147C7
	private void menuPickItem_Click(object sender, EventArgs e)
	{
		Class226.Boolean_103 = !Class226.Boolean_103;
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000165D6 File Offset: 0x000147D6
	private void menuRefreshAuto_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_92));
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x00016601 File Offset: 0x00014801
	private void menuSelectServer_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_93));
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x000F5D78 File Offset: 0x000F3F78
	private void menuSetNhom_Click(object sender, EventArgs e)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		foreach (IEnumerable<Class106> enumerable in Class106.IEnumerable_1.ToArray<Class106>().smethod_25<Class106>(6))
		{
			GUI.Class445 @class = new GUI.Class445();
			@class.list_0 = enumerable.Select<Class106, string>(new Func<Class106, string>(GUI.Class403.f_A642BF9F.method_94)).ToList<string>();
			Class226.Dictionary_2.Values.smethod_22<List<string>>(new Action<List<string>>(@class.method_0));
			Class226.Dictionary_2[enumerable.First<Class106>().Class527_0.String_11] = @class.list_0;
			dictionary[dictionary.Count.ToString()] = @class.list_0;
		}
		Class226.Dictionary_2 = Class226.Dictionary_2.Where<KeyValuePair<string, List<string>>>(new Func<KeyValuePair<string, List<string>>, bool>(GUI.Class403.f_A642BF9F.method_95)).ToDictionary<KeyValuePair<string, List<string>>, string, List<string>>(new Func<KeyValuePair<string, List<string>>, string>(GUI.Class403.f_A642BF9F.method_96), new Func<KeyValuePair<string, List<string>>, List<string>>(GUI.Class403.f_A642BF9F.method_97));
		using (IEnumerator<Class400> enumerator2 = Class106.IEnumerable_6.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GUI.Class446 class2 = new GUI.Class446();
				class2.class400_0 = enumerator2.Current;
				IEnumerable<KeyValuePair<string, List<string>>> enumerable2 = Class226.Dictionary_2.Where<KeyValuePair<string, List<string>>>(new Func<KeyValuePair<string, List<string>>, bool>(class2.method_0));
				if (enumerable2 != null)
				{
					class2.class400_0.ListViewItem_0.SubItems[14].Text = enumerable2.Select<KeyValuePair<string, List<string>>, string>(new Func<KeyValuePair<string, List<string>>, string>(GUI.Class403.f_A642BF9F.method_98)).FirstOrDefault<string>();
				}
				else
				{
					class2.class400_0.ListViewItem_0.SubItems[14].Text = "...";
				}
			}
		}
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000F5FA8 File Offset: 0x000F41A8
	private void menuShowGame_Click(object sender, EventArgs e)
	{
		if (Class106.IEnumerable_1.Count<Class106>() > 1)
		{
			this.x8ToolStripMenuItem_Click(sender, e);
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_99));
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x0001662C File Offset: 0x0001482C
	private void menuTrieuTap_Click(object sender, EventArgs e)
	{
		this.method_62(Class106.Class106_0);
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x00016639 File Offset: 0x00014839
	private void menuTrieuTapNhom_Click(object sender, EventArgs e)
	{
		this.method_63();
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000F5FF4 File Offset: 0x000F41F4
	private void method_47(Class106 class106_0)
	{
		if (!class106_0.Class527_0.Boolean_41)
		{
			return;
		}
		if (!class106_0.Class527_0.Boolean_21)
		{
			class106_0.Class512_0.method_27();
		}
		foreach (Class106 @class in Class106.IEnumerable_0)
		{
			if (@class.Class506_0.Class504_1 != null && @class.Class506_0.Class504_1.Int32_8 == -1)
			{
				@class.method_370(class106_0.Class527_0.Byte_0);
			}
			if (@class.Class502_0.Int32_5 == 1)
			{
				@class.method_372(class106_0.Class527_0.Byte_0);
			}
		}
	}

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06002166 RID: 8550 RVA: 0x00016641 File Offset: 0x00014841
	// (set) Token: 0x06002167 RID: 8551 RVA: 0x00016648 File Offset: 0x00014848
	public static IntPtr IntPtr_0 { get; set; }

	// Token: 0x06002168 RID: 8552 RVA: 0x000F60B0 File Offset: 0x000F42B0
	private void method_48()
	{
		for (;;)
		{
			try
			{
				try
				{
					GUI.IntPtr_0 = Class534.GetForegroundWindow();
					if (string.IsNullOrEmpty(this.String_2) || string.IsNullOrEmpty(Class226.String_0))
					{
						Thread.Sleep(1000);
						continue;
					}
					if (!GUI.Boolean_3)
					{
						Thread.Sleep(1000);
						continue;
					}
				}
				catch
				{
				}
				Class534.smethod_10();
				if (Class226.Boolean_74 && Class226.Int32_19 > 0)
				{
					GUI.Class447 @class = new GUI.Class447();
					@class.class106_0 = Class106.IEnumerable_0.OrderByDescending<Class106, double>(new Func<Class106, double>(GUI.Class403.f_A642BF9F.method_100)).FirstOrDefault<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_101));
					if (@class.class106_0 != null)
					{
						Task.Run(new Action(@class.method_0));
					}
				}
				List<Process> list = Process.GetProcesses().Where<Process>(new Func<Process, bool>(this.method_132)).ToList<Process>()
					.Where<Process>(new Func<Process, bool>(GUI.Class403.f_A642BF9F.method_102))
					.ToList<Process>();
				foreach (Process process in list.Take<Process>(6))
				{
					using (Class515 class2 = new Class515(process.Id))
					{
						Class514 class3 = class2.method_5();
						if (class3 != null)
						{
							string text = class3.String_1;
							try
							{
								DirectoryInfo parent = Directory.GetParent(text);
								File.Delete(((parent != null) ? parent.ToString() : null) + "\\WebClient\\webclient.exe");
							}
							catch
							{
							}
							try
							{
								DirectoryInfo parent2 = Directory.GetParent(text);
								File.Delete(((parent2 != null) ? parent2.ToString() : null) + "\\CrashReport.exe");
							}
							catch
							{
							}
							if (string.IsNullOrEmpty(Class226.String_4))
							{
								Class226.String_4 = text;
							}
							if (!Class226.List_0.Contains(text))
							{
								Class226.List_0.Add(text);
								Class106.Class210_0["Path"] = null;
								for (int i = 0; i < Class226.List_0.Count; i++)
								{
									Class106.Class210_0["Path", i.ToString()] = Class226.List_0[i];
								}
							}
							long int64_ = class3.Int64_0;
							int[] array;
							if (!class2.Boolean_0)
							{
								array = new int[] { 1, 2, 3, 4 };
							}
							else
							{
								(array = new int[1])[0] = 5;
							}
							List<int> list2 = array.ToList<int>();
							int num;
							if (int.TryParse(Class106.Class210_0["GAMETYPEx", text], out num) && list2.Remove(num))
							{
								list2.Insert(0, num);
							}
							string fullName = new DirectoryInfo(text).Parent.Parent.FullName;
							Class502 class4 = null;
							for (int j = 1; j <= 5; j++)
							{
								try
								{
									Class502 class5 = Class502.smethod_0(Class226.String_0, int64_, j);
									if (!string.IsNullOrEmpty(Class106.Class210_0["GAMETYPEx", fullName]))
									{
										if (Class106.Class210_0["GAMETYPEx", fullName] == class5.Int32_5.ToString())
										{
											class4 = class5;
										}
									}
									else if (class2.method_7(new long[] { class5.Int64_50[0] }) != 0 && class2.method_7(new long[]
									{
										class5.Int64_50[0],
										class5.Int64_50[1]
									}) != 0 && class2.method_7(new long[]
									{
										class5.Int64_50[0],
										class5.Int64_50[1],
										class5.Int64_50[2]
									}) != 0)
									{
										class4 = class5;
										break;
									}
								}
								catch (Exception)
								{
								}
							}
							if (class4 != null)
							{
								Class106.Class210_0["GAMETYPEx", fullName] = class4.Int32_5.ToString(CultureInfo.InvariantCulture);
								ListViewItem listViewItem = new ListViewItem(new string[33])
								{
									UseItemStyleForSubItems = false,
									Checked = true,
									BackColor = Color.FromArgb(22, 30, 46),
									ForeColor = Color.FromArgb(241, 245, 249)
								};
								for (int s = 0; s < listViewItem.SubItems.Count; s++)
								{
									listViewItem.SubItems[s].BackColor = Color.FromArgb(22, 30, 46);
									listViewItem.SubItems[s].ForeColor = Color.FromArgb(241, 245, 249);
								}
								listViewItem.Text = "OFFLINE";
								Class106 class6 = new Class106(process, class4, listViewItem);
								class6.String_22 = text;
								Class106.List_3.Add(class6);
								class6.Event_0 += this.method_133;
								class6.Int64_0 = int64_;
							}
						}
					}
				}
				int num2 = Class106.List_3.RemoveAll(new Predicate<Class106>(GUI.Class403.f_A642BF9F.method_103));
				Class106.List_4.RemoveAll(new Predicate<Class106>(GUI.Class403.f_A642BF9F.method_104));
				if (num2 > 0 || list.Count > 0)
				{
					this.txtMainSearch_TextChanged(null, null);
					Thread.Sleep(2000);
					continue;
				}
				int num3 = 6;
				int num4 = 6;
				if (Class226.Boolean_155 && Class226.Int32_31 > 0)
				{
					num3 = Class226.Int32_31;
					num4 = Class226.Int32_31;
				}
				num4 -= Class106.List_3.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_105)).Count<Class106>();
				if (Class226.Boolean_154 && Class226.Int32_24 > 0 && Class226.Int32_24 - Class106.List_3.Count < num3)
				{
					num3 = Class226.Int32_24 - Class106.List_3.Count;
				}
				foreach (TabLogin tabLogin in TabLogin.List_0)
				{
					try
					{
						tabLogin.method_14();
					}
					catch
					{
					}
					if ((this.stopwatch_1 == null || this.stopwatch_1.Elapsed.TotalSeconds >= 60.0) && !tabLogin.checkPaused.Checked)
					{
						int num5 = 6;
						if (tabLogin.Int32_0 > 0)
						{
							num5 = tabLogin.Int32_0 - tabLogin.list_2.Where<Class400>(new Func<Class400, bool>(GUI.Class403.f_A642BF9F.method_106)).Take<Class400>(tabLogin.Int32_0).Count<Class400>();
						}
						if (num5 > 6)
						{
							num5 = 6;
						}
						if (num5 > 0)
						{
							using (IEnumerator<Class400> enumerator3 = tabLogin.list_2.Where<Class400>(new Func<Class400, bool>(GUI.Class403.f_A642BF9F.method_107)).Take<Class400>(num5).GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									GUI.Class449 class7 = new GUI.Class449();
									class7.class400_0 = enumerator3.Current;
									Class106 class8 = Class106.List_3.FirstOrDefault<Class106>(new Func<Class106, bool>(class7.method_0));
									if (class8 != null)
									{
										class7.class400_0.Class106_0 = class8;
										if (class8.Class527_0.Boolean_36)
										{
											class8.method_304();
										}
										class7.class400_0.Boolean_0 = true;
										class7.class400_0.String_21 = "?";
										class8.List_17.Add(class7.class400_0);
									}
									else
									{
										if (num3-- <= 0)
										{
											break;
										}
										string string_ = class7.class400_0.String_24;
										if (string.IsNullOrEmpty(string_))
										{
											string_ = Class226.String_4;
										}
										if (File.Exists(string_))
										{
											num4--;
											this.method_9(string_);
											if (num4 <= 0)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(2000);
		}
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x00016650 File Offset: 0x00014850
	private void menuOpenBank_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_108));
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000F6914 File Offset: 0x000F4B14
	private void muDonHoang_Click(object sender, EventArgs e)
	{
		GUI.Class450 @class = new GUI.Class450();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(GUI.Class403.f_A642BF9F.method_109));
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x0001667B File Offset: 0x0001487B
	private void toolStripMenuItem25_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_110));
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000166A6 File Offset: 0x000148A6
	private void toolStripMenuItem27_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_111));
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000166D1 File Offset: 0x000148D1
	private void toolStripMenuItem26_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_112));
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000166FC File Offset: 0x000148FC
	private void toolStripMenuItem16_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_113));
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x00016727 File Offset: 0x00014927
	private void toolStripMenuItem5_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_114));
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000F6980 File Offset: 0x000F4B80
	private void toolStripMenuItem24_Click(object sender, EventArgs e)
	{
		GUI.Class451 @class = new GUI.Class451();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x00016752 File Offset: 0x00014952
	private void muCQThuCong_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_115)).smethod_22<Class106>(new Action<Class106>(this.method_134));
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000F69B8 File Offset: 0x000F4BB8
	private void method_49(object sender, EventArgs e)
	{
		GUI.Class452 @class = new GUI.Class452();
		@class.int_0 = (sender as ToolStripMenuItem).Tag.ToString().smethod_26();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x000F69FC File Offset: 0x000F4BFC
	private void MenuAcNhanCoc_Click(object sender, EventArgs e)
	{
		GUI.Class453 @class = new GUI.Class453();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		@class.int_0 = @class.toolStripMenuItem_0.Tag.ToString().smethod_26();
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_1));
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x0001678E File Offset: 0x0001498E
	private void menuuForceFollowKey_Click(object sender, EventArgs e)
	{
		Class226.Boolean_11 = !Class226.Boolean_11;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000F6A74 File Offset: 0x000F4C74
	private void muGiaiTan_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_0)
		{
			if (@class.Class502_0.Int32_5 != 1)
			{
				@class.method_375("Player:LeaveTeam(); ", false);
			}
			else
			{
				@class.method_375("Player:LeaveTeam(); Player:LeaveRiad();", false);
			}
		}
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x0001679D File Offset: 0x0001499D
	private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
	{
		this.onTopToolStripMenuItem.Checked = base.TopMost;
		this.pauseToolStripMenuItem.Checked = Class226.Boolean_143;
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000167C0 File Offset: 0x000149C0
	private void muHaoHuu_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_116));
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000F6AE4 File Offset: 0x000F4CE4
	private void muNhapCode_Click(object sender, EventArgs e)
	{
		if (Class106.Class106_0 != null && Class106.Class106_0.Class527_0.Boolean_41)
		{
			string string_ = Class106.Class106_0.Class527_0.String_11;
			TabPage tabPage = new TabPage("Code:" + string_);
			Code code = new Code(Class106.Class106_0)
			{
				Dock = DockStyle.Fill
			};
			code.FormBorderStyle = FormBorderStyle.None;
			code.TopLevel = false;
			tabPage.Controls.Add(code);
			this.tabBoottom.TabPages.Add(tabPage);
			code.Show();
			this.tabBoottom.SelectedTab = tabPage;
		}
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x000F6B7C File Offset: 0x000F4D7C
	private void menuYellow_Click(object sender, EventArgs e)
	{
		GUI.Class454 @class = new GUI.Class454();
		@class.object_0 = sender;
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000F6BAC File Offset: 0x000F4DAC
	private void method_50(object sender, EventArgs e)
	{
		GUI.Class455 @class = new GUI.Class455();
		@class.string_0 = string.Empty;
		for (int i = 1; i < 101; i++)
		{
			@class.string_0 = @class.string_0 + "\r\n                    Clear_XSCRIPT()\r\n\t\t\t        Set_XSCRIPT_Function_Name('AskGetReward')\r\n                    Set_XSCRIPT_ScriptID(998633)\r\n                    Set_XSCRIPT_Parameter(0, " + i.ToString() + ")\r\n                    Set_XSCRIPT_ParamCount(1)\r\n                    Send_XSCRIPT();\r\n                    ";
		}
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000167EB File Offset: 0x000149EB
	private void method_51(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_117));
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000F6C10 File Offset: 0x000F4E10
	private void method_52(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_118)))
		{
			@class.method_180();
		}
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00016816 File Offset: 0x00014A16
	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Class534.smethod_3(base.Handle);
		}
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000F6C80 File Offset: 0x000F4E80
	private void method_53(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		this.checkNM.Text = this.numberNM.Int32_1.ToString() + "% Buff";
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_135));
		}
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x000F6CDC File Offset: 0x000F4EDC
	private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class226.Boolean_144 = (base.TopMost = (this.onTopToolStripMenuItem.Checked = !this.onTopToolStripMenuItem.Checked));
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x000F6D14 File Offset: 0x000F4F14
	private void open96ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int num = (sender as ToolStripMenuItem).Text.smethod_26();
		for (int i = 0; i < num; i++)
		{
			this.method_9(Class226.String_4);
		}
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000F6D4C File Offset: 0x000F4F4C
	private void method_54()
	{
		Class226.Boolean_143 = !Class226.Boolean_143;
		if (Class226.Boolean_143)
		{
			this.notifyIcon_0.Icon = (base.Icon = Class616.Icon_1);
			return;
		}
		this.notifyIcon_0.Icon = (base.Icon = Class616.Icon_0);
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x000F6DA0 File Offset: 0x000F4FA0
	private void menuPkMode_Click(object sender, EventArgs e)
	{
		Class226.Boolean_106 = (this.menuPkMode.Checked = !this.menuPkMode.Checked);
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000F6DD0 File Offset: 0x000F4FD0
	private void menuQuanLyNhom_Click(object sender, EventArgs e)
	{
		this.tabMain.SelectedIndex = 5;
		foreach (object obj in GUI.univer_0.treeView1.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			if (treeNode.Tag == "Team")
			{
				GUI.univer_0.treeView1.SelectedNode = treeNode;
			}
		}
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x00016830 File Offset: 0x00014A30
	private void quitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.stopwatch_1 = Stopwatch.StartNew();
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_119));
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x00016866 File Offset: 0x00014A66
	private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_120));
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000F6E58 File Offset: 0x000F5058
	private void muLenGia_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class456 @class = new GUI.Class456();
				@class.class106_0 = enumerator.Current;
				if (@class.class106_0.Class527_0.Int32_34 == 10)
				{
					Task.Run(new Action(@class.method_0));
				}
			}
		}
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x00016891 File Offset: 0x00014A91
	private void muSapXepTayNai_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_121));
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x000168BC File Offset: 0x00014ABC
	private void selectCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.LvGame.smethod_21();
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x0000500B File Offset: 0x0000320B
	private void menuSelectPath_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x000168C9 File Offset: 0x00014AC9
	private void selectServerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_122));
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000F6ED0 File Offset: 0x000F50D0
	private void method_55()
	{
		GUI.bool_0 = true;
		try
		{
			this.LvGame.Columns[9].Text = string.Format("{0:0.00}M", Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_123)).Select<Class106, double>(new Func<Class106, double>(GUI.Class403.f_A642BF9F.method_124)).Sum() / 1000000.0);
			this.LvGame.Columns[0].Text = "[" + Class106.List_3.Count.ToString() + "]";
			Class106 @class = Class106.Class106_0;
			if (Class226.Boolean_61)
			{
				this.checkRadius.Text = string.Concat(new string[]
				{
					"Radius [",
					@class.Single_1.ToString(),
					",",
					@class.Single_2.ToString(),
					"]"
				});
			}
			else
			{
				this.checkRadius.Text = string.Concat(new string[]
				{
					"Bán Kính [",
					@class.Single_1.ToString(),
					",",
					@class.Single_2.ToString(),
					"]"
				});
			}
			if (@class == null)
			{
				@class = Class106.List_3.FirstOrDefault<Class106>();
				if (@class != null)
				{
					@class.ListViewItem_0.Selected = true;
				}
			}
			else
			{
				this.tabGame.Text = @class.Class527_0.String_11;
				this.lvFunction.Columns[0].Text = "[" + Class527.smethod_2(@class.Int32_40).Replace(" ", "") + "]";
				if (string.IsNullOrEmpty(@class.String_28))
				{
					this.lvSkill.Columns[0].Text = "[None]";
				}
				else
				{
					this.lvSkill.Columns[0].Text = "[" + @class.String_28 + "]";
				}
			}
		}
		catch
		{
		}
		GUI.bool_0 = false;
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000168F4 File Offset: 0x00014AF4
	private void setDoneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_125));
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x000F7144 File Offset: 0x000F5344
	private void method_56()
	{
		GUI.Class457 @class = new GUI.Class457();
		@class.gui_0 = this;
		@class.dictionary_0 = new Dictionary<int, Class525>();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
		base.Invoke(new Action(@class.method_1));
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x0001691F File Offset: 0x00014B1F
	private void method_57(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_130));
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000F7194 File Offset: 0x000F5394
	private void trangBij23ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GUI.Class459 @class = new GUI.Class459();
		@class.int_0 = (sender as ToolStripMenuItem).Tag.ToString().smethod_26();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x000F71D8 File Offset: 0x000F53D8
	private void menuCreateTeam_Click(object sender, EventArgs e)
	{
		using (IEnumerator<IEnumerable<Class106>> enumerator = Class106.IEnumerable_3.ToArray<Class106>().smethod_25<Class106>(6).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class460 @class = new GUI.Class460();
				@class.ienumerable_0 = enumerator.Current;
				Task.Run(new Action(@class.method_0));
			}
		}
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x0001694A File Offset: 0x00014B4A
	private void method_58(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_133));
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x00016975 File Offset: 0x00014B75
	private void method_59(object sender, EventArgs e)
	{
		new Thread(new ThreadStart(GUI.Class403.f_A642BF9F.method_134)).Start();
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x000169A0 File Offset: 0x00014BA0
	private void textBoxEx2_TextChanged(object sender, EventArgs e)
	{
		this.lvInbox.Search(this.textBoxEx2.Text);
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000169B8 File Offset: 0x00014BB8
	private void method_60(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_136));
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000169E3 File Offset: 0x00014BE3
	private void menuThaoTrangBi_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_137));
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000F7244 File Offset: 0x000F5444
	private void method_61(object sender, EventArgs e)
	{
		GUI.Class464 @class = new GUI.Class464();
		@class.string_0 = (sender as ToolStripMenuItem).Tag.ToString();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x000F7284 File Offset: 0x000F5484
	private void toolStripMenuItem_28_Click(object sender, EventArgs e)
	{
		GUI.Class466 @class = new GUI.Class466();
		@class.object_0 = sender;
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x000F72B4 File Offset: 0x000F54B4
	private void toolStripMenuItem40_Click(object sender, EventArgs e)
	{
		GUI.Class467 @class = new GUI.Class467();
		@class.int_0 = (sender as ToolStripMenuItem).Tag.ToString().smethod_26();
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x00016A0E File Offset: 0x00014C0E
	private void muThuPet_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_139));
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000F72F8 File Offset: 0x000F54F8
	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			this.method_10();
		}
		catch
		{
		}
		this.method_5();
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000F7328 File Offset: 0x000F5528
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (this.tabMain.SelectedIndex == 0)
		{
			try
			{
				this.LvGame.BeginUpdate();
				try
				{
					foreach (Class106 @class in Class106.List_4)
					{
						@class.Class527_0.method_5();
					}
				}
				catch
				{
				}
				this.LvGame.EndUpdate();
			}
			catch
			{
			}
		}
		if (!Class531.smethod_28(Enum18.VK_CONTROL))
		{
			Class106.stopwatch_3 = Stopwatch.StartNew();
		}
		try
		{
			if (Class0.Stopwatch_25 != null || Class0.Stopwatch_24 != null)
			{
				string text = "";
				if (Class0.Stopwatch_25 != null)
				{
					int num = (int)((double)Class106.Int32_74 / Class0.Stopwatch_25.Elapsed.TotalHours);
					text = string.Concat(new string[]
					{
						text,
						"(",
						num.smethod_6(),
						" BTĐ/H - ",
						Class106.Int32_74.smethod_6(),
						" Total)"
					});
				}
				if (Class0.Stopwatch_24 != null)
				{
					int num2 = (int)((double)Class106.int_5 / Class0.Stopwatch_24.Elapsed.TotalHours);
					if (!string.IsNullOrEmpty(text))
					{
						text += " ";
					}
					text = string.Concat(new string[]
					{
						text,
						"(Open: ",
						num2.smethod_6(),
						" BTĐ/H - ",
						Class106.int_5.smethod_6(),
						" Total)"
					});
				}
				this.txtMainSearch.String_0 = text;
			}
			this.Text = string.Concat(new string[]
			{
				"LAuto v2 ",
				Settings.Default.Version,
				" - ",
				(100 - this.Int32_0).ToString(),
				"% Mem + ",
				this.Int32_1.ToString(),
				"% CPU [",
				GUI.String_0,
				"]"
			});
			if (GUI.double_0 > 0.0)
			{
				this.Text += " - Pro";
			}
			else
			{
				this.Text += " - Free";
			}
		}
		catch
		{
		}
		this.method_55();
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x00016A39 File Offset: 0x00014C39
	private void method_62(Class106 class106_0)
	{
		GUI.Class468 @class = new GUI.Class468();
		@class.class106_0 = class106_0;
		Task.Run(new Action(@class.method_0));
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x00016A58 File Offset: 0x00014C58
	private void method_63()
	{
		Task.Run(new Action(GUI.Class403.f_A642BF9F.method_140));
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000F75CC File Offset: 0x000F57CC
	private void menuNhanNham_Click(object sender, EventArgs e)
	{
		GUI.Class469 @class = new GUI.Class469();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(GUI.Class403.f_A642BF9F.method_141));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x00016A7F File Offset: 0x00014C7F
	private void menuTuTaoNhom_Click(object sender, EventArgs e)
	{
		Class226.Boolean_20 = !Class226.Boolean_20;
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x00016A8E File Offset: 0x00014C8E
	private void txtChatContent_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.button17_Click(null, null);
		}
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x00016AA2 File Offset: 0x00014CA2
	private void txtMainSearch_TextChanged(object sender, EventArgs e)
	{
		base.Invoke(new Action(this.method_136));
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000F763C File Offset: 0x000F583C
	private void txtPass2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Class106.Class106_0.String_10 = this.txtPass2.Text;
			Class106.Class106_0.List_17.ForEach(new Action<Class400>(this.method_137));
			Class106.Class106_0.method_477();
		}
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x00016AB7 File Offset: 0x00014CB7
	private void txtRao_TextChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.Class106_0.String_11 = this.txtRao.Text;
		}
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x00016AD5 File Offset: 0x00014CD5
	private void txtSearchName_TextChanged(object sender, EventArgs e)
	{
		this.lvSkill.Search(this.txtSearchName.Text);
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000F7690 File Offset: 0x000F5890
	private void toolStripMenuItem_36_Click(object sender, EventArgs e)
	{
		GUI.Class471 @class = new GUI.Class471();
		if (GUI.GUI_0.String_2 == "" || GUI.GUI_0.String_2 == "" || GUI.GUI_0.String_2 == "0813673640" || GUI.GUI_0.String_2 == "tieudattai@yahoo.com")
		{
			try
			{
				Class106 class2 = Class106.List_3.FirstOrDefault<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_142));
				if (class2 != null)
				{
					int num = class2.Class515_0.method_7(new long[] { class2.Int64_0 + 1350728L });
					byte[] bytes = BitConverter.GetBytes(num);
					if (num != 0)
					{
						byte[] array = Class616.Byte_0;
						for (int i = 0; i < 4; i++)
						{
							array[1350728 + i] = bytes[i];
						}
						File.WriteAllBytes("GameFix.exe", array);
					}
				}
			}
			catch
			{
			}
		}
		@class.openFileDialog_0 = new OpenFileDialog();
		@class.openFileDialog_0.Filter = "*.exe | *.exe";
		if (@class.openFileDialog_0.ShowDialog(this) == DialogResult.OK)
		{
			Task.Run(new Action(@class.method_0));
		}
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000F77DC File Offset: 0x000F59DC
	private static ValueTuple<int, int> smethod_15(int int_6)
	{
		int num = (int)Math.Ceiling(Math.Sqrt((double)int_6));
		int num2 = (int)Math.Ceiling((double)int_6 / (double)num);
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x000F780C File Offset: 0x000F5A0C
	private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GUI.Class472 @class = new GUI.Class472();
		string text = (sender as ToolStripMenuItem).Text;
		ValueTuple<int, int> valueTuple = GUI.smethod_15(Class106.IEnumerable_1.Count<Class106>());
		int item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		@class.int_1 = item;
		int num = item2;
		if (text.Length == 3)
		{
			@class.int_1 = text[0].ToString().smethod_26();
			num = text[2].ToString().smethod_26();
		}
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		@class.int_2 = (int)((double)width / (double)@class.int_1);
		@class.int_3 = (int)((double)height / (double)num);
		@class.list_0 = Class106.IEnumerable_1.ToList<Class106>();
		@class.int_0 = 0;
		Task.Run(new Action(@class.method_0));
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x00016AED File Offset: 0x00014CED
	private void muXuatPet_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_143));
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000F78FC File Offset: 0x000F5AFC
	private void menuXuongGia_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class473 @class = new GUI.Class473();
				@class.class106_0 = enumerator.Current;
				new Thread(new ThreadStart(@class.method_0)).Start();
			}
		}
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x00016B18 File Offset: 0x00014D18
	private void muXuongNgua_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_144));
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x00016B43 File Offset: 0x00014D43
	private void mXuongNgua_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_145));
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000F7964 File Offset: 0x000F5B64
	private void menuTrieuTapTheo_DropDownOpening(object sender, EventArgs e)
	{
		this.menuTrieuTapTheo.DropDownItems.Clear();
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class474 @class = new GUI.Class474();
				@class.class106_0 = enumerator.Current;
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(string.Concat(new string[]
				{
					@class.class106_0.Class527_0.String_11,
					" -> ",
					@class.class106_0.Class527_0.String_12,
					" [",
					@class.class106_0.Int32_16.ToString(),
					",",
					@class.class106_0.Int32_17.ToString(),
					"]"
				}));
				toolStripMenuItem.Click += @class.method_0;
				list.Add(toolStripMenuItem);
			}
		}
		ToolStripItemCollection dropDownItems = this.menuTrieuTapTheo.DropDownItems;
		ToolStripItem[] array = list.ToArray();
		dropDownItems.AddRange(array);
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x00016B6E File Offset: 0x00014D6E
	private void txtSearchFuntion_TextChanged(object sender, EventArgs e)
	{
		this.lvFunction.Search(this.txtSearchFuntion.Text);
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000165BF File Offset: 0x000147BF
	private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.method_54();
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x00016B86 File Offset: 0x00014D86
	private void method_64(object sender, EventArgs e)
	{
		this.toolStripMenuItem_36_Click(sender, e);
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000F7A8C File Offset: 0x000F5C8C
	private void method_65(object sender, EventArgs e)
	{
		GUI.Class475 @class = new GUI.Class475();
		if (GUI.bool_0)
		{
			return;
		}
		@class.int_0 = ((GUI.Class402)this.cboPet.Object_0).Int32_0;
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x00016B90 File Offset: 0x00014D90
	private void method_66(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(this.method_138));
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x00016BB0 File Offset: 0x00014DB0
	private void menuPickNear_Click(object sender, EventArgs e)
	{
		Class226.Boolean_146 = !Class226.Boolean_146;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x0000500B File Offset: 0x0000320B
	private void englishToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x00016BBF File Offset: 0x00014DBF
	private void updateIAutoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		// LAuto: self-update is disabled; updating would replace this build with the official release
		MessageBox.Show(this, "Chức năng cập nhật đã bị tắt trong LAuto.", "LAuto", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000F7AD8 File Offset: 0x000F5CD8
	private void goToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
		Class106 class106_ = Class106.Class106_0;
		foreach (ToolStripMenuItem toolStripMenuItem in this.method_0(this.goToolStripMenuItem))
		{
			if (class106_ == null)
			{
				toolStripMenuItem.Font = new Font(toolStripMenuItem.Font, FontStyle.Regular);
			}
			else if (toolStripMenuItem.Tag != null && class106_.String_23 == toolStripMenuItem.Tag.ToString())
			{
				this.method_67(toolStripMenuItem);
			}
			else
			{
				toolStripMenuItem.Font = new Font(toolStripMenuItem.Font, FontStyle.Regular);
			}
		}
		this.goToolStripMenuItem.Font = new Font(this.goToolStripMenuItem.Font, FontStyle.Regular);
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x00016BD4 File Offset: 0x00014DD4
	private void method_67(ToolStripMenuItem toolStripMenuItem_80)
	{
		if (toolStripMenuItem_80 == null)
		{
			return;
		}
		toolStripMenuItem_80.Font = new Font(toolStripMenuItem_80.Font, FontStyle.Bold);
		this.method_67(toolStripMenuItem_80.OwnerItem as ToolStripMenuItem);
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000F7BA0 File Offset: 0x000F5DA0
	private void resetSpeedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class0.Stopwatch_25 = (Class0.Stopwatch_24 = null);
		int num = 0;
		Class106.int_5 = 0;
		Class106.Int32_74 = num;
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_146));
		TabLogin.List_0.ForEach(new Action<TabLogin>(GUI.Class403.f_A642BF9F.method_147));
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000F7C18 File Offset: 0x000F5E18
	private void method_68(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			if (this.checkRadius.Boolean_0)
			{
				@class.Single_1 = (float)@class.Int32_16;
				@class.Single_2 = (float)@class.Int32_17;
			}
			else
			{
				Class106 class2 = @class;
				Class106 class3 = @class;
				float num = 0f;
				float num2 = 0f;
				class3.Single_2 = num;
				class2.Single_1 = num2;
			}
		}
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000F7CA8 File Offset: 0x000F5EA8
	private void method_69(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		Class106 class106_ = Class106.Class106_0;
		if (class106_ != null)
		{
			if (class106_.Class527_0.Boolean_18)
			{
				Class226.Int32_30 = (int)this.checkRadius.Decimal_0;
				return;
			}
			Class226.Int32_29 = (int)this.checkRadius.Decimal_0;
		}
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000F7D00 File Offset: 0x000F5F00
	private void cboTrongTrot_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			@class.int_42 = this.cboTrongTrot.SelectedIndex;
		}
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000F7D60 File Offset: 0x000F5F60
	private void checkTrongTrot_CheckedChanged(object sender, EventArgs e)
	{
		if (GUI.bool_0)
		{
			return;
		}
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			@class.method_97(Enum17.TrongTrot, this.checkTrongTrot.Checked);
		}
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x00016BFD File Offset: 0x00014DFD
	private void button3_Click(object sender, EventArgs e)
	{
		MessBox.smethod_0("Auto đang chạy độc lập hoàn toàn, không cần đổi mật khẩu máy chủ.");
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x000F7DC0 File Offset: 0x000F5FC0
	private void menuThemToaDo_Click(object sender, EventArgs e)
	{
		Class106 class106_ = Class106.Class106_0;
		if (class106_ != null)
		{
			string text = string.Concat(new string[]
			{
				class106_.Class527_0.String_12,
				" [",
				class106_.Int32_16.ToString(),
				",",
				class106_.Int32_17.ToString(),
				"]"
			});
			string text2 = File.ReadAllText("iAuto.Go.json");
			if (!text2.Contains(string.Format(",\r\n    \"{0}\":\"{1},{2},{3}\"", new object[]
			{
				text,
				class106_.Int32_16,
				class106_.Int32_17,
				class106_.Class527_0.Int32_35
			})))
			{
				int num = text2.LastIndexOf("\r\n  }\r\n}");
				if (num == -1)
				{
					num = text2.LastIndexOf("\n  }\n}");
				}
				if (num != -1)
				{
					text2 = text2.Insert(num, string.Format(",\r\n    \"{0}\":\"{1},{2},{3}\"", new object[]
					{
						text,
						class106_.Int32_16,
						class106_.Int32_17,
						class106_.Class527_0.Int32_35
					}));
					File.WriteAllText("iAuto.Go.json", text2);
					this.method_19(this.goToolStripMenuItem, File.ReadAllText("iAuto.Go.json"));
				}
			}
		}
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x00016C11 File Offset: 0x00014E11
	private void method_70(object sender, EventArgs e)
	{
		MessBox messBox = MessBox.smethod_0("+30 Days TLBB Origin\r\nPrice 149.000 Chip\r\nAre You Sure?");
		messBox.EventHandler_0 = (EventHandler)Delegate.Combine(messBox.EventHandler_0, new EventHandler(this.method_140));
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x00016C3E File Offset: 0x00014E3E
	private void method_71(object sender, EventArgs e)
	{
		MessBox messBox = MessBox.smethod_0("+30 Days TLBB Private\r\nPrice 149.000 Chip\r\nAre You Sure?");
		messBox.EventHandler_0 = (EventHandler)Delegate.Combine(messBox.EventHandler_0, new EventHandler(this.method_141));
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x00016C6B File Offset: 0x00014E6B
	private void button12_Click(object sender, EventArgs e)
	{
		try
		{
			Class226.smethod_0();
			MessBox.smethod_0("Đã lưu toàn bộ cấu hình vào -iAuto.ini thành công!");
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.Message);
		}
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000F7F18 File Offset: 0x000F6118
	private void LvGame_ColumnReordered(object sender, ColumnReorderedEventArgs e)
	{
		foreach (object obj in this.LvGame.Columns)
		{
			ColumnHeader columnHeader = (ColumnHeader)obj;
			Class106.Class210_0["LvGame", columnHeader.Index.ToString()] = columnHeader.DisplayIndex.ToString();
		}
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x00016C98 File Offset: 0x00014E98
	private void checkSkill_CheckedChanged(object sender, EventArgs e)
	{
		this.method_26(sender, e);
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x00016CA2 File Offset: 0x00014EA2
	private void menuThemPhu_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_148));
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000F7F9C File Offset: 0x000F619C
	private void toolStripMenuItem20_Click(object sender, EventArgs e)
	{
		GUI.Class476 @class = new GUI.Class476();
		@class.int_0 = (sender as ToolStripMenuItem).Text.smethod_26();
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x00016CCD File Offset: 0x00014ECD
	private void method_72(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_149));
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x00016CF8 File Offset: 0x00014EF8
	private void menuThaoDeo_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_150));
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x00016D23 File Offset: 0x00014F23
	private void method_73(object sender, EventArgs e)
	{
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_151));
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x00016D4E File Offset: 0x00014F4E
	private void toolStripMenuItem_34_Click(object sender, EventArgs e)
	{
		Task.Run(new Action(GUI.Class403.f_A642BF9F.method_152));
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_74(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000F7FDC File Offset: 0x000F61DC
	private void cboDaTaoDo_DropDown(object sender, EventArgs e)
	{
		this.cboDaTaoDo.Items.Clear();
		Class106 class106_ = Class106.Class106_0;
		if (class106_ == null)
		{
			return;
		}
		foreach (Class516 @class in class106_.Class214_0.IEnumerable_0.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_154)).smethod_9<Class516, string>(new Func<Class516, string>(GUI.Class403.f_A642BF9F.method_155)))
		{
			this.cboDaTaoDo.Items.Add(@class.String_1);
		}
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x00016D75 File Offset: 0x00014F75
	private void cboDaTaoDo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_143));
		}
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000F80A4 File Offset: 0x000F62A4
	private void menuOpenGame_DropDownOpening(object sender, EventArgs e)
	{
		this.menuSelectPath.DropDownItems.Clear();
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("Open");
		toolStripMenuItem.Click += this.method_144;
		this.menuSelectPath.DropDownItems.Add(toolStripMenuItem);
		using (List<string>.Enumerator enumerator = Class226.List_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class480 @class = new GUI.Class480();
				@class.string_0 = enumerator.Current;
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(@class.string_0);
				if (@class.string_0 == Class226.String_4)
				{
					toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Bold);
				}
				toolStripMenuItem2.Click += @class.method_0;
				this.menuSelectPath.DropDownItems.Add(toolStripMenuItem2);
			}
		}
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x0000500B File Offset: 0x0000320B
	private void muTrungAc_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000F8190 File Offset: 0x000F6390
	private void menuStopTrader_Click(object sender, EventArgs e)
	{
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(GUI.Class403.f_A642BF9F.method_156));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_157));
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000F8200 File Offset: 0x000F6400
	private void menuQuayVe_Click(object sender, EventArgs e)
	{
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(GUI.Class403.f_A642BF9F.method_158));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_159));
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000F8270 File Offset: 0x000F6470
	private void menuDiToi_Click(object sender, EventArgs e)
	{
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(GUI.Class403.f_A642BF9F.method_160));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_161));
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x0000500B File Offset: 0x0000320B
	private void menuChayThuongNhan_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x0000500B File Offset: 0x0000320B
	private void muQuayVeDaiLy_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x0000500B File Offset: 0x0000320B
	private void muTuyetGiao_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x0000500B File Offset: 0x0000320B
	private void muLayDo_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x00016D94 File Offset: 0x00014F94
	private void lblTrader_Click(object sender, EventArgs e)
	{
		if (!GUI.bool_0)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_145));
		}
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000F82E0 File Offset: 0x000F64E0
	private void saveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "PNG Image|*.png",
			Title = "Save Qr",
			FileName = "iAutoQR.png"
		};
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			this.picQr.Image.Save(saveFileDialog.FileName);
		}
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000F8334 File Offset: 0x000F6534
	private void menuKinhHo_Click(object sender, EventArgs e)
	{
		GUI.Class481 @class = new GUI.Class481();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		@class.int_0 = @class.toolStripMenuItem_0.Tag.ToString().smethod_26();
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x060021D8 RID: 8664
	[DllImport("user32.dll")]
	private static extern bool IsZoomed(IntPtr intptr_1);

	// Token: 0x060021D9 RID: 8665 RVA: 0x00016DB3 File Offset: 0x00014FB3
	private void centerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Task.Run(new Action(GUI.Class403.f_A642BF9F.method_163));
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x000F8384 File Offset: 0x000F6584
	private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		Class226.Boolean_61 = !Class226.Boolean_61;
		if (Class226.Boolean_61)
		{
			GUI.univer_0.method_16();
			GUI.setting_0.method_1();
			this.method_6();
			TabLogin.List_0.ForEach(new Action<TabLogin>(GUI.Class403.f_A642BF9F.method_164));
			return;
		}
		GUI.univer_0.method_17();
		GUI.setting_0.method_2();
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000F8400 File Offset: 0x000F6600
	private void toolStripMenuItem_38_Click(object sender, EventArgs e)
	{
		Class226.Boolean_61 = !Class226.Boolean_61;
		if (Class226.Boolean_61)
		{
			GUI.univer_0.method_16();
			GUI.setting_0.method_1();
			this.method_6();
			TabLogin.List_0.ForEach(new Action<TabLogin>(GUI.Class403.f_A642BF9F.method_165));
			return;
		}
		GUI.univer_0.method_17();
		GUI.setting_0.method_2();
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x00016DDA File Offset: 0x00014FDA
	private void englishToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
		this.englishToolStripMenuItem1.Checked = Class226.Boolean_61;
		this.toolStripMenuItem_38.Checked = !Class226.Boolean_61;
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000F847C File Offset: 0x000F667C
	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_10();
			Class238.smethod_2();
			this.String_2 = (this.String_3 = (Class226.String_0 = string.Empty));
			Class106.List_3.Clear();
			Class106.List_4.Clear();
			this.LvGame.VirtualListSize = 0;
			this.method_8();
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000F84F4 File Offset: 0x000F66F4
	private void toolStripMenuItem_35_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_0.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_166)))
		{
			@class.method_180();
		}
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_75(object sender, EventArgs e)
	{
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000F8564 File Offset: 0x000F6764
	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		GUI.Class482 @class = new GUI.Class482();
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_1));
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x00016DFF File Offset: 0x00014FFF
	private void btnAddPoint_Click(object sender, EventArgs e)
	{
		new Thread(new ThreadStart(this.method_146)).Start();
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x00016E17 File Offset: 0x00015017
	private void button2_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_167));
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x00016E42 File Offset: 0x00015042
	private void button4_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_168));
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x00016E6D File Offset: 0x0001506D
	private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_169));
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x0000500B File Offset: 0x0000320B
	private void lvFunction_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x00016E98 File Offset: 0x00015098
	private void quitNRelogToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_170));
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000F85C0 File Offset: 0x000F67C0
	private void toolStripMenuItem_39_Click(object sender, EventArgs e)
	{
		foreach (Class106 @class in Class106.IEnumerable_1)
		{
			@class.method_375(string.Format("Clear_XSCRIPT( )\r\n\t\tSet_XSCRIPT_Function_Name( 'DoMoneyToJiaozi' )\r\n\r\n        Set_XSCRIPT_ScriptID(800119)\r\n\r\n        Set_XSCRIPT_Parameter(0,{0})\r\n\r\n        Set_XSCRIPT_ParamCount(1)\r\n\r\n    Send_XSCRIPT()", @class.Class527_0.Int32_19), false);
		}
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x00016EC3 File Offset: 0x000150C3
	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			MessBox.smethod_0("Đã dọn dẹp và tối ưu bộ nhớ RAM ứng dụng!");
		}
		catch
		{
		}
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000F8628 File Offset: 0x000F6828
	private void toolStripMenuItem_40_Click(object sender, EventArgs e)
	{
		using (IEnumerator<Class106> enumerator = Class106.IEnumerable_3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GUI.Class483 @class = new GUI.Class483();
				@class.class106_0 = enumerator.Current;
				if (@class.class106_0.Boolean_66)
				{
					@class.int_0 = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1, 1 };
					Task.Run(new Action(@class.method_0));
				}
			}
		}
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x0000500B File Offset: 0x0000320B
	private void muSuaTrangBi_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x0000500B File Offset: 0x0000320B
	private void cboPet_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000F86B0 File Offset: 0x000F68B0
	private void method_76(object sender, EventArgs e)
	{
		GUI.Class484 @class = new GUI.Class484();
		@class.class106_0 = Class106.Class106_0;
		if (@class.class106_0 == null)
		{
			MessageBox.Show("Vui lòng chọn 1 nhân vật trong danh sách trước!", "Thông báo");
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("=== DEBUG: " + @class.class106_0.Class527_0.String_11 + " ===");
		stringBuilder.AppendLine(string.Format("Tọa độ: ({0:F1}, {1:F1}) | Bản đồ: {2}", @class.class106_0.Single_5, @class.class106_0.Single_6, @class.class106_0.Class527_0.Int32_35));
		stringBuilder.AppendLine(string.Format("Base: {0:X} | Trạng thái: {1}", @class.class106_0.Class527_0.Int64_1, @class.class106_0.Class527_0.Int32_33));
		stringBuilder.AppendLine("------------------------------------------");
		stringBuilder.AppendLine("10 ĐỐI TƯỢNG GẦN NHẤT:");
		try
		{
			List<Class504> list = @class.class106_0.Class506_0.List_0.Where<Class504>(new Func<Class504, bool>(GUI.Class403.f_A642BF9F.method_171)).OrderBy<Class504, float>(new Func<Class504, float>(@class.method_0)).Take<Class504>(10)
				.ToList<Class504>();
			if (list.Count == 0)
			{
				stringBuilder.AppendLine(">> Không tìm thấy đối tượng nào!");
			}
			else
			{
				foreach (Class504 class2 in list)
				{
					double num = (double)class2.method_3(@class.class106_0.Single_5, @class.class106_0.Single_6);
					string text = "NPC/Quái";
					if (class2.Boolean_5)
					{
						text = "Người";
					}
					else if (class2.Boolean_4)
					{
						text = "Trân thú";
					}
					stringBuilder.AppendLine(string.Format("[{0}] {1}", text, class2.String_9));
					stringBuilder.AppendLine(string.Format("   + ID: {0} (Hex: {0:X})", class2.Int32_4));
					stringBuilder.AppendLine(string.Format("   + Tọa độ: ({0:F1}, {1:F1}) | Cách: {2:F1}m", class2.Single_4, class2.Single_5, num));
				}
			}
			MessageBox.Show(stringBuilder.ToString(), "Bản tin Debug Nearby");
		}
		catch (Exception ex)
		{
			MessageBox.Show("Lỗi trong quá trình quét: " + ex.Message);
		}
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000F895C File Offset: 0x000F6B5C
	private void method_77(object sender, EventArgs e)
	{
		GUI.Class485 @class = new GUI.Class485();
		@class.class106_0 = Class106.Class106_0;
		if (@class.class106_0 == null)
		{
			MessageBox.Show("Vui lòng chọn 1 nhân vật trong danh sách trước!", "Thông báo");
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("=== DEBUG: " + @class.class106_0.Class527_0.String_11 + " ===");
		stringBuilder.AppendLine(string.Format("Tọa độ: ({0:F1}, {1:F1}) | Bản đồ: {2}", @class.class106_0.Single_5, @class.class106_0.Single_6, @class.class106_0.Class527_0.Int32_35));
		stringBuilder.AppendLine(string.Format("Base: {0:X} | Trạng thái: {1}", @class.class106_0.Class527_0.Int64_1, @class.class106_0.Class527_0.Int32_33));
		stringBuilder.AppendLine("------------------------------------------");
		stringBuilder.AppendLine("10 ĐỐI TƯỢNG GẦN NHẤT:");
		try
		{
			List<Class504> list = @class.class106_0.Class506_0.List_0.Where<Class504>(new Func<Class504, bool>(GUI.Class403.f_A642BF9F.method_172)).OrderBy<Class504, float>(new Func<Class504, float>(@class.method_0)).Take<Class504>(10)
				.ToList<Class504>();
			if (list.Count == 0)
			{
				stringBuilder.AppendLine(">> Không tìm thấy đối tượng nào!");
			}
			else
			{
				foreach (Class504 class2 in list)
				{
					double num = (double)class2.method_3(@class.class106_0.Single_5, @class.class106_0.Single_6);
					string text = "NPC/Quái";
					if (class2.Boolean_5)
					{
						text = "Người";
					}
					else if (class2.Boolean_4)
					{
						text = "Trân thú";
					}
					stringBuilder.AppendLine(string.Format("[{0}] {1}", text, class2.String_9));
					stringBuilder.AppendLine(string.Format("   + ID: {0} (Hex: {0:X})", class2.Int32_4));
					stringBuilder.AppendLine(string.Format("   + Tọa độ: ({0:F1}, {1:F1}) | Cách: {2:F1}m", class2.Single_4, class2.Single_5, num));
				}
			}
			MessageBox.Show(stringBuilder.ToString(), "Bản tin Debug Nearby");
		}
		catch (Exception ex)
		{
			MessageBox.Show("Lỗi trong quá trình quét: " + ex.Message);
		}
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x0000500B File Offset: 0x0000320B
	private void method_78(object sender, EventArgs e)
	{
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000F8C08 File Offset: 0x000F6E08
	private void toolStripMenuItem_46_Click(object sender, EventArgs e)
	{
		List<Class106> list = Class106.IEnumerable_1.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_173)).ToList<Class106>();
		foreach (Class106 @class in Class106.IEnumerable_1.Where<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_174)))
		{
			if (@class.List_21.Count < 6)
			{
				for (int i = 0; i < 6 - @class.List_21.Count; i++)
				{
					if (list.Any<Class106>())
					{
						list[0].method_371(@class.Class527_0.String_11);
						list.RemoveAt(0);
					}
				}
				@class.method_425(true);
			}
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x00016ED0 File Offset: 0x000150D0
	private void toolStripMenuItem_47_Click(object sender, EventArgs e)
	{
		Class226.Boolean_45 = !Class226.Boolean_45;
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00016EDF File Offset: 0x000150DF
	private void toolStripMenuItem_48_Click(object sender, EventArgs e)
	{
		Class226.Boolean_46 = !Class226.Boolean_46;
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x0000500B File Offset: 0x0000320B
	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x00016EEE File Offset: 0x000150EE
	private void toolStripMenuItem_58_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_175));
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x00016F19 File Offset: 0x00015119
	private void toolStripMenuItem_54_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_176));
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x00016F44 File Offset: 0x00015144
	private void toolStripMenuItem_55_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_177));
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x00016F6F File Offset: 0x0001516F
	private void toolStripMenuItem_57_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_178));
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x00016F9A File Offset: 0x0001519A
	private void toolStripMenuItem_56_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_179));
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000F8CF4 File Offset: 0x000F6EF4
	private void toolStripMenuItem_62_Click(object sender, EventArgs e)
	{
		GUI.Class487 @class = new GUI.Class487();
		ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
		@class.int_0 = toolStripMenuItem.Text.smethod_26();
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_0));
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x00016FC5 File Offset: 0x000151C5
	private void toolStripMenuItem_67_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_180));
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x0000500B File Offset: 0x0000320B
	private void muTrungLau_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x00016FF0 File Offset: 0x000151F0
	private void toolStripMenuItem_71_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_181));
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x0001701B File Offset: 0x0001521B
	private void toolStripMenuItem_72_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_183));
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x00017046 File Offset: 0x00015246
	private void button5_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("explorer.exe", Environment.CurrentDirectory);
		}
		catch (Exception ex)
		{
			MessBox.smethod_0("Không thể mở thư mục: " + ex.Message);
		}
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x0000500B File Offset: 0x0000320B
	private void muNier_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x00017073 File Offset: 0x00015273
	private void toolStripMenuItem_73_Click(object sender, EventArgs e)
	{
		Class226.Boolean_47 = !Class226.Boolean_47;
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x00017082 File Offset: 0x00015282
	private void toolStripMenuItem_75_Click(object sender, EventArgs e)
	{
		Class226.Boolean_3 = !Class226.Boolean_3;
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000F8D38 File Offset: 0x000F6F38
	private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GUI.Class489 @class = new GUI.Class489();
		@class.list_0 = new List<Class106>();
		foreach (Class106 class2 in Class106.IEnumerable_1)
		{
			@class.list_0.Add(class2);
			Class106.List_3.Remove(class2);
			Class106.Class210_0["GAMETYPEx", new DirectoryInfo(class2.String_22).Parent.Parent.FullName] = null;
		}
		Class106.List_4.RemoveAll(new Predicate<Class106>(@class.method_0));
		if (@class.list_0.Count > 0)
		{
			this.txtMainSearch_TextChanged(null, null);
		}
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x0000500B File Offset: 0x0000320B
	private void label1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x00017091 File Offset: 0x00015291
	private void method_79(object sender, EventArgs e)
	{
		Class226.Boolean_0 = this.checkHuyCraft.Boolean_0;
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000170A3 File Offset: 0x000152A3
	private void numHuyCraftStar_ValueChanged(object sender, EventArgs e)
	{
		Class226.Int32_0 = (int)this.numHuyCraftStar.Value;
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000170BA File Offset: 0x000152BA
	private void numHuyCraftLine_ValueChanged(object sender, EventArgs e)
	{
		Class226.Int32_1 = (int)this.numHuyCraftLine.Value;
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000170D1 File Offset: 0x000152D1
	private void toolStripMenuItem_79_Click(object sender, EventArgs e)
	{
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_184));
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x0001711B File Offset: 0x0001531B
	[CompilerGenerated]
	private void method_80(KeyValuePair<ToolStripMenuItem, Enum17[]> keyValuePair_0)
	{
		keyValuePair_0.Key.Click += this.method_81;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x0010BE5C File Offset: 0x0010A05C
	[CompilerGenerated]
	private void method_81(object sender, EventArgs e)
	{
		GUI.Class486 @class = new GUI.Class486();
		@class.gui_0 = this;
		@class.toolStripMenuItem_0 = sender as ToolStripMenuItem;
		if (this.tabMain.SelectedIndex == 1)
		{
			Class106.IEnumerable_2.smethod_22<Class400>(new Action<Class400>(@class.method_0));
			return;
		}
		Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(@class.method_1));
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x0010BEC0 File Offset: 0x0010A0C0
	[CompilerGenerated]
	private void method_82()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.method_97(Enum17.ChayThuongNhan, true);
			class106_.String_27 = "Back";
			class106_.method_493("Trader -> Back [Ctrl + Left]");
		}
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x0010BEFC File Offset: 0x0010A0FC
	[CompilerGenerated]
	private void method_83()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.method_97(Enum17.ChayThuongNhan, true);
			class106_.String_27 = "Go";
			class106_.method_493("Trader -> Go [Ctrl + Right]");
		}
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x0010BF38 File Offset: 0x0010A138
	[CompilerGenerated]
	private void method_84()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.method_99(new Enum17[] { Enum17.ChayThuongNhan });
			class106_.method_493("Trader -> Stop [Ctrl + Down]");
		}
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x00017135 File Offset: 0x00015335
	[CompilerGenerated]
	private void method_85()
	{
		Class106.List_3.ForEach(new Action<Class106>(this.method_86));
		Class238.smethod_3("Thổ Linh Châu");
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x00017157 File Offset: 0x00015357
	[CompilerGenerated]
	private void method_86(Class106 class106_0)
	{
		this.menuDinhViThoLinhChau_Click(null, null);
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x00017161 File Offset: 0x00015361
	[CompilerGenerated]
	private void method_87()
	{
		Class106.List_3.ForEach(new Action<Class106>(this.method_88));
		Class238.smethod_3("Thổ Linh Châu Đầu Tiên");
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x00017157 File Offset: 0x00015357
	[CompilerGenerated]
	private void method_88(Class106 class106_0)
	{
		this.menuDinhViThoLinhChau_Click(null, null);
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x00017183 File Offset: 0x00015383
	[CompilerGenerated]
	private void method_89()
	{
		this.muDiemDanh_Click(null, null);
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x0001718D File Offset: 0x0001538D
	[CompilerGenerated]
	private void method_90()
	{
		this.method_9(Class226.String_4);
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x0010BF70 File Offset: 0x0010A170
	[CompilerGenerated]
	private void method_91()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			if (class106_.Boolean_67)
			{
				class106_.method_375("PushEvent('TOGLE_BIGBANK'); PushEvent('UPDATE_BANK')", false);
				return;
			}
			class106_.method_375("PushEvent('TOGLE_BANK'); PushEvent('UPDATE_BANK')", false);
		}
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x0001719A File Offset: 0x0001539A
	[CompilerGenerated]
	private void method_92()
	{
		this.method_47(this.Class106_0);
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x0001719A File Offset: 0x0001539A
	[CompilerGenerated]
	private void method_93()
	{
		this.method_47(this.Class106_0);
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000171A8 File Offset: 0x000153A8
	[CompilerGenerated]
	private void method_94()
	{
		this.method_62(this.Class106_0);
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x00016639 File Offset: 0x00014839
	[CompilerGenerated]
	private void method_95()
	{
		this.method_63();
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x00016031 File Offset: 0x00014231
	[CompilerGenerated]
	private void method_96()
	{
		this.method_16(this.Class106_0);
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x0010BFA8 File Offset: 0x0010A1A8
	[CompilerGenerated]
	private void method_97()
	{
		this.checkSkill.Checked = (Class226.Boolean_148 = !Class226.Boolean_148);
		Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_19));
		if (this.checkSkill.Checked)
		{
			Class238.smethod_3("Bật Skill");
			return;
		}
		Class238.smethod_3("Tắt Skill");
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x0010C01C File Offset: 0x0010A21C
	[CompilerGenerated]
	private void method_98()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.method_493("Refresh [Ctrl + W]");
			if (class106_ != null)
			{
				class106_.method_126();
			}
		}
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000171B6 File Offset: 0x000153B6
	[CompilerGenerated]
	private void method_99()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ == null)
		{
			return;
		}
		class106_.Class512_0.method_9();
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000171CD File Offset: 0x000153CD
	[CompilerGenerated]
	private void method_100()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ == null)
		{
			return;
		}
		class106_.method_120();
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000171DF File Offset: 0x000153DF
	[CompilerGenerated]
	private void method_101()
	{
		this.pauseToolStripMenuItem_Click(null, null);
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x0010C048 File Offset: 0x0010A248
	[CompilerGenerated]
	private void method_102()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.ListViewItem_0.Checked = !class106_.ListViewItem_0.Checked;
			class106_.method_493("IsAuto: " + class106_.ListViewItem_0.Checked.ToString() + " [Insert]");
		}
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x0010C048 File Offset: 0x0010A248
	[CompilerGenerated]
	private void method_103()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.ListViewItem_0.Checked = !class106_.ListViewItem_0.Checked;
			class106_.method_493("IsAuto: " + class106_.ListViewItem_0.Checked.ToString() + " [Insert]");
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x0010C0A0 File Offset: 0x0010A2A0
	[CompilerGenerated]
	private void method_104()
	{
		Class106 class106_ = this.Class106_0;
		if (class106_ != null)
		{
			class106_.method_200();
			class106_.method_493("Identify Equipment [Ctrl + /]");
		}
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x0010C0C8 File Offset: 0x0010A2C8
	[CompilerGenerated]
	private void method_105()
	{
		try
		{
			GUI.Class493 @class = new GUI.Class493();
			@class.gui_0 = this;
			int num = 0;
			if (Class106.List_3.Any<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_29)))
			{
				num++;
			}
			if (Class106.List_3.Any<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_30)))
			{
				num += 10;
			}
			if (Class106.List_3.Any<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_31)))
			{
				num += 100;
			}
			if (Class106.List_3.Any<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_32)))
			{
				num += 1000;
			}
			if (Class106.List_3.Any<Class106>(new Func<Class106, bool>(GUI.Class403.f_A642BF9F.method_33)))
			{
				num += 10000;
			}
			string text = Class531.smethod_10(6);
			string text2 = Class106.smethod_2(string.Concat(new string[]
			{
				"cmd=userinfoex&email=",
				HttpUtility.UrlEncode(this.String_2),
				"&pass=",
				HttpUtility.UrlEncode(this.String_3),
				"&version=",
				HttpUtility.UrlEncode(Settings.Default.Version),
				"&hwid=",
				GUI.string_1,
				"&ran=",
				text,
				"&isvng=",
				num.ToString(),
				"&gamecount=",
				Class106.List_3.Count.ToString(),
				"&ranex=",
				Class531.smethod_10(6)
			}), Settings.Default.PublicKey);
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			@class.string_0 = Class106.smethod_0(Settings.Default.HomePage + "?ranex=" + Class531.smethod_10(6), text2, null, false);
			@class.string_0 = Class261.smethod_1(@class.string_0, text);
			@class.string_0 = Class106.smethod_1(@class.string_0);
			GUI.GUI_0.Invoke(new Action(@class.method_0));
			GUI.int_0 = 0;
			this.btnRefresh.Enabled = true;
		}
		catch (Exception)
		{
			GUI.int_0++;
			if (GUI.int_0 >= 5)
			{
				GUI.double_0 = 0.0;
			}
		}
		finally
		{
			this.btnRefresh.Enabled = true;
		}
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x0010C38C File Offset: 0x0010A58C
	[CompilerGenerated]
	private void method_106()
	{
		for (;;)
		{
			try
			{
				GUI.Class494 @class = new GUI.Class494();
				@class.gui_0 = this;
				@class.byte_0 = new WebClient().DownloadData("https://img.vietqr.io/image/ICB-107006953692-print.png?accountName=NGUYEN%20DUY%20HAI&addInfo=" + this.string_2);
				base.Invoke(new Action(@class.method_0));
				break;
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x0010C3FC File Offset: 0x0010A5FC
	[CompilerGenerated]
	private void method_107()
	{
		TabPage tabPage = new TabPage("+");
		this.tabLogin.TabPages.Add(tabPage);
		LoginUser loginUser = new LoginUser
		{
			Dock = DockStyle.Fill
		};
		tabPage.Controls.Add(loginUser);
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x0010C440 File Offset: 0x0010A640
	[CompilerGenerated]
	private void method_108()
	{
		try
		{
			foreach (ValueTuple<string, string> valueTuple in Class106.Class210_0["Inbox"])
			{
				ListViewItem listViewItem = new ListViewItem(valueTuple.Item1);
				listViewItem.SubItems.AddRange(valueTuple.Item2.Split(new char[] { '\t' }).ToArray<string>());
				this.lvInbox.Items.Add(listViewItem);
			}
			this.checkSkill.Checked = Class226.Boolean_148;
			this.checkAutoShow.Checked = Class226.Boolean_150;
			base.TopMost = Class226.Boolean_144;
			this.method_19(this.goToolStripMenuItem, File.ReadAllText("iAuto.Go.json"));
			this.checkPanel.Checked = Class226.Boolean_149;
			this.cboLeader.Text = Class106.Class210_0["Settings", "LeaderEx"];
		}
		catch
		{
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000171E9 File Offset: 0x000153E9
	[CompilerGenerated]
	private void method_109()
	{
		if (string.IsNullOrEmpty(this.String_2))
		{
			this.String_2 = Class106.Class210_0["Settings", "User"];
			if (string.IsNullOrEmpty(this.String_2))
			{
				this.String_2 = "LAuto";
			}
		}
		this.tabMain.Visible = true;
		this.menuMain.Visible = true;
		this.tabMain.SelectedIndex = 0;
		this.method_111();
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000171F1 File Offset: 0x000153F1
	[CompilerGenerated]
	private void method_110(object sender, EventArgs e)
	{
		base.Invoke(new Action(this.method_111));
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x0010C558 File Offset: 0x0010A758
	[CompilerGenerated]
	private void method_111()
	{
		this.tabMain.Visible = true;
		this.menuMain.Visible = true;
		this.method_36();
		this.txtiAutoUser.Text = this.String_2;
		foreach (object obj in this.tabPay.Controls)
		{
			((Control)obj).Visible = true;
		}
		this.ApplyModernDarkCyberTheme();
		this.btnRefresh_Click(null, null);
		if (this.String_2 != "0364338933" && this.String_2 != "0972107747" && this.String_2 != "0917770732" && this.String_2 != "tieudattai@yahoo.com")
		{
			foreach (object obj2 in this.lvFunction.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj2;
				if (listViewItem.Tag == "muangoc")
				{
					listViewItem.Remove();
				}
			}
		}
		GUI.Boolean_3 = true;
		Class228.smethod_2();
		TabChat tabChat = this.tabChat_0;
		if (tabChat == null)
		{
			return;
		}
		tabChat.method_5();
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x0010C6AC File Offset: 0x0010A8AC
	[CompilerGenerated]
	private void method_112()
	{
		try
		{
			MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?email=",
				HttpUtility.UrlEncode(this.String_2),
				"&giftcode=",
				HttpUtility.UrlEncode(this.txtGiftCode.Text)
			})));
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x0010C72C File Offset: 0x0010A92C
	[CompilerGenerated]
	private void method_113()
	{
		try
		{
			this.btnRefresh.Enabled = false;
			this.method_5();
		}
		catch
		{
		}
		finally
		{
			base.Invoke(new Action(this.method_114));
		}
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x00017206 File Offset: 0x00015406
	[CompilerGenerated]
	private void method_114()
	{
		this.btnRefresh.Enabled = true;
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x0010C780 File Offset: 0x0010A980
	[CompilerGenerated]
	private void method_115()
	{
		try
		{
			MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?cmd=sendchip&pass=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_3),
				"&email=",
				HttpUtility.UrlEncode(this.String_2),
				"&toemail=",
				HttpUtility.UrlEncode(this.txtUserChip.Text),
				"&tobeli=",
				HttpUtility.UrlEncode(this.txtSendChip.Text)
			})));
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x00017214 File Offset: 0x00015414
	[CompilerGenerated]
	private bool method_116(Class516 class516_0)
	{
		return class516_0.String_1 == this.cboTrangBi.Text;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x0001722C File Offset: 0x0001542C
	[CompilerGenerated]
	private bool method_117(Class516 class516_0)
	{
		return class516_0.String_1 == this.cboGem.Text;
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x0010C838 File Offset: 0x0010AA38
	[CompilerGenerated]
	private void method_118()
	{
		try
		{
			MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?cmd=betchip&beli=",
				this.txtBetChip.Text,
				"&version=",
				HttpUtility.UrlEncode(Settings.Default.Version),
				"&email=",
				GUI.GUI_0.String_2,
				"&email=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_2),
				"&pass=",
				HttpUtility.UrlEncode(GUI.GUI_0.String_3),
				"&hwid=",
				GUI.string_1,
				"&count=",
				Class106.IEnumerable_0.Count<Class106>().ToString()
			})));
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x00017214 File Offset: 0x00015414
	[CompilerGenerated]
	private bool method_119(Class516 class516_0)
	{
		return class516_0.String_1 == this.cboTrangBi.Text;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x0010C934 File Offset: 0x0010AB34
	[CompilerGenerated]
	private void method_120(Class106 class106_0)
	{
		foreach (Class516 @class in class106_0.Class214_0.IEnumerable_0)
		{
			if (@class.String_1 == "Thông Thiên Phù Lục")
			{
				class106_0.method_375(string.Concat(new string[]
				{
					"Clear_XSCRIPT();\r\n\t\t\t                Set_XSCRIPT_Function_Name('SetUISelIdx');\r\n                            Set_XSCRIPT_ScriptID(330060);\r\n                            Set_XSCRIPT_Parameter(0, ",
					@class.Int32_11.ToString(),
					")\r\n                            Set_XSCRIPT_Parameter(1, ",
					(this.cboPhu.Text.smethod_26() - 1).ToString(),
					")\r\n                            Set_XSCRIPT_ParamCount(2);\r\n                            Send_XSCRIPT();\r\n                            PlayerPackage:UseItem(",
					@class.Int32_11.ToString(),
					")"
				}), false);
				break;
			}
		}
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x00017244 File Offset: 0x00015444
	[CompilerGenerated]
	private void method_121(Class106 class106_0)
	{
		class106_0.String_8 = this.cboMenpai.Text;
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x00017257 File Offset: 0x00015457
	[CompilerGenerated]
	private void method_122(Class106 class106_0)
	{
		class106_0.Boolean_57 = this.checkAutoPhu.Checked;
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x0001726A File Offset: 0x0001546A
	[CompilerGenerated]
	private void method_123(Class106 class106_0)
	{
		class106_0.bool_12 = this.checkCraft.Checked;
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x0001727D File Offset: 0x0001547D
	[CompilerGenerated]
	private void method_124(Class106 class106_0)
	{
		class106_0.int_13 = this.cboCheNoiNgoai.SelectedIndex;
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x0010CA08 File Offset: 0x0010AC08
	[CompilerGenerated]
	private void method_125()
	{
		this.method_31(this.muDuaDoChoTa, "vang");
		this.method_31(this.muDuaKNBCho, "knb");
		this.method_31(this.muDuaTangBaoDo, "tbd");
		this.method_33(this.toolStripMenuItem_49);
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x00017290 File Offset: 0x00015490
	[CompilerGenerated]
	private void method_126(Class106 class106_0)
	{
		class106_0.Class264_0.Boolean_29 = this.checkNM.Checked;
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000172A8 File Offset: 0x000154A8
	[CompilerGenerated]
	private void muVoDao_Click(object sender, EventArgs e)
	{
		this.method_2(1);
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000172B1 File Offset: 0x000154B1
	[CompilerGenerated]
	private void muVoDao1_Click(object sender, EventArgs e)
	{
		this.method_2(2);
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x0010CA54 File Offset: 0x0010AC54
	[CompilerGenerated]
	private void method_127()
	{
		Thread.CurrentThread.IsBackground = true;
		for (;;)
		{
			try
			{
				PerformanceCounter performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
				performanceCounter.NextValue();
				Thread.Sleep(1000);
				this.Int32_1 = (int)performanceCounter.NextValue();
				if (Class226.Boolean_124)
				{
					Class106.List_3.OrderByDescending<Class106, double>(new Func<Class106, double>(GUI.Class403.f_A642BF9F.method_74)).Take<Class106>(1).smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_75));
				}
			}
			catch
			{
			}
			Thread.Sleep(2000);
		}
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000172BA File Offset: 0x000154BA
	[CompilerGenerated]
	private void method_128()
	{
		Thread.CurrentThread.IsBackground = true;
		this.method_48();
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x0010CB20 File Offset: 0x0010AD20
	[CompilerGenerated]
	private void method_129()
	{
		for (;;)
		{
			try
			{
				if (!string.IsNullOrEmpty(this.String_2))
				{
					GUI.Class428 @class = new GUI.Class428();
					new HttpClient();
					@class.string_0 = Class106.smethod_17("https://tieudattai.org/s4.php?email=" + HttpUtility.UrlEncode(this.String_2), null, null, false).Item1;
					GUI.byte_0 = Enumerable.Range(0, 18).Select<int, byte>(new Func<int, byte>(@class.method_0)).ToArray<byte>();
					@class.string_1 = "14.255.255.244";
					@class.int_0 = 12121;
					@class.string_1 = @class.string_0.Split(new char[] { '\n' })[0].Split(new char[] { ':' })[0].Trim();
					int num = @class.string_0.Split(new char[] { '\n' })[0].Split(new char[] { ':' })[2].smethod_26();
					@class.int_0 = @class.string_0.Split(new char[] { '\n' })[0].Split(new char[] { ':' })[1].smethod_26();
					@class.tcpListener_0 = new TcpListener(IPAddress.Loopback, num);
					@class.tcpListener_0.Start();
					new Thread(new ThreadStart(@class.method_1)).Start();
					break;
				}
			}
			catch
			{
				break;
			}
			Thread.Sleep(1000);
		}
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000172CD File Offset: 0x000154CD
	[CompilerGenerated]
	private void method_130(object sender, ListViewEx.SubItemEventArgs e)
	{
		if (e.SubItem == 2)
		{
			GUI.GUI_0.lvSkill.StartEditing(this.textBox_0, e.Item, e.SubItem);
		}
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x0010CCB0 File Offset: 0x0010AEB0
	[CompilerGenerated]
	private void method_131()
	{
		for (;;)
		{
			try
			{
				if (!string.IsNullOrEmpty(this.String_2))
				{
					Class106.String_30 = (Class106.String_31 = string.Empty);
					if (Class106.String_30.Length != 32)
					{
						Class106.String_30 = Class106.smethod_16(32);
					}
					if (Class106.String_31.Length != 32)
					{
						Class106.String_31 = Class106.smethod_17(Settings.Default.HomePageEx, Class106.smethod_2(Class106.String_30, Settings.Default.PublicKeyEx), null, false).Item2.smethod_17("key=", ";").Trim();
						Thread.Sleep(1000);
					}
					Class226.String_0 = Class106.smethod_15(Class106.smethod_18(Class106.smethod_17(string.Concat(new string[]
					{
						Settings.Default.HomePageEx,
						"?email=",
						HttpUtility.UrlEncode(this.String_2),
						"&pass=",
						HttpUtility.UrlEncode(this.String_3),
						"&version=",
						Settings.Default.Version
					}), null, "key=" + Class106.String_31, false).Item1, Class106.String_30));
					Class106.String_30 = (Class106.String_31 = string.Empty);
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000172F9 File Offset: 0x000154F9
	[CompilerGenerated]
	private bool method_132(Process process_0)
	{
		return GUI.hashSet_0.Contains(process_0.ProcessName.ToLower()) && process_0.SessionId == this.int_1 && !process_0.HasExited;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x0001732B File Offset: 0x0001552B
	[CompilerGenerated]
	private void method_133(object sender, EventArgs e)
	{
		this.LvGame_SelectedIndexChanged(null, null);
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x0010CE20 File Offset: 0x0010B020
	[CompilerGenerated]
	private void method_134(Class106 class106_0)
	{
		if (class106_0.Class106_3 != null)
		{
			TabPage tabPage = new TabPage();
			tabPage.Dock = DockStyle.Fill;
			CanQuet canQuet = new CanQuet();
			canQuet.Class106_0 = (canQuet.class106_0 = class106_0.Class106_3);
			canQuet.Dock = DockStyle.Fill;
			tabPage.Controls.Add(canQuet);
			tabPage.Text = class106_0.Class106_3.Class527_0.String_11;
			this.tabBoottom.TabPages.Add(tabPage);
			return;
		}
		TabPage tabPage2 = new TabPage();
		tabPage2.Dock = DockStyle.Fill;
		CanQuet canQuet2 = new CanQuet();
		CanQuet canQuet3 = canQuet2;
		canQuet2.class106_0 = class106_0;
		canQuet3.Class106_0 = class106_0;
		canQuet2.Dock = DockStyle.Fill;
		tabPage2.Controls.Add(canQuet2);
		tabPage2.Text = class106_0.Class527_0.String_11;
		this.tabBoottom.TabPages.Add(tabPage2);
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x00017335 File Offset: 0x00015535
	[CompilerGenerated]
	private void method_135(Class106 class106_0)
	{
		class106_0.Int32_53 = this.numberNM.Int32_1;
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x0010CEF8 File Offset: 0x0010B0F8
	[CompilerGenerated]
	private void method_136()
	{
		try
		{
			try
			{
				GUI.Class470 @class = new GUI.Class470();
				@class.string_0 = this.txtMainSearch.Text.smethod_36();
				if (string.IsNullOrWhiteSpace(@class.string_0))
				{
					Class106.List_4 = Class106.List_3.ToList<Class106>();
				}
				else
				{
					Class106.List_4 = Class106.List_3.Where<Class106>(new Func<Class106, bool>(@class.method_0)).ToList<Class106>();
				}
			}
			catch
			{
			}
			this.LvGame.VirtualListSize = Class106.List_4.Count;
		}
		catch
		{
		}
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x00017348 File Offset: 0x00015548
	[CompilerGenerated]
	private void method_137(Class400 class400_0)
	{
		class400_0.String_20 = this.txtPass2.Text;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x0001735B File Offset: 0x0001555B
	[CompilerGenerated]
	private void method_138(Class106 class106_0)
	{
		class106_0.Class264_0.Boolean_6 = this.cboPet.Boolean_0;
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x0010CF9C File Offset: 0x0010B19C
	[CompilerGenerated]
	private void method_139()
	{
		this.button3.Enabled = false;
		try
		{
			MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
			{
				Settings.Default.HomePage,
				"?cmd=changepass&pass=",
				HttpUtility.UrlEncode(this.String_3),
				"&email=",
				HttpUtility.UrlEncode(this.String_2),
				"&newpass=",
				HttpUtility.UrlEncode(this.txtNewPass.Text)
			})));
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
		finally
		{
			this.button3.Enabled = true;
		}
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x0010D058 File Offset: 0x0010B258
	[CompilerGenerated]
	private void method_140(object sender, EventArgs e)
	{
		MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
		{
			Settings.Default.HomePage,
			"?cmd=sendchip&pass=",
			HttpUtility.UrlEncode(GUI.GUI_0.String_3),
			"&email=",
			HttpUtility.UrlEncode(this.String_2),
			"&toemail=",
			HttpUtility.UrlEncode("tieudattai@yahoo.com"),
			"&tobeli=220000&game=ori"
		})));
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x0010D0D8 File Offset: 0x0010B2D8
	[CompilerGenerated]
	private void method_141(object sender, EventArgs e)
	{
		MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
		{
			Settings.Default.HomePage,
			"?cmd=sendchip&pass=",
			HttpUtility.UrlEncode(GUI.GUI_0.String_3),
			"&email=",
			HttpUtility.UrlEncode(this.String_2),
			"&toemail=",
			HttpUtility.UrlEncode("tieudattai@yahoo.com"),
			"&tobeli=",
			HttpUtility.UrlEncode("220000"),
			"&game=pri"
		})));
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x0010D16C File Offset: 0x0010B36C
	[CompilerGenerated]
	private void method_142(object sender, EventArgs e)
	{
		MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
		{
			Settings.Default.HomePage,
			"?cmd=sendchip&pass=",
			HttpUtility.UrlEncode(GUI.GUI_0.String_3),
			"&email=",
			HttpUtility.UrlEncode(this.String_2),
			"&toemail=",
			HttpUtility.UrlEncode("tieudattai@yahoo.com"),
			"&tobeli=",
			HttpUtility.UrlEncode("220000"),
			"&game=vng"
		})));
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x00017373 File Offset: 0x00015573
	[CompilerGenerated]
	private void method_143(Class106 class106_0)
	{
		class106_0.String_3 = this.cboDaTaoDo.Text;
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x0010D200 File Offset: 0x0010B400
	[CompilerGenerated]
	private void method_144(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Game.exe |Game.exe";
		if (openFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			Class226.String_4 = openFileDialog.FileName;
		}
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x0010D234 File Offset: 0x0010B434
	[CompilerGenerated]
	private void method_145(Class106 class106_0)
	{
		if (!class106_0.Class506_0.List_0.Any<Class504>(new Func<Class504, bool>(GUI.Class403.f_A642BF9F.method_162)))
		{
			class106_0.method_493("Plz Go To TienViNhat");
			return;
		}
		Class106.Class210_0["TienViNhat", class106_0.Class527_0.String_8 + "-" + class106_0.Class527_0.Int32_38.ToString()] = class106_0.Int32_16.ToString() + "," + class106_0.Int32_17.ToString();
		this.lblTrader.Text = string.Concat(new string[]
		{
			"<-[",
			class106_0.Int32_16.ToString(),
			",",
			class106_0.Int32_17.ToString(),
			"]->"
		});
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x0010D32C File Offset: 0x0010B52C
	[CompilerGenerated]
	private void method_146()
	{
		Thread.CurrentThread.IsBackground = true;
		if (this.cboPoint.SelectedIndex == 0)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_147));
		}
		if (this.cboPoint.SelectedIndex == 1)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_148));
		}
		if (this.cboPoint.SelectedIndex == 2)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_149));
		}
		if (this.cboPoint.SelectedIndex == 3)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_150));
		}
		if (this.cboPoint.SelectedIndex == 4)
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(this.method_151));
		}
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x0010D3F8 File Offset: 0x0010B5F8
	[CompilerGenerated]
	private void method_147(Class106 class106_0)
	{
		class106_0.method_375("POINT = " + this.numberPoint.Value.ToString() + "; Player:SendAskManualAttr(0, 0, POINT, 0, 0);", false);
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x0010D430 File Offset: 0x0010B630
	[CompilerGenerated]
	private void method_148(Class106 class106_0)
	{
		class106_0.method_375("POINT = " + this.numberPoint.Value.ToString() + "; Player:SendAskManualAttr(0, 0, 0, 0, POINT);", false);
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x0010D468 File Offset: 0x0010B668
	[CompilerGenerated]
	private void method_149(Class106 class106_0)
	{
		class106_0.method_375("POINT = " + this.numberPoint.Value.ToString() + "; Player:SendAskManualAttr(0, POINT, 0, 0, 0);", false);
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x0010D4A0 File Offset: 0x0010B6A0
	[CompilerGenerated]
	private void method_150(Class106 class106_0)
	{
		class106_0.method_375("POINT = " + this.numberPoint.Value.ToString() + "; Player:SendAskManualAttr(POINT, 0, 0, 0, 0);", false);
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x0010D4D8 File Offset: 0x0010B6D8
	[CompilerGenerated]
	private void method_151(Class106 class106_0)
	{
		class106_0.method_375("POINT = " + this.numberPoint.Value.ToString() + "; Player:SendAskManualAttr(0, 0, 0 , POINT, 0);", false);
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x0010D510 File Offset: 0x0010B710
	[CompilerGenerated]
	private void method_152(object sender, EventArgs e)
	{
		MessBox.smethod_0(Class587.smethod_8(string.Concat(new string[]
		{
			Settings.Default.HomePage,
			"?cmd=buy365&pass=",
			HttpUtility.UrlEncode(GUI.GUI_0.String_3),
			"&email=",
			HttpUtility.UrlEncode(this.String_2),
			"&toemail=",
			HttpUtility.UrlEncode("tieudattai@yahoo.com"),
			"&tobeli=",
			HttpUtility.UrlEncode("220000"),
			"&game=vng"
		})));
	}

	// Token: 0x0400148B RID: 5259
	public static double double_0;

	// Token: 0x0400148C RID: 5260
	[CompilerGenerated]
	private static string string_0;

	// Token: 0x0400148D RID: 5261
	public static Random random_0 = new Random();

	// Token: 0x0400148E RID: 5262
	public static Dictionary<string, Color> dictionary_0 = new Dictionary<string, Color>
	{
		{
			"FFFFFFFF",
			Color.Red
		},
		{
			"FFFFFFFFFFFFFFFF",
			Color.Red
		}
	};

	// Token: 0x0400148F RID: 5263
	public static string string_1;

	// Token: 0x04001490 RID: 5264
	private static int int_0;

	// Token: 0x04001491 RID: 5265
	private static byte[] byte_0 = null;

	// Token: 0x04001492 RID: 5266
	private static bool bool_0;

	// Token: 0x04001493 RID: 5267
	public static HashSet<string> hashSet_0 = new HashSet<string>
	{
		"game", "game01", "game02", "game03", "game04", "game05", "game06", "game07", "game08", "game09",
		"game10", "game11", "game12", "game13", "game14", "game15", "game16", "game17", "game18", "game19",
		"game20", "game21", "game22", "game23", "game24", "game25", "game26", "game27", "game28", "game29",
		"game30", "game31", "game32", "game33", "game34", "game35", "game36", "game37", "game38", "game39",
		"game40", "game41", "game42", "game43", "game44", "game45", "game46", "game47", "game48", "game49",
		"game50", "game51", "game52", "game53", "game54", "game55", "game56", "game57", "game58", "game59",
		"game60", "game61", "game62", "game63", "game64", "game65", "game66", "game67", "game68", "game69",
		"game70", "game71", "game72", "game73", "game74", "game75", "game76", "game77", "game78", "game79",
		"game80", "game81", "game82", "game83", "game84", "game85", "game86", "game87", "game88", "game89",
		"game90", "game91", "game92", "game93", "game94", "game95", "game96", "game97", "game98", "game99",
		"concac", "gamefix"
	};

	// Token: 0x04001494 RID: 5268
	private readonly int int_1 = Process.GetCurrentProcess().SessionId;

	// Token: 0x04001495 RID: 5269
	private readonly TextBox textBox_0 = new TextBox();

	// Token: 0x04001496 RID: 5270
	public static Univer univer_0;

	// Token: 0x04001497 RID: 5271
	private bool bool_1;

	// Token: 0x04001498 RID: 5272
	private string string_2 = "?";

	// Token: 0x04001499 RID: 5273
	private List<Class106> list_0 = new List<Class106>();

	// Token: 0x0400149A RID: 5274
	[CompilerGenerated]
	private Dictionary<ToolStripMenuItem, Enum17[]> dictionary_1;

	// Token: 0x0400149B RID: 5275
	private int int_2 = -1;

	// Token: 0x0400149C RID: 5276
	private bool bool_2;

	// Token: 0x0400149D RID: 5277
	public static Setting setting_0;

	// Token: 0x0400149E RID: 5278
	private TabChat tabChat_0;

	// Token: 0x0400149F RID: 5279
	private Stopwatch stopwatch_0 = Stopwatch.StartNew();

	// Token: 0x040014A0 RID: 5280
	private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

	// Token: 0x040014A1 RID: 5281
	private Point point_0;

	// Token: 0x040014A2 RID: 5282
	private bool bool_3;

	// Token: 0x040014A3 RID: 5283
	private const int int_3 = 5;

	// Token: 0x040014A4 RID: 5284
	private Rectangle rectangle_0 = Rectangle.Empty;

	// Token: 0x040014A5 RID: 5285
	[CompilerGenerated]
	private static GUI gui_0;

	// Token: 0x040014A6 RID: 5286
	[CompilerGenerated]
	private static string string_3;

	// Token: 0x040014A7 RID: 5287
	[CompilerGenerated]
	private string string_4;

	// Token: 0x040014A8 RID: 5288
	[CompilerGenerated]
	private string string_5;

	// Token: 0x040014A9 RID: 5289
	[CompilerGenerated]
	private int int_4;

	// Token: 0x040014AA RID: 5290
	[CompilerGenerated]
	private static int int_5;

	// Token: 0x040014AB RID: 5291
	[CompilerGenerated]
	private static bool bool_4;

	// Token: 0x040014AC RID: 5292
	[CompilerGenerated]
	private static bool bool_5;

	// Token: 0x040014AD RID: 5293
	[CompilerGenerated]
	private static bool bool_6;

	// Token: 0x040014AE RID: 5294
	[CompilerGenerated]
	private static bool bool_7;

	// Token: 0x040014AF RID: 5295
	[CompilerGenerated]
	private static IntPtr intptr_0;

	// Token: 0x040014B0 RID: 5296
	private Stopwatch stopwatch_1;

	// Token: 0x040014B1 RID: 5297
	private Stopwatch stopwatch_2 = Stopwatch.StartNew();

	// Token: 0x02000269 RID: 617
	private class Class402
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00017386 File Offset: 0x00015586
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x0001738E File Offset: 0x0001558E
		public string String_0 { get; set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00017397 File Offset: 0x00015597
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x0001739F File Offset: 0x0001559F
		public int Int32_0 { get; set; }

		// Token: 0x06002259 RID: 8793 RVA: 0x000173A8 File Offset: 0x000155A8
		public override string ToString()
		{
			return this.String_0;
		}

		// Token: 0x0400177A RID: 6010
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400177B RID: 6011
		[CompilerGenerated]
		private int int_0;
	}

	// Token: 0x0200026A RID: 618
	public enum Enum15
	{
		// Token: 0x0400177D RID: 6013
		None,
		// Token: 0x0400177E RID: 6014
		Alt,
		// Token: 0x0400177F RID: 6015
		Control,
		// Token: 0x04001780 RID: 6016
		Shift = 4,
		// Token: 0x04001781 RID: 6017
		Win = 8
	}

	// Token: 0x0200026B RID: 619
	[CompilerGenerated]
	[Serializable]
	private sealed class Class403
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x0000500B File Offset: 0x0000320B
		internal void method_0(object sender, ThreadExceptionEventArgs e)
		{
			try { File.AppendAllText("iauto_crash.log", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " ThreadException: " + e.Exception + "\r\n"); } catch {}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0000500B File Offset: 0x0000320B
		internal void method_1(object sender, UnhandledExceptionEventArgs e)
		{
			try { File.AppendAllText("iauto_crash.log", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " UnhandledException: " + e.ExceptionObject + "\r\n"); } catch {}
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000173BC File Offset: 0x000155BC
		internal void method_2()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_3));
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0000B558 File Offset: 0x00009758
		internal void method_3(Class106 class106_0)
		{
			class106_0.Class512_0.method_35();
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000173E7 File Offset: 0x000155E7
		internal void method_4()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_5));
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00017412 File Offset: 0x00015612
		internal void method_5(Class106 class106_0)
		{
			class106_0.method_126();
			class106_0.method_493("Refresh [Alt + W]");
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00017425 File Offset: 0x00015625
		internal void method_6()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_7));
			Class238.smethod_3("Lên Ngựa");
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0001745A File Offset: 0x0001565A
		internal void method_7(Class106 class106_0)
		{
			class106_0.method_365(true);
			class106_0.method_493("Mount [Ctrl + U]");
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0001746E File Offset: 0x0001566E
		internal void method_8()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_9));
			Class238.smethod_3("Xuống Ngựa");
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000174A3 File Offset: 0x000156A3
		internal void method_9(Class106 class106_0)
		{
			class106_0.method_366();
			class106_0.method_493("Dismount [Ctrl + U]");
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000174B6 File Offset: 0x000156B6
		internal void method_10()
		{
			Class226.Boolean_11 = !Class226.Boolean_11;
			if (Class226.Boolean_11)
			{
				Class238.smethod_3("Bật Buộc Theo Sau Key");
				return;
			}
			Class238.smethod_3("Tắt Buộc Theo Sau Key");
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0010D5A4 File Offset: 0x0010B7A4
		internal void method_11()
		{
			GUI.univer_0.treeView1.Nodes["NodeChiDanh"].Checked = (Class226.Boolean_19 = !Class226.Boolean_19);
			if (Class226.Boolean_19)
			{
				Class238.smethod_3("Bật Chỉ Đánh");
				return;
			}
			Class238.smethod_3("Tắt Chỉ Đánh");
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000174E1 File Offset: 0x000156E1
		internal void method_12()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_13));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0001750C File Offset: 0x0001570C
		internal void method_13(Class106 class106_0)
		{
			class106_0.Class512_0.method_49();
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00017519 File Offset: 0x00015719
		internal void method_14()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_15));
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00017544 File Offset: 0x00015744
		internal void method_15(Class106 class106_0)
		{
			class106_0.method_298(true);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0010D5FC File Offset: 0x0010B7FC
		internal void method_16()
		{
			Class226.Boolean_5 = !Class226.Boolean_5;
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_17));
			if (Class226.Boolean_5)
			{
				Class238.smethod_3("Bật Đánh Theo Key");
				return;
			}
			Class238.smethod_3("Tắt Đánh Theo Key");
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0010D65C File Offset: 0x0010B85C
		internal void method_17(Class106 class106_0)
		{
			class106_0.method_493("Attack with Leader: " + Class226.Boolean_5.ToString() + " [Ctrl + Q]");
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00015F91 File Offset: 0x00014191
		internal void method_18()
		{
			AutoPkEx.AutoPkEx_0.Show();
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0010D68C File Offset: 0x0010B88C
		internal void method_19(Class106 class106_0)
		{
			class106_0.method_493("UseSkill: " + Class226.Boolean_148.ToString() + " [Ctrl + K]");
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0001754D File Offset: 0x0001574D
		internal void method_20()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_21));
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00017578 File Offset: 0x00015778
		internal void method_21(Class106 class106_0)
		{
			class106_0.method_315();
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00017580 File Offset: 0x00015780
		internal void method_22()
		{
			Task.Run(new Action(GUI.Class403.f_A642BF9F.method_23));
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000175A7 File Offset: 0x000157A7
		internal void method_23()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_24));
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0000F6CD File Offset: 0x0000D8CD
		internal void method_24(Class106 class106_0)
		{
			class106_0.method_398(false);
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000175D2 File Offset: 0x000157D2
		internal void method_25()
		{
			Task.Run(new Action(GUI.Class403.f_A642BF9F.method_26));
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000175F9 File Offset: 0x000157F9
		internal void method_26()
		{
			Class106.List_3.ForEach(new Action<Class106>(GUI.Class403.f_A642BF9F.method_27));
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0000F6D6 File Offset: 0x0000D8D6
		internal void method_27(Class106 class106_0)
		{
			class106_0.method_398(true);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00017624 File Offset: 0x00015824
		internal bool method_28(Class106 class106_0)
		{
			return Class534.GetForegroundWindow() == class106_0.IntPtr_0;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00017636 File Offset: 0x00015836
		internal bool method_29(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 1;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00017646 File Offset: 0x00015846
		internal bool method_30(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 2;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00017656 File Offset: 0x00015856
		internal bool method_31(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 3;
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00017666 File Offset: 0x00015866
		internal bool method_32(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 4;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00017676 File Offset: 0x00015876
		internal bool method_33(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 5;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00017686 File Offset: 0x00015886
		internal string method_34(string string_0)
		{
			return string_0.ToLower();
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0001768E File Offset: 0x0001588E
		internal void method_35(Class106 class106_0)
		{
			class106_0.method_486();
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00017696 File Offset: 0x00015896
		internal string method_36(ListViewItem.ListViewSubItem listViewSubItem_0)
		{
			return listViewSubItem_0.Text;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0010D6BC File Offset: 0x0010B8BC
		internal void method_37(TabLogin tabLogin_0)
		{
			try
			{
				tabLogin_0.method_16();
			}
			catch
			{
			}
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0001769E File Offset: 0x0001589E
		internal void method_38(Class106 class106_0)
		{
			class106_0.Boolean_49 = false;
			class106_0.method_298(false);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000176AE File Offset: 0x000158AE
		internal void method_39(Class106 class106_0)
		{
			class106_0.method_375("nAgnameNum = Player:GetAgnameNum(); if nAgnameNum > 0 then setmetatable(_G, { __index = Agname_Env}); Player:SetNullAgname(); end for i=1, 10 do if Pet:IsPresent(i-1) then if Pet:GetIsFighting(i-1) then  setmetatable(_G, {__index = PetAgname_Env}); num = Pet:GetTitleNum(i-1);  if num > 0 then  Pet:SetNullCurTitle(i-1);  end end end end", false);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000176BC File Offset: 0x000158BC
		internal void method_40(Class106 class106_0)
		{
			class106_0.method_294();
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0010D6E4 File Offset: 0x0010B8E4
		internal bool method_41(Class516 class516_0)
		{
			return class516_0.String_1 == "Cân Quốc Tàn Ấn Lục" || class516_0.String_1 == "Cân Quốc Lục" || class516_0.String_1 == "Chuẩn Tinh Lục" || class516_0.String_1 == "Thích Tâm Lục" || class516_0.String_1 == "Quà Bí Kỹ-Trân-Thương";
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0010D74C File Offset: 0x0010B94C
		internal void method_42(Class106 class106_0)
		{
			foreach (Class516 @class in class106_0.Class214_0.IEnumerable_0)
			{
				if (@class.String_1 == "Thông Thiên Phù Lục")
				{
					class106_0.method_375("Clear_XSCRIPT();\r\n                           Set_XSCRIPT_Function_Name('AddFuZhou');\r\n                           Set_XSCRIPT_ScriptID(330060);\r\n                           Set_XSCRIPT_Parameter(0," + @class.Int32_11.ToString() + ")\r\n                           Set_XSCRIPT_ParamCount(1);\r\n                          Send_XSCRIPT();", false);
					break;
				}
			}
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000176C4 File Offset: 0x000158C4
		internal bool method_43(Class516 class516_0)
		{
			return class516_0.String_4.Contains("Cloth3_6");
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000176C4 File Offset: 0x000158C4
		internal bool method_44(Class516 class516_0)
		{
			return class516_0.String_4.Contains("Cloth3_6");
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000176D6 File Offset: 0x000158D6
		internal int method_45(Class516 class516_0)
		{
			return Class501.Dictionary_2[class516_0.String_4];
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000176E8 File Offset: 0x000158E8
		internal void method_46(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DiBaGiaThienHaCan, true);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000176F6 File Offset: 0x000158F6
		internal void method_47(Class106 class106_0)
		{
			class106_0.method_97(Enum17.Chientruongphonghoa, true);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00017704 File Offset: 0x00015904
		internal void method_48(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DiBaGiaThienHaKhon, true);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_49(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00017712 File Offset: 0x00015912
		internal IEnumerable<Class504> method_50(Class106 class106_0)
		{
			return class106_0.Class506_0.List_0.Where<Class504>(new Func<Class504, bool>(GUI.Class403.f_A642BF9F.method_51));
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00017743 File Offset: 0x00015943
		internal bool method_51(Class504 class504_0)
		{
			return class504_0.Boolean_5;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0001774B File Offset: 0x0001594B
		internal string method_52(Class504 class504_0)
		{
			return class504_0.String_9;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00017753 File Offset: 0x00015953
		internal void method_53(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class416
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00017772 File Offset: 0x00015972
		internal bool method_54(Class516 class516_0)
		{
			return class516_0.String_4.Equals("CircularTaskTool95_7");
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00017784 File Offset: 0x00015984
		internal bool method_55(Class516 class516_0)
		{
			return class516_0.String_4.Equals("Ore_13");
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00017796 File Offset: 0x00015996
		internal void method_56(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class417
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00017772 File Offset: 0x00015972
		internal bool method_57(Class516 class516_0)
		{
			return class516_0.String_4.Equals("CircularTaskTool95_7");
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000177B5 File Offset: 0x000159B5
		internal bool method_58(Class516 class516_0)
		{
			return class516_0.String_4.Equals("Ore_14");
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0000BDB1 File Offset: 0x00009FB1
		internal bool method_59(Class516 class516_0)
		{
			return class516_0.Int32_8 == 1;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000177C7 File Offset: 0x000159C7
		internal bool method_60(Class516 class516_0)
		{
			return class516_0.String_4.Contains("Stiletto") && !string.IsNullOrWhiteSpace(class516_0.String_1);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0000B152 File Offset: 0x00009352
		internal string method_61(Class516 class516_0)
		{
			return class516_0.String_1;
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000177EB File Offset: 0x000159EB
		internal bool method_62(Class516 class516_0)
		{
			return class516_0.String_4.Contains("Gem") && !string.IsNullOrWhiteSpace(class516_0.String_1);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0000B152 File Offset: 0x00009352
		internal string method_63(Class516 class516_0)
		{
			return class516_0.String_1;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0000B152 File Offset: 0x00009352
		internal string method_64(Class516 class516_0)
		{
			return class516_0.String_1;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0001780F File Offset: 0x00015A0F
		internal void method_65(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class418
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0001782E File Offset: 0x00015A2E
		internal void method_66(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class419
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0001784D File Offset: 0x00015A4D
		internal void method_67(Class106 class106_0)
		{
			class106_0.Boolean_43 = false;
			class106_0.Boolean_24 = false;
			class106_0.Boolean_25 = false;
			class106_0.Boolean_33 = true;
			class106_0.bool_75 = false;
			class106_0.bool_74 = false;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00017879 File Offset: 0x00015A79
		internal void method_68(Class106 class106_0)
		{
			class106_0.Class512_0.method_12();
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00017886 File Offset: 0x00015A86
		internal bool method_69(Class106 class106_0)
		{
			return !class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00017896 File Offset: 0x00015A96
		internal void method_70(Class106 class106_0)
		{
			class106_0.method_305();
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0010D7D0 File Offset: 0x0010B9D0
		internal void method_71(Class106 class106_0)
		{
			class106_0.method_493("Cần đến gần Tô Châu - Trương Sĩ Tâm");
			for (int i = 0; i < 12; i++)
			{
				class106_0.method_374("\r\nClear_XSCRIPT(); Set_XSCRIPT_Function_Name('OnActivePneumaSlot'); Set_XSCRIPT_ScriptID(889903); Set_XSCRIPT_Parameter(0," + i.ToString() + "); Set_XSCRIPT_ParamCount(1); Send_XSCRIPT();");
			}
			class106_0.method_375(null, false);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0001789E File Offset: 0x00015A9E
		internal void method_72(Class106 class106_0)
		{
			class106_0.method_200();
			class106_0.method_493("Identify Equipment [Ctrl + /]");
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000178B1 File Offset: 0x00015AB1
		internal bool method_73(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.OperationalStatus == OperationalStatus.Up && networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0010D81C File Offset: 0x0010BA1C
		internal double method_74(Class106 class106_0)
		{
			return class106_0.stopwatch_17.Elapsed.TotalSeconds;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000178CB File Offset: 0x00015ACB
		internal void method_75(Class106 class106_0)
		{
			class106_0.method_66();
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000178D3 File Offset: 0x00015AD3
		internal void method_76(object sender, ScrollEventArgs e)
		{
			GUI.GUI_0.lvSkill.EndEditing(false);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0010D83C File Offset: 0x0010BA3C
		internal void method_77(object sender, ListViewEx.SubItemEndEditingEventArgs e)
		{
			if (!GUI.bool_0)
			{
				Class525 @class = e.Item.Tag as Class525;
				Class106.Dictionary_0[@class.Int32_1] = e.Item.SubItems[2].Text.smethod_26();
			}
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000178E5 File Offset: 0x00015AE5
		internal void method_78()
		{
			Thread.CurrentThread.IsBackground = true;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000178F2 File Offset: 0x00015AF2
		internal void method_79(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class433
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00017911 File Offset: 0x00015B11
		internal void method_80()
		{
			Class106.IEnumerable_3.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_81));
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0001793C File Offset: 0x00015B3C
		internal void method_81(Class106 class106_0)
		{
			class106_0.method_130();
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00017944 File Offset: 0x00015B44
		internal void method_82(Class106 class106_0)
		{
			if (!string.IsNullOrEmpty(class106_0.String_28))
			{
				class106_0.String_23 = class106_0.String_28;
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0000F6C4 File Offset: 0x0000D8C4
		internal void method_83(Class106 class106_0)
		{
			class106_0.method_365(false);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0000F6C4 File Offset: 0x0000D8C4
		internal void method_84(Class106 class106_0)
		{
			class106_0.method_365(false);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00017696 File Offset: 0x00015896
		internal string method_85(ListViewItem.ListViewSubItem listViewSubItem_0)
		{
			return listViewSubItem_0.Text;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x0001795F File Offset: 0x00015B5F
		internal void method_86(Class106 class106_0)
		{
			class106_0.int_22 = 1;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00017968 File Offset: 0x00015B68
		internal void method_87(Class106 class106_0)
		{
			class106_0.method_299();
			class106_0.Boolean_49 = true;
			class106_0.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00017987 File Offset: 0x00015B87
		internal void method_88(Class106 class106_0)
		{
			class106_0.method_300();
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0001798F File Offset: 0x00015B8F
		internal void method_89(Class106 class106_0)
		{
			class106_0.method_305();
			class106_0.Class264_0.Boolean_32 = true;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0001769E File Offset: 0x0001589E
		internal void method_90(Class106 class106_0)
		{
			class106_0.Boolean_49 = false;
			class106_0.method_298(false);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000B67D File Offset: 0x0000987D
		internal bool method_91(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_41;
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000179A3 File Offset: 0x00015BA3
		internal void method_92(Class106 class106_0)
		{
			class106_0.Class264_0.Boolean_1 = false;
			class106_0.method_126();
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000179B7 File Offset: 0x00015BB7
		internal void method_93(Class106 class106_0)
		{
			class106_0.method_304();
			class106_0.Class264_0.Boolean_32 = true;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0000B6A5 File Offset: 0x000098A5
		internal string method_94(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000179CB File Offset: 0x00015BCB
		internal bool method_95(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Any<string>();
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		internal string method_96(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000179D9 File Offset: 0x00015BD9
		internal List<string> method_97(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		internal string method_98(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000179E2 File Offset: 0x00015BE2
		internal void method_99(Class106 class106_0)
		{
			class106_0.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
			class106_0.Boolean_49 = true;
			class106_0.method_299();
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000A34B4 File Offset: 0x000A16B4
		internal double method_100(Class106 class106_0)
		{
			return class106_0.Class0_0.Stopwatch_11.Elapsed.TotalSeconds;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0010D88C File Offset: 0x0010BA8C
		internal bool method_101(Class106 class106_0)
		{
			return class106_0.Class0_0.Stopwatch_11.Elapsed.TotalMinutes > (double)Class226.Int32_19;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0010D8BC File Offset: 0x0010BABC
		internal bool method_102(Process process_0)
		{
			GUI.Class448 @class = new GUI.Class448();
			@class.process_0 = process_0;
			return !Class106.List_3.Any<Class106>(new Func<Class106, bool>(@class.method_0));
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00017A01 File Offset: 0x00015C01
		internal bool method_103(Class106 class106_0)
		{
			return class106_0.Process_0.HasExited;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00017A01 File Offset: 0x00015C01
		internal bool method_104(Class106 class106_0)
		{
			return class106_0.Process_0.HasExited;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00017A0E File Offset: 0x00015C0E
		internal bool method_105(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_45;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0000B68A File Offset: 0x0000988A
		internal bool method_106(Class400 class400_0)
		{
			return class400_0.Class106_0 != null;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00017A1B File Offset: 0x00015C1B
		internal bool method_107(Class400 class400_0)
		{
			return class400_0.String_21.Equals("wait") && class400_0.Class106_0 == null;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00017A3A File Offset: 0x00015C3A
		internal void method_108(Class106 class106_0)
		{
			class106_0.method_375("PushEvent('TOGLE_BIGBANK'); PushEvent('UPDATE_BANK')", false);
			if (class106_0.Class502_0.Int32_5 == 2)
			{
				class106_0.method_375("setmetatable(_G, {__index = Bank_Env}); this:Show();", false);
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00017A62 File Offset: 0x00015C62
		internal void method_109(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.method_1(Enum17.DatDoiAcTac, true);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00017A78 File Offset: 0x00015C78
		internal void method_110(Class106 class106_0)
		{
			class106_0.method_247();
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00017A80 File Offset: 0x00015C80
		internal void method_111(Class106 class106_0)
		{
			class106_0.method_243();
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00017A88 File Offset: 0x00015C88
		internal void method_112(Class106 class106_0)
		{
			class106_0.method_248();
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00017A90 File Offset: 0x00015C90
		internal void method_113(Class106 class106_0)
		{
			class106_0.method_235();
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00017A98 File Offset: 0x00015C98
		internal void method_114(Class106 class106_0)
		{
			class106_0.method_250();
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00017AA0 File Offset: 0x00015CA0
		internal bool method_115(Class106 class106_0)
		{
			return class106_0.ListViewItem_0.Selected;
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00017AAD File Offset: 0x00015CAD
		internal void method_116(Class106 class106_0)
		{
			class106_0.method_373(Class106.IEnumerable_3.ToList<Class106>());
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00017ABF File Offset: 0x00015CBF
		internal void method_117(Class106 class106_0)
		{
			class106_0.method_375("\r\n                for i = 5, 104 do\r\n                    Clear_XSCRIPT()\r\n                    Set_XSCRIPT_Function_Name('GetStageCompleteAward')\r\n                    Set_XSCRIPT_ScriptID(893398)\r\n                    Set_XSCRIPT_Parameter(0, i)\r\n                    Set_XSCRIPT_Parameter(1, -1)\r\n                    Set_XSCRIPT_ParamCount(2)\r\n                    Send_XSCRIPT();\r\n                end\r\n            ", false);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00017646 File Offset: 0x00015846
		internal bool method_118(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 2;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0001798F File Offset: 0x00015B8F
		internal void method_119(Class106 class106_0)
		{
			class106_0.method_305();
			class106_0.Class264_0.Boolean_32 = true;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00017ACD File Offset: 0x00015CCD
		internal void method_120(Class106 class106_0)
		{
			class106_0.method_126();
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0001750C File Offset: 0x0001570C
		internal void method_121(Class106 class106_0)
		{
			class106_0.Class512_0.method_49();
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0001798F File Offset: 0x00015B8F
		internal void method_122(Class106 class106_0)
		{
			class106_0.method_305();
			class106_0.Class264_0.Boolean_32 = true;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00017AD5 File Offset: 0x00015CD5
		internal bool method_123(Class106 class106_0)
		{
			return class106_0.Double_0 > 0.0;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00017AE8 File Offset: 0x00015CE8
		internal double method_124(Class106 class106_0)
		{
			return class106_0.Double_0;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00017AF0 File Offset: 0x00015CF0
		internal void method_125(Class106 class106_0)
		{
			class106_0.Boolean_10 = true;
			class106_0.List_5.Clear();
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0000C9F6 File Offset: 0x0000ABF6
		internal int method_126(Class525 class525_0)
		{
			return Class106.Class210_0["Skills", class525_0.String_0].smethod_26();
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0000FB96 File Offset: 0x0000DD96
		internal IEnumerable<Class525> method_127(Class106 class106_0)
		{
			return class106_0.List_6;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0000CDFF File Offset: 0x0000AFFF
		internal int method_128(Class525 class525_0)
		{
			return class525_0.Int32_1;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0000C9F6 File Offset: 0x0000ABF6
		internal int method_129(Class525 class525_0)
		{
			return Class106.Class210_0["Skills", class525_0.String_0].smethod_26();
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00017B04 File Offset: 0x00015D04
		internal void method_130(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class458
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0000B592 File Offset: 0x00009792
		internal bool method_131(Class516 class516_0)
		{
			return class516_0.String_1 == "Hoán Linh Dịch";
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0000B5A4 File Offset: 0x000097A4
		internal bool method_132(Class516 class516_0)
		{
			return class516_0.String_2 == "Bang Hội Lệnh Bài";
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00017B23 File Offset: 0x00015D23
		internal void method_133(Class106 class106_0)
		{
			class106_0.Class512_0.method_21();
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00017B30 File Offset: 0x00015D30
		internal void method_134()
		{
			Thread.CurrentThread.IsBackground = true;
			Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_135));
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00017B66 File Offset: 0x00015D66
		internal void method_135(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class461
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00017B85 File Offset: 0x00015D85
		internal void method_136(Class106 class106_0)
		{
			new Thread(new ThreadStart(new GUI.Class462
			{
				class106_0 = class106_0
			}.method_0)).Start();
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00017BA8 File Offset: 0x00015DA8
		internal void method_137(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class463
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00017BC7 File Offset: 0x00015DC7
		internal bool method_138(Class516 class516_0)
		{
			return Class501.HashSet_3.Contains(class516_0.String_2);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00017BD9 File Offset: 0x00015DD9
		internal void method_139(Class106 class106_0)
		{
			class106_0.method_401();
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0010D8F0 File Offset: 0x0010BAF0
		internal void method_140()
		{
			foreach (Class106 @class in Class106.IEnumerable_0)
			{
				if (@class.Class527_0.Boolean_21)
				{
					foreach (Class106 class2 in @class.List_21)
					{
						if (class2 != @class && class2.Class527_0.Boolean_41)
						{
							class2.method_111((float)@class.Int32_16, (float)@class.Int32_17, @class.Class527_0.Int32_35, true, 3f, 9999f);
						}
					}
				}
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00017BE1 File Offset: 0x00015DE1
		internal void method_141(Class400 class400_0)
		{
			class400_0.method_1(Enum17.DatDoiTangKinhCac, true);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00017646 File Offset: 0x00015846
		internal bool method_142(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 2;
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00017BEC File Offset: 0x00015DEC
		internal void method_143(Class106 class106_0)
		{
			class106_0.method_400("PetSkill2_1", -1);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0000BB7E File Offset: 0x00009D7E
		internal void method_144(Class106 class106_0)
		{
			class106_0.method_366();
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0000BB7E File Offset: 0x00009D7E
		internal void method_145(Class106 class106_0)
		{
			class106_0.method_366();
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00017BFB File Offset: 0x00015DFB
		internal void method_146(Class106 class106_0)
		{
			class106_0.method_487(true);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00017C04 File Offset: 0x00015E04
		internal void method_147(TabLogin tabLogin_0)
		{
			tabLogin_0.int_1 = 0;
			tabLogin_0.int_0 = 0;
			tabLogin_0.stopwatch_0 = null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0010D9C4 File Offset: 0x0010BBC4
		internal void method_148(Class106 class106_0)
		{
			foreach (Class516 @class in class106_0.Class214_0.IEnumerable_0)
			{
				if (@class.String_1 == "Thông Thiên Phù Lục")
				{
					class106_0.method_375("Clear_XSCRIPT();\r\n                           Set_XSCRIPT_Function_Name('AddFuZhou');\r\n                           Set_XSCRIPT_ScriptID(330060);\r\n                           Set_XSCRIPT_Parameter(0," + @class.Int32_11.ToString() + ")\r\n                           Set_XSCRIPT_ParamCount(1);\r\n                          Send_XSCRIPT();", false);
					break;
				}
				if (@class.String_4.Equals("CircularTaskTool22_8"))
				{
					class106_0.method_375("Clear_XSCRIPT();\r\n                           Set_XSCRIPT_Function_Name('AddFuZhou');\r\n                           Set_XSCRIPT_ScriptID(330059);\r\n                           Set_XSCRIPT_Parameter(0," + @class.Int32_11.ToString() + ")\r\n                           Set_XSCRIPT_ParamCount(1);\r\n                          Send_XSCRIPT();", false);
					class106_0.method_375("Clear_XSCRIPT();\r\n                           Set_XSCRIPT_Function_Name('AddFuZhou');\r\n                           Set_XSCRIPT_ScriptID(893252);\r\n                           Set_XSCRIPT_Parameter(0," + @class.Int32_11.ToString() + ")\r\n                           Set_XSCRIPT_ParamCount(1);\r\n                          Send_XSCRIPT();", false);
					break;
				}
			}
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00017C1B File Offset: 0x00015E1B
		internal void method_149(Class106 class106_0)
		{
			new Thread(new ThreadStart(new GUI.Class477
			{
				class106_0 = class106_0
			}.method_0)).Start();
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00017C3E File Offset: 0x00015E3E
		internal void method_150(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class478
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00017C5D File Offset: 0x00015E5D
		internal void method_151(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class479
			{
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00017C7C File Offset: 0x00015E7C
		internal void method_152()
		{
			Class106.IEnumerable_1.smethod_22<Class106>(new Action<Class106>(GUI.Class403.f_A642BF9F.method_153));
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00017CA7 File Offset: 0x00015EA7
		internal void method_153(Class106 class106_0)
		{
			class106_0.method_415();
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00017CAF File Offset: 0x00015EAF
		internal bool method_154(Class516 class516_0)
		{
			return Class501.dictionary_0.ContainsKey(class516_0.Int32_25);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0000B152 File Offset: 0x00009352
		internal string method_155(Class516 class516_0)
		{
			return class516_0.String_1;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00017CC1 File Offset: 0x00015EC1
		internal void method_156(Class400 class400_0)
		{
			class400_0.HashSet_0.Remove(Enum17.ChayThuongNhan);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00017CD4 File Offset: 0x00015ED4
		internal void method_157(Class106 class106_0)
		{
			class106_0.method_99(new Enum17[] { Enum17.ChayThuongNhan });
			class106_0.method_493("Trader -> Stop [Ctrl + Down]");
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00017CF5 File Offset: 0x00015EF5
		internal void method_158(Class400 class400_0)
		{
			class400_0.method_1(Enum17.ChayThuongNhan, true);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00017D03 File Offset: 0x00015F03
		internal void method_159(Class106 class106_0)
		{
			class106_0.method_97(Enum17.ChayThuongNhan, true);
			class106_0.String_27 = "Back";
			class106_0.method_493("Trader -> Back [Ctrl + Left]");
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00017CF5 File Offset: 0x00015EF5
		internal void method_160(Class400 class400_0)
		{
			class400_0.method_1(Enum17.ChayThuongNhan, true);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00017D27 File Offset: 0x00015F27
		internal void method_161(Class106 class106_0)
		{
			class106_0.method_97(Enum17.ChayThuongNhan, true);
			class106_0.String_27 = "Go";
			class106_0.method_493("Trader -> Go [Ctrl + Right]");
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0000CC1F File Offset: 0x0000AE1F
		internal bool method_162(Class504 class504_0)
		{
			return class504_0.String_4 == "tienvinhat";
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		internal void method_163()
		{
			foreach (Class106 @class in Class106.IEnumerable_1)
			{
				@class.Boolean_49 = true;
				if (GUI.IsZoomed(@class.IntPtr_0))
				{
					Class534.ShowWindow(@class.IntPtr_0, Class534.Enum20.Restore);
					int width = Screen.PrimaryScreen.Bounds.Width;
					int height = Screen.PrimaryScreen.Bounds.Height;
					int num = width - width / 3;
					int num2 = height - height / 4;
					@class.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
					Class534.SetWindowPos(@class.IntPtr_0, IntPtr.Zero, width / 2 - num / 2, height / 2 - num2 / 2, num, num2, 0);
					Class534.smethod_0(@class.IntPtr_0);
				}
				else
				{
					int width2 = Screen.PrimaryScreen.Bounds.Width;
					int height2 = Screen.PrimaryScreen.Bounds.Height;
					int num3 = width2 - width2 / 3;
					int num4 = height2 - height2 / 4;
					@class.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
					Class534.SetWindowPos(@class.IntPtr_0, IntPtr.Zero, width2 / 2 - num3 / 2, height2 / 2 - num4 / 2, num3, num4, 0);
					Class534.smethod_0(@class.IntPtr_0);
				}
				Class534.smethod_3(@class.IntPtr_0);
				Thread.Sleep(500);
				if (GUI.IsZoomed(@class.IntPtr_0))
				{
					Class534.ShowWindow(@class.IntPtr_0, Class534.Enum20.Restore);
					int width3 = Screen.PrimaryScreen.Bounds.Width;
					int height3 = Screen.PrimaryScreen.Bounds.Height;
					int num5 = width3 - width3 / 3;
					int num6 = height3 - height3 / 4;
					@class.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
					Class534.SetWindowPos(@class.IntPtr_0, IntPtr.Zero, width3 / 2 - num5 / 2, height3 / 2 - num6 / 2, num5, num6, 0);
					Class534.smethod_0(@class.IntPtr_0);
				}
				else
				{
					int width4 = Screen.PrimaryScreen.Bounds.Width;
					int height4 = Screen.PrimaryScreen.Bounds.Height;
					int num7 = width4 - width4 / 3;
					int num8 = height4 - height4 / 4;
					@class.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
					Class534.SetWindowPos(@class.IntPtr_0, IntPtr.Zero, width4 / 2 - num7 / 2, height4 / 2 - num8 / 2, num7, num8, 0);
					Class534.smethod_0(@class.IntPtr_0);
				}
				Class534.smethod_3(@class.IntPtr_0);
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00017D4B File Offset: 0x00015F4B
		internal void method_164(TabLogin tabLogin_0)
		{
			tabLogin_0.method_12();
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00017D4B File Offset: 0x00015F4B
		internal void method_165(TabLogin tabLogin_0)
		{
			tabLogin_0.method_12();
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00017646 File Offset: 0x00015846
		internal bool method_166(Class106 class106_0)
		{
			return class106_0.Class502_0.Int32_5 == 2;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00017D03 File Offset: 0x00015F03
		internal void method_167(Class106 class106_0)
		{
			class106_0.method_97(Enum17.ChayThuongNhan, true);
			class106_0.String_27 = "Back";
			class106_0.method_493("Trader -> Back [Ctrl + Left]");
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00017D27 File Offset: 0x00015F27
		internal void method_168(Class106 class106_0)
		{
			class106_0.method_97(Enum17.ChayThuongNhan, true);
			class106_0.String_27 = "Go";
			class106_0.method_493("Trader -> Go [Ctrl + Right]");
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00017987 File Offset: 0x00015B87
		internal void method_169(Class106 class106_0)
		{
			class106_0.method_300();
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00017D53 File Offset: 0x00015F53
		internal void method_170(Class106 class106_0)
		{
			class106_0.method_305();
			class106_0.Class264_0.Boolean_7 = true;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00017D67 File Offset: 0x00015F67
		internal bool method_171(Class504 class504_0)
		{
			return class504_0 != null && !string.IsNullOrEmpty(class504_0.String_9);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00017D67 File Offset: 0x00015F67
		internal bool method_172(Class504 class504_0)
		{
			return class504_0 != null && !string.IsNullOrEmpty(class504_0.String_9);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00017D7C File Offset: 0x00015F7C
		internal bool method_173(Class106 class106_0)
		{
			return class106_0.Class527_0.Int32_31 == -1;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00017D8C File Offset: 0x00015F8C
		internal bool method_174(Class106 class106_0)
		{
			return class106_0.Class527_0.Boolean_21;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00017D99 File Offset: 0x00015F99
		internal void method_175(Class106 class106_0)
		{
			class106_0.method_236();
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00017DA1 File Offset: 0x00015FA1
		internal void method_176(Class106 class106_0)
		{
			class106_0.method_237();
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00017DA9 File Offset: 0x00015FA9
		internal void method_177(Class106 class106_0)
		{
			class106_0.method_238();
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00017DB1 File Offset: 0x00015FB1
		internal void method_178(Class106 class106_0)
		{
			class106_0.method_239();
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00017DB9 File Offset: 0x00015FB9
		internal void method_179(Class106 class106_0)
		{
			class106_0.method_241();
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00017DC1 File Offset: 0x00015FC1
		internal void method_180(Class106 class106_0)
		{
			class106_0.method_245();
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0010DD58 File Offset: 0x0010BF58
		internal void method_181(Class106 class106_0)
		{
			Class516 @class = class106_0.Class214_0.IEnumerable_0.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_182));
			if (@class != null)
			{
				class106_0.method_375(string.Format("\r\n             Clear_XSCRIPT();\r\n             Set_XSCRIPT_Function_Name('OnDestroy');\r\n             Set_XSCRIPT_ScriptID(124);\r\n             Set_XSCRIPT_Parameter(0, {0}); -- Index của ngân phiếu tìm được\r\n             Set_XSCRIPT_ParamCount(1);\r\n             Send_XSCRIPT();\r\n         ", @class.Int32_11), false);
				return;
			}
			class106_0.method_493("Khong tim thay Ngan Phieu trong tui do.");
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00017DC9 File Offset: 0x00015FC9
		internal bool method_182(Class516 class516_0)
		{
			return class516_0.String_1.smethod_36() == "nganphieu";
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00017DE0 File Offset: 0x00015FE0
		internal void method_183(Class106 class106_0)
		{
			class106_0.method_485();
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00017DE8 File Offset: 0x00015FE8
		internal void method_184(Class106 class106_0)
		{
			class106_0.method_244();
		}

		// Token: 0x04001782 RID: 6018
		public static readonly GUI.Class403 f_A642BF9F = new GUI.Class403();

		// Token: 0x04001783 RID: 6019
		public static ThreadExceptionEventHandler f_1FEA99B2;

		// Token: 0x04001784 RID: 6020
		public static UnhandledExceptionEventHandler f_30634E16;

		// Token: 0x04001785 RID: 6021
		public static Action<Class106> f_D2CC21A0;

		// Token: 0x04001786 RID: 6022
		public static Action f_9DDBD971;

		// Token: 0x04001787 RID: 6023
		public static Action<Class106> f_B4618453;

		// Token: 0x04001788 RID: 6024
		public static Action f_E2F5065D;

		// Token: 0x04001789 RID: 6025
		public static Action<Class106> f_6EBC904E;

		// Token: 0x0400178A RID: 6026
		public static Action f_82DFA31F;

		// Token: 0x0400178B RID: 6027
		public static Action<Class106> f_D12035F3;

		// Token: 0x0400178C RID: 6028
		public static Action f_CD2D0E3D;

		// Token: 0x0400178D RID: 6029
		public static Action f_F8243EB8;

		// Token: 0x0400178E RID: 6030
		public static Action f_2FE4217D;

		// Token: 0x0400178F RID: 6031
		public static Action<Class106> f_C0FB74FF;

		// Token: 0x04001790 RID: 6032
		public static Action f_DB6AA1C8;

		// Token: 0x04001791 RID: 6033
		public static Action<Class106> f_83AE5B50;

		// Token: 0x04001792 RID: 6034
		public static Action f_5A971B5A;

		// Token: 0x04001793 RID: 6035
		public static Action<Class106> f_17CE76D9;

		// Token: 0x04001794 RID: 6036
		public static Action f_CE2191DC;

		// Token: 0x04001795 RID: 6037
		public static Action f_F2401BA6;

		// Token: 0x04001796 RID: 6038
		public static Action<Class106> f_D10B0E5E;

		// Token: 0x04001797 RID: 6039
		public static Action<Class106> f_F059F33B;

		// Token: 0x04001798 RID: 6040
		public static Action f_3BBE0E83;

		// Token: 0x04001799 RID: 6041
		public static Action<Class106> f_A6EEFC5C;

		// Token: 0x0400179A RID: 6042
		public static Action f_3A48FD01;

		// Token: 0x0400179B RID: 6043
		public static Action f_53D17A63;

		// Token: 0x0400179C RID: 6044
		public static Action<Class106> f_40C23E7C;

		// Token: 0x0400179D RID: 6045
		public static Action f_D7AC65C6;

		// Token: 0x0400179E RID: 6046
		public static Action f_8E641FA7;

		// Token: 0x0400179F RID: 6047
		public static Func<Class106, bool> f_271490BB;

		// Token: 0x040017A0 RID: 6048
		public static Func<Class106, bool> f_0ABE2539;

		// Token: 0x040017A1 RID: 6049
		public static Func<Class106, bool> f_C5BC11D8;

		// Token: 0x040017A2 RID: 6050
		public static Func<Class106, bool> f_56B10C1C;

		// Token: 0x040017A3 RID: 6051
		public static Func<Class106, bool> f_57DC222B;

		// Token: 0x040017A4 RID: 6052
		public static Func<Class106, bool> f_287B2ACB;

		// Token: 0x040017A5 RID: 6053
		public static Func<string, string> f_69667A76;

		// Token: 0x040017A6 RID: 6054
		public static Action<Class106> f_595BE26F;

		// Token: 0x040017A7 RID: 6055
		public static Func<ListViewItem.ListViewSubItem, string> f_076A6514;

		// Token: 0x040017A8 RID: 6056
		public static Action<TabLogin> f_246D976B;

		// Token: 0x040017A9 RID: 6057
		public static Action<Class106> f_51B3EA2A;

		// Token: 0x040017AA RID: 6058
		public static Action<Class106> f_718953CE;

		// Token: 0x040017AB RID: 6059
		public static Action<Class106> f_57C57576;

		// Token: 0x040017AC RID: 6060
		public static Func<Class516, bool> f_FC5BCF8E;

		// Token: 0x040017AD RID: 6061
		public static Action<Class106> f_CA9566E1;

		// Token: 0x040017AE RID: 6062
		public static Func<Class516, bool> f_E81F5D40;

		// Token: 0x040017AF RID: 6063
		public static Func<Class516, bool> f_B810975A;

		// Token: 0x040017B0 RID: 6064
		public static Func<Class516, int> f_C1BDD695;

		// Token: 0x040017B1 RID: 6065
		public static Action<Class106> f_CA6B7C0A;

		// Token: 0x040017B2 RID: 6066
		public static Action<Class106> f_7A43AB97;

		// Token: 0x040017B3 RID: 6067
		public static Action<Class106> f_07690B2A;

		// Token: 0x040017B4 RID: 6068
		public static Func<Class106, bool> f_B506B626;

		// Token: 0x040017B5 RID: 6069
		public static Func<Class504, bool> f_F22E9A59;

		// Token: 0x040017B6 RID: 6070
		public static Func<Class106, IEnumerable<Class504>> f_15B98649;

		// Token: 0x040017B7 RID: 6071
		public static Func<Class504, string> f_96007C6E;

		// Token: 0x040017B8 RID: 6072
		public static Func<Class516, bool> f_DA8305E6;

		// Token: 0x040017B9 RID: 6073
		public static Func<Class516, bool> f_12B6E6DA;

		// Token: 0x040017BA RID: 6074
		public static Action<Class106> f_BC3BAA81;

		// Token: 0x040017BB RID: 6075
		public static Func<Class516, bool> f_78300D49;

		// Token: 0x040017BC RID: 6076
		public static Func<Class516, bool> f_190605B8;

		// Token: 0x040017BD RID: 6077
		public static Action<Class106> f_F10F025A;

		// Token: 0x040017BE RID: 6078
		public static Func<Class516, bool> f_2A5FC97E;

		// Token: 0x040017BF RID: 6079
		public static Func<Class516, bool> f_55DD3852;

		// Token: 0x040017C0 RID: 6080
		public static Func<Class516, string> f_5FDC1B1D;

		// Token: 0x040017C1 RID: 6081
		public static Func<Class516, bool> f_D722D58E;

		// Token: 0x040017C2 RID: 6082
		public static Func<Class516, string> f_FC0C2363;

		// Token: 0x040017C3 RID: 6083
		public static Func<Class516, string> f_D7E04640;

		// Token: 0x040017C4 RID: 6084
		public static Action<Class106> f_BA42F02E;

		// Token: 0x040017C5 RID: 6085
		public static Action<Class106> f_E6DE53F3;

		// Token: 0x040017C6 RID: 6086
		public static Action<Class106> f_333A8DF4;

		// Token: 0x040017C7 RID: 6087
		public static Action<Class106> f_9D11A01A;

		// Token: 0x040017C8 RID: 6088
		public static Func<Class106, bool> f_B01AD993;

		// Token: 0x040017C9 RID: 6089
		public static Action<Class106> f_986295BF;

		// Token: 0x040017CA RID: 6090
		public static Action<Class106> f_635452DC;

		// Token: 0x040017CB RID: 6091
		public static Action<Class106> f_5D04E9FE;

		// Token: 0x040017CC RID: 6092
		public static Func<NetworkInterface, bool> f_9D4CD314;

		// Token: 0x040017CD RID: 6093
		public static Func<Class106, double> f_CC3798C7;

		// Token: 0x040017CE RID: 6094
		public static Action<Class106> f_15405D36;

		// Token: 0x040017CF RID: 6095
		public static ScrollEventHandler f_6A8A106F;

		// Token: 0x040017D0 RID: 6096
		public static ListViewEx.SubItemEndEditingEventHandler f_3FBFFBAA;

		// Token: 0x040017D1 RID: 6097
		public static ThreadStart f_34A220CB;

		// Token: 0x040017D2 RID: 6098
		public static Action<Class106> f_97C63FC1;

		// Token: 0x040017D3 RID: 6099
		public static Action<Class106> f_1F6042CA;

		// Token: 0x040017D4 RID: 6100
		public static Action f_96F24B26;

		// Token: 0x040017D5 RID: 6101
		public static Action<Class106> f_8BEC0A92;

		// Token: 0x040017D6 RID: 6102
		public static Action<Class106> f_73549346;

		// Token: 0x040017D7 RID: 6103
		public static Action<Class106> f_9FD14A0A;

		// Token: 0x040017D8 RID: 6104
		public static Func<ListViewItem.ListViewSubItem, string> f_BE265D0A;

		// Token: 0x040017D9 RID: 6105
		public static Action<Class106> f_8165167E;

		// Token: 0x040017DA RID: 6106
		public static Action<Class106> f_BCE07A52;

		// Token: 0x040017DB RID: 6107
		public static Action<Class106> f_A077741D;

		// Token: 0x040017DC RID: 6108
		public static Action<Class106> f_4874A4E7;

		// Token: 0x040017DD RID: 6109
		public static Action<Class106> f_81383C8A;

		// Token: 0x040017DE RID: 6110
		public static Func<Class106, bool> f_8EF3FDC0;

		// Token: 0x040017DF RID: 6111
		public static Action<Class106> f_0AF0E7BA;

		// Token: 0x040017E0 RID: 6112
		public static Action<Class106> f_F68EC3E9;

		// Token: 0x040017E1 RID: 6113
		public static Func<Class106, string> f_144C459D;

		// Token: 0x040017E2 RID: 6114
		public static Func<KeyValuePair<string, List<string>>, bool> f_CF89D490;

		// Token: 0x040017E3 RID: 6115
		public static Func<KeyValuePair<string, List<string>>, string> f_C51F85AB;

		// Token: 0x040017E4 RID: 6116
		public static Func<KeyValuePair<string, List<string>>, List<string>> f_7E8CF6EC;

		// Token: 0x040017E5 RID: 6117
		public static Func<KeyValuePair<string, List<string>>, string> f_18657645;

		// Token: 0x040017E6 RID: 6118
		public static Action<Class106> f_09AE26C5;

		// Token: 0x040017E7 RID: 6119
		public static Func<Class106, double> f_D4D29E60;

		// Token: 0x040017E8 RID: 6120
		public static Func<Class106, bool> f_29F9FDD5;

		// Token: 0x040017E9 RID: 6121
		public static Func<Process, bool> f_7CCE9B92;

		// Token: 0x040017EA RID: 6122
		public static Predicate<Class106> f_E204F712;

		// Token: 0x040017EB RID: 6123
		public static Predicate<Class106> f_E4FBB743;

		// Token: 0x040017EC RID: 6124
		public static Func<Class106, bool> f_8410AFFF;

		// Token: 0x040017ED RID: 6125
		public static Func<Class400, bool> f_14D510A0;

		// Token: 0x040017EE RID: 6126
		public static Func<Class400, bool> f_52DBF27C;

		// Token: 0x040017EF RID: 6127
		public static Action<Class106> f_FD6E47F8;

		// Token: 0x040017F0 RID: 6128
		public static Action<Class400> f_685342A2;

		// Token: 0x040017F1 RID: 6129
		public static Action<Class106> f_AA3EAAE1;

		// Token: 0x040017F2 RID: 6130
		public static Action<Class106> f_BE251C30;

		// Token: 0x040017F3 RID: 6131
		public static Action<Class106> f_BB03DC4D;

		// Token: 0x040017F4 RID: 6132
		public static Action<Class106> f_F9FCD8F3;

		// Token: 0x040017F5 RID: 6133
		public static Action<Class106> f_DA60A8B4;

		// Token: 0x040017F6 RID: 6134
		public static Func<Class106, bool> f_7724A4D6;

		// Token: 0x040017F7 RID: 6135
		public static Action<Class106> f_C772F368;

		// Token: 0x040017F8 RID: 6136
		public static Action<Class106> f_5187B99A;

		// Token: 0x040017F9 RID: 6137
		public static Func<Class106, bool> f_43AAE68F;

		// Token: 0x040017FA RID: 6138
		public static Action<Class106> f_50671D13;

		// Token: 0x040017FB RID: 6139
		public static Action<Class106> f_B6586D52;

		// Token: 0x040017FC RID: 6140
		public static Action<Class106> f_10590D21;

		// Token: 0x040017FD RID: 6141
		public static Action<Class106> f_8CFEBC44;

		// Token: 0x040017FE RID: 6142
		public static Func<Class106, bool> f_0ED999A8;

		// Token: 0x040017FF RID: 6143
		public static Func<Class106, double> f_0C994F9E;

		// Token: 0x04001800 RID: 6144
		public static Action<Class106> f_CD679FA5;

		// Token: 0x04001801 RID: 6145
		public static Func<Class525, int> f_F7794EB1;

		// Token: 0x04001802 RID: 6146
		public static Func<Class106, IEnumerable<Class525>> f_004A8B81;

		// Token: 0x04001803 RID: 6147
		public static Func<Class525, int> f_913F6883;

		// Token: 0x04001804 RID: 6148
		public static Func<Class525, int> f_C60B6C7C;

		// Token: 0x04001805 RID: 6149
		public static Func<Class516, bool> f_4B3ABF8A;

		// Token: 0x04001806 RID: 6150
		public static Func<Class516, bool> f_93F1F964;

		// Token: 0x04001807 RID: 6151
		public static Action<Class106> f_4CD41741;

		// Token: 0x04001808 RID: 6152
		public static Action<Class106> f_D6D04259;

		// Token: 0x04001809 RID: 6153
		public static Action<Class106> f_97E9C793;

		// Token: 0x0400180A RID: 6154
		public static ThreadStart f_EDFB4A86;

		// Token: 0x0400180B RID: 6155
		public static Action<Class106> f_BC0B1D30;

		// Token: 0x0400180C RID: 6156
		public static Action<Class106> f_5EEF92B8;

		// Token: 0x0400180D RID: 6157
		public static Func<Class516, bool> f_F4A0F9DB;

		// Token: 0x0400180E RID: 6158
		public static Action<Class106> f_D5B2465F;

		// Token: 0x0400180F RID: 6159
		public static Action f_3A158B1C;

		// Token: 0x04001810 RID: 6160
		public static Action<Class400> f_2E9E5CFF;

		// Token: 0x04001811 RID: 6161
		public static Func<Class106, bool> f_103DE5F2;

		// Token: 0x04001812 RID: 6162
		public static Action<Class106> f_75D82A92;

		// Token: 0x04001813 RID: 6163
		public static Action<Class106> f_B8AE47D0;

		// Token: 0x04001814 RID: 6164
		public static Action<Class106> f_E906E545;

		// Token: 0x04001815 RID: 6165
		public static Action<Class106> f_BC399287;

		// Token: 0x04001816 RID: 6166
		public static Action<TabLogin> f_AF42F950;

		// Token: 0x04001817 RID: 6167
		public static Action<Class106> f_21E9BCCE;

		// Token: 0x04001818 RID: 6168
		public static Action<Class106> f_16B45ED6;

		// Token: 0x04001819 RID: 6169
		public static Action<Class106> f_25311F76;

		// Token: 0x0400181A RID: 6170
		public static Action<Class106> f_4EB0BC22;

		// Token: 0x0400181B RID: 6171
		public static Action<Class106> f_58FEEF15;

		// Token: 0x0400181C RID: 6172
		public static Action f_50478904;

		// Token: 0x0400181D RID: 6173
		public static Func<Class516, bool> f_21276C61;

		// Token: 0x0400181E RID: 6174
		public static Func<Class516, string> f_EA830743;

		// Token: 0x0400181F RID: 6175
		public static Action<Class400> f_CADC4E58;

		// Token: 0x04001820 RID: 6176
		public static Action<Class106> f_D154CBA1;

		// Token: 0x04001821 RID: 6177
		public static Action<Class400> f_0C4A4109;

		// Token: 0x04001822 RID: 6178
		public static Action<Class106> f_CA7B8AFC;

		// Token: 0x04001823 RID: 6179
		public static Action<Class400> f_EF2A203D;

		// Token: 0x04001824 RID: 6180
		public static Action<Class106> f_41B66B81;

		// Token: 0x04001825 RID: 6181
		public static Func<Class504, bool> f_8C6A3901;

		// Token: 0x04001826 RID: 6182
		public static Action f_79BF9DB9;

		// Token: 0x04001827 RID: 6183
		public static Action<TabLogin> f_D70F7FB4;

		// Token: 0x04001828 RID: 6184
		public static Action<TabLogin> f_C32A07C3;

		// Token: 0x04001829 RID: 6185
		public static Func<Class106, bool> f_5EBB689A;

		// Token: 0x0400182A RID: 6186
		public static Action<Class106> f_BADE359A;

		// Token: 0x0400182B RID: 6187
		public static Action<Class106> f_D9B6445E;

		// Token: 0x0400182C RID: 6188
		public static Action<Class106> f_E586A75D;

		// Token: 0x0400182D RID: 6189
		public static Action<Class106> f_87D4C844;

		// Token: 0x0400182E RID: 6190
		public static Func<Class504, bool> f_E156FE7C;

		// Token: 0x0400182F RID: 6191
		public static Func<Class504, bool> f_1303A247;

		// Token: 0x04001830 RID: 6192
		public static Func<Class106, bool> f_54A4E3CE;

		// Token: 0x04001831 RID: 6193
		public static Func<Class106, bool> f_1D421F50;

		// Token: 0x04001832 RID: 6194
		public static Action<Class106> f_C6397153;

		// Token: 0x04001833 RID: 6195
		public static Action<Class106> f_73BEA7E0;

		// Token: 0x04001834 RID: 6196
		public static Action<Class106> f_63FEA7BA;

		// Token: 0x04001835 RID: 6197
		public static Action<Class106> f_E4AC7422;

		// Token: 0x04001836 RID: 6198
		public static Action<Class106> f_FF950070;

		// Token: 0x04001837 RID: 6199
		public static Action<Class106> f_96CAE34A;

		// Token: 0x04001838 RID: 6200
		public static Func<Class516, bool> f_89E88F3D;

		// Token: 0x04001839 RID: 6201
		public static Action<Class106> f_B9B9A0D3;

		// Token: 0x0400183A RID: 6202
		public static Action<Class106> f_F63788CC;

		// Token: 0x0400183B RID: 6203
		public static Action<Class106> f_8D95E608;
	}

	// Token: 0x0200026C RID: 620
	[CompilerGenerated]
	private sealed class Class404
	{
		// Token: 0x0400183C RID: 6204
		public int int_0;
	}

	// Token: 0x0200026D RID: 621
	[CompilerGenerated]
	private sealed class Class405
	{
		// Token: 0x06002318 RID: 8984 RVA: 0x0010DDC0 File Offset: 0x0010BFC0
		internal void method_0()
		{
			for (int i = 0; i < 15; i++)
			{
				Class516 @class = this.class106_0.Class214_0.IEnumerable_1.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_41)).FirstOrDefault<Class516>();
				if (@class == null)
				{
					break;
				}
				@class.method_9();
				Thread.Sleep(350);
				this.class106_0.method_375("setmetatable(_G, {__index = Rune_FourChoices_Env});\r\n                                              Rune_FourChoices_OnActionItemClicked(" + this.class404_0.int_0.ToString() + ")\r\n                                              Rune_FourChoices_OKClicked()", false);
			}
		}

		// Token: 0x0400183D RID: 6205
		public Class106 class106_0;

		// Token: 0x0400183E RID: 6206
		public GUI.Class404 class404_0;
	}

	// Token: 0x0200026E RID: 622
	[CompilerGenerated]
	private sealed class Class406
	{
		// Token: 0x0600231A RID: 8986 RVA: 0x0010DE58 File Offset: 0x0010C058
		internal void method_0()
		{
			this.gui_0.tabPay.Controls.Add(this.label_0);
			this.gui_0.tabPay.Controls.Add(this.class533_0);
			this.gui_0.tabPay.Controls.Add(this.class533_1);
			this.gui_0.tabPay.Controls.Add(this.button_0);
			this.gui_0.tabPay.Controls.Add(this.button_1);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0010DEEC File Offset: 0x0010C0EC
		internal void method_1(object sender, EventArgs e)
		{
			foreach (object obj in this.gui_0.tabPay.Controls)
			{
				((Control)obj).Show();
			}
			this.label_0.Dispose();
			this.class533_0.Dispose();
			this.class533_1.Dispose();
			this.button_0.Dispose();
			this.button_1.Dispose();
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0010DF84 File Offset: 0x0010C184
		internal void method_2(object sender, EventArgs e)
		{
			this.label_0.Text = "Doing...";
			this.button_0.Enabled = false;
			Action action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action(this.method_3));
			}
			Task.Run(action);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0010DFD4 File Offset: 0x0010C1D4
		internal void method_3()
		{
			try
			{
				string text = Class587.smethod_8(string.Concat(new string[]
				{
					Settings.Default.HomePage,
					"?cmd=changepass&pass=",
					HttpUtility.UrlEncode(this.class533_0.Text),
					"&email=",
					HttpUtility.UrlEncode(this.gui_0.String_2),
					"&newpass=",
					HttpUtility.UrlEncode(this.class533_1.Text)
				}));
				this.label_0.Text = text;
			}
			catch (Exception ex)
			{
				this.label_0.Text = ex.Message;
			}
			finally
			{
				this.button_0.Enabled = true;
			}
		}

		// Token: 0x0400183F RID: 6207
		public GUI gui_0;

		// Token: 0x04001840 RID: 6208
		public Label label_0;

		// Token: 0x04001841 RID: 6209
		public Class533 class533_0;

		// Token: 0x04001842 RID: 6210
		public Class533 class533_1;

		// Token: 0x04001843 RID: 6211
		public Button button_0;

		// Token: 0x04001844 RID: 6212
		public Button button_1;

		// Token: 0x04001845 RID: 6213
		public Action action_0;
	}

	// Token: 0x0200026F RID: 623
	[CompilerGenerated]
	private sealed class Class407
	{
		// Token: 0x04001846 RID: 6214
		public int int_0;
	}

	// Token: 0x02000270 RID: 624
	[CompilerGenerated]
	private sealed class Class408
	{
		// Token: 0x06002320 RID: 8992 RVA: 0x0010E09C File Offset: 0x0010C29C
		internal void method_0()
		{
			string text = "\r\n                                        joinid = " + this.class407_0.int_0.ToString() + "\r\n                                           Guild:AskGuildList4Page(joinid);\r\n\r\n";
			this.class106_0.method_375(text, false);
			Thread.Sleep(1000);
			this.class106_0.method_375("\r\n                                        guicount = Guild:GetGuildNum();\r\n                                        if guicount > 0 then\r\n                                            i = 0;\r\n                                            while i < guicount do\r\n                                                if  Guild:GetGuildInfo(i, 'ID') == joinid then\r\n                                                    Guild:JoinGuild(i)\r\n                                                end\r\n                                                i = i + 1;\r\n                                            end\r\n                                        end\r\n                                     ", false);
		}

		// Token: 0x04001847 RID: 6215
		public Class106 class106_0;

		// Token: 0x04001848 RID: 6216
		public GUI.Class407 class407_0;
	}

	// Token: 0x02000271 RID: 625
	[CompilerGenerated]
	private sealed class Class409
	{
		// Token: 0x06002322 RID: 8994 RVA: 0x0010E0F4 File Offset: 0x0010C2F4
		internal void method_0()
		{
			if (this.class106_0 == null)
			{
				return;
			}
			if (this.class106_0.Class527_0.String_11 == "OFFLINE")
			{
				return;
			}
			IEnumerable<Class106> ienumerable_ = Class106.IEnumerable_0;
			Action<Class106> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class106>(this.method_1));
			}
			ienumerable_.smethod_22<Class106>(action);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00017DF0 File Offset: 0x00015FF0
		internal void method_1(Class106 class106_1)
		{
			class106_1.Class106_2 = this.class106_0;
		}

		// Token: 0x04001849 RID: 6217
		public Class106 class106_0;

		// Token: 0x0400184A RID: 6218
		public Action<Class106> action_0;
	}

	// Token: 0x02000272 RID: 626
	[CompilerGenerated]
	private sealed class Class410
	{
		// Token: 0x06002325 RID: 8997 RVA: 0x00017DFE File Offset: 0x00015FFE
		internal bool method_0(Class516 class516_1)
		{
			return Class501.Dictionary_2.ContainsKey(class516_1.String_4) && Class501.Dictionary_2[class516_1.String_4] >= this.class516_0.Int32_20;
		}

		// Token: 0x0400184B RID: 6219
		public Class516 class516_0;
	}

	// Token: 0x02000273 RID: 627
	[CompilerGenerated]
	private sealed class Class411
	{
		// Token: 0x06002327 RID: 8999 RVA: 0x00017E34 File Offset: 0x00016034
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_3 = this.string_0;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00017E4D File Offset: 0x0001604D
		internal void method_1(Class106 class106_0)
		{
			class106_0.String_23 = this.string_0;
		}

		// Token: 0x0400184C RID: 6220
		public string string_0;
	}

	// Token: 0x02000274 RID: 628
	[CompilerGenerated]
	private sealed class Class412
	{
		// Token: 0x0400184D RID: 6221
		public int int_0;

		// Token: 0x0400184E RID: 6222
		public int int_1;
	}

	// Token: 0x02000275 RID: 629
	[CompilerGenerated]
	private sealed class Class413
	{
		// Token: 0x0600232B RID: 9003 RVA: 0x0010E150 File Offset: 0x0010C350
		internal void method_0()
		{
			Class106 @class = this.class106_0;
			string[] array = new string[7];
			array[0] = "Clear_XSCRIPT();\r\nSet_XSCRIPT_Function_Name('OnGemCarve');\r\nSet_XSCRIPT_ScriptID(800117);\r\nSet_XSCRIPT_Parameter(0, ";
			array[1] = this.class412_0.int_0.ToString();
			array[2] = "); Set_XSCRIPT_Parameter(1, ";
			int num = 3;
			int int_ = this.class412_0.int_1;
			array[num] = int_.ToString();
			array[4] = "); Set_XSCRIPT_Parameter(2, 134);Set_XSCRIPT_Parameter(3, 1);Set_XSCRIPT_Parameter(3, 1);PlayerPackage:GetBagItemNum(";
			array[5] = this.class412_0.int_0.ToString();
			array[6] = ") Set_XSCRIPT_ParamCount(5); Send_XSCRIPT(); ";
			@class.method_375(string.Concat(array), false);
		}

		// Token: 0x0400184F RID: 6223
		public Class106 class106_0;

		// Token: 0x04001850 RID: 6224
		public GUI.Class412 class412_0;
	}

	// Token: 0x02000276 RID: 630
	[CompilerGenerated]
	private sealed class Class414
	{
		// Token: 0x0600232D RID: 9005 RVA: 0x00017E5B File Offset: 0x0001605B
		internal bool method_0(Class516 class516_0)
		{
			return class516_0.String_4.Contains("Scroll") && class516_0.String_5.smethod_26() == this.int_0;
		}

		// Token: 0x04001851 RID: 6225
		public int int_0;
	}

	// Token: 0x02000277 RID: 631
	[CompilerGenerated]
	private sealed class Class415
	{
		// Token: 0x0600232F RID: 9007 RVA: 0x00017E84 File Offset: 0x00016084
		internal void method_0(Class106 class106_0)
		{
			class106_0.String_6 = this.string_0;
		}

		// Token: 0x04001852 RID: 6226
		public string string_0;
	}

	// Token: 0x02000278 RID: 632
	[CompilerGenerated]
	private sealed class Class416
	{
		// Token: 0x06002331 RID: 9009 RVA: 0x0010E1D0 File Offset: 0x0010C3D0
		internal void method_0()
		{
			this.class106_0.method_493("Cần đứng tại Lạc Dương");
			for (int i = 1; i < 10; i++)
			{
				Class516 @class = this.class106_0.Class214_0.IEnumerable_1.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_54));
				if (@class == null)
				{
					return;
				}
				Class516 class2 = this.class106_0.Class214_0.IEnumerable_2.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_55));
				if (class2 == null)
				{
					return;
				}
				this.class106_0.method_375(string.Concat(new string[]
				{
					"Clear_XSCRIPT();\r\n\t\t\tSet_XSCRIPT_Function_Name('DianJin')\r\n\r\n            Set_XSCRIPT_ScriptID(892944)\r\n\r\n            Set_XSCRIPT_Parameter(0, -1);\r\n                        Set_XSCRIPT_Parameter(1, ",
					class2.Int32_11.ToString(),
					");\r\n                        Set_XSCRIPT_Parameter(2, ",
					@class.Int32_11.ToString(),
					");\r\n                        Set_XSCRIPT_Parameter(3, 0);\r\n                        Set_XSCRIPT_ParamCount(4)\r\n\r\n        Send_XSCRIPT(); "
				}), false);
				Thread.Sleep(333);
			}
		}

		// Token: 0x04001853 RID: 6227
		public Class106 class106_0;
	}

	// Token: 0x02000279 RID: 633
	[CompilerGenerated]
	private sealed class Class417
	{
		// Token: 0x06002333 RID: 9011 RVA: 0x0010E2D0 File Offset: 0x0010C4D0
		internal void method_0()
		{
			this.class106_0.method_493("Cần đứng tại Lạc Dương");
			for (int i = 1; i < 10; i++)
			{
				Class516 @class = this.class106_0.Class214_0.IEnumerable_1.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_57));
				if (@class == null)
				{
					return;
				}
				Class516 class2 = this.class106_0.Class214_0.IEnumerable_2.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_58));
				if (class2 == null)
				{
					return;
				}
				this.class106_0.method_375(string.Concat(new string[]
				{
					"Clear_XSCRIPT();\r\n\t\t\tSet_XSCRIPT_Function_Name('DianJin')\r\n\r\n            Set_XSCRIPT_ScriptID(892944)\r\n\r\n            Set_XSCRIPT_Parameter(0, -1);\r\n                        Set_XSCRIPT_Parameter(1, ",
					class2.Int32_11.ToString(),
					");\r\n                        Set_XSCRIPT_Parameter(2, ",
					@class.Int32_11.ToString(),
					");\r\n                        Set_XSCRIPT_Parameter(3, 0);\r\n                        Set_XSCRIPT_ParamCount(4)\r\n\r\n        Send_XSCRIPT(); "
				}), false);
				Thread.Sleep(333);
			}
		}

		// Token: 0x04001854 RID: 6228
		public Class106 class106_0;
	}

	// Token: 0x0200027A RID: 634
	[CompilerGenerated]
	private sealed class Class418
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x00017E92 File Offset: 0x00016092
		internal void method_0()
		{
			this.class106_0.Class512_0.method_35();
		}

		// Token: 0x04001855 RID: 6229
		public Class106 class106_0;
	}

	// Token: 0x0200027B RID: 635
	[CompilerGenerated]
	private sealed class Class419
	{
		// Token: 0x06002337 RID: 9015 RVA: 0x0010E3D0 File Offset: 0x0010C5D0
		internal void method_0()
		{
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_1)
			{
				if (Class501.HashSet_3.Contains(@class.String_2) || Class501.HashSet_2.Contains(@class.String_2) || @class.String_2 == "Long Văn" || @class.String_2 == "Hào Hiệp Ấn" || @class.String_2 == "Ám Khí" || @class.String_2 == "Bang Hội Lệnh Bài")
				{
					@class.method_7();
					Thread.Sleep(150);
				}
			}
		}

		// Token: 0x04001856 RID: 6230
		public Class106 class106_0;
	}

	// Token: 0x0200027C RID: 636
	[CompilerGenerated]
	private sealed class Class420
	{
		// Token: 0x06002339 RID: 9017 RVA: 0x00017EA4 File Offset: 0x000160A4
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			this.class106_0.method_398(true);
		}

		// Token: 0x04001857 RID: 6231
		public Class106 class106_0;
	}

	// Token: 0x0200027D RID: 637
	[CompilerGenerated]
	private sealed class Class421
	{
		// Token: 0x0600233B RID: 9019 RVA: 0x00017EBD File Offset: 0x000160BD
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			this.class106_0.method_398(false);
		}

		// Token: 0x04001858 RID: 6232
		public Class106 class106_0;
	}

	// Token: 0x0200027E RID: 638
	[CompilerGenerated]
	private sealed class Class422
	{
		// Token: 0x0600233D RID: 9021 RVA: 0x00017ED6 File Offset: 0x000160D6
		internal void method_0(Class106 class106_0)
		{
			class106_0.int_21 = this.int_0;
		}

		// Token: 0x04001859 RID: 6233
		public int int_0;
	}

	// Token: 0x0200027F RID: 639
	[CompilerGenerated]
	private sealed class Class423
	{
		// Token: 0x0600233F RID: 9023 RVA: 0x0010E4A4 File Offset: 0x0010C6A4
		internal void method_0(object sender, EventArgs e)
		{
			if (this.gui_0.tabMain.SelectedIndex == 1)
			{
				IEnumerable<Class400> ienumerable_ = Class106.IEnumerable_2;
				Action<Class400> action;
				if ((action = this.action_0) == null)
				{
					action = (this.action_0 = new Action<Class400>(this.method_1));
				}
				ienumerable_.smethod_22<Class400>(action);
				return;
			}
			IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_3;
			Action<Class106> action2;
			if ((action2 = this.action_1) == null)
			{
				action2 = (this.action_1 = new Action<Class106>(this.method_2));
			}
			ienumerable_2.smethod_22<Class106>(action2);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00017EE4 File Offset: 0x000160E4
		internal void method_1(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_0 = this.class106_0.Class527_0.String_11;
			class400_0.method_1(Enum17.GomDo, true);
			class400_0.method_1(Enum17.GomVang, true);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00017F1C File Offset: 0x0001611C
		internal void method_2(Class106 class106_1)
		{
			class106_1.String_19 = this.class106_0.Class527_0.String_11;
			class106_1.method_97(Enum17.GomDo, true);
			class106_1.method_97(Enum17.GomVang, true);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0010E518 File Offset: 0x0010C718
		internal void method_3(object sender, EventArgs e)
		{
			if (this.gui_0.tabMain.SelectedIndex == 1)
			{
				IEnumerable<Class400> ienumerable_ = Class106.IEnumerable_2;
				Action<Class400> action;
				if ((action = this.action_2) == null)
				{
					action = (this.action_2 = new Action<Class400>(this.method_4));
				}
				ienumerable_.smethod_22<Class400>(action);
				return;
			}
			IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_3;
			Action<Class106> action2;
			if ((action2 = this.action_3) == null)
			{
				action2 = (this.action_3 = new Action<Class106>(this.method_5));
			}
			ienumerable_2.smethod_22<Class106>(action2);
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00017F49 File Offset: 0x00016149
		internal void method_4(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_0 = this.class106_0.Class527_0.String_11;
			class400_0.method_1(Enum17.GomKNB, true);
			class400_0.method_1(Enum17.GomDo, true);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00017F81 File Offset: 0x00016181
		internal void method_5(Class106 class106_1)
		{
			class106_1.String_19 = this.class106_0.Class527_0.String_11;
			class106_1.method_97(Enum17.GomKNB, true);
			class106_1.method_97(Enum17.GomDo, true);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0010E58C File Offset: 0x0010C78C
		internal void method_6(object sender, EventArgs e)
		{
			if (this.gui_0.tabMain.SelectedIndex == 1)
			{
				IEnumerable<Class400> ienumerable_ = Class106.IEnumerable_2;
				Action<Class400> action;
				if ((action = this.action_4) == null)
				{
					action = (this.action_4 = new Action<Class400>(this.method_7));
				}
				ienumerable_.smethod_22<Class400>(action);
				return;
			}
			IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_3;
			Action<Class106> action2;
			if ((action2 = this.action_5) == null)
			{
				action2 = (this.action_5 = new Action<Class106>(this.method_8));
			}
			ienumerable_2.smethod_22<Class106>(action2);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00017FAE File Offset: 0x000161AE
		internal void method_7(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_0 = this.class106_0.Class527_0.String_11;
			class400_0.method_1(Enum17.DuaTangBaoDo, true);
			class400_0.method_1(Enum17.GomDo, true);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00017FE6 File Offset: 0x000161E6
		internal void method_8(Class106 class106_1)
		{
			class106_1.String_19 = this.class106_0.Class527_0.String_11;
			class106_1.method_97(Enum17.DuaTangBaoDo, true);
			class106_1.method_97(Enum17.GomDo, true);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0010E600 File Offset: 0x0010C800
		internal void method_9(object sender, EventArgs e)
		{
			if (this.gui_0.tabMain.SelectedIndex == 1)
			{
				IEnumerable<Class400> ienumerable_ = Class106.IEnumerable_2;
				Action<Class400> action;
				if ((action = this.action_6) == null)
				{
					action = (this.action_6 = new Action<Class400>(this.method_10));
				}
				ienumerable_.smethod_22<Class400>(action);
				return;
			}
			IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_3;
			Action<Class106> action2;
			if ((action2 = this.action_7) == null)
			{
				action2 = (this.action_7 = new Action<Class106>(this.method_11));
			}
			ienumerable_2.smethod_22<Class106>(action2);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00018013 File Offset: 0x00016213
		internal void method_10(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_1 = this.class106_0.Class527_0.String_11;
			class400_0.method_1(Enum17.ChiaDo, true);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00018042 File Offset: 0x00016242
		internal void method_11(Class106 class106_1)
		{
			class106_1.String_20 = this.class106_0.Class527_0.String_11;
			class106_1.method_97(Enum17.ChiaDo, true);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0010E674 File Offset: 0x0010C874
		internal void method_12(object sender, EventArgs e)
		{
			if (this.gui_0.tabMain.SelectedIndex == 1)
			{
				IEnumerable<Class400> ienumerable_ = Class106.IEnumerable_2;
				Action<Class400> action;
				if ((action = this.action_8) == null)
				{
					action = (this.action_8 = new Action<Class400>(this.method_13));
				}
				ienumerable_.smethod_22<Class400>(action);
				return;
			}
			IEnumerable<Class106> ienumerable_2 = Class106.IEnumerable_3;
			Action<Class106> action2;
			if ((action2 = this.action_9) == null)
			{
				action2 = (this.action_9 = new Action<Class106>(this.method_14));
			}
			ienumerable_2.smethod_22<Class106>(action2);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00018066 File Offset: 0x00016266
		internal void method_13(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_2 = this.class106_0.Class527_0.String_11;
			class400_0.method_1(Enum17.TangBachHoaHuongNang, true);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00018095 File Offset: 0x00016295
		internal void method_14(Class106 class106_1)
		{
			class106_1.String_5 = this.class106_0.Class527_0.String_11;
			class106_1.method_97(Enum17.TangBachHoaHuongNang, true);
		}

		// Token: 0x0400185A RID: 6234
		public Class106 class106_0;

		// Token: 0x0400185B RID: 6235
		public GUI gui_0;

		// Token: 0x0400185C RID: 6236
		public Action<Class400> action_0;

		// Token: 0x0400185D RID: 6237
		public Action<Class106> action_1;

		// Token: 0x0400185E RID: 6238
		public Action<Class400> action_2;

		// Token: 0x0400185F RID: 6239
		public Action<Class106> action_3;

		// Token: 0x04001860 RID: 6240
		public Action<Class400> action_4;

		// Token: 0x04001861 RID: 6241
		public Action<Class106> action_5;

		// Token: 0x04001862 RID: 6242
		public Action<Class400> action_6;

		// Token: 0x04001863 RID: 6243
		public Action<Class106> action_7;

		// Token: 0x04001864 RID: 6244
		public Action<Class400> action_8;

		// Token: 0x04001865 RID: 6245
		public Action<Class106> action_9;
	}

	// Token: 0x02000280 RID: 640
	[CompilerGenerated]
	private sealed class Class424
	{
		// Token: 0x0600234F RID: 9039 RVA: 0x000180B9 File Offset: 0x000162B9
		internal void method_0(object sender, EventArgs e)
		{
			if (GUI.GUI_0 != null)
			{
				GUI.GUI_0.method_34(this.string_0);
			}
		}

		// Token: 0x04001866 RID: 6246
		public string string_0;
	}

	// Token: 0x02000281 RID: 641
	[CompilerGenerated]
	private sealed class Class425
	{
		// Token: 0x06002351 RID: 9041 RVA: 0x000180D2 File Offset: 0x000162D2
		internal void method_0(object sender, EventArgs e)
		{
			GUI.GUI_0.method_35(this.string_0, this.string_1);
		}

		// Token: 0x04001867 RID: 6247
		public string string_0;

		// Token: 0x04001868 RID: 6248
		public string string_1;
	}

	// Token: 0x02000282 RID: 642
	[CompilerGenerated]
	private sealed class Class426
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x000180EA File Offset: 0x000162EA
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_1 = this.string_0;
			class400_0.method_1(Enum17.ChiaDo, true);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0010E6E8 File Offset: 0x0010C8E8
		internal void method_1(Class106 class106_0)
		{
			if (string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			class106_0.String_20 = this.string_0;
			class106_0.method_97(Enum17.ChiaDo, true);
			class106_0.method_493("Chia đồ từ máy khác ← " + this.string_0);
		}

		// Token: 0x04001869 RID: 6249
		public string string_0;
	}

	// Token: 0x02000283 RID: 643
	[CompilerGenerated]
	private sealed class Class427
	{
		// Token: 0x06002356 RID: 9046 RVA: 0x0010E740 File Offset: 0x0010C940
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.String_0 = this.string_0;
			class400_0.method_1(Enum17.GomDo, true);
			if (this.string_1 == "knb")
			{
				class400_0.method_1(Enum17.GomKNB, true);
				return;
			}
			if (this.string_1 == "tbd")
			{
				class400_0.method_1(Enum17.DuaTangBaoDo, true);
				return;
			}
			class400_0.method_1(Enum17.GomVang, true);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0010E7B8 File Offset: 0x0010C9B8
		internal void method_1(Class106 class106_0)
		{
			if (string.Equals(class106_0.Class527_0.String_11, this.string_0, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			class106_0.String_19 = this.string_0;
			class106_0.method_97(Enum17.GomDo, true);
			if (this.string_1 == "knb")
			{
				class106_0.method_97(Enum17.GomKNB, true);
			}
			else if (this.string_1 == "tbd")
			{
				class106_0.method_97(Enum17.DuaTangBaoDo, true);
			}
			else
			{
				class106_0.method_97(Enum17.GomVang, true);
			}
			class106_0.method_493("Gom máy khác → " + this.string_0);
		}

		// Token: 0x0400186A RID: 6250
		public string string_0;

		// Token: 0x0400186B RID: 6251
		public string string_1;
	}

	// Token: 0x02000284 RID: 644
	[CompilerGenerated]
	private sealed class Class428
	{
		// Token: 0x06002359 RID: 9049 RVA: 0x0001810F File Offset: 0x0001630F
		internal byte method_0(int int_1)
		{
			return Convert.ToByte(this.string_0.Split(new char[] { '\n' })[1].Trim().Replace(" ", "").Substring(int_1 * 2, 2), 16);
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0001814D File Offset: 0x0001634D
		internal void method_1()
		{
			Thread.CurrentThread.IsBackground = true;
			for (;;)
			{
				Task.Run(new Action(new GUI.Class429
				{
					class428_0 = this,
					tcpClient_0 = this.tcpListener_0.AcceptTcpClient()
				}.method_0));
			}
		}

		// Token: 0x0400186C RID: 6252
		public string string_0;

		// Token: 0x0400186D RID: 6253
		public TcpListener tcpListener_0;

		// Token: 0x0400186E RID: 6254
		public string string_1;

		// Token: 0x0400186F RID: 6255
		public int int_0;
	}

	// Token: 0x02000285 RID: 645
	[CompilerGenerated]
	private sealed class Class429
	{
		// Token: 0x0600235C RID: 9052 RVA: 0x00018189 File Offset: 0x00016389
		internal void method_0()
		{
			GUI.smethod_10(this.tcpClient_0, this.class428_0.string_1, this.class428_0.int_0);
		}

		// Token: 0x04001870 RID: 6256
		public TcpClient tcpClient_0;

		// Token: 0x04001871 RID: 6257
		public GUI.Class428 class428_0;
	}

	// Token: 0x02000286 RID: 646
	[CompilerGenerated]
	private sealed class Class430
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x000181AC File Offset: 0x000163AC
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_375("Player:ChangePVPMode(" + this.int_0.ToString() + ");", false);
		}

		// Token: 0x04001872 RID: 6258
		public int int_0;
	}

	// Token: 0x02000287 RID: 647
	[CompilerGenerated]
	private sealed class Class431
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x0010E858 File Offset: 0x0010CA58
		internal void method_0()
		{
			this.class106_0.method_375(string.Format("LifeAbility:Do_Combine({0},{1},0,100)", this.int_0, this.int_1), false);
			Thread.Sleep(100);
			this.class106_0.method_375(string.Format("LifeAbility:Do_Combine({0},{1},0,100)", this.int_0, this.int_1), false);
			Thread.Sleep(300);
			this.class106_0.method_375("setmetatable(_G, {__index = LoginSelectServerQuest_Env}); if this:IsVisible() then SelectServerQuest_Bn1Click(); end", false);
		}

		// Token: 0x04001873 RID: 6259
		public Class106 class106_0;

		// Token: 0x04001874 RID: 6260
		public int int_0;

		// Token: 0x04001875 RID: 6261
		public int int_1;
	}

	// Token: 0x02000288 RID: 648
	[CompilerGenerated]
	private sealed class Class432
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x0010E8E0 File Offset: 0x0010CAE0
		internal void method_0()
		{
			this.class431_0.class106_0.method_375(string.Format("LifeAbility:Do_Combine({0},{1},{2},{3},{4},{5},1)", new object[]
			{
				this.list_0[0],
				this.list_0[1],
				this.list_0[2],
				this.list_0[3],
				this.list_0[4],
				this.class431_0.int_1
			}), false);
			Thread.Sleep(300);
			this.class431_0.class106_0.method_375("setmetatable(_G, {__index = LoginSelectServerQuest_Env}); if this:IsVisible() then SelectServerQuest_Bn1Click(); end", false);
		}

		// Token: 0x04001876 RID: 6262
		public List<int> list_0;

		// Token: 0x04001877 RID: 6263
		public GUI.Class431 class431_0;
	}

	// Token: 0x02000289 RID: 649
	[CompilerGenerated]
	private sealed class Class433
	{
		// Token: 0x06002364 RID: 9060 RVA: 0x000181CF File Offset: 0x000163CF
		internal void method_0()
		{
			this.class106_0.method_219();
		}

		// Token: 0x04001878 RID: 6264
		public Class106 class106_0;
	}

	// Token: 0x0200028A RID: 650
	[CompilerGenerated]
	private sealed class Class434
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x0010E9A8 File Offset: 0x0010CBA8
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_8)
			{
				@class.method_7();
				Thread.Sleep(333);
				this.class106_0.method_375("PlayerShop:RetackItem('item')", false);
				Thread.Sleep(333);
			}
		}

		// Token: 0x04001879 RID: 6265
		public Class106 class106_0;
	}

	// Token: 0x0200028B RID: 651
	[CompilerGenerated]
	private sealed class Class435
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x000181DC File Offset: 0x000163DC
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.NangTamPhap, !this.toolStripMenuItem_0.Checked);
			class106_0.method_99(new Enum17[] { Enum17.Quyen3Len30 });
			class106_0.Int32_64 = Class531.smethod_18(this.toolStripMenuItem_0.Text);
		}

		// Token: 0x0400187A RID: 6266
		public ToolStripMenuItem toolStripMenuItem_0;
	}

	// Token: 0x0200028C RID: 652
	[CompilerGenerated]
	private sealed class Class436
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x0010EA30 File Offset: 0x0010CC30
		internal void method_0()
		{
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_8)
			{
				if (Class226.Dictionary_0.ContainsKey(@class.String_1))
				{
					int num = Class226.Dictionary_0[@class.String_1];
					this.class106_0.method_399(@class.String_4, @class.Int32_9);
					Thread.Sleep(1000);
					this.class106_0.method_375("PlayerShop:UpStall('item'," + (num * @class.Int32_10).ToString() + ");", false);
					Thread.Sleep(1000);
					this.class106_0.method_493(string.Concat(new string[]
					{
						"Đã treo ",
						@class.String_1,
						" x",
						@class.Int32_10.ToString(),
						" giá ",
						(Class226.Dictionary_0[@class.String_1] * @class.Int32_10).ToString()
					}));
				}
			}
			this.class106_0.method_493("Treo xong rổi nhá");
		}

		// Token: 0x0400187B RID: 6267
		public Class106 class106_0;
	}

	// Token: 0x0200028D RID: 653
	[CompilerGenerated]
	private sealed class Class437
	{
		// Token: 0x0600236C RID: 9068 RVA: 0x0010EB8C File Offset: 0x0010CD8C
		internal void method_0(Class106 class106_0)
		{
			if (this.listViewItem_0.Tag == null)
			{
				return;
			}
			string text = this.listViewItem_0.Tag as string;
			if (text != null && text != null)
			{
				switch (text.Length)
				{
				case 2:
				{
					char c = text[1];
					if (c <= '4')
					{
						if (c != '2')
						{
							if (c != '4')
							{
								return;
							}
							if (!(text == "x4"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_12 = this.listViewItem_0.Checked;
							return;
						}
						else
						{
							if (!(text == "x2"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_23 = this.listViewItem_0.Checked;
							return;
						}
					}
					else if (c != 'm')
					{
						if (c != 'p')
						{
							return;
						}
						if (!(text == "mp"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_8 = this.listViewItem_0.Checked;
						return;
					}
					else
					{
						if (!(text == "nm"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_9 = this.listViewItem_0.Checked;
						return;
					}
					break;
				}
				case 3:
					if (!(text == "pet"))
					{
						return;
					}
					class106_0.Class264_0.Boolean_25 = this.listViewItem_0.Checked;
					return;
				case 4:
				{
					char c = text[0];
					if (c != 'l')
					{
						if (c != 'p')
						{
							if (c != 'x')
							{
								return;
							}
							if (!(text == "x2x3"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_15 = this.listViewItem_0.Checked;
							return;
						}
						else
						{
							if (!(text == "pick"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_16 = this.listViewItem_0.Checked;
							return;
						}
					}
					else
					{
						if (!(text == "lure"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_18 = this.listViewItem_0.Checked;
						return;
					}
					break;
				}
				case 5:
				{
					char c = text[0];
					if (c != 'f')
					{
						if (c != 'l')
						{
							return;
						}
						if (!(text == "lvlup"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_22 = this.listViewItem_0.Checked;
						return;
					}
					else
					{
						if (!(text == "fight"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_27 = this.listViewItem_0.Checked;
						return;
					}
					break;
				}
				case 6:
					if (!(text == "attack"))
					{
						return;
					}
					class106_0.Class264_0.Boolean_19 = this.listViewItem_0.Checked;
					return;
				case 7:
				{
					char c = text[0];
					if (c <= 'h')
					{
						if (c != 'g')
						{
							if (c != 'h')
							{
								return;
							}
							if (!(text == "haiduoc"))
							{
								return;
							}
							class106_0.method_97(Enum17.HaiDuoc, this.listViewItem_0.Checked);
							return;
						}
						else
						{
							if (!(text == "giacong"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_11 = this.listViewItem_0.Checked;
							return;
						}
					}
					else if (c != 'm')
					{
						if (c != 'o')
						{
							if (c != 't')
							{
								return;
							}
							if (!(text == "thuthap"))
							{
								return;
							}
							class106_0.method_97(Enum17.ThuThap, this.listViewItem_0.Checked);
							return;
						}
						else
						{
							if (!(text == "onlypet"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_20 = this.listViewItem_0.Checked;
							return;
						}
					}
					else
					{
						if (!(text == "muangoc"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_28 = this.listViewItem_0.Checked;
						return;
					}
					break;
				}
				case 8:
				{
					char c = text[0];
					if (c <= 'c')
					{
						if (c != 'b')
						{
							if (c != 'c')
							{
								return;
							}
							if (!(text == "comeback"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_10 = this.listViewItem_0.Checked;
							return;
						}
						else
						{
							if (!(text == "baoinbox"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_37 = this.listViewItem_0.Checked;
							return;
						}
					}
					else if (c != 'k')
					{
						if (c != 'p')
						{
							if (c != 'q')
							{
								return;
							}
							if (!(text == "quayvong"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_21 = this.listViewItem_0.Checked;
							return;
						}
						else
						{
							if (!(text == "picklist"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_26 = this.listViewItem_0.Checked;
							return;
						}
					}
					else
					{
						if (!(text == "khaithac"))
						{
							return;
						}
						class106_0.method_97(Enum17.KhaiThac, this.listViewItem_0.Checked);
					}
					break;
				}
				case 9:
					if (!(text == "cankhonho"))
					{
						return;
					}
					class106_0.Class264_0.Boolean_17 = this.listViewItem_0.Checked;
					return;
				case 10:
				{
					char c = text[1];
					if (c <= 'h')
					{
						if (c != 'e')
						{
							if (c != 'h')
							{
								return;
							}
							if (!(text == "khaikhoang"))
							{
								return;
							}
							class106_0.method_97(Enum17.KhaiKhoang, this.listViewItem_0.Checked);
							return;
						}
						else
						{
							if (!(text == "keeponline"))
							{
								return;
							}
							class106_0.Class264_0.Boolean_14 = this.listViewItem_0.Checked;
							return;
						}
					}
					else if (c != 't')
					{
						if (c != 'u')
						{
							return;
						}
						if (!(text == "tulinhngoc"))
						{
							return;
						}
						class106_0.Class264_0.Boolean_24 = this.listViewItem_0.Checked;
						return;
					}
					else
					{
						if (!(text == "attacklist"))
						{
							return;
						}
						class106_0.Boolean_51 = this.listViewItem_0.Checked;
						return;
					}
					break;
				}
				case 11:
					break;
				case 12:
					if (!(text == "khongbatlich"))
					{
						return;
					}
					class106_0.Class264_0.Boolean_35 = this.listViewItem_0.Checked;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0400187C RID: 6268
		public ListViewItem listViewItem_0;
	}

	// Token: 0x0200028E RID: 654
	[CompilerGenerated]
	private sealed class Class438
	{
		// Token: 0x0600236E RID: 9070 RVA: 0x0001821B File Offset: 0x0001641B
		internal void method_0(Class525 class525_0)
		{
			if (class525_0.String_0 == this.itemCheckedEventArgs_0.Item.Text)
			{
				class525_0.Boolean_1 = this.itemCheckedEventArgs_0.Item.Checked;
			}
		}

		// Token: 0x0400187D RID: 6269
		public ItemCheckedEventArgs itemCheckedEventArgs_0;

		// Token: 0x0400187E RID: 6270
		public Action<Class525> action_0;
	}

	// Token: 0x0200028F RID: 655
	[CompilerGenerated]
	private sealed class Class439
	{
		// Token: 0x06002370 RID: 9072 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
		internal void method_0(Class106 class106_0)
		{
			foreach (Class525 @class in class106_0.List_6)
			{
				if (@class.Int32_1 == this.class525_0.Int32_1)
				{
					@class.Boolean_0 = this.class525_0.Boolean_0;
				}
			}
		}

		// Token: 0x0400187F RID: 6271
		public Class525 class525_0;
	}

	// Token: 0x02000290 RID: 656
	[CompilerGenerated]
	private sealed class Class440
	{
		// Token: 0x06002372 RID: 9074 RVA: 0x00018250 File Offset: 0x00016450
		internal string method_0(Class106 class106_0)
		{
			return class106_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text;
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00018250 File Offset: 0x00016450
		internal string method_1(Class106 class106_0)
		{
			return class106_0.ListViewItem_0.SubItems[this.columnClickEventArgs_0.Column].Text;
		}

		// Token: 0x04001880 RID: 6272
		public ColumnClickEventArgs columnClickEventArgs_0;
	}

	// Token: 0x02000291 RID: 657
	[CompilerGenerated]
	private sealed class Class441
	{
		// Token: 0x06002375 RID: 9077 RVA: 0x00018272 File Offset: 0x00016472
		internal bool method_0(Class106 class106_0)
		{
			return class106_0.Class527_0.String_11 == this.string_0;
		}

		// Token: 0x04001881 RID: 6273
		public string string_0;
	}

	// Token: 0x02000292 RID: 658
	[CompilerGenerated]
	private sealed class Class442
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x0001828A File Offset: 0x0001648A
		internal bool method_0(Enum17 enum17_0)
		{
			return !this.class400_0.HashSet_0.Contains(enum17_0);
		}

		// Token: 0x04001882 RID: 6274
		public Class400 class400_0;

		// Token: 0x04001883 RID: 6275
		public Func<Enum17, bool> func_0;
	}

	// Token: 0x02000293 RID: 659
	[CompilerGenerated]
	private sealed class Class443
	{
		// Token: 0x06002379 RID: 9081 RVA: 0x000182A0 File Offset: 0x000164A0
		internal bool method_0(Enum17 enum17_0)
		{
			return !this.class106_0.List_5.Contains(enum17_0);
		}

		// Token: 0x04001884 RID: 6276
		public Class106 class106_0;

		// Token: 0x04001885 RID: 6277
		public Func<Enum17, bool> func_0;
	}

	// Token: 0x02000294 RID: 660
	[CompilerGenerated]
	private sealed class Class444
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x0010F118 File Offset: 0x0010D318
		internal void method_0(object sender, EventArgs e)
		{
			IEnumerable<Class106> ienumerable_ = Class106.IEnumerable_3;
			Action<Class106> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class106>(this.method_1));
			}
			ienumerable_.smethod_22<Class106>(action);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000182B6 File Offset: 0x000164B6
		internal void method_1(Class106 class106_1)
		{
			class106_1.method_370(this.class106_0.Class527_0.Byte_0);
		}

		// Token: 0x04001886 RID: 6278
		public Class106 class106_0;

		// Token: 0x04001887 RID: 6279
		public Action<Class106> action_0;
	}

	// Token: 0x02000295 RID: 661
	[CompilerGenerated]
	private sealed class Class445
	{
		// Token: 0x0600237E RID: 9086 RVA: 0x000182CE File Offset: 0x000164CE
		internal void method_0(List<string> list_1)
		{
			list_1.RemoveAll(new Predicate<string>(this.list_0.Contains));
		}

		// Token: 0x04001888 RID: 6280
		public List<string> list_0;
	}

	// Token: 0x02000296 RID: 662
	[CompilerGenerated]
	private sealed class Class446
	{
		// Token: 0x06002380 RID: 9088 RVA: 0x000182E9 File Offset: 0x000164E9
		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Contains(this.class400_0.String_17);
		}

		// Token: 0x04001889 RID: 6281
		public Class400 class400_0;
	}

	// Token: 0x02000297 RID: 663
	[CompilerGenerated]
	private sealed class Class447
	{
		// Token: 0x06002382 RID: 9090 RVA: 0x00018302 File Offset: 0x00016502
		internal void method_0()
		{
			Class534.smethod_15(this.class106_0);
			this.class106_0.Boolean_48 = true;
		}

		// Token: 0x0400188A RID: 6282
		public Class106 class106_0;
	}

	// Token: 0x02000298 RID: 664
	[CompilerGenerated]
	private sealed class Class448
	{
		// Token: 0x06002384 RID: 9092 RVA: 0x0001831B File Offset: 0x0001651B
		internal bool method_0(Class106 class106_0)
		{
			return class106_0.Process_0.Id == this.process_0.Id;
		}

		// Token: 0x0400188B RID: 6283
		public Process process_0;
	}

	// Token: 0x02000299 RID: 665
	[CompilerGenerated]
	private sealed class Class449
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x0010F150 File Offset: 0x0010D350
		internal bool method_0(Class106 class106_0)
		{
			return (class106_0.String_22.Equals(this.class400_0.String_24, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(this.class400_0.String_24)) && class106_0.List_17.Count == 0 && !class106_0.Boolean_10 && (class106_0.Class527_0.Boolean_12 || class106_0.Class527_0.Boolean_36 || class106_0.Class527_0.Boolean_43 || class106_0.Class527_0.Boolean_11);
		}

		// Token: 0x0400188C RID: 6284
		public Class400 class400_0;
	}

	// Token: 0x0200029A RID: 666
	[CompilerGenerated]
	private sealed class Class450
	{
		// Token: 0x06002388 RID: 9096 RVA: 0x0010F1D4 File Offset: 0x0010D3D4
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DatDoiAcTac, !this.toolStripMenuItem_0.Checked);
			int num = this.toolStripMenuItem_0.Tag.ToString().smethod_26();
			if (num == 0)
			{
				class106_0.method_218();
				return;
			}
			class106_0.Int32_70 = num;
		}

		// Token: 0x0400188D RID: 6285
		public ToolStripMenuItem toolStripMenuItem_0;
	}

	// Token: 0x0200029B RID: 667
	[CompilerGenerated]
	private sealed class Class451
	{
		// Token: 0x0600238A RID: 9098 RVA: 0x00018335 File Offset: 0x00016535
		internal void method_0(Class106 class106_0)
		{
			class106_0.Int32_35 = this.toolStripMenuItem_0.Text.smethod_26();
		}

		// Token: 0x0400188E RID: 6286
		public ToolStripMenuItem toolStripMenuItem_0;
	}

	// Token: 0x0200029C RID: 668
	[CompilerGenerated]
	private sealed class Class452
	{
		// Token: 0x0600238C RID: 9100 RVA: 0x0001834D File Offset: 0x0001654D
		internal void method_0(Class106 class106_0)
		{
			class106_0.Int32_38 = this.int_0;
		}

		// Token: 0x0400188F RID: 6287
		public int int_0;
	}

	// Token: 0x0200029D RID: 669
	[CompilerGenerated]
	private sealed class Class453
	{
		// Token: 0x0600238E RID: 9102 RVA: 0x0001835B File Offset: 0x0001655B
		internal void method_0(Class400 class400_0)
		{
			class400_0.String_21 = "wait";
			class400_0.method_1(Enum17.DatDoiAcBa, true);
			class400_0.String_4 = this.toolStripMenuItem_0.Tag.ToString();
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0010F220 File Offset: 0x0010D420
		internal void method_1(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DatDoiAcBa, true);
			List<Class106> list_ = class106_0.List_21;
			Action<Class106> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class106>(this.method_2));
			}
			list_.ForEach(action);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00018387 File Offset: 0x00016587
		internal void method_2(Class106 class106_0)
		{
			class106_0.Int32_40 = this.int_0;
		}

		// Token: 0x04001890 RID: 6288
		public ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001891 RID: 6289
		public int int_0;

		// Token: 0x04001892 RID: 6290
		public Action<Class106> action_0;
	}

	// Token: 0x0200029E RID: 670
	[CompilerGenerated]
	private sealed class Class454
	{
		// Token: 0x06002392 RID: 9106 RVA: 0x00018395 File Offset: 0x00016595
		internal void method_0(Class106 class106_0)
		{
			class106_0.Int32_5 = (this.object_0 as ToolStripMenuItem).Tag.ToString().smethod_26();
			class106_0.method_97(Enum17.NangBaoChauLenhBai, true);
		}

		// Token: 0x04001893 RID: 6291
		public object object_0;
	}

	// Token: 0x0200029F RID: 671
	[CompilerGenerated]
	private sealed class Class455
	{
		// Token: 0x06002394 RID: 9108 RVA: 0x000183C3 File Offset: 0x000165C3
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_375(this.string_0, false);
		}

		// Token: 0x04001894 RID: 6292
		public string string_0;
	}

	// Token: 0x020002A0 RID: 672
	[CompilerGenerated]
	private sealed class Class456
	{
		// Token: 0x06002396 RID: 9110 RVA: 0x0010F260 File Offset: 0x0010D460
		internal void method_0()
		{
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_0)
			{
				if (Class226.Dictionary_0.ContainsKey(@class.String_1))
				{
					int num = Class226.Dictionary_0[@class.String_1];
					@class.method_8();
					Thread.Sleep(1000);
					this.class106_0.method_375("StallSale:ReferItemPrice(" + (num * @class.Int32_10).ToString() + ");", false);
					Thread.Sleep(1000);
					this.class106_0.method_493(string.Concat(new string[]
					{
						"Đã treo ",
						@class.String_1,
						" x",
						@class.Int32_10.ToString(),
						" giá ",
						(Class226.Dictionary_0[@class.String_1] * @class.Int32_10).ToString()
					}));
					this.class106_0.method_375("setmetatable(_G, {__index = InputMoney_Env});  this:Hide();", false);
					Thread.Sleep(350);
				}
			}
			this.class106_0.method_493("Treo xong rổi nhá");
		}

		// Token: 0x04001895 RID: 6293
		public Class106 class106_0;
	}

	// Token: 0x020002A1 RID: 673
	[CompilerGenerated]
	private sealed class Class457
	{
		// Token: 0x06002398 RID: 9112 RVA: 0x0010F3C4 File Offset: 0x0010D5C4
		internal void method_0(Class106 class106_0)
		{
			foreach (Class525 @class in class106_0.List_6.OrderBy<Class525, int>(new Func<Class525, int>(GUI.Class403.f_A642BF9F.method_126)))
			{
				this.dictionary_0[@class.Int32_1] = @class;
			}
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0010F444 File Offset: 0x0010D644
		internal void method_1()
		{
			this.gui_0.lvSkill.Items.Clear();
			try
			{
				this.gui_0.lvSkill.AllItems.Clear();
			}
			catch
			{
			}
			List<ListViewItem> list = new List<ListViewItem>();
			foreach (Class525 @class in Class106.IEnumerable_1.SelectMany<Class106, Class525>(new Func<Class106, IEnumerable<Class525>>(GUI.Class403.f_A642BF9F.method_127)).smethod_9<Class525, int>(new Func<Class525, int>(GUI.Class403.f_A642BF9F.method_128)).OrderBy<Class525, int>(new Func<Class525, int>(GUI.Class403.f_A642BF9F.method_129)))
			{
				if (!string.IsNullOrEmpty(@class.String_0))
				{
					if (!this.dictionary_0.ContainsKey(@class.Int32_1))
					{
						this.dictionary_0[@class.Int32_1] = @class;
					}
					ListViewItem listViewItem = new ListViewItem(@class.String_0);
					listViewItem.Tag = @class;
					listViewItem.Text = @class.String_0;
					listViewItem.SubItems.Add(@class.Boolean_0 ? "X" : "");
					listViewItem.SubItems.Add("0");
					if (Class106.Dictionary_0.ContainsKey(@class.Int32_1))
					{
						listViewItem.SubItems[2].Text = Class106.Dictionary_0[@class.Int32_1].ToString();
					}
					listViewItem.Checked = @class.Boolean_1;
					list.Add(listViewItem);
				}
			}
			this.gui_0.lvSkill.Items.AddRange(list.ToArray());
		}

		// Token: 0x04001896 RID: 6294
		public Dictionary<int, Class525> dictionary_0;

		// Token: 0x04001897 RID: 6295
		public GUI gui_0;
	}

	// Token: 0x020002A2 RID: 674
	[CompilerGenerated]
	private sealed class Class458
	{
		// Token: 0x0600239B RID: 9115 RVA: 0x0010F62C File Offset: 0x0010D82C
		internal void method_0()
		{
			Class516 @class = this.class106_0.Class214_0.IEnumerable_1.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_131));
			if (@class != null)
			{
				this.class106_0.method_261(20);
				Thread.Sleep(1000);
				Class516 class2 = this.class106_0.Class214_0.IEnumerable_1.FirstOrDefault<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_132));
				if (class2 != null)
				{
					for (int i = 0; i < @class.Int32_10; i++)
					{
						this.class106_0.method_375("Clear_XSCRIPT();\r\n                            Set_XSCRIPT_Function_Name( 'RL_StarLevelup' );\r\n                            Set_XSCRIPT_ScriptID( 880001 );\r\n                            Set_XSCRIPT_Parameter( 0," + class2.Int32_11.ToString() + ");\r\n                            Set_XSCRIPT_Parameter( 1,1);\r\n                            Set_XSCRIPT_ParamCount( 2 );\r\n                            Send_XSCRIPT();", false);
					}
					class2.method_8();
				}
			}
		}

		// Token: 0x04001898 RID: 6296
		public Class106 class106_0;
	}

	// Token: 0x020002A3 RID: 675
	[CompilerGenerated]
	private sealed class Class459
	{
		// Token: 0x0600239D RID: 9117 RVA: 0x000183D2 File Offset: 0x000165D2
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.TangSuaChua, true);
			Class226.Int32_34 = this.int_0;
		}

		// Token: 0x04001899 RID: 6297
		public int int_0;
	}

	// Token: 0x020002A4 RID: 676
	[CompilerGenerated]
	private sealed class Class460
	{
		// Token: 0x0600239F RID: 9119 RVA: 0x000183EB File Offset: 0x000165EB
		internal void method_0()
		{
			GUI.smethod_3(this.ienumerable_0.ToList<Class106>());
		}

		// Token: 0x0400189A RID: 6298
		public IEnumerable<Class106> ienumerable_0;
	}

	// Token: 0x020002A5 RID: 677
	[CompilerGenerated]
	private sealed class Class461
	{
		// Token: 0x060023A1 RID: 9121 RVA: 0x0010F704 File Offset: 0x0010D904
		internal void method_0()
		{
			this.class106_0.method_374("setmetatable(_G, {__index = FreshMan_GamePass_Env})");
			for (int i = 1; i < 101; i++)
			{
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Award_GetAward({0}, 1)", i));
			}
			for (int j = 1; j < 101; j++)
			{
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Mission_GetPrize(0,{0})", j));
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Mission_GetPrize(1,{0})", j));
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Mission_GetPrize(2,{0})", j));
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Mission_GetPrize(3,{0})", j));
				this.class106_0.method_374(string.Format("FreshMan_GamePass_Mission_GetPrize(4,{0})", j));
			}
			this.class106_0.method_375("\r\n                            for i = 1, 100 do\r\n                                Clear_XSCRIPT()\r\n                                Set_XSCRIPT_Function_Name('GetLevelAward')\r\n                                Set_XSCRIPT_ScriptID(998112)\r\n                                Set_XSCRIPT_Parameter(0, i )\r\n                                Set_XSCRIPT_Parameter(1, 1 )\r\n                                Set_XSCRIPT_ParamCount(2)\r\n                                Send_XSCRIPT()\r\n                            end", false);
			this.class106_0.method_375("\r\n                             for i = 1, 100 do\r\n                                for j = 0, 4 do\r\n                                    Clear_XSCRIPT()\r\n                                    Set_XSCRIPT_Function_Name('OnGetTaskPrize')\r\n                                    Set_XSCRIPT_ScriptID(998112)\r\n                                    Set_XSCRIPT_Parameter(0, j )\r\n                                    Set_XSCRIPT_Parameter(1, i )\r\n                                    Set_XSCRIPT_ParamCount(2)\r\n                                    Send_XSCRIPT()\t\r\n                                end\r\n                             end", false);
			this.class106_0.method_375(null, false);
		}

		// Token: 0x0400189B RID: 6299
		public Class106 class106_0;
	}

	// Token: 0x020002A6 RID: 678
	[CompilerGenerated]
	private sealed class Class462
	{
		// Token: 0x060023A3 RID: 9123 RVA: 0x0010F814 File Offset: 0x0010DA14
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			for (int i = 0; i < 10; i++)
			{
				this.class106_0.method_375("setmetatable(_G, {__index = SelfJunXian_Env}); SelfJunXian_EquipHXYLevelup(); ", false);
			}
		}

		// Token: 0x0400189C RID: 6300
		public Class106 class106_0;
	}

	// Token: 0x020002A7 RID: 679
	[CompilerGenerated]
	private sealed class Class463
	{
		// Token: 0x060023A5 RID: 9125 RVA: 0x000183FD File Offset: 0x000165FD
		internal void method_0()
		{
			this.class106_0.method_261(-1);
		}

		// Token: 0x0400189D RID: 6301
		public Class106 class106_0;
	}

	// Token: 0x020002A8 RID: 680
	[CompilerGenerated]
	private sealed class Class464
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x0001840B File Offset: 0x0001660B
		internal void method_0(Class106 class106_0)
		{
			Task.Run(new Action(new GUI.Class465
			{
				class464_0 = this,
				class106_0 = class106_0
			}.method_0));
		}

		// Token: 0x0400189E RID: 6302
		public string string_0;
	}

	// Token: 0x020002A9 RID: 681
	[CompilerGenerated]
	private sealed class Class465
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x0010F84C File Offset: 0x0010DA4C
		internal void method_0()
		{
			bool flag = false;
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_1.Where<Class516>(new Func<Class516, bool>(GUI.Class403.f_A642BF9F.method_138)))
			{
				flag = true;
				this.class106_0.method_375(string.Concat(new string[]
				{
					" i = ",
					@class.Int32_11.ToString(),
					"\r\n\ttheAction,bLocked = PlayerPackage:EnumItem('base', i);\r\n\tfor j = 0, 2 do\r\n\t\tlocal pName,pLevel,pBValue,pPercent,pRValue = theAction:GetEquipAttaProperty(j);\r\n\t\tif string.find(pName, '",
					this.class464_0.string_0,
					"') then\r\n\t\t\tfor k = 0, 10 do\r\n\t\t\t\tClear_XSCRIPT();\r\n\t\t\t\tSet_XSCRIPT_Function_Name('EquipLevelupAtta');\r\n\r\n                Set_XSCRIPT_ScriptID(890088);\r\n                    Set_XSCRIPT_Parameter(0, i);\r\n                    Set_XSCRIPT_Parameter(1, j + 1)\r\n\r\n                Set_XSCRIPT_Parameter(2, -1);\r\n                    Set_XSCRIPT_ParamCount(3);\r\n                    Send_XSCRIPT();\r\n                    end\r\n\r\n            return\r\n        end\r\n\r\n    end\r\n"
				}), false);
			}
			if (!flag)
			{
				this.class106_0.method_493("Bạn Cần Đặt Trang Bị Cần Tăng Vào Tay Nải");
			}
		}

		// Token: 0x0400189F RID: 6303
		public Class106 class106_0;

		// Token: 0x040018A0 RID: 6304
		public GUI.Class464 class464_0;
	}

	// Token: 0x020002AA RID: 682
	[CompilerGenerated]
	private sealed class Class466
	{
		// Token: 0x060023AB RID: 9131 RVA: 0x00018431 File Offset: 0x00016631
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.CoLanNgoc, true);
			class106_0.String_24 = (this.object_0 as ToolStripMenuItem).Tag.ToString();
		}

		// Token: 0x040018A1 RID: 6305
		public object object_0;
	}

	// Token: 0x020002AB RID: 683
	[CompilerGenerated]
	private sealed class Class467
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x0001845A File Offset: 0x0001665A
		internal void method_0(Class106 class106_0)
		{
			class106_0.Int32_22 = this.int_0;
		}

		// Token: 0x040018A2 RID: 6306
		public int int_0;
	}

	// Token: 0x020002AC RID: 684
	[CompilerGenerated]
	private sealed class Class468
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x0010F928 File Offset: 0x0010DB28
		internal void method_0()
		{
			if (this.class106_0 == null)
			{
				return;
			}
			if (this.class106_0.Class527_0.String_11 == "OFFLINE")
			{
				return;
			}
			IEnumerable<Class106> ienumerable_ = Class106.IEnumerable_0;
			Action<Class106> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class106>(this.method_1));
			}
			ienumerable_.smethod_22<Class106>(action);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00018468 File Offset: 0x00016668
		internal void method_1(Class106 class106_1)
		{
			class106_1.method_111((float)this.class106_0.Int32_16, (float)this.class106_0.Int32_17, this.class106_0.Class527_0.Int32_35, true, 3f, 999f);
		}

		// Token: 0x040018A3 RID: 6307
		public Class106 class106_0;

		// Token: 0x040018A4 RID: 6308
		public Action<Class106> action_0;
	}

	// Token: 0x020002AD RID: 685
	[CompilerGenerated]
	private sealed class Class469
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x0010F984 File Offset: 0x0010DB84
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DatDoiTangKinhCac, !this.toolStripMenuItem_0.Checked);
			int num = this.toolStripMenuItem_0.Tag.ToString().smethod_26();
			if (num == 0)
			{
				class106_0.method_221();
				return;
			}
			class106_0.Int32_71 = num;
		}

		// Token: 0x040018A5 RID: 6309
		public ToolStripMenuItem toolStripMenuItem_0;
	}

	// Token: 0x020002AE RID: 686
	[CompilerGenerated]
	private sealed class Class470
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x0010F9D0 File Offset: 0x0010DBD0
		internal bool method_0(Class106 class106_0)
		{
			IEnumerable<ListViewItem.ListViewSubItem> enumerable = class106_0.ListViewItem_0.SubItems.Cast<ListViewItem.ListViewSubItem>();
			Func<ListViewItem.ListViewSubItem, bool> func;
			if ((func = this.func_0) == null)
			{
				func = (this.func_0 = new Func<ListViewItem.ListViewSubItem, bool>(this.method_1));
			}
			return enumerable.Any<ListViewItem.ListViewSubItem>(func);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000184A4 File Offset: 0x000166A4
		internal bool method_1(ListViewItem.ListViewSubItem listViewSubItem_0)
		{
			return listViewSubItem_0.Text.smethod_36().Contains(this.string_0);
		}

		// Token: 0x040018A6 RID: 6310
		public string string_0;

		// Token: 0x040018A7 RID: 6311
		public Func<ListViewItem.ListViewSubItem, bool> func_0;
	}

	// Token: 0x020002AF RID: 687
	[CompilerGenerated]
	private sealed class Class471
	{
		// Token: 0x060023B7 RID: 9143 RVA: 0x0010FA14 File Offset: 0x0010DC14
		internal void method_0()
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.openFileDialog_0.FileName);
				int num = array.smethod_11("e8 ?? ?? ?? ?? 85 C0 0f 84 ?? ?? ?? ?? E8 ?? ?? ?? ?? 85 C0 0F 84 ?? ?? ?? ??", "90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90").Count;
				num += array.smethod_11("85 DB 75 57", "85 DB EB 57").Count;
				num += array.smethod_11("3D B7 00 00 00 75 1C", "3D B7 00 00 00 EB 1C").Count;
				num += array.smethod_11("46 83 FE 02 0F 8C 6B FF FF FF", "46 E9 6F FF FF FF 90 90 90 90").Count;
				File.WriteAllBytes(this.openFileDialog_0.FileName, array);
				MessBox.smethod_0("Đã vá xong -> " + num.ToString() + " Điểm");
			}
			catch (Exception ex)
			{
				MessBox.smethod_0("Đã xảy ra lỗi " + ex.Message);
			}
		}

		// Token: 0x040018A8 RID: 6312
		public OpenFileDialog openFileDialog_0;
	}

	// Token: 0x020002B0 RID: 688
	[CompilerGenerated]
	private sealed class Class472
	{
		// Token: 0x060023B9 RID: 9145 RVA: 0x0010FAE8 File Offset: 0x0010DCE8
		internal void method_0()
		{
			foreach (Class106 @class in this.list_0)
			{
				int num = this.int_0 % this.int_1;
				int num2 = (int)Math.Floor((double)(this.int_0 / this.int_1));
				@class.Boolean_49 = true;
				@class.Class0_0.Stopwatch_11 = Stopwatch.StartNew();
				Class534.SetWindowPos(@class.IntPtr_0, IntPtr.Zero, num * this.int_2, num2 * this.int_3, this.int_2, this.int_3, 0);
				Class534.smethod_0(@class.IntPtr_0);
				Class534.smethod_3(@class.IntPtr_0);
				int num3 = this.int_0;
				this.int_0 = num3 + 1;
			}
		}

		// Token: 0x040018A9 RID: 6313
		public List<Class106> list_0;

		// Token: 0x040018AA RID: 6314
		public int int_0;

		// Token: 0x040018AB RID: 6315
		public int int_1;

		// Token: 0x040018AC RID: 6316
		public int int_2;

		// Token: 0x040018AD RID: 6317
		public int int_3;
	}

	// Token: 0x020002B1 RID: 689
	[CompilerGenerated]
	private sealed class Class473
	{
		// Token: 0x060023BB RID: 9147 RVA: 0x0010FBD8 File Offset: 0x0010DDD8
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			foreach (Class516 @class in this.class106_0.Class214_0.IEnumerable_8)
			{
				@class.method_7();
				Thread.Sleep(333);
				this.class106_0.method_375("PlayerShop:DownSale('item');", false);
				Thread.Sleep(333);
			}
		}

		// Token: 0x040018AE RID: 6318
		public Class106 class106_0;
	}

	// Token: 0x020002B2 RID: 690
	[CompilerGenerated]
	private sealed class Class474
	{
		// Token: 0x060023BD RID: 9149 RVA: 0x0010FC60 File Offset: 0x0010DE60
		internal void method_0(object sender, EventArgs e)
		{
			IEnumerable<Class106> ienumerable_ = Class106.IEnumerable_3;
			Action<Class106> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class106>(this.method_1));
			}
			ienumerable_.smethod_22<Class106>(action);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000184BC File Offset: 0x000166BC
		internal void method_1(Class106 class106_1)
		{
			class106_1.Class106_2 = this.class106_0;
		}

		// Token: 0x040018AF RID: 6319
		public Class106 class106_0;

		// Token: 0x040018B0 RID: 6320
		public Action<Class106> action_0;
	}

	// Token: 0x020002B3 RID: 691
	[CompilerGenerated]
	private sealed class Class475
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x0010FC98 File Offset: 0x0010DE98
		internal void method_0(Class106 class106_0)
		{
			IEnumerable<Class517> list_ = class106_0.Class527_0.List_0;
			Func<Class517, bool> func;
			if ((func = this.func_0) == null)
			{
				func = (this.func_0 = new Func<Class517, bool>(this.method_1));
			}
			if (list_.Any<Class517>(func))
			{
				class106_0.Int32_69 = this.int_0;
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000184CA File Offset: 0x000166CA
		internal bool method_1(Class517 class517_0)
		{
			return class517_0.String_0 == this.int_0.ToString("X8");
		}

		// Token: 0x040018B1 RID: 6321
		public int int_0;

		// Token: 0x040018B2 RID: 6322
		public Func<Class517, bool> func_0;
	}

	// Token: 0x020002B4 RID: 692
	[CompilerGenerated]
	private sealed class Class476
	{
		// Token: 0x060023C3 RID: 9155 RVA: 0x0010FCE4 File Offset: 0x0010DEE4
		internal void method_0(Class106 class106_0)
		{
			foreach (Class516 @class in class106_0.Class214_0.IEnumerable_0)
			{
				if (@class.String_1 == "Thông Thiên Phù Lục")
				{
					class106_0.method_375(string.Concat(new string[]
					{
						"Clear_XSCRIPT();\r\n\t\t\t                Set_XSCRIPT_Function_Name('SetUISelIdx');\r\n                            Set_XSCRIPT_ScriptID(330060);\r\n                            Set_XSCRIPT_Parameter(0, ",
						@class.Int32_11.ToString(),
						")\r\n                            Set_XSCRIPT_Parameter(1, ",
						(this.int_0 - 1).ToString(),
						")\r\n                            Set_XSCRIPT_ParamCount(2);\r\n                            Send_XSCRIPT();\r\n                            PlayerPackage:UseItem(",
						@class.Int32_11.ToString(),
						")"
					}), false);
					break;
				}
				if (@class.String_4.Equals("CircularTaskTool22_8"))
				{
					class106_0.method_375(string.Concat(new string[]
					{
						"Clear_XSCRIPT();\r\n\t\t\t                Set_XSCRIPT_Function_Name('SetUISelIdx');\r\n                            Set_XSCRIPT_ScriptID(330059);\r\n                            Set_XSCRIPT_Parameter(0, ",
						@class.Int32_11.ToString(),
						")\r\n                            Set_XSCRIPT_Parameter(1, ",
						(this.int_0 - 1).ToString(),
						")\r\n                            Set_XSCRIPT_ParamCount(2);\r\n                            Send_XSCRIPT();\r\n                            PlayerPackage:UseItem(",
						@class.Int32_11.ToString(),
						")"
					}), false);
					class106_0.method_375(string.Concat(new string[]
					{
						"Clear_XSCRIPT();\r\n\t\t\t                Set_XSCRIPT_Function_Name('SetUISelIdx');\r\n                            Set_XSCRIPT_ScriptID(893252);\r\n                            Set_XSCRIPT_Parameter(0, ",
						@class.Int32_11.ToString(),
						")\r\n                            Set_XSCRIPT_Parameter(1, ",
						(this.int_0 - 1).ToString(),
						")\r\n                            Set_XSCRIPT_ParamCount(2);\r\n                            Send_XSCRIPT();\r\n                            PlayerPackage:UseItem(",
						@class.Int32_11.ToString(),
						")"
					}), false);
					break;
				}
			}
		}

		// Token: 0x040018B3 RID: 6323
		public int int_0;
	}

	// Token: 0x020002B5 RID: 693
	[CompilerGenerated]
	private sealed class Class477
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x0010FEA0 File Offset: 0x0010E0A0
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			for (int i = 0; i < 10; i++)
			{
				this.class106_0.method_375("setmetatable(_G, {__index = SelfJunXian_Env}); SelfJunXian_EquipHXYLevelup(); ", false);
			}
		}

		// Token: 0x040018B4 RID: 6324
		public Class106 class106_0;
	}

	// Token: 0x020002B6 RID: 694
	[CompilerGenerated]
	private sealed class Class478
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x000184E7 File Offset: 0x000166E7
		internal void method_0()
		{
			this.class106_0.method_259();
		}

		// Token: 0x040018B5 RID: 6325
		public Class106 class106_0;
	}

	// Token: 0x020002B7 RID: 695
	[CompilerGenerated]
	private sealed class Class479
	{
		// Token: 0x060023C9 RID: 9161 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		internal void method_0()
		{
			for (int i = 0; i < 30; i++)
			{
				this.class106_0.method_375("for i = 1,98 do\r\nClear_XSCRIPT()\r\n\t\tSet_XSCRIPT_Function_Name(\"XingJuanLevelUp\")\r\n\t\tSet_XSCRIPT_ScriptID(888555)\r\n\t\tSet_XSCRIPT_Parameter(0, i)\r\n\t\tSet_XSCRIPT_Parameter(1, 0)\r\n\t\tSet_XSCRIPT_ParamCount(2)\r\n\tSend_XSCRIPT()\r\nClear_XSCRIPT()\r\n\t\tSet_XSCRIPT_Function_Name(\"XingJuanLevelUp\")\r\n\t\tSet_XSCRIPT_ScriptID(888555)\r\n\t\tSet_XSCRIPT_Parameter(0, i)\r\n\t\tSet_XSCRIPT_Parameter(1, 1)\r\n\t\tSet_XSCRIPT_ParamCount(2)\r\n\tSend_XSCRIPT()\r\nend", false);
				Thread.Sleep(100);
			}
		}

		// Token: 0x040018B6 RID: 6326
		public Class106 class106_0;
	}

	// Token: 0x020002B8 RID: 696
	[CompilerGenerated]
	private sealed class Class480
	{
		// Token: 0x060023CB RID: 9163 RVA: 0x000184F4 File Offset: 0x000166F4
		internal void method_0(object sender, EventArgs e)
		{
			Class226.String_4 = this.string_0;
		}

		// Token: 0x040018B7 RID: 6327
		public string string_0;
	}

	// Token: 0x020002B9 RID: 697
	[CompilerGenerated]
	private sealed class Class481
	{
		// Token: 0x060023CD RID: 9165 RVA: 0x00018501 File Offset: 0x00016701
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_97(Enum17.DatDoiBossMap, !this.toolStripMenuItem_0.Checked);
			class106_0.Int32_48 = this.int_0;
		}

		// Token: 0x040018B8 RID: 6328
		public ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040018B9 RID: 6329
		public int int_0;
	}

	// Token: 0x020002BA RID: 698
	[CompilerGenerated]
	private sealed class Class482
	{
		// Token: 0x060023CF RID: 9167 RVA: 0x00018525 File Offset: 0x00016725
		internal void method_0(Class400 class400_0)
		{
			if (class400_0.Class106_0 == null)
			{
				class400_0.String_21 = "wait";
			}
			class400_0.method_1(Enum17.NhanThienMachPhucTrach, true);
			class400_0.Class106_0.string_14 = this.toolStripMenuItem_0.Tag.ToString();
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00018561 File Offset: 0x00016761
		internal void method_1(Class106 class106_0)
		{
			class106_0.method_97(Enum17.NhanThienMachPhucTrach, !this.toolStripMenuItem_0.Checked);
			class106_0.string_14 = this.toolStripMenuItem_0.Tag.ToString();
		}

		// Token: 0x040018BA RID: 6330
		public ToolStripMenuItem toolStripMenuItem_0;
	}

	// Token: 0x020002BB RID: 699
	[CompilerGenerated]
	private sealed class Class483
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x0010FF0C File Offset: 0x0010E10C
		internal void method_0()
		{
			foreach (int num in this.int_0)
			{
				this.class106_0.method_375(string.Format("\r\n                      Clear_XSCRIPT();\r\n                      Set_XSCRIPT_Function_Name('Huoyuezhiduixian');\r\n                      Set_XSCRIPT_ScriptID(889203);\r\n                      Set_XSCRIPT_Parameter(0, {0}); \r\n                      Set_XSCRIPT_ParamCount(1);\r\n                      Send_XSCRIPT();\r\n                  ", num), false);
				Thread.Sleep(200);
			}
		}

		// Token: 0x040018BB RID: 6331
		public Class106 class106_0;

		// Token: 0x040018BC RID: 6332
		public int[] int_0;
	}

	// Token: 0x020002BC RID: 700
	[CompilerGenerated]
	private sealed class Class484
	{
		// Token: 0x060023D4 RID: 9172 RVA: 0x00018592 File Offset: 0x00016792
		internal float method_0(Class504 class504_0)
		{
			return class504_0.method_3(this.class106_0.Single_5, this.class106_0.Single_6);
		}

		// Token: 0x040018BD RID: 6333
		public Class106 class106_0;
	}

	// Token: 0x020002BD RID: 701
	[CompilerGenerated]
	private sealed class Class485
	{
		// Token: 0x060023D6 RID: 9174 RVA: 0x000185B0 File Offset: 0x000167B0
		internal float method_0(Class504 class504_0)
		{
			return class504_0.method_3(this.class106_0.Single_5, this.class106_0.Single_6);
		}

		// Token: 0x040018BE RID: 6334
		public Class106 class106_0;
	}

	// Token: 0x020002BE RID: 702
	[CompilerGenerated]
	private sealed class Class486
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x0010FF58 File Offset: 0x0010E158
		internal void method_0(Class400 class400_0)
		{
			if (class400_0.String_21.Equals("..."))
			{
				class400_0.HashSet_0.Clear();
			}
			class400_0.String_21 = "wait";
			Enum17[] array;
			if (this.gui_0.Dictionary_0.TryGetValue(this.toolStripMenuItem_0, out array))
			{
				foreach (Enum17 @enum in array)
				{
					class400_0.method_1(@enum, true);
				}
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0010FFC4 File Offset: 0x0010E1C4
		internal void method_1(Class106 class106_0)
		{
			Enum17[] array;
			if (this.gui_0.Dictionary_0.TryGetValue(this.toolStripMenuItem_0, out array))
			{
				foreach (Enum17 @enum in array)
				{
					class106_0.method_97(@enum, !this.toolStripMenuItem_0.Checked);
				}
			}
		}

		// Token: 0x040018BF RID: 6335
		public ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040018C0 RID: 6336
		public GUI gui_0;
	}

	// Token: 0x020002BF RID: 703
	[CompilerGenerated]
	private sealed class Class487
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x000185CE File Offset: 0x000167CE
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_242(this.int_0);
		}

		// Token: 0x040018C1 RID: 6337
		public int int_0;
	}

	// Token: 0x020002C0 RID: 704
	[CompilerGenerated]
	private sealed class Class488
	{
		// Token: 0x060023DD RID: 9181 RVA: 0x000185DC File Offset: 0x000167DC
		internal void method_0(Class400 class400_0)
		{
			if (class400_0.Class106_0 != null)
			{
				class400_0.Class106_0.int_1 = this.int_0;
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000185F7 File Offset: 0x000167F7
		internal void method_1(Class106 class106_0)
		{
			class106_0.int_1 = this.int_0;
		}

		// Token: 0x040018C2 RID: 6338
		public int int_0;
	}

	// Token: 0x020002C1 RID: 705
	[CompilerGenerated]
	private sealed class Class489
	{
		// Token: 0x060023E0 RID: 9184 RVA: 0x00018605 File Offset: 0x00016805
		internal bool method_0(Class106 class106_0)
		{
			return this.list_0.Contains(class106_0);
		}

		// Token: 0x040018C3 RID: 6339
		public List<Class106> list_0;
	}

	// Token: 0x020002C2 RID: 706
	[CompilerGenerated]
	private sealed class Class490
	{
		// Token: 0x060023E2 RID: 9186 RVA: 0x00110014 File Offset: 0x0010E214
		internal void method_0(Class106 class106_0)
		{
			GUI.Class491 @class = new GUI.Class491();
			@class.class490_0 = this;
			@class.class106_0 = class106_0;
			if (@class.class106_0.Class527_0.String_5 != this.list_0[0].Class527_0.String_10)
			{
				Task.Run(new Action(@class.method_0));
			}
		}

		// Token: 0x040018C4 RID: 6340
		public List<Class106> list_0;
	}

	// Token: 0x020002C3 RID: 707
	[CompilerGenerated]
	private sealed class Class491
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x00110074 File Offset: 0x0010E274
		internal void method_0()
		{
			this.class106_0.method_375("Player:LeaveTeam();", false);
			Thread.Sleep(500);
			this.class106_0.method_370(this.class490_0.list_0[0].Class527_0.Byte_0);
			Thread.Sleep(500);
			this.class490_0.list_0[0].method_425(true);
		}

		// Token: 0x040018C5 RID: 6341
		public Class106 class106_0;

		// Token: 0x040018C6 RID: 6342
		public GUI.Class490 class490_0;
	}

	// Token: 0x020002C4 RID: 708
	[CompilerGenerated]
	private sealed class Class492
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x001100E4 File Offset: 0x0010E2E4
		internal void method_0()
		{
			try
			{
				string[] array = this.string_0.Split(new char[] { '\t' });
				if (array.Length < 2)
				{
					array = new string[] { "Mèo", "Me", this.string_0 };
				}
				ListViewItem listViewItem = new ListViewItem(DateTime.Now.ToString());
				int num = 0;
				while (num < 3 && num < array.Length)
				{
					listViewItem.SubItems.Add(array[num]);
					num++;
				}
				GUI.GUI_0.lvInbox.Items.Insert(0, listViewItem);
				while (GUI.GUI_0.lvInbox.Items.Count > 10000)
				{
					GUI.GUI_0.lvInbox.Items.RemoveAt(GUI.GUI_0.lvInbox.Items.Count - 1);
				}
				if (Class226.Boolean_25 && !this.string_0.Contains("Mã Tặc"))
				{
					Class534.smethod_3(((Form)GUI.GUI_0.Parent).Handle);
					GUI.GUI_0.tabMain.SelectedIndex = 3;
				}
			}
			catch
			{
			}
		}

		// Token: 0x040018C7 RID: 6343
		public string string_0;
	}

	// Token: 0x020002C5 RID: 709
	[CompilerGenerated]
	private sealed class Class493
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x00110224 File Offset: 0x0010E424
		internal void method_0()
		{
			if (this.string_0.Split(new char[] { '|' }).Length > 5)
			{
				GUI.double_0 = (double)this.string_0.Split(new char[] { '|' })[3].smethod_26();
				this.gui_0.btnDayVNG.Text = GUI.smethod_7(this.string_0.Split(new char[] { '|' })[14]) + " Time VNG";
				this.gui_0.btnDayPRI.Text = GUI.smethod_7(this.string_0.Split(new char[] { '|' })[15]) + " Time PRI";
				this.gui_0.btnDayORI.Text = GUI.smethod_7(this.string_0.Split(new char[] { '|' })[16]) + " Time ORI";
				this.gui_0.string_2 = "iauto" + this.string_0.Split(new char[] { '|' })[0] + "beli";
				if (this.string_0.Split(new char[] { '|' })[0].smethod_26() > 0)
				{
					Task.Run(new Action(this.gui_0.method_106));
				}
				this.gui_0.btnBlance.Text = this.string_0.Split(new char[] { '|' })[8].smethod_26().smethod_6() + " Chip";
				GUI.Int32_2 = this.string_0.Split(new char[] { '|' })[8].smethod_26();
				GUI.Boolean_1 = this.string_0.Split(new char[] { '|' })[9].smethod_26() == 1;
				GUI.Boolean_2 = this.string_0.Split(new char[] { '|' })[9].smethod_26() == 1;
				GUI.Boolean_0 = this.string_0.Split(new char[] { '|' })[10].smethod_26() == 1;
				if (this.string_0.Split(new char[] { '|' }).Length > 3)
				{
					this.string_0.Split(new char[] { '|' })[3].smethod_26();
					if (this.string_0.Split(new char[] { '|' }).Length > 6)
					{
						GUI.String_0 = this.string_0.Split(new char[] { '|' })[6];
					}
					try
					{
						long num = GClass36.smethod_0();
						long num2 = GClass36.smethod_1();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x040018C8 RID: 6344
		public string string_0;

		// Token: 0x040018C9 RID: 6345
		public GUI gui_0;
	}

	// Token: 0x020002C6 RID: 710
	[CompilerGenerated]
	private sealed class Class494
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x00018613 File Offset: 0x00016813
		internal void method_0()
		{
			this.gui_0.picQr.Image = Image.FromStream(new MemoryStream(this.byte_0));
		}

		// Token: 0x040018CA RID: 6346
		public byte[] byte_0;

		// Token: 0x040018CB RID: 6347
		public GUI gui_0;
	}

	// Token: 0x020002C7 RID: 711
	[CompilerGenerated]
	private sealed class Class495
	{
		// Token: 0x060023EC RID: 9196 RVA: 0x00110508 File Offset: 0x0010E708
		internal void method_0()
		{
			GUI.Class496 @class = new GUI.Class496();
			string fileName = Path.GetFileName(this.string_0);
			TabPage tabPage = new TabPage(fileName.Replace(".xml", ""));
			this.gui_0.tabLogin.TabPages.Add(tabPage);
			@class.tabLogin_0 = new TabLogin
			{
				Dock = DockStyle.Fill,
				String_2 = fileName.Replace(".xml", "")
			};
			tabPage.Controls.Add(@class.tabLogin_0);
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x040018CC RID: 6348
		public string string_0;

		// Token: 0x040018CD RID: 6349
		public GUI gui_0;
	}

	// Token: 0x020002C8 RID: 712
	[CompilerGenerated]
	private sealed class Class496
	{
		// Token: 0x060023EE RID: 9198 RVA: 0x00018635 File Offset: 0x00016835
		internal void method_0()
		{
			this.tabLogin_0.method_0(null, null);
		}

		// Token: 0x040018CE RID: 6350
		public TabLogin tabLogin_0;
	}

	// Token: 0x020002C9 RID: 713
	[CompilerGenerated]
	private sealed class Class497
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x00018644 File Offset: 0x00016844
		internal void method_0()
		{
			try
			{
				Class90.Class91 result = Class90.smethod_5(this.string_0, "-fl");
				if (result != null && !string.IsNullOrEmpty(result.string_2))
				{
					GUI.ReportGameLaunchError(this.string_0, result.string_2);
				}
			}
			catch (Exception ex)
			{
				GUI.ReportGameLaunchError(this.string_0, ex.Message);
			}
		}

		// Token: 0x040018CF RID: 6351
		public string string_0;
	}

	// Token: 0x020002CA RID: 714
	[CompilerGenerated]
	private sealed class Class498
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x00018657 File Offset: 0x00016857
		internal void method_0()
		{
			GUI.smethod_9(this.networkStream_0, this.networkStream_1);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0001866A File Offset: 0x0001686A
		internal void method_1()
		{
			GUI.smethod_8(this.networkStream_1, this.networkStream_0);
		}

		// Token: 0x040018D0 RID: 6352
		public NetworkStream networkStream_0;

		// Token: 0x040018D1 RID: 6353
		public NetworkStream networkStream_1;
	}

	public void ApplyModernDarkCyberTheme()
	{
		try
		{
			this.BackColor = Color.FromArgb(18, 24, 36);
			this.ForeColor = Color.FromArgb(241, 245, 249);

			// Top MenuStrip
			if (this.menuMain != null)
			{
				this.menuMain.BackColor = Color.FromArgb(15, 23, 42);
				this.menuMain.ForeColor = Color.FromArgb(241, 245, 249);
				this.menuMain.Renderer = new ModernDarkToolStripRenderer();
			}

			// Style all tab pages in tabMain & tabBoottom
			if (this.tabMain != null)
			{
				this.tabMain.Padding = new Point(12, 5);
				foreach (TabPage page in this.tabMain.TabPages)
				{
					page.BackColor = Color.FromArgb(18, 24, 36);
					page.ForeColor = Color.FromArgb(241, 245, 249);
				}
			}
			if (this.tabBoottom != null)
			{
				this.tabBoottom.Padding = new Point(10, 4);
				foreach (TabPage page in this.tabBoottom.TabPages)
				{
					page.BackColor = Color.FromArgb(18, 24, 36);
					page.ForeColor = Color.FromArgb(241, 245, 249);
				}
			}

			// Style all child controls across all panels, listviews, comboboxes, textboxes
			this.StyleAllChildControls(this);

			// Info tab (tabPay)
			this.tabPay.Text = "Info";
			this.tabPay.BackColor = Color.FromArgb(18, 24, 36);
			this.myPanel1.BackColor = Color.FromArgb(18, 24, 36);
			this.myPanel3.BackColor = Color.FromArgb(26, 34, 52);

			// Left GroupBoxes
			GroupBox[] gbs = new GroupBox[] { this.groupBox8, this.groupBox1, this.groupBox2, this.groupBox9 };
			string[] titles = new string[] { "Tài Khoản Trạng Thái", "Phiên Bản Phần Mềm", "Máy Chủ Hỗ Trợ", "Cơ Chế Điều Khiển" };
			for (int i = 0; i < gbs.Length; i++)
			{
				if (gbs[i] != null)
				{
					gbs[i].ForeColor = Color.FromArgb(56, 189, 248);
					gbs[i].BackColor = Color.FromArgb(26, 34, 52);
					gbs[i].Text = titles[i];
				}
			}

			string currentUser = string.IsNullOrEmpty(this.String_2) ? "LAuto User" : this.String_2;
			this.txtUserChip.Text = currentUser;
			this.txtUserChip.BackColor = Color.FromArgb(15, 23, 42);
			this.txtUserChip.ForeColor = Color.FromArgb(241, 245, 249);
			this.txtUserChip.ReadOnly = true;

			this.txtSendChip.Text = "Bản Quyền: Trọn Đời (Lifetime)";
			this.txtSendChip.BackColor = Color.FromArgb(15, 23, 42);
			this.txtSendChip.ForeColor = Color.FromArgb(74, 222, 128);
			this.txtSendChip.ReadOnly = true;

			this.btnSendChip.Text = "VIP";
			this.btnSendChip.BackColor = Color.FromArgb(30, 41, 59);
			this.btnSendChip.ForeColor = Color.FromArgb(56, 189, 248);
			this.btnSendChip.FlatStyle = FlatStyle.Flat;
			this.btnSendChip.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			this.txtGiftCode.Text = "LAuto Pro (Clean & Offline)";
			this.txtGiftCode.BackColor = Color.FromArgb(15, 23, 42);
			this.txtGiftCode.ForeColor = Color.FromArgb(241, 245, 249);
			this.txtGiftCode.ReadOnly = true;

			this.btnOpenGiftCode.Text = "v" + Settings.Default.Version;
			this.btnOpenGiftCode.BackColor = Color.FromArgb(30, 41, 59);
			this.btnOpenGiftCode.ForeColor = Color.FromArgb(56, 189, 248);
			this.btnOpenGiftCode.FlatStyle = FlatStyle.Flat;
			this.btnOpenGiftCode.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			this.txtNewPass.Text = "VNG / Private / Origin";
			this.txtNewPass.BackColor = Color.FromArgb(15, 23, 42);
			this.txtNewPass.ForeColor = Color.FromArgb(241, 245, 249);
			this.txtNewPass.ReadOnly = true;

			this.button3.Text = "Sẵn Sàng";
			this.button3.BackColor = Color.FromArgb(30, 41, 59);
			this.button3.ForeColor = Color.FromArgb(74, 222, 128);
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			this.txtBetChip.Text = "WOW64 Native Hook & Lua";
			this.txtBetChip.BackColor = Color.FromArgb(15, 23, 42);
			this.txtBetChip.ForeColor = Color.FromArgb(241, 245, 249);
			this.txtBetChip.ReadOnly = true;

			this.button14.Text = "x86/x64";
			this.button14.BackColor = Color.FromArgb(30, 41, 59);
			this.button14.ForeColor = Color.FromArgb(56, 189, 248);
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			Button[] statusBtns = new Button[] { this.btnBlance, this.btnDayVNG, this.btnDayPRI, this.btnDayORI };
			string[] statusTexts = new string[]
			{
				"Tính Năng: Không Giới Hạn",
				"✔ Hạn Dùng VNG: Vĩnh Viễn",
				"✔ Hạn Dùng Private: Vĩnh Viễn",
				"✔ Hạn Dùng Origin: Vĩnh Viễn"
			};
			for (int i = 0; i < statusBtns.Length; i++)
			{
				if (statusBtns[i] != null)
				{
					statusBtns[i].Enabled = true;
					statusBtns[i].Text = statusTexts[i];
					statusBtns[i].BackColor = Color.FromArgb(26, 34, 52);
					statusBtns[i].ForeColor = Color.FromArgb(74, 222, 128);
					statusBtns[i].FlatStyle = FlatStyle.Flat;
					statusBtns[i].FlatAppearance.BorderSize = 1;
					statusBtns[i].FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);
					statusBtns[i].Font = new Font("Segoe UI", 8.25f, FontStyle.Bold);
				}
			}

			this.lblIncome.Text = "Chế độ: Độc lập offline (Không phụ thuộc server)";
			this.lblIncome.ForeColor = Color.FromArgb(148, 163, 184);

			this.linkLabel1.Text = "⚡ Tối Ưu Dọn Bộ Nhớ RAM (Trim RAM)";
			this.linkLabel1.LinkColor = Color.FromArgb(56, 189, 248);
			this.linkLabel1.ActiveLinkColor = Color.FromArgb(14, 165, 233);
			this.linkLabel1.VisitedLinkColor = Color.FromArgb(56, 189, 248);

			this.picQr.BackColor = Color.FromArgb(26, 34, 52);
			this.picQr.Image = null;
			this.picQr.Paint -= this.OnPaintCheatsheet;
			this.picQr.Paint += this.OnPaintCheatsheet;
			this.picQr.Invalidate();

			this.txtHWID.BackColor = Color.FromArgb(15, 23, 42);
			this.txtHWID.ForeColor = Color.FromArgb(148, 163, 184);
			this.txtHWID.Text = "HWID: " + (GUI.string_1 ?? "8D2E-8D76-3F92-362F-2F9D-EFC0-9");

			this.txtiAutoUser.BackColor = Color.FromArgb(15, 23, 42);
			this.txtiAutoUser.ForeColor = Color.FromArgb(74, 222, 128);
			this.txtiAutoUser.Text = "Người Dùng: " + currentUser;

			this.button5.Text = "📁 Mở Thư Mục Cài Đặt (Open Folder)";
			this.button5.BackColor = Color.FromArgb(30, 41, 59);
			this.button5.ForeColor = Color.FromArgb(241, 245, 249);
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			this.button12.Text = "💾 Lưu Cấu Hình Ngay (-iAuto.ini)";
			this.button12.BackColor = Color.FromArgb(30, 41, 59);
			this.button12.ForeColor = Color.FromArgb(241, 245, 249);
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.FlatAppearance.BorderColor = Color.FromArgb(42, 54, 79);

			this.btnRefresh.Text = "🔄 Làm Mới Trạng Thái";
			this.btnRefresh.BackColor = Color.FromArgb(14, 165, 233);
			this.btnRefresh.ForeColor = Color.FromArgb(255, 255, 255);
			this.btnRefresh.FlatStyle = FlatStyle.Flat;
			this.btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(56, 189, 248);
			this.btnRefresh.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold);

			this.button1.Visible = false;
		}
		catch
		{
		}
	}

	private readonly List<Control> styledControls = new List<Control>();

	private void StyleAllChildControls(Control root)
	{
		if (root == null) return;
		foreach (Control c in root.Controls)
		{
			if (c is ListView lv)
			{
				lv.BackColor = Color.FromArgb(22, 30, 46);
				lv.ForeColor = Color.FromArgb(241, 245, 249);
				foreach (ListViewItem item in lv.Items)
				{
					item.BackColor = Color.FromArgb(22, 30, 46);
					item.ForeColor = Color.FromArgb(241, 245, 249);
					foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
					{
						sub.BackColor = Color.FromArgb(22, 30, 46);
						sub.ForeColor = Color.FromArgb(241, 245, 249);
					}
				}
			}
			else if (c is ComboBox cbo)
			{
				cbo.BackColor = Color.FromArgb(26, 34, 52);
				cbo.ForeColor = Color.FromArgb(241, 245, 249);
				cbo.FlatStyle = FlatStyle.Flat;
				cbo.DrawMode = DrawMode.OwnerDrawFixed;
				cbo.DrawItem -= this.Cbo_DrawItem;
				cbo.DrawItem += this.Cbo_DrawItem;
				if (!this.styledControls.Contains(cbo))
				{
					this.styledControls.Add(cbo);
					new CyberComboBoxStyler(cbo);
				}
			}
			else if (c is TextBox tb)
			{
				tb.BackColor = Color.FromArgb(15, 23, 42);
				tb.ForeColor = Color.FromArgb(241, 245, 249);
			}
			else if (c is CheckBox cb)
			{
				cb.ForeColor = Color.FromArgb(241, 245, 249);
			}
			else if (c is RadioButton rb)
			{
				rb.ForeColor = Color.FromArgb(241, 245, 249);
			}
			else if (c is Label lbl)
			{
				if (lbl.ForeColor == Color.Black || lbl.ForeColor == SystemColors.ControlText)
				{
					lbl.ForeColor = Color.FromArgb(241, 245, 249);
				}
			}
			else if (c is Panel p && !(p is TabPage))
			{
				p.BackColor = Color.FromArgb(18, 24, 36);
			}

			if (c.HasChildren)
			{
				this.StyleAllChildControls(c);
			}
		}
	}

	private void Cbo_DrawItem(object sender, DrawItemEventArgs e)
	{
		ComboBox cbo = sender as ComboBox;
		if (cbo == null || e.Index < 0 || e.Index >= cbo.Items.Count) return;

		bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
		Color bg = isSelected ? Color.FromArgb(14, 165, 233) : Color.FromArgb(26, 34, 52);
		Color fg = isSelected ? Color.White : Color.FromArgb(241, 245, 249);

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

	private void OnPaintCheatsheet(object sender, PaintEventArgs e)
	{
		try
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

			using (SolidBrush bBg = new SolidBrush(Color.FromArgb(26, 34, 52)))
			{
				e.Graphics.FillRectangle(bBg, e.ClipRectangle);
			}

			using (Font titleFont = new Font("Segoe UI", 9.5f, FontStyle.Bold))
			using (Font boldFont = new Font("Segoe UI", 8.25f, FontStyle.Bold))
			using (Font font = new Font("Segoe UI", 8.25f, FontStyle.Regular))
			using (Font noteFont = new Font("Segoe UI", 7.5f, FontStyle.Italic))
			using (Brush bTitle = new SolidBrush(Color.FromArgb(56, 189, 248)))
			using (Brush bKey = new SolidBrush(Color.FromArgb(251, 191, 36)))
			using (Brush bText = new SolidBrush(Color.FromArgb(241, 245, 249)))
			using (Brush bNote = new SolidBrush(Color.FromArgb(148, 163, 184)))
			using (Pen pLine = new Pen(Color.FromArgb(42, 54, 79)))
			{
				e.Graphics.DrawString("PHÍM TẮT ĐIỀU KHIỂN NHANH", titleFont, bTitle, 10f, 10f);

				string[] keys = new string[]
				{
					"Ctrl + Q",
					"Ctrl + K",
					"Ctrl + U",
					"Ctrl + D",
					"Ctrl + Shift + O",
					"Alt + F1",
					"Alt + F2",
					"Alt + F3",
					"Space",
					"Tab"
				};
				string[] descs = new string[]
				{
					"Đánh theo Key / Bám Key",
					"Bật / Tắt dùng Skill",
					"Lên thú cưỡi",
					"Xuống thú cưỡi",
					"Chế độ chỉ đánh quái",
					"Triệu tập nhân vật",
					"Triệu tập cả tổ đội",
					"Buộc triệu tập khẩn",
					"Tạm dừng / Tiếp tục Auto",
					"Đổi mục tiêu gần nhất"
				};

				float y = 35f;
				for (int i = 0; i < keys.Length; i++)
				{
					e.Graphics.DrawString(keys[i] + ":", boldFont, bKey, 10f, y);
					e.Graphics.DrawString(descs[i], font, bText, 85f, y);
					y += 18f;
				}

				y += 5f;
				e.Graphics.DrawLine(pLine, 10f, y, 210f, y);

				y += 6f;
				e.Graphics.DrawString("Chạy game bằng Admin để kích hoạt\nđầy đủ tính năng tiêm DLL & phím tắt.", noteFont, bNote, 10f, y);
			}
		}
		catch
		{
		}
	}
}

internal class ModernDarkToolStripRenderer : ToolStripProfessionalRenderer
{
	public ModernDarkToolStripRenderer() : base(new ModernDarkColorTable())
	{
	}

	protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
	{
		e.TextColor = Color.FromArgb(241, 245, 249);
		base.OnRenderItemText(e);
	}
}

internal class ModernDarkColorTable : ProfessionalColorTable
{
	public override Color MenuStripGradientBegin => Color.FromArgb(15, 23, 42);
	public override Color MenuStripGradientEnd => Color.FromArgb(15, 23, 42);
	public override Color MenuItemSelected => Color.FromArgb(30, 41, 59);
	public override Color MenuItemSelectedGradientBegin => Color.FromArgb(30, 41, 59);
	public override Color MenuItemSelectedGradientEnd => Color.FromArgb(30, 41, 59);
	public override Color MenuItemBorder => Color.FromArgb(14, 165, 233);
	public override Color ToolStripDropDownBackground => Color.FromArgb(15, 23, 42);
	public override Color ImageMarginGradientBegin => Color.FromArgb(18, 24, 36);
	public override Color ImageMarginGradientMiddle => Color.FromArgb(18, 24, 36);
	public override Color ImageMarginGradientEnd => Color.FromArgb(18, 24, 36);
	public override Color MenuBorder => Color.FromArgb(42, 54, 79);
	public override Color MenuItemPressedGradientBegin => Color.FromArgb(30, 41, 59);
	public override Color MenuItemPressedGradientEnd => Color.FromArgb(30, 41, 59);
	public override Color SeparatorDark => Color.FromArgb(42, 54, 79);
	public override Color SeparatorLight => Color.FromArgb(30, 41, 59);
}

internal class CyberComboBoxStyler : NativeWindow
{
	private readonly ComboBox _cbo;

	public CyberComboBoxStyler(ComboBox cbo)
	{
		this._cbo = cbo;
		if (cbo.IsHandleCreated)
		{
			this.AssignHandle(cbo.Handle);
		}
		cbo.HandleCreated += (s, e) => this.AssignHandle(cbo.Handle);
		cbo.HandleDestroyed += (s, e) => this.ReleaseHandle();
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		if (m.Msg == 15 && this._cbo != null && this._cbo.IsHandleCreated)
		{
			try
			{
				using (Graphics g = Graphics.FromHwnd(this._cbo.Handle))
				{
					int arrowBtnWidth = 18;
					Rectangle btnRect = new Rectangle(this._cbo.Width - arrowBtnWidth - 1, 1, arrowBtnWidth, this._cbo.Height - 2);
					using (SolidBrush bBtn = new SolidBrush(Color.FromArgb(30, 41, 59)))
					using (Pen pBorder = new Pen(Color.FromArgb(51, 65, 85)))
					{
						g.FillRectangle(bBtn, btnRect);
						g.DrawLine(pBorder, btnRect.Left, btnRect.Top, btnRect.Left, btnRect.Bottom);
					}

					int cx = btnRect.Left + btnRect.Width / 2;
					int cy = btnRect.Top + btnRect.Height / 2;
					Point[] arrow = new Point[]
					{
						new Point(cx - 4, cy - 2),
						new Point(cx + 4, cy - 2),
						new Point(cx, cy + 3)
					};
					using (SolidBrush bArrow = new SolidBrush(Color.FromArgb(56, 189, 248)))
					{
						g.FillPolygon(bArrow, arrow);
					}

					using (Pen pOuter = new Pen(Color.FromArgb(51, 65, 85)))
					{
						g.DrawRectangle(pOuter, 0, 0, this._cbo.Width - 1, this._cbo.Height - 1);
					}
				}
			}
			catch
			{
			}
		}
	}
}
