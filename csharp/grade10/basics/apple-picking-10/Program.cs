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
            double cheapest = 1000, first = 0, second = 0;

            Console.WriteLine("Enter the weight of apples each student picked");
            double price = double.Parse(Console.ReadLine());
            cheapest = price; first = price; second = price;
            while (price >= 0)
            {
                    
                if (price < first && price > second)
                {
                    second = price;
                }
                
                if (price > first)
                {
                    second = first;
                    first = price;
                }
                Console.WriteLine("Enter the weight of apples each student picked");
                price = double.Parse(Console.ReadLine());


            }
            Console.WriteLine("The most apples a student picked is: " + first + " The second most apples a student picked is: " + second);
        }

    }
}
