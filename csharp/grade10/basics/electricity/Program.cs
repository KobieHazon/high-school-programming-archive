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
            double TotalBill = 0,temp;
            Console.WriteLine("enter the number of electricity you used ( in killowatts):");
            double electricity = double.Parse(Console.ReadLine());

            if (electricity <= 180)
            {
                Console.WriteLine("your bill is:" + (0.70 * electricity));
            }
            else if (electricity > 180 && electricity < 1000)
                {
                    TotalBill = (180 * 0.70 + 0.90 * (electricity - 180));
                    Console.WriteLine(" your bill is:" + (TotalBill + (TotalBill / 17)));
                }
                else
                {
                    temp = TotalBill/10 + TotalBill/17;
                    Console.WriteLine("your bill is:" + (TotalBill + temp));
                }
            
        }
    }
}

/*להלן שיטת החיוב 56של חשבון 828 החשמל:126 עבור 180 קוט"ש הראשונים, משלם הלקוח 70 אגורות לקוט"ש. 
עבור כל קוט"ש מעבר לזה, התשלום הוא 90 אגורות לקוט"ש. למשל, לקוח שצרך 220 קוט"ש ישלם 70
אגורות עבור 180 קוט"ש, ו- 90 אגורות עבור 40 קוט"ש הנותרים. 
לקוח שצרך יותר מ- 1000 קוט"ש משלם קנס של %10 על כל החשבון.
בנוסף, מחויבים כל הלקוחות ב- %17 מס ערך מוסף על הסכום הכולל. 
• כתבו פעולה שקולטת מספר קוט"ש שצרך לקוח ומדפיסה את החשבון הסופי לתשלום.
• שימרו, הריצו מספר פעמים ובדקו שמתקבל הפלט המתאים. */
