using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_2014___3_
{
    class Student
    {
        private string Name;
        private Birth BDay;

        public Student(string Name, Birth BDay)
        {
            this.Name = Name;
            this.BDay = BDay;
        }
        public string GetName()
        {
            return this.Name;
        }
        public Birth GetBDay()
        {
            return this.BDay;
        }

    }
}
