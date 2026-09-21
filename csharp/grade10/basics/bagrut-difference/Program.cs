using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static double Difference(double a , double b)
        {
            return (a - b);
        }
        
        static void Main(string[] args)
        {
            double Shield = 0, Bagrut = 0, diff = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter your shield score: ");
                Shield = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter you bagrut score: ");
                Bagrut = double.Parse(Console.ReadLine());
                diff = Difference(Shield, Bagrut);
                
            } while (Shield < 101);
        }
    }
}

/* משימה 26
במשרד החינוך הוחלט לבדוק את הקשר בין ציון המגן לבין הציון בבחינת הבגרות.
כתבו פעולה שתקלוט עבור כל אחד מהתלמידים שניגשו לבחינת הבגרות האחרונה באנגלית את ציון
המגן ואת ציון בחינת הבגרות. קליטת הנתונים תפסק עם קליטת ציון מגן 101 (אין לקלוט ציון בגרות
עבור נתון זה). הפעולה תחשב ותציג:
א. את ההפרש בין ציון המגן לציון הבגרות של כל תלמיד.
ב. את ההפרש הגבוה ביותר בין ציון המגן לבין ציון הבגרות של תלמיד אחד.
ג. את ההפרש הממוצע בין ציון המגן לציון הבגרות. */
