/*
Given a linked list, remove the nth node from the end of list and return its head.
For example,
Given linked list: 1->2->3->4->5, and n = 2.
After removing the second node from the end, the linked list becomes 1->2->3->5.
*/

using System;
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

            test.RemoveNthFromEnd(list, 2);
            printNode(list);

        }

        //One pass algorithm
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            ListNode fast = head;
            ListNode slow = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            //if remove the first node
            if (fast == null)
            {
                head = head.next;
                return head;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return head;
        }

        //Two pass algorithm
        public ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            int length = 0;
            ListNode first = head;
            while (first != null)
            {
                length++;
                first = first.next;
            }
            length -= n;
            first = dummy;
            while (length > 0)
            {
                length--;
                first = first.next;
            }
            first.next = first.next.next;
            return dummy.next;
            
        }

        static void printNode(ListNode node)
        {
            while (node != null)
            {
                Console.Write( node.val + " -> ");
                node = node.next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

    }  

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }   

}


