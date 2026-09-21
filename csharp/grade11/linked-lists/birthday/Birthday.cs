using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Birthday
    {
        private string name;
        private int day;

        public Birthday(string n, int a)
        {
            this.name = n;
            this.day = a;
        }
        public Birthday(Birthday a)
        {
            this.name = a.name;
            this.day = a.day;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetDay()
        {
            return this.day;
        }
        public override string ToString()
        {
            return "name: " + this.name + "     day:  " + this.day;
        }
    }
}
