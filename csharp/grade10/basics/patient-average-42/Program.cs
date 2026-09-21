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
            int num = 0;
            int sum = 0;
            int highest = 0;
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Enter the amount of patients in devision " + i);
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > highest)
                {
                    highest = num;
                }
            }
            Console.WriteLine("The patient average is: " + (sum/6));
            Console.WriteLine("The highest patient number is: " + highest);
        }
    }
}

/* • בבית חולים יש 6 מחלקות. כתבו פעולה שקולטת את מספר החולים בכל מחלקה ומציגה את מספר
החולים הממוצע למחלקה ואת מספר החולים המקסימלי למחלקה (כלומר, את מספר החולים
במחלקה בה יש מספר גדול ביותר של חולים). */
