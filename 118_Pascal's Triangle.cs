/*
Given numRows, generate the first numRows of Pascal's triangle.

For example, given numRows = 5,
Return

[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]

Solution: DP

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
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if(numRows == 0)
            {
                return res;
            }

            List<int> list = new List<int>();
            list.Add(1);
            res.Add(list);

            for(int i = 2; i <= numRows; i++)
            {
                List<int> list2 = new List<int>();
                list2.Add(1);  // first

                for(int j = 0; j< list.Count - 1; j++)
                {
                    list2.Add(list[j] + list[j + 1]); // middle
                }
                list2.Add(1);  // last

                res.Add(list2);
                list = list2;
            }

            return res;

        }
    }

}

