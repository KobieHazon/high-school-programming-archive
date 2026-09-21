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
            Console.WriteLine("Enter a number");
            int temp = 0;
            int num = int.Parse(Console.ReadLine());
            temp = num;
            for (int i = 1; i < num; i++)
            {
                if ((temp % 3) == 0)
                {
                    Console.WriteLine(+temp);
                }
                temp--;
            }
        }
    }
}
/*
.n ומציגה את המספרים המתחלקים ב 3- בתחום שבין 1 לבין n • כתבו פעולה שקולטת מספר טבעי
3 • למשל, אם הפעולה תקלוט את המספר 8 היא תציג 6 */
