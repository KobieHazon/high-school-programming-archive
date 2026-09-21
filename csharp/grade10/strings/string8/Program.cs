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
            string[] str = new string[4];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            int cnt = 0;
            for (int i = 0; i < str.Length-1; i++)
            {

                
                    if (str[i][str[i].Length-1] == str[i + 1][0])
                    {
                    cnt++;
                    }
               
                
                
            }
            Console.WriteLine(cnt);
        }
    }
}

