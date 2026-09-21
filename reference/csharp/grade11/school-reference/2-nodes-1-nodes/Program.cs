using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Two_stacks_in_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            // NODE בניית רשימה של 3
            // SETNEXT על ידי שימוש ב
            Node<int> first = new Node<int>(5);
            Node<int> second = new Node<int>(3);
            Node<int> third = new Node<int>(6);
            first.SetNext(second);
            second.SetNext(third);

            // בניית רשימה מהסוף
            Node<int> last = new Node<int>(8);
            Node<int> beforeLast = new Node<int>(3, last);
            Node<int> first1 = new Node<int>(5, beforeLast);

            // שימוש בלולאת פור
            int info;
            Console.WriteLine("Enter a number: ");
            info = int.Parse(Console.ReadLine());
            Node<int> nodeList=new Node<int>(info);
            Node<int> list = nodeList;
            Node<int> node;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                info = int.Parse(Console.ReadLine());
                node = new Node<int>(info);
                nodeList.SetNext(node);
                nodeList = nodeList.GetNext();
            }

            Console.WriteLine("");
            node = list;
            for (int j = 0; j < 5; j++)
            {
                Console.Write(node.GetInfo() + "  ");
                node = node.GetNext();
            }
        }
    }
}
