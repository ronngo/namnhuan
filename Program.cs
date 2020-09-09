using System;

namespace namnhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
           
            Console.Write("Nhap nam muon kiem tra : ");
            year = int.Parse(Console.ReadLine());
            kiemtraNamNhuan(year);
            Console.ReadKey();
        }
        static int kiemtraNamNhuan(int year)
        {
            if (year % 400 == 0 && year % 100 == 0)
            {
                Console.Write("Nam {0} la nam nhuan ", year);
            }
            else
            {
                Console.Write("Nam {0} khong phai la nam nhuan ", year);
            }


            Console.ReadLine();
            return year;
        }
    }
}