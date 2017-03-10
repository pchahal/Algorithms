using System;
using System.Collections.Generic;

namespace Algorithms
{
    //check if a expressison is well formed
    //IE   //[(ABC {DEF}[XYZ (LMN)]  is false
    public class WellFormedExpression
    {
        Dictionary<string,string> openingBrackets = new Dictionary<string,string>
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
        Dictionary<string,string> closingBrackets = new Dictionary<string,string>
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
                    if (closingBrackets [item.ToString()] == prevBracket)
                        continue;
                    else
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}

