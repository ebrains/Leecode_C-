/*
 * Implement regular expression matching with support for '.' and '*'.
 * 
 * '.' Matches any single character.
 * '*' Matches zero or more of the preceding element.
 * The matching should cover the entire input string (not partial).
 * 
 * The function prototype should be 
 * bool isMatch(const char *s, const char *p)
 * 
 * Some examples:
 * isMatch("aa","a") false
 * isMatch("aa","aa") true
 * isMatch("aaa","aa") false
 * isMatch("aa", "a*") true
 * isMatch("aa", ".*") true
 * isMatch("ab", ".*") true
 * isMatch("aab", "c*a*b") true
 */

/*
 * 1. Analysis
 * First of all, this is one of the most difficulty problems. It is hard to think through all different cases.
 * The problem should be simplified to handle 2 basic cases:
 * 
 * the second char of pattern is "*"
 * the second char of pattern is not "*"
 * For the 1st case, if the first char of pattern is not ".", the first char of pattern and string should be the same. 
 * Then continue to match the remaining part.
 * For the 2nd case, if the first char of pattern is "." or first char of pattern == the first i char of string, 
 * continue to match the remaining part.
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
            string str1 = "aab";
            string str2 = "c*a*b";
            Console.WriteLine(test.IsMatch(str1, str2));
        }
        // Solution 1: Recursion
        public bool IsMatch(String s, String p)
        {
            if (p == null && s == null)
            {
                return true;
            }
            if (p == null || s == null)
            {
                return false;
            }
            return this.isMatchRecursion(s, 0, p, 0);
        }

        public bool isMatchRecursion(String s, int indexOfs, String p, int indexofp)
        {
            if (indexOfs >= s.Length)
            {
                while (indexofp + 1 < p.Length && p[indexofp + 1].Equals('*'))
                {
                    indexofp += 2;
                }
            }
            if (indexOfs >= s.Length && indexofp >= p.Length)
            {
                return true;
            }
            if (indexOfs >= s.Length || indexofp >= p.Length)
            {
                return false;
            }

            var next = indexofp + 1 >= p.Length ? ' ' : p[indexofp + 1];

            if (next.Equals('*'))
            {
                if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
                {
                    // a* matches more than 0 of a in s
                    return this.isMatchRecursion(s, indexOfs + 1, p, indexofp)
                        // a* matches 0 of a in s
                        || this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
                }
                return this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
            }

            if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
            {
                return this.isMatchRecursion(s, indexOfs + 1, p, indexofp + 1);
            }
            return false;
        }

        /*
        public bool IsMatch(string s, string p)
        {
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] == '*') dp[0, i + 1] = dp[0, i - 1];
                else dp[0, i + 1] = false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i] == p[j] || p[j] == '.')
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    else if (p[j] == '*')
                    {
                        dp[i + 1, j + 1] = dp[i + 1, j - 1] || (dp[i, j + 1] && (s[i] == p[j - 1] || p[j - 1] == '.'));
                    }
                }
            }

            return dp[s.Length, p.Length];
        } 
        */
    }
}

