/*
Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
the contiguous subarray [4,-1,2,1] has the largest sum = 6.

If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int[] i = {3,-5,6,8};
            Console.Write(test.MaxSubArray(i));

        }
        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
                return 0;
            if(nums.Length == 1)
            {
                return nums[0];
            }
            int sum = nums[0];
            int maxvalue = nums[0];
            for (int i = 1; i< nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                maxvalue = Math.Max(maxvalue, sum);
            }
            return maxvalue;
        }
    }
}


