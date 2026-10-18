using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x02000192 RID: 402
internal partial class Setting : UserControl
{
	// Token: 0x06001726 RID: 5926 RVA: 0x000100EF File Offset: 0x0000E2EF
	public Setting()
	{
		this.InitializeComponent();
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x000BB77C File Offset: 0x000B997C
	private List<Control> method_0(Control control_0)
	{
		List<Control> list = new List<Control>();
		foreach (object obj in control_0.Controls)
		{
			Control control = (Control)obj;
			list.Add(control);
			list.AddRange(this.method_0(control));
		}
		return list;
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x000BB7EC File Offset: 0x000B99EC
	public void method_1()
	{
		for (int i = 0; i < this.checkVaoPhai.ObjectCollection_0.Count; i++)
		{
			foreach (KeyValuePair<string, string> keyValuePair in Class501.Dictionary_1)
			{
				if (this.checkVaoPhai.ObjectCollection_0[i].ToString().Contains(keyValuePair.Value))
				{
					this.checkVaoPhai.ObjectCollection_0[i] = this.checkVaoPhai.ObjectCollection_0[i].ToString().Replace(keyValuePair.Value, keyValuePair.Key);
					break;
				}
			}
		}
		for (int j = 0; j < this.checkDiaPhu.ObjectCollection_0.Count; j++)
		{
			foreach (KeyValuePair<string, string> keyValuePair2 in Class501.Dictionary_1)
			{
				if (this.checkDiaPhu.ObjectCollection_0[j].ToString().Contains(keyValuePair2.Value))
				{
					this.checkDiaPhu.ObjectCollection_0[j] = this.checkDiaPhu.ObjectCollection_0[j].ToString().Replace(keyValuePair2.Value, keyValuePair2.Key);
					break;
				}
			}
		}
		this.checkTrimCPU.Text = "Trim CPU";
		this.checkAlarmDisconnected.Text = "Disconnected";
		this.groupTuDong.Text = "Auto";
		this.checkDanhTra.Text = "Auto PK";
		this.checkXuongNgua.Text = "Dismount When Idle";
		this.chkTrungSinh.Text = "Reincarnation";
		this.checkByPass.Text = "Bypass Captcha";
		this.checkToDoiTuDong.Text = "Auto Create Team";
		this.checkHoiSinh.Text = "Resurrect";
		this.checkCongTheLuc.Text = "Auto Add Stamina";
		this.checkTriLieuTuVong.Text = "Heal After Death";
		this.checkTriLieuMP.Text = "Heal When MP < 5%";
		this.checkVaoDoiCuoi.Text = "Join Last Team";
		this.chkAutoCreatePlayer.Text = "Auto Create Character";
		this.checkDauThai.Text = "Revive";
		this.checkAccept.Text = "Accept Friends Team Invite";
		this.checkAcceptAll.Text = "Accept Team Invite";
		this.checkDiemDanh.Text = "Auto Check-in";
		this.checkDiaPhu.Text = "Inferno Return";
		this.checkVaoPhai.Text = "Join Menpai";
		this.checkTamXa.Text = "Distance";
		this.checkThuPet.Text = "Auto Rest Pet if Level >=";
		this.checkCongDiemPet.Text = "Auto Add Pet Points";
		this.checkUseSkillPet.Text = "Auto Use Pet Skills";
		this.checkTuXuatPet.Text = "Auto Summon Pet";
		this.checkBuff.Text = "Recovery";
		this.checkNgamyHoiSinh.Text = "Revive Team";
		this.checkBuffPet.Text = "Buff Pet";
		this.checkNgamyCungMay.Text = "Buff Same PC";
		this.checkBuffAll.Text = "Buff All";
		this.checkKhongDungXungHu.Text = "Disable Buff Lv20";
		this.checkExitGame.Text = "Exit Game When";
		this.checkExitTuVong.Text = "Dead";
		this.checkExitDone.Text = "Mission Complete";
		this.checkAutoDone.Text = "Trader Complete";
		this.checkExitLvl.Text = "Level Reached";
		this.checkExitidle.Text = "Standing Still";
		this.groupPhuBan.Text = "Fuben";
		this.checkTangQuanSonHai.Text = "Go Quan Son Hai Level";
		this.checkTriLieu.Text = "Heal Before Fuben";
		this.checkDiCoNhanh.Text = "Fast Flag, Treasure";
		this.checkBoBoss2.Text = "Skip Boss 2 Q2 Su Zhou";
		this.checkPhuBanDuNguoi.Text = "Fuben on Full Team";
		this.checkAcTacThaiHo.Text = "Rebels in Reed Port";
		this.checkCuoiNguaAcTac.Text = "Mount in Thieves";
		this.checkNeBinh.Text = "Avoid Soldiers Shaolin";
		this.checkBossCuoi.Text = "Skip Last Boss Shaolin";
		this.checkDontAutoPick.Text = "Don't Auto Pickup Fuben";
		this.checkBuffPhuBan.Text = "Always Buff In Fuben";
		this.checkHoTro.Text = "Support Fuben";
		this.checkAlarm.Text = "Alarm";
		this.checkAlarmHp.Text = "When Low HP";
		this.checkAlarmPk.Text = "When PK";
		this.checkAlarmDead.Text = "When Dead";
		this.checkKeoPhuBan.Text = "Auto Pass Fuben";
		this.groupLotus.Text = "Lotus";
		this.checkThangCap.Text = "Auto Level Up if Level <=";
		this.checkHienGameToiDa.Text = "Show Max Game";
		this.checkAnDanhHieu.Text = "Hide Title";
		this.checkDayTayNai.Text = "When Bag is Full";
		this.checkIsHuyQBang.Text = "Cancel Q Bang Material";
		this.checkHuyQBinhMonPhai.Text = "Cancel Q Binh Sect";
		this.checkTangToc.Text = "Run Faster While Trading";
		this.checkKhongDungNgua.Text = "Do Not Use Mount";
		this.checkDungImMienDich.Text = "Stand Still When Immune";
		this.checkLuonHienDoiTruong.Text = "Always Show Team Leader";
		this.checkDungXaPhu.Text = "Use Station Master Teleport";
		this.checkTaoTenDep.Text = "Create Beautiful Name";
		this.checkTheoSauCungMap.Text = "Only Follow Same Map";
		this.checkMapMapTac.Text = "Don't Change Treasure Map";
		this.checkHoldOnPk.Text = "Stand Still After Buff";
		this.groupBox_0.Text = "Items";
		this.checkSapXepTayNai.Text = "Sort Bag";
		this.checkMuaTuBoDan.Text = "Auto Buy Pet Food";
		this.checkDieBuy.Text = "Auto Buy Items After Death";
		this.checkBanRac.Text = "Auto Sell Trash After Fuben";
		this.checkTuTrangBi.Text = "Auto Equip Items Lv <=";
		this.checkHopThanBinh.Text = "Divine Weapon Box";
		this.checkHopDienTich.Text = "Merge Scripture";
		this.checkQuaVuUoc.Text = "Dance Gift";
		this.checkVatCamHoaDai.Text = "Dahlia";
		this.groupHieuSuat.Text = "Performance";
		this.checkMoGameToiDa.Text = "Max Game";
		this.checkAnGameToiDa.Text = "Hide Max Time";
		this.checkTocDoMoGame.Text = "Game Launch Speed";
		this.checkAutoHideGame.Text = "Auto Hide Game";
		this.checkKhongChiemManHinh.Text = "Don't Take Screen";
		this.checkCPU0.Text = "Don't Use CPU[0]";
		this.checkTurnOffShortcutKey.Text = "Don't Use Shortcut Keys";
		this.checkMuteGame.Text = "Mute Game";
		this.checkAutoRun.Text = "Auto Startup";
		this.checkNotifyInbox.Text = "Notify Inbox";
		this.checkTrimMemory.Text = "Trim Memory";
		this.groupDelayAuto.Text = "Delay Auto (ms)";
		this.checkTatAmAuto.Text = "Mute iAuto";
		this.method_3();
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x000BBF6C File Offset: 0x000BA16C
	public void method_2()
	{
		this.checkDayTayNai.Text = "Đầy Tay Nải";
		this.checkIsHuyQBang.Text = "Hủy Q Bang Nguyên Liệu";
		this.checkHuyQBinhMonPhai.Text = "Hủy Q Binh Môn Phái";
		this.checkTangToc.Text = "Không Bay Khi Chạy Thương Nhân";
		this.checkKhongDungNgua.Text = "Không Dùng Ngựa";
		this.checkDungImMienDich.Text = "Đứng im Khi Miễn Dịch";
		this.checkLuonHienDoiTruong.Text = "Luôn Hiện Đội Trưởng";
		this.checkDungXaPhu.Text = "Dùng Xa Phu Dịch Chuyển";
		this.checkTaoTenDep.Text = "Tạo Tên Đẹp";
		this.checkTheoSauCungMap.Text = "Chỉ Theo Sau Cùng Map";
		this.checkMapMapTac.Text = "Không Chuyển Map Mã Tặc";
		this.checkHoldOnPk.Text = "Đứng im Sau Khi Phù Lên";
		this.checkAlarm.Text = "Báo Động";
		this.checkAlarmHp.Text = "Khi Sắp Hết Máu";
		this.checkAlarmPk.Text = "Khi Bị Pk";
		this.checkAlarmDead.Text = "Khi Tử Vong";
		this.groupLotus.Text = "Ngamy";
		this.checkKhongDungXungHu.Text = "Không Dùng Xung Hư";
		this.checkNgamyHoiSinh.Text = "Hồi Sinh Đồng Đội";
		this.checkBuffPet.Text = "Buff Pet";
		this.checkNgamyCungMay.Text = "Buff Cùng Máy";
		this.checkBuffAll.Text = "Buff Tất Cả";
		this.checkCongDiemPet.Text = "Tự Cộng Điểm";
		this.checkUseSkillPet.Text = "Tự Dùng Skill";
		this.checkTuXuatPet.Text = "Tự Triệu Hồi";
		this.checkExitGame.Text = "Thoát Game Khi";
		this.checkExitTuVong.Text = "Tử Vong";
		this.checkExitDone.Text = "Xong Nhiệm Vụ";
		this.checkAutoDone.Text = "Xong Thương Nhân";
		this.checkExitLvl.Text = "Cấp Đạt";
		this.checkExitidle.Text = "Đứng im";
		this.groupPhuBan.Text = "Phụ Bản";
		this.checkTangQuanSonHai.Text = "Đi Quan Sơn Hải Tầng";
		this.checkTriLieu.Text = "Trị Liệu Trước Khi Đi Phụ Bản";
		this.checkDiCoNhanh.Text = "Cờ, Tầm Bảo Nhanh";
		this.checkBoBoss2.Text = "Bỏ Boss 2 Q2 Tô Châu";
		this.checkPhuBanDuNguoi.Text = "Chỉ Phụ Bản Khi Đủ Người";
		this.checkAcTacThaiHo.Text = "Chỉ Đi Ác Tặc Thái Hồ";
		this.checkCuoiNguaAcTac.Text = "Key Cưỡi Ngựa Ác Tặc";
		this.checkNeBinh.Text = "Né Bình Thiếu Thất Sơn";
		this.checkBossCuoi.Text = "Bỏ Boss Cuối Thiếu Thất Sơn";
		this.checkDontAutoPick.Text = "Không Tự Nhặt Phó Bản";
		this.checkBuffPhuBan.Text = "Luôn Buff Trong Phụ Bản";
		this.checkHoTro.Text = "Hỗ Trợ Phụ Bản";
		this.groupTuDong.Text = "Tự Động";
		this.checkDanhTra.Text = "Tự Động Pk";
		this.checkXuongNgua.Text = "Xuống Ngựa Khi Rảnh";
		this.chkTrungSinh.Text = "Trùng Sinh";
		this.checkByPass.Text = "Vượt Captcha";
		this.checkToDoiTuDong.Text = "Tự Tạo Tổ Đội";
		this.checkHoiSinh.Text = "Hồi Sinh";
		this.checkCongTheLuc.Text = "Cộng Điểm Thể Lực";
		this.checkTriLieuTuVong.Text = "Trị Liệu Sau Khi Tử Vong";
		this.checkTriLieuMP.Text = "Trị Liệu Khi MP < 5%";
		this.checkVaoDoiCuoi.Text = "Vào Đội Cuối";
		this.chkAutoCreatePlayer.Text = "Tự Tạo Nhân Vật";
		this.checkDauThai.Text = "Tự Đầu Thai";
		this.checkAccept.Text = "Chấp Nhận Bạn Bè Thêm Đội";
		this.checkAcceptAll.Text = "Chấp Nhận Thêm Đội";
		this.checkDiemDanh.Text = "Tự Điểm Danh";
		this.checkDiaPhu.Text = "Địa Phủ Về";
		this.checkVaoPhai.Text = "Tự Vào Phái";
		this.checkTamXa.Text = "Tầm Xa";
		this.checkThuPet.Text = "Tự Thu Pet Cấp >=";
		this.checkThangCap.Text = "Tự Thăng Cấp <=";
		this.checkBuff.Text = "Hồi Phục";
		this.groupBox_0.Text = "Vật Phẩm";
		this.checkSapXepTayNai.Text = "Tự Sắp Xếp Tay Nải";
		this.checkMuaTuBoDan.Text = "Tự Mua Tư Bổ Đan";
		this.checkDieBuy.Text = "Tự Mua Đồ Sau Khi Chết";
		this.checkBanRac.Text = "Tự Bán Rác Khi Phụ Bản";
		this.checkTuTrangBi.Text = "Tự Trang Bị Đồ Cấp <=";
		this.checkHopThanBinh.Text = "Hộp Thần Binh";
		this.checkHopDienTich.Text = "Hợp Điển Tịch";
		this.checkQuaVuUoc.Text = "Quà Vũ Ước";
		this.checkVatCamHoaDai.Text = "Hoa Đại";
		this.groupHieuSuat.Text = "Hiệu Suất";
		this.checkMoGameToiDa.Text = "Mở Game Tối Đa";
		this.checkAnGameToiDa.Text = "Ẩn Game Tối Đa";
		this.checkTocDoMoGame.Text = "Tốc Độ Mở Game";
		this.checkAutoHideGame.Text = "Tự Ẩn Game";
		this.checkKhongChiemManHinh.Text = "Không Chiếm Màn Hình";
		this.checkCPU0.Text = "Không Dùng CPU[0]";
		this.checkTurnOffShortcutKey.Text = "Không Dùng Phím Tắt";
		this.checkMuteGame.Text = "Tắt Âm Game";
		this.groupDelayAuto.Text = "Delay Auto ms";
		this.method_3();
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x000BC4E0 File Offset: 0x000BA6E0
	private void checkTurnOffShortcutKey_CheckedChanged(object sender, EventArgs e)
	{
		if (!this.bool_0)
		{
			return;
		}
		Class286 @class = sender as Class286;
		if (@class != null)
		{
			if (@class == this.checkBuff)
			{
				Class226.Boolean_161 = @class.Boolean_0;
			}
			if (@class == this.checkAlarm)
			{
				Class226.Boolean_152 = @class.Boolean_0;
			}
			if (@class == this.checkExitGame)
			{
				Class226.Boolean_22 = @class.Boolean_0;
			}
			if (@class == this.checkMP)
			{
				Class226.Boolean_36 = @class.Boolean_0;
			}
			if (@class == this.checkQuyCoc)
			{
				Class226.Boolean_41 = @class.Boolean_0;
			}
			if (@class == this.checkNM)
			{
				Class226.Boolean_37 = @class.Boolean_0;
			}
			if (@class == this.checkTuyetTinh)
			{
				Class226.Boolean_42 = @class.Boolean_0;
			}
			if (@class == this.checkUseItemHP)
			{
				Class226.Boolean_135 = @class.Boolean_0;
			}
			if (@class == this.checkNgaiNguoc)
			{
				Class226.Boolean_162 = @class.Boolean_0;
			}
		}
		CheckBoxComboControl checkBoxComboControl = sender as CheckBoxComboControl;
		if (checkBoxComboControl != null)
		{
			if (checkBoxComboControl == this.checkDiaPhu)
			{
				Class226.Boolean_160 = checkBoxComboControl.Boolean_0;
				Class226.Int32_43 = checkBoxComboControl.Int32_0;
			}
			if (checkBoxComboControl == this.checkVaoPhai)
			{
				Class226.Boolean_130 = checkBoxComboControl.Boolean_0;
				Class106.Class210_0["Settings", "JoinMenpai"] = checkBoxComboControl.ComboBox_0.Text;
			}
			if (checkBoxComboControl == this.checkVatCamHoaDai)
			{
				Class226.Int32_40 = checkBoxComboControl.Int32_0;
				Class226.Boolean_156 = checkBoxComboControl.Boolean_0;
			}
			if (checkBoxComboControl == this.checkQuaVuUoc)
			{
				Class226.Int32_41 = checkBoxComboControl.Int32_0;
				Class226.Boolean_158 = checkBoxComboControl.Boolean_0;
			}
			if (checkBoxComboControl == this.checkHopThanBinh)
			{
				Class226.Int32_42 = checkBoxComboControl.Int32_0;
				Class226.Boolean_157 = checkBoxComboControl.Boolean_0;
			}
			if (checkBoxComboControl == this.checkHopDienTich)
			{
				Class226.Int32_21 = checkBoxComboControl.Int32_0;
				Class226.Boolean_77 = checkBoxComboControl.Boolean_0;
			}
		}
		CheckBoxNumberControl checkBoxNumberControl = sender as CheckBoxNumberControl;
		if (checkBoxNumberControl != null)
		{
			if (checkBoxNumberControl == this.checkSuaTrangBi)
			{
				Class226.Boolean_1 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_2 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkHienGameToiDa)
			{
				Class226.Boolean_56 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_23 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkLogon)
			{
				Class226.Int32_25 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_163 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkTuTrangBi)
			{
				Class226.Int32_38 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_133 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkThangCap)
			{
				Class226.Int32_4 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_24 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkThuPet)
			{
				Class226.Int32_37 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_116 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkTamXa)
			{
				Class226.Int32_35 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_112 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkAnGameToiDa)
			{
				Class226.Boolean_74 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_19 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkTocDoMoGame)
			{
				Class226.Int32_31 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_155 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkMoGameToiDa)
			{
				Class226.Int32_24 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_154 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkTangQuanSonHai)
			{
				Class226.Int32_36 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_153 = checkBoxNumberControl.Boolean_0;
			}
			if (checkBoxNumberControl == this.checkExitOnline)
			{
				Class226.Boolean_66 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_18 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkExitOffline)
			{
				Class226.Boolean_65 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_17 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkExitidle)
			{
				Class226.Boolean_63 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_14 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkExitLvl)
			{
				Class226.Boolean_64 = checkBoxNumberControl.Boolean_0;
				Class226.Int32_16 = (int)checkBoxNumberControl.Decimal_0;
			}
			if (checkBoxNumberControl == this.checkExitDoneOnline)
			{
				Class226.Int32_15 = (int)checkBoxNumberControl.Decimal_0;
				Class226.Boolean_48 = checkBoxNumberControl.Boolean_0;
			}
		}
		CheckBox checkBox = sender as CheckBox;
		if (checkBox != null)
		{
			if (checkBox == this.checkDuyetDongY)
			{
				Class226.Boolean_115 = checkBox.Checked;
			}
			if (checkBox == this.checkKhongTheoKey)
			{
				Class226.Boolean_2 = checkBox.Checked;
				if (Class226.Boolean_2)
				{
					Class238.smethod_3("Không Theo Về Lạc Dương");
				}
				else
				{
					Class238.smethod_3("Theo Về Lạc Dương");
				}
			}
			if (checkBox == this.checkFollow)
			{
				Class226.Boolean_159 = checkBox.Checked;
			}
			if (checkBox == this.checkTatMay)
			{
				Class226.Boolean_8 = checkBox.Checked;
			}
			if (checkBox == this.checkHideChat)
			{
				Class226.Boolean_72 = checkBox.Checked;
				if (Class226.Boolean_72)
				{
					Class106.IEnumerable_0.smethod_22<Class106>(new Action<Class106>(Setting.Class276.f_71A8D4FA.method_0));
				}
			}
			if (checkBox == this.checkNotifyInbox)
			{
				Class226.Boolean_165 = checkBox.Checked;
			}
			if (checkBox == this.checkTatAmAuto)
			{
				Class226.Boolean_142 = checkBox.Checked;
				if (Class226.Boolean_142)
				{
					Class586.smethod_4();
				}
				else if (AlarmContainer.AlarmContainer_0.Controls.Count > 0)
				{
					Class586.smethod_1();
				}
			}
			if (checkBox == this.checkAutoSell)
			{
				Class226.Boolean_4 = checkBox.Checked;
			}
			if (checkBox == this.checkTrimCPU)
			{
				Class226.Boolean_6 = checkBox.Checked;
			}
			if (checkBox == this.checkTriLieuHP)
			{
				Class226.Boolean_120 = checkBox.Checked;
			}
			if (checkBox == this.checkAnDanhHieu)
			{
				Class226.Boolean_30 = checkBox.Checked;
			}
			if (checkBox == this.checkTrimMemory)
			{
				Class226.Boolean_124 = checkBox.Checked;
			}
			if (checkBox == this.checkKeoPhuBan)
			{
				Class226.Boolean_164 = checkBox.Checked;
			}
			if (checkBox == this.checkAutoRun)
			{
				Class226.Boolean_151 = checkBox.Checked;
			}
			if (checkBox == this.checkAlarmHp)
			{
				Class226.Boolean_17 = checkBox.Checked;
			}
			if (checkBox == this.checkHoldOnPk)
			{
				Class226.Boolean_76 = checkBox.Checked;
			}
			if (checkBox == this.checkBuffPet)
			{
				Class226.Boolean_38 = checkBox.Checked;
			}
			if (checkBox == this.checkAccept)
			{
				Class226.Boolean_12 = checkBox.Checked;
			}
			if (checkBox == this.checkAcceptAll)
			{
				Class226.Boolean_13 = checkBox.Checked;
			}
			if (checkBox == this.checkTriLieuMP)
			{
				Class226.Boolean_121 = checkBox.Checked;
			}
			if (checkBox == this.checkDiCoNhanh)
			{
				Class226.Boolean_57 = checkBox.Checked;
			}
			if (checkBox == this.checkPhuBanDuNguoi)
			{
				Class226.Boolean_102 = checkBox.Checked;
			}
			if (checkBox == this.checkDungXaPhu)
			{
				Class226.Boolean_139 = checkBox.Checked;
			}
			if (checkBox == this.checkHoTro)
			{
				Class226.Boolean_78 = checkBox.Checked;
			}
			if (checkBox == this.checkHoiSinh)
			{
				Class226.Boolean_75 = checkBox.Checked;
			}
			if (checkBox == this.checkNgamyHoiSinh)
			{
				Class226.Boolean_97 = checkBox.Checked;
			}
			if (checkBox == this.checkDauThai)
			{
				Class226.Boolean_126 = checkBox.Checked;
			}
			if (checkBox == this.checkCongTheLuc)
			{
				Class226.Boolean_54 = checkBox.Checked;
			}
			if (checkBox == this.checkCongDiemPet)
			{
				Class226.Boolean_53 = checkBox.Checked;
			}
			if (checkBox == this.checkToDoiTuDong)
			{
				Class226.Boolean_129 = checkBox.Checked;
			}
			if (checkBox == this.checkTuXuatPet)
			{
				Class226.Boolean_140 = checkBox.Checked;
			}
			if (checkBox == this.checkXuongNgua)
			{
				Class226.Boolean_131 = checkBox.Checked;
			}
			if (checkBox == this.checkNeBinh)
			{
				Class226.Boolean_96 = checkBox.Checked;
			}
			if (checkBox == this.checkBossCuoi)
			{
				Class226.Boolean_32 = checkBox.Checked;
			}
			if (checkBox == this.checkDanhTra)
			{
				Class226.Boolean_55 = checkBox.Checked;
			}
			if (checkBox == this.checkByPass)
			{
				Class226.Boolean_44 = checkBox.Checked;
			}
			if (checkBox == this.checkDungImMienDich)
			{
				Class226.Boolean_60 = checkBox.Checked;
			}
			if (checkBox == this.checkAutoHideGame)
			{
				Class226.Boolean_23 = checkBox.Checked;
			}
			if (checkBox == this.checkKhongChiemManHinh)
			{
				Class226.Boolean_87 = checkBox.Checked;
			}
			if (checkBox == this.checkBanRac)
			{
				Class226.Boolean_29 = checkBox.Checked;
			}
			if (checkBox == this.checkKhongDungXungHu)
			{
				Class226.Boolean_86 = checkBox.Checked;
			}
			if (checkBox == this.checkAlarmPk)
			{
				Class226.Boolean_18 = checkBox.Checked;
			}
			if (checkBox == this.checkAlarmDead)
			{
				Class226.Boolean_16 = checkBox.Checked;
			}
			if (checkBox == this.checkTriLieu)
			{
				Class226.Boolean_122 = checkBox.Checked;
			}
			if (checkBox == this.checkTheoSauCungMap)
			{
				Class226.Boolean_114 = checkBox.Checked;
			}
			if (checkBox == this.checkBuffPhuBan)
			{
				Class226.Boolean_39 = checkBox.Checked;
			}
			if (checkBox == this.checkTaoTenDep)
			{
				Class226.Boolean_113 = checkBox.Checked;
			}
			if (checkBox == this.checkTangToc)
			{
				Class226.Boolean_85 = checkBox.Checked;
			}
			if (checkBox == this.checkFakeMac)
			{
				Class226.Boolean_68 = checkBox.Checked;
			}
			if (checkBox == this.checkBoBoss2)
			{
				Class226.Boolean_33 = checkBox.Checked;
			}
			if (checkBox == this.checkKhongDungNgua)
			{
				Class226.Boolean_58 = checkBox.Checked;
			}
			if (checkBox == this.checkMuteGame)
			{
				Class226.Boolean_95 = checkBox.Checked;
			}
			if (checkBox == this.checkCPU0)
			{
				Class226.Boolean_89 = checkBox.Checked;
			}
			if (checkBox == this.checkCuoiNguaAcTac)
			{
				Class226.Boolean_82 = checkBox.Checked;
			}
			if (checkBox == this.checkVaoDoiCuoi)
			{
				Class226.Boolean_138 = checkBox.Checked;
			}
			if (checkBox == this.checkTriLieuTuVong)
			{
				Class226.Boolean_123 = checkBox.Checked;
			}
			if (checkBox == this.checkBuffAll)
			{
				Class226.Boolean_34 = checkBox.Checked;
			}
			if (checkBox == this.checkAutoDone)
			{
				Class226.Boolean_7 = checkBox.Checked;
			}
			if (checkBox == this.checkDiemDanh)
			{
				Class226.Boolean_127 = checkBox.Checked;
			}
			if (checkBox == this.checkHuyQBinhMonPhai)
			{
				Class226.Boolean_81 = checkBox.Checked;
			}
			if (checkBox == this.checkDieBuy)
			{
				Class226.Boolean_9 = checkBox.Checked;
			}
			if (checkBox == this.checkAcTacThaiHo)
			{
				Class226.Boolean_14 = checkBox.Checked;
			}
			if (checkBox == this.chkTrungSinh)
			{
				Class226.Boolean_125 = checkBox.Checked;
			}
			if (checkBox == this.checkMapMapTac)
			{
				Class226.Boolean_88 = checkBox.Checked;
			}
			if (checkBox == this.checkDontAutoPick)
			{
				Class226.Boolean_10 = checkBox.Checked;
			}
			if (checkBox == this.checkIsHuyQBang)
			{
				Class226.Boolean_80 = checkBox.Checked;
			}
			if (checkBox == this.checkTurnOffShortcutKey)
			{
				Class226.Boolean_147 = checkBox.Checked;
				if (Class226.Boolean_147)
				{
					GClass2.smethod_0();
				}
				else
				{
					try
					{
						GUI.GUI_0.method_3();
					}
					catch
					{
					}
				}
			}
			if (checkBox == this.checkLuonHienDoiTruong)
			{
				Class226.Boolean_90 = checkBox.Checked;
			}
			if (checkBox == this.checkSapXepTayNai)
			{
				Class226.Boolean_107 = checkBox.Checked;
			}
			if (checkBox == this.checkUseSkillPet)
			{
				Class226.Boolean_136 = checkBox.Checked;
			}
			if (checkBox == this.checkNgamyCungMay)
			{
				Class226.Boolean_35 = checkBox.Checked;
			}
			if (checkBox == this.checkMuaTuBoDan)
			{
				Class226.Boolean_94 = checkBox.Checked;
			}
			if (checkBox == this.checkExitTuVong || checkBox == this.chkAutoCreatePlayer || checkBox == this.checkExitDone)
			{
				if (checkBox == this.checkExitTuVong)
				{
					Class226.Boolean_67 = checkBox.Checked;
				}
				if (checkBox == this.chkAutoCreatePlayer)
				{
					Class226.Boolean_128 = checkBox.Checked;
				}
				if (checkBox == this.checkExitDone)
				{
					Class226.Boolean_62 = checkBox.Checked;
				}
			}
			if (checkBox == this.checkAutoRun)
			{
				Class106.Class210_0["Settings", "checkAutoRun"] = checkBox.Checked.ToString();
				if (checkBox.Checked)
				{
					Setting.smethod_0();
				}
				else
				{
					Setting.smethod_1();
				}
			}
		}
		Control0 control = sender as Control0;
		if (control != null)
		{
			if (control == this.numberQuyCoc)
			{
				Class226.Int32_8 = control.Int32_1;
			}
			else if (control == this.numberTuyetTinh)
			{
				Class226.Int32_9 = control.Int32_1;
			}
			else if (control == this.numberMana)
			{
				Class226.Int32_5 = control.Int32_1;
			}
			else if (control == this.numberDelayAuto)
			{
				Class226.Int32_10 = control.Int32_1;
			}
			else if (control == this.numberUseItemHP)
			{
				Class226.Int32_39 = control.Int32_1;
			}
			else if (control == this.numberNgaiNguoc)
			{
				Class226.Int32_32 = control.Int32_1;
			}
			else if (control == this.numberNM)
			{
				Class226.Int32_6 = control.Int32_1;
			}
		}
		this.method_3();
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x000BD084 File Offset: 0x000BB284
	private void method_3()
	{
		if (Class226.Boolean_61)
		{
			this.checkQuyCoc.Text = "Buff Voodoo " + this.numberQuyCoc.Int32_1.ToString() + "%";
			this.checkNgaiNguoc.Text = "Phoenix Guardian " + this.numberNgaiNguoc.Int32_1.ToString() + "%";
			this.checkNM.Text = "Buff Lotus " + this.numberNM.Int32_1.ToString() + "%";
			this.checkMP.Text = "Buff MP " + this.numberMana.Int32_1.ToString() + "%";
			this.checkTuyetTinh.Text = "Buff Heartless " + this.numberTuyetTinh.Int32_1.ToString() + "%";
			this.checkTriLieuHP.Text = "Heal When Low HP";
			this.checkUseItemHP.Text = "Use Item HP " + this.numberUseItemHP.Int32_1.ToString() + "%";
		}
		else
		{
			this.checkQuyCoc.Text = "Buff Quỷ Cốc " + this.numberQuyCoc.Int32_1.ToString() + "%";
			this.checkNgaiNguoc.Text = "Ngai Ngược " + this.numberNgaiNguoc.Int32_1.ToString() + "%";
			this.checkNM.Text = "Buff Ngamy " + this.numberNM.Int32_1.ToString() + "%";
			this.checkMP.Text = "Buff MP " + this.numberMana.Int32_1.ToString() + "%";
			this.checkTuyetTinh.Text = "Buff Tuyệt Tình " + this.numberTuyetTinh.Int32_1.ToString() + "%";
			this.checkTriLieuHP.Text = "Trị Liệu Khi Hết Máu";
			this.checkUseItemHP.Text = "Ăn Máu " + this.numberUseItemHP.Int32_1.ToString() + "%";
		}
		this.groupDelayAuto.Text = "Delay Auto " + this.numberDelayAuto.Int32_1.ToString() + " ms";
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x000BD30C File Offset: 0x000BB50C
	private void method_4()
	{
		this.checkSuaTrangBi.Boolean_0 = Class226.Boolean_1;
		this.checkSuaTrangBi.Decimal_0 = Class226.Int32_2;
		this.checkDuyetDongY.Checked = Class226.Boolean_115;
		this.checkTatMay.Checked = Class226.Boolean_8;
		this.checkExitDoneOnline.Boolean_0 = Class226.Boolean_48;
		this.checkExitDoneOnline.Decimal_0 = Class226.Int32_18;
		this.checkAutoSell.Checked = Class226.Boolean_4;
		this.checkHideChat.Checked = Class226.Boolean_72;
		this.checkTrimCPU.Checked = Class226.Boolean_6;
		this.checkAlarmDisconnected.Checked = Class226.Boolean_166;
		this.checkNotifyInbox.Checked = Class226.Boolean_165;
		this.checkTatAmAuto.Checked = Class226.Boolean_142;
		this.checkHienGameToiDa.Boolean_0 = Class226.Boolean_56;
		this.checkAnDanhHieu.Checked = Class226.Boolean_30;
		this.checkKeoPhuBan.Checked = Class226.Boolean_164;
		this.checkTrimMemory.Checked = Class226.Boolean_124;
		this.checkLogon.Boolean_0 = Class226.Boolean_163;
		this.checkBuff.Boolean_0 = Class226.Boolean_161;
		this.checkNgaiNguoc.Boolean_0 = Class226.Boolean_162;
		this.checkAutoRun.Checked = Class226.Boolean_151;
		this.checkAlarmHp.Checked = Class226.Boolean_17;
		this.checkAlarm.Boolean_0 = Class226.Boolean_152;
		this.checkThangCap.Boolean_0 = Class226.Boolean_24;
		this.checkThuPet.Boolean_0 = Class226.Boolean_116;
		this.checkTamXa.Boolean_0 = Class226.Boolean_112;
		this.checkAnGameToiDa.Boolean_0 = Class226.Boolean_74;
		this.checkTocDoMoGame.Boolean_0 = Class226.Boolean_155;
		this.checkMoGameToiDa.Boolean_0 = Class226.Boolean_154;
		this.checkTangQuanSonHai.Boolean_0 = Class226.Boolean_153;
		this.checkExitGame.Boolean_0 = Class226.Boolean_22;
		this.checkMP.Boolean_0 = Class226.Boolean_36;
		this.checkQuyCoc.Boolean_0 = Class226.Boolean_41;
		this.checkNM.Boolean_0 = Class226.Boolean_37;
		this.checkTuyetTinh.Boolean_0 = Class226.Boolean_42;
		this.checkTriLieuHP.Checked = Class226.Boolean_120;
		this.checkUseItemHP.Boolean_0 = Class226.Boolean_135;
		this.checkHoldOnPk.Checked = Class226.Boolean_76;
		this.checkBuffPet.Checked = Class226.Boolean_38;
		this.checkAccept.Checked = Class226.Boolean_12;
		this.checkAcceptAll.Checked = Class226.Boolean_13;
		this.checkTriLieuMP.Checked = Class226.Boolean_121;
		this.checkDiCoNhanh.Checked = Class226.Boolean_57;
		this.checkPhuBanDuNguoi.Checked = Class226.Boolean_102;
		this.checkDungXaPhu.Checked = Class226.Boolean_139;
		this.checkHoTro.Checked = Class226.Boolean_78;
		this.checkHoiSinh.Checked = Class226.Boolean_75;
		this.checkNgamyHoiSinh.Checked = Class226.Boolean_97;
		this.checkDauThai.Checked = Class226.Boolean_126;
		this.checkCongTheLuc.Checked = Class226.Boolean_54;
		this.checkCongDiemPet.Checked = Class226.Boolean_53;
		this.checkToDoiTuDong.Checked = Class226.Boolean_129;
		this.checkTuXuatPet.Checked = Class226.Boolean_140;
		this.checkXuongNgua.Checked = Class226.Boolean_131;
		this.checkNeBinh.Checked = Class226.Boolean_96;
		this.checkBossCuoi.Checked = Class226.Boolean_32;
		this.checkDanhTra.Checked = Class226.Boolean_55;
		this.checkByPass.Checked = Class226.Boolean_44;
		this.checkDungImMienDich.Checked = Class226.Boolean_60;
		this.checkAutoHideGame.Checked = Class226.Boolean_23;
		this.checkKhongChiemManHinh.Checked = Class226.Boolean_87;
		this.checkBanRac.Checked = Class226.Boolean_29;
		this.checkKhongDungXungHu.Checked = Class226.Boolean_86;
		this.checkAlarmPk.Checked = Class226.Boolean_18;
		this.checkAlarmDead.Checked = Class226.Boolean_16;
		this.checkTriLieu.Checked = Class226.Boolean_122;
		this.checkTheoSauCungMap.Checked = Class226.Boolean_114;
		this.checkBuffPhuBan.Checked = Class226.Boolean_39;
		this.checkTaoTenDep.Checked = Class226.Boolean_113;
		this.checkTangToc.Checked = Class226.Boolean_85;
		this.checkFakeMac.Checked = Class226.Boolean_68;
		this.checkBoBoss2.Checked = Class226.Boolean_33;
		this.checkKhongDungNgua.Checked = Class226.Boolean_58;
		this.checkMuteGame.Checked = Class226.Boolean_95;
		this.checkCPU0.Checked = Class226.Boolean_89;
		this.checkCuoiNguaAcTac.Checked = Class226.Boolean_82;
		this.checkVaoDoiCuoi.Checked = Class226.Boolean_138;
		this.checkTriLieuTuVong.Checked = Class226.Boolean_123;
		this.checkBuffAll.Checked = Class226.Boolean_34;
		this.checkAutoDone.Checked = Class226.Boolean_7;
		this.checkDiemDanh.Checked = Class226.Boolean_127;
		this.checkHuyQBinhMonPhai.Checked = Class226.Boolean_81;
		this.checkDieBuy.Checked = Class226.Boolean_9;
		this.checkAcTacThaiHo.Checked = Class226.Boolean_14;
		this.chkTrungSinh.Checked = Class226.Boolean_125;
		this.checkMapMapTac.Checked = Class226.Boolean_88;
		this.checkDontAutoPick.Checked = Class226.Boolean_10;
		this.checkIsHuyQBang.Checked = Class226.Boolean_80;
		this.checkTurnOffShortcutKey.Checked = Class226.Boolean_147;
		this.checkLuonHienDoiTruong.Checked = Class226.Boolean_90;
		this.checkSapXepTayNai.Checked = Class226.Boolean_107;
		this.checkUseSkillPet.Checked = Class226.Boolean_136;
		this.checkNgamyCungMay.Checked = Class226.Boolean_35;
		this.checkMuaTuBoDan.Checked = Class226.Boolean_94;
		this.checkExitOffline.Boolean_0 = Class226.Boolean_65;
		this.checkExitidle.Boolean_0 = Class226.Boolean_63;
		this.checkExitOnline.Boolean_0 = Class226.Boolean_66;
		this.checkExitLvl.Boolean_0 = Class226.Boolean_64;
		this.checkExitTuVong.Checked = Class226.Boolean_67;
		this.chkAutoCreatePlayer.Checked = Class226.Boolean_128;
		this.checkExitDone.Checked = Class226.Boolean_62;
		this.checkVatCamHoaDai.Boolean_0 = Class226.Boolean_156;
		this.checkQuaVuUoc.Boolean_0 = Class226.Boolean_158;
		this.checkHopThanBinh.Boolean_0 = Class226.Boolean_157;
		this.checkHopDienTich.Boolean_0 = Class226.Boolean_77;
		this.checkVaoPhai.Boolean_0 = Class226.Boolean_130;
		this.checkDiaPhu.Boolean_0 = Class226.Boolean_160;
		this.checkFollow.Checked = Class226.Boolean_159;
		this.checkHienGameToiDa.Decimal_0 = Class226.Int32_23;
		this.checkLogon.Decimal_0 = Class226.Int32_25;
		this.checkTuTrangBi.Boolean_0 = Class226.Boolean_133;
		this.checkTuTrangBi.Decimal_0 = Class226.Int32_38;
		this.checkThangCap.Decimal_0 = Class226.Int32_4;
		this.checkThuPet.Decimal_0 = Class226.Int32_37;
		this.checkTamXa.Decimal_0 = Class226.Int32_35;
		this.checkAnGameToiDa.Decimal_0 = Class226.Int32_19;
		this.checkTocDoMoGame.Decimal_0 = Class226.Int32_31;
		this.checkMoGameToiDa.Decimal_0 = Class226.Int32_24;
		this.checkTangQuanSonHai.Decimal_0 = Class226.Int32_36;
		this.checkExitOnline.Decimal_0 = Class226.Int32_18;
		this.checkExitidle.Decimal_0 = Class226.Int32_14;
		this.checkExitOffline.Decimal_0 = Class226.Int32_17;
		this.checkExitLvl.Decimal_0 = Class226.Int32_16;
		this.checkVatCamHoaDai.Int32_0 = Class226.Int32_40;
		this.checkQuaVuUoc.Int32_0 = Class226.Int32_41;
		this.checkHopThanBinh.Int32_0 = Class226.Int32_42;
		this.checkHopDienTich.Int32_0 = Class226.Int32_21;
		this.checkDiaPhu.Int32_0 = Class226.Int32_43;
		this.numberNM.Int32_1 = Class226.Int32_6;
		this.numberQuyCoc.Int32_1 = Class226.Int32_8;
		this.numberTuyetTinh.Int32_1 = Class226.Int32_9;
		this.numberMana.Int32_1 = Class226.Int32_5;
		this.numberDelayAuto.Int32_1 = Class226.Int32_10;
		this.numberUseItemHP.Int32_1 = Class226.Int32_39;
		this.numberNgaiNguoc.Int32_1 = Class226.Int32_32;
		this.method_3();
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x000BDBD0 File Offset: 0x000BBDD0
	private void Setting_Load(object sender, EventArgs e)
	{
		ComboBox.ObjectCollection items = this.checkVaoPhai.ComboBox_0.Items;
		object[] array = Class501.Dictionary_0.Values.ToArray<string>();
		items.AddRange(array);
		this.checkVaoPhai.ComboBox_0.SelectedIndex = this.checkVaoPhai.ComboBox_0.Items.IndexOf(Class106.Class210_0["Settings", "JoinMenpai"]);
		this.checkVatCamHoaDai.ComboBox_0.Items.AddRange(new object[] { "None", "Kim Tằm Ti", "Chân Nguyên Phách", "Cửu Thiên Ngọc Toái", "Dao Hoa Bích" });
		this.checkQuaVuUoc.ComboBox_0.Items.AddRange(new object[] { "None", "Kim Tinh Thạch", "Câu Thiên Thái", "Cửu Thiên Ngọc Toái" });
		this.checkHopThanBinh.ComboBox_0.Items.AddRange(new object[] { "None", "Huyền Binh Thạch", "Mệnh Hồn Ngọc", "Phục Hy Ngọc" });
		this.checkHopDienTich.ComboBox_0.Items.AddRange(new object[] { "None", "Xanh", "Tím", "Cam" });
		this.checkDiaPhu.ComboBox_0.Items.AddRange(new object[] { "None", "Lạc Dương", "Tô Châu", "Đại Lý", "Lâu Lan" });
		try
		{
			this.method_4();
		}
		catch (Exception ex)
		{
			MessBox.smethod_0(ex.ToString());
		}
		finally
		{
			this.bool_0 = true;
		}
		if (Class226.Boolean_61)
		{
			this.method_1();
		}
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x000BDDBC File Offset: 0x000BBFBC
	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		if (this.pictureBox_0 == null || this.pictureBox_0.IsDisposed)
		{
			this.pictureBox_0 = new PictureBox
			{
				Image = Class616.Bitmap_0,
				Dock = DockStyle.Fill,
				SizeMode = PictureBoxSizeMode.StretchImage
			};
			base.Controls.Add(this.pictureBox_0);
			this.pictureBox_0.BringToFront();
		}
		if (this.timer_1 != null)
		{
			this.timer_1.Stop();
			this.timer_1.Dispose();
		}
		this.timer_1 = new global::System.Timers.Timer(300.0);
		this.timer_1.Elapsed += this.timer_1_Elapsed;
		this.timer_1.Start();
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x000BDE74 File Offset: 0x000BC074
	private void method_5(string string_0)
	{
		Setting.Class277 @class = new Setting.Class277();
		@class.string_0 = string_0;
		if (string.IsNullOrEmpty(@class.string_0))
		{
			Action<Control.ControlCollection> action = new Action<Control.ControlCollection>(Setting.Class276.f_71A8D4FA.method_1);
			action(this.paneleft.Controls);
			action(this.panelRight.Controls);
			return;
		}
		Action<Control.ControlCollection> action2 = new Action<Control.ControlCollection>(@class.method_0);
		action2(this.paneleft.Controls);
		action2(this.panelRight.Controls);
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x000BDF0C File Offset: 0x000BC10C
	private static void smethod_0()
	{
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
		{
			registryKey.SetValue("iAuto", "\"" + Application.ExecutablePath + "\"");
		}
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x000BDF68 File Offset: 0x000BC168
	private static void smethod_1()
	{
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
		{
			registryKey.DeleteValue("iAuto", false);
		}
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x0000500B File Offset: 0x0000320B
	private void checkHienGameToiDa_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0000500B File Offset: 0x0000320B
	private void checkExitDoneOnline_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00010110 File Offset: 0x0000E310
	[CompilerGenerated]
	private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
	{
		this.timer_1.Stop();
		this.timer_1.Dispose();
		base.Invoke(new Action(this.method_6));
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x000BDFB0 File Offset: 0x000BC1B0
	[CompilerGenerated]
	private void method_6()
	{
		string text = this.txtSearch.Text.smethod_36();
		this.method_5(text);
		this.pictureBox_0.Dispose();
	}

	// Token: 0x04000E20 RID: 3616
	private global::System.Windows.Forms.Timer timer_0 = new global::System.Windows.Forms.Timer
	{
		Interval = 100
	};

	// Token: 0x04000E21 RID: 3617
	private IContainer icontainer_0;

	// Token: 0x04000EA2 RID: 3746
	private global::System.Timers.Timer timer_1;

	// Token: 0x04000EA3 RID: 3747
	private PictureBox pictureBox_0;

	// Token: 0x04000EA4 RID: 3748
	private bool bool_0;

	// Token: 0x02000193 RID: 403
	[CompilerGenerated]
	[Serializable]
	private sealed class Class276
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00010147 File Offset: 0x0000E347
		internal void method_0(Class106 class106_0)
		{
			class106_0.method_375("setmetatable(_G, {__index = ChatFrame_Env }); if this ~= nil and this:IsVisible() then this:Hide(); end", false);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
		internal void method_1(Control.ControlCollection controlCollection_0)
		{
			foreach (object obj in controlCollection_0)
			{
				Control control = (Control)obj;
				bool flag = true;
				foreach (object obj2 in control.Controls)
				{
					Control control2 = (Control)obj2;
					bool flag2 = true;
					flag = true;
					control2.Visible = flag2;
				}
				control.Visible = flag;
			}
		}

		// Token: 0x04000EA5 RID: 3749
		public static readonly Setting.Class276 f_71A8D4FA = new Setting.Class276();

		// Token: 0x04000EA6 RID: 3750
		public static Action<Class106> f_CDE08899;

		// Token: 0x04000EA7 RID: 3751
		public static Action<Control.ControlCollection> f_8AFE14F9;
	}

	// Token: 0x02000194 RID: 404
	[CompilerGenerated]
	private sealed class Class277
	{
		// Token: 0x0600173C RID: 5948 RVA: 0x000BE088 File Offset: 0x000BC288
		internal void method_0(Control.ControlCollection controlCollection_0)
		{
			foreach (object obj in controlCollection_0)
			{
				Control control = (Control)obj;
				bool flag;
				if (!(flag = string.IsNullOrEmpty(this.string_0) || control.Text.smethod_36().Contains(this.string_0)))
				{
					foreach (object obj2 in control.Controls)
					{
						Control control2 = (Control)obj2;
						if (control2.Text.smethod_36().Contains(this.string_0))
						{
							Control control3 = control2;
							bool flag2 = true;
							flag = true;
							control3.Visible = flag2;
						}
						else
						{
							control2.Visible = false;
						}
					}
				}
				control.Visible = flag;
			}
		}

		// Token: 0x04000EA8 RID: 3752
		public string string_0;
	}
}
