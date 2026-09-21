using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> L1 = Maker2();
            Node<Student> L2 = null;
            Student x = new Student("Moshe", 54545, 3);
            Student y = new Student("Yoram", 456456, 2);
            Student z = new Student("Hila", 4564562, 4);
            Student a = new Student("Miryam", 464686, 2);
            L2 = Maker2(x, y, z, a);
            Node<Student> L3 = afdsf(L1, L2);

        }
        public static Node<int> Maker2()
        {
            Node<int> L1 = null;
            Node<int> pos = null;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("");
                int x = int.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<int>(x);
                    pos = L1;
                }
                else
                {
                    pos.SetNext(new Node<int>(x));
                    pos = pos.GetNext();
                }
            }
            return L1;
        }
        public static Node<Student> Maker2(Student x, Student y, Student z, Student a)
        {
            Node<Student> L1 = null;
            Node<Student> pos = null;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
               
                if (L1 == null)
                {
                    L1 = new Node<Student>(x);
                    pos = L1;
                }
                else
                {
                    if (i == 1) { pos.SetNext(new Node<Student>(y)); }
                    if (i == 2) { pos.SetNext(new Node<Student>(z)); }
                    if (i == 3) { pos.SetNext(new Node<Student>(a)); }
                    pos = pos.GetNext();
                }
            }
            return L1;
        }
        public static Node<Student> afdsf(Node<int> L1, Node<Student> L2)
        {
            Node<Student> L3 = null;
            Node<Student> pos2 = null;
            Node<Student> pos = L2;
            int temp = 0;
            while (pos != null)
            {
                int x = pos.GetValue().GetAvg();
                for (int i = 0; i < x; i++)
                {
                    temp += L1.GetValue();
                    L1 = L1.GetNext();
                }
                temp = temp / x;
                if (L3 == null)
                {
                    L3 = new Node<Student>(new Student(pos.GetValue().GetName(), pos.GetValue().GetTz(), temp));
                    pos2 = L3;
                    
                }
                else
                {
                    pos2.SetNext(new Node<Student>(new Student(pos.GetValue().GetName(), pos.GetValue().GetTz(), temp)));
                    pos2 = pos2.GetNext();
                }

                    pos = pos.GetNext();
                    temp = 0;
            }

            return L3;
        }
    }
}
