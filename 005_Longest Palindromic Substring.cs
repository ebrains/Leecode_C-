/*
 * Given a string S, find the longest palindromic substring in S. You may assume that the maximum length of S is 1000, 
 * and there exists one unique longest palindromic substring.
 */

/*
 * Solution :
 * Naively, we can simply examine every substring and check if it is palindromic.
 * The time complexity is O(n^3). so the time limit may exceeded
 * 
 * 1. Reverse SS and become S'S, Find the longest common substring between SS and S'S, 
 * which must also be the longest palindromic substring, but it fails when S = "abacdfgdcaba"
 * to rectify this, we check if the substring’s indices are the same as the reversed substring’s original indices. 
 * compare to problem (The longest common substring)
 * 
 * 2.Dynamic Programming Time complexity : O(n^2)
 * 
 * 3.Expand Around Center   O(n^2) only constant space. (recommend)
 * 
 */

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcbadfdba";
            Program test = new Program();
            Console.WriteLine(test.LongestPalindrome(str));       
        }     

        // solution 
        public string LongestPalindrome(string s)
        {
            int start = 0,end = 0;
            for(int i =0; i < s.Length; i++ )
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}

