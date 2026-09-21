using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];

            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = random.Next(1000);

            Console.WriteLine("Array before radix sort: " + ArrToString(a) + "\n");

            RadixSort(a); // îéåï äîòøê áàîöòåú îéåï áñéñ

            Console.WriteLine("Array after radix sort: " + ArrToString(a));
        }

        public static void RadixSort(int[] arr)
        {
            Console.WriteLine("Start radix sort....");
            int k, dig, pow = 1;

            Queue<int>[] qarr = new Queue<int>[10];

            for (int i = 0; i < qarr.Length; i++)
                qarr[i] = new Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nstep " + i + "\n------");
                for (int j = 0; j < arr.Length; j++)
                {
                    dig = (arr[j] / pow) % 10;
                    qarr[dig].Insert(arr[j]);
                }
                k = 0;
                for (int j = 0; j < qarr.Length; j++)
                {
                    Console.WriteLine("qarr[" + j + "]: " + qarr[j]);
                    while (!qarr[j].IsEmpty())
                    {
                        arr[k] = qarr[j].Remove();
                        k++;
                    }
                }
                Console.WriteLine("Array: " + ArrToString(arr));
                pow = pow * 10;
            }
            Console.WriteLine("\nEnd radix sort.\n");
        }

        public static string ArrToString(int[] arr)
        {
            int i;
            string str = "[";

            for (i = 0; i < arr.Length - 1; i++)
                str = str + arr[i] + ",";

            if (i < arr.Length)
                str = str + arr[i];

            return str + "]";
        }
    }
}
