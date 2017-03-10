

using System;
using System.Collections.Generic;

namespace Algorithms
{

    public class ReversePolishNotation
    {
        public static int reversePolishNotation(string[] array)
        {
            Stack<int> stack = new Stack<int>();
            string ops = "+-*/";
            int num1, num2, sum = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (ops.Contains(array[i]))
                {
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    if (array[i] == "+")
                        sum = num1 + num2;
                    else if (array[i] == "-")
                        sum = num1 - num2;
                    else if (array[i] == "*")
                        sum = num1 * num2;
                    else if (array[i] == "/")
                        sum = num2 / num1;
                    stack.Push(sum);


                }
                else
                {
                    int.TryParse(array[i], out num1);
                    stack.Push(num1);
                }
            }
            return stack.Pop();
        }
    }
}
