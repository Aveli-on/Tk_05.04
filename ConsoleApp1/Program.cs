using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static bool tst(int bal, int tsts)
        {
            switch (tsts)
            {
                case 1 when bal <= 10 && bal >= 0:
                    return false;
                case 2 when bal <= 50 && bal >= 0:
                    return false;
                case 3 when bal <= 30 && bal >= 0:
                    return false;
                case 4 when bal <= 10 && bal >= 0:
                    return false;
            }
            return true;
        }
        public static int answ(int bal,int q=1)
        {
            switch (q)
            {
                case 1 when bal <= 100 && bal >= 70:
                    return 5;
                case 1 when bal <= 69 && bal >= 40:
                    return 4;
                case 1 when bal <= 39 && bal >= 20:
                    return 3;
                case 1 when bal <= 19 && bal >= 0:
                    return 2;
            }
            return 6;
        }

        static void Main(string[] args)
        {
            int sum = 0;
            int one = 0; 
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Введите количество баллов за {i} задание");
                one = int.Parse(Console.ReadLine());
                while (tst(one, i))
                {
                    Console.WriteLine($"Введите количество баллов за {i} задание( в 1-ом до 10, во 2-ом до 50, в 3-ем до 30, в 4-ом до 10 )");
                    one = int.Parse(Console.ReadLine());
                }
                sum += one;
            }
            Console.WriteLine($"Набранное количество баллов: {sum}, оценка {answ(sum)}");
            Console.ReadLine();
        }
    }
}
