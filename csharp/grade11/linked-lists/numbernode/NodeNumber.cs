using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberNode
{
    class NodeNumber
    {
        private Node<NumberNode> NodeNumbers;

        public NodeNumber()
        {
            NodeNumbers = null;
        }
        public Node<NumberNode> GetNode()
        {
            return this.NodeNumbers;
        }
        public Node<NumberNode> IsExist(NumberNode con)
        {
            Node<NumberNode> pos = this.NodeNumbers;
            while (pos != null)
            {
                if (pos.GetInfo().GetNumber() == con.GetNumber() && pos.GetInfo().GetCounter() == con.GetCounter())// שינוי
                    return pos;
                pos = pos.GetNext();
            }
            return pos;
        }

        public void Addlast(NumberNode con)
        {

            Node<NumberNode> pos = IsExist(con);
            Node<NumberNode> pos1 = this.NodeNumbers;
            if (pos == null)
            {
                if (this.NodeNumbers == null)
                    this.NodeNumbers = new Node<NumberNode>(new NumberNode(con.GetNumber(), con.GetCounter()));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<NumberNode>(new NumberNode(con.GetNumber(), con.GetCounter())));
                }
            }
        }


        public override String ToString()
        {
            String str = "The Values of the new node are: \n";
            Node<NumberNode> pos = this.NodeNumbers;

            while (pos != null)
            {
                str = str + pos.GetInfo() + "\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
