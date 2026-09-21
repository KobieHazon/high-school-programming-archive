using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Carriage
    {
        private int index;
        private int travelers;

        public Carriage(int index, int travelers)
        {
            this.index = index;
            this.travelers = travelers;
        }
        public int GetIndex()
        {
            return this.index;
        }
        public int GetTravelers()
        {
            return this.travelers;
        }
        public void SetIndex(int index)
        {
            this.index = index;
        }
        public void SetTravelers(int travelers)
        {
            this.travelers = travelers;
        }
        public bool isEqual(Carriage c)
        {
            return (this.travelers == c.travelers);
        }
        public override string ToString()
        {
            return "index - " + this.index + "\nnumber of travelers - " + this.travelers;
        }
    }
}
