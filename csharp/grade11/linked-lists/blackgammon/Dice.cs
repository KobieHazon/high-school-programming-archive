using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackgammon
{
    class Dice
    {
        private int first;
        private int second;

        public Dice(int n1, int n2)
        {
            this.first = n1;
            this.second = n2;
        }

        public int GetFirst()
        {
            return this.first;
        }
        public int GetSecond()
        {
            return this.second;
        }

        public override string ToString()
        {
            return ("(" + this.GetFirst() + "," + this.GetSecond() + ")");
        }
    }
}
