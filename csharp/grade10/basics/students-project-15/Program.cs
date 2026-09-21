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
            int CountA = 0, CountB = 0, CountC = 0;
            Console.Write("Enter the number of the student: ");
            double student = double.Parse(Console.ReadLine());
            while (student != 0)
            {
                Console.Write("Did you give the teacher the first project? (True / False) ");
                bool YesNo1 = bool.Parse(Console.ReadLine());
                if (YesNo1 == true)
                {
                    CountA++;
                }
                Console.Write("Did you give the teacher the second project? (True / False) ");
                bool YesNo2 = bool.Parse(Console.ReadLine());
                if (YesNo2 == true)
                {
                    CountB++;
                }
                if (YesNo1 == false && YesNo2 == false)
                {
                    CountC++;
                }
                Console.Write("Enter the number of the student: ");
                student = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("The number of students who gave the first project is: " + CountA );
            Console.WriteLine("The number of students who gave the second project is: " + CountB);
            Console.WriteLine("The number of students that didnt give any project is: " + CountC);

        }
    }
}

/* המורה לפיזיקה הטיל על תלמידיו לכתוב שתי עבודות. כתבו פעולה שקולטת לגבי כל תלמיד 3 נתונים:
.(true / false) האם הגיש עבודה שניה (true / false) מספר תלמיד, האם הגיש עבודה ראשונה
הפעולה תחשב ותציג כמה תלמידים הגישו את העבודה הראשונה, כמה תלמידים הגישו את העבודה
השניה וכמה לא הגישו אפילו עבודה אחת. מספר התלמידים אינו ידוע. קליטת הנתונים תיפסק כאשר
יוקלד תלמיד מספר 0 (אין לקלוט נתונים עבור מספר תלמיד זה). */
