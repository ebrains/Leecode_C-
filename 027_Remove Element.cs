/*
Given an array and a value, remove all instances of that value in-place and return the new length.
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
The order of elements can be changed. It doesn't matter what you leave beyond the new length.

Example:
Given nums = [3,2,2,3], val = 3,
Your function should return length = 2, with the first two elements of nums being 2.
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
            int[] nums = { 5,1,1,5,5 };
            Console.WriteLine(test.RemoveElement(nums,5));

        }
        public int RemoveElement(int[] nums, int val)
        {    
            int n = nums.Length;
            if (n == 0) return 0;
            for (int j = 0; j < n; j++)
            {
                if (nums[j] == val)
                {
                    n = n -1 ;       
                }
            }
            return n;
        }

    }
}


