/*
Write a function that takes a string as input and returns the string reversed.
Example:
Given s = "hello", return "olleh".
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
        }
        public string ReverseString(string s)
        {
            char[] c = s.ToCharArray();

            int x = c.Length - 1;
            char[] res = new char[c.Length];
            
            for(int i = 0; i < c.Length; i++)
            {
                res[i] = c[x];
                x -= 1;
            }
            return new string(res);  
        }
    }
}

