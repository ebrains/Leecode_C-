/*
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
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
            string str = "()[}";
            bool res = test.IsValid(str);
            Console.WriteLine(res);
            Console.ReadLine();     
        }

        public bool IsValid(string s)
        {
            Stack<Char> stack = new Stack<Char>();
            foreach (char c in s.ToCharArray())
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return false;
                    }
                }
                if (c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}


