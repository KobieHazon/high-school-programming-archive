using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Student
    {
        private string Name;
        private int MathG;
        private int CompG;

        public Student(string name, int MathG, int CompG)
        {
            this.Name = name;
            this.MathG = MathG;
            this.CompG = CompG;
        }

        public override string ToString()
        {
            return ("The name of the student is - " + this.Name + " \nThe student's math grade - " + this.MathG + " \nThe student's computer grade - " + this.CompG);
        }

        public String GetName()
        {
            return this.Name;
        }
        public int GetMathG()
        {
            return this.MathG;
        }
        public int GetCompG()
        {
            return this.CompG;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetMathG(int MathG)
        {
            this.MathG = MathG;
        }
        public void SetCompG(int CompG)
        {
            this.CompG = CompG;
        }

        public double StudentAverage()
        {
            return ((this.CompG + this.MathG) / 2.0);
        }
    }
}
