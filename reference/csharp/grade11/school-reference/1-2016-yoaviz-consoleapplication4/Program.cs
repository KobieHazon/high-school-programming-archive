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
            int grade;
            Console.WriteLine("enter grade");
            grade = int.Parse(Console.ReadLine());
            if (grade > 80)
                Console.WriteLine("good number");
            else if (grade < 55)
                Console.WriteLine("try again");

        }
    }
}
