/*
Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T. Each number in C may only be used ONCE in the combination.

Note:
1) All numbers (including target) will be positive integers.
2) Elements in a combination (a1, a2, ¡­ , ak) must be in non-descending order. (ie, a1 ¡Ü a2 ¡Ü ¡­ ¡Ü ak).
3) The solution set must not contain duplicate combinations.

For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8, 
A solution set is: 
[
  [1, 7],
  [1, 2, 5],
  [2, 6],
  [1, 1, 6]
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
            int[] a = { 10, 1, 2, 7, 6, 1, 5 };
            IList<IList<int>>  res = test.CombinationSum(a, 8);

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
                if (i != index && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                if (target < candidates[i])
                {
                    return;
                }            
                curr.Add(candidates[i]);
                combinationSum(candidates, target - candidates[i], i+1, curr, res);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}

