using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDigitAvg
{
    class Program
    {

        public static double DigitAvg(double n)
        {
            return DigitAvg(n, NumDigits(n));
        }

        private static double DigitAvg(double a, double k)
        {
            if (a < 10)
            {
                return a;
            }
            return (((a % 10) + (DigitAvg(a / 10, k -1) * (k-1)) / k));
        }

        private static double NumDigits(double num)
        {
            if (num < 10)
                return 1;
            return (1 + NumDigits(num / 10));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DigitAvg(689));
        }
    }
}
