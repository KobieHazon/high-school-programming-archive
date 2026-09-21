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
            Modaa a = new Modaa("Sport", "Ori", 9, "sss");
            Modaa b = new Modaa("Sport", "Omer", 6, "ssss");
            Modaa c = new Modaa("Others", "Osher", 1, "sasfsassa");

            Board b1 = new Board();
            b1.AddModaa(a);
            b1.AddModaa(b);
            b1.AddModaa(c);
            Console.WriteLine("Before Updating-------------->\n");
            Console.WriteLine(b1.ToString());
            b1.Updater();
            Console.WriteLine("After Updating------------>\n");
            Console.WriteLine(b1.ToString());

        }
    }
}
