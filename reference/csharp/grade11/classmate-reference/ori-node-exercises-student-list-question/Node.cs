using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Node<T>
    {
        private T Value;
        private Node<T> NextNode;

        public Node(T Value)
        {
            this.Value = Value;
            this.NextNode = null;
        }

        public Node(T Value, Node<T> NextNode)
        {
            this.Value = Value;
            this.NextNode = NextNode;
        }

        public T GetValue()
        {
            return (this.Value);
        }

        public Node<T> GetNext()
        {
            return (this.NextNode);
        }

        public void SetNext(Node<T> NextNode)
        {
            this.NextNode = NextNode;
        }

        public void SetValue(T Value)
        {
            this.Value = Value;
        }

        public override string ToString()
        {
            return ("the info is " + this.Value);
        }
    }
}
