using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingsClass
{
    class Address
    {
        private string street;
        private int number;
        private string city;

        public Address(string street, int number, string city)
        {
            this.street = street;
            this.number = number;
            this.city = city;
        }

        public string GetStreet()
        {
            return this.street;
        }
        public string GetCity()
        {
            return this.city;
        }
        public int Getnumber()
        {
            return this.number;
        }
        public void SetStreet(string Street)
        {
            this.street = Street;
        }
        public void SetCity(string City)
        {
            this.city = City;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
    }
}
