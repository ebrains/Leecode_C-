/*
Given an array of integers sorted in ascending order, find the starting and ending position of a given target value.
Your algorithm's runtime complexity must be in the order of O(log n).
If the target is not found in the array, return [-1, -1].

For example,
Given [5, 7, 7, 8, 8, 10] and target value 8,
return [3, 4]
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
            int[] nums = { 1,2,5} ;
            int[] res = test.SearchRange(nums, 1);

            foreach(int i in res)
            {
                Console.Write(i + " ");
            }
        }

        // naive way
        public int[] SearchRange(int[] nums, int target)
        {
            int[] res = { -1, -1 };
            if (nums == null)
                return res;
            if (nums.Length == 1)
            {
                if (nums[0] != target)
                {
                    return res;
                }
                else
                {
                    res[0] = 0;
                    res[1] = 0;
                    return res;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    res[0] = i;
                    break;
                }
            }
            for (int i = nums.Length-1; i >= 0; i--)
            {
                if (nums[i] == target)
                {
                    res[1] = i;
                    break;
                }
            }
            return res;

        }
    }
}


