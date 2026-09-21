using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {


        public static int BiggestNColumn(int[,] matriz, int Ccheck)
        {
            int ColumnMax = 0;
            int i;


            for ( i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, Ccheck] > ColumnMax)
                {
                    ColumnMax = matriz[i, Ccheck];
                    
                }
            }
            return ColumnMax;
        }


        public static void arreykelet(int[,] ar, int row)
        {


            for (int i = 0; i < ar.GetLength(0); i++)
            {


                Console.WriteLine(" Enter {1} numbers for line {0} ", i, (row ));
                for (int j = 0; j < ar.GetLength(1); j++)
                    ar[i, j] = int.Parse(Console.ReadLine());


            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("How many rows is the array?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns is the array?");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, column];

            arreykelet(matrix, row);
            Console.WriteLine("Which column would you like to check? ");
            int Ccheck = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("The biggest number in the column {0} is " + BiggestNColumn(matrix, Ccheck), Ccheck);
        }

    }
}
