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
            Console.WriteLine("enter 2 nuns");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("a" + a);
                Console.WriteLine("b" + b);
            }
            else
            {
                Console.WriteLine("a" + b);
                Console.WriteLine("b" + a);
            }

        }
    }
}
