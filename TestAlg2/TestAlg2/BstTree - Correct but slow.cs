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
            BstTreeNode root = new BstTreeNode(arr[0], 0);
            for (int i = 1; i < arr.Length; i++)
            {
                Insert(root, arr[i], i);
            }
            return root;
        }

        void IncreaseRight(BstTreeNode root)
        {
            if (root == null) return;
            ans[root.index]++;
            IncreaseRight(root.left);
            IncreaseRight(root.right);
        }
        void Insert(BstTreeNode root, int v, int index)
        {
            var newNode = new BstTreeNode(v, index);
            if(v < root.val)
            {
                ans[root.index]++;
                IncreaseRight(root.right);
            }
            if (v < root.val)
            {
                
                if (root.left == null)
                {
                    root.left = newNode;
                }
                else
                {
                    Insert(root.left, v, index);
                }
            }
            else 
            {
                if (root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    Insert(root.right, v, index);
                }
            }
        }



    }
    public class BstTreeNode
    {
        public int val;
        public int index;
        public BstTreeNode left;
        public BstTreeNode right;
        public BstTreeNode(int x, int i) { val = x; index = i; }
    }
}
