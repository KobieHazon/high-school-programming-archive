using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("I Love You Kobie \nDo you want to continue?");
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            while (num == 10)
            {
                Console.WriteLine("I Love You Kobie \nDo you want to continue?");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finish");
        }
    }
}
