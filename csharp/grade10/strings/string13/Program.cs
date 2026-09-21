using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static string space(string str)
        {
            bool loopstop = false;
            int dltcnt = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                loopstop = false;
                dltcnt = 0;
                for (int j = i; loopstop == false; j++)
                {
                    if (str[j] == str[j+1] && str[j+1] == ' ')
                {
                    dltcnt++;
                }
                    if (str[j+1] != ' ')
                    {
                        loopstop = true;
                    }
                
                }

                str = str.Remove(i+1, dltcnt);
            }
            return str;
        }

        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            Console.WriteLine(space(str));

        }
    }
}
