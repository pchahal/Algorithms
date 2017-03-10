using System;
using System.Collections.Generic;
using System.Linq;

public class WhichAppearsTwice
{
    //I have an array where every number in the range 1...n1...n appears once 
    //except for one number which appears twice.
    //Write a function for finding the number that appears twice.
    //{1,2,4,5,6,7,8,9,5});
    //1,2,3,2
    public int whichAppearsTwice(int[] array)
    {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        int i = 0;
        while(i<array.Length)
        {
            if  (dict.ContainsKey(array[i]))
                return array[i];
            else
                dict[array[i]] = 1;

            i++;
        }

        return dict.Keys.First();
    }
}