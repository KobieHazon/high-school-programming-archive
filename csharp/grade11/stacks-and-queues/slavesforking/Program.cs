using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavesforking
{
    class program
    {
        public static void remove(Node<int> N, int a)
        {
            Node<int> pos = N;
          
            while (pos.GetNext().GetInfo() !=a )
            {
                pos = pos.GetNext();
            }
            pos.SetNext(pos.GetNext().GetNext());
        }
        public static Node<int> maker() // פעולה שיוצרת שרשרת חוליות 
        {
            Node<int> L1 = null;
            Node<int> L2 = null;

            for (int i = 1; i <= 100; i++)
            {

                if (L1 == null)
                {
                    L1 = new Node<int>(i);
                    L2 = L1;
                }
                else
                {
                    L2.SetNext(new Node<int>(i, null));
                    L2 = L2.GetNext();
                }
            }
            return L1;
        }
        public static Queue<int> maker2() // פעולה שיוצרת שרשרת חוליות 
        {
            Queue<int> L1 = new Queue<int>();

            for (int i = 1; i <= 100; i++)
            {
                L1.Insert(i);
            }
            return L1;
        }
        public static Queue<int> CopyQueue(Queue<int> que)// מעתיקה את התור לחדש ושומרת על התור הקיים
        {
            Queue<int> Newque = new Queue<int>();
            Queue<int> pos = new Queue<int>();
            while (!que.IsEmpty())
            {
                Newque.Insert(que.Head());
                pos.Insert(que.Remove());
            }
            while (!pos.IsEmpty())
            {
                que.Insert(pos.Remove());
            }
            return Newque;
        }
         public static int Count(Queue<int> Q)
        {
            int cnt = 0;
            Queue<int> pos1 = CopyQueue(Q);
            while (!pos1.IsEmpty())
            {
                cnt++;
                pos1.Remove();
            }
            return cnt;
        }
        public static int Getreadofslaves(Queue<int> a)
        {
        Queue<int> pos= CopyQueue(a);
            while (Count(pos)!=1)
            {
            pos.Insert(pos.Remove());
            pos.Remove();
            }
            return pos.Head();
        }
        public static int King(Node<int> a)
        {
            Node<int> posCircle = a;
            int counter=0;
            bool m = false;
            while (posCircle.GetNext() != null)
            {
                posCircle = posCircle.GetNext();
            }
            posCircle.SetNext(a);
            posCircle = posCircle.GetNext();

            while (counter != 99)
            {
                    remove(posCircle, posCircle.GetNext().GetInfo());
                    posCircle = posCircle.GetNext();
                    counter++;
            }
            return posCircle.GetInfo();
        }
        static void Main(string[] args)
        {
            Node<int> a = maker();
            Console.WriteLine(King(a));
            Queue<int> a2=maker2();
            Console.WriteLine(Getreadofslaves(a2));
        }

    }
}
