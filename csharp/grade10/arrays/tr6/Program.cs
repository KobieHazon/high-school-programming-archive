using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void arreykelet(int[,] ar, int column)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine(" Enter {1} numbers for line {0} ", i, column);
                for (int j = 0; j < ar.GetLength(1); j++)
                    ar[i, j] = int.Parse(Console.ReadLine());
            }
        }

        public static bool placezugi(int[,] matriz, int row, int column)
        {
            if (matriz[row,column] % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static int linezugi(int[,] matriz, int row)
        {
            int i = 0; int zugicounter = 0;
            for (i = 0; i < matriz.GetLength(1); i++)
            {
                if (placezugi(matriz, row, i) == true)
                {
                    zugicounter++;
                }
            }
            return zugicounter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many rows is the array?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns is the array?");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, column];
            arreykelet(matrix, column);
            int zugisum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                zugisum =zugisum + (linezugi(matrix, i));
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("The number of zugi numbers in this dual array is {0}", zugisum);
        }
    }
}
