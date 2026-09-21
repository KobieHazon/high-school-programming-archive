using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {


        public static void action(int[,] matriz,int row,int column)
        {
            int MinNRow = 100000;
            int MaxNColumn = 0;
            int i, j;
            for (i = 0; i < matriz.GetLength(1); i++)
            {
                if (MinNRow > matriz[row, i])
                {
                    MinNRow = matriz[row, i];
                }
            }
            for (j = 0; j < matriz.GetLength(0); j++)
			{
                if (MaxNColumn < matriz[j, column])
                {
                    MaxNColumn = matriz[j, column];
                }
			}
            Console.WriteLine("The smallest number in the row is {0}\nThe biggest number in the column is {1}: ", MinNRow , MaxNColumn);
        }






        public static void arreykelet(int[,] ar, int column)
        {


            for (int i = 0; i < ar.GetLength(0); i++)
            {


                Console.WriteLine(" Enter {1} numbers for line {0} ", i, column);
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
            arreykelet(matrix, column);
            Console.Write("Enter the coordinates for the array: \nrow:");
            row = int.Parse(Console.ReadLine());
            Console.Write("Column:");
            column = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            action(matrix , row, column);
        }

    }
}
