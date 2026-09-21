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
            const int N = 10;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            for (int i = 0; i < N; i++)
			{
                A[i] = int.Parse(Console.ReadLine());
                B[i] = -1;
                C[i] = 0;
			}
            int POSB = 0;
            int POSC = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] > 0)
                {
                    B[POSB] = A[i];
                    POSB++;
                }
                else
                {
                    C[POSC] = A[i];
                    POSC++;
                }
            }
            Console.WriteLine("The positive numbers:");
            Console.WriteLine();
            for (int i = 0; i < POSB; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The negative numbers:");
            Console.WriteLine();
            for (int i = 0; i < POSC; i++)
            {
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
