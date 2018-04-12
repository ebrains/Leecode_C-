/*
Given an array of integers, every element appears twice except for one. Find that single one.
Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
 
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
        }

        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                if (i + 1 >= nums.Length)
                    return nums[i];
                if (nums[i] != nums[i + 1])
                    return nums[i];
            }
            return nums[nums.Length - 1];
        }

    }
}

