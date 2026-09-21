using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int cnt = 0;
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if ( i == str.Length-1)
                {
                    if (str[i] != str[i-1])
                    {
                        cnt++;
                    }
                }

                else if (str[i] != str[i + 1])
                {
                    cnt++;
                }
            }
            Console.WriteLine("The number of different kinds of chars is: " +cnt);
        }
    }
}
