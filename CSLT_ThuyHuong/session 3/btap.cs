using System;

namespace BaiTapCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.InputEncoding = System.Text.Encoding.UTF8;

			Console.WriteLine("Chon bai tap (1-5): ");
			string chon = Console.ReadLine();

			if (chon == "1") Bai1();
			else if (chon == "2") Bai2();
			else if (chon == "3") Bai3();
			else if (chon == "4") Bai4();
			else if (chon == "5") Bai5();
			else Console.WriteLine("Khong co bai nay");
		}

		// Bai 1: Nhap 2 so, chon phep toan (+,-,*,/), hien thi ket qua
		static void Bai1()
		{
			Console.Write("Nhập số thứ nhất: ");
			double so1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Nhập số thứ hai: ");
			double so2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Chọn phép toán (+, -, *, /): ");
			string phepToan = Console.ReadLine().Trim();

			double ketQua = 0;
			bool hopLe = true;

			switch (phepToan)
			{
				case "+":
					ketQua = so1 + so2;
					break;
				case "-":
					ketQua = so1 - so2;
					break;
				case "*":
				case "x":
				case "X":
					ketQua = so1 * so2;
					break;
				case "/":
					if (so2 == 0)
					{
						Console.WriteLine("Lỗi: Không thể chia cho 0.");
						hopLe = false;
					}
					else
					{
						ketQua = so1 / so2;
					}
					break;
				default:
					Console.WriteLine("Phép toán không hợp lệ.");
					hopLe = false;
					break;
			}

			if (hopLe)
			{
				Console.WriteLine("Kết quả: " + so1 + " " + phepToan + " " + so2 + " = " + ketQua);
			}
		}

		// Bai 2: Hien thi cac gia tri cua ham x = y^2 + 2y + 1, voi y nguyen tu -5 den 5
		static void Bai2()
		{
			Console.WriteLine("Bảng giá trị hàm x = y^2 + 2y + 1 (y từ -5 đến 5):");
			Console.WriteLine("{0,-10}{1,-10}", "y", "x");

			for (int y = -5; y <= 5; y++)
			{
				int x = y * y + 2 * y + 1;
				Console.WriteLine("{0,-10}{1,-10}", y, x);
			}
		}

		// Bai 3: Nhap quang duong va thoi gian (gio, phut, giay), hien thi van toc km/h va miles/h
		static void Bai3()
		{
			Console.Write("Nhập quãng đường (km): ");
			double quangDuong = Convert.ToDouble(Console.ReadLine());

			Console.Write("Nhập thời gian - giờ: ");
			int gio = Convert.ToInt32(Console.ReadLine());

			Console.Write("Nhập thời gian - phút: ");
			int phut = Convert.ToInt32(Console.ReadLine());

			Console.Write("Nhập thời gian - giây: ");
			int giay = Convert.ToInt32(Console.ReadLine());

			double tongGio = gio + (phut / 60.0) + (giay / 3600.0);

			if (tongGio <= 0)
			{
				Console.WriteLine("Thời gian không hợp lệ.");
				return;
			}

			double vanTocKmH = quangDuong / tongGio;
			double vanTocMilesH = vanTocKmH * 0.621371;

			Console.WriteLine("Vận tốc: " + Math.Round(vanTocKmH, 2) + " km/h");
			Console.WriteLine("Vận tốc: " + Math.Round(vanTocMilesH, 2) + " miles/h");
		}

		// Bai 4: Nhap ban kinh hinh cau, tinh dien tich mat cau va the tich
		static void Bai4()
		{
			Console.Write("Nhập bán kính hình cầu (r): ");
			double banKinh = Convert.ToDouble(Console.ReadLine());

			if (banKinh < 0)
			{
				Console.WriteLine("Bán kính không hợp lệ.");
				return;
			}

			double dienTich = 4 * Math.PI * banKinh * banKinh;
			double theTich = (4.0 / 3.0) * Math.PI * Math.Pow(banKinh, 3);

			Console.WriteLine("Diện tích mặt cầu: " + Math.Round(dienTich, 2));
			Console.WriteLine("Thể tích hình cầu: " + Math.Round(theTich, 2));
		}

		// Bai 5: Nhap 1 ky tu, kiem tra la nguyen am, chu so, hay ky tu khac
		static void Bai5()
		{
			Console.Write("Nhập một ký tự: ");
			string chuoiNhap = Console.ReadLine();

			if (string.IsNullOrEmpty(chuoiNhap))
			{
				Console.WriteLine("Bạn chưa nhập ký tự nào.");
				return;
			}

			char kyTu = chuoiNhap[0];
			char kyTuThuong = char.ToLower(kyTu);

			if (kyTuThuong == 'a' || kyTuThuong == 'e' || kyTuThuong == 'i' ||
				kyTuThuong == 'o' || kyTuThuong == 'u')
			{
				Console.WriteLine("'" + kyTu + "' là nguyên âm (vowel).");
			}
			else if (char.IsDigit(kyTu))
			{
				Console.WriteLine("'" + kyTu + "' là chữ số (digit).");
			}
			else if (char.IsLetter(kyTu))
			{
				Console.WriteLine("'" + kyTu + "' là phụ âm (consonant).");
			}
			else
			{
				Console.WriteLine("'" + kyTu + "' là ký hiệu khác (symbol).");
			}
		}
	}
}