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
            int magen = 0; int bagrut = 0; int highdiff = 0; int diff = 0; int counter = 0; int sum = 0;
            do
            {
                counter++;
                Console.WriteLine("Enter your magen grade:");
                magen = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your bagrut grade");
                bagrut = int.Parse(Console.ReadLine());
                diff = Math.Abs( magen - bagrut);
                Console.WriteLine("The Difference between grade" + counter +" is "+diff);
                if (diff > highdiff)
                {
                    highdiff = diff;
                }
                Console.WriteLine("The highest grade difference is" + highdiff);
                 sum = sum + diff;
                Console.WriteLine("The grade difference average is:" + (sum/ counter));
            } while (magen > 0 && bagrut > 0 && bagrut < 100 && magen < 100);
        }
    }
}

/* במשרד החינוך הוחלט לבדוק את הקשר בין ציון המגן לבין הציון בבחינת הבגרות.
כתבו פעולה שתקלוט עבור כל אחד מהתלמידים שניגשו לבחינת הבגרות האחרונה באנגלית את ציון
המגן ואת ציון בחינת הבגרות. קליטת הנתונים תפסק עם קליטת ציון מגן 101 (אין לקלוט ציון בגרות
עבור נתון זה). הפעולה תחשב ותציג:
א. את ההפרש בין ציון המגן לציון הבגרות של כל תלמיד.
ב. את ההפרש הגבוה ביותר בין ציון המגן לבין ציון הבגרות של תלמיד אחד.
ג. את ההפרש הממוצע בין ציון המגן לציון הבגרות.
למשל, עבור הנתונים: ציון מגן: 93 ציון בגרות: 100
ציון מגן: 77 ציון בגרות: 63
ציון מגן: 88 ציון בגרות: 88
הפעולה תציג:
0 = 14 הפרש 3 = 7 הפרש 2 = הפרש 1
הפרש גבוה ביותר= 14 הפרש ממוצע= 7
. יש לשלב מסננת קלט שתבדוק כי הציונים הנקלטים הם בתחום 0-100*/
