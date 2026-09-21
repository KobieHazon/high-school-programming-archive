using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collec_2014___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Collec C1 = new Collec(4);
            C1.Add(5);
            C1.Add(6);
            C1.Add(7);
            Collec C2 = new Collec(7);
            C2.Add(8);
            C2.Add(9);
            C2.Add(10);

            Console.WriteLine(C1.smallest(C2));
        }
    }
}
