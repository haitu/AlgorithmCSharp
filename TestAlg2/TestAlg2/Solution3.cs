using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class Solution3
    {
        static void Main(string[] args)
        {
            Solution3 pro = new Solution3();
            pro.test();
        }
        void test()
        {
            int mx = LengthLongestPath("abc\n\tabcd.h");
            mx = LengthLongestPath("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext");
            mx = LengthLongestPath("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext");

            var sps = SimplifyPath("/home/");
            sps = SimplifyPath("/a/./b/../../c/");
            sps = SimplifyPath("/../");
            sps = SimplifyPath("/home//foo/");



            int mR = FindRadius(new int[] { 1, 2, 3 }, new int[] { 2});

            mR = FindRadius(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 });

            mR = FindRadius(new int[] { 8,10,11,18 }, new int[] { 1, 4 });

            var tvp = ValidIPAddress("172.16.254.1");

            tvp = ValidIPAddress("2001:0db8:85a3:0000:0000:8a2e:0370:7334");

            tvp = ValidIPAddress("2001:db8:85a3:0:0:8A2E:0370:7334");
            tvp = ValidIPAddress("2001:0db8:85a3::8A2E:0370:7334");

            tvp = ValidIPAddress("2001:0db8:85a3:00000:0:8A2E:0370:7334");

            mR = FindRadius(new int[]{ 1,10},new int[]{ 1,11});

            mR = FindRadius(new int[] { 1, 10 ,20}, new int[] { 1, 11,18 });

            mR = FindRadius(new int[] { 1, 10, 1000 }, new int[] { 1, 11, 18,998 });

            mR = FindRadius(new int[] { 1, 10, 1000 }, new int[] { 1, 11,17, 18, 998 });

            mR = FindRadius(new int[] { 1, 10, 11 }, new int[] { 20,21,22});

            mR = FindRadius(new int[] { 1, 10, 11 }, new int[] { 1, 10, 11,12 });

            var rv = RemoveKdigits("1432219", 3);
            rv = RemoveKdigits("10", 1);
            rv = RemoveKdigits("10200", 1);
            rv = RemoveKdigits("112", 1);
            rv = RemoveKdigits("222222222222222222222210", 12);

            string str = ToHex(26);
            str = ToHex(-1);

            var crb = CanCross(new int[] { 0, 1, 3, 5, 6, 8, 12, 17 });
            crb = CanCross(new int[] { 0, 1, 2, 3, 4, 8, 9, 11 });

            crb = CanCross(new int[] { 0, 1, 3, 6, 7 });

            var fmhs = FindMinHeightTrees(4,new int[,]{ { 1, 0}, { 1, 2}, { 1, 3} });

            fmhs = FindMinHeightTrees(6, new int[,] { { 0, 3 }, { 1, 3 }, { 2, 3 }, { 4, 3 }, { 5, 4 } });
            fmhs = FindMinHeightTrees(1, new int[,] { });

            var bcstr = GetHint("1807", "7810");
            bcstr = GetHint("1123", "0111");
            bcstr = GetHint("11", "10");
            bcstr = GetHint("1122", "2211");
            bcstr = GetHint("1234", "0111");

            //string s12 = "123".Substring(0, 5);

            var bdn = IsAdditiveNumber("112358");
            bdn = IsAdditiveNumber("199100199");
            bdn = IsAdditiveNumber("1023");
            bdn = IsAdditiveNumber("101");

            var mpr = MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" });
            mpr = MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" });
            mpr = MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" });

            var sb = IsValid("()");
            sb = IsValid("()[]{}");
            sb = IsValid("(]");
            sb = IsValid("([)]");

            uint ui = 2147483648;
            ui = (ui - 1);

            var listLC = LetterCombinations("23");
            listLC = LetterCombinations("");

            var mt = new int[,] { { 0, 1 }, { 2, 3 } };
            Rotate(mt);
            mt = new int[,] { { 0, 1,2 }, { 3, 4,5 }, { 6, 7, 8 } };
            Rotate(mt);

            var bFO = FindOrder(2, new int[,] { { 1, 0 } });
            bFO = FindOrder(4, new int[,] { { 1, 0 }, { 2, 0 }, { 3, 1 }, { 3, 2 } });

            

            bFO = FindOrder(2, new int[,] { { 0, 1 }, { 1, 0 } });
            bFO = FindOrder(4, new int[,] { { 0, 1 }, { 1, 2 }, { 2, 3 } });
            bFO = FindOrder(10, new int[,] { { 5, 6 }, { 0, 2 }, { 1, 7 }, { 5, 9 }, { 1, 8 }, { 3, 4 }, { 0, 6 }, { 0, 7 }, { 0, 3 }, { 8, 9 } });
            bFO = FindOrder(8, new int[,] { { 1, 0 }, { 2, 6 }, { 1, 7 }, { 6, 4 }, { 7, 0 }, { 0, 5 } });

            int tn = TitleToNumber("Z");
            tn = TitleToNumber("AB");
            tn = TitleToNumber("BA");
            var rt = new TreeUtility().CreateTree(new int?[] { 1,2,4,null,3,null,null});
            var listN = new TreeUtility().ConvertTreeToArray(rt);

            Dictionary<UndirectedGraphNode, UndirectedGraphNode> dicCloneTest = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            dicCloneTest.Add(new UndirectedGraphNode(0),new UndirectedGraphNode(0));
            dicCloneTest.Add(new UndirectedGraphNode(0), new UndirectedGraphNode(0));

            int indexR = SearchIndex(new int[] {1,2,3,4,-1,0 });

            indexR = SearchIndex(new int[] { 1, 2, 3, 4,5, -2, -1,0 });
            var r = Search(new int[] { 1},0);
            r = Search(new int[] { 1 }, 1);
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            FindMedianSortedArrays(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1);
        }
        public void FindMedianSortedArrays(int[] nums1, int[] nums2,int l1,int r1,int l2,int r2)
        {
            while(r2 - l2 > 1 && r1 - l1 > 1)
            {
                int m2 = (r2 - l2) / 2;
                int m1 = (r1 - l1) / 2; 
                if(nums1[m1] < nums2[m2])
                {

                }
            }
        }

        public int Search(int[] nums, int target)
        {
            int index = SearchIndex(nums);
            int bsL = BinarySearch(nums,0,index - 1, target);
            if(bsL >= 0)
            {
                return bsL;
            }
            bsL = BinarySearch(nums, index, nums.Length - 1, target);
            if (bsL >= 0)
            {
                return bsL;
            }
            return -1;
        }
        int BinarySearch(int []a,int l, int r, int target)
        {
            while(l <= r)
            {
                int m = (r - l) / 2 + l;
                if(target == a[m])
                {
                    return m;
                }else if (target < a[m])
                {
                    r = m - 1;
                }else
                {
                    l = m + 1;
                }
            }
            return -1;
        }
        int SearchIndex(int []a)
        {
            int l = 0, r = a.Length - 1;
            while(r - l  > 2)
            {
                int m = (r - l) / 2 + l;
                if(a[m- 1] < a[m] && a[m] < a[m + 1])
                {
                    if(a[m] > a[r])
                    {
                        l = m ;
                    }
                    else
                    {
                        r = m;
                    }
                }else
                {
                    return FindIndex(a, m -1, m + 1);
                }
            }
            return FindIndex(a, l, r);

        }
        int FindIndex(int []a,int l, int r)
        {
            if(r - l == 1)
            {
                if (a[r] > a[l])
                    return l;
                else
                    return r;
            }
            if(r - l == 2)
            {
                if(a[l] < a[l + 1] && a[l + 1] < a[r])
                {
                    return r < a.Length - 1 ? r + 1 : 0;
                }
                else if(a[l] > a[l + 1] && a[l + 1] > a[r])
                {
                    return l > 0 ? l - 1 : 0;
                }else  if(a[l] < a[l + 1] && a[l + 1] > a[r])
                {
                    return r;
                }
                else if (a[l] > a[l + 1] && a[l + 1] < a[r])
                {
                    return l  + 1;
                }
            }
            return l;
        }
        Dictionary<UndirectedGraphNode, UndirectedGraphNode> dicClone = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if(node == null)
            {
                return null;
            }
            dicClone = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            UndirectedGraphNode dummy = new UndirectedGraphNode(-1);
            CloneGraph(node, dummy);
            return dummy.neighbors[0];
        }
        void CloneGraph(UndirectedGraphNode root, UndirectedGraphNode newParent)
        {
            if(dicClone.ContainsKey(root))
            {
                newParent.neighbors.Add(dicClone[root]);
                return;
            }
            UndirectedGraphNode newNode = new UndirectedGraphNode(root.label);
            dicClone.Add(root, newNode);
            newParent.neighbors.Add(newNode);
            foreach (var c in root.neighbors)
            {
                CloneGraph(c, newNode);
            }
        }
        public int StrStr(string haystack, string needle)
        {
            for(int i = 0; i <= haystack.Length - needle.Length;i ++)
            {
                if (CheckSame(haystack, i, needle))
                {
                    return i;
                }
            }
            return -1;
        }
        bool CheckSame(string s1,int i, string s2)
        {
            for(int j =0;j < s2.Length; j++)
            {
                if(s1[i + j] != s2[j])
                {
                    return false;
                }
            }
            return true;
        }


        //public IList<IList<int>> CombinationSum3(int k, int n)
        //{

        //}

        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return Math.Max(nums[0],nums[1]);
            }
            return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));

        }
        int Rob(int[] nums, int start,int end)
        {
            int[] dp = new int[nums.Length];
            dp[start] = nums[start];
            for(int i = start + 1; i <= end;i ++)
            {
                int v2 = 0;
                if(i - 2 >= start)
                {
                    v2 = dp[i - 2];
                }
                dp[i] = Math.Max(dp[i-1], v2 + nums[i]);
            }
            return dp[end];
        }
        public int TitleToNumber(string s)
        {
            int ans = 0;
            int t = 1;
            
            for(int i = s.Length - 1; i >= 0;i --)
            {

                ans =ans + t *(s[i] - 'A' + 1)  ;
                t *= 26;
            }
            
            return ans;
        }

        //public ListNode SortList(ListNode head)
        //{

        //}
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            MoveToEnd(nums1, m);
            int i = nums1.Length - m;
            int j = 0;
            int k = 0;
            while(i < nums1.Length && j < n)
            {
                if(nums1[i] <= nums2[j])
                {
                    nums1[k++] = nums1[i ++];
                }else
                {
                    nums1[k++] = nums2[j++];
                }
            }
            while(i < nums1.Length)
            {
                nums1[k++] = nums1[i++];
            }
            while(j < n)
            {
                nums1[k++] = nums2[j++];
            }
        }
        void MoveToEnd(int[] nums1, int m)
        {
            int i = nums1.Length - 1;
            while(m > 0)
            {
                nums1[i--] = nums1[--m];
            }
        }

        bool[] markToRemove;
        Dictionary<int, List<int>> _dicFO = new Dictionary<int, List<int>>(); 
        public int[] FindOrder(int numCourses, int[,] prerequisites)
        {
            markToRemove = new bool[numCourses];
            _dicFO =  GetDic(prerequisites);
            IList<int> ans = new List<int>();
            Dictionary<int, int> visited = new Dictionary<int, int>();

            if (DetectCycle(numCourses))
            {
                return new int[] { };
            }
            while (ans.Count < numCourses)
            {
                for(int i = 0; i < markToRemove.Length; i++)
                {
                    if(!markToRemove[i])
                    {
                        
                        GetLeaves(i, ans);
                    }
                }
                
            }
            return ans.ToArray();
        }
        Dictionary<int, List<int>> GetDic(int[,] prerequisites)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for(int i = 0;i < prerequisites.GetLength(0);i ++)
            {
                if (!dic.ContainsKey(prerequisites[i,0]))
                {
                    dic.Add(prerequisites[i, 0], new List<int>() { prerequisites[i, 1] });
                }else
                {
                    dic[prerequisites[i, 0]].Add(prerequisites[i, 1]);
                }
            }
            return dic;

        }
        Dictionary<int, HashSet<int>> visited = new Dictionary<int, HashSet<int>>();
        bool GetLeaves(int start, IList<int> result)
        {

            List<int> listNexts = GetNextKeyNotInList(start);
            if(listNexts.Count == 0)
            {
                result.Add(start);
                markToRemove[start] = true;
                return true;
            }
            bool bResult = false;
            foreach(var nx in listNexts)
            {
                if(!markToRemove[nx])
                {
                    bResult = bResult || GetLeaves(nx, result);
                }
            }
            return bResult;
        }
        bool DetectCycle(int n)
        {
            // Initialize color of all vertices as WHITE
            int []color = new int[n];

            // Do a DFS traversal beginning with all
            // vertices
            for (int i = 0; i < n; i++)
                if (color[i] == 0)
                    if (DFSUtil(i, color) == true)
                        return true;

            return false;
        }
        bool DFSUtil(int u, int[] color)
        {
            // GRAY :  This vertex is being processed (DFS
            //         for this vertex has started, but not
            //         ended (or this vertex is in function
            //         call stack)
            color[u] = 1;//GRAY

            if (_dicFO.ContainsKey(u))
            {
                foreach (var i in _dicFO[u])
                {
                    int v = i;  // An adjacent of u

                    // If there is
                    if (color[v] == 1)//GRAY
                        return true;

                    // If v is not processed and there is a back
                    // edge in subtree rooted with v
                    if (color[v] == 0 && DFSUtil(v, color))
                        return true;
                }
            }
                

            // Mark this vertex as processed
            color[u] = 2;//BLACK
            return false;
        }
            
            bool AddToHashSet(int start,int next)
        {
            if (visited.ContainsKey(start) && visited[start].Contains(next))
            {
                return false;
            }
            else
            {
                if (visited.ContainsKey(start))
                {
                    visited[start].Add(next);
                }
                else
                {
                    visited.Add(start, new HashSet<int>() { next });
                }
            }
            return true;
        }
        
        List<int> GetNextKeyNotInList(int start)
        {
            List<int> list = new List<int>();
            if(!_dicFO.ContainsKey(start))
            {
                return list;
            }
            foreach(var nx in _dicFO[start])
            {
                if(!markToRemove[nx])
                {
                    list.Add(nx);
                }
            }
            return list;
        }
        /// end
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int l = 0;
            int r = matrix.Length - 1;
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            while (l <= r)
            {
                int mid = (r - l) / 2 + l;
                int x = mid / n;
                int y = mid % n;
                if (matrix[x, y] == target)
                {
                    return true;
                } else if (matrix[x, y] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return false;
        }

        public bool IsValidSudoku(char[,] board)
        {
            int n = 9;
            bool[] mark = new bool[n];
            for (int i = 0;i < n;i ++)
            {
                Reset(mark);
                for (int j = 0;j < n;j ++)
                {
                    if(board[i,j] != '.' )
                    {
                        if(mark[board[i, j] - '1'])
                        {
                            return false;
                        }else
                        {
                            mark[board[i, j] - '1'] = true;
                        }
                    }
                }
            }
            for (int j = 0; j < n; j++)
            {
                Reset(mark);
                for (int i = 0; i < n; i++)
                {
                    if (board[i, j] != '.')
                    {
                        if (mark[board[i, j] - '1'])
                        {
                            return false;
                        }
                        else
                        {
                            mark[board[i, j] - '1'] = true;
                        }
                    }
                }
            }
            for(int k = 0;k < 9;k ++)
            {
                int x = k / 3;
                x *= 3;
                int y = k % 3;
                y *= 3;
                //x,y are origin
                Reset(mark);
                for (int i = 0; i < 3;i ++)
                {
                    for(int j = 0;j < 3;j ++)
                    {
                        char c = board[x + i, y + j];
                        if (c != '.')
                        {
                            if (mark[c - '1'])
                            {
                                return false;
                            }
                            else
                            {
                                mark[c - '1'] = true;
                            }
                        }
                    }
                }
            }
            return true;
        }
        void Reset(bool[] mark)
        {
            for(int i = 0;i < 9;i ++)
            {
                mark[i] = false;
            }
        }

        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int half = (n - 1) / 2;
            for(int i = 0;i <= half; i++)
            {
                for(int j = i; j < n-  i - 1;j ++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = matrix[n - i -1, n - j - 1];
                    matrix[n - i - 1, n - j - 1] = matrix[j, n - i - 1];
                    matrix[j, n - i - 1] = tmp;
                }
            }
        }

        char[][] dicLC;
        public IList<string> LetterCombinations(string digits)
        {
            
            dicLC = new char[10][];
            dicLC[2] = new char[] { 'a', 'b', 'c', };
            dicLC[3] = new char[] { 'd', 'e', 'f', };
            dicLC[4] = new char[] { 'g', 'h', 'i', };
            dicLC[5] = new char[] { 'j', 'k', 'l', };
            dicLC[6] = new char[] { 'm', 'n', 'o', };
            dicLC[7] = new char[] { 'p', 'q', 'r', 's'};
            dicLC[8] = new char[] { 't', 'u', 'v', };
            dicLC[9] = new char[] { 'w', 'x', 'y','z' };

            IList<string> list = new List<string>();
            if (digits.Length == 0)
            {
                return list;
            }
            string str="";
            LetterCombinations(digits, 0, str, list);
            return list;
        }
        void LetterCombinations(string digits,int start,string curS, IList<string> listResult)
        {
            if(start == digits.Length)
            {
                listResult.Add(curS);
                return;
            }
            var list = dicLC[digits[start] - '0'];
            foreach(var c in list)
            {
                LetterCombinations(digits, start + 1, curS + c, listResult);
            }
        }


        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            long ans = 0;
            int i = 0;
            bool negative = false;
            bool firstChar = false;

            for (; i < str.Length; i++)
            {
                if (str[i] != ' ') break;
            }
            int j = str.Length - 1;
            for (; j >= 0; j--)
            {
                if (str[j] != ' ') break;
            }

            for (; i <= j; i++)
            {
                uint digit = (uint)(str[i] - '0');
                if (!(digit >= 0 && digit <= 9))
                {
                    if (!firstChar)
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
                if(ans >= 2147483648)
                {
                    break;
                }
            }
            if (!negative && ans >= 2147483648)
            {
                ans = 2147483647;
            }
            else if (negative && ans >= 2147483649)
            {
                ans = 2147483648;
            }
            return negative ? (int)-ans : (int)ans;
        }

        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            for(int i = 0; i < s.Length;i ++)
            {
                char c = s[i];
                if(c == '(' || c == '{' || c == '[')
                {
                    st.Push(c);
                }
                else
                {
                    if (st.Count == 0) return false;
                    char top = st.Pop();
                    if((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return st.Count == 0;
        }

        public int MaxProduct(string[] words)
        {
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            int max = 0;
            int j = words.Length - 1, i = j - 1;
            int minI = 0;
            while(i >= 0 && i < j)
            {
                if(i >= minI && !IsCommon(words[i],words[j]))
                {

                    max = Math.Max(max, words[i].Length * words[j].Length);
                    minI = i;
                    j--;
                    i = j - 1;
                    if (j > 0 && words[i].Length * words[j].Length < max)
                    {
                        return max;
                    }
                }
                else if(i >= minI)
                {
                    i--;
                }
                if(i < minI)
                {
                    j--;
                    i = j -1;
                }

            }
            return max;
        }
        bool[] markC = new bool[26];
        bool IsCommon(string s1,string s2)
        {
            for(int i =0;i < 26;i ++)
            {
                markC[i] = false;
            }
            for(int i = 0;i < s1.Length;i ++)
            {
                markC[s1[i] - 'a'] = true;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if(markC[s2[i] - 'a'])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsAdditiveNumber(string num)
        {
            

            for(int i = 0;i < num.Length-2; i++)
            {
                for(int j = i + 1;j < num.Length - 1; j++)
                {
                    string s1 = num.Substring(0, i + 1);
                    string s2 = num.Substring(i + 1, j - i );
                    if((s1[0] == '0' && s1.Length > 1) || (s2[0] == '0' && s2.Length > 1))
                    {
                        continue;
                    }
                    if(CheckAdd(s1,s2, j + 1,num))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool CheckAdd(string str1,string str2,int i, string num)
        {
            string sum = Add(str1, str2);
            if(i + sum.Length > num.Length)
            {
                return false;
            }
            string next = num.Substring(i, sum.Length);
            if(sum == next)
            {
                if(i + sum.Length == num.Length)
                {
                    return true;
                }else
                {
                    return CheckAdd(str2, sum, i + sum.Length, num);

                }
            }
            return false;
        }
        string Add(string s1,string s2)
        {
            string ans = "";
            int carry = 0;
            int sum = 0;
            for(int i = s1.Length - 1,j = s2.Length - 1; i >= 0 || j >= 0; i --,j--  )
            {
                if(i >= 0 && j >=0 )
                {
                    sum = (s1[i] - '0') + (s2[j] - '0') + carry;
                }
                else if(i >= 0)
                {
                    sum = (s1[i] - '0') + carry;
                }else
                {
                    sum = (s2[j] - '0') + carry;
                }
                var d = sum % 10;
                carry = sum / 10;
                ans = d + ans;
            }
            if(carry > 0)
            {
                ans = carry + ans;
            }
            return ans.TrimStart('0');
        }

        public string GetHint(string secret, string guess)
        {
            int[] mark = new int[10];
            StringBuilder sb = new StringBuilder(guess);
            int bulls = 0;
            int cows = 0;
            for (int i = 0;i < secret.Length;i ++)
            {
                if(secret[i] == guess[i])
                {
                    bulls++;
                    sb[i] = ' ';
                }
                else
                {

                    mark[secret[i] - '0'] ++;
                }
            }
            for (int i = 0; i < guess.Length; i++)
            {
                if(sb[i] != ' ' && mark[guess[i] - '0'] > 0)
                {
                    cows++;
                    mark[guess[i] - '0']--;
                }
            }
            return bulls + "A" + cows + "B";


        }

        //shoud do in place
        public void GameOfLife(int[,] board)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);
            if (m == 0 || n == 0) return;
            int[,] mt = new int[m, n];
            for(int i = 0;i < m;i ++)
            {
                for(int j = 0;j < n;j ++)
                {
                    mt[i, j] = board[i, j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int cl = CountLive(mt, i, j);
                    if (mt[i, j] == 1)
                    {
                        if(cl < 2)
                        {
                            board[i, j] = 0;
                        }else if( cl > 3)
                        {
                            board[i, j] = 0;
                        }
                    } else
                    {
                        if(cl == 3)
                        {
                            board[i, j] = 1;
                        }
                    }
                }
            }
        }
        int[,] _neibors8 = new int[,] { { -1,-1}, { 0,-1}, {1,-1 }, { -1,0}, {1,0 }, {-1,1 }, {0,1 }, {1,1 } };
        int CountLive(int[,] board, int i, int  j)
        {
            int countL = 0;
            for(int k = 0;k < _neibors8.GetLength(0);k ++)
            {
                int x = i + _neibors8[k, 0];
                int y = j + _neibors8[k, 1];
                if(x >= 0 && y >= 0 && x < board.GetLength(0) && y < board.GetLength(1))
                {
                    if(board[x,y] == 1)
                    {
                        countL++;
                    }
                }
            }
            return countL;
        }
        public IList<int> FindMinHeightTrees(int n, int[,] edges)
        {

            List<HashSet<int>> graph = new List<HashSet<int>>(n);
            for(int i = 0;i < n;i ++)
            {
                graph.Add(new HashSet<int>());
            }
            for(int i = 0;i < edges.GetLength(0);i ++)
            {
                graph[edges[i, 0]].Add(edges[i, 1]);
                graph[edges[i, 1]].Add(edges[i, 0]);
            }
            List<int> leaves = new List<int>();

            if (n == 1)
            {
                return new int[] { 0 };
            }
            for (int i = 0; i < n; i++)
            {
                if(graph[i].Count == 1 )
                {
                    leaves.Add(i);
                }
            }

            while(n > 2)
            {
                n = n - leaves.Count;
                List<int> newLeaves = new List<int>();
                foreach (var l in leaves)
                {
                    var neibor = graph[l].First();
                    graph[neibor].Remove(l);
                    graph[l].Remove(l);
                    if(graph[neibor].Count == 1)
                    {
                        newLeaves.Add(neibor);
                    }
                }
                leaves =  newLeaves;
                
            }
            return leaves;

        }

        //https://discuss.leetcode.com/topic/59439/straight-forward-9ms-7-line-c-solution-with-explanation/2
        //revist
        Dictionary<int,bool> dpCR;
        public bool CanCross(int[] stones)
        {
            dpCR = new Dictionary<int, bool>();
            return CanCross(stones, 0,0);
        }
        bool CanCross(int[] stones, int k, int curPos)
        {
            int key = curPos | (k << 11);
            if(dpCR.ContainsKey(key))
            {
                return dpCR[key];
            }

            for (int i = curPos + 1; i < stones.Length; i++)
            {
                int diff = stones[i] - stones[curPos];
                if(diff < k - 1)
                {
                    continue;
                }
                if (diff > k + 1)
                {
                    dpCR[key] = false;
                    return false;
                }


                if (CanCross(stones, diff, i))
                {
                    dpCR[key] = true;
                    return true;
                }
            }
            dpCR[key] = true;
            return curPos == stones.Length - 1;
        }

        //bool CanCross(int[] stones,int k,int cur)
        //{
        //    if (cur == stones.Length - 1) return true;


        //    for(int i = cur + 1; i < stones.Length; i ++)
        //    {
        //        int diff = stones[i] - stones[cur];
        //        if (diff > k + 1) break;

        //        if (diff  == k -1 || diff == k || diff == k + 1)
        //        {
        //            dpCR[cur]
        //            if (CanCross(stones,diff,i))
        //            {
        //                dpCR[i] = true;
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        public string ToHex(int num)
        {
            if (num == 0) return "0";
            uint ui = (uint)(num >= 0 ? num : -num);
            if(num < 0)
            {
                ui = ~ui;
                ui++;
            }
            string str = "";
            for(int i = 0;i < 8;i ++)
            {
                uint v = ui & 0xf;
                char c = ' ';
                if(v < 10)
                {
                    c = (char)('0' + v);
                }else
                {
                    c = (char)('a' + (v - 10));
                }
                str = c + str;
                ui = ui >> 4;
            }
            return str.TrimStart('0');
        }

        public int LongestPalindrome(string s)
        {
            int max = 0;
            int[] mark = new int[52];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(c >= 'a' && c <= 'z')
                {
                    mark[c - 'a']++;
                }else
                {
                    mark[c - 'A' + 26]++;
                }
            }
            bool bOdd = false;
            for(int i = 0;i < 52; i++)
            {
                if (mark[i] % 2 == 1)
                {
                    max += mark[i] - 1;
                    bOdd = true;
                }
                else
                {
                    max += mark[i];
                }
            }
            return bOdd ? max + 1: max;
        }

        //public int LongestPalindrome(string s)
        //{
        //    int max = 1;
        //    for(int i = 1;i < s.Length - 1; i ++)
        //    {
        //        max = Math.Max(max,GetPL(s,i,i));
        //        if(s[i] == s[i + 1])
        //            max = Math.Max(max, GetPL(s, i, i + 1));
        //    }
        //    return max;
        //}
        //int GetPL(string s, int i, int j)
        //{
        //    while(i>= 0 && j < s.Length)
        //    {
        //        if(i - 1 >= 0 && j + 1 < s.Length && s[i - 1] == s[j + 1])
        //        {
        //            i--;
        //            j++;
        //        }else
        //        {
        //            break;
        //        }
        //    }
        //    return j - i + 1;
        //}

        public int FirstUniqChar(string s)
        {
            int[] mark = new int[26];
            foreach(var c in s)
            {
                mark[(c - 'a')]++;
            }
            for(int i = 0;i < s.Length; i ++)
            {
                if (mark[(s[i] - 'a')] == 1) return i;
            }
            return -1;
        }

        public string RemoveKdigits(string num, int k)
        {
            if (k == 0) return num.ToString();
            if (k >= num.Length) return "0";
            var str= RemoveKdigits(new StringBuilder(num), num.Length,k);
            str = str.TrimStart('0');
            if(str == "") return "0";

            return str;
        }
        public string RemoveKdigits(StringBuilder num,int len, int k)
        {
            if(k == 0)
            {
                return num.ToString(0,len);
            }
            for (int i = 0; i < len; i++)
            {
                if (i < len - 1)
                {
                    if (num[i] > num[i + 1])
                    {
                        MoveAt(num, len,i );
                        len--;
                        break;
                    }
                }
                else
                {
                    len--;
                }
            }

            return RemoveKdigits(num, len, k - 1);
        }
        int MoveAt(StringBuilder sb, int len, int i)
        {
            for(int k = i;k + 1< len; k++)
            {
                sb[ k] = sb[k + 1];
            }
            return len - 1;
        }


        //public string RemoveKdigits(string num, int k)
        //{
        //    if (k == 0) return num;
        //    if (k >= num.Length) return "0";
        //    string str = "";
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        if (i < num.Length - 1)
        //        {
        //            if (num[i] > num[i + 1])
        //            {
        //                str = num.Substring(0, i) + num.Substring(i + 1, num.Length - i - 1);
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            str = num.Substring(0, i);

        //        }
        //    }
        //    str = str.TrimStart('0');
        //    if (k == 1)
        //    {
        //        return str == "" ? "0" : str;
        //    }
        //    return RemoveKdigits(str, k - 1);
        //}
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);
            int i = 0, j = 0;
            int minR = int.MaxValue;
            int maxR = int.MinValue;
            while (i < houses.Length)
            {
                while (j + 1 < heaters.Length && Math.Abs(houses[i] - heaters[j]) > Math.Abs(houses[i] - heaters[j + 1]))
                {
                    j++;
                }
                minR = Math.Abs(houses[i] - heaters[j]);
                maxR = Math.Max(minR, maxR);
                i++;
            }
            return maxR;
        }

        //public int FindRadius(int[] houses, int[] heaters)
        //{
        //    Array.Sort(houses);
        //    Array.Sort(heaters);
        //    int i = 0, j = 0;
        //    int minR = int.MaxValue;
        //    int maxR = int.MinValue;
        //    while (i < houses.Length)
        //    {
        //        minR = Math.Min(Math.Abs(houses[i] - heaters[j]), minR);
        //        if (j + 1 < heaters.Length && Math.Abs(houses[i] - heaters[j]) > Math.Abs(houses[i] - heaters[j + 1]))
        //        {
        //            j++;
        //        }
        //        else
        //        {
        //            maxR = Math.Max(minR, maxR);
        //            minR = int.MaxValue;
        //            i++;
        //        }
        //    }
        //    return maxR;
        //}

        int mf;
        //public int FindMaxForm(string[] strs, int m, int n)
        //{
        //    mf = int.MinValue;
        //    int[,] matrix = GetMatrix(strs);
        //    Dfs(matrix,0,m,n);
        //    return mf;
        //}
        //void Dfs(int[,] matrix,int start,int m, int n)
        //{

        //}

        public string ValidIPAddress(string IP)
        {
            if(IP.Contains('.'))
            {
                return CheckIP4(IP);
            }else if(IP.Contains(':'))
            {
                return CheckIP6(IP);
            }
            return "Neither";
        }
        string CheckIP4(string IP)
        {
            string[] strs = IP.Split('.');
            if(strs.Length == 4)
            {
                foreach(var s in strs)
                {
                    if(!IsValidIP4(s))
                    {
                        return "Neither";
                    }
                }
                return "IPv4";
            }
            return "Neither";
        }
        bool IsValidIP4(string s)
        {
            if (s == "" || s[0] == '0' || s.Length > 3) return false;
            int num = 0;
            for(int i = 0;i < s.Length;i ++)
            {
                if (!char.IsDigit(s[i])) return false;
                num = num * 10 + s[i] - '0';
            }
            if (num > 255) return false;
            return true;
        }
        string CheckIP6(string IP)
        {

            string[] strs = IP.Split(':');
            if (strs.Length == 8)
            {
                foreach (var s in strs)
                {
                    if (!IsValidIP8(s))
                    {
                        return "Neither";
                    }
                }
                return "IPv6";
            }
            return "Neither";
        }
        bool IsValidIP8(string s)
        {
            if (s.Length > 4) return false;
            for(int i =0;i < s.Length-4; i++)
            {
                if(s[i] != '0')
                {
                    return false;
                }
            }
            if (s == "") return false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToUpper(s[i]);
                if (!(char.IsDigit(c) || (c >= 'A' && c <= 'F'))) {
                    return false;
                } 
            }
            return true;
        }


        
        //public string RemoveKdigits(string num, int k)
        //{
        //    if (k == 0) return num;
        //    if (k >= num.Length) return "0";
        //    string str = "";
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        if (i < num.Length - 1)
        //        {
        //            if (num[i] > num[i + 1])
        //            {
        //                str = num.Substring(0, i) + num.Substring(i + 1, num.Length - i - 1);
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            str = num.Substring(0, i);

        //        }
        //    }
        //    str = str.TrimStart('0');
        //    if (k == 1)
        //    {
        //        return str == "" ? "0" : str;
        //    }
        //    return RemoveKdigits(str, k - 1);
        //}

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();
            if (root == null) return list;

            DfsTreePath(root,"",list);
            return list;
        }
        string direction = "->";
        void DfsTreePath(TreeNode root,string str,IList<string> list)
        {
            
            if (root.left == null && root.right == null)
            {
                str += (str == "" ? "" : direction) + root.val;
                list.Add(str);
                return;
            }
            str += (str == "" ? "" : direction) + root.val;
            if (root.left != null)
            {
                DfsTreePath(root.left, str, list);
            }

            if (root.right != null)
            {
                DfsTreePath(root.right, str, list);
            }
        }

        public string SimplifyPath(string path)
        {
            string[] arr = path.Split('/');
            Stack<string> subPaths = new Stack<string>();
            foreach(var e in arr)
            {
                if(e != "")
                {
                    if (e == ".")
                    {
                    }
                    else if (e == "..")
                    {
                        if(subPaths.Count > 0)
                            subPaths.Pop();
                    }
                    else
                    {
                        subPaths.Push(e);
                    }
                }
                    
            }

            List<string> list = new List<string>();
            string strAns = "";
            while (subPaths.Count > 0)
            {
                var top = subPaths.Pop();
                strAns = "/" + top + strAns;
            }
            if (strAns == "") strAns = "/";

            return strAns;


        }

        public int LengthLongestPath(string input)
        {
            string[] paths = input.Split('\n');
            int[] stack = new int[paths.Length];

            int max = 0;
            foreach(var p in paths)
            {
                int lastI = p.LastIndexOf('\t');
                stack[lastI + 1] = lastI < 0 ? p.Length : stack[lastI] + p.Length - lastI;
                if(p.Contains('.'))
                {
                    max = Math.Max(stack[lastI + 1], max);
                }
            }
            return max;
        }
    }
}
