using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {


        public static void maximum(int[,] matriz)
        {


            int max;
            int columnnumber = 0;
            int i, j;


            for (i = 0; i < matriz.GetLength(0); i++)
            {

                max = matriz[i, 0];
                columnnumber = 0;

                for (j = 0; j < matriz.GetLength(1); j++)
                {


                    if (max < matriz[i, j])
                    {


                        max = matriz[i, j];
                        columnnumber = j;

                    }

                }


                Console.WriteLine("The maximum for the line is:" + max + " and its location is: " + i + "," + columnnumber);
            }


        }






        public static void arreykelet(int[,] ar , int row) 
{


            for (int i = 0; i < ar.GetLength(0); i++)
            {


                Console.WriteLine(" Enter {0} numbers for line {1} ", row,i );
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
            Console.WriteLine("-----------------------------------------");
            maximum(matrix);
        }

    }
}
