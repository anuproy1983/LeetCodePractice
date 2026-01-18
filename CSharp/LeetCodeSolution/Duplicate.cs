using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution
{
    internal class Duplicate
    {
        public bool IsDuplicateNumber(int[] nums)
        {
            var numSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numSet.Contains(nums[i]))
                {
                    return true;
                }
                else
                    numSet.Add(nums[i]);
            }
            return false;
        }
    }
}
