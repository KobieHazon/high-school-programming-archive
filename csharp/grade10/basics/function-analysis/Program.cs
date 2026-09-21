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
            Console.WriteLine("enter the three coefficient for the quadratic equation");
            Console.WriteLine();
            Console.Write("A=");
            long a = long.Parse(Console.ReadLine());
            Console.Write("\nB=");
            long b = long.Parse(Console.ReadLine());
            Console.Write("\nC=");
            long c = long.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The Quadratic Equation is:" + "y=" + a + "x²+" + b + "x+" + c);
            long root = ((b * b) + (-1) * (4) * a * c);

            if (root < 0)
            {
                Console.WriteLine("There isnt any solution to the descrimenant");
            }
            else if (root == 0)
            {
                Console.WriteLine("There is one solution the the descrimenant (0)");
            }
            else
            {
                Console.WriteLine("There are two solutions to the descrimenant");
            }

        }
    }
}
