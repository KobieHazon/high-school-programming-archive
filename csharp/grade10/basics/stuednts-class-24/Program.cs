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
            int student = 0, Class = 0, over = 0, under = 0;
            do
            {
                Console.WriteLine(" Enter the number of kids in a Class: " );
                student = int.Parse(Console.ReadLine());
                Class++;
                if (student > 41)
                {
                    over++;
                }
                if (student < 15)
                {
                    under++;
                }
                Console.WriteLine("The number of classes above maximum is : " + over + ", The number of classes under the minimum is : " + under);

            } while (student > 1);
        }
    }
}

/* כתבו פעולה שתקלוט את מספר התלמידים שנרשמו לכל אחת מכיתות בית הספר. מספר הכיתות
. אינו ידוע. קליטת הנתונים תפסק כאשר ייקלט מספר תלמידים 0
יש לשלב מסננת קלט שתוודא כי יקלטו רק מספרים לא שליליים.
.( • הפעולה תציג: א. לכמה כיתות נרשמו יותר תלמידים מהמותר ( 41
.( ב. לכמה כיתות נרשמו פחות תלמידים מהמינימום הדרוש ( 15 */
