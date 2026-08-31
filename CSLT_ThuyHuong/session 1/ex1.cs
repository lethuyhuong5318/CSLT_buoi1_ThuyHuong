using System;

namespace CSLT_ThuyHuong
{
    class Program
    {

        static void ex01()
        {
            double c;

            do
            {
                Console.Write("Nhap vao do Celsius: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out c))
                {
                    break;
                }

                Console.WriteLine("Du lieu khong hop le. Vui long nhap lai so thuc!\n");
            }
            while (true);

            double k = c + 273;
            double f = c * 18 / 10 + 32;

            Console.WriteLine($"kelvin = {k}");
            Console.WriteLine($"fahrenheit = {f}\n");
        }


        static void ex02()
        {
            double radius;

            do
            {
                Console.Write("Nhap ban kinh (radius): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius) && radius > 0)
                {
                    break;
                }

                Console.WriteLine("Ban kinh phai la so duong (> 0). Vui long nhap lai!\n");
            }
            while (true);

            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"Surface: {surface:F2}");
            Console.WriteLine($"Volume: {volume:F1}\n");
        }




        static void Main(string[] args)
        {
            Console.WriteLine("-- BAI 1 --");
            ex01();

            Console.WriteLine("-- BAI 2 --");
            ex02();
        }
    }
}