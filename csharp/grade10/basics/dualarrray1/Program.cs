using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static public void Dualarray1()
        {
            Console.WriteLine("How many rows do you want?");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns do you want?");
            int j = int.Parse(Console.ReadLine());
            int [,] BiggestNRow = new int [ j, i];
            j = 0;
            i = 0;
            for ( j = 0; j < BiggestNRow.GetLength(0); j++)
			{
                for (i = 0; i < BiggestNRow.GetLength(1); i++)
                {
                    Console.WriteLine("Enter a number for row {0} and column {1}" , i, j);
                    BiggestNRow[j, i] = int.Parse(Console.ReadLine());
                }
            }
            j = 0; i = 0;
            int biggest = 0;
            int columncounter = 0;
            for ( i = 0; i < BiggestNRow.GetLength(1); i++)
            {
                for (j = 0; j < BiggestNRow.GetLength(0); j++)
                {
                    if (BiggestNRow[j,i] > biggest)
                    {
                        biggest = BiggestNRow[j, i];
                        columncounter = i;
                    }
                }
                Console.WriteLine("The biggest number in row {0} is " + biggest, i);
                
            }
            
        }

        static void Main(string[] args)
        {
            Dualarray1();
        }
    }
}

/* .  כתוב פעולה המקבלת מערך דו ממדי ומדפיסה את המספר הגדול בכל שורה ומיקומו. */
