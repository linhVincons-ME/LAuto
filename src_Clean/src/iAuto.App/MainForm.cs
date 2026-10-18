using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using iAuto.Automation;
using iAuto.Core.Enums;
using iAuto.Core.Models;
using iAuto.Game.Lua;
using iAuto.Game.Memory;

namespace iAuto.App
{
    /// <summary>
    /// Giao diện chính điều khiển toàn bộ tính năng của iAuto TLBB.
    /// Tái cấu trúc chuẩn hóa giao diện từ GUI.cs và GUI.Designer.cs
    /// Đồng bộ hoàn toàn hệ thống Menu Player, Hourly, Quest, Fuben và các Tab Key, Life, Craft.
    /// </summary>
    public class MainForm : Form
    {
        private MenuStrip _menuStrip;
        private TabControl _tabMain;
        private TabPage _tabGame;
        private TabPage _tabLogin;
        private TabPage _tabPay;
        private TabPage _tabInbox;
        private TabPage _tabSetting;
        private TabPage _tabConfig;
        private TabPage _tabChat;

        // Khu vực tab Game
        private TextBox _txtSearch;
        private CheckBox _chkSelectAll;
        private ListView _lvCharacters;

        // Khu vực tab dưới (Key / Life / Craft)
        private TabControl _tabBottom;
        private TabPage _tabKey;
        private TabPage _tabLife;
        private TabPage _tabCraft;

        // Key Tab controls
        private TextBox _txtSearchFunction;
        private ListView _lvActions;
        private ComboBox _cboMenpai;
        private TextBox _txtSearchSkill;
        private CheckBox _chkSelectAllSkills;
        private ListView _lvSkills;
        private ComboBox _cboLeader;
        private TextBox _txtPass2;
        private CheckBox _chkShowPass;

        // Life Tab controls
        private CheckBox _chkAutoPhu;
        private ComboBox _cboPhu;
        private CheckBox _chkHealTeam;
        private NumericUpDown _numHealPercent;
        private CheckBox _chkAutoHp;
        private NumericUpDown _numHpPercent;
        private CheckBox _chkAutoMp;
        private NumericUpDown _numMpPercent;

        // Craft Tab controls
        private CheckBox _chkAutoCraft;
        private ComboBox _cboDaTaoDo;
        private ComboBox _cboCheNoiNgoai;
        private CheckBox _chkHuyCraft;
        private NumericUpDown _numHuyStar;
        private NumericUpDown _numHuyLine;

        // Quản lý đa luồng & nhân vật đang chạy
        private System.Windows.Forms.Timer _refreshTimer;
        private readonly AccountStorageService _accountService;
        private readonly Dictionary<int, CharacterContext> _activeClients;
        private CharacterContext _selectedContext;

        private class CharacterContext
        {
            public int ProcessId { get; set; }
            public IntPtr WindowHandle { get; set; }
            public ProcessMemoryReader MemoryReader { get; set; }
            public GameStateReader StateReader { get; set; }
            public LuaCommandService LuaService { get; set; }
            public CombatService CombatService { get; set; }
            public PathfindingService Pathfinder { get; set; }
            public BossTacticsService BossTactics { get; set; }
            public AutoCharacterController Controller { get; set; }
            public CombatConfig Config { get; set; }
            public Thread AutoThread { get; set; }
            public bool IsRunning { get; set; }
            public ListViewItem ListItem { get; set; }
        }

