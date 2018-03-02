/*
The count-and-say sequence is the sequence of integers with the first five terms as following:
1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.
Given an integer n, generate the nth term of the count-and-say sequence.

Note: Each term of the sequence of integers will be represented as a string.

Example 1:
Input: 1
Output: "1"

Example 2:
Input: 4
Output: "1211"
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int i = 3;
            Console.Write(test.CountAndSay(i));

        }
        public string CountAndSay(int n)
        {
            if (n <= 0)
                return null;
            if (n == 1)
                return "1";
            int i = 1;
            String str = "1";
            while (i<n)
            {
                int count = 1;
                StringBuilder sb = new StringBuilder();
                for(int j = 1; j<str.Length;j++)
                {
                    if(str[j] == str[j-1])
                    {
                        count++;
                    }
                    else
                    {
                        sb.Append(count);
                        sb.Append(str[j - 1]);
                        count = 1;
                    }
                }
                sb.Append(count);
                sb.Append(str[str.Length - 1]);
                str = sb.ToString();
                i++;
            }
            

            return str;
        }
    }
}


