using System;
using System.Text;
using System.Collections.Generic;

namespace CSLT_ThuyHuong.BtapMang
{
    public class Program
    {
        static int[] TaoMangNgauNhien(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
            return arr;
        }

        static void InMang(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static double TinhTrungBinh(int[] arr)
        {
            if (arr.Length == 0) return 0;
            double sum = 0;
            foreach (int val in arr) sum += val;
            return sum / arr.Length;
        }

        static bool KiemTraTonTai(int[] arr, int value)
        {
            foreach (int val in arr)
            {
                if (val == value) return true;
            }
            return false;
        }

        static int TimViTri(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) return i;
            }
            return -1;
        }

        static int[] XoaPhanTu(int[] arr, int value)
        {
            int count = 0;
            foreach (int val in arr)
            {
                if (val == value) count++;
            }

            if (count == 0) return arr;

            int[] newArr = new int[arr.Length - count];
            int index = 0;
            foreach (int val in arr)
            {
                if (val != value)
                {
                    newArr[index++] = val;
                }
            }
            return newArr;
        }

        static void TimMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            foreach (int val in arr)
            {
                if (val > max) max = val;
                if (val < min) min = val;
            }
        }

        static void DaoNguocMang(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        static List<int> TimPhanTuTrungLap(int[] arr)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> seen = new HashSet<int>();
            foreach (int val in arr)
            {
                if (!seen.Add(val) && !duplicates.Contains(val))
                {
                    duplicates.Add(val);
                }
            }
            return duplicates;
        }

        static int[] XoaPhanTuTrungLap(int[] arr)
        {
            List<int> unique = new List<int>();
            foreach (int val in arr)
            {
                if (!unique.Contains(val))
                {
                    unique.Add(val);
                }
            }
            return unique.ToArray();
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static bool LinearSearch(string sentence, string word)
        {
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        static int[,] TaoMaTranNgauNhien(int n, int m)
        {
            int[,] matrix = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            return matrix;
        }

        static void InMaTran(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static void InDongCot(int[,] matrix, int index)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            
            Console.Write($"Dòng {index}: ");
            if (index >= 0 && index < n)
            {
                for (int j = 0; j < m; j++) Console.Write(matrix[index, j] + " ");
            }
            else Console.Write("Không tồn tại");
            Console.WriteLine();

            Console.Write($"Cột {index}: ");
            if (index >= 0 && index < m)
            {
                for (int i = 0; i < n; i++) Console.Write(matrix[i, index] + " ");
            }
            else Console.Write("Không tồn tại");
            Console.WriteLine();
        }

        static int TimMaxMaTran(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int val in matrix)
            {
                if (val > max) max = val;
            }
            return max;
        }

        static void TimMinDongCot(int[,] matrix, int index)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (index >= 0 && index < n)
            {
                int minDong = matrix[index, 0];
                for (int j = 1; j < m; j++)
                {
                    if (matrix[index, j] < minDong) minDong = matrix[index, j];
                }
                Console.WriteLine($"Min dòng {index}: {minDong}");
            }

            if (index >= 0 && index < m)
            {
                int minCot = matrix[0, index];
                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, index] < minCot) minCot = matrix[i, index];
                }
                Console.WriteLine($"Min cột {index}: {minCot}");
            }
        }

        static int[,] ChuyenViMaTran(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] result = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        static void InDuongCheo(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (n != m)
            {
                Console.WriteLine("Đây không phải là ma trận vuông, không có đường chéo chính/phụ.");
                return;
            }

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++) Console.Write(matrix[i, i] + " ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < n; i++) Console.Write(matrix[i, n - 1 - i] + " ");
            Console.WriteLine();
        }

        static void Bai1()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng: "); InMang(arr);
            Console.WriteLine($"Trung bình cộng: {TinhTrungBinh(arr)}");
        }

        static void Bai2()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng: "); InMang(arr);
            Console.Write("Nhập giá trị cần kiểm tra: ");
            int.TryParse(Console.ReadLine(), out int val);
            bool tonTai = KiemTraTonTai(arr, val);
            Console.WriteLine(tonTai ? $"Có tồn tại {val} trong mảng." : $"Không tồn tại {val} trong mảng.");
        }

        static void Bai3()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng: "); InMang(arr);
            Console.Write("Nhập giá trị cần tìm vị trí: ");
            int.TryParse(Console.ReadLine(), out int val);
            int index = TimViTri(arr, val);
            if (index != -1) Console.WriteLine($"Phần tử {val} ở vị trí (index): {index}");
            else Console.WriteLine($"Không tìm thấy {val} trong mảng.");
        }

        static void Bai4()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng: "); InMang(arr);
            Console.Write("Nhập giá trị cần xóa: ");
            int.TryParse(Console.ReadLine(), out int val);
            int[] newArr = XoaPhanTu(arr, val);
            Console.Write("Mảng sau khi xóa: "); InMang(newArr);
        }

        static void Bai5()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng: "); InMang(arr);
            TimMaxMin(arr, out int max, out int min);
            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        static void Bai6()
        {
            int[] arr = TaoMangNgauNhien(10);
            Console.Write("Mảng ban đầu: "); InMang(arr);
            DaoNguocMang(arr);
            Console.Write("Mảng sau khi đảo ngược: "); InMang(arr);
        }

        static void Bai7()
        {
            int[] arr = TaoMangNgauNhien(15);
            Console.Write("Mảng: "); InMang(arr);
            List<int> dups = TimPhanTuTrungLap(arr);
            Console.WriteLine("Các phần tử trùng lặp: " + (dups.Count > 0 ? string.Join(", ", dups) : "Không có"));
        }

        static void Bai8()
        {
            int[] arr = TaoMangNgauNhien(15);
            Console.Write("Mảng ban đầu: "); InMang(arr);
            int[] newArr = XoaPhanTuTrungLap(arr);
            Console.Write("Mảng sau khi xóa trùng lặp: "); InMang(newArr);
        }

        static void Bai9()
        {
            int[] arr = new int[10];
            Console.WriteLine("Nhập 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            BubbleSort(arr);
            Console.Write("Mảng sau khi sắp xếp (Bubble Sort): "); InMang(arr);
        }

        static void Bai10()
        {
            Console.Write("Nhập một câu: ");
            string sentence = Console.ReadLine() ?? "";
            Console.Write("Nhập một từ cần tìm: ");
            string word = Console.ReadLine() ?? "";
            bool found = LinearSearch(sentence, word);
            Console.WriteLine(found ? $"Từ '{word}' CÓ xuất hiện trong câu." : $"Từ '{word}' KHÔNG xuất hiện trong câu.");
        }

        static void Bai11()
        {
            Console.Write("Nhập số dòng N: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Write("Nhập số cột M: ");
            int.TryParse(Console.ReadLine(), out int m);
            if (n <= 0 || m <= 0)
            {
                Console.WriteLine("Kích thước không hợp lệ.");
                return;
            }

            int[,] matrix = TaoMaTranNgauNhien(n, m);
            Console.WriteLine("--- MA TRẬN VỪA TẠO ---");
            InMaTran(matrix);

            Console.WriteLine($"\nMax của ma trận: {TimMaxMaTran(matrix)}");

            Console.Write("\nNhập chỉ số dòng/cột (i) muốn xem & tìm min: ");
            int.TryParse(Console.ReadLine(), out int i);
            InDongCot(matrix, i);
            TimMinDongCot(matrix, i);

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ ---");
            int[,] transposed = ChuyenViMaTran(matrix);
            InMaTran(transposed);

            Console.WriteLine("\n--- ĐƯỜNG CHÉO CHÍNH / PHỤ ---");
            InDuongCheo(matrix);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("            BÀI TẬP C# - MẢNG & MA TRẬN           ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1.  Tính trung bình các phần tử mảng");
                Console.WriteLine("2.  Kiểm tra mảng có chứa giá trị cụ thể");
                Console.WriteLine("3.  Tìm vị trí của phần tử trong mảng");
                Console.WriteLine("4.  Xóa phần tử cụ thể khỏi mảng");
                Console.WriteLine("5.  Tìm max, min của mảng");
                Console.WriteLine("6.  Đảo ngược mảng");
                Console.WriteLine("7.  Tìm các giá trị trùng lặp");
                Console.WriteLine("8.  Xóa các phần tử trùng lặp");
                Console.WriteLine("9.  Nhập 10 số, sắp xếp Bubble Sort");
                Console.WriteLine("10. Tìm từ trong câu (Linear Search)");
                Console.WriteLine("11. Làm việc với Ma trận (Matrix operations)");
                Console.WriteLine("0.  Thoát chương trình");
                Console.WriteLine("==================================================");
                Console.Write("Chọn bài để chạy (0-11): ");

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
                        case 11: Bai11(); break;
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
