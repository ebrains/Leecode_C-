/*
Given an index k, return the kth row of the Pascal's triangle.

For example, given k = 3,
Return [1,3,3,1].

Note:
Could you optimize your algorithm to use only O(k) extra space?

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

            IList<int> res = new List<int>();
            res = test.GetRow(3);

            foreach(int i in res)
            {
                Console.Write(i + " ");
            }
        }
        public IList<int> GetRow(int rowIndex)
        {
                List<int> list = new List<int>();       

                if (rowIndex < 0)
                {
                    return list;
                }                
                list.Add(1);
                
                for (int i = 1; i <= rowIndex; i++)
                {
                    List<int> list2 = new List<int>();
                    list2.Add(1);  // first

                    for (int j = 0; j < list.Count - 1; j++)
                    {
                        list2.Add(list[j] + list[j + 1]); // middle
                    }
                    list2.Add(1);  // last
                    list = list2;               
                }
                return list;
            }
        }
}

