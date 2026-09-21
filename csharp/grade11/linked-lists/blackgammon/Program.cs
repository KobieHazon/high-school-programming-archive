using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackgammon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            game G = new game();
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));
            G.AddFirst(Rnd.Next(1, 7), Rnd.Next(1, 7));

            Console.WriteLine(G);

            Console.WriteLine(G.Most());

        }
    }
}
