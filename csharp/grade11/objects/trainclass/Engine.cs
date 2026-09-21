using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Engine
    {
        private int license;
        private int year;

        public Engine(int license, int year)
        {
            this.license = license;
            this.year = year;
        }
        public int GetLicense()
        {
            return this.license;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void SetLicense(int license)
        {
            this.license = license;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public bool isEqual(Engine e)
        {
            return ((this.license == e.license) && (this.year == e.year));
        }
        public override string ToString()
        {
            return "Manufacture License - " + license + "\nYear - " + year;
        }
    }
}
