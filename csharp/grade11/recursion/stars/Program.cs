using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stars
{
    class Program
    {
        public static void stars(int n)
        {
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                stars(n - 1);
            }
        }

        public static void stars2(int n)
        {
            if (n != 0)
            {
                stars2(n - 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void stars3(int n)
        {
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                stars3(n - 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            int n = 6;
            stars(n);
            Console.WriteLine();
            stars2(n);
            Console.WriteLine();
            stars3(n);
        }
    }
}
