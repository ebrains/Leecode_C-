/*
 * Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. 
 * Return the sum of the three integers. You may assume that each input would have exactly one solution.
 * 
 * For example, given array S = {-1 2 1 -4}, and target = 1. 
 * The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
 * 
 * Analysis：
 * This problem is similar to 2 Sum. This kind of problem can be solved by using a similar approach, 
 * i.e., two pointers from both left and right.
 */

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();

            int[] num = { -1, 2, 1, -4 };

            Console.WriteLine(test.ThreeSumClosest(num,1));

        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            int min = Int32.MaxValue;
            int result = 0;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    int diff = Math.Abs(sum - target);

                    if (diff == 0) return sum;

                    if (diff < min)
                    {
                        min = diff;
                        result = sum;
                    }
                    if (sum <= target)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            return result;
        }
    }
}

