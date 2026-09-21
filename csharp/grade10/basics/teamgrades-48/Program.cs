using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lowest = 0;
            int grade = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Team number " + (i+1));
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Enter the grade for kid "+ (j+1));
                    grade = int.Parse(Console.ReadLine());
                    sum += grade;
                }
                if ((sum/4) < lowest)
                {
                    lowest = (sum / 4);
                }
            }
            Console.WriteLine("The lowest average is :" + lowest);
        }
    }
}
/* בבית הספר "תפארת" לומדים אנגלית ב- 3 קבוצות. בכל קבוצה 4 תלמידים. כתבו פעולה שקולטת
את הציונים שקיבלו כל התלמידים במבחן האחרון, מחשבת את הממוצע בכל קבוצה, ומציגה את
הממוצע המינימלי. */
