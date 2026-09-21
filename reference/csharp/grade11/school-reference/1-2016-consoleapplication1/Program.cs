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
            int num1, num2;
            Console.WriteLine("enrer 2 nums");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1=" + num1);
                Console.WriteLine("num2=" + num2);
            }
            else
            {
                Console.WriteLine("num1=" + num2);
                Console.WriteLine("num2=" + num1);
            }

          


             


        }
    }
}
