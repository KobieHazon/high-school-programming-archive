using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil50
{
    class Plan
    {
        private Node<Particepent> P;

        public Plan()
        {
            this.P = null;
        }

        public void AddFirst(string name, int n1, int n2)
        {
            this.P = new Node<Particepent>(new Particepent(name, n1, n2), this.P);
        }

        public Node<Particepent> GetP()
        {
            return this.P;
        }

        public override String ToString()
        {
            String str = "";
            Node<Particepent> pos = this.GetP();

            while (pos != null)
            {
                str = str + pos.GetInfo().ToString() + "\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
