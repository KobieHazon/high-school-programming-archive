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
            Engine E = new Engine(101, 1999);
            Train T = new Train(E);
            Carriage A = new Carriage(0, 57);
            Carriage B = new Carriage(1, 33);
            Carriage C = new Carriage(2, 10);
            Carriage D = new Carriage(34, 33);
            Carriage F = new Carriage(32, 36);
            Console.WriteLine(T.ToString());

            T.Add(A);
            T.Add(B);
            T.Add(C);
            T.Add(D);
            T.Add(F);
            Console.WriteLine(T.ToString());
            Console.WriteLine("After change:");
            T.Remove(2);
            Console.WriteLine(T.ToString());
        }
    }
}
