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
            int x = 0;
            Console.WriteLine("Enter a string: ");
            string st = Console.ReadLine();

            if (st.Contains('@'))
            {
                st = st.Remove(st.IndexOf('@'));
            }

            Console.WriteLine(st);
        }
    }
}
