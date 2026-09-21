using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus
{
    class Station
    {
        private string street;
        private int num;
        
        public Station(string street, int num)
        {
            this.street = street;
            this.num = num;
        }

        public Station(Station S)
        {
            this.street = S.street;
            this.num = S.num;
        }

        public string GetStreet()
        {
            return this.street;
        }
        public int GetNum()
        {
            return this.num;
        }
        public void SetStreet(string street)
        {
            this.street = street;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }

        public Boolean Equals(Station S)
        {
            if (this == S)
                return true;
            else
                return false;
        }
    }
}
