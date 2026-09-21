using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_25_
{
    class Program
    {
        static void Main(string[] args)
        {
            int CntBoy = 0, CntGirl = 0;
            do
            {
                Console.WriteLine("The gender of the student is (1= boy, 2= girl): ");
                int gender = int.Parse(Console.ReadLine());
                if (gender == 1)
                {
                    CntBoy++;
                }
                else if (gender == 2)
                {
                    CntGirl++;
                }
                else
                {
                    Console.WriteLine("Enter the gender of the student again: " );
                }
                Console.WriteLine("The number of boys in the class is: " + CntBoy + "\nThe number of girls in the class is: " +CntGirl + "\n In all there are: " +(CntBoy + CntGirl));
            } while (CntBoy <= 20 && CntGirl <=20);
        }
    }
}
/* הנהלת בית ספר "שוויון מוחלט" שואפת שמספר הבנים בכל כיתה יהיה שווה למספר הבנות בכיתה.
לכן, המספר המקסימלי של בנים והמספר המקסימלי של בנות שניתן לקבל לכל כיתה הוא 20 . כתבו
פעולה שתקלוט עבור כל אחד מהתלמידים שמבקשים להירשם לכיתה יא' את מינו ( 1 עבור בן, 2
עבור בת). הפעולה תמנה את מספר הבנים ומספר הבנות שנרשמו לכיתה. קליטת הנתונים תפסק
. כאשר מספר הבנים או מספר הבנות יגיע ל- 20
הפעולה תציג את מספר הבנים ואת מספר הבנות שנרשמו לכיתה.
. יש לשלב מסננת קלט שתוודא כי המין הנקלט הוא אכן 1 או 2 */
