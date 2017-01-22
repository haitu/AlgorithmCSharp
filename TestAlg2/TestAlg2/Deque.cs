using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Deque
    {
        LNode frontN;
        LNode backN;
        public int back()
        {
            return backN.val;
        }
        public bool empty()
        {
            return frontN == null;
        }
        
        public int pop_back()
        {
            int v = backN.val;
            backN = backN.pre;
            if(backN == null)
            {
                frontN = null;
            }
            return v;

        }
        public void push_back(int v)
        {
            LNode newN = new LNode(v);
            if(backN != null)
            {
                backN.next = newN;
                newN.pre = backN;
                backN = newN;
            }
            else
            {
                backN = newN;
                frontN = newN;
            }
        }
        public int front()
        {
            return frontN.val;
        }
        public int pop_front()
        {
            if(frontN != null)
            {
                int v = frontN.val;
                frontN = frontN.pre;
                if (frontN == null)
                    backN = null;
                return v;
            }
            return int.MinValue;
            
        }
    }
    public class LNode
    {
        public int val;
        public LNode pre;
        public LNode next;
        public LNode(int v)
        {
            val = v;
        }

    }

}
