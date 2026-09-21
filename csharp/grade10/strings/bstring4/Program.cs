using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool Bstring4(string str)
        {
            int n = str.Length;
            if (str[0] == str[n - 1])
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (Bstring4(str) == true)
            {
                Console.WriteLine("I did it");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }
}
