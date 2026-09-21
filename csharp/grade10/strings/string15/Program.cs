using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool site(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.StartsWith("WWW.") == true)
                {
                    if (str.EndsWith(".NET") == true || str.EndsWith(".COM") == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (site(str) == true)
            {
                Console.WriteLine("I did it");
            }
            else
            {
                Console.WriteLine("I did it(false)");
            }
        }
    }
}
