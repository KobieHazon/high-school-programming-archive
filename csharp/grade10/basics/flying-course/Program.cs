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
            Console.WriteLine("Enter the number of education years:");
            int years = int.Parse(Console.ReadLine());
            if (years >= 15)
            {
                Console.WriteLine("You can go to the course");
            }
            else if (years < 15 && years >= 12)
            {
                Console.Write("you can go to the course if you have a high bagrut grade:");
                int grade = int.Parse(Console.ReadLine());
                if (grade> 90)
                {
                    Console.WriteLine("you can go to the course");
                }
                else
                {
                    Console.WriteLine("you cant go to the course");
                }
                
            }
            else
            {
                Console.WriteLine("you cant go to the course");
            }
                
        }
    }
}


/* כדי להתקבל לקורס טייס אזרחי, על המועמד לעמוד באחת משתי הדרישות הבאות:
לרכוש מעל 15 שנות השכלה. 􀂃
לרכוש מעל 12 שנות השכלה ולקבל ציון ממוצע גבוה מ- 90 בתעודת הבגרות. 􀂃
• כתבו פעולה שתקלוט את מספר שנות ההשכלה של אדם המבקש להתקבל לקורס טייס, ואת ציון
תעודת הבגרות שלו. הפעולה תודיע האם המבקש התקבל או לא התקבל לקורס.
• הקלידו, שימרו, הריצו מספר פעמים ובדקו שמתקבל הפלט המתאים. */
