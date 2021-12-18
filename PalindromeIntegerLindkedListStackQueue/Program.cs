using System;
using System.Collections.Generic;

namespace PalindromeIntegerLindkedList
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {

        public static ListNode findMiddle(ListNode head)
        {
            ListNode turtle = head;
            ListNode rabbit = head;

            while (rabbit.next != null && rabbit.next.next != null)
            {
                rabbit = rabbit.next.next;
                turtle = turtle.next;
            }

            return turtle;
        }

        public static ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head.next == null || head == null)
            {
                return true;
            }

            ListNode middle = findMiddle(head);
            ListNode secondHalf = reverse(middle.next);
            ListNode firstHalf = head;

            while (secondHalf != null)
            {
                if (firstHalf.val != secondHalf.val)
                {
                    return false;
                }
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return true;

        }
        static void Main(string[] args)
        {

            //[1,1,2,1]

            ListNode myList = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(1))));
            

            Console.WriteLine(IsPalindrome(myList));
        }
    }
}
