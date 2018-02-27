/*
Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
For "(()", the longest valid parentheses substring is "()", which has length = 2.
Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
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

            string s = ")()())";



        }

        public int LongestValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            int result = 0;

            int length = s.Length;
            char[] c = s.ToCharArray();

            for(int i = 0; i<length; i++)
            {
                if(c[i] == '(')
                {
                    stack.Push(c[i]);
                }
            }

            //foreach (char c in s.ToCharArray())
            //{

            //}
            
        }


    }
}


