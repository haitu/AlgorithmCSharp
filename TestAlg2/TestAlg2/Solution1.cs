using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Contest
    {
        //static void Main(string[] args)
        //{
        //    Contest pro = new Contest();
        //    pro.test();
        //}
        void test()
        {
            FindContentChildren(new int[] { 1, 2, 3 }, new int[] { 1, 1 });

            FindContentChildren(new int[] { 1, 2 }, new int[] { 1, 2, 3 });

            bool br = RepeatedSubstringPattern("abab");
            br = RepeatedSubstringPattern("aba");
            br = RepeatedSubstringPattern("abcabc");
            br = RepeatedSubstringPattern("abcabcabcabc");
            br = RepeatedSubstringPattern("bb");

            br = Find132pattern(new int[] { 1, 2, 3, 4 });
            br = Find132pattern(new int[] { 3, 1, 4, 2 });
            br = Find132pattern(new int[] { -1, 3, 2, 0 });
            br = Find132pattern(new int[] { 1, 0, 1, -4, -3 });

            br = Find132pattern(new int[] { 4, 1, 3, 2 });

            int numR = FourSumCount(new int[] { 1, 2 }, new int[] { -2, -1 }, new int[] { -1, 2 }, new int[] { 0, 2 });

            long nd = GetDigitFromRight(106, 2);
            nd = GetDigitFromRight(106, 3);

            nd = FindNthDigit(11);
            nd = FindNthDigit(10);
            nd = FindNthDigit(13);
            nd = FindNthDigit(14);
            nd = FindNthDigit(15);
            nd = FindNthDigit(14);

            nd = FindNthDigit(1000);

            nd = FindNthDigit(1000000000);
            nd = FindNthDigit(2147483647);

            bool foundH = CanPartition(new int[] { 1, 5, 11, 5 });
            foundH = CanPartition(new int[] { 1, 2, 3, 5 });

            foundH = CanPartition(new int[] { 1, 2, 5 });

            foundH = CanPartition(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100, 99, 100 });

            int bi = CalculateTheNumberOfDistinctsPairs(new int[] { 1, 1, 3, 2, 9, 9, 1, 9 }, 10);
            bi = CalculateTheNumberOfDistinctsPairs(new int[] { 4, 4, 4, 4, 4 }, 8);

            bi = CalculateTheNumberOfDistinctsPairs(new int[] { 1, 9, 1, 9, 1 }, 10);
            bi = CalculateTheNumberOfDistinctsPairs(new int[] { 7, 3, 3, 8, 7 }, 8);

            int[] nums = new int[] { 101, 102, 78, 79, 63, 64 };
            RadixSort(nums);

            nums = new int[] { 101, 102, 78, 79, 63, 64, 124, 4, 6, 9, 107, 7 };
            RadixSort(nums);

            StringBuilder sb = new StringBuilder("Hello World");
            ReverseString(sb);

            sb = new StringBuilder("  Hello World");
            ReverseString(sb);

            sb = new StringBuilder("  Hello World  ");
            ReverseString(sb);

            sb = new StringBuilder("  a b  ");
            ReverseString(sb);

            sb = new StringBuilder("  abc b  ");
            ReverseString(sb);

            sb = new StringBuilder("a");
            ReverseString(sb);

            TreeNode tn1 = new TreeNode(1);
            TreeNode tn2 = new TreeNode(2);
            TreeNode tn3 = new TreeNode(3);
            TreeNode tn4 = new TreeNode(4);
            TreeNode tn5 = new TreeNode(5);
            TreeNode tn6 = new TreeNode(6);
            tn1.left = tn2; tn1.right = tn5;

            tn2.left = tn3; tn2.right = tn4;
            tn5.right = tn6;
            Flatten(tn1);

            tn1 = new TreeNode(1);
            tn2 = new TreeNode(2);
            tn1.left = tn2;

            Flatten(tn1);

            int nr = IslandPerimeter(new int[,] { { 0, 1, 0, 0 },
 {1, 1, 1, 0},
 {0, 1, 0, 0},
{1, 1, 0, 0} });

            int mm = MinMoves2(new int[] { 1, 2, 3 });

            mm = MinTransfers(new int[,] { { 0, 1, 10 }, { 2, 0, 5 } });
            mm = MinTransfers(new int[,] { { 0, 1, 10 }, { 1, 0, 1 }, { 1, 2, 5 }, { 2, 0, 5 } });

            mm = MinTransfers(new int[,] { { 0, 1, 5 }, { 0, 2, 5 }, { 3, 4, 5 }, { 3, 5, 5 } });

            bool bc = CanJump(new int[] { 2, 3, 1, 1, 4 });
            bc = CanJump(new int[] { 3, 2, 1, 0, 4 });

            int mi = Jump(new int[] { 2, 3, 1, 1, 4 });

            var nn = MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7},3);

            nn = MaxSlidingWindow(new int[] {  }, 0);

            nn = MaxSlidingWindow(new int[] { 1, 3, 1, 2, 0, 5 }, 3);

            nn = MaxSlidingWindow(new int[] { 9,8,7,6,5,4,3,2,1 }, 3);
            nn = MaxSlidingWindow(new int[] { 1,10,1,2,9,8,9,9,3 }, 4);

            var ln = LargestDivisibleSubset(new int[] { 1, 2, 3 });
            ln = LargestDivisibleSubset(new int[] { 1, 2, 4, 8 });

            ln = LargestDivisibleSubset(new int[] { 1, 2, 3,4, 8 });

            int wl = WiggleMaxLength(new int[] { 1, 7, 4, 9, 2, 5 });

            wl = WiggleMaxLength(new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 });

            wl = WiggleMaxLength(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            int code = 'a';
            code = 'A';
            code = '1';
            code = 'z';

            string strR = MinWindow("ADOBECODEBANC", "ABC");

            int chosen = 3;
            int i = 5;
            chosen = chosen | (1 << i);

            bool isWin = CanIWin(20, 200);

            long ansAtoi = MyAtoi("123");
            ansAtoi = MyAtoi("-123");
            ansAtoi = MyAtoi("+123");
            ansAtoi = MyAtoi("+");
            ansAtoi = MyAtoi("-");
            ansAtoi = MyAtoi("+-9");
            ansAtoi = MyAtoi("     +004500");
            ansAtoi = MyAtoi("  -0012a42");
            ansAtoi = MyAtoi("   +0 123");//0
            ansAtoi = MyAtoi("2147483648");

            //int sfs = 2147483648;
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            n1.next = n2;
            var r = RemoveNthFromEnd(n1,2);

            var rSearchRange = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 },8);

            rSearchRange = SearchRange(new int[] { 1}, 0);

            string sMultiply = Multiply("145", "123");
            sMultiply = Multiply("0", "0");
            sMultiply = Multiply("9", "9");
            sMultiply = Multiply("9", "99");
            sMultiply = Multiply("408", "5");

            n1 = new ListNode(1);
            n2 = new ListNode(2);
            n1.next = n2;

            n1 = SwapPairs(n1);

            n1 = new ListNode(1);
            n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            n1.next = n2;
            n2.next = n3;
            n1 = SwapPairs(n1);

            n1 = new ListNode(1);
            n2 = new ListNode(2);
            n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n1 = SwapPairs(n1);
        }


        //Swap Nodes in Pairs
        //Given 1->2->3->4, you should return the list as 2->1->4->3
        public ListNode SwapPairs(ListNode head)
        {
            ListNode first = head;
            if (first == null) return first;
            ListNode second = first.next;
            if(second == null) return first;
            ListNode newHead = second;
            ListNode last = null;
            while (first != null && second != null)
            {
                ListNode nextOfPair = second.next;
                second.next = first;
                last = first;

                first = nextOfPair;
                
                if(first != null)
                    second = first.next;
                if (second != null)
                    last.next = second;
                else {
                    last.next = first;
                }
            }

            if(last != null && first == null)
            {
                last.next = null;
            }
            return newHead;
        }

        public string Multiply(string num1, string num2)
        {
            int[] ans = new int[num1.Length + num2.Length + 2];
            int[] cur = new int[num1.Length + 1];
            int l = 0, lCur = 0;
            int shift = 0;
            int carry = 0;
            for (int j = num2.Length - 1;j >= 0; j --)
            {
                carry = 0;
                lCur = 0;
                
                for (int i = num1.Length - 1; i>= 0; i --)
                {
                    int digit = Multiply(num1[i], num2[j]) + carry;
                    cur[lCur++] = digit % 10;
                    carry = digit / 10;
                }

                if(carry > 0)
                {
                    cur[lCur++] = carry;
                }
                l = AddTo(ans, l, cur, lCur, shift);
                shift++;
            }
            
            return ConvertToString(ans, l);
        }
        int Multiply(char c1,char c2)
        {
            return (c1 - '0') * (c2 - '0');
        }
        int AddTo(int []final,int len,int []cur, int lenCur, int shift)
        {
            int carry = 0;
            int i = 0;
            for (; i < len || i - shift < lenCur; i ++)
            {
                int sum = 0;
                if(i < len &&  i - shift >= 0)
                {
                    sum = final[i] + cur[i - shift];
                }else if(i < len)
                {
                    sum = final[i];
                }
                else if (i - shift >= 0)
                {
                    sum = cur[i - shift];
                }
                sum += carry;
                final[i] = sum % 10;
                carry = sum / 10;
            }
            if (carry > 0)
            {
                final[i ++]  = carry;
            }
            return i;
        }
        string ConvertToString(int []a,int l)
        {
            string str = "";
            int i = 0;

            for(; l > 0; l --)
            {
                if (a[l - 1] + '0' != '0')
                {
                    break;
                }
            }

            if(i < l)
            {
                for (; i < l; i++)
                {
                    str = (char)(a[i] + '0') + str;
                }
            }
            else
            {
                str = "0";
            }
            
            
            return str;
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int m = -1;
            bool found = false;
            while ( l <= r)
            {
                m = (l + r) / 2;
                if(nums[m] == target)
                {
                    found = true;
                    break;
                }else if(nums[m] < target)
                {
                    l = m + 1;
                }else
                {
                    r = m - 1;
                }
            }
            if (!found) return new int[] { -1, -1 };
            int i = m, j = m;
            while (i - 1 >= 0 && nums[i - 1] == target) i--;
            while (j + 1 < nums.Length && nums[j + 1] == target) j ++;
            return new int[] { i, j };

        }
        //Integer to Roman
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    sb.Append(strs[i]);
                }
            }
            return sb.ToString();
        }
        //21. Merge Two Sorted Lists
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode cur1 = l1;
            ListNode cur2 = l2;
            ListNode pre = new ListNode(int.MinValue);
            ListNode dummy = pre;
            while (cur1 != null && cur2 !=  null)
            {
                if(cur1.val < cur2.val )
                {
                    pre.next = cur1;
                    pre = cur1;
                    cur1 = cur1.next;
                   
                }
                else
                {
                    pre.next = cur2;
                    pre = cur2;
                    cur2 = cur2.next;
                }
            }
            while(cur1 != null)
            {
                pre.next = cur1;
                pre = cur1;
                cur1 = cur1.next;
            }
            while (cur2 != null)
            {
                pre.next = cur2;
                pre = cur2;
                cur2 = cur2.next;
            }
            return dummy.next;
        }

        //1->2->3->4->5, and n = 2.
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            int i = 1;
            ListNode cur = head;
            
            while (i < n)
            {
                cur = cur.next;
                i++;
            }

            ListNode preNthNode = null;
            while (cur.next != null)
            {
                cur = cur.next;
                if (preNthNode != null)
                    preNthNode = preNthNode.next;
                else
                    preNthNode = head;
            }
            if (preNthNode == null)
            {
                return head.next;
            }
            preNthNode.next = preNthNode.next.next;
            return head;
        }
        //int i = 1;
        //ListNode cur = head;
        //while (i < n)
        //{
        //    if (cur == null) return head;
        //    cur = cur.next;
        //}
        //if (cur == null) return head.next;

        //ListNode preNthNode = null;

        //while(cur != null)
        //{
        //    cur = cur.next;
        //    preNthNode = preNthNode.next;
        //}
        //if (preNthNode == null) return head.next;

        //ListNode nthNode = preNthNode.next;
        //if (nthNode != null)
        //    preNthNode.next = nthNode.next;
        //return head;

        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int max = 0;
            while (left < right)
            {
                max = Math.Max(max, Math.Min(height[left], height[right])*(right - left));
                if(height[left] < height[right])
                {
                    left++;
                }else
                {
                    right--;
                }
            }
            return max;
        }

        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            long ans = 0;
            int i = 0;
            bool negative = false;
            bool firstChar = false;

            for (; i < str.Length ; i ++)
            {
                if (str[i] != ' ') break;
            }
            int j = str.Length - 1;
            for (; j >= 0; j --)
            {
                if (str[j] != ' ') break;
            }

            for (; i <= j ; i ++)
            {
               

                int digit = str[i] - '0';
                
                if(!(digit >=0 && digit <= 9))
                {
                    if(!firstChar)
                    {
                        firstChar = true;
                        if (str[i] == '-')
                        {
                            negative = true;
                            continue;
                        }
                        else if (str[i] == '+')
                        {
                            continue;
                        }
                    }
                    
                    break;
                }
                ans = ans * 10 + digit;
            }
            return negative ? (int)-ans : (int)ans;
        }
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            int n = maxChoosableInteger;
            int s = desiredTotal;

            if (n <= 0) return false;
            if (s <= 0) return true;
            if (n * (n + 1) / 2 < s) return false;
            bool[] dp = new bool[1 << n];
            for (int m = 0; m < (1 << n); m++)
            {
                int t = 0;
                bool w = false;
                for (int i = 0; i < n; i++)
                {
                    if(m == 38)
                    {
                        int ss = 10;
                    }
                    if ((m & (1 << i)) != 0)
                    {
                        if (!dp[m ^ (1 << i)])
                        {
                            w = true;
                        }
                    }
                    else {
                        t += (i + 1);
                    }
                }
                dp[m] = (t < s && w);
            }
            bool ret = dp[(1 << n) - 1];
            return ret;
        }
        //public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        //{

        //    dp = new int[1 << 20];
        //    for (int i = 0; i < dp.Length; i++)
        //        dp[i] = -1;
        //    m = maxChoosableInteger;
        //    all = desiredTotal;

        //    if (desiredTotal == 0) return true;
        //    if (m * (m + 1) / 2 < all) return false;

        //    go(true, 0, all);
        //    return dp[0] != 0;
        //}
        //int all;
        //int m;
        //int[] dp;
        //bool go(bool firstPlayer, int chosen, int remain)
        //{
        //    if (dp[chosen] != -1) return dp[chosen] != 0;
        //    if (remain <= 0)
        //    {
        //        dp[chosen] = 1;
        //        return !firstPlayer;
        //    }
        //    if (firstPlayer)
        //    {
        //        bool win = false;
        //        for (int i = 1; i <= m; i++)
        //            if ((chosen & (1 << (i - 1))) != 0)
        //            {
        //                if (remain <= i)  
        //                {
        //                    dp[chosen] = 1;
        //                    return true;
        //                } 
        //                win |= go(!firstPlayer, (chosen | (1 << (i - 1))), remain - i);
        //            }

        //        dp[chosen] = win;
        //        return (

        //        } );
        //    }
        //    else {
        //        bool win = true;
        //        for (int i = 1; i <= m; i++) if (!(chosen & (1 << (i - 1))))
        //            {
        //                if (remain <= i) return (dp[chosen] = 0);
        //                win &= go(!firstPlayer, (chosen | (1 << (i - 1))), remain - i);
        //            }
        //        return (dp[chosen] = win);
        //    }
        //}


        //76. Minimum Window Substring
        //https://discuss.leetcode.com/topic/3107/accepted-o-n-solution
        public string MinWindow(string s, string t)
        {
            int count = 0;
            
            int[] countList = new int[128];
            bool[] hasChar = new bool[128];

            int minLength = int.MaxValue;
            for (int k = 0; k < t.Length; k++)
            {
                countList[t[k]]++;
                hasChar[t[k]] = true;
            }
            int i = -1;
            int j = 0;
            int startIndex = 0;
            
            while(i < s.Length && j < s.Length)
            {
                if(count < t.Length)
                {
                    i++;
                    if(i < s.Length)
                    {
                        if (hasChar[s[i]] && countList[s[i]] > 0)
                        {
                            count++;
                        }

                        countList[s[i]]--;
                    }

                }
                else// countList may has negative which point to char is not in T
                {
                    if (i - j + 1 < minLength)
                    {
                        minLength = i - j + 1;
                        startIndex = j;
                    }
                    
                    
                    if (hasChar[s[j]] && countList[s[j]] >= 0)
                    {
                        count--;
                    }
                    countList[s[j]]++;
                    j++;

                }
                
            }
            if (minLength == int.MaxValue) return "";
            return s.Substring(startIndex, minLength) ;
        }

        public int WiggleMaxLength(int[] nums)
        {
            int up = 1;
            int down = 1;
            int n = nums.Length;
            if (n < 2) return n;

            for(int i = 1;i < nums.Length;i ++)
            {
                if(nums[i] > nums[i - 1])
                {
                    up = down + 1;
                    
                }else if(nums[i] < nums[i - 1])
                {
                    down = up + 1;
                }
            }
            return Math.Max(down, up);
        }

        //https://discuss.leetcode.com/topic/49652/classic-dp-solution-similar-to-lis-o-n-2
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int[] count = new int[n];
            int[] pre = new int[n];
            int index = -1;
            int max = 0;
            for (int i = 0;i < n;i ++)
            {
                count[i] = 1;
                pre[i] = -1;
                for(int j = i - 1;j >= 0;j --)
                {
                    if(nums[i] % nums[j] == 0 && 1 + count[j] > count[i])
                    {
                        count[i] = 1 + count[j];
                        pre[i] = j;
                    }
                }
                if(count[i] > max)
                {
                    max = count[i];
                    index = i;
                }
            }
            IList<int> list = new List<int>();
            while(index != -1)
            {
                list.Add(nums[index]);
                index = pre[index];
            }
            return list;
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];

            int[] result = new int[nums.Length - k + 1];

            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (deque.Count > 0 && deque.First() == i - k)
                    deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last()] < nums[i])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);

                if (i + 1 >= k)
                    result[i + 1 - k] = nums[deque.First()];
            }

            return result;
        }

        //public int[] MaxSlidingWindow(int[] nums, int k)
        //{
        //    int n = nums.Length;
        //    int[] A = nums;
        //    if (n == 0)
        //    {
        //        return A;
        //    }
        //    int[] B = new int[nums.Length - k + 1];
        //    Deque Q = new Deque();

        //    for (int i = 0; i < k; i++)
        //    {
        //        while (!Q.empty() && nums[i] >= nums[Q.back()])
        //            Q.pop_back();
        //        Q.push_back(i);
        //    }
        //    for (int i = k; i < nums.Length; i++)
        //    {
        //        B[i - k] = A[Q.front()];
        //        while (!Q.empty() && A[i] >= A[Q.back()])
        //            Q.pop_back();
        //        while (!Q.empty() && Q.front() <= i - k)
        //            Q.pop_front();
        //        Q.push_back(i);
        //    }
        //    B[n - k] = A[Q.front()];
        //    return B;
        //}

        

        public bool CanWinNim(int n)
        {
            return !(n % 4 == 0);
        }


        public int Jump(int[] nums)
        {
            int[] dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = int.MaxValue;
            }
            dp[0] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dp[j] < int.MaxValue)
                    {
                        if (nums[j] + j >= i && dp[j] + 1 < dp[i])
                        {
                            dp[i] = dp[j] + 1;
                        }
                    }
                }
            }
            return dp[nums.Length - 1];
        }

        //greedy

        public bool CanJump(int[] nums)
        {
            int N = nums.Length;
            int lastPos = N - 1;
            for(int i = N - 1;i >= 0; i--)
            {
                if(i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;
        }

        //dynamic programming
        //public bool CanJump(int[] nums)
        //{
        //    bool[] dp = new bool[nums.Length];
        //    dp[0] = true;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for(int j = i - 1; j >= 0; j --)
        //        {
        //            if(dp[j])
        //            {
        //                if(nums[j] + j >= i)
        //                {
        //                    dp[i] = true;
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    return dp[nums.Length - 1];

        //}

        public int MinTransfers(int[,] transactions)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < transactions.GetLength(0); i++)
            {
                if (!dic.ContainsKey(transactions[i, 0]))
                {
                    dic.Add(transactions[i, 0], -transactions[i, 2]);
                }
                else
                {
                    dic[transactions[i, 0]] += -transactions[i, 2];
                }
                if (!dic.ContainsKey(transactions[i, 1]))
                {
                    dic.Add(transactions[i, 1], transactions[i, 2]);
                }
                else
                {
                    dic[transactions[i, 1]] += transactions[i, 2];
                }
            }
            List<int> listNeg = new List<int>();
            List<int> listPos = new List<int>();
            foreach (var ele in dic.Values)
            {
                if (ele > 0)
                {
                    listPos.Add(ele);
                }
                else if (ele < 0)
                {
                    listNeg.Add(-ele);
                }
            }
            if (listNeg.Count == 0 && listPos.Count == 0) return 0;

            int match = 0;
            foreach(var ele in listPos)
            {
                int i = 0;
                for(i = 0;i < listNeg.Count; i ++)
                {
                    if (ele == listNeg[i])
                        break;
                }
                if(i <  listNeg.Count)
                {
                    listNeg.RemoveAt(i);
                    match++;
                }
            }
            return match + Math.Max(0, listPos.Count - match + listNeg.Count - 1);
        }
        //public int minMoves(int[] nums)
        //{
        //    //Arrays.sort(nums);
        //    //int moves = 0;
        //    //for (int i = nums.length - 1; i >= 1; i--)   // no. of moves will be equal to sum of subtracting smallest element from every other element            
        //    //    moves += (nums[i] - nums[0]);

        //    //return moves;
        //}
        //public int MinTransfers(int[,] transactions)
        //{

        //    Dictionary<int, long> bal = new Dictionary<int, long>();
        //    int i = 0;
        //    for (;i < transactions.GetLength(0); i ++)
        //    {
        //        if (!bal.ContainsKey(transactions[i,0])) bal.Add(transactions[i,0], 0L);
        //        if (!bal.ContainsKey(transactions[i,1])) bal.Add(transactions[i, 1], 0L);
        //        bal[transactions[i, 0]] += (long)transactions[i,2];
        //        bal[transactions[i, 1]] -= (long)transactions[i, 2];
        //    }
        //    Dictionary<long, int> balancemap = new Dictionary<long, int>();
        //    foreach (var person in bal.Keys)
        //    {
        //        long cur = bal[person];
        //        if (cur != 0L)
        //        {
        //            var v = (balancemap.ContainsKey(cur) ? balancemap[cur] : 0) + 1;
        //            balancemap.Add(cur,v);
        //        }
        //    }
        //    int payment = 0;
        //    while (balancemap.Count > 0)
        //    {
        //        long lo = balancemap.firstKey();
        //        long hi = balancemap.lastKey();
        //        long sum = lo + hi;

        //        if (balancemap.get(lo) == 1)
        //        {
        //            balancemap.remove(lo);
        //        }
        //        else {
        //            balancemap.put(lo, balancemap.get(lo) - 1);
        //        }
        //        if (balancemap.get(hi) == 1)
        //        {
        //            balancemap.remove(hi);
        //        }
        //        else {
        //            balancemap.put(hi, balancemap.get(hi) - 1);
        //        }

        //        if (sum != 0)
        //        {
        //            balancemap.put(sum, balancemap.getOrDefault(sum, 0) + 1);
        //        }
        //        payment++;
        //    }
        //    return payment;
        //}

        //http://www.bytehood.com/making-all-integers-in-an-array-same-using-minimum-steps/388/
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int numM = 0;
            int mid = nums[(nums.Length - 1) / 2];
            numM = Diff(nums, mid);
            mid = nums[(nums.Length) / 2];
            int numM1 = Diff(nums, mid);
            if (numM1 < numM)
                numM = numM1;
            return numM;

        }

        int Diff(int []a,int target)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i++)
            {
                num += Math.Abs(a[i] - target);
            }
            return num;
        }
        public int IslandPerimeter(int[,] grid)
        {
            int nr = grid.GetLength(0);
            int nc = grid.GetLength(1);
            int num = 0;
            for(int i = 0;i < nr;i ++)
            {
                for (int j = 0; j < nc; j++)
                {
                    if(grid[i,j] > 0)
                    {
                        if (j == 0 || grid[i, j - 1] == 0)
                        {
                            num += 2;
                        }
                    }
                    
                }
            }
            for (int j = 0; j < nc; j++)
            {
                for (int i = 0; i < nr; i++)
                {
                    if (grid[i, j] > 0)
                    {
                        if (i == 0 || grid[ i - 1,j] == 0)
                        {
                            num += 2;
                        }
                    }

                }
            }
            return num;
        }

        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            TreeNode left = root.left;
            TreeNode right = root.right;

            root.left = null;
            Flatten(left);
            Flatten(right);

            root.right = left;
            TreeNode current = root;
            while (current.right != null) current = current.right;
            current.right = right;
        }

       


        //Flatten Binary Tree to Linked List 

        //TreeNode preNode = null; 
        //public void Flatten(TreeNode root)
        //{
        //    preNode = null;
        //    if (root == null) return;
        //    Dfs(root);
        //}

        //void Dfs(TreeNode root)
        //{
        //    TreeNode left = root.left;
        //    TreeNode right = root.right;

        //    if (preNode != null)
        //    {
        //        preNode.right = root;
        //    }
        //    root.left = preNode;
        //    preNode = root;

        //    if (left != null)
        //        Dfs(left);
        //    if (right != null)
        //        Dfs(right);
        //}

        //public void Flatten(TreeNode root)
        //{
        //    List<TreeNode> list = new List<TreeNode>();
        //    if (root == null) return;
        //    Dfs(root, list);

        //    TreeNode pre = null;
        //    foreach (var n in list)
        //    {
        //        if(pre != null)
        //        {
        //            pre.right = n;
        //        }
        //        n.left = pre;
        //        pre = n;
        //    }

        //}
        //void Dfs(TreeNode root, List<TreeNode> list)
        //{
        //    if (root != null)
        //        list.Add(root);
        //    if (root.left != null)
        //        Dfs(root.left, list);
        //    if (root.right != null)
        //        Dfs(root.right, list);
        //}

        int minDepth = int.MaxValue;
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            minDepth = int.MaxValue;
            MinDepth(root,1);
            return minDepth;
        }
        public void MinDepth(TreeNode root,int h)
        {
            if(root.left == null && root.right == null)
            {
                minDepth = Math.Min(h, minDepth);
                return;
            }
            if(root.left != null)
            {
                MinDepth(root.left, h + 1);
            }
            if (root.right != null)
            {
                MinDepth(root.right, h + 1);
            }
        }
        //Invert Binary Tree
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            var newRoot = new TreeNode(root.val);
            if (root.left != null)
            {
                var child = InvertTree(root.left);
                newRoot.right = child;
            }
            if (root.right != null)
            {
                var child = InvertTree(root.right);
                newRoot.left = child;
            }
            return newRoot;
        }

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            q1.Enqueue(root);
            IList<IList<int>> preAns = new List<IList<int>>();
            IList<int> list = new List<int>();
            
            while (q1.Count > 0)
            {
                TreeNode node = q1.Dequeue();
                int v = node.val;
                list.Add(v);
                if(node.left != null)
                {
                    q2.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q2.Enqueue(node.right);
                }

                if(q1.Count == 0)
                {
                    preAns.Add(list);
                    list = new List<int>();
                    q1 = q2;
                    q2 = new Queue<TreeNode>();
                }
            }
            IList<IList<int>> ans = new List<IList<int>>();
            for(int i = preAns.Count - 1; i >= 0;i --)
            {
                ans.Add(preAns[i]);
            }
            return ans;
        }

        void ReverseString(StringBuilder str)
        {
            int start = int.MaxValue;
            ReverseString(str, 0, str.Length - 1);
            for (int i = 0;i < str.Length;i ++ )
            {
                if(start == int.MaxValue && str[i] != ' ')
                {
                    start = i;
                }

                if(start < int.MaxValue && (i + 1 == str.Length || str[i + 1] == ' '))
                {
                    ReverseString(str, start, i);
                    start = int.MaxValue;
                }

            }
            
        }
        void ReverseString(StringBuilder str,int start, int end)
        {
            while(start < end)
            {
                char tmp = str[start];
                str[start] = str[end];
                str[end] = tmp;
                start++;
                end--;
            }
        }
        public void RadixSort(int []nums)
        {
            int[] tmp = new int[nums.Length];
            int[] pos = new int[10];
            int nTh = 0;
            while (true)
            {
                SetZero(pos);
                bool allZero = true;
                for(int i = 0;i < nums.Length; i ++)
                {
                    bool isZero = false;
                    int digit = GetDigit(nums[i], nTh,ref isZero);
                    if (!isZero) allZero = false;
                    pos[digit]++; 
                }
                if (allZero) break;
                pos[pos.Length - 1] = nums.Length - pos[pos.Length - 1] ;
                for (int i = pos.Length - 2; i >= 0 ; i --)
                {
                    pos[i] = pos[i + 1] - pos[i];
                }
                
                for (int i = 0; i < nums.Length; i++)
                {
                    bool isZero = false;
                    int digit = GetDigit(nums[i], nTh, ref isZero);
                    tmp[pos[digit]] = nums[i];
                    pos[digit]++;
                }
                for(int i = 0;i < nums.Length;i ++)
                {
                    nums[i] = tmp[i];
                }
                nTh++;
            }
        }
        int GetDigit(int n, int k,ref bool isZero)
        {
            while(k > 0)
            {
                n /= 10;
                if (n == 0) {
                    isZero = true;
                    return 0;
                }
                k--;
            }
            return n % 10;
        }
        void SetZero(int []a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int lH = GetHeight(root.left);
            int rH = GetHeight(root.right);
            if (Math.Abs(lH - rH) <= 1 && IsBalanced(root.left) && IsBalanced(root.right))
                return true;
            return false;
        }

        private int GetHeight(TreeNode root)
        {
            int ans = 0;
            if (root == null) return ans;
            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            InorderTraversal(root, list);
            return list;
        }
        public void InorderTraversal(TreeNode root, List<int> list)
        {
            if (root == null) return;
            InorderTraversal(root.left, list);
            list.Add(root.val);
            InorderTraversal(root.right, list);
        }

        int CalculateTheNumberOfDistinctsPairs(int []a,int target)
        {
            HashSet<int> hs = new HashSet<int>();
            HashSet<int> hsExist = new HashSet<int>();
            int ans = 0;
            for(int i = 0;i <a.Length;i ++)
            {
                int com = target - a[i];
                if (hs.Contains(com))
                {
                    if(!hsExist.Contains(com))
                    {
                        ans++;
                        hsExist.Add(com);
                    }
                }
                else
                {
                    hs.Add(a[i]);
                }
            }
            return ans;
        }
        public bool CanPartition(int[] nums)
        {
            int half = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                half += nums[i];
            }
            if (half % 2 == 1) return false;
            half /= 2;
            return CanFindTarget(nums, half);
        }
        private bool CanFindTarget(int[] nums, int target)
        {
            bool[,] m = new bool[target + 1, nums.Length];
            for (int j = 0; j < nums.Length; j++)
                if (nums[j] <= target)
                    m[nums[j], j] = true;
            for (int i = 1; i <= target; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    m[i, j] = m[i, j] || m[i, j - 1];
                    if (i >= nums[j])
                    {
                        m[i, j] = m[i, j] || m[i - nums[j], j - 1];
                    }
                }
            }
            return m[target, nums.Length - 1];
        }



        //bool bFoundHalf = false;
        //public bool CanPartition(int[] nums)
        //{
        //    int half = 0;
        //    bFoundHalf = false;
        //    for (int i = 0;i < nums.Length; i++)
        //    {
        //        half += nums[i];
        //    }
        //    if (half % 2 == 1) return false;
        //    half /= 2;
        //    FindTarget(nums, half, 0);
        //    return bFoundHalf;
        //}
        //private void FindTarget(int[] nums,int target,int start)
        //{
        //    if (bFoundHalf || target < 0) return;
        //    if(target == 0)
        //    {
        //        bFoundHalf = true;
        //        return;
        //    }

        //    for (int i = start; i < nums.Length; i++)
        //    {
        //        FindTarget(nums, target - nums[i],i + 1);
        //    }
        //}

        public int FindNthDigit(int n)
        {
            long n1 = n;
            if (n1 < 10) return n;
            n1 -= 9;
            long curMin = 10;
            long curNumDigit = 2;
            while (n1 >= 0)
            {
                long lg = (curMin * 10 - curMin) * curNumDigit;
                if (lg < n1)
                {
                    n1 -= lg;
                    curNumDigit++;
                    curMin *= 10;
                }
                else
                {
                    long x = (n1 - 1) / curNumDigit;
                    long curNum = x + curMin;
                    n1 -= x * curNumDigit;
                    return (int)GetDigitFromRight(curNum, curNumDigit - n1 + 1);
                }
            }
            return 1;
        }
        long GetDigitFromRight(long num, long n)
        {
            while(num > 0)
            {
                if (n == 1) return num % 10;
                num /= 10;
                n--;
            }
            return 0;
        }

        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            int N = A.Length;
            int num = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int target = (A[i] + B[j]);
                    if(dic.ContainsKey(target))
                    {
                        dic[target]++;
                    }
                    else
                    {
                        dic.Add(target, 1);
                    }

                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int target = -(C[i] + D[j]);
                    if (dic.ContainsKey(target))
                    {
                        num += dic[target];
                    }
                    
                }
            }
            return num;
        }

        //public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        //{
        //    Array.Sort(A);
        //    Array.Sort(B);
        //    Array.Sort(C);
        //    Array.Sort(D);
        //    int N = A.Length;
        //    int num = 0;
        //    for(int i = 0;i < N; i ++)
        //    {
        //        for(int j = 0;j < N; j ++)
        //        {
        //            int target = -(A[i] + B[j]);

        //        }
        //    }

        //    return num;
        //}

        public bool Find132pattern(int[] nums)
        {
            int min = int.MaxValue;
            int second = int.MinValue;
            int first = min;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > first && nums[i] < second)
                {
                    return true;
                }
                if (nums[i] > second && nums[i] > min)
                {
                    second = nums[i];
                    first = min;
                }
                if (min > nums[i])
                    min = nums[i]; 
            }
            return false;
        }

        //int first = int.MaxValue;
        //for(int i = 0;i < nums.Length - 2; i++)
        //{
        //    if(nums[i] < first)
        //    {
        //        first = nums[i];
        //        for(int j = i + 1;j < nums.Length - 1; j ++)
        //        {
        //            if(nums[j] > nums[i])
        //            {
        //                for (int k = j + 1; k< nums.Length; k++)
        //                {
        //                    if(nums[k] < nums[j] && nums[k] > nums[i])
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //return false;
        public bool RepeatedSubstringPattern(string str)
        {
            int len = str.Length;
            int divide = 2;
            while(divide <= len)
            {
                if (len % divide == 0)
                {
                    int del = len / divide;
                    bool match = true;
                    for (int i = 0; i < del; i++)
                    {

                        for (int j = 0; j < divide; j++)
                        {
                            if (str[i + j * del] != str[i])
                            {
                                match = false;
                                break;
                            }
                        }


                    }
                    if (match)
                    {
                        return true;
                    }
                }
                divide++;
            }
            return false;
        }

        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int i = 0, j = 0;
            int num = 0;
            while (j < s.Length && i < g.Length)
            {
                while (j < s.Length && s[j] < g[i]) j++;
                if(j < s.Length)
                {
                    num++;
                    i++;
                    j++;
                }
            }
            return num;
        }
    }
}
