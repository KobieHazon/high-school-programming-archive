using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusRoutes_2015___3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Station S1 = new Station(3, 8);
            Station S2 = new Station(7, 1);
            Station S3 = new Station(6, 12);
            Station S4 = new Station(2, 9);
            Station S5 = new Station(1, 34);
            BusRoutes B1 = new BusRoutes(S1, S2);
            B1.AddSLast(S3);
            B1.AddSLast(S4);
            B1.AddSLast(S5);
            Console.WriteLine(B1.RouteLength());

        }
    }
}
