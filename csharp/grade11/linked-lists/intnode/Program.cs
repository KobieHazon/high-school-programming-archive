using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode
{
    class Program
    {
        public static IntNode Maker()
        {
            Console.WriteLine("How many Huliot in the sharsheret?");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for hulia {0} - ", i);
            int V = int.Parse(Console.ReadLine());
            IntNode Stam = new IntNode(V);
            for (int j = i - 1; j > 0; j--)
            {
                Console.WriteLine("Enter info for hulia {0} - ", j);
                int info = int.Parse(Console.ReadLine());
                Stam = new IntNode(info, Stam);
            }
            return Stam;
        }

        public static void PrintNode(IntNode Node)
        {
            IntNode Temp = Node;
            int cnt = 0;
            while (Temp != null)
            {
                cnt++;
                Console.WriteLine("The Info of hulia {0} is - {1}.", cnt,Temp.GetInfo());
                Temp = Temp.GetNext();
                
            }
        }

        static void Main(string[] args)
        {
            IntNode Node = Maker();
            PrintNode(Node);
        }
    }
}
