using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020002D1 RID: 721
internal class Class504
{
	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x060025A6 RID: 9638 RVA: 0x0011A48C File Offset: 0x0011868C
	public string String_0
	{
		get
		{
			return this.Int64_0.ToString("X8");
		}
	}

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0011A4AC File Offset: 0x001186AC
	public string String_1
	{
		get
		{
			return (this.Int64_1 - this.Class106_0.Int64_0).ToString("X8");
		}
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x0011A4D8 File Offset: 0x001186D8
	public Class504(Class106 class106_1, long long_5)
	{
		this.Class106_0 = class106_1;
		this.Class515_0 = class106_1.Class515_0;
		this.Class502_0 = class106_1.Class502_0;
		if (this.Class502_0.Int32_5 == 1)
		{
			this.Int32_4 = this.Class515_0.method_7(new long[]
			{
				long_5 + 20L,
				24L
			});
		}
		else if (this.Class502_0.Int32_5 == 3)
		{
			this.Int32_4 = this.Class515_0.method_7(new long[]
			{
				long_5 + 20L,
				44L
			});
		}
		else
		{
			this.Int32_4 = this.Class515_0.method_7(new long[] { long_5 + (long)this.Class502_0.Int32_35 });
		}
		this.Int64_0 = long_5;
		this.Int64_5 = long_5;
		this.Int32_6 = class106_1.Class527_0.Int32_35;
	}

	// Token: 0x1700076E RID: 1902
	// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000197DE File Offset: 0x000179DE
	public int Int32_0
	{
		get
		{
			return this.Class515_0.method_10(new long[] { this.Int64_5 + 21L });
		}
	}

	// Token: 0x1700076F RID: 1903
	// (get) Token: 0x060025AA RID: 9642 RVA: 0x00019804 File Offset: 0x00017A04
	// (set) Token: 0x060025AB RID: 9643 RVA: 0x0001980C File Offset: 0x00017A0C
	public long Int64_0 { get; set; }

	// Token: 0x17000770 RID: 1904
	// (get) Token: 0x060025AC RID: 9644 RVA: 0x00019815 File Offset: 0x00017A15
	// (set) Token: 0x060025AD RID: 9645 RVA: 0x0001981D File Offset: 0x00017A1D
	public int Int32_1 { get; set; }

	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x060025AE RID: 9646 RVA: 0x00019826 File Offset: 0x00017A26
	// (set) Token: 0x060025AF RID: 9647 RVA: 0x0001982E File Offset: 0x00017A2E
	public int Int32_2 { get; set; }

	// Token: 0x17000772 RID: 1906
	// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00019837 File Offset: 0x00017A37
	// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0001983F File Offset: 0x00017A3F
	public string String_2 { get; set; } = "FFFFFFFF";

	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x060025B2 RID: 9650 RVA: 0x0011A60C File Offset: 0x0011880C
	public string String_3
	{
		get
		{
			if (this.Class502_0.Int32_5 == 1)
			{
				this.String_2 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_42 + 4L }).ToString("X8");
			}
			else
			{
				this.String_2 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_42 }).ToString("X8");
			}
			return this.String_2;
		}
	}

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00019848 File Offset: 0x00017A48
	public List<int> List_0
	{
		get
		{
			return this.list_0 ?? new List<int>();
		}
	}

	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00019859 File Offset: 0x00017A59
	public HashSet<long> HashSet_0
	{
		get
		{
			return this.method_0(this.Class515_0.method_9(new long[] { this.Int64_3 + (long)this.Class106_0.Class502_0.Int32_50 }));
		}
	}

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0001988D File Offset: 0x00017A8D
	public List<long> List_1
	{
		get
		{
			return this.HashSet_0.ToList<long>();
		}
	}

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0001989A File Offset: 0x00017A9A
	// (set) Token: 0x060025B7 RID: 9655 RVA: 0x000198A2 File Offset: 0x00017AA2
	public long Int64_1 { get; set; }

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0011A6B0 File Offset: 0x001188B0
	public string String_4
	{
		get
		{
			string text;
			if ((text = this.string_0) == null)
			{
				text = (this.string_0 = this.String_9.smethod_36());
			}
			return text;
		}
	}

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000198AB File Offset: 0x00017AAB
	// (set) Token: 0x060025BA RID: 9658 RVA: 0x000198B3 File Offset: 0x00017AB3
	public float Single_0 { get; set; }

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x060025BB RID: 9659 RVA: 0x000198BC File Offset: 0x00017ABC
	public float Single_1
	{
		get
		{
			return this.method_1(this.Class106_0);
		}
	}

	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x060025BC RID: 9660 RVA: 0x000198CA File Offset: 0x00017ACA
	// (set) Token: 0x060025BD RID: 9661 RVA: 0x000198D2 File Offset: 0x00017AD2
	public Class106 Class106_0 { get; set; }

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x060025BE RID: 9662 RVA: 0x000198DB File Offset: 0x00017ADB
	// (set) Token: 0x060025BF RID: 9663 RVA: 0x000198E3 File Offset: 0x00017AE3
	public int Int32_3 { get; set; }

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000198EC File Offset: 0x00017AEC
	// (set) Token: 0x060025C1 RID: 9665 RVA: 0x000198F4 File Offset: 0x00017AF4
	public string String_5 { get; set; }

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0011A6DC File Offset: 0x001188DC
	public string String_6
	{
		get
		{
			return string.Concat(new string[]
			{
				this.Int32_4.ToString(),
				",",
				this.Int32_11.ToString(),
				",",
				this.Int32_12.ToString(),
				",",
				this.Int64_1.ToString("X8"),
				",",
				this.Int32_6.ToString()
			});
		}
	}

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000198FD File Offset: 0x00017AFD
	// (set) Token: 0x060025C4 RID: 9668 RVA: 0x00019905 File Offset: 0x00017B05
	public float Single_2 { get; set; }

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x060025C5 RID: 9669 RVA: 0x0001990E File Offset: 0x00017B0E
	// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00019916 File Offset: 0x00017B16
	public int Int32_4 { get; set; }

	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0001991F File Offset: 0x00017B1F
	// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00019927 File Offset: 0x00017B27
	public long Int64_2 { get; set; }

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x060025C9 RID: 9673 RVA: 0x00019930 File Offset: 0x00017B30
	public bool Boolean_0
	{
		get
		{
			return this.Int64_1 == this.Class106_0.Class502_0.Int64_22;
		}
	}

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x060025CA RID: 9674 RVA: 0x0001994A File Offset: 0x00017B4A
	public bool Boolean_1
	{
		get
		{
			return this.Class106_0.Class527_0.string_0.Contains(this.String_3);
		}
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x060025CB RID: 9675 RVA: 0x0011A770 File Offset: 0x00118970
	public bool Boolean_2
	{
		get
		{
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_1 && this.method_1(this.Class106_0) > 15f)
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_138 && Class531.smethod_22(65.0, 65.0, (double)this.Int32_11, (double)this.Int32_12) > 5f && !string.IsNullOrEmpty(this.String_12) && this.method_3(65f, 65f) < 10f)
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_20 && this.Class106_0.Class106_3 != null && this.Class106_0.Class106_3.List_5.Contains(Enum17.DatDoiQ3LauLanCham) && this.String_9 != "Hỏa Diễm Yêu Ma")
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_3 && this.Class106_0.Class106_3 != null && this.Class106_0.Class106_3.List_5.Contains(Enum17.DatDoiQ3ToChauCham) && this.String_9 != "Sơn Trại Đại Vương")
			{
				return false;
			}
			if (this.Single_2 <= 0f || Class226.Boolean_101)
			{
				return false;
			}
			int int32_ = Class226.Int32_35;
			if (Class226.Boolean_112 && this.method_3((float)this.Class106_0.Int32_16, (float)this.Class106_0.Int32_17) > (float)int32_)
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_92 && int32_ > 15 && this.method_3((float)this.Class106_0.Int32_16, (float)this.Class106_0.Int32_17) > 15f)
			{
				return false;
			}
			if (this.Class106_0.Single_1 > 0f)
			{
				int num = (this.Class106_0.Class527_0.Boolean_18 ? Class226.Int32_30 : Class226.Int32_29);
				if (this.method_3(this.Class106_0.Single_1, this.Class106_0.Single_2) > (float)num)
				{
					return false;
				}
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_90 && this.method_1(this.Class106_0) > 20f)
			{
				return false;
			}
			if (this.Class106_0.List_5.Contains(Enum17.TrungAc))
			{
				if (this.Class106_0.List_12.Any<Class516>(new Func<Class516, bool>(Class504.Class505.f_2F04411A.method_0)))
				{
					return false;
				}
			}
			if (this.Class106_0.Class527_0.String_12.Contains("Kiếm Tung Quần Hùng") && this.Int32_2 == this.Class106_0.Class506_0.Class504_1.Int32_4 && this.String_12.Contains("Người Khảo Hạch Ải"))
			{
				return true;
			}
			if (Class501.HashSet_12.Contains(this.String_9) || this.Int32_7 == Class537.int_13 || this.Boolean_0)
			{
				return false;
			}
			if (this.Class106_0.List_5.Contains(Enum17.TrangSucCuuLe) && this.String_9 != "Cửu Lê Chiến Sĩ")
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_148)
			{
				if (this.Class106_0.Int32_17 > 210 || (Class226.Boolean_96 && this.String_9 == "Huyết chú vu cổ"))
				{
					return false;
				}
				if ((this.String_9 == "Tinh Túc Đệ Tử" || this.String_9 == "Tinh túc môn đồ") && this.method_1(this.Class106_0) > 12f)
				{
					return false;
				}
			}
			if (this.Class106_0.Int32_11 != 0 || (Class226.Boolean_31 && Class226.HashSet_2.Contains(this.String_9)))
			{
				return false;
			}
			if (this.String_12.Contains("#{PTFB"))
			{
				return this.Int32_13 == 2 || this.Int32_13 == 7;
			}
			if (this.Class106_0.List_5.Contains(Enum17.DatDoiBinhThanh) && new List<string>(7) { "Trúc Đồng Tâm-Trắng", "Trúc Đồng Tâm-Lục", "Trúc Đồng Tâm-Tím", "Trúc Đồng Tâm-Vàng", "Trúc Đồng Tâm-Đỏ", "Trúc Đồng Tâm-Lam", "Phong Lôi Đàn" }.Contains(this.String_9))
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_50 < 10 && !string.IsNullOrWhiteSpace(this.String_12) && this.Class106_0.Class502_0.Int32_5 == 1)
			{
				return false;
			}
			Class106 class106_ = this.Class106_0.Class106_3;
			if (class106_ != null)
			{
				if (class106_.List_5.Contains(Enum17.DatDoiBaoDoHiem) && this.String_9 != "Đoạt Bảo Mã Tặc Đầu Lĩnh")
				{
					return false;
				}
				if (class106_.List_5.Contains(Enum17.DatDoiMaTac) && this.String_9 != "Đoạt Bảo Mã Tặc")
				{
					return false;
				}
				if (class106_.List_5.Contains(Enum17.DatDoiBossMap) && !Class501.HashSet_0.Contains(this.String_9))
				{
					return false;
				}
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_190 && this.String_9.Contains(" "))
			{
				return true;
			}
			if (this.Class106_0.Class527_0.Int32_35 <= 2)
			{
				return false;
			}
			if (this.Class106_0.List_21.Any<Class106>(new Func<Class106, bool>(Class504.Class505.f_2F04411A.method_1)) && this.Class106_0.Class527_0.Int32_35 == Class513.Int32_82 && !this.Class106_0.bool_20 && (this.String_9.smethod_36().Contains("dothong") || this.String_9.smethod_36().EndsWith("knight")))
			{
				return false;
			}
			if (this.Class106_0.List_21.Any<Class106>(new Func<Class106, bool>(Class504.Class505.f_2F04411A.method_2)) && this.Class106_0.Class527_0.Int32_35 == Class513.Int32_83 && (!this.Class106_0.bool_20 || Class226.Boolean_33) && this.String_9.smethod_36() == "honghungvuong")
			{
				return false;
			}
			if (this.Class106_0.List_5.Contains(Enum17.NhiemVuSuMon) && this.String_4 == "hodaothanthu")
			{
				return false;
			}
			if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_154)
			{
				if (this.Int32_7 != 16 && this.Int32_7 != 12 && this.Int32_7 != 53)
				{
					if (this.Int32_7 != 54)
					{
						if (this.Int32_7 > 37)
						{
							return true;
						}
						goto IL_06DE;
					}
				}
				return false;
			}
			IL_06DE:
			if (this.Single_2 > 0f && this.Int32_7 >= 0 && (this.Int32_7 < 0 || this.Int32_7 >= 16) && this.Int32_7 != 32 && this.Int32_7 != 21 && this.Int32_7 != 22 && this.Int32_7 != 19 && this.Int32_7 != 37)
			{
				if (this.Int32_7 <= 40 || this.Int32_7 == 57)
				{
					if (this.Int32_7 <= 10)
					{
						return false;
					}
					if (this.Class106_0.Class527_0.Int32_35 == Class513.Int32_145 && (this.String_9.Contains("Tháp") || this.String_9.Contains("Tower")))
					{
						return false;
					}
					if (!this.String_9.smethod_36().Contains("tieulang"))
					{
						if (!this.String_9.Contains("Niên Thú") || this.Class106_0.Class527_0.Int32_35 == 547 || this.Class106_0.Class527_0.Int32_35 == 243 || this.Class106_0.Class527_0.Int32_35 == 618)
						{
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x060025CC RID: 9676 RVA: 0x00019967 File Offset: 0x00017B67
	public bool Boolean_3
	{
		get
		{
			return !Class504.hashSet_2.Contains(this.String_9) && (Class504.hashSet_0.Contains(this.String_15) || Class504.hashSet_1.Contains(this.String_9));
		}
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x060025CD RID: 9677 RVA: 0x000199A1 File Offset: 0x00017BA1
	public bool Boolean_4
	{
		get
		{
			return this.String_15 == "40600000" && this.String_11.Contains("FFFFFFFF") && this.Int32_7 == -1;
		}
	}

	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x060025CE RID: 9678 RVA: 0x000199D2 File Offset: 0x00017BD2
	public bool Boolean_5
	{
		get
		{
			return !this.String_9.Contains(" ") && Class504.int_0.Contains(this.Int32_7);
		}
	}

	// Token: 0x17000788 RID: 1928
	// (get) Token: 0x060025CF RID: 9679 RVA: 0x000199F8 File Offset: 0x00017BF8
	public bool Boolean_6
	{
		get
		{
			return this.Int32_10 != -1;
		}
	}

	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00019A06 File Offset: 0x00017C06
	public bool Boolean_7
	{
		get
		{
			return this.Int32_4 == this.Class106_0.Int32_52;
		}
	}

	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x060025D1 RID: 9681 RVA: 0x00019A1B File Offset: 0x00017C1B
	public bool Boolean_8
	{
		get
		{
			return (!Class226.Boolean_31 || !Class226.HashSet_2.Contains(this.String_9)) && this.Int64_1 == this.Class106_0.Class502_0.Int64_59;
		}
	}

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0011AFAC File Offset: 0x001191AC
	public bool Boolean_9
	{
		get
		{
			if (Class226.Boolean_31 && Class226.HashSet_2.Contains(this.String_9))
			{
				return false;
			}
			if (this.Int64_1 != this.Class106_0.Class502_0.Int64_59)
			{
				return false;
			}
			if (this.Class106_0.List_5.Contains(Enum17.KhaiKhoang) && Class531.smethod_14(this.String_9) != -1)
			{
				return true;
			}
			if (this.Class106_0.List_5.Contains(Enum17.HaiDuoc) && Class531.smethod_15(this.String_9) != -1)
			{
				return true;
			}
			if (this.Int64_1 != this.Class106_0.Class502_0.Int64_59)
			{
				return false;
			}
			if (this.Class106_0.List_5.Contains(Enum17.KhaiThac))
			{
				return true;
			}
			if (this.Class106_0.List_5.Contains(Enum17.ThuThap))
			{
				return Class531.smethod_14(this.String_9) != -1 || Class531.smethod_15(this.String_9) != -1;
			}
			if (this.Class106_0.List_5.Contains(Enum17.KhaiKhoang) && this.Class106_0.List_5.Contains(Enum17.HaiDuoc))
			{
				if (Class531.smethod_14(this.String_9) == -1 && Class531.smethod_15(this.String_9) == -1)
				{
					return false;
				}
			}
			else
			{
				if (this.Class106_0.List_5.Contains(Enum17.KhaiKhoang) && Class531.smethod_14(this.String_9) == -1)
				{
					return false;
				}
				if (this.Class106_0.List_5.Contains(Enum17.HaiDuoc) && Class531.smethod_15(this.String_9) == -1)
				{
					return false;
				}
			}
			return true;
		}
	}

	// Token: 0x1700078C RID: 1932
	// (get) Token: 0x060025D3 RID: 9683 RVA: 0x0011B130 File Offset: 0x00119330
	public bool Boolean_10
	{
		get
		{
			return this.Int64_1 == (long)Class272.Int32_14 + this.Class106_0.Int64_0 || this.String_9 == "Hồi Âm Phiên" || this.Int64_1 == (long)Class272.Int32_15 + this.Class106_0.Int64_0;
		}
	}

	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00019A50 File Offset: 0x00017C50
	public bool Boolean_11
	{
		get
		{
			return this.String_2.Contains("FFFFFFFF") || this.String_2.Contains("00000000");
		}
	}

	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00019A76 File Offset: 0x00017C76
	// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00019A7E File Offset: 0x00017C7E
	public int Int32_5 { get; set; }

	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x060025D7 RID: 9687 RVA: 0x00019A87 File Offset: 0x00017C87
	// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00019A8F File Offset: 0x00017C8F
	public int Int32_6 { get; set; } = -1;

	// Token: 0x17000790 RID: 1936
	// (get) Token: 0x060025D9 RID: 9689 RVA: 0x00019A98 File Offset: 0x00017C98
	public string String_7
	{
		get
		{
			return Class529.smethod_1(this.String_9).Substring(0, 3);
		}
	}

	// Token: 0x17000791 RID: 1937
	// (get) Token: 0x060025DA RID: 9690 RVA: 0x00019AAC File Offset: 0x00017CAC
	// (set) Token: 0x060025DB RID: 9691 RVA: 0x00019AB4 File Offset: 0x00017CB4
	public int Int32_7 { get; set; }

	// Token: 0x17000792 RID: 1938
	// (get) Token: 0x060025DC RID: 9692 RVA: 0x00019ABD File Offset: 0x00017CBD
	public string String_8
	{
		get
		{
			return Class527.smethod_2(this.Int32_7);
		}
	}

	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x060025DD RID: 9693 RVA: 0x00019ACA File Offset: 0x00017CCA
	// (set) Token: 0x060025DE RID: 9694 RVA: 0x00019AD2 File Offset: 0x00017CD2
	public float Single_3 { get; set; }

	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x060025DF RID: 9695 RVA: 0x00019ADB File Offset: 0x00017CDB
	// (set) Token: 0x060025E0 RID: 9696 RVA: 0x00019AE3 File Offset: 0x00017CE3
	public string String_9 { get; set; } = string.Empty;

	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x060025E1 RID: 9697 RVA: 0x00019AEC File Offset: 0x00017CEC
	// (set) Token: 0x060025E2 RID: 9698 RVA: 0x00019AF4 File Offset: 0x00017CF4
	public long Int64_3 { get; set; }

	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00019AFD File Offset: 0x00017CFD
	public long Int64_4
	{
		get
		{
			return this.Int64_0 + (long)this.Class502_0.Int32_36;
		}
	}

	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00019B12 File Offset: 0x00017D12
	// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00019B1A File Offset: 0x00017D1A
	public int Int32_8 { get; set; }

	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x060025E6 RID: 9702 RVA: 0x0011B188 File Offset: 0x00119388
	public string String_10
	{
		get
		{
			return this.Int32_11.ToString() + "," + this.Int32_12.ToString();
		}
	}

	// Token: 0x17000799 RID: 1945
	// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00019B23 File Offset: 0x00017D23
	// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00019B2B File Offset: 0x00017D2B
	public int Int32_9 { get; set; }

	// Token: 0x1700079A RID: 1946
	// (get) Token: 0x060025E9 RID: 9705 RVA: 0x00019B34 File Offset: 0x00017D34
	// (set) Token: 0x060025EA RID: 9706 RVA: 0x00019B3C File Offset: 0x00017D3C
	public int Int32_10 { get; set; }

	// Token: 0x1700079B RID: 1947
	// (get) Token: 0x060025EB RID: 9707 RVA: 0x00019B45 File Offset: 0x00017D45
	// (set) Token: 0x060025EC RID: 9708 RVA: 0x00019B66 File Offset: 0x00017D66
	public int Int32_11
	{
		get
		{
			if (this.int_1 == -1)
			{
				return (int)Math.Round((double)this.Single_4, 0, MidpointRounding.AwayFromZero);
			}
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x1700079C RID: 1948
	// (get) Token: 0x060025ED RID: 9709 RVA: 0x00019B6F File Offset: 0x00017D6F
	// (set) Token: 0x060025EE RID: 9710 RVA: 0x00019B90 File Offset: 0x00017D90
	public int Int32_12
	{
		get
		{
			if (this.int_2 == -1)
			{
				return (int)Math.Round((double)this.Single_5, 0, MidpointRounding.AwayFromZero);
			}
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x1700079D RID: 1949
	// (get) Token: 0x060025EF RID: 9711 RVA: 0x00019B99 File Offset: 0x00017D99
	public string String_11
	{
		get
		{
			return this.String_13.Substring(0, 8);
		}
	}

	// Token: 0x1700079E RID: 1950
	// (get) Token: 0x060025F0 RID: 9712 RVA: 0x00019BA8 File Offset: 0x00017DA8
	// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00019BB0 File Offset: 0x00017DB0
	public int Int32_13 { get; set; }

	// Token: 0x1700079F RID: 1951
	// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00019BB9 File Offset: 0x00017DB9
	// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00019BC1 File Offset: 0x00017DC1
	public string String_12 { get; set; }

	// Token: 0x170007A0 RID: 1952
	// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00019BCA File Offset: 0x00017DCA
	// (set) Token: 0x060025F5 RID: 9717 RVA: 0x00019BD2 File Offset: 0x00017DD2
	public string String_13 { get; set; } = "FFFFFFFF";

	// Token: 0x170007A1 RID: 1953
	// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00019BDB File Offset: 0x00017DDB
	public string String_14
	{
		get
		{
			return this.String_13.Substring(this.String_13.Length - 8) + this.String_13.Substring(0, 8);
		}
	}

	// Token: 0x170007A2 RID: 1954
	// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00019C07 File Offset: 0x00017E07
	// (set) Token: 0x060025F8 RID: 9720 RVA: 0x00019C0F File Offset: 0x00017E0F
	public string String_15 { get; set; }

	// Token: 0x170007A3 RID: 1955
	// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0011B1BC File Offset: 0x001193BC
	public int Int32_14
	{
		get
		{
			int num = this.Class106_0.List_23.IndexOf(this.String_9);
			int num2 = this.Class106_0.List_23.IndexOf("Guild-" + this.Int32_3.ToString());
			int num3 = this.Class106_0.List_23.IndexOf(this.String_5);
			int num4 = this.Class106_0.List_23.IndexOf(Class527.smethod_2(this.Int32_7).Replace(" ", ""));
			int num5 = 9999;
			if (num > -1)
			{
				num5 = num;
			}
			if (num2 > -1 && num2 < num5)
			{
				num5 = num2;
			}
			if (num3 > -1 && num3 < num5)
			{
				num5 = num3;
			}
			if (num4 > -1 && num4 < num5)
			{
				num5 = num4;
			}
			if (num5 == -1)
			{
				num5 = 9999;
			}
			return num5;
		}
	}

	// Token: 0x170007A4 RID: 1956
	// (get) Token: 0x060025FA RID: 9722 RVA: 0x00019C18 File Offset: 0x00017E18
	// (set) Token: 0x060025FB RID: 9723 RVA: 0x00019C20 File Offset: 0x00017E20
	public byte[] Byte_0 { get; set; }

	// Token: 0x170007A5 RID: 1957
	// (get) Token: 0x060025FC RID: 9724 RVA: 0x00019C29 File Offset: 0x00017E29
	// (set) Token: 0x060025FD RID: 9725 RVA: 0x00019C31 File Offset: 0x00017E31
	public float Single_4 { get; set; }

	// Token: 0x170007A6 RID: 1958
	// (get) Token: 0x060025FE RID: 9726 RVA: 0x00019C3A File Offset: 0x00017E3A
	// (set) Token: 0x060025FF RID: 9727 RVA: 0x00019C42 File Offset: 0x00017E42
	public float Single_5 { get; set; }

	// Token: 0x170007A7 RID: 1959
	// (get) Token: 0x06002600 RID: 9728 RVA: 0x00019C4B File Offset: 0x00017E4B
	private long Int64_5 { get; }

	// Token: 0x170007A8 RID: 1960
	// (get) Token: 0x06002601 RID: 9729 RVA: 0x00019C53 File Offset: 0x00017E53
	private Class502 Class502_0 { get; }

	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x06002602 RID: 9730 RVA: 0x00019C5B File Offset: 0x00017E5B
	private Class515 Class515_0 { get; }

	// Token: 0x06002603 RID: 9731 RVA: 0x0011B28C File Offset: 0x0011948C
	public HashSet<long> method_0(long long_5)
	{
		HashSet<long> hashSet = new HashSet<long>();
		Stack<long> stack = new Stack<long>();
		stack.Push(long_5);
		while (stack.Count > 0 && hashSet.Count <= 50)
		{
			long num = stack.Pop();
			if (num > 0L && !hashSet.Contains(num))
			{
				hashSet.Add(num);
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num }));
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num + (long)this.Class106_0.Class515_0.Int32_1 }));
				stack.Push(this.Class106_0.Class515_0.method_9(new long[] { num + (long)(this.Class106_0.Class515_0.Int32_1 * 2) }));
			}
		}
		hashSet.Remove(long_5);
		return hashSet;
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00019C63 File Offset: 0x00017E63
	public float method_1(Class106 class106_1)
	{
		return Class531.smethod_22((double)class106_1.Single_5, (double)class106_1.Single_6, (double)this.Single_4, (double)this.Single_5);
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x0011B384 File Offset: 0x00119584
	public float method_2(string string_7)
	{
		float num = 0f;
		float num2 = 0f;
		if (string_7.Split(new char[] { ',' }).Length >= 2)
		{
			num = (float)Class531.smethod_19(string_7.Split(new char[] { ',' })[0]);
			num2 = (float)Class531.smethod_19(string_7.Split(new char[] { ',' })[1]);
		}
		return (float)Math.Sqrt(Math.Pow((double)(num - this.Single_4), 2.0) + Math.Pow((double)(num2 - this.Single_5), 2.0));
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x00019C86 File Offset: 0x00017E86
	public float method_3(float float_5, float float_6)
	{
		return (float)Math.Sqrt(Math.Pow((double)(float_5 - this.Single_4), 2.0) + Math.Pow((double)(float_6 - this.Single_5), 2.0));
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x0011B41C File Offset: 0x0011961C
	public Class504 method_4()
	{
		try
		{
			this.String_9 = string.Empty;
			long int64_ = this.Int64_5;
			Class106 @class = this.Class106_0;
			this.Int64_3 = this.Class515_0.method_9(new long[] { int64_ + (long)this.Class502_0.Int32_36 });
			this.Int64_1 = this.Class515_0.method_9(new long[] { this.Int64_3 });
			int num = ((this.Class502_0.Int32_5 != 1 || (!this.Boolean_8 && !this.Boolean_0 && !this.Boolean_10)) ? this.Class502_0.Int32_37 : 44);
			int num2 = ((this.Class502_0.Int32_5 != 1 || (!this.Boolean_8 && !this.Boolean_0 && !this.Boolean_10)) ? this.Class502_0.Int32_38 : 52);
			this.Single_4 = this.Class515_0.method_13(new long[] { this.Int64_3 + (long)num });
			this.Single_5 = this.Class515_0.method_13(new long[] { this.Int64_3 + (long)num2 });
			this.Int64_2 = @class.Class515_0.method_9(new long[] { int64_ + (long)this.Class502_0.Int32_36 }.Concat<long>(this.Class502_0.Int64_5).ToArray<long>());
			int num3 = ((this.Class502_0.Int32_5 == 5) ? 440 : ((this.Class502_0.Int32_5 == 1) ? 436 : ((this.Class502_0.Int32_5 == 3) ? 328 : 344)));
			this.Int32_13 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)num3 });
			this.Int32_2 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_51 });
			this.Int32_1 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)this.Class502_0.Int32_52 });
			byte[] array = new byte[this.Class502_0.Int32_48 + 255];
			if (@class.Class502_0.Int32_5 == 2)
			{
				array = new byte[308];
			}
			Class515.smethod_6(@class.Class515_0.IntPtr_0, this.Int64_2, array, array.Length, 0);
			this.Single_2 = this.Class106_0.Class515_0.method_13(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_39 });
			this.Single_3 = BitConverter.ToSingle(array, this.Class502_0.Int32_40);
			if (this.Class502_0.Int32_5 == 1)
			{
				this.String_13 = BitConverter.ToInt32(array, this.Class502_0.Int32_41 + 4).ToString("X8").Substring(0, 8);
			}
			else
			{
				this.String_13 = BitConverter.ToInt32(array, this.Class502_0.Int32_41).ToString("X8");
			}
			if (this.Class502_0.Int32_5 == 1)
			{
				this.String_2 = BitConverter.ToInt32(array, this.Class502_0.Int32_42 + 4).ToString("X8");
			}
			else
			{
				this.String_2 = BitConverter.ToInt32(array, this.Class502_0.Int32_42).ToString("X8");
			}
			this.Int32_7 = this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_45 });
			this.String_15 = BitConverter.ToInt32(array, this.Class502_0.Int32_46).ToString("X8");
			this.Int32_5 = BitConverter.ToInt32(array, this.Class502_0.Int32_47);
			this.Int32_8 = BitConverter.ToInt32(array, this.Class502_0.Int32_48);
			this.String_12 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_44 }).Trim();
			this.Int32_10 = BitConverter.ToInt32(array, this.Class502_0.Int32_49);
			int num4 = this.Class502_0.Int32_53;
			if (@class.Class502_0.Int32_5 == 1)
			{
				num4 = 256;
				if (this.Boolean_10)
				{
					num4 = 260;
				}
			}
			else if (@class.Class502_0.Int32_5 == 3)
			{
				num4 = (this.Boolean_10 ? 264 : 260);
			}
			if (this.Boolean_0)
			{
				this.String_9 = "Loot Packet";
			}
			else if (string.IsNullOrEmpty(this.String_9))
			{
				if (!this.Boolean_8 && !this.Boolean_10)
				{
					this.String_9 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_43 }).Trim();
				}
				else
				{
					if (this.Boolean_8 && this.Class106_0.Boolean_66)
					{
						num4 = 260;
					}
					Class515 class2 = @class.Class515_0;
					long[] array2 = new long[3];
					array2[0] = this.Int64_3 + (long)num4;
					array2[1] = (long)this.Class515_0.Int32_1;
					this.String_9 = class2.method_16(array2).Trim();
				}
			}
			this.list_0 = new List<int>();
			int num5 = 0;
			foreach (long num6 in this.HashSet_0)
			{
				if (num5++ > 300)
				{
					break;
				}
				int num7 = ((this.Class502_0.Int32_5 == 5) ? 32 : ((this.Class502_0.Int32_5 == 1 || this.Class106_0.Boolean_66 || this.Class502_0.Int32_5 == 4) ? 16 : 12));
				this.list_0.Add(this.Class106_0.Class515_0.method_7(new long[] { num6 + (long)num7 }));
			}
			if (this.Boolean_5)
			{
				this.Int32_9 = this.Class515_0.method_11(new long[] { this.Int64_2 + 23816L });
				this.Int32_3 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_13 });
				this.String_5 = this.Class515_0.method_16(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_21 });
			}
			if (@class.Class502_0.Int32_5 == 1 && (this.Class106_0.Class527_0.Int32_35 == Class268.Int32_0 || this.Class106_0.Class527_0.Int32_35 == Class269.Int32_0 || this.Class106_0.Class527_0.Int32_35 == Class270.Int32_0) && (this.Int32_7 == 36 || this.Int32_7 == 56))
			{
				this.Int32_7 = BitConverter.ToInt32(array, 664);
				if (this.Int32_7 < 10)
				{
					this.Int32_7++;
				}
				if (this.Int32_7 == 10)
				{
					this.Int32_7 = Class537.int_9;
				}
				if (this.Int32_7 == 11)
				{
					this.Int32_7 = Class537.int_10;
				}
				if (this.Int32_7 == 12)
				{
					this.Int32_7 = Class537.int_11;
				}
				if (this.Int32_7 == 13)
				{
					this.Int32_7 = Class537.int_12;
				}
				if (this.Int32_7 == 14)
				{
					this.Int32_7 = Class537.int_13;
				}
			}
		}
		catch
		{
		}
		return this;
	}

	// Token: 0x170007AA RID: 1962
	// (get) Token: 0x06002608 RID: 9736 RVA: 0x00019CBD File Offset: 0x00017EBD
	public float Single_6
	{
		get
		{
			return this.Class106_0.Class515_0.method_13(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_39 });
		}
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x0011BC10 File Offset: 0x00119E10
	public void method_5()
	{
		this.Int64_2 = this.Class106_0.Class515_0.method_9(new long[] { this.Int64_0 + (long)this.Class502_0.Int32_36 }.Concat<long>(this.Class502_0.Int64_5).ToArray<long>());
		this.Single_2 = (float)this.Class106_0.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_39 });
		int num = ((this.Class502_0.Int32_5 != 1 || (!this.Boolean_8 && !this.Boolean_0 && !this.Boolean_10)) ? this.Class502_0.Int32_37 : 44);
		int num2 = ((this.Class502_0.Int32_5 != 1 || (!this.Boolean_8 && !this.Boolean_0 && !this.Boolean_10)) ? this.Class502_0.Int32_38 : 52);
		this.Single_4 = this.Class515_0.method_13(new long[] { this.Int64_3 + (long)num });
		this.Single_5 = this.Class515_0.method_13(new long[] { this.Int64_3 + (long)num2 });
		this.list_0 = null;
		if (this.Class502_0.Int32_5 == 1)
		{
			this.String_2 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_42 + 4L }).ToString("X8");
		}
		else
		{
			this.String_2 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_42 }).ToString("X8");
		}
		int num3 = ((this.Class502_0.Int32_5 == 5) ? 440 : ((this.Class502_0.Int32_5 == 1) ? 432 : 344));
		this.Int32_13 = this.Class515_0.method_7(new long[] { this.Int64_3 + (long)num3 });
		this.Int32_8 = this.Class515_0.method_7(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_48 });
		this.list_0 = new List<int>();
		int num4 = 0;
		foreach (long num5 in this.HashSet_0)
		{
			if (num4++ > 300)
			{
				break;
			}
			int num6 = ((this.Class502_0.Int32_5 == 5) ? 32 : ((this.Class502_0.Int32_5 == 1 || this.Class106_0.Boolean_66 || this.Class502_0.Int32_5 == 4) ? 16 : 12));
			this.list_0.Add(this.Class106_0.Class515_0.method_7(new long[] { num5 + (long)num6 }));
		}
		if (string.IsNullOrEmpty(this.String_9))
		{
			if (this.Boolean_0)
			{
				this.String_9 = "Loot Packet";
			}
			else if (!this.Boolean_8 && !this.Boolean_10)
			{
				this.String_9 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_43 }).Trim();
			}
			else
			{
				Class515 @class = this.Class106_0.Class515_0;
				long[] array = new long[3];
				array[0] = this.Int64_3 + (long)this.Class502_0.Int32_53;
				array[1] = (long)this.Class515_0.Int32_1;
				this.String_9 = @class.method_16(array).Trim();
			}
		}
		this.String_12 = this.Class515_0.method_2(new long[] { this.Int64_2 + (long)this.Class502_0.Int32_44 }).Trim();
	}

	// Token: 0x0400197B RID: 6523
	public List<int> list_0;

	// Token: 0x0400197C RID: 6524
	private static readonly int[] int_0 = new int[]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 32,
		37, 53, 54, 55, 58
	};

	// Token: 0x0400197D RID: 6525
	private string string_0;

	// Token: 0x0400197E RID: 6526
	private int int_1 = -1;

	// Token: 0x0400197F RID: 6527
	private int int_2 = -1;

	// Token: 0x04001980 RID: 6528
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04001981 RID: 6529
	[CompilerGenerated]
	private int int_3;

	// Token: 0x04001982 RID: 6530
	[CompilerGenerated]
	private int int_4;

	// Token: 0x04001983 RID: 6531
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04001984 RID: 6532
	[CompilerGenerated]
	private long long_1;

	// Token: 0x04001985 RID: 6533
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04001986 RID: 6534
	[CompilerGenerated]
	private Class106 class106_0;

	// Token: 0x04001987 RID: 6535
	[CompilerGenerated]
	private int int_5;

	// Token: 0x04001988 RID: 6536
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04001989 RID: 6537
	[CompilerGenerated]
	private float float_1;

	// Token: 0x0400198A RID: 6538
	[CompilerGenerated]
	private int int_6;

	// Token: 0x0400198B RID: 6539
	[CompilerGenerated]
	private long long_2;

	// Token: 0x0400198C RID: 6540
	private static readonly HashSet<string> hashSet_0 = new HashSet<string> { "3FE66666", "3F4CCCCD", "40200000" };

	// Token: 0x0400198D RID: 6541
	private static readonly HashSet<string> hashSet_1 = new HashSet<string> { "Trương Sĩ Tâm", "Khô Vinh Đại Sư", "Đới Tam Kim", "Lý Thừa Phong", "Uông Hạn", "Ngô Đức Xương", "Võ Luyện", "Phan Thanh Thanh" };

	// Token: 0x0400198E RID: 6542
	private static readonly HashSet<string> hashSet_2 = new HashSet<string> { "Lạc Phụng Tiên" };

	// Token: 0x0400198F RID: 6543
	[CompilerGenerated]
	private int int_7;

	// Token: 0x04001990 RID: 6544
	[CompilerGenerated]
	private int int_8;

	// Token: 0x04001991 RID: 6545
	[CompilerGenerated]
	private int int_9;

	// Token: 0x04001992 RID: 6546
	[CompilerGenerated]
	private float float_2;

	// Token: 0x04001993 RID: 6547
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04001994 RID: 6548
	[CompilerGenerated]
	private long long_3;

	// Token: 0x04001995 RID: 6549
	[CompilerGenerated]
	private int int_10;

	// Token: 0x04001996 RID: 6550
	[CompilerGenerated]
	private int int_11;

	// Token: 0x04001997 RID: 6551
	[CompilerGenerated]
	private int int_12;

	// Token: 0x04001998 RID: 6552
	[CompilerGenerated]
	private int int_13;

	// Token: 0x04001999 RID: 6553
	[CompilerGenerated]
	private string string_4;

	// Token: 0x0400199A RID: 6554
	[CompilerGenerated]
	private string string_5;

	// Token: 0x0400199B RID: 6555
	[CompilerGenerated]
	private string string_6;

	// Token: 0x0400199C RID: 6556
	[CompilerGenerated]
	private byte[] byte_0;

	// Token: 0x0400199D RID: 6557
	[CompilerGenerated]
	private float float_3;

	// Token: 0x0400199E RID: 6558
	[CompilerGenerated]
	private float float_4;

	// Token: 0x0400199F RID: 6559
	[CompilerGenerated]
	private readonly long long_4;

	// Token: 0x040019A0 RID: 6560
	[CompilerGenerated]
	private readonly Class502 class502_0;

	// Token: 0x040019A1 RID: 6561
	[CompilerGenerated]
	private readonly Class515 class515_0;

	// Token: 0x020002D2 RID: 722
	[CompilerGenerated]
	[Serializable]
	private sealed class Class505
	{
		// Token: 0x0600260D RID: 9741 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		internal bool method_0(Class516 class516_0)
		{
			return class516_0.Int32_25 == 40004000;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00019CF7 File Offset: 0x00017EF7
		internal bool method_1(Class106 class106_0)
		{
			return class106_0.List_5.Contains(Enum17.DatDoiQ1ToChau);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00019D06 File Offset: 0x00017F06
		internal bool method_2(Class106 class106_0)
		{
			return class106_0.List_5.Contains(Enum17.DatDoiQ2ToChau);
		}

		// Token: 0x040019A2 RID: 6562
		public static readonly Class504.Class505 f_2F04411A = new Class504.Class505();

		// Token: 0x040019A3 RID: 6563
		public static Func<Class516, bool> f_982FEF30;

		// Token: 0x040019A4 RID: 6564
		public static Func<Class106, bool> f_764802B6;

		// Token: 0x040019A5 RID: 6565
		public static Func<Class106, bool> f_E53CFD15;
	}
}
