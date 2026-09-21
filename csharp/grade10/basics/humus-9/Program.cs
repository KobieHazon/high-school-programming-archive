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
            
            Console.WriteLine("Enter the price of your humus");
            double price = double.Parse(Console.ReadLine());
            cheapest = price; first = price; second = price;
            while (price >= 0)
            {

                if (price )
                {
                    cheapest = price;
                    if (price < first && price > cheapest)
                    {
                        
                    }
                }
                if (price > first)
                {
                    second = first;
                    first = price;
                }
                Console.WriteLine("Enter the price of the humus");
                price = double.Parse(Console.ReadLine());

                      
            }
            Console.WriteLine("The cheapest humus is " + second + " The expansive humus is: " + first);
        }

    }
}
