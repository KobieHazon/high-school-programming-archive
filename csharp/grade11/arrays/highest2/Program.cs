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
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int HighestP = 0;
            int Highest2P = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] > A[HighestP])
                {
                    HighestP = i;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] > A[Highest2P] && A[i] != A[HighestP])
                {
                    Highest2P = i;
                }
            }
            Console.WriteLine("The highest place in the array is {0} and its number is {1}. \nThe second highest place is {2} and its number is {3}",HighestP, A[HighestP], Highest2P, A[Highest2P]);
        }
    }
}
