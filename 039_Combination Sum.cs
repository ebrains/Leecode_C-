/*
Given a set of candidate numbers (C) (without duplicates) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

The same repeated number may be chosen from C unlimited number of times.

Note:
All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
For example, given candidate set [2, 3, 6, 7] and target 7, 
A solution set is: 
[
  [7],
  [2, 2, 3]
]
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int[] a = { 2,3,6,7,9};
            IList<IList<int>>  res = test.CombinationSum(a, 9);

            foreach( IList<int> i in res)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
        }

        /*Analysis:
        The first impression of this problem should be depth-first search(DFS). To solve DFS problem, recursion is a normal implementation.
        */
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if (candidates == null || candidates.Length == 0)
                return res;
            
            Array.Sort(candidates);

            List<int> current = new List<int>();
            combinationSum(candidates, target, 0, current, res);
            return res;
        }

        public void combinationSum(int[] candidates, int target, int index, List<int> curr, IList<IList<int>> res)
        {
            if(target == 0)
            {         
                res.Add(new List<int>(curr));
                return;
            }

            for(int i = index; i<candidates.Length; i++)
            {
                if (target < candidates[i])
                {
                    return;
                }            
                curr.Add(candidates[i]);
                combinationSum(candidates, target - candidates[i], i, curr, res);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}

