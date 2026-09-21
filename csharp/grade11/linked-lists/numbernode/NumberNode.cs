using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberNode
{
    class NumberNode
    {
        private int counter;
        private int number;

        public NumberNode(int number, int counter)
        {
            this.counter = counter;
            this.number = number;
        }

        public int GetCounter()
        {
            return this.counter;
        }
        public int GetNumber()
        {
            return this.number;
        }

        public void SetCounter(int counter)
        {
            this.counter = counter;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return "(" + this.number + "," + this.counter + ")";
        }
    }
}
