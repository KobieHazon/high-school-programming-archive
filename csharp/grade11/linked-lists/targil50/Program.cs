using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil50
{
    class Program
    {
        public static string Biggest(Plan P)
        {
            Node<Particepent> pos = P.GetP();
            Node<Particepent> Biggest = pos;
            while (pos != null)
            {
                if ((Biggest.GetInfo().GetEnd() - Biggest.GetInfo().GetStart()) > (pos.GetInfo().GetEnd() - pos.GetInfo().GetStart()))
                {
                    Biggest = pos;
                }
                pos = pos.GetNext();
            }
            return Biggest.GetInfo().Getname();
        }

        static void Main(string[] args)
        {
            Random Rnd = new Random();
            Plan P = new Plan();
            P.AddFirst("Roy", Rnd.Next(120, 160), Rnd.Next(60, 100));
            P.AddFirst("Talia", Rnd.Next(120, 160), Rnd.Next(60, 100));
            P.AddFirst("Lidor", Rnd.Next(120, 160), Rnd.Next(60, 100));
            P.AddFirst("Itay", Rnd.Next(120, 160), Rnd.Next(60, 100));
            P.AddFirst("Ohad", Rnd.Next(120, 160), Rnd.Next(60, 100));
            P.AddFirst("Yoni", Rnd.Next(120, 160), Rnd.Next(60, 100));
            Console.WriteLine(P);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine(Biggest(P));
        }
    }
}
