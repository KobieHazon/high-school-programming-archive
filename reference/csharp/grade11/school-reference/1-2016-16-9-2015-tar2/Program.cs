using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 2 numbers");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                Console.WriteLine();
                Console.WriteLine(a+", "+b);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine(b+", "+a);
                Console.WriteLine();
            }
        }
    }
}
