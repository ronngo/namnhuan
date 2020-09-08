using System;

namespace namnhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int years;
            Console.Write("Nhap nam muon kiem tra : ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n ");
            if (years % 400 == 0 && years % 100 == 0)
            {
                Console.Write("Nam {0} la nam nhuan ", years);
            }
            else
            {
                Console.Write("Nam {0} khong phai la nam nhuan ", years);
            }


            Console.ReadLine();
        }
    }
}