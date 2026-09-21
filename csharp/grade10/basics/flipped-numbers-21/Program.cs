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
            int temp, num1, num2;
            do
            {
            Console.WriteLine("Enter a pair of numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine("The flipped numbers are: " + num1 + "," + num2);
            } while (num1 > 0 && num2 > 0);

            Console.WriteLine("Finish");
        }
    }
}


/* כתבו פעולה שקולטת זוגות של מספרים ומציגה כל זוג כזה במהופך (כלומר עבור הקלט 7
7). הפעולה תעצור כאשר אחד המספרים בזוג יהיה שלילי. בסיום הפעולה יוצג מספר הפעולה תציג 3
הזוגות שנקלטו (לא כולל את הזקיף – הזוג בו היה מספר שלילי).
while א. כתבו את הפעולה בעזרת הוראת החזרה
do-while ב. כתבו את הפעולה בעזרת הוראת החזרה
• הריצו את שתי הפעולות ובדקו שהתקבלו ההדפסות המבוקשות. */ 
