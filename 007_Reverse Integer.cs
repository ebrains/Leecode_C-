/*
 * Reverse digits of an integer.
 * 
 * Example1: x = 123, return 321
 * Example2: x = -123, return -321
 * 
 * Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!
 * If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.
 * Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?
 * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
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
            int a = 1534469;
		    int res = test.Reverse(a);
            Console.WriteLine(res);
        }
        /*
        Succinct Solution
        */
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int rev = res * 10 + x % 10;
                x = x / 10;
                if (rev / 10 != res)   //  avoid out of range
                {
                    res = 0;
                    break;
                }
                res = rev;
            }
            return res;
        }
    }

    /*
     * Handle Out of Range Problem
     * As we form a new integer, it is possible that the number is out of range.
     * We can use the following code to assign the newly formed integer. When it is out of range, throw an exception.
     *
     *  try
     *  {
     *      result = ...;
     *  }
     *  catch(InputMismatchException exception)
     *  {
     *      ..........
     *  }
     */
}

