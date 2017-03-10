using System;

  

public class LinkedListCycle
{
    public bool containsCycle(LinkedListNode head)
    {   

        LinkedListNode tortoise = head;
        LinkedListNode hare=head;

        while (tortoise!=null && hare!=null)
        {
            tortoise=tortoise.next;
            hare= hare.next.next;            

            if (tortoise==hare)
                return true;
        }

        return false;
    }
public void Test()
{

    LinkedListNode A= new LinkedListNode("A");
    LinkedListNode B= new LinkedListNode("B");A.next=B;
    LinkedListNode C= new LinkedListNode("C");B.next=C;
    LinkedListNode D= new LinkedListNode("D");C.next=D;D.next=C;
    LinkedListCycle cycle= new LinkedListCycle();
    Console.WriteLine(cycle.containsCycle(A));
}
}