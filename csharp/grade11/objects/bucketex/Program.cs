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
            while (true)
            {
                Console.WriteLine("What is the capacity of the 3 buckets?");
                int[] capacity= new int[3];
                for (int i = 0; i < 3; i++)
                {
                    capacity[i] = int.Parse(Console.ReadLine());
                }
                Bucket B1 = new Bucket(capacity[0]);

		
                
            }
        }
    }
}
