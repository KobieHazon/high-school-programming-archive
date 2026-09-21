using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Psikim
{
    class Program
    {
        public static void Psikim(long x)
        {
            if (x < 1000)
            {
                Console.Write(x);
            }
            else
            {
                Psikim(x / 1000);
                Console.Write( "," + x % 1000 );
            }
        }

        private static int DigitSum(int x)
        {
            if (x < 10)
                return x;
            else
                return (DigitSum(x / 10) + (x % 10));
        }

        public static bool DSumE(int[] arr, int Num)
        {
            return DSumE(arr,Num, 0);
        }
        private static bool DSumE(int[] arr, int Num, int pointer)
        {
            if (pointer == arr.Length)
                return true;
            else
            {
                if (DigitSum(arr[pointer]) != DigitSum(Num))
                    return false;
                else
                    return DSumE(arr, Num, pointer + 1);
            }
        }
        public static int SeifGimel(int x)
        {
            return SeifGimel(x, 1);
        }
        public static int SeifGimel(int x, int cnt)
        {
            if (x != 1)
                if ((x % 2) == 0)
                {
                    Console.Write(x + "->");
                    return SeifGimel(x / 2, cnt + 1);
                }
                else
                {
                    Console.Write(x + "->");
                    return SeifGimel((x * 3) + 1, cnt + 1);
                }
            else
                Console.Write(x);
            Console.WriteLine();
            return cnt;


                
        }
        static void Main(string[] args)
        {
            long x = 2398976288494560;
            Psikim(x);
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int D = 12345;
            int[] arr = { 96, 87, 78, 69, 555 };
            if (DSumE(arr, D))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int G = 7;
            Console.WriteLine(SeifGimel(G));
            Console.WriteLine();
        }
    }
}
