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
            double grade = 60, sum = 0, counter = 0;
            while (grade > 50 && grade < 90)
            {
                Console.WriteLine("Enter a grade: ");
                grade = int.Parse(Console.ReadLine());
                sum = grade + sum;
                counter++;
                Console.WriteLine("Do you want to continue input? ");
                int contin = int.Parse(Console.ReadLine());
                if (contin !=1)
                {
                    grade = 100;
                }

            }
            Console.WriteLine("The average of the grade between 50 and 90 is: " + (sum / counter));
        }
    }
}

/* כתבו פעולה שתקלוט את הציונים במדעים בבחינת הבגרות האחרונה. הפעולה תציג את ממוצע
הציונים של הנבחנים שציוניהם בין 50 לבין 90 . מספר הנבחנים אינו ידוע. לאחר קליטת כל תוצאה,
הפעולה תשאל את המשתמש האם ברצונו להקליד תוצאות נוספות. במידה והמשתמש יקליד את
המספר 1, הפעולה תפנה לקליטת התוצאה הבאה. קליטת הנתונים תסתיים לאחר שהמשתמש יקליד
. מספר שונה מ- 1 */
