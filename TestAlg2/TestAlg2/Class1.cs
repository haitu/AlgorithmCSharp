using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    class Class1
    {
    }
    public class Interval
    {
      public int start;
      public int end;
      public Interval() { start = 0; end = 0; }
      public Interval(int s, int e) { start = s; end = e; }
    }
    public class IntervalComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Interval xi = (Interval)x;
            Interval yi = (Interval)y;
            if(xi.start < yi.start)
            {
                return -1;
            }else if(xi.start > yi.start)
            {
                return 1;
            }else
            {
                return 0;
            }
        }
    }

    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    };
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class RangeInfor
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Count { get; set; }
    }
}
