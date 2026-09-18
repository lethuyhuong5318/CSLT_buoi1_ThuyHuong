using System;

namespace CSLT_ThuyHuong.BtapBuoi4
{
    class Bai6_ChuoiDieuHoa
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"1/{i}");
                    if (i < n) Console.Write(" + ");
                    sum += 1.0 / i;
                }
                Console.WriteLine($"\nTong cua day so den {n} phan tu la: {sum}");
            }
            else
            {
                Console.WriteLine("Dau vao khong hop le!");
            }
        }
    }
}
