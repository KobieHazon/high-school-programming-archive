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
            int height = 0;
            int low = 0;
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter the height for plant "+(i+1));
                height = int.Parse(Console.ReadLine());
                if (height < 75)
                {
                    count++;
                    Console.WriteLine("The height is: " + height);
                }
                
            }
        }
    }
}

/* במשתלה שתלו 7 שתילים. לאחר מספר חודשים מדדו את הגובה של השתילים. כתבו פעולה
שקולטת את הגובה של כל אחד מהשתילים ומציגה את הגובה של השתילים שנמוכים מ- 75
סנטימטרים ואת מספר השתילים שנמוכים מ- 75 סנטימטרים. */
