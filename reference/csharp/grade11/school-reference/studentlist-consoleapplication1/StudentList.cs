using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class StudentList
    {
        private Node<Student> first;
        public StudentList()
        {
            this.first = null;
        }
        public void Add(Node<Student> addStudent)
        {
            addStudent.SetNext(this.first);
            this.first = addStudent;
        }
        public void Delete(string name)
        {
            Node<Student> first = this.first;
            Node<Student> pos = this.first;
            pos = pos.GetNext();
            while (pos.GetNext() != null)
            {
                if(pos.GetInfo().GetName().CompareTo(name)==0)
                {
                    first.SetNext(pos.GetNext());
                    pos.SetNext(null);
                }
                else
                {
                    pos=pos.GetNext();
                    first=first.GetNext();
                }

            }
        }
        public Student GetStudent(string name)
        {
            Node<Student> pos = this.first;
            while (pos != null)
            {
                if (pos.GetInfo().GetName().CompareTo(name) == 0)
                    return pos.GetInfo();
                else
                    pos = pos.GetNext();
            }
            return null;
        }
        public Student GetStudentByChar(char ch)
        {
            Node<Student> pos = this.first;
            while (pos != null)
            {
                if (pos.GetInfo().GetName().IndexOf(ch) == 0)
                    return pos.GetInfo();
                else
                    pos = pos.GetNext();
            }
            return null;
        }
    }
}
