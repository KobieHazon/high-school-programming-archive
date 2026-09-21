using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sexy_karate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number of members who signed:");
                int members= int.Parse(Console.ReadLine());
                if (members > 15)
                {
                    Console.WriteLine("the karate course will open \nthe number of members is:" + members);
                }
                else
                {
                    Console.WriteLine("the karate course will not open because there arent enough member \nin order for it to exist there needs to be more:" + (15 - members));
                }
           
 
        }
    }
}


/*• כתבו פעולה שתקלוט את מספר הילדים שנרשמו לחוג קראטה. 
אם נרשמו יותר מ – 15 ילדים אז: 
א. תוחזר הודעה שהחוג נפתח. 
ב. יוחזר מספר המשתתפים.
אחרת (אם נרשמו 15 ילדים או פחות), אז: 
א. תוחזר הודעה שיש פחות מדי נרשמים. 
ב. יוחזר מספר הילדים שחסר כדי לפתוח את החוג.
• הקלידו, שימרו, הריצו ובדקו שהתקבל הפלט הרצוי. */
