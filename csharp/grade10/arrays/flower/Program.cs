using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int flower(int[,] array, int row, int column)
        {
            int leaves = (array[(row - 1), (column - 1)] + array[row - 1, column + 1] + array[row + 1, column + 1] + array[row + 1, column - 1]);
            if (array[row, column] == leaves)
            {
                return 1;
            }
            else
                return 0;
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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (flower(matrix, i, j) == 1)
                    {
                        Console.WriteLine("You did it");
                    }
                }
            }
            
        }
    }
}
