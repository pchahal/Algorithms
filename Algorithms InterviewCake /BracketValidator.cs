using System;
using System.Collections.Generic;
//Write an efficient function that tells us whether or not an input string's
// openers and closers are properly nested.

//"{ [ ] ( ) }" should return true
//"{ [ ( ] ) }" should return false
//"{ [ }" should return false
//[(ABC {DEF}[XYZ (LMN)]
public class BracketValidator
{
    Dictionary<string, string> openingBrackets = new Dictionary<string, string>
        {
            {
                "(",
                ")"
            },
            {
                "[",
                "]"
            },
            {
                "{",
                "}"
            },
        };
    Dictionary<string, string> closingBrackets = new Dictionary<string, string>
        {
            {
                ")",
                "("
            },
            {
                "]",
                "["
            },
            {
                "}",
                "{"
            },
        };

    

    public bool isWellFormedExpression(string expr)
    {
        Stack<string> stack = new Stack<string>();

        foreach (var item in expr)
        {
            if (openingBrackets.ContainsKey(item.ToString()))
                stack.Push(item.ToString());
            else if (closingBrackets.ContainsKey(item.ToString()))
            {
                string prevBracket = stack.Pop();
                if (closingBrackets[item.ToString()] == prevBracket)
                    continue;
                else
                    return false;
            }

        }

        return stack.Count == 0;
    }
}


