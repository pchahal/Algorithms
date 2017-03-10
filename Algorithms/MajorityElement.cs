using System;
using System.Collections.Generic;



namespace Algorithms
{
    public class Solution
    {
        //how many ways to climb n stairs, with 1 or 2 step jumps
        public static int climbStairs(int A)
        {
            if (A <= 0)
                return 1;

            if (A == 1)
                return 1;
            int sum = 0;

            sum += climbStairs(A - 1);
            sum += climbStairs(A - 2);
            return sum;
        }

        //COUNT how many on bits in number
        public  int  numSetBits(uint A)
        {
            int size = sizeof(int) * 8;
            int numBitsOn = 0;

            for (int i = 0; i < size; i++)
            {
                uint B = A & (1u << i);
                if (B > 0)
                    numBitsOn++;
            }
            return numBitsOn;
        }
      
        public  class ListNode
        {
            public int val;
            public ListNode next;

            public  ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        //given an array , return item with most occuorrences
        public static int majorityElement(List<int> A)
        {            
            int majorityOccurence = (int)Math.Floor(A.Count / 2f);
            int i;
            Dictionary <int,int> occurrences = new Dictionary<int, int>();

            if (A.Count == 1)
                return A [0];

            for (i = 0; i < A.Count; i++)
            {
                if (occurrences.ContainsKey(A [i]))
                {
                    occurrences [A [i]] = occurrences [A [i]] + 1;
                 
                } else
                {
                    occurrences [A [i]] = 1;
                }

                if (occurrences [A [i]] > majorityOccurence)
                    break;
            }

            return A [i];

        }
    }
}