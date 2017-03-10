using System;
using System.Collections.Generic;

namespace CTCI
{
    class RemoveDups
    {
        //1 -> 2 -> 3 -> 2- > 4



        public async void removeDups(Node head)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            if (head == null || head.next == null)
                return;

            Node prev = head;
            head = head.next;

            while (head != null)
            {
                if (dict.ContainsKey(head.data))
                {

                    prev.next = head.next;
                    prev = head;

                    head = head.next;
                }
                else
                {
                    dict[head.data] = 1;
                    prev = head;
                    head = head.next;
                }

            }






        }

        public void Test()
        {
            Node a = new Node(1);
            a.appendToTail(2);
            a.appendToTail(3);
            a.appendToTail(2);
            a.appendToTail(4);
            removeDups(a);


        }
    }


    class Node
    {
        public Node next = null;
        public int data;

        public Node(int d)
        {
            data = d;
        }

        public void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }
    }
}