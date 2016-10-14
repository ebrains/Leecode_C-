/*
 * Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
 * Find all unique triplets in the array which gives the sum of zero.
 * 
 * Note:
 * Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ¡Ü b ¡Ü c)
 * The solution set must not contain duplicate triplets.
 * 
 * For example, given array S = {-1 0 1 2 -1 -4},
 * A solution set is:
 * (-1, 0, 1)
 * (-1, -1, 2)
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
            int[] s = { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> list = test.ThreeSum(s);

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

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
                return res;

            Array.Sort(nums);
            
            for(int i= 0; i<nums.Length-2; i++)
            {
                if(i==0||nums[i]>nums[i-1])
                {
                    int j = i + 1;
                    int k = nums.Length - 1;
                    while (j < k)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            IList<int> l = new List<int>();
                            l.Add(nums[i]);
                            l.Add(nums[j]);
                            l.Add(nums[k]);
                            res.Add(l);

                            j++;
                            k--;

                            // handle duplicate here 
                            while (j < k && nums[j] == nums[j - 1])
                                j++;
                            while (j < k && nums[k] == nums[k + 1])
                                k--;
                        }
                        else if (nums[i] + nums[j] + nums[k] < 0)
                        {
                            j++;
                        }
                        else
                        {
                            k--;
                        }
                    }
                }
            }
                return res;
        }
    }
}

