using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus
{
    class Program
    {
        public static int Cheapest(CityBus CB, Station Start, Station End)
        {
            Node<Bus> BPos = CB.GetBLines();
            Node<Bus> Cheapest = null;
            while (Cheapest == null && BPos != null)
            {
                if (BPos.GetInfo().Navigation(Start, End) != -1)
                {
                    Cheapest = new Node<Bus>(new Bus(BPos.GetInfo()));
                }
                BPos = BPos.GetNext();
            }
            if (Cheapest == null)
            {
                return -1;
            }
            else
            {
                while (BPos != null)
                {
                    if (BPos.GetInfo().Navigation(Start, End) != -1)
                    {
                        if (BPos.GetInfo().Navigation(Start, End) < Cheapest.GetInfo().Navigation(Start, End))
                        {
                            Cheapest = BPos;
                        }
                    }
                        BPos = BPos.GetNext();
                }
                return Cheapest.GetInfo().GetLine();
            }
        }

        static void Main(string[] args)
        {
            Station Same1 = new Station("Start station", 100);
            Station Same2 = new Station("End station", 50);
            CityBus CB1 = new CityBus("Rishon Lezion");
            Station S1 = new Station("HaNahshol", 2);
            Station S2 = new Station("Moshe Dayan", 3);
            Station S3 = new Station("Kobie", 4);
            Bus B1 = new Bus(17, 83);
            B1.AddSLast(S1);
            B1.AddSLast(S2);
            
            B1.AddSLast(S3);
            B1.AddSLast(Same1);
            B1.AddSLast(Same2);
            CB1.AddBLast(B1);

            Station S4 = new Station("Ohad", 10);
            Station S5 = new Station("Itay", 16);
            Station S6 = new Station("Idan", 15);
            Bus B2 = new Bus(15, 85);
            B2.AddSLast(Same1);
            B2.AddSLast(S4);
            B2.AddSLast(S5);
            B2.AddSLast(S6);
            
            B2.AddSLast(Same2);
            CB1.AddBLast(B2);

            Console.WriteLine(B1.Navigation(Same1, Same2));
            Console.WriteLine(B2.Navigation(Same1, Same2));
            Console.WriteLine("The cheapest way to get from 'Same1' to 'Same2' is through line: \n" + Cheapest(CB1, Same1, Same2));

            
        }
    }
}
