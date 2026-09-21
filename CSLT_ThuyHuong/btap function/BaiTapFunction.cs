using System;
using System.Text;

namespace CSLT_ThuyHuong.BtapFunction
{
    public class Program
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static long TinhGiaiThua(int n)
        {
            if (n < 0) return -1;
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string DaoNguocChuoi(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void InFibonacci(int n)
        {
            if (n <= 0) return;
            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + (i < n - 1 ? " " : ""));
                long temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

        public static int DemNguyenAm(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static double TinhLuyThua(double x, int y)
        {
            if (y == 0) return 1;
            double result = 1;
            int exp = Math.Abs(y);
            for (int i = 0; i < exp; i++)
            {
                result *= x;
            }
            return y < 0 ? 1.0 / result : result;
        }

        public static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            double sum = 0;
            foreach (int val in arr)
            {
                sum += val;
            }
            return sum / arr.Length;
        }

        static void Bai1()
        {
            Console.WriteLine("\n--- BÀI 1: TÍNH TỔNG HAI SỐ NGUYÊN ---");
            Console.Write("Nhập số a: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Nhập số b: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"Kết quả TinhTong({a}, {b}) = {TinhTong(a, b)}");
        }

        static void Bai2()
        {
            Console.WriteLine("\n--- BÀI 2: KIỂM TRA SỐ CHẮN LẺ ---");
            Console.Write("Nhập số nguyên n: ");
            int.TryParse(Console.ReadLine(), out int n);
            bool isChan = KiemTraChan(n);
            Console.WriteLine($"KiemTraChan({n}) = {isChan} ({(isChan ? "Số chẵn" : "Số lẻ")})");
        }

        static void Bai3()
        {
            Console.WriteLine("\n--- BÀI 3: TÌM SỐ LỚN NHẤT TRONG 3 SỐ ---");
            Console.Write("Nhập số a: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Nhập số b: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Nhập số c: ");
            int.TryParse(Console.ReadLine(), out int c);
            Console.WriteLine($"TimMax({a}, {b}, {c}) = {TimMax(a, b, c)}");
        }

        static void Bai4()
        {
            Console.WriteLine("\n--- BÀI 4: TÍNH GIAI THỪA CỦA MỘT SỐ ---");
            Console.Write("Nhập số nguyên n: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"TinhGiaiThua({n}) = {TinhGiaiThua(n)}");
        }

        static void Bai5()
        {
            Console.WriteLine("\n--- BÀI 5: ĐẢO NGUỢC CHUỖI KÝ TỰ ---");
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine() ?? "";
            Console.WriteLine($"DaoNguocChuoi(\"{input}\") = \"{DaoNguocChuoi(input)}\"");
        }

        static void Bai6()
        {
            Console.WriteLine("\n--- BÀI 6: KIỂM TRA SỐ NGUYÊN TỐ ---");
            Console.Write("Nhập số n: ");
            int.TryParse(Console.ReadLine(), out int n);
            bool isNT = KiemTraNguyenTo(n);
            Console.WriteLine($"KiemTraNguyenTo({n}) = {isNT} ({(isNT ? "Là số nguyên tố" : "Không là số nguyên tố")})");
        }

        static void Bai7()
        {
            Console.WriteLine("\n--- BÀI 7: IN DÃY FIBONACCI ---");
            Console.Write("Nhập số n: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Write($"InFibonacci({n}): ");
            InFibonacci(n);
        }

        static void Bai8()
        {
            Console.WriteLine("\n--- BÀI 8: ĐẾM SỐ LƯỢNG NGUYÊN ÂM TRONG CHUỖI ---");
            Console.Write("Nhập chuỗi s: ");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine($"DemNguyenAm(\"{s}\") = {DemNguyenAm(s)}");
        }

        static void Bai9()
        {
            Console.WriteLine("\n--- BÀI 9: TÍNH LŨY THỪA (X^Y) ---");
            Console.Write("Nhập cơ số x: ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.Write("Nhập số mũ y: ");
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine($"TinhLuyThua({x}, {y}) = {TinhLuyThua(x, y)}");
        }

        static void Bai10()
        {
            Console.WriteLine("\n--- BÀI 10: TÍNH ĐIỂM TRUNG BÌNH CỦA MẢNG ---");
            Console.Write("Nhập các số nguyên của mảng (phân cách bởi dấu cách): ");
            string input = Console.ReadLine() ?? "";
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                int.TryParse(parts[i], out arr[i]);
            }
            Console.WriteLine($"TinhTrungBinh = {TinhTrungBinh(arr)}");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("       BÀI TẬP C# - HÀM (BÀI 1 ĐẾN BÀI 10)");
                Console.WriteLine("==================================================");
                Console.WriteLine("1.  Bài 1: Tính tổng hai số nguyên");
                Console.WriteLine("2.  Bài 2: Kiểm tra số chẵn lẻ");
                Console.WriteLine("3.  Bài 3: Tìm số lớn nhất trong ba số");
                Console.WriteLine("4.  Bài 4: Tính giai thừa của một số");
                Console.WriteLine("5.  Bài 5: Đảo ngược chuỗi ký tự");
                Console.WriteLine("6.  Bài 6: Kiểm tra số nguyên tố");
                Console.WriteLine("7.  Bài 7: In dãy Fibonacci");
                Console.WriteLine("8.  Bài 8: Đếm số lượng nguyên âm trong chuỗi");
                Console.WriteLine("9.  Bài 9: Tính lũy thừa (x^y)");
                Console.WriteLine("10. Bài 10: Tính điểm trung bình của mảng");
                Console.WriteLine("0.  Thoát chương trình");
                Console.WriteLine("==================================================");
                Console.Write("Chọn bài để chạy (0-10): ");

                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int bai))
                {
                    if (bai == 0) break;
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
                        default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số!");
                }
            }
        }
    }
}
