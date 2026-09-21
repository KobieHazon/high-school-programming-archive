using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode
{
    class IntNode
    {
        private int info;
        private IntNode Next;

        public IntNode(int x)
        {
            this.info = x;
            this.Next = null;
        }
        public IntNode(int x, IntNode next)
        {
            this.info = x;
            this.Next = next;
        }

        public int GetInfo()
        {
            return this.info;
        }
        public IntNode GetNext()
        {
            return this.Next;
        }
    }
}
