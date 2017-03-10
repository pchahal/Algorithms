using System;
using System.Collections.Generic;

namespace CTCI
{

    //Palindrome: Implement a function to check if a linked list is a palindrome.
    //  a->b->c->b->a   TRUE

    //If we don't know the size of the linked list, we can iterate through the linked list, 
    //using the fast runner / slow runner technique described in the beginning of the chapter.
    // At each step in the loop, we push the data from the slow runner onto a stack. When the 
    //fast runner hits the end of the //list, the slow runner will have reached the middle of 
    //the linked list. By this point, the stack will have all the elements from the front of 
    //the linked list, but in reverse order.
    //use slow and fast pointers
    class Palindrome
    {



        public bool isPalindrome(Node slow)
        {
            Stack<int> stack = new Stack<int>();
            Node fast = slow;

            while (fast != null)
            {
                stack.Push(slow.data);

                slow = slow.next;
                fast = fast.next;
                if (fast != null)
                    fast = fast.next;
            }


            if (stack.Count % 2 != 0)
                stack.Pop();
            while (slow != null)
            {
                if (stack.Pop() == slow.data)
                    slow = slow.next;
                else
                    return false;
            }

            return true;
        }

        public void Test()
        {
            Node a = new Node(1);
            a.appendToTail(2);
            a.appendToTail(3);
            a.appendToTail(2);
            a.appendToTail(1);


            Console.WriteLine(isPalindrome(a));
        }

    }
}

