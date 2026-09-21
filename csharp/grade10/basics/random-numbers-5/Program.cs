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
            double num;
            Console.WriteLine("enter negative number");
            num = double.Parse(Console.ReadLine());
            double result = Math.Abs(num);
            Console.WriteLine("result="+result);
            
           
        }
    }
}
/* כתבו פעולה שתתנהג כמו שתי קוביות משחק. הפעולה תבצע:
. א. תגריל שני מספרים בתחום שבין 1 ל- 6
ב. תציג את המספרים שהוגרלו.
ג. אם המספרים שווים אז תוצג ההודעה: תור נוסף.
אחרת, תוצג ההודעה: התור עובר. */
