using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum3Lists
{
    class DuoInt
    {
        private int num1;
        private int num2;

        public DuoInt(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Get1()
        {
            return this.num1;
        }
        public int Get2()
        {
            return this.num2;
        }
        public override string ToString()
        {
            return "(" + this.num1 + "," + this.num2 + ")";
        }
    }
}
