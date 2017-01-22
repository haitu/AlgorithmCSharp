using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class NumArray
    {
        long[] sums;
        public NumArray(int[] nums)
        {
            sums = new long[nums.Length + 1];
            for (int i = 0;i < nums.Length;i++)
            {
                sums[i + 1] = sums[i] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            return (int )(sums[j + 1] - sums[i]);
        }
    }
}
