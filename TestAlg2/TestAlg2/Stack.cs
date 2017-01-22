using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Stack
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        public void Push(int x)
        {
            q1.Enqueue(x);
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            while(q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            q1.Dequeue();
            Swap();
        }
        void Swap()
        {
            Queue<int> tmp = q1;
            q1 = q2;
            q2 = tmp;
        }
        // Get the top element.
        public int Top()
        {
            int ele = 0;
            while (q1.Count > 0)
            {
                ele = q1.Dequeue();
                q2.Enqueue(ele);
            }
            Swap();
            return ele;
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return q1.Count == 0;
        }
    }
}
