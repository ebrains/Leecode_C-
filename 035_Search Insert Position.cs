/*
Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
You may assume no duplicates in the array.
Example 1:
Input: [1,3,5,6], 5
Output: 2
Example 2:
Input: [1,3,5,6], 2
Output: 1
Example 3:
Input: [1,3,5,6], 7
Output: 4
Example 1:
Input: [1,3,5,6], 0
Output: 0
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
            int[] a = { 1, 3, 5, 6 };
            Console.Write(test.SearchInsert(a, 0));

        }
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null || target == 0 || target < nums[0])
            {
                return 0;
            }
            int i = 0;
            while (i < nums.Length)
            {
                if (target == nums[i])
                {
                    return i;
                }
                if (target > nums[i])
                {
                    if (i + 1 == nums.Length)
                    {
                        return i;
                    }
                    else if (target < nums[i + 1])
                    {
                        return i + 1;
                    }
                    i = i + 1;
                } 
            }
            return 0;
        }
    }
}


