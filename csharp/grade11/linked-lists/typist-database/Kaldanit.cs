using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace שאלה_3
{
    class Kaldanit
    {
        private string Name;
        private int ID;
        private int Seniority;
        private int NumTypingJobs;

        public Kaldanit(string name, int id, int senior, int num)
        {
            this.Name = name;
            this.ID = id;
            this.Seniority = senior;
            this.NumTypingJobs = num;
        }

        public string GetName()
        {
            return this.Name;
        }
        public int GetId()
        {
            return this.ID;
        }
        public int GetSenior()
        {
            return this.Seniority;
        }
        public int GetNumTypingJobs()
        {
           return this.NumTypingJobs;
        }
}
}
     
