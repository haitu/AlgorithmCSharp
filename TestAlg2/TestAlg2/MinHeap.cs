using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class MinHeap
    {
        int maxSize;
        Tuple[] arr;
        int len;
        public MinHeap(int size)
        {
            maxSize = size;
            arr = new Tuple[maxSize];
        }
        public void Push(Tuple t)
        {
            arr[len++] = t;
            BubbleUp(len - 1);
        }
        void BubbleUp(int i)
        {
            if (i == 0) return;
            int parent = i % 2 == 1 ? i / 2 : (i - 1)/2;
            if(arr[i].Value < arr[parent].Value)
            {
                Swap(arr,i,parent);
                BubbleUp(parent);
            }
            
        }
        public Tuple Top()
        {
            return arr[0];
        }
        public void Pop()
        {
            Swap(arr,0,len - 1);
            len--;
            Sink(0);
        }
        private void Sink(int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int next = left;

            if (next >= len) return;
            if(left < len && right < len && arr[left].Value > arr[right].Value)
            {
                next = right;
            }
            
            if(arr[i].Value > arr[next].Value)
            {
                Swap(arr, i, next);
                Sink(next);
            }
            
        }
        void Swap(Tuple[] a, int i, int j)
        {
            Tuple tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
        

    }
    public class Tuple
    {
        public int Value { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

    }
}
