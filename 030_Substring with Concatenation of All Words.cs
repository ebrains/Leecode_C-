/*
You are given a string, s, and a list of words, words, 
that are all of the same length. Find all starting indices of substring(s) in s that is 
a concatenation of each word in words exactly once and without any intervening characters.
For example, given:
s: "barfoothefoobarman"
words: ["foo", "bar"]

You should return the indices: [0,9].   (order does not matter).
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
            string s = "barfoothefoobarman";
            string[] words = {"foo", "bar"};
            IList<int> list = test.FindSubstring(s, words);

            foreach (int res in list)
            {
                Console.Write(res + ",");
            }

        }


        public IList<int> FindSubstring(string s, string[] words)
        {     
            IList<int> res = new List<int>();
            if (s == null || s.Length == 0 || words == null || words.Length == 0)
            {
                return res;
            }

            Dictionary<string, int> dict  = new Dictionary<string, int>();
            for(int i = 0; i<words.Length; i++)
            {
                dict.Add(words[i], i);
            }

            int len = words[0].Length;
            int count = 0;
            

            while (s.Length >= 3)
            {
                string strtemp = s.Substring(0, 3);
                if (dict.ContainsKey(strtemp) == false)
                {
                    s = s.Substring(3);
                    res.Add(1);
                }
                else
                {
                    s = s.Substring(3);
                    res.Add(count);
                    count = count + len;
                    
                }
            }

            return res;

        }

    }
}


