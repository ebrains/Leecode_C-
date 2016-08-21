/*
 * Given an integer, convert it to a roman numeral.
 * Input is guaranteed to be within the range from 1 to 3999.
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
            int a = 1234;
            Console.WriteLine(test.IntToRoman(a));
        }

        public string IntToRoman(int num)
        {
            string[] ch = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] value = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string ans = "";
            for (int i = 0; num != 0; ++i)
            {
                while (num >= value[i])
                {
                    num -= value[i];
                    ans += ch[i];
                }
            }
            return ans;
        }
    }
}

