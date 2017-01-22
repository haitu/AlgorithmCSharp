using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Solution2
    {
        //static void Main(string[] args)
        //{
        //    Solution2 pro = new Solution2();
        //    pro.test();
        //}
        void test()
        {
            var listD = DiffWaysToCompute("2-1-1");
            listD = DiffWaysToCompute("2*3-4*5");

            int a = 2323;
            int b = 5646;
            a = a ^ b;
            b = a ^ b;
            b = a ^ b;

            int diff = 8;
            diff &= -diff;

            var arr = SingleNumber(new int[] { 1, 2, 1, 3, 2, 5 });

            a = 0xD;
            b = 0x1;
            int c = a ^ b;
            c = GetFirstBitDifferent(c);
            //c = (c & (c - 1)) ^ c;
            arr = SingleNumber(new int[] { 43772400, 1674008457, 1779561093, 744132272, 1674008457, 448610617, 1779561093, 124075538, -1034600064, 49040018, 612881857, 390719949, -359290212, -812493625, 124732, -1361696369, 49040018, -145417756, -812493625, 2078552599, 1568689850, 865876872, 865876872, -1471385435, 1816352571, 1793963758, 2078552599, -1034600064, 1475115274, -119634980, 124732, 661111294, -1813882010, 1568689850, 448610617, 1347212898, -1293494866, 612881857, 661111294, -1361696369, 1816352571, -1813882010, -359290212, 1475115274, 1793963758, 1347212898, 43772400, -1471385435, 124075538, -1293494866, -119634980, 390719949});
            var t = ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 },1, 2147483647);
            t = ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 }, 1, 2147483647);
            t = ContainsNearbyAlmostDuplicate(new int[] { -1, -1 }, 1, 0);

            t = ContainsNearbyAlmostDuplicate(new int[] { 1, 2 }, 0, 1);
            t = ContainsNearbyAlmostDuplicate(new int[] { -3,3 }, 2, 4);

            t = ContainsNearbyAlmostDuplicate(new int[] { 2,4}, 1, 1);
            t = ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 }, 1, 2147483647);

            t = ContainsNearbyAlmostDuplicate(new int[] { 1, 12 }, 3, 10);

            Dictionary<int, int> dicT = new Dictionary<int, int>();
            dicT.Add(1, 1);
            //dicT.Add(1, 2);
            dicT.Remove(-1);
            int mq1 = NumSquares(12);
            mq1 = NumSquares(13);

            mq1 = ComputeArea(-2, -2, 2, 2, -2, -2, 2, 2);

            bool b2 = IsPowerOfTwo(1073741825);

            int mn = MissingNumber(new int[] { 0, 1, 3 });

            var postF = InfixToPostfix("3+3*4");
            postF = InfixToPostfix("3+3*4 + 3/4*4 + 19*20");

            int resultC = Calculate("3+3*4");
            resultC = Calculate("3+3*4 + 3/4*4 + 19*20");
            resultC = Calculate("3/4");
            resultC = Calculate("3/4*4");
            resultC = Calculate("3/2");
            resultC = Calculate("3+2*2");
            resultC = Calculate(" 3/2 ");
            resultC = Calculate(" 3+5 / 2 ");

            int ml = LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            int fb = FirstBadVersion(16);

            fb = FirstBadVersion(10);
            fb = FirstBadVersion(11);

            var ll = CreateList(new int[] { 1, 2 });
            ll = ReverseList(ll);

            ll = CreateList(new int[] { 1, 2,3,4 });
            ll = ReverseList(ll);
            ml = MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });

            ml = MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 8, 3 });
            ml = MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 5, 3 });
            ml = MinSubArrayLen(50, new int[] { 2, 3, 1, 2, 5, 3 });
            ml = MinSubArrayLen(11, new int[] { 1, 2, 3, 4, 5 });


            ml = MinSubArrayLen(15, new int[] { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8 });

            ml = MinSubArrayLen(80, new int[] { 10, 5, 13, 4, 8, 4, 5, 11, 14, 9, 16, 10, 20, 8 });

            ml = MinSubArrayLen(2, new int[] { 23,2,1,1,3,4 });

            int countP = CountPrimes(5);

            countP = TrailingZeroes(25);
            countP = TrailingZeroes(70);
            countP = TrailingZeroes(1808548329);

            var bcf = CanFinish(2, new int[,] { { 0, 1 }, { 1, 0 } });
            bcf = CanFinish(2, new int[,] { { 0, 1 }, { 1, 2 } });
            bcf = CanFinish(2, new int[,] { { 0, 1 } });

            bcf = CanFinish(3, new int[,] { { 1, 0 }, { 2, 0 } });

            var ga = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            //Merge(new int[] { 1, 2, 2, 5, 0 }, 4, new int[] { 1 }, 1);

            var mat = GenerateMatrix(5);

            var head = CreateList(new int[] { 1,2,3,4,5});
            var newH = RotateRight(head, 2);
            head = CreateList(new int[] { 1, 2, 3, 4, 5 });
            newH = RotateRight(head, 4);

            head = CreateList(new int[] { 1, 2 });
            newH = RotateRight(head, 4);
            head = CreateList(new int[] { 1, 2 });
            newH = RotateRight(head, 2);
            int upn = UniquePaths(1, 1);

            int sq = MySqrt(10);
            sq = MySqrt(2);
            sq = MySqrt(9);
            sq = MySqrt(20);
            sq = MySqrt(2147395599);

            var ll1 = Combine(4,2);
            ll1 = Combine(3, 2);
            ll1 = Combine(3, 4);

            ListNode headLn = CreateList(new int[] { 1,2,3,4});

            headLn = ReorderList(headLn);

            headLn = CreateList(new int[] { 1, 2, 3, 4,5 });

            headLn = ReorderList(headLn);

            headLn = CreateList(new int[] { 1});

            headLn = ReorderList(headLn);
            headLn = CreateList(new int[] { 1,2});

            headLn = ReorderList(headLn);

            var lor = LexicalOrder(20);
            lor = LexicalOrder(120);
            lor = LexicalOrder(10);

            var tm = ThirdMax(new int[] { 3, 2, 1 });
            tm = ThirdMax(new int[] { 3, 2,2, 1 });

            tm = ThirdMax(new int[] { 1, 2, -2147483648 });
            tm = ThirdMax(new int[] { 1, 2, });
        }

        //public int ThirdMax(int[] nums)
        //{
        //    int n1 = nums[0], n2 = int.MaxValue, n3 = int.MaxValue;
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        int v = nums[i];
        //        if(v > n1)
        //        {
        //            if (n2 == v || n3 == v)
        //                continue;
        //            if(v > n2)
        //        }
        //    }
        //    return n1;

        //}

        public int ThirdMax(int[] nums)
        {
            List<int> list = new List<int>();
            list.Add(nums[0]);
            foreach (var v in nums)
            {
                int i = 0;
                for (; i < list.Count; i++)
                {
                    if(v > list[i])
                    {
                        
                        continue;
                    }else if(v == list[i])
                    {
                        i = -1;
                        break;
                    }else
                    {
                        
                        break;
                    }

                }
                if(i >= 0)
                    list.Insert(i, v);
                if (list.Count > 3)
                {
                    list.RemoveAt(0);
                }
                
            }
            return list.Count < 3 ? list[list.Count - 1] : list[0];
        }

        //public int ThirdMax(int[] nums)
        //{
        //    long[] threeNumbers = new long[3];
        //    threeNumbers[0] = threeNumbers[1] = threeNumbers[2] = long.MinValue;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        long v = nums[i];
        //        if(v == threeNumbers[0] || threeNumbers[1]== v || threeNumbers[2] == v)
        //        {
        //            continue;
        //        }
        //        if(v > threeNumbers[0])
        //        {
        //            threeNumbers[0] = v;
        //            if(threeNumbers[1] < threeNumbers[0])
        //            {
        //                Swap(threeNumbers, 1, 0);
        //            }
        //            if (threeNumbers[2] < threeNumbers[0])
        //            {
        //                Swap(threeNumbers, 2, 0);
        //            }
        //        }
        //    }
        //    long ans = threeNumbers[0] > long.MinValue ? threeNumbers[0] : Math.Max(threeNumbers[1], threeNumbers[2]);
        //    return (int)ans;
        //}
        void Swap(long[] a, int i, int j)
        {
            long tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
        void Swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
        public IList<int> LexicalOrder(int n)
        {
            IList<int> list = new List<int>();
            Solve(n, 1, list);
            return list;
        }
        void Solve(int n, int m,IList<int> list)
        {
            list.Add(m);
            if(m* 10 <= n)
            {
                Solve(n, m*10, list);
            }
            if(m < n && m % 10 < 9)
            {
                Solve(n, m + 1, list);
            }
        }

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            return SumOfLeftLeaves(root, false);
        }
        public int SumOfLeftLeaves(TreeNode root,bool isLeft)
        {
            if(isLeft && root.left == null && root.right == null)
            {
                return root.val;
            }
            return (root.left != null ? SumOfLeftLeaves(root.left, true) : 0) 
                + (root.right != null ? SumOfLeftLeaves(root.right, false) : 0);
        }

        public ListNode ReorderList(ListNode head)
        {
            if (head == null) return head;
            ListNode p1 = head;
            ListNode p2 = head;
            while(p2 != null && p2.next != null && p2.next.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
            }

            p2 = p1.next;
            p1 = head;
            p2 = Reverse(p2);
            while(p2 != null)
            {
                ListNode tmp1 = p1.next, tmp2 = p2.next;
                p1.next = p2;
                p2.next = tmp1;
                p1 = tmp1;
                p2 = tmp2;

            }
            if(p1 != null)
            {
                p1.next = null;
            }
            return head;
        }
        ListNode Reverse(ListNode head)
        {
            ListNode cur = head;
            ListNode last = null,tmp,tmp2;
            while(cur != null && cur.next != null)
            {
                tmp = cur.next.next;
                tmp2 = cur.next;
                cur.next.next = cur;
                cur.next = last;
                last = tmp2;
                cur = tmp;
            }
            if(cur != null)
            {
                cur.next = last;
                return cur;
            }
            return last;
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if(p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            if(p.val != q.val)
            {
                return false;
            }
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        IList<IList<int>> listOfList;
        public IList<IList<int>> Combine(int n, int k)
        {
            
            listOfList = new List<IList<int>>();
            if (n < k) return listOfList;

            IList<int> list = new List<int>();
            DfsCom(n,k,1,list);
            return listOfList;
        }

        void DfsCom(int n, int k, int start, IList<int> list)
        {
            if(list.Count == k)
            {
                listOfList.Add(CreateArray(list));
                return;
            }
            for( int i = start; i <= n; i++)
            {
                list.Add(i);
                DfsCom(n, k, i + 1, list);
                list.Remove(i);
            }

        }
        int[] CreateArray(IList<int> list)
        {
            int[] arrNew = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                arrNew[i] = list[i];
            }
            return arrNew;
        }

        

        public int MySqrt(int x)
        {
            if (x == 1 || x == 0) return x;

            int l = 2;
            int r = x - 1;
            while(l <= r)
            {
                int m = (r - l) / 2 + l;
                long m2 = (long)m * (long)m;
                if(m2 == x)
                {
                    return m;
                }else if(m2 < x)
                {
                    l = m + 1;
                }
                else if (m2 > x)
                {
                    
                    r = m - 1;
                }
            }
            return r;
        }

        public int[] PlusOne(int[] digits)
        {
            int carry = 0;
            for(int i = digits.Length - 1;i >= 0;i --)
            {
                int v = digits[i] + 1;
                digits[i] = v >= 10 ? 0 : v;
                carry = v >= 10 ? 1 : 0;
                if(carry == 0)
                {
                    return digits;
                }

            }
            int[] a = new int[digits.Length + 1];
            a[0] = 1;
            return a;
        }


        public int MinPathSum(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i, j] = grid[i, j];
                        continue;
                    }else if (i == 0)
                    {
                        dp[i, j] = grid[i, j] + dp[i, j - 1];
                        continue;
                    }else if (j == 0)
                    {
                        dp[i, j] = grid[i, j] + dp[i - 1, j];
                        continue;
                    }


                    dp[i, j] = grid[i, j] + Math.Min(dp[i - 1, j],dp[i, j - 1]);
                }
            }
            return dp[m - 1, n - 1];
        }
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.GetLength(1);

            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i, j] = obstacleGrid[0,0] == 0 ? 1 : 0;
                        continue;
                    }
                    if (i == 0)
                    {
                        dp[i, j] = obstacleGrid[i, j] == 0 ? dp[i, j -1] : 0;
                        continue;
                    }
                    if (j == 0)
                    {
                        dp[i, j] = obstacleGrid[i, j] == 0 ? dp[i - 1, j] : 0;
                        continue;
                    }

                    dp[i, j] = obstacleGrid[i, j] == 0 ? dp[i - 1, j] + dp[i, j - 1]: 0;
                }
            }
            return dp[m - 1, n - 1];
        }

        //62. Unique Paths
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m, n];
            for(int i = 0;i < m;i ++)
            {
                for(int j = 0;j < n;j ++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                        continue;
                    }
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0 || head == null || head.next == null) return head;
            int i = 0;
            ListNode pre = head;
            int count = 0;
            ListNode last = null;
            while (pre != null)
            {
                count++;
                last = pre;
                pre = pre.next;
            }
            k = k % count;
            if (k == 0) return head;

            pre = head;
            while (i < k)
            {
                pre = pre.next;
                i++;
            }
            int shift = count - k;
            i = 0;

            ListNode newHead = head;
            ListNode preHead = null;
            if (shift == 0) return head;

            while (i < shift)
            {
                preHead = newHead;
                newHead = newHead.next;
                i++;
            }
            
            preHead.next = null;
            last.next = head;
            return newHead;
        }

        public int[,] GenerateMatrix(int n)
        {
            int maxN = n * n;
            int[,] matrix = new int[n, n];
            int half = (n - 1) / 2;
            int cur = 1;
            int corner = 0;
            for (int i = 0;i <= half;i ++)
            {
                int x = corner, y = corner - 1;
                for(;y < n - corner -1; )
                {
                    y++;
                    matrix[x, y] = cur++;
                }
                
                for (; x < n - corner - 1;)
                {
                    x++;
                    matrix[x, y] = cur++;
                }
                for (; y >= corner + 1;)
                {
                    y --;
                    matrix[x, y] = cur++;
                }

                for (; x >= corner + 2;)
                {
                    x --;
                    matrix[x, y] = cur++;
                }
                corner++;
            }
            return matrix;
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = nums1.Length;
            int k = m - 1;
            for(;k >= 0;)
            {
                nums1[-- i] = nums1[k--];
            }

            k = -1;
            int j = 0;
            for (;i < nums1.Length && j < n;)
            {
                if( nums1[i] > nums2[j])
                {
                    nums1[++ k] = nums2[j++];
                }
                else
                {
                    nums1[++ k] = nums1[i++];
                }
            }
            while(i < nums1.Length)
            {
                nums1[k++] = nums2[i++];
            }
            while(j < n)
            {
                nums1[k++] = nums2[j++];
            }
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            string[] strs1 = new string[strs.Length];
            int i = 0;
            foreach (var s in strs)
            {
                char[] arrC = s.ToArray();
                Array.Sort(arrC);
                string sNew = GetString(arrC);
                strs1[i++] = sNew;
            }
            for(i = 0;i < strs1.Length; i ++)
            {
                if(dic.ContainsKey(strs1[i]))
                {
                    dic[strs1[i]].Add(strs[i]);
                }else
                {
                    IList<string> list = new List<string>();
                    list.Add(strs[i]);
                    dic.Add(strs1[i], list);
                }
            }
            IList<IList<string>> listlist = new List<IList<string>>();
            foreach (var k in dic.Keys)
            {
                listlist.Add(dic[k]);
            }
            return listlist;   
        }
        string GetString(char []arr)
        {
            string s = "";
            for(int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s;
        }
        //foreach (var s in strs)
        //{
        //    var k = FindKey(dic, s);
        //    if (k == null)
        //    {
        //        List<string> list = new List<string>();
        //        list.Add(s);
        //        dic.Add(s, list);
        //    }
        //    else
        //    {
        //        dic[k].Add(s);
        //    }
        //}
        //return dic.Values.ToList();
        //public IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();

        //    foreach(var s in strs)
        //    {
        //        var k = FindKey(dic, s);
        //        if(k == null)
        //        {
        //            List<string> list = new List<string>();
        //            list.Add(s);
        //            dic.Add(s, list);
        //        }else
        //        {
        //            dic[k].Add(s);
        //        }
        //    }
        //    return dic.Values.ToList();
        //}
        //int[] map = new int[26];
        //string FindKey(Dictionary<string, IList<string>> dic,string s)
        //{
        //    SetZero();
        //    foreach (var k in dic.Keys)
        //    {
        //        if (k.Length != s.Length) continue;
        //        for(int i = 0; i < k.Length;i ++)
        //        {
        //            map[(s[i] - 'a')] ++;
        //            map[(k[i] - 'a')]--;

        //        }

        //        if (IsZero(map))
        //        {
        //            return k;
        //        }
        //        SetZero();
        //    }
        //    return null;
        //}
        //void SetZero()
        //{
        //    for (int i = 0; i < 26; i++)
        //    {
        //        map[i] = 0;
        //    }
        //}
        //bool IsZero(int[] map)
        //{
        //    for (int i = 0; i < map.Length; i++)
        //    {
        //        if(map[i] != 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //public int[] FindOrder(int numCourses, int[,] prerequisites)
        //{
        //    hsv = new HashSet<int>();
        //    dicCf = GenerateCFDic(numCourses, prerequisites);
        //    int[] arr = new int[numCourses];
        //    int count = 0; 
        //    foreach (var k in dicCf.Keys)
        //    {
        //        if (!hsv.Contains(k))
        //        {
        //            BfsFO(k, arr,count);
        //        }
        //    }
        //}
        //void BfsFO(int start,int []arr,int count)
        //{
        //    Queue<int> q = new Queue<int>();
        //    q.Enqueue(start);
        //    while(q.Count > 0)
        //    {
        //        int v = q.Dequeue();
        //        IList<int> nexts = null;
        //        if(dicCf.ContainsKey(v))
        //        {
        //            nexts = dicCf[v];
        //        }
        //        List<int> nodeNotAdded = GetNodeNotAdded(nexts, arr, count);
        //        if(nodeNotAdded.Count == 0)
        //        {
        //            arr[count++] = v;
        //        }
        //        foreach(var nx in nodeNotAdded)
        //        {
        //            q.Enqueue(nx);
        //        }
        //    }
        //}
        //List<int> GetNodeNotAdded(IList<int> nodes,int []arr,int count)
        //{
        //    List<int> ans = new List<int>();
        //    if (nodes == null) return ans;

        //    foreach(var nd in nodes)
        //    {
        //        bool bFound = false;
        //        for(int i = 0;i < count;i ++)
        //        {
        //            if(nd == arr[i])
        //            {
        //                bFound = true;
        //                break;
        //            }
        //        }
        //        if()
        //    }
        //}

        //Course Schedule  
        bool foundCycle;
        Dictionary<int, IList<int>> dicCf = new Dictionary<int, IList<int>>();
        HashSet<int> hsv = new HashSet<int>();
        public bool CanFinish(int numCourses, int[,] prerequisites)
        {
            foundCycle = false;

            hsv = new HashSet<int>();
            dicCf = GenerateCFDic(numCourses, prerequisites );
            foreach(var k in dicCf.Keys)
            {
                if(!hsv.Contains(k))
                {
                    DfsCanF(k);
                }
            }

            return !foundCycle;


        }
        void DfsCanF(int start)
        {
            if (foundCycle)
            {
                return;
            }
            hsv.Add(start);
            IList<int> nexts = null;
            if (dicCf.ContainsKey(start))
            {
                nexts = dicCf[start];
            }
            if (nexts != null)
            {
                foreach (var nx in nexts)
                {
                    if (hsv.Contains(nx))
                    {
                        foundCycle = true;
                        return;
                    }
                    else
                    {
                        
                        DfsCanF(nx);
                    }
                }
            }
            hsv.Remove(start);

        }
        Dictionary<int, IList<int>> GenerateCFDic(int numCourses, int[,] prerequisites)
        {
            Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                if(dic.ContainsKey(prerequisites[i,0]))
                {
                    var list = dic[prerequisites[i, 0]];
                    list.Add(prerequisites[i, 1]);
                }else
                {
                    var list = new List<int>();
                    list.Add(prerequisites[i, 1]);
                    dic.Add(prerequisites[i, 0], list);
                }

            }
            return dic;
        }

        void DfsCanF(int[,] pr,int start,HashSet<int> hsVisited, bool[] mark)
        {
            for (int i = 0; i < pr.GetLength(0); i++)
            {
                if (!mark[pr[i, 0]] && pr[i,0] == pr[start,1])
                {
                    if(hsVisited.Contains(i))
                    {

                        return;
                    }
                    mark[pr[i, 0]] = true;
                    DfsCanF(pr,i,hsVisited,mark);
                }
            }
        }
        public int TrailingZeroes(int n)
        {
            long i = 1;
            long ln = n;
            long count = 0;
            i = 5;
            while(i <= ln)
            {
                count += ln / i;
                i *= 5;
            }
            return (int)count;
        }

        //204. Count Primes
        public int CountPrimes(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i ++)
            {
                if(IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        }
        bool IsPrime(int v)
        {
            int sq = (int)Math.Sqrt(v);
            for(int i = 2; i <= sq;i ++ )
            {
                if (v % i == 0) return false;
            }
            return true;
        }

        //Minimum Size Subarray Sum
        public int MinSubArrayLen(int s, int[] nums)
        {
            int curSum = 0;
            int start = 0;
            int i = 0;
            int minL = int.MaxValue;
            while(i < nums.Length)
            {
                if (curSum >= s)
                {
                    if(curSum - nums[start] >= s)
                    {
                        curSum -= nums[start];
                        start ++;
                    }else
                    {
                        minL = Math.Min(i- start,minL);
                        curSum += nums[i];
                        i++;

                    }
                }else
                {
                    curSum += nums[i];
                    i ++;
                    
                }
                
            }
            if(curSum >= s)
            {
                while (start < nums.Length && curSum - nums[start] >= s)
                {
                    curSum -= nums[start];
                    start ++;
                    
                }
                minL = Math.Min(nums.Length - start, minL);
            }
            
            return minL < int.MaxValue ? minL : 0;

        }


        //public int MinSubArrayLen(int s, int[] nums)
        //{
        //    int sumSoFar = 0;
        //    int min= int.MaxValue;
        //    int lenSoFar = 0;

        //    for(int i =0;i < nums.Length;i ++)
        //    {
        //        sumSoFar += nums[i];
        //        lenSoFar++;
        //        if (sumSoFar < s)
        //        {
        //            continue;
        //        }else
        //        {
        //            min = Math.Min(min, GetMin(nums,i,lenSoFar,s, sumSoFar));
        //            sumSoFar = 0;
        //            lenSoFar = 0;
        //        }
        //    }
        //    if (sumSoFar >= s)
        //    {
        //        min = Math.Min(min, GetMin(nums, nums.Length - 1 , lenSoFar,s,sumSoFar));
        //    }
        //    return min < int.MaxValue ? min : 0;
        //}
        int GetMin(int []nums,int i, int len,int s,int sum)
        {
            while(sum - nums[i - len + 1] >= s)
            {
                sum -= nums[i - len + 1];
                len--;
            }
            return len;
        }
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            
            var newHead =  ReverseList(head, head.next);
            head.next = null;
            return newHead;
        }
        public ListNode ReverseList(ListNode pre, ListNode cur)
        {
            ListNode tmp;

            if (cur.next != null)
            {
                tmp = ReverseList(cur, cur.next);
            }
            else
            {
                tmp = cur;
            }
            cur.next = pre;
            return tmp;
        }
        public bool IsIsomorphic(string s, string t)
        {
            int n = s.Length;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            Dictionary<char, char> dic1 = new Dictionary<char, char>();
            for (int i = 0;i < n;i ++)
            {
                if(dic.ContainsKey(s[i]))
                {
                    if(dic[s[i]] != t[i])
                    {
                        return false;
                    }
                }else
                {
                    dic.Add(s[i], t[i]);
                }

                if (dic1.ContainsKey(t[i]))
                {
                    if (dic1[t[i]] != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    dic1.Add(t[i], s[i]);
                }
            }
            return true;
        }

        public int NumIslands(char[,] grid)
        {
            int mR = grid.GetLength(0);
            int mC = grid.GetLength(1);

            bool[,] mark = new bool[mR, mC];
            int num = 0;
            for (int i = 0; i < mR; i++)
            {
                for (int j = 0; j < mC; j++)
                {
                    if (!mark[i, j] && grid[i, j] == '1')
                    {
                        num++;
                        DfsNumIsland(grid, mark, i, j);

                    }
                }
            }
            return num;
        }
        void DfsNumIsland(char[,] grid, bool[,] mark, int i, int j)
        {
            int mR = grid.GetLength(0);
            int mC = grid.GetLength(1);
            int[][] cors = new int[][] { new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            for (int k = 0; k < cors.Length; k++)
            {
                int x = i + cors[k][0];
                int y = j + cors[k][1];
                if ( x>= 0 && x < mR && y >= 0 && y < mC)
                {
                    if(grid[x,y] == '1' && !mark[x,y])
                    {
                        mark[x, y] = true;
                        DfsNumIsland(grid, mark, x, y);
                    }
                }
            }
        }
        //public IList<IList<int>> PermuteUnique(int[] nums)
        //{
        //    Array.Sort(nums);
        //    IList<IList<int>> list = new List<IList<int>>();
        //    List<int> listNums = new List<int>();
        //    foreach (var num in listNums) {
        //        listNums.Add(num);
        //    } 
        //    PermuteUnique(listNums, 0, list);
        //    return list;
        //}
        //public void PermuteUnique(List<int> nums,int start, IList<IList<int>> result)
        //{
        //    if(start == nums.Count )
        //    {
        //        int[] list = new int[nums.Count];
        //        int j = 0;
        //        foreach (var t in nums) list[j++] = t;
        //        result.Add(list);
        //        return;
        //    }
        //    for(int i = start; i < nums.Count; i ++)
        //    {
        //        if (i > start && nums[i] == nums[i - 1]) {
        //            continue;
        //        } 
        //        nums.Insert(start, nums[i]);
        //        nums.RemoveAt(i + 1);
        //        PermuteUnique(nums, start + 1, result);
        //        nums.Insert(i + 1, nums[start]);
        //        nums.RemoveAt(start);
        //    }
        //}
        //void Move(int[] num, int j, int i)
        //{
        //    num.insert(num.begin() + i + (i > j), num[j]);
        //    num.erase(num.begin() + j + (j > i));
        //}

        
        bool IsBadVersion(int version)
        {
            return version >= 10;
        }
        public int FirstBadVersion(int n)
        {
            int i = 1;
            int j = n;

            while(i <= j)
            {
                int m = (j - i) / 2 + i;
                if(IsBadVersion(m))
                {
                    j = m - 1;
                }else
                {
                    i = m + 1;
                }
            }
            return j + 1;

        }

        public int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            if (n == 0) return 0;
            int[] dp = new int[n];
            dp[0] = 1;
            int max = 1;
            for(int i = 1;i < n;i ++)
            {
                dp[i] = 1;
                for(int j = 0;j < i;j ++)
                {
                    if(nums[i] > nums[j])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
        public int Calculate(string s)
        {
            int start = s.Length;
            int n = s.Length;
            Stack<int> stack = new Stack<int>();
            char op = '+';

            for (int i = 0; i < s.Length; i++)
            {

                if (start == n && Char.IsNumber(s[i]))
                {
                    start = i;
                }
                if (start < n && Char.IsNumber(s[i]) && (i + 1 == n || !Char.IsNumber(s[i + 1])))
                {
                    int num = int.Parse(s.Substring(start, i - start + 1));
                    start = n;
                    if(op == '*')
                    {
                        stack.Push(stack.Pop() * num);
                    }else if (op == '/')
                    {
                        stack.Push(stack.Pop() / num);
                    }
                    else if (op == '-')
                    {
                        stack.Push(-num);
                    }
                    else if (op == '+')
                    {
                        stack.Push(num);
                    }
                }
                if(s[i] == '*' || s[i] == '/' || s[i] == '+' || s[i] == '-')
                {
                    op = s[i];
                }
                
            }
            int ans = 0;
            while(stack.Count > 0)
            {
                ans += stack.Pop();
            }
            return ans;
        }

        //public int Calculate(string s)
        //{
        //    List<string> postFixS = InfixToPostfix(s);
        //    Stack<int> stackOperands = new Stack<int>();

        //    foreach (var s1 in postFixS)
        //    {
        //        if (s1.Length == 1 && IsOperatorChar(s1[0]))
        //        {
        //            var o1 = stackOperands.Pop();
        //            var o2 = stackOperands.Pop();
        //            var result = Calculate(o2, o1, s1[0]);
        //            stackOperands.Push(result);
        //        }
        //        else
        //        {
        //            stackOperands.Push(int.Parse(s1));
        //        }
        //    }
        //    return stackOperands.Pop();
        //}

        int Calculate(int o1,int o2, char c)
        {
            if(c == '+')
            {
                return o1 + o2;
            }else if (c == '-')
            {
                return o1 - o2;
            }
            if (c == '*')
            {
                return o1 * o2;
            }
            if (c == '/')
            {
                return o1 / o2;
            }
            return 0;
        }
        List<string> InfixToPostfix(string s)
        {
            int start = s.Length;
            int n = s.Length;
            List<string> ans = new List<string>();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (IsOperatorChar(s[i]))
                {
                    while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(s[i]))
                    {
                        ans.Add(stack.Pop() + "");
                    }
                    stack.Push(s[i]);

                }
                if (start == n && Char.IsNumber(s[i]))
                {
                    start = i;
                }
                if (start < n && Char.IsNumber(s[i]) && (i + 1 == n || !Char.IsNumber(s[i + 1])))
                {
                    ans.Add(s.Substring(start, i - start + 1));
                    start = n;
                }
            }
            while (stack.Count > 0)
            {
                ans.Add(stack.Pop() + "");
            }
            return ans;
        }
        int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
            }
            return 0;

        }
        bool IsOperatorChar(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/') ? true : false;
        }

        //Stack<string> InfixToPostfix(string s)
        //{
        //    int start = s.Length;
        //    int n = s.Length;
        //    Stack<string> ans = new Stack<string>();
        //    Stack<char> stack = new Stack<char>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if(IsOperatorChar(s[i]))
        //        {
        //            while(stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(s[i]))
        //            {
        //                ans.Push(stack.Pop() + "");
        //            }
        //            stack.Push(s[i]);

        //        }
        //        if (start == n && Char.IsNumber(s[i]))
        //        {
        //            start = i;
        //        }
        //        if (start < n && Char.IsNumber(s[i]) && (i + 1 == n || !Char.IsNumber(s[i + 1])))
        //        {
        //            ans.Push(s.Substring(start, i - start + 1));
        //            start = n;
        //        }
        //    }
        //    while(stack.Count > 0)
        //    {
        //        ans.Push(stack.Pop() + "");
        //    }
        //    return ans;
        //}

        //227. Basic Calculator II
        //public int Calculate(string s)
        //{
        //    int start = s.Length;
        //    int n = s.Length;
        //    char lastOpt = ' ';
        //    int lastNumber;
        //    for(int i = 0;i < s.Length;i ++)
        //    {

        //        if(start == n && Char.IsNumber(s[i]) )
        //        {
        //            start = i;
        //        }
        //        if(IsOperator2(s[i]))
        //        {
        //            lastOpt = s[i];
        //        }

        //        //end of number
        //        if(start < n &&  Char.IsNumber(s[i]) && (i + 1 == n || Char.IsNumber(s[i + 1])))
        //        {
        //            int curN = int.Parse(s.Substring(start, i - start + 1));
        //            if(lastOpt == '*' || lastOpt == '/')
        //            {
        //                lastNumber = Calculate(lastNumber, curN, lastOpt);
        //            }else if(lastOpt == '+' || lastOpt == '-')
        //            {
        //                s1.Push(lastNumber);
        //                s1.Push(curN);
        //                s2.Push(lastOpt);
        //            }
        //        }

        //    }

        //    while(!s1.Empty() && !s2.Empty())
        //    {

        //        int opr = s1.Pop(); 

        //        while (s2.Top() == '*' || s2.Top() == '/')
        //        {
        //            var opt = s2.Pop();
        //            var opr1 = s1.Pop();
        //            var opr2 = s1.Pop();

        //        }
        //    }
        //}

        public int MissingNumber(int[] nums)
        {
            long total = 0;
            for(int i = 0;i < nums.Length;i ++)
            {
                total += nums[i];
            }
            long l = (long)nums.Length;
            long ans = l * (l + 1) / 2 - total;
            return (int)ans;

        }
        public void MoveZeroes(int[] nums)
        {
            int zeroPos = -1;
            int lastNonZero = 0;
            for(int i = 0;i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    Swap(nums, i, lastNonZero);
                    lastNonZero++;
                }
            }
        }
        

        //2^n = n
        public bool IsPowerOfTwo(int n)
        {
            long p2 = 1;
            while(p2< n)
            {
                p2 = p2 << 1;
            }
            return p2 == n;
        }

        public int CountNodes(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            int countOnLeft = CountOnLeft(root);
            int countOnRight = CountOnRight(root);

            if(countOnLeft == countOnRight)
            {
                return (1 << countOnLeft) - 1;
            }else
            {
                return 1 + CountNodes(root.left) + CountNodes(root.right);
            }
            
        }
        int CountOnLeft(TreeNode root)
        {
            int count = 0;
            while(root != null)
            {
                count++;
                root = root.left;
            }
            return count;
        }
        int CountOnRight(TreeNode root)
        {
            int count = 0;
            while (root != null)
            {
                count++;
                root = root.right;
            }
            return count;
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if(root == null)
            {
                return null;
            }
            if(root == p || root == q)
            {
                return root;
            }
            TreeNode l = LowestCommonAncestor(root.left, p, q);
            TreeNode r = LowestCommonAncestor(root.right, p, q);
            if(l != null && r != null)
            {
                return root;
            }else if( l== null && r == null)
            {
                return null;
            }else if(l != null)
            {
                return l;
            }
            else //r != null
            {
                return r;
            }
        }

        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    int countLeft = CountDescendant(root.left, p, q);
        //    int countRight = CountDescendant(root.right, p, q);
        //    if (countLeft == 1 && countRight == 1)
        //    {
        //        return root;
        //    }
        //    if(countLeft == 2)
        //    {
        //        return LowestCommonAncestor(root.left, p, q);
        //    }
        //    if (countRight == 2)
        //    {
        //        return LowestCommonAncestor(root.right, p, q);
        //    }
        //    if((countLeft == 1 || countRight == 1)  && (root == p || root == q) )
        //    {
        //        return root;
        //    }
        //    return null;
        //}


        //int countDes;
        //int CountDescendant(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    countDes = 0;
        //    DfsCountDes(root, p, q);
        //    return countDes;
        //}
        //void DfsCountDes(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null) return;
        //    if (root == p || root == q) {
        //        countDes ++;
        //    }

        //    DfsCountDes(root.left, p, q);
        //    DfsCountDes(root.right, p, q);
        //}


        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    bool bLeft = IsDescendant(root.left, p, q);
        //    bool bRight = IsDescendant(root.right, p, q);
        //    if (bLeft && bRight)
        //    {
        //        return root;
        //    }
        //    if (bLeft)
        //    {
        //        return LowestCommonAncestor(root.left, p, q);
        //    }
        //    if (bRight)
        //    {
        //        return LowestCommonAncestor(root.right, p, q);
        //    }
        //    return null;
        //}
        //bool IsDescendant(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null) return false;
        //    if (root == p || root == q) return true;

        //    return IsDescendant(root.left, p, q) || IsDescendant(root.right, p, q);

        //}

        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            if(H > D)
            {
                int tmp = A;
                A = E;
                E = tmp;

                tmp = B;
                B = F;
                F = tmp;

                tmp = C;
                C = G;
                G = tmp;

                tmp = D;
                D = H;
                H = tmp;
            }
            int maxL = Math.Max(A,E);
            int minR = Math.Min(C,G);
            int maxB = Math.Max(F,B);
            int minT = H;
            int total = (C - A) * (D - B) + (G - E) * (H - F);
            int overlap = 0;
            if(maxL < minR && maxB < minT)
            {
                overlap = (minR - maxL) * (minT - maxB);
            }
            return total -  overlap;


        }

        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            for(int i = 2;i <= n; i++)
            {
                int minN = int.MaxValue;
                int sq = (int)Math.Sqrt(i);
                for(int j = 1; j <= sq; j ++)
                {
                    minN = Math.Min(dp[i - j * j] + 1, minN);
                    if (i - j * j == 0) break;

                }
                dp[i] = minN;
            }
            return dp[n];
        }

        public int MaximalSquare(char[,] matrix)
        {
            int M = matrix.GetLength(0);
            int N = matrix.GetLength(1);
            int maxS = 0;
            int[,] dp = new int[M, N];

            
            for (int i = 0;i < M;i ++)
            {
                for(int j = 0;j < N; j++)
                {
                    if(matrix[i,j] != '0')
                    {
                        if(i ==0 || j == 0)
                        {
                            dp[i, j] = 1;
                            maxS = Math.Max(1,maxS);
                            continue;
                        }
                        dp[i, j] = Min3(dp[i - 1, j - 1], dp[i, j - 1], dp[i -1, j]) + 1;
                    }
                    
                    if(maxS < dp[i, j])
                    {
                        maxS = dp[i, j];
                    } 
                }
            }
            return maxS* maxS;
        }
        int Min3(int a,int b,int c)
        {
            if (a > b) a = b;
            if (a > c) a = c;
            return a;
        }

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (t < 0) return false;

            Dictionary<long, long> bucket = new Dictionary<long, long>();
            long w = (long)t + 1;
            for (int i = 0; i < nums.Length; i++)
            {
                long bi = GetDistance(nums[i] , int.MinValue) / w;

                if (bucket.ContainsKey(bi) || (bucket.ContainsKey(bi - 1) && nums[i] - bucket[bi - 1] <= t) || 
                    (bucket.ContainsKey(bi + 1) &&  bucket[bi + 1] - nums[i] <=t))
                {
                    return true;
                }

                bucket.Add(bi,nums[i]);
                if(i >= k)
                {
                    bucket.Remove(GetDistance(nums[i - k],int.MinValue)/w );
                }
                
            }
            return false;
        }
        long GetDistance(int v1,int min)
        {
            return (long)v1 - (long)min;
        }
        void UpdateRangeInfor(RangeInfor cur,int v)
        {
            cur.Count++;
            cur.Min = Math.Min(cur.Min, v);
            cur.Max = Math.Min(cur.Max, v);
        }

        //public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        //{
        //    int minL = Math.Min(nums.Length, k);
        //    for(int i = 1;i < nums.Length;i ++)
        //    {
        //        for(int j = i - 1; j >= 0 && i - j <= minL;j --)
        //        {
        //            if(Math.Abs((long)nums[i] - (long)nums[j]) <= t)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}


        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i = 0;i < nums.Length;i ++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    if(i - dic[nums[i]] <= k)
                    {
                        return true;
                    }
                    dic[nums[i]] = i;
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }
            return false;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i = 0;i < nums.Length;i ++)
            {
                if(hs.Contains(nums[i]))
                {
                    return true;
                }
                hs.Add(nums[i]);
            }
            return false;
        }
        public int[] SingleNumber(int[] nums)
        {
            int A = 0;
            int B = 0;
            int C = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                C ^= nums[i];
            }

            C = GetFirstBitDifferent(C); //find the different bit  
            for (int i = 0; i < nums.Length; i++)
            {
                if ((C & nums[i]) == 0)
                    A ^= nums[i];
                else
                    B ^= nums[i];
            }
            return new int[] { A, B };
        }
        int GetFirstBitDifferent(int a)
        {
            int ans = 1;
            
            while(a != 0)
            {
                int bit = a & 0x1;
                if(bit != 0)
                {
                    return ans;
                }
                ans = (ans << 1);
                a = a >> 1;
            }
            return 0;
        }

        //public int[] SingleNumber(int[] nums)
        //{
        //    int c = nums[0];
        //    for(int i = 1;i < nums.Length; i++)
        //    {
        //        c ^= nums[i];
        //    }

        //}
        public IList<int> DiffWaysToCompute(string input)
        {
            List<int> list = new List<int>();
            bool foundOperator = false;
            for(int i = 0;i < input.Length; i ++)
            {
                char c = input[i];
                if(!IsOperator(c))
                {
                    continue;
                }
                foundOperator = true;
                var leftList = DiffWaysToCompute(input.Substring(0, i));
                var rightList = DiffWaysToCompute(input.Substring(i + 1, input.Length - i - 1));
                for(int j = 0; j < leftList.Count; j ++ )
                {
                    for (int k = 0; k < rightList.Count; k++)
                    {
                        int result = Calculate(leftList[j],rightList[k],c);
                        list.Add(result);
                    }
                }

            }
            if(!foundOperator)
            {
                int v = int.Parse(input);
                list.Add(v);
            }
            return list;
        }
        bool IsOperator(char c)
        {
            return (c == '+' || c == '-' || c == '*') ? true : false;
        }
        int Calculate(int num1, int num2, int opt)
        {
            if(opt == '+')
            {
                return num1 + num2;
            }else if (opt == '-')
            {
                return num1 - num2;
            }
            else if (opt == '*')
            {
                return num1 * num2;
            }
            return 0;
        }

        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null) return false;
            int M = matrix.GetLength(0);
            int N = matrix.GetLength(1);
            int i = 0;
            int j = N - 1;
            

            while(i < M && j >= 0)
            {
                if(matrix[i,j] == target)
                {
                    return true;
                }else if(matrix[i, j] > target)
                {
                    j--;
                }else
                {
                    i++;
                }
                
            }
            return false;
        }

        

        //public int CompareVersion(string version1, string version2)
        //{
        //    var v1Values = CalculateVersion(version1);
        //    var v2Values = CalculateVersion(version2);
        //    int i = 0;
        //    for (; i < Math.Min(v1Values.Count, v2Values.Count); i++)
        //    {
        //        if (v1Values[i] < v2Values[i])
        //        {
        //            return -1;
        //        }
        //        else if (v1Values[i] > v2Values[i])
        //        {
        //            return 1;
        //        }
        //    }
        //    if (i < v1Values.Count)
        //    {
        //        return 1;
        //    }
        //    else if (i < v2Values.Count)
        //    {
        //        return -1;
        //    }
        //    return 0;
        //}
        //long CalculateVersion(string v)
        //{
        //    int i = 0;
        //    int num = 0;
        //    int ans = 0;
        //    for (i = 0; i <= v.Length; i++)
        //    {
        //        if (i == v.Length || v[i] == '.')
        //        {
        //            ans = ans*10 + num;
        //            continue;
        //        }
        //        else
        //        {
        //            num = num * 10 + (v[i] - '0');
        //        }

        //    }
        //    return list;
        //}
        public bool IsUgly(int num)
        {
            if (num == 0) return false;
            if (num == 1) return true;
            if(num % 2 == 0)
            {
                return IsUgly(num / 2);
            }
            if (num % 3 == 0)
            {
                return IsUgly(num / 3);
            }
            if (num % 5 == 0)
            {
                return IsUgly(num / 5);
            }
            return false;
        }
        public int AddDigits(int num)
        {
            if (num == 0) return 0;
            if (num % 9 == 0) return 9;
            return num % 9;

        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode pre = dummy;
            while(pre != null && pre.next != null)
            {
                if(pre.next.val == val)
                {
                    pre.next = pre.next.next;
                }else
                {
                    pre = pre.next;
                }
                
            }
            return dummy.next;
        }
        int digitSquareSum(int n)
        {
            int sum = 0, tmp;
            while (n > 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }

        public bool IsHappy(int n)
        {
            int slow, fast;
            slow = fast = n;
            do
            {
                slow = digitSquareSum(slow);
                fast = digitSquareSum(fast);
                fast = digitSquareSum(fast);
            } while (slow != fast);
            if (slow == 1) return true;
            else return false;
        }

        public int CompareVersion(string version1, string version2)
        {
            var v1Values = CalculateVersion(version1);
            var v2Values = CalculateVersion(version2);
            int i = 0;
            for (; i < Math.Min(v1Values.Count, v2Values.Count); i++)
            {
                if (v1Values[i] < v2Values[i])
                {
                    return -1;
                }
                else if (v1Values[i] > v2Values[i])
                {
                    return 1;
                }
            }
            if (i < v1Values.Count)
            {

                return Evaluate(v1Values, i);
            }
            else if (i < v2Values.Count)
            {
                return -Evaluate(v2Values, i);
            }
            return 0;
        }
        int Evaluate(IList<int> list,int start)
        {
            for (int i = start; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    return 1;
                }
            }
            return 0;
        }
        IList<int> CalculateVersion(string v)
        {
            IList<int> list = new List<int>();
            int i = 0;
            int num = 0;
            for (i = 0; i <= v.Length; i++)
            {
                if (i == v.Length || v[i] == '.')
                {
                    list.Add(num);
                    num = 0;
                    continue;
                }
                else
                {
                    num = num * 10 + (v[i] - '0');
                }

            }
            return list;
        }

        

        int minIR;
        public int IntegerReplacement(int n)
        {
            minIR = int.MaxValue;
            IntegerReplacementRecursive(n, 0);
            return minIR;
        }
        void IntegerReplacementRecursive(long n, int step)
        {
            if(n == 1)
            {
                if (step < minIR)
                    minIR = step;
                return;
            }
            if(n%2 == 0)
            {
                IntegerReplacementRecursive(n/2, step + 1);
            }else
            {
                IntegerReplacementRecursive(n -1, step + 1);
                IntegerReplacementRecursive(n + 1, step + 1);
            }
        }

        public int MaxRotateFunction(int[] A)
        {
            if (A.Length == 0) return 0;
            int max = int.MinValue;
            int sum = 0;
            int cur = 0;
            for (int i = 0;i < A.Length;i ++)
            {
                sum += A[i];
                cur += i * A[i];
            }
            max = cur;

            for (int k = 0;k < A.Length - 1;k ++)
            {
                cur -= sum;
                cur += A[k] * A.Length;
                max = Math.Max(max, cur);
            }
            return max;
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            uint one = 1;
            while(n > 0)
            {
                if ((n & one) != 0) count++;

                n = n >> 1;
            }
            return count;
        }

        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;

            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            q1.Enqueue(root);
            while(q1.Count > 0)
            {
                TreeNode cur = q1.Dequeue();
                if(cur.left != null)
                {
                    q2.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    q2.Enqueue(cur.right);
                }
                if(q1.Count == 0)
                {

                    list.Add(cur.val);
                    Queue<TreeNode> tmp = q1;
                    q1 = q2;
                    q2 = tmp;
                }
            }
            return list;
        }

        
        public int CalculateMinimumHP(int[,] dungeon)
        {
            int nR = dungeon.GetLength(0);
            int nC = dungeon.GetLength(1);
            int[,] dp = new int[nR + 1, nC + 1];

            for (int i = 0; i < nR + 1; i ++)
            {
                for (int j = 0; j < nC + 1; j ++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[nR, nC - 1] = 1;
            dp[nR - 1, nC] = 1;
            for (int i = nR - 1; i >= 0; i--)
            {
                for (int j = nC - 1; j >= 0; j--)
                {
                    int need = Math.Min(dp[i + 1, j], dp[i, j + 1]) - dungeon[i, j];
                    dp[i, j] = need <= 0 ? 1 : need;

                }
            }

            return dp[0, 0];
        }

        //for(int i = 1; i < nR;i ++)
        //{
        //    dp[i, 0] = dp[i - 1, 0] - dungeon[i,0];
        //    dp[i, 0] = Math.Max(dp[i, 0], 1);
        //}
        //for (int j = 1; j < nC; j++)
        //{
        //    dp[0, j] = dp[0, j - 1] - dungeon[0, j];
        //    dp[0, j] = Math.Max(dp[0, j], 1);
        //}
        //return dp[nR - 1, nC - 1] > 1 ? 1 : dp[nR - 1, nC - 1];
        public string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while(n > 0)
            {
                n--;
                char c = (char)(n % 26 + 'A');
                sb.Insert(0,c);
                n /= 26;
            }
            return sb.ToString();
        }
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                Swap(sb, i, j);
                i++;
                j--;
            }
            return sb.ToString();
        }

        public int FindPeakElement(int[] num)
        {
            return helper(num, 0, num.Length - 1);
        }

        public int helper(int[] num, int start, int end)
        {
            if (start == end)
            {
                return start;
            }
            else if (start + 1 == end)
            {
                if (num[start] > num[end]) return start;
                return end;
            }
            else {

                int m = (start + end) / 2;

                if (num[m] > num[m - 1] && num[m] > num[m + 1])
                {

                    return m;

                }
                else if (num[m - 1] > num[m] && num[m] > num[m + 1])
                {

                    return helper(num, start, m - 1);

                }
                else {

                    return helper(num, m + 1, end);

                }

            }
        }

        //public int FindPeakElement(int[] nums)
        //{
        //    int n = nums.Length;
        //    for(int i = 0; i < n; i ++)
        //    {
                
        //        if ((i == 0 || nums[i] > nums[i - 1]) && (i == n-1 || nums[i] > nums[i + 1]))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        public string ReverseVowels(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int i = 0, j = s.Length - 1;

            while(i < j)
            {
                if(!IsVowel(sb[i]))
                {
                    i++;
                    continue;
                }

                if (!IsVowel(sb[j]))
                {
                    j--;
                    continue;
                }
                Swap(sb, i, j);
                i++;
                j--;
            }
            return sb.ToString();

        }
        bool IsVowel(char c)
        {
            c = Char.ToLower(c);
            if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'a' || c == 'u')
                return true;
            return false;
        }
        void Swap(StringBuilder sb, int i, int j)
        {
            char tmp = sb[i];
            sb[i] = sb[j];
            sb[j] = tmp;
        }

        public string LargestNumber(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i - 1 ; j >= 0;j --)
                {
                    if(Compare(nums[j],nums[j+1]) > 0)
                    {
                        Swap(nums, j, j + 1);
                    }
                }
            }
            string ans = "";
            for(int i = nums.Length - 1; i >= 0; i --)
            {
                if(ans == "" && nums[i] == 0)
                {
                    continue;
                }
                var v = nums[i];
                ans += v.ToString();
            }
            return ans == "" ? "0" : ans;
        }

        int Compare(int a, int b)
        {
            string s1 = a + "" + b;
            string s2 = b + "" + a;
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] > s2[i])
                {
                    return 1;
                }else if (s1[i] < s2[i])
                {
                    return -1;
                }
            }
            return 0;

            
        }
        
        int[] intBuff1 = new int[15];
        int[] intBuff2 = new int[15];
        //int countA = 0,countB = 0;
        //while(a > 0)
        //{
        //    intBuff1[countA++] = a % 10;
        //    a /= 10;
        //}
        //while (b > 0)
        //{
        //    intBuff2[countB++] = b % 10;
        //    b /= 10;
        //}



        //int i = countA - 1;
        //int j = countB - 1;
        //while(i >= 0 && j >= 0)
        //{
        //    if(intBuff1[i] > intBuff2[j])
        //    {
        //        return 1;
        //    }else if (intBuff1[i] < intBuff2[j])
        //    {
        //        return -1;
        //    }
        //    i--;
        //    j--;
        //}
        //if (i < 0 && j < 0) return 0;

        //if(i >=0)
        //{
        //    return intBuff1[i] > intBuff1[i + 1] ? 1 : 0;
        //}

        //return intBuff2[j] > intBuff2[j + 1] ? 1 : 0;
        
        public uint reverseBits(uint n)
        {
            uint ans = 0;
            int i = 0;
            while (i < 32)
            {
                uint d = n % 2;
                ans = ans * 2 + d;
                n = n >> 1;
                i++;
            }
            return ans;
        }
        //public uint reverseBits(uint n)
        //{
        //    uint ans = 0;
        //    while(n > 0)
        //    {
        //        uint d = n % 2;
        //        ans = ans * 2 + d;
        //        n = n >> 1;
        //    }
        //    return ans;
        //}

        //160. Intersection of Two Linked Lists
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            int nA = 0;
            int nB = 0;
            ListNode cur = headA;
            while (cur != null)
            {
                nA++;
                cur = cur.next;
            }
            cur = headB;
            while (cur != null)
            {
                nB++;
                cur = cur.next;
            }
            if (nB < nA)
            {
                int tmp = nA;
                nA = nB;
                nB = tmp;

                ListNode tmpNode = headA;
                headA = headB;
                headB = tmpNode;
            }
            int i = 0;
            while(i < nB - nA)
            {
                headB = headB.next;
                i++;
            }
            while(headA != null && headA != headB)
            {
                headB = headB.next;
                headA = headA.next;
            }
            return headA == null || headA != headB ? null : headA;


        }
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] arr = new int[k];
            for (int i = 0; i < k; i++)
            {
                arr[i] = nums[nums.Length - k + i];
            }
            for (int i = nums.Length - 1; i >= k; i --)
            {
                nums[i] = nums[i - k];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = arr[i];
            }
        }

        //public void Rotate(int[] nums, int k)
        //{
        //    k = k % nums.Length;
        //    for (int i = 0; i < k; i++)
        //    {
        //        int start = i;
        //        int tmp = nums[nums.Length - 1];
        //        for (int j = nums.Length - 1; j > start; j--)
        //        {
        //            nums[j] = nums[j - 1];
        //        }
        //        for (int j = start; j > 0; j--)
        //        {
        //            nums[j] = nums[j - 1];
        //        }
        //        nums[0] = tmp;
        //    }
        //}



        //169. Majority Element
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(var n in nums)
            {
                int count = 0;
                if (dic.ContainsKey(n))
                {
                    dic[n]++;
                    count = dic[n];
                }
                else
                {
                    count = 1;
                    dic.Add(n, 1);
                }
                if (count > nums.Length / 2)
                {
                    return n;
                }

            }
            return 0;
        }

        //public string LargestNumber(int[] nums)
        //{

        //}

        //public int TrailingZeroes(int n)
        //{

        //}

        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            for(;i < j;)
            {
                if(numbers[i] + numbers[j] > target)
                {
                    j--;
                }else if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }else
                {
                    i++;
                }
            }
            return new int[] { -1, -1 };
        }

        //public string ConvertToTitle(int n)
        //{

        //}

        public int MaxProduct(int[] nums)
        {
            int maxP = nums[0];
            int dpMax = nums[0];
            int dpMin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int tmp = dpMax;
                dpMax = Math.Max(nums[i], dpMax * nums[i]);
                dpMax = Math.Max(dpMax, dpMin * nums[i]);

                dpMin = Math.Min(nums[i], dpMin * nums[i]);
                dpMin = Math.Min(dpMin, tmp * nums[i]);

                maxP = Math.Max(maxP, dpMax);
            }
            return maxP;
        }

        //213. House Robber II
        public int Rob(int[] nums)
        {
            return 1;
        }

        //Kth Largest Element in an Array: need to solve by selective algorithm
        public int FindKthLargest(int[] nums, int k)
        {
            if (k > nums.Length) return 0;
            Array.Sort(nums);
            return nums[nums.Length-k];

        }

        //public ListNode InsertionSortList(ListNode head)
        //{
        //    ListNode dummy = new ListNode(0);

        //    while (head != null)
        //    {
        //        ListNode node = dummy;
        //        while (node.next != null && node.next.val < head.val)
        //        {
        //            node = node.next;
        //        }
        //        ListNode temp = head.next;
        //        head.next = node.next;
        //        node.next = head;
        //        head = temp;
        //    }

        //    return dummy.next;
        //}

        //public ListNode InsertionSortList(ListNode head)
        //{
        //    if (head == null) return head;
        //    ListNode dummy = new ListNode(0);
        //    while (head != null)
        //    {
        //        ListNode cur = dummy;
        //        while (cur.next != end)
        //        {
        //            if (cur.next.val > end.val)
        //            {
        //                ListNode tmp = cur.next.next;
        //                cur.next.next = end.next;
        //                end.next = tmp;

        //                //ListNode tmp = cur.next.next;
        //                //cur.next.next = end.next;
        //                //cur.next = end;
        //                //end.next = tmp;
        //                //break;

        //            }
        //            cur = cur.next;
        //        }

        //        end = end.next;
        //    }
        //    return dummy.next;
        //}
        void Swap(ListNode n1, ListNode n2)
        {
            int tmp = n1.val;
            n1.val = n2.val;
            n2.val = tmp;
        }
        //public ListNode InsertionSortList(ListNode head)
        //{
        //    ListNode start = head;
        //    while (start != null && start.next != null)
        //    {
        //        ListNode cur = start.next;
        //        ListNode minN = start;
        //        while (cur != null)
        //        {
        //            if(cur.val < minN.val)
        //            {
        //                minN = cur;
        //            }
        //            cur = cur.next;
        //        }
        //        int tmp = start.val;
        //        start.val = minN.val;
        //        minN.val = tmp;

        //        start = start.next;
        //    }
        //    return head;
        //}

        int minMt = 0;
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0) return 0;
            minMt = int.MaxValue;
            MinimumTotal(triangle, 0,0,0);
            return minMt;
        }
        void MinimumTotal(IList<IList<int>> triangle, int row, int cur, int sum)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            stack.Push(cur);
            while(stack.Count > 0)
            {
                cur = stack.Pop();
                stack.Push(cur);
                stack.Push(cur+ 1);
            }

            int v = triangle[row][cur];
            if (row == triangle.Count - 1)
            {
                if (sum + v < minMt)
                {
                    minMt = sum + v;
                }
                return;
            }
            int[] nexts = new int[] { cur, cur + 1 };
            for (int i = 0; i < nexts.Length; i++)
            {
                MinimumTotal(triangle, row + 1, nexts[i], sum + v);
            }
        }

        //void MinimumTotal(IList<IList<int>> triangle,int row,int cur,int sum)
        //{
        //    int v = triangle[row][cur];
        //    if(row == triangle.Count - 1)
        //    {
        //        if(sum + v < minMt)
        //        {
        //            minMt = sum + v;
        //        }
        //        return;
        //    }
        //    int[] nexts = new int[] { cur,cur + 1};
        //    for(int i = 0; i < nexts.Length;i ++)
        //    {
        //        MinimumTotal(triangle, row + 1, nexts[i],sum + v);
        //    }
        //}

        IList<IList<int>> pathSumAns;
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            
            pathSumAns = new List<IList<int>>();
            if (root == null)
                return pathSumAns;
            IList<int> list = new List<int>();
            PathSumDfs(root, sum, list);
            return pathSumAns;
        }
        void PathSumDfs(TreeNode root, int sum,IList<int> list)
        {
            if(root.left == null && root.right == null && root.val == sum)
            {
                List<int> newList = new List<int>();
                newList.AddRange(list);
                pathSumAns.Add(newList);
                newList.Add(root.val);
                return;
            }
            if(root.left != null)
            {
                int index = list.Count;
                list.Add(root.val);
                PathSumDfs(root.left,sum- root.val,list);
                list.RemoveAt(index);
            }
            if (root.right != null)
            {
                int index = list.Count;
                list.Add(root.val);
                PathSumDfs(root.right, sum - root.val, list);
                list.RemoveAt(index);
            }
        }

        //77. Combinations
        //public IList<IList<int>> Combine(int n, int k)
        //{
        //    IList<IList<int>> list = new List<IList<int>>();
        //    Combine(n, k, 0, list);
        //    return list;
        //}
        //void Combine(int n, int k,int start, IList<IList<int>> list )
        //{
        //    for(int i = start; i < n - k;i ++)
        //    {
                
        //    }
        //}
        public int ArrangeCoins(int n)
        {

            int k = 1;
            while(n >= k)
            {
                n -= k;
                k++;
            }
            return  k - 1;
        }
        //437. Path Sum III
        //public int PathSum(TreeNode root, int sum)
        //{
        //    int countP = 0;
        //    if (root == null) return 0;

        //    countP += TrarvelDfs(root, sum);
        //    if(root.left != null)
        //        countP += PathSum(root.left, sum);
        //    if (root.right != null)
        //        countP += PathSum(root.right, sum);
        //    return countP;
        //}
        int TrarvelDfs(TreeNode root, int sum)
        {
            int countP = 0;
            if(root.val == sum)
            {
                countP++;
            }
            if(root.left != null)
            {
                countP += TrarvelDfs(root.left, sum - root.val);
            }
            if (root.right != null)
            {
                countP += TrarvelDfs(root.right, sum - root.val);
            }
            return countP;

        }

        //Pascal's Triangle II
        public IList<int> GetRow(int rowIndex)
        {
            
            if (rowIndex == 0 ) return new int[] { 1 };
            int len = rowIndex + 1;
            int[] arr = new int[len];
            arr[0] = 1; arr[1] = 1;
            for(int i = 2;i <= rowIndex;i ++)
            {
                int pre = 1;
                for(int j = 1;j < i ;j ++)
                {
                    int tmp = arr[j];
                    arr[j] = pre + arr[j];
                    pre = tmp;
                }
                arr[i] = 1;
            }
            return arr;
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if(root != null)
                PreOrderDfs(root,list);
            return list;
        }
        private void PreOrderDfs(TreeNode root, List<int> list)
        {
            list.Add(root.val);
            if(root.left != null)
            {
                PreOrderDfs(root.left,list);
            }
            if (root.right != null)
            {
                PreOrderDfs(root.right, list);
            }
        }

        ListNode CreateList(int []arr)
        {
            ListNode head = new ListNode(arr[0]);
            ListNode cur = head;
            for(int i = 1;i < arr.Length;i ++)
            {
                cur.next = new ListNode(arr[i]);
                cur = cur.next;
            }
            return head;
        }

        public ListNode ReorderList1(ListNode head)
        {
            ListNode cur = head;
            while (cur != null && cur.next != null && cur.next.next != null)
            {
                ListNode next = cur.next;
                ListNode preLast = cur.next;
                ListNode last = cur.next.next;
                while(last.next != null)
                {
                    preLast = preLast.next;
                    last = last.next;
                }
                cur.next = last;
                last.next = next;
                preLast.next = null;

                cur = next;
            }
            return head;
        }

        // need to work on O(n)
        //128. Longest Consecutive Sequence
        public int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            int max = 1;
            int count = 1;
            for(int i = 1;i < nums.Length; i++)
            {
                if(nums[i] == nums[i - 1])
                {
                    continue;
                }
                if (nums[i] == nums[i - 1] + 1)
                {
                    count++;
                }else
                {
                    max = Math.Max(count, max);
                    count = 1;
                }
            }
            max = Math.Max(count, max);
            return max;
        }

        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length- 1;
            while(i < j)
            {
                if(!IsChar(s[i]) )
                {
                    i++;
                    continue;
                }
                if(!IsChar(s[j]))
                {
                    j--;
                    continue;
                }
                if(Char.ToLower(s[i]) == Char.ToLower(s[j]))
                {
                    i++;
                    j--;
                }else
                {
                    return false;
                }
            }
            return true;
        }

        bool IsChar(char c)
        {
            c = Char.ToLower(c);
            if(c >= 'a' && c <= 'z')
            {
                return true;
            }else if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;
            ListNode slow = head;
            ListNode fast = head.next;

            // Search for loop using slow and fast pointers
            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                    break;
                slow = slow.next;
                fast = fast.next.next;
            }

            /* If loop exists */
            if (slow == fast)
            {
                slow = head;
                while (slow != fast.next)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                /* since fast->next is the looping point */
                return fast.next; /* remove loop */
            }else
            {
                return null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
                
            }
            return true;
        }

        //102. Binary Tree Level Order Traversal
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (root == null) return ans;
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            TreeNode current = root;
            q1.Enqueue(current);

            List<int> sameLevelList = new List<int>();
            while (q1.Count > 0)
            {
                current = q1.Dequeue();
                sameLevelList.Add(current.val);
                if(current.left != null)
                {
                    q2.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    q2.Enqueue(current.right);
                }

                if (q1.Count == 0)
                {
                    ans.Add(sameLevelList);
                    sameLevelList = new List<int>();

                    q1 = q2;
                    q2 = new Queue<TreeNode>();
                }
            }
            return ans;
        }
        //127. Word Ladder
        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            return BfsLadder(beginWord, endWord, wordList);
        }

        int BfsLadder(string current, string endWord, ISet<string> wordList)
        {
            HashSet<string> hsLadder = new HashSet<string>();

            Queue<string> q1 = new Queue<string>();
            Queue<string> q2 = new Queue<string>();
            q1.Enqueue(current);
            int depth = 1;
            hsLadder.Add(current);
            while (q1.Count > 0)
            {
                current = q1.Dequeue();
                
                if (current == endWord)
                {
                    return depth;
                }else if (DifferentOne( current,endWord))
                {
                    return depth + 1;
                }


                for (int i = 0; i < current.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(current);
                    for (char c = 'a'; c < 'z'; c++)
                    {
                        if (c == current[i]) continue;

                        sb[i] = c;
                        string w = sb.ToString();
                        if (wordList.Contains(w))
                        {
                            if (!hsLadder.Contains(w))
                            {
                                hsLadder.Add(w);
                                q2.Enqueue(w);
                            }
                        }
                    }
                }
                if(q1.Count == 0)
                {
                    depth++;
                    q1 = q2;
                    q2 = new Queue<string>();
                }

            }
            return 0;
        }

        bool DifferentOne(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    count++;
                }
            }
            return count == 1;
        }


        //void BfsLadder(string current, string endWord, ISet<string> wordList)
        //{
        //    //if (minLengthLadder < int.MaxValue) return;
        //    if(current == endWord )
        //    {
        //        minLengthLadder = Math.Min(minLengthLadder, hsLadder.Count);
        //        return;
        //    }
        //    if (DifferentOne(current, endWord))
        //    {
        //        minLengthLadder = Math.Min(minLengthLadder, hsLadder.Count + 1 );
        //        return;
        //    }
        //    foreach (var w in wordList)
        //    {
        //        if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w) && DifferentOne(w, current))
        //        {
        //            hsLadder.Add(w);
        //            DfsLadder(w, endWord, wordList);
        //            hsLadder.Remove(w);
        //        }
        //    }


        //    //for(int i = 0;i < current.Length;i ++)
        //    //{
        //    //    StringBuilder sb = new StringBuilder(current);
        //    //    for (char c = 'a'; c < 'z'; c++)
        //    //    {
        //    //        if (c == current[i]) continue;

        //    //        sb[i] = c;
        //    //        string w = sb.ToString();
        //    //        if(wordList.Contains(w))
        //    //        {
        //    //            if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w))
        //    //            {
        //    //                hsLadder.Add(w);
        //    //                BfsLadder(w, endWord, wordList);
        //    //                hsLadder.Remove(w);
        //    //            }
        //    //        }
        //    //    }
        //    //}

        //    //foreach (var w in wordList)
        //    //{
        //    //    if (hsLadder.Count < minLengthLadder && !hsLadder.Contains(w) && DifferentOne(w, current))
        //    //    {
        //    //        hsLadder.Add(w);
        //    //        DfsLadder(w, endWord, wordList);
        //    //        hsLadder.Remove(w);
        //    //    }
        //    //}

        //}


        //public bool WordPattern(string pattern, string str)
        //{
        //    int n = 26;
        //    string[] allWords = new string[n];
        //    int[] allPatternCount = new int[n]; 
        //    int start = -1;

        //    Dictionary<char, string> dic = new Dictionary<char, string>();
        //    int wordCount = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (start == -1 && str[i] != ' ')
        //        {
        //            start = i;
        //        }
        //        if (start >= 0 && str[i] != ' ' && (i == str.Length - 1 || str[i + 1] == ' '))
        //        {
        //            string word = str.Substring(start, i - start + 1);


        //            if (pattern.Length < wordCount + 1)
        //            {
        //                return false;
        //            }
        //            int index = pattern[wordCount] - 'a';

        //            if (allPatternCount[index] > 0 )
        //            {
        //                if(allWords[index] != word)
        //                {
        //                    return false;
        //                }
        //                else
        //                {

        //                }
        //            }else
        //            {
        //                allPatternCount[index]++;
        //                allWords[index] = word;
        //            }

        //            for (int j = 0; j < n; j++)
        //            {
        //                if (j != index && allWords[j] == word)
        //                    return false;
        //            }


        //            wordCount++;

        //            start = -1;
        //        }
        //    }
        //    if (wordCount != pattern.Length) return false;
        //    return true;

        //}
        public bool WordPattern(string pattern, string str)
        {
            int start = -1;
            List<string> words = new List<string>();
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dicInverse = new Dictionary<string, char>();
            int wordCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (start == -1 && str[i] != ' ')
                {
                    start = i;
                }
                if (start >= 0 && str[i] != ' ' && (i == str.Length - 1 || str[i + 1] == ' '))
                {
                    string word = str.Substring(start, i - start + 1);
                    if (pattern.Length < wordCount + 1)
                    {
                        return false;
                    }
                    if (!dic.ContainsKey(pattern[wordCount]))
                    {
                        dic.Add(pattern[wordCount], word);
                    }
                    else
                    {
                        if (dic[pattern[wordCount]] != word)
                        {
                            return false;
                        }
                    }
                    if (!dicInverse.ContainsKey(word))
                    {
                        dicInverse.Add(word,pattern[wordCount]);
                    }
                    else
                    {
                        if (dicInverse[word] != pattern[wordCount])
                        {
                            return false;
                        }
                    }

                    wordCount++;

                    start = -1;
                }
            }
            if (wordCount != pattern.Length) return false;
            return true;

        }

        //Length of Last Word
        public int LengthOfLastWord(string s)
        {
            int start = -1;
            for (int i = s.Length - 1; i >= 0 ; i --)
            {
                if(start == -1 && s[i] != ' ')
                {
                    start = i;
                }
                if(start > -1 && (i == 0 || s[i - 1] == ' ' ) )
                {
                    return start - i + 1;
                }
            }
            return 0;
        }

        //Reverse Words in a String
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            ReverseString(sb, 0, s.Length - 1);

            int n = sb.Length;
            int start = n;
            char spc = ' ';
            for(int i = 0;i < sb.Length; i++)
            {
                if(start == n && sb[i] != spc)
                {
                    start = i;
                }

                if (start < n && (i == sb.Length - 1 || sb[i + 1] == spc))
                {
                    ReverseString(sb, start, i);
                    start = n;
                }

            }
            int newLen = ShiftBlank(sb);
            return sb.ToString().Substring(0,newLen);
        }
        void ReverseString(StringBuilder str,int start,int end)
        {
            while(start < end)
            {
                char c = str[start];
                str[start] = str[end];
                str[end] = c;
                start++;
                end--;
            }
        }

        int ShiftBlank(StringBuilder str)
        {
            if (str.Length < 1) return 0;
            char spc = ' ';
            int shift = str[0] == spc ? 1 : 0;
            int last = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if(( i + 1 < str.Length && str[i] == spc && str[i + 1] == spc))
                {
                    shift++;
                }
                if(str[i] != spc)
                {
                    last = i - shift;
                    str[i - shift] = str[i];
                    if(last != i)
                        str[i] = spc;
                }
            }
            return last + 1;
        }

        //https://roy3221.gitbooks.io/algorithms/content/CH5%20DP/leetcode_139_word_break.html
        public bool WordBreak(string s, ISet<string> wordDict)
        {
            int n = s.Length;
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for(int i = 1;i <= s.Length;i ++)
            {
                foreach(var w in wordDict)
                {
                    if(IsTail(w,s,i - 1))
                    {
                        if (dp[i - w.Length])
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }
            }
            return dp[n ];
        }
        bool IsTail(string w,string s,int end)
        {
            int len = s.Length;
            if (w.Length > end + 1) return false;
            for(int i = w.Length - 1; i >= 0; i --)
            {
                if (w[i] != s[end - (w.Length - 1 - i)]) return false;
            }
            return true;
        }


        //139. Word Break
        bool bFoundWB = false;
        TrieNode originalRoot = null;
        Trie trie;
        public bool WordBreak1(string s, ISet<string> wordDict)
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
         
            if(root.HasEnd)
            {
                DfsWord(originalRoot, s, index);
            }
            foreach(var n in root.Children)
            {
                if(n.Val == s[index])
                {
                    DfsWord(n, s, index + 1);
                }
            }
            
        }

        //https://leetcode.com/problems/word-break/

        
        

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
