/*
 * Given a digit string, return all possible letter combinations that the number could represent.
 * A mapping of digit to letters (just like on the telephone buttons) is given below.
 * Return the sum of the three integers. You may assume that each input would have exactly one solution.
 * 
 * Input:Digit string "23"
 * Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
 * 
 * Analysis£º
 * This problem can be solves by a typical DFS algorithm. DFS problems are very similar and can be solved by using a simple recursion. 
 * Check out the index page to see other DFS problems.
 * Use hashmap
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
            string input = "23";
            Program test = new Program();
            IList<string> list = test.LetterCombinations(input);

            foreach(string i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            
        }
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if(digits == null || digits.Equals(""))
            {
                return result;
            }

            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict['2'] = "abc";
            dict['3'] = "def";
            dict['4'] = "ghi";
            dict['5'] = "jkl";
            dict['6'] = "mno";
            dict['7'] = "pqrs";
            dict['8'] = "tuv";
            dict['9'] = "wxyz";
            dict['0'] = "";

            StringBuilder sb = new StringBuilder();

            dfs(result, new StringBuilder(), digits, 0, dict);

            return result;
        }

        public void dfs(IList<String> result, StringBuilder sb,String digits,int index, Dictionary<char,string> dict)
        {
            if(index >= digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }
            char curr = digits[index];
            string s = dict[curr];
            for(int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                dfs(result, sb, digits, index+1, dict);
                sb.Remove(sb.Length - 1,1);
            }
        }
    }
}

