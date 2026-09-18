using System;

namespace CSLT_ThuyHuong.BtapBuoi4
{
    class Bai7_SoHoanHao
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap gia tri bat dau: ");
            if (!int.TryParse(Console.ReadLine(), out int start)) return;

            Console.Write("Nhap gia tri ket thuc: ");
            if (!int.TryParse(Console.ReadLine(), out int end)) return;

            Console.WriteLine($"Cac so hoan hao trong khoang da cho la:");
            for (int n = start; n <= end; n++)
            {
                if (IsPerfect(n))
                {
                    Console.Write($"{n} ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPerfect(int number)
        {
            if (number < 2) return false;
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
    }
}
