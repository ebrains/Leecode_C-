using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
        class Program
        {
            static void Main(string[] args)
            {
                Program test = new Program();
                IList<string> list = test.GenerateParenthesis(3);

                foreach (string i in list)
                {
                    Console.Write(i + " ");
                }

                Console.ReadLine();
            }

            public IList<string> GenerateParenthesis(int n)
            {
                List<string> result = new List<string>();
                if (n <= 0)
                {
                    return result;
                }
                helper(result, "", n, n);
                return result;
            }

            //parameter for helper
            // current parenteness
            // how many left paren we need to add
            // how many right paren we need to add
            public void helper(IList<string> result, string parenteness, int left, int right)
            {
                if (left == 0 && right == 0)
                {
                    result.Add(parenteness);
                    return;
                }

                if (left > 0)
                {
                    helper(result, parenteness + "(", left - 1, right);
                }

                if (right > 0 && left < right)
                {
                    helper(result, parenteness + ")", left, right - 1);
                }
            }

            public IList<String> GenerateParenthesis2(int n)
            {
                List<String> ans = new List<String>();
                if (n == 0)
                {
                    ans.Add("");
                }
                else
                {
                    for (int c = 0; c < n; ++c)
                        foreach (String left in GenerateParenthesis2(c))
                            foreach (String right in GenerateParenthesis2(n - 1 - c))
                                ans.Add("(" + left + ")" + right);
                }
                return ans;
            }
        }
}
