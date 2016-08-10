/*
 * There are two sorted arrays nums1 and nums2 of size m and n respectively.
 * Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
 * Example 1:
 * nums1 = [1, 3]
 * nums2 = [2]
 * 
 * The median is 2.0
 * Example 2:
 * nums1 = [1, 2]
 * nums2 = [3, 4]
 * 
 * The median is (2 + 3)/2 = 2.5
 */


/*
 * Solution : to find (length A + length B) / 2 and (length A + length B) / 2 + 1 if it is even,
 * or just  (length A + length B) / 2 + 1 if it is odd. the key question is how to find kth small element in two sorted arrays. use divide and conquer method, 
 * comparing mid of A and mid of B. here is 4 cases. left mid right for array A, B.
 * 
 * if mid of A <= mid of B
 * k <= left of A + left of B: that means k would not be in the right of B
 * k > left of A + left of B: that means k would not be in the left of A. and we now find k – (left of A length).
 * if mid of A > mid of B
 * K <= left of A + left of B: that means k would not be in the right of A
 * K > left of A + left of B: that means k would not be in the left of B, and we now find k – (left of B length)
 */

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 5, 6 };
            int[] arr2 = { 3, 4, 5, 7 };
            Program test = new Program();
            Console.WriteLine(test.FindMedianSortedArrays(arr1, arr2));
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var len1 = nums1.Length;
            var len2 = nums2.Length;

            var isEven = (nums1.Length + nums2.Length) % 2 == 0;
            var left = (len1 + len2 + 1) / 2;
            var right = (len1 + len2 + 2) / 2;

            if (isEven)
            {
                var leftvalue = findKth(nums1, 0, len1 - 1, nums2, 0, len2 - 1, left);
                var rightvalue = findKth(nums1, 0, len1 - 1, nums2, 0, len2 - 1, right);
                return (leftvalue + rightvalue) / 2.0;
            }
            else
            {
                return findKth(nums1, 0, len1 - 1, nums2, 0, len2 - 1, right);
            }

        }

        public double findKth(int[] num1, int low1, int high1, int[] num2, int low2, int high2, int k)
        {
            if (low1 > high1)
            {
                return num2[low2 + k - 1];
            }

            if (low2 > high2)
            {
                return num1[low1 + k - 1];
            }

            var mid1 = (low1 + high1) / 2;
            var mid2 = (low2 + high2) / 2;

            if (num1[mid1] <= num2[mid2])
            {
                return k <= mid1 - low1 + mid2 - low2 + 1 ? this.findKth(num1, low1, high1, num2, low2, mid2 - 1, k) : this.findKth(num1, mid1 + 1, high1, num2, low2, high2, k - (mid1 - low1 + 1));
            }
            else
            {
                return k <= mid1 - low1 + mid2 - low2 + 1 ? this.findKth(num1, low1, mid1 - 1, num2, low2, high2, k) : this.findKth(num1, low1, high1, num2, mid2 + 1, high2, k - (mid2 - low2 + 1));
            }
        }
    }
}

