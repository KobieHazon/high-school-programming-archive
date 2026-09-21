using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class domino
    {
        private int side1;
        private int side2;

        public domino(int num1, int num2)
        {
            this.side1 = num1;
            this.side2 = num2;
        }
        public domino(domino t1)
        {
            this.side1 = t1.side1;
            this.side2 = t1.side2;
        }

        public int GetSide1()
        {
            return this.side1;
        }

        public int GetSide2()
        {
            return this.side2;
        }

        public void SetSide1(int num)
        {
            this.side1 = num;
        }
        public void SetSide2(int num)
        {
            this.side2 = num;
        }

        public bool InDomino(int num)
        {
            if (this.side1 == num || this.side2 == num)
                return true;
            return false;
        }
        public override String ToString()
        {
            return ("the first side is " + this.side1 + " and the second side is " + this.side2);
        }
    }
}
