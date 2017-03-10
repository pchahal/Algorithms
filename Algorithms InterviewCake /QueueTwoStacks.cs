using System;
using System.Collections.Generic;


class QueueTwoStacks<T> where T:new()
{
    Stack<T> forwardStack= new Stack<T>();
    Stack<T> reverseStack= new Stack<T>();

     public void Enqueue(T item)
    {
        if (reverseStack.Count==0)
        {
            forwardStack.Push(item);
        }
        else
        {
            while (reverseStack.Count>0)
            {
                T data= reverseStack.Pop();
                forwardStack.Push(data);
            }
            forwardStack.Push(item);
        }
        
    }

    public T Dequeue()
    {
        
        if (forwardStack.Count==0)
        {
            return reverseStack.Pop();
        }        
         else
        {
            while (forwardStack.Count>0)
            {
                T item= forwardStack.Pop();
                reverseStack.Push(item);                              
            }
            return reverseStack.Pop();
        }

        
     
    }

public override string ToString() 
{
    string str="FORWARD ";
    foreach (var s in forwardStack)
    {
        str+= s.ToString()+",";
    }

    str+="\nREVERSE ";
    foreach (var s in reverseStack)
    {
        str+= s.ToString()+",";
    }
    return str;
}

}