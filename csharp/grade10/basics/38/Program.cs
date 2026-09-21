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
            int xcounter = 0;
            for (int i = 0; i < 5; i++)
            {
                xcounter++;
                Console.Write(+xcounter);
                for (int j = 0; j < xcounter; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }
        }
    }
}
