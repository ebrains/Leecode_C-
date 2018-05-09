/*
Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
Example 1:

Input:
    2
   / \
  1   3
Output: true
Example 2:

    5
   / \
  1   4
     / \
    3   6
Output: false
Explanation: The input is: [5,1,4,null,null,3,6]. The root node's value
             is 5 but its right child's value is 4.
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

        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode t, long min, long max)
        {
            if (t == null)
                return true;
            if (t.val <= min || t.val >= max)
                return false;
            return IsValidBST(t.left, min, t.val) && IsValidBST(t.right, t.val, max);
        }
    }
    
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}

