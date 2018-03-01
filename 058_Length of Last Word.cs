/*
Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
If the last word does not exist, return 0.
Note: A word is defined as a character sequence consists of non-space characters only.

Example:
Input: "Hello World"
Output: 5
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
            string s = "23423 fsdf ";
            Console.Write(test.LengthOfLastWord(s));
        }

        //  be careful of  "a "  so we need a flag 
        public int LengthOfLastWord(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            int l = s.Length;
            int i = l-1, count = 0;
            bool flag = false;
            while(i>=0)
            {
                if(s[i] != ' ')
                {
                    count = count + 1;            
                    flag = true;
                }
                else
                {
                    if (flag)
                        return count;
                }
                i = i - 1;
            }
            return count;
        }
    }
}


