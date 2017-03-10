using System;
using System.Collections.Generic;

//Use the built-in Stack class to implement a new class MaxStack
// with a function getMax() that returns the largest element in the stack. 
//getMax() should not remove the item.
//Your stacks will contain only integers.
public class LargestStack
{   
    Stack <int> stack= new Stack<int>();
    int currentMax=0;
    //    3
    //    5
    //    1
    public int getMax()
    {
        

        return stack.Peek();
    }

    public int Pop()
    {
        return stack.Pop();
    }
    public void Push(int data)
    {  
        if (stack.Count>0)
        {
              
              if (stack.Peek()>data)
                {
                    int stackTop=stack.Pop();
                    stack.Push(data);
                    stack.Push(stackTop);
                }
                else
                     stack.Push(data);
                              
        }
        else
            stack.Push(data);
    }

/*public override string ToString()
{
    string s ="";

    stack.ToString();

    return s;
}*/
    
}