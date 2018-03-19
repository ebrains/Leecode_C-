/*
Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the
two subtrees of every node never differ by more than 1.

Example:

Given the sorted array: [-10,-3,0,5,9],
One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:
      0
     / \
   -3   9
   /   /
 -10  5
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

        // Solution: do it manually would be like this. find the mid and set it as root, 
        //divide it into two parts, from the left part, find the mid and set it as root.left; from right part, find the mid and set it as root.right. It is recursion.
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return this.sortedArrayToBSTRecursion(nums, 0, nums.Length - 1);
        }

        private TreeNode sortedArrayToBSTRecursion(int[] num, int low, int high)
        {
            if (low > high)
            {
                return null;
            }

            var mid = (high - low) / 2 + low;

            var newRoot = new TreeNode(num[mid])
            {
                left = this.sortedArrayToBSTRecursion(num, low, mid - 1),
                right = this.sortedArrayToBSTRecursion(num, mid + 1, high)
            };

            return newRoot;
        }

        //Definition for a binary tree node
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}


