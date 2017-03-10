using System;


namespace CTCI
{
    // Write code to partition a linked list around a value x, such that all nodes less
    // than x come before all nodes greater than or equal to x. lf x is contained within 
    //the list, the values of x only need to be after the elements less than x (see below).
    //The partition element x can appear anywhere //in the "right partition"; it does not 
    //need to appear between the left and right partitions.

    class Partition
    {
        //Input:  3 -> 5 -> 8 -> 5 ->10 -> 2 -> 1[partition=5) 
        //Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
        public Node partition(Node head, int partition)
        {
            Node before = null;
            Node after = null;
            Node beforeTail = null;
            while (head != null)
            {
                if (head.data < partition)
                {
                    if (before == null)
                        before = new Node(head.data);
                    else
                    {
                        before.appendToTail(head.data);
                        beforeTail = before.next;
                    }

                }
                else
                {
                    if (after == null)
                        after = new Node(head.data);
                    else
                        after.appendToTail(head.data);

                }
                head = head.next;
            }



            beforeTail.next.next = after;
            return before; ;
        }

        public void Test()
        {
            Node a = new Node(3);
            a.appendToTail(5);
            a.appendToTail(8);
            a.appendToTail(5);
            a.appendToTail(10);
            a.appendToTail(2);
            a.appendToTail(1);

            Node par = null;
            par = partition(a, 5);


        }

    }
}