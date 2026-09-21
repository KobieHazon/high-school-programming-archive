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
            int countA, countB;
            double weight;
            countA = 0;
            countB = 0;
            while (countA <= 50 && countB <= 70)
            {
                Console.WriteLine("enter weight");
                weight = double.Parse(Console.ReadLine());
                if (weight > 150 && weight < 250)
                {
                    countA = countA + 1;
                }
                else
                {
                    countB++;
                }
            }
            if (countA == 50)
            {
                Console.WriteLine("The full crate is A"); 
            }
            else
            {
                Console.WriteLine("The full crate is B");
            }
        }



    }
}

/* בבית אריזה ממיינים את התפוחים לפי
משקלם:
סוג א': תפוחים שמשקלם 150-250 גרם.
הם נארזים בארגז המכיל 50 תפוחים מסוג
א'.
סוג ב': תפוחים אחרים (שמשקלם גדול מ-
250 גרם או קטן מ- 150 גרם).
הם נארזים בארגז המכיל 70 תפוחים מסוג
ב'.
נכתוב פעולה שקולטת משקל של כל תפוח
ובודקת לאיזה סוג הוא שייך. הפעולה
תעצור כאשר אחד הארגזים יתמלא, ותודיע
מיהו הארגז המלא.
לפניכם שלד של פעולה לביצוע המשימה.
• השלימו את הפעולה.
• שימרו, הריצו ובדקו שהתקבל הפלט
המבוקש. */
