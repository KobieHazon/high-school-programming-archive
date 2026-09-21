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
            int num, count;
            count = 0 ;
            Console.WriteLine("enter number: ");
            num = int.Parse(Console.ReadLine());

            do
	{
	  count++;
          Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
	} while (num > 0);
            Console.WriteLine("there are " + count + " positive numbers");

        }
    }
}
