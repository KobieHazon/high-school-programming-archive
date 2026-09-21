using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Prop
    {
        private int num;
        private int place;
        private int cntBiggerThan5;

        public Prop(int a, int b, int c)
        {
            this.num = a;
            this.place = b;
            this.cntBiggerThan5 = c;
        }
        public override string ToString()
        {
            return "  Num: " + this.num + "  Place: " + this.place + "  Numbers bigger than 5:   " + this.cntBiggerThan5;
        }

    }
}
