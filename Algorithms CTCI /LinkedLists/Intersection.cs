using System;
using System.Collections.Generic;

namespace CTCI
{



    //3->1->5->9->7->2->1
    //      4->6->
    //get length of both lists, then move longer list n nodes, so they match void Update (){
    //loop through both and find first matching node
    class Intersection
    {

        public Node intersection(Node list1, Node list2)
        {
            int length1 = 0;
            int length2 = 0;

            Node l1 = list1;
            Node l2 = list2;
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    l1 = l1.next;
                    length1++;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                    length2++;
                }
            }

            l1 = list1; l2 = list2;
            if (length1 > length2)
            {
                for (int i = 0; i < length1 - length2; i++)
                {
                    l1 = l1.next;
                }
            }
            else
            {
                for (int i = 0; i < length2 - length1; i++)
                {
                    l2 = l2.next;
                }
            }

            while (l1 != l2)
            {
                l1 = l1.next;
                l2 = l2.next;
            }



            Console.WriteLine(l1.data);
            return l1;
        }

        public void Test()
        {
            Node a = new Node(3);
            a.appendToTail(1);
            a.appendToTail(5);
            a.appendToTail(9);
            a.appendToTail(7);
            a.appendToTail(2);
            a.appendToTail(1);

            Node b = new Node(4);
            b.appendToTail(6);
            b.next.next = a.next.next.next.next;
            Console.WriteLine(intersection(a, b));
        }

    }
}

