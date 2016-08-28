/*
 * Write a function to find the longest common prefix string amongst an array of strings.
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
            string[] a = { "abcer", "abcccs334", "abcsghtr" };
            string res = test.LongestCommonPrefix(a);
            Console.WriteLine(res);
        }

        // Horizontal scan
        // Time complexity O(N) Space O(1) N is the sum of all characters in all strings
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }
            return prefix;
        }

        // Vertical scanning 
        // Time complexity O(N) Space O(1)  best case is better than horizon, worst case is the same
        public string LongestCommonPrefix1(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            for(int i = 0; i<strs[0].Length;i++)
            {
                char c = strs[0][i];
                for(int j = 1; j < strs.Length; j++)
                {
                    if(i==strs[j].Length||strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }

        // Binary Search
        //Time complexity O(N*log(n)) Space O(1)
        public string LongestCommonPrefix2(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            int minLen = Int32.MaxValue;
            foreach (string str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low < high)
            {
                int middle = (low + high) / 2;
                if (isCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;                                               
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private bool isCommonPrefix(string[] strs, int len)
        {
            string str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
}

