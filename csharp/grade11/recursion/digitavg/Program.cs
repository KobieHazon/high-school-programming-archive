using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitAVG
{
    class Program
    {
        public static int DigitAvg1(int Num)
        {
            return digitsAvg(Num, 0, 0);
        }
        public static int digitsAvg(int number, int sum, int count)
        {
            if (number == 0)
            {
                if (count == 0)
                    return 0;
                return (sum) / (count);
            }
            else
                return digitsAvg(number / 10, sum + number % 10, count+1);
        }



       
        static void Main(string[] args)
        {
            int K = 3898;
            Console.WriteLine(DigitAvg1(K));
        }
    }
}
