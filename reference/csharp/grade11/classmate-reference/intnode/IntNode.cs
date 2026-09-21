using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class IntNode
    {
        private int info;
        private IntNode next;

        public IntNode(int info)
        {
            this.info = info;
        }
        public IntNode(int info, IntNode n)
        {
            this.info = info;
            this.next = n;
        }
        public IntNode GetNext()
        {
            return this.next;
        }
        public int GetInfo()
        {
            return this.info;
        }
        public void SetNext(IntNode n)
        {
            this.next = n;
        }
        public void SetInfo(int i)
        {
            this.info = i;
        }
        public override string ToString()
        {
            return this.info + "   -   ";
        }

    }
}
