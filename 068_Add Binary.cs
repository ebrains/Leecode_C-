/*
Given two binary strings, return their sum (also a binary string).
For example,
a = "11"
b = "1"
Return "100"
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
            string s1 = "11";
            string s2 = "1111";
            Console.Write(test.AddBinary(s1, s2));

        }

        public string AddBinary(string a, string b)
        {
            int carry = 0;
            if (a == null)
                return b;
            if (b == null)
                return a;
            int i = a.Length - 1;
            int j = b.Length - 1;

            StringBuilder sb = new StringBuilder();
            
            while(i >=0 || j >= 0)
            {
                int sum = 0;
                if (i >= 0 && a[i] == '1')
                {
                    sum++;
                }
                if (j >= 0 && b[j] == '1')
                {
                    sum++;
                }
                sum = sum + carry;

                if(sum>=2)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sb.Insert(0, (char)((sum % 2) + '0'));

                i--;
                j--;
            }

            if(carry == 1)
            {
                sb.Insert(0, '1');
            }

            return sb.ToString();
        }
    }
}


