/*
For example,
[1,1,2] have the following unique permutations:
[
  [1,1,2],
  [1,2,1],
  [2,1,1]
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
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if(nums == null) {
                return res;
            }
            Array.Sort(nums);
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

                if (i > 0 && nums[i] == nums[i - 1] && !visited[i - 1])
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
