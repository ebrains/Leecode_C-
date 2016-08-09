/*
 * Given a string, find the length of the longest substring without repeating characters.
 * Examples:
 * Given "abcabcbb", the answer is "abc", which the length is 3.
 * Given "bbbbb", the answer is "b", with the length of 1.
 * Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
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
            String str = "abcabcbbz";
            int length = test.LengthOfLongestSubstring3(str);
            Console.WriteLine(length);
        }

        // only need n steps
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int j = 0, i = 0; j < n; j++)
            {
                if (dict.ContainsKey(s[j]))
                {
                    i = Math.Max(dict[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                dict[s[j]] = j + 1;
            }
            return ans;
        }

        //The previous implements all have no assumption on the charset of the string s.
        //If we know that the charset is rather small, we can replace the Map with an integer
        //array as direct access table. Commonly used tables are:
        public int LengthOfLongestSubstring2(string s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character
            // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }

        /* 
          Brute Force method, write a function bool allUnique(String substring) which return true if the characters in the substring are all unique,
          Time complexity : O(n^3) will cause exceed the time
        */
        public int LengthOfLongestSubstring3(String s)
        {
            int n = s.Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (allUnique(s, i, j)) ans = Math.Max(ans, j - i);
            return ans;
        }

        public bool allUnique(String s, int start, int end)
        {
            HashSet<Char> set = new HashSet<Char>();
            for (int i = start; i < end; i++)
            {
                Char ch = s[i];
                if (set.Contains(ch)) return false;
                set.Add(ch);
            }
            return true;
        }
    }
}

