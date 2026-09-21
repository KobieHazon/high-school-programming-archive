using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeQue
{
    class Program
    {
        public static bool IsPalin(DeQue<int> DQ)
        {
            int right; int left;
            while (DQ.IsEmpty() == false)
            {
                left = DQ.GetRemoveDEQUELeft();
                right = DQ.GetRemoveDEQUERight();
                if (left != right)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Middle(DeQue<int> DQ)
        {
            DeQue<int> DQ1 = new DeQue<int>();
            int cnt = 0;
            int x = 0;
            while (!DQ.IsEmpty())
            {
                cnt++;
                x = DQ.GetHeadDEQUERight();
                DQ1.InsertRight(DQ.GetRemoveDEQUERight());
                if (!DQ.IsEmpty())
                {
                    x = DQ.GetHeadDEQUELeft();
                    DQ1.InsertLeft(DQ.GetRemoveDEQUELeft());
                }
                

            }
            while (!DQ.IsEmpty())
            {
                DQ.InsertRight(DQ1.GetRemoveDEQUERight());
                if (!DQ1.IsEmpty())
                {
                    DQ.InsertLeft(DQ1.GetRemoveDEQUELeft());
                }
                
            }
            return x;
        }

        static void Main(string[] args)
        {
            DeQue<int> DQ = new DeQue<int>();
            DQ.InsertRight(5);
            DQ.InsertRight(4);
            DQ.InsertLeft(4);
            DQ.InsertRight(3);
            DQ.InsertLeft(3);
            DQ.InsertRight(2);
            DQ.InsertLeft(2);
            DQ.InsertRight(1);
            DQ.InsertLeft(1);

            Console.WriteLine(IsPalin(DQ));
            Console.WriteLine(Middle(DQ));
        }
    }
}
