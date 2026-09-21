using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hishtalmoot
{
    class Participent
    {
        private string name;
        private string ID;

        public Participent(string name, string ID)
        {
            this.name = name;
            this.ID = ID;
        }
        public Participent(Participent P)
        {
            this.name = P.GetName();
            this.ID = P.GetID();
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetID()
        {
            return this.ID;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetID(string ID)
        {
            this.ID = ID;
        }
    }
}
