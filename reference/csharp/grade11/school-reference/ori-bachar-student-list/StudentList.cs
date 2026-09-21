using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OriBachar_Node3
{
    public class StudentList
    {
        private Node<Student> first;

        public StudentList()
        {
            this.first = null;
        }

        public void Add(Student student)
        {
            Node<Student> temp = new Node<Student>(student);

            temp.SetNext(this.first);

            this.first = temp;
        }

        public Student Del(string name)
        {
            Node<Student> pos = this.first;

            Node<Student> posprev = this.first;

            if (pos.GetInfo().GetName().CompareTo(name) == 0)
            {
                pos.SetNext(null);

                posprev.SetNext(null);

                return pos.GetInfo();
            }
            else
            {

                pos = pos.GetNext();

                while (pos.GetNext() != null)
                {
                    if (pos.GetInfo().GetName().CompareTo(name) == 0)
                    {
                        posprev.SetNext(pos.GetNext());

                        pos.SetNext(null);

                        return pos.GetInfo();

                    }

                    else
                    {
                        pos = pos.GetNext();

                        posprev = posprev.GetNext();
                    }

                }

                while (pos.GetNext() == null)
                {
                    if (pos.GetInfo().GetName().CompareTo(name) == 0)
                    {
                        pos.SetNext(null);

                        return pos.GetInfo();

                    }

                }
            }

            return null;
        }

        public void Search()
        {
            Node<Student> help = this.first;

            if (help.GetInfo().GetName()[0].CompareTo("t") == 0)
            {
                Console.WriteLine(help.GetInfo().GetName());
            }

            else
            {
                help = help.GetNext();
            }
        }

        public override string ToString()
        {
           Node<Student> help2 = this.first;

           string str = "";

           while (help2 != null)
           {
              str += "\nName:" + help2.GetInfo().GetName() + "\nAge:" + help2.GetInfo().GetAge();

              help2 = help2.GetNext();

           }

           return str;

           
        }
        
    }
}
