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
            int num1 = 0; int num2 = 0;int between = 0;
            Console.WriteLine("Enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            between = (num2 - num1) + 1;
            for (int i = 0; i < between; i++)
            {
                Console.WriteLine("The numbers between them are:" + num1);
                num1 = num1 + 1;
            }
        }
    }
}
