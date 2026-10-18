using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020002CE RID: 718
internal class Class501
{
	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x0600240D RID: 9229 RVA: 0x001117D0 File Offset: 0x0010F9D0
	public static Dictionary<int, string> Dictionary_0
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 0, "None" },
				{ 1, "Thiếu Lâm" },
				{ 2, "Minh Giáo" },
				{ 3, "Cái Bang" },
				{ 4, "Võ Đang" },
				{ 5, "Nga My" },
				{ 6, "Tinh Túc" },
				{ 7, "Thiên Long" },
				{ 8, "Thiên Sơn" },
				{ 9, "Tiêu Dao" },
				{ 32, "Mộ Dung" },
				{ 37, "Đường Môn" },
				{ 53, "Quỷ Cốc" },
				{ 54, "Đào Hoa" },
				{ 55, "Tuyệt Tình" },
				{ 58, "Ác Nhân Cốc" }
			};
		}
	}

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x0600240E RID: 9230 RVA: 0x001118AC File Offset: 0x0010FAAC
	public static Dictionary<string, string> Dictionary_1
	{
		get
		{
			return new Dictionary<string, string>
			{
				{ "Shao Lin", "Thiếu Lâm" },
				{ "Pyromancer", "Minh Giáo" },
				{ "Beggars Alliance", "Cái Bang" },
				{ "Taoist", "Võ Đang" },
				{ "Lotus Order", "Nga My" },
				{ "Voodoo", "Quỷ Cốc" },
				{ "Royalty", "Thiên Long" },
				{ "Assassin", "Thiên Sơn" },
				{ "Minstrel", "Tiêu Dao" },
				{ "Sphinx", "Mộ Dung" },
				{ "Tang Men", "Đường Môn" },
				{ "Ghost Fairy", "Tinh Túc" },
				{ "Peach Blossom Island", "Đào Hoa" },
				{ "Heartless", "Tuyệt Tình" },
				{ "Luo Yang", "Lạc Dương" },
				{ "Su Zhou", "Tô Châu" },
				{ "Da Li", "Đại Lý" },
				{ "Kroraina", "Lâu Lan" }
			};
		}
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x0600240F RID: 9231 RVA: 0x001119E0 File Offset: 0x0010FBE0
	public static Dictionary<string, int> Dictionary_2
	{
		get
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary["Stiletto1_1"] = 10;
			dictionary["Stiletto1_2"] = 20;
			dictionary["Stiletto1_3"] = 30;
			dictionary["Stiletto1_4"] = 40;
			dictionary["Stiletto1_5"] = 50;
			dictionary["Stiletto1_6"] = 60;
			dictionary["Stiletto1_7"] = 70;
			dictionary["Stiletto1_8"] = 80;
			dictionary["Stiletto1_9"] = 90;
			dictionary["Stiletto1_10"] = 100;
			dictionary["Stiletto1_11"] = 110;
			dictionary["Stiletto1_12"] = 120;
			dictionary["Stiletto1_13"] = 130;
			dictionary["Stiletto1_14"] = 140;
			dictionary["Stiletto1_15"] = 150;
			return dictionary;
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06002410 RID: 9232 RVA: 0x00111AC0 File Offset: 0x0010FCC0
	public static HashSet<string> HashSet_0
	{
		get
		{
			return new HashSet<string>
			{
				"Minh Hư Nô", "Bạch Minh Khởi", "Huyền Kích Thần Tướng", "Huyền Kích Kim Cang", "Mãng Cổ Độc Cáp", "Mãng Cổ Độc Cáp Vương", "Thiên Niên Băng Phách", "Băng Yêu", "Đông Vực phiên giang Tiểu Thậ", "Đông Vực Hỗn Giang Tiểu Long",
				"Đông Vực xuất động Tiểu Giao", "Nam Vực Hỗn Giang Tiểu Long", "Nam Vực xuất động Tiểu Giao", "Nam Vực phiên giang Tiểu Thận", "Tây Vực xuất động Tiểu Giao", "Tây Vực Hỗn Giang Tiểu Long", "Tây Vực phiên giang Tiểu Thận", "Bắc Vực phiên giang Tiểu Thận", "Bắc Vực Hỗn Giang Tiểu Long", "Bắc Vực xuất động Tiểu Giao"
			};
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06002411 RID: 9233 RVA: 0x00111BC4 File Offset: 0x0010FDC4
	public static List<string> List_0
	{
		get
		{
			return new List<string>(67)
			{
				"ShutDown - Tắt Máy", "Chạy Thương Nhân", "Ác Tặc [Key]", "Ác Bá [Key]", "Tàng Kinh Các [Key]", "Dã Trư [Key]", "Phụng Hoàng Lăng Mộ [Key]", "Kỳ Cuộc [Key]", "Lâu Lan Tầm Bảo [Key]", "Phiêu Miễu Phong [Key]",
				"Huyết Chiến Phiêu Miễu Phong [Key]", "Thiên Giáng Kỳ Thú [Key]", "Q123 Tô Châu [Key]", "Q123 Lâu Lan [Key]", "Yến Tử Ô [Key]", "Tứ Tuyệt Trang [Key]", "Tụ Bảo Bồn", "Luyện Kim", "Luyện Kim Nhanh", "Phù Về Thành",
				"Nhiệm Vụ Hàng Ngày", "Nhiệm Vụ Sư Môn", "Thủ Bị [Chiến Minh]", "Bán Đồ + Cất Đồ + Trị Liệu", "Bán Rác", "Thiếu Thất Sơn", "Sát Tinh", "Nhận Bóng", "Móng Heo", "Tam Thần Huyễn Cảnh",
				"Vương Lăng", "Lên Bãi Train", "Dùng Thổ Linh Châu", "Reset Time", "Nhận Kinh Nghiệm Lưu Trữ", "Phúc Địa", "Phúc Địa Khó", "Phân Giải Trang Bị Pet", "Reset Giờ Toàn Bộ Người Chơi", "Thoát Game",
				"Mã Tặc", "Trừng Ác", "Thần Khí 9 Sao", "Đổi Huyễn Sắc Câu Thiên Thái", "Trang Sức Cửu Lê", "Đến Kim Lăng", "Binh Thánh", "Binh Thánh Khó", "Nhận Phỉ Thúy", "Bảo Vệ Bang",
				"Mở Shop Chiến Công", "Mở Shop Bách Bảo Các", "Mở Shop Trung Đô", "Mở Shop Quỷ Thị", "Nhận Chiến Công - Kiếm Chỉ", "Nhận Thưởng Quan Sơn Hải", "Q1 Tô Châu", "Q2 Tô Châu", "Q1 Lâu Lan", "Q2 Lâu Lan",
				"Thủy Lao", "Refresh", "Boss Map - Kính Hồ", "Boss Map - Huyền Vũ Đảo", "Boss Map - Thảo Nguyên", "Boss Map - Võ Di", "Boss Map - Thương Sơn"
			};
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06002412 RID: 9234 RVA: 0x00111EBC File Offset: 0x001100BC
	public static HashSet<string> HashSet_1
	{
		get
		{
			return new HashSet<string>
			{
				"Đao Búa", "Song Đoản", "Thương Bổng", "Khuyên", "Nỏ", "Phiến", "Đơn Đoản", "Loại Trường Trượng", "Loại Tiêu Kiếm", "Loại Đao",
				"Hộ Phù", "Hộ Kiên", "Hộ Uyển", "Y Phục", "Hài", "Hộ Thủ", "Mão", "Hạng Liên", "Yêu Đai", "Giới Chỉ",
				"Thương Tần"
			};
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x06002413 RID: 9235 RVA: 0x00111FCC File Offset: 0x001101CC
	public static HashSet<string> HashSet_2
	{
		get
		{
			return new HashSet<string>
			{
				"Phiến", "Đao Búa", "Song Đoản", "Thương Bổng", "Khuyên", "Nỏ", "Đơn Đoản", "Loại Trường Trượng", "Loại Tiêu Kiếm", "Loại Đao",
				"Lãnh Liêm"
			};
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06002414 RID: 9236 RVA: 0x00112064 File Offset: 0x00110264
	public static HashSet<string> HashSet_3
	{
		get
		{
			return new HashSet<string>
			{
				"Hộ Phù", "Hộ Kiên", "Hộ Uyển", "Y Phục", "Hài", "Hộ Thủ", "Mão", "Hạng Liên", "Yêu Đai", "Giới Chỉ",
				"Yêu Đái"
			};
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06002415 RID: 9237 RVA: 0x001120FC File Offset: 0x001102FC
	public static HashSet<string> HashSet_4
	{
		get
		{
			return new HashSet<string> { "Hộ Kiên", "Y Phục", "Hài", "Hộ Thủ", "Mão", "Yêu Đai" };
		}
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06002416 RID: 9238 RVA: 0x000187A0 File Offset: 0x000169A0
	public static HashSet<string> HashSet_5
	{
		get
		{
			return new HashSet<string> { "Giới Chỉ", "Hộ Phù", "Hạng Liên", "Hộ Uyển" };
		}
	}

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06002417 RID: 9239 RVA: 0x000187D7 File Offset: 0x000169D7
	// (set) Token: 0x06002418 RID: 9240 RVA: 0x000187DE File Offset: 0x000169DE
	public static List<string> List_1 { get; set; }

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x06002419 RID: 9241 RVA: 0x00112158 File Offset: 0x00110358
	public static Dictionary<int, string> Dictionary_3
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 38005402, "Hộp Quà Bích Ngọc Châu Cẩm" },
				{ 38005288, "Dao Hoa Bích" },
				{ 20700055, "Kim Tinh Thạch" },
				{ 30008034, "Kim Cương Sa" },
				{ 30503133, "Thiên Tôi Thần Ngọc" },
				{ 30700241, "Hồi Thiên Thần Thạch" },
				{ 38002047, "Tử Phủ Tinh Tủy" },
				{ 38001454, "Cửu Thiên Tẩy Luyện Phù" },
				{ 30503019, "Cao Cấp Trân Thú Hoàn Đồng Thiên Thư" },
				{ 38004810, "Võ Ước Tâm Quyết Tố Hạp" },
				{ 38000831, "Công Lực Đan" },
				{ 38005106, "Tố Hồi Nhật Quỹ" },
				{ 38005103, "Nhân Hào Chú Linh Phù-Phai Màu" },
				{ 38005104, "Địa Mậu Chú Linh Phù-Phai Màu" },
				{ 38005105, "Thiên Cực Chú Linh Phù-Phai Màu" },
				{ 38005108, "Lưu Hỏa Tương Kim Lệnh" },
				{ 38005097, "Kinh Nghiệm Hồi Tố Lệnh" },
				{ 38005096, "Nội Tức Hồi Tố Lệnh" }
			};
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x0600241A RID: 9242 RVA: 0x0011228C File Offset: 0x0011048C
	public static List<string> List_2
	{
		get
		{
			return new List<string>(74)
			{
				"huyennam1906@gmail.com", "tieudattai@yahoo.com", "sonvu171@gmail.com", "tieudiepminhanh@gmail.com", "binzfake@gmail.com", "phananh.slna.1989@gmail.com", "quangkhain02@gmail.com", "quyhoan0402@gmail.com", "sonvu1677@gmail.com", "bachnx92@gmail.com",
				"sonvu.drive@gmail.com", "phamthubg1993@gmail.com", "bachnx92@gmail.com", "bachnx92_1@gmail.com", "bachnx92_2@gmail.com", "bachnx92_3@gmail.com", "bachnx92_4@gmail.com", "bachnx92_5@gmail.com", "bachnx92_6@gmail.com", "bachnx92_7@gmail.com",
				"bachnx92_8@gmail.com", "bachnx92_9@gmail.com", "bachnx92_10@gmail.com", "bachnx92_11@gmail.com", "bachnx92_12@gmail.com", "bachnx92_13@gmail.com", "bachnx92_14@gmail.com", "bachnx92_15@gmail.com", "bachnx92_16@gmail.com", "bachnx92_17@gmail.com",
				"bachnx92_18@gmail.com", "bachnx92_19@gmail.com", "bachnx92_20@gmail.com", "bachnx92_21@gmail.com", "bachnx92_22@gmail.com", "bachnx92_23@gmail.com", "bachnx92_24@gmail.com", "bachnx92_25@gmail.com", "bachnx92_26@gmail.com", "bachnx92_27@gmail.com",
				"bachnx92_28@gmail.com", "bachnx92_29@gmail.com", "bachnx92_30@gmail.com", "beng_1@gmail.com", "beng_2@gmail.com", "beng_3@gmail.com", "beng_4@gmail.com", "beng_5@gmail.com", "beng_6@gmail.com", "beng_7@gmail.com",
				"beng_8@gmail.com", "beng_9@gmail.com", "beng_10@gmail.com", "beng_11@gmail.com", "beng_12@gmail.com", "beng_13@gmail.com", "beng_14@gmail.com", "beng_15@gmail.com", "beng_16@gmail.com", "beng_17@gmail.com",
				"beng_18@gmail.com", "beng_19@gmail.com", "beng_20@gmail.com", "beng_21@gmail.com", "beng_22@gmail.com", "beng_23@gmail.com", "beng_24@gmail.com", "beng_25@gmail.com", "beng_26@gmail.com", "beng_27@gmail.com",
				"beng_28@gmail.com", "beng_29@gmail.com", "beng_30@gmail.com", "tranviet92@gmail.com"
			};
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x0600241B RID: 9243 RVA: 0x001125D0 File Offset: 0x001107D0
	public static List<string> List_3
	{
		get
		{
			return new List<string>(75)
			{
				"huyennam1906@gmail.com", "tieudattai@yahoo.com", "sonvu171@gmail.com", "tieudiepminhanh@gmail.com", "binzfake@gmail.com", "phananh.slna.1989@gmail.com", "quangkhain02@gmail.com", "quyhoan0402@gmail.com", "sonvu1677@gmail.com", "bachnx92@gmail.com",
				"sonvu.drive@gmail.com", "phamthubg1993@gmail.com", "bachnx92@gmail.com", "bachnx92_1@gmail.com", "bachnx92_2@gmail.com", "bachnx92_3@gmail.com", "bachnx92_4@gmail.com", "bachnx92_5@gmail.com", "bachnx92_6@gmail.com", "bachnx92_7@gmail.com",
				"bachnx92_8@gmail.com", "bachnx92_9@gmail.com", "bachnx92_10@gmail.com", "bachnx92_11@gmail.com", "bachnx92_12@gmail.com", "bachnx92_13@gmail.com", "bachnx92_14@gmail.com", "bachnx92_15@gmail.com", "bachnx92_16@gmail.com", "bachnx92_17@gmail.com",
				"bachnx92_18@gmail.com", "bachnx92_19@gmail.com", "bachnx92_20@gmail.com", "bachnx92_21@gmail.com", "bachnx92_22@gmail.com", "bachnx92_23@gmail.com", "bachnx92_24@gmail.com", "bachnx92_25@gmail.com", "bachnx92_26@gmail.com", "bachnx92_27@gmail.com",
				"bachnx92_28@gmail.com", "bachnx92_29@gmail.com", "bachnx92_30@gmail.com", "beng_1@gmail.com", "beng_2@gmail.com", "beng_3@gmail.com", "beng_4@gmail.com", "beng_5@gmail.com", "beng_6@gmail.com", "beng_7@gmail.com",
				"beng_8@gmail.com", "beng_9@gmail.com", "beng_10@gmail.com", "beng_11@gmail.com", "beng_12@gmail.com", "beng_13@gmail.com", "beng_14@gmail.com", "beng_15@gmail.com", "beng_16@gmail.com", "beng_17@gmail.com",
				"beng_18@gmail.com", "beng_19@gmail.com", "beng_20@gmail.com", "beng_21@gmail.com", "beng_22@gmail.com", "beng_23@gmail.com", "beng_24@gmail.com", "beng_25@gmail.com", "beng_26@gmail.com", "beng_27@gmail.com",
				"beng_28@gmail.com", "beng_29@gmail.com", "beng_30@gmail.com", "tranviet92@gmail.com", "dangvanvu1@gmail.com"
			};
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x0600241C RID: 9244 RVA: 0x00112920 File Offset: 0x00110B20
	public static Dictionary<int, string> Dictionary_4
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 0, "Luo Yang" },
				{ 1, "Su Zhou" },
				{ 2, "Da Li" },
				{ 3, "Mt. Sanctity" },
				{ 4, "Reed Port" },
				{ 5, "Twin Island" },
				{ 6, "Mt. Infinity" },
				{ 7, "Wild Plains" },
				{ 8, "Dun Huang" },
				{ 9, "Shaolin Temple" },
				{ 10, "Beggars Alliance" },
				{ 11, "Fire Palace" },
				{ 12, "Mt. Wu Tang" },
				{ 13, "Royal Temple" },
				{ 14, "Minstrel Cave" },
				{ 15, "Mt. Emei" },
				{ 16, "Voodoo Sea" },
				{ 17, "Assassin" },
				{ 18, "South Yan" },
				{ 19, "North Yan" },
				{ 20, "Grasslands" },
				{ 21, "West Liao" },
				{ 22, "Mt. Everwhite" },
				{ 23, "Yellow Dragon Mansion" },
				{ 24, "Werewolf Plain" },
				{ 25, "Werewolf Hill" },
				{ 26, "Stone Forest" },
				{ 27, "Jade Valley" },
				{ 28, "South Rainforest" },
				{ 29, "Border Miao" },
				{ 30, "West Lake" },
				{ 31, "Dragon Fountain" },
				{ 32, "Mt. Fire Rock" },
				{ 33, "Plum Hill" },
				{ 34, "South Sea" },
				{ 35, "Crocodile Island" },
				{ 36, "Solon Manor" },
				{ 37, "Swallow's Dock" },
				{ 38, "Top Hall" },
				{ 39, "Reserved 1" },
				{ 40, "Reserve 2" },
				{ 41, "Reserved 3" },
				{ 42, "Rebel Camp" },
				{ 47, "Puppet Alley" },
				{ 61, "Chess Challenge" },
				{ 66, "Water Prison" },
				{ 71, "Da Li" },
				{ 72, "Da Li" },
				{ 73, "Mt. Infinity" },
				{ 74, "Mt. Infinity" },
				{ 75, "Wild Plains" },
				{ 76, "Wild Plains" },
				{ 77, "Inferno" },
				{ 78, "Desert Fortress" },
				{ 79, "Liao Border" },
				{ 80, "Gangsters' Village" },
				{ 81, "Bamboo Grove" },
				{ 82, "Arena" },
				{ 92, "Arena" },
				{ 102, "Light Cave" },
				{ 103, "Minstrels' Backyard" },
				{ 104, "Nimbus Peak" },
				{ 105, "Beggars' Cellar" },
				{ 106, "Blossom Island" },
				{ 107, "Pagodas" },
				{ 108, "Spider Cave" },
				{ 109, "Plum Peak" },
				{ 110, "Grave" },
				{ 111, "Tower Floor" },
				{ 112, "Pet Island" },
				{ 113, "Solon Manor" },
				{ 114, "Swallow's Dock" },
				{ 115, "Top Hall" },
				{ 116, "Duel Stage" },
				{ 117, "Duel Stage" },
				{ 118, "The Dead Valley" },
				{ 119, "The Dead Valley" },
				{ 120, "Mt. Mist" },
				{ 121, "Mt. Mist" },
				{ 122, "Mini Puppet Alley" },
				{ 123, "King's Garden" },
				{ 124, "Commercial 2" },
				{ 125, "Mine" },
				{ 126, "Pasture" },
				{ 127, "Technology 1" },
				{ 128, "Market" },
				{ 129, "South Cave of Mt. Yan" },
				{ 130, "South Cave of Mt. Yan" },
				{ 131, "South Cave of Mt. Yan" },
				{ 132, "South Cave of Mt. Yan" },
				{ 133, "Light Cave" },
				{ 134, "Minstrels' Backyard" },
				{ 135, "Nimbus Peak" },
				{ 136, "Beggars' Cellar" },
				{ 137, "Blossom Island" },
				{ 138, "Pagodas" },
				{ 139, "Spider Cave" },
				{ 140, "Plum Peak" },
				{ 141, "Tower Floor" },
				{ 142, "Light Cave" },
				{ 143, "Minstrels' Backyard" },
				{ 144, "Nimbus Peak" },
				{ 145, "Beggars' Cellar" },
				{ 146, "Blossom Island" },
				{ 147, "Pagodas" },
				{ 148, "Spider Cave" },
				{ 149, "Plum Peak" },
				{ 150, "Tower Floor" },
				{ 151, "Market" },
				{ 152, "Market" },
				{ 153, "Building Site" },
				{ 154, "Expand 1" },
				{ 155, "Tribunal" },
				{ 156, "Arena" },
				{ 157, "Arena" },
				{ 158, "Arena" },
				{ 159, "Arena" },
				{ 160, "Arena" },
				{ 161, "Arena" },
				{ 162, "Arena" },
				{ 163, "Arena" },
				{ 164, "West Lake" },
				{ 165, "Scripture Library" },
				{ 166, "Treasure Cave C1" },
				{ 167, "Tribunal" },
				{ 168, "Crest of Mt. Hua" },
				{ 169, "Treasure Cave C2" },
				{ 170, "Pasture" },
				{ 171, "Technology 1" },
				{ 172, "Technology 1" },
				{ 173, "Shaolin Temple" },
				{ 174, "Beggars Alliance" },
				{ 175, "Fire Palace" },
				{ 176, "Mt. Wu Tang" },
				{ 177, "Royal Temple" },
				{ 178, "Minstrel Cave" },
				{ 179, "Mt. Emei" },
				{ 180, "Voodoo Sea" },
				{ 181, "Assassin" },
				{ 182, "Shaolin Temple" },
				{ 183, "Beggars Alliance" },
				{ 184, "Fire Palace" },
				{ 185, "Mt. Wu Tang" },
				{ 186, "Royal Temple" },
				{ 187, "Minstrel Cave" },
				{ 188, "Mt. Emei" },
				{ 189, "Voodoo Sea" },
				{ 190, "Assassin" },
				{ 191, "Treasure Cave C3" },
				{ 192, "Treasure Cave C4" },
				{ 193, "Treasure Cave C5" },
				{ 194, "Prison" },
				{ 195, "Fighting Arena" },
				{ 196, "Hall" },
				{ 197, "Advanced Hall" },
				{ 198, "Luxurious Hall" },
				{ 199, "Fodder Grassland" },
				{ 200, "Carven Miao" },
				{ 201, "Pet Hill" },
				{ 202, "Yan Tomb F1" },
				{ 203, "Yan Tomb F2" },
				{ 204, "Yan Tomb F3" },
				{ 205, "Yan Tomb F4" },
				{ 206, "Yan Tomb F5" },
				{ 207, "Yan Tomb F6" },
				{ 208, "Yan Tomb F7" },
				{ 209, "Yan Tomb F8" },
				{ 210, "Yan Tomb F9" },
				{ 211, "Cave Boatyard" },
				{ 212, "Warriors Grave" },
				{ 213, "Qin Dungeon" },
				{ 214, "Fell Garden" },
				{ 215, "Hot Spring Cave" },
				{ 216, "Dragon Cave" },
				{ 217, "Crystal Cave" },
				{ 218, "Tomb of Khan" },
				{ 219, "Underground Forest" },
				{ 220, "Fairy Cave" },
				{ 221, "Pirate Cave" },
				{ 222, "Snow Wolf Lake" },
				{ 223, "Phoenix Town" },
				{ 224, "Bank" },
				{ 225, "Mini Puppet Alley" },
				{ 226, "Mini Puppet Alley" },
				{ 227, "King's Garden" },
				{ 228, "King's Garden" },
				{ 229, "Wild Snowfield" },
				{ 230, "Bandit Village" },
				{ 231, "Boar Farm" },
				{ 232, "Pet Hill" },
				{ 233, "Soccer Field" },
				{ 234, "Emperor's Arena" },
				{ 235, "Salt Lake" },
				{ 236, "Salt Lake" },
				{ 237, "Azure Pit" },
				{ 238, "Luo Yang 1st Lounge" },
				{ 239, "Luo Yang 2nd Lounge" },
				{ 240, "Da Li Lounge" },
				{ 241, "Su Zhou Lounge" },
				{ 242, "Luo Yang" },
				{ 243, "Ice Space" },
				{ 244, "Flame Mountain" },
				{ 245, "Ancient City" },
				{ 246, "Kroraina" },
				{ 247, "Tarim" },
				{ 248, "Mt. Kunlun" },
				{ 249, "Horse Ranch" },
				{ 250, "Sanctity Grasslands" },
				{ 251, "Flame Valley" },
				{ 252, "Ancient Maze" },
				{ 253, "Taklamakan Desert" },
				{ 254, "Kunlun Land" },
				{ 255, "Ferghana Hill" },
				{ 256, "Flame Palace" },
				{ 257, "Soccer Field" },
				{ 258, "Basketball Field" },
				{ 259, "Volleyball Field" },
				{ 260, "Mask Town" },
				{ 261, "Misty Peaks" },
				{ 262, "Qin Emperor's Dungeon B1" },
				{ 263, "Qin Emperor's Dungeon B2" },
				{ 264, "Qin Emperor's Dungeon B3" },
				{ 265, "Thunder Hill" },
				{ 266, "Miasma Bog" },
				{ 267, "Lava Field" },
				{ 268, "Pet Island" },
				{ 269, "Kroraina Treasure Cave" },
				{ 270, "Ancient Thunderdome" },
				{ 271, "Field Posthouse" },
				{ 272, "Scripture Library" },
				{ 273, "Mansion of Crime Lv 1" },
				{ 274, "Mansion of Crime Lv 2" },
				{ 275, "Mansion of Crime Lv 3" },
				{ 276, "Mansion of Crime Lv 4" },
				{ 277, "Mansion of Crime Lv 5" },
				{ 278, "Mansion of Crime Lv 6" },
				{ 279, "Mansion of Crime Lv 7" },
				{ 280, "Phoenix Town" },
				{ 281, "Phoenix Tomb" },
				{ 282, "Sacred Headstream" },
				{ 283, "Sacred Headstream Cave" },
				{ 284, "Qin Emperor's Dungeon B4" },
				{ 285, "Sphinx Holy Library" },
				{ 286, "Sphinx Holy Library" },
				{ 287, "Sphinx Holy Library" },
				{ 288, "Sphinx Manor" },
				{ 289, "Sphinx Manor" },
				{ 290, "Sphinx Manor" },
				{ 340, "Lounge" },
				{ 341, "Arena" },
				{ 342, "Challenge" },
				{ 343, "Emperor's Arena" },
				{ 501, "Outland 1" },
				{ 502, "Outland 2" },
				{ 503, "Outland 3" },
				{ 504, "Outland 4" },
				{ 505, "Outland 5" },
				{ 506, "Outland 1" },
				{ 507, "Outland 2" },
				{ 508, "Outland 3" },
				{ 509, "Outland 4" },
				{ 510, "Outland 5" },
				{ 511, "Outland 1" },
				{ 512, "Outland 2" },
				{ 513, "Outland 3" },
				{ 514, "Outland 4" },
				{ 515, "Outland 5" },
				{ 516, "Outland 1" },
				{ 517, "Outland 2" },
				{ 518, "Outland 3" },
				{ 519, "Outland 4" },
				{ 520, "Outland 5" },
				{ 521, "Outland 1" },
				{ 522, "Outland 2" },
				{ 523, "Outland 3" },
				{ 524, "Outland 4" },
				{ 525, "Outland 5" },
				{ 526, "Outland 1" },
				{ 527, "Outland 2" },
				{ 528, "Outland 3" },
				{ 529, "Outland 4" },
				{ 530, "Outland 5" },
				{ 531, "Outland 1" },
				{ 532, "Outland 2" },
				{ 533, "Outland 3" },
				{ 534, "Outland 4" },
				{ 535, "Outland 5" },
				{ 536, "Outland 1" },
				{ 537, "Outland 2" },
				{ 538, "Outland 3" },
				{ 539, "Outland 4" },
				{ 540, "Outland 5" },
				{ 541, "Outland 1" },
				{ 542, "Outland 2" },
				{ 543, "Outland 3" },
				{ 544, "Outland 4" },
				{ 545, "Outland 5" },
				{ 546, "Crucial Arena" },
				{ 547, "12 Monters Arena" },
				{ 549, "Rest Room" },
				{ 569, "Fairy Ghost Battlefield" },
				{ 579, "Phoenix Tomb" },
				{ 614, "Four Villains Challenge" },
				{ 615, "Tang Men Castle" },
				{ 616, "Tang Castle" },
				{ 663, "Battlefield" },
				{ 738, "Arena" }
			};
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x0600241D RID: 9245 RVA: 0x00113B5C File Offset: 0x00111D5C
	public static List<string> List_4
	{
		get
		{
			return new List<string>(6) { "118,42", "126,42", "130,47", "126,52", "118,52", "114,47" };
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x0600241E RID: 9246 RVA: 0x00113BB4 File Offset: 0x00111DB4
	public static List<string> List_5
	{
		get
		{
			return new List<string>(6) { "144,55", "137,55", "142,70", "133,61", "136,69", "147,66" };
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x0600241F RID: 9247 RVA: 0x00113C0C File Offset: 0x00111E0C
	public static List<string> List_6
	{
		get
		{
			return new List<string>(6) { "210,124", "207,120", "209,115", "214,114", "217,118", "216,123" };
		}
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x06002420 RID: 9248 RVA: 0x00113C64 File Offset: 0x00111E64
	public static List<string> List_7
	{
		get
		{
			return new List<string>(6) { "78,176", "84,175", "88,179", "86,185", "80,186", "76,182" };
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x06002421 RID: 9249 RVA: 0x00113CBC File Offset: 0x00111EBC
	public static Dictionary<string, int> Dictionary_5
	{
		get
		{
			return new Dictionary<string, int>
			{
				{ "Shenqi_1_9", 49 },
				{ "Shenqi_1_10", 59 },
				{ "Shenqi_1_11", 69 },
				{ "Shenqi_1_12", 79 },
				{ "Shenqi_1_13", 89 },
				{ "Shenqi_1_14", 99 },
				{ "Shenqi_1_15", 109 },
				{ "CircularTaskTool45_14", 119 }
			};
		}
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x06002422 RID: 9250 RVA: 0x00113D38 File Offset: 0x00111F38
	public static List<string> List_8
	{
		get
		{
			return new List<string>(45)
			{
				"Thương Lang KNT Trảo - Dũng", "Thương Lang KNT Trảo - Giảo", "Thương Lang KNT Trảo - Thận", "Hoàng Tước HTT Trảo - Khiếp", "Hoàng Tước HTT Trảo - Giảo", "Hoàng Tước HTT Trảo - Thận", "Ô Đồn Vọng Nhật Trảo-Trung", "Ô Đồn Vọng Nhật Trảo-Thận", "Bạch Thố Ẩn LT Trảo - Thận", "Thương Lang KNT Khôi - Dũng",
				"Thương Lang KNT Khôi - Giảo", "Thương Lang KNT Khôi - Thận", "Hoàng Tước HTT Khôi - Khiếp", "Hoàng Tước HTT Khôi - Giảo", "Hoàng Tước HTT Khôi - Thận", "Ô Đồn Vọng Nhật Khôi-Trung", "Ô Đồn Vọng Nhật Khôi-Thận", "Bạch Thố Ẩn LT Khôi - Thận", "Thương Lang KNT Giáp - Dũng", "Thương Lang KNT Giáp - Giảo",
				"Thương Lang KNT Giáp - Thận", "Hoàng Tước HTT Giáp - Khiếp", "Hoàng Tước HTT Giáp - Giảo", "Hoàng Tước HTT Giáp - Thận", "Ô Đồn Vọng Nhật Giáp-Trung", "Ô Đồn Vọng Nhật Giáp-Thận", "Bạch Thố Ẩn LT Giáp - Thận", "Thương Lang KNT Hoàn - Dũng", "Thương Lang KNT Hoàn - Giảo", "Thương Lang KNT Hoàn - Thận",
				"Hoàng Tước HTT Hoàn - Khiếp", "Hoàng Tước HTT Hoàn - Giảo", "Hoàng Tước HTT Hoàn - Thận", "Ô Đồn Vọng Nhật Hoàn-Trung", "Ô Đồn Vọng Nhật Hoàn-Thận", "Bạch Thố Ẩn LT Hoàn - Thận", "Thương Lang KNT Sức - Dũng", "Thương Lang KNT Sức - Giảo", "Thương Lang KNT Sức - Thận", "Hoàng Tước HTT Sức - Khiếp",
				"Hoàng Tước HTT Sức - Giảo", "Hoàng Tước HTT Sức - Thận", "Ô Đồn Vọng Nhật Sức-Trung", "Ô Đồn Vọng Nhật Sức-Thận", "Bạch Thố Ẩn LT Sức - Thận"
			};
		}
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x06002423 RID: 9251 RVA: 0x00113F3C File Offset: 0x0011213C
	public static HashSet<string> HashSet_6
	{
		get
		{
			return new HashSet<string>
			{
				"Lưu Kim Võ Lâm Ấn Đại Lý Sát Tinh", "Lưu Kim Võ Lâm Ấn Như Hổ Thiêm Dực", "Lưu Kim Võ Lâm Ấn Thần Dũng Võ Hồn", "Lưu Kim Võ Lâm Ấn Tiềm Tâm Tu Luyện", "Khoa Ngân Võ Lâm Ấn Túc Cầu Thịnh Hội", "Quả Ngân Võ Lâm Ấn Kiếm Tiền", "Quả Ngân Võ Lâm Ấn Bối Diệp Kinh Tàn Phiến", "Khoa Ngân Võ Lâm Ấn Phồn Mang Tào Vận", "Thanh Đồng Ấn-Tương Trợ Sư Môn", "Thanh Đồng Ấn-Trừ Ác",
				"Thanh Đồng Ấn-Trừng Hung", "Sinh Tài Chi Đạo"
			};
		}
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x06002424 RID: 9252 RVA: 0x00113FE0 File Offset: 0x001121E0
	public static HashSet<string> HashSet_7
	{
		get
		{
			return new HashSet<string>
			{
				"Đại Lý Kỳ Thánh", "Tô Châu Kỳ Thánh", "Lạc Dương Kỳ Thánh", "Hắc Bạch", "#{YD_100806_52}", "Ván Cờ Sinh Tử", "Đánh Lén Môn Phái", "#{YD_100806_64}", "Giang hồ tà đạo", "Tặc Binh Xâm Nhập",
				"#{YD_100806_56}", "Ác Tặc Tạo Phản", "#{LSHDR_150203_93}", "Đầu Sỏ Tam Quan", "#{LSHDR_150203_15}", "Vào Tam Tài Trận"
			};
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x06002425 RID: 9253 RVA: 0x001140B4 File Offset: 0x001122B4
	public static HashSet<string> HashSet_8
	{
		get
		{
			return new HashSet<string> { "#{ZYRW_120522_66}", "Ngộ chân nguyên", "#{ZYRW_120522_67}", "Chân nguyên hiện thế", "#{ZYRW_120522_68}", "Tìm kiếm chân nguyên", "#{ZYRW_120522_69}", "Chân nguyên chi đạo", "#{ZYRW_120522_70}", "Huyền âm giải chân nguyên" };
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x06002426 RID: 9254 RVA: 0x00114140 File Offset: 0x00112340
	public static List<string> List_9
	{
		get
		{
			return new List<string>(12)
			{
				"Hồi Báo Thiên Sư (1)", "Thiên sư kỳ đãi (1)", "Thiên sư kỳ đãi (2)", "Thiên sư kỳ đãi (3)", "Thiên sư kỳ đãi (4)", "Thiên sư kỳ đãi (5)", "Thiên sư kỳ đãi (6)", "Thiên sư kỳ đãi (7)", "Thiên sư kỳ đãi (8)", "Thiên sư kỳ đãi (9)",
				"Thiên sư kỳ đãi (10)", "Hồi Báo Thiên Sư (1)"
			};
		}
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06002427 RID: 9255 RVA: 0x001141D8 File Offset: 0x001123D8
	public static List<string> List_10
	{
		get
		{
			return new List<string>(8) { "Đèn nhà ai nấy sáng", "Áo xanh lỗi lạc hành núi hiểm", "Vi Tiếu Chi Lữ", "Ác Quán Mãn Doanh", "Gặp nhau tại Vạn Kiếp Cốc", "Đại chiến Vạn Kiếp Cốc", "Đại tiến quân", "Hổ khiếu long ngâm" };
		}
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06002428 RID: 9256 RVA: 0x00114244 File Offset: 0x00112444
	public static Dictionary<string, string> Dictionary_6
	{
		get
		{
			return new Dictionary<string, string>
			{
				{ "Juqing_Can_001", "Đèn nhà ai nấy sáng" },
				{ "Juqing_Can_002", "Áo xanh lỗi lạc hành núi hiểm" },
				{ "Juqing_Can_003", "Vi Tiếu Chi Lữ" },
				{ "Juqing_Can_004", "Ác Quán Mãn Doanh" },
				{ "Juqing_Can_005", "Gặp nhau tại Vạn Kiếp Cốc" },
				{ "Juqing_Can_006", "Đại chiến Vạn Kiếp Cốc" },
				{ "Juqing_Can_007", "Đại tiến quân" },
				{ "Juqing_Can_008", "Hổ khiếu long ngâm" },
				{ "Juqing_Can_009", "Cô Tô Mộ Dung" },
				{ "Juqing_Can_010", "Hoàn Thị Thủy Các" },
				{ "Juqing_Can_011", "Độc chiến song hùng" },
				{ "Juqing_Can_012", "Đêm dài lắm mộng" },
				{ "Juqing_Can_013", "Nhất phẩm đường" },
				{ "Juqing_Can_014", "Chỉ Điểm Quần Hào" },
				{ "Juqing_Can_015", "Bi Tô Thanh Phong" },
				{ "Juqing_Can_016", "Tứ hải là nhà" },
				{ "Juqing_Can_017", "Quần Long Vô Thủ" },
				{ "Juqing_Can_018", "Cùng Tiến Cùng Lùi" },
				{ "Juqing_Can_019", "Thiên hạ võ công xuất Thiếu Lâm" },
				{ "Juqing_Can_020", "Tụ Hiền Trang" },
				{ "Juqing_Can_021", "Đỉnh thiên lập địa" },
				{ "Juqing_Can_046", "Kỳ sau gặp mặt" },
				{ "Juqing_Can_022", "Dù vạn người, ta vẫn cứ tiến" },
				{ "Juqing_Can_023", "Huyết Chiến Tụ Hiền Trang" },
				{ "Juqing_Can_024", "Bảo vệ Mã Phu Nhân" },
				{ "Juqing_Can_025", "Nhất Bàn Tản Sa" },
				{ "Juqing_Can_026", "Tới núi Thương Mang" },
				{ "Juqing_Can_027", "Thiên thời không bằng địa lợi" },
				{ "Juqing_Can_028", "Cần Vương" },
				{ "Juqing_Can_029", "Bày mưu tính kế" },
				{ "Juqing_Can_030", "Tứ Diện Sở Ca" },
				{ "Juqing_Can_031", "Kim Qua Đãng Khấu Ngao Binh" },
				{ "Juqing_Can_032", "Lục Quân Tị Dịch" },
				{ "Juqing_Can_033", "Trân Long Kỳ Hội" },
				{ "Juqing_Can_034", "Tịnh hầu quế âm" },
				{ "Juqing_Can_035", "Thua thắng thành bại ai biết được" },
				{ "Juqing_Can_036", "Chọn ngày tái chiến" },
				{ "Juqing_Can_037", "Đóng cửa bắt trộm" },
				{ "Juqing_Can_038", "Hội Thi Túc Cầu" },
				{ "Juqing_Can_039", "Nhất kiếm thượng thiên sơn" },
				{ "Juqing_Can_040", "Dù nguy mà yên" },
				{ "Juqing_Can_041", "Y tiếu nhân gian vạn sự" },
				{ "Juqing_Can_042", "Hoàn Phụng Không quy nguyệt dạ hồn" },
				{ "Juqing_Can_043", "Bày tiệc rượu hỏi Quân Tam Ngữ" },
				{ "Juqing_Can_044", "Tình yêu không phải là mơ" },
				{ "Juqing_Can_045", "Bên Nhau Trọn Đời" },
				{ "CJG_101231_115", "Cái Bang Nghi Vấn Ban Đầu" },
				{ "CJG_101231_116", "Trừ độc vật giải nguy Cái Bang" },
				{ "CJG_101231_117", "Ẩn danh do thám Cái Bang" },
				{ "CJG_101231_118", "Cùng lên Thiếu Lâm" },
				{ "CJG_101231_119", "Đến Thiếu Lâm trừ gian kết nghĩa" }
			};
		}
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06002429 RID: 9257 RVA: 0x00114588 File Offset: 0x00112788
	public static Dictionary<string, string> Dictionary_7
	{
		get
		{
			return new Dictionary<string, string>
			{
				{ "#{MISSIONNAME_JUQING_1}", "Hội Thi Túc Cầu" },
				{ "#{CJG_101231_122}", "Trừ độc vật giải nguy Cái Bang" },
				{ "#{CJG_101231_123}", "Ẩn danh do thám Cái Bang" },
				{ "#{CJG_101231_124}", "Cùng lên Thiếu Lâm" },
				{ "#{CJG_101231_125}", "Đến Thiếu Lâm trừ gian kết nghĩa" }
			};
		}
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x0600242A RID: 9258 RVA: 0x001145EC File Offset: 0x001127EC
	public static Dictionary<int, string> Dictionary_8
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 0, "Lạc Dương" },
				{ 1, "Tô Châu" },
				{ 2, "Đại Lý" },
				{ 3, "Tung Sơn" },
				{ 4, "Thái Hồ" },
				{ 5, "Kính Hồ" },
				{ 6, "Vô Lượng Sơn" },
				{ 7, "Kiếm Các" },
				{ 8, "Đôn Hoàng" },
				{ 9, "Thiếu Lâm Tự" },
				{ 10, "Cái Bang Tổng Đà " },
				{ 11, "Quang Minh Điện" },
				{ 12, "Võ Đang Sơn" },
				{ 13, "Thiên Long Tự " },
				{ 14, "Lăng Ba Động " },
				{ 15, "Nga Mi Sơn" },
				{ 16, "Tinh Túc Hải " },
				{ 17, "Thiên Sơn" },
				{ 18, "Nhạn Nam" },
				{ 19, "Nhạn Bắc " },
				{ 20, "Thảo Nguyên" },
				{ 21, "Liêu Tây " },
				{ 22, "Trường Bạch Sơn " },
				{ 23, "Hoàng Long Phủ " },
				{ 24, "Nhĩ Hải " },
				{ 25, "Thương Sơn " },
				{ 26, "Thạch Lâm " },
				{ 27, "Ngọc Khê " },
				{ 28, "Nam Chiêu " },
				{ 29, "Miêu Cương " },
				{ 30, "Tây Hồ" },
				{ 31, "Long Tuyền " },
				{ 32, "Võ Di " },
				{ 33, "Mai Lĩnh " },
				{ 34, "Nam Vực" },
				{ 35, "Quỳnh Châu" },
				{ 36, "Tụ Hiền Trang " },
				{ 37, "Yến Tử ‘ " },
				{ 38, "Nhất phẩm đường " },
				{ 39, "Dự Lưu 1" },
				{ 40, "Dự Lưu 2" },
				{ 41, "Dự lưu 3" },
				{ 42, "Phản quân doanh địa" },
				{ 43, "Kỉ niệm Lạc Dương" },
				{ 44, "Kỉ niệm Tô Châu" },
				{ 45, "Đại Lý tròn một năm" },
				{ 46, "Kỉ niệm Lâu Lan" },
				{ 47, "Mộc Nhân Hạng" },
				{ 61, "Trân Long Kỳ Cuộc" },
				{ 66, "Thủy lao" },
				{ 71, "Đại Lý 2" },
				{ 72, "Đại Lý 3" },
				{ 73, "Vô Lượng Sơn 2" },
				{ 74, "Vô Lượng Sơn 3" },
				{ 75, "Kiếm Các 2" },
				{ 76, "Kiếm Các 3" },
				{ 77, "Địa phủ" },
				{ 78, "Sa mạc yếu trại" },
				{ 82, "Lôi đài" },
				{ 92, "Lôi đài" },
				{ 102, "Quang Minh động" },
				{ 103, "Đáy cốc Tiêu Dao" },
				{ 104, "Linh Tính Phong" },
				{ 105, "Cái Bang Tửu Diếu" },
				{ 106, "Đào Hoa Trận" },
				{ 107, "Tháp Lâm" },
				{ 108, "Ngũ Thần Động" },
				{ 109, "Chiết Mai Phong" },
				{ 110, "Huyệt mộ" },
				{ 111, "Chân tháp" },
				{ 112, "Huyền Vũ Đảo" },
				{ 113, "Tụ Hiền Trang " },
				{ 114, "Yến Tử ‘ " },
				{ 115, "Nhất phẩm đường " },
				{ 116, "Lôi Cổ Sơn" },
				{ 117, "Lôi Cổ Sơn" },
				{ 118, "Vạn Kiếp Cốc" },
				{ 119, "Vạn Kiếp Cốc" },
				{ 120, "Thương Mang Sơn " },
				{ 121, "Thương Mang Sơn " },
				{ 122, "Tiểu Mộc Nhân Hạng" },
				{ 123, "Hậu Hoa Viên" },
				{ 124, "Chợ" },
				{ 125, "Khoáng trường" },
				{ 126, "Nông trại" },
				{ 127, "Thư Phòng" },
				{ 128, "Thị tập" },
				{ 129, "Nhạn Nam sơn động" },
				{ 130, "Nhạn Bắc sơn động" },
				{ 131, "Tây Hồ sơn động" },
				{ 132, "Thương Sơn sơn động" },
				{ 133, "Quang Minh động" },
				{ 134, "Đáy cốc Tiêu Dao" },
				{ 135, "Linh Tính Phong" },
				{ 136, "Cái Bang Tửu Diếu" },
				{ 137, "Đào Hoa Trận" },
				{ 138, "Tháp Lâm" },
				{ 139, "Ngũ Thần Động" },
				{ 140, "Chiết Mai Phong" },
				{ 141, "Chân tháp" },
				{ 142, "Quang Minh động" },
				{ 143, "Đáy cốc Tiêu Dao" },
				{ 144, "Linh Tính Phong" },
				{ 145, "Cái Bang Tửu Diếu" },
				{ 146, "Đào Hoa Trận" },
				{ 147, "Tháp Lâm" },
				{ 148, "Ngũ Thần Động" },
				{ 149, "Chiết Mai Phong" },
				{ 150, "Chân tháp" },
				{ 151, "Thị tập" },
				{ 152, "Thị tập" },
				{ 153, "Công địa" },
				{ 154, "Thao Trường" },
				{ 155, "Nha Môn" },
				{ 156, "Lôi đài" },
				{ 157, "Lôi đài" },
				{ 158, "Lôi đài" },
				{ 159, "Lôi đài" },
				{ 160, "Lôi đài" },
				{ 161, "Lôi đài" },
				{ 162, "Lôi đài" },
				{ 163, "Lôi đài" },
				{ 164, "Dạ Tây Hồ" },
				{ 165, "Tàng Kinh Các" },
				{ 166, "Bảo Tàng Động Tầng 1 " },
				{ 167, "Khảo trường" },
				{ 168, "Hoa Sơn tuyệt đỉnh" },
				{ 169, "Bảo Tàng Động Tầng 2 " },
				{ 170, "Tặc Khấu doanh địa" },
				{ 171, "Tàng Kinh Các" },
				{ 172, "Tàng Kinh Các" },
				{ 173, "Thiếu Lâm Tự" },
				{ 174, "Cái Bang Tổng Đà " },
				{ 175, "Quang Minh Điện" },
				{ 176, "Võ Đang Sơn" },
				{ 177, "Thiên Long Tự " },
				{ 178, "Lăng Ba Động " },
				{ 179, "Nga Mi Sơn" },
				{ 180, "Tinh Túc Hải " },
				{ 181, "Thiên Sơn" },
				{ 182, "Thiếu Lâm Tự" },
				{ 183, "Cái Bang Tổng Đà " },
				{ 184, "Quang Minh Điện" },
				{ 185, "Võ Đang Sơn" },
				{ 186, "Thiên Long Tự " },
				{ 187, "Lăng Ba Động " },
				{ 188, "Nga Mi Sơn" },
				{ 189, "Tinh Túc Hải " },
				{ 190, "Thiên Sơn" },
				{ 191, "Bảo Tàng Động Tầng 3 " },
				{ 192, "Bảo Tàng Động Tầng 4 " },
				{ 193, "Bảo Tàng Động tầng 5 " },
				{ 194, "Giám ngục" },
				{ 195, "Tỷ Võ Hội Trường" },
				{ 196, "Lễ đường phổ thông" },
				{ 197, "Lễ đường cao cấp" },
				{ 198, "Lễ đường hào hoa" },
				{ 199, "Thảo Liệu Trường" },
				{ 200, "Miêu Nhân Động" },
				{ 201, "Thánh Thú Sơn" },
				{ 202, "Yến Vương Cổ Mộ Tầng 1" },
				{ 203, "Yến Vương Cổ Mộ Tầng 2" },
				{ 204, "Yến Vương Cổ Mộ Tầng 3" },
				{ 205, "Yến Vương Cổ Mộ Tầng 4" },
				{ 206, "Yến Vương Cổ Mộ Tầng 5" },
				{ 207, "Yến Vương Cổ Mộ Tầng 6" },
				{ 208, "Yến Vương Cổ Mộ Tầng 7" },
				{ 209, "Yến Vương Cổ Mộ Tầng 8" },
				{ 210, "Yến Vương Cổ Mộ Tầng 9" },
				{ 211, "Bến Tàu Sơn Động" },
				{ 212, "Kiếm Gia" },
				{ 213, "Ma Nhai Động" },
				{ 214, "Dã Nhân Câu" },
				{ 215, "Ôn Tuyền Động" },
				{ 216, "Hoàng Long Động" },
				{ 217, "Thủy Kính Hồ" },
				{ 218, "Tiên Vương Phần" },
				{ 219, "Thiên Khanh Thụ Động" },
				{ 220, "Đào Hoa Nguyên" },
				{ 221, "Hải Tặc Động" },
				{ 222, "Tuyết Lang Hồ" },
				{ 223, "Phụng Hoàng Cổ Trấn" },
				{ 224, "Tiền Trang" },
				{ 225, "Tiểu Mộc Nhân Cảng 2" },
				{ 226, "Tiểu Mộc Nhân Cảng 3" },
				{ 227, "Hậu Hoa Viên 2" },
				{ 228, "Hậu Hoa Viên 3" },
				{ 229, "Ngân Ngai Tuyết Nguyên" },
				{ 230, "Kính Hồ Phỉ Trại" },
				{ 231, "Nông trường Dã Trư" },
				{ 232, "Phó bản Thánh Thú Sơn" },
				{ 233, "Mẫu Đơn Uyển" },
				{ 234, "Tung Sơn phong thiền đài" },
				{ 235, "Diêm Hồ" },
				{ 236, "Yến Tử ‘ " },
				{ 237, "Bạch sa diêm khanh" },
				{ 238, "Đệ nhất khu nghỉ ngơi tại Lạc Dương" },
				{ 239, "Đệ nhị khu nghỉ ngơi tại Lạc Dương" },
				{ 240, "Khu nghỉ ngơi tại Đại Lý" },
				{ 241, "Khu nghỉ ngơi tại Tô Châu" },
				{ 242, "Lạc Dương" },
				{ 243, "Hàn Ngọc Cốc" },
				{ 244, "Hỏa Diệm Sơn" },
				{ 245, "Cao Xương" },
				{ 246, "Lâu Lan" },
				{ 247, "Tháp Lý Mộc " },
				{ 248, "Côn Lôn Sơn" },
				{ 249, "Đại Uyển" },
				{ 250, "Tát Mã Nhĩ Hãn" },
				{ 251, "Hỏa Diệm Cốc" },
				{ 252, "Cao Xương Mê Cung" },
				{ 253, "Tháp Khắc Lạp Mã Can" },
				{ 254, "Côn Lôn Phúc Địa" },
				{ 255, "Hãn Huyết Lĩnh" },
				{ 256, "Thánh hỏa cung" },
				{ 257, "Sân bóng đá" },
				{ 258, "Sân bóng rổ" },
				{ 259, "Sân bóng bàn" },
				{ 260, "Thúc Hà Cổ Trấn" },
				{ 261, "Phiêu Miễu Phong" },
				{ 262, "Tần Hoàng Địa Cung Tầng 1" },
				{ 263, "Tần Hoàng Địa Cung Tầng 2" },
				{ 264, "Tần Hoàng Địa Cung Tầng 3" },
				{ 268, "Huyền Vũ Đảo" },
				{ 269, "Lâu Lan Bảo Tàng Động" },
				{ 270, "Trác Lộc" },
				{ 271, "Lượng Mã Dịch" },
				{ 272, "Tàng Kinh Các" },
				{ 273, "Thiên Kiếp Lâu Tầng 1" },
				{ 274, "Thiên Kiếp Lâu Tầng 2" },
				{ 275, "Thiên Kiếp Lâu Tầng 3" },
				{ 276, "Thiên Kiếp Lâu Tầng 4" },
				{ 277, "Thiên Kiếp Lâu Tầng 5" },
				{ 278, "Thiên Kiếp Lâu Tầng 6" },
				{ 279, "Thiên Kiếp Lâu Tầng 7" },
				{ 280, "Phụng Hoàng Cổ Thành" },
				{ 281, "Phụng Hoàng Lăng Mộ" },
				{ 282, "Thanh Nguyên" },
				{ 283, "Thanh Nguyên Sơn Động" },
				{ 284, "Mộ Dung Sơn Trang" },
				{ 285, "Tàng Thư Thủy Các" },
				{ 286, "Tàng Thư Thủy Các" },
				{ 287, "Tàng Thư Thủy Các" },
				{ 288, "Mộ Dung Sơn Trang" },
				{ 289, "Mộ Dung Sơn Trang" },
				{ 290, "Đỉnh Hoa Sơn" },
				{ 291, "Tứ Tuyệt Trang" },
				{ 292, "Tần Hoàng Địa Cung Tầng 4" },
				{ 293, "Niêm Hoa Mộc Nhân Trận" },
				{ 294, "Binh Thánh Kỳ Trận" },
				{ 295, "Thông Thiên Tháp Địa Cung" },
				{ 296, "Thông Thiên Tháp Tầng 1" },
				{ 297, "Thông Thiên Tháp Tầng 2" },
				{ 298, "Thông Thiên Tháp Tầng 3" },
				{ 299, "Đỉnh Thông Thiên Tháp" },
				{ 300, "Thiên Long Huyễn Cảnh" },
				{ 301, "Phòng dự bị chiến đấu" },
				{ 302, "Chiến Trường Tranh Bá Toàn Cầu" },
				{ 303, "Chung kết-Sân 1" },
				{ 304, "Chung kết-Sân 2" },
				{ 305, "Chung kết-Sân 3" },
				{ 306, "Chung kết-Sân 4" },
				{ 501, "Tái Ngoại 1" },
				{ 502, "Tái Ngoại 2" },
				{ 503, "Tái Ngoại 3" },
				{ 504, "Tái Ngoại 4" },
				{ 505, "Tái Ngoại 5" },
				{ 506, "Lĩnh Nam 1" },
				{ 507, "Lĩnh Nam 2" },
				{ 508, "Lĩnh Nam 3" },
				{ 509, "Lĩnh Nam 4" },
				{ 510, "Lĩnh Nam 5" },
				{ 511, "Hàng Châu 1" },
				{ 512, "Hàng Châu 2" },
				{ 513, "Hàng Châu 3" },
				{ 514, "Hàng Châu 4" },
				{ 515, "Hàng Châu 5" },
				{ 516, "Hải Khẩu 1" },
				{ 517, "Hải Khẩu 2" },
				{ 518, "Hải Khẩu 3" },
				{ 519, "Hải Khẩu 4" },
				{ 520, "Hải Khẩu 5" },
				{ 521, "Điền Vực 1" },
				{ 522, "Điền Vực 2" },
				{ 523, "Điền Vực 3" },
				{ 524, "Điền Vực 4" },
				{ 525, "Điền Vực 5" },
				{ 526, "Thạch Thành 1" },
				{ 527, "Thạch Thành 2" },
				{ 528, "Thạch Thành 3" },
				{ 529, "Thạch Thành 4" },
				{ 530, "Thạch Thành 5" },
				{ 531, "Miêu Vực 1" },
				{ 532, "Miêu Vực 2" },
				{ 533, "Miêu Vực 3" },
				{ 534, "Miêu Vực 4" },
				{ 535, "Miêu Vực 5" },
				{ 536, "Liêu Địa 1" },
				{ 537, "Liêu Địa 2" },
				{ 538, "Liêu Địa 3" },
				{ 539, "Liêu Địa 4" },
				{ 540, "Liêu Địa 5" },
				{ 541, "Nhạn Môn 1" },
				{ 542, "Nhạn Môn 2" },
				{ 543, "Nhạn Môn 3" },
				{ 544, "Nhạn Môn 4" },
				{ 545, "Nhạn Môn 5" },
				{ 546, "Lôi Đài Sinh Tử" },
				{ 547, "Con Giáp Lôi Đài" },
				{ 548, "Chiến Trường Tống Liêu" },
				{ 549, "Phòng thông tin Chiến Trường Tống Liêu" },
				{ 550, "Trân Long Kỳ Cuộc" },
				{ 551, "Tặc Khấu doanh địa" },
				{ 552, "Thiếu Lâm Tự" },
				{ 553, "Cái Bang Tổng Đà " },
				{ 554, "Quang Minh Điện" },
				{ 555, "Võ Đang Sơn" },
				{ 556, "Thiên Long Tự " },
				{ 557, "Lăng Ba Động " },
				{ 558, "Nga Mi Sơn" },
				{ 559, "Tinh Túc Hải " },
				{ 560, "Thiên Sơn" },
				{ 561, "Mộ Dung Sơn Trang" },
				{ 565, "Thiếu Thất Sơn (câu chuyện)" },
				{ 566, "Thiếu Thất Sơn" },
				{ 567, "Cuộc chiến Tranh Bá liên máy chủ" },
				{ 568, "Chung kết-Sân 1" },
				{ 569, "Lâm Hải Khê Cốc" },
				{ 570, "Quân Thiên Vương Lăng" },
				{ 571, "La Phù Vương Lăng" },
				{ 572, "Triều Kinh Vương Lăng" },
				{ 573, "Mạc Nam Thanh Nguyên" },
				{ 574, "Vong Xuyên Hoa Hải" },
				{ 575, "Thiên Kỳ Nam Hoài" },
				{ 576, "Tàng Kinh Các" },
				{ 577, "Giám ngục" },
				{ 578, "Địa phủ" },
				{ 579, "Tân Lạc Dương" },
				{ 850, "Phụng Minh Trấn" },
				{ 581, "Quân Thiên Thành" },
				{ 582, "La Phù Thành" },
				{ 583, "Triều Kinh Thành" },
				{ 584, "Thiếu Lâm Thí Luyện" },
				{ 585, "Cái Bang Thí Luyện" },
				{ 586, "Minh Giáo Thí Luyện" },
				{ 587, "Võ Đang Thí Luyện" },
				{ 588, "Thiên Long Thí Luyện" },
				{ 589, "Tiêu Dao Thí Luyện" },
				{ 590, "Nga Mi Thí Luyện" },
				{ 591, "Tinh Túc Thí Luyện" },
				{ 592, "Thiên Sơn Thí Luyện" },
				{ 593, "Mộ Dung Thí Luyện" },
				{ 594, "Chung kết-Sân 2" },
				{ 595, "Chung kết-Sân 3" },
				{ 596, "Chung kết-Sân 4" },
				{ 597, "Đại Địa Đồ KVK" },
				{ 598, "Thiên Hoàng Địa Cung" },
				{ 599, "Lôi đài" },
				{ 600, "Phụng Minh Vương Lăng" },
				{ 601, "Quang Minh động" },
				{ 602, "Đáy cốc Tiêu Dao" },
				{ 603, "Linh Tính Phong" },
				{ 604, "Cái Bang Tửu Diếu" },
				{ 605, "Đào Hoa Trận" },
				{ 606, "Tháp Lâm" },
				{ 607, "Ngũ Thần Động" },
				{ 608, "Chiết Mai Phong" },
				{ 609, "Chân tháp" },
				{ 610, "Tàng Thư Thủy Các" },
				{ 611, "Huyền Hải" },
				{ 612, "Đại Côn Di Hài" },
				{ 613, "Thủy Nguyệt Động Thiên" },
				{ 614, "Hư Không Huyễn Cảnh" },
				{ 615, "Đường Gia Bảo" },
				{ 616, "Đường Gia Bảo" },
				{ 617, "Diễn Võ Trường" },
				{ 618, "Đường Gia Bảo" },
				{ 619, "Đường Môn Thí Luyện" },
				{ 620, "Thiên Hạ Đệ Nhất Lôi Đài" },
				{ 621, "Phòng chuẩn bị chiến đấu Tông Sư" },
				{ 622, "Phòng chuẩn bị chiến đấu Danh Sĩ" },
				{ 623, "Phòng chuẩn bị chiến đấu Hào Hiệp" },
				{ 624, "Trong Nhạn Môn Quan" },
				{ 625, "Thiếu Lâm (Thâu Đêm)" },
				{ 626, "Diễn Võ Trường" },
				{ 627, "Diễn Võ Trường" },
				{ 628, "Đường Gia Bảo" },
				{ 629, "Vấn Đỉnh Thiên Hạ" },
				{ 630, "Mật Chiến Thất" },
				{ 631, "Hi Hoàng Thần Vực" },
				{ 632, "Oa Hoàng Thần Vực" },
				{ 633, "Nông Hoàng Thần Vực" },
				{ 634, "Sào Hoàng Thần Vực" },
				{ 635, "Nhân Hoàng Thần Vực" },
				{ 636, "Dung Hoàng Thần Vực" },
				{ 637, "Công Hoàng Thần Vực" },
				{ 638, "Thái Hoàng Thần Vực" },
				{ 639, "Quân Thiên Thành (Đêm)" },
				{ 640, "Thần Binh Các (Cấp 1)" },
				{ 641, "Thần Binh Đường (Cấp 2)" },
				{ 642, "Thần Binh Đàn (Cấp 3)" },
				{ 643, "Thần Binh Lâu (Cấp 4)" },
				{ 644, "Thần Binh Điện (Cấp 5)" },
				{ 645, "Huyết Chiến Nhạn Môn Quan" },
				{ 646, "Hàn Băng Hải Vực" },
				{ 647, "Diệt Thế Hỏa Quật" },
				{ 648, "Cổ Hoặc Linh Cốc" },
				{ 649, "Phòng dự bị chiến đấu " },
				{ 650, "Vô Nhai Cảnh" },
				{ 651, "Viêm Ma Sơn" },
				{ 652, "Tam Tài Hiệp Cốc (Đơn)" },
				{ 653, "Tam Tài Hiệp Cốc" },
				{ 654, "Quần Hùng Lôi" },
				{ 655, "Quần Hùng Lôi" },
				{ 656, "Quần Hùng Lôi" },
				{ 657, "Quần Hùng Lôi" },
				{ 658, "Tụ Nghĩa Tinh Đàn" },
				{ 659, "Đạo Trường Sư Môn" },
				{ 660, "Đào Viên Cảnh" },
				{ 661, "Giải Đấu Ngôi Sao" },
				{ 662, "Tam Thần Huyễn Cảnh" },
				{ 663, "Thiên Thu Điện" },
				{ 664, "Bất Quy Lâm" },
				{ 665, "Vô Nhai Hải" },
				{ 666, "Viêm La Thiên" },
				{ 667, "Ngọc Hoàng Sơn" },
				{ 668, "Điện Tiền Quảng Trường" },
				{ 669, "Tẩm Thủy Đan Lâm" },
				{ 670, "Vân Dao Thước Lĩnh" },
				{ 671, "Côn Ngô-Mạc Nam Thanh Nguyên" },
				{ 672, "Côn Ngô-Vong Xuyên Hoa Hải" },
				{ 673, "Côn Ngô-Thiên Kỳ Nam Hoài" }
			};
		}
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x0600242B RID: 9259 RVA: 0x00115FF4 File Offset: 0x001141F4
	public static List<string> List_11
	{
		get
		{
			return new List<string>(9) { "Cửu Tiêu Lý", "Toái Phách Ngoa", "Cửu Tiêu Hộ Thủ", "Toái Phách Chưởng", "Cửu Tiêu Cầu", "Toái Phách Khải", "Toái Phách Khôi", "Cửu Tiêu Mão", "Thôi Tuyết" };
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x0600242C RID: 9260 RVA: 0x0011606C File Offset: 0x0011426C
	public static List<string> List_12
	{
		get
		{
			return new List<string>(7) { "Mão", "Y Phục", "Hộ Thủ", "Hài", "Yêu Đai", "Hộ Kiên", "Hộ Uyển" };
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x0600242D RID: 9261 RVA: 0x001160CC File Offset: 0x001142CC
	public static List<string> List_13
	{
		get
		{
			return new List<string>(10) { "Mão", "Y Phục", "Hộ Thủ", "Hài", "Yêu Đai", "Hộ Kiên", "Hộ Uyển", "Hộ Phù", "Giới Chỉ", "Hạng Liên" };
		}
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x0600242E RID: 9262 RVA: 0x00116150 File Offset: 0x00114350
	public static List<string> List_14
	{
		get
		{
			return new List<string>(18)
			{
				"Cửu Tiêu Lý", "Toái Phách Ngoa", "Ưng Dương", "Phượng Vũ", "Túc Giao", "Bách Xuyên", "Cửu Tiêu Hộ Thủ", "Toái Phách Chưởng", "Cửu Tiêu Cầu", "Toái Phách Khải",
				"Thôi Tuyết", "Túy Vũ", "Sương Hiểu", "Xuyên Mộ", "Yêu Ngôn", "Liệt Nhật", "Toái Phách Khôi", "Cửu Tiêu Mão"
			};
		}
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x0600242F RID: 9263 RVA: 0x0011622C File Offset: 0x0011442C
	public static List<string> List_15
	{
		get
		{
			return new List<string>(8) { "Dung Kim Lạc Nhật Đồ", "Thu Thủy Vô Ngấn Đồ", "Bích Hải Ngân Đào Đồ", "Vạn Hách Tùng Phong Đồ", "Bích Hải Lăng Ba Đồ Tường", "Tử Dương Tuyệt Linh Đồ Tường", "Bách Đại Hồng Quang Đồ Tường", "Dục Hỏa Xuất Trần Đồ Tường" };
		}
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06002430 RID: 9264 RVA: 0x00116298 File Offset: 0x00114498
	public static HashSet<string> HashSet_9
	{
		get
		{
			return new HashSet<string>
			{
				"Thú Cưỡi: Viêm Ô", "Thú Cưỡi: Linh Hồ", "Thú Cưỡi: Kim Tiền Báo", "Thú Cưỡi: Linh Dương", "Thú Cưỡi: Mao Ngưu", "Thú Cưỡi: Lộc", "Thú Cưỡi: Hổ", "Thú Cưỡi: Điêu", "Thú Cưỡi: Hoàng Phiêu Mã", "Thú Cưỡi: Thanh Phụng",
				"Thú Cưỡi: Hạc", "Thú Cưỡi: Sư Tử", "Thú Cưỡi: Khôi Lang", "Thú Cưỡi: Mộc Diên"
			};
		}
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06002431 RID: 9265 RVA: 0x00116354 File Offset: 0x00114554
	public static HashSet<string> HashSet_10
	{
		get
		{
			return new HashSet<string>
			{
				"Thú Cưỡi: Dung Phong Ô", "Thú Cưỡi: Xích Vĩ Hồ", "Thú Cưỡi: Vân Tuyết Báo", "Thú Cưỡi: Tuyết Linh Dương", "Thú Cưỡi: Bạch Mao Ngưu", "Thú Cưỡi: Bạch Lộc", "Thú Cưỡi: Bạch Hổ", "Thú Cưỡi: Bạch Điêu", "Thú Cưỡi: Thanh Bạch Tông Mã", "Thú Cưỡi: Hồng Bạch Phụng",
				"Thú Cưỡi: Kim Dực Hạc", "Thú Cưỡi: Bạch Sư", "Thú Cưỡi: Bạch Lang", "Thú Cưỡi: Tinh Phong Diên"
			};
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06002432 RID: 9266 RVA: 0x00116410 File Offset: 0x00114610
	public static HashSet<string> HashSet_11
	{
		get
		{
			return new HashSet<string>
			{
				"Phi Ưng", "Quỷ Ảnh", "Phạn Tu", "Phạn Thể", "Cùng Kỳ-Huyễn", "Thị Ma Giả", "Băng Mặc Hổ", "Huyền Mặc Hổ", "Hỏa Mặc Hổ", "Độc Mặc Hổ",
				"Tinh La Võ Sĩ", "Thanh Ưng", "Tín đồ", "Băng Tằm", "Huyết chú vu cổ", "Phiên tăng chấp sự", "Thổ phồn ác tăng đầu lĩnh", "Hắc Sắc Tâm Ma", "Nhiếp Hồn", "Hoa Độc",
				"Tâm Ma", "Vô Tướng Tung Ảnh", "Đạo Thư Ác Tăng", "Đào Thoán Phỉ Loại"
			};
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x06002433 RID: 9267 RVA: 0x00116544 File Offset: 0x00114744
	public static List<string> List_16
	{
		get
		{
			return new List<string>(6) { "62,118", "64,112", "64,123", "72,112", "72,123", "74,118" };
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x06002434 RID: 9268 RVA: 0x0011659C File Offset: 0x0011479C
	public static List<string> List_17
	{
		get
		{
			return new List<string>(6) { "118,40", "124,40", "126,45", "124,50", "118,50", "116,45" };
		}
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06002435 RID: 9269 RVA: 0x000187E6 File Offset: 0x000169E6
	public static List<string> List_18
	{
		get
		{
			return new List<string>(5) { "132,162", "142,152", "122,152", "132,142", "132,152" };
		}
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06002436 RID: 9270 RVA: 0x00018825 File Offset: 0x00016A25
	public static List<string> List_19
	{
		get
		{
			return new List<string>(5) { "52,122", "62,112", "52,102", "42,112", "52,112" };
		}
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x06002437 RID: 9271 RVA: 0x00018864 File Offset: 0x00016A64
	public static List<string> List_20
	{
		get
		{
			return new List<string>(5) { "126,74", "136,64", "126,54", "116,64", "126,64" };
		}
	}

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x06002438 RID: 9272 RVA: 0x001165F4 File Offset: 0x001147F4
	public static Dictionary<string, string> Dictionary_9
	{
		get
		{
			return new Dictionary<string, string>
			{
				{ "PetFood_12", "Trân Thú Hồi Thần Đan" },
				{ "PetFood_11", "Trân Thú Vạn Bổ Đan" },
				{ "PetFood_16", "Trân Thú Hồi Xuân Đan" },
				{ "PetFood_15", "Trân Thú Tư Bổ Đan" },
				{ "PetBauble_4", "Bóng Nhiều Màu" },
				{ "CircularTaskTool137_5", "Siêu Cấp Trân Thú Tư Bổ Đan" },
				{ "CircularTaskTool137_6", "Trân Thú Hồi Xuân Đan-Siêu" },
				{ "Treasure3_15", "Tiên Trúc Tư Bổ Đan" }
			};
		}
	}

	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x06002439 RID: 9273 RVA: 0x00116688 File Offset: 0x00114888
	public static Dictionary<string, string> Dictionary_10
	{
		get
		{
			return new Dictionary<string, string>
			{
				{ "PetFood_12", "Trân Thú Hồi Thần Đan" },
				{ "PetFood_11", "Trân Thú Vạn Bổ Đan" },
				{ "PetFood_16", "Trân Thú Hồi Xuân Đan" },
				{ "PetFood_15", "Trân Thú Tư Bổ Đan" },
				{ "CircularTaskTool137_5", "Siêu Cấp Trân Thú Tư Bổ Đan" },
				{ "CircularTaskTool137_6", "Trân Thú Hồi Xuân Đan-Siêu" },
				{ "Treasure3_15", "Tiên Trúc Tư Bổ Đan" }
			};
		}
	}

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x0600243A RID: 9274 RVA: 0x0011670C File Offset: 0x0011490C
	public static HashSet<string> HashSet_12
	{
		get
		{
			return new HashSet<string>
			{
				"Bích Lân Cương Thi", "Thực Phẩm Hỏng", "Nguyệt Lý", "Yến Tử Ổ trang đinh", "Công Dã Càn", "Bao Bất Đồng", "Đặng Bách Xuyên", "Nhất Phẩm Đường Võ Sĩ", "Top Hall Samurais", "Swallow's Dock Servant",
				"Attendant Gung", "Attendant Bao", "Attendant Fong"
			};
		}
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x0600243B RID: 9275 RVA: 0x001167BC File Offset: 0x001149BC
	public static Dictionary<int, string> Dictionary_11
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 38007000, "Hỗn Thiên Phác Thạch" },
				{ 38007001, "Tôi Ngọc Lộ-Sơ" },
				{ 38007002, "Tôi Ngọc Lộ-Trung" },
				{ 38007051, "Tinh Hỏa Bậc 1" },
				{ 38007005, "Trác Ngọc Nhẫn-Sơ" },
				{ 38007006, "Trác Ngọc Nhẫn-Trung" },
				{ 38007052, "Tinh Hỏa Bậc 2" },
				{ 38007053, "Tinh Hỏa Bậc 3" },
				{ 38007004, "Thần Sa" }
			};
		}
	}

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x0600243C RID: 9276 RVA: 0x00116860 File Offset: 0x00114A60
	public static Dictionary<int, string> Dictionary_12
	{
		get
		{
			return new Dictionary<int, string>
			{
				{ 38007026, "Thiên Hựu Tinh Thạch Toái Phiến-Tinh" },
				{ 38007027, "Linh Đài Tinh Thạch Toái Phiến-Tinh" },
				{ 38007028, "Tuế Ninh Tinh Thạch Toái Phiến-Tinh" },
				{ 38007029, "Thiên Cơ Tinh Thạch Toái Phiến-Tinh" },
				{ 38007030, "Võ Khúc Tinh Thạch Toái Phiến-Tinh" },
				{ 38007031, "Thái Âm Tinh Thạch Toái Phiến-Tinh" },
				{ 38007032, "Thái Dương Tinh Thạch Toái Phiến-Tinh" },
				{ 38007033, "Huyền Minh Tinh Thạch Toái Phiến-Tinh" },
				{ 38007034, "Ngự Độc Tinh Thạch Toái Phiến-Tinh" }
			};
		}
	}

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x0600243D RID: 9277 RVA: 0x00116904 File Offset: 0x00114B04
	public static List<string> List_21
	{
		get
		{
			return new List<string>(6) { "43,54", "53,54", "56,48", "53,42", "43,42", "40,48" };
		}
	}

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x0600243E RID: 9278 RVA: 0x0011695C File Offset: 0x00114B5C
	public static List<string> List_22
	{
		get
		{
			return new List<string>(6) { "36,29", "36,37", "30,39", "23,37", "23,29", "30,27" };
		}
	}

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x0600243F RID: 9279 RVA: 0x001169B4 File Offset: 0x00114BB4
	public static List<string> List_23
	{
		get
		{
			return new List<string>(6) { "25,95", "32,95", "34,100", "32,106", "25,106", "22,100" };
		}
	}

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06002440 RID: 9280 RVA: 0x00116A0C File Offset: 0x00114C0C
	public static List<string> List_24
	{
		get
		{
			return new List<string>(6) { "25,29", "27,25", "33,25", "35,29", "33,33", "28,33" };
		}
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x00116A64 File Offset: 0x00114C64
	// Note: this type is marked as 'beforefieldinit'.
	static Class501()
	{
		string[,] array = new string[68, 2];
		array[0, 0] = "38004320";
		array[0, 1] = "Đương Lư Tàn Ấn";
		array[1, 0] = "38004321";
		array[1, 1] = "Yến Nhiên Tàn Ấn";
		array[2, 0] = "38004322";
		array[2, 1] = "Vọng Dương Tàn Ấn";
		array[3, 0] = "38004323";
		array[3, 1] = "Xuyên Thượng Tàn Ấn";
		array[4, 0] = "38004324";
		array[4, 1] = "Khắc Mộc Tàn Ấn";
		array[5, 0] = "38004325";
		array[5, 1] = "Tiệp Đối Tàn Ấn";
		array[6, 0] = "38004326";
		array[6, 1] = "Hôn Vũ Tàn Ấn";
		array[7, 0] = "38004327";
		array[7, 1] = "Thất Bộ Tàn Ấn";
		array[8, 0] = "38004328";
		array[8, 1] = "Trịch Thủy Tàn Ấn";
		array[9, 0] = "38004329";
		array[9, 1] = "Cô Xạ Tàn Ấn";
		array[10, 0] = "38004330";
		array[10, 1] = "Đoạn Cơ Tàn Ấn";
		array[11, 0] = "38004331";
		array[11, 1] = "Vịnh Tự Tàn Ấn";
		array[12, 0] = "38004332";
		array[12, 1] = "Phiếm Hồ Tàn Ấn";
		array[13, 0] = "38004333";
		array[13, 1] = "Dũng Tuyền Tàn Ấn";
		array[14, 0] = "38004334";
		array[14, 1] = "Bác Vọng Tàn Ấn";
		array[15, 0] = "38004335";
		array[15, 1] = "Bái Mộ Tàn Ấn";
		array[16, 0] = "38004336";
		array[16, 1] = "Phi Thứ Tàn Ấn";
		array[17, 0] = "38004337";
		array[17, 1] = "Phụ Đỉnh Tàn Ấn";
		array[18, 0] = "38004338";
		array[18, 1] = "Độ Giang Tàn Ấn";
		array[19, 0] = "38004339";
		array[19, 1] = "Trì Tiết Tàn Ấn";
		array[20, 0] = "38004340";
		array[20, 1] = "Tam Vị Tàn Ấn";
		array[21, 0] = "38004341";
		array[21, 1] = "Khấp Kỳ Tàn Ấn";
		array[22, 0] = "38004342";
		array[22, 1] = "Thổ Tiết Tàn Ấn";
		array[23, 0] = "38004343";
		array[23, 1] = "Doãn Kinh Tàn Ấn";
		array[24, 0] = "38004344";
		array[24, 1] = "Nhượng Lê Tàn Ấn";
		array[25, 0] = "38004345";
		array[25, 1] = "Biện Nhật Tàn Ấn";
		array[26, 0] = "38004346";
		array[26, 1] = "Vân Thê Tàn Ấn";
		array[27, 0] = "38004347";
		array[27, 1] = "Hoàng Tước Tàn Ấn";
		array[28, 0] = "38004348";
		array[28, 1] = "Thể Khinh Tàn Ấn";
		array[29, 0] = "38004349";
		array[29, 1] = "Chỉ Đề Tàn Ấn";
		array[30, 0] = "38004350";
		array[30, 1] = "Bi Phiến Tàn Ấn";
		array[31, 0] = "38004351";
		array[31, 1] = "Thanh Sam Tàn Ấn";
		array[32, 0] = "38004352";
		array[32, 1] = "Chiết Cân Tàn Ấn";
		array[33, 0] = "38004353";
		array[33, 1] = "Lạc Mão Tàn Ấn";
		array[34, 0] = "38004292";
		array[34, 1] = "Khiển Mỹ-Băng Tàn Ấn";
		array[35, 0] = "38004293";
		array[35, 1] = "Khiển Mỹ-Hỏa Tàn Ấn";
		array[36, 0] = "38004294";
		array[36, 1] = "Khiển Mỹ-Huyền Tàn Ấn";
		array[37, 0] = "38004295";
		array[37, 1] = "Khiển Mỹ-Độc Tàn Ấn";
		array[38, 0] = "38004296";
		array[38, 1] = "Cao Môn-Băng Tàn Ấn";
		array[39, 0] = "38004297";
		array[39, 1] = "Cao Môn-Hỏa Tàn Ấn";
		array[40, 0] = "38004298";
		array[40, 1] = "Cao Môn-Huyền Tàn Ấn";
		array[41, 0] = "38004299";
		array[41, 1] = "Cao Môn-Độc Tàn Ấn";
		array[42, 0] = "38004300";
		array[42, 1] = "Đầu Vu-Băng Tàn Ấn";
		array[43, 0] = "38004301";
		array[43, 1] = "Đầu Vu-Hỏa Tàn Ấn";
		array[44, 0] = "38004302";
		array[44, 1] = "Đầu Vu-Huyền Tàn Ấn";
		array[45, 0] = "38004303";
		array[45, 1] = "Đầu Vu-Độc Tàn Ấn";
		array[46, 0] = "38004304";
		array[46, 1] = "Bổng Tâm-Băng Tàn Ấn";
		array[47, 0] = "38004305";
		array[47, 1] = "Bổng Tâm-Hỏa Tàn Ấn";
		array[48, 0] = "38004306";
		array[48, 1] = "Bổng Tâm-Huyền Tàn Ấn";
		array[49, 0] = "38004307";
		array[49, 1] = "Bổng Tâm-Độc Tàn Ấn";
		array[50, 0] = "38004308";
		array[50, 1] = "Thệ Giang-Băng Tàn Ấn";
		array[51, 0] = "38004309";
		array[51, 1] = "Thệ Giang-Hỏa Tàn Ấn";
		array[52, 0] = "38004310";
		array[52, 1] = "Thệ Giang-Huyền Tàn Ấn";
		array[53, 0] = "38004311";
		array[53, 1] = "Thệ Giang-Độc Tàn Ấn";
		array[54, 0] = "38004312";
		array[54, 1] = "Hoàn Châu-Băng Tàn Ấn";
		array[55, 0] = "38004313";
		array[55, 1] = "Hoàn Châu-Hỏa Tàn Ấn";
		array[56, 0] = "38004314";
		array[56, 1] = "Hoàn Châu-Huyền Tàn Ấn";
		array[57, 0] = "38004315";
		array[57, 1] = "Hoàn Châu-Độc Tàn Ấn";
		array[58, 0] = "38004316";
		array[58, 1] = "Hô Miếu Tàn Ấn";
		array[59, 0] = "38004317";
		array[59, 1] = "Khấp Ngọc Tàn Ấn";
		array[60, 0] = "38004318";
		array[60, 1] = "Thính Kính Tàn Ấn";
		array[61, 0] = "38004319";
		array[61, 1] = "Tọa Khiếu Tàn Ấn";
		array[62, 0] = "38004286";
		array[62, 1] = "Cân Quốc-Băng Tàn Ấn";
		array[63, 0] = "38004287";
		array[63, 1] = "Cân Quốc-Hỏa Tàn Ấn";
		array[64, 0] = "38004288";
		array[64, 1] = "Cân Quốc-Huyền Tàn Ấn";
		array[65, 0] = "38004289";
		array[65, 1] = "Cân Quốc-Độc Tàn Ấn";
		array[66, 0] = "38004290";
		array[66, 1] = "Thương Hồn Tàn Ấn";
		array[67, 0] = "38004291";
		array[67, 1] = "Cát Tường Tàn Ấn";
		Class501.string_0 = array;
		Class501.dictionary_1 = new Dictionary<int, string>
		{
			{ 10141153, "Thú Cưỡi: Lưu Ly Phụng" },
			{ 10141157, "Thú Cưỡi: Ngân Nguyệt Lang" },
			{ 10141161, "Thú Cưỡi: Liệt Diệm Sư" },
			{ 10141165, "Thú Cưỡi: Như Ý Hổ" },
			{ 10141169, "Thú Cưỡi: Long Huyết Mã" },
			{ 10141173, "Thú Cưỡi: Vụ Ảnh Điêu" },
			{ 10141177, "Thú Cưỡi: Thuỵ Liên Hạc" },
			{ 10141181, "Thú Cưỡi: Thất Thái Lộc" },
			{ 10141222, "Thú Cưỡi: U Quang Linh" },
			{ 10141185, "Thú Cưỡi: Thanh Mao Ngưu" },
			{ 10141495, "Thú Cưỡi: U Linh Báo" }
		};
		Class501.List_1 = new List<string>(7) { "0813673640", "beng_1@gmail.com", "sonvu171@gmail.com", "tranviet92@gmail.com", "dangvanvu1@gmail.com", "tieudattai@yahoo.com", "cp1" };
	}

	// Token: 0x040018DB RID: 6363
	public static HashSet<string> hashSet_0 = new HashSet<string> { "sonvu171@gmail.com", "beng_1@gmail.com" };

	// Token: 0x040018DC RID: 6364
	public static HashSet<int> hashSet_1 = new HashSet<int>
	{
		20310108, 20310109, 30001001, 30001002, 30001003, 30001004, 30001005, 30001006, 30001007, 30001008,
		30001009, 30001010, 30001011, 30001012, 30001013, 30001014, 30001015, 30001016, 30001017, 30001018,
		30001019, 30001020, 30001021, 30001022, 30001023, 30001024, 30001025, 30001026, 30001027, 30001028,
		30001029, 30001030, 30002001, 30002002, 30002003, 30002004, 30002005, 30002006, 30002007, 30002008,
		30002009, 30002010, 30002011, 30002012, 30002013, 30002014, 30002015, 30002016, 30002017, 30002018,
		30002019, 30002020, 30002021, 30002022, 30002023, 30002024, 30002025, 30002026, 30002027, 30002028,
		30101001, 30101002, 30101003, 30101004, 30101005, 30101006, 30101007, 30101008, 30101009, 30101010,
		30101011, 30101012, 30101013, 30101014, 30101015, 30101016, 30101017, 30101018, 30101019, 30101020,
		30101021, 30101022, 30101023, 30101024, 30101031, 30101032, 30101033, 30101034, 30101035, 30101036,
		30101037, 30101038, 30101039, 30101040, 30101041, 30101042, 30101043, 30101044, 30101045, 30101046,
		30101047, 30101048, 30101049, 30101050, 30101051, 30101052, 30101053, 30101054, 30101055, 30101056,
		30101057, 30101058, 30101059, 30101060, 30101061, 30101062, 30101063, 30101064, 30101065, 30101066,
		30101067, 30101068, 30101069, 30101070, 30101071, 30101072, 30101073, 30101074, 30101075, 30101076,
		30101077, 30101078, 30101079, 30101080, 30101081, 30101082, 30101083, 30101084, 30101085, 30101086,
		30101087, 30101088, 30101089, 30101090, 30101091, 30101092, 30101093, 30101094, 30101095, 30101096,
		30101097, 30101098, 30101099, 30101100, 30101101, 30101102, 30101103, 30101104, 30101105, 30101106,
		30101107, 30101108, 30101109, 30101110, 30101111, 30101112, 30101113, 30101114, 30101115, 30101116,
		30101117, 30101118, 30101119, 30101120, 30101121, 30101122, 30101123, 30101124, 30101125, 30101126,
		30101127, 30101128, 30101129, 30101130, 30101131, 30101132, 30101133, 30101134, 30101135, 30101136,
		30101137, 30101138, 30101139, 30101140, 30101141, 30101142, 30101143, 30101144, 30101145, 30101146,
		30101147, 30101148, 30101149, 30101150, 30101151, 30101152, 30101153, 30101154, 30101155, 30101156,
		30101157, 30101158, 30101159, 30101160, 30101161, 30101162, 30101163, 30101164, 30101165, 30101166,
		30101167, 30101168, 30101169, 30101170, 30101171, 30101172, 30101173, 30101174, 20108001, 20108002,
		20108003, 20108004, 20108005, 20108006, 20108007, 20108008, 20108009, 20108010, 20108011, 20108012,
		20108013, 20108014, 20108015, 20108016, 20108017, 20108018, 20108019, 20108020, 20108021, 20108022,
		20108023, 20108024, 20108025, 20108026, 20108027, 20108028, 20108029, 20108030, 20108031, 20108032,
		20108033, 20108034, 20108035, 20108036, 20108037, 20108038, 20108039, 20108040, 20108041, 20108042,
		20108043, 20108044, 20108045, 20108046, 20108047, 20108048, 20108049, 20108050, 20108051, 20108052,
		20108053, 20108054, 20108055, 20108056, 20108057, 20108058, 20108059, 20108060, 20108061, 20108062,
		20108063, 20108064, 20108065, 20108066, 20108067, 20108068, 20108069, 20108070, 20108071, 20108072,
		20108073, 20108074, 20108075, 20108076, 20108077, 20108078, 20108079, 20108080, 20108081, 20108082,
		20108083, 20108084, 20108085, 20108086, 20108087, 20108088, 20108089, 20108090, 20108091, 20108092,
		20108093, 20108094, 20108095, 20108096, 20108097, 20108098, 20108099, 20108100, 20108101, 20108102,
		20108103, 20108104, 20108105, 20108106, 20108107, 20108108, 20108109, 20108110, 20108111, 20108112,
		20108113, 20108114, 20108115, 20108116, 20108117, 20108118, 20108119, 20108120, 20108121, 20108122,
		20108123, 20108124, 20108125, 20108126, 20108127, 20108128, 20108129, 20108130, 20108131, 20108132,
		20108133, 20108134, 20108135, 20108136, 20108137, 20108138, 20108139, 20108140, 20108141, 20108142,
		20108143, 20108144, 20108145, 20108146, 20108147, 20108148, 20108149, 20108150, 20108151, 20108152,
		20108153, 20108154, 20108155, 20108156, 20108157, 20108158, 20108159, 20108160, 20108161, 20108162,
		20108163, 20108164, 20108165, 20108166, 20108167, 20108168, 20108169, 20108170, 20108171, 20108172,
		20108173, 20108174, 20108175, 20108176, 20108177, 20108178, 20108179, 20108180, 20106001, 20106002,
		20106003, 20106004, 20106005, 20106006, 20106007, 20106008, 20106009, 20106010, 20106011, 20106012,
		20107001, 20107002, 20107003, 20107004, 20107005, 20107006, 20107007, 20107008, 20107009, 20107010,
		20107011, 20107012, 20107013, 20107014, 20107015, 20107016, 20107017, 20107018, 20107019, 30003001,
		30003002, 30003003, 30003004, 30003005, 30003006, 30003007, 30003008, 30003009, 30003010, 30003011,
		30003012, 30003013, 30003014, 30003015, 30003016, 30003017, 30003018, 30003019, 30003020, 30003021,
		30003022, 30003023, 30003024, 30003025, 30003026, 30003027, 30003028, 30003029, 30003030, 30003031,
		30003032, 30003033, 30003034, 30003035, 30003036, 30003037, 30003038, 30003039
	};

	// Token: 0x040018DD RID: 6365
	public static readonly Dictionary<int, int> dictionary_0 = new Dictionary<int, int>
	{
		{ 20308001, 0 },
		{ 20308002, 0 },
		{ 20308003, 0 },
		{ 20308004, 0 },
		{ 20308005, 0 },
		{ 20308006, 0 },
		{ 20308007, 0 },
		{ 20308008, 0 },
		{ 20308009, 0 },
		{ 20308010, 0 },
		{ 20308011, 1 },
		{ 20308012, 1 },
		{ 20308013, 1 },
		{ 20308014, 1 },
		{ 20308015, 1 },
		{ 20308016, 1 },
		{ 20308017, 1 },
		{ 20308018, 1 },
		{ 20308019, 1 },
		{ 20308020, 1 },
		{ 20308021, 2 },
		{ 20308022, 2 },
		{ 20308023, 2 },
		{ 20308024, 2 },
		{ 20308025, 2 },
		{ 20308026, 2 },
		{ 20308027, 2 },
		{ 20308028, 2 },
		{ 20308029, 2 },
		{ 20308030, 2 },
		{ 20308031, 3 },
		{ 20308032, 3 },
		{ 20308033, 3 },
		{ 20308034, 3 },
		{ 20308035, 3 },
		{ 20308036, 3 },
		{ 20308037, 3 },
		{ 20308038, 3 },
		{ 20308039, 3 },
		{ 20308040, 3 },
		{ 20308041, 4 },
		{ 20308042, 4 },
		{ 20308043, 4 },
		{ 20308044, 4 },
		{ 20308045, 4 },
		{ 20308046, 4 },
		{ 20308047, 4 },
		{ 20308048, 4 },
		{ 20308049, 4 },
		{ 20308050, 4 },
		{ 20308051, 5 },
		{ 20308052, 5 },
		{ 20308053, 5 },
		{ 20308054, 5 },
		{ 20308055, 5 },
		{ 20308056, 5 },
		{ 20308057, 5 },
		{ 20308058, 5 },
		{ 20308059, 5 },
		{ 20308060, 5 },
		{ 20308061, 6 },
		{ 20308062, 6 },
		{ 20308063, 6 },
		{ 20308064, 6 },
		{ 20308065, 6 },
		{ 20308066, 6 },
		{ 20308067, 6 },
		{ 20308068, 6 },
		{ 20308069, 6 },
		{ 20308070, 6 },
		{ 20308071, 7 },
		{ 20308072, 7 },
		{ 20308073, 7 },
		{ 20308074, 7 },
		{ 20308075, 7 },
		{ 20308076, 7 },
		{ 20308077, 7 },
		{ 20308078, 7 },
		{ 20308079, 7 },
		{ 20308080, 7 },
		{ 20308081, 8 },
		{ 20308082, 8 },
		{ 20308083, 8 },
		{ 20308084, 8 },
		{ 20308085, 8 },
		{ 20308086, 8 },
		{ 20308087, 8 },
		{ 20308088, 8 },
		{ 20308089, 8 },
		{ 20308090, 8 },
		{ 20308091, 9 },
		{ 20308092, 9 },
		{ 20308093, 9 },
		{ 20308094, 9 },
		{ 20308095, 9 },
		{ 20308096, 9 },
		{ 20308097, 9 },
		{ 20308098, 9 },
		{ 20308099, 9 },
		{ 20308100, 9 },
		{ 20308101, 13 },
		{ 20308102, 13 },
		{ 20308103, 13 },
		{ 20308104, 13 },
		{ 20308105, 13 },
		{ 20308106, 13 },
		{ 20308107, 13 },
		{ 20308108, 13 },
		{ 20308109, 13 },
		{ 20308110, 13 },
		{ 20308111, 14 },
		{ 20308112, 14 },
		{ 20308113, 14 },
		{ 20308114, 14 },
		{ 20308115, 14 },
		{ 20308116, 14 },
		{ 20308117, 14 },
		{ 20308118, 14 },
		{ 20308119, 14 },
		{ 20308120, 14 },
		{ 20308121, 15 },
		{ 20308122, 15 },
		{ 20308123, 15 },
		{ 20308124, 15 },
		{ 20308125, 15 },
		{ 20308126, 15 },
		{ 20308127, 15 },
		{ 20308128, 15 },
		{ 20308129, 15 },
		{ 20308130, 15 },
		{ 20308131, 10 },
		{ 20308132, 10 },
		{ 20308133, 10 },
		{ 20308134, 10 },
		{ 20308135, 10 },
		{ 20308136, 10 },
		{ 20308137, 10 },
		{ 20308138, 10 },
		{ 20308139, 10 },
		{ 20308140, 10 },
		{ 20308141, 11 },
		{ 20308142, 11 },
		{ 20308143, 11 },
		{ 20308144, 11 },
		{ 20308145, 11 },
		{ 20308146, 11 },
		{ 20308147, 11 },
		{ 20308148, 11 },
		{ 20308149, 11 },
		{ 20308150, 11 },
		{ 20308151, 12 },
		{ 20308152, 12 },
		{ 20308153, 12 },
		{ 20308154, 12 },
		{ 20308155, 12 },
		{ 20308156, 12 },
		{ 20308157, 12 },
		{ 20308158, 12 },
		{ 20308159, 12 },
		{ 20308160, 12 }
	};

	// Token: 0x040018DE RID: 6366
	public static string[,] string_0;

	// Token: 0x040018DF RID: 6367
	public static Dictionary<int, string> dictionary_1;

	// Token: 0x040018E0 RID: 6368
	[CompilerGenerated]
	private static List<string> list_0;
}
