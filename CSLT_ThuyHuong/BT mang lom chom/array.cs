using System;

namespace BT_mang_lom_chom
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Khoi tao mang rang cua (chu y chi co 4 so 1 o hang dau)
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 1, 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4 }
            };

            // 2. Bat buoc dung dau nhay kep " " thay vi ' ' de khong bi loi CS1012
            Console.WriteLine("KET QUA:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}