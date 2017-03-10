using System;
using System.Collections.Generic;

namespace Algorithms
{
    //Add two numbers without using math operators
    public class AddTwoNumbers
    {
        public List<int> Add(List<int> num1, List<int> num2)
        {
            List<int> sum = new List<int>();

            int digits = 0;
            if (num1.Count > num2.Count)
                digits = num1.Count;
            else
                digits = num2.Count;

            int i = digits;
            int carry = 0;
            while (digits > 0)
            {
                int number = num1 [digits - 1] + num2 [digits - 1] + carry;
                if (number > 9)
                {
                    number = number - 10;
                    carry = 1;
                }
                sum.Insert(sum.Count, number);    
                digits--;
            }
                
            return sum;
        }
    }
}

