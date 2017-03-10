using System;
using System.Collections.Generic;

namespace Algorithms
{

    //implement a stack with a getMin function runs in o(1)
    public class FindMinInStack
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        public int FindMin()
        {
            return  minStack.Peek(); 
        }

        public void Push(int num)
        {
            stack.Push(num);
            int currentMin = 0;
            if (minStack.Count > 0)
                currentMin = minStack.Peek();

            if (num < currentMin || minStack.Count == 0)
                currentMin = num;

            minStack.Push(currentMin);

        }

        public int Pop()
        {            
            int num = stack.Pop();
            minStack.Pop();
            return num;
        }

    }
}

