using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrSum
{
    class Program
    {
        public static int ArrSum(int[] arr)
        {
            return ArrSum(arr, 0);
        }

        private static int ArrSum(int[] arr, int pointer)
        {
            if (pointer == arr.Length)
                return 0;

            else
                return arr[pointer] + ArrSum(arr, pointer + 1);
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 5, 5 };
            Console.WriteLine(ArrSum(arr));
        }
    }
}
