using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class Contact
    {
        private string Name;
        private string Number;

        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetNumber()
        {
            return this.Number;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetNumber(string number)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            
            return ("Name - " + this.Name + ".\nNumber - " + this.Number +".");
        }
    }
}
