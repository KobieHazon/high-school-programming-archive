using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void BiggerABC(string str)
        {
            for (int i = 0; i <= str.Length-1; i++)
            {
                if (i == str.Length-1)
                {
                    if (str[i] == (str[i-1]))
                    {
                        Console.Write(" ({0},{1}),",str[i],str[i-1]);
                    }
                }

                else if (str[i+1] == (str[i]+1))
                {
                    Console.Write(" ({0},{1}),",str[i],str[i+1]);
                }
            }
        }
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            BiggerABC(str);
        }
    }
}
