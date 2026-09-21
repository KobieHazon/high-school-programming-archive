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
            int num1 = 0; int num2 = 0; int sum = 0;
            Console.WriteLine("Enter 2 numbers: " );
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            int diff = Math.Abs(num1 - num2)+1;
            for (int i = 0; i < diff; i++)
            {
                sum = sum + (num1);
                num1 = num1 + 1;
            }
            Console.WriteLine("The sum of numbers between are:" + sum);
        }
    }
}
/*כתבו פעולה שקולטת שני מספרים שלמים ומציגה את סכום המספרים השלמים בין המספר הראשון
למספר השני (כולל). למשל, אם המספרים שנקלטו הם 4 ו- 12 אז הפעולה תציג 72
.(4+5+6+7+8+9+10+11+12=72)
שימו לב: יתכן כי המספר שייקלט ראשון, יהיה הגדול מבין שני המספרים שיקלטו.*/
