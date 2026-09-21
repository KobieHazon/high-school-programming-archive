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
            int startnumber = 2;
            int temp = 0;
            temp = startnumber;
            for (int i = 0; i < 5; i++)
            {
                startnumber = temp;
                Console.Write(+startnumber);
                for (int j = 0; j < (temp-1); j++)
                {
                    startnumber--;
                    Console.Write(+startnumber);
                }

                Console.WriteLine();
                temp++;
            }
        }
    }
}
