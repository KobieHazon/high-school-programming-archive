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
            
            Console.WriteLine(condition());
        }

        public static int condition()
        {
            int[] Primes = PrimeAr(2, 100);
            int target = 2;

            while (true)
            {
                int[] ways = new int[target + 1];
                ways[0] = 1;

                for (int i = 0; i < Primes.Length; i++)
                {
                    for (int j = Primes[i]; j <= target; j++)
                    {
                        ways[j] += ways[j - Primes[i]];
                    }
                }
                
                if (ways[target] > 5000)
                {
                    break;
                }
                target++;

            }
            return target;
           
        }
        public static int[] PrimeAr(int n1, int n2)
        {
            int cnt = 0;
            int NumT = n1;
            while (NumT < n2 && NumT >= n1)
            {
                if (isPrime(NumT))
                {
                    cnt++;
                }
                NumT++;
                
            }
            int[] temp = new int[cnt];
            int i = 0;
            NumT = n1;
            while (NumT < n2 && NumT >= n1)
            {
                if (isPrime(NumT))
                {
                    temp[i] = NumT;
                    i++;
                }
                NumT++;
            }
            PrintAr(temp);
            return temp;
                
        }

        public static void PrintAr(int[] Ar)
        {
            for (int i = 0; i < Ar.Length; i++)
            {
                Console.Write(Ar[i] + " ");
            }
        }
        public static Boolean isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}
