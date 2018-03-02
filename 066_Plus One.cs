/*
Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
You may assume the integer do not contain any leading zero, except the number 0 itself.
The digits are stored such that the most significant digit is at the head of the list.
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
            int[] s = { 9, 9, 9,9 };

            int[] res = test.PlusOne(s);
            foreach(int item in res)
            {
                Console.Write(item);
            }     
        }

        // be careful the first digit 9, after plus one, array will be inserted one more element
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return new int[0];

            int len = digits.Length;
            bool flag = false;

            int i = len - 1;
            while (i>=0)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    flag = false;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                    flag = true;
                }
                i -= 1;
            }

            if(flag == true && digits[0] == 0)
            {
                int[] res = new int[len + 1];
                res[0] = 1;
                for (int j=1; j<len; j++)
                {
                    res[j] = digits[j-1];
                }
                return res; 
            }
            return digits;
        }
    }
}


