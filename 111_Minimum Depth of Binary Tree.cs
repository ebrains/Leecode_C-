/*
Given a binary tree, find its minimum depth.
The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
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

        public int minDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return getMin(root);
        }

        public int getMin(TreeNode root)
        {
            if (root == null)
            {
                return Int32.MaxValue;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            return Math.Min(getMin(root.left), getMin(root.right)) + 1;
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


