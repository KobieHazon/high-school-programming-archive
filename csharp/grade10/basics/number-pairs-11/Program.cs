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
            double num1 = 0; double num2 = 0; double counter = 20; double PairCount = 0;
            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            while (counter > 0 && num1 > 0 && num2 > 0 && (num1-num2) != 1 )
            {
                counter--;
               
                if (num1 > num2)
                {
                    Console.WriteLine("The diffrence between the small and big is: " + (num2-num1));
                }
                
                if (num2 > num1)
                {
                    Console.WriteLine("The diffrence between the small and big is: " + (num1 - num2));
                }

                PairCount++;
                
                Console.WriteLine("The number of pairs you entered is:" + PairCount);
                Console.WriteLine("Enter two numbers:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Finish");
        }
    }
}

/* כתבו פעולה שתקלוט זוגות של מספרים, תחסר את המספר הקטן מהגדול ותציג את ההפרש.
הפעולה תעצור כאשר יתקיים אחד מן התנאים הבאים:
א. יקלטו 20 זוגות של מספרים.
ב. אחד מהמספרים הנקלטים הוא שלילי.
. ג. ההפרש בין המספרים (בתוך הזוג) שווה ל- 1
הפעולה תציג גם את מספר הזוגות שנקלטו.
• שימרו, הריצו ובדקו שהתקבל הפלט המבוקש. */
