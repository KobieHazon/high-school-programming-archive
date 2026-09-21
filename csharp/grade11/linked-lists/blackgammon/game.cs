using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackgammon
{
    class game
    {
        private Node<Dice> D;

        public game()
        {
            this.D = null;
        }

        public void AddFirst(int n1, int n2)
        {
           
            this.D = new Node<Dice>(new Dice(n1, n2), this.D);
        }

        public int Most()
        {
            int[] arr = new int[6];
            Node<Dice> pos = this.GetD();
            int temp = 0;
            while (pos != null)
            {
                temp = pos.GetInfo().GetFirst();
                arr[temp - 1]++;
                temp = pos.GetInfo().GetSecond();
                arr[temp - 1]++;
                pos = pos.GetNext();
            }
            temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[temp])
                {
                    temp = i;
                }
            }
            return (temp + 1);
        }

        public Node<Dice> GetD()
        {
            return this.D;
        }
        
        public override String ToString()
        {
            String str = "";
            Node<Dice> pos = this.D;

            while (pos != null)
            {
                str = str + pos.GetInfo().ToString() + "\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
