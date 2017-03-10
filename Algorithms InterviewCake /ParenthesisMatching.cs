using System;
using System.Collections.Generic;

//"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing."
//Write a function that, given a sentence like the one above,
// along with the position of an opening parenthesis,
//finds the corresponding closing parenthesis.

//Example: if the example string above is input with the number 10 
//(position of the first parenthesis), the output should be 79 
//(position of the last parenthesis).
//  "na(is (par))"
public class ParenthesisMatching
{
    Stack<int> stack = new Stack<int>();
    public int getMatching(string sentence, int openingBracket)
    {       
        int i = 0;
        while (i < sentence.Length)
        {
            if (sentence[i] == '(')
            {
                stack.Push(i);
            }
            if (sentence[i] == ')')
            {
                int  bracketOnStack=stack.Pop();
                if (bracketOnStack==openingBracket)
                    return i;
            }
            i++;
        }
        return 0;
    }
}