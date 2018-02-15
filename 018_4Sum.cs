/*
Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.
Note: The solution set must not contain duplicate quadruplets.
*/

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int[] s = { -1, 0, 1, 2, -1, -4,3 };

            IList<IList<int>> list = test.FourSum(s,3);

            foreach (IList<int> tmp in list)
            {
                Console.Write("( ");
                foreach (int res in tmp)
                {
                    Console.Write(res + ", ");
                }
                Console.Write(")");
                Console.WriteLine("");
            }

        }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j != i + 1 && nums[j] == nums[j - 1])
                        continue;
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum < target)
                        {
                            left++;
                        }
                        else if (sum > target)
                        {
                            right--;
                        }
                        else
                        {
                            List<int> tmp = new List<int>();
                            tmp.Add(nums[i]);
                            tmp.Add(nums[j]);
                            tmp.Add(nums[left]);
                            tmp.Add(nums[right]);
                            result.Add(tmp);
                            left++;
                            right--;
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }   
}


