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
            const int N = 6;
            char[] numbers_one = new char[N];
            int[] numbers_two = new int[N];
            Console.WriteLine("Enter values for number_one:");
            for (int i = 0; i < N; i++)
            {
                numbers_one[i] = char.Parse(Console.ReadLine());  
            }
            Console.WriteLine("Enter values for number_two:");
            for (int i = 0; i < N; i++)
            {
                numbers_two[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(numbers_one[numbers_two[i]-1]);
            }
            Console.WriteLine();
        }
    }
}
