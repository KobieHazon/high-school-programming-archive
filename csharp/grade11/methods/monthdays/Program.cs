using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int days(int month, int year)
        {
            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    return 29;
                }
            }
            else if (month > 7)
            {
                if (month % 2 == 0)
                {
                    return 31;
                }
                else
                {
                        return 30;
                }
            }
            else
            {
                if (month % 2 == 0)
                {
                    return 30;
                }
                else
                {
                    return 31;
                }
            }
            return 0;
            
            
        }
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine(days(month,year));
        }
    }
}
