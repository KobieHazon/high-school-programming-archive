using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Modaa
    {
        private string type;
        private string nameOfStudent;
        private int days;
        private string content;

        public Modaa(string t, string n, int d, string c)
        {
            this.type = t;
            this.nameOfStudent = n;
            this.days = d;
            this.content = c;
        }
        public int GetDays()
        {
            return this.days;
        }
        public string GetType()
        {
            return this.type;
        }
        public override string ToString()
        {
            return "Type:  " + this.type + " Name:   " + this.nameOfStudent + " Days:     " + this.days + " Content:   " + this.content + "\n";
        }
    }
}
