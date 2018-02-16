/*
Merge two sorted linked lists and return it as a new list. 
The new list should be made by splicing together the nodes of the first two lists.
Example:
Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
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
            ListNode list1 = new ListNode(2);
            list1.next = new ListNode(4);
            list1.next.next = new ListNode(5);
            list1.next.next.next = new ListNode(8);
            ListNode list2 = new ListNode(3);
            list2.next = new ListNode(6);
            list2.next.next = new ListNode(7);
            list2.next.next.next = new ListNode(9);
            printNode(list1);
            printNode(list2);

            ListNode res =  test.MergeTwoLists(list1, list2);
            printNode(res);

        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode l = head;

            if(l1 == null)
            {
                return l2;
            }
            if(l2 == null)
            {
                return l1;
            }

            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    l.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    l.next = l2;
                    l2 = l2.next;
                }
                l = l.next;
            }

            if(l1 != null)
            {
                l.next = l1;
            }
            if(l2 != null)
            {
                l.next = l2;
            }

            return head.next;
                    
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


