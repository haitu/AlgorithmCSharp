using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    class TreeModel
    {
    }
    public class TreeUtil
    {
        public TreeNode CreateBstTreeNode(int[] arr)
        {
            TreeNode root = null;
            for (int i = 0; i < arr.Length; i ++)
            {
                TreeNode node = new TreeNode(arr[i]);
                if (root == null) root = node;
                else
                {
                    Insert(root, node, i);
                }

            }
            return root;
        }

        void Insert(TreeNode root, TreeNode node, int index)
        {
            if (node.val < root.val)
            {
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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
