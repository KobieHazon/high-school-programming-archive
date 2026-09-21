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
            Console.WriteLine("Enter the amount of famlies in you'r neighberhood :");
            int neigh = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of membert in the first family");
            int members = int.Parse(Console.ReadLine());
            int counter = neigh;
            counter--;
            while (counter > 0)
            {
                counter--;
                Console.WriteLine("Enter the amount on members in other family");
                int temp = int.Parse(Console.ReadLine());
                members=members+temp;
                if (temp == 6)
                {
                    Console.WriteLine("The Members on the family are : "+temp);
                }
            }
            int average = (members / neigh);
            Console.WriteLine("The members average is :" + average);
            Console.WriteLine("Finsih");
        }
    }
}


/*• כתבו פעולה שתקלוט את מספר הנפשות שיש בכל אחת מהמשפחות בשכונה. הפעולה תציג את
ממוצע הנפשות למשפחה ואת מספר המשפחות שיש בהן 6 נפשות או יותר.
. מספר המשפחות אינו ידוע. קליטת הנתונים תיפסק עם קליטת המספר 0
• שימרו, הריצו ובדקו שהתקבל הפלט המבוקש. */
