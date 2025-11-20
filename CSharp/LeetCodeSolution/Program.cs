using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSum();
            //var result = twoSum.AddSum(new int[] { 2, 7, 11, 15 }, 9);
            //var result = twoSum.AddSum(new int[] { 3, 2, 4 }, 6);
            var result = twoSum.AddSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
            Console.WriteLine($"[{result[0]},{result[1]}]");

            Console.ReadLine();
        }
    }
}
