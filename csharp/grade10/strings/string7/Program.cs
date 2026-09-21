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

            Console.WriteLine("Enter a string- st: :");
            string st = Console.ReadLine();

            Console.WriteLine("Enter string x: ");
            string x = Console.ReadLine();

            Console.WriteLine("Enter string y :");
            string y = Console.ReadLine();


            int temp= st.IndexOf(x);
            string newst = st.Remove(temp, x.Length);
            newst = newst.Insert(temp, y);
            Console.WriteLine(newst);
        }
    }
}
