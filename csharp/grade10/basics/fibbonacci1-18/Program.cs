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
            int num1 = 1, num2 = 1, sum = 1;
            Console.Write(+ num1 + ",");
            while (sum < 50)
            {
                Console.Write(+ sum + ",");
                num1 = num2;
                num2 = sum;
                sum = num1 + num2;

            }
            Console.WriteLine("Finish");
        }
    }
}

/* סדרת פיבונצ'י היא סדרה אינסופית של מספרים: ........ 55
הערך של האיבר הראשון ושל האיבר השני בסדרה הוא 1, והערך של כל אחד מהאיברים הנוספים הוא
סכום שני האיברים שלפניו.
(1 1 2 … 34) • כתבו פעולה שמציגה את מספרי פיבונצ'י הראשונים שקטנים מ – 50 */
