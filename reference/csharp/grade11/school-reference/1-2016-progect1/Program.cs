using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
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
                b = int.Parse(Console.ReadLine());
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b" + b);
            }
            else
                if (b < a)
                    b = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
        }
    }
}
