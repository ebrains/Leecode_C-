/*
Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following [1,2,2,null,3,null,3] is not:
    1
   / \
  2   2
   \   \
   3    3
Note:
Bonus points if you could solve it both recursively and iteratively.
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

        // recursive
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return false;
            return ismirror(root, root);
        }

        public bool ismirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;
            return (t1.val == t2.val) && ismirror(t1.left, t2.right) &&
                ismirror(t1.right, t2.left);
        }

        // iterate
        //every level check if it's palindrome

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


