using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class TreeUtility
    {
        int curIndex = -1;
        TreeNode _rootS;

        public TreeNode CreateTree(int?[] arr)
        {
            curIndex = -1;
            _rootS = null;
            return CreateTreeUtil(arr);
        }
        TreeNode CreateTreeUtil(int?[] arr)
        {
            curIndex++;
            if (curIndex >= arr.Length || arr[curIndex] == null)
            {
                return null;
            }

            TreeNode node = new TreeNode(arr[curIndex].Value);

            if (_rootS == null)
            {
                _rootS = node;
            }

            node.left = CreateTreeUtil(arr);
            node.right = CreateTreeUtil(arr);
            return node;
        }
        public IList<int?> ConvertTreeToArray(TreeNode root)
        {
            IList<int?> list = new List<int?>();
            ConvertTreeToArray(root,list);
            return list;
        }
        void ConvertTreeToArray(TreeNode root, IList<int?> list)
        {
            if(root == null)
            {
                list.Add(null);
                return;
            }
            list.Add(root.val);
            ConvertTreeToArray(root.left, list);
            ConvertTreeToArray(root.right, list);
        }
    }
}
