/*
Given a linked list, determine if it has a cycle in it.
Follow up:
Can you solve it without using extra space?
 
Analysis:
To detect if a list is cyclic, we can check whether a node had been visited before. A natural way is to use a hash table.
Imagine two runners running on a track at different speed. What happens when the track is actually a circle?
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

        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode fast, slow;
            fast = head.next;
            slow = head;
            while (fast != slow)
            {
                if (fast == null || fast.next == null)
                    return false;
                fast = fast.next.next;
                slow = slow.next;
            }
            return true;
        }

        public bool HasCycleHash(ListNode head)
        {
            HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodesSeen.Contains(head))
                {
                    return true;
                }
                else
                {
                    nodesSeen.Add(head);
                }
                head = head.next;
            }
            return false;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

    }
}

