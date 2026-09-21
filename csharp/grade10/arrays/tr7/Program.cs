using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int afterrow(int[,] matriz, int row, int column)
        {
            int sum = 0;
            for (int i = (column+1); i < (matriz.GetLength(1)); i++)
            {
                sum += matriz[row, i];
            }
            return sum;
        }
        public static int aftercolumn(int[,] matriz, int row, int column)
        {
            int sum = 0;
            for (int j = (row+1); j < (matriz.GetLength(0)); j++)
            {
                sum += matriz[j, column];
            }
            return sum;
        }
        public static bool action3(int[,] matriz, int row, int column)
        {
            int Rsum = 0;
            for (int i = (column+1); i < (matriz.GetLength(1)); i++)
            {
                Rsum += matriz[row, i];
            }

            int Csum = 0;
            for (int j = (row+1); j < (matriz.GetLength(0)); j++)
            {
                Csum += matriz[j, column];
            }
            if (Rsum > Csum)
                return true;
            else
                return false;
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
            Console.WriteLine("--------------------------");
            if (action3(matrix, row, column) == true)
            {
                Console.WriteLine("True");
            }

        }
    }
}
