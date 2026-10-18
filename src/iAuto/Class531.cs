using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020002F2 RID: 754
internal class Class531
{
	// Token: 0x060029FD RID: 10749 RVA: 0x0001C5DC File Offset: 0x0001A7DC
	public static string smethod_0(string string_4)
	{
		return string_4.smethod_36();
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x0012BD94 File Offset: 0x00129F94
	public static string smethod_1(string string_4)
	{
		string_4 = Class531.smethod_0(string_4);
		if (string_4.Contains("trithanhdaisu") || string_4.Contains("bhrwsc_110331_53"))
		{
			return "0,176,192,trithanhdaisu,34";
		}
		if (string_4.Contains("trithanhdoisu") || string_4.Contains("bhrwsc_110331_53"))
		{
			return "0,176,192,trithanhdoisu,34";
		}
		if (string_4.Contains("doanchinhthuan"))
		{
			return "2,71,18,doanchinhthuan,16";
		}
		if (string_4.Contains("tothuc"))
		{
			return "1,166,311,tothuc,2";
		}
		return "";
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
	public static string smethod_2(string string_4)
	{
		if (string_4.Contains("#{SDHDRW_091109_44}"))
		{
			return "104,123";
		}
		return "";
	}

	// Token: 0x06002A00 RID: 10752 RVA: 0x0001C5FE File Offset: 0x0001A7FE
	public static string smethod_3(string string_4)
	{
		if (string_4.Contains("#{SDHDRW_091109_41}"))
		{
			return "4,168,200,229,117,114,128,116,186,168,200";
		}
		return "";
	}

	// Token: 0x06002A01 RID: 10753 RVA: 0x0012BE14 File Offset: 0x0012A014
	public static string smethod_4(string string_4)
	{
		string_4 = Class531.smethod_0(string_4);
		if (string_4.Contains("longtu"))
		{
			return "186,98,142,hotutruonglao,13035,96,142";
		}
		if (string_4.Contains("modungsontrang"))
		{
			return "289,152,154,congdakhon,9044,160,169";
		}
		if (string_4.Contains("duonggiabao"))
		{
			return "616,152,154,duongmotuong,10051,173,170";
		}
		if (string_4.Contains("tinhtuchai"))
		{
			return "189,100,145,thientoantu,16035,96,142";
		}
		if (string_4.Contains("badong"))
		{
			return "187,45,126,congdatutruong,14035,44,129";
		}
		if (string_4.Contains("thieulamtu"))
		{
			return "182,99,146,huyenchung,9035,96,158";
		}
		if (string_4.Contains("thienson"))
		{
			return "190,94,147,dangba,17035,95,148";
		}
		if (string_4.Contains("ngamison"))
		{
			return "188,95,146,lieutammuoi,15035,89,146";
		}
		if (string_4.Contains("vodangson"))
		{
			return "185,100,181,tieuthiendat,12035,95,192";
		}
		if (string_4.Contains("quangminhdien"))
		{
			return "184,95,162,thaccang,11035,98,159";
		}
		if (string_4.Contains("caibangtongda"))
		{
			return "183,93,152,auduongqua,10035,91,159";
		}
		return "";
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x0012BF00 File Offset: 0x0012A100
	public static string smethod_5(string string_4)
	{
		string_4 = Class531.smethod_0(string_4);
		if (string_4.Contains("dietyeukhoiloi"))
		{
			return "127,113,dietyeukhoiloi";
		}
		if (string_4.Contains("trutienkhoiloi"))
		{
			return "95,80,trutienkhoiloi";
		}
		if (string_4.Contains("thithankhoiloi"))
		{
			return "51,72,thithankhoiloi";
		}
		if (string_4.Contains("thambiphitac"))
		{
			return "69,126,thambiphitac";
		}
		if (string_4.Contains("tamthuphitac"))
		{
			return "54,61,tamthuphitac";
		}
		if (string_4.Contains("suubaophitac"))
		{
			return "68,142,phitieuthiettac";
		}
		if (string_4.Contains("tatlethiettac"))
		{
			return "98,70,tatlethiettac";
		}
		if (string_4.Contains("docchamthiettac"))
		{
			return "51,69,docchamthiettac";
		}
		if (string_4.Contains("phitieuthiettac"))
		{
			return "100,181,phitieuthiettac";
		}
		if (string_4.Contains("mocvuongtrithu"))
		{
			return "96,126,mocvuongtrithu";
		}
		if (string_4.Contains("thuyvuongtrithu"))
		{
			return "118,112,thuyvuongtrithu";
		}
		if (string_4.Contains("hoavuongtrithu"))
		{
			return "96,86,hoavuongtrithu";
		}
		if (string_4.Contains("huthekhoiloi"))
		{
			return "52,72,huthekhoiloi";
		}
		if (string_4.Contains("thuctamkhoiloi"))
		{
			return "120,140,thuctamkhoiloi";
		}
		if (string_4.Contains("hoaphachkhoiloi"))
		{
			return "146,58,hoaphachkhoiloi";
		}
		if (string_4.Contains("mocnhanlaula"))
		{
			return "96,110,mocnhanlaula";
		}
		if (string_4.Contains("mocnhantinhanh"))
		{
			return "96,80,mocnhantinhanh";
		}
		if (string_4.Contains("mocnhanvosi"))
		{
			return "40,98,mocnhanvosi";
		}
		if (string_4.Contains("thiensontieutuyetquai"))
		{
			return "96,110,thiensontieutuyetquai";
		}
		if (string_4.Contains("thiensondaituyetquai"))
		{
			return "96,86,thiensondaituyetquai";
		}
		if (string_4.Contains("thiensontuyetquaivuong"))
		{
			return "96,50,thiensontuyetquaivuong";
		}
		if (string_4.Contains("ngamibachmyacvien"))
		{
			return "139,106,ngamibachmyacvien";
		}
		if (string_4.Contains("ngamiloitraoacvien"))
		{
			return "96,63,ngamiloitraoacvien";
		}
		if (string_4.Contains("ngamihungnhu"))
		{
			return "44,45,ngamihungnhu";
		}
		if (string_4.Contains("yeuditamma"))
		{
			return "59,180,yeuditamma";
		}
		if (string_4.Contains("phasantamma"))
		{
			return "78,132,phasantamma";
		}
		if (string_4.Contains("satductamma"))
		{
			return "46,58,satductamma";
		}
		if (string_4.Contains("matthamtienphong"))
		{
			return "97,117,matthamtienphong";
		}
		if (string_4.Contains("thanhkythamma"))
		{
			return "155,102,thanhkythamma";
		}
		if (string_4.Contains("lamkythamma"))
		{
			return "98,65,lamkythamma";
		}
		if (string_4.Contains("phuccuuachau"))
		{
			return "69,145,phuccuuachau";
		}
		if (string_4.Contains("cuongtrangachau"))
		{
			return "45,115,cuongtrangachau";
		}
		if (string_4.Contains("tinhtrangachau"))
		{
			return "44,79,tinhtrangachau";
		}
		return "";
	}

	// Token: 0x170009B8 RID: 2488
	// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0001C618 File Offset: 0x0001A818
	// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0001C61F File Offset: 0x0001A81F
	public static Random Random_0 { get; set; } = new Random();

	// Token: 0x06002A05 RID: 10757 RVA: 0x0012C190 File Offset: 0x0012A390
	public static bool smethod_6(Point point_0, Point point_1, Point point_2, Point point_3)
	{
		int num = point_0.X - point_1.X;
		int num2 = point_0.Y - point_1.Y;
		bool flag = (point_2.X - point_1.X) * num2 - (point_2.Y - point_1.Y) * num > 0;
		return (point_3.X - point_1.X) * num2 - (point_3.Y - point_1.Y) * num > 0 != flag && (point_3.X - point_2.X) * (point_0.Y - point_2.Y) - (point_3.Y - point_2.Y) * (point_0.X - point_2.X) > 0 == flag;
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x0001C627 File Offset: 0x0001A827
	public static bool smethod_7(Point point_0, Point point_1, Point point_2, Point point_3, Point point_4)
	{
		return Class531.smethod_6(point_0, point_1, point_2, point_3) || Class531.smethod_6(point_0, point_1, point_3, point_4);
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x0001C640 File Offset: 0x0001A840
	public static bool smethod_8(Point point_0, Point point_1, Point point_2, Point point_3, Point point_4, Point point_5)
	{
		return Class531.smethod_7(point_0, point_1, point_2, point_3, point_4) || Class531.smethod_7(point_0, point_1, point_3, point_4, point_5);
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x0012C258 File Offset: 0x0012A458
	public static int[] smethod_9(Point point_0, Point point_1)
	{
		int num = point_0.Y - point_1.Y;
		int num2 = point_1.X - point_0.X;
		int num3 = num * -point_0.X + num2 * -point_0.Y;
		return new int[] { num, num2, num3 };
	}

	// Token: 0x06002A09 RID: 10761 RVA: 0x0001C65D File Offset: 0x0001A85D
	public static string smethod_10(int int_0)
	{
		return new string(Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyz", int_0).Select<string, char>(new Func<string, char>(Class531.Class532.f_104F3EEE.method_0)).ToArray<char>());
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x0012C2B0 File Offset: 0x0012A4B0
	public static string smethod_11()
	{
		int num = Class531.Random_0.Next(1, 10);
		return new string(Enumerable.Repeat<string>(" ", num).Select<string, char>(new Func<string, char>(Class531.Class532.f_104F3EEE.method_1)).ToArray<char>());
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x0012C304 File Offset: 0x0012A504
	public static string smethod_12(string string_4, string string_5, string string_6 = "")
	{
		int num = string_4.IndexOf(string_5);
		if (num == -1)
		{
			return null;
		}
		int num2 = ((string_6 != "") ? string_4.IndexOf(string_6, num + string_5.Length) : string_4.Length);
		if (num2 == -1)
		{
			return null;
		}
		return string_4.Substring(num + string_5.Length, num2 - num - string_5.Length);
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x0012C364 File Offset: 0x0012A564
	public static int smethod_13(string string_4)
	{
		string_4 = string_4.smethod_36();
		if (string_4.Contains("namvuc"))
		{
			return 4;
		}
		if (string_4.Contains("quynhchau"))
		{
			return 4;
		}
		if (string_4.Contains("vodi"))
		{
			return 4;
		}
		if (string_4.Contains("haitacdong"))
		{
			return 4;
		}
		if (string_4.Contains("haitocdong"))
		{
			return 4;
		}
		if (string_4.Contains("mieunhandong"))
		{
			return 4;
		}
		if (string_4.Contains("namchieu"))
		{
			return 5;
		}
		if (string_4.Contains("diemho"))
		{
			return 5;
		}
		if (string_4.Contains("bachsadiemkhanh"))
		{
			return 5;
		}
		if (string_4.Contains("bochsadiemkhanh"))
		{
			return 5;
		}
		if (string_4.Contains("thachlam"))
		{
			return 5;
		}
		if (string_4.Contains("thochlam"))
		{
			return 5;
		}
		if (string_4.Contains("mieucuong"))
		{
			return 5;
		}
		if (string_4.Contains("ngockhe"))
		{
			return 5;
		}
		if (string_4.Contains("truongbachson"))
		{
			return 6;
		}
		if (string_4.Contains("truongbochson"))
		{
			return 6;
		}
		if (string_4.Contains("hoanglongphu"))
		{
			return 6;
		}
		if (string_4.Contains("tuyetlangho"))
		{
			return 6;
		}
		if (string_4.Contains("thaonguyen"))
		{
			return 6;
		}
		if (string_4.Contains("thuykinhho"))
		{
			return 6;
		}
		if (string_4.Contains("lieutay"))
		{
			return 6;
		}
		if (string_4.Contains("tienvuongphan"))
		{
			return 6;
		}
		if (string_4.Contains("nganngaituyetnguyen"))
		{
			return 6;
		}
		return -1;
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x0012C4D4 File Offset: 0x0012A6D4
	public static int smethod_14(string string_4)
	{
		string_4 = string_4.smethod_36();
		if (string_4.EndsWith("khoang"))
		{
			return 99;
		}
		if (string_4 == "modong")
		{
			return 1;
		}
		if (string_4 == "mosat")
		{
			return 2;
		}
		if (string_4 == "mobac")
		{
			return 3;
		}
		if (string_4 == "mohanthiet")
		{
			return 4;
		}
		if (string_4 == "movang")
		{
			return 5;
		}
		if (string_4 == "mohuyenthiet")
		{
			return 6;
		}
		if (string_4 == "mophale")
		{
			return 7;
		}
		if (string_4 == "mophithuy")
		{
			return 8;
		}
		if (string_4 == "mochanvu")
		{
			return 9;
		}
		if (string_4 == "molonghuyet")
		{
			return 10;
		}
		if (string_4 == "mophunghuyet")
		{
			return 11;
		}
		return Class531.string_1.smethod_15(string_4);
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x0012C5AC File Offset: 0x0012A7AC
	public static int smethod_15(string string_4)
	{
		string_4 = string_4.smethod_36();
		if (string_4 == "bachanh")
		{
			return 1;
		}
		if (string_4 == "bochanh")
		{
			return 1;
		}
		if (string_4 == "bohoang")
		{
			return 2;
		}
		if (string_4 == "xuyenboi")
		{
			return 3;
		}
		if (string_4 == "nguyenho")
		{
			return 4;
		}
		if (string_4 == "tyba")
		{
			return 5;
		}
		if (string_4 == "camthao")
		{
			return 6;
		}
		if (string_4 == "kimnganhoa")
		{
			return 7;
		}
		if (string_4 == "hoangcam")
		{
			return 8;
		}
		if (string_4 == "cauky")
		{
			return 9;
		}
		if (string_4 == "tramhuong")
		{
			return 10;
		}
		if (string_4 == "dotrong")
		{
			return 11;
		}
		if (string_4 == "thuongthuat")
		{
			return 12;
		}
		if (string_4 == "phuclinh")
		{
			return 13;
		}
		if (string_4 == "phongphong")
		{
			return 14;
		}
		if (string_4 == "huongnhu")
		{
			return 15;
		}
		if (string_4 == "hoanglien")
		{
			return 16;
		}
		if (string_4 == "duongqui")
		{
			return 17;
		}
		if (string_4 == "quetam")
		{
			return 18;
		}
		if (string_4 == "huongphu")
		{
			return 19;
		}
		if (string_4 == "hoachuong")
		{
			return 20;
		}
		if (string_4 == "hoithanthao")
		{
			return 21;
		}
		if (string_4 == "thuo")
		{
			return 22;
		}
		if (string_4 == "dongtrunghathao")
		{
			return 23;
		}
		if (string_4 == "dongtrunghothao")
		{
			return 23;
		}
		if (string_4 == "longquitu")
		{
			return 24;
		}
		if (string_4 == "tuongboi")
		{
			return 25;
		}
		if (string_4 == "nhansam")
		{
			return 26;
		}
		if (string_4 == "linhchi")
		{
			return 27;
		}
		if (string_4 == "tuanthao")
		{
			return 28;
		}
		if (string_4 == "lientu")
		{
			return 29;
		}
		if (string_4 == "khomocxuan")
		{
			return 30;
		}
		if (string_4 == "longquytu")
		{
			return 31;
		}
		return Class531.string_2.smethod_15(string_4);
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x0012C7D4 File Offset: 0x0012A9D4
	public static int smethod_16(string string_4)
	{
		string_4 = string_4.smethod_36();
		string_4 = string_4.Replace("vudi", "vodi");
		if (string_4.Contains("lacduong"))
		{
			return 0;
		}
		if (string_4.Contains("tuyetnguyen"))
		{
			return Class513.Int32_107;
		}
		if (string_4.Contains("namhai"))
		{
			return Class513.Int32_80;
		}
		if (string_4.Contains("locduong"))
		{
			return 0;
		}
		if (string_4.Contains("tochau"))
		{
			return 1;
		}
		if (string_4.Contains("daily"))
		{
			return 2;
		}
		if (string_4.Contains("doily"))
		{
			return 2;
		}
		if (string_4.Contains("doilu"))
		{
			return 2;
		}
		if (string_4.Contains("tungson"))
		{
			return 3;
		}
		if (string_4.Contains("thaiho"))
		{
			return 4;
		}
		if (string_4.Contains("kinhho"))
		{
			return 5;
		}
		if (string_4.Contains("voluongson"))
		{
			return 6;
		}
		if (string_4.Contains("kiemcac"))
		{
			return 7;
		}
		if (string_4.Contains("donhoang"))
		{
			return 8;
		}
		if (string_4.Contains("thieulamtu"))
		{
			return 9;
		}
		if (string_4.Contains("caibangtongda"))
		{
			return 10;
		}
		if (string_4.Contains("quangminhdien"))
		{
			return 11;
		}
		if (string_4.Contains("vodangson"))
		{
			return 12;
		}
		if (string_4.Contains("thienlongtu"))
		{
			return 13;
		}
		if (string_4.Contains("langbadong"))
		{
			return 14;
		}
		if (string_4.Contains("ngamison"))
		{
			return 15;
		}
		if (string_4.Contains("tinhtuchai"))
		{
			return 16;
		}
		if (string_4.Contains("thienson"))
		{
			return 17;
		}
		if (string_4.Contains("nhannam"))
		{
			return 18;
		}
		if (string_4.Contains("nhonnam"))
		{
			return 18;
		}
		if (string_4.Contains("nhanbac"))
		{
			return 19;
		}
		if (string_4.Contains("nhonbac"))
		{
			return 19;
		}
		if (string_4.Contains("thaonguyen"))
		{
			return 20;
		}
		if (string_4.Contains("lieutay"))
		{
			return 21;
		}
		if (string_4.Contains("truongbachson"))
		{
			return 22;
		}
		if (string_4.Contains("truongbochson"))
		{
			return 22;
		}
		if (string_4.Contains("hoanglongphu"))
		{
			return 23;
		}
		if (string_4.Contains("nhihai"))
		{
			return 24;
		}
		if (string_4.Contains("thuongson"))
		{
			return 25;
		}
		if (string_4.Contains("thachlam"))
		{
			return 26;
		}
		if (string_4.Contains("thochlam"))
		{
			return 26;
		}
		if (string_4.Contains("ngockhe"))
		{
			return 27;
		}
		if (string_4.Contains("namchieu"))
		{
			return 28;
		}
		if (string_4.Contains("mieucuong"))
		{
			return 29;
		}
		if (string_4.Contains("tayho"))
		{
			return 30;
		}
		if (string_4.Contains("longtuyen"))
		{
			return 31;
		}
		if (string_4.Contains("vodi"))
		{
			return 32;
		}
		if (string_4.Contains("mailinh"))
		{
			return 33;
		}
		if (string_4.Contains("namvuc"))
		{
			return 34;
		}
		if (string_4.Contains("quynhchau"))
		{
			return 35;
		}
		if (string_4.Contains("huyenvudao"))
		{
			return 112;
		}
		if (string_4.Contains("baotangdongtang1"))
		{
			return 166;
		}
		if (string_4.Contains("baotangdongtang2"))
		{
			return 169;
		}
		if (string_4.Contains("nganngaituyetnguyen"))
		{
			return 229;
		}
		if (string_4.Contains("baotangdongtang3"))
		{
			return 191;
		}
		if (string_4.Contains("baotangdongtang4"))
		{
			return 192;
		}
		if (string_4.Contains("baotangdongtang5"))
		{
			return 193;
		}
		if (string_4.Contains("thaolieutruong"))
		{
			return 199;
		}
		if (string_4.Contains("mieu nhan dong"))
		{
			return 200;
		}
		if (string_4.Contains("thanh thu son"))
		{
			return 201;
		}
		if (string_4.Contains("yenvuongcomotang1"))
		{
			return 202;
		}
		if (string_4.Contains("yenvuongcomotang2"))
		{
			return 203;
		}
		if (string_4.Contains("yenvuongcomotang3"))
		{
			return 204;
		}
		if (string_4.Contains("yenvuongcomotang4"))
		{
			return 205;
		}
		if (string_4.Contains("yenvuongcomotang5"))
		{
			return 206;
		}
		if (string_4.Contains("yenvuongcomotang6"))
		{
			return 207;
		}
		if (string_4.Contains("yenvuongcomotang7"))
		{
			return 208;
		}
		if (string_4.Contains("yenvuongcomotang8"))
		{
			return 209;
		}
		if (string_4.Contains("yenvuongcomotang9"))
		{
			return 210;
		}
		if (string_4.Contains("bentausondong"))
		{
			return 211;
		}
		if (string_4.Contains("kiemgia"))
		{
			return 212;
		}
		if (string_4.Contains("manhaidong"))
		{
			return 213;
		}
		if (string_4.Contains("danhancau"))
		{
			return 214;
		}
		if (string_4.Contains("ontuyendong"))
		{
			return 215;
		}
		if (string_4.Contains("hoanglongdong"))
		{
			return 216;
		}
		if (string_4.Contains("thuykinhho"))
		{
			return 217;
		}
		if (string_4.Contains("tienvuongphan"))
		{
			return 218;
		}
		if (string_4.Contains("thienkhanhthudong"))
		{
			return 219;
		}
		if (string_4.Contains("daohoanguyen"))
		{
			return 220;
		}
		if (string_4.Contains("haitacdong"))
		{
			return 221;
		}
		if (string_4.Contains("tuyetlangho"))
		{
			return 222;
		}
		if (string_4.Contains("diemho"))
		{
			return 235;
		}
		if (string_4.Contains("bachsadiemkhanh"))
		{
			return 237;
		}
		if (string_4.Contains("bochsadiemkhanh"))
		{
			return 237;
		}
		if (string_4.Contains("hoadiemson"))
		{
			return 244;
		}
		if (string_4.Contains("caoxuong"))
		{
			return 245;
		}
		if (string_4.Contains("laulan"))
		{
			return 246;
		}
		if (string_4.Contains("thaplymoc"))
		{
			return 247;
		}
		if (string_4.Contains("thaplumoc"))
		{
			return 247;
		}
		if (string_4.Contains("hoadiemcoc"))
		{
			return 251;
		}
		if (string_4.Contains("caoxuongmecung"))
		{
			return 252;
		}
		if (string_4.Contains("thapkhaclapmacan"))
		{
			return 253;
		}
		if (string_4.Contains("daiuyen"))
		{
			return 249;
		}
		if (string_4.Contains("hanhuyetlinh"))
		{
			return 255;
		}
		if (string_4.Contains("honhuyetlinh"))
		{
			return 255;
		}
		if (string_4.Contains("tanhoangdiacungtang1"))
		{
			return 262;
		}
		if (string_4.Contains("tanhoangdiacungtang2"))
		{
			return 263;
		}
		if (string_4.Contains("tanhoangdiacungtang3"))
		{
			return 264;
		}
		if (string_4.Contains("tanhoangdiacungtang4"))
		{
			return 292;
		}
		if (string_4.Contains("datayho"))
		{
			return 164;
		}
		if (string_4.Contains("dotayho"))
		{
			return 164;
		}
		if (string_4.Contains("conlonphucdia"))
		{
			return 254;
		}
		if (string_4.Contains("conlonson"))
		{
			return 248;
		}
		if (string_4.Contains("thanhnguyen"))
		{
			return 282;
		}
		if (string_4.Contains("thanhnguyensondong"))
		{
			return 283;
		}
		if (string_4.Contains("modungsontrang"))
		{
			return 284;
		}
		if (string_4.Contains("tatmanhihan"))
		{
			return 250;
		}
		if (string_4.Contains("thanhhoacung"))
		{
			return 256;
		}
		if (string_4.Contains("lamhaikhecoc"))
		{
			return 569;
		}
		if (string_4.Contains("macnamthanhnguyen"))
		{
			return 573;
		}
		if (string_4.Contains("vongxuyenhoahai"))
		{
			return 574;
		}
		if (string_4.Contains("thienkynamhoai"))
		{
			return 575;
		}
		if (string_4.Contains("thongthienthapdiacung"))
		{
			return 295;
		}
		if (string_4.Contains("thongthienthaptang1"))
		{
			return 296;
		}
		if (string_4.Contains("thongthienthaptang2"))
		{
			return 297;
		}
		if (string_4.Contains("thongthienthaptang3"))
		{
			return 298;
		}
		if (string_4.Contains("dinhthongthienthap"))
		{
			return 299;
		}
		if (string_4.Contains("phungminhtran"))
		{
			return 580;
		}
		if (string_4.Contains("laulan"))
		{
			return 246;
		}
		if (string_4.Contains("thuchacotran"))
		{
			return 260;
		}
		if (string_4.Contains("denhatkhunghingoitailacduong"))
		{
			return 238;
		}
		if (string_4.Contains("khunghingoitaidaily"))
		{
			return 240;
		}
		if (string_4.Contains("khunghingoitaitochau"))
		{
			return 241;
		}
		if (string_4.Contains("hanngoccoc"))
		{
			return 243;
		}
		if (string_4.Contains("thuynguyetdongthien"))
		{
			return 613;
		}
		if (string_4.Contains("huyenhai"))
		{
			return 611;
		}
		if (string_4.Contains("daicondihai"))
		{
			return 612;
		}
		if (string_4.Contains("phungminhtran"))
		{
			return 580;
		}
		if (string_4.Contains("thuynguyetdongthien"))
		{
			return 613;
		}
		if (string_4.Contains("lacduong"))
		{
			return 242;
		}
		if (string_4.Contains("huyenvudao"))
		{
			return 112;
		}
		if (string_4.Contains("laulan"))
		{
			return 246;
		}
		if (string_4.Contains("thuchacotran"))
		{
			return 260;
		}
		if (string_4.Contains("denhatkhunghingoitailacdduong"))
		{
			return 238;
		}
		if (string_4.Contains("denhikhunghingoitailacduong"))
		{
			return 239;
		}
		if (string_4.Contains("modungsontrang"))
		{
			return 284;
		}
		if (string_4.Contains("tientrang"))
		{
			return 224;
		}
		if (string_4.Contains("phungminhtran"))
		{
			return 580;
		}
		if (string_4.Contains("huyenvudao"))
		{
			return 112;
		}
		if (string_4.Contains("quangminhdong"))
		{
			return 601;
		}
		if (string_4.Contains("daycoctieudao"))
		{
			return 602;
		}
		if (string_4.Contains("linhtinhphong"))
		{
			return 603;
		}
		if (string_4.Contains("caibangtuudieu"))
		{
			return 604;
		}
		if (string_4.Contains("daohoatran"))
		{
			return 605;
		}
		if (string_4.Contains("thaplam"))
		{
			return 606;
		}
		if (string_4.Contains("nguthandong"))
		{
			return 607;
		}
		if (string_4.Contains("chietmaiphong"))
		{
			return 608;
		}
		if (string_4.Contains("chanthap"))
		{
			return 609;
		}
		if (string_4.Contains("tangthuthuycac"))
		{
			return 610;
		}
		if (string_4.Contains("hauhoavien"))
		{
			return 123;
		}
		if (string_4.Contains("tieumocnhanhang"))
		{
			return 122;
		}
		if (string_4.Contains("duonggiabao"))
		{
			return 615;
		}
		if (string_4.Contains("laulan"))
		{
			return 246;
		}
		if (string_4.Contains("thuchacotran"))
		{
			return 260;
		}
		if (string_4.Contains("modungsontrang"))
		{
			return 284;
		}
		if (string_4.Contains("phungminhtran"))
		{
			return 580;
		}
		if (string_4.Contains("dienvotruong"))
		{
			return 617;
		}
		if (string_4.Contains("quanthienthanh"))
		{
			return 581;
		}
		if (string_4.Contains("trieukinhthanh"))
		{
			return 583;
		}
		if (string_4.Contains("laphuthanh"))
		{
			return 582;
		}
		foreach (KeyValuePair<int, string> keyValuePair in Class501.Dictionary_4)
		{
			if (string_4.Contains(keyValuePair.Value.smethod_36()))
			{
				return keyValuePair.Key;
			}
		}
		return -1;
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x0012D340 File Offset: 0x0012B540
	public static string smethod_17(string string_4)
	{
		string_4 = string_4.Replace("Vương Đức Phú", "Vương Đức Phúc");
		string_4 = string_4.Replace("Bách Hiểu Sinh", "Bạch Manh Sinh");
		string_4 = string_4.Replace("Mộ Dung Chùy", "Mộ Dung Thùy");
		if (string_4.Contains("Đoạn Trường Nhai"))
		{
			return "INFOAIM258,33,824,TuoiNuoc";
		}
		if (string_4.Contains("Tàng Phong Lâu"))
		{
			return "INFOAIM278,251,824,TuoiNuoc";
		}
		if (string_4.Contains("#GThính Phong Xướng Vãn"))
		{
			return "INFOAIM369,327,824,TuoiNuoc";
		}
		if (string_4.Contains("#GLinh Ô Uyển"))
		{
			return "INFOAIM122,252,824,TuoiNuoc";
		}
		if (string_4.Contains("Tìm #RMục Vũ"))
		{
			return "INFOAIM256,142,824,MucVu,PhuBan";
		}
		if (string_4.Contains("Huyền Hồ Uyển"))
		{
			return "INFOAIM139,146,678,TuoiNuoc";
		}
		if (string_4.Contains("Quan Tinh Đài"))
		{
			return "INFOAIM60,42,678,TuoiNuoc";
		}
		if (string_4.Contains("Vu Sơn Cảnh"))
		{
			return "INFOAIM40,100,678,TuoiNuoc";
		}
		if (string_4.Contains("Âm Dương Thiên Đông Trắc"))
		{
			return "INFOAIM128,71,678,TuoiNuoc";
		}
		if (string_4.Contains("Thính Hương Thủy Tạ"))
		{
			return "INFOAIM154,93,284,TuoiNuoc";
		}
		if (string_4.Contains("Cầm Âm Tiểu Trúc"))
		{
			return "INFOAIM78,142,284,TuoiNuoc";
		}
		if (string_4.Contains("Sâm Hợp Trang"))
		{
			return "INFOAIM28,28,284,TuoiNuoc";
		}
		if (string_4.Contains("Mạn Đà Viên"))
		{
			return "INFOAIM119,36,284,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_47}#r"))
		{
			return "INFOAIM67,110,284,MoDungThuy,PhuBan";
		}
		if (string_4.Contains("Túc Thái Âm Tì Kinh Đồng Nhân"))
		{
			return "INFOAIM121,90,13,TuoiNuoc";
		}
		if (string_4.Contains("Thủ Thái Âm Phế Kinh Đồng Nhân"))
		{
			return "INFOAIM62,90,13,TuoiNuoc";
		}
		if (string_4.Contains("Túc Dương Minh Vị Kinh Đồng Nhân"))
		{
			return "INFOAIM106,85,13,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_41}#{SMXL_090819_dali}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM35,86,13,BanTuong,PhuBan";
		}
		if (string_4.Contains("Người đồng thủ dương minh đại trường kinh"))
		{
			return "INFOAIM84,84,13,TuoiNuoc";
		}
		if (string_4.Contains("Hoàng Thổ Kỳ"))
		{
			return "INFOAIM62,38,11,TuoiNuoc";
		}
		if (string_4.Contains("Bạch Kim Kỳ"))
		{
			return "INFOAIM65,139,11,TuoiNuoc";
		}
		if (string_4.Contains("Thanh Mộc Kỳ"))
		{
			return "INFOAIM131,139,11,TuoiNuoc";
		}
		if (string_4.Contains("Hắc Thủy Kỳ"))
		{
			return "INFOAIM129,55,11,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_51}#{SMXL_090819_mingjiao}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM89,56,11,PhuongLap,PhuBan";
		}
		if (string_4.Contains("Đang Thanh Họa"))
		{
			return "INFOAIM142,59,14,TuoiNuoc";
		}
		if (string_4.Contains("Lạn Kha Kỳ"))
		{
			return "INFOAIM136,145,14,TuoiNuoc";
		}
		if (string_4.Contains("Phụng Hoàng Cầm"))
		{
			return "INFOAIM42,144,14,TuoiNuoc";
		}
		if (string_4.Contains("Thánh Hiền Thư"))
		{
			return "INFOAIM47,54,14,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_45}#{SMXL_090819_xiaoyao}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM62,68,14,PhungATam,PhuBan";
		}
		if (string_4.Contains("Kim Điện"))
		{
			return "INFOAIM82,58,12,TuoiNuoc";
		}
		if (string_4.Contains("Thiên Giới"))
		{
			return "INFOAIM45,87,12,TuoiNuoc";
		}
		if (string_4.Contains("Hồi Long Đài"))
		{
			return "INFOAIM76,133,12,TuoiNuoc";
		}
		if (string_4.Contains("Giải Kiếm Trì"))
		{
			return "INFOAIM49,180,12,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_39}#{SMXL_090819_wudang}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM58,73,12,LamLinhTo,PhuBan";
		}
		if (string_4.Contains("Nham Băng Hộ"))
		{
			return "INFOAIM125,50,17,TuoiNuoc";
		}
		if (string_4.Contains("Huyền Băng Hộ"))
		{
			return "INFOAIM65,43,17,TuoiNuoc";
		}
		if (string_4.Contains("Hàn Băng Hộ"))
		{
			return "INFOAIM71,65,17,TuoiNuoc";
		}
		if (string_4.Contains("Toái Băng Hộ"))
		{
			return "INFOAIM123,89,17,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_43}#{SMXL_090819_tianshan}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM101,44,17,CucKiem,PhuBan";
		}
		if (string_4.Contains("Chung Lâu"))
		{
			return "INFOAIM81,69,9,TuoiNuoc";
		}
		if (string_4.Contains("Đại Hùng Bảo Điện"))
		{
			return "INFOAIM96,82,9,TuoiNuoc";
		}
		if (string_4.Contains("Tàng Kinh Các"))
		{
			return "INFOAIM134,132,9,TuoiNuoc";
		}
		if (string_4.Contains("GSơn môn"))
		{
			return "INFOAIM90,110,9,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_35}#{SMXL_090819_shaolin}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM61,62,9,HuyenTrung,PhuBan";
		}
		if (string_4.Contains("Thiên Cơ Phường"))
		{
			return "INFOAIM56,136,615,TuoiNuoc";
		}
		if (string_4.Contains("Đường Gia Nội Bảo"))
		{
			return "INFOAIM80,46,615,TuoiNuoc";
		}
		if (string_4.Contains("Diễn Võ Trường"))
		{
			return "INFOAIM48,80,615,TuoiNuoc";
		}
		if (string_4.Contains("Phong Vũ Lâu"))
		{
			return "INFOAIM102,97,615,TuoiNuoc";
		}
		if (string_4.Contains("#{TMSM_130808_01}#") && string_4.Contains("#{SMRW_090206_01}"))
		{
			return "INFOAIM66,30,615,DuongNhacThien,Phuban";
		}
		string_4 = string_4.Replace("Ph.Hoàng", "Phụng Hoàng");
		if (string_4.Contains("Phật Quang Phụng Hoàng"))
		{
			return "INFOAIM39,152,15,TuoiNuoc";
		}
		if (string_4.Contains("Kim Đỉnh Phụng Hoàng"))
		{
			return "INFOAIM45,42,15,TuoiNuoc";
		}
		if (string_4.Contains("Linh Tuyền Phụng Hoàng"))
		{
			return "INFOAIM146,46,15,TuoiNuoc";
		}
		if (string_4.Contains("Vạn Niên Phụng Hoàng"))
		{
			return "INFOAIM146,156,15,TuoiNuoc";
		}
		if (string_4 == "#{SMFB_120214_37}#{SMXL_090819_emei}#r#{SMRW_090206_01}")
		{
			return "INFOAIM96,73,15,ManhThanhThanh,PhuBan";
		}
		if (string_4.Contains("Đỗ khang từ"))
		{
			return "INFOAIM131,112,10,TuoiNuoc";
		}
		if (string_4.Contains("Tiểu đào viên"))
		{
			return "INFOAIM39,147,10,TuoiNuoc";
		}
		if (string_4.Contains("Diễn binh đàn"))
		{
			return "INFOAIM46,36,10,TuoiNuoc";
		}
		if (string_4.Contains("Tây sương phòng"))
		{
			return "INFOAIM53,88,10,TuoiNuoc";
		}
		if (string_4 == "#{SMFB_120214_49}#{SMXL_090819_gaibang}#r#{SMRW_090206_01}")
		{
			return "INFOAIM41,144,10,PhatAn,PhuBan";
		}
		if (string_4.Contains("Rương Rết Độc"))
		{
			return "INFOAIM87,98,16,TuoiNuoc";
		}
		if (string_4.Contains("Rương Bọ Cạp Độc"))
		{
			return "INFOAIM127,73,16,TuoiNuoc";
		}
		if (string_4.Contains("Rương Nhện Độc"))
		{
			return "INFOAIM106,98,16,TuoiNuoc";
		}
		if (string_4.Contains("Rương Cóc Độc"))
		{
			return "INFOAIM95,56,16,TuoiNuoc";
		}
		if (string_4.Contains("#{SMFB_120214_33}#{SMXL_090819_xingxiu}#r#{SMRW_090206_01}"))
		{
			return "INFOAIM128,78,16,HongNgoc,PhuBan";
		}
		return string_4;
	}

	// Token: 0x06002A11 RID: 10769 RVA: 0x0012D864 File Offset: 0x0012BA64
	public static int smethod_18(string string_4)
	{
		string text = string.Empty;
		for (int i = 0; i < string_4.Length; i++)
		{
			if (char.IsDigit(string_4[i]))
			{
				text += string_4[i].ToString();
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return 0;
		}
		int num = 0;
		int.TryParse(text, out num);
		if (string_4.StartsWith("-"))
		{
			return 0 - num;
		}
		return num;
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
	public static int smethod_19(string string_4)
	{
		int num = 0;
		string text = string.Empty;
		for (int i = 0; i < string_4.Length; i++)
		{
			if (char.IsDigit(string_4[i]))
			{
				text += string_4[i].ToString();
			}
			else if (text.Length > 0)
			{
				break;
			}
		}
		if (text.Length > 0)
		{
			num = int.Parse(text);
		}
		return num;
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x0012D93C File Offset: 0x0012BB3C
	public static List<string> smethod_20(string string_4, string string_5, string string_6)
	{
		if (string_4 == null)
		{
			return null;
		}
		List<string> list = new List<string>();
		for (;;)
		{
			int num = string_4.IndexOf(string_5);
			if (num == -1)
			{
				break;
			}
			string text = string_4.Substring(num + string_5.Length);
			int num2 = text.IndexOf(string_6);
			if (num2 == -1)
			{
				break;
			}
			text = text.Substring(0, num2);
			list.Add(text);
			if (string_4.Length <= num + string_5.Length + text.Length + string_6.Length)
			{
				break;
			}
			string_4 = string_4.Substring(num + string_5.Length + text.Length + string_6.Length);
		}
		return list;
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x0012D9CC File Offset: 0x0012BBCC
	public static float smethod_21(string string_4, string string_5)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		if (string_4.Split(new char[] { ',' }).Length >= 2)
		{
			num = (float)Class531.smethod_19(string_4.Split(new char[] { ',' })[0]);
			num2 = (float)Class531.smethod_19(string_4.Split(new char[] { ',' })[1]);
		}
		if (string_5.Split(new char[] { ',' }).Length >= 2)
		{
			num3 = (float)Class531.smethod_19(string_5.Split(new char[] { ',' })[0]);
			num4 = (float)Class531.smethod_19(string_5.Split(new char[] { ',' })[1]);
		}
		return (float)Math.Sqrt(Math.Pow((double)(num - num3), 2.0) + Math.Pow((double)(num2 - num4), 2.0));
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x0001C698 File Offset: 0x0001A898
	public static float smethod_22(double double_0, double double_1, double double_2, double double_3)
	{
		return (float)Math.Sqrt(Math.Pow(double_0 - double_2, 2.0) + Math.Pow(double_1 - double_3, 2.0));
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x0012DAB0 File Offset: 0x0012BCB0
	public static int smethod_23(int int_0, int int_1)
	{
		int num = int_0 - int_1;
		if (num < 0)
		{
			num = -num;
		}
		return num;
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x0012DACC File Offset: 0x0012BCCC
	public static string smethod_24(string string_4)
	{
		string text = "";
		foreach (char c in string_4)
		{
			if (Class531.string_0.Contains(c))
			{
				text += c.ToString();
			}
		}
		return text;
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x0012DB18 File Offset: 0x0012BD18
	public static string smethod_25(int int_0)
	{
		string[] array = new string[]
		{
			"b", "c", "d", "f", "g", "h", "j", "k", "l", "m",
			"l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v",
			"w", "x"
		};
		string[] array2 = new string[] { "a", "e", "i", "o", "u", "ae", "y" };
		string text = "";
		text += array[Class531.Random_0.Next(array.Length)].ToUpper();
		text += array2[Class531.Random_0.Next(array2.Length)];
		for (int i = 2; i < int_0; i++)
		{
			text += array[Class531.Random_0.Next(array.Length)];
			i++;
			text += array2[Class531.Random_0.Next(array2.Length)];
		}
		return text;
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x0012DCA0 File Offset: 0x0012BEA0
	public static string smethod_26(string string_4)
	{
		for (int i = 1; i < Class531.string_3.Length; i++)
		{
			for (int j = 0; j < Class531.string_3[i].Length; j++)
			{
				string_4 = string_4.Replace(Class531.string_3[i][j], Class531.string_3[0][i - 1]);
			}
		}
		return string_4;
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x0001C6C3 File Offset: 0x0001A8C3
	public static bool smethod_27(string string_4, string string_5)
	{
		return string_5 != null && !(string_5 == "") && string_4.smethod_36().Contains(string_5.smethod_36());
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x0001C6ED File Offset: 0x0001A8ED
	public static bool smethod_28(Enum18 enum18_0)
	{
		return Convert.ToBoolean((int)Class531.GetKeyState(enum18_0) & 32768);
	}

	// Token: 0x06002A1C RID: 10780
	[DllImport("user32.dll")]
	private static extern short GetKeyState(Enum18 enum18_0);

	// Token: 0x04001D48 RID: 7496
	public static string string_0 = "aAeEoOuUiIdDyYáàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";

	// Token: 0x04001D49 RID: 7497
	[CompilerGenerated]
	private static Random random_0;

	// Token: 0x04001D4A RID: 7498
	private static string[] string_1 = new string[]
	{
		"copper", "iron", "silver", "coldiron", "gold", "weakironore", "crystal", "jade", "starstone", "arkonor",
		"mochastone"
	};

	// Token: 0x04001D4B RID: 7499
	private static string[] string_2 = new string[]
	{
		"whiteherb", "typha", "fritillarybulb", "poppy", "loquat", "liquorice", "goldenflower", "purpleflower", "medlar", "spicyleaf",
		"bark", "whiteflower", "tuckahoe", "mushroom", "ringcluster", "goldthread", "cylinderroot", "yellowbulb", "flatroot", "ageratum",
		"rosemary", "blackroot", "dogwood", "dragonflower", "rosewood", "panax", "tinderagaric", "poplar", "lotus", "cypress"
	};

	// Token: 0x04001D4C RID: 7500
	public static string[] string_3 = new string[]
	{
		"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
		"ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"
	};

	// Token: 0x020002F3 RID: 755
	[CompilerGenerated]
	[Serializable]
	private sealed class Class532
	{
		// Token: 0x06002A21 RID: 10785 RVA: 0x0001C70C File Offset: 0x0001A90C
		internal char method_0(string string_0)
		{
			return string_0[Class531.Random_0.Next(string_0.Length)];
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x0001C70C File Offset: 0x0001A90C
		internal char method_1(string string_0)
		{
			return string_0[Class531.Random_0.Next(string_0.Length)];
		}

		// Token: 0x04001D4D RID: 7501
		public static readonly Class531.Class532 f_104F3EEE = new Class531.Class532();

		// Token: 0x04001D4E RID: 7502
		public static Func<string, char> f_A947192D;

		// Token: 0x04001D4F RID: 7503
		public static Func<string, char> f_C151FEB9;
	}
}
