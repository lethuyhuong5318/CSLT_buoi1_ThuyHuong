using System;

namespace CSLT_ThuyHuong.BtapBuoi4
{
    class Bai2_DoanSo
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            long tien = 1000000;
            bool continuePlaying = true;

            while (continuePlaying && tien > 0)
            {
                Console.WriteLine($"\n--- GAME ĐOÁN SỐ ---");
                Console.WriteLine($"Số tiền hiện tại: {tien} VNĐ");
                Console.WriteLine("Chọn mức độ: 1. Dễ (9 lần) | 2. Trung bình (6 lần) | 3. Khó (4 lần)");
                Console.Write("Lựa chọn của bạn: ");
                string levelStr = Console.ReadLine();
                
                int maxTries = 0;
                double multiplier = 0;
                
                if (levelStr == "1") { maxTries = 9; multiplier = 0.5; }
                else if (levelStr == "2") { maxTries = 6; multiplier = 1; }
                else if (levelStr == "3") { maxTries = 4; multiplier = 3; }
                else { Console.WriteLine("Lựa chọn không hợp lệ!"); continue; }

                long tienDatCuoc = 0;
                while (true)
                {
                    Console.Write("Nhập số tiền cược (phải > 0 và <= số tiền hiện tại): ");
                    if (long.TryParse(Console.ReadLine(), out tienDatCuoc) && tienDatCuoc > 0 && tienDatCuoc <= tien)
                    {
                        break;
                    }
                    Console.WriteLine("Tiền cược không hợp lệ.");
                }

                tien -= tienDatCuoc;
                Random rand = new Random();
                int targetNumber = rand.Next(1, 101);
                bool isWin = false;

                Console.WriteLine($"Máy đã nghĩ ra 1 số từ 1 đến 100. Bạn có {maxTries} lần đoán.");
                for (int i = 1; i <= maxTries; i++)
                {
                    Console.Write($"Lần đoán {i}: ");
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        if (guess == targetNumber)
                        {
                            isWin = true;
                            break;
                        }
                        else if (guess < targetNumber)
                        {
                            Console.WriteLine("Số bạn đoán NHỎ hơn số của máy.");
                        }
                        else
                        {
                            Console.WriteLine("Số bạn đoán LỚN hơn số của máy.");
                        }
                    }
                }

                if (isWin)
                {
                    long tienThang = (long)(tienDatCuoc + tienDatCuoc * multiplier);
                    tien += tienThang;
                    Console.WriteLine($"\nChúc mừng! Bạn đã đoán đúng số {targetNumber}.");
                    Console.WriteLine($"Bạn nhận được thêm {tienThang} VNĐ. Tổng tiền: {tien} VNĐ");
                }
                else
                {
                    Console.WriteLine($"\nRất tiếc! Bạn đã hết lượt đoán. Số của máy là {targetNumber}.");
                    Console.WriteLine($"Bạn mất {tienDatCuoc} VNĐ. Tổng tiền: {tien} VNĐ");
                }

                if (tien == 0)
                {
                    Console.WriteLine("Bạn đã hết tiền! Trò chơi kết thúc.");
                    break;
                }

                Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                if (Console.ReadLine().ToLower() == "k")
                {
                    continuePlaying = false;
                }
            }
            Console.WriteLine("Cảm ơn bạn đã chơi game!");
        }
    }
}
