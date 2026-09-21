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
            Console.WriteLine("Enter a string: ");
            string st = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ' ' && i + 1 < st.Length)
                {
                    if ((st[i+1] == 'a') || (st[i+1] == 'A'))
                    {
                        counter++;
                    }
                }
            }
            if (st.Length > 0 && (st[0] == 'A' || st[0] == 'a'))
            {
                counter++;
            }
            Console.WriteLine("The number of beginining 'a's are: " + counter);
          

         }
    }
}
