using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_2014___3_
{
    class School
    {
        private Node<Student>[] Students;

        public School()
        {
            Students = new Node<Student>[6];
        }
        public Node<Student>[] GetStu()
        {
            return this.Students;
        }

        public void AddSFirst(Student S, int grade)
        {
            
            this.Students[grade] = new Node<Student>(new Student(S.GetName(), S.GetBDay()), this.Students[grade]);
        }


    }
}
