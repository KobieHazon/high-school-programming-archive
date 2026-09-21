using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Student
    {
        private string name;
        private int TZ;
        private int avg;

        public Student(string name, int TZ, int avg)
        {
            this.name = name;
            this.TZ = TZ;
            this.avg = avg;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetTz()
        {
            return this.TZ;
        }
        public int GetAvg()
        {
            return this.avg;
        }
        
    }
}
