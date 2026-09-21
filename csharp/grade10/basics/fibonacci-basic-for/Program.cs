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
            int num2 = 1;
            int num1 = 0;
            int next = 0;
            for (int counter = 0; counter < 12; counter++)
            {
                Console.WriteLine("The next number is:" +next);
                next = num1 + num2;
                num1 = num2;
                num2 = next;

            }
        }
    }
}
