using System;

namespace BaiTapBuoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Chon bai tap (1-10): ");
            string chon = Console.ReadLine();

            if (chon == "1") Bai1();
            else if (chon == "2") Bai2();
            else if (chon == "3") Bai3();
            else if (chon == "4") Bai4();
            else if (chon == "5") Bai5();
            else if (chon == "6") Bai6();
            else if (chon == "7") Bai7();
            else if (chon == "8") Bai8();
            else if (chon == "9") Bai9();
            else if (chon == "10") Bai10();
            else Console.WriteLine("Khong co bai nay");
        }

        static void Bai1()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            int chiSoCu = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhập chỉ số điện mới (kWh): ");
            int chiSoMoi = Convert.ToInt32(Console.ReadLine());

            if (chiSoMoi < chiSoCu)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            }
            else
            {
                int soDien = chiSoMoi - chiSoCu;
                decimal tienDien = 0;

                if (soDien <= 50)
                {
                    tienDien = soDien * 1.806m;
                }
                else if (soDien <= 100)
                {
                    tienDien = 50 * 1.806m + (soDien - 50) * 1.866m;
                }
                else if (soDien <= 200)
                {
                    tienDien = 50 * 1.806m + 50 * 1.866m + (soDien - 100) * 2.167m;
                }
                else if (soDien <= 300)
                {
                    tienDien = 50 * 1.806m + 50 * 1.866m + 100 * 2.167m + (soDien - 200) * 2.729m;
                }
                else
                {
                    tienDien = 50 * 1.806m + 50 * 1.866m + 100 * 2.167m + 100 * 2.729m + (soDien - 300) * 3.050m;
                }

                decimal thueVat = tienDien * 0.08m;
                decimal tongTien = tienDien + thueVat;

                Console.WriteLine("Số điện tiêu thụ: " + soDien + " kWh");
                Console.WriteLine("Tiền điện chưa thuế: " + tienDien.ToString("#,##0") + " VNĐ");
                Console.WriteLine("Thuế VAT (8%): " + thueVat.ToString("#,##0") + " VNĐ");
                Console.WriteLine("Tổng thanh toán: " + tongTien.ToString("#,##0") + " VNĐ");
            }
        }

        static void Bai2()
        {
            Console.Write("Chiều cao (m): ");
            double chieuCao = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Cân nặng (kg): ");
            double canNang = Convert.ToDouble(Console.ReadLine());

            double bmi = canNang / (chieuCao * chieuCao);
            Console.WriteLine("Chỉ số BMI của bạn: " + Math.Round(bmi, 2));

            if (bmi < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe: Gầy (Thiếu cân)");
            }
            else if (bmi >= 18.5 && bmi < 23.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Bình thường (Lý tưởng)");
            }
            else if (bmi >= 23.0 && bmi < 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Thừa cân (Tiền béo phì)");
            }
            else
            {
                Console.WriteLine("Phân loại sức khỏe: Béo phì");
            }

            double canNangMin = 18.5 * chieuCao * chieuCao;
            double canNangMax = 22.9 * chieuCao * chieuCao;
            
            Console.WriteLine("Khuyên dùng: Cân nặng lý tưởng của bạn nên từ " + Math.Round(canNangMin, 2) + " kg đến " + Math.Round(canNangMax, 2) + " kg.");
        }

        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4
        }

        static void Bai3()
        {
            Console.Write("Nhập số tiền VNĐ: ");
            decimal soTienVnd = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int chon = Convert.ToInt32(Console.ReadLine());

            decimal phiDichVu = soTienVnd * 0.005m;
            decimal tienThucTe = soTienVnd - phiDichVu;

            Console.WriteLine("Phí dịch vụ (0.5%): " + phiDichVu.ToString("#,##0") + " VNĐ");
            Console.WriteLine("Số tiền VNĐ tính đổi: " + tienThucTe.ToString("#,##0") + " VNĐ");

            CurrencyType loaiTien = (CurrencyType)chon;
            
            if (loaiTien == CurrencyType.USD)
            {
                decimal tienUsd = tienThucTe / 25400m;
                Console.WriteLine("Số tiền USD nhận được: " + Math.Round(tienUsd, 2) + " USD");
            }
            else if (loaiTien == CurrencyType.EUR)
            {
                decimal tienEur = tienThucTe / 27200m;
                Console.WriteLine("Số tiền EUR nhận được: " + Math.Round(tienEur, 2) + " EUR");
            }
            else if (loaiTien == CurrencyType.JPY)
            {
                decimal tienJpy = tienThucTe / 165m;
                Console.WriteLine("Số tiền JPY nhận được: " + Math.Round(tienJpy, 2) + " JPY");
            }
            else if (loaiTien == CurrencyType.GBP)
            {
                decimal tienGbp = tienThucTe / 32100m;
                Console.WriteLine("Số tiền GBP nhận được: " + Math.Round(tienGbp, 2) + " GBP");
            }
        }

        static void Bai4()
        {
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string chuoiNgaySinh = Console.ReadLine();
            
            DateTime ngaySinh = DateTime.ParseExact(chuoiNgaySinh, "dd/MM/yyyy", null);
            DateTime ngayHienTai = DateTime.Now.Date;

            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngaySinh.Date > ngayHienTai.AddYears(-tuoi))
            {
                tuoi = tuoi - 1;
            }

            Console.WriteLine("Tuổi hiện tại: " + tuoi + " tuổi");

            TimeSpan thoiGianDaSong = ngayHienTai - ngaySinh;
            Console.WriteLine("Bạn đã sống tổng cộng: " + thoiGianDaSong.TotalDays + " ngày");

            DateTime sinhNhatNamNay = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatNamNay < ngayHienTai)
            {
                sinhNhatNamNay = sinhNhatNamNay.AddYears(1);
            }

            TimeSpan conLai = sinhNhatNamNay - ngayHienTai;
            Console.WriteLine("Sinh nhật tiếp theo còn: " + conLai.TotalDays + " ngày nữa");
        }

        static void Bai5()
        {
            Console.Write("C# (4 TC): ");
            double diemCsharp = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Toán (3 TC): ");
            double diemToan = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Tiếng Anh (2 TC): ");
            double diemAnh = Convert.ToDouble(Console.ReadLine());

            double diemTrungBinh = (diemCsharp * 4 + diemToan * 3 + diemAnh * 2) / (4 + 3 + 2);
            Console.WriteLine("Điểm TB Thang 10: " + Math.Round(diemTrungBinh, 2));

            if (diemTrungBinh >= 8.5)
            {
                Console.WriteLine("Điểm Chữ Quy Đổi: A");
                Console.WriteLine("Điểm GPA Thang 4: 4.0");
                Console.WriteLine("Xếp Loại Học Lực: Xuất sắc / Giỏi");
            }
            else if (diemTrungBinh >= 7.0)
            {
                Console.WriteLine("Điểm Chữ Quy Đổi: B");
                Console.WriteLine("Điểm GPA Thang 4: 3.0");
                Console.WriteLine("Xếp Loại Học Lực: Khá");
            }
            else if (diemTrungBinh >= 5.5)
            {
                Console.WriteLine("Điểm Chữ Quy Đổi: C");
                Console.WriteLine("Điểm GPA Thang 4: 2.0");
                Console.WriteLine("Xếp Loại Học Lực: Trung bình");
            }
            else if (diemTrungBinh >= 4.0)
            {
                Console.WriteLine("Điểm Chữ Quy Đổi: D");
                Console.WriteLine("Điểm GPA Thang 4: 1.0");
                Console.WriteLine("Xếp Loại Học Lực: Yếu");
            }
            else
            {
                Console.WriteLine("Điểm Chữ Quy Đổi: F");
                Console.WriteLine("Điểm GPA Thang 4: 0.0");
                Console.WriteLine("Xếp Loại Học Lực: Kém (Trượt)");
            }
        }

        static void Bai6()
        {
            Console.Write("Nhập họ tên thô: ");
            string hoTenTho = Console.ReadLine();
            
            hoTenTho = hoTenTho.Trim();
            
            string[] mangChu = hoTenTho.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            string hoTenChuan = "";
            for (int i = 0; i < mangChu.Length; i++)
            {
                string chu = mangChu[i];
                string chuDau = chu.Substring(0, 1).ToUpper();
                string chuSau = chu.Substring(1).ToLower();
                hoTenChuan += chuDau + chuSau + " ";
            }
            
            hoTenChuan = hoTenChuan.Trim();
            Console.WriteLine("Họ tên chuẩn hóa: " + hoTenChuan);

            string ho = mangChu[0];
            string ten = mangChu[mangChu.Length - 1];
            
            string tenDem = "";
            for (int i = 1; i < mangChu.Length - 1; i++)
            {
                tenDem += mangChu[i] + " ";
            }
            tenDem = tenDem.Trim();

            Console.WriteLine("Họ: " + ho + " | Tên đệm: " + tenDem + " | Tên: " + ten);

            string userGoc = (ten + "." + ho + tenDem.Replace(" ", "")).ToLower();
            string userKhongDau = userGoc
                .Replace("á", "a").Replace("à", "a").Replace("ả", "a").Replace("ã", "a").Replace("ạ", "a")
                .Replace("ă", "a").Replace("ắ", "a").Replace("ằ", "a").Replace("ẳ", "a").Replace("ẵ", "a").Replace("ặ", "a")
                .Replace("â", "a").Replace("ấ", "a").Replace("ầ", "a").Replace("ẩ", "a").Replace("ẫ", "a").Replace("ậ", "a")
                .Replace("é", "e").Replace("è", "e").Replace("ẻ", "e").Replace("ẽ", "e").Replace("ẹ", "e")
                .Replace("ê", "e").Replace("ế", "e").Replace("ề", "e").Replace("ể", "e").Replace("ễ", "e").Replace("ệ", "e")
                .Replace("í", "i").Replace("ì", "i").Replace("ỉ", "i").Replace("ĩ", "i").Replace("ị", "i")
                .Replace("ó", "o").Replace("ò", "o").Replace("ỏ", "o").Replace("õ", "o").Replace("ọ", "o")
                .Replace("ô", "o").Replace("ố", "o").Replace("ồ", "o").Replace("ổ", "o").Replace("ỗ", "o").Replace("ộ", "o")
                .Replace("ơ", "o").Replace("ớ", "o").Replace("ờ", "o").Replace("ở", "o").Replace("ỡ", "o").Replace("ợ", "o")
                .Replace("ú", "u").Replace("ù", "u").Replace("ủ", "u").Replace("ũ", "u").Replace("ụ", "u")
                .Replace("ư", "u").Replace("ứ", "u").Replace("ừ", "u").Replace("ử", "u").Replace("ữ", "u").Replace("ự", "u")
                .Replace("ý", "y").Replace("ỳ", "y").Replace("ỷ", "y").Replace("ỹ", "y").Replace("ỵ", "y")
                .Replace("đ", "d");

            Console.WriteLine("Username tạo tự động: " + userKhongDau);
            Console.WriteLine("Email cấp phát: " + userKhongDau + "@company.edu.vn");
        }

        static void Bai7()
        {
            Console.Write("Quãng đường (km): ");
            double quangDuong = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Mức tiêu hao (L/100km): ");
            double mucTieuHao = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal giaXang = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Số người đi: ");
            int soNguoi = Convert.ToInt32(Console.ReadLine());

            double soLitXang = (quangDuong / 100) * mucTieuHao;
            decimal tongTienXang = (decimal)soLitXang * giaXang;
            
            decimal tienMoiNguoi = tongTienXang / soNguoi;
            tienMoiNguoi = Math.Ceiling(tienMoiNguoi / 1000) * 1000;

            Console.WriteLine("Tổng nhiên liệu tiêu thụ: " + Math.Round(soLitXang, 2) + " Lít");
            Console.WriteLine("Tổng chi phí xăng dầu: " + tongTienXang.ToString("#,##0") + " VNĐ");
            Console.WriteLine("Chi phí mỗi người: " + tienMoiNguoi.ToString("#,##0") + " VNĐ");
        }

        static void Bai8()
        {
            string maOtpDung = "839201";
            DateTime thoiGianTao = DateTime.Now;
            
            Console.Write("Mã OTP nhận được: ");
            string maNhap = Console.ReadLine();
            
            Console.Write("Thời gian trôi qua (giây): ");
            int giayTroiQua = Convert.ToInt32(Console.ReadLine());
            
            DateTime thoiGianXacThuc = thoiGianTao.AddSeconds(giayTroiQua);

            bool laSo = int.TryParse(maNhap, out int ketQua);

            if (maNhap.Length != 6 || laSo == false)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Định dạng không hợp lệ.");
            }
            else if (maNhap != maOtpDung)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Mã OTP sai.");
            }
            else
            {
                TimeSpan thoiGianDaQua = thoiGianXacThuc - thoiGianTao;
                if (thoiGianDaQua.TotalSeconds > 300)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Hết hạn OTP.");
                }
                else
                {
                    Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
                }
            }
        }

        static void Bai9()
        {
            Console.Write("Lương Gross (VNĐ): ");
            decimal luongGross = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Số người phụ thuộc: ");
            int nguoiPhuThuoc = Convert.ToInt32(Console.ReadLine());

            decimal baoHiem = luongGross * 0.105m;
            decimal giamTru = 11000000m + (nguoiPhuThuoc * 4400000m);
            decimal thuNhapChiuThue = luongGross - baoHiem - giamTru;

            if (thuNhapChiuThue < 0)
            {
                thuNhapChiuThue = 0;
            }

            decimal thueTncn = 0;
            decimal thuNhapConLai = thuNhapChiuThue;

            if (thuNhapConLai > 80000000)
            {
                thueTncn += (thuNhapConLai - 80000000) * 0.35m;
                thuNhapConLai = 80000000;
            }
            if (thuNhapConLai > 52000000)
            {
                thueTncn += (thuNhapConLai - 52000000) * 0.30m;
                thuNhapConLai = 52000000;
            }
            if (thuNhapConLai > 32000000)
            {
                thueTncn += (thuNhapConLai - 32000000) * 0.25m;
                thuNhapConLai = 32000000;
            }
            if (thuNhapConLai > 18000000)
            {
                thueTncn += (thuNhapConLai - 18000000) * 0.20m;
                thuNhapConLai = 18000000;
            }
            if (thuNhapConLai > 10000000)
            {
                thueTncn += (thuNhapConLai - 10000000) * 0.15m;
                thuNhapConLai = 10000000;
            }
            if (thuNhapConLai > 5000000)
            {
                thueTncn += (thuNhapConLai - 5000000) * 0.10m;
                thuNhapConLai = 5000000;
            }
            if (thuNhapConLai > 0)
            {
                thueTncn += thuNhapConLai * 0.05m;
            }

            decimal luongNet = luongGross - baoHiem - thueTncn;

            Console.WriteLine("Giảm trừ Bảo hiểm (10.5%): " + baoHiem.ToString("#,##0") + " VNĐ");
            Console.WriteLine("Thu nhập chịu thuế: " + thuNhapChiuThue.ToString("#,##0") + " VNĐ");
            Console.WriteLine("Thuế TNCN phải nộp: " + thueTncn.ToString("#,##0") + " VNĐ");
            Console.WriteLine("LƯƠNG NET THỰC NHẬN: " + luongNet.ToString("#,##0") + " VNĐ");
        }

        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued
        }

        static void Bai10()
        {
            Console.WriteLine("Sản phẩm: Bàn phím Cơ Akko (Mã: KB-09)");
            
            int? soLuongTonKho = null;
            int nguongToiThieu = 10;
            DateTime? ngayNhapHang = null;

            int soHienThi = soLuongTonKho ?? 0;
            
            if (soLuongTonKho == null)
            {
                Console.WriteLine("Số lượng hiển thị: " + soHienThi + " (Cảnh báo: Dữ liệu trống)");
            }
            else
            {
                Console.WriteLine("Số lượng hiển thị: " + soHienThi);
            }

            StockStatus trangThai;
            if (soLuongTonKho == null || soLuongTonKho == 0)
            {
                trangThai = StockStatus.OutOfStock;
                Console.WriteLine("Trạng thái kho: OutOfStock (Hết hàng)");
            }
            else if (soLuongTonKho < nguongToiThieu)
            {
                trangThai = StockStatus.LowStock;
                Console.WriteLine("Trạng thái kho: LowStock");
            }
            else
            {
                trangThai = StockStatus.InStock;
                Console.WriteLine("Trạng thái kho: InStock");
            }
            
            string lichNhap = ngayNhapHang?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            Console.WriteLine("Dự kiến nhập hàng: " + lichNhap);
        }
    }
}
