using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trees
{
    class Program
    {
        public static bool Exist(BinTreeNode<int> b, int x)
        {
            if (b == null)
                return false;
            if (b.GetInfo() == x)
                return true;
            if (x < b.GetInfo())
                return Exist(b.GetLeft(), x);
             return Exist(b.GetRight(), x);
            
        }

        public static void Insert(BinTreeNode<int> b, int x) 
        {
            if (b!=null) 
            {
                if (b.GetInfo() > x) 
                {
                    if (b.GetLeft() == null) 
                    b.SetLeft(new BinTreeNode<int>(x)); 
                    else
                        Insert(b.GetLeft(), x); 

                }

                else 
                {
                    if (b.GetRight()==null)
                    b.SetRight(new BinTreeNode<int>(x)); 
                    else 
                        Insert(b.GetRight(),x); 
                }
            }
        }

        public static void InOrder(BinTreeNode<int> b)
        {
            if (b != null)
            {
                
                InOrder(b.GetLeft());
                Console.Write(b.GetInfo()+ " ");
                InOrder(b.GetRight()); 
            }
        }

        public static void PostOrder(BinTreeNode<int> b)
        {
            if (b != null)
            {
                Console.Write(b.GetInfo()+" ");
                PostOrder(b.GetLeft());
                
                PostOrder(b.GetRight());
            }
        }

        public static void PreOrder(BinTreeNode<int> b)
        {
            if (b != null)
            {
                PreOrder(b.GetLeft());
                
                PreOrder(b.GetRight());
                Console.Write(b.GetInfo()+" ");
            }
        }

        public static int NumLeafs(BinTreeNode<int> bt)
        {
            if (bt.IsLeaf(bt))
                return 1;
            return NumLeafs(bt.GetLeft()) + NumLeafs(bt.GetRight()); 
           
        }

        public static int NumNodes(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            return 1 + NumNodes(bt.GetLeft()) + NumNodes(bt.GetRight()); 
        }

        public static int SumNodes(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            return SumNodes(bt.GetLeft()) + SumNodes(bt.GetRight()) + bt.GetInfo(); 
        }

        public static int Hieght(BinTreeNode<int> bt)
        {
            if (bt == null)
                return -1; 
            return Math.Max(Hieght(bt.GetLeft()), Hieght(bt.GetRight()))+1; 
        }

        public static int DadEqualsBoys(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            if (bt.GetLeft() != null && bt.GetRight() != null)
            {
                if (bt.GetLeft().GetInfo() + bt.GetRight().GetInfo() == bt.GetInfo())
                    return DadEqualsBoys(bt.GetLeft()) + DadEqualsBoys(bt.GetRight()) + 1;
            }
            if (bt.GetLeft() == null && bt.GetRight() != null)
            {
                if ( bt.GetRight().GetInfo() == bt.GetInfo())
                    return  DadEqualsBoys(bt.GetRight()) + 1;
            }
            if (bt.GetLeft() != null && bt.GetRight() == null)
            {
                if (bt.GetLeft().GetInfo() == bt.GetInfo())
                    return DadEqualsBoys(bt.GetLeft()) +  1;
            }
            return DadEqualsBoys(bt.GetLeft()) + DadEqualsBoys(bt.GetRight());
        }

        public static void BFS(BinTreeNode<int> bt)
        {
            Queue<BinTreeNode<int>> q = new Queue<BinTreeNode<int>>();
            q.Insert(bt);
            while (!q.IsEmpty())
            {
               BinTreeNode<int> x = q.Remove();
               Console.WriteLine(x.GetInfo());
               if (x.GetLeft() != null)
               {
                   q.Insert(x.GetLeft()); 
               }
               if (x.GetRight() != null)
               {
                   q.Insert(x.GetRight()); 
               }
            }
        }

        public static void NumLevelsN(BinTreeNode<int> bt, int level)
        {
           
        }

        public static void Main(string[] args)
        {
            BinTreeNode<int> bt = new BinTreeNode<int>(8);
            Insert(bt, 5);
            Insert(bt, 3);
            Insert(bt, 21);
            Insert(bt, 9);
            Insert(bt, 20);
            Insert(bt, 15);
            bool b = Exist(bt, 15);
            Console.WriteLine(b);
            Console.WriteLine();
            Console.WriteLine("InOrder: ");
            InOrder(bt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PreOrder: ");
            PreOrder(bt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PostOrder: ");
            PostOrder(bt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(NumNodes(bt));
            Console.WriteLine(NumLeafs(bt));
            Console.WriteLine(SumNodes(bt));
            Console.WriteLine(Hieght(bt));
            Console.WriteLine(DadEqualsBoys(bt));
            BFS(bt); 
           
            

 
        }
    }
}
