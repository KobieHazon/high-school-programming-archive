using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domino
{
    class Domino
    {
        private int first;
        private int second;

        public Domino(int n1, int n2)
        {
            this.first = n1;
            this.second = n2;
        }

        public void SetFirst(int n1)
        {
            this.first = n1;
        }
        public void SetSecond(int n2)
        {
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

        public bool IsExist(int n)
        {
            if (first == n || second == n)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return ("(" + this.GetFirst() + "," + this.GetSecond() + ")");
        }
    }
}
