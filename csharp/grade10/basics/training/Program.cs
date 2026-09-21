using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sexy_kobie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of hours you trained this week");
            int hours = int.Parse(Console.ReadLine());
            if (hours < 30)
            {
                Console.WriteLine(" if you continue not practicing enough you will die");
                Console.WriteLine(" you need more hours:" + (30 - hours));
            }
            else
            {
                Console.WriteLine("good job motherfucker");
            }
        }
    }
}
