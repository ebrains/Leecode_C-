/*
Implement int sqrt(int x).
Compute and return the square root of x.
x is guaranteed to be a non-negative integer.

Example 1:
Input: 4
Output: 2

Example 2:
Input: 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we want to return an integer, 
the decimal part will be truncated.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int i = 23445;
            Console.Write(test.MySqrt(i));
        }

        // Newton  Math solution 
        public int MySqrt(int x)
        {
            {
                long i = 0;
                long j = x / 2 + 1;
                while (i <= j)
                {
                    long mid = (i + j) / 2;
                    if (mid * mid == x)
                        return (int)mid;
                    if (mid * mid < x)
                        i = mid + 1;
                    else
                        j = mid - 1;
                }
                return (int)j;

            }
        }
    }
}


