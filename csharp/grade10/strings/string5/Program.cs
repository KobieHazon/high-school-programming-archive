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

            //Console.Write("Enter your addrese: ");
            //string addrese = Console.ReadLine();
            //Console.Write("Enter your city: ");
            //string city = Console.ReadLine();
            //two(city, addrese);

            Console.Write("Enter a random sentence: ");
            string stnc = Console.ReadLine();
            five(stnc);

        }

        public static void two(string city, string add)
        {

            int place = add.IndexOf(city);
            if (place > -1)
            {
                string newadd = add.Remove(place, city.Length);
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("The new addrese is: {0}", newadd);
            }

        }
        public static void three(string st)
        {
            int wordcount = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == 'A' || (st[i] == 'a' && st[i-1] == ' '))
                {
                    wordcount++;
                }
            }

            Console.WriteLine("The sentence has {0} words which start with the letter 'a'.", wordcount);

        }
        public static void five(string st)
        {
            int wordcount = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == 'Y' && st[i + 1] == ' ')
                {
                    wordcount++;
                }
            }

            Console.WriteLine("The sentence has {0} words which start with the letter 'a'.", wordcount);

        }
        public static void seven(string x, string y, string st)
        {



        }
    }
}
