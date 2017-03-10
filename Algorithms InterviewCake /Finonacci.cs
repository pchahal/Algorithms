using System;
/*
fib(0); // => 0
fib(1); // => 1
fib(2); // => 1
fib(3); // => 2
fib(4); // => 3

0,1,1,2,3,5
*/

class Solution
{
   
}


public class Fibonacci  
{
    public int fib(int n)
    {
        if (n<=1)
            return n;
        
        
        int prevSum=1;
        int prevPrevSum=0;
        
        for  (int i=2;i<n;i++)
        {
            int newSum= prevPrevSum+ prevSum;
            prevPrevSum=prevSum;
            
            prevSum=newSum;
            Console.WriteLine(prevSum);
        }
        
        return prevSum+prevPrevSum;
        
    }
    
}