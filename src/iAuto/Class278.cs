using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000195 RID: 405
internal class Class278
{
	// Token: 0x0600173D RID: 5949 RVA: 0x00010155 File Offset: 0x0000E355
	public void method_0(int int_0, int int_1)
	{
		this.method_2(Class278.smethod_0(int_0), Class278.smethod_0(int_1));
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00010169 File Offset: 0x0000E369
	public void method_1()
	{
		this.list_0.Clear();
		this.hashSet_0.Clear();
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x000BE184 File Offset: 0x000BC384
	public void method_2(string string_0, string string_1)
	{
		Queue<List<string>> queue = new Queue<List<string>>();
		queue.Enqueue(new List<string>(1) { string_0 });
		while (queue.Count > 0)
		{
			List<string> list = queue.Dequeue();
			string text = list.Last<string>();
			if (string_1 == text)
			{
				this.list_0 = list;
				return;
			}
			if (!this.hashSet_0.Contains(text))
			{
				this.hashSet_0.Add(text);
				if (text != null)
				{
					switch (text.Length)
					{
					case 4:
						if (text == "vodi")
						{
							this.method_3(queue, list, new string[] { "tayho", "mailinh", "namhai", "hoanglongdong" });
						}
						break;
					case 5:
					{
						char c = text[0];
						if (c != 'd')
						{
							if (c == 't')
							{
								if (text == "tayho")
								{
									this.method_3(queue, list, new string[] { "tochau", "longtuyen", "vodi" });
								}
							}
						}
						else if (text == "daily")
						{
							this.method_3(queue, list, new string[]
							{
								"nhihai", "kiemcac", "voluongson", "laulan", "thieulam", "minhgiao", "caibang", "vodang", "thienlong", "tieudao",
								"ngamy", "tinhtuc", "thienson", "modung", "quycoc", "daohoa", "duongmon", "tuyettinh"
							});
						}
						break;
					}
					case 6:
					{
						char c = text[2];
						if (c <= 'i')
						{
							switch (c)
							{
							case 'a':
								if (text == "thaiho")
								{
									this.method_3(queue, list, new string[] { "tungson", "tochau" });
								}
								break;
							case 'b':
							case 'd':
								break;
							case 'c':
								if (text == "tochau")
								{
									this.method_3(queue, list, new string[]
									{
										"thaiho", "tayho", "kinhho", "laulan", "thieulam", "minhgiao", "caibang", "vodang", "thienlong", "tieudao",
										"ngamy", "tinhtuc", "thienson", "modung", "quycoc", "daohoa", "duongmon", "tuyettinh"
									});
								}
								break;
							case 'e':
								if (text == "diemho")
								{
									this.method_3(queue, list, new string[] { "thachlam", "diemkhanh" });
								}
								break;
							default:
								if (c == 'i')
								{
									if (text == "nhihai")
									{
										this.method_3(queue, list, new string[] { "daily", "thuongson", "thachlam" });
									}
								}
								break;
							}
						}
						else if (c != 'm')
						{
							if (c == 'n')
							{
								if (text == "kinhho")
								{
									this.method_3(queue, list, new string[] { "tochau", "voluongson" });
								}
							}
						}
						else if (text == "namhai")
						{
							this.method_3(queue, list, new string[] { "quynhchau", "vodi", "haitacdong" });
						}
						break;
					}
					case 7:
					{
						char c = text[4];
						if (c <= 'i')
						{
							if (c != 'b')
							{
								if (c != 'c')
								{
									if (c == 'i')
									{
										if (text == "mailinh")
										{
											this.method_3(queue, list, new string[] { "vodi", "mieunhandong" });
										}
									}
								}
								else if (text == "kiemcac")
								{
									this.method_3(queue, list, new string[] { "donhoang", "daily" });
								}
							}
							else if (text == "nhanbac")
							{
								this.method_3(queue, list, new string[] { "nhannam", "thaolieutruong", "como1" });
							}
						}
						else if (c <= 's')
						{
							if (c != 'n')
							{
								if (c == 's')
								{
									if (text == "tungson")
									{
										this.method_3(queue, list, new string[] { "lacduong", "thaiho" });
									}
								}
							}
							else if (text == "nhannam")
							{
								this.method_3(queue, list, new string[] { "lacduong", "nhanbac", "thaonguyen" });
							}
						}
						else if (c != 't')
						{
							if (c == 'y')
							{
								if (text == "daiuyen")
								{
									this.method_3(queue, list, new string[] { "laulan", "hanhuyetlinh", "tatmanhihan" });
								}
							}
						}
						else if (text == "lieutay")
						{
							this.method_3(queue, list, new string[] { "thaonguyen", "nganngaituyetnguyen", "tienvuongphan" });
						}
						break;
					}
					case 8:
					{
						char c = text[0];
						if (c <= 'd')
						{
							if (c != 'c')
							{
								if (c == 'd')
								{
									if (text == "donhoang")
									{
										this.method_3(queue, list, new string[] { "lacduong", "kiemcac" });
									}
								}
							}
							else if (text == "caoxuong")
							{
								this.method_3(queue, list, new string[] { "caoxuongmecung", "hoadiemson" });
							}
						}
						else if (c != 'l')
						{
							if (c != 'n')
							{
								if (c == 't')
								{
									if (text == "thachlam")
									{
										this.method_3(queue, list, new string[] { "nhihai", "ngockhue", "namchieu", "diemho" });
									}
								}
							}
							else if (!(text == "ngockhue"))
							{
								if (text == "namchieu")
								{
									this.method_3(queue, list, new string[] { "thachlam", "mieucuong" });
								}
							}
							else
							{
								this.method_3(queue, list, new string[] { "thachlam", "daohoanguyen" });
							}
						}
						else if (text == "lacduong")
						{
							this.method_3(queue, list, new string[]
							{
								"donhoang", "nhannam", "tungson", "laulan", "thieulam", "minhgiao", "caibang", "vodang", "thienlong", "tieudao",
								"ngamy", "tinhtuc", "thienson", "modung", "quycoc", "daohoa", "duongmon", "tuyettinh"
							});
						}
						break;
					}
					case 9:
					{
						char c = text[0];
						if (c <= 'l')
						{
							if (c != 'd')
							{
								if (c == 'l')
								{
									if (text == "longtuyen")
									{
										this.method_3(queue, list, new string[] { "tayho" });
									}
								}
							}
							else if (text == "diemkhanh")
							{
								this.method_3(queue, list, new string[] { "diemho" });
							}
						}
						else if (c != 'm')
						{
							if (c != 'q')
							{
								if (c == 't')
								{
									if (text == "thuongson")
									{
										this.method_3(queue, list, new string[] { "nhihai" });
									}
								}
							}
							else if (text == "quynhchau")
							{
								this.method_3(queue, list, new string[] { "namhai" });
							}
						}
						else if (text == "mieucuong")
						{
							this.method_3(queue, list, new string[] { "namchieu" });
						}
						break;
					}
					case 10:
					{
						char c = text[3];
						if (c <= 'e')
						{
							if (c != 'd')
							{
								if (c == 'e')
								{
									if (text == "huyenvudao")
									{
										this.method_3(queue, list, new string[] { "thanhthuson" });
									}
								}
							}
							else if (!(text == "hoadiemson"))
							{
								if (text == "hoadiemcoc")
								{
									this.method_3(queue, list, new string[] { "hoadiemson" });
								}
							}
							else
							{
								this.method_3(queue, list, new string[] { "caoxuong", "hoadiemcoc" });
							}
						}
						else if (c != 'o')
						{
							if (c != 't')
							{
								if (c == 'u')
								{
									if (text == "voluongson")
									{
										this.method_3(queue, list, new string[] { "daily", "kinhho" });
									}
								}
							}
							else if (text == "haitacdong")
							{
								this.method_3(queue, list, new string[] { "namhai" });
							}
						}
						else if (text == "thaonguyen")
						{
							this.method_3(queue, list, new string[] { "lieutay", "nhannam", "truongbachson" });
						}
						break;
					}
					case 11:
						if (text == "tatmanhihan")
						{
							this.method_3(queue, list, new string[] { "daiuyen", "thanhhoacung" });
						}
						break;
					case 12:
					{
						char c = text[4];
						if (c <= 'h')
						{
							if (c != 'g')
							{
								if (c == 'h')
								{
									if (text == "thanhhoacung")
									{
										this.method_3(queue, list, new string[] { "tatmanhihan" });
									}
								}
							}
							else if (text == "hoanglongphu")
							{
								this.method_3(queue, list, new string[] { "truongbachson" });
							}
						}
						else if (c != 'n')
						{
							if (c != 'o')
							{
								if (c == 'u')
								{
									if (text == "hanhuyetlinh")
									{
										this.method_3(queue, list, new string[] { "daiuyen" });
									}
								}
							}
							else if (text == "daohoanguyen")
							{
								this.method_3(queue, list, new string[] { "ngockhue" });
							}
						}
						else if (text == "mieunhandong")
						{
							this.method_3(queue, list, new string[] { "mailinh" });
						}
						break;
					}
					case 13:
					{
						char c = text[1];
						if (c != 'i')
						{
							if (c == 'r')
							{
								if (text == "truongbachson")
								{
									this.method_3(queue, list, new string[] { "thaonguyen", "hoanglongphu" });
								}
							}
						}
						else if (text == "tienvuongphan")
						{
							this.method_3(queue, list, new string[] { "lieutay" });
						}
						break;
					}
					case 19:
						if (text == "nganngaituyetnguyen")
						{
							this.method_3(queue, list, new string[] { "lieutay" });
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
	private void method_3(Queue<List<string>> queue_0, List<string> list_1, params string[] string_0)
	{
		foreach (string text in string_0)
		{
			if (!this.hashSet_0.Contains(text))
			{
				List<string> list = new List<string>(1 + list_1.Count);
				list.AddRange(list_1);
				list.Add(text);
				List<string> list2 = list;
				queue_0.Enqueue(list2);
			}
		}
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00010181 File Offset: 0x0000E381
	public string method_4(string string_0, string string_1)
	{
		if (this.dictionary_1.ContainsKey(string_0) && this.dictionary_1[string_0].ContainsKey(string_1))
		{
			return this.dictionary_1[string_0][string_1];
		}
		return "0,0";
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x000101BD File Offset: 0x0000E3BD
	public static string smethod_0(int int_0)
	{
		if (Class278.dictionary_0.ContainsKey(int_0))
		{
			return Class278.dictionary_0[int_0];
		}
		return "";
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x000BEE28 File Offset: 0x000BD028
	public Class278()
	{
		Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
		dictionary["huyenvudao"] = new Dictionary<string, string> { { "thanhthuson", "290,60" } };
		dictionary["kinhho"] = new Dictionary<string, string>
		{
			{ "tochau", "285,44" },
			{ "voluongson", "38,284" }
		};
		dictionary["voluongson"] = new Dictionary<string, string>
		{
			{ "daily", "32,176" },
			{ "kinhho", "287,77" }
		};
		dictionary["daily"] = new Dictionary<string, string>
		{
			{ "nhihai", "160,295" },
			{ "kiemcac", "31,151" },
			{ "voluongson", "288,151" }
		};
		dictionary["nhihai"] = new Dictionary<string, string>
		{
			{ "daily", "287,32" },
			{ "thachlam", "34,279" },
			{ "thuongson", "34,157" }
		};
		dictionary["thuongson"] = new Dictionary<string, string> { { "nhihai", "286,56" } };
		dictionary["thachlam"] = new Dictionary<string, string>
		{
			{ "nhihai", "268,128" },
			{ "ngockhue", "112,34" },
			{ "namchieu", "33,250" },
			{ "diemho", "37,273" }
		};
		dictionary["ngockhue"] = new Dictionary<string, string>
		{
			{ "thachlam", "36,46" },
			{ "daohoanguyen", "54,167" }
		};
		dictionary["namchieu"] = new Dictionary<string, string>
		{
			{ "thachlam", "280,45" },
			{ "mieucuong", "106,285" }
		};
		dictionary["mieucuong"] = new Dictionary<string, string> { { "namchieu", "67,32" } };
		dictionary["kiemcac"] = new Dictionary<string, string>
		{
			{ "daily", "36,286" },
			{ "donhoang", "105,40" }
		};
		dictionary["donhoang"] = new Dictionary<string, string>
		{
			{ "kiemcac", "231,286" },
			{ "lacduong", "284,146" }
		};
		dictionary["lacduong"] = new Dictionary<string, string>
		{
			{ "donhoang", "33,130" },
			{ "nhannam", "286,129" },
			{ "tungson", "159,287" }
		};
		dictionary["nhannam"] = new Dictionary<string, string>
		{
			{ "lacduong", "264,286" },
			{ "nhanbac", "248,37" },
			{ "thaonguyen", "33,58" }
		};
		dictionary["nhanbac"] = new Dictionary<string, string>
		{
			{ "nhannam", "228,280" },
			{ "thaolieutruong", "59,60" },
			{ "como1", "139,259" }
		};
		dictionary["thaolieutruong"] = new Dictionary<string, string> { { "nhanbac", "23,228" } };
		dictionary["thaonguyen"] = new Dictionary<string, string>
		{
			{ "lieutay", "119,32" },
			{ "nhannam", "287,258" },
			{ "truongbachson", "271,33" }
		};
		dictionary["lieutay"] = new Dictionary<string, string>
		{
			{ "thaonguyen", "61,297" },
			{ "nganngaituyetnguyen", "286,44" },
			{ "tienvuongphan", "37,211" }
		};
		dictionary["nganngaituyetnguyen"] = new Dictionary<string, string> { { "lieutay", "59,228" } };
		dictionary["truongbachson"] = new Dictionary<string, string>
		{
			{ "thaonguyen", "33,269" },
			{ "hoanglongphu", "286,73" }
		};
		dictionary["hoanglongphu"] = new Dictionary<string, string> { { "truongbachson", "48,287" } };
		dictionary["tungson"] = new Dictionary<string, string>
		{
			{ "lacduong", "34,55" },
			{ "thaiho", "286,247" }
		};
		dictionary["thaiho"] = new Dictionary<string, string>
		{
			{ "tungson", "91,23" },
			{ "tochau", "215,281" }
		};
		dictionary["tochau"] = new Dictionary<string, string>
		{
			{ "tayho", "182,287" },
			{ "thaiho", "182,33" },
			{ "kinhho", "32,162" }
		};
		dictionary["tayho"] = new Dictionary<string, string>
		{
			{ "tochau", "34,50" },
			{ "longtuyen", "287,54" },
			{ "vodi", "265,286" }
		};
		dictionary["longtuyen"] = new Dictionary<string, string> { { "tayho", "34,274" } };
		dictionary["vodi"] = new Dictionary<string, string>
		{
			{ "tayho", "36,33" },
			{ "mailinh", "283,180" },
			{ "namhai", "248,286" }
		};
		dictionary["mailinh"] = new Dictionary<string, string>
		{
			{ "vodi", "33,275" },
			{ "mieunhandong", "192,279" }
		};
		dictionary["namhai"] = new Dictionary<string, string>
		{
			{ "vodi", "34,36" },
			{ "quynhchau", "286,174" },
			{ "haitacdong", "70,188" }
		};
		dictionary["quynhchau"] = new Dictionary<string, string> { { "namhai", "279,286" } };
		dictionary["laulan"] = new Dictionary<string, string>
		{
			{ "daiuyen", "21,143" },
			{ "thaplymoc", "160,307" },
			{ "caoxuong", "298,142" }
		};
		dictionary["caoxuong"] = new Dictionary<string, string>
		{
			{ "caoxuongmecung", "72,144" },
			{ "hoadiemson", "229,221" }
		};
		dictionary["hoadiemson"] = new Dictionary<string, string>
		{
			{ "caoxuong", "20,237" },
			{ "hoadiemcoc", "26,103" }
		};
		dictionary["hoadiemcoc"] = new Dictionary<string, string> { { "hoadiemson", "68,23" } };
		dictionary["daiuyen"] = new Dictionary<string, string>
		{
			{ "laulan", "195,235" },
			{ "hanhuyetlinh", "20,210" },
			{ "tatmanhihan", "47,21" }
		};
		dictionary["tatmanhihan"] = new Dictionary<string, string>
		{
			{ "daiuyen", "42,231" },
			{ "thanhhoacung", "72,30" }
		};
		dictionary["thanhhoacung"] = new Dictionary<string, string> { { "tatmanhihan", "24,106" } };
		dictionary["hanhuyetlinh"] = new Dictionary<string, string> { { "daiuyen", "96,87" } };
		dictionary["mieunhandong"] = new Dictionary<string, string> { { "mailinh", "89,242" } };
		dictionary["daohoanguyen"] = new Dictionary<string, string> { { "ngockhue", "20,19" } };
		dictionary["tienvuongphan"] = new Dictionary<string, string> { { "lieutay", "127,19" } };
		dictionary["haitacdong"] = new Dictionary<string, string> { { "namhai", "42,228" } };
		dictionary["diemho"] = new Dictionary<string, string>
		{
			{ "thachlam", "49,12" },
			{ "diemkhanh", "231,169" }
		};
		dictionary["diemkhanh"] = new Dictionary<string, string> { { "diemho", "100,98" } };
		this.dictionary_1 = dictionary;
		this.list_0 = new List<string>();
		this.hashSet_0 = new HashSet<string>();
	}

	// Token: 0x04000EA9 RID: 3753
	private static readonly Dictionary<int, string> dictionary_0 = new Dictionary<int, string>
	{
		{ 112, "huyenvudao" },
		{ 201, "thanhthuson" },
		{ 0, "lacduong" },
		{ 1, "tochau" },
		{ 2, "daily" },
		{ 3, "tungson" },
		{ 4, "thaiho" },
		{ 5, "kinhho" },
		{ 6, "voluongson" },
		{ 7, "kiemcac" },
		{ 8, "donhoang" },
		{ 18, "nhannam" },
		{ 19, "nhanbac" },
		{ 20, "thaonguyen" },
		{ 21, "lieutay" },
		{ 22, "truongbachson" },
		{ 23, "hoanglongphu" },
		{ 24, "nhihai" },
		{ 25, "thuongson" },
		{ 26, "thachlam" },
		{ 27, "ngockhue" },
		{ 28, "namchieu" },
		{ 29, "mieucuong" },
		{ 30, "tayho" },
		{ 31, "longtuyen" },
		{ 32, "vodi" },
		{ 33, "mailinh" },
		{ 216, "hoanglongdong" },
		{ 246, "laulan" },
		{ 34, "namhai" },
		{ 35, "quynhchau" },
		{ 199, "thaolieutruong" },
		{ 9, "thieulam" },
		{ 11, "minhgiao" },
		{ 10, "caibang" },
		{ 12, "vodang" },
		{ 13, "thienlong" },
		{ 14, "tieudao" },
		{ 15, "ngamy" },
		{ 16, "tinhtuc" },
		{ 17, "thienson" },
		{ 284, "modung" },
		{ 678, "quycoc" },
		{ 731, "daohoa" },
		{ 615, "duongmon" },
		{ 824, "tuyettinh" },
		{ 244, "hoadiemson" },
		{ 245, "caoxuong" },
		{ 247, "thaplymoc" },
		{ 249, "daiuyen" },
		{ 250, "tatmanhihan" },
		{ 251, "hoadiemcoc" },
		{ 252, "caoxuongmecung" },
		{ 255, "hanhuyetlinh" },
		{ 256, "thanhhoacung" },
		{ 229, "nganngaituyetnguyen" },
		{ 200, "mieunhandong" },
		{ 202, "como1" },
		{ 220, "daohoanguyen" },
		{ 218, "tienvuongphan" },
		{ 221, "haitacdong" },
		{ 235, "diemho" },
		{ 237, "diemkhanh" }
	};

	// Token: 0x04000EAA RID: 3754
	private readonly Dictionary<string, Dictionary<string, string>> dictionary_1;

	// Token: 0x04000EAB RID: 3755
	public List<string> list_0;

	// Token: 0x04000EAC RID: 3756
	public HashSet<string> hashSet_0;
}
