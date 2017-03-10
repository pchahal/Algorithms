using System;
using System.Collections.Generic;

namespace CTCI
{
    class RotationalSymmetry
    {
        public bool isSymmetric(int[] input)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>() { { 0, 0 }, { 6, 9 }, { 8, 8 }, { 9, 6 } };

            int i = 0; int j = input.Length - 1;
            int value = 0;
            while (i < j)
            {
                bool foundKey = dict.ContainsKey(input[j]);
                if (foundKey)
                {
                    value = dict[input[j]];
                    if (input[i] == value)
                    {
                        i++;
                        j--;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

        public void Test()
        {
            Console.WriteLine(isSymmetric(new int[] { 0, 8, 9, 1, 6, 8, 0 }));
            Console.WriteLine(isSymmetric(new int[] { 6, 8, 8, 5 }));
        }
    }
}