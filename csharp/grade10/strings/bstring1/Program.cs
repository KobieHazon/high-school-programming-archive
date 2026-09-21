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
            string st = " ";
            for (int i = 0; i < 40; i++)
            {
                st = Console.ReadLine();
                if (st.Length % 2 == 0)
                {
                    
                    Console.Write(st + " \n");
                }
            }
        }
    }
}
