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
            Console.WriteLine("How many rows is the array?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns is the array?");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, column];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(" Enter {1} numbers for line {0} ", i, column);
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int Rsum = 0;
                    for (int k = (j+1); k < (matrix.GetLength(1)); k++)
                    {
                        Rsum += matrix[i, k];
                    }

                    int Csum = 0;
                    for (int b = (i+1); b < (matrix.GetLength(0)); b++)
                    {
                        Csum += matrix[b, j];
                    }
                    if (Rsum > Csum)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine("the number of suitable numbers is: " + counter);
        }
    }
}
