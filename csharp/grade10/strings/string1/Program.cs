using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static string InputString()
        {
            Console.Write("Insert any string of Keyboard -> ");
            string mystr = Console.ReadLine();
            return mystr;
        }
        public static void OutputString(string mystr)
        {
            Console.Write("The my string from Keyboard -> ");
            Console.WriteLine(mystr);
        }


        static void Main(string[] args)
        {
            string name = "  ";
            name = InputString();
            OutputString(name);
            Console.WriteLine("First char of string -> " + name[0]);
            Console.WriteLine("Last  char of string -> " + name[name.Length - 1]);
            Console.WriteLine("Sub String First -> " + name.Substring(name.Length / 2));
            Console.WriteLine("Sub String Last -> " + name.Substring(0, name.Length / 2));
            Console.WriteLine("Three first Char of string -> " + name[0] + name[1] + name[2]);
            Console.WriteLine("Three Last Char of string -> " + name[name.Length - 3] + name[name.Length - 2] + name[name.Length - 1]);

        }
    }
}
