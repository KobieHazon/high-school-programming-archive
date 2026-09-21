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
            Console.WriteLine("Enter a number");
            double num = 1;
            double old = 0;
            int counter = 0;
            while (num > old)
            {
               
                old = num;
                num = int.Parse(Console.ReadLine());
                if (num > old)
                {
                    counter++;
                }  

            }
            Console.WriteLine("The number of good numbers is: " + counter);
        }
    }
}

/*  כתבו פעולה שתקלוט מספרים כלשהם. קליטת הנתונים תיפסק כאשר ייקלט מספר שלא גדול
מהמספר הקודם לו. הפעולה תציג את מספר המספרים "התקינים" שנקלטו.
4.3 (משמאל לימין), קליטת הנתונים תיפסק 9.0 16.8 40.1 למשל, אם יקלטו המספרים 1.2
לאחר קליטת המספר 1.2 (שלא גדול מ- 40.1 ) והפעולה תודיע כי נקלטו 4 מספרים "תקינים".
• שימרו, הריצו ובדקו שהתקבל הפלט המבוקש. */
