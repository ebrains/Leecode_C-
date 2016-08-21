/*
 * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines
 * are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
 * Find two lines, which together with x-axis forms a container, such that the container contains the most water.
 * 
 * Analysis:
 * Initially we can assume the result is 0. Then we scan from both sides. If leftHeight < rightHeight, 
 * move right and find a value that is greater than leftHeight. Similarily, if leftHeight > rightHeight,
 * move left and find a value that is greater than rightHeight. Additionally, keep tracking the max value.
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
            int[] arr = {5,6,8,9,12,3,6};
            Console.WriteLine(test.MaxArea(arr));
        }

        public int MaxArea(int[] height)
        {
            int max = 0, left = 0 , right = height.Length - 1;
            if (height == null || height.Length < 2)
            {
                return 0;
            }
            while (left < right)
            {
                max = Math.Max(max, (right - left) * Math.Min(height[left], height[right]));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return max;
        }
    }
}

