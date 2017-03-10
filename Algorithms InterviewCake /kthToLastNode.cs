using System;
//Write a function kthToLastNode() that takes an integer kk and the headNode of a singly linked list, 
//and returns the kkth to last node in the list.

public class kthToLastNode
{
    //A->B->C->D->E      k=3 return node C
    public LinkedListNode KthToLastNode(int k, LinkedListNode head)
    {
        LinkedListNode kNode = head;
        int index = 1;
        while (head!=null)
        {
            if (index>k)
            {
                kNode = kNode.next;
            }

            head = head.next;
            index++;
        }
        return kNode;
    }


    public void Test()
    {
        LinkedListNode a = new LinkedListNode("Angel Food");
        LinkedListNode b = new LinkedListNode("Bundt");
        LinkedListNode c = new LinkedListNode("Cheese");
        LinkedListNode d = new LinkedListNode("Devil's Food");
        LinkedListNode e = new LinkedListNode("Eccles");


        a.next = b;
        b.next = c;
        c.next = d;
        d.next = e;
        // returns the node with value "Devil's Food" (the 2nd to last node)
        Console.WriteLine(KthToLastNode(3, a).value);
        

    }

}