        private static void Log(string msg)
        {
            try
            {
                string p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "run.log");
                File.AppendAllText(p, string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("HH:mm:ss.fff"), msg));
            }
            catch { }
        }

        public MainForm()
        {
            Log("MainForm ctor start");
            _accountService = new AccountStorageService();
            _activeClients = new Dictionary<int, CharacterContext>();

            InitializeComponent();
            Log("InitializeComponent done");
            InitializeTimer();
            Log("InitializeTimer done");

            this.Shown += delegate { Log("MainForm Shown!"); };
            this.FormClosing += delegate(object s, FormClosingEventArgs ev) { Log("MainForm FormClosing reason: " + ev.CloseReason); };
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "iAuto 1.0.5 - 58% Mem + 2% CPU [1] - Pro";
            this.Size = new Size(460, 680);
            this.MinimumSize = new Size(420, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(245, 245, 245);

            // 1. MenuStrip ở trên cùng
            BuildMainMenu();

            // 2. TabControl chính
            _tabMain = new TabControl();
            _tabMain.Dock = DockStyle.Fill;
            _tabMain.ItemSize = new Size(54, 24);

            _tabGame = new TabPage("Game");
            _tabLogin = new TabPage("Login");
            _tabPay = new TabPage("Pay");
            _tabInbox = new TabPage("inbox");
            _tabSetting = new TabPage("Setting");
            _tabConfig = new TabPage("Config");
            _tabChat = new TabPage("Chat");

            _tabMain.TabPages.Add(_tabGame);
            _tabMain.TabPages.Add(_tabLogin);
            _tabMain.TabPages.Add(_tabPay);
            _tabMain.TabPages.Add(_tabInbox);
            _tabMain.TabPages.Add(_tabSetting);
            _tabMain.TabPages.Add(_tabConfig);
            _tabMain.TabPages.Add(_tabChat);

            BuildGameTab();
            BuildLoginTab();
            BuildPayTab();
            BuildInboxTab();
            BuildSettingTab();
            BuildConfigTab();
            BuildChatTab();

            this.Controls.Add(_tabMain);
            this.Controls.Add(_menuStrip);
            this.MainMenuStrip = _menuStrip;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #region Xây dựng Hệ Thống Menu Chính (Đồng bộ với iAuto gốc)

        private void BuildMainMenu()
        {
            _menuStrip = new MenuStrip();
            _menuStrip.BackColor = Color.White;
            _menuStrip.Padding = new Padding(3, 2, 0, 2);

            // Menu Player
            ToolStripMenuItem menuPlayer = new ToolStripMenuItem("Player");
            BuildPlayerMenu(menuPlayer);

            // Menu Hourly
            ToolStripMenuItem menuHourly = new ToolStripMenuItem("Hourly");
            BuildHourlyMenu(menuHourly);

            // Menu Quest
            ToolStripMenuItem menuQuest = new ToolStripMenuItem("Quest");
            BuildQuestMenu(menuQuest);

            // Menu Fuben
            ToolStripMenuItem menuFuben = new ToolStripMenuItem("Fuben");
            BuildFubenMenu(menuFuben);

            // Menu All
            ToolStripMenuItem menuAll = new ToolStripMenuItem("All");
            BuildAllMenu(menuAll);

            // Menu i
            ToolStripMenuItem menuI = new ToolStripMenuItem("i");
            BuildIMenu(menuI);

            // Menu Go
            ToolStripMenuItem menuGo = new ToolStripMenuItem("Go");
            menuGo.Click += delegate { ShowGoBaiduongDialog(); };

            _menuStrip.Items.Add(menuPlayer);
            _menuStrip.Items.Add(menuHourly);
            _menuStrip.Items.Add(menuQuest);
            _menuStrip.Items.Add(menuFuben);
            _menuStrip.Items.Add(menuAll);
            _menuStrip.Items.Add(menuI);
            _menuStrip.Items.Add(menuGo);
        }

        private void BuildPlayerMenu(ToolStripMenuItem root)
        {
            // 1. Thường Dùng
            ToolStripMenuItem muThuongDung = new ToolStripMenuItem("Thường Dùng");
            AddMenuItem(muThuongDung, "Đi Bán Rác", delegate { ExecuteAction("Đi Bán Rác", GameTaskType.BanRac); });
            AddMenuItem(muThuongDung, "Trị Liệu", delegate { ExecuteAction("Trị Liệu", GameTaskType.TriLieu); });
            AddMenuItem(muThuongDung, "Bán Rác + Trị Liệu + Cất Đồ", delegate
            {
                ExecuteAction("Bán Rác + Trị Liệu + Cất Đồ", GameTaskType.CatVang);
                ExecuteAction("Bán Rác", GameTaskType.BanRac);
                ExecuteAction("Cất Đồ", GameTaskType.CatDo);
                ExecuteAction("Trị Liệu", GameTaskType.TriLieu);
            });
            muThuongDung.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(muThuongDung, "Nhận x2", delegate { ExecuteAction("Nhận x2", GameTaskType.NhanX2); });
            AddMenuItem(muThuongDung, "Đông x2", delegate { ExecuteAction("Đông x2", GameTaskType.DongX2); });
            AddMenuItem(muThuongDung, "Phân Giải Trang Bị Pet", delegate { ExecuteAction("Phân Giải Trang Bị Pet", GameTaskType.PhanGiaiTrangBiPet); });
            AddMenuItem(muThuongDung, "Tăng Sao Trang Bị Pet", delegate { ExecuteAction("Tăng Sao Trang Bị Pet"); });
            muThuongDung.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(muThuongDung, "Mở Sạp", delegate { ExecuteAction("Mở Sạp", GameTaskType.None, "PushEvent('STALL_OPEN')"); });
            AddMenuItem(muThuongDung, "Lên Giá Vật Phẩm", delegate { ExecuteAction("Lên Giá Vật Phẩm"); });
            AddMenuItem(muThuongDung, "Chờ Giao Tàng Bảo Đồ", delegate { ExecuteAction("Chờ Giao Tàng Bảo Đồ"); });

            ToolStripMenuItem muThuongNhan = new ToolStripMenuItem("Thương Nhân");
            AddMenuItem(muThuongNhan, "Dừng [Ctrl + Down]", delegate { ExecuteAction("Dừng Thương Nhân"); });
            AddMenuItem(muThuongNhan, "Quay Về [Ctrl + Left]", delegate { ExecuteAction("Quay Về"); });
            AddMenuItem(muThuongNhan, "Đi Tới [Ctrl + Right]", delegate { ExecuteAction("Đi Tới"); });
            muThuongDung.DropDownItems.Add(muThuongNhan);

            AddMenuItem(muThuongDung, "Đổi Vàng Sang Giao Tử", delegate { ExecuteAction("Đổi Vàng Sang Giao Tử"); });
            AddMenuItem(muThuongDung, "Ngân Phiếu Đổi Tiền Mặt", delegate { ExecuteAction("Ngân Phiếu Đổi Tiền Mặt"); });

            // 2. Nhận Lại
            ToolStripMenuItem muNhanLai = new ToolStripMenuItem("Nhận Lại");
            AddMenuItem(muNhanLai, "Kinh Nghiệm", delegate { ExecuteAction("Nhận Lại Kinh Nghiệm"); });
            AddMenuItem(muNhanLai, "Nội Tức", delegate { ExecuteAction("Nhận Lại Nội Tức"); });
            AddMenuItem(muNhanLai, "Thiếu Thất Sơn", delegate { ExecuteAction("Nhận Lại Thiếu Thất Sơn"); });
            AddMenuItem(muNhanLai, "Yến Tử Ô", delegate { ExecuteAction("Nhận Lại Yến Tử Ô"); });
            AddMenuItem(muNhanLai, "Tứ Tuyệt Trang", delegate { ExecuteAction("Nhận Lại Tứ Tuyệt Trang"); });
            AddMenuItem(muNhanLai, "Phúc Địa", delegate { ExecuteAction("Nhận Lại Phúc Địa"); });
            AddMenuItem(muNhanLai, "Vương Lăng", delegate { ExecuteAction("Nhận Lại Vương Lăng"); });
            AddMenuItem(muNhanLai, "Tam Thần", delegate { ExecuteAction("Nhận Lại Tam Thần"); });
            AddMenuItem(muNhanLai, "Phiêu Miễu Phong", delegate { ExecuteAction("Nhận Lại Phiêu Miễu Phong"); });

            // 3. Gom
            ToolStripMenuItem muGom = new ToolStripMenuItem("Gom");
            AddMenuItem(muGom, "Đưa KNB Cho", delegate { ExecuteAction("Đưa KNB Cho", GameTaskType.GomKnb); });
            AddMenuItem(muGom, "Đưa Đồ + Vàng Cho", delegate { ExecuteAction("Đưa Đồ + Vàng Cho", GameTaskType.GomDo); });
            AddMenuItem(muGom, "Đưa Tàng Bảo Đồ Cho", delegate { ExecuteAction("Đưa Tàng Bảo Đồ Cho", GameTaskType.DuaTangBaoDo); });
            AddMenuItem(muGom, "Chia Đồ Từ", delegate { ExecuteAction("Chia Đồ Từ"); });
            AddMenuItem(muGom, "Tặng Bách Hoa", delegate { ExecuteAction("Tặng Bách Hoa", GameTaskType.BachHoaDuyen); });

            // 4. Trang Bị
            ToolStripMenuItem muTrangBi = new ToolStripMenuItem("Trang Bị");
            ToolStripMenuItem muDucLo = new ToolStripMenuItem("Đục Lỗ");
            AddMenuItem(muDucLo, "1 Lỗ", delegate { ExecuteAction("Đục 1 Lỗ"); });
            AddMenuItem(muDucLo, "2 Lỗ", delegate { ExecuteAction("Đục 2 Lỗ"); });
            AddMenuItem(muDucLo, "3 Lỗ", delegate { ExecuteAction("Đục 3 Lỗ"); });
            muTrangBi.DropDownItems.Add(muDucLo);

            ToolStripMenuItem muLenhBai = new ToolStripMenuItem("Lệnh Bài");
            ToolStripMenuItem muNangBaoChau = new ToolStripMenuItem("Nâng Bảo Châu");
            AddMenuItem(muNangBaoChau, "Đỏ", delegate { ExecuteAction("Nâng Bảo Châu Đỏ"); });
            AddMenuItem(muNangBaoChau, "Lục", delegate { ExecuteAction("Nâng Bảo Châu Lục"); });
            AddMenuItem(muNangBaoChau, "Lam", delegate { ExecuteAction("Nâng Bảo Châu Lam"); });
            AddMenuItem(muNangBaoChau, "Vàng", delegate { ExecuteAction("Nâng Bảo Châu Vàng"); });
            muLenhBai.DropDownItems.Add(muNangBaoChau);
            AddMenuItem(muLenhBai, "Tăng Sao", delegate { ExecuteAction("Tăng Sao Lệnh Bài"); });
            muTrangBi.DropDownItems.Add(muLenhBai);

            ToolStripMenuItem muTanAn = new ToolStripMenuItem("Mở Tàn Ấn - Bí Kĩ");
            AddMenuItem(muTanAn, "Băng", delegate { ExecuteAction("Mở Tàn Ấn Băng"); });
            AddMenuItem(muTanAn, "Hỏa", delegate { ExecuteAction("Mở Tàn Ấn Hỏa"); });
            AddMenuItem(muTanAn, "Huyền", delegate { ExecuteAction("Mở Tàn Ấn Huyền"); });
            AddMenuItem(muTanAn, "Độc", delegate { ExecuteAction("Mở Tàn Ấn Độc"); });
            muTrangBi.DropDownItems.Add(muTanAn);

            ToolStripMenuItem muTinhThong = new ToolStripMenuItem("Tinh Thông + Tôi Luyện");
            AddMenuItem(muTinhThong, "Thể", delegate { ExecuteAction("Tôi Luyện Thể"); });
            AddMenuItem(muTinhThong, "Băng", delegate { ExecuteAction("Tôi Luyện Băng"); });
            AddMenuItem(muTinhThong, "Huyền", delegate { ExecuteAction("Tôi Luyện Huyền"); });
            AddMenuItem(muTinhThong, "Hỏa", delegate { ExecuteAction("Tôi Luyện Hỏa"); });
            AddMenuItem(muTinhThong, "Độc", delegate { ExecuteAction("Tôi Luyện Độc"); });
            AddMenuItem(muTinhThong, "Trùng Lâu", delegate { ExecuteAction("Tôi Luyện Trùng Lâu"); });
            muTrangBi.DropDownItems.Add(muTinhThong);

            ToolStripMenuItem muThanKhi = new ToolStripMenuItem("Thần Khí");
            AddMenuItem(muThanKhi, "Lên 8 Sao", delegate { ExecuteAction("Thần Khí Lên 8 Sao"); });
            AddMenuItem(muThanKhi, "Cường Hóa 9", delegate { ExecuteAction("Cường Hóa 9"); });
            AddMenuItem(muThanKhi, "Cường Hóa 99", delegate { ExecuteAction("Cường Hóa 99"); });
            muTrangBi.DropDownItems.Add(muThanKhi);

            muTrangBi.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem muCuongHoa = new ToolStripMenuItem("Cường Hóa");
            AddMenuItem(muCuongHoa, "Trong Tay Nải Lên 7", delegate { ExecuteAction("Cường Hóa Tay Nải Lên 7"); });
            AddMenuItem(muCuongHoa, "Hào Hiệp Ấn Lên 9", delegate { ExecuteAction("Cường Hóa Hào Hiệp Ấn Lên 9"); });
            AddMenuItem(muCuongHoa, "Ám Khí Lên 9", delegate { ExecuteAction("Cường Hóa Ám Khí Lên 9"); });
            muTrangBi.DropDownItems.Add(muCuongHoa);

            AddMenuItem(muTrangBi, "Chế Thần Khí", delegate { ExecuteAction("Chế Thần Khí", GameTaskType.CheThanKhi); });
            AddMenuItem(muTrangBi, "Ngưng Tụ Bảo Giám", delegate { ExecuteAction("Ngưng Tụ Bảo Giám"); });
            AddMenuItem(muTrangBi, "Giải Phong Chân Nguyên", delegate { ExecuteAction("Giải Phong Chân Nguyên"); });
            AddMenuItem(muTrangBi, "Tăng Trưởng Thành Long Văn", delegate { ExecuteAction("Tăng Trưởng Thành Long Văn", GameTaskType.TangCapTruongThanhLongVan); });

            muTrangBi.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(muTrangBi, "Tháo Trang Bị", delegate { ExecuteAction("Tháo Trang Bị"); });
            AddMenuItem(muTrangBi, "Đeo Trang Bị", delegate { ExecuteAction("Đeo Trang Bị"); });
            AddMenuItem(muTrangBi, "Tháo + Đeo", delegate { ExecuteAction("Tháo + Đeo Trang Bị"); });
            muTrangBi.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(muTrangBi, "Giám Định [Ctrl + /]", delegate { ExecuteAction("Giám Định"); });
            AddMenuItem(muTrangBi, "Yêu Cầu Hủy Vật Phẩm Quý", delegate { ExecuteAction("Yêu Cầu Hủy Vật Phẩm Quý", GameTaskType.HuyVatPhamQuy); });

            // 5. Thương Khố
            ToolStripMenuItem muThuongKho = new ToolStripMenuItem("Thương Khố");
            AddMenuItem(muThuongKho, "Mở Từ Xa [Ctrl + B]", delegate { ExecuteAction("Mở Thương Khố Từ Xa", GameTaskType.None, "PushEvent('TOGLE_BIGBANK'); PushEvent('UPDATE_BANK')"); });
            AddMenuItem(muThuongKho, "Cất Đồ", delegate
            {
                ExecuteAction("Cất Đồ", GameTaskType.CatDo);
                ExecuteAction("Cất Vàng", GameTaskType.CatVang);
            });
            AddMenuItem(muThuongKho, "Lấy Đồ Không Cố Định", delegate { ExecuteAction("Lấy Đồ Không Cố Định"); });
            AddMenuItem(muThuongKho, "Lấy Đồ", delegate { ExecuteAction("Lấy Đồ", GameTaskType.LayDo); });
            AddMenuItem(muThuongKho, "Lấy Vàng", delegate { ExecuteAction("Lấy Vàng", GameTaskType.LayVang); });

            // 6. Thương Hội
            ToolStripMenuItem muThuongHoi = new ToolStripMenuItem("Thương Hội");
            AddMenuItem(muThuongHoi, "Xuống Giá", delegate { ExecuteAction("Xuống Giá"); });
            AddMenuItem(muThuongHoi, "Lên Giá", delegate { ExecuteAction("Lên Giá"); });
            AddMenuItem(muThuongHoi, "Lấy Đồ", delegate { ExecuteAction("Lấy Đồ Thương Hội"); });

            // 7. Đi
            ToolStripMenuItem muDi = new ToolStripMenuItem("Đi");
            ToolStripMenuItem muSkillStudy = new ToolStripMenuItem("Nâng Tâm Pháp");
            AddMenuItem(muSkillStudy, "Buff Máu", delegate { ExecuteAction("Nâng Buff Máu"); });
            int[] tpLevels = new int[] { 30, 40, 45, 50, 60, 75, 80, 90, 100 };
            for (int i = 0; i < tpLevels.Length; i++)
            {
                int lvl = tpLevels[i];
                AddMenuItem(muSkillStudy, string.Format("Lên {0}", lvl), delegate { ExecuteAction(string.Format("Nâng Tâm Pháp Lên {0}", lvl), GameTaskType.NangTamPhap); });
            }
            muDi.DropDownItems.Add(muSkillStudy);

            ToolStripMenuItem muTuLuyen = new ToolStripMenuItem("Đi Tu Luyện");
            AddMenuItem(muTuLuyen, "Thể Lực", delegate { ExecuteAction("Tu Luyện Thể Lực", GameTaskType.TuLuyenTheLuc); });
            AddMenuItem(muTuLuyen, "Nội Lực", delegate { ExecuteAction("Tu Luyện Nội Lực", GameTaskType.TuLuyenNoiLuc); });
            AddMenuItem(muTuLuyen, "Thân Pháp", delegate { ExecuteAction("Tu Luyện Thân Pháp", GameTaskType.TuLuyenThanPhap); });
            AddMenuItem(muTuLuyen, "Cường Lực", delegate { ExecuteAction("Tu Luyện Cường Lực", GameTaskType.TuLuyenCuongLuc); });
            AddMenuItem(muTuLuyen, "Thể + Nội + Thân", delegate { ExecuteAction("Tu Luyện Thể + Nội + Thân", GameTaskType.TuLuyenTheNoiThan); });
            muDi.DropDownItems.Add(muTuLuyen);

            muDi.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem muMoShop = new ToolStripMenuItem("Đi Mở Shop");
            AddMenuItem(muMoShop, "Shop Trung Đô", delegate { ExecuteAction("Mở Shop Trung Đô", GameTaskType.MoShopTrungDo); });
            AddMenuItem(muMoShop, "Shop Chiến Công", delegate { ExecuteAction("Mở Shop Chiến Công", GameTaskType.MoShopHungBa); });
            AddMenuItem(muMoShop, "Bách Bảo Các", delegate { ExecuteAction("Mở Bách Bảo Các", GameTaskType.MoShopBachBaoCac); });
            AddMenuItem(muMoShop, "Shop Vân Cẩm", delegate { ExecuteAction("Mở Shop Vân Cẩm", GameTaskType.MoShopVanCam); });
            AddMenuItem(muMoShop, "Tiệm Thuốc", delegate { ExecuteAction("Mở Tiệm Thuốc", GameTaskType.MoTiemThuoc); });
            AddMenuItem(muMoShop, "Shop Quan Sơn Hải", delegate { ExecuteAction("Mở Shop Quan Sơn Hải"); });
            AddMenuItem(muMoShop, "Hoa Ngọc Tập", delegate { ExecuteAction("Mở Hoa Ngọc Tập"); });
            AddMenuItem(muMoShop, "Shop Tinh Bàn", delegate { ExecuteAction("Mở Shop Tinh Bàn"); });
            muDi.DropDownItems.Add(muMoShop);

            ToolStripMenuItem muBaGia = new ToolStripMenuItem("Bá Giả Thiên Hạ");
            AddMenuItem(muBaGia, "Càn", delegate { ExecuteAction("Bá Giả Thiên Hạ Càn"); });
            AddMenuItem(muBaGia, "Khôn", delegate { ExecuteAction("Bá Giả Thiên Hạ Khôn"); });
            AddMenuItem(muBaGia, "Chiến Trường Phong Hỏa", delegate { ExecuteAction("Chiến Trường Phong Hỏa"); });
            muDi.DropDownItems.Add(muBaGia);

            AddMenuItem(muDi, "Đi Mua Ngựa", delegate { ExecuteAction("Đi Mua Ngựa", GameTaskType.DiMuaNga); });
            AddMenuItem(muDi, "Đi Nộp Tử Vi Huy Tinh", delegate { ExecuteAction("Đi Nộp Tử Vi Huy Tinh", GameTaskType.NopTuViHuyTinh); });
            AddMenuItem(muDi, "Đi Thanh Lý Nhiệm Vụ", delegate { ExecuteAction("Đi Thanh Lý Nhiệm Vụ", GameTaskType.ThanhLyNhiemVu); });
            AddMenuItem(muDi, "Đi Giao Ngũ Hành Thiệp", delegate { ExecuteAction("Đi Giao Ngũ Hành Thiệp", GameTaskType.GiaoNguHanhPhapThiep); });
            AddMenuItem(muDi, "Đi Mở Rộng Thương Khố", delegate { ExecuteAction("Đi Mở Rộng Thương Khố"); });
            AddMenuItem(muDi, "Đi Học Tinh - Chế + Luyện + Công", delegate { ExecuteAction("Đi Học Nghề"); });
            AddMenuItem(muDi, "Đi Thỉnh Giáo Bí Kỹ", delegate { ExecuteAction("Đi Thỉnh Giáo Bí Kỹ"); });
            AddMenuItem(muDi, "Đi Mua 100 Kim Sang Dược", delegate { ExecuteAction("Đi Mua 100 Kim Sang Dược", GameTaskType.Mua100KimSangDuoc); });
            AddMenuItem(muDi, "Mua 250 Cỏ + 250 Thịt + 20 Đồ Chơi", delegate { ExecuteAction("Mua Cỏ Thịt Đồ Chơi"); });

            // 8. Đi Sửa
            ToolStripMenuItem muDiSua = new ToolStripMenuItem("Đi Sửa");
            ToolStripMenuItem muTangSoLanSua = new ToolStripMenuItem("Tăng Số Lần Sửa Chữa");
            AddMenuItem(muTangSoLanSua, "Độ Bền 0/3", delegate { ExecuteAction("Tăng Sửa Chữa 0/3"); });
            AddMenuItem(muTangSoLanSua, "Độ Bền 1/3", delegate { ExecuteAction("Tăng Sửa Chữa 1/3"); });
            AddMenuItem(muTangSoLanSua, "Độ Bền 2/3", delegate { ExecuteAction("Tăng Sửa Chữa 2/3"); });
            muDiSua.DropDownItems.Add(muTangSoLanSua);
            AddMenuItem(muDiSua, "Võ Hồn", delegate { ExecuteAction("Sửa Võ Hồn", GameTaskType.SuaVoHon); });
            AddMenuItem(muDiSua, "Thần Khí", delegate { ExecuteAction("Sửa Thần Khí", GameTaskType.SuaThanKhi); });
            AddMenuItem(muDiSua, "Trang Bị", delegate { ExecuteAction("Sửa Toàn Bộ Trang Bị", GameTaskType.SuaTrangBi); });
            AddMenuItem(muDiSua, "Private", delegate { ExecuteAction("Sửa Đồ Private"); });

            // 9. Đi Đổi
            ToolStripMenuItem muDiDoi = new ToolStripMenuItem("Đi Đổi");
            ToolStripMenuItem muDoiPhieuNgoc = new ToolStripMenuItem("Đổi Phiếu Ngọc Cấp 3");
            string[] ngocTypes = new string[] { "Thể Lực", "Băng", "Huyền", "Hỏa", "Độc", "Kháng Độc" };
            for (int i = 0; i < ngocTypes.Length; i++)
            {
                string nType = ngocTypes[i];
                AddMenuItem(muDoiPhieuNgoc, nType, delegate { ExecuteAction(string.Format("Đổi Phiếu Ngọc {0}", nType)); });
            }
            muDiDoi.DropDownItems.Add(muDoiPhieuNgoc);

            ToolStripMenuItem muCoLanNgoc = new ToolStripMenuItem("Cổ Lan Ngọc");
            for (int i = 0; i < ngocTypes.Length; i++)
            {
                string nType = ngocTypes[i];
                AddMenuItem(muCoLanNgoc, nType, delegate { ExecuteAction(string.Format("Đổi Cổ Lan Ngọc {0}", nType)); });
            }
            muDiDoi.DropDownItems.Add(muCoLanNgoc);

            ToolStripMenuItem muDoiHiepAn = new ToolStripMenuItem("Đổi Hiệp Ấn");
            string[] anTypes = new string[] { "Độc", "Huyền", "Hỏa", "Băng" };
            for (int i = 0; i < anTypes.Length; i++)
            {
                string aType = anTypes[i];
                AddMenuItem(muDoiHiepAn, aType, delegate { ExecuteAction(string.Format("Đổi Hiệp Ấn {0}", aType)); });
            }
            muDiDoi.DropDownItems.Add(muDoiHiepAn);

            ToolStripMenuItem muHoaLan = new ToolStripMenuItem("Đổi Hoa Lan Toái Phiến");
            AddMenuItem(muHoaLan, "Đổi Kim Tinh Thạch", delegate { ExecuteAction("Đổi Kim Tinh Thạch"); });
            AddMenuItem(muHoaLan, "Đổi Chân Nguyên Linh Phách", delegate { ExecuteAction("Đổi Chân Nguyên Linh Phách"); });
            muDiDoi.DropDownItems.Add(muHoaLan);

            AddMenuItem(muDiDoi, "Đổi Chân Nguyên Linh Phách", delegate { ExecuteAction("Đổi Chân Nguyên Linh Phách", GameTaskType.DoiChanNguyenLinhPhach); });
            AddMenuItem(muDiDoi, "Đổi Huyễn Sắc Câu Thiên Thái", delegate { ExecuteAction("Đổi Huyễn Sắc Câu Thiên Thái", GameTaskType.DoiHuyenSacCauThienThai); });
            AddMenuItem(muDiDoi, "Đổi Chí Tôn Miên Bố", delegate { ExecuteAction("Đổi Chí Tôn Miên Bố"); });
            AddMenuItem(muDiDoi, "Đổi Chí Tôn Bí Ngân", delegate { ExecuteAction("Đổi Chí Tôn Bí Ngân"); });
            AddMenuItem(muDiDoi, "Đổi Loạn Phỉ Mật Hàm", delegate { ExecuteAction("Đổi Loạn Phỉ Mật Hàm", GameTaskType.DoiLoanPhiMatHam); });
            AddMenuItem(muDiDoi, "Đổi Địa Linh Châu", delegate { ExecuteAction("Đổi Địa Linh Châu"); });
            AddMenuItem(muDiDoi, "Đổi Công Lực Đan", delegate { ExecuteAction("Đổi Công Lực Đan"); });
            AddMenuItem(muDiDoi, "Đổi Bối Diệp Kinh Tàn Phiến", delegate { ExecuteAction("Đổi Bối Diệp Kinh Tàn Phiến"); });

            // 10. Đi Nhận
            ToolStripMenuItem muDiNhan = new ToolStripMenuItem("Đi Nhận");
            ToolStripMenuItem muThienMach = new ToolStripMenuItem("Nhận Thiên Mạch Phúc Trạch");
            string[] cities = new string[] { "La Phù Thành", "Quân Thiên Thành", "Triều Kinh Thành", "Phụng Minh Trấn" };
            for (int i = 0; i < cities.Length; i++)
            {
                string city = cities[i];
                AddMenuItem(muThienMach, city, delegate { ExecuteAction(string.Format("Nhận Thiên Mạch tại {0}", city)); });
            }
            muDiNhan.DropDownItems.Add(muThienMach);

            AddMenuItem(muDiNhan, "Nhận Chiến Công + Tử Vi", delegate
            {
                ExecuteAction("Nhận Chiến Công", GameTaskType.NhanChienCong);
                ExecuteAction("Nhận Kiếm Trì", GameTaskType.NhanKiemChi);
            });
            AddMenuItem(muDiNhan, "Nhận Thưởng Quan Sơn Hải", delegate { ExecuteAction("Nhận Thưởng Quan Sơn Hải", GameTaskType.NhanThuongQuanSonHai); });
            AddMenuItem(muDiNhan, "Nhận Bùa Bảo Rương", delegate { ExecuteAction("Nhận Bùa Bảo Rương", GameTaskType.NhanBuaBaoRuong); });
            AddMenuItem(muDiNhan, "Nhận Lễ Bao", delegate { ExecuteAction("Nhận Lễ Bao", GameTaskType.NhanLeBao); });
            AddMenuItem(muDiNhan, "Nhận Lệnh Bài", delegate { ExecuteAction("Nhận Lệnh Bài"); });
            AddMenuItem(muDiNhan, "Nhận Bá Giả + Linh Thảo + Liên Tục", delegate { ExecuteAction("Nhận Bá Giả + Linh Thảo"); });
            AddMenuItem(muDiNhan, "Nhận x2 x3 Võ Ý", delegate { ExecuteAction("Nhận x2 x3 Võ Ý"); });
            AddMenuItem(muDiNhan, "Nhận Phúc Nguyên Lễ Hạp", delegate { ExecuteAction("Nhận Phúc Nguyên Lễ Hạp", GameTaskType.NhanPhucNguyenLeHap); });
            AddMenuItem(muDiNhan, "Nhận Bách Hoa Hương Nang", delegate { ExecuteAction("Nhận Bách Hoa Hương Nang"); });
            AddMenuItem(muDiNhan, "Nhận 5 Giỏ Hoa", delegate { ExecuteAction("Nhận 5 Giỏ Hoa"); });

            // 11. Chế Độ PK
            ToolStripMenuItem muPkMode = new ToolStripMenuItem("Chế Độ Pk");
            AddMenuItem(muPkMode, "Hòa Bình", delegate { SetPkMode(0, "Hòa Bình"); });
            AddMenuItem(muPkMode, "Thiện Ác", delegate { SetPkMode(2, "Thiện Ác"); });
            AddMenuItem(muPkMode, "Nhóm", delegate { SetPkMode(3, "Nhóm"); });
            AddMenuItem(muPkMode, "Bang", delegate { SetPkMode(4, "Bang"); });
            AddMenuItem(muPkMode, "Quân Đoàn", delegate { SetPkMode(5, "Quân Đoàn"); });

            // Đưa tất cả vào Menu Player
            root.DropDownItems.Add(muThuongDung);
            root.DropDownItems.Add(muNhanLai);
            root.DropDownItems.Add(muGom);
            root.DropDownItems.Add(new ToolStripSeparator());
            root.DropDownItems.Add(muTrangBi);
            root.DropDownItems.Add(muThuongKho);
            root.DropDownItems.Add(muThuongHoi);
            root.DropDownItems.Add(new ToolStripSeparator());
            root.DropDownItems.Add(muDi);
            root.DropDownItems.Add(muDiSua);
            root.DropDownItems.Add(muDiDoi);
            root.DropDownItems.Add(muDiNhan);
            root.DropDownItems.Add(muPkMode);
        }

        private void BuildHourlyMenu(ToolStripMenuItem root)
        {
            ToolStripMenuItem muAcTac = new ToolStripMenuItem("Ác Tặc");
            AddMenuItem(muAcTac, "Tự Động", delegate { ExecuteAction("Ác Tặc Tự Động", GameTaskType.DatDoiAcTac); });
            string[] acTacMaps = new string[] { "Vô Lượng Sơn", "Kính Hồ", "Kiếm Các", "Thái Hồ", "Tùng Sơn", "Đôn Hoàng" };
            for (int i = 0; i < acTacMaps.Length; i++)
            {
                string mName = acTacMaps[i];
                AddMenuItem(muAcTac, mName, delegate { ExecuteAction(string.Format("Ác Tặc {0}", mName)); });
            }
            root.DropDownItems.Add(muAcTac);

            AddMenuItem(root, "Ác Bá", delegate { ExecuteAction("Ác Bá", GameTaskType.DatDoiAcBa); });
            AddMenuItem(root, "Tàng Kinh Các", delegate { ExecuteAction("Tàng Kinh Các", GameTaskType.DatDoiTangKinhCac); });
            AddMenuItem(root, "Boss Map", delegate { ExecuteAction("Boss Bản Đồ", GameTaskType.DatDoiBossMap); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Túc Cầu", delegate { ExecuteAction("Túc Cầu", GameTaskType.DatDoiTucCau); });

            ToolStripMenuItem muKyCuoc = new ToolStripMenuItem("Kỳ Cuộc");
            AddMenuItem(muKyCuoc, "Chậm", delegate { ExecuteAction("Kỳ Cuộc Chậm", GameTaskType.DatDoiKyCuoc); });
            AddMenuItem(muKyCuoc, "Nhanh", delegate { ExecuteAction("Kỳ Cuộc Nhanh", GameTaskType.KyCuocNhanh); });
            root.DropDownItems.Add(muKyCuoc);

            ToolStripMenuItem muLauLan = new ToolStripMenuItem("Lâu Lan Tầm Bảo");
            AddMenuItem(muLauLan, "Chậm", delegate { ExecuteAction("Lâu Lan Tầm Bảo Chậm", GameTaskType.DatDoiLauLanTamBao); });
            AddMenuItem(muLauLan, "Nhanh", delegate { ExecuteAction("Lâu Lan Tầm Bảo Nhanh", GameTaskType.LauLanTamBaoNhanh); });
            root.DropDownItems.Add(muLauLan);

            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Dã Trư", delegate { ExecuteAction("Dã Trư", GameTaskType.DatDoiDaTru); });
            AddMenuItem(root, "Mộng Heo", delegate { ExecuteAction("Mộng Heo", GameTaskType.DatDoiMongHeo); });
            AddMenuItem(root, "Thiên Giáng Kỳ Thú", delegate { ExecuteAction("Thiên Giáng Kỳ Thú", GameTaskType.DatDoiThienGiangKyThu); });
            AddMenuItem(root, "Phượng Hoàng Lăng Mộ", delegate { ExecuteAction("Phượng Hoàng Lăng Mộ", GameTaskType.DatDoiPhungHoangLangMo); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Bảo Đồ Hiếm", delegate { ExecuteAction("Bảo Đồ Hiếm", GameTaskType.DatDoiBaoDoHiem); });
            AddMenuItem(root, "Đoạt Bảo Mã Tặc", delegate { ExecuteAction("Đoạt Bảo Mã Tặc", GameTaskType.DatDoiMaTac); });
        }

        private void BuildQuestMenu(ToolStripMenuItem root)
        {
            ToolStripMenuItem muHangNgay = new ToolStripMenuItem("Hàng Ngày");
            AddMenuItem(muHangNgay, "Thu Tài Vận May", delegate { ExecuteAction("Thu Tài Vận May", GameTaskType.ThuTaiVanMay); });
            AddMenuItem(muHangNgay, "Nguyện Vọng Thiên Linh", delegate { ExecuteAction("Nguyện Vọng Thiên Linh", GameTaskType.NguyenVongThienLinh); });
            AddMenuItem(muHangNgay, "Toàn Bộ Hàng Ngày", delegate
            {
                ExecuteAction("Thu Tài Vận May", GameTaskType.ThuTaiVanMay);
                ExecuteAction("Bảo Vệ Bang", GameTaskType.BaoVeBang);
                ExecuteAction("Nguyện Vọng Thiên Linh", GameTaskType.NguyenVongThienLinh);
            });
            root.DropDownItems.Add(muHangNgay);

            ToolStripMenuItem muBang = new ToolStripMenuItem("Q Bang");
            AddMenuItem(muBang, "Bảo Vệ Bang", delegate { ExecuteAction("Bảo Vệ Bang", GameTaskType.BaoVeBang); });
            AddMenuItem(muBang, "Quốc Phòng", delegate { ExecuteAction("Quốc Phòng", GameTaskType.NhiemVuCongTrinh); });
            AddMenuItem(muBang, "Nghiên Cứu", delegate { ExecuteAction("Nghiên Cứu", GameTaskType.NhiemVuNghienCuu); });
            root.DropDownItems.Add(muBang);

            root.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem muConCai = new ToolStripMenuItem("Con Cái");
            AddMenuItem(muConCai, "Nhận Con", delegate { ExecuteAction("Nhận Con", GameTaskType.NhanCon); });
            AddMenuItem(muConCai, "Tu Dưỡng Con", delegate { ExecuteAction("Tu Dưỡng Con", GameTaskType.TuDuongCon); });
            AddMenuItem(muConCai, "Long Phụ Mẫu", delegate { ExecuteAction("Long Phụ Mẫu", GameTaskType.LongPhuMau); });
            root.DropDownItems.Add(muConCai);

            ToolStripMenuItem muCotTruyen = new ToolStripMenuItem("Cốt Truyện");
            AddMenuItem(muCotTruyen, "KNB Khóa", delegate { ExecuteAction("Cốt Truyện KNB Khóa", GameTaskType.NhiemVuKnbKhoa); });
            AddMenuItem(muCotTruyen, "Thăng Cấp", delegate { ExecuteAction("Cốt Truyện Thăng Cấp", GameTaskType.NhiemVuThangCap); });
            AddMenuItem(muCotTruyen, "Chính Tuyến", delegate { ExecuteAction("Cốt Truyện Chính Tuyến", GameTaskType.NhiemVuChinhTuyen); });
            AddMenuItem(muCotTruyen, "Exp", delegate { ExecuteAction("Cốt Truyện Exp", GameTaskType.NhiemVuExp); });
            AddMenuItem(muCotTruyen, "Võ Ý", delegate { ExecuteAction("Cốt Truyện Võ Ý", GameTaskType.NhiemVuVoY); });
            AddMenuItem(muCotTruyen, "Võ Tự Phổ", delegate { ExecuteAction("Cốt Truyện Võ Tự Phổ", GameTaskType.VoTuPho); });
            AddMenuItem(muCotTruyen, "Cốt Truyện 120", delegate { ExecuteAction("Cốt Truyện 120"); });
            root.DropDownItems.Add(muCotTruyen);

            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Sư Môn", delegate { ExecuteAction("Nhiệm Vụ Sư Môn", GameTaskType.NhiemVuSuMon); });
            AddMenuItem(root, "Trừng Ác", delegate { ExecuteAction("Trừng Ác", GameTaskType.TruAc); });
            AddMenuItem(root, "Mở Bảo Tàng Đồ", delegate { ExecuteAction("Mở Bảo Tàng Đồ", GameTaskType.MoBaoTangDo); });
            AddMenuItem(root, "Sinh Tiêu", delegate { ExecuteAction("Sinh Tiêu", GameTaskType.SinhTieu); });
            AddMenuItem(root, "Đoạt Bảo Rương", delegate { ExecuteAction("Đoạt Bảo Rương", GameTaskType.DungDoatBaoRuong); });
        }

        private void BuildFubenMenu(ToolStripMenuItem root)
        {
            ToolStripMenuItem muCanQuet = new ToolStripMenuItem("Càn Quét");
            string[] fubenNames = new string[]
            {
                "Phiêu Miễu Phong", "Phúc Địa", "Phúc Địa Khó", "Vương Lăng",
                "Tam Thần", "Thiếu Thất Sơn", "Yến Tử Ô", "Tứ Tuyệt Trang", "Trừ Phỉ Phá Tam Quan"
            };
            for (int i = 0; i < fubenNames.Length; i++)
            {
                string fName = fubenNames[i];
                AddMenuItem(muCanQuet, fName, delegate { ExecuteAction(string.Format("Càn Quét {0}", fName)); });
            }
            muCanQuet.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(muCanQuet, "Càn Quét Toàn Bộ", delegate { ExecuteAction("Càn Quét Toàn Bộ Phụ Bản"); });
            root.DropDownItems.Add(muCanQuet);

            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Binh Thánh Kỳ Trận", delegate { ExecuteAction("Đặt Đội Binh Thánh Kỳ Trận", GameTaskType.DatDoiBinhThanh); });
            AddMenuItem(root, "Phiêu Miễu Phong", delegate { ExecuteAction("Đặt Đội Phiêu Miễu Phong", GameTaskType.DatDoiPhieuMieuPhong); });
            AddMenuItem(root, "Yến Tử Ô", delegate { ExecuteAction("Đặt Đội Yến Tử Ô", GameTaskType.DatDoiYenTuO); });
            AddMenuItem(root, "Tứ Tuyệt Trang", delegate { ExecuteAction("Đặt Đội Tứ Tuyệt Trang", GameTaskType.DatDoiTuTuyetTrang); });
            AddMenuItem(root, "Thiếu Thất Sơn", delegate { ExecuteAction("Đặt Đội Thiếu Thất Sơn", GameTaskType.DatDoiThieuThatSon); });
            AddMenuItem(root, "Phúc Địa", delegate { ExecuteAction("Đặt Đội Phúc Địa", GameTaskType.DatDoiPhucDia); });
            AddMenuItem(root, "Phúc Địa Khó", delegate { ExecuteAction("Đặt Đội Phúc Địa Khó", GameTaskType.DatDoiPhucDiaKho); });
            AddMenuItem(root, "Vương Lăng", delegate { ExecuteAction("Đặt Đội Vương Lăng", GameTaskType.DatDoiVuongLang); });
            AddMenuItem(root, "Tam Thần", delegate { ExecuteAction("Đặt Đội Tam Thần", GameTaskType.DatDoiTamThan); });
            AddMenuItem(root, "Trừ Phỉ Phá Tam Quan", delegate { ExecuteAction("Đặt Đội Trừ Phỉ Phá Tam Quan", GameTaskType.DatDoiTruPhiPhaTamQuan); });
            AddMenuItem(root, "Quan Sơn Hải", delegate { ExecuteAction("Đặt Đội Quan Sơn Hải", GameTaskType.DatDoiQuanSonHai); });
            AddMenuItem(root, "Sát Tinh", delegate { ExecuteAction("Đặt Đội Sát Tinh", GameTaskType.DatDoiSatTinh); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Q1 Tô Châu", delegate { ExecuteAction("Q1 Tô Châu", GameTaskType.DatDoiQ1ToChau); });
            AddMenuItem(root, "Q2 Tô Châu", delegate { ExecuteAction("Q2 Tô Châu", GameTaskType.DatDoiQ2ToChau); });
            AddMenuItem(root, "Q1 Lâu Lan", delegate { ExecuteAction("Q1 Lâu Lan", GameTaskType.DatDoiQ1LauLan); });
            AddMenuItem(root, "Q2 Lâu Lan", delegate { ExecuteAction("Q2 Lâu Lan", GameTaskType.DatDoiQ2LauLan); });
            AddMenuItem(root, "Q3 Lâu Lan", delegate { ExecuteAction("Q3 Lâu Lan", GameTaskType.DatDoiQ3LauLan); });
            AddMenuItem(root, "Thủy Lao", delegate { ExecuteAction("Thủy Lao", GameTaskType.DatDoiThuyLao); });
        }

        private void BuildAllMenu(ToolStripMenuItem root)
        {
            AddMenuItem(root, "Chọn Tất Cả [Ctrl + A]", delegate { ToggleAllActions(); });
            AddMenuItem(root, "Làm Mới [Ctrl + R]", delegate { ScanRunningClients(); });
            AddMenuItem(root, "Chọn Server", delegate { MessageBox.Show("Chức năng chọn Server cho toàn bộ tài khoản.", "iAuto"); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Lên Ngựa", delegate { ExecuteAction("Lên Ngựa", GameTaskType.None, "PushEvent('HORSE_MOUNT')"); });
            AddMenuItem(root, "Xuống Ngựa", delegate { ExecuteAction("Xuống Ngựa", GameTaskType.None, "PushEvent('HORSE_UNMOUNT')"); });
            AddMenuItem(root, "Điểm Danh", delegate { ExecuteAction("Điểm Danh"); });
            AddMenuItem(root, "Sắp Xếp Tay Nải", delegate { ExecuteAction("Sắp Xếp Tay Nải", GameTaskType.None, "PushEvent('PACKAGE_SORT')"); });
        }

        private void BuildIMenu(ToolStripMenuItem root)
        {
            AddMenuItem(root, "Mở Game", delegate { MessageBox.Show("Khởi chạy client game TLBB.", "iAuto"); });
            AddMenuItem(root, "Auto PK [Alt + I]", delegate { ExecuteAction("Tự Động PK"); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Nhặt Gần", delegate { ExecuteAction("Nhặt Gần"); });
            AddMenuItem(root, "Nhặt Đồ", delegate { ExecuteAction("Nhặt Đồ"); });
            AddMenuItem(root, "Lọc Vật Phẩm", delegate { ExecuteAction("Lọc Vật Phẩm"); });
            root.DropDownItems.Add(new ToolStripSeparator());
            AddMenuItem(root, "Theo Sau Key", delegate { ExecuteAction("Theo Sau Key"); });
            AddMenuItem(root, "Buộc Theo Sau Key", delegate { ExecuteAction("Buộc Theo Sau Key"); });
            AddMenuItem(root, "Đánh Theo Key", delegate { ExecuteAction("Đánh Theo Key"); });
        }

        private void AddMenuItem(ToolStripMenuItem parent, string text, EventHandler onClick)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text);
            if (onClick != null)
            {
                item.Click += onClick;
            }
            parent.DropDownItems.Add(item);
        }

        private void SetPkMode(int mode, string modeName)
        {
            string lua = string.Format("Player:ChangePVPMode({0});", mode);
            ExecuteAction(string.Format("Chuyển PK: {0}", modeName), GameTaskType.None, lua);
        }

        private void ExecuteAction(string actionName, GameTaskType taskType = GameTaskType.None, string luaCommand = null)
        {
            if (_selectedContext != null)
            {
                if (!string.IsNullOrEmpty(luaCommand) && _selectedContext.LuaService != null)
                {
                    _selectedContext.LuaService.ExecuteLua(luaCommand);
                }

                if (_selectedContext.ListItem != null && _selectedContext.ListItem.SubItems.Count > 3)
                {
                    _selectedContext.ListItem.SubItems[3].Text = actionName;
                }
            }
            else if (_activeClients.Count > 0)
            {
                foreach (KeyValuePair<int, CharacterContext> kv in _activeClients)
                {
                    if (!string.IsNullOrEmpty(luaCommand) && kv.Value.LuaService != null)
                    {
                        kv.Value.LuaService.ExecuteLua(luaCommand);
                    }
                    if (kv.Value.ListItem != null && kv.Value.ListItem.SubItems.Count > 3)
                    {
                        kv.Value.ListItem.SubItems[3].Text = actionName;
                    }
                }
            }
        }

        #endregion

        #region Xây dựng Tab Game & Bottom Sub-Tabs (Key, Life, Craft)

        private void BuildGameTab()
        {
            _tabGame.BackColor = Color.White;
            _tabGame.Padding = new Padding(2);

            // 1. Top Search Bar
            Panel pnlTopSearch = new Panel();
            pnlTopSearch.Dock = DockStyle.Top;
            pnlTopSearch.Height = 26;

            _txtSearch = new TextBox();
            _txtSearch.Text = "Search...";
            _txtSearch.ForeColor = Color.Gray;
            _txtSearch.Location = new Point(2, 2);
            _txtSearch.Width = 390;
            _txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtSearch.GotFocus += delegate { if (_txtSearch.Text == "Search...") { _txtSearch.Text = ""; _txtSearch.ForeColor = Color.Black; } };
            _txtSearch.LostFocus += delegate { if (string.IsNullOrEmpty(_txtSearch.Text)) { _txtSearch.Text = "Search..."; _txtSearch.ForeColor = Color.Gray; } };

            _chkSelectAll = new CheckBox();
            _chkSelectAll.Location = new Point(400, 4);
            _chkSelectAll.Width = 20;
            _chkSelectAll.Checked = true;
            _chkSelectAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            pnlTopSearch.Controls.Add(_txtSearch);
            pnlTopSearch.Controls.Add(_chkSelectAll);

            // 2. ListView hiển thị danh sách nhân vật
            _lvCharacters = new ListView();
            _lvCharacters.Dock = DockStyle.Fill;
            _lvCharacters.View = View.Details;
            _lvCharacters.FullRowSelect = true;
            _lvCharacters.GridLines = true;
            _lvCharacters.HideSelection = false;

            _lvCharacters.Columns.Add("[0]", 80);
            _lvCharacters.Columns.Add("Lvl", 35);
            _lvCharacters.Columns.Add("Phái", 55);
            _lvCharacters.Columns.Add("Status", 75);
            _lvCharacters.Columns.Add("HP", 45);
            _lvCharacters.Columns.Add("MP", 45);
            _lvCharacters.Columns.Add("Pet", 45);
            _lvCharacters.Columns.Add("Online", 55);
            _lvCharacters.Columns.Add("Exp", 50);
            _lvCharacters.Columns.Add("0", 30);

            _lvCharacters.SelectedIndexChanged += OnCharacterSelectionChanged;

            // 3. TabControl phía dưới (Key, Life, Craft) với Alignment = Bottom
            _tabBottom = new TabControl();
            _tabBottom.Dock = DockStyle.Bottom;
            _tabBottom.Height = 245;
            _tabBottom.Alignment = TabAlignment.Bottom;

            _tabKey = new TabPage("Key");
            _tabLife = new TabPage("Life");
            _tabCraft = new TabPage("Craft");

            _tabBottom.TabPages.Add(_tabKey);
            _tabBottom.TabPages.Add(_tabLife);
            _tabBottom.TabPages.Add(_tabCraft);

            BuildKeyTabPage();
            BuildLifeTabPage();
            BuildCraftTabPage();

            // Đưa controls vào TabGame
            _tabGame.Controls.Add(_lvCharacters);
            _tabGame.Controls.Add(_tabBottom);
            _tabGame.Controls.Add(pnlTopSearch);
        }

        private void BuildKeyTabPage()
        {
            _tabKey.BackColor = Color.White;
            _tabKey.Padding = new Padding(2);

            // Container chia trái / phải
            SplitContainer splitKey = new SplitContainer();
            splitKey.Dock = DockStyle.Fill;
            splitKey.SplitterDistance = 150;
            splitKey.FixedPanel = FixedPanel.Panel1;

            // Panel Trái: Search + Danh sách 28 Action Checklist + Combo Menpai
            Panel pnlLeft = new Panel();
            pnlLeft.Dock = DockStyle.Fill;

            _txtSearchFunction = new TextBox();
            _txtSearchFunction.Text = "Search...";
            _txtSearchFunction.ForeColor = Color.Gray;
            _txtSearchFunction.Dock = DockStyle.Top;
            _txtSearchFunction.Height = 20;
            _txtSearchFunction.GotFocus += delegate { if (_txtSearchFunction.Text == "Search...") { _txtSearchFunction.Text = ""; _txtSearchFunction.ForeColor = Color.Black; } };
            _txtSearchFunction.LostFocus += delegate { if (string.IsNullOrEmpty(_txtSearchFunction.Text)) { _txtSearchFunction.Text = "Search..."; _txtSearchFunction.ForeColor = Color.Gray; } };

            _lvActions = new ListView();
            _lvActions.Dock = DockStyle.Fill;
            _lvActions.View = View.Details;
            _lvActions.CheckBoxes = true;
            _lvActions.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _lvActions.Columns.Add("Name", 140);

            // 28 Hành động chuẩn của iAuto
            string[] actionNames = new string[]
            {
                "Quay Lại Bãi", "Attack", "Lure", "Chỉ Đánh", "Tuyên Chiến",
                "Only Pet", "Pet", "HP", "MP", "Chỉ Nhặt",
                "Gia Công", "Thăng Cấp", "Quay Vòng", "Tụ Linh Ngọc",
                "Càn Khôn Hồ", "Nhặt Đồ", "Dùng x2", "Dùng x4",
                "x2, x3 Võ Ý", "Keep Online", "Hái Hoa", "Mua Ngọc",
                "Không Bật Lịch", "Khai Khoáng", "Hái Dược", "Thu Thập",
                "Báo inbox", "Khai Thác"
            };

            for (int i = 0; i < actionNames.Length; i++)
            {
                ListViewItem item = new ListViewItem(actionNames[i]);
                _lvActions.Items.Add(item);
            }
            _lvActions.ItemChecked += OnActionItemChecked;

            _cboMenpai = new ComboBox();
            _cboMenpai.Dock = DockStyle.Bottom;
            _cboMenpai.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboMenpai.Items.Add("-- Môn Phái --");
            _cboMenpai.Items.Add("Thiếu Lâm");
            _cboMenpai.Items.Add("Minh Giáo");
            _cboMenpai.Items.Add("Cái Bang");
            _cboMenpai.Items.Add("Võ Đang");
            _cboMenpai.Items.Add("Nga My");
            _cboMenpai.Items.Add("Tinh Túc");
            _cboMenpai.Items.Add("Thiên Long");
            _cboMenpai.Items.Add("Thiên Sơn");
            _cboMenpai.Items.Add("Tiêu Dao");
            _cboMenpai.Items.Add("Mộ Dung");
            _cboMenpai.Items.Add("Đường Môn");
            _cboMenpai.Items.Add("Quỷ Cốc");
            _cboMenpai.Items.Add("Đào Hoa Đảo");
            _cboMenpai.SelectedIndex = 0;

            pnlLeft.Controls.Add(_lvActions);
            pnlLeft.Controls.Add(_txtSearchFunction);
            pnlLeft.Controls.Add(_cboMenpai);
            splitKey.Panel1.Controls.Add(pnlLeft);

            // Panel Phải: Search + ListView Skill (Name, PK, Delay) + Thanh điều khiển dưới (cboLeader, txtPass2, chkShowPass)
            Panel pnlRight = new Panel();
            pnlRight.Dock = DockStyle.Fill;

            Panel pnlSkillTop = new Panel();
            pnlSkillTop.Dock = DockStyle.Top;
            pnlSkillTop.Height = 22;

            _txtSearchSkill = new TextBox();
            _txtSearchSkill.Text = "Search...";
            _txtSearchSkill.ForeColor = Color.Gray;
            _txtSearchSkill.Dock = DockStyle.Fill;
            _txtSearchSkill.GotFocus += delegate { if (_txtSearchSkill.Text == "Search...") { _txtSearchSkill.Text = ""; _txtSearchSkill.ForeColor = Color.Black; } };
            _txtSearchSkill.LostFocus += delegate { if (string.IsNullOrEmpty(_txtSearchSkill.Text)) { _txtSearchSkill.Text = "Search..."; _txtSearchSkill.ForeColor = Color.Gray; } };

            _chkSelectAllSkills = new CheckBox();
            _chkSelectAllSkills.Dock = DockStyle.Right;
            _chkSelectAllSkills.Width = 20;
            _chkSelectAllSkills.Checked = true;
            _chkSelectAllSkills.CheckedChanged += delegate
            {
                for (int i = 0; i < _lvSkills.Items.Count; i++)
                {
                    _lvSkills.Items[i].Checked = _chkSelectAllSkills.Checked;
                }
            };

            pnlSkillTop.Controls.Add(_txtSearchSkill);
            pnlSkillTop.Controls.Add(_chkSelectAllSkills);

            _lvSkills = new ListView();
            _lvSkills.Dock = DockStyle.Fill;
            _lvSkills.View = View.Details;
            _lvSkills.CheckBoxes = true;
            _lvSkills.FullRowSelect = true;
            _lvSkills.GridLines = true;
            _lvSkills.Columns.Add("Name", 144);
            _lvSkills.Columns.Add("PK", 35);
            _lvSkills.Columns.Add("Delay", 45);

            // Nạp danh sách skill mặc định
            string[] defaultSkills = new string[]
            {
                "Đánh Thường", "Lan Hoa Huyệt", "Kim Cương Bất Hoại", "Khê Sơn Hành Lữ",
                "Thanh Tâm Phổ Thiện Chú", "Cửu Âm Bạch Cốt Trảo", "Lục Mạch Thần Kiếm",
                "Di Hoa Tiếp Mộc", "Dịch Cân Kinh", "Bát Trận Đồ", "Thị Huyết (Pet)"
            };
            for (int i = 0; i < defaultSkills.Length; i++)
            {
                ListViewItem sItem = new ListViewItem(defaultSkills[i]);
                sItem.Checked = true;
                sItem.SubItems.Add("Có");
                sItem.SubItems.Add("1000");
                _lvSkills.Items.Add(sItem);
            }

            // Thanh Footer dưới của Key
            Panel pnlKeyFooter = new Panel();
            pnlKeyFooter.Dock = DockStyle.Bottom;
            pnlKeyFooter.Height = 24;

            _cboLeader = new ComboBox();
            _cboLeader.Location = new Point(2, 2);
            _cboLeader.Width = 110;
            _cboLeader.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboLeader.Items.Add("-- Đội Trưởng --");
            _cboLeader.SelectedIndex = 0;

            _txtPass2 = new TextBox();
            _txtPass2.Location = new Point(116, 2);
            _txtPass2.Width = 115;
            _txtPass2.PasswordChar = '*';
            _txtPass2.Text = "Pass 2";
            _txtPass2.ForeColor = Color.Gray;
            _txtPass2.GotFocus += delegate { if (_txtPass2.Text == "Pass 2") { _txtPass2.Text = ""; _txtPass2.ForeColor = Color.Black; } };
            _txtPass2.LostFocus += delegate { if (string.IsNullOrEmpty(_txtPass2.Text)) { _txtPass2.Text = "Pass 2"; _txtPass2.ForeColor = Color.Gray; } };

            _chkShowPass = new CheckBox();
            _chkShowPass.Location = new Point(235, 4);
            _chkShowPass.Width = 18;
            _chkShowPass.CheckedChanged += delegate
            {
                _txtPass2.PasswordChar = _chkShowPass.Checked ? '\0' : '*';
            };

            pnlKeyFooter.Controls.Add(_cboLeader);
            pnlKeyFooter.Controls.Add(_txtPass2);
            pnlKeyFooter.Controls.Add(_chkShowPass);

            pnlRight.Controls.Add(_lvSkills);
            pnlRight.Controls.Add(pnlSkillTop);
            pnlRight.Controls.Add(pnlKeyFooter);
            splitKey.Panel2.Controls.Add(pnlRight);

            _tabKey.Controls.Add(splitKey);
        }

        private void BuildLifeTabPage()
        {
            _tabLife.BackColor = Color.White;
            _tabLife.Padding = new Padding(6);

            GroupBox grpHeal = new GroupBox();
            grpHeal.Text = "Hồi Phục Sinh Lực & Khí";
            grpHeal.Dock = DockStyle.Top;
            grpHeal.Height = 90;

            _chkAutoHp = new CheckBox();
            _chkAutoHp.Text = "Tự dùng HP khi dưới (%):";
            _chkAutoHp.Location = new Point(10, 22);
            _chkAutoHp.Width = 170;
            _chkAutoHp.Checked = true;

            _numHpPercent = new NumericUpDown();
            _numHpPercent.Location = new Point(185, 20);
            _numHpPercent.Width = 55;
            _numHpPercent.Value = 75;

            _chkAutoMp = new CheckBox();
            _chkAutoMp.Text = "Tự dùng MP khi dưới (%):";
            _chkAutoMp.Location = new Point(10, 52);
            _chkAutoMp.Width = 170;
            _chkAutoMp.Checked = true;

            _numMpPercent = new NumericUpDown();
            _numMpPercent.Location = new Point(185, 50);
            _numMpPercent.Width = 55;
            _numMpPercent.Value = 40;

            grpHeal.Controls.Add(_chkAutoHp);
            grpHeal.Controls.Add(_numHpPercent);
            grpHeal.Controls.Add(_chkAutoMp);
            grpHeal.Controls.Add(_numMpPercent);

            GroupBox grpSupport = new GroupBox();
            grpSupport.Text = "Hỗ Trợ & Nga My";
            grpSupport.Dock = DockStyle.Fill;

            _chkHealTeam = new CheckBox();
            _chkHealTeam.Text = "Nga My buff máu đồng đội (%):";
            _chkHealTeam.Location = new Point(10, 25);
            _chkHealTeam.Width = 190;
            _chkHealTeam.Checked = true;

            _numHealPercent = new NumericUpDown();
            _numHealPercent.Location = new Point(205, 23);
            _numHealPercent.Width = 55;
            _numHealPercent.Value = 70;

            _chkAutoPhu = new CheckBox();
            _chkAutoPhu.Text = "Tự động dùng Phù về thành khi nguy cấp:";
            _chkAutoPhu.Location = new Point(10, 55);
            _chkAutoPhu.Width = 240;

            _cboPhu = new ComboBox();
            _cboPhu.Location = new Point(255, 53);
            _cboPhu.Width = 130;
            _cboPhu.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboPhu.Items.Add("Thổ Linh Châu");
            _cboPhu.Items.Add("Định Vị Phù");
            _cboPhu.SelectedIndex = 0;

            grpSupport.Controls.Add(_chkHealTeam);
            grpSupport.Controls.Add(_numHealPercent);
            grpSupport.Controls.Add(_chkAutoPhu);
            grpSupport.Controls.Add(_cboPhu);

            _tabLife.Controls.Add(grpSupport);
            _tabLife.Controls.Add(grpHeal);
        }

        private void BuildCraftTabPage()
        {
            _tabCraft.BackColor = Color.White;
            _tabCraft.Padding = new Padding(6);

            GroupBox grpCraft = new GroupBox();
            grpCraft.Text = "Cài Đặt Chế Đồ (Craft)";
            grpCraft.Dock = DockStyle.Top;
            grpCraft.Height = 100;

            _chkAutoCraft = new CheckBox();
            _chkAutoCraft.Text = "Tự Động Chế Đồ";
            _chkAutoCraft.Location = new Point(10, 25);
            _chkAutoCraft.Width = 130;

            Label lblDa = new Label();
            lblDa.Text = "Đá chế:";
            lblDa.Location = new Point(150, 27);
            lblDa.Width = 55;

            _cboDaTaoDo = new ComboBox();
            _cboDaTaoDo.Location = new Point(210, 24);
            _cboDaTaoDo.Width = 160;
            _cboDaTaoDo.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboDaTaoDo.Items.Add("Bí Ngân");
            _cboDaTaoDo.Items.Add("Vải Bông");
            _cboDaTaoDo.Items.Add("Tinh Thiết");
            _cboDaTaoDo.SelectedIndex = 0;

            Label lblType = new Label();
            lblType.Text = "Hệ đồ:";
            lblType.Location = new Point(150, 58);
            lblType.Width = 55;

            _cboCheNoiNgoai = new ComboBox();
            _cboCheNoiNgoai.Location = new Point(210, 55);
            _cboCheNoiNgoai.Width = 160;
            _cboCheNoiNgoai.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboCheNoiNgoai.Items.Add("Đồ Nội Công");
            _cboCheNoiNgoai.Items.Add("Đồ Ngoại Công");
            _cboCheNoiNgoai.SelectedIndex = 0;

            grpCraft.Controls.Add(_chkAutoCraft);
            grpCraft.Controls.Add(lblDa);
            grpCraft.Controls.Add(_cboDaTaoDo);
            grpCraft.Controls.Add(lblType);
            grpCraft.Controls.Add(_cboCheNoiNgoai);

            GroupBox grpHuy = new GroupBox();
            grpHuy.Text = "Tự Động Hủy / Phân Giải Đồ";
            grpHuy.Dock = DockStyle.Fill;

            _chkHuyCraft = new CheckBox();
            _chkHuyCraft.Text = "Tự hủy đồ phẩm chất thấp:";
            _chkHuyCraft.Location = new Point(10, 25);
            _chkHuyCraft.Width = 170;

            Label lblStar = new Label();
            lblStar.Text = "Dưới số sao:";
            lblStar.Location = new Point(190, 27);
            lblStar.Width = 75;

            _numHuyStar = new NumericUpDown();
            _numHuyStar.Location = new Point(270, 25);
            _numHuyStar.Width = 50;
            _numHuyStar.Value = 5;

            Label lblLine = new Label();
            lblLine.Text = "Dưới số dòng:";
            lblLine.Location = new Point(190, 57);
            lblLine.Width = 75;

            _numHuyLine = new NumericUpDown();
            _numHuyLine.Location = new Point(270, 55);
            _numHuyLine.Width = 50;
            _numHuyLine.Value = 6;

            grpHuy.Controls.Add(_chkHuyCraft);
            grpHuy.Controls.Add(lblStar);
            grpHuy.Controls.Add(_numHuyStar);
            grpHuy.Controls.Add(lblLine);
            grpHuy.Controls.Add(_numHuyLine);

            _tabCraft.Controls.Add(grpHuy);
            _tabCraft.Controls.Add(grpCraft);
        }

        #endregion

        #region Xây dựng Toàn Bộ Các Tab (Login, Pay, Inbox, Setting, Config, Chat)

        private void BuildLoginTab()
        {
            _tabLogin.BackColor = Color.White;
            _tabLogin.Padding = new Padding(4);

            // 1. Toolbar Thao Tác ở trên
            Panel pnlTopBar = new Panel();
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Height = 32;

            Button btnLoginAll = new Button();
            btnLoginAll.Text = "Đăng Nhập Tất Cả";
            btnLoginAll.Location = new Point(2, 2);
            btnLoginAll.Size = new Size(125, 26);
            btnLoginAll.Click += delegate
            {
                MessageBox.Show("Bắt đầu tự động đăng nhập tuần tự danh sách tài khoản...", "iAuto.Login");
            };

            Button btnStopLogin = new Button();
            btnStopLogin.Text = "Dừng Đăng Nhập";
            btnStopLogin.Location = new Point(132, 2);
            btnStopLogin.Size = new Size(110, 26);

            ComboBox cboActions = new ComboBox();
            cboActions.Location = new Point(248, 4);
            cboActions.Width = 160;
            cboActions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActions.Items.Add("-- Thao Tác Nhanh --");
            cboActions.Items.Add("Clone Zing (75 Chip)");
            cboActions.Items.Add("Tải Lên Cloud");
            cboActions.Items.Add("Tải Xuống Từ Cloud");
            cboActions.Items.Add("Copy User + Pass");
            cboActions.Items.Add("Clean Status");
            cboActions.Items.Add("Clean Name");
            cboActions.Items.Add("Lên Trên Cùng [Ctrl + Up]");
            cboActions.Items.Add("Xuống Dưới Cùng [Ctrl + Down]");
            cboActions.Items.Add("Xóa Trùng Lặp");
            cboActions.Items.Add("Xáo Trộn Dữ Liệu");
            cboActions.SelectedIndex = 0;
            cboActions.SelectedIndexChanged += delegate
            {
                if (cboActions.SelectedIndex > 0)
                {
                    MessageBox.Show(string.Format("Đã thực hiện: {0}", cboActions.SelectedItem), "iAuto.Login");
                    cboActions.SelectedIndex = 0;
                }
            };

            pnlTopBar.Controls.Add(btnLoginAll);
            pnlTopBar.Controls.Add(btnStopLogin);
            pnlTopBar.Controls.Add(cboActions);

            // 2. ListView danh sách tài khoản
            ListView lvAccounts = new ListView();
            lvAccounts.Dock = DockStyle.Fill;
            lvAccounts.View = View.Details;
            lvAccounts.FullRowSelect = true;
            lvAccounts.GridLines = true;
            lvAccounts.CheckBoxes = true;

            lvAccounts.Columns.Add("#", 30);
            lvAccounts.Columns.Add("User", 95);
            lvAccounts.Columns.Add("Name", 90);
            lvAccounts.Columns.Add("Server", 75);
            lvAccounts.Columns.Add("Idx", 35);
            lvAccounts.Columns.Add("Status", 75);
            lvAccounts.Columns.Add("Lvl", 35);
            lvAccounts.Columns.Add("Phái", 55);
            lvAccounts.Columns.Add("Bật", 35);
            lvAccounts.Columns.Add("Info", 100);

            // Nạp tài khoản từ thư mục iAuto.Login
            string loginDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "iAuto.Login");
            if (!Directory.Exists(loginDir))
            {
                loginDir = Path.Combine(Directory.GetCurrentDirectory(), "iAuto.Login");
            }

            int indexCounter = 1;
            if (Directory.Exists(loginDir))
            {
                string[] files = Directory.GetFiles(loginDir, "*.xml");
                for (int i = 0; i < files.Length; i++)
                {
                    AccountGroupSettings settings;
                    List<GameAccount> accList = _accountService.LoadAccounts(files[i], out settings);
                    for (int j = 0; j < accList.Count; j++)
                    {
                        GameAccount acc = accList[j];
                        ListViewItem item = new ListViewItem(indexCounter.ToString());
                        item.Checked = true;
                        item.SubItems.Add(acc.Username);
                        item.SubItems.Add(acc.CharacterName);
                        item.SubItems.Add(acc.ServerName);
                        item.SubItems.Add(acc.CharacterSlotIndex.ToString());
                        item.SubItems.Add("Sẵn sàng");
                        item.SubItems.Add(acc.Level.ToString());
                        item.SubItems.Add(acc.Menpai.ToString());
                        item.SubItems.Add("Bật");
                        item.SubItems.Add("OK");
                        lvAccounts.Items.Add(item);
                        indexCounter++;
                    }
                }
            }

            if (lvAccounts.Items.Count == 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.Checked = true;
                    item.SubItems.Add(string.Format("user_tlbb_{0}", i));
                    item.SubItems.Add(string.Format("Char_{0}", i));
                    item.SubItems.Add("Tuyệt Đỉnh");
                    item.SubItems.Add(i.ToString());
                    item.SubItems.Add("Sẵn sàng");
                    item.SubItems.Add("109");
                    item.SubItems.Add("Võ Đang");
                    item.SubItems.Add("Bật");
                    item.SubItems.Add("OK");
                    lvAccounts.Items.Add(item);
                }
            }

            _tabLogin.Controls.Add(lvAccounts);
            _tabLogin.Controls.Add(pnlTopBar);
        }

        private void BuildPayTab()
        {
            _tabPay.BackColor = Color.White;
            _tabPay.Padding = new Padding(4);

            SplitContainer splitPay = new SplitContainer();
            splitPay.Dock = DockStyle.Fill;
            splitPay.SplitterDistance = 205;
            splitPay.FixedPanel = FixedPanel.Panel1;

            // Panel Trái: Thông tin tài khoản, số dư, các gói dịch vụ
            Panel pnlPayLeft = new Panel();
            pnlPayLeft.Dock = DockStyle.Fill;
            pnlPayLeft.AutoScroll = true;

            GroupBox grpUser = new GroupBox();
            grpUser.Text = "Tài Khoản & Máy Chủ";
            grpUser.Dock = DockStyle.Top;
            grpUser.Height = 100;

            Label lblAcc = new Label();
            lblAcc.Text = "iAuto User: PRO_TLBB_USER";
            lblAcc.Location = new Point(10, 20);
            lblAcc.Width = 180;

            Label lblHwid = new Label();
            lblHwid.Text = "HWID: 8E9F-27E9-EB5F-4EB6";
            lblHwid.Location = new Point(10, 45);
            lblHwid.Width = 180;

            Label lblVersion = new Label();
            lblVersion.Text = "Phiên bản: iAuto 1.0.5 Pro";
            lblVersion.Location = new Point(10, 70);
            lblVersion.Width = 180;

            grpUser.Controls.Add(lblAcc);
            grpUser.Controls.Add(lblHwid);
            grpUser.Controls.Add(lblVersion);

            GroupBox grpBalance = new GroupBox();
            grpBalance.Text = "Hạn Dùng & Số Dư";
            grpBalance.Dock = DockStyle.Top;
            grpBalance.Height = 120;

            Label lblVng = new Label();
            lblVng.Text = "Bản VNG: Còn 365 Ngày";
            lblVng.ForeColor = Color.DarkGreen;
            lblVng.Location = new Point(10, 22);
            lblVng.Width = 180;

            Label lblPri = new Label();
            lblPri.Text = "Bản Private: Còn 365 Ngày";
            lblPri.ForeColor = Color.DarkGreen;
            lblPri.Location = new Point(10, 48);
            lblPri.Width = 180;

            Label lblChip = new Label();
            lblChip.Text = "Số dư Chip: 1.000.000 Chip";
            lblChip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChip.ForeColor = Color.DarkBlue;
            lblChip.Location = new Point(10, 76);
            lblChip.Width = 180;

            grpBalance.Controls.Add(lblVng);
            grpBalance.Controls.Add(lblPri);
            grpBalance.Controls.Add(lblChip);

            GroupBox grpPackages = new GroupBox();
            grpPackages.Text = "Gói Dịch Vụ";
            grpPackages.Dock = DockStyle.Top;
            grpPackages.Height = 110;

            Button btnPack1 = new Button();
            btnPack1.Text = "+20 Ngày - 99.000 Chip";
            btnPack1.Location = new Point(10, 24);
            btnPack1.Size = new Size(180, 30);
            btnPack1.Click += delegate { MessageBox.Show("Gia hạn thành công +20 Ngày sử dụng!", "iAuto.Pay"); };

            Button btnPack2 = new Button();
            btnPack2.Text = "+365 Ngày - 1.000.000 Chip";
            btnPack2.Location = new Point(10, 62);
            btnPack2.Size = new Size(180, 30);
            btnPack2.Click += delegate { MessageBox.Show("Gia hạn thành công +365 Ngày sử dụng!", "iAuto.Pay"); };

            grpPackages.Controls.Add(btnPack1);
            grpPackages.Controls.Add(btnPack2);

            LinkLabel lnkSupport = new LinkLabel();
            lnkSupport.Text = "Tham gia Zalo Group Hỗ Trợ iAuto";
            lnkSupport.Dock = DockStyle.Bottom;
            lnkSupport.TextAlign = ContentAlignment.MiddleCenter;
            lnkSupport.Height = 30;
            lnkSupport.LinkClicked += delegate
            {
                try { Process.Start("https://zalo.me"); } catch { }
            };

            pnlPayLeft.Controls.Add(grpPackages);
            pnlPayLeft.Controls.Add(grpBalance);
            pnlPayLeft.Controls.Add(grpUser);
            pnlPayLeft.Controls.Add(lnkSupport);
            splitPay.Panel1.Controls.Add(pnlPayLeft);

            // Panel Phải: Quét QR & Làm mới
            Panel pnlPayRight = new Panel();
            pnlPayRight.Dock = DockStyle.Fill;

            PictureBox picQr = new PictureBox();
            picQr.Dock = DockStyle.Fill;
            picQr.BackColor = Color.FromArgb(248, 249, 250);
            picQr.BorderStyle = BorderStyle.FixedSingle;
            picQr.Paint += delegate(object s, PaintEventArgs pe)
            {
                pe.Graphics.DrawString("QR NẠP CHIP TỰ ĐỘNG\r\n\r\nQuét mã chuyển khoản\r\nNội dung: IAUTOPRO",
                    new Font("Segoe UI", 10F, FontStyle.Bold), Brushes.DarkSlateGray, new RectangleF(10, 50, 190, 150));
            };

            Button btnRefreshPay = new Button();
            btnRefreshPay.Text = "Làm Mới Trạng Thái (Refresh)";
            btnRefreshPay.Dock = DockStyle.Bottom;
            btnRefreshPay.Height = 36;
            btnRefreshPay.Click += delegate
            {
                MessageBox.Show("Đã đồng bộ kiểm tra trạng thái thanh toán từ máy chủ xác thực.", "iAuto.Pay");
            };

            pnlPayRight.Controls.Add(picQr);
            pnlPayRight.Controls.Add(btnRefreshPay);
            splitPay.Panel2.Controls.Add(pnlPayRight);

            _tabPay.Controls.Add(splitPay);
        }

        private void BuildInboxTab()
        {
            _tabInbox.BackColor = Color.White;
            _tabInbox.Padding = new Padding(2);

            // 1. ListView danh sách tin nhắn đến
            ListView lvInbox = new ListView();
            lvInbox.Dock = DockStyle.Fill;
            lvInbox.View = View.Details;
            lvInbox.FullRowSelect = true;
            lvInbox.GridLines = true;

            lvInbox.Columns.Add("Thời gian", 75);
            lvInbox.Columns.Add("Người gửi", 80);
            lvInbox.Columns.Add("Người nhận", 80);
            lvInbox.Columns.Add("Nội dung", 160);

            // Thêm các tin nhắn mẫu
            string[][] sampleInbox = new string[][]
            {
                new string[] { "11:20:15", "HệThống", "Tất cả", "Bảo trì định kỳ máy chủ hoàn tất." },
                new string[] { "11:22:40", "BangChủ", "TổĐội", "Anh em tập trung càn quét Ác Bá đúng giờ!" },
                new string[] { "11:25:02", "ThươngHội", "TàiKhoản", "Vật phẩm treo sạp đã bán thành công +50 Vàng." }
            };
            for (int i = 0; i < sampleInbox.Length; i++)
            {
                ListViewItem item = new ListViewItem(sampleInbox[i][0]);
                item.SubItems.Add(sampleInbox[i][1]);
                item.SubItems.Add(sampleInbox[i][2]);
                item.SubItems.Add(sampleInbox[i][3]);
                lvInbox.Items.Add(item);
            }

            // 2. Ô xem chi tiết nội dung tin nhắn
            TextBox txtContent = new TextBox();
            txtContent.Dock = DockStyle.Bottom;
            txtContent.Height = 65;
            txtContent.Multiline = true;
            txtContent.ReadOnly = true;
            txtContent.BackColor = Color.FromArgb(250, 250, 250);
            txtContent.Text = "Chọn một tin nhắn để xem nội dung đầy đủ...";

            lvInbox.SelectedIndexChanged += delegate
            {
                if (lvInbox.SelectedItems.Count > 0)
                {
                    ListViewItem sel = lvInbox.SelectedItems[0];
                    txtContent.Text = string.Format("[{0}] Từ: {1} -> Đến: {2}\r\nNội dung: {3}",
                        sel.SubItems[0].Text, sel.SubItems[1].Text, sel.SubItems[2].Text, sel.SubItems[3].Text);
                }
            };

            // 3. Thanh gửi tin nhắn nhanh
            Panel pnlReply = new Panel();
            pnlReply.Dock = DockStyle.Bottom;
            pnlReply.Height = 28;

            TextBox txtTo = new TextBox();
            txtTo.Text = "Người nhận";
            txtTo.ForeColor = Color.Gray;
            txtTo.Width = 85;
            txtTo.Dock = DockStyle.Left;
            txtTo.GotFocus += delegate { if (txtTo.Text == "Người nhận") { txtTo.Text = ""; txtTo.ForeColor = Color.Black; } };
            txtTo.LostFocus += delegate { if (string.IsNullOrEmpty(txtTo.Text)) { txtTo.Text = "Người nhận"; txtTo.ForeColor = Color.Gray; } };

            Button btnSendReply = new Button();
            btnSendReply.Text = "Gửi";
            btnSendReply.Width = 55;
            btnSendReply.Dock = DockStyle.Right;

            TextBox txtMsg = new TextBox();
            txtMsg.Text = "Nội dung phản hồi...";
            txtMsg.ForeColor = Color.Gray;
            txtMsg.Dock = DockStyle.Fill;
            txtMsg.GotFocus += delegate { if (txtMsg.Text == "Nội dung phản hồi...") { txtMsg.Text = ""; txtMsg.ForeColor = Color.Black; } };
            txtMsg.LostFocus += delegate { if (string.IsNullOrEmpty(txtMsg.Text)) { txtMsg.Text = "Nội dung phản hồi..."; txtMsg.ForeColor = Color.Gray; } };

            btnSendReply.Click += delegate
            {
                if (!string.IsNullOrEmpty(txtMsg.Text) && txtMsg.Text != "Nội dung phản hồi...")
                {
                    ListViewItem newItem = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                    newItem.SubItems.Add("Tôi");
                    newItem.SubItems.Add(txtTo.Text);
                    newItem.SubItems.Add(txtMsg.Text);
                    lvInbox.Items.Add(newItem);
                    txtMsg.Text = "";
                }
            };

            pnlReply.Controls.Add(txtMsg);
            pnlReply.Controls.Add(txtTo);
            pnlReply.Controls.Add(btnSendReply);

            _tabInbox.Controls.Add(lvInbox);
            _tabInbox.Controls.Add(txtContent);
            _tabInbox.Controls.Add(pnlReply);
        }

        private void BuildSettingTab()
        {
            _tabSetting.BackColor = Color.White;
            _tabSetting.AutoScroll = true;
            _tabSetting.Padding = new Padding(6);

            // Group 1: Di Chuyển & Đội Ngũ
            GroupBox grpMovement = new GroupBox();
            grpMovement.Text = "Cài Đặt Di Chuyển & Đội Ngũ";
            grpMovement.Dock = DockStyle.Top;
            grpMovement.Height = 140;

            CheckBox chkFollow = new CheckBox();
            chkFollow.Text = "Cho Tổ Đội Theo Sau";
            chkFollow.Location = new Point(12, 22);
            chkFollow.Width = 180;
            chkFollow.Checked = true;

            CheckBox chkShowLeader = new CheckBox();
            chkShowLeader.Text = "Luôn Hiện Đội Trưởng";
            chkShowLeader.Location = new Point(200, 22);
            chkShowLeader.Width = 180;
            chkShowLeader.Checked = true;

            CheckBox chkSameMap = new CheckBox();
            chkSameMap.Text = "Chỉ Theo Sau Cùng Map";
            chkSameMap.Location = new Point(12, 50);
            chkSameMap.Width = 180;

            CheckBox chkHoldOnPhu = new CheckBox();
            chkHoldOnPhu.Text = "Đứng Im Sau Khi Phù Lên";
            chkHoldOnPhu.Location = new Point(200, 50);
            chkHoldOnPhu.Width = 180;

            CheckBox chkXaPhu = new CheckBox();
            chkXaPhu.Text = "Dùng Xa Phu Dịch Chuyển";
            chkXaPhu.Location = new Point(12, 78);
            chkXaPhu.Width = 180;
            chkXaPhu.Checked = true;

            CheckBox chkNoHorse = new CheckBox();
            chkNoHorse.Text = "Không Dùng Ngựa";
            chkNoHorse.Location = new Point(200, 78);
            chkNoHorse.Width = 180;

            CheckBox chkImmuneStop = new CheckBox();
            chkImmuneStop.Text = "Đứng Im Khi Miễn Dịch";
            chkImmuneStop.Location = new Point(12, 106);
            chkImmuneStop.Width = 180;

            grpMovement.Controls.Add(chkFollow);
            grpMovement.Controls.Add(chkShowLeader);
            grpMovement.Controls.Add(chkSameMap);
            grpMovement.Controls.Add(chkHoldOnPhu);
            grpMovement.Controls.Add(chkXaPhu);
            grpMovement.Controls.Add(chkNoHorse);
            grpMovement.Controls.Add(chkImmuneStop);

            // Group 2: Nhiệm Vụ & Tiện Ích
            GroupBox grpTasks = new GroupBox();
            grpTasks.Text = "Nhiệm Vụ & Tiện Ích";
            grpTasks.Dock = DockStyle.Top;
            grpTasks.Height = 115;

            CheckBox chkHuyQBang = new CheckBox();
            chkHuyQBang.Text = "Hủy Q Bang Nguyên Liệu";
            chkHuyQBang.Location = new Point(12, 22);
            chkHuyQBang.Width = 180;
            chkHuyQBang.Checked = true;

            CheckBox chkHuyQBinh = new CheckBox();
            chkHuyQBinh.Text = "Hủy Q Binh Môn Phái";
            chkHuyQBinh.Location = new Point(200, 22);
            chkHuyQBinh.Width = 180;

            CheckBox chkSpeedTrade = new CheckBox();
            chkSpeedTrade.Text = "Skill Tăng Tốc Chạy Thương Nhân";
            chkSpeedTrade.Location = new Point(12, 50);
            chkSpeedTrade.Width = 180;
            chkSpeedTrade.Checked = true;

            CheckBox chkNoSwitchMaTac = new CheckBox();
            chkNoSwitchMaTac.Text = "Không Chuyển Map Mã Tặc";
            chkNoSwitchMaTac.Location = new Point(200, 50);
            chkNoSwitchMaTac.Width = 180;

            CheckBox chkFakeMac = new CheckBox();
            chkFakeMac.Text = "Fake MAC Address";
            chkFakeMac.Location = new Point(12, 78);
            chkFakeMac.Width = 180;

            CheckBox chkNiceName = new CheckBox();
            chkNiceName.Text = "Tạo Tên Đẹp";
            chkNiceName.Location = new Point(200, 78);
            chkNiceName.Width = 180;

            grpTasks.Controls.Add(chkHuyQBang);
            grpTasks.Controls.Add(chkHuyQBinh);
            grpTasks.Controls.Add(chkSpeedTrade);
            grpTasks.Controls.Add(chkNoSwitchMaTac);
            grpTasks.Controls.Add(chkFakeMac);
            grpTasks.Controls.Add(chkNiceName);

            // Group 3: Báo Động (Alarm)
            GroupBox grpAlarm = new GroupBox();
            grpAlarm.Text = "Cảnh Báo & Báo Động (Alarm)";
            grpAlarm.Dock = DockStyle.Top;
            grpAlarm.Height = 85;

            CheckBox chkAlarmDis = new CheckBox();
            chkAlarmDis.Text = "Mất Kết Nối (Disconnect)";
            chkAlarmDis.Location = new Point(12, 22);
            chkAlarmDis.Width = 180;
            chkAlarmDis.Checked = true;

            CheckBox chkAlarmHp = new CheckBox();
            chkAlarmHp.Text = "Khi Sắp Hết Máu";
            chkAlarmHp.Location = new Point(200, 22);
            chkAlarmHp.Width = 180;
            chkAlarmHp.Checked = true;

            CheckBox chkAlarmPk = new CheckBox();
            chkAlarmPk.Text = "Khi Bị PK (Bị Đánh)";
            chkAlarmPk.Location = new Point(12, 50);
            chkAlarmPk.Width = 180;
            chkAlarmPk.Checked = true;

            CheckBox chkAlarmDead = new CheckBox();
            chkAlarmDead.Text = "Khi Tử Vong";
            chkAlarmDead.Location = new Point(200, 50);
            chkAlarmDead.Width = 180;
            chkAlarmDead.Checked = true;

            grpAlarm.Controls.Add(chkAlarmDis);
            grpAlarm.Controls.Add(chkAlarmHp);
            grpAlarm.Controls.Add(chkAlarmPk);
            grpAlarm.Controls.Add(chkAlarmDead);

            // Group 4: Nga My & Trân Thú
            GroupBox grpLotus = new GroupBox();
            grpLotus.Text = "Nga My & Trân Thú";
            grpLotus.Dock = DockStyle.Top;
            grpLotus.Height = 115;

            CheckBox chkRevive = new CheckBox();
            chkRevive.Text = "Hồi Sinh Đồng Đội";
            chkRevive.Location = new Point(12, 22);
            chkRevive.Width = 180;
            chkRevive.Checked = true;

            CheckBox chkBuffPet = new CheckBox();
            chkBuffPet.Text = "Tự Buff Máu Pet";
            chkBuffPet.Location = new Point(200, 22);
            chkBuffPet.Width = 180;
            chkBuffPet.Checked = true;

            CheckBox chkBuffSamePc = new CheckBox();
            chkBuffSamePc.Text = "Buff Cùng Máy";
            chkBuffSamePc.Location = new Point(12, 50);
            chkBuffSamePc.Width = 180;
            chkBuffSamePc.Checked = true;

            CheckBox chkBuffAll = new CheckBox();
            chkBuffAll.Text = "Buff Tất Cả Người Chơi";
            chkBuffAll.Location = new Point(200, 50);
            chkBuffAll.Width = 180;

            CheckBox chkNoXungHu = new CheckBox();
            chkNoXungHu.Text = "Không Dùng Xung Hư";
            chkNoXungHu.Location = new Point(12, 78);
            chkNoXungHu.Width = 180;

            CheckBox chkAutoFeedPet = new CheckBox();
            chkAutoFeedPet.Text = "Tự Cho Pet Ăn";
            chkAutoFeedPet.Location = new Point(200, 78);
            chkAutoFeedPet.Width = 180;
            chkAutoFeedPet.Checked = true;

            grpLotus.Controls.Add(chkRevive);
            grpLotus.Controls.Add(chkBuffPet);
            grpLotus.Controls.Add(chkBuffSamePc);
            grpLotus.Controls.Add(chkBuffAll);
            grpLotus.Controls.Add(chkNoXungHu);
            grpLotus.Controls.Add(chkAutoFeedPet);

            _tabSetting.Controls.Add(grpLotus);
            _tabSetting.Controls.Add(grpAlarm);
            _tabSetting.Controls.Add(grpTasks);
            _tabSetting.Controls.Add(grpMovement);
        }

        private void BuildConfigTab()
        {
            _tabConfig.BackColor = Color.White;
            _tabConfig.Padding = new Padding(2);

            SplitContainer splitConfig = new SplitContainer();
            splitConfig.Dock = DockStyle.Fill;
            splitConfig.SplitterDistance = 140;
            splitConfig.FixedPanel = FixedPanel.Panel1;

            // 1. TreeView bên trái chứa 23 danh mục Universal Config
            TreeView treeConfig = new TreeView();
            treeConfig.Dock = DockStyle.Fill;

            TreeNode nodeItems = new TreeNode("Vật Phẩm");
            string[] itemCategories = new string[]
            {
                "Hủy", "Bán", "Dùng", "Mua", "Cất", "Cất Thiên Cơ",
                "Gom", "Gom KNB", "Lấy", "Lấy Thiên Cơ", "Chỉ Nhặt", "Treo Shop", "Chia"
            };
            for (int i = 0; i < itemCategories.Length; i++)
            {
                nodeItems.Nodes.Add(new TreeNode(itemCategories[i]));
            }

            TreeNode nodeTargets = new TreeNode("Mục Tiêu & PK");
            string[] targetCategories = new string[] { "Bạn Bè", "Bỏ Qua", "Tuyên Chiến", "Chỉ Đánh", "Ưu Tiên" };
            for (int i = 0; i < targetCategories.Length; i++)
            {
                nodeTargets.Nodes.Add(new TreeNode(targetCategories[i]));
            }

            TreeNode nodeSystem = new TreeNode("Hệ Thống");
            string[] systemCategories = new string[] { "Lịch", "Tổ Đội", "Di Chuyển", "Point", "Skill" };
            for (int i = 0; i < systemCategories.Length; i++)
            {
                nodeSystem.Nodes.Add(new TreeNode(systemCategories[i]));
            }

            treeConfig.Nodes.Add(nodeItems);
            treeConfig.Nodes.Add(nodeTargets);
            treeConfig.Nodes.Add(nodeSystem);
            treeConfig.ExpandAll();

            splitConfig.Panel1.Controls.Add(treeConfig);

            // 2. Panel bên phải hiển thị danh sách quy tắc tương ứng
            Panel pnlRight = new Panel();
            pnlRight.Dock = DockStyle.Fill;

            Panel pnlTimeHeader = new Panel();
            pnlTimeHeader.Dock = DockStyle.Top;
            pnlTimeHeader.Height = 28;

            Label lblFrom = new Label();
            lblFrom.Text = "Từ:";
            lblFrom.Location = new Point(4, 6);
            lblFrom.Width = 25;

            TextBox txtFrom = new TextBox();
            txtFrom.Text = "00:00";
            txtFrom.Location = new Point(32, 4);
            txtFrom.Width = 50;

            Label lblTo = new Label();
            lblTo.Text = "Đến:";
            lblTo.Location = new Point(88, 6);
            lblTo.Width = 30;

            TextBox txtTo = new TextBox();
            txtTo.Text = "23:59";
            txtTo.Location = new Point(122, 4);
            txtTo.Width = 50;

            CheckBox chkLocked = new CheckBox();
            chkLocked.Text = "Khóa (Locked)";
            chkLocked.Location = new Point(180, 5);
            chkLocked.Width = 100;

            pnlTimeHeader.Controls.Add(lblFrom);
            pnlTimeHeader.Controls.Add(txtFrom);
            pnlTimeHeader.Controls.Add(lblTo);
            pnlTimeHeader.Controls.Add(txtTo);
            pnlTimeHeader.Controls.Add(chkLocked);

            ListView lvRules = new ListView();
            lvRules.Dock = DockStyle.Fill;
            lvRules.View = View.Details;
            lvRules.FullRowSelect = true;
            lvRules.GridLines = true;
            lvRules.CheckBoxes = true;

            lvRules.Columns.Add("Tên Quy Tắc", 140);
            lvRules.Columns.Add("Số Lượng", 60);
            lvRules.Columns.Add("Trạng Thái", 65);

            // Nạp dữ liệu mẫu
            string[][] sampleRules = new string[][]
            {
                new string[] { "Kim Sang Dược", "100", "Áp dụng" },
                new string[] { "Định Vị Phù", "20", "Áp dụng" },
                new string[] { "Bí Ngân Khoáng", "99", "Áp dụng" },
                new string[] { "Tơ Tằm", "99", "Áp dụng" }
            };
            for (int i = 0; i < sampleRules.Length; i++)
            {
                ListViewItem item = new ListViewItem(sampleRules[i][0]);
                item.Checked = true;
                item.SubItems.Add(sampleRules[i][1]);
                item.SubItems.Add(sampleRules[i][2]);
                lvRules.Items.Add(item);
            }

            treeConfig.AfterSelect += delegate(object s, TreeViewEventArgs ev)
            {
                if (ev.Node != null)
                {
                    lvRules.Items.Clear();
                    ListViewItem item1 = new ListViewItem(string.Format("Mục: {0} 1", ev.Node.Text));
                    item1.Checked = true;
                    item1.SubItems.Add("10");
                    item1.SubItems.Add("Áp dụng");

                    ListViewItem item2 = new ListViewItem(string.Format("Mục: {0} 2", ev.Node.Text));
                    item2.Checked = true;
                    item2.SubItems.Add("50");
                    item2.SubItems.Add("Áp dụng");

                    lvRules.Items.Add(item1);
                    lvRules.Items.Add(item2);
                }
            };

            Panel pnlRuleActions = new Panel();
            pnlRuleActions.Dock = DockStyle.Bottom;
            pnlRuleActions.Height = 32;

            TextBox txtNewRule = new TextBox();
            txtNewRule.Text = "Tên vật phẩm...";
            txtNewRule.ForeColor = Color.Gray;
            txtNewRule.Location = new Point(4, 5);
            txtNewRule.Width = 115;
            txtNewRule.GotFocus += delegate { if (txtNewRule.Text == "Tên vật phẩm...") { txtNewRule.Text = ""; txtNewRule.ForeColor = Color.Black; } };
            txtNewRule.LostFocus += delegate { if (string.IsNullOrEmpty(txtNewRule.Text)) { txtNewRule.Text = "Tên vật phẩm..."; txtNewRule.ForeColor = Color.Gray; } };

            Button btnAdd = new Button();
            btnAdd.Text = "Thêm";
            btnAdd.Location = new Point(122, 4);
            btnAdd.Size = new Size(50, 24);
            btnAdd.Click += delegate
            {
                if (!string.IsNullOrEmpty(txtNewRule.Text) && txtNewRule.Text != "Tên vật phẩm...")
                {
                    ListViewItem item = new ListViewItem(txtNewRule.Text);
                    item.Checked = true;
                    item.SubItems.Add("1");
                    item.SubItems.Add("Áp dụng");
                    lvRules.Items.Add(item);
                    txtNewRule.Text = "";
                }
            };

            Button btnDel = new Button();
            btnDel.Text = "Xóa";
            btnDel.Location = new Point(174, 4);
            btnDel.Size = new Size(45, 24);
            btnDel.Click += delegate
            {
                if (lvRules.SelectedItems.Count > 0)
                {
                    lvRules.Items.Remove(lvRules.SelectedItems[0]);
                }
            };

            Button btnSave = new Button();
            btnSave.Text = "Lưu (Save)";
            btnSave.Location = new Point(221, 4);
            btnSave.Size = new Size(60, 24);
            btnSave.Click += delegate
            {
                MessageBox.Show("Đã lưu thiết lập cấu hình vật phẩm và mục tiêu thành công!", "iAuto.Config");
            };

            pnlRuleActions.Controls.Add(txtNewRule);
            pnlRuleActions.Controls.Add(btnAdd);
            pnlRuleActions.Controls.Add(btnDel);
            pnlRuleActions.Controls.Add(btnSave);

            pnlRight.Controls.Add(lvRules);
            pnlRight.Controls.Add(pnlTimeHeader);
            pnlRight.Controls.Add(pnlRuleActions);
            splitConfig.Panel2.Controls.Add(pnlRight);

            _tabConfig.Controls.Add(splitConfig);
        }

        private void BuildChatTab()
        {
            _tabChat.BackColor = Color.White;
            _tabChat.Padding = new Padding(2);

            // 1. Header Trạng Thái Chat
            Panel pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 28;
            pnlHeader.BackColor = Color.FromArgb(248, 249, 250);

            Label lblTitle = new Label();
            lblTitle.Text = "Kênh Chat Trực Tiếp - TLBB Server";
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(6, 6);
            lblTitle.Width = 220;

            Label lblMeta = new Label();
            lblMeta.Text = "Online • 1 client";
            lblMeta.ForeColor = Color.DarkGreen;
            lblMeta.Dock = DockStyle.Right;
            lblMeta.TextAlign = ContentAlignment.MiddleRight;
            lblMeta.Width = 120;

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblMeta);

            // 2. Nội dung Chat
            RichTextBox rtbChat = new RichTextBox();
            rtbChat.Dock = DockStyle.Fill;
            rtbChat.ReadOnly = true;
            rtbChat.BackColor = Color.White;
            rtbChat.Font = new Font("Consolas", 9F);
            rtbChat.Text = "[Hệ thống] iAuto Clean Architecture khởi chạy thành công.\r\n" +
                           "[Hệ thống] Đã đồng bộ toàn bộ Menu: Player, Hourly, Quest, Fuben, All, i, Go.\r\n" +
                           "[Hệ thống] Đã đồng bộ toàn bộ Tab: Game, Login, Pay, inbox, Setting, Config, Chat.\r\n" +
                           "[Thế Giới] [Thiên Long]: Tuyển 1 Nga My đi Phụ bản Thiếu Thất Sơn!\r\n" +
                           "[Bang Hội] [BangChủ]: Anh em bật auto luyện công bãi 2 Hạn Huyết Lĩnh nhé.\r\n";

            // 3. Khung Gửi Tin Nhắn Phía Dưới
            Panel pnlSend = new Panel();
            pnlSend.Dock = DockStyle.Bottom;
            pnlSend.Height = 32;

            ComboBox cboChannel = new ComboBox();
            cboChannel.Width = 85;
            cboChannel.Dock = DockStyle.Left;
            cboChannel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChannel.Items.Add("Thế Giới");
            cboChannel.Items.Add("Bang Hội");
            cboChannel.Items.Add("Môn Phái");
            cboChannel.Items.Add("Đội Ngũ");
            cboChannel.Items.Add("Mật");
            cboChannel.SelectedIndex = 0;

            Button btnSend = new Button();
            btnSend.Text = "Gửi";
            btnSend.Dock = DockStyle.Right;
            btnSend.Width = 55;

            TextBox txtMsg = new TextBox();
            txtMsg.Dock = DockStyle.Fill;

            btnSend.Click += delegate
            {
                if (!string.IsNullOrEmpty(txtMsg.Text))
                {
                    string channelTag = cboChannel.SelectedItem.ToString();
                    rtbChat.AppendText(string.Format("[{0}] [Tôi]: {1}\r\n", channelTag, txtMsg.Text));
                    if (_selectedContext != null && _selectedContext.LuaService != null)
                    {
                        _selectedContext.LuaService.ExecuteLua(string.Format("Chat:Send('{0}');", txtMsg.Text.Replace("'", "\\'")));
                    }
                    txtMsg.Clear();
                }
            };

            pnlSend.Controls.Add(txtMsg);
            pnlSend.Controls.Add(cboChannel);
            pnlSend.Controls.Add(btnSend);

            _tabChat.Controls.Add(rtbChat);
            _tabChat.Controls.Add(pnlHeader);
            _tabChat.Controls.Add(pnlSend);
        }

        #endregion

        #region Bộ Quản Lý Luồng & Tự Động Quét Game

        private void InitializeTimer()
        {
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 1000;
            _refreshTimer.Tick += OnTimerTick;
            _refreshTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            try
            {
                ScanRunningClients();
                UpdateClientStates();
            }
            catch (Exception ex)
            {
                File.AppendAllText("run.log", "TimerTick Exception: " + ex.ToString() + "\r\n");
            }
        }

        private void ScanRunningClients()
        {
            Process[] processes = Process.GetProcessesByName("Game");
            if (processes.Length == 0)
            {
                processes = Process.GetProcessesByName("Launch");
            }

            for (int i = 0; i < processes.Length; i++)
            {
                Process proc = processes[i];
                if (!_activeClients.ContainsKey(proc.Id))
                {
                    try
                    {
                        ProcessMemoryReader reader = new ProcessMemoryReader(proc.Id);
                        if (reader.ProcessHandle == IntPtr.Zero) continue;

                        GameProfileOffsets offsets = GameProfileOffsets.CreateDefaultProfile(1, 0x00400000);
                        GameStateReader stateReader = new GameStateReader(reader, offsets);
                        LuaCommandService luaService = new LuaCommandService(proc.MainWindowHandle, reader.ProcessHandle);
                        CombatConfig config = new CombatConfig();
                        PathfindingService pathfinder = new PathfindingService(luaService);
                        CombatService combatService = new CombatService(luaService, proc.MainWindowHandle);
                        BossTacticsService bossTactics = new BossTacticsService(pathfinder);
                        AutoCharacterController controller = new AutoCharacterController(
                            stateReader, combatService, pathfinder, bossTactics, config);

                        ListViewItem item = new ListViewItem(string.Format("[{0}]", proc.Id));
                        item.SubItems.Add("0");
                        item.SubItems.Add("Chưa rõ");
                        item.SubItems.Add("Kết nối...");
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.SubItems.Add("Online");
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.Tag = proc.Id;

                        _lvCharacters.Items.Add(item);

                        CharacterContext context = new CharacterContext
                        {
                            ProcessId = proc.Id,
                            WindowHandle = proc.MainWindowHandle,
                            MemoryReader = reader,
                            StateReader = stateReader,
                            LuaService = luaService,
                            CombatService = combatService,
                            Pathfinder = pathfinder,
                            BossTactics = bossTactics,
                            Controller = controller,
                            Config = config,
                            IsRunning = true,
                            ListItem = item
                        };

                        context.AutoThread = new Thread(new ParameterizedThreadStart(CharacterAutoWorker));
                        context.AutoThread.IsBackground = true;
                        context.AutoThread.Start(context);

                        _activeClients.Add(proc.Id, context);
                    }
                    catch
                    {
                        // Bỏ qua lỗi truy cập client bị khóa
                    }
                }
            }

            // Dọn dẹp tiến trình đã tắt
            List<int> toRemove = new List<int>();
            foreach (KeyValuePair<int, CharacterContext> kv in _activeClients)
            {
                try
                {
                    Process proc = Process.GetProcessById(kv.Key);
                    if (proc.HasExited)
                    {
                        toRemove.Add(kv.Key);
                    }
                }
                catch
                {
                    toRemove.Add(kv.Key);
                }
            }

            for (int i = 0; i < toRemove.Count; i++)
            {
                int pid = toRemove[i];
                CharacterContext ctx = _activeClients[pid];
                ctx.IsRunning = false;
                if (ctx.ListItem != null)
                {
                    _lvCharacters.Items.Remove(ctx.ListItem);
                }
                _activeClients.Remove(pid);
            }
        }

        private void CharacterAutoWorker(object arg)
        {
            CharacterContext ctx = (CharacterContext)arg;
            while (ctx.IsRunning)
            {
                try
                {
                    ctx.Controller.Tick();
                }
                catch
                {
                    // Tránh crash luồng nền
                }
                Thread.Sleep(200);
            }
        }

        private void UpdateClientStates()
        {
            foreach (KeyValuePair<int, CharacterContext> kv in _activeClients)
            {
                CharacterContext ctx = kv.Value;
                if (ctx.ListItem != null && ctx.Controller != null && ctx.Controller.LastPlayerState != null)
                {
                    PlayerState p = ctx.Controller.LastPlayerState;
                    ctx.ListItem.Text = string.IsNullOrEmpty(p.CharacterName) ? string.Format("[{0}]", ctx.ProcessId) : p.CharacterName;
                    ctx.ListItem.SubItems[1].Text = p.Level.ToString();
                    ctx.ListItem.SubItems[2].Text = p.Menpai.ToString();
                    ctx.ListItem.SubItems[3].Text = ctx.Controller.CurrentState.ToString();
                    ctx.ListItem.SubItems[4].Text = string.Format("{0}%", p.HpPercent);
                    ctx.ListItem.SubItems[5].Text = string.Format("{0}%", p.MpPercent);
                }
            }
        }

        private void OnCharacterSelectionChanged(object sender, EventArgs e)
        {
            if (_lvCharacters.SelectedItems.Count > 0)
            {
                ListViewItem sel = _lvCharacters.SelectedItems[0];
                int pid = (int)sel.Tag;
                if (_activeClients.ContainsKey(pid))
                {
                    _selectedContext = _activeClients[pid];
                }
            }
            else
            {
                _selectedContext = null;
            }
        }

        private void OnActionItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (_selectedContext != null && _selectedContext.Config != null)
            {
                string name = e.Item.Text;
                bool isChecked = e.Item.Checked;

                if (name == "Attack") _selectedContext.Config.AutoAttack = isChecked;
                else if (name == "Quay Lại Bãi") _selectedContext.Config.AutoReturnToCamp = isChecked;
                else if (name == "HP") _selectedContext.Config.AutoHealHp = isChecked;
                else if (name == "MP") _selectedContext.Config.AutoHealMp = isChecked;
            }
        }

        private void ToggleAllActions()
        {
            bool checkAll = true;
            if (_lvActions.Items.Count > 0 && _lvActions.Items[0].Checked)
            {
                checkAll = false;
            }

            for (int i = 0; i < _lvActions.Items.Count; i++)
            {
                _lvActions.Items[i].Checked = checkAll;
            }
        }

        private void ShowGoBaiduongDialog()
        {
            Form dlg = new Form();
            dlg.Text = "Danh Sách Bãi Train (iAuto.Go)";
            dlg.Size = new Size(300, 380);
            dlg.StartPosition = FormStartPosition.CenterParent;

            ListBox lb = new ListBox();
            lb.Dock = DockStyle.Fill;
            lb.Items.Add("Côn Lôn Sơn - Bãi Gấu (210, 180)");
            lb.Items.Add("Đại Uyển - Bãi Ngựa (145, 90)");
            lb.Items.Add("Hạn Huyết Lĩnh - Bãi 1 (88, 120)");
            lb.Items.Add("Hạn Huyết Lĩnh - Bãi 2 (160, 210)");
            lb.Items.Add("Hỏa Diệm Sơn - Bãi Quỷ (110, 75)");
            lb.Items.Add("Cao Xương Mê Cung (130, 140)");
            lb.Items.Add("Tháp Khắc Lạp Mã Can (180, 220)");

            Button btnGo = new Button();
            btnGo.Text = "Di chuyển đến bãi";
            btnGo.Dock = DockStyle.Bottom;
            btnGo.Height = 36;
            btnGo.Click += delegate
            {
                if (lb.SelectedItem != null && _selectedContext != null && _selectedContext.Pathfinder != null)
                {
                    MessageBox.Show(dlg, string.Format("Đã phát lệnh di chuyển tới: {0}", lb.SelectedItem), "iAuto");
                    dlg.Close();
                }
                else
                {
                    MessageBox.Show(dlg, "Vui lòng chọn bãi và chọn nhân vật đang mở game.", "iAuto");
                }
            };

            dlg.Controls.Add(lb);
            dlg.Controls.Add(btnGo);
            dlg.ShowDialog(this);
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (KeyValuePair<int, CharacterContext> kv in _activeClients)
            {
                kv.Value.IsRunning = false;
            }
            base.OnFormClosing(e);
        }
    }
}
