using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Solution2
    {
        static void Main(string[] args)
        {
            Solution2 pro = new Solution2();
            pro.test();
        }
        void test()
        {
            int mp = MaxProfit(new int[] { 1,7,8,6,7,8});

            List<string> dic = new List<string> { "leet","code"};
            HashSet<string> hs = new HashSet<string>(dic);
            bool bWB = WordBreak("leetcode", hs);

            dic = new List<string> { "leet", "code" };
            hs = new HashSet<string>(dic);
            bWB = WordBreak("leet1code", hs);


            dic = new List<string> { "aaaa", "aa" };
            hs = new HashSet<string>(dic);
            bWB = WordBreak("aaaaaaa", hs);
        }


        bool bFoundWB = false;
        TrieNode originalRoot = null;
        Trie trie;
        public bool WordBreak(string s, ISet<string> wordDict)
        {
            bFoundWB = false;
            trie = new Trie(wordDict);
            originalRoot = trie.Root;
            DfsWord(originalRoot,s,0);
            return bFoundWB;
        }
        void DfsWord(TrieNode root,string s,int index)
        {
            if (bFoundWB) return;
            if(index == s.Length)
            {
                if(trie.HasEnd(root))
                {
                    bFoundWB = true;
                }
                
                return;
            }
         
            foreach(var n in root.Children)
            {
                if(n.Val == Trie.EndKey)
                {
                    DfsWord(originalRoot, s, index);
                }
                else if(n.Val == s[index])
                {
                    DfsWord(n, s, index + 1);
                }
            }
            
        }

        //https://leetcode.com/problems/word-break/

        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;

            do
            {
                slow = slow.next;
                fast = fast.next;
                if (fast == null) return false;
                fast = fast.next;
                if (fast == null) return false;
            } while (slow != fast);
            return false;
        }
        public int SingleNumber(int[] nums)
        {
            int ans = nums[0];
            for(int i = 1;i < nums.Length;i ++)
            {
                ans ^= nums[i];
            }
            return ans;
        }

        int sumAll = 0;
        public int SumNumbers(TreeNode root)
        {
            sumAll = 0;
            if (root == null) return 0;

            DfsSumNumbers(root, 0);
            return sumAll;
        }
        void DfsSumNumbers(TreeNode root,int sum)
        {
            sum =sum*10 + root.val;
            if (root.left == null && root.right == null)
            {
                sumAll += sum;
                return;
            }
            if(root.left != null)
            {
                DfsSumNumbers(root.left, sum);
            }
            if (root.right != null)
            {
                DfsSumNumbers(root.right, sum);
            }
        }

        //Best Time to Buy and Sell Stock II
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 1) return 0;

            int minSoFar = prices[0];
            int maxProfit = 0;
            int n = prices.Length;
            for (int i = 1;i < n; i++)
            {
                if(i == n -1 ||  prices[i + 1] < prices[i])
                {
                    if(prices[i] - minSoFar > 0)
                    {
                        maxProfit += prices[i] - minSoFar;
                        minSoFar = prices[i];
                    }
                }
                minSoFar = Math.Min(minSoFar, prices[i]);
            }
            return maxProfit;
        }

        public int MaxProfit1(int[] prices)
        {
            int max = 0;
            if (prices.Length < 1) return 0;
            int minSoFar = prices[0];
            for(int i = 1;i < prices.Length;i ++)
            {
                if (prices[i] - minSoFar > max)
                    max = prices[i] - minSoFar;
                minSoFar = Math.Min(prices[i],minSoFar);
            }
            return max;
        }

        //108. Convert Sorted Array to Binary Search Tree
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateBST(nums,0,nums.Length - 1);
        }
        public TreeNode CreateBST(int[] nums,int left,int right)
        {
            if (left > right) return null;
            int mid = (right - left) / 2 + left;
            TreeNode root = new TreeNode(nums[mid]);
            TreeNode leftN = CreateBST(nums,left, mid - 1);
            TreeNode rightN =CreateBST(nums, mid  + 1, right);
            root.left = leftN;
            root.right = rightN;
            return root;
        }

        //http://www.programcreek.com/2014/03/leetcode-gas-station-java/
        //has better solution
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int n = gas.Length;
            for(int i = 0;i < n; i++)
            {
                int gasRemain = 0;
                int j = 0;
                for(;j < n;j ++)
                {
                    int index = i + j;
                    if(index >= n)
                    {
                        index -= n;
                    }
                    if(gasRemain + gas[index] >= cost[index])
                    {
                        gasRemain += gas[index] - cost[index];
                    }else
                    {
                        break;
                    }
                }
                if (j >= n)
                    return i;

            }
            return -1;
        }
        //112. Path Sum
        public bool HasPathSum(TreeNode root, int sum)
        {
            bFoundCP = false;
            if (root == null) return false;
            CalculatePath(root,sum);
            return bFoundCP;
        }
        bool bFoundCP = false;
        void CalculatePath(TreeNode root, int sum)
        {
            if (bFoundCP) return;
            if(root.left == null && root.right == null)
            {
                if(sum == root.val)
                {
                    bFoundCP = true;
                }
                return;
            }
            if(root.left != null)
            {
                CalculatePath(root.left, sum - root.val);
            }
            if (root.right != null)
            {
                CalculatePath(root.right, sum - root.val);
            }
        }
    }
}
