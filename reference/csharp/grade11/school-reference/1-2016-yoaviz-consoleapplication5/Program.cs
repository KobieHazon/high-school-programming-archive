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
            double age;
            Console.WriteLine("enter age");
            age = double.Parse(Console.ReadLine());
            if (age >= 17)
                Console.WriteLine("license");
            else
                Console.WriteLine("no license");

        }
    }
}
