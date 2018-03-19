/*
Given a binary tree, determine if it is height-balanced.
For this problem, a height-balanced binary tree is defined as:
a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

Example 1:
Given the following tree [3,9,20,null,null,15,7]:

    3
   / \
  9  20
    /  \
   15   7
Return true.

Example 2:
Given the following tree [1,2,2,3,3,null,null,4,4]:

       1
      / \
     2   2
    / \
   3   3
  / \
 4   4
Return false.
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

        /* Analysis: 
         Solution1 :It is easy to make mistake here. compare the current node’s has left or has right to determine its binary tree. 
         it should compare the height of left and height or right differ by no more than 1.

         Solution2:  Combine get height and check is balance together within one traversal. use -1 to indicate it is invalid,
         otherwise return the height
        */
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (getHeight(root) == -1)
                return false;

            return true;
        }

        public int getHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = getHeight(root.left);
            int right = getHeight(root.right);

            if(left == -1 || right == -1)
            {
                return -1;
            }
            if (Math.Abs(left - right) > 1)
            {
                return -1;
            }

            return Math.Max(left, right) + 1;
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


