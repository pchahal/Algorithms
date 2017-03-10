using System;

namespace CTCI
{
    // given 2 strings is one a permutaion of other 
class CheckPermutation
{
    public bool isPermutation(string s1, string s2)
    {
            int[] array = new int[256];
            if (s1.Length!=s2.Length)
            return false;

        foreach (var c in s1)
        {
                array[c]++;
        }

        foreach (var c in s2)
        {
                array[c]--;
                if (array[c]<0)
                    return false;
            }
        
        return true;
    }

    public void Test()
    {
       Console.WriteLine( isPermutation("abc", "cba"));
    }
}
}