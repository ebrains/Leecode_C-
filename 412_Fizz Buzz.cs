/*
Write a program that outputs the string representation of numbers from 1 to n.
But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
Example:

n = 15,

Return:
[
    "1",
    "2",
    "Fizz",
    "4",
    "Buzz",
    "Fizz",
    "7",
    "8",
    "Fizz",
    "Buzz",
    "11",
    "Fizz",
    "13",
    "14",
    "FizzBuzz"
]
 
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

            foreach (string i in test.FizzBuzz(15))
            {
                Console.Write(i + " ");
            }
        }
        public IList<string> FizzBuzz(int n)
        {
            IList<string> res = new List<string>();
            if (n == 0)
                return res;

            for (int i = 1; i <= n; i++)
            {
                if(i % 15 == 0 )
                {
                    res.Add("FizzBuzz");
                }
                else if(i % 3 == 0 )
                {
                    res.Add("Fizz");
                }
                else if (i % 5 == 0 )
                {
                    res.Add("Buzz");
                }
                else
                {
                    res.Add(i.ToString());
                }
            }
            return res;
        }

    }
}

