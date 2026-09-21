using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static Stack<int> Sum(Stack<int> st)
        {
            Stack<int> hst = new Stack<int>();
            int sum = 0;
            while (!st.IsEmpty())
            {
                sum += st.Top();
                hst.Push(st.Pop());
            }
            Console.WriteLine("The Sum Of The Stack Is: {0}", sum);
            while (!hst.IsEmpty())
                st.Push(hst.Pop());
            return st;
        }
        public static Stack<int> Max(Stack<int> st)
        {
            Stack<int> hst = new Stack<int>();
            int max = st.Top();
            while (!st.IsEmpty())
            {
                int x = st.Top();
                hst.Push(st.Pop());
                max = Math.Max(x, max);
            }
            Console.WriteLine("The Max Num Is: {0}", max);
            while (!hst.IsEmpty())
                st.Push(hst.Pop());
            return st;
        }
        public static Stack<int> Equal(Stack<int> st1, Stack<int> st2)
        {
            Stack<int> hst2 = new Stack<int>();
            Stack<int> nst = new Stack<int>();
            int num2, num1;
            while (!st1.IsEmpty())
            {
                num1 = st1.Pop();
                while (!st2.IsEmpty())
                {
                    num2 = st2.Top();
                    if (num1 == num2)
                        nst.Push(num1);
                    hst2.Push(st2.Pop());
                }
                while (!hst2.IsEmpty())
                    st2.Push(hst2.Pop());
            }
            return nst;
        }
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            Stack<int> st2 = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(30);
            st.Push(4);
            st.Push(5);
            st2.Push(30);
            st2.Push(1);
            st2.Push(4);
            st2.Push(88);
            st2.Push(40);
            st2.Push(99);
            st2.Push(19);

            st = Sum(st);
            st = Max(st);
            st = Equal(st, st2);
        }
    }
}
