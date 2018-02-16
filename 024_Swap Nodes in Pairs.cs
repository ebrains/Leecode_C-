/*
Given a linked list, swap every two adjacent nodes and return its head.
For example,
Given 1->2->3->4, you should return the list as 2->1->4->3.
Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
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
            ListNode list = new ListNode(2);
            list.next = new ListNode(4);
            list.next.next = new ListNode(5);
            list.next.next.next = new ListNode(6);
            printNode(list);

            printNode(test.SwapPairs(list));

        }

        //  fake head -> 1 -> 2- >3   1 point to 3, 2 point to 1, fake point to 2
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode h = new ListNode(0);
            h.next = head;
            ListNode p = h;
            while (p.next != null && p.next != null && p.next.next != null)
            {
                ListNode end = p.next.next;
                p.next.next = end.next;
                end.next = p.next;
                p.next = end;

                p = p.next.next;
            }
            return h.next;
        }


        static void printNode(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " -> ");
                node = node.next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

    }
}


