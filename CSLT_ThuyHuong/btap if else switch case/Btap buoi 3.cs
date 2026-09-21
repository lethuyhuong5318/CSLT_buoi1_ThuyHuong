using System;
using System.Text;

namespace CSLT_ThuyHuong.BtapBuoi3
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Chọn bài để chạy (1-10):");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int bai))
        {
            switch (bai)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                default: Console.WriteLine("Bài không tồn tại."); break;
            }
        }
    }

    static void Bai1()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int tuoi, gioChieu;
        bool tuoiOk, gioChieuOk;
        do
        {
            Console.Write("Tuổi: ");
            string input1 = Console.ReadLine();
            tuoiOk = int.TryParse(input1, out tuoi);

            if (!tuoiOk)
            { Console.WriteLine("Bạn nhập sai định dạng tuổi, vui lòng nhập lại, chỉ nhập số nguyên dương, vd: 9,35,.."); }
            else if (tuoi < 0)
            { Console.WriteLine("Tuổi không thể âm, vui lòng nhập lại, vd: 9,35,.."); }
            else if (tuoi > 155)
            { Console.WriteLine("Tuổi không hợp lệ, vui lòng nhập lại, vd: 9,35,120.."); }

        } while (!tuoiOk || tuoi < 0 || tuoi > 155);

        do
        {
            Console.Write("Giờ chiếu: ");
            string input2 = Console.ReadLine();
            gioChieuOk = int.TryParse(input2, out gioChieu);

            if (!gioChieuOk)
                Console.WriteLine("Bạn nhập sai định dạng, vui lòng nhập lại, chỉ nhập số nguyên dương 0<=giờ<=23(h), vd: 9,15,..");
            else if (gioChieu < 0 || gioChieu > 23)
                Console.WriteLine("Giờ chiếu không hợp lệ, vui lòng nhập lại, số nguyên dương 0<=giờ<=23(h),vd: 9,15,..");

        } while (!gioChieuOk || gioChieu < 0 || gioChieu > 23);

        if (tuoi > 60 || tuoi < 12)
        { Console.WriteLine("Giá vé của bạn là: 50,000 VND"); }
        else if (gioChieu < 17)
        { Console.WriteLine("Giá vé của bạn là: 80,000 VND"); }
        else
        { Console.WriteLine("Giá vé của bạn là: 110,000 VND"); }
    }

    static void Bai2()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập vai trò của bạn: (ADMIN/MANAGER/EMPLOYEE/GUEST)");
        string role = Console.ReadLine()?.Trim()?.ToUpper();
        string thongBao;
        switch (role)
        {
            case "ADMIN":
                thongBao = "Toàn quyền quản trị hệ thống.";
                break;
            case "MANAGER":
                thongBao = "Quyền quản lý nhân sự và xem báo cáo";
                break;
            case "EMPLOYEE":
                thongBao = "Quyền tạo và chỉnh sửa hồ sơ cá nhân";
                break;
            case "GUEST":
                thongBao = "Chỉ có quyền xem thông tin công khai.";
                break;

            default:
                thongBao = "Mã vai trò không hợp lệ!"; break;
        }
        Console.WriteLine($"[Thông báo]:{thongBao}");
    }

    static void Bai3()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool soDuOk, soTienOk;
        decimal soDu, soTien;

        do
        {
            Console.WriteLine("Nhập vào số dư tài khoản: ");
            string input1 = Console.ReadLine();
            soDuOk = decimal.TryParse(input1, out soDu);
            if (!soDuOk)
            {
                Console.WriteLine("Số dư không hợp lệ, vui lòng nhập lại, chỉ nhập số nguyên ");
            }
            else if (soDu < 0)
            {
                Console.WriteLine("Số dư không được âm, vui lòng nhập lại ");
            }
        }
        while (!soDuOk || soDu < 0);

        do
        {
            Console.WriteLine("Nhập vào số tiền muốn rút (Số tiền muốn rút phải >0, là bội số của 50,000, vd 100,000,250,000 VND, Hạn mức rút tối đa là 5,000,000/lần): ");

            string input2 = Console.ReadLine();
            soTienOk = decimal.TryParse(input2, out soTien);
            if (!soTienOk)
            {
                Console.WriteLine("Số tiền không hợp lệ, vui lòng nhập lại, chỉ nhập số nguyên ");
            }
            else if (soTien <= 0)
            {
                Console.WriteLine("Số tiền phải >0, vui lòng nhập lại ");
            }

        }
        while (soTien <= 0 || !soTienOk);

        if (soTien > soDu)
        {
            Console.WriteLine("Giao dịch thất bại. Số tiền không được vượt quá số dư hiện tại.");
        }
        else if (soTien % 50000 != 0)
        {
            Console.WriteLine("Giao dịch thất bại.Số tiền phải là bội số của 50,000 ");
        }

        else if (soTien > 5000000)
        {
            Console.WriteLine("Giao dịch thất bại. Hạn mức rút tối đa 5,000,000 VNĐ / lần.");
        }
        else
        {
            decimal conLai = soDu - soTien;
            Console.WriteLine($"Giao dịch thành công. Số dư còn lại là: {conLai:N0} VND ");
        }
    }

    static void Bai4()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool inputOk;
        int so;
        do
        {
            Console.WriteLine("Để tương tác với tổng đài ngân hàng, vui lòng bấm các phím sau:\n- 1: Gặp tổng đài viên tư vấn thẻ.\n- 2: Tra cứu số dư tài khoản.\n- 3: Báo khóa thẻ khẩn cấp.\n- 4: Tra cứu tỷ giá ngoại tệ.\n- 0: Quay lại menu chính.");

            string input = Console.ReadLine();
            inputOk = int.TryParse(input, out so);

            if (!inputOk)
            {
                Console.WriteLine("Số không hợp lệ, vui lòng nhập lại");
            }
        }
        while (!inputOk);
        string thongBao;
        switch (so)
        {
            case 1:
                thongBao = "Xin chào, đây là tổng đài tư vấn thẻ";
                break;
            case 2:
                thongBao = "Đang kiểm tra số dư tài khoản hiện tại của quý khách ";
                break;
            case 3:
                thongBao = "Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận";
                break;
            case 4:
                thongBao = "Đang tra cứu tỉ giá ngoại tệ hiện nay";
                break;
            case 0:
                thongBao = "Đã quay lại menu chính";
                break;
            default:
                thongBao = "Lựa chọn không hợp lệ. Vui lòng thử lại!";
                break;
        }
        Console.WriteLine($"[Tổng đài]:{thongBao}");
    }

    static void Bai5()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool inputOk;
        int soKm;
        decimal tongTienTruocGiam, khuyenMai, thanhTien;
        thanhTien = tongTienTruocGiam = 0;
        khuyenMai = 0;

        do
        {
            Console.WriteLine("Nhập vào số km: ");

            string input = Console.ReadLine();
            inputOk = int.TryParse(input, out soKm);

            if (!inputOk || soKm <= 0)
            {
                Console.WriteLine("Số không hợp lệ, vui lòng nhập lại");
            }
        }
        while (!inputOk || soKm <= 0);

        if (soKm <= 1)
        {
            tongTienTruocGiam = 15000;
        }
        else if (soKm >= 2 && soKm <= 10)
        {
            tongTienTruocGiam = 15000 + 12000 * (soKm - 1);
        }
        else if (soKm >= 11)
        {
            tongTienTruocGiam = 15000 + 12000 * 9 + 10000 * (soKm - 10);
        }
        if (soKm > 30)
        {
            khuyenMai = tongTienTruocGiam * 0.1m;
            thanhTien = tongTienTruocGiam - khuyenMai;
        }
        else
            thanhTien = tongTienTruocGiam;

        Console.WriteLine($"Tổng tiền trước giảm: {tongTienTruocGiam:N0}");
        Console.WriteLine($"Khuyến mãi (10%):{khuyenMai:N0}");
        Console.WriteLine($"Thành tiền:{thanhTien:N0}");
    }

    static void Bai6()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool inputOk;
        int trangThai;

        do
        {
            Console.WriteLine("Nhập mã trạng thái đơn hàng (1-5): ");
            string input = Console.ReadLine();
            inputOk = int.TryParse(input, out trangThai);

            if (!inputOk)
            {
                Console.WriteLine("Mã trạng thái không hợp lệ, vui lòng chỉ nhập số nguyên!");
            }

        } while (!inputOk);

        string thongBao;

        switch (trangThai)
        {
            case 1:
                thongBao = "Chờ xác nhận thanh toán.";
                break;
            case 2:
                thongBao = "Đang đóng gói và bàn giao đơn vị vận chuyển.";
                break;
            case 3:
                thongBao = "Đơn hàng đang trên đường giao đến bạn.";
                break;
            case 4:
                thongBao = "Đơn hàng đã hoàn thành. Cảm ơn bạn!";
                break;
            case 5:
                thongBao = "Đơn hàng đã hủy. Xuất phiếu hoàn tiền.";
                break;
            default:
                thongBao = "Mã trạng thái không hợp lệ!";
                break;
        }

        Console.WriteLine($"[Trạng thái]: {thongBao}");
    }

    static void Bai7()
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool chieuCaoOk;
        double chieuCao;
        do
        {
            Console.Write("Nhập chiều cao (m): ");
            string input1 = Console.ReadLine();
            chieuCaoOk = double.TryParse(input1, out chieuCao);

            if (!chieuCaoOk)
                Console.WriteLine("Sai định dạng, vui lòng nhập lại (ví dụ: 1.75)!");
            else if (chieuCao <= 0)
                Console.WriteLine("Chiều cao phải lớn hơn 0!");

        } while (!chieuCaoOk || chieuCao <= 0);

        bool canNangOk;
        double canNang;
        do
        {
            Console.Write("Nhập cân nặng (kg): ");
            string input2 = Console.ReadLine();
            canNangOk = double.TryParse(input2, out canNang);

            if (!canNangOk)
                Console.WriteLine("Sai định dạng, vui lòng nhập lại (ví dụ: 70)!");
            else if (canNang <= 0)
                Console.WriteLine("Cân nặng phải lớn hơn 0!");

        } while (!canNangOk || canNang <= 0);

        double bmi = canNang / Math.Pow(chieuCao, 2);

        string danhGia;

        if (bmi < 18.5)
        {
            danhGia = "Thầy gầy - Nên bổ sung dinh dưỡng.";
        }
        else if (bmi < 25)
        {
            danhGia = "Cân đối - Tiếp tục duy trì.";
        }
        else if (bmi < 30)
        {
            danhGia = "Thừa cân - Nên tăng cường luyện tập.";
        }
        else
        {
            danhGia = "Béo phì - Cần sự tư vấn từ bác sĩ.";
        }

        Console.WriteLine();
        Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: {danhGia}");
    }

    static void Bai8()
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool loaiXeOk;
        string loaiXe;
        do
        {
            Console.Write("Nhập loại xe (BIKE/CAR): ");
            loaiXe = Console.ReadLine()?.Trim().ToUpper();
            loaiXeOk = (loaiXe == "BIKE" || loaiXe == "CAR");

            if (!loaiXeOk)
                Console.WriteLine("Loại xe không hợp lệ, vui lòng nhập BIKE hoặc CAR!");

        } while (!loaiXeOk);

        bool thoiGianOk;
        int thoiGian;
        do
        {
            Console.Write("Nhập thời gian gửi (1: Ban ngày, 2: Ban đêm): ");
            string input = Console.ReadLine();
            thoiGianOk = int.TryParse(input, out thoiGian) && (thoiGian == 1 || thoiGian == 2);

            if (!thoiGianOk)
                Console.WriteLine("Thời gian không hợp lệ, vui lòng nhập 1 hoặc 2!");

        } while (!thoiGianOk);

        int phi = 0;
        string loaiXeHienThi = "";

        switch (loaiXe)
        {
            case "BIKE":
                loaiXeHienThi = "Xe máy";
                if (thoiGian == 1)
                    phi = 5000;
                else
                    phi = 10000;
                break;
            case "CAR":
                loaiXeHienThi = "Ô tô";
                if (thoiGian == 1)
                    phi = 30000;
                else
                    phi = 60000;
                break;
        }

        string thoiGianHienThi = (thoiGian == 1) ? "Ban ngày" : "Ban đêm";

        Console.WriteLine($"Phí gửi xe {loaiXeHienThi} ({thoiGianHienThi}): {phi:N0} VNĐ");
    }

    static void Bai9()
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool gpaOk;
        double gpa;
        do
        {
            Console.Write("Nhập GPA (0-4.0): ");
            string input1 = Console.ReadLine();
            gpaOk = double.TryParse(input1, out gpa) && gpa >= 0 && gpa <= 4.0;

            if (!gpaOk)
                Console.WriteLine("GPA không hợp lệ, vui lòng nhập từ 0 đến 4.0!");

        } while (!gpaOk);

        bool drlOk;
        double drl;
        do
        {
            Console.Write("Nhập DRL (0-100): ");
            string input2 = Console.ReadLine();
            drlOk = double.TryParse(input2, out drl) && drl >= 0 && drl <= 100;

            if (!drlOk)
                Console.WriteLine("DRL không hợp lệ, vui lòng nhập từ 0 đến 100!");

        } while (!drlOk);

        string ketQua;

        if (gpa >= 3.6 && drl >= 90)
        {
            ketQua = "Học bổng Xuất sắc (Mức 100%)";
        }
        else if (gpa >= 3.2 && drl >= 80)
        {
            ketQua = "Học bổng Khá/Giỏi (Mức 50%)";

            if (gpa < 3.6)
                ketQua += " (Do GPA < 3.6)";
            else if (drl < 90)
                ketQua += " (Do DRL < 90)";
        }
        else
        {
            ketQua = "Không đạt học bổng";

            if (gpa < 3.2)
                ketQua += " (Do GPA < 3.2)";
            else if (drl < 80)
                ketQua += " (Do DRL < 80)";
        }

        Console.WriteLine();
        Console.WriteLine($"Kết quả: {ketQua}");
    }

    static void Bai10()
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool soTienOk;
        decimal soTien;
        do
        {
            Console.Write("Nhập số tiền (VNĐ): ");
            string input1 = Console.ReadLine();
            soTienOk = decimal.TryParse(input1, out soTien) && soTien > 0;

            if (!soTienOk)
                Console.WriteLine("Số tiền không hợp lệ, vui lòng nhập lại (phải > 0)!");

        } while (!soTienOk);

        bool maOk;
        string maNgoaiTe;
        do
        {
            Console.Write("Nhập mã ngoại tệ (USD/EUR/JPY): ");
            maNgoaiTe = Console.ReadLine()?.Trim().ToUpper();
            maOk = (maNgoaiTe == "USD" || maNgoaiTe == "EUR" || maNgoaiTe == "JPY");

            if (!maOk)
                Console.WriteLine("Mã ngoại tệ không hợp lệ, chỉ nhận USD, EUR hoặc JPY!");

        } while (!maOk);

        decimal tyGia = 0;

        switch (maNgoaiTe)
        {
            case "USD":
                tyGia = 25400;
                break;
            case "EUR":
                tyGia = 27200;
                break;
            case "JPY":
                tyGia = 165;
                break;
        }

        decimal ketQua = soTien / tyGia;

        Console.WriteLine();
        Console.WriteLine($"Số tiền sau quy đổi: {ketQua:F2} {maNgoaiTe}");
    }
}
}
