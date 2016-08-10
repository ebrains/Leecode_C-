/*
 * Implement atoi to convert a string to an integer.
 * 
 * Hint: Carefully consider all possible input cases. If you want a challenge, 
 * please do not see below and ask yourself what are the possible input cases.
 * 
 * Notes: It is intended for this problem to be specified vaguely (ie, no given input specs).
 * You are responsible to gather all the input requirements up front.
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
            string str = "87564";
            int res  = test.MyAtoi(str);
            Console.WriteLine(res);
        }
 

        public int MyAtoi(string str)
        {
            if (str == null || str.Length < 1)
                return 0;

            // trim white spaces
            str = str.Trim();

            char flag = '+';

            // check negative or positive
            int i = 0;
            if (str[0] == '-')
            {
                flag = '-';
                i++;
            }
            else if (str[0] == '+')
            {
                i++;
            }
            // use double to store result
            double result = 0;

            // calculate value
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                result = result * 10 + (str[i] - '0');
                i++;
            }

            if (flag == '-')
                result = -result;

            // handle max and min
            if (result > Int32.MaxValue)
                return Int32.MaxValue;

            if (result < Int32.MinValue)
                return Int32.MinValue;         
            return (int)result;
        }
    }

    /*
     * The following cases should be considered for this problem:
     * 1. null or empty string
     * 2. white spaces
     * 3. +/- sign
     * 4. calculate real value
     * 5. handle max and min
     */
}

