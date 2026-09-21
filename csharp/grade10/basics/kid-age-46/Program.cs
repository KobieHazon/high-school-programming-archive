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
            int low = 0, high = 0, num = 10000;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter the age of the kid " + (i+1));
                num = int.Parse(Console.ReadLine());
                if (num > high)
                    high = num;
                else if (num < low)
                    low = num;

            }
            Console.WriteLine("The oldest kid is " + high + " the youngest kid is " + low);
        }
    }
}
/* לפעולה האחרונה בתנועת הנוער הגיעו 12 ילדים. כתבו פעולה שתקלוט את גילאי הילדים (מספרים
ממשיים). הפעולה תציג את הגיל של הילד הצעיר ביותר ואת הגיל של הילד המבוגר ביותר. */
