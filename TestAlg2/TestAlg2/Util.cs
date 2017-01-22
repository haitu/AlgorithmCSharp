using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Util
    {
        public ListNode ArrayToListNode(int []arr)
        {
            ListNode head = new ListNode(arr[0]);
            ListNode cur = head;
            for (int i = 1;i < arr.Length; i++)
            {
                cur.next = new ListNode(arr[i]);
                cur = cur.next;
            }
            return head;
        }
    }
}
