using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static IntNode Maker()
        {
            IntNode L1 = null;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                int x = int.Parse(Console.ReadLine());
                L1 = new IntNode(x, L1);
            }
            return L1;
        }
        public static int sum(IntNode n)
        {
            IntNode Pos = n;
            int sum = 0;
            while (Pos != null)
            {
                sum += Pos.GetInfo();
                Pos = Pos.GetNext();
            }
            return sum;
        }
        public static int biggest(IntNode n)
        {
            IntNode Pos = n;
            int max = Pos.GetInfo();
            while (Pos != null)
            {
                if (Pos.GetInfo() > max)
                {
                    max = Pos.GetInfo();
                }
                Pos = Pos.GetNext();
            }
            return max;
        }
        public static void Print(IntNode n)
        {
            IntNode Pos = n;
            while (Pos != null)
            {
                Console.Write(Pos.ToString());
                Pos = Pos.GetNext();
            }
        }

        public static IntNode Once(IntNode n)
        {
            IntNode Pos = n;
            IntNode L2 = null; 
            while (Pos.GetNext() != null)
            {
                if (IsExist(L2, Pos.GetInfo()) == false)
                {
                    L2 = new IntNode(Pos.GetInfo(), L2);
                }
                Pos = Pos.GetNext();
            }

            return L2;

        }
        public static bool IsExist(IntNode L, int check)
        {
            IntNode Pos = L;
            while (Pos.GetNext() != null)
            {
                if (Pos.GetInfo() == check)
                {
                    return true;
                } 
            }
            return false;
        }
        static void Main(string[] args)
        {
            IntNode L1 = null;
            L1 = Maker();
            Print(L1);
            int totalNode = sum(L1);
            int maxNode = biggest(L1);
            Console.WriteLine("Total Node: " + totalNode + " Max : " + maxNode);
            IntNode Repeat = Once(L1);
            Console.WriteLine("Once = ");
            Print(Repeat);

        }
        
    }
}
