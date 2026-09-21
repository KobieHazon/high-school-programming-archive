using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OriBachar_Node3
{
    public class Student
    {
        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.name = name;

            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return "Name:" + this.name + "\nAge:" + this.age;
        }




    }
}
