/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. 
Add the two numbers and return it as a linked list.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8

 */
using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(5);

            ListNode res = AddTwoNumbers(l1, l2);

            printNode(res);
           
           

        }

        static void printNode(ListNode l)
        {
             while(l != null)
            {
                Console.WriteLine(l.val);
                l = l.next;
            }
            Console.WriteLine();
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;

            ListNode newHead = new ListNode(0);
            ListNode p1 = l1, p2 = l2, curr = newHead;

            while(p1 !=null || p2!=null)
            {
                if(p1 !=null)
                {
                    carry += p1.val;
                    p1 = p1.next;
                }
                if (p2 != null)
                {
                    carry += p2.val;
                    p2 = p2.next;
                }

                curr.next = new ListNode(carry % 10);
                curr = curr.next;
                carry /= 10;
            }

            if (carry == 1)
                curr.next = new ListNode(1);

            return newHead.next;
        }

        //Definition for singly-linked list.
        public class ListNode 
        {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
        }
       
    }
}

// What if the digits are stored in regular order instead of reversed order?
// Answer: We can simple reverse the list, calculate the result, and reverse the result.