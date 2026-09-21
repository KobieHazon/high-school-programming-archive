using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualArrayActions
{
    class Program
    {
        public static int[,] kelet(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("_____________________________");
            Console.WriteLine();
            return array;
        }

        public static void pelet(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________________________");
            Console.WriteLine();

        }

        public static void sumrow(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("The sum in row {0}:", i);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                Console.Write(sum);
                Console.WriteLine();
                sum = 0;

            }
            Console.WriteLine("_____________________________");
            Console.WriteLine();

        }

        public static void sumcolumn(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine("The sum in column {0}:", i);
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
                Console.Write(sum);
                Console.WriteLine();
                sum = 0;
            }
        }

        public static int diagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        public static int subdiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, (array.GetLength(1)-1-i)];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            array = kelet(array);
            pelet(array);
            sumrow(array);
            sumcolumn(array);
            pelet(array);
            Console.WriteLine(diagonal(array));
            Console.WriteLine(subdiagonal(array));
            
        }
    }
}
