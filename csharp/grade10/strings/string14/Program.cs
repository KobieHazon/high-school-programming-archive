using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int gmail(string[] str)
        {
            string sub = " ";
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] == '@')
                    {
                        sub = str[i].Substring(j+1, 5);
                        if (sub == "gmail")
                        {
                            cnt++;
                        }
                    }

                    
                    sub = " ";
                }
                
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine(gmail(str));

        }
    }
}
