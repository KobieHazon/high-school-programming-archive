using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class toss
    {
        private int toss1;
        private int toss2;

        public toss(int num1, int num2)
        {
            this.toss1 = num1;
            this.toss2 = num2;
        }
        public toss(toss t1)
        {
            this.toss1 = t1.toss1;
            this.toss2 = t1.toss2;
        }

        public int GetToss1()
        {
            return this.toss1;
        }

        public int GetToss2()
        {
            return this.toss2;
        }

        public override String ToString()
        {
            return ("the first toss is " + this.toss1 + " and the second is " + this.toss2);
        }
    }
}
