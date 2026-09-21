using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miunmahsanit
{
    class Program
    {
       
        public static Stack<int> Miun(Stack<int> s,int num)
        {    
            Stack<int> New = new Stack<int>();
            bool checkNum = false;
            while (!s.IsEmpty() && checkNum == false)
                {
                    if (num < s.top())
                    {
                        New.Push(s.pop());
                    }
                    else
                    {
                        New.Push(num);
                        checkNum = true;
                    }
                } 
   
                while (!s.IsEmpty())
                {
                    New.Push(s.pop());
                }

                return New;
        }

        public static int Biggest(Stack<int> s1)
        {
            Stack<int> pos = CopyQueue(s1);
            int x = pos.top();
            while (!pos.IsEmpty())
            {
                if (x < pos.top())
                {
                    x = pos.pop();
                }
                else
                {
                    pos.pop();
                }
            }
            return x;
        }

        public static Stack<int> CopyQueue(Stack<int> que)// מעתיקה את התור לחדש ושומרת על התור הקיים
        {
            Stack<int> Newque = new Stack<int>();
            Stack<int> pos = new Stack<int>();
            while (!que.IsEmpty())
            {
                Newque.Push(que.top());
                pos.Push(que.pop());
            }
            while (!pos.IsEmpty())
            {
                que.Push(pos.pop());
            }
            Newque.reverse();
            return Newque;
        }

        public static void Removenum(Stack<int> S, int num)
        {

            Stack<int> NewS = new Stack<int>();
            while (!S.IsEmpty())
            {
                if (S.top() == num)
                {
                    S.pop();
                }
                else
                    NewS.Push(S.pop());
            }
            while (!NewS.IsEmpty())
            {
                S.Push(NewS.pop());
            }

        }

        public static Stack<int> Miun2(Stack<int> s1, Stack<int> s2)
        {
            Stack<int> News = new Stack<int>();
            while (!s2.IsEmpty())
            {
                s1.Push(s2.pop());
            }
            while (!s1.IsEmpty())
            {
                int x = Biggest(s1);
                News.Push(x);
                Removenum(s1, x);
            }
            
            return News;
        }
        public static int checknums(Stack<int> s)
        {
            int cnt = 0;
            Stack<int> nn = new Stack<int>();
            while (!s.IsEmpty())
            {
                cnt++;
                nn.Push(s.pop());
            }
            nn.reverse();
            s = nn;
            return cnt;
        }
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(3);
            s.Push(5);
            s.Push(7);
            s.Push(9);
            Console.WriteLine("First Mahsanit:" + s);
            int n = 4;
            Console.WriteLine("Number to add: " + n);
            Stack<int> ss=Miun(s, n);
            Console.WriteLine("The New Mahsanit with miun: " +ss.ToString());
            Stack<int> s2 = new Stack<int>();
            s2.Push(22);
            s2.Push(103);
            s2.Push(7);
            Console.WriteLine("mahsanit 1 : " + s2);
            Stack<int> s3 = new Stack<int>();
            s3.Push(12);
            s3.Push(45);
            s3.Push(203);
            Console.WriteLine("mahsanit 2 : " + s3);
            Console.WriteLine("The New Mahsanit from the two: " + Miun2(s2, s3).ToString());
        }
    }
}
