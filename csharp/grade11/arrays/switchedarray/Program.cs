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
            int[] temp = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                temp[i] = A[i];
            }
            for (int i = 0; i < N; i++)
            {
                A[i] = temp[N - i -1];
            }
            Console.WriteLine("The original array :");
            for (int i = 0; i < N; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.Write("\nThe switched array :\n");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
