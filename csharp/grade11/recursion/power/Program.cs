using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power
{
    class Program
    {
        public static int Power(int Num, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return Num * (Power(Num, power - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Power(5, 2));
        }
    }
}
