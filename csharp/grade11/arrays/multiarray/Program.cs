using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int[] Multi(int[] a1, int[] a2)
        {
            int[] a3 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                for (int k = 0; k < a2.Length; k++)
                {
                    a3[i] = (a3[i] + (a1[i] * a2[k]));
                }
            }
            return a3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length for array a1:");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length for array a2:");
            int N2 = int.Parse(Console.ReadLine());
            int[] a1 = new int[N1];
            int[] a2 = new int[N2];
            Console.WriteLine("Enter values for array 1: ");
            for (int i = 0; i < N1; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter values for array 2: ");
            for (int i = 0; i < N2; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The multi array: ");
            for (int i = 0; i < Multi(a1, a2).Length; i++)
            {
                Console.Write(Multi(a1, a2)[i] + " ");
            }


        }
    }
}
