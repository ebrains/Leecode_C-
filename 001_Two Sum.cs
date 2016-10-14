/*
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * You may assume that each input would have exactly one solution.
 * 
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 */

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 3, 2, 4 };
            int[] index = new int[2];       
            Program test = new Program();
            index = test.TwoSumHash(nums, 5);
            Console.WriteLine("index1 = " + index[0] + " index2 = " + index[1]);

        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == 5)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }
            return res;
            //throw new ArgumentException("no two sum");
        }

        public int[] TwoSumHash(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    res[0] = dict[target - nums[i]];
                    res[1] = i;
                }
                dict[nums[i]] = i;
            }
            return res;
            throw new ArgumentException("no two sum");
        }
    }
}
