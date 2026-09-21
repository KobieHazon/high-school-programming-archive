using System;
using System.Text;
using System.Linq;
using System.Text;

namespace Domino
{
    public class Node<T>
    {
        private T info;
        private Node<T> NextNode;

        public Node(T info)
        {
            this.info = info;
            this.NextNode = null;
        }

        public Node(T info, Node<T> NextNode)
        {
            this.info = info;
            this.NextNode = NextNode;
        }

        public T GetInfo()
        {
            return (this.info);
        }

        public Node<T> GetNext()
        {
            return (this.NextNode);
        }

        public void SetNext(Node<T> NextNode)
        {
            this.NextNode = NextNode;
        }

        public void SetInfo(T info)
        {
            this.info = info;
        }

        public override string ToString()
        {
            return ("" + this.info);
        }



    }
}
