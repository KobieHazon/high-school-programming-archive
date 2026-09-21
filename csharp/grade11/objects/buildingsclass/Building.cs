using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingsClass
{
    class Building
    {
        private Address address;
        private const int MaxApartmants = 100;
        private int LastPos;
        private Apartmant[] Aprts;

        public Building(Address A)
        {
            this.address = A;
            Aprts = new Apartmant[MaxApartmants];
            LastPos = 0;
        }

        public Apartmant[] GetAprts()
        {
            return this.Aprts;
        }
        public Address GetAdres()
        {
            return this.address;
        }
        public void SetAprts(Apartmant[] Aprts)
        {
            this.Aprts = Aprts;
        }
        public void Setaddress(Address address)
        {
            this.address = address;
        }
        public void Add(Apartmant A)
        {
            if (LastPos != this.Aprts.Length)
            {
                this.Aprts[LastPos] = A;
                this.LastPos++;
            }

        }



    }
}
