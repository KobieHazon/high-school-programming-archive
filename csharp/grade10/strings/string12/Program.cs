using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public static bool legal(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    counter++; 
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    counter++;
                }
            }
            if (counter >= 3)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (legal(password) == true)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                while (legal(password) == false)
                {
                    password = Console.ReadLine();
                }
                Console.WriteLine("Welcome");
            }
        }
    }
}
