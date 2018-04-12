/*
Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

For example,
"A man, a plan, a canal: Panama" is a palindrome.
"race a car" is not a palindrome.

Note:
Have you consider that the string might be empty? This is a good question to ask during an interview.
For the purpose of this problem, we define empty string as valid palindrome.

//Also could consider stack
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
            string s ="A man, a plan, a canal: Panama";
            Console.Write(test.IsPalindrome(s));
        }

        public bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return true;
            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            while(left < right)
            {
                if ( left<s.Length && !isvalid(s[left]))
                {
                    left++;
                    continue;
                }          
                else if (right >=0 &&!isvalid(s[right]))
                {
                    right--;
                    continue;
                } 
                else if (s[left] != s[right])
                {
                    return false;
                }                  
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
        private bool isvalid(char c)
        {
            return Char.IsLetterOrDigit(c) ;
        }
    }
}

