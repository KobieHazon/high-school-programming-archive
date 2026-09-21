using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        public static List<int> SumUp(List<int> lst)
        {
            Node<int> nd = lst.GetFirst();
            List<int> newlst=new List<int>();
            int sum = nd.GetInfo();
            while (nd.GetNext() != null)
            {
                if (nd.GetNext().GetInfo() - nd.GetInfo() > 0)
                {
                    sum += nd.GetNext().GetInfo();
                }
                else
                {
                    newlst.Insert(null, sum);
                    sum = nd.GetNext().GetInfo();
                }
                nd = nd.GetNext();
            }
            newlst.Insert(null, sum);
            return newlst;
        }
        
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Insert(null, 9);
            lst.Insert(null, 0);
            lst.Insert(null, -3);
            lst.Insert(null, 5);
            lst.Insert(null, 20);
            lst.Insert(null, 20);
            lst.Insert(null, 19);
            lst.Insert(null, 18);
            lst.Insert(null, 20);
            lst.Insert(null, 8);
            lst.Insert(null, 4);
            lst.Insert(null, 2);
            lst.Insert(null, 7);
            Console.WriteLine(lst.ToString());
            Console.WriteLine(SumUp(lst).ToString());
        }
    }
}
