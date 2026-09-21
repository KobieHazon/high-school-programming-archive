using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static tosses randomnodes()
        {
            Random rnd = new Random();
            tosses ts1 = new tosses();
            for (int i = 0; i < 8; i++)
            {
                //node1 = AddNode(node1, new Node<int>(rnd.Next(1,11)));
                ts1.Addlast(new toss((rnd.Next(1, 7)), (rnd.Next(1, 7))));
            }
            return ts1;
        }
        static int most(tosses ts1)
        {
            int bigcount = 0, bigi = 0;
            Node<toss> temp = ts1.GetChain();
            int[] arr = new int[6];
            while(temp != null)
            {
                arr[temp.GetInfo().GetToss1() - 1]++;
                arr[temp.GetInfo().GetToss2() - 1]++;
                temp = temp.GetNext();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > bigcount)
                {
                    bigcount = arr[i];
                    bigi = i;
                }
            }
            return bigi + 1;
        }
        static void Main(string[] args)
        {
            tosses ts1 = randomnodes();
            Console.WriteLine(ts1);
            Console.WriteLine(ts1.mosttosses());
            Console.WriteLine(most(ts1));
        }
    }
}
