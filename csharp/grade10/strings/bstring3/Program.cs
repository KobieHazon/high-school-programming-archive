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
            string str = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
