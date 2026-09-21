using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil50
{
    class Particepent
    {
        private string name;
        private int StartWheight;
        private int EndWheight;

        public Particepent(string name, int statwheight, int endwheight)
        {
            this.name = name;
            this.StartWheight = statwheight;
            this.EndWheight = endwheight;
        }

        public string Getname()
        {
            return this.name;
        }
        public int GetStart()
        {
            return this.StartWheight;
        }
        public int GetEnd()
        {
            return this.EndWheight;
        }

        public double Precents()
        {
            return ((this.StartWheight * (this.StartWheight - this.EndWheight)) / 100);
        }

        public override string ToString()
        {
            return ("Name:" + this.Getname() + ", start - " + this.GetStart() + ", end -" + this.GetEnd() + ".");
        }
    }
}
