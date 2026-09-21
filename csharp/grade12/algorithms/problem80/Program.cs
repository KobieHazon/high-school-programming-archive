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
            int sum = 0;
            int[] temp = new int[100];
            for (int i = 1; i < 100; i++)
            {
                if (IsRational(i))
                {
                    temp = IntoAr(Math.Pow(i, 0.5));
                    sum = sum + ArSum(temp);
                }
            }
            Console.WriteLine(sum);
        }

        public static int ArSum(int[] Ar)
        {
            int sum = 0;
            for (int i = 0; i < Ar.Length; i++)
            {
                sum = sum + Ar[i];
            }
            return sum;
        }

        public static int[] IntoAr(double num)
        {
            double temp = num - (int)num;
            Console.WriteLine(num);
            int[] Ar = new int[100];
            for (int i = 0; i < 100; i++)
            {
                temp = temp* 10;
                Ar[i] = (int)temp;
                Console.Write(Ar[i] + ", ");
                temp = temp - (int)temp;
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~");
            return Ar;

        }

        public static bool IsRational(int num)
        {
            double temp = Math.Pow(num, 0.5);
            if (temp != (int)temp)
            {
                return true;
            }
            return false;
        }
    }
}
