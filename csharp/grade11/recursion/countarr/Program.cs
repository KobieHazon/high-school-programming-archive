using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountArr
{
    class Program
    {
        public static int CountArr(int[] Arr, int Num)
        {
            return CountArr(Arr, Num, Arr.Length - 1);
        }

        public static int CountArr(int[] Arr, int Num, int size)
        {
            if (size == -1)
            {
                return 0;
            }
            else
            {
                if (Arr[size] == Num)
                {
                    return 1 + CountArr(Arr, Num, size - 1);
                }

                else
                    return CountArr(Arr, Num, size - 1);
            }
        }


        static void Main(string[] args)
        {
            int[] Arr = {1, 2, 3, 4, 3, 2, 1, 3, 3};
            int num = 3;
            Console.WriteLine(CountArr(Arr, num));
        }
    }
}
