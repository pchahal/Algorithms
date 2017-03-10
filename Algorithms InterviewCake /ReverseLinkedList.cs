using System;

public class ReverseLinkedList
{
    //  A-> B-> C
    public LinkedListNode reverseList(LinkedListNode head)
    {
        if (head==null|| head.next==null) return head;

        LinkedListNode prev = head;
        LinkedListNode current= head.next;
        LinkedListNode next= head.next.next;
        prev.next=null;
        

        while (next!=null)
        {
            current.next= prev;
            prev=current;
            current=next;
            next=next.next;

        }

        current.next=prev;
        return current;
    }

  

    public void Test()
    {
         LinkedListNode A = new LinkedListNode("A");
        LinkedListNode B = new LinkedListNode("B"); A.next = B;
        LinkedListNode C = new LinkedListNode("C"); B.next = C;
        LinkedListNode D = new LinkedListNode("D"); C.next = D; 
        LinkedListCycle cycle = new LinkedListCycle();
        
        
        
      LinkedListNode head= reverseList(A);
     
      while (head!=null)
      {
          Console.WriteLine(head.value);
          head=head.next;
      }

    }
}