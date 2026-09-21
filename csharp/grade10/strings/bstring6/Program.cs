using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Password(string str)
        {
            bool num = false;
            bool ch = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    ch = true;
                }
            }
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] >= '0' && str[j] <= '9')
                {
                    num = true;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    ch = true;
                }
            }

            if (num == true && ch == true && str.Length >= 6)
            {
                Console.WriteLine("Good Password");
            }
            else
            {
                do
                {
                    num = false;
                    ch = false;
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] >= 'a' && str[i] <= 'z')
                        {
                            ch = true;
                        }
                    }
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] >= 'A' && str[i] <= 'Z')
                        {
                            ch = true;
                        }
                    }
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j] >= '0' && str[j] <= '9')
                        {
                            num = true;
                        }
                    }
                } while (str.Length < 6 || ch == false || num == false);
                if (num == true && ch == true && str.Length >= 6)
                {
                    Console.WriteLine("Good Password");
                }
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Password(str);
        }
    }
}
