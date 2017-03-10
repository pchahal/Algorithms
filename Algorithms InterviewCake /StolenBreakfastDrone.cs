using System;
using System.Collections.Generic;
using System.Linq;
class StolenBreakfastDrone
{
   // Given the array of IDs, which contains many duplicate integers and 
   //one unique integer, find the unique integer.
    //       1,2,3,4,5,1,2,3,5
    public int FindUnique(int [] array)
    {
        
        Dictionary <int,int> uniques = new Dictionary<int,int>();

        foreach (var id in array)
        {
            if (uniques.ContainsKey(id))
            {
                uniques.Remove(id);

            }
            else
             uniques[id]=1;
        }


        return uniques.Keys.First();
        
    }
}