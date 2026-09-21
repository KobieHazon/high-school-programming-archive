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
            int a, b;
            int c = 0;
            Console.WriteLine("please, sire enter 2 numbers ur magisty my queen senpai");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


            if (a > b)
            {
                c = b;
                b = a;
                a = c;
            }

              
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
            
      
            
            
                    






        }
    }
}
