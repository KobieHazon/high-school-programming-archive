using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrDiff
{
    class Program
    {
        public static bool sidra(int[] arr)
        {
            if (arr.Length < 2)
                return true;
            return sidra(arr, 0);
        }
        private static bool sidra(int[] arr, int pointer)
        {
            if (pointer != arr.Length - 2)
            {
                if (arr[pointer + 1] - arr[pointer] != arr[pointer + 2] - arr[pointer + 1])
                    return false;
                else
                    return sidra(arr, pointer + 1);
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 13, 17 };
            Console.WriteLine(sidra(arr));
        }
    }
}
