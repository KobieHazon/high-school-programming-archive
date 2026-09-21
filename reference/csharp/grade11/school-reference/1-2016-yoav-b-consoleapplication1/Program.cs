using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("enter 2 nums");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a: " + a);
                Console.WriteLine("b :" + b);

            }
            else
            {
                Console.WriteLine("b: " + b);
                Console.WriteLine("a :" + a);
            }
        }

    }
}
