using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static string Backwards(string str)
        {
            char[] newarr = new char[str.Length];
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[str.Length - 1 - i];
            }
            string newstr = new string(newarr);
            return newstr;
        }

        public static bool palindrom(string str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;
            while (str != "Exit")
            {
                if (palindrom(str) == true)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("The backword is: " +Backwards(str));
                }
                str = Console.ReadLine();
            }
            Console.WriteLine("The number of Palindroms were: " +count);
        }
        
    }
}
