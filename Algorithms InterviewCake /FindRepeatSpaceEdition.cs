using System;

public class FindRepeatSpaceEdition
{

    //this may be nsquared cause current.contains is o(n), if array was sorted can do binary search instead
    public int FindDuplicate(int[] array)
    {
        string current = "";

        foreach (var num in array)
        {
            
            
            if (current.Contains(num.ToString()))
                return num;
            current += num;
        }

        return -1;
    }
}