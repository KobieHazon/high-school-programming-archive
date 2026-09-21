using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumDigits
{
    class Program
    {
        public static int SumDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return SumDigits(num / 10) + num % 10;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(1234));
        }
    }
}
