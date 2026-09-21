using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int Belowdiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 1; i <= array.GetLength(1)-1; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    sum += array[i, j];
                }
            }
            return sum;
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
            Console.WriteLine("The sum is:" + Belowdiagonal(matrix));
        }
    }
}
