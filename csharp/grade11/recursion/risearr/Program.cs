using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseArr
{
    class Program
    {
        public static bool RiseArr(int[] arr)
        {
            if (arr.Length < 2)
                return true;
            return RiseArr(arr, 0);
        }
        public static bool RiseArr(int[] arr, int pointer)
        {
            if (pointer != arr.Length-1)
            {
                if (arr[pointer] >= arr[pointer + 1])
                    return false;
                else
                    return RiseArr(arr, pointer + 1);
            }
            return true;
            
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 14, 37};
            Console.WriteLine(RiseArr(arr));
        }
    }
}
