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
            for (int i = st.Length-1; i > 0; i--)
            {
                if (st[i] == ' ')
                {
                    if ((st[i-1] == 'a') || (st[i-1] == 'A'))
                    {
                        counter++;
                    }
                }
            }
            if (st[st.Length - 1] == 'A' || st[st.Length - 1] == 'a')
            {
                counter++;
            }
            Console.WriteLine("The number of ending 'a's are: " + counter);
          

         }
    }
}
