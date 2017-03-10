using System;

namespace CTCI
{
class IsUnique 
{
    public bool isUnique(string word)
    {
        int[] array = new int[256];;

        

        foreach (var c in word)
        {
            if (array[c] == 1)
            {
                return false;
                
            }
            else
                array[c] = 1;
        }

        return true;
    }

    public void Test()
    {
        Console.WriteLine(isUnique("cabc"));
    }
}
}