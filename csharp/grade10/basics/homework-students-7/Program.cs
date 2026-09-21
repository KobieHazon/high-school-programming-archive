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
            Console.WriteLine("Enter the number of hours you spent doing homework");
            int Hours = int.Parse(Console.ReadLine());
            int Sum = 0;
            int Good_Students = 0;
            while (Hours < 70)
            {
                Good_Students++;
                Sum++;
                if (Hours > 15)
                {
                    Good_Students++;
                }
                else
                {
                }
                Console.WriteLine("Enter the next student's hour:");
                Hours = int.Parse(Console.ReadLine());
                Sum++;

                Console.WriteLine("The number of 15+ hours students are:" + Good_Students);
                Console.WriteLine("The number of students is::" + Sum);
                
            }
            Console.WriteLine("Finish");
        }
    }
}
