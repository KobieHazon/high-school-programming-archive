using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SameDigitPlace
{
    class Program
    {
        public static int SameDigitPlace(int Num1, int Num2)
        {
            if (Num1 == 0 || Num2 == 0)
                return 1;

            if (Num1 % 10 == Num2 % 10)
                return 1 + SameDigitPlace(Num1 / 10, Num2 / 10);

            else
                return SameDigitPlace(Num1 / 10, Num2 / 10);
        }

        

        static void Main(string[] args)
        {

            int Num1 = 123456;
            int Num2 = 123459;
            Console.WriteLine(SameDigitPlace(Num1, Num2));
        }
    }
}
