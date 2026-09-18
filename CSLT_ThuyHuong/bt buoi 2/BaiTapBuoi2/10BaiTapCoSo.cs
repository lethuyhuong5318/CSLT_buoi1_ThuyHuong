using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool tiepTuc = true;

        while (tiepTuc)
        {
            Console.WriteLine("\n===== MENU 10 BÀI TẬP C# =====");
            Console.WriteLine("1. Tính tiền điện bậc thang (EVN)");
            Console.WriteLine("2. Theo dõi chỉ số BMI");
            Console.WriteLine("3. Tính giá vé xem phim");
            Console.WriteLine("4. Phân quyền truy cập hệ thống");
            Console.WriteLine("5. Giao dịch rút tiền ATM");
            Console.WriteLine("6. Tổng đài chăm sóc khách hàng (IVR)");
            Console.WriteLine("7. Tính tiền cước GrabCar/Taxi");
            Console.WriteLine("8. Cập nhật trạng thái đơn hàng");
            Console.WriteLine("9. Phân loại BMI và cảnh báo sức khỏe");
            Console.WriteLine("10. Tính phí đỗ xe theo giờ");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1": Bai1(); break;
                case "2": Bai2(); break;
                case "3": Bai3(); break;
                case "4": Bai4(); break;
                case "5": Bai5(); break;
                case "6": Bai6(); break;
                case "7": Bai7(); break;
                case "8": Bai8(); break;
                case "9": Bai9(); break;
                case "10": Bai10(); break;
                case "0": tiepTuc = false; break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        }
    }

    // ===== BÀI 1: TÍNH TIỀN ĐIỆN BẬC THANG =====
    static void Bai1()
    {
        bool oldOk, newOk;
        int oldInput, newInput;

        do
        {
            Console.Write("Nhập vào chỉ số điện cũ (kWh): ");
            string input1 = Console.ReadLine();
            oldOk = int.TryParse(input1, out oldInput);

            if (!oldOk || oldInput < 0)
                Console.WriteLine("Sai định dạng, vui lòng nhập số nguyên dương!");

        } while (!oldOk || oldInput < 0);

        do
        {
            Console.Write("Nhập vào chỉ số điện mới (kWh): ");
            string input2 = Console.ReadLine();
            newOk = int.TryParse(input2, out newInput);

            if (!newOk)
                Console.WriteLine("Sai định dạng, vui lòng nhập số nguyên!");
            else if (newInput < oldInput)
                Console.WriteLine("Chỉ số mới không được nhỏ hơn chỉ số cũ!");

        } while (!newOk || newInput < oldInput);

        int soDienTieuThu = newInput - oldInput;

        decimal price1 = 1806m, price2 = 1866m, price3 = 2167m, price4 = 2729m, price5 = 3050m;
        int soConLai = soDienTieuThu;

        int soBac1 = Math.Min(soConLai, 50);
        decimal tienBac1 = soBac1 * price1;
        soConLai -= soBac1;

        int soBac2 = Math.Min(soConLai, 50);
        decimal tienBac2 = soBac2 * price2;
        soConLai -= soBac2;

        int soBac3 = Math.Min(soConLai, 100);
        decimal tienBac3 = soBac3 * price3;
        soConLai -= soBac3;

        int soBac4 = Math.Min(soConLai, 100);
        decimal tienBac4 = soBac4 * price4;
        soConLai -= soBac4;

        int soBac5 = soConLai;
        decimal tienBac5 = soBac5 * price5;

        decimal tienDienChuaThue = tienBac1 + tienBac2 + tienBac3 + tienBac4 + tienBac5;
        decimal tienThue = tienDienChuaThue * 0.08m;
        decimal tongTienThanhToan = tienDienChuaThue + tienThue;

        Console.WriteLine("-------------HÓA ĐƠN TIỀN ĐIỆN-------------");
        Console.WriteLine($"Số điện tiêu thụ: {soDienTieuThu} kWh");
        Console.WriteLine($"Tiền điện (chưa thuế): {tienDienChuaThue:N0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%): {tienThue:N0} VNĐ");
        Console.WriteLine($"Tổng tiền thanh toán: {tongTienThanhToan:N0} VNĐ");
    }

    // ===== BÀI 2: THEO DÕI CHỈ SỐ BMI =====
    static void Bai2()
    {
        bool chieuCaoOk, canNangOk;
        double chieuCao, canNang;

        do
        {
            Console.Write("Nhập chiều cao (m): ");
            string input1 = Console.ReadLine();
            chieuCaoOk = double.TryParse(input1, out chieuCao) && chieuCao > 0;

            if (!chieuCaoOk)
                Console.WriteLine("Chiều cao không hợp lệ, vui lòng nhập lại!");

        } while (!chieuCaoOk);

        do
        {
            Console.Write("Nhập cân nặng (kg): ");
            string input2 = Console.ReadLine();
            canNangOk = double.TryParse(input2, out canNang) && canNang > 0;

            if (!canNangOk)
                Console.WriteLine("Cân nặng không hợp lệ, vui lòng nhập lại!");

        } while (!canNangOk);

        double bmi = canNang / Math.Pow(chieuCao, 2);
        string phanLoai;

        if (bmi < 18.5)
            phanLoai = "Thiếu cân";
        else if (bmi < 23.0)
            phanLoai = "Bình thường (Lý tưởng)";
        else if (bmi < 25.0)
            phanLoai = "Thừa cân (Tiền béo phì)";
        else
            phanLoai = "Béo phì";

        double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
        double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);

        Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
        Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
        Console.WriteLine($"Khuyến nghị: Cân nặng lý tưởng nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg.");
    }

    // ===== BÀI 3: TÍNH GIÁ VÉ XEM PHIM =====
    static void Bai3()
    {
        bool tuoiOk, gioOk;
        int tuoi, gioChieu;

        do
        {
            Console.Write("Nhập tuổi: ");
            string input1 = Console.ReadLine();
            tuoiOk = int.TryParse(input1, out tuoi) && tuoi >= 0 && tuoi <= 130;

            if (!tuoiOk)
                Console.WriteLine("Tuổi không hợp lệ, vui lòng nhập lại!");

        } while (!tuoiOk);

        do
        {
            Console.Write("Nhập giờ chiếu (0-23): ");
            string input2 = Console.ReadLine();
            gioOk = int.TryParse(input2, out gioChieu) && gioChieu >= 0 && gioChieu <= 23;

            if (!gioOk)
                Console.WriteLine("Giờ chiếu không hợp lệ, vui lòng nhập lại!");

        } while (!gioOk);

        int giaVe;

        if (tuoi > 60 || tuoi < 12)
            giaVe = 50000;
        else if (gioChieu < 17)
            giaVe = 80000;
        else
            giaVe = 110000;

        Console.WriteLine($"Giá vé của bạn là: {giaVe:N0} VNĐ");
    }

    // ===== BÀI 4: PHÂN QUYỀN TRUY CẬP HỆ THỐNG =====
    static void Bai4()
    {
        Console.Write("Nhập mã vai trò (ADMIN/MANAGER/EMPLOYEE/GUEST): ");
        string role = Console.ReadLine()?.Trim().ToUpper();
        string thongBao;

        switch (role)
        {
            case "ADMIN":
                thongBao = "Toàn quyền quản trị hệ thống.";
                break;
            case "MANAGER":
                thongBao = "Quyền quản lý nhân sự và xem báo cáo.";
                break;
            case "EMPLOYEE":
                thongBao = "Quyền tạo và chỉnh sửa hồ sơ cá nhân.";
                break;
            case "GUEST":
                thongBao = "Chỉ có quyền xem thông tin công khai.";
                break;
            default:
                thongBao = "Mã vai trò không hợp lệ!";
                break;
        }

        Console.WriteLine($"[Thông báo]: {thongBao}");
    }

    // ===== BÀI 5: GIAO DỊCH RÚT TIỀN ATM =====
    static void Bai5()
    {
        bool soDuOk, soTienOk;
        decimal soDu, soTien;

        do
        {
            Console.Write("Nhập số dư tài khoản: ");
            string input1 = Console.ReadLine();
            soDuOk = decimal.TryParse(input1, out soDu) && soDu >= 0;

            if (!soDuOk)
                Console.WriteLine("Số dư không hợp lệ, vui lòng nhập lại!");

        } while (!soDuOk);

        do
        {
            Console.Write("Nhập số tiền muốn rút: ");
            string input2 = Console.ReadLine();
            soTienOk = decimal.TryParse(input2, out soTien) && soTien > 0;

            if (!soTienOk)
                Console.WriteLine("Số tiền không hợp lệ, vui lòng nhập lại!");

        } while (!soTienOk);

        if (soTien % 50000 != 0)
            Console.WriteLine("[Từ chối]: Số tiền rút phải là bội số của 50,000 VNĐ.");
        else if (soTien > 5000000)
            Console.WriteLine("[Từ chối]: Vượt quá hạn mức rút tối đa 5,000,000 VNĐ/lần.");
        else if (soTien > soDu)
            Console.WriteLine("[Từ chối]: Số dư không đủ để thực hiện giao dịch.");
        else
        {
            decimal soDuConLai = soDu - soTien;
            Console.WriteLine($"Giao dịch thành công. Số dư còn lại: {soDuConLai:N0} VNĐ");
        }
    }

    // ===== BÀI 6: TỔNG ĐÀI CHĂM SÓC KHÁCH HÀNG (IVR) =====
    static void Bai6()
    {
        bool phimOk;
        int phimBam;

        do
        {
            Console.Write("Nhập phím bấm (0-4): ");
            string input = Console.ReadLine();
            phimOk = int.TryParse(input, out phimBam);

            if (!phimOk)
                Console.WriteLine("Vui lòng chỉ nhập số nguyên!");

        } while (!phimOk);

        string thongBao;

        switch (phimBam)
        {
            case 1:
                thongBao = "Gặp tổng đài viên tư vấn thẻ.";
                break;
            case 2:
                thongBao = "Tra cứu số dư tài khoản.";
                break;
            case 3:
                thongBao = "Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.";
                break;
            case 4:
                thongBao = "Tra cứu tỷ giá ngoại tệ.";
                break;
            case 0:
                thongBao = "Quay lại menu chính.";
                break;
            default:
                thongBao = "Lựa chọn không hợp lệ. Vui lòng thử lại!";
                break;
        }

        Console.WriteLine($"[Tổng đài]: {thongBao}");
    }

    // ===== BÀI 7: TÍNH TIỀN CƯỚC GRABCAR/TAXI =====
    static void Bai7()
    {
        bool soKmOk;
        double soKm;

        do
        {
            Console.Write("Nhập số km di chuyển: ");
            string input = Console.ReadLine();
            soKmOk = double.TryParse(input, out soKm) && soKm > 0;

            if (!soKmOk)
                Console.WriteLine("Số km không hợp lệ, vui lòng nhập lại!");

        } while (!soKmOk);

        double soKmConLai = soKm;
        decimal tongTienTruocGiam = 0;

        double soKmBac1 = Math.Min(soKmConLai, 1);
        if (soKmBac1 > 0)
            tongTienTruocGiam += 15000;
        soKmConLai -= soKmBac1;

        double soKmBac2 = Math.Min(soKmConLai, 9);
        tongTienTruocGiam += (decimal)soKmBac2 * 12000;
        soKmConLai -= soKmBac2;

        double soKmBac3 = soKmConLai;
        tongTienTruocGiam += (decimal)soKmBac3 * 10000;

        decimal khuyenMai = 0;
        decimal thanhTien;

        if (soKm > 30)
        {
            khuyenMai = tongTienTruocGiam * 0.10m;
            thanhTien = tongTienTruocGiam - khuyenMai;
        }
        else
        {
            thanhTien = tongTienTruocGiam;
        }

        Console.WriteLine($"Tổng tiền trước giảm: {tongTienTruocGiam:N0} VNĐ");
        if (soKm > 30)
            Console.WriteLine($"Khuyến mãi (10%): -{khuyenMai:N0} VNĐ");
        Console.WriteLine($"Thành tiền: {thanhTien:N0} VNĐ");
    }

    // ===== BÀI 8: CẬP NHẬT TRẠNG THÁI ĐƠN HÀNG =====
    static void Bai8()
    {
        bool inputOk;
        int trangThai;

        do
        {
            Console.Write("Nhập mã trạng thái đơn hàng (1-5): ");
            string input = Console.ReadLine();
            inputOk = int.TryParse(input, out trangThai);

            if (!inputOk)
                Console.WriteLine("Mã trạng thái không hợp lệ, vui lòng chỉ nhập số nguyên!");

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

    // ===== BÀI 9: PHÂN LOẠI BMI VÀ CẢNH BÁO SỨC KHỎE =====
    static void Bai9()
    {
        bool chieuCaoOk, canNangOk;
        double chieuCao, canNang;

        do
        {
            Console.Write("Nhập chiều cao (m): ");
            string input1 = Console.ReadLine();
            chieuCaoOk = double.TryParse(input1, out chieuCao) && chieuCao > 0;

            if (!chieuCaoOk)
                Console.WriteLine("Chiều cao không hợp lệ, vui lòng nhập lại!");

        } while (!chieuCaoOk);

        do
        {
            Console.Write("Nhập cân nặng (kg): ");
            string input2 = Console.ReadLine();
            canNangOk = double.TryParse(input2, out canNang) && canNang > 0;

            if (!canNangOk)
                Console.WriteLine("Cân nặng không hợp lệ, vui lòng nhập lại!");

        } while (!canNangOk);

        double bmi = canNang / Math.Pow(chieuCao, 2);
        string danhGia;

        if (bmi < 18.5)
            danhGia = "Thầy gầy - Nên bổ sung dinh dưỡng.";
        else if (bmi < 25)
            danhGia = "Cân đối - Tiếp tục duy trì.";
        else if (bmi < 30)
            danhGia = "Thừa cân - Nên tăng cường luyện tập.";
        else
            danhGia = "Béo phì - Cần sự tư vấn từ bác sĩ.";

        Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: {danhGia}");
    }

    // ===== BÀI 10: TÍNH PHÍ ĐỖ XE THEO GIỜ =====
    static void Bai10()
    {
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
                phi = (thoiGian == 1) ? 5000 : 10000;
                break;
            case "CAR":
                loaiXeHienThi = "Ô tô";
                phi = (thoiGian == 1) ? 30000 : 60000;
                break;
        }

        string thoiGianHienThi = (thoiGian == 1) ? "Ban ngày" : "Ban đêm";

        Console.WriteLine($"Phí gửi xe {loaiXeHienThi} ({thoiGianHienThi}): {phi:N0} VNĐ");
    }
}