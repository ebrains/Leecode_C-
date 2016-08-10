/*
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * 
 * And then read line by line: "PAHNAPLSIIGYIR"
 */

using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "PAYPALISHIRING";
            Program test = new Program();
            Console.WriteLine(test.Convert(str,3));
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            // step 
            int step = 2 * numRows - 2;
            string ans = "";
            for (int i = 0; i < numRows; i++)
            {
                for (int j = i; j < s.Length; j += step)
                {
                    ans += s[j];
                    if (i > 0 && i < numRows - 1)
                    {
                        if (j + step - 2 * i < s.Length)
                        {
                            ans += s[j + step - 2 * i];
                        }
                    }
                }
            }
            return ans;
        }
    }
}

