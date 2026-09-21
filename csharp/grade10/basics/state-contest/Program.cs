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

            Console.Write("Enter the number of wins your teams has had this year: ");
            int wins = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of losses your team had this year:");
            int losses = int.Parse(Console.ReadLine());

            if (wins > 6 && losses < 5) 
            {
                Console.WriteLine("You can go to the state contest");
            }
            else
            {
                Console.WriteLine("You cant go to the dtate contest");
            }

        }
    }
}


/* כדי להשתתף בתחרות ארצית לנבחרות כדורגל, הנבחרת צריכה לצבור יותר מ- 6 ניצחונות ופחות מ- 5
הפסדים.
• כתבו פעולה שתקלוט את מספר הניצחונות ומספר ההפסדים שהיו לנבחרת בית הספר במשך העונה
האחרונה. הפעולה תודיע האם הנבחרת עלתה או לא עלתה לתחרות הארצית.
• שימרו, הריצו ובדקו שהתקבל הפלט הרצוי. */
