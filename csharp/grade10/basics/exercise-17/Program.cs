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
            double num = 1;
            while (num != 0)
            {
                Console.WriteLine("Enter a number: ");
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    num = (num * -1); 
                }
                Console.WriteLine("The value of the number you entered is: " + num);
            }
        }
    }
}

/* כתבו פעולה שקולטת מספרים ממשיים ומדפיסה את הערכים המוחלטים של המספרים הנקלטים.
במידה והמספר הנקלט הוא מספר שלם, יודפס הערך המוחלט כמספר שלם (כלומר ללא נקודה
. עשרונית וללא אפסים לאחר הנקודה). קליטת המספרים תסתיים עם קליטת המספר 0
כדי לבדוק אם הוא שלם או שאינו שלם. (casting) רמז: לאחר קליטת כל מספר יש לבצע המרה */
