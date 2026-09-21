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
            Random rnd = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10, 101);
            }
            int biggest = 0;
            int smallest = 1000;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] > biggest)
                {
                    biggest = numbers[j];
                }
                if (numbers[j] < smallest)
                {
                    smallest = numbers[j];
                }
            }
            Console.WriteLine("The smallest number is: " + smallest);
            Console.WriteLine("The biggest number is :" + biggest);

        }
    }
}
