/*
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2.
Note:
The length of both num1 and num2 is < 110.
Both num1 and num2 contains only digits 0-9.
Both num1 and num2 does not contain any leading zero.
You must not use any built-in BigInteger library or convert the inputs to integer directly.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            string s1 = "343545", s2 = "6456";
            string res = test.Multiply(s1, s2);

            Console.Write(res);
        }

        public string Multiply(string num1, string num2)
        {
            var res = new int[num1.Length + num2.Length];
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                for (var j = num2.Length - 1; j >= 0; j--)
                {
                    // use char to get the int
                    var sum = (num1[i] - '0') * (num2[j] - '0') + res[i + j + 1];

                    res[i + j + 1] = sum % 10;
                    res[i + j] += sum / 10;
                }
            }

            var result = new StringBuilder();
            for (int i = 0; i < res.Length; i++)
            {
                if (result.Length == 0 && res[i] == 0) continue;
                result.Append(res[i]);
            }
            return result.Length > 0 ? result.ToString() : "0";
        }
    }
}

