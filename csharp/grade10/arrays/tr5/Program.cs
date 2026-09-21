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
            int[,] matrix = new int[5, 14];
            int i = 0;
            int j = 0;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            int dayweek = 1;
            int sclass= 1;
            int scounter = 0;
            int sum = 0;
            int temp = 0;
            int STemp = 0;
            int BiggestClass = 0; ;
            i = 0; j = 0;
            while (dayweek <= 5 && dayweek >= 1)
            {
                matrix[(dayweek - 1), (sclass - 1)] = matrix[(dayweek - 1), (sclass - 1)] + temp ;
                scounter = scounter + 1;
                temp = 1;
                Console.WriteLine("You are the {0} late student", scounter);
                Console.WriteLine("Enter the day in which you were late: ");
                dayweek = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the class you are in: ");
                sclass = int.Parse(Console.ReadLine());
                Console.WriteLine("_____________________");
            } 

            Console.WriteLine("_____________________");
            Console.WriteLine("The number of late kids in all classes is {0}", (scounter-1));
            i = 0; j = 0; sum = 0;
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                STemp = sum;
                for (i = 0; i < matrix.GetLength(0); i++)
                {
                    sum = sum + matrix[i, j];
                }
                if (sum > STemp)
                {
                    BiggestClass = j;
                }
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("Class number {0} is the class with most late kids", (BiggestClass+1));
            i = 0; j = 0; int DSum = 0; int SmallesttDay = 0; STemp = 1000;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    DSum += matrix[i, j];
                }
                if (DSum <
                    STemp)
                {
                    SmallesttDay = i;
                    STemp = DSum;
                }
                DSum = 0;
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("Day {0} is the day with the least late kids", (SmallesttDay+1));
        }
    }
}

/* בשכבת ט 14 כיתות , רכזת השכבה רוצה לעקוב אחר איחורי התלמידים ב-5 ימות השבוע. 
כתוב תכנית הקולטת לכל מאחר את מספר היום בשבוע  ומספר הכיתה שלו לסיום  הקליטה   
 * יוקש מספר יום שאינו בתחום. על התוכנית להציג על מסך:
 */
