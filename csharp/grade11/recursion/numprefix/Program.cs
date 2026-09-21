using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumPrefix
{
    class Program
    {
        public static void NumPrefix(int Num)
        {
            if (Num != 0)
            {
                Console.WriteLine(Num);
                NumPrefix(Num / 10);
            }
        }

        static void Main(string[] args)
        {
            NumPrefix(29807);
        }
    }
}
