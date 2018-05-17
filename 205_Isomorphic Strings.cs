/*
Given two strings s and t, determine if they are isomorphic.
Two strings are isomorphic if the characters in s can be replaced to get t.
All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

For example,
Given "egg", "add", return true.
Given "foo", "bar", return false.
Given "paper", "title", return true.
Note:
You may assume both s and t have the same length.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            string s1 = "ab", s2 = "aa";

            bool res = test.IsIsomorphic(s1, s2);
        }


        // time complexity n*n
        public bool IsIsomorphicHash(string s, string t)
        {
            if (s == null || t == null)
                return false;

            Dictionary<char, char> dict = new Dictionary<char, char>();

            for ( int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (dict.ContainsValue(t[i]))
                        return false;
                    dict.Add(s[i], t[i]);
                }
            }
            return true;

        }

        // O(n)	
        public bool IsIsomorphic(string s, string t)
        {
            // ASCII range 255
            int[] m1 = new int[256];
            int[] m2 = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                int cs = s[i];
                int ts = t[i];
                if (m1[cs] == 0 && m2[ts] == 0)
                {
                    m1[cs] = ts;
                    m2[ts] = 1;
                }
                else if (m1[cs] != ts)
                {
                    return false;
                }
            }
            return true;
        }

    }  
}

