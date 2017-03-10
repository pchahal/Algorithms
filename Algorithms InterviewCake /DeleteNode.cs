using System;

  public  class LinkedListNode {

    public String value;
    public LinkedListNode next;

    public LinkedListNode(String value) {
        this.value = value;
    }
}



class DeleteNode
{
    //a -> b -> c
    public void deleteNode(LinkedListNode node)
    {
    
        if (node==null)
            return;

       if (node.next!=null)
        {
            node.value= node.next.value;
            node.next= node.next.next;
            

        }
    }

    public void Test()
    {
        LinkedListNode a = new LinkedListNode("A");
        LinkedListNode b = new LinkedListNode("B");
        LinkedListNode c = new LinkedListNode("C");

        a.next = b;
        b.next = c;

        deleteNode(b);
        
    }
}