/*
Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

Example 1
Input: [3,0,1]
Output: 2
Example 2

Input: [9,6,4,2,3,5,7,0,1]
Output: 8

Note:
Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
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
        public int MissingNumber(int[] nums)
        {
            HashSet<int> numset = new HashSet<int>();

            foreach(int num in nums)
            {
                numset.Add(num);
            }

            for( int i = 0; i < nums.Length + 1; i ++)
            {
                if (!numset.Contains(i))
                {
                    return i;
                }
            }
            return -1;
           
        }
    }
}

