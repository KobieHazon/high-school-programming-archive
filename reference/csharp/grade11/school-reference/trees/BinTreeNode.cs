using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trees
{
    public class BinTreeNode<T>
    {
        private BinTreeNode<T> Left;

        private T Info;

        private BinTreeNode<T> Right;

        //-----------------------------
        public BinTreeNode(T x)
        {
            this.Left = null;

            this.Info = x;

            this.Right = null;
        }
        //-----------------------------
        public BinTreeNode(BinTreeNode<T> Left, T x, BinTreeNode<T> Right)
        {
            this.Left = Left;

            this.Info = x;

            this.Right = Right;
        }
        //-----------------------------

        public T GetInfo()
        {
            return (this.Info);
        }
        //-----------------------------

        public void SetInfo(T x)
        {
            this.Info = x;
        }
        //-----------------------------
        public BinTreeNode<T> GetLeft()
        {
            return (this.Left);
        }
        //-----------------------------
        public BinTreeNode<T> GetRight()
        {
            return (this.Right);
        }
        //-----------------------------
        public void SetLeft(BinTreeNode<T> left)
        {
            this.Left = left;
        }
        //-----------------------------
        public void SetRight(BinTreeNode<T> right)
        {
            this.Right = right;
        }
        //-----------------------------

        public bool IsLeaf(BinTreeNode<T> bt)
        {
            if (bt.GetLeft() != null && bt.GetRight() != null)
                return false;
            return true; 
        }

        public override string ToString()
        {
            return (this.Info.ToString()+" ");
        }

    }
}
