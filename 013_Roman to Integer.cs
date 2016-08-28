/*
 * Given a roman numeral, convert it to an integer.
 * Input is guaranteed to be within the range from 1 to 3999.
 * 
 * Solution:
 * 1. This problem has to use HashMap, since we need to quickly look up what does each character mean.
 * 2. Thoughts: if the current char has greater or equal value than the next char, add it; else, minus it.
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
            string roman = "LXV";
            Console.WriteLine(test.RomanToInt(roman));
        }

        public int RomanToInt(String s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X',10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);
            int i = 0;
            int res = 0;

            for (i = 0; i < s.Length - 1; i++)
            {
                if(dict[s[i]]>=dict[s[i+1]])
                {
                    res = res + dict[s[i]];
                }
                else
                {
                    res = res - dict[s[i]];
                }
            }
            res = res + dict[s[i]];
            return res;
        }
    }
}

