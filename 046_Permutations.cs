/*
Given a collection of distinct numbers, return all possible permutations.
For example,
[1,2,3] have the following permutations:
[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]
// Analysis:  backtracking
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
        }
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if(nums == null) {
                return res;
            }
            dfs(nums, new bool[nums.Length], new List<int>(), res);

            return res;

        }

        private void dfs(int[] nums, bool[] visited, IList<int> permutation, IList<IList<int>> res)
        {
            if(nums.Length == permutation.Count())
            {
                res.Add(new List<int>(permutation));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                permutation.Add(nums[i]);
                visited[i] = true;
                dfs(nums, visited, permutation, res);
                visited[i] = false;
                permutation.RemoveAt(permutation.Count() - 1);
            }

        }
    }
}
