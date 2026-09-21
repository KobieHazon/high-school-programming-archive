using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {


        public static void minimum(int[,] matriz)
        {
            int min = 100000;
            int columnnumber= 0;
            int rownumber = 0;
            int i, j;

            for (i = 0; i < matriz.GetLength(0); i++)
            {

                for (j = 0; j < matriz.GetLength(1); j++)
                {

                    if (min > matriz[i, j])
                    {
                        min = matriz[i, j];
                        columnnumber = j;
                        rownumber = i;
                    }
                }

            }
            Console.WriteLine("The minimum for the whole array is:" + min + " and its location is: " + rownumber + "," + columnnumber);
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
            Console.WriteLine("-----------------------------");
            minimum(matrix);
        }

    }
}
