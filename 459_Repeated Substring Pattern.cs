/*
Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.
Example 1:
Input: "abab"

Output: True

Explanation: It's the substring "ab" twice.
Example 2:
Input: "aba"

Output: False
Example 3:
Input: "abcabcabcabc"

Output: True

Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)


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
        }

        public bool RepeatedSubstringPattern(string s)
        {
            int n = s.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i != 0) continue;
                sb.Clear();
                string substr = s.Substring(0, i);
                while (sb.Length < n)
                {
                    sb.Append(substr);
                }
                if (sb.ToString().Equals(s)) return true;
            }
            return false;
        }
    }


}

