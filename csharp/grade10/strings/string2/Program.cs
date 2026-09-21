using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void OutputString(string mystr)
        {
            Console.Write("The is the new string -> ");
            Console.WriteLine(mystr);
        }


        static void Main(string[] args)
        {
            Console.Write("Enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your city: ");
            Console.WriteLine();
            string city = Console.ReadLine();

            if (address.Contains(city))
            {
                address = address.Replace(city, null);
            }
            OutputString(address);
        }
    }
}
