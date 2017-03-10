using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Palindrome
    {
      public static bool isPalindrome(string inputStr)
        {
            int head = 0; 
            int tail = inputStr.Length - 1;

            while (head < tail)
            {
                Console.WriteLine(inputStr [head] + "==" + inputStr [tail]);

                if (inputStr [tail] != inputStr [head])
                    return false;
                head++;
                tail--;

                if (inputStr [head] == ' ')
                    head++;
                if (inputStr [tail] == ' ')
                    tail--;
                    
            }
            return true;
        }
    }
}

