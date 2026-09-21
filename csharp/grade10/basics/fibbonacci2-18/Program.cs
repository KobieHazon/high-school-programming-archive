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
            int num1 = 1, num2 = 1, sum = 1, BigSum = 0;
            while (BigSum < 1000)
            {
                Console.WriteLine( + sum + ",");
                num1 = num2;
                num2 = sum;
                BigSum = BigSum + sum;
                sum = num1 + num2;
                
            }
        }
    }
}
