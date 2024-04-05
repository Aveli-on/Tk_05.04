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
                    return true;
                case 2 when bal <= 50 && bal >= 0:
                    return true;
                case 3 when bal <= 30 && bal >= 0:
                    return true;
                case 4 when bal <= 10 && bal >= 0:
                    return true;
            }
            return false;
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
        public static bool final(int [] a) {
            int sum = 0;
            int one = 0;
            for (int i = 0; i < 4; i++)
            {
                string y = a[i].ToString();
                bool result = int.TryParse(y,out one);
                if (!tst(one, i+1) || !result)
                {
                    return false;
                }
                sum += one;
            }
            Console.WriteLine($"Набранное количество баллов: {sum}, оценка {answ(sum)}");


            return true;
        }
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
