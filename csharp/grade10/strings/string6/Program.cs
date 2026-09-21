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

          
            string str1 = null;
            string x = null;
            int count = 0;

            Console.Write("Enter string - ");
            str1 = Console.ReadLine();

            Console.Write("Enter another string - ");
            x = Console.ReadLine();

            while (str1.IndexOf(x) != - 1)
            {
                if (str1.EndsWith(x))
                {
                    str1 = str1.Remove(str1.IndexOf(x), x.Length);
                    count++;

                }
                else
                {
                    str1 = str1.Remove(str1.IndexOf(x), x.Length+1);
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(str1);
            
              
        }
    }
}
