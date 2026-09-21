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
            int target = 100;

            int[] ways = new int[101];
            ways[0] = 1;
            for (int i = 1; i <= 99; i++)
            {
                for (int j = i; j <= target; j++)
                {
                    ways[j] += ways[j - i];
                }
            }
            Console.WriteLine(ways[100]);

        }
    }
}
