using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LeetCodeSolution
{
    // https://leetcode.com/problems/two-sum/
    public class TwoSum
    {
        public int[] AddSum(int[] arrayNum, int target)
        {

            var dictSum = new Dictionary<int, int>();

            for (int i = 0; i < arrayNum.Length; i++)
            {
                var diff = target - arrayNum[i];

                if (dictSum.TryGetValue(diff, out int foundValue))
                    return new int[] { foundValue, i };

                if (!dictSum.ContainsKey(arrayNum[i]))
                    dictSum.Add(arrayNum[i], i);
                    
            }
            return null;



            //for (int i = 0; i < arrayNum.Length; i++)
            //{
            //    var diff = target - arrayNum[i];

            //    if (dictSum.TryGetValue(diff, out int foundValue))
            //        return new int[] { foundValue, i };

            //    if (!dictSum.ContainsKey(arrayNum[i]))
            //        dictSum.Add(arrayNum[i], i);

            //}
            //return null;

        }
    }
}
