/*
Divide two integers without using multiplication, division and mod operator.

If it is overflow, return MAX_INT.
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
            Console.WriteLine(test.Divide(-7,2));

        }


        // use bit ,  mod operator equals...
        public int Divide(int dividend, int divisor) {
            if (divisor == 0) return Int32.MaxValue;
            var sign = !((dividend > 0) ^ (divisor > 0));

            long dividendlong = Math.Abs((long)dividend);
            long divisorlong = Math.Abs((long)divisor);

            long res = 0;

            while (dividendlong >= divisorlong)
            {
                long cur = 1;
                long start = divisorlong;
                while ((start << 1) <= dividendlong)
                {
                    start <<= 1;
                    cur <<= 1;                 
                }                 
                dividendlong -= start;                 
                res += cur;             
            }             
            if (sign)             
            {                 
                if (res > int.MaxValue) return int.MaxValue;
                return (int)res;
            }
            else
            {
                if (-res < int.MinValue) return int.MaxValue;
                return (int)-res;
            }
    	}

    	//  Brute-force  but there is exception
        public int Divide2(int dividend, int divisor)
        {
            if (divisor == 0) return Int32.MaxValue;
            if (dividend == 0 ) return 0;
            if (divisor < 0 && dividend == Int32.MinValue)
                return Int32.MaxValue;
            if (divisor > 1 && dividend == Int32.MinValue)
                return Int32.MinValue;
            if (dividend == Int32.MaxValue && divisor < 0)
                return Int32.MinValue;
            if (dividend == Int32.MaxValue && divisor > 0)
                return Int32.MaxValue;

            int pdivisor = Math.Abs(divisor);
            int pdividend = Math.Abs(dividend);

            if (pdividend < pdivisor)
                return 0;

            int remain = pdividend - pdivisor;
            int res = 1;
            while (remain > pdivisor)
            {
                remain = remain - pdivisor;
                res = res + 1;
            }

            if (dividend * divisor < 0)
            {
                return -res;
            }         
            else {
                return res;
            }

          
        }

    }
}


