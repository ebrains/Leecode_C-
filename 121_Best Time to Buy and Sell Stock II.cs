/*
Say you have an array for which the ith element is the price of a given stock on day i.
Design an algorithm to find the maximum profit. 
You may complete as many transactions as you like 
(ie, buy one and sell one share of the stock multiple times).
However, you may not engage in multiple transactions at the same time
(ie, you must sell the stock before you buy again).

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
        }

        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i<prices.Length - 1; i++)
            {
                int dif = prices[i + 1] - prices[i];
                if(dif > 0)
                {
                    profit = profit + dif;
                }
            }
            return profit;       
        }
    }
}

