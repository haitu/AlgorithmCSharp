using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class BstTree
    {
        int[] ans;
        public int[] GetAnswer()
        {
            return ans;
        }
        public BstTreeNode CreateBstTreeNode(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                ans = new int[] { };
                return null;

            }
            ans = new int[arr.Length];
            BstTreeNode root = null;
            for (int i = arr.Length - 1; i >= 0; i --)
            {
                BstTreeNode node = new BstTreeNode(arr[i],i);
                if (root == null) root = node;
                else
                {
                    Insert(root, node, i);
                }
                
            }
            return root;
        }

        void Insert(BstTreeNode root, BstTreeNode node, int index)
        {
            if (node.val < root.val)
            {
                root.biggerNum++;
                if (root.left == null)
                {
                    root.left = node;
                }
                else
                {
                    Insert(root.left, node, index);
                }
            }
            else 
            {
                //node.biggerNum += root.biggerNum + 1;
                ans[index] += root.biggerNum;
                if (node.val > root.val) ans[index]++;
                if (root.right == null)
                {     
                    root.right = node;
                }
                else
                {
                    Insert(root.right, node, index);
                }
            }
        }



    }
    public class BstTreeNode
    {
        public int val;
        public int index;
        public int biggerNum;
        public BstTreeNode left;
        public BstTreeNode right;
        public BstTreeNode(int x, int i) { val = x; index = i; }
    }
}
