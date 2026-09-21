using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitCnt
{
    class Program
    {
        public static int DigitCnt(int Num)
        {
            if (Num > -10 && Num < 10)
                return 1;
            return 1 + DigitCnt(Num / 10);
        }

        static void Main(string[] args)
        {
            int Num1 = 96737457;
            Console.WriteLine(DigitCnt(Num1));

        }
    }
}
